internal sealed class CoalescingBranchInstruction : OffsetInstruction // TypeDefIndex: 2370
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1979420 Offset: 0x1979521 VA: 0x1979420 Slot: 10
	public override Instruction[] get_Cache() { }

	// RVA: 0x19794C0 Offset: 0x19795C1 VA: 0x19794C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1979510 Offset: 0x1979611 VA: 0x1979510 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1979520 Offset: 0x1979621 VA: 0x1979520 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1979530 Offset: 0x1979631 VA: 0x1979530 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1979580 Offset: 0x1979681 VA: 0x1979580
	public void .ctor() { }
}

