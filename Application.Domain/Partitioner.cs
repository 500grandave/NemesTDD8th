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
            return new Partition() { Size = sharesList.Count};
        }
    }
}
