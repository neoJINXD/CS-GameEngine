using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;
using UI;


namespace GameStateSystem {
    class MainMenu : BaseState{

        private RenderWindow win;

        public static Font fnt;
        Button strt;
        Text title;
        Text buttonTxt;

        public MainMenu(RenderWindow passedWin){
            win = passedWin;
            win.KeyPressed += OnKeyPressed;
            win.MouseButtonPressed += OnMousePressed;
            
        }

        public void Initialize() {
            title = new Text("MAIN MENU", fnt, 64);
            title.Position = new Vector2f(win.Size.X / 2 - title.GetLocalBounds().Width/2, win.Size.Y / 4);
            strt = new Button((int)win.Size.X / 2 - 150, (int)win.Size.Y / 2 -50, 300, 100, "PLAY", fnt);
        }

        public void LoadContent() {

            fnt = new Font("../../../UI/Blacklisted.ttf");
        }

        public void Render() {
            win.Draw(title);
            win.Draw(strt);
        }

        public void Tick() {
            strt.highlight(win);
            
        }
        private void OnKeyPressed(object sender, KeyEventArgs e) {
            //Handling Keyboard input
            if (e.Code == Keyboard.Key.Escape) {
                win.Close();
            }
            
        }

        private void OnMousePressed(object sender, MouseButtonEventArgs e) {
            if (e.Button == Mouse.Button.Left && strt.selectedCheck(win)) {
                win.KeyPressed -= OnKeyPressed;
                win.MouseButtonPressed -= OnMousePressed;

                Game.state.Pop();
                Game.stateAdd(new InGame(win));
                
            }
        }

    }
}
