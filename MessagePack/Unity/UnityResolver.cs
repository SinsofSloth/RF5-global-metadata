public class UnityResolver : IFormatterResolver // TypeDefIndex: 5204
{
	// Fields
	public static readonly UnityResolver Instance; // 0x0

	// Methods

	// RVA: 0x1501370 Offset: 0x1501471 VA: 0x1501370
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x280CF40 Offset: 0x280D041 VA: 0x280CF40
	|-UnityResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x280CFF0 Offset: 0x280D0F1 VA: 0x280CFF0
	|-UnityResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x280D0A0 Offset: 0x280D1A1 VA: 0x280D0A0
	|-UnityResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x280D150 Offset: 0x280D251 VA: 0x280D150
	|-UnityResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x280D200 Offset: 0x280D301 VA: 0x280D200
	|-UnityResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x280D2B0 Offset: 0x280D3B1 VA: 0x280D2B0
	|-UnityResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x280D360 Offset: 0x280D461 VA: 0x280D360
	|-UnityResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x280D410 Offset: 0x280D511 VA: 0x280D410
	|-UnityResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x280D4C0 Offset: 0x280D5C1 VA: 0x280D4C0
	|-UnityResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x280D570 Offset: 0x280D671 VA: 0x280D570
	|-UnityResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x280D620 Offset: 0x280D721 VA: 0x280D620
	|-UnityResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x280D6D0 Offset: 0x280D7D1 VA: 0x280D6D0
	|-UnityResolver.GetFormatter<bool>
	|
	|-RVA: 0x280D780 Offset: 0x280D881 VA: 0x280D780
	|-UnityResolver.GetFormatter<byte>
	|
	|-RVA: 0x280D830 Offset: 0x280D931 VA: 0x280D830
	|-UnityResolver.GetFormatter<char>
	|
	|-RVA: 0x280D8E0 Offset: 0x280D9E1 VA: 0x280D8E0
	|-UnityResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x280D990 Offset: 0x280DA91 VA: 0x280D990
	|-UnityResolver.GetFormatter<double>
	|
	|-RVA: 0x280DA40 Offset: 0x280DB41 VA: 0x280DA40
	|-UnityResolver.GetFormatter<short>
	|
	|-RVA: 0x280DAF0 Offset: 0x280DBF1 VA: 0x280DAF0
	|-UnityResolver.GetFormatter<int>
	|
	|-RVA: 0x280DBA0 Offset: 0x280DCA1 VA: 0x280DBA0
	|-UnityResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x280DC50 Offset: 0x280DD51 VA: 0x280DC50
	|-UnityResolver.GetFormatter<long>
	|
	|-RVA: 0x280DD00 Offset: 0x280DE01 VA: 0x280DD00
	|-UnityResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x280DDB0 Offset: 0x280DEB1 VA: 0x280DDB0
	|-UnityResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x280DE60 Offset: 0x280DF61 VA: 0x280DE60
	|-UnityResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x280DF10 Offset: 0x280E011 VA: 0x280DF10
	|-UnityResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x280DFC0 Offset: 0x280E0C1 VA: 0x280DFC0
	|-UnityResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x280E070 Offset: 0x280E171 VA: 0x280E070
	|-UnityResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x280E120 Offset: 0x280E221 VA: 0x280E120
	|-UnityResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x280E1D0 Offset: 0x280E2D1 VA: 0x280E1D0
	|-UnityResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x280E280 Offset: 0x280E381 VA: 0x280E280
	|-UnityResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x280E330 Offset: 0x280E431 VA: 0x280E330
	|-UnityResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x280E3E0 Offset: 0x280E4E1 VA: 0x280E3E0
	|-UnityResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x280E490 Offset: 0x280E591 VA: 0x280E490
	|-UnityResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x280E540 Offset: 0x280E641 VA: 0x280E540
	|-UnityResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x280E5F0 Offset: 0x280E6F1 VA: 0x280E5F0
	|-UnityResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x280E6A0 Offset: 0x280E7A1 VA: 0x280E6A0
	|-UnityResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x280E750 Offset: 0x280E851 VA: 0x280E750
	|-UnityResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x280E800 Offset: 0x280E901 VA: 0x280E800
	|-UnityResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x280E8B0 Offset: 0x280E9B1 VA: 0x280E8B0
	|-UnityResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x280E960 Offset: 0x280EA61 VA: 0x280E960
	|-UnityResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x280EA10 Offset: 0x280EB11 VA: 0x280EA10
	|-UnityResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x280EAC0 Offset: 0x280EBC1 VA: 0x280EAC0
	|-UnityResolver.GetFormatter<object>
	|
	|-RVA: 0x280EB70 Offset: 0x280EC71 VA: 0x280EB70
	|-UnityResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x280EC20 Offset: 0x280ED21 VA: 0x280EC20
	|-UnityResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x280ECD0 Offset: 0x280EDD1 VA: 0x280ECD0
	|-UnityResolver.GetFormatter<float>
	|
	|-RVA: 0x280ED80 Offset: 0x280EE81 VA: 0x280ED80
	|-UnityResolver.GetFormatter<ushort>
	|
	|-RVA: 0x280EE30 Offset: 0x280EF31 VA: 0x280EE30
	|-UnityResolver.GetFormatter<uint>
	|
	|-RVA: 0x280EEE0 Offset: 0x280EFE1 VA: 0x280EEE0
	|-UnityResolver.GetFormatter<ulong>
	|
	|-RVA: 0x280EF90 Offset: 0x280F091 VA: 0x280EF90
	|-UnityResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x280F040 Offset: 0x280F141 VA: 0x280F040
	|-UnityResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x280F0F0 Offset: 0x280F1F1 VA: 0x280F0F0
	|-UnityResolver.GetFormatter<Color32>
	|
	|-RVA: 0x280F1A0 Offset: 0x280F2A1 VA: 0x280F1A0
	|-UnityResolver.GetFormatter<Color>
	|
	|-RVA: 0x280F250 Offset: 0x280F351 VA: 0x280F250
	|-UnityResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x280F300 Offset: 0x280F401 VA: 0x280F300
	|-UnityResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x280F3B0 Offset: 0x280F4B1 VA: 0x280F3B0
	|-UnityResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x280F460 Offset: 0x280F561 VA: 0x280F460
	|-UnityResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x280F510 Offset: 0x280F611 VA: 0x280F510
	|-UnityResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x280F5C0 Offset: 0x280F6C1 VA: 0x280F5C0
	|-UnityResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x280F670 Offset: 0x280F771 VA: 0x280F670
	|-UnityResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x280F720 Offset: 0x280F821 VA: 0x280F720
	|-UnityResolver.GetFormatter<Rect>
	|
	|-RVA: 0x280F7D0 Offset: 0x280F8D1 VA: 0x280F7D0
	|-UnityResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x280F880 Offset: 0x280F981 VA: 0x280F880
	|-UnityResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x280F930 Offset: 0x280FA31 VA: 0x280F930
	|-UnityResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x280F9E0 Offset: 0x280FAE1 VA: 0x280F9E0
	|-UnityResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x280FA90 Offset: 0x280FB91 VA: 0x280FA90
	|-UnityResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x280FB40 Offset: 0x280FC41 VA: 0x280FB40
	|-UnityResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x1501380 Offset: 0x1501481 VA: 0x1501380
	private static void .cctor() { }
}

