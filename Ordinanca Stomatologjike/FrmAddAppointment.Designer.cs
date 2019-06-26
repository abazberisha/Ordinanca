namespace Ordinanca_Stomatologjike
{
    partial class FrmAddAppointment
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtArsyejaTerminit = new System.Windows.Forms.TextBox();
            this.txtAlergjia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbShfaq = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMbyllFormen = new System.Windows.Forms.Button();
            this.btnShtoTermin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Anulo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNrLeternjofitmit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtESurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 42);
            this.label9.TabIndex = 25;
            this.label9.Text = "Shto Takimet ";
            // 
            // txtArsyejaTerminit
            // 
            this.txtArsyejaTerminit.Location = new System.Drawing.Point(207, 220);
            this.txtArsyejaTerminit.Name = "txtArsyejaTerminit";
            this.txtArsyejaTerminit.Size = new System.Drawing.Size(178, 22);
            this.txtArsyejaTerminit.TabIndex = 26;
            this.txtArsyejaTerminit.TextChanged += new System.EventHandler(this.txtArsyejaTerminit_TextChanged);
            // 
            // txtAlergjia
            // 
            this.txtAlergjia.Location = new System.Drawing.Point(208, 186);
            this.txtAlergjia.Name = "txtAlergjia";
            this.txtAlergjia.Size = new System.Drawing.Size(177, 22);
            this.txtAlergjia.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 14);
            this.label1.TabIndex = 30;
            this.label1.Text = "Arsyeja Terminit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data e terminit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "Alergjia :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 21);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // cmbShfaq
            // 
            this.cmbShfaq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShfaq.FormattingEnabled = true;
            this.cmbShfaq.Location = new System.Drawing.Point(206, 29);
            this.cmbShfaq.Name = "cmbShfaq";
            this.cmbShfaq.Size = new System.Drawing.Size(177, 22);
            this.cmbShfaq.TabIndex = 35;
            this.cmbShfaq.SelectedIndexChanged += new System.EventHandler(this.cmbShfaq_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMbyllFormen);
            this.groupBox1.Controls.Add(this.cmbShfaq);
            this.groupBox1.Controls.Add(this.btnShtoTermin);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Anulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtAlergjia);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtArsyejaTerminit);
            this.groupBox1.Controls.Add(this.txtNrLeternjofitmit);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtEName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtESurname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 424);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Të dhënat e pacientit";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // btnMbyllFormen
            // 
            this.btnMbyllFormen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMbyllFormen.Location = new System.Drawing.Point(341, 319);
            this.btnMbyllFormen.Name = "btnMbyllFormen";
            this.btnMbyllFormen.Size = new System.Drawing.Size(77, 41);
            this.btnMbyllFormen.TabIndex = 38;
            this.btnMbyllFormen.Text = "Mbyll Formen";
            this.btnMbyllFormen.UseVisualStyleBackColor = true;
            this.btnMbyllFormen.Click += new System.EventHandler(this.btnMbyllFormen_Click);
            // 
            // btnShtoTermin
            // 
            this.btnShtoTermin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShtoTermin.Location = new System.Drawing.Point(129, 319);
            this.btnShtoTermin.Name = "btnShtoTermin";
            this.btnShtoTermin.Size = new System.Drawing.Size(75, 41);
            this.btnShtoTermin.TabIndex = 37;
            this.btnShtoTermin.Text = "Shto Termin";
            this.btnShtoTermin.UseVisualStyleBackColor = true;
            this.btnShtoTermin.Click += new System.EventHandler(this.btnShtoTermin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "PacientiID";
            // 
            // Anulo
            // 
            this.Anulo.Location = new System.Drawing.Point(235, 319);
            this.Anulo.Name = "Anulo";
            this.Anulo.Size = new System.Drawing.Size(84, 41);
            this.Anulo.TabIndex = 11;
            this.Anulo.Text = "Anulo";
            this.Anulo.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 256);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 14);
            this.label15.TabIndex = 32;
            this.label15.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(208, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNrLeternjofitmit
            // 
            this.txtNrLeternjofitmit.Location = new System.Drawing.Point(208, 118);
            this.txtNrLeternjofitmit.Name = "txtNrLeternjofitmit";
            this.txtNrLeternjofitmit.Size = new System.Drawing.Size(176, 22);
            this.txtNrLeternjofitmit.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 14);
            this.label13.TabIndex = 27;
            this.label13.Text = "Nr Leternjoftimit :";
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(207, 56);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(176, 22);
            this.txtEName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Emri :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mbiemri :";
            // 
            // txtESurname
            // 
            this.txtESurname.Location = new System.Drawing.Point(207, 88);
            this.txtESurname.Name = "txtESurname";
            this.txtESurname.Size = new System.Drawing.Size(176, 22);
            this.txtESurname.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 14);
            this.label10.TabIndex = 24;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(207, 285);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(178, 22);
            this.txtTel.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(142, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 14);
            this.label16.TabIndex = 12;
            this.label16.Text = "Tel :";
            // 
            // FrmAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(508, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddAppointment";
            this.Load += new System.EventHandler(this.FrmAddAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArsyejaTerminit;
        private System.Windows.Forms.TextBox txtAlergjia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbShfaq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMbyllFormen;
        private System.Windows.Forms.Button btnShtoTermin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Anulo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNrLeternjofitmit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtESurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label16;
    }
}