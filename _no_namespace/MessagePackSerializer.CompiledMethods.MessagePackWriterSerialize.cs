internal sealed class MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize : MulticastDelegate // TypeDefIndex: 5151
{
	// Methods

	// RVA: 0x14E97B0 Offset: 0x14E98B1 VA: 0x14E97B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14E97D0 Offset: 0x14E98D1 VA: 0x14E97D0 Slot: 13
	public virtual void Invoke(ref MessagePackWriter writer, object value, MessagePackSerializerOptions options) { }

	// RVA: 0x14E9A90 Offset: 0x14E9B91 VA: 0x14E9A90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref MessagePackWriter writer, object value, MessagePackSerializerOptions options, AsyncCallback callback, object object) { }

	// RVA: 0x14E9B40 Offset: 0x14E9C41 VA: 0x14E9B40 Slot: 15
	public virtual void EndInvoke(ref MessagePackWriter writer, IAsyncResult result) { }
}

