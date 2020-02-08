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
    public partial class FrmSala : Form
    {
        String Comunicado;//Almacena el comunicado más reciente para compararlo con los almacenados
        public FrmSala()
        {
            InitializeComponent();
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
            Cls.ClsUsuario ObjUsuario = new Cls.ClsUsuario();
            Bar.Width = this.Width;//Modifico el largo de la barra en base al tamaño del formulario
            DestGVDest.Width = this.Width - 70;//modifico el tamaño de los objetos en pantalla
            DestGVDest.Height = this.Height - 180;
            PnlMensaje.Width = this.Width;
            PnlMensaje.Height= this.Height - Bar.Height;
            CargarComunicado();//Cargo el comunicado por primera vez
            LblFecha.Location= new System.Drawing.Point(((PnlMensaje.Width -150)), LblFecha.Location.Y);//Ubico en base al panel los items
            LblComunicado.Location = new System.Drawing.Point(((PnlMensaje.Width / 2) - (LblComunicado.Width / 2)), LblComunicado.Location.Y);
            LblCreditos.Padding = new System.Windows.Forms.Padding((this.Width / 2) - (LblCreditos.Width / 2), 0, 0, ((4*0)+14));//Modifico el padding ya que el dock del label está en button y así lo centro en base al formulario
            LblContenido.MaximumSize = new Size(PnlMensaje.Width - 159, PnlMensaje.Height - Bar.Height - 114);
            DestGVDest.Location = new System.Drawing.Point(((this.Width / 2) - (DestGVDest.Width / 2)), DestGVDest.Location.Y);
            LblD.Location = new System.Drawing.Point(((this.Width / 2) - (LblD.Width / 2)), LblD.Location.Y);
            DestGVDest.DataSource = ObjUsuario.BuscarFaltas();//Actualizo el gridview de las 
        }
        private void CargarComunicado() {//Carga por primera vez el último comunicado ingresado
            Cls.ClsUsuario ObjUsuario = new Cls.ClsUsuario();
            DataTable DTComunicados = ObjUsuario.BuscarComunicado();
            try{//si no puedo realizarlo sigo
                if (DTComunicados.Rows.Count != 0)
                {//Si existe un comunicado muestro el panel de comunicados y cargo el comunicado
                    PnlMensaje.Visible = true;
                    LblAutor.Text = "AUTOR: " + DTComunicados.Rows[0][0].ToString();
                    LblContenido.Text = DTComunicados.Rows[0][1].ToString();
                    Comunicado = LblContenido.Text;//Almaceno el comunicado como el más reciente
                    DateTime Fecha = DateTime.Parse(DTComunicados.Rows[0][2].ToString());
                    LblFecha.Text = Fecha.Day.ToString() + "/" + Fecha.Month.ToString() + "/" + Fecha.Year.ToString();
                    LblCreditos.Visible = false;
                }
            
                Thread Tr = new Thread(ComprobarComunicadosYFaltasConIngreso);//Comienzo a buscar por nuevo contenido
                Tr.IsBackground = true;//Lo utilizo para que el hilo se cierre con el programa
                Tr.Start();
            }
            catch { }
        }
        private void ComprobarComunicadosYFaltasConIngreso() {//Comprueba si hemos visto el comunicado más reciente
            Cls.ClsUsuario ObjUsuario = new Cls.ClsUsuario();
            DataTable DTComunicados = ObjUsuario.BuscarComunicado();
            if (DTComunicados.Rows.Count != 0)
            {//Si existe un comunicado sigo con los condicionales
                string ComunicadoLocal = DTComunicados.Rows[0][1].ToString();
                if (Comunicado != ComunicadoLocal) {//Si no se ha visto el comunicado lo muestro
                    PnlMensaje.Invoke((MethodInvoker)(() => PnlMensaje.Visible = true));
                    LblAutor.Invoke((MethodInvoker)(() => LblAutor.Text = "AUTOR: " + DTComunicados.Rows[0][0].ToString()));
                    LblContenido.Invoke((MethodInvoker)(() => LblContenido.Text = DTComunicados.Rows[0][1].ToString()));
                    Comunicado = LblContenido.Text;//Almaceno el comunicado como el más reciente
                    DateTime Fecha = DateTime.Parse(DTComunicados.Rows[0][2].ToString());
                    LblFecha.Invoke((MethodInvoker)(() => LblFecha.Text = Fecha.Day.ToString() + "/" + Fecha.Month.ToString() + "/" + Fecha.Year.ToString()));
                    LblCreditos.Invoke((MethodInvoker)(() => LblCreditos.Visible = false));
                }
            }
            try
            {//intento cargar el gridview
                DestGVDest.Invoke((MethodInvoker)(() => DestGVDest.DataSource = ObjUsuario.BuscarFaltas()));//Actualizo el gridview 
            }
            catch {//sino sigo sin detener el programa
            }
            Thread.Sleep(5000);//Duermo el hilo 5 segundos antes de seguir
            ComprobarComunicadosYFaltasConIngreso();//vuelvo a realizarlo
    }
        private void DestGVDest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblD_Click(object sender, EventArgs e)
        {
        }

        private void PnlMensaje_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BttnEntendido_Click(object sender, EventArgs e)
        {
            PnlMensaje.Visible = false;//Si se desea oculto el panel de los comunicados
            LblCreditos.Visible = true;//hago visible los créditos
            BttnEntendido.Enabled = false;//Lo deshabilito y habilito para corregir un bug visual
            BttnEntendido.Enabled = true;
        }
    }
}
