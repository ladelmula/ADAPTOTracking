namespace Disponibilidad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblTit = new System.Windows.Forms.Label();
			this.pnlCuadroControl = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdComponents = new VisualStyles.VIButton();
			this.cmdAlarmas = new VisualStyles.VIButton();
			this.cmdTree = new VisualStyles.VIButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cmdGenerarDiario = new VisualStyles.VIButton();
			this.cmdVistaPrevia = new VisualStyles.VIButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btGuardar = new VisualStyles.VIButton();
			this.cmdLoadFile = new VisualStyles.VIButton();
			this.gbHorarioP = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmdCargar = new VisualStyles.VIButton();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			this.pnlAlarmas = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsLblAlarmas = new System.Windows.Forms.ToolStripStatusLabel();
			this.dgvDatos = new Zuby.ADGV.AdvancedDataGridView();
			this.fECHAINIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fECHAFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUBSISTEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tEXTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dURACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dESCARTADODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.FUERAPRODUCCION = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.FUERAPRODUCCIONMANUAL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dAALARMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BSAlarmasGrid = new System.Windows.Forms.BindingSource(this.components);
			this.alarmas1 = new Disponibilidad.DataBase.Alarmas();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.cmdSalir = new System.Windows.Forms.Button();
			this.pbCustomer = new System.Windows.Forms.PictureBox();
			this.pbVI = new System.Windows.Forms.PictureBox();
			this.pnlCuadroControl.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.gbHorarioP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.pnlAlarmas.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BSAlarmasGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alarmas1)).BeginInit();
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
			this.lblTit.Text = "Cálculos de disponibilidad";
			this.lblTit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlCuadroControl
			// 
			this.pnlCuadroControl.Controls.Add(this.groupBox2);
			this.pnlCuadroControl.Controls.Add(this.groupBox4);
			this.pnlCuadroControl.Controls.Add(this.groupBox3);
			this.pnlCuadroControl.Controls.Add(this.gbHorarioP);
			this.pnlCuadroControl.Controls.Add(this.groupBox1);
			this.pnlCuadroControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCuadroControl.Location = new System.Drawing.Point(0, 73);
			this.pnlCuadroControl.Name = "pnlCuadroControl";
			this.pnlCuadroControl.Size = new System.Drawing.Size(1540, 159);
			this.pnlCuadroControl.TabIndex = 28;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdComponents);
			this.groupBox2.Controls.Add(this.cmdAlarmas);
			this.groupBox2.Controls.Add(this.cmdTree);
			this.groupBox2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(1139, 11);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(389, 145);
			this.groupBox2.TabIndex = 29;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Configuración";
			// 
			// cmdComponents
			// 
			this.cmdComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdComponents.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdComponents.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.cmdComponents.Image = global::Disponibilidad.Properties.Resources.Componentes;
			this.cmdComponents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdComponents.Location = new System.Drawing.Point(179, 86);
			this.cmdComponents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cmdComponents.Name = "cmdComponents";
			this.cmdComponents.Size = new System.Drawing.Size(196, 52);
			this.cmdComponents.TabIndex = 26;
			this.cmdComponents.Text = "Componentes";
			this.cmdComponents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdComponents.UseVisualStyleBackColor = false;
			this.cmdComponents.Click += new System.EventHandler(this.cmdComponents_Click);
			// 
			// cmdAlarmas
			// 
			this.cmdAlarmas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdAlarmas.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdAlarmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdAlarmas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.cmdAlarmas.Image = global::Disponibilidad.Properties.Resources.Bullets___02;
			this.cmdAlarmas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAlarmas.Location = new System.Drawing.Point(8, 86);
			this.cmdAlarmas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cmdAlarmas.Name = "cmdAlarmas";
			this.cmdAlarmas.Size = new System.Drawing.Size(161, 52);
			this.cmdAlarmas.TabIndex = 25;
			this.cmdAlarmas.Text = "Alarmas";
			this.cmdAlarmas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdAlarmas.UseVisualStyleBackColor = false;
			this.cmdAlarmas.Click += new System.EventHandler(this.cmdAlarmas_Click);
			// 
			// cmdTree
			// 
			this.cmdTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdTree.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdTree.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.cmdTree.Image = global::Disponibilidad.Properties.Resources.Arbol;
			this.cmdTree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdTree.Location = new System.Drawing.Point(8, 26);
			this.cmdTree.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cmdTree.Name = "cmdTree";
			this.cmdTree.Size = new System.Drawing.Size(161, 52);
			this.cmdTree.TabIndex = 24;
			this.cmdTree.Text = "Árbol";
			this.cmdTree.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdTree.UseVisualStyleBackColor = false;
			this.cmdTree.Click += new System.EventHandler(this.cmdTree_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cmdGenerarDiario);
			this.groupBox4.Controls.Add(this.cmdVistaPrevia);
			this.groupBox4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.groupBox4.ForeColor = System.Drawing.Color.White;
			this.groupBox4.Location = new System.Drawing.Point(741, 11);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(388, 150);
			this.groupBox4.TabIndex = 29;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Informes";
			// 
			// cmdGenerarDiario
			// 
			this.cmdGenerarDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdGenerarDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdGenerarDiario.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.cmdGenerarDiario.ForeColor = System.Drawing.Color.White;
			this.cmdGenerarDiario.Image = ((System.Drawing.Image)(resources.GetObject("cmdGenerarDiario.Image")));
			this.cmdGenerarDiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGenerarDiario.Location = new System.Drawing.Point(9, 91);
			this.cmdGenerarDiario.Margin = new System.Windows.Forms.Padding(4);
			this.cmdGenerarDiario.Name = "cmdGenerarDiario";
			this.cmdGenerarDiario.Size = new System.Drawing.Size(367, 52);
			this.cmdGenerarDiario.TabIndex = 21;
			this.cmdGenerarDiario.Text = "Guardar fichero y generar informes diarios";
			this.cmdGenerarDiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdGenerarDiario.UseVisualStyleBackColor = false;
			// 
			// cmdVistaPrevia
			// 
			this.cmdVistaPrevia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdVistaPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.cmdVistaPrevia.ForeColor = System.Drawing.Color.White;
			this.cmdVistaPrevia.Image = ((System.Drawing.Image)(resources.GetObject("cmdVistaPrevia.Image")));
			this.cmdVistaPrevia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdVistaPrevia.Location = new System.Drawing.Point(9, 31);
			this.cmdVistaPrevia.Margin = new System.Windows.Forms.Padding(0);
			this.cmdVistaPrevia.Name = "cmdVistaPrevia";
			this.cmdVistaPrevia.Size = new System.Drawing.Size(367, 52);
			this.cmdVistaPrevia.TabIndex = 20;
			this.cmdVistaPrevia.Text = "Vista previa de informes diarios";
			this.cmdVistaPrevia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdVistaPrevia.UseVisualStyleBackColor = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btGuardar);
			this.groupBox3.Controls.Add(this.cmdLoadFile);
			this.groupBox3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(520, 11);
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
			this.btGuardar.Image = global::Disponibilidad.Properties.Resources.File_Download;
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
			this.cmdLoadFile.Image = global::Disponibilidad.Properties.Resources.File_Upload;
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
			this.gbHorarioP.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.gbHorarioP.ForeColor = System.Drawing.Color.White;
			this.gbHorarioP.Location = new System.Drawing.Point(9, 6);
			this.gbHorarioP.Name = "gbHorarioP";
			this.gbHorarioP.Size = new System.Drawing.Size(215, 150);
			this.gbHorarioP.TabIndex = 27;
			this.gbHorarioP.TabStop = false;
			this.gbHorarioP.Text = "Horario de producción";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Disponibilidad.Properties.Resources.Timer;
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmdCargar);
			this.groupBox1.Controls.Add(this.dtpDesde);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(239, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(266, 148);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Carga de alarmas desde SCADA";
			// 
			// cmdCargar
			// 
			this.cmdCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCargar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.cmdCargar.ForeColor = System.Drawing.Color.White;
			this.cmdCargar.Image = global::Disponibilidad.Properties.Resources.Data_Refresh;
			this.cmdCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCargar.Location = new System.Drawing.Point(46, 89);
			this.cmdCargar.Margin = new System.Windows.Forms.Padding(0);
			this.cmdCargar.Name = "cmdCargar";
			this.cmdCargar.Size = new System.Drawing.Size(193, 52);
			this.cmdCargar.TabIndex = 19;
			this.cmdCargar.Text = "Cargar alarmas";
			this.cmdCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCargar.UseVisualStyleBackColor = true;
			// 
			// dtpDesde
			// 
			this.dtpDesde.CustomFormat = "dd/MM/yyyy";
			this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDesde.Location = new System.Drawing.Point(40, 40);
			this.dtpDesde.Margin = new System.Windows.Forms.Padding(4);
			this.dtpDesde.Name = "dtpDesde";
			this.dtpDesde.Size = new System.Drawing.Size(199, 29);
			this.dtpDesde.TabIndex = 15;
			this.dtpDesde.Value = new System.DateTime(2024, 6, 17, 0, 0, 0, 0);
			// 
			// pnlAlarmas
			// 
			this.pnlAlarmas.Controls.Add(this.statusStrip1);
			this.pnlAlarmas.Controls.Add(this.dgvDatos);
			this.pnlAlarmas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAlarmas.Location = new System.Drawing.Point(0, 232);
			this.pnlAlarmas.Name = "pnlAlarmas";
			this.pnlAlarmas.Size = new System.Drawing.Size(1540, 613);
			this.pnlAlarmas.TabIndex = 29;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblAlarmas});
			this.statusStrip1.Location = new System.Drawing.Point(0, 587);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1540, 26);
			this.statusStrip1.TabIndex = 24;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsLblAlarmas
			// 
			this.tsLblAlarmas.Name = "tsLblAlarmas";
			this.tsLblAlarmas.Size = new System.Drawing.Size(115, 20);
			this.tsLblAlarmas.Text = "Total Alarmas: 0";
			// 
			// dgvDatos
			// 
			this.dgvDatos.AllowUserToAddRows = false;
			this.dgvDatos.AllowUserToDeleteRows = false;
			this.dgvDatos.AutoGenerateColumns = false;
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fECHAINIDataGridViewTextBoxColumn,
            this.fECHAFINDataGridViewTextBoxColumn,
            this.SUBSISTEMA,
            this.AREA,
            this.tEXTODataGridViewTextBoxColumn,
            this.dURACIONDataGridViewTextBoxColumn,
            this.dESCARTADODataGridViewCheckBoxColumn,
            this.FUERAPRODUCCION,
            this.FUERAPRODUCCIONMANUAL,
            this.OBSERVACIONES,
            this.dAALARMDataGridViewTextBoxColumn});
			this.dgvDatos.DataBindingSource = this.BSAlarmasGrid;
			this.dgvDatos.DataSource = this.BSAlarmasGrid;
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
			this.dgvDatos.Size = new System.Drawing.Size(1540, 613);
			this.dgvDatos.SortString = "";
			this.dgvDatos.TabIndex = 23;
			this.dgvDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDatos_CellFormatting);
			this.dgvDatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatos_CellMouseClick);
			// 
			// fECHAINIDataGridViewTextBoxColumn
			// 
			this.fECHAINIDataGridViewTextBoxColumn.DataPropertyName = "FECHA_INI";
			this.fECHAINIDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
			this.fECHAINIDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.fECHAINIDataGridViewTextBoxColumn.Name = "fECHAINIDataGridViewTextBoxColumn";
			this.fECHAINIDataGridViewTextBoxColumn.ReadOnly = true;
			this.fECHAINIDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.fECHAINIDataGridViewTextBoxColumn.Width = 125;
			// 
			// fECHAFINDataGridViewTextBoxColumn
			// 
			this.fECHAFINDataGridViewTextBoxColumn.DataPropertyName = "FECHA_FIN";
			this.fECHAFINDataGridViewTextBoxColumn.HeaderText = "Fecha Fin";
			this.fECHAFINDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.fECHAFINDataGridViewTextBoxColumn.Name = "fECHAFINDataGridViewTextBoxColumn";
			this.fECHAFINDataGridViewTextBoxColumn.ReadOnly = true;
			this.fECHAFINDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.fECHAFINDataGridViewTextBoxColumn.Width = 125;
			// 
			// SUBSISTEMA
			// 
			this.SUBSISTEMA.DataPropertyName = "SUBSISTEMA";
			this.SUBSISTEMA.HeaderText = "Subsistema";
			this.SUBSISTEMA.MinimumWidth = 22;
			this.SUBSISTEMA.Name = "SUBSISTEMA";
			this.SUBSISTEMA.ReadOnly = true;
			this.SUBSISTEMA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.SUBSISTEMA.Width = 86;
			// 
			// AREA
			// 
			this.AREA.DataPropertyName = "AREA";
			this.AREA.HeaderText = "Area";
			this.AREA.MinimumWidth = 22;
			this.AREA.Name = "AREA";
			this.AREA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.AREA.Width = 70;
			// 
			// tEXTODataGridViewTextBoxColumn
			// 
			this.tEXTODataGridViewTextBoxColumn.DataPropertyName = "TEXTO";
			this.tEXTODataGridViewTextBoxColumn.HeaderText = "Texto";
			this.tEXTODataGridViewTextBoxColumn.MinimumWidth = 22;
			this.tEXTODataGridViewTextBoxColumn.Name = "tEXTODataGridViewTextBoxColumn";
			this.tEXTODataGridViewTextBoxColumn.ReadOnly = true;
			this.tEXTODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.tEXTODataGridViewTextBoxColumn.Width = 125;
			// 
			// dURACIONDataGridViewTextBoxColumn
			// 
			this.dURACIONDataGridViewTextBoxColumn.DataPropertyName = "DURACION";
			this.dURACIONDataGridViewTextBoxColumn.HeaderText = "Duración";
			this.dURACIONDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.dURACIONDataGridViewTextBoxColumn.Name = "dURACIONDataGridViewTextBoxColumn";
			this.dURACIONDataGridViewTextBoxColumn.ReadOnly = true;
			this.dURACIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dURACIONDataGridViewTextBoxColumn.Width = 125;
			// 
			// dESCARTADODataGridViewCheckBoxColumn
			// 
			this.dESCARTADODataGridViewCheckBoxColumn.DataPropertyName = "DESCARTADO";
			this.dESCARTADODataGridViewCheckBoxColumn.HeaderText = "Descartado";
			this.dESCARTADODataGridViewCheckBoxColumn.MinimumWidth = 22;
			this.dESCARTADODataGridViewCheckBoxColumn.Name = "dESCARTADODataGridViewCheckBoxColumn";
			this.dESCARTADODataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dESCARTADODataGridViewCheckBoxColumn.Width = 125;
			// 
			// FUERAPRODUCCION
			// 
			this.FUERAPRODUCCION.DataPropertyName = "FUERAPRODUCCION";
			this.FUERAPRODUCCION.HeaderText = "Filtro automático por mantenimiento";
			this.FUERAPRODUCCION.MinimumWidth = 22;
			this.FUERAPRODUCCION.Name = "FUERAPRODUCCION";
			this.FUERAPRODUCCION.ReadOnly = true;
			this.FUERAPRODUCCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.FUERAPRODUCCION.Width = 125;
			// 
			// FUERAPRODUCCIONMANUAL
			// 
			this.FUERAPRODUCCIONMANUAL.DataPropertyName = "FUERAPRODUCCIONMANUAL";
			this.FUERAPRODUCCIONMANUAL.HeaderText = "Filtro manual por mantenimiento";
			this.FUERAPRODUCCIONMANUAL.MinimumWidth = 22;
			this.FUERAPRODUCCIONMANUAL.Name = "FUERAPRODUCCIONMANUAL";
			this.FUERAPRODUCCIONMANUAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.FUERAPRODUCCIONMANUAL.Width = 110;
			// 
			// OBSERVACIONES
			// 
			this.OBSERVACIONES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.OBSERVACIONES.DataPropertyName = "OBSERVACIONES";
			this.OBSERVACIONES.HeaderText = "Observaciones";
			this.OBSERVACIONES.MinimumWidth = 22;
			this.OBSERVACIONES.Name = "OBSERVACIONES";
			this.OBSERVACIONES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.OBSERVACIONES.Width = 485;
			// 
			// dAALARMDataGridViewTextBoxColumn
			// 
			this.dAALARMDataGridViewTextBoxColumn.DataPropertyName = "DA_ALARM";
			this.dAALARMDataGridViewTextBoxColumn.HeaderText = "DA_ALARM";
			this.dAALARMDataGridViewTextBoxColumn.MinimumWidth = 22;
			this.dAALARMDataGridViewTextBoxColumn.Name = "dAALARMDataGridViewTextBoxColumn";
			this.dAALARMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dAALARMDataGridViewTextBoxColumn.Visible = false;
			this.dAALARMDataGridViewTextBoxColumn.Width = 125;
			// 
			// BSAlarmasGrid
			// 
			this.BSAlarmasGrid.DataMember = "H_Alarmas_DW";
			this.BSAlarmasGrid.DataSource = this.alarmas1;
			this.BSAlarmasGrid.Sort = "";
			// 
			// alarmas1
			// 
			this.alarmas1.DataSetName = "Alarmas";
			this.alarmas1.Locale = new System.Globalization.CultureInfo("es-ES");
			this.alarmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			this.cmdSalir.Image = global::Disponibilidad.Properties.Resources.Exit;
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
			this.pbVI.Image = global::Disponibilidad.Properties.Resources.VanderlandeLogoBW;
			this.pbVI.InitialImage = global::Disponibilidad.Properties.Resources.VanderlandeLogoBW;
			this.pbVI.Location = new System.Drawing.Point(1157, 0);
			this.pbVI.Name = "pbVI";
			this.pbVI.Size = new System.Drawing.Size(296, 73);
			this.pbVI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbVI.TabIndex = 26;
			this.pbVI.TabStop = false;
			this.pbVI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbVI_MouseClick);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cálculos de disponibilidad";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlCuadroControl.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.gbHorarioP.ResumeLayout(false);
			this.gbHorarioP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.pnlAlarmas.ResumeLayout(false);
			this.pnlAlarmas.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BSAlarmasGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alarmas1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbVI)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private VisualStyles.VIButton cmdTree;
		private System.Windows.Forms.Label lblTit;
		private System.Windows.Forms.PictureBox pbVI;
		private System.Windows.Forms.PictureBox pbCustomer;
		private System.Windows.Forms.Panel pnlCuadroControl;
		private System.Windows.Forms.GroupBox groupBox4;
		private VisualStyles.VIButton cmdGenerarDiario;
		private VisualStyles.VIButton cmdVistaPrevia;
		private System.Windows.Forms.GroupBox groupBox3;
		private VisualStyles.VIButton btGuardar;
		private VisualStyles.VIButton cmdLoadFile;
		private System.Windows.Forms.GroupBox gbHorarioP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
		private System.Windows.Forms.GroupBox groupBox1;
		private VisualStyles.VIButton cmdCargar;
		private System.Windows.Forms.DateTimePicker dtpDesde;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private VisualStyles.VIButton cmdAlarmas;
		private System.Windows.Forms.Panel pnlAlarmas;
		private Zuby.ADGV.AdvancedDataGridView dgvDatos;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsLblAlarmas;
		private VisualStyles.VIButton cmdComponents;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private DataBase.Alarmas alarmas1;
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
	}
}

