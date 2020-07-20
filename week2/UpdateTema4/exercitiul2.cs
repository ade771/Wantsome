using System;


namespace UpdateTema4
{
    class exercitiul2
    {
        public void Exercitiul2()
        {
            //2. Implement an algorithm to determine if a string has all unique characters.
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            if (IsUnique(str) == true) 
            {
                Console.WriteLine("The String  has all unique characters");
            }                    
            else
            {


                Console.WriteLine("The String  has duplicate characters");

            }

            static bool IsUnique(String str)
            {


                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                        {
                            return false;
                        }
                    }

                }
                return true;
            }

            
            
               
            
            Console.ReadKey();


        }
    }
}
