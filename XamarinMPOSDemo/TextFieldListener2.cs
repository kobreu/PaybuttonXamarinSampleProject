using System;
using System.Collections.Generic;
using Android.Widget;
using IO.Mpos.Paymentdetails;
using IO.Mpos.Transactionprovider;
using IO.Mpos.Transactions;

namespace XamarinMPOSDemo
{
    internal class TextFieldListener2 : Java.Lang.Object,Com.Payworks.Xamarin.IXamarinListener
    {
        private TextView textView;

        public TextFieldListener2(TextView textView)
        {
            this.textView = textView;
        }

        public void OnApplicationSelectionRequired(ITransactionProcess p0, ITransaction p1, IList<IApplicationInformation> p2)
        {
            this.Display("Application Selection");
            p0.ContinueWithSelectedApplication(p2[0]);
        }

        public void OnCompleted(ITransactionProcess p0, ITransaction p1, ITransactionProcessDetails p2)
        {
           // this.Display("On Completed");
        }

        public void OnCustomerSignatureRequired(ITransactionProcess p0, ITransaction p1)
        {
            this.Display("Customer Signature Required");
            p0.ContinueWithCustomerSignatureOnReceipt();
        }

        public void OnCustomerVerificationRequired(ITransactionProcess p0, ITransaction p1)
        {
            this.Display("Customer Verification Required");
            p0.ContinueWithCustomerIdentityVerified(true);
        }

        public void OnRegistered(ITransactionProcess p0, ITransaction p1)
        {
        }

        public void OnStatusChanged(ITransactionProcess p0, ITransaction p1, ITransactionProcessDetails p2)
        {
            this.Display(p2.GetInformation()[0] + "\n" + p2.GetInformation()[1]);
        }

        private void Display(string s) {
            this.textView.Text = s;
        }
    }
}