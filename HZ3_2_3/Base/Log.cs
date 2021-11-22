using System;
using System.IO;

namespace HZ3_2_3
{
    public class Log
    {
        private string _filePath = "./"+DateTime.Now.ToFileTimeUtc()+"_log.xyz";

        public Log()
        {
            File.Create(_filePath).Close();
            Command.ThrowEvent += (sender) => { OnCommandExec(sender); };
        }

        private void OnCommandExec(Command sender)
        {
            File.AppendAllText(_filePath, DateTime.Now + ": " + sender.CommandSyntax + " executed!\n");
        }
    }
}