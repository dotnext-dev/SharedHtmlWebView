using System;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(SharedHtmlWebView.iOS.BaseUrl))]
namespace SharedHtmlWebView.iOS
{
	public class BaseUrl : IBaseUrl
	{
		public string Get()
		{
			return NSBundle.MainBundle.BundlePath;
		}
	}
}