internal abstract class MulInstruction : Instruction // TypeDefIndex: 2580
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

	// RVA: 0x1911B80 Offset: 0x1911C81 VA: 0x1911B80 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1911B90 Offset: 0x1911C91 VA: 0x1911B90 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1911BA0 Offset: 0x1911CA1 VA: 0x1911BA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1911BF0 Offset: 0x1911CF1 VA: 0x1911BF0
	private void .ctor() { }

	// RVA: 0x1911C00 Offset: 0x1911D01 VA: 0x1911C00
	public static Instruction Create(Type type) { }
}

