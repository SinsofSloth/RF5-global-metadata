internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2305
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30
	private readonly Expression _arg4; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x19232E0 Offset: 0x19233E1 VA: 0x19232E0
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x19233E0 Offset: 0x19234E1 VA: 0x19233E0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x19234F0 Offset: 0x19235F1 VA: 0x19234F0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1923500 Offset: 0x1923601 VA: 0x1923500 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

