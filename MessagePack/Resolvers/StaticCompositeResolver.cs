public class StaticCompositeResolver : IFormatterResolver // TypeDefIndex: 5274
{
	// Fields
	public static readonly StaticCompositeResolver Instance; // 0x0
	private bool freezed; // 0x10
	private IReadOnlyList<IMessagePackFormatter> formatters; // 0x18
	private IReadOnlyList<IFormatterResolver> resolvers; // 0x20

	// Methods

	// RVA: 0x14F8F30 Offset: 0x14F9031 VA: 0x14F8F30
	private void .ctor() { }

	// RVA: 0x14F90E0 Offset: 0x14F91E1 VA: 0x14F90E0
	public void Register(IMessagePackFormatter[] formatters) { }

	// RVA: 0x14F9260 Offset: 0x14F9361 VA: 0x14F9260
	public void Register(IFormatterResolver[] resolvers) { }

	// RVA: 0x14F93E0 Offset: 0x14F94E1 VA: 0x14F93E0
	public void Register(IReadOnlyList<IMessagePackFormatter> formatters, IReadOnlyList<IFormatterResolver> resolvers) { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2804930 Offset: 0x2804A31 VA: 0x2804930
	|-StaticCompositeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x28049E0 Offset: 0x2804AE1 VA: 0x28049E0
	|-StaticCompositeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2804A90 Offset: 0x2804B91 VA: 0x2804A90
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2804B40 Offset: 0x2804C41 VA: 0x2804B40
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2804BF0 Offset: 0x2804CF1 VA: 0x2804BF0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2804CA0 Offset: 0x2804DA1 VA: 0x2804CA0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x2804D50 Offset: 0x2804E51 VA: 0x2804D50
	|-StaticCompositeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2804E00 Offset: 0x2804F01 VA: 0x2804E00
	|-StaticCompositeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2804EB0 Offset: 0x2804FB1 VA: 0x2804EB0
	|-StaticCompositeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x2804F60 Offset: 0x2805061 VA: 0x2804F60
	|-StaticCompositeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2805010 Offset: 0x2805111 VA: 0x2805010
	|-StaticCompositeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x28050C0 Offset: 0x28051C1 VA: 0x28050C0
	|-StaticCompositeResolver.GetFormatter<bool>
	|
	|-RVA: 0x2805170 Offset: 0x2805271 VA: 0x2805170
	|-StaticCompositeResolver.GetFormatter<byte>
	|
	|-RVA: 0x2805220 Offset: 0x2805321 VA: 0x2805220
	|-StaticCompositeResolver.GetFormatter<char>
	|
	|-RVA: 0x28052D0 Offset: 0x28053D1 VA: 0x28052D0
	|-StaticCompositeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x2805380 Offset: 0x2805481 VA: 0x2805380
	|-StaticCompositeResolver.GetFormatter<double>
	|
	|-RVA: 0x2805430 Offset: 0x2805531 VA: 0x2805430
	|-StaticCompositeResolver.GetFormatter<short>
	|
	|-RVA: 0x28054E0 Offset: 0x28055E1 VA: 0x28054E0
	|-StaticCompositeResolver.GetFormatter<int>
	|
	|-RVA: 0x2805590 Offset: 0x2805691 VA: 0x2805590
	|-StaticCompositeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2805640 Offset: 0x2805741 VA: 0x2805640
	|-StaticCompositeResolver.GetFormatter<long>
	|
	|-RVA: 0x28056F0 Offset: 0x28057F1 VA: 0x28056F0
	|-StaticCompositeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x28057A0 Offset: 0x28058A1 VA: 0x28057A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2805850 Offset: 0x2805951 VA: 0x2805850
	|-StaticCompositeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2805900 Offset: 0x2805A01 VA: 0x2805900
	|-StaticCompositeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x28059B0 Offset: 0x2805AB1 VA: 0x28059B0
	|-StaticCompositeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2805A60 Offset: 0x2805B61 VA: 0x2805A60
	|-StaticCompositeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2805B10 Offset: 0x2805C11 VA: 0x2805B10
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2805BC0 Offset: 0x2805CC1 VA: 0x2805BC0
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2805C70 Offset: 0x2805D71 VA: 0x2805C70
	|-StaticCompositeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2805D20 Offset: 0x2805E21 VA: 0x2805D20
	|-StaticCompositeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2805DD0 Offset: 0x2805ED1 VA: 0x2805DD0
	|-StaticCompositeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2805E80 Offset: 0x2805F81 VA: 0x2805E80
	|-StaticCompositeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2805F30 Offset: 0x2806031 VA: 0x2805F30
	|-StaticCompositeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2805FE0 Offset: 0x28060E1 VA: 0x2805FE0
	|-StaticCompositeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x2806090 Offset: 0x2806191 VA: 0x2806090
	|-StaticCompositeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2806140 Offset: 0x2806241 VA: 0x2806140
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x28061F0 Offset: 0x28062F1 VA: 0x28061F0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28062A0 Offset: 0x28063A1 VA: 0x28062A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x2806350 Offset: 0x2806451 VA: 0x2806350
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2806400 Offset: 0x2806501 VA: 0x2806400
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x28064B0 Offset: 0x28065B1 VA: 0x28064B0
	|-StaticCompositeResolver.GetFormatter<object>
	|
	|-RVA: 0x2806560 Offset: 0x2806661 VA: 0x2806560
	|-StaticCompositeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2806610 Offset: 0x2806711 VA: 0x2806610
	|-StaticCompositeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x28066C0 Offset: 0x28067C1 VA: 0x28066C0
	|-StaticCompositeResolver.GetFormatter<float>
	|
	|-RVA: 0x2806770 Offset: 0x2806871 VA: 0x2806770
	|-StaticCompositeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x2806820 Offset: 0x2806921 VA: 0x2806820
	|-StaticCompositeResolver.GetFormatter<uint>
	|
	|-RVA: 0x28068D0 Offset: 0x28069D1 VA: 0x28068D0
	|-StaticCompositeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x2806980 Offset: 0x2806A81 VA: 0x2806980
	|-StaticCompositeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x2806A30 Offset: 0x2806B31 VA: 0x2806A30
	|-StaticCompositeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2806AE0 Offset: 0x2806BE1 VA: 0x2806AE0
	|-StaticCompositeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x2806B90 Offset: 0x2806C91 VA: 0x2806B90
	|-StaticCompositeResolver.GetFormatter<Color>
	|
	|-RVA: 0x2806C40 Offset: 0x2806D41 VA: 0x2806C40
	|-StaticCompositeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2806CF0 Offset: 0x2806DF1 VA: 0x2806CF0
	|-StaticCompositeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x2806DA0 Offset: 0x2806EA1 VA: 0x2806DA0
	|-StaticCompositeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x2806E50 Offset: 0x2806F51 VA: 0x2806E50
	|-StaticCompositeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x2806F00 Offset: 0x2807001 VA: 0x2806F00
	|-StaticCompositeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2806FB0 Offset: 0x28070B1 VA: 0x2806FB0
	|-StaticCompositeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x2807060 Offset: 0x2807161 VA: 0x2807060
	|-StaticCompositeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x2807110 Offset: 0x2807211 VA: 0x2807110
	|-StaticCompositeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x28071C0 Offset: 0x28072C1 VA: 0x28071C0
	|-StaticCompositeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x2807270 Offset: 0x2807371 VA: 0x2807270
	|-StaticCompositeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x2807320 Offset: 0x2807421 VA: 0x2807320
	|-StaticCompositeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x28073D0 Offset: 0x28074D1 VA: 0x28073D0
	|-StaticCompositeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x2807480 Offset: 0x2807581 VA: 0x2807480
	|-StaticCompositeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2807530 Offset: 0x2807631 VA: 0x2807530
	|-StaticCompositeResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F94E0 Offset: 0x14F95E1 VA: 0x14F94E0
	private static void .cctor() { }
}

public class StaticCompositeResolver : IFormatterResolver // TypeDefIndex: 5274
{
	// Fields
	public static readonly StaticCompositeResolver Instance; // 0x0
	private bool freezed; // 0x10
	private IReadOnlyList<IMessagePackFormatter> formatters; // 0x18
	private IReadOnlyList<IFormatterResolver> resolvers; // 0x20

	// Methods

	// RVA: 0x14F8F30 Offset: 0x14F9031 VA: 0x14F8F30
	private void .ctor() { }

	// RVA: 0x14F90E0 Offset: 0x14F91E1 VA: 0x14F90E0
	public void Register(IMessagePackFormatter[] formatters) { }

	// RVA: 0x14F9260 Offset: 0x14F9361 VA: 0x14F9260
	public void Register(IFormatterResolver[] resolvers) { }

	// RVA: 0x14F93E0 Offset: 0x14F94E1 VA: 0x14F93E0
	public void Register(IReadOnlyList<IMessagePackFormatter> formatters, IReadOnlyList<IFormatterResolver> resolvers) { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2804930 Offset: 0x2804A31 VA: 0x2804930
	|-StaticCompositeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x28049E0 Offset: 0x2804AE1 VA: 0x28049E0
	|-StaticCompositeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2804A90 Offset: 0x2804B91 VA: 0x2804A90
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2804B40 Offset: 0x2804C41 VA: 0x2804B40
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2804BF0 Offset: 0x2804CF1 VA: 0x2804BF0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2804CA0 Offset: 0x2804DA1 VA: 0x2804CA0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x2804D50 Offset: 0x2804E51 VA: 0x2804D50
	|-StaticCompositeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2804E00 Offset: 0x2804F01 VA: 0x2804E00
	|-StaticCompositeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2804EB0 Offset: 0x2804FB1 VA: 0x2804EB0
	|-StaticCompositeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x2804F60 Offset: 0x2805061 VA: 0x2804F60
	|-StaticCompositeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2805010 Offset: 0x2805111 VA: 0x2805010
	|-StaticCompositeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x28050C0 Offset: 0x28051C1 VA: 0x28050C0
	|-StaticCompositeResolver.GetFormatter<bool>
	|
	|-RVA: 0x2805170 Offset: 0x2805271 VA: 0x2805170
	|-StaticCompositeResolver.GetFormatter<byte>
	|
	|-RVA: 0x2805220 Offset: 0x2805321 VA: 0x2805220
	|-StaticCompositeResolver.GetFormatter<char>
	|
	|-RVA: 0x28052D0 Offset: 0x28053D1 VA: 0x28052D0
	|-StaticCompositeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x2805380 Offset: 0x2805481 VA: 0x2805380
	|-StaticCompositeResolver.GetFormatter<double>
	|
	|-RVA: 0x2805430 Offset: 0x2805531 VA: 0x2805430
	|-StaticCompositeResolver.GetFormatter<short>
	|
	|-RVA: 0x28054E0 Offset: 0x28055E1 VA: 0x28054E0
	|-StaticCompositeResolver.GetFormatter<int>
	|
	|-RVA: 0x2805590 Offset: 0x2805691 VA: 0x2805590
	|-StaticCompositeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2805640 Offset: 0x2805741 VA: 0x2805640
	|-StaticCompositeResolver.GetFormatter<long>
	|
	|-RVA: 0x28056F0 Offset: 0x28057F1 VA: 0x28056F0
	|-StaticCompositeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x28057A0 Offset: 0x28058A1 VA: 0x28057A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2805850 Offset: 0x2805951 VA: 0x2805850
	|-StaticCompositeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2805900 Offset: 0x2805A01 VA: 0x2805900
	|-StaticCompositeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x28059B0 Offset: 0x2805AB1 VA: 0x28059B0
	|-StaticCompositeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2805A60 Offset: 0x2805B61 VA: 0x2805A60
	|-StaticCompositeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2805B10 Offset: 0x2805C11 VA: 0x2805B10
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2805BC0 Offset: 0x2805CC1 VA: 0x2805BC0
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2805C70 Offset: 0x2805D71 VA: 0x2805C70
	|-StaticCompositeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2805D20 Offset: 0x2805E21 VA: 0x2805D20
	|-StaticCompositeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2805DD0 Offset: 0x2805ED1 VA: 0x2805DD0
	|-StaticCompositeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2805E80 Offset: 0x2805F81 VA: 0x2805E80
	|-StaticCompositeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2805F30 Offset: 0x2806031 VA: 0x2805F30
	|-StaticCompositeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2805FE0 Offset: 0x28060E1 VA: 0x2805FE0
	|-StaticCompositeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x2806090 Offset: 0x2806191 VA: 0x2806090
	|-StaticCompositeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2806140 Offset: 0x2806241 VA: 0x2806140
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x28061F0 Offset: 0x28062F1 VA: 0x28061F0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28062A0 Offset: 0x28063A1 VA: 0x28062A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x2806350 Offset: 0x2806451 VA: 0x2806350
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2806400 Offset: 0x2806501 VA: 0x2806400
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x28064B0 Offset: 0x28065B1 VA: 0x28064B0
	|-StaticCompositeResolver.GetFormatter<object>
	|
	|-RVA: 0x2806560 Offset: 0x2806661 VA: 0x2806560
	|-StaticCompositeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2806610 Offset: 0x2806711 VA: 0x2806610
	|-StaticCompositeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x28066C0 Offset: 0x28067C1 VA: 0x28066C0
	|-StaticCompositeResolver.GetFormatter<float>
	|
	|-RVA: 0x2806770 Offset: 0x2806871 VA: 0x2806770
	|-StaticCompositeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x2806820 Offset: 0x2806921 VA: 0x2806820
	|-StaticCompositeResolver.GetFormatter<uint>
	|
	|-RVA: 0x28068D0 Offset: 0x28069D1 VA: 0x28068D0
	|-StaticCompositeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x2806980 Offset: 0x2806A81 VA: 0x2806980
	|-StaticCompositeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x2806A30 Offset: 0x2806B31 VA: 0x2806A30
	|-StaticCompositeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2806AE0 Offset: 0x2806BE1 VA: 0x2806AE0
	|-StaticCompositeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x2806B90 Offset: 0x2806C91 VA: 0x2806B90
	|-StaticCompositeResolver.GetFormatter<Color>
	|
	|-RVA: 0x2806C40 Offset: 0x2806D41 VA: 0x2806C40
	|-StaticCompositeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2806CF0 Offset: 0x2806DF1 VA: 0x2806CF0
	|-StaticCompositeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x2806DA0 Offset: 0x2806EA1 VA: 0x2806DA0
	|-StaticCompositeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x2806E50 Offset: 0x2806F51 VA: 0x2806E50
	|-StaticCompositeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x2806F00 Offset: 0x2807001 VA: 0x2806F00
	|-StaticCompositeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2806FB0 Offset: 0x28070B1 VA: 0x2806FB0
	|-StaticCompositeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x2807060 Offset: 0x2807161 VA: 0x2807060
	|-StaticCompositeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x2807110 Offset: 0x2807211 VA: 0x2807110
	|-StaticCompositeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x28071C0 Offset: 0x28072C1 VA: 0x28071C0
	|-StaticCompositeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x2807270 Offset: 0x2807371 VA: 0x2807270
	|-StaticCompositeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x2807320 Offset: 0x2807421 VA: 0x2807320
	|-StaticCompositeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x28073D0 Offset: 0x28074D1 VA: 0x28073D0
	|-StaticCompositeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x2807480 Offset: 0x2807581 VA: 0x2807480
	|-StaticCompositeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2807530 Offset: 0x2807631 VA: 0x2807530
	|-StaticCompositeResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F94E0 Offset: 0x14F95E1 VA: 0x14F94E0
	private static void .cctor() { }
}

public class StaticCompositeResolver : IFormatterResolver // TypeDefIndex: 5274
{
	// Fields
	public static readonly StaticCompositeResolver Instance; // 0x0
	private bool freezed; // 0x10
	private IReadOnlyList<IMessagePackFormatter> formatters; // 0x18
	private IReadOnlyList<IFormatterResolver> resolvers; // 0x20

	// Methods

	// RVA: 0x14F8F30 Offset: 0x14F9031 VA: 0x14F8F30
	private void .ctor() { }

	// RVA: 0x14F90E0 Offset: 0x14F91E1 VA: 0x14F90E0
	public void Register(IMessagePackFormatter[] formatters) { }

	// RVA: 0x14F9260 Offset: 0x14F9361 VA: 0x14F9260
	public void Register(IFormatterResolver[] resolvers) { }

	// RVA: 0x14F93E0 Offset: 0x14F94E1 VA: 0x14F93E0
	public void Register(IReadOnlyList<IMessagePackFormatter> formatters, IReadOnlyList<IFormatterResolver> resolvers) { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2804930 Offset: 0x2804A31 VA: 0x2804930
	|-StaticCompositeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x28049E0 Offset: 0x2804AE1 VA: 0x28049E0
	|-StaticCompositeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2804A90 Offset: 0x2804B91 VA: 0x2804A90
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2804B40 Offset: 0x2804C41 VA: 0x2804B40
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2804BF0 Offset: 0x2804CF1 VA: 0x2804BF0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2804CA0 Offset: 0x2804DA1 VA: 0x2804CA0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x2804D50 Offset: 0x2804E51 VA: 0x2804D50
	|-StaticCompositeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2804E00 Offset: 0x2804F01 VA: 0x2804E00
	|-StaticCompositeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2804EB0 Offset: 0x2804FB1 VA: 0x2804EB0
	|-StaticCompositeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x2804F60 Offset: 0x2805061 VA: 0x2804F60
	|-StaticCompositeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2805010 Offset: 0x2805111 VA: 0x2805010
	|-StaticCompositeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x28050C0 Offset: 0x28051C1 VA: 0x28050C0
	|-StaticCompositeResolver.GetFormatter<bool>
	|
	|-RVA: 0x2805170 Offset: 0x2805271 VA: 0x2805170
	|-StaticCompositeResolver.GetFormatter<byte>
	|
	|-RVA: 0x2805220 Offset: 0x2805321 VA: 0x2805220
	|-StaticCompositeResolver.GetFormatter<char>
	|
	|-RVA: 0x28052D0 Offset: 0x28053D1 VA: 0x28052D0
	|-StaticCompositeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x2805380 Offset: 0x2805481 VA: 0x2805380
	|-StaticCompositeResolver.GetFormatter<double>
	|
	|-RVA: 0x2805430 Offset: 0x2805531 VA: 0x2805430
	|-StaticCompositeResolver.GetFormatter<short>
	|
	|-RVA: 0x28054E0 Offset: 0x28055E1 VA: 0x28054E0
	|-StaticCompositeResolver.GetFormatter<int>
	|
	|-RVA: 0x2805590 Offset: 0x2805691 VA: 0x2805590
	|-StaticCompositeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2805640 Offset: 0x2805741 VA: 0x2805640
	|-StaticCompositeResolver.GetFormatter<long>
	|
	|-RVA: 0x28056F0 Offset: 0x28057F1 VA: 0x28056F0
	|-StaticCompositeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x28057A0 Offset: 0x28058A1 VA: 0x28057A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2805850 Offset: 0x2805951 VA: 0x2805850
	|-StaticCompositeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2805900 Offset: 0x2805A01 VA: 0x2805900
	|-StaticCompositeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x28059B0 Offset: 0x2805AB1 VA: 0x28059B0
	|-StaticCompositeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2805A60 Offset: 0x2805B61 VA: 0x2805A60
	|-StaticCompositeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2805B10 Offset: 0x2805C11 VA: 0x2805B10
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2805BC0 Offset: 0x2805CC1 VA: 0x2805BC0
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2805C70 Offset: 0x2805D71 VA: 0x2805C70
	|-StaticCompositeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2805D20 Offset: 0x2805E21 VA: 0x2805D20
	|-StaticCompositeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2805DD0 Offset: 0x2805ED1 VA: 0x2805DD0
	|-StaticCompositeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2805E80 Offset: 0x2805F81 VA: 0x2805E80
	|-StaticCompositeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2805F30 Offset: 0x2806031 VA: 0x2805F30
	|-StaticCompositeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2805FE0 Offset: 0x28060E1 VA: 0x2805FE0
	|-StaticCompositeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x2806090 Offset: 0x2806191 VA: 0x2806090
	|-StaticCompositeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2806140 Offset: 0x2806241 VA: 0x2806140
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x28061F0 Offset: 0x28062F1 VA: 0x28061F0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28062A0 Offset: 0x28063A1 VA: 0x28062A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x2806350 Offset: 0x2806451 VA: 0x2806350
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2806400 Offset: 0x2806501 VA: 0x2806400
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x28064B0 Offset: 0x28065B1 VA: 0x28064B0
	|-StaticCompositeResolver.GetFormatter<object>
	|
	|-RVA: 0x2806560 Offset: 0x2806661 VA: 0x2806560
	|-StaticCompositeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2806610 Offset: 0x2806711 VA: 0x2806610
	|-StaticCompositeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x28066C0 Offset: 0x28067C1 VA: 0x28066C0
	|-StaticCompositeResolver.GetFormatter<float>
	|
	|-RVA: 0x2806770 Offset: 0x2806871 VA: 0x2806770
	|-StaticCompositeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x2806820 Offset: 0x2806921 VA: 0x2806820
	|-StaticCompositeResolver.GetFormatter<uint>
	|
	|-RVA: 0x28068D0 Offset: 0x28069D1 VA: 0x28068D0
	|-StaticCompositeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x2806980 Offset: 0x2806A81 VA: 0x2806980
	|-StaticCompositeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x2806A30 Offset: 0x2806B31 VA: 0x2806A30
	|-StaticCompositeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2806AE0 Offset: 0x2806BE1 VA: 0x2806AE0
	|-StaticCompositeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x2806B90 Offset: 0x2806C91 VA: 0x2806B90
	|-StaticCompositeResolver.GetFormatter<Color>
	|
	|-RVA: 0x2806C40 Offset: 0x2806D41 VA: 0x2806C40
	|-StaticCompositeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2806CF0 Offset: 0x2806DF1 VA: 0x2806CF0
	|-StaticCompositeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x2806DA0 Offset: 0x2806EA1 VA: 0x2806DA0
	|-StaticCompositeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x2806E50 Offset: 0x2806F51 VA: 0x2806E50
	|-StaticCompositeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x2806F00 Offset: 0x2807001 VA: 0x2806F00
	|-StaticCompositeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2806FB0 Offset: 0x28070B1 VA: 0x2806FB0
	|-StaticCompositeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x2807060 Offset: 0x2807161 VA: 0x2807060
	|-StaticCompositeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x2807110 Offset: 0x2807211 VA: 0x2807110
	|-StaticCompositeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x28071C0 Offset: 0x28072C1 VA: 0x28071C0
	|-StaticCompositeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x2807270 Offset: 0x2807371 VA: 0x2807270
	|-StaticCompositeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x2807320 Offset: 0x2807421 VA: 0x2807320
	|-StaticCompositeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x28073D0 Offset: 0x28074D1 VA: 0x28073D0
	|-StaticCompositeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x2807480 Offset: 0x2807581 VA: 0x2807480
	|-StaticCompositeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2807530 Offset: 0x2807631 VA: 0x2807530
	|-StaticCompositeResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F94E0 Offset: 0x14F95E1 VA: 0x14F94E0
	private static void .cctor() { }
}

public class StaticCompositeResolver : IFormatterResolver // TypeDefIndex: 5274
{
	// Fields
	public static readonly StaticCompositeResolver Instance; // 0x0
	private bool freezed; // 0x10
	private IReadOnlyList<IMessagePackFormatter> formatters; // 0x18
	private IReadOnlyList<IFormatterResolver> resolvers; // 0x20

	// Methods

	// RVA: 0x14F8F30 Offset: 0x14F9031 VA: 0x14F8F30
	private void .ctor() { }

	// RVA: 0x14F90E0 Offset: 0x14F91E1 VA: 0x14F90E0
	public void Register(IMessagePackFormatter[] formatters) { }

	// RVA: 0x14F9260 Offset: 0x14F9361 VA: 0x14F9260
	public void Register(IFormatterResolver[] resolvers) { }

	// RVA: 0x14F93E0 Offset: 0x14F94E1 VA: 0x14F93E0
	public void Register(IReadOnlyList<IMessagePackFormatter> formatters, IReadOnlyList<IFormatterResolver> resolvers) { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2804930 Offset: 0x2804A31 VA: 0x2804930
	|-StaticCompositeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x28049E0 Offset: 0x2804AE1 VA: 0x28049E0
	|-StaticCompositeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2804A90 Offset: 0x2804B91 VA: 0x2804A90
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2804B40 Offset: 0x2804C41 VA: 0x2804B40
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2804BF0 Offset: 0x2804CF1 VA: 0x2804BF0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2804CA0 Offset: 0x2804DA1 VA: 0x2804CA0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x2804D50 Offset: 0x2804E51 VA: 0x2804D50
	|-StaticCompositeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2804E00 Offset: 0x2804F01 VA: 0x2804E00
	|-StaticCompositeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2804EB0 Offset: 0x2804FB1 VA: 0x2804EB0
	|-StaticCompositeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x2804F60 Offset: 0x2805061 VA: 0x2804F60
	|-StaticCompositeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2805010 Offset: 0x2805111 VA: 0x2805010
	|-StaticCompositeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x28050C0 Offset: 0x28051C1 VA: 0x28050C0
	|-StaticCompositeResolver.GetFormatter<bool>
	|
	|-RVA: 0x2805170 Offset: 0x2805271 VA: 0x2805170
	|-StaticCompositeResolver.GetFormatter<byte>
	|
	|-RVA: 0x2805220 Offset: 0x2805321 VA: 0x2805220
	|-StaticCompositeResolver.GetFormatter<char>
	|
	|-RVA: 0x28052D0 Offset: 0x28053D1 VA: 0x28052D0
	|-StaticCompositeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x2805380 Offset: 0x2805481 VA: 0x2805380
	|-StaticCompositeResolver.GetFormatter<double>
	|
	|-RVA: 0x2805430 Offset: 0x2805531 VA: 0x2805430
	|-StaticCompositeResolver.GetFormatter<short>
	|
	|-RVA: 0x28054E0 Offset: 0x28055E1 VA: 0x28054E0
	|-StaticCompositeResolver.GetFormatter<int>
	|
	|-RVA: 0x2805590 Offset: 0x2805691 VA: 0x2805590
	|-StaticCompositeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2805640 Offset: 0x2805741 VA: 0x2805640
	|-StaticCompositeResolver.GetFormatter<long>
	|
	|-RVA: 0x28056F0 Offset: 0x28057F1 VA: 0x28056F0
	|-StaticCompositeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x28057A0 Offset: 0x28058A1 VA: 0x28057A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2805850 Offset: 0x2805951 VA: 0x2805850
	|-StaticCompositeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2805900 Offset: 0x2805A01 VA: 0x2805900
	|-StaticCompositeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x28059B0 Offset: 0x2805AB1 VA: 0x28059B0
	|-StaticCompositeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2805A60 Offset: 0x2805B61 VA: 0x2805A60
	|-StaticCompositeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2805B10 Offset: 0x2805C11 VA: 0x2805B10
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2805BC0 Offset: 0x2805CC1 VA: 0x2805BC0
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2805C70 Offset: 0x2805D71 VA: 0x2805C70
	|-StaticCompositeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2805D20 Offset: 0x2805E21 VA: 0x2805D20
	|-StaticCompositeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2805DD0 Offset: 0x2805ED1 VA: 0x2805DD0
	|-StaticCompositeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2805E80 Offset: 0x2805F81 VA: 0x2805E80
	|-StaticCompositeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2805F30 Offset: 0x2806031 VA: 0x2805F30
	|-StaticCompositeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2805FE0 Offset: 0x28060E1 VA: 0x2805FE0
	|-StaticCompositeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x2806090 Offset: 0x2806191 VA: 0x2806090
	|-StaticCompositeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2806140 Offset: 0x2806241 VA: 0x2806140
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x28061F0 Offset: 0x28062F1 VA: 0x28061F0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28062A0 Offset: 0x28063A1 VA: 0x28062A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x2806350 Offset: 0x2806451 VA: 0x2806350
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2806400 Offset: 0x2806501 VA: 0x2806400
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x28064B0 Offset: 0x28065B1 VA: 0x28064B0
	|-StaticCompositeResolver.GetFormatter<object>
	|
	|-RVA: 0x2806560 Offset: 0x2806661 VA: 0x2806560
	|-StaticCompositeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2806610 Offset: 0x2806711 VA: 0x2806610
	|-StaticCompositeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x28066C0 Offset: 0x28067C1 VA: 0x28066C0
	|-StaticCompositeResolver.GetFormatter<float>
	|
	|-RVA: 0x2806770 Offset: 0x2806871 VA: 0x2806770
	|-StaticCompositeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x2806820 Offset: 0x2806921 VA: 0x2806820
	|-StaticCompositeResolver.GetFormatter<uint>
	|
	|-RVA: 0x28068D0 Offset: 0x28069D1 VA: 0x28068D0
	|-StaticCompositeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x2806980 Offset: 0x2806A81 VA: 0x2806980
	|-StaticCompositeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x2806A30 Offset: 0x2806B31 VA: 0x2806A30
	|-StaticCompositeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2806AE0 Offset: 0x2806BE1 VA: 0x2806AE0
	|-StaticCompositeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x2806B90 Offset: 0x2806C91 VA: 0x2806B90
	|-StaticCompositeResolver.GetFormatter<Color>
	|
	|-RVA: 0x2806C40 Offset: 0x2806D41 VA: 0x2806C40
	|-StaticCompositeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2806CF0 Offset: 0x2806DF1 VA: 0x2806CF0
	|-StaticCompositeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x2806DA0 Offset: 0x2806EA1 VA: 0x2806DA0
	|-StaticCompositeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x2806E50 Offset: 0x2806F51 VA: 0x2806E50
	|-StaticCompositeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x2806F00 Offset: 0x2807001 VA: 0x2806F00
	|-StaticCompositeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2806FB0 Offset: 0x28070B1 VA: 0x2806FB0
	|-StaticCompositeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x2807060 Offset: 0x2807161 VA: 0x2807060
	|-StaticCompositeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x2807110 Offset: 0x2807211 VA: 0x2807110
	|-StaticCompositeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x28071C0 Offset: 0x28072C1 VA: 0x28071C0
	|-StaticCompositeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x2807270 Offset: 0x2807371 VA: 0x2807270
	|-StaticCompositeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x2807320 Offset: 0x2807421 VA: 0x2807320
	|-StaticCompositeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x28073D0 Offset: 0x28074D1 VA: 0x28073D0
	|-StaticCompositeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x2807480 Offset: 0x2807581 VA: 0x2807480
	|-StaticCompositeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2807530 Offset: 0x2807631 VA: 0x2807530
	|-StaticCompositeResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F94E0 Offset: 0x14F95E1 VA: 0x14F94E0
	private static void .cctor() { }
}

public class StaticCompositeResolver : IFormatterResolver // TypeDefIndex: 5274
{
	// Fields
	public static readonly StaticCompositeResolver Instance; // 0x0
	private bool freezed; // 0x10
	private IReadOnlyList<IMessagePackFormatter> formatters; // 0x18
	private IReadOnlyList<IFormatterResolver> resolvers; // 0x20

	// Methods

	// RVA: 0x14F8F30 Offset: 0x14F9031 VA: 0x14F8F30
	private void .ctor() { }

	// RVA: 0x14F90E0 Offset: 0x14F91E1 VA: 0x14F90E0
	public void Register(IMessagePackFormatter[] formatters) { }

	// RVA: 0x14F9260 Offset: 0x14F9361 VA: 0x14F9260
	public void Register(IFormatterResolver[] resolvers) { }

	// RVA: 0x14F93E0 Offset: 0x14F94E1 VA: 0x14F93E0
	public void Register(IReadOnlyList<IMessagePackFormatter> formatters, IReadOnlyList<IFormatterResolver> resolvers) { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2804930 Offset: 0x2804A31 VA: 0x2804930
	|-StaticCompositeResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x28049E0 Offset: 0x2804AE1 VA: 0x28049E0
	|-StaticCompositeResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2804A90 Offset: 0x2804B91 VA: 0x2804A90
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2804B40 Offset: 0x2804C41 VA: 0x2804B40
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2804BF0 Offset: 0x2804CF1 VA: 0x2804BF0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2804CA0 Offset: 0x2804DA1 VA: 0x2804CA0
	|-StaticCompositeResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x2804D50 Offset: 0x2804E51 VA: 0x2804D50
	|-StaticCompositeResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2804E00 Offset: 0x2804F01 VA: 0x2804E00
	|-StaticCompositeResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2804EB0 Offset: 0x2804FB1 VA: 0x2804EB0
	|-StaticCompositeResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x2804F60 Offset: 0x2805061 VA: 0x2804F60
	|-StaticCompositeResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2805010 Offset: 0x2805111 VA: 0x2805010
	|-StaticCompositeResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x28050C0 Offset: 0x28051C1 VA: 0x28050C0
	|-StaticCompositeResolver.GetFormatter<bool>
	|
	|-RVA: 0x2805170 Offset: 0x2805271 VA: 0x2805170
	|-StaticCompositeResolver.GetFormatter<byte>
	|
	|-RVA: 0x2805220 Offset: 0x2805321 VA: 0x2805220
	|-StaticCompositeResolver.GetFormatter<char>
	|
	|-RVA: 0x28052D0 Offset: 0x28053D1 VA: 0x28052D0
	|-StaticCompositeResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x2805380 Offset: 0x2805481 VA: 0x2805380
	|-StaticCompositeResolver.GetFormatter<double>
	|
	|-RVA: 0x2805430 Offset: 0x2805531 VA: 0x2805430
	|-StaticCompositeResolver.GetFormatter<short>
	|
	|-RVA: 0x28054E0 Offset: 0x28055E1 VA: 0x28054E0
	|-StaticCompositeResolver.GetFormatter<int>
	|
	|-RVA: 0x2805590 Offset: 0x2805691 VA: 0x2805590
	|-StaticCompositeResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x2805640 Offset: 0x2805741 VA: 0x2805640
	|-StaticCompositeResolver.GetFormatter<long>
	|
	|-RVA: 0x28056F0 Offset: 0x28057F1 VA: 0x28056F0
	|-StaticCompositeResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x28057A0 Offset: 0x28058A1 VA: 0x28057A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2805850 Offset: 0x2805951 VA: 0x2805850
	|-StaticCompositeResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x2805900 Offset: 0x2805A01 VA: 0x2805900
	|-StaticCompositeResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x28059B0 Offset: 0x2805AB1 VA: 0x28059B0
	|-StaticCompositeResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2805A60 Offset: 0x2805B61 VA: 0x2805A60
	|-StaticCompositeResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x2805B10 Offset: 0x2805C11 VA: 0x2805B10
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2805BC0 Offset: 0x2805CC1 VA: 0x2805BC0
	|-StaticCompositeResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2805C70 Offset: 0x2805D71 VA: 0x2805C70
	|-StaticCompositeResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x2805D20 Offset: 0x2805E21 VA: 0x2805D20
	|-StaticCompositeResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2805DD0 Offset: 0x2805ED1 VA: 0x2805DD0
	|-StaticCompositeResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2805E80 Offset: 0x2805F81 VA: 0x2805E80
	|-StaticCompositeResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2805F30 Offset: 0x2806031 VA: 0x2805F30
	|-StaticCompositeResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2805FE0 Offset: 0x28060E1 VA: 0x2805FE0
	|-StaticCompositeResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x2806090 Offset: 0x2806191 VA: 0x2806090
	|-StaticCompositeResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2806140 Offset: 0x2806241 VA: 0x2806140
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x28061F0 Offset: 0x28062F1 VA: 0x28061F0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x28062A0 Offset: 0x28063A1 VA: 0x28062A0
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x2806350 Offset: 0x2806451 VA: 0x2806350
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x2806400 Offset: 0x2806501 VA: 0x2806400
	|-StaticCompositeResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x28064B0 Offset: 0x28065B1 VA: 0x28064B0
	|-StaticCompositeResolver.GetFormatter<object>
	|
	|-RVA: 0x2806560 Offset: 0x2806661 VA: 0x2806560
	|-StaticCompositeResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2806610 Offset: 0x2806711 VA: 0x2806610
	|-StaticCompositeResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x28066C0 Offset: 0x28067C1 VA: 0x28066C0
	|-StaticCompositeResolver.GetFormatter<float>
	|
	|-RVA: 0x2806770 Offset: 0x2806871 VA: 0x2806770
	|-StaticCompositeResolver.GetFormatter<ushort>
	|
	|-RVA: 0x2806820 Offset: 0x2806921 VA: 0x2806820
	|-StaticCompositeResolver.GetFormatter<uint>
	|
	|-RVA: 0x28068D0 Offset: 0x28069D1 VA: 0x28068D0
	|-StaticCompositeResolver.GetFormatter<ulong>
	|
	|-RVA: 0x2806980 Offset: 0x2806A81 VA: 0x2806980
	|-StaticCompositeResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x2806A30 Offset: 0x2806B31 VA: 0x2806A30
	|-StaticCompositeResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2806AE0 Offset: 0x2806BE1 VA: 0x2806AE0
	|-StaticCompositeResolver.GetFormatter<Color32>
	|
	|-RVA: 0x2806B90 Offset: 0x2806C91 VA: 0x2806B90
	|-StaticCompositeResolver.GetFormatter<Color>
	|
	|-RVA: 0x2806C40 Offset: 0x2806D41 VA: 0x2806C40
	|-StaticCompositeResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x2806CF0 Offset: 0x2806DF1 VA: 0x2806CF0
	|-StaticCompositeResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x2806DA0 Offset: 0x2806EA1 VA: 0x2806DA0
	|-StaticCompositeResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x2806E50 Offset: 0x2806F51 VA: 0x2806E50
	|-StaticCompositeResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x2806F00 Offset: 0x2807001 VA: 0x2806F00
	|-StaticCompositeResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2806FB0 Offset: 0x28070B1 VA: 0x2806FB0
	|-StaticCompositeResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x2807060 Offset: 0x2807161 VA: 0x2807060
	|-StaticCompositeResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x2807110 Offset: 0x2807211 VA: 0x2807110
	|-StaticCompositeResolver.GetFormatter<Rect>
	|
	|-RVA: 0x28071C0 Offset: 0x28072C1 VA: 0x28071C0
	|-StaticCompositeResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x2807270 Offset: 0x2807371 VA: 0x2807270
	|-StaticCompositeResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x2807320 Offset: 0x2807421 VA: 0x2807320
	|-StaticCompositeResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x28073D0 Offset: 0x28074D1 VA: 0x28073D0
	|-StaticCompositeResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x2807480 Offset: 0x2807581 VA: 0x2807480
	|-StaticCompositeResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x2807530 Offset: 0x2807631 VA: 0x2807530
	|-StaticCompositeResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F94E0 Offset: 0x14F95E1 VA: 0x14F94E0
	private static void .cctor() { }
}

