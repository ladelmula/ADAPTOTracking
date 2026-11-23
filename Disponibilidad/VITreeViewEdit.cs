using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disponibilidad.DataBase;
namespace Disponibilidad
{
	public partial class VITreeViewEdit : VisualStyles.VIForm
	{
		string funcionalidad;
		public VITreeViewEdit(string funcionalidad,ref Arbol.NodosArbolRow nar)
		{
			this.funcionalidad = funcionalidad;
			//nodosArbolBindingSource.DataMember = "";
			
			InitializeComponent();
			this.Text= funcionalidad;
			nodosArbolBindingSource.DataSource = nar;
		}

		private void TreeViewEdit_Load(object sender, EventArgs e)
		{

		}

		private void cmdOK_Click(object sender, EventArgs e)
		{
			cmdOK.Focus();
		}
	}
}
