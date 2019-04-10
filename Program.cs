using System;
using System.Collections;
using static Utilities.Helpers;
using Utilities;
using System.IO;
class Program {
    static void Main(string[] args) {
        Console.WriteLine(Directory.GetCurrentDirectory());

        Game game = new Game(1200);
        game.Run();
        //Make an object of Game that extends Base for the game logic

        //float[][] white = PerlinNoise.GenerateWhiteNoise(1200, 700);
        //float[][] perlin = PerlinNoise.GeneratePerlinNoise(white, 2);
        //for (int i = 0; i < 20; i++) {
        //    for (int j = 0; j < 5; j++) {
        //        Console.Write(perlin[i][j] + "\t");
        //    }
        //    Console.WriteLine();
        //}

    }
}

