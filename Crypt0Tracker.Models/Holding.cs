using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Crypt0Tracker.Models
{
    class Holding
    {
        [StringLength(10)]
        public string Ticker { get; set; }
    }
}
