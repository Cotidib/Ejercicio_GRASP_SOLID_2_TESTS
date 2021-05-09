using NUnit.Framework;
using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;


namespace Library.Test
{
    public class EquipmentTest
    {

        private Equipment equipment;

        [SetUp]
        public void Setup()
        {
            this.equipment = new Equipment("Esto es una descripción", 50.0); 
        }

        [Test]
        public void ValidateDescription() 
        // Verificar que el atributo Description de la clase Product sea correcto.
        {
            //Act
            equipment.Description = "Descripción modificada";
            //Assert
            Assert.AreEqual("Descripción modificada", equipment.Description);
        }

        [Test]
        public void ValidateHourlyCost() 
        // Verificar que el atributo HourlyCost de la clase Product sea correcto.
        {
            //Act
            equipment.HourlyCost = 60.0;
            //Assert
            Assert.AreEqual(60.0, equipment.HourlyCost);
        }

        [Test]
        public void DescriptionIsString()
        // Validar que la descripción sea del tipo string.
        {
            Assert.IsInstanceOf(typeof(string), equipment.Description);
        }

        [Test]
        public void DescriptionNotEmpty()
        // Verifica que la descripción no esté vacía.
        {
            Assert.IsNotEmpty(equipment.Description);
        }

        [Test]
        public void HourlyCostIsDouble()
        // Verifica que el HourlyCost sea del tipo double.
        {
            Assert.IsInstanceOf(typeof(double), equipment.HourlyCost);
        }

        [Test]
        public void HourlyCostNotNull()
        // Verifica que HourlyCost no sea nulo.
        {
            Assert.IsNotNull(equipment.HourlyCost);
        }
    }
}