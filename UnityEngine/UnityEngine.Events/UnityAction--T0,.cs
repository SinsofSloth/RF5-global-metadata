public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 3114
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB9030 Offset: 0x2CB9131 VA: 0x2CB9030
	|-UnityAction<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB9050 Offset: 0x2CB9151 VA: 0x2CB9050
	|-UnityAction<object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB94C0 Offset: 0x2CB95C1 VA: 0x2CB94C0
	|-UnityAction<object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB9500 Offset: 0x2CB9601 VA: 0x2CB9500
	|-UnityAction<object, object, object, object>.EndInvoke
	*/
}

