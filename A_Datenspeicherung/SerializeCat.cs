using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace A_Datenspeicherung
{
    public class SerializeCat
    {
        static void Main(string[] args)
        {
            string basepath = @"C:\Users\r1min\OneDrive\school\Module\M226B\Code\Main\A_Datenspeicherung";
            
            Cat cat = new Cat();
            cat.name = "Peter";
            cat.Color = "black";

            // write as bin
            FileStream fs = new FileStream(@"C:\Users\r1min\OneDrive\school\Module\M226B\Code\Main\A_Datenspeicherung\cat.xyz", FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, cat);

            //read as bin
            fs.Position = 0;
            Cat newCat = (Cat)formatter.Deserialize(fs);
            Console.WriteLine(newCat.Color);
            fs.Close();

            //JSON USES NEWTONSOFT JSON LIBRARY
            
            //write as JSON
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(@"C:\Users\r1min\OneDrive\school\Module\M226B\Code\Main\A_Datenspeicherung\cat.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, cat);
            }
            
            //read as JSON
            Cat newerCat = JsonConvert.DeserializeObject<Cat>(
                    File.ReadAllText(@"C:\Users\r1min\OneDrive\school\Module\M226B\Code\Main\A_Datenspeicherung\cat.json")
                );
            Console.WriteLine(newCat.name);
        }
    }
}