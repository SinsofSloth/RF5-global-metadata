[ComVisibleAttribute] // RVA: 0xAC490 Offset: 0xAC591 VA: 0xAC490
[Serializable]
public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 289
{
	// Fields
	private string objectName; // 0x88

	// Properties
	public override string Message { get; }
	public string ObjectName { get; }

	// Methods

	// RVA: 0x18EB5E0 Offset: 0x18EB6E1 VA: 0x18EB5E0
	private void .ctor() { }

	// RVA: 0x18EB680 Offset: 0x18EB781 VA: 0x18EB680
	public void .ctor(string objectName) { }

	// RVA: 0x18D6490 Offset: 0x18D6591 VA: 0x18D6490
	public void .ctor(string objectName, string message) { }

	// RVA: 0x18EB730 Offset: 0x18EB831 VA: 0x18EB730 Slot: 5
	public override string get_Message() { }

	// RVA: 0x18EB8C0 Offset: 0x18EB9C1 VA: 0x18EB8C0
	public string get_ObjectName() { }

	// RVA: 0x18EB960 Offset: 0x18EBA61 VA: 0x18EB960
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18EBA00 Offset: 0x18EBB01 VA: 0x18EBA00 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

