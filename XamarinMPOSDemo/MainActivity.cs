using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using IO.Mpos;
using IO.Mpos.UI.Shared;
using IO.Mpos.Accessories.Parameters;

namespace XamarinMPOSDemo
{
	[Activity (Label = "XamarinMPOSDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resourc		
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
			// Implementation without UI

			//var provider = IO.Mpos.MMpos.CreateTransactionProvider(this, IO.Mpos.Provider.ProviderMode.Test, "bf12b302-13ff-46d3-b76a-f795b58a0738", "wptdjc5P1LcpDskmT0UzePF7DEGBNfBF");
			//var transactionParameters = new IO.Mpos.Transactions.Parameters.TransactionParametersBuilder().Charge(Java.Math.BigDecimal.One, IO.Mpos.Transactions.Currency.Eur).Subject("subject").CustomIdentifier("identifier").Build();
			//var accessoryParameters = new IO.Mpos.Accessories.Parameters.AccessoryParameters.Builder(IO.Mpos.Accessories.AccessoryFamily.MiuraMpi).Bluetooth().Build();
			//var listener = new MyPaymentProcessListener(FindViewById<TextView>(Resource.Id.textView1));

			/*var listener = new MyPaymentProcessListener (FindViewById<TextView> (Resource.Id.textView1));
			provider.StartTransaction (template, IO.Mpos.Accessories.AccessoryFamily.MiuraMpi, listener);*/

			// Implementation with UI

			AccessoryParameters accessoryParameters = new AccessoryParameters.Builder(IO.Mpos.Accessories.AccessoryFamily.MiuraMpi).Bluetooth().Build();
			var transactionParameters = new IO.Mpos.Transactions.Parameters.TransactionParametersBuilder().Charge(Java.Math.BigDecimal.One, IO.Mpos.Transactions.Currency.Eur).Subject("subject").CustomIdentifier("identifier").Build();

			MposUi ui = MposUi.Initialize (this, IO.Mpos.Provider.ProviderMode.Test, "6ef3adee-3bce-48b7-b3c1-3185c14d67b6", "E1JewPljP1BjDwCY9yPO3XtNMa3NjHUZ");

			ui.Configuration.SetTerminalParameters(accessoryParameters);
			ui.Configuration.SetSummaryFeatures(Java.Util.EnumSet.Of(IO.Mpos.UI.Shared.Model.MposUiConfiguration.SummaryFeature.SendReceiptViaEmail));

			Intent intent = ui.CreateTransactionIntent(transactionParameters);
			StartActivityForResult (intent, MposUi.RequestCodePayment);
		}
			
		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data) {
			base.OnActivityResult (requestCode, resultCode, data);

			if (requestCode == MposUi.RequestCodePayment) {
				// Grab the processed transaction in case you need it
				// (e.g. the transaction identifier for a refund)
				// Keep in mind that the returned transaction might be null
				// (e.g. if it could not be registered)
				IO.Mpos.Transactions.ITransaction transaction = MposUi.InitializedInstance.Transaction;

				if (transaction != null && transaction.Status.Equals(IO.Mpos.Transactions.TransactionStatus.Approved)) {
					// Transaction was approved
					Toast.MakeText (this, "Transaction approved", ToastLength.Long).Show();
				} else {
					// Card was declined, or transaction was aborted, or failed
					// (e.g. no internet or accessory not found)
					Toast.MakeText (this, "Transaction was declined, aborted, or failed", ToastLength.Long).Show ();
				}
			}

		}
	
	}
}


