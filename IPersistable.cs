using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Disaheim
{
    internal interface IPersistable
    {
        public void Save(string fileName);
        public void Load(string fileName);
    }
}
