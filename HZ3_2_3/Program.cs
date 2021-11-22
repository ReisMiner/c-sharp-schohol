using System;
using System.Collections.Generic;

namespace HZ3_2_3
{
    class Program
    {
        public static List<Command> cmds;

        static void Main(string[] args)
        {
            Log log = new Log();
            cmds = new List<Command>();
            RegisterCmds();

            while (true)
            {
                bool foundCmd = false;
                string[] cmdArgs = Console.ReadLine().Split(" ");
                foreach (Command cmd in cmds)
                {
                    if (cmd.CommandSyntax == cmdArgs[0])
                    {
                        foundCmd = true;
                        cmd.ExecuteCommand(cmdArgs);
                    }
                }

                if (!foundCmd)
                {
                    Console.WriteLine("De igäbeni command isch ned gfunde worde.\n" +
                                      "Benutz +list zum d commands azeige!");
                }
            }
        }

        private static void RegisterCmds()
        {
            cmds.Add(new PrintCommand());
            cmds.Add(new ExitCommand());
            cmds.Add(new ClearCommand());
            cmds.Add(new ListCommand());
            cmds.Add(new ExecAllCommand());
        }
    }
}