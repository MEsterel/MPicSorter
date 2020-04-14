using MPicSorter.Forms;
using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace MPicSorter
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                // Load dlls
                AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                {
                    string resourceName = new AssemblyName(args.Name).Name + ".dll";
                    string resource = Array.Find(Assembly.GetExecutingAssembly().GetManifestResourceNames(), element => element.EndsWith(resourceName));

                    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                    {
                        Byte[] assemblyData = new Byte[stream.Length];
                        stream.Read(assemblyData, 0, assemblyData.Length);
                        return Assembly.Load(assemblyData);
                    }
                };

                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.language);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                RunExceptionMessageHandler(ex);
            }
        }

        private static void RunExceptionMessageHandler(Exception ex)
        {
            MExceptionReporter.ReportException reportException = new MExceptionReporter.ReportException(Application.ProductName, ex);
            reportException.ShowDialog();
            return;
        }
    }
}