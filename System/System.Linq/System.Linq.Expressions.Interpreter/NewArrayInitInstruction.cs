internal sealed class NewArrayInitInstruction : Instruction // TypeDefIndex: 2355
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _elementCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1914B60 Offset: 0x1914C61 VA: 0x1914B60
	internal void .ctor(Type elementType, int elementCount) { }

	// RVA: 0x1914BB0 Offset: 0x1914CB1 VA: 0x1914BB0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1914BC0 Offset: 0x1914CC1 VA: 0x1914BC0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1914BD0 Offset: 0x1914CD1 VA: 0x1914BD0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1914C20 Offset: 0x1914D21 VA: 0x1914C20 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

