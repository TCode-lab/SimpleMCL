using System.Text.Json;
using System.Text;

namespace SimpleMCL.Controller.Settings
{
    internal class ConfigurationsJson
    {
        private const string settingsFileName = "settings.json";

        static public void Read()
        {
            try
            {
                string jsonString = File.ReadAllText(settingsFileName);
                Configurations conf = JsonSerializer.Deserialize<Configurations>(jsonString)!;

                if (conf != null)
                {
                    Configurations.activeConf = conf;
                }
                else
                {
                    throw new Exception($"Ошибка загрузки сборок");
                }
            }
            catch (FileNotFoundException)
            {
                // Нужно просто создать файл
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Файл настроек поврежден и не может быть загружен.\nОшибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла настроек.\nОшибка: {ex.Message}");
            }
        }

        static public void Write(Configurations settings)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(settings);
                StringBuilder sb = new StringBuilder();
                File.WriteAllText(settingsFileName, jsonString);
            }
            catch
            {
                MessageBox.Show("Ошибка записи настроек.");
            }
        }
    }
}
