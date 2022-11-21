using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace shf_element
{
    internal class Insert_Elements
    {
        public string group { get; set; }
        public string name { get; set; }
        public string[] parameters { get; set; }
        public Dictionary<string, string> other_par { get; set; }
        public string[] matrix { get; set; }


        public void AddNewElement(string group, string name, string[] parameters, Dictionary<string,string> values, string[] matrix)
        {
            var options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            string file_path = @"C:\Users\user\source\repos\shf_element\shf_element\test.json";
            var jsonData = File.ReadAllText(file_path);
            var elementsList = JsonSerializer.Deserialize<List<Insert_Elements>>(jsonData) ?? new List<Insert_Elements>();

            elementsList.Add(new Insert_Elements()
            {
                        group = group,
                        name = name,
                        parameters = parameters,
                        other_par = values,
                        matrix = matrix
            });;

            jsonData = JsonSerializer.Serialize(elementsList, options);
            File.WriteAllText(file_path, jsonData);


        }
    }

    /*other_par = new Dictionary<string, string>()
                        {
                            ["Z"] = "C-A",
                            ["Z1"] = "B-A",
                 
                        }
    */
}
