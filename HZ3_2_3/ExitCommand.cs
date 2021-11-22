using System;

namespace HZ3_2_3
{
    public class ExitCommand : Command
    {
        public override string CommandSyntax
        {
            get
            {
                return "+exit";
            }
        }

        public override string ErrorMessage
        {
            get
            {
                return "Wieso chan ich ned use?";
            }
        }

        public override void ExecuteCommand(params string[] args)
        {
            base.ExecuteCommand();
            try
            {
                Environment.Exit(0);
            }
            catch (Exception e)
            {
                Console.WriteLine(ErrorMessage);
                Console.Error.WriteLine(e);
            }
            
        }
    }
}