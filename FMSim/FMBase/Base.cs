using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMBase.Hoomans;
using FMInterface;

using System.Text.Json;

namespace FMBase
{
    class Base
    {
        string userName;
        string saveName;
        DateTime createdAt;

        async void jsonDump()
        {
            await using FileStream createStream = File.Create(saveName + ".json");
            await JsonSerializer.SerializeAsync(createStream, this);
        }

        public void Main(string[] args)
        {
            Base cos = new Base();
            cos.userName = "mish";
            cos.saveName = "test";
            cos.createdAt = DateTime.Now;

            cos.jsonDump();
        }
    }
}
