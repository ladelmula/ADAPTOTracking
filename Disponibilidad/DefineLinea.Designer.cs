using Disponibilidad.DataBase;
namespace Disponibilidad
{
	partial class DefineLinea
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineLinea));
			this.cbOper = new System.Windows.Forms.ComboBox();
			this.arbol = new Disponibilidad.DataBase.Arbol();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idLineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.componenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.calculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.arbolBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.OperacionesLineaBindigSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.arbol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.arbolBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OperacionesLineaBindigSource)).BeginInit();
			this.SuspendLayout();
			// 
			// cbOper
			// 
			this.cbOper.DataSource = this.arbol;
			this.cbOper.DisplayMember = "OperacionesLinea.Description";
			this.cbOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOper.FormattingEnabled = true;
			this.cbOper.Location = new System.Drawing.Point(52, 12);
			this.cbOper.Name = "cbOper";
			this.cbOper.Size = new System.Drawing.Size(121, 24);
			this.cbOper.TabIndex = 8;
			// 
			// arbol
			// 
			this.arbol.DataSetName = "Arbol";
			this.arbol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLineaDataGridViewTextBoxColumn,
            this.componenteDataGridViewTextBoxColumn,
            this.calculoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.arbolBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 39);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(431, 613);
			this.dataGridView1.TabIndex = 9;
			// 
			// idLineaDataGridViewTextBoxColumn
			// 
			this.idLineaDataGridViewTextBoxColumn.DataPropertyName = "IdLinea";
			this.idLineaDataGridViewTextBoxColumn.HeaderText = "IdLinea";
			this.idLineaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idLineaDataGridViewTextBoxColumn.Name = "idLineaDataGridViewTextBoxColumn";
			this.idLineaDataGridViewTextBoxColumn.ReadOnly = true;
			this.idLineaDataGridViewTextBoxColumn.Visible = false;
			// 
			// componenteDataGridViewTextBoxColumn
			// 
			this.componenteDataGridViewTextBoxColumn.DataPropertyName = "Componente";
			this.componenteDataGridViewTextBoxColumn.HeaderText = "Componente";
			this.componenteDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.componenteDataGridViewTextBoxColumn.Name = "componenteDataGridViewTextBoxColumn";
			// 
			// calculoDataGridViewTextBoxColumn
			// 
			this.calculoDataGridViewTextBoxColumn.DataPropertyName = "Calculo";
			this.calculoDataGridViewTextBoxColumn.HeaderText = "Calculo";
			this.calculoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.calculoDataGridViewTextBoxColumn.Name = "calculoDataGridViewTextBoxColumn";
			this.calculoDataGridViewTextBoxColumn.Visible = false;
			// 
			// arbolBindingSource
			// 
			this.arbolBindingSource.DataMember = "ComponenteLinea";
			this.arbolBindingSource.DataSource = this.arbol;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Oper";
			// 
			// OperacionesLineaBindigSource
			// 
			this.OperacionesLineaBindigSource.DataMember = "OperacionesLinea";
			this.OperacionesLineaBindigSource.DataSource = this.arbol;
			// 
			// DefineLinea
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(455, 664);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cbOper);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DefineLinea";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DefineLinea";
			this.Load += new System.EventHandler(this.DefineLinea_Load);
			((System.ComponentModel.ISupportInitialize)(this.arbol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.arbolBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OperacionesLineaBindigSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbOper;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idLineaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn componenteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn calculoDataGridViewTextBoxColumn;
		private Arbol arbol;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource OperacionesLineaBindigSource;
		private System.Windows.Forms.BindingSource arbolBindingSource;
	}
}