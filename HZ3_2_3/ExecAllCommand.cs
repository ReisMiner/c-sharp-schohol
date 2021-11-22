using System;

namespace HZ3_2_3
{
    public class ExecAllCommand:Command
    {
        public override string CommandSyntax
        {
            get
            {
                return "+execAll";
            }
        }

        public override string ErrorMessage
        {
            get
            {
                return "ka was los isch";
            }
        }

        public override void ExecuteCommand(params string[] args)
        {
            base.ExecuteCommand();
            try
            {
                Console.WriteLine("alli commands werded usgfüert\n");
                foreach (IExecute x in Program.cmds)
                {
                    x.ExecuteCommand();
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