internal struct ExecutionContextSwitcher // TypeDefIndex: 784
{
	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB8A10 Offset: 0xB8B11 VA: 0xB8A10
	[ReliabilityContractAttribute] // RVA: 0xB8A10 Offset: 0xB8B11 VA: 0xB8A10
	// RVA: 0x176F0 Offset: 0x177F1 VA: 0x176F0
	internal bool UndoNoThrow() { }

	[ReliabilityContractAttribute] // RVA: 0xB8A50 Offset: 0xB8B51 VA: 0xB8A50
	// RVA: 0x17700 Offset: 0x17801 VA: 0x17700
	internal void Undo() { }
}

