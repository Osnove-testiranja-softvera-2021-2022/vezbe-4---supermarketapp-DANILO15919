using NUnit.Framework;
using OTS_Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Test
{
    [TestFixture]
    public class CartTest
    {
        [Test]

        public void AddOneToChart_OKInput_Succes()
        {
            Cart cart = new Cart();
            Keyboard keyboard = new Keyboard();

            cart.AddOneToChart(keyboard);

            Assert.AreEqual(1,cart.size);
        }

        [Test]

        public void AddOneToCart_SizeGreaterThen10_Success()
        {
            Cart cart = new Cart();
            Keyboard keyboard1 = new Keyboard();
            Keyboard keyboard2 = new Keyboard();
            Keyboard keyboard3 = new Keyboard();
            Keyboard keyboard4 = new Keyboard();
            Keyboard keyboard5 = new Keyboard();
            Keyboard keyboard6 = new Keyboard();
            Keyboard keyboard7 = new Keyboard();
            Keyboard keyboard8 = new Keyboard();
            Keyboard keyboard9 = new Keyboard();
            Keyboard keyboard10 = new Keyboard();

            cart.AddOneToChart(keyboard1);
            cart.AddOneToChart(keyboard2);
            cart.AddOneToChart(keyboard3);
            cart.AddOneToChart(keyboard4);
            cart.AddOneToChart(keyboard5);
            cart.AddOneToChart(keyboard6);
            cart.AddOneToChart(keyboard7);
            cart.AddOneToChart(keyboard8);
            cart.AddOneToChart(keyboard9);
            cart.AddOneToChart(keyboard10);

            Monitor monitor = new Monitor();

            Exception ex = Assert.Throws<Exception>(() => cart.AddOneToChart(monitor));

            Assert.That(ex.Message, Is.EqualTo("Nova greska"));
        }

        [Test]
        public void AddMultipleToChart_OKInput_Succes()
        {
            Cart cart = new Cart();
            Keyboard keyboard = new Keyboard();

            cart.AddMultipleToChart(keyboard , 3);

            Assert.AreEqual(3, cart.size);
        }
    }
}
