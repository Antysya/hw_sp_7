using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace hw_sp_7
{
    class Country
    {
        public Dictionary<string, string> Country_City;
        public Country()
        {
            Country_City = new Dictionary<string, string>();
        }

        public void TransCity(string country)
        {
            string key;
            if (Country_City.TryGetValue(country, out key))
            {
                WriteLine(key);
            }
            else
            {
                WriteLine("Ключ не существует");
            }
        }


        public void TransCountry(string city)
        {
            foreach (KeyValuePair<string, string> kvp in Country_City)
            {
                if (kvp.Value == city)
                WriteLine(kvp.Key);
            }
        }
        
        public void PrintDictionary()
        {
            WriteLine();
            foreach (KeyValuePair<string, string> kvp in Country_City)
            {
                WriteLine("{0, 16} - {1}", kvp.Key, kvp.Value);
            }
            WriteLine();
        }
    }

}

