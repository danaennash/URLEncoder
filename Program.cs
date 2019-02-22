using System;
using System.Collections.Generic;

namespace URLEncoder
{
    class Program
    {
        static string urlFormat = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";
        //MAIN PROGRAM   
        static void Main(string[] args)
        {
            console.WriteLine("NAEK47 CUSTOM URL GENERATOR\n");
            
            do
            {
                console.Write("Enter project name: \n");
                    string projectName = GetUserInput();
                
                console.Write("Enter activity name: \n");
                    string activityName = GetUserInput();
                
                console.WriteLine(createURL(projectName,activityName));
                
                console.Write("Want another NAEK47 CUSTUM URL GENERATOR? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }
        
        
        //FUNCTIONS
        static string GetUserInput()                             
        {
	        string input = "";
	            do
	              {   
		            input = Console.ReadLine();
		            if (IsValid(input)) return input;
		            Console.Write("The input contains invalid characters. Enter again: ");
	              } while (true);
        }
        
        static bool IsValid(string input){
            
            foreach (char character in input.ToCharArray()){
                
                if(character >= 0x00 || character <= 0x1F)
                {
                    console.WriteLine("Can't use control characters. Try another option:\n");
                    return false;
                }
                else if(character == 0x7F)
                {
                    console.WriteLine("Can't use control characters. Try another option:\n");
                    return false;
                }
              
            }
            return true;
        }
        
        static string Encode(string value)
        {
            string EncodedValue = "";
            
            foreach (char character in value)
            {
                value = value.Replace(" ", "%20");
                value = value.Replace("<", "%3C");
                value = value.Replace(">", "%3E");
                value = value.Replace("#", "%23");
                value = value.Replace("%", "%25");
                //value = value.Replace(""", "%22");
                value = value.Replace(";", "%3B");
                value = value.Replace("/", "%2F");
                value = value.Replace("?", "%3F");
                value = value.Replace(":", "%3A");
                value = value.Replace("@", "%40");
                value = value.Replace("&", "%26");
                value = value.Replace("=", "%3D");
                value = value.Replace("+", "%2B");
                value = value.Replace("$", "%24");
                value = value.Replace(",", "%2C");
                value = value.Replace("{", "%7B");
                value = value.Replace("}", "%7D");
                value = value.Replace("|", "%7C");
                //value = value.Replace("\", "%5C");
                value = value.Replace("^", "%5E");
                value = value.Replace("[", "%5B");
                value = value.Replace("]", "%5D");
                value = value.Replace("`", "%60");
                                      
                EncodedValue = value;
            }                                    
            return EncodedValue;
        }
                                      
        static string CreateURL(string projectName, string activityName) {
            
            return String.Format(urlFormat, projectName, activityName);
        }
        
    }
}

