namespace BootcampCoreServices
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxRaports = new System.Windows.Forms.ComboBox();
            this.labelRaports = new System.Windows.Forms.Label();
            this.buttonGenerateRaport = new System.Windows.Forms.Button();
            this.labelClientId = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelRange = new System.Windows.Forms.Label();
            this.textBoxRangeMin = new System.Windows.Forms.TextBox();
            this.labelRangeSplit = new System.Windows.Forms.Label();
            this.textBoxRangeMax = new System.Windows.Forms.TextBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.comboBoxSortType = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBoxRaports
            // 
            this.comboBoxRaports.AutoCompleteCustomSource.AddRange(new string[] {
            "a. Ilość zamówień",
            "b. Ilość zamówień dla klienta o wskazanym identyfikatorze",
            "c. Łączna kwota zamówień",
            "d. Łączna kwota zamówień dla klienta o wskazanym identyfikatorze",
            "e. Lista wszystkich zamówień",
            "f. Lista zamówień dla klienta o wskazanym identyfikatorze",
            "g. Średnia wartość zamówienia",
            "h. Średnia wartość zamówienia dla klienta o wskazanym identyfikatorze",
            "i. Ilość zamówień pogrupowanych po nazwie",
            "j. Ilość zamówień pogrupowanych po nazwie dla klienta o wskazanym identyfikatorze" +
                "",
            "k. Zamówienia w podanym przedziale cenowym"});
            this.comboBoxRaports.Items.AddRange(new object[] {
            "a. Ilość zamówień",
            "b. Ilość zamówień dla klienta o wskazanym identyfikatorze",
            "c. Łączna kwota zamówień",
            "d. Łączna kwota zamówień dla klienta o wskazanym identyfikatorze",
            "e. Lista wszystkich zamówień",
            "f. Lista zamówień dla klienta o wskazanym identyfikatorze",
            "g. Średnia wartość zamówienia",
            "h. Średnia wartość zamówienia dla klienta o wskazanym identyfikatorze",
            "i. Ilość zamówień pogrupowanych po nazwie",
            "j. Ilość zamówień pogrupowanych po nazwie dla klienta o wskazanym identyfikatorze" +
                "",
            "k. Zamówienia w podanym przedziale cenowym"});
            this.comboBoxRaports.Location = new System.Drawing.Point(91, 12);
            this.comboBoxRaports.Name = "comboBoxRaports";
            this.comboBoxRaports.Size = new System.Drawing.Size(251, 21);
            this.comboBoxRaports.TabIndex = 0;
            this.comboBoxRaports.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // labelRaports
            // 
            this.labelRaports.AutoSize = true;
            this.labelRaports.Location = new System.Drawing.Point(12, 15);
            this.labelRaports.Name = "labelRaports";
            this.labelRaports.Size = new System.Drawing.Size(73, 13);
            this.labelRaports.TabIndex = 1;
            this.labelRaports.Text = "Lista raportow";
            // 
            // buttonGenerateRaport
            // 
            this.buttonGenerateRaport.Location = new System.Drawing.Point(348, 10);
            this.buttonGenerateRaport.Name = "buttonGenerateRaport";
            this.buttonGenerateRaport.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateRaport.TabIndex = 2;
            this.buttonGenerateRaport.Text = "Generuj";
            this.buttonGenerateRaport.UseVisualStyleBackColor = true;
            this.buttonGenerateRaport.Click += new System.EventHandler(this.buttonGenerateRaport_Click);
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(12, 42);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(52, 13);
            this.labelClientId.TabIndex = 3;
            this.labelClientId.Text = "ID klienta";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(91, 39);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientId.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 95);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(411, 340);
            this.dataGridView.TabIndex = 5;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(197, 42);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(70, 13);
            this.labelRange.TabIndex = 6;
            this.labelRange.Text = "Przedzial cen";
            // 
            // textBoxRangeMin
            // 
            this.textBoxRangeMin.Location = new System.Drawing.Point(273, 39);
            this.textBoxRangeMin.Name = "textBoxRangeMin";
            this.textBoxRangeMin.Size = new System.Drawing.Size(59, 20);
            this.textBoxRangeMin.TabIndex = 7;
            // 
            // labelRangeSplit
            // 
            this.labelRangeSplit.AutoSize = true;
            this.labelRangeSplit.Location = new System.Drawing.Point(338, 43);
            this.labelRangeSplit.Name = "labelRangeSplit";
            this.labelRangeSplit.Size = new System.Drawing.Size(13, 13);
            this.labelRangeSplit.TabIndex = 9;
            this.labelRangeSplit.Text = "--";
            // 
            // textBoxRangeMax
            // 
            this.textBoxRangeMax.Location = new System.Drawing.Point(357, 40);
            this.textBoxRangeMax.Name = "textBoxRangeMax";
            this.textBoxRangeMax.Size = new System.Drawing.Size(57, 20);
            this.textBoxRangeMax.TabIndex = 10;
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(91, 65);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSort.TabIndex = 11;
            // 
            // comboBoxSortType
            // 
            this.comboBoxSortType.FormattingEnabled = true;
            this.comboBoxSortType.Items.AddRange(new object[] {
            "Malejaco",
            "Rosnaco"});
            this.comboBoxSortType.Location = new System.Drawing.Point(218, 65);
            this.comboBoxSortType.Name = "comboBoxSortType";
            this.comboBoxSortType.Size = new System.Drawing.Size(96, 21);
            this.comboBoxSortType.TabIndex = 12;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(12, 68);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(26, 13);
            this.labelSort.TabIndex = 13;
            this.labelSort.Text = "Sort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 447);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.comboBoxSortType);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.textBoxRangeMax);
            this.Controls.Add(this.labelRangeSplit);
            this.Controls.Add(this.textBoxRangeMin);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.labelClientId);
            this.Controls.Add(this.buttonGenerateRaport);
            this.Controls.Add(this.labelRaports);
            this.Controls.Add(this.comboBoxRaports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxRaports;
        private System.Windows.Forms.Label labelRaports;
        private System.Windows.Forms.Button buttonGenerateRaport;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.TextBox textBoxRangeMin;
        private System.Windows.Forms.Label labelRangeSplit;
        private System.Windows.Forms.TextBox textBoxRangeMax;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxSortType;
        private System.Windows.Forms.Label labelSort;
    }
}

