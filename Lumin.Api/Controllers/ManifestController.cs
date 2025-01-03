using Lumin.Api.Contracts;
using Lumin.Core.Interfaces;
using Lumin.Domain.Manifest;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace Lumin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManifestController(IManifestService manifestService, IMapper mapper) : ControllerBase
    {
        private readonly IMapper _mapper = mapper;
        private readonly IManifestService _manifestService = manifestService;

        [HttpGet("manifest.json")]
        public IActionResult GetManifest()
        {
            Manifest manifest = _manifestService.GetManifest();

            ManifestResponse manifestResponse = _mapper.Map<ManifestResponse>(manifest);
            return Ok(manifestResponse);
        }
    }
}
