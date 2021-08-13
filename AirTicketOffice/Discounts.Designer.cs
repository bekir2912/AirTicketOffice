namespace AirTicketOffice
{
    partial class Discounts
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BeforeDiscount = new System.Windows.Forms.Label();
            this.AfterDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скидка";
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.Location = new System.Drawing.Point(161, 17);
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownDiscount.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(214, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxDescription.Location = new System.Drawing.Point(25, 80);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 156);
            this.textBoxDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание скидки";
            // 
            // BeforeDiscount
            // 
            this.BeforeDiscount.AutoSize = true;
            this.BeforeDiscount.BackColor = System.Drawing.Color.Transparent;
            this.BeforeDiscount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeforeDiscount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BeforeDiscount.Location = new System.Drawing.Point(12, 239);
            this.BeforeDiscount.Name = "BeforeDiscount";
            this.BeforeDiscount.Size = new System.Drawing.Size(121, 24);
            this.BeforeDiscount.TabIndex = 5;
            this.BeforeDiscount.Text = "До скидки: ";
            // 
            // AfterDiscount
            // 
            this.AfterDiscount.AutoSize = true;
            this.AfterDiscount.BackColor = System.Drawing.Color.Transparent;
            this.AfterDiscount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AfterDiscount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AfterDiscount.Location = new System.Drawing.Point(12, 264);
            this.AfterDiscount.Name = "AfterDiscount";
            this.AfterDiscount.Size = new System.Drawing.Size(155, 24);
            this.AfterDiscount.TabIndex = 6;
            this.AfterDiscount.Text = "После скидки: ";
            this.AfterDiscount.Click += new System.EventHandler(this.AfterDiscount_Click);
            // 
            // Discounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::AirTicketOffice.Properties.Resources.Discount;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 318);
            this.Controls.Add(this.AfterDiscount);
            this.Controls.Add(this.BeforeDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownDiscount);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Discounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discounts";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownDiscount;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Label BeforeDiscount;
        protected internal System.Windows.Forms.Label AfterDiscount;
    }
}