
//before you init code this you will need to  create a folder called raw in the resource folder app.
//you have to add all mp3 files tha you want to play in app inside the folder raw.
using Android.App;
//if you dont have android.Media in your code, its just copy.
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
        //here you instantiate the MediaPlayer
        MediaPlayer player1;
        MediaPlayer player2;
        MediaPlayer player3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //Here you have to setup de MediaPlayer
            player1 = MediaPlayer.Create(this, Resource.Raw.te_mp3);
            player2 = MediaPlayer.Create(this, Resource.Raw.ta);

            //here you will configure you click event
            Button buttomPlay = FindViewById<Button>(Resource.Id.btnPlay);
            buttomPlay.Click += (sender, e) =>
            {
            //inside your click event you have to init the player;
                player1.Start();
                
                
            };
            //Here i created this another button to pause the music.
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
