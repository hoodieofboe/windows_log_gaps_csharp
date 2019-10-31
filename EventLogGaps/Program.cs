using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EventLogGaps
{
   class Program
   {
      static void Main(string[] args)
      {
         DateTime start = DateTime.Now;
         var eventLog = new EventLog("Security");
         Dictionary<int, int> holes = new Dictionary<int, int>();
         int previousId = -1;
         foreach (EventLogEntry ele in eventLog.Entries)
         {
            if (previousId < 0) previousId = ele.Index;            
            else if (ele.Index - 1 != previousId)
            {
               holes.Add(previousId, ele.Index);
               previousId = ele.Index;
            } else
            {
               previousId = ele.Index;
            }
         }
         DateTime end = DateTime.Now;

         if (holes.Count > 0) Console.WriteLine("You got {0} holes", holes.Count);
         else Console.WriteLine("No holes");
         Console.WriteLine("Count: {0}", eventLog.Entries.Count);
         Console.WriteLine((end.Subtract(start)));
         Console.WriteLine("Finished");
         Console.ReadKey();
      }
   }
}
