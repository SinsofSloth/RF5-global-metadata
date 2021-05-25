internal sealed class Utilities.GetWriterBytesAction<TArg> : MulticastDelegate // TypeDefIndex: 5180
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD120 Offset: 0x2ADD221 VA: 0x2ADD120
	|-Utilities.GetWriterBytesAction<object>..ctor
	|-Utilities.GetWriterBytesAction<string>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref MessagePackWriter writer, TArg argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD140 Offset: 0x2ADD241 VA: 0x2ADD140
	|-Utilities.GetWriterBytesAction<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref MessagePackWriter writer, TArg argument, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD3E0 Offset: 0x2ADD4E1 VA: 0x2ADD3E0
	|-Utilities.GetWriterBytesAction<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref MessagePackWriter writer, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD480 Offset: 0x2ADD581 VA: 0x2ADD480
	|-Utilities.GetWriterBytesAction<object>.EndInvoke
	*/
}

