using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VideoCall.Services;
using VideoCall.Views;
using Xamarin.Forms.OpenTok.Service;

namespace VideoCall
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            CrossOpenTok.Current.ApiKey = "46499332";
            CrossOpenTok.Current.SessionId = "2_MX40NjQ5OTMzMn5-MTU3OTk5NjMxNTg5M35hWVpMQ2FtZGFqQTlNUHgwTm9heE5HZmV-fg";
            CrossOpenTok.Current.UserToken = "T1==cGFydG5lcl9pZD00NjQ5OTMzMiZzaWc9ZjAxZTVlMWEzM2QwMGEzY2RkMzM5M2I1NjQyZWI4Njc4M2IyMWYxZjpzZXNzaW9uX2lkPTJfTVg0ME5qUTVPVE16TW41LU1UVTNPVGs1TmpNeE5UZzVNMzVoV1ZwTVEyRnRaR0ZxUVRsTlVIZ3dUbTloZUU1SFptVi1mZyZjcmVhdGVfdGltZT0xNTc5OTk2MzI2Jm5vbmNlPTAuMDU5OTQ5ODc0MzU1Njc1ODkmcm9sZT1wdWJsaXNoZXImZXhwaXJlX3RpbWU9MTU4MjU4ODMyNiZpbml0aWFsX2xheW91dF9jbGFzc19saXN0PQ==";

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
