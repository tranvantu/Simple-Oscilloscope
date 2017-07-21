using System;
using System.Windows.Forms;
using System.Reflection;
namespace Scope
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }

        static void Main()
        {
            EmbeddedAssembly.Load("Scope.MetroFramework.dll", "MetroFramework.dll");
            EmbeddedAssembly.Load("Scope.MetroFramework.Design.dll", "MetroFramework.Design.dll");
            EmbeddedAssembly.Load("Scope.MetroFramework.Fonts.dll", "MetroFramework.Fonts.dll");
            EmbeddedAssembly.Load("Scope.OxyPlot.dll", "OxyPlot.dll");
            EmbeddedAssembly.Load("Scope.OxyPlot.WindowsForms.dll", "OxyPlot.WindowsForms.dll");
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        
    }
}
