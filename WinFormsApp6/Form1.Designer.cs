namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DebugWindow = new System.Windows.Forms.RichTextBox();
            this.pobierz = new System.Windows.Forms.Button();
            this.USDTextBox = new System.Windows.Forms.TextBox();
            this.EURTextBox = new System.Windows.Forms.TextBox();
            this.HUFTextBox = new System.Windows.Forms.TextBox();
            this.label1USD = new System.Windows.Forms.Label();
            this.label2EUR = new System.Windows.Forms.Label();
            this.label3HUF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.TextCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DebugWindow
            // 
            this.DebugWindow.Location = new System.Drawing.Point(12, 256);
            this.DebugWindow.Name = "DebugWindow";
            this.DebugWindow.Size = new System.Drawing.Size(776, 182);
            this.DebugWindow.TabIndex = 0;
            this.DebugWindow.Text = "";
            // 
            // pobierz
            // 
            this.pobierz.Location = new System.Drawing.Point(12, 146);
            this.pobierz.Name = "pobierz";
            this.pobierz.Size = new System.Drawing.Size(134, 24);
            this.pobierz.TabIndex = 1;
            this.pobierz.Text = "Pobierz";
            this.pobierz.UseVisualStyleBackColor = true;
            this.pobierz.Click += new System.EventHandler(this.pobierz_Click);
            // 
            // USDTextBox
            // 
            this.USDTextBox.Location = new System.Drawing.Point(12, 43);
            this.USDTextBox.Name = "USDTextBox";
            this.USDTextBox.Size = new System.Drawing.Size(100, 23);
            this.USDTextBox.TabIndex = 3;
            // 
            // EURTextBox
            // 
            this.EURTextBox.Location = new System.Drawing.Point(12, 76);
            this.EURTextBox.Name = "EURTextBox";
            this.EURTextBox.Size = new System.Drawing.Size(100, 23);
            this.EURTextBox.TabIndex = 4;
            // 
            // HUFTextBox
            // 
            this.HUFTextBox.Location = new System.Drawing.Point(12, 106);
            this.HUFTextBox.Name = "HUFTextBox";
            this.HUFTextBox.Size = new System.Drawing.Size(100, 23);
            this.HUFTextBox.TabIndex = 5;
            // 
            // label1USD
            // 
            this.label1USD.AutoSize = true;
            this.label1USD.Location = new System.Drawing.Point(118, 46);
            this.label1USD.Name = "label1USD";
            this.label1USD.Size = new System.Drawing.Size(32, 15);
            this.label1USD.TabIndex = 6;
            this.label1USD.Text = "USD ";
            // 
            // label2EUR
            // 
            this.label2EUR.AutoSize = true;
            this.label2EUR.Location = new System.Drawing.Point(118, 79);
            this.label2EUR.Name = "label2EUR";
            this.label2EUR.Size = new System.Drawing.Size(28, 15);
            this.label2EUR.TabIndex = 7;
            this.label2EUR.Text = "EUR";
            this.label2EUR.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3HUF
            // 
            this.label3HUF.AutoSize = true;
            this.label3HUF.Location = new System.Drawing.Point(117, 109);
            this.label3HUF.Name = "label3HUF";
            this.label3HUF.Size = new System.Drawing.Size(30, 15);
            this.label3HUF.TabIndex = 8;
            this.label3HUF.Text = "HUF";
            this.label3HUF.Click += new System.EventHandler(this.label3HUN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kwota PLN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(303, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "USD";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.Exchange);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(303, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 19);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "EUR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.Exchange);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(303, 114);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 19);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "HUF";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.Exchange);
            // 
            // TextCount
            // 
            this.TextCount.Location = new System.Drawing.Point(356, 63);
            this.TextCount.Name = "TextCount";
            this.TextCount.Size = new System.Drawing.Size(100, 23);
            this.TextCount.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextCount);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3HUF);
            this.Controls.Add(this.label2EUR);
            this.Controls.Add(this.label1USD);
            this.Controls.Add(this.HUFTextBox);
            this.Controls.Add(this.EURTextBox);
            this.Controls.Add(this.USDTextBox);
            this.Controls.Add(this.pobierz);
            this.Controls.Add(this.DebugWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox DebugWindow;
        private Button pobierz;
        private TextBox USDTextBox;
        private TextBox EURTextBox;
        private TextBox HUFTextBox;
        private Label label1USD;
        private Label label2EUR;
        private Label label3HUF;
        private Label label1;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox TextCount;
    }
}