package mono.com.estimote.sdk;


public class BeaconManager_ScanStatusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.estimote.sdk.BeaconManager.ScanStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScanStart:()V:GetOnScanStartHandler:EstimoteSdk.BeaconManager/IScanStatusListenerInvoker, Xamarin.Estimote.Android\n" +
			"n_onScanStop:()V:GetOnScanStopHandler:EstimoteSdk.BeaconManager/IScanStatusListenerInvoker, Xamarin.Estimote.Android\n" +
			"";
		mono.android.Runtime.register ("EstimoteSdk.BeaconManager+IScanStatusListenerImplementor, Xamarin.Estimote.Android, Version=1.0.8.7, Culture=neutral, PublicKeyToken=null", BeaconManager_ScanStatusListenerImplementor.class, __md_methods);
	}


	public BeaconManager_ScanStatusListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BeaconManager_ScanStatusListenerImplementor.class)
			mono.android.TypeManager.Activate ("EstimoteSdk.BeaconManager+IScanStatusListenerImplementor, Xamarin.Estimote.Android, Version=1.0.8.7, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onScanStart ()
	{
		n_onScanStart ();
	}

	private native void n_onScanStart ();


	public void onScanStop ()
	{
		n_onScanStop ();
	}

	private native void n_onScanStop ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
