using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;
using SimpleMCL.Model;
using System.Diagnostics;

namespace SimpleMCL.Controller
{
    public enum LauncherStatus
    {
        waiting,
        loading,
        inGame
    }

    internal class LauncherController
    {
        // UI
        static public ToolStripProgressBar? progressBar;
        static public ToolStripStatusLabel? statusLabel;
        // Status
        static public LauncherStatus Status { get => status; }
        static private LauncherStatus status = LauncherStatus.waiting;
        // Events
        static public event Action<bool> LockAssemblyControlAction;
        //
        static private Process? activeProcess = null;

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
            SetStatus(LauncherStatus.loading);
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
                activeProcess = await launcher.BuildProcessAsync(assembly.Version, new MLaunchOption
                {
                    Session = MSession.CreateOfflineSession("Steve"),
                    MaximumRamMb = Convert.ToInt32(assembly.Memory)
                });

                activeProcess.EnableRaisingEvents = true;
                activeProcess.Exited += OnEndProcess;

                if (activeProcess.Start()) { OnStartProcess(); }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"При запуске данной сборки произошла ошибка.\nОшибка:\n{ex.Message}");
            }
        }

        private static void OnStartProcess()
        {
            SetStatus(LauncherStatus.inGame);
        }

        static private void OnEndProcess(object? sender, EventArgs e)
        {
            SetStatus(LauncherStatus.waiting);
            activeProcess = null;
        }

        static public void CloseProcess()
        {
            if (activeProcess == null) { return; }

            activeProcess.Kill();
            activeProcess = null;
        } 

        static public void SetStatus(LauncherStatus new_status)
        {
            if (progressBar == null || statusLabel == null) { return; }
            status = new_status;

            switch (status)
            {
                case LauncherStatus.waiting:
                    progressBar.Value = 0;
                    statusLabel.Text = "Ожидание";
                    LockAssemblyControlAction?.Invoke(false);
                    break;
                case LauncherStatus.loading:
                    progressBar.Value = 0;
                    statusLabel.Text = "Загрузка";
                    LockAssemblyControlAction?.Invoke(true);
                    break;
                case LauncherStatus.inGame:
                    progressBar.Value = 100;
                    statusLabel.Text = "В игре";
                    LockAssemblyControlAction?.Invoke(true);
                    break;
            }
        }
    }
}
