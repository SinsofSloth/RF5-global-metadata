internal class TinyJsonReader : IDisposable // TypeDefIndex: 5128
{
	// Fields
	private readonly TextReader reader; // 0x10
	private readonly bool disposeInnerReader; // 0x18
	private StringBuilder reusableBuilder; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x139890 Offset: 0x139991 VA: 0x139890
	private TinyJsonToken <TokenType>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1398A0 Offset: 0x1399A1 VA: 0x1398A0
	private ValueType <ValueType>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x1398B0 Offset: 0x1399B1 VA: 0x1398B0
	private double <DoubleValue>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x1398C0 Offset: 0x1399C1 VA: 0x1398C0
	private long <LongValue>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x1398D0 Offset: 0x1399D1 VA: 0x1398D0
	private ulong <ULongValue>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x1398E0 Offset: 0x1399E1 VA: 0x1398E0
	private Decimal <DecimalValue>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x1398F0 Offset: 0x1399F1 VA: 0x1398F0
	private string <StringValue>k__BackingField; // 0x58

	// Properties
	public TinyJsonToken TokenType { get; set; }
	public ValueType ValueType { get; set; }
	public double DoubleValue { get; set; }
	public long LongValue { get; set; }
	public ulong ULongValue { get; set; }
	public Decimal DecimalValue { get; set; }
	public string StringValue { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x139EF0 Offset: 0x139FF1 VA: 0x139EF0
	// RVA: 0x14FB920 Offset: 0x14FBA21 VA: 0x14FB920
	public TinyJsonToken get_TokenType() { }

	[CompilerGeneratedAttribute] // RVA: 0x139F00 Offset: 0x13A001 VA: 0x139F00
	// RVA: 0x14FB930 Offset: 0x14FBA31 VA: 0x14FB930
	private void set_TokenType(TinyJsonToken value) { }

	[CompilerGeneratedAttribute] // RVA: 0x139F10 Offset: 0x13A011 VA: 0x139F10
	// RVA: 0x14FB940 Offset: 0x14FBA41 VA: 0x14FB940
	public ValueType get_ValueType() { }

	[CompilerGeneratedAttribute] // RVA: 0x139F20 Offset: 0x13A021 VA: 0x139F20
	// RVA: 0x14FB950 Offset: 0x14FBA51 VA: 0x14FB950
	private void set_ValueType(ValueType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x139F30 Offset: 0x13A031 VA: 0x139F30
	// RVA: 0x14FB960 Offset: 0x14FBA61 VA: 0x14FB960
	public double get_DoubleValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x139F40 Offset: 0x13A041 VA: 0x139F40
	// RVA: 0x14FB970 Offset: 0x14FBA71 VA: 0x14FB970
	private void set_DoubleValue(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x139F50 Offset: 0x13A051 VA: 0x139F50
	// RVA: 0x14FB980 Offset: 0x14FBA81 VA: 0x14FB980
	public long get_LongValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x139F60 Offset: 0x13A061 VA: 0x139F60
	// RVA: 0x14FB990 Offset: 0x14FBA91 VA: 0x14FB990
	private void set_LongValue(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x139F70 Offset: 0x13A071 VA: 0x139F70
	// RVA: 0x14FB9A0 Offset: 0x14FBAA1 VA: 0x14FB9A0
	public ulong get_ULongValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x139F80 Offset: 0x13A081 VA: 0x139F80
	// RVA: 0x14FB9B0 Offset: 0x14FBAB1 VA: 0x14FB9B0
	private void set_ULongValue(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x139F90 Offset: 0x13A091 VA: 0x139F90
	// RVA: 0x14FB9C0 Offset: 0x14FBAC1 VA: 0x14FB9C0
	public Decimal get_DecimalValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x139FA0 Offset: 0x13A0A1 VA: 0x139FA0
	// RVA: 0x14FB9D0 Offset: 0x14FBAD1 VA: 0x14FB9D0
	private void set_DecimalValue(Decimal value) { }

	[CompilerGeneratedAttribute] // RVA: 0x139FB0 Offset: 0x13A0B1 VA: 0x139FB0
	// RVA: 0x14FB9E0 Offset: 0x14FBAE1 VA: 0x14FB9E0
	public string get_StringValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x139FC0 Offset: 0x13A0C1 VA: 0x139FC0
	// RVA: 0x14FB9F0 Offset: 0x14FBAF1 VA: 0x14FB9F0
	private void set_StringValue(string value) { }

	// RVA: 0x14FBA00 Offset: 0x14FBB01 VA: 0x14FBA00
	public void .ctor(TextReader reader, bool disposeInnerReader = True) { }

	// RVA: 0x14FBA50 Offset: 0x14FBB51 VA: 0x14FBA50
	public bool Read() { }

	// RVA: 0x14FBFB0 Offset: 0x14FC0B1 VA: 0x14FBFB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14FBFF0 Offset: 0x14FC0F1 VA: 0x14FBFF0
	private void SkipWhiteSpace() { }

	// RVA: 0x14FC0C0 Offset: 0x14FC1C1 VA: 0x14FC0C0
	private char ReadChar() { }

	// RVA: 0x14FC0F0 Offset: 0x14FC1F1 VA: 0x14FC0F0
	private static bool IsWordBreak(char c) { }

	// RVA: 0x14FBA90 Offset: 0x14FBB91 VA: 0x14FBA90
	private void ReadNextToken() { }

	// RVA: 0x14FBC80 Offset: 0x14FBD81 VA: 0x14FBC80
	private void ReadValue() { }

	// RVA: 0x14FC180 Offset: 0x14FC281 VA: 0x14FC180
	private void ReadNumber() { }

	// RVA: 0x14FC580 Offset: 0x14FC681 VA: 0x14FC580
	private void ReadString() { }
}

