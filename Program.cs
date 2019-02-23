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
            
            partOne:
            	Console.WriteLine("Enter project name:\n");
            	string projectName = Console.ReadLine();
            	if (IsValid(projectName) is false)
            		{
                		goto partOne;
            		}
            		projectName = Encode(projectName);

             partTwo:
            	Console.WriteLine("Enter the activity:\n");
            	string activityName = Console.ReadLine();
            	if (IsValid(activityName) is false)
            		{
                		goto partTwo;
            		}		
            		activityName = Encode(activityName);

            		Console.WriteLine(createURL(projectName, activityName));
                
               
              partThree:
                Console.WriteLine("Want another NAEK47 CUSTUM URL GENERATOR? (y/n): ");
		string answer = Console.ReadLine();

            	switch (answer)
            		{
                	case "y":
                   		 goto partOne;
                	case "n":
                    		break;
			default:
				Console.WriteLine("Not an option. Try again.");
				goto partThree;
			} 
        }
        
        
        //LIL DICTIONARY
	    
	static Dictionary<string, string> hex = new Dictionary<string, string>()
        	{
            		{"<", "%3C"},{">", "%3E"},{"#", "%23"},{"%", "%25" }, 
            		{"\"", "%22"},{";", "%3B"},{"/", "%2F"},{"?", "%3F"}, 
            		{":", "%3A"},{"@", "%40"},{"=", "%3D"},{"+", "%2B"}, 
            		{"$", "%24"},{",", "%2C"},{"{", "%7B"},{"}", "%7D"}, 
            		{"|", "%7C"},{"\\", "%5C"},{"^", "%5E"},{"[", "%5B"}, 
           		{"]", "%5D"},{"`", "%60"},{" ", "%20"}
        	};
	    
	//FUNCTIONS

        static bool IsValid(string input)
        {
            foreach(char character in input)
            {
                if (character <= 0x1F || character == 0x7F)
                {
		    Console.WriteLine("Cannot contain control characters. Try another option!");
                    return false;
                }
            }
            return true;
        }	   

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

