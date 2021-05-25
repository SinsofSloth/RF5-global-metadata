[DebuggerTypeProxyAttribute] // RVA: 0xBEE90 Offset: 0xBEF91 VA: 0xBEE90
internal sealed class InstructionList // TypeDefIndex: 2483
{
	// Fields
	private readonly List<Instruction> _instructions; // 0x10
	private List<object> _objects; // 0x18
	private int _currentStackDepth; // 0x20
	private int _maxStackDepth; // 0x24
	private int _currentContinuationsDepth; // 0x28
	private int _maxContinuationDepth; // 0x2C
	private int _runtimeLabelCount; // 0x30
	private List<BranchLabel> _labels; // 0x38
	private List<KeyValuePair<int, object>> _debugCookies; // 0x40
	private static Instruction s_null; // 0x0
	private static Instruction s_true; // 0x8
	private static Instruction s_false; // 0x10
	private static Instruction[] s_Ints; // 0x18
	private static Instruction[] s_loadObjectCached; // 0x20
	private static Instruction[] s_loadLocal; // 0x28
	private static Instruction[] s_loadLocalBoxed; // 0x30
	private static Instruction[] s_loadLocalFromClosure; // 0x38
	private static Instruction[] s_loadLocalFromClosureBoxed; // 0x40
	private static Instruction[] s_assignLocal; // 0x48
	private static Instruction[] s_storeLocal; // 0x50
	private static Instruction[] s_assignLocalBoxed; // 0x58
	private static Instruction[] s_storeLocalBoxed; // 0x60
	private static Instruction[] s_assignLocalToClosure; // 0x68
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; // 0x70
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; // 0x78

	// Properties
	public int Count { get; }
	public int CurrentStackDepth { get; }
	public int CurrentContinuationsDepth { get; }

	// Methods

	// RVA: 0x17B5FD0 Offset: 0x17B60D1 VA: 0x17B5FD0
	public void Emit(Instruction instruction) { }

	// RVA: 0x17B60D0 Offset: 0x17B61D1 VA: 0x17B60D0
	private void UpdateStackDepth(Instruction instruction) { }

	// RVA: 0x17B6190 Offset: 0x17B6291 VA: 0x17B6190
	public void UnEmit() { }

	// RVA: 0x17B62A0 Offset: 0x17B63A1 VA: 0x17B62A0
	public int get_Count() { }

	// RVA: 0x17B62F0 Offset: 0x17B63F1 VA: 0x17B62F0
	public int get_CurrentStackDepth() { }

	// RVA: 0x17B6300 Offset: 0x17B6401 VA: 0x17B6300
	public int get_CurrentContinuationsDepth() { }

	// RVA: 0x17B6310 Offset: 0x17B6411 VA: 0x17B6310
	internal Instruction GetInstruction(int index) { }

	// RVA: 0x17B6390 Offset: 0x17B6491 VA: 0x17B6390
	public InstructionArray ToArray() { }

	// RVA: 0x17B6750 Offset: 0x17B6851 VA: 0x17B6750
	public void EmitLoad(object value) { }

	// RVA: 0x17B6C70 Offset: 0x17B6D71 VA: 0x17B6C70
	public void EmitLoad(bool value) { }

	// RVA: 0x17B6760 Offset: 0x17B6861 VA: 0x17B6760
	public void EmitLoad(object value, Type type) { }

	// RVA: 0x17B6E40 Offset: 0x17B6F41 VA: 0x17B6E40
	public void EmitDup() { }

	// RVA: 0x17B6EB0 Offset: 0x17B6FB1 VA: 0x17B6EB0
	public void EmitPop() { }

	// RVA: 0x17B6F20 Offset: 0x17B7021 VA: 0x17B6F20
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	// RVA: 0x17B7060 Offset: 0x17B7161 VA: 0x17B7060
	public void EmitLoadLocal(int index) { }

	// RVA: 0x17B7280 Offset: 0x17B7381 VA: 0x17B7280
	public void EmitLoadLocalBoxed(int index) { }

	// RVA: 0x17B7300 Offset: 0x17B7401 VA: 0x17B7300
	internal static Instruction LoadLocalBoxed(int index) { }

	// RVA: 0x17B7520 Offset: 0x17B7621 VA: 0x17B7520
	public void EmitLoadLocalFromClosure(int index) { }

	// RVA: 0x17B7740 Offset: 0x17B7841 VA: 0x17B7740
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	// RVA: 0x17B7960 Offset: 0x17B7A61 VA: 0x17B7960
	public void EmitAssignLocal(int index) { }

	// RVA: 0x17B7B80 Offset: 0x17B7C81 VA: 0x17B7B80
	public void EmitStoreLocal(int index) { }

	// RVA: 0x17B7DA0 Offset: 0x17B7EA1 VA: 0x17B7DA0
	public void EmitAssignLocalBoxed(int index) { }

	// RVA: 0x17B7E20 Offset: 0x17B7F21 VA: 0x17B7E20
	internal static Instruction AssignLocalBoxed(int index) { }

	// RVA: 0x17B8040 Offset: 0x17B8141 VA: 0x17B8040
	public void EmitStoreLocalBoxed(int index) { }

	// RVA: 0x17B80C0 Offset: 0x17B81C1 VA: 0x17B80C0
	internal static Instruction StoreLocalBoxed(int index) { }

	// RVA: 0x17B82E0 Offset: 0x17B83E1 VA: 0x17B82E0
	public void EmitAssignLocalToClosure(int index) { }

	// RVA: 0x17B8500 Offset: 0x17B8601 VA: 0x17B8500
	public void EmitStoreLocalToClosure(int index) { }

	// RVA: 0x17B8580 Offset: 0x17B8681 VA: 0x17B8580
	public void EmitInitializeLocal(int index, Type type) { }

	// RVA: 0x17B8760 Offset: 0x17B8861 VA: 0x17B8760
	internal void EmitInitializeParameter(int index) { }

	// RVA: 0x17B8830 Offset: 0x17B8931 VA: 0x17B8830
	internal static Instruction Parameter(int index) { }

	// RVA: 0x17B5A70 Offset: 0x17B5B71 VA: 0x17B5A70
	internal static Instruction ParameterBox(int index) { }

	// RVA: 0x17B86F0 Offset: 0x17B87F1 VA: 0x17B86F0
	internal static Instruction InitReference(int index) { }

	// RVA: 0x17B5DD0 Offset: 0x17B5ED1 VA: 0x17B5DD0
	internal static Instruction InitImmutableRefBox(int index) { }

	// RVA: 0x17B88A0 Offset: 0x17B89A1 VA: 0x17B88A0
	public void EmitNewRuntimeVariables(int count) { }

	// RVA: 0x17B8920 Offset: 0x17B8A21 VA: 0x17B8920
	public void EmitGetArrayItem() { }

	// RVA: 0x17B8990 Offset: 0x17B8A91 VA: 0x17B8990
	public void EmitSetArrayItem() { }

	// RVA: 0x17B8A00 Offset: 0x17B8B01 VA: 0x17B8A00
	public void EmitNewArray(Type elementType) { }

	// RVA: 0x17B8A80 Offset: 0x17B8B81 VA: 0x17B8A80
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	// RVA: 0x17B8B00 Offset: 0x17B8C01 VA: 0x17B8B00
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	// RVA: 0x17B8B80 Offset: 0x17B8C81 VA: 0x17B8B80
	public void EmitAdd(Type type, bool checked) { }

	// RVA: 0x17B8BD0 Offset: 0x17B8CD1 VA: 0x17B8BD0
	public void EmitSub(Type type, bool checked) { }

	// RVA: 0x17B8C20 Offset: 0x17B8D21 VA: 0x17B8C20
	public void EmitMul(Type type, bool checked) { }

	// RVA: 0x17B8C70 Offset: 0x17B8D71 VA: 0x17B8C70
	public void EmitDiv(Type type) { }

	// RVA: 0x17B8CA0 Offset: 0x17B8DA1 VA: 0x17B8CA0
	public void EmitModulo(Type type) { }

	// RVA: 0x17B8CD0 Offset: 0x17B8DD1 VA: 0x17B8CD0
	public void EmitExclusiveOr(Type type) { }

	// RVA: 0x17B8D00 Offset: 0x17B8E01 VA: 0x17B8D00
	public void EmitAnd(Type type) { }

	// RVA: 0x17B8D30 Offset: 0x17B8E31 VA: 0x17B8D30
	public void EmitOr(Type type) { }

	// RVA: 0x17B8D60 Offset: 0x17B8E61 VA: 0x17B8D60
	public void EmitLeftShift(Type type) { }

	// RVA: 0x17B9080 Offset: 0x17B9181 VA: 0x17B9080
	public void EmitRightShift(Type type) { }

	// RVA: 0x17B90B0 Offset: 0x17B91B1 VA: 0x17B90B0
	public void EmitEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x17B90F0 Offset: 0x17B91F1 VA: 0x17B90F0
	public void EmitNotEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x17B9130 Offset: 0x17B9231 VA: 0x17B9130
	public void EmitLessThan(Type type, bool liftedToNull) { }

	// RVA: 0x17B9BA0 Offset: 0x17B9CA1 VA: 0x17B9BA0
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x17BA610 Offset: 0x17BA711 VA: 0x17BA610
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	// RVA: 0x17BA650 Offset: 0x17BA751 VA: 0x17BA650
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x17BA690 Offset: 0x17BA791 VA: 0x17BA690
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x17BA720 Offset: 0x17BA821 VA: 0x17BA720
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x17BA7B0 Offset: 0x17BA8B1 VA: 0x17BA7B0
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x17BA830 Offset: 0x17BA931 VA: 0x17BA830
	public void EmitCast(Type toType) { }

	// RVA: 0x17BA860 Offset: 0x17BA961 VA: 0x17BA860
	public void EmitCastToEnum(Type toType) { }

	// RVA: 0x17BA8E0 Offset: 0x17BA9E1 VA: 0x17BA8E0
	public void EmitCastReferenceToEnum(Type toType) { }

	// RVA: 0x17BA960 Offset: 0x17BAA61 VA: 0x17BA960
	public void EmitNot(Type type) { }

	// RVA: 0x17BA990 Offset: 0x17BAA91 VA: 0x17BA990
	public void EmitDefaultValue(Type type) { }

	// RVA: 0x17BAA10 Offset: 0x17BAB11 VA: 0x17BAA10
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	// RVA: 0x17BAAA0 Offset: 0x17BABA1 VA: 0x17BAAA0
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	// RVA: 0x17BAB40 Offset: 0x17BAC41 VA: 0x17BAB40
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	// RVA: 0x17BABC0 Offset: 0x17BACC1 VA: 0x17BABC0
	public void EmitTypeEquals() { }

	// RVA: 0x17BAC30 Offset: 0x17BAD31 VA: 0x17BAC30
	public void EmitArrayLength() { }

	// RVA: 0x17BACA0 Offset: 0x17BADA1 VA: 0x17BACA0
	public void EmitNegate(Type type) { }

	// RVA: 0x17BACD0 Offset: 0x17BADD1 VA: 0x17BACD0
	public void EmitNegateChecked(Type type) { }

	// RVA: 0x17BAD00 Offset: 0x17BAE01 VA: 0x17BAD00
	public void EmitIncrement(Type type) { }

	// RVA: 0x17BAD30 Offset: 0x17BAE31 VA: 0x17BAD30
	public void EmitDecrement(Type type) { }

	// RVA: 0x17BAD60 Offset: 0x17BAE61 VA: 0x17BAD60
	public void EmitTypeIs(Type type) { }

	// RVA: 0x17BADE0 Offset: 0x17BAEE1 VA: 0x17BADE0
	public void EmitTypeAs(Type type) { }

	// RVA: 0x17BAE60 Offset: 0x17BAF61 VA: 0x17BAE60
	public void EmitLoadField(FieldInfo field) { }

	// RVA: 0x17BAE90 Offset: 0x17BAF91 VA: 0x17BAE90
	private Instruction GetLoadField(FieldInfo field) { }

	// RVA: 0x17BB0D0 Offset: 0x17BB1D1 VA: 0x17BB0D0
	public void EmitStoreField(FieldInfo field) { }

	// RVA: 0x17BB180 Offset: 0x17BB281 VA: 0x17BB180
	public void EmitCall(MethodInfo method) { }

	// RVA: 0x17BB210 Offset: 0x17BB311 VA: 0x17BB210
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x17BB250 Offset: 0x17BB351 VA: 0x17BB250
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x17BB310 Offset: 0x17BB411 VA: 0x17BB310
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x17B64B0 Offset: 0x17B65B1 VA: 0x17B64B0
	private RuntimeLabel[] BuildRuntimeLabels() { }

	// RVA: 0x17BB370 Offset: 0x17BB471 VA: 0x17BB370
	public BranchLabel MakeLabel() { }

	// RVA: 0x17BB430 Offset: 0x17BB531 VA: 0x17BB430
	internal void FixupBranch(int branchIndex, int offset) { }

	// RVA: 0x17BB510 Offset: 0x17BB611 VA: 0x17BB510
	private int EnsureLabelIndex(BranchLabel label) { }

	// RVA: 0x17BB570 Offset: 0x17BB671 VA: 0x17BB570
	public int MarkRuntimeLabel() { }

	// RVA: 0x17BB5E0 Offset: 0x17BB6E1 VA: 0x17BB5E0
	public void MarkLabel(BranchLabel label) { }

	// RVA: 0x17BB610 Offset: 0x17BB711 VA: 0x17BB610
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x17BB6F0 Offset: 0x17BB7F1 VA: 0x17BB6F0
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	// RVA: 0x17BB770 Offset: 0x17BB871 VA: 0x17BB770
	public void EmitBranch(BranchLabel label) { }

	// RVA: 0x17BB830 Offset: 0x17BB931 VA: 0x17BB830
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	// RVA: 0x17BB910 Offset: 0x17BBA11 VA: 0x17BB910
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	// RVA: 0x17BB9D0 Offset: 0x17BBAD1 VA: 0x17BB9D0
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	// RVA: 0x17BBA90 Offset: 0x17BBB91 VA: 0x17BBA90
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	// RVA: 0x17BBB50 Offset: 0x17BBC51 VA: 0x17BBB50
	public void EmitThrow() { }

	// RVA: 0x17BBBC0 Offset: 0x17BBCC1 VA: 0x17BBBC0
	public void EmitThrowVoid() { }

	// RVA: 0x17BBC30 Offset: 0x17BBD31 VA: 0x17BBC30
	public void EmitRethrow() { }

	// RVA: 0x17BBCA0 Offset: 0x17BBDA1 VA: 0x17BBCA0
	public void EmitRethrowVoid() { }

	// RVA: 0x17BBD10 Offset: 0x17BBE11 VA: 0x17BBD10
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x17BBD80 Offset: 0x17BBE81 VA: 0x17BBD80
	public void EmitEnterTryCatch() { }

	// RVA: 0x17BBDB0 Offset: 0x17BBEB1 VA: 0x17BBDB0
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	// RVA: 0x17BBE70 Offset: 0x17BBF71 VA: 0x17BBE70
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x17BBF30 Offset: 0x17BC031 VA: 0x17BBF30
	public void EmitLeaveFinally() { }

	// RVA: 0x17BBFA0 Offset: 0x17BC0A1 VA: 0x17BBFA0
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	// RVA: 0x17BC060 Offset: 0x17BC161 VA: 0x17BC060
	public void EmitLeaveFault() { }

	// RVA: 0x17BC0D0 Offset: 0x17BC1D1 VA: 0x17BC0D0
	public void EmitEnterExceptionFilter() { }

	// RVA: 0x17BC140 Offset: 0x17BC241 VA: 0x17BC140
	public void EmitLeaveExceptionFilter() { }

	// RVA: 0x17BC1B0 Offset: 0x17BC2B1 VA: 0x17BC1B0
	public void EmitEnterExceptionHandlerNonVoid() { }

	// RVA: 0x17BC220 Offset: 0x17BC321 VA: 0x17BC220
	public void EmitEnterExceptionHandlerVoid() { }

	// RVA: 0x17BC290 Offset: 0x17BC391 VA: 0x17BC290
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	// RVA: -1 Offset: -1
	public void EmitIntSwitch<T>(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B71D0 Offset: 0x24B72D1 VA: 0x24B71D0
	|-InstructionList.EmitIntSwitch<int>
	|
	|-RVA: 0x24B7250 Offset: 0x24B7351 VA: 0x24B7250
	|-InstructionList.EmitIntSwitch<object>
	*/

	// RVA: 0x17BC4D0 Offset: 0x17BC5D1 VA: 0x17BC4D0
	public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x17BC550 Offset: 0x17BC651 VA: 0x17BC550
	public void .ctor() { }

	// RVA: 0x17BC5D0 Offset: 0x17BC6D1 VA: 0x17BC5D0
	private static void .cctor() { }
}

