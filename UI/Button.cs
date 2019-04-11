using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;


namespace UI {
    class Button : Drawable {
        RectangleShape button;

        private readonly int x;
        private readonly int y;
        private readonly int width;
        private readonly int height;

        private Color highlighted = new Color(201, 201, 201);
        private Color normal = new Color(86, 86, 86);


        Font local;
        Text txt;

        public Button(int xPos, int yPos, int width, int height, string text, Font font) {
            local = new Font(font);
            txt = new Text(text, local, 32);

            this.x = xPos;
            this.y = yPos;
            this.width = width;
            this.height = height;

            button = new RectangleShape(new Vector2f(this.width, this.height));

            button.Position = new Vector2f(this.x, this.y);
            button.FillColor = normal;
            
            float x1 = this.x + txt.CharacterSize/2;
            float y1 = this.y + button.Size.Y/2 - txt.CharacterSize / 2;
            
            txt.Position = new Vector2f(x1, y1);
            txt.FillColor = Color.Black;
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

        

        public void Draw(RenderTarget target, RenderStates states) {
            ((Drawable)button).Draw(target, states);
            txt.Draw(target, states);
        }
    }
}
