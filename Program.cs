using System;

namespace URLEncoder
{
    class Program
    {
        static string UrlTemp = "https://companyserver.com/content/[project_name]/files/[activity_name]/[activity_name]Report.pdf";



        static void Main(string[] args)
        {
            firststep:
                Console.WriteLine("NAEK47 CUSTOM URL GENERATOR\n");
                Console.WriteLine("Wut is da project name:\n");
                string PN = Console.ReadLine();
                if (IsValid(PN) is false)
                    {
                        goto firststep;
                    }
                    PN = CheckInput(PN);

            nextstep:
                Console.WriteLine("Please enter an activity name:\n");
                string AN = Console.ReadLine();
                if (IsValid(AN) is false)
                    {
                        goto nextstep;
                    }
                    AN = CheckInput(AN);

                    Console.WriteLine(CustomURLMaker(PN, AN));

            finalstep:
                    Console.WriteLine("Want another NAEK Custom URL? (yes/no) ");
                    string respond = Console.ReadLine();

            switch (respond)
                    {
                        case "yes":
                                goto firststep;
                        case "no":
                                break;
                        default:
                                Console.WriteLine("Not an option. Try Again.\n");
                                goto finalstep;
                    }
        }

                static string CustomURLMaker(string PN, string AN)
                 {
                    return String.Format(UrlTemp, PN, AN);
                 }
        
        
         static string CheckInput(string input)
        {
            string[] illegal = new string[] { " ", "/", "?", ":", "@", ";", "&", "=", "+", "$", ",", "{", "}", "|", "\\", "^", "[", "]", "`" };
            string[] replacement = new string[] { "%20", "%2F", "%3F", "%40", "%3B", "%26", "%3D", "%2B","%24", "%2C", "%7B", "%7D", "%7C", "%5C", "%5E", "%5B", "%5D", "%60" };

            foreach (string element in illegal)
            {
                int index = Array.IndexOf(illegal, element);

                if (input.Contains(element))
                        {
                            input = input.Replace(element, replacement[index]);
                        }
            }
            return String.Format(input);
        }
        

        static bool IsValid(string input)
        {
            foreach (char character in input)
            {
                if (character <= 0x1F || character == 0x7F)
                {
                    Console.WriteLine("ERROR. Cannot Use Control Character. Try Again.");
                    return false;
                }
            }
            return true;
        }



    }
    
}
