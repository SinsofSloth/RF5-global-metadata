public abstract class Expression // TypeDefIndex: 2211
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x16A9430 Offset: 0x16A9531 VA: 0x16A9430
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x16B2A60 Offset: 0x16B2B61 VA: 0x16B2A60
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B31D0 Offset: 0x16B32D1 VA: 0x16B31D0
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x16B3AF0 Offset: 0x16B3BF1 VA: 0x16B3AF0
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B4060 Offset: 0x16B4161 VA: 0x16B4060
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B4330 Offset: 0x16B4431 VA: 0x16B4330
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B2DD0 Offset: 0x16B2ED1 VA: 0x16B2DD0
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x16B4570 Offset: 0x16B4671 VA: 0x16B4570
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x16B39D0 Offset: 0x16B3AD1 VA: 0x16B39D0
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x16B3A40 Offset: 0x16B3B41 VA: 0x16B3A40
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x16B38A0 Offset: 0x16B39A1 VA: 0x16B38A0
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x16B45F0 Offset: 0x16B46F1 VA: 0x16B45F0
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x16B4720 Offset: 0x16B4821 VA: 0x16B4720
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x16B4940 Offset: 0x16B4A41 VA: 0x16B4940
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x16B4A00 Offset: 0x16B4B01 VA: 0x16B4A00
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x16B52D0 Offset: 0x16B53D1 VA: 0x16B52D0
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x16B5130 Offset: 0x16B5231 VA: 0x16B5130
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x16A91E0 Offset: 0x16A92E1 VA: 0x16A91E0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A7870 Offset: 0x16A7971 VA: 0x16A7870
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7960 Offset: 0x16B7A61 VA: 0x16B7960
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A75A0 Offset: 0x16A76A1 VA: 0x16A75A0
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x16B7A80 Offset: 0x16B7B81 VA: 0x16B7A80
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A76E0 Offset: 0x16A77E1 VA: 0x16A76E0
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x16BA810 Offset: 0x16BA911 VA: 0x16BA810
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B7720 Offset: 0x16B7821 VA: 0x16B7720
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B74E0 Offset: 0x16B75E1 VA: 0x16B74E0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7840 Offset: 0x16B7941 VA: 0x16B7840
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7600 Offset: 0x16B7701 VA: 0x16B7600
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16BABA0 Offset: 0x16BACA1 VA: 0x16BABA0
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B67F0 Offset: 0x16B68F1 VA: 0x16B67F0
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B6F90 Offset: 0x16B7091 VA: 0x16B6F90
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B7D90 Offset: 0x16B7E91 VA: 0x16B7D90
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x16BAD80 Offset: 0x16BAE81 VA: 0x16BAD80
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x16B5520 Offset: 0x16B5621 VA: 0x16B5520
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8900 Offset: 0x16B8A01 VA: 0x16B8900
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B3D30 Offset: 0x16B3E31 VA: 0x16B3D30
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x16BA150 Offset: 0x16BA251 VA: 0x16BA150
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5710 Offset: 0x16B5811 VA: 0x16B5710
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B5900 Offset: 0x16B5A01 VA: 0x16B5900
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9F10 Offset: 0x16BA011 VA: 0x16B9F10
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA390 Offset: 0x16BA491 VA: 0x16BA390
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5AF0 Offset: 0x16B5BF1 VA: 0x16B5AF0
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B60C0 Offset: 0x16B61C1 VA: 0x16B60C0
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8D80 Offset: 0x16B8E81 VA: 0x16B8D80
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B62B0 Offset: 0x16B63B1 VA: 0x16B62B0
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9460 Offset: 0x16B9561 VA: 0x16B9460
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5CE0 Offset: 0x16B5DE1 VA: 0x16B5CE0
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B96A0 Offset: 0x16B97A1 VA: 0x16B96A0
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA5D0 Offset: 0x16BA6D1 VA: 0x16BA5D0
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5ED0 Offset: 0x16B5FD1 VA: 0x16B5ED0
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16BAEC0 Offset: 0x16BAFC1 VA: 0x16BAEC0
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x16BAFC0 Offset: 0x16BB0C1 VA: 0x16BAFC0
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x16B86D0 Offset: 0x16B87D1 VA: 0x16B86D0
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9200 Offset: 0x16B9301 VA: 0x16B9200
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B84A0 Offset: 0x16B85A1 VA: 0x16B84A0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9CB0 Offset: 0x16B9DB1 VA: 0x16B9CB0
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6600 Offset: 0x16B6701 VA: 0x16B6600
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8B40 Offset: 0x16B8C41 VA: 0x16B8B40
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6DA0 Offset: 0x16B6EA1 VA: 0x16B6DA0
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B98E0 Offset: 0x16B99E1 VA: 0x16B98E0
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7BA0 Offset: 0x16B7CA1 VA: 0x16B7BA0
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8FC0 Offset: 0x16B90C1 VA: 0x16B8FC0
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B64A0 Offset: 0x16B65A1 VA: 0x16B64A0
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9B20 Offset: 0x16B9C21 VA: 0x16B9B20
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B82E0 Offset: 0x16B83E1 VA: 0x16B82E0
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x16BB100 Offset: 0x16BB201 VA: 0x16BB100
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x16BB260 Offset: 0x16BB361 VA: 0x16BB260
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB580 Offset: 0x16BB681 VA: 0x16BB580
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x16A98F0 Offset: 0x16A99F1 VA: 0x16A98F0
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB310 Offset: 0x16BB411 VA: 0x16BB310
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BC0B0 Offset: 0x16BC1B1 VA: 0x16BC0B0
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x16BC3F0 Offset: 0x16BC4F1 VA: 0x16BC3F0
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x16BB760 Offset: 0x16BB861 VA: 0x16BB760
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x16AD490 Offset: 0x16AD591 VA: 0x16AD490
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x16AB2F0 Offset: 0x16AB3F1 VA: 0x16AB2F0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x16ADDB0 Offset: 0x16ADEB1 VA: 0x16ADDB0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x16BC630 Offset: 0x16BC731 VA: 0x16BC630
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x16AB010 Offset: 0x16AB111 VA: 0x16AB010
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x16BC6F0 Offset: 0x16BC7F1 VA: 0x16BC6F0
	public static DefaultExpression Empty() { }

	// RVA: 0x16A7270 Offset: 0x16A7371 VA: 0x16A7270
	protected void .ctor() { }

	// RVA: 0x16BC7F0 Offset: 0x16BC8F1 VA: 0x16BC7F0 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x16BC8E0 Offset: 0x16BC9E1 VA: 0x16BC8E0 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x16BC9D0 Offset: 0x16BCAD1 VA: 0x16BC9D0 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x16BC9E0 Offset: 0x16BCAE1 VA: 0x16BC9E0 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x16BCA50 Offset: 0x16BCB51 VA: 0x16BCA50 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x16BCBE0 Offset: 0x16BCCE1 VA: 0x16BCBE0 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x16BCAF0 Offset: 0x16BCBF1 VA: 0x16BCAF0
	public Expression ReduceAndCheck() { }

	// RVA: 0x16BCC10 Offset: 0x16BCD11 VA: 0x16BCC10 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BB600 Offset: 0x16BB701 VA: 0x16BB600
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x16B2830 Offset: 0x16B2931 VA: 0x16B2830
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x16BCC20 Offset: 0x16BCD21 VA: 0x16BCC20
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x16BCCE0 Offset: 0x16BCDE1 VA: 0x16BCCE0
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x16BCDC0 Offset: 0x16BCEC1 VA: 0x16BCDC0
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x16BCFA0 Offset: 0x16BD0A1 VA: 0x16BCFA0
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x16A9AB0 Offset: 0x16A9BB1 VA: 0x16A9AB0
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD670 Offset: 0x16BD771 VA: 0x16BD670
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x16BD210 Offset: 0x16BD311 VA: 0x16BD210
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x16BD0F0 Offset: 0x16BD1F1 VA: 0x16BD0F0
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD6F0 Offset: 0x16BD7F1 VA: 0x16BD6F0
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BD7B0 Offset: 0x16BD8B1 VA: 0x16BD7B0
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BDDB0 Offset: 0x16BDEB1 VA: 0x16BDDB0
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16BE0B0 Offset: 0x16BE1B1 VA: 0x16BE0B0
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16A9280 Offset: 0x16A9381 VA: 0x16A9280
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x16BE4B0 Offset: 0x16BE5B1 VA: 0x16BE4B0
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x16BE760 Offset: 0x16BE861 VA: 0x16BE760
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x16BE820 Offset: 0x16BE921 VA: 0x16BE820
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x16BE920 Offset: 0x16BEA21 VA: 0x16BE920
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F970 Offset: 0x255FA71 VA: 0x255F970
	|-Expression.Lambda<DynamicObjectTypeFallbackFormatter.SerializeMethod>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize>
	|-Expression.Lambda<Action<object>>
	|-Expression.Lambda<Action<IBufferWriter<byte>, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Action<Stream, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute>>
	|-Expression.Lambda<Func<object>>
	|-Expression.Lambda<Func<Type>>
	|-Expression.Lambda<Func<IFormatterResolver, IMessagePackFormatter>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, object[]>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, Type>>
	|-Expression.Lambda<Func<Type, FieldInfo>>
	|-Expression.Lambda<Func<Type, PropertyInfo>>
	|-Expression.Lambda<Func<ReadOnlySequence<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, ValueTask<object>>>
	|-Expression.Lambda<Func<object, MessagePackSerializerOptions, CancellationToken, byte[]>>
	|-Expression.Lambda<Func<ReadOnlyMemory<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, object, MessagePackSerializerOptions, CancellationToken, Task>>
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F8D0 Offset: 0x255F9D1 VA: 0x255F8D0
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FA00 Offset: 0x255FB01 VA: 0x255FA00
	|-Expression.Lambda<object>
	*/

	// RVA: 0x16BED70 Offset: 0x16BEE71 VA: 0x16BED70
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x16BEE00 Offset: 0x16BEF01 VA: 0x16BEE00
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x16BEED0 Offset: 0x16BEFD1 VA: 0x16BEED0
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x16BF5C0 Offset: 0x16BF6C1 VA: 0x16BF5C0
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x16BF790 Offset: 0x16BF891 VA: 0x16BF790
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x16AA790 Offset: 0x16AA891 VA: 0x16AA790
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x16BF940 Offset: 0x16BFA41 VA: 0x16BF940
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x16BFBF0 Offset: 0x16BFCF1 VA: 0x16BFBF0
	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor) { }

	// RVA: 0x16BFCF0 Offset: 0x16BFDF1 VA: 0x16BFCF0
	private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1) { }

	// RVA: 0x16BFF40 Offset: 0x16C0041 VA: 0x16BFF40
	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod) { }

	// RVA: 0x16A9710 Offset: 0x16A9811 VA: 0x16A9710
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x16C0040 Offset: 0x16C0141 VA: 0x16C0040
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x16AAB70 Offset: 0x16AAC71 VA: 0x16AAB70
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x16AAD50 Offset: 0x16AAE51 VA: 0x16AAD50
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C0280 Offset: 0x16C0381 VA: 0x16C0280
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16C0510 Offset: 0x16C0611 VA: 0x16C0510
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x16C07F0 Offset: 0x16C08F1 VA: 0x16C07F0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x16C0B30 Offset: 0x16C0C31 VA: 0x16C0B30
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C1590 Offset: 0x16C1691 VA: 0x16C1590
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x16C1720 Offset: 0x16C1821 VA: 0x16C1720
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x16C17A0 Offset: 0x16C18A1 VA: 0x16C17A0
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x16C19B0 Offset: 0x16C1AB1 VA: 0x16C19B0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C1C30 Offset: 0x16C1D31 VA: 0x16C1C30
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16AA940 Offset: 0x16AAA41 VA: 0x16AA940
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x16C0BB0 Offset: 0x16C0CB1 VA: 0x16C0BB0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C01A0 Offset: 0x16C02A1 VA: 0x16C01A0
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x16C21E0 Offset: 0x16C22E1 VA: 0x16C21E0
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x16BE010 Offset: 0x16BE111 VA: 0x16BE010
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x16C2320 Offset: 0x16C2421 VA: 0x16C2320
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x16BE6A0 Offset: 0x16BE7A1 VA: 0x16BE6A0
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x16BE740 Offset: 0x16BE841 VA: 0x16BE740
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x16BE750 Offset: 0x16BE851 VA: 0x16BE750
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x16BD0E0 Offset: 0x16BD1E1 VA: 0x16BD0E0
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x16C1F00 Offset: 0x16C2001 VA: 0x16C1F00
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x16C23F0 Offset: 0x16C24F1 VA: 0x16C23F0
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x16C2330 Offset: 0x16C2431 VA: 0x16C2330
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x16C2640 Offset: 0x16C2741 VA: 0x16C2640
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x16C26C0 Offset: 0x16C27C1 VA: 0x16C26C0
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x16C2AF0 Offset: 0x16C2BF1 VA: 0x16C2AF0
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x16C2D90 Offset: 0x16C2E91 VA: 0x16C2D90
	public static NewExpression New(ConstructorInfo constructor, Expression[] arguments) { }

	// RVA: 0x16C2E10 Offset: 0x16C2F11 VA: 0x16C2E10
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C30D0 Offset: 0x16C31D1 VA: 0x16C30D0
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members) { }

	// RVA: 0x16C3330 Offset: 0x16C3431 VA: 0x16C3330
	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x16C3C60 Offset: 0x16C3D61 VA: 0x16C3C60
	private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType, string paramName, int index) { }

	// RVA: 0x16C3050 Offset: 0x16C3151 VA: 0x16C3050
	private static void ValidateConstructor(ConstructorInfo constructor, string paramName) { }

	// RVA: 0x16C3F10 Offset: 0x16C4011 VA: 0x16C3F10
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x16AA6D0 Offset: 0x16AA7D1 VA: 0x16AA6D0
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x16A9680 Offset: 0x16A9781 VA: 0x16A9680
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x16C3F80 Offset: 0x16C4081 VA: 0x16C3F80
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x16C40C0 Offset: 0x16C41C1 VA: 0x16C40C0
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x16C4140 Offset: 0x16C4241 VA: 0x16C4140
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x16C4320 Offset: 0x16C4421 VA: 0x16C4320
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x16C4D70 Offset: 0x16C4E71 VA: 0x16C4D70
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x16C6D10 Offset: 0x16C6E11 VA: 0x16C6D10
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C6F10 Offset: 0x16C7011 VA: 0x16C6F10
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C72B0 Offset: 0x16C73B1 VA: 0x16C72B0
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x16C76D0 Offset: 0x16C77D1 VA: 0x16C76D0
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7790 Offset: 0x16C7891 VA: 0x16C7790
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7850 Offset: 0x16C7951 VA: 0x16C7850
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x16C53E0 Offset: 0x16C54E1 VA: 0x16C53E0
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6520 Offset: 0x16C6621 VA: 0x16C6520
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5560 Offset: 0x16C5661 VA: 0x16C5560
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x16C56E0 Offset: 0x16C57E1 VA: 0x16C56E0
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5880 Offset: 0x16C5981 VA: 0x16C5880
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x16C59E0 Offset: 0x16C5AE1 VA: 0x16C59E0
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5B40 Offset: 0x16C5C41 VA: 0x16C5B40
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C63D0 Offset: 0x16C64D1 VA: 0x16C63D0
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x16C6680 Offset: 0x16C6781 VA: 0x16C6680
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x16AAF90 Offset: 0x16AB091 VA: 0x16AAF90
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x16C5E60 Offset: 0x16C5F61 VA: 0x16C5E60
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C6060 Offset: 0x16C6161 VA: 0x16C6060
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C5CA0 Offset: 0x16C5DA1 VA: 0x16C5CA0
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x16A1540 Offset: 0x16A1641 VA: 0x16A1540
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x16C6270 Offset: 0x16C6371 VA: 0x16C6270
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x16C6850 Offset: 0x16C6951 VA: 0x16C6850
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x16C69B0 Offset: 0x16C6AB1 VA: 0x16C69B0
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B10 Offset: 0x16C6C11 VA: 0x16C6B10
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C10 Offset: 0x16C6D11 VA: 0x16C6C10
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B90 Offset: 0x16C6C91 VA: 0x16C6B90
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C90 Offset: 0x16C6D91 VA: 0x16C6C90
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C7D40 Offset: 0x16C7E41 VA: 0x16C7D40
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x16C7F70 Offset: 0x16C8071 VA: 0x16C7F70
	private static void .cctor() { }
}

public abstract class Expression // TypeDefIndex: 2211
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x16A9430 Offset: 0x16A9531 VA: 0x16A9430
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x16B2A60 Offset: 0x16B2B61 VA: 0x16B2A60
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B31D0 Offset: 0x16B32D1 VA: 0x16B31D0
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x16B3AF0 Offset: 0x16B3BF1 VA: 0x16B3AF0
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B4060 Offset: 0x16B4161 VA: 0x16B4060
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B4330 Offset: 0x16B4431 VA: 0x16B4330
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B2DD0 Offset: 0x16B2ED1 VA: 0x16B2DD0
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x16B4570 Offset: 0x16B4671 VA: 0x16B4570
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x16B39D0 Offset: 0x16B3AD1 VA: 0x16B39D0
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x16B3A40 Offset: 0x16B3B41 VA: 0x16B3A40
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x16B38A0 Offset: 0x16B39A1 VA: 0x16B38A0
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x16B45F0 Offset: 0x16B46F1 VA: 0x16B45F0
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x16B4720 Offset: 0x16B4821 VA: 0x16B4720
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x16B4940 Offset: 0x16B4A41 VA: 0x16B4940
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x16B4A00 Offset: 0x16B4B01 VA: 0x16B4A00
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x16B52D0 Offset: 0x16B53D1 VA: 0x16B52D0
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x16B5130 Offset: 0x16B5231 VA: 0x16B5130
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x16A91E0 Offset: 0x16A92E1 VA: 0x16A91E0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A7870 Offset: 0x16A7971 VA: 0x16A7870
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7960 Offset: 0x16B7A61 VA: 0x16B7960
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A75A0 Offset: 0x16A76A1 VA: 0x16A75A0
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x16B7A80 Offset: 0x16B7B81 VA: 0x16B7A80
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A76E0 Offset: 0x16A77E1 VA: 0x16A76E0
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x16BA810 Offset: 0x16BA911 VA: 0x16BA810
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B7720 Offset: 0x16B7821 VA: 0x16B7720
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B74E0 Offset: 0x16B75E1 VA: 0x16B74E0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7840 Offset: 0x16B7941 VA: 0x16B7840
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7600 Offset: 0x16B7701 VA: 0x16B7600
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16BABA0 Offset: 0x16BACA1 VA: 0x16BABA0
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B67F0 Offset: 0x16B68F1 VA: 0x16B67F0
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B6F90 Offset: 0x16B7091 VA: 0x16B6F90
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B7D90 Offset: 0x16B7E91 VA: 0x16B7D90
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x16BAD80 Offset: 0x16BAE81 VA: 0x16BAD80
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x16B5520 Offset: 0x16B5621 VA: 0x16B5520
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8900 Offset: 0x16B8A01 VA: 0x16B8900
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B3D30 Offset: 0x16B3E31 VA: 0x16B3D30
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x16BA150 Offset: 0x16BA251 VA: 0x16BA150
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5710 Offset: 0x16B5811 VA: 0x16B5710
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B5900 Offset: 0x16B5A01 VA: 0x16B5900
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9F10 Offset: 0x16BA011 VA: 0x16B9F10
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA390 Offset: 0x16BA491 VA: 0x16BA390
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5AF0 Offset: 0x16B5BF1 VA: 0x16B5AF0
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B60C0 Offset: 0x16B61C1 VA: 0x16B60C0
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8D80 Offset: 0x16B8E81 VA: 0x16B8D80
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B62B0 Offset: 0x16B63B1 VA: 0x16B62B0
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9460 Offset: 0x16B9561 VA: 0x16B9460
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5CE0 Offset: 0x16B5DE1 VA: 0x16B5CE0
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B96A0 Offset: 0x16B97A1 VA: 0x16B96A0
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA5D0 Offset: 0x16BA6D1 VA: 0x16BA5D0
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5ED0 Offset: 0x16B5FD1 VA: 0x16B5ED0
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16BAEC0 Offset: 0x16BAFC1 VA: 0x16BAEC0
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x16BAFC0 Offset: 0x16BB0C1 VA: 0x16BAFC0
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x16B86D0 Offset: 0x16B87D1 VA: 0x16B86D0
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9200 Offset: 0x16B9301 VA: 0x16B9200
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B84A0 Offset: 0x16B85A1 VA: 0x16B84A0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9CB0 Offset: 0x16B9DB1 VA: 0x16B9CB0
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6600 Offset: 0x16B6701 VA: 0x16B6600
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8B40 Offset: 0x16B8C41 VA: 0x16B8B40
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6DA0 Offset: 0x16B6EA1 VA: 0x16B6DA0
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B98E0 Offset: 0x16B99E1 VA: 0x16B98E0
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7BA0 Offset: 0x16B7CA1 VA: 0x16B7BA0
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8FC0 Offset: 0x16B90C1 VA: 0x16B8FC0
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B64A0 Offset: 0x16B65A1 VA: 0x16B64A0
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9B20 Offset: 0x16B9C21 VA: 0x16B9B20
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B82E0 Offset: 0x16B83E1 VA: 0x16B82E0
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x16BB100 Offset: 0x16BB201 VA: 0x16BB100
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x16BB260 Offset: 0x16BB361 VA: 0x16BB260
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB580 Offset: 0x16BB681 VA: 0x16BB580
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x16A98F0 Offset: 0x16A99F1 VA: 0x16A98F0
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB310 Offset: 0x16BB411 VA: 0x16BB310
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BC0B0 Offset: 0x16BC1B1 VA: 0x16BC0B0
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x16BC3F0 Offset: 0x16BC4F1 VA: 0x16BC3F0
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x16BB760 Offset: 0x16BB861 VA: 0x16BB760
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x16AD490 Offset: 0x16AD591 VA: 0x16AD490
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x16AB2F0 Offset: 0x16AB3F1 VA: 0x16AB2F0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x16ADDB0 Offset: 0x16ADEB1 VA: 0x16ADDB0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x16BC630 Offset: 0x16BC731 VA: 0x16BC630
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x16AB010 Offset: 0x16AB111 VA: 0x16AB010
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x16BC6F0 Offset: 0x16BC7F1 VA: 0x16BC6F0
	public static DefaultExpression Empty() { }

	// RVA: 0x16A7270 Offset: 0x16A7371 VA: 0x16A7270
	protected void .ctor() { }

	// RVA: 0x16BC7F0 Offset: 0x16BC8F1 VA: 0x16BC7F0 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x16BC8E0 Offset: 0x16BC9E1 VA: 0x16BC8E0 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x16BC9D0 Offset: 0x16BCAD1 VA: 0x16BC9D0 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x16BC9E0 Offset: 0x16BCAE1 VA: 0x16BC9E0 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x16BCA50 Offset: 0x16BCB51 VA: 0x16BCA50 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x16BCBE0 Offset: 0x16BCCE1 VA: 0x16BCBE0 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x16BCAF0 Offset: 0x16BCBF1 VA: 0x16BCAF0
	public Expression ReduceAndCheck() { }

	// RVA: 0x16BCC10 Offset: 0x16BCD11 VA: 0x16BCC10 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BB600 Offset: 0x16BB701 VA: 0x16BB600
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x16B2830 Offset: 0x16B2931 VA: 0x16B2830
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x16BCC20 Offset: 0x16BCD21 VA: 0x16BCC20
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x16BCCE0 Offset: 0x16BCDE1 VA: 0x16BCCE0
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x16BCDC0 Offset: 0x16BCEC1 VA: 0x16BCDC0
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x16BCFA0 Offset: 0x16BD0A1 VA: 0x16BCFA0
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x16A9AB0 Offset: 0x16A9BB1 VA: 0x16A9AB0
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD670 Offset: 0x16BD771 VA: 0x16BD670
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x16BD210 Offset: 0x16BD311 VA: 0x16BD210
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x16BD0F0 Offset: 0x16BD1F1 VA: 0x16BD0F0
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD6F0 Offset: 0x16BD7F1 VA: 0x16BD6F0
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BD7B0 Offset: 0x16BD8B1 VA: 0x16BD7B0
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BDDB0 Offset: 0x16BDEB1 VA: 0x16BDDB0
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16BE0B0 Offset: 0x16BE1B1 VA: 0x16BE0B0
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16A9280 Offset: 0x16A9381 VA: 0x16A9280
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x16BE4B0 Offset: 0x16BE5B1 VA: 0x16BE4B0
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x16BE760 Offset: 0x16BE861 VA: 0x16BE760
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x16BE820 Offset: 0x16BE921 VA: 0x16BE820
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x16BE920 Offset: 0x16BEA21 VA: 0x16BE920
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F970 Offset: 0x255FA71 VA: 0x255F970
	|-Expression.Lambda<DynamicObjectTypeFallbackFormatter.SerializeMethod>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize>
	|-Expression.Lambda<Action<object>>
	|-Expression.Lambda<Action<IBufferWriter<byte>, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Action<Stream, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute>>
	|-Expression.Lambda<Func<object>>
	|-Expression.Lambda<Func<Type>>
	|-Expression.Lambda<Func<IFormatterResolver, IMessagePackFormatter>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, object[]>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, Type>>
	|-Expression.Lambda<Func<Type, FieldInfo>>
	|-Expression.Lambda<Func<Type, PropertyInfo>>
	|-Expression.Lambda<Func<ReadOnlySequence<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, ValueTask<object>>>
	|-Expression.Lambda<Func<object, MessagePackSerializerOptions, CancellationToken, byte[]>>
	|-Expression.Lambda<Func<ReadOnlyMemory<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, object, MessagePackSerializerOptions, CancellationToken, Task>>
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F8D0 Offset: 0x255F9D1 VA: 0x255F8D0
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FA00 Offset: 0x255FB01 VA: 0x255FA00
	|-Expression.Lambda<object>
	*/

	// RVA: 0x16BED70 Offset: 0x16BEE71 VA: 0x16BED70
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x16BEE00 Offset: 0x16BEF01 VA: 0x16BEE00
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x16BEED0 Offset: 0x16BEFD1 VA: 0x16BEED0
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x16BF5C0 Offset: 0x16BF6C1 VA: 0x16BF5C0
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x16BF790 Offset: 0x16BF891 VA: 0x16BF790
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x16AA790 Offset: 0x16AA891 VA: 0x16AA790
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x16BF940 Offset: 0x16BFA41 VA: 0x16BF940
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x16BFBF0 Offset: 0x16BFCF1 VA: 0x16BFBF0
	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor) { }

	// RVA: 0x16BFCF0 Offset: 0x16BFDF1 VA: 0x16BFCF0
	private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1) { }

	// RVA: 0x16BFF40 Offset: 0x16C0041 VA: 0x16BFF40
	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod) { }

	// RVA: 0x16A9710 Offset: 0x16A9811 VA: 0x16A9710
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x16C0040 Offset: 0x16C0141 VA: 0x16C0040
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x16AAB70 Offset: 0x16AAC71 VA: 0x16AAB70
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x16AAD50 Offset: 0x16AAE51 VA: 0x16AAD50
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C0280 Offset: 0x16C0381 VA: 0x16C0280
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16C0510 Offset: 0x16C0611 VA: 0x16C0510
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x16C07F0 Offset: 0x16C08F1 VA: 0x16C07F0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x16C0B30 Offset: 0x16C0C31 VA: 0x16C0B30
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C1590 Offset: 0x16C1691 VA: 0x16C1590
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x16C1720 Offset: 0x16C1821 VA: 0x16C1720
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x16C17A0 Offset: 0x16C18A1 VA: 0x16C17A0
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x16C19B0 Offset: 0x16C1AB1 VA: 0x16C19B0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C1C30 Offset: 0x16C1D31 VA: 0x16C1C30
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16AA940 Offset: 0x16AAA41 VA: 0x16AA940
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x16C0BB0 Offset: 0x16C0CB1 VA: 0x16C0BB0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C01A0 Offset: 0x16C02A1 VA: 0x16C01A0
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x16C21E0 Offset: 0x16C22E1 VA: 0x16C21E0
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x16BE010 Offset: 0x16BE111 VA: 0x16BE010
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x16C2320 Offset: 0x16C2421 VA: 0x16C2320
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x16BE6A0 Offset: 0x16BE7A1 VA: 0x16BE6A0
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x16BE740 Offset: 0x16BE841 VA: 0x16BE740
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x16BE750 Offset: 0x16BE851 VA: 0x16BE750
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x16BD0E0 Offset: 0x16BD1E1 VA: 0x16BD0E0
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x16C1F00 Offset: 0x16C2001 VA: 0x16C1F00
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x16C23F0 Offset: 0x16C24F1 VA: 0x16C23F0
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x16C2330 Offset: 0x16C2431 VA: 0x16C2330
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x16C2640 Offset: 0x16C2741 VA: 0x16C2640
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x16C26C0 Offset: 0x16C27C1 VA: 0x16C26C0
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x16C2AF0 Offset: 0x16C2BF1 VA: 0x16C2AF0
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x16C2D90 Offset: 0x16C2E91 VA: 0x16C2D90
	public static NewExpression New(ConstructorInfo constructor, Expression[] arguments) { }

	// RVA: 0x16C2E10 Offset: 0x16C2F11 VA: 0x16C2E10
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C30D0 Offset: 0x16C31D1 VA: 0x16C30D0
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members) { }

	// RVA: 0x16C3330 Offset: 0x16C3431 VA: 0x16C3330
	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x16C3C60 Offset: 0x16C3D61 VA: 0x16C3C60
	private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType, string paramName, int index) { }

	// RVA: 0x16C3050 Offset: 0x16C3151 VA: 0x16C3050
	private static void ValidateConstructor(ConstructorInfo constructor, string paramName) { }

	// RVA: 0x16C3F10 Offset: 0x16C4011 VA: 0x16C3F10
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x16AA6D0 Offset: 0x16AA7D1 VA: 0x16AA6D0
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x16A9680 Offset: 0x16A9781 VA: 0x16A9680
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x16C3F80 Offset: 0x16C4081 VA: 0x16C3F80
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x16C40C0 Offset: 0x16C41C1 VA: 0x16C40C0
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x16C4140 Offset: 0x16C4241 VA: 0x16C4140
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x16C4320 Offset: 0x16C4421 VA: 0x16C4320
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x16C4D70 Offset: 0x16C4E71 VA: 0x16C4D70
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x16C6D10 Offset: 0x16C6E11 VA: 0x16C6D10
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C6F10 Offset: 0x16C7011 VA: 0x16C6F10
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C72B0 Offset: 0x16C73B1 VA: 0x16C72B0
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x16C76D0 Offset: 0x16C77D1 VA: 0x16C76D0
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7790 Offset: 0x16C7891 VA: 0x16C7790
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7850 Offset: 0x16C7951 VA: 0x16C7850
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x16C53E0 Offset: 0x16C54E1 VA: 0x16C53E0
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6520 Offset: 0x16C6621 VA: 0x16C6520
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5560 Offset: 0x16C5661 VA: 0x16C5560
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x16C56E0 Offset: 0x16C57E1 VA: 0x16C56E0
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5880 Offset: 0x16C5981 VA: 0x16C5880
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x16C59E0 Offset: 0x16C5AE1 VA: 0x16C59E0
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5B40 Offset: 0x16C5C41 VA: 0x16C5B40
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C63D0 Offset: 0x16C64D1 VA: 0x16C63D0
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x16C6680 Offset: 0x16C6781 VA: 0x16C6680
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x16AAF90 Offset: 0x16AB091 VA: 0x16AAF90
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x16C5E60 Offset: 0x16C5F61 VA: 0x16C5E60
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C6060 Offset: 0x16C6161 VA: 0x16C6060
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C5CA0 Offset: 0x16C5DA1 VA: 0x16C5CA0
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x16A1540 Offset: 0x16A1641 VA: 0x16A1540
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x16C6270 Offset: 0x16C6371 VA: 0x16C6270
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x16C6850 Offset: 0x16C6951 VA: 0x16C6850
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x16C69B0 Offset: 0x16C6AB1 VA: 0x16C69B0
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B10 Offset: 0x16C6C11 VA: 0x16C6B10
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C10 Offset: 0x16C6D11 VA: 0x16C6C10
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B90 Offset: 0x16C6C91 VA: 0x16C6B90
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C90 Offset: 0x16C6D91 VA: 0x16C6C90
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C7D40 Offset: 0x16C7E41 VA: 0x16C7D40
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x16C7F70 Offset: 0x16C8071 VA: 0x16C7F70
	private static void .cctor() { }
}

public abstract class Expression // TypeDefIndex: 2211
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x16A9430 Offset: 0x16A9531 VA: 0x16A9430
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x16B2A60 Offset: 0x16B2B61 VA: 0x16B2A60
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B31D0 Offset: 0x16B32D1 VA: 0x16B31D0
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x16B3AF0 Offset: 0x16B3BF1 VA: 0x16B3AF0
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B4060 Offset: 0x16B4161 VA: 0x16B4060
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B4330 Offset: 0x16B4431 VA: 0x16B4330
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B2DD0 Offset: 0x16B2ED1 VA: 0x16B2DD0
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x16B4570 Offset: 0x16B4671 VA: 0x16B4570
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x16B39D0 Offset: 0x16B3AD1 VA: 0x16B39D0
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x16B3A40 Offset: 0x16B3B41 VA: 0x16B3A40
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x16B38A0 Offset: 0x16B39A1 VA: 0x16B38A0
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x16B45F0 Offset: 0x16B46F1 VA: 0x16B45F0
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x16B4720 Offset: 0x16B4821 VA: 0x16B4720
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x16B4940 Offset: 0x16B4A41 VA: 0x16B4940
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x16B4A00 Offset: 0x16B4B01 VA: 0x16B4A00
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x16B52D0 Offset: 0x16B53D1 VA: 0x16B52D0
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x16B5130 Offset: 0x16B5231 VA: 0x16B5130
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x16A91E0 Offset: 0x16A92E1 VA: 0x16A91E0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A7870 Offset: 0x16A7971 VA: 0x16A7870
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7960 Offset: 0x16B7A61 VA: 0x16B7960
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A75A0 Offset: 0x16A76A1 VA: 0x16A75A0
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x16B7A80 Offset: 0x16B7B81 VA: 0x16B7A80
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A76E0 Offset: 0x16A77E1 VA: 0x16A76E0
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x16BA810 Offset: 0x16BA911 VA: 0x16BA810
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B7720 Offset: 0x16B7821 VA: 0x16B7720
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B74E0 Offset: 0x16B75E1 VA: 0x16B74E0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7840 Offset: 0x16B7941 VA: 0x16B7840
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7600 Offset: 0x16B7701 VA: 0x16B7600
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16BABA0 Offset: 0x16BACA1 VA: 0x16BABA0
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B67F0 Offset: 0x16B68F1 VA: 0x16B67F0
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B6F90 Offset: 0x16B7091 VA: 0x16B6F90
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B7D90 Offset: 0x16B7E91 VA: 0x16B7D90
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x16BAD80 Offset: 0x16BAE81 VA: 0x16BAD80
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x16B5520 Offset: 0x16B5621 VA: 0x16B5520
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8900 Offset: 0x16B8A01 VA: 0x16B8900
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B3D30 Offset: 0x16B3E31 VA: 0x16B3D30
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x16BA150 Offset: 0x16BA251 VA: 0x16BA150
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5710 Offset: 0x16B5811 VA: 0x16B5710
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B5900 Offset: 0x16B5A01 VA: 0x16B5900
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9F10 Offset: 0x16BA011 VA: 0x16B9F10
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA390 Offset: 0x16BA491 VA: 0x16BA390
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5AF0 Offset: 0x16B5BF1 VA: 0x16B5AF0
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B60C0 Offset: 0x16B61C1 VA: 0x16B60C0
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8D80 Offset: 0x16B8E81 VA: 0x16B8D80
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B62B0 Offset: 0x16B63B1 VA: 0x16B62B0
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9460 Offset: 0x16B9561 VA: 0x16B9460
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5CE0 Offset: 0x16B5DE1 VA: 0x16B5CE0
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B96A0 Offset: 0x16B97A1 VA: 0x16B96A0
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA5D0 Offset: 0x16BA6D1 VA: 0x16BA5D0
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5ED0 Offset: 0x16B5FD1 VA: 0x16B5ED0
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16BAEC0 Offset: 0x16BAFC1 VA: 0x16BAEC0
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x16BAFC0 Offset: 0x16BB0C1 VA: 0x16BAFC0
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x16B86D0 Offset: 0x16B87D1 VA: 0x16B86D0
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9200 Offset: 0x16B9301 VA: 0x16B9200
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B84A0 Offset: 0x16B85A1 VA: 0x16B84A0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9CB0 Offset: 0x16B9DB1 VA: 0x16B9CB0
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6600 Offset: 0x16B6701 VA: 0x16B6600
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8B40 Offset: 0x16B8C41 VA: 0x16B8B40
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6DA0 Offset: 0x16B6EA1 VA: 0x16B6DA0
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B98E0 Offset: 0x16B99E1 VA: 0x16B98E0
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7BA0 Offset: 0x16B7CA1 VA: 0x16B7BA0
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8FC0 Offset: 0x16B90C1 VA: 0x16B8FC0
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B64A0 Offset: 0x16B65A1 VA: 0x16B64A0
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9B20 Offset: 0x16B9C21 VA: 0x16B9B20
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B82E0 Offset: 0x16B83E1 VA: 0x16B82E0
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x16BB100 Offset: 0x16BB201 VA: 0x16BB100
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x16BB260 Offset: 0x16BB361 VA: 0x16BB260
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB580 Offset: 0x16BB681 VA: 0x16BB580
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x16A98F0 Offset: 0x16A99F1 VA: 0x16A98F0
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB310 Offset: 0x16BB411 VA: 0x16BB310
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BC0B0 Offset: 0x16BC1B1 VA: 0x16BC0B0
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x16BC3F0 Offset: 0x16BC4F1 VA: 0x16BC3F0
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x16BB760 Offset: 0x16BB861 VA: 0x16BB760
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x16AD490 Offset: 0x16AD591 VA: 0x16AD490
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x16AB2F0 Offset: 0x16AB3F1 VA: 0x16AB2F0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x16ADDB0 Offset: 0x16ADEB1 VA: 0x16ADDB0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x16BC630 Offset: 0x16BC731 VA: 0x16BC630
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x16AB010 Offset: 0x16AB111 VA: 0x16AB010
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x16BC6F0 Offset: 0x16BC7F1 VA: 0x16BC6F0
	public static DefaultExpression Empty() { }

	// RVA: 0x16A7270 Offset: 0x16A7371 VA: 0x16A7270
	protected void .ctor() { }

	// RVA: 0x16BC7F0 Offset: 0x16BC8F1 VA: 0x16BC7F0 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x16BC8E0 Offset: 0x16BC9E1 VA: 0x16BC8E0 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x16BC9D0 Offset: 0x16BCAD1 VA: 0x16BC9D0 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x16BC9E0 Offset: 0x16BCAE1 VA: 0x16BC9E0 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x16BCA50 Offset: 0x16BCB51 VA: 0x16BCA50 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x16BCBE0 Offset: 0x16BCCE1 VA: 0x16BCBE0 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x16BCAF0 Offset: 0x16BCBF1 VA: 0x16BCAF0
	public Expression ReduceAndCheck() { }

	// RVA: 0x16BCC10 Offset: 0x16BCD11 VA: 0x16BCC10 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BB600 Offset: 0x16BB701 VA: 0x16BB600
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x16B2830 Offset: 0x16B2931 VA: 0x16B2830
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x16BCC20 Offset: 0x16BCD21 VA: 0x16BCC20
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x16BCCE0 Offset: 0x16BCDE1 VA: 0x16BCCE0
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x16BCDC0 Offset: 0x16BCEC1 VA: 0x16BCDC0
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x16BCFA0 Offset: 0x16BD0A1 VA: 0x16BCFA0
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x16A9AB0 Offset: 0x16A9BB1 VA: 0x16A9AB0
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD670 Offset: 0x16BD771 VA: 0x16BD670
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x16BD210 Offset: 0x16BD311 VA: 0x16BD210
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x16BD0F0 Offset: 0x16BD1F1 VA: 0x16BD0F0
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD6F0 Offset: 0x16BD7F1 VA: 0x16BD6F0
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BD7B0 Offset: 0x16BD8B1 VA: 0x16BD7B0
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BDDB0 Offset: 0x16BDEB1 VA: 0x16BDDB0
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16BE0B0 Offset: 0x16BE1B1 VA: 0x16BE0B0
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16A9280 Offset: 0x16A9381 VA: 0x16A9280
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x16BE4B0 Offset: 0x16BE5B1 VA: 0x16BE4B0
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x16BE760 Offset: 0x16BE861 VA: 0x16BE760
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x16BE820 Offset: 0x16BE921 VA: 0x16BE820
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x16BE920 Offset: 0x16BEA21 VA: 0x16BE920
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F970 Offset: 0x255FA71 VA: 0x255F970
	|-Expression.Lambda<DynamicObjectTypeFallbackFormatter.SerializeMethod>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize>
	|-Expression.Lambda<Action<object>>
	|-Expression.Lambda<Action<IBufferWriter<byte>, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Action<Stream, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute>>
	|-Expression.Lambda<Func<object>>
	|-Expression.Lambda<Func<Type>>
	|-Expression.Lambda<Func<IFormatterResolver, IMessagePackFormatter>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, object[]>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, Type>>
	|-Expression.Lambda<Func<Type, FieldInfo>>
	|-Expression.Lambda<Func<Type, PropertyInfo>>
	|-Expression.Lambda<Func<ReadOnlySequence<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, ValueTask<object>>>
	|-Expression.Lambda<Func<object, MessagePackSerializerOptions, CancellationToken, byte[]>>
	|-Expression.Lambda<Func<ReadOnlyMemory<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, object, MessagePackSerializerOptions, CancellationToken, Task>>
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F8D0 Offset: 0x255F9D1 VA: 0x255F8D0
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FA00 Offset: 0x255FB01 VA: 0x255FA00
	|-Expression.Lambda<object>
	*/

	// RVA: 0x16BED70 Offset: 0x16BEE71 VA: 0x16BED70
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x16BEE00 Offset: 0x16BEF01 VA: 0x16BEE00
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x16BEED0 Offset: 0x16BEFD1 VA: 0x16BEED0
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x16BF5C0 Offset: 0x16BF6C1 VA: 0x16BF5C0
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x16BF790 Offset: 0x16BF891 VA: 0x16BF790
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x16AA790 Offset: 0x16AA891 VA: 0x16AA790
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x16BF940 Offset: 0x16BFA41 VA: 0x16BF940
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x16BFBF0 Offset: 0x16BFCF1 VA: 0x16BFBF0
	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor) { }

	// RVA: 0x16BFCF0 Offset: 0x16BFDF1 VA: 0x16BFCF0
	private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1) { }

	// RVA: 0x16BFF40 Offset: 0x16C0041 VA: 0x16BFF40
	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod) { }

	// RVA: 0x16A9710 Offset: 0x16A9811 VA: 0x16A9710
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x16C0040 Offset: 0x16C0141 VA: 0x16C0040
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x16AAB70 Offset: 0x16AAC71 VA: 0x16AAB70
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x16AAD50 Offset: 0x16AAE51 VA: 0x16AAD50
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C0280 Offset: 0x16C0381 VA: 0x16C0280
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16C0510 Offset: 0x16C0611 VA: 0x16C0510
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x16C07F0 Offset: 0x16C08F1 VA: 0x16C07F0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x16C0B30 Offset: 0x16C0C31 VA: 0x16C0B30
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C1590 Offset: 0x16C1691 VA: 0x16C1590
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x16C1720 Offset: 0x16C1821 VA: 0x16C1720
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x16C17A0 Offset: 0x16C18A1 VA: 0x16C17A0
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x16C19B0 Offset: 0x16C1AB1 VA: 0x16C19B0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C1C30 Offset: 0x16C1D31 VA: 0x16C1C30
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16AA940 Offset: 0x16AAA41 VA: 0x16AA940
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x16C0BB0 Offset: 0x16C0CB1 VA: 0x16C0BB0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C01A0 Offset: 0x16C02A1 VA: 0x16C01A0
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x16C21E0 Offset: 0x16C22E1 VA: 0x16C21E0
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x16BE010 Offset: 0x16BE111 VA: 0x16BE010
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x16C2320 Offset: 0x16C2421 VA: 0x16C2320
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x16BE6A0 Offset: 0x16BE7A1 VA: 0x16BE6A0
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x16BE740 Offset: 0x16BE841 VA: 0x16BE740
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x16BE750 Offset: 0x16BE851 VA: 0x16BE750
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x16BD0E0 Offset: 0x16BD1E1 VA: 0x16BD0E0
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x16C1F00 Offset: 0x16C2001 VA: 0x16C1F00
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x16C23F0 Offset: 0x16C24F1 VA: 0x16C23F0
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x16C2330 Offset: 0x16C2431 VA: 0x16C2330
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x16C2640 Offset: 0x16C2741 VA: 0x16C2640
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x16C26C0 Offset: 0x16C27C1 VA: 0x16C26C0
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x16C2AF0 Offset: 0x16C2BF1 VA: 0x16C2AF0
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x16C2D90 Offset: 0x16C2E91 VA: 0x16C2D90
	public static NewExpression New(ConstructorInfo constructor, Expression[] arguments) { }

	// RVA: 0x16C2E10 Offset: 0x16C2F11 VA: 0x16C2E10
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C30D0 Offset: 0x16C31D1 VA: 0x16C30D0
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members) { }

	// RVA: 0x16C3330 Offset: 0x16C3431 VA: 0x16C3330
	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x16C3C60 Offset: 0x16C3D61 VA: 0x16C3C60
	private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType, string paramName, int index) { }

	// RVA: 0x16C3050 Offset: 0x16C3151 VA: 0x16C3050
	private static void ValidateConstructor(ConstructorInfo constructor, string paramName) { }

	// RVA: 0x16C3F10 Offset: 0x16C4011 VA: 0x16C3F10
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x16AA6D0 Offset: 0x16AA7D1 VA: 0x16AA6D0
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x16A9680 Offset: 0x16A9781 VA: 0x16A9680
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x16C3F80 Offset: 0x16C4081 VA: 0x16C3F80
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x16C40C0 Offset: 0x16C41C1 VA: 0x16C40C0
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x16C4140 Offset: 0x16C4241 VA: 0x16C4140
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x16C4320 Offset: 0x16C4421 VA: 0x16C4320
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x16C4D70 Offset: 0x16C4E71 VA: 0x16C4D70
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x16C6D10 Offset: 0x16C6E11 VA: 0x16C6D10
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C6F10 Offset: 0x16C7011 VA: 0x16C6F10
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C72B0 Offset: 0x16C73B1 VA: 0x16C72B0
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x16C76D0 Offset: 0x16C77D1 VA: 0x16C76D0
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7790 Offset: 0x16C7891 VA: 0x16C7790
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7850 Offset: 0x16C7951 VA: 0x16C7850
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x16C53E0 Offset: 0x16C54E1 VA: 0x16C53E0
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6520 Offset: 0x16C6621 VA: 0x16C6520
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5560 Offset: 0x16C5661 VA: 0x16C5560
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x16C56E0 Offset: 0x16C57E1 VA: 0x16C56E0
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5880 Offset: 0x16C5981 VA: 0x16C5880
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x16C59E0 Offset: 0x16C5AE1 VA: 0x16C59E0
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5B40 Offset: 0x16C5C41 VA: 0x16C5B40
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C63D0 Offset: 0x16C64D1 VA: 0x16C63D0
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x16C6680 Offset: 0x16C6781 VA: 0x16C6680
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x16AAF90 Offset: 0x16AB091 VA: 0x16AAF90
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x16C5E60 Offset: 0x16C5F61 VA: 0x16C5E60
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C6060 Offset: 0x16C6161 VA: 0x16C6060
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C5CA0 Offset: 0x16C5DA1 VA: 0x16C5CA0
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x16A1540 Offset: 0x16A1641 VA: 0x16A1540
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x16C6270 Offset: 0x16C6371 VA: 0x16C6270
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x16C6850 Offset: 0x16C6951 VA: 0x16C6850
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x16C69B0 Offset: 0x16C6AB1 VA: 0x16C69B0
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B10 Offset: 0x16C6C11 VA: 0x16C6B10
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C10 Offset: 0x16C6D11 VA: 0x16C6C10
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B90 Offset: 0x16C6C91 VA: 0x16C6B90
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C90 Offset: 0x16C6D91 VA: 0x16C6C90
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C7D40 Offset: 0x16C7E41 VA: 0x16C7D40
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x16C7F70 Offset: 0x16C8071 VA: 0x16C7F70
	private static void .cctor() { }
}

public abstract class Expression // TypeDefIndex: 2211
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x16A9430 Offset: 0x16A9531 VA: 0x16A9430
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x16B2A60 Offset: 0x16B2B61 VA: 0x16B2A60
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B31D0 Offset: 0x16B32D1 VA: 0x16B31D0
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x16B3AF0 Offset: 0x16B3BF1 VA: 0x16B3AF0
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B4060 Offset: 0x16B4161 VA: 0x16B4060
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B4330 Offset: 0x16B4431 VA: 0x16B4330
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B2DD0 Offset: 0x16B2ED1 VA: 0x16B2DD0
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x16B4570 Offset: 0x16B4671 VA: 0x16B4570
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x16B39D0 Offset: 0x16B3AD1 VA: 0x16B39D0
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x16B3A40 Offset: 0x16B3B41 VA: 0x16B3A40
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x16B38A0 Offset: 0x16B39A1 VA: 0x16B38A0
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x16B45F0 Offset: 0x16B46F1 VA: 0x16B45F0
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x16B4720 Offset: 0x16B4821 VA: 0x16B4720
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x16B4940 Offset: 0x16B4A41 VA: 0x16B4940
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x16B4A00 Offset: 0x16B4B01 VA: 0x16B4A00
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x16B52D0 Offset: 0x16B53D1 VA: 0x16B52D0
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x16B5130 Offset: 0x16B5231 VA: 0x16B5130
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x16A91E0 Offset: 0x16A92E1 VA: 0x16A91E0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A7870 Offset: 0x16A7971 VA: 0x16A7870
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7960 Offset: 0x16B7A61 VA: 0x16B7960
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A75A0 Offset: 0x16A76A1 VA: 0x16A75A0
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x16B7A80 Offset: 0x16B7B81 VA: 0x16B7A80
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A76E0 Offset: 0x16A77E1 VA: 0x16A76E0
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x16BA810 Offset: 0x16BA911 VA: 0x16BA810
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B7720 Offset: 0x16B7821 VA: 0x16B7720
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B74E0 Offset: 0x16B75E1 VA: 0x16B74E0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7840 Offset: 0x16B7941 VA: 0x16B7840
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7600 Offset: 0x16B7701 VA: 0x16B7600
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16BABA0 Offset: 0x16BACA1 VA: 0x16BABA0
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B67F0 Offset: 0x16B68F1 VA: 0x16B67F0
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B6F90 Offset: 0x16B7091 VA: 0x16B6F90
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B7D90 Offset: 0x16B7E91 VA: 0x16B7D90
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x16BAD80 Offset: 0x16BAE81 VA: 0x16BAD80
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x16B5520 Offset: 0x16B5621 VA: 0x16B5520
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8900 Offset: 0x16B8A01 VA: 0x16B8900
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B3D30 Offset: 0x16B3E31 VA: 0x16B3D30
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x16BA150 Offset: 0x16BA251 VA: 0x16BA150
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5710 Offset: 0x16B5811 VA: 0x16B5710
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B5900 Offset: 0x16B5A01 VA: 0x16B5900
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9F10 Offset: 0x16BA011 VA: 0x16B9F10
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA390 Offset: 0x16BA491 VA: 0x16BA390
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5AF0 Offset: 0x16B5BF1 VA: 0x16B5AF0
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B60C0 Offset: 0x16B61C1 VA: 0x16B60C0
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8D80 Offset: 0x16B8E81 VA: 0x16B8D80
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B62B0 Offset: 0x16B63B1 VA: 0x16B62B0
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9460 Offset: 0x16B9561 VA: 0x16B9460
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5CE0 Offset: 0x16B5DE1 VA: 0x16B5CE0
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B96A0 Offset: 0x16B97A1 VA: 0x16B96A0
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA5D0 Offset: 0x16BA6D1 VA: 0x16BA5D0
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5ED0 Offset: 0x16B5FD1 VA: 0x16B5ED0
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16BAEC0 Offset: 0x16BAFC1 VA: 0x16BAEC0
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x16BAFC0 Offset: 0x16BB0C1 VA: 0x16BAFC0
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x16B86D0 Offset: 0x16B87D1 VA: 0x16B86D0
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9200 Offset: 0x16B9301 VA: 0x16B9200
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B84A0 Offset: 0x16B85A1 VA: 0x16B84A0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9CB0 Offset: 0x16B9DB1 VA: 0x16B9CB0
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6600 Offset: 0x16B6701 VA: 0x16B6600
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8B40 Offset: 0x16B8C41 VA: 0x16B8B40
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6DA0 Offset: 0x16B6EA1 VA: 0x16B6DA0
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B98E0 Offset: 0x16B99E1 VA: 0x16B98E0
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7BA0 Offset: 0x16B7CA1 VA: 0x16B7BA0
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8FC0 Offset: 0x16B90C1 VA: 0x16B8FC0
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B64A0 Offset: 0x16B65A1 VA: 0x16B64A0
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9B20 Offset: 0x16B9C21 VA: 0x16B9B20
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B82E0 Offset: 0x16B83E1 VA: 0x16B82E0
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x16BB100 Offset: 0x16BB201 VA: 0x16BB100
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x16BB260 Offset: 0x16BB361 VA: 0x16BB260
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB580 Offset: 0x16BB681 VA: 0x16BB580
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x16A98F0 Offset: 0x16A99F1 VA: 0x16A98F0
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB310 Offset: 0x16BB411 VA: 0x16BB310
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BC0B0 Offset: 0x16BC1B1 VA: 0x16BC0B0
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x16BC3F0 Offset: 0x16BC4F1 VA: 0x16BC3F0
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x16BB760 Offset: 0x16BB861 VA: 0x16BB760
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x16AD490 Offset: 0x16AD591 VA: 0x16AD490
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x16AB2F0 Offset: 0x16AB3F1 VA: 0x16AB2F0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x16ADDB0 Offset: 0x16ADEB1 VA: 0x16ADDB0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x16BC630 Offset: 0x16BC731 VA: 0x16BC630
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x16AB010 Offset: 0x16AB111 VA: 0x16AB010
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x16BC6F0 Offset: 0x16BC7F1 VA: 0x16BC6F0
	public static DefaultExpression Empty() { }

	// RVA: 0x16A7270 Offset: 0x16A7371 VA: 0x16A7270
	protected void .ctor() { }

	// RVA: 0x16BC7F0 Offset: 0x16BC8F1 VA: 0x16BC7F0 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x16BC8E0 Offset: 0x16BC9E1 VA: 0x16BC8E0 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x16BC9D0 Offset: 0x16BCAD1 VA: 0x16BC9D0 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x16BC9E0 Offset: 0x16BCAE1 VA: 0x16BC9E0 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x16BCA50 Offset: 0x16BCB51 VA: 0x16BCA50 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x16BCBE0 Offset: 0x16BCCE1 VA: 0x16BCBE0 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x16BCAF0 Offset: 0x16BCBF1 VA: 0x16BCAF0
	public Expression ReduceAndCheck() { }

	// RVA: 0x16BCC10 Offset: 0x16BCD11 VA: 0x16BCC10 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BB600 Offset: 0x16BB701 VA: 0x16BB600
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x16B2830 Offset: 0x16B2931 VA: 0x16B2830
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x16BCC20 Offset: 0x16BCD21 VA: 0x16BCC20
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x16BCCE0 Offset: 0x16BCDE1 VA: 0x16BCCE0
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x16BCDC0 Offset: 0x16BCEC1 VA: 0x16BCDC0
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x16BCFA0 Offset: 0x16BD0A1 VA: 0x16BCFA0
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x16A9AB0 Offset: 0x16A9BB1 VA: 0x16A9AB0
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD670 Offset: 0x16BD771 VA: 0x16BD670
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x16BD210 Offset: 0x16BD311 VA: 0x16BD210
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x16BD0F0 Offset: 0x16BD1F1 VA: 0x16BD0F0
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD6F0 Offset: 0x16BD7F1 VA: 0x16BD6F0
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BD7B0 Offset: 0x16BD8B1 VA: 0x16BD7B0
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BDDB0 Offset: 0x16BDEB1 VA: 0x16BDDB0
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16BE0B0 Offset: 0x16BE1B1 VA: 0x16BE0B0
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16A9280 Offset: 0x16A9381 VA: 0x16A9280
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x16BE4B0 Offset: 0x16BE5B1 VA: 0x16BE4B0
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x16BE760 Offset: 0x16BE861 VA: 0x16BE760
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x16BE820 Offset: 0x16BE921 VA: 0x16BE820
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x16BE920 Offset: 0x16BEA21 VA: 0x16BE920
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F970 Offset: 0x255FA71 VA: 0x255F970
	|-Expression.Lambda<DynamicObjectTypeFallbackFormatter.SerializeMethod>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize>
	|-Expression.Lambda<Action<object>>
	|-Expression.Lambda<Action<IBufferWriter<byte>, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Action<Stream, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute>>
	|-Expression.Lambda<Func<object>>
	|-Expression.Lambda<Func<Type>>
	|-Expression.Lambda<Func<IFormatterResolver, IMessagePackFormatter>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, object[]>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, Type>>
	|-Expression.Lambda<Func<Type, FieldInfo>>
	|-Expression.Lambda<Func<Type, PropertyInfo>>
	|-Expression.Lambda<Func<ReadOnlySequence<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, ValueTask<object>>>
	|-Expression.Lambda<Func<object, MessagePackSerializerOptions, CancellationToken, byte[]>>
	|-Expression.Lambda<Func<ReadOnlyMemory<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, object, MessagePackSerializerOptions, CancellationToken, Task>>
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F8D0 Offset: 0x255F9D1 VA: 0x255F8D0
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FA00 Offset: 0x255FB01 VA: 0x255FA00
	|-Expression.Lambda<object>
	*/

	// RVA: 0x16BED70 Offset: 0x16BEE71 VA: 0x16BED70
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x16BEE00 Offset: 0x16BEF01 VA: 0x16BEE00
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x16BEED0 Offset: 0x16BEFD1 VA: 0x16BEED0
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x16BF5C0 Offset: 0x16BF6C1 VA: 0x16BF5C0
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x16BF790 Offset: 0x16BF891 VA: 0x16BF790
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x16AA790 Offset: 0x16AA891 VA: 0x16AA790
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x16BF940 Offset: 0x16BFA41 VA: 0x16BF940
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x16BFBF0 Offset: 0x16BFCF1 VA: 0x16BFBF0
	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor) { }

	// RVA: 0x16BFCF0 Offset: 0x16BFDF1 VA: 0x16BFCF0
	private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1) { }

	// RVA: 0x16BFF40 Offset: 0x16C0041 VA: 0x16BFF40
	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod) { }

	// RVA: 0x16A9710 Offset: 0x16A9811 VA: 0x16A9710
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x16C0040 Offset: 0x16C0141 VA: 0x16C0040
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x16AAB70 Offset: 0x16AAC71 VA: 0x16AAB70
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x16AAD50 Offset: 0x16AAE51 VA: 0x16AAD50
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C0280 Offset: 0x16C0381 VA: 0x16C0280
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16C0510 Offset: 0x16C0611 VA: 0x16C0510
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x16C07F0 Offset: 0x16C08F1 VA: 0x16C07F0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x16C0B30 Offset: 0x16C0C31 VA: 0x16C0B30
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C1590 Offset: 0x16C1691 VA: 0x16C1590
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x16C1720 Offset: 0x16C1821 VA: 0x16C1720
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x16C17A0 Offset: 0x16C18A1 VA: 0x16C17A0
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x16C19B0 Offset: 0x16C1AB1 VA: 0x16C19B0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C1C30 Offset: 0x16C1D31 VA: 0x16C1C30
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16AA940 Offset: 0x16AAA41 VA: 0x16AA940
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x16C0BB0 Offset: 0x16C0CB1 VA: 0x16C0BB0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C01A0 Offset: 0x16C02A1 VA: 0x16C01A0
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x16C21E0 Offset: 0x16C22E1 VA: 0x16C21E0
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x16BE010 Offset: 0x16BE111 VA: 0x16BE010
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x16C2320 Offset: 0x16C2421 VA: 0x16C2320
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x16BE6A0 Offset: 0x16BE7A1 VA: 0x16BE6A0
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x16BE740 Offset: 0x16BE841 VA: 0x16BE740
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x16BE750 Offset: 0x16BE851 VA: 0x16BE750
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x16BD0E0 Offset: 0x16BD1E1 VA: 0x16BD0E0
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x16C1F00 Offset: 0x16C2001 VA: 0x16C1F00
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x16C23F0 Offset: 0x16C24F1 VA: 0x16C23F0
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x16C2330 Offset: 0x16C2431 VA: 0x16C2330
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x16C2640 Offset: 0x16C2741 VA: 0x16C2640
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x16C26C0 Offset: 0x16C27C1 VA: 0x16C26C0
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x16C2AF0 Offset: 0x16C2BF1 VA: 0x16C2AF0
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x16C2D90 Offset: 0x16C2E91 VA: 0x16C2D90
	public static NewExpression New(ConstructorInfo constructor, Expression[] arguments) { }

	// RVA: 0x16C2E10 Offset: 0x16C2F11 VA: 0x16C2E10
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C30D0 Offset: 0x16C31D1 VA: 0x16C30D0
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members) { }

	// RVA: 0x16C3330 Offset: 0x16C3431 VA: 0x16C3330
	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x16C3C60 Offset: 0x16C3D61 VA: 0x16C3C60
	private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType, string paramName, int index) { }

	// RVA: 0x16C3050 Offset: 0x16C3151 VA: 0x16C3050
	private static void ValidateConstructor(ConstructorInfo constructor, string paramName) { }

	// RVA: 0x16C3F10 Offset: 0x16C4011 VA: 0x16C3F10
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x16AA6D0 Offset: 0x16AA7D1 VA: 0x16AA6D0
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x16A9680 Offset: 0x16A9781 VA: 0x16A9680
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x16C3F80 Offset: 0x16C4081 VA: 0x16C3F80
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x16C40C0 Offset: 0x16C41C1 VA: 0x16C40C0
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x16C4140 Offset: 0x16C4241 VA: 0x16C4140
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x16C4320 Offset: 0x16C4421 VA: 0x16C4320
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x16C4D70 Offset: 0x16C4E71 VA: 0x16C4D70
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x16C6D10 Offset: 0x16C6E11 VA: 0x16C6D10
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C6F10 Offset: 0x16C7011 VA: 0x16C6F10
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C72B0 Offset: 0x16C73B1 VA: 0x16C72B0
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x16C76D0 Offset: 0x16C77D1 VA: 0x16C76D0
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7790 Offset: 0x16C7891 VA: 0x16C7790
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7850 Offset: 0x16C7951 VA: 0x16C7850
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x16C53E0 Offset: 0x16C54E1 VA: 0x16C53E0
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6520 Offset: 0x16C6621 VA: 0x16C6520
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5560 Offset: 0x16C5661 VA: 0x16C5560
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x16C56E0 Offset: 0x16C57E1 VA: 0x16C56E0
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5880 Offset: 0x16C5981 VA: 0x16C5880
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x16C59E0 Offset: 0x16C5AE1 VA: 0x16C59E0
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5B40 Offset: 0x16C5C41 VA: 0x16C5B40
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C63D0 Offset: 0x16C64D1 VA: 0x16C63D0
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x16C6680 Offset: 0x16C6781 VA: 0x16C6680
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x16AAF90 Offset: 0x16AB091 VA: 0x16AAF90
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x16C5E60 Offset: 0x16C5F61 VA: 0x16C5E60
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C6060 Offset: 0x16C6161 VA: 0x16C6060
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C5CA0 Offset: 0x16C5DA1 VA: 0x16C5CA0
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x16A1540 Offset: 0x16A1641 VA: 0x16A1540
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x16C6270 Offset: 0x16C6371 VA: 0x16C6270
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x16C6850 Offset: 0x16C6951 VA: 0x16C6850
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x16C69B0 Offset: 0x16C6AB1 VA: 0x16C69B0
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B10 Offset: 0x16C6C11 VA: 0x16C6B10
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C10 Offset: 0x16C6D11 VA: 0x16C6C10
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B90 Offset: 0x16C6C91 VA: 0x16C6B90
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C90 Offset: 0x16C6D91 VA: 0x16C6C90
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C7D40 Offset: 0x16C7E41 VA: 0x16C7D40
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x16C7F70 Offset: 0x16C8071 VA: 0x16C7F70
	private static void .cctor() { }
}

public abstract class Expression // TypeDefIndex: 2211
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x16A9430 Offset: 0x16A9531 VA: 0x16A9430
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x16B2A60 Offset: 0x16B2B61 VA: 0x16B2A60
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B31D0 Offset: 0x16B32D1 VA: 0x16B31D0
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x16B3AF0 Offset: 0x16B3BF1 VA: 0x16B3AF0
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B4060 Offset: 0x16B4161 VA: 0x16B4060
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B4330 Offset: 0x16B4431 VA: 0x16B4330
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B2DD0 Offset: 0x16B2ED1 VA: 0x16B2DD0
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x16B4570 Offset: 0x16B4671 VA: 0x16B4570
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x16B39D0 Offset: 0x16B3AD1 VA: 0x16B39D0
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x16B3A40 Offset: 0x16B3B41 VA: 0x16B3A40
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x16B38A0 Offset: 0x16B39A1 VA: 0x16B38A0
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x16B45F0 Offset: 0x16B46F1 VA: 0x16B45F0
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x16B4720 Offset: 0x16B4821 VA: 0x16B4720
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x16B4940 Offset: 0x16B4A41 VA: 0x16B4940
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x16B4A00 Offset: 0x16B4B01 VA: 0x16B4A00
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x16B52D0 Offset: 0x16B53D1 VA: 0x16B52D0
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x16B5130 Offset: 0x16B5231 VA: 0x16B5130
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x16A91E0 Offset: 0x16A92E1 VA: 0x16A91E0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A7870 Offset: 0x16A7971 VA: 0x16A7870
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7960 Offset: 0x16B7A61 VA: 0x16B7960
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A75A0 Offset: 0x16A76A1 VA: 0x16A75A0
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x16B7A80 Offset: 0x16B7B81 VA: 0x16B7A80
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A76E0 Offset: 0x16A77E1 VA: 0x16A76E0
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x16BA810 Offset: 0x16BA911 VA: 0x16BA810
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B7720 Offset: 0x16B7821 VA: 0x16B7720
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B74E0 Offset: 0x16B75E1 VA: 0x16B74E0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7840 Offset: 0x16B7941 VA: 0x16B7840
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7600 Offset: 0x16B7701 VA: 0x16B7600
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16BABA0 Offset: 0x16BACA1 VA: 0x16BABA0
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B67F0 Offset: 0x16B68F1 VA: 0x16B67F0
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B6F90 Offset: 0x16B7091 VA: 0x16B6F90
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B7D90 Offset: 0x16B7E91 VA: 0x16B7D90
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x16BAD80 Offset: 0x16BAE81 VA: 0x16BAD80
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x16B5520 Offset: 0x16B5621 VA: 0x16B5520
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8900 Offset: 0x16B8A01 VA: 0x16B8900
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B3D30 Offset: 0x16B3E31 VA: 0x16B3D30
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x16BA150 Offset: 0x16BA251 VA: 0x16BA150
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5710 Offset: 0x16B5811 VA: 0x16B5710
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B5900 Offset: 0x16B5A01 VA: 0x16B5900
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9F10 Offset: 0x16BA011 VA: 0x16B9F10
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA390 Offset: 0x16BA491 VA: 0x16BA390
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5AF0 Offset: 0x16B5BF1 VA: 0x16B5AF0
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B60C0 Offset: 0x16B61C1 VA: 0x16B60C0
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8D80 Offset: 0x16B8E81 VA: 0x16B8D80
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B62B0 Offset: 0x16B63B1 VA: 0x16B62B0
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9460 Offset: 0x16B9561 VA: 0x16B9460
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5CE0 Offset: 0x16B5DE1 VA: 0x16B5CE0
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B96A0 Offset: 0x16B97A1 VA: 0x16B96A0
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA5D0 Offset: 0x16BA6D1 VA: 0x16BA5D0
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5ED0 Offset: 0x16B5FD1 VA: 0x16B5ED0
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16BAEC0 Offset: 0x16BAFC1 VA: 0x16BAEC0
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x16BAFC0 Offset: 0x16BB0C1 VA: 0x16BAFC0
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x16B86D0 Offset: 0x16B87D1 VA: 0x16B86D0
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9200 Offset: 0x16B9301 VA: 0x16B9200
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B84A0 Offset: 0x16B85A1 VA: 0x16B84A0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9CB0 Offset: 0x16B9DB1 VA: 0x16B9CB0
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6600 Offset: 0x16B6701 VA: 0x16B6600
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8B40 Offset: 0x16B8C41 VA: 0x16B8B40
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6DA0 Offset: 0x16B6EA1 VA: 0x16B6DA0
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B98E0 Offset: 0x16B99E1 VA: 0x16B98E0
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7BA0 Offset: 0x16B7CA1 VA: 0x16B7BA0
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8FC0 Offset: 0x16B90C1 VA: 0x16B8FC0
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B64A0 Offset: 0x16B65A1 VA: 0x16B64A0
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9B20 Offset: 0x16B9C21 VA: 0x16B9B20
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B82E0 Offset: 0x16B83E1 VA: 0x16B82E0
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x16BB100 Offset: 0x16BB201 VA: 0x16BB100
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x16BB260 Offset: 0x16BB361 VA: 0x16BB260
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB580 Offset: 0x16BB681 VA: 0x16BB580
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x16A98F0 Offset: 0x16A99F1 VA: 0x16A98F0
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB310 Offset: 0x16BB411 VA: 0x16BB310
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BC0B0 Offset: 0x16BC1B1 VA: 0x16BC0B0
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x16BC3F0 Offset: 0x16BC4F1 VA: 0x16BC3F0
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x16BB760 Offset: 0x16BB861 VA: 0x16BB760
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x16AD490 Offset: 0x16AD591 VA: 0x16AD490
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x16AB2F0 Offset: 0x16AB3F1 VA: 0x16AB2F0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x16ADDB0 Offset: 0x16ADEB1 VA: 0x16ADDB0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x16BC630 Offset: 0x16BC731 VA: 0x16BC630
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x16AB010 Offset: 0x16AB111 VA: 0x16AB010
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x16BC6F0 Offset: 0x16BC7F1 VA: 0x16BC6F0
	public static DefaultExpression Empty() { }

	// RVA: 0x16A7270 Offset: 0x16A7371 VA: 0x16A7270
	protected void .ctor() { }

	// RVA: 0x16BC7F0 Offset: 0x16BC8F1 VA: 0x16BC7F0 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x16BC8E0 Offset: 0x16BC9E1 VA: 0x16BC8E0 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x16BC9D0 Offset: 0x16BCAD1 VA: 0x16BC9D0 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x16BC9E0 Offset: 0x16BCAE1 VA: 0x16BC9E0 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x16BCA50 Offset: 0x16BCB51 VA: 0x16BCA50 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x16BCBE0 Offset: 0x16BCCE1 VA: 0x16BCBE0 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x16BCAF0 Offset: 0x16BCBF1 VA: 0x16BCAF0
	public Expression ReduceAndCheck() { }

	// RVA: 0x16BCC10 Offset: 0x16BCD11 VA: 0x16BCC10 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BB600 Offset: 0x16BB701 VA: 0x16BB600
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x16B2830 Offset: 0x16B2931 VA: 0x16B2830
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x16BCC20 Offset: 0x16BCD21 VA: 0x16BCC20
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x16BCCE0 Offset: 0x16BCDE1 VA: 0x16BCCE0
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x16BCDC0 Offset: 0x16BCEC1 VA: 0x16BCDC0
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x16BCFA0 Offset: 0x16BD0A1 VA: 0x16BCFA0
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x16A9AB0 Offset: 0x16A9BB1 VA: 0x16A9AB0
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD670 Offset: 0x16BD771 VA: 0x16BD670
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x16BD210 Offset: 0x16BD311 VA: 0x16BD210
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x16BD0F0 Offset: 0x16BD1F1 VA: 0x16BD0F0
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD6F0 Offset: 0x16BD7F1 VA: 0x16BD6F0
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BD7B0 Offset: 0x16BD8B1 VA: 0x16BD7B0
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BDDB0 Offset: 0x16BDEB1 VA: 0x16BDDB0
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16BE0B0 Offset: 0x16BE1B1 VA: 0x16BE0B0
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16A9280 Offset: 0x16A9381 VA: 0x16A9280
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x16BE4B0 Offset: 0x16BE5B1 VA: 0x16BE4B0
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x16BE760 Offset: 0x16BE861 VA: 0x16BE760
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x16BE820 Offset: 0x16BE921 VA: 0x16BE820
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x16BE920 Offset: 0x16BEA21 VA: 0x16BE920
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F970 Offset: 0x255FA71 VA: 0x255F970
	|-Expression.Lambda<DynamicObjectTypeFallbackFormatter.SerializeMethod>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize>
	|-Expression.Lambda<Action<object>>
	|-Expression.Lambda<Action<IBufferWriter<byte>, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Action<Stream, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute>>
	|-Expression.Lambda<Func<object>>
	|-Expression.Lambda<Func<Type>>
	|-Expression.Lambda<Func<IFormatterResolver, IMessagePackFormatter>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, object[]>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, Type>>
	|-Expression.Lambda<Func<Type, FieldInfo>>
	|-Expression.Lambda<Func<Type, PropertyInfo>>
	|-Expression.Lambda<Func<ReadOnlySequence<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, ValueTask<object>>>
	|-Expression.Lambda<Func<object, MessagePackSerializerOptions, CancellationToken, byte[]>>
	|-Expression.Lambda<Func<ReadOnlyMemory<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, object, MessagePackSerializerOptions, CancellationToken, Task>>
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F8D0 Offset: 0x255F9D1 VA: 0x255F8D0
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FA00 Offset: 0x255FB01 VA: 0x255FA00
	|-Expression.Lambda<object>
	*/

	// RVA: 0x16BED70 Offset: 0x16BEE71 VA: 0x16BED70
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x16BEE00 Offset: 0x16BEF01 VA: 0x16BEE00
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x16BEED0 Offset: 0x16BEFD1 VA: 0x16BEED0
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x16BF5C0 Offset: 0x16BF6C1 VA: 0x16BF5C0
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x16BF790 Offset: 0x16BF891 VA: 0x16BF790
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x16AA790 Offset: 0x16AA891 VA: 0x16AA790
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x16BF940 Offset: 0x16BFA41 VA: 0x16BF940
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x16BFBF0 Offset: 0x16BFCF1 VA: 0x16BFBF0
	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor) { }

	// RVA: 0x16BFCF0 Offset: 0x16BFDF1 VA: 0x16BFCF0
	private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1) { }

	// RVA: 0x16BFF40 Offset: 0x16C0041 VA: 0x16BFF40
	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod) { }

	// RVA: 0x16A9710 Offset: 0x16A9811 VA: 0x16A9710
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x16C0040 Offset: 0x16C0141 VA: 0x16C0040
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x16AAB70 Offset: 0x16AAC71 VA: 0x16AAB70
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x16AAD50 Offset: 0x16AAE51 VA: 0x16AAD50
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C0280 Offset: 0x16C0381 VA: 0x16C0280
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16C0510 Offset: 0x16C0611 VA: 0x16C0510
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x16C07F0 Offset: 0x16C08F1 VA: 0x16C07F0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x16C0B30 Offset: 0x16C0C31 VA: 0x16C0B30
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C1590 Offset: 0x16C1691 VA: 0x16C1590
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x16C1720 Offset: 0x16C1821 VA: 0x16C1720
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x16C17A0 Offset: 0x16C18A1 VA: 0x16C17A0
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x16C19B0 Offset: 0x16C1AB1 VA: 0x16C19B0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C1C30 Offset: 0x16C1D31 VA: 0x16C1C30
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16AA940 Offset: 0x16AAA41 VA: 0x16AA940
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x16C0BB0 Offset: 0x16C0CB1 VA: 0x16C0BB0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C01A0 Offset: 0x16C02A1 VA: 0x16C01A0
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x16C21E0 Offset: 0x16C22E1 VA: 0x16C21E0
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x16BE010 Offset: 0x16BE111 VA: 0x16BE010
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x16C2320 Offset: 0x16C2421 VA: 0x16C2320
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x16BE6A0 Offset: 0x16BE7A1 VA: 0x16BE6A0
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x16BE740 Offset: 0x16BE841 VA: 0x16BE740
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x16BE750 Offset: 0x16BE851 VA: 0x16BE750
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x16BD0E0 Offset: 0x16BD1E1 VA: 0x16BD0E0
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x16C1F00 Offset: 0x16C2001 VA: 0x16C1F00
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x16C23F0 Offset: 0x16C24F1 VA: 0x16C23F0
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x16C2330 Offset: 0x16C2431 VA: 0x16C2330
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x16C2640 Offset: 0x16C2741 VA: 0x16C2640
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x16C26C0 Offset: 0x16C27C1 VA: 0x16C26C0
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x16C2AF0 Offset: 0x16C2BF1 VA: 0x16C2AF0
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x16C2D90 Offset: 0x16C2E91 VA: 0x16C2D90
	public static NewExpression New(ConstructorInfo constructor, Expression[] arguments) { }

	// RVA: 0x16C2E10 Offset: 0x16C2F11 VA: 0x16C2E10
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C30D0 Offset: 0x16C31D1 VA: 0x16C30D0
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members) { }

	// RVA: 0x16C3330 Offset: 0x16C3431 VA: 0x16C3330
	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x16C3C60 Offset: 0x16C3D61 VA: 0x16C3C60
	private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType, string paramName, int index) { }

	// RVA: 0x16C3050 Offset: 0x16C3151 VA: 0x16C3050
	private static void ValidateConstructor(ConstructorInfo constructor, string paramName) { }

	// RVA: 0x16C3F10 Offset: 0x16C4011 VA: 0x16C3F10
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x16AA6D0 Offset: 0x16AA7D1 VA: 0x16AA6D0
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x16A9680 Offset: 0x16A9781 VA: 0x16A9680
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x16C3F80 Offset: 0x16C4081 VA: 0x16C3F80
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x16C40C0 Offset: 0x16C41C1 VA: 0x16C40C0
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x16C4140 Offset: 0x16C4241 VA: 0x16C4140
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x16C4320 Offset: 0x16C4421 VA: 0x16C4320
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x16C4D70 Offset: 0x16C4E71 VA: 0x16C4D70
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x16C6D10 Offset: 0x16C6E11 VA: 0x16C6D10
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C6F10 Offset: 0x16C7011 VA: 0x16C6F10
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C72B0 Offset: 0x16C73B1 VA: 0x16C72B0
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x16C76D0 Offset: 0x16C77D1 VA: 0x16C76D0
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7790 Offset: 0x16C7891 VA: 0x16C7790
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7850 Offset: 0x16C7951 VA: 0x16C7850
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x16C53E0 Offset: 0x16C54E1 VA: 0x16C53E0
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6520 Offset: 0x16C6621 VA: 0x16C6520
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5560 Offset: 0x16C5661 VA: 0x16C5560
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x16C56E0 Offset: 0x16C57E1 VA: 0x16C56E0
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5880 Offset: 0x16C5981 VA: 0x16C5880
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x16C59E0 Offset: 0x16C5AE1 VA: 0x16C59E0
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5B40 Offset: 0x16C5C41 VA: 0x16C5B40
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C63D0 Offset: 0x16C64D1 VA: 0x16C63D0
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x16C6680 Offset: 0x16C6781 VA: 0x16C6680
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x16AAF90 Offset: 0x16AB091 VA: 0x16AAF90
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x16C5E60 Offset: 0x16C5F61 VA: 0x16C5E60
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C6060 Offset: 0x16C6161 VA: 0x16C6060
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C5CA0 Offset: 0x16C5DA1 VA: 0x16C5CA0
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x16A1540 Offset: 0x16A1641 VA: 0x16A1540
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x16C6270 Offset: 0x16C6371 VA: 0x16C6270
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x16C6850 Offset: 0x16C6951 VA: 0x16C6850
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x16C69B0 Offset: 0x16C6AB1 VA: 0x16C69B0
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B10 Offset: 0x16C6C11 VA: 0x16C6B10
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C10 Offset: 0x16C6D11 VA: 0x16C6C10
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B90 Offset: 0x16C6C91 VA: 0x16C6B90
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C90 Offset: 0x16C6D91 VA: 0x16C6C90
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C7D40 Offset: 0x16C7E41 VA: 0x16C7D40
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x16C7F70 Offset: 0x16C8071 VA: 0x16C7F70
	private static void .cctor() { }
}

public abstract class Expression // TypeDefIndex: 2211
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x16A9430 Offset: 0x16A9531 VA: 0x16A9430
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x16B2A60 Offset: 0x16B2B61 VA: 0x16B2A60
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B31D0 Offset: 0x16B32D1 VA: 0x16B31D0
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x16B3AF0 Offset: 0x16B3BF1 VA: 0x16B3AF0
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B4060 Offset: 0x16B4161 VA: 0x16B4060
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B4330 Offset: 0x16B4431 VA: 0x16B4330
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x16B2DD0 Offset: 0x16B2ED1 VA: 0x16B2DD0
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x16B4570 Offset: 0x16B4671 VA: 0x16B4570
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x16B39D0 Offset: 0x16B3AD1 VA: 0x16B39D0
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x16B3A40 Offset: 0x16B3B41 VA: 0x16B3A40
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x16B38A0 Offset: 0x16B39A1 VA: 0x16B38A0
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x16B45F0 Offset: 0x16B46F1 VA: 0x16B45F0
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x16B4720 Offset: 0x16B4821 VA: 0x16B4720
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x16B4940 Offset: 0x16B4A41 VA: 0x16B4940
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x16B4A00 Offset: 0x16B4B01 VA: 0x16B4A00
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x16B52D0 Offset: 0x16B53D1 VA: 0x16B52D0
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x16B5130 Offset: 0x16B5231 VA: 0x16B5130
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x16A91E0 Offset: 0x16A92E1 VA: 0x16A91E0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A7870 Offset: 0x16A7971 VA: 0x16A7870
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7960 Offset: 0x16B7A61 VA: 0x16B7960
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A75A0 Offset: 0x16A76A1 VA: 0x16A75A0
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x16B7A80 Offset: 0x16B7B81 VA: 0x16B7A80
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16A76E0 Offset: 0x16A77E1 VA: 0x16A76E0
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x16BA810 Offset: 0x16BA911 VA: 0x16BA810
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B7720 Offset: 0x16B7821 VA: 0x16B7720
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B74E0 Offset: 0x16B75E1 VA: 0x16B74E0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7840 Offset: 0x16B7941 VA: 0x16B7840
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16B7600 Offset: 0x16B7701 VA: 0x16B7600
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x16BABA0 Offset: 0x16BACA1 VA: 0x16BABA0
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x16B67F0 Offset: 0x16B68F1 VA: 0x16B67F0
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B6F90 Offset: 0x16B7091 VA: 0x16B6F90
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B7D90 Offset: 0x16B7E91 VA: 0x16B7D90
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x16BAD80 Offset: 0x16BAE81 VA: 0x16BAD80
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x16B5520 Offset: 0x16B5621 VA: 0x16B5520
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8900 Offset: 0x16B8A01 VA: 0x16B8900
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B3D30 Offset: 0x16B3E31 VA: 0x16B3D30
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x16BA150 Offset: 0x16BA251 VA: 0x16BA150
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5710 Offset: 0x16B5811 VA: 0x16B5710
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B5900 Offset: 0x16B5A01 VA: 0x16B5900
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9F10 Offset: 0x16BA011 VA: 0x16B9F10
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA390 Offset: 0x16BA491 VA: 0x16BA390
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5AF0 Offset: 0x16B5BF1 VA: 0x16B5AF0
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B60C0 Offset: 0x16B61C1 VA: 0x16B60C0
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8D80 Offset: 0x16B8E81 VA: 0x16B8D80
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B62B0 Offset: 0x16B63B1 VA: 0x16B62B0
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9460 Offset: 0x16B9561 VA: 0x16B9460
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5CE0 Offset: 0x16B5DE1 VA: 0x16B5CE0
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B96A0 Offset: 0x16B97A1 VA: 0x16B96A0
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16BA5D0 Offset: 0x16BA6D1 VA: 0x16BA5D0
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B5ED0 Offset: 0x16B5FD1 VA: 0x16B5ED0
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16BAEC0 Offset: 0x16BAFC1 VA: 0x16BAEC0
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x16BAFC0 Offset: 0x16BB0C1 VA: 0x16BAFC0
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x16B86D0 Offset: 0x16B87D1 VA: 0x16B86D0
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9200 Offset: 0x16B9301 VA: 0x16B9200
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B84A0 Offset: 0x16B85A1 VA: 0x16B84A0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9CB0 Offset: 0x16B9DB1 VA: 0x16B9CB0
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6600 Offset: 0x16B6701 VA: 0x16B6600
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8B40 Offset: 0x16B8C41 VA: 0x16B8B40
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B6DA0 Offset: 0x16B6EA1 VA: 0x16B6DA0
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B98E0 Offset: 0x16B99E1 VA: 0x16B98E0
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B7BA0 Offset: 0x16B7CA1 VA: 0x16B7BA0
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B8FC0 Offset: 0x16B90C1 VA: 0x16B8FC0
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B64A0 Offset: 0x16B65A1 VA: 0x16B64A0
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x16B9B20 Offset: 0x16B9C21 VA: 0x16B9B20
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x16B82E0 Offset: 0x16B83E1 VA: 0x16B82E0
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x16BB100 Offset: 0x16BB201 VA: 0x16BB100
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x16BB260 Offset: 0x16BB361 VA: 0x16BB260
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB580 Offset: 0x16BB681 VA: 0x16BB580
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x16A98F0 Offset: 0x16A99F1 VA: 0x16A98F0
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BB310 Offset: 0x16BB411 VA: 0x16BB310
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x16BC0B0 Offset: 0x16BC1B1 VA: 0x16BC0B0
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x16BC3F0 Offset: 0x16BC4F1 VA: 0x16BC3F0
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x16BB760 Offset: 0x16BB861 VA: 0x16BB760
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x16AD490 Offset: 0x16AD591 VA: 0x16AD490
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x16AB2F0 Offset: 0x16AB3F1 VA: 0x16AB2F0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x16ADDB0 Offset: 0x16ADEB1 VA: 0x16ADDB0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x16BC630 Offset: 0x16BC731 VA: 0x16BC630
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x16AB010 Offset: 0x16AB111 VA: 0x16AB010
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x16BC6F0 Offset: 0x16BC7F1 VA: 0x16BC6F0
	public static DefaultExpression Empty() { }

	// RVA: 0x16A7270 Offset: 0x16A7371 VA: 0x16A7270
	protected void .ctor() { }

	// RVA: 0x16BC7F0 Offset: 0x16BC8F1 VA: 0x16BC7F0 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x16BC8E0 Offset: 0x16BC9E1 VA: 0x16BC8E0 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x16BC9D0 Offset: 0x16BCAD1 VA: 0x16BC9D0 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x16BC9E0 Offset: 0x16BCAE1 VA: 0x16BC9E0 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x16BCA50 Offset: 0x16BCB51 VA: 0x16BCA50 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x16BCBE0 Offset: 0x16BCCE1 VA: 0x16BCBE0 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x16BCAF0 Offset: 0x16BCBF1 VA: 0x16BCAF0
	public Expression ReduceAndCheck() { }

	// RVA: 0x16BCC10 Offset: 0x16BCD11 VA: 0x16BCC10 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BB600 Offset: 0x16BB701 VA: 0x16BB600
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x16B2830 Offset: 0x16B2931 VA: 0x16B2830
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x16BCC20 Offset: 0x16BCD21 VA: 0x16BCC20
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x16BCCE0 Offset: 0x16BCDE1 VA: 0x16BCCE0
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x16BCDC0 Offset: 0x16BCEC1 VA: 0x16BCDC0
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x16BCFA0 Offset: 0x16BD0A1 VA: 0x16BCFA0
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x16A9AB0 Offset: 0x16A9BB1 VA: 0x16A9AB0
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD670 Offset: 0x16BD771 VA: 0x16BD670
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x16BD210 Offset: 0x16BD311 VA: 0x16BD210
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x16BD0F0 Offset: 0x16BD1F1 VA: 0x16BD0F0
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x16BD6F0 Offset: 0x16BD7F1 VA: 0x16BD6F0
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BD7B0 Offset: 0x16BD8B1 VA: 0x16BD7B0
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x16BDDB0 Offset: 0x16BDEB1 VA: 0x16BDDB0
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16BE0B0 Offset: 0x16BE1B1 VA: 0x16BE0B0
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x16A9280 Offset: 0x16A9381 VA: 0x16A9280
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x16BE4B0 Offset: 0x16BE5B1 VA: 0x16BE4B0
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x16BE760 Offset: 0x16BE861 VA: 0x16BE760
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x16BE820 Offset: 0x16BE921 VA: 0x16BE820
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x16BE920 Offset: 0x16BEA21 VA: 0x16BE920
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F970 Offset: 0x255FA71 VA: 0x255F970
	|-Expression.Lambda<DynamicObjectTypeFallbackFormatter.SerializeMethod>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize>
	|-Expression.Lambda<MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize>
	|-Expression.Lambda<Action<object>>
	|-Expression.Lambda<Action<IBufferWriter<byte>, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Action<Stream, object, MessagePackSerializerOptions, CancellationToken>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute>>
	|-Expression.Lambda<Func<object>>
	|-Expression.Lambda<Func<Type>>
	|-Expression.Lambda<Func<IFormatterResolver, IMessagePackFormatter>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, object[]>>
	|-Expression.Lambda<Func<MessagePackFormatterAttribute, Type>>
	|-Expression.Lambda<Func<Type, FieldInfo>>
	|-Expression.Lambda<Func<Type, PropertyInfo>>
	|-Expression.Lambda<Func<ReadOnlySequence<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, MessagePackSerializerOptions, CancellationToken, ValueTask<object>>>
	|-Expression.Lambda<Func<object, MessagePackSerializerOptions, CancellationToken, byte[]>>
	|-Expression.Lambda<Func<ReadOnlyMemory<byte>, MessagePackSerializerOptions, CancellationToken, object>>
	|-Expression.Lambda<Func<Stream, object, MessagePackSerializerOptions, CancellationToken, Task>>
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F8D0 Offset: 0x255F9D1 VA: 0x255F8D0
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FA00 Offset: 0x255FB01 VA: 0x255FA00
	|-Expression.Lambda<object>
	*/

	// RVA: 0x16BED70 Offset: 0x16BEE71 VA: 0x16BED70
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x16BEE00 Offset: 0x16BEF01 VA: 0x16BEE00
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x16BEED0 Offset: 0x16BEFD1 VA: 0x16BEED0
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x16BF5C0 Offset: 0x16BF6C1 VA: 0x16BF5C0
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x16BF790 Offset: 0x16BF891 VA: 0x16BF790
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x16AA790 Offset: 0x16AA891 VA: 0x16AA790
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x16BF940 Offset: 0x16BFA41 VA: 0x16BF940
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x16BFBF0 Offset: 0x16BFCF1 VA: 0x16BFBF0
	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor) { }

	// RVA: 0x16BFCF0 Offset: 0x16BFDF1 VA: 0x16BFCF0
	private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1) { }

	// RVA: 0x16BFF40 Offset: 0x16C0041 VA: 0x16BFF40
	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod) { }

	// RVA: 0x16A9710 Offset: 0x16A9811 VA: 0x16A9710
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x16C0040 Offset: 0x16C0141 VA: 0x16C0040
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x16AAB70 Offset: 0x16AAC71 VA: 0x16AAB70
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x16AAD50 Offset: 0x16AAE51 VA: 0x16AAD50
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C0280 Offset: 0x16C0381 VA: 0x16C0280
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16C0510 Offset: 0x16C0611 VA: 0x16C0510
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x16C07F0 Offset: 0x16C08F1 VA: 0x16C07F0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x16C0B30 Offset: 0x16C0C31 VA: 0x16C0B30
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C1590 Offset: 0x16C1691 VA: 0x16C1590
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x16C1720 Offset: 0x16C1821 VA: 0x16C1720
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x16C17A0 Offset: 0x16C18A1 VA: 0x16C17A0
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x16C19B0 Offset: 0x16C1AB1 VA: 0x16C19B0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x16C1C30 Offset: 0x16C1D31 VA: 0x16C1C30
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x16AA940 Offset: 0x16AAA41 VA: 0x16AA940
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x16C0BB0 Offset: 0x16C0CB1 VA: 0x16C0BB0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C01A0 Offset: 0x16C02A1 VA: 0x16C01A0
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x16C21E0 Offset: 0x16C22E1 VA: 0x16C21E0
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x16BE010 Offset: 0x16BE111 VA: 0x16BE010
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x16C2320 Offset: 0x16C2421 VA: 0x16C2320
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x16BE6A0 Offset: 0x16BE7A1 VA: 0x16BE6A0
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x16BE740 Offset: 0x16BE841 VA: 0x16BE740
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x16BE750 Offset: 0x16BE851 VA: 0x16BE750
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x16BD0E0 Offset: 0x16BD1E1 VA: 0x16BD0E0
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x16C1F00 Offset: 0x16C2001 VA: 0x16C1F00
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x16C23F0 Offset: 0x16C24F1 VA: 0x16C23F0
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x16C2330 Offset: 0x16C2431 VA: 0x16C2330
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x16C2640 Offset: 0x16C2741 VA: 0x16C2640
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x16C26C0 Offset: 0x16C27C1 VA: 0x16C26C0
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x16C2AF0 Offset: 0x16C2BF1 VA: 0x16C2AF0
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x16C2D90 Offset: 0x16C2E91 VA: 0x16C2D90
	public static NewExpression New(ConstructorInfo constructor, Expression[] arguments) { }

	// RVA: 0x16C2E10 Offset: 0x16C2F11 VA: 0x16C2E10
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments) { }

	// RVA: 0x16C30D0 Offset: 0x16C31D1 VA: 0x16C30D0
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members) { }

	// RVA: 0x16C3330 Offset: 0x16C3431 VA: 0x16C3330
	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x16C3C60 Offset: 0x16C3D61 VA: 0x16C3C60
	private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType, string paramName, int index) { }

	// RVA: 0x16C3050 Offset: 0x16C3151 VA: 0x16C3050
	private static void ValidateConstructor(ConstructorInfo constructor, string paramName) { }

	// RVA: 0x16C3F10 Offset: 0x16C4011 VA: 0x16C3F10
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x16AA6D0 Offset: 0x16AA7D1 VA: 0x16AA6D0
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x16A9680 Offset: 0x16A9781 VA: 0x16A9680
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x16C3F80 Offset: 0x16C4081 VA: 0x16C3F80
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x16C40C0 Offset: 0x16C41C1 VA: 0x16C40C0
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x16C4140 Offset: 0x16C4241 VA: 0x16C4140
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x16C4320 Offset: 0x16C4421 VA: 0x16C4320
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x16C4D70 Offset: 0x16C4E71 VA: 0x16C4D70
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x16C6D10 Offset: 0x16C6E11 VA: 0x16C6D10
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C6F10 Offset: 0x16C7011 VA: 0x16C6F10
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x16C72B0 Offset: 0x16C73B1 VA: 0x16C72B0
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x16C76D0 Offset: 0x16C77D1 VA: 0x16C76D0
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7790 Offset: 0x16C7891 VA: 0x16C7790
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x16C7850 Offset: 0x16C7951 VA: 0x16C7850
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x16C53E0 Offset: 0x16C54E1 VA: 0x16C53E0
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6520 Offset: 0x16C6621 VA: 0x16C6520
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5560 Offset: 0x16C5661 VA: 0x16C5560
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x16C56E0 Offset: 0x16C57E1 VA: 0x16C56E0
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5880 Offset: 0x16C5981 VA: 0x16C5880
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x16C59E0 Offset: 0x16C5AE1 VA: 0x16C59E0
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x16C5B40 Offset: 0x16C5C41 VA: 0x16C5B40
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C63D0 Offset: 0x16C64D1 VA: 0x16C63D0
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x16C6680 Offset: 0x16C6781 VA: 0x16C6680
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x16AAF90 Offset: 0x16AB091 VA: 0x16AAF90
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x16C5E60 Offset: 0x16C5F61 VA: 0x16C5E60
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C6060 Offset: 0x16C6161 VA: 0x16C6060
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x16C5CA0 Offset: 0x16C5DA1 VA: 0x16C5CA0
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x16A1540 Offset: 0x16A1641 VA: 0x16A1540
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x16C6270 Offset: 0x16C6371 VA: 0x16C6270
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x16C6850 Offset: 0x16C6951 VA: 0x16C6850
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x16C69B0 Offset: 0x16C6AB1 VA: 0x16C69B0
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B10 Offset: 0x16C6C11 VA: 0x16C6B10
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C10 Offset: 0x16C6D11 VA: 0x16C6C10
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6B90 Offset: 0x16C6C91 VA: 0x16C6B90
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C6C90 Offset: 0x16C6D91 VA: 0x16C6C90
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x16C7D40 Offset: 0x16C7E41 VA: 0x16C7D40
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x16C7F70 Offset: 0x16C8071 VA: 0x16C7F70
	private static void .cctor() { }
}

