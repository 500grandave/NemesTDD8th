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


            IList<IList<Share>> partitioningResult = new List<IList<Share>>();
            int total = 0;
            while(total < sharesList.Count)
            {
                List<Share> subGroup = sharesList.Skip(total).Take(_partitionSize).ToList();
                partitioningResult.Add(subGroup);
                total += _partitionSize;
            }



            return new Partition() { PartitioningResult = partitioningResult, Size = sharesList.Count};
        }
    }
}
