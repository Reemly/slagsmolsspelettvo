using System;

Heroes Champion = new Heroes();

Champion.name = "idk";
Champion.weapon = new Weapon();

Heroes Monster = new Heroes();
Monster.name = "rawr";
Monster.weapon = new Weapon();


Random generator = new Random();
while (Champion.hp > 0 && Monster.hp > 0)
{
    Console.WriteLine("fight start");
    Console.WriteLine($"{Champion.name}: {Champion.hp} || {Monster.name}: {Monster.hp}");

    Champion.Engage(Monster);
    Monster.Engage(Champion);
    








}


