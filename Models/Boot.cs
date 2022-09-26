using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloworld_dotnet.Models
{
    public class Boot
    {
        public string? Label { get; set; }
        public string? Model { get; set; }
        public int? Size { get; set; }

        public void ShowBoot () {
            Console.WriteLine($"This is a {Label} {Model}, number {Size}");
        }
    }
}