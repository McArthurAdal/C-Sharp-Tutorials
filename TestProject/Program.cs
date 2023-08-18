Random rand = new Random(1,11);

int healthHero, healthMonster = 10;
int attack = 0;
bool drained = false;

Console.WriteLine($"Fight Beginning...\nHero health: {healthHero}");
Console.WriteLine($"Monster health: {healthMonster}")

do
{
//let hero make first attack
attack = rand.Next();
Console.WriteLine("Hero attacking monster...");
healthMonster -= attack;
Console.WriteLine($"Health lost: {attack}, health remaining: {healthMonster}");

// If monster health is available fight back
if (healthMonster > 0)
{
	Console.WriteLine("Monster attacking hero...");
	attack = rand.Next();
	healthHero -= attack;
	Console.WriteLine($"Health lost: {attack}, health remaining: {healthHero}");
}
// If hero dies first
else if (healthHero <=0) 
{
	drained = true;
	Console.WriteLine("Hero lost, no health remaining");
}
//If monster dies first
else if (healthMonster <=0)
{
	drained = true;
	Console.WriteLine("Monster lost, no health remaining");

}
while (drained == false);