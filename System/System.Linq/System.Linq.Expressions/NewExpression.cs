[DebuggerTypeProxyAttribute] // RVA: 0xBEA90 Offset: 0xBEB91 VA: 0xBEA90
public class NewExpression : Expression, IArgumentProvider // TypeDefIndex: 2313
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF5A0 Offset: 0xBF6A1 VA: 0xBF5A0
	private readonly ConstructorInfo <Constructor>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF5B0 Offset: 0xBF6B1 VA: 0xBF5B0
	private readonly ReadOnlyCollection<MemberInfo> <Members>k__BackingField; // 0x20

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public ConstructorInfo Constructor { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	public int ArgumentCount { get; }
	public ReadOnlyCollection<MemberInfo> Members { get; }

	// Methods

	// RVA: 0x1923F20 Offset: 0x1924021 VA: 0x1923F20
	internal void .ctor(ConstructorInfo constructor, IReadOnlyList<Expression> arguments, ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x1923FE0 Offset: 0x19240E1 VA: 0x1923FE0 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x1924000 Offset: 0x1924101 VA: 0x1924000 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0B70 Offset: 0xC0C71 VA: 0xC0B70
	// RVA: 0x1924010 Offset: 0x1924111 VA: 0x1924010
	public ConstructorInfo get_Constructor() { }

	// RVA: 0x1924020 Offset: 0x1924121 VA: 0x1924020
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1924070 Offset: 0x1924171 VA: 0x1924070 Slot: 10
	public Expression GetArgument(int index) { }

	// RVA: 0x1924130 Offset: 0x1924231 VA: 0x1924130 Slot: 11
	public int get_ArgumentCount() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0B80 Offset: 0xC0C81 VA: 0xC0B80
	// RVA: 0x19241E0 Offset: 0x19242E1 VA: 0x19241E0
	public ReadOnlyCollection<MemberInfo> get_Members() { }

	// RVA: 0x19241F0 Offset: 0x19242F1 VA: 0x19241F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1924220 Offset: 0x1924321 VA: 0x1924220
	public NewExpression Update(IEnumerable<Expression> arguments) { }
}

