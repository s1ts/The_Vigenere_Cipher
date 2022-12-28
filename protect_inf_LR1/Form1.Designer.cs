namespace protect_inf_LR1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonVizhener = new System.Windows.Forms.RadioButton();
            this.radioButtonGamma = new System.Windows.Forms.RadioButton();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKeyWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.radioButtonVizhener);
            this.groupBox1.Controls.Add(this.radioButtonGamma);
            this.groupBox1.Location = new System.Drawing.Point(281, 317);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(191, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод шифрования";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonVizhener
            // 
            this.radioButtonVizhener.AutoSize = true;
            this.radioButtonVizhener.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonVizhener.Location = new System.Drawing.Point(8, 22);
            this.radioButtonVizhener.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonVizhener.Name = "radioButtonVizhener";
            this.radioButtonVizhener.Size = new System.Drawing.Size(135, 20);
            this.radioButtonVizhener.TabIndex = 1;
            this.radioButtonVizhener.Text = "Шифр Виженера";
            this.radioButtonVizhener.UseVisualStyleBackColor = true;
            // 
            // radioButtonGamma
            // 
            this.radioButtonGamma.AutoSize = true;
            this.radioButtonGamma.Checked = true;
            this.radioButtonGamma.Location = new System.Drawing.Point(22, 87);
            this.radioButtonGamma.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonGamma.Name = "radioButtonGamma";
            this.radioButtonGamma.Size = new System.Drawing.Size(125, 20);
            this.radioButtonGamma.TabIndex = 0;
            this.radioButtonGamma.TabStop = true;
            this.radioButtonGamma.Text = "Гаммирование";
            this.radioButtonGamma.UseVisualStyleBackColor = true;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.Color.Bisque;
            this.buttonEncrypt.Location = new System.Drawing.Point(281, 412);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(191, 36);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.BackColor = System.Drawing.Color.Bisque;
            this.buttonDecipher.Location = new System.Drawing.Point(703, 412);
            this.buttonDecipher.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(142, 36);
            this.buttonDecipher.TabIndex = 2;
            this.buttonDecipher.Text = "Расшифровать";
            this.buttonDecipher.UseVisualStyleBackColor = false;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(700, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ключевое слово:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxKeyWord
            // 
            this.textBoxKeyWord.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxKeyWord.Location = new System.Drawing.Point(700, 347);
            this.textBoxKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKeyWord.Name = "textBoxKeyWord";
            this.textBoxKeyWord.Size = new System.Drawing.Size(145, 22);
            this.textBoxKeyWord.TabIndex = 4;
            this.textBoxKeyWord.TextChanged += new System.EventHandler(this.textBoxKeyWord_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(903, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1075, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxKeyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "vscode.ru - Шифр Виженера";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonVizhener;
        private System.Windows.Forms.RadioButton radioButtonGamma;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKeyWord;
        private System.Windows.Forms.Button button1;
    }
}

