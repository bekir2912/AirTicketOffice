namespace AirTicketOffice
{
    partial class DebitForm
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
            this.AddingBalance = new System.Windows.Forms.NumericUpDown();
            this.SubmitBalance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddingBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пополнение Баланса";
            // 
            // AddingBalance
            // 
            this.AddingBalance.Location = new System.Drawing.Point(67, 99);
            this.AddingBalance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AddingBalance.Name = "AddingBalance";
            this.AddingBalance.Size = new System.Drawing.Size(196, 20);
            this.AddingBalance.TabIndex = 1;
            // 
            // SubmitBalance
            // 
            this.SubmitBalance.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SubmitBalance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SubmitBalance.Location = new System.Drawing.Point(116, 156);
            this.SubmitBalance.Name = "SubmitBalance";
            this.SubmitBalance.Size = new System.Drawing.Size(83, 30);
            this.SubmitBalance.TabIndex = 2;
            this.SubmitBalance.Text = "Готово";
            this.SubmitBalance.UseVisualStyleBackColor = true;
            // 
            // DebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::AirTicketOffice.Properties.Resources.Money;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 198);
            this.Controls.Add(this.SubmitBalance);
            this.Controls.Add(this.AddingBalance);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пополнение";
            ((System.ComponentModel.ISupportInitialize)(this.AddingBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitBalance;
        protected internal System.Windows.Forms.NumericUpDown AddingBalance;
    }
}