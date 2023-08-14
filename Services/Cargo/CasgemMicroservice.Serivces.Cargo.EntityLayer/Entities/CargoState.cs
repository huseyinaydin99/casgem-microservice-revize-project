using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities
{
    public class CargoState : IEntity
    {
        public int CargoStateId { get; set; }
        public string Description { get; set; }
    }
}