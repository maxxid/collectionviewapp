package crc647f25f480157a6a21;


public class SegmentedControlRenderer
	extends crc643f46942d9dd1fff9.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setBackgroundColor:(I)V:GetSetBackgroundColor_IHandler\n" +
			"";
		mono.android.Runtime.register ("Plugin.Segmented.Control.Droid.SegmentedControlRenderer, Plugin.Segmented.Control.Droid", SegmentedControlRenderer.class, __md_methods);
	}


	public SegmentedControlRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SegmentedControlRenderer.class) {
			mono.android.TypeManager.Activate ("Plugin.Segmented.Control.Droid.SegmentedControlRenderer, Plugin.Segmented.Control.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public SegmentedControlRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SegmentedControlRenderer.class) {
			mono.android.TypeManager.Activate ("Plugin.Segmented.Control.Droid.SegmentedControlRenderer, Plugin.Segmented.Control.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public SegmentedControlRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SegmentedControlRenderer.class) {
			mono.android.TypeManager.Activate ("Plugin.Segmented.Control.Droid.SegmentedControlRenderer, Plugin.Segmented.Control.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public void setBackgroundColor (int p0)
	{
		n_setBackgroundColor (p0);
	}

	private native void n_setBackgroundColor (int p0);

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
