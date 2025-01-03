namespace Lumin.Domain.Manifest
{
    public class Manifest(string id, string name, string description, SemanticVersion version, Resource[] resources, Catalog[] catalogs, Config? config = null, Catalog[]? addonCatalogs = null, string? background = null, string? logo = null, string? contactEmail = null, BehaviorHints? behaviorHints = null)
    {
        public string Id { get; private set; } = id;
        public string Name { get; private set; } = name;
        public string Description { get; private set; } = description;
        public SemanticVersion Version { get; private set; } = version;
        public Resource[] Resources { get; set; } = resources;
        public Catalog[] Catalogs { get; set; } = catalogs;
        public Config? Config { get; set; } = config;
        public Catalog[]? AddonCatalogs { get; set; } = addonCatalogs;
        public string? Background { get; set; } = background;
        public string? Logo { get; set; } = logo;
        public string? ContactEmail { get; set; } = contactEmail;
        public BehaviorHints? BehaviorHints { get; set; } = behaviorHints;

    }

}
