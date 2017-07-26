package mono.com.estimote.sdk;


public class BeaconManager_LocationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.estimote.sdk.BeaconManager.LocationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLocationsFound:(Ljava/util/List;)V:GetOnLocationsFound_Ljava_util_List_Handler:EstimoteSdk.BeaconManager/ILocationListenerInvoker, Xamarin.Estimote.Android\n" +
			"";
		mono.android.Runtime.register ("EstimoteSdk.BeaconManager+ILocationListenerImplementor, Xamarin.Estimote.Android, Version=1.0.8.7, Culture=neutral, PublicKeyToken=null", BeaconManager_LocationListenerImplementor.class, __md_methods);
	}


	public BeaconManager_LocationListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BeaconManager_LocationListenerImplementor.class)
			mono.android.TypeManager.Activate ("EstimoteSdk.BeaconManager+ILocationListenerImplementor, Xamarin.Estimote.Android, Version=1.0.8.7, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onLocationsFound (java.util.List p0)
	{
		n_onLocationsFound (p0);
	}

	private native void n_onLocationsFound (java.util.List p0);

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
