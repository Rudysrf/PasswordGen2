namespace Генератор_паролей
{
    partial class FormSetting
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
            this.rbtnEnglish = new System.Windows.Forms.RadioButton();
            this.rbtnRussian = new System.Windows.Forms.RadioButton();
            this.cboxSymvol = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLengthPassword = new System.Windows.Forms.Label();
            this.cboxLengthPassword = new System.Windows.Forms.ComboBox();
            this.lblBukv = new System.Windows.Forms.Label();
            this.cboxBukv = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tboxPasswordManual = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnEnglish
            // 
            this.rbtnEnglish.AutoSize = true;
            this.rbtnEnglish.Location = new System.Drawing.Point(32, 37);
            this.rbtnEnglish.Name = "rbtnEnglish";
            this.rbtnEnglish.Size = new System.Drawing.Size(114, 17);
            this.rbtnEnglish.TabIndex = 0;
            this.rbtnEnglish.TabStop = true;
            this.rbtnEnglish.Text = "Английский язык";
            this.rbtnEnglish.UseVisualStyleBackColor = true;
            // 
            // rbtnRussian
            // 
            this.rbtnRussian.AutoSize = true;
            this.rbtnRussian.Location = new System.Drawing.Point(167, 37);
            this.rbtnRussian.Name = "rbtnRussian";
            this.rbtnRussian.Size = new System.Drawing.Size(96, 17);
            this.rbtnRussian.TabIndex = 1;
            this.rbtnRussian.TabStop = true;
            this.rbtnRussian.Text = "Русский язык";
            this.rbtnRussian.UseVisualStyleBackColor = true;
            // 
            // cboxSymvol
            // 
            this.cboxSymvol.AutoSize = true;
            this.cboxSymvol.Location = new System.Drawing.Point(32, 75);
            this.cboxSymvol.Name = "cboxSymvol";
            this.cboxSymvol.Size = new System.Drawing.Size(201, 17);
            this.cboxSymvol.TabIndex = 2;
            this.cboxSymvol.Text = "Наличие спецсимволов _^@ и т.п.";
            this.cboxSymvol.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор языка:";
            // 
            // lblLengthPassword
            // 
            this.lblLengthPassword.AutoSize = true;
            this.lblLengthPassword.Location = new System.Drawing.Point(29, 104);
            this.lblLengthPassword.Name = "lblLengthPassword";
            this.lblLengthPassword.Size = new System.Drawing.Size(85, 13);
            this.lblLengthPassword.TabIndex = 4;
            this.lblLengthPassword.Text = "Длинна пароля";
            // 
            // cboxLengthPassword
            // 
            this.cboxLengthPassword.FormattingEnabled = true;
            this.cboxLengthPassword.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboxLengthPassword.Location = new System.Drawing.Point(32, 129);
            this.cboxLengthPassword.Name = "cboxLengthPassword";
            this.cboxLengthPassword.Size = new System.Drawing.Size(64, 21);
            this.cboxLengthPassword.TabIndex = 5;
            this.cboxLengthPassword.Text = "6";
            // 
            // lblBukv
            // 
            this.lblBukv.AutoSize = true;
            this.lblBukv.Location = new System.Drawing.Point(164, 104);
            this.lblBukv.Name = "lblBukv";
            this.lblBukv.Size = new System.Drawing.Size(67, 13);
            this.lblBukv.TabIndex = 6;
            this.lblBukv.Text = "Из них букв";
            // 
            // cboxBukv
            // 
            this.cboxBukv.FormattingEnabled = true;
            this.cboxBukv.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboxBukv.Location = new System.Drawing.Point(167, 129);
            this.cboxBukv.Name = "cboxBukv";
            this.cboxBukv.Size = new System.Drawing.Size(64, 21);
            this.cboxBukv.TabIndex = 7;
            this.cboxBukv.Text = "2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Гененрировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tboxPasswordManual
            // 
            this.tboxPasswordManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxPasswordManual.Location = new System.Drawing.Point(32, 185);
            this.tboxPasswordManual.Name = "tboxPasswordManual";
            this.tboxPasswordManual.Size = new System.Drawing.Size(215, 29);
            this.tboxPasswordManual.TabIndex = 9;
            this.tboxPasswordManual.Text = "Пароль";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(156, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tboxPasswordManual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboxBukv);
            this.Controls.Add(this.lblBukv);
            this.Controls.Add(this.cboxLengthPassword);
            this.Controls.Add(this.lblLengthPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxSymvol);
            this.Controls.Add(this.rbtnRussian);
            this.Controls.Add(this.rbtnEnglish);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnEnglish;
        private System.Windows.Forms.RadioButton rbtnRussian;
        private System.Windows.Forms.CheckBox cboxSymvol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLengthPassword;
        private System.Windows.Forms.ComboBox cboxLengthPassword;
        private System.Windows.Forms.Label lblBukv;
        private System.Windows.Forms.ComboBox cboxBukv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tboxPasswordManual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}