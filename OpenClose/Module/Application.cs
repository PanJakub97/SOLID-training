using System;
using System.Collections.Generic;
using System.Linq;
using static OpenClose.Module.ShapeType;

namespace OpenClose.Module

{
    public class Application
    {
        public void Render(List<Shape> shapes)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Render();
            }
        }
    }
}
