using System;

namespace elevators
{
    public class Floor
    {
        public int num {get; set;}
        public bool upButton {get; set;}
        public bool downButton {get; set;}
        public Floor() {
            num = 0;
            upButton = false;
            downButton = false;
        }
    }
}
