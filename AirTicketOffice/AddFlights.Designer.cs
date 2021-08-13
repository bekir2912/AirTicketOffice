namespace AirTicketOffice
{
    partial class AddFlights
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ToCity = new System.Windows.Forms.TextBox();
            this.FromCit = new System.Windows.Forms.TextBox();
            this.FromCountr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FromCity = new System.Windows.Forms.Label();
            this.FromCountry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalSeats = new System.Windows.Forms.NumericUpDown();
            this.DateToStart = new System.Windows.Forms.DateTimePicker();
            this.dateToArrivel = new System.Windows.Forms.DateTimePicker();
            this.Cost = new System.Windows.Forms.NumericUpDown();
            this.ToCountry = new System.Windows.Forms.TextBox();
            this.ModelAir = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totalSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(653, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 39;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(529, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ToCity
            // 
            this.ToCity.Location = new System.Drawing.Point(227, 176);
            this.ToCity.Name = "ToCity";
            this.ToCity.Size = new System.Drawing.Size(170, 20);
            this.ToCity.TabIndex = 4;
            // 
            // FromCit
            // 
            this.FromCit.Location = new System.Drawing.Point(227, 107);
            this.FromCit.Name = "FromCit";
            this.FromCit.Size = new System.Drawing.Size(170, 20);
            this.FromCit.TabIndex = 2;
            // 
            // FromCountr
            // 
            this.FromCountr.Location = new System.Drawing.Point(227, 72);
            this.FromCountr.Name = "FromCountr";
            this.FromCountr.Size = new System.Drawing.Size(170, 20);
            this.FromCountr.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label9.Location = new System.Drawing.Point(277, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 40);
            this.label9.TabIndex = 30;
            this.label9.Text = "Заполните данные";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(31, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "Дата прилета ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(31, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(31, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Дата вылета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(31, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Куда(город)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(31, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "Куда(Страна)";
            // 
            // FromCity
            // 
            this.FromCity.AutoSize = true;
            this.FromCity.BackColor = System.Drawing.Color.Transparent;
            this.FromCity.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromCity.ForeColor = System.Drawing.Color.Navy;
            this.FromCity.Location = new System.Drawing.Point(31, 103);
            this.FromCity.Name = "FromCity";
            this.FromCity.Size = new System.Drawing.Size(156, 27);
            this.FromCity.TabIndex = 23;
            this.FromCity.Text = "Откуда(город)";
            // 
            // FromCountry
            // 
            this.FromCountry.AutoSize = true;
            this.FromCountry.BackColor = System.Drawing.Color.Transparent;
            this.FromCountry.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromCountry.ForeColor = System.Drawing.Color.Navy;
            this.FromCountry.Location = new System.Drawing.Point(31, 68);
            this.FromCountry.Name = "FromCountry";
            this.FromCountry.Size = new System.Drawing.Size(173, 27);
            this.FromCountry.TabIndex = 22;
            this.FromCountry.Text = "Откуда(Страна)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(408, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 54);
            this.label2.TabIndex = 42;
            this.label2.Text = "Общее колличество \r\nмест";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(31, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 27);
            this.label10.TabIndex = 41;
            this.label10.Text = "Модель Самолета";
            // 
            // totalSeats
            // 
            this.totalSeats.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.totalSeats.InterceptArrowKeys = false;
            this.totalSeats.Location = new System.Drawing.Point(633, 120);
            this.totalSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.totalSeats.Name = "totalSeats";
            this.totalSeats.Size = new System.Drawing.Size(146, 20);
            this.totalSeats.TabIndex = 9;
            // 
            // DateToStart
            // 
            this.DateToStart.Location = new System.Drawing.Point(227, 211);
            this.DateToStart.Name = "DateToStart";
            this.DateToStart.Size = new System.Drawing.Size(170, 20);
            this.DateToStart.TabIndex = 5;
            // 
            // dateToArrivel
            // 
            this.dateToArrivel.Location = new System.Drawing.Point(227, 244);
            this.dateToArrivel.Name = "dateToArrivel";
            this.dateToArrivel.Size = new System.Drawing.Size(170, 20);
            this.dateToArrivel.TabIndex = 6;
            // 
            // Cost
            // 
            this.Cost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cost.InterceptArrowKeys = false;
            this.Cost.Location = new System.Drawing.Point(227, 319);
            this.Cost.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(170, 20);
            this.Cost.TabIndex = 8;
            // 
            // ToCountry
            // 
            this.ToCountry.Location = new System.Drawing.Point(227, 141);
            this.ToCountry.Name = "ToCountry";
            this.ToCountry.Size = new System.Drawing.Size(170, 20);
            this.ToCountry.TabIndex = 3;
            // 
            // ModelAir
            // 
            this.ModelAir.Location = new System.Drawing.Point(227, 282);
            this.ModelAir.Name = "ModelAir";
            this.ModelAir.Size = new System.Drawing.Size(170, 20);
            this.ModelAir.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Бизнес",
            "Эконом"});
            this.comboBox1.Location = new System.Drawing.Point(633, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(408, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "Класс";
            // 
            // AddFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::AirTicketOffice.Properties.Resources.Addint_Ticket;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ToCountry);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.dateToArrivel);
            this.Controls.Add(this.DateToStart);
            this.Controls.Add(this.ModelAir);
            this.Controls.Add(this.totalSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToCity);
            this.Controls.Add(this.FromCit);
            this.Controls.Add(this.FromCountr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FromCity);
            this.Controls.Add(this.FromCountry);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добовление Рейсов";
            ((System.ComponentModel.ISupportInitialize)(this.totalSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.TextBox ToCity;
        protected internal System.Windows.Forms.TextBox FromCit;
        protected internal System.Windows.Forms.TextBox FromCountr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FromCity;
        private System.Windows.Forms.Label FromCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        protected internal System.Windows.Forms.NumericUpDown totalSeats;
        protected internal System.Windows.Forms.DateTimePicker DateToStart;
        protected internal System.Windows.Forms.DateTimePicker dateToArrivel;
        protected internal System.Windows.Forms.NumericUpDown Cost;
        protected internal System.Windows.Forms.TextBox ToCountry;
        protected internal System.Windows.Forms.TextBox ModelAir;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.ComboBox comboBox1;
    }
}