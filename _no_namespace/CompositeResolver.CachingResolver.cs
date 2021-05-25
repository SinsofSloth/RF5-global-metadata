private class CompositeResolver.CachingResolver : IFormatterResolver // TypeDefIndex: 5230
{
	// Fields
	private readonly ThreadsafeTypeKeyHashTable<IMessagePackFormatter> formattersCache; // 0x10
	private readonly IMessagePackFormatter[] subFormatters; // 0x18
	private readonly IFormatterResolver[] subResolvers; // 0x20

	// Methods

	// RVA: 0x14F2360 Offset: 0x14F2461 VA: 0x14F2360
	internal void .ctor(IMessagePackFormatter[] subFormatters, IFormatterResolver[] subResolvers) { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1E830 Offset: 0x1B1E931 VA: 0x1B1E830
	|-CompositeResolver.CachingResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1B1EAA0 Offset: 0x1B1EBA1 VA: 0x1B1EAA0
	|-CompositeResolver.CachingResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1B1ED10 Offset: 0x1B1EE11 VA: 0x1B1ED10
	|-CompositeResolver.CachingResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1B1EF80 Offset: 0x1B1F081 VA: 0x1B1EF80
	|-CompositeResolver.CachingResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1807C10 Offset: 0x1807D11 VA: 0x1807C10
	|-CompositeResolver.CachingResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1807E80 Offset: 0x1807F81 VA: 0x1807E80
	|-CompositeResolver.CachingResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x18080F0 Offset: 0x18081F1 VA: 0x18080F0
	|-CompositeResolver.CachingResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1808360 Offset: 0x1808461 VA: 0x1808360
	|-CompositeResolver.CachingResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x18085D0 Offset: 0x18086D1 VA: 0x18085D0
	|-CompositeResolver.CachingResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1808840 Offset: 0x1808941 VA: 0x1808840
	|-CompositeResolver.CachingResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1808AB0 Offset: 0x1808BB1 VA: 0x1808AB0
	|-CompositeResolver.CachingResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1808D20 Offset: 0x1808E21 VA: 0x1808D20
	|-CompositeResolver.CachingResolver.GetFormatter<bool>
	|
	|-RVA: 0x1808F90 Offset: 0x1809091 VA: 0x1808F90
	|-CompositeResolver.CachingResolver.GetFormatter<byte>
	|
	|-RVA: 0x1809200 Offset: 0x1809301 VA: 0x1809200
	|-CompositeResolver.CachingResolver.GetFormatter<char>
	|
	|-RVA: 0x1809470 Offset: 0x1809571 VA: 0x1809470
	|-CompositeResolver.CachingResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18096E0 Offset: 0x18097E1 VA: 0x18096E0
	|-CompositeResolver.CachingResolver.GetFormatter<double>
	|
	|-RVA: 0x1809950 Offset: 0x1809A51 VA: 0x1809950
	|-CompositeResolver.CachingResolver.GetFormatter<short>
	|
	|-RVA: 0x1809BC0 Offset: 0x1809CC1 VA: 0x1809BC0
	|-CompositeResolver.CachingResolver.GetFormatter<int>
	|
	|-RVA: 0x1809E30 Offset: 0x1809F31 VA: 0x1809E30
	|-CompositeResolver.CachingResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x180A0A0 Offset: 0x180A1A1 VA: 0x180A0A0
	|-CompositeResolver.CachingResolver.GetFormatter<long>
	|
	|-RVA: 0x180A310 Offset: 0x180A411 VA: 0x180A310
	|-CompositeResolver.CachingResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x180A580 Offset: 0x180A681 VA: 0x180A580
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x180A7F0 Offset: 0x180A8F1 VA: 0x180A7F0
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x180AA60 Offset: 0x180AB61 VA: 0x180AA60
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x180ACD0 Offset: 0x180ADD1 VA: 0x180ACD0
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x180AF40 Offset: 0x180B041 VA: 0x180AF40
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x180B1B0 Offset: 0x180B2B1 VA: 0x180B1B0
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x180B420 Offset: 0x180B521 VA: 0x180B420
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x180B690 Offset: 0x180B791 VA: 0x180B690
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x180B900 Offset: 0x180BA01 VA: 0x180B900
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x180BB70 Offset: 0x180BC71 VA: 0x180BB70
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x180BDE0 Offset: 0x180BEE1 VA: 0x180BDE0
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x180C050 Offset: 0x180C151 VA: 0x180C050
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x180C2C0 Offset: 0x180C3C1 VA: 0x180C2C0
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x180C530 Offset: 0x180C631 VA: 0x180C530
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x180C7A0 Offset: 0x180C8A1 VA: 0x180C7A0
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x180CA10 Offset: 0x180CB11 VA: 0x180CA10
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x180CC80 Offset: 0x180CD81 VA: 0x180CC80
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x180CEF0 Offset: 0x180CFF1 VA: 0x180CEF0
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x180D160 Offset: 0x180D261 VA: 0x180D160
	|-CompositeResolver.CachingResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x180D3D0 Offset: 0x180D4D1 VA: 0x180D3D0
	|-CompositeResolver.CachingResolver.GetFormatter<object>
	|
	|-RVA: 0x180D640 Offset: 0x180D741 VA: 0x180D640
	|-CompositeResolver.CachingResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x180D8B0 Offset: 0x180D9B1 VA: 0x180D8B0
	|-CompositeResolver.CachingResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x180DB20 Offset: 0x180DC21 VA: 0x180DB20
	|-CompositeResolver.CachingResolver.GetFormatter<float>
	|
	|-RVA: 0x180DD90 Offset: 0x180DE91 VA: 0x180DD90
	|-CompositeResolver.CachingResolver.GetFormatter<ushort>
	|
	|-RVA: 0x180E000 Offset: 0x180E101 VA: 0x180E000
	|-CompositeResolver.CachingResolver.GetFormatter<uint>
	|
	|-RVA: 0x180E270 Offset: 0x180E371 VA: 0x180E270
	|-CompositeResolver.CachingResolver.GetFormatter<ulong>
	|
	|-RVA: 0x180E4E0 Offset: 0x180E5E1 VA: 0x180E4E0
	|-CompositeResolver.CachingResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x180E750 Offset: 0x180E851 VA: 0x180E750
	|-CompositeResolver.CachingResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x180E9C0 Offset: 0x180EAC1 VA: 0x180E9C0
	|-CompositeResolver.CachingResolver.GetFormatter<Color32>
	|
	|-RVA: 0x180EC30 Offset: 0x180ED31 VA: 0x180EC30
	|-CompositeResolver.CachingResolver.GetFormatter<Color>
	|
	|-RVA: 0x180EEA0 Offset: 0x180EFA1 VA: 0x180EEA0
	|-CompositeResolver.CachingResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x180F110 Offset: 0x180F211 VA: 0x180F110
	|-CompositeResolver.CachingResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x180F380 Offset: 0x180F481 VA: 0x180F380
	|-CompositeResolver.CachingResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x180F5F0 Offset: 0x180F6F1 VA: 0x180F5F0
	|-CompositeResolver.CachingResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x180F860 Offset: 0x180F961 VA: 0x180F860
	|-CompositeResolver.CachingResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x180FAD0 Offset: 0x180FBD1 VA: 0x180FAD0
	|-CompositeResolver.CachingResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x180FD40 Offset: 0x180FE41 VA: 0x180FD40
	|-CompositeResolver.CachingResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x180FFB0 Offset: 0x18100B1 VA: 0x180FFB0
	|-CompositeResolver.CachingResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1810220 Offset: 0x1810321 VA: 0x1810220
	|-CompositeResolver.CachingResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1810490 Offset: 0x1810591 VA: 0x1810490
	|-CompositeResolver.CachingResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1810700 Offset: 0x1810801 VA: 0x1810700
	|-CompositeResolver.CachingResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1810970 Offset: 0x1810A71 VA: 0x1810970
	|-CompositeResolver.CachingResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1810BE0 Offset: 0x1810CE1 VA: 0x1810BE0
	|-CompositeResolver.CachingResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1810E50 Offset: 0x1810F51 VA: 0x1810E50
	|-CompositeResolver.CachingResolver.GetFormatter<Vector4>
	*/
}

