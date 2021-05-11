using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Full_GRASP_And_SOLID.Library;


namespace Library.Test
{
    public class RecipeTest
    {

        private IList<Step> steps;
        private Product FinalProduct;
        private Recipe recipe;
        private Product product;
        private double quantity;
        private Equipment equipment;
        private int time;
        private Step step;

        [SetUp]
        public void Setup()
        {
            //ARRANGE
            this.FinalProduct = new Product("Torta Helada", 30.0);
            this.recipe = new Recipe();

            this.product = new Product("Helado", 40);
            this.quantity = 10;
            this.equipment = new Equipment("Heladera", 50);
            this.time = 60;
            this.step = new Step(this.product, this.quantity, this.equipment, this.time);
        }

        [Test]
        public void GetTextToPrintIsNotNull()
        // Test para verificar que get text to print no es nulo.
        {
            //ACT
            recipe.AddStep(step);
            recipe.FinalProduct = FinalProduct;
            //ASSERT
            Assert.IsNotNull(recipe.GetTextToPrint());
        }

        [Test]
        public void GetProductionCostReturnsDoubleTest()
        // Verifica que el valor retornado por la función sea del tipo double.
        {
            Assert.IsInstanceOf(typeof(double), recipe.GetProductionCost());
        }

        [Test]
        public void GetProductionCostReturnsWrightCalculation()
        // Verifica que el método devuelva el cálculo correcto.
        {
            // ACT
            int valorEsperado = 3400;
            recipe.AddStep(step);
            recipe.FinalProduct = FinalProduct;
            //ASSERT
            Assert.AreEqual(valorEsperado, step.GetStepCost());
        }
    }
}