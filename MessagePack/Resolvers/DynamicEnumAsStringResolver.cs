public sealed class DynamicEnumAsStringResolver : IFormatterResolver // TypeDefIndex: 5231
{
	// Fields
	public static readonly DynamicEnumAsStringResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F2C60 Offset: 0x14F2D61 VA: 0x14F2C60
	private static void .cctor() { }

	// RVA: 0x14F2D10 Offset: 0x14F2E11 VA: 0x14F2D10
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181C380 Offset: 0x181C481 VA: 0x181C380
	|-DynamicEnumAsStringResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x181C430 Offset: 0x181C531 VA: 0x181C430
	|-DynamicEnumAsStringResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x181C4E0 Offset: 0x181C5E1 VA: 0x181C4E0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x181C590 Offset: 0x181C691 VA: 0x181C590
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x181C640 Offset: 0x181C741 VA: 0x181C640
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x181C6F0 Offset: 0x181C7F1 VA: 0x181C6F0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x181C7A0 Offset: 0x181C8A1 VA: 0x181C7A0
	|-DynamicEnumAsStringResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x181C850 Offset: 0x181C951 VA: 0x181C850
	|-DynamicEnumAsStringResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x181C900 Offset: 0x181CA01 VA: 0x181C900
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x181C9B0 Offset: 0x181CAB1 VA: 0x181C9B0
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x181CA60 Offset: 0x181CB61 VA: 0x181CA60
	|-DynamicEnumAsStringResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x181CB10 Offset: 0x181CC11 VA: 0x181CB10
	|-DynamicEnumAsStringResolver.GetFormatter<bool>
	|
	|-RVA: 0x181CBC0 Offset: 0x181CCC1 VA: 0x181CBC0
	|-DynamicEnumAsStringResolver.GetFormatter<byte>
	|
	|-RVA: 0x181CC70 Offset: 0x181CD71 VA: 0x181CC70
	|-DynamicEnumAsStringResolver.GetFormatter<char>
	|
	|-RVA: 0x181CD20 Offset: 0x181CE21 VA: 0x181CD20
	|-DynamicEnumAsStringResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x181CDD0 Offset: 0x181CED1 VA: 0x181CDD0
	|-DynamicEnumAsStringResolver.GetFormatter<double>
	|
	|-RVA: 0x181CE80 Offset: 0x181CF81 VA: 0x181CE80
	|-DynamicEnumAsStringResolver.GetFormatter<short>
	|
	|-RVA: 0x181CF30 Offset: 0x181D031 VA: 0x181CF30
	|-DynamicEnumAsStringResolver.GetFormatter<int>
	|
	|-RVA: 0x181CFE0 Offset: 0x181D0E1 VA: 0x181CFE0
	|-DynamicEnumAsStringResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x181D090 Offset: 0x181D191 VA: 0x181D090
	|-DynamicEnumAsStringResolver.GetFormatter<long>
	|
	|-RVA: 0x181D140 Offset: 0x181D241 VA: 0x181D140
	|-DynamicEnumAsStringResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x181D1F0 Offset: 0x181D2F1 VA: 0x181D1F0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x181D2A0 Offset: 0x181D3A1 VA: 0x181D2A0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x181D350 Offset: 0x181D451 VA: 0x181D350
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x181D400 Offset: 0x181D501 VA: 0x181D400
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x181D4B0 Offset: 0x181D5B1 VA: 0x181D4B0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x181D560 Offset: 0x181D661 VA: 0x181D560
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x181D610 Offset: 0x181D711 VA: 0x181D610
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x181D6C0 Offset: 0x181D7C1 VA: 0x181D6C0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x181D770 Offset: 0x181D871 VA: 0x181D770
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x181D820 Offset: 0x181D921 VA: 0x181D820
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x181D8D0 Offset: 0x181D9D1 VA: 0x181D8D0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x181D980 Offset: 0x181DA81 VA: 0x181D980
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x181DA30 Offset: 0x181DB31 VA: 0x181DA30
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x181DAE0 Offset: 0x181DBE1 VA: 0x181DAE0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x181DB90 Offset: 0x181DC91 VA: 0x181DB90
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x181DC40 Offset: 0x181DD41 VA: 0x181DC40
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x181DCF0 Offset: 0x181DDF1 VA: 0x181DCF0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x181DDA0 Offset: 0x181DEA1 VA: 0x181DDA0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x181DE50 Offset: 0x181DF51 VA: 0x181DE50
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x181DF00 Offset: 0x181E001 VA: 0x181DF00
	|-DynamicEnumAsStringResolver.GetFormatter<object>
	|
	|-RVA: 0x181DFB0 Offset: 0x181E0B1 VA: 0x181DFB0
	|-DynamicEnumAsStringResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x181E060 Offset: 0x181E161 VA: 0x181E060
	|-DynamicEnumAsStringResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x181E110 Offset: 0x181E211 VA: 0x181E110
	|-DynamicEnumAsStringResolver.GetFormatter<float>
	|
	|-RVA: 0x181E1C0 Offset: 0x181E2C1 VA: 0x181E1C0
	|-DynamicEnumAsStringResolver.GetFormatter<ushort>
	|
	|-RVA: 0x181E270 Offset: 0x181E371 VA: 0x181E270
	|-DynamicEnumAsStringResolver.GetFormatter<uint>
	|
	|-RVA: 0x181E320 Offset: 0x181E421 VA: 0x181E320
	|-DynamicEnumAsStringResolver.GetFormatter<ulong>
	|
	|-RVA: 0x181E3D0 Offset: 0x181E4D1 VA: 0x181E3D0
	|-DynamicEnumAsStringResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x181E480 Offset: 0x181E581 VA: 0x181E480
	|-DynamicEnumAsStringResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x181E530 Offset: 0x181E631 VA: 0x181E530
	|-DynamicEnumAsStringResolver.GetFormatter<Color32>
	|
	|-RVA: 0x181E5E0 Offset: 0x181E6E1 VA: 0x181E5E0
	|-DynamicEnumAsStringResolver.GetFormatter<Color>
	|
	|-RVA: 0x181E690 Offset: 0x181E791 VA: 0x181E690
	|-DynamicEnumAsStringResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x181E740 Offset: 0x181E841 VA: 0x181E740
	|-DynamicEnumAsStringResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x181E7F0 Offset: 0x181E8F1 VA: 0x181E7F0
	|-DynamicEnumAsStringResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x181E8A0 Offset: 0x181E9A1 VA: 0x181E8A0
	|-DynamicEnumAsStringResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x181E950 Offset: 0x181EA51 VA: 0x181E950
	|-DynamicEnumAsStringResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x181EA00 Offset: 0x181EB01 VA: 0x181EA00
	|-DynamicEnumAsStringResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x181EAB0 Offset: 0x181EBB1 VA: 0x181EAB0
	|-DynamicEnumAsStringResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x181EB60 Offset: 0x181EC61 VA: 0x181EB60
	|-DynamicEnumAsStringResolver.GetFormatter<Rect>
	|
	|-RVA: 0x181EC10 Offset: 0x181ED11 VA: 0x181EC10
	|-DynamicEnumAsStringResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x181ECC0 Offset: 0x181EDC1 VA: 0x181ECC0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x181ED70 Offset: 0x181EE71 VA: 0x181ED70
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x181EE20 Offset: 0x181EF21 VA: 0x181EE20
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x181EED0 Offset: 0x181EFD1 VA: 0x181EED0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x181EF80 Offset: 0x181F081 VA: 0x181EF80
	|-DynamicEnumAsStringResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicEnumAsStringResolver : IFormatterResolver // TypeDefIndex: 5231
{
	// Fields
	public static readonly DynamicEnumAsStringResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F2C60 Offset: 0x14F2D61 VA: 0x14F2C60
	private static void .cctor() { }

	// RVA: 0x14F2D10 Offset: 0x14F2E11 VA: 0x14F2D10
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181C380 Offset: 0x181C481 VA: 0x181C380
	|-DynamicEnumAsStringResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x181C430 Offset: 0x181C531 VA: 0x181C430
	|-DynamicEnumAsStringResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x181C4E0 Offset: 0x181C5E1 VA: 0x181C4E0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x181C590 Offset: 0x181C691 VA: 0x181C590
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x181C640 Offset: 0x181C741 VA: 0x181C640
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x181C6F0 Offset: 0x181C7F1 VA: 0x181C6F0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x181C7A0 Offset: 0x181C8A1 VA: 0x181C7A0
	|-DynamicEnumAsStringResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x181C850 Offset: 0x181C951 VA: 0x181C850
	|-DynamicEnumAsStringResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x181C900 Offset: 0x181CA01 VA: 0x181C900
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x181C9B0 Offset: 0x181CAB1 VA: 0x181C9B0
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x181CA60 Offset: 0x181CB61 VA: 0x181CA60
	|-DynamicEnumAsStringResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x181CB10 Offset: 0x181CC11 VA: 0x181CB10
	|-DynamicEnumAsStringResolver.GetFormatter<bool>
	|
	|-RVA: 0x181CBC0 Offset: 0x181CCC1 VA: 0x181CBC0
	|-DynamicEnumAsStringResolver.GetFormatter<byte>
	|
	|-RVA: 0x181CC70 Offset: 0x181CD71 VA: 0x181CC70
	|-DynamicEnumAsStringResolver.GetFormatter<char>
	|
	|-RVA: 0x181CD20 Offset: 0x181CE21 VA: 0x181CD20
	|-DynamicEnumAsStringResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x181CDD0 Offset: 0x181CED1 VA: 0x181CDD0
	|-DynamicEnumAsStringResolver.GetFormatter<double>
	|
	|-RVA: 0x181CE80 Offset: 0x181CF81 VA: 0x181CE80
	|-DynamicEnumAsStringResolver.GetFormatter<short>
	|
	|-RVA: 0x181CF30 Offset: 0x181D031 VA: 0x181CF30
	|-DynamicEnumAsStringResolver.GetFormatter<int>
	|
	|-RVA: 0x181CFE0 Offset: 0x181D0E1 VA: 0x181CFE0
	|-DynamicEnumAsStringResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x181D090 Offset: 0x181D191 VA: 0x181D090
	|-DynamicEnumAsStringResolver.GetFormatter<long>
	|
	|-RVA: 0x181D140 Offset: 0x181D241 VA: 0x181D140
	|-DynamicEnumAsStringResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x181D1F0 Offset: 0x181D2F1 VA: 0x181D1F0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x181D2A0 Offset: 0x181D3A1 VA: 0x181D2A0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x181D350 Offset: 0x181D451 VA: 0x181D350
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x181D400 Offset: 0x181D501 VA: 0x181D400
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x181D4B0 Offset: 0x181D5B1 VA: 0x181D4B0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x181D560 Offset: 0x181D661 VA: 0x181D560
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x181D610 Offset: 0x181D711 VA: 0x181D610
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x181D6C0 Offset: 0x181D7C1 VA: 0x181D6C0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x181D770 Offset: 0x181D871 VA: 0x181D770
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x181D820 Offset: 0x181D921 VA: 0x181D820
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x181D8D0 Offset: 0x181D9D1 VA: 0x181D8D0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x181D980 Offset: 0x181DA81 VA: 0x181D980
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x181DA30 Offset: 0x181DB31 VA: 0x181DA30
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x181DAE0 Offset: 0x181DBE1 VA: 0x181DAE0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x181DB90 Offset: 0x181DC91 VA: 0x181DB90
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x181DC40 Offset: 0x181DD41 VA: 0x181DC40
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x181DCF0 Offset: 0x181DDF1 VA: 0x181DCF0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x181DDA0 Offset: 0x181DEA1 VA: 0x181DDA0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x181DE50 Offset: 0x181DF51 VA: 0x181DE50
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x181DF00 Offset: 0x181E001 VA: 0x181DF00
	|-DynamicEnumAsStringResolver.GetFormatter<object>
	|
	|-RVA: 0x181DFB0 Offset: 0x181E0B1 VA: 0x181DFB0
	|-DynamicEnumAsStringResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x181E060 Offset: 0x181E161 VA: 0x181E060
	|-DynamicEnumAsStringResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x181E110 Offset: 0x181E211 VA: 0x181E110
	|-DynamicEnumAsStringResolver.GetFormatter<float>
	|
	|-RVA: 0x181E1C0 Offset: 0x181E2C1 VA: 0x181E1C0
	|-DynamicEnumAsStringResolver.GetFormatter<ushort>
	|
	|-RVA: 0x181E270 Offset: 0x181E371 VA: 0x181E270
	|-DynamicEnumAsStringResolver.GetFormatter<uint>
	|
	|-RVA: 0x181E320 Offset: 0x181E421 VA: 0x181E320
	|-DynamicEnumAsStringResolver.GetFormatter<ulong>
	|
	|-RVA: 0x181E3D0 Offset: 0x181E4D1 VA: 0x181E3D0
	|-DynamicEnumAsStringResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x181E480 Offset: 0x181E581 VA: 0x181E480
	|-DynamicEnumAsStringResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x181E530 Offset: 0x181E631 VA: 0x181E530
	|-DynamicEnumAsStringResolver.GetFormatter<Color32>
	|
	|-RVA: 0x181E5E0 Offset: 0x181E6E1 VA: 0x181E5E0
	|-DynamicEnumAsStringResolver.GetFormatter<Color>
	|
	|-RVA: 0x181E690 Offset: 0x181E791 VA: 0x181E690
	|-DynamicEnumAsStringResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x181E740 Offset: 0x181E841 VA: 0x181E740
	|-DynamicEnumAsStringResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x181E7F0 Offset: 0x181E8F1 VA: 0x181E7F0
	|-DynamicEnumAsStringResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x181E8A0 Offset: 0x181E9A1 VA: 0x181E8A0
	|-DynamicEnumAsStringResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x181E950 Offset: 0x181EA51 VA: 0x181E950
	|-DynamicEnumAsStringResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x181EA00 Offset: 0x181EB01 VA: 0x181EA00
	|-DynamicEnumAsStringResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x181EAB0 Offset: 0x181EBB1 VA: 0x181EAB0
	|-DynamicEnumAsStringResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x181EB60 Offset: 0x181EC61 VA: 0x181EB60
	|-DynamicEnumAsStringResolver.GetFormatter<Rect>
	|
	|-RVA: 0x181EC10 Offset: 0x181ED11 VA: 0x181EC10
	|-DynamicEnumAsStringResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x181ECC0 Offset: 0x181EDC1 VA: 0x181ECC0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x181ED70 Offset: 0x181EE71 VA: 0x181ED70
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x181EE20 Offset: 0x181EF21 VA: 0x181EE20
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x181EED0 Offset: 0x181EFD1 VA: 0x181EED0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x181EF80 Offset: 0x181F081 VA: 0x181EF80
	|-DynamicEnumAsStringResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicEnumAsStringResolver : IFormatterResolver // TypeDefIndex: 5231
{
	// Fields
	public static readonly DynamicEnumAsStringResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F2C60 Offset: 0x14F2D61 VA: 0x14F2C60
	private static void .cctor() { }

	// RVA: 0x14F2D10 Offset: 0x14F2E11 VA: 0x14F2D10
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181C380 Offset: 0x181C481 VA: 0x181C380
	|-DynamicEnumAsStringResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x181C430 Offset: 0x181C531 VA: 0x181C430
	|-DynamicEnumAsStringResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x181C4E0 Offset: 0x181C5E1 VA: 0x181C4E0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x181C590 Offset: 0x181C691 VA: 0x181C590
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x181C640 Offset: 0x181C741 VA: 0x181C640
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x181C6F0 Offset: 0x181C7F1 VA: 0x181C6F0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x181C7A0 Offset: 0x181C8A1 VA: 0x181C7A0
	|-DynamicEnumAsStringResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x181C850 Offset: 0x181C951 VA: 0x181C850
	|-DynamicEnumAsStringResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x181C900 Offset: 0x181CA01 VA: 0x181C900
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x181C9B0 Offset: 0x181CAB1 VA: 0x181C9B0
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x181CA60 Offset: 0x181CB61 VA: 0x181CA60
	|-DynamicEnumAsStringResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x181CB10 Offset: 0x181CC11 VA: 0x181CB10
	|-DynamicEnumAsStringResolver.GetFormatter<bool>
	|
	|-RVA: 0x181CBC0 Offset: 0x181CCC1 VA: 0x181CBC0
	|-DynamicEnumAsStringResolver.GetFormatter<byte>
	|
	|-RVA: 0x181CC70 Offset: 0x181CD71 VA: 0x181CC70
	|-DynamicEnumAsStringResolver.GetFormatter<char>
	|
	|-RVA: 0x181CD20 Offset: 0x181CE21 VA: 0x181CD20
	|-DynamicEnumAsStringResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x181CDD0 Offset: 0x181CED1 VA: 0x181CDD0
	|-DynamicEnumAsStringResolver.GetFormatter<double>
	|
	|-RVA: 0x181CE80 Offset: 0x181CF81 VA: 0x181CE80
	|-DynamicEnumAsStringResolver.GetFormatter<short>
	|
	|-RVA: 0x181CF30 Offset: 0x181D031 VA: 0x181CF30
	|-DynamicEnumAsStringResolver.GetFormatter<int>
	|
	|-RVA: 0x181CFE0 Offset: 0x181D0E1 VA: 0x181CFE0
	|-DynamicEnumAsStringResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x181D090 Offset: 0x181D191 VA: 0x181D090
	|-DynamicEnumAsStringResolver.GetFormatter<long>
	|
	|-RVA: 0x181D140 Offset: 0x181D241 VA: 0x181D140
	|-DynamicEnumAsStringResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x181D1F0 Offset: 0x181D2F1 VA: 0x181D1F0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x181D2A0 Offset: 0x181D3A1 VA: 0x181D2A0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x181D350 Offset: 0x181D451 VA: 0x181D350
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x181D400 Offset: 0x181D501 VA: 0x181D400
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x181D4B0 Offset: 0x181D5B1 VA: 0x181D4B0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x181D560 Offset: 0x181D661 VA: 0x181D560
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x181D610 Offset: 0x181D711 VA: 0x181D610
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x181D6C0 Offset: 0x181D7C1 VA: 0x181D6C0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x181D770 Offset: 0x181D871 VA: 0x181D770
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x181D820 Offset: 0x181D921 VA: 0x181D820
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x181D8D0 Offset: 0x181D9D1 VA: 0x181D8D0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x181D980 Offset: 0x181DA81 VA: 0x181D980
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x181DA30 Offset: 0x181DB31 VA: 0x181DA30
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x181DAE0 Offset: 0x181DBE1 VA: 0x181DAE0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x181DB90 Offset: 0x181DC91 VA: 0x181DB90
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x181DC40 Offset: 0x181DD41 VA: 0x181DC40
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x181DCF0 Offset: 0x181DDF1 VA: 0x181DCF0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x181DDA0 Offset: 0x181DEA1 VA: 0x181DDA0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x181DE50 Offset: 0x181DF51 VA: 0x181DE50
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x181DF00 Offset: 0x181E001 VA: 0x181DF00
	|-DynamicEnumAsStringResolver.GetFormatter<object>
	|
	|-RVA: 0x181DFB0 Offset: 0x181E0B1 VA: 0x181DFB0
	|-DynamicEnumAsStringResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x181E060 Offset: 0x181E161 VA: 0x181E060
	|-DynamicEnumAsStringResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x181E110 Offset: 0x181E211 VA: 0x181E110
	|-DynamicEnumAsStringResolver.GetFormatter<float>
	|
	|-RVA: 0x181E1C0 Offset: 0x181E2C1 VA: 0x181E1C0
	|-DynamicEnumAsStringResolver.GetFormatter<ushort>
	|
	|-RVA: 0x181E270 Offset: 0x181E371 VA: 0x181E270
	|-DynamicEnumAsStringResolver.GetFormatter<uint>
	|
	|-RVA: 0x181E320 Offset: 0x181E421 VA: 0x181E320
	|-DynamicEnumAsStringResolver.GetFormatter<ulong>
	|
	|-RVA: 0x181E3D0 Offset: 0x181E4D1 VA: 0x181E3D0
	|-DynamicEnumAsStringResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x181E480 Offset: 0x181E581 VA: 0x181E480
	|-DynamicEnumAsStringResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x181E530 Offset: 0x181E631 VA: 0x181E530
	|-DynamicEnumAsStringResolver.GetFormatter<Color32>
	|
	|-RVA: 0x181E5E0 Offset: 0x181E6E1 VA: 0x181E5E0
	|-DynamicEnumAsStringResolver.GetFormatter<Color>
	|
	|-RVA: 0x181E690 Offset: 0x181E791 VA: 0x181E690
	|-DynamicEnumAsStringResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x181E740 Offset: 0x181E841 VA: 0x181E740
	|-DynamicEnumAsStringResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x181E7F0 Offset: 0x181E8F1 VA: 0x181E7F0
	|-DynamicEnumAsStringResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x181E8A0 Offset: 0x181E9A1 VA: 0x181E8A0
	|-DynamicEnumAsStringResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x181E950 Offset: 0x181EA51 VA: 0x181E950
	|-DynamicEnumAsStringResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x181EA00 Offset: 0x181EB01 VA: 0x181EA00
	|-DynamicEnumAsStringResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x181EAB0 Offset: 0x181EBB1 VA: 0x181EAB0
	|-DynamicEnumAsStringResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x181EB60 Offset: 0x181EC61 VA: 0x181EB60
	|-DynamicEnumAsStringResolver.GetFormatter<Rect>
	|
	|-RVA: 0x181EC10 Offset: 0x181ED11 VA: 0x181EC10
	|-DynamicEnumAsStringResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x181ECC0 Offset: 0x181EDC1 VA: 0x181ECC0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x181ED70 Offset: 0x181EE71 VA: 0x181ED70
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x181EE20 Offset: 0x181EF21 VA: 0x181EE20
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x181EED0 Offset: 0x181EFD1 VA: 0x181EED0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x181EF80 Offset: 0x181F081 VA: 0x181EF80
	|-DynamicEnumAsStringResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicEnumAsStringResolver : IFormatterResolver // TypeDefIndex: 5231
{
	// Fields
	public static readonly DynamicEnumAsStringResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F2C60 Offset: 0x14F2D61 VA: 0x14F2C60
	private static void .cctor() { }

	// RVA: 0x14F2D10 Offset: 0x14F2E11 VA: 0x14F2D10
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181C380 Offset: 0x181C481 VA: 0x181C380
	|-DynamicEnumAsStringResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x181C430 Offset: 0x181C531 VA: 0x181C430
	|-DynamicEnumAsStringResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x181C4E0 Offset: 0x181C5E1 VA: 0x181C4E0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x181C590 Offset: 0x181C691 VA: 0x181C590
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x181C640 Offset: 0x181C741 VA: 0x181C640
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x181C6F0 Offset: 0x181C7F1 VA: 0x181C6F0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x181C7A0 Offset: 0x181C8A1 VA: 0x181C7A0
	|-DynamicEnumAsStringResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x181C850 Offset: 0x181C951 VA: 0x181C850
	|-DynamicEnumAsStringResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x181C900 Offset: 0x181CA01 VA: 0x181C900
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x181C9B0 Offset: 0x181CAB1 VA: 0x181C9B0
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x181CA60 Offset: 0x181CB61 VA: 0x181CA60
	|-DynamicEnumAsStringResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x181CB10 Offset: 0x181CC11 VA: 0x181CB10
	|-DynamicEnumAsStringResolver.GetFormatter<bool>
	|
	|-RVA: 0x181CBC0 Offset: 0x181CCC1 VA: 0x181CBC0
	|-DynamicEnumAsStringResolver.GetFormatter<byte>
	|
	|-RVA: 0x181CC70 Offset: 0x181CD71 VA: 0x181CC70
	|-DynamicEnumAsStringResolver.GetFormatter<char>
	|
	|-RVA: 0x181CD20 Offset: 0x181CE21 VA: 0x181CD20
	|-DynamicEnumAsStringResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x181CDD0 Offset: 0x181CED1 VA: 0x181CDD0
	|-DynamicEnumAsStringResolver.GetFormatter<double>
	|
	|-RVA: 0x181CE80 Offset: 0x181CF81 VA: 0x181CE80
	|-DynamicEnumAsStringResolver.GetFormatter<short>
	|
	|-RVA: 0x181CF30 Offset: 0x181D031 VA: 0x181CF30
	|-DynamicEnumAsStringResolver.GetFormatter<int>
	|
	|-RVA: 0x181CFE0 Offset: 0x181D0E1 VA: 0x181CFE0
	|-DynamicEnumAsStringResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x181D090 Offset: 0x181D191 VA: 0x181D090
	|-DynamicEnumAsStringResolver.GetFormatter<long>
	|
	|-RVA: 0x181D140 Offset: 0x181D241 VA: 0x181D140
	|-DynamicEnumAsStringResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x181D1F0 Offset: 0x181D2F1 VA: 0x181D1F0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x181D2A0 Offset: 0x181D3A1 VA: 0x181D2A0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x181D350 Offset: 0x181D451 VA: 0x181D350
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x181D400 Offset: 0x181D501 VA: 0x181D400
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x181D4B0 Offset: 0x181D5B1 VA: 0x181D4B0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x181D560 Offset: 0x181D661 VA: 0x181D560
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x181D610 Offset: 0x181D711 VA: 0x181D610
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x181D6C0 Offset: 0x181D7C1 VA: 0x181D6C0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x181D770 Offset: 0x181D871 VA: 0x181D770
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x181D820 Offset: 0x181D921 VA: 0x181D820
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x181D8D0 Offset: 0x181D9D1 VA: 0x181D8D0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x181D980 Offset: 0x181DA81 VA: 0x181D980
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x181DA30 Offset: 0x181DB31 VA: 0x181DA30
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x181DAE0 Offset: 0x181DBE1 VA: 0x181DAE0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x181DB90 Offset: 0x181DC91 VA: 0x181DB90
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x181DC40 Offset: 0x181DD41 VA: 0x181DC40
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x181DCF0 Offset: 0x181DDF1 VA: 0x181DCF0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x181DDA0 Offset: 0x181DEA1 VA: 0x181DDA0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x181DE50 Offset: 0x181DF51 VA: 0x181DE50
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x181DF00 Offset: 0x181E001 VA: 0x181DF00
	|-DynamicEnumAsStringResolver.GetFormatter<object>
	|
	|-RVA: 0x181DFB0 Offset: 0x181E0B1 VA: 0x181DFB0
	|-DynamicEnumAsStringResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x181E060 Offset: 0x181E161 VA: 0x181E060
	|-DynamicEnumAsStringResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x181E110 Offset: 0x181E211 VA: 0x181E110
	|-DynamicEnumAsStringResolver.GetFormatter<float>
	|
	|-RVA: 0x181E1C0 Offset: 0x181E2C1 VA: 0x181E1C0
	|-DynamicEnumAsStringResolver.GetFormatter<ushort>
	|
	|-RVA: 0x181E270 Offset: 0x181E371 VA: 0x181E270
	|-DynamicEnumAsStringResolver.GetFormatter<uint>
	|
	|-RVA: 0x181E320 Offset: 0x181E421 VA: 0x181E320
	|-DynamicEnumAsStringResolver.GetFormatter<ulong>
	|
	|-RVA: 0x181E3D0 Offset: 0x181E4D1 VA: 0x181E3D0
	|-DynamicEnumAsStringResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x181E480 Offset: 0x181E581 VA: 0x181E480
	|-DynamicEnumAsStringResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x181E530 Offset: 0x181E631 VA: 0x181E530
	|-DynamicEnumAsStringResolver.GetFormatter<Color32>
	|
	|-RVA: 0x181E5E0 Offset: 0x181E6E1 VA: 0x181E5E0
	|-DynamicEnumAsStringResolver.GetFormatter<Color>
	|
	|-RVA: 0x181E690 Offset: 0x181E791 VA: 0x181E690
	|-DynamicEnumAsStringResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x181E740 Offset: 0x181E841 VA: 0x181E740
	|-DynamicEnumAsStringResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x181E7F0 Offset: 0x181E8F1 VA: 0x181E7F0
	|-DynamicEnumAsStringResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x181E8A0 Offset: 0x181E9A1 VA: 0x181E8A0
	|-DynamicEnumAsStringResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x181E950 Offset: 0x181EA51 VA: 0x181E950
	|-DynamicEnumAsStringResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x181EA00 Offset: 0x181EB01 VA: 0x181EA00
	|-DynamicEnumAsStringResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x181EAB0 Offset: 0x181EBB1 VA: 0x181EAB0
	|-DynamicEnumAsStringResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x181EB60 Offset: 0x181EC61 VA: 0x181EB60
	|-DynamicEnumAsStringResolver.GetFormatter<Rect>
	|
	|-RVA: 0x181EC10 Offset: 0x181ED11 VA: 0x181EC10
	|-DynamicEnumAsStringResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x181ECC0 Offset: 0x181EDC1 VA: 0x181ECC0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x181ED70 Offset: 0x181EE71 VA: 0x181ED70
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x181EE20 Offset: 0x181EF21 VA: 0x181EE20
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x181EED0 Offset: 0x181EFD1 VA: 0x181EED0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x181EF80 Offset: 0x181F081 VA: 0x181EF80
	|-DynamicEnumAsStringResolver.GetFormatter<Vector4>
	*/
}

public sealed class DynamicEnumAsStringResolver : IFormatterResolver // TypeDefIndex: 5231
{
	// Fields
	public static readonly DynamicEnumAsStringResolver Instance; // 0x0
	public static readonly MessagePackSerializerOptions Options; // 0x8

	// Methods

	// RVA: 0x14F2C60 Offset: 0x14F2D61 VA: 0x14F2C60
	private static void .cctor() { }

	// RVA: 0x14F2D10 Offset: 0x14F2E11 VA: 0x14F2D10
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181C380 Offset: 0x181C481 VA: 0x181C380
	|-DynamicEnumAsStringResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x181C430 Offset: 0x181C531 VA: 0x181C430
	|-DynamicEnumAsStringResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x181C4E0 Offset: 0x181C5E1 VA: 0x181C4E0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x181C590 Offset: 0x181C691 VA: 0x181C590
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x181C640 Offset: 0x181C741 VA: 0x181C640
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x181C6F0 Offset: 0x181C7F1 VA: 0x181C6F0
	|-DynamicEnumAsStringResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x181C7A0 Offset: 0x181C8A1 VA: 0x181C7A0
	|-DynamicEnumAsStringResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x181C850 Offset: 0x181C951 VA: 0x181C850
	|-DynamicEnumAsStringResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x181C900 Offset: 0x181CA01 VA: 0x181C900
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x181C9B0 Offset: 0x181CAB1 VA: 0x181C9B0
	|-DynamicEnumAsStringResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x181CA60 Offset: 0x181CB61 VA: 0x181CA60
	|-DynamicEnumAsStringResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x181CB10 Offset: 0x181CC11 VA: 0x181CB10
	|-DynamicEnumAsStringResolver.GetFormatter<bool>
	|
	|-RVA: 0x181CBC0 Offset: 0x181CCC1 VA: 0x181CBC0
	|-DynamicEnumAsStringResolver.GetFormatter<byte>
	|
	|-RVA: 0x181CC70 Offset: 0x181CD71 VA: 0x181CC70
	|-DynamicEnumAsStringResolver.GetFormatter<char>
	|
	|-RVA: 0x181CD20 Offset: 0x181CE21 VA: 0x181CD20
	|-DynamicEnumAsStringResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x181CDD0 Offset: 0x181CED1 VA: 0x181CDD0
	|-DynamicEnumAsStringResolver.GetFormatter<double>
	|
	|-RVA: 0x181CE80 Offset: 0x181CF81 VA: 0x181CE80
	|-DynamicEnumAsStringResolver.GetFormatter<short>
	|
	|-RVA: 0x181CF30 Offset: 0x181D031 VA: 0x181CF30
	|-DynamicEnumAsStringResolver.GetFormatter<int>
	|
	|-RVA: 0x181CFE0 Offset: 0x181D0E1 VA: 0x181CFE0
	|-DynamicEnumAsStringResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x181D090 Offset: 0x181D191 VA: 0x181D090
	|-DynamicEnumAsStringResolver.GetFormatter<long>
	|
	|-RVA: 0x181D140 Offset: 0x181D241 VA: 0x181D140
	|-DynamicEnumAsStringResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x181D1F0 Offset: 0x181D2F1 VA: 0x181D1F0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x181D2A0 Offset: 0x181D3A1 VA: 0x181D2A0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x181D350 Offset: 0x181D451 VA: 0x181D350
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x181D400 Offset: 0x181D501 VA: 0x181D400
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x181D4B0 Offset: 0x181D5B1 VA: 0x181D4B0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x181D560 Offset: 0x181D661 VA: 0x181D560
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x181D610 Offset: 0x181D711 VA: 0x181D610
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x181D6C0 Offset: 0x181D7C1 VA: 0x181D6C0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x181D770 Offset: 0x181D871 VA: 0x181D770
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x181D820 Offset: 0x181D921 VA: 0x181D820
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x181D8D0 Offset: 0x181D9D1 VA: 0x181D8D0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x181D980 Offset: 0x181DA81 VA: 0x181D980
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x181DA30 Offset: 0x181DB31 VA: 0x181DA30
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x181DAE0 Offset: 0x181DBE1 VA: 0x181DAE0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x181DB90 Offset: 0x181DC91 VA: 0x181DB90
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x181DC40 Offset: 0x181DD41 VA: 0x181DC40
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x181DCF0 Offset: 0x181DDF1 VA: 0x181DCF0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x181DDA0 Offset: 0x181DEA1 VA: 0x181DDA0
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x181DE50 Offset: 0x181DF51 VA: 0x181DE50
	|-DynamicEnumAsStringResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x181DF00 Offset: 0x181E001 VA: 0x181DF00
	|-DynamicEnumAsStringResolver.GetFormatter<object>
	|
	|-RVA: 0x181DFB0 Offset: 0x181E0B1 VA: 0x181DFB0
	|-DynamicEnumAsStringResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x181E060 Offset: 0x181E161 VA: 0x181E060
	|-DynamicEnumAsStringResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x181E110 Offset: 0x181E211 VA: 0x181E110
	|-DynamicEnumAsStringResolver.GetFormatter<float>
	|
	|-RVA: 0x181E1C0 Offset: 0x181E2C1 VA: 0x181E1C0
	|-DynamicEnumAsStringResolver.GetFormatter<ushort>
	|
	|-RVA: 0x181E270 Offset: 0x181E371 VA: 0x181E270
	|-DynamicEnumAsStringResolver.GetFormatter<uint>
	|
	|-RVA: 0x181E320 Offset: 0x181E421 VA: 0x181E320
	|-DynamicEnumAsStringResolver.GetFormatter<ulong>
	|
	|-RVA: 0x181E3D0 Offset: 0x181E4D1 VA: 0x181E3D0
	|-DynamicEnumAsStringResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x181E480 Offset: 0x181E581 VA: 0x181E480
	|-DynamicEnumAsStringResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x181E530 Offset: 0x181E631 VA: 0x181E530
	|-DynamicEnumAsStringResolver.GetFormatter<Color32>
	|
	|-RVA: 0x181E5E0 Offset: 0x181E6E1 VA: 0x181E5E0
	|-DynamicEnumAsStringResolver.GetFormatter<Color>
	|
	|-RVA: 0x181E690 Offset: 0x181E791 VA: 0x181E690
	|-DynamicEnumAsStringResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x181E740 Offset: 0x181E841 VA: 0x181E740
	|-DynamicEnumAsStringResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x181E7F0 Offset: 0x181E8F1 VA: 0x181E7F0
	|-DynamicEnumAsStringResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x181E8A0 Offset: 0x181E9A1 VA: 0x181E8A0
	|-DynamicEnumAsStringResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x181E950 Offset: 0x181EA51 VA: 0x181E950
	|-DynamicEnumAsStringResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x181EA00 Offset: 0x181EB01 VA: 0x181EA00
	|-DynamicEnumAsStringResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x181EAB0 Offset: 0x181EBB1 VA: 0x181EAB0
	|-DynamicEnumAsStringResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x181EB60 Offset: 0x181EC61 VA: 0x181EB60
	|-DynamicEnumAsStringResolver.GetFormatter<Rect>
	|
	|-RVA: 0x181EC10 Offset: 0x181ED11 VA: 0x181EC10
	|-DynamicEnumAsStringResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x181ECC0 Offset: 0x181EDC1 VA: 0x181ECC0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x181ED70 Offset: 0x181EE71 VA: 0x181ED70
	|-DynamicEnumAsStringResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x181EE20 Offset: 0x181EF21 VA: 0x181EE20
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x181EED0 Offset: 0x181EFD1 VA: 0x181EED0
	|-DynamicEnumAsStringResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x181EF80 Offset: 0x181F081 VA: 0x181EF80
	|-DynamicEnumAsStringResolver.GetFormatter<Vector4>
	*/
}

