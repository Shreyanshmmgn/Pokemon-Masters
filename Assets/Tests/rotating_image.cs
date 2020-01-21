using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class damage_calculator
    {

        [Test]
        public void sets_damage_tohalf_with_50_percent()
        {
            int finalDamage = DamageCalculator.CalculateDamage(10, 0.5f);

            //Asert
            Assert.AreEqual(5, finalDamage);
        }

    }
}
