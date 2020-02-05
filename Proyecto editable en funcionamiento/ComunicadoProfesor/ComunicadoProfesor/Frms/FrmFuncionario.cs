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
    public partial class FrmFuncionario : Form
    {
        int ModeOFUse = 0; //Variable sobre la cual se confirma qué acción se quiere ejecutar(0 con guardados de faltas, 1 con guardados de comunicados y 2 con limpieza de faltas)
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            SetMaximumLength(TxtFaltaProfesor, 50);//Modifico el largo máximo de los textbox al cargar el formulario
            SetMaximumLength(TxtFaltaCurso, 50);
            SetMaximumLength(TxtAutor, 50);
            SetMaximumLength(TxtMensaje, 1700);
        }
        private void SetMaximumLength(Bunifu.Framework.UI.BunifuMaterialTextbox metroTextbox, int maximumLength)
        {//Modifico el largo máximo del textbox
            foreach (Control ctl in metroTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = maximumLength;
                }
            }
        }
        private void BttnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();//Cierro el programa
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BttnClosePanel_Click(object sender, EventArgs e)
        {//Si no se quiere seguir con lo seleccionado oculto el panel
            PnlAlert.Visible = false;
        }

        private void TxtFaltaProfesor_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtFaltaProfesor_Leave(object sender, EventArgs e)
        {
            if (TxtFaltaProfesor.Text == "") {//Si el campo se encuentra sin contenido lo aviso
                LblVProfesor.Visible = true;
            }
        }

        private void TxtFaltaProfesor_Enter(object sender, EventArgs e)
        {
            LblVProfesor.Visible = false;//Si se modifica el valor oculto la advertencia
        }

        private void TxtFaltaCurso_Leave(object sender, EventArgs e)
        {
            if (TxtFaltaCurso.Text == "")
            {//Si el campo se encuentra sin contenido lo aviso
                LblVCurso.Visible = true;
            }
        }

        private void TxtFaltaCurso_Enter(object sender, EventArgs e)
        {//Si se entra en el textbox oculto el mensaje de advertencia
                LblVCurso.Visible = false;
        }

        private void BttnAFalta_Click(object sender, EventArgs e)
        {
            if (CanDOFuncionario()) {//Si puedo ingresar el funcionario lo ingreso
                PnlAlert.Visible = true;
                LblAlertaComentario.Text = "¿Seguro que desea agregar la falta?";
                ModeOFUse = 0;
            }
        }
        private void LimpiarFormulario() {//Limpio el formulario
            TxtFaltaProfesor.Text = "";
            TxtFaltaCurso.Text = "";
            TxtAutor.Text = "";
            TxtMensaje.Text = "";
            DTPFecha.ResetText();
        }
        private bool CanDOFuncionario() {//Controlo si todos los datos han sido ingresados
            bool Can = true;
            if (TxtFaltaProfesor.Text == "") {
                Can = false;
                LblVProfesor.Visible = true;
            }
            if (TxtFaltaCurso.Text == "")
            {
                Can = false;
                LblVCurso.Visible = true;
            }
            return Can;
        }
        private bool CanDOComunicado()
        {//Controlo si todos los datos han sido ingresados
            bool Can = true;
            if (TxtAutor.Text == "")
            {
                Can = false;
                LblVAutor.Visible = true;
            }
            if (TxtMensaje.Text == "")
            {
                Can = false;
                LblVMensaje.Visible = true;
            }
            return Can;
        }
        private void button4_Click(object sender, EventArgs e)
        {//Si no se desea continuar oculto el panel de alerta
            PnlAlert.Visible = false;
        }

        private void TxtAutor_Leave(object sender, EventArgs e)
        {
            if (TxtAutor.Text == "")
            {//Si el campo se encuentra sin contenido lo aviso
                LblVAutor.Visible = true;
            }
        }

        private void TxtAutor_Enter(object sender, EventArgs e)
        {
            LblVAutor.Visible = false;//Si se intenta escribir en el campo oculto la advertencia
        }

        private void TxtMensaje_Leave(object sender, EventArgs e)
        {
            if (TxtMensaje.Text == "")
            {//Si el campo se encuentra sin contenido lo aviso
                LblVMensaje.Visible = true;
            }
        }

        private void TxtMensaje_Enter(object sender, EventArgs e)
        {
            LblVMensaje.Visible = false;//Lo oculto en caso de que se intente escribir en el campo seleccionado
        }

        private void BttnAComunicado_Click(object sender, EventArgs e)
        {
            if (CanDOComunicado()) {//Si puedo ingresar el comunicado consulto si se desea ingresar
                PnlAlert.Visible = true;
                LblAlertaComentario.Text = "¿Seguro que desea enviar el comunicado?";
                ModeOFUse = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cls.ClsUsuario ObjUsuario = new Cls.ClsUsuario();
            switch (ModeOFUse) {
                case 0://Ingreso la falta
                    Cls.ClsFaltaDeHoy ObjFalta;
                    String Profesor;
                    String Curso;
                    Profesor = TxtFaltaProfesor.Text;
                    Curso = TxtFaltaCurso.Text;
                    ObjFalta = new Cls.ClsFaltaDeHoy(Profesor, Curso);
                    ObjUsuario.AFaltaDeHoy(ObjFalta);
                    break;
                case 1://Ingreso el comunicado
                    Cls.ClsComunicados ObjComunicado;
                    String Autor;
                    String Mensaje;
                    DateTime Fecha;
                    Autor = TxtAutor.Text;
                    Mensaje = TxtMensaje.Text;
                    Fecha = DTPFecha.Value;
                    ObjComunicado = new Cls.ClsComunicados(Autor,Mensaje,Fecha);
                    ObjUsuario.LimpiarComunicados();//Borro el comunicado anterior antes de ingresar el siguiente
                    ObjUsuario.AComunicado(ObjComunicado);
                    break;
                case 2://Limpio los registros de las faltas ingresados
                    ObjUsuario.LimpiarFaltas();
                    break;
            }
            LimpiarFormulario();//Limpio el formulario
            PnlAlert.Visible = false;
        }

        private void BttnCFalta_Click(object sender, EventArgs e)
        {//Consulto si se desea eliminar las faltas de los profesores ingresadas 
            PnlAlert.Visible = true;
            LblAlertaComentario.Text = "¿Seguro que desea limpiar las faltas?";
            ModeOFUse = 2;
        }
    }
}
