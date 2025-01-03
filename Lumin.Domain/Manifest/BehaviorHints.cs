namespace Lumin.Domain.Manifest
{
    public class BehaviorHints(bool? adult = null, bool? p2p = null, bool? configurable = null, bool? configurationRequired = null)
    {
        public bool? Adult { get; set; } = adult;
        public bool? P2p { get; set; } = p2p;
        public bool? Configurable { get; set; } = configurable;
        public bool? ConfigurationRequired { get; set; } = configurationRequired;

    }
}
