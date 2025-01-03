namespace Lumin.Domain.Manifest
{
    public class ContentType
    {
        private readonly string _value;

        private ContentType(string value)
        {
            _value = value;
        }

        public static readonly ContentType Movie = new("movie");
        public static readonly ContentType Series = new("series");
        public static readonly ContentType Channel = new("channel");
        public static readonly ContentType TV = new("tv");

        public static implicit operator string(ContentType contentType) => contentType._value;
    }
}
