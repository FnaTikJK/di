﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudContainer.Algorithm
{
    public interface ICloudLayouter
    {
        public List<(Rectangle rectangle, string text)> FindRectanglesPositions();
    }
}