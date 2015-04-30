using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Domain;

namespace Application.Domain.Tests
{
    [TestFixture]
    public class FinanceTests
    {
        [Test]
        public void Partitioning_a_list_of_one_item_by_one_produces_a_partition_of_size_one()
        {
            List<Share> sharesList = CreateSharesListOfSize(1);

            Partitioner partitioner = new Partitioner(1);
            Partition partition = partitioner.Partition(sharesList);
            System.Diagnostics.Debug.WriteLine(string.Format("The inside of Size is: {0}", partition.Size.ToString()));
            Assert.AreEqual(1, partition.Size);
        }
        [Test]
        public void Partitioning_a_list_of_two_items_by_one_produces_a_partition_of_size_two()
        {
            List<Share> sharesList = CreateSharesListOfSize(2);

            Partitioner partitioner = new Partitioner(1);
            Partition partition = partitioner.Partition(sharesList);
            System.Diagnostics.Debug.WriteLine(string.Format("The inside of Size is: {0}", partition.Size.ToString()));
            Assert.AreEqual(2, partition.Size);
        }
        private List<Share> CreateSharesListOfSize(int size)
        {
            List<Share> shares = new List<Share>();
            for(int i = 0; i < size; i++)
            {
               shares.Add(new Share() { Maximum = 130, Minimum = 15 });

            }
            return shares;
        }
    }
}
