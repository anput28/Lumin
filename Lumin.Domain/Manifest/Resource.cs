namespace Lumin.Domain.Manifest
{
    public class Resource(ResourceName name, ContentType[] types, string[]? idPrefixes = null)
    {
        public ResourceName Name { get; set; } = name;
        public ContentType[] Types { get; set; } = types;
        public string[]? IdPrefixes { get; set; } = idPrefixes;
    }


    public class ResourceName
    {
        private readonly string _value;

        private ResourceName(string value)
        {
            _value = value;
        }

        public static readonly ResourceName Catalog = new("catalog");
        public static readonly ResourceName Meta = new("meta");
        public static readonly ResourceName Stream = new("stream");
        public static readonly ResourceName Subtitles = new("subtitles");
        public static readonly ResourceName AddonCatalog = new("addon_catalog");

        public static implicit operator string(ResourceName resourceName) => resourceName._value;
    }
}
