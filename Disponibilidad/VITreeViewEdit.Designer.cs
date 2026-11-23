using Disponibilidad.DataBase;
namespace Disponibilidad
{
	partial class VITreeViewEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VITreeViewEdit));
			this.label4 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.nodosArbolBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.arbol = new Disponibilidad.DataBase.Arbol();
			this.nudPond = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.cbOper = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.cmdCancel = new VisualStyles.VIButton();
			this.cmdOK = new VisualStyles.VIButton();
			((System.ComponentModel.ISupportInitialize)(this.nodosArbolBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.arbol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPond)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 8);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Id";
			// 
			// txtID
			// 
			this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nodosArbolBindingSource, "Id", true));
			this.txtID.Location = new System.Drawing.Point(111, 5);
			this.txtID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(374, 22);
			this.txtID.TabIndex = 21;
			// 
			// nodosArbolBindingSource
			// 
			this.nodosArbolBindingSource.DataMember = "NodosArbol";
			this.nodosArbolBindingSource.DataSource = this.arbol;
			// 
			// arbol
			// 
			this.arbol.DataSetName = "Arbol";
			this.arbol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// nudPond
			// 
			this.nudPond.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nodosArbolBindingSource, "Ponderation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.nudPond.DecimalPlaces = 5;
			this.nudPond.Location = new System.Drawing.Point(111, 179);
			this.nudPond.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.nudPond.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPond.Name = "nudPond";
			this.nudPond.Size = new System.Drawing.Size(195, 22);
			this.nudPond.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 181);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 16);
			this.label3.TabIndex = 19;
			this.label3.Text = "Pond.";
			// 
			// cbOper
			// 
			this.cbOper.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nodosArbolBindingSource, "Operation", true));
			this.cbOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOper.FormattingEnabled = true;
			this.cbOper.Items.AddRange(new object[] {
            "-",
            "Suma",
            "Multiplica",
            "Media"});
			this.cbOper.Location = new System.Drawing.Point(111, 117);
			this.cbOper.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cbOper.Name = "cbOper";
			this.cbOper.Size = new System.Drawing.Size(249, 24);
			this.cbOper.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 125);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Oper";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 67);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "Desc";
			// 
			// txtDesc
			// 
			this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nodosArbolBindingSource, "Description", true));
			this.txtDesc.Location = new System.Drawing.Point(111, 64);
			this.txtDesc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(748, 22);
			this.txtDesc.TabIndex = 15;
			// 
			// cmdCancel
			// 
			this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cmdCancel.Image = global::Disponibilidad.Properties.Resources.Cancel2;
			this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCancel.Location = new System.Drawing.Point(713, 234);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(146, 53);
			this.cmdCancel.TabIndex = 24;
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
			this.cmdOK.Location = new System.Drawing.Point(41, 235);
			this.cmdOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(146, 53);
			this.cmdOK.TabIndex = 23;
			this.cmdOK.Text = "Aceptar";
			this.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdOK.UseVisualStyleBackColor = false;
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// VITreeViewEdit
			// 
			this.AcceptButton = this.cmdOK;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size(877, 302);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOK);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.nudPond);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbOper);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDesc);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "VITreeViewEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "--";
			this.Load += new System.EventHandler(this.TreeViewEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.nodosArbolBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.arbol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPond)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.NumericUpDown nudPond;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbOper;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDesc;
		private VisualStyles.VIButton cmdOK;
		private VisualStyles.VIButton cmdCancel;
		private System.Windows.Forms.BindingSource nodosArbolBindingSource;
		private Arbol arbol;
	}
}