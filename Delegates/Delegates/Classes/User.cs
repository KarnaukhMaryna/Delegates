namespace Delegates.Classes
{
    class User
    { 
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public User(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format($"Name {Name}, Gender {Gender}, Age {Age}");
        }
    }
}
