[DebuggerTypeProxyAttribute] // RVA: 0xBE710 Offset: 0xBE811 VA: 0xBE710
public sealed class LabelExpression : Expression // TypeDefIndex: 2274
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF450 Offset: 0xBF551 VA: 0xBF450
	private readonly LabelTarget <Target>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF460 Offset: 0xBF561 VA: 0xBF460
	private readonly Expression <DefaultValue>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public LabelTarget Target { get; }
	public Expression DefaultValue { get; }

	// Methods

	// RVA: 0x1921720 Offset: 0x1921821 VA: 0x1921720
	internal void .ctor(LabelTarget label, Expression defaultValue) { }

	// RVA: 0x19217C0 Offset: 0x19218C1 VA: 0x19217C0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x19217E0 Offset: 0x19218E1 VA: 0x19217E0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC09C0 Offset: 0xC0AC1 VA: 0xC09C0
	// RVA: 0x19217F0 Offset: 0x19218F1 VA: 0x19217F0
	public LabelTarget get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0xC09D0 Offset: 0xC0AD1 VA: 0xC09D0
	// RVA: 0x1921800 Offset: 0x1921901 VA: 0x1921800
	public Expression get_DefaultValue() { }

	// RVA: 0x1921810 Offset: 0x1921911 VA: 0x1921810 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1921840 Offset: 0x1921941 VA: 0x1921840
	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }
}

