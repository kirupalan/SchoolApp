using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDSchoolApp
{
    internal static class FileManager
    {
        public static void WriteToFile(Teacher tchr, FileStream fs)
        {
            
            var data = tchr.Id.ToString() + "|" + tchr.Name + "|" + tchr.ClassName + "|" + tchr.Section + "\r\n";
            byte[] info = new UTF8Encoding(true).GetBytes(data);
            fs.Write(info, 0, info.Length);
        }

        public static void ReadFromFile(FileStream fs)
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }

    }
}
