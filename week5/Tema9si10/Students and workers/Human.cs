

namespace Students_and_workers
{
    abstract class Human
    {
   
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string firstName, string lastName)

        {
            this.FirstName = firstName;
            this.LastName = lastName;


        }
    }
}
