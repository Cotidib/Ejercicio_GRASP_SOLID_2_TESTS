using NUnit.Framework;
using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;


namespace Library.Test
{
    public class StepTest
    {
        private Step step;
        private Product product;
        private double quantity;
        private Equipment equipment;
        private int time;

        [SetUp]
        public void Setup()
        {
            //ARRANGE
            this.product = new Product("Helado", 40);
            this.quantity = 10;
            this.equipment = new Equipment("Heladera", 50);
            this.time = 60;
            this.step = new Step(product, quantity, equipment, time);

        }

        [Test]
        public void StepCostIsDouble() 
        // Test para corroborar que el método devuelva un valor del tipo double.
        {
           //Assert
           Assert.IsInstanceOf(typeof(double), step.GetStepCost());
        }

        [Test]
        public void CorrectStepCost() 
        // Test para verificar que el cálculo del costo sea correcto.
        {
            // ACT
            double calculo = (product.UnitCost * this.quantity) + (equipment.HourlyCost * this.time);
            //ASSERT
            Assert.AreEqual(calculo, step.GetStepCost());
        }

        [Test]
        public void SetQuantity() 
        // Test para validar que el atributo quantity se modifica correctamente.
        {
            //Act
            this.quantity = 20;
            //Assert
            Assert.AreEqual(20, this.quantity); 
            
        }

        [Test]
        public void GetQuantity()
        // Test para corroborar que el valor de quantity que devuelve sea correcto.
        {
            //Assert
            Assert.AreEqual(10, this.quantity);
        }

        [Test]
        public void SetTime() 
        // Test para validar que el atributo time se modifica correctamente.
        {
            //Act
            this.time = 120;
            //Assert
            Assert.AreEqual(120, this.time); 
            
        }

        [Test]
        public void GetTime()
        // Test para corroborar que el valor de time que devuelve sea correcto.
        {
            //Assert
            Assert.AreEqual(60, this.time);
        }

    }
}