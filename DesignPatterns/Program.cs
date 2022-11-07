using DesignPatterns.Singleton;

class Program
{
    static void Main(string[] args)
    {
        #region Singleton

        //var singleton = Singleton.Instance; 
        var log = Log.Instance;
        log.Save("a");
        log.Save("b");

        #endregion
    }
}