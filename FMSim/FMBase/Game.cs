using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FMBase
{
    public class Game(string userName, string saveName)
    {
        public string UserName { get; set; } = userName;
        public string SaveName { get; set; } = saveName;
        public DateTime createdAt { get; set; } = DateTime.Now;

        public void Save()
        {
            Base.JsonDump(this, SaveName);
        }
    }
}
