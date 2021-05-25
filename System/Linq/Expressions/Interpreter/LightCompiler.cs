internal sealed class LightCompiler // TypeDefIndex: 2533
{
	// Fields
	private readonly InstructionList _instructions; // 0x10
	private readonly LocalVariables _locals; // 0x18
	private readonly List<DebugInfo> _debugInfos; // 0x20
	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; // 0x28
	private LabelScopeInfo _labelBlock; // 0x30
	private readonly Stack<ParameterExpression> _exceptionForRethrowStack; // 0x38
	private readonly LightCompiler _parent; // 0x40
	private readonly StackGuard _guard; // 0x48
	private static readonly LocalDefinition[] s_emptyLocals; // 0x0

	// Properties
	public InstructionList Instructions { get; }

	// Methods

	// RVA: 0x17C20F0 Offset: 0x17C21F1 VA: 0x17C20F0
	public void .ctor() { }

	// RVA: 0x17C2300 Offset: 0x17C2401 VA: 0x17C2300
	private void .ctor(LightCompiler parent) { }

	// RVA: 0x17C2330 Offset: 0x17C2431 VA: 0x17C2330
	public InstructionList get_Instructions() { }

	// RVA: 0x17C2340 Offset: 0x17C2441 VA: 0x17C2340
	public LightDelegateCreator CompileTop(LambdaExpression node) { }

	// RVA: 0x17C2610 Offset: 0x17C2711 VA: 0x17C2610
	private Interpreter MakeInterpreter(string lambdaName) { }

	// RVA: 0x17C2940 Offset: 0x17C2A41 VA: 0x17C2940
	private void CompileConstantExpression(Expression expr) { }

	// RVA: 0x17C2A00 Offset: 0x17C2B01 VA: 0x17C2A00
	private void CompileDefaultExpression(Expression expr) { }

	// RVA: 0x17C2A40 Offset: 0x17C2B41 VA: 0x17C2A40
	private void CompileDefaultExpression(Type type) { }

	// RVA: 0x17C2B90 Offset: 0x17C2C91 VA: 0x17C2B90
	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) { }

	// RVA: 0x17C2CD0 Offset: 0x17C2DD1 VA: 0x17C2CD0
	private LocalVariable ResolveLocal(ParameterExpression variable) { }

	// RVA: 0x17C2D40 Offset: 0x17C2E41 VA: 0x17C2D40
	private void CompileGetVariable(ParameterExpression variable) { }

	// RVA: 0x17C2EC0 Offset: 0x17C2FC1 VA: 0x17C2EC0
	private void EmitCopyValueType(Type valueType) { }

	// RVA: 0x17C2D90 Offset: 0x17C2E91 VA: 0x17C2D90
	private void LoadLocalNoValueTypeCopy(ParameterExpression variable) { }

	// RVA: 0x17C2FA0 Offset: 0x17C30A1 VA: 0x17C2FA0
	private bool MaybeMutableValueType(Type type) { }

	// RVA: 0x17C3030 Offset: 0x17C3131 VA: 0x17C3030
	private void CompileGetBoxedVariable(ParameterExpression variable) { }

	// RVA: 0x17C30E0 Offset: 0x17C31E1 VA: 0x17C30E0
	private void CompileSetVariable(ParameterExpression variable, bool isVoid) { }

	// RVA: 0x17C32D0 Offset: 0x17C33D1 VA: 0x17C32D0
	private void CompileParameterExpression(Expression expr) { }

	// RVA: 0x17C3390 Offset: 0x17C3491 VA: 0x17C3390
	private void CompileBlockExpression(Expression expr, bool asVoid) { }

	// RVA: 0x17C3510 Offset: 0x17C3611 VA: 0x17C3510
	private LocalDefinition[] CompileBlockStart(BlockExpression node) { }

	// RVA: 0x17C3B30 Offset: 0x17C3C31 VA: 0x17C3B30
	private void CompileBlockEnd(LocalDefinition[] locals) { }

	// RVA: 0x17C3E10 Offset: 0x17C3F11 VA: 0x17C3E10
	private void CompileIndexExpression(Expression expr) { }

	// RVA: 0x17C3F40 Offset: 0x17C4041 VA: 0x17C3F40
	private void EmitIndexGet(IndexExpression index) { }

	// RVA: 0x17C40E0 Offset: 0x17C41E1 VA: 0x17C40E0
	private void CompileIndexAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x17C4560 Offset: 0x17C4661 VA: 0x17C4560
	private void CompileMemberAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x17C4630 Offset: 0x17C4731 VA: 0x17C4630
	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) { }

	// RVA: 0x17C4AF0 Offset: 0x17C4BF1 VA: 0x17C4AF0
	private void CompileVariableAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x17C4BE0 Offset: 0x17C4CE1 VA: 0x17C4BE0
	private void CompileAssignBinaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x17C4D30 Offset: 0x17C4E31 VA: 0x17C4D30
	private void CompileBinaryExpression(Expression expr) { }

	// RVA: 0x17C6130 Offset: 0x17C6231 VA: 0x17C6130
	private void CompileEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x17C6210 Offset: 0x17C6311 VA: 0x17C6210
	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x17C62F0 Offset: 0x17C63F1 VA: 0x17C62F0
	private void CompileComparison(BinaryExpression node) { }

	// RVA: 0x17C5EC0 Offset: 0x17C5FC1 VA: 0x17C5EC0
	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) { }

	// RVA: 0x17C6510 Offset: 0x17C6611 VA: 0x17C6510
	private void CompileConvertUnaryExpression(Expression expr) { }

	// RVA: 0x17C6B30 Offset: 0x17C6C31 VA: 0x17C6B30
	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull) { }

	// RVA: 0x17C7120 Offset: 0x17C7221 VA: 0x17C7120
	private void CompileNotExpression(UnaryExpression node) { }

	// RVA: 0x17C71C0 Offset: 0x17C72C1 VA: 0x17C71C0
	private void CompileUnaryExpression(Expression expr) { }

	// RVA: 0x17C7630 Offset: 0x17C7731 VA: 0x17C7630
	private void EmitUnaryMethodCall(UnaryExpression node) { }

	// RVA: 0x17C78F0 Offset: 0x17C79F1 VA: 0x17C78F0
	private void EmitUnaryBoolCheck(UnaryExpression node) { }

	// RVA: 0x17C7B10 Offset: 0x17C7C11 VA: 0x17C7B10
	private void CompileAndAlsoBinaryExpression(Expression expr) { }

	// RVA: 0x17C7D70 Offset: 0x17C7E71 VA: 0x17C7D70
	private void CompileOrElseBinaryExpression(Expression expr) { }

	// RVA: 0x17C7BB0 Offset: 0x17C7CB1 VA: 0x17C7BB0
	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) { }

	// RVA: 0x17C7E10 Offset: 0x17C7F11 VA: 0x17C7E10
	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x17C80C0 Offset: 0x17C81C1 VA: 0x17C80C0
	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) { }

	// RVA: 0x17C8930 Offset: 0x17C8A31 VA: 0x17C8930
	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x17C8A80 Offset: 0x17C8B81 VA: 0x17C8A80
	private void CompileConditionalExpression(Expression expr, bool asVoid) { }

	// RVA: 0x17C8CC0 Offset: 0x17C8DC1 VA: 0x17C8CC0
	private void CompileLoopExpression(Expression expr) { }

	// RVA: 0x17C90E0 Offset: 0x17C91E1 VA: 0x17C90E0
	private void CompileSwitchExpression(Expression expr) { }

	// RVA: -1 Offset: -1
	private void CompileIntSwitchExpression<T>(SwitchExpression node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B72D0 Offset: 0x24B73D1 VA: 0x24B72D0
	|-LightCompiler.CompileIntSwitchExpression<int>
	|
	|-RVA: 0x24B78E0 Offset: 0x24B79E1 VA: 0x24B78E0
	|-LightCompiler.CompileIntSwitchExpression<object>
	*/

	// RVA: 0x17C9B50 Offset: 0x17C9C51 VA: 0x17C9B50
	private void CompileStringSwitchExpression(SwitchExpression node) { }

	// RVA: 0x17CA2C0 Offset: 0x17CA3C1 VA: 0x17CA2C0
	private void CompileLabelExpression(Expression expr) { }

	// RVA: 0x17CA580 Offset: 0x17CA681 VA: 0x17CA580
	private void CompileGotoExpression(Expression expr) { }

	// RVA: 0x17C8F30 Offset: 0x17C9031 VA: 0x17C8F30
	private void PushLabelBlock(LabelScopeKind type) { }

	// RVA: 0x17C90C0 Offset: 0x17C91C1 VA: 0x17C90C0
	private void PopLabelBlock(LabelScopeKind kind) { }

	// RVA: 0x17CA840 Offset: 0x17CA941 VA: 0x17CA840
	private LabelInfo EnsureLabel(LabelTarget node) { }

	// RVA: 0x17CA7B0 Offset: 0x17CA8B1 VA: 0x17CA7B0
	private LabelInfo ReferenceLabel(LabelTarget node) { }

	// RVA: 0x17C8FC0 Offset: 0x17C90C1 VA: 0x17C8FC0
	private LabelInfo DefineLabel(LabelTarget node) { }

	// RVA: 0x17CA980 Offset: 0x17CAA81 VA: 0x17CA980
	private bool TryPushLabelBlock(Expression node) { }

	// RVA: 0x17CAF90 Offset: 0x17CB091 VA: 0x17CAF90
	private void DefineBlockLabels(Expression node) { }

	// RVA: 0x17CB0C0 Offset: 0x17CB1C1 VA: 0x17CB0C0
	private void CheckRethrow() { }

	// RVA: 0x17CB140 Offset: 0x17CB241 VA: 0x17CB140
	private void CompileThrowUnaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x17CB3F0 Offset: 0x17CB4F1 VA: 0x17CB3F0
	private void CompileTryExpression(Expression expr) { }

	// RVA: 0x17CC730 Offset: 0x17CC831 VA: 0x17CC730
	private void CompileTryFaultExpression(TryExpression expr) { }

	// RVA: 0x17CCB00 Offset: 0x17CCC01 VA: 0x17CCB00
	private void CompileMethodCallExpression(Expression expr) { }

	// RVA: 0x17CCBB0 Offset: 0x17CCCB1 VA: 0x17CCBB0
	private void CompileMethodCallExpression(Expression object, MethodInfo method, IArgumentProvider arguments) { }

	// RVA: 0x17CDBD0 Offset: 0x17CDCD1 VA: 0x17CDBD0
	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) { }

	// RVA: 0x17C3F30 Offset: 0x17C4031 VA: 0x17C3F30
	private void EmitThisForMethodCall(Expression node) { }

	// RVA: 0x17CDEB0 Offset: 0x17CDFB1 VA: 0x17CDEB0
	private static bool ShouldWritebackNode(Expression node) { }

	// RVA: 0x17CD0A0 Offset: 0x17CD1A1 VA: 0x17CD0A0
	private ByRefUpdater CompileAddress(Expression node, int index) { }

	// RVA: 0x17CE050 Offset: 0x17CE151 VA: 0x17CE050
	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) { }

	// RVA: 0x17CE620 Offset: 0x17CE721 VA: 0x17CE620
	private void CompileNewExpression(Expression expr) { }

	// RVA: 0x17CEA20 Offset: 0x17CEB21 VA: 0x17CEA20
	private void CompileMemberExpression(Expression expr) { }

	// RVA: 0x17CEAD0 Offset: 0x17CEBD1 VA: 0x17CEAD0
	private void CompileMember(Expression from, MemberInfo member, bool forBinding) { }

	// RVA: 0x17CEE80 Offset: 0x17CEF81 VA: 0x17CEE80
	private void CompileNewArrayExpression(Expression expr) { }

	// RVA: 0x17CF290 Offset: 0x17CF391 VA: 0x17CF290
	private void CompileDebugInfoExpression(Expression expr) { }

	// RVA: 0x17CF400 Offset: 0x17CF501 VA: 0x17CF400
	private void CompileRuntimeVariablesExpression(Expression expr) { }

	// RVA: 0x17CF6E0 Offset: 0x17CF7E1 VA: 0x17CF6E0
	private void CompileLambdaExpression(Expression expr) { }

	// RVA: 0x17CF8F0 Offset: 0x17CF9F1 VA: 0x17CF8F0
	private void CompileCoalesceBinaryExpression(Expression expr) { }

	// RVA: 0x17CFDE0 Offset: 0x17CFEE1 VA: 0x17CFDE0
	private void CompileInvocationExpression(Expression expr) { }

	// RVA: 0x17D0050 Offset: 0x17D0151 VA: 0x17D0050
	private void CompileListInitExpression(Expression expr) { }

	// RVA: 0x17D00E0 Offset: 0x17D01E1 VA: 0x17D00E0
	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) { }

	// RVA: 0x17D05D0 Offset: 0x17D06D1 VA: 0x17D05D0
	private void CompileMemberInitExpression(Expression expr) { }

	// RVA: 0x17D0660 Offset: 0x17D0761 VA: 0x17D0660
	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) { }

	// RVA: 0x17D0D00 Offset: 0x17D0E01 VA: 0x17D0D00
	private static Type GetMemberType(MemberInfo member) { }

	// RVA: 0x17D0E60 Offset: 0x17D0F61 VA: 0x17D0E60
	private void CompileQuoteUnaryExpression(Expression expr) { }

	// RVA: 0x17D1150 Offset: 0x17D1251 VA: 0x17D1150
	private void CompileUnboxUnaryExpression(Expression expr) { }

	// RVA: 0x17D1290 Offset: 0x17D1391 VA: 0x17D1290
	private void CompileTypeEqualExpression(Expression expr) { }

	// RVA: 0x17C7820 Offset: 0x17C7921 VA: 0x17C7820
	private void CompileTypeAsExpression(UnaryExpression node) { }

	// RVA: 0x17D14D0 Offset: 0x17D15D1 VA: 0x17D14D0
	private void CompileTypeIsExpression(Expression expr) { }

	// RVA: 0x17C3AA0 Offset: 0x17C3BA1 VA: 0x17C3AA0
	private void Compile(Expression expr, bool asVoid) { }

	// RVA: 0x17C3C20 Offset: 0x17C3D21 VA: 0x17C3C20
	private void CompileAsVoid(Expression expr) { }

	// RVA: 0x17D17F0 Offset: 0x17D18F1 VA: 0x17D17F0
	private void CompileNoLabelPush(Expression expr) { }

	// RVA: 0x17C25A0 Offset: 0x17C26A1 VA: 0x17C25A0
	private void Compile(Expression expr) { }

	// RVA: 0x17D1FC0 Offset: 0x17D20C1 VA: 0x17D1FC0
	private static void .cctor() { }
}

