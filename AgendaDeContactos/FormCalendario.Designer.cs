namespace AgendaDeContactos
{
    partial class FormCalendario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.calCalendario = new System.Windows.Forms.MonthCalendar();
            this.lblFechaTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTextoTitulo = new System.Windows.Forms.Label();
            this.txtRecordatorio = new System.Windows.Forms.TextBox();
            this.lblHoraTitulo = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblContactoTitulo = new System.Windows.Forms.Label();
            this.cmbContacto = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblListaTitulo = new System.Windows.Forms.Label();
            this.lstRecordatorios = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.lblTitulo.Location = new System.Drawing.Point(18, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(332, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mis recordatorios";
            // 
            // calCalendario
            // 
            this.calCalendario.BackColor = System.Drawing.Color.White;
            this.calCalendario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calCalendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.calCalendario.Location = new System.Drawing.Point(27, 77);
            this.calCalendario.MaxSelectionCount = 1;
            this.calCalendario.Name = "calCalendario";
            this.calCalendario.TabIndex = 1;
            this.calCalendario.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.calCalendario.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.calCalendario.TrailingForeColor = System.Drawing.Color.Silver;
            this.calCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calCalendario_DateChanged);
            // 
            // lblFechaTitulo
            // 
            this.lblFechaTitulo.AutoSize = true;
            this.lblFechaTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.lblFechaTitulo.Location = new System.Drawing.Point(472, 14);
            this.lblFechaTitulo.Name = "lblFechaTitulo";
            this.lblFechaTitulo.Size = new System.Drawing.Size(162, 25);
            this.lblFechaTitulo.TabIndex = 2;
            this.lblFechaTitulo.Text = "Fecha seleccionada";
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.lblFecha.Location = new System.Drawing.Point(445, 53);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(290, 24);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "fecha";
            // 
            // lblTextoTitulo
            // 
            this.lblTextoTitulo.AutoSize = true;
            this.lblTextoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTextoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.lblTextoTitulo.Location = new System.Drawing.Point(445, 108);
            this.lblTextoTitulo.Name = "lblTextoTitulo";
            this.lblTextoTitulo.Size = new System.Drawing.Size(114, 25);
            this.lblTextoTitulo.TabIndex = 4;
            this.lblTextoTitulo.Text = "Recordatorio";
            // 
            // txtRecordatorio
            // 
            this.txtRecordatorio.BackColor = System.Drawing.Color.White;
            this.txtRecordatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecordatorio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRecordatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.txtRecordatorio.Location = new System.Drawing.Point(450, 136);
            this.txtRecordatorio.MaxLength = 100;
            this.txtRecordatorio.Name = "txtRecordatorio";
            this.txtRecordatorio.Size = new System.Drawing.Size(290, 37);
            this.txtRecordatorio.TabIndex = 5;
            // 
            // lblHoraTitulo
            // 
            this.lblHoraTitulo.AutoSize = true;
            this.lblHoraTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoraTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.lblHoraTitulo.Location = new System.Drawing.Point(388, 190);
            this.lblHoraTitulo.Name = "lblHoraTitulo";
            this.lblHoraTitulo.Size = new System.Drawing.Size(51, 25);
            this.lblHoraTitulo.TabIndex = 6;
            this.lblHoraTitulo.Text = "Hora";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "hh:mm tt";
            this.dtpHora.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(393, 214);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(130, 37);
            this.dtpHora.TabIndex = 7;
            // 
            // lblContactoTitulo
            // 
            this.lblContactoTitulo.AutoSize = true;
            this.lblContactoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.lblContactoTitulo.Location = new System.Drawing.Point(693, 240);
            this.lblContactoTitulo.Name = "lblContactoTitulo";
            this.lblContactoTitulo.Size = new System.Drawing.Size(167, 25);
            this.lblContactoTitulo.TabIndex = 8;
            this.lblContactoTitulo.Text = "Contacto (opcional)";
            // 
            // cmbContacto
            // 
            this.cmbContacto.BackColor = System.Drawing.Color.White;
            this.cmbContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContacto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.cmbContacto.FormattingEnabled = true;
            this.cmbContacto.Location = new System.Drawing.Point(698, 290);
            this.cmbContacto.Name = "cmbContacto";
            this.cmbContacto.Size = new System.Drawing.Size(145, 36);
            this.cmbContacto.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.btnGuardar.Location = new System.Drawing.Point(378, 257);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(190, 36);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar recordatorio";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblListaTitulo
            // 
            this.lblListaTitulo.AutoSize = true;
            this.lblListaTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblListaTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblListaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.lblListaTitulo.Location = new System.Drawing.Point(108, 357);
            this.lblListaTitulo.Name = "lblListaTitulo";
            this.lblListaTitulo.Size = new System.Drawing.Size(213, 25);
            this.lblListaTitulo.TabIndex = 11;
            this.lblListaTitulo.Text = "Recordatorios guardados";
            // 
            // lstRecordatorios
            // 
            this.lstRecordatorios.BackColor = System.Drawing.Color.White;
            this.lstRecordatorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRecordatorios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstRecordatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.lstRecordatorios.FormattingEnabled = true;
            this.lstRecordatorios.IntegralHeight = false;
            this.lstRecordatorios.ItemHeight = 28;
            this.lstRecordatorios.Location = new System.Drawing.Point(88, 396);
            this.lstRecordatorios.Name = "lstRecordatorios";
            this.lstRecordatorios.Size = new System.Drawing.Size(560, 135);
            this.lstRecordatorios.TabIndex = 12;
            this.lstRecordatorios.SelectedIndexChanged += new System.EventHandler(this.lstRecordatorios_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.btnEliminar.Location = new System.Drawing.Point(113, 576);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 38);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.btnVolver.Location = new System.Drawing.Point(477, 576);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(130, 38);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormCalendario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(930, 702);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstRecordatorios);
            this.Controls.Add(this.lblListaTitulo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbContacto);
            this.Controls.Add(this.lblContactoTitulo);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblHoraTitulo);
            this.Controls.Add(this.txtRecordatorio);
            this.Controls.Add(this.lblTextoTitulo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFechaTitulo);
            this.Controls.Add(this.calCalendario);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendario y recordatorios";
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MonthCalendar calCalendario;
        private System.Windows.Forms.Label lblFechaTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTextoTitulo;
        private System.Windows.Forms.TextBox txtRecordatorio;
        private System.Windows.Forms.Label lblHoraTitulo;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblContactoTitulo;
        private System.Windows.Forms.ComboBox cmbContacto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblListaTitulo;
        private System.Windows.Forms.ListBox lstRecordatorios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
    }
}
