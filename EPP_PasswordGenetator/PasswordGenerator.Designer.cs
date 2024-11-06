namespace EPP_PasswordGenerator
{
    partial class PasswordGenerator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.length = new System.Windows.Forms.Label();
            this.len8 = new System.Windows.Forms.RadioButton();
            this.len8_14 = new System.Windows.Forms.RadioButton();
            this.len14_20 = new System.Windows.Forms.RadioButton();
            this.lenInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.useSymbols = new System.Windows.Forms.CheckBox();
            this.useDigits = new System.Windows.Forms.CheckBox();
            this.useLowCase = new System.Windows.Forms.CheckBox();
            this.useUppCase = new System.Windows.Forms.CheckBox();
            this.use = new System.Windows.Forms.Label();
            this.typePassword = new System.Windows.Forms.Label();
            this.generatedPassword = new System.Windows.Forms.TextBox();
            this.generatePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.length.Location = new System.Drawing.Point(27, 31);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(62, 20);
            this.length.TabIndex = 0;
            this.length.Text = "Длина:";
            // 
            // len8
            // 
            this.len8.AutoSize = true;
            this.len8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.len8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.len8.Location = new System.Drawing.Point(137, 29);
            this.len8.Name = "len8";
            this.len8.Size = new System.Drawing.Size(36, 24);
            this.len8.TabIndex = 1;
            this.len8.TabStop = true;
            this.len8.Text = "8";
            this.len8.UseVisualStyleBackColor = true;
            // 
            // len8_14
            // 
            this.len8_14.AutoSize = true;
            this.len8_14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.len8_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.len8_14.Location = new System.Drawing.Point(232, 29);
            this.len8_14.Name = "len8_14";
            this.len8_14.Size = new System.Drawing.Size(59, 24);
            this.len8_14.TabIndex = 2;
            this.len8_14.TabStop = true;
            this.len8_14.Text = "8-14";
            this.len8_14.UseVisualStyleBackColor = true;
            // 
            // len14_20
            // 
            this.len14_20.AutoSize = true;
            this.len14_20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.len14_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.len14_20.Location = new System.Drawing.Point(345, 29);
            this.len14_20.Name = "len14_20";
            this.len14_20.Size = new System.Drawing.Size(68, 24);
            this.len14_20.TabIndex = 3;
            this.len14_20.TabStop = true;
            this.len14_20.Text = "14-20";
            this.len14_20.UseVisualStyleBackColor = true;
            // 
            // lenInput
            // 
            this.lenInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lenInput.Location = new System.Drawing.Point(473, 27);
            this.lenInput.Name = "lenInput";
            this.lenInput.Size = new System.Drawing.Size(200, 26);
            this.lenInput.TabIndex = 4;
            this.lenInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lenInput_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.length);
            this.panel1.Controls.Add(this.lenInput);
            this.panel1.Controls.Add(this.len8);
            this.panel1.Controls.Add(this.len14_20);
            this.panel1.Controls.Add(this.len8_14);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 82);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.useSymbols);
            this.panel2.Controls.Add(this.useDigits);
            this.panel2.Controls.Add(this.useLowCase);
            this.panel2.Controls.Add(this.useUppCase);
            this.panel2.Controls.Add(this.use);
            this.panel2.Location = new System.Drawing.Point(1, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 82);
            this.panel2.TabIndex = 6;
            // 
            // useSymbols
            // 
            this.useSymbols.AutoSize = true;
            this.useSymbols.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useSymbols.Location = new System.Drawing.Point(575, 27);
            this.useSymbols.Name = "useSymbols";
            this.useSymbols.Size = new System.Drawing.Size(98, 24);
            this.useSymbols.TabIndex = 4;
            this.useSymbols.Text = "Символы";
            this.useSymbols.UseVisualStyleBackColor = true;
            // 
            // useDigits
            // 
            this.useDigits.AutoSize = true;
            this.useDigits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useDigits.Location = new System.Drawing.Point(485, 28);
            this.useDigits.Name = "useDigits";
            this.useDigits.Size = new System.Drawing.Size(84, 24);
            this.useDigits.TabIndex = 3;
            this.useDigits.Text = "Цифры";
            this.useDigits.UseVisualStyleBackColor = true;
            // 
            // useLowCase
            // 
            this.useLowCase.AutoSize = true;
            this.useLowCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useLowCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useLowCase.Location = new System.Drawing.Point(328, 28);
            this.useLowCase.Name = "useLowCase";
            this.useLowCase.Size = new System.Drawing.Size(151, 24);
            this.useLowCase.TabIndex = 2;
            this.useLowCase.Text = "Нижний регистр";
            this.useLowCase.UseVisualStyleBackColor = true;
            // 
            // useUppCase
            // 
            this.useUppCase.AutoSize = true;
            this.useUppCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useUppCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useUppCase.Location = new System.Drawing.Point(167, 28);
            this.useUppCase.Name = "useUppCase";
            this.useUppCase.Size = new System.Drawing.Size(155, 24);
            this.useUppCase.TabIndex = 1;
            this.useUppCase.Text = "Верхний регистр";
            this.useUppCase.UseVisualStyleBackColor = true;
            // 
            // use
            // 
            this.use.AutoSize = true;
            this.use.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.use.Location = new System.Drawing.Point(27, 28);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(122, 20);
            this.use.TabIndex = 0;
            this.use.Text = "Использовать:";
            // 
            // typePassword
            // 
            this.typePassword.AutoSize = true;
            this.typePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typePassword.Location = new System.Drawing.Point(206, 213);
            this.typePassword.Name = "typePassword";
            this.typePassword.Size = new System.Drawing.Size(286, 31);
            this.typePassword.TabIndex = 7;
            this.typePassword.Text = "Сгенерируйте пароль";
            // 
            // generatedPassword
            // 
            this.generatedPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.generatedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatedPassword.Location = new System.Drawing.Point(72, 287);
            this.generatedPassword.Multiline = true;
            this.generatedPassword.Name = "generatedPassword";
            this.generatedPassword.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.generatedPassword.Size = new System.Drawing.Size(554, 46);
            this.generatedPassword.TabIndex = 8;
            // 
            // generatePassword
            // 
            this.generatePassword.BackColor = System.Drawing.Color.RosyBrown;
            this.generatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatePassword.Location = new System.Drawing.Point(233, 388);
            this.generatePassword.Name = "generatePassword";
            this.generatePassword.Size = new System.Drawing.Size(230, 46);
            this.generatePassword.TabIndex = 9;
            this.generatePassword.Text = "Сгенерировать";
            this.generatePassword.UseVisualStyleBackColor = false;
            this.generatePassword.Click += new System.EventHandler(this.generatePassword_Click);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(693, 499);
            this.Controls.Add(this.generatePassword);
            this.Controls.Add(this.generatedPassword);
            this.Controls.Add(this.typePassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label length;
        private System.Windows.Forms.RadioButton len8;
        private System.Windows.Forms.RadioButton len8_14;
        private System.Windows.Forms.RadioButton len14_20;
        private System.Windows.Forms.TextBox lenInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox useSymbols;
        private System.Windows.Forms.CheckBox useDigits;
        private System.Windows.Forms.CheckBox useLowCase;
        private System.Windows.Forms.CheckBox useUppCase;
        private System.Windows.Forms.Label use;
        private System.Windows.Forms.Label typePassword;
        private System.Windows.Forms.TextBox generatedPassword;
        private System.Windows.Forms.Button generatePassword;
    }
}

