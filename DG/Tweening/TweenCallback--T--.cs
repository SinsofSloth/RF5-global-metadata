public sealed class TweenCallback<T> : MulticastDelegate // TypeDefIndex: 4916
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C873E0 Offset: 0x2C874E1 VA: 0x2C873E0
	|-TweenCallback<int>..ctor
	|
	|-RVA: 0x2C87740 Offset: 0x2C87841 VA: 0x2C87740
	|-TweenCallback<object>..ctor
	|
	|-RVA: 0x2C87B70 Offset: 0x2C87C71 VA: 0x2C87B70
	|-TweenCallback<float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C87400 Offset: 0x2C87501 VA: 0x2C87400
	|-TweenCallback<int>.Invoke
	|
	|-RVA: 0x2C87760 Offset: 0x2C87861 VA: 0x2C87760
	|-TweenCallback<object>.Invoke
	|
	|-RVA: 0x2C87B90 Offset: 0x2C87C91 VA: 0x2C87B90
	|-TweenCallback<float>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C876A0 Offset: 0x2C877A1 VA: 0x2C876A0
	|-TweenCallback<int>.BeginInvoke
	|
	|-RVA: 0x2C87B30 Offset: 0x2C87C31 VA: 0x2C87B30
	|-TweenCallback<object>.BeginInvoke
	|
	|-RVA: 0x2C87E20 Offset: 0x2C87F21 VA: 0x2C87E20
	|-TweenCallback<float>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C87730 Offset: 0x2C87831 VA: 0x2C87730
	|-TweenCallback<int>.EndInvoke
	|
	|-RVA: 0x2C87B60 Offset: 0x2C87C61 VA: 0x2C87B60
	|-TweenCallback<object>.EndInvoke
	|
	|-RVA: 0x2C87EB0 Offset: 0x2C87FB1 VA: 0x2C87EB0
	|-TweenCallback<float>.EndInvoke
	*/
}

