internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 2308
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1972710 Offset: 0x1972811 VA: 0x1972710
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1) { }

	// RVA: 0x1972780 Offset: 0x1972881 VA: 0x1972780 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x1972840 Offset: 0x1972941 VA: 0x1972840 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1972850 Offset: 0x1972951 VA: 0x1972850 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

