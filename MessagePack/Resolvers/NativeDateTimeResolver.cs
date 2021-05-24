public sealed class NativeDateTimeResolver : IFormatterResolver // TypeDefIndex: 5258
{
	// Fields
	public static readonly NativeDateTimeResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8750 Offset: 0x14F8851 VA: 0x14F8750
	private static void .cctor() { }

	// RVA: 0x14F8800 Offset: 0x14F8901 VA: 0x14F8800
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x182FC50 Offset: 0x182FD51 VA: 0x182FC50
	|-NativeDateTimeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x182FD00 Offset: 0x182FE01 VA: 0x182FD00
	|-NativeDateTimeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x182FDB0 Offset: 0x182FEB1 VA: 0x182FDB0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x182FE60 Offset: 0x182FF61 VA: 0x182FE60
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x182FF10 Offset: 0x1830011 VA: 0x182FF10
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x182FFC0 Offset: 0x18300C1 VA: 0x182FFC0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1830070 Offset: 0x1830171 VA: 0x1830070
	|-NativeDateTimeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1830120 Offset: 0x1830221 VA: 0x1830120
	|-NativeDateTimeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18301D0 Offset: 0x18302D1 VA: 0x18301D0
	|-NativeDateTimeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1830280 Offset: 0x1830381 VA: 0x1830280
	|-NativeDateTimeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1830330 Offset: 0x1830431 VA: 0x1830330
	|-NativeDateTimeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18303E0 Offset: 0x18304E1 VA: 0x18303E0
	|-NativeDateTimeResolver.GetFormatter<bool>
	|
	|-RVA: 0x1830490 Offset: 0x1830591 VA: 0x1830490
	|-NativeDateTimeResolver.GetFormatter<byte>
	|
	|-RVA: 0x1830540 Offset: 0x1830641 VA: 0x1830540
	|-NativeDateTimeResolver.GetFormatter<char>
	|
	|-RVA: 0x18305F0 Offset: 0x18306F1 VA: 0x18305F0
	|-NativeDateTimeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18306A0 Offset: 0x18307A1 VA: 0x18306A0
	|-NativeDateTimeResolver.GetFormatter<double>
	|
	|-RVA: 0x1830750 Offset: 0x1830851 VA: 0x1830750
	|-NativeDateTimeResolver.GetFormatter<short>
	|
	|-RVA: 0x1830800 Offset: 0x1830901 VA: 0x1830800
	|-NativeDateTimeResolver.GetFormatter<int>
	|
	|-RVA: 0x18308B0 Offset: 0x18309B1 VA: 0x18308B0
	|-NativeDateTimeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1830960 Offset: 0x1830A61 VA: 0x1830960
	|-NativeDateTimeResolver.GetFormatter<long>
	|
	|-RVA: 0x1830A10 Offset: 0x1830B11 VA: 0x1830A10
	|-NativeDateTimeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1830AC0 Offset: 0x1830BC1 VA: 0x1830AC0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1830B70 Offset: 0x1830C71 VA: 0x1830B70
	|-NativeDateTimeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1830C20 Offset: 0x1830D21 VA: 0x1830C20
	|-NativeDateTimeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1830CD0 Offset: 0x1830DD1 VA: 0x1830CD0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1830D80 Offset: 0x1830E81 VA: 0x1830D80
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1830E30 Offset: 0x1830F31 VA: 0x1830E30
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1830EE0 Offset: 0x1830FE1 VA: 0x1830EE0
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1830F90 Offset: 0x1831091 VA: 0x1830F90
	|-NativeDateTimeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1831040 Offset: 0x1831141 VA: 0x1831040
	|-NativeDateTimeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x18310F0 Offset: 0x18311F1 VA: 0x18310F0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18311A0 Offset: 0x18312A1 VA: 0x18311A0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1831250 Offset: 0x1831351 VA: 0x1831250
	|-NativeDateTimeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1831300 Offset: 0x1831401 VA: 0x1831300
	|-NativeDateTimeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18313B0 Offset: 0x18314B1 VA: 0x18313B0
	|-NativeDateTimeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1831460 Offset: 0x1831561 VA: 0x1831460
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1831510 Offset: 0x1831611 VA: 0x1831510
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18315C0 Offset: 0x18316C1 VA: 0x18315C0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1831670 Offset: 0x1831771 VA: 0x1831670
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1831720 Offset: 0x1831821 VA: 0x1831720
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18317D0 Offset: 0x18318D1 VA: 0x18317D0
	|-NativeDateTimeResolver.GetFormatter<object>
	|
	|-RVA: 0x1831880 Offset: 0x1831981 VA: 0x1831880
	|-NativeDateTimeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1831930 Offset: 0x1831A31 VA: 0x1831930
	|-NativeDateTimeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18319E0 Offset: 0x1831AE1 VA: 0x18319E0
	|-NativeDateTimeResolver.GetFormatter<float>
	|
	|-RVA: 0x1831A90 Offset: 0x1831B91 VA: 0x1831A90
	|-NativeDateTimeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1831B40 Offset: 0x1831C41 VA: 0x1831B40
	|-NativeDateTimeResolver.GetFormatter<uint>
	|
	|-RVA: 0x1831BF0 Offset: 0x1831CF1 VA: 0x1831BF0
	|-NativeDateTimeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1831CA0 Offset: 0x1831DA1 VA: 0x1831CA0
	|-NativeDateTimeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1831D50 Offset: 0x1831E51 VA: 0x1831D50
	|-NativeDateTimeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1831E00 Offset: 0x1831F01 VA: 0x1831E00
	|-NativeDateTimeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1831EB0 Offset: 0x1831FB1 VA: 0x1831EB0
	|-NativeDateTimeResolver.GetFormatter<Color>
	|
	|-RVA: 0x1831F60 Offset: 0x1832061 VA: 0x1831F60
	|-NativeDateTimeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1832010 Offset: 0x1832111 VA: 0x1832010
	|-NativeDateTimeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18320C0 Offset: 0x18321C1 VA: 0x18320C0
	|-NativeDateTimeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1832170 Offset: 0x1832271 VA: 0x1832170
	|-NativeDateTimeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1832220 Offset: 0x1832321 VA: 0x1832220
	|-NativeDateTimeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18322D0 Offset: 0x18323D1 VA: 0x18322D0
	|-NativeDateTimeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1832380 Offset: 0x1832481 VA: 0x1832380
	|-NativeDateTimeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1832430 Offset: 0x1832531 VA: 0x1832430
	|-NativeDateTimeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18324E0 Offset: 0x18325E1 VA: 0x18324E0
	|-NativeDateTimeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1832590 Offset: 0x1832691 VA: 0x1832590
	|-NativeDateTimeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1832640 Offset: 0x1832741 VA: 0x1832640
	|-NativeDateTimeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18326F0 Offset: 0x18327F1 VA: 0x18326F0
	|-NativeDateTimeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18327A0 Offset: 0x18328A1 VA: 0x18327A0
	|-NativeDateTimeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1832850 Offset: 0x1832951 VA: 0x1832850
	|-NativeDateTimeResolver.GetFormatter<Vector4>
	*/
}

public sealed class NativeDateTimeResolver : IFormatterResolver // TypeDefIndex: 5258
{
	// Fields
	public static readonly NativeDateTimeResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8750 Offset: 0x14F8851 VA: 0x14F8750
	private static void .cctor() { }

	// RVA: 0x14F8800 Offset: 0x14F8901 VA: 0x14F8800
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x182FC50 Offset: 0x182FD51 VA: 0x182FC50
	|-NativeDateTimeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x182FD00 Offset: 0x182FE01 VA: 0x182FD00
	|-NativeDateTimeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x182FDB0 Offset: 0x182FEB1 VA: 0x182FDB0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x182FE60 Offset: 0x182FF61 VA: 0x182FE60
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x182FF10 Offset: 0x1830011 VA: 0x182FF10
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x182FFC0 Offset: 0x18300C1 VA: 0x182FFC0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1830070 Offset: 0x1830171 VA: 0x1830070
	|-NativeDateTimeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1830120 Offset: 0x1830221 VA: 0x1830120
	|-NativeDateTimeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18301D0 Offset: 0x18302D1 VA: 0x18301D0
	|-NativeDateTimeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1830280 Offset: 0x1830381 VA: 0x1830280
	|-NativeDateTimeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1830330 Offset: 0x1830431 VA: 0x1830330
	|-NativeDateTimeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18303E0 Offset: 0x18304E1 VA: 0x18303E0
	|-NativeDateTimeResolver.GetFormatter<bool>
	|
	|-RVA: 0x1830490 Offset: 0x1830591 VA: 0x1830490
	|-NativeDateTimeResolver.GetFormatter<byte>
	|
	|-RVA: 0x1830540 Offset: 0x1830641 VA: 0x1830540
	|-NativeDateTimeResolver.GetFormatter<char>
	|
	|-RVA: 0x18305F0 Offset: 0x18306F1 VA: 0x18305F0
	|-NativeDateTimeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18306A0 Offset: 0x18307A1 VA: 0x18306A0
	|-NativeDateTimeResolver.GetFormatter<double>
	|
	|-RVA: 0x1830750 Offset: 0x1830851 VA: 0x1830750
	|-NativeDateTimeResolver.GetFormatter<short>
	|
	|-RVA: 0x1830800 Offset: 0x1830901 VA: 0x1830800
	|-NativeDateTimeResolver.GetFormatter<int>
	|
	|-RVA: 0x18308B0 Offset: 0x18309B1 VA: 0x18308B0
	|-NativeDateTimeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1830960 Offset: 0x1830A61 VA: 0x1830960
	|-NativeDateTimeResolver.GetFormatter<long>
	|
	|-RVA: 0x1830A10 Offset: 0x1830B11 VA: 0x1830A10
	|-NativeDateTimeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1830AC0 Offset: 0x1830BC1 VA: 0x1830AC0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1830B70 Offset: 0x1830C71 VA: 0x1830B70
	|-NativeDateTimeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1830C20 Offset: 0x1830D21 VA: 0x1830C20
	|-NativeDateTimeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1830CD0 Offset: 0x1830DD1 VA: 0x1830CD0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1830D80 Offset: 0x1830E81 VA: 0x1830D80
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1830E30 Offset: 0x1830F31 VA: 0x1830E30
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1830EE0 Offset: 0x1830FE1 VA: 0x1830EE0
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1830F90 Offset: 0x1831091 VA: 0x1830F90
	|-NativeDateTimeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1831040 Offset: 0x1831141 VA: 0x1831040
	|-NativeDateTimeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x18310F0 Offset: 0x18311F1 VA: 0x18310F0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18311A0 Offset: 0x18312A1 VA: 0x18311A0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1831250 Offset: 0x1831351 VA: 0x1831250
	|-NativeDateTimeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1831300 Offset: 0x1831401 VA: 0x1831300
	|-NativeDateTimeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18313B0 Offset: 0x18314B1 VA: 0x18313B0
	|-NativeDateTimeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1831460 Offset: 0x1831561 VA: 0x1831460
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1831510 Offset: 0x1831611 VA: 0x1831510
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18315C0 Offset: 0x18316C1 VA: 0x18315C0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1831670 Offset: 0x1831771 VA: 0x1831670
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1831720 Offset: 0x1831821 VA: 0x1831720
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18317D0 Offset: 0x18318D1 VA: 0x18317D0
	|-NativeDateTimeResolver.GetFormatter<object>
	|
	|-RVA: 0x1831880 Offset: 0x1831981 VA: 0x1831880
	|-NativeDateTimeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1831930 Offset: 0x1831A31 VA: 0x1831930
	|-NativeDateTimeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18319E0 Offset: 0x1831AE1 VA: 0x18319E0
	|-NativeDateTimeResolver.GetFormatter<float>
	|
	|-RVA: 0x1831A90 Offset: 0x1831B91 VA: 0x1831A90
	|-NativeDateTimeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1831B40 Offset: 0x1831C41 VA: 0x1831B40
	|-NativeDateTimeResolver.GetFormatter<uint>
	|
	|-RVA: 0x1831BF0 Offset: 0x1831CF1 VA: 0x1831BF0
	|-NativeDateTimeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1831CA0 Offset: 0x1831DA1 VA: 0x1831CA0
	|-NativeDateTimeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1831D50 Offset: 0x1831E51 VA: 0x1831D50
	|-NativeDateTimeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1831E00 Offset: 0x1831F01 VA: 0x1831E00
	|-NativeDateTimeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1831EB0 Offset: 0x1831FB1 VA: 0x1831EB0
	|-NativeDateTimeResolver.GetFormatter<Color>
	|
	|-RVA: 0x1831F60 Offset: 0x1832061 VA: 0x1831F60
	|-NativeDateTimeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1832010 Offset: 0x1832111 VA: 0x1832010
	|-NativeDateTimeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18320C0 Offset: 0x18321C1 VA: 0x18320C0
	|-NativeDateTimeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1832170 Offset: 0x1832271 VA: 0x1832170
	|-NativeDateTimeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1832220 Offset: 0x1832321 VA: 0x1832220
	|-NativeDateTimeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18322D0 Offset: 0x18323D1 VA: 0x18322D0
	|-NativeDateTimeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1832380 Offset: 0x1832481 VA: 0x1832380
	|-NativeDateTimeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1832430 Offset: 0x1832531 VA: 0x1832430
	|-NativeDateTimeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18324E0 Offset: 0x18325E1 VA: 0x18324E0
	|-NativeDateTimeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1832590 Offset: 0x1832691 VA: 0x1832590
	|-NativeDateTimeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1832640 Offset: 0x1832741 VA: 0x1832640
	|-NativeDateTimeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18326F0 Offset: 0x18327F1 VA: 0x18326F0
	|-NativeDateTimeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18327A0 Offset: 0x18328A1 VA: 0x18327A0
	|-NativeDateTimeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1832850 Offset: 0x1832951 VA: 0x1832850
	|-NativeDateTimeResolver.GetFormatter<Vector4>
	*/
}

public sealed class NativeDateTimeResolver : IFormatterResolver // TypeDefIndex: 5258
{
	// Fields
	public static readonly NativeDateTimeResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8750 Offset: 0x14F8851 VA: 0x14F8750
	private static void .cctor() { }

	// RVA: 0x14F8800 Offset: 0x14F8901 VA: 0x14F8800
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x182FC50 Offset: 0x182FD51 VA: 0x182FC50
	|-NativeDateTimeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x182FD00 Offset: 0x182FE01 VA: 0x182FD00
	|-NativeDateTimeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x182FDB0 Offset: 0x182FEB1 VA: 0x182FDB0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x182FE60 Offset: 0x182FF61 VA: 0x182FE60
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x182FF10 Offset: 0x1830011 VA: 0x182FF10
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x182FFC0 Offset: 0x18300C1 VA: 0x182FFC0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1830070 Offset: 0x1830171 VA: 0x1830070
	|-NativeDateTimeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1830120 Offset: 0x1830221 VA: 0x1830120
	|-NativeDateTimeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18301D0 Offset: 0x18302D1 VA: 0x18301D0
	|-NativeDateTimeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1830280 Offset: 0x1830381 VA: 0x1830280
	|-NativeDateTimeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1830330 Offset: 0x1830431 VA: 0x1830330
	|-NativeDateTimeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18303E0 Offset: 0x18304E1 VA: 0x18303E0
	|-NativeDateTimeResolver.GetFormatter<bool>
	|
	|-RVA: 0x1830490 Offset: 0x1830591 VA: 0x1830490
	|-NativeDateTimeResolver.GetFormatter<byte>
	|
	|-RVA: 0x1830540 Offset: 0x1830641 VA: 0x1830540
	|-NativeDateTimeResolver.GetFormatter<char>
	|
	|-RVA: 0x18305F0 Offset: 0x18306F1 VA: 0x18305F0
	|-NativeDateTimeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18306A0 Offset: 0x18307A1 VA: 0x18306A0
	|-NativeDateTimeResolver.GetFormatter<double>
	|
	|-RVA: 0x1830750 Offset: 0x1830851 VA: 0x1830750
	|-NativeDateTimeResolver.GetFormatter<short>
	|
	|-RVA: 0x1830800 Offset: 0x1830901 VA: 0x1830800
	|-NativeDateTimeResolver.GetFormatter<int>
	|
	|-RVA: 0x18308B0 Offset: 0x18309B1 VA: 0x18308B0
	|-NativeDateTimeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1830960 Offset: 0x1830A61 VA: 0x1830960
	|-NativeDateTimeResolver.GetFormatter<long>
	|
	|-RVA: 0x1830A10 Offset: 0x1830B11 VA: 0x1830A10
	|-NativeDateTimeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1830AC0 Offset: 0x1830BC1 VA: 0x1830AC0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1830B70 Offset: 0x1830C71 VA: 0x1830B70
	|-NativeDateTimeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1830C20 Offset: 0x1830D21 VA: 0x1830C20
	|-NativeDateTimeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1830CD0 Offset: 0x1830DD1 VA: 0x1830CD0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1830D80 Offset: 0x1830E81 VA: 0x1830D80
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1830E30 Offset: 0x1830F31 VA: 0x1830E30
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1830EE0 Offset: 0x1830FE1 VA: 0x1830EE0
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1830F90 Offset: 0x1831091 VA: 0x1830F90
	|-NativeDateTimeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1831040 Offset: 0x1831141 VA: 0x1831040
	|-NativeDateTimeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x18310F0 Offset: 0x18311F1 VA: 0x18310F0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18311A0 Offset: 0x18312A1 VA: 0x18311A0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1831250 Offset: 0x1831351 VA: 0x1831250
	|-NativeDateTimeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1831300 Offset: 0x1831401 VA: 0x1831300
	|-NativeDateTimeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18313B0 Offset: 0x18314B1 VA: 0x18313B0
	|-NativeDateTimeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1831460 Offset: 0x1831561 VA: 0x1831460
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1831510 Offset: 0x1831611 VA: 0x1831510
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18315C0 Offset: 0x18316C1 VA: 0x18315C0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1831670 Offset: 0x1831771 VA: 0x1831670
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1831720 Offset: 0x1831821 VA: 0x1831720
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18317D0 Offset: 0x18318D1 VA: 0x18317D0
	|-NativeDateTimeResolver.GetFormatter<object>
	|
	|-RVA: 0x1831880 Offset: 0x1831981 VA: 0x1831880
	|-NativeDateTimeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1831930 Offset: 0x1831A31 VA: 0x1831930
	|-NativeDateTimeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18319E0 Offset: 0x1831AE1 VA: 0x18319E0
	|-NativeDateTimeResolver.GetFormatter<float>
	|
	|-RVA: 0x1831A90 Offset: 0x1831B91 VA: 0x1831A90
	|-NativeDateTimeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1831B40 Offset: 0x1831C41 VA: 0x1831B40
	|-NativeDateTimeResolver.GetFormatter<uint>
	|
	|-RVA: 0x1831BF0 Offset: 0x1831CF1 VA: 0x1831BF0
	|-NativeDateTimeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1831CA0 Offset: 0x1831DA1 VA: 0x1831CA0
	|-NativeDateTimeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1831D50 Offset: 0x1831E51 VA: 0x1831D50
	|-NativeDateTimeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1831E00 Offset: 0x1831F01 VA: 0x1831E00
	|-NativeDateTimeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1831EB0 Offset: 0x1831FB1 VA: 0x1831EB0
	|-NativeDateTimeResolver.GetFormatter<Color>
	|
	|-RVA: 0x1831F60 Offset: 0x1832061 VA: 0x1831F60
	|-NativeDateTimeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1832010 Offset: 0x1832111 VA: 0x1832010
	|-NativeDateTimeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18320C0 Offset: 0x18321C1 VA: 0x18320C0
	|-NativeDateTimeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1832170 Offset: 0x1832271 VA: 0x1832170
	|-NativeDateTimeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1832220 Offset: 0x1832321 VA: 0x1832220
	|-NativeDateTimeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18322D0 Offset: 0x18323D1 VA: 0x18322D0
	|-NativeDateTimeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1832380 Offset: 0x1832481 VA: 0x1832380
	|-NativeDateTimeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1832430 Offset: 0x1832531 VA: 0x1832430
	|-NativeDateTimeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18324E0 Offset: 0x18325E1 VA: 0x18324E0
	|-NativeDateTimeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1832590 Offset: 0x1832691 VA: 0x1832590
	|-NativeDateTimeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1832640 Offset: 0x1832741 VA: 0x1832640
	|-NativeDateTimeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18326F0 Offset: 0x18327F1 VA: 0x18326F0
	|-NativeDateTimeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18327A0 Offset: 0x18328A1 VA: 0x18327A0
	|-NativeDateTimeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1832850 Offset: 0x1832951 VA: 0x1832850
	|-NativeDateTimeResolver.GetFormatter<Vector4>
	*/
}

public sealed class NativeDateTimeResolver : IFormatterResolver // TypeDefIndex: 5258
{
	// Fields
	public static readonly NativeDateTimeResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8750 Offset: 0x14F8851 VA: 0x14F8750
	private static void .cctor() { }

	// RVA: 0x14F8800 Offset: 0x14F8901 VA: 0x14F8800
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x182FC50 Offset: 0x182FD51 VA: 0x182FC50
	|-NativeDateTimeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x182FD00 Offset: 0x182FE01 VA: 0x182FD00
	|-NativeDateTimeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x182FDB0 Offset: 0x182FEB1 VA: 0x182FDB0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x182FE60 Offset: 0x182FF61 VA: 0x182FE60
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x182FF10 Offset: 0x1830011 VA: 0x182FF10
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x182FFC0 Offset: 0x18300C1 VA: 0x182FFC0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1830070 Offset: 0x1830171 VA: 0x1830070
	|-NativeDateTimeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1830120 Offset: 0x1830221 VA: 0x1830120
	|-NativeDateTimeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18301D0 Offset: 0x18302D1 VA: 0x18301D0
	|-NativeDateTimeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1830280 Offset: 0x1830381 VA: 0x1830280
	|-NativeDateTimeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1830330 Offset: 0x1830431 VA: 0x1830330
	|-NativeDateTimeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18303E0 Offset: 0x18304E1 VA: 0x18303E0
	|-NativeDateTimeResolver.GetFormatter<bool>
	|
	|-RVA: 0x1830490 Offset: 0x1830591 VA: 0x1830490
	|-NativeDateTimeResolver.GetFormatter<byte>
	|
	|-RVA: 0x1830540 Offset: 0x1830641 VA: 0x1830540
	|-NativeDateTimeResolver.GetFormatter<char>
	|
	|-RVA: 0x18305F0 Offset: 0x18306F1 VA: 0x18305F0
	|-NativeDateTimeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18306A0 Offset: 0x18307A1 VA: 0x18306A0
	|-NativeDateTimeResolver.GetFormatter<double>
	|
	|-RVA: 0x1830750 Offset: 0x1830851 VA: 0x1830750
	|-NativeDateTimeResolver.GetFormatter<short>
	|
	|-RVA: 0x1830800 Offset: 0x1830901 VA: 0x1830800
	|-NativeDateTimeResolver.GetFormatter<int>
	|
	|-RVA: 0x18308B0 Offset: 0x18309B1 VA: 0x18308B0
	|-NativeDateTimeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1830960 Offset: 0x1830A61 VA: 0x1830960
	|-NativeDateTimeResolver.GetFormatter<long>
	|
	|-RVA: 0x1830A10 Offset: 0x1830B11 VA: 0x1830A10
	|-NativeDateTimeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1830AC0 Offset: 0x1830BC1 VA: 0x1830AC0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1830B70 Offset: 0x1830C71 VA: 0x1830B70
	|-NativeDateTimeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1830C20 Offset: 0x1830D21 VA: 0x1830C20
	|-NativeDateTimeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1830CD0 Offset: 0x1830DD1 VA: 0x1830CD0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1830D80 Offset: 0x1830E81 VA: 0x1830D80
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1830E30 Offset: 0x1830F31 VA: 0x1830E30
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1830EE0 Offset: 0x1830FE1 VA: 0x1830EE0
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1830F90 Offset: 0x1831091 VA: 0x1830F90
	|-NativeDateTimeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1831040 Offset: 0x1831141 VA: 0x1831040
	|-NativeDateTimeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x18310F0 Offset: 0x18311F1 VA: 0x18310F0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18311A0 Offset: 0x18312A1 VA: 0x18311A0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1831250 Offset: 0x1831351 VA: 0x1831250
	|-NativeDateTimeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1831300 Offset: 0x1831401 VA: 0x1831300
	|-NativeDateTimeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18313B0 Offset: 0x18314B1 VA: 0x18313B0
	|-NativeDateTimeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1831460 Offset: 0x1831561 VA: 0x1831460
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1831510 Offset: 0x1831611 VA: 0x1831510
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18315C0 Offset: 0x18316C1 VA: 0x18315C0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1831670 Offset: 0x1831771 VA: 0x1831670
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1831720 Offset: 0x1831821 VA: 0x1831720
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18317D0 Offset: 0x18318D1 VA: 0x18317D0
	|-NativeDateTimeResolver.GetFormatter<object>
	|
	|-RVA: 0x1831880 Offset: 0x1831981 VA: 0x1831880
	|-NativeDateTimeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1831930 Offset: 0x1831A31 VA: 0x1831930
	|-NativeDateTimeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18319E0 Offset: 0x1831AE1 VA: 0x18319E0
	|-NativeDateTimeResolver.GetFormatter<float>
	|
	|-RVA: 0x1831A90 Offset: 0x1831B91 VA: 0x1831A90
	|-NativeDateTimeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1831B40 Offset: 0x1831C41 VA: 0x1831B40
	|-NativeDateTimeResolver.GetFormatter<uint>
	|
	|-RVA: 0x1831BF0 Offset: 0x1831CF1 VA: 0x1831BF0
	|-NativeDateTimeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1831CA0 Offset: 0x1831DA1 VA: 0x1831CA0
	|-NativeDateTimeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1831D50 Offset: 0x1831E51 VA: 0x1831D50
	|-NativeDateTimeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1831E00 Offset: 0x1831F01 VA: 0x1831E00
	|-NativeDateTimeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1831EB0 Offset: 0x1831FB1 VA: 0x1831EB0
	|-NativeDateTimeResolver.GetFormatter<Color>
	|
	|-RVA: 0x1831F60 Offset: 0x1832061 VA: 0x1831F60
	|-NativeDateTimeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1832010 Offset: 0x1832111 VA: 0x1832010
	|-NativeDateTimeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18320C0 Offset: 0x18321C1 VA: 0x18320C0
	|-NativeDateTimeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1832170 Offset: 0x1832271 VA: 0x1832170
	|-NativeDateTimeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1832220 Offset: 0x1832321 VA: 0x1832220
	|-NativeDateTimeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18322D0 Offset: 0x18323D1 VA: 0x18322D0
	|-NativeDateTimeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1832380 Offset: 0x1832481 VA: 0x1832380
	|-NativeDateTimeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1832430 Offset: 0x1832531 VA: 0x1832430
	|-NativeDateTimeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18324E0 Offset: 0x18325E1 VA: 0x18324E0
	|-NativeDateTimeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1832590 Offset: 0x1832691 VA: 0x1832590
	|-NativeDateTimeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1832640 Offset: 0x1832741 VA: 0x1832640
	|-NativeDateTimeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18326F0 Offset: 0x18327F1 VA: 0x18326F0
	|-NativeDateTimeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18327A0 Offset: 0x18328A1 VA: 0x18327A0
	|-NativeDateTimeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1832850 Offset: 0x1832951 VA: 0x1832850
	|-NativeDateTimeResolver.GetFormatter<Vector4>
	*/
}

public sealed class NativeDateTimeResolver : IFormatterResolver // TypeDefIndex: 5258
{
	// Fields
	public static readonly NativeDateTimeResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8750 Offset: 0x14F8851 VA: 0x14F8750
	private static void .cctor() { }

	// RVA: 0x14F8800 Offset: 0x14F8901 VA: 0x14F8800
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x182FC50 Offset: 0x182FD51 VA: 0x182FC50
	|-NativeDateTimeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x182FD00 Offset: 0x182FE01 VA: 0x182FD00
	|-NativeDateTimeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x182FDB0 Offset: 0x182FEB1 VA: 0x182FDB0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x182FE60 Offset: 0x182FF61 VA: 0x182FE60
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x182FF10 Offset: 0x1830011 VA: 0x182FF10
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x182FFC0 Offset: 0x18300C1 VA: 0x182FFC0
	|-NativeDateTimeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1830070 Offset: 0x1830171 VA: 0x1830070
	|-NativeDateTimeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1830120 Offset: 0x1830221 VA: 0x1830120
	|-NativeDateTimeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18301D0 Offset: 0x18302D1 VA: 0x18301D0
	|-NativeDateTimeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1830280 Offset: 0x1830381 VA: 0x1830280
	|-NativeDateTimeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1830330 Offset: 0x1830431 VA: 0x1830330
	|-NativeDateTimeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18303E0 Offset: 0x18304E1 VA: 0x18303E0
	|-NativeDateTimeResolver.GetFormatter<bool>
	|
	|-RVA: 0x1830490 Offset: 0x1830591 VA: 0x1830490
	|-NativeDateTimeResolver.GetFormatter<byte>
	|
	|-RVA: 0x1830540 Offset: 0x1830641 VA: 0x1830540
	|-NativeDateTimeResolver.GetFormatter<char>
	|
	|-RVA: 0x18305F0 Offset: 0x18306F1 VA: 0x18305F0
	|-NativeDateTimeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18306A0 Offset: 0x18307A1 VA: 0x18306A0
	|-NativeDateTimeResolver.GetFormatter<double>
	|
	|-RVA: 0x1830750 Offset: 0x1830851 VA: 0x1830750
	|-NativeDateTimeResolver.GetFormatter<short>
	|
	|-RVA: 0x1830800 Offset: 0x1830901 VA: 0x1830800
	|-NativeDateTimeResolver.GetFormatter<int>
	|
	|-RVA: 0x18308B0 Offset: 0x18309B1 VA: 0x18308B0
	|-NativeDateTimeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1830960 Offset: 0x1830A61 VA: 0x1830960
	|-NativeDateTimeResolver.GetFormatter<long>
	|
	|-RVA: 0x1830A10 Offset: 0x1830B11 VA: 0x1830A10
	|-NativeDateTimeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1830AC0 Offset: 0x1830BC1 VA: 0x1830AC0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1830B70 Offset: 0x1830C71 VA: 0x1830B70
	|-NativeDateTimeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1830C20 Offset: 0x1830D21 VA: 0x1830C20
	|-NativeDateTimeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1830CD0 Offset: 0x1830DD1 VA: 0x1830CD0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1830D80 Offset: 0x1830E81 VA: 0x1830D80
	|-NativeDateTimeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1830E30 Offset: 0x1830F31 VA: 0x1830E30
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1830EE0 Offset: 0x1830FE1 VA: 0x1830EE0
	|-NativeDateTimeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1830F90 Offset: 0x1831091 VA: 0x1830F90
	|-NativeDateTimeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1831040 Offset: 0x1831141 VA: 0x1831040
	|-NativeDateTimeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x18310F0 Offset: 0x18311F1 VA: 0x18310F0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18311A0 Offset: 0x18312A1 VA: 0x18311A0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1831250 Offset: 0x1831351 VA: 0x1831250
	|-NativeDateTimeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1831300 Offset: 0x1831401 VA: 0x1831300
	|-NativeDateTimeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18313B0 Offset: 0x18314B1 VA: 0x18313B0
	|-NativeDateTimeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1831460 Offset: 0x1831561 VA: 0x1831460
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1831510 Offset: 0x1831611 VA: 0x1831510
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18315C0 Offset: 0x18316C1 VA: 0x18315C0
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1831670 Offset: 0x1831771 VA: 0x1831670
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1831720 Offset: 0x1831821 VA: 0x1831720
	|-NativeDateTimeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18317D0 Offset: 0x18318D1 VA: 0x18317D0
	|-NativeDateTimeResolver.GetFormatter<object>
	|
	|-RVA: 0x1831880 Offset: 0x1831981 VA: 0x1831880
	|-NativeDateTimeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1831930 Offset: 0x1831A31 VA: 0x1831930
	|-NativeDateTimeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18319E0 Offset: 0x1831AE1 VA: 0x18319E0
	|-NativeDateTimeResolver.GetFormatter<float>
	|
	|-RVA: 0x1831A90 Offset: 0x1831B91 VA: 0x1831A90
	|-NativeDateTimeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1831B40 Offset: 0x1831C41 VA: 0x1831B40
	|-NativeDateTimeResolver.GetFormatter<uint>
	|
	|-RVA: 0x1831BF0 Offset: 0x1831CF1 VA: 0x1831BF0
	|-NativeDateTimeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1831CA0 Offset: 0x1831DA1 VA: 0x1831CA0
	|-NativeDateTimeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1831D50 Offset: 0x1831E51 VA: 0x1831D50
	|-NativeDateTimeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1831E00 Offset: 0x1831F01 VA: 0x1831E00
	|-NativeDateTimeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1831EB0 Offset: 0x1831FB1 VA: 0x1831EB0
	|-NativeDateTimeResolver.GetFormatter<Color>
	|
	|-RVA: 0x1831F60 Offset: 0x1832061 VA: 0x1831F60
	|-NativeDateTimeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1832010 Offset: 0x1832111 VA: 0x1832010
	|-NativeDateTimeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18320C0 Offset: 0x18321C1 VA: 0x18320C0
	|-NativeDateTimeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1832170 Offset: 0x1832271 VA: 0x1832170
	|-NativeDateTimeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1832220 Offset: 0x1832321 VA: 0x1832220
	|-NativeDateTimeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18322D0 Offset: 0x18323D1 VA: 0x18322D0
	|-NativeDateTimeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1832380 Offset: 0x1832481 VA: 0x1832380
	|-NativeDateTimeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1832430 Offset: 0x1832531 VA: 0x1832430
	|-NativeDateTimeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18324E0 Offset: 0x18325E1 VA: 0x18324E0
	|-NativeDateTimeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1832590 Offset: 0x1832691 VA: 0x1832590
	|-NativeDateTimeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1832640 Offset: 0x1832741 VA: 0x1832640
	|-NativeDateTimeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18326F0 Offset: 0x18327F1 VA: 0x18326F0
	|-NativeDateTimeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18327A0 Offset: 0x18328A1 VA: 0x18327A0
	|-NativeDateTimeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1832850 Offset: 0x1832951 VA: 0x1832850
	|-NativeDateTimeResolver.GetFormatter<Vector4>
	*/
}

