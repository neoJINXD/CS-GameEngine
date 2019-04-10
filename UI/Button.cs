using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;

namespace UI {
    class Button : Drawable {
        private RectangleShape button;

        private readonly int x;
        private readonly int y;
        private readonly int width;
        private readonly int height;

        private Color highlighted = new Color(201, 201, 201);
        private Color normal = new Color(86, 86, 86);


        private Font font;
        private Text txt;

        public Button(int xPos, int yPos, int width, int height, string text, Font font) {
            this.font = new Font(font);
            this.txt = new Text(text, this.font);

            this.x = xPos;
            this.y = yPos;
            this.width = width;
            this.height = height;

            this.button = new RectangleShape(new Vector2f(this.width, this.height));

            button.Position = new Vector2f(this.x, this.y);
            button.FillColor = normal;
            txt.Position = new Vector2f((this.x + this.width) - (txt.Scale.X / 2), (this.y + this.height) - (txt.Scale.Y / 2));
        }

        public bool selectedCheck(RenderWindow win) {
            
            Vector2i mousePos = Mouse.GetPosition(win);
            if (mousePos.X > this.x && mousePos.Y > this.y && mousePos.X < this.x + this.width && mousePos.Y < this.y + this.height) {
                return true;
            }

            return false;
        }

        public void highlight(RenderWindow win) {
            if (selectedCheck(win)) {
                button.FillColor = highlighted;
            }
            else {
                button.FillColor = normal;
            }
        }

        public void Draw(RenderWindow win) {
            win.Draw(this.button);
            win.Draw(this.txt);

            
        }

        public void Draw(RenderTarget target, RenderStates states) {
            ((Drawable)button).Draw(target, states);
        }
    }
}
