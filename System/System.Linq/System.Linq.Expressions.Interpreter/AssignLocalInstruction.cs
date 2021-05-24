internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 2551
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19764E0 Offset: 0x19765E1 VA: 0x19764E0
	internal void .ctor(int index) { }

	// RVA: 0x19764F0 Offset: 0x19765F1 VA: 0x19764F0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1976500 Offset: 0x1976601 VA: 0x1976500 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1976510 Offset: 0x1976611 VA: 0x1976510 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1976560 Offset: 0x1976661 VA: 0x1976560 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1976600 Offset: 0x1976701 VA: 0x1976600 Slot: 10
	public Instruction BoxIfIndexMatches(int index) { }
}

