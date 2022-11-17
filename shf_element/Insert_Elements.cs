using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace shf_element
{
    internal class Insert_Elements
    {
        public string group { get; set; }
        public string name { get; set; }
        public string[] matrix { get; set; }
        public string[] parameters { get; set; }
        public Dictionary<string, string> other_par { get; set; }

        //public Dictionary<string, ElPar> elpar { get; set; }


        public void Trf()
        {
            var options = new JsonSerializerOptions()
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            string file_path = @"C:\Users\user\source\repos\shf_element\shf_element\test.json";
            var jsonData = File.ReadAllText(file_path);
           // List<Insert_Elements> elementsList = JsonSerializer.Deserialize<List<Insert_Elements>>(jsonData,options);

            var elementsList = JsonSerializer.Deserialize<List<Insert_Elements>>(jsonData) ?? new List<Insert_Elements>();

            elementsList.Add(new Insert_Elements()
            {
                        group = "smth",
                        name = "smth",
                        matrix = new[] {"A/B","B/c","C/a"},
                        parameters = new[] {"A","B","C"},
                        other_par = new Dictionary<string,string>()
                        {
                            ["Z"] = "C-A",
                            ["Z1"] = "B-A",
                 
                }
            });;

            jsonData = JsonSerializer.Serialize(elementsList, options);
            File.WriteAllText(file_path, jsonData);


        }
    }

        public class Two_Pole
        {
           
        }

        public class QuadeiPole
        {
            public string name { get; set; }
            public string[] matrix { get; set; }
            public string[] parameters { get; set; }
            public Dictionary<string, string> other_par { get; set; }
        }

        public class Eight_Pole
        {
            public string name { get; set; }
            public string[] matrix { get; set; }
            public string[] parameters { get; set; }
            public Dictionary<string, string> other_par { get; set; }
        }


}
