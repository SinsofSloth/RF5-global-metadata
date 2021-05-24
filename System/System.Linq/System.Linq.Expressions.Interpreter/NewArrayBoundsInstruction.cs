internal sealed class NewArrayBoundsInstruction : Instruction // TypeDefIndex: 2357
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _rank; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1914960 Offset: 0x1914A61 VA: 0x1914960
	internal void .ctor(Type elementType, int rank) { }

	// RVA: 0x19149B0 Offset: 0x1914AB1 VA: 0x19149B0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19149C0 Offset: 0x1914AC1 VA: 0x19149C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19149D0 Offset: 0x1914AD1 VA: 0x19149D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1914A20 Offset: 0x1914B21 VA: 0x1914A20 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

