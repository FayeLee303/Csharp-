using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_文件操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //相对路径，找当前程序所在的路径
            //绝对路径就是完整路径
            //FileInfo fileInfo = new FileInfo("TextFile1.txt");
            //FileInfo fileInfo_s = new FileInfo(@"E:\VSProjects\Csharp学习\011_文件操作\TextFile1.txt");
            ////判断是否存在
            //if (!fileInfo_s.Exists)
            //{
            //    Console.WriteLine("文件不存在");
            //}
            //else
            //{
            //    Console.WriteLine(fileInfo_s.Name);//文件名.后缀
            //    Console.WriteLine(fileInfo_s.Directory);//目录
            //    Console.WriteLine(fileInfo_s.Length);//大小
            //    Console.WriteLine(fileInfo_s.IsReadOnly);//是否只读
            //    fileInfo_s.Delete();//删除输出目录下的文件，工程下的文件还在
            //    fileInfo_s.CopyTo("tt.txt");//拷贝到另一个文件
            //}

            //FileInfo fileInfo = new FileInfo("aaa.txt");
            //if (!fileInfo.Exists)
            //{
            //    //如果不存在就创建一个空的
            //    fileInfo.Create();
            //}
            //fileInfo.MoveTo("bbb.txt");//相当于一个重命名操作

            //DirectoryInfo dirInfo = new DirectoryInfo(@"E:\VSProjects\Csharp学习\011_文件操作");
            //if (dirInfo.Exists)
            //{
            //    Console.WriteLine(dirInfo.Name);//文件夹名
            //    Console.WriteLine(dirInfo.Parent);//父文件夹名
            //    Console.WriteLine(dirInfo.Root);//子文件夹名
            //    Console.WriteLine(dirInfo.CreationTime);//创建时间
            //    dirInfo.CreateSubdirectory("aaa");//创建子文件夹
            //}

            ////ReadAllLines读取文件，逐行存成字符串数组
            //string[] strArray = File.ReadAllLines("TextFile1.txt");
            ////ReadAllText是把文件内所有字符存成一个字符串
            //string s = File.ReadAllText("TextFile1.txt");
            //File.WriteAllText("TextFile1.txt","sss");//把原文件的内容覆盖掉了
            //File.WriteAllLines("TextFile1.txt",new string[]{"aaa","sss"});//把原文件的内容覆盖掉了
            //byte[] data = File.ReadAllBytes(@"E:\VSProjects\Csharp学习\011_文件操作\1111.png");
            //File.WriteAllBytes("2222.png",data);//相当于完成了一次复制


            ////使用FileStream读取文件，比较适合读取二进制的文件
            ////创建文件流来操作文件
            //FileStream fileStream = new FileStream("TextFile1.txt",FileMode.Open);
            //byte[] data = new byte[1024];//数据容器，1024byte等于1kb
            ////读取数据           
            //while (true)
            //{
            //    int length = fileStream.Read(data, 0, data.Length);
            //    if (length == 0)
            //    {
            //        Console.WriteLine("读取数据结束");
            //    }
            //    for (int i = 0; i < length; i++)
            //    {
            //        Console.Write(data[i] + " ");
            //    }
            //}

            ////使用FileStream完成文件的复制
            //FileStream readStream = new FileStream("1111.png",FileMode.Open);
            //FileStream writeStream = new FileStream("1111_copy.png", FileMode.Create);
            //byte[] data = new byte[1024];
            //while (true)
            //{
            //    int length = readStream.Read(data, 0, data.Length);//读取到的数据长度
            //    if (length == 0)
            //    {
            //        Console.WriteLine("读取数据结束");
            //        break;
            //    }
            //    else
            //    {
            //        //写入数据
            //        writeStream.Write(data, 0, data.Length);
            //    }
            //}
            ////使用完之后要把流关闭
            //readStream.Close();
            //writeStream.Close();


            //使用SteamReader和SteamWrite来操作文件，比较适合文本文件
            StreamReader reader = new StreamReader("TextFile1.txt");
            while (true)
            {
                string str = reader.ReadLine();//逐行读取
                if (str == null) break;//为空时表示读取完毕
                Console.WriteLine(str);
            }
            string str_end = reader.ReadToEnd();//直接读取到结尾
            while (true)
            {
                int res = reader.Read();//逐字读取
                if (res == -1) //到达结尾
                {
                    break;
                }
                else
                {
                    Console.Write((char)res);
                }
            }
            reader.Close();//这也是一个流，使用完要关闭

            //文本文件写入流
            StreamWriter writer = new StreamWriter("TextFile2.txt");//如果文件存在就会被覆盖
            while (true)
            {
                string message = Console.ReadLine();
                if (message == "over") break;
                writer.Write(message);//写字符串
                writer.WriteLine(message);//写字符串并换行
            }
            writer.Close();
            Console.ReadKey();
        }
    }
}
