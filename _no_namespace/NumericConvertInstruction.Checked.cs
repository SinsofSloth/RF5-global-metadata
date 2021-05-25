internal sealed class NumericConvertInstruction.Checked : NumericConvertInstruction // TypeDefIndex: 2646
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1918E70 Offset: 0x1918F71 VA: 0x1918E70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1918EC0 Offset: 0x1918FC1 VA: 0x1918EC0
	public void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1918F10 Offset: 0x1919011 VA: 0x1918F10 Slot: 10
	protected override object Convert(object obj) { }

	// RVA: 0x1919210 Offset: 0x1919311 VA: 0x1919210
	private object ConvertInt32(int obj) { }

	// RVA: 0x1919400 Offset: 0x1919501 VA: 0x1919400
	private object ConvertInt64(long obj) { }

	// RVA: 0x19195E0 Offset: 0x19196E1 VA: 0x19195E0
	private object ConvertUInt64(ulong obj) { }

	// RVA: 0x19197C0 Offset: 0x19198C1 VA: 0x19197C0
	private object ConvertDouble(double obj) { }
}

