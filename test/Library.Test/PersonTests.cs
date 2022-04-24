using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void InvalidNumbersIdTest() // Testeamos que con una ID invalida no se asigne a la instancia person el valor de ID.
        {
            Person person = new Person("Santiago Ferraro", "399-323-3");
            Assert.That(person.ID == null);
        }

        [Test]
        public void InvalidLengthIdTest() // Testeamos que con una ID invalida no se asigne a la instancia person el valor de ID.
        {
            Person person = new Person("Santiago Ferraro", "3939-323-3");
            Assert.That(person.ID == null);
        }

        [Test]
        public void InvalidFormatIdTest() // Testeamos que con una ID invalida no se asigne a la instancia person el valor de ID.
        {
            Person person = new Person("Santiago Ferraro", "3933233");
            Assert.That(person.ID == null);
        }

        [Test]
        public void ValidIdTest() // Testeamos que con una ID valida se asigne a la instancia person el valor de ID.
        {
            Person person = new Person("Santiago Ferraro", "5-307-722-8");
            Assert.That(person.ID == "5-307-722-8");
        }

        [Test]
        public void InvalidNameTest() // Testeamos que con un nombre invalido no se asigne a la instancia person el valor de name.
        {
            Person person = new Person("", "5-307-722-8");
            Assert.That(person.Name == null);
        }

        [Test]
        public void ValidNameTest() // Testeamos que con un nombre valido se asigne a la instancia person el valor de name.
        {
            Person person = new Person("Santiago Ferraro", "5-307-722-8");
            Assert.That(person.Name == "Santiago Ferraro");
        }
    }
}