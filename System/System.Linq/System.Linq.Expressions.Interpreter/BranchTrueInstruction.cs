internal sealed class BranchTrueInstruction : OffsetInstruction // TypeDefIndex: 2369
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1977050 Offset: 0x1977151 VA: 0x1977050 Slot: 10
	public override Instruction[] get_Cache() { }

	// RVA: 0x19770F0 Offset: 0x19771F1 VA: 0x19770F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1977140 Offset: 0x1977241 VA: 0x1977140 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1977150 Offset: 0x1977251 VA: 0x1977150 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1977200 Offset: 0x1977301 VA: 0x1977200
	public void .ctor() { }
}

