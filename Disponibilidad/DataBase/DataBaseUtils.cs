using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disponibilidad.DataBase
{
	public static class DataBaseUtils
	{
		public static ConcurrentBag<String> ComponentesEspeciales= new ConcurrentBag<String>() { "Shuttles"};	
		public static void GuardarArbol(Arbol dsArbol)
		{
			try
			{
				dsArbol.WriteXml(@"Data\Config\DatosArbol.xml");
#if DEBUG
				dsArbol.WriteXml(@"..\..\Data\Config\DatosArbol.xml");
#endif
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "DataBase:GuardarArbol", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("DataBase:GuardarArbol", ex);
			}
		}
		public static Image LoadCustomerLogo()
		{
			return Image.FromFile(@"C:\Proyecto\InRetail\Disponibilidad\Disponibilidad\Data\Config\Customer Logo.png");
		}
		public static void CargarAlbol(ref Arbol dsArbol)
		{
			dsArbol.Clear();
			try
			{
				dsArbol.ReadXml(@"Data\Config\DatosArbol.xml");
			}
			catch
			{
				CrearNuevoArbol(ref dsArbol);
			}
		}
		public static void GuardarConfigAlarmas(ConfigAlarmas cfgAlarmas)
		{
			try
			{
				cfgAlarmas.WriteXml(@"Data\Config\ConfigAlarmas.xml");
#if DEBUG
				cfgAlarmas.WriteXml(@"..\..\Data\Config\ConfigAlarmas.xml");
#endif
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "DataBase:GuardarConfigAlarmas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("DataBase:GuardarConfigAlarmas", ex);
			}
		}
		public static void CargarConfigAlarmas(ref ConfigAlarmas cfgAlarmas)
		{
			cfgAlarmas.Clear();
			try
			{
				cfgAlarmas.ReadXml(@"Data\Config\ConfigAlarmas.xml");
			}
			catch
			{
				
			}
		}
		private static string[] operaciones = { "Suma", "Media", "Multiplica" };
		private static void CrearNuevoArbol(ref Arbol dsArbol)
		{
			try
			{
				dsArbol.NodosArbol.AddNodosArbolRow("Sistema", "Suma", 1.0, -1, 0.0);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "DataBase:CrearNuevoArbol", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("DataBase:CrearNuevoArbol", ex);
			}
		}
	}
}
