[ComVisibleAttribute] // RVA: 0xACC10 Offset: 0xACD11 VA: 0xACC10
[Serializable]
public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 340
{
	// Fields
	private object _Exception; // 0x10
	private bool _IsTerminating; // 0x18

	// Properties
	public object ExceptionObject { get; }
	public bool IsTerminating { get; }

	// Methods

	// RVA: 0x1AE3E90 Offset: 0x1AE3F91 VA: 0x1AE3E90
	public void .ctor(object exception, bool isTerminating) { }

	[ReliabilityContractAttribute] // RVA: 0xB70E0 Offset: 0xB71E1 VA: 0xB70E0
	// RVA: 0x1AE3F30 Offset: 0x1AE4031 VA: 0x1AE3F30
	public object get_ExceptionObject() { }

	[ReliabilityContractAttribute] // RVA: 0xB7100 Offset: 0xB7201 VA: 0xB7100
	// RVA: 0x1AE3F40 Offset: 0x1AE4041 VA: 0x1AE3F40
	public bool get_IsTerminating() { }
}

