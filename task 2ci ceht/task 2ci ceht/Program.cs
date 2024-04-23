using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace task_2ci_ceht
{
    internal class Program
    {
        static void Main(string[] args)
        {




            // Add("sa");
            Console.WriteLine(Search("sa"));
           
        }
        public static void Add(string name )
        {
            List<string> strings = Deserialize(@"C:\Users\Emil\Desktop\code academy task\task 20\task 2ci ceht\task 2ci ceht\Files\names.json");
            strings.Add(name);
            Serialize(@"C:\Users\Emil\Desktop\code academy task\task 20\task 2ci ceht\task 2ci ceht\Files\names.json", strings);
        }
        
        public static bool Search( string name)
        {
            List<string> strings = Deserialize(@"C:\Users\Emil\Desktop\code academy task\task 20\task 2ci ceht\task 2ci ceht\Files\names.json");
            return  strings.Contains(name);
        }


        public static void Delete(string name)
        {
            List<string> strings = Deserialize(@"C:\Users\Emil\Desktop\code academy task\task 20\task 2ci ceht\task 2ci ceht\Files\names.json");
            strings.Remove(name);
            Serialize(@"C:\Users\Emil\Desktop\code academy task\task 20\task 2ci ceht\task 2ci ceht\Files\names.json", strings);
        }


        public static List<string> Deserialize(string FullPath)
        {
            string result;
            using (StreamReader sr = new StreamReader(FullPath))
            {
                result = sr.ReadToEnd();
            }
            
            List<string> strings = JsonConvert.DeserializeObject<List<string>>(result);
            return strings;
        }

        public static void Serialize<T>(string FullPath,T obj )
        {
            string result = JsonConvert.SerializeObject(obj);
            using (StreamWriter sw = new StreamWriter(FullPath))
            { sw.WriteLine(result); }
             
            
        }

    }
}
