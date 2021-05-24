internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 2552
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x191DC50 Offset: 0x191DD51 VA: 0x191DC50
	internal void .ctor(int index) { }

	// RVA: 0x191DC80 Offset: 0x191DD81 VA: 0x191DC80 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x191DC90 Offset: 0x191DD91 VA: 0x191DC90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x191DCE0 Offset: 0x191DDE1 VA: 0x191DCE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x191DD80 Offset: 0x191DE81 VA: 0x191DD80 Slot: 10
	public Instruction BoxIfIndexMatches(int index) { }
}

