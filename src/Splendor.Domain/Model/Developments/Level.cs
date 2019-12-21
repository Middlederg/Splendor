using System;
using System.ComponentModel;

namespace Splendor.Domain
{
    public class Level
    {
        public int LevelNumber { get; }

        internal Level(int number)
        {
            LevelNumber = number;
        }

        public override string ToString() => $"Level {LevelNumber}";

        public static bool operator ==(Level gem1, Level gem2) => gem1.Equals(gem2);
        public static bool operator !=(Level gem1, Level gem2) => !gem1.Equals(gem2);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var level = (Level)obj;
            return level.LevelNumber == LevelNumber;
        }

        public override int GetHashCode() => LevelNumber.GetHashCode();

    }
}
