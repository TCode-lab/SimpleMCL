using SimpleMCL.Controller;
using SimpleMCL.Controller.Assemblies;
using SimpleMCL.Controller.Versions;
using System.Runtime.InteropServices;

namespace SimpleMCL
{
    internal static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)] static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
#if DEBUG
            AllocConsole();
#endif

            VersionsController.Initialize();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}