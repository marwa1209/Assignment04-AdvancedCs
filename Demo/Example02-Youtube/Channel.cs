using Demo.Fifa_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example02_Youtube
{
    internal class Channel
    {
        public string ChannelName { get; set; }
        public List<Video> Videos { get; set; }
        public void AddVideo(Video video)
        {
            if (Videos is not null)
            {
                Videos.Add(video);
                VideoAdded?.Invoke(video ,this);
            }

            //notify subscribers
        }
        public event Action<Video ,Channel>? VideoAdded;

        public override string ToString()
        {
            return $"ChannelName={ChannelName}";
        }
        public Channel()
        {
            Videos = new List<Video>();
        }
    }
}
