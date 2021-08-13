namespace AirTicketOffice
{
    partial class OwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            this.OwnerNameLabel = new System.Windows.Forms.Label();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.AirPlaneTextBox = new System.Windows.Forms.TextBox();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.FlightTextBox = new System.Windows.Forms.TextBox();
            this.AirPlaneLabel = new System.Windows.Forms.Label();
            this.TicketcheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectioncheckBox = new System.Windows.Forms.CheckBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.CountInfoLabel = new System.Windows.Forms.Label();
            this.Changebutton = new System.Windows.Forms.Button();
            this.Discountbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.TilldateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DiscountcheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Quit = new System.Windows.Forms.Button();
            this.OwnerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OwnerNameLabel
            // 
            this.OwnerNameLabel.AutoSize = true;
            this.OwnerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.OwnerNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerNameLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.OwnerNameLabel.Location = new System.Drawing.Point(12, 126);
            this.OwnerNameLabel.Name = "OwnerNameLabel";
            this.OwnerNameLabel.Size = new System.Drawing.Size(115, 23);
            this.OwnerNameLabel.TabIndex = 1;
            this.OwnerNameLabel.Text = "OwnerName";
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(173, 29);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(100, 20);
            this.FromTextBox.TabIndex = 3;
            this.FromTextBox.TextChanged += new System.EventHandler(this.FromTextBox_TextChanged);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.BackColor = System.Drawing.Color.Transparent;
            this.FromLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromLabel.ForeColor = System.Drawing.Color.Crimson;
            this.FromLabel.Location = new System.Drawing.Point(170, 3);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(72, 23);
            this.FromLabel.TabIndex = 4;
            this.FromLabel.Text = "Откуда";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ToLabel.Location = new System.Drawing.Point(287, 3);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(50, 23);
            this.ToLabel.TabIndex = 5;
            this.ToLabel.Text = "Куда";
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(291, 29);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(100, 20);
            this.ToTextBox.TabIndex = 6;
            this.ToTextBox.TextChanged += new System.EventHandler(this.ToTextBox_TextChanged);
            // 
            // AirPlaneTextBox
            // 
            this.AirPlaneTextBox.Location = new System.Drawing.Point(528, 29);
            this.AirPlaneTextBox.Name = "AirPlaneTextBox";
            this.AirPlaneTextBox.Size = new System.Drawing.Size(157, 20);
            this.AirPlaneTextBox.TabIndex = 8;
            this.AirPlaneTextBox.TextChanged += new System.EventHandler(this.AirPlaneTextBox_TextChanged);
            // 
            // FlightLabel
            // 
            this.FlightLabel.AutoSize = true;
            this.FlightLabel.BackColor = System.Drawing.Color.Transparent;
            this.FlightLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlightLabel.ForeColor = System.Drawing.Color.Crimson;
            this.FlightLabel.Location = new System.Drawing.Point(406, 3);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(85, 23);
            this.FlightLabel.TabIndex = 9;
            this.FlightLabel.Text = "№ Рейса";
            // 
            // FlightTextBox
            // 
            this.FlightTextBox.Location = new System.Drawing.Point(410, 29);
            this.FlightTextBox.Name = "FlightTextBox";
            this.FlightTextBox.Size = new System.Drawing.Size(100, 20);
            this.FlightTextBox.TabIndex = 7;
            this.FlightTextBox.TextChanged += new System.EventHandler(this.FlightTextBox_TextChanged);
            // 
            // AirPlaneLabel
            // 
            this.AirPlaneLabel.AutoSize = true;
            this.AirPlaneLabel.BackColor = System.Drawing.Color.Transparent;
            this.AirPlaneLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AirPlaneLabel.ForeColor = System.Drawing.Color.Crimson;
            this.AirPlaneLabel.Location = new System.Drawing.Point(524, 3);
            this.AirPlaneLabel.Name = "AirPlaneLabel";
            this.AirPlaneLabel.Size = new System.Drawing.Size(161, 23);
            this.AirPlaneLabel.TabIndex = 10;
            this.AirPlaneLabel.Text = "Модель самолета";
            // 
            // TicketcheckBox
            // 
            this.TicketcheckBox.AutoSize = true;
            this.TicketcheckBox.BackColor = System.Drawing.Color.Transparent;
            this.TicketcheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicketcheckBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketcheckBox.ForeColor = System.Drawing.Color.Crimson;
            this.TicketcheckBox.Location = new System.Drawing.Point(15, 353);
            this.TicketcheckBox.Name = "TicketcheckBox";
            this.TicketcheckBox.Size = new System.Drawing.Size(94, 27);
            this.TicketcheckBox.TabIndex = 11;
            this.TicketcheckBox.Text = "Билеты";
            this.TicketcheckBox.UseVisualStyleBackColor = false;
            this.TicketcheckBox.CheckedChanged += new System.EventHandler(this.TicketcheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(691, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "От";
            // 
            // DirectioncheckBox
            // 
            this.DirectioncheckBox.AutoSize = true;
            this.DirectioncheckBox.BackColor = System.Drawing.Color.Transparent;
            this.DirectioncheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DirectioncheckBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectioncheckBox.ForeColor = System.Drawing.Color.Crimson;
            this.DirectioncheckBox.Location = new System.Drawing.Point(15, 376);
            this.DirectioncheckBox.Name = "DirectioncheckBox";
            this.DirectioncheckBox.Size = new System.Drawing.Size(144, 27);
            this.DirectioncheckBox.TabIndex = 14;
            this.DirectioncheckBox.Text = "Направления";
            this.DirectioncheckBox.UseVisualStyleBackColor = false;
            this.DirectioncheckBox.CheckedChanged += new System.EventHandler(this.DirectioncheckBox_CheckedChanged);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Transparent;
            this.Addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addbutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Addbutton.Location = new System.Drawing.Point(12, 182);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(160, 30);
            this.Addbutton.TabIndex = 15;
            this.Addbutton.Text = "Добавить рейс";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // CountInfoLabel
            // 
            this.CountInfoLabel.AutoSize = true;
            this.CountInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountInfoLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountInfoLabel.ForeColor = System.Drawing.Color.Crimson;
            this.CountInfoLabel.Location = new System.Drawing.Point(166, 613);
            this.CountInfoLabel.Name = "CountInfoLabel";
            this.CountInfoLabel.Size = new System.Drawing.Size(589, 42);
            this.CountInfoLabel.TabIndex = 16;
            this.CountInfoLabel.Text = "Количество найденных результатов: ";
            // 
            // Changebutton
            // 
            this.Changebutton.BackColor = System.Drawing.Color.Transparent;
            this.Changebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Changebutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Changebutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Changebutton.Location = new System.Drawing.Point(12, 218);
            this.Changebutton.Name = "Changebutton";
            this.Changebutton.Size = new System.Drawing.Size(160, 30);
            this.Changebutton.TabIndex = 17;
            this.Changebutton.Text = "Изменить рейс";
            this.Changebutton.UseVisualStyleBackColor = false;
            this.Changebutton.Click += new System.EventHandler(this.Changebutton_Click);
            // 
            // Discountbutton
            // 
            this.Discountbutton.BackColor = System.Drawing.Color.Transparent;
            this.Discountbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Discountbutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discountbutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Discountbutton.Location = new System.Drawing.Point(12, 291);
            this.Discountbutton.Name = "Discountbutton";
            this.Discountbutton.Size = new System.Drawing.Size(160, 30);
            this.Discountbutton.TabIndex = 18;
            this.Discountbutton.Text = "Сделать скидку";
            this.Discountbutton.UseVisualStyleBackColor = false;
            this.Discountbutton.Click += new System.EventHandler(this.Discountbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Deletebutton.Location = new System.Drawing.Point(12, 254);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(160, 30);
            this.Deletebutton.TabIndex = 19;
            this.Deletebutton.Text = "Удалить рейс";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // TilldateTimePicker
            // 
            this.TilldateTimePicker.Location = new System.Drawing.Point(845, 29);
            this.TilldateTimePicker.Name = "TilldateTimePicker";
            this.TilldateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.TilldateTimePicker.TabIndex = 20;
            this.TilldateTimePicker.ValueChanged += new System.EventHandler(this.TilldateTimePicker_ValueChanged);
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Location = new System.Drawing.Point(694, 29);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.FromdateTimePicker.TabIndex = 21;
            this.FromdateTimePicker.ValueChanged += new System.EventHandler(this.FromdateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(12, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Популярные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Редактирование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(841, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "До";
            // 
            // DiscountcheckBox
            // 
            this.DiscountcheckBox.AutoSize = true;
            this.DiscountcheckBox.BackColor = System.Drawing.Color.Transparent;
            this.DiscountcheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscountcheckBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountcheckBox.ForeColor = System.Drawing.Color.Crimson;
            this.DiscountcheckBox.Location = new System.Drawing.Point(15, 399);
            this.DiscountcheckBox.Name = "DiscountcheckBox";
            this.DiscountcheckBox.Size = new System.Drawing.Size(94, 27);
            this.DiscountcheckBox.TabIndex = 26;
            this.DiscountcheckBox.Text = "Скидка";
            this.DiscountcheckBox.UseVisualStyleBackColor = false;
            this.DiscountcheckBox.CheckedChanged += new System.EventHandler(this.DiscountcheckBox_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(829, 547);
            this.dataGridView1.TabIndex = 27;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Quit.Location = new System.Drawing.Point(15, 622);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(94, 33);
            this.Quit.TabIndex = 28;
            this.Quit.Text = "Выход";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // OwnerPictureBox
            // 
            this.OwnerPictureBox.Image = global::AirTicketOffice.Properties.Resources.Owner;
            this.OwnerPictureBox.Location = new System.Drawing.Point(12, 12);
            this.OwnerPictureBox.Name = "OwnerPictureBox";
            this.OwnerPictureBox.Size = new System.Drawing.Size(100, 100);
            this.OwnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OwnerPictureBox.TabIndex = 0;
            this.OwnerPictureBox.TabStop = false;
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 661);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DiscountcheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FromdateTimePicker);
            this.Controls.Add(this.TilldateTimePicker);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Discountbutton);
            this.Controls.Add(this.Changebutton);
            this.Controls.Add(this.CountInfoLabel);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.DirectioncheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TicketcheckBox);
            this.Controls.Add(this.AirPlaneLabel);
            this.Controls.Add(this.FlightLabel);
            this.Controls.Add(this.AirPlaneTextBox);
            this.Controls.Add(this.FlightTextBox);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.OwnerNameLabel);
            this.Controls.Add(this.OwnerPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OwnerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Здравствуйте, ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OwnerPictureBox;
        private System.Windows.Forms.Label OwnerNameLabel;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.TextBox AirPlaneTextBox;
        private System.Windows.Forms.Label FlightLabel;
        private System.Windows.Forms.TextBox FlightTextBox;
        private System.Windows.Forms.Label AirPlaneLabel;
        private System.Windows.Forms.CheckBox TicketcheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DirectioncheckBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label CountInfoLabel;
        private System.Windows.Forms.Button Changebutton;
        private System.Windows.Forms.Button Discountbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.DateTimePicker TilldateTimePicker;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox DiscountcheckBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Quit;
    }
}