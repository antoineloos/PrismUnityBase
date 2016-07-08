using System.ComponentModel.Composition;

namespace Infrastructure.Core
{
    [Export]
    public static class RegionNames
    {
        public const string MainContentRegion = "MainContentRegion";
        public const string LoginRegion = "LoginRegion";
        public const string AccueilRegion = "AccueilRegion";
        public const string ProfilRegion = "ProfilRegion";
    }
}
