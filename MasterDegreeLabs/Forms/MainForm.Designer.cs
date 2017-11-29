namespace MasterDegreeLabs.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ucText = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.ucChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ucPrepositionLength = new System.Windows.Forms.NumericUpDown();
            this.ucEssey = new System.Windows.Forms.Button();
            this.ucStartWord = new System.Windows.Forms.NumericUpDown();
            this.ucEndKeyWord = new System.Windows.Forms.NumericUpDown();
            this.ucWordsPerSentence = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ucChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPrepositionLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucStartWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucEndKeyWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucWordsPerSentence)).BeginInit();
            this.SuspendLayout();
            // 
            // ucText
            // 
            this.ucText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ucText.Location = new System.Drawing.Point(12, 12);
            this.ucText.Name = "ucText";
            this.ucText.Size = new System.Drawing.Size(380, 476);
            this.ucText.TabIndex = 0;
            this.ucText.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(398, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Посчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ucChart
            // 
            this.ucChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ucChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ucChart.Legends.Add(legend1);
            this.ucChart.Location = new System.Drawing.Point(494, 12);
            this.ucChart.Name = "ucChart";
            this.ucChart.Size = new System.Drawing.Size(831, 476);
            this.ucChart.TabIndex = 2;
            this.ucChart.Text = "chart1";
            // 
            // ucPrepositionLength
            // 
            this.ucPrepositionLength.Location = new System.Drawing.Point(398, 41);
            this.ucPrepositionLength.Name = "ucPrepositionLength";
            this.ucPrepositionLength.Size = new System.Drawing.Size(90, 20);
            this.ucPrepositionLength.TabIndex = 3;
            // 
            // ucEssey
            // 
            this.ucEssey.Location = new System.Drawing.Point(398, 67);
            this.ucEssey.Name = "ucEssey";
            this.ucEssey.Size = new System.Drawing.Size(90, 23);
            this.ucEssey.TabIndex = 4;
            this.ucEssey.Text = "Реферат";
            this.ucEssey.UseVisualStyleBackColor = true;
            this.ucEssey.Click += new System.EventHandler(this.ucEssey_Click);
            // 
            // ucStartWord
            // 
            this.ucStartWord.Location = new System.Drawing.Point(398, 96);
            this.ucStartWord.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.ucStartWord.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucStartWord.Name = "ucStartWord";
            this.ucStartWord.Size = new System.Drawing.Size(90, 20);
            this.ucStartWord.TabIndex = 5;
            this.ucStartWord.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ucEndKeyWord
            // 
            this.ucEndKeyWord.Location = new System.Drawing.Point(398, 122);
            this.ucEndKeyWord.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ucEndKeyWord.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ucEndKeyWord.Name = "ucEndKeyWord";
            this.ucEndKeyWord.Size = new System.Drawing.Size(90, 20);
            this.ucEndKeyWord.TabIndex = 6;
            this.ucEndKeyWord.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // ucWordsPerSentence
            // 
            this.ucWordsPerSentence.Location = new System.Drawing.Point(398, 163);
            this.ucWordsPerSentence.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ucWordsPerSentence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucWordsPerSentence.Name = "ucWordsPerSentence";
            this.ucWordsPerSentence.Size = new System.Drawing.Size(90, 20);
            this.ucWordsPerSentence.TabIndex = 7;
            this.ucWordsPerSentence.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 503);
            this.Controls.Add(this.ucWordsPerSentence);
            this.Controls.Add(this.ucEndKeyWord);
            this.Controls.Add(this.ucStartWord);
            this.Controls.Add(this.ucEssey);
            this.Controls.Add(this.ucPrepositionLength);
            this.Controls.Add(this.ucChart);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.ucText);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ucChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPrepositionLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucStartWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucEndKeyWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucWordsPerSentence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ucText;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart ucChart;
        private System.Windows.Forms.NumericUpDown ucPrepositionLength;
        private System.Windows.Forms.Button ucEssey;
        private System.Windows.Forms.NumericUpDown ucStartWord;
        private System.Windows.Forms.NumericUpDown ucEndKeyWord;
        private System.Windows.Forms.NumericUpDown ucWordsPerSentence;
    }
}