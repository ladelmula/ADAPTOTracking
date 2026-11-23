using AdaptoTrackingTool;
using AdaptoTrackingTool.DataBase;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using RecursosExternos = VisualStyles.Properties.Resources;
namespace AdaptoTrackingTool
{
	public partial class MainForm : VIForm
	{
		string dirAlarmasTratadas = Application.StartupPath;// System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, AdaptoTrackingTool.Properties.Settings.Default.CarpetaAlarmasEditadas));
		private TimeZoneInfo _timeZone;

		public MainForm()
		{
			InitializeComponent();
			//this.pbCustomer.Image = DataBaseUtils.LoadCustomerLogo();
		}




		private void Form1_Load(object sender, EventArgs e)
		{
			string tzId = (string)Properties.Settings.Default["TimeZoneId"];
			_timeZone = TimeZoneInfo.FindSystemTimeZoneById(tzId);
			//DataBaseUtils.CargarConfigAlarmas(ref cfgAlarmas);
			dtpDesde.Value = DateTime.Today.AddDays(-1);
			cbType.SelectedIndex = 0;
		}


		public void HabilitarControles()
		{
			dgvDatos.ReadOnly = false;
			dateTimePickerDesde.Enabled = true;
			dateTimePickerHasta.Enabled = true;

		}

		private void dgvDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			try
			{
				// Código de colores y prioridades:
				// 1 - 'Fuera de producción'--->VERDE
				// 2 - 'Fuera de producción' + 'Descartado'--->VERDE
				// 3 - 'Descartado'--->NARANJA
				// 4 - 'Nada'---BLANCO
				// 5 - 'Fuera de producción manual' + "Cualquier otra opción" ---> VERDE CLARO

				//Si 'Fuera de producción' es null, solo comprueba 'Descartado'
				if (dgvDatos.Rows[e.RowIndex].Cells["oPTIONALMESSAGEDataGridViewTextBoxColumn"].Value != System.DBNull.Value)
				{
					if (dgvDatos.Rows[e.RowIndex].Cells["oPTIONALMESSAGEDataGridViewTextBoxColumn"].Value.ToString() == "Result: Executed")
					{
						dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
					}
					else
					{
						dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
					}
				}
				//HORA LOCAL
				if (dgvDatos.Columns[e.ColumnIndex].DataPropertyName == "CREATED" && e.Value is DateTime utc)
				{
					if (utc.Kind == DateTimeKind.Unspecified)
						utc = DateTime.SpecifyKind(utc, DateTimeKind.Utc);

					e.Value = TimeZoneInfo.ConvertTimeFromUtc(utc, _timeZone);
					//e.FormattingApplied = true;
				}

				////Si 'Fuera de producción' tiene información, comprueba todos los campos
				//if (dgvDatos.Rows[e.RowIndex].Cells[FUERAPRODUCCION.Name].Value != System.DBNull.Value)
				//{
				//	if ((Boolean)dgvDatos.Rows[e.RowIndex].Cells[FUERAPRODUCCIONMANUAL.Name].Value == true)
				//	{
				//		dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
				//	}
				//	else if ((Boolean)dgvDatos.Rows[e.RowIndex].Cells[FUERAPRODUCCION.Name].Value == true)
				//	{
				//		dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
				//	}
				//	else if ((Boolean)dgvDatos.Rows[e.RowIndex].Cells[dESCARTADODataGridViewCheckBoxColumn.Name].Value == true)
				//	{
				//		dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
				//	}
				//	else if ((Boolean)dgvDatos.Rows[e.RowIndex].Cells[FUERAPRODUCCION.Name].Value == false)
				//	{
				//		dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
				//	}
				//}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "MainForm.dgvDatos_CellFormatting", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("MainForm.dgvDatos_CellFormatting", ex);
			}
		}

		//private void dgvDatos_SortStringChanged(object sender, EventArgs e)
		//{
		//	BSAlarmasGrid.Sort = dgvDatos.SortString;
		//}

		////Filtra tabla de alarmas
		//private void dgvDatos_FilterStringChanged(object sender, EventArgs e)
		//{
		//	BSAlarmasGrid.Filter = dgvDatos.FilterString;
		//}

		private void dgvDatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			DataGridViewCell actualCell = dgvDatos[e.ColumnIndex, e.RowIndex];
			object actualValue = actualCell.Value;
			if (e.Button == MouseButtons.Right)
			{
				if (dgvDatos.Columns[e.ColumnIndex] == FUERAPRODUCCIONMANUAL || dgvDatos.Columns[e.ColumnIndex] == dESCARTADODataGridViewCheckBoxColumn)
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
		private void cmdTree_Click(object sender, EventArgs e)
		{
			//ConfigurarArbol ca = new ConfigurarArbol(ref dsArbol);
			//ca.ShowDialog(this);
		}
		private void cmdAlarmas_Click(object sender, EventArgs e)
		{
			//ConfigurarAlarmas configAlarmas = new ConfigurarAlarmas(ref cfgAlarmas);
			//configAlarmas.ShowDialog(this);
		}

		private void cmdSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pbVI_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Middle)
			{
				//TODO: MENU SECRETO
			}
		}
		public void EjecutarConsultaEnDataSet(string connectionString, string sql)
		{

			using (var conn = new OracleConnection(connectionString))
			using (var cmd = new OracleCommand(sql, conn))
			using (var da = new OracleDataAdapter(cmd))
			{
				conn.Open();

				// Opcional: configurar timeout
				cmd.CommandTimeout = 30;

				// Opcional: mapear nombre por defecto de la tabla (por si quieres un nombre concreto)
				da.TableMappings.Add("Table", "Resultados");

				// Llenar DataSet -> creará un DataTable llamado "Resultados"
				da.Fill(tracking1.MOVEMENTHISTORY);
			}
		}
		private void EjecutaConsulta(string connectionString)
		{
			Cursor = Cursors.WaitCursor;
			string extrastring = (chkResumen.Checked) ? " AND (ACTION='Tracking Update sent' OR OPTIONALMESSAGE IS NOT NULL)" : "";
			string barcodeFilter = "";
			if (cbType.SelectedIndex == 0)
			{
				barcodeFilter = (txtTSUId.Text.Contains("%") ? $"BARCODE LIKE '{txtTSUId.Text}'" : $"BARCODE = '{txtTSUId.Text}'");
			}
			else if (cbType.SelectedIndex == 1)
			{
				barcodeFilter = $"BATCHODERID = '{txtTSUId.Text}'";
			}
			
			string sqlQuery= $"SELECT * FROM MOVEMENTHISTORY WHERE {barcodeFilter} {extrastring}  ORDER BY 1";
			EjecutarConsultaEnDataSet(connectionString, sqlQuery);
			tsLblAlarmas.Text = "Total filas:" + tracking1.MOVEMENTHISTORY.Count;
			Cursor = Cursors.Default;
		}
		private void cmdCargar_Click(object sender, EventArgs e)
		{
			EjecutaConsulta(Properties.Settings.Default.ADAPTO1);
			
			//SPSA
			//User Id=FMCDB_Peruanos;Password=FMCDB_Peruanos;Data Source=10.109.169.67:1521/SPLIMAFM;
			
		}

		private void viButton1_Click(object sender, EventArgs e)
		{
			EjecutaConsulta(Properties.Settings.Default.ADAPTO2);
		}

		private void btGuardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			try
			{
				saveFileDialog1.InitialDirectory = dirAlarmasTratadas;
				saveFileDialog1.Filter = "xml | *.xml";

				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					tracking1.MOVEMENTHISTORY.WriteXml(saveFileDialog1.FileName);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "MainForm.btGuardar_Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("MainForm.btGuardar_Click", ex);
			}
			Cursor = Cursors.Default;
		}

		private void cmdLoadFile_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			try
			{
				openFileDialog1.InitialDirectory = dirAlarmasTratadas;
				openFileDialog1.Filter = "xml | *.xml";
				openFileDialog1.Multiselect = false;

				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					tracking1.MOVEMENTHISTORY.ReadXml(openFileDialog1.FileName);
				}
				tsLblAlarmas.Text = "Total filas:" + tracking1.MOVEMENTHISTORY.Count;

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "MainForm.cmdLoadFile_Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("MainForm.cmdLoadFile_Click", ex);
			}
			Cursor = Cursors.Default;
		}

		private void viButton2_Click(object sender, EventArgs e)
		{
			tracking1.MOVEMENTHISTORY.Clear();
		}
	}
}
