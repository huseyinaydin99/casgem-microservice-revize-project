using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities
{
    public class CargoDetail : IEntity
    {
        public int CargoDetailId { get; set; }
        public int OrderingId { get; set; }
        public int CargoStateId { get; set; }
        public CargoState CargoState { get; set; }
    }
}