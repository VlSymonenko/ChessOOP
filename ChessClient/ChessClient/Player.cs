using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClient
{
    public class Player : Base/*,IComparable*/
    {
        static public List<Player> Players = new List<Player>();
        public string SName;
        public string PName;
        public int Rating;
        public string Nationality;
        public int Age;
        public string NickName;
        private Guid _groupId;

        public Team Team
        {
            get
            {
                foreach (var t in Team.Teams)
                    if (t.Id == _groupId)
                        return t;

                return null;
            }
            set
            {
                _groupId = value == null ? Guid.Empty : value.Id;
            }
        }
        //public int CompareTo(object o)
        //{
        //    Player p = o as Player;
        //    if (p != null)
        //        return CompareTo(p);
        //    else
        //        throw new Exception("Невозможно сравнить два объекта");
        //}
        public Player(Team g) : this("", g) { }
        public Player(string n):base(n)
        {
            //if (CompareTo(this) != 0)
              //  throw new Exception("GGWP");
        }

        public Player(string n, Team g) : base(n)
        {
            Team = g;
           // if(CompareTo(this)==0)
            Players.Add(this);
        }
        public override string ToString()
        {
            return $"Name : {Name} , Surname : {SName} , Nationality : {Nationality} , Rating : {Rating} , Age : {Age} , NickName : {NickName}";
        }
    }
}
