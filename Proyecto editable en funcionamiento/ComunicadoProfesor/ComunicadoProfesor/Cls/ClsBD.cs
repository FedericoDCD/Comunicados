using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComunicadoProfesor.Cls
{
    class ClsBD
    {
        //Guardo la stringconnection y realizo las conexiones necesarias y métodos para mejorar su uso desde otras clases
        //string StringConnection = "Data Source=(local);Initial Catalog = BDComunicacion; Integrated Security = True";
        string StringConnection = "Data Source = SQL5045.site4now.net; Initial Catalog = DB_A550BE_BDComunicados; User Id = DB_A550BE_BDComunicados_admin; Password=2Comunidad;";
        public SqlConnection Conn = new SqlConnection();
        public ClsBD()
        {
            Conn.ConnectionString = StringConnection;
        }
        public void Open()
        {//Abro la conexión
            try
            {
                Conn.Open();
            }
            catch (Exception ex)
            {
                FrmAlert FrmAlerta = new FrmAlert("No se pudo conectar con la base de datos");
                Form.ActiveForm.Close();
                FrmAlerta.Show();
                Console.WriteLine(ex.Message);
            }

        }
        public void Close()
        {//Cierro la conexión
            try
            {
                Conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
