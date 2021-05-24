internal sealed class LoadObjectInstruction : Instruction // TypeDefIndex: 2668
{
	// Fields
	private readonly object _value; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x190F560 Offset: 0x190F661 VA: 0x190F560
	internal void .ctor(object value) { }

	// RVA: 0x190F5A0 Offset: 0x190F6A1 VA: 0x190F5A0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x190F5B0 Offset: 0x190F6B1 VA: 0x190F5B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x190F600 Offset: 0x190F701 VA: 0x190F600 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x190F690 Offset: 0x190F791 VA: 0x190F690 Slot: 3
	public override string ToString() { }
}

