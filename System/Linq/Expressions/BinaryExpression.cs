[DebuggerTypeProxyAttribute] // RVA: 0xBE250 Offset: 0xBE351 VA: 0xBE250
public class BinaryExpression : Expression // TypeDefIndex: 2204
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF2A0 Offset: 0xBF3A1 VA: 0xBF2A0
	private readonly Expression <Right>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF2B0 Offset: 0xBF3B1 VA: 0xBF2B0
	private readonly Expression <Left>k__BackingField; // 0x18

	// Properties
	public override bool CanReduce { get; }
	public Expression Right { get; }
	public Expression Left { get; }
	public MethodInfo Method { get; }
	public LambdaExpression Conversion { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	internal bool IsLiftedLogical { get; }
	internal bool IsReferenceComparison { get; }

	// Methods

	// RVA: 0x16A71A0 Offset: 0x16A72A1 VA: 0x16A71A0
	internal void .ctor(Expression left, Expression right) { }

	// RVA: 0x16A7280 Offset: 0x16A7381 VA: 0x16A7280 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x16A72B0 Offset: 0x16A73B1 VA: 0x16A72B0
	private static bool IsOpAssignment(ExpressionType op) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0690 Offset: 0xC0791 VA: 0xC0690
	// RVA: 0x16A72C0 Offset: 0x16A73C1 VA: 0x16A72C0
	public Expression get_Right() { }

	[CompilerGeneratedAttribute] // RVA: 0xC06A0 Offset: 0xC07A1 VA: 0xC06A0
	// RVA: 0x16A72D0 Offset: 0x16A73D1 VA: 0x16A72D0
	public Expression get_Left() { }

	// RVA: 0x16A72E0 Offset: 0x16A73E1 VA: 0x16A72E0
	public MethodInfo get_Method() { }

	// RVA: 0x16A72F0 Offset: 0x16A73F1 VA: 0x16A72F0 Slot: 10
	internal virtual MethodInfo GetMethod() { }

	// RVA: 0x16A7300 Offset: 0x16A7401 VA: 0x16A7300
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

	// RVA: 0x16A83D0 Offset: 0x16A84D1 VA: 0x16A83D0 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x16A9170 Offset: 0x16A9271 VA: 0x16A9170
	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	// RVA: 0x16A8FA0 Offset: 0x16A90A1 VA: 0x16A8FA0
	private Expression ReduceVariable() { }

	// RVA: 0x16A8460 Offset: 0x16A8561 VA: 0x16A8460
	private Expression ReduceMember() { }

	// RVA: 0x16A89C0 Offset: 0x16A8AC1 VA: 0x16A89C0
	private Expression ReduceIndex() { }

	// RVA: 0x16A74B0 Offset: 0x16A75B1 VA: 0x16A74B0
	public LambdaExpression get_Conversion() { }

	// RVA: 0x16A9B70 Offset: 0x16A9C71 VA: 0x16A9B70 Slot: 11
	internal virtual LambdaExpression GetConversion() { }

	// RVA: 0x16A9B80 Offset: 0x16A9C81 VA: 0x16A9B80
	public bool get_IsLifted() { }

	// RVA: 0x16A7820 Offset: 0x16A7921 VA: 0x16A7820
	public bool get_IsLiftedToNull() { }

	// RVA: 0x16A9D60 Offset: 0x16A9E61 VA: 0x16A9D60 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x16A9D90 Offset: 0x16A9E91 VA: 0x16A9D90
	internal bool get_IsLiftedLogical() { }

	// RVA: 0x16A74C0 Offset: 0x16A75C1 VA: 0x16A74C0
	internal bool get_IsReferenceComparison() { }

	// RVA: 0x16A9FA0 Offset: 0x16AA0A1 VA: 0x16A9FA0
	internal Expression ReduceUserdefinedLifted() { }
}

