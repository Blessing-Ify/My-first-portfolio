using DemoClass.Data;
using DemoClass.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;


namespace DemoClass.Services
{
    public class Service : IService
    {
        public List<Project> MyProjects { get; private set; }

        private readonly IConfiguration _config;
        public Service(IConfiguration config)
        {// here we call the seedme method from the seeder class so as to get what its returning here
            MyProjects = Seeder.SeedMe(config);

            _config = config;
        }
    }
}

//next we register the Iservice and service class so that it could be recognized in the program