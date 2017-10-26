using System;
using System.Reflection;
using Xamarin.Forms;

namespace SharedHtmlWebView
{
    public partial class SharedHtmlWebViewPage : ContentPage
    {
        public SharedHtmlWebViewPage()
        {
            InitializeComponent();

            LoadSource();
        }

        private void LoadSource()
        {
			var assembly = typeof(SharedHtmlWebView.App).GetTypeInfo().Assembly;
			var stream = assembly.GetManifestResourceStream("SharedHtmlWebView.Common.html");
			string html = string.Empty;
			using (var reader = new System.IO.StreamReader(stream))
			{
				html = reader.ReadToEnd();
			}

			var source = new HtmlWebViewSource()
			{
				BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
				Html = html
			};

			webView.Source = source;
        }
    }
}
