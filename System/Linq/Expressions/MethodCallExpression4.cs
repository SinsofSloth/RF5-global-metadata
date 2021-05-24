internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2304
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1922E40 Offset: 0x1922F41 VA: 0x1922E40
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1922F30 Offset: 0x1923031 VA: 0x1922F30 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x1923030 Offset: 0x1923131 VA: 0x1923030 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1923040 Offset: 0x1923141 VA: 0x1923040 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

