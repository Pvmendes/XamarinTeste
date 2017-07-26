package mono.com.estimote.sdk;


public class BeaconManager_TelemetryListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.estimote.sdk.BeaconManager.TelemetryListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTelemetriesFound:(Ljava/util/List;)V:GetOnTelemetriesFound_Ljava_util_List_Handler:EstimoteSdk.BeaconManager/ITelemetryListenerInvoker, Xamarin.Estimote.Android\n" +
			"";
		mono.android.Runtime.register ("EstimoteSdk.BeaconManager+ITelemetryListenerImplementor, Xamarin.Estimote.Android, Version=1.0.8.7, Culture=neutral, PublicKeyToken=null", BeaconManager_TelemetryListenerImplementor.class, __md_methods);
	}


	public BeaconManager_TelemetryListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BeaconManager_TelemetryListenerImplementor.class)
			mono.android.TypeManager.Activate ("EstimoteSdk.BeaconManager+ITelemetryListenerImplementor, Xamarin.Estimote.Android, Version=1.0.8.7, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTelemetriesFound (java.util.List p0)
	{
		n_onTelemetriesFound (p0);
	}

	private native void n_onTelemetriesFound (java.util.List p0);

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
