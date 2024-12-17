using System.Reflection.PortableExecutable;
using System.Text.Json;

namespace FMBase
{
    public class Base
    {
        static public string GetProjectDir()
        {
            return Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\";
        }

        static public void JsonDump(Object obj, string savename)
        {
            if (!Directory.Exists(GetProjectDir() + "Saves\\"))
            {
                Directory.CreateDirectory(GetProjectDir() + "Saves\\");
            }
            File.WriteAllText(GetProjectDir() + "Saves\\" + savename + ".json", JsonSerializer.Serialize(obj));

        }

        static public Object? JsonLoad(string savename)
        {
            return JsonSerializer.Deserialize<Object>(File.ReadAllText(GetProjectDir() + "Saves\\" + savename + ".json"));
        }
    }
}
