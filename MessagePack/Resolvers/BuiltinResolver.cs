public sealed class BuiltinResolver : IFormatterResolver // TypeDefIndex: 5226
{
	// Fields
	public static readonly BuiltinResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F2150 Offset: 0x14F2251 VA: 0x14F2150
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B15A00 Offset: 0x1B15B01 VA: 0x1B15A00
	|-BuiltinResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1B15AB0 Offset: 0x1B15BB1 VA: 0x1B15AB0
	|-BuiltinResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1B15B60 Offset: 0x1B15C61 VA: 0x1B15B60
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1B15C10 Offset: 0x1B15D11 VA: 0x1B15C10
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1B15CC0 Offset: 0x1B15DC1 VA: 0x1B15CC0
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1B15D70 Offset: 0x1B15E71 VA: 0x1B15D70
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1B15E20 Offset: 0x1B15F21 VA: 0x1B15E20
	|-BuiltinResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1B15ED0 Offset: 0x1B15FD1 VA: 0x1B15ED0
	|-BuiltinResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1B15F80 Offset: 0x1B16081 VA: 0x1B15F80
	|-BuiltinResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1B16030 Offset: 0x1B16131 VA: 0x1B16030
	|-BuiltinResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1B160E0 Offset: 0x1B161E1 VA: 0x1B160E0
	|-BuiltinResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1B16190 Offset: 0x1B16291 VA: 0x1B16190
	|-BuiltinResolver.GetFormatter<bool>
	|
	|-RVA: 0x1B16240 Offset: 0x1B16341 VA: 0x1B16240
	|-BuiltinResolver.GetFormatter<byte>
	|
	|-RVA: 0x1B162F0 Offset: 0x1B163F1 VA: 0x1B162F0
	|-BuiltinResolver.GetFormatter<char>
	|
	|-RVA: 0x1B163A0 Offset: 0x1B164A1 VA: 0x1B163A0
	|-BuiltinResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1B16450 Offset: 0x1B16551 VA: 0x1B16450
	|-BuiltinResolver.GetFormatter<double>
	|
	|-RVA: 0x1B16500 Offset: 0x1B16601 VA: 0x1B16500
	|-BuiltinResolver.GetFormatter<short>
	|
	|-RVA: 0x1B165B0 Offset: 0x1B166B1 VA: 0x1B165B0
	|-BuiltinResolver.GetFormatter<int>
	|
	|-RVA: 0x1B16660 Offset: 0x1B16761 VA: 0x1B16660
	|-BuiltinResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1B16710 Offset: 0x1B16811 VA: 0x1B16710
	|-BuiltinResolver.GetFormatter<long>
	|
	|-RVA: 0x1B167C0 Offset: 0x1B168C1 VA: 0x1B167C0
	|-BuiltinResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1B16870 Offset: 0x1B16971 VA: 0x1B16870
	|-BuiltinResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1B16920 Offset: 0x1B16A21 VA: 0x1B16920
	|-BuiltinResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1B169D0 Offset: 0x1B16AD1 VA: 0x1B169D0
	|-BuiltinResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1B16A80 Offset: 0x1B16B81 VA: 0x1B16A80
	|-BuiltinResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1B16B30 Offset: 0x1B16C31 VA: 0x1B16B30
	|-BuiltinResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1B16BE0 Offset: 0x1B16CE1 VA: 0x1B16BE0
	|-BuiltinResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1B16C90 Offset: 0x1B16D91 VA: 0x1B16C90
	|-BuiltinResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1B16D40 Offset: 0x1B16E41 VA: 0x1B16D40
	|-BuiltinResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1B16DF0 Offset: 0x1B16EF1 VA: 0x1B16DF0
	|-BuiltinResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1B16EA0 Offset: 0x1B16FA1 VA: 0x1B16EA0
	|-BuiltinResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1B16F50 Offset: 0x1B17051 VA: 0x1B16F50
	|-BuiltinResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1B17000 Offset: 0x1B17101 VA: 0x1B17000
	|-BuiltinResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1B170B0 Offset: 0x1B171B1 VA: 0x1B170B0
	|-BuiltinResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1B17160 Offset: 0x1B17261 VA: 0x1B17160
	|-BuiltinResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1B17210 Offset: 0x1B17311 VA: 0x1B17210
	|-BuiltinResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1B172C0 Offset: 0x1B173C1 VA: 0x1B172C0
	|-BuiltinResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1B17370 Offset: 0x1B17471 VA: 0x1B17370
	|-BuiltinResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1B17420 Offset: 0x1B17521 VA: 0x1B17420
	|-BuiltinResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1B174D0 Offset: 0x1B175D1 VA: 0x1B174D0
	|-BuiltinResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1B17580 Offset: 0x1B17681 VA: 0x1B17580
	|-BuiltinResolver.GetFormatter<object>
	|
	|-RVA: 0x1B17630 Offset: 0x1B17731 VA: 0x1B17630
	|-BuiltinResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1B176E0 Offset: 0x1B177E1 VA: 0x1B176E0
	|-BuiltinResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1B17790 Offset: 0x1B17891 VA: 0x1B17790
	|-BuiltinResolver.GetFormatter<float>
	|
	|-RVA: 0x1B17840 Offset: 0x1B17941 VA: 0x1B17840
	|-BuiltinResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1B178F0 Offset: 0x1B179F1 VA: 0x1B178F0
	|-BuiltinResolver.GetFormatter<uint>
	|
	|-RVA: 0x1B179A0 Offset: 0x1B17AA1 VA: 0x1B179A0
	|-BuiltinResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1B17A50 Offset: 0x1B17B51 VA: 0x1B17A50
	|-BuiltinResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1B17B00 Offset: 0x1B17C01 VA: 0x1B17B00
	|-BuiltinResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1B17BB0 Offset: 0x1B17CB1 VA: 0x1B17BB0
	|-BuiltinResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1B17C60 Offset: 0x1B17D61 VA: 0x1B17C60
	|-BuiltinResolver.GetFormatter<Color>
	|
	|-RVA: 0x1B17D10 Offset: 0x1B17E11 VA: 0x1B17D10
	|-BuiltinResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1B17DC0 Offset: 0x1B17EC1 VA: 0x1B17DC0
	|-BuiltinResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1B17E70 Offset: 0x1B17F71 VA: 0x1B17E70
	|-BuiltinResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1B17F20 Offset: 0x1B18021 VA: 0x1B17F20
	|-BuiltinResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1B17FD0 Offset: 0x1B180D1 VA: 0x1B17FD0
	|-BuiltinResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1B18080 Offset: 0x1B18181 VA: 0x1B18080
	|-BuiltinResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1B18130 Offset: 0x1B18231 VA: 0x1B18130
	|-BuiltinResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1B181E0 Offset: 0x1B182E1 VA: 0x1B181E0
	|-BuiltinResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1B18290 Offset: 0x1B18391 VA: 0x1B18290
	|-BuiltinResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1B18340 Offset: 0x1B18441 VA: 0x1B18340
	|-BuiltinResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1B183F0 Offset: 0x1B184F1 VA: 0x1B183F0
	|-BuiltinResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1B184A0 Offset: 0x1B185A1 VA: 0x1B184A0
	|-BuiltinResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1B18550 Offset: 0x1B18651 VA: 0x1B18550
	|-BuiltinResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1B18600 Offset: 0x1B18701 VA: 0x1B18600
	|-BuiltinResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F2160 Offset: 0x14F2261 VA: 0x14F2160
	private static void .cctor() { }
}

public sealed class BuiltinResolver : IFormatterResolver // TypeDefIndex: 5226
{
	// Fields
	public static readonly BuiltinResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F2150 Offset: 0x14F2251 VA: 0x14F2150
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B15A00 Offset: 0x1B15B01 VA: 0x1B15A00
	|-BuiltinResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1B15AB0 Offset: 0x1B15BB1 VA: 0x1B15AB0
	|-BuiltinResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1B15B60 Offset: 0x1B15C61 VA: 0x1B15B60
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1B15C10 Offset: 0x1B15D11 VA: 0x1B15C10
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1B15CC0 Offset: 0x1B15DC1 VA: 0x1B15CC0
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1B15D70 Offset: 0x1B15E71 VA: 0x1B15D70
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1B15E20 Offset: 0x1B15F21 VA: 0x1B15E20
	|-BuiltinResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1B15ED0 Offset: 0x1B15FD1 VA: 0x1B15ED0
	|-BuiltinResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1B15F80 Offset: 0x1B16081 VA: 0x1B15F80
	|-BuiltinResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1B16030 Offset: 0x1B16131 VA: 0x1B16030
	|-BuiltinResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1B160E0 Offset: 0x1B161E1 VA: 0x1B160E0
	|-BuiltinResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1B16190 Offset: 0x1B16291 VA: 0x1B16190
	|-BuiltinResolver.GetFormatter<bool>
	|
	|-RVA: 0x1B16240 Offset: 0x1B16341 VA: 0x1B16240
	|-BuiltinResolver.GetFormatter<byte>
	|
	|-RVA: 0x1B162F0 Offset: 0x1B163F1 VA: 0x1B162F0
	|-BuiltinResolver.GetFormatter<char>
	|
	|-RVA: 0x1B163A0 Offset: 0x1B164A1 VA: 0x1B163A0
	|-BuiltinResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1B16450 Offset: 0x1B16551 VA: 0x1B16450
	|-BuiltinResolver.GetFormatter<double>
	|
	|-RVA: 0x1B16500 Offset: 0x1B16601 VA: 0x1B16500
	|-BuiltinResolver.GetFormatter<short>
	|
	|-RVA: 0x1B165B0 Offset: 0x1B166B1 VA: 0x1B165B0
	|-BuiltinResolver.GetFormatter<int>
	|
	|-RVA: 0x1B16660 Offset: 0x1B16761 VA: 0x1B16660
	|-BuiltinResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1B16710 Offset: 0x1B16811 VA: 0x1B16710
	|-BuiltinResolver.GetFormatter<long>
	|
	|-RVA: 0x1B167C0 Offset: 0x1B168C1 VA: 0x1B167C0
	|-BuiltinResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1B16870 Offset: 0x1B16971 VA: 0x1B16870
	|-BuiltinResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1B16920 Offset: 0x1B16A21 VA: 0x1B16920
	|-BuiltinResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1B169D0 Offset: 0x1B16AD1 VA: 0x1B169D0
	|-BuiltinResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1B16A80 Offset: 0x1B16B81 VA: 0x1B16A80
	|-BuiltinResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1B16B30 Offset: 0x1B16C31 VA: 0x1B16B30
	|-BuiltinResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1B16BE0 Offset: 0x1B16CE1 VA: 0x1B16BE0
	|-BuiltinResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1B16C90 Offset: 0x1B16D91 VA: 0x1B16C90
	|-BuiltinResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1B16D40 Offset: 0x1B16E41 VA: 0x1B16D40
	|-BuiltinResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1B16DF0 Offset: 0x1B16EF1 VA: 0x1B16DF0
	|-BuiltinResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1B16EA0 Offset: 0x1B16FA1 VA: 0x1B16EA0
	|-BuiltinResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1B16F50 Offset: 0x1B17051 VA: 0x1B16F50
	|-BuiltinResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1B17000 Offset: 0x1B17101 VA: 0x1B17000
	|-BuiltinResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1B170B0 Offset: 0x1B171B1 VA: 0x1B170B0
	|-BuiltinResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1B17160 Offset: 0x1B17261 VA: 0x1B17160
	|-BuiltinResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1B17210 Offset: 0x1B17311 VA: 0x1B17210
	|-BuiltinResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1B172C0 Offset: 0x1B173C1 VA: 0x1B172C0
	|-BuiltinResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1B17370 Offset: 0x1B17471 VA: 0x1B17370
	|-BuiltinResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1B17420 Offset: 0x1B17521 VA: 0x1B17420
	|-BuiltinResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1B174D0 Offset: 0x1B175D1 VA: 0x1B174D0
	|-BuiltinResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1B17580 Offset: 0x1B17681 VA: 0x1B17580
	|-BuiltinResolver.GetFormatter<object>
	|
	|-RVA: 0x1B17630 Offset: 0x1B17731 VA: 0x1B17630
	|-BuiltinResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1B176E0 Offset: 0x1B177E1 VA: 0x1B176E0
	|-BuiltinResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1B17790 Offset: 0x1B17891 VA: 0x1B17790
	|-BuiltinResolver.GetFormatter<float>
	|
	|-RVA: 0x1B17840 Offset: 0x1B17941 VA: 0x1B17840
	|-BuiltinResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1B178F0 Offset: 0x1B179F1 VA: 0x1B178F0
	|-BuiltinResolver.GetFormatter<uint>
	|
	|-RVA: 0x1B179A0 Offset: 0x1B17AA1 VA: 0x1B179A0
	|-BuiltinResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1B17A50 Offset: 0x1B17B51 VA: 0x1B17A50
	|-BuiltinResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1B17B00 Offset: 0x1B17C01 VA: 0x1B17B00
	|-BuiltinResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1B17BB0 Offset: 0x1B17CB1 VA: 0x1B17BB0
	|-BuiltinResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1B17C60 Offset: 0x1B17D61 VA: 0x1B17C60
	|-BuiltinResolver.GetFormatter<Color>
	|
	|-RVA: 0x1B17D10 Offset: 0x1B17E11 VA: 0x1B17D10
	|-BuiltinResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1B17DC0 Offset: 0x1B17EC1 VA: 0x1B17DC0
	|-BuiltinResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1B17E70 Offset: 0x1B17F71 VA: 0x1B17E70
	|-BuiltinResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1B17F20 Offset: 0x1B18021 VA: 0x1B17F20
	|-BuiltinResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1B17FD0 Offset: 0x1B180D1 VA: 0x1B17FD0
	|-BuiltinResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1B18080 Offset: 0x1B18181 VA: 0x1B18080
	|-BuiltinResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1B18130 Offset: 0x1B18231 VA: 0x1B18130
	|-BuiltinResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1B181E0 Offset: 0x1B182E1 VA: 0x1B181E0
	|-BuiltinResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1B18290 Offset: 0x1B18391 VA: 0x1B18290
	|-BuiltinResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1B18340 Offset: 0x1B18441 VA: 0x1B18340
	|-BuiltinResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1B183F0 Offset: 0x1B184F1 VA: 0x1B183F0
	|-BuiltinResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1B184A0 Offset: 0x1B185A1 VA: 0x1B184A0
	|-BuiltinResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1B18550 Offset: 0x1B18651 VA: 0x1B18550
	|-BuiltinResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1B18600 Offset: 0x1B18701 VA: 0x1B18600
	|-BuiltinResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F2160 Offset: 0x14F2261 VA: 0x14F2160
	private static void .cctor() { }
}

public sealed class BuiltinResolver : IFormatterResolver // TypeDefIndex: 5226
{
	// Fields
	public static readonly BuiltinResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F2150 Offset: 0x14F2251 VA: 0x14F2150
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B15A00 Offset: 0x1B15B01 VA: 0x1B15A00
	|-BuiltinResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1B15AB0 Offset: 0x1B15BB1 VA: 0x1B15AB0
	|-BuiltinResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1B15B60 Offset: 0x1B15C61 VA: 0x1B15B60
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1B15C10 Offset: 0x1B15D11 VA: 0x1B15C10
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1B15CC0 Offset: 0x1B15DC1 VA: 0x1B15CC0
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1B15D70 Offset: 0x1B15E71 VA: 0x1B15D70
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1B15E20 Offset: 0x1B15F21 VA: 0x1B15E20
	|-BuiltinResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1B15ED0 Offset: 0x1B15FD1 VA: 0x1B15ED0
	|-BuiltinResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1B15F80 Offset: 0x1B16081 VA: 0x1B15F80
	|-BuiltinResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1B16030 Offset: 0x1B16131 VA: 0x1B16030
	|-BuiltinResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1B160E0 Offset: 0x1B161E1 VA: 0x1B160E0
	|-BuiltinResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1B16190 Offset: 0x1B16291 VA: 0x1B16190
	|-BuiltinResolver.GetFormatter<bool>
	|
	|-RVA: 0x1B16240 Offset: 0x1B16341 VA: 0x1B16240
	|-BuiltinResolver.GetFormatter<byte>
	|
	|-RVA: 0x1B162F0 Offset: 0x1B163F1 VA: 0x1B162F0
	|-BuiltinResolver.GetFormatter<char>
	|
	|-RVA: 0x1B163A0 Offset: 0x1B164A1 VA: 0x1B163A0
	|-BuiltinResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1B16450 Offset: 0x1B16551 VA: 0x1B16450
	|-BuiltinResolver.GetFormatter<double>
	|
	|-RVA: 0x1B16500 Offset: 0x1B16601 VA: 0x1B16500
	|-BuiltinResolver.GetFormatter<short>
	|
	|-RVA: 0x1B165B0 Offset: 0x1B166B1 VA: 0x1B165B0
	|-BuiltinResolver.GetFormatter<int>
	|
	|-RVA: 0x1B16660 Offset: 0x1B16761 VA: 0x1B16660
	|-BuiltinResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1B16710 Offset: 0x1B16811 VA: 0x1B16710
	|-BuiltinResolver.GetFormatter<long>
	|
	|-RVA: 0x1B167C0 Offset: 0x1B168C1 VA: 0x1B167C0
	|-BuiltinResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1B16870 Offset: 0x1B16971 VA: 0x1B16870
	|-BuiltinResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1B16920 Offset: 0x1B16A21 VA: 0x1B16920
	|-BuiltinResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1B169D0 Offset: 0x1B16AD1 VA: 0x1B169D0
	|-BuiltinResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1B16A80 Offset: 0x1B16B81 VA: 0x1B16A80
	|-BuiltinResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1B16B30 Offset: 0x1B16C31 VA: 0x1B16B30
	|-BuiltinResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1B16BE0 Offset: 0x1B16CE1 VA: 0x1B16BE0
	|-BuiltinResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1B16C90 Offset: 0x1B16D91 VA: 0x1B16C90
	|-BuiltinResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1B16D40 Offset: 0x1B16E41 VA: 0x1B16D40
	|-BuiltinResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1B16DF0 Offset: 0x1B16EF1 VA: 0x1B16DF0
	|-BuiltinResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1B16EA0 Offset: 0x1B16FA1 VA: 0x1B16EA0
	|-BuiltinResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1B16F50 Offset: 0x1B17051 VA: 0x1B16F50
	|-BuiltinResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1B17000 Offset: 0x1B17101 VA: 0x1B17000
	|-BuiltinResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1B170B0 Offset: 0x1B171B1 VA: 0x1B170B0
	|-BuiltinResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1B17160 Offset: 0x1B17261 VA: 0x1B17160
	|-BuiltinResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1B17210 Offset: 0x1B17311 VA: 0x1B17210
	|-BuiltinResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1B172C0 Offset: 0x1B173C1 VA: 0x1B172C0
	|-BuiltinResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1B17370 Offset: 0x1B17471 VA: 0x1B17370
	|-BuiltinResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1B17420 Offset: 0x1B17521 VA: 0x1B17420
	|-BuiltinResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1B174D0 Offset: 0x1B175D1 VA: 0x1B174D0
	|-BuiltinResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1B17580 Offset: 0x1B17681 VA: 0x1B17580
	|-BuiltinResolver.GetFormatter<object>
	|
	|-RVA: 0x1B17630 Offset: 0x1B17731 VA: 0x1B17630
	|-BuiltinResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1B176E0 Offset: 0x1B177E1 VA: 0x1B176E0
	|-BuiltinResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1B17790 Offset: 0x1B17891 VA: 0x1B17790
	|-BuiltinResolver.GetFormatter<float>
	|
	|-RVA: 0x1B17840 Offset: 0x1B17941 VA: 0x1B17840
	|-BuiltinResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1B178F0 Offset: 0x1B179F1 VA: 0x1B178F0
	|-BuiltinResolver.GetFormatter<uint>
	|
	|-RVA: 0x1B179A0 Offset: 0x1B17AA1 VA: 0x1B179A0
	|-BuiltinResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1B17A50 Offset: 0x1B17B51 VA: 0x1B17A50
	|-BuiltinResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1B17B00 Offset: 0x1B17C01 VA: 0x1B17B00
	|-BuiltinResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1B17BB0 Offset: 0x1B17CB1 VA: 0x1B17BB0
	|-BuiltinResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1B17C60 Offset: 0x1B17D61 VA: 0x1B17C60
	|-BuiltinResolver.GetFormatter<Color>
	|
	|-RVA: 0x1B17D10 Offset: 0x1B17E11 VA: 0x1B17D10
	|-BuiltinResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1B17DC0 Offset: 0x1B17EC1 VA: 0x1B17DC0
	|-BuiltinResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1B17E70 Offset: 0x1B17F71 VA: 0x1B17E70
	|-BuiltinResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1B17F20 Offset: 0x1B18021 VA: 0x1B17F20
	|-BuiltinResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1B17FD0 Offset: 0x1B180D1 VA: 0x1B17FD0
	|-BuiltinResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1B18080 Offset: 0x1B18181 VA: 0x1B18080
	|-BuiltinResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1B18130 Offset: 0x1B18231 VA: 0x1B18130
	|-BuiltinResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1B181E0 Offset: 0x1B182E1 VA: 0x1B181E0
	|-BuiltinResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1B18290 Offset: 0x1B18391 VA: 0x1B18290
	|-BuiltinResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1B18340 Offset: 0x1B18441 VA: 0x1B18340
	|-BuiltinResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1B183F0 Offset: 0x1B184F1 VA: 0x1B183F0
	|-BuiltinResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1B184A0 Offset: 0x1B185A1 VA: 0x1B184A0
	|-BuiltinResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1B18550 Offset: 0x1B18651 VA: 0x1B18550
	|-BuiltinResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1B18600 Offset: 0x1B18701 VA: 0x1B18600
	|-BuiltinResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F2160 Offset: 0x14F2261 VA: 0x14F2160
	private static void .cctor() { }
}

public sealed class BuiltinResolver : IFormatterResolver // TypeDefIndex: 5226
{
	// Fields
	public static readonly BuiltinResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F2150 Offset: 0x14F2251 VA: 0x14F2150
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B15A00 Offset: 0x1B15B01 VA: 0x1B15A00
	|-BuiltinResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1B15AB0 Offset: 0x1B15BB1 VA: 0x1B15AB0
	|-BuiltinResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1B15B60 Offset: 0x1B15C61 VA: 0x1B15B60
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1B15C10 Offset: 0x1B15D11 VA: 0x1B15C10
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1B15CC0 Offset: 0x1B15DC1 VA: 0x1B15CC0
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1B15D70 Offset: 0x1B15E71 VA: 0x1B15D70
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1B15E20 Offset: 0x1B15F21 VA: 0x1B15E20
	|-BuiltinResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1B15ED0 Offset: 0x1B15FD1 VA: 0x1B15ED0
	|-BuiltinResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1B15F80 Offset: 0x1B16081 VA: 0x1B15F80
	|-BuiltinResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1B16030 Offset: 0x1B16131 VA: 0x1B16030
	|-BuiltinResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1B160E0 Offset: 0x1B161E1 VA: 0x1B160E0
	|-BuiltinResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1B16190 Offset: 0x1B16291 VA: 0x1B16190
	|-BuiltinResolver.GetFormatter<bool>
	|
	|-RVA: 0x1B16240 Offset: 0x1B16341 VA: 0x1B16240
	|-BuiltinResolver.GetFormatter<byte>
	|
	|-RVA: 0x1B162F0 Offset: 0x1B163F1 VA: 0x1B162F0
	|-BuiltinResolver.GetFormatter<char>
	|
	|-RVA: 0x1B163A0 Offset: 0x1B164A1 VA: 0x1B163A0
	|-BuiltinResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1B16450 Offset: 0x1B16551 VA: 0x1B16450
	|-BuiltinResolver.GetFormatter<double>
	|
	|-RVA: 0x1B16500 Offset: 0x1B16601 VA: 0x1B16500
	|-BuiltinResolver.GetFormatter<short>
	|
	|-RVA: 0x1B165B0 Offset: 0x1B166B1 VA: 0x1B165B0
	|-BuiltinResolver.GetFormatter<int>
	|
	|-RVA: 0x1B16660 Offset: 0x1B16761 VA: 0x1B16660
	|-BuiltinResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1B16710 Offset: 0x1B16811 VA: 0x1B16710
	|-BuiltinResolver.GetFormatter<long>
	|
	|-RVA: 0x1B167C0 Offset: 0x1B168C1 VA: 0x1B167C0
	|-BuiltinResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1B16870 Offset: 0x1B16971 VA: 0x1B16870
	|-BuiltinResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1B16920 Offset: 0x1B16A21 VA: 0x1B16920
	|-BuiltinResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1B169D0 Offset: 0x1B16AD1 VA: 0x1B169D0
	|-BuiltinResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1B16A80 Offset: 0x1B16B81 VA: 0x1B16A80
	|-BuiltinResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1B16B30 Offset: 0x1B16C31 VA: 0x1B16B30
	|-BuiltinResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1B16BE0 Offset: 0x1B16CE1 VA: 0x1B16BE0
	|-BuiltinResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1B16C90 Offset: 0x1B16D91 VA: 0x1B16C90
	|-BuiltinResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1B16D40 Offset: 0x1B16E41 VA: 0x1B16D40
	|-BuiltinResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1B16DF0 Offset: 0x1B16EF1 VA: 0x1B16DF0
	|-BuiltinResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1B16EA0 Offset: 0x1B16FA1 VA: 0x1B16EA0
	|-BuiltinResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1B16F50 Offset: 0x1B17051 VA: 0x1B16F50
	|-BuiltinResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1B17000 Offset: 0x1B17101 VA: 0x1B17000
	|-BuiltinResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1B170B0 Offset: 0x1B171B1 VA: 0x1B170B0
	|-BuiltinResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1B17160 Offset: 0x1B17261 VA: 0x1B17160
	|-BuiltinResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1B17210 Offset: 0x1B17311 VA: 0x1B17210
	|-BuiltinResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1B172C0 Offset: 0x1B173C1 VA: 0x1B172C0
	|-BuiltinResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1B17370 Offset: 0x1B17471 VA: 0x1B17370
	|-BuiltinResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1B17420 Offset: 0x1B17521 VA: 0x1B17420
	|-BuiltinResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1B174D0 Offset: 0x1B175D1 VA: 0x1B174D0
	|-BuiltinResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1B17580 Offset: 0x1B17681 VA: 0x1B17580
	|-BuiltinResolver.GetFormatter<object>
	|
	|-RVA: 0x1B17630 Offset: 0x1B17731 VA: 0x1B17630
	|-BuiltinResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1B176E0 Offset: 0x1B177E1 VA: 0x1B176E0
	|-BuiltinResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1B17790 Offset: 0x1B17891 VA: 0x1B17790
	|-BuiltinResolver.GetFormatter<float>
	|
	|-RVA: 0x1B17840 Offset: 0x1B17941 VA: 0x1B17840
	|-BuiltinResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1B178F0 Offset: 0x1B179F1 VA: 0x1B178F0
	|-BuiltinResolver.GetFormatter<uint>
	|
	|-RVA: 0x1B179A0 Offset: 0x1B17AA1 VA: 0x1B179A0
	|-BuiltinResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1B17A50 Offset: 0x1B17B51 VA: 0x1B17A50
	|-BuiltinResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1B17B00 Offset: 0x1B17C01 VA: 0x1B17B00
	|-BuiltinResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1B17BB0 Offset: 0x1B17CB1 VA: 0x1B17BB0
	|-BuiltinResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1B17C60 Offset: 0x1B17D61 VA: 0x1B17C60
	|-BuiltinResolver.GetFormatter<Color>
	|
	|-RVA: 0x1B17D10 Offset: 0x1B17E11 VA: 0x1B17D10
	|-BuiltinResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1B17DC0 Offset: 0x1B17EC1 VA: 0x1B17DC0
	|-BuiltinResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1B17E70 Offset: 0x1B17F71 VA: 0x1B17E70
	|-BuiltinResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1B17F20 Offset: 0x1B18021 VA: 0x1B17F20
	|-BuiltinResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1B17FD0 Offset: 0x1B180D1 VA: 0x1B17FD0
	|-BuiltinResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1B18080 Offset: 0x1B18181 VA: 0x1B18080
	|-BuiltinResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1B18130 Offset: 0x1B18231 VA: 0x1B18130
	|-BuiltinResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1B181E0 Offset: 0x1B182E1 VA: 0x1B181E0
	|-BuiltinResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1B18290 Offset: 0x1B18391 VA: 0x1B18290
	|-BuiltinResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1B18340 Offset: 0x1B18441 VA: 0x1B18340
	|-BuiltinResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1B183F0 Offset: 0x1B184F1 VA: 0x1B183F0
	|-BuiltinResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1B184A0 Offset: 0x1B185A1 VA: 0x1B184A0
	|-BuiltinResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1B18550 Offset: 0x1B18651 VA: 0x1B18550
	|-BuiltinResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1B18600 Offset: 0x1B18701 VA: 0x1B18600
	|-BuiltinResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F2160 Offset: 0x14F2261 VA: 0x14F2160
	private static void .cctor() { }
}

public sealed class BuiltinResolver : IFormatterResolver // TypeDefIndex: 5226
{
	// Fields
	public static readonly BuiltinResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F2150 Offset: 0x14F2251 VA: 0x14F2150
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B15A00 Offset: 0x1B15B01 VA: 0x1B15A00
	|-BuiltinResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1B15AB0 Offset: 0x1B15BB1 VA: 0x1B15AB0
	|-BuiltinResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1B15B60 Offset: 0x1B15C61 VA: 0x1B15B60
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1B15C10 Offset: 0x1B15D11 VA: 0x1B15C10
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1B15CC0 Offset: 0x1B15DC1 VA: 0x1B15CC0
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1B15D70 Offset: 0x1B15E71 VA: 0x1B15D70
	|-BuiltinResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1B15E20 Offset: 0x1B15F21 VA: 0x1B15E20
	|-BuiltinResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1B15ED0 Offset: 0x1B15FD1 VA: 0x1B15ED0
	|-BuiltinResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1B15F80 Offset: 0x1B16081 VA: 0x1B15F80
	|-BuiltinResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1B16030 Offset: 0x1B16131 VA: 0x1B16030
	|-BuiltinResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1B160E0 Offset: 0x1B161E1 VA: 0x1B160E0
	|-BuiltinResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1B16190 Offset: 0x1B16291 VA: 0x1B16190
	|-BuiltinResolver.GetFormatter<bool>
	|
	|-RVA: 0x1B16240 Offset: 0x1B16341 VA: 0x1B16240
	|-BuiltinResolver.GetFormatter<byte>
	|
	|-RVA: 0x1B162F0 Offset: 0x1B163F1 VA: 0x1B162F0
	|-BuiltinResolver.GetFormatter<char>
	|
	|-RVA: 0x1B163A0 Offset: 0x1B164A1 VA: 0x1B163A0
	|-BuiltinResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1B16450 Offset: 0x1B16551 VA: 0x1B16450
	|-BuiltinResolver.GetFormatter<double>
	|
	|-RVA: 0x1B16500 Offset: 0x1B16601 VA: 0x1B16500
	|-BuiltinResolver.GetFormatter<short>
	|
	|-RVA: 0x1B165B0 Offset: 0x1B166B1 VA: 0x1B165B0
	|-BuiltinResolver.GetFormatter<int>
	|
	|-RVA: 0x1B16660 Offset: 0x1B16761 VA: 0x1B16660
	|-BuiltinResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1B16710 Offset: 0x1B16811 VA: 0x1B16710
	|-BuiltinResolver.GetFormatter<long>
	|
	|-RVA: 0x1B167C0 Offset: 0x1B168C1 VA: 0x1B167C0
	|-BuiltinResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1B16870 Offset: 0x1B16971 VA: 0x1B16870
	|-BuiltinResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1B16920 Offset: 0x1B16A21 VA: 0x1B16920
	|-BuiltinResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1B169D0 Offset: 0x1B16AD1 VA: 0x1B169D0
	|-BuiltinResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1B16A80 Offset: 0x1B16B81 VA: 0x1B16A80
	|-BuiltinResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1B16B30 Offset: 0x1B16C31 VA: 0x1B16B30
	|-BuiltinResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1B16BE0 Offset: 0x1B16CE1 VA: 0x1B16BE0
	|-BuiltinResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1B16C90 Offset: 0x1B16D91 VA: 0x1B16C90
	|-BuiltinResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1B16D40 Offset: 0x1B16E41 VA: 0x1B16D40
	|-BuiltinResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1B16DF0 Offset: 0x1B16EF1 VA: 0x1B16DF0
	|-BuiltinResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1B16EA0 Offset: 0x1B16FA1 VA: 0x1B16EA0
	|-BuiltinResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1B16F50 Offset: 0x1B17051 VA: 0x1B16F50
	|-BuiltinResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1B17000 Offset: 0x1B17101 VA: 0x1B17000
	|-BuiltinResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1B170B0 Offset: 0x1B171B1 VA: 0x1B170B0
	|-BuiltinResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1B17160 Offset: 0x1B17261 VA: 0x1B17160
	|-BuiltinResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1B17210 Offset: 0x1B17311 VA: 0x1B17210
	|-BuiltinResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1B172C0 Offset: 0x1B173C1 VA: 0x1B172C0
	|-BuiltinResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1B17370 Offset: 0x1B17471 VA: 0x1B17370
	|-BuiltinResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1B17420 Offset: 0x1B17521 VA: 0x1B17420
	|-BuiltinResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1B174D0 Offset: 0x1B175D1 VA: 0x1B174D0
	|-BuiltinResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1B17580 Offset: 0x1B17681 VA: 0x1B17580
	|-BuiltinResolver.GetFormatter<object>
	|
	|-RVA: 0x1B17630 Offset: 0x1B17731 VA: 0x1B17630
	|-BuiltinResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1B176E0 Offset: 0x1B177E1 VA: 0x1B176E0
	|-BuiltinResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1B17790 Offset: 0x1B17891 VA: 0x1B17790
	|-BuiltinResolver.GetFormatter<float>
	|
	|-RVA: 0x1B17840 Offset: 0x1B17941 VA: 0x1B17840
	|-BuiltinResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1B178F0 Offset: 0x1B179F1 VA: 0x1B178F0
	|-BuiltinResolver.GetFormatter<uint>
	|
	|-RVA: 0x1B179A0 Offset: 0x1B17AA1 VA: 0x1B179A0
	|-BuiltinResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1B17A50 Offset: 0x1B17B51 VA: 0x1B17A50
	|-BuiltinResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1B17B00 Offset: 0x1B17C01 VA: 0x1B17B00
	|-BuiltinResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1B17BB0 Offset: 0x1B17CB1 VA: 0x1B17BB0
	|-BuiltinResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1B17C60 Offset: 0x1B17D61 VA: 0x1B17C60
	|-BuiltinResolver.GetFormatter<Color>
	|
	|-RVA: 0x1B17D10 Offset: 0x1B17E11 VA: 0x1B17D10
	|-BuiltinResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1B17DC0 Offset: 0x1B17EC1 VA: 0x1B17DC0
	|-BuiltinResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1B17E70 Offset: 0x1B17F71 VA: 0x1B17E70
	|-BuiltinResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1B17F20 Offset: 0x1B18021 VA: 0x1B17F20
	|-BuiltinResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1B17FD0 Offset: 0x1B180D1 VA: 0x1B17FD0
	|-BuiltinResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1B18080 Offset: 0x1B18181 VA: 0x1B18080
	|-BuiltinResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1B18130 Offset: 0x1B18231 VA: 0x1B18130
	|-BuiltinResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1B181E0 Offset: 0x1B182E1 VA: 0x1B181E0
	|-BuiltinResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1B18290 Offset: 0x1B18391 VA: 0x1B18290
	|-BuiltinResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1B18340 Offset: 0x1B18441 VA: 0x1B18340
	|-BuiltinResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1B183F0 Offset: 0x1B184F1 VA: 0x1B183F0
	|-BuiltinResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1B184A0 Offset: 0x1B185A1 VA: 0x1B184A0
	|-BuiltinResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1B18550 Offset: 0x1B18651 VA: 0x1B18550
	|-BuiltinResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1B18600 Offset: 0x1B18701 VA: 0x1B18600
	|-BuiltinResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F2160 Offset: 0x14F2261 VA: 0x14F2160
	private static void .cctor() { }
}

