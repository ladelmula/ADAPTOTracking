namespace AdaptoTrackingTool
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblTit = new System.Windows.Forms.Label();
			this.pnlCuadroControl = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btGuardar = new VisualStyles.VIButton();
			this.cmdLoadFile = new VisualStyles.VIButton();
			this.gbHorarioP = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.viButton2 = new VisualStyles.VIButton();
			this.chkResumen = new System.Windows.Forms.CheckBox();
			this.viButton1 = new VisualStyles.VIButton();
			this.txtTSUId = new System.Windows.Forms.TextBox();
			this.cmdCargar = new VisualStyles.VIButton();
			this.pnlAlarmas = new System.Windows.Forms.Panel();
			this.dgvDatos = new Zuby.ADGV.AdvancedDataGridView();
			this.dBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mODULEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aCTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bARCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hSRSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hSRERRORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bATCHODERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sEQGROUPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oRDERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cRANEORDERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tSUPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oPTIONALMESSAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cREATEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rELEASEGROUPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fAULTREASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sUSPECTREASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nUMOFUSABLETSUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BSAlarmasGrid = new System.Windows.Forms.BindingSource(this.components);
			this.tracking1 = new AdaptoTrackingTool.DataBase.DatosOracle();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsLblAlarmas = new System.Windows.Forms.ToolStripStatusLabel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.cmdSalir = new System.Windows.Forms.Button();
			this.pbCustomer = new System.Windows.Forms.PictureBox();
			this.pbVI = new System.Windows.Forms.PictureBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.pnlCuadroControl.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.gbHorarioP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.pnlAlarmas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BSAlarmasGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tracking1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbVI)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTit
			// 
			this.lblTit.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTit.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.lblTit.ForeColor = System.Drawing.Color.White;
			this.lblTit.Location = new System.Drawing.Point(0, 0);
			this.lblTit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTit.Name = "lblTit";
			this.lblTit.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
			this.lblTit.Size = new System.Drawing.Size(1540, 73);
			this.lblTit.TabIndex = 25;
			this.lblTit.Text = "Adapto Tracking Tool";
			this.lblTit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlCuadroControl
			// 
			this.pnlCuadroControl.Controls.Add(this.groupBox3);
			this.pnlCuadroControl.Controls.Add(this.gbHorarioP);
			this.pnlCuadroControl.Controls.Add(this.groupBox1);
			this.pnlCuadroControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCuadroControl.Location = new System.Drawing.Point(0, 73);
			this.pnlCuadroControl.Name = "pnlCuadroControl";
			this.pnlCuadroControl.Size = new System.Drawing.Size(1540, 159);
			this.pnlCuadroControl.TabIndex = 28;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btGuardar);
			this.groupBox3.Controls.Add(this.cmdLoadFile);
			this.groupBox3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(956, 11);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(215, 148);
			this.groupBox3.TabIndex = 28;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Trabajo con ficheros";
			// 
			// btGuardar
			// 
			this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btGuardar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.btGuardar.ForeColor = System.Drawing.Color.White;
			this.btGuardar.Image = global::AdaptoTrackingTool.Properties.Resources.File_Download;
			this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btGuardar.Location = new System.Drawing.Point(16, 89);
			this.btGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.btGuardar.Name = "btGuardar";
			this.btGuardar.Size = new System.Drawing.Size(178, 52);
			this.btGuardar.TabIndex = 28;
			this.btGuardar.Text = "Guardar fichero";
			this.btGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btGuardar.UseVisualStyleBackColor = false;
			this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
			// 
			// cmdLoadFile
			// 
			this.cmdLoadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLoadFile.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.cmdLoadFile.ForeColor = System.Drawing.Color.White;
			this.cmdLoadFile.Image = global::AdaptoTrackingTool.Properties.Resources.File_Upload;
			this.cmdLoadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdLoadFile.Location = new System.Drawing.Point(16, 29);
			this.cmdLoadFile.Margin = new System.Windows.Forms.Padding(4);
			this.cmdLoadFile.Name = "cmdLoadFile";
			this.cmdLoadFile.Size = new System.Drawing.Size(178, 52);
			this.cmdLoadFile.TabIndex = 20;
			this.cmdLoadFile.Text = "Cargar fichero";
			this.cmdLoadFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdLoadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdLoadFile.UseVisualStyleBackColor = false;
			this.cmdLoadFile.Click += new System.EventHandler(this.cmdLoadFile_Click);
			// 
			// gbHorarioP
			// 
			this.gbHorarioP.Controls.Add(this.pictureBox1);
			this.gbHorarioP.Controls.Add(this.label4);
			this.gbHorarioP.Controls.Add(this.dateTimePickerHasta);
			this.gbHorarioP.Controls.Add(this.label5);
			this.gbHorarioP.Controls.Add(this.dateTimePickerDesde);
			this.gbHorarioP.Controls.Add(this.dtpDesde);
			this.gbHorarioP.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.gbHorarioP.ForeColor = System.Drawing.Color.White;
			this.gbHorarioP.Location = new System.Drawing.Point(9, 6);
			this.gbHorarioP.Name = "gbHorarioP";
			this.gbHorarioP.Size = new System.Drawing.Size(215, 150);
			this.gbHorarioP.TabIndex = 27;
			this.gbHorarioP.TabStop = false;
			this.gbHorarioP.Text = "Horario de producción";
			this.gbHorarioP.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AdaptoTrackingTool.Properties.Resources.Timer;
			this.pictureBox1.Location = new System.Drawing.Point(172, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(42, 39);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
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
			this.dateTimePickerHasta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerHasta.Location = new System.Drawing.Point(81, 84);
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
			this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
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
			this.dateTimePickerDesde.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDesde.Location = new System.Drawing.Point(81, 47);
			this.dateTimePickerDesde.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePickerDesde.Name = "dateTimePickerDesde";
			this.dateTimePickerDesde.ShowUpDown = true;
			this.dateTimePickerDesde.Size = new System.Drawing.Size(112, 29);
			this.dateTimePickerDesde.TabIndex = 20;
			this.dateTimePickerDesde.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
			// 
			// dtpDesde
			// 
			this.dtpDesde.CustomFormat = "dd/MM/yyyy";
			this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDesde.Location = new System.Drawing.Point(64, 117);
			this.dtpDesde.Margin = new System.Windows.Forms.Padding(4);
			this.dtpDesde.Name = "dtpDesde";
			this.dtpDesde.Size = new System.Drawing.Size(129, 29);
			this.dtpDesde.TabIndex = 15;
			this.dtpDesde.Value = new System.DateTime(2024, 6, 17, 0, 0, 0, 0);
			this.dtpDesde.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbType);
			this.groupBox1.Controls.Add(this.viButton2);
			this.groupBox1.Controls.Add(this.chkResumen);
			this.groupBox1.Controls.Add(this.viButton1);
			this.groupBox1.Controls.Add(this.txtTSUId);
			this.groupBox1.Controls.Add(this.cmdCargar);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(239, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(711, 148);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Carga de históricos desde FMC";
			// 
			// viButton2
			// 
			this.viButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.viButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.viButton2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.viButton2.ForeColor = System.Drawing.Color.White;
			this.viButton2.Image = global::AdaptoTrackingTool.Properties.Resources.Data_Refresh;
			this.viButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.viButton2.Location = new System.Drawing.Point(541, 89);
			this.viButton2.Margin = new System.Windows.Forms.Padding(0);
			this.viButton2.Name = "viButton2";
			this.viButton2.Size = new System.Drawing.Size(126, 52);
			this.viButton2.TabIndex = 33;
			this.viButton2.Text = "Clear";
			this.viButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.viButton2.UseVisualStyleBackColor = true;
			this.viButton2.Click += new System.EventHandler(this.viButton2_Click);
			// 
			// chkResumen
			// 
			this.chkResumen.AutoSize = true;
			this.chkResumen.Checked = true;
			this.chkResumen.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkResumen.Location = new System.Drawing.Point(416, 43);
			this.chkResumen.Name = "chkResumen";
			this.chkResumen.Size = new System.Drawing.Size(104, 26);
			this.chkResumen.TabIndex = 32;
			this.chkResumen.Text = "Resumido";
			this.chkResumen.UseVisualStyleBackColor = true;
			// 
			// viButton1
			// 
			this.viButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.viButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.viButton1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.viButton1.ForeColor = System.Drawing.Color.White;
			this.viButton1.Image = global::AdaptoTrackingTool.Properties.Resources.Data_Refresh;
			this.viButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.viButton1.Location = new System.Drawing.Point(279, 89);
			this.viButton1.Margin = new System.Windows.Forms.Padding(0);
			this.viButton1.Name = "viButton1";
			this.viButton1.Size = new System.Drawing.Size(238, 52);
			this.viButton1.TabIndex = 31;
			this.viButton1.Text = "Cargar datos modulo 2";
			this.viButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.viButton1.UseVisualStyleBackColor = true;
			this.viButton1.Click += new System.EventHandler(this.viButton1_Click);
			// 
			// txtTSUId
			// 
			this.txtTSUId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.txtTSUId.Location = new System.Drawing.Point(182, 42);
			this.txtTSUId.Margin = new System.Windows.Forms.Padding(4);
			this.txtTSUId.Name = "txtTSUId";
			this.txtTSUId.Size = new System.Drawing.Size(209, 29);
			this.txtTSUId.TabIndex = 21;
			this.txtTSUId.Text = "0041899";
			this.txtTSUId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cmdCargar
			// 
			this.cmdCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCargar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.cmdCargar.ForeColor = System.Drawing.Color.White;
			this.cmdCargar.Image = global::AdaptoTrackingTool.Properties.Resources.Data_Refresh;
			this.cmdCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCargar.Location = new System.Drawing.Point(21, 89);
			this.cmdCargar.Margin = new System.Windows.Forms.Padding(0);
			this.cmdCargar.Name = "cmdCargar";
			this.cmdCargar.Size = new System.Drawing.Size(238, 52);
			this.cmdCargar.TabIndex = 19;
			this.cmdCargar.Text = "Cargar datos modulo 1";
			this.cmdCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCargar.UseVisualStyleBackColor = true;
			this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
			// 
			// pnlAlarmas
			// 
			this.pnlAlarmas.Controls.Add(this.dgvDatos);
			this.pnlAlarmas.Controls.Add(this.statusStrip1);
			this.pnlAlarmas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAlarmas.Location = new System.Drawing.Point(0, 232);
			this.pnlAlarmas.Name = "pnlAlarmas";
			this.pnlAlarmas.Size = new System.Drawing.Size(1540, 613);
			this.pnlAlarmas.TabIndex = 29;
			// 
			// dgvDatos
			// 
			this.dgvDatos.AllowUserToAddRows = false;
			this.dgvDatos.AllowUserToDeleteRows = false;
			this.dgvDatos.AutoGenerateColumns = false;
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dBIDDataGridViewTextBoxColumn,
            this.mODULEIDDataGridViewTextBoxColumn,
            this.aCTIONDataGridViewTextBoxColumn,
            this.bARCODEDataGridViewTextBoxColumn,
            this.hSRSTATUSDataGridViewTextBoxColumn,
            this.hSRERRORCODEDataGridViewTextBoxColumn,
            this.bATCHODERIDDataGridViewTextBoxColumn,
            this.sEQGROUPIDDataGridViewTextBoxColumn,
            this.oRDERIDDataGridViewTextBoxColumn,
            this.cRANEORDERIDDataGridViewTextBoxColumn,
            this.tSUPOSITIONDataGridViewTextBoxColumn,
            this.oPTIONALMESSAGEDataGridViewTextBoxColumn,
            this.cREATEDDataGridViewTextBoxColumn,
            this.rELEASEGROUPNAMEDataGridViewTextBoxColumn,
            this.fAULTREASONDataGridViewTextBoxColumn,
            this.sUSPECTREASONDataGridViewTextBoxColumn,
            this.nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn,
            this.nUMOFUSABLETSUSDataGridViewTextBoxColumn});
			this.dgvDatos.DataBindingSource = this.BSAlarmasGrid;
			this.dgvDatos.DataSource = this.BSAlarmasGrid;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDatos.FilterAndSortEnabled = true;
			this.dgvDatos.Location = new System.Drawing.Point(0, 0);
			this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.RowHeadersWidth = 25;
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvDatos.Size = new System.Drawing.Size(1540, 591);
			this.dgvDatos.SortString = "";
			this.dgvDatos.TabIndex = 23;
			this.dgvDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDatos_CellFormatting);
			this.dgvDatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatos_CellMouseClick);
			// 
			// dBIDDataGridViewTextBoxColumn
			// 
			this.dBIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dBIDDataGridViewTextBoxColumn.DataPropertyName = "DBID";
			this.dBIDDataGridViewTextBoxColumn.HeaderText = "DBID";
			this.dBIDDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.dBIDDataGridViewTextBoxColumn.Name = "dBIDDataGridViewTextBoxColumn";
			this.dBIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dBIDDataGridViewTextBoxColumn.Width = 58;
			// 
			// mODULEIDDataGridViewTextBoxColumn
			// 
			this.mODULEIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.mODULEIDDataGridViewTextBoxColumn.DataPropertyName = "MODULEID";
			this.mODULEIDDataGridViewTextBoxColumn.HeaderText = "MODULEID";
			this.mODULEIDDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.mODULEIDDataGridViewTextBoxColumn.Name = "mODULEIDDataGridViewTextBoxColumn";
			this.mODULEIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.mODULEIDDataGridViewTextBoxColumn.Visible = false;
			// 
			// aCTIONDataGridViewTextBoxColumn
			// 
			this.aCTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.aCTIONDataGridViewTextBoxColumn.DataPropertyName = "ACTION";
			this.aCTIONDataGridViewTextBoxColumn.HeaderText = "ACTION";
			this.aCTIONDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.aCTIONDataGridViewTextBoxColumn.Name = "aCTIONDataGridViewTextBoxColumn";
			this.aCTIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.aCTIONDataGridViewTextBoxColumn.Width = 72;
			// 
			// bARCODEDataGridViewTextBoxColumn
			// 
			this.bARCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.bARCODEDataGridViewTextBoxColumn.DataPropertyName = "BARCODE";
			this.bARCODEDataGridViewTextBoxColumn.HeaderText = "BARCODE";
			this.bARCODEDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.bARCODEDataGridViewTextBoxColumn.Name = "bARCODEDataGridViewTextBoxColumn";
			this.bARCODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.bARCODEDataGridViewTextBoxColumn.Width = 84;
			// 
			// hSRSTATUSDataGridViewTextBoxColumn
			// 
			this.hSRSTATUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.hSRSTATUSDataGridViewTextBoxColumn.DataPropertyName = "HSRSTATUS";
			this.hSRSTATUSDataGridViewTextBoxColumn.HeaderText = "HSRSTATUS";
			this.hSRSTATUSDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.hSRSTATUSDataGridViewTextBoxColumn.Name = "hSRSTATUSDataGridViewTextBoxColumn";
			this.hSRSTATUSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.hSRSTATUSDataGridViewTextBoxColumn.Width = 98;
			// 
			// hSRERRORCODEDataGridViewTextBoxColumn
			// 
			this.hSRERRORCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.hSRERRORCODEDataGridViewTextBoxColumn.DataPropertyName = "HSRERRORCODE";
			this.hSRERRORCODEDataGridViewTextBoxColumn.HeaderText = "HSRERRORCODE";
			this.hSRERRORCODEDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.hSRERRORCODEDataGridViewTextBoxColumn.Name = "hSRERRORCODEDataGridViewTextBoxColumn";
			this.hSRERRORCODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.hSRERRORCODEDataGridViewTextBoxColumn.Width = 124;
			// 
			// bATCHODERIDDataGridViewTextBoxColumn
			// 
			this.bATCHODERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.bATCHODERIDDataGridViewTextBoxColumn.DataPropertyName = "BATCHODERID";
			this.bATCHODERIDDataGridViewTextBoxColumn.HeaderText = "BATCHODERID";
			this.bATCHODERIDDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.bATCHODERIDDataGridViewTextBoxColumn.Name = "bATCHODERIDDataGridViewTextBoxColumn";
			this.bATCHODERIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.bATCHODERIDDataGridViewTextBoxColumn.Width = 110;
			// 
			// sEQGROUPIDDataGridViewTextBoxColumn
			// 
			this.sEQGROUPIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.sEQGROUPIDDataGridViewTextBoxColumn.DataPropertyName = "SEQGROUPID";
			this.sEQGROUPIDDataGridViewTextBoxColumn.HeaderText = "SEQGROUPID";
			this.sEQGROUPIDDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.sEQGROUPIDDataGridViewTextBoxColumn.Name = "sEQGROUPIDDataGridViewTextBoxColumn";
			this.sEQGROUPIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.sEQGROUPIDDataGridViewTextBoxColumn.Width = 104;
			// 
			// oRDERIDDataGridViewTextBoxColumn
			// 
			this.oRDERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.oRDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDERID";
			this.oRDERIDDataGridViewTextBoxColumn.HeaderText = "ORDERID";
			this.oRDERIDDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.oRDERIDDataGridViewTextBoxColumn.Name = "oRDERIDDataGridViewTextBoxColumn";
			this.oRDERIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.oRDERIDDataGridViewTextBoxColumn.Width = 82;
			// 
			// cRANEORDERIDDataGridViewTextBoxColumn
			// 
			this.cRANEORDERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.cRANEORDERIDDataGridViewTextBoxColumn.DataPropertyName = "CRANEORDERID";
			this.cRANEORDERIDDataGridViewTextBoxColumn.HeaderText = "CRANEORDERID";
			this.cRANEORDERIDDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.cRANEORDERIDDataGridViewTextBoxColumn.Name = "cRANEORDERIDDataGridViewTextBoxColumn";
			this.cRANEORDERIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.cRANEORDERIDDataGridViewTextBoxColumn.Width = 119;
			// 
			// tSUPOSITIONDataGridViewTextBoxColumn
			// 
			this.tSUPOSITIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.tSUPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "TSUPOSITION";
			this.tSUPOSITIONDataGridViewTextBoxColumn.HeaderText = "TSUPOSITION";
			this.tSUPOSITIONDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.tSUPOSITIONDataGridViewTextBoxColumn.Name = "tSUPOSITIONDataGridViewTextBoxColumn";
			this.tSUPOSITIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.tSUPOSITIONDataGridViewTextBoxColumn.Width = 105;
			// 
			// oPTIONALMESSAGEDataGridViewTextBoxColumn
			// 
			this.oPTIONALMESSAGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.oPTIONALMESSAGEDataGridViewTextBoxColumn.DataPropertyName = "OPTIONALMESSAGE";
			this.oPTIONALMESSAGEDataGridViewTextBoxColumn.HeaderText = "OPTIONALMESSAGE";
			this.oPTIONALMESSAGEDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.oPTIONALMESSAGEDataGridViewTextBoxColumn.Name = "oPTIONALMESSAGEDataGridViewTextBoxColumn";
			this.oPTIONALMESSAGEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.oPTIONALMESSAGEDataGridViewTextBoxColumn.Width = 138;
			// 
			// cREATEDDataGridViewTextBoxColumn
			// 
			this.cREATEDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.cREATEDDataGridViewTextBoxColumn.DataPropertyName = "CREATED";
			dataGridViewCellStyle3.Format = "G";
			dataGridViewCellStyle3.NullValue = null;
			this.cREATEDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.cREATEDDataGridViewTextBoxColumn.HeaderText = "CREATED";
			this.cREATEDDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.cREATEDDataGridViewTextBoxColumn.Name = "cREATEDDataGridViewTextBoxColumn";
			this.cREATEDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.cREATEDDataGridViewTextBoxColumn.Width = 83;
			// 
			// rELEASEGROUPNAMEDataGridViewTextBoxColumn
			// 
			this.rELEASEGROUPNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.rELEASEGROUPNAMEDataGridViewTextBoxColumn.DataPropertyName = "RELEASEGROUPNAME";
			this.rELEASEGROUPNAMEDataGridViewTextBoxColumn.HeaderText = "RELEASEGROUPNAME";
			this.rELEASEGROUPNAMEDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.rELEASEGROUPNAMEDataGridViewTextBoxColumn.Name = "rELEASEGROUPNAMEDataGridViewTextBoxColumn";
			this.rELEASEGROUPNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.rELEASEGROUPNAMEDataGridViewTextBoxColumn.Width = 151;
			// 
			// fAULTREASONDataGridViewTextBoxColumn
			// 
			this.fAULTREASONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.fAULTREASONDataGridViewTextBoxColumn.DataPropertyName = "FAULTREASON";
			this.fAULTREASONDataGridViewTextBoxColumn.HeaderText = "FAULTREASON";
			this.fAULTREASONDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.fAULTREASONDataGridViewTextBoxColumn.Name = "fAULTREASONDataGridViewTextBoxColumn";
			this.fAULTREASONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.fAULTREASONDataGridViewTextBoxColumn.Width = 111;
			// 
			// sUSPECTREASONDataGridViewTextBoxColumn
			// 
			this.sUSPECTREASONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.sUSPECTREASONDataGridViewTextBoxColumn.DataPropertyName = "SUSPECTREASON";
			this.sUSPECTREASONDataGridViewTextBoxColumn.HeaderText = "SUSPECTREASON";
			this.sUSPECTREASONDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.sUSPECTREASONDataGridViewTextBoxColumn.Name = "sUSPECTREASONDataGridViewTextBoxColumn";
			this.sUSPECTREASONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.sUSPECTREASONDataGridViewTextBoxColumn.Width = 127;
			// 
			// nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn
			// 
			this.nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn.DataPropertyName = "NUMOFANNOUNCEDTSUS";
			this.nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn.HeaderText = "NUMOFANNOUNCEDTSUS";
			this.nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn.Name = "nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn";
			this.nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn.Width = 169;
			// 
			// nUMOFUSABLETSUSDataGridViewTextBoxColumn
			// 
			this.nUMOFUSABLETSUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.nUMOFUSABLETSUSDataGridViewTextBoxColumn.DataPropertyName = "NUMOFUSABLETSUS";
			this.nUMOFUSABLETSUSDataGridViewTextBoxColumn.HeaderText = "NUMOFUSABLETSUS";
			this.nUMOFUSABLETSUSDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.nUMOFUSABLETSUSDataGridViewTextBoxColumn.Name = "nUMOFUSABLETSUSDataGridViewTextBoxColumn";
			this.nUMOFUSABLETSUSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.nUMOFUSABLETSUSDataGridViewTextBoxColumn.Width = 142;
			// 
			// BSAlarmasGrid
			// 
			this.BSAlarmasGrid.DataMember = "MOVEMENTHISTORY";
			this.BSAlarmasGrid.DataSource = this.tracking1;
			this.BSAlarmasGrid.Sort = "";
			// 
			// tracking1
			// 
			this.tracking1.DataSetName = "Alarmas";
			this.tracking1.Locale = new System.Globalization.CultureInfo("es-ES");
			this.tracking1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblAlarmas});
			this.statusStrip1.Location = new System.Drawing.Point(0, 591);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1540, 22);
			this.statusStrip1.TabIndex = 24;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsLblAlarmas
			// 
			this.tsLblAlarmas.Name = "tsLblAlarmas";
			this.tsLblAlarmas.Size = new System.Drawing.Size(69, 17);
			this.tsLblAlarmas.Text = "Total filas: 0";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// cmdSalir
			// 
			this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSalir.ForeColor = System.Drawing.Color.White;
			this.cmdSalir.Image = global::AdaptoTrackingTool.Properties.Resources.Exit;
			this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdSalir.Location = new System.Drawing.Point(1460, -2);
			this.cmdSalir.Margin = new System.Windows.Forms.Padding(4);
			this.cmdSalir.Name = "cmdSalir";
			this.cmdSalir.Size = new System.Drawing.Size(80, 75);
			this.cmdSalir.TabIndex = 30;
			this.cmdSalir.Text = "Salir";
			this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdSalir.UseVisualStyleBackColor = false;
			this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
			// 
			// pbCustomer
			// 
			this.pbCustomer.Location = new System.Drawing.Point(0, 0);
			this.pbCustomer.Name = "pbCustomer";
			this.pbCustomer.Size = new System.Drawing.Size(201, 73);
			this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbCustomer.TabIndex = 27;
			this.pbCustomer.TabStop = false;
			// 
			// pbVI
			// 
			this.pbVI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbVI.Image = global::AdaptoTrackingTool.Properties.Resources.VanderlandeLogoBW;
			this.pbVI.InitialImage = global::AdaptoTrackingTool.Properties.Resources.VanderlandeLogoBW;
			this.pbVI.Location = new System.Drawing.Point(1157, 0);
			this.pbVI.Name = "pbVI";
			this.pbVI.Size = new System.Drawing.Size(296, 73);
			this.pbVI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbVI.TabIndex = 26;
			this.pbVI.TabStop = false;
			this.pbVI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbVI_MouseClick);
			// 
			// cbType
			// 
			this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbType.FormattingEnabled = true;
			this.cbType.Items.AddRange(new object[] {
            "Barcode",
            "BatchOrderID"});
			this.cbType.Location = new System.Drawing.Point(21, 39);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(154, 30);
			this.cbType.TabIndex = 34;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1540, 845);
			this.Controls.Add(this.cmdSalir);
			this.Controls.Add(this.pnlAlarmas);
			this.Controls.Add(this.pnlCuadroControl);
			this.Controls.Add(this.pbCustomer);
			this.Controls.Add(this.pbVI);
			this.Controls.Add(this.lblTit);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdaptoTrackingTool";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlCuadroControl.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.gbHorarioP.ResumeLayout(false);
			this.gbHorarioP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.pnlAlarmas.ResumeLayout(false);
			this.pnlAlarmas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BSAlarmasGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tracking1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbVI)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblTit;
		private System.Windows.Forms.PictureBox pbVI;
		private System.Windows.Forms.PictureBox pbCustomer;
		private System.Windows.Forms.Panel pnlCuadroControl;
		private System.Windows.Forms.GroupBox groupBox3;
		private VisualStyles.VIButton btGuardar;
		private VisualStyles.VIButton cmdLoadFile;
		private System.Windows.Forms.GroupBox gbHorarioP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnlAlarmas;
		private Zuby.ADGV.AdvancedDataGridView dgvDatos;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsLblAlarmas;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private AdaptoTrackingTool.DataBase.DatosOracle tracking1;
		private System.Windows.Forms.BindingSource BSAlarmasGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUBSISTEMA;
		private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
		private System.Windows.Forms.DataGridViewCheckBoxColumn FUERAPRODUCCION;
		private System.Windows.Forms.DataGridViewCheckBoxColumn FUERAPRODUCCIONMANUAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
		private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINIDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tEXTODataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dURACIONDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dESCARTADODataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dAALARMDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button cmdSalir;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTSUId;
		private VisualStyles.VIButton cmdCargar;
		private System.Windows.Forms.DateTimePicker dtpDesde;
		private VisualStyles.VIButton viButton1;
		private System.Windows.Forms.CheckBox chkResumen;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private VisualStyles.VIButton viButton2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dBIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mODULEIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aCTIONDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bARCODEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hSRSTATUSDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hSRERRORCODEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bATCHODERIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sEQGROUPIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cRANEORDERIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tSUPOSITIONDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oPTIONALMESSAGEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rELEASEGROUPNAMEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fAULTREASONDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sUSPECTREASONDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nUMOFANNOUNCEDTSUSDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nUMOFUSABLETSUSDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox cbType;
	}
}

