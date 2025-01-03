namespace Lumin.Domain.Manifest
{
    public class Config(string key, ConfigType type, string? defaultValue = null, string? title = null, string[]? options = null, bool? required = null)
    {
        public string Key { get; set; } = key;
        public ConfigType Type { get; set; } = type;
        public string? Default { get; set; } = defaultValue;
        public string? Title { get; set; } = title;
        public string[]? Options { get; set; } = options;
        public bool? Required { get; set; } = required;
    }

    public class ConfigType
    {
        private readonly string _value;
        private ConfigType(string value)
        {
            _value = value;
        }

        public static readonly ConfigType Text = new("text");
        public static readonly ConfigType Number = new("number");
        public static readonly ConfigType Password = new("password");
        public static readonly ConfigType Checkbox = new("checkbox");
        public static readonly ConfigType Select = new("select");

        public static implicit operator string(ConfigType type) => type._value;
    }

}
