using System;
using System.Collections.Generic;
using System.Text;

namespace IASteepestAscentHillClimbing.Classes
{
    class BackapackObject
    {
        public int value { get; set; }
        public int weight { get; set; }

        public BackapackObject(int value, int weight) {
            this.value = value;
            this.weight = weight;
        }
    }
}
