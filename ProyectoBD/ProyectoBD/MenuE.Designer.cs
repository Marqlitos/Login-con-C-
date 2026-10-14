/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 08/10/2026
 * Time: 04:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoBD
{
	partial class MenuE
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnVer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCerrarS;
		private System.Windows.Forms.DataGridView dgvUsuarios;
		
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
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCerrarS = new System.Windows.Forms.Button();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(12, 442);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 8;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnVer
			// 
			this.btnVer.Location = new System.Drawing.Point(12, 65);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(108, 23);
			this.btnVer.TabIndex = 7;
			this.btnVer.Text = "Ver";
			this.btnVer.UseVisualStyleBackColor = true;
			this.btnVer.Click += new System.EventHandler(this.BtnVerClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Menu Empleado";
			// 
			// btnCerrarS
			// 
			this.btnCerrarS.Location = new System.Drawing.Point(820, 442);
			this.btnCerrarS.Name = "btnCerrarS";
			this.btnCerrarS.Size = new System.Drawing.Size(108, 23);
			this.btnCerrarS.TabIndex = 9;
			this.btnCerrarS.Text = "Cerrar Sesion";
			this.btnCerrarS.UseVisualStyleBackColor = true;
			this.btnCerrarS.Click += new System.EventHandler(this.BtnCerrarSClick);
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(166, 12);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.RowTemplate.Height = 24;
			this.dgvUsuarios.Size = new System.Drawing.Size(762, 419);
			this.dgvUsuarios.TabIndex = 12;
			// 
			// MenuE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 477);
			this.Controls.Add(this.dgvUsuarios);
			this.Controls.Add(this.btnCerrarS);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.label1);
			this.Name = "MenuE";
			this.Text = "MenuE";
			this.Load += new System.EventHandler(this.MenuELoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
