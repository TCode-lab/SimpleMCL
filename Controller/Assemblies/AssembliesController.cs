using SimpleMCL.Model;

namespace SimpleMCL.Controller.Assemblies
{
    internal class AssembliesController
    {
        static private List<Assembly> assemblies = new List<Assembly>();
        static public int AssembliesCount { get => assemblies.Count; }

        static public void Read()
        {
            AssembliesJson.ReadAllAssemblies(ref assemblies);
        }

        static public void Write()
        {
            AssembliesJson.WriteAllAssemblies(ref assemblies);
        }

        static public void CreateAssembly(string name, string version)
        {
            assemblies.Add(new Assembly()
            {
                Index = assemblies.Count,
                Name = name,
                Version = version,
                Memory = 2048
            });
        }

        static public void EditAssemblyWithIndex(int index, Assembly newAssemblySettings)
        {
            if (assemblies.Count > 0 && index >= 0 && index < assemblies.Count)
            {
                var oldAssembly = assemblies[index];
                newAssemblySettings.Index = oldAssembly.Index;
                assemblies[index] = newAssemblySettings;
            }
        }

        static public void DeleteAssemblyByName(string name)
        {
            var assembly = assemblies.First(ass => ass.Name == name);
            try
            {
                if (assembly != null)
                {
                    string assemblyPath = $"assemblies/{assembly.Name}";
                    Directory.Delete(assemblyPath, true);
                    assemblies.Remove(assembly);
                }
                else
                {
                    throw new Exception("Not found assembly.");
                }
            }
            catch (DirectoryNotFoundException)
            {
                assemblies.Remove(assembly);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Попытка удаления сборки была провалена.\nОшибка:\n{ex.Message}");
            }
            
        }

        static public Assembly? GetAssemblyByIndex(int index)
        {
            if (assemblies.Count > 0 && index >= 0 && index < assemblies.Count)
            {
                return assemblies[index];
            }
            return null;
        }

        static public List<Assembly> GetAllAssemblies()
        {
            return assemblies;
        }
    }
}
