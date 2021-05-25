private sealed class GenericEnumFormatter.EnumDeserialize<T> : MulticastDelegate // TypeDefIndex: 5408
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DF780 Offset: 0x27DF881 VA: 0x27DF780
	|-GenericEnumFormatter.EnumDeserialize<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual T Invoke(ref MessagePackReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DF7A0 Offset: 0x27DF8A1 VA: 0x27DF7A0
	|-GenericEnumFormatter.EnumDeserialize<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref MessagePackReader reader, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DFA30 Offset: 0x27DFB31 VA: 0x27DFA30
	|-GenericEnumFormatter.EnumDeserialize<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual T EndInvoke(ref MessagePackReader reader, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DFAD0 Offset: 0x27DFBD1 VA: 0x27DFAD0
	|-GenericEnumFormatter.EnumDeserialize<object>.EndInvoke
	*/
}

