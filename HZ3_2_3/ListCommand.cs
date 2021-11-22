using System;

namespace HZ3_2_3
{
    public class ListCommand : Command
    {
        public override string CommandSyntax
        {
            get { return "+list"; }
        }

        public override string ErrorMessage
        {
            get { return "iwie gads ned ka why tho"; }
        }

        public override void ExecuteCommand(params string[] args)
        {
            base.ExecuteCommand();
            try
            {
                Console.WriteLine("alli commands:\n");
                foreach (Command x in Program.cmds)
                {
                    Console.WriteLine(x.CommandSyntax);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(ErrorMessage);
                Console.Error.WriteLine(e);
            }
        }
    }
}