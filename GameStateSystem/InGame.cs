using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;

namespace GameStateSystem {
    class InGame : BaseState {
        private RenderWindow win;
        RectangleShape test;
        public InGame(RenderWindow passedWin) {
            win = passedWin;
            test = new RectangleShape(new Vector2f(400, 400));
            test.Position = new Vector2f(600,600);
        }

        public void LoadContent() {
            //Load up files
            //Like images, tilemap...
            win.KeyPressed += OnKeyPressed;

        }

        public void Initialize() {
            //Setup initial state
            //Perhaps the game menu when fully done

        }

        public void Tick() {
            //Updates the game
            win.Clear(Color.Black);

        }

        public void Render() {
            //Whatever you need to draw
            win.Draw(test);
        }
        private void OnKeyPressed(object sender, KeyEventArgs e) {
            //Handling Keyboard input

            if (e.Code == Keyboard.Key.Escape) {
                win.KeyPressed -= OnKeyPressed;
                Game.stateAdd(new PauseMenu(win));
                //win.Close();
            }
        }
    }
}
