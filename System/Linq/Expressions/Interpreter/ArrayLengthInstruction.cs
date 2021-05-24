internal sealed class ArrayLengthInstruction : Instruction // TypeDefIndex: 2360
{
	// Fields
	public static readonly ArrayLengthInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1976170 Offset: 0x1976271 VA: 0x1976170 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1976180 Offset: 0x1976281 VA: 0x1976180 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1976190 Offset: 0x1976291 VA: 0x1976190 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19761E0 Offset: 0x19762E1 VA: 0x19761E0
	private void .ctor() { }

	// RVA: 0x19761F0 Offset: 0x19762F1 VA: 0x19761F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19762A0 Offset: 0x19763A1 VA: 0x19762A0
	private static void .cctor() { }
}

