internal abstract class ExclusiveOrInstruction : Instruction // TypeDefIndex: 2432
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x197F980 Offset: 0x197FA81 VA: 0x197F980 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x197F990 Offset: 0x197FA91 VA: 0x197F990 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x197F9A0 Offset: 0x197FAA1 VA: 0x197F9A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x197F9F0 Offset: 0x197FAF1 VA: 0x197F9F0
	private void .ctor() { }

	// RVA: 0x197FA00 Offset: 0x197FB01 VA: 0x197FA00
	public static Instruction Create(Type type) { }
}

