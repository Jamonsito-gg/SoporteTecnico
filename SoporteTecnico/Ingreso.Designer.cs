
namespace SoporteTecnico
{
    partial class Ingreso
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.btnNuevoDispositivo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNuevoDispositivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.comboBoxDispositivo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.selectedRowsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infoNombre = new System.Windows.Forms.Label();
            this.infoApellido = new System.Windows.Forms.Label();
            this.infoCorreo = new System.Windows.Forms.Label();
            this.infoDispositivo = new System.Windows.Forms.Label();
            this.infoDescripcion = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.infoTicket = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dispositivo";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.btnNuevoDispositivo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtNuevoDispositivo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtDescripción);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.comboBoxDispositivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 438);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de ticket";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Inactivo",
            "Reparando",
            "Completado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(112, 167);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(137, 23);
            this.comboBoxEstado.TabIndex = 18;
            // 
            // btnNuevoDispositivo
            // 
            this.btnNuevoDispositivo.Location = new System.Drawing.Point(239, 210);
            this.btnNuevoDispositivo.Name = "btnNuevoDispositivo";
            this.btnNuevoDispositivo.Size = new System.Drawing.Size(50, 23);
            this.btnNuevoDispositivo.TabIndex = 17;
            this.btnNuevoDispositivo.Text = "<-";
            this.btnNuevoDispositivo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nuevo dispositivo";
            // 
            // txtNuevoDispositivo
            // 
            this.txtNuevoDispositivo.Location = new System.Drawing.Point(295, 210);
            this.txtNuevoDispositivo.Name = "txtNuevoDispositivo";
            this.txtNuevoDispositivo.PlaceholderText = "Agregar dispositivo";
            this.txtNuevoDispositivo.Size = new System.Drawing.Size(144, 23);
            this.txtNuevoDispositivo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(34, 351);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(215, 54);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar ticket";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(34, 260);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(405, 84);
            this.txtDescripción.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(112, 109);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(185, 41);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 23);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // comboBoxDispositivo
            // 
            this.comboBoxDispositivo.AutoCompleteCustomSource.AddRange(new string[] {
            "Inactivo"});
            this.comboBoxDispositivo.FormattingEnabled = true;
            this.comboBoxDispositivo.Items.AddRange(new object[] {
            "Notebook",
            "Torre-PC",
            "Movil"});
            this.comboBoxDispositivo.Location = new System.Drawing.Point(112, 210);
            this.comboBoxDispositivo.Name = "comboBoxDispositivo";
            this.comboBoxDispositivo.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDispositivo.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.selectedRowsButton);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(487, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 438);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tickets";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(634, 399);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 33);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizar.Location = new System.Drawing.Point(186, 351);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(145, 37);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectedRowsButton
            // 
            this.selectedRowsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectedRowsButton.Location = new System.Drawing.Point(37, 351);
            this.selectedRowsButton.Name = "selectedRowsButton";
            this.selectedRowsButton.Size = new System.Drawing.Size(143, 37);
            this.selectedRowsButton.TabIndex = 2;
            this.selectedRowsButton.Text = "Eliminar Ticket";
            this.selectedRowsButton.UseVisualStyleBackColor = false;
            this.selectedRowsButton.Click += new System.EventHandler(this.selectedRowsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(621, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // infoNombre
            // 
            this.infoNombre.AutoSize = true;
            this.infoNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.infoNombre.Location = new System.Drawing.Point(6, 37);
            this.infoNombre.Name = "infoNombre";
            this.infoNombre.Size = new System.Drawing.Size(0, 15);
            this.infoNombre.TabIndex = 8;
            // 
            // infoApellido
            // 
            this.infoApellido.AutoSize = true;
            this.infoApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.infoApellido.Location = new System.Drawing.Point(112, 37);
            this.infoApellido.Name = "infoApellido";
            this.infoApellido.Size = new System.Drawing.Size(0, 15);
            this.infoApellido.TabIndex = 9;
            // 
            // infoCorreo
            // 
            this.infoCorreo.AutoSize = true;
            this.infoCorreo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.infoCorreo.Location = new System.Drawing.Point(6, 82);
            this.infoCorreo.Name = "infoCorreo";
            this.infoCorreo.Size = new System.Drawing.Size(0, 15);
            this.infoCorreo.TabIndex = 10;
            // 
            // infoDispositivo
            // 
            this.infoDispositivo.AutoSize = true;
            this.infoDispositivo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.infoDispositivo.Location = new System.Drawing.Point(308, 37);
            this.infoDispositivo.Name = "infoDispositivo";
            this.infoDispositivo.Size = new System.Drawing.Size(0, 15);
            this.infoDispositivo.TabIndex = 11;
            // 
            // infoDescripcion
            // 
            this.infoDescripcion.AutoSize = true;
            this.infoDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.infoDescripcion.Location = new System.Drawing.Point(460, 37);
            this.infoDescripcion.MaximumSize = new System.Drawing.Size(557, 70);
            this.infoDescripcion.Name = "infoDescripcion";
            this.infoDescripcion.Size = new System.Drawing.Size(0, 15);
            this.infoDescripcion.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.infoTicket);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.infoDescripcion);
            this.groupBox3.Controls.Add(this.infoDispositivo);
            this.groupBox3.Controls.Add(this.infoCorreo);
            this.groupBox3.Controls.Add(this.infoApellido);
            this.groupBox3.Controls.Add(this.infoNombre);
            this.groupBox3.Location = new System.Drawing.Point(27, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1191, 115);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información detallada";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(308, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "N° Ticket";
            // 
            // infoTicket
            // 
            this.infoTicket.AutoSize = true;
            this.infoTicket.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.infoTicket.Location = new System.Drawing.Point(308, 82);
            this.infoTicket.Name = "infoTicket";
            this.infoTicket.Size = new System.Drawing.Size(0, 15);
            this.infoTicket.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(6, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Correo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(460, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Descripción";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(308, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dispositivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(112, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre";
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1250, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingreso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectedRowsButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label infoNombre;
        private System.Windows.Forms.Label infoApellido;
        private System.Windows.Forms.Label infoCorreo;
        private System.Windows.Forms.Label infoDispositivo;
        private System.Windows.Forms.Label infoDescripcion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label infoTicket;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBoxDispositivo;
        private System.Windows.Forms.Button btnNuevoDispositivo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNuevoDispositivo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}