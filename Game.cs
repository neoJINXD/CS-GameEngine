using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;

class Game : Base {

    
    public Game(uint size) : base(size, size, "title", Color.Black) {
        

        win.KeyPressed += OnKeyPressed;
    }

    protected override void LoadContent() {
        //Load up files
        //Like images, tilemap...

    }

    protected override void Initialize() {
        //Setup initial state
        //Perhaps the game menu when fully done

    }

    protected override void Tick() {
        //Updates the game
        
    }

    protected override void Render() {
        //Whatever you need to draw
        
    }
    private void OnKeyPressed(object sender, KeyEventArgs e) {
        //Handling Keyboard input

        if (e.Code == Keyboard.Key.Escape) {
            win.Close();
        }

    }
}

