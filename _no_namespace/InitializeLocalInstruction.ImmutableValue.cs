internal sealed class InitializeLocalInstruction.ImmutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 2559
{
	// Fields
	private readonly object _defaultValue; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x17B5310 Offset: 0x17B5411 VA: 0x17B5310
	internal void .ctor(int index, object defaultValue) { }

	// RVA: 0x17B5350 Offset: 0x17B5451 VA: 0x17B5350 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x17B53E0 Offset: 0x17B54E1 VA: 0x17B53E0 Slot: 10
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x17B5470 Offset: 0x17B5571 VA: 0x17B5470 Slot: 9
	public override string get_InstructionName() { }
}

