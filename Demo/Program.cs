using Demo.Example02_Youtube;
using Demo.Fifa_Game;
using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What Is Event
            //event is a way for a class to notify other classes (subscribers) when something happens. It uses a delegate to define the method signature for the event handlers.
            //The publisher class raises the event, and subscribers handle it with their methods. Events are commonly used in the publisher-subscriber model for communication between
            //objects.
            #endregion
            #region Event [example 01]
            //Ball ball = new Ball() ;
            //Console.WriteLine(ball);
            //ball.Location = new Location() { X = 1, Y = 2, Z = 3 };
            //Console.WriteLine(ball);
            //Player player01 = new Player() { PlayerName = "Marwaa", TeamName = "team01" };
            //Player player02 = new Player() { PlayerName = "Marwaan", TeamName = "team01" };
            //Player player03 = new Player() { PlayerName = "maram", TeamName = "team02" };
            //Player player04 = new Player() { PlayerName = "reem", TeamName = "team02" };
            //Refree refree01 = new Refree() { RefreeName = "salem" };
            //ball.BallLocationChanged += player01.Run;
            //ball.BallLocationChanged += player02.Run;
            //ball.BallLocationChanged += player03.Run;
            //ball.BallLocationChanged += player04.Run;
            //ball.BallLocationChanged += refree01.Look;
            //ball.Location = new Location() { X = 11, Y = 12, Z = 13 };
            //ball.Location = new Location() { X = 11, Y = 12, Z = 13 };
            //ball.Location = new Location() { X = 11, Y = 12, Z = 13 };
            //ball.BallLocationChanged -= refree01.Look;
            //ball.Location = new Location() { X = 11, Y = 12, Z = 11 };


            #endregion
            #region Event [example 02]
            //Subscriber subscriber01 = new Subscriber() { Name = "Marwa" };
            //Subscriber subscriber02 = new Subscriber() { Name = "Marwan" };
            //Subscriber subscriber03 = new Subscriber() { Name = "Mary" };
            //Subscriber subscriber04 = new Subscriber() { Name = "rania" };
            //Channel channel01 = new Channel() { ChannelName = "comedy" };
            //channel01.VideoAdded += subscriber01.Notify;
            //channel01.VideoAdded += subscriber02.Notify;
            //channel01.VideoAdded += subscriber03.Notify;
            //channel01.VideoAdded += subscriber04.Notify;
            //channel01.AddVideo(new Video() { Title = "Video01", Desc = "loremmmmmmmmm" });
            //channel01.AddVideo(new Video() { Title = "Video02", Desc = "loremmmmmmmmm" });
            #endregion
            #region  Hashtables Category[non-generic]
            //generic
            //non-generic
            Hashtable Note = new Hashtable();
            Console.WriteLine(Note.Count);
            Note.Add("Ahmed", "012238475956");
            Note.Add("rana", "012238475956");
            Note.Add("marwa", "012238475956");
            Note.Add("marwan", "012238475956");
            Console.WriteLine(Note.Count);
            foreach (DictionaryEntry Item in Note) {
                Console.WriteLine(Item);
                Console.WriteLine(Item);
            }
            #endregion
        }
    }
}
