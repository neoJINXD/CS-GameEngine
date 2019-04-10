using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;
using UI;

namespace GameStateSystem {
    class PauseMenu : BaseState {
        private RenderWindow win;

        Font local;
        Text txt;
        Button exitButton;
        public PauseMenu(RenderWindow passedWin) {
            win = passedWin;
            
        }

        public void LoadContent() {
            //Load up files
            //Like images, tilemap...
            win.KeyPressed += OnKeyPressed;
            win.MouseButtonPressed += OnMousePressed;
            local = MainMenu.fnt;
        }

        public void Initialize() {
            //Setup initial state
            //Perhaps the game menu when fully done
            txt = new Text("PAUSED", local, 64) {
                OutlineColor = Color.Red
            };
            //Console.WriteLine(title.GetLocalBounds().Width);
            txt.Position = new Vector2f(win.Size.X / 2 - txt.GetLocalBounds().Width / 2, win.Size.Y / 6);
            exitButton = new Button((int)win.Size.X / 2 - 150, (int)win.Size.Y / 2 - 250, 300, 100, "EXIT", MainMenu.fnt);
        }

        public void Tick() {
            //Updates the game
            win.Clear(new Color(51,51,51,50));

        }

        public void Render() {
            //Whatever you need to draw
            win.Draw(txt);
            win.Draw(exitButton);
        }
        private void OnKeyPressed(object sender, KeyEventArgs e) {
            //Handling Keyboard input

            if (e.Code == Keyboard.Key.Escape) {
                Game.state.Pop();
                win.KeyPressed -= OnKeyPressed;
                Game.state.Peek().LoadContent();
                //win.Close();
            }
        }
        private void OnMousePressed(object sender, MouseButtonEventArgs e) {
            if (e.Button == Mouse.Button.Left && exitButton.selectedCheck(win)) {
                //Game.state.Pop();
                //Game.stateAdd(new InGame(win));
                win.Close();
            }
        }
    }
}