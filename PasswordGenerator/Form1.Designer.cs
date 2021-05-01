
namespace PasswordGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.latinSmall = new System.Windows.Forms.CheckBox();
            this.latinBig = new System.Windows.Forms.CheckBox();
            this.cyrillicSmall = new System.Windows.Forms.CheckBox();
            this.cyrillicBig = new System.Windows.Forms.CheckBox();
            this.numbers = new System.Windows.Forms.CheckBox();
            this.symbols = new System.Windows.Forms.CheckBox();
            this.passwordLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordResultBox = new System.Windows.Forms.GroupBox();
            this.copyLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.passwordResultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // latinSmall
            // 
            this.latinSmall.AutoSize = true;
            this.latinSmall.Location = new System.Drawing.Point(25, 49);
            this.latinSmall.Margin = new System.Windows.Forms.Padding(4);
            this.latinSmall.Name = "latinSmall";
            this.latinSmall.Size = new System.Drawing.Size(186, 25);
            this.latinSmall.TabIndex = 0;
            this.latinSmall.Text = "Латинские маленькие";
            this.latinSmall.UseVisualStyleBackColor = true;
            // 
            // latinBig
            // 
            this.latinBig.AutoSize = true;
            this.latinBig.Location = new System.Drawing.Point(25, 82);
            this.latinBig.Margin = new System.Windows.Forms.Padding(4);
            this.latinBig.Name = "latinBig";
            this.latinBig.Size = new System.Drawing.Size(173, 25);
            this.latinBig.TabIndex = 1;
            this.latinBig.Text = "Латинские большие";
            this.latinBig.UseVisualStyleBackColor = true;
            // 
            // cyrillicSmall
            // 
            this.cyrillicSmall.AutoSize = true;
            this.cyrillicSmall.Location = new System.Drawing.Point(235, 49);
            this.cyrillicSmall.Margin = new System.Windows.Forms.Padding(4);
            this.cyrillicSmall.Name = "cyrillicSmall";
            this.cyrillicSmall.Size = new System.Drawing.Size(189, 25);
            this.cyrillicSmall.TabIndex = 2;
            this.cyrillicSmall.Text = "Кириллица маленькие";
            this.cyrillicSmall.UseVisualStyleBackColor = true;
            // 
            // cyrillicBig
            // 
            this.cyrillicBig.AutoSize = true;
            this.cyrillicBig.Location = new System.Drawing.Point(235, 82);
            this.cyrillicBig.Margin = new System.Windows.Forms.Padding(4);
            this.cyrillicBig.Name = "cyrillicBig";
            this.cyrillicBig.Size = new System.Drawing.Size(176, 25);
            this.cyrillicBig.TabIndex = 3;
            this.cyrillicBig.Text = "Кириллица большие";
            this.cyrillicBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cyrillicBig.UseVisualStyleBackColor = true;
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Location = new System.Drawing.Point(25, 115);
            this.numbers.Margin = new System.Windows.Forms.Padding(4);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(81, 25);
            this.numbers.TabIndex = 4;
            this.numbers.Text = "Цифры";
            this.numbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numbers.UseVisualStyleBackColor = true;
            // 
            // symbols
            // 
            this.symbols.AutoSize = true;
            this.symbols.Location = new System.Drawing.Point(235, 115);
            this.symbols.Margin = new System.Windows.Forms.Padding(4);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(95, 25);
            this.symbols.TabIndex = 5;
            this.symbols.Text = "Символы";
            this.symbols.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.symbols.UseVisualStyleBackColor = true;
            // 
            // passwordLength
            // 
            this.passwordLength.Location = new System.Drawing.Point(309, 39);
            this.passwordLength.Margin = new System.Windows.Forms.Padding(4);
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(87, 29);
            this.passwordLength.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Укажите желаемую длину пароля: ";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(18, 44);
            this.resultBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(293, 29);
            this.resultBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Копировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.latinSmall);
            this.groupBox1.Controls.Add(this.latinBig);
            this.groupBox1.Controls.Add(this.cyrillicSmall);
            this.groupBox1.Controls.Add(this.cyrillicBig);
            this.groupBox1.Controls.Add(this.numbers);
            this.groupBox1.Controls.Add(this.symbols);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 177);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Содержимое пароля";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.passwordLength);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры пароля";
            // 
            // passwordResultBox
            // 
            this.passwordResultBox.Controls.Add(this.resultBox);
            this.passwordResultBox.Controls.Add(this.button2);
            this.passwordResultBox.Location = new System.Drawing.Point(13, 373);
            this.passwordResultBox.Name = "passwordResultBox";
            this.passwordResultBox.Size = new System.Drawing.Size(447, 100);
            this.passwordResultBox.TabIndex = 15;
            this.passwordResultBox.TabStop = false;
            this.passwordResultBox.Text = "Результат";
            // 
            // copyLabel
            // 
            this.copyLabel.AutoSize = true;
            this.copyLabel.Location = new System.Drawing.Point(177, 483);
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(112, 21);
            this.copyLabel.TabIndex = 16;
            this.copyLabel.Text = "Скопировано!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(472, 513);
            this.Controls.Add(this.copyLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.passwordResultBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Angry Coder Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.passwordResultBox.ResumeLayout(false);
            this.passwordResultBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox latinSmall;
        private System.Windows.Forms.CheckBox latinBig;
        private System.Windows.Forms.CheckBox cyrillicSmall;
        private System.Windows.Forms.CheckBox cyrillicBig;
        private System.Windows.Forms.CheckBox numbers;
        private System.Windows.Forms.CheckBox symbols;
        private System.Windows.Forms.TextBox passwordLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox passwordResultBox;
        private System.Windows.Forms.Label copyLabel;
    }
}

