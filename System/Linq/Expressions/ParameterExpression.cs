[DebuggerTypeProxyAttribute] // RVA: 0xBEB00 Offset: 0xBEC01 VA: 0xBEB00
public class ParameterExpression : Expression // TypeDefIndex: 2314
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF5C0 Offset: 0xBF6C1 VA: 0xBF5C0
	private readonly string <Name>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	public bool IsByRef { get; }

	// Methods

	// RVA: 0x1924390 Offset: 0x1924491 VA: 0x1924390
	internal void .ctor(string name) { }

	// RVA: 0x1924420 Offset: 0x1924521 VA: 0x1924420
	internal static ParameterExpression Make(Type type, string name, bool isByRef) { }

	// RVA: 0x1924950 Offset: 0x1924A51 VA: 0x1924950 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x19249C0 Offset: 0x1924AC1 VA: 0x19249C0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0B90 Offset: 0xC0C91 VA: 0xC0B90
	// RVA: 0x19249D0 Offset: 0x1924AD1 VA: 0x19249D0
	public string get_Name() { }

	// RVA: 0x19249E0 Offset: 0x1924AE1 VA: 0x19249E0
	public bool get_IsByRef() { }

	// RVA: 0x19249F0 Offset: 0x1924AF1 VA: 0x19249F0 Slot: 10
	internal virtual bool GetIsByRef() { }

	// RVA: 0x1924A00 Offset: 0x1924B01 VA: 0x1924A00 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}

