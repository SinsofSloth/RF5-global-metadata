[Serializable]
internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 368
{
	// Fields
	private Delegate _delegate; // 0x10

	// Methods

	// RVA: 0x19B4400 Offset: 0x19B4501 VA: 0x19B4400
	private void .ctor(SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0x19B3AF0 Offset: 0x19B3BF1 VA: 0x19B3AF0
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0x19B4A70 Offset: 0x19B4B71 VA: 0x19B4A70 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19B4AD0 Offset: 0x19B4BD1 VA: 0x19B4AD0 Slot: 5
	public object GetRealObject(StreamingContext context) { }
}

