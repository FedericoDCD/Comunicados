using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicadoProfesor
{
    public partial class FrmAlert : Form
    {
        public FrmAlert(String Error)
        {
            InitializeComponent();
            LblAlertaComentario.Text = Error;
        }

        private void PnlAlert_Paint(object sender, PaintEventArgs e)
        {

        }
     

        private void FrmAlert_Load(object sender, EventArgs e)
        {

        }

        private void BttnAlertaSi_Click(object sender, EventArgs e)
        {
            Application.Exit();//Cierro el programa
        }

        private void BttnClosePanel_Click(object sender, EventArgs e)
        {
            Application.Exit();//Cierro el programa
        }
    }
}
