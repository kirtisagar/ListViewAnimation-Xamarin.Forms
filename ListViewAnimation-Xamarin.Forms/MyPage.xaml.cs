using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewAnimationXamarin.Forms
{	
	public partial class MyPage : ContentPage
	{	
		public MyPage ()
		{
			InitializeComponent ();

			ListView listView = new ListView ();

			listView.ItemsSource = GetData ();



			//return new ContentPage {

				this.Content = new StackLayout {
					Children ={ listView}
			};
			//};
		}

		private  List<string> GetData()
		{
			var lst = new List<string> ();
			for(int i=0; i<=30; i++)
			{
				lst.Add ("item " + i); 
			}
			return lst;

		}

		protected override void OnAppearing ()
		{
			DependencyService.Get<IFindListView>().FindNativeListView();
			base.OnAppearing ();
		}
	}
}

