using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using MyMvcApp.Models;
using StoreManage.Models;

namespace StoreManage.Services
{
    public class JsonFileReaderService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public JsonFileReaderService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<Account> GetAccounts()
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "data", "sampleData.json");
            using var jsonFileReader = File.OpenText(filePath);
            var accounts = JsonSerializer.Deserialize<JsonFileModel>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            return accounts.Accounts;
        }
        public IEnumerable<Store> GetStores()
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "data", "sampleData.json");
            using var jsonFileReader = File.OpenText(filePath);
            var jsonData = JsonSerializer.Deserialize<JsonFileModel>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            return jsonData.Stores;
        }
    }
    public class JsonFileModel
    {
        public IEnumerable<Account> Accounts { get; set; }
        public IEnumerable<Store> Stores { get; set; }
    }
}
