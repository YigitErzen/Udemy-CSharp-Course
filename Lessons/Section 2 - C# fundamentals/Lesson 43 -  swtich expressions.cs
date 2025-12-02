string convertPointsToGrade(int points)
{
    return points switch
    {
        >= 90 => "AA",
        >= 80 => "BB",
        >= 50 => "CC",
        _ => "DD",
    };
}


string grade = convertPointsToGrade(90);

Console.WriteLine(grade);


