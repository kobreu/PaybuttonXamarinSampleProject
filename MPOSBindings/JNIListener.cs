using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Payworks
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']"
    [global::Android.Runtime.Register("com/payworks/xamarin/GenericListener", DoNotGenerateAcw = true)]
    public partial class JNIListener : global::Java.Lang.Object, global::IO.Mpos.Transactionprovider.ITransactionProcessWithRegistrationListener
    {

        internal static new IntPtr java_class_handle;
        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/payworks/xamarin/GenericListener", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(JNIListener); }
        }

        protected JNIListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor_Lcom_payworks_xamarin_XamarinListener_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/constructor[@name='GenericListener' and count(parameter)=1 and parameter[1][@type='com.payworks.xamarin.XamarinListener']]"
        [Register(".ctor", "(Lcom/payworks/xamarin/XamarinListener;)V", "")]
        public unsafe JNIListener(global::Com.Payworks.Xamarin.IXamarinListener p0)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                if (((object)this).GetType() != typeof(JNIListener))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Lcom/payworks/xamarin/XamarinListener;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(Lcom/payworks/xamarin/XamarinListener;)V", __args);
                    return;
                }

                if (id_ctor_Lcom_payworks_xamarin_XamarinListener_ == IntPtr.Zero)
                    id_ctor_Lcom_payworks_xamarin_XamarinListener_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Lcom/payworks/xamarin/XamarinListener;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Lcom_payworks_xamarin_XamarinListener_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_Lcom_payworks_xamarin_XamarinListener_, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_onApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_;
#pragma warning disable 0169
        static Delegate GetOnApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_Handler()
        {
            if (cb_onApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_ == null)
                cb_onApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_OnApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_);
            return cb_onApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_;
        }

        static void n_OnApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
        {
            global::Com.Payworks.JNIListener __this = global::Java.Lang.Object.GetObject<global::Com.Payworks.JNIListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactionprovider.ITransactionProcess p0 = (global::IO.Mpos.Transactionprovider.ITransactionProcess)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactionprovider.ITransactionProcess>(native_p0, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactions.ITransaction p1 = (global::IO.Mpos.Transactions.ITransaction)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactions.ITransaction>(native_p1, JniHandleOwnership.DoNotTransfer);
            var p2 = global::Android.Runtime.JavaList<global::IO.Mpos.Paymentdetails.IApplicationInformation>.FromJniHandle(native_p2, JniHandleOwnership.DoNotTransfer);
            __this.OnApplicationSelectionRequired(p0, p1, p2);
        }
#pragma warning restore 0169

        static IntPtr id_onApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onApplicationSelectionRequired' and count(parameter)=3 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction'] and parameter[3][@type='java.util.List&lt;io.mpos.paymentdetails.ApplicationInformation&gt;']]"
        [Register("onApplicationSelectionRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Ljava/util/List;)V", "GetOnApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_Handler")]
        public virtual unsafe void OnApplicationSelectionRequired(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1, global::System.Collections.Generic.IList<global::IO.Mpos.Paymentdetails.IApplicationInformation> p2)
        {
            if (id_onApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_ == IntPtr.Zero)
                id_onApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_ = JNIEnv.GetMethodID(class_ref, "onApplicationSelectionRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Ljava/util/List;)V");
            IntPtr native_p2 = global::Android.Runtime.JavaList<global::IO.Mpos.Paymentdetails.IApplicationInformation>.ToLocalJniHandle(p2);
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(native_p2);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onApplicationSelectionRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Ljava/util/List;)V"), __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p2);
            }
        }

        static Delegate cb_onCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_;
#pragma warning disable 0169
        static Delegate GetOnCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_Handler()
        {
            if (cb_onCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_ == null)
                cb_onCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_OnCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_);
            return cb_onCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_;
        }

        static void n_OnCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
        {
            global::Com.Payworks.JNIListener __this = global::Java.Lang.Object.GetObject<global::Com.Payworks.JNIListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactionprovider.ITransactionProcess p0 = (global::IO.Mpos.Transactionprovider.ITransactionProcess)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactionprovider.ITransactionProcess>(native_p0, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactions.ITransaction p1 = (global::IO.Mpos.Transactions.ITransaction)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactions.ITransaction>(native_p1, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactionprovider.ITransactionProcessDetails p2 = (global::IO.Mpos.Transactionprovider.ITransactionProcessDetails)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactionprovider.ITransactionProcessDetails>(native_p2, JniHandleOwnership.DoNotTransfer);
            __this.OnCompleted((Java.Lang.Object)p0, (Java.Lang.Object)p1, (Java.Lang.Object)p2);
        }
#pragma warning restore 0169

        static IntPtr id_onCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onCompleted' and count(parameter)=3 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction'] and parameter[3][@type='io.mpos.transactionprovider.TransactionProcessDetails']]"
        [Register("onCompleted", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V", "GetOnCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_Handler")]
        public virtual unsafe void OnCompleted(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1, global::IO.Mpos.Transactionprovider.ITransactionProcessDetails p2)
        {
            if (id_onCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_ == IntPtr.Zero)
                id_onCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_ = JNIEnv.GetMethodID(class_ref, "onCompleted", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V");
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(p2);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onCompleted", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V"), __args);
            }
            finally
            {
            }
        }

        public void OnCompleted(global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2) {
            this.OnCompleted((IO.Mpos.Transactionprovider.ITransactionProcess) p0, (IO.Mpos.Transactions.ITransaction) p1, (IO.Mpos.Transactionprovider.ITransactionProcessDetails) p2);
        }

        static Delegate cb_onCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_;
#pragma warning disable 0169
        static Delegate GetOnCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Handler()
        {
            if (cb_onCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ == null)
                cb_onCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_OnCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_);
            return cb_onCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_;
        }

        static void n_OnCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
        {
            global::Com.Payworks.JNIListener __this = global::Java.Lang.Object.GetObject<global::Com.Payworks.JNIListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactionprovider.ITransactionProcess p0 = (global::IO.Mpos.Transactionprovider.ITransactionProcess)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactionprovider.ITransactionProcess>(native_p0, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactions.ITransaction p1 = (global::IO.Mpos.Transactions.ITransaction)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactions.ITransaction>(native_p1, JniHandleOwnership.DoNotTransfer);
            __this.OnCustomerSignatureRequired(p0, p1);
        }
#pragma warning restore 0169

        static IntPtr id_onCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onCustomerSignatureRequired' and count(parameter)=2 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction']]"
        [Register("onCustomerSignatureRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V", "GetOnCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Handler")]
        public virtual unsafe void OnCustomerSignatureRequired(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1)
        {
            if (id_onCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ == IntPtr.Zero)
                id_onCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ = JNIEnv.GetMethodID(class_ref, "onCustomerSignatureRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onCustomerSignatureRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V"), __args);
            }
            finally
            {
            }
        }

        static Delegate cb_onCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_;
#pragma warning disable 0169
        static Delegate GetOnCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Handler()
        {
            if (cb_onCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ == null)
                cb_onCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_OnCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_);
            return cb_onCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_;
        }

        static void n_OnCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
        {
            global::Com.Payworks.JNIListener __this = global::Java.Lang.Object.GetObject<global::Com.Payworks.JNIListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactionprovider.ITransactionProcess p0 = (global::IO.Mpos.Transactionprovider.ITransactionProcess)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactionprovider.ITransactionProcess>(native_p0, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactions.ITransaction p1 = (global::IO.Mpos.Transactions.ITransaction)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactions.ITransaction>(native_p1, JniHandleOwnership.DoNotTransfer);
            __this.OnCustomerVerificationRequired(p0, p1);
        }
#pragma warning restore 0169

        static IntPtr id_onCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onCustomerVerificationRequired' and count(parameter)=2 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction']]"
        [Register("onCustomerVerificationRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V", "GetOnCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Handler")]
        public virtual unsafe void OnCustomerVerificationRequired(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1)
        {
            if (id_onCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ == IntPtr.Zero)
                id_onCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ = JNIEnv.GetMethodID(class_ref, "onCustomerVerificationRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onCustomerVerificationRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V"), __args);
            }
            finally
            {
            }
        }

        static Delegate cb_onRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_;
#pragma warning disable 0169
        static Delegate GetOnRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Handler()
        {
            if (cb_onRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ == null)
                cb_onRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_OnRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_);
            return cb_onRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_;
        }

        static void n_OnRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
        {
            global::Com.Payworks.JNIListener __this = global::Java.Lang.Object.GetObject<global::Com.Payworks.JNIListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactionprovider.ITransactionProcess p0 = (global::IO.Mpos.Transactionprovider.ITransactionProcess)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactionprovider.ITransactionProcess>(native_p0, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactions.ITransaction p1 = (global::IO.Mpos.Transactions.ITransaction)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactions.ITransaction>(native_p1, JniHandleOwnership.DoNotTransfer);
            __this.OnRegistered(p0, p1);
        }
#pragma warning restore 0169

        static IntPtr id_onRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onRegistered' and count(parameter)=2 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction']]"
        [Register("onRegistered", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V", "GetOnRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Handler")]
        public virtual unsafe void OnRegistered(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1)
        {
            if (id_onRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ == IntPtr.Zero)
                id_onRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_ = JNIEnv.GetMethodID(class_ref, "onRegistered", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onRegistered", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V"), __args);
            }
            finally
            {
            }
        }

        static Delegate cb_onStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_;
#pragma warning disable 0169
        static Delegate GetOnStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_Handler()
        {
            if (cb_onStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_ == null)
                cb_onStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_OnStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_);
            return cb_onStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_;
        }

        static void n_OnStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
        {
            global::Com.Payworks.JNIListener __this = global::Java.Lang.Object.GetObject<global::Com.Payworks.JNIListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactionprovider.ITransactionProcess p0 = (global::IO.Mpos.Transactionprovider.ITransactionProcess)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactionprovider.ITransactionProcess>(native_p0, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactions.ITransaction p1 = (global::IO.Mpos.Transactions.ITransaction)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactions.ITransaction>(native_p1, JniHandleOwnership.DoNotTransfer);
            global::IO.Mpos.Transactionprovider.ITransactionProcessDetails p2 = (global::IO.Mpos.Transactionprovider.ITransactionProcessDetails)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactionprovider.ITransactionProcessDetails>(native_p2, JniHandleOwnership.DoNotTransfer);
            __this.OnStatusChanged((Java.Lang.Object)p0,(Java.Lang.Object) p1,(Java.Lang.Object) p2);
        }
#pragma warning restore 0169

        static IntPtr id_onStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onStatusChanged' and count(parameter)=3 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction'] and parameter[3][@type='io.mpos.transactionprovider.TransactionProcessDetails']]"
        [Register("onStatusChanged", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V", "GetOnStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_Handler")]
        public virtual unsafe void OnStatusChanged(global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
        {   
            if (id_onStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_ == IntPtr.Zero)
                id_onStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_ = JNIEnv.GetMethodID(class_ref, "onStatusChanged", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V");
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(p2);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onStatusChanged", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V"), __args);
            }
            finally
            {
            }
        }

    }
}
