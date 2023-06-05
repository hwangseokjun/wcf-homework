using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC.IoC
{
    public sealed class Container
    {
        private Container _instance;
        private readonly object _lock = new object();

        public Container Instance 
        {
            get => _instance;
        }

        private Container()
        {

        }
    }
}
