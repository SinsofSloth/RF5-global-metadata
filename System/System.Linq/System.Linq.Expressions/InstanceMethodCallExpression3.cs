internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 2309
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1972A10 Offset: 0x1972B11 VA: 0x1972A10
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1972A90 Offset: 0x1972B91 VA: 0x1972A90 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x1972B70 Offset: 0x1972C71 VA: 0x1972B70 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1972B80 Offset: 0x1972C81 VA: 0x1972B80 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

