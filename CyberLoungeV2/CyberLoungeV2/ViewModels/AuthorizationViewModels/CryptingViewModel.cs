using System.Security.Cryptography;
using System.Text;

namespace CyberLoungeV2.ViewModels.AuthorizationViewModels
{
    public class CryptingViewModel
    {
        string res;
        public CryptingViewModel()
        {

        }

        //шифруем пароль используя SHA256
        public string CryptingPass( string pass)
        {
            var sha256 = SHA256.Create();

            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));

            var strBuild = new StringBuilder();
            for(int i = 0; i < bytes.Length; i++)
            {
                strBuild.Append(bytes[i].ToString("x2"));
                res = strBuild.ToString();
            }
            return res;
        }
    }
}
