internal abstract class AndInstruction : Instruction // TypeDefIndex: 2345
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

	// RVA: 0x1975130 Offset: 0x1975231 VA: 0x1975130 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1975140 Offset: 0x1975241 VA: 0x1975140 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1975150 Offset: 0x1975251 VA: 0x1975150 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19751A0 Offset: 0x19752A1 VA: 0x19751A0
	private void .ctor() { }

	// RVA: 0x19751B0 Offset: 0x19752B1 VA: 0x19751B0
	public static Instruction Create(Type type) { }
}

