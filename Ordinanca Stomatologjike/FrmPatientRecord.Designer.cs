namespace Ordinanca_Stomatologjike
{
    partial class FrmPatientRecord
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
            this.gridPacientet = new System.Windows.Forms.DataGridView();
            this.txtKerko = new System.Windows.Forms.TextBox();
            this.btn_SearchPatient = new System.Windows.Forms.Button();
            this.btn_AddPatientBack = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEnable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPacientet
            // 
            this.gridPacientet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridPacientet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientet.Location = new System.Drawing.Point(19, 171);
            this.gridPacientet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridPacientet.MultiSelect = false;
            this.gridPacientet.Name = "gridPacientet";
            this.gridPacientet.RowHeadersVisible = false;
            this.gridPacientet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPacientet.Size = new System.Drawing.Size(817, 287);
            this.gridPacientet.TabIndex = 25;
            this.gridPacientet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPacientet_CellContentClick);
            this.gridPacientet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPacientet_CellDoubleClick);
            // 
            // txtKerko
            // 
            this.txtKerko.Location = new System.Drawing.Point(452, 128);
            this.txtKerko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKerko.Multiline = true;
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.Size = new System.Drawing.Size(184, 24);
            this.txtKerko.TabIndex = 26;
            // 
            // btn_SearchPatient
            // 
            this.btn_SearchPatient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchPatient.Location = new System.Drawing.Point(664, 126);
            this.btn_SearchPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SearchPatient.Name = "btn_SearchPatient";
            this.btn_SearchPatient.Size = new System.Drawing.Size(172, 27);
            this.btn_SearchPatient.TabIndex = 28;
            this.btn_SearchPatient.Text = "Kërko";
            this.btn_SearchPatient.UseVisualStyleBackColor = true;
            this.btn_SearchPatient.Click += new System.EventHandler(this.btn_SearchPatient_Click);
            // 
            // btn_AddPatientBack
            // 
            this.btn_AddPatientBack.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPatientBack.Location = new System.Drawing.Point(479, 481);
            this.btn_AddPatientBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddPatientBack.Name = "btn_AddPatientBack";
            this.btn_AddPatientBack.Size = new System.Drawing.Size(177, 36);
            this.btn_AddPatientBack.TabIndex = 29;
            this.btn_AddPatientBack.Text = "Shto Pacient";
            this.btn_AddPatientBack.UseVisualStyleBackColor = true;
            this.btn_AddPatientBack.Click += new System.EventHandler(this.btn_AddPatientBack_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(664, 481);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(172, 34);
            this.btn_Exit.TabIndex = 30;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(620, 53);
            this.label9.TabIndex = 31;
            this.label9.Text = "Kërko të dhënat e pacientit";
            // 
            // btnEnable
            // 
            this.btnEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEnable.Location = new System.Drawing.Point(282, 112);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(120, 51);
            this.btnEnable.TabIndex = 33;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // FrmPatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 529);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_AddPatientBack);
            this.Controls.Add(this.btn_SearchPatient);
            this.Controls.Add(this.txtKerko);
            this.Controls.Add(this.gridPacientet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPatientRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPatientRecord";
            this.Load += new System.EventHandler(this.FrmPatientRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPacientet;
        private System.Windows.Forms.TextBox txtKerko;
        private System.Windows.Forms.Button btn_SearchPatient;
        private System.Windows.Forms.Button btn_AddPatientBack;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEnable;
    }
}