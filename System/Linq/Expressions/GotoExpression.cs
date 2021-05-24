[DebuggerTypeProxyAttribute] // RVA: 0xBE5C0 Offset: 0xBE6C1 VA: 0xBE5C0
public sealed class GotoExpression : Expression // TypeDefIndex: 2268
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF3D0 Offset: 0xBF4D1 VA: 0xBF3D0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF3E0 Offset: 0xBF4E1 VA: 0xBF3E0
	private readonly Expression <Value>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF3F0 Offset: 0xBF4F1 VA: 0xBF3F0
	private readonly LabelTarget <Target>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF400 Offset: 0xBF501 VA: 0xBF400
	private readonly GotoExpressionKind <Kind>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Value { get; }
	public LabelTarget Target { get; }
	public GotoExpressionKind Kind { get; }

	// Methods

	// RVA: 0x1972080 Offset: 0x1972181 VA: 0x1972080
	internal void .ctor(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0920 Offset: 0xC0A21 VA: 0xC0920
	// RVA: 0x1972140 Offset: 0x1972241 VA: 0x1972140 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1972150 Offset: 0x1972251 VA: 0x1972150 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0930 Offset: 0xC0A31 VA: 0xC0930
	// RVA: 0x1972160 Offset: 0x1972261 VA: 0x1972160
	public Expression get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0940 Offset: 0xC0A41 VA: 0xC0940
	// RVA: 0x1972170 Offset: 0x1972271 VA: 0x1972170
	public LabelTarget get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0950 Offset: 0xC0A51 VA: 0xC0950
	// RVA: 0x1972180 Offset: 0x1972281 VA: 0x1972180
	public GotoExpressionKind get_Kind() { }

	// RVA: 0x1972190 Offset: 0x1972291 VA: 0x1972190 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1971680 Offset: 0x1971781 VA: 0x1971680
	public GotoExpression Update(LabelTarget target, Expression value) { }
}

