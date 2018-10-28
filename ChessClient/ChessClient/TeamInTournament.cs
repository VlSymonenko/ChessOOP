using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClient
{
    public class TeamInTournament : Base
    {
        static public List<TeamInTournament> TeamInTournaments = new List<TeamInTournament>();

        private Guid _subjectId;
        public Tournament Tournament
        {
            get
            {
                foreach (var t in Tournament.Tournaments)
                    if (t.Id == _subjectId)
                        return t;
                return null;
            }
            set { _subjectId = value.Id; }
        }

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
            set { _groupId = value.Id; }
        }

        public TeamInTournament(Tournament s, Team g)
        {
            Tournament = s; Team = g;
            TeamInTournaments.Add(this);
        }
    }
}
