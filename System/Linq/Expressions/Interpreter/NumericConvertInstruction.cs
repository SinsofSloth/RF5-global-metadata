internal abstract class NumericConvertInstruction : Instruction // TypeDefIndex: 2644
{
	// Fields
	internal readonly TypeCode _from; // 0x10
	internal readonly TypeCode _to; // 0x14
	private readonly bool _isLiftedToNull; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1918A60 Offset: 0x1918B61 VA: 0x1918A60
	protected void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1918AB0 Offset: 0x1918BB1 VA: 0x1918AB0 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract object Convert(object obj) { }

	// RVA: 0x1918B90 Offset: 0x1918C91 VA: 0x1918B90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1918BE0 Offset: 0x1918CE1 VA: 0x1918BE0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1918BF0 Offset: 0x1918CF1 VA: 0x1918BF0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1918C00 Offset: 0x1918D01 VA: 0x1918C00 Slot: 3
	public override string ToString() { }
}

