internal abstract class IncrementInstruction : Instruction // TypeDefIndex: 2471
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

	// RVA: 0x1984280 Offset: 0x1984381 VA: 0x1984280 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1984290 Offset: 0x1984391 VA: 0x1984290 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19842A0 Offset: 0x19843A1 VA: 0x19842A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19842F0 Offset: 0x19843F1 VA: 0x19842F0
	private void .ctor() { }

	// RVA: 0x1984300 Offset: 0x1984401 VA: 0x1984300
	public static Instruction Create(Type type) { }
}

