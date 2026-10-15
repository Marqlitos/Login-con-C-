/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 06/10/2026
 * Time: 12:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoBD
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void CargarDatosEnGrid()
		{
			ConexionBD backend = new ConexionBD();
			dgvUsuarios.DataSource = backend.ObtenerUsuariosAdmin();
			dgvUsuarios.Columns["Contrasena"].ReadOnly = true;
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			//Boton Salir
			DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas Salir?",
			                                         "Confirmación", MessageBoxButtons.YesNo,
			                                         MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				MessageBox.Show("Programa cerrado, ¡Hasta luego!.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Application.Exit();
			}
			else
			{
				// Código que se ejecuta si el usuario hace clic en "No" o cierra la ventana
				MessageBox.Show("¡Operación cancelada!.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		void BtnCerrarSClick(object sender, EventArgs e)
		{
			//Boton cerrar
			Form MainForm = new MainForm();
			
			DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?",
			                                         "Confirmación", MessageBoxButtons.YesNo,
			                                         MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				MessageBox.Show("Sesion Cerrada, ¡Hasta luego!.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
				MainForm.Show();
			}
			else
			{
				// Código que se ejecuta si el usuario hace clic en "No" o cierra la ventana
				MessageBox.Show("¡Operación cancelada!.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			//Logica de boton de editar
			if (dgvUsuarios.SelectedRows.Count > 0)
			{
				// Extrae los datos de la fila seleccionada
				int idSeleccionado = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);
				string usuarioSeleccionado = dgvUsuarios.SelectedRows[0].Cells["Usuario"].Value.ToString();

				//Se vuelve a abrir el formulario de registro
				MessageBox.Show("Para editar al usuario " + usuarioSeleccionado +
				                " (ID: " + idSeleccionado + "), Escibe los datos en las celdas, depues guardalos con el botonb de 'Guardar'.", "Editar");
			}
			else
			{
				MessageBox.Show("Selecciona toda la fila del usuario que deseas editar dando clic en el margen izquierdo de la tabla.",
				                "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
		}
		void BtnVerClick(object sender, EventArgs e)
		{
			//Logica de boton Ver
			CargarDatosEnGrid();
			
		}
		void BtnBorrarClick(object sender, EventArgs e)
		{
			//Logica de boton Borrar
			if (dgvUsuarios.SelectedRows.Count > 0)
			{
				// Extrae el IdUsuario de la primera celda de la fila seleccionada
				int idSeleccionado = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);

				// Confirma si se quiere borrar
				DialogResult respuesta = MessageBox.Show("¿Estas seguro de que deseas eliminar este usuario de Azuer?",
				                                         "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (respuesta == DialogResult.Yes)
				{
					ConexionBD backend = new ConexionBD();
					if (backend.BorrarUsuario(idSeleccionado))
					{
						MessageBox.Show("Usuario eliminado exitosamente.",
						                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						// Recarga la tabla para que desaparezca el borrado
						
						CargarDatosEnGrid();
					}
				}
			}
			else
			{
				MessageBox.Show("Por favor, selecciona toda la fila del usuario que deseas borrar dando clic en el margen izquierdo de la tabla.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
		}
		void DgvUsuariosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			//Logica botn guardar
			if (dgvUsuarios.SelectedRows.Count > 0)
			{
				try
				{
					// Extraemos el ID del usuario (escondido en la columna IdUsuario)
					int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);

					// Leemos todo el texto nuevo directamente de las celdas
					string nom = dgvUsuarios.SelectedRows[0].Cells["Nombre"].Value.ToString();
					string app = dgvUsuarios.SelectedRows[0].Cells["ApellidoPaterno"].Value.ToString();
					string apm = dgvUsuarios.SelectedRows[0].Cells["ApellidoMaterno"].Value.ToString();
					string usu = dgvUsuarios.SelectedRows[0].Cells["Usuario"].Value.ToString();
					string rfc = dgvUsuarios.SelectedRows[0].Cells["RFC"].Value.ToString();
					string email = dgvUsuarios.SelectedRows[0].Cells["Email"].Value.ToString();
					string curp = dgvUsuarios.SelectedRows[0].Cells["CURP"].Value.ToString();
					int edad = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Edad"].Value);
					string nc = dgvUsuarios.SelectedRows[0].Cells["NoControl"].Value.ToString();
					string area = dgvUsuarios.SelectedRows[0].Cells["Area"].Value.ToString();
					string tel = dgvUsuarios.SelectedRows[0].Cells["Telefono"].Value.ToString();
					string rol = dgvUsuarios.SelectedRows[0].Cells["Rol"].Value.ToString();
					
					// Convertimos la fecha y el estado booleano
					DateTime fec = Convert.ToDateTime(dgvUsuarios.SelectedRows[0].Cells["FechaNacimiento"].Value);
					bool est = Convert.ToBoolean(dgvUsuarios.SelectedRows[0].Cells["Estado"].Value);

					// Como estamos editando desde la tabla, mandamos la contraseña en blanco
					// para que el Backend ignore este campo y no la borre
					string contra = "";

					// Llamamos a la base de datos
					ConexionBD backend = new ConexionBD();
					bool exito = backend.EditarUsuario(id, nom, app, apm, usu, contra, rfc, email, curp, edad, nc, area, tel, rol, fec, est);

					if (exito)
					{
						MessageBox.Show("Los cambios se han guardado exitosamente en Azure.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
						// Si tienes tu método para recargar el Grid, llámalo aquí para refrescar la vista
						// CargarDatosEnGrid();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Asegúrate de no dejar celdas numéricas o de fecha vacías. Error: " 
					                + ex.Message, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Primero edita los datos en la tabla y luego selecciona TODA la fila dando clic en la flechita del lado izquierdo antes de presionar Guardar.", 
				                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
	}
}
