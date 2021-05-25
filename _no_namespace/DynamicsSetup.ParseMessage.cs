public class DynamicsSetup.ParseMessage // TypeDefIndex: 9125
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x195FB0 Offset: 0x1960B1 VA: 0x195FB0
	private string <Message>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x195FC0 Offset: 0x1960C1 VA: 0x195FC0
	private string <SourceLine>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x195FD0 Offset: 0x1960D1 VA: 0x195FD0
	private string <Exception>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x195FE0 Offset: 0x1960E1 VA: 0x195FE0
	private Object <Context>k__BackingField; // 0x28

	// Properties
	public string Message { get; set; }
	public string SourceLine { get; set; }
	public string Exception { get; set; }
	public Object Context { get; set; }

	// Methods

	// RVA: 0x1FFD850 Offset: 0x1FFD951 VA: 0x1FFD850
	public void .ctor(string message, string sourceLine = "", string exception = "", Object context) { }

	// RVA: 0x1FFD2C0 Offset: 0x1FFD3C1 VA: 0x1FFD2C0
	public void .ctor(string message, IEnumerable<string> sourceLineItems, string exception = "", Object context) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4E90 Offset: 0x1B4F91 VA: 0x1B4E90
	// RVA: 0x1FFE360 Offset: 0x1FFE461 VA: 0x1FFE360
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4EA0 Offset: 0x1B4FA1 VA: 0x1B4EA0
	// RVA: 0x1FFE370 Offset: 0x1FFE471 VA: 0x1FFE370
	private void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4EB0 Offset: 0x1B4FB1 VA: 0x1B4EB0
	// RVA: 0x1FFE380 Offset: 0x1FFE481 VA: 0x1FFE380
	public string get_SourceLine() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4EC0 Offset: 0x1B4FC1 VA: 0x1B4EC0
	// RVA: 0x1FFE390 Offset: 0x1FFE491 VA: 0x1FFE390
	private void set_SourceLine(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4ED0 Offset: 0x1B4FD1 VA: 0x1B4ED0
	// RVA: 0x1FFE3A0 Offset: 0x1FFE4A1 VA: 0x1FFE3A0
	public string get_Exception() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4EE0 Offset: 0x1B4FE1 VA: 0x1B4EE0
	// RVA: 0x1FFE3B0 Offset: 0x1FFE4B1 VA: 0x1FFE3B0
	private void set_Exception(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4EF0 Offset: 0x1B4FF1 VA: 0x1B4EF0
	// RVA: 0x1FFE3C0 Offset: 0x1FFE4C1 VA: 0x1FFE3C0
	public Object get_Context() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4F00 Offset: 0x1B5001 VA: 0x1B4F00
	// RVA: 0x1FFE3D0 Offset: 0x1FFE4D1 VA: 0x1FFE3D0
	private void set_Context(Object value) { }

	// RVA: 0x1FFE3E0 Offset: 0x1FFE4E1 VA: 0x1FFE3E0
	public string ToLogMessage() { }
}

