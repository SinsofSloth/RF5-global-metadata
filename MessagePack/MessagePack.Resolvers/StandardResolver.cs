public sealed class StandardResolver : IFormatterResolver // TypeDefIndex: 5266
{
	// Fields
	public static readonly StandardResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8
	private static readonly IFormatterResolver[] Resolvers; // 0x10

	// Methods

	// RVA: 0x14F8CB0 Offset: 0x14F8DB1 VA: 0x14F8CB0
	private static void .cctor() { }

	// RVA: 0x14F8DE0 Offset: 0x14F8EE1 VA: 0x14F8DE0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FEFD0 Offset: 0x27FF0D1 VA: 0x27FEFD0
	|-StandardResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27FF080 Offset: 0x27FF181 VA: 0x27FF080
	|-StandardResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27FF130 Offset: 0x27FF231 VA: 0x27FF130
	|-StandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27FF1E0 Offset: 0x27FF2E1 VA: 0x27FF1E0
	|-StandardResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27FF290 Offset: 0x27FF391 VA: 0x27FF290
	|-StandardResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27FF340 Offset: 0x27FF441 VA: 0x27FF340
	|-StandardResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27FF3F0 Offset: 0x27FF4F1 VA: 0x27FF3F0
	|-StandardResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27FF4A0 Offset: 0x27FF5A1 VA: 0x27FF4A0
	|-StandardResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27FF550 Offset: 0x27FF651 VA: 0x27FF550
	|-StandardResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27FF600 Offset: 0x27FF701 VA: 0x27FF600
	|-StandardResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27FF6B0 Offset: 0x27FF7B1 VA: 0x27FF6B0
	|-StandardResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27FF760 Offset: 0x27FF861 VA: 0x27FF760
	|-StandardResolver.GetFormatter<bool>
	|
	|-RVA: 0x27FF810 Offset: 0x27FF911 VA: 0x27FF810
	|-StandardResolver.GetFormatter<byte>
	|
	|-RVA: 0x27FF8C0 Offset: 0x27FF9C1 VA: 0x27FF8C0
	|-StandardResolver.GetFormatter<char>
	|
	|-RVA: 0x27FF970 Offset: 0x27FFA71 VA: 0x27FF970
	|-StandardResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FFA20 Offset: 0x27FFB21 VA: 0x27FFA20
	|-StandardResolver.GetFormatter<double>
	|
	|-RVA: 0x27FFAD0 Offset: 0x27FFBD1 VA: 0x27FFAD0
	|-StandardResolver.GetFormatter<short>
	|
	|-RVA: 0x27FFB80 Offset: 0x27FFC81 VA: 0x27FFB80
	|-StandardResolver.GetFormatter<int>
	|
	|-RVA: 0x27FFC30 Offset: 0x27FFD31 VA: 0x27FFC30
	|-StandardResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FFCE0 Offset: 0x27FFDE1 VA: 0x27FFCE0
	|-StandardResolver.GetFormatter<long>
	|
	|-RVA: 0x27FFD90 Offset: 0x27FFE91 VA: 0x27FFD90
	|-StandardResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FFE40 Offset: 0x27FFF41 VA: 0x27FFE40
	|-StandardResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FFEF0 Offset: 0x27FFFF1 VA: 0x27FFEF0
	|-StandardResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FFFA0 Offset: 0x28000A1 VA: 0x27FFFA0
	|-StandardResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x2800050 Offset: 0x2800151 VA: 0x2800050
	|-StandardResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2800100 Offset: 0x2800201 VA: 0x2800100
	|-StandardResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x28001B0 Offset: 0x28002B1 VA: 0x28001B0
	|-StandardResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2800260 Offset: 0x2800361 VA: 0x2800260
	|-StandardResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2800310 Offset: 0x2800411 VA: 0x2800310
	|-StandardResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x28003C0 Offset: 0x28004C1 VA: 0x28003C0
	|-StandardResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2800470 Offset: 0x2800571 VA: 0x2800470
	|-StandardResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2800520 Offset: 0x2800621 VA: 0x2800520
	|-StandardResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x28005D0 Offset: 0x28006D1 VA: 0x28005D0
	|-StandardResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2800680 Offset: 0x2800781 VA: 0x2800680
	|-StandardResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x2800730 Offset: 0x2800831 VA: 0x2800730
	|-StandardResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x28007E0 Offset: 0x28008E1 VA: 0x28007E0
	|-StandardResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x2800890 Offset: 0x2800991 VA: 0x2800890
	|-StandardResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x2800940 Offset: 0x2800A41 VA: 0x2800940
	|-StandardResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x28009F0 Offset: 0x2800AF1 VA: 0x28009F0
	|-StandardResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2800AA0 Offset: 0x2800BA1 VA: 0x2800AA0
	|-StandardResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x2800B50 Offset: 0x2800C51 VA: 0x2800B50
	|-StandardResolver.GetFormatter<object>
	|
	|-RVA: 0x2800C00 Offset: 0x2800D01 VA: 0x2800C00
	|-StandardResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2800CB0 Offset: 0x2800DB1 VA: 0x2800CB0
	|-StandardResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x2800D60 Offset: 0x2800E61 VA: 0x2800D60
	|-StandardResolver.GetFormatter<float>
	|
	|-RVA: 0x2800E10 Offset: 0x2800F11 VA: 0x2800E10
	|-StandardResolver.GetFormatter<ushort>
	|
	|-RVA: 0x2800EC0 Offset: 0x2800FC1 VA: 0x2800EC0
	|-StandardResolver.GetFormatter<uint>
	|
	|-RVA: 0x2800F70 Offset: 0x2801071 VA: 0x2800F70
	|-StandardResolver.GetFormatter<ulong>
	|
	|-RVA: 0x2801020 Offset: 0x2801121 VA: 0x2801020
	|-StandardResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x28010D0 Offset: 0x28011D1 VA: 0x28010D0
	|-StandardResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2801180 Offset: 0x2801281 VA: 0x2801180
	|-StandardResolver.GetFormatter<Color32>
	|
	|-RVA: 0x2801230 Offset: 0x2801331 VA: 0x2801230
	|-StandardResolver.GetFormatter<Color>
	|
	|-RVA: 0x28012E0 Offset: 0x28013E1 VA: 0x28012E0
	|-StandardResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2801390 Offset: 0x2801491 VA: 0x2801390
	|-StandardResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x2801440 Offset: 0x2801541 VA: 0x2801440
	|-StandardResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x28014F0 Offset: 0x28015F1 VA: 0x28014F0
	|-StandardResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x28015A0 Offset: 0x28016A1 VA: 0x28015A0
	|-StandardResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2801650 Offset: 0x2801751 VA: 0x2801650
	|-StandardResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x2801700 Offset: 0x2801801 VA: 0x2801700
	|-StandardResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x28017B0 Offset: 0x28018B1 VA: 0x28017B0
	|-StandardResolver.GetFormatter<Rect>
	|
	|-RVA: 0x2801860 Offset: 0x2801961 VA: 0x2801860
	|-StandardResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x2801910 Offset: 0x2801A11 VA: 0x2801910
	|-StandardResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x28019C0 Offset: 0x2801AC1 VA: 0x28019C0
	|-StandardResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x2801A70 Offset: 0x2801B71 VA: 0x2801A70
	|-StandardResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x2801B20 Offset: 0x2801C21 VA: 0x2801B20
	|-StandardResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2801BD0 Offset: 0x2801CD1 VA: 0x2801BD0
	|-StandardResolver.GetFormatter<Vector4>
	*/
}

