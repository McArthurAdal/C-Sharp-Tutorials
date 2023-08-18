int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

int[][] students = new int [][] {sophiaScores,andrewScores,emmaScores,loganScores};
decimal[] averages = new decimal[4];

int totalScore = 0;
int numberOfSubjects = 5;

int i = 0;
foreach (int[] student in students) 
{
	totalScore = 0;

	foreach (int score in student)
	{
		totalScore += score;
	}

	// Calculate average score for the current student.

	averages[i] = (decimal)totalScore/numberOfSubjects;

	// Move to the next student
	i++;
}

foreach (decimal avg in averages)
{
	Console.WriteLine(avg);
}