using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();
            MessageSubscriberTwo s2 = new MessageSubscriberTwo();
            MessageSubscriberThree s3 = new MessageSubscriberThree();

            MessagePublisher p = new MessagePublisher();
            //p.attach(s1);
            //p.attach(s2);

            //p.notifyUpdate(new Message("First Message")); //s1,s2 will receive the update

            //p.detach(s1);
            //p.attach(s3);

            //p.notifyUpdate(new Message("Second Message")); //s2,s3 will get the message

            p.attach(s1);
            p.attach(s2);
            p.attach(s3);

            p.ChangeState(2);
            Console.ReadLine();
        }
    }
}
