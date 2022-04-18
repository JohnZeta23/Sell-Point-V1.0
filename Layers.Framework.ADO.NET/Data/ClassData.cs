using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Layers.Framework.ADO.NET.Data
{
    public static class ClassData
    {
        public static string stringConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        public static SqlConnection OpenDBSQLServer()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ClassData.stringConnection.ToString();
            sqlConnection.Open();

            return sqlConnection;
        }

        public static SqlCommand sqlCommand(string sql, CommandType commandtypeSQL)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = ClassData.OpenDBSQLServer();
            sqlCommand.CommandType = commandtypeSQL;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            return sqlCommand;
        }

        public static SqlDataReader SQLDatareader(SqlCommand sqlCommandSQL)
        {
            SqlDataReader sqlDataReader = sqlCommandSQL.ExecuteReader();
            sqlDataReader.Read();
            return sqlDataReader;
        }

        public static SqlDataAdapter SQLDataAdapter(SqlCommand sqlCommandSQL)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandSQL);
            return sqlDataAdapter;
        }

        //CODIGO PARA LA CONSULTA INSERT DE LA ENTIDAD

        public static void RegistroEntidad(string Descripcion, string Direccion, string Localidad,
           string TipoEntidad, string TipoDocumento, string NumeroDocumento, string Teléfonos,
           string URLPaginaWeb, string URLFacebook, string URLInstagram, string URLTwitter,
           string URLTikTok, string GrupoEntidad, string TipoEntidad2, int LimiteCredito, string UserNameEntidad,
           string PasswordEntidad, string RolUserEntidad, string Comentario, string Status,
           int NoEliminable)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpEntidadesInsertar";

                DataTable SQLdatatable = new DataTable();

                    ClassData.SQLDataAdapter(
                        ClassData.sqlCommand("Select IdGrupoEntidad from GrupoEntidades Where Descripcion ='"
                        + GrupoEntidad + "'",
                        CommandType.Text)).Fill(SQLdatatable);

                DataTable SQLdatatable2 = new DataTable();

                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select IdTipoEntidad from TipoEntidades Where Descripcion ='"
                    + TipoEntidad2 + "' and IdGrupoEntidad = '"+ Convert.ToInt32(SQLdatatable.Rows[0][0]) + "'",
                    CommandType.Text)).Fill(SQLdatatable2);

                sqlCommand.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
                sqlCommand.Parameters.AddWithValue("@DIRECCION", Direccion);
                sqlCommand.Parameters.AddWithValue("@LOCALIDAD", Localidad);
                sqlCommand.Parameters.AddWithValue("@TIPOENTIDAD", TipoEntidad);
                sqlCommand.Parameters.AddWithValue("@TIPODOCUMENTO", TipoDocumento);
                sqlCommand.Parameters.AddWithValue("@NUMERODOCUMENTO", NumeroDocumento);
                sqlCommand.Parameters.AddWithValue("@TELÉFONOS", Teléfonos);
                sqlCommand.Parameters.AddWithValue("@URLPAGINAWEB", URLPaginaWeb);
                sqlCommand.Parameters.AddWithValue("@URLFACEBOOK", URLFacebook);
                sqlCommand.Parameters.AddWithValue("@URLINSTAGRAM", URLInstagram);
                sqlCommand.Parameters.AddWithValue("@URLTWITTER", URLTwitter);
                sqlCommand.Parameters.AddWithValue("@URLTIKTOK", URLTikTok);
                sqlCommand.Parameters.AddWithValue("@IDGRUPOENTIDAD", Convert.ToInt32(SQLdatatable.Rows[0][0]));
                sqlCommand.Parameters.AddWithValue("@IDTIPOENTIDAD", Convert.ToInt32(SQLdatatable2.Rows[0][0]));
                sqlCommand.Parameters.AddWithValue("@LIMITECREDITO", LimiteCredito);
                sqlCommand.Parameters.AddWithValue("@USERNAMEENTIDAD", UserNameEntidad);
                sqlCommand.Parameters.AddWithValue("@PASSWORDENTIDAD", PasswordEntidad);
                sqlCommand.Parameters.AddWithValue("@ROLUSERENTIDAD", RolUserEntidad);
                sqlCommand.Parameters.AddWithValue("@COMENTARIO", Comentario);
                sqlCommand.Parameters.AddWithValue("@STATUS", Status);
                sqlCommand.Parameters.AddWithValue("@NOELIMINABLE", NoEliminable);

                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

        }

        //CODIGO PARA LA CONSULTA UPDATE DE LA ENTIDAD

        public static void EditarEntidad(int IdEntidad, string Descripcion, string Direccion, string Localidad,
           string TipoEntidad, string TipoDocumento, string NumeroDocumento, string Teléfonos,
           string URLPaginaWeb, string URLFacebook, string URLInstagram, string URLTwitter,
           string URLTikTok, string IdGrupoEntidad, string IdTipoEntidad, int LimiteCredito, string UserNameEntidad,
           string PasswordEntidad, string RolUserEntidad, string Comentario, string Status,
           int NoEliminable)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpEntidadesActualizar";

                DataTable SQLdatatable = new DataTable();

                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select IdGrupoEntidad from GrupoEntidades Where Descripcion ='"
                    + IdGrupoEntidad + "'",
                    CommandType.Text)).Fill(SQLdatatable);

                DataTable SQLdatatable2 = new DataTable();

                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select IdTipoEntidad from TipoEntidades Where Descripcion ='"
                    + IdTipoEntidad + "' and IdGrupoEntidad = '" + Convert.ToInt32(SQLdatatable.Rows[0][0]) + "'",
                    CommandType.Text)).Fill(SQLdatatable2);

                sqlCommand.Parameters.AddWithValue("@IDENTIDAD", IdEntidad);
                sqlCommand.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
                sqlCommand.Parameters.AddWithValue("@DIRECCION", Direccion);
                sqlCommand.Parameters.AddWithValue("@LOCALIDAD", Localidad);
                sqlCommand.Parameters.AddWithValue("@TIPOENTIDAD", TipoEntidad);
                sqlCommand.Parameters.AddWithValue("@TIPODOCUMENTO", TipoDocumento);
                sqlCommand.Parameters.AddWithValue("@NUMERODOCUMENTO", NumeroDocumento);
                sqlCommand.Parameters.AddWithValue("@TELÉFONOS", Teléfonos);
                sqlCommand.Parameters.AddWithValue("@URLPAGINAWEB", URLPaginaWeb);
                sqlCommand.Parameters.AddWithValue("@URLFACEBOOK", URLFacebook);
                sqlCommand.Parameters.AddWithValue("@URLINSTAGRAM", URLInstagram);
                sqlCommand.Parameters.AddWithValue("@URLTWITTER", URLTwitter);
                sqlCommand.Parameters.AddWithValue("@URLTIKTOK", URLTikTok);
                sqlCommand.Parameters.AddWithValue("@IDGRUPOENTIDAD", Convert.ToInt32(SQLdatatable.Rows[0][0]));
                sqlCommand.Parameters.AddWithValue("@IDTIPOENTIDAD", Convert.ToInt32(SQLdatatable2.Rows[0][0]));
                sqlCommand.Parameters.AddWithValue("@LIMITECREDITO", LimiteCredito);
                sqlCommand.Parameters.AddWithValue("@USERNAMEENTIDAD", UserNameEntidad);
                sqlCommand.Parameters.AddWithValue("@PASSWORDENTIDAD", PasswordEntidad);
                sqlCommand.Parameters.AddWithValue("@ROLUSERENTIDAD", RolUserEntidad);
                sqlCommand.Parameters.AddWithValue("@COMENTARIO", Comentario);
                sqlCommand.Parameters.AddWithValue("@STATUS", Status);
                sqlCommand.Parameters.AddWithValue("@NOELIMINABLE", NoEliminable);

                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

        }

        //CODIGO PARA LA CONSULTA SELECT QUE SE REQUIERE PARA EL UPDATE DE LA ENTIDAD

        public static int NoEliminable = 0, LimiteCredito = 0;

        public static string Descripcion = "", Direccion = "", Localidad = "",
        TipoEntidad = "", TipoDocumento = "", NumeroDocumento = "", Teléfonos = "",
        URLPaginaWeb = "", URLFacebook = "", URLInstagram = "", URLTwitter = "",
        URLTikTok = "", UserNameEntidad = "", GrupoEntidad = "", TipoEntidad2 = "",
        PasswordEntidad = "", RolUserEntidad = "", Comentario = "", Status = "";

        public static void LlenarEntidad(int IdEntidad)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpEntidadesObtener";

                sqlCommand.Parameters.AddWithValue("@IdEntidad", IdEntidad);

                sqlCommand.ExecuteNonQuery();

                DataTable SQLdatatable = new DataTable();

                SqlDataAdapter datadapter = new SqlDataAdapter(sqlCommand);

                datadapter.Fill(SQLdatatable);


                DataTable SQLdatatable2 = new DataTable();

                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select Descripcion from GrupoEntidades Where IdGrupoEntidad ='"
                    + Convert.ToInt32(SQLdatatable.Rows[0][13]) + "'",
                    CommandType.Text)).Fill(SQLdatatable2);

                DataTable SQLdatatable3 = new DataTable();

                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select Descripcion from TipoEntidades Where IdTipoEntidad ='"
                    + Convert.ToInt32(SQLdatatable.Rows[0][14]) + "'",
                    CommandType.Text)).Fill(SQLdatatable3);


                if (SQLdatatable.Rows.Count > 0)
                {
                    Descripcion = SQLdatatable.Rows[0][1].ToString();
                    Direccion = SQLdatatable.Rows[0][2].ToString();
                    Localidad = SQLdatatable.Rows[0][3].ToString();
                    TipoDocumento = SQLdatatable.Rows[0][5].ToString();
                    NumeroDocumento = SQLdatatable.Rows[0][6].ToString();
                    Teléfonos = SQLdatatable.Rows[0][7].ToString();
                    URLPaginaWeb = SQLdatatable.Rows[0][8].ToString();
                    URLFacebook = SQLdatatable.Rows[0][9].ToString();
                    URLInstagram = SQLdatatable.Rows[0][10].ToString();
                    URLTwitter = SQLdatatable.Rows[0][11].ToString();
                    URLTikTok = SQLdatatable.Rows[0][12].ToString();
                    GrupoEntidad = SQLdatatable2.Rows[0][0].ToString();
                    TipoEntidad2 = SQLdatatable3.Rows[0][0].ToString();
                    LimiteCredito = Convert.ToInt32(SQLdatatable.Rows[0][15]);
                    UserNameEntidad = SQLdatatable.Rows[0][16].ToString();
                    PasswordEntidad = SQLdatatable.Rows[0][17].ToString();
                    RolUserEntidad = SQLdatatable.Rows[0][18].ToString();
                    Comentario = SQLdatatable.Rows[0][19].ToString();
                    Status = SQLdatatable.Rows[0][20].ToString();
                    NoEliminable = Convert.ToInt32(SQLdatatable.Rows[0][21].ToString());
                }
            }

            catch (Exception ex)
            {
               System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }


        }
        //CODIGO PARA LA CONSULTA DELETE DE LA ENTIDAD
        public static void EliminarEntidad(int IdEntidad, string Nombre)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpEntidadesEliminar";

                sqlCommand.Parameters.AddWithValue("@IdEntidad", IdEntidad);
                sqlCommand.Parameters.AddWithValue("@Descripcion", Nombre);

                sqlCommand.ExecuteNonQuery();

                DataTable SQLdatatable = new DataTable();

                SqlDataAdapter datadapter = new SqlDataAdapter(sqlCommand);

                datadapter.Fill(SQLdatatable);

            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

        }

        //CODIGO PARA LA CONSULTA INSERT DEl GRUPO ENTIDAD

        public static void RegistroGrupoEntidad(string Descripcion, string Comentario, string Status,
           int NoEliminable)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpGrupoEntidadesInsert";

                sqlCommand.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
                sqlCommand.Parameters.AddWithValue("@COMENTARIO", Comentario);
                sqlCommand.Parameters.AddWithValue("@STATUS", Status);
                sqlCommand.Parameters.AddWithValue("@NOELIMINABLE", NoEliminable);

                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

        }

        //CODIGO PARA LA CONSULTA UPDATE DEl GRUPO ENTIDAD

        public static void EditarGrupoEntidad(int IdGrupoEntidad, string Descripcion, string Comentario, string Status,
           int NoEliminable)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpGrupoEntidadesActualizar";

                sqlCommand.Parameters.AddWithValue("@IDGRUPOENTIDAD", IdGrupoEntidad);
                sqlCommand.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
                sqlCommand.Parameters.AddWithValue("@COMENTARIO", Comentario);
                sqlCommand.Parameters.AddWithValue("@STATUS", Status);
                sqlCommand.Parameters.AddWithValue("@NOELIMINABLE", NoEliminable);

                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

        }

        //CODIGO PARA LA CONSULTA SELECT QUE SE REQUIERE PARA EL UPDATE DEl GRUPO ENTIDAD

        public static void LlenarGrupoEntidad(int IdGrupoEntidad)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpGrupoEntidadesObtener";

                sqlCommand.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);

                sqlCommand.ExecuteNonQuery();

                DataTable SQLdatatable = new DataTable();

                SqlDataAdapter datadapter = new SqlDataAdapter(sqlCommand);

                datadapter.Fill(SQLdatatable);

                if (SQLdatatable.Rows.Count > 0)
                {
                    Descripcion = SQLdatatable.Rows[0][1].ToString();
                    Comentario = SQLdatatable.Rows[0][2].ToString();
                    Status = SQLdatatable.Rows[0][3].ToString();
                    NoEliminable = Convert.ToInt32(SQLdatatable.Rows[0][4].ToString());
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }


        }
        //CODIGO PARA LA CONSULTA DELETE DEL GRUPO ENTIDAD
        public static void EliminarGrupoEntidad(int IdGrupoEntidad, string Nombre)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpGrupoEntidadesEliminar";

                sqlCommand.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
                sqlCommand.Parameters.AddWithValue("@Descripcion", Nombre);

                sqlCommand.ExecuteNonQuery();

                DataTable SQLdatatable = new DataTable();

                SqlDataAdapter datadapter = new SqlDataAdapter(sqlCommand);

                datadapter.Fill(SQLdatatable);

            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

        }

        //CODIGO PARA LA CONSULTA INSERT DEl TIPO ENTIDAD

        public static void RegistroTipoEntidad(string Descripcion, string IdGrupoEntidad, 
            string Comentario, string Status, int NoEliminable)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpTipoEntidadesInsertar";

                DataTable SQLdatatable = new DataTable();

                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select IdGrupoEntidad from GrupoEntidades Where Descripcion ='"
                    + IdGrupoEntidad + "'",
                    CommandType.Text)).Fill(SQLdatatable);

                sqlCommand.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
                sqlCommand.Parameters.AddWithValue("@IDGRUPOENTIDAD", Convert.ToInt32(SQLdatatable.Rows[0][0]));
                sqlCommand.Parameters.AddWithValue("@COMENTARIO", Comentario);
                sqlCommand.Parameters.AddWithValue("@STATUS", Status);
                sqlCommand.Parameters.AddWithValue("@NOELIMINABLE", NoEliminable);

                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

        }

        //CODIGO PARA LA CONSULTA UPDATE DEl Tipo ENTIDAD

        public static void EditarTipoEntidad(int IdTipoEntidad, string Descripcion, string IdGrupoEntidad, 
           string Comentario, string Status,
           int NoEliminable)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpTipoEntidadesActualizar";

                DataTable SQLdatatable = new DataTable();

                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select IdGrupoEntidad from GrupoEntidades Where Descripcion ='"
                    + IdGrupoEntidad + "'",
                    CommandType.Text)).Fill(SQLdatatable);

                sqlCommand.Parameters.AddWithValue("@IDTIPOENTIDAD", IdTipoEntidad);
                sqlCommand.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
                sqlCommand.Parameters.AddWithValue("@IDGRUPOENTIDAD", Convert.ToInt32(SQLdatatable.Rows[0][0]));
                sqlCommand.Parameters.AddWithValue("@COMENTARIO", Comentario);
                sqlCommand.Parameters.AddWithValue("@STATUS", Status);
                sqlCommand.Parameters.AddWithValue("@NOELIMINABLE", NoEliminable);

                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

        }

        //CODIGO PARA LA CONSULTA SELECT QUE SE REQUIERE PARA EL UPDATE DEl TIPO ENTIDAD

        public static void LlenarTipoEntidad(int IdTipoEntidad)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpTipoEntidadesObtener";

                sqlCommand.Parameters.AddWithValue("@IdTipoEntidad", IdTipoEntidad);

                sqlCommand.ExecuteNonQuery();

                DataTable SQLdatatable = new DataTable();

                SqlDataAdapter datadapter = new SqlDataAdapter(sqlCommand);

                datadapter.Fill(SQLdatatable);

                
                if (SQLdatatable.Rows.Count > 0)
                {
                    DataTable SQLdatatable2 = new DataTable();

                    ClassData.SQLDataAdapter(
                        ClassData.sqlCommand("Select Descripcion from GrupoEntidades Where IdGrupoEntidad ='"
                        + Convert.ToInt32(SQLdatatable.Rows[0][2]) + "'",
                        CommandType.Text)).Fill(SQLdatatable2);

                    Descripcion = SQLdatatable.Rows[0][1].ToString();
                    GrupoEntidad = SQLdatatable2.Rows[0][0].ToString();
                    Comentario = SQLdatatable.Rows[0][3].ToString();
                    Status = SQLdatatable.Rows[0][4].ToString();
                    NoEliminable = Convert.ToInt32(SQLdatatable.Rows[0][5].ToString());
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }


        }
        //CODIGO PARA LA CONSULTA DELETE DEL TIPO ENTIDAD
        public static void EliminarTipoEntidad(int IdTipoEntidad, string Nombre)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = ClassData.OpenDBSQLServer();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SpTipoEntidadesEliminar";

                sqlCommand.Parameters.AddWithValue("@IdTipoEntidad", IdTipoEntidad);
                sqlCommand.Parameters.AddWithValue("@Descripcion", Nombre);

                sqlCommand.ExecuteNonQuery();

                DataTable SQLdatatable = new DataTable();

                SqlDataAdapter datadapter = new SqlDataAdapter(sqlCommand);

                datadapter.Fill(SQLdatatable);

            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

        }
    }
}
