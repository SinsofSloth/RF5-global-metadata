internal sealed class Block5 : BlockExpression // TypeDefIndex: 2243
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28
	private readonly Expression _arg4; // 0x30

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x16ABE60 Offset: 0x16ABF61 VA: 0x16ABE60
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x16ABF50 Offset: 0x16AC051 VA: 0x16ABF50 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x16AC050 Offset: 0x16AC151 VA: 0x16AC050 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x16AC060 Offset: 0x16AC161 VA: 0x16AC060 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x16AC070 Offset: 0x16AC171 VA: 0x16AC070 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

