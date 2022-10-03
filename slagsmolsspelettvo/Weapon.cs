using System;

public class Weapon {
    public string name;
    private Random ADgenerator;

    public Weapon() {
        ADgenerator = new Random();

    }

    public int DamageTaken()
    {
    return ADgenerator.Next(10, 20);
    }

}