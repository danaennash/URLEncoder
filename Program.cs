using System;

    namespace URLEncoder
    {
        class Program
        {
            static void Main(string[] args){
                
                console.WriteLine("NAEK47 URL GENERATOR");
                string project_name = "";
                string project_activity = "";
                
                a:
                    console.WriteLine("Enter da project name:");
                    project_name = Console.ReadLine();
                    if(FirstCheck(project_name) == 1){
                        goto a;
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

        
