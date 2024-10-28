using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConversorMonedas
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            form1.MonedasSeleccionadas.Clear();

            if (checkBoxUSD.Checked) form1.MonedasSeleccionadas.Add("USD - Dólar Estadounidense");
            if (checkBoxMXN.Checked) form1.MonedasSeleccionadas.Add("MXN - Peso Mexicano");
            if (checkBoxCAD.Checked) form1.MonedasSeleccionadas.Add("CAD - Dólar Canadiense");
            if (checkBoxEUR.Checked) form1.MonedasSeleccionadas.Add("EUR - Euro");
            if (checkBoxJPY.Checked) form1.MonedasSeleccionadas.Add("JPY - Yen Japonés");

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
