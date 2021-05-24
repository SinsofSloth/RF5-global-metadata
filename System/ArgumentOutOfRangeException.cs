[ComVisibleAttribute] // RVA: 0xABA30 Offset: 0xABB31 VA: 0xABA30
[Serializable]
public class ArgumentOutOfRangeException : ArgumentException, ISerializable // TypeDefIndex: 178
{
	// Fields
	private static string _rangeMessage; // 0x0
	private object m_actualValue; // 0x90

	// Properties
	private static string RangeMessage { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1848480 Offset: 0x1848581 VA: 0x1848480
	private static string get_RangeMessage() { }

	// RVA: 0x1848520 Offset: 0x1848621 VA: 0x1848520
	public void .ctor() { }

	// RVA: 0x1848580 Offset: 0x1848681 VA: 0x1848580
	public void .ctor(string paramName) { }

	// RVA: 0x18485F0 Offset: 0x18486F1 VA: 0x18485F0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x1848650 Offset: 0x1848751 VA: 0x1848650
	public void .ctor(string paramName, object actualValue, string message) { }

	// RVA: 0x18486D0 Offset: 0x18487D1 VA: 0x18486D0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1848800 Offset: 0x1848901 VA: 0x1848800 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1848910 Offset: 0x1848A11 VA: 0x1848910
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

