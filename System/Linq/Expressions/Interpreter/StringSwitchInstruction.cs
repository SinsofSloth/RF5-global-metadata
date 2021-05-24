internal sealed class StringSwitchInstruction : Instruction // TypeDefIndex: 2386
{
	// Fields
	private readonly Dictionary<string, int> _cases; // 0x10
	private readonly StrongBox<int> _nullCase; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x191DEE0 Offset: 0x191DFE1 VA: 0x191DEE0
	internal void .ctor(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x191DF30 Offset: 0x191E031 VA: 0x191DF30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x191DF80 Offset: 0x191E081 VA: 0x191DF80 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x191DF90 Offset: 0x191E091 VA: 0x191DF90 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

