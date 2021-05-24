internal abstract class SubInstruction : Instruction // TypeDefIndex: 2672
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x191E070 Offset: 0x191E171 VA: 0x191E070 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x191E080 Offset: 0x191E181 VA: 0x191E080 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x191E090 Offset: 0x191E191 VA: 0x191E090 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x191E0E0 Offset: 0x191E1E1 VA: 0x191E0E0
	private void .ctor() { }

	// RVA: 0x191E0F0 Offset: 0x191E1F1 VA: 0x191E0F0
	public static Instruction Create(Type type) { }
}

