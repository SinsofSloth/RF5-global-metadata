internal sealed class CoalesceConversionBinaryExpression : BinaryExpression // TypeDefIndex: 2207
{
	// Fields
	private readonly LambdaExpression _conversion; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x16AD7E0 Offset: 0x16AD8E1 VA: 0x16AD7E0
	internal void .ctor(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x16AD8A0 Offset: 0x16AD9A1 VA: 0x16AD8A0 Slot: 11
	internal override LambdaExpression GetConversion() { }

	// RVA: 0x16AD8B0 Offset: 0x16AD9B1 VA: 0x16AD8B0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x16AD8C0 Offset: 0x16AD9C1 VA: 0x16AD8C0 Slot: 5
	public sealed override Type get_Type() { }
}

