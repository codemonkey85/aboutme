using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace aboutme.Shared
{
    public static class SharedMethods
    {
        public static async Task<string> ReadPageContentFromMd(this HttpClient HttpClient, string fileName)
        {
            try
            {
                return await HttpClient.GetStringAsync($"page-content/{fileName}");
            }
            catch (Exception ex)
            {
                StringBuilder sbError = new StringBuilder();
                BuildErrorMessage(sbError, ex);
                return sbError.ToString();
            }
        }

        private static void BuildErrorMessage(StringBuilder sbError, Exception ex)
        {
            sbError.AppendLine($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
            if (ex.InnerException != null)
            {
                BuildErrorMessage(sbError, ex.InnerException);
            }
        }
    }
}
