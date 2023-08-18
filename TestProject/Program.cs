
Random rand = new Random(123);

int healthHero = 100;
int healthMonster = 100;
int attack = 0;
bool drained = false;

Console.WriteLine($"Fight Beginning...\nHero health: {healthHero}");
Console.WriteLine($"Monster health: {healthMonster}");

do
{
//let hero make first attack
attack = rand.Next(1,11);
Console.WriteLine("Hero attacking monster...");
healthMonster -= attack;
Console.WriteLine($"Health lost: {attack}, health remaining: {healthMonster}");

// If monster health is available fight back
if (healthMonster > 0)
{
	Console.WriteLine("Monster attacking hero...");
	attack = rand.Next(1,11);
	healthHero -= attack;
	Console.WriteLine($"Health lost: {attack}, health remaining: {healthHero}");
}
//If monster dies first
else if (healthMonster <=0)
{
	drained = true;
	Console.WriteLine("Monster lost, no health remaining");

}
// If hero dies first
if (healthHero <=0) 
{
	drained = true;
	Console.WriteLine("Hero lost, no health remaining");
}
}
while (drained == false);