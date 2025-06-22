using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework12;

public class Menu
{
    public static bool IsActive { get; set; }

    public static void Show()
    {
        Output.Header("Users data management system");
        Output.Prompt("To show all users data enter \"show\"");
        Output.Prompt("To add new user data - enter \"add\"");
        Output.Prompt("To exit this task - enter \"exit\"");
        Output.Message("Please enter a chosen option:");
    }

    public static void ReadInput()
    {
        switch (Console.ReadLine().ToLower())
        {
            case "exit":
                {
                    IsActive = false;
                    break;
                }
            case "show":
                {
                    
                    break;
                }
            case "add":
                {
                    DataProcessor.AddNewUserData();
                    Output.PressAndClear();
                    break;
                }
            default:
                {
                    Output.Warning("Invalid input. Try again:");
                    break;
                }
        }
    }
}
