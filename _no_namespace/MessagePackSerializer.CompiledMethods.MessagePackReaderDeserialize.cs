internal sealed class MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize : MulticastDelegate // TypeDefIndex: 5152
{
	// Methods

	// RVA: 0x14E9410 Offset: 0x14E9511 VA: 0x14E9410
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14E9430 Offset: 0x14E9531 VA: 0x14E9430 Slot: 13
	public virtual object Invoke(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x14E96E0 Offset: 0x14E97E1 VA: 0x14E96E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref MessagePackReader reader, MessagePackSerializerOptions options, AsyncCallback callback, object object) { }

	// RVA: 0x14E9780 Offset: 0x14E9881 VA: 0x14E9780 Slot: 15
	public virtual object EndInvoke(ref MessagePackReader reader, IAsyncResult result) { }
}

