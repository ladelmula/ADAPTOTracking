using System;
using System.IO;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;
namespace Logger
{
    class ExportLog
	{
        public DateTime fecha;
        public string[] campos;

		
	}
	class CircularExport
	{
        ConcurrentQueue<ExportLog> datosPendientes = new ConcurrentQueue<ExportLog>();
        public int Pendientes()
        {
            return datosPendientes.Count;
        }
        AutoResetEvent m_StopThread = new AutoResetEvent(false);

        private string _FileName = "app.log";
        public string FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
                CheckFolder();
            }
        }
        
        public DateTime currentDay = DateTime.Today;
 

        public string ErrorInfo = string.Empty;

        
        
        public CircularExport(string fileName)
        {
            FileName = fileName;
            CheckFileDate(DateTime.Today);
        }
        
        private void CheckFolder()
        {
            try
            {
                string path = Path.GetDirectoryName(FileName);
                if (path.Length > 0 && false == Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch { }
        }

        public void Write(DateTime fecha, string[] campos, string separador=";", string dateFormat= "yyyy/MM/dd HH:mm:ss.fff")
        {
            try
            {
                if (currentDay != fecha.Date)
                {
                    CheckFileDate(fecha.Date);
                    currentDay = fecha.Date;
                }
                File.AppendAllText(FileNameDay(fecha), $"{fecha.ToString(dateFormat)}{separador}{String.Join(separador,campos)}"+Environment.NewLine);
            }

			catch (Exception ex)
            {
                ErrorInfo = ex.Message;
            }
        }

        public string FileNameDay(DateTime dia)
		{
            return $"{FileName}_{dia.Day}.log";

        }

        private void CheckFileDate(DateTime dia)
		{
            if (File.Exists(FileNameDay(dia)))
            {
                FileInfo fi = new FileInfo(FileNameDay(dia));
                if (fi.LastWriteTime< dia)
				{
                    File.Delete(FileNameDay(dia));
                }
            }
        }



        #region --- Private methods -----------------------------------------------------------------------------------
        
        public bool ChangeDay()
		{
            bool result = false;
            if (currentDay != DateTime.UtcNow.Date)
			{
                result = true;

            }
            else
			{
                if (File.Exists(FileNameDay(DateTime.UtcNow.Date)))
                {
                    FileInfo fi = new FileInfo(FileNameDay(DateTime.UtcNow.Date));
                    return (fi.LastWriteTime < DateTime.UtcNow.Date);
                }
                else
                    return true;
                
            }
            return result;
		}
        
        #endregion
    }
}
