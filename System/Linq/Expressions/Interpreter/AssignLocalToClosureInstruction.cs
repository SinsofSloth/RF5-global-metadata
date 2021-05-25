internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction // TypeDefIndex: 2555
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19766A0 Offset: 0x19767A1 VA: 0x19766A0
	internal void .ctor(int index) { }

	// RVA: 0x19766B0 Offset: 0x19767B1 VA: 0x19766B0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19766C0 Offset: 0x19767C1 VA: 0x19766C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19766D0 Offset: 0x19767D1 VA: 0x19766D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1976720 Offset: 0x1976821 VA: 0x1976720 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

