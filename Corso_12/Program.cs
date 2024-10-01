using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace Corso_12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Lista semplice
            List<Request> requests = new List<Request>();

            //Init
            requests.Add(new Request("Mario Rossi", "1) Il mouse non si muove"));
            requests.Add(new Request("Giuseppe Versi", "2) Il pc mi dice \"Kayboard error, press any key\" Che faccio?"));
            requests.Add(new Request("Alessio Bianchi", "3) La stampante non vede il computer"));
            requests.Add(new Request("Filippo Marrone", "4) E' tutto buio"));
            requests.Add(new Request("Giovanni Blu", "5) Mi si è rotto il porta tazza del computer"));
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elenco inziale:");
            foreach (var item in requests)
                Console.WriteLine($"{item.RequestDateTime:dd/MM/yy hh:mm} : {item.Message} ({item.User})");
            Console.ResetColor();
            Console.WriteLine("\n\n");

            #region coda

            ////Rappresenta una raccolta di oggetti FIFO(First-In First - Out).
            //Queue<Request> FIFOrequests = new Queue<Request>();
            //foreach (var request in requests)
            //    FIFOrequests.Enqueue(request);

            //Console.WriteLine("QUEUE (FIFO)");
            //Request newDequeuedItem;
            //while(FIFOrequests.Count > 0)
            //{
            //    newDequeuedItem = FIFOrequests.Dequeue();
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine($"{newDequeuedItem.RequestDateTime:dd/MM/yy hh:mm} : {newDequeuedItem.Message} ({newDequeuedItem.User})");
            //    Console.ResetColor();

            //    Console.WriteLine($"\nAncora in coda:");

            //    Console.ForegroundColor = ConsoleColor.DarkGray;
            //    foreach (var item in FIFOrequests)
            //        Console.WriteLine($"{item.RequestDateTime:dd/MM/yy hh:mm} : {item.Message} ({item.User})");
            //    Console.ResetColor();
            //    Console.WriteLine("\n");
            //}

            #endregion

            #region Pila

            ////Rappresenta una raccolta di istanze LIFO (last-in-first-out) a dimensione variabile dello stesso tipo specificato.
            //Stack<Request> LIFOrequests = new Stack<Request>();
            //foreach (var request in requests)
            //    LIFOrequests.Push(request);

            //Console.WriteLine("STACK (LIFO)");
            //Request newPoppedItem;
            //while (LIFOrequests.Count > 0)
            //{
            //    newPoppedItem = LIFOrequests.Pop();
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine($"{newPoppedItem.RequestDateTime:dd/MM/yy hh:mm} : {newPoppedItem.Message} ({newPoppedItem.User})");
            //    Console.ResetColor();

            //    Console.WriteLine($"\nAncora in pila:");

            //    Console.ForegroundColor = ConsoleColor.DarkGray;
            //    foreach (var item in LIFOrequests)
            //        Console.WriteLine($"{item.RequestDateTime:dd/MM/yy hh:mm} : {item.Message} ({item.User})");
            //    Console.ResetColor();
            //    Console.WriteLine("\n");
            //}

            #endregion

            #region Liste "osservabili"

            ObservableCollection<Request> requestsObservable = new ObservableCollection<Request>();

            requestsObservable.CollectionChanged += RequestsObservable_CollectionChanged;

            foreach (var item in requests)
            {
                requestsObservable.Add(item);

                Thread.Sleep(new Random().Next(0, 3000));
            }
            #endregion

        }

        #region delegates

        static void RequestsObservable_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Request item = null;

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                item = (Request)e.NewItems[0];

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                item = (Request)e.OldItems[0];

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"ADDED {DateTime.Now.ToLongTimeString()} ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{item?.RequestDateTime:dd/MM/yy hh:mm} : {item?.Message} ({item?.User})");
            Console.ResetColor();
        }

        #endregion
    }
}
