using System;
using System.Collections.Generic;
using System.Text;

namespace GameStateSystem
{
    interface BaseState {

        void LoadContent();
        void Initialize();
        void Render();
        void Tick();
}
}
