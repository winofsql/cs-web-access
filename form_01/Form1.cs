using System.Diagnostics;
namespace form_01;

public partial class Form1 : Form
{
    private string url = "https://lightbox.sakura.ne.jp/demo/json/syain_json.php";

    public Form1()
    {
        InitializeComponent();
    }

    // 同期処理用( いままでどおり )
    private void action_Click(object sender, EventArgs e)
    {
        string result = Form1.Get(url);
        Debug.WriteLine($"DBG:{result}");
    }

    // 非同期処理用( async が必要 )
    private async void action_ClickAsync(object sender, EventArgs e)
    {
        string result = await Form1.GetAsync(url);
        Debug.WriteLine($"DBG:{result}");
    }


    // 同期処理用( いままでどおり )
    public static string Get(string url) {
        string result = "";

        HttpClient httpClient = new HttpClient();

        HttpResponseMessage? response = null;
        try {
            response = httpClient.GetAsync(url).Result;
        }
        catch (Exception Err) {
            result = "ERROR: " + Err.Message;
        }
        // 接続に失敗
        if (response == null) {
            return result;
        }

        try {
            response.EnsureSuccessStatusCode();
        }
        catch (Exception Err) {
            result = "ERROR: " + Err.Message;
        }
        // HTTP 応答の失敗
        if (!response.IsSuccessStatusCode) {
            return result;
        }

        // 内容を文字列として取得
        try {
            String text = response.Content.ReadAsStringAsync().Result;

            result = text;
        }
        catch (Exception Err) {
            result = "ERROR: " + Err.Message;
        }

        return result;

    }

    // 非同期処理用( async が必要 / 非同期メソッドの戻り値の型は、void、Task、Task<T> )
    public static async Task<string> GetAsync(string url) {
        string result = "";

        HttpClient httpClient = new HttpClient();

        HttpResponseMessage? response = null;
        try {
            response = await httpClient.GetAsync(url);
        }
        catch (Exception Err) {
            result = "ERROR: " + Err.Message;
        }
        // 接続に失敗
        if (response == null) {
            return result;
        }

        try {
            response.EnsureSuccessStatusCode();
        }
        catch (Exception Err) {
            result = "ERROR: " + Err.Message;
        }
        // HTTP 応答の失敗
        if (!response.IsSuccessStatusCode) {
            return result;
        }

        // 内容を文字列として取得
        try {
            String text = await response.Content.ReadAsStringAsync();

            result = text;
        }
        catch (Exception Err) {
            result = "ERROR: " + Err.Message;
        }

        return result;

    }

}
