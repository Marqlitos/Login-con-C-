/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 05/10/2026
 * Time: 09:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoBD
{
	/// <summary>
	/// Description of Registro.
	/// </summary>
	public partial class Registro : Form
	{
		public Registro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnAtrasClick(object sender, EventArgs e)
		{
			Form Registro = new Registro();
			DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas cancelar el registro?, ¡No se guardarán los cambios!", 
			                                         "Confirmación", MessageBoxButtons.YesNo, 
			                                         MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
    			MessageBox.Show("¡Registro cancelado!.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
    			this.Close();
			}
				else
				{
    				// Código que se ejecuta si el usuario hace clic en "No" o cierra la ventana
    				MessageBox.Show("¡Operación cancelada!.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			//Validar todas las cajas de texto de un solo golpe
			if(string.IsNullOrWhiteSpace(txtbNombre.Text) ||
			   string.IsNullOrWhiteSpace(txtbApellidoP.Text) ||
			   string.IsNullOrWhiteSpace(txtbApellidoM.Text) ||
			   string.IsNullOrWhiteSpace(txtbUsuario.Text) ||
			   string.IsNullOrWhiteSpace(txtbContraseña.Text) ||
			   string.IsNullOrWhiteSpace(txtbEMail.Text) ||
			   string.IsNullOrWhiteSpace(txtbRFC.Text) ||
			   string.IsNullOrWhiteSpace(txtbCurp.Text) ||
			   string.IsNullOrWhiteSpace(txtbNControl.Text) ||
			   string.IsNullOrWhiteSpace(txtTelefono.Text))
			{
				MessageBox.Show("Faltan datos de texto por llenar. Por favor, completa todas las casillas.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Detiene la ejecución
			}

			//Validar la Edad
			if(nudEdad.Value <= 0)
			{
				MessageBox.Show("Por favor, ingresa una edad válida (mayor a 0).", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				nudEdad.Focus(); // Pone el cursor ahí
				return;
			}

			// Validar Listas Desplegables / ComboBox
			if(cmbArea.SelectedIndex == -1 || cmbRol.SelectedIndex == -1)
			{
				MessageBox.Show("Por favor, selecciona un Área y un Rol de las listas desplegables.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Validar Fecha
			if(dtpFecha.Value.Date == DateTime.Now.Date)
			{
				MessageBox.Show("Por favor, selecciona una Fecha de Nacimiento válida.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dtpFecha.Focus();
				return;
			}

			// Validar CheckBoxes
			if(!cbActivo.Checked && !cbInactivo.Checked)
			{
				MessageBox.Show("Por favor, selecciona el estado del usuario (Activo o Inactivo).", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			MessageBox.Show("Todos los datos están completos. Conexión y validación de credenciales en construcción...", "Verificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			//this.Close();
			
			//Verificamos el estado del checkbox
			bool esActivo = cbActivo.Checked;
			
			//Llamamos al backend
			ConexionBD backend = new ConexionBD();
			
			bool exito = backend.RegistrarUsuario(
				txtbNombre.Text,
				txtbApellidoP.Text,
				txtbApellidoM.Text,
				txtbUsuario.Text, 
				txtbContraseña.Text,
				txtbRFC.Text,
				txtbEMail.Text,
				txtbCurp.Text,
				(int)nudEdad.Value, //Convertimos la edad a entero
				txtbNControl.Text,
				cmbArea.Text,
				txtTelefono.Text,
				cmbRol.Text,
				dtpFecha.Value, //Aqui se extrae la fecha
				esActivo
			);
			
			if(exito){
				MessageBox.Show("Usuario registrado y encriptado con exito en Azuer.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close(); //Cerramos la ventana y regresa al login
			}
		}
	}
}
