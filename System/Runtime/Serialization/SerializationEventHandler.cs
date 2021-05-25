[Serializable]
internal sealed class SerializationEventHandler : MulticastDelegate // TypeDefIndex: 997
{
	// Methods

	// RVA: 0x151E060 Offset: 0x151E161 VA: 0x151E060
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151BCE0 Offset: 0x151BDE1 VA: 0x151BCE0 Slot: 13
	public virtual void Invoke(StreamingContext context) { }

	// RVA: 0x151E080 Offset: 0x151E181 VA: 0x151E080 Slot: 14
	public virtual IAsyncResult BeginInvoke(StreamingContext context, AsyncCallback callback, object object) { }

	// RVA: 0x151E110 Offset: 0x151E211 VA: 0x151E110 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

