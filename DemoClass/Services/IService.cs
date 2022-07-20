using DemoClass.Models;
using System.Collections.Generic;

namespace DemoClass.Services
{
    //we need a service to define the operations carried out in the json file,
    //so that we can use this service class as the name and be injecting it directly to any class that we need the list of projects
    public interface IService
    {
        //interface doesn't implement hence no setter and more also, i don't want anyone to set my project
        public List<Project> MyProjects { get; }

    }
}
     