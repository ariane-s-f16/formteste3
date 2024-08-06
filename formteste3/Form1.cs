using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formteste3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(mostrarrenda.Text);
            double n2= double.Parse(mostrarenergia.Text);
            double n3= double.Parse(mostraragua.Text);
            double n4= double.Parse(mostrargastos.Text);
            double n5= double.Parse(mostraralimentacao.Text);
            double n6= double.Parse(mostraroutros.Text);
            
            double saldo2= (((((n1-n2)-n3)-n4)-n5)-n6);

            double valor_total= n2+n3+n4+n5+n6;

            mostrartotal.Text= valor_total.ToString();
            mostrarsaldo.Text= saldo2.ToString();

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            mostrartotal.Clear();
            mostrarsaldo.Clear();
            mostraragua.Clear();
            mostraralimentacao.Clear();
            mostrarenergia.Clear();
            mostrargastos.Clear();
            mostraroutros.Clear();   

        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
