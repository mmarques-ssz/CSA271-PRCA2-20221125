using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLeds
{
    public partial class Form1 : Form
    {
        private Lampada lampada;
        public Form1()
        {
            InitializeComponent();
            lampada = new Lampada(true);
            atualizaInterface();
        }

        private void acener(object sender, EventArgs e)
        {
            lampada.acender();
            atualizaInterface();
        }

        private void apagar(object sender, EventArgs e)
        {
            lampada.apagar();
            atualizaInterface();
        }
        private void atualizaInterface()
        {
            picLampada.Image =
                            (lampada.getEstado() ?
                            projLeds.Properties.Resources.acesa :
                            projLeds.Properties.Resources.apagada);
            btnOnOff.Text = (lampada.getEstado() ? "Off" : "On");
        }

        private void onoff(object sender, EventArgs e)
        {
            if (lampada.getEstado())
            {
                lampada.apagar();
            }
            else
            {
                lampada.acender();
            }
            atualizaInterface();
        }
    }
}
