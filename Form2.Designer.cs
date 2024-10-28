using System.Windows.Forms;

namespace ConversorMonedas
{
    partial class Form2
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

        private void InitializeComponent()
        {
            this.checkBoxUSD = new System.Windows.Forms.CheckBox();
            this.checkBoxMXN = new System.Windows.Forms.CheckBox();
            this.checkBoxCAD = new System.Windows.Forms.CheckBox();
            this.checkBoxEUR = new System.Windows.Forms.CheckBox();
            this.checkBoxJPY = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxUSD
            // 
            this.checkBoxUSD.AutoSize = true;
            this.checkBoxUSD.Location = new System.Drawing.Point(12, 12);
            this.checkBoxUSD.Name = "checkBoxUSD";
            this.checkBoxUSD.Size = new System.Drawing.Size(48, 19);
            this.checkBoxUSD.TabIndex = 0;
            this.checkBoxUSD.Text = "USD";
            this.checkBoxUSD.UseVisualStyleBackColor = true;
            // 
            // checkBoxMXN
            // 
            this.checkBoxMXN.AutoSize = true;
            this.checkBoxMXN.Location = new System.Drawing.Point(12, 37);
            this.checkBoxMXN.Name = "checkBoxMXN";
            this.checkBoxMXN.Size = new System.Drawing.Size(53, 19);
            this.checkBoxMXN.TabIndex = 1;
            this.checkBoxMXN.Text = "MXN";
            this.checkBoxMXN.UseVisualStyleBackColor = true;
            // 
            // checkBoxCAD
            // 
            this.checkBoxCAD.AutoSize = true;
            this.checkBoxCAD.Location = new System.Drawing.Point(12, 62);
            this.checkBoxCAD.Name = "checkBoxCAD";
            this.checkBoxCAD.Size = new System.Drawing.Size(50, 19);
            this.checkBoxCAD.TabIndex = 2;
            this.checkBoxCAD.Text = "CAD";
            this.checkBoxCAD.UseVisualStyleBackColor = true;
            // 
            // checkBoxEUR
            // 
            this.checkBoxEUR.AutoSize = true;
            this.checkBoxEUR.Location = new System.Drawing.Point(12, 87);
            this.checkBoxEUR.Name = "checkBoxEUR";
            this.checkBoxEUR.Size = new System.Drawing.Size(47, 19);
            this.checkBoxEUR.TabIndex = 3;
            this.checkBoxEUR.Text = "EUR";
            this.checkBoxEUR.UseVisualStyleBackColor = true;
            // 
            // checkBoxJPY
            // 
            this.checkBoxJPY.AutoSize = true;
            this.checkBoxJPY.Location = new System.Drawing.Point(12, 112);
            this.checkBoxJPY.Name = "checkBoxJPY";
            this.checkBoxJPY.Size = new System.Drawing.Size(44, 19);
            this.checkBoxJPY.TabIndex = 4;
            this.checkBoxJPY.Text = "JPY";
            this.checkBoxJPY.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(136, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(136, 41);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.checkBoxJPY);
            this.Controls.Add(this.checkBoxEUR);
            this.Controls.Add(this.checkBoxCAD);
            this.Controls.Add(this.checkBoxMXN);
            this.Controls.Add(this.checkBoxUSD);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkBoxUSD;
        private System.Windows.Forms.CheckBox checkBoxMXN;
        private System.Windows.Forms.CheckBox checkBoxCAD;
        private System.Windows.Forms.CheckBox checkBoxEUR;
        private System.Windows.Forms.CheckBox checkBoxJPY;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
