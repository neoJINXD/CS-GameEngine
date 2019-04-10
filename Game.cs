using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;
using GameStateSystem;

class Game : Base {

    public static Stack<BaseState> state = new Stack<BaseState>();

    public Game(uint size) : base(size, size, "Tilt", Color.Cyan) {
        state.Push(new MainMenu(win));

    }


    protected override void LoadContent() {
        //Load up files
        //Like images, tilemap...
        state.Peek().LoadContent();

    }

    protected override void Initialize() {
        //Setup initial state
        //Perhaps the game menu when fully done
        state.Peek().Initialize();
    }

    protected override void Tick() {
        //Updates the game
        state.Peek().Tick();
        foreach (BaseState i in state) 
            Console.WriteLine(i);
        Console.WriteLine();
        
    }

    protected override void Render() {
        //Whatever you need to draw
        state.Peek().Render();
    }

    public static void stateAdd(BaseState newState) {
        state.Push(newState);
        newState.LoadContent();
        newState.Initialize();
    }

}

