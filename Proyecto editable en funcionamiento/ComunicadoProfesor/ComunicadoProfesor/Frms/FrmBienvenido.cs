using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicadoProfesor
{
    public partial class FrmBienvenido : Form
    {
        private static Form MyForm;
        private static int IndexUser = 1;//si es uno es un perfil administativo, si es 0 es una sala
        public FrmBienvenido()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creo un hilo con el método que carga el formulario de nuevos usuarios
            MyForm = new FrmBienvenido();
            Thread Tr = new Thread(LoadFormNewUsers);
            Tr.Start();
        }
        private void LoadFormNewUsers()
        {//Cargo el formulario de registro
            Thread.Sleep(5000);
            if (IndexUser==0)//si es una sala en la que se utiliza el programa se abrirá en modo sala
            {
                FrmSala ObjNewUser = new FrmSala();
                this.Invoke(new MethodInvoker(Close));//Invoco por separado el close del formulario para poder cerrarlo
                ObjNewUser.Show();
            }
            else
            {//Sino será un usuario administrativo, y en consecuencia abriré el menú para que pueda realizar los comunicados
                FrmFuncionario ObjIndex = new FrmFuncionario();
                this.Invoke(new MethodInvoker(Close));//Invoco por separado el close del formulario para poder cerrarlo
                ObjIndex.Show();
            }
            Application.Run();//Permite que la app siga ejecutandose en el hilo
        }
    }
}
