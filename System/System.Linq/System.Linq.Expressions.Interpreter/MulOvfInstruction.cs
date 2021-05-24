internal abstract class MulOvfInstruction : Instruction // TypeDefIndex: 2589
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1912BD0 Offset: 0x1912CD1 VA: 0x1912BD0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1912BE0 Offset: 0x1912CE1 VA: 0x1912BE0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1912BF0 Offset: 0x1912CF1 VA: 0x1912BF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1912C40 Offset: 0x1912D41 VA: 0x1912C40
	private void .ctor() { }

	// RVA: 0x1912C50 Offset: 0x1912D51 VA: 0x1912C50
	public static Instruction Create(Type type) { }
}

