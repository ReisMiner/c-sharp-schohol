using System;

namespace HZ3_2_3
{
    public abstract class Command : IExecute
    {
        public abstract string CommandSyntax { get; }
        public abstract string ErrorMessage { get; }
        
        public delegate void EventHandler(Command sender) ;

        public static event EventHandler ThrowEvent = delegate{};

        public virtual void ExecuteCommand(params string[] args)
        {
            ThrowEvent(this);
        }
    }
}