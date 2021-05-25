internal static class ExpressionUtils // TypeDefIndex: 2735
{
	// Methods

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AB500 Offset: 0x21AB601 VA: 0x21AB500
	|-ExpressionUtils.ReturnReadOnly<Expression>
	|-ExpressionUtils.ReturnReadOnly<ParameterExpression>
	|-ExpressionUtils.ReturnReadOnly<object>
	*/

	// RVA: -1 Offset: -1
	public static T ReturnObject<T>(object collectionOrT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2263980 Offset: 0x2263A81 VA: 0x2263980
	|-ExpressionUtils.ReturnObject<Expression>
	|-ExpressionUtils.ReturnObject<ParameterExpression>
	|-ExpressionUtils.ReturnObject<object>
	*/

	// RVA: 0x16A02A0 Offset: 0x16A03A1 VA: 0x16A02A0
	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x16A06A0 Offset: 0x16A07A1 VA: 0x16A06A0
	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x16A07A0 Offset: 0x16A08A1 VA: 0x16A07A0
	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1) { }

	// RVA: 0x16A1380 Offset: 0x16A1481 VA: 0x16A1380
	public static void RequiresCanRead(Expression expression, string paramName) { }

	// RVA: 0x16A0B50 Offset: 0x16A0C51 VA: 0x16A0B50
	public static void RequiresCanRead(Expression expression, string paramName, int idx) { }

	// RVA: 0x16A0F50 Offset: 0x16A1051 VA: 0x16A0F50
	public static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x16A0600 Offset: 0x16A0701 VA: 0x16A0600
	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: -1 Offset: -1
	internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22C8B10 Offset: 0x22C8C11 VA: 0x22C8B10
	|-ExpressionUtils.SameElements<CatchBlock>
	|-ExpressionUtils.SameElements<Expression>
	|-ExpressionUtils.SameElements<object>
	*/

	// RVA: -1 Offset: -1
	private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22C8C60 Offset: 0x22C8D61 VA: 0x22C8C60
	|-ExpressionUtils.SameElementsInCollection<object>
	*/
}

