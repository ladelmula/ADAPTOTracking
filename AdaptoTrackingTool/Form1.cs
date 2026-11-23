using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace AdaptoTrackingTool
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public static DataSet EjecutarConsultaEnDataSet(string connectionString, string sql)
		{
			var ds = new DataSet();

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
				da.Fill(ds);
			}
			ds.WriteXmlSchema("esquema.xsd");
			return ds;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//User Id=usuario; Password=contraseña; Data Source=host:1521/servicio;
			DataSet ds= new DataSet();

			var connString = "User Id=FMCDB_Peruanos;Password=FMCDB_Peruanos;Data Source=10.109.169.67:1521/SPLIMAFM;"; // cámbialo a tu entorno
			ds=EjecutarConsultaEnDataSet(connectionString: connString, sql: "SELECT * FROM MOVEMENTHISTORY WHERE BARCODE='04118' AND (ACTION='Tracking Update sent' OR OPTIONALMESSAGE IS NOT NULL)");
			//using (var conn = new OracleConnection(connString))
			//{
			//	conn.Open();
			//	Console.WriteLine("Conectado a: " + conn.ServerVersion);

			//	using (var cmd = conn.CreateCommand())
			//	{
			//		cmd.CommandText = "SELECT * FROM MOVEMENTHISTORY";
			//		using (var reader = cmd.ExecuteReader())
			//		{
			//			while (reader.Read())
			//			{
			//				Console.WriteLine($"{reader.GetInt32(0)} - {reader.GetString(1)}");
			//			}
			//		}
			//	}
			//}

		}
	}
}
