internal sealed class GetArrayItemInstruction : Instruction // TypeDefIndex: 2358
{
	// Fields
	internal static readonly GetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1980AA0 Offset: 0x1980BA1 VA: 0x1980AA0
	private void .ctor() { }

	// RVA: 0x1980AB0 Offset: 0x1980BB1 VA: 0x1980AB0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1980AC0 Offset: 0x1980BC1 VA: 0x1980AC0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1980AD0 Offset: 0x1980BD1 VA: 0x1980AD0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1980B20 Offset: 0x1980C21 VA: 0x1980B20 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1980C80 Offset: 0x1980D81 VA: 0x1980C80
	private static void .cctor() { }
}

