private sealed class DynamicObjectTypeFallbackFormatter.SerializeMethod : MulticastDelegate // TypeDefIndex: 5403
{
	// Methods

	// RVA: 0x16570F0 Offset: 0x16571F1 VA: 0x16570F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1656AE0 Offset: 0x1656BE1 VA: 0x1656AE0 Slot: 13
	public virtual void Invoke(object dynamicFormatter, ref MessagePackWriter writer, object value, MessagePackSerializerOptions options) { }

	// RVA: 0x1657110 Offset: 0x1657211 VA: 0x1657110 Slot: 14
	public virtual IAsyncResult BeginInvoke(object dynamicFormatter, ref MessagePackWriter writer, object value, MessagePackSerializerOptions options, AsyncCallback callback, object object) { }

	// RVA: 0x16571C0 Offset: 0x16572C1 VA: 0x16571C0 Slot: 15
	public virtual void EndInvoke(ref MessagePackWriter writer, IAsyncResult result) { }
}

