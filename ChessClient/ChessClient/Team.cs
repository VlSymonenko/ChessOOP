using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClient
{
    public class Team : Base
    {
        static public List<Team> Teams = new List<Team>();

        public List<Player> Players
        {
            get
            {
                List<Player> res = new List<Player>();
                foreach (var pl in Player.Players)
                    if (pl.Team == this)
                        res.Add(pl);
                return res;
            }
        }

        public List<TeamInTournament> TeamInTournaments
        {
            get
            {
                List<TeamInTournament> res = new List<TeamInTournament>();
                foreach (var tit in TeamInTournament.TeamInTournaments)
                    if (tit.Team == this)
                        res.Add(tit);
                return res;
            }
        }

        public List<Tournament> Tournaments
        {
            get
            {
                List<Tournament> res = new List<Tournament>();
                foreach (var tit in TeamInTournament.TeamInTournaments)
                    if (tit.Team == this)
                        res.Add(tit.Tournament);
                return res;
            }
        }

        public Team(string name) : base(name)
        {
            Teams.Add(this);
        }
    }
}
