namespace ICE2Indexers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pokemon Delta = new Pokemon("Metapod", "Bug", "Shed Skin", "Rock, Fire, Flying", 21.8, 2.04);

            Console.WriteLine("Pokemon name: " + Delta[0]);
            Console.WriteLine("Pokemon type: " + Delta[1]);
            Console.WriteLine("Pokemon ability: " + Delta[2]);
            Console.WriteLine("Pokemon weaknesses: " + Delta[3]);
            Console.WriteLine("Pokemon weight: " + Delta[4] + " lbs");
            Console.WriteLine("Pokemon height: " + Delta[5] + " ft");
            

        }
    }
}
