internal sealed class RuntimeVariablesInstruction : Instruction // TypeDefIndex: 2566
{
	// Fields
	private readonly int _count; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x191D170 Offset: 0x191D271 VA: 0x191D170
	public void .ctor(int count) { }

	// RVA: 0x191D1A0 Offset: 0x191D2A1 VA: 0x191D1A0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x191D1B0 Offset: 0x191D2B1 VA: 0x191D1B0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x191D1C0 Offset: 0x191D2C1 VA: 0x191D1C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x191D210 Offset: 0x191D311 VA: 0x191D210 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

