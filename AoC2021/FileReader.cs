using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021
{
    public class FileReader
    {
        StreamReader stream;
        List<string> list;

        public FileReader()
        {
            list = new List<string>();
        }

        public void read(string path)
        {
            stream = new StreamReader(path);
        }
        
        public List<string> getList()
        {
            while (stream.Peek() != -1)
                list.Add(stream.ReadLine());
            return list;
        }                    
    }
}
