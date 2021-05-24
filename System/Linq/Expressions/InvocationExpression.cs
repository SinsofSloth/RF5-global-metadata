[DebuggerTypeProxyAttribute] // RVA: 0xBE6A0 Offset: 0xBE7A1 VA: 0xBE6A0
public class InvocationExpression : Expression, IArgumentProvider // TypeDefIndex: 2272
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF430 Offset: 0xBF531 VA: 0xBF430
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF440 Offset: 0xBF541 VA: 0xBF440
	private readonly Expression <Expression>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC1530 Offset: 0xC1631 VA: 0xC1530
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x19212F0 Offset: 0x19213F1 VA: 0x19212F0
	internal void .ctor(Expression expression, Type returnType) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0980 Offset: 0xC0A81 VA: 0xC0980
	// RVA: 0x1921390 Offset: 0x1921491 VA: 0x1921390 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x19213A0 Offset: 0x19214A1 VA: 0x19213A0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0990 Offset: 0xC0A91 VA: 0xC0990
	// RVA: 0x19213B0 Offset: 0x19214B1 VA: 0x19213B0
	public Expression get_Expression() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC09A0 Offset: 0xC0AA1 VA: 0xC09A0
	// RVA: 0x19213C0 Offset: 0x19214C1 VA: 0x19213C0 Slot: 12
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x1921410 Offset: 0x1921511 VA: 0x1921410 Slot: 13
	public virtual int get_ArgumentCount() { }

	// RVA: 0x1921460 Offset: 0x1921561 VA: 0x1921460 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC09B0 Offset: 0xC0AB1 VA: 0xC09B0
	// RVA: 0x1921490 Offset: 0x1921591 VA: 0x1921490 Slot: 14
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

