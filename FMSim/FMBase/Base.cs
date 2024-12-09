using System.Text.Json;

namespace FMBase
{
    public class Base
    {
        static void Main (string[] args){

            
        }
        async static public void JsonDump(Object obj, string name)
        {
            await using FileStream createStream = File.Create(name + ".json");
            await JsonSerializer.SerializeAsync(createStream, obj);
        }
    }
}
