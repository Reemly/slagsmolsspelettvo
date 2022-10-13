using System;


public class Heroes
{
public int hp = 10;
public Weapon weapon;
public string name;

public void Engage(Heroes chosen) {
    int AD = weapon.DamageTaken();
chosen.hp -= AD;
chosen.hp = Math.Max(0, chosen.hp);
Console.WriteLine($"{name} do {AD} to {chosen.name}");
}
}


