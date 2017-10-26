using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(SharedHtmlWebView.Droid.BaseUrl))]
namespace SharedHtmlWebView.Droid
{
	public class BaseUrl : IBaseUrl
	{
		public string Get()
		{
			return "file:///android_asset/";
		}
	}
}
