[ComVisibleAttribute] // RVA: 0xAE920 Offset: 0xAEA21 VA: 0xAE920
[Serializable]
public class FileLoadException : IOException // TypeDefIndex: 642
{
	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x18A3A60 Offset: 0x18A3B61 VA: 0x18A3A60
	public void .ctor() { }

	// RVA: 0x18A3AF0 Offset: 0x18A3BF1 VA: 0x18A3AF0
	public void .ctor(string message) { }

	// RVA: 0x18A3B40 Offset: 0x18A3C41 VA: 0x18A3B40 Slot: 5
	public override string get_Message() { }

	// RVA: 0x18A3C00 Offset: 0x18A3D01 VA: 0x18A3C00
	private void SetMessageField() { }

	// RVA: 0x18A3D30 Offset: 0x18A3E31 VA: 0x18A3D30 Slot: 3
	public override string ToString() { }

	// RVA: 0x18A4020 Offset: 0x18A4121 VA: 0x18A4020
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18A4180 Offset: 0x18A4281 VA: 0x18A4180
	public string get_FusionLog() { }

	// RVA: 0x18A4190 Offset: 0x18A4291 VA: 0x18A4190 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18A3CB0 Offset: 0x18A3DB1 VA: 0x18A3CB0
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }
}

