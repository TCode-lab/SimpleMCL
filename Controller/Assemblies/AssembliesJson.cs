using SimpleMCL.Model;
using System.Text;
using System.Text.Json;

namespace SimpleMCL.Controller.Assemblies
{
    internal class AssembliesJson
    {
        private class AssembliesRoot
        {
            public List<Assembly>? Assemblies { get; set; }
        }

        private const string assembliesFileName = "assemblies.json";

        static public void WriteAllAssemblies(ref List<Assembly> assemblies)
        {
            try
            {
                AssembliesRoot root = new AssembliesRoot();
                root.Assemblies = assemblies;

                string jsonString = JsonSerializer.Serialize(assemblies);
                StringBuilder sb = new StringBuilder();
                //
                // Дай бог блять не забыть это исправить. Мне просто впадлу ебаться сейчас с этим
                sb.Append("{\""); sb.Append(nameof(AssembliesRoot.Assemblies)); sb.Append("\":"); sb.Append(jsonString); sb.Append("}");
                //
                File.WriteAllText(assembliesFileName, sb.ToString());
            }
            catch
            {
                MessageBox.Show("Ошибка записи созданных ранее сборок.");
            }
        }

        static public void ReadAllAssemblies(ref List<Assembly> assemblies)
        {
            try
            {
                string jsonString = File.ReadAllText(assembliesFileName);
                AssembliesRoot assembliesRoot = JsonSerializer.Deserialize<AssembliesRoot>(jsonString)!;

                if (assembliesRoot != null && assembliesRoot.Assemblies != null)
                {
                    assemblies.Clear();
                    assemblies = assembliesRoot.Assemblies;
                    for (int i = 0; i < assemblies.Count; i++)
                    {
                        assemblies[i].Index = i;
                    }
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
                MessageBox.Show($"Данные созданных ранее сборок повреждены и не могут быть загружены.\nОшибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки созданных ранее сборок.\nОшибка: {ex.Message}");
            }
        }
    }
}
