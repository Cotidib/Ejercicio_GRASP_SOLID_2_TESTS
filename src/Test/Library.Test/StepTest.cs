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
        private Recipe recipe;
        private static ArrayList productCatalog = new ArrayList();

        private static ArrayList equipmentCatalog = new ArrayList();

        [SetUp]
        public void Setup()
        {
            // this.recipe = new Recipe();
            //recipe.FinalProduct = GetProduct("Café con leche");
            //this.step = new Step(GetProduct("Café"), 100, GetEquipment("Cafetera"), 120);
        }

        [Test]
        public void StepCostIsDouble() // Test para corroborar que el método devuelva un valor del tipo double.
        {
           
           Assert.IsInstanceOf(typeof(double), step.GetStepCost());
        }

        [Test]
        public void CorrectStepCost() // Test para verificar que el cálculo del costo sea correcto.
        {

        }

        [Test]
        public void ValidateAtributes() // Test para validar los atributos del constructor.
        {

        }
    }
}