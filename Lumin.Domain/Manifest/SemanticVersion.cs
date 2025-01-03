namespace Lumin.Domain.Manifest
{
    public class SemanticVersion(int major, int minor, int patch)
    {
        public int Major { get; set; } = major;
        public int Minor { get; set; } = minor;
        public int Patch { get; set; } = patch;

        public override string ToString()
        {
            return $"{Major}.{Minor}.{Patch}";
        }
    }
}
