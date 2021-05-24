internal sealed class ExpressionStringBuilder : ExpressionVisitor // TypeDefIndex: 2264
{
	// Fields
	private readonly StringBuilder _out; // 0x10
	private Dictionary<object, int> _ids; // 0x18

	// Methods

	// RVA: 0x196E8D0 Offset: 0x196E9D1 VA: 0x196E8D0
	private void .ctor() { }

	// RVA: 0x196E960 Offset: 0x196EA61 VA: 0x196E960 Slot: 3
	public override string ToString() { }

	// RVA: 0x196E980 Offset: 0x196EA81 VA: 0x196E980
	private int GetLabelId(LabelTarget label) { }

	// RVA: 0x196EA90 Offset: 0x196EB91 VA: 0x196EA90
	private int GetParamId(ParameterExpression p) { }

	// RVA: 0x196E990 Offset: 0x196EA91 VA: 0x196E990
	private int GetId(object o) { }

	// RVA: 0x196EAA0 Offset: 0x196EBA1 VA: 0x196EAA0
	private void Out(string s) { }

	// RVA: 0x196EAC0 Offset: 0x196EBC1 VA: 0x196EAC0
	private void Out(char c) { }

	// RVA: 0x196EAE0 Offset: 0x196EBE1 VA: 0x196EAE0
	internal static string ExpressionToString(Expression node) { }

	// RVA: 0x196EBC0 Offset: 0x196ECC1 VA: 0x196EBC0
	internal static string CatchBlockToString(CatchBlock node) { }

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B6EA0 Offset: 0x24B6FA1 VA: 0x24B6EA0
	|-ExpressionStringBuilder.VisitExpressions<Expression>
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B6F30 Offset: 0x24B7031 VA: 0x24B6F30
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: 0x196ECB0 Offset: 0x196EDB1 VA: 0x196ECB0 Slot: 5
	protected internal override Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x196F220 Offset: 0x196F321 VA: 0x196F220 Slot: 21
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F2C0 Offset: 0x255F3C1 VA: 0x255F2C0
	|-ExpressionStringBuilder.VisitLambda<object>
	*/

	// RVA: 0x196F320 Offset: 0x196F421 VA: 0x196F320 Slot: 7
	protected internal override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x196F420 Offset: 0x196F521 VA: 0x196F420 Slot: 8
	protected internal override Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x196F590 Offset: 0x196F691 VA: 0x196F590
	private void OutMember(Expression instance, MemberInfo member) { }

	// RVA: 0x196F640 Offset: 0x196F741 VA: 0x196F640 Slot: 16
	protected internal override Expression VisitMember(MemberExpression node) { }

	// RVA: 0x196F6A0 Offset: 0x196F7A1 VA: 0x196F6A0 Slot: 12
	protected internal override Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x196F7D0 Offset: 0x196F8D1 VA: 0x196F7D0 Slot: 18
	protected internal override Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x196F9C0 Offset: 0x196FAC1 VA: 0x196F9C0 Slot: 19
	protected internal override Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x196FAE0 Offset: 0x196FBE1 VA: 0x196FAE0 Slot: 20
	protected internal override Expression VisitNew(NewExpression node) { }

	// RVA: 0x196FD00 Offset: 0x196FE01 VA: 0x196FD00 Slot: 24
	protected internal override Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x1970090 Offset: 0x1970191 VA: 0x1970090 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1970360 Offset: 0x1970461 VA: 0x1970360 Slot: 9
	protected internal override Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x1970420 Offset: 0x1970521 VA: 0x1970420 Slot: 14
	protected internal override Expression VisitLabel(LabelExpression node) { }

	// RVA: 0x19705A0 Offset: 0x19706A1 VA: 0x19705A0 Slot: 11
	protected internal override Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x19706D0 Offset: 0x19707D1 VA: 0x19706D0 Slot: 22
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x19707F0 Offset: 0x19708F1 VA: 0x19707F0 Slot: 23
	protected internal override Expression VisitTry(TryExpression node) { }

	// RVA: 0x1970860 Offset: 0x1970961 VA: 0x1970860 Slot: 17
	protected internal override Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x1970C90 Offset: 0x1970D91 VA: 0x1970C90 Slot: 10
	protected internal override Expression VisitExtension(Expression node) { }

	// RVA: 0x19704C0 Offset: 0x19705C1 VA: 0x19704C0
	private void DumpLabel(LabelTarget target) { }

	// RVA: 0x196F100 Offset: 0x196F201 VA: 0x196F100
	private static bool IsBool(Expression node) { }
}

