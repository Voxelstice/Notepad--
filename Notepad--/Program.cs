namespace Notepad__
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Thread thread = new Thread(Funny);
            thread.Start();
        }

        static void Funny()
        {
            Form1 form = new Form1();
            MessageBox.Show("NOTEPAD-- IS NOW LOADING!!! HAVE PATIENT....", "Notepad--");
            Thread.Sleep(TimeSpan.FromMinutes(4));
            MessageBox.Show("NOTEPAD-- HAS FINISH LOAD!!!! THAN YOU FOR PATIENT!!!! ENHOY USE!!!", "Notepad--");
            form.ShowDialog();
        }
    }
}