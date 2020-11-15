using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    //ограничить атрибут на применение только для классов
    [AttributeUsage(AttributeTargets.Class)]
    public class ExportClass : Attribute
    {
    }
}
