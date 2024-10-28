using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConversorMonedas
{
    public partial class Form1 : Form
    {
        public List<string> MonedasSeleccionadas { get; set; }

        public Form1()
        {
            InitializeComponent();
            MonedasSeleccionadas = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMonedas.Items.Add("USD - D�lar Estadounidense");
            comboBoxMonedas.Items.Add("MXN - Peso Mexicano");
            comboBoxMonedas.Items.Add("CAD - D�lar Canadiense");
            comboBoxMonedas.Items.Add("EUR - Euro");
            comboBoxMonedas.Items.Add("JPY - Yen Japon�s");
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double monto;
            if (double.TryParse(textBoxMonto.Text, out monto))
            {
                listBoxConversiones.Items.Clear();
                string monedaSeleccionada = comboBoxMonedas.SelectedItem?.ToString();

                if (monedaSeleccionada != null)
                {
                    // Aqu� puedes a�adir la l�gica de conversi�n que desees
                    listBoxConversiones.Items.Add($"{monto} en {monedaSeleccionada} es ..."); // Ejemplo de salida
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una moneda.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un monto v�lido.");
            }
        }

        private void buttonSeleccionarMonedas_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }
    }
}
