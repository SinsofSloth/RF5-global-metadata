public sealed class SerializationObjectManager // TypeDefIndex: 1034
{
	// Fields
	private Hashtable m_objectSeenTable; // 0x10
	private SerializationEventHandler m_onSerializedHandler; // 0x18
	private StreamingContext m_context; // 0x20

	// Methods

	// RVA: 0x1520850 Offset: 0x1520951 VA: 0x1520850
	public void .ctor(StreamingContext context) { }

	// RVA: 0x150C290 Offset: 0x150C391 VA: 0x150C290
	public void RegisterObject(object obj) { }

	// RVA: 0x15209D0 Offset: 0x1520AD1 VA: 0x15209D0
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x1520920 Offset: 0x1520A21 VA: 0x1520920
	private void AddOnSerialized(object obj) { }
}

