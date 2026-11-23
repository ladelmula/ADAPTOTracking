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
	public partial class ConfigurarArbol : VisualStyles.VIForm
	{
		Arbol dsArbol;
		public ConfigurarArbol(ref Arbol dsArbol)
		{
			InitializeComponent();
			this.dsArbol = dsArbol;
		}

		private void ConfigurarArbol_Load(object sender, EventArgs e)
		{
			viTreeView1.LoadData(ref dsArbol);
		}

		
	}
}
