private sealed class GenericEnumFormatter.EnumSerialize<T> : MulticastDelegate // TypeDefIndex: 5407
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DFB00 Offset: 0x27DFC01 VA: 0x27DFB00
	|-GenericEnumFormatter.EnumSerialize<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref MessagePackWriter writer, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DFB20 Offset: 0x27DFC21 VA: 0x27DFB20
	|-GenericEnumFormatter.EnumSerialize<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref MessagePackWriter writer, ref T value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DFDC0 Offset: 0x27DFEC1 VA: 0x27DFDC0
	|-GenericEnumFormatter.EnumSerialize<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref MessagePackWriter writer, ref T value, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DFE60 Offset: 0x27DFF61 VA: 0x27DFE60
	|-GenericEnumFormatter.EnumSerialize<object>.EndInvoke
	*/
}

