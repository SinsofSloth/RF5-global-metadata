[Serializable]
internal class DefaultBinder : Binder // TypeDefIndex: 213
{
	// Methods

	// RVA: 0x19AC600 Offset: 0x19AC701 VA: 0x19AC600 Slot: 4
	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

	// RVA: 0x19AEE10 Offset: 0x19AEF11 VA: 0x19AEE10 Slot: 5
	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	// RVA: 0x19AF420 Offset: 0x19AF521 VA: 0x19AF420 Slot: 6
	public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x19AFD70 Offset: 0x19AFE71 VA: 0x19AFD70 Slot: 7
	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

	// RVA: 0x19B11C0 Offset: 0x19B12C1 VA: 0x19B11C0 Slot: 8
	public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	// RVA: 0x19B1240 Offset: 0x19B1341 VA: 0x19B1240 Slot: 9
	public override void ReorderArgumentArray(ref object[] args, object state) { }

	// RVA: 0x19B1540 Offset: 0x19B1641 VA: 0x19B1540
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x19B1990 Offset: 0x19B1A91 VA: 0x19B1990
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x19B0BC0 Offset: 0x19B0CC1 VA: 0x19B0BC0
	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0x19B07C0 Offset: 0x19B08C1 VA: 0x19B07C0
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	// RVA: 0x19AEC10 Offset: 0x19AED11 VA: 0x19AEC10
	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0x19AF280 Offset: 0x19AF381 VA: 0x19AF280
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	// RVA: 0x19B1020 Offset: 0x19B1121 VA: 0x19B1020
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	// RVA: 0x19B1CA0 Offset: 0x19B1DA1 VA: 0x19B1CA0
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	// RVA: 0x19B1E20 Offset: 0x19B1F21 VA: 0x19B1E20
	internal static int GetHierarchyDepth(Type t) { }

	// RVA: 0x19B17C0 Offset: 0x19B18C1 VA: 0x19B17C0
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	// RVA: 0x19AEA70 Offset: 0x19AEB71 VA: 0x19AEA70
	private static void ReorderParams(int[] paramOrder, object[] vars) { }

	// RVA: 0x19AE6A0 Offset: 0x19AE7A1 VA: 0x19AE6A0
	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

	// RVA: 0x19AFB20 Offset: 0x19AFC21 VA: 0x19AFB20
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	// RVA: 0x19AE920 Offset: 0x19AEA21 VA: 0x19AE920
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	// RVA: 0x19B1ED0 Offset: 0x19B1FD1 VA: 0x19B1ED0
	public void .ctor() { }
}

