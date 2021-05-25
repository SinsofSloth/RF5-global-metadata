[ComVisibleAttribute] // RVA: 0xABB80 Offset: 0xABC81 VA: 0xABB80
[Serializable]
public class BadImageFormatException : SystemException // TypeDefIndex: 187
{
	// Fields
	private string _fileName; // 0x88
	private string _fusionLog; // 0x90

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x1851D30 Offset: 0x1851E31 VA: 0x1851D30
	public void .ctor() { }

	// RVA: 0x1851DB0 Offset: 0x1851EB1 VA: 0x1851DB0
	public void .ctor(string message) { }

	// RVA: 0x1851DF0 Offset: 0x1851EF1 VA: 0x1851DF0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1851E30 Offset: 0x1851F31 VA: 0x1851E30
	public void .ctor(string message, string fileName) { }

	// RVA: 0x1851E80 Offset: 0x1851F81 VA: 0x1851E80 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1851F40 Offset: 0x1852041 VA: 0x1851F40
	private void SetMessageField() { }

	// RVA: 0x1851FE0 Offset: 0x18520E1 VA: 0x1851FE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18522D0 Offset: 0x18523D1 VA: 0x18522D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1852430 Offset: 0x1852531 VA: 0x1852430
	public string get_FusionLog() { }

	// RVA: 0x1852440 Offset: 0x1852541 VA: 0x1852440 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

