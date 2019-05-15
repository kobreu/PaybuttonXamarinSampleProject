using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Payworks
{

  // Metadata.xml XPath class reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']"
  [global::Android.Runtime.Register("com/payworks/xamarin/GenericListener", DoNotGenerateAcw = true)]
  public partial class JNIListener : global::Java.Lang.Object, global::IO.Mpos.Transactionprovider.ITransactionProcessWithRegistrationListener
  {

    internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/payworks/JNIListener", typeof(JNIListener));
    internal static new IntPtr class_ref
    {
      get
      {
        return _members.JniPeerType.PeerReference.Handle;
      }
    }

    public override global::Java.Interop.JniPeerMembers JniPeerMembers
    {
      get { return _members; }
    }

    protected override IntPtr ThresholdClass
    {
      get { return _members.JniPeerType.PeerReference.Handle; }
    }

    protected override global::System.Type ThresholdType
    {
      get { return _members.ManagedPeerType; }
    }

    protected JNIListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

    // Metadata.xml XPath constructor reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/constructor[@name='GenericListener' and count(parameter)=1 and parameter[1][@type='com.payworks.xamarin.XamarinListener']]"
    [Register(".ctor", "(Lcom/payworks/xamarin/XamarinListener;)V", "")]
    public unsafe JNIListener(global::Com.Payworks.Xamarin.IXamarinListener p0)
        : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
    {
      const string __id = "(Lcom/payworks/xamarin/XamarinListener;)V";

      if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
        return;

      try
      {
        JniArgumentValue* __args = stackalloc JniArgumentValue[1];
        __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
        var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
        SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
        _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
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

    // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onApplicationSelectionRequired' and count(parameter)=3 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction'] and parameter[3][@type='java.util.List&lt;io.mpos.paymentdetails.ApplicationInformation&gt;']]"
    [Register("onApplicationSelectionRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Ljava/util/List;)V", "GetOnApplicationSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Ljava_util_List_Handler")]
    public virtual unsafe void OnApplicationSelectionRequired(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1, global::System.Collections.Generic.IList<global::IO.Mpos.Paymentdetails.IApplicationInformation> p2)
    {
      const string __id = "onApplicationSelectionRequired.(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Ljava/util/List;)V";
      IntPtr native_p2 = global::Android.Runtime.JavaList<global::IO.Mpos.Paymentdetails.IApplicationInformation>.ToLocalJniHandle(p2);
      try
      {
        JniArgumentValue* __args = stackalloc JniArgumentValue[3];
        __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
        __args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
        __args[2] = new JniArgumentValue(native_p2);
        _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
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
      __this.OnCompleted(p0, p1, p2);
    }
#pragma warning restore 0169

    // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onCompleted' and count(parameter)=3 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction'] and parameter[3][@type='io.mpos.transactionprovider.TransactionProcessDetails']]"
    [Register("onCompleted", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V", "GetOnCompleted_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_Handler")]
    public virtual unsafe void OnCompleted(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1, global::IO.Mpos.Transactionprovider.ITransactionProcessDetails p2)
    {
      const string __id = "onCompleted.(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V";
      try
      {
        JniArgumentValue* __args = stackalloc JniArgumentValue[3];
        __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
        __args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
        __args[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
        _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
      }
      finally
      {
      }
    }

    public void OnCompleted(global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
    {
      this.OnCompleted((IO.Mpos.Transactionprovider.ITransactionProcess)p0, (IO.Mpos.Transactions.ITransaction)p1, (IO.Mpos.Transactionprovider.ITransactionProcessDetails)p2);
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

    // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onCustomerSignatureRequired' and count(parameter)=2 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction']]"
    [Register("onCustomerSignatureRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V", "GetOnCustomerSignatureRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Handler")]
    public virtual unsafe void OnCustomerSignatureRequired(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1)
    {
      const string __id = "onCustomerSignatureRequired.(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V";
      try
      {
        JniArgumentValue* __args = stackalloc JniArgumentValue[2];
        __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
        __args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
        _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
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

    // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onCustomerVerificationRequired' and count(parameter)=2 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction']]"
    [Register("onCustomerVerificationRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V", "GetOnCustomerVerificationRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Handler")]
    public virtual unsafe void OnCustomerVerificationRequired(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1)
    {
      const string __id = "onCustomerVerificationRequired.(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V";
      try
      {
        JniArgumentValue* __args = stackalloc JniArgumentValue[2];
        __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
        __args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
        _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
      }
      finally
      {
      }
    }

    static Delegate cb_onDccSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_paymentdetails_DccInformation_;
#pragma warning disable 0169
    static Delegate GetOnDccSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_paymentdetails_DccInformation_Handler()
    {
      if (cb_onDccSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_paymentdetails_DccInformation_ == null)
        cb_onDccSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_paymentdetails_DccInformation_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_OnDccSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_paymentdetails_DccInformation_);
      return cb_onDccSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_paymentdetails_DccInformation_;
    }

    static void n_OnDccSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_paymentdetails_DccInformation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
    {
      global::Com.Payworks.JNIListener __this = global::Java.Lang.Object.GetObject<global::Com.Payworks.JNIListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
      global::IO.Mpos.Transactionprovider.ITransactionProcess p0 = (global::IO.Mpos.Transactionprovider.ITransactionProcess)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactionprovider.ITransactionProcess>(native_p0, JniHandleOwnership.DoNotTransfer);
      global::IO.Mpos.Transactions.ITransaction p1 = (global::IO.Mpos.Transactions.ITransaction)global::Java.Lang.Object.GetObject<global::IO.Mpos.Transactions.ITransaction>(native_p1, JniHandleOwnership.DoNotTransfer);
      global::IO.Mpos.Paymentdetails.IDccInformation p2 = (global::IO.Mpos.Paymentdetails.IDccInformation)global::Java.Lang.Object.GetObject<global::IO.Mpos.Paymentdetails.IDccInformation>(native_p2, JniHandleOwnership.DoNotTransfer);
      __this.OnDccSelectionRequired(p0, p1, p2);
    }
#pragma warning restore 0169

    // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onDccSelectionRequired' and count(parameter)=3 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction'] and parameter[3][@type='io.mpos.paymentdetails.DccInformation']]"
    [Register("onDccSelectionRequired", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/paymentdetails/DccInformation;)V", "GetOnDccSelectionRequired_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_paymentdetails_DccInformation_Handler")]
    public virtual unsafe void OnDccSelectionRequired(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1, global::IO.Mpos.Paymentdetails.IDccInformation p2)
    {
      const string __id = "onDccSelectionRequired.(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/paymentdetails/DccInformation;)V";
      try
      {
        JniArgumentValue* __args = stackalloc JniArgumentValue[3];
        __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
        __args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
        __args[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
        _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
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

    // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onRegistered' and count(parameter)=2 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction']]"
    [Register("onRegistered", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V", "GetOnRegistered_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Handler")]
    public virtual unsafe void OnRegistered(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1)
    {
      const string __id = "onRegistered.(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;)V";
      try
      {
        JniArgumentValue* __args = stackalloc JniArgumentValue[2];
        __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
        __args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
        _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
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
      __this.OnStatusChanged(p0, p1, p2);
    }
#pragma warning restore 0169

    // Metadata.xml XPath method reference: path="/api/package[@name='com.payworks.xamarin']/class[@name='GenericListener']/method[@name='onStatusChanged' and count(parameter)=3 and parameter[1][@type='io.mpos.transactionprovider.TransactionProcess'] and parameter[2][@type='io.mpos.transactions.Transaction'] and parameter[3][@type='io.mpos.transactionprovider.TransactionProcessDetails']]"
    [Register("onStatusChanged", "(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V", "GetOnStatusChanged_Lio_mpos_transactionprovider_TransactionProcess_Lio_mpos_transactions_Transaction_Lio_mpos_transactionprovider_TransactionProcessDetails_Handler")]
    public virtual unsafe void OnStatusChanged(global::IO.Mpos.Transactionprovider.ITransactionProcess p0, global::IO.Mpos.Transactions.ITransaction p1, global::IO.Mpos.Transactionprovider.ITransactionProcessDetails p2)
    {
      const string __id = "onStatusChanged.(Lio/mpos/transactionprovider/TransactionProcess;Lio/mpos/transactions/Transaction;Lio/mpos/transactionprovider/TransactionProcessDetails;)V";
      try
      {
        JniArgumentValue* __args = stackalloc JniArgumentValue[3];
        __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
        __args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
        __args[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
        _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
      }
      finally
      {
      }
    }

    public void OnStatusChanged(global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
    {
      this.OnStatusChanged((IO.Mpos.Transactionprovider.ITransactionProcess)p0, (IO.Mpos.Transactions.ITransaction)p1, (IO.Mpos.Transactionprovider.ITransactionProcessDetails)p2);
    }

  }

  

}
