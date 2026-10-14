/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 05/10/2026
 * Time: 05:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoBD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Boton Salir
		void BtnSalirClick(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas Salir?",
			                                         "Confirmación", MessageBoxButtons.YesNo,
			                                         MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				MessageBox.Show("Sesion Cerrada, ¡Hasta luego!.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Application.Exit();
			}
			else
			{
				// Código que se ejecuta si el usuario hace clic en "No" o cierra la ventana
				MessageBox.Show("¡Operación cancelada!.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		
		//Boton Registrarse
		void BtnRegistrarseClick(object sender, EventArgs e)
		{
			//Funciones para registrarse
			Registro ventanaRegistro = new Registro();
			ventanaRegistro.ShowDialog();
		}
		
		//Boton Verificar
		void BtnVerificarClick(object sender, EventArgs e)
		{
			//Codigo de prueba de Login
//			if(txtBUsuario.Text=="admin" && txtContraseña.Text=="123")
//			{
//
//				//MessageBox.Show("entra el formulario");
//				//llamar al formulario
//				Form MainForm = new Menu();
//				MainForm.Show();
//				//Oculta el formulario login
//				this.Hide();
//
//			}
//			else if(txtBUsuario.Text=="user" && txtContraseña.Text =="123")
//			{
//				//MessageBox.Show("entra el formulario");
//				//llamar al formulario
//				Form MainForm = new MenuE();
//				MainForm.Show();
//				//Oculta el formulario login
//				this.Hide();
//			}
//			 else
//			 {
//
//				if(MessageBox.Show("Usuario o contraseña incorrectos, ¿Desea volver a intentar?","Datos Incorrectos",
//				                   MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
//			 	{
//					//Liapiar las cajas
//					txtBUsuario.Clear();
//					txtContraseña.Clear();
//
//				}
//
//				 else
//				 {
//					 //Cerrar el formulario
//					 this.Close();
//				 }
//		      }
			
			// Codigo de prueba a la bd
//			ConexionBD backendBD = new ConexionBD();
//
//			// Intentamos obtener la conexión
//			MySqlConnection conexionPrueba = backendBD.ObtenerConexion();
//
//			if (conexionPrueba != null)
//			{
//				MessageBox.Show("¡Conexión a Azure exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
//				conexionPrueba.Close(); // Siempre cierra la conexión cuando termines de usarla
//			}
//		}
			//Valida que las cajas no esten vacias
			if (string.IsNullOrWhiteSpace(txtBUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
			{
				MessageBox.Show("Por favor, ingresa tu Usuario y Contraseña.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			//Llama al BACKEND para validar credenciales
			ConexionBD backend = new ConexionBD();
			string rolUsuario = backend.ValidarLogin(txtBUsuario.Text, txtContraseña.Text);

			//Evaluar la respuesta de Azure
			if (rolUsuario != null)
    {
        MessageBox.Show("¡Bienvenido al sistema! Ingresaste como: " + rolUsuario, "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        // Evalua si el rol nos devolvió la base de datos
        if (rolUsuario == "Administrador")
        {
            // Instancia y abre la ventana del Administrador
            Form menuAdministrador = new Menu();
            menuAdministrador.Show();
        }
        else if (rolUsuario == "Empleado" || rolUsuario == "Trabajador") 
        {
            // Instancia y abre la ventana del Empleado
            Form menuEmpleado = new MenuE();
            menuEmpleado.Show();
        }
        else
        {
             MessageBox.Show("Rol no reconocido en el sistema.", "Error de Rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        // Ocultam la ventana de Login actual
        this.Hide(); 
    }
    else
    {
        MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtContraseña.Clear();
        txtContraseña.Focus();
    }
			
		}
			void TxtBUsuarioTextChanged(object sender, EventArgs e)
			{
				if (txtBUsuario.Text == "Ingresa tu usuario aqui")
				{
					txtBUsuario.Text = "";
					txtBUsuario.ForeColor = Color.Black;
				}
			}
		}
	}