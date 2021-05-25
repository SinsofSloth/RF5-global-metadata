[ComVisibleAttribute] // RVA: 0xAC380 Offset: 0xAC481 VA: 0xAC380
[Serializable]
public class MissingMethodException : MissingMemberException, ISerializable // TypeDefIndex: 281
{
	// Fields
	private string signature; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x18DE140 Offset: 0x18DE241 VA: 0x18DE140
	public void .ctor() { }

	// RVA: 0x18DE1E0 Offset: 0x18DE2E1 VA: 0x18DE1E0
	public void .ctor(string message) { }

	// RVA: 0x18DE240 Offset: 0x18DE341 VA: 0x18DE240
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18DE250 Offset: 0x18DE351 VA: 0x18DE250 Slot: 5
	public override string get_Message() { }

	// RVA: 0x18DE350 Offset: 0x18DE451 VA: 0x18DE350
	public void .ctor(string className, string methodName) { }

	// RVA: 0x18DE410 Offset: 0x18DE511 VA: 0x18DE410
	private void .ctor(string className, string methodName, string signature, string message) { }
}

