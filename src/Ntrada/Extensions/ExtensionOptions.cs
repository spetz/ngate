namespace Ntrada.Extensions
{
    internal sealed class ExtensionOptions : IExtensionOptions
    {
        public int? Order { get; set; }
        public bool? Enabled { get; set; }
    }
}