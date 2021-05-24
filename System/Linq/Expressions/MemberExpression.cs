[DebuggerTypeProxyAttribute] // RVA: 0xBE8D0 Offset: 0xBE9D1 VA: 0xBE8D0
public class MemberExpression : Expression // TypeDefIndex: 2290
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF520 Offset: 0xBF621 VA: 0xBF520
	private readonly Expression <Expression>k__BackingField; // 0x10

	// Properties
	public MemberInfo Member { get; }
	public Expression Expression { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1921DA0 Offset: 0x1921EA1 VA: 0x1921DA0
	public MemberInfo get_Member() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0AC0 Offset: 0xC0BC1 VA: 0xC0AC0
	// RVA: 0x1921DB0 Offset: 0x1921EB1 VA: 0x1921DB0
	public Expression get_Expression() { }

	// RVA: 0x1921DC0 Offset: 0x1921EC1 VA: 0x1921DC0
	internal void .ctor(Expression expression) { }

	// RVA: 0x1921E50 Offset: 0x1921F51 VA: 0x1921E50
	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	// RVA: 0x1921ED0 Offset: 0x1921FD1 VA: 0x1921ED0
	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	// RVA: 0x1921F50 Offset: 0x1922051 VA: 0x1921F50 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC0AD0 Offset: 0xC0BD1 VA: 0xC0AD0
	// RVA: 0x1921F60 Offset: 0x1922061 VA: 0x1921F60 Slot: 10
	internal virtual MemberInfo GetMember() { }

	// RVA: 0x1921FB0 Offset: 0x19220B1 VA: 0x1921FB0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1921FE0 Offset: 0x19220E1 VA: 0x1921FE0
	public MemberExpression Update(Expression expression) { }
}

