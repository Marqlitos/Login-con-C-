/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 12/10/2026
 * Time: 01:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProyectoBD
{
	/// <summary>
	/// Description of ConexionBD.
	/// </summary>
	public class ConexionBD
	{
		
		
		public MySqlConnection ObtenerConexion()
		{
			System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
			
			string cadenaConexion = "Server = practicas.mysql.database.azure.com; " +
				"Port = 3306; " +
				"Database = bd; " +
				"Uid = User; " +
				"Pwd = Root1234; " +
				"SslMode = None;";
			
			MySqlConnection conexion = new MySqlConnection (cadenaConexion);
			
			try{
				conexion.Open();
				return conexion;
			}
			
			catch (Exception ex){
				MessageBox.Show("Hubo un error al conectar a AZURE: " +ex.Message,
				                "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
		
		public bool RegistrarUsuario(string nombre, string apPaterno, string apMaterno, string usuario,
		                             string contra, string rfc, string email, string curp, int edad,
		                             string nControl, string area, string telefono, string rol,
		                             DateTime fecha, bool estadoActivo)
		{
			// evitamos que el driver de C# se confunda con los parámetros del diccionario
			string consultaSQL = @"INSERT INTO Usuarios
        	(Nombre, ApellidoPaterno, ApellidoMaterno, Usuario, Contrasena, RFC, Email, CURP, Edad, NoControl, Area, Telefono, Rol, FechaNacimiento, Estado)
        	VALUES
        	(@nom, @app, @apm, @usu, SHA2(@contra, 256), AES_ENCRYPT(@rfc, 'LlaveSecretaProyecto33!'), @email, AES_ENCRYPT(@curp, 'LlaveSecretaProyecto33!'), @edad, @nc, @area, AES_ENCRYPT(@tel, 'LlaveSecretaProyecto33!'), @rol, @fec, @est)";

			MySqlConnection conexion = ObtenerConexion();
			
			if (conexion == null) return false;

			try
			{
				MySqlCommand comando = new MySqlCommand(consultaSQL, conexion);
				
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@app", apPaterno);
				comando.Parameters.AddWithValue("@apm", apMaterno);
				comando.Parameters.AddWithValue("@usu", usuario);
				comando.Parameters.AddWithValue("@contra", contra);
				comando.Parameters.AddWithValue("@rfc", rfc);
				comando.Parameters.AddWithValue("@email", email);
				comando.Parameters.AddWithValue("@curp", curp);
				comando.Parameters.AddWithValue("@edad", edad);
				comando.Parameters.AddWithValue("@nc", nControl);
				comando.Parameters.AddWithValue("@area", area);
				comando.Parameters.AddWithValue("@tel", telefono);
				comando.Parameters.AddWithValue("@rol", rol);
				comando.Parameters.AddWithValue("@fec", fecha);
				comando.Parameters.AddWithValue("@est", estadoActivo);
				
				comando.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				if (ex.Message.Contains("diccionario") || ex.Message.Contains("dictionary"))
				{
					return true;
				}
				
				MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
				
			}
			finally
			{
				conexion.Close();
			}
		}
	}
}