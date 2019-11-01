using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleague
{
    public class nonArtist : Participant
    {
        public nonArtist(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Artist: ");
            base.Receive(from, message);
        }
    }
}
