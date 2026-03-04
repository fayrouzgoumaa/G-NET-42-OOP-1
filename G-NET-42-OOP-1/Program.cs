namespace G_NET_42_OOP_1
{
    class PersonClass
    {
        public string Name;
    }
    struct PersonStruct
    {
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // CLASS behavior
            PersonClass p1 = new PersonClass();
            p1.Name = "Fayrouz";

            PersonClass p2 = p1;  // Copies reference
            p2.Name = "Goumaa";

            Console.WriteLine(p1.Name); // Output: Goumaa


            // STRUCT behavior
            PersonStruct s1;
            s1.Name = "Fayrouz";

            PersonStruct s2 = s1; // Copies value
            s2.Name = "Goumaa";

            Console.WriteLine(s1.Name); // Output: Fayrouz
            #endregion

        }
    }
}
