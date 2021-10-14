using System;

namespace Password_Lab_5
{
    class Program
    {
        const int MIN_LENGTH = 7;
        const string SYMBOLS = "!@#$%^&*()";
        const int MAX_LENGTH = 12;


        static bool goodPassword(string password)
        {

            string[] passWord = { "", "", "", "", "", "", "", "", "", "" };

            string[] userName = { "", "", "", "", "", "", "", "", "", "" };

            bool hasLower;
            bool hasUpper;
            bool hasNum;
            bool hasMin;
            bool hasMax;
            bool hasSpecial;

            //PASSWORD 
            static bool goodUsername(string username)
            {
                bool hasLength = username.Length >= MIN_LENGTH;
                if (!hasLength) Console.WriteLine("Needs at least minimum 7 characters");

                bool hasSymbol = false;

                foreach (char c in SYMBOLS)
                {
                    if (username.Contains(c))
                    {
                        hasSymbol = true;
                        break;
                    }
                }
                if (!hasSymbol) Console.WriteLine($"Needs any of the following special characters: ! @ # $ % ^ & *  : {SYMBOLS}");

                bool hasUpper = false;
                bool hasLower = false;
                for (int i = 0; i < username.Length; i++)
                {
                    string s = username[i] + "";
                    if (Char.IsLetter(username[i]))
                    {
                        hasUpper = s.ToUpper() == s ? true : hasUpper;
                        hasLower = s.ToLower() == s ? true : hasLower;
                    }
                }

                ////bool hasNum = false;
                //for (int i = 0; i < password.Length; i++)
                //{
                //    string s = password[i] + "";
                //    if (char.IsDigit(password[i]))

                //    {
                //        //hasNum = true;
                //        hasNum = s.hasNum() == s ? true : hasNum;
                //        break;
                //    }
                //}

                if (!hasUpper || !hasLower)
                { 
                    Console.WriteLine("Needs an uppercase and lowercase letter");
                
                }

                //else if (!hasNum)
                //{
                //    Console.WriteLine("Needs at least one number");
                //}

                return hasLength && hasSymbol && hasUpper && hasLower; //&& hasNum ;
            }


            //USERNAME
            public static void Main(string[] args)
            {
            
                Console.WriteLine("Hello! Please create a username with the following requirements. The password must contain: ");
                Console.WriteLine();
                Console.WriteLine("Must have letters and numbers");
                Console.WriteLine("Must have at least 5 letters");
                Console.WriteLine("Must be a length of 7 character minimum");
                Console.WriteLine("Must be no longer than 12 characters");
                Console.WriteLine("Any of the following special characters: ! @ # $ % ^ & * ");
                Console.WriteLine("Please enter username: ");
                Console.Read();

                string username = "";

                do
                {
                    username = Console.ReadLine();
                } while (!goodPassword(username));
                Console.WriteLine("username");
            }











        }

    }


}
       


            /*
            //USERNAME     
            Console.WriteLine("Please create a username with the following requirements. The username must contain: ");
            Console.WriteLine("Must have letters and numbers");
            Console.WriteLine("Must have at least 5 letters");
            Console.WriteLine("Must be a length of 7 character minimum");
            Console.WriteLine("Must be no longer than 12 characters");
            Console.WriteLine("Any of the following special characters: ! @ # $ % ^ & * ");
            Console.WriteLine("Please enter username: ");
            Console.Read();


        

 




//ADD VALID PASSWORD TO PASSWORD ARRAY if it doesn't already exist


/*

If user name doesn't already exist add them to list and add password in the same position


If any of these rules are violated, print an error message show the first rule that does not get met


Extended: When a username or password does not meet the validation rules, print ALL rules that they fail to meet. 


*/
