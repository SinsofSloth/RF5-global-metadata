internal abstract class NotInstruction : Instruction // TypeDefIndex: 2633
{
	// Fields
	public static Instruction s_Boolean; // 0x0
	public static Instruction s_Int64; // 0x8
	public static Instruction s_Int32; // 0x10
	public static Instruction s_Int16; // 0x18
	public static Instruction s_UInt64; // 0x20
	public static Instruction s_UInt32; // 0x28
	public static Instruction s_UInt16; // 0x30
	public static Instruction s_Byte; // 0x38
	public static Instruction s_SByte; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1917540 Offset: 0x1917641 VA: 0x1917540
	private void .ctor() { }

	// RVA: 0x1917550 Offset: 0x1917651 VA: 0x1917550 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1917560 Offset: 0x1917661 VA: 0x1917560 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1917570 Offset: 0x1917671 VA: 0x1917570 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19175C0 Offset: 0x19176C1 VA: 0x19175C0
	public static Instruction Create(Type type) { }
}

