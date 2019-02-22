using System;

    namespace URLEncoder
    {
        public int CheckForBadCode(string CheckBC)
        {
            if (CheckBC == "%00"||"%01"||"%02"||"%03"||"%04"||"%05"||"%06"||"%07"||"%08"||"%09"){
                
                console.WriteLine("Not valid, Dat's a control character.");
                return 1;
            }
        }
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
