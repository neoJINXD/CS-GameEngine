using System;
using static Utilities.Helpers;
using Utilities;

class Program {
    static void Main(string[] args) {
        //Game game = new Game(1200);
        //game.Run();
        //Make an object of Game that extends Base for the game logic

        int times = 0;
        //PerlinNoise noise; 
        while (times < 20) {
            //noise = new PerlinNoise();
            double p = PerlinNoise.perlin(8.0, 8.0, 1.0);
            Console.WriteLine(p);
            times++;
        }
    }
}

