using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClient
{
    public class Tournament : Base
    {
        static public List<Tournament> Tournaments = new List<Tournament>();

        public List<TeamInTournament> TeamInTournaments
        {
            get
            {
                List<TeamInTournament> res = new List<TeamInTournament>();
                foreach (var tit in TeamInTournament.TeamInTournaments)
                    if (tit.Tournament == this)
                        res.Add(tit);
                return res;
            }
        }

        public List<Team> Teams
        {
            get
            {
                List<Team> res = new List<Team>();
                foreach (var tit in TeamInTournament.TeamInTournaments)
                    if (tit.Tournament == this)
                        res.Add(tit.Team);
                return res;
            }
        }

        public Tournament(string name) : base(name)
        {
            Tournaments.Add(this);
        }
    }
}
