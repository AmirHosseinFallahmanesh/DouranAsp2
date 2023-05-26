using Demo1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Ads> Ads { get; set; }
        public IEnumerable<News> HotNews { get; set; }
        public IEnumerable<News> LastNews { get; set; }

    }
}
