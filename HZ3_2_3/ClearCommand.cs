using System;

namespace HZ3_2_3
{
    public class ClearCommand : Command
    {
        public override string CommandSyntax
        {
            get
            {
                return "+clear";
            }
        }

        public override string ErrorMessage
        {
            get
            {
                return "S programm chan sich ned lösche :huh:";
            }
        }

        public override void ExecuteCommand(params string[] args)
        {
            base.ExecuteCommand();
            try
            {
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(ErrorMessage);
                Console.Error.WriteLine(e);
            }
            
        }
    }
}