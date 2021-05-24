public sealed class EnumAsStringFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter // TypeDefIndex: 5404
{
	// Fields
	private readonly IReadOnlyDictionary<string, T> nameValueMapping; // 0x0
	private readonly IReadOnlyDictionary<T, string> valueNameMapping; // 0x0
	private readonly IReadOnlyDictionary<string, string> clrToSerializationName; // 0x0
	private readonly IReadOnlyDictionary<string, string> serializationToClrName; // 0x0
	private readonly bool enumMemberOverridesPresent; // 0x0
	private readonly bool isFlags; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CFA0 Offset: 0x270D0A1 VA: 0x270CFA0
	|-EnumAsStringFormatter<BitVector32Int>..ctor
	|
	|-RVA: 0x270DA90 Offset: 0x270DB91 VA: 0x270DA90
	|-EnumAsStringFormatter<EventCheckId>..ctor
	|
	|-RVA: 0x270E680 Offset: 0x270E781 VA: 0x270E680
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x270F330 Offset: 0x270F431 VA: 0x270F330
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x270FF20 Offset: 0x2710021 VA: 0x270FF20
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2710A90 Offset: 0x2710B91 VA: 0x2710A90
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x27115C0 Offset: 0x27116C1 VA: 0x27115C0
	|-EnumAsStringFormatter<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2712200 Offset: 0x2712301 VA: 0x2712200
	|-EnumAsStringFormatter<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2712D70 Offset: 0x2712E71 VA: 0x2712D70
	|-EnumAsStringFormatter<OrderSaveData>..ctor
	|
	|-RVA: 0x27139B0 Offset: 0x2713AB1 VA: 0x27139B0
	|-EnumAsStringFormatter<OrderSaveParameter>..ctor
	|
	|-RVA: 0x27145A0 Offset: 0x27146A1 VA: 0x27145A0
	|-EnumAsStringFormatter<Parameter>..ctor
	|
	|-RVA: 0x2715210 Offset: 0x2715311 VA: 0x2715210
	|-EnumAsStringFormatter<bool>..ctor
	|
	|-RVA: 0x2715D10 Offset: 0x2715E11 VA: 0x2715D10
	|-EnumAsStringFormatter<byte>..ctor
	|
	|-RVA: 0x2716800 Offset: 0x2716901 VA: 0x2716800
	|-EnumAsStringFormatter<char>..ctor
	|
	|-RVA: 0x27172F0 Offset: 0x27173F1 VA: 0x27172F0
	|-EnumAsStringFormatter<DateTime>..ctor
	|
	|-RVA: 0x2717DD0 Offset: 0x2717ED1 VA: 0x2717DD0
	|-EnumAsStringFormatter<double>..ctor
	|
	|-RVA: 0x27188E0 Offset: 0x27189E1 VA: 0x27188E0
	|-EnumAsStringFormatter<short>..ctor
	|
	|-RVA: 0x27193D0 Offset: 0x27194D1 VA: 0x27193D0
	|-EnumAsStringFormatter<int>..ctor
	|
	|-RVA: 0x2719EC0 Offset: 0x2719FC1 VA: 0x2719EC0
	|-EnumAsStringFormatter<Int32Enum>..ctor
	|
	|-RVA: 0x271A9D0 Offset: 0x271AAD1 VA: 0x271A9D0
	|-EnumAsStringFormatter<long>..ctor
	|
	|-RVA: 0x271B4B0 Offset: 0x271B5B1 VA: 0x271B4B0
	|-EnumAsStringFormatter<Memory<object>>..ctor
	|
	|-RVA: 0x271BFC0 Offset: 0x271C0C1 VA: 0x271BFC0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x271CAA0 Offset: 0x271CBA1 VA: 0x271CAA0
	|-EnumAsStringFormatter<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x271D680 Offset: 0x271D781 VA: 0x271D680
	|-EnumAsStringFormatter<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x271E260 Offset: 0x271E361 VA: 0x271E260
	|-EnumAsStringFormatter<Nullable<Color32>>..ctor
	|
	|-RVA: 0x271ED40 Offset: 0x271EE41 VA: 0x271ED40
	|-EnumAsStringFormatter<Nullable<Color>>..ctor
	|
	|-RVA: 0x271F8D0 Offset: 0x271F9D1 VA: 0x271F8D0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2720400 Offset: 0x2720501 VA: 0x2720400
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2720F90 Offset: 0x2721091 VA: 0x2720F90
	|-EnumAsStringFormatter<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2721B10 Offset: 0x2721C11 VA: 0x2721B10
	|-EnumAsStringFormatter<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x27225F0 Offset: 0x27226F1 VA: 0x27225F0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x27232C0 Offset: 0x27233C1 VA: 0x27232C0
	|-EnumAsStringFormatter<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2723E50 Offset: 0x2723F51 VA: 0x2723E50
	|-EnumAsStringFormatter<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2724980 Offset: 0x2724A81 VA: 0x2724980
	|-EnumAsStringFormatter<Nullable<Rect>>..ctor
	|
	|-RVA: 0x27C89E0 Offset: 0x27C8AE1 VA: 0x27C89E0
	|-EnumAsStringFormatter<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x27C9570 Offset: 0x27C9671 VA: 0x27C9570
	|-EnumAsStringFormatter<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x27CA0A0 Offset: 0x27CA1A1 VA: 0x27CA0A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x27CABD0 Offset: 0x27CACD1 VA: 0x27CABD0
	|-EnumAsStringFormatter<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x27CB6D0 Offset: 0x27CB7D1 VA: 0x27CB6D0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x27CC1D0 Offset: 0x27CC2D1 VA: 0x27CC1D0
	|-EnumAsStringFormatter<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x27CCD60 Offset: 0x27CCE61 VA: 0x27CCD60
	|-EnumAsStringFormatter<object>..ctor
	|
	|-RVA: 0x27CD840 Offset: 0x27CD941 VA: 0x27CD840
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x27CE350 Offset: 0x27CE451 VA: 0x27CE350
	|-EnumAsStringFormatter<sbyte>..ctor
	|
	|-RVA: 0x27CEE40 Offset: 0x27CEF41 VA: 0x27CEE40
	|-EnumAsStringFormatter<float>..ctor
	|
	|-RVA: 0x27CF950 Offset: 0x27CFA51 VA: 0x27CF950
	|-EnumAsStringFormatter<ushort>..ctor
	|
	|-RVA: 0x27D0440 Offset: 0x27D0541 VA: 0x27D0440
	|-EnumAsStringFormatter<uint>..ctor
	|
	|-RVA: 0x27D0F30 Offset: 0x27D1031 VA: 0x27D0F30
	|-EnumAsStringFormatter<ulong>..ctor
	|
	|-RVA: 0x27D1A10 Offset: 0x27D1B11 VA: 0x27D1A10
	|-EnumAsStringFormatter<Bounds>..ctor
	|
	|-RVA: 0x27D25B0 Offset: 0x27D26B1 VA: 0x27D25B0
	|-EnumAsStringFormatter<BoundsInt>..ctor
	|
	|-RVA: 0x27D3150 Offset: 0x27D3251 VA: 0x27D3150
	|-EnumAsStringFormatter<Color32>..ctor
	|
	|-RVA: 0x27D3C40 Offset: 0x27D3D41 VA: 0x27D3C40
	|-EnumAsStringFormatter<Color>..ctor
	|
	|-RVA: 0x27D4790 Offset: 0x27D4891 VA: 0x27D4790
	|-EnumAsStringFormatter<GradientAlphaKey>..ctor
	|
	|-RVA: 0x27D5300 Offset: 0x27D5401 VA: 0x27D5300
	|-EnumAsStringFormatter<GradientColorKey>..ctor
	|
	|-RVA: 0x27D5EF0 Offset: 0x27D5FF1 VA: 0x27D5EF0
	|-EnumAsStringFormatter<Keyframe>..ctor
	|
	|-RVA: 0x27D6B30 Offset: 0x27D6C31 VA: 0x27D6B30
	|-EnumAsStringFormatter<LayerMask>..ctor
	|
	|-RVA: 0x27D7660 Offset: 0x27D7761 VA: 0x27D7660
	|-EnumAsStringFormatter<Matrix4x4>..ctor
	|
	|-RVA: 0x27D82A0 Offset: 0x27D83A1 VA: 0x27D82A0
	|-EnumAsStringFormatter<Quaternion>..ctor
	|
	|-RVA: 0x27D8DF0 Offset: 0x27D8EF1 VA: 0x27D8DF0
	|-EnumAsStringFormatter<RangeInt>..ctor
	|
	|-RVA: 0x27D9920 Offset: 0x27D9A21 VA: 0x27D9920
	|-EnumAsStringFormatter<Rect>..ctor
	|
	|-RVA: 0x27DA470 Offset: 0x27DA571 VA: 0x27DA470
	|-EnumAsStringFormatter<RectInt>..ctor
	|
	|-RVA: 0x27DAF60 Offset: 0x27DB061 VA: 0x27DAF60
	|-EnumAsStringFormatter<Vector2>..ctor
	|
	|-RVA: 0x27DBA90 Offset: 0x27DBB91 VA: 0x27DBA90
	|-EnumAsStringFormatter<Vector2Int>..ctor
	|
	|-RVA: 0x27DC570 Offset: 0x27DC671 VA: 0x27DC570
	|-EnumAsStringFormatter<Vector3>..ctor
	|
	|-RVA: 0x27DD0C0 Offset: 0x27DD1C1 VA: 0x27DD0C0
	|-EnumAsStringFormatter<Vector3Int>..ctor
	|
	|-RVA: 0x27DDBE0 Offset: 0x27DDCE1 VA: 0x27DDBE0
	|-EnumAsStringFormatter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D390 Offset: 0x270D491 VA: 0x270D390
	|-EnumAsStringFormatter<BitVector32Int>.Serialize
	|
	|-RVA: 0x270DEF0 Offset: 0x270DFF1 VA: 0x270DEF0
	|-EnumAsStringFormatter<EventCheckId>.Serialize
	|
	|-RVA: 0x270EB40 Offset: 0x270EC41 VA: 0x270EB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Serialize
	|
	|-RVA: 0x270F790 Offset: 0x270F891 VA: 0x270F790
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Serialize
	|
	|-RVA: 0x2710320 Offset: 0x2710421 VA: 0x2710320
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Serialize
	|
	|-RVA: 0x2710E70 Offset: 0x2710F71 VA: 0x2710E70
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Serialize
	|
	|-RVA: 0x2711A40 Offset: 0x2711B41 VA: 0x2711A40
	|-EnumAsStringFormatter<MonsterHutSaveData>.Serialize
	|
	|-RVA: 0x2712600 Offset: 0x2712701 VA: 0x2712600
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Serialize
	|
	|-RVA: 0x27131F0 Offset: 0x27132F1 VA: 0x27131F0
	|-EnumAsStringFormatter<OrderSaveData>.Serialize
	|
	|-RVA: 0x2713E10 Offset: 0x2713F11 VA: 0x2713E10
	|-EnumAsStringFormatter<OrderSaveParameter>.Serialize
	|
	|-RVA: 0x2714A40 Offset: 0x2714B41 VA: 0x2714A40
	|-EnumAsStringFormatter<Parameter>.Serialize
	|
	|-RVA: 0x2715610 Offset: 0x2715711 VA: 0x2715610
	|-EnumAsStringFormatter<bool>.Serialize
	|
	|-RVA: 0x2716100 Offset: 0x2716201 VA: 0x2716100
	|-EnumAsStringFormatter<byte>.Serialize
	|
	|-RVA: 0x2716BF0 Offset: 0x2716CF1 VA: 0x2716BF0
	|-EnumAsStringFormatter<char>.Serialize
	|
	|-RVA: 0x27176E0 Offset: 0x27177E1 VA: 0x27176E0
	|-EnumAsStringFormatter<DateTime>.Serialize
	|
	|-RVA: 0x27181E0 Offset: 0x27182E1 VA: 0x27181E0
	|-EnumAsStringFormatter<double>.Serialize
	|
	|-RVA: 0x2718CD0 Offset: 0x2718DD1 VA: 0x2718CD0
	|-EnumAsStringFormatter<short>.Serialize
	|
	|-RVA: 0x27197C0 Offset: 0x27198C1 VA: 0x27197C0
	|-EnumAsStringFormatter<int>.Serialize
	|
	|-RVA: 0x271A2B0 Offset: 0x271A3B1 VA: 0x271A2B0
	|-EnumAsStringFormatter<Int32Enum>.Serialize
	|
	|-RVA: 0x271ADC0 Offset: 0x271AEC1 VA: 0x271ADC0
	|-EnumAsStringFormatter<long>.Serialize
	|
	|-RVA: 0x271B890 Offset: 0x271B991 VA: 0x271B890
	|-EnumAsStringFormatter<Memory<object>>.Serialize
	|
	|-RVA: 0x271C390 Offset: 0x271C491 VA: 0x271C390
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Serialize
	|
	|-RVA: 0x271CED0 Offset: 0x271CFD1 VA: 0x271CED0
	|-EnumAsStringFormatter<Nullable<Bounds>>.Serialize
	|
	|-RVA: 0x271DAB0 Offset: 0x271DBB1 VA: 0x271DAB0
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Serialize
	|
	|-RVA: 0x271E630 Offset: 0x271E731 VA: 0x271E630
	|-EnumAsStringFormatter<Nullable<Color32>>.Serialize
	|
	|-RVA: 0x271F150 Offset: 0x271F251 VA: 0x271F150
	|-EnumAsStringFormatter<Nullable<Color>>.Serialize
	|
	|-RVA: 0x271FCD0 Offset: 0x271FDD1 VA: 0x271FCD0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Serialize
	|
	|-RVA: 0x2720810 Offset: 0x2720911 VA: 0x2720810
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Serialize
	|
	|-RVA: 0x2721390 Offset: 0x2721491 VA: 0x2721390
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Serialize
	|
	|-RVA: 0x2721EE0 Offset: 0x2721FE1 VA: 0x2721EE0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Serialize
	|
	|-RVA: 0x2722A70 Offset: 0x2722B71 VA: 0x2722A70
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Serialize
	|
	|-RVA: 0x27236D0 Offset: 0x27237D1 VA: 0x27236D0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Serialize
	|
	|-RVA: 0x2724250 Offset: 0x2724351 VA: 0x2724250
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Serialize
	|
	|-RVA: 0x2724D90 Offset: 0x2724E91 VA: 0x2724D90
	|-EnumAsStringFormatter<Nullable<Rect>>.Serialize
	|
	|-RVA: 0x27C8DF0 Offset: 0x27C8EF1 VA: 0x27C8DF0
	|-EnumAsStringFormatter<Nullable<RectInt>>.Serialize
	|
	|-RVA: 0x27C9970 Offset: 0x27C9A71 VA: 0x27C9970
	|-EnumAsStringFormatter<Nullable<Vector2>>.Serialize
	|
	|-RVA: 0x27CA4A0 Offset: 0x27CA5A1 VA: 0x27CA4A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Serialize
	|
	|-RVA: 0x27CAFB0 Offset: 0x27CB0B1 VA: 0x27CAFB0
	|-EnumAsStringFormatter<Nullable<Vector3>>.Serialize
	|
	|-RVA: 0x27CBAB0 Offset: 0x27CBBB1 VA: 0x27CBAB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Serialize
	|
	|-RVA: 0x27CC5E0 Offset: 0x27CC6E1 VA: 0x27CC5E0
	|-EnumAsStringFormatter<Nullable<Vector4>>.Serialize
	|
	|-RVA: 0x27CD150 Offset: 0x27CD251 VA: 0x27CD150
	|-EnumAsStringFormatter<object>.Serialize
	|
	|-RVA: 0x27CDC20 Offset: 0x27CDD21 VA: 0x27CDC20
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Serialize
	|
	|-RVA: 0x27CE740 Offset: 0x27CE841 VA: 0x27CE740
	|-EnumAsStringFormatter<sbyte>.Serialize
	|
	|-RVA: 0x27CF250 Offset: 0x27CF351 VA: 0x27CF250
	|-EnumAsStringFormatter<float>.Serialize
	|
	|-RVA: 0x27CFD40 Offset: 0x27CFE41 VA: 0x27CFD40
	|-EnumAsStringFormatter<ushort>.Serialize
	|
	|-RVA: 0x27D0830 Offset: 0x27D0931 VA: 0x27D0830
	|-EnumAsStringFormatter<uint>.Serialize
	|
	|-RVA: 0x27D1320 Offset: 0x27D1421 VA: 0x27D1320
	|-EnumAsStringFormatter<ulong>.Serialize
	|
	|-RVA: 0x27D1E70 Offset: 0x27D1F71 VA: 0x27D1E70
	|-EnumAsStringFormatter<Bounds>.Serialize
	|
	|-RVA: 0x27D2A10 Offset: 0x27D2B11 VA: 0x27D2A10
	|-EnumAsStringFormatter<BoundsInt>.Serialize
	|
	|-RVA: 0x27D3540 Offset: 0x27D3641 VA: 0x27D3540
	|-EnumAsStringFormatter<Color32>.Serialize
	|
	|-RVA: 0x27D4070 Offset: 0x27D4171 VA: 0x27D4070
	|-EnumAsStringFormatter<Color>.Serialize
	|
	|-RVA: 0x27D4BA0 Offset: 0x27D4CA1 VA: 0x27D4BA0
	|-EnumAsStringFormatter<GradientAlphaKey>.Serialize
	|
	|-RVA: 0x27D5760 Offset: 0x27D5861 VA: 0x27D5760
	|-EnumAsStringFormatter<GradientColorKey>.Serialize
	|
	|-RVA: 0x27D6370 Offset: 0x27D6471 VA: 0x27D6370
	|-EnumAsStringFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x27D6F20 Offset: 0x27D7021 VA: 0x27D6F20
	|-EnumAsStringFormatter<LayerMask>.Serialize
	|
	|-RVA: 0x27D7B10 Offset: 0x27D7C11 VA: 0x27D7B10
	|-EnumAsStringFormatter<Matrix4x4>.Serialize
	|
	|-RVA: 0x27D86D0 Offset: 0x27D87D1 VA: 0x27D86D0
	|-EnumAsStringFormatter<Quaternion>.Serialize
	|
	|-RVA: 0x27D91E0 Offset: 0x27D92E1 VA: 0x27D91E0
	|-EnumAsStringFormatter<RangeInt>.Serialize
	|
	|-RVA: 0x27D9D50 Offset: 0x27D9E51 VA: 0x27D9D50
	|-EnumAsStringFormatter<Rect>.Serialize
	|
	|-RVA: 0x27DA850 Offset: 0x27DA951 VA: 0x27DA850
	|-EnumAsStringFormatter<RectInt>.Serialize
	|
	|-RVA: 0x27DB370 Offset: 0x27DB471 VA: 0x27DB370
	|-EnumAsStringFormatter<Vector2>.Serialize
	|
	|-RVA: 0x27DBE80 Offset: 0x27DBF81 VA: 0x27DBE80
	|-EnumAsStringFormatter<Vector2Int>.Serialize
	|
	|-RVA: 0x27DC990 Offset: 0x27DCA91 VA: 0x27DC990
	|-EnumAsStringFormatter<Vector3>.Serialize
	|
	|-RVA: 0x27DD4C0 Offset: 0x27DD5C1 VA: 0x27DD4C0
	|-EnumAsStringFormatter<Vector3Int>.Serialize
	|
	|-RVA: 0x27DE010 Offset: 0x27DE111 VA: 0x27DE010
	|-EnumAsStringFormatter<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D4C0 Offset: 0x270D5C1 VA: 0x270D4C0
	|-EnumAsStringFormatter<BitVector32Int>.Deserialize
	|
	|-RVA: 0x270E090 Offset: 0x270E191 VA: 0x270E090
	|-EnumAsStringFormatter<EventCheckId>.Deserialize
	|
	|-RVA: 0x270ED30 Offset: 0x270EE31 VA: 0x270ED30
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Deserialize
	|
	|-RVA: 0x270F930 Offset: 0x270FA31 VA: 0x270F930
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Deserialize
	|
	|-RVA: 0x27104B0 Offset: 0x27105B1 VA: 0x27104B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Deserialize
	|
	|-RVA: 0x2710FF0 Offset: 0x27110F1 VA: 0x2710FF0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Deserialize
	|
	|-RVA: 0x2711C00 Offset: 0x2711D01 VA: 0x2711C00
	|-EnumAsStringFormatter<MonsterHutSaveData>.Deserialize
	|
	|-RVA: 0x2712790 Offset: 0x2712891 VA: 0x2712790
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Deserialize
	|
	|-RVA: 0x27133B0 Offset: 0x27134B1 VA: 0x27133B0
	|-EnumAsStringFormatter<OrderSaveData>.Deserialize
	|
	|-RVA: 0x2713FB0 Offset: 0x27140B1 VA: 0x2713FB0
	|-EnumAsStringFormatter<OrderSaveParameter>.Deserialize
	|
	|-RVA: 0x2714BF0 Offset: 0x2714CF1 VA: 0x2714BF0
	|-EnumAsStringFormatter<Parameter>.Deserialize
	|
	|-RVA: 0x2715740 Offset: 0x2715841 VA: 0x2715740
	|-EnumAsStringFormatter<bool>.Deserialize
	|
	|-RVA: 0x2716230 Offset: 0x2716331 VA: 0x2716230
	|-EnumAsStringFormatter<byte>.Deserialize
	|
	|-RVA: 0x2716D20 Offset: 0x2716E21 VA: 0x2716D20
	|-EnumAsStringFormatter<char>.Deserialize
	|
	|-RVA: 0x2717800 Offset: 0x2717901 VA: 0x2717800
	|-EnumAsStringFormatter<DateTime>.Deserialize
	|
	|-RVA: 0x2718310 Offset: 0x2718411 VA: 0x2718310
	|-EnumAsStringFormatter<double>.Deserialize
	|
	|-RVA: 0x2718E00 Offset: 0x2718F01 VA: 0x2718E00
	|-EnumAsStringFormatter<short>.Deserialize
	|
	|-RVA: 0x27198F0 Offset: 0x27199F1 VA: 0x27198F0
	|-EnumAsStringFormatter<int>.Deserialize
	|
	|-RVA: 0x271A400 Offset: 0x271A501 VA: 0x271A400
	|-EnumAsStringFormatter<Int32Enum>.Deserialize
	|
	|-RVA: 0x271AEE0 Offset: 0x271AFE1 VA: 0x271AEE0
	|-EnumAsStringFormatter<long>.Deserialize
	|
	|-RVA: 0x271B9F0 Offset: 0x271BAF1 VA: 0x271B9F0
	|-EnumAsStringFormatter<Memory<object>>.Deserialize
	|
	|-RVA: 0x271C4E0 Offset: 0x271C5E1 VA: 0x271C4E0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Deserialize
	|
	|-RVA: 0x271D090 Offset: 0x271D191 VA: 0x271D090
	|-EnumAsStringFormatter<Nullable<Bounds>>.Deserialize
	|
	|-RVA: 0x271DC70 Offset: 0x271DD71 VA: 0x271DC70
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Deserialize
	|
	|-RVA: 0x271E780 Offset: 0x271E881 VA: 0x271E780
	|-EnumAsStringFormatter<Nullable<Color32>>.Deserialize
	|
	|-RVA: 0x271F2F0 Offset: 0x271F3F1 VA: 0x271F2F0
	|-EnumAsStringFormatter<Nullable<Color>>.Deserialize
	|
	|-RVA: 0x271FE30 Offset: 0x271FF31 VA: 0x271FE30
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Deserialize
	|
	|-RVA: 0x27209B0 Offset: 0x2720AB1 VA: 0x27209B0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Deserialize
	|
	|-RVA: 0x2721530 Offset: 0x2721631 VA: 0x2721530
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Deserialize
	|
	|-RVA: 0x2722030 Offset: 0x2722131 VA: 0x2722030
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Deserialize
	|
	|-RVA: 0x2722CA0 Offset: 0x2722DA1 VA: 0x2722CA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Deserialize
	|
	|-RVA: 0x2723870 Offset: 0x2723971 VA: 0x2723870
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Deserialize
	|
	|-RVA: 0x27243B0 Offset: 0x27244B1 VA: 0x27243B0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Deserialize
	|
	|-RVA: 0x2724F30 Offset: 0x2725031 VA: 0x2724F30
	|-EnumAsStringFormatter<Nullable<Rect>>.Deserialize
	|
	|-RVA: 0x27C8F90 Offset: 0x27C9091 VA: 0x27C8F90
	|-EnumAsStringFormatter<Nullable<RectInt>>.Deserialize
	|
	|-RVA: 0x27C9AD0 Offset: 0x27C9BD1 VA: 0x27C9AD0
	|-EnumAsStringFormatter<Nullable<Vector2>>.Deserialize
	|
	|-RVA: 0x27CA600 Offset: 0x27CA701 VA: 0x27CA600
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Deserialize
	|
	|-RVA: 0x27CB110 Offset: 0x27CB211 VA: 0x27CB110
	|-EnumAsStringFormatter<Nullable<Vector3>>.Deserialize
	|
	|-RVA: 0x27CBC10 Offset: 0x27CBD11 VA: 0x27CBC10
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Deserialize
	|
	|-RVA: 0x27CC780 Offset: 0x27CC881 VA: 0x27CC780
	|-EnumAsStringFormatter<Nullable<Vector4>>.Deserialize
	|
	|-RVA: 0x27CD280 Offset: 0x27CD381 VA: 0x27CD280
	|-EnumAsStringFormatter<object>.Deserialize
	|
	|-RVA: 0x27CDD80 Offset: 0x27CDE81 VA: 0x27CDD80
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Deserialize
	|
	|-RVA: 0x27CE870 Offset: 0x27CE971 VA: 0x27CE870
	|-EnumAsStringFormatter<sbyte>.Deserialize
	|
	|-RVA: 0x27CF380 Offset: 0x27CF481 VA: 0x27CF380
	|-EnumAsStringFormatter<float>.Deserialize
	|
	|-RVA: 0x27CFE70 Offset: 0x27CFF71 VA: 0x27CFE70
	|-EnumAsStringFormatter<ushort>.Deserialize
	|
	|-RVA: 0x27D0960 Offset: 0x27D0A61 VA: 0x27D0960
	|-EnumAsStringFormatter<uint>.Deserialize
	|
	|-RVA: 0x27D1440 Offset: 0x27D1541 VA: 0x27D1440
	|-EnumAsStringFormatter<ulong>.Deserialize
	|
	|-RVA: 0x27D1FC0 Offset: 0x27D20C1 VA: 0x27D1FC0
	|-EnumAsStringFormatter<Bounds>.Deserialize
	|
	|-RVA: 0x27D2B60 Offset: 0x27D2C61 VA: 0x27D2B60
	|-EnumAsStringFormatter<BoundsInt>.Deserialize
	|
	|-RVA: 0x27D3670 Offset: 0x27D3771 VA: 0x27D3670
	|-EnumAsStringFormatter<Color32>.Deserialize
	|
	|-RVA: 0x27D41C0 Offset: 0x27D42C1 VA: 0x27D41C0
	|-EnumAsStringFormatter<Color>.Deserialize
	|
	|-RVA: 0x27D4D20 Offset: 0x27D4E21 VA: 0x27D4D20
	|-EnumAsStringFormatter<GradientAlphaKey>.Deserialize
	|
	|-RVA: 0x27D5900 Offset: 0x27D5A01 VA: 0x27D5900
	|-EnumAsStringFormatter<GradientColorKey>.Deserialize
	|
	|-RVA: 0x27D6530 Offset: 0x27D6631 VA: 0x27D6530
	|-EnumAsStringFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x27D7090 Offset: 0x27D7191 VA: 0x27D7090
	|-EnumAsStringFormatter<LayerMask>.Deserialize
	|
	|-RVA: 0x27D7CA0 Offset: 0x27D7DA1 VA: 0x27D7CA0
	|-EnumAsStringFormatter<Matrix4x4>.Deserialize
	|
	|-RVA: 0x27D8820 Offset: 0x27D8921 VA: 0x27D8820
	|-EnumAsStringFormatter<Quaternion>.Deserialize
	|
	|-RVA: 0x27D9350 Offset: 0x27D9451 VA: 0x27D9350
	|-EnumAsStringFormatter<RangeInt>.Deserialize
	|
	|-RVA: 0x27D9EA0 Offset: 0x27D9FA1 VA: 0x27D9EA0
	|-EnumAsStringFormatter<Rect>.Deserialize
	|
	|-RVA: 0x27DA990 Offset: 0x27DAA91 VA: 0x27DA990
	|-EnumAsStringFormatter<RectInt>.Deserialize
	|
	|-RVA: 0x27DB4B0 Offset: 0x27DB5B1 VA: 0x27DB4B0
	|-EnumAsStringFormatter<Vector2>.Deserialize
	|
	|-RVA: 0x27DBFA0 Offset: 0x27DC0A1 VA: 0x27DBFA0
	|-EnumAsStringFormatter<Vector2Int>.Deserialize
	|
	|-RVA: 0x27DCAE0 Offset: 0x27DCBE1 VA: 0x27DCAE0
	|-EnumAsStringFormatter<Vector3>.Deserialize
	|
	|-RVA: 0x27DD600 Offset: 0x27DD701 VA: 0x27DD600
	|-EnumAsStringFormatter<Vector3Int>.Deserialize
	|
	|-RVA: 0x27DE160 Offset: 0x27DE261 VA: 0x27DE160
	|-EnumAsStringFormatter<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	private string GetClrNames(string serializedNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D6B0 Offset: 0x270D7B1 VA: 0x270D6B0
	|-EnumAsStringFormatter<BitVector32Int>.GetClrNames
	|
	|-RVA: 0x270E2A0 Offset: 0x270E3A1 VA: 0x270E2A0
	|-EnumAsStringFormatter<EventCheckId>.GetClrNames
	|
	|-RVA: 0x270EF50 Offset: 0x270F051 VA: 0x270EF50
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetClrNames
	|
	|-RVA: 0x270FB40 Offset: 0x270FC41 VA: 0x270FB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetClrNames
	|
	|-RVA: 0x27106B0 Offset: 0x27107B1 VA: 0x27106B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetClrNames
	|
	|-RVA: 0x27111E0 Offset: 0x27112E1 VA: 0x27111E0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetClrNames
	|
	|-RVA: 0x2711E20 Offset: 0x2711F21 VA: 0x2711E20
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetClrNames
	|
	|-RVA: 0x2712990 Offset: 0x2712A91 VA: 0x2712990
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetClrNames
	|
	|-RVA: 0x27135D0 Offset: 0x27136D1 VA: 0x27135D0
	|-EnumAsStringFormatter<OrderSaveData>.GetClrNames
	|
	|-RVA: 0x27141C0 Offset: 0x27142C1 VA: 0x27141C0
	|-EnumAsStringFormatter<OrderSaveParameter>.GetClrNames
	|
	|-RVA: 0x2714E30 Offset: 0x2714F31 VA: 0x2714E30
	|-EnumAsStringFormatter<Parameter>.GetClrNames
	|
	|-RVA: 0x2715930 Offset: 0x2715A31 VA: 0x2715930
	|-EnumAsStringFormatter<bool>.GetClrNames
	|
	|-RVA: 0x2716420 Offset: 0x2716521 VA: 0x2716420
	|-EnumAsStringFormatter<byte>.GetClrNames
	|
	|-RVA: 0x2716F10 Offset: 0x2717011 VA: 0x2716F10
	|-EnumAsStringFormatter<char>.GetClrNames
	|
	|-RVA: 0x27179F0 Offset: 0x2717AF1 VA: 0x27179F0
	|-EnumAsStringFormatter<DateTime>.GetClrNames
	|
	|-RVA: 0x2718500 Offset: 0x2718601 VA: 0x2718500
	|-EnumAsStringFormatter<double>.GetClrNames
	|
	|-RVA: 0x2718FF0 Offset: 0x27190F1 VA: 0x2718FF0
	|-EnumAsStringFormatter<short>.GetClrNames
	|
	|-RVA: 0x2719AE0 Offset: 0x2719BE1 VA: 0x2719AE0
	|-EnumAsStringFormatter<int>.GetClrNames
	|
	|-RVA: 0x271A5F0 Offset: 0x271A6F1 VA: 0x271A5F0
	|-EnumAsStringFormatter<Int32Enum>.GetClrNames
	|
	|-RVA: 0x271B0D0 Offset: 0x271B1D1 VA: 0x271B0D0
	|-EnumAsStringFormatter<long>.GetClrNames
	|
	|-RVA: 0x271BBE0 Offset: 0x271BCE1 VA: 0x271BBE0
	|-EnumAsStringFormatter<Memory<object>>.GetClrNames
	|
	|-RVA: 0x271C6C0 Offset: 0x271C7C1 VA: 0x271C6C0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetClrNames
	|
	|-RVA: 0x271D2A0 Offset: 0x271D3A1 VA: 0x271D2A0
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetClrNames
	|
	|-RVA: 0x271DE80 Offset: 0x271DF81 VA: 0x271DE80
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetClrNames
	|
	|-RVA: 0x271E960 Offset: 0x271EA61 VA: 0x271E960
	|-EnumAsStringFormatter<Nullable<Color32>>.GetClrNames
	|
	|-RVA: 0x271F4F0 Offset: 0x271F5F1 VA: 0x271F4F0
	|-EnumAsStringFormatter<Nullable<Color>>.GetClrNames
	|
	|-RVA: 0x2720020 Offset: 0x2720121 VA: 0x2720020
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetClrNames
	|
	|-RVA: 0x2720BB0 Offset: 0x2720CB1 VA: 0x2720BB0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetClrNames
	|
	|-RVA: 0x2721730 Offset: 0x2721831 VA: 0x2721730
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetClrNames
	|
	|-RVA: 0x2722210 Offset: 0x2722311 VA: 0x2722210
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetClrNames
	|
	|-RVA: 0x2722EE0 Offset: 0x2722FE1 VA: 0x2722EE0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetClrNames
	|
	|-RVA: 0x2723A70 Offset: 0x2723B71 VA: 0x2723A70
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetClrNames
	|
	|-RVA: 0x27245A0 Offset: 0x27246A1 VA: 0x27245A0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetClrNames
	|
	|-RVA: 0x2725130 Offset: 0x2725231 VA: 0x2725130
	|-EnumAsStringFormatter<Nullable<Rect>>.GetClrNames
	|
	|-RVA: 0x27C9190 Offset: 0x27C9291 VA: 0x27C9190
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetClrNames
	|
	|-RVA: 0x27C9CC0 Offset: 0x27C9DC1 VA: 0x27C9CC0
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetClrNames
	|
	|-RVA: 0x27CA7F0 Offset: 0x27CA8F1 VA: 0x27CA7F0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetClrNames
	|
	|-RVA: 0x27CB2F0 Offset: 0x27CB3F1 VA: 0x27CB2F0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetClrNames
	|
	|-RVA: 0x27CBDF0 Offset: 0x27CBEF1 VA: 0x27CBDF0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetClrNames
	|
	|-RVA: 0x27CC980 Offset: 0x27CCA81 VA: 0x27CC980
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetClrNames
	|
	|-RVA: 0x27CD460 Offset: 0x27CD561 VA: 0x27CD460
	|-EnumAsStringFormatter<object>.GetClrNames
	|
	|-RVA: 0x27CDF70 Offset: 0x27CE071 VA: 0x27CDF70
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetClrNames
	|
	|-RVA: 0x27CEA60 Offset: 0x27CEB61 VA: 0x27CEA60
	|-EnumAsStringFormatter<sbyte>.GetClrNames
	|
	|-RVA: 0x27CF570 Offset: 0x27CF671 VA: 0x27CF570
	|-EnumAsStringFormatter<float>.GetClrNames
	|
	|-RVA: 0x27D0060 Offset: 0x27D0161 VA: 0x27D0060
	|-EnumAsStringFormatter<ushort>.GetClrNames
	|
	|-RVA: 0x27D0B50 Offset: 0x27D0C51 VA: 0x27D0B50
	|-EnumAsStringFormatter<uint>.GetClrNames
	|
	|-RVA: 0x27D1630 Offset: 0x27D1731 VA: 0x27D1630
	|-EnumAsStringFormatter<ulong>.GetClrNames
	|
	|-RVA: 0x27D21D0 Offset: 0x27D22D1 VA: 0x27D21D0
	|-EnumAsStringFormatter<Bounds>.GetClrNames
	|
	|-RVA: 0x27D2D70 Offset: 0x27D2E71 VA: 0x27D2D70
	|-EnumAsStringFormatter<BoundsInt>.GetClrNames
	|
	|-RVA: 0x27D3860 Offset: 0x27D3961 VA: 0x27D3860
	|-EnumAsStringFormatter<Color32>.GetClrNames
	|
	|-RVA: 0x27D43B0 Offset: 0x27D44B1 VA: 0x27D43B0
	|-EnumAsStringFormatter<Color>.GetClrNames
	|
	|-RVA: 0x27D4F20 Offset: 0x27D5021 VA: 0x27D4F20
	|-EnumAsStringFormatter<GradientAlphaKey>.GetClrNames
	|
	|-RVA: 0x27D5B10 Offset: 0x27D5C11 VA: 0x27D5B10
	|-EnumAsStringFormatter<GradientColorKey>.GetClrNames
	|
	|-RVA: 0x27D6750 Offset: 0x27D6851 VA: 0x27D6750
	|-EnumAsStringFormatter<Keyframe>.GetClrNames
	|
	|-RVA: 0x27D7280 Offset: 0x27D7381 VA: 0x27D7280
	|-EnumAsStringFormatter<LayerMask>.GetClrNames
	|
	|-RVA: 0x27D7EC0 Offset: 0x27D7FC1 VA: 0x27D7EC0
	|-EnumAsStringFormatter<Matrix4x4>.GetClrNames
	|
	|-RVA: 0x27D8A10 Offset: 0x27D8B11 VA: 0x27D8A10
	|-EnumAsStringFormatter<Quaternion>.GetClrNames
	|
	|-RVA: 0x27D9540 Offset: 0x27D9641 VA: 0x27D9540
	|-EnumAsStringFormatter<RangeInt>.GetClrNames
	|
	|-RVA: 0x27DA090 Offset: 0x27DA191 VA: 0x27DA090
	|-EnumAsStringFormatter<Rect>.GetClrNames
	|
	|-RVA: 0x27DAB80 Offset: 0x27DAC81 VA: 0x27DAB80
	|-EnumAsStringFormatter<RectInt>.GetClrNames
	|
	|-RVA: 0x27DB6B0 Offset: 0x27DB7B1 VA: 0x27DB6B0
	|-EnumAsStringFormatter<Vector2>.GetClrNames
	|
	|-RVA: 0x27DC190 Offset: 0x27DC291 VA: 0x27DC190
	|-EnumAsStringFormatter<Vector2Int>.GetClrNames
	|
	|-RVA: 0x27DCCE0 Offset: 0x27DCDE1 VA: 0x27DCCE0
	|-EnumAsStringFormatter<Vector3>.GetClrNames
	|
	|-RVA: 0x27DD800 Offset: 0x27DD901 VA: 0x27DD800
	|-EnumAsStringFormatter<Vector3Int>.GetClrNames
	|
	|-RVA: 0x27DE350 Offset: 0x27DE451 VA: 0x27DE350
	|-EnumAsStringFormatter<Vector4>.GetClrNames
	*/

	// RVA: -1 Offset: -1
	private string GetSerializedNames(string clrNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D770 Offset: 0x270D871 VA: 0x270D770
	|-EnumAsStringFormatter<BitVector32Int>.GetSerializedNames
	|
	|-RVA: 0x270E360 Offset: 0x270E461 VA: 0x270E360
	|-EnumAsStringFormatter<EventCheckId>.GetSerializedNames
	|
	|-RVA: 0x270F010 Offset: 0x270F111 VA: 0x270F010
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetSerializedNames
	|
	|-RVA: 0x270FC00 Offset: 0x270FD01 VA: 0x270FC00
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetSerializedNames
	|
	|-RVA: 0x2710770 Offset: 0x2710871 VA: 0x2710770
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetSerializedNames
	|
	|-RVA: 0x27112A0 Offset: 0x27113A1 VA: 0x27112A0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetSerializedNames
	|
	|-RVA: 0x2711EE0 Offset: 0x2711FE1 VA: 0x2711EE0
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetSerializedNames
	|
	|-RVA: 0x2712A50 Offset: 0x2712B51 VA: 0x2712A50
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2713690 Offset: 0x2713791 VA: 0x2713690
	|-EnumAsStringFormatter<OrderSaveData>.GetSerializedNames
	|
	|-RVA: 0x2714280 Offset: 0x2714381 VA: 0x2714280
	|-EnumAsStringFormatter<OrderSaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2714EF0 Offset: 0x2714FF1 VA: 0x2714EF0
	|-EnumAsStringFormatter<Parameter>.GetSerializedNames
	|
	|-RVA: 0x27159F0 Offset: 0x2715AF1 VA: 0x27159F0
	|-EnumAsStringFormatter<bool>.GetSerializedNames
	|
	|-RVA: 0x27164E0 Offset: 0x27165E1 VA: 0x27164E0
	|-EnumAsStringFormatter<byte>.GetSerializedNames
	|
	|-RVA: 0x2716FD0 Offset: 0x27170D1 VA: 0x2716FD0
	|-EnumAsStringFormatter<char>.GetSerializedNames
	|
	|-RVA: 0x2717AB0 Offset: 0x2717BB1 VA: 0x2717AB0
	|-EnumAsStringFormatter<DateTime>.GetSerializedNames
	|
	|-RVA: 0x27185C0 Offset: 0x27186C1 VA: 0x27185C0
	|-EnumAsStringFormatter<double>.GetSerializedNames
	|
	|-RVA: 0x27190B0 Offset: 0x27191B1 VA: 0x27190B0
	|-EnumAsStringFormatter<short>.GetSerializedNames
	|
	|-RVA: 0x2719BA0 Offset: 0x2719CA1 VA: 0x2719BA0
	|-EnumAsStringFormatter<int>.GetSerializedNames
	|
	|-RVA: 0x271A6B0 Offset: 0x271A7B1 VA: 0x271A6B0
	|-EnumAsStringFormatter<Int32Enum>.GetSerializedNames
	|
	|-RVA: 0x271B190 Offset: 0x271B291 VA: 0x271B190
	|-EnumAsStringFormatter<long>.GetSerializedNames
	|
	|-RVA: 0x271BCA0 Offset: 0x271BDA1 VA: 0x271BCA0
	|-EnumAsStringFormatter<Memory<object>>.GetSerializedNames
	|
	|-RVA: 0x271C780 Offset: 0x271C881 VA: 0x271C780
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetSerializedNames
	|
	|-RVA: 0x271D360 Offset: 0x271D461 VA: 0x271D360
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetSerializedNames
	|
	|-RVA: 0x271DF40 Offset: 0x271E041 VA: 0x271DF40
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetSerializedNames
	|
	|-RVA: 0x271EA20 Offset: 0x271EB21 VA: 0x271EA20
	|-EnumAsStringFormatter<Nullable<Color32>>.GetSerializedNames
	|
	|-RVA: 0x271F5B0 Offset: 0x271F6B1 VA: 0x271F5B0
	|-EnumAsStringFormatter<Nullable<Color>>.GetSerializedNames
	|
	|-RVA: 0x27200E0 Offset: 0x27201E1 VA: 0x27200E0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetSerializedNames
	|
	|-RVA: 0x2720C70 Offset: 0x2720D71 VA: 0x2720C70
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetSerializedNames
	|
	|-RVA: 0x27217F0 Offset: 0x27218F1 VA: 0x27217F0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetSerializedNames
	|
	|-RVA: 0x27222D0 Offset: 0x27223D1 VA: 0x27222D0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetSerializedNames
	|
	|-RVA: 0x2722FA0 Offset: 0x27230A1 VA: 0x2722FA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetSerializedNames
	|
	|-RVA: 0x2723B30 Offset: 0x2723C31 VA: 0x2723B30
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetSerializedNames
	|
	|-RVA: 0x2724660 Offset: 0x2724761 VA: 0x2724660
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetSerializedNames
	|
	|-RVA: 0x27251F0 Offset: 0x27252F1 VA: 0x27251F0
	|-EnumAsStringFormatter<Nullable<Rect>>.GetSerializedNames
	|
	|-RVA: 0x27C9250 Offset: 0x27C9351 VA: 0x27C9250
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetSerializedNames
	|
	|-RVA: 0x27C9D80 Offset: 0x27C9E81 VA: 0x27C9D80
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetSerializedNames
	|
	|-RVA: 0x27CA8B0 Offset: 0x27CA9B1 VA: 0x27CA8B0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetSerializedNames
	|
	|-RVA: 0x27CB3B0 Offset: 0x27CB4B1 VA: 0x27CB3B0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetSerializedNames
	|
	|-RVA: 0x27CBEB0 Offset: 0x27CBFB1 VA: 0x27CBEB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetSerializedNames
	|
	|-RVA: 0x27CCA40 Offset: 0x27CCB41 VA: 0x27CCA40
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetSerializedNames
	|
	|-RVA: 0x27CD520 Offset: 0x27CD621 VA: 0x27CD520
	|-EnumAsStringFormatter<object>.GetSerializedNames
	|
	|-RVA: 0x27CE030 Offset: 0x27CE131 VA: 0x27CE030
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetSerializedNames
	|
	|-RVA: 0x27CEB20 Offset: 0x27CEC21 VA: 0x27CEB20
	|-EnumAsStringFormatter<sbyte>.GetSerializedNames
	|
	|-RVA: 0x27CF630 Offset: 0x27CF731 VA: 0x27CF630
	|-EnumAsStringFormatter<float>.GetSerializedNames
	|
	|-RVA: 0x27D0120 Offset: 0x27D0221 VA: 0x27D0120
	|-EnumAsStringFormatter<ushort>.GetSerializedNames
	|
	|-RVA: 0x27D0C10 Offset: 0x27D0D11 VA: 0x27D0C10
	|-EnumAsStringFormatter<uint>.GetSerializedNames
	|
	|-RVA: 0x27D16F0 Offset: 0x27D17F1 VA: 0x27D16F0
	|-EnumAsStringFormatter<ulong>.GetSerializedNames
	|
	|-RVA: 0x27D2290 Offset: 0x27D2391 VA: 0x27D2290
	|-EnumAsStringFormatter<Bounds>.GetSerializedNames
	|
	|-RVA: 0x27D2E30 Offset: 0x27D2F31 VA: 0x27D2E30
	|-EnumAsStringFormatter<BoundsInt>.GetSerializedNames
	|
	|-RVA: 0x27D3920 Offset: 0x27D3A21 VA: 0x27D3920
	|-EnumAsStringFormatter<Color32>.GetSerializedNames
	|
	|-RVA: 0x27D4470 Offset: 0x27D4571 VA: 0x27D4470
	|-EnumAsStringFormatter<Color>.GetSerializedNames
	|
	|-RVA: 0x27D4FE0 Offset: 0x27D50E1 VA: 0x27D4FE0
	|-EnumAsStringFormatter<GradientAlphaKey>.GetSerializedNames
	|
	|-RVA: 0x27D5BD0 Offset: 0x27D5CD1 VA: 0x27D5BD0
	|-EnumAsStringFormatter<GradientColorKey>.GetSerializedNames
	|
	|-RVA: 0x27D6810 Offset: 0x27D6911 VA: 0x27D6810
	|-EnumAsStringFormatter<Keyframe>.GetSerializedNames
	|
	|-RVA: 0x27D7340 Offset: 0x27D7441 VA: 0x27D7340
	|-EnumAsStringFormatter<LayerMask>.GetSerializedNames
	|
	|-RVA: 0x27D7F80 Offset: 0x27D8081 VA: 0x27D7F80
	|-EnumAsStringFormatter<Matrix4x4>.GetSerializedNames
	|
	|-RVA: 0x27D8AD0 Offset: 0x27D8BD1 VA: 0x27D8AD0
	|-EnumAsStringFormatter<Quaternion>.GetSerializedNames
	|
	|-RVA: 0x27D9600 Offset: 0x27D9701 VA: 0x27D9600
	|-EnumAsStringFormatter<RangeInt>.GetSerializedNames
	|
	|-RVA: 0x27DA150 Offset: 0x27DA251 VA: 0x27DA150
	|-EnumAsStringFormatter<Rect>.GetSerializedNames
	|
	|-RVA: 0x27DAC40 Offset: 0x27DAD41 VA: 0x27DAC40
	|-EnumAsStringFormatter<RectInt>.GetSerializedNames
	|
	|-RVA: 0x27DB770 Offset: 0x27DB871 VA: 0x27DB770
	|-EnumAsStringFormatter<Vector2>.GetSerializedNames
	|
	|-RVA: 0x27DC250 Offset: 0x27DC351 VA: 0x27DC250
	|-EnumAsStringFormatter<Vector2Int>.GetSerializedNames
	|
	|-RVA: 0x27DCDA0 Offset: 0x27DCEA1 VA: 0x27DCDA0
	|-EnumAsStringFormatter<Vector3>.GetSerializedNames
	|
	|-RVA: 0x27DD8C0 Offset: 0x27DD9C1 VA: 0x27DD8C0
	|-EnumAsStringFormatter<Vector3Int>.GetSerializedNames
	|
	|-RVA: 0x27DE410 Offset: 0x27DE511 VA: 0x27DE410
	|-EnumAsStringFormatter<Vector4>.GetSerializedNames
	*/

	// RVA: -1 Offset: -1
	private static string Translate(string items, IReadOnlyDictionary<string, string> mapping) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D830 Offset: 0x270D931 VA: 0x270D830
	|-EnumAsStringFormatter<BitVector32Int>.Translate
	|
	|-RVA: 0x270E420 Offset: 0x270E521 VA: 0x270E420
	|-EnumAsStringFormatter<EventCheckId>.Translate
	|
	|-RVA: 0x270F0D0 Offset: 0x270F1D1 VA: 0x270F0D0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Translate
	|
	|-RVA: 0x270FCC0 Offset: 0x270FDC1 VA: 0x270FCC0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Translate
	|
	|-RVA: 0x2710830 Offset: 0x2710931 VA: 0x2710830
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Translate
	|
	|-RVA: 0x2711360 Offset: 0x2711461 VA: 0x2711360
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Translate
	|
	|-RVA: 0x2711FA0 Offset: 0x27120A1 VA: 0x2711FA0
	|-EnumAsStringFormatter<MonsterHutSaveData>.Translate
	|
	|-RVA: 0x2712B10 Offset: 0x2712C11 VA: 0x2712B10
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Translate
	|
	|-RVA: 0x2713750 Offset: 0x2713851 VA: 0x2713750
	|-EnumAsStringFormatter<OrderSaveData>.Translate
	|
	|-RVA: 0x2714340 Offset: 0x2714441 VA: 0x2714340
	|-EnumAsStringFormatter<OrderSaveParameter>.Translate
	|
	|-RVA: 0x2714FB0 Offset: 0x27150B1 VA: 0x2714FB0
	|-EnumAsStringFormatter<Parameter>.Translate
	|
	|-RVA: 0x2715AB0 Offset: 0x2715BB1 VA: 0x2715AB0
	|-EnumAsStringFormatter<bool>.Translate
	|
	|-RVA: 0x27165A0 Offset: 0x27166A1 VA: 0x27165A0
	|-EnumAsStringFormatter<byte>.Translate
	|
	|-RVA: 0x2717090 Offset: 0x2717191 VA: 0x2717090
	|-EnumAsStringFormatter<char>.Translate
	|
	|-RVA: 0x2717B70 Offset: 0x2717C71 VA: 0x2717B70
	|-EnumAsStringFormatter<DateTime>.Translate
	|
	|-RVA: 0x2718680 Offset: 0x2718781 VA: 0x2718680
	|-EnumAsStringFormatter<double>.Translate
	|
	|-RVA: 0x2719170 Offset: 0x2719271 VA: 0x2719170
	|-EnumAsStringFormatter<short>.Translate
	|
	|-RVA: 0x2719C60 Offset: 0x2719D61 VA: 0x2719C60
	|-EnumAsStringFormatter<int>.Translate
	|
	|-RVA: 0x271A770 Offset: 0x271A871 VA: 0x271A770
	|-EnumAsStringFormatter<Int32Enum>.Translate
	|
	|-RVA: 0x271B250 Offset: 0x271B351 VA: 0x271B250
	|-EnumAsStringFormatter<long>.Translate
	|
	|-RVA: 0x271BD60 Offset: 0x271BE61 VA: 0x271BD60
	|-EnumAsStringFormatter<Memory<object>>.Translate
	|
	|-RVA: 0x271C840 Offset: 0x271C941 VA: 0x271C840
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Translate
	|
	|-RVA: 0x271D420 Offset: 0x271D521 VA: 0x271D420
	|-EnumAsStringFormatter<Nullable<Bounds>>.Translate
	|
	|-RVA: 0x271E000 Offset: 0x271E101 VA: 0x271E000
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Translate
	|
	|-RVA: 0x271EAE0 Offset: 0x271EBE1 VA: 0x271EAE0
	|-EnumAsStringFormatter<Nullable<Color32>>.Translate
	|
	|-RVA: 0x271F670 Offset: 0x271F771 VA: 0x271F670
	|-EnumAsStringFormatter<Nullable<Color>>.Translate
	|
	|-RVA: 0x27201A0 Offset: 0x27202A1 VA: 0x27201A0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Translate
	|
	|-RVA: 0x2720D30 Offset: 0x2720E31 VA: 0x2720D30
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Translate
	|
	|-RVA: 0x27218B0 Offset: 0x27219B1 VA: 0x27218B0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Translate
	|
	|-RVA: 0x2722390 Offset: 0x2722491 VA: 0x2722390
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Translate
	|
	|-RVA: 0x2723060 Offset: 0x2723161 VA: 0x2723060
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Translate
	|
	|-RVA: 0x2723BF0 Offset: 0x2723CF1 VA: 0x2723BF0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Translate
	|
	|-RVA: 0x2724720 Offset: 0x2724821 VA: 0x2724720
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Translate
	|
	|-RVA: 0x27252B0 Offset: 0x27253B1 VA: 0x27252B0
	|-EnumAsStringFormatter<Nullable<Rect>>.Translate
	|
	|-RVA: 0x27C9310 Offset: 0x27C9411 VA: 0x27C9310
	|-EnumAsStringFormatter<Nullable<RectInt>>.Translate
	|
	|-RVA: 0x27C9E40 Offset: 0x27C9F41 VA: 0x27C9E40
	|-EnumAsStringFormatter<Nullable<Vector2>>.Translate
	|
	|-RVA: 0x27CA970 Offset: 0x27CAA71 VA: 0x27CA970
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Translate
	|
	|-RVA: 0x27CB470 Offset: 0x27CB571 VA: 0x27CB470
	|-EnumAsStringFormatter<Nullable<Vector3>>.Translate
	|
	|-RVA: 0x27CBF70 Offset: 0x27CC071 VA: 0x27CBF70
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Translate
	|
	|-RVA: 0x27CCB00 Offset: 0x27CCC01 VA: 0x27CCB00
	|-EnumAsStringFormatter<Nullable<Vector4>>.Translate
	|
	|-RVA: 0x27CD5E0 Offset: 0x27CD6E1 VA: 0x27CD5E0
	|-EnumAsStringFormatter<object>.Translate
	|
	|-RVA: 0x27CE0F0 Offset: 0x27CE1F1 VA: 0x27CE0F0
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Translate
	|
	|-RVA: 0x27CEBE0 Offset: 0x27CECE1 VA: 0x27CEBE0
	|-EnumAsStringFormatter<sbyte>.Translate
	|
	|-RVA: 0x27CF6F0 Offset: 0x27CF7F1 VA: 0x27CF6F0
	|-EnumAsStringFormatter<float>.Translate
	|
	|-RVA: 0x27D01E0 Offset: 0x27D02E1 VA: 0x27D01E0
	|-EnumAsStringFormatter<ushort>.Translate
	|
	|-RVA: 0x27D0CD0 Offset: 0x27D0DD1 VA: 0x27D0CD0
	|-EnumAsStringFormatter<uint>.Translate
	|
	|-RVA: 0x27D17B0 Offset: 0x27D18B1 VA: 0x27D17B0
	|-EnumAsStringFormatter<ulong>.Translate
	|
	|-RVA: 0x27D2350 Offset: 0x27D2451 VA: 0x27D2350
	|-EnumAsStringFormatter<Bounds>.Translate
	|
	|-RVA: 0x27D2EF0 Offset: 0x27D2FF1 VA: 0x27D2EF0
	|-EnumAsStringFormatter<BoundsInt>.Translate
	|
	|-RVA: 0x27D39E0 Offset: 0x27D3AE1 VA: 0x27D39E0
	|-EnumAsStringFormatter<Color32>.Translate
	|
	|-RVA: 0x27D4530 Offset: 0x27D4631 VA: 0x27D4530
	|-EnumAsStringFormatter<Color>.Translate
	|
	|-RVA: 0x27D50A0 Offset: 0x27D51A1 VA: 0x27D50A0
	|-EnumAsStringFormatter<GradientAlphaKey>.Translate
	|
	|-RVA: 0x27D5C90 Offset: 0x27D5D91 VA: 0x27D5C90
	|-EnumAsStringFormatter<GradientColorKey>.Translate
	|
	|-RVA: 0x27D68D0 Offset: 0x27D69D1 VA: 0x27D68D0
	|-EnumAsStringFormatter<Keyframe>.Translate
	|
	|-RVA: 0x27D7400 Offset: 0x27D7501 VA: 0x27D7400
	|-EnumAsStringFormatter<LayerMask>.Translate
	|
	|-RVA: 0x27D8040 Offset: 0x27D8141 VA: 0x27D8040
	|-EnumAsStringFormatter<Matrix4x4>.Translate
	|
	|-RVA: 0x27D8B90 Offset: 0x27D8C91 VA: 0x27D8B90
	|-EnumAsStringFormatter<Quaternion>.Translate
	|
	|-RVA: 0x27D96C0 Offset: 0x27D97C1 VA: 0x27D96C0
	|-EnumAsStringFormatter<RangeInt>.Translate
	|
	|-RVA: 0x27DA210 Offset: 0x27DA311 VA: 0x27DA210
	|-EnumAsStringFormatter<Rect>.Translate
	|
	|-RVA: 0x27DAD00 Offset: 0x27DAE01 VA: 0x27DAD00
	|-EnumAsStringFormatter<RectInt>.Translate
	|
	|-RVA: 0x27DB830 Offset: 0x27DB931 VA: 0x27DB830
	|-EnumAsStringFormatter<Vector2>.Translate
	|
	|-RVA: 0x27DC310 Offset: 0x27DC411 VA: 0x27DC310
	|-EnumAsStringFormatter<Vector2Int>.Translate
	|
	|-RVA: 0x27DCE60 Offset: 0x27DCF61 VA: 0x27DCE60
	|-EnumAsStringFormatter<Vector3>.Translate
	|
	|-RVA: 0x27DD980 Offset: 0x27DDA81 VA: 0x27DD980
	|-EnumAsStringFormatter<Vector3Int>.Translate
	|
	|-RVA: 0x27DE4D0 Offset: 0x27DE5D1 VA: 0x27DE4D0
	|-EnumAsStringFormatter<Vector4>.Translate
	*/
}

public sealed class EnumAsStringFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter // TypeDefIndex: 5404
{
	// Fields
	private readonly IReadOnlyDictionary<string, T> nameValueMapping; // 0x0
	private readonly IReadOnlyDictionary<T, string> valueNameMapping; // 0x0
	private readonly IReadOnlyDictionary<string, string> clrToSerializationName; // 0x0
	private readonly IReadOnlyDictionary<string, string> serializationToClrName; // 0x0
	private readonly bool enumMemberOverridesPresent; // 0x0
	private readonly bool isFlags; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CFA0 Offset: 0x270D0A1 VA: 0x270CFA0
	|-EnumAsStringFormatter<BitVector32Int>..ctor
	|
	|-RVA: 0x270DA90 Offset: 0x270DB91 VA: 0x270DA90
	|-EnumAsStringFormatter<EventCheckId>..ctor
	|
	|-RVA: 0x270E680 Offset: 0x270E781 VA: 0x270E680
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x270F330 Offset: 0x270F431 VA: 0x270F330
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x270FF20 Offset: 0x2710021 VA: 0x270FF20
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2710A90 Offset: 0x2710B91 VA: 0x2710A90
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x27115C0 Offset: 0x27116C1 VA: 0x27115C0
	|-EnumAsStringFormatter<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2712200 Offset: 0x2712301 VA: 0x2712200
	|-EnumAsStringFormatter<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2712D70 Offset: 0x2712E71 VA: 0x2712D70
	|-EnumAsStringFormatter<OrderSaveData>..ctor
	|
	|-RVA: 0x27139B0 Offset: 0x2713AB1 VA: 0x27139B0
	|-EnumAsStringFormatter<OrderSaveParameter>..ctor
	|
	|-RVA: 0x27145A0 Offset: 0x27146A1 VA: 0x27145A0
	|-EnumAsStringFormatter<Parameter>..ctor
	|
	|-RVA: 0x2715210 Offset: 0x2715311 VA: 0x2715210
	|-EnumAsStringFormatter<bool>..ctor
	|
	|-RVA: 0x2715D10 Offset: 0x2715E11 VA: 0x2715D10
	|-EnumAsStringFormatter<byte>..ctor
	|
	|-RVA: 0x2716800 Offset: 0x2716901 VA: 0x2716800
	|-EnumAsStringFormatter<char>..ctor
	|
	|-RVA: 0x27172F0 Offset: 0x27173F1 VA: 0x27172F0
	|-EnumAsStringFormatter<DateTime>..ctor
	|
	|-RVA: 0x2717DD0 Offset: 0x2717ED1 VA: 0x2717DD0
	|-EnumAsStringFormatter<double>..ctor
	|
	|-RVA: 0x27188E0 Offset: 0x27189E1 VA: 0x27188E0
	|-EnumAsStringFormatter<short>..ctor
	|
	|-RVA: 0x27193D0 Offset: 0x27194D1 VA: 0x27193D0
	|-EnumAsStringFormatter<int>..ctor
	|
	|-RVA: 0x2719EC0 Offset: 0x2719FC1 VA: 0x2719EC0
	|-EnumAsStringFormatter<Int32Enum>..ctor
	|
	|-RVA: 0x271A9D0 Offset: 0x271AAD1 VA: 0x271A9D0
	|-EnumAsStringFormatter<long>..ctor
	|
	|-RVA: 0x271B4B0 Offset: 0x271B5B1 VA: 0x271B4B0
	|-EnumAsStringFormatter<Memory<object>>..ctor
	|
	|-RVA: 0x271BFC0 Offset: 0x271C0C1 VA: 0x271BFC0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x271CAA0 Offset: 0x271CBA1 VA: 0x271CAA0
	|-EnumAsStringFormatter<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x271D680 Offset: 0x271D781 VA: 0x271D680
	|-EnumAsStringFormatter<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x271E260 Offset: 0x271E361 VA: 0x271E260
	|-EnumAsStringFormatter<Nullable<Color32>>..ctor
	|
	|-RVA: 0x271ED40 Offset: 0x271EE41 VA: 0x271ED40
	|-EnumAsStringFormatter<Nullable<Color>>..ctor
	|
	|-RVA: 0x271F8D0 Offset: 0x271F9D1 VA: 0x271F8D0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2720400 Offset: 0x2720501 VA: 0x2720400
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2720F90 Offset: 0x2721091 VA: 0x2720F90
	|-EnumAsStringFormatter<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2721B10 Offset: 0x2721C11 VA: 0x2721B10
	|-EnumAsStringFormatter<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x27225F0 Offset: 0x27226F1 VA: 0x27225F0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x27232C0 Offset: 0x27233C1 VA: 0x27232C0
	|-EnumAsStringFormatter<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2723E50 Offset: 0x2723F51 VA: 0x2723E50
	|-EnumAsStringFormatter<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2724980 Offset: 0x2724A81 VA: 0x2724980
	|-EnumAsStringFormatter<Nullable<Rect>>..ctor
	|
	|-RVA: 0x27C89E0 Offset: 0x27C8AE1 VA: 0x27C89E0
	|-EnumAsStringFormatter<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x27C9570 Offset: 0x27C9671 VA: 0x27C9570
	|-EnumAsStringFormatter<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x27CA0A0 Offset: 0x27CA1A1 VA: 0x27CA0A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x27CABD0 Offset: 0x27CACD1 VA: 0x27CABD0
	|-EnumAsStringFormatter<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x27CB6D0 Offset: 0x27CB7D1 VA: 0x27CB6D0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x27CC1D0 Offset: 0x27CC2D1 VA: 0x27CC1D0
	|-EnumAsStringFormatter<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x27CCD60 Offset: 0x27CCE61 VA: 0x27CCD60
	|-EnumAsStringFormatter<object>..ctor
	|
	|-RVA: 0x27CD840 Offset: 0x27CD941 VA: 0x27CD840
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x27CE350 Offset: 0x27CE451 VA: 0x27CE350
	|-EnumAsStringFormatter<sbyte>..ctor
	|
	|-RVA: 0x27CEE40 Offset: 0x27CEF41 VA: 0x27CEE40
	|-EnumAsStringFormatter<float>..ctor
	|
	|-RVA: 0x27CF950 Offset: 0x27CFA51 VA: 0x27CF950
	|-EnumAsStringFormatter<ushort>..ctor
	|
	|-RVA: 0x27D0440 Offset: 0x27D0541 VA: 0x27D0440
	|-EnumAsStringFormatter<uint>..ctor
	|
	|-RVA: 0x27D0F30 Offset: 0x27D1031 VA: 0x27D0F30
	|-EnumAsStringFormatter<ulong>..ctor
	|
	|-RVA: 0x27D1A10 Offset: 0x27D1B11 VA: 0x27D1A10
	|-EnumAsStringFormatter<Bounds>..ctor
	|
	|-RVA: 0x27D25B0 Offset: 0x27D26B1 VA: 0x27D25B0
	|-EnumAsStringFormatter<BoundsInt>..ctor
	|
	|-RVA: 0x27D3150 Offset: 0x27D3251 VA: 0x27D3150
	|-EnumAsStringFormatter<Color32>..ctor
	|
	|-RVA: 0x27D3C40 Offset: 0x27D3D41 VA: 0x27D3C40
	|-EnumAsStringFormatter<Color>..ctor
	|
	|-RVA: 0x27D4790 Offset: 0x27D4891 VA: 0x27D4790
	|-EnumAsStringFormatter<GradientAlphaKey>..ctor
	|
	|-RVA: 0x27D5300 Offset: 0x27D5401 VA: 0x27D5300
	|-EnumAsStringFormatter<GradientColorKey>..ctor
	|
	|-RVA: 0x27D5EF0 Offset: 0x27D5FF1 VA: 0x27D5EF0
	|-EnumAsStringFormatter<Keyframe>..ctor
	|
	|-RVA: 0x27D6B30 Offset: 0x27D6C31 VA: 0x27D6B30
	|-EnumAsStringFormatter<LayerMask>..ctor
	|
	|-RVA: 0x27D7660 Offset: 0x27D7761 VA: 0x27D7660
	|-EnumAsStringFormatter<Matrix4x4>..ctor
	|
	|-RVA: 0x27D82A0 Offset: 0x27D83A1 VA: 0x27D82A0
	|-EnumAsStringFormatter<Quaternion>..ctor
	|
	|-RVA: 0x27D8DF0 Offset: 0x27D8EF1 VA: 0x27D8DF0
	|-EnumAsStringFormatter<RangeInt>..ctor
	|
	|-RVA: 0x27D9920 Offset: 0x27D9A21 VA: 0x27D9920
	|-EnumAsStringFormatter<Rect>..ctor
	|
	|-RVA: 0x27DA470 Offset: 0x27DA571 VA: 0x27DA470
	|-EnumAsStringFormatter<RectInt>..ctor
	|
	|-RVA: 0x27DAF60 Offset: 0x27DB061 VA: 0x27DAF60
	|-EnumAsStringFormatter<Vector2>..ctor
	|
	|-RVA: 0x27DBA90 Offset: 0x27DBB91 VA: 0x27DBA90
	|-EnumAsStringFormatter<Vector2Int>..ctor
	|
	|-RVA: 0x27DC570 Offset: 0x27DC671 VA: 0x27DC570
	|-EnumAsStringFormatter<Vector3>..ctor
	|
	|-RVA: 0x27DD0C0 Offset: 0x27DD1C1 VA: 0x27DD0C0
	|-EnumAsStringFormatter<Vector3Int>..ctor
	|
	|-RVA: 0x27DDBE0 Offset: 0x27DDCE1 VA: 0x27DDBE0
	|-EnumAsStringFormatter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D390 Offset: 0x270D491 VA: 0x270D390
	|-EnumAsStringFormatter<BitVector32Int>.Serialize
	|
	|-RVA: 0x270DEF0 Offset: 0x270DFF1 VA: 0x270DEF0
	|-EnumAsStringFormatter<EventCheckId>.Serialize
	|
	|-RVA: 0x270EB40 Offset: 0x270EC41 VA: 0x270EB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Serialize
	|
	|-RVA: 0x270F790 Offset: 0x270F891 VA: 0x270F790
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Serialize
	|
	|-RVA: 0x2710320 Offset: 0x2710421 VA: 0x2710320
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Serialize
	|
	|-RVA: 0x2710E70 Offset: 0x2710F71 VA: 0x2710E70
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Serialize
	|
	|-RVA: 0x2711A40 Offset: 0x2711B41 VA: 0x2711A40
	|-EnumAsStringFormatter<MonsterHutSaveData>.Serialize
	|
	|-RVA: 0x2712600 Offset: 0x2712701 VA: 0x2712600
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Serialize
	|
	|-RVA: 0x27131F0 Offset: 0x27132F1 VA: 0x27131F0
	|-EnumAsStringFormatter<OrderSaveData>.Serialize
	|
	|-RVA: 0x2713E10 Offset: 0x2713F11 VA: 0x2713E10
	|-EnumAsStringFormatter<OrderSaveParameter>.Serialize
	|
	|-RVA: 0x2714A40 Offset: 0x2714B41 VA: 0x2714A40
	|-EnumAsStringFormatter<Parameter>.Serialize
	|
	|-RVA: 0x2715610 Offset: 0x2715711 VA: 0x2715610
	|-EnumAsStringFormatter<bool>.Serialize
	|
	|-RVA: 0x2716100 Offset: 0x2716201 VA: 0x2716100
	|-EnumAsStringFormatter<byte>.Serialize
	|
	|-RVA: 0x2716BF0 Offset: 0x2716CF1 VA: 0x2716BF0
	|-EnumAsStringFormatter<char>.Serialize
	|
	|-RVA: 0x27176E0 Offset: 0x27177E1 VA: 0x27176E0
	|-EnumAsStringFormatter<DateTime>.Serialize
	|
	|-RVA: 0x27181E0 Offset: 0x27182E1 VA: 0x27181E0
	|-EnumAsStringFormatter<double>.Serialize
	|
	|-RVA: 0x2718CD0 Offset: 0x2718DD1 VA: 0x2718CD0
	|-EnumAsStringFormatter<short>.Serialize
	|
	|-RVA: 0x27197C0 Offset: 0x27198C1 VA: 0x27197C0
	|-EnumAsStringFormatter<int>.Serialize
	|
	|-RVA: 0x271A2B0 Offset: 0x271A3B1 VA: 0x271A2B0
	|-EnumAsStringFormatter<Int32Enum>.Serialize
	|
	|-RVA: 0x271ADC0 Offset: 0x271AEC1 VA: 0x271ADC0
	|-EnumAsStringFormatter<long>.Serialize
	|
	|-RVA: 0x271B890 Offset: 0x271B991 VA: 0x271B890
	|-EnumAsStringFormatter<Memory<object>>.Serialize
	|
	|-RVA: 0x271C390 Offset: 0x271C491 VA: 0x271C390
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Serialize
	|
	|-RVA: 0x271CED0 Offset: 0x271CFD1 VA: 0x271CED0
	|-EnumAsStringFormatter<Nullable<Bounds>>.Serialize
	|
	|-RVA: 0x271DAB0 Offset: 0x271DBB1 VA: 0x271DAB0
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Serialize
	|
	|-RVA: 0x271E630 Offset: 0x271E731 VA: 0x271E630
	|-EnumAsStringFormatter<Nullable<Color32>>.Serialize
	|
	|-RVA: 0x271F150 Offset: 0x271F251 VA: 0x271F150
	|-EnumAsStringFormatter<Nullable<Color>>.Serialize
	|
	|-RVA: 0x271FCD0 Offset: 0x271FDD1 VA: 0x271FCD0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Serialize
	|
	|-RVA: 0x2720810 Offset: 0x2720911 VA: 0x2720810
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Serialize
	|
	|-RVA: 0x2721390 Offset: 0x2721491 VA: 0x2721390
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Serialize
	|
	|-RVA: 0x2721EE0 Offset: 0x2721FE1 VA: 0x2721EE0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Serialize
	|
	|-RVA: 0x2722A70 Offset: 0x2722B71 VA: 0x2722A70
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Serialize
	|
	|-RVA: 0x27236D0 Offset: 0x27237D1 VA: 0x27236D0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Serialize
	|
	|-RVA: 0x2724250 Offset: 0x2724351 VA: 0x2724250
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Serialize
	|
	|-RVA: 0x2724D90 Offset: 0x2724E91 VA: 0x2724D90
	|-EnumAsStringFormatter<Nullable<Rect>>.Serialize
	|
	|-RVA: 0x27C8DF0 Offset: 0x27C8EF1 VA: 0x27C8DF0
	|-EnumAsStringFormatter<Nullable<RectInt>>.Serialize
	|
	|-RVA: 0x27C9970 Offset: 0x27C9A71 VA: 0x27C9970
	|-EnumAsStringFormatter<Nullable<Vector2>>.Serialize
	|
	|-RVA: 0x27CA4A0 Offset: 0x27CA5A1 VA: 0x27CA4A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Serialize
	|
	|-RVA: 0x27CAFB0 Offset: 0x27CB0B1 VA: 0x27CAFB0
	|-EnumAsStringFormatter<Nullable<Vector3>>.Serialize
	|
	|-RVA: 0x27CBAB0 Offset: 0x27CBBB1 VA: 0x27CBAB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Serialize
	|
	|-RVA: 0x27CC5E0 Offset: 0x27CC6E1 VA: 0x27CC5E0
	|-EnumAsStringFormatter<Nullable<Vector4>>.Serialize
	|
	|-RVA: 0x27CD150 Offset: 0x27CD251 VA: 0x27CD150
	|-EnumAsStringFormatter<object>.Serialize
	|
	|-RVA: 0x27CDC20 Offset: 0x27CDD21 VA: 0x27CDC20
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Serialize
	|
	|-RVA: 0x27CE740 Offset: 0x27CE841 VA: 0x27CE740
	|-EnumAsStringFormatter<sbyte>.Serialize
	|
	|-RVA: 0x27CF250 Offset: 0x27CF351 VA: 0x27CF250
	|-EnumAsStringFormatter<float>.Serialize
	|
	|-RVA: 0x27CFD40 Offset: 0x27CFE41 VA: 0x27CFD40
	|-EnumAsStringFormatter<ushort>.Serialize
	|
	|-RVA: 0x27D0830 Offset: 0x27D0931 VA: 0x27D0830
	|-EnumAsStringFormatter<uint>.Serialize
	|
	|-RVA: 0x27D1320 Offset: 0x27D1421 VA: 0x27D1320
	|-EnumAsStringFormatter<ulong>.Serialize
	|
	|-RVA: 0x27D1E70 Offset: 0x27D1F71 VA: 0x27D1E70
	|-EnumAsStringFormatter<Bounds>.Serialize
	|
	|-RVA: 0x27D2A10 Offset: 0x27D2B11 VA: 0x27D2A10
	|-EnumAsStringFormatter<BoundsInt>.Serialize
	|
	|-RVA: 0x27D3540 Offset: 0x27D3641 VA: 0x27D3540
	|-EnumAsStringFormatter<Color32>.Serialize
	|
	|-RVA: 0x27D4070 Offset: 0x27D4171 VA: 0x27D4070
	|-EnumAsStringFormatter<Color>.Serialize
	|
	|-RVA: 0x27D4BA0 Offset: 0x27D4CA1 VA: 0x27D4BA0
	|-EnumAsStringFormatter<GradientAlphaKey>.Serialize
	|
	|-RVA: 0x27D5760 Offset: 0x27D5861 VA: 0x27D5760
	|-EnumAsStringFormatter<GradientColorKey>.Serialize
	|
	|-RVA: 0x27D6370 Offset: 0x27D6471 VA: 0x27D6370
	|-EnumAsStringFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x27D6F20 Offset: 0x27D7021 VA: 0x27D6F20
	|-EnumAsStringFormatter<LayerMask>.Serialize
	|
	|-RVA: 0x27D7B10 Offset: 0x27D7C11 VA: 0x27D7B10
	|-EnumAsStringFormatter<Matrix4x4>.Serialize
	|
	|-RVA: 0x27D86D0 Offset: 0x27D87D1 VA: 0x27D86D0
	|-EnumAsStringFormatter<Quaternion>.Serialize
	|
	|-RVA: 0x27D91E0 Offset: 0x27D92E1 VA: 0x27D91E0
	|-EnumAsStringFormatter<RangeInt>.Serialize
	|
	|-RVA: 0x27D9D50 Offset: 0x27D9E51 VA: 0x27D9D50
	|-EnumAsStringFormatter<Rect>.Serialize
	|
	|-RVA: 0x27DA850 Offset: 0x27DA951 VA: 0x27DA850
	|-EnumAsStringFormatter<RectInt>.Serialize
	|
	|-RVA: 0x27DB370 Offset: 0x27DB471 VA: 0x27DB370
	|-EnumAsStringFormatter<Vector2>.Serialize
	|
	|-RVA: 0x27DBE80 Offset: 0x27DBF81 VA: 0x27DBE80
	|-EnumAsStringFormatter<Vector2Int>.Serialize
	|
	|-RVA: 0x27DC990 Offset: 0x27DCA91 VA: 0x27DC990
	|-EnumAsStringFormatter<Vector3>.Serialize
	|
	|-RVA: 0x27DD4C0 Offset: 0x27DD5C1 VA: 0x27DD4C0
	|-EnumAsStringFormatter<Vector3Int>.Serialize
	|
	|-RVA: 0x27DE010 Offset: 0x27DE111 VA: 0x27DE010
	|-EnumAsStringFormatter<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D4C0 Offset: 0x270D5C1 VA: 0x270D4C0
	|-EnumAsStringFormatter<BitVector32Int>.Deserialize
	|
	|-RVA: 0x270E090 Offset: 0x270E191 VA: 0x270E090
	|-EnumAsStringFormatter<EventCheckId>.Deserialize
	|
	|-RVA: 0x270ED30 Offset: 0x270EE31 VA: 0x270ED30
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Deserialize
	|
	|-RVA: 0x270F930 Offset: 0x270FA31 VA: 0x270F930
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Deserialize
	|
	|-RVA: 0x27104B0 Offset: 0x27105B1 VA: 0x27104B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Deserialize
	|
	|-RVA: 0x2710FF0 Offset: 0x27110F1 VA: 0x2710FF0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Deserialize
	|
	|-RVA: 0x2711C00 Offset: 0x2711D01 VA: 0x2711C00
	|-EnumAsStringFormatter<MonsterHutSaveData>.Deserialize
	|
	|-RVA: 0x2712790 Offset: 0x2712891 VA: 0x2712790
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Deserialize
	|
	|-RVA: 0x27133B0 Offset: 0x27134B1 VA: 0x27133B0
	|-EnumAsStringFormatter<OrderSaveData>.Deserialize
	|
	|-RVA: 0x2713FB0 Offset: 0x27140B1 VA: 0x2713FB0
	|-EnumAsStringFormatter<OrderSaveParameter>.Deserialize
	|
	|-RVA: 0x2714BF0 Offset: 0x2714CF1 VA: 0x2714BF0
	|-EnumAsStringFormatter<Parameter>.Deserialize
	|
	|-RVA: 0x2715740 Offset: 0x2715841 VA: 0x2715740
	|-EnumAsStringFormatter<bool>.Deserialize
	|
	|-RVA: 0x2716230 Offset: 0x2716331 VA: 0x2716230
	|-EnumAsStringFormatter<byte>.Deserialize
	|
	|-RVA: 0x2716D20 Offset: 0x2716E21 VA: 0x2716D20
	|-EnumAsStringFormatter<char>.Deserialize
	|
	|-RVA: 0x2717800 Offset: 0x2717901 VA: 0x2717800
	|-EnumAsStringFormatter<DateTime>.Deserialize
	|
	|-RVA: 0x2718310 Offset: 0x2718411 VA: 0x2718310
	|-EnumAsStringFormatter<double>.Deserialize
	|
	|-RVA: 0x2718E00 Offset: 0x2718F01 VA: 0x2718E00
	|-EnumAsStringFormatter<short>.Deserialize
	|
	|-RVA: 0x27198F0 Offset: 0x27199F1 VA: 0x27198F0
	|-EnumAsStringFormatter<int>.Deserialize
	|
	|-RVA: 0x271A400 Offset: 0x271A501 VA: 0x271A400
	|-EnumAsStringFormatter<Int32Enum>.Deserialize
	|
	|-RVA: 0x271AEE0 Offset: 0x271AFE1 VA: 0x271AEE0
	|-EnumAsStringFormatter<long>.Deserialize
	|
	|-RVA: 0x271B9F0 Offset: 0x271BAF1 VA: 0x271B9F0
	|-EnumAsStringFormatter<Memory<object>>.Deserialize
	|
	|-RVA: 0x271C4E0 Offset: 0x271C5E1 VA: 0x271C4E0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Deserialize
	|
	|-RVA: 0x271D090 Offset: 0x271D191 VA: 0x271D090
	|-EnumAsStringFormatter<Nullable<Bounds>>.Deserialize
	|
	|-RVA: 0x271DC70 Offset: 0x271DD71 VA: 0x271DC70
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Deserialize
	|
	|-RVA: 0x271E780 Offset: 0x271E881 VA: 0x271E780
	|-EnumAsStringFormatter<Nullable<Color32>>.Deserialize
	|
	|-RVA: 0x271F2F0 Offset: 0x271F3F1 VA: 0x271F2F0
	|-EnumAsStringFormatter<Nullable<Color>>.Deserialize
	|
	|-RVA: 0x271FE30 Offset: 0x271FF31 VA: 0x271FE30
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Deserialize
	|
	|-RVA: 0x27209B0 Offset: 0x2720AB1 VA: 0x27209B0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Deserialize
	|
	|-RVA: 0x2721530 Offset: 0x2721631 VA: 0x2721530
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Deserialize
	|
	|-RVA: 0x2722030 Offset: 0x2722131 VA: 0x2722030
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Deserialize
	|
	|-RVA: 0x2722CA0 Offset: 0x2722DA1 VA: 0x2722CA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Deserialize
	|
	|-RVA: 0x2723870 Offset: 0x2723971 VA: 0x2723870
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Deserialize
	|
	|-RVA: 0x27243B0 Offset: 0x27244B1 VA: 0x27243B0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Deserialize
	|
	|-RVA: 0x2724F30 Offset: 0x2725031 VA: 0x2724F30
	|-EnumAsStringFormatter<Nullable<Rect>>.Deserialize
	|
	|-RVA: 0x27C8F90 Offset: 0x27C9091 VA: 0x27C8F90
	|-EnumAsStringFormatter<Nullable<RectInt>>.Deserialize
	|
	|-RVA: 0x27C9AD0 Offset: 0x27C9BD1 VA: 0x27C9AD0
	|-EnumAsStringFormatter<Nullable<Vector2>>.Deserialize
	|
	|-RVA: 0x27CA600 Offset: 0x27CA701 VA: 0x27CA600
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Deserialize
	|
	|-RVA: 0x27CB110 Offset: 0x27CB211 VA: 0x27CB110
	|-EnumAsStringFormatter<Nullable<Vector3>>.Deserialize
	|
	|-RVA: 0x27CBC10 Offset: 0x27CBD11 VA: 0x27CBC10
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Deserialize
	|
	|-RVA: 0x27CC780 Offset: 0x27CC881 VA: 0x27CC780
	|-EnumAsStringFormatter<Nullable<Vector4>>.Deserialize
	|
	|-RVA: 0x27CD280 Offset: 0x27CD381 VA: 0x27CD280
	|-EnumAsStringFormatter<object>.Deserialize
	|
	|-RVA: 0x27CDD80 Offset: 0x27CDE81 VA: 0x27CDD80
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Deserialize
	|
	|-RVA: 0x27CE870 Offset: 0x27CE971 VA: 0x27CE870
	|-EnumAsStringFormatter<sbyte>.Deserialize
	|
	|-RVA: 0x27CF380 Offset: 0x27CF481 VA: 0x27CF380
	|-EnumAsStringFormatter<float>.Deserialize
	|
	|-RVA: 0x27CFE70 Offset: 0x27CFF71 VA: 0x27CFE70
	|-EnumAsStringFormatter<ushort>.Deserialize
	|
	|-RVA: 0x27D0960 Offset: 0x27D0A61 VA: 0x27D0960
	|-EnumAsStringFormatter<uint>.Deserialize
	|
	|-RVA: 0x27D1440 Offset: 0x27D1541 VA: 0x27D1440
	|-EnumAsStringFormatter<ulong>.Deserialize
	|
	|-RVA: 0x27D1FC0 Offset: 0x27D20C1 VA: 0x27D1FC0
	|-EnumAsStringFormatter<Bounds>.Deserialize
	|
	|-RVA: 0x27D2B60 Offset: 0x27D2C61 VA: 0x27D2B60
	|-EnumAsStringFormatter<BoundsInt>.Deserialize
	|
	|-RVA: 0x27D3670 Offset: 0x27D3771 VA: 0x27D3670
	|-EnumAsStringFormatter<Color32>.Deserialize
	|
	|-RVA: 0x27D41C0 Offset: 0x27D42C1 VA: 0x27D41C0
	|-EnumAsStringFormatter<Color>.Deserialize
	|
	|-RVA: 0x27D4D20 Offset: 0x27D4E21 VA: 0x27D4D20
	|-EnumAsStringFormatter<GradientAlphaKey>.Deserialize
	|
	|-RVA: 0x27D5900 Offset: 0x27D5A01 VA: 0x27D5900
	|-EnumAsStringFormatter<GradientColorKey>.Deserialize
	|
	|-RVA: 0x27D6530 Offset: 0x27D6631 VA: 0x27D6530
	|-EnumAsStringFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x27D7090 Offset: 0x27D7191 VA: 0x27D7090
	|-EnumAsStringFormatter<LayerMask>.Deserialize
	|
	|-RVA: 0x27D7CA0 Offset: 0x27D7DA1 VA: 0x27D7CA0
	|-EnumAsStringFormatter<Matrix4x4>.Deserialize
	|
	|-RVA: 0x27D8820 Offset: 0x27D8921 VA: 0x27D8820
	|-EnumAsStringFormatter<Quaternion>.Deserialize
	|
	|-RVA: 0x27D9350 Offset: 0x27D9451 VA: 0x27D9350
	|-EnumAsStringFormatter<RangeInt>.Deserialize
	|
	|-RVA: 0x27D9EA0 Offset: 0x27D9FA1 VA: 0x27D9EA0
	|-EnumAsStringFormatter<Rect>.Deserialize
	|
	|-RVA: 0x27DA990 Offset: 0x27DAA91 VA: 0x27DA990
	|-EnumAsStringFormatter<RectInt>.Deserialize
	|
	|-RVA: 0x27DB4B0 Offset: 0x27DB5B1 VA: 0x27DB4B0
	|-EnumAsStringFormatter<Vector2>.Deserialize
	|
	|-RVA: 0x27DBFA0 Offset: 0x27DC0A1 VA: 0x27DBFA0
	|-EnumAsStringFormatter<Vector2Int>.Deserialize
	|
	|-RVA: 0x27DCAE0 Offset: 0x27DCBE1 VA: 0x27DCAE0
	|-EnumAsStringFormatter<Vector3>.Deserialize
	|
	|-RVA: 0x27DD600 Offset: 0x27DD701 VA: 0x27DD600
	|-EnumAsStringFormatter<Vector3Int>.Deserialize
	|
	|-RVA: 0x27DE160 Offset: 0x27DE261 VA: 0x27DE160
	|-EnumAsStringFormatter<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	private string GetClrNames(string serializedNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D6B0 Offset: 0x270D7B1 VA: 0x270D6B0
	|-EnumAsStringFormatter<BitVector32Int>.GetClrNames
	|
	|-RVA: 0x270E2A0 Offset: 0x270E3A1 VA: 0x270E2A0
	|-EnumAsStringFormatter<EventCheckId>.GetClrNames
	|
	|-RVA: 0x270EF50 Offset: 0x270F051 VA: 0x270EF50
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetClrNames
	|
	|-RVA: 0x270FB40 Offset: 0x270FC41 VA: 0x270FB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetClrNames
	|
	|-RVA: 0x27106B0 Offset: 0x27107B1 VA: 0x27106B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetClrNames
	|
	|-RVA: 0x27111E0 Offset: 0x27112E1 VA: 0x27111E0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetClrNames
	|
	|-RVA: 0x2711E20 Offset: 0x2711F21 VA: 0x2711E20
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetClrNames
	|
	|-RVA: 0x2712990 Offset: 0x2712A91 VA: 0x2712990
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetClrNames
	|
	|-RVA: 0x27135D0 Offset: 0x27136D1 VA: 0x27135D0
	|-EnumAsStringFormatter<OrderSaveData>.GetClrNames
	|
	|-RVA: 0x27141C0 Offset: 0x27142C1 VA: 0x27141C0
	|-EnumAsStringFormatter<OrderSaveParameter>.GetClrNames
	|
	|-RVA: 0x2714E30 Offset: 0x2714F31 VA: 0x2714E30
	|-EnumAsStringFormatter<Parameter>.GetClrNames
	|
	|-RVA: 0x2715930 Offset: 0x2715A31 VA: 0x2715930
	|-EnumAsStringFormatter<bool>.GetClrNames
	|
	|-RVA: 0x2716420 Offset: 0x2716521 VA: 0x2716420
	|-EnumAsStringFormatter<byte>.GetClrNames
	|
	|-RVA: 0x2716F10 Offset: 0x2717011 VA: 0x2716F10
	|-EnumAsStringFormatter<char>.GetClrNames
	|
	|-RVA: 0x27179F0 Offset: 0x2717AF1 VA: 0x27179F0
	|-EnumAsStringFormatter<DateTime>.GetClrNames
	|
	|-RVA: 0x2718500 Offset: 0x2718601 VA: 0x2718500
	|-EnumAsStringFormatter<double>.GetClrNames
	|
	|-RVA: 0x2718FF0 Offset: 0x27190F1 VA: 0x2718FF0
	|-EnumAsStringFormatter<short>.GetClrNames
	|
	|-RVA: 0x2719AE0 Offset: 0x2719BE1 VA: 0x2719AE0
	|-EnumAsStringFormatter<int>.GetClrNames
	|
	|-RVA: 0x271A5F0 Offset: 0x271A6F1 VA: 0x271A5F0
	|-EnumAsStringFormatter<Int32Enum>.GetClrNames
	|
	|-RVA: 0x271B0D0 Offset: 0x271B1D1 VA: 0x271B0D0
	|-EnumAsStringFormatter<long>.GetClrNames
	|
	|-RVA: 0x271BBE0 Offset: 0x271BCE1 VA: 0x271BBE0
	|-EnumAsStringFormatter<Memory<object>>.GetClrNames
	|
	|-RVA: 0x271C6C0 Offset: 0x271C7C1 VA: 0x271C6C0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetClrNames
	|
	|-RVA: 0x271D2A0 Offset: 0x271D3A1 VA: 0x271D2A0
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetClrNames
	|
	|-RVA: 0x271DE80 Offset: 0x271DF81 VA: 0x271DE80
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetClrNames
	|
	|-RVA: 0x271E960 Offset: 0x271EA61 VA: 0x271E960
	|-EnumAsStringFormatter<Nullable<Color32>>.GetClrNames
	|
	|-RVA: 0x271F4F0 Offset: 0x271F5F1 VA: 0x271F4F0
	|-EnumAsStringFormatter<Nullable<Color>>.GetClrNames
	|
	|-RVA: 0x2720020 Offset: 0x2720121 VA: 0x2720020
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetClrNames
	|
	|-RVA: 0x2720BB0 Offset: 0x2720CB1 VA: 0x2720BB0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetClrNames
	|
	|-RVA: 0x2721730 Offset: 0x2721831 VA: 0x2721730
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetClrNames
	|
	|-RVA: 0x2722210 Offset: 0x2722311 VA: 0x2722210
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetClrNames
	|
	|-RVA: 0x2722EE0 Offset: 0x2722FE1 VA: 0x2722EE0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetClrNames
	|
	|-RVA: 0x2723A70 Offset: 0x2723B71 VA: 0x2723A70
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetClrNames
	|
	|-RVA: 0x27245A0 Offset: 0x27246A1 VA: 0x27245A0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetClrNames
	|
	|-RVA: 0x2725130 Offset: 0x2725231 VA: 0x2725130
	|-EnumAsStringFormatter<Nullable<Rect>>.GetClrNames
	|
	|-RVA: 0x27C9190 Offset: 0x27C9291 VA: 0x27C9190
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetClrNames
	|
	|-RVA: 0x27C9CC0 Offset: 0x27C9DC1 VA: 0x27C9CC0
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetClrNames
	|
	|-RVA: 0x27CA7F0 Offset: 0x27CA8F1 VA: 0x27CA7F0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetClrNames
	|
	|-RVA: 0x27CB2F0 Offset: 0x27CB3F1 VA: 0x27CB2F0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetClrNames
	|
	|-RVA: 0x27CBDF0 Offset: 0x27CBEF1 VA: 0x27CBDF0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetClrNames
	|
	|-RVA: 0x27CC980 Offset: 0x27CCA81 VA: 0x27CC980
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetClrNames
	|
	|-RVA: 0x27CD460 Offset: 0x27CD561 VA: 0x27CD460
	|-EnumAsStringFormatter<object>.GetClrNames
	|
	|-RVA: 0x27CDF70 Offset: 0x27CE071 VA: 0x27CDF70
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetClrNames
	|
	|-RVA: 0x27CEA60 Offset: 0x27CEB61 VA: 0x27CEA60
	|-EnumAsStringFormatter<sbyte>.GetClrNames
	|
	|-RVA: 0x27CF570 Offset: 0x27CF671 VA: 0x27CF570
	|-EnumAsStringFormatter<float>.GetClrNames
	|
	|-RVA: 0x27D0060 Offset: 0x27D0161 VA: 0x27D0060
	|-EnumAsStringFormatter<ushort>.GetClrNames
	|
	|-RVA: 0x27D0B50 Offset: 0x27D0C51 VA: 0x27D0B50
	|-EnumAsStringFormatter<uint>.GetClrNames
	|
	|-RVA: 0x27D1630 Offset: 0x27D1731 VA: 0x27D1630
	|-EnumAsStringFormatter<ulong>.GetClrNames
	|
	|-RVA: 0x27D21D0 Offset: 0x27D22D1 VA: 0x27D21D0
	|-EnumAsStringFormatter<Bounds>.GetClrNames
	|
	|-RVA: 0x27D2D70 Offset: 0x27D2E71 VA: 0x27D2D70
	|-EnumAsStringFormatter<BoundsInt>.GetClrNames
	|
	|-RVA: 0x27D3860 Offset: 0x27D3961 VA: 0x27D3860
	|-EnumAsStringFormatter<Color32>.GetClrNames
	|
	|-RVA: 0x27D43B0 Offset: 0x27D44B1 VA: 0x27D43B0
	|-EnumAsStringFormatter<Color>.GetClrNames
	|
	|-RVA: 0x27D4F20 Offset: 0x27D5021 VA: 0x27D4F20
	|-EnumAsStringFormatter<GradientAlphaKey>.GetClrNames
	|
	|-RVA: 0x27D5B10 Offset: 0x27D5C11 VA: 0x27D5B10
	|-EnumAsStringFormatter<GradientColorKey>.GetClrNames
	|
	|-RVA: 0x27D6750 Offset: 0x27D6851 VA: 0x27D6750
	|-EnumAsStringFormatter<Keyframe>.GetClrNames
	|
	|-RVA: 0x27D7280 Offset: 0x27D7381 VA: 0x27D7280
	|-EnumAsStringFormatter<LayerMask>.GetClrNames
	|
	|-RVA: 0x27D7EC0 Offset: 0x27D7FC1 VA: 0x27D7EC0
	|-EnumAsStringFormatter<Matrix4x4>.GetClrNames
	|
	|-RVA: 0x27D8A10 Offset: 0x27D8B11 VA: 0x27D8A10
	|-EnumAsStringFormatter<Quaternion>.GetClrNames
	|
	|-RVA: 0x27D9540 Offset: 0x27D9641 VA: 0x27D9540
	|-EnumAsStringFormatter<RangeInt>.GetClrNames
	|
	|-RVA: 0x27DA090 Offset: 0x27DA191 VA: 0x27DA090
	|-EnumAsStringFormatter<Rect>.GetClrNames
	|
	|-RVA: 0x27DAB80 Offset: 0x27DAC81 VA: 0x27DAB80
	|-EnumAsStringFormatter<RectInt>.GetClrNames
	|
	|-RVA: 0x27DB6B0 Offset: 0x27DB7B1 VA: 0x27DB6B0
	|-EnumAsStringFormatter<Vector2>.GetClrNames
	|
	|-RVA: 0x27DC190 Offset: 0x27DC291 VA: 0x27DC190
	|-EnumAsStringFormatter<Vector2Int>.GetClrNames
	|
	|-RVA: 0x27DCCE0 Offset: 0x27DCDE1 VA: 0x27DCCE0
	|-EnumAsStringFormatter<Vector3>.GetClrNames
	|
	|-RVA: 0x27DD800 Offset: 0x27DD901 VA: 0x27DD800
	|-EnumAsStringFormatter<Vector3Int>.GetClrNames
	|
	|-RVA: 0x27DE350 Offset: 0x27DE451 VA: 0x27DE350
	|-EnumAsStringFormatter<Vector4>.GetClrNames
	*/

	// RVA: -1 Offset: -1
	private string GetSerializedNames(string clrNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D770 Offset: 0x270D871 VA: 0x270D770
	|-EnumAsStringFormatter<BitVector32Int>.GetSerializedNames
	|
	|-RVA: 0x270E360 Offset: 0x270E461 VA: 0x270E360
	|-EnumAsStringFormatter<EventCheckId>.GetSerializedNames
	|
	|-RVA: 0x270F010 Offset: 0x270F111 VA: 0x270F010
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetSerializedNames
	|
	|-RVA: 0x270FC00 Offset: 0x270FD01 VA: 0x270FC00
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetSerializedNames
	|
	|-RVA: 0x2710770 Offset: 0x2710871 VA: 0x2710770
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetSerializedNames
	|
	|-RVA: 0x27112A0 Offset: 0x27113A1 VA: 0x27112A0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetSerializedNames
	|
	|-RVA: 0x2711EE0 Offset: 0x2711FE1 VA: 0x2711EE0
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetSerializedNames
	|
	|-RVA: 0x2712A50 Offset: 0x2712B51 VA: 0x2712A50
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2713690 Offset: 0x2713791 VA: 0x2713690
	|-EnumAsStringFormatter<OrderSaveData>.GetSerializedNames
	|
	|-RVA: 0x2714280 Offset: 0x2714381 VA: 0x2714280
	|-EnumAsStringFormatter<OrderSaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2714EF0 Offset: 0x2714FF1 VA: 0x2714EF0
	|-EnumAsStringFormatter<Parameter>.GetSerializedNames
	|
	|-RVA: 0x27159F0 Offset: 0x2715AF1 VA: 0x27159F0
	|-EnumAsStringFormatter<bool>.GetSerializedNames
	|
	|-RVA: 0x27164E0 Offset: 0x27165E1 VA: 0x27164E0
	|-EnumAsStringFormatter<byte>.GetSerializedNames
	|
	|-RVA: 0x2716FD0 Offset: 0x27170D1 VA: 0x2716FD0
	|-EnumAsStringFormatter<char>.GetSerializedNames
	|
	|-RVA: 0x2717AB0 Offset: 0x2717BB1 VA: 0x2717AB0
	|-EnumAsStringFormatter<DateTime>.GetSerializedNames
	|
	|-RVA: 0x27185C0 Offset: 0x27186C1 VA: 0x27185C0
	|-EnumAsStringFormatter<double>.GetSerializedNames
	|
	|-RVA: 0x27190B0 Offset: 0x27191B1 VA: 0x27190B0
	|-EnumAsStringFormatter<short>.GetSerializedNames
	|
	|-RVA: 0x2719BA0 Offset: 0x2719CA1 VA: 0x2719BA0
	|-EnumAsStringFormatter<int>.GetSerializedNames
	|
	|-RVA: 0x271A6B0 Offset: 0x271A7B1 VA: 0x271A6B0
	|-EnumAsStringFormatter<Int32Enum>.GetSerializedNames
	|
	|-RVA: 0x271B190 Offset: 0x271B291 VA: 0x271B190
	|-EnumAsStringFormatter<long>.GetSerializedNames
	|
	|-RVA: 0x271BCA0 Offset: 0x271BDA1 VA: 0x271BCA0
	|-EnumAsStringFormatter<Memory<object>>.GetSerializedNames
	|
	|-RVA: 0x271C780 Offset: 0x271C881 VA: 0x271C780
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetSerializedNames
	|
	|-RVA: 0x271D360 Offset: 0x271D461 VA: 0x271D360
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetSerializedNames
	|
	|-RVA: 0x271DF40 Offset: 0x271E041 VA: 0x271DF40
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetSerializedNames
	|
	|-RVA: 0x271EA20 Offset: 0x271EB21 VA: 0x271EA20
	|-EnumAsStringFormatter<Nullable<Color32>>.GetSerializedNames
	|
	|-RVA: 0x271F5B0 Offset: 0x271F6B1 VA: 0x271F5B0
	|-EnumAsStringFormatter<Nullable<Color>>.GetSerializedNames
	|
	|-RVA: 0x27200E0 Offset: 0x27201E1 VA: 0x27200E0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetSerializedNames
	|
	|-RVA: 0x2720C70 Offset: 0x2720D71 VA: 0x2720C70
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetSerializedNames
	|
	|-RVA: 0x27217F0 Offset: 0x27218F1 VA: 0x27217F0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetSerializedNames
	|
	|-RVA: 0x27222D0 Offset: 0x27223D1 VA: 0x27222D0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetSerializedNames
	|
	|-RVA: 0x2722FA0 Offset: 0x27230A1 VA: 0x2722FA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetSerializedNames
	|
	|-RVA: 0x2723B30 Offset: 0x2723C31 VA: 0x2723B30
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetSerializedNames
	|
	|-RVA: 0x2724660 Offset: 0x2724761 VA: 0x2724660
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetSerializedNames
	|
	|-RVA: 0x27251F0 Offset: 0x27252F1 VA: 0x27251F0
	|-EnumAsStringFormatter<Nullable<Rect>>.GetSerializedNames
	|
	|-RVA: 0x27C9250 Offset: 0x27C9351 VA: 0x27C9250
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetSerializedNames
	|
	|-RVA: 0x27C9D80 Offset: 0x27C9E81 VA: 0x27C9D80
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetSerializedNames
	|
	|-RVA: 0x27CA8B0 Offset: 0x27CA9B1 VA: 0x27CA8B0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetSerializedNames
	|
	|-RVA: 0x27CB3B0 Offset: 0x27CB4B1 VA: 0x27CB3B0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetSerializedNames
	|
	|-RVA: 0x27CBEB0 Offset: 0x27CBFB1 VA: 0x27CBEB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetSerializedNames
	|
	|-RVA: 0x27CCA40 Offset: 0x27CCB41 VA: 0x27CCA40
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetSerializedNames
	|
	|-RVA: 0x27CD520 Offset: 0x27CD621 VA: 0x27CD520
	|-EnumAsStringFormatter<object>.GetSerializedNames
	|
	|-RVA: 0x27CE030 Offset: 0x27CE131 VA: 0x27CE030
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetSerializedNames
	|
	|-RVA: 0x27CEB20 Offset: 0x27CEC21 VA: 0x27CEB20
	|-EnumAsStringFormatter<sbyte>.GetSerializedNames
	|
	|-RVA: 0x27CF630 Offset: 0x27CF731 VA: 0x27CF630
	|-EnumAsStringFormatter<float>.GetSerializedNames
	|
	|-RVA: 0x27D0120 Offset: 0x27D0221 VA: 0x27D0120
	|-EnumAsStringFormatter<ushort>.GetSerializedNames
	|
	|-RVA: 0x27D0C10 Offset: 0x27D0D11 VA: 0x27D0C10
	|-EnumAsStringFormatter<uint>.GetSerializedNames
	|
	|-RVA: 0x27D16F0 Offset: 0x27D17F1 VA: 0x27D16F0
	|-EnumAsStringFormatter<ulong>.GetSerializedNames
	|
	|-RVA: 0x27D2290 Offset: 0x27D2391 VA: 0x27D2290
	|-EnumAsStringFormatter<Bounds>.GetSerializedNames
	|
	|-RVA: 0x27D2E30 Offset: 0x27D2F31 VA: 0x27D2E30
	|-EnumAsStringFormatter<BoundsInt>.GetSerializedNames
	|
	|-RVA: 0x27D3920 Offset: 0x27D3A21 VA: 0x27D3920
	|-EnumAsStringFormatter<Color32>.GetSerializedNames
	|
	|-RVA: 0x27D4470 Offset: 0x27D4571 VA: 0x27D4470
	|-EnumAsStringFormatter<Color>.GetSerializedNames
	|
	|-RVA: 0x27D4FE0 Offset: 0x27D50E1 VA: 0x27D4FE0
	|-EnumAsStringFormatter<GradientAlphaKey>.GetSerializedNames
	|
	|-RVA: 0x27D5BD0 Offset: 0x27D5CD1 VA: 0x27D5BD0
	|-EnumAsStringFormatter<GradientColorKey>.GetSerializedNames
	|
	|-RVA: 0x27D6810 Offset: 0x27D6911 VA: 0x27D6810
	|-EnumAsStringFormatter<Keyframe>.GetSerializedNames
	|
	|-RVA: 0x27D7340 Offset: 0x27D7441 VA: 0x27D7340
	|-EnumAsStringFormatter<LayerMask>.GetSerializedNames
	|
	|-RVA: 0x27D7F80 Offset: 0x27D8081 VA: 0x27D7F80
	|-EnumAsStringFormatter<Matrix4x4>.GetSerializedNames
	|
	|-RVA: 0x27D8AD0 Offset: 0x27D8BD1 VA: 0x27D8AD0
	|-EnumAsStringFormatter<Quaternion>.GetSerializedNames
	|
	|-RVA: 0x27D9600 Offset: 0x27D9701 VA: 0x27D9600
	|-EnumAsStringFormatter<RangeInt>.GetSerializedNames
	|
	|-RVA: 0x27DA150 Offset: 0x27DA251 VA: 0x27DA150
	|-EnumAsStringFormatter<Rect>.GetSerializedNames
	|
	|-RVA: 0x27DAC40 Offset: 0x27DAD41 VA: 0x27DAC40
	|-EnumAsStringFormatter<RectInt>.GetSerializedNames
	|
	|-RVA: 0x27DB770 Offset: 0x27DB871 VA: 0x27DB770
	|-EnumAsStringFormatter<Vector2>.GetSerializedNames
	|
	|-RVA: 0x27DC250 Offset: 0x27DC351 VA: 0x27DC250
	|-EnumAsStringFormatter<Vector2Int>.GetSerializedNames
	|
	|-RVA: 0x27DCDA0 Offset: 0x27DCEA1 VA: 0x27DCDA0
	|-EnumAsStringFormatter<Vector3>.GetSerializedNames
	|
	|-RVA: 0x27DD8C0 Offset: 0x27DD9C1 VA: 0x27DD8C0
	|-EnumAsStringFormatter<Vector3Int>.GetSerializedNames
	|
	|-RVA: 0x27DE410 Offset: 0x27DE511 VA: 0x27DE410
	|-EnumAsStringFormatter<Vector4>.GetSerializedNames
	*/

	// RVA: -1 Offset: -1
	private static string Translate(string items, IReadOnlyDictionary<string, string> mapping) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D830 Offset: 0x270D931 VA: 0x270D830
	|-EnumAsStringFormatter<BitVector32Int>.Translate
	|
	|-RVA: 0x270E420 Offset: 0x270E521 VA: 0x270E420
	|-EnumAsStringFormatter<EventCheckId>.Translate
	|
	|-RVA: 0x270F0D0 Offset: 0x270F1D1 VA: 0x270F0D0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Translate
	|
	|-RVA: 0x270FCC0 Offset: 0x270FDC1 VA: 0x270FCC0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Translate
	|
	|-RVA: 0x2710830 Offset: 0x2710931 VA: 0x2710830
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Translate
	|
	|-RVA: 0x2711360 Offset: 0x2711461 VA: 0x2711360
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Translate
	|
	|-RVA: 0x2711FA0 Offset: 0x27120A1 VA: 0x2711FA0
	|-EnumAsStringFormatter<MonsterHutSaveData>.Translate
	|
	|-RVA: 0x2712B10 Offset: 0x2712C11 VA: 0x2712B10
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Translate
	|
	|-RVA: 0x2713750 Offset: 0x2713851 VA: 0x2713750
	|-EnumAsStringFormatter<OrderSaveData>.Translate
	|
	|-RVA: 0x2714340 Offset: 0x2714441 VA: 0x2714340
	|-EnumAsStringFormatter<OrderSaveParameter>.Translate
	|
	|-RVA: 0x2714FB0 Offset: 0x27150B1 VA: 0x2714FB0
	|-EnumAsStringFormatter<Parameter>.Translate
	|
	|-RVA: 0x2715AB0 Offset: 0x2715BB1 VA: 0x2715AB0
	|-EnumAsStringFormatter<bool>.Translate
	|
	|-RVA: 0x27165A0 Offset: 0x27166A1 VA: 0x27165A0
	|-EnumAsStringFormatter<byte>.Translate
	|
	|-RVA: 0x2717090 Offset: 0x2717191 VA: 0x2717090
	|-EnumAsStringFormatter<char>.Translate
	|
	|-RVA: 0x2717B70 Offset: 0x2717C71 VA: 0x2717B70
	|-EnumAsStringFormatter<DateTime>.Translate
	|
	|-RVA: 0x2718680 Offset: 0x2718781 VA: 0x2718680
	|-EnumAsStringFormatter<double>.Translate
	|
	|-RVA: 0x2719170 Offset: 0x2719271 VA: 0x2719170
	|-EnumAsStringFormatter<short>.Translate
	|
	|-RVA: 0x2719C60 Offset: 0x2719D61 VA: 0x2719C60
	|-EnumAsStringFormatter<int>.Translate
	|
	|-RVA: 0x271A770 Offset: 0x271A871 VA: 0x271A770
	|-EnumAsStringFormatter<Int32Enum>.Translate
	|
	|-RVA: 0x271B250 Offset: 0x271B351 VA: 0x271B250
	|-EnumAsStringFormatter<long>.Translate
	|
	|-RVA: 0x271BD60 Offset: 0x271BE61 VA: 0x271BD60
	|-EnumAsStringFormatter<Memory<object>>.Translate
	|
	|-RVA: 0x271C840 Offset: 0x271C941 VA: 0x271C840
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Translate
	|
	|-RVA: 0x271D420 Offset: 0x271D521 VA: 0x271D420
	|-EnumAsStringFormatter<Nullable<Bounds>>.Translate
	|
	|-RVA: 0x271E000 Offset: 0x271E101 VA: 0x271E000
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Translate
	|
	|-RVA: 0x271EAE0 Offset: 0x271EBE1 VA: 0x271EAE0
	|-EnumAsStringFormatter<Nullable<Color32>>.Translate
	|
	|-RVA: 0x271F670 Offset: 0x271F771 VA: 0x271F670
	|-EnumAsStringFormatter<Nullable<Color>>.Translate
	|
	|-RVA: 0x27201A0 Offset: 0x27202A1 VA: 0x27201A0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Translate
	|
	|-RVA: 0x2720D30 Offset: 0x2720E31 VA: 0x2720D30
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Translate
	|
	|-RVA: 0x27218B0 Offset: 0x27219B1 VA: 0x27218B0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Translate
	|
	|-RVA: 0x2722390 Offset: 0x2722491 VA: 0x2722390
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Translate
	|
	|-RVA: 0x2723060 Offset: 0x2723161 VA: 0x2723060
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Translate
	|
	|-RVA: 0x2723BF0 Offset: 0x2723CF1 VA: 0x2723BF0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Translate
	|
	|-RVA: 0x2724720 Offset: 0x2724821 VA: 0x2724720
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Translate
	|
	|-RVA: 0x27252B0 Offset: 0x27253B1 VA: 0x27252B0
	|-EnumAsStringFormatter<Nullable<Rect>>.Translate
	|
	|-RVA: 0x27C9310 Offset: 0x27C9411 VA: 0x27C9310
	|-EnumAsStringFormatter<Nullable<RectInt>>.Translate
	|
	|-RVA: 0x27C9E40 Offset: 0x27C9F41 VA: 0x27C9E40
	|-EnumAsStringFormatter<Nullable<Vector2>>.Translate
	|
	|-RVA: 0x27CA970 Offset: 0x27CAA71 VA: 0x27CA970
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Translate
	|
	|-RVA: 0x27CB470 Offset: 0x27CB571 VA: 0x27CB470
	|-EnumAsStringFormatter<Nullable<Vector3>>.Translate
	|
	|-RVA: 0x27CBF70 Offset: 0x27CC071 VA: 0x27CBF70
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Translate
	|
	|-RVA: 0x27CCB00 Offset: 0x27CCC01 VA: 0x27CCB00
	|-EnumAsStringFormatter<Nullable<Vector4>>.Translate
	|
	|-RVA: 0x27CD5E0 Offset: 0x27CD6E1 VA: 0x27CD5E0
	|-EnumAsStringFormatter<object>.Translate
	|
	|-RVA: 0x27CE0F0 Offset: 0x27CE1F1 VA: 0x27CE0F0
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Translate
	|
	|-RVA: 0x27CEBE0 Offset: 0x27CECE1 VA: 0x27CEBE0
	|-EnumAsStringFormatter<sbyte>.Translate
	|
	|-RVA: 0x27CF6F0 Offset: 0x27CF7F1 VA: 0x27CF6F0
	|-EnumAsStringFormatter<float>.Translate
	|
	|-RVA: 0x27D01E0 Offset: 0x27D02E1 VA: 0x27D01E0
	|-EnumAsStringFormatter<ushort>.Translate
	|
	|-RVA: 0x27D0CD0 Offset: 0x27D0DD1 VA: 0x27D0CD0
	|-EnumAsStringFormatter<uint>.Translate
	|
	|-RVA: 0x27D17B0 Offset: 0x27D18B1 VA: 0x27D17B0
	|-EnumAsStringFormatter<ulong>.Translate
	|
	|-RVA: 0x27D2350 Offset: 0x27D2451 VA: 0x27D2350
	|-EnumAsStringFormatter<Bounds>.Translate
	|
	|-RVA: 0x27D2EF0 Offset: 0x27D2FF1 VA: 0x27D2EF0
	|-EnumAsStringFormatter<BoundsInt>.Translate
	|
	|-RVA: 0x27D39E0 Offset: 0x27D3AE1 VA: 0x27D39E0
	|-EnumAsStringFormatter<Color32>.Translate
	|
	|-RVA: 0x27D4530 Offset: 0x27D4631 VA: 0x27D4530
	|-EnumAsStringFormatter<Color>.Translate
	|
	|-RVA: 0x27D50A0 Offset: 0x27D51A1 VA: 0x27D50A0
	|-EnumAsStringFormatter<GradientAlphaKey>.Translate
	|
	|-RVA: 0x27D5C90 Offset: 0x27D5D91 VA: 0x27D5C90
	|-EnumAsStringFormatter<GradientColorKey>.Translate
	|
	|-RVA: 0x27D68D0 Offset: 0x27D69D1 VA: 0x27D68D0
	|-EnumAsStringFormatter<Keyframe>.Translate
	|
	|-RVA: 0x27D7400 Offset: 0x27D7501 VA: 0x27D7400
	|-EnumAsStringFormatter<LayerMask>.Translate
	|
	|-RVA: 0x27D8040 Offset: 0x27D8141 VA: 0x27D8040
	|-EnumAsStringFormatter<Matrix4x4>.Translate
	|
	|-RVA: 0x27D8B90 Offset: 0x27D8C91 VA: 0x27D8B90
	|-EnumAsStringFormatter<Quaternion>.Translate
	|
	|-RVA: 0x27D96C0 Offset: 0x27D97C1 VA: 0x27D96C0
	|-EnumAsStringFormatter<RangeInt>.Translate
	|
	|-RVA: 0x27DA210 Offset: 0x27DA311 VA: 0x27DA210
	|-EnumAsStringFormatter<Rect>.Translate
	|
	|-RVA: 0x27DAD00 Offset: 0x27DAE01 VA: 0x27DAD00
	|-EnumAsStringFormatter<RectInt>.Translate
	|
	|-RVA: 0x27DB830 Offset: 0x27DB931 VA: 0x27DB830
	|-EnumAsStringFormatter<Vector2>.Translate
	|
	|-RVA: 0x27DC310 Offset: 0x27DC411 VA: 0x27DC310
	|-EnumAsStringFormatter<Vector2Int>.Translate
	|
	|-RVA: 0x27DCE60 Offset: 0x27DCF61 VA: 0x27DCE60
	|-EnumAsStringFormatter<Vector3>.Translate
	|
	|-RVA: 0x27DD980 Offset: 0x27DDA81 VA: 0x27DD980
	|-EnumAsStringFormatter<Vector3Int>.Translate
	|
	|-RVA: 0x27DE4D0 Offset: 0x27DE5D1 VA: 0x27DE4D0
	|-EnumAsStringFormatter<Vector4>.Translate
	*/
}

public sealed class EnumAsStringFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter // TypeDefIndex: 5404
{
	// Fields
	private readonly IReadOnlyDictionary<string, T> nameValueMapping; // 0x0
	private readonly IReadOnlyDictionary<T, string> valueNameMapping; // 0x0
	private readonly IReadOnlyDictionary<string, string> clrToSerializationName; // 0x0
	private readonly IReadOnlyDictionary<string, string> serializationToClrName; // 0x0
	private readonly bool enumMemberOverridesPresent; // 0x0
	private readonly bool isFlags; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CFA0 Offset: 0x270D0A1 VA: 0x270CFA0
	|-EnumAsStringFormatter<BitVector32Int>..ctor
	|
	|-RVA: 0x270DA90 Offset: 0x270DB91 VA: 0x270DA90
	|-EnumAsStringFormatter<EventCheckId>..ctor
	|
	|-RVA: 0x270E680 Offset: 0x270E781 VA: 0x270E680
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x270F330 Offset: 0x270F431 VA: 0x270F330
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x270FF20 Offset: 0x2710021 VA: 0x270FF20
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2710A90 Offset: 0x2710B91 VA: 0x2710A90
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x27115C0 Offset: 0x27116C1 VA: 0x27115C0
	|-EnumAsStringFormatter<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2712200 Offset: 0x2712301 VA: 0x2712200
	|-EnumAsStringFormatter<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2712D70 Offset: 0x2712E71 VA: 0x2712D70
	|-EnumAsStringFormatter<OrderSaveData>..ctor
	|
	|-RVA: 0x27139B0 Offset: 0x2713AB1 VA: 0x27139B0
	|-EnumAsStringFormatter<OrderSaveParameter>..ctor
	|
	|-RVA: 0x27145A0 Offset: 0x27146A1 VA: 0x27145A0
	|-EnumAsStringFormatter<Parameter>..ctor
	|
	|-RVA: 0x2715210 Offset: 0x2715311 VA: 0x2715210
	|-EnumAsStringFormatter<bool>..ctor
	|
	|-RVA: 0x2715D10 Offset: 0x2715E11 VA: 0x2715D10
	|-EnumAsStringFormatter<byte>..ctor
	|
	|-RVA: 0x2716800 Offset: 0x2716901 VA: 0x2716800
	|-EnumAsStringFormatter<char>..ctor
	|
	|-RVA: 0x27172F0 Offset: 0x27173F1 VA: 0x27172F0
	|-EnumAsStringFormatter<DateTime>..ctor
	|
	|-RVA: 0x2717DD0 Offset: 0x2717ED1 VA: 0x2717DD0
	|-EnumAsStringFormatter<double>..ctor
	|
	|-RVA: 0x27188E0 Offset: 0x27189E1 VA: 0x27188E0
	|-EnumAsStringFormatter<short>..ctor
	|
	|-RVA: 0x27193D0 Offset: 0x27194D1 VA: 0x27193D0
	|-EnumAsStringFormatter<int>..ctor
	|
	|-RVA: 0x2719EC0 Offset: 0x2719FC1 VA: 0x2719EC0
	|-EnumAsStringFormatter<Int32Enum>..ctor
	|
	|-RVA: 0x271A9D0 Offset: 0x271AAD1 VA: 0x271A9D0
	|-EnumAsStringFormatter<long>..ctor
	|
	|-RVA: 0x271B4B0 Offset: 0x271B5B1 VA: 0x271B4B0
	|-EnumAsStringFormatter<Memory<object>>..ctor
	|
	|-RVA: 0x271BFC0 Offset: 0x271C0C1 VA: 0x271BFC0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x271CAA0 Offset: 0x271CBA1 VA: 0x271CAA0
	|-EnumAsStringFormatter<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x271D680 Offset: 0x271D781 VA: 0x271D680
	|-EnumAsStringFormatter<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x271E260 Offset: 0x271E361 VA: 0x271E260
	|-EnumAsStringFormatter<Nullable<Color32>>..ctor
	|
	|-RVA: 0x271ED40 Offset: 0x271EE41 VA: 0x271ED40
	|-EnumAsStringFormatter<Nullable<Color>>..ctor
	|
	|-RVA: 0x271F8D0 Offset: 0x271F9D1 VA: 0x271F8D0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2720400 Offset: 0x2720501 VA: 0x2720400
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2720F90 Offset: 0x2721091 VA: 0x2720F90
	|-EnumAsStringFormatter<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2721B10 Offset: 0x2721C11 VA: 0x2721B10
	|-EnumAsStringFormatter<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x27225F0 Offset: 0x27226F1 VA: 0x27225F0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x27232C0 Offset: 0x27233C1 VA: 0x27232C0
	|-EnumAsStringFormatter<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2723E50 Offset: 0x2723F51 VA: 0x2723E50
	|-EnumAsStringFormatter<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2724980 Offset: 0x2724A81 VA: 0x2724980
	|-EnumAsStringFormatter<Nullable<Rect>>..ctor
	|
	|-RVA: 0x27C89E0 Offset: 0x27C8AE1 VA: 0x27C89E0
	|-EnumAsStringFormatter<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x27C9570 Offset: 0x27C9671 VA: 0x27C9570
	|-EnumAsStringFormatter<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x27CA0A0 Offset: 0x27CA1A1 VA: 0x27CA0A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x27CABD0 Offset: 0x27CACD1 VA: 0x27CABD0
	|-EnumAsStringFormatter<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x27CB6D0 Offset: 0x27CB7D1 VA: 0x27CB6D0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x27CC1D0 Offset: 0x27CC2D1 VA: 0x27CC1D0
	|-EnumAsStringFormatter<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x27CCD60 Offset: 0x27CCE61 VA: 0x27CCD60
	|-EnumAsStringFormatter<object>..ctor
	|
	|-RVA: 0x27CD840 Offset: 0x27CD941 VA: 0x27CD840
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x27CE350 Offset: 0x27CE451 VA: 0x27CE350
	|-EnumAsStringFormatter<sbyte>..ctor
	|
	|-RVA: 0x27CEE40 Offset: 0x27CEF41 VA: 0x27CEE40
	|-EnumAsStringFormatter<float>..ctor
	|
	|-RVA: 0x27CF950 Offset: 0x27CFA51 VA: 0x27CF950
	|-EnumAsStringFormatter<ushort>..ctor
	|
	|-RVA: 0x27D0440 Offset: 0x27D0541 VA: 0x27D0440
	|-EnumAsStringFormatter<uint>..ctor
	|
	|-RVA: 0x27D0F30 Offset: 0x27D1031 VA: 0x27D0F30
	|-EnumAsStringFormatter<ulong>..ctor
	|
	|-RVA: 0x27D1A10 Offset: 0x27D1B11 VA: 0x27D1A10
	|-EnumAsStringFormatter<Bounds>..ctor
	|
	|-RVA: 0x27D25B0 Offset: 0x27D26B1 VA: 0x27D25B0
	|-EnumAsStringFormatter<BoundsInt>..ctor
	|
	|-RVA: 0x27D3150 Offset: 0x27D3251 VA: 0x27D3150
	|-EnumAsStringFormatter<Color32>..ctor
	|
	|-RVA: 0x27D3C40 Offset: 0x27D3D41 VA: 0x27D3C40
	|-EnumAsStringFormatter<Color>..ctor
	|
	|-RVA: 0x27D4790 Offset: 0x27D4891 VA: 0x27D4790
	|-EnumAsStringFormatter<GradientAlphaKey>..ctor
	|
	|-RVA: 0x27D5300 Offset: 0x27D5401 VA: 0x27D5300
	|-EnumAsStringFormatter<GradientColorKey>..ctor
	|
	|-RVA: 0x27D5EF0 Offset: 0x27D5FF1 VA: 0x27D5EF0
	|-EnumAsStringFormatter<Keyframe>..ctor
	|
	|-RVA: 0x27D6B30 Offset: 0x27D6C31 VA: 0x27D6B30
	|-EnumAsStringFormatter<LayerMask>..ctor
	|
	|-RVA: 0x27D7660 Offset: 0x27D7761 VA: 0x27D7660
	|-EnumAsStringFormatter<Matrix4x4>..ctor
	|
	|-RVA: 0x27D82A0 Offset: 0x27D83A1 VA: 0x27D82A0
	|-EnumAsStringFormatter<Quaternion>..ctor
	|
	|-RVA: 0x27D8DF0 Offset: 0x27D8EF1 VA: 0x27D8DF0
	|-EnumAsStringFormatter<RangeInt>..ctor
	|
	|-RVA: 0x27D9920 Offset: 0x27D9A21 VA: 0x27D9920
	|-EnumAsStringFormatter<Rect>..ctor
	|
	|-RVA: 0x27DA470 Offset: 0x27DA571 VA: 0x27DA470
	|-EnumAsStringFormatter<RectInt>..ctor
	|
	|-RVA: 0x27DAF60 Offset: 0x27DB061 VA: 0x27DAF60
	|-EnumAsStringFormatter<Vector2>..ctor
	|
	|-RVA: 0x27DBA90 Offset: 0x27DBB91 VA: 0x27DBA90
	|-EnumAsStringFormatter<Vector2Int>..ctor
	|
	|-RVA: 0x27DC570 Offset: 0x27DC671 VA: 0x27DC570
	|-EnumAsStringFormatter<Vector3>..ctor
	|
	|-RVA: 0x27DD0C0 Offset: 0x27DD1C1 VA: 0x27DD0C0
	|-EnumAsStringFormatter<Vector3Int>..ctor
	|
	|-RVA: 0x27DDBE0 Offset: 0x27DDCE1 VA: 0x27DDBE0
	|-EnumAsStringFormatter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D390 Offset: 0x270D491 VA: 0x270D390
	|-EnumAsStringFormatter<BitVector32Int>.Serialize
	|
	|-RVA: 0x270DEF0 Offset: 0x270DFF1 VA: 0x270DEF0
	|-EnumAsStringFormatter<EventCheckId>.Serialize
	|
	|-RVA: 0x270EB40 Offset: 0x270EC41 VA: 0x270EB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Serialize
	|
	|-RVA: 0x270F790 Offset: 0x270F891 VA: 0x270F790
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Serialize
	|
	|-RVA: 0x2710320 Offset: 0x2710421 VA: 0x2710320
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Serialize
	|
	|-RVA: 0x2710E70 Offset: 0x2710F71 VA: 0x2710E70
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Serialize
	|
	|-RVA: 0x2711A40 Offset: 0x2711B41 VA: 0x2711A40
	|-EnumAsStringFormatter<MonsterHutSaveData>.Serialize
	|
	|-RVA: 0x2712600 Offset: 0x2712701 VA: 0x2712600
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Serialize
	|
	|-RVA: 0x27131F0 Offset: 0x27132F1 VA: 0x27131F0
	|-EnumAsStringFormatter<OrderSaveData>.Serialize
	|
	|-RVA: 0x2713E10 Offset: 0x2713F11 VA: 0x2713E10
	|-EnumAsStringFormatter<OrderSaveParameter>.Serialize
	|
	|-RVA: 0x2714A40 Offset: 0x2714B41 VA: 0x2714A40
	|-EnumAsStringFormatter<Parameter>.Serialize
	|
	|-RVA: 0x2715610 Offset: 0x2715711 VA: 0x2715610
	|-EnumAsStringFormatter<bool>.Serialize
	|
	|-RVA: 0x2716100 Offset: 0x2716201 VA: 0x2716100
	|-EnumAsStringFormatter<byte>.Serialize
	|
	|-RVA: 0x2716BF0 Offset: 0x2716CF1 VA: 0x2716BF0
	|-EnumAsStringFormatter<char>.Serialize
	|
	|-RVA: 0x27176E0 Offset: 0x27177E1 VA: 0x27176E0
	|-EnumAsStringFormatter<DateTime>.Serialize
	|
	|-RVA: 0x27181E0 Offset: 0x27182E1 VA: 0x27181E0
	|-EnumAsStringFormatter<double>.Serialize
	|
	|-RVA: 0x2718CD0 Offset: 0x2718DD1 VA: 0x2718CD0
	|-EnumAsStringFormatter<short>.Serialize
	|
	|-RVA: 0x27197C0 Offset: 0x27198C1 VA: 0x27197C0
	|-EnumAsStringFormatter<int>.Serialize
	|
	|-RVA: 0x271A2B0 Offset: 0x271A3B1 VA: 0x271A2B0
	|-EnumAsStringFormatter<Int32Enum>.Serialize
	|
	|-RVA: 0x271ADC0 Offset: 0x271AEC1 VA: 0x271ADC0
	|-EnumAsStringFormatter<long>.Serialize
	|
	|-RVA: 0x271B890 Offset: 0x271B991 VA: 0x271B890
	|-EnumAsStringFormatter<Memory<object>>.Serialize
	|
	|-RVA: 0x271C390 Offset: 0x271C491 VA: 0x271C390
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Serialize
	|
	|-RVA: 0x271CED0 Offset: 0x271CFD1 VA: 0x271CED0
	|-EnumAsStringFormatter<Nullable<Bounds>>.Serialize
	|
	|-RVA: 0x271DAB0 Offset: 0x271DBB1 VA: 0x271DAB0
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Serialize
	|
	|-RVA: 0x271E630 Offset: 0x271E731 VA: 0x271E630
	|-EnumAsStringFormatter<Nullable<Color32>>.Serialize
	|
	|-RVA: 0x271F150 Offset: 0x271F251 VA: 0x271F150
	|-EnumAsStringFormatter<Nullable<Color>>.Serialize
	|
	|-RVA: 0x271FCD0 Offset: 0x271FDD1 VA: 0x271FCD0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Serialize
	|
	|-RVA: 0x2720810 Offset: 0x2720911 VA: 0x2720810
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Serialize
	|
	|-RVA: 0x2721390 Offset: 0x2721491 VA: 0x2721390
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Serialize
	|
	|-RVA: 0x2721EE0 Offset: 0x2721FE1 VA: 0x2721EE0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Serialize
	|
	|-RVA: 0x2722A70 Offset: 0x2722B71 VA: 0x2722A70
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Serialize
	|
	|-RVA: 0x27236D0 Offset: 0x27237D1 VA: 0x27236D0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Serialize
	|
	|-RVA: 0x2724250 Offset: 0x2724351 VA: 0x2724250
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Serialize
	|
	|-RVA: 0x2724D90 Offset: 0x2724E91 VA: 0x2724D90
	|-EnumAsStringFormatter<Nullable<Rect>>.Serialize
	|
	|-RVA: 0x27C8DF0 Offset: 0x27C8EF1 VA: 0x27C8DF0
	|-EnumAsStringFormatter<Nullable<RectInt>>.Serialize
	|
	|-RVA: 0x27C9970 Offset: 0x27C9A71 VA: 0x27C9970
	|-EnumAsStringFormatter<Nullable<Vector2>>.Serialize
	|
	|-RVA: 0x27CA4A0 Offset: 0x27CA5A1 VA: 0x27CA4A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Serialize
	|
	|-RVA: 0x27CAFB0 Offset: 0x27CB0B1 VA: 0x27CAFB0
	|-EnumAsStringFormatter<Nullable<Vector3>>.Serialize
	|
	|-RVA: 0x27CBAB0 Offset: 0x27CBBB1 VA: 0x27CBAB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Serialize
	|
	|-RVA: 0x27CC5E0 Offset: 0x27CC6E1 VA: 0x27CC5E0
	|-EnumAsStringFormatter<Nullable<Vector4>>.Serialize
	|
	|-RVA: 0x27CD150 Offset: 0x27CD251 VA: 0x27CD150
	|-EnumAsStringFormatter<object>.Serialize
	|
	|-RVA: 0x27CDC20 Offset: 0x27CDD21 VA: 0x27CDC20
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Serialize
	|
	|-RVA: 0x27CE740 Offset: 0x27CE841 VA: 0x27CE740
	|-EnumAsStringFormatter<sbyte>.Serialize
	|
	|-RVA: 0x27CF250 Offset: 0x27CF351 VA: 0x27CF250
	|-EnumAsStringFormatter<float>.Serialize
	|
	|-RVA: 0x27CFD40 Offset: 0x27CFE41 VA: 0x27CFD40
	|-EnumAsStringFormatter<ushort>.Serialize
	|
	|-RVA: 0x27D0830 Offset: 0x27D0931 VA: 0x27D0830
	|-EnumAsStringFormatter<uint>.Serialize
	|
	|-RVA: 0x27D1320 Offset: 0x27D1421 VA: 0x27D1320
	|-EnumAsStringFormatter<ulong>.Serialize
	|
	|-RVA: 0x27D1E70 Offset: 0x27D1F71 VA: 0x27D1E70
	|-EnumAsStringFormatter<Bounds>.Serialize
	|
	|-RVA: 0x27D2A10 Offset: 0x27D2B11 VA: 0x27D2A10
	|-EnumAsStringFormatter<BoundsInt>.Serialize
	|
	|-RVA: 0x27D3540 Offset: 0x27D3641 VA: 0x27D3540
	|-EnumAsStringFormatter<Color32>.Serialize
	|
	|-RVA: 0x27D4070 Offset: 0x27D4171 VA: 0x27D4070
	|-EnumAsStringFormatter<Color>.Serialize
	|
	|-RVA: 0x27D4BA0 Offset: 0x27D4CA1 VA: 0x27D4BA0
	|-EnumAsStringFormatter<GradientAlphaKey>.Serialize
	|
	|-RVA: 0x27D5760 Offset: 0x27D5861 VA: 0x27D5760
	|-EnumAsStringFormatter<GradientColorKey>.Serialize
	|
	|-RVA: 0x27D6370 Offset: 0x27D6471 VA: 0x27D6370
	|-EnumAsStringFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x27D6F20 Offset: 0x27D7021 VA: 0x27D6F20
	|-EnumAsStringFormatter<LayerMask>.Serialize
	|
	|-RVA: 0x27D7B10 Offset: 0x27D7C11 VA: 0x27D7B10
	|-EnumAsStringFormatter<Matrix4x4>.Serialize
	|
	|-RVA: 0x27D86D0 Offset: 0x27D87D1 VA: 0x27D86D0
	|-EnumAsStringFormatter<Quaternion>.Serialize
	|
	|-RVA: 0x27D91E0 Offset: 0x27D92E1 VA: 0x27D91E0
	|-EnumAsStringFormatter<RangeInt>.Serialize
	|
	|-RVA: 0x27D9D50 Offset: 0x27D9E51 VA: 0x27D9D50
	|-EnumAsStringFormatter<Rect>.Serialize
	|
	|-RVA: 0x27DA850 Offset: 0x27DA951 VA: 0x27DA850
	|-EnumAsStringFormatter<RectInt>.Serialize
	|
	|-RVA: 0x27DB370 Offset: 0x27DB471 VA: 0x27DB370
	|-EnumAsStringFormatter<Vector2>.Serialize
	|
	|-RVA: 0x27DBE80 Offset: 0x27DBF81 VA: 0x27DBE80
	|-EnumAsStringFormatter<Vector2Int>.Serialize
	|
	|-RVA: 0x27DC990 Offset: 0x27DCA91 VA: 0x27DC990
	|-EnumAsStringFormatter<Vector3>.Serialize
	|
	|-RVA: 0x27DD4C0 Offset: 0x27DD5C1 VA: 0x27DD4C0
	|-EnumAsStringFormatter<Vector3Int>.Serialize
	|
	|-RVA: 0x27DE010 Offset: 0x27DE111 VA: 0x27DE010
	|-EnumAsStringFormatter<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D4C0 Offset: 0x270D5C1 VA: 0x270D4C0
	|-EnumAsStringFormatter<BitVector32Int>.Deserialize
	|
	|-RVA: 0x270E090 Offset: 0x270E191 VA: 0x270E090
	|-EnumAsStringFormatter<EventCheckId>.Deserialize
	|
	|-RVA: 0x270ED30 Offset: 0x270EE31 VA: 0x270ED30
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Deserialize
	|
	|-RVA: 0x270F930 Offset: 0x270FA31 VA: 0x270F930
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Deserialize
	|
	|-RVA: 0x27104B0 Offset: 0x27105B1 VA: 0x27104B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Deserialize
	|
	|-RVA: 0x2710FF0 Offset: 0x27110F1 VA: 0x2710FF0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Deserialize
	|
	|-RVA: 0x2711C00 Offset: 0x2711D01 VA: 0x2711C00
	|-EnumAsStringFormatter<MonsterHutSaveData>.Deserialize
	|
	|-RVA: 0x2712790 Offset: 0x2712891 VA: 0x2712790
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Deserialize
	|
	|-RVA: 0x27133B0 Offset: 0x27134B1 VA: 0x27133B0
	|-EnumAsStringFormatter<OrderSaveData>.Deserialize
	|
	|-RVA: 0x2713FB0 Offset: 0x27140B1 VA: 0x2713FB0
	|-EnumAsStringFormatter<OrderSaveParameter>.Deserialize
	|
	|-RVA: 0x2714BF0 Offset: 0x2714CF1 VA: 0x2714BF0
	|-EnumAsStringFormatter<Parameter>.Deserialize
	|
	|-RVA: 0x2715740 Offset: 0x2715841 VA: 0x2715740
	|-EnumAsStringFormatter<bool>.Deserialize
	|
	|-RVA: 0x2716230 Offset: 0x2716331 VA: 0x2716230
	|-EnumAsStringFormatter<byte>.Deserialize
	|
	|-RVA: 0x2716D20 Offset: 0x2716E21 VA: 0x2716D20
	|-EnumAsStringFormatter<char>.Deserialize
	|
	|-RVA: 0x2717800 Offset: 0x2717901 VA: 0x2717800
	|-EnumAsStringFormatter<DateTime>.Deserialize
	|
	|-RVA: 0x2718310 Offset: 0x2718411 VA: 0x2718310
	|-EnumAsStringFormatter<double>.Deserialize
	|
	|-RVA: 0x2718E00 Offset: 0x2718F01 VA: 0x2718E00
	|-EnumAsStringFormatter<short>.Deserialize
	|
	|-RVA: 0x27198F0 Offset: 0x27199F1 VA: 0x27198F0
	|-EnumAsStringFormatter<int>.Deserialize
	|
	|-RVA: 0x271A400 Offset: 0x271A501 VA: 0x271A400
	|-EnumAsStringFormatter<Int32Enum>.Deserialize
	|
	|-RVA: 0x271AEE0 Offset: 0x271AFE1 VA: 0x271AEE0
	|-EnumAsStringFormatter<long>.Deserialize
	|
	|-RVA: 0x271B9F0 Offset: 0x271BAF1 VA: 0x271B9F0
	|-EnumAsStringFormatter<Memory<object>>.Deserialize
	|
	|-RVA: 0x271C4E0 Offset: 0x271C5E1 VA: 0x271C4E0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Deserialize
	|
	|-RVA: 0x271D090 Offset: 0x271D191 VA: 0x271D090
	|-EnumAsStringFormatter<Nullable<Bounds>>.Deserialize
	|
	|-RVA: 0x271DC70 Offset: 0x271DD71 VA: 0x271DC70
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Deserialize
	|
	|-RVA: 0x271E780 Offset: 0x271E881 VA: 0x271E780
	|-EnumAsStringFormatter<Nullable<Color32>>.Deserialize
	|
	|-RVA: 0x271F2F0 Offset: 0x271F3F1 VA: 0x271F2F0
	|-EnumAsStringFormatter<Nullable<Color>>.Deserialize
	|
	|-RVA: 0x271FE30 Offset: 0x271FF31 VA: 0x271FE30
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Deserialize
	|
	|-RVA: 0x27209B0 Offset: 0x2720AB1 VA: 0x27209B0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Deserialize
	|
	|-RVA: 0x2721530 Offset: 0x2721631 VA: 0x2721530
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Deserialize
	|
	|-RVA: 0x2722030 Offset: 0x2722131 VA: 0x2722030
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Deserialize
	|
	|-RVA: 0x2722CA0 Offset: 0x2722DA1 VA: 0x2722CA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Deserialize
	|
	|-RVA: 0x2723870 Offset: 0x2723971 VA: 0x2723870
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Deserialize
	|
	|-RVA: 0x27243B0 Offset: 0x27244B1 VA: 0x27243B0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Deserialize
	|
	|-RVA: 0x2724F30 Offset: 0x2725031 VA: 0x2724F30
	|-EnumAsStringFormatter<Nullable<Rect>>.Deserialize
	|
	|-RVA: 0x27C8F90 Offset: 0x27C9091 VA: 0x27C8F90
	|-EnumAsStringFormatter<Nullable<RectInt>>.Deserialize
	|
	|-RVA: 0x27C9AD0 Offset: 0x27C9BD1 VA: 0x27C9AD0
	|-EnumAsStringFormatter<Nullable<Vector2>>.Deserialize
	|
	|-RVA: 0x27CA600 Offset: 0x27CA701 VA: 0x27CA600
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Deserialize
	|
	|-RVA: 0x27CB110 Offset: 0x27CB211 VA: 0x27CB110
	|-EnumAsStringFormatter<Nullable<Vector3>>.Deserialize
	|
	|-RVA: 0x27CBC10 Offset: 0x27CBD11 VA: 0x27CBC10
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Deserialize
	|
	|-RVA: 0x27CC780 Offset: 0x27CC881 VA: 0x27CC780
	|-EnumAsStringFormatter<Nullable<Vector4>>.Deserialize
	|
	|-RVA: 0x27CD280 Offset: 0x27CD381 VA: 0x27CD280
	|-EnumAsStringFormatter<object>.Deserialize
	|
	|-RVA: 0x27CDD80 Offset: 0x27CDE81 VA: 0x27CDD80
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Deserialize
	|
	|-RVA: 0x27CE870 Offset: 0x27CE971 VA: 0x27CE870
	|-EnumAsStringFormatter<sbyte>.Deserialize
	|
	|-RVA: 0x27CF380 Offset: 0x27CF481 VA: 0x27CF380
	|-EnumAsStringFormatter<float>.Deserialize
	|
	|-RVA: 0x27CFE70 Offset: 0x27CFF71 VA: 0x27CFE70
	|-EnumAsStringFormatter<ushort>.Deserialize
	|
	|-RVA: 0x27D0960 Offset: 0x27D0A61 VA: 0x27D0960
	|-EnumAsStringFormatter<uint>.Deserialize
	|
	|-RVA: 0x27D1440 Offset: 0x27D1541 VA: 0x27D1440
	|-EnumAsStringFormatter<ulong>.Deserialize
	|
	|-RVA: 0x27D1FC0 Offset: 0x27D20C1 VA: 0x27D1FC0
	|-EnumAsStringFormatter<Bounds>.Deserialize
	|
	|-RVA: 0x27D2B60 Offset: 0x27D2C61 VA: 0x27D2B60
	|-EnumAsStringFormatter<BoundsInt>.Deserialize
	|
	|-RVA: 0x27D3670 Offset: 0x27D3771 VA: 0x27D3670
	|-EnumAsStringFormatter<Color32>.Deserialize
	|
	|-RVA: 0x27D41C0 Offset: 0x27D42C1 VA: 0x27D41C0
	|-EnumAsStringFormatter<Color>.Deserialize
	|
	|-RVA: 0x27D4D20 Offset: 0x27D4E21 VA: 0x27D4D20
	|-EnumAsStringFormatter<GradientAlphaKey>.Deserialize
	|
	|-RVA: 0x27D5900 Offset: 0x27D5A01 VA: 0x27D5900
	|-EnumAsStringFormatter<GradientColorKey>.Deserialize
	|
	|-RVA: 0x27D6530 Offset: 0x27D6631 VA: 0x27D6530
	|-EnumAsStringFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x27D7090 Offset: 0x27D7191 VA: 0x27D7090
	|-EnumAsStringFormatter<LayerMask>.Deserialize
	|
	|-RVA: 0x27D7CA0 Offset: 0x27D7DA1 VA: 0x27D7CA0
	|-EnumAsStringFormatter<Matrix4x4>.Deserialize
	|
	|-RVA: 0x27D8820 Offset: 0x27D8921 VA: 0x27D8820
	|-EnumAsStringFormatter<Quaternion>.Deserialize
	|
	|-RVA: 0x27D9350 Offset: 0x27D9451 VA: 0x27D9350
	|-EnumAsStringFormatter<RangeInt>.Deserialize
	|
	|-RVA: 0x27D9EA0 Offset: 0x27D9FA1 VA: 0x27D9EA0
	|-EnumAsStringFormatter<Rect>.Deserialize
	|
	|-RVA: 0x27DA990 Offset: 0x27DAA91 VA: 0x27DA990
	|-EnumAsStringFormatter<RectInt>.Deserialize
	|
	|-RVA: 0x27DB4B0 Offset: 0x27DB5B1 VA: 0x27DB4B0
	|-EnumAsStringFormatter<Vector2>.Deserialize
	|
	|-RVA: 0x27DBFA0 Offset: 0x27DC0A1 VA: 0x27DBFA0
	|-EnumAsStringFormatter<Vector2Int>.Deserialize
	|
	|-RVA: 0x27DCAE0 Offset: 0x27DCBE1 VA: 0x27DCAE0
	|-EnumAsStringFormatter<Vector3>.Deserialize
	|
	|-RVA: 0x27DD600 Offset: 0x27DD701 VA: 0x27DD600
	|-EnumAsStringFormatter<Vector3Int>.Deserialize
	|
	|-RVA: 0x27DE160 Offset: 0x27DE261 VA: 0x27DE160
	|-EnumAsStringFormatter<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	private string GetClrNames(string serializedNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D6B0 Offset: 0x270D7B1 VA: 0x270D6B0
	|-EnumAsStringFormatter<BitVector32Int>.GetClrNames
	|
	|-RVA: 0x270E2A0 Offset: 0x270E3A1 VA: 0x270E2A0
	|-EnumAsStringFormatter<EventCheckId>.GetClrNames
	|
	|-RVA: 0x270EF50 Offset: 0x270F051 VA: 0x270EF50
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetClrNames
	|
	|-RVA: 0x270FB40 Offset: 0x270FC41 VA: 0x270FB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetClrNames
	|
	|-RVA: 0x27106B0 Offset: 0x27107B1 VA: 0x27106B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetClrNames
	|
	|-RVA: 0x27111E0 Offset: 0x27112E1 VA: 0x27111E0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetClrNames
	|
	|-RVA: 0x2711E20 Offset: 0x2711F21 VA: 0x2711E20
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetClrNames
	|
	|-RVA: 0x2712990 Offset: 0x2712A91 VA: 0x2712990
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetClrNames
	|
	|-RVA: 0x27135D0 Offset: 0x27136D1 VA: 0x27135D0
	|-EnumAsStringFormatter<OrderSaveData>.GetClrNames
	|
	|-RVA: 0x27141C0 Offset: 0x27142C1 VA: 0x27141C0
	|-EnumAsStringFormatter<OrderSaveParameter>.GetClrNames
	|
	|-RVA: 0x2714E30 Offset: 0x2714F31 VA: 0x2714E30
	|-EnumAsStringFormatter<Parameter>.GetClrNames
	|
	|-RVA: 0x2715930 Offset: 0x2715A31 VA: 0x2715930
	|-EnumAsStringFormatter<bool>.GetClrNames
	|
	|-RVA: 0x2716420 Offset: 0x2716521 VA: 0x2716420
	|-EnumAsStringFormatter<byte>.GetClrNames
	|
	|-RVA: 0x2716F10 Offset: 0x2717011 VA: 0x2716F10
	|-EnumAsStringFormatter<char>.GetClrNames
	|
	|-RVA: 0x27179F0 Offset: 0x2717AF1 VA: 0x27179F0
	|-EnumAsStringFormatter<DateTime>.GetClrNames
	|
	|-RVA: 0x2718500 Offset: 0x2718601 VA: 0x2718500
	|-EnumAsStringFormatter<double>.GetClrNames
	|
	|-RVA: 0x2718FF0 Offset: 0x27190F1 VA: 0x2718FF0
	|-EnumAsStringFormatter<short>.GetClrNames
	|
	|-RVA: 0x2719AE0 Offset: 0x2719BE1 VA: 0x2719AE0
	|-EnumAsStringFormatter<int>.GetClrNames
	|
	|-RVA: 0x271A5F0 Offset: 0x271A6F1 VA: 0x271A5F0
	|-EnumAsStringFormatter<Int32Enum>.GetClrNames
	|
	|-RVA: 0x271B0D0 Offset: 0x271B1D1 VA: 0x271B0D0
	|-EnumAsStringFormatter<long>.GetClrNames
	|
	|-RVA: 0x271BBE0 Offset: 0x271BCE1 VA: 0x271BBE0
	|-EnumAsStringFormatter<Memory<object>>.GetClrNames
	|
	|-RVA: 0x271C6C0 Offset: 0x271C7C1 VA: 0x271C6C0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetClrNames
	|
	|-RVA: 0x271D2A0 Offset: 0x271D3A1 VA: 0x271D2A0
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetClrNames
	|
	|-RVA: 0x271DE80 Offset: 0x271DF81 VA: 0x271DE80
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetClrNames
	|
	|-RVA: 0x271E960 Offset: 0x271EA61 VA: 0x271E960
	|-EnumAsStringFormatter<Nullable<Color32>>.GetClrNames
	|
	|-RVA: 0x271F4F0 Offset: 0x271F5F1 VA: 0x271F4F0
	|-EnumAsStringFormatter<Nullable<Color>>.GetClrNames
	|
	|-RVA: 0x2720020 Offset: 0x2720121 VA: 0x2720020
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetClrNames
	|
	|-RVA: 0x2720BB0 Offset: 0x2720CB1 VA: 0x2720BB0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetClrNames
	|
	|-RVA: 0x2721730 Offset: 0x2721831 VA: 0x2721730
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetClrNames
	|
	|-RVA: 0x2722210 Offset: 0x2722311 VA: 0x2722210
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetClrNames
	|
	|-RVA: 0x2722EE0 Offset: 0x2722FE1 VA: 0x2722EE0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetClrNames
	|
	|-RVA: 0x2723A70 Offset: 0x2723B71 VA: 0x2723A70
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetClrNames
	|
	|-RVA: 0x27245A0 Offset: 0x27246A1 VA: 0x27245A0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetClrNames
	|
	|-RVA: 0x2725130 Offset: 0x2725231 VA: 0x2725130
	|-EnumAsStringFormatter<Nullable<Rect>>.GetClrNames
	|
	|-RVA: 0x27C9190 Offset: 0x27C9291 VA: 0x27C9190
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetClrNames
	|
	|-RVA: 0x27C9CC0 Offset: 0x27C9DC1 VA: 0x27C9CC0
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetClrNames
	|
	|-RVA: 0x27CA7F0 Offset: 0x27CA8F1 VA: 0x27CA7F0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetClrNames
	|
	|-RVA: 0x27CB2F0 Offset: 0x27CB3F1 VA: 0x27CB2F0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetClrNames
	|
	|-RVA: 0x27CBDF0 Offset: 0x27CBEF1 VA: 0x27CBDF0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetClrNames
	|
	|-RVA: 0x27CC980 Offset: 0x27CCA81 VA: 0x27CC980
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetClrNames
	|
	|-RVA: 0x27CD460 Offset: 0x27CD561 VA: 0x27CD460
	|-EnumAsStringFormatter<object>.GetClrNames
	|
	|-RVA: 0x27CDF70 Offset: 0x27CE071 VA: 0x27CDF70
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetClrNames
	|
	|-RVA: 0x27CEA60 Offset: 0x27CEB61 VA: 0x27CEA60
	|-EnumAsStringFormatter<sbyte>.GetClrNames
	|
	|-RVA: 0x27CF570 Offset: 0x27CF671 VA: 0x27CF570
	|-EnumAsStringFormatter<float>.GetClrNames
	|
	|-RVA: 0x27D0060 Offset: 0x27D0161 VA: 0x27D0060
	|-EnumAsStringFormatter<ushort>.GetClrNames
	|
	|-RVA: 0x27D0B50 Offset: 0x27D0C51 VA: 0x27D0B50
	|-EnumAsStringFormatter<uint>.GetClrNames
	|
	|-RVA: 0x27D1630 Offset: 0x27D1731 VA: 0x27D1630
	|-EnumAsStringFormatter<ulong>.GetClrNames
	|
	|-RVA: 0x27D21D0 Offset: 0x27D22D1 VA: 0x27D21D0
	|-EnumAsStringFormatter<Bounds>.GetClrNames
	|
	|-RVA: 0x27D2D70 Offset: 0x27D2E71 VA: 0x27D2D70
	|-EnumAsStringFormatter<BoundsInt>.GetClrNames
	|
	|-RVA: 0x27D3860 Offset: 0x27D3961 VA: 0x27D3860
	|-EnumAsStringFormatter<Color32>.GetClrNames
	|
	|-RVA: 0x27D43B0 Offset: 0x27D44B1 VA: 0x27D43B0
	|-EnumAsStringFormatter<Color>.GetClrNames
	|
	|-RVA: 0x27D4F20 Offset: 0x27D5021 VA: 0x27D4F20
	|-EnumAsStringFormatter<GradientAlphaKey>.GetClrNames
	|
	|-RVA: 0x27D5B10 Offset: 0x27D5C11 VA: 0x27D5B10
	|-EnumAsStringFormatter<GradientColorKey>.GetClrNames
	|
	|-RVA: 0x27D6750 Offset: 0x27D6851 VA: 0x27D6750
	|-EnumAsStringFormatter<Keyframe>.GetClrNames
	|
	|-RVA: 0x27D7280 Offset: 0x27D7381 VA: 0x27D7280
	|-EnumAsStringFormatter<LayerMask>.GetClrNames
	|
	|-RVA: 0x27D7EC0 Offset: 0x27D7FC1 VA: 0x27D7EC0
	|-EnumAsStringFormatter<Matrix4x4>.GetClrNames
	|
	|-RVA: 0x27D8A10 Offset: 0x27D8B11 VA: 0x27D8A10
	|-EnumAsStringFormatter<Quaternion>.GetClrNames
	|
	|-RVA: 0x27D9540 Offset: 0x27D9641 VA: 0x27D9540
	|-EnumAsStringFormatter<RangeInt>.GetClrNames
	|
	|-RVA: 0x27DA090 Offset: 0x27DA191 VA: 0x27DA090
	|-EnumAsStringFormatter<Rect>.GetClrNames
	|
	|-RVA: 0x27DAB80 Offset: 0x27DAC81 VA: 0x27DAB80
	|-EnumAsStringFormatter<RectInt>.GetClrNames
	|
	|-RVA: 0x27DB6B0 Offset: 0x27DB7B1 VA: 0x27DB6B0
	|-EnumAsStringFormatter<Vector2>.GetClrNames
	|
	|-RVA: 0x27DC190 Offset: 0x27DC291 VA: 0x27DC190
	|-EnumAsStringFormatter<Vector2Int>.GetClrNames
	|
	|-RVA: 0x27DCCE0 Offset: 0x27DCDE1 VA: 0x27DCCE0
	|-EnumAsStringFormatter<Vector3>.GetClrNames
	|
	|-RVA: 0x27DD800 Offset: 0x27DD901 VA: 0x27DD800
	|-EnumAsStringFormatter<Vector3Int>.GetClrNames
	|
	|-RVA: 0x27DE350 Offset: 0x27DE451 VA: 0x27DE350
	|-EnumAsStringFormatter<Vector4>.GetClrNames
	*/

	// RVA: -1 Offset: -1
	private string GetSerializedNames(string clrNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D770 Offset: 0x270D871 VA: 0x270D770
	|-EnumAsStringFormatter<BitVector32Int>.GetSerializedNames
	|
	|-RVA: 0x270E360 Offset: 0x270E461 VA: 0x270E360
	|-EnumAsStringFormatter<EventCheckId>.GetSerializedNames
	|
	|-RVA: 0x270F010 Offset: 0x270F111 VA: 0x270F010
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetSerializedNames
	|
	|-RVA: 0x270FC00 Offset: 0x270FD01 VA: 0x270FC00
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetSerializedNames
	|
	|-RVA: 0x2710770 Offset: 0x2710871 VA: 0x2710770
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetSerializedNames
	|
	|-RVA: 0x27112A0 Offset: 0x27113A1 VA: 0x27112A0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetSerializedNames
	|
	|-RVA: 0x2711EE0 Offset: 0x2711FE1 VA: 0x2711EE0
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetSerializedNames
	|
	|-RVA: 0x2712A50 Offset: 0x2712B51 VA: 0x2712A50
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2713690 Offset: 0x2713791 VA: 0x2713690
	|-EnumAsStringFormatter<OrderSaveData>.GetSerializedNames
	|
	|-RVA: 0x2714280 Offset: 0x2714381 VA: 0x2714280
	|-EnumAsStringFormatter<OrderSaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2714EF0 Offset: 0x2714FF1 VA: 0x2714EF0
	|-EnumAsStringFormatter<Parameter>.GetSerializedNames
	|
	|-RVA: 0x27159F0 Offset: 0x2715AF1 VA: 0x27159F0
	|-EnumAsStringFormatter<bool>.GetSerializedNames
	|
	|-RVA: 0x27164E0 Offset: 0x27165E1 VA: 0x27164E0
	|-EnumAsStringFormatter<byte>.GetSerializedNames
	|
	|-RVA: 0x2716FD0 Offset: 0x27170D1 VA: 0x2716FD0
	|-EnumAsStringFormatter<char>.GetSerializedNames
	|
	|-RVA: 0x2717AB0 Offset: 0x2717BB1 VA: 0x2717AB0
	|-EnumAsStringFormatter<DateTime>.GetSerializedNames
	|
	|-RVA: 0x27185C0 Offset: 0x27186C1 VA: 0x27185C0
	|-EnumAsStringFormatter<double>.GetSerializedNames
	|
	|-RVA: 0x27190B0 Offset: 0x27191B1 VA: 0x27190B0
	|-EnumAsStringFormatter<short>.GetSerializedNames
	|
	|-RVA: 0x2719BA0 Offset: 0x2719CA1 VA: 0x2719BA0
	|-EnumAsStringFormatter<int>.GetSerializedNames
	|
	|-RVA: 0x271A6B0 Offset: 0x271A7B1 VA: 0x271A6B0
	|-EnumAsStringFormatter<Int32Enum>.GetSerializedNames
	|
	|-RVA: 0x271B190 Offset: 0x271B291 VA: 0x271B190
	|-EnumAsStringFormatter<long>.GetSerializedNames
	|
	|-RVA: 0x271BCA0 Offset: 0x271BDA1 VA: 0x271BCA0
	|-EnumAsStringFormatter<Memory<object>>.GetSerializedNames
	|
	|-RVA: 0x271C780 Offset: 0x271C881 VA: 0x271C780
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetSerializedNames
	|
	|-RVA: 0x271D360 Offset: 0x271D461 VA: 0x271D360
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetSerializedNames
	|
	|-RVA: 0x271DF40 Offset: 0x271E041 VA: 0x271DF40
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetSerializedNames
	|
	|-RVA: 0x271EA20 Offset: 0x271EB21 VA: 0x271EA20
	|-EnumAsStringFormatter<Nullable<Color32>>.GetSerializedNames
	|
	|-RVA: 0x271F5B0 Offset: 0x271F6B1 VA: 0x271F5B0
	|-EnumAsStringFormatter<Nullable<Color>>.GetSerializedNames
	|
	|-RVA: 0x27200E0 Offset: 0x27201E1 VA: 0x27200E0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetSerializedNames
	|
	|-RVA: 0x2720C70 Offset: 0x2720D71 VA: 0x2720C70
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetSerializedNames
	|
	|-RVA: 0x27217F0 Offset: 0x27218F1 VA: 0x27217F0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetSerializedNames
	|
	|-RVA: 0x27222D0 Offset: 0x27223D1 VA: 0x27222D0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetSerializedNames
	|
	|-RVA: 0x2722FA0 Offset: 0x27230A1 VA: 0x2722FA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetSerializedNames
	|
	|-RVA: 0x2723B30 Offset: 0x2723C31 VA: 0x2723B30
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetSerializedNames
	|
	|-RVA: 0x2724660 Offset: 0x2724761 VA: 0x2724660
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetSerializedNames
	|
	|-RVA: 0x27251F0 Offset: 0x27252F1 VA: 0x27251F0
	|-EnumAsStringFormatter<Nullable<Rect>>.GetSerializedNames
	|
	|-RVA: 0x27C9250 Offset: 0x27C9351 VA: 0x27C9250
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetSerializedNames
	|
	|-RVA: 0x27C9D80 Offset: 0x27C9E81 VA: 0x27C9D80
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetSerializedNames
	|
	|-RVA: 0x27CA8B0 Offset: 0x27CA9B1 VA: 0x27CA8B0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetSerializedNames
	|
	|-RVA: 0x27CB3B0 Offset: 0x27CB4B1 VA: 0x27CB3B0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetSerializedNames
	|
	|-RVA: 0x27CBEB0 Offset: 0x27CBFB1 VA: 0x27CBEB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetSerializedNames
	|
	|-RVA: 0x27CCA40 Offset: 0x27CCB41 VA: 0x27CCA40
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetSerializedNames
	|
	|-RVA: 0x27CD520 Offset: 0x27CD621 VA: 0x27CD520
	|-EnumAsStringFormatter<object>.GetSerializedNames
	|
	|-RVA: 0x27CE030 Offset: 0x27CE131 VA: 0x27CE030
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetSerializedNames
	|
	|-RVA: 0x27CEB20 Offset: 0x27CEC21 VA: 0x27CEB20
	|-EnumAsStringFormatter<sbyte>.GetSerializedNames
	|
	|-RVA: 0x27CF630 Offset: 0x27CF731 VA: 0x27CF630
	|-EnumAsStringFormatter<float>.GetSerializedNames
	|
	|-RVA: 0x27D0120 Offset: 0x27D0221 VA: 0x27D0120
	|-EnumAsStringFormatter<ushort>.GetSerializedNames
	|
	|-RVA: 0x27D0C10 Offset: 0x27D0D11 VA: 0x27D0C10
	|-EnumAsStringFormatter<uint>.GetSerializedNames
	|
	|-RVA: 0x27D16F0 Offset: 0x27D17F1 VA: 0x27D16F0
	|-EnumAsStringFormatter<ulong>.GetSerializedNames
	|
	|-RVA: 0x27D2290 Offset: 0x27D2391 VA: 0x27D2290
	|-EnumAsStringFormatter<Bounds>.GetSerializedNames
	|
	|-RVA: 0x27D2E30 Offset: 0x27D2F31 VA: 0x27D2E30
	|-EnumAsStringFormatter<BoundsInt>.GetSerializedNames
	|
	|-RVA: 0x27D3920 Offset: 0x27D3A21 VA: 0x27D3920
	|-EnumAsStringFormatter<Color32>.GetSerializedNames
	|
	|-RVA: 0x27D4470 Offset: 0x27D4571 VA: 0x27D4470
	|-EnumAsStringFormatter<Color>.GetSerializedNames
	|
	|-RVA: 0x27D4FE0 Offset: 0x27D50E1 VA: 0x27D4FE0
	|-EnumAsStringFormatter<GradientAlphaKey>.GetSerializedNames
	|
	|-RVA: 0x27D5BD0 Offset: 0x27D5CD1 VA: 0x27D5BD0
	|-EnumAsStringFormatter<GradientColorKey>.GetSerializedNames
	|
	|-RVA: 0x27D6810 Offset: 0x27D6911 VA: 0x27D6810
	|-EnumAsStringFormatter<Keyframe>.GetSerializedNames
	|
	|-RVA: 0x27D7340 Offset: 0x27D7441 VA: 0x27D7340
	|-EnumAsStringFormatter<LayerMask>.GetSerializedNames
	|
	|-RVA: 0x27D7F80 Offset: 0x27D8081 VA: 0x27D7F80
	|-EnumAsStringFormatter<Matrix4x4>.GetSerializedNames
	|
	|-RVA: 0x27D8AD0 Offset: 0x27D8BD1 VA: 0x27D8AD0
	|-EnumAsStringFormatter<Quaternion>.GetSerializedNames
	|
	|-RVA: 0x27D9600 Offset: 0x27D9701 VA: 0x27D9600
	|-EnumAsStringFormatter<RangeInt>.GetSerializedNames
	|
	|-RVA: 0x27DA150 Offset: 0x27DA251 VA: 0x27DA150
	|-EnumAsStringFormatter<Rect>.GetSerializedNames
	|
	|-RVA: 0x27DAC40 Offset: 0x27DAD41 VA: 0x27DAC40
	|-EnumAsStringFormatter<RectInt>.GetSerializedNames
	|
	|-RVA: 0x27DB770 Offset: 0x27DB871 VA: 0x27DB770
	|-EnumAsStringFormatter<Vector2>.GetSerializedNames
	|
	|-RVA: 0x27DC250 Offset: 0x27DC351 VA: 0x27DC250
	|-EnumAsStringFormatter<Vector2Int>.GetSerializedNames
	|
	|-RVA: 0x27DCDA0 Offset: 0x27DCEA1 VA: 0x27DCDA0
	|-EnumAsStringFormatter<Vector3>.GetSerializedNames
	|
	|-RVA: 0x27DD8C0 Offset: 0x27DD9C1 VA: 0x27DD8C0
	|-EnumAsStringFormatter<Vector3Int>.GetSerializedNames
	|
	|-RVA: 0x27DE410 Offset: 0x27DE511 VA: 0x27DE410
	|-EnumAsStringFormatter<Vector4>.GetSerializedNames
	*/

	// RVA: -1 Offset: -1
	private static string Translate(string items, IReadOnlyDictionary<string, string> mapping) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D830 Offset: 0x270D931 VA: 0x270D830
	|-EnumAsStringFormatter<BitVector32Int>.Translate
	|
	|-RVA: 0x270E420 Offset: 0x270E521 VA: 0x270E420
	|-EnumAsStringFormatter<EventCheckId>.Translate
	|
	|-RVA: 0x270F0D0 Offset: 0x270F1D1 VA: 0x270F0D0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Translate
	|
	|-RVA: 0x270FCC0 Offset: 0x270FDC1 VA: 0x270FCC0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Translate
	|
	|-RVA: 0x2710830 Offset: 0x2710931 VA: 0x2710830
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Translate
	|
	|-RVA: 0x2711360 Offset: 0x2711461 VA: 0x2711360
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Translate
	|
	|-RVA: 0x2711FA0 Offset: 0x27120A1 VA: 0x2711FA0
	|-EnumAsStringFormatter<MonsterHutSaveData>.Translate
	|
	|-RVA: 0x2712B10 Offset: 0x2712C11 VA: 0x2712B10
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Translate
	|
	|-RVA: 0x2713750 Offset: 0x2713851 VA: 0x2713750
	|-EnumAsStringFormatter<OrderSaveData>.Translate
	|
	|-RVA: 0x2714340 Offset: 0x2714441 VA: 0x2714340
	|-EnumAsStringFormatter<OrderSaveParameter>.Translate
	|
	|-RVA: 0x2714FB0 Offset: 0x27150B1 VA: 0x2714FB0
	|-EnumAsStringFormatter<Parameter>.Translate
	|
	|-RVA: 0x2715AB0 Offset: 0x2715BB1 VA: 0x2715AB0
	|-EnumAsStringFormatter<bool>.Translate
	|
	|-RVA: 0x27165A0 Offset: 0x27166A1 VA: 0x27165A0
	|-EnumAsStringFormatter<byte>.Translate
	|
	|-RVA: 0x2717090 Offset: 0x2717191 VA: 0x2717090
	|-EnumAsStringFormatter<char>.Translate
	|
	|-RVA: 0x2717B70 Offset: 0x2717C71 VA: 0x2717B70
	|-EnumAsStringFormatter<DateTime>.Translate
	|
	|-RVA: 0x2718680 Offset: 0x2718781 VA: 0x2718680
	|-EnumAsStringFormatter<double>.Translate
	|
	|-RVA: 0x2719170 Offset: 0x2719271 VA: 0x2719170
	|-EnumAsStringFormatter<short>.Translate
	|
	|-RVA: 0x2719C60 Offset: 0x2719D61 VA: 0x2719C60
	|-EnumAsStringFormatter<int>.Translate
	|
	|-RVA: 0x271A770 Offset: 0x271A871 VA: 0x271A770
	|-EnumAsStringFormatter<Int32Enum>.Translate
	|
	|-RVA: 0x271B250 Offset: 0x271B351 VA: 0x271B250
	|-EnumAsStringFormatter<long>.Translate
	|
	|-RVA: 0x271BD60 Offset: 0x271BE61 VA: 0x271BD60
	|-EnumAsStringFormatter<Memory<object>>.Translate
	|
	|-RVA: 0x271C840 Offset: 0x271C941 VA: 0x271C840
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Translate
	|
	|-RVA: 0x271D420 Offset: 0x271D521 VA: 0x271D420
	|-EnumAsStringFormatter<Nullable<Bounds>>.Translate
	|
	|-RVA: 0x271E000 Offset: 0x271E101 VA: 0x271E000
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Translate
	|
	|-RVA: 0x271EAE0 Offset: 0x271EBE1 VA: 0x271EAE0
	|-EnumAsStringFormatter<Nullable<Color32>>.Translate
	|
	|-RVA: 0x271F670 Offset: 0x271F771 VA: 0x271F670
	|-EnumAsStringFormatter<Nullable<Color>>.Translate
	|
	|-RVA: 0x27201A0 Offset: 0x27202A1 VA: 0x27201A0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Translate
	|
	|-RVA: 0x2720D30 Offset: 0x2720E31 VA: 0x2720D30
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Translate
	|
	|-RVA: 0x27218B0 Offset: 0x27219B1 VA: 0x27218B0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Translate
	|
	|-RVA: 0x2722390 Offset: 0x2722491 VA: 0x2722390
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Translate
	|
	|-RVA: 0x2723060 Offset: 0x2723161 VA: 0x2723060
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Translate
	|
	|-RVA: 0x2723BF0 Offset: 0x2723CF1 VA: 0x2723BF0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Translate
	|
	|-RVA: 0x2724720 Offset: 0x2724821 VA: 0x2724720
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Translate
	|
	|-RVA: 0x27252B0 Offset: 0x27253B1 VA: 0x27252B0
	|-EnumAsStringFormatter<Nullable<Rect>>.Translate
	|
	|-RVA: 0x27C9310 Offset: 0x27C9411 VA: 0x27C9310
	|-EnumAsStringFormatter<Nullable<RectInt>>.Translate
	|
	|-RVA: 0x27C9E40 Offset: 0x27C9F41 VA: 0x27C9E40
	|-EnumAsStringFormatter<Nullable<Vector2>>.Translate
	|
	|-RVA: 0x27CA970 Offset: 0x27CAA71 VA: 0x27CA970
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Translate
	|
	|-RVA: 0x27CB470 Offset: 0x27CB571 VA: 0x27CB470
	|-EnumAsStringFormatter<Nullable<Vector3>>.Translate
	|
	|-RVA: 0x27CBF70 Offset: 0x27CC071 VA: 0x27CBF70
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Translate
	|
	|-RVA: 0x27CCB00 Offset: 0x27CCC01 VA: 0x27CCB00
	|-EnumAsStringFormatter<Nullable<Vector4>>.Translate
	|
	|-RVA: 0x27CD5E0 Offset: 0x27CD6E1 VA: 0x27CD5E0
	|-EnumAsStringFormatter<object>.Translate
	|
	|-RVA: 0x27CE0F0 Offset: 0x27CE1F1 VA: 0x27CE0F0
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Translate
	|
	|-RVA: 0x27CEBE0 Offset: 0x27CECE1 VA: 0x27CEBE0
	|-EnumAsStringFormatter<sbyte>.Translate
	|
	|-RVA: 0x27CF6F0 Offset: 0x27CF7F1 VA: 0x27CF6F0
	|-EnumAsStringFormatter<float>.Translate
	|
	|-RVA: 0x27D01E0 Offset: 0x27D02E1 VA: 0x27D01E0
	|-EnumAsStringFormatter<ushort>.Translate
	|
	|-RVA: 0x27D0CD0 Offset: 0x27D0DD1 VA: 0x27D0CD0
	|-EnumAsStringFormatter<uint>.Translate
	|
	|-RVA: 0x27D17B0 Offset: 0x27D18B1 VA: 0x27D17B0
	|-EnumAsStringFormatter<ulong>.Translate
	|
	|-RVA: 0x27D2350 Offset: 0x27D2451 VA: 0x27D2350
	|-EnumAsStringFormatter<Bounds>.Translate
	|
	|-RVA: 0x27D2EF0 Offset: 0x27D2FF1 VA: 0x27D2EF0
	|-EnumAsStringFormatter<BoundsInt>.Translate
	|
	|-RVA: 0x27D39E0 Offset: 0x27D3AE1 VA: 0x27D39E0
	|-EnumAsStringFormatter<Color32>.Translate
	|
	|-RVA: 0x27D4530 Offset: 0x27D4631 VA: 0x27D4530
	|-EnumAsStringFormatter<Color>.Translate
	|
	|-RVA: 0x27D50A0 Offset: 0x27D51A1 VA: 0x27D50A0
	|-EnumAsStringFormatter<GradientAlphaKey>.Translate
	|
	|-RVA: 0x27D5C90 Offset: 0x27D5D91 VA: 0x27D5C90
	|-EnumAsStringFormatter<GradientColorKey>.Translate
	|
	|-RVA: 0x27D68D0 Offset: 0x27D69D1 VA: 0x27D68D0
	|-EnumAsStringFormatter<Keyframe>.Translate
	|
	|-RVA: 0x27D7400 Offset: 0x27D7501 VA: 0x27D7400
	|-EnumAsStringFormatter<LayerMask>.Translate
	|
	|-RVA: 0x27D8040 Offset: 0x27D8141 VA: 0x27D8040
	|-EnumAsStringFormatter<Matrix4x4>.Translate
	|
	|-RVA: 0x27D8B90 Offset: 0x27D8C91 VA: 0x27D8B90
	|-EnumAsStringFormatter<Quaternion>.Translate
	|
	|-RVA: 0x27D96C0 Offset: 0x27D97C1 VA: 0x27D96C0
	|-EnumAsStringFormatter<RangeInt>.Translate
	|
	|-RVA: 0x27DA210 Offset: 0x27DA311 VA: 0x27DA210
	|-EnumAsStringFormatter<Rect>.Translate
	|
	|-RVA: 0x27DAD00 Offset: 0x27DAE01 VA: 0x27DAD00
	|-EnumAsStringFormatter<RectInt>.Translate
	|
	|-RVA: 0x27DB830 Offset: 0x27DB931 VA: 0x27DB830
	|-EnumAsStringFormatter<Vector2>.Translate
	|
	|-RVA: 0x27DC310 Offset: 0x27DC411 VA: 0x27DC310
	|-EnumAsStringFormatter<Vector2Int>.Translate
	|
	|-RVA: 0x27DCE60 Offset: 0x27DCF61 VA: 0x27DCE60
	|-EnumAsStringFormatter<Vector3>.Translate
	|
	|-RVA: 0x27DD980 Offset: 0x27DDA81 VA: 0x27DD980
	|-EnumAsStringFormatter<Vector3Int>.Translate
	|
	|-RVA: 0x27DE4D0 Offset: 0x27DE5D1 VA: 0x27DE4D0
	|-EnumAsStringFormatter<Vector4>.Translate
	*/
}

public sealed class EnumAsStringFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter // TypeDefIndex: 5404
{
	// Fields
	private readonly IReadOnlyDictionary<string, T> nameValueMapping; // 0x0
	private readonly IReadOnlyDictionary<T, string> valueNameMapping; // 0x0
	private readonly IReadOnlyDictionary<string, string> clrToSerializationName; // 0x0
	private readonly IReadOnlyDictionary<string, string> serializationToClrName; // 0x0
	private readonly bool enumMemberOverridesPresent; // 0x0
	private readonly bool isFlags; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CFA0 Offset: 0x270D0A1 VA: 0x270CFA0
	|-EnumAsStringFormatter<BitVector32Int>..ctor
	|
	|-RVA: 0x270DA90 Offset: 0x270DB91 VA: 0x270DA90
	|-EnumAsStringFormatter<EventCheckId>..ctor
	|
	|-RVA: 0x270E680 Offset: 0x270E781 VA: 0x270E680
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x270F330 Offset: 0x270F431 VA: 0x270F330
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x270FF20 Offset: 0x2710021 VA: 0x270FF20
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2710A90 Offset: 0x2710B91 VA: 0x2710A90
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x27115C0 Offset: 0x27116C1 VA: 0x27115C0
	|-EnumAsStringFormatter<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2712200 Offset: 0x2712301 VA: 0x2712200
	|-EnumAsStringFormatter<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2712D70 Offset: 0x2712E71 VA: 0x2712D70
	|-EnumAsStringFormatter<OrderSaveData>..ctor
	|
	|-RVA: 0x27139B0 Offset: 0x2713AB1 VA: 0x27139B0
	|-EnumAsStringFormatter<OrderSaveParameter>..ctor
	|
	|-RVA: 0x27145A0 Offset: 0x27146A1 VA: 0x27145A0
	|-EnumAsStringFormatter<Parameter>..ctor
	|
	|-RVA: 0x2715210 Offset: 0x2715311 VA: 0x2715210
	|-EnumAsStringFormatter<bool>..ctor
	|
	|-RVA: 0x2715D10 Offset: 0x2715E11 VA: 0x2715D10
	|-EnumAsStringFormatter<byte>..ctor
	|
	|-RVA: 0x2716800 Offset: 0x2716901 VA: 0x2716800
	|-EnumAsStringFormatter<char>..ctor
	|
	|-RVA: 0x27172F0 Offset: 0x27173F1 VA: 0x27172F0
	|-EnumAsStringFormatter<DateTime>..ctor
	|
	|-RVA: 0x2717DD0 Offset: 0x2717ED1 VA: 0x2717DD0
	|-EnumAsStringFormatter<double>..ctor
	|
	|-RVA: 0x27188E0 Offset: 0x27189E1 VA: 0x27188E0
	|-EnumAsStringFormatter<short>..ctor
	|
	|-RVA: 0x27193D0 Offset: 0x27194D1 VA: 0x27193D0
	|-EnumAsStringFormatter<int>..ctor
	|
	|-RVA: 0x2719EC0 Offset: 0x2719FC1 VA: 0x2719EC0
	|-EnumAsStringFormatter<Int32Enum>..ctor
	|
	|-RVA: 0x271A9D0 Offset: 0x271AAD1 VA: 0x271A9D0
	|-EnumAsStringFormatter<long>..ctor
	|
	|-RVA: 0x271B4B0 Offset: 0x271B5B1 VA: 0x271B4B0
	|-EnumAsStringFormatter<Memory<object>>..ctor
	|
	|-RVA: 0x271BFC0 Offset: 0x271C0C1 VA: 0x271BFC0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x271CAA0 Offset: 0x271CBA1 VA: 0x271CAA0
	|-EnumAsStringFormatter<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x271D680 Offset: 0x271D781 VA: 0x271D680
	|-EnumAsStringFormatter<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x271E260 Offset: 0x271E361 VA: 0x271E260
	|-EnumAsStringFormatter<Nullable<Color32>>..ctor
	|
	|-RVA: 0x271ED40 Offset: 0x271EE41 VA: 0x271ED40
	|-EnumAsStringFormatter<Nullable<Color>>..ctor
	|
	|-RVA: 0x271F8D0 Offset: 0x271F9D1 VA: 0x271F8D0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2720400 Offset: 0x2720501 VA: 0x2720400
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2720F90 Offset: 0x2721091 VA: 0x2720F90
	|-EnumAsStringFormatter<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2721B10 Offset: 0x2721C11 VA: 0x2721B10
	|-EnumAsStringFormatter<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x27225F0 Offset: 0x27226F1 VA: 0x27225F0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x27232C0 Offset: 0x27233C1 VA: 0x27232C0
	|-EnumAsStringFormatter<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2723E50 Offset: 0x2723F51 VA: 0x2723E50
	|-EnumAsStringFormatter<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2724980 Offset: 0x2724A81 VA: 0x2724980
	|-EnumAsStringFormatter<Nullable<Rect>>..ctor
	|
	|-RVA: 0x27C89E0 Offset: 0x27C8AE1 VA: 0x27C89E0
	|-EnumAsStringFormatter<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x27C9570 Offset: 0x27C9671 VA: 0x27C9570
	|-EnumAsStringFormatter<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x27CA0A0 Offset: 0x27CA1A1 VA: 0x27CA0A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x27CABD0 Offset: 0x27CACD1 VA: 0x27CABD0
	|-EnumAsStringFormatter<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x27CB6D0 Offset: 0x27CB7D1 VA: 0x27CB6D0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x27CC1D0 Offset: 0x27CC2D1 VA: 0x27CC1D0
	|-EnumAsStringFormatter<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x27CCD60 Offset: 0x27CCE61 VA: 0x27CCD60
	|-EnumAsStringFormatter<object>..ctor
	|
	|-RVA: 0x27CD840 Offset: 0x27CD941 VA: 0x27CD840
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x27CE350 Offset: 0x27CE451 VA: 0x27CE350
	|-EnumAsStringFormatter<sbyte>..ctor
	|
	|-RVA: 0x27CEE40 Offset: 0x27CEF41 VA: 0x27CEE40
	|-EnumAsStringFormatter<float>..ctor
	|
	|-RVA: 0x27CF950 Offset: 0x27CFA51 VA: 0x27CF950
	|-EnumAsStringFormatter<ushort>..ctor
	|
	|-RVA: 0x27D0440 Offset: 0x27D0541 VA: 0x27D0440
	|-EnumAsStringFormatter<uint>..ctor
	|
	|-RVA: 0x27D0F30 Offset: 0x27D1031 VA: 0x27D0F30
	|-EnumAsStringFormatter<ulong>..ctor
	|
	|-RVA: 0x27D1A10 Offset: 0x27D1B11 VA: 0x27D1A10
	|-EnumAsStringFormatter<Bounds>..ctor
	|
	|-RVA: 0x27D25B0 Offset: 0x27D26B1 VA: 0x27D25B0
	|-EnumAsStringFormatter<BoundsInt>..ctor
	|
	|-RVA: 0x27D3150 Offset: 0x27D3251 VA: 0x27D3150
	|-EnumAsStringFormatter<Color32>..ctor
	|
	|-RVA: 0x27D3C40 Offset: 0x27D3D41 VA: 0x27D3C40
	|-EnumAsStringFormatter<Color>..ctor
	|
	|-RVA: 0x27D4790 Offset: 0x27D4891 VA: 0x27D4790
	|-EnumAsStringFormatter<GradientAlphaKey>..ctor
	|
	|-RVA: 0x27D5300 Offset: 0x27D5401 VA: 0x27D5300
	|-EnumAsStringFormatter<GradientColorKey>..ctor
	|
	|-RVA: 0x27D5EF0 Offset: 0x27D5FF1 VA: 0x27D5EF0
	|-EnumAsStringFormatter<Keyframe>..ctor
	|
	|-RVA: 0x27D6B30 Offset: 0x27D6C31 VA: 0x27D6B30
	|-EnumAsStringFormatter<LayerMask>..ctor
	|
	|-RVA: 0x27D7660 Offset: 0x27D7761 VA: 0x27D7660
	|-EnumAsStringFormatter<Matrix4x4>..ctor
	|
	|-RVA: 0x27D82A0 Offset: 0x27D83A1 VA: 0x27D82A0
	|-EnumAsStringFormatter<Quaternion>..ctor
	|
	|-RVA: 0x27D8DF0 Offset: 0x27D8EF1 VA: 0x27D8DF0
	|-EnumAsStringFormatter<RangeInt>..ctor
	|
	|-RVA: 0x27D9920 Offset: 0x27D9A21 VA: 0x27D9920
	|-EnumAsStringFormatter<Rect>..ctor
	|
	|-RVA: 0x27DA470 Offset: 0x27DA571 VA: 0x27DA470
	|-EnumAsStringFormatter<RectInt>..ctor
	|
	|-RVA: 0x27DAF60 Offset: 0x27DB061 VA: 0x27DAF60
	|-EnumAsStringFormatter<Vector2>..ctor
	|
	|-RVA: 0x27DBA90 Offset: 0x27DBB91 VA: 0x27DBA90
	|-EnumAsStringFormatter<Vector2Int>..ctor
	|
	|-RVA: 0x27DC570 Offset: 0x27DC671 VA: 0x27DC570
	|-EnumAsStringFormatter<Vector3>..ctor
	|
	|-RVA: 0x27DD0C0 Offset: 0x27DD1C1 VA: 0x27DD0C0
	|-EnumAsStringFormatter<Vector3Int>..ctor
	|
	|-RVA: 0x27DDBE0 Offset: 0x27DDCE1 VA: 0x27DDBE0
	|-EnumAsStringFormatter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D390 Offset: 0x270D491 VA: 0x270D390
	|-EnumAsStringFormatter<BitVector32Int>.Serialize
	|
	|-RVA: 0x270DEF0 Offset: 0x270DFF1 VA: 0x270DEF0
	|-EnumAsStringFormatter<EventCheckId>.Serialize
	|
	|-RVA: 0x270EB40 Offset: 0x270EC41 VA: 0x270EB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Serialize
	|
	|-RVA: 0x270F790 Offset: 0x270F891 VA: 0x270F790
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Serialize
	|
	|-RVA: 0x2710320 Offset: 0x2710421 VA: 0x2710320
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Serialize
	|
	|-RVA: 0x2710E70 Offset: 0x2710F71 VA: 0x2710E70
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Serialize
	|
	|-RVA: 0x2711A40 Offset: 0x2711B41 VA: 0x2711A40
	|-EnumAsStringFormatter<MonsterHutSaveData>.Serialize
	|
	|-RVA: 0x2712600 Offset: 0x2712701 VA: 0x2712600
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Serialize
	|
	|-RVA: 0x27131F0 Offset: 0x27132F1 VA: 0x27131F0
	|-EnumAsStringFormatter<OrderSaveData>.Serialize
	|
	|-RVA: 0x2713E10 Offset: 0x2713F11 VA: 0x2713E10
	|-EnumAsStringFormatter<OrderSaveParameter>.Serialize
	|
	|-RVA: 0x2714A40 Offset: 0x2714B41 VA: 0x2714A40
	|-EnumAsStringFormatter<Parameter>.Serialize
	|
	|-RVA: 0x2715610 Offset: 0x2715711 VA: 0x2715610
	|-EnumAsStringFormatter<bool>.Serialize
	|
	|-RVA: 0x2716100 Offset: 0x2716201 VA: 0x2716100
	|-EnumAsStringFormatter<byte>.Serialize
	|
	|-RVA: 0x2716BF0 Offset: 0x2716CF1 VA: 0x2716BF0
	|-EnumAsStringFormatter<char>.Serialize
	|
	|-RVA: 0x27176E0 Offset: 0x27177E1 VA: 0x27176E0
	|-EnumAsStringFormatter<DateTime>.Serialize
	|
	|-RVA: 0x27181E0 Offset: 0x27182E1 VA: 0x27181E0
	|-EnumAsStringFormatter<double>.Serialize
	|
	|-RVA: 0x2718CD0 Offset: 0x2718DD1 VA: 0x2718CD0
	|-EnumAsStringFormatter<short>.Serialize
	|
	|-RVA: 0x27197C0 Offset: 0x27198C1 VA: 0x27197C0
	|-EnumAsStringFormatter<int>.Serialize
	|
	|-RVA: 0x271A2B0 Offset: 0x271A3B1 VA: 0x271A2B0
	|-EnumAsStringFormatter<Int32Enum>.Serialize
	|
	|-RVA: 0x271ADC0 Offset: 0x271AEC1 VA: 0x271ADC0
	|-EnumAsStringFormatter<long>.Serialize
	|
	|-RVA: 0x271B890 Offset: 0x271B991 VA: 0x271B890
	|-EnumAsStringFormatter<Memory<object>>.Serialize
	|
	|-RVA: 0x271C390 Offset: 0x271C491 VA: 0x271C390
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Serialize
	|
	|-RVA: 0x271CED0 Offset: 0x271CFD1 VA: 0x271CED0
	|-EnumAsStringFormatter<Nullable<Bounds>>.Serialize
	|
	|-RVA: 0x271DAB0 Offset: 0x271DBB1 VA: 0x271DAB0
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Serialize
	|
	|-RVA: 0x271E630 Offset: 0x271E731 VA: 0x271E630
	|-EnumAsStringFormatter<Nullable<Color32>>.Serialize
	|
	|-RVA: 0x271F150 Offset: 0x271F251 VA: 0x271F150
	|-EnumAsStringFormatter<Nullable<Color>>.Serialize
	|
	|-RVA: 0x271FCD0 Offset: 0x271FDD1 VA: 0x271FCD0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Serialize
	|
	|-RVA: 0x2720810 Offset: 0x2720911 VA: 0x2720810
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Serialize
	|
	|-RVA: 0x2721390 Offset: 0x2721491 VA: 0x2721390
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Serialize
	|
	|-RVA: 0x2721EE0 Offset: 0x2721FE1 VA: 0x2721EE0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Serialize
	|
	|-RVA: 0x2722A70 Offset: 0x2722B71 VA: 0x2722A70
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Serialize
	|
	|-RVA: 0x27236D0 Offset: 0x27237D1 VA: 0x27236D0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Serialize
	|
	|-RVA: 0x2724250 Offset: 0x2724351 VA: 0x2724250
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Serialize
	|
	|-RVA: 0x2724D90 Offset: 0x2724E91 VA: 0x2724D90
	|-EnumAsStringFormatter<Nullable<Rect>>.Serialize
	|
	|-RVA: 0x27C8DF0 Offset: 0x27C8EF1 VA: 0x27C8DF0
	|-EnumAsStringFormatter<Nullable<RectInt>>.Serialize
	|
	|-RVA: 0x27C9970 Offset: 0x27C9A71 VA: 0x27C9970
	|-EnumAsStringFormatter<Nullable<Vector2>>.Serialize
	|
	|-RVA: 0x27CA4A0 Offset: 0x27CA5A1 VA: 0x27CA4A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Serialize
	|
	|-RVA: 0x27CAFB0 Offset: 0x27CB0B1 VA: 0x27CAFB0
	|-EnumAsStringFormatter<Nullable<Vector3>>.Serialize
	|
	|-RVA: 0x27CBAB0 Offset: 0x27CBBB1 VA: 0x27CBAB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Serialize
	|
	|-RVA: 0x27CC5E0 Offset: 0x27CC6E1 VA: 0x27CC5E0
	|-EnumAsStringFormatter<Nullable<Vector4>>.Serialize
	|
	|-RVA: 0x27CD150 Offset: 0x27CD251 VA: 0x27CD150
	|-EnumAsStringFormatter<object>.Serialize
	|
	|-RVA: 0x27CDC20 Offset: 0x27CDD21 VA: 0x27CDC20
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Serialize
	|
	|-RVA: 0x27CE740 Offset: 0x27CE841 VA: 0x27CE740
	|-EnumAsStringFormatter<sbyte>.Serialize
	|
	|-RVA: 0x27CF250 Offset: 0x27CF351 VA: 0x27CF250
	|-EnumAsStringFormatter<float>.Serialize
	|
	|-RVA: 0x27CFD40 Offset: 0x27CFE41 VA: 0x27CFD40
	|-EnumAsStringFormatter<ushort>.Serialize
	|
	|-RVA: 0x27D0830 Offset: 0x27D0931 VA: 0x27D0830
	|-EnumAsStringFormatter<uint>.Serialize
	|
	|-RVA: 0x27D1320 Offset: 0x27D1421 VA: 0x27D1320
	|-EnumAsStringFormatter<ulong>.Serialize
	|
	|-RVA: 0x27D1E70 Offset: 0x27D1F71 VA: 0x27D1E70
	|-EnumAsStringFormatter<Bounds>.Serialize
	|
	|-RVA: 0x27D2A10 Offset: 0x27D2B11 VA: 0x27D2A10
	|-EnumAsStringFormatter<BoundsInt>.Serialize
	|
	|-RVA: 0x27D3540 Offset: 0x27D3641 VA: 0x27D3540
	|-EnumAsStringFormatter<Color32>.Serialize
	|
	|-RVA: 0x27D4070 Offset: 0x27D4171 VA: 0x27D4070
	|-EnumAsStringFormatter<Color>.Serialize
	|
	|-RVA: 0x27D4BA0 Offset: 0x27D4CA1 VA: 0x27D4BA0
	|-EnumAsStringFormatter<GradientAlphaKey>.Serialize
	|
	|-RVA: 0x27D5760 Offset: 0x27D5861 VA: 0x27D5760
	|-EnumAsStringFormatter<GradientColorKey>.Serialize
	|
	|-RVA: 0x27D6370 Offset: 0x27D6471 VA: 0x27D6370
	|-EnumAsStringFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x27D6F20 Offset: 0x27D7021 VA: 0x27D6F20
	|-EnumAsStringFormatter<LayerMask>.Serialize
	|
	|-RVA: 0x27D7B10 Offset: 0x27D7C11 VA: 0x27D7B10
	|-EnumAsStringFormatter<Matrix4x4>.Serialize
	|
	|-RVA: 0x27D86D0 Offset: 0x27D87D1 VA: 0x27D86D0
	|-EnumAsStringFormatter<Quaternion>.Serialize
	|
	|-RVA: 0x27D91E0 Offset: 0x27D92E1 VA: 0x27D91E0
	|-EnumAsStringFormatter<RangeInt>.Serialize
	|
	|-RVA: 0x27D9D50 Offset: 0x27D9E51 VA: 0x27D9D50
	|-EnumAsStringFormatter<Rect>.Serialize
	|
	|-RVA: 0x27DA850 Offset: 0x27DA951 VA: 0x27DA850
	|-EnumAsStringFormatter<RectInt>.Serialize
	|
	|-RVA: 0x27DB370 Offset: 0x27DB471 VA: 0x27DB370
	|-EnumAsStringFormatter<Vector2>.Serialize
	|
	|-RVA: 0x27DBE80 Offset: 0x27DBF81 VA: 0x27DBE80
	|-EnumAsStringFormatter<Vector2Int>.Serialize
	|
	|-RVA: 0x27DC990 Offset: 0x27DCA91 VA: 0x27DC990
	|-EnumAsStringFormatter<Vector3>.Serialize
	|
	|-RVA: 0x27DD4C0 Offset: 0x27DD5C1 VA: 0x27DD4C0
	|-EnumAsStringFormatter<Vector3Int>.Serialize
	|
	|-RVA: 0x27DE010 Offset: 0x27DE111 VA: 0x27DE010
	|-EnumAsStringFormatter<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D4C0 Offset: 0x270D5C1 VA: 0x270D4C0
	|-EnumAsStringFormatter<BitVector32Int>.Deserialize
	|
	|-RVA: 0x270E090 Offset: 0x270E191 VA: 0x270E090
	|-EnumAsStringFormatter<EventCheckId>.Deserialize
	|
	|-RVA: 0x270ED30 Offset: 0x270EE31 VA: 0x270ED30
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Deserialize
	|
	|-RVA: 0x270F930 Offset: 0x270FA31 VA: 0x270F930
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Deserialize
	|
	|-RVA: 0x27104B0 Offset: 0x27105B1 VA: 0x27104B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Deserialize
	|
	|-RVA: 0x2710FF0 Offset: 0x27110F1 VA: 0x2710FF0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Deserialize
	|
	|-RVA: 0x2711C00 Offset: 0x2711D01 VA: 0x2711C00
	|-EnumAsStringFormatter<MonsterHutSaveData>.Deserialize
	|
	|-RVA: 0x2712790 Offset: 0x2712891 VA: 0x2712790
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Deserialize
	|
	|-RVA: 0x27133B0 Offset: 0x27134B1 VA: 0x27133B0
	|-EnumAsStringFormatter<OrderSaveData>.Deserialize
	|
	|-RVA: 0x2713FB0 Offset: 0x27140B1 VA: 0x2713FB0
	|-EnumAsStringFormatter<OrderSaveParameter>.Deserialize
	|
	|-RVA: 0x2714BF0 Offset: 0x2714CF1 VA: 0x2714BF0
	|-EnumAsStringFormatter<Parameter>.Deserialize
	|
	|-RVA: 0x2715740 Offset: 0x2715841 VA: 0x2715740
	|-EnumAsStringFormatter<bool>.Deserialize
	|
	|-RVA: 0x2716230 Offset: 0x2716331 VA: 0x2716230
	|-EnumAsStringFormatter<byte>.Deserialize
	|
	|-RVA: 0x2716D20 Offset: 0x2716E21 VA: 0x2716D20
	|-EnumAsStringFormatter<char>.Deserialize
	|
	|-RVA: 0x2717800 Offset: 0x2717901 VA: 0x2717800
	|-EnumAsStringFormatter<DateTime>.Deserialize
	|
	|-RVA: 0x2718310 Offset: 0x2718411 VA: 0x2718310
	|-EnumAsStringFormatter<double>.Deserialize
	|
	|-RVA: 0x2718E00 Offset: 0x2718F01 VA: 0x2718E00
	|-EnumAsStringFormatter<short>.Deserialize
	|
	|-RVA: 0x27198F0 Offset: 0x27199F1 VA: 0x27198F0
	|-EnumAsStringFormatter<int>.Deserialize
	|
	|-RVA: 0x271A400 Offset: 0x271A501 VA: 0x271A400
	|-EnumAsStringFormatter<Int32Enum>.Deserialize
	|
	|-RVA: 0x271AEE0 Offset: 0x271AFE1 VA: 0x271AEE0
	|-EnumAsStringFormatter<long>.Deserialize
	|
	|-RVA: 0x271B9F0 Offset: 0x271BAF1 VA: 0x271B9F0
	|-EnumAsStringFormatter<Memory<object>>.Deserialize
	|
	|-RVA: 0x271C4E0 Offset: 0x271C5E1 VA: 0x271C4E0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Deserialize
	|
	|-RVA: 0x271D090 Offset: 0x271D191 VA: 0x271D090
	|-EnumAsStringFormatter<Nullable<Bounds>>.Deserialize
	|
	|-RVA: 0x271DC70 Offset: 0x271DD71 VA: 0x271DC70
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Deserialize
	|
	|-RVA: 0x271E780 Offset: 0x271E881 VA: 0x271E780
	|-EnumAsStringFormatter<Nullable<Color32>>.Deserialize
	|
	|-RVA: 0x271F2F0 Offset: 0x271F3F1 VA: 0x271F2F0
	|-EnumAsStringFormatter<Nullable<Color>>.Deserialize
	|
	|-RVA: 0x271FE30 Offset: 0x271FF31 VA: 0x271FE30
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Deserialize
	|
	|-RVA: 0x27209B0 Offset: 0x2720AB1 VA: 0x27209B0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Deserialize
	|
	|-RVA: 0x2721530 Offset: 0x2721631 VA: 0x2721530
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Deserialize
	|
	|-RVA: 0x2722030 Offset: 0x2722131 VA: 0x2722030
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Deserialize
	|
	|-RVA: 0x2722CA0 Offset: 0x2722DA1 VA: 0x2722CA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Deserialize
	|
	|-RVA: 0x2723870 Offset: 0x2723971 VA: 0x2723870
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Deserialize
	|
	|-RVA: 0x27243B0 Offset: 0x27244B1 VA: 0x27243B0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Deserialize
	|
	|-RVA: 0x2724F30 Offset: 0x2725031 VA: 0x2724F30
	|-EnumAsStringFormatter<Nullable<Rect>>.Deserialize
	|
	|-RVA: 0x27C8F90 Offset: 0x27C9091 VA: 0x27C8F90
	|-EnumAsStringFormatter<Nullable<RectInt>>.Deserialize
	|
	|-RVA: 0x27C9AD0 Offset: 0x27C9BD1 VA: 0x27C9AD0
	|-EnumAsStringFormatter<Nullable<Vector2>>.Deserialize
	|
	|-RVA: 0x27CA600 Offset: 0x27CA701 VA: 0x27CA600
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Deserialize
	|
	|-RVA: 0x27CB110 Offset: 0x27CB211 VA: 0x27CB110
	|-EnumAsStringFormatter<Nullable<Vector3>>.Deserialize
	|
	|-RVA: 0x27CBC10 Offset: 0x27CBD11 VA: 0x27CBC10
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Deserialize
	|
	|-RVA: 0x27CC780 Offset: 0x27CC881 VA: 0x27CC780
	|-EnumAsStringFormatter<Nullable<Vector4>>.Deserialize
	|
	|-RVA: 0x27CD280 Offset: 0x27CD381 VA: 0x27CD280
	|-EnumAsStringFormatter<object>.Deserialize
	|
	|-RVA: 0x27CDD80 Offset: 0x27CDE81 VA: 0x27CDD80
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Deserialize
	|
	|-RVA: 0x27CE870 Offset: 0x27CE971 VA: 0x27CE870
	|-EnumAsStringFormatter<sbyte>.Deserialize
	|
	|-RVA: 0x27CF380 Offset: 0x27CF481 VA: 0x27CF380
	|-EnumAsStringFormatter<float>.Deserialize
	|
	|-RVA: 0x27CFE70 Offset: 0x27CFF71 VA: 0x27CFE70
	|-EnumAsStringFormatter<ushort>.Deserialize
	|
	|-RVA: 0x27D0960 Offset: 0x27D0A61 VA: 0x27D0960
	|-EnumAsStringFormatter<uint>.Deserialize
	|
	|-RVA: 0x27D1440 Offset: 0x27D1541 VA: 0x27D1440
	|-EnumAsStringFormatter<ulong>.Deserialize
	|
	|-RVA: 0x27D1FC0 Offset: 0x27D20C1 VA: 0x27D1FC0
	|-EnumAsStringFormatter<Bounds>.Deserialize
	|
	|-RVA: 0x27D2B60 Offset: 0x27D2C61 VA: 0x27D2B60
	|-EnumAsStringFormatter<BoundsInt>.Deserialize
	|
	|-RVA: 0x27D3670 Offset: 0x27D3771 VA: 0x27D3670
	|-EnumAsStringFormatter<Color32>.Deserialize
	|
	|-RVA: 0x27D41C0 Offset: 0x27D42C1 VA: 0x27D41C0
	|-EnumAsStringFormatter<Color>.Deserialize
	|
	|-RVA: 0x27D4D20 Offset: 0x27D4E21 VA: 0x27D4D20
	|-EnumAsStringFormatter<GradientAlphaKey>.Deserialize
	|
	|-RVA: 0x27D5900 Offset: 0x27D5A01 VA: 0x27D5900
	|-EnumAsStringFormatter<GradientColorKey>.Deserialize
	|
	|-RVA: 0x27D6530 Offset: 0x27D6631 VA: 0x27D6530
	|-EnumAsStringFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x27D7090 Offset: 0x27D7191 VA: 0x27D7090
	|-EnumAsStringFormatter<LayerMask>.Deserialize
	|
	|-RVA: 0x27D7CA0 Offset: 0x27D7DA1 VA: 0x27D7CA0
	|-EnumAsStringFormatter<Matrix4x4>.Deserialize
	|
	|-RVA: 0x27D8820 Offset: 0x27D8921 VA: 0x27D8820
	|-EnumAsStringFormatter<Quaternion>.Deserialize
	|
	|-RVA: 0x27D9350 Offset: 0x27D9451 VA: 0x27D9350
	|-EnumAsStringFormatter<RangeInt>.Deserialize
	|
	|-RVA: 0x27D9EA0 Offset: 0x27D9FA1 VA: 0x27D9EA0
	|-EnumAsStringFormatter<Rect>.Deserialize
	|
	|-RVA: 0x27DA990 Offset: 0x27DAA91 VA: 0x27DA990
	|-EnumAsStringFormatter<RectInt>.Deserialize
	|
	|-RVA: 0x27DB4B0 Offset: 0x27DB5B1 VA: 0x27DB4B0
	|-EnumAsStringFormatter<Vector2>.Deserialize
	|
	|-RVA: 0x27DBFA0 Offset: 0x27DC0A1 VA: 0x27DBFA0
	|-EnumAsStringFormatter<Vector2Int>.Deserialize
	|
	|-RVA: 0x27DCAE0 Offset: 0x27DCBE1 VA: 0x27DCAE0
	|-EnumAsStringFormatter<Vector3>.Deserialize
	|
	|-RVA: 0x27DD600 Offset: 0x27DD701 VA: 0x27DD600
	|-EnumAsStringFormatter<Vector3Int>.Deserialize
	|
	|-RVA: 0x27DE160 Offset: 0x27DE261 VA: 0x27DE160
	|-EnumAsStringFormatter<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	private string GetClrNames(string serializedNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D6B0 Offset: 0x270D7B1 VA: 0x270D6B0
	|-EnumAsStringFormatter<BitVector32Int>.GetClrNames
	|
	|-RVA: 0x270E2A0 Offset: 0x270E3A1 VA: 0x270E2A0
	|-EnumAsStringFormatter<EventCheckId>.GetClrNames
	|
	|-RVA: 0x270EF50 Offset: 0x270F051 VA: 0x270EF50
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetClrNames
	|
	|-RVA: 0x270FB40 Offset: 0x270FC41 VA: 0x270FB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetClrNames
	|
	|-RVA: 0x27106B0 Offset: 0x27107B1 VA: 0x27106B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetClrNames
	|
	|-RVA: 0x27111E0 Offset: 0x27112E1 VA: 0x27111E0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetClrNames
	|
	|-RVA: 0x2711E20 Offset: 0x2711F21 VA: 0x2711E20
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetClrNames
	|
	|-RVA: 0x2712990 Offset: 0x2712A91 VA: 0x2712990
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetClrNames
	|
	|-RVA: 0x27135D0 Offset: 0x27136D1 VA: 0x27135D0
	|-EnumAsStringFormatter<OrderSaveData>.GetClrNames
	|
	|-RVA: 0x27141C0 Offset: 0x27142C1 VA: 0x27141C0
	|-EnumAsStringFormatter<OrderSaveParameter>.GetClrNames
	|
	|-RVA: 0x2714E30 Offset: 0x2714F31 VA: 0x2714E30
	|-EnumAsStringFormatter<Parameter>.GetClrNames
	|
	|-RVA: 0x2715930 Offset: 0x2715A31 VA: 0x2715930
	|-EnumAsStringFormatter<bool>.GetClrNames
	|
	|-RVA: 0x2716420 Offset: 0x2716521 VA: 0x2716420
	|-EnumAsStringFormatter<byte>.GetClrNames
	|
	|-RVA: 0x2716F10 Offset: 0x2717011 VA: 0x2716F10
	|-EnumAsStringFormatter<char>.GetClrNames
	|
	|-RVA: 0x27179F0 Offset: 0x2717AF1 VA: 0x27179F0
	|-EnumAsStringFormatter<DateTime>.GetClrNames
	|
	|-RVA: 0x2718500 Offset: 0x2718601 VA: 0x2718500
	|-EnumAsStringFormatter<double>.GetClrNames
	|
	|-RVA: 0x2718FF0 Offset: 0x27190F1 VA: 0x2718FF0
	|-EnumAsStringFormatter<short>.GetClrNames
	|
	|-RVA: 0x2719AE0 Offset: 0x2719BE1 VA: 0x2719AE0
	|-EnumAsStringFormatter<int>.GetClrNames
	|
	|-RVA: 0x271A5F0 Offset: 0x271A6F1 VA: 0x271A5F0
	|-EnumAsStringFormatter<Int32Enum>.GetClrNames
	|
	|-RVA: 0x271B0D0 Offset: 0x271B1D1 VA: 0x271B0D0
	|-EnumAsStringFormatter<long>.GetClrNames
	|
	|-RVA: 0x271BBE0 Offset: 0x271BCE1 VA: 0x271BBE0
	|-EnumAsStringFormatter<Memory<object>>.GetClrNames
	|
	|-RVA: 0x271C6C0 Offset: 0x271C7C1 VA: 0x271C6C0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetClrNames
	|
	|-RVA: 0x271D2A0 Offset: 0x271D3A1 VA: 0x271D2A0
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetClrNames
	|
	|-RVA: 0x271DE80 Offset: 0x271DF81 VA: 0x271DE80
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetClrNames
	|
	|-RVA: 0x271E960 Offset: 0x271EA61 VA: 0x271E960
	|-EnumAsStringFormatter<Nullable<Color32>>.GetClrNames
	|
	|-RVA: 0x271F4F0 Offset: 0x271F5F1 VA: 0x271F4F0
	|-EnumAsStringFormatter<Nullable<Color>>.GetClrNames
	|
	|-RVA: 0x2720020 Offset: 0x2720121 VA: 0x2720020
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetClrNames
	|
	|-RVA: 0x2720BB0 Offset: 0x2720CB1 VA: 0x2720BB0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetClrNames
	|
	|-RVA: 0x2721730 Offset: 0x2721831 VA: 0x2721730
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetClrNames
	|
	|-RVA: 0x2722210 Offset: 0x2722311 VA: 0x2722210
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetClrNames
	|
	|-RVA: 0x2722EE0 Offset: 0x2722FE1 VA: 0x2722EE0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetClrNames
	|
	|-RVA: 0x2723A70 Offset: 0x2723B71 VA: 0x2723A70
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetClrNames
	|
	|-RVA: 0x27245A0 Offset: 0x27246A1 VA: 0x27245A0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetClrNames
	|
	|-RVA: 0x2725130 Offset: 0x2725231 VA: 0x2725130
	|-EnumAsStringFormatter<Nullable<Rect>>.GetClrNames
	|
	|-RVA: 0x27C9190 Offset: 0x27C9291 VA: 0x27C9190
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetClrNames
	|
	|-RVA: 0x27C9CC0 Offset: 0x27C9DC1 VA: 0x27C9CC0
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetClrNames
	|
	|-RVA: 0x27CA7F0 Offset: 0x27CA8F1 VA: 0x27CA7F0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetClrNames
	|
	|-RVA: 0x27CB2F0 Offset: 0x27CB3F1 VA: 0x27CB2F0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetClrNames
	|
	|-RVA: 0x27CBDF0 Offset: 0x27CBEF1 VA: 0x27CBDF0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetClrNames
	|
	|-RVA: 0x27CC980 Offset: 0x27CCA81 VA: 0x27CC980
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetClrNames
	|
	|-RVA: 0x27CD460 Offset: 0x27CD561 VA: 0x27CD460
	|-EnumAsStringFormatter<object>.GetClrNames
	|
	|-RVA: 0x27CDF70 Offset: 0x27CE071 VA: 0x27CDF70
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetClrNames
	|
	|-RVA: 0x27CEA60 Offset: 0x27CEB61 VA: 0x27CEA60
	|-EnumAsStringFormatter<sbyte>.GetClrNames
	|
	|-RVA: 0x27CF570 Offset: 0x27CF671 VA: 0x27CF570
	|-EnumAsStringFormatter<float>.GetClrNames
	|
	|-RVA: 0x27D0060 Offset: 0x27D0161 VA: 0x27D0060
	|-EnumAsStringFormatter<ushort>.GetClrNames
	|
	|-RVA: 0x27D0B50 Offset: 0x27D0C51 VA: 0x27D0B50
	|-EnumAsStringFormatter<uint>.GetClrNames
	|
	|-RVA: 0x27D1630 Offset: 0x27D1731 VA: 0x27D1630
	|-EnumAsStringFormatter<ulong>.GetClrNames
	|
	|-RVA: 0x27D21D0 Offset: 0x27D22D1 VA: 0x27D21D0
	|-EnumAsStringFormatter<Bounds>.GetClrNames
	|
	|-RVA: 0x27D2D70 Offset: 0x27D2E71 VA: 0x27D2D70
	|-EnumAsStringFormatter<BoundsInt>.GetClrNames
	|
	|-RVA: 0x27D3860 Offset: 0x27D3961 VA: 0x27D3860
	|-EnumAsStringFormatter<Color32>.GetClrNames
	|
	|-RVA: 0x27D43B0 Offset: 0x27D44B1 VA: 0x27D43B0
	|-EnumAsStringFormatter<Color>.GetClrNames
	|
	|-RVA: 0x27D4F20 Offset: 0x27D5021 VA: 0x27D4F20
	|-EnumAsStringFormatter<GradientAlphaKey>.GetClrNames
	|
	|-RVA: 0x27D5B10 Offset: 0x27D5C11 VA: 0x27D5B10
	|-EnumAsStringFormatter<GradientColorKey>.GetClrNames
	|
	|-RVA: 0x27D6750 Offset: 0x27D6851 VA: 0x27D6750
	|-EnumAsStringFormatter<Keyframe>.GetClrNames
	|
	|-RVA: 0x27D7280 Offset: 0x27D7381 VA: 0x27D7280
	|-EnumAsStringFormatter<LayerMask>.GetClrNames
	|
	|-RVA: 0x27D7EC0 Offset: 0x27D7FC1 VA: 0x27D7EC0
	|-EnumAsStringFormatter<Matrix4x4>.GetClrNames
	|
	|-RVA: 0x27D8A10 Offset: 0x27D8B11 VA: 0x27D8A10
	|-EnumAsStringFormatter<Quaternion>.GetClrNames
	|
	|-RVA: 0x27D9540 Offset: 0x27D9641 VA: 0x27D9540
	|-EnumAsStringFormatter<RangeInt>.GetClrNames
	|
	|-RVA: 0x27DA090 Offset: 0x27DA191 VA: 0x27DA090
	|-EnumAsStringFormatter<Rect>.GetClrNames
	|
	|-RVA: 0x27DAB80 Offset: 0x27DAC81 VA: 0x27DAB80
	|-EnumAsStringFormatter<RectInt>.GetClrNames
	|
	|-RVA: 0x27DB6B0 Offset: 0x27DB7B1 VA: 0x27DB6B0
	|-EnumAsStringFormatter<Vector2>.GetClrNames
	|
	|-RVA: 0x27DC190 Offset: 0x27DC291 VA: 0x27DC190
	|-EnumAsStringFormatter<Vector2Int>.GetClrNames
	|
	|-RVA: 0x27DCCE0 Offset: 0x27DCDE1 VA: 0x27DCCE0
	|-EnumAsStringFormatter<Vector3>.GetClrNames
	|
	|-RVA: 0x27DD800 Offset: 0x27DD901 VA: 0x27DD800
	|-EnumAsStringFormatter<Vector3Int>.GetClrNames
	|
	|-RVA: 0x27DE350 Offset: 0x27DE451 VA: 0x27DE350
	|-EnumAsStringFormatter<Vector4>.GetClrNames
	*/

	// RVA: -1 Offset: -1
	private string GetSerializedNames(string clrNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D770 Offset: 0x270D871 VA: 0x270D770
	|-EnumAsStringFormatter<BitVector32Int>.GetSerializedNames
	|
	|-RVA: 0x270E360 Offset: 0x270E461 VA: 0x270E360
	|-EnumAsStringFormatter<EventCheckId>.GetSerializedNames
	|
	|-RVA: 0x270F010 Offset: 0x270F111 VA: 0x270F010
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetSerializedNames
	|
	|-RVA: 0x270FC00 Offset: 0x270FD01 VA: 0x270FC00
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetSerializedNames
	|
	|-RVA: 0x2710770 Offset: 0x2710871 VA: 0x2710770
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetSerializedNames
	|
	|-RVA: 0x27112A0 Offset: 0x27113A1 VA: 0x27112A0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetSerializedNames
	|
	|-RVA: 0x2711EE0 Offset: 0x2711FE1 VA: 0x2711EE0
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetSerializedNames
	|
	|-RVA: 0x2712A50 Offset: 0x2712B51 VA: 0x2712A50
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2713690 Offset: 0x2713791 VA: 0x2713690
	|-EnumAsStringFormatter<OrderSaveData>.GetSerializedNames
	|
	|-RVA: 0x2714280 Offset: 0x2714381 VA: 0x2714280
	|-EnumAsStringFormatter<OrderSaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2714EF0 Offset: 0x2714FF1 VA: 0x2714EF0
	|-EnumAsStringFormatter<Parameter>.GetSerializedNames
	|
	|-RVA: 0x27159F0 Offset: 0x2715AF1 VA: 0x27159F0
	|-EnumAsStringFormatter<bool>.GetSerializedNames
	|
	|-RVA: 0x27164E0 Offset: 0x27165E1 VA: 0x27164E0
	|-EnumAsStringFormatter<byte>.GetSerializedNames
	|
	|-RVA: 0x2716FD0 Offset: 0x27170D1 VA: 0x2716FD0
	|-EnumAsStringFormatter<char>.GetSerializedNames
	|
	|-RVA: 0x2717AB0 Offset: 0x2717BB1 VA: 0x2717AB0
	|-EnumAsStringFormatter<DateTime>.GetSerializedNames
	|
	|-RVA: 0x27185C0 Offset: 0x27186C1 VA: 0x27185C0
	|-EnumAsStringFormatter<double>.GetSerializedNames
	|
	|-RVA: 0x27190B0 Offset: 0x27191B1 VA: 0x27190B0
	|-EnumAsStringFormatter<short>.GetSerializedNames
	|
	|-RVA: 0x2719BA0 Offset: 0x2719CA1 VA: 0x2719BA0
	|-EnumAsStringFormatter<int>.GetSerializedNames
	|
	|-RVA: 0x271A6B0 Offset: 0x271A7B1 VA: 0x271A6B0
	|-EnumAsStringFormatter<Int32Enum>.GetSerializedNames
	|
	|-RVA: 0x271B190 Offset: 0x271B291 VA: 0x271B190
	|-EnumAsStringFormatter<long>.GetSerializedNames
	|
	|-RVA: 0x271BCA0 Offset: 0x271BDA1 VA: 0x271BCA0
	|-EnumAsStringFormatter<Memory<object>>.GetSerializedNames
	|
	|-RVA: 0x271C780 Offset: 0x271C881 VA: 0x271C780
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetSerializedNames
	|
	|-RVA: 0x271D360 Offset: 0x271D461 VA: 0x271D360
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetSerializedNames
	|
	|-RVA: 0x271DF40 Offset: 0x271E041 VA: 0x271DF40
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetSerializedNames
	|
	|-RVA: 0x271EA20 Offset: 0x271EB21 VA: 0x271EA20
	|-EnumAsStringFormatter<Nullable<Color32>>.GetSerializedNames
	|
	|-RVA: 0x271F5B0 Offset: 0x271F6B1 VA: 0x271F5B0
	|-EnumAsStringFormatter<Nullable<Color>>.GetSerializedNames
	|
	|-RVA: 0x27200E0 Offset: 0x27201E1 VA: 0x27200E0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetSerializedNames
	|
	|-RVA: 0x2720C70 Offset: 0x2720D71 VA: 0x2720C70
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetSerializedNames
	|
	|-RVA: 0x27217F0 Offset: 0x27218F1 VA: 0x27217F0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetSerializedNames
	|
	|-RVA: 0x27222D0 Offset: 0x27223D1 VA: 0x27222D0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetSerializedNames
	|
	|-RVA: 0x2722FA0 Offset: 0x27230A1 VA: 0x2722FA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetSerializedNames
	|
	|-RVA: 0x2723B30 Offset: 0x2723C31 VA: 0x2723B30
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetSerializedNames
	|
	|-RVA: 0x2724660 Offset: 0x2724761 VA: 0x2724660
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetSerializedNames
	|
	|-RVA: 0x27251F0 Offset: 0x27252F1 VA: 0x27251F0
	|-EnumAsStringFormatter<Nullable<Rect>>.GetSerializedNames
	|
	|-RVA: 0x27C9250 Offset: 0x27C9351 VA: 0x27C9250
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetSerializedNames
	|
	|-RVA: 0x27C9D80 Offset: 0x27C9E81 VA: 0x27C9D80
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetSerializedNames
	|
	|-RVA: 0x27CA8B0 Offset: 0x27CA9B1 VA: 0x27CA8B0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetSerializedNames
	|
	|-RVA: 0x27CB3B0 Offset: 0x27CB4B1 VA: 0x27CB3B0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetSerializedNames
	|
	|-RVA: 0x27CBEB0 Offset: 0x27CBFB1 VA: 0x27CBEB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetSerializedNames
	|
	|-RVA: 0x27CCA40 Offset: 0x27CCB41 VA: 0x27CCA40
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetSerializedNames
	|
	|-RVA: 0x27CD520 Offset: 0x27CD621 VA: 0x27CD520
	|-EnumAsStringFormatter<object>.GetSerializedNames
	|
	|-RVA: 0x27CE030 Offset: 0x27CE131 VA: 0x27CE030
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetSerializedNames
	|
	|-RVA: 0x27CEB20 Offset: 0x27CEC21 VA: 0x27CEB20
	|-EnumAsStringFormatter<sbyte>.GetSerializedNames
	|
	|-RVA: 0x27CF630 Offset: 0x27CF731 VA: 0x27CF630
	|-EnumAsStringFormatter<float>.GetSerializedNames
	|
	|-RVA: 0x27D0120 Offset: 0x27D0221 VA: 0x27D0120
	|-EnumAsStringFormatter<ushort>.GetSerializedNames
	|
	|-RVA: 0x27D0C10 Offset: 0x27D0D11 VA: 0x27D0C10
	|-EnumAsStringFormatter<uint>.GetSerializedNames
	|
	|-RVA: 0x27D16F0 Offset: 0x27D17F1 VA: 0x27D16F0
	|-EnumAsStringFormatter<ulong>.GetSerializedNames
	|
	|-RVA: 0x27D2290 Offset: 0x27D2391 VA: 0x27D2290
	|-EnumAsStringFormatter<Bounds>.GetSerializedNames
	|
	|-RVA: 0x27D2E30 Offset: 0x27D2F31 VA: 0x27D2E30
	|-EnumAsStringFormatter<BoundsInt>.GetSerializedNames
	|
	|-RVA: 0x27D3920 Offset: 0x27D3A21 VA: 0x27D3920
	|-EnumAsStringFormatter<Color32>.GetSerializedNames
	|
	|-RVA: 0x27D4470 Offset: 0x27D4571 VA: 0x27D4470
	|-EnumAsStringFormatter<Color>.GetSerializedNames
	|
	|-RVA: 0x27D4FE0 Offset: 0x27D50E1 VA: 0x27D4FE0
	|-EnumAsStringFormatter<GradientAlphaKey>.GetSerializedNames
	|
	|-RVA: 0x27D5BD0 Offset: 0x27D5CD1 VA: 0x27D5BD0
	|-EnumAsStringFormatter<GradientColorKey>.GetSerializedNames
	|
	|-RVA: 0x27D6810 Offset: 0x27D6911 VA: 0x27D6810
	|-EnumAsStringFormatter<Keyframe>.GetSerializedNames
	|
	|-RVA: 0x27D7340 Offset: 0x27D7441 VA: 0x27D7340
	|-EnumAsStringFormatter<LayerMask>.GetSerializedNames
	|
	|-RVA: 0x27D7F80 Offset: 0x27D8081 VA: 0x27D7F80
	|-EnumAsStringFormatter<Matrix4x4>.GetSerializedNames
	|
	|-RVA: 0x27D8AD0 Offset: 0x27D8BD1 VA: 0x27D8AD0
	|-EnumAsStringFormatter<Quaternion>.GetSerializedNames
	|
	|-RVA: 0x27D9600 Offset: 0x27D9701 VA: 0x27D9600
	|-EnumAsStringFormatter<RangeInt>.GetSerializedNames
	|
	|-RVA: 0x27DA150 Offset: 0x27DA251 VA: 0x27DA150
	|-EnumAsStringFormatter<Rect>.GetSerializedNames
	|
	|-RVA: 0x27DAC40 Offset: 0x27DAD41 VA: 0x27DAC40
	|-EnumAsStringFormatter<RectInt>.GetSerializedNames
	|
	|-RVA: 0x27DB770 Offset: 0x27DB871 VA: 0x27DB770
	|-EnumAsStringFormatter<Vector2>.GetSerializedNames
	|
	|-RVA: 0x27DC250 Offset: 0x27DC351 VA: 0x27DC250
	|-EnumAsStringFormatter<Vector2Int>.GetSerializedNames
	|
	|-RVA: 0x27DCDA0 Offset: 0x27DCEA1 VA: 0x27DCDA0
	|-EnumAsStringFormatter<Vector3>.GetSerializedNames
	|
	|-RVA: 0x27DD8C0 Offset: 0x27DD9C1 VA: 0x27DD8C0
	|-EnumAsStringFormatter<Vector3Int>.GetSerializedNames
	|
	|-RVA: 0x27DE410 Offset: 0x27DE511 VA: 0x27DE410
	|-EnumAsStringFormatter<Vector4>.GetSerializedNames
	*/

	// RVA: -1 Offset: -1
	private static string Translate(string items, IReadOnlyDictionary<string, string> mapping) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D830 Offset: 0x270D931 VA: 0x270D830
	|-EnumAsStringFormatter<BitVector32Int>.Translate
	|
	|-RVA: 0x270E420 Offset: 0x270E521 VA: 0x270E420
	|-EnumAsStringFormatter<EventCheckId>.Translate
	|
	|-RVA: 0x270F0D0 Offset: 0x270F1D1 VA: 0x270F0D0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Translate
	|
	|-RVA: 0x270FCC0 Offset: 0x270FDC1 VA: 0x270FCC0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Translate
	|
	|-RVA: 0x2710830 Offset: 0x2710931 VA: 0x2710830
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Translate
	|
	|-RVA: 0x2711360 Offset: 0x2711461 VA: 0x2711360
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Translate
	|
	|-RVA: 0x2711FA0 Offset: 0x27120A1 VA: 0x2711FA0
	|-EnumAsStringFormatter<MonsterHutSaveData>.Translate
	|
	|-RVA: 0x2712B10 Offset: 0x2712C11 VA: 0x2712B10
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Translate
	|
	|-RVA: 0x2713750 Offset: 0x2713851 VA: 0x2713750
	|-EnumAsStringFormatter<OrderSaveData>.Translate
	|
	|-RVA: 0x2714340 Offset: 0x2714441 VA: 0x2714340
	|-EnumAsStringFormatter<OrderSaveParameter>.Translate
	|
	|-RVA: 0x2714FB0 Offset: 0x27150B1 VA: 0x2714FB0
	|-EnumAsStringFormatter<Parameter>.Translate
	|
	|-RVA: 0x2715AB0 Offset: 0x2715BB1 VA: 0x2715AB0
	|-EnumAsStringFormatter<bool>.Translate
	|
	|-RVA: 0x27165A0 Offset: 0x27166A1 VA: 0x27165A0
	|-EnumAsStringFormatter<byte>.Translate
	|
	|-RVA: 0x2717090 Offset: 0x2717191 VA: 0x2717090
	|-EnumAsStringFormatter<char>.Translate
	|
	|-RVA: 0x2717B70 Offset: 0x2717C71 VA: 0x2717B70
	|-EnumAsStringFormatter<DateTime>.Translate
	|
	|-RVA: 0x2718680 Offset: 0x2718781 VA: 0x2718680
	|-EnumAsStringFormatter<double>.Translate
	|
	|-RVA: 0x2719170 Offset: 0x2719271 VA: 0x2719170
	|-EnumAsStringFormatter<short>.Translate
	|
	|-RVA: 0x2719C60 Offset: 0x2719D61 VA: 0x2719C60
	|-EnumAsStringFormatter<int>.Translate
	|
	|-RVA: 0x271A770 Offset: 0x271A871 VA: 0x271A770
	|-EnumAsStringFormatter<Int32Enum>.Translate
	|
	|-RVA: 0x271B250 Offset: 0x271B351 VA: 0x271B250
	|-EnumAsStringFormatter<long>.Translate
	|
	|-RVA: 0x271BD60 Offset: 0x271BE61 VA: 0x271BD60
	|-EnumAsStringFormatter<Memory<object>>.Translate
	|
	|-RVA: 0x271C840 Offset: 0x271C941 VA: 0x271C840
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Translate
	|
	|-RVA: 0x271D420 Offset: 0x271D521 VA: 0x271D420
	|-EnumAsStringFormatter<Nullable<Bounds>>.Translate
	|
	|-RVA: 0x271E000 Offset: 0x271E101 VA: 0x271E000
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Translate
	|
	|-RVA: 0x271EAE0 Offset: 0x271EBE1 VA: 0x271EAE0
	|-EnumAsStringFormatter<Nullable<Color32>>.Translate
	|
	|-RVA: 0x271F670 Offset: 0x271F771 VA: 0x271F670
	|-EnumAsStringFormatter<Nullable<Color>>.Translate
	|
	|-RVA: 0x27201A0 Offset: 0x27202A1 VA: 0x27201A0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Translate
	|
	|-RVA: 0x2720D30 Offset: 0x2720E31 VA: 0x2720D30
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Translate
	|
	|-RVA: 0x27218B0 Offset: 0x27219B1 VA: 0x27218B0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Translate
	|
	|-RVA: 0x2722390 Offset: 0x2722491 VA: 0x2722390
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Translate
	|
	|-RVA: 0x2723060 Offset: 0x2723161 VA: 0x2723060
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Translate
	|
	|-RVA: 0x2723BF0 Offset: 0x2723CF1 VA: 0x2723BF0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Translate
	|
	|-RVA: 0x2724720 Offset: 0x2724821 VA: 0x2724720
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Translate
	|
	|-RVA: 0x27252B0 Offset: 0x27253B1 VA: 0x27252B0
	|-EnumAsStringFormatter<Nullable<Rect>>.Translate
	|
	|-RVA: 0x27C9310 Offset: 0x27C9411 VA: 0x27C9310
	|-EnumAsStringFormatter<Nullable<RectInt>>.Translate
	|
	|-RVA: 0x27C9E40 Offset: 0x27C9F41 VA: 0x27C9E40
	|-EnumAsStringFormatter<Nullable<Vector2>>.Translate
	|
	|-RVA: 0x27CA970 Offset: 0x27CAA71 VA: 0x27CA970
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Translate
	|
	|-RVA: 0x27CB470 Offset: 0x27CB571 VA: 0x27CB470
	|-EnumAsStringFormatter<Nullable<Vector3>>.Translate
	|
	|-RVA: 0x27CBF70 Offset: 0x27CC071 VA: 0x27CBF70
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Translate
	|
	|-RVA: 0x27CCB00 Offset: 0x27CCC01 VA: 0x27CCB00
	|-EnumAsStringFormatter<Nullable<Vector4>>.Translate
	|
	|-RVA: 0x27CD5E0 Offset: 0x27CD6E1 VA: 0x27CD5E0
	|-EnumAsStringFormatter<object>.Translate
	|
	|-RVA: 0x27CE0F0 Offset: 0x27CE1F1 VA: 0x27CE0F0
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Translate
	|
	|-RVA: 0x27CEBE0 Offset: 0x27CECE1 VA: 0x27CEBE0
	|-EnumAsStringFormatter<sbyte>.Translate
	|
	|-RVA: 0x27CF6F0 Offset: 0x27CF7F1 VA: 0x27CF6F0
	|-EnumAsStringFormatter<float>.Translate
	|
	|-RVA: 0x27D01E0 Offset: 0x27D02E1 VA: 0x27D01E0
	|-EnumAsStringFormatter<ushort>.Translate
	|
	|-RVA: 0x27D0CD0 Offset: 0x27D0DD1 VA: 0x27D0CD0
	|-EnumAsStringFormatter<uint>.Translate
	|
	|-RVA: 0x27D17B0 Offset: 0x27D18B1 VA: 0x27D17B0
	|-EnumAsStringFormatter<ulong>.Translate
	|
	|-RVA: 0x27D2350 Offset: 0x27D2451 VA: 0x27D2350
	|-EnumAsStringFormatter<Bounds>.Translate
	|
	|-RVA: 0x27D2EF0 Offset: 0x27D2FF1 VA: 0x27D2EF0
	|-EnumAsStringFormatter<BoundsInt>.Translate
	|
	|-RVA: 0x27D39E0 Offset: 0x27D3AE1 VA: 0x27D39E0
	|-EnumAsStringFormatter<Color32>.Translate
	|
	|-RVA: 0x27D4530 Offset: 0x27D4631 VA: 0x27D4530
	|-EnumAsStringFormatter<Color>.Translate
	|
	|-RVA: 0x27D50A0 Offset: 0x27D51A1 VA: 0x27D50A0
	|-EnumAsStringFormatter<GradientAlphaKey>.Translate
	|
	|-RVA: 0x27D5C90 Offset: 0x27D5D91 VA: 0x27D5C90
	|-EnumAsStringFormatter<GradientColorKey>.Translate
	|
	|-RVA: 0x27D68D0 Offset: 0x27D69D1 VA: 0x27D68D0
	|-EnumAsStringFormatter<Keyframe>.Translate
	|
	|-RVA: 0x27D7400 Offset: 0x27D7501 VA: 0x27D7400
	|-EnumAsStringFormatter<LayerMask>.Translate
	|
	|-RVA: 0x27D8040 Offset: 0x27D8141 VA: 0x27D8040
	|-EnumAsStringFormatter<Matrix4x4>.Translate
	|
	|-RVA: 0x27D8B90 Offset: 0x27D8C91 VA: 0x27D8B90
	|-EnumAsStringFormatter<Quaternion>.Translate
	|
	|-RVA: 0x27D96C0 Offset: 0x27D97C1 VA: 0x27D96C0
	|-EnumAsStringFormatter<RangeInt>.Translate
	|
	|-RVA: 0x27DA210 Offset: 0x27DA311 VA: 0x27DA210
	|-EnumAsStringFormatter<Rect>.Translate
	|
	|-RVA: 0x27DAD00 Offset: 0x27DAE01 VA: 0x27DAD00
	|-EnumAsStringFormatter<RectInt>.Translate
	|
	|-RVA: 0x27DB830 Offset: 0x27DB931 VA: 0x27DB830
	|-EnumAsStringFormatter<Vector2>.Translate
	|
	|-RVA: 0x27DC310 Offset: 0x27DC411 VA: 0x27DC310
	|-EnumAsStringFormatter<Vector2Int>.Translate
	|
	|-RVA: 0x27DCE60 Offset: 0x27DCF61 VA: 0x27DCE60
	|-EnumAsStringFormatter<Vector3>.Translate
	|
	|-RVA: 0x27DD980 Offset: 0x27DDA81 VA: 0x27DD980
	|-EnumAsStringFormatter<Vector3Int>.Translate
	|
	|-RVA: 0x27DE4D0 Offset: 0x27DE5D1 VA: 0x27DE4D0
	|-EnumAsStringFormatter<Vector4>.Translate
	*/
}

public sealed class EnumAsStringFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter // TypeDefIndex: 5404
{
	// Fields
	private readonly IReadOnlyDictionary<string, T> nameValueMapping; // 0x0
	private readonly IReadOnlyDictionary<T, string> valueNameMapping; // 0x0
	private readonly IReadOnlyDictionary<string, string> clrToSerializationName; // 0x0
	private readonly IReadOnlyDictionary<string, string> serializationToClrName; // 0x0
	private readonly bool enumMemberOverridesPresent; // 0x0
	private readonly bool isFlags; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CFA0 Offset: 0x270D0A1 VA: 0x270CFA0
	|-EnumAsStringFormatter<BitVector32Int>..ctor
	|
	|-RVA: 0x270DA90 Offset: 0x270DB91 VA: 0x270DA90
	|-EnumAsStringFormatter<EventCheckId>..ctor
	|
	|-RVA: 0x270E680 Offset: 0x270E781 VA: 0x270E680
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x270F330 Offset: 0x270F431 VA: 0x270F330
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x270FF20 Offset: 0x2710021 VA: 0x270FF20
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2710A90 Offset: 0x2710B91 VA: 0x2710A90
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x27115C0 Offset: 0x27116C1 VA: 0x27115C0
	|-EnumAsStringFormatter<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2712200 Offset: 0x2712301 VA: 0x2712200
	|-EnumAsStringFormatter<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2712D70 Offset: 0x2712E71 VA: 0x2712D70
	|-EnumAsStringFormatter<OrderSaveData>..ctor
	|
	|-RVA: 0x27139B0 Offset: 0x2713AB1 VA: 0x27139B0
	|-EnumAsStringFormatter<OrderSaveParameter>..ctor
	|
	|-RVA: 0x27145A0 Offset: 0x27146A1 VA: 0x27145A0
	|-EnumAsStringFormatter<Parameter>..ctor
	|
	|-RVA: 0x2715210 Offset: 0x2715311 VA: 0x2715210
	|-EnumAsStringFormatter<bool>..ctor
	|
	|-RVA: 0x2715D10 Offset: 0x2715E11 VA: 0x2715D10
	|-EnumAsStringFormatter<byte>..ctor
	|
	|-RVA: 0x2716800 Offset: 0x2716901 VA: 0x2716800
	|-EnumAsStringFormatter<char>..ctor
	|
	|-RVA: 0x27172F0 Offset: 0x27173F1 VA: 0x27172F0
	|-EnumAsStringFormatter<DateTime>..ctor
	|
	|-RVA: 0x2717DD0 Offset: 0x2717ED1 VA: 0x2717DD0
	|-EnumAsStringFormatter<double>..ctor
	|
	|-RVA: 0x27188E0 Offset: 0x27189E1 VA: 0x27188E0
	|-EnumAsStringFormatter<short>..ctor
	|
	|-RVA: 0x27193D0 Offset: 0x27194D1 VA: 0x27193D0
	|-EnumAsStringFormatter<int>..ctor
	|
	|-RVA: 0x2719EC0 Offset: 0x2719FC1 VA: 0x2719EC0
	|-EnumAsStringFormatter<Int32Enum>..ctor
	|
	|-RVA: 0x271A9D0 Offset: 0x271AAD1 VA: 0x271A9D0
	|-EnumAsStringFormatter<long>..ctor
	|
	|-RVA: 0x271B4B0 Offset: 0x271B5B1 VA: 0x271B4B0
	|-EnumAsStringFormatter<Memory<object>>..ctor
	|
	|-RVA: 0x271BFC0 Offset: 0x271C0C1 VA: 0x271BFC0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x271CAA0 Offset: 0x271CBA1 VA: 0x271CAA0
	|-EnumAsStringFormatter<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x271D680 Offset: 0x271D781 VA: 0x271D680
	|-EnumAsStringFormatter<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x271E260 Offset: 0x271E361 VA: 0x271E260
	|-EnumAsStringFormatter<Nullable<Color32>>..ctor
	|
	|-RVA: 0x271ED40 Offset: 0x271EE41 VA: 0x271ED40
	|-EnumAsStringFormatter<Nullable<Color>>..ctor
	|
	|-RVA: 0x271F8D0 Offset: 0x271F9D1 VA: 0x271F8D0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2720400 Offset: 0x2720501 VA: 0x2720400
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2720F90 Offset: 0x2721091 VA: 0x2720F90
	|-EnumAsStringFormatter<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2721B10 Offset: 0x2721C11 VA: 0x2721B10
	|-EnumAsStringFormatter<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x27225F0 Offset: 0x27226F1 VA: 0x27225F0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x27232C0 Offset: 0x27233C1 VA: 0x27232C0
	|-EnumAsStringFormatter<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2723E50 Offset: 0x2723F51 VA: 0x2723E50
	|-EnumAsStringFormatter<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2724980 Offset: 0x2724A81 VA: 0x2724980
	|-EnumAsStringFormatter<Nullable<Rect>>..ctor
	|
	|-RVA: 0x27C89E0 Offset: 0x27C8AE1 VA: 0x27C89E0
	|-EnumAsStringFormatter<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x27C9570 Offset: 0x27C9671 VA: 0x27C9570
	|-EnumAsStringFormatter<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x27CA0A0 Offset: 0x27CA1A1 VA: 0x27CA0A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x27CABD0 Offset: 0x27CACD1 VA: 0x27CABD0
	|-EnumAsStringFormatter<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x27CB6D0 Offset: 0x27CB7D1 VA: 0x27CB6D0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x27CC1D0 Offset: 0x27CC2D1 VA: 0x27CC1D0
	|-EnumAsStringFormatter<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x27CCD60 Offset: 0x27CCE61 VA: 0x27CCD60
	|-EnumAsStringFormatter<object>..ctor
	|
	|-RVA: 0x27CD840 Offset: 0x27CD941 VA: 0x27CD840
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x27CE350 Offset: 0x27CE451 VA: 0x27CE350
	|-EnumAsStringFormatter<sbyte>..ctor
	|
	|-RVA: 0x27CEE40 Offset: 0x27CEF41 VA: 0x27CEE40
	|-EnumAsStringFormatter<float>..ctor
	|
	|-RVA: 0x27CF950 Offset: 0x27CFA51 VA: 0x27CF950
	|-EnumAsStringFormatter<ushort>..ctor
	|
	|-RVA: 0x27D0440 Offset: 0x27D0541 VA: 0x27D0440
	|-EnumAsStringFormatter<uint>..ctor
	|
	|-RVA: 0x27D0F30 Offset: 0x27D1031 VA: 0x27D0F30
	|-EnumAsStringFormatter<ulong>..ctor
	|
	|-RVA: 0x27D1A10 Offset: 0x27D1B11 VA: 0x27D1A10
	|-EnumAsStringFormatter<Bounds>..ctor
	|
	|-RVA: 0x27D25B0 Offset: 0x27D26B1 VA: 0x27D25B0
	|-EnumAsStringFormatter<BoundsInt>..ctor
	|
	|-RVA: 0x27D3150 Offset: 0x27D3251 VA: 0x27D3150
	|-EnumAsStringFormatter<Color32>..ctor
	|
	|-RVA: 0x27D3C40 Offset: 0x27D3D41 VA: 0x27D3C40
	|-EnumAsStringFormatter<Color>..ctor
	|
	|-RVA: 0x27D4790 Offset: 0x27D4891 VA: 0x27D4790
	|-EnumAsStringFormatter<GradientAlphaKey>..ctor
	|
	|-RVA: 0x27D5300 Offset: 0x27D5401 VA: 0x27D5300
	|-EnumAsStringFormatter<GradientColorKey>..ctor
	|
	|-RVA: 0x27D5EF0 Offset: 0x27D5FF1 VA: 0x27D5EF0
	|-EnumAsStringFormatter<Keyframe>..ctor
	|
	|-RVA: 0x27D6B30 Offset: 0x27D6C31 VA: 0x27D6B30
	|-EnumAsStringFormatter<LayerMask>..ctor
	|
	|-RVA: 0x27D7660 Offset: 0x27D7761 VA: 0x27D7660
	|-EnumAsStringFormatter<Matrix4x4>..ctor
	|
	|-RVA: 0x27D82A0 Offset: 0x27D83A1 VA: 0x27D82A0
	|-EnumAsStringFormatter<Quaternion>..ctor
	|
	|-RVA: 0x27D8DF0 Offset: 0x27D8EF1 VA: 0x27D8DF0
	|-EnumAsStringFormatter<RangeInt>..ctor
	|
	|-RVA: 0x27D9920 Offset: 0x27D9A21 VA: 0x27D9920
	|-EnumAsStringFormatter<Rect>..ctor
	|
	|-RVA: 0x27DA470 Offset: 0x27DA571 VA: 0x27DA470
	|-EnumAsStringFormatter<RectInt>..ctor
	|
	|-RVA: 0x27DAF60 Offset: 0x27DB061 VA: 0x27DAF60
	|-EnumAsStringFormatter<Vector2>..ctor
	|
	|-RVA: 0x27DBA90 Offset: 0x27DBB91 VA: 0x27DBA90
	|-EnumAsStringFormatter<Vector2Int>..ctor
	|
	|-RVA: 0x27DC570 Offset: 0x27DC671 VA: 0x27DC570
	|-EnumAsStringFormatter<Vector3>..ctor
	|
	|-RVA: 0x27DD0C0 Offset: 0x27DD1C1 VA: 0x27DD0C0
	|-EnumAsStringFormatter<Vector3Int>..ctor
	|
	|-RVA: 0x27DDBE0 Offset: 0x27DDCE1 VA: 0x27DDBE0
	|-EnumAsStringFormatter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D390 Offset: 0x270D491 VA: 0x270D390
	|-EnumAsStringFormatter<BitVector32Int>.Serialize
	|
	|-RVA: 0x270DEF0 Offset: 0x270DFF1 VA: 0x270DEF0
	|-EnumAsStringFormatter<EventCheckId>.Serialize
	|
	|-RVA: 0x270EB40 Offset: 0x270EC41 VA: 0x270EB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Serialize
	|
	|-RVA: 0x270F790 Offset: 0x270F891 VA: 0x270F790
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Serialize
	|
	|-RVA: 0x2710320 Offset: 0x2710421 VA: 0x2710320
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Serialize
	|
	|-RVA: 0x2710E70 Offset: 0x2710F71 VA: 0x2710E70
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Serialize
	|
	|-RVA: 0x2711A40 Offset: 0x2711B41 VA: 0x2711A40
	|-EnumAsStringFormatter<MonsterHutSaveData>.Serialize
	|
	|-RVA: 0x2712600 Offset: 0x2712701 VA: 0x2712600
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Serialize
	|
	|-RVA: 0x27131F0 Offset: 0x27132F1 VA: 0x27131F0
	|-EnumAsStringFormatter<OrderSaveData>.Serialize
	|
	|-RVA: 0x2713E10 Offset: 0x2713F11 VA: 0x2713E10
	|-EnumAsStringFormatter<OrderSaveParameter>.Serialize
	|
	|-RVA: 0x2714A40 Offset: 0x2714B41 VA: 0x2714A40
	|-EnumAsStringFormatter<Parameter>.Serialize
	|
	|-RVA: 0x2715610 Offset: 0x2715711 VA: 0x2715610
	|-EnumAsStringFormatter<bool>.Serialize
	|
	|-RVA: 0x2716100 Offset: 0x2716201 VA: 0x2716100
	|-EnumAsStringFormatter<byte>.Serialize
	|
	|-RVA: 0x2716BF0 Offset: 0x2716CF1 VA: 0x2716BF0
	|-EnumAsStringFormatter<char>.Serialize
	|
	|-RVA: 0x27176E0 Offset: 0x27177E1 VA: 0x27176E0
	|-EnumAsStringFormatter<DateTime>.Serialize
	|
	|-RVA: 0x27181E0 Offset: 0x27182E1 VA: 0x27181E0
	|-EnumAsStringFormatter<double>.Serialize
	|
	|-RVA: 0x2718CD0 Offset: 0x2718DD1 VA: 0x2718CD0
	|-EnumAsStringFormatter<short>.Serialize
	|
	|-RVA: 0x27197C0 Offset: 0x27198C1 VA: 0x27197C0
	|-EnumAsStringFormatter<int>.Serialize
	|
	|-RVA: 0x271A2B0 Offset: 0x271A3B1 VA: 0x271A2B0
	|-EnumAsStringFormatter<Int32Enum>.Serialize
	|
	|-RVA: 0x271ADC0 Offset: 0x271AEC1 VA: 0x271ADC0
	|-EnumAsStringFormatter<long>.Serialize
	|
	|-RVA: 0x271B890 Offset: 0x271B991 VA: 0x271B890
	|-EnumAsStringFormatter<Memory<object>>.Serialize
	|
	|-RVA: 0x271C390 Offset: 0x271C491 VA: 0x271C390
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Serialize
	|
	|-RVA: 0x271CED0 Offset: 0x271CFD1 VA: 0x271CED0
	|-EnumAsStringFormatter<Nullable<Bounds>>.Serialize
	|
	|-RVA: 0x271DAB0 Offset: 0x271DBB1 VA: 0x271DAB0
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Serialize
	|
	|-RVA: 0x271E630 Offset: 0x271E731 VA: 0x271E630
	|-EnumAsStringFormatter<Nullable<Color32>>.Serialize
	|
	|-RVA: 0x271F150 Offset: 0x271F251 VA: 0x271F150
	|-EnumAsStringFormatter<Nullable<Color>>.Serialize
	|
	|-RVA: 0x271FCD0 Offset: 0x271FDD1 VA: 0x271FCD0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Serialize
	|
	|-RVA: 0x2720810 Offset: 0x2720911 VA: 0x2720810
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Serialize
	|
	|-RVA: 0x2721390 Offset: 0x2721491 VA: 0x2721390
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Serialize
	|
	|-RVA: 0x2721EE0 Offset: 0x2721FE1 VA: 0x2721EE0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Serialize
	|
	|-RVA: 0x2722A70 Offset: 0x2722B71 VA: 0x2722A70
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Serialize
	|
	|-RVA: 0x27236D0 Offset: 0x27237D1 VA: 0x27236D0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Serialize
	|
	|-RVA: 0x2724250 Offset: 0x2724351 VA: 0x2724250
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Serialize
	|
	|-RVA: 0x2724D90 Offset: 0x2724E91 VA: 0x2724D90
	|-EnumAsStringFormatter<Nullable<Rect>>.Serialize
	|
	|-RVA: 0x27C8DF0 Offset: 0x27C8EF1 VA: 0x27C8DF0
	|-EnumAsStringFormatter<Nullable<RectInt>>.Serialize
	|
	|-RVA: 0x27C9970 Offset: 0x27C9A71 VA: 0x27C9970
	|-EnumAsStringFormatter<Nullable<Vector2>>.Serialize
	|
	|-RVA: 0x27CA4A0 Offset: 0x27CA5A1 VA: 0x27CA4A0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Serialize
	|
	|-RVA: 0x27CAFB0 Offset: 0x27CB0B1 VA: 0x27CAFB0
	|-EnumAsStringFormatter<Nullable<Vector3>>.Serialize
	|
	|-RVA: 0x27CBAB0 Offset: 0x27CBBB1 VA: 0x27CBAB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Serialize
	|
	|-RVA: 0x27CC5E0 Offset: 0x27CC6E1 VA: 0x27CC5E0
	|-EnumAsStringFormatter<Nullable<Vector4>>.Serialize
	|
	|-RVA: 0x27CD150 Offset: 0x27CD251 VA: 0x27CD150
	|-EnumAsStringFormatter<object>.Serialize
	|
	|-RVA: 0x27CDC20 Offset: 0x27CDD21 VA: 0x27CDC20
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Serialize
	|
	|-RVA: 0x27CE740 Offset: 0x27CE841 VA: 0x27CE740
	|-EnumAsStringFormatter<sbyte>.Serialize
	|
	|-RVA: 0x27CF250 Offset: 0x27CF351 VA: 0x27CF250
	|-EnumAsStringFormatter<float>.Serialize
	|
	|-RVA: 0x27CFD40 Offset: 0x27CFE41 VA: 0x27CFD40
	|-EnumAsStringFormatter<ushort>.Serialize
	|
	|-RVA: 0x27D0830 Offset: 0x27D0931 VA: 0x27D0830
	|-EnumAsStringFormatter<uint>.Serialize
	|
	|-RVA: 0x27D1320 Offset: 0x27D1421 VA: 0x27D1320
	|-EnumAsStringFormatter<ulong>.Serialize
	|
	|-RVA: 0x27D1E70 Offset: 0x27D1F71 VA: 0x27D1E70
	|-EnumAsStringFormatter<Bounds>.Serialize
	|
	|-RVA: 0x27D2A10 Offset: 0x27D2B11 VA: 0x27D2A10
	|-EnumAsStringFormatter<BoundsInt>.Serialize
	|
	|-RVA: 0x27D3540 Offset: 0x27D3641 VA: 0x27D3540
	|-EnumAsStringFormatter<Color32>.Serialize
	|
	|-RVA: 0x27D4070 Offset: 0x27D4171 VA: 0x27D4070
	|-EnumAsStringFormatter<Color>.Serialize
	|
	|-RVA: 0x27D4BA0 Offset: 0x27D4CA1 VA: 0x27D4BA0
	|-EnumAsStringFormatter<GradientAlphaKey>.Serialize
	|
	|-RVA: 0x27D5760 Offset: 0x27D5861 VA: 0x27D5760
	|-EnumAsStringFormatter<GradientColorKey>.Serialize
	|
	|-RVA: 0x27D6370 Offset: 0x27D6471 VA: 0x27D6370
	|-EnumAsStringFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x27D6F20 Offset: 0x27D7021 VA: 0x27D6F20
	|-EnumAsStringFormatter<LayerMask>.Serialize
	|
	|-RVA: 0x27D7B10 Offset: 0x27D7C11 VA: 0x27D7B10
	|-EnumAsStringFormatter<Matrix4x4>.Serialize
	|
	|-RVA: 0x27D86D0 Offset: 0x27D87D1 VA: 0x27D86D0
	|-EnumAsStringFormatter<Quaternion>.Serialize
	|
	|-RVA: 0x27D91E0 Offset: 0x27D92E1 VA: 0x27D91E0
	|-EnumAsStringFormatter<RangeInt>.Serialize
	|
	|-RVA: 0x27D9D50 Offset: 0x27D9E51 VA: 0x27D9D50
	|-EnumAsStringFormatter<Rect>.Serialize
	|
	|-RVA: 0x27DA850 Offset: 0x27DA951 VA: 0x27DA850
	|-EnumAsStringFormatter<RectInt>.Serialize
	|
	|-RVA: 0x27DB370 Offset: 0x27DB471 VA: 0x27DB370
	|-EnumAsStringFormatter<Vector2>.Serialize
	|
	|-RVA: 0x27DBE80 Offset: 0x27DBF81 VA: 0x27DBE80
	|-EnumAsStringFormatter<Vector2Int>.Serialize
	|
	|-RVA: 0x27DC990 Offset: 0x27DCA91 VA: 0x27DC990
	|-EnumAsStringFormatter<Vector3>.Serialize
	|
	|-RVA: 0x27DD4C0 Offset: 0x27DD5C1 VA: 0x27DD4C0
	|-EnumAsStringFormatter<Vector3Int>.Serialize
	|
	|-RVA: 0x27DE010 Offset: 0x27DE111 VA: 0x27DE010
	|-EnumAsStringFormatter<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D4C0 Offset: 0x270D5C1 VA: 0x270D4C0
	|-EnumAsStringFormatter<BitVector32Int>.Deserialize
	|
	|-RVA: 0x270E090 Offset: 0x270E191 VA: 0x270E090
	|-EnumAsStringFormatter<EventCheckId>.Deserialize
	|
	|-RVA: 0x270ED30 Offset: 0x270EE31 VA: 0x270ED30
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Deserialize
	|
	|-RVA: 0x270F930 Offset: 0x270FA31 VA: 0x270F930
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Deserialize
	|
	|-RVA: 0x27104B0 Offset: 0x27105B1 VA: 0x27104B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Deserialize
	|
	|-RVA: 0x2710FF0 Offset: 0x27110F1 VA: 0x2710FF0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Deserialize
	|
	|-RVA: 0x2711C00 Offset: 0x2711D01 VA: 0x2711C00
	|-EnumAsStringFormatter<MonsterHutSaveData>.Deserialize
	|
	|-RVA: 0x2712790 Offset: 0x2712891 VA: 0x2712790
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Deserialize
	|
	|-RVA: 0x27133B0 Offset: 0x27134B1 VA: 0x27133B0
	|-EnumAsStringFormatter<OrderSaveData>.Deserialize
	|
	|-RVA: 0x2713FB0 Offset: 0x27140B1 VA: 0x2713FB0
	|-EnumAsStringFormatter<OrderSaveParameter>.Deserialize
	|
	|-RVA: 0x2714BF0 Offset: 0x2714CF1 VA: 0x2714BF0
	|-EnumAsStringFormatter<Parameter>.Deserialize
	|
	|-RVA: 0x2715740 Offset: 0x2715841 VA: 0x2715740
	|-EnumAsStringFormatter<bool>.Deserialize
	|
	|-RVA: 0x2716230 Offset: 0x2716331 VA: 0x2716230
	|-EnumAsStringFormatter<byte>.Deserialize
	|
	|-RVA: 0x2716D20 Offset: 0x2716E21 VA: 0x2716D20
	|-EnumAsStringFormatter<char>.Deserialize
	|
	|-RVA: 0x2717800 Offset: 0x2717901 VA: 0x2717800
	|-EnumAsStringFormatter<DateTime>.Deserialize
	|
	|-RVA: 0x2718310 Offset: 0x2718411 VA: 0x2718310
	|-EnumAsStringFormatter<double>.Deserialize
	|
	|-RVA: 0x2718E00 Offset: 0x2718F01 VA: 0x2718E00
	|-EnumAsStringFormatter<short>.Deserialize
	|
	|-RVA: 0x27198F0 Offset: 0x27199F1 VA: 0x27198F0
	|-EnumAsStringFormatter<int>.Deserialize
	|
	|-RVA: 0x271A400 Offset: 0x271A501 VA: 0x271A400
	|-EnumAsStringFormatter<Int32Enum>.Deserialize
	|
	|-RVA: 0x271AEE0 Offset: 0x271AFE1 VA: 0x271AEE0
	|-EnumAsStringFormatter<long>.Deserialize
	|
	|-RVA: 0x271B9F0 Offset: 0x271BAF1 VA: 0x271B9F0
	|-EnumAsStringFormatter<Memory<object>>.Deserialize
	|
	|-RVA: 0x271C4E0 Offset: 0x271C5E1 VA: 0x271C4E0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Deserialize
	|
	|-RVA: 0x271D090 Offset: 0x271D191 VA: 0x271D090
	|-EnumAsStringFormatter<Nullable<Bounds>>.Deserialize
	|
	|-RVA: 0x271DC70 Offset: 0x271DD71 VA: 0x271DC70
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Deserialize
	|
	|-RVA: 0x271E780 Offset: 0x271E881 VA: 0x271E780
	|-EnumAsStringFormatter<Nullable<Color32>>.Deserialize
	|
	|-RVA: 0x271F2F0 Offset: 0x271F3F1 VA: 0x271F2F0
	|-EnumAsStringFormatter<Nullable<Color>>.Deserialize
	|
	|-RVA: 0x271FE30 Offset: 0x271FF31 VA: 0x271FE30
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Deserialize
	|
	|-RVA: 0x27209B0 Offset: 0x2720AB1 VA: 0x27209B0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Deserialize
	|
	|-RVA: 0x2721530 Offset: 0x2721631 VA: 0x2721530
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Deserialize
	|
	|-RVA: 0x2722030 Offset: 0x2722131 VA: 0x2722030
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Deserialize
	|
	|-RVA: 0x2722CA0 Offset: 0x2722DA1 VA: 0x2722CA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Deserialize
	|
	|-RVA: 0x2723870 Offset: 0x2723971 VA: 0x2723870
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Deserialize
	|
	|-RVA: 0x27243B0 Offset: 0x27244B1 VA: 0x27243B0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Deserialize
	|
	|-RVA: 0x2724F30 Offset: 0x2725031 VA: 0x2724F30
	|-EnumAsStringFormatter<Nullable<Rect>>.Deserialize
	|
	|-RVA: 0x27C8F90 Offset: 0x27C9091 VA: 0x27C8F90
	|-EnumAsStringFormatter<Nullable<RectInt>>.Deserialize
	|
	|-RVA: 0x27C9AD0 Offset: 0x27C9BD1 VA: 0x27C9AD0
	|-EnumAsStringFormatter<Nullable<Vector2>>.Deserialize
	|
	|-RVA: 0x27CA600 Offset: 0x27CA701 VA: 0x27CA600
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Deserialize
	|
	|-RVA: 0x27CB110 Offset: 0x27CB211 VA: 0x27CB110
	|-EnumAsStringFormatter<Nullable<Vector3>>.Deserialize
	|
	|-RVA: 0x27CBC10 Offset: 0x27CBD11 VA: 0x27CBC10
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Deserialize
	|
	|-RVA: 0x27CC780 Offset: 0x27CC881 VA: 0x27CC780
	|-EnumAsStringFormatter<Nullable<Vector4>>.Deserialize
	|
	|-RVA: 0x27CD280 Offset: 0x27CD381 VA: 0x27CD280
	|-EnumAsStringFormatter<object>.Deserialize
	|
	|-RVA: 0x27CDD80 Offset: 0x27CDE81 VA: 0x27CDD80
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Deserialize
	|
	|-RVA: 0x27CE870 Offset: 0x27CE971 VA: 0x27CE870
	|-EnumAsStringFormatter<sbyte>.Deserialize
	|
	|-RVA: 0x27CF380 Offset: 0x27CF481 VA: 0x27CF380
	|-EnumAsStringFormatter<float>.Deserialize
	|
	|-RVA: 0x27CFE70 Offset: 0x27CFF71 VA: 0x27CFE70
	|-EnumAsStringFormatter<ushort>.Deserialize
	|
	|-RVA: 0x27D0960 Offset: 0x27D0A61 VA: 0x27D0960
	|-EnumAsStringFormatter<uint>.Deserialize
	|
	|-RVA: 0x27D1440 Offset: 0x27D1541 VA: 0x27D1440
	|-EnumAsStringFormatter<ulong>.Deserialize
	|
	|-RVA: 0x27D1FC0 Offset: 0x27D20C1 VA: 0x27D1FC0
	|-EnumAsStringFormatter<Bounds>.Deserialize
	|
	|-RVA: 0x27D2B60 Offset: 0x27D2C61 VA: 0x27D2B60
	|-EnumAsStringFormatter<BoundsInt>.Deserialize
	|
	|-RVA: 0x27D3670 Offset: 0x27D3771 VA: 0x27D3670
	|-EnumAsStringFormatter<Color32>.Deserialize
	|
	|-RVA: 0x27D41C0 Offset: 0x27D42C1 VA: 0x27D41C0
	|-EnumAsStringFormatter<Color>.Deserialize
	|
	|-RVA: 0x27D4D20 Offset: 0x27D4E21 VA: 0x27D4D20
	|-EnumAsStringFormatter<GradientAlphaKey>.Deserialize
	|
	|-RVA: 0x27D5900 Offset: 0x27D5A01 VA: 0x27D5900
	|-EnumAsStringFormatter<GradientColorKey>.Deserialize
	|
	|-RVA: 0x27D6530 Offset: 0x27D6631 VA: 0x27D6530
	|-EnumAsStringFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x27D7090 Offset: 0x27D7191 VA: 0x27D7090
	|-EnumAsStringFormatter<LayerMask>.Deserialize
	|
	|-RVA: 0x27D7CA0 Offset: 0x27D7DA1 VA: 0x27D7CA0
	|-EnumAsStringFormatter<Matrix4x4>.Deserialize
	|
	|-RVA: 0x27D8820 Offset: 0x27D8921 VA: 0x27D8820
	|-EnumAsStringFormatter<Quaternion>.Deserialize
	|
	|-RVA: 0x27D9350 Offset: 0x27D9451 VA: 0x27D9350
	|-EnumAsStringFormatter<RangeInt>.Deserialize
	|
	|-RVA: 0x27D9EA0 Offset: 0x27D9FA1 VA: 0x27D9EA0
	|-EnumAsStringFormatter<Rect>.Deserialize
	|
	|-RVA: 0x27DA990 Offset: 0x27DAA91 VA: 0x27DA990
	|-EnumAsStringFormatter<RectInt>.Deserialize
	|
	|-RVA: 0x27DB4B0 Offset: 0x27DB5B1 VA: 0x27DB4B0
	|-EnumAsStringFormatter<Vector2>.Deserialize
	|
	|-RVA: 0x27DBFA0 Offset: 0x27DC0A1 VA: 0x27DBFA0
	|-EnumAsStringFormatter<Vector2Int>.Deserialize
	|
	|-RVA: 0x27DCAE0 Offset: 0x27DCBE1 VA: 0x27DCAE0
	|-EnumAsStringFormatter<Vector3>.Deserialize
	|
	|-RVA: 0x27DD600 Offset: 0x27DD701 VA: 0x27DD600
	|-EnumAsStringFormatter<Vector3Int>.Deserialize
	|
	|-RVA: 0x27DE160 Offset: 0x27DE261 VA: 0x27DE160
	|-EnumAsStringFormatter<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	private string GetClrNames(string serializedNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D6B0 Offset: 0x270D7B1 VA: 0x270D6B0
	|-EnumAsStringFormatter<BitVector32Int>.GetClrNames
	|
	|-RVA: 0x270E2A0 Offset: 0x270E3A1 VA: 0x270E2A0
	|-EnumAsStringFormatter<EventCheckId>.GetClrNames
	|
	|-RVA: 0x270EF50 Offset: 0x270F051 VA: 0x270EF50
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetClrNames
	|
	|-RVA: 0x270FB40 Offset: 0x270FC41 VA: 0x270FB40
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetClrNames
	|
	|-RVA: 0x27106B0 Offset: 0x27107B1 VA: 0x27106B0
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetClrNames
	|
	|-RVA: 0x27111E0 Offset: 0x27112E1 VA: 0x27111E0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetClrNames
	|
	|-RVA: 0x2711E20 Offset: 0x2711F21 VA: 0x2711E20
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetClrNames
	|
	|-RVA: 0x2712990 Offset: 0x2712A91 VA: 0x2712990
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetClrNames
	|
	|-RVA: 0x27135D0 Offset: 0x27136D1 VA: 0x27135D0
	|-EnumAsStringFormatter<OrderSaveData>.GetClrNames
	|
	|-RVA: 0x27141C0 Offset: 0x27142C1 VA: 0x27141C0
	|-EnumAsStringFormatter<OrderSaveParameter>.GetClrNames
	|
	|-RVA: 0x2714E30 Offset: 0x2714F31 VA: 0x2714E30
	|-EnumAsStringFormatter<Parameter>.GetClrNames
	|
	|-RVA: 0x2715930 Offset: 0x2715A31 VA: 0x2715930
	|-EnumAsStringFormatter<bool>.GetClrNames
	|
	|-RVA: 0x2716420 Offset: 0x2716521 VA: 0x2716420
	|-EnumAsStringFormatter<byte>.GetClrNames
	|
	|-RVA: 0x2716F10 Offset: 0x2717011 VA: 0x2716F10
	|-EnumAsStringFormatter<char>.GetClrNames
	|
	|-RVA: 0x27179F0 Offset: 0x2717AF1 VA: 0x27179F0
	|-EnumAsStringFormatter<DateTime>.GetClrNames
	|
	|-RVA: 0x2718500 Offset: 0x2718601 VA: 0x2718500
	|-EnumAsStringFormatter<double>.GetClrNames
	|
	|-RVA: 0x2718FF0 Offset: 0x27190F1 VA: 0x2718FF0
	|-EnumAsStringFormatter<short>.GetClrNames
	|
	|-RVA: 0x2719AE0 Offset: 0x2719BE1 VA: 0x2719AE0
	|-EnumAsStringFormatter<int>.GetClrNames
	|
	|-RVA: 0x271A5F0 Offset: 0x271A6F1 VA: 0x271A5F0
	|-EnumAsStringFormatter<Int32Enum>.GetClrNames
	|
	|-RVA: 0x271B0D0 Offset: 0x271B1D1 VA: 0x271B0D0
	|-EnumAsStringFormatter<long>.GetClrNames
	|
	|-RVA: 0x271BBE0 Offset: 0x271BCE1 VA: 0x271BBE0
	|-EnumAsStringFormatter<Memory<object>>.GetClrNames
	|
	|-RVA: 0x271C6C0 Offset: 0x271C7C1 VA: 0x271C6C0
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetClrNames
	|
	|-RVA: 0x271D2A0 Offset: 0x271D3A1 VA: 0x271D2A0
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetClrNames
	|
	|-RVA: 0x271DE80 Offset: 0x271DF81 VA: 0x271DE80
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetClrNames
	|
	|-RVA: 0x271E960 Offset: 0x271EA61 VA: 0x271E960
	|-EnumAsStringFormatter<Nullable<Color32>>.GetClrNames
	|
	|-RVA: 0x271F4F0 Offset: 0x271F5F1 VA: 0x271F4F0
	|-EnumAsStringFormatter<Nullable<Color>>.GetClrNames
	|
	|-RVA: 0x2720020 Offset: 0x2720121 VA: 0x2720020
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetClrNames
	|
	|-RVA: 0x2720BB0 Offset: 0x2720CB1 VA: 0x2720BB0
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetClrNames
	|
	|-RVA: 0x2721730 Offset: 0x2721831 VA: 0x2721730
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetClrNames
	|
	|-RVA: 0x2722210 Offset: 0x2722311 VA: 0x2722210
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetClrNames
	|
	|-RVA: 0x2722EE0 Offset: 0x2722FE1 VA: 0x2722EE0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetClrNames
	|
	|-RVA: 0x2723A70 Offset: 0x2723B71 VA: 0x2723A70
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetClrNames
	|
	|-RVA: 0x27245A0 Offset: 0x27246A1 VA: 0x27245A0
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetClrNames
	|
	|-RVA: 0x2725130 Offset: 0x2725231 VA: 0x2725130
	|-EnumAsStringFormatter<Nullable<Rect>>.GetClrNames
	|
	|-RVA: 0x27C9190 Offset: 0x27C9291 VA: 0x27C9190
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetClrNames
	|
	|-RVA: 0x27C9CC0 Offset: 0x27C9DC1 VA: 0x27C9CC0
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetClrNames
	|
	|-RVA: 0x27CA7F0 Offset: 0x27CA8F1 VA: 0x27CA7F0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetClrNames
	|
	|-RVA: 0x27CB2F0 Offset: 0x27CB3F1 VA: 0x27CB2F0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetClrNames
	|
	|-RVA: 0x27CBDF0 Offset: 0x27CBEF1 VA: 0x27CBDF0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetClrNames
	|
	|-RVA: 0x27CC980 Offset: 0x27CCA81 VA: 0x27CC980
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetClrNames
	|
	|-RVA: 0x27CD460 Offset: 0x27CD561 VA: 0x27CD460
	|-EnumAsStringFormatter<object>.GetClrNames
	|
	|-RVA: 0x27CDF70 Offset: 0x27CE071 VA: 0x27CDF70
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetClrNames
	|
	|-RVA: 0x27CEA60 Offset: 0x27CEB61 VA: 0x27CEA60
	|-EnumAsStringFormatter<sbyte>.GetClrNames
	|
	|-RVA: 0x27CF570 Offset: 0x27CF671 VA: 0x27CF570
	|-EnumAsStringFormatter<float>.GetClrNames
	|
	|-RVA: 0x27D0060 Offset: 0x27D0161 VA: 0x27D0060
	|-EnumAsStringFormatter<ushort>.GetClrNames
	|
	|-RVA: 0x27D0B50 Offset: 0x27D0C51 VA: 0x27D0B50
	|-EnumAsStringFormatter<uint>.GetClrNames
	|
	|-RVA: 0x27D1630 Offset: 0x27D1731 VA: 0x27D1630
	|-EnumAsStringFormatter<ulong>.GetClrNames
	|
	|-RVA: 0x27D21D0 Offset: 0x27D22D1 VA: 0x27D21D0
	|-EnumAsStringFormatter<Bounds>.GetClrNames
	|
	|-RVA: 0x27D2D70 Offset: 0x27D2E71 VA: 0x27D2D70
	|-EnumAsStringFormatter<BoundsInt>.GetClrNames
	|
	|-RVA: 0x27D3860 Offset: 0x27D3961 VA: 0x27D3860
	|-EnumAsStringFormatter<Color32>.GetClrNames
	|
	|-RVA: 0x27D43B0 Offset: 0x27D44B1 VA: 0x27D43B0
	|-EnumAsStringFormatter<Color>.GetClrNames
	|
	|-RVA: 0x27D4F20 Offset: 0x27D5021 VA: 0x27D4F20
	|-EnumAsStringFormatter<GradientAlphaKey>.GetClrNames
	|
	|-RVA: 0x27D5B10 Offset: 0x27D5C11 VA: 0x27D5B10
	|-EnumAsStringFormatter<GradientColorKey>.GetClrNames
	|
	|-RVA: 0x27D6750 Offset: 0x27D6851 VA: 0x27D6750
	|-EnumAsStringFormatter<Keyframe>.GetClrNames
	|
	|-RVA: 0x27D7280 Offset: 0x27D7381 VA: 0x27D7280
	|-EnumAsStringFormatter<LayerMask>.GetClrNames
	|
	|-RVA: 0x27D7EC0 Offset: 0x27D7FC1 VA: 0x27D7EC0
	|-EnumAsStringFormatter<Matrix4x4>.GetClrNames
	|
	|-RVA: 0x27D8A10 Offset: 0x27D8B11 VA: 0x27D8A10
	|-EnumAsStringFormatter<Quaternion>.GetClrNames
	|
	|-RVA: 0x27D9540 Offset: 0x27D9641 VA: 0x27D9540
	|-EnumAsStringFormatter<RangeInt>.GetClrNames
	|
	|-RVA: 0x27DA090 Offset: 0x27DA191 VA: 0x27DA090
	|-EnumAsStringFormatter<Rect>.GetClrNames
	|
	|-RVA: 0x27DAB80 Offset: 0x27DAC81 VA: 0x27DAB80
	|-EnumAsStringFormatter<RectInt>.GetClrNames
	|
	|-RVA: 0x27DB6B0 Offset: 0x27DB7B1 VA: 0x27DB6B0
	|-EnumAsStringFormatter<Vector2>.GetClrNames
	|
	|-RVA: 0x27DC190 Offset: 0x27DC291 VA: 0x27DC190
	|-EnumAsStringFormatter<Vector2Int>.GetClrNames
	|
	|-RVA: 0x27DCCE0 Offset: 0x27DCDE1 VA: 0x27DCCE0
	|-EnumAsStringFormatter<Vector3>.GetClrNames
	|
	|-RVA: 0x27DD800 Offset: 0x27DD901 VA: 0x27DD800
	|-EnumAsStringFormatter<Vector3Int>.GetClrNames
	|
	|-RVA: 0x27DE350 Offset: 0x27DE451 VA: 0x27DE350
	|-EnumAsStringFormatter<Vector4>.GetClrNames
	*/

	// RVA: -1 Offset: -1
	private string GetSerializedNames(string clrNames) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D770 Offset: 0x270D871 VA: 0x270D770
	|-EnumAsStringFormatter<BitVector32Int>.GetSerializedNames
	|
	|-RVA: 0x270E360 Offset: 0x270E461 VA: 0x270E360
	|-EnumAsStringFormatter<EventCheckId>.GetSerializedNames
	|
	|-RVA: 0x270F010 Offset: 0x270F111 VA: 0x270F010
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.GetSerializedNames
	|
	|-RVA: 0x270FC00 Offset: 0x270FD01 VA: 0x270FC00
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.GetSerializedNames
	|
	|-RVA: 0x2710770 Offset: 0x2710871 VA: 0x2710770
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.GetSerializedNames
	|
	|-RVA: 0x27112A0 Offset: 0x27113A1 VA: 0x27112A0
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.GetSerializedNames
	|
	|-RVA: 0x2711EE0 Offset: 0x2711FE1 VA: 0x2711EE0
	|-EnumAsStringFormatter<MonsterHutSaveData>.GetSerializedNames
	|
	|-RVA: 0x2712A50 Offset: 0x2712B51 VA: 0x2712A50
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2713690 Offset: 0x2713791 VA: 0x2713690
	|-EnumAsStringFormatter<OrderSaveData>.GetSerializedNames
	|
	|-RVA: 0x2714280 Offset: 0x2714381 VA: 0x2714280
	|-EnumAsStringFormatter<OrderSaveParameter>.GetSerializedNames
	|
	|-RVA: 0x2714EF0 Offset: 0x2714FF1 VA: 0x2714EF0
	|-EnumAsStringFormatter<Parameter>.GetSerializedNames
	|
	|-RVA: 0x27159F0 Offset: 0x2715AF1 VA: 0x27159F0
	|-EnumAsStringFormatter<bool>.GetSerializedNames
	|
	|-RVA: 0x27164E0 Offset: 0x27165E1 VA: 0x27164E0
	|-EnumAsStringFormatter<byte>.GetSerializedNames
	|
	|-RVA: 0x2716FD0 Offset: 0x27170D1 VA: 0x2716FD0
	|-EnumAsStringFormatter<char>.GetSerializedNames
	|
	|-RVA: 0x2717AB0 Offset: 0x2717BB1 VA: 0x2717AB0
	|-EnumAsStringFormatter<DateTime>.GetSerializedNames
	|
	|-RVA: 0x27185C0 Offset: 0x27186C1 VA: 0x27185C0
	|-EnumAsStringFormatter<double>.GetSerializedNames
	|
	|-RVA: 0x27190B0 Offset: 0x27191B1 VA: 0x27190B0
	|-EnumAsStringFormatter<short>.GetSerializedNames
	|
	|-RVA: 0x2719BA0 Offset: 0x2719CA1 VA: 0x2719BA0
	|-EnumAsStringFormatter<int>.GetSerializedNames
	|
	|-RVA: 0x271A6B0 Offset: 0x271A7B1 VA: 0x271A6B0
	|-EnumAsStringFormatter<Int32Enum>.GetSerializedNames
	|
	|-RVA: 0x271B190 Offset: 0x271B291 VA: 0x271B190
	|-EnumAsStringFormatter<long>.GetSerializedNames
	|
	|-RVA: 0x271BCA0 Offset: 0x271BDA1 VA: 0x271BCA0
	|-EnumAsStringFormatter<Memory<object>>.GetSerializedNames
	|
	|-RVA: 0x271C780 Offset: 0x271C881 VA: 0x271C780
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.GetSerializedNames
	|
	|-RVA: 0x271D360 Offset: 0x271D461 VA: 0x271D360
	|-EnumAsStringFormatter<Nullable<Bounds>>.GetSerializedNames
	|
	|-RVA: 0x271DF40 Offset: 0x271E041 VA: 0x271DF40
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.GetSerializedNames
	|
	|-RVA: 0x271EA20 Offset: 0x271EB21 VA: 0x271EA20
	|-EnumAsStringFormatter<Nullable<Color32>>.GetSerializedNames
	|
	|-RVA: 0x271F5B0 Offset: 0x271F6B1 VA: 0x271F5B0
	|-EnumAsStringFormatter<Nullable<Color>>.GetSerializedNames
	|
	|-RVA: 0x27200E0 Offset: 0x27201E1 VA: 0x27200E0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.GetSerializedNames
	|
	|-RVA: 0x2720C70 Offset: 0x2720D71 VA: 0x2720C70
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.GetSerializedNames
	|
	|-RVA: 0x27217F0 Offset: 0x27218F1 VA: 0x27217F0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.GetSerializedNames
	|
	|-RVA: 0x27222D0 Offset: 0x27223D1 VA: 0x27222D0
	|-EnumAsStringFormatter<Nullable<LayerMask>>.GetSerializedNames
	|
	|-RVA: 0x2722FA0 Offset: 0x27230A1 VA: 0x2722FA0
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.GetSerializedNames
	|
	|-RVA: 0x2723B30 Offset: 0x2723C31 VA: 0x2723B30
	|-EnumAsStringFormatter<Nullable<Quaternion>>.GetSerializedNames
	|
	|-RVA: 0x2724660 Offset: 0x2724761 VA: 0x2724660
	|-EnumAsStringFormatter<Nullable<RangeInt>>.GetSerializedNames
	|
	|-RVA: 0x27251F0 Offset: 0x27252F1 VA: 0x27251F0
	|-EnumAsStringFormatter<Nullable<Rect>>.GetSerializedNames
	|
	|-RVA: 0x27C9250 Offset: 0x27C9351 VA: 0x27C9250
	|-EnumAsStringFormatter<Nullable<RectInt>>.GetSerializedNames
	|
	|-RVA: 0x27C9D80 Offset: 0x27C9E81 VA: 0x27C9D80
	|-EnumAsStringFormatter<Nullable<Vector2>>.GetSerializedNames
	|
	|-RVA: 0x27CA8B0 Offset: 0x27CA9B1 VA: 0x27CA8B0
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.GetSerializedNames
	|
	|-RVA: 0x27CB3B0 Offset: 0x27CB4B1 VA: 0x27CB3B0
	|-EnumAsStringFormatter<Nullable<Vector3>>.GetSerializedNames
	|
	|-RVA: 0x27CBEB0 Offset: 0x27CBFB1 VA: 0x27CBEB0
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.GetSerializedNames
	|
	|-RVA: 0x27CCA40 Offset: 0x27CCB41 VA: 0x27CCA40
	|-EnumAsStringFormatter<Nullable<Vector4>>.GetSerializedNames
	|
	|-RVA: 0x27CD520 Offset: 0x27CD621 VA: 0x27CD520
	|-EnumAsStringFormatter<object>.GetSerializedNames
	|
	|-RVA: 0x27CE030 Offset: 0x27CE131 VA: 0x27CE030
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.GetSerializedNames
	|
	|-RVA: 0x27CEB20 Offset: 0x27CEC21 VA: 0x27CEB20
	|-EnumAsStringFormatter<sbyte>.GetSerializedNames
	|
	|-RVA: 0x27CF630 Offset: 0x27CF731 VA: 0x27CF630
	|-EnumAsStringFormatter<float>.GetSerializedNames
	|
	|-RVA: 0x27D0120 Offset: 0x27D0221 VA: 0x27D0120
	|-EnumAsStringFormatter<ushort>.GetSerializedNames
	|
	|-RVA: 0x27D0C10 Offset: 0x27D0D11 VA: 0x27D0C10
	|-EnumAsStringFormatter<uint>.GetSerializedNames
	|
	|-RVA: 0x27D16F0 Offset: 0x27D17F1 VA: 0x27D16F0
	|-EnumAsStringFormatter<ulong>.GetSerializedNames
	|
	|-RVA: 0x27D2290 Offset: 0x27D2391 VA: 0x27D2290
	|-EnumAsStringFormatter<Bounds>.GetSerializedNames
	|
	|-RVA: 0x27D2E30 Offset: 0x27D2F31 VA: 0x27D2E30
	|-EnumAsStringFormatter<BoundsInt>.GetSerializedNames
	|
	|-RVA: 0x27D3920 Offset: 0x27D3A21 VA: 0x27D3920
	|-EnumAsStringFormatter<Color32>.GetSerializedNames
	|
	|-RVA: 0x27D4470 Offset: 0x27D4571 VA: 0x27D4470
	|-EnumAsStringFormatter<Color>.GetSerializedNames
	|
	|-RVA: 0x27D4FE0 Offset: 0x27D50E1 VA: 0x27D4FE0
	|-EnumAsStringFormatter<GradientAlphaKey>.GetSerializedNames
	|
	|-RVA: 0x27D5BD0 Offset: 0x27D5CD1 VA: 0x27D5BD0
	|-EnumAsStringFormatter<GradientColorKey>.GetSerializedNames
	|
	|-RVA: 0x27D6810 Offset: 0x27D6911 VA: 0x27D6810
	|-EnumAsStringFormatter<Keyframe>.GetSerializedNames
	|
	|-RVA: 0x27D7340 Offset: 0x27D7441 VA: 0x27D7340
	|-EnumAsStringFormatter<LayerMask>.GetSerializedNames
	|
	|-RVA: 0x27D7F80 Offset: 0x27D8081 VA: 0x27D7F80
	|-EnumAsStringFormatter<Matrix4x4>.GetSerializedNames
	|
	|-RVA: 0x27D8AD0 Offset: 0x27D8BD1 VA: 0x27D8AD0
	|-EnumAsStringFormatter<Quaternion>.GetSerializedNames
	|
	|-RVA: 0x27D9600 Offset: 0x27D9701 VA: 0x27D9600
	|-EnumAsStringFormatter<RangeInt>.GetSerializedNames
	|
	|-RVA: 0x27DA150 Offset: 0x27DA251 VA: 0x27DA150
	|-EnumAsStringFormatter<Rect>.GetSerializedNames
	|
	|-RVA: 0x27DAC40 Offset: 0x27DAD41 VA: 0x27DAC40
	|-EnumAsStringFormatter<RectInt>.GetSerializedNames
	|
	|-RVA: 0x27DB770 Offset: 0x27DB871 VA: 0x27DB770
	|-EnumAsStringFormatter<Vector2>.GetSerializedNames
	|
	|-RVA: 0x27DC250 Offset: 0x27DC351 VA: 0x27DC250
	|-EnumAsStringFormatter<Vector2Int>.GetSerializedNames
	|
	|-RVA: 0x27DCDA0 Offset: 0x27DCEA1 VA: 0x27DCDA0
	|-EnumAsStringFormatter<Vector3>.GetSerializedNames
	|
	|-RVA: 0x27DD8C0 Offset: 0x27DD9C1 VA: 0x27DD8C0
	|-EnumAsStringFormatter<Vector3Int>.GetSerializedNames
	|
	|-RVA: 0x27DE410 Offset: 0x27DE511 VA: 0x27DE410
	|-EnumAsStringFormatter<Vector4>.GetSerializedNames
	*/

	// RVA: -1 Offset: -1
	private static string Translate(string items, IReadOnlyDictionary<string, string> mapping) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270D830 Offset: 0x270D931 VA: 0x270D830
	|-EnumAsStringFormatter<BitVector32Int>.Translate
	|
	|-RVA: 0x270E420 Offset: 0x270E521 VA: 0x270E420
	|-EnumAsStringFormatter<EventCheckId>.Translate
	|
	|-RVA: 0x270F0D0 Offset: 0x270F1D1 VA: 0x270F0D0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE>.Translate
	|
	|-RVA: 0x270FCC0 Offset: 0x270FDC1 VA: 0x270FCC0
	|-EnumAsStringFormatter<FarmManager.RF4_CROP_STATE_INFO>.Translate
	|
	|-RVA: 0x2710830 Offset: 0x2710931 VA: 0x2710830
	|-EnumAsStringFormatter<FarmManager.RF4_MCROP_INFO>.Translate
	|
	|-RVA: 0x2711360 Offset: 0x2711461 VA: 0x2711360
	|-EnumAsStringFormatter<FarmManager.RF4_SOIL_INFO>.Translate
	|
	|-RVA: 0x2711FA0 Offset: 0x27120A1 VA: 0x2711FA0
	|-EnumAsStringFormatter<MonsterHutSaveData>.Translate
	|
	|-RVA: 0x2712B10 Offset: 0x2712C11 VA: 0x2712B10
	|-EnumAsStringFormatter<OrderLotterySaveParameter>.Translate
	|
	|-RVA: 0x2713750 Offset: 0x2713851 VA: 0x2713750
	|-EnumAsStringFormatter<OrderSaveData>.Translate
	|
	|-RVA: 0x2714340 Offset: 0x2714441 VA: 0x2714340
	|-EnumAsStringFormatter<OrderSaveParameter>.Translate
	|
	|-RVA: 0x2714FB0 Offset: 0x27150B1 VA: 0x2714FB0
	|-EnumAsStringFormatter<Parameter>.Translate
	|
	|-RVA: 0x2715AB0 Offset: 0x2715BB1 VA: 0x2715AB0
	|-EnumAsStringFormatter<bool>.Translate
	|
	|-RVA: 0x27165A0 Offset: 0x27166A1 VA: 0x27165A0
	|-EnumAsStringFormatter<byte>.Translate
	|
	|-RVA: 0x2717090 Offset: 0x2717191 VA: 0x2717090
	|-EnumAsStringFormatter<char>.Translate
	|
	|-RVA: 0x2717B70 Offset: 0x2717C71 VA: 0x2717B70
	|-EnumAsStringFormatter<DateTime>.Translate
	|
	|-RVA: 0x2718680 Offset: 0x2718781 VA: 0x2718680
	|-EnumAsStringFormatter<double>.Translate
	|
	|-RVA: 0x2719170 Offset: 0x2719271 VA: 0x2719170
	|-EnumAsStringFormatter<short>.Translate
	|
	|-RVA: 0x2719C60 Offset: 0x2719D61 VA: 0x2719C60
	|-EnumAsStringFormatter<int>.Translate
	|
	|-RVA: 0x271A770 Offset: 0x271A871 VA: 0x271A770
	|-EnumAsStringFormatter<Int32Enum>.Translate
	|
	|-RVA: 0x271B250 Offset: 0x271B351 VA: 0x271B250
	|-EnumAsStringFormatter<long>.Translate
	|
	|-RVA: 0x271BD60 Offset: 0x271BE61 VA: 0x271BD60
	|-EnumAsStringFormatter<Memory<object>>.Translate
	|
	|-RVA: 0x271C840 Offset: 0x271C941 VA: 0x271C840
	|-EnumAsStringFormatter<Nullable<Int32Enum>>.Translate
	|
	|-RVA: 0x271D420 Offset: 0x271D521 VA: 0x271D420
	|-EnumAsStringFormatter<Nullable<Bounds>>.Translate
	|
	|-RVA: 0x271E000 Offset: 0x271E101 VA: 0x271E000
	|-EnumAsStringFormatter<Nullable<BoundsInt>>.Translate
	|
	|-RVA: 0x271EAE0 Offset: 0x271EBE1 VA: 0x271EAE0
	|-EnumAsStringFormatter<Nullable<Color32>>.Translate
	|
	|-RVA: 0x271F670 Offset: 0x271F771 VA: 0x271F670
	|-EnumAsStringFormatter<Nullable<Color>>.Translate
	|
	|-RVA: 0x27201A0 Offset: 0x27202A1 VA: 0x27201A0
	|-EnumAsStringFormatter<Nullable<GradientAlphaKey>>.Translate
	|
	|-RVA: 0x2720D30 Offset: 0x2720E31 VA: 0x2720D30
	|-EnumAsStringFormatter<Nullable<GradientColorKey>>.Translate
	|
	|-RVA: 0x27218B0 Offset: 0x27219B1 VA: 0x27218B0
	|-EnumAsStringFormatter<Nullable<Keyframe>>.Translate
	|
	|-RVA: 0x2722390 Offset: 0x2722491 VA: 0x2722390
	|-EnumAsStringFormatter<Nullable<LayerMask>>.Translate
	|
	|-RVA: 0x2723060 Offset: 0x2723161 VA: 0x2723060
	|-EnumAsStringFormatter<Nullable<Matrix4x4>>.Translate
	|
	|-RVA: 0x2723BF0 Offset: 0x2723CF1 VA: 0x2723BF0
	|-EnumAsStringFormatter<Nullable<Quaternion>>.Translate
	|
	|-RVA: 0x2724720 Offset: 0x2724821 VA: 0x2724720
	|-EnumAsStringFormatter<Nullable<RangeInt>>.Translate
	|
	|-RVA: 0x27252B0 Offset: 0x27253B1 VA: 0x27252B0
	|-EnumAsStringFormatter<Nullable<Rect>>.Translate
	|
	|-RVA: 0x27C9310 Offset: 0x27C9411 VA: 0x27C9310
	|-EnumAsStringFormatter<Nullable<RectInt>>.Translate
	|
	|-RVA: 0x27C9E40 Offset: 0x27C9F41 VA: 0x27C9E40
	|-EnumAsStringFormatter<Nullable<Vector2>>.Translate
	|
	|-RVA: 0x27CA970 Offset: 0x27CAA71 VA: 0x27CA970
	|-EnumAsStringFormatter<Nullable<Vector2Int>>.Translate
	|
	|-RVA: 0x27CB470 Offset: 0x27CB571 VA: 0x27CB470
	|-EnumAsStringFormatter<Nullable<Vector3>>.Translate
	|
	|-RVA: 0x27CBF70 Offset: 0x27CC071 VA: 0x27CBF70
	|-EnumAsStringFormatter<Nullable<Vector3Int>>.Translate
	|
	|-RVA: 0x27CCB00 Offset: 0x27CCC01 VA: 0x27CCB00
	|-EnumAsStringFormatter<Nullable<Vector4>>.Translate
	|
	|-RVA: 0x27CD5E0 Offset: 0x27CD6E1 VA: 0x27CD5E0
	|-EnumAsStringFormatter<object>.Translate
	|
	|-RVA: 0x27CE0F0 Offset: 0x27CE1F1 VA: 0x27CE0F0
	|-EnumAsStringFormatter<ReadOnlyMemory<object>>.Translate
	|
	|-RVA: 0x27CEBE0 Offset: 0x27CECE1 VA: 0x27CEBE0
	|-EnumAsStringFormatter<sbyte>.Translate
	|
	|-RVA: 0x27CF6F0 Offset: 0x27CF7F1 VA: 0x27CF6F0
	|-EnumAsStringFormatter<float>.Translate
	|
	|-RVA: 0x27D01E0 Offset: 0x27D02E1 VA: 0x27D01E0
	|-EnumAsStringFormatter<ushort>.Translate
	|
	|-RVA: 0x27D0CD0 Offset: 0x27D0DD1 VA: 0x27D0CD0
	|-EnumAsStringFormatter<uint>.Translate
	|
	|-RVA: 0x27D17B0 Offset: 0x27D18B1 VA: 0x27D17B0
	|-EnumAsStringFormatter<ulong>.Translate
	|
	|-RVA: 0x27D2350 Offset: 0x27D2451 VA: 0x27D2350
	|-EnumAsStringFormatter<Bounds>.Translate
	|
	|-RVA: 0x27D2EF0 Offset: 0x27D2FF1 VA: 0x27D2EF0
	|-EnumAsStringFormatter<BoundsInt>.Translate
	|
	|-RVA: 0x27D39E0 Offset: 0x27D3AE1 VA: 0x27D39E0
	|-EnumAsStringFormatter<Color32>.Translate
	|
	|-RVA: 0x27D4530 Offset: 0x27D4631 VA: 0x27D4530
	|-EnumAsStringFormatter<Color>.Translate
	|
	|-RVA: 0x27D50A0 Offset: 0x27D51A1 VA: 0x27D50A0
	|-EnumAsStringFormatter<GradientAlphaKey>.Translate
	|
	|-RVA: 0x27D5C90 Offset: 0x27D5D91 VA: 0x27D5C90
	|-EnumAsStringFormatter<GradientColorKey>.Translate
	|
	|-RVA: 0x27D68D0 Offset: 0x27D69D1 VA: 0x27D68D0
	|-EnumAsStringFormatter<Keyframe>.Translate
	|
	|-RVA: 0x27D7400 Offset: 0x27D7501 VA: 0x27D7400
	|-EnumAsStringFormatter<LayerMask>.Translate
	|
	|-RVA: 0x27D8040 Offset: 0x27D8141 VA: 0x27D8040
	|-EnumAsStringFormatter<Matrix4x4>.Translate
	|
	|-RVA: 0x27D8B90 Offset: 0x27D8C91 VA: 0x27D8B90
	|-EnumAsStringFormatter<Quaternion>.Translate
	|
	|-RVA: 0x27D96C0 Offset: 0x27D97C1 VA: 0x27D96C0
	|-EnumAsStringFormatter<RangeInt>.Translate
	|
	|-RVA: 0x27DA210 Offset: 0x27DA311 VA: 0x27DA210
	|-EnumAsStringFormatter<Rect>.Translate
	|
	|-RVA: 0x27DAD00 Offset: 0x27DAE01 VA: 0x27DAD00
	|-EnumAsStringFormatter<RectInt>.Translate
	|
	|-RVA: 0x27DB830 Offset: 0x27DB931 VA: 0x27DB830
	|-EnumAsStringFormatter<Vector2>.Translate
	|
	|-RVA: 0x27DC310 Offset: 0x27DC411 VA: 0x27DC310
	|-EnumAsStringFormatter<Vector2Int>.Translate
	|
	|-RVA: 0x27DCE60 Offset: 0x27DCF61 VA: 0x27DCE60
	|-EnumAsStringFormatter<Vector3>.Translate
	|
	|-RVA: 0x27DD980 Offset: 0x27DDA81 VA: 0x27DD980
	|-EnumAsStringFormatter<Vector3Int>.Translate
	|
	|-RVA: 0x27DE4D0 Offset: 0x27DE5D1 VA: 0x27DE4D0
	|-EnumAsStringFormatter<Vector4>.Translate
	*/
}

