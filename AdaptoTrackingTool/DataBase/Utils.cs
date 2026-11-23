using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdaptoTrackingTool.DataBase
{
	public static class Utils
	{

		public static TimeZoneInfo GetConfiguredTimeZone()
		{
			var tzId = ConfigurationManager.AppSettings["TimeZoneId"];
			if (string.IsNullOrWhiteSpace(tzId))
				throw new InvalidOperationException("Falta appSettings['TimeZoneId'] en .config.");

			try
			{
				// Intento directo (funciona en Windows con "SA Pacific Standard Time"
				// y en Linux si el ID es IANA y la implementación soporta IANA nativamente).
				return TimeZoneInfo.FindSystemTimeZoneById(tzId);
			}
			catch (TimeZoneNotFoundException)
			{
				// Si estás en Linux y te pasaron un ID de Windows, o viceversa, puedes mapearlo:
				// Mapeo rápido mínimo para Perú:
				if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && tzId.Equals("America/Lima", StringComparison.OrdinalIgnoreCase))
					return TimeZoneInfo.FindSystemTimeZoneById("SA Pacific Standard Time");
				if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && tzId.Equals("SA Pacific Standard Time", StringComparison.OrdinalIgnoreCase))
					return TimeZoneInfo.FindSystemTimeZoneById("America/Lima");

				throw;
			}
		}

		public static string MostrarFechaPeru(DataRow row)
		{
			var tz = GetConfiguredTimeZone();

			// 1) Leer del DataSet (viene Unspecified)
			var raw = row.Field<DateTime>("FechaUtc");

			// 2) Marcar como UTC
			var utc = DateTime.SpecifyKind(raw, DateTimeKind.Utc);

			// 3) Convertir a Perú
			var lima = TimeZoneInfo.ConvertTimeFromUtc(utc, tz);

			// 4) Formatear
			var cultura = System.Globalization.CultureInfo.GetCultureInfo("es-PE");
			return lima.ToString("dd/MM/yyyy HH:mm:ss", cultura);
		}


	}
}
