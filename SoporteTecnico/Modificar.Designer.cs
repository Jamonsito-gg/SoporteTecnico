
namespace SoporteTecnico
{
    partial class Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxModiEstado = new System.Windows.Forms.ComboBox();
            this.modiNombre = new System.Windows.Forms.TextBox();
            this.modiApellido = new System.Windows.Forms.TextBox();
            this.modiCorreo = new System.Windows.Forms.TextBox();
            this.modiDescripción = new System.Windows.Forms.TextBox();
            this.btnCerrarModi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(40, 348);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 41);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripción";
            // 
            // comboBoxModiEstado
            // 
            this.comboBoxModiEstado.FormattingEnabled = true;
            this.comboBoxModiEstado.Items.AddRange(new object[] {
            "Inactivo",
            "Reparando",
            "Completado"});
            this.comboBoxModiEstado.Location = new System.Drawing.Point(117, 156);
            this.comboBoxModiEstado.Name = "comboBoxModiEstado";
            this.comboBoxModiEstado.Size = new System.Drawing.Size(157, 23);
            this.comboBoxModiEstado.TabIndex = 6;
            // 
            // modiNombre
            // 
            this.modiNombre.Location = new System.Drawing.Point(117, 32);
            this.modiNombre.Name = "modiNombre";
            this.modiNombre.Size = new System.Drawing.Size(157, 23);
            this.modiNombre.TabIndex = 7;
            // 
            // modiApellido
            // 
            this.modiApellido.Location = new System.Drawing.Point(117, 74);
            this.modiApellido.Name = "modiApellido";
            this.modiApellido.Size = new System.Drawing.Size(157, 23);
            this.modiApellido.TabIndex = 8;
            // 
            // modiCorreo
            // 
            this.modiCorreo.Location = new System.Drawing.Point(117, 114);
            this.modiCorreo.Name = "modiCorreo";
            this.modiCorreo.Size = new System.Drawing.Size(157, 23);
            this.modiCorreo.TabIndex = 9;
            // 
            // modiDescripción
            // 
            this.modiDescripción.Location = new System.Drawing.Point(40, 217);
            this.modiDescripción.Multiline = true;
            this.modiDescripción.Name = "modiDescripción";
            this.modiDescripción.Size = new System.Drawing.Size(305, 106);
            this.modiDescripción.TabIndex = 10;
            // 
            // btnCerrarModi
            // 
            this.btnCerrarModi.Location = new System.Drawing.Point(247, 348);
            this.btnCerrarModi.Name = "btnCerrarModi";
            this.btnCerrarModi.Size = new System.Drawing.Size(98, 41);
            this.btnCerrarModi.TabIndex = 11;
            this.btnCerrarModi.Text = "Cerrar";
            this.btnCerrarModi.UseVisualStyleBackColor = true;
            this.btnCerrarModi.Click += new System.EventHandler(this.btnCerrarModi_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 418);
            this.Controls.Add(this.btnCerrarModi);
            this.Controls.Add(this.modiDescripción);
            this.Controls.Add(this.modiCorreo);
            this.Controls.Add(this.modiApellido);
            this.Controls.Add(this.modiNombre);
            this.Controls.Add(this.comboBoxModiEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxModiEstado;
        public System.Windows.Forms.TextBox modiNombre;
        public System.Windows.Forms.TextBox modiApellido;
        public System.Windows.Forms.TextBox modiCorreo;
        public System.Windows.Forms.TextBox modiDescripción;
        private System.Windows.Forms.Button btnCerrarModi;
    }
}