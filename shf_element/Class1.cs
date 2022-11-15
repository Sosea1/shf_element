using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace shf_element
{
    public class Class1
    {
        public void Trf()
        {
            var first_elem = new SHF_element
            {
                elpar = new Dictionary<string, ElPar>
                {
                    ["Name"] = new ElPar { elem_group = "Название элемента" },
                    ["Matrix"] = new ElPar
                    {
                        mat = new Dictionary<string, matrix>
                        {
                            ["first element"] = new matrix { mat_elem = "Формула" }
                        }
                    }
                }
            };
            string file_path = @"D:\projects VScode\shf_element\shf_element\test.json";
            string json_string = JsonSerializer.Serialize(first_elem);
            File.WriteAllText(file_path, json_string);


        }
        public class SHF_element
        {
            //   public string Name { get; set; }
            public Dictionary<string, ElPar> elpar { get; set; }

        }
        public class ElPar
        {
            public string elem_group { get; set; }
            public Dictionary<string, matrix> mat { get; set; }
        }
        public class matrix
        {
            public string mat_elem { get; set; }
        }
    }
}
