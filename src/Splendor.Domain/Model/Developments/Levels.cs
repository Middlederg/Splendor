namespace Splendor.Domain
{
    public static class Levels
    {
        public static Level FromInt(int levelNumber) => new Level(levelNumber);
        public static Level Level1 => new Level(1);
        public static Level Level2 => new Level(2);
        public static Level Level3 => new Level(3);
    }
}
