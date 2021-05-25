public sealed class ConditionalWeakTable.CreateValueCallback<TKey, TValue> : MulticastDelegate // TypeDefIndex: 1289
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EABB0 Offset: 0x26EACB1 VA: 0x26EABB0
	|-ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession>..ctor
	|-ConditionalWeakTable.CreateValueCallback<object, object>..ctor
	|-ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EABD0 Offset: 0x26EACD1 VA: 0x26EABD0
	|-ConditionalWeakTable.CreateValueCallback<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(TKey key, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EAFB0 Offset: 0x26EB0B1 VA: 0x26EAFB0
	|-ConditionalWeakTable.CreateValueCallback<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TValue EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EAFE0 Offset: 0x26EB0E1 VA: 0x26EAFE0
	|-ConditionalWeakTable.CreateValueCallback<object, object>.EndInvoke
	*/
}

