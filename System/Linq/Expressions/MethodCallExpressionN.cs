internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2298
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1923810 Offset: 0x1923911 VA: 0x1923810
	public void .ctor(MethodInfo method, IReadOnlyList<Expression> args) { }

	// RVA: 0x19238B0 Offset: 0x19239B1 VA: 0x19238B0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x1923970 Offset: 0x1923A71 VA: 0x1923970 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1923A20 Offset: 0x1923B21 VA: 0x1923A20 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

