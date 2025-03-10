﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Point
    {
        public int x;
        public int y;

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void move(Point newLocation) 
        {
          if(newLocation == null)
                throw new ArgumentNullException(nameof(newLocation));
            move(newLocation.x, newLocation.y);
        }
    }
}
