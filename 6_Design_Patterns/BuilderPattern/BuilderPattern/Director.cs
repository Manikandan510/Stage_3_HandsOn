using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Director
    {
        public void Construct(Builder builder) 
        {
            builder.BuildSavory();
            builder.BuildSweet();
        }
    }
}
