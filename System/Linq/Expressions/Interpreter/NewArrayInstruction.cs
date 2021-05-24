internal sealed class NewArrayInstruction : Instruction // TypeDefIndex: 2356
{
	// Fields
	private readonly Type _elementType; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1914CD0 Offset: 0x1914DD1 VA: 0x1914CD0
	internal void .ctor(Type elementType) { }

	// RVA: 0x1914D10 Offset: 0x1914E11 VA: 0x1914D10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1914D20 Offset: 0x1914E21 VA: 0x1914D20 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1914D30 Offset: 0x1914E31 VA: 0x1914D30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1914D80 Offset: 0x1914E81 VA: 0x1914D80 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

