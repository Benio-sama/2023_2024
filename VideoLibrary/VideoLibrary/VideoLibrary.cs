using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibrary
{
    internal class VideoLibrary
    {
        private List<Video> videos = new List<Video>();
        private List<Guest> guests = new List<Guest>();

        internal List<Video> Videos { get => videos; set => videos = value; }
        internal List<Guest> Guests { get => guests; set => guests = value; }

        public override string ToString()
        {
            return $"Az áruháznak jelenleg {videos.Count()} videója van, és {guests.Count()} regisztrált vendége.";
        }
        public void AddGuest(Guest g)
        {
            guests.Add(g);
        }
        public void AddVideo(Video v)
        {
            videos.Add(v);
        }
        public void Borrow(Guest g, Video v)
        {
            if (g.IsBorrowing)
            {
                throw new Exception("mar van egy video kolcsonozve a felhasznalonal");
            }
            else if (v.IsBorrowed)
            {
                throw new Exception("a video jelenleg ki van kolcsonozve");
            }
            else
            {
                v.IsBorrowed = true;
                g.IsBorrowing = true;
                g.Borrowedvideo = v;
            }
        }
        public void ReturnVideo(Guest g)
        {
            if (g.IsBorrowing)
            {
                g.Borrowedvideo.Borrowed++;
                g.Borrowedvideo.IsBorrowed = false;
                g.Borrowedvideo = null;
                g.IsBorrowing = false;
            }
            else
            {
                throw new Exception("nincs kolcsonzott video amit vissza tudna vinni a felhasznalo");
            }
        }
        public string GetMostOftenBorrowed()
        {
            Video max = videos[0];
            foreach (var item in videos)
            {
                if (item.Borrowed > max.Borrowed)
                {
                    max = item;
                }
            }
            return max.ToString();
        }
    }
}
