public sealed class DynamicUnionResolver : IFormatterResolver // TypeDefIndex: 5248
{
	// Fields
	private const string ModuleName = "MessagePack.Resolvers.DynamicUnionResolver";
	public static readonly DynamicUnionResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x10
	private static readonly Regex SubtractFullNameRegex; // 0x18
	private static int nameSequence; // 0x20
	private static readonly Type refMessagePackReader; // 0x28
	private static readonly Type refKvp; // 0x30
	private static readonly MethodInfo getFormatterWithVerify; // 0x38
	private static readonly MethodInfo getResolverFromOptions; // 0x40
	private static readonly Func<Type, MethodInfo> getSerialize; // 0x48
	private static readonly Func<Type, MethodInfo> getDeserialize; // 0x50
	private static readonly FieldInfo runtimeTypeHandleEqualityComparer; // 0x58
	private static readonly ConstructorInfo intIntKeyValuePairConstructor; // 0x60
	private static readonly ConstructorInfo typeMapDictionaryConstructor; // 0x68
	private static readonly MethodInfo typeMapDictionaryAdd; // 0x70
	private static readonly MethodInfo typeMapDictionaryTryGetValue; // 0x78
	private static readonly ConstructorInfo keyMapDictionaryConstructor; // 0x80
	private static readonly MethodInfo keyMapDictionaryAdd; // 0x88
	private static readonly MethodInfo keyMapDictionaryTryGetValue; // 0x90
	private static readonly MethodInfo objectGetType; // 0x98
	private static readonly MethodInfo getTypeHandle; // 0xA0
	private static readonly MethodInfo intIntKeyValuePairGetKey; // 0xA8
	private static readonly MethodInfo intIntKeyValuePairGetValue; // 0xB0
	private static readonly ConstructorInfo invalidOperationExceptionConstructor; // 0xB8
	private static readonly ConstructorInfo objectCtor; // 0xC0

	// Methods

	// RVA: 0x14F3E20 Offset: 0x14F3F21 VA: 0x14F3E20
	private static void .cctor() { }

	// RVA: 0x14F49A0 Offset: 0x14F4AA1 VA: 0x14F49A0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x182A2F0 Offset: 0x182A3F1 VA: 0x182A2F0
	|-DynamicUnionResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x182A3A0 Offset: 0x182A4A1 VA: 0x182A3A0
	|-DynamicUnionResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x182A450 Offset: 0x182A551 VA: 0x182A450
	|-DynamicUnionResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x182A500 Offset: 0x182A601 VA: 0x182A500
	|-DynamicUnionResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x182A5B0 Offset: 0x182A6B1 VA: 0x182A5B0
	|-DynamicUnionResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x182A660 Offset: 0x182A761 VA: 0x182A660
	|-DynamicUnionResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x182A710 Offset: 0x182A811 VA: 0x182A710
	|-DynamicUnionResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x182A7C0 Offset: 0x182A8C1 VA: 0x182A7C0
	|-DynamicUnionResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x182A870 Offset: 0x182A971 VA: 0x182A870
	|-DynamicUnionResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x182A920 Offset: 0x182AA21 VA: 0x182A920
	|-DynamicUnionResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x182A9D0 Offset: 0x182AAD1 VA: 0x182A9D0
	|-DynamicUnionResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x182AA80 Offset: 0x182AB81 VA: 0x182AA80
	|-DynamicUnionResolver.GetFormatter<bool>
	|
	|-RVA: 0x182AB30 Offset: 0x182AC31 VA: 0x182AB30
	|-DynamicUnionResolver.GetFormatter<byte>
	|
	|-RVA: 0x182ABE0 Offset: 0x182ACE1 VA: 0x182ABE0
	|-DynamicUnionResolver.GetFormatter<char>
	|
	|-RVA: 0x182AC90 Offset: 0x182AD91 VA: 0x182AC90
	|-DynamicUnionResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x182AD40 Offset: 0x182AE41 VA: 0x182AD40
	|-DynamicUnionResolver.GetFormatter<double>
	|
	|-RVA: 0x182ADF0 Offset: 0x182AEF1 VA: 0x182ADF0
	|-DynamicUnionResolver.GetFormatter<short>
	|
	|-RVA: 0x182AEA0 Offset: 0x182AFA1 VA: 0x182AEA0
	|-DynamicUnionResolver.GetFormatter<int>
	|
	|-RVA: 0x182AF50 Offset: 0x182B051 VA: 0x182AF50
	|-DynamicUnionResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x182B000 Offset: 0x182B101 VA: 0x182B000
	|-DynamicUnionResolver.GetFormatter<long>
	|
	|-RVA: 0x182B0B0 Offset: 0x182B1B1 VA: 0x182B0B0
	|-DynamicUnionResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x182B160 Offset: 0x182B261 VA: 0x182B160
	|-DynamicUnionResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x182B210 Offset: 0x182B311 VA: 0x182B210
	|-DynamicUnionResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x182B2C0 Offset: 0x182B3C1 VA: 0x182B2C0
	|-DynamicUnionResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x182B370 Offset: 0x182B471 VA: 0x182B370
	|-DynamicUnionResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x182B420 Offset: 0x182B521 VA: 0x182B420
	|-DynamicUnionResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x182B4D0 Offset: 0x182B5D1 VA: 0x182B4D0
	|-DynamicUnionResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x182B580 Offset: 0x182B681 VA: 0x182B580
	|-DynamicUnionResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x182B630 Offset: 0x182B731 VA: 0x182B630
	|-DynamicUnionResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x182B6E0 Offset: 0x182B7E1 VA: 0x182B6E0
	|-DynamicUnionResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x182B790 Offset: 0x182B891 VA: 0x182B790
	|-DynamicUnionResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x182B840 Offset: 0x182B941 VA: 0x182B840
	|-DynamicUnionResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x182B8F0 Offset: 0x182B9F1 VA: 0x182B8F0
	|-DynamicUnionResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x182B9A0 Offset: 0x182BAA1 VA: 0x182B9A0
	|-DynamicUnionResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x182BA50 Offset: 0x182BB51 VA: 0x182BA50
	|-DynamicUnionResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x182BB00 Offset: 0x182BC01 VA: 0x182BB00
	|-DynamicUnionResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x182BBB0 Offset: 0x182BCB1 VA: 0x182BBB0
	|-DynamicUnionResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x182BC60 Offset: 0x182BD61 VA: 0x182BC60
	|-DynamicUnionResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x182BD10 Offset: 0x182BE11 VA: 0x182BD10
	|-DynamicUnionResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x182BDC0 Offset: 0x182BEC1 VA: 0x182BDC0
	|-DynamicUnionResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x182BE70 Offset: 0x182BF71 VA: 0x182BE70
	|-DynamicUnionResolver.GetFormatter<object>
	|
	|-RVA: 0x182BF20 Offset: 0x182C021 VA: 0x182BF20
	|-DynamicUnionResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x182BFD0 Offset: 0x182C0D1 VA: 0x182BFD0
	|-DynamicUnionResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x182C080 Offset: 0x182C181 VA: 0x182C080
	|-DynamicUnionResolver.GetFormatter<float>
	|
	|-RVA: 0x182C130 Offset: 0x182C231 VA: 0x182C130
	|-DynamicUnionResolver.GetFormatter<ushort>
	|
	|-RVA: 0x182C1E0 Offset: 0x182C2E1 VA: 0x182C1E0
	|-DynamicUnionResolver.GetFormatter<uint>
	|
	|-RVA: 0x182C290 Offset: 0x182C391 VA: 0x182C290
	|-DynamicUnionResolver.GetFormatter<ulong>
	|
	|-RVA: 0x182C340 Offset: 0x182C441 VA: 0x182C340
	|-DynamicUnionResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x182C3F0 Offset: 0x182C4F1 VA: 0x182C3F0
	|-DynamicUnionResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x182C4A0 Offset: 0x182C5A1 VA: 0x182C4A0
	|-DynamicUnionResolver.GetFormatter<Color32>
	|
	|-RVA: 0x182C550 Offset: 0x182C651 VA: 0x182C550
	|-DynamicUnionResolver.GetFormatter<Color>
	|
	|-RVA: 0x182C600 Offset: 0x182C701 VA: 0x182C600
	|-DynamicUnionResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x182C6B0 Offset: 0x182C7B1 VA: 0x182C6B0
	|-DynamicUnionResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x182C760 Offset: 0x182C861 VA: 0x182C760
	|-DynamicUnionResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x182C810 Offset: 0x182C911 VA: 0x182C810
	|-DynamicUnionResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x182C8C0 Offset: 0x182C9C1 VA: 0x182C8C0
	|-DynamicUnionResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x182C970 Offset: 0x182CA71 VA: 0x182C970
	|-DynamicUnionResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x182CA20 Offset: 0x182CB21 VA: 0x182CA20
	|-DynamicUnionResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x182CAD0 Offset: 0x182CBD1 VA: 0x182CAD0
	|-DynamicUnionResolver.GetFormatter<Rect>
	|
	|-RVA: 0x182CB80 Offset: 0x182CC81 VA: 0x182CB80
	|-DynamicUnionResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x182CC30 Offset: 0x182CD31 VA: 0x182CC30
	|-DynamicUnionResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x182CCE0 Offset: 0x182CDE1 VA: 0x182CCE0
	|-DynamicUnionResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x182CD90 Offset: 0x182CE91 VA: 0x182CD90
	|-DynamicUnionResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x182CE40 Offset: 0x182CF41 VA: 0x182CE40
	|-DynamicUnionResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x182CEF0 Offset: 0x182CFF1 VA: 0x182CEF0
	|-DynamicUnionResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F49B0 Offset: 0x14F4AB1 VA: 0x14F49B0
	private static TypeInfo BuildType(Type type) { }

	// RVA: 0x14F5830 Offset: 0x14F5931 VA: 0x14F5830
	private static void BuildConstructor(Type type, UnionAttribute[] infos, ConstructorInfo method, FieldBuilder typeToKeyAndJumpMap, FieldBuilder keyToJumpMap, ILGenerator il) { }

	// RVA: 0x14F5C60 Offset: 0x14F5D61 VA: 0x14F5C60
	private static void BuildSerialize(Type type, UnionAttribute[] infos, MethodBuilder method, FieldBuilder typeToKeyAndJumpMap, ILGenerator il) { }

	// RVA: 0x14F65D0 Offset: 0x14F66D1 VA: 0x14F65D0
	private static void BuildDeserialize(Type type, UnionAttribute[] infos, MethodBuilder method, FieldBuilder keyToJumpMap, ILGenerator il) { }

	// RVA: 0x14F7110 Offset: 0x14F7211 VA: 0x14F7110
	private static bool IsZeroStartSequential(UnionAttribute[] infos) { }
}

