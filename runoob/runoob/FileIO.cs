using System;
using System.IO;

namespace runoob
{
    class FileIO
    {
        public static void TestStreamIO()
        {
            string[] text = new string[] {"Down the way where the nights are gay"
                        ,"And the sun shines daily on the mountain top"
                        ,"I took a trip on a sailing ship"
                        ,"And when I reached Jamaica"
                        ,"I made a stop"};

            using (StreamWriter sw = new StreamWriter("data.txt"))
            {
                foreach(string str in text)
                {
                    sw.WriteLine(str);
                }
            }

            string line = "";
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }
}
