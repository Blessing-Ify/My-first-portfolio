using DemoClass.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DemoClass.Data
{
    public class Seeder
    {
        public Seeder()
        {
        }
        //we have to create a method that returns a list of project model stored in the json
        public static List<Project> SeedMe(IConfiguration config)
        {   //from nuget package, install newton json...
            //var data = File.ReadAllText("Data/ProjectData.json"); 
            var data = File.ReadAllText(config.GetSection("JsonFilePath:Path").Value);
            var project = JsonConvert.DeserializeObject<List<Project>>(data);

            return project;
        }
    }   
        //Deserialize helps convert an object of json to our language datatype because we want to read from it
    
}
