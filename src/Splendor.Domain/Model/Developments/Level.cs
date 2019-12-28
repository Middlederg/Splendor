using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Splendor.Domain
{
    public class Level
    {
        public static IEnumerable<Level> AllLevels => new List<Level>() { Level.Level1, Level.Level2, Level.Level3 };
        public static Level FromScalar(int levelNumber) => new Level(levelNumber);
        public static Level Level1 => FromScalar(1);
        public static Level Level2 => FromScalar(2);
        public static Level Level3 => FromScalar(3);

        private readonly int value;

        private Level(int value)
        {
            if (value < 1 || value > 3)
                throw new ArgumentOutOfRangeException(nameof(Level), "Level should be a value between 1 and 3");
            this.value = value;
        }

        public static implicit operator int(Level prestige) => prestige.value;
        public static explicit operator Level(int value) => new Level(value);

        public override string ToString()
        {
            switch (Constants.CurrentLanguage)
            {
                case Language.Spanish: return $"Nivel {value}";
                default: return $"Level {value}";
            }
        }

        public static bool operator ==(Level obj1, Level obj2) => obj1.Equals(obj2);
        public static bool operator !=(Level obj1, Level obj2) => !obj1.Equals(obj2);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var level = (Level)obj;
            return level.value == value;
        }

        public override int GetHashCode() => value.GetHashCode();

    }
}
