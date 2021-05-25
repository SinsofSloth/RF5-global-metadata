internal sealed class DefaultValueInstruction : Instruction // TypeDefIndex: 2396
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x197A710 Offset: 0x197A811 VA: 0x197A710
	internal void .ctor(Type type) { }

	// RVA: 0x197A750 Offset: 0x197A851 VA: 0x197A750 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x197A760 Offset: 0x197A861 VA: 0x197A760 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x197A7B0 Offset: 0x197A8B1 VA: 0x197A7B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x197A800 Offset: 0x197A901 VA: 0x197A800 Slot: 3
	public override string ToString() { }
}

