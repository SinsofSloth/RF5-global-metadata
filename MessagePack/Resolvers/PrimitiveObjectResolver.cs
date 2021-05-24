public sealed class PrimitiveObjectResolver : IFormatterResolver // TypeDefIndex: 5264
{
	// Fields
	public static readonly PrimitiveObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8BF0 Offset: 0x14F8CF1 VA: 0x14F8BF0
	private static void .cctor() { }

	// RVA: 0x14F8CA0 Offset: 0x14F8DA1 VA: 0x14F8CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FC320 Offset: 0x27FC421 VA: 0x27FC320
	|-PrimitiveObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27FC3D0 Offset: 0x27FC4D1 VA: 0x27FC3D0
	|-PrimitiveObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27FC480 Offset: 0x27FC581 VA: 0x27FC480
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27FC530 Offset: 0x27FC631 VA: 0x27FC530
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27FC5E0 Offset: 0x27FC6E1 VA: 0x27FC5E0
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27FC690 Offset: 0x27FC791 VA: 0x27FC690
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27FC740 Offset: 0x27FC841 VA: 0x27FC740
	|-PrimitiveObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27FC7F0 Offset: 0x27FC8F1 VA: 0x27FC7F0
	|-PrimitiveObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27FC8A0 Offset: 0x27FC9A1 VA: 0x27FC8A0
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27FC950 Offset: 0x27FCA51 VA: 0x27FC950
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27FCA00 Offset: 0x27FCB01 VA: 0x27FCA00
	|-PrimitiveObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27FCAB0 Offset: 0x27FCBB1 VA: 0x27FCAB0
	|-PrimitiveObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x27FCB60 Offset: 0x27FCC61 VA: 0x27FCB60
	|-PrimitiveObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x27FCC10 Offset: 0x27FCD11 VA: 0x27FCC10
	|-PrimitiveObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x27FCCC0 Offset: 0x27FCDC1 VA: 0x27FCCC0
	|-PrimitiveObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FCD70 Offset: 0x27FCE71 VA: 0x27FCD70
	|-PrimitiveObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x27FCE20 Offset: 0x27FCF21 VA: 0x27FCE20
	|-PrimitiveObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x27FCED0 Offset: 0x27FCFD1 VA: 0x27FCED0
	|-PrimitiveObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x27FCF80 Offset: 0x27FD081 VA: 0x27FCF80
	|-PrimitiveObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FD030 Offset: 0x27FD131 VA: 0x27FD030
	|-PrimitiveObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x27FD0E0 Offset: 0x27FD1E1 VA: 0x27FD0E0
	|-PrimitiveObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FD190 Offset: 0x27FD291 VA: 0x27FD190
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FD240 Offset: 0x27FD341 VA: 0x27FD240
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FD2F0 Offset: 0x27FD3F1 VA: 0x27FD2F0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FD3A0 Offset: 0x27FD4A1 VA: 0x27FD3A0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FD450 Offset: 0x27FD551 VA: 0x27FD450
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FD500 Offset: 0x27FD601 VA: 0x27FD500
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FD5B0 Offset: 0x27FD6B1 VA: 0x27FD5B0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FD660 Offset: 0x27FD761 VA: 0x27FD660
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FD710 Offset: 0x27FD811 VA: 0x27FD710
	|-PrimitiveObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FD7C0 Offset: 0x27FD8C1 VA: 0x27FD7C0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FD870 Offset: 0x27FD971 VA: 0x27FD870
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FD920 Offset: 0x27FDA21 VA: 0x27FD920
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FD9D0 Offset: 0x27FDAD1 VA: 0x27FD9D0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FDA80 Offset: 0x27FDB81 VA: 0x27FDA80
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FDB30 Offset: 0x27FDC31 VA: 0x27FDB30
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FDBE0 Offset: 0x27FDCE1 VA: 0x27FDBE0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FDC90 Offset: 0x27FDD91 VA: 0x27FDC90
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FDD40 Offset: 0x27FDE41 VA: 0x27FDD40
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FDDF0 Offset: 0x27FDEF1 VA: 0x27FDDF0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FDEA0 Offset: 0x27FDFA1 VA: 0x27FDEA0
	|-PrimitiveObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x27FDF50 Offset: 0x27FE051 VA: 0x27FDF50
	|-PrimitiveObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FE000 Offset: 0x27FE101 VA: 0x27FE000
	|-PrimitiveObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FE0B0 Offset: 0x27FE1B1 VA: 0x27FE0B0
	|-PrimitiveObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x27FE160 Offset: 0x27FE261 VA: 0x27FE160
	|-PrimitiveObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FE210 Offset: 0x27FE311 VA: 0x27FE210
	|-PrimitiveObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FE2C0 Offset: 0x27FE3C1 VA: 0x27FE2C0
	|-PrimitiveObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FE370 Offset: 0x27FE471 VA: 0x27FE370
	|-PrimitiveObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FE420 Offset: 0x27FE521 VA: 0x27FE420
	|-PrimitiveObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FE4D0 Offset: 0x27FE5D1 VA: 0x27FE4D0
	|-PrimitiveObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FE580 Offset: 0x27FE681 VA: 0x27FE580
	|-PrimitiveObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FE630 Offset: 0x27FE731 VA: 0x27FE630
	|-PrimitiveObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FE6E0 Offset: 0x27FE7E1 VA: 0x27FE6E0
	|-PrimitiveObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FE790 Offset: 0x27FE891 VA: 0x27FE790
	|-PrimitiveObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FE840 Offset: 0x27FE941 VA: 0x27FE840
	|-PrimitiveObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FE8F0 Offset: 0x27FE9F1 VA: 0x27FE8F0
	|-PrimitiveObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FE9A0 Offset: 0x27FEAA1 VA: 0x27FE9A0
	|-PrimitiveObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FEA50 Offset: 0x27FEB51 VA: 0x27FEA50
	|-PrimitiveObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FEB00 Offset: 0x27FEC01 VA: 0x27FEB00
	|-PrimitiveObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FEBB0 Offset: 0x27FECB1 VA: 0x27FEBB0
	|-PrimitiveObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FEC60 Offset: 0x27FED61 VA: 0x27FEC60
	|-PrimitiveObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FED10 Offset: 0x27FEE11 VA: 0x27FED10
	|-PrimitiveObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FEDC0 Offset: 0x27FEEC1 VA: 0x27FEDC0
	|-PrimitiveObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FEE70 Offset: 0x27FEF71 VA: 0x27FEE70
	|-PrimitiveObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FEF20 Offset: 0x27FF021 VA: 0x27FEF20
	|-PrimitiveObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class PrimitiveObjectResolver : IFormatterResolver // TypeDefIndex: 5264
{
	// Fields
	public static readonly PrimitiveObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8BF0 Offset: 0x14F8CF1 VA: 0x14F8BF0
	private static void .cctor() { }

	// RVA: 0x14F8CA0 Offset: 0x14F8DA1 VA: 0x14F8CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FC320 Offset: 0x27FC421 VA: 0x27FC320
	|-PrimitiveObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27FC3D0 Offset: 0x27FC4D1 VA: 0x27FC3D0
	|-PrimitiveObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27FC480 Offset: 0x27FC581 VA: 0x27FC480
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27FC530 Offset: 0x27FC631 VA: 0x27FC530
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27FC5E0 Offset: 0x27FC6E1 VA: 0x27FC5E0
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27FC690 Offset: 0x27FC791 VA: 0x27FC690
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27FC740 Offset: 0x27FC841 VA: 0x27FC740
	|-PrimitiveObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27FC7F0 Offset: 0x27FC8F1 VA: 0x27FC7F0
	|-PrimitiveObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27FC8A0 Offset: 0x27FC9A1 VA: 0x27FC8A0
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27FC950 Offset: 0x27FCA51 VA: 0x27FC950
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27FCA00 Offset: 0x27FCB01 VA: 0x27FCA00
	|-PrimitiveObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27FCAB0 Offset: 0x27FCBB1 VA: 0x27FCAB0
	|-PrimitiveObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x27FCB60 Offset: 0x27FCC61 VA: 0x27FCB60
	|-PrimitiveObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x27FCC10 Offset: 0x27FCD11 VA: 0x27FCC10
	|-PrimitiveObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x27FCCC0 Offset: 0x27FCDC1 VA: 0x27FCCC0
	|-PrimitiveObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FCD70 Offset: 0x27FCE71 VA: 0x27FCD70
	|-PrimitiveObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x27FCE20 Offset: 0x27FCF21 VA: 0x27FCE20
	|-PrimitiveObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x27FCED0 Offset: 0x27FCFD1 VA: 0x27FCED0
	|-PrimitiveObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x27FCF80 Offset: 0x27FD081 VA: 0x27FCF80
	|-PrimitiveObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FD030 Offset: 0x27FD131 VA: 0x27FD030
	|-PrimitiveObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x27FD0E0 Offset: 0x27FD1E1 VA: 0x27FD0E0
	|-PrimitiveObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FD190 Offset: 0x27FD291 VA: 0x27FD190
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FD240 Offset: 0x27FD341 VA: 0x27FD240
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FD2F0 Offset: 0x27FD3F1 VA: 0x27FD2F0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FD3A0 Offset: 0x27FD4A1 VA: 0x27FD3A0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FD450 Offset: 0x27FD551 VA: 0x27FD450
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FD500 Offset: 0x27FD601 VA: 0x27FD500
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FD5B0 Offset: 0x27FD6B1 VA: 0x27FD5B0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FD660 Offset: 0x27FD761 VA: 0x27FD660
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FD710 Offset: 0x27FD811 VA: 0x27FD710
	|-PrimitiveObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FD7C0 Offset: 0x27FD8C1 VA: 0x27FD7C0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FD870 Offset: 0x27FD971 VA: 0x27FD870
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FD920 Offset: 0x27FDA21 VA: 0x27FD920
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FD9D0 Offset: 0x27FDAD1 VA: 0x27FD9D0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FDA80 Offset: 0x27FDB81 VA: 0x27FDA80
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FDB30 Offset: 0x27FDC31 VA: 0x27FDB30
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FDBE0 Offset: 0x27FDCE1 VA: 0x27FDBE0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FDC90 Offset: 0x27FDD91 VA: 0x27FDC90
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FDD40 Offset: 0x27FDE41 VA: 0x27FDD40
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FDDF0 Offset: 0x27FDEF1 VA: 0x27FDDF0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FDEA0 Offset: 0x27FDFA1 VA: 0x27FDEA0
	|-PrimitiveObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x27FDF50 Offset: 0x27FE051 VA: 0x27FDF50
	|-PrimitiveObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FE000 Offset: 0x27FE101 VA: 0x27FE000
	|-PrimitiveObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FE0B0 Offset: 0x27FE1B1 VA: 0x27FE0B0
	|-PrimitiveObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x27FE160 Offset: 0x27FE261 VA: 0x27FE160
	|-PrimitiveObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FE210 Offset: 0x27FE311 VA: 0x27FE210
	|-PrimitiveObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FE2C0 Offset: 0x27FE3C1 VA: 0x27FE2C0
	|-PrimitiveObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FE370 Offset: 0x27FE471 VA: 0x27FE370
	|-PrimitiveObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FE420 Offset: 0x27FE521 VA: 0x27FE420
	|-PrimitiveObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FE4D0 Offset: 0x27FE5D1 VA: 0x27FE4D0
	|-PrimitiveObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FE580 Offset: 0x27FE681 VA: 0x27FE580
	|-PrimitiveObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FE630 Offset: 0x27FE731 VA: 0x27FE630
	|-PrimitiveObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FE6E0 Offset: 0x27FE7E1 VA: 0x27FE6E0
	|-PrimitiveObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FE790 Offset: 0x27FE891 VA: 0x27FE790
	|-PrimitiveObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FE840 Offset: 0x27FE941 VA: 0x27FE840
	|-PrimitiveObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FE8F0 Offset: 0x27FE9F1 VA: 0x27FE8F0
	|-PrimitiveObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FE9A0 Offset: 0x27FEAA1 VA: 0x27FE9A0
	|-PrimitiveObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FEA50 Offset: 0x27FEB51 VA: 0x27FEA50
	|-PrimitiveObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FEB00 Offset: 0x27FEC01 VA: 0x27FEB00
	|-PrimitiveObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FEBB0 Offset: 0x27FECB1 VA: 0x27FEBB0
	|-PrimitiveObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FEC60 Offset: 0x27FED61 VA: 0x27FEC60
	|-PrimitiveObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FED10 Offset: 0x27FEE11 VA: 0x27FED10
	|-PrimitiveObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FEDC0 Offset: 0x27FEEC1 VA: 0x27FEDC0
	|-PrimitiveObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FEE70 Offset: 0x27FEF71 VA: 0x27FEE70
	|-PrimitiveObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FEF20 Offset: 0x27FF021 VA: 0x27FEF20
	|-PrimitiveObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class PrimitiveObjectResolver : IFormatterResolver // TypeDefIndex: 5264
{
	// Fields
	public static readonly PrimitiveObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8BF0 Offset: 0x14F8CF1 VA: 0x14F8BF0
	private static void .cctor() { }

	// RVA: 0x14F8CA0 Offset: 0x14F8DA1 VA: 0x14F8CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FC320 Offset: 0x27FC421 VA: 0x27FC320
	|-PrimitiveObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27FC3D0 Offset: 0x27FC4D1 VA: 0x27FC3D0
	|-PrimitiveObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27FC480 Offset: 0x27FC581 VA: 0x27FC480
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27FC530 Offset: 0x27FC631 VA: 0x27FC530
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27FC5E0 Offset: 0x27FC6E1 VA: 0x27FC5E0
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27FC690 Offset: 0x27FC791 VA: 0x27FC690
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27FC740 Offset: 0x27FC841 VA: 0x27FC740
	|-PrimitiveObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27FC7F0 Offset: 0x27FC8F1 VA: 0x27FC7F0
	|-PrimitiveObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27FC8A0 Offset: 0x27FC9A1 VA: 0x27FC8A0
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27FC950 Offset: 0x27FCA51 VA: 0x27FC950
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27FCA00 Offset: 0x27FCB01 VA: 0x27FCA00
	|-PrimitiveObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27FCAB0 Offset: 0x27FCBB1 VA: 0x27FCAB0
	|-PrimitiveObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x27FCB60 Offset: 0x27FCC61 VA: 0x27FCB60
	|-PrimitiveObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x27FCC10 Offset: 0x27FCD11 VA: 0x27FCC10
	|-PrimitiveObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x27FCCC0 Offset: 0x27FCDC1 VA: 0x27FCCC0
	|-PrimitiveObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FCD70 Offset: 0x27FCE71 VA: 0x27FCD70
	|-PrimitiveObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x27FCE20 Offset: 0x27FCF21 VA: 0x27FCE20
	|-PrimitiveObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x27FCED0 Offset: 0x27FCFD1 VA: 0x27FCED0
	|-PrimitiveObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x27FCF80 Offset: 0x27FD081 VA: 0x27FCF80
	|-PrimitiveObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FD030 Offset: 0x27FD131 VA: 0x27FD030
	|-PrimitiveObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x27FD0E0 Offset: 0x27FD1E1 VA: 0x27FD0E0
	|-PrimitiveObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FD190 Offset: 0x27FD291 VA: 0x27FD190
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FD240 Offset: 0x27FD341 VA: 0x27FD240
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FD2F0 Offset: 0x27FD3F1 VA: 0x27FD2F0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FD3A0 Offset: 0x27FD4A1 VA: 0x27FD3A0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FD450 Offset: 0x27FD551 VA: 0x27FD450
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FD500 Offset: 0x27FD601 VA: 0x27FD500
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FD5B0 Offset: 0x27FD6B1 VA: 0x27FD5B0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FD660 Offset: 0x27FD761 VA: 0x27FD660
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FD710 Offset: 0x27FD811 VA: 0x27FD710
	|-PrimitiveObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FD7C0 Offset: 0x27FD8C1 VA: 0x27FD7C0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FD870 Offset: 0x27FD971 VA: 0x27FD870
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FD920 Offset: 0x27FDA21 VA: 0x27FD920
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FD9D0 Offset: 0x27FDAD1 VA: 0x27FD9D0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FDA80 Offset: 0x27FDB81 VA: 0x27FDA80
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FDB30 Offset: 0x27FDC31 VA: 0x27FDB30
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FDBE0 Offset: 0x27FDCE1 VA: 0x27FDBE0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FDC90 Offset: 0x27FDD91 VA: 0x27FDC90
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FDD40 Offset: 0x27FDE41 VA: 0x27FDD40
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FDDF0 Offset: 0x27FDEF1 VA: 0x27FDDF0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FDEA0 Offset: 0x27FDFA1 VA: 0x27FDEA0
	|-PrimitiveObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x27FDF50 Offset: 0x27FE051 VA: 0x27FDF50
	|-PrimitiveObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FE000 Offset: 0x27FE101 VA: 0x27FE000
	|-PrimitiveObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FE0B0 Offset: 0x27FE1B1 VA: 0x27FE0B0
	|-PrimitiveObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x27FE160 Offset: 0x27FE261 VA: 0x27FE160
	|-PrimitiveObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FE210 Offset: 0x27FE311 VA: 0x27FE210
	|-PrimitiveObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FE2C0 Offset: 0x27FE3C1 VA: 0x27FE2C0
	|-PrimitiveObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FE370 Offset: 0x27FE471 VA: 0x27FE370
	|-PrimitiveObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FE420 Offset: 0x27FE521 VA: 0x27FE420
	|-PrimitiveObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FE4D0 Offset: 0x27FE5D1 VA: 0x27FE4D0
	|-PrimitiveObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FE580 Offset: 0x27FE681 VA: 0x27FE580
	|-PrimitiveObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FE630 Offset: 0x27FE731 VA: 0x27FE630
	|-PrimitiveObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FE6E0 Offset: 0x27FE7E1 VA: 0x27FE6E0
	|-PrimitiveObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FE790 Offset: 0x27FE891 VA: 0x27FE790
	|-PrimitiveObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FE840 Offset: 0x27FE941 VA: 0x27FE840
	|-PrimitiveObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FE8F0 Offset: 0x27FE9F1 VA: 0x27FE8F0
	|-PrimitiveObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FE9A0 Offset: 0x27FEAA1 VA: 0x27FE9A0
	|-PrimitiveObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FEA50 Offset: 0x27FEB51 VA: 0x27FEA50
	|-PrimitiveObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FEB00 Offset: 0x27FEC01 VA: 0x27FEB00
	|-PrimitiveObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FEBB0 Offset: 0x27FECB1 VA: 0x27FEBB0
	|-PrimitiveObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FEC60 Offset: 0x27FED61 VA: 0x27FEC60
	|-PrimitiveObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FED10 Offset: 0x27FEE11 VA: 0x27FED10
	|-PrimitiveObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FEDC0 Offset: 0x27FEEC1 VA: 0x27FEDC0
	|-PrimitiveObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FEE70 Offset: 0x27FEF71 VA: 0x27FEE70
	|-PrimitiveObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FEF20 Offset: 0x27FF021 VA: 0x27FEF20
	|-PrimitiveObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class PrimitiveObjectResolver : IFormatterResolver // TypeDefIndex: 5264
{
	// Fields
	public static readonly PrimitiveObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8BF0 Offset: 0x14F8CF1 VA: 0x14F8BF0
	private static void .cctor() { }

	// RVA: 0x14F8CA0 Offset: 0x14F8DA1 VA: 0x14F8CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FC320 Offset: 0x27FC421 VA: 0x27FC320
	|-PrimitiveObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27FC3D0 Offset: 0x27FC4D1 VA: 0x27FC3D0
	|-PrimitiveObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27FC480 Offset: 0x27FC581 VA: 0x27FC480
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27FC530 Offset: 0x27FC631 VA: 0x27FC530
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27FC5E0 Offset: 0x27FC6E1 VA: 0x27FC5E0
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27FC690 Offset: 0x27FC791 VA: 0x27FC690
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27FC740 Offset: 0x27FC841 VA: 0x27FC740
	|-PrimitiveObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27FC7F0 Offset: 0x27FC8F1 VA: 0x27FC7F0
	|-PrimitiveObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27FC8A0 Offset: 0x27FC9A1 VA: 0x27FC8A0
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27FC950 Offset: 0x27FCA51 VA: 0x27FC950
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27FCA00 Offset: 0x27FCB01 VA: 0x27FCA00
	|-PrimitiveObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27FCAB0 Offset: 0x27FCBB1 VA: 0x27FCAB0
	|-PrimitiveObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x27FCB60 Offset: 0x27FCC61 VA: 0x27FCB60
	|-PrimitiveObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x27FCC10 Offset: 0x27FCD11 VA: 0x27FCC10
	|-PrimitiveObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x27FCCC0 Offset: 0x27FCDC1 VA: 0x27FCCC0
	|-PrimitiveObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FCD70 Offset: 0x27FCE71 VA: 0x27FCD70
	|-PrimitiveObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x27FCE20 Offset: 0x27FCF21 VA: 0x27FCE20
	|-PrimitiveObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x27FCED0 Offset: 0x27FCFD1 VA: 0x27FCED0
	|-PrimitiveObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x27FCF80 Offset: 0x27FD081 VA: 0x27FCF80
	|-PrimitiveObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FD030 Offset: 0x27FD131 VA: 0x27FD030
	|-PrimitiveObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x27FD0E0 Offset: 0x27FD1E1 VA: 0x27FD0E0
	|-PrimitiveObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FD190 Offset: 0x27FD291 VA: 0x27FD190
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FD240 Offset: 0x27FD341 VA: 0x27FD240
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FD2F0 Offset: 0x27FD3F1 VA: 0x27FD2F0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FD3A0 Offset: 0x27FD4A1 VA: 0x27FD3A0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FD450 Offset: 0x27FD551 VA: 0x27FD450
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FD500 Offset: 0x27FD601 VA: 0x27FD500
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FD5B0 Offset: 0x27FD6B1 VA: 0x27FD5B0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FD660 Offset: 0x27FD761 VA: 0x27FD660
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FD710 Offset: 0x27FD811 VA: 0x27FD710
	|-PrimitiveObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FD7C0 Offset: 0x27FD8C1 VA: 0x27FD7C0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FD870 Offset: 0x27FD971 VA: 0x27FD870
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FD920 Offset: 0x27FDA21 VA: 0x27FD920
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FD9D0 Offset: 0x27FDAD1 VA: 0x27FD9D0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FDA80 Offset: 0x27FDB81 VA: 0x27FDA80
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FDB30 Offset: 0x27FDC31 VA: 0x27FDB30
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FDBE0 Offset: 0x27FDCE1 VA: 0x27FDBE0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FDC90 Offset: 0x27FDD91 VA: 0x27FDC90
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FDD40 Offset: 0x27FDE41 VA: 0x27FDD40
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FDDF0 Offset: 0x27FDEF1 VA: 0x27FDDF0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FDEA0 Offset: 0x27FDFA1 VA: 0x27FDEA0
	|-PrimitiveObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x27FDF50 Offset: 0x27FE051 VA: 0x27FDF50
	|-PrimitiveObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FE000 Offset: 0x27FE101 VA: 0x27FE000
	|-PrimitiveObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FE0B0 Offset: 0x27FE1B1 VA: 0x27FE0B0
	|-PrimitiveObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x27FE160 Offset: 0x27FE261 VA: 0x27FE160
	|-PrimitiveObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FE210 Offset: 0x27FE311 VA: 0x27FE210
	|-PrimitiveObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FE2C0 Offset: 0x27FE3C1 VA: 0x27FE2C0
	|-PrimitiveObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FE370 Offset: 0x27FE471 VA: 0x27FE370
	|-PrimitiveObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FE420 Offset: 0x27FE521 VA: 0x27FE420
	|-PrimitiveObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FE4D0 Offset: 0x27FE5D1 VA: 0x27FE4D0
	|-PrimitiveObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FE580 Offset: 0x27FE681 VA: 0x27FE580
	|-PrimitiveObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FE630 Offset: 0x27FE731 VA: 0x27FE630
	|-PrimitiveObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FE6E0 Offset: 0x27FE7E1 VA: 0x27FE6E0
	|-PrimitiveObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FE790 Offset: 0x27FE891 VA: 0x27FE790
	|-PrimitiveObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FE840 Offset: 0x27FE941 VA: 0x27FE840
	|-PrimitiveObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FE8F0 Offset: 0x27FE9F1 VA: 0x27FE8F0
	|-PrimitiveObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FE9A0 Offset: 0x27FEAA1 VA: 0x27FE9A0
	|-PrimitiveObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FEA50 Offset: 0x27FEB51 VA: 0x27FEA50
	|-PrimitiveObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FEB00 Offset: 0x27FEC01 VA: 0x27FEB00
	|-PrimitiveObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FEBB0 Offset: 0x27FECB1 VA: 0x27FEBB0
	|-PrimitiveObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FEC60 Offset: 0x27FED61 VA: 0x27FEC60
	|-PrimitiveObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FED10 Offset: 0x27FEE11 VA: 0x27FED10
	|-PrimitiveObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FEDC0 Offset: 0x27FEEC1 VA: 0x27FEDC0
	|-PrimitiveObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FEE70 Offset: 0x27FEF71 VA: 0x27FEE70
	|-PrimitiveObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FEF20 Offset: 0x27FF021 VA: 0x27FEF20
	|-PrimitiveObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class PrimitiveObjectResolver : IFormatterResolver // TypeDefIndex: 5264
{
	// Fields
	public static readonly PrimitiveObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F8BF0 Offset: 0x14F8CF1 VA: 0x14F8BF0
	private static void .cctor() { }

	// RVA: 0x14F8CA0 Offset: 0x14F8DA1 VA: 0x14F8CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FC320 Offset: 0x27FC421 VA: 0x27FC320
	|-PrimitiveObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27FC3D0 Offset: 0x27FC4D1 VA: 0x27FC3D0
	|-PrimitiveObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27FC480 Offset: 0x27FC581 VA: 0x27FC480
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27FC530 Offset: 0x27FC631 VA: 0x27FC530
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27FC5E0 Offset: 0x27FC6E1 VA: 0x27FC5E0
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27FC690 Offset: 0x27FC791 VA: 0x27FC690
	|-PrimitiveObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27FC740 Offset: 0x27FC841 VA: 0x27FC740
	|-PrimitiveObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27FC7F0 Offset: 0x27FC8F1 VA: 0x27FC7F0
	|-PrimitiveObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27FC8A0 Offset: 0x27FC9A1 VA: 0x27FC8A0
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27FC950 Offset: 0x27FCA51 VA: 0x27FC950
	|-PrimitiveObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27FCA00 Offset: 0x27FCB01 VA: 0x27FCA00
	|-PrimitiveObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27FCAB0 Offset: 0x27FCBB1 VA: 0x27FCAB0
	|-PrimitiveObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x27FCB60 Offset: 0x27FCC61 VA: 0x27FCB60
	|-PrimitiveObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x27FCC10 Offset: 0x27FCD11 VA: 0x27FCC10
	|-PrimitiveObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x27FCCC0 Offset: 0x27FCDC1 VA: 0x27FCCC0
	|-PrimitiveObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FCD70 Offset: 0x27FCE71 VA: 0x27FCD70
	|-PrimitiveObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x27FCE20 Offset: 0x27FCF21 VA: 0x27FCE20
	|-PrimitiveObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x27FCED0 Offset: 0x27FCFD1 VA: 0x27FCED0
	|-PrimitiveObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x27FCF80 Offset: 0x27FD081 VA: 0x27FCF80
	|-PrimitiveObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FD030 Offset: 0x27FD131 VA: 0x27FD030
	|-PrimitiveObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x27FD0E0 Offset: 0x27FD1E1 VA: 0x27FD0E0
	|-PrimitiveObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FD190 Offset: 0x27FD291 VA: 0x27FD190
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FD240 Offset: 0x27FD341 VA: 0x27FD240
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FD2F0 Offset: 0x27FD3F1 VA: 0x27FD2F0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FD3A0 Offset: 0x27FD4A1 VA: 0x27FD3A0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FD450 Offset: 0x27FD551 VA: 0x27FD450
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FD500 Offset: 0x27FD601 VA: 0x27FD500
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FD5B0 Offset: 0x27FD6B1 VA: 0x27FD5B0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FD660 Offset: 0x27FD761 VA: 0x27FD660
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FD710 Offset: 0x27FD811 VA: 0x27FD710
	|-PrimitiveObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FD7C0 Offset: 0x27FD8C1 VA: 0x27FD7C0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FD870 Offset: 0x27FD971 VA: 0x27FD870
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FD920 Offset: 0x27FDA21 VA: 0x27FD920
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FD9D0 Offset: 0x27FDAD1 VA: 0x27FD9D0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FDA80 Offset: 0x27FDB81 VA: 0x27FDA80
	|-PrimitiveObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FDB30 Offset: 0x27FDC31 VA: 0x27FDB30
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FDBE0 Offset: 0x27FDCE1 VA: 0x27FDBE0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FDC90 Offset: 0x27FDD91 VA: 0x27FDC90
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FDD40 Offset: 0x27FDE41 VA: 0x27FDD40
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FDDF0 Offset: 0x27FDEF1 VA: 0x27FDDF0
	|-PrimitiveObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FDEA0 Offset: 0x27FDFA1 VA: 0x27FDEA0
	|-PrimitiveObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x27FDF50 Offset: 0x27FE051 VA: 0x27FDF50
	|-PrimitiveObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FE000 Offset: 0x27FE101 VA: 0x27FE000
	|-PrimitiveObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FE0B0 Offset: 0x27FE1B1 VA: 0x27FE0B0
	|-PrimitiveObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x27FE160 Offset: 0x27FE261 VA: 0x27FE160
	|-PrimitiveObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FE210 Offset: 0x27FE311 VA: 0x27FE210
	|-PrimitiveObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FE2C0 Offset: 0x27FE3C1 VA: 0x27FE2C0
	|-PrimitiveObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FE370 Offset: 0x27FE471 VA: 0x27FE370
	|-PrimitiveObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FE420 Offset: 0x27FE521 VA: 0x27FE420
	|-PrimitiveObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FE4D0 Offset: 0x27FE5D1 VA: 0x27FE4D0
	|-PrimitiveObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FE580 Offset: 0x27FE681 VA: 0x27FE580
	|-PrimitiveObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FE630 Offset: 0x27FE731 VA: 0x27FE630
	|-PrimitiveObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FE6E0 Offset: 0x27FE7E1 VA: 0x27FE6E0
	|-PrimitiveObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FE790 Offset: 0x27FE891 VA: 0x27FE790
	|-PrimitiveObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FE840 Offset: 0x27FE941 VA: 0x27FE840
	|-PrimitiveObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FE8F0 Offset: 0x27FE9F1 VA: 0x27FE8F0
	|-PrimitiveObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FE9A0 Offset: 0x27FEAA1 VA: 0x27FE9A0
	|-PrimitiveObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FEA50 Offset: 0x27FEB51 VA: 0x27FEA50
	|-PrimitiveObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FEB00 Offset: 0x27FEC01 VA: 0x27FEB00
	|-PrimitiveObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FEBB0 Offset: 0x27FECB1 VA: 0x27FEBB0
	|-PrimitiveObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FEC60 Offset: 0x27FED61 VA: 0x27FEC60
	|-PrimitiveObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FED10 Offset: 0x27FEE11 VA: 0x27FED10
	|-PrimitiveObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FEDC0 Offset: 0x27FEEC1 VA: 0x27FEDC0
	|-PrimitiveObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FEE70 Offset: 0x27FEF71 VA: 0x27FEE70
	|-PrimitiveObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FEF20 Offset: 0x27FF021 VA: 0x27FEF20
	|-PrimitiveObjectResolver.GetFormatter<Vector4>
	*/
}

