using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Colleague;
using Mediator.Mediator;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create chatroom

            Chatroom chatroom = new Chatroom();

            // Create participants and register them

            Participant George = new Artist("George");
            Participant Paul = new Artist("Paul");
            Participant Ringo = new Artist("Ringo");
            Participant John = new Artist("John");
            Participant Yoko = new nonArtist("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            // Wait for user

            Console.ReadKey();
        }
    }
}
