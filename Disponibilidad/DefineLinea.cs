using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Disponibilidad.DataBase;
namespace Disponibilidad
{
	public partial class DefineLinea : Form
	{
		Arbol.NodosArbolRow nar;
		Arbol.InfoLineaRow ifr;
		public DefineLinea(int id, ref Arbol dsArbol)
		{
			InitializeComponent();
			arbol = dsArbol;
			arbolBindingSource.Filter = $"IdLinea={id}";
			cbOper.DataSource= arbolBindingSource.DataSource = arbol;
			nar = arbol.NodosArbol.FindById(id);
			
			if (arbol.OperacionesLinea.Count == 0)
			{
				arbol.OperacionesLinea.AddOperacionesLineaRow("Intersección");
				arbol.OperacionesLinea.AddOperacionesLineaRow("Cálculo de shuttles");
			}
			arbol.ComponenteLinea.IdLineaColumn.DefaultValue = id;
			dataGridView1.Columns["idLineaDataGridViewTextBoxColumn"].Visible = false;
			this.Text = "Define Línea: " + nar.Description;
		}

		private void DefineLinea_Load(object sender, EventArgs e)
		{
			
			ifr = arbol.InfoLinea.FindById(nar.Id);
			
			if (arbol.InfoLinea.FindById(nar.Id)==null)
			{
				ifr= arbol.InfoLinea.NewInfoLineaRow();
				ifr.Id = nar.Id;
				ifr.Operation = "Intersección";
				arbol.InfoLinea.AddInfoLineaRow(ifr);
			}
			cbOper.Text = ifr.Operation;

		}
	}
}
