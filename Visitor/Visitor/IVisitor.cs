﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IVisitor
    {
        void Visit(IElement element);
    }
}
