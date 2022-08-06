
using Android.App;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Music4u
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        MediaPlayer player1;
        MediaPlayer player2;
        MediaPlayer player3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            player1 = MediaPlayer.Create(this, Resource.Raw.te_mp3);
            player2 = MediaPlayer.Create(this, Resource.Raw.ta);

            //buttons take
            Button buttomPlay = FindViewById<Button>(Resource.Id.btnPlay);
            buttomPlay.Click += (sender, e) =>
            {
                player1.Start();
                
                
            };
            Button buttomPause = FindViewById<Button>(Resource.Id.btnPause);
            buttomPause.Click += (sender, e) =>
            {
                player1.Pause();
            };
            Button buttomPlay1 = FindViewById<Button>(Resource.Id.btnPlay1);
            buttomPlay1.Click += (sender, e) =>
            {
                player2.Start();
            };
            Button buttomPause1 = FindViewById<Button>(Resource.Id.btnPause1);
            buttomPause1 .Click += (sender, e) =>
            {
                player2.Pause();
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}