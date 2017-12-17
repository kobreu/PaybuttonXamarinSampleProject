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
            throw new NotImplementedException();
        }

        public void OnCompleted(ITransactionProcess p0, ITransaction p1, ITransactionProcessDetails p2)
        {
            throw new NotImplementedException();
        }

        public void OnCustomerSignatureRequired(ITransactionProcess p0, ITransaction p1)
        {
            throw new NotImplementedException();
        }

        public void OnCustomerVerificationRequired(ITransactionProcess p0, ITransaction p1)
        {
            throw new NotImplementedException();
        }

        public void OnStatusChanged(ITransactionProcess p0, ITransaction p1, ITransactionProcessDetails p2)
        {
            throw new NotImplementedException();
        }
    }
}