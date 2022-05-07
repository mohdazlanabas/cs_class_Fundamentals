namespace cs_class_fundamanetals
{
    class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AsyncConsoleWork().GetAwaiter().GetResult();


        }

        private static async Task<int> AsyncConsoleWork()
        {
            // Main body here
            return await AsyncConsoleWork();
        }

    }
}
