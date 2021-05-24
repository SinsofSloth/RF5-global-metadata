public abstract class ExpressionVisitor // TypeDefIndex: 2266
{
	// Methods

	// RVA: 0x196E950 Offset: 0x196EA51 VA: 0x196E950
	protected void .ctor() { }

	// RVA: 0x1970EA0 Offset: 0x1970FA1 VA: 0x1970EA0 Slot: 4
	public virtual Expression Visit(Expression node) { }

	// RVA: 0x1970ED0 Offset: 0x1970FD1 VA: 0x1970ED0
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) { }

	// RVA: 0x1971160 Offset: 0x1971261 VA: 0x1971160
	private Expression[] VisitArguments(IArgumentProvider nodes) { }

	// RVA: 0x1971170 Offset: 0x1971271 VA: 0x1971170
	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AB650 Offset: 0x21AB751 VA: 0x21AB650
	|-ExpressionVisitor.Visit<CatchBlock>
	|-ExpressionVisitor.Visit<object>
	*/

	// RVA: -1 Offset: -1
	public T VisitAndConvert<T>(T node, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2263AA0 Offset: 0x2263BA1 VA: 0x2263AA0
	|-ExpressionVisitor.VisitAndConvert<LambdaExpression>
	|-ExpressionVisitor.VisitAndConvert<ParameterExpression>
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AB8E0 Offset: 0x21AB9E1 VA: 0x21AB8E0
	|-ExpressionVisitor.VisitAndConvert<ParameterExpression>
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: 0x1971180 Offset: 0x1971281 VA: 0x1971180 Slot: 5
	protected internal virtual Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x19713C0 Offset: 0x19714C1 VA: 0x19713C0 Slot: 6
	protected internal virtual Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x19714A0 Offset: 0x19715A1 VA: 0x19714A0 Slot: 7
	protected internal virtual Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x1971530 Offset: 0x1971631 VA: 0x1971530 Slot: 8
	protected internal virtual Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x1971540 Offset: 0x1971641 VA: 0x1971540 Slot: 9
	protected internal virtual Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x1971550 Offset: 0x1971651 VA: 0x1971550 Slot: 10
	protected internal virtual Expression VisitExtension(Expression node) { }

	// RVA: 0x1971580 Offset: 0x1971681 VA: 0x1971580 Slot: 11
	protected internal virtual Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x1971750 Offset: 0x1971851 VA: 0x1971750 Slot: 12
	protected internal virtual Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x19717E0 Offset: 0x19718E1 VA: 0x19717E0 Slot: 13
	protected virtual LabelTarget VisitLabelTarget(LabelTarget node) { }

	// RVA: 0x19717F0 Offset: 0x19718F1 VA: 0x19717F0 Slot: 14
	protected internal virtual Expression VisitLabel(LabelExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal virtual Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F440 Offset: 0x255F541 VA: 0x255F440
	|-ExpressionVisitor.VisitLambda<object>
	*/

	// RVA: 0x1971860 Offset: 0x1971961 VA: 0x1971860 Slot: 16
	protected internal virtual Expression VisitMember(MemberExpression node) { }

	// RVA: 0x19718A0 Offset: 0x19719A1 VA: 0x19718A0 Slot: 17
	protected internal virtual Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x1971A10 Offset: 0x1971B11 VA: 0x1971A10 Slot: 18
	protected internal virtual Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x1971AC0 Offset: 0x1971BC1 VA: 0x1971AC0 Slot: 19
	protected internal virtual Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x1971B00 Offset: 0x1971C01 VA: 0x1971B00 Slot: 20
	protected internal virtual Expression VisitNew(NewExpression node) { }

	// RVA: 0x1971B50 Offset: 0x1971C51 VA: 0x1971B50 Slot: 21
	protected internal virtual Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x1971B60 Offset: 0x1971C61 VA: 0x1971B60 Slot: 22
	protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1971C20 Offset: 0x1971D21 VA: 0x1971C20 Slot: 23
	protected internal virtual Expression VisitTry(TryExpression node) { }

	// RVA: 0x1971D30 Offset: 0x1971E31 VA: 0x1971D30 Slot: 24
	protected internal virtual Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x1971D80 Offset: 0x1971E81 VA: 0x1971D80
	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) { }

	// RVA: 0x1971260 Offset: 0x1971361 VA: 0x1971260
	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) { }

	// RVA: 0x1971E90 Offset: 0x1971F91 VA: 0x1971E90
	private static void ValidateChildType(Type before, Type after, string methodName) { }
}

