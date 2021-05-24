[DebuggerTypeProxyAttribute] // RVA: 0xBE9B0 Offset: 0xBEAB1 VA: 0xBE9B0
public class MethodCallExpression : Expression, IArgumentProvider // TypeDefIndex: 2296
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF570 Offset: 0xBF671 VA: 0xBF570
	private readonly MethodInfo <Method>k__BackingField; // 0x10

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public MethodInfo Method { get; }
	public Expression Object { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC1560 Offset: 0xC1661 VA: 0xC1560
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x1922120 Offset: 0x1922221 VA: 0x1922120
	internal void .ctor(MethodInfo method) { }

	// RVA: 0x19221B0 Offset: 0x19222B1 VA: 0x19221B0 Slot: 12
	internal virtual Expression GetInstance() { }

	// RVA: 0x19221C0 Offset: 0x19222C1 VA: 0x19221C0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x19221D0 Offset: 0x19222D1 VA: 0x19221D0 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0B20 Offset: 0xC0C21 VA: 0xC0B20
	// RVA: 0x1922200 Offset: 0x1922301 VA: 0x1922200
	public MethodInfo get_Method() { }

	// RVA: 0x1922210 Offset: 0x1922311 VA: 0x1922210
	public Expression get_Object() { }

	// RVA: 0x1922220 Offset: 0x1922321 VA: 0x1922220 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC0B30 Offset: 0xC0C31 VA: 0xC0B30
	// RVA: 0x1922250 Offset: 0x1922351 VA: 0x1922250 Slot: 13
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC0B40 Offset: 0xC0C41 VA: 0xC0B40
	// RVA: 0x19222A0 Offset: 0x19223A1 VA: 0x19222A0 Slot: 14
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x19222F0 Offset: 0x19223F1 VA: 0x19222F0 Slot: 15
	public virtual int get_ArgumentCount() { }
}

