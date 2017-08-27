using System;

namespace ProCSharp.Ch06
{
    public class Person : IComparable<Person>, IEquatable<Person>
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1} {2}", Id, FirstName, LastName);
        }

        public int CompareTo(Person other)
        {
            if (other == null)
                throw new ArgumentException("other");

            int result = this.LastName.CompareTo(other.LastName);
            if (result == 0)
            {
                result = this.FirstName.CompareTo(other.FirstName);
            }
            return result;
        }

        public override Boolean Equals(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            return Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Equals(Person other)
        {
            if (other == null) throw new ArgumentNullException("other");

            return this.Id == other.Id && this.FirstName == other.FirstName &&
                   this.LastName == other.LastName;
        }
    }
}