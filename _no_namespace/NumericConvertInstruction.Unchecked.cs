internal sealed class NumericConvertInstruction.Unchecked : NumericConvertInstruction // TypeDefIndex: 2645
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1919C80 Offset: 0x1919D81 VA: 0x1919C80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1919CD0 Offset: 0x1919DD1 VA: 0x1919CD0
	public void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1919D20 Offset: 0x1919E21 VA: 0x1919D20 Slot: 10
	protected override object Convert(object obj) { }

	// RVA: 0x191A020 Offset: 0x191A121 VA: 0x191A020
	private object ConvertInt32(int obj) { }

	// RVA: 0x191A1D0 Offset: 0x191A2D1 VA: 0x191A1D0
	private object ConvertInt64(long obj) { }

	// RVA: 0x191A360 Offset: 0x191A461 VA: 0x191A360
	private object ConvertUInt64(ulong obj) { }

	// RVA: 0x191A4F0 Offset: 0x191A5F1 VA: 0x191A4F0
	private object ConvertDouble(double obj) { }
}

