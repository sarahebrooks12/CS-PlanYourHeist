using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // option 1 - while loop --- keep adding members over and over
            // option 2 - add method to reprint main menu below Program
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("1. Enter New Team Member");
            Console.WriteLine("2. View your team");
            Console.WriteLine("3. Let's go rob a bank!");
            Console.WriteLine("4. I'd rather register to vote");
            string response = Console.ReadLine();
            List<TeamMember> Team = new List<TeamMember>();
            TeamMember inputTeamMember = new TeamMember();
            bool nameBool = true;
            while (nameBool == true)
            {
                if (response == "1")
                {
                    Console.WriteLine("What's the team member's first name?");
                    inputTeamMember.name = Console.ReadLine();

                    while (inputTeamMember.skillLevel <= 0)
                    {
                        Console.WriteLine("What's the team member's skill level?");
                        try
                        {
                            inputTeamMember.skillLevel = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a skill level of 1 or more. (must be a postive integer)");
                        }
                    };
                    bool courageBool = false;
                    while (inputTeamMember.courageLevel < 0.0 || inputTeamMember.courageLevel > 2.0 || courageBool == false)
                    {
                        courageBool = true;
                        Console.WriteLine("What's the team member's courage level 0.0-2.0?");
                        try
                        {
                            inputTeamMember.courageLevel = Double.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a courage level between 0.0 and 2.0. (Must be a decimal)");
                        }
                    };



                    Console.WriteLine($"Your team member's name is {inputTeamMember.name}. They're skill level is {inputTeamMember.skillLevel} and their courage level is {inputTeamMember.courageLevel}");

                    TeamMember newMember = new TeamMember()
                    {
                        name = inputTeamMember.name,
                        skillLevel = inputTeamMember.skillLevel,
                        courageLevel = inputTeamMember.courageLevel
                    };

                    Team.Add(newMember);
                    inputTeamMember.skillLevel = 0;
                    Team.ForEach(member => Console.WriteLine(member.name + ","));

                }



            }
            Console.WriteLine();











        }
    }
}
