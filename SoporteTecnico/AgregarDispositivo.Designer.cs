
namespace SoporteTecnico
{
    partial class AgregarDispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarDispositivo));
            this.btnAgregarDispositivo = new System.Windows.Forms.Button();
            this.txtAgregarDispositivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarDispositivo
            // 
            this.btnAgregarDispositivo.Location = new System.Drawing.Point(60, 132);
            this.btnAgregarDispositivo.Name = "btnAgregarDispositivo";
            this.btnAgregarDispositivo.Size = new System.Drawing.Size(147, 50);
            this.btnAgregarDispositivo.TabIndex = 0;
            this.btnAgregarDispositivo.Text = "Agregar";
            this.btnAgregarDispositivo.UseVisualStyleBackColor = true;
            this.btnAgregarDispositivo.Click += new System.EventHandler(this.btnAgregarDispositivo_Click);
            // 
            // txtAgregarDispositivo
            // 
            this.txtAgregarDispositivo.Location = new System.Drawing.Point(60, 86);
            this.txtAgregarDispositivo.Name = "txtAgregarDispositivo";
            this.txtAgregarDispositivo.PlaceholderText = "Nombre del dispositivo";
            this.txtAgregarDispositivo.Size = new System.Drawing.Size(148, 23);
            this.txtAgregarDispositivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar un nuevo dispositivo";
            // 
            // AgregarDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAgregarDispositivo);
            this.Controls.Add(this.btnAgregarDispositivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarDispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarDispositivo;
        private System.Windows.Forms.TextBox txtAgregarDispositivo;
        private System.Windows.Forms.Label label1;
    }
}