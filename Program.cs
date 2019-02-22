using System;

    namespace URLEncoder
    {
        class Program
        {
            static void Main(string[] args){
                
                console.WriteLine("NAEK47 URL GENERATOR");
                string project_name = "";
                string project_activity = "";
                
                console.WriteLine("Enter da project name:");
                project_name = Console.ReadLine();
                
                
                
            }
        }
    }

        public int FirstCheck(string FirstCheck)
        {
            if (FirstCheck == "%00"|| "%01"|| "%02"|| "%03"|| "%04"|| "%05"|| "%06"|| "%07"|| "%08"|| "%07"|| "%08"|| "%09"){
                
                console.WriteLine("Not valid, Dat's a control character.");
                return 1;
            }
            else if (FirstCheck == "%0A"|| "%0B"|| "%0C"|| "%0D"|| "%0E"|| "%0F"|| "%1A"|| "%1B"|| "%1C"|| "%1D"|| "%1E"|| "%1F"){
                
                console.WriteLine("Not valid, Dat's a control character.");
                return 1;
            }
            else if (FirstCheck == "%10"|| "%11"|| "%12"|| "%13"|| "%14"|| "%15"|| "%16"|| "%17"|| "%18"|| "%19"){
                
                console.WriteLine("Not valid, Dat's a control character.");
                return 1;
            }
            else{
                return 0;
            }
        }
