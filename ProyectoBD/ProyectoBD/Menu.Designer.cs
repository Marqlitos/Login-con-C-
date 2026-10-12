/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 06/10/2026
 * Time: 12:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoBD
{
	partial class Menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnVer;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnCerrarS;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnCerrarS = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu Administrador";
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(56, 58);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(108, 24);
			this.btnEditar.TabIndex = 1;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnVer
			// 
			this.btnVer.Location = new System.Drawing.Point(56, 88);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(108, 23);
			this.btnVer.TabIndex = 2;
			this.btnVer.Text = "Ver";
			this.btnVer.UseVisualStyleBackColor = true;
			this.btnVer.Click += new System.EventHandler(this.BtnVerClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(12, 188);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(56, 118);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(108, 23);
			this.btnBorrar.TabIndex = 4;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// btnCerrarS
			// 
			this.btnCerrarS.Location = new System.Drawing.Point(98, 188);
			this.btnCerrarS.Name = "btnCerrarS";
			this.btnCerrarS.Size = new System.Drawing.Size(108, 23);
			this.btnCerrarS.TabIndex = 10;
			this.btnCerrarS.Text = "Cerrar Sesion";
			this.btnCerrarS.UseVisualStyleBackColor = true;
			this.btnCerrarS.Click += new System.EventHandler(this.BtnCerrarSClick);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(218, 223);
			this.Controls.Add(this.btnCerrarS);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.label1);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);

		}
	}
}
