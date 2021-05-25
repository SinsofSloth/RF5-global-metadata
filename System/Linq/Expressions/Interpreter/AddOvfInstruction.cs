internal abstract class AddOvfInstruction : Instruction // TypeDefIndex: 2338
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

	// RVA: 0x1974060 Offset: 0x1974161 VA: 0x1974060 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1974070 Offset: 0x1974171 VA: 0x1974070 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1974080 Offset: 0x1974181 VA: 0x1974080 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19740D0 Offset: 0x19741D1 VA: 0x19740D0
	private void .ctor() { }

	// RVA: 0x19740E0 Offset: 0x19741E1 VA: 0x19740E0
	public static Instruction Create(Type type) { }
}

