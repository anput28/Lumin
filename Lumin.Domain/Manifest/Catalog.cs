namespace Lumin.Domain.Manifest
{
    public class Catalog(ContentType type, string id, string name, Extra[]? extra = null)
    {
        public ContentType Type { get; set; } = type;
        public string Id { get; set; } = id;
        public string Name { get; set; } = name;
        public Extra[]? Extra { get; set; } = extra;
    }

    public class Extra(ExtraName name, bool? isRequired = null, string[]? options = null, int? optionsLimit = null)
    {
        public ExtraName Name { get; set; } = name;
        public bool? IsRequired { get; set; } = isRequired;
        public string[]? Options { get; set; } = options;
        public int? OptionsLimit { get; set; } = optionsLimit;
    }

    public class ExtraName
    {
        private readonly string _value;

        private ExtraName(string value)
        {
            _value = value;
        }

        public static readonly ExtraName Search = new("search");
        public static readonly ExtraName Genre = new("genre");
        public static readonly ExtraName Skip = new("skip");

        public static implicit operator string(ExtraName name) => name._value;
    }
}
