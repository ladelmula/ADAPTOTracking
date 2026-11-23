using Disponibilidad.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualStyles;
namespace Disponibilidad
{
	public partial class ConfigurarAlarmas : VIForm
	{
		ConfigAlarmas dsCfgAlarmas;
		
		public ConfigurarAlarmas(ref ConfigAlarmas dsCfgAlarmas)
		{
			dsCfgAlarmas.AcceptChanges();
			this.dsCfgAlarmas=dsCfgAlarmas;
			InitializeComponent();
			this.configAlarmas1 = dsCfgAlarmas;
			BSConfigAlarmas.DataSource = this.configAlarmas1;
		}

		

		private void dgvDatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			DataGridViewCell actualCell = dgvDatos[e.ColumnIndex, e.RowIndex];
			object actualValue = actualCell.Value;
			if (e.Button == MouseButtons.Right)
			{
				if (dgvDatos.Columns[e.ColumnIndex] == tecnicaDataGridViewCheckBoxColumn || dgvDatos.Columns[e.ColumnIndex] == operativaDataGridViewCheckBoxColumn)
				{
					actualCell.Value = !(bool)actualCell.Value;
					List<int> rows = new List<int>();
					foreach (DataGridViewCell dgvc in dgvDatos.SelectedCells)
					{
						if (!rows.Contains(dgvc.RowIndex))
						{
							rows.Add(dgvc.RowIndex);
						}
					}
					foreach (int row in rows)
					{
						dgvDatos[e.ColumnIndex, row].Value = !(bool)actualValue;

					}
					dgvDatos.RefreshEdit();
					//dgvDatos.ClearSelection();
				}
			}
		}
		private void cmdOK_Click(object sender, EventArgs e)
		{
			dsCfgAlarmas.AcceptChanges();
			DataBaseUtils.GuardarConfigAlarmas(dsCfgAlarmas);
		}
		private void cmdCancel_Click(object sender, EventArgs e)
		{
			dsCfgAlarmas.RejectChanges();
		}
	}
}
