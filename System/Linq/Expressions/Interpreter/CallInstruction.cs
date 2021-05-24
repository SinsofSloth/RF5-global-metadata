internal abstract class CallInstruction : Instruction // TypeDefIndex: 2364
{
	// Properties
	public abstract int ArgumentCount { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_ArgumentCount() { }

	// RVA: 0x1977DA0 Offset: 0x1977EA1 VA: 0x1977DA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1977DF0 Offset: 0x1977EF1 VA: 0x1977DF0
	public static CallInstruction Create(MethodInfo info) { }

	// RVA: 0x1977E70 Offset: 0x1977F71 VA: 0x1977E70
	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	// RVA: 0x1977FE0 Offset: 0x19780E1 VA: 0x1977FE0
	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	// RVA: 0x19784D0 Offset: 0x19785D1 VA: 0x19784D0
	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	// RVA: 0x1978500 Offset: 0x1978601 VA: 0x1978500
	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	// RVA: 0x1978530 Offset: 0x1978631 VA: 0x1978530
	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	// RVA: 0x1978560 Offset: 0x1978661 VA: 0x1978560 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1977880 Offset: 0x1977981 VA: 0x1977880
	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

	// RVA: 0x1977A10 Offset: 0x1977B11 VA: 0x1977A10
	protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args) { }

	// RVA: 0x1978570 Offset: 0x1978671 VA: 0x1978570
	protected void .ctor() { }
}

