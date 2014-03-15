using System;
using Microsoft.WindowsAzure.Jobs;

namespace WebJob {
    class Program {
        static void Main(string[] args) {
        new JobHost().RunAndBlock();
        }

        public static void ProcessQueueMessage(
        [QueueInput("webjobsqueue")] string queueMessage 
            ) {
           Console.WriteLine(queueMessage); 
        }
    }
}
