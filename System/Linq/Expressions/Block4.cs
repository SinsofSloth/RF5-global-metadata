internal sealed class Block4 : BlockExpression // TypeDefIndex: 2242
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x16ABBD0 Offset: 0x16ABCD1 VA: 0x16ABBD0
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x16ABCA0 Offset: 0x16ABDA1 VA: 0x16ABCA0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x16ABD80 Offset: 0x16ABE81 VA: 0x16ABD80 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x16ABD90 Offset: 0x16ABE91 VA: 0x16ABD90 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x16ABDA0 Offset: 0x16ABEA1 VA: 0x16ABDA0 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

