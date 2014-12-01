using System;
using Xamarin.Forms;
using Android.App;

using ViewGroup = global::Android.Views.ViewGroup;
using FormsApp1.Android;
using Com.Nhaarman.Listviewanimations.Swinginadapters.Prepared;
using Android.Widget;
using ListViewAnimationXamarin.Forms;
using ListViewAnimationXamarin.Forms.Android;

[assembly: Xamarin.Forms.Dependency (typeof (FindListViewImplementor))]

namespace ListViewAnimationXamarin.Forms.Android
{
    public class FindListViewImplementor : Java.Lang.Object, IFindListView
    {
        #region ISetListAdapter implementation

        public void FindNativeListView()
        {
			var lv = Util.FindView<global::Android.Widget.ListView>((ViewGroup)((Activity)Xamarin.Forms.Forms.Context).Window.DecorView.RootView);
            //Console.WriteLine(lv[0].Adapter);

			var AnimationAdapter = new SwingLeftInAnimationAdapter((BaseAdapter)lv[0].Adapter);

			AnimationAdapter.AbsListView = lv[0];

			lv[0].Adapter = AnimationAdapter;
        }
        #endregion
    }
}