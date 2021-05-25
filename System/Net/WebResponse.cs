[Serializable]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 1909
{
	// Properties
	public virtual WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0x170E2D0 Offset: 0x170E3D1 VA: 0x170E2D0
	protected void .ctor() { }

	// RVA: 0x170E2E0 Offset: 0x170E3E1 VA: 0x170E2E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170E2F0 Offset: 0x170E3F1 VA: 0x170E2F0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170E300 Offset: 0x170E401 VA: 0x170E300 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170E310 Offset: 0x170E411 VA: 0x170E310 Slot: 9
	public virtual void Close() { }

	// RVA: 0x170E320 Offset: 0x170E421 VA: 0x170E320 Slot: 7
	public void Dispose() { }

	// RVA: 0x170E3A0 Offset: 0x170E4A1 VA: 0x170E3A0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x170E480 Offset: 0x170E581 VA: 0x170E480 Slot: 11
	public virtual Stream GetResponseStream() { }

	// RVA: 0x170E4D0 Offset: 0x170E5D1 VA: 0x170E4D0 Slot: 12
	public virtual WebHeaderCollection get_Headers() { }
}

