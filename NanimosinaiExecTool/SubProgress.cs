// //--------------------------------------------------
// //! @file 	SubProgress.cs
// //! @brief 	SubProgress.cs
// //--------------------------------------------------

using Bogus;

namespace NanimosinaiExecTool;

public partial class SubProgress : Form
{
    private readonly TaskCompletionSource<bool> _tcs;
    public SubProgress(string title, TaskCompletionSource<bool> tcs)
    {
        InitializeComponent();
        // ReSharper disable once VirtualMemberCallInConstructor
        Text = title;
        this._tcs = tcs;

        // フォームが閉じたときに完了通知
        this.FormClosed += (s, e) => _tcs.SetResult(true);
    }

    private async void SubProgress_Load(object sender, EventArgs e)
    {
        try
        {
            Random random = new();
            int progMax = random.Next(50,500);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = progMax;

            textBox1.Text += "staring...\n";
         
            for (var i = 0; i < progMax;)
            {
                await Task.Delay(random.Next(10, 200));
                
                textBox1.AppendText($"{GenerateRealisticFilePath()}{Environment.NewLine}");
                // 数値更新
                i ++;
                Math.Clamp(i, 0, progMax);
                progressBar1.Value = i;
            }

            await Task.Delay(random.Next(100, 300));
            Close();
        }
        catch (Exception ef)
        {
            throw; // TODO 例外の処理
        }
    }


    private static string GenerateRealisticFilePath()
    {
        Random rand = new Random();
        var faker = new Faker();

        // Windows/Linux のどちらの形式かをランダムに選択
        const bool isWindows = true;
        // ランダムなドライブ名（Windows）またはルートディレクトリ（Linux）
        string[] drives = { "C:", "D:", "E:", "/home/user", "/var/log", "/usr/local" };
        string rootPath = isWindows ? drives[rand.Next(0, 1)] : drives[rand.Next(3, drives.Length)];

        // それっぽいフォルダ名の生成（都市名・企業名・カテゴリ名など）
        string[] categories = { "Projects", "Documents", "Downloads", "Archives", "Resources", "Configs" };
        string category = categories[rand.Next(categories.Length)];

        string folder1 = faker.Company.CompanyName().Replace(" ", ""); // 企業名
        string folder2 = faker.Address.City().Replace(" ", ""); // 都市名
        string folder3 = "v" + rand.Next(1, 10) + "." + rand.Next(0, 10); // バージョン番号

        // ランダムなファイル名（人物名・適当な単語）
        string fileName = faker.Name.FirstName().ToLower() + "_" + faker.Random.Word().ToLower();

        // それっぽい拡張子
        string[] extensions = { ".txt", ".log", ".csv", ".jpg", ".png", ".exe", ".dll", ".mp4", ".json", ".docx", ".xlsx" };
        string extension = extensions[rand.Next(extensions.Length)];

        // フルパスを作成
        string fullPath = Path.Combine(rootPath, category, folder1, folder2, folder3, fileName + extension);

        return isWindows ? fullPath.Replace("/", "\\") : fullPath.Replace("\\", "/");
    }
}