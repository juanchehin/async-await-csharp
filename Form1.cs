namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // InitializeComponent();
            MessageBox.Show("async-await", "Pasa 1");
            MyMethodAsync();
        }

        public async Task MyMethodAsync()
        {
            MessageBox.Show("async-await", "Pasa 2");
            //Task<int> longRunningTask = LongRunningOperationAsync();
            LongRunningOperationAsync();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here

            //and now we call await on the task 
            MessageBox.Show("async-await", "Pasa 3");
            // int result = await longRunningTask;
            MessageBox.Show("async-await", "Pasa 4");
            //use the result 
            MessageBox.Show("async-await", "Pasa 7");
            // Console.WriteLine(result);
        }

        public async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
        {
            MessageBox.Show("async-await", "Pasa 5");
            await Task.Delay(2000); // 1 second delay
            MessageBox.Show("async-await", "Pasa 6");
            return 1;
        }
    }
}