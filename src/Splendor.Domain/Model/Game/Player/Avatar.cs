using System;
using System.Collections.Generic;

namespace Splendor.Domain
{
    public class Avatar : IPath
    {
        private string name;
        public void SetName(string newName) => name = newName;

        public int Id { get; }
        public string Path => $"Silueta{Id}";

        public Avatar(int id, string name)
        {
            Id = id;
            this.name = name;
        }
        
        public override string ToString() => name;

        public static bool operator ==(Avatar obj1, Avatar obj2) => obj1.Equals(obj2);
        public static bool operator !=(Avatar obj1, Avatar obj2) => !obj1.Equals(obj2);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var profile = (Avatar)obj;
            return profile.Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
