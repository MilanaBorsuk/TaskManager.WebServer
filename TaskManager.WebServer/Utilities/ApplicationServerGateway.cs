using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TaskManager.WebServer.Utilities
{
    public class ApplicationServerGateway
    {
       

        public T GetTask<T>(string path)
        {
            try
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(path);
                webRequest.Method = "GET";
                webRequest.KeepAlive = true;
                webRequest.ContentType = "application/x-www-form-urlencoded";
         

                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                using (var stream = webResponse.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var result = (T)serializer.Deserialize(reader, typeof(T));

                    return result;
                }
            }
            catch(Exception exception)
            {

            }

            return default(T);
        }

        public IList<T> GetTasks<T>(string path)
        {
            try
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(path);
                webRequest.Method = "GET";
                webRequest.KeepAlive = true;
                webRequest.ContentType = "application/x-www-form-urlencoded";


                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                using (var stream = webResponse.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var result = (List<T>)serializer.Deserialize(reader, typeof(List<T>));

                    return result;
                }
            }
            catch (Exception exception)
            {

            }

            return null;
        }
    }
}