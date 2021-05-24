[DebuggerTypeProxyAttribute] // RVA: 0xBEDB0 Offset: 0xBEEB1 VA: 0xBEDB0
public sealed class UnaryExpression : Expression // TypeDefIndex: 2327
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF6D0 Offset: 0xBF7D1 VA: 0xBF6D0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF6E0 Offset: 0xBF7E1 VA: 0xBF6E0
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF6F0 Offset: 0xBF7F1 VA: 0xBF6F0
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF700 Offset: 0xBF801 VA: 0xBF700
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x1B56EC0 Offset: 0x1B56FC1 VA: 0x1B56EC0
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CA0 Offset: 0xC0DA1 VA: 0xC0CA0
	// RVA: 0x1B56F80 Offset: 0x1B57081 VA: 0x1B56F80 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CB0 Offset: 0xC0DB1 VA: 0xC0CB0
	// RVA: 0x1B56F90 Offset: 0x1B57091 VA: 0x1B56F90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CC0 Offset: 0xC0DC1 VA: 0xC0CC0
	// RVA: 0x1B56FA0 Offset: 0x1B570A1 VA: 0x1B56FA0
	public Expression get_Operand() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CD0 Offset: 0xC0DD1 VA: 0xC0CD0
	// RVA: 0x1B56FB0 Offset: 0x1B570B1 VA: 0x1B56FB0
	public MethodInfo get_Method() { }

	// RVA: 0x1B56FC0 Offset: 0x1B570C1 VA: 0x1B56FC0
	public bool get_IsLifted() { }

	// RVA: 0x1B571A0 Offset: 0x1B572A1 VA: 0x1B571A0
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1B571F0 Offset: 0x1B572F1 VA: 0x1B571F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B57220 Offset: 0x1B57321 VA: 0x1B57220 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1B57250 Offset: 0x1B57351 VA: 0x1B57250 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1B581D0 Offset: 0x1B582D1 VA: 0x1B581D0
	private bool get_IsPrefix() { }

	// RVA: 0x1B58230 Offset: 0x1B58331 VA: 0x1B58230
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x1B57F00 Offset: 0x1B58001 VA: 0x1B57F00
	private Expression ReduceVariable() { }

	// RVA: 0x1B579E0 Offset: 0x1B57AE1 VA: 0x1B579E0
	private Expression ReduceMember() { }

	// RVA: 0x1B572E0 Offset: 0x1B573E1 VA: 0x1B572E0
	private Expression ReduceIndex() { }

	// RVA: 0x1B58310 Offset: 0x1B58411 VA: 0x1B58310
	public UnaryExpression Update(Expression operand) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBEDB0 Offset: 0xBEEB1 VA: 0xBEDB0
public sealed class UnaryExpression : Expression // TypeDefIndex: 2327
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF6D0 Offset: 0xBF7D1 VA: 0xBF6D0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF6E0 Offset: 0xBF7E1 VA: 0xBF6E0
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF6F0 Offset: 0xBF7F1 VA: 0xBF6F0
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF700 Offset: 0xBF801 VA: 0xBF700
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x1B56EC0 Offset: 0x1B56FC1 VA: 0x1B56EC0
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CA0 Offset: 0xC0DA1 VA: 0xC0CA0
	// RVA: 0x1B56F80 Offset: 0x1B57081 VA: 0x1B56F80 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CB0 Offset: 0xC0DB1 VA: 0xC0CB0
	// RVA: 0x1B56F90 Offset: 0x1B57091 VA: 0x1B56F90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CC0 Offset: 0xC0DC1 VA: 0xC0CC0
	// RVA: 0x1B56FA0 Offset: 0x1B570A1 VA: 0x1B56FA0
	public Expression get_Operand() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CD0 Offset: 0xC0DD1 VA: 0xC0CD0
	// RVA: 0x1B56FB0 Offset: 0x1B570B1 VA: 0x1B56FB0
	public MethodInfo get_Method() { }

	// RVA: 0x1B56FC0 Offset: 0x1B570C1 VA: 0x1B56FC0
	public bool get_IsLifted() { }

	// RVA: 0x1B571A0 Offset: 0x1B572A1 VA: 0x1B571A0
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1B571F0 Offset: 0x1B572F1 VA: 0x1B571F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B57220 Offset: 0x1B57321 VA: 0x1B57220 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1B57250 Offset: 0x1B57351 VA: 0x1B57250 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1B581D0 Offset: 0x1B582D1 VA: 0x1B581D0
	private bool get_IsPrefix() { }

	// RVA: 0x1B58230 Offset: 0x1B58331 VA: 0x1B58230
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x1B57F00 Offset: 0x1B58001 VA: 0x1B57F00
	private Expression ReduceVariable() { }

	// RVA: 0x1B579E0 Offset: 0x1B57AE1 VA: 0x1B579E0
	private Expression ReduceMember() { }

	// RVA: 0x1B572E0 Offset: 0x1B573E1 VA: 0x1B572E0
	private Expression ReduceIndex() { }

	// RVA: 0x1B58310 Offset: 0x1B58411 VA: 0x1B58310
	public UnaryExpression Update(Expression operand) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBEDB0 Offset: 0xBEEB1 VA: 0xBEDB0
public sealed class UnaryExpression : Expression // TypeDefIndex: 2327
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF6D0 Offset: 0xBF7D1 VA: 0xBF6D0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF6E0 Offset: 0xBF7E1 VA: 0xBF6E0
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF6F0 Offset: 0xBF7F1 VA: 0xBF6F0
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF700 Offset: 0xBF801 VA: 0xBF700
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x1B56EC0 Offset: 0x1B56FC1 VA: 0x1B56EC0
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CA0 Offset: 0xC0DA1 VA: 0xC0CA0
	// RVA: 0x1B56F80 Offset: 0x1B57081 VA: 0x1B56F80 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CB0 Offset: 0xC0DB1 VA: 0xC0CB0
	// RVA: 0x1B56F90 Offset: 0x1B57091 VA: 0x1B56F90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CC0 Offset: 0xC0DC1 VA: 0xC0CC0
	// RVA: 0x1B56FA0 Offset: 0x1B570A1 VA: 0x1B56FA0
	public Expression get_Operand() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CD0 Offset: 0xC0DD1 VA: 0xC0CD0
	// RVA: 0x1B56FB0 Offset: 0x1B570B1 VA: 0x1B56FB0
	public MethodInfo get_Method() { }

	// RVA: 0x1B56FC0 Offset: 0x1B570C1 VA: 0x1B56FC0
	public bool get_IsLifted() { }

	// RVA: 0x1B571A0 Offset: 0x1B572A1 VA: 0x1B571A0
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1B571F0 Offset: 0x1B572F1 VA: 0x1B571F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B57220 Offset: 0x1B57321 VA: 0x1B57220 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1B57250 Offset: 0x1B57351 VA: 0x1B57250 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1B581D0 Offset: 0x1B582D1 VA: 0x1B581D0
	private bool get_IsPrefix() { }

	// RVA: 0x1B58230 Offset: 0x1B58331 VA: 0x1B58230
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x1B57F00 Offset: 0x1B58001 VA: 0x1B57F00
	private Expression ReduceVariable() { }

	// RVA: 0x1B579E0 Offset: 0x1B57AE1 VA: 0x1B579E0
	private Expression ReduceMember() { }

	// RVA: 0x1B572E0 Offset: 0x1B573E1 VA: 0x1B572E0
	private Expression ReduceIndex() { }

	// RVA: 0x1B58310 Offset: 0x1B58411 VA: 0x1B58310
	public UnaryExpression Update(Expression operand) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBEDB0 Offset: 0xBEEB1 VA: 0xBEDB0
public sealed class UnaryExpression : Expression // TypeDefIndex: 2327
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF6D0 Offset: 0xBF7D1 VA: 0xBF6D0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF6E0 Offset: 0xBF7E1 VA: 0xBF6E0
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF6F0 Offset: 0xBF7F1 VA: 0xBF6F0
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF700 Offset: 0xBF801 VA: 0xBF700
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x1B56EC0 Offset: 0x1B56FC1 VA: 0x1B56EC0
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CA0 Offset: 0xC0DA1 VA: 0xC0CA0
	// RVA: 0x1B56F80 Offset: 0x1B57081 VA: 0x1B56F80 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CB0 Offset: 0xC0DB1 VA: 0xC0CB0
	// RVA: 0x1B56F90 Offset: 0x1B57091 VA: 0x1B56F90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CC0 Offset: 0xC0DC1 VA: 0xC0CC0
	// RVA: 0x1B56FA0 Offset: 0x1B570A1 VA: 0x1B56FA0
	public Expression get_Operand() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CD0 Offset: 0xC0DD1 VA: 0xC0CD0
	// RVA: 0x1B56FB0 Offset: 0x1B570B1 VA: 0x1B56FB0
	public MethodInfo get_Method() { }

	// RVA: 0x1B56FC0 Offset: 0x1B570C1 VA: 0x1B56FC0
	public bool get_IsLifted() { }

	// RVA: 0x1B571A0 Offset: 0x1B572A1 VA: 0x1B571A0
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1B571F0 Offset: 0x1B572F1 VA: 0x1B571F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B57220 Offset: 0x1B57321 VA: 0x1B57220 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1B57250 Offset: 0x1B57351 VA: 0x1B57250 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1B581D0 Offset: 0x1B582D1 VA: 0x1B581D0
	private bool get_IsPrefix() { }

	// RVA: 0x1B58230 Offset: 0x1B58331 VA: 0x1B58230
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x1B57F00 Offset: 0x1B58001 VA: 0x1B57F00
	private Expression ReduceVariable() { }

	// RVA: 0x1B579E0 Offset: 0x1B57AE1 VA: 0x1B579E0
	private Expression ReduceMember() { }

	// RVA: 0x1B572E0 Offset: 0x1B573E1 VA: 0x1B572E0
	private Expression ReduceIndex() { }

	// RVA: 0x1B58310 Offset: 0x1B58411 VA: 0x1B58310
	public UnaryExpression Update(Expression operand) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBEDB0 Offset: 0xBEEB1 VA: 0xBEDB0
public sealed class UnaryExpression : Expression // TypeDefIndex: 2327
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF6D0 Offset: 0xBF7D1 VA: 0xBF6D0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF6E0 Offset: 0xBF7E1 VA: 0xBF6E0
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF6F0 Offset: 0xBF7F1 VA: 0xBF6F0
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF700 Offset: 0xBF801 VA: 0xBF700
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x1B56EC0 Offset: 0x1B56FC1 VA: 0x1B56EC0
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CA0 Offset: 0xC0DA1 VA: 0xC0CA0
	// RVA: 0x1B56F80 Offset: 0x1B57081 VA: 0x1B56F80 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CB0 Offset: 0xC0DB1 VA: 0xC0CB0
	// RVA: 0x1B56F90 Offset: 0x1B57091 VA: 0x1B56F90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CC0 Offset: 0xC0DC1 VA: 0xC0CC0
	// RVA: 0x1B56FA0 Offset: 0x1B570A1 VA: 0x1B56FA0
	public Expression get_Operand() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CD0 Offset: 0xC0DD1 VA: 0xC0CD0
	// RVA: 0x1B56FB0 Offset: 0x1B570B1 VA: 0x1B56FB0
	public MethodInfo get_Method() { }

	// RVA: 0x1B56FC0 Offset: 0x1B570C1 VA: 0x1B56FC0
	public bool get_IsLifted() { }

	// RVA: 0x1B571A0 Offset: 0x1B572A1 VA: 0x1B571A0
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1B571F0 Offset: 0x1B572F1 VA: 0x1B571F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B57220 Offset: 0x1B57321 VA: 0x1B57220 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1B57250 Offset: 0x1B57351 VA: 0x1B57250 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1B581D0 Offset: 0x1B582D1 VA: 0x1B581D0
	private bool get_IsPrefix() { }

	// RVA: 0x1B58230 Offset: 0x1B58331 VA: 0x1B58230
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x1B57F00 Offset: 0x1B58001 VA: 0x1B57F00
	private Expression ReduceVariable() { }

	// RVA: 0x1B579E0 Offset: 0x1B57AE1 VA: 0x1B579E0
	private Expression ReduceMember() { }

	// RVA: 0x1B572E0 Offset: 0x1B573E1 VA: 0x1B572E0
	private Expression ReduceIndex() { }

	// RVA: 0x1B58310 Offset: 0x1B58411 VA: 0x1B58310
	public UnaryExpression Update(Expression operand) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBEDB0 Offset: 0xBEEB1 VA: 0xBEDB0
public sealed class UnaryExpression : Expression // TypeDefIndex: 2327
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF6D0 Offset: 0xBF7D1 VA: 0xBF6D0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF6E0 Offset: 0xBF7E1 VA: 0xBF6E0
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF6F0 Offset: 0xBF7F1 VA: 0xBF6F0
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF700 Offset: 0xBF801 VA: 0xBF700
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x1B56EC0 Offset: 0x1B56FC1 VA: 0x1B56EC0
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CA0 Offset: 0xC0DA1 VA: 0xC0CA0
	// RVA: 0x1B56F80 Offset: 0x1B57081 VA: 0x1B56F80 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CB0 Offset: 0xC0DB1 VA: 0xC0CB0
	// RVA: 0x1B56F90 Offset: 0x1B57091 VA: 0x1B56F90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CC0 Offset: 0xC0DC1 VA: 0xC0CC0
	// RVA: 0x1B56FA0 Offset: 0x1B570A1 VA: 0x1B56FA0
	public Expression get_Operand() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CD0 Offset: 0xC0DD1 VA: 0xC0CD0
	// RVA: 0x1B56FB0 Offset: 0x1B570B1 VA: 0x1B56FB0
	public MethodInfo get_Method() { }

	// RVA: 0x1B56FC0 Offset: 0x1B570C1 VA: 0x1B56FC0
	public bool get_IsLifted() { }

	// RVA: 0x1B571A0 Offset: 0x1B572A1 VA: 0x1B571A0
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1B571F0 Offset: 0x1B572F1 VA: 0x1B571F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B57220 Offset: 0x1B57321 VA: 0x1B57220 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1B57250 Offset: 0x1B57351 VA: 0x1B57250 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1B581D0 Offset: 0x1B582D1 VA: 0x1B581D0
	private bool get_IsPrefix() { }

	// RVA: 0x1B58230 Offset: 0x1B58331 VA: 0x1B58230
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x1B57F00 Offset: 0x1B58001 VA: 0x1B57F00
	private Expression ReduceVariable() { }

	// RVA: 0x1B579E0 Offset: 0x1B57AE1 VA: 0x1B579E0
	private Expression ReduceMember() { }

	// RVA: 0x1B572E0 Offset: 0x1B573E1 VA: 0x1B572E0
	private Expression ReduceIndex() { }

	// RVA: 0x1B58310 Offset: 0x1B58411 VA: 0x1B58310
	public UnaryExpression Update(Expression operand) { }
}

