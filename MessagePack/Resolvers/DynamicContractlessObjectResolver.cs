public sealed class DynamicContractlessObjectResolver : IFormatterResolver // TypeDefIndex: 5243
{
	// Fields
	public static readonly DynamicContractlessObjectResolver Instance; // 0x0
	private const string ModuleName = "MessagePack.Resolvers.DynamicContractlessObjectResolver";
	private static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x8

	// Methods

	// RVA: 0x14F29D0 Offset: 0x14F2AD1 VA: 0x14F29D0
	private void .ctor() { }

	// RVA: 0x14F29E0 Offset: 0x14F2AE1 VA: 0x14F29E0
	private static void .cctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1816A20 Offset: 0x1816B21 VA: 0x1816A20
	|-DynamicContractlessObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1816AD0 Offset: 0x1816BD1 VA: 0x1816AD0
	|-DynamicContractlessObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1816B80 Offset: 0x1816C81 VA: 0x1816B80
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1816C30 Offset: 0x1816D31 VA: 0x1816C30
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1816CE0 Offset: 0x1816DE1 VA: 0x1816CE0
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1816D90 Offset: 0x1816E91 VA: 0x1816D90
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1816E40 Offset: 0x1816F41 VA: 0x1816E40
	|-DynamicContractlessObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1816EF0 Offset: 0x1816FF1 VA: 0x1816EF0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1816FA0 Offset: 0x18170A1 VA: 0x1816FA0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1817050 Offset: 0x1817151 VA: 0x1817050
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1817100 Offset: 0x1817201 VA: 0x1817100
	|-DynamicContractlessObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18171B0 Offset: 0x18172B1 VA: 0x18171B0
	|-DynamicContractlessObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x1817260 Offset: 0x1817361 VA: 0x1817260
	|-DynamicContractlessObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1817310 Offset: 0x1817411 VA: 0x1817310
	|-DynamicContractlessObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x18173C0 Offset: 0x18174C1 VA: 0x18173C0
	|-DynamicContractlessObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1817470 Offset: 0x1817571 VA: 0x1817470
	|-DynamicContractlessObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1817520 Offset: 0x1817621 VA: 0x1817520
	|-DynamicContractlessObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x18175D0 Offset: 0x18176D1 VA: 0x18175D0
	|-DynamicContractlessObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x1817680 Offset: 0x1817781 VA: 0x1817680
	|-DynamicContractlessObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1817730 Offset: 0x1817831 VA: 0x1817730
	|-DynamicContractlessObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x18177E0 Offset: 0x18178E1 VA: 0x18177E0
	|-DynamicContractlessObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1817890 Offset: 0x1817991 VA: 0x1817890
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1817940 Offset: 0x1817A41 VA: 0x1817940
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x18179F0 Offset: 0x1817AF1 VA: 0x18179F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1817AA0 Offset: 0x1817BA1 VA: 0x1817AA0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1817B50 Offset: 0x1817C51 VA: 0x1817B50
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1817C00 Offset: 0x1817D01 VA: 0x1817C00
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1817CB0 Offset: 0x1817DB1 VA: 0x1817CB0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1817D60 Offset: 0x1817E61 VA: 0x1817D60
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1817E10 Offset: 0x1817F11 VA: 0x1817E10
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1817EC0 Offset: 0x1817FC1 VA: 0x1817EC0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1817F70 Offset: 0x1818071 VA: 0x1817F70
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1818020 Offset: 0x1818121 VA: 0x1818020
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x18180D0 Offset: 0x18181D1 VA: 0x18180D0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1818180 Offset: 0x1818281 VA: 0x1818180
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1818230 Offset: 0x1818331 VA: 0x1818230
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18182E0 Offset: 0x18183E1 VA: 0x18182E0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1818390 Offset: 0x1818491 VA: 0x1818390
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1818440 Offset: 0x1818541 VA: 0x1818440
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18184F0 Offset: 0x18185F1 VA: 0x18184F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18185A0 Offset: 0x18186A1 VA: 0x18185A0
	|-DynamicContractlessObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x1818650 Offset: 0x1818751 VA: 0x1818650
	|-DynamicContractlessObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1818700 Offset: 0x1818801 VA: 0x1818700
	|-DynamicContractlessObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18187B0 Offset: 0x18188B1 VA: 0x18187B0
	|-DynamicContractlessObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x1818860 Offset: 0x1818961 VA: 0x1818860
	|-DynamicContractlessObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1818910 Offset: 0x1818A11 VA: 0x1818910
	|-DynamicContractlessObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x18189C0 Offset: 0x1818AC1 VA: 0x18189C0
	|-DynamicContractlessObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1818A70 Offset: 0x1818B71 VA: 0x1818A70
	|-DynamicContractlessObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1818B20 Offset: 0x1818C21 VA: 0x1818B20
	|-DynamicContractlessObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1818BD0 Offset: 0x1818CD1 VA: 0x1818BD0
	|-DynamicContractlessObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1818C80 Offset: 0x1818D81 VA: 0x1818C80
	|-DynamicContractlessObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1818D30 Offset: 0x1818E31 VA: 0x1818D30
	|-DynamicContractlessObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1818DE0 Offset: 0x1818EE1 VA: 0x1818DE0
	|-DynamicContractlessObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1818E90 Offset: 0x1818F91 VA: 0x1818E90
	|-DynamicContractlessObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1818F40 Offset: 0x1819041 VA: 0x1818F40
	|-DynamicContractlessObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1818FF0 Offset: 0x18190F1 VA: 0x1818FF0
	|-DynamicContractlessObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18190A0 Offset: 0x18191A1 VA: 0x18190A0
	|-DynamicContractlessObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1819150 Offset: 0x1819251 VA: 0x1819150
	|-DynamicContractlessObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1819200 Offset: 0x1819301 VA: 0x1819200
	|-DynamicContractlessObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18192B0 Offset: 0x18193B1 VA: 0x18192B0
	|-DynamicContractlessObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1819360 Offset: 0x1819461 VA: 0x1819360
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1819410 Offset: 0x1819511 VA: 0x1819410
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18194C0 Offset: 0x18195C1 VA: 0x18194C0
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1819570 Offset: 0x1819671 VA: 0x1819570
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1819620 Offset: 0x1819721 VA: 0x1819620
	|-DynamicContractlessObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicContractlessObjectResolver : IFormatterResolver // TypeDefIndex: 5243
{
	// Fields
	public static readonly DynamicContractlessObjectResolver Instance; // 0x0
	private const string ModuleName = "MessagePack.Resolvers.DynamicContractlessObjectResolver";
	private static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x8

	// Methods

	// RVA: 0x14F29D0 Offset: 0x14F2AD1 VA: 0x14F29D0
	private void .ctor() { }

	// RVA: 0x14F29E0 Offset: 0x14F2AE1 VA: 0x14F29E0
	private static void .cctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1816A20 Offset: 0x1816B21 VA: 0x1816A20
	|-DynamicContractlessObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1816AD0 Offset: 0x1816BD1 VA: 0x1816AD0
	|-DynamicContractlessObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1816B80 Offset: 0x1816C81 VA: 0x1816B80
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1816C30 Offset: 0x1816D31 VA: 0x1816C30
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1816CE0 Offset: 0x1816DE1 VA: 0x1816CE0
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1816D90 Offset: 0x1816E91 VA: 0x1816D90
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1816E40 Offset: 0x1816F41 VA: 0x1816E40
	|-DynamicContractlessObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1816EF0 Offset: 0x1816FF1 VA: 0x1816EF0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1816FA0 Offset: 0x18170A1 VA: 0x1816FA0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1817050 Offset: 0x1817151 VA: 0x1817050
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1817100 Offset: 0x1817201 VA: 0x1817100
	|-DynamicContractlessObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18171B0 Offset: 0x18172B1 VA: 0x18171B0
	|-DynamicContractlessObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x1817260 Offset: 0x1817361 VA: 0x1817260
	|-DynamicContractlessObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1817310 Offset: 0x1817411 VA: 0x1817310
	|-DynamicContractlessObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x18173C0 Offset: 0x18174C1 VA: 0x18173C0
	|-DynamicContractlessObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1817470 Offset: 0x1817571 VA: 0x1817470
	|-DynamicContractlessObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1817520 Offset: 0x1817621 VA: 0x1817520
	|-DynamicContractlessObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x18175D0 Offset: 0x18176D1 VA: 0x18175D0
	|-DynamicContractlessObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x1817680 Offset: 0x1817781 VA: 0x1817680
	|-DynamicContractlessObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1817730 Offset: 0x1817831 VA: 0x1817730
	|-DynamicContractlessObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x18177E0 Offset: 0x18178E1 VA: 0x18177E0
	|-DynamicContractlessObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1817890 Offset: 0x1817991 VA: 0x1817890
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1817940 Offset: 0x1817A41 VA: 0x1817940
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x18179F0 Offset: 0x1817AF1 VA: 0x18179F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1817AA0 Offset: 0x1817BA1 VA: 0x1817AA0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1817B50 Offset: 0x1817C51 VA: 0x1817B50
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1817C00 Offset: 0x1817D01 VA: 0x1817C00
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1817CB0 Offset: 0x1817DB1 VA: 0x1817CB0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1817D60 Offset: 0x1817E61 VA: 0x1817D60
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1817E10 Offset: 0x1817F11 VA: 0x1817E10
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1817EC0 Offset: 0x1817FC1 VA: 0x1817EC0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1817F70 Offset: 0x1818071 VA: 0x1817F70
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1818020 Offset: 0x1818121 VA: 0x1818020
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x18180D0 Offset: 0x18181D1 VA: 0x18180D0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1818180 Offset: 0x1818281 VA: 0x1818180
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1818230 Offset: 0x1818331 VA: 0x1818230
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18182E0 Offset: 0x18183E1 VA: 0x18182E0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1818390 Offset: 0x1818491 VA: 0x1818390
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1818440 Offset: 0x1818541 VA: 0x1818440
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18184F0 Offset: 0x18185F1 VA: 0x18184F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18185A0 Offset: 0x18186A1 VA: 0x18185A0
	|-DynamicContractlessObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x1818650 Offset: 0x1818751 VA: 0x1818650
	|-DynamicContractlessObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1818700 Offset: 0x1818801 VA: 0x1818700
	|-DynamicContractlessObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18187B0 Offset: 0x18188B1 VA: 0x18187B0
	|-DynamicContractlessObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x1818860 Offset: 0x1818961 VA: 0x1818860
	|-DynamicContractlessObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1818910 Offset: 0x1818A11 VA: 0x1818910
	|-DynamicContractlessObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x18189C0 Offset: 0x1818AC1 VA: 0x18189C0
	|-DynamicContractlessObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1818A70 Offset: 0x1818B71 VA: 0x1818A70
	|-DynamicContractlessObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1818B20 Offset: 0x1818C21 VA: 0x1818B20
	|-DynamicContractlessObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1818BD0 Offset: 0x1818CD1 VA: 0x1818BD0
	|-DynamicContractlessObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1818C80 Offset: 0x1818D81 VA: 0x1818C80
	|-DynamicContractlessObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1818D30 Offset: 0x1818E31 VA: 0x1818D30
	|-DynamicContractlessObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1818DE0 Offset: 0x1818EE1 VA: 0x1818DE0
	|-DynamicContractlessObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1818E90 Offset: 0x1818F91 VA: 0x1818E90
	|-DynamicContractlessObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1818F40 Offset: 0x1819041 VA: 0x1818F40
	|-DynamicContractlessObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1818FF0 Offset: 0x18190F1 VA: 0x1818FF0
	|-DynamicContractlessObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18190A0 Offset: 0x18191A1 VA: 0x18190A0
	|-DynamicContractlessObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1819150 Offset: 0x1819251 VA: 0x1819150
	|-DynamicContractlessObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1819200 Offset: 0x1819301 VA: 0x1819200
	|-DynamicContractlessObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18192B0 Offset: 0x18193B1 VA: 0x18192B0
	|-DynamicContractlessObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1819360 Offset: 0x1819461 VA: 0x1819360
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1819410 Offset: 0x1819511 VA: 0x1819410
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18194C0 Offset: 0x18195C1 VA: 0x18194C0
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1819570 Offset: 0x1819671 VA: 0x1819570
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1819620 Offset: 0x1819721 VA: 0x1819620
	|-DynamicContractlessObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicContractlessObjectResolver : IFormatterResolver // TypeDefIndex: 5243
{
	// Fields
	public static readonly DynamicContractlessObjectResolver Instance; // 0x0
	private const string ModuleName = "MessagePack.Resolvers.DynamicContractlessObjectResolver";
	private static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x8

	// Methods

	// RVA: 0x14F29D0 Offset: 0x14F2AD1 VA: 0x14F29D0
	private void .ctor() { }

	// RVA: 0x14F29E0 Offset: 0x14F2AE1 VA: 0x14F29E0
	private static void .cctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1816A20 Offset: 0x1816B21 VA: 0x1816A20
	|-DynamicContractlessObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1816AD0 Offset: 0x1816BD1 VA: 0x1816AD0
	|-DynamicContractlessObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1816B80 Offset: 0x1816C81 VA: 0x1816B80
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1816C30 Offset: 0x1816D31 VA: 0x1816C30
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1816CE0 Offset: 0x1816DE1 VA: 0x1816CE0
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1816D90 Offset: 0x1816E91 VA: 0x1816D90
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1816E40 Offset: 0x1816F41 VA: 0x1816E40
	|-DynamicContractlessObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1816EF0 Offset: 0x1816FF1 VA: 0x1816EF0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1816FA0 Offset: 0x18170A1 VA: 0x1816FA0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1817050 Offset: 0x1817151 VA: 0x1817050
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1817100 Offset: 0x1817201 VA: 0x1817100
	|-DynamicContractlessObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18171B0 Offset: 0x18172B1 VA: 0x18171B0
	|-DynamicContractlessObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x1817260 Offset: 0x1817361 VA: 0x1817260
	|-DynamicContractlessObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1817310 Offset: 0x1817411 VA: 0x1817310
	|-DynamicContractlessObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x18173C0 Offset: 0x18174C1 VA: 0x18173C0
	|-DynamicContractlessObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1817470 Offset: 0x1817571 VA: 0x1817470
	|-DynamicContractlessObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1817520 Offset: 0x1817621 VA: 0x1817520
	|-DynamicContractlessObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x18175D0 Offset: 0x18176D1 VA: 0x18175D0
	|-DynamicContractlessObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x1817680 Offset: 0x1817781 VA: 0x1817680
	|-DynamicContractlessObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1817730 Offset: 0x1817831 VA: 0x1817730
	|-DynamicContractlessObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x18177E0 Offset: 0x18178E1 VA: 0x18177E0
	|-DynamicContractlessObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1817890 Offset: 0x1817991 VA: 0x1817890
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1817940 Offset: 0x1817A41 VA: 0x1817940
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x18179F0 Offset: 0x1817AF1 VA: 0x18179F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1817AA0 Offset: 0x1817BA1 VA: 0x1817AA0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1817B50 Offset: 0x1817C51 VA: 0x1817B50
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1817C00 Offset: 0x1817D01 VA: 0x1817C00
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1817CB0 Offset: 0x1817DB1 VA: 0x1817CB0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1817D60 Offset: 0x1817E61 VA: 0x1817D60
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1817E10 Offset: 0x1817F11 VA: 0x1817E10
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1817EC0 Offset: 0x1817FC1 VA: 0x1817EC0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1817F70 Offset: 0x1818071 VA: 0x1817F70
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1818020 Offset: 0x1818121 VA: 0x1818020
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x18180D0 Offset: 0x18181D1 VA: 0x18180D0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1818180 Offset: 0x1818281 VA: 0x1818180
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1818230 Offset: 0x1818331 VA: 0x1818230
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18182E0 Offset: 0x18183E1 VA: 0x18182E0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1818390 Offset: 0x1818491 VA: 0x1818390
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1818440 Offset: 0x1818541 VA: 0x1818440
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18184F0 Offset: 0x18185F1 VA: 0x18184F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18185A0 Offset: 0x18186A1 VA: 0x18185A0
	|-DynamicContractlessObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x1818650 Offset: 0x1818751 VA: 0x1818650
	|-DynamicContractlessObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1818700 Offset: 0x1818801 VA: 0x1818700
	|-DynamicContractlessObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18187B0 Offset: 0x18188B1 VA: 0x18187B0
	|-DynamicContractlessObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x1818860 Offset: 0x1818961 VA: 0x1818860
	|-DynamicContractlessObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1818910 Offset: 0x1818A11 VA: 0x1818910
	|-DynamicContractlessObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x18189C0 Offset: 0x1818AC1 VA: 0x18189C0
	|-DynamicContractlessObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1818A70 Offset: 0x1818B71 VA: 0x1818A70
	|-DynamicContractlessObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1818B20 Offset: 0x1818C21 VA: 0x1818B20
	|-DynamicContractlessObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1818BD0 Offset: 0x1818CD1 VA: 0x1818BD0
	|-DynamicContractlessObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1818C80 Offset: 0x1818D81 VA: 0x1818C80
	|-DynamicContractlessObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1818D30 Offset: 0x1818E31 VA: 0x1818D30
	|-DynamicContractlessObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1818DE0 Offset: 0x1818EE1 VA: 0x1818DE0
	|-DynamicContractlessObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1818E90 Offset: 0x1818F91 VA: 0x1818E90
	|-DynamicContractlessObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1818F40 Offset: 0x1819041 VA: 0x1818F40
	|-DynamicContractlessObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1818FF0 Offset: 0x18190F1 VA: 0x1818FF0
	|-DynamicContractlessObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18190A0 Offset: 0x18191A1 VA: 0x18190A0
	|-DynamicContractlessObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1819150 Offset: 0x1819251 VA: 0x1819150
	|-DynamicContractlessObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1819200 Offset: 0x1819301 VA: 0x1819200
	|-DynamicContractlessObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18192B0 Offset: 0x18193B1 VA: 0x18192B0
	|-DynamicContractlessObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1819360 Offset: 0x1819461 VA: 0x1819360
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1819410 Offset: 0x1819511 VA: 0x1819410
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18194C0 Offset: 0x18195C1 VA: 0x18194C0
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1819570 Offset: 0x1819671 VA: 0x1819570
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1819620 Offset: 0x1819721 VA: 0x1819620
	|-DynamicContractlessObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicContractlessObjectResolver : IFormatterResolver // TypeDefIndex: 5243
{
	// Fields
	public static readonly DynamicContractlessObjectResolver Instance; // 0x0
	private const string ModuleName = "MessagePack.Resolvers.DynamicContractlessObjectResolver";
	private static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x8

	// Methods

	// RVA: 0x14F29D0 Offset: 0x14F2AD1 VA: 0x14F29D0
	private void .ctor() { }

	// RVA: 0x14F29E0 Offset: 0x14F2AE1 VA: 0x14F29E0
	private static void .cctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1816A20 Offset: 0x1816B21 VA: 0x1816A20
	|-DynamicContractlessObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1816AD0 Offset: 0x1816BD1 VA: 0x1816AD0
	|-DynamicContractlessObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1816B80 Offset: 0x1816C81 VA: 0x1816B80
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1816C30 Offset: 0x1816D31 VA: 0x1816C30
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1816CE0 Offset: 0x1816DE1 VA: 0x1816CE0
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1816D90 Offset: 0x1816E91 VA: 0x1816D90
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1816E40 Offset: 0x1816F41 VA: 0x1816E40
	|-DynamicContractlessObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1816EF0 Offset: 0x1816FF1 VA: 0x1816EF0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1816FA0 Offset: 0x18170A1 VA: 0x1816FA0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1817050 Offset: 0x1817151 VA: 0x1817050
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1817100 Offset: 0x1817201 VA: 0x1817100
	|-DynamicContractlessObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18171B0 Offset: 0x18172B1 VA: 0x18171B0
	|-DynamicContractlessObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x1817260 Offset: 0x1817361 VA: 0x1817260
	|-DynamicContractlessObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1817310 Offset: 0x1817411 VA: 0x1817310
	|-DynamicContractlessObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x18173C0 Offset: 0x18174C1 VA: 0x18173C0
	|-DynamicContractlessObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1817470 Offset: 0x1817571 VA: 0x1817470
	|-DynamicContractlessObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1817520 Offset: 0x1817621 VA: 0x1817520
	|-DynamicContractlessObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x18175D0 Offset: 0x18176D1 VA: 0x18175D0
	|-DynamicContractlessObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x1817680 Offset: 0x1817781 VA: 0x1817680
	|-DynamicContractlessObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1817730 Offset: 0x1817831 VA: 0x1817730
	|-DynamicContractlessObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x18177E0 Offset: 0x18178E1 VA: 0x18177E0
	|-DynamicContractlessObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1817890 Offset: 0x1817991 VA: 0x1817890
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1817940 Offset: 0x1817A41 VA: 0x1817940
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x18179F0 Offset: 0x1817AF1 VA: 0x18179F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1817AA0 Offset: 0x1817BA1 VA: 0x1817AA0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1817B50 Offset: 0x1817C51 VA: 0x1817B50
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1817C00 Offset: 0x1817D01 VA: 0x1817C00
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1817CB0 Offset: 0x1817DB1 VA: 0x1817CB0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1817D60 Offset: 0x1817E61 VA: 0x1817D60
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1817E10 Offset: 0x1817F11 VA: 0x1817E10
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1817EC0 Offset: 0x1817FC1 VA: 0x1817EC0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1817F70 Offset: 0x1818071 VA: 0x1817F70
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1818020 Offset: 0x1818121 VA: 0x1818020
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x18180D0 Offset: 0x18181D1 VA: 0x18180D0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1818180 Offset: 0x1818281 VA: 0x1818180
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1818230 Offset: 0x1818331 VA: 0x1818230
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18182E0 Offset: 0x18183E1 VA: 0x18182E0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1818390 Offset: 0x1818491 VA: 0x1818390
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1818440 Offset: 0x1818541 VA: 0x1818440
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18184F0 Offset: 0x18185F1 VA: 0x18184F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18185A0 Offset: 0x18186A1 VA: 0x18185A0
	|-DynamicContractlessObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x1818650 Offset: 0x1818751 VA: 0x1818650
	|-DynamicContractlessObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1818700 Offset: 0x1818801 VA: 0x1818700
	|-DynamicContractlessObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18187B0 Offset: 0x18188B1 VA: 0x18187B0
	|-DynamicContractlessObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x1818860 Offset: 0x1818961 VA: 0x1818860
	|-DynamicContractlessObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1818910 Offset: 0x1818A11 VA: 0x1818910
	|-DynamicContractlessObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x18189C0 Offset: 0x1818AC1 VA: 0x18189C0
	|-DynamicContractlessObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1818A70 Offset: 0x1818B71 VA: 0x1818A70
	|-DynamicContractlessObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1818B20 Offset: 0x1818C21 VA: 0x1818B20
	|-DynamicContractlessObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1818BD0 Offset: 0x1818CD1 VA: 0x1818BD0
	|-DynamicContractlessObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1818C80 Offset: 0x1818D81 VA: 0x1818C80
	|-DynamicContractlessObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1818D30 Offset: 0x1818E31 VA: 0x1818D30
	|-DynamicContractlessObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1818DE0 Offset: 0x1818EE1 VA: 0x1818DE0
	|-DynamicContractlessObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1818E90 Offset: 0x1818F91 VA: 0x1818E90
	|-DynamicContractlessObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1818F40 Offset: 0x1819041 VA: 0x1818F40
	|-DynamicContractlessObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1818FF0 Offset: 0x18190F1 VA: 0x1818FF0
	|-DynamicContractlessObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18190A0 Offset: 0x18191A1 VA: 0x18190A0
	|-DynamicContractlessObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1819150 Offset: 0x1819251 VA: 0x1819150
	|-DynamicContractlessObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1819200 Offset: 0x1819301 VA: 0x1819200
	|-DynamicContractlessObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18192B0 Offset: 0x18193B1 VA: 0x18192B0
	|-DynamicContractlessObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1819360 Offset: 0x1819461 VA: 0x1819360
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1819410 Offset: 0x1819511 VA: 0x1819410
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18194C0 Offset: 0x18195C1 VA: 0x18194C0
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1819570 Offset: 0x1819671 VA: 0x1819570
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1819620 Offset: 0x1819721 VA: 0x1819620
	|-DynamicContractlessObjectResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicContractlessObjectResolver : IFormatterResolver // TypeDefIndex: 5243
{
	// Fields
	public static readonly DynamicContractlessObjectResolver Instance; // 0x0
	private const string ModuleName = "MessagePack.Resolvers.DynamicContractlessObjectResolver";
	private static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x8

	// Methods

	// RVA: 0x14F29D0 Offset: 0x14F2AD1 VA: 0x14F29D0
	private void .ctor() { }

	// RVA: 0x14F29E0 Offset: 0x14F2AE1 VA: 0x14F29E0
	private static void .cctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1816A20 Offset: 0x1816B21 VA: 0x1816A20
	|-DynamicContractlessObjectResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1816AD0 Offset: 0x1816BD1 VA: 0x1816AD0
	|-DynamicContractlessObjectResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1816B80 Offset: 0x1816C81 VA: 0x1816B80
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1816C30 Offset: 0x1816D31 VA: 0x1816C30
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1816CE0 Offset: 0x1816DE1 VA: 0x1816CE0
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1816D90 Offset: 0x1816E91 VA: 0x1816D90
	|-DynamicContractlessObjectResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1816E40 Offset: 0x1816F41 VA: 0x1816E40
	|-DynamicContractlessObjectResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1816EF0 Offset: 0x1816FF1 VA: 0x1816EF0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1816FA0 Offset: 0x18170A1 VA: 0x1816FA0
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1817050 Offset: 0x1817151 VA: 0x1817050
	|-DynamicContractlessObjectResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1817100 Offset: 0x1817201 VA: 0x1817100
	|-DynamicContractlessObjectResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x18171B0 Offset: 0x18172B1 VA: 0x18171B0
	|-DynamicContractlessObjectResolver.GetFormatter<bool>
	|
	|-RVA: 0x1817260 Offset: 0x1817361 VA: 0x1817260
	|-DynamicContractlessObjectResolver.GetFormatter<byte>
	|
	|-RVA: 0x1817310 Offset: 0x1817411 VA: 0x1817310
	|-DynamicContractlessObjectResolver.GetFormatter<char>
	|
	|-RVA: 0x18173C0 Offset: 0x18174C1 VA: 0x18173C0
	|-DynamicContractlessObjectResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1817470 Offset: 0x1817571 VA: 0x1817470
	|-DynamicContractlessObjectResolver.GetFormatter<double>
	|
	|-RVA: 0x1817520 Offset: 0x1817621 VA: 0x1817520
	|-DynamicContractlessObjectResolver.GetFormatter<short>
	|
	|-RVA: 0x18175D0 Offset: 0x18176D1 VA: 0x18175D0
	|-DynamicContractlessObjectResolver.GetFormatter<int>
	|
	|-RVA: 0x1817680 Offset: 0x1817781 VA: 0x1817680
	|-DynamicContractlessObjectResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1817730 Offset: 0x1817831 VA: 0x1817730
	|-DynamicContractlessObjectResolver.GetFormatter<long>
	|
	|-RVA: 0x18177E0 Offset: 0x18178E1 VA: 0x18177E0
	|-DynamicContractlessObjectResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1817890 Offset: 0x1817991 VA: 0x1817890
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1817940 Offset: 0x1817A41 VA: 0x1817940
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x18179F0 Offset: 0x1817AF1 VA: 0x18179F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1817AA0 Offset: 0x1817BA1 VA: 0x1817AA0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1817B50 Offset: 0x1817C51 VA: 0x1817B50
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1817C00 Offset: 0x1817D01 VA: 0x1817C00
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1817CB0 Offset: 0x1817DB1 VA: 0x1817CB0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1817D60 Offset: 0x1817E61 VA: 0x1817D60
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1817E10 Offset: 0x1817F11 VA: 0x1817E10
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1817EC0 Offset: 0x1817FC1 VA: 0x1817EC0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1817F70 Offset: 0x1818071 VA: 0x1817F70
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1818020 Offset: 0x1818121 VA: 0x1818020
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x18180D0 Offset: 0x18181D1 VA: 0x18180D0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1818180 Offset: 0x1818281 VA: 0x1818180
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1818230 Offset: 0x1818331 VA: 0x1818230
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18182E0 Offset: 0x18183E1 VA: 0x18182E0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1818390 Offset: 0x1818491 VA: 0x1818390
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1818440 Offset: 0x1818541 VA: 0x1818440
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18184F0 Offset: 0x18185F1 VA: 0x18184F0
	|-DynamicContractlessObjectResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x18185A0 Offset: 0x18186A1 VA: 0x18185A0
	|-DynamicContractlessObjectResolver.GetFormatter<object>
	|
	|-RVA: 0x1818650 Offset: 0x1818751 VA: 0x1818650
	|-DynamicContractlessObjectResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1818700 Offset: 0x1818801 VA: 0x1818700
	|-DynamicContractlessObjectResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x18187B0 Offset: 0x18188B1 VA: 0x18187B0
	|-DynamicContractlessObjectResolver.GetFormatter<float>
	|
	|-RVA: 0x1818860 Offset: 0x1818961 VA: 0x1818860
	|-DynamicContractlessObjectResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1818910 Offset: 0x1818A11 VA: 0x1818910
	|-DynamicContractlessObjectResolver.GetFormatter<uint>
	|
	|-RVA: 0x18189C0 Offset: 0x1818AC1 VA: 0x18189C0
	|-DynamicContractlessObjectResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1818A70 Offset: 0x1818B71 VA: 0x1818A70
	|-DynamicContractlessObjectResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1818B20 Offset: 0x1818C21 VA: 0x1818B20
	|-DynamicContractlessObjectResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1818BD0 Offset: 0x1818CD1 VA: 0x1818BD0
	|-DynamicContractlessObjectResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1818C80 Offset: 0x1818D81 VA: 0x1818C80
	|-DynamicContractlessObjectResolver.GetFormatter<Color>
	|
	|-RVA: 0x1818D30 Offset: 0x1818E31 VA: 0x1818D30
	|-DynamicContractlessObjectResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1818DE0 Offset: 0x1818EE1 VA: 0x1818DE0
	|-DynamicContractlessObjectResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1818E90 Offset: 0x1818F91 VA: 0x1818E90
	|-DynamicContractlessObjectResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1818F40 Offset: 0x1819041 VA: 0x1818F40
	|-DynamicContractlessObjectResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1818FF0 Offset: 0x18190F1 VA: 0x1818FF0
	|-DynamicContractlessObjectResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18190A0 Offset: 0x18191A1 VA: 0x18190A0
	|-DynamicContractlessObjectResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1819150 Offset: 0x1819251 VA: 0x1819150
	|-DynamicContractlessObjectResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1819200 Offset: 0x1819301 VA: 0x1819200
	|-DynamicContractlessObjectResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18192B0 Offset: 0x18193B1 VA: 0x18192B0
	|-DynamicContractlessObjectResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1819360 Offset: 0x1819461 VA: 0x1819360
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1819410 Offset: 0x1819511 VA: 0x1819410
	|-DynamicContractlessObjectResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x18194C0 Offset: 0x18195C1 VA: 0x18194C0
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1819570 Offset: 0x1819671 VA: 0x1819570
	|-DynamicContractlessObjectResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1819620 Offset: 0x1819721 VA: 0x1819620
	|-DynamicContractlessObjectResolver.GetFormatter<Vector4>
	*/
}

