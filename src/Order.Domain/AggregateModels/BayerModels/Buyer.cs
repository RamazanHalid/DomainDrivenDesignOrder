using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.AggregateModels.BayerModels
{
    public class Buyer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
