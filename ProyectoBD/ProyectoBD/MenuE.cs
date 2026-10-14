/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 08/10/2026
 * Time: 04:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoBD
{
	/// <summary>
	/// Description of MenuE.
	/// </summary>
	public partial class MenuE : Form
	{
		public MenuE()
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
			// Llamamos al Backend y le asignamos el resultado al DataSource del Grid
			dgvUsuarios.DataSource = backend.ObtenerUsuariosAdmin();
		}
		
		void MenuELoad(object sender, EventArgs e)
		{
			
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
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
		}
	}
	}