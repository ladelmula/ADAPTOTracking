using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using RecursosExternos = VisualStyles.Properties.Resources;
using Disponibilidad.DataBase;
using System.IO;
namespace Disponibilidad
{
	public partial class MainForm : VIForm
	{
		Arbol dsArbol = new Arbol();
		ConfigAlarmas cfgAlarmas= new ConfigAlarmas();
		string dirAlarmasTratadas = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, Properties.Settings.Default.CarpetaAlarmasEditadas));

		public MainForm()
		{
			InitializeComponent();
			this.pbCustomer.Image = DataBaseUtils.LoadCustomerLogo();
		}
		
		

		
		private void Form1_Load(object sender, EventArgs e)
		{
			//TODO:
			//Que las ponderacíones puedan depender de una tabla de valores, en plan "Ponderación línea de cajas", y que eso esté ligado
			//Que en cada nodo de un árbol se pueda ver las alarmas mostradas que afectan a ese área
			//Modo configuración o modo consulta
			//Carga y guardado de alarmas (como BP y Consum).
			//Definición de alarmas y disponibilidades técnicas/operativas
			//Chequeos sobre base de datos (transportadores/elementos faltantes, Alarmas faltantes
			//Rangos de colores en función del valor de cada nodo del árbol
			//Trazabilidad y control de excepciones
			//Ejcución por línea de comandos, para programaciones
			//¿Como definir líneas que se "complementan"?
			//En sumas ponderadas, ¿Podríamos poner una ponderación técnica y otra operativa?
			//La intersección actual es unión
			//Operación intersección, entre grupos de trasportadores
			DataBaseUtils.CargarConfigAlarmas(ref cfgAlarmas);

		}

		
		public void HabilitarControles()
		{
			dgvDatos.ReadOnly = false;
			dateTimePickerDesde.Enabled = true;
			dateTimePickerHasta.Enabled = true;
			cmdGenerarDiario.Enabled = true;
			cmdVistaPrevia.Enabled = true;
		}
		private void CargarFicheroAlarmas(string fichero)
		{
			alarmas1.Clear();
			alarmas1.ReadXml(fichero);

			//lbArchivo.Visible = true;
			int barra = fichero.LastIndexOf('\\');
			//lbArchivo.Text = fichero.Substring(barra + 1);
			BSAlarmasGrid.Sort = "FECHA_INI";
			dgvDatos.ClearSelection();

			//22/06/18---El archivo ya es de alarmas tratadas pero así aseguramos que se muestran los valores correctos en 'filtro produccion'
			//El tratamiento se hace sobre alarmas1. No sobre alarmasGlobal (los archivos origen ya estarán tratados)
			//TratarAlarmas();

			//Aplica filtro de horario de producción según los valores recién recuperados
			//22/06/18---El archivo ya es de alarmas tratadas, por lo que ya tiene 'horario producción' aplicado
			//MarcarProduccion(dateTimePickerDesde.Value.TimeOfDay, dateTimePickerHasta.Value.TimeOfDay)

			HabilitarControles();
			//Cargar config de alarmas y comprobar que están todas o darlas de alta
			
			DataView view = new DataView(alarmas1.H_Alarmas_DW);
			DataTable distinctValues = view.ToTable(true, "TEXTO");
			foreach (DataRow dr in distinctValues.Rows)
			{
				if (cfgAlarmas._ConfigAlarmas.FindByTextoAlarma(dr[0].ToString()) == null)
				{
					cfgAlarmas._ConfigAlarmas.AddConfigAlarmasRow(dr[0].ToString(), false, false);
				}
			}
			DataBaseUtils.GuardarConfigAlarmas(cfgAlarmas);
		}
		private void cmdLoadFile_Click(object sender, EventArgs e)
		{
			Cursor=Cursors.WaitCursor;
			try
			{
				openFileDialog1.InitialDirectory = dirAlarmasTratadas;
				openFileDialog1.Filter = "xml | *tratadas*.xml";
				openFileDialog1.Multiselect = false;

				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					CargarFicheroAlarmas(openFileDialog1.FileName);
				}
				tsLblAlarmas.Text = "Total Alarmas:" + alarmas1.H_Alarmas_DW.Count;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "MainForm.cmdLoadFile_Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("MainForm.cmdLoadFile_Click", ex);
			}
			Cursor=Cursors.Default;
		}

		private void cmdComponents_Click(object sender, EventArgs e)
		{
			Configurar_componentes ca = new Configurar_componentes();
			ca.ShowDialog(this);
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
				if (dgvDatos.Rows[e.RowIndex].Cells[FUERAPRODUCCION.Name].Value == System.DBNull.Value)
				{
					if ((Boolean)dgvDatos.Rows[e.RowIndex].Cells[dESCARTADODataGridViewCheckBoxColumn.Name].Value == true)
					{
						dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
					}
				}

				//Si 'Fuera de producción' tiene información, comprueba todos los campos
				if (dgvDatos.Rows[e.RowIndex].Cells[FUERAPRODUCCION.Name].Value != System.DBNull.Value)
				{
					if ((Boolean)dgvDatos.Rows[e.RowIndex].Cells[FUERAPRODUCCIONMANUAL.Name].Value == true)
					{
						dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
					}
					else if ((Boolean)dgvDatos.Rows[e.RowIndex].Cells[FUERAPRODUCCION.Name].Value == true)
					{
						dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
					}
					else if ((Boolean)dgvDatos.Rows[e.RowIndex].Cells[dESCARTADODataGridViewCheckBoxColumn.Name].Value == true)
					{
						dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
					}
					else if ((Boolean)dgvDatos.Rows[e.RowIndex].Cells[FUERAPRODUCCION.Name].Value == false)
					{
						dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
					}
				}
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
			if (e.Button==MouseButtons.Right)
			{ 
				if (dgvDatos.Columns[e.ColumnIndex] == FUERAPRODUCCIONMANUAL || dgvDatos.Columns[e.ColumnIndex] == dESCARTADODataGridViewCheckBoxColumn)
				{
					actualCell.Value = !(bool)actualCell.Value;
					List<int> rows= new List<int>();
					foreach (DataGridViewCell dgvc in dgvDatos.SelectedCells)
					{
						if (!rows.Contains(dgvc.RowIndex)) 
						{ 
							rows.Add(dgvc.RowIndex); 
						}
					}
					foreach (int row in rows)
					{
						dgvDatos[e.ColumnIndex,row].Value = !(bool)actualValue;
						
					}
					dgvDatos.RefreshEdit();
					//dgvDatos.ClearSelection();
				}
			}
		}
		private void cmdTree_Click(object sender, EventArgs e)
		{
			ConfigurarArbol ca = new ConfigurarArbol(ref dsArbol);
			ca.ShowDialog(this);
		}
		private void cmdAlarmas_Click(object sender, EventArgs e)
		{
			ConfigurarAlarmas configAlarmas = new ConfigurarAlarmas(ref cfgAlarmas);
			configAlarmas.ShowDialog(this);
		}

		private void cmdSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pbVI_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button==MouseButtons.Middle)
			{
				//TODO: MENU SECRETO
			}
		}

		private void btGuardar_Click(object sender, EventArgs e)
		{

		}
	}
}
