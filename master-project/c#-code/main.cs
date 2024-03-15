internal class Program
{
    [DllImport("sub-project.dll", EntryPoint = "?bar@foo@@QEAAHPEBD@Z")]
    static extern int Bar(string msg);
  
    static void Main(string[] args)
    {
        string path = "D:\\MCX\\MCX SFTP Files\\MCXScrips.bcp";
        string msg = "Hello!";
        try
        {
            var res = Bar(path);
            Console.WriteLine(string.Format(@"{0}", res));
            if (res != 0)
            {
                Console.WriteLine("Error in ReadMasterFile()");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
