using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcilator
{
    internal class Test
    {
        [Test]
        public void Add_TwoPlusTwo_ReturnsFour()
        {
            var calc = new Calculator();
            Assert.That(calc.Add(2, 2), Is.EqualTo(4));
        } 
    }
}
