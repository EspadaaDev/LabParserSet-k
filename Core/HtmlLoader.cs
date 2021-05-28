using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using AngleSharp.Html.Parser;
using AngleSharp.Html.Dom;
using System.Windows.Forms;
using System.Threading;

namespace LabParserSet_k.Core
{
    class HtmlLoader
    {
        //Предназначение этого класса загружать код HTML страницы из указанных настроек парсера.

        HttpClient client; //для отправки HTTP запросов и получения HTTP ответов.        
        private HtmlParser domParser;

        public HtmlLoader() {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.128 Safari/537.36"); //Это для идентификации на сайте-жертве.       
            domParser = new HtmlParser();
        }

        // Получаем HTML код с указанной страницы
        public async Task<IHtmlDocument> GetSourceByPage(string url) {
            string source;
            IHtmlDocument document = default;

            try {
                HttpResponseMessage responce = await client.GetAsync(url); //Получаем ответ с сайта.            

                if (responce != null && responce.StatusCode == HttpStatusCode.OK) {
                    source = await responce.Content.ReadAsStringAsync(); //Помещаем код страницы в переменную.
                    document = await domParser.ParseDocumentAsync(source);
                }
                
                return document;
            }
            catch (System.InvalidOperationException e) {
                MessageBox.Show("Ошибка чтения: " + e.Message);
                return document;
            }
        }
    }
}
