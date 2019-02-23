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
            Console.WriteLine("NAEK47 CUSTOM URL GENERATOR\n");
            
            do
            {
                Console.Write("Enter project name: \n");
                    string projectName = GetUserInput();
                
                Console.Write("Enter activity name: \n");
                    string activityName = GetUserInput();
                
                Console.WriteLine(createURL(projectName,activityName));
                
                Console.Write("Want another NAEK47 CUSTUM URL GENERATOR? (y/n): ");
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
        
         static bool IsValid(string input)
        {
            foreach (char character in input)
            {
                if (character <= 0x1F || character == 0x7F)
                {
                    Console.WriteLine("Can't contain control characters. Try another option! ");
                    return false;
                }
            }
            return true;
        }

        
        /*static string Encode(string value)
        {
            string EncodedValue = "";
            
            foreach (char character in value.ToCharArray())
            {
		    
		    
		if(value.Contains(" "))
		{
                	value = value.Replace(" ", "%20");
		}
		    
		string charstring = character.ToString();
                EncodedValue += hex.GetValueOrDefault(charstring, charstring);
                value = value.Replace("<", "%3C");
                value = value.Replace(">", "%3E");
                value = value.Replace("#", "%23");
                value = value.Replace("%", "%25");
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
                value = value.Replace("^", "%5E");
                value = value.Replace("[", "%5B");
                value = value.Replace("]", "%5D");
                value = value.Replace("`", "%60");
            }                                    
            return EncodedValue;
        }*/
	    
	static Dictionary<string, string> hex = new Dictionary<string, string>()
        {
            {"<", "%3C"}, {">", "%3E"}, {"#", "%23"}, {"%", "%25" }, 
            {"\"", "%22"}, {";", "%3B"}, {"/", "%2F"}, {"?", "%3F"}, 
            {":", "%3A"}, {"@", "%40"}, {"=", "%3D"}, {"+", "%2B"}, 
            {"$", "%24"}, {",", "%2C"}, {"{", "%7B"}, {"}", "%7D"}, 
            {"|", "%7C"}, {"\\", "%5C"}, {"^", "%5E"}, {"[", "%5B"}, 
            {"]", "%5D"}, {"`", "%60"}, {" ", "%20"}
        };

        static string Encode(string value)
        {
            string encodedValue = "";
            foreach(char character in value.ToCharArray())
            {
                string charstring = character.ToString();
                encodedValue += hex.GetValueOrDefault(charstring, charstring);
            }
            return encodedValue;
        }    
                                      
        static string createURL(string projectName, string activityName)
	{   
            return String.Format(urlFormat, projectName, activityName);
        }
        
    }
}

