using Lumin.Api.Contracts;
using Lumin.Domain.Manifest;
using Mapster;

namespace Lumin.Api.Mapping
{
    public class ManifestMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<Manifest, ManifestResponse>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Description, src => src.Description)
                .Map(dest => dest.Version, src => src.Version.ToString())
                .Map(dest => dest.Background, src => src.Background)
                .Map(dest => dest.Logo, src => src.Logo)
                .Map(dest => dest.ContactEmail, src => src.ContactEmail);

            config.ForType<Resource, ManifestResourceResponse>()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Types, src => src.Types.Select(t => (string)t).ToArray())
                .Map(dest => dest.IdPrefixes, src => src.IdPrefixes);

            config.ForType<Extra, ManifestCatalogExtraResponse>()
                .Map(dest => dest.Name, src => (string)src.Name)
                .Map(dest => dest.IsRequired, src => src.IsRequired)
                .Map(dest => dest.Options, src => src.Options)
                .Map(dest => dest.OptionsLimit, src => src.OptionsLimit);

            config.ForType<Catalog, ManifestCatalogResponse>()
                .Map(dest => dest.Type, src => src.Type)
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Name, src => src.Name);

            config.ForType<Config, ManifestConfigResponse>()
                .Map(dest => dest.Key, src => src.Key)
                .Map(dest => dest.Type, src => (string)src.Type)
                .Map(dest => dest.Default, src => src.Default)
                .Map(dest => dest.Title, src => src.Title)
                .Map(dest => dest.Options, src => src.Options)
                .Map(dest => dest.Required, src => src.Required);

            config.ForType<BehaviorHints, ManifestBehaviorHintsResponse>()
                .Map(dest => dest.Adult, src => src.Adult)
                .Map(dest => dest.P2p, src => src.P2p)
                .Map(dest => dest.Configurable, src => src.Configurable)
                .Map(dest => dest.ConfigurationRequired, src => src.ConfigurationRequired);

            config.ForType<ResourceName, string>()
                .MapWith(src => (string)src);

            config.ForType<ContentType, string>()
                .MapWith(src => (string)src);
        }
    }
}
