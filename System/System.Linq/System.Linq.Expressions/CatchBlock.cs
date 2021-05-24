[DebuggerTypeProxyAttribute] // RVA: 0xBE380 Offset: 0xBE481 VA: 0xBE380
public sealed class CatchBlock // TypeDefIndex: 2251
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF300 Offset: 0xBF401 VA: 0xBF300
	private readonly ParameterExpression <Variable>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF310 Offset: 0xBF411 VA: 0xBF310
	private readonly Type <Test>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF320 Offset: 0xBF421 VA: 0xBF320
	private readonly Expression <Body>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF330 Offset: 0xBF431 VA: 0xBF330
	private readonly Expression <Filter>k__BackingField; // 0x28

	// Properties
	public ParameterExpression Variable { get; }
	public Type Test { get; }
	public Expression Body { get; }
	public Expression Filter { get; }

	// Methods

	// RVA: 0x16AD2F0 Offset: 0x16AD3F1 VA: 0x16AD2F0
	internal void .ctor(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0840 Offset: 0xC0941 VA: 0xC0840
	// RVA: 0x16AD370 Offset: 0x16AD471 VA: 0x16AD370
	public ParameterExpression get_Variable() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0850 Offset: 0xC0951 VA: 0xC0850
	// RVA: 0x16AD380 Offset: 0x16AD481 VA: 0x16AD380
	public Type get_Test() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0860 Offset: 0xC0961 VA: 0xC0860
	// RVA: 0x16AD390 Offset: 0x16AD491 VA: 0x16AD390
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0870 Offset: 0xC0971 VA: 0xC0870
	// RVA: 0x16AD3A0 Offset: 0x16AD4A1 VA: 0x16AD3A0
	public Expression get_Filter() { }

	// RVA: 0x16AD3B0 Offset: 0x16AD4B1 VA: 0x16AD3B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16AD3C0 Offset: 0x16AD4C1 VA: 0x16AD3C0
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }
}

