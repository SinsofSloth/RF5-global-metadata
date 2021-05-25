[ComVisibleAttribute] // RVA: 0xAE940 Offset: 0xAEA41 VA: 0xAE940
[Serializable]
public class FileNotFoundException : IOException // TypeDefIndex: 643
{
	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x18A4340 Offset: 0x18A4441 VA: 0x18A4340
	public void .ctor() { }

	// RVA: 0x18A43D0 Offset: 0x18A44D1 VA: 0x18A43D0
	public void .ctor(string message) { }

	// RVA: 0x18A2450 Offset: 0x18A2551 VA: 0x18A2450
	public void .ctor(string message, string fileName) { }

	// RVA: 0x18A4420 Offset: 0x18A4521 VA: 0x18A4420 Slot: 5
	public override string get_Message() { }

	// RVA: 0x18A4450 Offset: 0x18A4551 VA: 0x18A4450
	private void SetMessageField() { }

	// RVA: 0x18A4560 Offset: 0x18A4661 VA: 0x18A4560 Slot: 3
	public override string ToString() { }

	// RVA: 0x18A4850 Offset: 0x18A4951 VA: 0x18A4850
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18A49B0 Offset: 0x18A4AB1 VA: 0x18A49B0
	public string get_FusionLog() { }

	// RVA: 0x18A49C0 Offset: 0x18A4AC1 VA: 0x18A49C0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

