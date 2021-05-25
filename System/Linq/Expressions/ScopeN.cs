internal class ScopeN : ScopeExpression // TypeDefIndex: 2247
{
	// Fields
	private IReadOnlyList<Expression> _body; // 0x18

	// Properties
	protected IReadOnlyList<Expression> Body { get; }
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1B53910 Offset: 0x1B53A11 VA: 0x1B53910
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	// RVA: 0x1B53960 Offset: 0x1B53A61 VA: 0x1B53960
	protected IReadOnlyList<Expression> get_Body() { }

	// RVA: 0x1B53970 Offset: 0x1B53A71 VA: 0x1B53970 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1B53A30 Offset: 0x1B53B31 VA: 0x1B53A30 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1B53AE0 Offset: 0x1B53BE1 VA: 0x1B53AE0 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1B53B30 Offset: 0x1B53C31 VA: 0x1B53B30 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

