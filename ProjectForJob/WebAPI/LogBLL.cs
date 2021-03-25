using System;
using System.Collections.Generic;
using System.Text;
using LogLibrary;
using System.Data;
using System.Threading.Tasks;
using System.Net.Http;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace WebAPI
{
    public class LogBLL
    {
        private LogDal logDAL;


        public LogBLL()
        {
            logDAL = new LogDal();
            
        }

        public async Task<string> Get(string tableName)
        {
            //Endpointten verileri çeken get fonksiyonu
            string appp = "api/"+tableName;
            var client = new HttpClient();            
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            HttpResponseMessage response = await client.GetAsync(appp);
            string result = await response.Content.ReadAsStringAsync();
            AddNewItem("Get metodu :"+" Tablo : "+ tableName, DateTime.Now.ToString());
            return  result;
        }
        public async Task<string> Get(string tableName, object Id)
        {
            //Endpointten verileri id'ye göre çeken get fonksiyonu
            string appp = "api/" + tableName+"/"+Id;
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            HttpResponseMessage response = await client.GetAsync(appp);
            var result = await response.Content.ReadAsStringAsync();
            AddNewItem("Get metodu :  "+"tablo: "+  tableName+" ID : "+ Id, DateTime.Now.ToString());

            return result;
        }

        public async Task<string> Delete(string tableName, object Id)
        {
            //Seçilen endpointten id'ye göre veri silen fonksiyon
            var client = new HttpClient();
            string appp = "api/" + tableName + "/" + Id;
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            HttpResponseMessage response = await client.DeleteAsync(appp);
            string result = await response.Content.ReadAsStringAsync();
            var x = response.IsSuccessStatusCode;
            AddNewItem("Delete metodu  " +"sonuc : "+response.StatusCode.ToString()+" Tablo : " + tableName + " ID: " + Id, DateTime.Now.ToString());
            if (x) 
            { 
                return response.StatusCode.ToString();
            }
            else
            {
                return response.StatusCode.ToString();
            }            
        }

        public async Task<string> Post(string tableName, string companyName1, string phone1)
        {
            //Endpoint'e veri ekleyen fonksiyon.
            //Tam olarak istendiği gibi çalışmayabilir lütfen projedeki readme dosyasına bakınız.
            shippers values = new shippers { companyName = "company", phone = "0555 55235841" };
            
            var json = JsonConvert.SerializeObject(values, Formatting.Indented);

            var stringContent = new StringContent(json);
                       

            var client = new HttpClient();
            string appp = "api/" + tableName;
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("App1/Form1"));
            //HttpResponseMessage response = await client.PostAsync(appp, stringContent);
            HttpResponseMessage response = new HttpResponseMessage();
            
            response = await client.PostAsync(appp, stringContent).ConfigureAwait(false);

            string result = await response.Content.ReadAsStringAsync();

            AddNewItem("Post metodu  "+"sonuc : " + response.StatusCode.ToString() +" Tablo : "+ tableName, DateTime.Now.ToString());
            return response.StatusCode.ToString();
        }


        public DataTable GetAllItems()
        {
            //log kayıtlarını veri tabanından çeken fonksiyon
            return logDAL.GetAllItems();
        }

        public void AddNewItem(string process, object dateTime)
        {
            //log kayıtlarını veritabanına ekleyen fonksiyon
            logDAL.AddNewItem(process, dateTime);
        }
    }
}
