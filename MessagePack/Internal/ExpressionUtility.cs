internal static class ExpressionUtility // TypeDefIndex: 5291
{
	// Methods

	// RVA: 0x167D300 Offset: 0x167D401 VA: 0x167D300
	private static MethodInfo GetMethodInfoCore(LambdaExpression expression) { }

	// RVA: -1 Offset: -1
	public static MethodInfo GetMethodInfo<T>(Expression<Func<T>> expression) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561CA0 Offset: 0x2561DA1 VA: 0x2561CA0
	|-ExpressionUtility.GetMethodInfo<MessagePackFormatterAttribute>
	|-ExpressionUtility.GetMethodInfo<object>
	|-ExpressionUtility.GetMethodInfo<Type>
	*/

	// RVA: 0x167D3D0 Offset: 0x167D4D1 VA: 0x167D3D0
	public static MethodInfo GetMethodInfo(Expression<Action> expression) { }

	// RVA: -1 Offset: -1
	public static MethodInfo GetMethodInfo<T, TR>(Expression<Func<T, TR>> expression) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561C80 Offset: 0x2561D81 VA: 0x2561C80
	|-ExpressionUtility.GetMethodInfo<object, object>
	|-ExpressionUtility.GetMethodInfo<Type, FieldInfo>
	|-ExpressionUtility.GetMethodInfo<Type, PropertyInfo>
	*/

	// RVA: -1 Offset: -1
	public static MethodInfo GetMethodInfo<T>(Expression<Action<T>> expression) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561C90 Offset: 0x2561D91 VA: 0x2561C90
	|-ExpressionUtility.GetMethodInfo<object>
	*/

	// RVA: -1 Offset: -1
	public static MethodInfo GetMethodInfo<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> expression) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561C70 Offset: 0x2561D71 VA: 0x2561C70
	|-ExpressionUtility.GetMethodInfo<object, object, object>
	*/

	// RVA: -1 Offset: -1
	private static MemberInfo GetMemberInfoCore<T>(Expression<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561BC0 Offset: 0x2561CC1 VA: 0x2561BC0
	|-ExpressionUtility.GetMemberInfoCore<object>
	*/

	// RVA: -1 Offset: -1
	public static PropertyInfo GetPropertyInfo<T, TR>(Expression<Func<T, TR>> expression) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561CB0 Offset: 0x2561DB1 VA: 0x2561CB0
	|-ExpressionUtility.GetPropertyInfo<MessagePackFormatterAttribute, object[]>
	|-ExpressionUtility.GetPropertyInfo<MessagePackFormatterAttribute, Type>
	|-ExpressionUtility.GetPropertyInfo<object, object>
	*/

	// RVA: -1 Offset: -1
	public static FieldInfo GetFieldInfo<T, TR>(Expression<Func<T, TR>> expression) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561B50 Offset: 0x2561C51 VA: 0x2561B50
	|-ExpressionUtility.GetFieldInfo<object, object>
	*/
}

