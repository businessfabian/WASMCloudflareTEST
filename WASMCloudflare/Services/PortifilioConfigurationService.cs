using WASMCloudflare.Models;
using System.Threading.Tasks;
namespace WASMCloudflare.Services
{
    public class PortifilioConfigurationService
    {
       
        public async Task<FooterModel> GetFooter()
        {
            SocialLinks sl = new SocialLinks()
            {
                FaceBookLink = "test",
                TwitterLink = "test",
                GitHub = "test",
                LinkedInLink = "test"
            };

            FooterModel result = new FooterModel()
            {
                About = "test",
                Message = "test",
                SocialLinks = sl

            };
            await Task.CompletedTask;
            return result;
        }
    }
}
