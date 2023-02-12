using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public static class Sklad
    {
    
        public static void NonBlockingConsumer(BlockingCollection<Tech> bc, CancellationToken ct)
        {
            // IsCompleted == (IsAddingCompleted && Count == 0)
            while (!bc.IsCompleted)
            {
                Tech nextItem = new Tech();
                try
                {
                    if (!bc.TryTake(out nextItem, 1000, ct))
                    {
                        Console.WriteLine(" Take Blocked");
                    }
                    else
                    {
                        Console.WriteLine(" Take:{0}", nextItem.name);
                    }
                }

                catch (OperationCanceledException)
                {
                    Console.WriteLine("Taking canceled.");
                    break;
                }

                // Slow down consumer just a little to cause
                // collection to fill up faster, and lead to "AddBlocked"
                Thread.Sleep(1000);
            }
            
            Console.WriteLine("\r\nNo more items to take.");
        }
        public static void NonBlockingProducer(BlockingCollection<Tech> bc, CancellationToken ct, string Techname, int offset)
        {
            Tech itemToAdd = new Tech();
            itemToAdd.name = Techname;
            bool success = false;

            do
            {
                // Cancellation causes OCE. We know how to handle it.
                try
                {
                    // A shorter timeout causes more failures.
                    success = bc.TryAdd(itemToAdd, 1000, ct);
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Add loop canceled.");
                    // Let other threads know we're done in case
                    // they aren't monitoring the cancellation token.
                    bc.CompleteAdding();
                    break;
                }

                if (success)
                {
                    Console.WriteLine(" Add:{0}", itemToAdd.name);
                }
                else
                {
                    Console.Write(" AddBlocked:{0} Count = {1}", itemToAdd.ToString(), bc.Count);
                    // Don't increment nextItem. Try again on next iteration.

                    //Do something else useful instead.

                    Thread.Sleep(offset);
                }
            } while (true);

            // No lock required here because only one producer.
            bc.CompleteAdding();
            Thread.Sleep(offset);

        }
     
    }
}
