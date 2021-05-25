internal abstract class CachingFormatterResolver : IFormatterResolver // TypeDefIndex: 5228
{
	// Fields
	private readonly ThreadsafeTypeKeyHashTable<IMessagePackFormatter> formatters; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B186B0 Offset: 0x1B187B1 VA: 0x1B186B0
	|-CachingFormatterResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x1B18830 Offset: 0x1B18931 VA: 0x1B18830
	|-CachingFormatterResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1B189B0 Offset: 0x1B18AB1 VA: 0x1B189B0
	|-CachingFormatterResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1B18B30 Offset: 0x1B18C31 VA: 0x1B18B30
	|-CachingFormatterResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1B18CB0 Offset: 0x1B18DB1 VA: 0x1B18CB0
	|-CachingFormatterResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1B18E30 Offset: 0x1B18F31 VA: 0x1B18E30
	|-CachingFormatterResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1B18FB0 Offset: 0x1B190B1 VA: 0x1B18FB0
	|-CachingFormatterResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1B19130 Offset: 0x1B19231 VA: 0x1B19130
	|-CachingFormatterResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1B192B0 Offset: 0x1B193B1 VA: 0x1B192B0
	|-CachingFormatterResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1B19430 Offset: 0x1B19531 VA: 0x1B19430
	|-CachingFormatterResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1B195B0 Offset: 0x1B196B1 VA: 0x1B195B0
	|-CachingFormatterResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1B19730 Offset: 0x1B19831 VA: 0x1B19730
	|-CachingFormatterResolver.GetFormatter<bool>
	|
	|-RVA: 0x1B198B0 Offset: 0x1B199B1 VA: 0x1B198B0
	|-CachingFormatterResolver.GetFormatter<byte>
	|
	|-RVA: 0x1B19A30 Offset: 0x1B19B31 VA: 0x1B19A30
	|-CachingFormatterResolver.GetFormatter<char>
	|
	|-RVA: 0x1B19BB0 Offset: 0x1B19CB1 VA: 0x1B19BB0
	|-CachingFormatterResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1B19D30 Offset: 0x1B19E31 VA: 0x1B19D30
	|-CachingFormatterResolver.GetFormatter<double>
	|
	|-RVA: 0x1B19EB0 Offset: 0x1B19FB1 VA: 0x1B19EB0
	|-CachingFormatterResolver.GetFormatter<short>
	|
	|-RVA: 0x1B1A030 Offset: 0x1B1A131 VA: 0x1B1A030
	|-CachingFormatterResolver.GetFormatter<int>
	|
	|-RVA: 0x1B1A1B0 Offset: 0x1B1A2B1 VA: 0x1B1A1B0
	|-CachingFormatterResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1B1A330 Offset: 0x1B1A431 VA: 0x1B1A330
	|-CachingFormatterResolver.GetFormatter<long>
	|
	|-RVA: 0x1B1A4B0 Offset: 0x1B1A5B1 VA: 0x1B1A4B0
	|-CachingFormatterResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1B1A630 Offset: 0x1B1A731 VA: 0x1B1A630
	|-CachingFormatterResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1B1A7B0 Offset: 0x1B1A8B1 VA: 0x1B1A7B0
	|-CachingFormatterResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x1B1A930 Offset: 0x1B1AA31 VA: 0x1B1A930
	|-CachingFormatterResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1B1AAB0 Offset: 0x1B1ABB1 VA: 0x1B1AAB0
	|-CachingFormatterResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1B1AC30 Offset: 0x1B1AD31 VA: 0x1B1AC30
	|-CachingFormatterResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1B1ADB0 Offset: 0x1B1AEB1 VA: 0x1B1ADB0
	|-CachingFormatterResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1B1AF30 Offset: 0x1B1B031 VA: 0x1B1AF30
	|-CachingFormatterResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1B1B0B0 Offset: 0x1B1B1B1 VA: 0x1B1B0B0
	|-CachingFormatterResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1B1B230 Offset: 0x1B1B331 VA: 0x1B1B230
	|-CachingFormatterResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1B1B3B0 Offset: 0x1B1B4B1 VA: 0x1B1B3B0
	|-CachingFormatterResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1B1B530 Offset: 0x1B1B631 VA: 0x1B1B530
	|-CachingFormatterResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1B1B6B0 Offset: 0x1B1B7B1 VA: 0x1B1B6B0
	|-CachingFormatterResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1B1B830 Offset: 0x1B1B931 VA: 0x1B1B830
	|-CachingFormatterResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1B1B9B0 Offset: 0x1B1BAB1 VA: 0x1B1B9B0
	|-CachingFormatterResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1B1BB30 Offset: 0x1B1BC31 VA: 0x1B1BB30
	|-CachingFormatterResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x1B1BCB0 Offset: 0x1B1BDB1 VA: 0x1B1BCB0
	|-CachingFormatterResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1B1BE30 Offset: 0x1B1BF31 VA: 0x1B1BE30
	|-CachingFormatterResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1B1BFB0 Offset: 0x1B1C0B1 VA: 0x1B1BFB0
	|-CachingFormatterResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x1B1C130 Offset: 0x1B1C231 VA: 0x1B1C130
	|-CachingFormatterResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1B1C2B0 Offset: 0x1B1C3B1 VA: 0x1B1C2B0
	|-CachingFormatterResolver.GetFormatter<object>
	|
	|-RVA: 0x1B1C430 Offset: 0x1B1C531 VA: 0x1B1C430
	|-CachingFormatterResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1B1C5B0 Offset: 0x1B1C6B1 VA: 0x1B1C5B0
	|-CachingFormatterResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1B1C730 Offset: 0x1B1C831 VA: 0x1B1C730
	|-CachingFormatterResolver.GetFormatter<float>
	|
	|-RVA: 0x1B1C8B0 Offset: 0x1B1C9B1 VA: 0x1B1C8B0
	|-CachingFormatterResolver.GetFormatter<ushort>
	|
	|-RVA: 0x1B1CA30 Offset: 0x1B1CB31 VA: 0x1B1CA30
	|-CachingFormatterResolver.GetFormatter<uint>
	|
	|-RVA: 0x1B1CBB0 Offset: 0x1B1CCB1 VA: 0x1B1CBB0
	|-CachingFormatterResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1B1CD30 Offset: 0x1B1CE31 VA: 0x1B1CD30
	|-CachingFormatterResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1B1CEB0 Offset: 0x1B1CFB1 VA: 0x1B1CEB0
	|-CachingFormatterResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1B1D030 Offset: 0x1B1D131 VA: 0x1B1D030
	|-CachingFormatterResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1B1D1B0 Offset: 0x1B1D2B1 VA: 0x1B1D1B0
	|-CachingFormatterResolver.GetFormatter<Color>
	|
	|-RVA: 0x1B1D330 Offset: 0x1B1D431 VA: 0x1B1D330
	|-CachingFormatterResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x1B1D4B0 Offset: 0x1B1D5B1 VA: 0x1B1D4B0
	|-CachingFormatterResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x1B1D630 Offset: 0x1B1D731 VA: 0x1B1D630
	|-CachingFormatterResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x1B1D7B0 Offset: 0x1B1D8B1 VA: 0x1B1D7B0
	|-CachingFormatterResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x1B1D930 Offset: 0x1B1DA31 VA: 0x1B1D930
	|-CachingFormatterResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x1B1DAB0 Offset: 0x1B1DBB1 VA: 0x1B1DAB0
	|-CachingFormatterResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x1B1DC30 Offset: 0x1B1DD31 VA: 0x1B1DC30
	|-CachingFormatterResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x1B1DDB0 Offset: 0x1B1DEB1 VA: 0x1B1DDB0
	|-CachingFormatterResolver.GetFormatter<Rect>
	|
	|-RVA: 0x1B1DF30 Offset: 0x1B1E031 VA: 0x1B1DF30
	|-CachingFormatterResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x1B1E0B0 Offset: 0x1B1E1B1 VA: 0x1B1E0B0
	|-CachingFormatterResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x1B1E230 Offset: 0x1B1E331 VA: 0x1B1E230
	|-CachingFormatterResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x1B1E3B0 Offset: 0x1B1E4B1 VA: 0x1B1E3B0
	|-CachingFormatterResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x1B1E530 Offset: 0x1B1E631 VA: 0x1B1E530
	|-CachingFormatterResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x1B1E6B0 Offset: 0x1B1E7B1 VA: 0x1B1E6B0
	|-CachingFormatterResolver.GetFormatter<Vector4>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract IMessagePackFormatter<T> GetFormatterCore<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CachingFormatterResolver.GetFormatterCore<object>
	*/

	// RVA: 0x14F21D0 Offset: 0x14F22D1 VA: 0x14F21D0
	protected void .ctor() { }
}

