namespace Disponibilidad
{
	partial class Configurar_componentes
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
			this.button3 = new System.Windows.Forms.Button();
			this.gbHorarioP = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gbHorarioP.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(97, 23);
			this.button3.TabIndex = 31;
			this.button3.Text = "Prueba botón";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// gbHorarioP
			// 
			this.gbHorarioP.Controls.Add(this.pictureBox1);
			this.gbHorarioP.Controls.Add(this.label4);
			this.gbHorarioP.Controls.Add(this.dateTimePickerHasta);
			this.gbHorarioP.Controls.Add(this.label5);
			this.gbHorarioP.Controls.Add(this.dateTimePickerDesde);
			this.gbHorarioP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.gbHorarioP.ForeColor = System.Drawing.Color.Black;
			this.gbHorarioP.Location = new System.Drawing.Point(12, 118);
			this.gbHorarioP.Name = "gbHorarioP";
			this.gbHorarioP.Size = new System.Drawing.Size(221, 150);
			this.gbHorarioP.TabIndex = 32;
			this.gbHorarioP.TabStop = false;
			this.gbHorarioP.Text = "Horario de producción";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(10, 91);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 21);
			this.label4.TabIndex = 18;
			this.label4.Text = "Hasta:";
			// 
			// dateTimePickerHasta
			// 
			this.dateTimePickerHasta.CustomFormat = "HH:mm:ss";
			this.dateTimePickerHasta.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerHasta.Location = new System.Drawing.Point(81, 91);
			this.dateTimePickerHasta.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePickerHasta.Name = "dateTimePickerHasta";
			this.dateTimePickerHasta.ShowUpDown = true;
			this.dateTimePickerHasta.Size = new System.Drawing.Size(111, 29);
			this.dateTimePickerHasta.TabIndex = 21;
			this.dateTimePickerHasta.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(7, 47);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 21);
			this.label5.TabIndex = 16;
			this.label5.Text = "Desde:";
			// 
			// dateTimePickerDesde
			// 
			this.dateTimePickerDesde.CustomFormat = "HH:mm:ss";
			this.dateTimePickerDesde.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDesde.Location = new System.Drawing.Point(81, 47);
			this.dateTimePickerDesde.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePickerDesde.Name = "dateTimePickerDesde";
			this.dateTimePickerDesde.ShowUpDown = true;
			this.dateTimePickerDesde.Size = new System.Drawing.Size(112, 29);
			this.dateTimePickerDesde.TabIndex = 20;
			this.dateTimePickerDesde.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(213, 100);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Disponibilidad.Properties.Resources.Timer;
			this.pictureBox1.Location = new System.Drawing.Point(171, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(42, 39);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			// 
			// Configurar_componentes
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(242, 274);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbHorarioP);
			this.Name = "Configurar_componentes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configurar_componentes";
			this.gbHorarioP.ResumeLayout(false);
			this.gbHorarioP.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox gbHorarioP;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}