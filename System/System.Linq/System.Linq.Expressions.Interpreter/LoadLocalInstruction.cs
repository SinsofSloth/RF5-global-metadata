internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 2547
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x190F380 Offset: 0x190F481 VA: 0x190F380
	internal void .ctor(int index) { }

	// RVA: 0x190F3B0 Offset: 0x190F4B1 VA: 0x190F3B0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x190F3C0 Offset: 0x190F4C1 VA: 0x190F3C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x190F410 Offset: 0x190F511 VA: 0x190F410 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x190F4C0 Offset: 0x190F5C1 VA: 0x190F4C0 Slot: 10
	public Instruction BoxIfIndexMatches(int index) { }
}

