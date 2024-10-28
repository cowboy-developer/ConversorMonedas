using System.Windows.Forms;

namespace ConversorMonedas
{
    partial class Form1
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
            this.comboBoxMonedas = new System.Windows.Forms.ComboBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.listBoxConversiones = new System.Windows.Forms.ListBox();
            this.buttonSeleccionarMonedas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMonedas
            // 
            this.comboBoxMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonedas.FormattingEnabled = true;
            this.comboBoxMonedas.Location = new System.Drawing.Point(12, 12);
            this.comboBoxMonedas.Name = "comboBoxMonedas";
            this.comboBoxMonedas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonedas.TabIndex = 0;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(139, 12);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonto.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(245, 10);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 2;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // listBoxConversiones
            // 
            this.listBoxConversiones.FormattingEnabled = true;
            this.listBoxConversiones.Location = new System.Drawing.Point(12, 39);
            this.listBoxConversiones.Name = "listBoxConversiones";
            this.listBoxConversiones.Size = new System.Drawing.Size(308, 199);
            this.listBoxConversiones.TabIndex = 3;
            // 
            // buttonSeleccionarMonedas
            // 
            this.buttonSeleccionarMonedas.Location = new System.Drawing.Point(12, 244);
            this.buttonSeleccionarMonedas.Name = "buttonSeleccionarMonedas";
            this.buttonSeleccionarMonedas.Size = new System.Drawing.Size(136, 23);
            this.buttonSeleccionarMonedas.TabIndex = 4;
            this.buttonSeleccionarMonedas.Text = "Seleccionar Monedas";
            this.buttonSeleccionarMonedas.UseVisualStyleBackColor = true;
            this.buttonSeleccionarMonedas.Click += new System.EventHandler(this.buttonSeleccionarMonedas_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(332, 273);
            this.Controls.Add(this.buttonSeleccionarMonedas);
            this.Controls.Add(this.listBoxConversiones);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.comboBoxMonedas);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxMonedas;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.ListBox listBoxConversiones;
        private System.Windows.Forms.Button buttonSeleccionarMonedas;
    }
}
