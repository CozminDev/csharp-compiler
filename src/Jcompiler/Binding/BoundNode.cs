﻿namespace Jcompiler.Binding
{
    public abstract class BoundNode
    {
        public abstract BoundNodeKind Kind { get; }
    }
}