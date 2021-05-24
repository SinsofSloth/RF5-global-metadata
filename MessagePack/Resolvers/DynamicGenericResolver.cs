public sealed class DynamicGenericResolver : IFormatterResolver // TypeDefIndex: 5236
{
	// Fields
	public static readonly DynamicGenericResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F3AD0 Offset: 0x14F3BD1 VA: 0x14F3AD0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821CE0 Offset: 0x1821DE1 VA: 0x1821CE0
	|-DynamicGenericResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1821D90 Offset: 0x1821E91 VA: 0x1821D90
	|-DynamicGenericResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1821E40 Offset: 0x1821F41 VA: 0x1821E40
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1821EF0 Offset: 0x1821FF1 VA: 0x1821EF0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1821FA0 Offset: 0x18220A1 VA: 0x1821FA0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1822050 Offset: 0x1822151 VA: 0x1822050
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1822100 Offset: 0x1822201 VA: 0x1822100
	|-DynamicGenericResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x18221B0 Offset: 0x18222B1 VA: 0x18221B0
	|-DynamicGenericResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1822260 Offset: 0x1822361 VA: 0x1822260
	|-DynamicGenericResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1822310 Offset: 0x1822411 VA: 0x1822310
	|-DynamicGenericResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18223C0 Offset: 0x18224C1 VA: 0x18223C0
	|-DynamicGenericResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1822470 Offset: 0x1822571 VA: 0x1822470
	|-DynamicGenericResolver.GetFormatter<bool>
	|
	|-RVA: 0x1822520 Offset: 0x1822621 VA: 0x1822520
	|-DynamicGenericResolver.GetFormatter<byte>
	|
	|-RVA: 0x18225D0 Offset: 0x18226D1 VA: 0x18225D0
	|-DynamicGenericResolver.GetFormatter<char>
	|
	|-RVA: 0x1822680 Offset: 0x1822781 VA: 0x1822680
	|-DynamicGenericResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1822730 Offset: 0x1822831 VA: 0x1822730
	|-DynamicGenericResolver.GetFormatter<double>
	|
	|-RVA: 0x18227E0 Offset: 0x18228E1 VA: 0x18227E0
	|-DynamicGenericResolver.GetFormatter<short>
	|
	|-RVA: 0x1822890 Offset: 0x1822991 VA: 0x1822890
	|-DynamicGenericResolver.GetFormatter<int>
	|
	|-RVA: 0x1822940 Offset: 0x1822A41 VA: 0x1822940
	|-DynamicGenericResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18229F0 Offset: 0x1822AF1 VA: 0x18229F0
	|-DynamicGenericResolver.GetFormatter<long>
	|
	|-RVA: 0x1822AA0 Offset: 0x1822BA1 VA: 0x1822AA0
	|-DynamicGenericResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1822B50 Offset: 0x1822C51 VA: 0x1822B50
	|-DynamicGenericResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1822C00 Offset: 0x1822D01 VA: 0x1822C00
	|-DynamicGenericResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1822CB0 Offset: 0x1822DB1 VA: 0x1822CB0
	|-DynamicGenericResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1822D60 Offset: 0x1822E61 VA: 0x1822D60
	|-DynamicGenericResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1822E10 Offset: 0x1822F11 VA: 0x1822E10
	|-DynamicGenericResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1822EC0 Offset: 0x1822FC1 VA: 0x1822EC0
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1822F70 Offset: 0x1823071 VA: 0x1822F70
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1823020 Offset: 0x1823121 VA: 0x1823020
	|-DynamicGenericResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18230D0 Offset: 0x18231D1 VA: 0x18230D0
	|-DynamicGenericResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1823180 Offset: 0x1823281 VA: 0x1823180
	|-DynamicGenericResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1823230 Offset: 0x1823331 VA: 0x1823230
	|-DynamicGenericResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18232E0 Offset: 0x18233E1 VA: 0x18232E0
	|-DynamicGenericResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1823390 Offset: 0x1823491 VA: 0x1823390
	|-DynamicGenericResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1823440 Offset: 0x1823541 VA: 0x1823440
	|-DynamicGenericResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18234F0 Offset: 0x18235F1 VA: 0x18234F0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18235A0 Offset: 0x18236A1 VA: 0x18235A0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1823650 Offset: 0x1823751 VA: 0x1823650
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1823700 Offset: 0x1823801 VA: 0x1823700
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18237B0 Offset: 0x18238B1 VA: 0x18237B0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1823860 Offset: 0x1823961 VA: 0x1823860
	|-DynamicGenericResolver.GetFormatter<object>
	|
	|-RVA: 0x1823910 Offset: 0x1823A11 VA: 0x1823910
	|-DynamicGenericResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x18239C0 Offset: 0x1823AC1 VA: 0x18239C0
	|-DynamicGenericResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1823A70 Offset: 0x1823B71 VA: 0x1823A70
	|-DynamicGenericResolver.GetFormatter<float>
	|
	|-RVA: 0x1823B20 Offset: 0x1823C21 VA: 0x1823B20
	|-DynamicGenericResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1823BD0 Offset: 0x1823CD1 VA: 0x1823BD0
	|-DynamicGenericResolver.GetFormatter<uint>
	|
	|-RVA: 0x1823C80 Offset: 0x1823D81 VA: 0x1823C80
	|-DynamicGenericResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1823D30 Offset: 0x1823E31 VA: 0x1823D30
	|-DynamicGenericResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1823DE0 Offset: 0x1823EE1 VA: 0x1823DE0
	|-DynamicGenericResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1823E90 Offset: 0x1823F91 VA: 0x1823E90
	|-DynamicGenericResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1823F40 Offset: 0x1824041 VA: 0x1823F40
	|-DynamicGenericResolver.GetFormatter<Color>
	|
	|-RVA: 0x1823FF0 Offset: 0x18240F1 VA: 0x1823FF0
	|-DynamicGenericResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x18240A0 Offset: 0x18241A1 VA: 0x18240A0
	|-DynamicGenericResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1824150 Offset: 0x1824251 VA: 0x1824150
	|-DynamicGenericResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1824200 Offset: 0x1824301 VA: 0x1824200
	|-DynamicGenericResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x18242B0 Offset: 0x18243B1 VA: 0x18242B0
	|-DynamicGenericResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1824360 Offset: 0x1824461 VA: 0x1824360
	|-DynamicGenericResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1824410 Offset: 0x1824511 VA: 0x1824410
	|-DynamicGenericResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18244C0 Offset: 0x18245C1 VA: 0x18244C0
	|-DynamicGenericResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1824570 Offset: 0x1824671 VA: 0x1824570
	|-DynamicGenericResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1824620 Offset: 0x1824721 VA: 0x1824620
	|-DynamicGenericResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x18246D0 Offset: 0x18247D1 VA: 0x18246D0
	|-DynamicGenericResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1824780 Offset: 0x1824881 VA: 0x1824780
	|-DynamicGenericResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1824830 Offset: 0x1824931 VA: 0x1824830
	|-DynamicGenericResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x18248E0 Offset: 0x18249E1 VA: 0x18248E0
	|-DynamicGenericResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3AE0 Offset: 0x14F3BE1 VA: 0x14F3AE0
	private static void .cctor() { }
}

public sealed class DynamicGenericResolver : IFormatterResolver // TypeDefIndex: 5236
{
	// Fields
	public static readonly DynamicGenericResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F3AD0 Offset: 0x14F3BD1 VA: 0x14F3AD0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821CE0 Offset: 0x1821DE1 VA: 0x1821CE0
	|-DynamicGenericResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1821D90 Offset: 0x1821E91 VA: 0x1821D90
	|-DynamicGenericResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1821E40 Offset: 0x1821F41 VA: 0x1821E40
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1821EF0 Offset: 0x1821FF1 VA: 0x1821EF0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1821FA0 Offset: 0x18220A1 VA: 0x1821FA0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1822050 Offset: 0x1822151 VA: 0x1822050
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1822100 Offset: 0x1822201 VA: 0x1822100
	|-DynamicGenericResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x18221B0 Offset: 0x18222B1 VA: 0x18221B0
	|-DynamicGenericResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1822260 Offset: 0x1822361 VA: 0x1822260
	|-DynamicGenericResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1822310 Offset: 0x1822411 VA: 0x1822310
	|-DynamicGenericResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18223C0 Offset: 0x18224C1 VA: 0x18223C0
	|-DynamicGenericResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1822470 Offset: 0x1822571 VA: 0x1822470
	|-DynamicGenericResolver.GetFormatter<bool>
	|
	|-RVA: 0x1822520 Offset: 0x1822621 VA: 0x1822520
	|-DynamicGenericResolver.GetFormatter<byte>
	|
	|-RVA: 0x18225D0 Offset: 0x18226D1 VA: 0x18225D0
	|-DynamicGenericResolver.GetFormatter<char>
	|
	|-RVA: 0x1822680 Offset: 0x1822781 VA: 0x1822680
	|-DynamicGenericResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1822730 Offset: 0x1822831 VA: 0x1822730
	|-DynamicGenericResolver.GetFormatter<double>
	|
	|-RVA: 0x18227E0 Offset: 0x18228E1 VA: 0x18227E0
	|-DynamicGenericResolver.GetFormatter<short>
	|
	|-RVA: 0x1822890 Offset: 0x1822991 VA: 0x1822890
	|-DynamicGenericResolver.GetFormatter<int>
	|
	|-RVA: 0x1822940 Offset: 0x1822A41 VA: 0x1822940
	|-DynamicGenericResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18229F0 Offset: 0x1822AF1 VA: 0x18229F0
	|-DynamicGenericResolver.GetFormatter<long>
	|
	|-RVA: 0x1822AA0 Offset: 0x1822BA1 VA: 0x1822AA0
	|-DynamicGenericResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1822B50 Offset: 0x1822C51 VA: 0x1822B50
	|-DynamicGenericResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1822C00 Offset: 0x1822D01 VA: 0x1822C00
	|-DynamicGenericResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1822CB0 Offset: 0x1822DB1 VA: 0x1822CB0
	|-DynamicGenericResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1822D60 Offset: 0x1822E61 VA: 0x1822D60
	|-DynamicGenericResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1822E10 Offset: 0x1822F11 VA: 0x1822E10
	|-DynamicGenericResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1822EC0 Offset: 0x1822FC1 VA: 0x1822EC0
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1822F70 Offset: 0x1823071 VA: 0x1822F70
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1823020 Offset: 0x1823121 VA: 0x1823020
	|-DynamicGenericResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18230D0 Offset: 0x18231D1 VA: 0x18230D0
	|-DynamicGenericResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1823180 Offset: 0x1823281 VA: 0x1823180
	|-DynamicGenericResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1823230 Offset: 0x1823331 VA: 0x1823230
	|-DynamicGenericResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18232E0 Offset: 0x18233E1 VA: 0x18232E0
	|-DynamicGenericResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1823390 Offset: 0x1823491 VA: 0x1823390
	|-DynamicGenericResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1823440 Offset: 0x1823541 VA: 0x1823440
	|-DynamicGenericResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18234F0 Offset: 0x18235F1 VA: 0x18234F0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18235A0 Offset: 0x18236A1 VA: 0x18235A0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1823650 Offset: 0x1823751 VA: 0x1823650
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1823700 Offset: 0x1823801 VA: 0x1823700
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18237B0 Offset: 0x18238B1 VA: 0x18237B0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1823860 Offset: 0x1823961 VA: 0x1823860
	|-DynamicGenericResolver.GetFormatter<object>
	|
	|-RVA: 0x1823910 Offset: 0x1823A11 VA: 0x1823910
	|-DynamicGenericResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x18239C0 Offset: 0x1823AC1 VA: 0x18239C0
	|-DynamicGenericResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1823A70 Offset: 0x1823B71 VA: 0x1823A70
	|-DynamicGenericResolver.GetFormatter<float>
	|
	|-RVA: 0x1823B20 Offset: 0x1823C21 VA: 0x1823B20
	|-DynamicGenericResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1823BD0 Offset: 0x1823CD1 VA: 0x1823BD0
	|-DynamicGenericResolver.GetFormatter<uint>
	|
	|-RVA: 0x1823C80 Offset: 0x1823D81 VA: 0x1823C80
	|-DynamicGenericResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1823D30 Offset: 0x1823E31 VA: 0x1823D30
	|-DynamicGenericResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1823DE0 Offset: 0x1823EE1 VA: 0x1823DE0
	|-DynamicGenericResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1823E90 Offset: 0x1823F91 VA: 0x1823E90
	|-DynamicGenericResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1823F40 Offset: 0x1824041 VA: 0x1823F40
	|-DynamicGenericResolver.GetFormatter<Color>
	|
	|-RVA: 0x1823FF0 Offset: 0x18240F1 VA: 0x1823FF0
	|-DynamicGenericResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x18240A0 Offset: 0x18241A1 VA: 0x18240A0
	|-DynamicGenericResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1824150 Offset: 0x1824251 VA: 0x1824150
	|-DynamicGenericResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1824200 Offset: 0x1824301 VA: 0x1824200
	|-DynamicGenericResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x18242B0 Offset: 0x18243B1 VA: 0x18242B0
	|-DynamicGenericResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1824360 Offset: 0x1824461 VA: 0x1824360
	|-DynamicGenericResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1824410 Offset: 0x1824511 VA: 0x1824410
	|-DynamicGenericResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18244C0 Offset: 0x18245C1 VA: 0x18244C0
	|-DynamicGenericResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1824570 Offset: 0x1824671 VA: 0x1824570
	|-DynamicGenericResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1824620 Offset: 0x1824721 VA: 0x1824620
	|-DynamicGenericResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x18246D0 Offset: 0x18247D1 VA: 0x18246D0
	|-DynamicGenericResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1824780 Offset: 0x1824881 VA: 0x1824780
	|-DynamicGenericResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1824830 Offset: 0x1824931 VA: 0x1824830
	|-DynamicGenericResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x18248E0 Offset: 0x18249E1 VA: 0x18248E0
	|-DynamicGenericResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3AE0 Offset: 0x14F3BE1 VA: 0x14F3AE0
	private static void .cctor() { }
}

public sealed class DynamicGenericResolver : IFormatterResolver // TypeDefIndex: 5236
{
	// Fields
	public static readonly DynamicGenericResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F3AD0 Offset: 0x14F3BD1 VA: 0x14F3AD0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821CE0 Offset: 0x1821DE1 VA: 0x1821CE0
	|-DynamicGenericResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1821D90 Offset: 0x1821E91 VA: 0x1821D90
	|-DynamicGenericResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1821E40 Offset: 0x1821F41 VA: 0x1821E40
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1821EF0 Offset: 0x1821FF1 VA: 0x1821EF0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1821FA0 Offset: 0x18220A1 VA: 0x1821FA0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1822050 Offset: 0x1822151 VA: 0x1822050
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1822100 Offset: 0x1822201 VA: 0x1822100
	|-DynamicGenericResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x18221B0 Offset: 0x18222B1 VA: 0x18221B0
	|-DynamicGenericResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1822260 Offset: 0x1822361 VA: 0x1822260
	|-DynamicGenericResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1822310 Offset: 0x1822411 VA: 0x1822310
	|-DynamicGenericResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18223C0 Offset: 0x18224C1 VA: 0x18223C0
	|-DynamicGenericResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1822470 Offset: 0x1822571 VA: 0x1822470
	|-DynamicGenericResolver.GetFormatter<bool>
	|
	|-RVA: 0x1822520 Offset: 0x1822621 VA: 0x1822520
	|-DynamicGenericResolver.GetFormatter<byte>
	|
	|-RVA: 0x18225D0 Offset: 0x18226D1 VA: 0x18225D0
	|-DynamicGenericResolver.GetFormatter<char>
	|
	|-RVA: 0x1822680 Offset: 0x1822781 VA: 0x1822680
	|-DynamicGenericResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1822730 Offset: 0x1822831 VA: 0x1822730
	|-DynamicGenericResolver.GetFormatter<double>
	|
	|-RVA: 0x18227E0 Offset: 0x18228E1 VA: 0x18227E0
	|-DynamicGenericResolver.GetFormatter<short>
	|
	|-RVA: 0x1822890 Offset: 0x1822991 VA: 0x1822890
	|-DynamicGenericResolver.GetFormatter<int>
	|
	|-RVA: 0x1822940 Offset: 0x1822A41 VA: 0x1822940
	|-DynamicGenericResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18229F0 Offset: 0x1822AF1 VA: 0x18229F0
	|-DynamicGenericResolver.GetFormatter<long>
	|
	|-RVA: 0x1822AA0 Offset: 0x1822BA1 VA: 0x1822AA0
	|-DynamicGenericResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1822B50 Offset: 0x1822C51 VA: 0x1822B50
	|-DynamicGenericResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1822C00 Offset: 0x1822D01 VA: 0x1822C00
	|-DynamicGenericResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1822CB0 Offset: 0x1822DB1 VA: 0x1822CB0
	|-DynamicGenericResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1822D60 Offset: 0x1822E61 VA: 0x1822D60
	|-DynamicGenericResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1822E10 Offset: 0x1822F11 VA: 0x1822E10
	|-DynamicGenericResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1822EC0 Offset: 0x1822FC1 VA: 0x1822EC0
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1822F70 Offset: 0x1823071 VA: 0x1822F70
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1823020 Offset: 0x1823121 VA: 0x1823020
	|-DynamicGenericResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18230D0 Offset: 0x18231D1 VA: 0x18230D0
	|-DynamicGenericResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1823180 Offset: 0x1823281 VA: 0x1823180
	|-DynamicGenericResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1823230 Offset: 0x1823331 VA: 0x1823230
	|-DynamicGenericResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18232E0 Offset: 0x18233E1 VA: 0x18232E0
	|-DynamicGenericResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1823390 Offset: 0x1823491 VA: 0x1823390
	|-DynamicGenericResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1823440 Offset: 0x1823541 VA: 0x1823440
	|-DynamicGenericResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18234F0 Offset: 0x18235F1 VA: 0x18234F0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18235A0 Offset: 0x18236A1 VA: 0x18235A0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1823650 Offset: 0x1823751 VA: 0x1823650
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1823700 Offset: 0x1823801 VA: 0x1823700
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18237B0 Offset: 0x18238B1 VA: 0x18237B0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1823860 Offset: 0x1823961 VA: 0x1823860
	|-DynamicGenericResolver.GetFormatter<object>
	|
	|-RVA: 0x1823910 Offset: 0x1823A11 VA: 0x1823910
	|-DynamicGenericResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x18239C0 Offset: 0x1823AC1 VA: 0x18239C0
	|-DynamicGenericResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1823A70 Offset: 0x1823B71 VA: 0x1823A70
	|-DynamicGenericResolver.GetFormatter<float>
	|
	|-RVA: 0x1823B20 Offset: 0x1823C21 VA: 0x1823B20
	|-DynamicGenericResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1823BD0 Offset: 0x1823CD1 VA: 0x1823BD0
	|-DynamicGenericResolver.GetFormatter<uint>
	|
	|-RVA: 0x1823C80 Offset: 0x1823D81 VA: 0x1823C80
	|-DynamicGenericResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1823D30 Offset: 0x1823E31 VA: 0x1823D30
	|-DynamicGenericResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1823DE0 Offset: 0x1823EE1 VA: 0x1823DE0
	|-DynamicGenericResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1823E90 Offset: 0x1823F91 VA: 0x1823E90
	|-DynamicGenericResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1823F40 Offset: 0x1824041 VA: 0x1823F40
	|-DynamicGenericResolver.GetFormatter<Color>
	|
	|-RVA: 0x1823FF0 Offset: 0x18240F1 VA: 0x1823FF0
	|-DynamicGenericResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x18240A0 Offset: 0x18241A1 VA: 0x18240A0
	|-DynamicGenericResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1824150 Offset: 0x1824251 VA: 0x1824150
	|-DynamicGenericResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1824200 Offset: 0x1824301 VA: 0x1824200
	|-DynamicGenericResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x18242B0 Offset: 0x18243B1 VA: 0x18242B0
	|-DynamicGenericResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1824360 Offset: 0x1824461 VA: 0x1824360
	|-DynamicGenericResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1824410 Offset: 0x1824511 VA: 0x1824410
	|-DynamicGenericResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18244C0 Offset: 0x18245C1 VA: 0x18244C0
	|-DynamicGenericResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1824570 Offset: 0x1824671 VA: 0x1824570
	|-DynamicGenericResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1824620 Offset: 0x1824721 VA: 0x1824620
	|-DynamicGenericResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x18246D0 Offset: 0x18247D1 VA: 0x18246D0
	|-DynamicGenericResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1824780 Offset: 0x1824881 VA: 0x1824780
	|-DynamicGenericResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1824830 Offset: 0x1824931 VA: 0x1824830
	|-DynamicGenericResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x18248E0 Offset: 0x18249E1 VA: 0x18248E0
	|-DynamicGenericResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3AE0 Offset: 0x14F3BE1 VA: 0x14F3AE0
	private static void .cctor() { }
}

public sealed class DynamicGenericResolver : IFormatterResolver // TypeDefIndex: 5236
{
	// Fields
	public static readonly DynamicGenericResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F3AD0 Offset: 0x14F3BD1 VA: 0x14F3AD0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821CE0 Offset: 0x1821DE1 VA: 0x1821CE0
	|-DynamicGenericResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1821D90 Offset: 0x1821E91 VA: 0x1821D90
	|-DynamicGenericResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1821E40 Offset: 0x1821F41 VA: 0x1821E40
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1821EF0 Offset: 0x1821FF1 VA: 0x1821EF0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1821FA0 Offset: 0x18220A1 VA: 0x1821FA0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1822050 Offset: 0x1822151 VA: 0x1822050
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1822100 Offset: 0x1822201 VA: 0x1822100
	|-DynamicGenericResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x18221B0 Offset: 0x18222B1 VA: 0x18221B0
	|-DynamicGenericResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1822260 Offset: 0x1822361 VA: 0x1822260
	|-DynamicGenericResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1822310 Offset: 0x1822411 VA: 0x1822310
	|-DynamicGenericResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18223C0 Offset: 0x18224C1 VA: 0x18223C0
	|-DynamicGenericResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1822470 Offset: 0x1822571 VA: 0x1822470
	|-DynamicGenericResolver.GetFormatter<bool>
	|
	|-RVA: 0x1822520 Offset: 0x1822621 VA: 0x1822520
	|-DynamicGenericResolver.GetFormatter<byte>
	|
	|-RVA: 0x18225D0 Offset: 0x18226D1 VA: 0x18225D0
	|-DynamicGenericResolver.GetFormatter<char>
	|
	|-RVA: 0x1822680 Offset: 0x1822781 VA: 0x1822680
	|-DynamicGenericResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1822730 Offset: 0x1822831 VA: 0x1822730
	|-DynamicGenericResolver.GetFormatter<double>
	|
	|-RVA: 0x18227E0 Offset: 0x18228E1 VA: 0x18227E0
	|-DynamicGenericResolver.GetFormatter<short>
	|
	|-RVA: 0x1822890 Offset: 0x1822991 VA: 0x1822890
	|-DynamicGenericResolver.GetFormatter<int>
	|
	|-RVA: 0x1822940 Offset: 0x1822A41 VA: 0x1822940
	|-DynamicGenericResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18229F0 Offset: 0x1822AF1 VA: 0x18229F0
	|-DynamicGenericResolver.GetFormatter<long>
	|
	|-RVA: 0x1822AA0 Offset: 0x1822BA1 VA: 0x1822AA0
	|-DynamicGenericResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1822B50 Offset: 0x1822C51 VA: 0x1822B50
	|-DynamicGenericResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1822C00 Offset: 0x1822D01 VA: 0x1822C00
	|-DynamicGenericResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1822CB0 Offset: 0x1822DB1 VA: 0x1822CB0
	|-DynamicGenericResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1822D60 Offset: 0x1822E61 VA: 0x1822D60
	|-DynamicGenericResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1822E10 Offset: 0x1822F11 VA: 0x1822E10
	|-DynamicGenericResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1822EC0 Offset: 0x1822FC1 VA: 0x1822EC0
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1822F70 Offset: 0x1823071 VA: 0x1822F70
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1823020 Offset: 0x1823121 VA: 0x1823020
	|-DynamicGenericResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18230D0 Offset: 0x18231D1 VA: 0x18230D0
	|-DynamicGenericResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1823180 Offset: 0x1823281 VA: 0x1823180
	|-DynamicGenericResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1823230 Offset: 0x1823331 VA: 0x1823230
	|-DynamicGenericResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18232E0 Offset: 0x18233E1 VA: 0x18232E0
	|-DynamicGenericResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1823390 Offset: 0x1823491 VA: 0x1823390
	|-DynamicGenericResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1823440 Offset: 0x1823541 VA: 0x1823440
	|-DynamicGenericResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18234F0 Offset: 0x18235F1 VA: 0x18234F0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18235A0 Offset: 0x18236A1 VA: 0x18235A0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1823650 Offset: 0x1823751 VA: 0x1823650
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1823700 Offset: 0x1823801 VA: 0x1823700
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18237B0 Offset: 0x18238B1 VA: 0x18237B0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1823860 Offset: 0x1823961 VA: 0x1823860
	|-DynamicGenericResolver.GetFormatter<object>
	|
	|-RVA: 0x1823910 Offset: 0x1823A11 VA: 0x1823910
	|-DynamicGenericResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x18239C0 Offset: 0x1823AC1 VA: 0x18239C0
	|-DynamicGenericResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1823A70 Offset: 0x1823B71 VA: 0x1823A70
	|-DynamicGenericResolver.GetFormatter<float>
	|
	|-RVA: 0x1823B20 Offset: 0x1823C21 VA: 0x1823B20
	|-DynamicGenericResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1823BD0 Offset: 0x1823CD1 VA: 0x1823BD0
	|-DynamicGenericResolver.GetFormatter<uint>
	|
	|-RVA: 0x1823C80 Offset: 0x1823D81 VA: 0x1823C80
	|-DynamicGenericResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1823D30 Offset: 0x1823E31 VA: 0x1823D30
	|-DynamicGenericResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1823DE0 Offset: 0x1823EE1 VA: 0x1823DE0
	|-DynamicGenericResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1823E90 Offset: 0x1823F91 VA: 0x1823E90
	|-DynamicGenericResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1823F40 Offset: 0x1824041 VA: 0x1823F40
	|-DynamicGenericResolver.GetFormatter<Color>
	|
	|-RVA: 0x1823FF0 Offset: 0x18240F1 VA: 0x1823FF0
	|-DynamicGenericResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x18240A0 Offset: 0x18241A1 VA: 0x18240A0
	|-DynamicGenericResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1824150 Offset: 0x1824251 VA: 0x1824150
	|-DynamicGenericResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1824200 Offset: 0x1824301 VA: 0x1824200
	|-DynamicGenericResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x18242B0 Offset: 0x18243B1 VA: 0x18242B0
	|-DynamicGenericResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1824360 Offset: 0x1824461 VA: 0x1824360
	|-DynamicGenericResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1824410 Offset: 0x1824511 VA: 0x1824410
	|-DynamicGenericResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18244C0 Offset: 0x18245C1 VA: 0x18244C0
	|-DynamicGenericResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1824570 Offset: 0x1824671 VA: 0x1824570
	|-DynamicGenericResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1824620 Offset: 0x1824721 VA: 0x1824620
	|-DynamicGenericResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x18246D0 Offset: 0x18247D1 VA: 0x18246D0
	|-DynamicGenericResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1824780 Offset: 0x1824881 VA: 0x1824780
	|-DynamicGenericResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1824830 Offset: 0x1824931 VA: 0x1824830
	|-DynamicGenericResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x18248E0 Offset: 0x18249E1 VA: 0x18248E0
	|-DynamicGenericResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3AE0 Offset: 0x14F3BE1 VA: 0x14F3AE0
	private static void .cctor() { }
}

public sealed class DynamicGenericResolver : IFormatterResolver // TypeDefIndex: 5236
{
	// Fields
	public static readonly DynamicGenericResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F3AD0 Offset: 0x14F3BD1 VA: 0x14F3AD0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821CE0 Offset: 0x1821DE1 VA: 0x1821CE0
	|-DynamicGenericResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1821D90 Offset: 0x1821E91 VA: 0x1821D90
	|-DynamicGenericResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1821E40 Offset: 0x1821F41 VA: 0x1821E40
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1821EF0 Offset: 0x1821FF1 VA: 0x1821EF0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1821FA0 Offset: 0x18220A1 VA: 0x1821FA0
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1822050 Offset: 0x1822151 VA: 0x1822050
	|-DynamicGenericResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1822100 Offset: 0x1822201 VA: 0x1822100
	|-DynamicGenericResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x18221B0 Offset: 0x18222B1 VA: 0x18221B0
	|-DynamicGenericResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1822260 Offset: 0x1822361 VA: 0x1822260
	|-DynamicGenericResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1822310 Offset: 0x1822411 VA: 0x1822310
	|-DynamicGenericResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x18223C0 Offset: 0x18224C1 VA: 0x18223C0
	|-DynamicGenericResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1822470 Offset: 0x1822571 VA: 0x1822470
	|-DynamicGenericResolver.GetFormatter<bool>
	|
	|-RVA: 0x1822520 Offset: 0x1822621 VA: 0x1822520
	|-DynamicGenericResolver.GetFormatter<byte>
	|
	|-RVA: 0x18225D0 Offset: 0x18226D1 VA: 0x18225D0
	|-DynamicGenericResolver.GetFormatter<char>
	|
	|-RVA: 0x1822680 Offset: 0x1822781 VA: 0x1822680
	|-DynamicGenericResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1822730 Offset: 0x1822831 VA: 0x1822730
	|-DynamicGenericResolver.GetFormatter<double>
	|
	|-RVA: 0x18227E0 Offset: 0x18228E1 VA: 0x18227E0
	|-DynamicGenericResolver.GetFormatter<short>
	|
	|-RVA: 0x1822890 Offset: 0x1822991 VA: 0x1822890
	|-DynamicGenericResolver.GetFormatter<int>
	|
	|-RVA: 0x1822940 Offset: 0x1822A41 VA: 0x1822940
	|-DynamicGenericResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18229F0 Offset: 0x1822AF1 VA: 0x18229F0
	|-DynamicGenericResolver.GetFormatter<long>
	|
	|-RVA: 0x1822AA0 Offset: 0x1822BA1 VA: 0x1822AA0
	|-DynamicGenericResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1822B50 Offset: 0x1822C51 VA: 0x1822B50
	|-DynamicGenericResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1822C00 Offset: 0x1822D01 VA: 0x1822C00
	|-DynamicGenericResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1822CB0 Offset: 0x1822DB1 VA: 0x1822CB0
	|-DynamicGenericResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1822D60 Offset: 0x1822E61 VA: 0x1822D60
	|-DynamicGenericResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1822E10 Offset: 0x1822F11 VA: 0x1822E10
	|-DynamicGenericResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1822EC0 Offset: 0x1822FC1 VA: 0x1822EC0
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1822F70 Offset: 0x1823071 VA: 0x1822F70
	|-DynamicGenericResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1823020 Offset: 0x1823121 VA: 0x1823020
	|-DynamicGenericResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x18230D0 Offset: 0x18231D1 VA: 0x18230D0
	|-DynamicGenericResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1823180 Offset: 0x1823281 VA: 0x1823180
	|-DynamicGenericResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1823230 Offset: 0x1823331 VA: 0x1823230
	|-DynamicGenericResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x18232E0 Offset: 0x18233E1 VA: 0x18232E0
	|-DynamicGenericResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1823390 Offset: 0x1823491 VA: 0x1823390
	|-DynamicGenericResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1823440 Offset: 0x1823541 VA: 0x1823440
	|-DynamicGenericResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18234F0 Offset: 0x18235F1 VA: 0x18234F0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18235A0 Offset: 0x18236A1 VA: 0x18235A0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1823650 Offset: 0x1823751 VA: 0x1823650
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1823700 Offset: 0x1823801 VA: 0x1823700
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18237B0 Offset: 0x18238B1 VA: 0x18237B0
	|-DynamicGenericResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1823860 Offset: 0x1823961 VA: 0x1823860
	|-DynamicGenericResolver.GetFormatter<object>
	|
	|-RVA: 0x1823910 Offset: 0x1823A11 VA: 0x1823910
	|-DynamicGenericResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x18239C0 Offset: 0x1823AC1 VA: 0x18239C0
	|-DynamicGenericResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1823A70 Offset: 0x1823B71 VA: 0x1823A70
	|-DynamicGenericResolver.GetFormatter<float>
	|
	|-RVA: 0x1823B20 Offset: 0x1823C21 VA: 0x1823B20
	|-DynamicGenericResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1823BD0 Offset: 0x1823CD1 VA: 0x1823BD0
	|-DynamicGenericResolver.GetFormatter<uint>
	|
	|-RVA: 0x1823C80 Offset: 0x1823D81 VA: 0x1823C80
	|-DynamicGenericResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1823D30 Offset: 0x1823E31 VA: 0x1823D30
	|-DynamicGenericResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1823DE0 Offset: 0x1823EE1 VA: 0x1823DE0
	|-DynamicGenericResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1823E90 Offset: 0x1823F91 VA: 0x1823E90
	|-DynamicGenericResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1823F40 Offset: 0x1824041 VA: 0x1823F40
	|-DynamicGenericResolver.GetFormatter<Color>
	|
	|-RVA: 0x1823FF0 Offset: 0x18240F1 VA: 0x1823FF0
	|-DynamicGenericResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x18240A0 Offset: 0x18241A1 VA: 0x18240A0
	|-DynamicGenericResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1824150 Offset: 0x1824251 VA: 0x1824150
	|-DynamicGenericResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1824200 Offset: 0x1824301 VA: 0x1824200
	|-DynamicGenericResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x18242B0 Offset: 0x18243B1 VA: 0x18242B0
	|-DynamicGenericResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1824360 Offset: 0x1824461 VA: 0x1824360
	|-DynamicGenericResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1824410 Offset: 0x1824511 VA: 0x1824410
	|-DynamicGenericResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x18244C0 Offset: 0x18245C1 VA: 0x18244C0
	|-DynamicGenericResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1824570 Offset: 0x1824671 VA: 0x1824570
	|-DynamicGenericResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1824620 Offset: 0x1824721 VA: 0x1824620
	|-DynamicGenericResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x18246D0 Offset: 0x18247D1 VA: 0x18246D0
	|-DynamicGenericResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1824780 Offset: 0x1824881 VA: 0x1824780
	|-DynamicGenericResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1824830 Offset: 0x1824931 VA: 0x1824830
	|-DynamicGenericResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x18248E0 Offset: 0x18249E1 VA: 0x18248E0
	|-DynamicGenericResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F3AE0 Offset: 0x14F3BE1 VA: 0x14F3AE0
	private static void .cctor() { }
}

