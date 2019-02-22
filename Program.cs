using System;

    namespace URLEncoder
    {
        class Program
        {
            static void Main(string[] args){
                
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
                console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", FPN, FPA);
                
                
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
                First Check = Output;
                return Output;
         }
