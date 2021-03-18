using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest leave = new LeaveRequest()
            {
                LeaveDays = 6,
                Employee = "Mani"
            };
            ILeaveRequestHandler leaves = new Supervisor();
            leaves.HandlerRequest(leave);

            Console.ReadLine();
        }
    }
}
