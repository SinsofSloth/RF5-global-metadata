internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2302
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1922720 Offset: 0x1922821 VA: 0x1922720
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x19227E0 Offset: 0x19228E1 VA: 0x19227E0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x19228A0 Offset: 0x19229A1 VA: 0x19228A0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x19228B0 Offset: 0x19229B1 VA: 0x19228B0 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

