[DebuggerTypeProxyAttribute] // RVA: 0xBE2C0 Offset: 0xBE3C1 VA: 0xBE2C0
public class BlockExpression : Expression // TypeDefIndex: 2239
{
	// Properties
	public ReadOnlyCollection<Expression> Expressions { get; }
	public ReadOnlyCollection<ParameterExpression> Variables { get; }
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC14E0 Offset: 0xC15E1 VA: 0xC14E0
	internal virtual int ExpressionCount { get; }

	// Methods

	// RVA: 0x16AC140 Offset: 0x16AC241 VA: 0x16AC140
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x16AC150 Offset: 0x16AC251 VA: 0x16AC150
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	// RVA: 0x16AB590 Offset: 0x16AB691 VA: 0x16AB590
	internal void .ctor() { }

	// RVA: 0x16AC160 Offset: 0x16AC261 VA: 0x16AC160 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x16AC190 Offset: 0x16AC291 VA: 0x16AC190 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x16AC1A0 Offset: 0x16AC2A1 VA: 0x16AC1A0 Slot: 5
	public override Type get_Type() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC06E0 Offset: 0xC07E1 VA: 0xC06E0
	// RVA: 0x16AC1F0 Offset: 0x16AC2F1 VA: 0x16AC1F0 Slot: 10
	internal virtual Expression GetExpression(int index) { }

	// RVA: 0x16AC240 Offset: 0x16AC341 VA: 0x16AC240 Slot: 11
	internal virtual int get_ExpressionCount() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC06F0 Offset: 0xC07F1 VA: 0xC06F0
	// RVA: 0x16AC290 Offset: 0x16AC391 VA: 0x16AC290 Slot: 12
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x16AC2E0 Offset: 0x16AC3E1 VA: 0x16AC2E0 Slot: 13
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC0700 Offset: 0xC0801 VA: 0xC0700
	// RVA: 0x16AC350 Offset: 0x16AC451 VA: 0x16AC350 Slot: 14
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

	// RVA: 0x16AB730 Offset: 0x16AB831 VA: 0x16AB730
	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }
}

