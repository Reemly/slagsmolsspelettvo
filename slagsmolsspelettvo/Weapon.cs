using System;

public class Weapon {
    private Random ADgenerator;
    public string name;

    public Weapon() {
        ADgenerator = new Random();

    }

    public int DamageTaken()
    {
    return ADgenerator.Next(10, 20);
    }

}