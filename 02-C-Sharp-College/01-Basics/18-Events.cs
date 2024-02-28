// Foreground(Events generated by user) Event and Background(Events generated by process) Event
/*
    Publisher: Generates event
    Subscriber: Responds to generated event
    
 */
using System;
using System.Security.Cryptography.X509Certificates;

namespace EventApp
{
    // Delegate defines a signature of Event. So, Subscriber method should also follow that signature
    public delegate void Notify();
    public class Process
    {
        // Declaring and event named 'ProcessCompleted' of type 'Notify'
        public event Notify ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            Console.WriteLine("Process Running...");
            OnProcessCompleted();  
        }
        protected virtual void OnProcessCompleted()
        {
            // Invoke the event's subscriber method if the subscriber exists
            ProcessCompleted?.Invoke();
        }
        public static void Main(string[] args)
        {
            Process p1 = new Process();
            // Attach subscriber method to the event. If this not done, then event wil have null subscriber
            p1.ProcessCompleted += p1_ProcessCompleted;
            p1.StartProcess();
        }
        // Subscriber: Actual Event Handler
        private static void p1_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}