using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface Observer
    {
        public void update(Message m );
    }
    
    public class MessageSubscriberOne : Observer
    {
        public void update(Message m)
        {
            Console.WriteLine("MessageSubscriberOne ::"+m.getMessageContent());
        }
    }
    public class MessageSubscriberTwo : Observer
    {
        public void update(Message m)
        {
            Console.WriteLine("MessageSubscriberTwo ::" + m.getMessageContent());
        }
    }
    public class MessageSubscriberThree : Observer
    {
        public void update(Message m)
        {
            Console.WriteLine("MessageSubscriberThree ::" + m.getMessageContent());
        }
    }
}