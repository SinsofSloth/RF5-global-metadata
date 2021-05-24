[DebuggerTypeProxyAttribute] // RVA: 0xBEA20 Offset: 0xBEB21 VA: 0xBEA20
public class NewArrayExpression : Expression // TypeDefIndex: 2310
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF580 Offset: 0xBF681 VA: 0xBF580
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF590 Offset: 0xBF691 VA: 0xBF590
	private readonly ReadOnlyCollection<Expression> <Expressions>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public ReadOnlyCollection<Expression> Expressions { get; }

	// Methods

	// RVA: 0x1923B50 Offset: 0x1923C51 VA: 0x1923B50
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x1923C00 Offset: 0x1923D01 VA: 0x1923C00
	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0B50 Offset: 0xC0C51 VA: 0xC0B50
	// RVA: 0x1923D90 Offset: 0x1923E91 VA: 0x1923D90 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0B60 Offset: 0xC0C61 VA: 0xC0B60
	// RVA: 0x1923DA0 Offset: 0x1923EA1 VA: 0x1923DA0
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x1923DB0 Offset: 0x1923EB1 VA: 0x1923DB0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1923DE0 Offset: 0x1923EE1 VA: 0x1923DE0
	public NewArrayExpression Update(IEnumerable<Expression> expressions) { }
}

