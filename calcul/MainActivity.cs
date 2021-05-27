using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace calcul
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button Sum = FindViewById<Button>(Resource.Id.btnSum);
            Button Sub = FindViewById<Button>(Resource.Id.btnSub);
            Button Mul = FindViewById<Button>(Resource.Id.btnMul);
            Button Div = FindViewById<Button>(Resource.Id.btnDiv);
            EditText nbr1 = FindViewById<EditText>(Resource.Id.textNb1);
            EditText nbr2 = FindViewById<EditText>(Resource.Id.textNb2);
            TextView resultats = FindViewById<TextView>(Resource.Id.resultat);

            // Addition
            Sum.Click += (S, e) =>
            {
                int var1 = int.Parse(nbr1.Text);
                int var2 = int.Parse(nbr2.Text);

                resultats.Text = (var1 + var2).ToString();
            };

            //Substration
            Sub.Click += (S, e) =>
            {
                int var1 = int.Parse(nbr1.Text);
                int var2 = int.Parse(nbr2.Text);

                resultats.Text = (var1 - var2).ToString();
            };

            //Multiplication
            Mul.Click += (S, e) =>
            {
                int var1 = int.Parse(nbr1.Text);
                int var2 = int.Parse(nbr2.Text);

                resultats.Text = (var1 * var2).ToString();
            };

            //Division
            Div.Click += (S, e) =>
            {
                float var1 = float.Parse(nbr1.Text);
                float var2 = float.Parse(nbr2.Text);

                resultats.Text = (var1 / var2).ToString();
            };


        }

    }
}