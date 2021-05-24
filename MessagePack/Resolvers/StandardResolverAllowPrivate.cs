public sealed class StandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5270
{
	// Fields
	public static readonly StandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F8DF0 Offset: 0x14F8EF1 VA: 0x14F8DF0
	private static void .cctor() { }

	// RVA: 0x14F8F20 Offset: 0x14F9021 VA: 0x14F8F20
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2801C80 Offset: 0x2801D81 VA: 0x2801C80
	|-StandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x2801D30 Offset: 0x2801E31 VA: 0x2801D30
	|-StandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2801DE0 Offset: 0x2801EE1 VA: 0x2801DE0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2801E90 Offset: 0x2801F91 VA: 0x2801E90
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2801F40 Offset: 0x2802041 VA: 0x2801F40
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2801FF0 Offset: 0x28020F1 VA: 0x2801FF0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x28020A0 Offset: 0x28021A1 VA: 0x28020A0
	|-StandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2802150 Offset: 0x2802251 VA: 0x2802150
	|-StandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2802200 Offset: 0x2802301 VA: 0x2802200
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x28022B0 Offset: 0x28023B1 VA: 0x28022B0
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2802360 Offset: 0x2802461 VA: 0x2802360
	|-StandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x2802410 Offset: 0x2802511 VA: 0x2802410
	|-StandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x28024C0 Offset: 0x28025C1 VA: 0x28024C0
	|-StandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x2802570 Offset: 0x2802671 VA: 0x2802570
	|-StandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x2802620 Offset: 0x2802721 VA: 0x2802620
	|-StandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x28026D0 Offset: 0x28027D1 VA: 0x28026D0
	|-StandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x2802780 Offset: 0x2802881 VA: 0x2802780
	|-StandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x2802830 Offset: 0x2802931 VA: 0x2802830
	|-StandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x28028E0 Offset: 0x28029E1 VA: 0x28028E0
	|-StandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2802990 Offset: 0x2802A91 VA: 0x2802990
	|-StandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x2802A40 Offset: 0x2802B41 VA: 0x2802A40
	|-StandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x2802AF0 Offset: 0x2802BF1 VA: 0x2802AF0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2802BA0 Offset: 0x2802CA1 VA: 0x2802BA0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2802C50 Offset: 0x2802D51 VA: 0x2802C50
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x2802D00 Offset: 0x2802E01 VA: 0x2802D00
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2802DB0 Offset: 0x2802EB1 VA: 0x2802DB0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2802E60 Offset: 0x2802F61 VA: 0x2802E60
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2802F10 Offset: 0x2803011 VA: 0x2802F10
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2802FC0 Offset: 0x28030C1 VA: 0x2802FC0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2803070 Offset: 0x2803171 VA: 0x2803070
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2803120 Offset: 0x2803221 VA: 0x2803120
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x28031D0 Offset: 0x28032D1 VA: 0x28031D0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2803280 Offset: 0x2803381 VA: 0x2803280
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2803330 Offset: 0x2803431 VA: 0x2803330
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x28033E0 Offset: 0x28034E1 VA: 0x28033E0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2803490 Offset: 0x2803591 VA: 0x2803490
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x2803540 Offset: 0x2803641 VA: 0x2803540
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28035F0 Offset: 0x28036F1 VA: 0x28035F0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x28036A0 Offset: 0x28037A1 VA: 0x28036A0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2803750 Offset: 0x2803851 VA: 0x2803750
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x2803800 Offset: 0x2803901 VA: 0x2803800
	|-StandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x28038B0 Offset: 0x28039B1 VA: 0x28038B0
	|-StandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2803960 Offset: 0x2803A61 VA: 0x2803960
	|-StandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x2803A10 Offset: 0x2803B11 VA: 0x2803A10
	|-StandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x2803AC0 Offset: 0x2803BC1 VA: 0x2803AC0
	|-StandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x2803B70 Offset: 0x2803C71 VA: 0x2803B70
	|-StandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x2803C20 Offset: 0x2803D21 VA: 0x2803C20
	|-StandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x2803CD0 Offset: 0x2803DD1 VA: 0x2803CD0
	|-StandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x2803D80 Offset: 0x2803E81 VA: 0x2803D80
	|-StandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2803E30 Offset: 0x2803F31 VA: 0x2803E30
	|-StandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x2803EE0 Offset: 0x2803FE1 VA: 0x2803EE0
	|-StandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x2803F90 Offset: 0x2804091 VA: 0x2803F90
	|-StandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2804040 Offset: 0x2804141 VA: 0x2804040
	|-StandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x28040F0 Offset: 0x28041F1 VA: 0x28040F0
	|-StandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x28041A0 Offset: 0x28042A1 VA: 0x28041A0
	|-StandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x2804250 Offset: 0x2804351 VA: 0x2804250
	|-StandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2804300 Offset: 0x2804401 VA: 0x2804300
	|-StandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x28043B0 Offset: 0x28044B1 VA: 0x28043B0
	|-StandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x2804460 Offset: 0x2804561 VA: 0x2804460
	|-StandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x2804510 Offset: 0x2804611 VA: 0x2804510
	|-StandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x28045C0 Offset: 0x28046C1 VA: 0x28045C0
	|-StandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x2804670 Offset: 0x2804771 VA: 0x2804670
	|-StandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x2804720 Offset: 0x2804821 VA: 0x2804720
	|-StandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x28047D0 Offset: 0x28048D1 VA: 0x28047D0
	|-StandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2804880 Offset: 0x2804981 VA: 0x2804880
	|-StandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

public sealed class StandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5270
{
	// Fields
	public static readonly StandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F8DF0 Offset: 0x14F8EF1 VA: 0x14F8DF0
	private static void .cctor() { }

	// RVA: 0x14F8F20 Offset: 0x14F9021 VA: 0x14F8F20
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2801C80 Offset: 0x2801D81 VA: 0x2801C80
	|-StandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x2801D30 Offset: 0x2801E31 VA: 0x2801D30
	|-StandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2801DE0 Offset: 0x2801EE1 VA: 0x2801DE0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2801E90 Offset: 0x2801F91 VA: 0x2801E90
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2801F40 Offset: 0x2802041 VA: 0x2801F40
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2801FF0 Offset: 0x28020F1 VA: 0x2801FF0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x28020A0 Offset: 0x28021A1 VA: 0x28020A0
	|-StandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2802150 Offset: 0x2802251 VA: 0x2802150
	|-StandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2802200 Offset: 0x2802301 VA: 0x2802200
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x28022B0 Offset: 0x28023B1 VA: 0x28022B0
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2802360 Offset: 0x2802461 VA: 0x2802360
	|-StandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x2802410 Offset: 0x2802511 VA: 0x2802410
	|-StandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x28024C0 Offset: 0x28025C1 VA: 0x28024C0
	|-StandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x2802570 Offset: 0x2802671 VA: 0x2802570
	|-StandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x2802620 Offset: 0x2802721 VA: 0x2802620
	|-StandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x28026D0 Offset: 0x28027D1 VA: 0x28026D0
	|-StandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x2802780 Offset: 0x2802881 VA: 0x2802780
	|-StandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x2802830 Offset: 0x2802931 VA: 0x2802830
	|-StandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x28028E0 Offset: 0x28029E1 VA: 0x28028E0
	|-StandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2802990 Offset: 0x2802A91 VA: 0x2802990
	|-StandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x2802A40 Offset: 0x2802B41 VA: 0x2802A40
	|-StandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x2802AF0 Offset: 0x2802BF1 VA: 0x2802AF0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2802BA0 Offset: 0x2802CA1 VA: 0x2802BA0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2802C50 Offset: 0x2802D51 VA: 0x2802C50
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x2802D00 Offset: 0x2802E01 VA: 0x2802D00
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2802DB0 Offset: 0x2802EB1 VA: 0x2802DB0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2802E60 Offset: 0x2802F61 VA: 0x2802E60
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2802F10 Offset: 0x2803011 VA: 0x2802F10
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2802FC0 Offset: 0x28030C1 VA: 0x2802FC0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2803070 Offset: 0x2803171 VA: 0x2803070
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2803120 Offset: 0x2803221 VA: 0x2803120
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x28031D0 Offset: 0x28032D1 VA: 0x28031D0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2803280 Offset: 0x2803381 VA: 0x2803280
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2803330 Offset: 0x2803431 VA: 0x2803330
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x28033E0 Offset: 0x28034E1 VA: 0x28033E0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2803490 Offset: 0x2803591 VA: 0x2803490
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x2803540 Offset: 0x2803641 VA: 0x2803540
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28035F0 Offset: 0x28036F1 VA: 0x28035F0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x28036A0 Offset: 0x28037A1 VA: 0x28036A0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2803750 Offset: 0x2803851 VA: 0x2803750
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x2803800 Offset: 0x2803901 VA: 0x2803800
	|-StandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x28038B0 Offset: 0x28039B1 VA: 0x28038B0
	|-StandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2803960 Offset: 0x2803A61 VA: 0x2803960
	|-StandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x2803A10 Offset: 0x2803B11 VA: 0x2803A10
	|-StandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x2803AC0 Offset: 0x2803BC1 VA: 0x2803AC0
	|-StandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x2803B70 Offset: 0x2803C71 VA: 0x2803B70
	|-StandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x2803C20 Offset: 0x2803D21 VA: 0x2803C20
	|-StandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x2803CD0 Offset: 0x2803DD1 VA: 0x2803CD0
	|-StandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x2803D80 Offset: 0x2803E81 VA: 0x2803D80
	|-StandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2803E30 Offset: 0x2803F31 VA: 0x2803E30
	|-StandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x2803EE0 Offset: 0x2803FE1 VA: 0x2803EE0
	|-StandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x2803F90 Offset: 0x2804091 VA: 0x2803F90
	|-StandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2804040 Offset: 0x2804141 VA: 0x2804040
	|-StandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x28040F0 Offset: 0x28041F1 VA: 0x28040F0
	|-StandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x28041A0 Offset: 0x28042A1 VA: 0x28041A0
	|-StandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x2804250 Offset: 0x2804351 VA: 0x2804250
	|-StandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2804300 Offset: 0x2804401 VA: 0x2804300
	|-StandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x28043B0 Offset: 0x28044B1 VA: 0x28043B0
	|-StandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x2804460 Offset: 0x2804561 VA: 0x2804460
	|-StandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x2804510 Offset: 0x2804611 VA: 0x2804510
	|-StandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x28045C0 Offset: 0x28046C1 VA: 0x28045C0
	|-StandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x2804670 Offset: 0x2804771 VA: 0x2804670
	|-StandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x2804720 Offset: 0x2804821 VA: 0x2804720
	|-StandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x28047D0 Offset: 0x28048D1 VA: 0x28047D0
	|-StandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2804880 Offset: 0x2804981 VA: 0x2804880
	|-StandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

public sealed class StandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5270
{
	// Fields
	public static readonly StandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F8DF0 Offset: 0x14F8EF1 VA: 0x14F8DF0
	private static void .cctor() { }

	// RVA: 0x14F8F20 Offset: 0x14F9021 VA: 0x14F8F20
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2801C80 Offset: 0x2801D81 VA: 0x2801C80
	|-StandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x2801D30 Offset: 0x2801E31 VA: 0x2801D30
	|-StandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2801DE0 Offset: 0x2801EE1 VA: 0x2801DE0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2801E90 Offset: 0x2801F91 VA: 0x2801E90
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2801F40 Offset: 0x2802041 VA: 0x2801F40
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2801FF0 Offset: 0x28020F1 VA: 0x2801FF0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x28020A0 Offset: 0x28021A1 VA: 0x28020A0
	|-StandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2802150 Offset: 0x2802251 VA: 0x2802150
	|-StandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2802200 Offset: 0x2802301 VA: 0x2802200
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x28022B0 Offset: 0x28023B1 VA: 0x28022B0
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2802360 Offset: 0x2802461 VA: 0x2802360
	|-StandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x2802410 Offset: 0x2802511 VA: 0x2802410
	|-StandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x28024C0 Offset: 0x28025C1 VA: 0x28024C0
	|-StandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x2802570 Offset: 0x2802671 VA: 0x2802570
	|-StandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x2802620 Offset: 0x2802721 VA: 0x2802620
	|-StandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x28026D0 Offset: 0x28027D1 VA: 0x28026D0
	|-StandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x2802780 Offset: 0x2802881 VA: 0x2802780
	|-StandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x2802830 Offset: 0x2802931 VA: 0x2802830
	|-StandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x28028E0 Offset: 0x28029E1 VA: 0x28028E0
	|-StandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2802990 Offset: 0x2802A91 VA: 0x2802990
	|-StandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x2802A40 Offset: 0x2802B41 VA: 0x2802A40
	|-StandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x2802AF0 Offset: 0x2802BF1 VA: 0x2802AF0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2802BA0 Offset: 0x2802CA1 VA: 0x2802BA0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2802C50 Offset: 0x2802D51 VA: 0x2802C50
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x2802D00 Offset: 0x2802E01 VA: 0x2802D00
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2802DB0 Offset: 0x2802EB1 VA: 0x2802DB0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2802E60 Offset: 0x2802F61 VA: 0x2802E60
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2802F10 Offset: 0x2803011 VA: 0x2802F10
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2802FC0 Offset: 0x28030C1 VA: 0x2802FC0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2803070 Offset: 0x2803171 VA: 0x2803070
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2803120 Offset: 0x2803221 VA: 0x2803120
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x28031D0 Offset: 0x28032D1 VA: 0x28031D0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2803280 Offset: 0x2803381 VA: 0x2803280
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2803330 Offset: 0x2803431 VA: 0x2803330
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x28033E0 Offset: 0x28034E1 VA: 0x28033E0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2803490 Offset: 0x2803591 VA: 0x2803490
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x2803540 Offset: 0x2803641 VA: 0x2803540
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28035F0 Offset: 0x28036F1 VA: 0x28035F0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x28036A0 Offset: 0x28037A1 VA: 0x28036A0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2803750 Offset: 0x2803851 VA: 0x2803750
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x2803800 Offset: 0x2803901 VA: 0x2803800
	|-StandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x28038B0 Offset: 0x28039B1 VA: 0x28038B0
	|-StandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2803960 Offset: 0x2803A61 VA: 0x2803960
	|-StandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x2803A10 Offset: 0x2803B11 VA: 0x2803A10
	|-StandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x2803AC0 Offset: 0x2803BC1 VA: 0x2803AC0
	|-StandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x2803B70 Offset: 0x2803C71 VA: 0x2803B70
	|-StandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x2803C20 Offset: 0x2803D21 VA: 0x2803C20
	|-StandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x2803CD0 Offset: 0x2803DD1 VA: 0x2803CD0
	|-StandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x2803D80 Offset: 0x2803E81 VA: 0x2803D80
	|-StandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2803E30 Offset: 0x2803F31 VA: 0x2803E30
	|-StandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x2803EE0 Offset: 0x2803FE1 VA: 0x2803EE0
	|-StandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x2803F90 Offset: 0x2804091 VA: 0x2803F90
	|-StandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2804040 Offset: 0x2804141 VA: 0x2804040
	|-StandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x28040F0 Offset: 0x28041F1 VA: 0x28040F0
	|-StandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x28041A0 Offset: 0x28042A1 VA: 0x28041A0
	|-StandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x2804250 Offset: 0x2804351 VA: 0x2804250
	|-StandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2804300 Offset: 0x2804401 VA: 0x2804300
	|-StandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x28043B0 Offset: 0x28044B1 VA: 0x28043B0
	|-StandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x2804460 Offset: 0x2804561 VA: 0x2804460
	|-StandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x2804510 Offset: 0x2804611 VA: 0x2804510
	|-StandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x28045C0 Offset: 0x28046C1 VA: 0x28045C0
	|-StandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x2804670 Offset: 0x2804771 VA: 0x2804670
	|-StandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x2804720 Offset: 0x2804821 VA: 0x2804720
	|-StandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x28047D0 Offset: 0x28048D1 VA: 0x28047D0
	|-StandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2804880 Offset: 0x2804981 VA: 0x2804880
	|-StandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

public sealed class StandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5270
{
	// Fields
	public static readonly StandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F8DF0 Offset: 0x14F8EF1 VA: 0x14F8DF0
	private static void .cctor() { }

	// RVA: 0x14F8F20 Offset: 0x14F9021 VA: 0x14F8F20
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2801C80 Offset: 0x2801D81 VA: 0x2801C80
	|-StandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x2801D30 Offset: 0x2801E31 VA: 0x2801D30
	|-StandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2801DE0 Offset: 0x2801EE1 VA: 0x2801DE0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2801E90 Offset: 0x2801F91 VA: 0x2801E90
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2801F40 Offset: 0x2802041 VA: 0x2801F40
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2801FF0 Offset: 0x28020F1 VA: 0x2801FF0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x28020A0 Offset: 0x28021A1 VA: 0x28020A0
	|-StandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2802150 Offset: 0x2802251 VA: 0x2802150
	|-StandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2802200 Offset: 0x2802301 VA: 0x2802200
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x28022B0 Offset: 0x28023B1 VA: 0x28022B0
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2802360 Offset: 0x2802461 VA: 0x2802360
	|-StandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x2802410 Offset: 0x2802511 VA: 0x2802410
	|-StandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x28024C0 Offset: 0x28025C1 VA: 0x28024C0
	|-StandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x2802570 Offset: 0x2802671 VA: 0x2802570
	|-StandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x2802620 Offset: 0x2802721 VA: 0x2802620
	|-StandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x28026D0 Offset: 0x28027D1 VA: 0x28026D0
	|-StandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x2802780 Offset: 0x2802881 VA: 0x2802780
	|-StandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x2802830 Offset: 0x2802931 VA: 0x2802830
	|-StandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x28028E0 Offset: 0x28029E1 VA: 0x28028E0
	|-StandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2802990 Offset: 0x2802A91 VA: 0x2802990
	|-StandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x2802A40 Offset: 0x2802B41 VA: 0x2802A40
	|-StandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x2802AF0 Offset: 0x2802BF1 VA: 0x2802AF0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2802BA0 Offset: 0x2802CA1 VA: 0x2802BA0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2802C50 Offset: 0x2802D51 VA: 0x2802C50
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x2802D00 Offset: 0x2802E01 VA: 0x2802D00
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2802DB0 Offset: 0x2802EB1 VA: 0x2802DB0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2802E60 Offset: 0x2802F61 VA: 0x2802E60
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2802F10 Offset: 0x2803011 VA: 0x2802F10
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2802FC0 Offset: 0x28030C1 VA: 0x2802FC0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2803070 Offset: 0x2803171 VA: 0x2803070
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2803120 Offset: 0x2803221 VA: 0x2803120
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x28031D0 Offset: 0x28032D1 VA: 0x28031D0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2803280 Offset: 0x2803381 VA: 0x2803280
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2803330 Offset: 0x2803431 VA: 0x2803330
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x28033E0 Offset: 0x28034E1 VA: 0x28033E0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2803490 Offset: 0x2803591 VA: 0x2803490
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x2803540 Offset: 0x2803641 VA: 0x2803540
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28035F0 Offset: 0x28036F1 VA: 0x28035F0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x28036A0 Offset: 0x28037A1 VA: 0x28036A0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2803750 Offset: 0x2803851 VA: 0x2803750
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x2803800 Offset: 0x2803901 VA: 0x2803800
	|-StandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x28038B0 Offset: 0x28039B1 VA: 0x28038B0
	|-StandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2803960 Offset: 0x2803A61 VA: 0x2803960
	|-StandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x2803A10 Offset: 0x2803B11 VA: 0x2803A10
	|-StandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x2803AC0 Offset: 0x2803BC1 VA: 0x2803AC0
	|-StandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x2803B70 Offset: 0x2803C71 VA: 0x2803B70
	|-StandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x2803C20 Offset: 0x2803D21 VA: 0x2803C20
	|-StandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x2803CD0 Offset: 0x2803DD1 VA: 0x2803CD0
	|-StandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x2803D80 Offset: 0x2803E81 VA: 0x2803D80
	|-StandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2803E30 Offset: 0x2803F31 VA: 0x2803E30
	|-StandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x2803EE0 Offset: 0x2803FE1 VA: 0x2803EE0
	|-StandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x2803F90 Offset: 0x2804091 VA: 0x2803F90
	|-StandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2804040 Offset: 0x2804141 VA: 0x2804040
	|-StandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x28040F0 Offset: 0x28041F1 VA: 0x28040F0
	|-StandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x28041A0 Offset: 0x28042A1 VA: 0x28041A0
	|-StandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x2804250 Offset: 0x2804351 VA: 0x2804250
	|-StandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2804300 Offset: 0x2804401 VA: 0x2804300
	|-StandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x28043B0 Offset: 0x28044B1 VA: 0x28043B0
	|-StandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x2804460 Offset: 0x2804561 VA: 0x2804460
	|-StandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x2804510 Offset: 0x2804611 VA: 0x2804510
	|-StandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x28045C0 Offset: 0x28046C1 VA: 0x28045C0
	|-StandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x2804670 Offset: 0x2804771 VA: 0x2804670
	|-StandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x2804720 Offset: 0x2804821 VA: 0x2804720
	|-StandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x28047D0 Offset: 0x28048D1 VA: 0x28047D0
	|-StandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2804880 Offset: 0x2804981 VA: 0x2804880
	|-StandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

public sealed class StandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5270
{
	// Fields
	public static readonly StandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F8DF0 Offset: 0x14F8EF1 VA: 0x14F8DF0
	private static void .cctor() { }

	// RVA: 0x14F8F20 Offset: 0x14F9021 VA: 0x14F8F20
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2801C80 Offset: 0x2801D81 VA: 0x2801C80
	|-StandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x2801D30 Offset: 0x2801E31 VA: 0x2801D30
	|-StandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2801DE0 Offset: 0x2801EE1 VA: 0x2801DE0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2801E90 Offset: 0x2801F91 VA: 0x2801E90
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2801F40 Offset: 0x2802041 VA: 0x2801F40
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2801FF0 Offset: 0x28020F1 VA: 0x2801FF0
	|-StandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x28020A0 Offset: 0x28021A1 VA: 0x28020A0
	|-StandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2802150 Offset: 0x2802251 VA: 0x2802150
	|-StandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2802200 Offset: 0x2802301 VA: 0x2802200
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x28022B0 Offset: 0x28023B1 VA: 0x28022B0
	|-StandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2802360 Offset: 0x2802461 VA: 0x2802360
	|-StandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x2802410 Offset: 0x2802511 VA: 0x2802410
	|-StandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x28024C0 Offset: 0x28025C1 VA: 0x28024C0
	|-StandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x2802570 Offset: 0x2802671 VA: 0x2802570
	|-StandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x2802620 Offset: 0x2802721 VA: 0x2802620
	|-StandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x28026D0 Offset: 0x28027D1 VA: 0x28026D0
	|-StandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x2802780 Offset: 0x2802881 VA: 0x2802780
	|-StandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x2802830 Offset: 0x2802931 VA: 0x2802830
	|-StandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x28028E0 Offset: 0x28029E1 VA: 0x28028E0
	|-StandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2802990 Offset: 0x2802A91 VA: 0x2802990
	|-StandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x2802A40 Offset: 0x2802B41 VA: 0x2802A40
	|-StandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x2802AF0 Offset: 0x2802BF1 VA: 0x2802AF0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2802BA0 Offset: 0x2802CA1 VA: 0x2802BA0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2802C50 Offset: 0x2802D51 VA: 0x2802C50
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x2802D00 Offset: 0x2802E01 VA: 0x2802D00
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2802DB0 Offset: 0x2802EB1 VA: 0x2802DB0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2802E60 Offset: 0x2802F61 VA: 0x2802E60
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2802F10 Offset: 0x2803011 VA: 0x2802F10
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2802FC0 Offset: 0x28030C1 VA: 0x2802FC0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2803070 Offset: 0x2803171 VA: 0x2803070
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2803120 Offset: 0x2803221 VA: 0x2803120
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x28031D0 Offset: 0x28032D1 VA: 0x28031D0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2803280 Offset: 0x2803381 VA: 0x2803280
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2803330 Offset: 0x2803431 VA: 0x2803330
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x28033E0 Offset: 0x28034E1 VA: 0x28033E0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2803490 Offset: 0x2803591 VA: 0x2803490
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x2803540 Offset: 0x2803641 VA: 0x2803540
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28035F0 Offset: 0x28036F1 VA: 0x28035F0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x28036A0 Offset: 0x28037A1 VA: 0x28036A0
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2803750 Offset: 0x2803851 VA: 0x2803750
	|-StandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x2803800 Offset: 0x2803901 VA: 0x2803800
	|-StandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x28038B0 Offset: 0x28039B1 VA: 0x28038B0
	|-StandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2803960 Offset: 0x2803A61 VA: 0x2803960
	|-StandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x2803A10 Offset: 0x2803B11 VA: 0x2803A10
	|-StandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x2803AC0 Offset: 0x2803BC1 VA: 0x2803AC0
	|-StandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x2803B70 Offset: 0x2803C71 VA: 0x2803B70
	|-StandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x2803C20 Offset: 0x2803D21 VA: 0x2803C20
	|-StandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x2803CD0 Offset: 0x2803DD1 VA: 0x2803CD0
	|-StandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x2803D80 Offset: 0x2803E81 VA: 0x2803D80
	|-StandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2803E30 Offset: 0x2803F31 VA: 0x2803E30
	|-StandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x2803EE0 Offset: 0x2803FE1 VA: 0x2803EE0
	|-StandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x2803F90 Offset: 0x2804091 VA: 0x2803F90
	|-StandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2804040 Offset: 0x2804141 VA: 0x2804040
	|-StandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x28040F0 Offset: 0x28041F1 VA: 0x28040F0
	|-StandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x28041A0 Offset: 0x28042A1 VA: 0x28041A0
	|-StandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x2804250 Offset: 0x2804351 VA: 0x2804250
	|-StandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2804300 Offset: 0x2804401 VA: 0x2804300
	|-StandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x28043B0 Offset: 0x28044B1 VA: 0x28043B0
	|-StandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x2804460 Offset: 0x2804561 VA: 0x2804460
	|-StandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x2804510 Offset: 0x2804611 VA: 0x2804510
	|-StandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x28045C0 Offset: 0x28046C1 VA: 0x28045C0
	|-StandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x2804670 Offset: 0x2804771 VA: 0x2804670
	|-StandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x2804720 Offset: 0x2804821 VA: 0x2804720
	|-StandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x28047D0 Offset: 0x28048D1 VA: 0x28047D0
	|-StandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2804880 Offset: 0x2804981 VA: 0x2804880
	|-StandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

