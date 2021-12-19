using CalculatorBombCrypto.View.Aplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorBombCrypto
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            panelAzul.Size = new Size(panelAzul.Size.Width, 30);
        }

        int panelAzul_y = 30; int waiter = 0;
        private void timerLoading_Tick(object sender, EventArgs e)
        {
            waiter++;
            if (waiter > 150)
            {
                lblConectando.Hide();
                panelAzul_y += 6;
                panelAzul.Size = new Size(panelAzul.Size.Width, panelAzul_y);
                if (panelAzul_y > 450)
                {
                    panelAmarelo.Hide();
                    timerLoading.Enabled = false;
                }
            }

        }

        private void picBonecoCrypto_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void picEntrarApp_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Hide();
        }
    }
}
