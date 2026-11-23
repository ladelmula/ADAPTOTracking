using System;
using System.IO;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;
namespace Logger
{
    public class LogFile
    {
        ConcurrentQueue<string> datosPendientes= new ConcurrentQueue<string>();
        public int Pendientes()
        {
            return datosPendientes.Count;
        }
        AutoResetEvent m_StopThread = new AutoResetEvent(false);
        //Thread thrWrite = null;
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
                FirstCheckFileMaxSize();
                CheckFolder();
            }
        }
        public int MaxFileSize = 10485760;
        public int currentSize = 0;
        public int MaxBackupFiles = 10;

        public string ErrorInfo = string.Empty;

        #region -- Log Levels -----------------------------------------------------------------------------------------

        public enum LogLevel
        {
            Debug=0,            
            Info,
            Warning,
            Error,
            Fatal
        }

        public string[] LogLevelNames =
        { 
            "Debug",
            "Info",
            "Warning",
            "Error",
            "Fatal"
        };

        public bool[] EnabledLogLevels = 
        {
            true,
            true,
            true,
            true,
            true
        };

        public void DisableLogLevel(LogLevel Level)
        {
            EnabledLogLevels[(int)Level] = false;
        }

        public void EnableLogLevel(LogLevel Level)
        {
            EnabledLogLevels[(int)Level] = true;
        }

        #endregion

        public LogFile()
        {
        }
		public LogFile(string fileName)
		{
			FileName = fileName;
		}
		public LogFile(string fileName, int maxFileSize)
		{
			FileName = fileName;
			MaxFileSize = maxFileSize;
		}

		public LogFile(string fileName, int maxFileSize, int maxBackupFiles)
		{
			FileName = fileName;
			MaxFileSize = maxFileSize;
			MaxBackupFiles = maxBackupFiles;
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
        

        
		public void WritePlainText(string Text)
		{
			Text = Text.Replace("\r", " ").Replace("\n", " ").Replace("\t", "    ");

			try
			{
				datosPendientes.Enqueue(Text);
				Task t = Task.Factory.StartNew(() =>
				{
					BackGroundWrite();
				});
			}
			catch (Exception ex)
			{
				ErrorInfo = ex.Message;
			}
		}

		public void Write(LogLevel Level, string Text,bool Only1Line)
        {
            if (false == EnabledLogLevels[(int)Level])
            {
                return;
            }

            if (Only1Line)
            {
                Text = Text.Replace("\r", " ").Replace("\n", " ").Replace("\t", "    ");
            }
            

            try
            {

                string Line = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + " : " + LogLevelNames[(int)Level].PadLeft(7, ' ') + " : " + Text;
                datosPendientes.Enqueue(Line);
                Task t = Task.Factory.StartNew(() =>
                {
                    BackGroundWrite();
                });
                if (null != OnNewLogEntry)
                {
                    OnNewLogEntry(Level, Line);
                }
            }
            catch (Exception ex)
            {
                ErrorInfo = ex.Message;
            }
        }
        public void BackGroundWrite()
        {
            try
            {
                lock (datosPendientes)
                {
                    while (datosPendientes.Count > 0)
                    {
                        CheckFileMaxSize();
                        FileStream fs = new FileStream(FileName, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                        using (TextWriter w = new StreamWriter(fs))
                        {
                            string Text = "";
                            while (datosPendientes.TryDequeue(out Text))
                            {
                                w.WriteLine(Text);
                                currentSize += Text.Length;
                                if (currentSize > MaxFileSize)
                                    break;
                            }
                            w.Close();
                        }
                    }
                }
            }
            catch
            {
            }
        }
        public delegate void NewLogEntry(LogLevel Level, string Text);
        public event NewLogEntry OnNewLogEntry;

        #region -- Level Shortcuts --

        public void WriteDebug(string Text)
        {
            Write(LogLevel.Debug, Text,true);
        }

        public void WriteInfo(string Text)
        {
            Write(LogLevel.Info, Text,true);
        }

        public void WriteWarning(string Text)
        {
            Write(LogLevel.Warning, Text,true);
        }

        public void WriteError(string Text)
        {
            Write(LogLevel.Error, Text,true);
        }
		public void WriteError(string Text,Exception ex)
		{
			Write(LogLevel.Error, Text+" : "+ex.Message+Environment.NewLine+ex.StackTrace, true);
		}
		public void WriteFatal(string Text)
        {
            Write(LogLevel.Fatal, Text,true);
        }

        #endregion

        #region --- Private methods -----------------------------------------------------------------------------------
        private void FirstCheckFileMaxSize()
        {
            // check file size
            if (File.Exists(FileName))
            {
                FileInfo fi = new FileInfo(FileName);
                currentSize = (int)fi.Length;
            }
        }
        private void CheckFileMaxSize()
        {
            if (currentSize > MaxFileSize)
            {
                currentSize = 0;
                if (MaxBackupFiles > 1)
                {
                    // delete the older one
                    try
                    {
                        File.Delete(FileName + "." + MaxBackupFiles.ToString());
                    }
                    catch { }

                    // cascade rename
                    for (int i = MaxBackupFiles - 1; i > 0; i--)
                    {

                        try
                        {
                            File.Move(FileName + "." + i.ToString(), FileName + "." + (i + 1).ToString());
                        }
                        catch { }
                    }
                    try
                    {
                        File.Move(FileName, FileName + ".1");
                    }
                    catch { }
                }
            }
            //// check file size
            //if (File.Exists(FileName))
            //{
            //    FileInfo fi = new FileInfo(FileName);
            //    if (fi.Length > MaxFileSize)
            //    {
            //        if (MaxBackupFiles > 1)
            //        {
            //            // delete the older one
            //            try
            //            {
            //                File.Delete(FileName + "." + MaxBackupFiles.ToString());
            //            }
            //            catch { }
                    
            //            // cascade rename
            //            for (int i = MaxBackupFiles - 1; i > 0; i--)
            //            {
                            
            //                try
            //                {
            //                    File.Move(FileName + "." + i.ToString(), FileName + "." + (i+1).ToString());
            //                }
            //                catch { }
            //            }
            //            try
            //            {
            //                File.Move(FileName, FileName + ".1");
            //            }
            //            catch { }
            //        }
            //    }
            //}
        }

        #endregion

    }
}