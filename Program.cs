using System;

    namespace URLEncoder
    {
        class Program
        {
            static void Main(string[] args){
                
                       public string UrlTemp = "https://companyserver.com/content/[project_name]/files/[activity_name]/[activity_name]Report.pdf (Links to an external site.)Links to an external site.";

                
                console.WriteLine("NAEK47 URL GENERATOR\n");
                string project_name = "";
                string project_activity = "";
                string FPN = "";
                string FPA = "";
                
                a:
                    console.WriteLine("Enter da project name:\n");
                    project_name = Console.ReadLine();
                    if(FirstCheck(project_name) == 1){
                        goto a;
                    }
                    project_name = EncodeInput(project_name,FPN);
                b:
                    console.WriteLine("Enter da activity name:\n");
                    project_activity = Console.ReadLine();
                    if(FirstCheck(project_activity) == 1){
                        goto b;
                    }
                    project_activity = EncodeInput(project_activity,FPA);
                
                console.WriteLine("A NAEK47 URL has been created:\n");
                
                c:
                    Console.WriteLine("Want another custom NAEK URL? (y/n) ");
                    string response = Console.ReadLine();
                
                switch (response)
            {
                case "y":
                    goto a;
                case "n":
                    break;
                default:
                    Console.WriteLine("You made an invalid choice.\n");
                    goto c;
            }
            }
        }
    }

        static bool FirstCheck(string FirstCheck)
        {
          foreach (char character in FirstCheck)
            {
                if (character <= 0x1F || character == 0x7F)
                {
                    Console.WriteLine("ERROR. Contains a control character, try again.");
                    return 1;
                }  
                else{
                    return 0;
                }
            }
        }
        
         string EncodeInput(string Input, string Output)
         {
                if (Input.Contains(" "))
                {
                Input = Input.Replace("%", "%20");
                }
             
                if (Input.Contains(";"))
                {
                Input = Input.Replace(";", "%3B");
                }
             
                if (Input.Contains("/"))
                {
                Input = Input.Replace("/", "%2F");
                }
             
                if (Input.Contains("?"))
                {
                Input = Input.Replace("?", "%3F");
                }
             
                if (Input.Contains(":"))
                {
                Input = Input.Replace(":", "%3A");
                }
             
                if (Input.Contains("@"))
                {
                Input = Input.Replace("@", "%40");
                }
             
                if (Input.Contains("&"))
                {
                Input = Input.Replace("&", "%3B");
                }
             
                if (Input.Contains("="))
                {
                Input = Input.Replace("=", "%3B");
                }
             
                if (Input.Contains("+"))
                {
                Input = Input.Replace("+", "%3B");
                }
             
                if (Input.Contains("$"))
                {
                Input = Input.Replace("$", "%3B");
                }
             
                FirstCheck = Output;
                return Output;
         }

        static string CreateUrl(string FPN, string FPA)
        {
            return String.Format(UrlTemp, FPN, FPA);
        }
