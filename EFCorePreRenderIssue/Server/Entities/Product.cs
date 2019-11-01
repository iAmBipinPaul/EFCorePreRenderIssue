using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Server.Entities
{
    public class Product
    {      
        public int Id { get; set; }
        public string Name { get; set; }            
        public int UnitId { get; set; }
        public Unit Unit { get; set; }

    }
}
