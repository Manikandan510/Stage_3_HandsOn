using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class ConcreteAdult : Builder
    {
        private Items items = new Items();
        public override void BuildSavory()
        {
            items.Add("Popcorn");
            items.Add("Veggie Chips");
        }

        public override void BuildSweet()
        {
            items.Add("Palkova");
            items.Add("Rasamalai");
        }

        public override Items GetItems()
        {
            return items;
        }
    }
}
