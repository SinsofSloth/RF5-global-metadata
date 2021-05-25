internal sealed class AnonymousDeserializeFunc<T> : MulticastDelegate // TypeDefIndex: 5332
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286DEC0 Offset: 0x286DFC1 VA: 0x286DEC0
	|-AnonymousDeserializeFunc<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual T Invoke(object[] customFormatters, ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286DEE0 Offset: 0x286DFE1 VA: 0x286DEE0
	|-AnonymousDeserializeFunc<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(object[] customFormatters, ref MessagePackReader reader, MessagePackSerializerOptions options, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286E330 Offset: 0x286E431 VA: 0x286E330
	|-AnonymousDeserializeFunc<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual T EndInvoke(ref MessagePackReader reader, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286E3E0 Offset: 0x286E4E1 VA: 0x286E3E0
	|-AnonymousDeserializeFunc<object>.EndInvoke
	*/
}

