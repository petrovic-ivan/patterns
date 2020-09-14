namespace SingletonPattern
{
    public static class Client
    {
        public static void Run()
        {
            var dbContextSingleton1 = Singleton<DbContext>.Instance;
            dbContextSingleton1.PrintFromDb(1);

            var dbContextSingleton2 = Singleton<DbContext>.Instance;
            dbContextSingleton1.PrintFromDb(2);
        }
    }
}