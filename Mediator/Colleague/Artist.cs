using System;

namespace Mediator.Colleague
{
    class Artist : Participant

    {
        // Constructor
        public Artist(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a Artist: ");
            base.Receive(from, message);
        }
    }
}