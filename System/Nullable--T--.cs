[DebuggerStepThroughAttribute] // RVA: 0xACE40 Offset: 0xACF41 VA: 0xACE40
[Serializable]
public struct Nullable<T> // TypeDefIndex: 391
{
	// Fields
	internal T value; // 0x0
	internal bool has_value; // 0x0

	// Properties
	public bool HasValue { get; }
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30A320 Offset: 0x30A421 VA: 0x30A320
	|-Nullable<CropDataTable>..ctor
	|
	|-RVA: 0x30DA40 Offset: 0x30DB41 VA: 0x30DA40
	|-Nullable<FarmManager.FARM_ID>..ctor
	|-Nullable<MonoSslPolicyErrors>..ctor
	|-Nullable<ConsoleAlignment>..ctor
	|-Nullable<DefaultTabs>..ctor
	|-Nullable<Int32Enum>..ctor
	|-Nullable<CursorLockMode>..ctor
	|
	|-RVA: 0x30A980 Offset: 0x30AA81 VA: 0x30A980
	|-Nullable<Nil>..ctor
	|
	|-RVA: 0x30ACF0 Offset: 0x30ADF1 VA: 0x30ACF0
	|-Nullable<ArraySegment<byte>>..ctor
	|
	|-RVA: 0x30B180 Offset: 0x30B281 VA: 0x30B180
	|-Nullable<bool>..ctor
	|
	|-RVA: 0x30B4F0 Offset: 0x30B5F1 VA: 0x30B4F0
	|-Nullable<ReadOnlySequence<byte>>..ctor
	|
	|-RVA: 0x30BB80 Offset: 0x30BC81 VA: 0x30BB80
	|-Nullable<byte>..ctor
	|
	|-RVA: 0x30BEF0 Offset: 0x30BFF1 VA: 0x30BEF0
	|-Nullable<char>..ctor
	|
	|-RVA: 0x30C250 Offset: 0x30C351 VA: 0x30C250
	|-Nullable<DateTime>..ctor
	|
	|-RVA: 0x30C5A0 Offset: 0x30C6A1 VA: 0x30C5A0
	|-Nullable<DateTimeOffset>..ctor
	|
	|-RVA: 0x30C920 Offset: 0x30CA21 VA: 0x30C920
	|-Nullable<Decimal>..ctor
	|
	|-RVA: 0x30CCA0 Offset: 0x30CDA1 VA: 0x30CCA0
	|-Nullable<double>..ctor
	|
	|-RVA: 0x30D000 Offset: 0x30D101 VA: 0x30D000
	|-Nullable<Guid>..ctor
	|
	|-RVA: 0x30D380 Offset: 0x30D481 VA: 0x30D380
	|-Nullable<short>..ctor
	|
	|-RVA: 0x30D6E0 Offset: 0x30D7E1 VA: 0x30D6E0
	|-Nullable<int>..ctor
	|
	|-RVA: 0x30DDB0 Offset: 0x30DEB1 VA: 0x30DDB0
	|-Nullable<long>..ctor
	|
	|-RVA: 0x30E100 Offset: 0x30E201 VA: 0x30E100
	|-Nullable<LocalDefinition>..ctor
	|
	|-RVA: 0x30E5B0 Offset: 0x30E6B1 VA: 0x30E5B0
	|-Nullable<Memory<byte>>..ctor
	|
	|-RVA: 0x30EAD0 Offset: 0x30EBD1 VA: 0x30EAD0
	|-Nullable<BigInteger>..ctor
	|
	|-RVA: 0x30EFC0 Offset: 0x30F0C1 VA: 0x30EFC0
	|-Nullable<Complex>..ctor
	|
	|-RVA: 0x30F340 Offset: 0x30F441 VA: 0x30F340
	|-Nullable<ReadOnlyMemory<byte>>..ctor
	|
	|-RVA: 0x30F860 Offset: 0x30F961 VA: 0x30F860
	|-Nullable<Label>..ctor
	|
	|-RVA: 0x30FB60 Offset: 0x30FC61 VA: 0x30FB60
	|-Nullable<sbyte>..ctor
	|
	|-RVA: 0x30FED0 Offset: 0x30FFD1 VA: 0x30FED0
	|-Nullable<SequencePosition>..ctor
	|
	|-RVA: 0x310370 Offset: 0x310471 VA: 0x310370
	|-Nullable<float>..ctor
	|
	|-RVA: 0x3106F0 Offset: 0x3107F1 VA: 0x3106F0
	|-Nullable<TimeSpan>..ctor
	|
	|-RVA: 0x310A40 Offset: 0x310B41 VA: 0x310A40
	|-Nullable<ushort>..ctor
	|
	|-RVA: 0x310DA0 Offset: 0x310EA1 VA: 0x310DA0
	|-Nullable<uint>..ctor
	|
	|-RVA: 0x311100 Offset: 0x311201 VA: 0x311100
	|-Nullable<ulong>..ctor
	|
	|-RVA: 0x311450 Offset: 0x311551 VA: 0x311450
	|-Nullable<Bounds>..ctor
	|
	|-RVA: 0x311920 Offset: 0x311A21 VA: 0x311920
	|-Nullable<BoundsInt>..ctor
	|
	|-RVA: 0x311DF0 Offset: 0x311EF1 VA: 0x311DF0
	|-Nullable<Color32>..ctor
	|
	|-RVA: 0x3120C0 Offset: 0x3121C1 VA: 0x3120C0
	|-Nullable<Color>..ctor
	|
	|-RVA: 0x312530 Offset: 0x312631 VA: 0x312530
	|-Nullable<GradientAlphaKey>..ctor
	|
	|-RVA: 0x312800 Offset: 0x312901 VA: 0x312800
	|-Nullable<GradientColorKey>..ctor
	|
	|-RVA: 0x312BE0 Offset: 0x312CE1 VA: 0x312BE0
	|-Nullable<Keyframe>..ctor
	|
	|-RVA: 0x313070 Offset: 0x313171 VA: 0x313070
	|-Nullable<LayerMask>..ctor
	|
	|-RVA: 0x3132E0 Offset: 0x3133E1 VA: 0x3132E0
	|-Nullable<Matrix4x4>..ctor
	|
	|-RVA: 0x313930 Offset: 0x313A31 VA: 0x313930
	|-Nullable<Quaternion>..ctor
	|
	|-RVA: 0x313DA0 Offset: 0x313EA1 VA: 0x313DA0
	|-Nullable<RangeInt>..ctor
	|
	|-RVA: 0x314030 Offset: 0x314131 VA: 0x314030
	|-Nullable<Rect>..ctor
	|
	|-RVA: 0x3144A0 Offset: 0x3145A1 VA: 0x3144A0
	|-Nullable<RectInt>..ctor
	|
	|-RVA: 0x3147C0 Offset: 0x3148C1 VA: 0x3147C0
	|-Nullable<Vector2>..ctor
	|
	|-RVA: 0x314B80 Offset: 0x314C81 VA: 0x314B80
	|-Nullable<Vector2Int>..ctor
	|
	|-RVA: 0x314EE0 Offset: 0x314FE1 VA: 0x314EE0
	|-Nullable<Vector3>..ctor
	|
	|-RVA: 0x3152A0 Offset: 0x3153A1 VA: 0x3152A0
	|-Nullable<Vector3Int>..ctor
	|
	|-RVA: 0x315660 Offset: 0x315761 VA: 0x315660
	|-Nullable<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30A3B0 Offset: 0x30A4B1 VA: 0x30A3B0
	|-Nullable<CropDataTable>.get_HasValue
	|
	|-RVA: 0x30DA50 Offset: 0x30DB51 VA: 0x30DA50
	|-Nullable<Ease>.get_HasValue
	|-Nullable<LogBehaviour>.get_HasValue
	|-Nullable<LoopType>.get_HasValue
	|-Nullable<FarmManager.FARM_ID>.get_HasValue
	|-Nullable<ConsoleAlignment>.get_HasValue
	|-Nullable<DefaultTabs>.get_HasValue
	|-Nullable<Int32Enum>.get_HasValue
	|-Nullable<CursorLockMode>.get_HasValue
	|
	|-RVA: 0x30A990 Offset: 0x30AA91 VA: 0x30A990
	|-Nullable<Nil>.get_HasValue
	|
	|-RVA: 0x30AD60 Offset: 0x30AE61 VA: 0x30AD60
	|-Nullable<ArraySegment<byte>>.get_HasValue
	|
	|-RVA: 0x30B190 Offset: 0x30B291 VA: 0x30B190
	|-Nullable<bool>.get_HasValue
	|
	|-RVA: 0x30B580 Offset: 0x30B681 VA: 0x30B580
	|-Nullable<ReadOnlySequence<byte>>.get_HasValue
	|
	|-RVA: 0x30BB90 Offset: 0x30BC91 VA: 0x30BB90
	|-Nullable<byte>.get_HasValue
	|
	|-RVA: 0x30BF00 Offset: 0x30C001 VA: 0x30BF00
	|-Nullable<char>.get_HasValue
	|
	|-RVA: 0x30C260 Offset: 0x30C361 VA: 0x30C260
	|-Nullable<DateTime>.get_HasValue
	|
	|-RVA: 0x30C5B0 Offset: 0x30C6B1 VA: 0x30C5B0
	|-Nullable<DateTimeOffset>.get_HasValue
	|
	|-RVA: 0x30C930 Offset: 0x30CA31 VA: 0x30C930
	|-Nullable<Decimal>.get_HasValue
	|
	|-RVA: 0x30CCB0 Offset: 0x30CDB1 VA: 0x30CCB0
	|-Nullable<double>.get_HasValue
	|
	|-RVA: 0x30D010 Offset: 0x30D111 VA: 0x30D010
	|-Nullable<Guid>.get_HasValue
	|
	|-RVA: 0x30D390 Offset: 0x30D491 VA: 0x30D390
	|-Nullable<short>.get_HasValue
	|
	|-RVA: 0x30D6F0 Offset: 0x30D7F1 VA: 0x30D6F0
	|-Nullable<int>.get_HasValue
	|
	|-RVA: 0x30DDC0 Offset: 0x30DEC1 VA: 0x30DDC0
	|-Nullable<long>.get_HasValue
	|
	|-RVA: 0x30E170 Offset: 0x30E271 VA: 0x30E170
	|-Nullable<LocalDefinition>.get_HasValue
	|
	|-RVA: 0x30E620 Offset: 0x30E721 VA: 0x30E620
	|-Nullable<Memory<byte>>.get_HasValue
	|
	|-RVA: 0x30EB40 Offset: 0x30EC41 VA: 0x30EB40
	|-Nullable<BigInteger>.get_HasValue
	|
	|-RVA: 0x30EFD0 Offset: 0x30F0D1 VA: 0x30EFD0
	|-Nullable<Complex>.get_HasValue
	|
	|-RVA: 0x30F3B0 Offset: 0x30F4B1 VA: 0x30F3B0
	|-Nullable<ReadOnlyMemory<byte>>.get_HasValue
	|
	|-RVA: 0x30F870 Offset: 0x30F971 VA: 0x30F870
	|-Nullable<Label>.get_HasValue
	|
	|-RVA: 0x30FB70 Offset: 0x30FC71 VA: 0x30FB70
	|-Nullable<sbyte>.get_HasValue
	|
	|-RVA: 0x30FF40 Offset: 0x310041 VA: 0x30FF40
	|-Nullable<SequencePosition>.get_HasValue
	|
	|-RVA: 0x310380 Offset: 0x310481 VA: 0x310380
	|-Nullable<float>.get_HasValue
	|
	|-RVA: 0x310700 Offset: 0x310801 VA: 0x310700
	|-Nullable<TimeSpan>.get_HasValue
	|
	|-RVA: 0x310A50 Offset: 0x310B51 VA: 0x310A50
	|-Nullable<ushort>.get_HasValue
	|
	|-RVA: 0x310DB0 Offset: 0x310EB1 VA: 0x310DB0
	|-Nullable<uint>.get_HasValue
	|
	|-RVA: 0x311110 Offset: 0x311211 VA: 0x311110
	|-Nullable<ulong>.get_HasValue
	|
	|-RVA: 0x311470 Offset: 0x311571 VA: 0x311470
	|-Nullable<Bounds>.get_HasValue
	|
	|-RVA: 0x311940 Offset: 0x311A41 VA: 0x311940
	|-Nullable<BoundsInt>.get_HasValue
	|
	|-RVA: 0x311E00 Offset: 0x311F01 VA: 0x311E00
	|-Nullable<Color32>.get_HasValue
	|
	|-RVA: 0x3120E0 Offset: 0x3121E1 VA: 0x3120E0
	|-Nullable<Color>.get_HasValue
	|
	|-RVA: 0x312540 Offset: 0x312641 VA: 0x312540
	|-Nullable<GradientAlphaKey>.get_HasValue
	|
	|-RVA: 0x312820 Offset: 0x312921 VA: 0x312820
	|-Nullable<GradientColorKey>.get_HasValue
	|
	|-RVA: 0x312C00 Offset: 0x312D01 VA: 0x312C00
	|-Nullable<Keyframe>.get_HasValue
	|
	|-RVA: 0x313080 Offset: 0x313181 VA: 0x313080
	|-Nullable<LayerMask>.get_HasValue
	|
	|-RVA: 0x313300 Offset: 0x313401 VA: 0x313300
	|-Nullable<Matrix4x4>.get_HasValue
	|
	|-RVA: 0x313950 Offset: 0x313A51 VA: 0x313950
	|-Nullable<Quaternion>.get_HasValue
	|
	|-RVA: 0x313DB0 Offset: 0x313EB1 VA: 0x313DB0
	|-Nullable<RangeInt>.get_HasValue
	|
	|-RVA: 0x314050 Offset: 0x314151 VA: 0x314050
	|-Nullable<Rect>.get_HasValue
	|
	|-RVA: 0x3144B0 Offset: 0x3145B1 VA: 0x3144B0
	|-Nullable<RectInt>.get_HasValue
	|
	|-RVA: 0x3147D0 Offset: 0x3148D1 VA: 0x3147D0
	|-Nullable<Vector2>.get_HasValue
	|
	|-RVA: 0x314B90 Offset: 0x314C91 VA: 0x314B90
	|-Nullable<Vector2Int>.get_HasValue
	|
	|-RVA: 0x314EF0 Offset: 0x314FF1 VA: 0x314EF0
	|-Nullable<Vector3>.get_HasValue
	|
	|-RVA: 0x3152B0 Offset: 0x3153B1 VA: 0x3152B0
	|-Nullable<Vector3Int>.get_HasValue
	|
	|-RVA: 0x315680 Offset: 0x315781 VA: 0x315680
	|-Nullable<Vector4>.get_HasValue
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30A460 Offset: 0x30A561 VA: 0x30A460
	|-Nullable<CropDataTable>.get_Value
	|
	|-RVA: 0x30DA80 Offset: 0x30DB81 VA: 0x30DA80
	|-Nullable<Ease>.get_Value
	|-Nullable<LogBehaviour>.get_Value
	|-Nullable<LoopType>.get_Value
	|-Nullable<ConsoleAlignment>.get_Value
	|-Nullable<DefaultTabs>.get_Value
	|-Nullable<CursorLockMode>.get_Value
	|-Nullable<Int32Enum>.get_Value
	|
	|-RVA: 0x30B620 Offset: 0x30B721 VA: 0x30B620
	|-Nullable<ReadOnlySequence<byte>>.get_Value
	|
	|-RVA: 0x30BBC0 Offset: 0x30BCC1 VA: 0x30BBC0
	|-Nullable<byte>.get_Value
	|
	|-RVA: 0x30BF30 Offset: 0x30C031 VA: 0x30BF30
	|-Nullable<char>.get_Value
	|
	|-RVA: 0x30C290 Offset: 0x30C391 VA: 0x30C290
	|-Nullable<DateTime>.get_Value
	|
	|-RVA: 0x30CCE0 Offset: 0x30CDE1 VA: 0x30CCE0
	|-Nullable<double>.get_Value
	|
	|-RVA: 0x30D3C0 Offset: 0x30D4C1 VA: 0x30D3C0
	|-Nullable<short>.get_Value
	|
	|-RVA: 0x30DDF0 Offset: 0x30DEF1 VA: 0x30DDF0
	|-Nullable<long>.get_Value
	|
	|-RVA: 0x30F8A0 Offset: 0x30F9A1 VA: 0x30F8A0
	|-Nullable<Label>.get_Value
	|
	|-RVA: 0x30FBA0 Offset: 0x30FCA1 VA: 0x30FBA0
	|-Nullable<sbyte>.get_Value
	|
	|-RVA: 0x30FFB0 Offset: 0x3100B1 VA: 0x30FFB0
	|-Nullable<SequencePosition>.get_Value
	|
	|-RVA: 0x3103B0 Offset: 0x3104B1 VA: 0x3103B0
	|-Nullable<float>.get_Value
	|
	|-RVA: 0x310A80 Offset: 0x310B81 VA: 0x310A80
	|-Nullable<ushort>.get_Value
	|
	|-RVA: 0x310DE0 Offset: 0x310EE1 VA: 0x310DE0
	|-Nullable<uint>.get_Value
	|
	|-RVA: 0x311140 Offset: 0x311241 VA: 0x311140
	|-Nullable<ulong>.get_Value
	|
	|-RVA: 0x312130 Offset: 0x312231 VA: 0x312130
	|-Nullable<Color>.get_Value
	|
	|-RVA: 0x3139A0 Offset: 0x313AA1 VA: 0x3139A0
	|-Nullable<Quaternion>.get_Value
	|
	|-RVA: 0x314810 Offset: 0x314911 VA: 0x314810
	|-Nullable<Vector2>.get_Value
	|
	|-RVA: 0x314F30 Offset: 0x315031 VA: 0x314F30
	|-Nullable<Vector3>.get_Value
	|
	|-RVA: 0x30A9C0 Offset: 0x30AAC1 VA: 0x30A9C0
	|-Nullable<Nil>.get_Value
	|
	|-RVA: 0x30ADD0 Offset: 0x30AED1 VA: 0x30ADD0
	|-Nullable<ArraySegment<byte>>.get_Value
	|
	|-RVA: 0x30B1C0 Offset: 0x30B2C1 VA: 0x30B1C0
	|-Nullable<bool>.get_Value
	|
	|-RVA: 0x30C5E0 Offset: 0x30C6E1 VA: 0x30C5E0
	|-Nullable<DateTimeOffset>.get_Value
	|
	|-RVA: 0x30C960 Offset: 0x30CA61 VA: 0x30C960
	|-Nullable<Decimal>.get_Value
	|
	|-RVA: 0x30D040 Offset: 0x30D141 VA: 0x30D040
	|-Nullable<Guid>.get_Value
	|
	|-RVA: 0x30D720 Offset: 0x30D821 VA: 0x30D720
	|-Nullable<int>.get_Value
	|
	|-RVA: 0x30E1E0 Offset: 0x30E2E1 VA: 0x30E1E0
	|-Nullable<LocalDefinition>.get_Value
	|
	|-RVA: 0x30E690 Offset: 0x30E791 VA: 0x30E690
	|-Nullable<Memory<byte>>.get_Value
	|
	|-RVA: 0x30EBB0 Offset: 0x30ECB1 VA: 0x30EBB0
	|-Nullable<BigInteger>.get_Value
	|
	|-RVA: 0x30F000 Offset: 0x30F101 VA: 0x30F000
	|-Nullable<Complex>.get_Value
	|
	|-RVA: 0x30F420 Offset: 0x30F521 VA: 0x30F420
	|-Nullable<ReadOnlyMemory<byte>>.get_Value
	|
	|-RVA: 0x310730 Offset: 0x310831 VA: 0x310730
	|-Nullable<TimeSpan>.get_Value
	|
	|-RVA: 0x3114D0 Offset: 0x3115D1 VA: 0x3114D0
	|-Nullable<Bounds>.get_Value
	|
	|-RVA: 0x3119A0 Offset: 0x311AA1 VA: 0x3119A0
	|-Nullable<BoundsInt>.get_Value
	|
	|-RVA: 0x311E30 Offset: 0x311F31 VA: 0x311E30
	|-Nullable<Color32>.get_Value
	|
	|-RVA: 0x312580 Offset: 0x312681 VA: 0x312580
	|-Nullable<GradientAlphaKey>.get_Value
	|
	|-RVA: 0x312880 Offset: 0x312981 VA: 0x312880
	|-Nullable<GradientColorKey>.get_Value
	|
	|-RVA: 0x312C80 Offset: 0x312D81 VA: 0x312C80
	|-Nullable<Keyframe>.get_Value
	|
	|-RVA: 0x3130B0 Offset: 0x3131B1 VA: 0x3130B0
	|-Nullable<LayerMask>.get_Value
	|
	|-RVA: 0x313390 Offset: 0x313491 VA: 0x313390
	|-Nullable<Matrix4x4>.get_Value
	|
	|-RVA: 0x313DE0 Offset: 0x313EE1 VA: 0x313DE0
	|-Nullable<RangeInt>.get_Value
	|
	|-RVA: 0x3140A0 Offset: 0x3141A1 VA: 0x3140A0
	|-Nullable<Rect>.get_Value
	|
	|-RVA: 0x3144E0 Offset: 0x3145E1 VA: 0x3144E0
	|-Nullable<RectInt>.get_Value
	|
	|-RVA: 0x314BC0 Offset: 0x314CC1 VA: 0x314BC0
	|-Nullable<Vector2Int>.get_Value
	|
	|-RVA: 0x3152E0 Offset: 0x3153E1 VA: 0x3152E0
	|-Nullable<Vector3Int>.get_Value
	|
	|-RVA: 0x3156D0 Offset: 0x3157D1 VA: 0x3156D0
	|-Nullable<Vector4>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30A590 Offset: 0x30A691 VA: 0x30A590
	|-Nullable<CropDataTable>.Equals
	|
	|-RVA: 0x30AA80 Offset: 0x30AB81 VA: 0x30AA80
	|-Nullable<Nil>.Equals
	|
	|-RVA: 0x30AEB0 Offset: 0x30AFB1 VA: 0x30AEB0
	|-Nullable<ArraySegment<byte>>.Equals
	|
	|-RVA: 0x30B280 Offset: 0x30B381 VA: 0x30B280
	|-Nullable<bool>.Equals
	|
	|-RVA: 0x30B750 Offset: 0x30B851 VA: 0x30B750
	|-Nullable<ReadOnlySequence<byte>>.Equals
	|
	|-RVA: 0x30BC80 Offset: 0x30BD81 VA: 0x30BC80
	|-Nullable<byte>.Equals
	|
	|-RVA: 0x30BFF0 Offset: 0x30C0F1 VA: 0x30BFF0
	|-Nullable<char>.Equals
	|
	|-RVA: 0x30C350 Offset: 0x30C451 VA: 0x30C350
	|-Nullable<DateTime>.Equals
	|
	|-RVA: 0x30C6B0 Offset: 0x30C7B1 VA: 0x30C6B0
	|-Nullable<DateTimeOffset>.Equals
	|
	|-RVA: 0x30CA30 Offset: 0x30CB31 VA: 0x30CA30
	|-Nullable<Decimal>.Equals
	|
	|-RVA: 0x30CDB0 Offset: 0x30CEB1 VA: 0x30CDB0
	|-Nullable<double>.Equals
	|
	|-RVA: 0x30D110 Offset: 0x30D211 VA: 0x30D110
	|-Nullable<Guid>.Equals
	|
	|-RVA: 0x30D480 Offset: 0x30D581 VA: 0x30D480
	|-Nullable<short>.Equals
	|
	|-RVA: 0x30D7E0 Offset: 0x30D8E1 VA: 0x30D7E0
	|-Nullable<int>.Equals
	|
	|-RVA: 0x30DB40 Offset: 0x30DC41 VA: 0x30DB40
	|-Nullable<Int32Enum>.Equals
	|
	|-RVA: 0x30DEB0 Offset: 0x30DFB1 VA: 0x30DEB0
	|-Nullable<long>.Equals
	|
	|-RVA: 0x30E2C0 Offset: 0x30E3C1 VA: 0x30E2C0
	|-Nullable<LocalDefinition>.Equals
	|
	|-RVA: 0x30E770 Offset: 0x30E871 VA: 0x30E770
	|-Nullable<Memory<byte>>.Equals
	|
	|-RVA: 0x30EC90 Offset: 0x30ED91 VA: 0x30EC90
	|-Nullable<BigInteger>.Equals
	|
	|-RVA: 0x30F0D0 Offset: 0x30F1D1 VA: 0x30F0D0
	|-Nullable<Complex>.Equals
	|
	|-RVA: 0x30F500 Offset: 0x30F601 VA: 0x30F500
	|-Nullable<ReadOnlyMemory<byte>>.Equals
	|
	|-RVA: 0x30F960 Offset: 0x30FA61 VA: 0x30F960
	|-Nullable<Label>.Equals
	|
	|-RVA: 0x30FC60 Offset: 0x30FD61 VA: 0x30FC60
	|-Nullable<sbyte>.Equals
	|
	|-RVA: 0x310090 Offset: 0x310191 VA: 0x310090
	|-Nullable<SequencePosition>.Equals
	|
	|-RVA: 0x310480 Offset: 0x310581 VA: 0x310480
	|-Nullable<float>.Equals
	|
	|-RVA: 0x3107F0 Offset: 0x3108F1 VA: 0x3107F0
	|-Nullable<TimeSpan>.Equals
	|
	|-RVA: 0x310B40 Offset: 0x310C41 VA: 0x310B40
	|-Nullable<ushort>.Equals
	|
	|-RVA: 0x310EA0 Offset: 0x310FA1 VA: 0x310EA0
	|-Nullable<uint>.Equals
	|
	|-RVA: 0x311200 Offset: 0x311301 VA: 0x311200
	|-Nullable<ulong>.Equals
	|
	|-RVA: 0x3115D0 Offset: 0x3116D1 VA: 0x3115D0
	|-Nullable<Bounds>.Equals
	|
	|-RVA: 0x311AA0 Offset: 0x311BA1 VA: 0x311AA0
	|-Nullable<BoundsInt>.Equals
	|
	|-RVA: 0x311EF0 Offset: 0x311FF1 VA: 0x311EF0
	|-Nullable<Color32>.Equals
	|
	|-RVA: 0x312200 Offset: 0x312301 VA: 0x312200
	|-Nullable<Color>.Equals
	|
	|-RVA: 0x312650 Offset: 0x312751 VA: 0x312650
	|-Nullable<GradientAlphaKey>.Equals
	|
	|-RVA: 0x312980 Offset: 0x312A81 VA: 0x312980
	|-Nullable<GradientColorKey>.Equals
	|
	|-RVA: 0x312DA0 Offset: 0x312EA1 VA: 0x312DA0
	|-Nullable<Keyframe>.Equals
	|
	|-RVA: 0x313170 Offset: 0x313271 VA: 0x313170
	|-Nullable<LayerMask>.Equals
	|
	|-RVA: 0x3134D0 Offset: 0x3135D1 VA: 0x3134D0
	|-Nullable<Matrix4x4>.Equals
	|
	|-RVA: 0x313A70 Offset: 0x313B71 VA: 0x313A70
	|-Nullable<Quaternion>.Equals
	|
	|-RVA: 0x313EA0 Offset: 0x313FA1 VA: 0x313EA0
	|-Nullable<RangeInt>.Equals
	|
	|-RVA: 0x314170 Offset: 0x314271 VA: 0x314170
	|-Nullable<Rect>.Equals
	|
	|-RVA: 0x3145B0 Offset: 0x3146B1 VA: 0x3145B0
	|-Nullable<RectInt>.Equals
	|
	|-RVA: 0x3148E0 Offset: 0x3149E1 VA: 0x3148E0
	|-Nullable<Vector2>.Equals
	|
	|-RVA: 0x314C80 Offset: 0x314D81 VA: 0x314C80
	|-Nullable<Vector2Int>.Equals
	|
	|-RVA: 0x315000 Offset: 0x315101 VA: 0x315000
	|-Nullable<Vector3>.Equals
	|
	|-RVA: 0x3153A0 Offset: 0x3154A1 VA: 0x3153A0
	|-Nullable<Vector3Int>.Equals
	|
	|-RVA: 0x3157A0 Offset: 0x3158A1 VA: 0x3157A0
	|-Nullable<Vector4>.Equals
	*/

	// RVA: -1 Offset: -1
	private bool Equals(Nullable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30A660 Offset: 0x30A761 VA: 0x30A660
	|-Nullable<CropDataTable>.Equals
	|
	|-RVA: 0x30AAE0 Offset: 0x30ABE1 VA: 0x30AAE0
	|-Nullable<Nil>.Equals
	|
	|-RVA: 0x30AF30 Offset: 0x30B031 VA: 0x30AF30
	|-Nullable<ArraySegment<byte>>.Equals
	|
	|-RVA: 0x30B2E0 Offset: 0x30B3E1 VA: 0x30B2E0
	|-Nullable<bool>.Equals
	|
	|-RVA: 0x30B800 Offset: 0x30B901 VA: 0x30B800
	|-Nullable<ReadOnlySequence<byte>>.Equals
	|
	|-RVA: 0x30BCE0 Offset: 0x30BDE1 VA: 0x30BCE0
	|-Nullable<byte>.Equals
	|
	|-RVA: 0x30C050 Offset: 0x30C151 VA: 0x30C050
	|-Nullable<char>.Equals
	|
	|-RVA: 0x30C3B0 Offset: 0x30C4B1 VA: 0x30C3B0
	|-Nullable<DateTime>.Equals
	|
	|-RVA: 0x30C710 Offset: 0x30C811 VA: 0x30C710
	|-Nullable<DateTimeOffset>.Equals
	|
	|-RVA: 0x30CA90 Offset: 0x30CB91 VA: 0x30CA90
	|-Nullable<Decimal>.Equals
	|
	|-RVA: 0x30CE10 Offset: 0x30CF11 VA: 0x30CE10
	|-Nullable<double>.Equals
	|
	|-RVA: 0x30D170 Offset: 0x30D271 VA: 0x30D170
	|-Nullable<Guid>.Equals
	|
	|-RVA: 0x30D4E0 Offset: 0x30D5E1 VA: 0x30D4E0
	|-Nullable<short>.Equals
	|
	|-RVA: 0x30D840 Offset: 0x30D941 VA: 0x30D840
	|-Nullable<int>.Equals
	|
	|-RVA: 0x30DBA0 Offset: 0x30DCA1 VA: 0x30DBA0
	|-Nullable<Int32Enum>.Equals
	|
	|-RVA: 0x30DF10 Offset: 0x30E011 VA: 0x30DF10
	|-Nullable<long>.Equals
	|
	|-RVA: 0x30E350 Offset: 0x30E451 VA: 0x30E350
	|-Nullable<LocalDefinition>.Equals
	|
	|-RVA: 0x30E7F0 Offset: 0x30E8F1 VA: 0x30E7F0
	|-Nullable<Memory<byte>>.Equals
	|
	|-RVA: 0x30ED20 Offset: 0x30EE21 VA: 0x30ED20
	|-Nullable<BigInteger>.Equals
	|
	|-RVA: 0x30F130 Offset: 0x30F231 VA: 0x30F130
	|-Nullable<Complex>.Equals
	|
	|-RVA: 0x30F580 Offset: 0x30F681 VA: 0x30F580
	|-Nullable<ReadOnlyMemory<byte>>.Equals
	|
	|-RVA: 0x30F9C0 Offset: 0x30FAC1 VA: 0x30F9C0
	|-Nullable<Label>.Equals
	|
	|-RVA: 0x30FCC0 Offset: 0x30FDC1 VA: 0x30FCC0
	|-Nullable<sbyte>.Equals
	|
	|-RVA: 0x310110 Offset: 0x310211 VA: 0x310110
	|-Nullable<SequencePosition>.Equals
	|
	|-RVA: 0x3104E0 Offset: 0x3105E1 VA: 0x3104E0
	|-Nullable<float>.Equals
	|
	|-RVA: 0x310850 Offset: 0x310951 VA: 0x310850
	|-Nullable<TimeSpan>.Equals
	|
	|-RVA: 0x310BA0 Offset: 0x310CA1 VA: 0x310BA0
	|-Nullable<ushort>.Equals
	|
	|-RVA: 0x310F00 Offset: 0x311001 VA: 0x310F00
	|-Nullable<uint>.Equals
	|
	|-RVA: 0x311260 Offset: 0x311361 VA: 0x311260
	|-Nullable<ulong>.Equals
	|
	|-RVA: 0x311650 Offset: 0x311751 VA: 0x311650
	|-Nullable<Bounds>.Equals
	|
	|-RVA: 0x311B20 Offset: 0x311C21 VA: 0x311B20
	|-Nullable<BoundsInt>.Equals
	|
	|-RVA: 0x311F50 Offset: 0x312051 VA: 0x311F50
	|-Nullable<Color32>.Equals
	|
	|-RVA: 0x3122A0 Offset: 0x3123A1 VA: 0x3122A0
	|-Nullable<Color>.Equals
	|
	|-RVA: 0x3126C0 Offset: 0x3127C1 VA: 0x3126C0
	|-Nullable<GradientAlphaKey>.Equals
	|
	|-RVA: 0x312A00 Offset: 0x312B01 VA: 0x312A00
	|-Nullable<GradientColorKey>.Equals
	|
	|-RVA: 0x312E40 Offset: 0x312F41 VA: 0x312E40
	|-Nullable<Keyframe>.Equals
	|
	|-RVA: 0x3131D0 Offset: 0x3132D1 VA: 0x3131D0
	|-Nullable<LayerMask>.Equals
	|
	|-RVA: 0x313580 Offset: 0x313681 VA: 0x313580
	|-Nullable<Matrix4x4>.Equals
	|
	|-RVA: 0x313B10 Offset: 0x313C11 VA: 0x313B10
	|-Nullable<Quaternion>.Equals
	|
	|-RVA: 0x313F00 Offset: 0x314001 VA: 0x313F00
	|-Nullable<RangeInt>.Equals
	|
	|-RVA: 0x314210 Offset: 0x314311 VA: 0x314210
	|-Nullable<Rect>.Equals
	|
	|-RVA: 0x314610 Offset: 0x314711 VA: 0x314610
	|-Nullable<RectInt>.Equals
	|
	|-RVA: 0x314950 Offset: 0x314A51 VA: 0x314950
	|-Nullable<Vector2>.Equals
	|
	|-RVA: 0x314CE0 Offset: 0x314DE1 VA: 0x314CE0
	|-Nullable<Vector2Int>.Equals
	|
	|-RVA: 0x315090 Offset: 0x315191 VA: 0x315090
	|-Nullable<Vector3>.Equals
	|
	|-RVA: 0x315420 Offset: 0x315521 VA: 0x315420
	|-Nullable<Vector3Int>.Equals
	|
	|-RVA: 0x315840 Offset: 0x315941 VA: 0x315840
	|-Nullable<Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30A740 Offset: 0x30A841 VA: 0x30A740
	|-Nullable<CropDataTable>.GetHashCode
	|
	|-RVA: 0x30ABA0 Offset: 0x30ACA1 VA: 0x30ABA0
	|-Nullable<Nil>.GetHashCode
	|
	|-RVA: 0x30AFC0 Offset: 0x30B0C1 VA: 0x30AFC0
	|-Nullable<ArraySegment<byte>>.GetHashCode
	|
	|-RVA: 0x30B3A0 Offset: 0x30B4A1 VA: 0x30B3A0
	|-Nullable<bool>.GetHashCode
	|
	|-RVA: 0x30B8D0 Offset: 0x30B9D1 VA: 0x30B8D0
	|-Nullable<ReadOnlySequence<byte>>.GetHashCode
	|
	|-RVA: 0x30BDA0 Offset: 0x30BEA1 VA: 0x30BDA0
	|-Nullable<byte>.GetHashCode
	|
	|-RVA: 0x30C110 Offset: 0x30C211 VA: 0x30C110
	|-Nullable<char>.GetHashCode
	|
	|-RVA: 0x30C470 Offset: 0x30C571 VA: 0x30C470
	|-Nullable<DateTime>.GetHashCode
	|
	|-RVA: 0x30C7E0 Offset: 0x30C8E1 VA: 0x30C7E0
	|-Nullable<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x30CB60 Offset: 0x30CC61 VA: 0x30CB60
	|-Nullable<Decimal>.GetHashCode
	|
	|-RVA: 0x30CED0 Offset: 0x30CFD1 VA: 0x30CED0
	|-Nullable<double>.GetHashCode
	|
	|-RVA: 0x30D240 Offset: 0x30D341 VA: 0x30D240
	|-Nullable<Guid>.GetHashCode
	|
	|-RVA: 0x30D5A0 Offset: 0x30D6A1 VA: 0x30D5A0
	|-Nullable<short>.GetHashCode
	|
	|-RVA: 0x30D900 Offset: 0x30DA01 VA: 0x30D900
	|-Nullable<int>.GetHashCode
	|
	|-RVA: 0x30DC00 Offset: 0x30DD01 VA: 0x30DC00
	|-Nullable<Int32Enum>.GetHashCode
	|
	|-RVA: 0x30DFD0 Offset: 0x30E0D1 VA: 0x30DFD0
	|-Nullable<long>.GetHashCode
	|
	|-RVA: 0x30E450 Offset: 0x30E551 VA: 0x30E450
	|-Nullable<LocalDefinition>.GetHashCode
	|
	|-RVA: 0x30E880 Offset: 0x30E981 VA: 0x30E880
	|-Nullable<Memory<byte>>.GetHashCode
	|
	|-RVA: 0x30EE20 Offset: 0x30EF21 VA: 0x30EE20
	|-Nullable<BigInteger>.GetHashCode
	|
	|-RVA: 0x30F200 Offset: 0x30F301 VA: 0x30F200
	|-Nullable<Complex>.GetHashCode
	|
	|-RVA: 0x30F610 Offset: 0x30F711 VA: 0x30F610
	|-Nullable<ReadOnlyMemory<byte>>.GetHashCode
	|
	|-RVA: 0x30FA80 Offset: 0x30FB81 VA: 0x30FA80
	|-Nullable<Label>.GetHashCode
	|
	|-RVA: 0x30FD80 Offset: 0x30FE81 VA: 0x30FD80
	|-Nullable<sbyte>.GetHashCode
	|
	|-RVA: 0x310210 Offset: 0x310311 VA: 0x310210
	|-Nullable<SequencePosition>.GetHashCode
	|
	|-RVA: 0x3105A0 Offset: 0x3106A1 VA: 0x3105A0
	|-Nullable<float>.GetHashCode
	|
	|-RVA: 0x310910 Offset: 0x310A11 VA: 0x310910
	|-Nullable<TimeSpan>.GetHashCode
	|
	|-RVA: 0x310C60 Offset: 0x310D61 VA: 0x310C60
	|-Nullable<ushort>.GetHashCode
	|
	|-RVA: 0x310FC0 Offset: 0x3110C1 VA: 0x310FC0
	|-Nullable<uint>.GetHashCode
	|
	|-RVA: 0x311320 Offset: 0x311421 VA: 0x311320
	|-Nullable<ulong>.GetHashCode
	|
	|-RVA: 0x311760 Offset: 0x311861 VA: 0x311760
	|-Nullable<Bounds>.GetHashCode
	|
	|-RVA: 0x311C30 Offset: 0x311D31 VA: 0x311C30
	|-Nullable<BoundsInt>.GetHashCode
	|
	|-RVA: 0x311FB0 Offset: 0x3120B1 VA: 0x311FB0
	|-Nullable<Color32>.GetHashCode
	|
	|-RVA: 0x3123A0 Offset: 0x3124A1 VA: 0x3123A0
	|-Nullable<Color>.GetHashCode
	|
	|-RVA: 0x312730 Offset: 0x312831 VA: 0x312730
	|-Nullable<GradientAlphaKey>.GetHashCode
	|
	|-RVA: 0x312A90 Offset: 0x312B91 VA: 0x312A90
	|-Nullable<GradientColorKey>.GetHashCode
	|
	|-RVA: 0x312EF0 Offset: 0x312FF1 VA: 0x312EF0
	|-Nullable<Keyframe>.GetHashCode
	|
	|-RVA: 0x313230 Offset: 0x313331 VA: 0x313230
	|-Nullable<LayerMask>.GetHashCode
	|
	|-RVA: 0x3136E0 Offset: 0x3137E1 VA: 0x3136E0
	|-Nullable<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x313C10 Offset: 0x313D11 VA: 0x313C10
	|-Nullable<Quaternion>.GetHashCode
	|
	|-RVA: 0x313F60 Offset: 0x314061 VA: 0x313F60
	|-Nullable<RangeInt>.GetHashCode
	|
	|-RVA: 0x314310 Offset: 0x314411 VA: 0x314310
	|-Nullable<Rect>.GetHashCode
	|
	|-RVA: 0x314690 Offset: 0x314791 VA: 0x314690
	|-Nullable<RectInt>.GetHashCode
	|
	|-RVA: 0x314A20 Offset: 0x314B21 VA: 0x314A20
	|-Nullable<Vector2>.GetHashCode
	|
	|-RVA: 0x314DB0 Offset: 0x314EB1 VA: 0x314DB0
	|-Nullable<Vector2Int>.GetHashCode
	|
	|-RVA: 0x315120 Offset: 0x315221 VA: 0x315120
	|-Nullable<Vector3>.GetHashCode
	|
	|-RVA: 0x3154F0 Offset: 0x3155F1 VA: 0x3154F0
	|-Nullable<Vector3Int>.GetHashCode
	|
	|-RVA: 0x315940 Offset: 0x315A41 VA: 0x315940
	|-Nullable<Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public T GetValueOrDefault() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DCB0 Offset: 0x30DDB1 VA: 0x30DCB0
	|-Nullable<FarmManager.FARM_ID>.GetValueOrDefault
	|-Nullable<DefaultTabs>.GetValueOrDefault
	|-Nullable<Int32Enum>.GetValueOrDefault
	|
	|-RVA: 0x30B420 Offset: 0x30B521 VA: 0x30B420
	|-Nullable<bool>.GetValueOrDefault
	|
	|-RVA: 0x30B980 Offset: 0x30BA81 VA: 0x30B980
	|-Nullable<ReadOnlySequence<byte>>.GetValueOrDefault
	|
	|-RVA: 0x30D980 Offset: 0x30DA81 VA: 0x30D980
	|-Nullable<int>.GetValueOrDefault
	|
	|-RVA: 0x30E4D0 Offset: 0x30E5D1 VA: 0x30E4D0
	|-Nullable<LocalDefinition>.GetValueOrDefault
	|
	|-RVA: 0x3151B0 Offset: 0x3152B1 VA: 0x3151B0
	|-Nullable<Vector3>.GetValueOrDefault
	|
	|-RVA: 0x30A800 Offset: 0x30A901 VA: 0x30A800
	|-Nullable<CropDataTable>.GetValueOrDefault
	|
	|-RVA: 0x30AC20 Offset: 0x30AD21 VA: 0x30AC20
	|-Nullable<Nil>.GetValueOrDefault
	|
	|-RVA: 0x30B0A0 Offset: 0x30B1A1 VA: 0x30B0A0
	|-Nullable<ArraySegment<byte>>.GetValueOrDefault
	|
	|-RVA: 0x30BE20 Offset: 0x30BF21 VA: 0x30BE20
	|-Nullable<byte>.GetValueOrDefault
	|
	|-RVA: 0x30C190 Offset: 0x30C291 VA: 0x30C190
	|-Nullable<char>.GetValueOrDefault
	|
	|-RVA: 0x30C4E0 Offset: 0x30C5E1 VA: 0x30C4E0
	|-Nullable<DateTime>.GetValueOrDefault
	|
	|-RVA: 0x30C850 Offset: 0x30C951 VA: 0x30C850
	|-Nullable<DateTimeOffset>.GetValueOrDefault
	|
	|-RVA: 0x30CBD0 Offset: 0x30CCD1 VA: 0x30CBD0
	|-Nullable<Decimal>.GetValueOrDefault
	|
	|-RVA: 0x30CF40 Offset: 0x30D041 VA: 0x30CF40
	|-Nullable<double>.GetValueOrDefault
	|
	|-RVA: 0x30D2B0 Offset: 0x30D3B1 VA: 0x30D2B0
	|-Nullable<Guid>.GetValueOrDefault
	|
	|-RVA: 0x30D620 Offset: 0x30D721 VA: 0x30D620
	|-Nullable<short>.GetValueOrDefault
	|
	|-RVA: 0x30E040 Offset: 0x30E141 VA: 0x30E040
	|-Nullable<long>.GetValueOrDefault
	|
	|-RVA: 0x30E960 Offset: 0x30EA61 VA: 0x30E960
	|-Nullable<Memory<byte>>.GetValueOrDefault
	|
	|-RVA: 0x30EEA0 Offset: 0x30EFA1 VA: 0x30EEA0
	|-Nullable<BigInteger>.GetValueOrDefault
	|
	|-RVA: 0x30F270 Offset: 0x30F371 VA: 0x30F270
	|-Nullable<Complex>.GetValueOrDefault
	|
	|-RVA: 0x30F6F0 Offset: 0x30F7F1 VA: 0x30F6F0
	|-Nullable<ReadOnlyMemory<byte>>.GetValueOrDefault
	|
	|-RVA: 0x30FB00 Offset: 0x30FC01 VA: 0x30FB00
	|-Nullable<Label>.GetValueOrDefault
	|
	|-RVA: 0x30FE00 Offset: 0x30FF01 VA: 0x30FE00
	|-Nullable<sbyte>.GetValueOrDefault
	|
	|-RVA: 0x310290 Offset: 0x310391 VA: 0x310290
	|-Nullable<SequencePosition>.GetValueOrDefault
	|
	|-RVA: 0x310620 Offset: 0x310721 VA: 0x310620
	|-Nullable<float>.GetValueOrDefault
	|
	|-RVA: 0x310980 Offset: 0x310A81 VA: 0x310980
	|-Nullable<TimeSpan>.GetValueOrDefault
	|
	|-RVA: 0x310CE0 Offset: 0x310DE1 VA: 0x310CE0
	|-Nullable<ushort>.GetValueOrDefault
	|
	|-RVA: 0x311040 Offset: 0x311141 VA: 0x311040
	|-Nullable<uint>.GetValueOrDefault
	|
	|-RVA: 0x311390 Offset: 0x311491 VA: 0x311390
	|-Nullable<ulong>.GetValueOrDefault
	|
	|-RVA: 0x3117F0 Offset: 0x3118F1 VA: 0x3117F0
	|-Nullable<Bounds>.GetValueOrDefault
	|
	|-RVA: 0x311CC0 Offset: 0x311DC1 VA: 0x311CC0
	|-Nullable<BoundsInt>.GetValueOrDefault
	|
	|-RVA: 0x312000 Offset: 0x312101 VA: 0x312000
	|-Nullable<Color32>.GetValueOrDefault
	|
	|-RVA: 0x312430 Offset: 0x312531 VA: 0x312430
	|-Nullable<Color>.GetValueOrDefault
	|
	|-RVA: 0x312790 Offset: 0x312891 VA: 0x312790
	|-Nullable<GradientAlphaKey>.GetValueOrDefault
	|
	|-RVA: 0x312B10 Offset: 0x312C11 VA: 0x312B10
	|-Nullable<GradientColorKey>.GetValueOrDefault
	|
	|-RVA: 0x312F80 Offset: 0x313081 VA: 0x312F80
	|-Nullable<Keyframe>.GetValueOrDefault
	|
	|-RVA: 0x313280 Offset: 0x313381 VA: 0x313280
	|-Nullable<LayerMask>.GetValueOrDefault
	|
	|-RVA: 0x3137A0 Offset: 0x3138A1 VA: 0x3137A0
	|-Nullable<Matrix4x4>.GetValueOrDefault
	|
	|-RVA: 0x313CA0 Offset: 0x313DA1 VA: 0x313CA0
	|-Nullable<Quaternion>.GetValueOrDefault
	|
	|-RVA: 0x313FC0 Offset: 0x3140C1 VA: 0x313FC0
	|-Nullable<RangeInt>.GetValueOrDefault
	|
	|-RVA: 0x3143A0 Offset: 0x3144A1 VA: 0x3143A0
	|-Nullable<Rect>.GetValueOrDefault
	|
	|-RVA: 0x3146F0 Offset: 0x3147F1 VA: 0x3146F0
	|-Nullable<RectInt>.GetValueOrDefault
	|
	|-RVA: 0x314AA0 Offset: 0x314BA1 VA: 0x314AA0
	|-Nullable<Vector2>.GetValueOrDefault
	|
	|-RVA: 0x314E20 Offset: 0x314F21 VA: 0x314E20
	|-Nullable<Vector2Int>.GetValueOrDefault
	|
	|-RVA: 0x315580 Offset: 0x315681 VA: 0x315580
	|-Nullable<Vector3Int>.GetValueOrDefault
	|
	|-RVA: 0x3159D0 Offset: 0x315AD1 VA: 0x3159D0
	|-Nullable<Vector4>.GetValueOrDefault
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30A8C0 Offset: 0x30A9C1 VA: 0x30A8C0
	|-Nullable<CropDataTable>.ToString
	|
	|-RVA: 0x30AC30 Offset: 0x30AD31 VA: 0x30AC30
	|-Nullable<Nil>.ToString
	|
	|-RVA: 0x30B100 Offset: 0x30B201 VA: 0x30B100
	|-Nullable<ArraySegment<byte>>.ToString
	|
	|-RVA: 0x30B430 Offset: 0x30B531 VA: 0x30B430
	|-Nullable<bool>.ToString
	|
	|-RVA: 0x30BA30 Offset: 0x30BB31 VA: 0x30BA30
	|-Nullable<ReadOnlySequence<byte>>.ToString
	|
	|-RVA: 0x30BE30 Offset: 0x30BF31 VA: 0x30BE30
	|-Nullable<byte>.ToString
	|
	|-RVA: 0x30C1A0 Offset: 0x30C2A1 VA: 0x30C1A0
	|-Nullable<char>.ToString
	|
	|-RVA: 0x30C4F0 Offset: 0x30C5F1 VA: 0x30C4F0
	|-Nullable<DateTime>.ToString
	|
	|-RVA: 0x30C860 Offset: 0x30C961 VA: 0x30C860
	|-Nullable<DateTimeOffset>.ToString
	|
	|-RVA: 0x30CBE0 Offset: 0x30CCE1 VA: 0x30CBE0
	|-Nullable<Decimal>.ToString
	|
	|-RVA: 0x30CF50 Offset: 0x30D051 VA: 0x30CF50
	|-Nullable<double>.ToString
	|
	|-RVA: 0x30D2C0 Offset: 0x30D3C1 VA: 0x30D2C0
	|-Nullable<Guid>.ToString
	|
	|-RVA: 0x30D630 Offset: 0x30D731 VA: 0x30D630
	|-Nullable<short>.ToString
	|
	|-RVA: 0x30D990 Offset: 0x30DA91 VA: 0x30D990
	|-Nullable<int>.ToString
	|
	|-RVA: 0x30DCC0 Offset: 0x30DDC1 VA: 0x30DCC0
	|-Nullable<Int32Enum>.ToString
	|
	|-RVA: 0x30E050 Offset: 0x30E151 VA: 0x30E050
	|-Nullable<long>.ToString
	|
	|-RVA: 0x30E530 Offset: 0x30E631 VA: 0x30E530
	|-Nullable<LocalDefinition>.ToString
	|
	|-RVA: 0x30E9C0 Offset: 0x30EAC1 VA: 0x30E9C0
	|-Nullable<Memory<byte>>.ToString
	|
	|-RVA: 0x30EF00 Offset: 0x30F001 VA: 0x30EF00
	|-Nullable<BigInteger>.ToString
	|
	|-RVA: 0x30F280 Offset: 0x30F381 VA: 0x30F280
	|-Nullable<Complex>.ToString
	|
	|-RVA: 0x30F750 Offset: 0x30F851 VA: 0x30F750
	|-Nullable<ReadOnlyMemory<byte>>.ToString
	|
	|-RVA: 0x30FB10 Offset: 0x30FC11 VA: 0x30FB10
	|-Nullable<Label>.ToString
	|
	|-RVA: 0x30FE10 Offset: 0x30FF11 VA: 0x30FE10
	|-Nullable<sbyte>.ToString
	|
	|-RVA: 0x3102F0 Offset: 0x3103F1 VA: 0x3102F0
	|-Nullable<SequencePosition>.ToString
	|
	|-RVA: 0x310630 Offset: 0x310731 VA: 0x310630
	|-Nullable<float>.ToString
	|
	|-RVA: 0x310990 Offset: 0x310A91 VA: 0x310990
	|-Nullable<TimeSpan>.ToString
	|
	|-RVA: 0x310CF0 Offset: 0x310DF1 VA: 0x310CF0
	|-Nullable<ushort>.ToString
	|
	|-RVA: 0x311050 Offset: 0x311151 VA: 0x311050
	|-Nullable<uint>.ToString
	|
	|-RVA: 0x3113A0 Offset: 0x3114A1 VA: 0x3113A0
	|-Nullable<ulong>.ToString
	|
	|-RVA: 0x311840 Offset: 0x311941 VA: 0x311840
	|-Nullable<Bounds>.ToString
	|
	|-RVA: 0x311D10 Offset: 0x311E11 VA: 0x311D10
	|-Nullable<BoundsInt>.ToString
	|
	|-RVA: 0x312010 Offset: 0x312111 VA: 0x312010
	|-Nullable<Color32>.ToString
	|
	|-RVA: 0x312440 Offset: 0x312541 VA: 0x312440
	|-Nullable<Color>.ToString
	|
	|-RVA: 0x3127A0 Offset: 0x3128A1 VA: 0x3127A0
	|-Nullable<GradientAlphaKey>.ToString
	|
	|-RVA: 0x312B60 Offset: 0x312C61 VA: 0x312B60
	|-Nullable<GradientColorKey>.ToString
	|
	|-RVA: 0x312FE0 Offset: 0x3130E1 VA: 0x312FE0
	|-Nullable<Keyframe>.ToString
	|
	|-RVA: 0x313290 Offset: 0x313391 VA: 0x313290
	|-Nullable<LayerMask>.ToString
	|
	|-RVA: 0x313820 Offset: 0x313921 VA: 0x313820
	|-Nullable<Matrix4x4>.ToString
	|
	|-RVA: 0x313CB0 Offset: 0x313DB1 VA: 0x313CB0
	|-Nullable<Quaternion>.ToString
	|
	|-RVA: 0x313FD0 Offset: 0x3140D1 VA: 0x313FD0
	|-Nullable<RangeInt>.ToString
	|
	|-RVA: 0x3143B0 Offset: 0x3144B1 VA: 0x3143B0
	|-Nullable<Rect>.ToString
	|
	|-RVA: 0x314700 Offset: 0x314801 VA: 0x314700
	|-Nullable<RectInt>.ToString
	|
	|-RVA: 0x314AB0 Offset: 0x314BB1 VA: 0x314AB0
	|-Nullable<Vector2>.ToString
	|
	|-RVA: 0x314E30 Offset: 0x314F31 VA: 0x314E30
	|-Nullable<Vector2Int>.ToString
	|
	|-RVA: 0x3151C0 Offset: 0x3152C1 VA: 0x3151C0
	|-Nullable<Vector3>.ToString
	|
	|-RVA: 0x315590 Offset: 0x315691 VA: 0x315590
	|-Nullable<Vector3Int>.ToString
	|
	|-RVA: 0x3159E0 Offset: 0x315AE1 VA: 0x3159E0
	|-Nullable<Vector4>.ToString
	*/

	// RVA: -1 Offset: -1
	private static object Box(Nullable<T> o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x244BDD0 Offset: 0x244BED1 VA: 0x244BDD0
	|-Nullable<CropDataTable>.Box
	|
	|-RVA: 0x244C350 Offset: 0x244C451 VA: 0x244C350
	|-Nullable<Nil>.Box
	|
	|-RVA: 0x244C900 Offset: 0x244CA01 VA: 0x244C900
	|-Nullable<ArraySegment<byte>>.Box
	|
	|-RVA: 0x244CDF0 Offset: 0x244CEF1 VA: 0x244CDF0
	|-Nullable<bool>.Box
	|
	|-RVA: 0x244D430 Offset: 0x244D531 VA: 0x244D430
	|-Nullable<ReadOnlySequence<byte>>.Box
	|
	|-RVA: 0x244D940 Offset: 0x244DA41 VA: 0x244D940
	|-Nullable<byte>.Box
	|
	|-RVA: 0x244DDE0 Offset: 0x244DEE1 VA: 0x244DDE0
	|-Nullable<char>.Box
	|
	|-RVA: 0x244E290 Offset: 0x244E391 VA: 0x244E290
	|-Nullable<DateTime>.Box
	|
	|-RVA: 0x244E750 Offset: 0x244E851 VA: 0x244E750
	|-Nullable<DateTimeOffset>.Box
	|
	|-RVA: 0x244EC40 Offset: 0x244ED41 VA: 0x244EC40
	|-Nullable<Decimal>.Box
	|
	|-RVA: 0x244F120 Offset: 0x244F221 VA: 0x244F120
	|-Nullable<double>.Box
	|
	|-RVA: 0x244F5E0 Offset: 0x244F6E1 VA: 0x244F5E0
	|-Nullable<Guid>.Box
	|
	|-RVA: 0x244FAB0 Offset: 0x244FBB1 VA: 0x244FAB0
	|-Nullable<short>.Box
	|
	|-RVA: 0x244FF50 Offset: 0x2450051 VA: 0x244FF50
	|-Nullable<int>.Box
	|
	|-RVA: 0x2450490 Offset: 0x2450591 VA: 0x2450490
	|-Nullable<Int32Enum>.Box
	|
	|-RVA: 0x2450940 Offset: 0x2450A41 VA: 0x2450940
	|-Nullable<long>.Box
	|
	|-RVA: 0x2450EA0 Offset: 0x2450FA1 VA: 0x2450EA0
	|-Nullable<LocalDefinition>.Box
	|
	|-RVA: 0x2451460 Offset: 0x2451561 VA: 0x2451460
	|-Nullable<Memory<byte>>.Box
	|
	|-RVA: 0x2451970 Offset: 0x2451A71 VA: 0x2451970
	|-Nullable<BigInteger>.Box
	|
	|-RVA: 0x2451E80 Offset: 0x2451F81 VA: 0x2451E80
	|-Nullable<Complex>.Box
	|
	|-RVA: 0x2452430 Offset: 0x2452531 VA: 0x2452430
	|-Nullable<ReadOnlyMemory<byte>>.Box
	|
	|-RVA: 0x24529A0 Offset: 0x2452AA1 VA: 0x24529A0
	|-Nullable<Label>.Box
	|
	|-RVA: 0x2452E40 Offset: 0x2452F41 VA: 0x2452E40
	|-Nullable<sbyte>.Box
	|
	|-RVA: 0x24533A0 Offset: 0x24534A1 VA: 0x24533A0
	|-Nullable<SequencePosition>.Box
	|
	|-RVA: 0x2453880 Offset: 0x2453981 VA: 0x2453880
	|-Nullable<float>.Box
	|
	|-RVA: 0x2453D30 Offset: 0x2453E31 VA: 0x2453D30
	|-Nullable<TimeSpan>.Box
	|
	|-RVA: 0x24541D0 Offset: 0x24542D1 VA: 0x24541D0
	|-Nullable<ushort>.Box
	|
	|-RVA: 0x2454670 Offset: 0x2454771 VA: 0x2454670
	|-Nullable<uint>.Box
	|
	|-RVA: 0x2454B20 Offset: 0x2454C21 VA: 0x2454B20
	|-Nullable<ulong>.Box
	|
	|-RVA: 0x2455020 Offset: 0x2455121 VA: 0x2455020
	|-Nullable<Bounds>.Box
	|
	|-RVA: 0x2455580 Offset: 0x2455681 VA: 0x2455580
	|-Nullable<BoundsInt>.Box
	|
	|-RVA: 0x2455B40 Offset: 0x2455C41 VA: 0x2455B40
	|-Nullable<Color32>.Box
	|
	|-RVA: 0x2455FA0 Offset: 0x24560A1 VA: 0x2455FA0
	|-Nullable<Color>.Box
	|
	|-RVA: 0x2456600 Offset: 0x2456701 VA: 0x2456600
	|-Nullable<GradientAlphaKey>.Box
	|
	|-RVA: 0x2456C70 Offset: 0x2456D71 VA: 0x2456C70
	|-Nullable<GradientColorKey>.Box
	|
	|-RVA: 0x2457370 Offset: 0x2457471 VA: 0x2457370
	|-Nullable<Keyframe>.Box
	|
	|-RVA: 0x24579D0 Offset: 0x2457AD1 VA: 0x24579D0
	|-Nullable<LayerMask>.Box
	|
	|-RVA: 0x2457F20 Offset: 0x2458021 VA: 0x2457F20
	|-Nullable<Matrix4x4>.Box
	|
	|-RVA: 0x2458410 Offset: 0x2458511 VA: 0x2458410
	|-Nullable<Quaternion>.Box
	|
	|-RVA: 0x2458A60 Offset: 0x2458B61 VA: 0x2458A60
	|-Nullable<RangeInt>.Box
	|
	|-RVA: 0x2458EC0 Offset: 0x2458FC1 VA: 0x2458EC0
	|-Nullable<Rect>.Box
	|
	|-RVA: 0x2459490 Offset: 0x2459591 VA: 0x2459490
	|-Nullable<RectInt>.Box
	|
	|-RVA: 0x2459920 Offset: 0x2459A21 VA: 0x2459920
	|-Nullable<Vector2>.Box
	|
	|-RVA: 0x2459DF0 Offset: 0x2459EF1 VA: 0x2459DF0
	|-Nullable<Vector2Int>.Box
	|
	|-RVA: 0x245A250 Offset: 0x245A351 VA: 0x245A250
	|-Nullable<Vector3>.Box
	|
	|-RVA: 0x245A6D0 Offset: 0x245A7D1 VA: 0x245A6D0
	|-Nullable<Vector3Int>.Box
	|
	|-RVA: 0x245AB40 Offset: 0x245AC41 VA: 0x245AB40
	|-Nullable<Vector4>.Box
	*/

	// RVA: -1 Offset: -1
	private static Nullable<T> Unbox(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x244BE50 Offset: 0x244BF51 VA: 0x244BE50
	|-Nullable<CropDataTable>.Unbox
	|
	|-RVA: 0x244C3C0 Offset: 0x244C4C1 VA: 0x244C3C0
	|-Nullable<Nil>.Unbox
	|
	|-RVA: 0x244C970 Offset: 0x244CA71 VA: 0x244C970
	|-Nullable<ArraySegment<byte>>.Unbox
	|
	|-RVA: 0x244CE60 Offset: 0x244CF61 VA: 0x244CE60
	|-Nullable<bool>.Unbox
	|
	|-RVA: 0x244D4B0 Offset: 0x244D5B1 VA: 0x244D4B0
	|-Nullable<ReadOnlySequence<byte>>.Unbox
	|
	|-RVA: 0x244D9B0 Offset: 0x244DAB1 VA: 0x244D9B0
	|-Nullable<byte>.Unbox
	|
	|-RVA: 0x244DE50 Offset: 0x244DF51 VA: 0x244DE50
	|-Nullable<char>.Unbox
	|
	|-RVA: 0x244E300 Offset: 0x244E401 VA: 0x244E300
	|-Nullable<DateTime>.Unbox
	|
	|-RVA: 0x244E7C0 Offset: 0x244E8C1 VA: 0x244E7C0
	|-Nullable<DateTimeOffset>.Unbox
	|
	|-RVA: 0x244ECB0 Offset: 0x244EDB1 VA: 0x244ECB0
	|-Nullable<Decimal>.Unbox
	|
	|-RVA: 0x244F190 Offset: 0x244F291 VA: 0x244F190
	|-Nullable<double>.Unbox
	|
	|-RVA: 0x244F650 Offset: 0x244F751 VA: 0x244F650
	|-Nullable<Guid>.Unbox
	|
	|-RVA: 0x244FB20 Offset: 0x244FC21 VA: 0x244FB20
	|-Nullable<short>.Unbox
	|
	|-RVA: 0x244FFC0 Offset: 0x24500C1 VA: 0x244FFC0
	|-Nullable<int>.Unbox
	|
	|-RVA: 0x2450500 Offset: 0x2450601 VA: 0x2450500
	|-Nullable<Int32Enum>.Unbox
	|
	|-RVA: 0x24509B0 Offset: 0x2450AB1 VA: 0x24509B0
	|-Nullable<long>.Unbox
	|
	|-RVA: 0x2450F10 Offset: 0x2451011 VA: 0x2450F10
	|-Nullable<LocalDefinition>.Unbox
	|
	|-RVA: 0x24514D0 Offset: 0x24515D1 VA: 0x24514D0
	|-Nullable<Memory<byte>>.Unbox
	|
	|-RVA: 0x24519E0 Offset: 0x2451AE1 VA: 0x24519E0
	|-Nullable<BigInteger>.Unbox
	|
	|-RVA: 0x2451EF0 Offset: 0x2451FF1 VA: 0x2451EF0
	|-Nullable<Complex>.Unbox
	|
	|-RVA: 0x24524A0 Offset: 0x24525A1 VA: 0x24524A0
	|-Nullable<ReadOnlyMemory<byte>>.Unbox
	|
	|-RVA: 0x2452A10 Offset: 0x2452B11 VA: 0x2452A10
	|-Nullable<Label>.Unbox
	|
	|-RVA: 0x2452EB0 Offset: 0x2452FB1 VA: 0x2452EB0
	|-Nullable<sbyte>.Unbox
	|
	|-RVA: 0x2453410 Offset: 0x2453511 VA: 0x2453410
	|-Nullable<SequencePosition>.Unbox
	|
	|-RVA: 0x24538F0 Offset: 0x24539F1 VA: 0x24538F0
	|-Nullable<float>.Unbox
	|
	|-RVA: 0x2453DA0 Offset: 0x2453EA1 VA: 0x2453DA0
	|-Nullable<TimeSpan>.Unbox
	|
	|-RVA: 0x2454240 Offset: 0x2454341 VA: 0x2454240
	|-Nullable<ushort>.Unbox
	|
	|-RVA: 0x24546E0 Offset: 0x24547E1 VA: 0x24546E0
	|-Nullable<uint>.Unbox
	|
	|-RVA: 0x2454B90 Offset: 0x2454C91 VA: 0x2454B90
	|-Nullable<ulong>.Unbox
	|
	|-RVA: 0x24550A0 Offset: 0x24551A1 VA: 0x24550A0
	|-Nullable<Bounds>.Unbox
	|
	|-RVA: 0x2455600 Offset: 0x2455701 VA: 0x2455600
	|-Nullable<BoundsInt>.Unbox
	|
	|-RVA: 0x2455BB0 Offset: 0x2455CB1 VA: 0x2455BB0
	|-Nullable<Color32>.Unbox
	|
	|-RVA: 0x2456020 Offset: 0x2456121 VA: 0x2456020
	|-Nullable<Color>.Unbox
	|
	|-RVA: 0x2456670 Offset: 0x2456771 VA: 0x2456670
	|-Nullable<GradientAlphaKey>.Unbox
	|
	|-RVA: 0x2456CF0 Offset: 0x2456DF1 VA: 0x2456CF0
	|-Nullable<GradientColorKey>.Unbox
	|
	|-RVA: 0x24573F0 Offset: 0x24574F1 VA: 0x24573F0
	|-Nullable<Keyframe>.Unbox
	|
	|-RVA: 0x2457A40 Offset: 0x2457B41 VA: 0x2457A40
	|-Nullable<LayerMask>.Unbox
	|
	|-RVA: 0x2457FB0 Offset: 0x24580B1 VA: 0x2457FB0
	|-Nullable<Matrix4x4>.Unbox
	|
	|-RVA: 0x2458490 Offset: 0x2458591 VA: 0x2458490
	|-Nullable<Quaternion>.Unbox
	|
	|-RVA: 0x2458AD0 Offset: 0x2458BD1 VA: 0x2458AD0
	|-Nullable<RangeInt>.Unbox
	|
	|-RVA: 0x2458F40 Offset: 0x2459041 VA: 0x2458F40
	|-Nullable<Rect>.Unbox
	|
	|-RVA: 0x2459500 Offset: 0x2459601 VA: 0x2459500
	|-Nullable<RectInt>.Unbox
	|
	|-RVA: 0x2459990 Offset: 0x2459A91 VA: 0x2459990
	|-Nullable<Vector2>.Unbox
	|
	|-RVA: 0x2459E60 Offset: 0x2459F61 VA: 0x2459E60
	|-Nullable<Vector2Int>.Unbox
	|
	|-RVA: 0x245A2D0 Offset: 0x245A3D1 VA: 0x245A2D0
	|-Nullable<Vector3>.Unbox
	|
	|-RVA: 0x245A740 Offset: 0x245A841 VA: 0x245A740
	|-Nullable<Vector3Int>.Unbox
	|
	|-RVA: 0x245ABC0 Offset: 0x245ACC1 VA: 0x245ABC0
	|-Nullable<Vector4>.Unbox
	*/
}

