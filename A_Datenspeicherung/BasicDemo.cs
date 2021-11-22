using System;
using System.IO;
using System.Text;

namespace A_Datenspeicherung
{
    class Program
    {
        static void Maisn(string[] args)
        {
            // define path and file name
            string fileName = @"C:\Users\r1min\OneDrive\school\Module\M226B\Code\xyz.xyz";
            // define and initialize arrays
            byte[] byteArrayWrite =  Encoding.ASCII.GetBytes("Hallo. Du bisch fett loool.\nOke vlt doch ned idk.\nABCDEFGHIJKLMNOPQRSTUVWXYZ\nabcdefghijklmnopqrstuvwxyz");
            byte[] byteArrayRead = new byte[byteArrayWrite.Length];
            //create file stream
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            // write array to file
            fs.Write(byteArrayWrite, 0, byteArrayWrite.Length);
            
            fs.Position = 0;
            
            fs.Read(byteArrayRead, 0, byteArrayRead.Length);
            
            for (int count = 0; count < byteArrayRead.Length; count++){
                Console.Write (byteArrayRead[count] + ", ");
            }
            fs.Close();

            //File.Delete(fileName);
        }

    }
}