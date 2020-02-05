using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunicadoProfesor.Cls
{
    class ClsUsuario
    {
        public void AFaltaDeHoy(ClsFaltaDeHoy ObjFaltaDeHoy) {//Ingreso la falta
            ClsBD BD = new ClsBD();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores de la falta
            String Profesor = ObjFaltaDeHoy.GetProfesor();
            String Curso = ObjFaltaDeHoy.GetCurso();

            using (SqlCommand comand = new SqlCommand("PRAAltaFaltaDeHoy", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@Profesor", Profesor));
                    comand.Parameters.Add(new SqlParameter("@Curso", Curso));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public void AComunicado(ClsComunicados ObjComunicado)
        {//Ingreso la falta
            ClsBD BD = new ClsBD();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores del comunicado
            String Autor = ObjComunicado.GetAutor();
            String Mensaje = ObjComunicado.GetMensaje();
            DateTime Fecha = ObjComunicado.GetFecha();

            using (SqlCommand comand = new SqlCommand("PRAAltaComunicado", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@Autor", Autor));
                    comand.Parameters.Add(new SqlParameter("@Mensaje", Mensaje));
                    comand.Parameters.Add(new SqlParameter("@Fecha", Fecha));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public System.Data.DataTable BuscarComunicado()
        {
            ClsBD BD = new ClsBD();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarComunicado", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
        public System.Data.DataTable BuscarFaltas()
        {
            ClsBD BD = new ClsBD();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarFaltas", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
        public void LimpiarFaltas()
        {//Ingreso la falta
            ClsBD BD = new ClsBD();//Creo un objeto de la clase de base de datos para utilizarla y realizar la 
            using (SqlCommand comand = new SqlCommand("PRALimpiarFaltaDeHoy", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al limpiar: " + ex.Message);
                }
            }
        }
        public void LimpiarComunicados()
        {//Ingreso la falta
            ClsBD BD = new ClsBD();//Creo un objeto de la clase de base de datos para utilizarla y realizar la 
            using (SqlCommand comand = new SqlCommand("PRALimpiarComunicados", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al limpiar: " + ex.Message);
                }
            }
        }
        public void BCComunicados() {
           // using (TableDependency.SqlClient.SqlTableDependency<> ) {
            //}
        }
    }
}
