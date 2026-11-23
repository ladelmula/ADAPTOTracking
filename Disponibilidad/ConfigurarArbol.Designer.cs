namespace Disponibilidad
{
	partial class ConfigurarArbol
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarArbol));
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmdCancel = new VisualStyles.VIButton();
			this.cmdOK = new VisualStyles.VIButton();
			this.viTreeView1 = new Disponibilidad.VITreeView();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmdCancel);
			this.panel1.Controls.Add(this.cmdOK);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 670);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1015, 75);
			this.panel1.TabIndex = 19;
			// 
			// cmdCancel
			// 
			this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cmdCancel.Image = global::Disponibilidad.Properties.Resources.Cancel2;
			this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCancel.Location = new System.Drawing.Point(796, 12);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(146, 53);
			this.cmdCancel.TabIndex = 26;
			this.cmdCancel.Text = "Cancelar";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			// 
			// cmdOK
			// 
			this.cmdOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdOK.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cmdOK.Image = global::Disponibilidad.Properties.Resources.Aceptar2;
			this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdOK.Location = new System.Drawing.Point(87, 12);
			this.cmdOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(146, 53);
			this.cmdOK.TabIndex = 25;
			this.cmdOK.Text = "Aceptar";
			this.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdOK.UseVisualStyleBackColor = false;
			// 
			// viTreeView1
			// 
			this.viTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
			this.viTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viTreeView1.ForeColor = System.Drawing.Color.White;
			this.viTreeView1.Location = new System.Drawing.Point(0, 0);
			this.viTreeView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.viTreeView1.Name = "viTreeView1";
			this.viTreeView1.Size = new System.Drawing.Size(1015, 670);
			this.viTreeView1.TabIndex = 18;
			// 
			// ConfigurarArbol
			// 
			this.AcceptButton = this.cmdOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size(1015, 745);
			this.Controls.Add(this.viTreeView1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConfigurarArbol";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configurar Árbol";
			this.Load += new System.EventHandler(this.ConfigurarArbol_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private VITreeView viTreeView1;
		private System.Windows.Forms.Panel panel1;
		private VisualStyles.VIButton cmdCancel;
		private VisualStyles.VIButton cmdOK;
	}
}