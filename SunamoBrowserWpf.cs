namespace SunamoWeb3
{
    public class SunamoBrowserWpf : ISunamoBrowser
    {
        public static SunamoBrowserWpf Instance = new SunamoBrowserWpf();
        public  Microsoft.Web.WebView2.Wpf.WebView2  vw = new Microsoft.Web.WebView2.Wpf.WebView2();
    
        
        
        public Uri Source { get; set; }
        public async Task<HtmlDocument> GetHtmlDocument()
        {
            return null;
        }

        public Task<string> GetContent()
        {
            Task<string> html = null;
#pragma warning disable CSE005
             WpfApp.cd.Invoke( () =>
            {
                html =  vw.ExecuteScriptAsync("document.documentElement.outerHTML");
            });
            return html;
#pragma warning restore CSE005
        }

        public string HTML { get; }
        public void Navigate(string uri)
        {
            vw.Source = new Uri(uri);
        }

        public bool ScrollToEnd()
        {
            return false;
        }

        public void Init()
        {
            
        }
    }
}
