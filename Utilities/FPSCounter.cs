using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;


namespace Utilities {
    class FPSCounter : Drawable {
        Clock clock;
        private static Time time;
        static double fps;

        public FPSCounter(){
            clock = new Clock();
        }

        public void update() {
            time = clock.ElapsedTime;
            
            fps = 1 / clock.ElapsedTime.AsSeconds();
            clock.Restart();
        }

        public double getFps() {
            update();
            return fps;
        }

        public void Draw(RenderTarget target, RenderStates states) {


        }
    }
}
