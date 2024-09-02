using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example02_Youtube
{
    internal class Video
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public override string ToString()
        {
            return $"Title={Title} , Description = {Desc}";
        }
    }
}
