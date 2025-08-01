using ICE2Indexers;

namespace Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestPokemonEvolution()
        {
            Pokemon pokemon = new Pokemon("Squirtle", "Water", "Ups water attacks when below 30% HP", "Grass, Electric", 19.8, 1.08);
            pokemon["name"] = "Wartortle";
            pokemon["weight"] = 49.6;
            pokemon["height"] = 3.03;

            Assert.AreEqual(pokemon[0], "Wartortle");
            Assert.AreEqual(pokemon[4], 49.6);
            Assert.AreEqual(pokemon[5], 3.03);
        }
        [TestMethod]
        public void TestPokemonNameChange()
        {
            Pokemon pokemon = new Pokemon("Squirtle", "Water", "Ups water attacks when below 30% HP", "Grass, Electric", 19.8, 1.08);
            pokemon[0] = "Ben";
            Assert.AreEqual(pokemon["name"], "Ben");
        }
        [TestMethod]
        public void TestPokemonEvolution2()
        {
            Pokemon pokemon = new Pokemon("Eevee", "Normal", "Can escape wild battles", "Fighting", 14.3, 1.00);
            pokemon["name"] = "Jolteon";
            pokemon["type"] = "Electric";
            pokemon["ability"] = "Heals on Electric Damage";
            pokemon["weaknesses"] = "Ground";
            pokemon["weight"] = 54.0;
            pokemon["height"] = 2.07;

            Assert.AreEqual(pokemon[0], "Jolteon");
            Assert.AreEqual(pokemon[1], "Electric");
            Assert.AreEqual(pokemon[2], "Heals on Electric Damage");
            Assert.AreEqual(pokemon[3], "Ground");
            Assert.AreEqual(pokemon[4], 54.0);
            Assert.AreEqual(pokemon[5], 2.07);
        }
        [TestMethod]
        public void TestType()
        {
            Pokemon pokemon = new Pokemon("Squirtle", "Water", "Ups water attacks when below 30% HP", "Grass, Electric", 19.8, 1.08);
            Assert.AreEqual(pokemon[1], "Water");
        }
        [TestMethod]
        public void TestWeakness()
        {
            Pokemon pokemon = new Pokemon("Squirtle", "Water", "Ups water attacks when below 30% HP", "Grass, Electric", 19.8, 1.08);
            Assert.AreEqual(pokemon["weaknesses"], "Grass, Electric");
        }
    }
}
