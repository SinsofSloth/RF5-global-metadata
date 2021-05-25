[DebuggerTypeProxyAttribute] // RVA: 0xBE630 Offset: 0xBE731 VA: 0xBE630
public sealed class IndexExpression : Expression, IArgumentProvider // TypeDefIndex: 2271
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF410 Offset: 0xBF511 VA: 0xBF410
	private readonly Expression <Object>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF420 Offset: 0xBF521 VA: 0xBF420
	private readonly PropertyInfo <Indexer>k__BackingField; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public Expression Object { get; }
	public PropertyInfo Indexer { get; }
	public int ArgumentCount { get; }

	// Methods

	// RVA: 0x19721C0 Offset: 0x19722C1 VA: 0x19721C0
	internal void .ctor(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) { }

	// RVA: 0x1972290 Offset: 0x1972391 VA: 0x1972290 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x19722A0 Offset: 0x19723A1 VA: 0x19722A0 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0960 Offset: 0xC0A61 VA: 0xC0960
	// RVA: 0x1972320 Offset: 0x1972421 VA: 0x1972320
	public Expression get_Object() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0970 Offset: 0xC0A71 VA: 0xC0970
	// RVA: 0x1972330 Offset: 0x1972431 VA: 0x1972330
	public PropertyInfo get_Indexer() { }

	// RVA: 0x1970BD0 Offset: 0x1970CD1 VA: 0x1970BD0 Slot: 10
	public Expression GetArgument(int index) { }

	// RVA: 0x1970B20 Offset: 0x1970C21 VA: 0x1970B20 Slot: 11
	public int get_ArgumentCount() { }

	// RVA: 0x1972340 Offset: 0x1972441 VA: 0x1972340 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1971980 Offset: 0x1971A81 VA: 0x1971980
	internal Expression Rewrite(Expression instance, Expression[] arguments) { }
}

