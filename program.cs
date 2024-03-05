// BTEC_UCAS_Points_Calculator

using System;

class UcasCalculator
{
    // Variable types
    static string btec_Grades_Input;
    static bool is_Valid_Input;
    static int total_Ucas_Points;

    // UCAS points
    const int ucas_Points_D = 48;
    const int ucas_Points_M = 32;
    const int ucas_Points_P = 16;

    static void Main()
    {
        Console.WriteLine("UCAS Points Calculator for BTEC Level 3 Extended Diploma");

        Console.WriteLine("Enter your BTEC grades (e.g., DDD):");

        btec_Grades_Input = Console.ReadLine()?.ToUpper(); // Use the null conditional operator ?.

        // Validate input
        is_Valid_Input = !string.IsNullOrEmpty(btec_Grades_Input) &&
                        btec_Grades_Input.Length == 3 &&
                        Is_Valid_Btec_Grade(btec_Grades_Input[0]) &&
                        Is_Valid_Btec_Grade(btec_Grades_Input[1]) &&
                        Is_Valid_Btec_Grade(btec_Grades_Input[2]);

        if (is_Valid_Input)
        {
            // Calculate UCAS points
            foreach (char grade in btec_Grades_Input)
            {
                if (grade != '\0') // Check for null character
                {
                    if (grade == 'D')
                    {
                        total_Ucas_Points += ucas_Points_D;
                    }
                    else if (grade == 'M')
                    {
                        total_Ucas_Points += ucas_Points_M;
                    }
                    else if (grade == 'P')
                    {
                        total_Ucas_Points += ucas_Points_P;
                    }
                }
            }

            // Display the result
            Console.WriteLine($"UCAS Points: {total_Ucas_Points}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid BTEC grades (DDD, DDM, etc.).");
        }
    }

    static bool Is_Valid_Btec_Grade(char grade)
    {
        // Validate individual BTEC grades (D, M, P)
        return grade == 'D' || grade == 'M' || grade == 'P';
    }
}

// reminder
// cd into project location on Windows
// code .

// dotnet new console 
// dotnet restore 
// dotnet run
