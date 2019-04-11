using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;
using Utilities;

namespace GameStateSystem {
    class InGame : BaseState {
        private RenderWindow win;

        Font local;
        private FPSCounter fps;
        Text fpsCounter;
        //private string fps;
        //RectangleShape test;
        public InGame(RenderWindow passedWin) {
            win = passedWin;
            //test = new RectangleShape(new Vector2f(400, 400));
            //test.Position = new Vector2f(600,600);
        }

        public void LoadContent() {
            //Load up files
            //Like images, tilemap...
            win.KeyPressed += OnKeyPressed;
            local = MainMenu.fnt;
        }

        public void Initialize() {
            //Setup initial state
            fps = new FPSCounter();
            fpsCounter = new Text("0", local, 20);
            fpsCounter.Position = new Vector2f(0, 0);
        }

        public void Tick() {
            //Updates the game
            
            Console.WriteLine(fps.getFps());
            
            win.Clear(Color.Black);
            

        }

        public void Render() {
            //Whatever you need to draw
            win.Draw(fpsCounter);
            //win.Draw(test);
        }
        private void OnKeyPressed(object sender, KeyEventArgs e) {
            //Handling Keyboard input

            if (e.Code == Keyboard.Key.Escape) {
                win.KeyPressed -= OnKeyPressed;
                Game.stateAdd(new PauseMenu(win));
            }

            if (e.Code == Keyboard.Key.Slash) {
                win.KeyPressed -= OnKeyPressed;
                Game.state.Pop();
                Game.stateAdd(new EndScreen(win));
            }
        }
    }
}
