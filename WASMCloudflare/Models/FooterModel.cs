namespace WASMCloudflare.Models
{
    public class FooterModel
    {
        public AdressModel Address { get; set; } = new AdressModel();
        public SocialLinks SocialLinks { get; set; } = new SocialLinks();

        public string About { get; set; }
        public string Message { get; set; }
    }
}
