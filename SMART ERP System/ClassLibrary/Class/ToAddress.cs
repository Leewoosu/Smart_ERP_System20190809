using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.Class
{
    public class ToAddress
    {
        //public string Type { get; set; }
        //public string Code { get; set; }
        //public string Name { get; set; }
        //public string FullName { get; set; }
        //public string RegionId { get; set; }
        //public string Name0 { get; set; }
        //public string Name1 { get; set; }
        //public string Name2 { get; set; }
        //public string Name3 { get; set; }
        //public string Code1 { get; set; }
        //public string Code2 { get; set; }
        //public string Code3 { get; set; }
        //public float X { get; set; }
        //public float Y { get; set; }

        //public ToAddress GetToAddress(string lng, string lat)
        //{
        //    WebResponse webResponse;
        //    StreamReader reader;
        //    ToAddress coordinate = null;

        //    using (var client = new HttpClient())
        //    {
        //        try
        //        {
        //            var serviceUrl = String.Format("https://apis.daum.net/local/geo/coord2addr?apikey={{PI_KEY}}&longitude={0}&latitude={1}&inputCoordSystem=WGS84&output=json", lng, lat);

        //            WebRequest request = WebRequest.Create(serviceUrl);
        //            request.Credentials = CredentialCache.DefaultCredentials;
        //            webResponse = request.GetResponse();

        //            MessageBox.Show(((HttpWebResponse)webResponse).StatusDescription);
        //            Stream dataStream = webResponse.GetResponseStream();
        //            reader = new StreamReader(dataStream);
        //            string responseFromServer = reader.ReadToEnd();

        //            coordinate = JsonConvert.DeserializeObject<ToAddress>(responseFromServer);
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show("in api 좌표 변환 실패 : " + lng + "|" + lat);
        //            MessageBox.Show(e.Message);
        //        }

        //        return coordinate;
        //    }
        //}
    }
}
