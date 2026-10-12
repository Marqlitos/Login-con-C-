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
			
		}
		void BtnVerClick(object sender, EventArgs e)
		{
			//Logica de boton Ver
			
		}
		void BtnBorrarClick(object sender, EventArgs e)
		{
			//Logica de boton Borrar
			
		}
	}
}
