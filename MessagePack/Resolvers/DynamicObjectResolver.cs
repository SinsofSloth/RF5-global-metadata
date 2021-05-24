public sealed class DynamicObjectResolver : IFormatterResolver // TypeDefIndex: 5238
{
	// Fields
	private const string ModuleName = "MessagePack.Resolvers.DynamicObjectResolver";
	public static readonly DynamicObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	internal static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x10

	// Methods

	// RVA: 0x14F3B50 Offset: 0x14F3C51 VA: 0x14F3B50
	private static void .cctor() { }

	// RVA: 0x14F3CA0 Offset: 0x14F3DA1 VA: 0x14F3CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1824990 Offset: 0x1824A91 VA: 0x1824990
	|-DynamicObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1824A40 Offset: 0x1824B41 VA: 0x1824A40
	|-DynamicObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1824AF0 Offset: 0x1824BF1 VA: 0x1824AF0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1824BA0 Offset: 0x1824CA1 VA: 0x1824BA0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1824C50 Offset: 0x1824D51 VA: 0x1824C50
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1824D00 Offset: 0x1824E01 VA: 0x1824D00
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1824DB0 Offset: 0x1824EB1 VA: 0x1824DB0
	|-DynamicObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1824E60 Offset: 0x1824F61 VA: 0x1824E60
	|-DynamicObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1824F10 Offset: 0x1825011 VA: 0x1824F10
	|-DynamicObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1824FC0 Offset: 0x18250C1 VA: 0x1824FC0
	|-DynamicObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1825070 Offset: 0x1825171 VA: 0x1825070
	|-DynamicObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1825120 Offset: 0x1825221 VA: 0x1825120
	|-DynamicObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x18251D0 Offset: 0x18252D1 VA: 0x18251D0
	|-DynamicObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1825280 Offset: 0x1825381 VA: 0x1825280
	|-DynamicObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x1825330 Offset: 0x1825431 VA: 0x1825330
	|-DynamicObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18253E0 Offset: 0x18254E1 VA: 0x18253E0
	|-DynamicObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1825490 Offset: 0x1825591 VA: 0x1825490
	|-DynamicObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x1825540 Offset: 0x1825641 VA: 0x1825540
	|-DynamicObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x18255F0 Offset: 0x18256F1 VA: 0x18255F0
	|-DynamicObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18256A0 Offset: 0x18257A1 VA: 0x18256A0
	|-DynamicObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x1825750 Offset: 0x1825851 VA: 0x1825750
	|-DynamicObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1825800 Offset: 0x1825901 VA: 0x1825800
	|-DynamicObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x18258B0 Offset: 0x18259B1 VA: 0x18258B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1825960 Offset: 0x1825A61 VA: 0x1825960
	|-DynamicObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1825A10 Offset: 0x1825B11 VA: 0x1825A10
	|-DynamicObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1825AC0 Offset: 0x1825BC1 VA: 0x1825AC0
	|-DynamicObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1825B70 Offset: 0x1825C71 VA: 0x1825B70
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1825C20 Offset: 0x1825D21 VA: 0x1825C20
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1825CD0 Offset: 0x1825DD1 VA: 0x1825CD0
	|-DynamicObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1825D80 Offset: 0x1825E81 VA: 0x1825D80
	|-DynamicObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1825E30 Offset: 0x1825F31 VA: 0x1825E30
	|-DynamicObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1825EE0 Offset: 0x1825FE1 VA: 0x1825EE0
	|-DynamicObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1825F90 Offset: 0x1826091 VA: 0x1825F90
	|-DynamicObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1826040 Offset: 0x1826141 VA: 0x1826040
	|-DynamicObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18260F0 Offset: 0x18261F1 VA: 0x18260F0
	|-DynamicObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18261A0 Offset: 0x18262A1 VA: 0x18261A0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1826250 Offset: 0x1826351 VA: 0x1826250
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1826300 Offset: 0x1826401 VA: 0x1826300
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x18263B0 Offset: 0x18264B1 VA: 0x18263B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1826460 Offset: 0x1826561 VA: 0x1826460
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1826510 Offset: 0x1826611 VA: 0x1826510
	|-DynamicObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x18265C0 Offset: 0x18266C1 VA: 0x18265C0
	|-DynamicObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1826670 Offset: 0x1826771 VA: 0x1826670
	|-DynamicObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1826720 Offset: 0x1826821 VA: 0x1826720
	|-DynamicObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x18267D0 Offset: 0x18268D1 VA: 0x18267D0
	|-DynamicObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1826880 Offset: 0x1826981 VA: 0x1826880
	|-DynamicObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x1826930 Offset: 0x1826A31 VA: 0x1826930
	|-DynamicObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x18269E0 Offset: 0x1826AE1 VA: 0x18269E0
	|-DynamicObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1826A90 Offset: 0x1826B91 VA: 0x1826A90
	|-DynamicObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1826B40 Offset: 0x1826C41 VA: 0x1826B40
	|-DynamicObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1826BF0 Offset: 0x1826CF1 VA: 0x1826BF0
	|-DynamicObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1826CA0 Offset: 0x1826DA1 VA: 0x1826CA0
	|-DynamicObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1826D50 Offset: 0x1826E51 VA: 0x1826D50
	|-DynamicObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1826E00 Offset: 0x1826F01 VA: 0x1826E00
	|-DynamicObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1826EB0 Offset: 0x1826FB1 VA: 0x1826EB0
	|-DynamicObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1826F60 Offset: 0x1827061 VA: 0x1826F60
	|-DynamicObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1827010 Offset: 0x1827111 VA: 0x1827010
	|-DynamicObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18270C0 Offset: 0x18271C1 VA: 0x18270C0
	|-DynamicObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1827170 Offset: 0x1827271 VA: 0x1827170
	|-DynamicObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1827220 Offset: 0x1827321 VA: 0x1827220
	|-DynamicObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x18272D0 Offset: 0x18273D1 VA: 0x18272D0
	|-DynamicObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1827380 Offset: 0x1827481 VA: 0x1827380
	|-DynamicObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1827430 Offset: 0x1827531 VA: 0x1827430
	|-DynamicObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18274E0 Offset: 0x18275E1 VA: 0x18274E0
	|-DynamicObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1827590 Offset: 0x1827691 VA: 0x1827590
	|-DynamicObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicObjectResolver : IFormatterResolver // TypeDefIndex: 5238
{
	// Fields
	private const string ModuleName = "MessagePack.Resolvers.DynamicObjectResolver";
	public static readonly DynamicObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	internal static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x10

	// Methods

	// RVA: 0x14F3B50 Offset: 0x14F3C51 VA: 0x14F3B50
	private static void .cctor() { }

	// RVA: 0x14F3CA0 Offset: 0x14F3DA1 VA: 0x14F3CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1824990 Offset: 0x1824A91 VA: 0x1824990
	|-DynamicObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1824A40 Offset: 0x1824B41 VA: 0x1824A40
	|-DynamicObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1824AF0 Offset: 0x1824BF1 VA: 0x1824AF0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1824BA0 Offset: 0x1824CA1 VA: 0x1824BA0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1824C50 Offset: 0x1824D51 VA: 0x1824C50
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1824D00 Offset: 0x1824E01 VA: 0x1824D00
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1824DB0 Offset: 0x1824EB1 VA: 0x1824DB0
	|-DynamicObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1824E60 Offset: 0x1824F61 VA: 0x1824E60
	|-DynamicObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1824F10 Offset: 0x1825011 VA: 0x1824F10
	|-DynamicObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1824FC0 Offset: 0x18250C1 VA: 0x1824FC0
	|-DynamicObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1825070 Offset: 0x1825171 VA: 0x1825070
	|-DynamicObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1825120 Offset: 0x1825221 VA: 0x1825120
	|-DynamicObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x18251D0 Offset: 0x18252D1 VA: 0x18251D0
	|-DynamicObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1825280 Offset: 0x1825381 VA: 0x1825280
	|-DynamicObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x1825330 Offset: 0x1825431 VA: 0x1825330
	|-DynamicObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18253E0 Offset: 0x18254E1 VA: 0x18253E0
	|-DynamicObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1825490 Offset: 0x1825591 VA: 0x1825490
	|-DynamicObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x1825540 Offset: 0x1825641 VA: 0x1825540
	|-DynamicObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x18255F0 Offset: 0x18256F1 VA: 0x18255F0
	|-DynamicObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18256A0 Offset: 0x18257A1 VA: 0x18256A0
	|-DynamicObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x1825750 Offset: 0x1825851 VA: 0x1825750
	|-DynamicObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1825800 Offset: 0x1825901 VA: 0x1825800
	|-DynamicObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x18258B0 Offset: 0x18259B1 VA: 0x18258B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1825960 Offset: 0x1825A61 VA: 0x1825960
	|-DynamicObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1825A10 Offset: 0x1825B11 VA: 0x1825A10
	|-DynamicObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1825AC0 Offset: 0x1825BC1 VA: 0x1825AC0
	|-DynamicObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1825B70 Offset: 0x1825C71 VA: 0x1825B70
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1825C20 Offset: 0x1825D21 VA: 0x1825C20
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1825CD0 Offset: 0x1825DD1 VA: 0x1825CD0
	|-DynamicObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1825D80 Offset: 0x1825E81 VA: 0x1825D80
	|-DynamicObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1825E30 Offset: 0x1825F31 VA: 0x1825E30
	|-DynamicObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1825EE0 Offset: 0x1825FE1 VA: 0x1825EE0
	|-DynamicObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1825F90 Offset: 0x1826091 VA: 0x1825F90
	|-DynamicObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1826040 Offset: 0x1826141 VA: 0x1826040
	|-DynamicObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18260F0 Offset: 0x18261F1 VA: 0x18260F0
	|-DynamicObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18261A0 Offset: 0x18262A1 VA: 0x18261A0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1826250 Offset: 0x1826351 VA: 0x1826250
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1826300 Offset: 0x1826401 VA: 0x1826300
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x18263B0 Offset: 0x18264B1 VA: 0x18263B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1826460 Offset: 0x1826561 VA: 0x1826460
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1826510 Offset: 0x1826611 VA: 0x1826510
	|-DynamicObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x18265C0 Offset: 0x18266C1 VA: 0x18265C0
	|-DynamicObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1826670 Offset: 0x1826771 VA: 0x1826670
	|-DynamicObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1826720 Offset: 0x1826821 VA: 0x1826720
	|-DynamicObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x18267D0 Offset: 0x18268D1 VA: 0x18267D0
	|-DynamicObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1826880 Offset: 0x1826981 VA: 0x1826880
	|-DynamicObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x1826930 Offset: 0x1826A31 VA: 0x1826930
	|-DynamicObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x18269E0 Offset: 0x1826AE1 VA: 0x18269E0
	|-DynamicObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1826A90 Offset: 0x1826B91 VA: 0x1826A90
	|-DynamicObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1826B40 Offset: 0x1826C41 VA: 0x1826B40
	|-DynamicObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1826BF0 Offset: 0x1826CF1 VA: 0x1826BF0
	|-DynamicObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1826CA0 Offset: 0x1826DA1 VA: 0x1826CA0
	|-DynamicObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1826D50 Offset: 0x1826E51 VA: 0x1826D50
	|-DynamicObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1826E00 Offset: 0x1826F01 VA: 0x1826E00
	|-DynamicObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1826EB0 Offset: 0x1826FB1 VA: 0x1826EB0
	|-DynamicObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1826F60 Offset: 0x1827061 VA: 0x1826F60
	|-DynamicObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1827010 Offset: 0x1827111 VA: 0x1827010
	|-DynamicObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18270C0 Offset: 0x18271C1 VA: 0x18270C0
	|-DynamicObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1827170 Offset: 0x1827271 VA: 0x1827170
	|-DynamicObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1827220 Offset: 0x1827321 VA: 0x1827220
	|-DynamicObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x18272D0 Offset: 0x18273D1 VA: 0x18272D0
	|-DynamicObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1827380 Offset: 0x1827481 VA: 0x1827380
	|-DynamicObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1827430 Offset: 0x1827531 VA: 0x1827430
	|-DynamicObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18274E0 Offset: 0x18275E1 VA: 0x18274E0
	|-DynamicObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1827590 Offset: 0x1827691 VA: 0x1827590
	|-DynamicObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicObjectResolver : IFormatterResolver // TypeDefIndex: 5238
{
	// Fields
	private const string ModuleName = "MessagePack.Resolvers.DynamicObjectResolver";
	public static readonly DynamicObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	internal static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x10

	// Methods

	// RVA: 0x14F3B50 Offset: 0x14F3C51 VA: 0x14F3B50
	private static void .cctor() { }

	// RVA: 0x14F3CA0 Offset: 0x14F3DA1 VA: 0x14F3CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1824990 Offset: 0x1824A91 VA: 0x1824990
	|-DynamicObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1824A40 Offset: 0x1824B41 VA: 0x1824A40
	|-DynamicObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1824AF0 Offset: 0x1824BF1 VA: 0x1824AF0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1824BA0 Offset: 0x1824CA1 VA: 0x1824BA0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1824C50 Offset: 0x1824D51 VA: 0x1824C50
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1824D00 Offset: 0x1824E01 VA: 0x1824D00
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1824DB0 Offset: 0x1824EB1 VA: 0x1824DB0
	|-DynamicObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1824E60 Offset: 0x1824F61 VA: 0x1824E60
	|-DynamicObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1824F10 Offset: 0x1825011 VA: 0x1824F10
	|-DynamicObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1824FC0 Offset: 0x18250C1 VA: 0x1824FC0
	|-DynamicObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1825070 Offset: 0x1825171 VA: 0x1825070
	|-DynamicObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1825120 Offset: 0x1825221 VA: 0x1825120
	|-DynamicObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x18251D0 Offset: 0x18252D1 VA: 0x18251D0
	|-DynamicObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1825280 Offset: 0x1825381 VA: 0x1825280
	|-DynamicObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x1825330 Offset: 0x1825431 VA: 0x1825330
	|-DynamicObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18253E0 Offset: 0x18254E1 VA: 0x18253E0
	|-DynamicObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1825490 Offset: 0x1825591 VA: 0x1825490
	|-DynamicObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x1825540 Offset: 0x1825641 VA: 0x1825540
	|-DynamicObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x18255F0 Offset: 0x18256F1 VA: 0x18255F0
	|-DynamicObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18256A0 Offset: 0x18257A1 VA: 0x18256A0
	|-DynamicObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x1825750 Offset: 0x1825851 VA: 0x1825750
	|-DynamicObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1825800 Offset: 0x1825901 VA: 0x1825800
	|-DynamicObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x18258B0 Offset: 0x18259B1 VA: 0x18258B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1825960 Offset: 0x1825A61 VA: 0x1825960
	|-DynamicObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1825A10 Offset: 0x1825B11 VA: 0x1825A10
	|-DynamicObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1825AC0 Offset: 0x1825BC1 VA: 0x1825AC0
	|-DynamicObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1825B70 Offset: 0x1825C71 VA: 0x1825B70
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1825C20 Offset: 0x1825D21 VA: 0x1825C20
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1825CD0 Offset: 0x1825DD1 VA: 0x1825CD0
	|-DynamicObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1825D80 Offset: 0x1825E81 VA: 0x1825D80
	|-DynamicObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1825E30 Offset: 0x1825F31 VA: 0x1825E30
	|-DynamicObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1825EE0 Offset: 0x1825FE1 VA: 0x1825EE0
	|-DynamicObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1825F90 Offset: 0x1826091 VA: 0x1825F90
	|-DynamicObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1826040 Offset: 0x1826141 VA: 0x1826040
	|-DynamicObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18260F0 Offset: 0x18261F1 VA: 0x18260F0
	|-DynamicObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18261A0 Offset: 0x18262A1 VA: 0x18261A0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1826250 Offset: 0x1826351 VA: 0x1826250
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1826300 Offset: 0x1826401 VA: 0x1826300
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x18263B0 Offset: 0x18264B1 VA: 0x18263B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1826460 Offset: 0x1826561 VA: 0x1826460
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1826510 Offset: 0x1826611 VA: 0x1826510
	|-DynamicObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x18265C0 Offset: 0x18266C1 VA: 0x18265C0
	|-DynamicObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1826670 Offset: 0x1826771 VA: 0x1826670
	|-DynamicObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1826720 Offset: 0x1826821 VA: 0x1826720
	|-DynamicObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x18267D0 Offset: 0x18268D1 VA: 0x18267D0
	|-DynamicObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1826880 Offset: 0x1826981 VA: 0x1826880
	|-DynamicObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x1826930 Offset: 0x1826A31 VA: 0x1826930
	|-DynamicObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x18269E0 Offset: 0x1826AE1 VA: 0x18269E0
	|-DynamicObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1826A90 Offset: 0x1826B91 VA: 0x1826A90
	|-DynamicObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1826B40 Offset: 0x1826C41 VA: 0x1826B40
	|-DynamicObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1826BF0 Offset: 0x1826CF1 VA: 0x1826BF0
	|-DynamicObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1826CA0 Offset: 0x1826DA1 VA: 0x1826CA0
	|-DynamicObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1826D50 Offset: 0x1826E51 VA: 0x1826D50
	|-DynamicObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1826E00 Offset: 0x1826F01 VA: 0x1826E00
	|-DynamicObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1826EB0 Offset: 0x1826FB1 VA: 0x1826EB0
	|-DynamicObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1826F60 Offset: 0x1827061 VA: 0x1826F60
	|-DynamicObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1827010 Offset: 0x1827111 VA: 0x1827010
	|-DynamicObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18270C0 Offset: 0x18271C1 VA: 0x18270C0
	|-DynamicObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1827170 Offset: 0x1827271 VA: 0x1827170
	|-DynamicObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1827220 Offset: 0x1827321 VA: 0x1827220
	|-DynamicObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x18272D0 Offset: 0x18273D1 VA: 0x18272D0
	|-DynamicObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1827380 Offset: 0x1827481 VA: 0x1827380
	|-DynamicObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1827430 Offset: 0x1827531 VA: 0x1827430
	|-DynamicObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18274E0 Offset: 0x18275E1 VA: 0x18274E0
	|-DynamicObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1827590 Offset: 0x1827691 VA: 0x1827590
	|-DynamicObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicObjectResolver : IFormatterResolver // TypeDefIndex: 5238
{
	// Fields
	private const string ModuleName = "MessagePack.Resolvers.DynamicObjectResolver";
	public static readonly DynamicObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	internal static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x10

	// Methods

	// RVA: 0x14F3B50 Offset: 0x14F3C51 VA: 0x14F3B50
	private static void .cctor() { }

	// RVA: 0x14F3CA0 Offset: 0x14F3DA1 VA: 0x14F3CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1824990 Offset: 0x1824A91 VA: 0x1824990
	|-DynamicObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1824A40 Offset: 0x1824B41 VA: 0x1824A40
	|-DynamicObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1824AF0 Offset: 0x1824BF1 VA: 0x1824AF0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1824BA0 Offset: 0x1824CA1 VA: 0x1824BA0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1824C50 Offset: 0x1824D51 VA: 0x1824C50
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1824D00 Offset: 0x1824E01 VA: 0x1824D00
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1824DB0 Offset: 0x1824EB1 VA: 0x1824DB0
	|-DynamicObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1824E60 Offset: 0x1824F61 VA: 0x1824E60
	|-DynamicObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1824F10 Offset: 0x1825011 VA: 0x1824F10
	|-DynamicObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1824FC0 Offset: 0x18250C1 VA: 0x1824FC0
	|-DynamicObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1825070 Offset: 0x1825171 VA: 0x1825070
	|-DynamicObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1825120 Offset: 0x1825221 VA: 0x1825120
	|-DynamicObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x18251D0 Offset: 0x18252D1 VA: 0x18251D0
	|-DynamicObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1825280 Offset: 0x1825381 VA: 0x1825280
	|-DynamicObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x1825330 Offset: 0x1825431 VA: 0x1825330
	|-DynamicObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18253E0 Offset: 0x18254E1 VA: 0x18253E0
	|-DynamicObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1825490 Offset: 0x1825591 VA: 0x1825490
	|-DynamicObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x1825540 Offset: 0x1825641 VA: 0x1825540
	|-DynamicObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x18255F0 Offset: 0x18256F1 VA: 0x18255F0
	|-DynamicObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18256A0 Offset: 0x18257A1 VA: 0x18256A0
	|-DynamicObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x1825750 Offset: 0x1825851 VA: 0x1825750
	|-DynamicObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1825800 Offset: 0x1825901 VA: 0x1825800
	|-DynamicObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x18258B0 Offset: 0x18259B1 VA: 0x18258B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1825960 Offset: 0x1825A61 VA: 0x1825960
	|-DynamicObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1825A10 Offset: 0x1825B11 VA: 0x1825A10
	|-DynamicObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1825AC0 Offset: 0x1825BC1 VA: 0x1825AC0
	|-DynamicObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1825B70 Offset: 0x1825C71 VA: 0x1825B70
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1825C20 Offset: 0x1825D21 VA: 0x1825C20
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1825CD0 Offset: 0x1825DD1 VA: 0x1825CD0
	|-DynamicObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1825D80 Offset: 0x1825E81 VA: 0x1825D80
	|-DynamicObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1825E30 Offset: 0x1825F31 VA: 0x1825E30
	|-DynamicObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1825EE0 Offset: 0x1825FE1 VA: 0x1825EE0
	|-DynamicObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1825F90 Offset: 0x1826091 VA: 0x1825F90
	|-DynamicObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1826040 Offset: 0x1826141 VA: 0x1826040
	|-DynamicObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18260F0 Offset: 0x18261F1 VA: 0x18260F0
	|-DynamicObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18261A0 Offset: 0x18262A1 VA: 0x18261A0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1826250 Offset: 0x1826351 VA: 0x1826250
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1826300 Offset: 0x1826401 VA: 0x1826300
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x18263B0 Offset: 0x18264B1 VA: 0x18263B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1826460 Offset: 0x1826561 VA: 0x1826460
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1826510 Offset: 0x1826611 VA: 0x1826510
	|-DynamicObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x18265C0 Offset: 0x18266C1 VA: 0x18265C0
	|-DynamicObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1826670 Offset: 0x1826771 VA: 0x1826670
	|-DynamicObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1826720 Offset: 0x1826821 VA: 0x1826720
	|-DynamicObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x18267D0 Offset: 0x18268D1 VA: 0x18267D0
	|-DynamicObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1826880 Offset: 0x1826981 VA: 0x1826880
	|-DynamicObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x1826930 Offset: 0x1826A31 VA: 0x1826930
	|-DynamicObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x18269E0 Offset: 0x1826AE1 VA: 0x18269E0
	|-DynamicObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1826A90 Offset: 0x1826B91 VA: 0x1826A90
	|-DynamicObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1826B40 Offset: 0x1826C41 VA: 0x1826B40
	|-DynamicObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1826BF0 Offset: 0x1826CF1 VA: 0x1826BF0
	|-DynamicObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1826CA0 Offset: 0x1826DA1 VA: 0x1826CA0
	|-DynamicObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1826D50 Offset: 0x1826E51 VA: 0x1826D50
	|-DynamicObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1826E00 Offset: 0x1826F01 VA: 0x1826E00
	|-DynamicObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1826EB0 Offset: 0x1826FB1 VA: 0x1826EB0
	|-DynamicObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1826F60 Offset: 0x1827061 VA: 0x1826F60
	|-DynamicObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1827010 Offset: 0x1827111 VA: 0x1827010
	|-DynamicObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18270C0 Offset: 0x18271C1 VA: 0x18270C0
	|-DynamicObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1827170 Offset: 0x1827271 VA: 0x1827170
	|-DynamicObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1827220 Offset: 0x1827321 VA: 0x1827220
	|-DynamicObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x18272D0 Offset: 0x18273D1 VA: 0x18272D0
	|-DynamicObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1827380 Offset: 0x1827481 VA: 0x1827380
	|-DynamicObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1827430 Offset: 0x1827531 VA: 0x1827430
	|-DynamicObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18274E0 Offset: 0x18275E1 VA: 0x18274E0
	|-DynamicObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1827590 Offset: 0x1827691 VA: 0x1827590
	|-DynamicObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicObjectResolver : IFormatterResolver // TypeDefIndex: 5238
{
	// Fields
	private const string ModuleName = "MessagePack.Resolvers.DynamicObjectResolver";
	public static readonly DynamicObjectResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	internal static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x10

	// Methods

	// RVA: 0x14F3B50 Offset: 0x14F3C51 VA: 0x14F3B50
	private static void .cctor() { }

	// RVA: 0x14F3CA0 Offset: 0x14F3DA1 VA: 0x14F3CA0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1824990 Offset: 0x1824A91 VA: 0x1824990
	|-DynamicObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1824A40 Offset: 0x1824B41 VA: 0x1824A40
	|-DynamicObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1824AF0 Offset: 0x1824BF1 VA: 0x1824AF0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1824BA0 Offset: 0x1824CA1 VA: 0x1824BA0
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1824C50 Offset: 0x1824D51 VA: 0x1824C50
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1824D00 Offset: 0x1824E01 VA: 0x1824D00
	|-DynamicObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1824DB0 Offset: 0x1824EB1 VA: 0x1824DB0
	|-DynamicObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1824E60 Offset: 0x1824F61 VA: 0x1824E60
	|-DynamicObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1824F10 Offset: 0x1825011 VA: 0x1824F10
	|-DynamicObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1824FC0 Offset: 0x18250C1 VA: 0x1824FC0
	|-DynamicObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1825070 Offset: 0x1825171 VA: 0x1825070
	|-DynamicObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1825120 Offset: 0x1825221 VA: 0x1825120
	|-DynamicObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x18251D0 Offset: 0x18252D1 VA: 0x18251D0
	|-DynamicObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1825280 Offset: 0x1825381 VA: 0x1825280
	|-DynamicObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x1825330 Offset: 0x1825431 VA: 0x1825330
	|-DynamicObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x18253E0 Offset: 0x18254E1 VA: 0x18253E0
	|-DynamicObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1825490 Offset: 0x1825591 VA: 0x1825490
	|-DynamicObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x1825540 Offset: 0x1825641 VA: 0x1825540
	|-DynamicObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x18255F0 Offset: 0x18256F1 VA: 0x18255F0
	|-DynamicObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x18256A0 Offset: 0x18257A1 VA: 0x18256A0
	|-DynamicObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x1825750 Offset: 0x1825851 VA: 0x1825750
	|-DynamicObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1825800 Offset: 0x1825901 VA: 0x1825800
	|-DynamicObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x18258B0 Offset: 0x18259B1 VA: 0x18258B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1825960 Offset: 0x1825A61 VA: 0x1825960
	|-DynamicObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1825A10 Offset: 0x1825B11 VA: 0x1825A10
	|-DynamicObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1825AC0 Offset: 0x1825BC1 VA: 0x1825AC0
	|-DynamicObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1825B70 Offset: 0x1825C71 VA: 0x1825B70
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1825C20 Offset: 0x1825D21 VA: 0x1825C20
	|-DynamicObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1825CD0 Offset: 0x1825DD1 VA: 0x1825CD0
	|-DynamicObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1825D80 Offset: 0x1825E81 VA: 0x1825D80
	|-DynamicObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1825E30 Offset: 0x1825F31 VA: 0x1825E30
	|-DynamicObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1825EE0 Offset: 0x1825FE1 VA: 0x1825EE0
	|-DynamicObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1825F90 Offset: 0x1826091 VA: 0x1825F90
	|-DynamicObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1826040 Offset: 0x1826141 VA: 0x1826040
	|-DynamicObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x18260F0 Offset: 0x18261F1 VA: 0x18260F0
	|-DynamicObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x18261A0 Offset: 0x18262A1 VA: 0x18261A0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1826250 Offset: 0x1826351 VA: 0x1826250
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1826300 Offset: 0x1826401 VA: 0x1826300
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x18263B0 Offset: 0x18264B1 VA: 0x18263B0
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1826460 Offset: 0x1826561 VA: 0x1826460
	|-DynamicObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1826510 Offset: 0x1826611 VA: 0x1826510
	|-DynamicObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x18265C0 Offset: 0x18266C1 VA: 0x18265C0
	|-DynamicObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1826670 Offset: 0x1826771 VA: 0x1826670
	|-DynamicObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1826720 Offset: 0x1826821 VA: 0x1826720
	|-DynamicObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x18267D0 Offset: 0x18268D1 VA: 0x18267D0
	|-DynamicObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1826880 Offset: 0x1826981 VA: 0x1826880
	|-DynamicObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x1826930 Offset: 0x1826A31 VA: 0x1826930
	|-DynamicObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x18269E0 Offset: 0x1826AE1 VA: 0x18269E0
	|-DynamicObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1826A90 Offset: 0x1826B91 VA: 0x1826A90
	|-DynamicObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1826B40 Offset: 0x1826C41 VA: 0x1826B40
	|-DynamicObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1826BF0 Offset: 0x1826CF1 VA: 0x1826BF0
	|-DynamicObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1826CA0 Offset: 0x1826DA1 VA: 0x1826CA0
	|-DynamicObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1826D50 Offset: 0x1826E51 VA: 0x1826D50
	|-DynamicObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1826E00 Offset: 0x1826F01 VA: 0x1826E00
	|-DynamicObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1826EB0 Offset: 0x1826FB1 VA: 0x1826EB0
	|-DynamicObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1826F60 Offset: 0x1827061 VA: 0x1826F60
	|-DynamicObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1827010 Offset: 0x1827111 VA: 0x1827010
	|-DynamicObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x18270C0 Offset: 0x18271C1 VA: 0x18270C0
	|-DynamicObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1827170 Offset: 0x1827271 VA: 0x1827170
	|-DynamicObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1827220 Offset: 0x1827321 VA: 0x1827220
	|-DynamicObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x18272D0 Offset: 0x18273D1 VA: 0x18272D0
	|-DynamicObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1827380 Offset: 0x1827481 VA: 0x1827380
	|-DynamicObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1827430 Offset: 0x1827531 VA: 0x1827430
	|-DynamicObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x18274E0 Offset: 0x18275E1 VA: 0x18274E0
	|-DynamicObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1827590 Offset: 0x1827691 VA: 0x1827590
	|-DynamicObjectResolver.GetFormatter<Vector4>
	*/
}

