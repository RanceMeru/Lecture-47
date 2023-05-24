class Program
{
    static void Main(string[] args)
    {
        Add(5);
        Add(5, z: 30);//lets us skip the order to manually set the value for z 
        //it will still add in order
    }

    public static void Add( int x, int y = 1, int z = 2)
    {
        int answer = x + y + z;
        Console.WriteLine(answer);
    }
}