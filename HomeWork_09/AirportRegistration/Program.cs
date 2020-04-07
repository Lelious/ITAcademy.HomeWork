using System;

namespace Airport_Registration
{
    class Program
    {
        static Person p = new Person();
        static readonly ConsoleSystemMessages message = new ConsoleSystemMessages();

        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            Console.WriteLine((hour <= 16 || hour >= 6 ? (hour < 6 || hour > 10 ? "Добрый день! " : "Доброе утро! ") : "Добрый вечер! ") + message.greetingsMessage + "\n" + message.beforeReg);

            while (true)
            {
                string str = Console.ReadLine();

                if (!str.Equals("да") && !str.Equals("нет"))
                {
                    Console.WriteLine(message.chechInFail);                                                             
                }  
                else
                {
                    if (str.Equals("нет"))
                    {
                        Change_Registry(p.SecurityCheck, p.PassportCheck, p.CheckInStatus);
                    }

                    if (str.Equals("да"))
                    {
                        CheckIn_Method();
                    }
                }
            }
        }

        static void Passport_Check()
        {
            Console.WriteLine(message.passportCheck);
            Console.Write(p.SecondName + " " + p.FirstName + "\n" + message.passportCheckMessage + p.PassportID + "\nверно?");

            string str = Console.ReadLine();

            while (!str.Equals("да"))
            {
                Console.WriteLine(message.passportCheckRedirect);

                p.PassportID = Console.ReadLine();
                Passport_Check();
            }

            Console.WriteLine(message.chechInSucsess);
            p.PassportCheck = true;
            Change_Registry(p.SecurityCheck, p.PassportCheck, p.CheckInStatus);
        }

        static void Security_Check()
        {
            Console.WriteLine(message.securityCheck);

            while (true)
            {
                Console.WriteLine(message.securityCheckMessage);

                string str = Console.ReadLine();

                if (str.Equals("да"))
                {
                    Console.WriteLine(message.securityCheckFail);
                }

                if (str.Equals("нет"))
                {
                    Console.WriteLine(message.chechInSucsess);

                    p.SecurityCheck = true;
                    Change_Registry(p.SecurityCheck, p.PassportCheck, p.CheckInStatus);
                }
                if (!str.Equals("да") && !str.Equals("нет"))
                {
                    Console.WriteLine(message.chechInFail);
                }                
            }           
        }

        static void CheckIn_Method()
        {
            Console.WriteLine(message.checkInMessage);
            Console.WriteLine(message.enterFirstName);

            for (p.FirstName = Console.ReadLine(); p.FirstName.Length <= 0; p.FirstName = Console.ReadLine())
            {
                Console.WriteLine(message.chechInFail);
            }
                
            Console.WriteLine(message.enterSecondName);

            for (p.SecondName = Console.ReadLine(); p.SecondName.Length <= 0; p.SecondName = Console.ReadLine())
            {
                Console.WriteLine(message.chechInFail);
            }

            Console.WriteLine(message.enterPassportNumber);

            for (p.PassportID = Console.ReadLine(); p.PassportID.Length <= 0; p.PassportID = Console.ReadLine())
            {
                Console.WriteLine(message.chechInFail);
            }
                
            Console.WriteLine(message.chechInSucsess);

            p.CheckInStatus = true;
            Change_Registry(p.SecurityCheck, p.PassportCheck, p.CheckInStatus);
        }

        static void Change_Registry(bool passCheck, bool securCheck, bool checkIn)
        {
            if (p.PassportCheck && p.SecurityCheck && p.CheckInStatus)
            {
                Console.WriteLine(message.sucsessLastMessage);
                Console.ReadKey();
            }

            while (true)
            {
                Console.WriteLine(string.Format("{0} Check-in: {1}\n Security-check: {2}\n Passport-check: {3}", message.changeRegistry, p.CheckInStatus, p.SecurityCheck, p.PassportCheck));
                Console.WriteLine(message.setProcedure);

                string str = Console.ReadLine();

                if (str.Equals("Check-in"))
                {
                    if (p.CheckInStatus)
                    {
                        Console.WriteLine(message.notAvailable);
                        Change_Registry(p.SecurityCheck, p.PassportCheck, p.CheckInStatus);
                    }
                    else
                    {
                        CheckIn_Method();
                    }
                }

                if (str.Equals("Security-check"))
                {
                    if (p.SecurityCheck)
                    {
                        Console.WriteLine(message.notAvailable);
                    }
                    else
                    {
                        Security_Check();
                    }
                }

                if (!str.Equals("Passport-check"))
                {
                    if (p.PassportCheck)
                    {
                        Console.WriteLine(message.notAvailable);
                    }
                    else
                    {
                        Passport_Check();
                    }
                }
                Console.WriteLine(message.chechInFail);
            }                        
        }
    }
}
