using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class Builder
    {
        public abstract void BuildSavory();
        public abstract void BuildSweet();
        public abstract Items GetItems();
    }
}
