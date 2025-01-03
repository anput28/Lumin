using Lumin.Core.Interfaces;
using Lumin.Domain.Manifest;

namespace Lumin.Core.Services
{
    public class ManifestService : IManifestService
    {
        public Manifest GetManifest()
        {
            return new Manifest(
                "it.stremio.lumin",
                "Lumin",
                "Lumin is a Stremio add-on that provides a curated selection of movies and series.",
                new SemanticVersion(0, 0, 1),
                [new Resource(ResourceName.Catalog, [ContentType.Movie, ContentType.Series])],
                [new(ContentType.Movie, "top", "Top Movies")]
            );
        }
    }
}
