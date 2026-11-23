using VisualStyles;
using RecursosExternos = VisualStyles.Properties.Resources;
namespace Disponibilidad
{
	partial class VITreeView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vacías*0.1");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ODS E1", 1, 1);
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ODS E2", 1, 1);
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ODS E3", 1, 1);
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ODS E4", 1, 1);
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ODS E5", 1, 1);
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ODS E6", 1, 1);
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Estaciones ODS ANILLO 1 (media)", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Resto ODS ANILLO 1");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ODS ANILLO 1 * 0.3 (multiplica)", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("ODS ANILLO 2");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ODS ANILLO 3");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("ODS (suma)", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("AAA-L");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("GTP");
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("AFRAME");
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Picking*0.7 (suma)", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("LOOP procesos*0.10");
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Processing*0.10");
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Sorter*0.10");
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Preparación de pedidos*0.7 (suma)", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Decanting*0.1");
			System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("VAS*0.1");
			System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Sistema (suma)", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode21,
            treeNode22,
            treeNode23});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VITreeView));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panelOperación = new VisualStyles.VIPanel();
			this.cmdDOWN = new VisualStyles.VIButton();
			this.cmdUP = new VisualStyles.VIButton();
			this.cmdDelete = new VisualStyles.VIButton();
			this.cmdMOD = new VisualStyles.VIButton();
			this.cmdCopy = new VisualStyles.VIButton();
			this.cmdADD = new VisualStyles.VIButton();
			this.panelOperación.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node0";
			treeNode1.Text = "Vacías*0.1";
			treeNode2.ImageIndex = 1;
			treeNode2.Name = "Node22";
			treeNode2.SelectedImageIndex = 1;
			treeNode2.Text = "ODS E1";
			treeNode3.ImageIndex = 1;
			treeNode3.Name = "Node23";
			treeNode3.SelectedImageIndex = 1;
			treeNode3.Text = "ODS E2";
			treeNode4.ImageIndex = 1;
			treeNode4.Name = "Node24";
			treeNode4.SelectedImageIndex = 1;
			treeNode4.Text = "ODS E3";
			treeNode5.ImageIndex = 1;
			treeNode5.Name = "Node25";
			treeNode5.SelectedImageIndex = 1;
			treeNode5.Text = "ODS E4";
			treeNode6.ImageIndex = 1;
			treeNode6.Name = "Node26";
			treeNode6.SelectedImageIndex = 1;
			treeNode6.Text = "ODS E5";
			treeNode7.ImageIndex = 1;
			treeNode7.Name = "Node27";
			treeNode7.SelectedImageIndex = 1;
			treeNode7.Text = "ODS E6";
			treeNode8.Name = "Node20";
			treeNode8.Text = "Estaciones ODS ANILLO 1 (media)";
			treeNode9.Name = "Node21";
			treeNode9.Text = "Resto ODS ANILLO 1";
			treeNode10.Name = "Node17";
			treeNode10.Text = "ODS ANILLO 1 * 0.3 (multiplica)";
			treeNode11.Name = "Node18";
			treeNode11.Text = "ODS ANILLO 2";
			treeNode12.Name = "Node19";
			treeNode12.Text = "ODS ANILLO 3";
			treeNode13.Name = "Node11";
			treeNode13.Text = "ODS (suma)";
			treeNode14.Name = "Node12";
			treeNode14.Text = "AAA-L";
			treeNode15.Name = "Node14";
			treeNode15.Text = "GTP";
			treeNode16.Name = "Node16";
			treeNode16.Text = "AFRAME";
			treeNode17.Name = "Node5";
			treeNode17.Text = "Picking*0.7 (suma)";
			treeNode18.Name = "Node7";
			treeNode18.Text = "LOOP procesos*0.10";
			treeNode19.Name = "Node8";
			treeNode19.Text = "Processing*0.10";
			treeNode20.Name = "Node9";
			treeNode20.Text = "Sorter*0.10";
			treeNode21.Name = "Node3";
			treeNode21.Text = "Preparación de pedidos*0.7 (suma)";
			treeNode22.Name = "Node4";
			treeNode22.Text = "Decanting*0.1";
			treeNode23.Name = "Node10";
			treeNode23.Text = "VAS*0.1";
			treeNode24.ImageKey = "Folder-Cube-01.png";
			treeNode24.Name = "Sistema";
			treeNode24.Text = "Sistema (suma)";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24});
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.ShowNodeToolTips = true;
			this.treeView1.Size = new System.Drawing.Size(231, 480);
			this.treeView1.TabIndex = 1;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Folder-Cube-01.png");
			this.imageList1.Images.SetKeyName(1, "Folder-Download-01.png");
			this.imageList1.Images.SetKeyName(2, "Folder-Special-01.png");
			// 
			// panelOperación
			// 
			this.panelOperación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
			this.panelOperación.Controls.Add(this.cmdDOWN);
			this.panelOperación.Controls.Add(this.cmdUP);
			this.panelOperación.Controls.Add(this.cmdDelete);
			this.panelOperación.Controls.Add(this.cmdMOD);
			this.panelOperación.Controls.Add(this.cmdCopy);
			this.panelOperación.Controls.Add(this.cmdADD);
			this.panelOperación.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelOperación.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.panelOperación.ForeColor = System.Drawing.Color.White;
			this.panelOperación.Location = new System.Drawing.Point(231, 0);
			this.panelOperación.Name = "panelOperación";
			this.panelOperación.Size = new System.Drawing.Size(179, 480);
			this.panelOperación.TabIndex = 3;
			// 
			// cmdDOWN
			// 
			this.cmdDOWN.AutoSize = true;
			this.cmdDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdDOWN.Enabled = false;
			this.cmdDOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdDOWN.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.cmdDOWN.Image = global::Disponibilidad.Properties.Resources.Abajo;
			this.cmdDOWN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdDOWN.Location = new System.Drawing.Point(8, 74);
			this.cmdDOWN.Margin = new System.Windows.Forms.Padding(0);
			this.cmdDOWN.Name = "cmdDOWN";
			this.cmdDOWN.Size = new System.Drawing.Size(121, 56);
			this.cmdDOWN.TabIndex = 22;
			this.cmdDOWN.Text = "Bajar";
			this.cmdDOWN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdDOWN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdDOWN.UseVisualStyleBackColor = false;
			this.cmdDOWN.Click += new System.EventHandler(this.cmdDOWN_Click);
			// 
			// cmdUP
			// 
			this.cmdUP.AutoSize = true;
			this.cmdUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdUP.Enabled = false;
			this.cmdUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdUP.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.cmdUP.Image = global::Disponibilidad.Properties.Resources.Arriba;
			this.cmdUP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdUP.Location = new System.Drawing.Point(8, 9);
			this.cmdUP.Margin = new System.Windows.Forms.Padding(0);
			this.cmdUP.Name = "cmdUP";
			this.cmdUP.Size = new System.Drawing.Size(121, 56);
			this.cmdUP.TabIndex = 21;
			this.cmdUP.Text = "Subir";
			this.cmdUP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdUP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdUP.UseVisualStyleBackColor = false;
			this.cmdUP.Click += new System.EventHandler(this.cmdUP_Click);
			// 
			// cmdDelete
			// 
			this.cmdDelete.AutoSize = true;
			this.cmdDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdDelete.Enabled = false;
			this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdDelete.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.cmdDelete.Image = global::Disponibilidad.Properties.Resources.Folder_Delete;
			this.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdDelete.Location = new System.Drawing.Point(8, 409);
			this.cmdDelete.Margin = new System.Windows.Forms.Padding(0);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(166, 56);
			this.cmdDelete.TabIndex = 20;
			this.cmdDelete.Text = "Borrar";
			this.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdDelete.UseVisualStyleBackColor = false;
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			// 
			// cmdMOD
			// 
			this.cmdMOD.AutoSize = true;
			this.cmdMOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdMOD.Enabled = false;
			this.cmdMOD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdMOD.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.cmdMOD.Image = global::Disponibilidad.Properties.Resources.Folder_Edit;
			this.cmdMOD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdMOD.Location = new System.Drawing.Point(8, 285);
			this.cmdMOD.Margin = new System.Windows.Forms.Padding(0);
			this.cmdMOD.Name = "cmdMOD";
			this.cmdMOD.Size = new System.Drawing.Size(166, 56);
			this.cmdMOD.TabIndex = 19;
			this.cmdMOD.Text = "Modificar";
			this.cmdMOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdMOD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdMOD.UseVisualStyleBackColor = false;
			this.cmdMOD.Click += new System.EventHandler(this.cmdMOD_Click);
			// 
			// cmdCopy
			// 
			this.cmdCopy.AutoSize = true;
			this.cmdCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdCopy.Enabled = false;
			this.cmdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCopy.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.cmdCopy.Image = global::Disponibilidad.Properties.Resources.Copy_01;
			this.cmdCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCopy.Location = new System.Drawing.Point(8, 220);
			this.cmdCopy.Margin = new System.Windows.Forms.Padding(0);
			this.cmdCopy.Name = "cmdCopy";
			this.cmdCopy.Size = new System.Drawing.Size(166, 56);
			this.cmdCopy.TabIndex = 18;
			this.cmdCopy.Text = "Copiar";
			this.cmdCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCopy.UseVisualStyleBackColor = false;
			this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
			// 
			// cmdADD
			// 
			this.cmdADD.AutoSize = true;
			this.cmdADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdADD.Enabled = false;
			this.cmdADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdADD.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.cmdADD.Image = global::Disponibilidad.Properties.Resources.Folder_Add;
			this.cmdADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdADD.Location = new System.Drawing.Point(8, 155);
			this.cmdADD.Margin = new System.Windows.Forms.Padding(0);
			this.cmdADD.Name = "cmdADD";
			this.cmdADD.Size = new System.Drawing.Size(167, 56);
			this.cmdADD.TabIndex = 17;
			this.cmdADD.Text = "Añadir hijo";
			this.cmdADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdADD.UseVisualStyleBackColor = false;
			this.cmdADD.Click += new System.EventHandler(this.cmdADD_Click);
			// 
			// VITreeView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.panelOperación);
			this.Name = "VITreeView";
			this.Size = new System.Drawing.Size(410, 480);
			this.panelOperación.ResumeLayout(false);
			this.panelOperación.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ImageList imageList1;
		private VIPanel panelOperación;
		private VisualStyles.VIButton cmdDOWN;
		private VisualStyles.VIButton cmdUP;
		private VisualStyles.VIButton cmdDelete;
		private VisualStyles.VIButton cmdMOD;
		private VisualStyles.VIButton cmdCopy;
		private VisualStyles.VIButton cmdADD;
	}
}
