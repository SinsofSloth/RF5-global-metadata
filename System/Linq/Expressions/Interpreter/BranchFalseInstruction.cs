internal sealed class BranchFalseInstruction : OffsetInstruction // TypeDefIndex: 2368
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1976830 Offset: 0x1976931 VA: 0x1976830 Slot: 10
	public override Instruction[] get_Cache() { }

	// RVA: 0x19768D0 Offset: 0x19769D1 VA: 0x19768D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1976920 Offset: 0x1976A21 VA: 0x1976920 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1976930 Offset: 0x1976A31 VA: 0x1976930 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19769E0 Offset: 0x1976AE1 VA: 0x19769E0
	public void .ctor() { }
}

