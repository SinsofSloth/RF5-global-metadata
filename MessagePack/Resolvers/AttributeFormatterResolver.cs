public sealed class AttributeFormatterResolver : IFormatterResolver // TypeDefIndex: 5224
{
	// Fields
	public static readonly AttributeFormatterResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F20D0 Offset: 0x14F21D1 VA: 0x14F20D0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B12D50 Offset: 0x1B12E51 VA: 0x1B12D50
	|-AttributeFormatterResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1B12E00 Offset: 0x1B12F01 VA: 0x1B12E00
	|-AttributeFormatterResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1B12EB0 Offset: 0x1B12FB1 VA: 0x1B12EB0
	|-AttributeFormatterResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1B12F60 Offset: 0x1B13061 VA: 0x1B12F60
	|-AttributeFormatterResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1B13010 Offset: 0x1B13111 VA: 0x1B13010
	|-AttributeFormatterResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1B130C0 Offset: 0x1B131C1 VA: 0x1B130C0
	|-AttributeFormatterResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1B13170 Offset: 0x1B13271 VA: 0x1B13170
	|-AttributeFormatterResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1B13220 Offset: 0x1B13321 VA: 0x1B13220
	|-AttributeFormatterResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1B132D0 Offset: 0x1B133D1 VA: 0x1B132D0
	|-AttributeFormatterResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1B13380 Offset: 0x1B13481 VA: 0x1B13380
	|-AttributeFormatterResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1B13430 Offset: 0x1B13531 VA: 0x1B13430
	|-AttributeFormatterResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1B134E0 Offset: 0x1B135E1 VA: 0x1B134E0
	|-AttributeFormatterResolver.GetFormatter<bool>
	|
	|-RVA: 0x1B13590 Offset: 0x1B13691 VA: 0x1B13590
	|-AttributeFormatterResolver.GetFormatter<byte>
	|
	|-RVA: 0x1B13640 Offset: 0x1B13741 VA: 0x1B13640
	|-AttributeFormatterResolver.GetFormatter<char>
	|
	|-RVA: 0x1B136F0 Offset: 0x1B137F1 VA: 0x1B136F0
	|-AttributeFormatterResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1B137A0 Offset: 0x1B138A1 VA: 0x1B137A0
	|-AttributeFormatterResolver.GetFormatter<double>
	|
	|-RVA: 0x1B13850 Offset: 0x1B13951 VA: 0x1B13850
	|-AttributeFormatterResolver.GetFormatter<short>
	|
	|-RVA: 0x1B13900 Offset: 0x1B13A01 VA: 0x1B13900
	|-AttributeFormatterResolver.GetFormatter<int>
	|
	|-RVA: 0x1B139B0 Offset: 0x1B13AB1 VA: 0x1B139B0
	|-AttributeFormatterResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1B13A60 Offset: 0x1B13B61 VA: 0x1B13A60
	|-AttributeFormatterResolver.GetFormatter<long>
	|
	|-RVA: 0x1B13B10 Offset: 0x1B13C11 VA: 0x1B13B10
	|-AttributeFormatterResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1B13BC0 Offset: 0x1B13CC1 VA: 0x1B13BC0
	|-AttributeFormatterResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1B13C70 Offset: 0x1B13D71 VA: 0x1B13C70
	|-AttributeFormatterResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1B13D20 Offset: 0x1B13E21 VA: 0x1B13D20
	|-AttributeFormatterResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1B13DD0 Offset: 0x1B13ED1 VA: 0x1B13DD0
	|-AttributeFormatterResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1B13E80 Offset: 0x1B13F81 VA: 0x1B13E80
	|-AttributeFormatterResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1B13F30 Offset: 0x1B14031 VA: 0x1B13F30
	|-AttributeFormatterResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1B13FE0 Offset: 0x1B140E1 VA: 0x1B13FE0
	|-AttributeFormatterResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1B14090 Offset: 0x1B14191 VA: 0x1B14090
	|-AttributeFormatterResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1B14140 Offset: 0x1B14241 VA: 0x1B14140
	|-AttributeFormatterResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1B141F0 Offset: 0x1B142F1 VA: 0x1B141F0
	|-AttributeFormatterResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1B142A0 Offset: 0x1B143A1 VA: 0x1B142A0
	|-AttributeFormatterResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1B14350 Offset: 0x1B14451 VA: 0x1B14350
	|-AttributeFormatterResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1B14400 Offset: 0x1B14501 VA: 0x1B14400
	|-AttributeFormatterResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1B144B0 Offset: 0x1B145B1 VA: 0x1B144B0
	|-AttributeFormatterResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1B14560 Offset: 0x1B14661 VA: 0x1B14560
	|-AttributeFormatterResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1B14610 Offset: 0x1B14711 VA: 0x1B14610
	|-AttributeFormatterResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1B146C0 Offset: 0x1B147C1 VA: 0x1B146C0
	|-AttributeFormatterResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1B14770 Offset: 0x1B14871 VA: 0x1B14770
	|-AttributeFormatterResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1B14820 Offset: 0x1B14921 VA: 0x1B14820
	|-AttributeFormatterResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1B148D0 Offset: 0x1B149D1 VA: 0x1B148D0
	|-AttributeFormatterResolver.GetFormatter<object>
	|
	|-RVA: 0x1B14980 Offset: 0x1B14A81 VA: 0x1B14980
	|-AttributeFormatterResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1B14A30 Offset: 0x1B14B31 VA: 0x1B14A30
	|-AttributeFormatterResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1B14AE0 Offset: 0x1B14BE1 VA: 0x1B14AE0
	|-AttributeFormatterResolver.GetFormatter<float>
	|
	|-RVA: 0x1B14B90 Offset: 0x1B14C91 VA: 0x1B14B90
	|-AttributeFormatterResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1B14C40 Offset: 0x1B14D41 VA: 0x1B14C40
	|-AttributeFormatterResolver.GetFormatter<uint>
	|
	|-RVA: 0x1B14CF0 Offset: 0x1B14DF1 VA: 0x1B14CF0
	|-AttributeFormatterResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1B14DA0 Offset: 0x1B14EA1 VA: 0x1B14DA0
	|-AttributeFormatterResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1B14E50 Offset: 0x1B14F51 VA: 0x1B14E50
	|-AttributeFormatterResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1B14F00 Offset: 0x1B15001 VA: 0x1B14F00
	|-AttributeFormatterResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1B14FB0 Offset: 0x1B150B1 VA: 0x1B14FB0
	|-AttributeFormatterResolver.GetFormatter<Color>
	|
	|-RVA: 0x1B15060 Offset: 0x1B15161 VA: 0x1B15060
	|-AttributeFormatterResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1B15110 Offset: 0x1B15211 VA: 0x1B15110
	|-AttributeFormatterResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1B151C0 Offset: 0x1B152C1 VA: 0x1B151C0
	|-AttributeFormatterResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1B15270 Offset: 0x1B15371 VA: 0x1B15270
	|-AttributeFormatterResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1B15320 Offset: 0x1B15421 VA: 0x1B15320
	|-AttributeFormatterResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1B153D0 Offset: 0x1B154D1 VA: 0x1B153D0
	|-AttributeFormatterResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1B15480 Offset: 0x1B15581 VA: 0x1B15480
	|-AttributeFormatterResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1B15530 Offset: 0x1B15631 VA: 0x1B15530
	|-AttributeFormatterResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1B155E0 Offset: 0x1B156E1 VA: 0x1B155E0
	|-AttributeFormatterResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1B15690 Offset: 0x1B15791 VA: 0x1B15690
	|-AttributeFormatterResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1B15740 Offset: 0x1B15841 VA: 0x1B15740
	|-AttributeFormatterResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1B157F0 Offset: 0x1B158F1 VA: 0x1B157F0
	|-AttributeFormatterResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1B158A0 Offset: 0x1B159A1 VA: 0x1B158A0
	|-AttributeFormatterResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1B15950 Offset: 0x1B15A51 VA: 0x1B15950
	|-AttributeFormatterResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F20E0 Offset: 0x14F21E1 VA: 0x14F20E0
	private static void .cctor() { }
}

