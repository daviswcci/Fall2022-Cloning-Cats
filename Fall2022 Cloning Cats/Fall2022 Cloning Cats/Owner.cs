namespace Fall2022_Cloning_Cats
{
    internal class Owner
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Owner()
        {
            Name = "Davis";
            Age = 24;
        }
        public Owner(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}