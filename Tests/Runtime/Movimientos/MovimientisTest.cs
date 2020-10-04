using NicitaSoftware.Tools;
using UnityEngine;
using NUnit.Framework;

namespace NicitaSoftware.ToolsTests
{   
    public class MovimientosTest
    {
        [Test]
        public void AddComponentMovimientoHorizontal()
        {
            bool flag = false;
            var g = new GameObject().AddComponent<MovimientoHorizontal>();
            if (g.GetComponent <MovimientoHorizontal>()) flag = true;
            Assert.IsTrue(flag);
            Object.DestroyImmediate(g.gameObject);
        }

        [Test]
        public void AddComponentMovimientoContinuo()
        {
            bool flag = false;
            var g = new GameObject().AddComponent<MovimientoContinuo>();
            if (g.GetComponent<MovimientoContinuo>()) flag = true;
            Assert.IsTrue(flag);
            Object.DestroyImmediate(g.gameObject);
        }

        [Test]
        public void AddComponentRotacionContinua()
        {
            bool flag = false;
            var g = new GameObject().AddComponent<RotacionContinua>();
            if (g.GetComponent<RotacionContinua>()) flag = true;
            Assert.IsTrue(flag);
            Object.DestroyImmediate(g.gameObject);
        }

    }
}
