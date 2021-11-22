using System;

namespace HZ3_2_3
{
    public class PrintCommand : Command
    {
        public override string CommandSyntax
        {
            get { return "+print"; }
        }

        public override string ErrorMessage
        {
            get { return "Chan ned drucke gopf!!!!1!!1¨++!!+!11"; }
        }
        
        public override void ExecuteCommand(params string[] args)
        {
            base.ExecuteCommand();
            string output = "";
            try
            {
                for (int i = 1; i < args.Length; i++)
                {
                    output += args[i] + " ";
                }

                output.Substring(output.Length - 1);
                Console.WriteLine(output);
            }
            catch (Exception e)
            {
                Console.WriteLine(ErrorMessage);
                Console.Error.WriteLine(e);
            }
        }
    }
}