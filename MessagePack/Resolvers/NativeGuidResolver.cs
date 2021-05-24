public sealed class NativeGuidResolver : IFormatterResolver // TypeDefIndex: 5262
{
	// Fields
	public static readonly NativeGuidResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F8A00 Offset: 0x14F8B01 VA: 0x14F8A00
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F9670 Offset: 0x27F9771 VA: 0x27F9670
	|-NativeGuidResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27F9720 Offset: 0x27F9821 VA: 0x27F9720
	|-NativeGuidResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27F97D0 Offset: 0x27F98D1 VA: 0x27F97D0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27F9880 Offset: 0x27F9981 VA: 0x27F9880
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27F9930 Offset: 0x27F9A31 VA: 0x27F9930
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27F99E0 Offset: 0x27F9AE1 VA: 0x27F99E0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27F9A90 Offset: 0x27F9B91 VA: 0x27F9A90
	|-NativeGuidResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27F9B40 Offset: 0x27F9C41 VA: 0x27F9B40
	|-NativeGuidResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27F9BF0 Offset: 0x27F9CF1 VA: 0x27F9BF0
	|-NativeGuidResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27F9CA0 Offset: 0x27F9DA1 VA: 0x27F9CA0
	|-NativeGuidResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27F9D50 Offset: 0x27F9E51 VA: 0x27F9D50
	|-NativeGuidResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27F9E00 Offset: 0x27F9F01 VA: 0x27F9E00
	|-NativeGuidResolver.GetFormatter<bool>
	|
	|-RVA: 0x27F9EB0 Offset: 0x27F9FB1 VA: 0x27F9EB0
	|-NativeGuidResolver.GetFormatter<byte>
	|
	|-RVA: 0x27F9F60 Offset: 0x27FA061 VA: 0x27F9F60
	|-NativeGuidResolver.GetFormatter<char>
	|
	|-RVA: 0x27FA010 Offset: 0x27FA111 VA: 0x27FA010
	|-NativeGuidResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FA0C0 Offset: 0x27FA1C1 VA: 0x27FA0C0
	|-NativeGuidResolver.GetFormatter<double>
	|
	|-RVA: 0x27FA170 Offset: 0x27FA271 VA: 0x27FA170
	|-NativeGuidResolver.GetFormatter<short>
	|
	|-RVA: 0x27FA220 Offset: 0x27FA321 VA: 0x27FA220
	|-NativeGuidResolver.GetFormatter<int>
	|
	|-RVA: 0x27FA2D0 Offset: 0x27FA3D1 VA: 0x27FA2D0
	|-NativeGuidResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FA380 Offset: 0x27FA481 VA: 0x27FA380
	|-NativeGuidResolver.GetFormatter<long>
	|
	|-RVA: 0x27FA430 Offset: 0x27FA531 VA: 0x27FA430
	|-NativeGuidResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FA4E0 Offset: 0x27FA5E1 VA: 0x27FA4E0
	|-NativeGuidResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FA590 Offset: 0x27FA691 VA: 0x27FA590
	|-NativeGuidResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FA640 Offset: 0x27FA741 VA: 0x27FA640
	|-NativeGuidResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FA6F0 Offset: 0x27FA7F1 VA: 0x27FA6F0
	|-NativeGuidResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FA7A0 Offset: 0x27FA8A1 VA: 0x27FA7A0
	|-NativeGuidResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FA850 Offset: 0x27FA951 VA: 0x27FA850
	|-NativeGuidResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FA900 Offset: 0x27FAA01 VA: 0x27FA900
	|-NativeGuidResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FA9B0 Offset: 0x27FAAB1 VA: 0x27FA9B0
	|-NativeGuidResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FAA60 Offset: 0x27FAB61 VA: 0x27FAA60
	|-NativeGuidResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FAB10 Offset: 0x27FAC11 VA: 0x27FAB10
	|-NativeGuidResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FABC0 Offset: 0x27FACC1 VA: 0x27FABC0
	|-NativeGuidResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FAC70 Offset: 0x27FAD71 VA: 0x27FAC70
	|-NativeGuidResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FAD20 Offset: 0x27FAE21 VA: 0x27FAD20
	|-NativeGuidResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FADD0 Offset: 0x27FAED1 VA: 0x27FADD0
	|-NativeGuidResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FAE80 Offset: 0x27FAF81 VA: 0x27FAE80
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FAF30 Offset: 0x27FB031 VA: 0x27FAF30
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FAFE0 Offset: 0x27FB0E1 VA: 0x27FAFE0
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FB090 Offset: 0x27FB191 VA: 0x27FB090
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FB140 Offset: 0x27FB241 VA: 0x27FB140
	|-NativeGuidResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FB1F0 Offset: 0x27FB2F1 VA: 0x27FB1F0
	|-NativeGuidResolver.GetFormatter<object>
	|
	|-RVA: 0x27FB2A0 Offset: 0x27FB3A1 VA: 0x27FB2A0
	|-NativeGuidResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FB350 Offset: 0x27FB451 VA: 0x27FB350
	|-NativeGuidResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FB400 Offset: 0x27FB501 VA: 0x27FB400
	|-NativeGuidResolver.GetFormatter<float>
	|
	|-RVA: 0x27FB4B0 Offset: 0x27FB5B1 VA: 0x27FB4B0
	|-NativeGuidResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FB560 Offset: 0x27FB661 VA: 0x27FB560
	|-NativeGuidResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FB610 Offset: 0x27FB711 VA: 0x27FB610
	|-NativeGuidResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FB6C0 Offset: 0x27FB7C1 VA: 0x27FB6C0
	|-NativeGuidResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FB770 Offset: 0x27FB871 VA: 0x27FB770
	|-NativeGuidResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FB820 Offset: 0x27FB921 VA: 0x27FB820
	|-NativeGuidResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FB8D0 Offset: 0x27FB9D1 VA: 0x27FB8D0
	|-NativeGuidResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FB980 Offset: 0x27FBA81 VA: 0x27FB980
	|-NativeGuidResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FBA30 Offset: 0x27FBB31 VA: 0x27FBA30
	|-NativeGuidResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FBAE0 Offset: 0x27FBBE1 VA: 0x27FBAE0
	|-NativeGuidResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FBB90 Offset: 0x27FBC91 VA: 0x27FBB90
	|-NativeGuidResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FBC40 Offset: 0x27FBD41 VA: 0x27FBC40
	|-NativeGuidResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FBCF0 Offset: 0x27FBDF1 VA: 0x27FBCF0
	|-NativeGuidResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FBDA0 Offset: 0x27FBEA1 VA: 0x27FBDA0
	|-NativeGuidResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FBE50 Offset: 0x27FBF51 VA: 0x27FBE50
	|-NativeGuidResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FBF00 Offset: 0x27FC001 VA: 0x27FBF00
	|-NativeGuidResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FBFB0 Offset: 0x27FC0B1 VA: 0x27FBFB0
	|-NativeGuidResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FC060 Offset: 0x27FC161 VA: 0x27FC060
	|-NativeGuidResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FC110 Offset: 0x27FC211 VA: 0x27FC110
	|-NativeGuidResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FC1C0 Offset: 0x27FC2C1 VA: 0x27FC1C0
	|-NativeGuidResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FC270 Offset: 0x27FC371 VA: 0x27FC270
	|-NativeGuidResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F8A10 Offset: 0x14F8B11 VA: 0x14F8A10
	private static object GetFormatterHelper(Type t) { }

	// RVA: 0x14F8B80 Offset: 0x14F8C81 VA: 0x14F8B80
	private static void .cctor() { }
}

public sealed class NativeGuidResolver : IFormatterResolver // TypeDefIndex: 5262
{
	// Fields
	public static readonly NativeGuidResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F8A00 Offset: 0x14F8B01 VA: 0x14F8A00
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F9670 Offset: 0x27F9771 VA: 0x27F9670
	|-NativeGuidResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27F9720 Offset: 0x27F9821 VA: 0x27F9720
	|-NativeGuidResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27F97D0 Offset: 0x27F98D1 VA: 0x27F97D0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27F9880 Offset: 0x27F9981 VA: 0x27F9880
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27F9930 Offset: 0x27F9A31 VA: 0x27F9930
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27F99E0 Offset: 0x27F9AE1 VA: 0x27F99E0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27F9A90 Offset: 0x27F9B91 VA: 0x27F9A90
	|-NativeGuidResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27F9B40 Offset: 0x27F9C41 VA: 0x27F9B40
	|-NativeGuidResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27F9BF0 Offset: 0x27F9CF1 VA: 0x27F9BF0
	|-NativeGuidResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27F9CA0 Offset: 0x27F9DA1 VA: 0x27F9CA0
	|-NativeGuidResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27F9D50 Offset: 0x27F9E51 VA: 0x27F9D50
	|-NativeGuidResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27F9E00 Offset: 0x27F9F01 VA: 0x27F9E00
	|-NativeGuidResolver.GetFormatter<bool>
	|
	|-RVA: 0x27F9EB0 Offset: 0x27F9FB1 VA: 0x27F9EB0
	|-NativeGuidResolver.GetFormatter<byte>
	|
	|-RVA: 0x27F9F60 Offset: 0x27FA061 VA: 0x27F9F60
	|-NativeGuidResolver.GetFormatter<char>
	|
	|-RVA: 0x27FA010 Offset: 0x27FA111 VA: 0x27FA010
	|-NativeGuidResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FA0C0 Offset: 0x27FA1C1 VA: 0x27FA0C0
	|-NativeGuidResolver.GetFormatter<double>
	|
	|-RVA: 0x27FA170 Offset: 0x27FA271 VA: 0x27FA170
	|-NativeGuidResolver.GetFormatter<short>
	|
	|-RVA: 0x27FA220 Offset: 0x27FA321 VA: 0x27FA220
	|-NativeGuidResolver.GetFormatter<int>
	|
	|-RVA: 0x27FA2D0 Offset: 0x27FA3D1 VA: 0x27FA2D0
	|-NativeGuidResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FA380 Offset: 0x27FA481 VA: 0x27FA380
	|-NativeGuidResolver.GetFormatter<long>
	|
	|-RVA: 0x27FA430 Offset: 0x27FA531 VA: 0x27FA430
	|-NativeGuidResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FA4E0 Offset: 0x27FA5E1 VA: 0x27FA4E0
	|-NativeGuidResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FA590 Offset: 0x27FA691 VA: 0x27FA590
	|-NativeGuidResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FA640 Offset: 0x27FA741 VA: 0x27FA640
	|-NativeGuidResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FA6F0 Offset: 0x27FA7F1 VA: 0x27FA6F0
	|-NativeGuidResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FA7A0 Offset: 0x27FA8A1 VA: 0x27FA7A0
	|-NativeGuidResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FA850 Offset: 0x27FA951 VA: 0x27FA850
	|-NativeGuidResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FA900 Offset: 0x27FAA01 VA: 0x27FA900
	|-NativeGuidResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FA9B0 Offset: 0x27FAAB1 VA: 0x27FA9B0
	|-NativeGuidResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FAA60 Offset: 0x27FAB61 VA: 0x27FAA60
	|-NativeGuidResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FAB10 Offset: 0x27FAC11 VA: 0x27FAB10
	|-NativeGuidResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FABC0 Offset: 0x27FACC1 VA: 0x27FABC0
	|-NativeGuidResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FAC70 Offset: 0x27FAD71 VA: 0x27FAC70
	|-NativeGuidResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FAD20 Offset: 0x27FAE21 VA: 0x27FAD20
	|-NativeGuidResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FADD0 Offset: 0x27FAED1 VA: 0x27FADD0
	|-NativeGuidResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FAE80 Offset: 0x27FAF81 VA: 0x27FAE80
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FAF30 Offset: 0x27FB031 VA: 0x27FAF30
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FAFE0 Offset: 0x27FB0E1 VA: 0x27FAFE0
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FB090 Offset: 0x27FB191 VA: 0x27FB090
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FB140 Offset: 0x27FB241 VA: 0x27FB140
	|-NativeGuidResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FB1F0 Offset: 0x27FB2F1 VA: 0x27FB1F0
	|-NativeGuidResolver.GetFormatter<object>
	|
	|-RVA: 0x27FB2A0 Offset: 0x27FB3A1 VA: 0x27FB2A0
	|-NativeGuidResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FB350 Offset: 0x27FB451 VA: 0x27FB350
	|-NativeGuidResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FB400 Offset: 0x27FB501 VA: 0x27FB400
	|-NativeGuidResolver.GetFormatter<float>
	|
	|-RVA: 0x27FB4B0 Offset: 0x27FB5B1 VA: 0x27FB4B0
	|-NativeGuidResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FB560 Offset: 0x27FB661 VA: 0x27FB560
	|-NativeGuidResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FB610 Offset: 0x27FB711 VA: 0x27FB610
	|-NativeGuidResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FB6C0 Offset: 0x27FB7C1 VA: 0x27FB6C0
	|-NativeGuidResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FB770 Offset: 0x27FB871 VA: 0x27FB770
	|-NativeGuidResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FB820 Offset: 0x27FB921 VA: 0x27FB820
	|-NativeGuidResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FB8D0 Offset: 0x27FB9D1 VA: 0x27FB8D0
	|-NativeGuidResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FB980 Offset: 0x27FBA81 VA: 0x27FB980
	|-NativeGuidResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FBA30 Offset: 0x27FBB31 VA: 0x27FBA30
	|-NativeGuidResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FBAE0 Offset: 0x27FBBE1 VA: 0x27FBAE0
	|-NativeGuidResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FBB90 Offset: 0x27FBC91 VA: 0x27FBB90
	|-NativeGuidResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FBC40 Offset: 0x27FBD41 VA: 0x27FBC40
	|-NativeGuidResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FBCF0 Offset: 0x27FBDF1 VA: 0x27FBCF0
	|-NativeGuidResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FBDA0 Offset: 0x27FBEA1 VA: 0x27FBDA0
	|-NativeGuidResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FBE50 Offset: 0x27FBF51 VA: 0x27FBE50
	|-NativeGuidResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FBF00 Offset: 0x27FC001 VA: 0x27FBF00
	|-NativeGuidResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FBFB0 Offset: 0x27FC0B1 VA: 0x27FBFB0
	|-NativeGuidResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FC060 Offset: 0x27FC161 VA: 0x27FC060
	|-NativeGuidResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FC110 Offset: 0x27FC211 VA: 0x27FC110
	|-NativeGuidResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FC1C0 Offset: 0x27FC2C1 VA: 0x27FC1C0
	|-NativeGuidResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FC270 Offset: 0x27FC371 VA: 0x27FC270
	|-NativeGuidResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F8A10 Offset: 0x14F8B11 VA: 0x14F8A10
	private static object GetFormatterHelper(Type t) { }

	// RVA: 0x14F8B80 Offset: 0x14F8C81 VA: 0x14F8B80
	private static void .cctor() { }
}

public sealed class NativeGuidResolver : IFormatterResolver // TypeDefIndex: 5262
{
	// Fields
	public static readonly NativeGuidResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F8A00 Offset: 0x14F8B01 VA: 0x14F8A00
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F9670 Offset: 0x27F9771 VA: 0x27F9670
	|-NativeGuidResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27F9720 Offset: 0x27F9821 VA: 0x27F9720
	|-NativeGuidResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27F97D0 Offset: 0x27F98D1 VA: 0x27F97D0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27F9880 Offset: 0x27F9981 VA: 0x27F9880
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27F9930 Offset: 0x27F9A31 VA: 0x27F9930
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27F99E0 Offset: 0x27F9AE1 VA: 0x27F99E0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27F9A90 Offset: 0x27F9B91 VA: 0x27F9A90
	|-NativeGuidResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27F9B40 Offset: 0x27F9C41 VA: 0x27F9B40
	|-NativeGuidResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27F9BF0 Offset: 0x27F9CF1 VA: 0x27F9BF0
	|-NativeGuidResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27F9CA0 Offset: 0x27F9DA1 VA: 0x27F9CA0
	|-NativeGuidResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27F9D50 Offset: 0x27F9E51 VA: 0x27F9D50
	|-NativeGuidResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27F9E00 Offset: 0x27F9F01 VA: 0x27F9E00
	|-NativeGuidResolver.GetFormatter<bool>
	|
	|-RVA: 0x27F9EB0 Offset: 0x27F9FB1 VA: 0x27F9EB0
	|-NativeGuidResolver.GetFormatter<byte>
	|
	|-RVA: 0x27F9F60 Offset: 0x27FA061 VA: 0x27F9F60
	|-NativeGuidResolver.GetFormatter<char>
	|
	|-RVA: 0x27FA010 Offset: 0x27FA111 VA: 0x27FA010
	|-NativeGuidResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FA0C0 Offset: 0x27FA1C1 VA: 0x27FA0C0
	|-NativeGuidResolver.GetFormatter<double>
	|
	|-RVA: 0x27FA170 Offset: 0x27FA271 VA: 0x27FA170
	|-NativeGuidResolver.GetFormatter<short>
	|
	|-RVA: 0x27FA220 Offset: 0x27FA321 VA: 0x27FA220
	|-NativeGuidResolver.GetFormatter<int>
	|
	|-RVA: 0x27FA2D0 Offset: 0x27FA3D1 VA: 0x27FA2D0
	|-NativeGuidResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FA380 Offset: 0x27FA481 VA: 0x27FA380
	|-NativeGuidResolver.GetFormatter<long>
	|
	|-RVA: 0x27FA430 Offset: 0x27FA531 VA: 0x27FA430
	|-NativeGuidResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FA4E0 Offset: 0x27FA5E1 VA: 0x27FA4E0
	|-NativeGuidResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FA590 Offset: 0x27FA691 VA: 0x27FA590
	|-NativeGuidResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FA640 Offset: 0x27FA741 VA: 0x27FA640
	|-NativeGuidResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FA6F0 Offset: 0x27FA7F1 VA: 0x27FA6F0
	|-NativeGuidResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FA7A0 Offset: 0x27FA8A1 VA: 0x27FA7A0
	|-NativeGuidResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FA850 Offset: 0x27FA951 VA: 0x27FA850
	|-NativeGuidResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FA900 Offset: 0x27FAA01 VA: 0x27FA900
	|-NativeGuidResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FA9B0 Offset: 0x27FAAB1 VA: 0x27FA9B0
	|-NativeGuidResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FAA60 Offset: 0x27FAB61 VA: 0x27FAA60
	|-NativeGuidResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FAB10 Offset: 0x27FAC11 VA: 0x27FAB10
	|-NativeGuidResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FABC0 Offset: 0x27FACC1 VA: 0x27FABC0
	|-NativeGuidResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FAC70 Offset: 0x27FAD71 VA: 0x27FAC70
	|-NativeGuidResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FAD20 Offset: 0x27FAE21 VA: 0x27FAD20
	|-NativeGuidResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FADD0 Offset: 0x27FAED1 VA: 0x27FADD0
	|-NativeGuidResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FAE80 Offset: 0x27FAF81 VA: 0x27FAE80
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FAF30 Offset: 0x27FB031 VA: 0x27FAF30
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FAFE0 Offset: 0x27FB0E1 VA: 0x27FAFE0
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FB090 Offset: 0x27FB191 VA: 0x27FB090
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FB140 Offset: 0x27FB241 VA: 0x27FB140
	|-NativeGuidResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FB1F0 Offset: 0x27FB2F1 VA: 0x27FB1F0
	|-NativeGuidResolver.GetFormatter<object>
	|
	|-RVA: 0x27FB2A0 Offset: 0x27FB3A1 VA: 0x27FB2A0
	|-NativeGuidResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FB350 Offset: 0x27FB451 VA: 0x27FB350
	|-NativeGuidResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FB400 Offset: 0x27FB501 VA: 0x27FB400
	|-NativeGuidResolver.GetFormatter<float>
	|
	|-RVA: 0x27FB4B0 Offset: 0x27FB5B1 VA: 0x27FB4B0
	|-NativeGuidResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FB560 Offset: 0x27FB661 VA: 0x27FB560
	|-NativeGuidResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FB610 Offset: 0x27FB711 VA: 0x27FB610
	|-NativeGuidResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FB6C0 Offset: 0x27FB7C1 VA: 0x27FB6C0
	|-NativeGuidResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FB770 Offset: 0x27FB871 VA: 0x27FB770
	|-NativeGuidResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FB820 Offset: 0x27FB921 VA: 0x27FB820
	|-NativeGuidResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FB8D0 Offset: 0x27FB9D1 VA: 0x27FB8D0
	|-NativeGuidResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FB980 Offset: 0x27FBA81 VA: 0x27FB980
	|-NativeGuidResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FBA30 Offset: 0x27FBB31 VA: 0x27FBA30
	|-NativeGuidResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FBAE0 Offset: 0x27FBBE1 VA: 0x27FBAE0
	|-NativeGuidResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FBB90 Offset: 0x27FBC91 VA: 0x27FBB90
	|-NativeGuidResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FBC40 Offset: 0x27FBD41 VA: 0x27FBC40
	|-NativeGuidResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FBCF0 Offset: 0x27FBDF1 VA: 0x27FBCF0
	|-NativeGuidResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FBDA0 Offset: 0x27FBEA1 VA: 0x27FBDA0
	|-NativeGuidResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FBE50 Offset: 0x27FBF51 VA: 0x27FBE50
	|-NativeGuidResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FBF00 Offset: 0x27FC001 VA: 0x27FBF00
	|-NativeGuidResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FBFB0 Offset: 0x27FC0B1 VA: 0x27FBFB0
	|-NativeGuidResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FC060 Offset: 0x27FC161 VA: 0x27FC060
	|-NativeGuidResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FC110 Offset: 0x27FC211 VA: 0x27FC110
	|-NativeGuidResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FC1C0 Offset: 0x27FC2C1 VA: 0x27FC1C0
	|-NativeGuidResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FC270 Offset: 0x27FC371 VA: 0x27FC270
	|-NativeGuidResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F8A10 Offset: 0x14F8B11 VA: 0x14F8A10
	private static object GetFormatterHelper(Type t) { }

	// RVA: 0x14F8B80 Offset: 0x14F8C81 VA: 0x14F8B80
	private static void .cctor() { }
}

public sealed class NativeGuidResolver : IFormatterResolver // TypeDefIndex: 5262
{
	// Fields
	public static readonly NativeGuidResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F8A00 Offset: 0x14F8B01 VA: 0x14F8A00
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F9670 Offset: 0x27F9771 VA: 0x27F9670
	|-NativeGuidResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27F9720 Offset: 0x27F9821 VA: 0x27F9720
	|-NativeGuidResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27F97D0 Offset: 0x27F98D1 VA: 0x27F97D0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27F9880 Offset: 0x27F9981 VA: 0x27F9880
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27F9930 Offset: 0x27F9A31 VA: 0x27F9930
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27F99E0 Offset: 0x27F9AE1 VA: 0x27F99E0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27F9A90 Offset: 0x27F9B91 VA: 0x27F9A90
	|-NativeGuidResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27F9B40 Offset: 0x27F9C41 VA: 0x27F9B40
	|-NativeGuidResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27F9BF0 Offset: 0x27F9CF1 VA: 0x27F9BF0
	|-NativeGuidResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27F9CA0 Offset: 0x27F9DA1 VA: 0x27F9CA0
	|-NativeGuidResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27F9D50 Offset: 0x27F9E51 VA: 0x27F9D50
	|-NativeGuidResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27F9E00 Offset: 0x27F9F01 VA: 0x27F9E00
	|-NativeGuidResolver.GetFormatter<bool>
	|
	|-RVA: 0x27F9EB0 Offset: 0x27F9FB1 VA: 0x27F9EB0
	|-NativeGuidResolver.GetFormatter<byte>
	|
	|-RVA: 0x27F9F60 Offset: 0x27FA061 VA: 0x27F9F60
	|-NativeGuidResolver.GetFormatter<char>
	|
	|-RVA: 0x27FA010 Offset: 0x27FA111 VA: 0x27FA010
	|-NativeGuidResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FA0C0 Offset: 0x27FA1C1 VA: 0x27FA0C0
	|-NativeGuidResolver.GetFormatter<double>
	|
	|-RVA: 0x27FA170 Offset: 0x27FA271 VA: 0x27FA170
	|-NativeGuidResolver.GetFormatter<short>
	|
	|-RVA: 0x27FA220 Offset: 0x27FA321 VA: 0x27FA220
	|-NativeGuidResolver.GetFormatter<int>
	|
	|-RVA: 0x27FA2D0 Offset: 0x27FA3D1 VA: 0x27FA2D0
	|-NativeGuidResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FA380 Offset: 0x27FA481 VA: 0x27FA380
	|-NativeGuidResolver.GetFormatter<long>
	|
	|-RVA: 0x27FA430 Offset: 0x27FA531 VA: 0x27FA430
	|-NativeGuidResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FA4E0 Offset: 0x27FA5E1 VA: 0x27FA4E0
	|-NativeGuidResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FA590 Offset: 0x27FA691 VA: 0x27FA590
	|-NativeGuidResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FA640 Offset: 0x27FA741 VA: 0x27FA640
	|-NativeGuidResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FA6F0 Offset: 0x27FA7F1 VA: 0x27FA6F0
	|-NativeGuidResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FA7A0 Offset: 0x27FA8A1 VA: 0x27FA7A0
	|-NativeGuidResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FA850 Offset: 0x27FA951 VA: 0x27FA850
	|-NativeGuidResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FA900 Offset: 0x27FAA01 VA: 0x27FA900
	|-NativeGuidResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FA9B0 Offset: 0x27FAAB1 VA: 0x27FA9B0
	|-NativeGuidResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FAA60 Offset: 0x27FAB61 VA: 0x27FAA60
	|-NativeGuidResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FAB10 Offset: 0x27FAC11 VA: 0x27FAB10
	|-NativeGuidResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FABC0 Offset: 0x27FACC1 VA: 0x27FABC0
	|-NativeGuidResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FAC70 Offset: 0x27FAD71 VA: 0x27FAC70
	|-NativeGuidResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FAD20 Offset: 0x27FAE21 VA: 0x27FAD20
	|-NativeGuidResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FADD0 Offset: 0x27FAED1 VA: 0x27FADD0
	|-NativeGuidResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FAE80 Offset: 0x27FAF81 VA: 0x27FAE80
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FAF30 Offset: 0x27FB031 VA: 0x27FAF30
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FAFE0 Offset: 0x27FB0E1 VA: 0x27FAFE0
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FB090 Offset: 0x27FB191 VA: 0x27FB090
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FB140 Offset: 0x27FB241 VA: 0x27FB140
	|-NativeGuidResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FB1F0 Offset: 0x27FB2F1 VA: 0x27FB1F0
	|-NativeGuidResolver.GetFormatter<object>
	|
	|-RVA: 0x27FB2A0 Offset: 0x27FB3A1 VA: 0x27FB2A0
	|-NativeGuidResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FB350 Offset: 0x27FB451 VA: 0x27FB350
	|-NativeGuidResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FB400 Offset: 0x27FB501 VA: 0x27FB400
	|-NativeGuidResolver.GetFormatter<float>
	|
	|-RVA: 0x27FB4B0 Offset: 0x27FB5B1 VA: 0x27FB4B0
	|-NativeGuidResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FB560 Offset: 0x27FB661 VA: 0x27FB560
	|-NativeGuidResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FB610 Offset: 0x27FB711 VA: 0x27FB610
	|-NativeGuidResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FB6C0 Offset: 0x27FB7C1 VA: 0x27FB6C0
	|-NativeGuidResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FB770 Offset: 0x27FB871 VA: 0x27FB770
	|-NativeGuidResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FB820 Offset: 0x27FB921 VA: 0x27FB820
	|-NativeGuidResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FB8D0 Offset: 0x27FB9D1 VA: 0x27FB8D0
	|-NativeGuidResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FB980 Offset: 0x27FBA81 VA: 0x27FB980
	|-NativeGuidResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FBA30 Offset: 0x27FBB31 VA: 0x27FBA30
	|-NativeGuidResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FBAE0 Offset: 0x27FBBE1 VA: 0x27FBAE0
	|-NativeGuidResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FBB90 Offset: 0x27FBC91 VA: 0x27FBB90
	|-NativeGuidResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FBC40 Offset: 0x27FBD41 VA: 0x27FBC40
	|-NativeGuidResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FBCF0 Offset: 0x27FBDF1 VA: 0x27FBCF0
	|-NativeGuidResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FBDA0 Offset: 0x27FBEA1 VA: 0x27FBDA0
	|-NativeGuidResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FBE50 Offset: 0x27FBF51 VA: 0x27FBE50
	|-NativeGuidResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FBF00 Offset: 0x27FC001 VA: 0x27FBF00
	|-NativeGuidResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FBFB0 Offset: 0x27FC0B1 VA: 0x27FBFB0
	|-NativeGuidResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FC060 Offset: 0x27FC161 VA: 0x27FC060
	|-NativeGuidResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FC110 Offset: 0x27FC211 VA: 0x27FC110
	|-NativeGuidResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FC1C0 Offset: 0x27FC2C1 VA: 0x27FC1C0
	|-NativeGuidResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FC270 Offset: 0x27FC371 VA: 0x27FC270
	|-NativeGuidResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F8A10 Offset: 0x14F8B11 VA: 0x14F8A10
	private static object GetFormatterHelper(Type t) { }

	// RVA: 0x14F8B80 Offset: 0x14F8C81 VA: 0x14F8B80
	private static void .cctor() { }
}

public sealed class NativeGuidResolver : IFormatterResolver // TypeDefIndex: 5262
{
	// Fields
	public static readonly NativeGuidResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F8A00 Offset: 0x14F8B01 VA: 0x14F8A00
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F9670 Offset: 0x27F9771 VA: 0x27F9670
	|-NativeGuidResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x27F9720 Offset: 0x27F9821 VA: 0x27F9720
	|-NativeGuidResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x27F97D0 Offset: 0x27F98D1 VA: 0x27F97D0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x27F9880 Offset: 0x27F9981 VA: 0x27F9880
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x27F9930 Offset: 0x27F9A31 VA: 0x27F9930
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x27F99E0 Offset: 0x27F9AE1 VA: 0x27F99E0
	|-NativeGuidResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x27F9A90 Offset: 0x27F9B91 VA: 0x27F9A90
	|-NativeGuidResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x27F9B40 Offset: 0x27F9C41 VA: 0x27F9B40
	|-NativeGuidResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x27F9BF0 Offset: 0x27F9CF1 VA: 0x27F9BF0
	|-NativeGuidResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x27F9CA0 Offset: 0x27F9DA1 VA: 0x27F9CA0
	|-NativeGuidResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x27F9D50 Offset: 0x27F9E51 VA: 0x27F9D50
	|-NativeGuidResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x27F9E00 Offset: 0x27F9F01 VA: 0x27F9E00
	|-NativeGuidResolver.GetFormatter<bool>
	|
	|-RVA: 0x27F9EB0 Offset: 0x27F9FB1 VA: 0x27F9EB0
	|-NativeGuidResolver.GetFormatter<byte>
	|
	|-RVA: 0x27F9F60 Offset: 0x27FA061 VA: 0x27F9F60
	|-NativeGuidResolver.GetFormatter<char>
	|
	|-RVA: 0x27FA010 Offset: 0x27FA111 VA: 0x27FA010
	|-NativeGuidResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x27FA0C0 Offset: 0x27FA1C1 VA: 0x27FA0C0
	|-NativeGuidResolver.GetFormatter<double>
	|
	|-RVA: 0x27FA170 Offset: 0x27FA271 VA: 0x27FA170
	|-NativeGuidResolver.GetFormatter<short>
	|
	|-RVA: 0x27FA220 Offset: 0x27FA321 VA: 0x27FA220
	|-NativeGuidResolver.GetFormatter<int>
	|
	|-RVA: 0x27FA2D0 Offset: 0x27FA3D1 VA: 0x27FA2D0
	|-NativeGuidResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x27FA380 Offset: 0x27FA481 VA: 0x27FA380
	|-NativeGuidResolver.GetFormatter<long>
	|
	|-RVA: 0x27FA430 Offset: 0x27FA531 VA: 0x27FA430
	|-NativeGuidResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x27FA4E0 Offset: 0x27FA5E1 VA: 0x27FA4E0
	|-NativeGuidResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x27FA590 Offset: 0x27FA691 VA: 0x27FA590
	|-NativeGuidResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x27FA640 Offset: 0x27FA741 VA: 0x27FA640
	|-NativeGuidResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x27FA6F0 Offset: 0x27FA7F1 VA: 0x27FA6F0
	|-NativeGuidResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x27FA7A0 Offset: 0x27FA8A1 VA: 0x27FA7A0
	|-NativeGuidResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x27FA850 Offset: 0x27FA951 VA: 0x27FA850
	|-NativeGuidResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27FA900 Offset: 0x27FAA01 VA: 0x27FA900
	|-NativeGuidResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27FA9B0 Offset: 0x27FAAB1 VA: 0x27FA9B0
	|-NativeGuidResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x27FAA60 Offset: 0x27FAB61 VA: 0x27FAA60
	|-NativeGuidResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x27FAB10 Offset: 0x27FAC11 VA: 0x27FAB10
	|-NativeGuidResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27FABC0 Offset: 0x27FACC1 VA: 0x27FABC0
	|-NativeGuidResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x27FAC70 Offset: 0x27FAD71 VA: 0x27FAC70
	|-NativeGuidResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x27FAD20 Offset: 0x27FAE21 VA: 0x27FAD20
	|-NativeGuidResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x27FADD0 Offset: 0x27FAED1 VA: 0x27FADD0
	|-NativeGuidResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x27FAE80 Offset: 0x27FAF81 VA: 0x27FAE80
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x27FAF30 Offset: 0x27FB031 VA: 0x27FAF30
	|-NativeGuidResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x27FAFE0 Offset: 0x27FB0E1 VA: 0x27FAFE0
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x27FB090 Offset: 0x27FB191 VA: 0x27FB090
	|-NativeGuidResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x27FB140 Offset: 0x27FB241 VA: 0x27FB140
	|-NativeGuidResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x27FB1F0 Offset: 0x27FB2F1 VA: 0x27FB1F0
	|-NativeGuidResolver.GetFormatter<object>
	|
	|-RVA: 0x27FB2A0 Offset: 0x27FB3A1 VA: 0x27FB2A0
	|-NativeGuidResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27FB350 Offset: 0x27FB451 VA: 0x27FB350
	|-NativeGuidResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x27FB400 Offset: 0x27FB501 VA: 0x27FB400
	|-NativeGuidResolver.GetFormatter<float>
	|
	|-RVA: 0x27FB4B0 Offset: 0x27FB5B1 VA: 0x27FB4B0
	|-NativeGuidResolver.GetFormatter<ushort>
	|
	|-RVA: 0x27FB560 Offset: 0x27FB661 VA: 0x27FB560
	|-NativeGuidResolver.GetFormatter<uint>
	|
	|-RVA: 0x27FB610 Offset: 0x27FB711 VA: 0x27FB610
	|-NativeGuidResolver.GetFormatter<ulong>
	|
	|-RVA: 0x27FB6C0 Offset: 0x27FB7C1 VA: 0x27FB6C0
	|-NativeGuidResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x27FB770 Offset: 0x27FB871 VA: 0x27FB770
	|-NativeGuidResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x27FB820 Offset: 0x27FB921 VA: 0x27FB820
	|-NativeGuidResolver.GetFormatter<Color32>
	|
	|-RVA: 0x27FB8D0 Offset: 0x27FB9D1 VA: 0x27FB8D0
	|-NativeGuidResolver.GetFormatter<Color>
	|
	|-RVA: 0x27FB980 Offset: 0x27FBA81 VA: 0x27FB980
	|-NativeGuidResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27FBA30 Offset: 0x27FBB31 VA: 0x27FBA30
	|-NativeGuidResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27FBAE0 Offset: 0x27FBBE1 VA: 0x27FBAE0
	|-NativeGuidResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27FBB90 Offset: 0x27FBC91 VA: 0x27FBB90
	|-NativeGuidResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27FBC40 Offset: 0x27FBD41 VA: 0x27FBC40
	|-NativeGuidResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27FBCF0 Offset: 0x27FBDF1 VA: 0x27FBCF0
	|-NativeGuidResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27FBDA0 Offset: 0x27FBEA1 VA: 0x27FBDA0
	|-NativeGuidResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27FBE50 Offset: 0x27FBF51 VA: 0x27FBE50
	|-NativeGuidResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27FBF00 Offset: 0x27FC001 VA: 0x27FBF00
	|-NativeGuidResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27FBFB0 Offset: 0x27FC0B1 VA: 0x27FBFB0
	|-NativeGuidResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27FC060 Offset: 0x27FC161 VA: 0x27FC060
	|-NativeGuidResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27FC110 Offset: 0x27FC211 VA: 0x27FC110
	|-NativeGuidResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27FC1C0 Offset: 0x27FC2C1 VA: 0x27FC1C0
	|-NativeGuidResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27FC270 Offset: 0x27FC371 VA: 0x27FC270
	|-NativeGuidResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F8A10 Offset: 0x14F8B11 VA: 0x14F8A10
	private static object GetFormatterHelper(Type t) { }

	// RVA: 0x14F8B80 Offset: 0x14F8C81 VA: 0x14F8B80
	private static void .cctor() { }
}

