using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RestSharp;

namespace YTR.Utils
{
    public static class RestUtil
    {
        public static async Task Test(string url)
        {
            RestClient restClient = new RestClient(url);
            RestRequest request = new RestRequest();

            var res = await restClient.ExecuteGetAsync(request);

            string content = res.Content;
            //content.IndexOf("SIGI_STATE") + 36
            //content = content[(content.IndexOf("SIGI_STATE") + 36)..];
            //content = content[..content.IndexOf("</script>")];
        }
    }
}
