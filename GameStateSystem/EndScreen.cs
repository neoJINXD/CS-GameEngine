using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;
using UI;

namespace GameStateSystem {
    class EndScreen : BaseState {

        private RenderWindow win;

        public static Font fnt;
        Button reset;
        Button exit;
        Text title;
        
        public EndScreen(RenderWindow passedWin) {
            win = passedWin;
            win.MouseButtonPressed += OnMousePressed;
            
        }

        public void Initialize() {
            title = new Text("GAME OVER", fnt, 64);
            title.Position = new Vector2f(win.Size.X / 2 - title.GetLocalBounds().Width / 2, win.Size.Y / 6);
            title.FillColor = Color.Black;
            reset = new Button((int)win.Size.X / 2 - 150, (int)win.Size.Y / 2 - 50, 300, 100, "BACK TO MENU", fnt);
            exit = new Button((int)win.Size.X / 2 - 150, (int)win.Size.Y / 2 + 200, 300, 100, "EXIT", fnt);
        }

        public void LoadContent() {
            fnt = new Font("../../../UI/Blacklisted.ttf");
        }

        public void Render() {
            win.Clear(Color.Red);
            win.Draw(title);
            win.Draw(reset);
            win.Draw(exit);
        }

        public void Tick() {
            reset.highlight(win);
            exit.highlight(win);
        }
        

        private void OnMousePressed(object sender, MouseButtonEventArgs e) {
            if (e.Button == Mouse.Button.Left && exit.selectedCheck(win)) {
                win.Close();
            }
            if (e.Button == Mouse.Button.Left && reset.selectedCheck(win)) {
                win.MouseButtonPressed -= OnMousePressed;

                Game.state.Pop();
                Game.stateAdd(new MainMenu(win));
            }
        }

    }
}

