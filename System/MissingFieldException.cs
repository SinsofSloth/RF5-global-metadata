[ComVisibleAttribute] // RVA: 0xAC340 Offset: 0xAC441 VA: 0xAC340
[Serializable]
public class MissingFieldException : MissingMemberException, ISerializable // TypeDefIndex: 279
{
	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x18DD910 Offset: 0x18DDA11 VA: 0x18DD910
	public void .ctor() { }

	// RVA: 0x18DDA00 Offset: 0x18DDB01 VA: 0x18DDA00
	public void .ctor(string message) { }

	// RVA: 0x18DDA60 Offset: 0x18DDB61 VA: 0x18DDA60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18DDBD0 Offset: 0x18DDCD1 VA: 0x18DDBD0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x18DDE70 Offset: 0x18DDF71 VA: 0x18DDE70
	public void .ctor(string className, string fieldName) { }
}

