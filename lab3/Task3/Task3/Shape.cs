﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Shape
    {
        public IGraphic graphic;
        public abstract void Draw();
    }
}
