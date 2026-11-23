namespace Disponibilidad
{
	partial class ConfigurarAlarmas
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarAlarmas));
			this.configAlarmas1 = new Disponibilidad.DataBase.ConfigAlarmas();
			this.BSConfigAlarmas = new System.Windows.Forms.BindingSource(this.components);
			this.dgvDatos = new Zuby.ADGV.AdvancedDataGridView();
			this.textoAlarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tecnicaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.operativaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.viPanel1 = new VisualStyles.VIPanel();
			this.cmdCancel = new VisualStyles.VIButton();
			this.cmdOK = new VisualStyles.VIButton();
			((System.ComponentModel.ISupportInitialize)(this.configAlarmas1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BSConfigAlarmas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.viPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// configAlarmas1
			// 
			this.configAlarmas1.DataSetName = "ConfigAlarmas";
			this.configAlarmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// BSConfigAlarmas
			// 
			this.BSConfigAlarmas.DataMember = "ConfigAlarmas";
			this.BSConfigAlarmas.DataSource = this.configAlarmas1;
			this.BSConfigAlarmas.Sort = "";
			// 
			// dgvDatos
			// 
			this.dgvDatos.AllowUserToAddRows = false;
			this.dgvDatos.AllowUserToDeleteRows = false;
			this.dgvDatos.AutoGenerateColumns = false;
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textoAlarmaDataGridViewTextBoxColumn,
            this.tecnicaDataGridViewCheckBoxColumn,
            this.operativaDataGridViewCheckBoxColumn});
			this.dgvDatos.DataBindingSource = this.BSConfigAlarmas;
			this.dgvDatos.DataSource = this.BSConfigAlarmas;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDatos.FilterAndSortEnabled = true;
			this.dgvDatos.Location = new System.Drawing.Point(0, 0);
			this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.RowHeadersWidth = 25;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDatos.Size = new System.Drawing.Size(800, 350);
			this.dgvDatos.SortString = "";
			this.dgvDatos.TabIndex = 24;
			this.dgvDatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatos_CellMouseClick);
			// 
			// textoAlarmaDataGridViewTextBoxColumn
			// 
			this.textoAlarmaDataGridViewTextBoxColumn.DataPropertyName = "TextoAlarma";
			this.textoAlarmaDataGridViewTextBoxColumn.HeaderText = "Texto de la alarma";
			this.textoAlarmaDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.textoAlarmaDataGridViewTextBoxColumn.Name = "textoAlarmaDataGridViewTextBoxColumn";
			this.textoAlarmaDataGridViewTextBoxColumn.ReadOnly = true;
			this.textoAlarmaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.textoAlarmaDataGridViewTextBoxColumn.Width = 400;
			// 
			// tecnicaDataGridViewCheckBoxColumn
			// 
			this.tecnicaDataGridViewCheckBoxColumn.DataPropertyName = "Tecnica";
			this.tecnicaDataGridViewCheckBoxColumn.HeaderText = "Técnica";
			this.tecnicaDataGridViewCheckBoxColumn.MinimumWidth = 22;
			this.tecnicaDataGridViewCheckBoxColumn.Name = "tecnicaDataGridViewCheckBoxColumn";
			this.tecnicaDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.tecnicaDataGridViewCheckBoxColumn.Width = 125;
			// 
			// operativaDataGridViewCheckBoxColumn
			// 
			this.operativaDataGridViewCheckBoxColumn.DataPropertyName = "Operativa";
			this.operativaDataGridViewCheckBoxColumn.HeaderText = "Operativa";
			this.operativaDataGridViewCheckBoxColumn.MinimumWidth = 22;
			this.operativaDataGridViewCheckBoxColumn.Name = "operativaDataGridViewCheckBoxColumn";
			this.operativaDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.operativaDataGridViewCheckBoxColumn.Width = 125;
			// 
			// viPanel1
			// 
			this.viPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
			this.viPanel1.Controls.Add(this.cmdCancel);
			this.viPanel1.Controls.Add(this.cmdOK);
			this.viPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.viPanel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.viPanel1.ForeColor = System.Drawing.Color.White;
			this.viPanel1.Location = new System.Drawing.Point(0, 350);
			this.viPanel1.Name = "viPanel1";
			this.viPanel1.Size = new System.Drawing.Size(800, 100);
			this.viPanel1.TabIndex = 25;
			// 
			// cmdCancel
			// 
			this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cmdCancel.Image = global::Disponibilidad.Properties.Resources.Cancel2;
			this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCancel.Location = new System.Drawing.Point(649, 24);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(146, 53);
			this.cmdCancel.TabIndex = 28;
			this.cmdCancel.Text = "Cancelar";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// cmdOK
			// 
			this.cmdOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdOK.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cmdOK.Image = global::Disponibilidad.Properties.Resources.Aceptar2;
			this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdOK.Location = new System.Drawing.Point(14, 24);
			this.cmdOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(146, 53);
			this.cmdOK.TabIndex = 27;
			this.cmdOK.Text = "Aceptar";
			this.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdOK.UseVisualStyleBackColor = false;
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// ConfigurarAlarmas
			// 
			this.AcceptButton = this.cmdOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvDatos);
			this.Controls.Add(this.viPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConfigurarAlarmas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configurar alarmas";
			((System.ComponentModel.ISupportInitialize)(this.configAlarmas1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BSConfigAlarmas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.viPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DataBase.ConfigAlarmas configAlarmas1;
		private System.Windows.Forms.BindingSource BSConfigAlarmas;
		private Zuby.ADGV.AdvancedDataGridView dgvDatos;
		private System.Windows.Forms.DataGridViewTextBoxColumn textoAlarmaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn tecnicaDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn operativaDataGridViewCheckBoxColumn;
		private VisualStyles.VIPanel viPanel1;
		private VisualStyles.VIButton cmdCancel;
		private VisualStyles.VIButton cmdOK;
	}
}