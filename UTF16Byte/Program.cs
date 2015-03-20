using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UTF16Byte
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "/移行作業用/MultiByteTest2/MultiByteTest2/アンケート結果ビューアー はない はない/ｃｔｌEnqueteViewer.cs";
//
            byte[] b1 = Encoding.Unicode.GetBytes(s1);
            int[] b2 = new int[b1.Length];
            for (int i = 0; i < b1.Length;i++ )
            {
                b2[i] = b1[i];
            }
            Console.WriteLine(b1[0].ToString());
            string fileName = @"C:\Users\bgubbiga\Desktop\bytes.txt";
            using(FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using(StreamWriter writer = new StreamWriter(stream))
                {
                    foreach(int i in b2)
                    {
                        writer.Write(i);
                        writer.Write(" ");
                    }
                }
            }

        }
    }
}
