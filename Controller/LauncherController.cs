using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;
using SimpleMCL.Model;

namespace SimpleMCL.Controller
{
    internal class LauncherController
    {
        static public ToolStripProgressBar? progressBar;

        private static void updateProgressBar(object? sender, ByteProgress e)
        {
            int percentage = Convert.ToInt32(Math.Round(e.ToRatio() * 100));
            Console.Write("   total: " + e.TotalBytes);
            Console.Write("  progressed: " + e.ProgressedBytes);
            Console.Write("  percentage: " + percentage + "%\n");
            if (progressBar != null) { progressBar.Value = percentage; }
        }

        static public async Task InstallAssembly(Assembly assembly)
        {
            var path = new MinecraftPath($"assemblies/{assembly.Name}");
            var launcher = new MinecraftLauncher(path);
            launcher.ByteProgressChanged += updateProgressBar;
            Console.WriteLine($"Start loading and install assembly \"{assembly.Name} {assembly.Version}\" process...");
            try
            {
                await launcher.InstallAsync(assembly.Version);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"В процессе установки выбранной версии майнкрафт произошла ошибка.\nОшибка:\n{ex.Message}");
            }
        }


        static public async Task BuildAndStartAssembly(Assembly assembly)
        {
            var path = new MinecraftPath($"assemblies/{assembly.Name}");
            var launcher = new MinecraftLauncher(path);
            Console.WriteLine($"Start building assembly \"{assembly.Name} {assembly.Version}\" process...");
            try
            {
                var process = await launcher.BuildProcessAsync(assembly.Version, new MLaunchOption
                {
                    Session = MSession.CreateOfflineSession("Steve"),
                    MaximumRamMb = Convert.ToInt32(assembly.Memory)
                });

                process.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"При запуске данной сборки произошла ошибка.\nОшибка:\n{ex.Message}");
            }
        }
    }
}
