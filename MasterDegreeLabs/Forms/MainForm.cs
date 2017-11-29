using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MasterDegreeLabs.Forms
{
    public partial class MainForm : Form
    {
        private const string StopWords = "StopWords.txt";
        private static readonly Regex WordRegex = new Regex("\\W+");
        private static readonly Dictionary<string, int> KeyWords = new Dictionary<string, int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> OrderedKeyWords => KeyWords.OrderByDescending(pair => pair.Value).Take(20)
            .ToDictionary(pair => pair.Key, pair => pair.Value);

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            KeyWords.Clear();
            if (ucText.TextLength == 0)
            {
                return;
            }

            var stopWords = GetStopWords();
            var text = ucText.Text;
            var split = WordRegex.Split(text);
            var stopWordsExist = stopWords.Count != 0;

            foreach (var word in split)
            {
                var lowerWord = word.ToLower();

                if (stopWordsExist)
                {
                    if (stopWords.Contains(lowerWord))
                    {
                        continue;
                    }
                }
                else if (lowerWord.Length <= ucPrepositionLength.Value)
                {
                    continue;
                }

                if (KeyWords.ContainsKey(lowerWord))
                {
                    KeyWords[lowerWord]++;
                    continue;
                }

                KeyWords.Add(lowerWord, 1);
            }

            foreach (var ucChartSeries in ucChart.Series)
            {
                ucChartSeries.Points.Clear();
            }

            ucChart.Series.Clear();

            var series = new Series();

            var index = 1;
            foreach (var kvp in OrderedKeyWords)
            {
                var dataPoint = new DataPoint(index, kvp.Value)
                {
                    Label = $"{kvp.Key} - {Convert.ToDecimal(kvp.Value) / split.Length:F4}"
                };
                series.Points.Add(dataPoint);
                index++;
            }

            ucChart.Series.Add(series);
        }

        private IList<string> GetStopWords()
        {
            var path = $"{Environment.CurrentDirectory}\\{StopWords}";
            return !File.Exists(path) ? new List<string>() : File.ReadAllLines(path).ToList();
        }

        private async void ucEssey_Click(object sender, EventArgs e)
        {
            if (ucText.Text.Length == 0 || KeyWords.Count == 0)
            {
                return;
            }

            var startIndex = Convert.ToInt32(ucStartWord.Value) - 1;
            var endIndex = Convert.ToInt32(ucEndKeyWord.Value) - 1;
            var wordsPerSentence = Convert.ToInt32(ucWordsPerSentence.Value);
            var keyWords = OrderedKeyWords.Skip(startIndex).Take(endIndex - startIndex).Select(pair => pair.Key)
                .ToList();

            var text = ucText.Text;
            var splitBySentences = text.Split('.');
            var sentences = splitBySentences.Where(sentence =>
                keyWords.Count(s => sentence.ToLowerInvariant().Contains(s)) >= wordsPerSentence).ToList();

            var path = $"{Environment.CurrentDirectory}\\{DateTime.Now.Date:yy-MM-dd}_{DateTime.Now:HH_mm_ss}.txt";
            using (var fileStream = File.CreateText(path))
            {
                foreach (var sentence in sentences)
                {
                    await fileStream.WriteLineAsync($"{sentence.TrimEnd()}.");
                }

                fileStream.Close();
            }

            try
            {
                Process.Start(path);
            }
            catch
            {
                // ignored
            }
        }
    }
}