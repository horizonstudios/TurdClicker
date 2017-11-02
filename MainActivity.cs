using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System;

namespace TurdClicker
{
    [Activity(Label = "TurdClicker", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int clicks = 0;
        int turdhp = 10;
        int damage = 1;

        private TextView turdhealth;
        private ImageButton btn_clicker;
        private TextView turd_value_viewer;
        private ProgressBar healthbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            

            turdhealth = FindViewById<TextView>(Resource.Id.turdhealth);
            btn_clicker = FindViewById<ImageButton>(Resource.Id.btn_clicker);
            turd_value_viewer = FindViewById<TextView>(Resource.Id.turd1_value_viewer);
            healthbar = FindViewById<ProgressBar>(Resource.Id.healthbar);
            btn_clicker.Click += Btn_clicker_ClickAsync;
            healthbar.Max = turdhp;
            healthbar.Progress = turdhp;

            btn_clicker.SetImageResource(Resource.Drawable.turd_normal);
            turdhealth.Text = turdhp.ToString();




        }
        

        private async Task Btn_clicker_ClickAsync(object sender, System.EventArgs e)
        {
            clicks++;
            turd_value_viewer.Text = clicks.ToString() + " Clicks!";
            turdhp = turdhp - damage;
            turdhealth.Text = turdhp.ToString();
            healthbar.Progress = turdhp;
            if (turdhp >= 0)
            {
                btn_clicker.SetImageResource(Resource.Drawable.turd_distressed);
                Task.Run(async()->
                    {
                    await Task.Delay(System.TimeSpan.FromSeconds(3));
                    RunOnUiThread() = ->
                        }
                StartActivity(typeof(MainActivity));
                ))};
                )).wait();



                }
            }

        private void wait()
        {
            throw new NotImplementedException();
        }

        private object RunOnUiThread()
        {
            throw new NotImplementedException();
        }

        private object async()
        {
            throw new NotImplementedException();
        }
    }     
    }
}

