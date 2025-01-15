using CmlLib.Core;
using CmlLib.Core.Version;
using CmlLib.Core.VersionLoader;
using CmlLib.Core.VersionMetadata;
using System.Collections;

namespace SimpleMCL.Controller.Versions
{
    internal class VersionsController
    {
        static private MojangJsonVersionLoaderV2? loader;

        static private VersionMetadataCollection versions = new VersionMetadataCollection();

        static public void Initialize()
        {
            var path = new MinecraftPath()
            {
                Versions = "local_versions"
            };
            var parameters = MinecraftLauncherParameters.CreateDefault(path);
            loader = new MojangJsonVersionLoaderV2(path, parameters.HttpClient);
        }

        static public async Task<bool> UpdateVersionsMeta()
        {
            loader.UseLocalManifestWhenError = true;
            versions = await loader.GetVersionMetadatasAsync();
            return true;
        }



        static public IEnumerable<IVersionMetadata> GetAllVersionsMeta(
              bool release = true
            , bool snapshot = true
            , bool beta = true
            , bool alpha = true
            )
        {
            IEnumerable<IVersionMetadata> result = new VersionMetadataCollection();
            result = versions.Where(ver => 
               (release  && ver.Type == "release")
            || (snapshot && ver.Type == "snapshot")
            || (beta     && ver.Type == "old_beta")
            || (alpha    && ver.Type == "old_alpha")
            );

            return result;
        }

    }
}
