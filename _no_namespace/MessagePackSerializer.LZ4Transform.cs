private sealed class MessagePackSerializer.LZ4Transform : MulticastDelegate // TypeDefIndex: 5154
{
	// Methods

	// RVA: 0x14E9B70 Offset: 0x14E9C71 VA: 0x14E9B70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14E9B90 Offset: 0x14E9C91 VA: 0x14E9B90 Slot: 13
	public virtual int Invoke(ReadOnlySpan<byte> input, Span<byte> output) { }

	// RVA: 0x14E9FF0 Offset: 0x14EA0F1 VA: 0x14E9FF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ReadOnlySpan<byte> input, Span<byte> output, AsyncCallback callback, object object) { }

	// RVA: 0x14EA0A0 Offset: 0x14EA1A1 VA: 0x14EA0A0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

