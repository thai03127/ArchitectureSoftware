using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
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
        public IEnumerable<Store> Stores { get; set; }
    }
}
