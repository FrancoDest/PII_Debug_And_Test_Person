using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    /// <summary>
    /// No agregue mas tests porque al ser un testing de caja blanca y poder ver el codigo me doy cuenta que 
    /// no hay mas que deba testear de forma util al menos.
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void Test1() // Pruebo que se ejecute con una cedula real que cumpla los requisitos
        {
            Person john = new Person("John Doe", "5.035.354-2");
            string esperado= "5.035.354-2";
            Assert.AreEqual(esperado, john.ID);
        }
        [Test]
        public void Test2() // Pruebo si enves de ponerle puntos dejo espacios con una cedula real
        {
            Person john = new Person("John Doe", "50353542");
            string esperado= "50353542";
            Assert.AreEqual(esperado, john.ID);
        }

        [Test]
        public void Test3() // Pruebo que se ejecute con una cedula real pero que le cambio un digito
        {
            Person john = new Person("John Doe", "5.035.354-1");
            string esperado= null;
            Assert.AreEqual(esperado, john.ID);
        }
        [Test]
        public void Test4() //Pruebo con la cedula real pero cambiandole dos digitos y el verificador para que sea valida
        {
            Person john = new Person("John Doe", "50253540");
            string esperado= "50253540";
            Assert.AreEqual(esperado, john.ID);
        }

        
    }
}