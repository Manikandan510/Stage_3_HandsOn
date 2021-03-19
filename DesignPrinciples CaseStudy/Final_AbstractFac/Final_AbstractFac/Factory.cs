using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AbstractFac
{
    public interface Factory
    {
        void makeOrder(Channel channel,Product product);
    }
}
