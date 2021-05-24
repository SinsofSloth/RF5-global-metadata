public sealed class ContractlessStandardResolver : IFormatterResolver // TypeDefIndex: 5268
{
	// Fields
	public static readonly ContractlessStandardResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2750 Offset: 0x14F2851 VA: 0x14F2750
	private static void .cctor() { }

	// RVA: 0x14F2880 Offset: 0x14F2981 VA: 0x14F2880
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18110C0 Offset: 0x18111C1 VA: 0x18110C0
	|-ContractlessStandardResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1811170 Offset: 0x1811271 VA: 0x1811170
	|-ContractlessStandardResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1811220 Offset: 0x1811321 VA: 0x1811220
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x18112D0 Offset: 0x18113D1 VA: 0x18112D0
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1811380 Offset: 0x1811481 VA: 0x1811380
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1811430 Offset: 0x1811531 VA: 0x1811430
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x18114E0 Offset: 0x18115E1 VA: 0x18114E0
	|-ContractlessStandardResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1811590 Offset: 0x1811691 VA: 0x1811590
	|-ContractlessStandardResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1811640 Offset: 0x1811741 VA: 0x1811640
	|-ContractlessStandardResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18116F0 Offset: 0x18117F1 VA: 0x18116F0
	|-ContractlessStandardResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18117A0 Offset: 0x18118A1 VA: 0x18117A0
	|-ContractlessStandardResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1811850 Offset: 0x1811951 VA: 0x1811850
	|-ContractlessStandardResolver.GetFormatter<bool>
	|
	|-RVA: 0x1811900 Offset: 0x1811A01 VA: 0x1811900
	|-ContractlessStandardResolver.GetFormatter<byte>
	|
	|-RVA: 0x18119B0 Offset: 0x1811AB1 VA: 0x18119B0
	|-ContractlessStandardResolver.GetFormatter<char>
	|
	|-RVA: 0x1811A60 Offset: 0x1811B61 VA: 0x1811A60
	|-ContractlessStandardResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1811B10 Offset: 0x1811C11 VA: 0x1811B10
	|-ContractlessStandardResolver.GetFormatter<double>
	|
	|-RVA: 0x1811BC0 Offset: 0x1811CC1 VA: 0x1811BC0
	|-ContractlessStandardResolver.GetFormatter<short>
	|
	|-RVA: 0x1811C70 Offset: 0x1811D71 VA: 0x1811C70
	|-ContractlessStandardResolver.GetFormatter<int>
	|
	|-RVA: 0x1811D20 Offset: 0x1811E21 VA: 0x1811D20
	|-ContractlessStandardResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1811DD0 Offset: 0x1811ED1 VA: 0x1811DD0
	|-ContractlessStandardResolver.GetFormatter<long>
	|
	|-RVA: 0x1811E80 Offset: 0x1811F81 VA: 0x1811E80
	|-ContractlessStandardResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1811F30 Offset: 0x1812031 VA: 0x1811F30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1811FE0 Offset: 0x18120E1 VA: 0x1811FE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1812090 Offset: 0x1812191 VA: 0x1812090
	|-ContractlessStandardResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1812140 Offset: 0x1812241 VA: 0x1812140
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x18121F0 Offset: 0x18122F1 VA: 0x18121F0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x18122A0 Offset: 0x18123A1 VA: 0x18122A0
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1812350 Offset: 0x1812451 VA: 0x1812350
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1812400 Offset: 0x1812501 VA: 0x1812400
	|-ContractlessStandardResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18124B0 Offset: 0x18125B1 VA: 0x18124B0
	|-ContractlessStandardResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1812560 Offset: 0x1812661 VA: 0x1812560
	|-ContractlessStandardResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1812610 Offset: 0x1812711 VA: 0x1812610
	|-ContractlessStandardResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18126C0 Offset: 0x18127C1 VA: 0x18126C0
	|-ContractlessStandardResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1812770 Offset: 0x1812871 VA: 0x1812770
	|-ContractlessStandardResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1812820 Offset: 0x1812921 VA: 0x1812820
	|-ContractlessStandardResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18128D0 Offset: 0x18129D1 VA: 0x18128D0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1812980 Offset: 0x1812A81 VA: 0x1812980
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1812A30 Offset: 0x1812B31 VA: 0x1812A30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1812AE0 Offset: 0x1812BE1 VA: 0x1812AE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1812B90 Offset: 0x1812C91 VA: 0x1812B90
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1812C40 Offset: 0x1812D41 VA: 0x1812C40
	|-ContractlessStandardResolver.GetFormatter<object>
	|
	|-RVA: 0x1812CF0 Offset: 0x1812DF1 VA: 0x1812CF0
	|-ContractlessStandardResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1812DA0 Offset: 0x1812EA1 VA: 0x1812DA0
	|-ContractlessStandardResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1812E50 Offset: 0x1812F51 VA: 0x1812E50
	|-ContractlessStandardResolver.GetFormatter<float>
	|
	|-RVA: 0x1812F00 Offset: 0x1813001 VA: 0x1812F00
	|-ContractlessStandardResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1812FB0 Offset: 0x18130B1 VA: 0x1812FB0
	|-ContractlessStandardResolver.GetFormatter<uint>
	|
	|-RVA: 0x1813060 Offset: 0x1813161 VA: 0x1813060
	|-ContractlessStandardResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1813110 Offset: 0x1813211 VA: 0x1813110
	|-ContractlessStandardResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x18131C0 Offset: 0x18132C1 VA: 0x18131C0
	|-ContractlessStandardResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1813270 Offset: 0x1813371 VA: 0x1813270
	|-ContractlessStandardResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1813320 Offset: 0x1813421 VA: 0x1813320
	|-ContractlessStandardResolver.GetFormatter<Color>
	|
	|-RVA: 0x18133D0 Offset: 0x18134D1 VA: 0x18133D0
	|-ContractlessStandardResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1813480 Offset: 0x1813581 VA: 0x1813480
	|-ContractlessStandardResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1813530 Offset: 0x1813631 VA: 0x1813530
	|-ContractlessStandardResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x18135E0 Offset: 0x18136E1 VA: 0x18135E0
	|-ContractlessStandardResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1813690 Offset: 0x1813791 VA: 0x1813690
	|-ContractlessStandardResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1813740 Offset: 0x1813841 VA: 0x1813740
	|-ContractlessStandardResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18137F0 Offset: 0x18138F1 VA: 0x18137F0
	|-ContractlessStandardResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18138A0 Offset: 0x18139A1 VA: 0x18138A0
	|-ContractlessStandardResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1813950 Offset: 0x1813A51 VA: 0x1813950
	|-ContractlessStandardResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1813A00 Offset: 0x1813B01 VA: 0x1813A00
	|-ContractlessStandardResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1813AB0 Offset: 0x1813BB1 VA: 0x1813AB0
	|-ContractlessStandardResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1813B60 Offset: 0x1813C61 VA: 0x1813B60
	|-ContractlessStandardResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1813C10 Offset: 0x1813D11 VA: 0x1813C10
	|-ContractlessStandardResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1813CC0 Offset: 0x1813DC1 VA: 0x1813CC0
	|-ContractlessStandardResolver.GetFormatter<Vector4>
	*/
}

public sealed class ContractlessStandardResolver : IFormatterResolver // TypeDefIndex: 5268
{
	// Fields
	public static readonly ContractlessStandardResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2750 Offset: 0x14F2851 VA: 0x14F2750
	private static void .cctor() { }

	// RVA: 0x14F2880 Offset: 0x14F2981 VA: 0x14F2880
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18110C0 Offset: 0x18111C1 VA: 0x18110C0
	|-ContractlessStandardResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1811170 Offset: 0x1811271 VA: 0x1811170
	|-ContractlessStandardResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1811220 Offset: 0x1811321 VA: 0x1811220
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x18112D0 Offset: 0x18113D1 VA: 0x18112D0
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1811380 Offset: 0x1811481 VA: 0x1811380
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1811430 Offset: 0x1811531 VA: 0x1811430
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x18114E0 Offset: 0x18115E1 VA: 0x18114E0
	|-ContractlessStandardResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1811590 Offset: 0x1811691 VA: 0x1811590
	|-ContractlessStandardResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1811640 Offset: 0x1811741 VA: 0x1811640
	|-ContractlessStandardResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18116F0 Offset: 0x18117F1 VA: 0x18116F0
	|-ContractlessStandardResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18117A0 Offset: 0x18118A1 VA: 0x18117A0
	|-ContractlessStandardResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1811850 Offset: 0x1811951 VA: 0x1811850
	|-ContractlessStandardResolver.GetFormatter<bool>
	|
	|-RVA: 0x1811900 Offset: 0x1811A01 VA: 0x1811900
	|-ContractlessStandardResolver.GetFormatter<byte>
	|
	|-RVA: 0x18119B0 Offset: 0x1811AB1 VA: 0x18119B0
	|-ContractlessStandardResolver.GetFormatter<char>
	|
	|-RVA: 0x1811A60 Offset: 0x1811B61 VA: 0x1811A60
	|-ContractlessStandardResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1811B10 Offset: 0x1811C11 VA: 0x1811B10
	|-ContractlessStandardResolver.GetFormatter<double>
	|
	|-RVA: 0x1811BC0 Offset: 0x1811CC1 VA: 0x1811BC0
	|-ContractlessStandardResolver.GetFormatter<short>
	|
	|-RVA: 0x1811C70 Offset: 0x1811D71 VA: 0x1811C70
	|-ContractlessStandardResolver.GetFormatter<int>
	|
	|-RVA: 0x1811D20 Offset: 0x1811E21 VA: 0x1811D20
	|-ContractlessStandardResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1811DD0 Offset: 0x1811ED1 VA: 0x1811DD0
	|-ContractlessStandardResolver.GetFormatter<long>
	|
	|-RVA: 0x1811E80 Offset: 0x1811F81 VA: 0x1811E80
	|-ContractlessStandardResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1811F30 Offset: 0x1812031 VA: 0x1811F30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1811FE0 Offset: 0x18120E1 VA: 0x1811FE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1812090 Offset: 0x1812191 VA: 0x1812090
	|-ContractlessStandardResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1812140 Offset: 0x1812241 VA: 0x1812140
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x18121F0 Offset: 0x18122F1 VA: 0x18121F0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x18122A0 Offset: 0x18123A1 VA: 0x18122A0
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1812350 Offset: 0x1812451 VA: 0x1812350
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1812400 Offset: 0x1812501 VA: 0x1812400
	|-ContractlessStandardResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18124B0 Offset: 0x18125B1 VA: 0x18124B0
	|-ContractlessStandardResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1812560 Offset: 0x1812661 VA: 0x1812560
	|-ContractlessStandardResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1812610 Offset: 0x1812711 VA: 0x1812610
	|-ContractlessStandardResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18126C0 Offset: 0x18127C1 VA: 0x18126C0
	|-ContractlessStandardResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1812770 Offset: 0x1812871 VA: 0x1812770
	|-ContractlessStandardResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1812820 Offset: 0x1812921 VA: 0x1812820
	|-ContractlessStandardResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18128D0 Offset: 0x18129D1 VA: 0x18128D0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1812980 Offset: 0x1812A81 VA: 0x1812980
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1812A30 Offset: 0x1812B31 VA: 0x1812A30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1812AE0 Offset: 0x1812BE1 VA: 0x1812AE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1812B90 Offset: 0x1812C91 VA: 0x1812B90
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1812C40 Offset: 0x1812D41 VA: 0x1812C40
	|-ContractlessStandardResolver.GetFormatter<object>
	|
	|-RVA: 0x1812CF0 Offset: 0x1812DF1 VA: 0x1812CF0
	|-ContractlessStandardResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1812DA0 Offset: 0x1812EA1 VA: 0x1812DA0
	|-ContractlessStandardResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1812E50 Offset: 0x1812F51 VA: 0x1812E50
	|-ContractlessStandardResolver.GetFormatter<float>
	|
	|-RVA: 0x1812F00 Offset: 0x1813001 VA: 0x1812F00
	|-ContractlessStandardResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1812FB0 Offset: 0x18130B1 VA: 0x1812FB0
	|-ContractlessStandardResolver.GetFormatter<uint>
	|
	|-RVA: 0x1813060 Offset: 0x1813161 VA: 0x1813060
	|-ContractlessStandardResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1813110 Offset: 0x1813211 VA: 0x1813110
	|-ContractlessStandardResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x18131C0 Offset: 0x18132C1 VA: 0x18131C0
	|-ContractlessStandardResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1813270 Offset: 0x1813371 VA: 0x1813270
	|-ContractlessStandardResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1813320 Offset: 0x1813421 VA: 0x1813320
	|-ContractlessStandardResolver.GetFormatter<Color>
	|
	|-RVA: 0x18133D0 Offset: 0x18134D1 VA: 0x18133D0
	|-ContractlessStandardResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1813480 Offset: 0x1813581 VA: 0x1813480
	|-ContractlessStandardResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1813530 Offset: 0x1813631 VA: 0x1813530
	|-ContractlessStandardResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x18135E0 Offset: 0x18136E1 VA: 0x18135E0
	|-ContractlessStandardResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1813690 Offset: 0x1813791 VA: 0x1813690
	|-ContractlessStandardResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1813740 Offset: 0x1813841 VA: 0x1813740
	|-ContractlessStandardResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18137F0 Offset: 0x18138F1 VA: 0x18137F0
	|-ContractlessStandardResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18138A0 Offset: 0x18139A1 VA: 0x18138A0
	|-ContractlessStandardResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1813950 Offset: 0x1813A51 VA: 0x1813950
	|-ContractlessStandardResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1813A00 Offset: 0x1813B01 VA: 0x1813A00
	|-ContractlessStandardResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1813AB0 Offset: 0x1813BB1 VA: 0x1813AB0
	|-ContractlessStandardResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1813B60 Offset: 0x1813C61 VA: 0x1813B60
	|-ContractlessStandardResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1813C10 Offset: 0x1813D11 VA: 0x1813C10
	|-ContractlessStandardResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1813CC0 Offset: 0x1813DC1 VA: 0x1813CC0
	|-ContractlessStandardResolver.GetFormatter<Vector4>
	*/
}

public sealed class ContractlessStandardResolver : IFormatterResolver // TypeDefIndex: 5268
{
	// Fields
	public static readonly ContractlessStandardResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2750 Offset: 0x14F2851 VA: 0x14F2750
	private static void .cctor() { }

	// RVA: 0x14F2880 Offset: 0x14F2981 VA: 0x14F2880
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18110C0 Offset: 0x18111C1 VA: 0x18110C0
	|-ContractlessStandardResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1811170 Offset: 0x1811271 VA: 0x1811170
	|-ContractlessStandardResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1811220 Offset: 0x1811321 VA: 0x1811220
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x18112D0 Offset: 0x18113D1 VA: 0x18112D0
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1811380 Offset: 0x1811481 VA: 0x1811380
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1811430 Offset: 0x1811531 VA: 0x1811430
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x18114E0 Offset: 0x18115E1 VA: 0x18114E0
	|-ContractlessStandardResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1811590 Offset: 0x1811691 VA: 0x1811590
	|-ContractlessStandardResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1811640 Offset: 0x1811741 VA: 0x1811640
	|-ContractlessStandardResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18116F0 Offset: 0x18117F1 VA: 0x18116F0
	|-ContractlessStandardResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18117A0 Offset: 0x18118A1 VA: 0x18117A0
	|-ContractlessStandardResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1811850 Offset: 0x1811951 VA: 0x1811850
	|-ContractlessStandardResolver.GetFormatter<bool>
	|
	|-RVA: 0x1811900 Offset: 0x1811A01 VA: 0x1811900
	|-ContractlessStandardResolver.GetFormatter<byte>
	|
	|-RVA: 0x18119B0 Offset: 0x1811AB1 VA: 0x18119B0
	|-ContractlessStandardResolver.GetFormatter<char>
	|
	|-RVA: 0x1811A60 Offset: 0x1811B61 VA: 0x1811A60
	|-ContractlessStandardResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1811B10 Offset: 0x1811C11 VA: 0x1811B10
	|-ContractlessStandardResolver.GetFormatter<double>
	|
	|-RVA: 0x1811BC0 Offset: 0x1811CC1 VA: 0x1811BC0
	|-ContractlessStandardResolver.GetFormatter<short>
	|
	|-RVA: 0x1811C70 Offset: 0x1811D71 VA: 0x1811C70
	|-ContractlessStandardResolver.GetFormatter<int>
	|
	|-RVA: 0x1811D20 Offset: 0x1811E21 VA: 0x1811D20
	|-ContractlessStandardResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1811DD0 Offset: 0x1811ED1 VA: 0x1811DD0
	|-ContractlessStandardResolver.GetFormatter<long>
	|
	|-RVA: 0x1811E80 Offset: 0x1811F81 VA: 0x1811E80
	|-ContractlessStandardResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1811F30 Offset: 0x1812031 VA: 0x1811F30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1811FE0 Offset: 0x18120E1 VA: 0x1811FE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1812090 Offset: 0x1812191 VA: 0x1812090
	|-ContractlessStandardResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1812140 Offset: 0x1812241 VA: 0x1812140
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x18121F0 Offset: 0x18122F1 VA: 0x18121F0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x18122A0 Offset: 0x18123A1 VA: 0x18122A0
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1812350 Offset: 0x1812451 VA: 0x1812350
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1812400 Offset: 0x1812501 VA: 0x1812400
	|-ContractlessStandardResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18124B0 Offset: 0x18125B1 VA: 0x18124B0
	|-ContractlessStandardResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1812560 Offset: 0x1812661 VA: 0x1812560
	|-ContractlessStandardResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1812610 Offset: 0x1812711 VA: 0x1812610
	|-ContractlessStandardResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18126C0 Offset: 0x18127C1 VA: 0x18126C0
	|-ContractlessStandardResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1812770 Offset: 0x1812871 VA: 0x1812770
	|-ContractlessStandardResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1812820 Offset: 0x1812921 VA: 0x1812820
	|-ContractlessStandardResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18128D0 Offset: 0x18129D1 VA: 0x18128D0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1812980 Offset: 0x1812A81 VA: 0x1812980
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1812A30 Offset: 0x1812B31 VA: 0x1812A30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1812AE0 Offset: 0x1812BE1 VA: 0x1812AE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1812B90 Offset: 0x1812C91 VA: 0x1812B90
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1812C40 Offset: 0x1812D41 VA: 0x1812C40
	|-ContractlessStandardResolver.GetFormatter<object>
	|
	|-RVA: 0x1812CF0 Offset: 0x1812DF1 VA: 0x1812CF0
	|-ContractlessStandardResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1812DA0 Offset: 0x1812EA1 VA: 0x1812DA0
	|-ContractlessStandardResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1812E50 Offset: 0x1812F51 VA: 0x1812E50
	|-ContractlessStandardResolver.GetFormatter<float>
	|
	|-RVA: 0x1812F00 Offset: 0x1813001 VA: 0x1812F00
	|-ContractlessStandardResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1812FB0 Offset: 0x18130B1 VA: 0x1812FB0
	|-ContractlessStandardResolver.GetFormatter<uint>
	|
	|-RVA: 0x1813060 Offset: 0x1813161 VA: 0x1813060
	|-ContractlessStandardResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1813110 Offset: 0x1813211 VA: 0x1813110
	|-ContractlessStandardResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x18131C0 Offset: 0x18132C1 VA: 0x18131C0
	|-ContractlessStandardResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1813270 Offset: 0x1813371 VA: 0x1813270
	|-ContractlessStandardResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1813320 Offset: 0x1813421 VA: 0x1813320
	|-ContractlessStandardResolver.GetFormatter<Color>
	|
	|-RVA: 0x18133D0 Offset: 0x18134D1 VA: 0x18133D0
	|-ContractlessStandardResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1813480 Offset: 0x1813581 VA: 0x1813480
	|-ContractlessStandardResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1813530 Offset: 0x1813631 VA: 0x1813530
	|-ContractlessStandardResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x18135E0 Offset: 0x18136E1 VA: 0x18135E0
	|-ContractlessStandardResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1813690 Offset: 0x1813791 VA: 0x1813690
	|-ContractlessStandardResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1813740 Offset: 0x1813841 VA: 0x1813740
	|-ContractlessStandardResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18137F0 Offset: 0x18138F1 VA: 0x18137F0
	|-ContractlessStandardResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18138A0 Offset: 0x18139A1 VA: 0x18138A0
	|-ContractlessStandardResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1813950 Offset: 0x1813A51 VA: 0x1813950
	|-ContractlessStandardResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1813A00 Offset: 0x1813B01 VA: 0x1813A00
	|-ContractlessStandardResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1813AB0 Offset: 0x1813BB1 VA: 0x1813AB0
	|-ContractlessStandardResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1813B60 Offset: 0x1813C61 VA: 0x1813B60
	|-ContractlessStandardResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1813C10 Offset: 0x1813D11 VA: 0x1813C10
	|-ContractlessStandardResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1813CC0 Offset: 0x1813DC1 VA: 0x1813CC0
	|-ContractlessStandardResolver.GetFormatter<Vector4>
	*/
}

public sealed class ContractlessStandardResolver : IFormatterResolver // TypeDefIndex: 5268
{
	// Fields
	public static readonly ContractlessStandardResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2750 Offset: 0x14F2851 VA: 0x14F2750
	private static void .cctor() { }

	// RVA: 0x14F2880 Offset: 0x14F2981 VA: 0x14F2880
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18110C0 Offset: 0x18111C1 VA: 0x18110C0
	|-ContractlessStandardResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1811170 Offset: 0x1811271 VA: 0x1811170
	|-ContractlessStandardResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1811220 Offset: 0x1811321 VA: 0x1811220
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x18112D0 Offset: 0x18113D1 VA: 0x18112D0
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1811380 Offset: 0x1811481 VA: 0x1811380
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1811430 Offset: 0x1811531 VA: 0x1811430
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x18114E0 Offset: 0x18115E1 VA: 0x18114E0
	|-ContractlessStandardResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1811590 Offset: 0x1811691 VA: 0x1811590
	|-ContractlessStandardResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1811640 Offset: 0x1811741 VA: 0x1811640
	|-ContractlessStandardResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18116F0 Offset: 0x18117F1 VA: 0x18116F0
	|-ContractlessStandardResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18117A0 Offset: 0x18118A1 VA: 0x18117A0
	|-ContractlessStandardResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1811850 Offset: 0x1811951 VA: 0x1811850
	|-ContractlessStandardResolver.GetFormatter<bool>
	|
	|-RVA: 0x1811900 Offset: 0x1811A01 VA: 0x1811900
	|-ContractlessStandardResolver.GetFormatter<byte>
	|
	|-RVA: 0x18119B0 Offset: 0x1811AB1 VA: 0x18119B0
	|-ContractlessStandardResolver.GetFormatter<char>
	|
	|-RVA: 0x1811A60 Offset: 0x1811B61 VA: 0x1811A60
	|-ContractlessStandardResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1811B10 Offset: 0x1811C11 VA: 0x1811B10
	|-ContractlessStandardResolver.GetFormatter<double>
	|
	|-RVA: 0x1811BC0 Offset: 0x1811CC1 VA: 0x1811BC0
	|-ContractlessStandardResolver.GetFormatter<short>
	|
	|-RVA: 0x1811C70 Offset: 0x1811D71 VA: 0x1811C70
	|-ContractlessStandardResolver.GetFormatter<int>
	|
	|-RVA: 0x1811D20 Offset: 0x1811E21 VA: 0x1811D20
	|-ContractlessStandardResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1811DD0 Offset: 0x1811ED1 VA: 0x1811DD0
	|-ContractlessStandardResolver.GetFormatter<long>
	|
	|-RVA: 0x1811E80 Offset: 0x1811F81 VA: 0x1811E80
	|-ContractlessStandardResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1811F30 Offset: 0x1812031 VA: 0x1811F30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1811FE0 Offset: 0x18120E1 VA: 0x1811FE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1812090 Offset: 0x1812191 VA: 0x1812090
	|-ContractlessStandardResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1812140 Offset: 0x1812241 VA: 0x1812140
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x18121F0 Offset: 0x18122F1 VA: 0x18121F0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x18122A0 Offset: 0x18123A1 VA: 0x18122A0
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1812350 Offset: 0x1812451 VA: 0x1812350
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1812400 Offset: 0x1812501 VA: 0x1812400
	|-ContractlessStandardResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18124B0 Offset: 0x18125B1 VA: 0x18124B0
	|-ContractlessStandardResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1812560 Offset: 0x1812661 VA: 0x1812560
	|-ContractlessStandardResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1812610 Offset: 0x1812711 VA: 0x1812610
	|-ContractlessStandardResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18126C0 Offset: 0x18127C1 VA: 0x18126C0
	|-ContractlessStandardResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1812770 Offset: 0x1812871 VA: 0x1812770
	|-ContractlessStandardResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1812820 Offset: 0x1812921 VA: 0x1812820
	|-ContractlessStandardResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18128D0 Offset: 0x18129D1 VA: 0x18128D0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1812980 Offset: 0x1812A81 VA: 0x1812980
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1812A30 Offset: 0x1812B31 VA: 0x1812A30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1812AE0 Offset: 0x1812BE1 VA: 0x1812AE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1812B90 Offset: 0x1812C91 VA: 0x1812B90
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1812C40 Offset: 0x1812D41 VA: 0x1812C40
	|-ContractlessStandardResolver.GetFormatter<object>
	|
	|-RVA: 0x1812CF0 Offset: 0x1812DF1 VA: 0x1812CF0
	|-ContractlessStandardResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1812DA0 Offset: 0x1812EA1 VA: 0x1812DA0
	|-ContractlessStandardResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1812E50 Offset: 0x1812F51 VA: 0x1812E50
	|-ContractlessStandardResolver.GetFormatter<float>
	|
	|-RVA: 0x1812F00 Offset: 0x1813001 VA: 0x1812F00
	|-ContractlessStandardResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1812FB0 Offset: 0x18130B1 VA: 0x1812FB0
	|-ContractlessStandardResolver.GetFormatter<uint>
	|
	|-RVA: 0x1813060 Offset: 0x1813161 VA: 0x1813060
	|-ContractlessStandardResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1813110 Offset: 0x1813211 VA: 0x1813110
	|-ContractlessStandardResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x18131C0 Offset: 0x18132C1 VA: 0x18131C0
	|-ContractlessStandardResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1813270 Offset: 0x1813371 VA: 0x1813270
	|-ContractlessStandardResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1813320 Offset: 0x1813421 VA: 0x1813320
	|-ContractlessStandardResolver.GetFormatter<Color>
	|
	|-RVA: 0x18133D0 Offset: 0x18134D1 VA: 0x18133D0
	|-ContractlessStandardResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1813480 Offset: 0x1813581 VA: 0x1813480
	|-ContractlessStandardResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1813530 Offset: 0x1813631 VA: 0x1813530
	|-ContractlessStandardResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x18135E0 Offset: 0x18136E1 VA: 0x18135E0
	|-ContractlessStandardResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1813690 Offset: 0x1813791 VA: 0x1813690
	|-ContractlessStandardResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1813740 Offset: 0x1813841 VA: 0x1813740
	|-ContractlessStandardResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18137F0 Offset: 0x18138F1 VA: 0x18137F0
	|-ContractlessStandardResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18138A0 Offset: 0x18139A1 VA: 0x18138A0
	|-ContractlessStandardResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1813950 Offset: 0x1813A51 VA: 0x1813950
	|-ContractlessStandardResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1813A00 Offset: 0x1813B01 VA: 0x1813A00
	|-ContractlessStandardResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1813AB0 Offset: 0x1813BB1 VA: 0x1813AB0
	|-ContractlessStandardResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1813B60 Offset: 0x1813C61 VA: 0x1813B60
	|-ContractlessStandardResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1813C10 Offset: 0x1813D11 VA: 0x1813C10
	|-ContractlessStandardResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1813CC0 Offset: 0x1813DC1 VA: 0x1813CC0
	|-ContractlessStandardResolver.GetFormatter<Vector4>
	*/
}

public sealed class ContractlessStandardResolver : IFormatterResolver // TypeDefIndex: 5268
{
	// Fields
	public static readonly ContractlessStandardResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2750 Offset: 0x14F2851 VA: 0x14F2750
	private static void .cctor() { }

	// RVA: 0x14F2880 Offset: 0x14F2981 VA: 0x14F2880
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18110C0 Offset: 0x18111C1 VA: 0x18110C0
	|-ContractlessStandardResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1811170 Offset: 0x1811271 VA: 0x1811170
	|-ContractlessStandardResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1811220 Offset: 0x1811321 VA: 0x1811220
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x18112D0 Offset: 0x18113D1 VA: 0x18112D0
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1811380 Offset: 0x1811481 VA: 0x1811380
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1811430 Offset: 0x1811531 VA: 0x1811430
	|-ContractlessStandardResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x18114E0 Offset: 0x18115E1 VA: 0x18114E0
	|-ContractlessStandardResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1811590 Offset: 0x1811691 VA: 0x1811590
	|-ContractlessStandardResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1811640 Offset: 0x1811741 VA: 0x1811640
	|-ContractlessStandardResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18116F0 Offset: 0x18117F1 VA: 0x18116F0
	|-ContractlessStandardResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18117A0 Offset: 0x18118A1 VA: 0x18117A0
	|-ContractlessStandardResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1811850 Offset: 0x1811951 VA: 0x1811850
	|-ContractlessStandardResolver.GetFormatter<bool>
	|
	|-RVA: 0x1811900 Offset: 0x1811A01 VA: 0x1811900
	|-ContractlessStandardResolver.GetFormatter<byte>
	|
	|-RVA: 0x18119B0 Offset: 0x1811AB1 VA: 0x18119B0
	|-ContractlessStandardResolver.GetFormatter<char>
	|
	|-RVA: 0x1811A60 Offset: 0x1811B61 VA: 0x1811A60
	|-ContractlessStandardResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1811B10 Offset: 0x1811C11 VA: 0x1811B10
	|-ContractlessStandardResolver.GetFormatter<double>
	|
	|-RVA: 0x1811BC0 Offset: 0x1811CC1 VA: 0x1811BC0
	|-ContractlessStandardResolver.GetFormatter<short>
	|
	|-RVA: 0x1811C70 Offset: 0x1811D71 VA: 0x1811C70
	|-ContractlessStandardResolver.GetFormatter<int>
	|
	|-RVA: 0x1811D20 Offset: 0x1811E21 VA: 0x1811D20
	|-ContractlessStandardResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1811DD0 Offset: 0x1811ED1 VA: 0x1811DD0
	|-ContractlessStandardResolver.GetFormatter<long>
	|
	|-RVA: 0x1811E80 Offset: 0x1811F81 VA: 0x1811E80
	|-ContractlessStandardResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1811F30 Offset: 0x1812031 VA: 0x1811F30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1811FE0 Offset: 0x18120E1 VA: 0x1811FE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1812090 Offset: 0x1812191 VA: 0x1812090
	|-ContractlessStandardResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1812140 Offset: 0x1812241 VA: 0x1812140
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x18121F0 Offset: 0x18122F1 VA: 0x18121F0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x18122A0 Offset: 0x18123A1 VA: 0x18122A0
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1812350 Offset: 0x1812451 VA: 0x1812350
	|-ContractlessStandardResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1812400 Offset: 0x1812501 VA: 0x1812400
	|-ContractlessStandardResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18124B0 Offset: 0x18125B1 VA: 0x18124B0
	|-ContractlessStandardResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1812560 Offset: 0x1812661 VA: 0x1812560
	|-ContractlessStandardResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1812610 Offset: 0x1812711 VA: 0x1812610
	|-ContractlessStandardResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18126C0 Offset: 0x18127C1 VA: 0x18126C0
	|-ContractlessStandardResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1812770 Offset: 0x1812871 VA: 0x1812770
	|-ContractlessStandardResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1812820 Offset: 0x1812921 VA: 0x1812820
	|-ContractlessStandardResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18128D0 Offset: 0x18129D1 VA: 0x18128D0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1812980 Offset: 0x1812A81 VA: 0x1812980
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1812A30 Offset: 0x1812B31 VA: 0x1812A30
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1812AE0 Offset: 0x1812BE1 VA: 0x1812AE0
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1812B90 Offset: 0x1812C91 VA: 0x1812B90
	|-ContractlessStandardResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1812C40 Offset: 0x1812D41 VA: 0x1812C40
	|-ContractlessStandardResolver.GetFormatter<object>
	|
	|-RVA: 0x1812CF0 Offset: 0x1812DF1 VA: 0x1812CF0
	|-ContractlessStandardResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1812DA0 Offset: 0x1812EA1 VA: 0x1812DA0
	|-ContractlessStandardResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1812E50 Offset: 0x1812F51 VA: 0x1812E50
	|-ContractlessStandardResolver.GetFormatter<float>
	|
	|-RVA: 0x1812F00 Offset: 0x1813001 VA: 0x1812F00
	|-ContractlessStandardResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1812FB0 Offset: 0x18130B1 VA: 0x1812FB0
	|-ContractlessStandardResolver.GetFormatter<uint>
	|
	|-RVA: 0x1813060 Offset: 0x1813161 VA: 0x1813060
	|-ContractlessStandardResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1813110 Offset: 0x1813211 VA: 0x1813110
	|-ContractlessStandardResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x18131C0 Offset: 0x18132C1 VA: 0x18131C0
	|-ContractlessStandardResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1813270 Offset: 0x1813371 VA: 0x1813270
	|-ContractlessStandardResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1813320 Offset: 0x1813421 VA: 0x1813320
	|-ContractlessStandardResolver.GetFormatter<Color>
	|
	|-RVA: 0x18133D0 Offset: 0x18134D1 VA: 0x18133D0
	|-ContractlessStandardResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1813480 Offset: 0x1813581 VA: 0x1813480
	|-ContractlessStandardResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1813530 Offset: 0x1813631 VA: 0x1813530
	|-ContractlessStandardResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x18135E0 Offset: 0x18136E1 VA: 0x18135E0
	|-ContractlessStandardResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1813690 Offset: 0x1813791 VA: 0x1813690
	|-ContractlessStandardResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1813740 Offset: 0x1813841 VA: 0x1813740
	|-ContractlessStandardResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18137F0 Offset: 0x18138F1 VA: 0x18137F0
	|-ContractlessStandardResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18138A0 Offset: 0x18139A1 VA: 0x18138A0
	|-ContractlessStandardResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1813950 Offset: 0x1813A51 VA: 0x1813950
	|-ContractlessStandardResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1813A00 Offset: 0x1813B01 VA: 0x1813A00
	|-ContractlessStandardResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1813AB0 Offset: 0x1813BB1 VA: 0x1813AB0
	|-ContractlessStandardResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1813B60 Offset: 0x1813C61 VA: 0x1813B60
	|-ContractlessStandardResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1813C10 Offset: 0x1813D11 VA: 0x1813C10
	|-ContractlessStandardResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1813CC0 Offset: 0x1813DC1 VA: 0x1813CC0
	|-ContractlessStandardResolver.GetFormatter<Vector4>
	*/
}

