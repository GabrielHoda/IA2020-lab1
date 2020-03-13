using System;
using System.Collections.Generic;
using System.Text;

namespace IASteepestAscentHillClimbing.Classes
{
    class Backpack
    {
        public static int capacity { get; set; }
        public static int objectNumber { get; set; }
        public static List<BackapackObject> objectsList { get; set; }

        public static void initializeBackpack()
        {
            objectsList = new List<BackapackObject>();
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\gabrielh\\source\\repos\\IASteepestAscentHillClimbing\\IASteepestAscentHillClimbing\\Input\\backpack200.txt");
            objectNumber = Int32.Parse(lines[0]);
            for (int i = 1; i <= objectNumber; i++)
            {
                string[] line = lines[i].Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var x = Int32.Parse(line[1]);
                var y = Int32.Parse(line[2]);
                var z = new BackapackObject(x, y);
                objectsList.Add(z);
            }
            capacity = Int32.Parse(lines[objectNumber+1]);
        }
    }
}
