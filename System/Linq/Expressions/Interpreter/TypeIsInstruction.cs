internal sealed class TypeIsInstruction : Instruction // TypeDefIndex: 2689
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1921020 Offset: 0x1921121 VA: 0x1921020
	internal void .ctor(Type type) { }

	// RVA: 0x1921060 Offset: 0x1921161 VA: 0x1921060 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1921070 Offset: 0x1921171 VA: 0x1921070 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1921080 Offset: 0x1921181 VA: 0x1921080 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19210D0 Offset: 0x19211D1 VA: 0x19210D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1921140 Offset: 0x1921241 VA: 0x1921140 Slot: 3
	public override string ToString() { }
}

