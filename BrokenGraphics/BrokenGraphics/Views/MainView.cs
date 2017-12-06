using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;

namespace BrokenGraphics.Views
{
    [Activity(Label = "View for MainViewModel",
        ScreenOrientation = ScreenOrientation.SensorPortrait,
        Theme = "@style/CompanyTheme")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}
