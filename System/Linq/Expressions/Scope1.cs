internal sealed class Scope1 : ScopeExpression // TypeDefIndex: 2246
{
	// Fields
	private object _body; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1B534E0 Offset: 0x1B535E1 VA: 0x1B534E0
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, Expression body) { }

	// RVA: 0x1B53530 Offset: 0x1B53631 VA: 0x1B53530
	private void .ctor(IReadOnlyList<ParameterExpression> variables, object body) { }

	// RVA: 0x1B535C0 Offset: 0x1B536C1 VA: 0x1B535C0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1B53650 Offset: 0x1B53751 VA: 0x1B53650 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1B53660 Offset: 0x1B53761 VA: 0x1B53660 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1B53670 Offset: 0x1B53771 VA: 0x1B53670 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

