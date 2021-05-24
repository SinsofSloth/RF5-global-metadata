public sealed class ContractlessStandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5272
{
	// Fields
	public static readonly ContractlessStandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2890 Offset: 0x14F2991 VA: 0x14F2890
	private static void .cctor() { }

	// RVA: 0x14F29C0 Offset: 0x14F2AC1 VA: 0x14F29C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1813D70 Offset: 0x1813E71 VA: 0x1813D70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1813E20 Offset: 0x1813F21 VA: 0x1813E20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1813ED0 Offset: 0x1813FD1 VA: 0x1813ED0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1813F80 Offset: 0x1814081 VA: 0x1813F80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1814030 Offset: 0x1814131 VA: 0x1814030
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18140E0 Offset: 0x18141E1 VA: 0x18140E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1814190 Offset: 0x1814291 VA: 0x1814190
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1814240 Offset: 0x1814341 VA: 0x1814240
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18142F0 Offset: 0x18143F1 VA: 0x18142F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18143A0 Offset: 0x18144A1 VA: 0x18143A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1814450 Offset: 0x1814551 VA: 0x1814450
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1814500 Offset: 0x1814601 VA: 0x1814500
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x18145B0 Offset: 0x18146B1 VA: 0x18145B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1814660 Offset: 0x1814761 VA: 0x1814660
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1814710 Offset: 0x1814811 VA: 0x1814710
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x18147C0 Offset: 0x18148C1 VA: 0x18147C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1814870 Offset: 0x1814971 VA: 0x1814870
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x1814920 Offset: 0x1814A21 VA: 0x1814920
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18149D0 Offset: 0x1814AD1 VA: 0x18149D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1814A80 Offset: 0x1814B81 VA: 0x1814A80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1814B30 Offset: 0x1814C31 VA: 0x1814B30
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1814BE0 Offset: 0x1814CE1 VA: 0x1814BE0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1814C90 Offset: 0x1814D91 VA: 0x1814C90
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1814D40 Offset: 0x1814E41 VA: 0x1814D40
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1814DF0 Offset: 0x1814EF1 VA: 0x1814DF0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1814EA0 Offset: 0x1814FA1 VA: 0x1814EA0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1814F50 Offset: 0x1815051 VA: 0x1814F50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1815000 Offset: 0x1815101 VA: 0x1815000
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x18150B0 Offset: 0x18151B1 VA: 0x18150B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1815160 Offset: 0x1815261 VA: 0x1815160
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1815210 Offset: 0x1815311 VA: 0x1815210
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18152C0 Offset: 0x18153C1 VA: 0x18152C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1815370 Offset: 0x1815471 VA: 0x1815370
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1815420 Offset: 0x1815521 VA: 0x1815420
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18154D0 Offset: 0x18155D1 VA: 0x18154D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1815580 Offset: 0x1815681 VA: 0x1815580
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1815630 Offset: 0x1815731 VA: 0x1815630
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18156E0 Offset: 0x18157E1 VA: 0x18156E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1815790 Offset: 0x1815891 VA: 0x1815790
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1815840 Offset: 0x1815941 VA: 0x1815840
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18158F0 Offset: 0x18159F1 VA: 0x18158F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x18159A0 Offset: 0x1815AA1 VA: 0x18159A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1815A50 Offset: 0x1815B51 VA: 0x1815A50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x1815B00 Offset: 0x1815C01 VA: 0x1815B00
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1815BB0 Offset: 0x1815CB1 VA: 0x1815BB0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1815C60 Offset: 0x1815D61 VA: 0x1815C60
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x1815D10 Offset: 0x1815E11 VA: 0x1815D10
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1815DC0 Offset: 0x1815EC1 VA: 0x1815DC0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1815E70 Offset: 0x1815F71 VA: 0x1815E70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1815F20 Offset: 0x1816021 VA: 0x1815F20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x1815FD0 Offset: 0x18160D1 VA: 0x1815FD0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1816080 Offset: 0x1816181 VA: 0x1816080
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1816130 Offset: 0x1816231 VA: 0x1816130
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18161E0 Offset: 0x18162E1 VA: 0x18161E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1816290 Offset: 0x1816391 VA: 0x1816290
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1816340 Offset: 0x1816441 VA: 0x1816340
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18163F0 Offset: 0x18164F1 VA: 0x18163F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x18164A0 Offset: 0x18165A1 VA: 0x18164A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1816550 Offset: 0x1816651 VA: 0x1816550
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1816600 Offset: 0x1816701 VA: 0x1816600
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x18166B0 Offset: 0x18167B1 VA: 0x18166B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x1816760 Offset: 0x1816861 VA: 0x1816760
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1816810 Offset: 0x1816911 VA: 0x1816810
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x18168C0 Offset: 0x18169C1 VA: 0x18168C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1816970 Offset: 0x1816A71 VA: 0x1816970
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

public sealed class ContractlessStandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5272
{
	// Fields
	public static readonly ContractlessStandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2890 Offset: 0x14F2991 VA: 0x14F2890
	private static void .cctor() { }

	// RVA: 0x14F29C0 Offset: 0x14F2AC1 VA: 0x14F29C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1813D70 Offset: 0x1813E71 VA: 0x1813D70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1813E20 Offset: 0x1813F21 VA: 0x1813E20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1813ED0 Offset: 0x1813FD1 VA: 0x1813ED0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1813F80 Offset: 0x1814081 VA: 0x1813F80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1814030 Offset: 0x1814131 VA: 0x1814030
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18140E0 Offset: 0x18141E1 VA: 0x18140E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1814190 Offset: 0x1814291 VA: 0x1814190
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1814240 Offset: 0x1814341 VA: 0x1814240
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18142F0 Offset: 0x18143F1 VA: 0x18142F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18143A0 Offset: 0x18144A1 VA: 0x18143A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1814450 Offset: 0x1814551 VA: 0x1814450
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1814500 Offset: 0x1814601 VA: 0x1814500
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x18145B0 Offset: 0x18146B1 VA: 0x18145B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1814660 Offset: 0x1814761 VA: 0x1814660
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1814710 Offset: 0x1814811 VA: 0x1814710
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x18147C0 Offset: 0x18148C1 VA: 0x18147C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1814870 Offset: 0x1814971 VA: 0x1814870
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x1814920 Offset: 0x1814A21 VA: 0x1814920
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18149D0 Offset: 0x1814AD1 VA: 0x18149D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1814A80 Offset: 0x1814B81 VA: 0x1814A80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1814B30 Offset: 0x1814C31 VA: 0x1814B30
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1814BE0 Offset: 0x1814CE1 VA: 0x1814BE0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1814C90 Offset: 0x1814D91 VA: 0x1814C90
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1814D40 Offset: 0x1814E41 VA: 0x1814D40
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1814DF0 Offset: 0x1814EF1 VA: 0x1814DF0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1814EA0 Offset: 0x1814FA1 VA: 0x1814EA0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1814F50 Offset: 0x1815051 VA: 0x1814F50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1815000 Offset: 0x1815101 VA: 0x1815000
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x18150B0 Offset: 0x18151B1 VA: 0x18150B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1815160 Offset: 0x1815261 VA: 0x1815160
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1815210 Offset: 0x1815311 VA: 0x1815210
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18152C0 Offset: 0x18153C1 VA: 0x18152C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1815370 Offset: 0x1815471 VA: 0x1815370
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1815420 Offset: 0x1815521 VA: 0x1815420
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18154D0 Offset: 0x18155D1 VA: 0x18154D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1815580 Offset: 0x1815681 VA: 0x1815580
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1815630 Offset: 0x1815731 VA: 0x1815630
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18156E0 Offset: 0x18157E1 VA: 0x18156E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1815790 Offset: 0x1815891 VA: 0x1815790
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1815840 Offset: 0x1815941 VA: 0x1815840
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18158F0 Offset: 0x18159F1 VA: 0x18158F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x18159A0 Offset: 0x1815AA1 VA: 0x18159A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1815A50 Offset: 0x1815B51 VA: 0x1815A50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x1815B00 Offset: 0x1815C01 VA: 0x1815B00
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1815BB0 Offset: 0x1815CB1 VA: 0x1815BB0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1815C60 Offset: 0x1815D61 VA: 0x1815C60
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x1815D10 Offset: 0x1815E11 VA: 0x1815D10
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1815DC0 Offset: 0x1815EC1 VA: 0x1815DC0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1815E70 Offset: 0x1815F71 VA: 0x1815E70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1815F20 Offset: 0x1816021 VA: 0x1815F20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x1815FD0 Offset: 0x18160D1 VA: 0x1815FD0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1816080 Offset: 0x1816181 VA: 0x1816080
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1816130 Offset: 0x1816231 VA: 0x1816130
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18161E0 Offset: 0x18162E1 VA: 0x18161E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1816290 Offset: 0x1816391 VA: 0x1816290
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1816340 Offset: 0x1816441 VA: 0x1816340
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18163F0 Offset: 0x18164F1 VA: 0x18163F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x18164A0 Offset: 0x18165A1 VA: 0x18164A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1816550 Offset: 0x1816651 VA: 0x1816550
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1816600 Offset: 0x1816701 VA: 0x1816600
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x18166B0 Offset: 0x18167B1 VA: 0x18166B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x1816760 Offset: 0x1816861 VA: 0x1816760
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1816810 Offset: 0x1816911 VA: 0x1816810
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x18168C0 Offset: 0x18169C1 VA: 0x18168C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1816970 Offset: 0x1816A71 VA: 0x1816970
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

public sealed class ContractlessStandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5272
{
	// Fields
	public static readonly ContractlessStandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2890 Offset: 0x14F2991 VA: 0x14F2890
	private static void .cctor() { }

	// RVA: 0x14F29C0 Offset: 0x14F2AC1 VA: 0x14F29C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1813D70 Offset: 0x1813E71 VA: 0x1813D70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1813E20 Offset: 0x1813F21 VA: 0x1813E20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1813ED0 Offset: 0x1813FD1 VA: 0x1813ED0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1813F80 Offset: 0x1814081 VA: 0x1813F80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1814030 Offset: 0x1814131 VA: 0x1814030
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18140E0 Offset: 0x18141E1 VA: 0x18140E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1814190 Offset: 0x1814291 VA: 0x1814190
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1814240 Offset: 0x1814341 VA: 0x1814240
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18142F0 Offset: 0x18143F1 VA: 0x18142F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18143A0 Offset: 0x18144A1 VA: 0x18143A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1814450 Offset: 0x1814551 VA: 0x1814450
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1814500 Offset: 0x1814601 VA: 0x1814500
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x18145B0 Offset: 0x18146B1 VA: 0x18145B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1814660 Offset: 0x1814761 VA: 0x1814660
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1814710 Offset: 0x1814811 VA: 0x1814710
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x18147C0 Offset: 0x18148C1 VA: 0x18147C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1814870 Offset: 0x1814971 VA: 0x1814870
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x1814920 Offset: 0x1814A21 VA: 0x1814920
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18149D0 Offset: 0x1814AD1 VA: 0x18149D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1814A80 Offset: 0x1814B81 VA: 0x1814A80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1814B30 Offset: 0x1814C31 VA: 0x1814B30
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1814BE0 Offset: 0x1814CE1 VA: 0x1814BE0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1814C90 Offset: 0x1814D91 VA: 0x1814C90
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1814D40 Offset: 0x1814E41 VA: 0x1814D40
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1814DF0 Offset: 0x1814EF1 VA: 0x1814DF0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1814EA0 Offset: 0x1814FA1 VA: 0x1814EA0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1814F50 Offset: 0x1815051 VA: 0x1814F50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1815000 Offset: 0x1815101 VA: 0x1815000
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x18150B0 Offset: 0x18151B1 VA: 0x18150B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1815160 Offset: 0x1815261 VA: 0x1815160
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1815210 Offset: 0x1815311 VA: 0x1815210
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18152C0 Offset: 0x18153C1 VA: 0x18152C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1815370 Offset: 0x1815471 VA: 0x1815370
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1815420 Offset: 0x1815521 VA: 0x1815420
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18154D0 Offset: 0x18155D1 VA: 0x18154D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1815580 Offset: 0x1815681 VA: 0x1815580
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1815630 Offset: 0x1815731 VA: 0x1815630
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18156E0 Offset: 0x18157E1 VA: 0x18156E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1815790 Offset: 0x1815891 VA: 0x1815790
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1815840 Offset: 0x1815941 VA: 0x1815840
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18158F0 Offset: 0x18159F1 VA: 0x18158F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x18159A0 Offset: 0x1815AA1 VA: 0x18159A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1815A50 Offset: 0x1815B51 VA: 0x1815A50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x1815B00 Offset: 0x1815C01 VA: 0x1815B00
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1815BB0 Offset: 0x1815CB1 VA: 0x1815BB0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1815C60 Offset: 0x1815D61 VA: 0x1815C60
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x1815D10 Offset: 0x1815E11 VA: 0x1815D10
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1815DC0 Offset: 0x1815EC1 VA: 0x1815DC0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1815E70 Offset: 0x1815F71 VA: 0x1815E70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1815F20 Offset: 0x1816021 VA: 0x1815F20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x1815FD0 Offset: 0x18160D1 VA: 0x1815FD0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1816080 Offset: 0x1816181 VA: 0x1816080
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1816130 Offset: 0x1816231 VA: 0x1816130
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18161E0 Offset: 0x18162E1 VA: 0x18161E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1816290 Offset: 0x1816391 VA: 0x1816290
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1816340 Offset: 0x1816441 VA: 0x1816340
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18163F0 Offset: 0x18164F1 VA: 0x18163F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x18164A0 Offset: 0x18165A1 VA: 0x18164A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1816550 Offset: 0x1816651 VA: 0x1816550
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1816600 Offset: 0x1816701 VA: 0x1816600
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x18166B0 Offset: 0x18167B1 VA: 0x18166B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x1816760 Offset: 0x1816861 VA: 0x1816760
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1816810 Offset: 0x1816911 VA: 0x1816810
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x18168C0 Offset: 0x18169C1 VA: 0x18168C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1816970 Offset: 0x1816A71 VA: 0x1816970
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

public sealed class ContractlessStandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5272
{
	// Fields
	public static readonly ContractlessStandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2890 Offset: 0x14F2991 VA: 0x14F2890
	private static void .cctor() { }

	// RVA: 0x14F29C0 Offset: 0x14F2AC1 VA: 0x14F29C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1813D70 Offset: 0x1813E71 VA: 0x1813D70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1813E20 Offset: 0x1813F21 VA: 0x1813E20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1813ED0 Offset: 0x1813FD1 VA: 0x1813ED0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1813F80 Offset: 0x1814081 VA: 0x1813F80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1814030 Offset: 0x1814131 VA: 0x1814030
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18140E0 Offset: 0x18141E1 VA: 0x18140E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1814190 Offset: 0x1814291 VA: 0x1814190
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1814240 Offset: 0x1814341 VA: 0x1814240
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18142F0 Offset: 0x18143F1 VA: 0x18142F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18143A0 Offset: 0x18144A1 VA: 0x18143A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1814450 Offset: 0x1814551 VA: 0x1814450
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1814500 Offset: 0x1814601 VA: 0x1814500
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x18145B0 Offset: 0x18146B1 VA: 0x18145B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1814660 Offset: 0x1814761 VA: 0x1814660
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1814710 Offset: 0x1814811 VA: 0x1814710
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x18147C0 Offset: 0x18148C1 VA: 0x18147C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1814870 Offset: 0x1814971 VA: 0x1814870
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x1814920 Offset: 0x1814A21 VA: 0x1814920
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18149D0 Offset: 0x1814AD1 VA: 0x18149D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1814A80 Offset: 0x1814B81 VA: 0x1814A80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1814B30 Offset: 0x1814C31 VA: 0x1814B30
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1814BE0 Offset: 0x1814CE1 VA: 0x1814BE0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1814C90 Offset: 0x1814D91 VA: 0x1814C90
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1814D40 Offset: 0x1814E41 VA: 0x1814D40
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1814DF0 Offset: 0x1814EF1 VA: 0x1814DF0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1814EA0 Offset: 0x1814FA1 VA: 0x1814EA0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1814F50 Offset: 0x1815051 VA: 0x1814F50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1815000 Offset: 0x1815101 VA: 0x1815000
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x18150B0 Offset: 0x18151B1 VA: 0x18150B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1815160 Offset: 0x1815261 VA: 0x1815160
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1815210 Offset: 0x1815311 VA: 0x1815210
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18152C0 Offset: 0x18153C1 VA: 0x18152C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1815370 Offset: 0x1815471 VA: 0x1815370
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1815420 Offset: 0x1815521 VA: 0x1815420
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18154D0 Offset: 0x18155D1 VA: 0x18154D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1815580 Offset: 0x1815681 VA: 0x1815580
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1815630 Offset: 0x1815731 VA: 0x1815630
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18156E0 Offset: 0x18157E1 VA: 0x18156E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1815790 Offset: 0x1815891 VA: 0x1815790
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1815840 Offset: 0x1815941 VA: 0x1815840
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18158F0 Offset: 0x18159F1 VA: 0x18158F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x18159A0 Offset: 0x1815AA1 VA: 0x18159A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1815A50 Offset: 0x1815B51 VA: 0x1815A50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x1815B00 Offset: 0x1815C01 VA: 0x1815B00
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1815BB0 Offset: 0x1815CB1 VA: 0x1815BB0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1815C60 Offset: 0x1815D61 VA: 0x1815C60
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x1815D10 Offset: 0x1815E11 VA: 0x1815D10
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1815DC0 Offset: 0x1815EC1 VA: 0x1815DC0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1815E70 Offset: 0x1815F71 VA: 0x1815E70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1815F20 Offset: 0x1816021 VA: 0x1815F20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x1815FD0 Offset: 0x18160D1 VA: 0x1815FD0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1816080 Offset: 0x1816181 VA: 0x1816080
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1816130 Offset: 0x1816231 VA: 0x1816130
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18161E0 Offset: 0x18162E1 VA: 0x18161E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1816290 Offset: 0x1816391 VA: 0x1816290
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1816340 Offset: 0x1816441 VA: 0x1816340
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18163F0 Offset: 0x18164F1 VA: 0x18163F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x18164A0 Offset: 0x18165A1 VA: 0x18164A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1816550 Offset: 0x1816651 VA: 0x1816550
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1816600 Offset: 0x1816701 VA: 0x1816600
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x18166B0 Offset: 0x18167B1 VA: 0x18166B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x1816760 Offset: 0x1816861 VA: 0x1816760
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1816810 Offset: 0x1816911 VA: 0x1816810
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x18168C0 Offset: 0x18169C1 VA: 0x18168C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1816970 Offset: 0x1816A71 VA: 0x1816970
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

public sealed class ContractlessStandardResolverAllowPrivate : IFormatterResolver // TypeDefIndex: 5272
{
	// Fields
	public static readonly ContractlessStandardResolverAllowPrivate Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F2890 Offset: 0x14F2991 VA: 0x14F2890
	private static void .cctor() { }

	// RVA: 0x14F29C0 Offset: 0x14F2AC1 VA: 0x14F29C0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1813D70 Offset: 0x1813E71 VA: 0x1813D70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1813E20 Offset: 0x1813F21 VA: 0x1813E20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1813ED0 Offset: 0x1813FD1 VA: 0x1813ED0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1813F80 Offset: 0x1814081 VA: 0x1813F80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1814030 Offset: 0x1814131 VA: 0x1814030
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x18140E0 Offset: 0x18141E1 VA: 0x18140E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1814190 Offset: 0x1814291 VA: 0x1814190
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1814240 Offset: 0x1814341 VA: 0x1814240
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18142F0 Offset: 0x18143F1 VA: 0x18142F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x18143A0 Offset: 0x18144A1 VA: 0x18143A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1814450 Offset: 0x1814551 VA: 0x1814450
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Parameter>
	|
	|-RVA: 0x1814500 Offset: 0x1814601 VA: 0x1814500
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<bool>
	|
	|-RVA: 0x18145B0 Offset: 0x18146B1 VA: 0x18145B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<byte>
	|
	|-RVA: 0x1814660 Offset: 0x1814761 VA: 0x1814660
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<char>
	|
	|-RVA: 0x1814710 Offset: 0x1814811 VA: 0x1814710
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<DateTime>
	|
	|-RVA: 0x18147C0 Offset: 0x18148C1 VA: 0x18147C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<double>
	|
	|-RVA: 0x1814870 Offset: 0x1814971 VA: 0x1814870
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<short>
	|
	|-RVA: 0x1814920 Offset: 0x1814A21 VA: 0x1814920
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<int>
	|
	|-RVA: 0x18149D0 Offset: 0x1814AD1 VA: 0x18149D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1814A80 Offset: 0x1814B81 VA: 0x1814A80
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<long>
	|
	|-RVA: 0x1814B30 Offset: 0x1814C31 VA: 0x1814B30
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1814BE0 Offset: 0x1814CE1 VA: 0x1814BE0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1814C90 Offset: 0x1814D91 VA: 0x1814C90
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1814D40 Offset: 0x1814E41 VA: 0x1814D40
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1814DF0 Offset: 0x1814EF1 VA: 0x1814DF0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1814EA0 Offset: 0x1814FA1 VA: 0x1814EA0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1814F50 Offset: 0x1815051 VA: 0x1814F50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1815000 Offset: 0x1815101 VA: 0x1815000
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x18150B0 Offset: 0x18151B1 VA: 0x18150B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1815160 Offset: 0x1815261 VA: 0x1815160
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1815210 Offset: 0x1815311 VA: 0x1815210
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x18152C0 Offset: 0x18153C1 VA: 0x18152C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1815370 Offset: 0x1815471 VA: 0x1815370
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1815420 Offset: 0x1815521 VA: 0x1815420
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18154D0 Offset: 0x18155D1 VA: 0x18154D0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1815580 Offset: 0x1815681 VA: 0x1815580
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1815630 Offset: 0x1815731 VA: 0x1815630
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18156E0 Offset: 0x18157E1 VA: 0x18156E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1815790 Offset: 0x1815891 VA: 0x1815790
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1815840 Offset: 0x1815941 VA: 0x1815840
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18158F0 Offset: 0x18159F1 VA: 0x18158F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<object>
	|
	|-RVA: 0x18159A0 Offset: 0x1815AA1 VA: 0x18159A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1815A50 Offset: 0x1815B51 VA: 0x1815A50
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<sbyte>
	|
	|-RVA: 0x1815B00 Offset: 0x1815C01 VA: 0x1815B00
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<float>
	|
	|-RVA: 0x1815BB0 Offset: 0x1815CB1 VA: 0x1815BB0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ushort>
	|
	|-RVA: 0x1815C60 Offset: 0x1815D61 VA: 0x1815C60
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<uint>
	|
	|-RVA: 0x1815D10 Offset: 0x1815E11 VA: 0x1815D10
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<ulong>
	|
	|-RVA: 0x1815DC0 Offset: 0x1815EC1 VA: 0x1815DC0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Bounds>
	|
	|-RVA: 0x1815E70 Offset: 0x1815F71 VA: 0x1815E70
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1815F20 Offset: 0x1816021 VA: 0x1815F20
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color32>
	|
	|-RVA: 0x1815FD0 Offset: 0x18160D1 VA: 0x1815FD0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Color>
	|
	|-RVA: 0x1816080 Offset: 0x1816181 VA: 0x1816080
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1816130 Offset: 0x1816231 VA: 0x1816130
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18161E0 Offset: 0x18162E1 VA: 0x18161E0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Keyframe>
	|
	|-RVA: 0x1816290 Offset: 0x1816391 VA: 0x1816290
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<LayerMask>
	|
	|-RVA: 0x1816340 Offset: 0x1816441 VA: 0x1816340
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18163F0 Offset: 0x18164F1 VA: 0x18163F0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Quaternion>
	|
	|-RVA: 0x18164A0 Offset: 0x18165A1 VA: 0x18164A0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RangeInt>
	|
	|-RVA: 0x1816550 Offset: 0x1816651 VA: 0x1816550
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Rect>
	|
	|-RVA: 0x1816600 Offset: 0x1816701 VA: 0x1816600
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<RectInt>
	|
	|-RVA: 0x18166B0 Offset: 0x18167B1 VA: 0x18166B0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2>
	|
	|-RVA: 0x1816760 Offset: 0x1816861 VA: 0x1816760
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1816810 Offset: 0x1816911 VA: 0x1816810
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3>
	|
	|-RVA: 0x18168C0 Offset: 0x18169C1 VA: 0x18168C0
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1816970 Offset: 0x1816A71 VA: 0x1816970
	|-ContractlessStandardResolverAllowPrivate.GetFormatter<Vector4>
	*/
}

