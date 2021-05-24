public sealed class DynamicObjectResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5241
{
	// Fields
	public static readonly DynamicObjectResolverAllowPrivate Instance; // 0x0

	// Methods

	// RVA: 0x14F3DA0 Offset: 0x14F3EA1 VA: 0x14F3DA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1827640 Offset: 0x1827741 VA: 0x1827640
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x18276F0 Offset: 0x18277F1 VA: 0x18276F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x18277A0 Offset: 0x18278A1 VA: 0x18277A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1827850 Offset: 0x1827951 VA: 0x1827850
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1827900 Offset: 0x1827A01 VA: 0x1827900
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18279B0 Offset: 0x1827AB1 VA: 0x18279B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1827A60 Offset: 0x1827B61 VA: 0x1827A60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1827B10 Offset: 0x1827C11 VA: 0x1827B10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1827BC0 Offset: 0x1827CC1 VA: 0x1827BC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1827C70 Offset: 0x1827D71 VA: 0x1827C70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1827D20 Offset: 0x1827E21 VA: 0x1827D20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1827DD0 Offset: 0x1827ED1 VA: 0x1827DD0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x1827E80 Offset: 0x1827F81 VA: 0x1827E80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1827F30 Offset: 0x1828031 VA: 0x1827F30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1827FE0 Offset: 0x18280E1 VA: 0x1827FE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x1828090 Offset: 0x1828191 VA: 0x1828090
	|-DynamicObjectResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1828140 Offset: 0x1828241 VA: 0x1828140
	|-DynamicObjectResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x18281F0 Offset: 0x18282F1 VA: 0x18281F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18282A0 Offset: 0x18283A1 VA: 0x18282A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1828350 Offset: 0x1828451 VA: 0x1828350
	|-DynamicObjectResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1828400 Offset: 0x1828501 VA: 0x1828400
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x18284B0 Offset: 0x18285B1 VA: 0x18284B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1828560 Offset: 0x1828661 VA: 0x1828560
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1828610 Offset: 0x1828711 VA: 0x1828610
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x18286C0 Offset: 0x18287C1 VA: 0x18286C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1828770 Offset: 0x1828871 VA: 0x1828770
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1828820 Offset: 0x1828921 VA: 0x1828820
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x18288D0 Offset: 0x18289D1 VA: 0x18288D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1828980 Offset: 0x1828A81 VA: 0x1828980
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1828A30 Offset: 0x1828B31 VA: 0x1828A30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1828AE0 Offset: 0x1828BE1 VA: 0x1828AE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1828B90 Offset: 0x1828C91 VA: 0x1828B90
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1828C40 Offset: 0x1828D41 VA: 0x1828C40
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1828CF0 Offset: 0x1828DF1 VA: 0x1828CF0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1828DA0 Offset: 0x1828EA1 VA: 0x1828DA0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1828E50 Offset: 0x1828F51 VA: 0x1828E50
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1828F00 Offset: 0x1829001 VA: 0x1828F00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1828FB0 Offset: 0x18290B1 VA: 0x1828FB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1829060 Offset: 0x1829161 VA: 0x1829060
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1829110 Offset: 0x1829211 VA: 0x1829110
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18291C0 Offset: 0x18292C1 VA: 0x18291C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x1829270 Offset: 0x1829371 VA: 0x1829270
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1829320 Offset: 0x1829421 VA: 0x1829320
	|-DynamicObjectResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x18293D0 Offset: 0x18294D1 VA: 0x18293D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1829480 Offset: 0x1829581 VA: 0x1829480
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1829530 Offset: 0x1829631 VA: 0x1829530
	|-DynamicObjectResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x18295E0 Offset: 0x18296E1 VA: 0x18295E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1829690 Offset: 0x1829791 VA: 0x1829690
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1829740 Offset: 0x1829841 VA: 0x1829740
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x18297F0 Offset: 0x18298F1 VA: 0x18297F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x18298A0 Offset: 0x18299A1 VA: 0x18298A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1829950 Offset: 0x1829A51 VA: 0x1829950
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1829A00 Offset: 0x1829B01 VA: 0x1829A00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1829AB0 Offset: 0x1829BB1 VA: 0x1829AB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1829B60 Offset: 0x1829C61 VA: 0x1829B60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1829C10 Offset: 0x1829D11 VA: 0x1829C10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1829CC0 Offset: 0x1829DC1 VA: 0x1829CC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x1829D70 Offset: 0x1829E71 VA: 0x1829D70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1829E20 Offset: 0x1829F21 VA: 0x1829E20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1829ED0 Offset: 0x1829FD1 VA: 0x1829ED0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x1829F80 Offset: 0x182A081 VA: 0x1829F80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x182A030 Offset: 0x182A131 VA: 0x182A030
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x182A0E0 Offset: 0x182A1E1 VA: 0x182A0E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x182A190 Offset: 0x182A291 VA: 0x182A190
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x182A240 Offset: 0x182A341 VA: 0x182A240
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3DB0 Offset: 0x14F3EB1 VA: 0x14F3DB0
	private static void .cctor() { }
}

public sealed class DynamicObjectResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5241
{
	// Fields
	public static readonly DynamicObjectResolverAllowPrivate Instance; // 0x0

	// Methods

	// RVA: 0x14F3DA0 Offset: 0x14F3EA1 VA: 0x14F3DA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1827640 Offset: 0x1827741 VA: 0x1827640
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x18276F0 Offset: 0x18277F1 VA: 0x18276F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x18277A0 Offset: 0x18278A1 VA: 0x18277A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1827850 Offset: 0x1827951 VA: 0x1827850
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1827900 Offset: 0x1827A01 VA: 0x1827900
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18279B0 Offset: 0x1827AB1 VA: 0x18279B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1827A60 Offset: 0x1827B61 VA: 0x1827A60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1827B10 Offset: 0x1827C11 VA: 0x1827B10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1827BC0 Offset: 0x1827CC1 VA: 0x1827BC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1827C70 Offset: 0x1827D71 VA: 0x1827C70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1827D20 Offset: 0x1827E21 VA: 0x1827D20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1827DD0 Offset: 0x1827ED1 VA: 0x1827DD0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x1827E80 Offset: 0x1827F81 VA: 0x1827E80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1827F30 Offset: 0x1828031 VA: 0x1827F30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1827FE0 Offset: 0x18280E1 VA: 0x1827FE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x1828090 Offset: 0x1828191 VA: 0x1828090
	|-DynamicObjectResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1828140 Offset: 0x1828241 VA: 0x1828140
	|-DynamicObjectResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x18281F0 Offset: 0x18282F1 VA: 0x18281F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18282A0 Offset: 0x18283A1 VA: 0x18282A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1828350 Offset: 0x1828451 VA: 0x1828350
	|-DynamicObjectResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1828400 Offset: 0x1828501 VA: 0x1828400
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x18284B0 Offset: 0x18285B1 VA: 0x18284B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1828560 Offset: 0x1828661 VA: 0x1828560
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1828610 Offset: 0x1828711 VA: 0x1828610
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x18286C0 Offset: 0x18287C1 VA: 0x18286C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1828770 Offset: 0x1828871 VA: 0x1828770
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1828820 Offset: 0x1828921 VA: 0x1828820
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x18288D0 Offset: 0x18289D1 VA: 0x18288D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1828980 Offset: 0x1828A81 VA: 0x1828980
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1828A30 Offset: 0x1828B31 VA: 0x1828A30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1828AE0 Offset: 0x1828BE1 VA: 0x1828AE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1828B90 Offset: 0x1828C91 VA: 0x1828B90
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1828C40 Offset: 0x1828D41 VA: 0x1828C40
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1828CF0 Offset: 0x1828DF1 VA: 0x1828CF0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1828DA0 Offset: 0x1828EA1 VA: 0x1828DA0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1828E50 Offset: 0x1828F51 VA: 0x1828E50
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1828F00 Offset: 0x1829001 VA: 0x1828F00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1828FB0 Offset: 0x18290B1 VA: 0x1828FB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1829060 Offset: 0x1829161 VA: 0x1829060
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1829110 Offset: 0x1829211 VA: 0x1829110
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18291C0 Offset: 0x18292C1 VA: 0x18291C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x1829270 Offset: 0x1829371 VA: 0x1829270
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1829320 Offset: 0x1829421 VA: 0x1829320
	|-DynamicObjectResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x18293D0 Offset: 0x18294D1 VA: 0x18293D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1829480 Offset: 0x1829581 VA: 0x1829480
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1829530 Offset: 0x1829631 VA: 0x1829530
	|-DynamicObjectResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x18295E0 Offset: 0x18296E1 VA: 0x18295E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1829690 Offset: 0x1829791 VA: 0x1829690
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1829740 Offset: 0x1829841 VA: 0x1829740
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x18297F0 Offset: 0x18298F1 VA: 0x18297F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x18298A0 Offset: 0x18299A1 VA: 0x18298A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1829950 Offset: 0x1829A51 VA: 0x1829950
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1829A00 Offset: 0x1829B01 VA: 0x1829A00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1829AB0 Offset: 0x1829BB1 VA: 0x1829AB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1829B60 Offset: 0x1829C61 VA: 0x1829B60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1829C10 Offset: 0x1829D11 VA: 0x1829C10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1829CC0 Offset: 0x1829DC1 VA: 0x1829CC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x1829D70 Offset: 0x1829E71 VA: 0x1829D70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1829E20 Offset: 0x1829F21 VA: 0x1829E20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1829ED0 Offset: 0x1829FD1 VA: 0x1829ED0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x1829F80 Offset: 0x182A081 VA: 0x1829F80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x182A030 Offset: 0x182A131 VA: 0x182A030
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x182A0E0 Offset: 0x182A1E1 VA: 0x182A0E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x182A190 Offset: 0x182A291 VA: 0x182A190
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x182A240 Offset: 0x182A341 VA: 0x182A240
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3DB0 Offset: 0x14F3EB1 VA: 0x14F3DB0
	private static void .cctor() { }
}

public sealed class DynamicObjectResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5241
{
	// Fields
	public static readonly DynamicObjectResolverAllowPrivate Instance; // 0x0

	// Methods

	// RVA: 0x14F3DA0 Offset: 0x14F3EA1 VA: 0x14F3DA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1827640 Offset: 0x1827741 VA: 0x1827640
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x18276F0 Offset: 0x18277F1 VA: 0x18276F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x18277A0 Offset: 0x18278A1 VA: 0x18277A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1827850 Offset: 0x1827951 VA: 0x1827850
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1827900 Offset: 0x1827A01 VA: 0x1827900
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18279B0 Offset: 0x1827AB1 VA: 0x18279B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1827A60 Offset: 0x1827B61 VA: 0x1827A60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1827B10 Offset: 0x1827C11 VA: 0x1827B10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1827BC0 Offset: 0x1827CC1 VA: 0x1827BC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1827C70 Offset: 0x1827D71 VA: 0x1827C70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1827D20 Offset: 0x1827E21 VA: 0x1827D20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1827DD0 Offset: 0x1827ED1 VA: 0x1827DD0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x1827E80 Offset: 0x1827F81 VA: 0x1827E80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1827F30 Offset: 0x1828031 VA: 0x1827F30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1827FE0 Offset: 0x18280E1 VA: 0x1827FE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x1828090 Offset: 0x1828191 VA: 0x1828090
	|-DynamicObjectResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1828140 Offset: 0x1828241 VA: 0x1828140
	|-DynamicObjectResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x18281F0 Offset: 0x18282F1 VA: 0x18281F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18282A0 Offset: 0x18283A1 VA: 0x18282A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1828350 Offset: 0x1828451 VA: 0x1828350
	|-DynamicObjectResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1828400 Offset: 0x1828501 VA: 0x1828400
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x18284B0 Offset: 0x18285B1 VA: 0x18284B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1828560 Offset: 0x1828661 VA: 0x1828560
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1828610 Offset: 0x1828711 VA: 0x1828610
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x18286C0 Offset: 0x18287C1 VA: 0x18286C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1828770 Offset: 0x1828871 VA: 0x1828770
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1828820 Offset: 0x1828921 VA: 0x1828820
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x18288D0 Offset: 0x18289D1 VA: 0x18288D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1828980 Offset: 0x1828A81 VA: 0x1828980
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1828A30 Offset: 0x1828B31 VA: 0x1828A30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1828AE0 Offset: 0x1828BE1 VA: 0x1828AE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1828B90 Offset: 0x1828C91 VA: 0x1828B90
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1828C40 Offset: 0x1828D41 VA: 0x1828C40
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1828CF0 Offset: 0x1828DF1 VA: 0x1828CF0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1828DA0 Offset: 0x1828EA1 VA: 0x1828DA0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1828E50 Offset: 0x1828F51 VA: 0x1828E50
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1828F00 Offset: 0x1829001 VA: 0x1828F00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1828FB0 Offset: 0x18290B1 VA: 0x1828FB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1829060 Offset: 0x1829161 VA: 0x1829060
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1829110 Offset: 0x1829211 VA: 0x1829110
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18291C0 Offset: 0x18292C1 VA: 0x18291C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x1829270 Offset: 0x1829371 VA: 0x1829270
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1829320 Offset: 0x1829421 VA: 0x1829320
	|-DynamicObjectResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x18293D0 Offset: 0x18294D1 VA: 0x18293D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1829480 Offset: 0x1829581 VA: 0x1829480
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1829530 Offset: 0x1829631 VA: 0x1829530
	|-DynamicObjectResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x18295E0 Offset: 0x18296E1 VA: 0x18295E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1829690 Offset: 0x1829791 VA: 0x1829690
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1829740 Offset: 0x1829841 VA: 0x1829740
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x18297F0 Offset: 0x18298F1 VA: 0x18297F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x18298A0 Offset: 0x18299A1 VA: 0x18298A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1829950 Offset: 0x1829A51 VA: 0x1829950
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1829A00 Offset: 0x1829B01 VA: 0x1829A00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1829AB0 Offset: 0x1829BB1 VA: 0x1829AB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1829B60 Offset: 0x1829C61 VA: 0x1829B60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1829C10 Offset: 0x1829D11 VA: 0x1829C10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1829CC0 Offset: 0x1829DC1 VA: 0x1829CC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x1829D70 Offset: 0x1829E71 VA: 0x1829D70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1829E20 Offset: 0x1829F21 VA: 0x1829E20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1829ED0 Offset: 0x1829FD1 VA: 0x1829ED0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x1829F80 Offset: 0x182A081 VA: 0x1829F80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x182A030 Offset: 0x182A131 VA: 0x182A030
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x182A0E0 Offset: 0x182A1E1 VA: 0x182A0E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x182A190 Offset: 0x182A291 VA: 0x182A190
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x182A240 Offset: 0x182A341 VA: 0x182A240
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3DB0 Offset: 0x14F3EB1 VA: 0x14F3DB0
	private static void .cctor() { }
}

public sealed class DynamicObjectResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5241
{
	// Fields
	public static readonly DynamicObjectResolverAllowPrivate Instance; // 0x0

	// Methods

	// RVA: 0x14F3DA0 Offset: 0x14F3EA1 VA: 0x14F3DA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1827640 Offset: 0x1827741 VA: 0x1827640
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x18276F0 Offset: 0x18277F1 VA: 0x18276F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x18277A0 Offset: 0x18278A1 VA: 0x18277A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1827850 Offset: 0x1827951 VA: 0x1827850
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1827900 Offset: 0x1827A01 VA: 0x1827900
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18279B0 Offset: 0x1827AB1 VA: 0x18279B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1827A60 Offset: 0x1827B61 VA: 0x1827A60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1827B10 Offset: 0x1827C11 VA: 0x1827B10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1827BC0 Offset: 0x1827CC1 VA: 0x1827BC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1827C70 Offset: 0x1827D71 VA: 0x1827C70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1827D20 Offset: 0x1827E21 VA: 0x1827D20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1827DD0 Offset: 0x1827ED1 VA: 0x1827DD0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x1827E80 Offset: 0x1827F81 VA: 0x1827E80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1827F30 Offset: 0x1828031 VA: 0x1827F30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1827FE0 Offset: 0x18280E1 VA: 0x1827FE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x1828090 Offset: 0x1828191 VA: 0x1828090
	|-DynamicObjectResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1828140 Offset: 0x1828241 VA: 0x1828140
	|-DynamicObjectResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x18281F0 Offset: 0x18282F1 VA: 0x18281F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18282A0 Offset: 0x18283A1 VA: 0x18282A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1828350 Offset: 0x1828451 VA: 0x1828350
	|-DynamicObjectResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1828400 Offset: 0x1828501 VA: 0x1828400
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x18284B0 Offset: 0x18285B1 VA: 0x18284B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1828560 Offset: 0x1828661 VA: 0x1828560
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1828610 Offset: 0x1828711 VA: 0x1828610
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x18286C0 Offset: 0x18287C1 VA: 0x18286C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1828770 Offset: 0x1828871 VA: 0x1828770
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1828820 Offset: 0x1828921 VA: 0x1828820
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x18288D0 Offset: 0x18289D1 VA: 0x18288D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1828980 Offset: 0x1828A81 VA: 0x1828980
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1828A30 Offset: 0x1828B31 VA: 0x1828A30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1828AE0 Offset: 0x1828BE1 VA: 0x1828AE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1828B90 Offset: 0x1828C91 VA: 0x1828B90
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1828C40 Offset: 0x1828D41 VA: 0x1828C40
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1828CF0 Offset: 0x1828DF1 VA: 0x1828CF0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1828DA0 Offset: 0x1828EA1 VA: 0x1828DA0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1828E50 Offset: 0x1828F51 VA: 0x1828E50
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1828F00 Offset: 0x1829001 VA: 0x1828F00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1828FB0 Offset: 0x18290B1 VA: 0x1828FB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1829060 Offset: 0x1829161 VA: 0x1829060
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1829110 Offset: 0x1829211 VA: 0x1829110
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18291C0 Offset: 0x18292C1 VA: 0x18291C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x1829270 Offset: 0x1829371 VA: 0x1829270
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1829320 Offset: 0x1829421 VA: 0x1829320
	|-DynamicObjectResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x18293D0 Offset: 0x18294D1 VA: 0x18293D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1829480 Offset: 0x1829581 VA: 0x1829480
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1829530 Offset: 0x1829631 VA: 0x1829530
	|-DynamicObjectResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x18295E0 Offset: 0x18296E1 VA: 0x18295E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1829690 Offset: 0x1829791 VA: 0x1829690
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1829740 Offset: 0x1829841 VA: 0x1829740
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x18297F0 Offset: 0x18298F1 VA: 0x18297F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x18298A0 Offset: 0x18299A1 VA: 0x18298A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1829950 Offset: 0x1829A51 VA: 0x1829950
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1829A00 Offset: 0x1829B01 VA: 0x1829A00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1829AB0 Offset: 0x1829BB1 VA: 0x1829AB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1829B60 Offset: 0x1829C61 VA: 0x1829B60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1829C10 Offset: 0x1829D11 VA: 0x1829C10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1829CC0 Offset: 0x1829DC1 VA: 0x1829CC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x1829D70 Offset: 0x1829E71 VA: 0x1829D70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1829E20 Offset: 0x1829F21 VA: 0x1829E20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1829ED0 Offset: 0x1829FD1 VA: 0x1829ED0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x1829F80 Offset: 0x182A081 VA: 0x1829F80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x182A030 Offset: 0x182A131 VA: 0x182A030
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x182A0E0 Offset: 0x182A1E1 VA: 0x182A0E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x182A190 Offset: 0x182A291 VA: 0x182A190
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x182A240 Offset: 0x182A341 VA: 0x182A240
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3DB0 Offset: 0x14F3EB1 VA: 0x14F3DB0
	private static void .cctor() { }
}

public sealed class DynamicObjectResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5241
{
	// Fields
	public static readonly DynamicObjectResolverAllowPrivate Instance; // 0x0

	// Methods

	// RVA: 0x14F3DA0 Offset: 0x14F3EA1 VA: 0x14F3DA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1827640 Offset: 0x1827741 VA: 0x1827640
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x18276F0 Offset: 0x18277F1 VA: 0x18276F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x18277A0 Offset: 0x18278A1 VA: 0x18277A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1827850 Offset: 0x1827951 VA: 0x1827850
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1827900 Offset: 0x1827A01 VA: 0x1827900
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18279B0 Offset: 0x1827AB1 VA: 0x18279B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1827A60 Offset: 0x1827B61 VA: 0x1827A60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1827B10 Offset: 0x1827C11 VA: 0x1827B10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1827BC0 Offset: 0x1827CC1 VA: 0x1827BC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1827C70 Offset: 0x1827D71 VA: 0x1827C70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1827D20 Offset: 0x1827E21 VA: 0x1827D20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1827DD0 Offset: 0x1827ED1 VA: 0x1827DD0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x1827E80 Offset: 0x1827F81 VA: 0x1827E80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1827F30 Offset: 0x1828031 VA: 0x1827F30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1827FE0 Offset: 0x18280E1 VA: 0x1827FE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x1828090 Offset: 0x1828191 VA: 0x1828090
	|-DynamicObjectResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1828140 Offset: 0x1828241 VA: 0x1828140
	|-DynamicObjectResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x18281F0 Offset: 0x18282F1 VA: 0x18281F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18282A0 Offset: 0x18283A1 VA: 0x18282A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1828350 Offset: 0x1828451 VA: 0x1828350
	|-DynamicObjectResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1828400 Offset: 0x1828501 VA: 0x1828400
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x18284B0 Offset: 0x18285B1 VA: 0x18284B0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1828560 Offset: 0x1828661 VA: 0x1828560
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1828610 Offset: 0x1828711 VA: 0x1828610
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x18286C0 Offset: 0x18287C1 VA: 0x18286C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1828770 Offset: 0x1828871 VA: 0x1828770
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1828820 Offset: 0x1828921 VA: 0x1828820
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x18288D0 Offset: 0x18289D1 VA: 0x18288D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1828980 Offset: 0x1828A81 VA: 0x1828980
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1828A30 Offset: 0x1828B31 VA: 0x1828A30
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1828AE0 Offset: 0x1828BE1 VA: 0x1828AE0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1828B90 Offset: 0x1828C91 VA: 0x1828B90
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1828C40 Offset: 0x1828D41 VA: 0x1828C40
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1828CF0 Offset: 0x1828DF1 VA: 0x1828CF0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1828DA0 Offset: 0x1828EA1 VA: 0x1828DA0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1828E50 Offset: 0x1828F51 VA: 0x1828E50
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1828F00 Offset: 0x1829001 VA: 0x1828F00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1828FB0 Offset: 0x18290B1 VA: 0x1828FB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1829060 Offset: 0x1829161 VA: 0x1829060
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1829110 Offset: 0x1829211 VA: 0x1829110
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18291C0 Offset: 0x18292C1 VA: 0x18291C0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x1829270 Offset: 0x1829371 VA: 0x1829270
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1829320 Offset: 0x1829421 VA: 0x1829320
	|-DynamicObjectResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x18293D0 Offset: 0x18294D1 VA: 0x18293D0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1829480 Offset: 0x1829581 VA: 0x1829480
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1829530 Offset: 0x1829631 VA: 0x1829530
	|-DynamicObjectResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x18295E0 Offset: 0x18296E1 VA: 0x18295E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1829690 Offset: 0x1829791 VA: 0x1829690
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1829740 Offset: 0x1829841 VA: 0x1829740
	|-DynamicObjectResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x18297F0 Offset: 0x18298F1 VA: 0x18297F0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x18298A0 Offset: 0x18299A1 VA: 0x18298A0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1829950 Offset: 0x1829A51 VA: 0x1829950
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1829A00 Offset: 0x1829B01 VA: 0x1829A00
	|-DynamicObjectResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1829AB0 Offset: 0x1829BB1 VA: 0x1829AB0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1829B60 Offset: 0x1829C61 VA: 0x1829B60
	|-DynamicObjectResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1829C10 Offset: 0x1829D11 VA: 0x1829C10
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1829CC0 Offset: 0x1829DC1 VA: 0x1829CC0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x1829D70 Offset: 0x1829E71 VA: 0x1829D70
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1829E20 Offset: 0x1829F21 VA: 0x1829E20
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1829ED0 Offset: 0x1829FD1 VA: 0x1829ED0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x1829F80 Offset: 0x182A081 VA: 0x1829F80
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x182A030 Offset: 0x182A131 VA: 0x182A030
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x182A0E0 Offset: 0x182A1E1 VA: 0x182A0E0
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x182A190 Offset: 0x182A291 VA: 0x182A190
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x182A240 Offset: 0x182A341 VA: 0x182A240
	|-DynamicObjectResolverAllowPrivate.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3DB0 Offset: 0x14F3EB1 VA: 0x14F3DB0
	private static void .cctor() { }
}

