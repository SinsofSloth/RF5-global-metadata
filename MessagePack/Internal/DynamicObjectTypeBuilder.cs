internal static class DynamicObjectTypeBuilder // TypeDefIndex: 5305
{
	// Fields
	private static readonly Regex SubtractFullNameRegex; // 0x0
	private static int nameSequence; // 0x8
	private static HashSet<Type> ignoreTypes; // 0x10
	private static readonly Type refMessagePackReader; // 0x18
	private static readonly MethodInfo ReadOnlySpanFromByteArray; // 0x20
	private static readonly MethodInfo ReadStringSpan; // 0x28
	private static readonly MethodInfo ArrayFromNullableReadOnlySequence; // 0x30
	private static readonly MethodInfo getFormatterWithVerify; // 0x38
	private static readonly MethodInfo getResolverFromOptions; // 0x40
	private static readonly MethodInfo getSecurityFromOptions; // 0x48
	private static readonly MethodInfo securityDepthStep; // 0x50
	private static readonly MethodInfo readerDepthGet; // 0x58
	private static readonly MethodInfo readerDepthSet; // 0x60
	private static readonly Func<Type, MethodInfo> getSerialize; // 0x68
	private static readonly Func<Type, MethodInfo> getDeserialize; // 0x70
	private static readonly ConstructorInfo messagePackSerializationExceptionMessageOnlyConstructor; // 0x78
	private static readonly MethodInfo onBeforeSerialize; // 0x80
	private static readonly MethodInfo onAfterDeserialize; // 0x88
	private static readonly ConstructorInfo objectCtor; // 0x90

	// Methods

	// RVA: 0x166D120 Offset: 0x166D221 VA: 0x166D120
	public static TypeInfo BuildType(DynamicAssembly assembly, Type type, bool forceStringKey, bool contractless) { }

	// RVA: 0x16752B0 Offset: 0x16753B1 VA: 0x16752B0
	public static object BuildFormatterToDynamicMethod(Type type, bool forceStringKey, bool contractless, bool allowPrivate) { }

	// RVA: 0x1672030 Offset: 0x1672131 VA: 0x1672030
	private static void BuildConstructor(Type type, ObjectSerializationInfo info, ConstructorInfo method, FieldBuilder stringByteKeysField, ILGenerator il) { }

	// RVA: 0x1672750 Offset: 0x1672851 VA: 0x1672750
	private static Dictionary<ObjectSerializationInfo.EmittableMember, FieldInfo> BuildCustomFormatterField(TypeBuilder builder, ObjectSerializationInfo info, ILGenerator il) { }

	// RVA: 0x1673270 Offset: 0x1673371 VA: 0x1673270
	private static void BuildSerialize(Type type, ObjectSerializationInfo info, ILGenerator il, Action emitStringByteKeys, Func<int, ObjectSerializationInfo.EmittableMember, Action> tryEmitLoadCustomFormatter, int firstArgIndex) { }

	// RVA: 0x1676BA0 Offset: 0x1676CA1 VA: 0x1676BA0
	private static void EmitSerializeValue(ILGenerator il, TypeInfo type, ObjectSerializationInfo.EmittableMember member, int index, Func<int, ObjectSerializationInfo.EmittableMember, Action> tryEmitLoadCustomFormatter, ArgumentField argWriter, ArgumentField argValue, ArgumentField argOptions, LocalBuilder localResolver) { }

	// RVA: 0x1674220 Offset: 0x1674321 VA: 0x1674220
	private static void BuildDeserialize(Type type, ObjectSerializationInfo info, ILGenerator il, Func<int, ObjectSerializationInfo.EmittableMember, Action> tryEmitLoadCustomFormatter, int firstArgIndex) { }

	// RVA: 0x1678320 Offset: 0x1678421 VA: 0x1678320
	private static void EmitDeserializeValue(ILGenerator il, DynamicObjectTypeBuilder.DeserializeInfo info, int index, Func<int, ObjectSerializationInfo.EmittableMember, Action> tryEmitLoadCustomFormatter, ArgumentField argReader, ArgumentField argOptions, LocalBuilder localResolver) { }

	// RVA: 0x16778A0 Offset: 0x16779A1 VA: 0x16778A0
	private static LocalBuilder EmitNewObject(ILGenerator il, Type type, ObjectSerializationInfo info, DynamicObjectTypeBuilder.DeserializeInfo[] members) { }

	// RVA: 0x1678940 Offset: 0x1678A41 VA: 0x1678940
	private static void EmitNewObjectConstructorArguments(ILGenerator il, ObjectSerializationInfo info, DynamicObjectTypeBuilder.DeserializeInfo[] members) { }

	// RVA: 0x16771A0 Offset: 0x16772A1 VA: 0x16771A0
	private static bool IsOptimizeTargetType(Type type) { }

	// RVA: 0x1678B60 Offset: 0x1678C61 VA: 0x1678B60
	private static bool Matches(MethodInfo m, int parameterIndex, Type desiredType) { }

	// RVA: 0x1678C90 Offset: 0x1678D91 VA: 0x1678C90
	private static void .cctor() { }
}

