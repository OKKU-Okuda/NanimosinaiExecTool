
using Bogus;

namespace NanimosinaiExecTool;


public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        const string prefixCurrentText = "指定されたコマンドパイプラインを実行中... ";
        try
        {
            Random random = new();
            button1.Enabled = false;

            MainProgressText.Text = prefixCurrentText;
            progressBar1.Minimum = 0;
            const int max = 21398;
            progressBar1.Maximum = max;

            for (var i = 0; i < max;)
            {
                await Task.Delay(random.Next(900, 1900));

                MainProgressText.Text = prefixCurrentText + $"{i}/{max}";
                MainProgressText.Refresh();
                Console.WriteLine($"{i}/{max}");


                // フォームを起動し、すべて閉じるのを待つ

                var faker = new Faker("ja");
                
                List<string> titles = new();
                for (var j = 0; j < random.Next(3, 9); j++)
                {
                    titles.Add($"ファイル修復中...{faker.Name.JobType()}");
                }
                await RunMultipleFormsAsync(titles.ToArray());

                // 数値更新
                i += random.Next(1, 4);
                Math.Clamp(i, 0, max);
                progressBar1.Value = i;

                if (i == max)
                {// リセットー！
                    i = 0;
                }
            }
        }
        catch (Exception ex)
        {
            throw; // TODO 例外の処理
        }
    }

    static Task RunMultipleFormsAsync(string[] titles)
    {
        var tasks = new List<Task>();

        foreach (var title in titles)
        {
            var tcs = new TaskCompletionSource<bool>();
            tasks.Add(tcs.Task);

            var thread = new Thread(() => { Application.Run(new SubProgress(title, tcs)); });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        return Task.WhenAll(tasks); // すべてのフォームが閉じるのを待機
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }
}