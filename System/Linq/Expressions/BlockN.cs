internal class BlockN : BlockExpression // TypeDefIndex: 2244
{
	// Fields
	private IReadOnlyList<Expression> _expressions; // 0x10

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x16ACC80 Offset: 0x16ACD81 VA: 0x16ACC80
	internal void .ctor(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x16ACD10 Offset: 0x16ACE11 VA: 0x16ACD10 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x16ACDD0 Offset: 0x16ACED1 VA: 0x16ACDD0 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x16ACE80 Offset: 0x16ACF81 VA: 0x16ACE80 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x16ACED0 Offset: 0x16ACFD1 VA: 0x16ACED0 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

