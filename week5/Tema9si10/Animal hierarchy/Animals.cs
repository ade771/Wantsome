using System;

namespace Animal_hierarchy
{
    public abstract class Animals : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        public Animals(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;

        }

        public abstract void Sound();

        public static double CalculateAverage(Animals[] allanimal)
        {
            int sum = 0;

            foreach (var animal in allanimal)
            {
                sum += animal.Age;
            }

            int result = sum / allanimal.Length;

            return result;
        }

    }
}

