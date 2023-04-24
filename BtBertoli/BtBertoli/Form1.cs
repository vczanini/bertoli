using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtBertoli
{
    public partial class Eletroestimulador : Form
    {
        double value = 0;
        public Eletroestimulador()
        {
            InitializeComponent();
            Tx_Value.Text = (value.ToString() + " mA");
        }

        private void Bt_5map_Click(object sender, EventArgs e)
        {
            value = value + 0.5;
            if (value >= 3)
            {
                value = 3;
            }
            Tx_Value.Text = (value.ToString() + " mA");
            // Enviar o valor via bluetooth
        }

        private void Bt_1am_Click(object sender, EventArgs e)
        {
            value = value + 0.1;
            if (value >= 3)
            {
                value = 3;
            }
            Tx_Value.Text = (value.ToString() + " mA");
            // Enviar o valor via bluetooth
        }

        private void Bt_1an_Click(object sender, EventArgs e)
        {
            value = value - 0.1;
            if(value < 0)
            {
                value = 0;
            }
            Tx_Value.Text = (value.ToString() + " mA");
            // Enviar o valor via bluetooth
        }

        private void Bt_5man_Click(object sender, EventArgs e)
        {
            value = value - 0.5;
            if (value < 0)
            {
                value = 0;
            }
            Tx_Value.Text = (value.ToString() + " mA");

            // Enviar o valor via bluetooth
        }

        private void Eletroestimulador_Load(object sender, EventArgs e)
        {
            // Cliquei sem querer, mas da mt rolo tirar. Nao mexer
        }

        private void Bt_Connect_Click(object sender, EventArgs e)
        {
            // Montar a conexão por bluetooh aqui dentro
            Lb_Connect.Text = "Conectado";
        }

        private void Bt_Start_Click(object sender, EventArgs e)
        {
            // Colocar o comando de inicio aqui dentro
            Lb_Start.Text = "Iniciado";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Tx_Value_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
