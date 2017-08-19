namespace ProCSharp.Ch04
{
    abstract class GenericCustomer
    {
        private string name;
        // lots of other method etc.

        private GenericCustomer()
            : base() // We could omit this line without affecting the compiled code.
        {
            name = "<no name>";
        }

        public GenericCustomer(string name)
        {
            this.name = name;
        }
    }

    class Nevermore60Customer : GenericCustomer
    {
        private string referrerName;
        private uint highCostMinutesUsed;
        // other methods etc.

        public Nevermore60Customer(string name, string referrerName)
            : base(name)
        {
            this.referrerName = referrerName;
        }

        public Nevermore60Customer(string name)
            : this(name, "<None>")
        {
        }
    }
}