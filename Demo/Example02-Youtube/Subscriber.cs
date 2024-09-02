using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example02_Youtube
{
    internal class Subscriber
    {
        public string Name { get; set; }
        public void Notify(Video video , Channel channel)
        {
            Console.WriteLine($"{Name } new video alert Video Name is {video.Title} , Channel name is ={channel.ChannelName}" );
        }
        public override string ToString()
        {
            return $"Name ={Name}";
        }
    }
}
