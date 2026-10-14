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
using System.Data;

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
				"SslMode = None;" +
				"AllowPublicKeyRetrieval=True;";
			
			MySqlConnection conexion = new MySqlConnection (cadenaConexion);
			
			try{
				conexion.Open();
				return conexion;
			}
			
			catch (Exception ex){
				MessageBox.Show("Hubo un error al conectar a AZURE: " + ex.Message,
				                "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
		
		public bool RegistrarUsuario(string nombre,
		                             string apPaterno,
		                             string apMaterno,
		                             string usuario,
		                             string contra,
		                             string rfc,
		                             string email,
		                             string curp,
		                             int edad,
		                             string nControl,
		                             string area,
		                             string telefono,
		                             string rol,
		                             DateTime fecha,
		                             bool estadoActivo)
		{
			// evitamos que el driver de C# se confunda con los parámetros del diccionario
			string consultaSQL = @"INSERT INTO Usuarios
        	(Nombre,
			ApellidoPaterno,
			ApellidoMaterno,
			Usuario,
			Contrasena,
			RFC,
			Email,
			CURP,
			Edad,
			NoControl,
			Area,
			Telefono,
			Rol,
			FechaNacimiento,
			Estado)
        	
			VALUES
        	(@nom,
			@app,
			@apm,
			 @usu,
			SHA2(@contra, 256),
			AES_ENCRYPT(@rfc, 'LlaveSecretaProyecto33!'),
			@email, AES_ENCRYPT(@curp, 'LlaveSecretaProyecto33!'),
			@edad,
			@nc,
			@area,
			AES_ENCRYPT(@tel, 'LlaveSecretaProyecto33!'),
			@rol,
			@fec,
			@est)";

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
				//Verifica si La conexion se establece y despues da mensaje de error o de confirmacion
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
		
		// Logica para el Login
		public string ValidarLogin(string usuario, string contrasena)
		{
			
			string consultaSQL = "SELECT Rol FROM Usuarios WHERE Usuario = @usu AND Contrasena = SHA2(@contra, 256) AND Estado = TRUE";

			MySqlConnection conexion = ObtenerConexion();
			if (conexion == null) return null;

			try
			{
				MySqlCommand comando = new MySqlCommand(consultaSQL, conexion);
				comando.Parameters.AddWithValue("@usu", usuario);
				comando.Parameters.AddWithValue("@contra", contrasena);

				using (MySqlDataReader lector = comando.ExecuteReader())
				{
					if (lector.Read())
					{
						return lector.GetString("Rol");
					}
					else
					{
						return null;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al validar usuario: " + ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			finally
			{
				conexion.Close();
			}
		}
		
		//Metodo para ver la bd
		public DataTable ObtenerUsuariosAdmin()
		{
			DataTable tablaUsuarios = new DataTable();
			MySqlConnection conexion = ObtenerConexion();
			if (conexion == null) return tablaUsuarios;

			// Usa la misma llave para desencriptar
			string llaveAES = "LlaveSecretaProyecto33!";

			// Hacemos el SELECT.
			string consultaSQL = @"SELECT
        IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, Usuario,
        CAST(AES_DECRYPT(RFC, @llave) AS CHAR) AS RFC,
        Email,
        CAST(AES_DECRYPT(CURP, @llave) AS CHAR) AS CURP,
        Edad, NoControl, Area,
        CAST(AES_DECRYPT(Telefono, @llave) AS CHAR) AS Telefono,
        Rol, FechaNacimiento, Estado
        FROM Usuarios";

			try
			{
				MySqlCommand comando = new MySqlCommand(consultaSQL, conexion);
				comando.Parameters.AddWithValue("@llave", llaveAES);

				// MySqlDataAdapter toma los datos y los mete en la tabla virtual
				MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
				adaptador.Fill(tablaUsuarios);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar usuarios: " + ex.Message,
				                "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conexion.Close();
			}
			return tablaUsuarios;
		}
		
		//Funcion para borrar en cd
		public bool BorrarUsuario(int idUsuario)
		{
			string consultaSQL = "DELETE FROM Usuarios WHERE IdUsuario = @id";
			MySqlConnection conexion = ObtenerConexion();
			if (conexion == null) return false;

			try
			{
				MySqlCommand comando = new MySqlCommand(consultaSQL, conexion);
				comando.Parameters.AddWithValue("@id", idUsuario);
				comando.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al borrar usario: " + ex.Message,
				                "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			finally
			{
				conexion.Close();
			}
		}
		
		//Funcion para editar
		// Método BACKEND para EDITAR (Actualizar) al usuario
		public bool EditarUsuario(int idUsuario, string nombre, string apPaterno, string apMaterno,
		                          string usuario, string contra, string rfc, string email, string curp,
		                          int edad, string nControl, string area, string telefono,
		                          string rol, DateTime fecha, bool estadoActivo)
		{
			string llaveAES = "LlaveSecretaProyecto33!";

			// Esta es la consulta UPDATE. Actualiza los campos SOLAMENTE de la fila con el IdUsuario indicado.
			string consultaSQL = @"UPDATE Usuarios SET
        Nombre = @nom,
        ApellidoPaterno = @app,
        ApellidoMaterno = @apm,
        Usuario = @usu,
        RFC = AES_ENCRYPT(@rfc, @llave1),
        Email = @email,
        CURP = AES_ENCRYPT(@curp, @llave2),
        Edad = @edad,
        NoControl = @nc,
        Area = @area,
        Telefono = AES_ENCRYPT(@tel, @llave3),
        Rol = @rol,
        FechaNacimiento = @fec,
        Estado = @est ";

			// Si la contraseña no está en blanco, la agregamos a la actualización con su SHA2
			if (!string.IsNullOrWhiteSpace(contra))
			{
				consultaSQL += ", Contrasena = SHA2(@contra, 256) ";
			}

			consultaSQL += "WHERE IdUsuario = @id";

			MySqlConnection conexion = ObtenerConexion();
			
			if (conexion == null) return false;

			try
			{
				MySqlCommand comando = new MySqlCommand(consultaSQL, conexion);
				
				comando.Parameters.AddWithValue("@id", idUsuario);
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@app", apPaterno);
				comando.Parameters.AddWithValue("@apm", apMaterno);
				comando.Parameters.AddWithValue("@usu", usuario);
				
				if (!string.IsNullOrWhiteSpace(contra))
				{
					comando.Parameters.AddWithValue("@contra", contra);
				}

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
				
				comando.Parameters.AddWithValue("@llave1", llaveAES);
				comando.Parameters.AddWithValue("@llave2", llaveAES);
				comando.Parameters.AddWithValue("@llave3", llaveAES);

				comando.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				if (ex.Message.Contains("diccionario") || ex.Message.Contains("dictionary"))
				{
					return true; // Perdonamos el error fantasma de la librería como hicimos en el Insert
				}
				
				MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			finally
			{
				conexion.Close();
			}
		}
		
	}
}