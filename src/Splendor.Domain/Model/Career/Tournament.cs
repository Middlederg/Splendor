using System;
using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class Tournament
    {
        private readonly int id;
        private readonly string name;
        private readonly int maxPlayers;

        public string Description { get; }
        public string Place { get; }
        public Division Division { get; }
        public DateTime Date { get; }
        public int Edition => Date.Year;
        public int Rounds { get; set; }
        public PlayersPerTable PlayersPerTable { get; }
        public List<TournamentParticipant> Participants { get; private set; }
        public void AddParticipant(TournamentParticipant participant)
        {
            if (Participants.Count > maxPlayers)
                throw new ArgumentOutOfRangeException($"Can not add more participants");

            Participants.Add(participant);
        }
        public List<Sponsor> Sponsors { get; }

        public Tournament(int id, string name, string description, string place, Division division, DateTime date, int rounds,
            PlayersPerTable playersPerTable, int maxPlayers, params Sponsor[] sponsor)
        {
            this.id = id;
            this.name = name;
            this.maxPlayers = maxPlayers;

            Description = description;
            Place = place;
            Division = division;
            Date = date;
            Rounds = rounds;
            PlayersPerTable = playersPerTable;

            Participants = new List<TournamentParticipant>();
            Sponsors = sponsor.ToList();
        }

        public List<TournamentParticipant> Ranking() => Participants
            .OrderByDescending(participant => participant.Victories)
            .ThenByDescending(participant => participant.Points)
            .ToList();

        public override string ToString() => name;
    }
}
