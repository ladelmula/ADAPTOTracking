using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disponibilidad
{
	internal static class Program
	{
		public static Logger.LogFile errorLogFile = new Logger.LogFile(@"Data\Logs\Errores.log");
		public static Logger.LogFile traceLogFile = new Logger.LogFile(@"Data\Logs\Trazas.log");
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
