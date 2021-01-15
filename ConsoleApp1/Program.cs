using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Web.Script.Serialization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            

            //Uri webUri = new Uri("https://api.steampowered.com/ISteamApps/GetAppList/v2/");

            //Task<string> webTask = GetWebPageAsync(webUri);
            //webTask.Wait(); // Mainメソッドではawaitできないので、処理が完了するまで待機する
            //string result = webTask.Result;
            //Console.WriteLine(result);

            //var wc = new WebClient();
            //var html = wc.DownloadString("https://api.steampowered.com/ISteamApps/GetAppList/v2/");
            //Console.WriteLine(html);


        }
        //static async Task<string> GetWebPageAsync(Uri uri) {
        //    using (HttpClient client = new HttpClient()) {
        //        // ユーザーエージェント文字列をセット（オプション）
        //        client.DefaultRequestHeaders.Add(
        //            "User-Agent",
        //            "Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko");

        //        // 受け入れ言語をセット（オプション）
        //        client.DefaultRequestHeaders.Add("Accept-Language", "ja-JP");

        //        // タイムアウトをセット（オプション）
        //        client.Timeout = TimeSpan.FromSeconds(10.0);

        //        try {
        //            // Webページを取得するのは、事実上この1行だけ
        //            return await client.GetStringAsync(uri);
        //        }
        //        catch (HttpRequestException e) {
        //            // 404エラーや、名前解決失敗など
        //            Console.WriteLine("\n例外発生!");
        //            // InnerExceptionも含めて、再帰的に例外メッセージを表示する
        //            Exception ex = e;
        //            while (ex != null) {
        //                Console.WriteLine("例外メッセージ: {0} ", ex.Message);
        //                ex = ex.InnerException;
        //            }
        //        }
        //        catch (TaskCanceledException e) {
        //            // タスクがキャンセルされたとき（一般的にタイムアウト）
        //            Console.WriteLine("\nタイムアウト!");
        //            Console.WriteLine("例外メッセージ: {0} ", e.Message);
        //        }
        //        return null;
        //    }
        //}
    }
}
