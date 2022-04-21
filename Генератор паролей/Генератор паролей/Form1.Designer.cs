namespace Генератор_паролей
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCount = new System.Windows.Forms.Label();
            this.cboxLengthPassword = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxPasswordGenAuto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(73, -1);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(129, 13);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Укажите длинну пароля";
            // 
            // cboxLengthPassword
            // 
            this.cboxLengthPassword.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.cboxLengthPassword.Location = new System.Drawing.Point(110, 15);
            this.cboxLengthPassword.Name = "cboxLengthPassword";
            this.cboxLengthPassword.Size = new System.Drawing.Size(67, 21);
            this.cboxLengthPassword.TabIndex = 1;
            this.cboxLengthPassword.Text = "6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сгенерировать пароль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxPassword.Location = new System.Drawing.Point(27, 71);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(202, 29);
            this.tboxPassword.TabIndex = 3;
            this.tboxPassword.Text = "Пароль";
            // 
            // tboxPasswordGenAuto
            // 
            this.tboxPasswordGenAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxPasswordGenAuto.Location = new System.Drawing.Point(27, 156);
            this.tboxPasswordGenAuto.Name = "tboxPasswordGenAuto";
            this.tboxPasswordGenAuto.Size = new System.Drawing.Size(202, 29);
            this.tboxPasswordGenAuto.TabIndex = 4;
            this.tboxPasswordGenAuto.Text = "Пароль";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сгенерировать автоматически";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(40, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(127, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(40, 191);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(180, 29);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Подробная настройка";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 267);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tboxPasswordGenAuto);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboxLengthPassword);
            this.Controls.Add(this.lblCount);
            this.Name = "Form1";
            this.Text = "Генератор паролей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ComboBox cboxLengthPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxPasswordGenAuto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSetting;
    }
}

