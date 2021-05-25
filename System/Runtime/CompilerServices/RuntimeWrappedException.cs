[Serializable]
public sealed class RuntimeWrappedException : Exception // TypeDefIndex: 1261
{
	// Fields
	private object m_wrappedException; // 0x88

	// Properties
	public object WrappedException { get; }

	// Methods

	// RVA: 0x1802A60 Offset: 0x1802B61 VA: 0x1802A60
	private void .ctor(object thrownObject) { }

	// RVA: 0x1802B20 Offset: 0x1802C21 VA: 0x1802B20
	public object get_WrappedException() { }

	// RVA: 0x1802B30 Offset: 0x1802C31 VA: 0x1802B30 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1802C40 Offset: 0x1802D41 VA: 0x1802C40
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1802D40 Offset: 0x1802E41 VA: 0x1802D40
	internal void .ctor() { }
}

