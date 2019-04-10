using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;

abstract class Base {
    protected RenderWindow win;
    protected Color backgroundColor;

    public Base(uint width, uint height, string title, Color color) {
        this.win = new RenderWindow(new VideoMode(width, height), title);
        this.backgroundColor = color;
        win.SetFramerateLimit(60);
        win.Closed += OnClosed;

    }

    public void Run() {
        LoadContent();
        Initialize();
        while (win.IsOpen)
        {
            win.DispatchEvents();
            win.Clear(backgroundColor);

            Tick();

            Render();
            win.Display();
            
        }
    }
    protected abstract void LoadContent();  //Preload
    protected abstract void Initialize();   //Setup

    protected abstract void Tick();         //Update
    protected abstract void Render();       //Draw
    private void OnClosed(object sender, EventArgs e) {
        win.Close();
    }





}

