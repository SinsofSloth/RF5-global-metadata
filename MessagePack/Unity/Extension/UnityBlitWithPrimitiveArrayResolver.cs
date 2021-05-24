public class UnityBlitWithPrimitiveArrayResolver : IFormatterResolver // TypeDefIndex: 5209
{
	// Fields
	public static readonly UnityBlitWithPrimitiveArrayResolver Instance; // 0x0

	// Methods

	// RVA: 0x14FE8C0 Offset: 0x14FE9C1 VA: 0x14FE8C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x280A290 Offset: 0x280A391 VA: 0x280A290
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x280A340 Offset: 0x280A441 VA: 0x280A340
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x280A3F0 Offset: 0x280A4F1 VA: 0x280A3F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x280A4A0 Offset: 0x280A5A1 VA: 0x280A4A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x280A550 Offset: 0x280A651 VA: 0x280A550
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x280A600 Offset: 0x280A701 VA: 0x280A600
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x280A6B0 Offset: 0x280A7B1 VA: 0x280A6B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x280A760 Offset: 0x280A861 VA: 0x280A760
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x280A810 Offset: 0x280A911 VA: 0x280A810
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x280A8C0 Offset: 0x280A9C1 VA: 0x280A8C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x280A970 Offset: 0x280AA71 VA: 0x280A970
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x280AA20 Offset: 0x280AB21 VA: 0x280AA20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<bool>
	|
	|-RVA: 0x280AAD0 Offset: 0x280ABD1 VA: 0x280AAD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<byte>
	|
	|-RVA: 0x280AB80 Offset: 0x280AC81 VA: 0x280AB80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<char>
	|
	|-RVA: 0x280AC30 Offset: 0x280AD31 VA: 0x280AC30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x280ACE0 Offset: 0x280ADE1 VA: 0x280ACE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<double>
	|
	|-RVA: 0x280AD90 Offset: 0x280AE91 VA: 0x280AD90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<short>
	|
	|-RVA: 0x280AE40 Offset: 0x280AF41 VA: 0x280AE40
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<int>
	|
	|-RVA: 0x280AEF0 Offset: 0x280AFF1 VA: 0x280AEF0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x280AFA0 Offset: 0x280B0A1 VA: 0x280AFA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<long>
	|
	|-RVA: 0x280B050 Offset: 0x280B151 VA: 0x280B050
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x280B100 Offset: 0x280B201 VA: 0x280B100
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x280B1B0 Offset: 0x280B2B1 VA: 0x280B1B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x280B260 Offset: 0x280B361 VA: 0x280B260
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x280B310 Offset: 0x280B411 VA: 0x280B310
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x280B3C0 Offset: 0x280B4C1 VA: 0x280B3C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x280B470 Offset: 0x280B571 VA: 0x280B470
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x280B520 Offset: 0x280B621 VA: 0x280B520
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x280B5D0 Offset: 0x280B6D1 VA: 0x280B5D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x280B680 Offset: 0x280B781 VA: 0x280B680
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x280B730 Offset: 0x280B831 VA: 0x280B730
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x280B7E0 Offset: 0x280B8E1 VA: 0x280B7E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x280B890 Offset: 0x280B991 VA: 0x280B890
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x280B940 Offset: 0x280BA41 VA: 0x280B940
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x280B9F0 Offset: 0x280BAF1 VA: 0x280B9F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x280BAA0 Offset: 0x280BBA1 VA: 0x280BAA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x280BB50 Offset: 0x280BC51 VA: 0x280BB50
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x280BC00 Offset: 0x280BD01 VA: 0x280BC00
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x280BCB0 Offset: 0x280BDB1 VA: 0x280BCB0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x280BD60 Offset: 0x280BE61 VA: 0x280BD60
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x280BE10 Offset: 0x280BF11 VA: 0x280BE10
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<object>
	|
	|-RVA: 0x280BEC0 Offset: 0x280BFC1 VA: 0x280BEC0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x280BF70 Offset: 0x280C071 VA: 0x280BF70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x280C020 Offset: 0x280C121 VA: 0x280C020
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<float>
	|
	|-RVA: 0x280C0D0 Offset: 0x280C1D1 VA: 0x280C0D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ushort>
	|
	|-RVA: 0x280C180 Offset: 0x280C281 VA: 0x280C180
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<uint>
	|
	|-RVA: 0x280C230 Offset: 0x280C331 VA: 0x280C230
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ulong>
	|
	|-RVA: 0x280C2E0 Offset: 0x280C3E1 VA: 0x280C2E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x280C390 Offset: 0x280C491 VA: 0x280C390
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x280C440 Offset: 0x280C541 VA: 0x280C440
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color32>
	|
	|-RVA: 0x280C4F0 Offset: 0x280C5F1 VA: 0x280C4F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color>
	|
	|-RVA: 0x280C5A0 Offset: 0x280C6A1 VA: 0x280C5A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x280C650 Offset: 0x280C751 VA: 0x280C650
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x280C700 Offset: 0x280C801 VA: 0x280C700
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x280C7B0 Offset: 0x280C8B1 VA: 0x280C7B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x280C860 Offset: 0x280C961 VA: 0x280C860
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x280C910 Offset: 0x280CA11 VA: 0x280C910
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x280C9C0 Offset: 0x280CAC1 VA: 0x280C9C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x280CA70 Offset: 0x280CB71 VA: 0x280CA70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Rect>
	|
	|-RVA: 0x280CB20 Offset: 0x280CC21 VA: 0x280CB20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x280CBD0 Offset: 0x280CCD1 VA: 0x280CBD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x280CC80 Offset: 0x280CD81 VA: 0x280CC80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x280CD30 Offset: 0x280CE31 VA: 0x280CD30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x280CDE0 Offset: 0x280CEE1 VA: 0x280CDE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x280CE90 Offset: 0x280CF91 VA: 0x280CE90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14FE8D0 Offset: 0x14FE9D1 VA: 0x14FE8D0
	private static void .cctor() { }
}

public class UnityBlitWithPrimitiveArrayResolver : IFormatterResolver // TypeDefIndex: 5209
{
	// Fields
	public static readonly UnityBlitWithPrimitiveArrayResolver Instance; // 0x0

	// Methods

	// RVA: 0x14FE8C0 Offset: 0x14FE9C1 VA: 0x14FE8C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x280A290 Offset: 0x280A391 VA: 0x280A290
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x280A340 Offset: 0x280A441 VA: 0x280A340
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x280A3F0 Offset: 0x280A4F1 VA: 0x280A3F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x280A4A0 Offset: 0x280A5A1 VA: 0x280A4A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x280A550 Offset: 0x280A651 VA: 0x280A550
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x280A600 Offset: 0x280A701 VA: 0x280A600
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x280A6B0 Offset: 0x280A7B1 VA: 0x280A6B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x280A760 Offset: 0x280A861 VA: 0x280A760
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x280A810 Offset: 0x280A911 VA: 0x280A810
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x280A8C0 Offset: 0x280A9C1 VA: 0x280A8C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x280A970 Offset: 0x280AA71 VA: 0x280A970
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x280AA20 Offset: 0x280AB21 VA: 0x280AA20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<bool>
	|
	|-RVA: 0x280AAD0 Offset: 0x280ABD1 VA: 0x280AAD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<byte>
	|
	|-RVA: 0x280AB80 Offset: 0x280AC81 VA: 0x280AB80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<char>
	|
	|-RVA: 0x280AC30 Offset: 0x280AD31 VA: 0x280AC30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x280ACE0 Offset: 0x280ADE1 VA: 0x280ACE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<double>
	|
	|-RVA: 0x280AD90 Offset: 0x280AE91 VA: 0x280AD90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<short>
	|
	|-RVA: 0x280AE40 Offset: 0x280AF41 VA: 0x280AE40
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<int>
	|
	|-RVA: 0x280AEF0 Offset: 0x280AFF1 VA: 0x280AEF0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x280AFA0 Offset: 0x280B0A1 VA: 0x280AFA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<long>
	|
	|-RVA: 0x280B050 Offset: 0x280B151 VA: 0x280B050
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x280B100 Offset: 0x280B201 VA: 0x280B100
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x280B1B0 Offset: 0x280B2B1 VA: 0x280B1B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x280B260 Offset: 0x280B361 VA: 0x280B260
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x280B310 Offset: 0x280B411 VA: 0x280B310
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x280B3C0 Offset: 0x280B4C1 VA: 0x280B3C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x280B470 Offset: 0x280B571 VA: 0x280B470
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x280B520 Offset: 0x280B621 VA: 0x280B520
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x280B5D0 Offset: 0x280B6D1 VA: 0x280B5D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x280B680 Offset: 0x280B781 VA: 0x280B680
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x280B730 Offset: 0x280B831 VA: 0x280B730
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x280B7E0 Offset: 0x280B8E1 VA: 0x280B7E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x280B890 Offset: 0x280B991 VA: 0x280B890
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x280B940 Offset: 0x280BA41 VA: 0x280B940
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x280B9F0 Offset: 0x280BAF1 VA: 0x280B9F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x280BAA0 Offset: 0x280BBA1 VA: 0x280BAA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x280BB50 Offset: 0x280BC51 VA: 0x280BB50
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x280BC00 Offset: 0x280BD01 VA: 0x280BC00
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x280BCB0 Offset: 0x280BDB1 VA: 0x280BCB0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x280BD60 Offset: 0x280BE61 VA: 0x280BD60
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x280BE10 Offset: 0x280BF11 VA: 0x280BE10
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<object>
	|
	|-RVA: 0x280BEC0 Offset: 0x280BFC1 VA: 0x280BEC0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x280BF70 Offset: 0x280C071 VA: 0x280BF70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x280C020 Offset: 0x280C121 VA: 0x280C020
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<float>
	|
	|-RVA: 0x280C0D0 Offset: 0x280C1D1 VA: 0x280C0D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ushort>
	|
	|-RVA: 0x280C180 Offset: 0x280C281 VA: 0x280C180
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<uint>
	|
	|-RVA: 0x280C230 Offset: 0x280C331 VA: 0x280C230
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ulong>
	|
	|-RVA: 0x280C2E0 Offset: 0x280C3E1 VA: 0x280C2E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x280C390 Offset: 0x280C491 VA: 0x280C390
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x280C440 Offset: 0x280C541 VA: 0x280C440
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color32>
	|
	|-RVA: 0x280C4F0 Offset: 0x280C5F1 VA: 0x280C4F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color>
	|
	|-RVA: 0x280C5A0 Offset: 0x280C6A1 VA: 0x280C5A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x280C650 Offset: 0x280C751 VA: 0x280C650
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x280C700 Offset: 0x280C801 VA: 0x280C700
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x280C7B0 Offset: 0x280C8B1 VA: 0x280C7B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x280C860 Offset: 0x280C961 VA: 0x280C860
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x280C910 Offset: 0x280CA11 VA: 0x280C910
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x280C9C0 Offset: 0x280CAC1 VA: 0x280C9C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x280CA70 Offset: 0x280CB71 VA: 0x280CA70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Rect>
	|
	|-RVA: 0x280CB20 Offset: 0x280CC21 VA: 0x280CB20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x280CBD0 Offset: 0x280CCD1 VA: 0x280CBD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x280CC80 Offset: 0x280CD81 VA: 0x280CC80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x280CD30 Offset: 0x280CE31 VA: 0x280CD30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x280CDE0 Offset: 0x280CEE1 VA: 0x280CDE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x280CE90 Offset: 0x280CF91 VA: 0x280CE90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14FE8D0 Offset: 0x14FE9D1 VA: 0x14FE8D0
	private static void .cctor() { }
}

public class UnityBlitWithPrimitiveArrayResolver : IFormatterResolver // TypeDefIndex: 5209
{
	// Fields
	public static readonly UnityBlitWithPrimitiveArrayResolver Instance; // 0x0

	// Methods

	// RVA: 0x14FE8C0 Offset: 0x14FE9C1 VA: 0x14FE8C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x280A290 Offset: 0x280A391 VA: 0x280A290
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x280A340 Offset: 0x280A441 VA: 0x280A340
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x280A3F0 Offset: 0x280A4F1 VA: 0x280A3F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x280A4A0 Offset: 0x280A5A1 VA: 0x280A4A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x280A550 Offset: 0x280A651 VA: 0x280A550
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x280A600 Offset: 0x280A701 VA: 0x280A600
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x280A6B0 Offset: 0x280A7B1 VA: 0x280A6B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x280A760 Offset: 0x280A861 VA: 0x280A760
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x280A810 Offset: 0x280A911 VA: 0x280A810
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x280A8C0 Offset: 0x280A9C1 VA: 0x280A8C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x280A970 Offset: 0x280AA71 VA: 0x280A970
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x280AA20 Offset: 0x280AB21 VA: 0x280AA20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<bool>
	|
	|-RVA: 0x280AAD0 Offset: 0x280ABD1 VA: 0x280AAD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<byte>
	|
	|-RVA: 0x280AB80 Offset: 0x280AC81 VA: 0x280AB80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<char>
	|
	|-RVA: 0x280AC30 Offset: 0x280AD31 VA: 0x280AC30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x280ACE0 Offset: 0x280ADE1 VA: 0x280ACE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<double>
	|
	|-RVA: 0x280AD90 Offset: 0x280AE91 VA: 0x280AD90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<short>
	|
	|-RVA: 0x280AE40 Offset: 0x280AF41 VA: 0x280AE40
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<int>
	|
	|-RVA: 0x280AEF0 Offset: 0x280AFF1 VA: 0x280AEF0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x280AFA0 Offset: 0x280B0A1 VA: 0x280AFA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<long>
	|
	|-RVA: 0x280B050 Offset: 0x280B151 VA: 0x280B050
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x280B100 Offset: 0x280B201 VA: 0x280B100
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x280B1B0 Offset: 0x280B2B1 VA: 0x280B1B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x280B260 Offset: 0x280B361 VA: 0x280B260
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x280B310 Offset: 0x280B411 VA: 0x280B310
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x280B3C0 Offset: 0x280B4C1 VA: 0x280B3C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x280B470 Offset: 0x280B571 VA: 0x280B470
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x280B520 Offset: 0x280B621 VA: 0x280B520
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x280B5D0 Offset: 0x280B6D1 VA: 0x280B5D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x280B680 Offset: 0x280B781 VA: 0x280B680
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x280B730 Offset: 0x280B831 VA: 0x280B730
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x280B7E0 Offset: 0x280B8E1 VA: 0x280B7E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x280B890 Offset: 0x280B991 VA: 0x280B890
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x280B940 Offset: 0x280BA41 VA: 0x280B940
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x280B9F0 Offset: 0x280BAF1 VA: 0x280B9F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x280BAA0 Offset: 0x280BBA1 VA: 0x280BAA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x280BB50 Offset: 0x280BC51 VA: 0x280BB50
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x280BC00 Offset: 0x280BD01 VA: 0x280BC00
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x280BCB0 Offset: 0x280BDB1 VA: 0x280BCB0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x280BD60 Offset: 0x280BE61 VA: 0x280BD60
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x280BE10 Offset: 0x280BF11 VA: 0x280BE10
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<object>
	|
	|-RVA: 0x280BEC0 Offset: 0x280BFC1 VA: 0x280BEC0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x280BF70 Offset: 0x280C071 VA: 0x280BF70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x280C020 Offset: 0x280C121 VA: 0x280C020
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<float>
	|
	|-RVA: 0x280C0D0 Offset: 0x280C1D1 VA: 0x280C0D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ushort>
	|
	|-RVA: 0x280C180 Offset: 0x280C281 VA: 0x280C180
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<uint>
	|
	|-RVA: 0x280C230 Offset: 0x280C331 VA: 0x280C230
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ulong>
	|
	|-RVA: 0x280C2E0 Offset: 0x280C3E1 VA: 0x280C2E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x280C390 Offset: 0x280C491 VA: 0x280C390
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x280C440 Offset: 0x280C541 VA: 0x280C440
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color32>
	|
	|-RVA: 0x280C4F0 Offset: 0x280C5F1 VA: 0x280C4F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color>
	|
	|-RVA: 0x280C5A0 Offset: 0x280C6A1 VA: 0x280C5A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x280C650 Offset: 0x280C751 VA: 0x280C650
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x280C700 Offset: 0x280C801 VA: 0x280C700
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x280C7B0 Offset: 0x280C8B1 VA: 0x280C7B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x280C860 Offset: 0x280C961 VA: 0x280C860
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x280C910 Offset: 0x280CA11 VA: 0x280C910
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x280C9C0 Offset: 0x280CAC1 VA: 0x280C9C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x280CA70 Offset: 0x280CB71 VA: 0x280CA70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Rect>
	|
	|-RVA: 0x280CB20 Offset: 0x280CC21 VA: 0x280CB20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x280CBD0 Offset: 0x280CCD1 VA: 0x280CBD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x280CC80 Offset: 0x280CD81 VA: 0x280CC80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x280CD30 Offset: 0x280CE31 VA: 0x280CD30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x280CDE0 Offset: 0x280CEE1 VA: 0x280CDE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x280CE90 Offset: 0x280CF91 VA: 0x280CE90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14FE8D0 Offset: 0x14FE9D1 VA: 0x14FE8D0
	private static void .cctor() { }
}

public class UnityBlitWithPrimitiveArrayResolver : IFormatterResolver // TypeDefIndex: 5209
{
	// Fields
	public static readonly UnityBlitWithPrimitiveArrayResolver Instance; // 0x0

	// Methods

	// RVA: 0x14FE8C0 Offset: 0x14FE9C1 VA: 0x14FE8C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x280A290 Offset: 0x280A391 VA: 0x280A290
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x280A340 Offset: 0x280A441 VA: 0x280A340
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x280A3F0 Offset: 0x280A4F1 VA: 0x280A3F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x280A4A0 Offset: 0x280A5A1 VA: 0x280A4A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x280A550 Offset: 0x280A651 VA: 0x280A550
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x280A600 Offset: 0x280A701 VA: 0x280A600
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x280A6B0 Offset: 0x280A7B1 VA: 0x280A6B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x280A760 Offset: 0x280A861 VA: 0x280A760
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x280A810 Offset: 0x280A911 VA: 0x280A810
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x280A8C0 Offset: 0x280A9C1 VA: 0x280A8C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x280A970 Offset: 0x280AA71 VA: 0x280A970
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x280AA20 Offset: 0x280AB21 VA: 0x280AA20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<bool>
	|
	|-RVA: 0x280AAD0 Offset: 0x280ABD1 VA: 0x280AAD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<byte>
	|
	|-RVA: 0x280AB80 Offset: 0x280AC81 VA: 0x280AB80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<char>
	|
	|-RVA: 0x280AC30 Offset: 0x280AD31 VA: 0x280AC30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x280ACE0 Offset: 0x280ADE1 VA: 0x280ACE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<double>
	|
	|-RVA: 0x280AD90 Offset: 0x280AE91 VA: 0x280AD90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<short>
	|
	|-RVA: 0x280AE40 Offset: 0x280AF41 VA: 0x280AE40
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<int>
	|
	|-RVA: 0x280AEF0 Offset: 0x280AFF1 VA: 0x280AEF0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x280AFA0 Offset: 0x280B0A1 VA: 0x280AFA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<long>
	|
	|-RVA: 0x280B050 Offset: 0x280B151 VA: 0x280B050
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x280B100 Offset: 0x280B201 VA: 0x280B100
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x280B1B0 Offset: 0x280B2B1 VA: 0x280B1B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x280B260 Offset: 0x280B361 VA: 0x280B260
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x280B310 Offset: 0x280B411 VA: 0x280B310
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x280B3C0 Offset: 0x280B4C1 VA: 0x280B3C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x280B470 Offset: 0x280B571 VA: 0x280B470
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x280B520 Offset: 0x280B621 VA: 0x280B520
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x280B5D0 Offset: 0x280B6D1 VA: 0x280B5D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x280B680 Offset: 0x280B781 VA: 0x280B680
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x280B730 Offset: 0x280B831 VA: 0x280B730
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x280B7E0 Offset: 0x280B8E1 VA: 0x280B7E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x280B890 Offset: 0x280B991 VA: 0x280B890
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x280B940 Offset: 0x280BA41 VA: 0x280B940
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x280B9F0 Offset: 0x280BAF1 VA: 0x280B9F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x280BAA0 Offset: 0x280BBA1 VA: 0x280BAA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x280BB50 Offset: 0x280BC51 VA: 0x280BB50
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x280BC00 Offset: 0x280BD01 VA: 0x280BC00
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x280BCB0 Offset: 0x280BDB1 VA: 0x280BCB0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x280BD60 Offset: 0x280BE61 VA: 0x280BD60
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x280BE10 Offset: 0x280BF11 VA: 0x280BE10
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<object>
	|
	|-RVA: 0x280BEC0 Offset: 0x280BFC1 VA: 0x280BEC0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x280BF70 Offset: 0x280C071 VA: 0x280BF70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x280C020 Offset: 0x280C121 VA: 0x280C020
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<float>
	|
	|-RVA: 0x280C0D0 Offset: 0x280C1D1 VA: 0x280C0D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ushort>
	|
	|-RVA: 0x280C180 Offset: 0x280C281 VA: 0x280C180
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<uint>
	|
	|-RVA: 0x280C230 Offset: 0x280C331 VA: 0x280C230
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ulong>
	|
	|-RVA: 0x280C2E0 Offset: 0x280C3E1 VA: 0x280C2E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x280C390 Offset: 0x280C491 VA: 0x280C390
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x280C440 Offset: 0x280C541 VA: 0x280C440
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color32>
	|
	|-RVA: 0x280C4F0 Offset: 0x280C5F1 VA: 0x280C4F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color>
	|
	|-RVA: 0x280C5A0 Offset: 0x280C6A1 VA: 0x280C5A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x280C650 Offset: 0x280C751 VA: 0x280C650
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x280C700 Offset: 0x280C801 VA: 0x280C700
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x280C7B0 Offset: 0x280C8B1 VA: 0x280C7B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x280C860 Offset: 0x280C961 VA: 0x280C860
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x280C910 Offset: 0x280CA11 VA: 0x280C910
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x280C9C0 Offset: 0x280CAC1 VA: 0x280C9C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x280CA70 Offset: 0x280CB71 VA: 0x280CA70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Rect>
	|
	|-RVA: 0x280CB20 Offset: 0x280CC21 VA: 0x280CB20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x280CBD0 Offset: 0x280CCD1 VA: 0x280CBD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x280CC80 Offset: 0x280CD81 VA: 0x280CC80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x280CD30 Offset: 0x280CE31 VA: 0x280CD30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x280CDE0 Offset: 0x280CEE1 VA: 0x280CDE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x280CE90 Offset: 0x280CF91 VA: 0x280CE90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14FE8D0 Offset: 0x14FE9D1 VA: 0x14FE8D0
	private static void .cctor() { }
}

public class UnityBlitWithPrimitiveArrayResolver : IFormatterResolver // TypeDefIndex: 5209
{
	// Fields
	public static readonly UnityBlitWithPrimitiveArrayResolver Instance; // 0x0

	// Methods

	// RVA: 0x14FE8C0 Offset: 0x14FE9C1 VA: 0x14FE8C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x280A290 Offset: 0x280A391 VA: 0x280A290
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x280A340 Offset: 0x280A441 VA: 0x280A340
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x280A3F0 Offset: 0x280A4F1 VA: 0x280A3F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x280A4A0 Offset: 0x280A5A1 VA: 0x280A4A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x280A550 Offset: 0x280A651 VA: 0x280A550
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x280A600 Offset: 0x280A701 VA: 0x280A600
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x280A6B0 Offset: 0x280A7B1 VA: 0x280A6B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x280A760 Offset: 0x280A861 VA: 0x280A760
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x280A810 Offset: 0x280A911 VA: 0x280A810
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x280A8C0 Offset: 0x280A9C1 VA: 0x280A8C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x280A970 Offset: 0x280AA71 VA: 0x280A970
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x280AA20 Offset: 0x280AB21 VA: 0x280AA20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<bool>
	|
	|-RVA: 0x280AAD0 Offset: 0x280ABD1 VA: 0x280AAD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<byte>
	|
	|-RVA: 0x280AB80 Offset: 0x280AC81 VA: 0x280AB80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<char>
	|
	|-RVA: 0x280AC30 Offset: 0x280AD31 VA: 0x280AC30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x280ACE0 Offset: 0x280ADE1 VA: 0x280ACE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<double>
	|
	|-RVA: 0x280AD90 Offset: 0x280AE91 VA: 0x280AD90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<short>
	|
	|-RVA: 0x280AE40 Offset: 0x280AF41 VA: 0x280AE40
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<int>
	|
	|-RVA: 0x280AEF0 Offset: 0x280AFF1 VA: 0x280AEF0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x280AFA0 Offset: 0x280B0A1 VA: 0x280AFA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<long>
	|
	|-RVA: 0x280B050 Offset: 0x280B151 VA: 0x280B050
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x280B100 Offset: 0x280B201 VA: 0x280B100
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x280B1B0 Offset: 0x280B2B1 VA: 0x280B1B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x280B260 Offset: 0x280B361 VA: 0x280B260
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x280B310 Offset: 0x280B411 VA: 0x280B310
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x280B3C0 Offset: 0x280B4C1 VA: 0x280B3C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x280B470 Offset: 0x280B571 VA: 0x280B470
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x280B520 Offset: 0x280B621 VA: 0x280B520
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x280B5D0 Offset: 0x280B6D1 VA: 0x280B5D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x280B680 Offset: 0x280B781 VA: 0x280B680
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x280B730 Offset: 0x280B831 VA: 0x280B730
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x280B7E0 Offset: 0x280B8E1 VA: 0x280B7E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x280B890 Offset: 0x280B991 VA: 0x280B890
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x280B940 Offset: 0x280BA41 VA: 0x280B940
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x280B9F0 Offset: 0x280BAF1 VA: 0x280B9F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x280BAA0 Offset: 0x280BBA1 VA: 0x280BAA0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x280BB50 Offset: 0x280BC51 VA: 0x280BB50
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x280BC00 Offset: 0x280BD01 VA: 0x280BC00
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x280BCB0 Offset: 0x280BDB1 VA: 0x280BCB0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x280BD60 Offset: 0x280BE61 VA: 0x280BD60
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x280BE10 Offset: 0x280BF11 VA: 0x280BE10
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<object>
	|
	|-RVA: 0x280BEC0 Offset: 0x280BFC1 VA: 0x280BEC0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x280BF70 Offset: 0x280C071 VA: 0x280BF70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x280C020 Offset: 0x280C121 VA: 0x280C020
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<float>
	|
	|-RVA: 0x280C0D0 Offset: 0x280C1D1 VA: 0x280C0D0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ushort>
	|
	|-RVA: 0x280C180 Offset: 0x280C281 VA: 0x280C180
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<uint>
	|
	|-RVA: 0x280C230 Offset: 0x280C331 VA: 0x280C230
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<ulong>
	|
	|-RVA: 0x280C2E0 Offset: 0x280C3E1 VA: 0x280C2E0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x280C390 Offset: 0x280C491 VA: 0x280C390
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x280C440 Offset: 0x280C541 VA: 0x280C440
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color32>
	|
	|-RVA: 0x280C4F0 Offset: 0x280C5F1 VA: 0x280C4F0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Color>
	|
	|-RVA: 0x280C5A0 Offset: 0x280C6A1 VA: 0x280C5A0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x280C650 Offset: 0x280C751 VA: 0x280C650
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x280C700 Offset: 0x280C801 VA: 0x280C700
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x280C7B0 Offset: 0x280C8B1 VA: 0x280C7B0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x280C860 Offset: 0x280C961 VA: 0x280C860
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x280C910 Offset: 0x280CA11 VA: 0x280C910
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x280C9C0 Offset: 0x280CAC1 VA: 0x280C9C0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x280CA70 Offset: 0x280CB71 VA: 0x280CA70
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Rect>
	|
	|-RVA: 0x280CB20 Offset: 0x280CC21 VA: 0x280CB20
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x280CBD0 Offset: 0x280CCD1 VA: 0x280CBD0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x280CC80 Offset: 0x280CD81 VA: 0x280CC80
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x280CD30 Offset: 0x280CE31 VA: 0x280CD30
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x280CDE0 Offset: 0x280CEE1 VA: 0x280CDE0
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x280CE90 Offset: 0x280CF91 VA: 0x280CE90
	|-UnityBlitWithPrimitiveArrayResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14FE8D0 Offset: 0x14FE9D1 VA: 0x14FE8D0
	private static void .cctor() { }
}

