internal abstract class NegateInstruction : Instruction // TypeDefIndex: 2596
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_Single; // 0x18
	private static Instruction s_Double; // 0x20

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19144D0 Offset: 0x19145D1 VA: 0x19144D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19144E0 Offset: 0x19145E1 VA: 0x19144E0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19144F0 Offset: 0x19145F1 VA: 0x19144F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1914540 Offset: 0x1914641 VA: 0x1914540
	private void .ctor() { }

	// RVA: 0x1913F10 Offset: 0x1914011 VA: 0x1913F10
	public static Instruction Create(Type type) { }
}

