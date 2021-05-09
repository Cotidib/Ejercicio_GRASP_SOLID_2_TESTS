using NUnit.Framework;
using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;


namespace Library.Test
{
    public class ProductTest
    {
        private Product product;

        [SetUp]
        public void Setup()
        {
            //Arrange
            this.product = new Product("Producto", 15.0);

        }

        [Test]
        public void SetUnitCost() 
        // Se prueba que el atributo UnitCost de la clase Product se asigne correctamente.
        {
          //Act
          product.UnitCost = 45.4;
          //Assert
          Assert.AreEqual(45.4, product.UnitCost); 
        }

        [Test]
        public void GetUnitCost() 
        // Se prueba que el atributo UnitCost de la clase Product se consulte correctamente.
        {
          //Assert
          Assert.AreEqual(15.0, product.UnitCost); 
        }

        [Test]
        public void SetDescription() 
        // Se prueba que el atributo Description de la clase Product se asigne correctamente.
        {
          //Act
          product.Description = "Nuevo producto";
          //Assert
          Assert.AreEqual("Nuevo producto", product.Description); 
        }

        [Test]
        public void GetDescription() 
        // Se prueba que el atributo Description de la clase Product se consulte correctamente.
        {
          //Assert
          Assert.AreEqual("Producto", product.Description); 
        }

        [Test]
        public void DescriptionCannotBeEmpty()
        //Se prueba que la Descripcion no sea vacía
        {
            //Assert
            Assert.IsNotEmpty(product.Description);
        }

        [Test]
        public void DescriptionIsString()
        //Se prueba que la Descripción ingresada en el constructor sea del tipo string
        {
            //Assert
            Assert.IsInstanceOf(typeof(string), product.Description);
        }

        [Test]
        public void UnitCostIsDouble()
        //Se prueba que el UnitCost ingresado en el constructor sea del tipo double 
        {
            //Assert
            Assert.IsInstanceOf(typeof(double), product.UnitCost);
        }

        [Test]
        public void UnitCostCannotBeNull()
        //Se prueba que el UnitCost no sea null
        {
            //Assert
            Assert.IsNotNull(product.UnitCost);
        } 
    }
}