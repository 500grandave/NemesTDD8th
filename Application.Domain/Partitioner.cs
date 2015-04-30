using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Domain
{
    public class Partitioner
    {
        private int _partitionSize;

        public Partitioner(int partitionSize)
        {
            // TODO: Complete member initialization
            this._partitionSize = partitionSize;
        }

        public Partition Partition(List<Share> sharesList)
        {
//            throw new NotImplementedException();
            System.Diagnostics.Debug.WriteLine("Starting While Loop");
            System.Diagnostics.Debug.Indent();
//
            IList<IList<Share>> partitioningResult = new List<IList<Share>>();
            int total = 0;
            while(total < sharesList.Count)
            {
                List<Share> subGroup = sharesList.Skip(total).Take(_partitionSize).ToList();
                partitioningResult.Add(subGroup);
//
                if ((total % 2) == 0) 
                    System.Diagnostics.Debug.Indent();
                if ((total % 3) == 0)
                    System.Diagnostics.Debug.Unindent();
                System.Diagnostics.Debug.WriteLine(string.Format("Loop {0} at Indent Level {1}", total, System.Diagnostics.Debug.IndentLevel));
//
                total += _partitionSize;
            }
//
            System.Diagnostics.Debug.IndentLevel = 0;
            System.Diagnostics.Debug.WriteLine("Ending While Loop");
//
            return new Partition() { PartitioningResult = partitioningResult, Size = sharesList.Count};
        }
    }
}
