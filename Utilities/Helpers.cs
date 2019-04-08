using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities {
    static class Helpers {

        public static int mod(int num, int div) {

            while (num > div)
                num -= div;

            while (num < 0)
                num += div;

            return num;
        }

    }
}
