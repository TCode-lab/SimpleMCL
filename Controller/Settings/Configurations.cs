namespace SimpleMCL.Controller.Settings
{
    public class Configurations
    {
        static public Configurations activeConf = new Configurations();

        // Versions search filters
        public bool ReleaseVerFilter    { get; set; }   =   true;
        public bool SnapshotsVerFilter  { get; set; }   =   false;
        public bool BetaVerFilter       { get; set; }   =   false;
        public bool AlphaVerFilter      { get; set; }   =   false;
    }
}
