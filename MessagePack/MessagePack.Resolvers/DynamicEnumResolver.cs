public sealed class DynamicEnumResolver : IFormatterResolver // TypeDefIndex: 5233
{
	// Fields
	public static readonly DynamicEnumResolver Instance; // 0x0
	private const string ModuleName = "MessagePack.Resolvers.DynamicEnumResolver";
	private static readonly Lazy<DynamicAssembly> DynamicAssembly; // 0x8
	private static int nameSequence; // 0x10

	// Methods

	// RVA: 0x14F2D20 Offset: 0x14F2E21 VA: 0x14F2D20
	private void .ctor() { }

	// RVA: 0x14F2D30 Offset: 0x14F2E31 VA: 0x14F2D30
	private static void .cctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181F030 Offset: 0x181F131 VA: 0x181F030
	|-DynamicEnumResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x181F0E0 Offset: 0x181F1E1 VA: 0x181F0E0
	|-DynamicEnumResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x181F190 Offset: 0x181F291 VA: 0x181F190
	|-DynamicEnumResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x181F240 Offset: 0x181F341 VA: 0x181F240
	|-DynamicEnumResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x181F2F0 Offset: 0x181F3F1 VA: 0x181F2F0
	|-DynamicEnumResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x181F3A0 Offset: 0x181F4A1 VA: 0x181F3A0
	|-DynamicEnumResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x181F450 Offset: 0x181F551 VA: 0x181F450
	|-DynamicEnumResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x181F500 Offset: 0x181F601 VA: 0x181F500
	|-DynamicEnumResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x181F5B0 Offset: 0x181F6B1 VA: 0x181F5B0
	|-DynamicEnumResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x181F660 Offset: 0x181F761 VA: 0x181F660
	|-DynamicEnumResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x181F710 Offset: 0x181F811 VA: 0x181F710
	|-DynamicEnumResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x181F7C0 Offset: 0x181F8C1 VA: 0x181F7C0
	|-DynamicEnumResolver.GetFormatter<bool>
	|
	|-RVA: 0x181F870 Offset: 0x181F971 VA: 0x181F870
	|-DynamicEnumResolver.GetFormatter<byte>
	|
	|-RVA: 0x181F920 Offset: 0x181FA21 VA: 0x181F920
	|-DynamicEnumResolver.GetFormatter<char>
	|
	|-RVA: 0x181F9D0 Offset: 0x181FAD1 VA: 0x181F9D0
	|-DynamicEnumResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x181FA80 Offset: 0x181FB81 VA: 0x181FA80
	|-DynamicEnumResolver.GetFormatter<double>
	|
	|-RVA: 0x181FB30 Offset: 0x181FC31 VA: 0x181FB30
	|-DynamicEnumResolver.GetFormatter<short>
	|
	|-RVA: 0x181FBE0 Offset: 0x181FCE1 VA: 0x181FBE0
	|-DynamicEnumResolver.GetFormatter<int>
	|
	|-RVA: 0x181FC90 Offset: 0x181FD91 VA: 0x181FC90
	|-DynamicEnumResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x181FD40 Offset: 0x181FE41 VA: 0x181FD40
	|-DynamicEnumResolver.GetFormatter<long>
	|
	|-RVA: 0x181FDF0 Offset: 0x181FEF1 VA: 0x181FDF0
	|-DynamicEnumResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x181FEA0 Offset: 0x181FFA1 VA: 0x181FEA0
	|-DynamicEnumResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x181FF50 Offset: 0x1820051 VA: 0x181FF50
	|-DynamicEnumResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1820000 Offset: 0x1820101 VA: 0x1820000
	|-DynamicEnumResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x18200B0 Offset: 0x18201B1 VA: 0x18200B0
	|-DynamicEnumResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1820160 Offset: 0x1820261 VA: 0x1820160
	|-DynamicEnumResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1820210 Offset: 0x1820311 VA: 0x1820210
	|-DynamicEnumResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x18202C0 Offset: 0x18203C1 VA: 0x18202C0
	|-DynamicEnumResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1820370 Offset: 0x1820471 VA: 0x1820370
	|-DynamicEnumResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1820420 Offset: 0x1820521 VA: 0x1820420
	|-DynamicEnumResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x18204D0 Offset: 0x18205D1 VA: 0x18204D0
	|-DynamicEnumResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1820580 Offset: 0x1820681 VA: 0x1820580
	|-DynamicEnumResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1820630 Offset: 0x1820731 VA: 0x1820630
	|-DynamicEnumResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x18206E0 Offset: 0x18207E1 VA: 0x18206E0
	|-DynamicEnumResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1820790 Offset: 0x1820891 VA: 0x1820790
	|-DynamicEnumResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1820840 Offset: 0x1820941 VA: 0x1820840
	|-DynamicEnumResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18208F0 Offset: 0x18209F1 VA: 0x18208F0
	|-DynamicEnumResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x18209A0 Offset: 0x1820AA1 VA: 0x18209A0
	|-DynamicEnumResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1820A50 Offset: 0x1820B51 VA: 0x1820A50
	|-DynamicEnumResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1820B00 Offset: 0x1820C01 VA: 0x1820B00
	|-DynamicEnumResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1820BB0 Offset: 0x1820CB1 VA: 0x1820BB0
	|-DynamicEnumResolver.GetFormatter<object>
	|
	|-RVA: 0x1820C60 Offset: 0x1820D61 VA: 0x1820C60
	|-DynamicEnumResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1820D10 Offset: 0x1820E11 VA: 0x1820D10
	|-DynamicEnumResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1820DC0 Offset: 0x1820EC1 VA: 0x1820DC0
	|-DynamicEnumResolver.GetFormatter<float>
	|
	|-RVA: 0x1820E70 Offset: 0x1820F71 VA: 0x1820E70
	|-DynamicEnumResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1820F20 Offset: 0x1821021 VA: 0x1820F20
	|-DynamicEnumResolver.GetFormatter<uint>
	|
	|-RVA: 0x1820FD0 Offset: 0x18210D1 VA: 0x1820FD0
	|-DynamicEnumResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1821080 Offset: 0x1821181 VA: 0x1821080
	|-DynamicEnumResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1821130 Offset: 0x1821231 VA: 0x1821130
	|-DynamicEnumResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x18211E0 Offset: 0x18212E1 VA: 0x18211E0
	|-DynamicEnumResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1821290 Offset: 0x1821391 VA: 0x1821290
	|-DynamicEnumResolver.GetFormatter<Color>
	|
	|-RVA: 0x1821340 Offset: 0x1821441 VA: 0x1821340
	|-DynamicEnumResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x18213F0 Offset: 0x18214F1 VA: 0x18213F0
	|-DynamicEnumResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x18214A0 Offset: 0x18215A1 VA: 0x18214A0
	|-DynamicEnumResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1821550 Offset: 0x1821651 VA: 0x1821550
	|-DynamicEnumResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1821600 Offset: 0x1821701 VA: 0x1821600
	|-DynamicEnumResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x18216B0 Offset: 0x18217B1 VA: 0x18216B0
	|-DynamicEnumResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1821760 Offset: 0x1821861 VA: 0x1821760
	|-DynamicEnumResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1821810 Offset: 0x1821911 VA: 0x1821810
	|-DynamicEnumResolver.GetFormatter<Rect>
	|
	|-RVA: 0x18218C0 Offset: 0x18219C1 VA: 0x18218C0
	|-DynamicEnumResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1821970 Offset: 0x1821A71 VA: 0x1821970
	|-DynamicEnumResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1821A20 Offset: 0x1821B21 VA: 0x1821A20
	|-DynamicEnumResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1821AD0 Offset: 0x1821BD1 VA: 0x1821AD0
	|-DynamicEnumResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1821B80 Offset: 0x1821C81 VA: 0x1821B80
	|-DynamicEnumResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1821C30 Offset: 0x1821D31 VA: 0x1821C30
	|-DynamicEnumResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F2E50 Offset: 0x14F2F51 VA: 0x14F2E50
	private static TypeInfo BuildType(Type enumType) { }
}

