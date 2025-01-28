using SimpleMCL.Controller;
using SimpleMCL.Controller.Assemblies;
using SimpleMCL.Controller.Settings;
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
            ConfigurationsJson.Read();

            VersionsController.Initialize();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            LauncherController.SetStatus(LauncherStatus.waiting);
        }
    }
}