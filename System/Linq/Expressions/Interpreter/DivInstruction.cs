internal abstract class DivInstruction : Instruction // TypeDefIndex: 2397
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

	// RVA: 0x197AF60 Offset: 0x197B061 VA: 0x197AF60 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x197AF70 Offset: 0x197B071 VA: 0x197AF70 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x197AF80 Offset: 0x197B081 VA: 0x197AF80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x197AFD0 Offset: 0x197B0D1 VA: 0x197AFD0
	private void .ctor() { }

	// RVA: 0x197AFE0 Offset: 0x197B0E1 VA: 0x197AFE0
	public static Instruction Create(Type type) { }
}

