namespace AirTicketOffice
{
    partial class EnteringForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnteringForm));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EnteringFormButton = new System.Windows.Forms.Button();
            this.EnteringFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LoginTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LoginTextBox.Location = new System.Drawing.Point(698, 227);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(279, 35);
            this.LoginTextBox.TabIndex = 1;
            this.LoginTextBox.TabStop = false;
            this.LoginTextBox.Text = "Введите Email";
            this.LoginTextBox.Click += new System.EventHandler(this.LoginTextBox_Click);
            this.LoginTextBox.Leave += new System.EventHandler(this.LoginTextBox_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PasswordTextBox.Location = new System.Drawing.Point(698, 293);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(279, 35);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.Text = "Введите пароль";
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // EnteringFormButton
            // 
            this.EnteringFormButton.BackColor = System.Drawing.Color.Transparent;
            this.EnteringFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.EnteringFormButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EnteringFormButton.Location = new System.Drawing.Point(830, 353);
            this.EnteringFormButton.Name = "EnteringFormButton";
            this.EnteringFormButton.Size = new System.Drawing.Size(147, 37);
            this.EnteringFormButton.TabIndex = 3;
            this.EnteringFormButton.TabStop = false;
            this.EnteringFormButton.Text = "Вход";
            this.EnteringFormButton.UseVisualStyleBackColor = false;
            this.EnteringFormButton.Click += new System.EventHandler(this.EnteringFormButton_Click);
            // 
            // EnteringFormLabel
            // 
            this.EnteringFormLabel.AutoSize = true;
            this.EnteringFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnteringFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.EnteringFormLabel.ForeColor = System.Drawing.Color.Crimson;
            this.EnteringFormLabel.Location = new System.Drawing.Point(766, 133);
            this.EnteringFormLabel.Name = "EnteringFormLabel";
            this.EnteringFormLabel.Size = new System.Drawing.Size(131, 54);
            this.EnteringFormLabel.TabIndex = 1;
            this.EnteringFormLabel.Text = "Вход";
            // 
            // EnteringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 661);
            this.Controls.Add(this.EnteringFormLabel);
            this.Controls.Add(this.EnteringFormButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnteringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button EnteringFormButton;
        private System.Windows.Forms.Label EnteringFormLabel;
    }
}

