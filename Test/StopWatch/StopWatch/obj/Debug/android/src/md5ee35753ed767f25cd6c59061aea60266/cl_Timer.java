package md5ee35753ed767f25cd6c59061aea60266;


public class cl_Timer
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("StopWatch.cl_Timer, StopWatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", cl_Timer.class, __md_methods);
	}


	public cl_Timer ()
	{
		super ();
		if (getClass () == cl_Timer.class)
			mono.android.TypeManager.Activate ("StopWatch.cl_Timer, StopWatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public cl_Timer (android.app.Activity p0)
	{
		super ();
		if (getClass () == cl_Timer.class)
			mono.android.TypeManager.Activate ("StopWatch.cl_Timer, StopWatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	public cl_Timer (android.app.Activity p0, android.widget.Button p1, android.widget.Button p2, md565ae71dbe3b466a414b8046441055195.RadialProgressView p3)
	{
		super ();
		if (getClass () == cl_Timer.class)
			mono.android.TypeManager.Activate ("StopWatch.cl_Timer, StopWatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Widget.Button&, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Widget.Button&, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:RadialProgress.RadialProgressView&, RadialProgress.Android, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}

	public cl_Timer (android.app.Activity p0, android.widget.Button p1, android.widget.Button p2)
	{
		super ();
		if (getClass () == cl_Timer.class)
			mono.android.TypeManager.Activate ("StopWatch.cl_Timer, StopWatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Widget.Button, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Widget.Button, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1, p2 });
	}

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
