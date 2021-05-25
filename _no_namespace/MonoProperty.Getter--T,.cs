private sealed class MonoProperty.Getter<T, R> : MulticastDelegate // TypeDefIndex: 607
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E2210 Offset: 0x26E2311 VA: 0x26E2210
	|-MonoProperty.Getter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual R Invoke(T _this) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E2230 Offset: 0x26E2331 VA: 0x26E2230
	|-MonoProperty.Getter<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T _this, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E2610 Offset: 0x26E2711 VA: 0x26E2610
	|-MonoProperty.Getter<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E2640 Offset: 0x26E2741 VA: 0x26E2640
	|-MonoProperty.Getter<object, object>.EndInvoke
	*/
}

