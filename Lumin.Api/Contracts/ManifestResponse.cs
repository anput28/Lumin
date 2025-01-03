namespace Lumin.Api.Contracts
{
    public record ManifestResponse(
        string Id,
        string Name,
        string Description,
        string Version,
        ManifestResourceResponse[] Resources,
        ManifestCatalogResponse[] Catalogs,
        ManifestConfigResponse? Config,
        ManifestCatalogResponse[]? AddonCatalogs,
        string? Background,
        string? Logo,
        string? ContactEmail,
        ManifestBehaviorHintsResponse? BehaviorHints);

    public record ManifestResourceResponse(string Name, string[] Types, string[]? IdPrefixes);

    public record ManifestCatalogResponse(string Type, string Id, string Name, ManifestCatalogExtraResponse[] Extras);

    public record ManifestCatalogExtraResponse(string Name, bool? IsRequired, string[]? Options, int? OptionsLimit);

    public record ManifestConfigResponse(string Key, string Type, string? Default, string? Title, string[]? Options, bool? Required);

    public record ManifestBehaviorHintsResponse(bool? Adult, bool? P2p, bool? Configurable, bool? ConfigurationRequired);
}
