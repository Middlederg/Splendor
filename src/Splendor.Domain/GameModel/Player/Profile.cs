using System.Collections.Generic;

namespace Splendor.Domain
{
    public class Profile : IPath
    {
        private readonly string name;

        public int Id { get; }
        public string Path => $"Silueta{Id}";
        public bool IsHuman { get; }
        public ColorGroup Color { get; set; }

        public Profile(int id, string name, ColorGroup color = null, bool isHuman = false)
        {
            Id = id;
            this.name = name;
            IsHuman = isHuman;
            Color = color ?? ColorFactory.DefaultBlue;
        }

        public override string ToString() => name;

        public static bool operator ==(Profile obj1, Profile obj2) => obj1.Equals(obj2);
        public static bool operator !=(Profile obj1, Profile obj2) => !obj1.Equals(obj2);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var profile = (Profile)obj;
            return profile.Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
