using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using IO.Mpos;

namespace XamarinMPOSDemo
{
	[Activity (Label = "XamarinMPOSDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				StartPayment();
			};
		}


		protected void StartPayment()
		{
			MposExtended.SetLogLevel (2); //TRACE

			var provider = Mpos.CreateTransactionProvider (this, IO.Mpos.Provider.ProviderMode.Test, "6ef3adee-3bce-48b7-b3c1-3185c14d67b6", "E1JewPljP1BjDwCY9yPO3XtNMa3NjHUZ");
			var template = provider.CreateChargeTransactionTemplate (Java.Math.BigDecimal.One, IO.Mpos.Transactions.Currency.Eur, "subject", "identifier");
			var listener = new MyPaymentProcessListener (FindViewById<TextView> (Resource.Id.textView1));
			provider.StartTransaction (template, IO.Mpos.Accessories.AccessoryFamily.MiuraMpi, listener);


		}
	}
}


