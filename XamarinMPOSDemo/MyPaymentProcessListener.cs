﻿using System;

using Android.Util;
using Android.Views;
using Android.Widget;
using IO.Mpos;

namespace XamarinMPOSDemo
{
	public class MyPaymentProcessListener : Java.Lang.Object, IO.Mpos.Transactionprovider.ITransactionProcessWithRegistrationListener
	{
		private TextView _statusView;

		public MyPaymentProcessListener(TextView statusView) {
			_statusView = statusView;
		}

		public void OnRegistered (IO.Mpos.Transactionprovider.ITransactionProcess transactionProcess, IO.Mpos.Transactions.ITransaction transaction)
		{
			updateStatus("OnRegistered");
		}

		#region IPaymentProcessListener implementation

		public void OnApplicationSelectionRequired (IO.Mpos.Transactionprovider.ITransactionProcess p0, IO.Mpos.Transactions.ITransaction p1, System.Collections.Generic.IList<IO.Mpos.Paymentdetails.IApplicationInformation> p2)
		{
			updateStatus("application selection required.");
			p0.ContinueWithSelectedApplication (p2 [0]);
		}

		public void onCompleted (IO.Mpos.Transactionprovider.ITransactionProcess paymentProcess, IO.Mpos.Transactions.ITransaction transaction, IO.Mpos.Transactionprovider.ITransactionProcessDetails details)
		{
			updateStatus ("OnCompleted");
		}

		public void OnCustomerSignatureRequired (IO.Mpos.Transactionprovider.ITransactionProcess paymentProcess, IO.Mpos.Transactions.ITransaction transaction)
		{
			updateStatus ("OnCustomerSignatureRequired");
			//paymentProcess.ContinueWithCustomerSignature (true);
		}

		public void OnCustomerVerificationRequired (IO.Mpos.Transactionprovider.ITransactionProcess paymentProcess, IO.Mpos.Transactions.ITransaction transaction)
		{
			updateStatus ("OnCustomerVerificationRequired");
			paymentProcess.ContinueWithCustomerIdentityVerified (true);
		}

		public void onStatusChanged (IO.Mpos.Transactionprovider.ITransactionProcess paymentProcess, IO.Mpos.Transactions.ITransaction transaction, IO.Mpos.Transactionprovider.ITransactionProcessDetails details)
		{
			updateStatus ("onStatusChanged:\n" + details.GetInformation()[0] + "\n" + details.GetInformation()[1]);
		}

		#endregion

		private void updateStatus(String text) {
			Log.Info ("MyPaymentProcessListener", text);
			_statusView.Text = text;
		}
	}
}

