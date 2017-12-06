using Android.Content;
using BrokenGraphics.ViewModels;
using MvvmCross.Core.Parse.StringDictionary;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;

namespace BrokenGraphics
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            //return new Core.App();
            return new DummyApp();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        private class DummyApp : MvxApplication
        {
            public override void Initialize()
            {
                base.Initialize();

                RegisterNavigationServiceAppStart<MainViewModel>();
            }
        }
    }
}
