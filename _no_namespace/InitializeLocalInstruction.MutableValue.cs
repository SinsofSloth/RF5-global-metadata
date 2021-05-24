internal sealed class InitializeLocalInstruction.MutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 2564
{
	// Fields
	private readonly Type _type; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x17B56D0 Offset: 0x17B57D1 VA: 0x17B56D0
	internal void .ctor(int index, Type type) { }

	// RVA: 0x17B5710 Offset: 0x17B5811 VA: 0x17B5710 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x17B5880 Offset: 0x17B5981 VA: 0x17B5880 Slot: 10
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x17B5920 Offset: 0x17B5A21 VA: 0x17B5920 Slot: 9
	public override string get_InstructionName() { }
}

