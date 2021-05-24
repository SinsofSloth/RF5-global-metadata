[DebuggerTypeProxyAttribute] // RVA: 0xBE400 Offset: 0xBE501 VA: 0xBE400
public class ConditionalExpression : Expression // TypeDefIndex: 2255
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF340 Offset: 0xBF441 VA: 0xBF340
	private readonly Expression <Test>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF350 Offset: 0xBF451 VA: 0xBF350
	private readonly Expression <IfTrue>k__BackingField; // 0x18

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	public Expression Test { get; }
	public Expression IfTrue { get; }
	public Expression IfFalse { get; }

	// Methods

	// RVA: 0x16AD8E0 Offset: 0x16AD9E1 VA: 0x16AD8E0
	internal void .ctor(Expression test, Expression ifTrue) { }

	// RVA: 0x16AD980 Offset: 0x16ADA81 VA: 0x16AD980
	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x16ADBC0 Offset: 0x16ADCC1 VA: 0x16ADBC0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x16ADBD0 Offset: 0x16ADCD1 VA: 0x16ADBD0 Slot: 5
	public override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0890 Offset: 0xC0991 VA: 0xC0890
	// RVA: 0x16ADBF0 Offset: 0x16ADCF1 VA: 0x16ADBF0
	public Expression get_Test() { }

	[CompilerGeneratedAttribute] // RVA: 0xC08A0 Offset: 0xC09A1 VA: 0xC08A0
	// RVA: 0x16ADC00 Offset: 0x16ADD01 VA: 0x16ADC00
	public Expression get_IfTrue() { }

	// RVA: 0x16ADC10 Offset: 0x16ADD11 VA: 0x16ADC10
	public Expression get_IfFalse() { }

	// RVA: 0x16ADC20 Offset: 0x16ADD21 VA: 0x16ADC20 Slot: 10
	internal virtual Expression GetFalse() { }

	// RVA: 0x16ADC90 Offset: 0x16ADD91 VA: 0x16ADC90 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x16ADCC0 Offset: 0x16ADDC1 VA: 0x16ADCC0
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }
}

