private sealed class MonoProperty.StaticGetter<R> : MulticastDelegate // TypeDefIndex: 608
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E2650 Offset: 0x26E2751 VA: 0x26E2650
	|-MonoProperty.StaticGetter<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual R Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E2670 Offset: 0x26E2771 VA: 0x26E2670
	|-MonoProperty.StaticGetter<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E28B0 Offset: 0x26E29B1 VA: 0x26E28B0
	|-MonoProperty.StaticGetter<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E28E0 Offset: 0x26E29E1 VA: 0x26E28E0
	|-MonoProperty.StaticGetter<object>.EndInvoke
	*/
}

