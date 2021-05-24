public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable // TypeDefIndex: 120
{
	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public long LongLength { get; }
	public bool IsFixedSize { get; }
	public bool IsReadOnly { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public int Length { get; }
	public int Rank { get; }

	// Methods

	// RVA: 0x1848B50 Offset: 0x1848C51 VA: 0x1848B50
	public static Array CreateInstance(Type elementType, long[] lengths) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AB100 Offset: 0x21AB201 VA: 0x21AB100
	|-Array.AsReadOnly<object>
	|-Array.AsReadOnly<CustomAttributeData>
	|
	|-RVA: 0x21AB1D0 Offset: 0x21AB2D1 VA: 0x21AB1D0
	|-Array.AsReadOnly<CustomAttributeNamedArgument>
	|
	|-RVA: 0x21AB2A0 Offset: 0x21AB3A1 VA: 0x21AB2A0
	|-Array.AsReadOnly<CustomAttributeTypedArgument>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2653E70 Offset: 0x2653F71 VA: 0x2653E70
	|-Array.Resize<Tween>
	|-Array.Resize<EventData>
	|-Array.Resize<EventScheduleData>
	|-Array.Resize<AutomataDictionary.AutomataNode>
	|-Array.Resize<BakerTransform>
	|-Array.Resize<Finger>
	|-Array.Resize<GenericPoser.Map>
	|-Array.Resize<IKSolver.Point>
	|-Array.Resize<object>
	|-Array.Resize<string>
	|-Array.Resize<Type>
	|-Array.Resize<Camera>
	|-Array.Resize<Texture2D>
	|-Array.Resize<Transform>
	|
	|-RVA: 0x2653790 Offset: 0x2653891 VA: 0x2653790
	|-Array.Resize<DamageTextInfo>
	|
	|-RVA: 0x26538F0 Offset: 0x26539F1 VA: 0x26538F0
	|-Array.Resize<char>
	|
	|-RVA: 0x2653A50 Offset: 0x2653B51 VA: 0x2653A50
	|-Array.Resize<KeyValuePair<object, object>>
	|
	|-RVA: 0x2653BB0 Offset: 0x2653CB1 VA: 0x2653BB0
	|-Array.Resize<int>
	|
	|-RVA: 0x2653D10 Offset: 0x2653E11 VA: 0x2653D10
	|-Array.Resize<Int32Enum>
	|
	|-RVA: 0x2653FD0 Offset: 0x26540D1 VA: 0x2653FD0
	|-Array.Resize<float>
	|
	|-RVA: 0x2654130 Offset: 0x2654231 VA: 0x2654130
	|-Array.Resize<uint>
	|
	|-RVA: 0x2654290 Offset: 0x2654391 VA: 0x2654290
	|-Array.Resize<ulong>
	|
	|-RVA: 0x26543F0 Offset: 0x26544F1 VA: 0x26543F0
	|-Array.Resize<HighlightState>
	|
	|-RVA: 0x2654550 Offset: 0x2654651 VA: 0x2654550
	|-Array.Resize<MaterialReference>
	|
	|-RVA: 0x26546B0 Offset: 0x26547B1 VA: 0x26546B0
	|-Array.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x2654810 Offset: 0x2654911 VA: 0x2654810
	|-Array.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x2654970 Offset: 0x2654A71 VA: 0x2654970
	|-Array.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x2654AD0 Offset: 0x2654BD1 VA: 0x2654AD0
	|-Array.Resize<TMP_PageInfo>
	|
	|-RVA: 0x2654C30 Offset: 0x2654D31 VA: 0x2654C30
	|-Array.Resize<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x2654D90 Offset: 0x2654E91 VA: 0x2654D90
	|-Array.Resize<TMP_WordInfo>
	|
	|-RVA: 0x2654EF0 Offset: 0x2654FF1 VA: 0x2654EF0
	|-Array.Resize<WordWrapState>
	|
	|-RVA: 0x2655050 Offset: 0x2655151 VA: 0x2655050
	|-Array.Resize<Color32>
	|
	|-RVA: 0x26551B0 Offset: 0x26552B1 VA: 0x26551B0
	|-Array.Resize<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x2655310 Offset: 0x2655411 VA: 0x2655310
	|-Array.Resize<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x2655470 Offset: 0x2655571 VA: 0x2655470
	|-Array.Resize<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x26555D0 Offset: 0x26556D1 VA: 0x26555D0
	|-Array.Resize<EventDispatcher.EventRecord>
	|
	|-RVA: 0x2655730 Offset: 0x2655831 VA: 0x2655730
	|-Array.Resize<Vector2>
	|
	|-RVA: 0x2655890 Offset: 0x2655991 VA: 0x2655890
	|-Array.Resize<Vector3>
	|
	|-RVA: 0x26559F0 Offset: 0x2655AF1 VA: 0x26559F0
	|-Array.Resize<Vector4>
	*/

	// RVA: 0x1848F50 Offset: 0x1849051 VA: 0x1848F50 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1849030 Offset: 0x1849131 VA: 0x1849030 Slot: 12
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1849040 Offset: 0x1849141 VA: 0x1849040 Slot: 7
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x18491E0 Offset: 0x18492E1 VA: 0x18491E0 Slot: 8
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1849390 Offset: 0x1849491 VA: 0x1849390 Slot: 9
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1849400 Offset: 0x1849501 VA: 0x1849400 Slot: 10
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1849520 Offset: 0x1849621 VA: 0x1849520 Slot: 11
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1849740 Offset: 0x1849841 VA: 0x1849740 Slot: 13
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1849750 Offset: 0x1849851 VA: 0x1849750 Slot: 14
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x18497C0 Offset: 0x18498C1 VA: 0x18497C0 Slot: 15
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1849830 Offset: 0x1849931 VA: 0x1849830 Slot: 16
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x18498A0 Offset: 0x18499A1 VA: 0x18498A0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1849F10 Offset: 0x184A011 VA: 0x1849F10 Slot: 20
	public object Clone() { }

	// RVA: 0x1849F20 Offset: 0x184A021 VA: 0x1849F20 Slot: 17
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: 0x184A210 Offset: 0x184A311 VA: 0x184A210 Slot: 18
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: 0x184A4D0 Offset: 0x184A5D1 VA: 0x184A4D0
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x184A4E0 Offset: 0x184A5E1 VA: 0x184A4E0 Slot: 19
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x184A710 Offset: 0x184A811 VA: 0x184A710
	public static int BinarySearch(Array array, object value) { }

	// RVA: -1 Offset: -1
	public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2268200 Offset: 0x2268301 VA: 0x2268200
	|-Array.ConvertAll<object, object>
	*/

	// RVA: 0x184AD40 Offset: 0x184AE41 VA: 0x184AD40
	public static void Copy(Array sourceArray, Array destinationArray, long length) { }

	// RVA: 0x184AED0 Offset: 0x184AFD1 VA: 0x184AED0
	public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length) { }

	// RVA: 0x184AFE0 Offset: 0x184B0E1 VA: 0x184AFE0
	public void CopyTo(Array array, long index) { }

	// RVA: -1 Offset: -1
	public static void ForEach<T>(T[] array, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D8C10 Offset: 0x21D8D11 VA: 0x21D8C10
	|-Array.ForEach<object>
	*/

	// RVA: 0x184B090 Offset: 0x184B191 VA: 0x184B090
	public long get_LongLength() { }

	// RVA: 0x184B110 Offset: 0x184B211 VA: 0x184B110
	public long GetLongLength(int dimension) { }

	// RVA: 0x184B130 Offset: 0x184B231 VA: 0x184B130
	public object GetValue(long index) { }

	// RVA: 0x184B1D0 Offset: 0x184B2D1 VA: 0x184B1D0
	public object GetValue(long index1, long index2) { }

	// RVA: 0x184B340 Offset: 0x184B441 VA: 0x184B340
	public object GetValue(long index1, long index2, long index3) { }

	// RVA: 0x184B4F0 Offset: 0x184B5F1 VA: 0x184B4F0
	public object GetValue(long[] indices) { }

	// RVA: 0x184B680 Offset: 0x184B781 VA: 0x184B680 Slot: 21
	public bool get_IsFixedSize() { }

	// RVA: 0x184B690 Offset: 0x184B791 VA: 0x184B690 Slot: 22
	public bool get_IsReadOnly() { }

	// RVA: 0x184B6A0 Offset: 0x184B7A1 VA: 0x184B6A0 Slot: 23
	public bool get_IsSynchronized() { }

	// RVA: 0x184B6B0 Offset: 0x184B7B1 VA: 0x184B6B0 Slot: 24
	public object get_SyncRoot() { }

	// RVA: 0x184B6C0 Offset: 0x184B7C1 VA: 0x184B6C0
	public static int BinarySearch(Array array, int index, int length, object value) { }

	// RVA: 0x184B6D0 Offset: 0x184B7D1 VA: 0x184B6D0
	public static int BinarySearch(Array array, object value, IComparer comparer) { }

	// RVA: 0x184A810 Offset: 0x184A911 VA: 0x184A810
	public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer) { }

	// RVA: 0x184B7D0 Offset: 0x184B8D1 VA: 0x184B7D0
	private static int GetMedian(int low, int hi) { }

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B1830 Offset: 0x21B1931 VA: 0x21B1830
	|-Array.BinarySearch<object>
	|-Array.BinarySearch<string>
	|
	|-RVA: 0x21B1B30 Offset: 0x21B1C31 VA: 0x21B1B30
	|-Array.BinarySearch<ulong>
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B18E0 Offset: 0x21B19E1 VA: 0x21B18E0
	|-Array.BinarySearch<DebugInfo>
	|-Array.BinarySearch<object>
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, int index, int length, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B16A0 Offset: 0x21B17A1 VA: 0x21B16A0
	|-Array.BinarySearch<object>
	|
	|-RVA: 0x21B19A0 Offset: 0x21B1AA1 VA: 0x21B19A0
	|-Array.BinarySearch<ulong>
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B16C0 Offset: 0x21B17C1 VA: 0x21B16C0
	|-Array.BinarySearch<object>
	|
	|-RVA: 0x21B19C0 Offset: 0x21B1AC1 VA: 0x21B19C0
	|-Array.BinarySearch<ulong>
	*/

	// RVA: 0x1849420 Offset: 0x1849521 VA: 0x1849420
	public static int IndexOf(Array array, object value) { }

	// RVA: 0x184BB10 Offset: 0x184BC11 VA: 0x184BB10
	public static int IndexOf(Array array, object value, int startIndex) { }

	// RVA: 0x184B7E0 Offset: 0x184B8E1 VA: 0x184B7E0
	public static int IndexOf(Array array, object value, int startIndex, int count) { }

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2616810 Offset: 0x2616911 VA: 0x2616810
	|-Array.IndexOf<ActorID>
	|-Array.IndexOf<ItemID>
	|-Array.IndexOf<Int32Enum>
	|
	|-RVA: 0x26186E0 Offset: 0x26187E1 VA: 0x26186E0
	|-Array.IndexOf<FocusInterface>
	|-Array.IndexOf<object>
	|-Array.IndexOf<string>
	|-Array.IndexOf<Material>
	|-Array.IndexOf<Face>
	|-Array.IndexOf<Texture2D>
	|
	|-RVA: 0x21B5080 Offset: 0x21B5181 VA: 0x21B5080
	|-Array.IndexOf<bool>
	|
	|-RVA: 0x21B5270 Offset: 0x21B5371 VA: 0x21B5270
	|-Array.IndexOf<byte>
	|
	|-RVA: 0x21B5460 Offset: 0x21B5561 VA: 0x21B5460
	|-Array.IndexOf<char>
	|
	|-RVA: 0x2616620 Offset: 0x2616721 VA: 0x2616620
	|-Array.IndexOf<int>
	|
	|-RVA: 0x2618AD0 Offset: 0x2618BD1 VA: 0x2618AD0
	|-Array.IndexOf<float>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T value, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2618790 Offset: 0x2618891 VA: 0x2618790
	|-Array.IndexOf<object>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B2260 Offset: 0x21B2361 VA: 0x21B2260
	|-Array.IndexOf<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x21B23D0 Offset: 0x21B24D1 VA: 0x21B23D0
	|-Array.IndexOf<BuildItemData>
	|
	|-RVA: 0x21B25A0 Offset: 0x21B26A1 VA: 0x21B25A0
	|-Array.IndexOf<ButtonLinker.LinkObject>
	|
	|-RVA: 0x21B26F0 Offset: 0x21B27F1 VA: 0x21B26F0
	|-Array.IndexOf<CharaCallTable.BustupTable>
	|
	|-RVA: 0x21B2840 Offset: 0x21B2941 VA: 0x21B2840
	|-Array.IndexOf<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x21B2990 Offset: 0x21B2A91 VA: 0x21B2990
	|-Array.IndexOf<CameraState.CustomBlendable>
	|
	|-RVA: 0x21B2AE0 Offset: 0x21B2BE1 VA: 0x21B2AE0
	|-Array.IndexOf<CinemachineClearShot.Pair>
	|
	|-RVA: 0x21B2C20 Offset: 0x21B2D21 VA: 0x21B2C20
	|-Array.IndexOf<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x21B2D60 Offset: 0x21B2E61 VA: 0x21B2D60
	|-Array.IndexOf<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x21B2EE0 Offset: 0x21B2FE1 VA: 0x21B2EE0
	|-Array.IndexOf<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x21B3060 Offset: 0x21B3161 VA: 0x21B3060
	|-Array.IndexOf<CropDataTable>
	|
	|-RVA: 0x21B31D0 Offset: 0x21B32D1 VA: 0x21B31D0
	|-Array.IndexOf<DropItemParam>
	|
	|-RVA: 0x21B3310 Offset: 0x21B3411 VA: 0x21B3310
	|-Array.IndexOf<ErosionBrush.UndoStep>
	|
	|-RVA: 0x21B3480 Offset: 0x21B3581 VA: 0x21B3480
	|-Array.IndexOf<EventCheckId>
	|
	|-RVA: 0x21B35F0 Offset: 0x21B36F1 VA: 0x21B35F0
	|-Array.IndexOf<EventFlagProgressData>
	|
	|-RVA: 0x21B3740 Offset: 0x21B3841 VA: 0x21B3740
	|-Array.IndexOf<FesNpcScoreData>
	|
	|-RVA: 0x21B3890 Offset: 0x21B3991 VA: 0x21B3890
	|-Array.IndexOf<MiningPointSaveData>
	|
	|-RVA: 0x21B3A10 Offset: 0x21B3B11 VA: 0x21B3A10
	|-Array.IndexOf<MonsterHutSaveData>
	|
	|-RVA: 0x21B3B90 Offset: 0x21B3C91 VA: 0x21B3B90
	|-Array.IndexOf<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x21B3CE0 Offset: 0x21B3DE1 VA: 0x21B3CE0
	|-Array.IndexOf<NPCActionData>
	|
	|-RVA: 0x21B3E70 Offset: 0x21B3F71 VA: 0x21B3E70
	|-Array.IndexOf<NpcPlaceSchedule>
	|
	|-RVA: 0x21B3FE0 Offset: 0x21B40E1 VA: 0x21B3FE0
	|-Array.IndexOf<OrderLotterySaveParameter>
	|
	|-RVA: 0x21B4130 Offset: 0x21B4231 VA: 0x21B4130
	|-Array.IndexOf<OrderSaveParameter>
	|
	|-RVA: 0x21B42A0 Offset: 0x21B43A1 VA: 0x21B42A0
	|-Array.IndexOf<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x21B43F0 Offset: 0x21B44F1 VA: 0x21B43F0
	|-Array.IndexOf<ShopCatalogPage>
	|
	|-RVA: 0x21B4540 Offset: 0x21B4641 VA: 0x21B4540
	|-Array.IndexOf<ShopNpcTalk>
	|
	|-RVA: 0x21B46C0 Offset: 0x21B47C1 VA: 0x21B46C0
	|-Array.IndexOf<SubtitleDataTable.Data>
	|
	|-RVA: 0x21B4810 Offset: 0x21B4911 VA: 0x21B4810
	|-Array.IndexOf<SubtitleDataTable.DataList>
	|
	|-RVA: 0x21B4950 Offset: 0x21B4A51 VA: 0x21B4950
	|-Array.IndexOf<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x21B4AA0 Offset: 0x21B4BA1 VA: 0x21B4AA0
	|-Array.IndexOf<ProfilerFrame>
	|
	|-RVA: 0x21B4C00 Offset: 0x21B4D01 VA: 0x21B4C00
	|-Array.IndexOf<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x21B4D70 Offset: 0x21B4E71 VA: 0x21B4D70
	|-Array.IndexOf<Schedule>
	|
	|-RVA: 0x21B4EE0 Offset: 0x21B4FE1 VA: 0x21B4EE0
	|-Array.IndexOf<CurveSample>
	|
	|-RVA: 0x21B5130 Offset: 0x21B5231 VA: 0x21B5130
	|-Array.IndexOf<bool>
	|
	|-RVA: 0x21B5320 Offset: 0x21B5421 VA: 0x21B5320
	|-Array.IndexOf<byte>
	|
	|-RVA: 0x21B5510 Offset: 0x21B5611 VA: 0x21B5510
	|-Array.IndexOf<char>
	|
	|-RVA: 0x2615E70 Offset: 0x2615F71 VA: 0x2615E70
	|-Array.IndexOf<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2615FC0 Offset: 0x26160C1 VA: 0x2615FC0
	|-Array.IndexOf<KeyValuePair<int, object>>
	|
	|-RVA: 0x2616110 Offset: 0x2616211 VA: 0x2616110
	|-Array.IndexOf<KeyValuePair<object, object>>
	|
	|-RVA: 0x2616260 Offset: 0x2616361 VA: 0x2616260
	|-Array.IndexOf<DateTime>
	|
	|-RVA: 0x26163A0 Offset: 0x26164A1 VA: 0x26163A0
	|-Array.IndexOf<double>
	|
	|-RVA: 0x26164E0 Offset: 0x26165E1 VA: 0x26164E0
	|-Array.IndexOf<short>
	|
	|-RVA: 0x26166D0 Offset: 0x26167D1 VA: 0x26166D0
	|-Array.IndexOf<int>
	|
	|-RVA: 0x26168C0 Offset: 0x26169C1 VA: 0x26168C0
	|-Array.IndexOf<Int32Enum>
	|
	|-RVA: 0x2616A00 Offset: 0x2616B01 VA: 0x2616A00
	|-Array.IndexOf<long>
	|
	|-RVA: 0x2616B40 Offset: 0x2616C41 VA: 0x2616B40
	|-Array.IndexOf<InterpretedFrameInfo>
	|
	|-RVA: 0x2616C90 Offset: 0x2616D91 VA: 0x2616C90
	|-Array.IndexOf<Nullable<Int32Enum>>
	|
	|-RVA: 0x2616DD0 Offset: 0x2616ED1 VA: 0x2616DD0
	|-Array.IndexOf<Nullable<Bounds>>
	|
	|-RVA: 0x2616F50 Offset: 0x2617051 VA: 0x2616F50
	|-Array.IndexOf<Nullable<BoundsInt>>
	|
	|-RVA: 0x26170D0 Offset: 0x26171D1 VA: 0x26170D0
	|-Array.IndexOf<Nullable<Color32>>
	|
	|-RVA: 0x2617210 Offset: 0x2617311 VA: 0x2617210
	|-Array.IndexOf<Nullable<Color>>
	|
	|-RVA: 0x2617380 Offset: 0x2617481 VA: 0x2617380
	|-Array.IndexOf<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x26174D0 Offset: 0x26175D1 VA: 0x26174D0
	|-Array.IndexOf<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2617640 Offset: 0x2617741 VA: 0x2617640
	|-Array.IndexOf<Nullable<Keyframe>>
	|
	|-RVA: 0x26177B0 Offset: 0x26178B1 VA: 0x26177B0
	|-Array.IndexOf<Nullable<LayerMask>>
	|
	|-RVA: 0x26178F0 Offset: 0x26179F1 VA: 0x26178F0
	|-Array.IndexOf<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2617A90 Offset: 0x2617B91 VA: 0x2617A90
	|-Array.IndexOf<Nullable<Quaternion>>
	|
	|-RVA: 0x2617C00 Offset: 0x2617D01 VA: 0x2617C00
	|-Array.IndexOf<Nullable<RangeInt>>
	|
	|-RVA: 0x2617D50 Offset: 0x2617E51 VA: 0x2617D50
	|-Array.IndexOf<Nullable<Rect>>
	|
	|-RVA: 0x2617EC0 Offset: 0x2617FC1 VA: 0x2617EC0
	|-Array.IndexOf<Nullable<RectInt>>
	|
	|-RVA: 0x2618030 Offset: 0x2618131 VA: 0x2618030
	|-Array.IndexOf<Nullable<Vector2>>
	|
	|-RVA: 0x2618180 Offset: 0x2618281 VA: 0x2618180
	|-Array.IndexOf<Nullable<Vector2Int>>
	|
	|-RVA: 0x26182D0 Offset: 0x26183D1 VA: 0x26182D0
	|-Array.IndexOf<Nullable<Vector3>>
	|
	|-RVA: 0x2618420 Offset: 0x2618521 VA: 0x2618420
	|-Array.IndexOf<Nullable<Vector3Int>>
	|
	|-RVA: 0x2618570 Offset: 0x2618671 VA: 0x2618570
	|-Array.IndexOf<Nullable<Vector4>>
	|
	|-RVA: 0x2618850 Offset: 0x2618951 VA: 0x2618850
	|-Array.IndexOf<object>
	|
	|-RVA: 0x2618990 Offset: 0x2618A91 VA: 0x2618990
	|-Array.IndexOf<sbyte>
	|
	|-RVA: 0x2618B90 Offset: 0x2618C91 VA: 0x2618B90
	|-Array.IndexOf<float>
	|
	|-RVA: 0x2618CD0 Offset: 0x2618DD1 VA: 0x2618CD0
	|-Array.IndexOf<ushort>
	|
	|-RVA: 0x2618E10 Offset: 0x2618F11 VA: 0x2618E10
	|-Array.IndexOf<uint>
	|
	|-RVA: 0x2618F50 Offset: 0x2619051 VA: 0x2618F50
	|-Array.IndexOf<ulong>
	|
	|-RVA: 0x2619090 Offset: 0x2619191 VA: 0x2619090
	|-Array.IndexOf<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x26191D0 Offset: 0x26192D1 VA: 0x26191D0
	|-Array.IndexOf<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2619310 Offset: 0x2619411 VA: 0x2619310
	|-Array.IndexOf<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x2619460 Offset: 0x2619561 VA: 0x2619460
	|-Array.IndexOf<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x26195B0 Offset: 0x26196B1 VA: 0x26195B0
	|-Array.IndexOf<ValueTuple<object, object>>
	|
	|-RVA: 0x2619700 Offset: 0x2619801 VA: 0x2619700
	|-Array.IndexOf<ValueTuple<object, float>>
	|
	|-RVA: 0x2619850 Offset: 0x2619951 VA: 0x2619850
	|-Array.IndexOf<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x26199A0 Offset: 0x2619AA1 VA: 0x26199A0
	|-Array.IndexOf<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x2619B30 Offset: 0x2619C31 VA: 0x2619B30
	|-Array.IndexOf<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x2619CC0 Offset: 0x2619DC1 VA: 0x2619CC0
	|-Array.IndexOf<TutorialUnlockFlagData>
	|
	|-RVA: 0x2619E10 Offset: 0x2619F11 VA: 0x2619E10
	|-Array.IndexOf<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x2619F60 Offset: 0x261A061 VA: 0x2619F60
	|-Array.IndexOf<CapEdge>
	|
	|-RVA: 0x261A0E0 Offset: 0x261A1E1 VA: 0x261A0E0
	|-Array.IndexOf<MeshDataConnectivity.Face>
	|
	|-RVA: 0x261A220 Offset: 0x261A321 VA: 0x261A220
	|-Array.IndexOf<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x261A390 Offset: 0x261A491 VA: 0x261A390
	|-Array.IndexOf<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x261A510 Offset: 0x261A611 VA: 0x261A510
	|-Array.IndexOf<NavMeshBuildMarkup>
	|
	|-RVA: 0x261A660 Offset: 0x261A761 VA: 0x261A660
	|-Array.IndexOf<NavMeshBuildSource>
	|
	|-RVA: 0x261A820 Offset: 0x261A921 VA: 0x261A820
	|-Array.IndexOf<ConstraintSource>
	|
	|-RVA: 0x261A970 Offset: 0x261AA71 VA: 0x261A970
	|-Array.IndexOf<AnimatorClipInfo>
	|
	|-RVA: 0x261AAB0 Offset: 0x261ABB1 VA: 0x261AAB0
	|-Array.IndexOf<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x261AC00 Offset: 0x261AD01 VA: 0x261AC00
	|-Array.IndexOf<BoneWeight>
	|
	|-RVA: 0x261AD70 Offset: 0x261AE71 VA: 0x261AD70
	|-Array.IndexOf<Bounds>
	|
	|-RVA: 0x261AEE0 Offset: 0x261AFE1 VA: 0x261AEE0
	|-Array.IndexOf<BoundsInt>
	|
	|-RVA: 0x261B050 Offset: 0x261B151 VA: 0x261B050
	|-Array.IndexOf<Color32>
	|
	|-RVA: 0x261B190 Offset: 0x261B291 VA: 0x261B190
	|-Array.IndexOf<Color>
	|
	|-RVA: 0x261B2F0 Offset: 0x261B3F1 VA: 0x261B2F0
	|-Array.IndexOf<CombineInstance>
	|
	|-RVA: 0x261B4B0 Offset: 0x261B5B1 VA: 0x261B4B0
	|-Array.IndexOf<RaycastResult>
	|
	|-RVA: 0x261B650 Offset: 0x261B751 VA: 0x261B650
	|-Array.IndexOf<GradientAlphaKey>
	|
	|-RVA: 0x261B7A0 Offset: 0x261B8A1 VA: 0x261B7A0
	|-Array.IndexOf<GradientColorKey>
	|
	|-RVA: 0x261B910 Offset: 0x261BA11 VA: 0x261B910
	|-Array.IndexOf<Keyframe>
	|
	|-RVA: 0x261BA90 Offset: 0x261BB91 VA: 0x261BA90
	|-Array.IndexOf<LayerMask>
	|
	|-RVA: 0x261BBD0 Offset: 0x261BCD1 VA: 0x261BBD0
	|-Array.IndexOf<Matrix4x4>
	|
	|-RVA: 0x261BD60 Offset: 0x261BE61 VA: 0x261BD60
	|-Array.IndexOf<ParticleSystem.Particle>
	|
	|-RVA: 0x261BEE0 Offset: 0x261BFE1 VA: 0x261BEE0
	|-Array.IndexOf<Playable>
	|
	|-RVA: 0x261C030 Offset: 0x261C131 VA: 0x261C030
	|-Array.IndexOf<PlayableBinding>
	|
	|-RVA: 0x261C1A0 Offset: 0x261C2A1 VA: 0x261C1A0
	|-Array.IndexOf<PlayableGraph>
	|
	|-RVA: 0x261C2F0 Offset: 0x261C3F1 VA: 0x261C2F0
	|-Array.IndexOf<Edge>
	|
	|-RVA: 0x261C430 Offset: 0x261C531 VA: 0x261C430
	|-Array.IndexOf<Quaternion>
	|
	|-RVA: 0x261C590 Offset: 0x261C691 VA: 0x261C590
	|-Array.IndexOf<RangeInt>
	|
	|-RVA: 0x261C6D0 Offset: 0x261C7D1 VA: 0x261C6D0
	|-Array.IndexOf<RaycastHit2D>
	|
	|-RVA: 0x261C850 Offset: 0x261C951 VA: 0x261C850
	|-Array.IndexOf<RaycastHit>
	|
	|-RVA: 0x261C9E0 Offset: 0x261CAE1 VA: 0x261C9E0
	|-Array.IndexOf<Rect>
	|
	|-RVA: 0x261CB40 Offset: 0x261CC41 VA: 0x261CB40
	|-Array.IndexOf<RectInt>
	|
	|-RVA: 0x261CC90 Offset: 0x261CD91 VA: 0x261CC90
	|-Array.IndexOf<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x261CDE0 Offset: 0x261CEE1 VA: 0x261CDE0
	|-Array.IndexOf<SphericalHarmonicsL2>
	|
	|-RVA: 0x261CFC0 Offset: 0x261D0C1 VA: 0x261CFC0
	|-Array.IndexOf<VertexAttributeDescriptor>
	|
	|-RVA: 0x261D110 Offset: 0x261D211 VA: 0x261D110
	|-Array.IndexOf<AsyncOperationHandle>
	|
	|-RVA: 0x261D280 Offset: 0x261D381 VA: 0x261D280
	|-Array.IndexOf<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x261D3F0 Offset: 0x261D4F1 VA: 0x261D3F0
	|-Array.IndexOf<DiagnosticEvent>
	|
	|-RVA: 0x261D570 Offset: 0x261D671 VA: 0x261D570
	|-Array.IndexOf<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x261D6E0 Offset: 0x261D7E1 VA: 0x261D6E0
	|-Array.IndexOf<ObjectInitializationData>
	|
	|-RVA: 0x261D860 Offset: 0x261D961 VA: 0x261D860
	|-Array.IndexOf<GlyphRect>
	|
	|-RVA: 0x261D9B0 Offset: 0x261DAB1 VA: 0x261D9B0
	|-Array.IndexOf<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x261DB30 Offset: 0x261DC31 VA: 0x261DB30
	|-Array.IndexOf<IntervalTreeNode>
	|
	|-RVA: 0x261DCA0 Offset: 0x261DDA1 VA: 0x261DCA0
	|-Array.IndexOf<IntervalTree.Entry<object>>
	|
	|-RVA: 0x261DE10 Offset: 0x261DF11 VA: 0x261DE10
	|-Array.IndexOf<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x261DF80 Offset: 0x261E081 VA: 0x261DF80
	|-Array.IndexOf<UICharInfo>
	|
	|-RVA: 0x261E0E0 Offset: 0x261E1E1 VA: 0x261E0E0
	|-Array.IndexOf<FocusController.FocusedElement>
	|
	|-RVA: 0x261E230 Offset: 0x261E331 VA: 0x261E230
	|-Array.IndexOf<UILineInfo>
	|
	|-RVA: 0x261E380 Offset: 0x261E481 VA: 0x261E380
	|-Array.IndexOf<UIVertex>
	|
	|-RVA: 0x261E530 Offset: 0x261E631 VA: 0x261E530
	|-Array.IndexOf<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x261E6A0 Offset: 0x261E7A1 VA: 0x261E6A0
	|-Array.IndexOf<Vector2>
	|
	|-RVA: 0x261E7F0 Offset: 0x261E8F1 VA: 0x261E7F0
	|-Array.IndexOf<Vector2Int>
	|
	|-RVA: 0x261E930 Offset: 0x261EA31 VA: 0x261E930
	|-Array.IndexOf<Vector3>
	|
	|-RVA: 0x261EA90 Offset: 0x261EB91 VA: 0x261EA90
	|-Array.IndexOf<Vector3Int>
	|
	|-RVA: 0x261EBE0 Offset: 0x261ECE1 VA: 0x261EBE0
	|-Array.IndexOf<Vector4>
	|
	|-RVA: 0x261ED40 Offset: 0x261EE41 VA: 0x261ED40
	|-Array.IndexOf<WarpPoints.WarpPoint>
	|
	|-RVA: 0x261EF10 Offset: 0x261F011 VA: 0x261EF10
	|-Array.IndexOf<YieldItemParam>
	|
	|-RVA: 0x261F050 Offset: 0x261F151 VA: 0x261F050
	|-Array.IndexOf<stCommand_t>
	*/

	// RVA: 0x184BC10 Offset: 0x184BD11 VA: 0x184BC10
	public static int LastIndexOf(Array array, object value) { }

	// RVA: 0x184C080 Offset: 0x184C181 VA: 0x184C080
	public static int LastIndexOf(Array array, object value, int startIndex) { }

	// RVA: 0x184BD40 Offset: 0x184BE41 VA: 0x184BD40
	public static int LastIndexOf(Array array, object value, int startIndex, int count) { }

	// RVA: -1 Offset: -1
	public static int LastIndexOf<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2556B90 Offset: 0x2556C91 VA: 0x2556B90
	|-Array.LastIndexOf<Delegate>
	|-Array.LastIndexOf<object>
	*/

	// RVA: -1 Offset: -1
	public static int LastIndexOf<T>(T[] array, T value, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25564E0 Offset: 0x25565E1 VA: 0x25564E0
	|-Array.LastIndexOf<KeyValuePair<object, object>>
	|
	|-RVA: 0x2556730 Offset: 0x2556831 VA: 0x2556730
	|-Array.LastIndexOf<int>
	|
	|-RVA: 0x2556960 Offset: 0x2556A61 VA: 0x2556960
	|-Array.LastIndexOf<Int32Enum>
	|
	|-RVA: 0x2556C40 Offset: 0x2556D41 VA: 0x2556C40
	|-Array.LastIndexOf<object>
	|
	|-RVA: 0x2556E70 Offset: 0x2556F71 VA: 0x2556E70
	|-Array.LastIndexOf<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x2557150 Offset: 0x2557251 VA: 0x2557150
	|-Array.LastIndexOf<EventDispatcher.DispatchContext>
	*/

	// RVA: -1 Offset: -1
	public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25565B0 Offset: 0x25566B1 VA: 0x25565B0
	|-Array.LastIndexOf<KeyValuePair<object, object>>
	|
	|-RVA: 0x25567F0 Offset: 0x25568F1 VA: 0x25567F0
	|-Array.LastIndexOf<int>
	|
	|-RVA: 0x2556A20 Offset: 0x2556B21 VA: 0x2556A20
	|-Array.LastIndexOf<Int32Enum>
	|
	|-RVA: 0x2556D00 Offset: 0x2556E01 VA: 0x2556D00
	|-Array.LastIndexOf<object>
	|
	|-RVA: 0x2556FC0 Offset: 0x25570C1 VA: 0x2556FC0
	|-Array.LastIndexOf<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x2557220 Offset: 0x2557321 VA: 0x2557220
	|-Array.LastIndexOf<EventDispatcher.DispatchContext>
	*/

	// RVA: 0x184C120 Offset: 0x184C221 VA: 0x184C120
	public static void Reverse(Array array) { }

	// RVA: 0x184C210 Offset: 0x184C311 VA: 0x184C210
	public static void Reverse(Array array, int index, int length) { }

	// RVA: -1 Offset: -1
	public static void Reverse<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x265A070 Offset: 0x265A171 VA: 0x265A070
	|-Array.Reverse<byte>
	|
	|-RVA: 0x265DD40 Offset: 0x265DE41 VA: 0x265DD40
	|-Array.Reverse<object>
	*/

	// RVA: -1 Offset: -1
	public static void Reverse<T>(T[] array, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2655B50 Offset: 0x2655C51 VA: 0x2655B50
	|-Array.Reverse<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x2655D90 Offset: 0x2655E91 VA: 0x2655D90
	|-Array.Reverse<BuildItemData>
	|
	|-RVA: 0x2656070 Offset: 0x2656171 VA: 0x2656070
	|-Array.Reverse<ButtonLinker.LinkObject>
	|
	|-RVA: 0x2656260 Offset: 0x2656361 VA: 0x2656260
	|-Array.Reverse<CharaCallTable.BustupTable>
	|
	|-RVA: 0x2656420 Offset: 0x2656521 VA: 0x2656420
	|-Array.Reverse<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x2656600 Offset: 0x2656701 VA: 0x2656600
	|-Array.Reverse<CameraState.CustomBlendable>
	|
	|-RVA: 0x2656800 Offset: 0x2656901 VA: 0x2656800
	|-Array.Reverse<CinemachineClearShot.Pair>
	|
	|-RVA: 0x26569D0 Offset: 0x2656AD1 VA: 0x26569D0
	|-Array.Reverse<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2656BA0 Offset: 0x2656CA1 VA: 0x2656BA0
	|-Array.Reverse<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2656DD0 Offset: 0x2656ED1 VA: 0x2656DD0
	|-Array.Reverse<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x2657010 Offset: 0x2657111 VA: 0x2657010
	|-Array.Reverse<CropDataTable>
	|
	|-RVA: 0x2657290 Offset: 0x2657391 VA: 0x2657290
	|-Array.Reverse<DropItemParam>
	|
	|-RVA: 0x2657460 Offset: 0x2657561 VA: 0x2657460
	|-Array.Reverse<ErosionBrush.UndoStep>
	|
	|-RVA: 0x2657690 Offset: 0x2657791 VA: 0x2657690
	|-Array.Reverse<EventCheckId>
	|
	|-RVA: 0x26578D0 Offset: 0x26579D1 VA: 0x26578D0
	|-Array.Reverse<EventFlagProgressData>
	|
	|-RVA: 0x2657AC0 Offset: 0x2657BC1 VA: 0x2657AC0
	|-Array.Reverse<FesNpcScoreData>
	|
	|-RVA: 0x2657CB0 Offset: 0x2657DB1 VA: 0x2657CB0
	|-Array.Reverse<MiningPointSaveData>
	|
	|-RVA: 0x2657EF0 Offset: 0x2657FF1 VA: 0x2657EF0
	|-Array.Reverse<MonsterHutSaveData>
	|
	|-RVA: 0x2658150 Offset: 0x2658251 VA: 0x2658150
	|-Array.Reverse<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x2658340 Offset: 0x2658441 VA: 0x2658340
	|-Array.Reverse<NPCActionData>
	|
	|-RVA: 0x2658590 Offset: 0x2658691 VA: 0x2658590
	|-Array.Reverse<NpcPlaceSchedule>
	|
	|-RVA: 0x26587C0 Offset: 0x26588C1 VA: 0x26587C0
	|-Array.Reverse<OrderLotterySaveParameter>
	|
	|-RVA: 0x26589A0 Offset: 0x2658AA1 VA: 0x26589A0
	|-Array.Reverse<OrderSaveParameter>
	|
	|-RVA: 0x2658BE0 Offset: 0x2658CE1 VA: 0x2658BE0
	|-Array.Reverse<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2658DD0 Offset: 0x2658ED1 VA: 0x2658DD0
	|-Array.Reverse<ShopCatalogPage>
	|
	|-RVA: 0x2658FD0 Offset: 0x26590D1 VA: 0x2658FD0
	|-Array.Reverse<ShopNpcTalk>
	|
	|-RVA: 0x2659230 Offset: 0x2659331 VA: 0x2659230
	|-Array.Reverse<SubtitleDataTable.Data>
	|
	|-RVA: 0x2659410 Offset: 0x2659511 VA: 0x2659410
	|-Array.Reverse<SubtitleDataTable.DataList>
	|
	|-RVA: 0x2659600 Offset: 0x2659701 VA: 0x2659600
	|-Array.Reverse<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x26597E0 Offset: 0x26598E1 VA: 0x26597E0
	|-Array.Reverse<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x2659A20 Offset: 0x2659B21 VA: 0x2659A20
	|-Array.Reverse<Schedule>
	|
	|-RVA: 0x2659C30 Offset: 0x2659D31 VA: 0x2659C30
	|-Array.Reverse<CurveSample>
	|
	|-RVA: 0x2659EA0 Offset: 0x2659FA1 VA: 0x2659EA0
	|-Array.Reverse<bool>
	|
	|-RVA: 0x265A120 Offset: 0x265A221 VA: 0x265A120
	|-Array.Reverse<byte>
	|
	|-RVA: 0x265A2F0 Offset: 0x265A3F1 VA: 0x265A2F0
	|-Array.Reverse<char>
	|
	|-RVA: 0x265A4C0 Offset: 0x265A5C1 VA: 0x265A4C0
	|-Array.Reverse<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x265A6B0 Offset: 0x265A7B1 VA: 0x265A6B0
	|-Array.Reverse<KeyValuePair<int, object>>
	|
	|-RVA: 0x265A8A0 Offset: 0x265A9A1 VA: 0x265A8A0
	|-Array.Reverse<KeyValuePair<object, object>>
	|
	|-RVA: 0x265AAA0 Offset: 0x265ABA1 VA: 0x265AAA0
	|-Array.Reverse<DateTime>
	|
	|-RVA: 0x265AC70 Offset: 0x265AD71 VA: 0x265AC70
	|-Array.Reverse<double>
	|
	|-RVA: 0x265AE40 Offset: 0x265AF41 VA: 0x265AE40
	|-Array.Reverse<short>
	|
	|-RVA: 0x265B010 Offset: 0x265B111 VA: 0x265B010
	|-Array.Reverse<int>
	|
	|-RVA: 0x265B1E0 Offset: 0x265B2E1 VA: 0x265B1E0
	|-Array.Reverse<Int32Enum>
	|
	|-RVA: 0x265B3B0 Offset: 0x265B4B1 VA: 0x265B3B0
	|-Array.Reverse<long>
	|
	|-RVA: 0x265B580 Offset: 0x265B681 VA: 0x265B580
	|-Array.Reverse<InterpretedFrameInfo>
	|
	|-RVA: 0x265B780 Offset: 0x265B881 VA: 0x265B780
	|-Array.Reverse<Nullable<Int32Enum>>
	|
	|-RVA: 0x265B950 Offset: 0x265BA51 VA: 0x265B950
	|-Array.Reverse<Nullable<Bounds>>
	|
	|-RVA: 0x265BB80 Offset: 0x265BC81 VA: 0x265BB80
	|-Array.Reverse<Nullable<BoundsInt>>
	|
	|-RVA: 0x265BDB0 Offset: 0x265BEB1 VA: 0x265BDB0
	|-Array.Reverse<Nullable<Color32>>
	|
	|-RVA: 0x265BF80 Offset: 0x265C081 VA: 0x265BF80
	|-Array.Reverse<Nullable<Color>>
	|
	|-RVA: 0x265C190 Offset: 0x265C291 VA: 0x265C190
	|-Array.Reverse<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x265C370 Offset: 0x265C471 VA: 0x265C370
	|-Array.Reverse<Nullable<GradientColorKey>>
	|
	|-RVA: 0x265C580 Offset: 0x265C681 VA: 0x265C580
	|-Array.Reverse<Nullable<Keyframe>>
	|
	|-RVA: 0x265C790 Offset: 0x265C891 VA: 0x265C790
	|-Array.Reverse<Nullable<LayerMask>>
	|
	|-RVA: 0x265C960 Offset: 0x265CA61 VA: 0x265C960
	|-Array.Reverse<Nullable<Matrix4x4>>
	|
	|-RVA: 0x265CBE0 Offset: 0x265CCE1 VA: 0x265CBE0
	|-Array.Reverse<Nullable<Quaternion>>
	|
	|-RVA: 0x265CDF0 Offset: 0x265CEF1 VA: 0x265CDF0
	|-Array.Reverse<Nullable<RangeInt>>
	|
	|-RVA: 0x265CFD0 Offset: 0x265D0D1 VA: 0x265CFD0
	|-Array.Reverse<Nullable<Rect>>
	|
	|-RVA: 0x265D1E0 Offset: 0x265D2E1 VA: 0x265D1E0
	|-Array.Reverse<Nullable<RectInt>>
	|
	|-RVA: 0x265D3F0 Offset: 0x265D4F1 VA: 0x265D3F0
	|-Array.Reverse<Nullable<Vector2>>
	|
	|-RVA: 0x265D5D0 Offset: 0x265D6D1 VA: 0x265D5D0
	|-Array.Reverse<Nullable<Vector2Int>>
	|
	|-RVA: 0x265D7B0 Offset: 0x265D8B1 VA: 0x265D7B0
	|-Array.Reverse<Nullable<Vector3>>
	|
	|-RVA: 0x265D970 Offset: 0x265DA71 VA: 0x265D970
	|-Array.Reverse<Nullable<Vector3Int>>
	|
	|-RVA: 0x265DB30 Offset: 0x265DC31 VA: 0x265DB30
	|-Array.Reverse<Nullable<Vector4>>
	|
	|-RVA: 0x265DDF0 Offset: 0x265DEF1 VA: 0x265DDF0
	|-Array.Reverse<object>
	|
	|-RVA: 0x265DFE0 Offset: 0x265E0E1 VA: 0x265DFE0
	|-Array.Reverse<sbyte>
	|
	|-RVA: 0x265E1B0 Offset: 0x265E2B1 VA: 0x265E1B0
	|-Array.Reverse<float>
	|
	|-RVA: 0x265E380 Offset: 0x265E481 VA: 0x265E380
	|-Array.Reverse<ushort>
	|
	|-RVA: 0x265E550 Offset: 0x265E651 VA: 0x265E550
	|-Array.Reverse<uint>
	|
	|-RVA: 0x265E720 Offset: 0x265E821 VA: 0x265E720
	|-Array.Reverse<ulong>
	|
	|-RVA: 0x265E8F0 Offset: 0x265E9F1 VA: 0x265E8F0
	|-Array.Reverse<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x265EAC0 Offset: 0x265EBC1 VA: 0x265EAC0
	|-Array.Reverse<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x265EC90 Offset: 0x265ED91 VA: 0x265EC90
	|-Array.Reverse<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x265EE80 Offset: 0x265EF81 VA: 0x265EE80
	|-Array.Reverse<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x265F080 Offset: 0x265F181 VA: 0x265F080
	|-Array.Reverse<ValueTuple<object, object>>
	|
	|-RVA: 0x265F280 Offset: 0x265F381 VA: 0x265F280
	|-Array.Reverse<ValueTuple<object, float>>
	|
	|-RVA: 0x265F480 Offset: 0x265F581 VA: 0x265F480
	|-Array.Reverse<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x265F660 Offset: 0x265F761 VA: 0x265F660
	|-Array.Reverse<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x265F8D0 Offset: 0x265F9D1 VA: 0x265F8D0
	|-Array.Reverse<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x265FB50 Offset: 0x265FC51 VA: 0x265FB50
	|-Array.Reverse<TutorialUnlockFlagData>
	|
	|-RVA: 0x265FD30 Offset: 0x265FE31 VA: 0x265FD30
	|-Array.Reverse<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x265FF20 Offset: 0x2660021 VA: 0x265FF20
	|-Array.Reverse<CapEdge>
	|
	|-RVA: 0x2660160 Offset: 0x2660261 VA: 0x2660160
	|-Array.Reverse<MeshDataConnectivity.Face>
	|
	|-RVA: 0x2660330 Offset: 0x2660431 VA: 0x2660330
	|-Array.Reverse<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x2660540 Offset: 0x2660641 VA: 0x2660540
	|-Array.Reverse<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x26607A0 Offset: 0x26608A1 VA: 0x26607A0
	|-Array.Reverse<NavMeshBuildMarkup>
	|
	|-RVA: 0x2660960 Offset: 0x2660A61 VA: 0x2660960
	|-Array.Reverse<NavMeshBuildSource>
	|
	|-RVA: 0x2660C10 Offset: 0x2660D11 VA: 0x2660C10
	|-Array.Reverse<ConstraintSource>
	|
	|-RVA: 0x2660E10 Offset: 0x2660F11 VA: 0x2660E10
	|-Array.Reverse<AnimatorClipInfo>
	|
	|-RVA: 0x2660FE0 Offset: 0x26610E1 VA: 0x2660FE0
	|-Array.Reverse<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x26611D0 Offset: 0x26612D1 VA: 0x26611D0
	|-Array.Reverse<BoneWeight>
	|
	|-RVA: 0x26613E0 Offset: 0x26614E1 VA: 0x26613E0
	|-Array.Reverse<Bounds>
	|
	|-RVA: 0x26615F0 Offset: 0x26616F1 VA: 0x26615F0
	|-Array.Reverse<BoundsInt>
	|
	|-RVA: 0x2661800 Offset: 0x2661901 VA: 0x2661800
	|-Array.Reverse<Color32>
	|
	|-RVA: 0x26619D0 Offset: 0x2661AD1 VA: 0x26619D0
	|-Array.Reverse<Color>
	|
	|-RVA: 0x2661BA0 Offset: 0x2661CA1 VA: 0x2661BA0
	|-Array.Reverse<CombineInstance>
	|
	|-RVA: 0x2661E50 Offset: 0x2661F51 VA: 0x2661E50
	|-Array.Reverse<RaycastResult>
	|
	|-RVA: 0x26620E0 Offset: 0x26621E1 VA: 0x26620E0
	|-Array.Reverse<GradientAlphaKey>
	|
	|-RVA: 0x26622A0 Offset: 0x26623A1 VA: 0x26622A0
	|-Array.Reverse<GradientColorKey>
	|
	|-RVA: 0x26624B0 Offset: 0x26625B1 VA: 0x26624B0
	|-Array.Reverse<Keyframe>
	|
	|-RVA: 0x26626E0 Offset: 0x26627E1 VA: 0x26626E0
	|-Array.Reverse<LayerMask>
	|
	|-RVA: 0x26628B0 Offset: 0x26629B1 VA: 0x26628B0
	|-Array.Reverse<Matrix4x4>
	|
	|-RVA: 0x2662B00 Offset: 0x2662C01 VA: 0x2662B00
	|-Array.Reverse<ParticleSystem.Particle>
	|
	|-RVA: 0x2662D40 Offset: 0x2662E41 VA: 0x2662D40
	|-Array.Reverse<Playable>
	|
	|-RVA: 0x2662F00 Offset: 0x2663001 VA: 0x2662F00
	|-Array.Reverse<PlayableBinding>
	|
	|-RVA: 0x2663130 Offset: 0x2663231 VA: 0x2663130
	|-Array.Reverse<PlayableGraph>
	|
	|-RVA: 0x26632F0 Offset: 0x26633F1 VA: 0x26632F0
	|-Array.Reverse<Edge>
	|
	|-RVA: 0x26634C0 Offset: 0x26635C1 VA: 0x26634C0
	|-Array.Reverse<Quaternion>
	|
	|-RVA: 0x2663690 Offset: 0x2663791 VA: 0x2663690
	|-Array.Reverse<RangeInt>
	|
	|-RVA: 0x2663860 Offset: 0x2663961 VA: 0x2663860
	|-Array.Reverse<RaycastHit2D>
	|
	|-RVA: 0x2663AA0 Offset: 0x2663BA1 VA: 0x2663AA0
	|-Array.Reverse<RaycastHit>
	|
	|-RVA: 0x2663CF0 Offset: 0x2663DF1 VA: 0x2663CF0
	|-Array.Reverse<Rect>
	|
	|-RVA: 0x2663EC0 Offset: 0x2663FC1 VA: 0x2663EC0
	|-Array.Reverse<RectInt>
	|
	|-RVA: 0x2664080 Offset: 0x2664181 VA: 0x2664080
	|-Array.Reverse<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x2664280 Offset: 0x2664381 VA: 0x2664280
	|-Array.Reverse<SphericalHarmonicsL2>
	|
	|-RVA: 0x2664550 Offset: 0x2664651 VA: 0x2664550
	|-Array.Reverse<VertexAttributeDescriptor>
	|
	|-RVA: 0x2664710 Offset: 0x2664811 VA: 0x2664710
	|-Array.Reverse<AsyncOperationHandle>
	|
	|-RVA: 0x2664940 Offset: 0x2664A41 VA: 0x2664940
	|-Array.Reverse<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x2664B70 Offset: 0x2664C71 VA: 0x2664B70
	|-Array.Reverse<DiagnosticEvent>
	|
	|-RVA: 0x2664DD0 Offset: 0x2664ED1 VA: 0x2664DD0
	|-Array.Reverse<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2665010 Offset: 0x2665111 VA: 0x2665010
	|-Array.Reverse<ObjectInitializationData>
	|
	|-RVA: 0x2665270 Offset: 0x2665371 VA: 0x2665270
	|-Array.Reverse<GlyphRect>
	|
	|-RVA: 0x2665430 Offset: 0x2665531 VA: 0x2665430
	|-Array.Reverse<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2665660 Offset: 0x2665761 VA: 0x2665660
	|-Array.Reverse<IntervalTreeNode>
	|
	|-RVA: 0x2665870 Offset: 0x2665971 VA: 0x2665870
	|-Array.Reverse<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2665AB0 Offset: 0x2665BB1 VA: 0x2665AB0
	|-Array.Reverse<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x2665CF0 Offset: 0x2665DF1 VA: 0x2665CF0
	|-Array.Reverse<UICharInfo>
	|
	|-RVA: 0x2665ED0 Offset: 0x2665FD1 VA: 0x2665ED0
	|-Array.Reverse<FocusController.FocusedElement>
	|
	|-RVA: 0x26660D0 Offset: 0x26661D1 VA: 0x26660D0
	|-Array.Reverse<UILineInfo>
	|
	|-RVA: 0x2666290 Offset: 0x2666391 VA: 0x2666290
	|-Array.Reverse<UIVertex>
	|
	|-RVA: 0x2666520 Offset: 0x2666621 VA: 0x2666520
	|-Array.Reverse<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x2666750 Offset: 0x2666851 VA: 0x2666750
	|-Array.Reverse<Vector2>
	|
	|-RVA: 0x2666910 Offset: 0x2666A11 VA: 0x2666910
	|-Array.Reverse<Vector2Int>
	|
	|-RVA: 0x2666AE0 Offset: 0x2666BE1 VA: 0x2666AE0
	|-Array.Reverse<Vector3>
	|
	|-RVA: 0x2666CC0 Offset: 0x2666DC1 VA: 0x2666CC0
	|-Array.Reverse<Vector3Int>
	|
	|-RVA: 0x2666EA0 Offset: 0x2666FA1 VA: 0x2666EA0
	|-Array.Reverse<Vector4>
	|
	|-RVA: 0x2667070 Offset: 0x2667171 VA: 0x2667070
	|-Array.Reverse<WarpPoints.WarpPoint>
	|
	|-RVA: 0x2667350 Offset: 0x2667451 VA: 0x2667350
	|-Array.Reverse<YieldItemParam>
	|
	|-RVA: 0x2667520 Offset: 0x2667621 VA: 0x2667520
	|-Array.Reverse<stCommand_t>
	*/

	// RVA: 0x184C520 Offset: 0x184C621 VA: 0x184C520
	public void SetValue(object value, long index) { }

	// RVA: 0x184C5D0 Offset: 0x184C6D1 VA: 0x184C5D0
	public void SetValue(object value, long index1, long index2) { }

	// RVA: 0x184C760 Offset: 0x184C861 VA: 0x184C760
	public void SetValue(object value, long index1, long index2, long index3) { }

	// RVA: 0x184C930 Offset: 0x184CA31 VA: 0x184C930
	public void SetValue(object value, long[] indices) { }

	// RVA: 0x184CAD0 Offset: 0x184CBD1 VA: 0x184CAD0
	public static void Sort(Array array) { }

	// RVA: 0x184CE80 Offset: 0x184CF81 VA: 0x184CE80
	public static void Sort(Array array, int index, int length) { }

	// RVA: 0x184CEA0 Offset: 0x184CFA1 VA: 0x184CEA0
	public static void Sort(Array array, IComparer comparer) { }

	// RVA: 0x184CFA0 Offset: 0x184D0A1 VA: 0x184CFA0
	public static void Sort(Array array, int index, int length, IComparer comparer) { }

	// RVA: 0x184CFC0 Offset: 0x184D0C1 VA: 0x184CFC0
	public static void Sort(Array keys, Array items) { }

	// RVA: 0x184D0C0 Offset: 0x184D1C1 VA: 0x184D0C0
	public static void Sort(Array keys, Array items, IComparer comparer) { }

	// RVA: 0x184D1C0 Offset: 0x184D2C1 VA: 0x184D1C0
	public static void Sort(Array keys, Array items, int index, int length) { }

	// RVA: 0x184CBC0 Offset: 0x184CCC1 VA: 0x184CBC0
	public static void Sort(Array keys, Array items, int index, int length, IComparer comparer) { }

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24AAAD0 Offset: 0x24AABD1 VA: 0x24AAAD0
	|-Array.Sort<object>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24AAD00 Offset: 0x24AAE01 VA: 0x24AAD00
	|-Array.Sort<AutomataDictionary.AutomataNode>
	|-Array.Sort<object>
	|
	|-RVA: 0x24AB750 Offset: 0x24AB851 VA: 0x24AB750
	|-Array.Sort<ulong>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24A8420 Offset: 0x24A8521 VA: 0x24A8420
	|-Array.Sort<int>
	|
	|-RVA: 0x24AAB80 Offset: 0x24AAC81 VA: 0x24AAB80
	|-Array.Sort<object>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2667760 Offset: 0x2667861 VA: 0x2667760
	|-Array.Sort<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x26678E0 Offset: 0x26679E1 VA: 0x26678E0
	|-Array.Sort<BuildItemData>
	|
	|-RVA: 0x2667A60 Offset: 0x2667B61 VA: 0x2667A60
	|-Array.Sort<ButtonLinker.LinkObject>
	|
	|-RVA: 0x2667BE0 Offset: 0x2667CE1 VA: 0x2667BE0
	|-Array.Sort<CharaCallTable.BustupTable>
	|
	|-RVA: 0x2667D60 Offset: 0x2667E61 VA: 0x2667D60
	|-Array.Sort<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x2667EE0 Offset: 0x2667FE1 VA: 0x2667EE0
	|-Array.Sort<CameraState.CustomBlendable>
	|
	|-RVA: 0x2668060 Offset: 0x2668161 VA: 0x2668060
	|-Array.Sort<CinemachineClearShot.Pair>
	|
	|-RVA: 0x26681E0 Offset: 0x26682E1 VA: 0x26681E0
	|-Array.Sort<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2668360 Offset: 0x2668461 VA: 0x2668360
	|-Array.Sort<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x26684E0 Offset: 0x26685E1 VA: 0x26684E0
	|-Array.Sort<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x24A5420 Offset: 0x24A5521 VA: 0x24A5420
	|-Array.Sort<CropDataTable>
	|
	|-RVA: 0x24A55A0 Offset: 0x24A56A1 VA: 0x24A55A0
	|-Array.Sort<DropItemParam>
	|
	|-RVA: 0x24A5720 Offset: 0x24A5821 VA: 0x24A5720
	|-Array.Sort<ErosionBrush.UndoStep>
	|
	|-RVA: 0x24A58A0 Offset: 0x24A59A1 VA: 0x24A58A0
	|-Array.Sort<EventCheckId>
	|
	|-RVA: 0x24A5A20 Offset: 0x24A5B21 VA: 0x24A5A20
	|-Array.Sort<EventFlagProgressData>
	|
	|-RVA: 0x24A5BA0 Offset: 0x24A5CA1 VA: 0x24A5BA0
	|-Array.Sort<FesNpcScoreData>
	|
	|-RVA: 0x24A5D20 Offset: 0x24A5E21 VA: 0x24A5D20
	|-Array.Sort<HitResult>
	|
	|-RVA: 0x24A5EA0 Offset: 0x24A5FA1 VA: 0x24A5EA0
	|-Array.Sort<MiningPointSaveData>
	|
	|-RVA: 0x24A6020 Offset: 0x24A6121 VA: 0x24A6020
	|-Array.Sort<MonsterHutSaveData>
	|
	|-RVA: 0x24A61A0 Offset: 0x24A62A1 VA: 0x24A61A0
	|-Array.Sort<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x24A6320 Offset: 0x24A6421 VA: 0x24A6320
	|-Array.Sort<NPCActionData>
	|
	|-RVA: 0x24A64A0 Offset: 0x24A65A1 VA: 0x24A64A0
	|-Array.Sort<NpcPlaceSchedule>
	|
	|-RVA: 0x24A6620 Offset: 0x24A6721 VA: 0x24A6620
	|-Array.Sort<OrderLotterySaveParameter>
	|
	|-RVA: 0x24A67A0 Offset: 0x24A68A1 VA: 0x24A67A0
	|-Array.Sort<OrderSaveParameter>
	|
	|-RVA: 0x24A6920 Offset: 0x24A6A21 VA: 0x24A6920
	|-Array.Sort<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x24A6AA0 Offset: 0x24A6BA1 VA: 0x24A6AA0
	|-Array.Sort<ShopCatalogPage>
	|
	|-RVA: 0x24A6C20 Offset: 0x24A6D21 VA: 0x24A6C20
	|-Array.Sort<ShopNpcTalk>
	|
	|-RVA: 0x24A6DA0 Offset: 0x24A6EA1 VA: 0x24A6DA0
	|-Array.Sort<SubtitleDataTable.Data>
	|
	|-RVA: 0x24A6F20 Offset: 0x24A7021 VA: 0x24A6F20
	|-Array.Sort<SubtitleDataTable.DataList>
	|
	|-RVA: 0x24A70A0 Offset: 0x24A71A1 VA: 0x24A70A0
	|-Array.Sort<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x24A7220 Offset: 0x24A7321 VA: 0x24A7220
	|-Array.Sort<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x24A73A0 Offset: 0x24A74A1 VA: 0x24A73A0
	|-Array.Sort<Schedule>
	|
	|-RVA: 0x24A7520 Offset: 0x24A7621 VA: 0x24A7520
	|-Array.Sort<CurveSample>
	|
	|-RVA: 0x24A76A0 Offset: 0x24A77A1 VA: 0x24A76A0
	|-Array.Sort<bool>
	|
	|-RVA: 0x24A7820 Offset: 0x24A7921 VA: 0x24A7820
	|-Array.Sort<byte>
	|
	|-RVA: 0x24A79A0 Offset: 0x24A7AA1 VA: 0x24A79A0
	|-Array.Sort<char>
	|
	|-RVA: 0x24A7B20 Offset: 0x24A7C21 VA: 0x24A7B20
	|-Array.Sort<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x24A7CA0 Offset: 0x24A7DA1 VA: 0x24A7CA0
	|-Array.Sort<KeyValuePair<int, object>>
	|
	|-RVA: 0x24A7E20 Offset: 0x24A7F21 VA: 0x24A7E20
	|-Array.Sort<KeyValuePair<object, object>>
	|
	|-RVA: 0x24A7FA0 Offset: 0x24A80A1 VA: 0x24A7FA0
	|-Array.Sort<DateTime>
	|
	|-RVA: 0x24A8120 Offset: 0x24A8221 VA: 0x24A8120
	|-Array.Sort<double>
	|
	|-RVA: 0x24A82A0 Offset: 0x24A83A1 VA: 0x24A82A0
	|-Array.Sort<short>
	|
	|-RVA: 0x24A84D0 Offset: 0x24A85D1 VA: 0x24A84D0
	|-Array.Sort<int>
	|
	|-RVA: 0x24A8650 Offset: 0x24A8751 VA: 0x24A8650
	|-Array.Sort<Int32Enum>
	|
	|-RVA: 0x24A87D0 Offset: 0x24A88D1 VA: 0x24A87D0
	|-Array.Sort<long>
	|
	|-RVA: 0x24A8950 Offset: 0x24A8A51 VA: 0x24A8950
	|-Array.Sort<InterpretedFrameInfo>
	|
	|-RVA: 0x24A8AD0 Offset: 0x24A8BD1 VA: 0x24A8AD0
	|-Array.Sort<Nullable<Int32Enum>>
	|
	|-RVA: 0x24A8C50 Offset: 0x24A8D51 VA: 0x24A8C50
	|-Array.Sort<Nullable<Bounds>>
	|
	|-RVA: 0x24A8DD0 Offset: 0x24A8ED1 VA: 0x24A8DD0
	|-Array.Sort<Nullable<BoundsInt>>
	|
	|-RVA: 0x24A8F50 Offset: 0x24A9051 VA: 0x24A8F50
	|-Array.Sort<Nullable<Color32>>
	|
	|-RVA: 0x24A90D0 Offset: 0x24A91D1 VA: 0x24A90D0
	|-Array.Sort<Nullable<Color>>
	|
	|-RVA: 0x24A9250 Offset: 0x24A9351 VA: 0x24A9250
	|-Array.Sort<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x24A93D0 Offset: 0x24A94D1 VA: 0x24A93D0
	|-Array.Sort<Nullable<GradientColorKey>>
	|
	|-RVA: 0x24A9550 Offset: 0x24A9651 VA: 0x24A9550
	|-Array.Sort<Nullable<Keyframe>>
	|
	|-RVA: 0x24A96D0 Offset: 0x24A97D1 VA: 0x24A96D0
	|-Array.Sort<Nullable<LayerMask>>
	|
	|-RVA: 0x24A9850 Offset: 0x24A9951 VA: 0x24A9850
	|-Array.Sort<Nullable<Matrix4x4>>
	|
	|-RVA: 0x24A99D0 Offset: 0x24A9AD1 VA: 0x24A99D0
	|-Array.Sort<Nullable<Quaternion>>
	|
	|-RVA: 0x24A9B50 Offset: 0x24A9C51 VA: 0x24A9B50
	|-Array.Sort<Nullable<RangeInt>>
	|
	|-RVA: 0x24A9CD0 Offset: 0x24A9DD1 VA: 0x24A9CD0
	|-Array.Sort<Nullable<Rect>>
	|
	|-RVA: 0x24A9E50 Offset: 0x24A9F51 VA: 0x24A9E50
	|-Array.Sort<Nullable<RectInt>>
	|
	|-RVA: 0x24A9FD0 Offset: 0x24AA0D1 VA: 0x24A9FD0
	|-Array.Sort<Nullable<Vector2>>
	|
	|-RVA: 0x24AA150 Offset: 0x24AA251 VA: 0x24AA150
	|-Array.Sort<Nullable<Vector2Int>>
	|
	|-RVA: 0x24AA2D0 Offset: 0x24AA3D1 VA: 0x24AA2D0
	|-Array.Sort<Nullable<Vector3>>
	|
	|-RVA: 0x24AA450 Offset: 0x24AA551 VA: 0x24AA450
	|-Array.Sort<Nullable<Vector3Int>>
	|
	|-RVA: 0x24AA5D0 Offset: 0x24AA6D1 VA: 0x24AA5D0
	|-Array.Sort<Nullable<Vector4>>
	|
	|-RVA: 0x24AAD20 Offset: 0x24AAE21 VA: 0x24AAD20
	|-Array.Sort<object>
	|-Array.Sort<Collider>
	|
	|-RVA: 0x24AAEA0 Offset: 0x24AAFA1 VA: 0x24AAEA0
	|-Array.Sort<sbyte>
	|
	|-RVA: 0x24AB020 Offset: 0x24AB121 VA: 0x24AB020
	|-Array.Sort<float>
	|
	|-RVA: 0x24AB1A0 Offset: 0x24AB2A1 VA: 0x24AB1A0
	|-Array.Sort<ushort>
	|
	|-RVA: 0x24AB320 Offset: 0x24AB421 VA: 0x24AB320
	|-Array.Sort<uint>
	|
	|-RVA: 0x24AB770 Offset: 0x24AB871 VA: 0x24AB770
	|-Array.Sort<ulong>
	|
	|-RVA: 0x24AB8F0 Offset: 0x24AB9F1 VA: 0x24AB8F0
	|-Array.Sort<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x24ABA70 Offset: 0x24ABB71 VA: 0x24ABA70
	|-Array.Sort<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x24ABBF0 Offset: 0x24ABCF1 VA: 0x24ABBF0
	|-Array.Sort<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x24ABD70 Offset: 0x24ABE71 VA: 0x24ABD70
	|-Array.Sort<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x24ABEF0 Offset: 0x24ABFF1 VA: 0x24ABEF0
	|-Array.Sort<ValueTuple<object, object>>
	|
	|-RVA: 0x24AC070 Offset: 0x24AC171 VA: 0x24AC070
	|-Array.Sort<ValueTuple<object, float>>
	|
	|-RVA: 0x24AC1F0 Offset: 0x24AC2F1 VA: 0x24AC1F0
	|-Array.Sort<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x24AC370 Offset: 0x24AC471 VA: 0x24AC370
	|-Array.Sort<ValueTuple<object, object, Vector3>>
	|-Array.Sort<ValueTuple<Collider, FocusInterface, Vector3>>
	|
	|-RVA: 0x24AC4F0 Offset: 0x24AC5F1 VA: 0x24AC4F0
	|-Array.Sort<ValueTuple<object, object, Vector3, float>>
	|-Array.Sort<ValueTuple<Collider, FocusInterface, Vector3, float>>
	|
	|-RVA: 0x24AC670 Offset: 0x24AC771 VA: 0x24AC670
	|-Array.Sort<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x24AC7F0 Offset: 0x24AC8F1 VA: 0x24AC7F0
	|-Array.Sort<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x24AC970 Offset: 0x24ACA71 VA: 0x24AC970
	|-Array.Sort<TutorialUnlockFlagData>
	|
	|-RVA: 0x24ACAF0 Offset: 0x24ACBF1 VA: 0x24ACAF0
	|-Array.Sort<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x24ACC70 Offset: 0x24ACD71 VA: 0x24ACC70
	|-Array.Sort<CapEdge>
	|
	|-RVA: 0x24ACDF0 Offset: 0x24ACEF1 VA: 0x24ACDF0
	|-Array.Sort<MeshDataConnectivity.Face>
	|
	|-RVA: 0x24ACF70 Offset: 0x24AD071 VA: 0x24ACF70
	|-Array.Sort<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x24AD0F0 Offset: 0x24AD1F1 VA: 0x24AD0F0
	|-Array.Sort<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x24AD270 Offset: 0x24AD371 VA: 0x24AD270
	|-Array.Sort<NavMeshBuildMarkup>
	|
	|-RVA: 0x24AD3F0 Offset: 0x24AD4F1 VA: 0x24AD3F0
	|-Array.Sort<NavMeshBuildSource>
	|
	|-RVA: 0x24AD570 Offset: 0x24AD671 VA: 0x24AD570
	|-Array.Sort<ConstraintSource>
	|
	|-RVA: 0x24AD6F0 Offset: 0x24AD7F1 VA: 0x24AD6F0
	|-Array.Sort<AnimatorClipInfo>
	|
	|-RVA: 0x24AD870 Offset: 0x24AD971 VA: 0x24AD870
	|-Array.Sort<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x24AD9F0 Offset: 0x24ADAF1 VA: 0x24AD9F0
	|-Array.Sort<BoneWeight>
	|
	|-RVA: 0x24ADB70 Offset: 0x24ADC71 VA: 0x24ADB70
	|-Array.Sort<Bounds>
	|
	|-RVA: 0x24ADCF0 Offset: 0x24ADDF1 VA: 0x24ADCF0
	|-Array.Sort<BoundsInt>
	|
	|-RVA: 0x24ADE70 Offset: 0x24ADF71 VA: 0x24ADE70
	|-Array.Sort<Color32>
	|
	|-RVA: 0x24ADFF0 Offset: 0x24AE0F1 VA: 0x24ADFF0
	|-Array.Sort<Color>
	|
	|-RVA: 0x24AE170 Offset: 0x24AE271 VA: 0x24AE170
	|-Array.Sort<CombineInstance>
	|
	|-RVA: 0x24AE2F0 Offset: 0x24AE3F1 VA: 0x24AE2F0
	|-Array.Sort<RaycastResult>
	|
	|-RVA: 0x24AE470 Offset: 0x24AE571 VA: 0x24AE470
	|-Array.Sort<GradientAlphaKey>
	|
	|-RVA: 0x24AE5F0 Offset: 0x24AE6F1 VA: 0x24AE5F0
	|-Array.Sort<GradientColorKey>
	|
	|-RVA: 0x24AE770 Offset: 0x24AE871 VA: 0x24AE770
	|-Array.Sort<Keyframe>
	|
	|-RVA: 0x24AE8F0 Offset: 0x24AE9F1 VA: 0x24AE8F0
	|-Array.Sort<LayerMask>
	|
	|-RVA: 0x24AEA70 Offset: 0x24AEB71 VA: 0x24AEA70
	|-Array.Sort<Matrix4x4>
	|
	|-RVA: 0x24AEBF0 Offset: 0x24AECF1 VA: 0x24AEBF0
	|-Array.Sort<ParticleSystem.Particle>
	|
	|-RVA: 0x24AED70 Offset: 0x24AEE71 VA: 0x24AED70
	|-Array.Sort<Playable>
	|
	|-RVA: 0x24AEEF0 Offset: 0x24AEFF1 VA: 0x24AEEF0
	|-Array.Sort<PlayableBinding>
	|
	|-RVA: 0x24AF070 Offset: 0x24AF171 VA: 0x24AF070
	|-Array.Sort<PlayableGraph>
	|
	|-RVA: 0x24AF1F0 Offset: 0x24AF2F1 VA: 0x24AF1F0
	|-Array.Sort<Edge>
	|
	|-RVA: 0x24AF370 Offset: 0x24AF471 VA: 0x24AF370
	|-Array.Sort<Quaternion>
	|
	|-RVA: 0x24AF4F0 Offset: 0x24AF5F1 VA: 0x24AF4F0
	|-Array.Sort<RangeInt>
	|
	|-RVA: 0x24AF670 Offset: 0x24AF771 VA: 0x24AF670
	|-Array.Sort<RaycastHit2D>
	|
	|-RVA: 0x24AF7F0 Offset: 0x24AF8F1 VA: 0x24AF7F0
	|-Array.Sort<RaycastHit>
	|
	|-RVA: 0x24AF970 Offset: 0x24AFA71 VA: 0x24AF970
	|-Array.Sort<Rect>
	|
	|-RVA: 0x24AFAF0 Offset: 0x24AFBF1 VA: 0x24AFAF0
	|-Array.Sort<RectInt>
	|
	|-RVA: 0x24AFC70 Offset: 0x24AFD71 VA: 0x24AFC70
	|-Array.Sort<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x24AFDF0 Offset: 0x24AFEF1 VA: 0x24AFDF0
	|-Array.Sort<SphericalHarmonicsL2>
	|
	|-RVA: 0x24AFF70 Offset: 0x24B0071 VA: 0x24AFF70
	|-Array.Sort<VertexAttributeDescriptor>
	|
	|-RVA: 0x24B00F0 Offset: 0x24B01F1 VA: 0x24B00F0
	|-Array.Sort<AsyncOperationHandle>
	|
	|-RVA: 0x24B0270 Offset: 0x24B0371 VA: 0x24B0270
	|-Array.Sort<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x24B03F0 Offset: 0x24B04F1 VA: 0x24B03F0
	|-Array.Sort<DiagnosticEvent>
	|
	|-RVA: 0x24B0570 Offset: 0x24B0671 VA: 0x24B0570
	|-Array.Sort<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x24B06F0 Offset: 0x24B07F1 VA: 0x24B06F0
	|-Array.Sort<ObjectInitializationData>
	|
	|-RVA: 0x24B0870 Offset: 0x24B0971 VA: 0x24B0870
	|-Array.Sort<GlyphRect>
	|
	|-RVA: 0x24B09F0 Offset: 0x24B0AF1 VA: 0x24B09F0
	|-Array.Sort<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x24B0B70 Offset: 0x24B0C71 VA: 0x24B0B70
	|-Array.Sort<IntervalTreeNode>
	|
	|-RVA: 0x24B0CF0 Offset: 0x24B0DF1 VA: 0x24B0CF0
	|-Array.Sort<IntervalTree.Entry<object>>
	|
	|-RVA: 0x24B0E70 Offset: 0x24B0F71 VA: 0x24B0E70
	|-Array.Sort<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x24B0FF0 Offset: 0x24B10F1 VA: 0x24B0FF0
	|-Array.Sort<UICharInfo>
	|
	|-RVA: 0x24B1170 Offset: 0x24B1271 VA: 0x24B1170
	|-Array.Sort<FocusController.FocusedElement>
	|
	|-RVA: 0x24B12F0 Offset: 0x24B13F1 VA: 0x24B12F0
	|-Array.Sort<UILineInfo>
	|
	|-RVA: 0x24B1470 Offset: 0x24B1571 VA: 0x24B1470
	|-Array.Sort<UIVertex>
	|
	|-RVA: 0x24B15F0 Offset: 0x24B16F1 VA: 0x24B15F0
	|-Array.Sort<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x24B1770 Offset: 0x24B1871 VA: 0x24B1770
	|-Array.Sort<Vector2>
	|
	|-RVA: 0x24B18F0 Offset: 0x24B19F1 VA: 0x24B18F0
	|-Array.Sort<Vector2Int>
	|
	|-RVA: 0x24B1A70 Offset: 0x24B1B71 VA: 0x24B1A70
	|-Array.Sort<Vector3>
	|
	|-RVA: 0x24B1BF0 Offset: 0x24B1CF1 VA: 0x24B1BF0
	|-Array.Sort<Vector3Int>
	|
	|-RVA: 0x24B1D70 Offset: 0x24B1E71 VA: 0x24B1D70
	|-Array.Sort<Vector4>
	|
	|-RVA: 0x24B1EF0 Offset: 0x24B1FF1 VA: 0x24B1EF0
	|-Array.Sort<WarpPoints.WarpPoint>
	|
	|-RVA: 0x24B2070 Offset: 0x24B2171 VA: 0x24B2070
	|-Array.Sort<YieldItemParam>
	|
	|-RVA: 0x24B21F0 Offset: 0x24B22F1 VA: 0x24B21F0
	|-Array.Sort<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24AAC30 Offset: 0x24AAD31 VA: 0x24AAC30
	|-Array.Sort<object>
	|-Array.Sort<TimelineClip>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24AA750 Offset: 0x24AA851 VA: 0x24AA750
	|-Array.Sort<object, object>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24AA8C0 Offset: 0x24AA9C1 VA: 0x24AA8C0
	|-Array.Sort<object, object>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24AA800 Offset: 0x24AA901 VA: 0x24AA800
	|-Array.Sort<object, object>
	|
	|-RVA: 0x24AB4A0 Offset: 0x24AB5A1 VA: 0x24AB4A0
	|-Array.Sort<ulong, object>
	|-Array.Sort<ulong, string>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24AA8E0 Offset: 0x24AA9E1 VA: 0x24AA8E0
	|-Array.Sort<object, object>
	|
	|-RVA: 0x24AB560 Offset: 0x24AB661 VA: 0x24AB560
	|-Array.Sort<ulong, object>
	*/

	// RVA: -1 Offset: -1
	public static bool Exists<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519DD0 Offset: 0x2519ED1 VA: 0x2519DD0
	|-Array.Exists<object>
	|-Array.Exists<string>
	|-Array.Exists<Face>
	*/

	// RVA: -1 Offset: -1
	public static void Fill<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D89B0 Offset: 0x21D8AB1 VA: 0x21D89B0
	|-Array.Fill<object>
	*/

	// RVA: -1 Offset: -1
	public static void Fill<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D8A90 Offset: 0x21D8B91 VA: 0x21D8A90
	|-Array.Fill<object>
	*/

	// RVA: -1 Offset: -1
	public static T Find<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C8B30 Offset: 0x23C8C31 VA: 0x23C8B30
	|-Array.Find<ActionCodeDataTable>
	|-Array.Find<MonsterActionCodeDataTable>
	|-Array.Find<FriendMonsterIDAndHouseID>
	|-Array.Find<MonsterSearchRangePair>
	|-Array.Find<Animator>
	|-Array.Find<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindAll<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2270AC0 Offset: 0x2270BC1 VA: 0x2270AC0
	|-Array.FindAll<FriendMonsterIDAndHouseID>
	|-Array.FindAll<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B1E70 Offset: 0x21B1F71 VA: 0x21B1E70
	|-Array.FindIndex<object>
	|-Array.FindIndex<Material>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B1DB0 Offset: 0x21B1EB1 VA: 0x21B1DB0
	|-Array.FindIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B1BE0 Offset: 0x21B1CE1 VA: 0x21B1BE0
	|-Array.FindIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindLast<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C8C60 Offset: 0x23C8D61 VA: 0x23C8C60
	|-Array.FindLast<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindLastIndex<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B21B0 Offset: 0x21B22B1 VA: 0x21B21B0
	|-Array.FindLastIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B20F0 Offset: 0x21B21F1 VA: 0x21B20F0
	|-Array.FindLastIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B1F20 Offset: 0x21B2021 VA: 0x21B1F20
	|-Array.FindLastIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TrueForAll<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22C86A0 Offset: 0x22C87A1 VA: 0x22C86A0
	|-Array.TrueForAll<object>
	*/

	// RVA: 0x184D3C0 Offset: 0x184D4C1 VA: 0x184D3C0 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x184D4C0 Offset: 0x184D5C1 VA: 0x184D4C0
	private void .ctor() { }

	// RVA: 0x184D4D0 Offset: 0x184D5D1 VA: 0x184D4D0
	internal int InternalArray__ICollection_get_Count() { }

	// RVA: 0x184D540 Offset: 0x184D641 VA: 0x184D540
	internal bool InternalArray__ICollection_get_IsReadOnly() { }

	// RVA: -1 Offset: -1
	internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212F320 Offset: 0x212F421 VA: 0x212F320
	|-Array.InternalArray__IEnumerable_GetEnumerator<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x212F430 Offset: 0x212F531 VA: 0x212F430
	|-Array.InternalArray__IEnumerable_GetEnumerator<ActionCommandDataTable>
	|
	|-RVA: 0x212F540 Offset: 0x212F641 VA: 0x212F540
	|-Array.InternalArray__IEnumerable_GetEnumerator<AdvScriptDefCountParam>
	|
	|-RVA: 0x212F650 Offset: 0x212F751 VA: 0x212F650
	|-Array.InternalArray__IEnumerable_GetEnumerator<JSONDeserialization.TaskField>
	|
	|-RVA: 0x212F760 Offset: 0x212F861 VA: 0x212F760
	|-Array.InternalArray__IEnumerable_GetEnumerator<BitVector32Int>
	|
	|-RVA: 0x212F870 Offset: 0x212F971 VA: 0x212F870
	|-Array.InternalArray__IEnumerable_GetEnumerator<BuildItemData>
	|
	|-RVA: 0x212F980 Offset: 0x212FA81 VA: 0x212F980
	|-Array.InternalArray__IEnumerable_GetEnumerator<ButtonLinker.LinkObject>
	|
	|-RVA: 0x212FA90 Offset: 0x212FB91 VA: 0x212FA90
	|-Array.InternalArray__IEnumerable_GetEnumerator<CharaCallTable.BustupTable>
	|
	|-RVA: 0x212FBA0 Offset: 0x212FCA1 VA: 0x212FBA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x212FCB0 Offset: 0x212FDB1 VA: 0x212FCB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CameraState.CustomBlendable>
	|
	|-RVA: 0x212FDC0 Offset: 0x212FEC1 VA: 0x212FDC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x212FED0 Offset: 0x212FFD1 VA: 0x212FED0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x212FFE0 Offset: 0x21300E1 VA: 0x212FFE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineClearShot.Pair>
	|
	|-RVA: 0x21300F0 Offset: 0x21301F1 VA: 0x21300F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x2130200 Offset: 0x2130301 VA: 0x2130200
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachinePath.Waypoint>
	|
	|-RVA: 0x2130310 Offset: 0x2130411 VA: 0x2130310
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x2130420 Offset: 0x2130521 VA: 0x2130420
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2130530 Offset: 0x2130631 VA: 0x2130530
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x2130640 Offset: 0x2130741 VA: 0x2130640
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x2130750 Offset: 0x2130851 VA: 0x2130750
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x2130860 Offset: 0x2130961 VA: 0x2130860
	|-Array.InternalArray__IEnumerable_GetEnumerator<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x2130970 Offset: 0x2130A71 VA: 0x2130970
	|-Array.InternalArray__IEnumerable_GetEnumerator<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2130A80 Offset: 0x2130B81 VA: 0x2130A80
	|-Array.InternalArray__IEnumerable_GetEnumerator<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x2130B90 Offset: 0x2130C91 VA: 0x2130B90
	|-Array.InternalArray__IEnumerable_GetEnumerator<HeadingTracker.Item>
	|
	|-RVA: 0x2130CA0 Offset: 0x2130DA1 VA: 0x2130CA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CropDataTable>
	|
	|-RVA: 0x2130DB0 Offset: 0x2130EB1 VA: 0x2130DB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ControlPoint>
	|
	|-RVA: 0x2130EC0 Offset: 0x2130FC1 VA: 0x2130EC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DamageTextInfo>
	|
	|-RVA: 0x2130FD0 Offset: 0x21310D1 VA: 0x2130FD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x21310E0 Offset: 0x21311E1 VA: 0x21310E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DropItemParam>
	|
	|-RVA: 0x21311F0 Offset: 0x21312F1 VA: 0x21311F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DropTableElement>
	|
	|-RVA: 0x2131300 Offset: 0x2131401 VA: 0x2131300
	|-Array.InternalArray__IEnumerable_GetEnumerator<EffectDataTable>
	|
	|-RVA: 0x2131410 Offset: 0x2131511 VA: 0x2131410
	|-Array.InternalArray__IEnumerable_GetEnumerator<EnemyPatrolPoints>
	|
	|-RVA: 0x2131520 Offset: 0x2131621 VA: 0x2131520
	|-Array.InternalArray__IEnumerable_GetEnumerator<Coord>
	|
	|-RVA: 0x2131630 Offset: 0x2131731 VA: 0x2131630
	|-Array.InternalArray__IEnumerable_GetEnumerator<ErosionBrush.UndoStep>
	|
	|-RVA: 0x2131740 Offset: 0x2131841 VA: 0x2131740
	|-Array.InternalArray__IEnumerable_GetEnumerator<EventCheckId>
	|
	|-RVA: 0x2131850 Offset: 0x2131951 VA: 0x2131850
	|-Array.InternalArray__IEnumerable_GetEnumerator<EventFlagProgressData>
	|
	|-RVA: 0x2131960 Offset: 0x2131A61 VA: 0x2131960
	|-Array.InternalArray__IEnumerable_GetEnumerator<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x2131A70 Offset: 0x2131B71 VA: 0x2131A70
	|-Array.InternalArray__IEnumerable_GetEnumerator<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x2131B80 Offset: 0x2131C81 VA: 0x2131B80
	|-Array.InternalArray__IEnumerable_GetEnumerator<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2131C90 Offset: 0x2131D91 VA: 0x2131C90
	|-Array.InternalArray__IEnumerable_GetEnumerator<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2131DA0 Offset: 0x2131EA1 VA: 0x2131DA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2131EB0 Offset: 0x2131FB1 VA: 0x2131EB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x2131FC0 Offset: 0x21320C1 VA: 0x2131FC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<FesNpcScoreData>
	|
	|-RVA: 0x21320D0 Offset: 0x21321D1 VA: 0x21320D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x21321E0 Offset: 0x21322E1 VA: 0x21321E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<FieldItemSpawnDataTable>
	|
	|-RVA: 0x21322F0 Offset: 0x21323F1 VA: 0x21322F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x2132400 Offset: 0x2132501 VA: 0x2132400
	|-Array.InternalArray__IEnumerable_GetEnumerator<FieldSceneData.Data>
	|
	|-RVA: 0x2132510 Offset: 0x2132611 VA: 0x2132510
	|-Array.InternalArray__IEnumerable_GetEnumerator<FieldTreasureBoxItemData>
	|
	|-RVA: 0x2132620 Offset: 0x2132721 VA: 0x2132620
	|-Array.InternalArray__IEnumerable_GetEnumerator<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x2132730 Offset: 0x2132831 VA: 0x2132730
	|-Array.InternalArray__IEnumerable_GetEnumerator<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x2132840 Offset: 0x2132941 VA: 0x2132840
	|-Array.InternalArray__IEnumerable_GetEnumerator<FocusObjectDataTable>
	|
	|-RVA: 0x2132950 Offset: 0x2132A51 VA: 0x2132950
	|-Array.InternalArray__IEnumerable_GetEnumerator<FurnitureData>
	|
	|-RVA: 0x2132A60 Offset: 0x2132B61 VA: 0x2132A60
	|-Array.InternalArray__IEnumerable_GetEnumerator<GateDataTable>
	|
	|-RVA: 0x2132B70 Offset: 0x2132C71 VA: 0x2132B70
	|-Array.InternalArray__IEnumerable_GetEnumerator<GateStatusDataTable>
	|
	|-RVA: 0x2132C80 Offset: 0x2132D81 VA: 0x2132C80
	|-Array.InternalArray__IEnumerable_GetEnumerator<GimmickLayoutDataTable>
	|
	|-RVA: 0x2132D90 Offset: 0x2132E91 VA: 0x2132D90
	|-Array.InternalArray__IEnumerable_GetEnumerator<HitResult>
	|
	|-RVA: 0x2132EA0 Offset: 0x2132FA1 VA: 0x2132EA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x2132FB0 Offset: 0x21330B1 VA: 0x2132FB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<FurnitureManager.SendPos>
	|
	|-RVA: 0x21330C0 Offset: 0x21331C1 VA: 0x21330C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ItemLevelData>
	|
	|-RVA: 0x21331D0 Offset: 0x21332D1 VA: 0x21331D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapDatas.MapData>
	|
	|-RVA: 0x21332E0 Offset: 0x21333E1 VA: 0x21332E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x21333F0 Offset: 0x21334F1 VA: 0x21333F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x2133500 Offset: 0x2133601 VA: 0x2133500
	|-Array.InternalArray__IEnumerable_GetEnumerator<MineTypeDataTable>
	|
	|-RVA: 0x2133610 Offset: 0x2133711 VA: 0x2133610
	|-Array.InternalArray__IEnumerable_GetEnumerator<MiningDataTable>
	|
	|-RVA: 0x2133720 Offset: 0x2133821 VA: 0x2133720
	|-Array.InternalArray__IEnumerable_GetEnumerator<MiningPointSaveData>
	|
	|-RVA: 0x2133830 Offset: 0x2133931 VA: 0x2133830
	|-Array.InternalArray__IEnumerable_GetEnumerator<CodePointIndexer.TableRange>
	|
	|-RVA: 0x2133940 Offset: 0x2133A41 VA: 0x2133940
	|-Array.InternalArray__IEnumerable_GetEnumerator<MonsterBehaviorDataTable>
	|
	|-RVA: 0x2133A50 Offset: 0x2133B51 VA: 0x2133A50
	|-Array.InternalArray__IEnumerable_GetEnumerator<MonsterDataTable>
	|
	|-RVA: 0x2133B60 Offset: 0x2133C61 VA: 0x2133B60
	|-Array.InternalArray__IEnumerable_GetEnumerator<MonsterDropItemDataTable>
	|
	|-RVA: 0x2133C70 Offset: 0x2133D71 VA: 0x2133C70
	|-Array.InternalArray__IEnumerable_GetEnumerator<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x2133D80 Offset: 0x2133E81 VA: 0x2133D80
	|-Array.InternalArray__IEnumerable_GetEnumerator<MonsterHutSaveData>
	|
	|-RVA: 0x2133E90 Offset: 0x2133F91 VA: 0x2133E90
	|-Array.InternalArray__IEnumerable_GetEnumerator<MonsterUIData.Data>
	|
	|-RVA: 0x2133FA0 Offset: 0x21340A1 VA: 0x2133FA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MonsterYieldItemDataTable>
	|
	|-RVA: 0x21340B0 Offset: 0x21341B1 VA: 0x21340B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x21341C0 Offset: 0x21342C1 VA: 0x21341C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NPCActionData>
	|
	|-RVA: 0x21342D0 Offset: 0x21343D1 VA: 0x21342D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x21343E0 Offset: 0x21344E1 VA: 0x21343E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NPCUIData.Data>
	|
	|-RVA: 0x21344F0 Offset: 0x21345F1 VA: 0x21344F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpcPlaceSchedule>
	|
	|-RVA: 0x2134600 Offset: 0x2134701 VA: 0x2134600
	|-Array.InternalArray__IEnumerable_GetEnumerator<OrderLotterySaveParameter>
	|
	|-RVA: 0x2134710 Offset: 0x2134811 VA: 0x2134710
	|-Array.InternalArray__IEnumerable_GetEnumerator<OrderSaveData>
	|
	|-RVA: 0x2134820 Offset: 0x2134921 VA: 0x2134820
	|-Array.InternalArray__IEnumerable_GetEnumerator<OrderSaveParameter>
	|
	|-RVA: 0x2134930 Offset: 0x2134A31 VA: 0x2134930
	|-Array.InternalArray__IEnumerable_GetEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2134A40 Offset: 0x2134B41 VA: 0x2134A40
	|-Array.InternalArray__IEnumerable_GetEnumerator<Parameter>
	|
	|-RVA: 0x2134B50 Offset: 0x2134C51 VA: 0x2134B50
	|-Array.InternalArray__IEnumerable_GetEnumerator<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x2134C60 Offset: 0x2134D61 VA: 0x2134C60
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x2134D70 Offset: 0x2134E71 VA: 0x2134D70
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShopCatalogPage>
	|
	|-RVA: 0x2134E80 Offset: 0x2134F81 VA: 0x2134E80
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShopNpcTalk>
	|
	|-RVA: 0x2134F90 Offset: 0x2135091 VA: 0x2134F90
	|-Array.InternalArray__IEnumerable_GetEnumerator<SubtitleDataTable.Data>
	|
	|-RVA: 0x21350A0 Offset: 0x21351A1 VA: 0x21350A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SubtitleDataTable.DataList>
	|
	|-RVA: 0x21351B0 Offset: 0x21352B1 VA: 0x21351B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x21352C0 Offset: 0x21353C1 VA: 0x21352C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AnimationWarping.Warp>
	|
	|-RVA: 0x21353D0 Offset: 0x21354D1 VA: 0x21353D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GrounderQuadruped.Foot>
	|
	|-RVA: 0x21354E0 Offset: 0x21355E1 VA: 0x21354E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x21355F0 Offset: 0x21356F1 VA: 0x21355F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProfilerFrame>
	|
	|-RVA: 0x2135700 Offset: 0x2135801 VA: 0x2135700
	|-Array.InternalArray__IEnumerable_GetEnumerator<NumberControl.ValueRange>
	|
	|-RVA: 0x2135810 Offset: 0x2135911 VA: 0x2135810
	|-Array.InternalArray__IEnumerable_GetEnumerator<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x2135920 Offset: 0x2135A21 VA: 0x2135920
	|-Array.InternalArray__IEnumerable_GetEnumerator<ResponsiveEnable.Entry>
	|
	|-RVA: 0x2135A30 Offset: 0x2135B31 VA: 0x2135A30
	|-Array.InternalArray__IEnumerable_GetEnumerator<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x2135B40 Offset: 0x2135C41 VA: 0x2135B40
	|-Array.InternalArray__IEnumerable_GetEnumerator<ResponsiveResize.Element>
	|
	|-RVA: 0x2135C50 Offset: 0x2135D51 VA: 0x2135C50
	|-Array.InternalArray__IEnumerable_GetEnumerator<Schedule>
	|
	|-RVA: 0x2135D60 Offset: 0x2135E61 VA: 0x2135D60
	|-Array.InternalArray__IEnumerable_GetEnumerator<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x2135E70 Offset: 0x2135F71 VA: 0x2135E70
	|-Array.InternalArray__IEnumerable_GetEnumerator<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x2135F80 Offset: 0x2136081 VA: 0x2135F80
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpeedData>
	|
	|-RVA: 0x2136090 Offset: 0x2136191 VA: 0x2136090
	|-Array.InternalArray__IEnumerable_GetEnumerator<CurveSample>
	|
	|-RVA: 0x21361A0 Offset: 0x21362A1 VA: 0x21361A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x21362B0 Offset: 0x21363B1 VA: 0x21362B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<StringFormatData.FormatData>
	|
	|-RVA: 0x21363C0 Offset: 0x21364C1 VA: 0x21363C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x21364D0 Offset: 0x21365D1 VA: 0x21364D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ArraySegment<byte>>
	|
	|-RVA: 0x21365E0 Offset: 0x21366E1 VA: 0x21365E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ArraySegment<object>>
	|
	|-RVA: 0x21366F0 Offset: 0x21367F1 VA: 0x21366F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<bool>
	|
	|-RVA: 0x2136800 Offset: 0x2136901 VA: 0x2136800
	|-Array.InternalArray__IEnumerable_GetEnumerator<byte>
	|
	|-RVA: 0x2136910 Offset: 0x2136A11 VA: 0x2136910
	|-Array.InternalArray__IEnumerable_GetEnumerator<ByteEnum>
	|
	|-RVA: 0x2136A20 Offset: 0x2136B21 VA: 0x2136A20
	|-Array.InternalArray__IEnumerable_GetEnumerator<char>
	|
	|-RVA: 0x2136B30 Offset: 0x2136C31 VA: 0x2136B30
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x2136C40 Offset: 0x2136D41 VA: 0x2136C40
	|-Array.InternalArray__IEnumerable_GetEnumerator<DictionaryEntry>
	|
	|-RVA: 0x2136D50 Offset: 0x2136E51 VA: 0x2136D50
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x2136E60 Offset: 0x2136F61 VA: 0x2136E60
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x2136F70 Offset: 0x2137071 VA: 0x2136F70
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x2137080 Offset: 0x2137181 VA: 0x2137080
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x2137190 Offset: 0x2137291 VA: 0x2137190
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x21372A0 Offset: 0x21373A1 VA: 0x21372A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x21373B0 Offset: 0x21374B1 VA: 0x21373B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x21374C0 Offset: 0x21375C1 VA: 0x21374C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x21375D0 Offset: 0x21376D1 VA: 0x21375D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x21376E0 Offset: 0x21377E1 VA: 0x21376E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x21377F0 Offset: 0x21378F1 VA: 0x21377F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x2137900 Offset: 0x2137A01 VA: 0x2137900
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x2137A10 Offset: 0x2137B11 VA: 0x2137A10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x2137B20 Offset: 0x2137C21 VA: 0x2137B20
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x2137C30 Offset: 0x2137D31 VA: 0x2137C30
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x2137D40 Offset: 0x2137E41 VA: 0x2137D40
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x2137E50 Offset: 0x2137F51 VA: 0x2137E50
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x2137F60 Offset: 0x2138061 VA: 0x2137F60
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x2138070 Offset: 0x2138171 VA: 0x2138070
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x2138180 Offset: 0x2138281 VA: 0x2138180
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x2138290 Offset: 0x2138391 VA: 0x2138290
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x21383A0 Offset: 0x21384A1 VA: 0x21383A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x21384B0 Offset: 0x21385B1 VA: 0x21384B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x21385C0 Offset: 0x21386C1 VA: 0x21385C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x21386D0 Offset: 0x21387D1 VA: 0x21386D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x21387E0 Offset: 0x21388E1 VA: 0x21387E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x21388F0 Offset: 0x21389F1 VA: 0x21388F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x2138A00 Offset: 0x2138B01 VA: 0x2138A00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x2138B10 Offset: 0x2138C11 VA: 0x2138B10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x2138C20 Offset: 0x2138D21 VA: 0x2138C20
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x2138D30 Offset: 0x2138E31 VA: 0x2138D30
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x2138E40 Offset: 0x2138F41 VA: 0x2138E40
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x2138F50 Offset: 0x2139051 VA: 0x2138F50
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x2139060 Offset: 0x2139161 VA: 0x2139060
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x2139170 Offset: 0x2139271 VA: 0x2139170
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x2139280 Offset: 0x2139381 VA: 0x2139280
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x2139390 Offset: 0x2139491 VA: 0x2139390
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x21394A0 Offset: 0x21395A1 VA: 0x21394A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x21395B0 Offset: 0x21396B1 VA: 0x21395B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x21396C0 Offset: 0x21397C1 VA: 0x21396C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x21397D0 Offset: 0x21398D1 VA: 0x21397D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x21398E0 Offset: 0x21399E1 VA: 0x21398E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x21399F0 Offset: 0x2139AF1 VA: 0x21399F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x2139B00 Offset: 0x2139C01 VA: 0x2139B00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x2139C10 Offset: 0x2139D11 VA: 0x2139C10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x2139D20 Offset: 0x2139E21 VA: 0x2139D20
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x2139E30 Offset: 0x2139F31 VA: 0x2139E30
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x2139F40 Offset: 0x213A041 VA: 0x2139F40
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x213A050 Offset: 0x213A151 VA: 0x213A050
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x213A160 Offset: 0x213A261 VA: 0x213A160
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x213A270 Offset: 0x213A371 VA: 0x213A270
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x213A380 Offset: 0x213A481 VA: 0x213A380
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x213A490 Offset: 0x213A591 VA: 0x213A490
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x213A5A0 Offset: 0x213A6A1 VA: 0x213A5A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x213A6B0 Offset: 0x213A7B1 VA: 0x213A6B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x213A7C0 Offset: 0x213A8C1 VA: 0x213A7C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x213A8D0 Offset: 0x213A9D1 VA: 0x213A8D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x213A9E0 Offset: 0x213AAE1 VA: 0x213A9E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x213AAF0 Offset: 0x213ABF1 VA: 0x213AAF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x213AC00 Offset: 0x213AD01 VA: 0x213AC00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x213AD10 Offset: 0x213AE11 VA: 0x213AD10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x213AE20 Offset: 0x213AF21 VA: 0x213AE20
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x213AF30 Offset: 0x213B031 VA: 0x213AF30
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x213B040 Offset: 0x213B141 VA: 0x213B040
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x213B150 Offset: 0x213B251 VA: 0x213B150
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x213B260 Offset: 0x213B361 VA: 0x213B260
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x213B370 Offset: 0x213B471 VA: 0x213B370
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x213B480 Offset: 0x213B581 VA: 0x213B480
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x213B590 Offset: 0x213B691 VA: 0x213B590
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x213B6A0 Offset: 0x213B7A1 VA: 0x213B6A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x213B7B0 Offset: 0x213B8B1 VA: 0x213B7B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x213B8C0 Offset: 0x213B9C1 VA: 0x213B8C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x213B9D0 Offset: 0x213BAD1 VA: 0x213B9D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x213BAE0 Offset: 0x213BBE1 VA: 0x213BAE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x213BBF0 Offset: 0x213BCF1 VA: 0x213BBF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x213BD00 Offset: 0x213BE01 VA: 0x213BD00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x213BE10 Offset: 0x213BF11 VA: 0x213BE10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x213BF20 Offset: 0x213C021 VA: 0x213BF20
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x213C030 Offset: 0x213C131 VA: 0x213C030
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x213C140 Offset: 0x213C241 VA: 0x213C140
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x213C250 Offset: 0x213C351 VA: 0x213C250
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x213C360 Offset: 0x213C461 VA: 0x213C360
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x213C470 Offset: 0x213C571 VA: 0x213C470
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x213C580 Offset: 0x213C681 VA: 0x213C580
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x213C690 Offset: 0x213C791 VA: 0x213C690
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x213C7A0 Offset: 0x213C8A1 VA: 0x213C7A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x213C8B0 Offset: 0x213C9B1 VA: 0x213C8B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x213C9C0 Offset: 0x213CAC1 VA: 0x213C9C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x213CAD0 Offset: 0x213CBD1 VA: 0x213CAD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x213CBE0 Offset: 0x213CCE1 VA: 0x213CBE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x213CCF0 Offset: 0x213CDF1 VA: 0x213CCF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x213CE00 Offset: 0x213CF01 VA: 0x213CE00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x213CF10 Offset: 0x213D011 VA: 0x213CF10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x213D020 Offset: 0x213D121 VA: 0x213D020
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x213D130 Offset: 0x213D231 VA: 0x213D130
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x213D240 Offset: 0x213D341 VA: 0x213D240
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x213D350 Offset: 0x213D451 VA: 0x213D350
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x213D460 Offset: 0x213D561 VA: 0x213D460
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x213D570 Offset: 0x213D671 VA: 0x213D570
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x213D680 Offset: 0x213D781 VA: 0x213D680
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x213D790 Offset: 0x213D891 VA: 0x213D790
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x213D8A0 Offset: 0x213D9A1 VA: 0x213D8A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x213D9B0 Offset: 0x213DAB1 VA: 0x213D9B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x213DAC0 Offset: 0x213DBC1 VA: 0x213DAC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x213DBD0 Offset: 0x213DCD1 VA: 0x213DBD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x213DCE0 Offset: 0x213DDE1 VA: 0x213DCE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x213DDF0 Offset: 0x213DEF1 VA: 0x213DDF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x213DF00 Offset: 0x213E001 VA: 0x213DF00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x213E010 Offset: 0x213E111 VA: 0x213E010
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x213E120 Offset: 0x213E221 VA: 0x213E120
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x213E230 Offset: 0x213E331 VA: 0x213E230
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x213E340 Offset: 0x213E441 VA: 0x213E340
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x213E450 Offset: 0x213E551 VA: 0x213E450
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x213E560 Offset: 0x213E661 VA: 0x213E560
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x213E670 Offset: 0x213E771 VA: 0x213E670
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x213E780 Offset: 0x213E881 VA: 0x213E780
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x213E890 Offset: 0x213E991 VA: 0x213E890
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x213E9A0 Offset: 0x213EAA1 VA: 0x213E9A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x213EAB0 Offset: 0x213EBB1 VA: 0x213EAB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x213EBC0 Offset: 0x213ECC1 VA: 0x213EBC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x213ECD0 Offset: 0x213EDD1 VA: 0x213ECD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x213EDE0 Offset: 0x213EEE1 VA: 0x213EDE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x213EEF0 Offset: 0x213EFF1 VA: 0x213EEF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x213F000 Offset: 0x213F101 VA: 0x213F000
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x213F110 Offset: 0x213F211 VA: 0x213F110
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x213F220 Offset: 0x213F321 VA: 0x213F220
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x213F330 Offset: 0x213F431 VA: 0x213F330
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x213F440 Offset: 0x213F541 VA: 0x213F440
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x213F550 Offset: 0x213F651 VA: 0x213F550
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x213F660 Offset: 0x213F761 VA: 0x213F660
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x213F770 Offset: 0x213F871 VA: 0x213F770
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x213F880 Offset: 0x213F981 VA: 0x213F880
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x213F990 Offset: 0x213FA91 VA: 0x213F990
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x213FAA0 Offset: 0x213FBA1 VA: 0x213FAA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x213FBB0 Offset: 0x213FCB1 VA: 0x213FBB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x213FCC0 Offset: 0x213FDC1 VA: 0x213FCC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x213FDD0 Offset: 0x213FED1 VA: 0x213FDD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x213FEE0 Offset: 0x213FFE1 VA: 0x213FEE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x213FFF0 Offset: 0x21400F1 VA: 0x213FFF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x2140100 Offset: 0x2140201 VA: 0x2140100
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x2140210 Offset: 0x2140311 VA: 0x2140210
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x2140320 Offset: 0x2140421 VA: 0x2140320
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x2140430 Offset: 0x2140531 VA: 0x2140430
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x2140540 Offset: 0x2140641 VA: 0x2140540
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x2140650 Offset: 0x2140751 VA: 0x2140650
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x2140760 Offset: 0x2140861 VA: 0x2140760
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x2140870 Offset: 0x2140971 VA: 0x2140870
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x2140980 Offset: 0x2140A81 VA: 0x2140980
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x2140A90 Offset: 0x2140B91 VA: 0x2140A90
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x2140BA0 Offset: 0x2140CA1 VA: 0x2140BA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x2140CB0 Offset: 0x2140DB1 VA: 0x2140CB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x2140DC0 Offset: 0x2140EC1 VA: 0x2140DC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x2140ED0 Offset: 0x2140FD1 VA: 0x2140ED0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x2140FE0 Offset: 0x21410E1 VA: 0x2140FE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x21410F0 Offset: 0x21411F1 VA: 0x21410F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x2141200 Offset: 0x2141301 VA: 0x2141200
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x2141310 Offset: 0x2141411 VA: 0x2141310
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x2141420 Offset: 0x2141521 VA: 0x2141420
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x2141530 Offset: 0x2141631 VA: 0x2141530
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2141640 Offset: 0x2141741 VA: 0x2141640
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x2141750 Offset: 0x2141851 VA: 0x2141750
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x2141860 Offset: 0x2141961 VA: 0x2141860
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x2141970 Offset: 0x2141A71 VA: 0x2141970
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x2141A80 Offset: 0x2141B81 VA: 0x2141A80
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x2141B90 Offset: 0x2141C91 VA: 0x2141B90
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x2141CA0 Offset: 0x2141DA1 VA: 0x2141CA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x2141DB0 Offset: 0x2141EB1 VA: 0x2141DB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x2141EC0 Offset: 0x2141FC1 VA: 0x2141EC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x2141FD0 Offset: 0x21420D1 VA: 0x2141FD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x21420E0 Offset: 0x21421E1 VA: 0x21420E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x21421F0 Offset: 0x21422F1 VA: 0x21421F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x2142300 Offset: 0x2142401 VA: 0x2142300
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x2142410 Offset: 0x2142511 VA: 0x2142410
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x2142520 Offset: 0x2142621 VA: 0x2142520
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x2142630 Offset: 0x2142731 VA: 0x2142630
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x2142740 Offset: 0x2142841 VA: 0x2142740
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x2142850 Offset: 0x2142951 VA: 0x2142850
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<int>>
	|
	|-RVA: 0x2142960 Offset: 0x2142A61 VA: 0x2142960
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x2142A70 Offset: 0x2142B71 VA: 0x2142A70
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<object>>
	|
	|-RVA: 0x2142B80 Offset: 0x2142C81 VA: 0x2142B80
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<uint>>
	|
	|-RVA: 0x2142C90 Offset: 0x2142D91 VA: 0x2142C90
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<Edge>>
	|
	|-RVA: 0x2142DA0 Offset: 0x2142EA1 VA: 0x2142DA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x2142EB0 Offset: 0x2142FB1 VA: 0x2142EB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x2142FC0 Offset: 0x21430C1 VA: 0x2142FC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x21430D0 Offset: 0x21431D1 VA: 0x21430D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x21431E0 Offset: 0x21432E1 VA: 0x21431E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x21432F0 Offset: 0x21433F1 VA: 0x21432F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x2143400 Offset: 0x2143501 VA: 0x2143400
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x2143510 Offset: 0x2143611 VA: 0x2143510
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x2143620 Offset: 0x2143721 VA: 0x2143620
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x2143730 Offset: 0x2143831 VA: 0x2143730
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x2143840 Offset: 0x2143941 VA: 0x2143840
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x2143950 Offset: 0x2143A51 VA: 0x2143950
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x2143A60 Offset: 0x2143B61 VA: 0x2143A60
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x2143B70 Offset: 0x2143C71 VA: 0x2143B70
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<bool, object>>
	|
	|-RVA: 0x2143C80 Offset: 0x2143D81 VA: 0x2143C80
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<byte, object>>
	|
	|-RVA: 0x2143D90 Offset: 0x2143E91 VA: 0x2143D90
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<char, object>>
	|
	|-RVA: 0x2143EA0 Offset: 0x2143FA1 VA: 0x2143EA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2143FB0 Offset: 0x21440B1 VA: 0x2143FB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<double, object>>
	|
	|-RVA: 0x21440C0 Offset: 0x21441C1 VA: 0x21440C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x21441D0 Offset: 0x21442D1 VA: 0x21441D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<short, object>>
	|
	|-RVA: 0x21442E0 Offset: 0x21443E1 VA: 0x21442E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x21443F0 Offset: 0x21444F1 VA: 0x21443F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x2144500 Offset: 0x2144601 VA: 0x2144500
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x2144610 Offset: 0x2144711 VA: 0x2144610
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x2144720 Offset: 0x2144821 VA: 0x2144720
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x2144830 Offset: 0x2144931 VA: 0x2144830
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, bool>>
	|
	|-RVA: 0x2144940 Offset: 0x2144A41 VA: 0x2144940
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, char>>
	|
	|-RVA: 0x2144A50 Offset: 0x2144B51 VA: 0x2144A50
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, int>>
	|
	|-RVA: 0x2144B60 Offset: 0x2144C61 VA: 0x2144B60
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x2144C70 Offset: 0x2144D71 VA: 0x2144C70
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, long>>
	|
	|-RVA: 0x2144D80 Offset: 0x2144E81 VA: 0x2144D80
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, object>>
	|
	|-RVA: 0x2144E90 Offset: 0x2144F91 VA: 0x2144E90
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x2144FA0 Offset: 0x21450A1 VA: 0x2144FA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x21450B0 Offset: 0x21451B1 VA: 0x21450B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x21451C0 Offset: 0x21452C1 VA: 0x21451C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x21452D0 Offset: 0x21453D1 VA: 0x21452D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x21453E0 Offset: 0x21454E1 VA: 0x21453E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x21454F0 Offset: 0x21455F1 VA: 0x21454F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x2145600 Offset: 0x2145701 VA: 0x2145600
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x2145710 Offset: 0x2145811 VA: 0x2145710
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x2145820 Offset: 0x2145921 VA: 0x2145820
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x2145930 Offset: 0x2145A31 VA: 0x2145930
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2145A40 Offset: 0x2145B41 VA: 0x2145A40
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x2145B50 Offset: 0x2145C51 VA: 0x2145B50
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x2145C60 Offset: 0x2145D61 VA: 0x2145C60
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x2145D70 Offset: 0x2145E71 VA: 0x2145D70
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x2145E80 Offset: 0x2145F81 VA: 0x2145E80
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x2145F90 Offset: 0x2146091 VA: 0x2145F90
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<long, object>>
	|
	|-RVA: 0x21460A0 Offset: 0x21461A1 VA: 0x21460A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x21461B0 Offset: 0x21462B1 VA: 0x21461B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x21462C0 Offset: 0x21463C1 VA: 0x21462C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x21463D0 Offset: 0x21464D1 VA: 0x21463D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x21464E0 Offset: 0x21465E1 VA: 0x21464E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x21465F0 Offset: 0x21466F1 VA: 0x21465F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x2146700 Offset: 0x2146801 VA: 0x2146700
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x2146810 Offset: 0x2146911 VA: 0x2146810
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x2146920 Offset: 0x2146A21 VA: 0x2146920
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x2146A30 Offset: 0x2146B31 VA: 0x2146A30
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x2146B40 Offset: 0x2146C41 VA: 0x2146B40
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x2146C50 Offset: 0x2146D51 VA: 0x2146C50
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x2146D60 Offset: 0x2146E61 VA: 0x2146D60
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x2146E70 Offset: 0x2146F71 VA: 0x2146E70
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x2146F80 Offset: 0x2147081 VA: 0x2146F80
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x2147090 Offset: 0x2147191 VA: 0x2147090
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x21471A0 Offset: 0x21472A1 VA: 0x21471A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x21472B0 Offset: 0x21473B1 VA: 0x21472B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x21473C0 Offset: 0x21474C1 VA: 0x21473C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x21474D0 Offset: 0x21475D1 VA: 0x21474D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x21475E0 Offset: 0x21476E1 VA: 0x21475E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x21476F0 Offset: 0x21477F1 VA: 0x21476F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x2147800 Offset: 0x2147901 VA: 0x2147800
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x2147910 Offset: 0x2147A11 VA: 0x2147910
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x2147A20 Offset: 0x2147B21 VA: 0x2147A20
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x2147B30 Offset: 0x2147C31 VA: 0x2147B30
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x2147C40 Offset: 0x2147D41 VA: 0x2147C40
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x2147D50 Offset: 0x2147E51 VA: 0x2147D50
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x2147E60 Offset: 0x2147F61 VA: 0x2147E60
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x2147F70 Offset: 0x2148071 VA: 0x2147F70
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x2148080 Offset: 0x2148181 VA: 0x2148080
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x2148190 Offset: 0x2148291 VA: 0x2148190
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x21482A0 Offset: 0x21483A1 VA: 0x21482A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, bool>>
	|
	|-RVA: 0x21483B0 Offset: 0x21484B1 VA: 0x21483B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, byte>>
	|
	|-RVA: 0x21484C0 Offset: 0x21485C1 VA: 0x21484C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, char>>
	|
	|-RVA: 0x21485D0 Offset: 0x21486D1 VA: 0x21485D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x21486E0 Offset: 0x21487E1 VA: 0x21486E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, double>>
	|
	|-RVA: 0x21487F0 Offset: 0x21488F1 VA: 0x21487F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, short>>
	|
	|-RVA: 0x2148900 Offset: 0x2148A01 VA: 0x2148900
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, int>>
	|
	|-RVA: 0x2148A10 Offset: 0x2148B11 VA: 0x2148A10
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x2148B20 Offset: 0x2148C21 VA: 0x2148B20
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, long>>
	|
	|-RVA: 0x2148C30 Offset: 0x2148D31 VA: 0x2148C30
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x2148D40 Offset: 0x2148E41 VA: 0x2148D40
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x21937B0 Offset: 0x21938B1 VA: 0x21937B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x21938C0 Offset: 0x21939C1 VA: 0x21938C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x21939D0 Offset: 0x2193AD1 VA: 0x21939D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x2193AE0 Offset: 0x2193BE1 VA: 0x2193AE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x2193BF0 Offset: 0x2193CF1 VA: 0x2193BF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x2193D00 Offset: 0x2193E01 VA: 0x2193D00
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x2193E10 Offset: 0x2193F11 VA: 0x2193E10
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x2193F20 Offset: 0x2194021 VA: 0x2193F20
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x2194030 Offset: 0x2194131 VA: 0x2194030
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x2194140 Offset: 0x2194241 VA: 0x2194140
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x2194250 Offset: 0x2194351 VA: 0x2194250
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x2194360 Offset: 0x2194461 VA: 0x2194360
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x2194470 Offset: 0x2194571 VA: 0x2194470
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x2194580 Offset: 0x2194681 VA: 0x2194580
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x2194690 Offset: 0x2194791 VA: 0x2194690
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x21947A0 Offset: 0x21948A1 VA: 0x21947A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x21948B0 Offset: 0x21949B1 VA: 0x21948B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x21949C0 Offset: 0x2194AC1 VA: 0x21949C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x2194AD0 Offset: 0x2194BD1 VA: 0x2194AD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, object>>
	|
	|-RVA: 0x2194BE0 Offset: 0x2194CE1 VA: 0x2194BE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x2194CF0 Offset: 0x2194DF1 VA: 0x2194CF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x2194E00 Offset: 0x2194F01 VA: 0x2194E00
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x2194F10 Offset: 0x2195011 VA: 0x2194F10
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, float>>
	|
	|-RVA: 0x2195020 Offset: 0x2195121 VA: 0x2195020
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x2195130 Offset: 0x2195231 VA: 0x2195130
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, uint>>
	|
	|-RVA: 0x2195240 Offset: 0x2195341 VA: 0x2195240
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x2195350 Offset: 0x2195451 VA: 0x2195350
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x2195460 Offset: 0x2195561 VA: 0x2195460
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x2195570 Offset: 0x2195671 VA: 0x2195570
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x2195680 Offset: 0x2195781 VA: 0x2195680
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x2195790 Offset: 0x2195891 VA: 0x2195790
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Color>>
	|
	|-RVA: 0x21958A0 Offset: 0x21959A1 VA: 0x21958A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x21959B0 Offset: 0x2195AB1 VA: 0x21959B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x2195AC0 Offset: 0x2195BC1 VA: 0x2195AC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x2195BD0 Offset: 0x2195CD1 VA: 0x2195BD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x2195CE0 Offset: 0x2195DE1 VA: 0x2195CE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x2195DF0 Offset: 0x2195EF1 VA: 0x2195DF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x2195F00 Offset: 0x2196001 VA: 0x2195F00
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x2196010 Offset: 0x2196111 VA: 0x2196010
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x2196120 Offset: 0x2196221 VA: 0x2196120
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x2196230 Offset: 0x2196331 VA: 0x2196230
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x2196340 Offset: 0x2196441 VA: 0x2196340
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2196450 Offset: 0x2196551 VA: 0x2196450
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2196560 Offset: 0x2196661 VA: 0x2196560
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x2196670 Offset: 0x2196771 VA: 0x2196670
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x2196780 Offset: 0x2196881 VA: 0x2196780
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x2196890 Offset: 0x2196991 VA: 0x2196890
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x21969A0 Offset: 0x2196AA1 VA: 0x21969A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x2196AB0 Offset: 0x2196BB1 VA: 0x2196AB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x2196BC0 Offset: 0x2196CC1 VA: 0x2196BC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x2196CD0 Offset: 0x2196DD1 VA: 0x2196CD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x2196DE0 Offset: 0x2196EE1 VA: 0x2196DE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x2196EF0 Offset: 0x2196FF1 VA: 0x2196EF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<float, object>>
	|
	|-RVA: 0x2197000 Offset: 0x2197101 VA: 0x2197000
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x2197110 Offset: 0x2197211 VA: 0x2197110
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, int>>
	|
	|-RVA: 0x2197220 Offset: 0x2197321 VA: 0x2197220
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x2197330 Offset: 0x2197431 VA: 0x2197330
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, object>>
	|
	|-RVA: 0x2197440 Offset: 0x2197541 VA: 0x2197440
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x2197550 Offset: 0x2197651 VA: 0x2197550
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x2197660 Offset: 0x2197761 VA: 0x2197660
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x2197770 Offset: 0x2197871 VA: 0x2197770
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x2197880 Offset: 0x2197981 VA: 0x2197880
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x2197990 Offset: 0x2197A91 VA: 0x2197990
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x2197AA0 Offset: 0x2197BA1 VA: 0x2197AA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x2197BB0 Offset: 0x2197CB1 VA: 0x2197BB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x2197CC0 Offset: 0x2197DC1 VA: 0x2197CC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x2197DD0 Offset: 0x2197ED1 VA: 0x2197DD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Color, object>>
	|
	|-RVA: 0x2197EE0 Offset: 0x2197FE1 VA: 0x2197EE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x2197FF0 Offset: 0x21980F1 VA: 0x2197FF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2198100 Offset: 0x2198201 VA: 0x2198100
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x2198210 Offset: 0x2198311 VA: 0x2198210
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x2198320 Offset: 0x2198421 VA: 0x2198320
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x2198430 Offset: 0x2198531 VA: 0x2198430
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x2198540 Offset: 0x2198641 VA: 0x2198540
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x2198650 Offset: 0x2198751 VA: 0x2198650
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x2198760 Offset: 0x2198861 VA: 0x2198760
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x2198870 Offset: 0x2198971 VA: 0x2198870
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x2198980 Offset: 0x2198A81 VA: 0x2198980
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x2198A90 Offset: 0x2198B91 VA: 0x2198A90
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x2198BA0 Offset: 0x2198CA1 VA: 0x2198BA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x2198CB0 Offset: 0x2198DB1 VA: 0x2198CB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x2198DC0 Offset: 0x2198EC1 VA: 0x2198DC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x2198ED0 Offset: 0x2198FD1 VA: 0x2198ED0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x2198FE0 Offset: 0x21990E1 VA: 0x2198FE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x21990F0 Offset: 0x21991F1 VA: 0x21990F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x2199200 Offset: 0x2199301 VA: 0x2199200
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x2199310 Offset: 0x2199411 VA: 0x2199310
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hashtable.bucket>
	|
	|-RVA: 0x2199420 Offset: 0x2199521 VA: 0x2199420
	|-Array.InternalArray__IEnumerable_GetEnumerator<DateTime>
	|
	|-RVA: 0x2199530 Offset: 0x2199631 VA: 0x2199530
	|-Array.InternalArray__IEnumerable_GetEnumerator<DateTimeOffset>
	|
	|-RVA: 0x2199640 Offset: 0x2199741 VA: 0x2199640
	|-Array.InternalArray__IEnumerable_GetEnumerator<Decimal>
	|
	|-RVA: 0x2199750 Offset: 0x2199851 VA: 0x2199750
	|-Array.InternalArray__IEnumerable_GetEnumerator<double>
	|
	|-RVA: 0x2199860 Offset: 0x2199961 VA: 0x2199860
	|-Array.InternalArray__IEnumerable_GetEnumerator<InternalCodePageDataItem>
	|
	|-RVA: 0x2199970 Offset: 0x2199A71 VA: 0x2199970
	|-Array.InternalArray__IEnumerable_GetEnumerator<InternalEncodingDataItem>
	|
	|-RVA: 0x2199A80 Offset: 0x2199B81 VA: 0x2199A80
	|-Array.InternalArray__IEnumerable_GetEnumerator<Guid>
	|
	|-RVA: 0x2199B90 Offset: 0x2199C91 VA: 0x2199B90
	|-Array.InternalArray__IEnumerable_GetEnumerator<short>
	|
	|-RVA: 0x2199CA0 Offset: 0x2199DA1 VA: 0x2199CA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<int>
	|
	|-RVA: 0x2199DB0 Offset: 0x2199EB1 VA: 0x2199DB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Int32Enum>
	|
	|-RVA: 0x2199EC0 Offset: 0x2199FC1 VA: 0x2199EC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<long>
	|
	|-RVA: 0x2199FD0 Offset: 0x219A0D1 VA: 0x2199FD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntPtr>
	|
	|-RVA: 0x219A0E0 Offset: 0x219A1E1 VA: 0x219A0E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<InterpretedFrameInfo>
	|
	|-RVA: 0x219A1F0 Offset: 0x219A2F1 VA: 0x219A1F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<LocalDefinition>
	|
	|-RVA: 0x219A300 Offset: 0x219A401 VA: 0x219A300
	|-Array.InternalArray__IEnumerable_GetEnumerator<RuntimeLabel>
	|
	|-RVA: 0x219A410 Offset: 0x219A511 VA: 0x219A410
	|-Array.InternalArray__IEnumerable_GetEnumerator<Set.Slot<int>>
	|
	|-RVA: 0x219A520 Offset: 0x219A621 VA: 0x219A520
	|-Array.InternalArray__IEnumerable_GetEnumerator<Set.Slot<object>>
	|
	|-RVA: 0x219A630 Offset: 0x219A731 VA: 0x219A630
	|-Array.InternalArray__IEnumerable_GetEnumerator<Memory<object>>
	|
	|-RVA: 0x219A740 Offset: 0x219A841 VA: 0x219A740
	|-Array.InternalArray__IEnumerable_GetEnumerator<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x219A850 Offset: 0x219A951 VA: 0x219A850
	|-Array.InternalArray__IEnumerable_GetEnumerator<HeaderVariantInfo>
	|
	|-RVA: 0x219A960 Offset: 0x219AA61 VA: 0x219A960
	|-Array.InternalArray__IEnumerable_GetEnumerator<Socket.WSABUF>
	|
	|-RVA: 0x219AA70 Offset: 0x219AB71 VA: 0x219AA70
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x219AB80 Offset: 0x219AC81 VA: 0x219AB80
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Int32Enum>>
	|
	|-RVA: 0x219AC90 Offset: 0x219AD91 VA: 0x219AC90
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Bounds>>
	|
	|-RVA: 0x219ADA0 Offset: 0x219AEA1 VA: 0x219ADA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<BoundsInt>>
	|
	|-RVA: 0x219AEB0 Offset: 0x219AFB1 VA: 0x219AEB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Color32>>
	|
	|-RVA: 0x219AFC0 Offset: 0x219B0C1 VA: 0x219AFC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Color>>
	|
	|-RVA: 0x219B0D0 Offset: 0x219B1D1 VA: 0x219B0D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x219B1E0 Offset: 0x219B2E1 VA: 0x219B1E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<GradientColorKey>>
	|
	|-RVA: 0x219B2F0 Offset: 0x219B3F1 VA: 0x219B2F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Keyframe>>
	|
	|-RVA: 0x219B400 Offset: 0x219B501 VA: 0x219B400
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<LayerMask>>
	|
	|-RVA: 0x219B510 Offset: 0x219B611 VA: 0x219B510
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Matrix4x4>>
	|
	|-RVA: 0x219B620 Offset: 0x219B721 VA: 0x219B620
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Quaternion>>
	|
	|-RVA: 0x219B730 Offset: 0x219B831 VA: 0x219B730
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<RangeInt>>
	|
	|-RVA: 0x219B840 Offset: 0x219B941 VA: 0x219B840
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Rect>>
	|
	|-RVA: 0x219B950 Offset: 0x219BA51 VA: 0x219B950
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<RectInt>>
	|
	|-RVA: 0x219BA60 Offset: 0x219BB61 VA: 0x219BA60
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Vector2>>
	|
	|-RVA: 0x219BB70 Offset: 0x219BC71 VA: 0x219BB70
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Vector2Int>>
	|
	|-RVA: 0x219BC80 Offset: 0x219BD81 VA: 0x219BC80
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Vector3>>
	|
	|-RVA: 0x219BD90 Offset: 0x219BE91 VA: 0x219BD90
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Vector3Int>>
	|
	|-RVA: 0x219BEA0 Offset: 0x219BFA1 VA: 0x219BEA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Vector4>>
	|
	|-RVA: 0x219BFB0 Offset: 0x219C0B1 VA: 0x219BFB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<object>
	|
	|-RVA: 0x219C0C0 Offset: 0x219C1C1 VA: 0x219C0C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x219C1D0 Offset: 0x219C2D1 VA: 0x219C1D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ReadOnlyMemory<object>>
	|
	|-RVA: 0x219C2E0 Offset: 0x219C3E1 VA: 0x219C2E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CustomAttributeNamedArgument>
	|
	|-RVA: 0x219C3F0 Offset: 0x219C4F1 VA: 0x219C3F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CustomAttributeTypedArgument>
	|
	|-RVA: 0x219C500 Offset: 0x219C601 VA: 0x219C500
	|-Array.InternalArray__IEnumerable_GetEnumerator<Label>
	|
	|-RVA: 0x219C610 Offset: 0x219C711 VA: 0x219C610
	|-Array.InternalArray__IEnumerable_GetEnumerator<ParameterModifier>
	|
	|-RVA: 0x219C720 Offset: 0x219C821 VA: 0x219C720
	|-Array.InternalArray__IEnumerable_GetEnumerator<ResourceLocator>
	|
	|-RVA: 0x219C830 Offset: 0x219C931 VA: 0x219C830
	|-Array.InternalArray__IEnumerable_GetEnumerator<Ephemeron>
	|
	|-RVA: 0x219C940 Offset: 0x219CA41 VA: 0x219C940
	|-Array.InternalArray__IEnumerable_GetEnumerator<GCHandle>
	|
	|-RVA: 0x219CA50 Offset: 0x219CB51 VA: 0x219CA50
	|-Array.InternalArray__IEnumerable_GetEnumerator<RuntimeTypeHandle>
	|
	|-RVA: 0x219CB60 Offset: 0x219CC61 VA: 0x219CB60
	|-Array.InternalArray__IEnumerable_GetEnumerator<sbyte>
	|
	|-RVA: 0x219CC70 Offset: 0x219CD71 VA: 0x219CC70
	|-Array.InternalArray__IEnumerable_GetEnumerator<X509ChainStatus>
	|
	|-RVA: 0x219CD80 Offset: 0x219CE81 VA: 0x219CD80
	|-Array.InternalArray__IEnumerable_GetEnumerator<float>
	|
	|-RVA: 0x219CE90 Offset: 0x219CF91 VA: 0x219CE90
	|-Array.InternalArray__IEnumerable_GetEnumerator<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x219CFA0 Offset: 0x219D0A1 VA: 0x219CFA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CancellationTokenRegistration>
	|
	|-RVA: 0x219D0B0 Offset: 0x219D1B1 VA: 0x219D0B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x219D1C0 Offset: 0x219D2C1 VA: 0x219D1C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TimeSpan>
	|
	|-RVA: 0x219D2D0 Offset: 0x219D3D1 VA: 0x219D2D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ushort>
	|
	|-RVA: 0x219D3E0 Offset: 0x219D4E1 VA: 0x219D3E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<UInt16Enum>
	|
	|-RVA: 0x219D4F0 Offset: 0x219D5F1 VA: 0x219D4F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<uint>
	|
	|-RVA: 0x219D600 Offset: 0x219D701 VA: 0x219D600
	|-Array.InternalArray__IEnumerable_GetEnumerator<UInt32Enum>
	|
	|-RVA: 0x219D710 Offset: 0x219D811 VA: 0x219D710
	|-Array.InternalArray__IEnumerable_GetEnumerator<ulong>
	|
	|-RVA: 0x219D820 Offset: 0x219D921 VA: 0x219D820
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x219D930 Offset: 0x219DA31 VA: 0x219D930
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x219DA40 Offset: 0x219DB41 VA: 0x219DA40
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x219DB50 Offset: 0x219DC51 VA: 0x219DB50
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x219DC60 Offset: 0x219DD61 VA: 0x219DC60
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object>>
	|
	|-RVA: 0x219DD70 Offset: 0x219DE71 VA: 0x219DD70
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, float>>
	|
	|-RVA: 0x219DE80 Offset: 0x219DF81 VA: 0x219DE80
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<float, object>>
	|
	|-RVA: 0x219DF90 Offset: 0x219E091 VA: 0x219DF90
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<float, float>>
	|
	|-RVA: 0x219E0A0 Offset: 0x219E1A1 VA: 0x219E0A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x219E1B0 Offset: 0x219E2B1 VA: 0x219E1B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x219E2C0 Offset: 0x219E3C1 VA: 0x219E2C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x219E3D0 Offset: 0x219E4D1 VA: 0x219E3D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x219E4E0 Offset: 0x219E5E1 VA: 0x219E4E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x219E5F0 Offset: 0x219E6F1 VA: 0x219E5F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<HighlightState>
	|
	|-RVA: 0x219E700 Offset: 0x219E801 VA: 0x219E700
	|-Array.InternalArray__IEnumerable_GetEnumerator<MaterialReference>
	|
	|-RVA: 0x219E810 Offset: 0x219E911 VA: 0x219E810
	|-Array.InternalArray__IEnumerable_GetEnumerator<RichTextTagAttribute>
	|
	|-RVA: 0x219E920 Offset: 0x219EA21 VA: 0x219E920
	|-Array.InternalArray__IEnumerable_GetEnumerator<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x219EA30 Offset: 0x219EB31 VA: 0x219EA30
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_CharacterInfo>
	|
	|-RVA: 0x219EB40 Offset: 0x219EC41 VA: 0x219EB40
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_FontWeightPair>
	|
	|-RVA: 0x219EC50 Offset: 0x219ED51 VA: 0x219EC50
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_LineInfo>
	|
	|-RVA: 0x219ED60 Offset: 0x219EE61 VA: 0x219ED60
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_LinkInfo>
	|
	|-RVA: 0x219EE70 Offset: 0x219EF71 VA: 0x219EE70
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_MeshInfo>
	|
	|-RVA: 0x219EF80 Offset: 0x219F081 VA: 0x219EF80
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_PageInfo>
	|
	|-RVA: 0x219F090 Offset: 0x219F191 VA: 0x219F090
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x219F1A0 Offset: 0x219F2A1 VA: 0x219F1A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x219F2B0 Offset: 0x219F3B1 VA: 0x219F2B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_WordInfo>
	|
	|-RVA: 0x219F3C0 Offset: 0x219F4C1 VA: 0x219F3C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<WordWrapState>
	|
	|-RVA: 0x219F4D0 Offset: 0x219F5D1 VA: 0x219F4D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x219F5E0 Offset: 0x219F6E1 VA: 0x219F5E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TransitionTables>
	|
	|-RVA: 0x219F6F0 Offset: 0x219F7F1 VA: 0x219F6F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TutorialUnlockFlagData>
	|
	|-RVA: 0x219F800 Offset: 0x219F901 VA: 0x219F800
	|-Array.InternalArray__IEnumerable_GetEnumerator<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x219F910 Offset: 0x219FA11 VA: 0x219F910
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x219FA20 Offset: 0x219FB21 VA: 0x219FA20
	|-Array.InternalArray__IEnumerable_GetEnumerator<CapEdge>
	|
	|-RVA: 0x219FB30 Offset: 0x219FC31 VA: 0x219FB30
	|-Array.InternalArray__IEnumerable_GetEnumerator<ClippedEdge>
	|
	|-RVA: 0x219FC40 Offset: 0x219FD41 VA: 0x219FC40
	|-Array.InternalArray__IEnumerable_GetEnumerator<EdgeKeyByHash>
	|
	|-RVA: 0x219FD50 Offset: 0x219FE51 VA: 0x219FD50
	|-Array.InternalArray__IEnumerable_GetEnumerator<EdgeKeyByIndex>
	|
	|-RVA: 0x219FE60 Offset: 0x219FF61 VA: 0x219FE60
	|-Array.InternalArray__IEnumerable_GetEnumerator<MeshDataConnectivity.Face>
	|
	|-RVA: 0x219FF70 Offset: 0x21A0071 VA: 0x219FF70
	|-Array.InternalArray__IEnumerable_GetEnumerator<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x21A0080 Offset: 0x21A0181 VA: 0x21A0080
	|-Array.InternalArray__IEnumerable_GetEnumerator<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x21A0190 Offset: 0x21A0291 VA: 0x21A0190
	|-Array.InternalArray__IEnumerable_GetEnumerator<NavMeshBuildMarkup>
	|
	|-RVA: 0x21A02A0 Offset: 0x21A03A1 VA: 0x21A02A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NavMeshBuildSource>
	|
	|-RVA: 0x21A03B0 Offset: 0x21A04B1 VA: 0x21A03B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContentCatalogData.Bucket>
	|
	|-RVA: 0x21A04C0 Offset: 0x21A05C1 VA: 0x21A04C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConstraintSource>
	|
	|-RVA: 0x21A05D0 Offset: 0x21A06D1 VA: 0x21A05D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<PropertySceneHandle>
	|
	|-RVA: 0x21A06E0 Offset: 0x21A07E1 VA: 0x21A06E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TransformStreamHandle>
	|
	|-RVA: 0x21A07F0 Offset: 0x21A08F1 VA: 0x21A07F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AnimatorClipInfo>
	|
	|-RVA: 0x21A0900 Offset: 0x21A0A01 VA: 0x21A0900
	|-Array.InternalArray__IEnumerable_GetEnumerator<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x21A0A10 Offset: 0x21A0B11 VA: 0x21A0A10
	|-Array.InternalArray__IEnumerable_GetEnumerator<BoneWeight1>
	|
	|-RVA: 0x21A0B20 Offset: 0x21A0C21 VA: 0x21A0B20
	|-Array.InternalArray__IEnumerable_GetEnumerator<BoneWeight>
	|
	|-RVA: 0x21A0C30 Offset: 0x21A0D31 VA: 0x21A0C30
	|-Array.InternalArray__IEnumerable_GetEnumerator<BoundingSphere>
	|
	|-RVA: 0x21A0D40 Offset: 0x21A0E41 VA: 0x21A0D40
	|-Array.InternalArray__IEnumerable_GetEnumerator<Bounds>
	|
	|-RVA: 0x21A0E50 Offset: 0x21A0F51 VA: 0x21A0E50
	|-Array.InternalArray__IEnumerable_GetEnumerator<BoundsInt>
	|
	|-RVA: 0x21A0F60 Offset: 0x21A1061 VA: 0x21A0F60
	|-Array.InternalArray__IEnumerable_GetEnumerator<CharacterInfo>
	|
	|-RVA: 0x21A1070 Offset: 0x21A1171 VA: 0x21A1070
	|-Array.InternalArray__IEnumerable_GetEnumerator<Color32>
	|
	|-RVA: 0x21A1180 Offset: 0x21A1281 VA: 0x21A1180
	|-Array.InternalArray__IEnumerable_GetEnumerator<Color>
	|
	|-RVA: 0x21A1290 Offset: 0x21A1391 VA: 0x21A1290
	|-Array.InternalArray__IEnumerable_GetEnumerator<CombineInstance>
	|
	|-RVA: 0x21A13A0 Offset: 0x21A14A1 VA: 0x21A13A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContactPoint2D>
	|
	|-RVA: 0x21A14B0 Offset: 0x21A15B1 VA: 0x21A14B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContactPoint>
	|
	|-RVA: 0x21A15C0 Offset: 0x21A16C1 VA: 0x21A15C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<RaycastResult>
	|
	|-RVA: 0x21A16D0 Offset: 0x21A17D1 VA: 0x21A16D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<LightDataGI>
	|
	|-RVA: 0x21A17E0 Offset: 0x21A18E1 VA: 0x21A17E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x21A18F0 Offset: 0x21A19F1 VA: 0x21A18F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GradientAlphaKey>
	|
	|-RVA: 0x21A1A00 Offset: 0x21A1B01 VA: 0x21A1A00
	|-Array.InternalArray__IEnumerable_GetEnumerator<GradientColorKey>
	|
	|-RVA: 0x21A1B10 Offset: 0x21A1C11 VA: 0x21A1B10
	|-Array.InternalArray__IEnumerable_GetEnumerator<HumanBone>
	|
	|-RVA: 0x21A1C20 Offset: 0x21A1D21 VA: 0x21A1C20
	|-Array.InternalArray__IEnumerable_GetEnumerator<Keyframe>
	|
	|-RVA: 0x21A1D30 Offset: 0x21A1E31 VA: 0x21A1D30
	|-Array.InternalArray__IEnumerable_GetEnumerator<LOD>
	|
	|-RVA: 0x21A1E40 Offset: 0x21A1F41 VA: 0x21A1E40
	|-Array.InternalArray__IEnumerable_GetEnumerator<LayerMask>
	|
	|-RVA: 0x21A1F50 Offset: 0x21A2051 VA: 0x21A1F50
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayerLoopSystem>
	|
	|-RVA: 0x21A2060 Offset: 0x21A2161 VA: 0x21A2060
	|-Array.InternalArray__IEnumerable_GetEnumerator<Matrix4x4>
	|
	|-RVA: 0x21A2170 Offset: 0x21A2271 VA: 0x21A2170
	|-Array.InternalArray__IEnumerable_GetEnumerator<ParticleSystem.Particle>
	|
	|-RVA: 0x21A2280 Offset: 0x21A2381 VA: 0x21A2280
	|-Array.InternalArray__IEnumerable_GetEnumerator<PatchExtents>
	|
	|-RVA: 0x21A2390 Offset: 0x21A2491 VA: 0x21A2390
	|-Array.InternalArray__IEnumerable_GetEnumerator<Plane>
	|
	|-RVA: 0x21A24A0 Offset: 0x21A25A1 VA: 0x21A24A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Playable>
	|
	|-RVA: 0x21A25B0 Offset: 0x21A26B1 VA: 0x21A25B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayableBinding>
	|
	|-RVA: 0x21A26C0 Offset: 0x21A27C1 VA: 0x21A26C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayableGraph>
	|
	|-RVA: 0x21A27D0 Offset: 0x21A28D1 VA: 0x21A27D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Edge>
	|
	|-RVA: 0x21A28E0 Offset: 0x21A29E1 VA: 0x21A28E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntVec3>
	|
	|-RVA: 0x21A29F0 Offset: 0x21A2AF1 VA: 0x21A29F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Quaternion>
	|
	|-RVA: 0x21A2B00 Offset: 0x21A2C01 VA: 0x21A2B00
	|-Array.InternalArray__IEnumerable_GetEnumerator<RangeInt>
	|
	|-RVA: 0x21A2C10 Offset: 0x21A2D11 VA: 0x21A2C10
	|-Array.InternalArray__IEnumerable_GetEnumerator<RaycastHit2D>
	|
	|-RVA: 0x21A2D20 Offset: 0x21A2E21 VA: 0x21A2D20
	|-Array.InternalArray__IEnumerable_GetEnumerator<RaycastHit>
	|
	|-RVA: 0x21A2E30 Offset: 0x21A2F31 VA: 0x21A2E30
	|-Array.InternalArray__IEnumerable_GetEnumerator<Rect>
	|
	|-RVA: 0x21A2F40 Offset: 0x21A3041 VA: 0x21A2F40
	|-Array.InternalArray__IEnumerable_GetEnumerator<RectInt>
	|
	|-RVA: 0x21A3050 Offset: 0x21A3151 VA: 0x21A3050
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderBuffer>
	|
	|-RVA: 0x21A3160 Offset: 0x21A3261 VA: 0x21A3160
	|-Array.InternalArray__IEnumerable_GetEnumerator<BatchVisibility>
	|
	|-RVA: 0x21A3270 Offset: 0x21A3371 VA: 0x21A3270
	|-Array.InternalArray__IEnumerable_GetEnumerator<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x21A3380 Offset: 0x21A3481 VA: 0x21A3380
	|-Array.InternalArray__IEnumerable_GetEnumerator<SphericalHarmonicsL2>
	|
	|-RVA: 0x21A3490 Offset: 0x21A3591 VA: 0x21A3490
	|-Array.InternalArray__IEnumerable_GetEnumerator<VertexAttributeDescriptor>
	|
	|-RVA: 0x21A35A0 Offset: 0x21A36A1 VA: 0x21A35A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AsyncOperationHandle>
	|
	|-RVA: 0x21A36B0 Offset: 0x21A37B1 VA: 0x21A36B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AsyncOperationHandle<object>>
	|
	|-RVA: 0x21A37C0 Offset: 0x21A38C1 VA: 0x21A37C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x21A38D0 Offset: 0x21A39D1 VA: 0x21A38D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DiagnosticEvent>
	|
	|-RVA: 0x21A39E0 Offset: 0x21A3AE1 VA: 0x21A39E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SceneInstance>
	|
	|-RVA: 0x21A3AF0 Offset: 0x21A3BF1 VA: 0x21A3AF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x21A3C00 Offset: 0x21A3D01 VA: 0x21A3C00
	|-Array.InternalArray__IEnumerable_GetEnumerator<ObjectInitializationData>
	|
	|-RVA: 0x21A3D10 Offset: 0x21A3E11 VA: 0x21A3D10
	|-Array.InternalArray__IEnumerable_GetEnumerator<SerializedType>
	|
	|-RVA: 0x21A3E20 Offset: 0x21A3F21 VA: 0x21A3E20
	|-Array.InternalArray__IEnumerable_GetEnumerator<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x21A3F30 Offset: 0x21A4031 VA: 0x21A3F30
	|-Array.InternalArray__IEnumerable_GetEnumerator<SkeletonBone>
	|
	|-RVA: 0x21A4040 Offset: 0x21A4141 VA: 0x21A4040
	|-Array.InternalArray__IEnumerable_GetEnumerator<GlyphRect>
	|
	|-RVA: 0x21A4150 Offset: 0x21A4251 VA: 0x21A4150
	|-Array.InternalArray__IEnumerable_GetEnumerator<GlyphMarshallingStruct>
	|
	|-RVA: 0x21A4260 Offset: 0x21A4361 VA: 0x21A4260
	|-Array.InternalArray__IEnumerable_GetEnumerator<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x21A4370 Offset: 0x21A4471 VA: 0x21A4370
	|-Array.InternalArray__IEnumerable_GetEnumerator<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x21A4480 Offset: 0x21A4581 VA: 0x21A4480
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntervalTreeNode>
	|
	|-RVA: 0x21A4590 Offset: 0x21A4691 VA: 0x21A4590
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntervalTree.Entry<object>>
	|
	|-RVA: 0x21A46A0 Offset: 0x21A47A1 VA: 0x21A46A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x21A47B0 Offset: 0x21A48B1 VA: 0x21A47B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Touch>
	|
	|-RVA: 0x21A48C0 Offset: 0x21A49C1 VA: 0x21A48C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TreeInstance>
	|
	|-RVA: 0x21A49D0 Offset: 0x21A4AD1 VA: 0x21A49D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ColorBlock>
	|
	|-RVA: 0x21A4AE0 Offset: 0x21A4BE1 VA: 0x21A4AE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Navigation>
	|
	|-RVA: 0x21A4BF0 Offset: 0x21A4CF1 VA: 0x21A4BF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpriteState>
	|
	|-RVA: 0x21A4D00 Offset: 0x21A4E01 VA: 0x21A4D00
	|-Array.InternalArray__IEnumerable_GetEnumerator<UICharInfo>
	|
	|-RVA: 0x21A4E10 Offset: 0x21A4F11 VA: 0x21A4E10
	|-Array.InternalArray__IEnumerable_GetEnumerator<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x21A4F20 Offset: 0x21A5021 VA: 0x21A4F20
	|-Array.InternalArray__IEnumerable_GetEnumerator<EventDispatcher.EventRecord>
	|
	|-RVA: 0x21A5030 Offset: 0x21A5131 VA: 0x21A5030
	|-Array.InternalArray__IEnumerable_GetEnumerator<FocusController.FocusedElement>
	|
	|-RVA: 0x21A5140 Offset: 0x21A5241 VA: 0x21A5140
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x21A5250 Offset: 0x21A5351 VA: 0x21A5250
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleValue>
	|
	|-RVA: 0x21A5360 Offset: 0x21A5461 VA: 0x21A5360
	|-Array.InternalArray__IEnumerable_GetEnumerator<UILineInfo>
	|
	|-RVA: 0x21A5470 Offset: 0x21A5571 VA: 0x21A5470
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIVertex>
	|
	|-RVA: 0x21A5580 Offset: 0x21A5681 VA: 0x21A5580
	|-Array.InternalArray__IEnumerable_GetEnumerator<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x21A5690 Offset: 0x21A5791 VA: 0x21A5690
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector2>
	|
	|-RVA: 0x21A57A0 Offset: 0x21A58A1 VA: 0x21A57A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector2Int>
	|
	|-RVA: 0x21A58B0 Offset: 0x21A59B1 VA: 0x21A58B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector3>
	|
	|-RVA: 0x21A59C0 Offset: 0x21A5AC1 VA: 0x21A59C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector3Int>
	|
	|-RVA: 0x21A5AD0 Offset: 0x21A5BD1 VA: 0x21A5AD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector4>
	|
	|-RVA: 0x21A5BE0 Offset: 0x21A5CE1 VA: 0x21A5BE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<jvalue>
	|
	|-RVA: 0x21A5CF0 Offset: 0x21A5DF1 VA: 0x21A5CF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<WarpPoints.WarpPoint>
	|
	|-RVA: 0x21A5E00 Offset: 0x21A5F01 VA: 0x21A5E00
	|-Array.InternalArray__IEnumerable_GetEnumerator<YieldItemParam>
	|
	|-RVA: 0x21A5F10 Offset: 0x21A6011 VA: 0x21A5F10
	|-Array.InternalArray__IEnumerable_GetEnumerator<NetworkServiceAccountId>
	|
	|-RVA: 0x21A6020 Offset: 0x21A6121 VA: 0x21A6020
	|-Array.InternalArray__IEnumerable_GetEnumerator<Uid>
	|
	|-RVA: 0x21A6130 Offset: 0x21A6231 VA: 0x21A6130
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConsumableServiceItemId>
	|
	|-RVA: 0x21A6240 Offset: 0x21A6341 VA: 0x21A6240
	|-Array.InternalArray__IEnumerable_GetEnumerator<NsUid>
	|
	|-RVA: 0x21A6350 Offset: 0x21A6451 VA: 0x21A6350
	|-Array.InternalArray__IEnumerable_GetEnumerator<Friend>
	|
	|-RVA: 0x21A6460 Offset: 0x21A6561 VA: 0x21A6460
	|-Array.InternalArray__IEnumerable_GetEnumerator<Profile>
	|
	|-RVA: 0x21A6570 Offset: 0x21A6671 VA: 0x21A6570
	|-Array.InternalArray__IEnumerable_GetEnumerator<DirectoryEntry>
	|
	|-RVA: 0x21A6680 Offset: 0x21A6781 VA: 0x21A6680
	|-Array.InternalArray__IEnumerable_GetEnumerator<DebugPadState>
	|
	|-RVA: 0x21A6790 Offset: 0x21A6891 VA: 0x21A6790
	|-Array.InternalArray__IEnumerable_GetEnumerator<GesturePoint>
	|
	|-RVA: 0x21A68A0 Offset: 0x21A69A1 VA: 0x21A68A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GestureState>
	|
	|-RVA: 0x21A69B0 Offset: 0x21A6AB1 VA: 0x21A69B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadFullKeyState>
	|
	|-RVA: 0x21A6AC0 Offset: 0x21A6BC1 VA: 0x21A6AC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadHandheldState>
	|
	|-RVA: 0x21A6BD0 Offset: 0x21A6CD1 VA: 0x21A6BD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadJoyDualState>
	|
	|-RVA: 0x21A6CE0 Offset: 0x21A6DE1 VA: 0x21A6CE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadJoyLeftState>
	|
	|-RVA: 0x21A6DF0 Offset: 0x21A6EF1 VA: 0x21A6DF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadJoyRightState>
	|
	|-RVA: 0x21A6F00 Offset: 0x21A7001 VA: 0x21A6F00
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadStateArrayItem>
	|
	|-RVA: 0x21A7010 Offset: 0x21A7111 VA: 0x21A7010
	|-Array.InternalArray__IEnumerable_GetEnumerator<SixAxisSensorHandle>
	|
	|-RVA: 0x21A7120 Offset: 0x21A7221 VA: 0x21A7120
	|-Array.InternalArray__IEnumerable_GetEnumerator<SixAxisSensorState>
	|
	|-RVA: 0x21A7230 Offset: 0x21A7331 VA: 0x21A7230
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState10>
	|
	|-RVA: 0x21A7340 Offset: 0x21A7441 VA: 0x21A7340
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState11>
	|
	|-RVA: 0x21A7450 Offset: 0x21A7551 VA: 0x21A7450
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState12>
	|
	|-RVA: 0x21A7560 Offset: 0x21A7661 VA: 0x21A7560
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState13>
	|
	|-RVA: 0x21A7670 Offset: 0x21A7771 VA: 0x21A7670
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState14>
	|
	|-RVA: 0x21A7780 Offset: 0x21A7881 VA: 0x21A7780
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState15>
	|
	|-RVA: 0x21A7890 Offset: 0x21A7991 VA: 0x21A7890
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState16>
	|
	|-RVA: 0x21A79A0 Offset: 0x21A7AA1 VA: 0x21A79A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState1>
	|
	|-RVA: 0x21A7AB0 Offset: 0x21A7BB1 VA: 0x21A7AB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState2>
	|
	|-RVA: 0x21A7BC0 Offset: 0x21A7CC1 VA: 0x21A7BC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState3>
	|
	|-RVA: 0x21A7CD0 Offset: 0x21A7DD1 VA: 0x21A7CD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState4>
	|
	|-RVA: 0x21A7DE0 Offset: 0x21A7EE1 VA: 0x21A7DE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState5>
	|
	|-RVA: 0x21A7EF0 Offset: 0x21A7FF1 VA: 0x21A7EF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState6>
	|
	|-RVA: 0x21A8000 Offset: 0x21A8101 VA: 0x21A8000
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState7>
	|
	|-RVA: 0x21A8110 Offset: 0x21A8211 VA: 0x21A8110
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState8>
	|
	|-RVA: 0x21A8220 Offset: 0x21A8321 VA: 0x21A8220
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState9>
	|
	|-RVA: 0x21A8330 Offset: 0x21A8431 VA: 0x21A8330
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchState>
	|
	|-RVA: 0x21A8440 Offset: 0x21A8541 VA: 0x21A8440
	|-Array.InternalArray__IEnumerable_GetEnumerator<VibrationDeviceHandle>
	|
	|-RVA: 0x21A8550 Offset: 0x21A8651 VA: 0x21A8550
	|-Array.InternalArray__IEnumerable_GetEnumerator<VibrationDeviceInfo>
	|
	|-RVA: 0x21A8660 Offset: 0x21A8761 VA: 0x21A8660
	|-Array.InternalArray__IEnumerable_GetEnumerator<VibrationValue>
	|
	|-RVA: 0x21A8770 Offset: 0x21A8871 VA: 0x21A8770
	|-Array.InternalArray__IEnumerable_GetEnumerator<ClusteringData>
	|
	|-RVA: 0x21A8880 Offset: 0x21A8981 VA: 0x21A8880
	|-Array.InternalArray__IEnumerable_GetEnumerator<ClusteringProcessorState>
	|
	|-RVA: 0x21A8990 Offset: 0x21A8A91 VA: 0x21A8990
	|-Array.InternalArray__IEnumerable_GetEnumerator<Finger>
	|
	|-RVA: 0x21A8AA0 Offset: 0x21A8BA1 VA: 0x21A8AA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hand>
	|
	|-RVA: 0x21A8BB0 Offset: 0x21A8CB1 VA: 0x21A8BB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<HandAnalysisImageState>
	|
	|-RVA: 0x21A8CC0 Offset: 0x21A8DC1 VA: 0x21A8CC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x21A8DD0 Offset: 0x21A8ED1 VA: 0x21A8DD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MomentProcessorState>
	|
	|-RVA: 0x21A8EE0 Offset: 0x21A8FE1 VA: 0x21A8EE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MomentStatistic>
	|
	|-RVA: 0x21A8FF0 Offset: 0x21A90F1 VA: 0x21A8FF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Protrusion>
	|
	|-RVA: 0x21A9100 Offset: 0x21A9201 VA: 0x21A9100
	|-Array.InternalArray__IEnumerable_GetEnumerator<Shape>
	|
	|-RVA: 0x21A9210 Offset: 0x21A9311 VA: 0x21A9210
	|-Array.InternalArray__IEnumerable_GetEnumerator<DictionaryInfo>
	|
	|-RVA: 0x21A9320 Offset: 0x21A9421 VA: 0x21A9320
	|-Array.InternalArray__IEnumerable_GetEnumerator<UserWord>
	|
	|-RVA: 0x21A9430 Offset: 0x21A9531 VA: 0x21A9430
	|-Array.InternalArray__IEnumerable_GetEnumerator<Color4u8>
	|
	|-RVA: 0x21A9540 Offset: 0x21A9641 VA: 0x21A9540
	|-Array.InternalArray__IEnumerable_GetEnumerator<Float2>
	|
	|-RVA: 0x21A9650 Offset: 0x21A9751 VA: 0x21A9650
	|-Array.InternalArray__IEnumerable_GetEnumerator<stCommand_t>
	*/

	// RVA: 0x184D550 Offset: 0x184D651 VA: 0x184D550
	internal void InternalArray__ICollection_Clear() { }

	// RVA: -1 Offset: -1
	internal void InternalArray__ICollection_Add<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D8D20 Offset: 0x21D8E21 VA: 0x21D8D20
	|-Array.InternalArray__ICollection_Add<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x21D8D90 Offset: 0x21D8E91 VA: 0x21D8D90
	|-Array.InternalArray__ICollection_Add<ActionCommandDataTable>
	|
	|-RVA: 0x21D8E00 Offset: 0x21D8F01 VA: 0x21D8E00
	|-Array.InternalArray__ICollection_Add<AdvScriptDefCountParam>
	|
	|-RVA: 0x21D8E70 Offset: 0x21D8F71 VA: 0x21D8E70
	|-Array.InternalArray__ICollection_Add<JSONDeserialization.TaskField>
	|
	|-RVA: 0x21D8EE0 Offset: 0x21D8FE1 VA: 0x21D8EE0
	|-Array.InternalArray__ICollection_Add<BitVector32Int>
	|
	|-RVA: 0x21D8F50 Offset: 0x21D9051 VA: 0x21D8F50
	|-Array.InternalArray__ICollection_Add<BuildItemData>
	|
	|-RVA: 0x21D8FC0 Offset: 0x21D90C1 VA: 0x21D8FC0
	|-Array.InternalArray__ICollection_Add<ButtonLinker.LinkObject>
	|
	|-RVA: 0x21D9030 Offset: 0x21D9131 VA: 0x21D9030
	|-Array.InternalArray__ICollection_Add<CharaCallTable.BustupTable>
	|
	|-RVA: 0x21D90A0 Offset: 0x21D91A1 VA: 0x21D90A0
	|-Array.InternalArray__ICollection_Add<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x21D9110 Offset: 0x21D9211 VA: 0x21D9110
	|-Array.InternalArray__ICollection_Add<CameraState.CustomBlendable>
	|
	|-RVA: 0x21D9180 Offset: 0x21D9281 VA: 0x21D9180
	|-Array.InternalArray__ICollection_Add<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x21D91F0 Offset: 0x21D92F1 VA: 0x21D91F0
	|-Array.InternalArray__ICollection_Add<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x21D9260 Offset: 0x21D9361 VA: 0x21D9260
	|-Array.InternalArray__ICollection_Add<CinemachineClearShot.Pair>
	|
	|-RVA: 0x21D92D0 Offset: 0x21D93D1 VA: 0x21D92D0
	|-Array.InternalArray__ICollection_Add<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x21D9340 Offset: 0x21D9441 VA: 0x21D9340
	|-Array.InternalArray__ICollection_Add<CinemachinePath.Waypoint>
	|
	|-RVA: 0x21D93B0 Offset: 0x21D94B1 VA: 0x21D93B0
	|-Array.InternalArray__ICollection_Add<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x21D9420 Offset: 0x21D9521 VA: 0x21D9420
	|-Array.InternalArray__ICollection_Add<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x21D9490 Offset: 0x21D9591 VA: 0x21D9490
	|-Array.InternalArray__ICollection_Add<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x21D9500 Offset: 0x21D9601 VA: 0x21D9500
	|-Array.InternalArray__ICollection_Add<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x21D9570 Offset: 0x21D9671 VA: 0x21D9570
	|-Array.InternalArray__ICollection_Add<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x21D95E0 Offset: 0x21D96E1 VA: 0x21D95E0
	|-Array.InternalArray__ICollection_Add<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x21D9650 Offset: 0x21D9751 VA: 0x21D9650
	|-Array.InternalArray__ICollection_Add<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x21D96C0 Offset: 0x21D97C1 VA: 0x21D96C0
	|-Array.InternalArray__ICollection_Add<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x21D9730 Offset: 0x21D9831 VA: 0x21D9730
	|-Array.InternalArray__ICollection_Add<HeadingTracker.Item>
	|
	|-RVA: 0x21D97A0 Offset: 0x21D98A1 VA: 0x21D97A0
	|-Array.InternalArray__ICollection_Add<CropDataTable>
	|
	|-RVA: 0x21D9810 Offset: 0x21D9911 VA: 0x21D9810
	|-Array.InternalArray__ICollection_Add<ControlPoint>
	|
	|-RVA: 0x21D9880 Offset: 0x21D9981 VA: 0x21D9880
	|-Array.InternalArray__ICollection_Add<DamageTextInfo>
	|
	|-RVA: 0x21D98F0 Offset: 0x21D99F1 VA: 0x21D98F0
	|-Array.InternalArray__ICollection_Add<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x21D9960 Offset: 0x21D9A61 VA: 0x21D9960
	|-Array.InternalArray__ICollection_Add<DropItemParam>
	|
	|-RVA: 0x21D99D0 Offset: 0x21D9AD1 VA: 0x21D99D0
	|-Array.InternalArray__ICollection_Add<DropTableElement>
	|
	|-RVA: 0x21D9A40 Offset: 0x21D9B41 VA: 0x21D9A40
	|-Array.InternalArray__ICollection_Add<EffectDataTable>
	|
	|-RVA: 0x21D9AB0 Offset: 0x21D9BB1 VA: 0x21D9AB0
	|-Array.InternalArray__ICollection_Add<EnemyPatrolPoints>
	|
	|-RVA: 0x21D9B20 Offset: 0x21D9C21 VA: 0x21D9B20
	|-Array.InternalArray__ICollection_Add<Coord>
	|
	|-RVA: 0x21D9B90 Offset: 0x21D9C91 VA: 0x21D9B90
	|-Array.InternalArray__ICollection_Add<ErosionBrush.UndoStep>
	|
	|-RVA: 0x21D9C00 Offset: 0x21D9D01 VA: 0x21D9C00
	|-Array.InternalArray__ICollection_Add<EventCheckId>
	|
	|-RVA: 0x21D9C70 Offset: 0x21D9D71 VA: 0x21D9C70
	|-Array.InternalArray__ICollection_Add<EventFlagProgressData>
	|
	|-RVA: 0x21D9CE0 Offset: 0x21D9DE1 VA: 0x21D9CE0
	|-Array.InternalArray__ICollection_Add<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x21D9D50 Offset: 0x21D9E51 VA: 0x21D9D50
	|-Array.InternalArray__ICollection_Add<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x21D9DC0 Offset: 0x21D9EC1 VA: 0x21D9DC0
	|-Array.InternalArray__ICollection_Add<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x21D9E30 Offset: 0x21D9F31 VA: 0x21D9E30
	|-Array.InternalArray__ICollection_Add<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x21D9EA0 Offset: 0x21D9FA1 VA: 0x21D9EA0
	|-Array.InternalArray__ICollection_Add<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x21D9F10 Offset: 0x21DA011 VA: 0x21D9F10
	|-Array.InternalArray__ICollection_Add<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x21D9F80 Offset: 0x21DA081 VA: 0x21D9F80
	|-Array.InternalArray__ICollection_Add<FesNpcScoreData>
	|
	|-RVA: 0x21D9FF0 Offset: 0x21DA0F1 VA: 0x21D9FF0
	|-Array.InternalArray__ICollection_Add<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x21DA060 Offset: 0x21DA161 VA: 0x21DA060
	|-Array.InternalArray__ICollection_Add<FieldItemSpawnDataTable>
	|
	|-RVA: 0x21DA0D0 Offset: 0x21DA1D1 VA: 0x21DA0D0
	|-Array.InternalArray__ICollection_Add<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x21DA140 Offset: 0x21DA241 VA: 0x21DA140
	|-Array.InternalArray__ICollection_Add<FieldSceneData.Data>
	|
	|-RVA: 0x21DA1B0 Offset: 0x21DA2B1 VA: 0x21DA1B0
	|-Array.InternalArray__ICollection_Add<FieldTreasureBoxItemData>
	|
	|-RVA: 0x21DA220 Offset: 0x21DA321 VA: 0x21DA220
	|-Array.InternalArray__ICollection_Add<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x21DA290 Offset: 0x21DA391 VA: 0x21DA290
	|-Array.InternalArray__ICollection_Add<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x21DA300 Offset: 0x21DA401 VA: 0x21DA300
	|-Array.InternalArray__ICollection_Add<FocusObjectDataTable>
	|
	|-RVA: 0x21DA370 Offset: 0x21DA471 VA: 0x21DA370
	|-Array.InternalArray__ICollection_Add<FurnitureData>
	|
	|-RVA: 0x21DA3E0 Offset: 0x21DA4E1 VA: 0x21DA3E0
	|-Array.InternalArray__ICollection_Add<GateDataTable>
	|
	|-RVA: 0x21DA450 Offset: 0x21DA551 VA: 0x21DA450
	|-Array.InternalArray__ICollection_Add<GateStatusDataTable>
	|
	|-RVA: 0x21DA4C0 Offset: 0x21DA5C1 VA: 0x21DA4C0
	|-Array.InternalArray__ICollection_Add<GimmickLayoutDataTable>
	|
	|-RVA: 0x21DA530 Offset: 0x21DA631 VA: 0x21DA530
	|-Array.InternalArray__ICollection_Add<HitResult>
	|
	|-RVA: 0x21DA5A0 Offset: 0x21DA6A1 VA: 0x21DA5A0
	|-Array.InternalArray__ICollection_Add<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x21DA610 Offset: 0x21DA711 VA: 0x21DA610
	|-Array.InternalArray__ICollection_Add<FurnitureManager.SendPos>
	|
	|-RVA: 0x21DA680 Offset: 0x21DA781 VA: 0x21DA680
	|-Array.InternalArray__ICollection_Add<ItemLevelData>
	|
	|-RVA: 0x21DA6F0 Offset: 0x21DA7F1 VA: 0x21DA6F0
	|-Array.InternalArray__ICollection_Add<MapDatas.MapData>
	|
	|-RVA: 0x21DA760 Offset: 0x21DA861 VA: 0x21DA760
	|-Array.InternalArray__ICollection_Add<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x21DA7D0 Offset: 0x21DA8D1 VA: 0x21DA7D0
	|-Array.InternalArray__ICollection_Add<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x21DA840 Offset: 0x21DA941 VA: 0x21DA840
	|-Array.InternalArray__ICollection_Add<MineTypeDataTable>
	|
	|-RVA: 0x21DA8B0 Offset: 0x21DA9B1 VA: 0x21DA8B0
	|-Array.InternalArray__ICollection_Add<MiningDataTable>
	|
	|-RVA: 0x21DA920 Offset: 0x21DAA21 VA: 0x21DA920
	|-Array.InternalArray__ICollection_Add<MiningPointSaveData>
	|
	|-RVA: 0x21DA990 Offset: 0x21DAA91 VA: 0x21DA990
	|-Array.InternalArray__ICollection_Add<CodePointIndexer.TableRange>
	|
	|-RVA: 0x21DAA00 Offset: 0x21DAB01 VA: 0x21DAA00
	|-Array.InternalArray__ICollection_Add<MonsterBehaviorDataTable>
	|
	|-RVA: 0x21DAA70 Offset: 0x21DAB71 VA: 0x21DAA70
	|-Array.InternalArray__ICollection_Add<MonsterDataTable>
	|
	|-RVA: 0x21DAAE0 Offset: 0x21DABE1 VA: 0x21DAAE0
	|-Array.InternalArray__ICollection_Add<MonsterDropItemDataTable>
	|
	|-RVA: 0x21DAB50 Offset: 0x21DAC51 VA: 0x21DAB50
	|-Array.InternalArray__ICollection_Add<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x21DABC0 Offset: 0x21DACC1 VA: 0x21DABC0
	|-Array.InternalArray__ICollection_Add<MonsterHutSaveData>
	|
	|-RVA: 0x21DAC30 Offset: 0x21DAD31 VA: 0x21DAC30
	|-Array.InternalArray__ICollection_Add<MonsterUIData.Data>
	|
	|-RVA: 0x21DACA0 Offset: 0x21DADA1 VA: 0x21DACA0
	|-Array.InternalArray__ICollection_Add<MonsterYieldItemDataTable>
	|
	|-RVA: 0x21DAD10 Offset: 0x21DAE11 VA: 0x21DAD10
	|-Array.InternalArray__ICollection_Add<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x21DAD80 Offset: 0x21DAE81 VA: 0x21DAD80
	|-Array.InternalArray__ICollection_Add<NPCActionData>
	|
	|-RVA: 0x21DADF0 Offset: 0x21DAEF1 VA: 0x21DADF0
	|-Array.InternalArray__ICollection_Add<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x21DAE60 Offset: 0x21DAF61 VA: 0x21DAE60
	|-Array.InternalArray__ICollection_Add<NPCUIData.Data>
	|
	|-RVA: 0x21DAED0 Offset: 0x21DAFD1 VA: 0x21DAED0
	|-Array.InternalArray__ICollection_Add<NpcPlaceSchedule>
	|
	|-RVA: 0x21DAF40 Offset: 0x21DB041 VA: 0x21DAF40
	|-Array.InternalArray__ICollection_Add<OrderLotterySaveParameter>
	|
	|-RVA: 0x21DAFB0 Offset: 0x21DB0B1 VA: 0x21DAFB0
	|-Array.InternalArray__ICollection_Add<OrderSaveData>
	|
	|-RVA: 0x21DB020 Offset: 0x21DB121 VA: 0x21DB020
	|-Array.InternalArray__ICollection_Add<OrderSaveParameter>
	|
	|-RVA: 0x21DB090 Offset: 0x21DB191 VA: 0x21DB090
	|-Array.InternalArray__ICollection_Add<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x21DB100 Offset: 0x21DB201 VA: 0x21DB100
	|-Array.InternalArray__ICollection_Add<Parameter>
	|
	|-RVA: 0x21DB170 Offset: 0x21DB271 VA: 0x21DB170
	|-Array.InternalArray__ICollection_Add<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x21DB1E0 Offset: 0x21DB2E1 VA: 0x21DB1E0
	|-Array.InternalArray__ICollection_Add<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x21DB250 Offset: 0x21DB351 VA: 0x21DB250
	|-Array.InternalArray__ICollection_Add<ShopCatalogPage>
	|
	|-RVA: 0x21DB2C0 Offset: 0x21DB3C1 VA: 0x21DB2C0
	|-Array.InternalArray__ICollection_Add<ShopNpcTalk>
	|
	|-RVA: 0x21DB330 Offset: 0x21DB431 VA: 0x21DB330
	|-Array.InternalArray__ICollection_Add<SubtitleDataTable.Data>
	|
	|-RVA: 0x21DB3A0 Offset: 0x21DB4A1 VA: 0x21DB3A0
	|-Array.InternalArray__ICollection_Add<SubtitleDataTable.DataList>
	|
	|-RVA: 0x21DB410 Offset: 0x21DB511 VA: 0x21DB410
	|-Array.InternalArray__ICollection_Add<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x21DB480 Offset: 0x21DB581 VA: 0x21DB480
	|-Array.InternalArray__ICollection_Add<AnimationWarping.Warp>
	|
	|-RVA: 0x21DB4F0 Offset: 0x21DB5F1 VA: 0x21DB4F0
	|-Array.InternalArray__ICollection_Add<GrounderQuadruped.Foot>
	|
	|-RVA: 0x21DB560 Offset: 0x21DB661 VA: 0x21DB560
	|-Array.InternalArray__ICollection_Add<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x21DB5D0 Offset: 0x21DB6D1 VA: 0x21DB5D0
	|-Array.InternalArray__ICollection_Add<ProfilerFrame>
	|
	|-RVA: 0x21DB640 Offset: 0x21DB741 VA: 0x21DB640
	|-Array.InternalArray__ICollection_Add<NumberControl.ValueRange>
	|
	|-RVA: 0x21DB6B0 Offset: 0x21DB7B1 VA: 0x21DB6B0
	|-Array.InternalArray__ICollection_Add<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x21DB720 Offset: 0x21DB821 VA: 0x21DB720
	|-Array.InternalArray__ICollection_Add<ResponsiveEnable.Entry>
	|
	|-RVA: 0x21DB790 Offset: 0x21DB891 VA: 0x21DB790
	|-Array.InternalArray__ICollection_Add<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x21DB800 Offset: 0x21DB901 VA: 0x21DB800
	|-Array.InternalArray__ICollection_Add<ResponsiveResize.Element>
	|
	|-RVA: 0x21DB870 Offset: 0x21DB971 VA: 0x21DB870
	|-Array.InternalArray__ICollection_Add<Schedule>
	|
	|-RVA: 0x21DB8E0 Offset: 0x21DB9E1 VA: 0x21DB8E0
	|-Array.InternalArray__ICollection_Add<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x21DB950 Offset: 0x21DBA51 VA: 0x21DB950
	|-Array.InternalArray__ICollection_Add<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x21DB9C0 Offset: 0x21DBAC1 VA: 0x21DB9C0
	|-Array.InternalArray__ICollection_Add<SpeedData>
	|
	|-RVA: 0x21DBA30 Offset: 0x21DBB31 VA: 0x21DBA30
	|-Array.InternalArray__ICollection_Add<CurveSample>
	|
	|-RVA: 0x21DBAA0 Offset: 0x21DBBA1 VA: 0x21DBAA0
	|-Array.InternalArray__ICollection_Add<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x21DBB10 Offset: 0x21DBC11 VA: 0x21DBB10
	|-Array.InternalArray__ICollection_Add<StringFormatData.FormatData>
	|
	|-RVA: 0x21DBB80 Offset: 0x21DBC81 VA: 0x21DBB80
	|-Array.InternalArray__ICollection_Add<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x21DBBF0 Offset: 0x21DBCF1 VA: 0x21DBBF0
	|-Array.InternalArray__ICollection_Add<ArraySegment<byte>>
	|
	|-RVA: 0x21DBC60 Offset: 0x21DBD61 VA: 0x21DBC60
	|-Array.InternalArray__ICollection_Add<ArraySegment<object>>
	|
	|-RVA: 0x21DBCD0 Offset: 0x21DBDD1 VA: 0x21DBCD0
	|-Array.InternalArray__ICollection_Add<bool>
	|
	|-RVA: 0x21DBD40 Offset: 0x21DBE41 VA: 0x21DBD40
	|-Array.InternalArray__ICollection_Add<byte>
	|
	|-RVA: 0x21DBDB0 Offset: 0x21DBEB1 VA: 0x21DBDB0
	|-Array.InternalArray__ICollection_Add<ByteEnum>
	|
	|-RVA: 0x21DBE20 Offset: 0x21DBF21 VA: 0x21DBE20
	|-Array.InternalArray__ICollection_Add<char>
	|
	|-RVA: 0x21DBE90 Offset: 0x21DBF91 VA: 0x21DBE90
	|-Array.InternalArray__ICollection_Add<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x21DBF00 Offset: 0x21DC001 VA: 0x21DBF00
	|-Array.InternalArray__ICollection_Add<DictionaryEntry>
	|
	|-RVA: 0x21DBF70 Offset: 0x21DC071 VA: 0x21DBF70
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x21DBFE0 Offset: 0x21DC0E1 VA: 0x21DBFE0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x21DC050 Offset: 0x21DC151 VA: 0x21DC050
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x21DC0C0 Offset: 0x21DC1C1 VA: 0x21DC0C0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x21DC130 Offset: 0x21DC231 VA: 0x21DC130
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x21DC1A0 Offset: 0x21DC2A1 VA: 0x21DC1A0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x21DC210 Offset: 0x21DC311 VA: 0x21DC210
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x21DC280 Offset: 0x21DC381 VA: 0x21DC280
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x21DC2F0 Offset: 0x21DC3F1 VA: 0x21DC2F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x21DC360 Offset: 0x21DC461 VA: 0x21DC360
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x21DC3D0 Offset: 0x21DC4D1 VA: 0x21DC3D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x21DC440 Offset: 0x21DC541 VA: 0x21DC440
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x21DC4B0 Offset: 0x21DC5B1 VA: 0x21DC4B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x21DC520 Offset: 0x21DC621 VA: 0x21DC520
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x21DC590 Offset: 0x21DC691 VA: 0x21DC590
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x21DC600 Offset: 0x21DC701 VA: 0x21DC600
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x21DC670 Offset: 0x21DC771 VA: 0x21DC670
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x21DC6E0 Offset: 0x21DC7E1 VA: 0x21DC6E0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x21DC750 Offset: 0x21DC851 VA: 0x21DC750
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x21DC7C0 Offset: 0x21DC8C1 VA: 0x21DC7C0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x21DC830 Offset: 0x21DC931 VA: 0x21DC830
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x21DC8A0 Offset: 0x21DC9A1 VA: 0x21DC8A0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x21DC910 Offset: 0x21DCA11 VA: 0x21DC910
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x21DC980 Offset: 0x21DCA81 VA: 0x21DC980
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x21DC9F0 Offset: 0x21DCAF1 VA: 0x21DC9F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x21DCA60 Offset: 0x21DCB61 VA: 0x21DCA60
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x21DCAD0 Offset: 0x21DCBD1 VA: 0x21DCAD0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x21DCB40 Offset: 0x21DCC41 VA: 0x21DCB40
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x21DCBB0 Offset: 0x21DCCB1 VA: 0x21DCBB0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x21DCC20 Offset: 0x21DCD21 VA: 0x21DCC20
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x21DCC90 Offset: 0x21DCD91 VA: 0x21DCC90
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x21DCD00 Offset: 0x21DCE01 VA: 0x21DCD00
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x21DCD70 Offset: 0x21DCE71 VA: 0x21DCD70
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x21DCDE0 Offset: 0x21DCEE1 VA: 0x21DCDE0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x21DCE50 Offset: 0x21DCF51 VA: 0x21DCE50
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x21DCEC0 Offset: 0x21DCFC1 VA: 0x21DCEC0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x21DCF30 Offset: 0x21DD031 VA: 0x21DCF30
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x21DCFA0 Offset: 0x21DD0A1 VA: 0x21DCFA0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x21DD010 Offset: 0x21DD111 VA: 0x21DD010
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x21DD080 Offset: 0x21DD181 VA: 0x21DD080
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x21DD0F0 Offset: 0x21DD1F1 VA: 0x21DD0F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x21DD160 Offset: 0x21DD261 VA: 0x21DD160
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x21DD1D0 Offset: 0x21DD2D1 VA: 0x21DD1D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x21DD240 Offset: 0x21DD341 VA: 0x21DD240
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x21DD2B0 Offset: 0x21DD3B1 VA: 0x21DD2B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x21DD320 Offset: 0x21DD421 VA: 0x21DD320
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x21DD390 Offset: 0x21DD491 VA: 0x21DD390
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x21DD400 Offset: 0x21DD501 VA: 0x21DD400
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x21DD470 Offset: 0x21DD571 VA: 0x21DD470
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x21DD4E0 Offset: 0x21DD5E1 VA: 0x21DD4E0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x21DD550 Offset: 0x21DD651 VA: 0x21DD550
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x21DD5C0 Offset: 0x21DD6C1 VA: 0x21DD5C0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x21DD630 Offset: 0x21DD731 VA: 0x21DD630
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x21DD6A0 Offset: 0x21DD7A1 VA: 0x21DD6A0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x21DD710 Offset: 0x21DD811 VA: 0x21DD710
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x21DD780 Offset: 0x21DD881 VA: 0x21DD780
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x21DD7F0 Offset: 0x21DD8F1 VA: 0x21DD7F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x21DD860 Offset: 0x21DD961 VA: 0x21DD860
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x21DD8D0 Offset: 0x21DD9D1 VA: 0x21DD8D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x21DD940 Offset: 0x21DDA41 VA: 0x21DD940
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x21DD9B0 Offset: 0x21DDAB1 VA: 0x21DD9B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x21DDA20 Offset: 0x21DDB21 VA: 0x21DDA20
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x21DDA90 Offset: 0x21DDB91 VA: 0x21DDA90
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x21DDB00 Offset: 0x21DDC01 VA: 0x21DDB00
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x21DDB70 Offset: 0x21DDC71 VA: 0x21DDB70
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x21DDBE0 Offset: 0x21DDCE1 VA: 0x21DDBE0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x21DDC50 Offset: 0x21DDD51 VA: 0x21DDC50
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x21DDCC0 Offset: 0x21DDDC1 VA: 0x21DDCC0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x21DDD30 Offset: 0x21DDE31 VA: 0x21DDD30
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x21DDDA0 Offset: 0x21DDEA1 VA: 0x21DDDA0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x21DDE10 Offset: 0x21DDF11 VA: 0x21DDE10
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x21DDE80 Offset: 0x21DDF81 VA: 0x21DDE80
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x21DDEF0 Offset: 0x21DDFF1 VA: 0x21DDEF0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x21DDF60 Offset: 0x21DE061 VA: 0x21DDF60
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x21DDFD0 Offset: 0x21DE0D1 VA: 0x21DDFD0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x21DE040 Offset: 0x21DE141 VA: 0x21DE040
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x21DE0B0 Offset: 0x21DE1B1 VA: 0x21DE0B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x21DE120 Offset: 0x21DE221 VA: 0x21DE120
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x21DE190 Offset: 0x21DE291 VA: 0x21DE190
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x21DE200 Offset: 0x21DE301 VA: 0x21DE200
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x21DE270 Offset: 0x21DE371 VA: 0x21DE270
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x21DE2E0 Offset: 0x21DE3E1 VA: 0x21DE2E0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x21DE350 Offset: 0x21DE451 VA: 0x21DE350
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x21DE3C0 Offset: 0x21DE4C1 VA: 0x21DE3C0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x21DE430 Offset: 0x21DE531 VA: 0x21DE430
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x21DE4A0 Offset: 0x21DE5A1 VA: 0x21DE4A0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x21DE510 Offset: 0x21DE611 VA: 0x21DE510
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x21DE580 Offset: 0x21DE681 VA: 0x21DE580
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x21DE5F0 Offset: 0x21DE6F1 VA: 0x21DE5F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x21DE660 Offset: 0x21DE761 VA: 0x21DE660
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x21DE6D0 Offset: 0x21DE7D1 VA: 0x21DE6D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x21DE740 Offset: 0x21DE841 VA: 0x21DE740
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x21DE7B0 Offset: 0x21DE8B1 VA: 0x21DE7B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x21DE820 Offset: 0x21DE921 VA: 0x21DE820
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x21DE890 Offset: 0x21DE991 VA: 0x21DE890
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x21DE900 Offset: 0x21DEA01 VA: 0x21DE900
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x21DE970 Offset: 0x21DEA71 VA: 0x21DE970
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x21DE9E0 Offset: 0x21DEAE1 VA: 0x21DE9E0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x21DEA50 Offset: 0x21DEB51 VA: 0x21DEA50
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x21DEAC0 Offset: 0x21DEBC1 VA: 0x21DEAC0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x21DEB30 Offset: 0x21DEC31 VA: 0x21DEB30
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x21DEBA0 Offset: 0x21DECA1 VA: 0x21DEBA0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x21DEC10 Offset: 0x21DED11 VA: 0x21DEC10
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x21DEC80 Offset: 0x21DED81 VA: 0x21DEC80
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x21DECF0 Offset: 0x21DEDF1 VA: 0x21DECF0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x21DED60 Offset: 0x21DEE61 VA: 0x21DED60
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x21DEDD0 Offset: 0x21DEED1 VA: 0x21DEDD0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x21DEE40 Offset: 0x21DEF41 VA: 0x21DEE40
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x21DEEB0 Offset: 0x21DEFB1 VA: 0x21DEEB0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x21DEF20 Offset: 0x21DF021 VA: 0x21DEF20
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x21DEF90 Offset: 0x21DF091 VA: 0x21DEF90
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x21DF000 Offset: 0x21DF101 VA: 0x21DF000
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x21DF070 Offset: 0x21DF171 VA: 0x21DF070
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x21DF0E0 Offset: 0x21DF1E1 VA: 0x21DF0E0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x21DF150 Offset: 0x21DF251 VA: 0x21DF150
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x21DF1C0 Offset: 0x21DF2C1 VA: 0x21DF1C0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x21DF230 Offset: 0x21DF331 VA: 0x21DF230
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x21DF2A0 Offset: 0x21DF3A1 VA: 0x21DF2A0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x21DF310 Offset: 0x21DF411 VA: 0x21DF310
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x21DF380 Offset: 0x21DF481 VA: 0x21DF380
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x21DF3F0 Offset: 0x21DF4F1 VA: 0x21DF3F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x21DF460 Offset: 0x21DF561 VA: 0x21DF460
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x21DF4D0 Offset: 0x21DF5D1 VA: 0x21DF4D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x21DF540 Offset: 0x21DF641 VA: 0x21DF540
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x21DF5B0 Offset: 0x21DF6B1 VA: 0x21DF5B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x21DF620 Offset: 0x21DF721 VA: 0x21DF620
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x21DF690 Offset: 0x21DF791 VA: 0x21DF690
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x21DF700 Offset: 0x21DF801 VA: 0x21DF700
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x21DF770 Offset: 0x21DF871 VA: 0x21DF770
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x21DF7E0 Offset: 0x21DF8E1 VA: 0x21DF7E0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x21DF850 Offset: 0x21DF951 VA: 0x21DF850
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x21DF8C0 Offset: 0x21DF9C1 VA: 0x21DF8C0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x21DF930 Offset: 0x21DFA31 VA: 0x21DF930
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x21DF9A0 Offset: 0x21DFAA1 VA: 0x21DF9A0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x21DFA10 Offset: 0x21DFB11 VA: 0x21DFA10
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x21DFA80 Offset: 0x21DFB81 VA: 0x21DFA80
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x21DFAF0 Offset: 0x21DFBF1 VA: 0x21DFAF0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x21DFB60 Offset: 0x21DFC61 VA: 0x21DFB60
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x21DFBD0 Offset: 0x21DFCD1 VA: 0x21DFBD0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x21DFC40 Offset: 0x21DFD41 VA: 0x21DFC40
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x21DFCB0 Offset: 0x21DFDB1 VA: 0x21DFCB0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x21DFD20 Offset: 0x21DFE21 VA: 0x21DFD20
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x21DFD90 Offset: 0x21DFE91 VA: 0x21DFD90
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x21DFE00 Offset: 0x21DFF01 VA: 0x21DFE00
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x21DFE70 Offset: 0x21DFF71 VA: 0x21DFE70
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x21DFEE0 Offset: 0x21DFFE1 VA: 0x21DFEE0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x21DFF50 Offset: 0x21E0051 VA: 0x21DFF50
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x21DFFC0 Offset: 0x21E00C1 VA: 0x21DFFC0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x21E0030 Offset: 0x21E0131 VA: 0x21E0030
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x21E00A0 Offset: 0x21E01A1 VA: 0x21E00A0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x21E0110 Offset: 0x21E0211 VA: 0x21E0110
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x21E0180 Offset: 0x21E0281 VA: 0x21E0180
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x21E01F0 Offset: 0x21E02F1 VA: 0x21E01F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x21E0260 Offset: 0x21E0361 VA: 0x21E0260
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x21E02D0 Offset: 0x21E03D1 VA: 0x21E02D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x21E0340 Offset: 0x21E0441 VA: 0x21E0340
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x21E03B0 Offset: 0x21E04B1 VA: 0x21E03B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x21E0420 Offset: 0x21E0521 VA: 0x21E0420
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x21E0490 Offset: 0x21E0591 VA: 0x21E0490
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x21E0500 Offset: 0x21E0601 VA: 0x21E0500
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x21E0570 Offset: 0x21E0671 VA: 0x21E0570
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x21E05E0 Offset: 0x21E06E1 VA: 0x21E05E0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x21E0650 Offset: 0x21E0751 VA: 0x21E0650
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x21E06C0 Offset: 0x21E07C1 VA: 0x21E06C0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x21E0730 Offset: 0x21E0831 VA: 0x21E0730
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x21E07A0 Offset: 0x21E08A1 VA: 0x21E07A0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x21E0810 Offset: 0x21E0911 VA: 0x21E0810
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x21E0880 Offset: 0x21E0981 VA: 0x21E0880
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x21E08F0 Offset: 0x21E09F1 VA: 0x21E08F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x21E0960 Offset: 0x21E0A61 VA: 0x21E0960
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x21E09D0 Offset: 0x21E0AD1 VA: 0x21E09D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x21E0A40 Offset: 0x21E0B41 VA: 0x21E0A40
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x21E0AB0 Offset: 0x21E0BB1 VA: 0x21E0AB0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x21E0B20 Offset: 0x21E0C21 VA: 0x21E0B20
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x21E0B90 Offset: 0x21E0C91 VA: 0x21E0B90
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x21E0C00 Offset: 0x21E0D01 VA: 0x21E0C00
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x21E0C70 Offset: 0x21E0D71 VA: 0x21E0C70
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<int>>
	|
	|-RVA: 0x21E0CE0 Offset: 0x21E0DE1 VA: 0x21E0CE0
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x21E0D50 Offset: 0x21E0E51 VA: 0x21E0D50
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<object>>
	|
	|-RVA: 0x21E0DC0 Offset: 0x21E0EC1 VA: 0x21E0DC0
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<uint>>
	|
	|-RVA: 0x21E0E30 Offset: 0x21E0F31 VA: 0x21E0E30
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<Edge>>
	|
	|-RVA: 0x21E0EA0 Offset: 0x21E0FA1 VA: 0x21E0EA0
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x21E0F10 Offset: 0x21E1011 VA: 0x21E0F10
	|-Array.InternalArray__ICollection_Add<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x21E0F80 Offset: 0x21E1081 VA: 0x21E0F80
	|-Array.InternalArray__ICollection_Add<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x21E0FF0 Offset: 0x21E10F1 VA: 0x21E0FF0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x21E1060 Offset: 0x21E1161 VA: 0x21E1060
	|-Array.InternalArray__ICollection_Add<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x21E10D0 Offset: 0x21E11D1 VA: 0x21E10D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x21E1140 Offset: 0x21E1241 VA: 0x21E1140
	|-Array.InternalArray__ICollection_Add<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x21E11B0 Offset: 0x21E12B1 VA: 0x21E11B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x21E1220 Offset: 0x21E1321 VA: 0x21E1220
	|-Array.InternalArray__ICollection_Add<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x21E1290 Offset: 0x21E1391 VA: 0x21E1290
	|-Array.InternalArray__ICollection_Add<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x21E1300 Offset: 0x21E1401 VA: 0x21E1300
	|-Array.InternalArray__ICollection_Add<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x21E1370 Offset: 0x21E1471 VA: 0x21E1370
	|-Array.InternalArray__ICollection_Add<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x21E13E0 Offset: 0x21E14E1 VA: 0x21E13E0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x21E1450 Offset: 0x21E1551 VA: 0x21E1450
	|-Array.InternalArray__ICollection_Add<KeyValuePair<bool, object>>
	|
	|-RVA: 0x21E14C0 Offset: 0x21E15C1 VA: 0x21E14C0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<byte, object>>
	|
	|-RVA: 0x21E1530 Offset: 0x21E1631 VA: 0x21E1530
	|-Array.InternalArray__ICollection_Add<KeyValuePair<char, object>>
	|
	|-RVA: 0x21E15A0 Offset: 0x21E16A1 VA: 0x21E15A0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x21E1610 Offset: 0x21E1711 VA: 0x21E1610
	|-Array.InternalArray__ICollection_Add<KeyValuePair<double, object>>
	|
	|-RVA: 0x21E1680 Offset: 0x21E1781 VA: 0x21E1680
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x21E16F0 Offset: 0x21E17F1 VA: 0x21E16F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<short, object>>
	|
	|-RVA: 0x21E1760 Offset: 0x21E1861 VA: 0x21E1760
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x21E17D0 Offset: 0x21E18D1 VA: 0x21E17D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x21E1840 Offset: 0x21E1941 VA: 0x21E1840
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x21E18B0 Offset: 0x21E19B1 VA: 0x21E18B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x21E1920 Offset: 0x21E1A21 VA: 0x21E1920
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x21E1990 Offset: 0x21E1A91 VA: 0x21E1990
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, bool>>
	|
	|-RVA: 0x21E1A00 Offset: 0x21E1B01 VA: 0x21E1A00
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, char>>
	|
	|-RVA: 0x21E1A70 Offset: 0x21E1B71 VA: 0x21E1A70
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, int>>
	|
	|-RVA: 0x21E1AE0 Offset: 0x21E1BE1 VA: 0x21E1AE0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x21E1B50 Offset: 0x21E1C51 VA: 0x21E1B50
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, long>>
	|
	|-RVA: 0x21E1BC0 Offset: 0x21E1CC1 VA: 0x21E1BC0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, object>>
	|
	|-RVA: 0x21E1C30 Offset: 0x21E1D31 VA: 0x21E1C30
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x21E1CA0 Offset: 0x21E1DA1 VA: 0x21E1CA0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x21E1D10 Offset: 0x21E1E11 VA: 0x21E1D10
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x21E1D80 Offset: 0x21E1E81 VA: 0x21E1D80
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x21E1DF0 Offset: 0x21E1EF1 VA: 0x21E1DF0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x21E1E60 Offset: 0x21E1F61 VA: 0x21E1E60
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x21E1ED0 Offset: 0x21E1FD1 VA: 0x21E1ED0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x21E1F40 Offset: 0x21E2041 VA: 0x21E1F40
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x21E1FB0 Offset: 0x21E20B1 VA: 0x21E1FB0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x21E2020 Offset: 0x21E2121 VA: 0x21E2020
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x21E2090 Offset: 0x21E2191 VA: 0x21E2090
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x21E2100 Offset: 0x21E2201 VA: 0x21E2100
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x21E2170 Offset: 0x21E2271 VA: 0x21E2170
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x21E21E0 Offset: 0x21E22E1 VA: 0x21E21E0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x21E2250 Offset: 0x21E2351 VA: 0x21E2250
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x21E22C0 Offset: 0x21E23C1 VA: 0x21E22C0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x21E2330 Offset: 0x21E2431 VA: 0x21E2330
	|-Array.InternalArray__ICollection_Add<KeyValuePair<long, object>>
	|
	|-RVA: 0x1DB5DB0 Offset: 0x1DB5EB1 VA: 0x1DB5DB0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x1DB5E20 Offset: 0x1DB5F21 VA: 0x1DB5E20
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x1DB5E90 Offset: 0x1DB5F91 VA: 0x1DB5E90
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x1DB5F00 Offset: 0x1DB6001 VA: 0x1DB5F00
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x1DB5F70 Offset: 0x1DB6071 VA: 0x1DB5F70
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x1DB5FE0 Offset: 0x1DB60E1 VA: 0x1DB5FE0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x1DB6050 Offset: 0x1DB6151 VA: 0x1DB6050
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x1DB60C0 Offset: 0x1DB61C1 VA: 0x1DB60C0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x1DB6130 Offset: 0x1DB6231 VA: 0x1DB6130
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x1DB61A0 Offset: 0x1DB62A1 VA: 0x1DB61A0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x1DB6210 Offset: 0x1DB6311 VA: 0x1DB6210
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x1DB6280 Offset: 0x1DB6381 VA: 0x1DB6280
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x1DB62F0 Offset: 0x1DB63F1 VA: 0x1DB62F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x1DB6360 Offset: 0x1DB6461 VA: 0x1DB6360
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x1DB63D0 Offset: 0x1DB64D1 VA: 0x1DB63D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x1DB6440 Offset: 0x1DB6541 VA: 0x1DB6440
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x1DB64B0 Offset: 0x1DB65B1 VA: 0x1DB64B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x1DB6520 Offset: 0x1DB6621 VA: 0x1DB6520
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x1DB6590 Offset: 0x1DB6691 VA: 0x1DB6590
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x1DB6600 Offset: 0x1DB6701 VA: 0x1DB6600
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x1DB6670 Offset: 0x1DB6771 VA: 0x1DB6670
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x1DB66E0 Offset: 0x1DB67E1 VA: 0x1DB66E0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x1DB6750 Offset: 0x1DB6851 VA: 0x1DB6750
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x1DB67C0 Offset: 0x1DB68C1 VA: 0x1DB67C0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x1DB6830 Offset: 0x1DB6931 VA: 0x1DB6830
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x1DB68A0 Offset: 0x1DB69A1 VA: 0x1DB68A0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x1DB6910 Offset: 0x1DB6A11 VA: 0x1DB6910
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x1DB6980 Offset: 0x1DB6A81 VA: 0x1DB6980
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x1DB69F0 Offset: 0x1DB6AF1 VA: 0x1DB69F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x1DB6A60 Offset: 0x1DB6B61 VA: 0x1DB6A60
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x1DB6AD0 Offset: 0x1DB6BD1 VA: 0x1DB6AD0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x1DB6B40 Offset: 0x1DB6C41 VA: 0x1DB6B40
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x1DB6BB0 Offset: 0x1DB6CB1 VA: 0x1DB6BB0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, bool>>
	|
	|-RVA: 0x1DB6C20 Offset: 0x1DB6D21 VA: 0x1DB6C20
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, byte>>
	|
	|-RVA: 0x1DB6C90 Offset: 0x1DB6D91 VA: 0x1DB6C90
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, char>>
	|
	|-RVA: 0x1DB6D00 Offset: 0x1DB6E01 VA: 0x1DB6D00
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x1DB6D70 Offset: 0x1DB6E71 VA: 0x1DB6D70
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, double>>
	|
	|-RVA: 0x1DB6DE0 Offset: 0x1DB6EE1 VA: 0x1DB6DE0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, short>>
	|
	|-RVA: 0x1DB6E50 Offset: 0x1DB6F51 VA: 0x1DB6E50
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, int>>
	|
	|-RVA: 0x1DB6EC0 Offset: 0x1DB6FC1 VA: 0x1DB6EC0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x1DB6F30 Offset: 0x1DB7031 VA: 0x1DB6F30
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, long>>
	|
	|-RVA: 0x1DB6FA0 Offset: 0x1DB70A1 VA: 0x1DB6FA0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x1DB7010 Offset: 0x1DB7111 VA: 0x1DB7010
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x1DB7080 Offset: 0x1DB7181 VA: 0x1DB7080
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x1DB70F0 Offset: 0x1DB71F1 VA: 0x1DB70F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x1DB7160 Offset: 0x1DB7261 VA: 0x1DB7160
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x1DB71D0 Offset: 0x1DB72D1 VA: 0x1DB71D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x1DB7240 Offset: 0x1DB7341 VA: 0x1DB7240
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x1DB72B0 Offset: 0x1DB73B1 VA: 0x1DB72B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x1DB7320 Offset: 0x1DB7421 VA: 0x1DB7320
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x1DB7390 Offset: 0x1DB7491 VA: 0x1DB7390
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x1DB7400 Offset: 0x1DB7501 VA: 0x1DB7400
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x1DB7470 Offset: 0x1DB7571 VA: 0x1DB7470
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x1DB74E0 Offset: 0x1DB75E1 VA: 0x1DB74E0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x1DB7550 Offset: 0x1DB7651 VA: 0x1DB7550
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x1DB75C0 Offset: 0x1DB76C1 VA: 0x1DB75C0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x1DB7630 Offset: 0x1DB7731 VA: 0x1DB7630
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x1DB76A0 Offset: 0x1DB77A1 VA: 0x1DB76A0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x1DB7710 Offset: 0x1DB7811 VA: 0x1DB7710
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x1DB7780 Offset: 0x1DB7881 VA: 0x1DB7780
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x1DB77F0 Offset: 0x1DB78F1 VA: 0x1DB77F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x1DB7860 Offset: 0x1DB7961 VA: 0x1DB7860
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, object>>
	|
	|-RVA: 0x1DB78D0 Offset: 0x1DB79D1 VA: 0x1DB78D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x1DB7940 Offset: 0x1DB7A41 VA: 0x1DB7940
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x1DB79B0 Offset: 0x1DB7AB1 VA: 0x1DB79B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x1DB7A20 Offset: 0x1DB7B21 VA: 0x1DB7A20
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, float>>
	|
	|-RVA: 0x1DB7A90 Offset: 0x1DB7B91 VA: 0x1DB7A90
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x1DB7B00 Offset: 0x1DB7C01 VA: 0x1DB7B00
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, uint>>
	|
	|-RVA: 0x1DB7B70 Offset: 0x1DB7C71 VA: 0x1DB7B70
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x1DB7BE0 Offset: 0x1DB7CE1 VA: 0x1DB7BE0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x1DB7C50 Offset: 0x1DB7D51 VA: 0x1DB7C50
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x1DB7CC0 Offset: 0x1DB7DC1 VA: 0x1DB7CC0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x1DB7D30 Offset: 0x1DB7E31 VA: 0x1DB7D30
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x1DB7DA0 Offset: 0x1DB7EA1 VA: 0x1DB7DA0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Color>>
	|
	|-RVA: 0x1DB7E10 Offset: 0x1DB7F11 VA: 0x1DB7E10
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x1DB7E80 Offset: 0x1DB7F81 VA: 0x1DB7E80
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x1DB7EF0 Offset: 0x1DB7FF1 VA: 0x1DB7EF0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x1DB7F60 Offset: 0x1DB8061 VA: 0x1DB7F60
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x1DB7FD0 Offset: 0x1DB80D1 VA: 0x1DB7FD0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x1DB8040 Offset: 0x1DB8141 VA: 0x1DB8040
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x1DB80B0 Offset: 0x1DB81B1 VA: 0x1DB80B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x1DB8120 Offset: 0x1DB8221 VA: 0x1DB8120
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x1DB8190 Offset: 0x1DB8291 VA: 0x1DB8190
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x1DB8200 Offset: 0x1DB8301 VA: 0x1DB8200
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x1DB8270 Offset: 0x1DB8371 VA: 0x1DB8270
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1DB82E0 Offset: 0x1DB83E1 VA: 0x1DB82E0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1DB8350 Offset: 0x1DB8451 VA: 0x1DB8350
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x1DB83C0 Offset: 0x1DB84C1 VA: 0x1DB83C0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x1DB8430 Offset: 0x1DB8531 VA: 0x1DB8430
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x1DB84A0 Offset: 0x1DB85A1 VA: 0x1DB84A0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x1DB8510 Offset: 0x1DB8611 VA: 0x1DB8510
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x1DB8580 Offset: 0x1DB8681 VA: 0x1DB8580
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x1DB85F0 Offset: 0x1DB86F1 VA: 0x1DB85F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x1DB8660 Offset: 0x1DB8761 VA: 0x1DB8660
	|-Array.InternalArray__ICollection_Add<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x1DB86D0 Offset: 0x1DB87D1 VA: 0x1DB86D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x1DB8740 Offset: 0x1DB8841 VA: 0x1DB8740
	|-Array.InternalArray__ICollection_Add<KeyValuePair<float, object>>
	|
	|-RVA: 0x1DB87B0 Offset: 0x1DB88B1 VA: 0x1DB87B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x1DB8820 Offset: 0x1DB8921 VA: 0x1DB8820
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, int>>
	|
	|-RVA: 0x1DB8890 Offset: 0x1DB8991 VA: 0x1DB8890
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x1DB8900 Offset: 0x1DB8A01 VA: 0x1DB8900
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, object>>
	|
	|-RVA: 0x1DB8970 Offset: 0x1DB8A71 VA: 0x1DB8970
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x1DB89E0 Offset: 0x1DB8AE1 VA: 0x1DB89E0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x1DB8A50 Offset: 0x1DB8B51 VA: 0x1DB8A50
	|-Array.InternalArray__ICollection_Add<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x1DB8AC0 Offset: 0x1DB8BC1 VA: 0x1DB8AC0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x1DB8B30 Offset: 0x1DB8C31 VA: 0x1DB8B30
	|-Array.InternalArray__ICollection_Add<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x1DB8BA0 Offset: 0x1DB8CA1 VA: 0x1DB8BA0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x1DB8C10 Offset: 0x1DB8D11 VA: 0x1DB8C10
	|-Array.InternalArray__ICollection_Add<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x1DB8C80 Offset: 0x1DB8D81 VA: 0x1DB8C80
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x1DB8CF0 Offset: 0x1DB8DF1 VA: 0x1DB8CF0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x1DB8D60 Offset: 0x1DB8E61 VA: 0x1DB8D60
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Color, object>>
	|
	|-RVA: 0x1DB8DD0 Offset: 0x1DB8ED1 VA: 0x1DB8DD0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x1DB8E40 Offset: 0x1DB8F41 VA: 0x1DB8E40
	|-Array.InternalArray__ICollection_Add<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1DB8EB0 Offset: 0x1DB8FB1 VA: 0x1DB8EB0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x1DB8F20 Offset: 0x1DB9021 VA: 0x1DB8F20
	|-Array.InternalArray__ICollection_Add<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x1DB8F90 Offset: 0x1DB9091 VA: 0x1DB8F90
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x1DB9000 Offset: 0x1DB9101 VA: 0x1DB9000
	|-Array.InternalArray__ICollection_Add<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x1DB9070 Offset: 0x1DB9171 VA: 0x1DB9070
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x1DB90E0 Offset: 0x1DB91E1 VA: 0x1DB90E0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x1DB9150 Offset: 0x1DB9251 VA: 0x1DB9150
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x1DB91C0 Offset: 0x1DB92C1 VA: 0x1DB91C0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x1DB9230 Offset: 0x1DB9331 VA: 0x1DB9230
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x1DB92A0 Offset: 0x1DB93A1 VA: 0x1DB92A0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x1DB9310 Offset: 0x1DB9411 VA: 0x1DB9310
	|-Array.InternalArray__ICollection_Add<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x1DB9380 Offset: 0x1DB9481 VA: 0x1DB9380
	|-Array.InternalArray__ICollection_Add<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x1DB93F0 Offset: 0x1DB94F1 VA: 0x1DB93F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x1DB9460 Offset: 0x1DB9561 VA: 0x1DB9460
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x1DB94D0 Offset: 0x1DB95D1 VA: 0x1DB94D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x1DB9540 Offset: 0x1DB9641 VA: 0x1DB9540
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x1DB95B0 Offset: 0x1DB96B1 VA: 0x1DB95B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x1DB9620 Offset: 0x1DB9721 VA: 0x1DB9620
	|-Array.InternalArray__ICollection_Add<Hashtable.bucket>
	|
	|-RVA: 0x1DB9690 Offset: 0x1DB9791 VA: 0x1DB9690
	|-Array.InternalArray__ICollection_Add<DateTime>
	|
	|-RVA: 0x1DB9700 Offset: 0x1DB9801 VA: 0x1DB9700
	|-Array.InternalArray__ICollection_Add<DateTimeOffset>
	|
	|-RVA: 0x1DB9770 Offset: 0x1DB9871 VA: 0x1DB9770
	|-Array.InternalArray__ICollection_Add<Decimal>
	|
	|-RVA: 0x1DB97E0 Offset: 0x1DB98E1 VA: 0x1DB97E0
	|-Array.InternalArray__ICollection_Add<double>
	|
	|-RVA: 0x1DB9850 Offset: 0x1DB9951 VA: 0x1DB9850
	|-Array.InternalArray__ICollection_Add<InternalCodePageDataItem>
	|
	|-RVA: 0x1DB98C0 Offset: 0x1DB99C1 VA: 0x1DB98C0
	|-Array.InternalArray__ICollection_Add<InternalEncodingDataItem>
	|
	|-RVA: 0x1DB9930 Offset: 0x1DB9A31 VA: 0x1DB9930
	|-Array.InternalArray__ICollection_Add<Guid>
	|
	|-RVA: 0x1DB99A0 Offset: 0x1DB9AA1 VA: 0x1DB99A0
	|-Array.InternalArray__ICollection_Add<short>
	|
	|-RVA: 0x1DB9A10 Offset: 0x1DB9B11 VA: 0x1DB9A10
	|-Array.InternalArray__ICollection_Add<int>
	|
	|-RVA: 0x1DB9A80 Offset: 0x1DB9B81 VA: 0x1DB9A80
	|-Array.InternalArray__ICollection_Add<Int32Enum>
	|
	|-RVA: 0x1DB9AF0 Offset: 0x1DB9BF1 VA: 0x1DB9AF0
	|-Array.InternalArray__ICollection_Add<long>
	|
	|-RVA: 0x1DB9B60 Offset: 0x1DB9C61 VA: 0x1DB9B60
	|-Array.InternalArray__ICollection_Add<IntPtr>
	|
	|-RVA: 0x1DB9BD0 Offset: 0x1DB9CD1 VA: 0x1DB9BD0
	|-Array.InternalArray__ICollection_Add<InterpretedFrameInfo>
	|
	|-RVA: 0x1DB9C40 Offset: 0x1DB9D41 VA: 0x1DB9C40
	|-Array.InternalArray__ICollection_Add<LocalDefinition>
	|
	|-RVA: 0x1DB9CB0 Offset: 0x1DB9DB1 VA: 0x1DB9CB0
	|-Array.InternalArray__ICollection_Add<RuntimeLabel>
	|
	|-RVA: 0x1DB9D20 Offset: 0x1DB9E21 VA: 0x1DB9D20
	|-Array.InternalArray__ICollection_Add<Set.Slot<int>>
	|
	|-RVA: 0x1DB9D90 Offset: 0x1DB9E91 VA: 0x1DB9D90
	|-Array.InternalArray__ICollection_Add<Set.Slot<object>>
	|
	|-RVA: 0x1DB9E00 Offset: 0x1DB9F01 VA: 0x1DB9E00
	|-Array.InternalArray__ICollection_Add<Memory<object>>
	|
	|-RVA: 0x1DB9E70 Offset: 0x1DB9F71 VA: 0x1DB9E70
	|-Array.InternalArray__ICollection_Add<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x1DB9EE0 Offset: 0x1DB9FE1 VA: 0x1DB9EE0
	|-Array.InternalArray__ICollection_Add<HeaderVariantInfo>
	|
	|-RVA: 0x1DB9F50 Offset: 0x1DBA051 VA: 0x1DB9F50
	|-Array.InternalArray__ICollection_Add<Socket.WSABUF>
	|
	|-RVA: 0x1DB9FC0 Offset: 0x1DBA0C1 VA: 0x1DB9FC0
	|-Array.InternalArray__ICollection_Add<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x1DBA030 Offset: 0x1DBA131 VA: 0x1DBA030
	|-Array.InternalArray__ICollection_Add<Nullable<Int32Enum>>
	|
	|-RVA: 0x1DBA0A0 Offset: 0x1DBA1A1 VA: 0x1DBA0A0
	|-Array.InternalArray__ICollection_Add<Nullable<Bounds>>
	|
	|-RVA: 0x1DBA110 Offset: 0x1DBA211 VA: 0x1DBA110
	|-Array.InternalArray__ICollection_Add<Nullable<BoundsInt>>
	|
	|-RVA: 0x1DBA180 Offset: 0x1DBA281 VA: 0x1DBA180
	|-Array.InternalArray__ICollection_Add<Nullable<Color32>>
	|
	|-RVA: 0x1DBA1F0 Offset: 0x1DBA2F1 VA: 0x1DBA1F0
	|-Array.InternalArray__ICollection_Add<Nullable<Color>>
	|
	|-RVA: 0x1DBA260 Offset: 0x1DBA361 VA: 0x1DBA260
	|-Array.InternalArray__ICollection_Add<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1DBA2D0 Offset: 0x1DBA3D1 VA: 0x1DBA2D0
	|-Array.InternalArray__ICollection_Add<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1DBA340 Offset: 0x1DBA441 VA: 0x1DBA340
	|-Array.InternalArray__ICollection_Add<Nullable<Keyframe>>
	|
	|-RVA: 0x1DBA3B0 Offset: 0x1DBA4B1 VA: 0x1DBA3B0
	|-Array.InternalArray__ICollection_Add<Nullable<LayerMask>>
	|
	|-RVA: 0x1DBA420 Offset: 0x1DBA521 VA: 0x1DBA420
	|-Array.InternalArray__ICollection_Add<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1DBA490 Offset: 0x1DBA591 VA: 0x1DBA490
	|-Array.InternalArray__ICollection_Add<Nullable<Quaternion>>
	|
	|-RVA: 0x1DBA500 Offset: 0x1DBA601 VA: 0x1DBA500
	|-Array.InternalArray__ICollection_Add<Nullable<RangeInt>>
	|
	|-RVA: 0x1DBA570 Offset: 0x1DBA671 VA: 0x1DBA570
	|-Array.InternalArray__ICollection_Add<Nullable<Rect>>
	|
	|-RVA: 0x1DBA5E0 Offset: 0x1DBA6E1 VA: 0x1DBA5E0
	|-Array.InternalArray__ICollection_Add<Nullable<RectInt>>
	|
	|-RVA: 0x1DBA650 Offset: 0x1DBA751 VA: 0x1DBA650
	|-Array.InternalArray__ICollection_Add<Nullable<Vector2>>
	|
	|-RVA: 0x1DBA6C0 Offset: 0x1DBA7C1 VA: 0x1DBA6C0
	|-Array.InternalArray__ICollection_Add<Nullable<Vector2Int>>
	|
	|-RVA: 0x1DBA730 Offset: 0x1DBA831 VA: 0x1DBA730
	|-Array.InternalArray__ICollection_Add<Nullable<Vector3>>
	|
	|-RVA: 0x1DBA7A0 Offset: 0x1DBA8A1 VA: 0x1DBA7A0
	|-Array.InternalArray__ICollection_Add<Nullable<Vector3Int>>
	|
	|-RVA: 0x1DBA810 Offset: 0x1DBA911 VA: 0x1DBA810
	|-Array.InternalArray__ICollection_Add<Nullable<Vector4>>
	|
	|-RVA: 0x1DBA880 Offset: 0x1DBA981 VA: 0x1DBA880
	|-Array.InternalArray__ICollection_Add<object>
	|
	|-RVA: 0x1DBA8F0 Offset: 0x1DBA9F1 VA: 0x1DBA8F0
	|-Array.InternalArray__ICollection_Add<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x1DBA960 Offset: 0x1DBAA61 VA: 0x1DBA960
	|-Array.InternalArray__ICollection_Add<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1DBA9D0 Offset: 0x1DBAAD1 VA: 0x1DBA9D0
	|-Array.InternalArray__ICollection_Add<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1DBAA40 Offset: 0x1DBAB41 VA: 0x1DBAA40
	|-Array.InternalArray__ICollection_Add<CustomAttributeTypedArgument>
	|
	|-RVA: 0x1DBAAB0 Offset: 0x1DBABB1 VA: 0x1DBAAB0
	|-Array.InternalArray__ICollection_Add<Label>
	|
	|-RVA: 0x1DBAB20 Offset: 0x1DBAC21 VA: 0x1DBAB20
	|-Array.InternalArray__ICollection_Add<ParameterModifier>
	|
	|-RVA: 0x1DBAB90 Offset: 0x1DBAC91 VA: 0x1DBAB90
	|-Array.InternalArray__ICollection_Add<ResourceLocator>
	|
	|-RVA: 0x1DBAC00 Offset: 0x1DBAD01 VA: 0x1DBAC00
	|-Array.InternalArray__ICollection_Add<Ephemeron>
	|
	|-RVA: 0x1DBAC70 Offset: 0x1DBAD71 VA: 0x1DBAC70
	|-Array.InternalArray__ICollection_Add<GCHandle>
	|
	|-RVA: 0x1DBACE0 Offset: 0x1DBADE1 VA: 0x1DBACE0
	|-Array.InternalArray__ICollection_Add<RuntimeTypeHandle>
	|
	|-RVA: 0x1DBAD50 Offset: 0x1DBAE51 VA: 0x1DBAD50
	|-Array.InternalArray__ICollection_Add<sbyte>
	|
	|-RVA: 0x1DBADC0 Offset: 0x1DBAEC1 VA: 0x1DBADC0
	|-Array.InternalArray__ICollection_Add<X509ChainStatus>
	|
	|-RVA: 0x1DBAE30 Offset: 0x1DBAF31 VA: 0x1DBAE30
	|-Array.InternalArray__ICollection_Add<float>
	|
	|-RVA: 0x1DBAEA0 Offset: 0x1DBAFA1 VA: 0x1DBAEA0
	|-Array.InternalArray__ICollection_Add<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x1DBAF10 Offset: 0x1DBB011 VA: 0x1DBAF10
	|-Array.InternalArray__ICollection_Add<CancellationTokenRegistration>
	|
	|-RVA: 0x1DBAF80 Offset: 0x1DBB081 VA: 0x1DBAF80
	|-Array.InternalArray__ICollection_Add<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x1DBAFF0 Offset: 0x1DBB0F1 VA: 0x1DBAFF0
	|-Array.InternalArray__ICollection_Add<TimeSpan>
	|
	|-RVA: 0x1DBB060 Offset: 0x1DBB161 VA: 0x1DBB060
	|-Array.InternalArray__ICollection_Add<ushort>
	|
	|-RVA: 0x1DBB0D0 Offset: 0x1DBB1D1 VA: 0x1DBB0D0
	|-Array.InternalArray__ICollection_Add<UInt16Enum>
	|
	|-RVA: 0x1DBB140 Offset: 0x1DBB241 VA: 0x1DBB140
	|-Array.InternalArray__ICollection_Add<uint>
	|
	|-RVA: 0x1DBB1B0 Offset: 0x1DBB2B1 VA: 0x1DBB1B0
	|-Array.InternalArray__ICollection_Add<UInt32Enum>
	|
	|-RVA: 0x1DBB220 Offset: 0x1DBB321 VA: 0x1DBB220
	|-Array.InternalArray__ICollection_Add<ulong>
	|
	|-RVA: 0x1DBB290 Offset: 0x1DBB391 VA: 0x1DBB290
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x1DBB300 Offset: 0x1DBB401 VA: 0x1DBB300
	|-Array.InternalArray__ICollection_Add<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x1DBB370 Offset: 0x1DBB471 VA: 0x1DBB370
	|-Array.InternalArray__ICollection_Add<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x1DBB3E0 Offset: 0x1DBB4E1 VA: 0x1DBB3E0
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x1DBB450 Offset: 0x1DBB551 VA: 0x1DBB450
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object>>
	|
	|-RVA: 0x1DBB4C0 Offset: 0x1DBB5C1 VA: 0x1DBB4C0
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, float>>
	|
	|-RVA: 0x1DBB530 Offset: 0x1DBB631 VA: 0x1DBB530
	|-Array.InternalArray__ICollection_Add<ValueTuple<float, object>>
	|
	|-RVA: 0x1DBB5A0 Offset: 0x1DBB6A1 VA: 0x1DBB5A0
	|-Array.InternalArray__ICollection_Add<ValueTuple<float, float>>
	|
	|-RVA: 0x1DBB610 Offset: 0x1DBB711 VA: 0x1DBB610
	|-Array.InternalArray__ICollection_Add<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x1DBB680 Offset: 0x1DBB781 VA: 0x1DBB680
	|-Array.InternalArray__ICollection_Add<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1DBB6F0 Offset: 0x1DBB7F1 VA: 0x1DBB6F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x1DBB760 Offset: 0x1DBB861 VA: 0x1DBB760
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x1DBB7D0 Offset: 0x1DBB8D1 VA: 0x1DBB7D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x1DBB840 Offset: 0x1DBB941 VA: 0x1DBB840
	|-Array.InternalArray__ICollection_Add<HighlightState>
	|
	|-RVA: 0x1DBB8B0 Offset: 0x1DBB9B1 VA: 0x1DBB8B0
	|-Array.InternalArray__ICollection_Add<MaterialReference>
	|
	|-RVA: 0x1DBB920 Offset: 0x1DBBA21 VA: 0x1DBB920
	|-Array.InternalArray__ICollection_Add<RichTextTagAttribute>
	|
	|-RVA: 0x1DBB990 Offset: 0x1DBBA91 VA: 0x1DBB990
	|-Array.InternalArray__ICollection_Add<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x1DBBA00 Offset: 0x1DBBB01 VA: 0x1DBBA00
	|-Array.InternalArray__ICollection_Add<TMP_CharacterInfo>
	|
	|-RVA: 0x1DBBA70 Offset: 0x1DBBB71 VA: 0x1DBBA70
	|-Array.InternalArray__ICollection_Add<TMP_FontWeightPair>
	|
	|-RVA: 0x1DBBAE0 Offset: 0x1DBBBE1 VA: 0x1DBBAE0
	|-Array.InternalArray__ICollection_Add<TMP_LineInfo>
	|
	|-RVA: 0x1DBBB50 Offset: 0x1DBBC51 VA: 0x1DBBB50
	|-Array.InternalArray__ICollection_Add<TMP_LinkInfo>
	|
	|-RVA: 0x1DBBBC0 Offset: 0x1DBBCC1 VA: 0x1DBBBC0
	|-Array.InternalArray__ICollection_Add<TMP_MeshInfo>
	|
	|-RVA: 0x1DBBC30 Offset: 0x1DBBD31 VA: 0x1DBBC30
	|-Array.InternalArray__ICollection_Add<TMP_PageInfo>
	|
	|-RVA: 0x1DBBCA0 Offset: 0x1DBBDA1 VA: 0x1DBBCA0
	|-Array.InternalArray__ICollection_Add<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x1DBBD10 Offset: 0x1DBBE11 VA: 0x1DBBD10
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x1DBBD80 Offset: 0x1DBBE81 VA: 0x1DBBD80
	|-Array.InternalArray__ICollection_Add<TMP_WordInfo>
	|
	|-RVA: 0x1DBBDF0 Offset: 0x1DBBEF1 VA: 0x1DBBDF0
	|-Array.InternalArray__ICollection_Add<WordWrapState>
	|
	|-RVA: 0x1DBBE60 Offset: 0x1DBBF61 VA: 0x1DBBE60
	|-Array.InternalArray__ICollection_Add<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x1DBBED0 Offset: 0x1DBBFD1 VA: 0x1DBBED0
	|-Array.InternalArray__ICollection_Add<TransitionTables>
	|
	|-RVA: 0x1DBBF40 Offset: 0x1DBC041 VA: 0x1DBBF40
	|-Array.InternalArray__ICollection_Add<TutorialUnlockFlagData>
	|
	|-RVA: 0x1DBBFB0 Offset: 0x1DBC0B1 VA: 0x1DBBFB0
	|-Array.InternalArray__ICollection_Add<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x1DBC020 Offset: 0x1DBC121 VA: 0x1DBC020
	|-Array.InternalArray__ICollection_Add<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x1DBC090 Offset: 0x1DBC191 VA: 0x1DBC090
	|-Array.InternalArray__ICollection_Add<CapEdge>
	|
	|-RVA: 0x1DBC100 Offset: 0x1DBC201 VA: 0x1DBC100
	|-Array.InternalArray__ICollection_Add<ClippedEdge>
	|
	|-RVA: 0x1DBC170 Offset: 0x1DBC271 VA: 0x1DBC170
	|-Array.InternalArray__ICollection_Add<EdgeKeyByHash>
	|
	|-RVA: 0x1DBC1E0 Offset: 0x1DBC2E1 VA: 0x1DBC1E0
	|-Array.InternalArray__ICollection_Add<EdgeKeyByIndex>
	|
	|-RVA: 0x1DBC250 Offset: 0x1DBC351 VA: 0x1DBC250
	|-Array.InternalArray__ICollection_Add<MeshDataConnectivity.Face>
	|
	|-RVA: 0x1DBC2C0 Offset: 0x1DBC3C1 VA: 0x1DBC2C0
	|-Array.InternalArray__ICollection_Add<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x1DBC330 Offset: 0x1DBC431 VA: 0x1DBC330
	|-Array.InternalArray__ICollection_Add<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x1DBC3A0 Offset: 0x1DBC4A1 VA: 0x1DBC3A0
	|-Array.InternalArray__ICollection_Add<NavMeshBuildMarkup>
	|
	|-RVA: 0x1DBC410 Offset: 0x1DBC511 VA: 0x1DBC410
	|-Array.InternalArray__ICollection_Add<NavMeshBuildSource>
	|
	|-RVA: 0x1DBC480 Offset: 0x1DBC581 VA: 0x1DBC480
	|-Array.InternalArray__ICollection_Add<ContentCatalogData.Bucket>
	|
	|-RVA: 0x1DBC4F0 Offset: 0x1DBC5F1 VA: 0x1DBC4F0
	|-Array.InternalArray__ICollection_Add<ConstraintSource>
	|
	|-RVA: 0x1DBC560 Offset: 0x1DBC661 VA: 0x1DBC560
	|-Array.InternalArray__ICollection_Add<PropertySceneHandle>
	|
	|-RVA: 0x1DBC5D0 Offset: 0x1DBC6D1 VA: 0x1DBC5D0
	|-Array.InternalArray__ICollection_Add<TransformStreamHandle>
	|
	|-RVA: 0x1DBC640 Offset: 0x1DBC741 VA: 0x1DBC640
	|-Array.InternalArray__ICollection_Add<AnimatorClipInfo>
	|
	|-RVA: 0x1DBC6B0 Offset: 0x1DBC7B1 VA: 0x1DBC6B0
	|-Array.InternalArray__ICollection_Add<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x1DBC720 Offset: 0x1DBC821 VA: 0x1DBC720
	|-Array.InternalArray__ICollection_Add<BoneWeight1>
	|
	|-RVA: 0x1DBC790 Offset: 0x1DBC891 VA: 0x1DBC790
	|-Array.InternalArray__ICollection_Add<BoneWeight>
	|
	|-RVA: 0x1DBC800 Offset: 0x1DBC901 VA: 0x1DBC800
	|-Array.InternalArray__ICollection_Add<BoundingSphere>
	|
	|-RVA: 0x1DBC870 Offset: 0x1DBC971 VA: 0x1DBC870
	|-Array.InternalArray__ICollection_Add<Bounds>
	|
	|-RVA: 0x1DBC8E0 Offset: 0x1DBC9E1 VA: 0x1DBC8E0
	|-Array.InternalArray__ICollection_Add<BoundsInt>
	|
	|-RVA: 0x1DBC950 Offset: 0x1DBCA51 VA: 0x1DBC950
	|-Array.InternalArray__ICollection_Add<CharacterInfo>
	|
	|-RVA: 0x1DBC9C0 Offset: 0x1DBCAC1 VA: 0x1DBC9C0
	|-Array.InternalArray__ICollection_Add<Color32>
	|
	|-RVA: 0x1DBCA30 Offset: 0x1DBCB31 VA: 0x1DBCA30
	|-Array.InternalArray__ICollection_Add<Color>
	|
	|-RVA: 0x1DBCAA0 Offset: 0x1DBCBA1 VA: 0x1DBCAA0
	|-Array.InternalArray__ICollection_Add<CombineInstance>
	|
	|-RVA: 0x1DBCB10 Offset: 0x1DBCC11 VA: 0x1DBCB10
	|-Array.InternalArray__ICollection_Add<ContactPoint2D>
	|
	|-RVA: 0x1DBCB80 Offset: 0x1DBCC81 VA: 0x1DBCB80
	|-Array.InternalArray__ICollection_Add<ContactPoint>
	|
	|-RVA: 0x1DBCBF0 Offset: 0x1DBCCF1 VA: 0x1DBCBF0
	|-Array.InternalArray__ICollection_Add<RaycastResult>
	|
	|-RVA: 0x1DBCC60 Offset: 0x1DBCD61 VA: 0x1DBCC60
	|-Array.InternalArray__ICollection_Add<LightDataGI>
	|
	|-RVA: 0x1DBCCD0 Offset: 0x1DBCDD1 VA: 0x1DBCCD0
	|-Array.InternalArray__ICollection_Add<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x1DBCD40 Offset: 0x1DBCE41 VA: 0x1DBCD40
	|-Array.InternalArray__ICollection_Add<GradientAlphaKey>
	|
	|-RVA: 0x1DBCDB0 Offset: 0x1DBCEB1 VA: 0x1DBCDB0
	|-Array.InternalArray__ICollection_Add<GradientColorKey>
	|
	|-RVA: 0x1DBCE20 Offset: 0x1DBCF21 VA: 0x1DBCE20
	|-Array.InternalArray__ICollection_Add<HumanBone>
	|
	|-RVA: 0x1DBCE90 Offset: 0x1DBCF91 VA: 0x1DBCE90
	|-Array.InternalArray__ICollection_Add<Keyframe>
	|
	|-RVA: 0x1DBCF00 Offset: 0x1DBD001 VA: 0x1DBCF00
	|-Array.InternalArray__ICollection_Add<LOD>
	|
	|-RVA: 0x1DBCF70 Offset: 0x1DBD071 VA: 0x1DBCF70
	|-Array.InternalArray__ICollection_Add<LayerMask>
	|
	|-RVA: 0x1DBCFE0 Offset: 0x1DBD0E1 VA: 0x1DBCFE0
	|-Array.InternalArray__ICollection_Add<PlayerLoopSystem>
	|
	|-RVA: 0x1DBD050 Offset: 0x1DBD151 VA: 0x1DBD050
	|-Array.InternalArray__ICollection_Add<Matrix4x4>
	|
	|-RVA: 0x1DBD0C0 Offset: 0x1DBD1C1 VA: 0x1DBD0C0
	|-Array.InternalArray__ICollection_Add<ParticleSystem.Particle>
	|
	|-RVA: 0x1DBD130 Offset: 0x1DBD231 VA: 0x1DBD130
	|-Array.InternalArray__ICollection_Add<PatchExtents>
	|
	|-RVA: 0x1DBD1A0 Offset: 0x1DBD2A1 VA: 0x1DBD1A0
	|-Array.InternalArray__ICollection_Add<Plane>
	|
	|-RVA: 0x1DBD210 Offset: 0x1DBD311 VA: 0x1DBD210
	|-Array.InternalArray__ICollection_Add<Playable>
	|
	|-RVA: 0x1DBD280 Offset: 0x1DBD381 VA: 0x1DBD280
	|-Array.InternalArray__ICollection_Add<PlayableBinding>
	|
	|-RVA: 0x1DBD2F0 Offset: 0x1DBD3F1 VA: 0x1DBD2F0
	|-Array.InternalArray__ICollection_Add<PlayableGraph>
	|
	|-RVA: 0x1DBD360 Offset: 0x1DBD461 VA: 0x1DBD360
	|-Array.InternalArray__ICollection_Add<Edge>
	|
	|-RVA: 0x1DBD3D0 Offset: 0x1DBD4D1 VA: 0x1DBD3D0
	|-Array.InternalArray__ICollection_Add<IntVec3>
	|
	|-RVA: 0x1DBD440 Offset: 0x1DBD541 VA: 0x1DBD440
	|-Array.InternalArray__ICollection_Add<Quaternion>
	|
	|-RVA: 0x1DBD4B0 Offset: 0x1DBD5B1 VA: 0x1DBD4B0
	|-Array.InternalArray__ICollection_Add<RangeInt>
	|
	|-RVA: 0x1DBD520 Offset: 0x1DBD621 VA: 0x1DBD520
	|-Array.InternalArray__ICollection_Add<RaycastHit2D>
	|
	|-RVA: 0x1DBD590 Offset: 0x1DBD691 VA: 0x1DBD590
	|-Array.InternalArray__ICollection_Add<RaycastHit>
	|
	|-RVA: 0x1DBD600 Offset: 0x1DBD701 VA: 0x1DBD600
	|-Array.InternalArray__ICollection_Add<Rect>
	|
	|-RVA: 0x1DBD670 Offset: 0x1DBD771 VA: 0x1DBD670
	|-Array.InternalArray__ICollection_Add<RectInt>
	|
	|-RVA: 0x1DBD6E0 Offset: 0x1DBD7E1 VA: 0x1DBD6E0
	|-Array.InternalArray__ICollection_Add<RenderBuffer>
	|
	|-RVA: 0x1DBD750 Offset: 0x1DBD851 VA: 0x1DBD750
	|-Array.InternalArray__ICollection_Add<BatchVisibility>
	|
	|-RVA: 0x1DBD7C0 Offset: 0x1DBD8C1 VA: 0x1DBD7C0
	|-Array.InternalArray__ICollection_Add<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x1DBD830 Offset: 0x1DBD931 VA: 0x1DBD830
	|-Array.InternalArray__ICollection_Add<SphericalHarmonicsL2>
	|
	|-RVA: 0x1DBD8A0 Offset: 0x1DBD9A1 VA: 0x1DBD8A0
	|-Array.InternalArray__ICollection_Add<VertexAttributeDescriptor>
	|
	|-RVA: 0x1DBD910 Offset: 0x1DBDA11 VA: 0x1DBD910
	|-Array.InternalArray__ICollection_Add<AsyncOperationHandle>
	|
	|-RVA: 0x1DBD980 Offset: 0x1DBDA81 VA: 0x1DBD980
	|-Array.InternalArray__ICollection_Add<AsyncOperationHandle<object>>
	|
	|-RVA: 0x1DBD9F0 Offset: 0x1DBDAF1 VA: 0x1DBD9F0
	|-Array.InternalArray__ICollection_Add<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x1DBDA60 Offset: 0x1DBDB61 VA: 0x1DBDA60
	|-Array.InternalArray__ICollection_Add<DiagnosticEvent>
	|
	|-RVA: 0x1DBDAD0 Offset: 0x1DBDBD1 VA: 0x1DBDAD0
	|-Array.InternalArray__ICollection_Add<SceneInstance>
	|
	|-RVA: 0x1DBDB40 Offset: 0x1DBDC41 VA: 0x1DBDB40
	|-Array.InternalArray__ICollection_Add<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x1DBDBB0 Offset: 0x1DBDCB1 VA: 0x1DBDBB0
	|-Array.InternalArray__ICollection_Add<ObjectInitializationData>
	|
	|-RVA: 0x1DBDC20 Offset: 0x1DBDD21 VA: 0x1DBDC20
	|-Array.InternalArray__ICollection_Add<SerializedType>
	|
	|-RVA: 0x1DBDC90 Offset: 0x1DBDD91 VA: 0x1DBDC90
	|-Array.InternalArray__ICollection_Add<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x1DBDD00 Offset: 0x1DBDE01 VA: 0x1DBDD00
	|-Array.InternalArray__ICollection_Add<SkeletonBone>
	|
	|-RVA: 0x1DBDD70 Offset: 0x1DBDE71 VA: 0x1DBDD70
	|-Array.InternalArray__ICollection_Add<GlyphRect>
	|
	|-RVA: 0x1DBDDE0 Offset: 0x1DBDEE1 VA: 0x1DBDDE0
	|-Array.InternalArray__ICollection_Add<GlyphMarshallingStruct>
	|
	|-RVA: 0x1DBDE50 Offset: 0x1DBDF51 VA: 0x1DBDE50
	|-Array.InternalArray__ICollection_Add<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x1DBDEC0 Offset: 0x1DBDFC1 VA: 0x1DBDEC0
	|-Array.InternalArray__ICollection_Add<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x1DBDF30 Offset: 0x1DBE031 VA: 0x1DBDF30
	|-Array.InternalArray__ICollection_Add<IntervalTreeNode>
	|
	|-RVA: 0x1DBDFA0 Offset: 0x1DBE0A1 VA: 0x1DBDFA0
	|-Array.InternalArray__ICollection_Add<IntervalTree.Entry<object>>
	|
	|-RVA: 0x1DBE010 Offset: 0x1DBE111 VA: 0x1DBE010
	|-Array.InternalArray__ICollection_Add<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x1DBE080 Offset: 0x1DBE181 VA: 0x1DBE080
	|-Array.InternalArray__ICollection_Add<Touch>
	|
	|-RVA: 0x1DBE0F0 Offset: 0x1DBE1F1 VA: 0x1DBE0F0
	|-Array.InternalArray__ICollection_Add<TreeInstance>
	|
	|-RVA: 0x1DBE160 Offset: 0x1DBE261 VA: 0x1DBE160
	|-Array.InternalArray__ICollection_Add<ColorBlock>
	|
	|-RVA: 0x1DBE1D0 Offset: 0x1DBE2D1 VA: 0x1DBE1D0
	|-Array.InternalArray__ICollection_Add<Navigation>
	|
	|-RVA: 0x1DBE240 Offset: 0x1DBE341 VA: 0x1DBE240
	|-Array.InternalArray__ICollection_Add<SpriteState>
	|
	|-RVA: 0x1DBE2B0 Offset: 0x1DBE3B1 VA: 0x1DBE2B0
	|-Array.InternalArray__ICollection_Add<UICharInfo>
	|
	|-RVA: 0x1DBE320 Offset: 0x1DBE421 VA: 0x1DBE320
	|-Array.InternalArray__ICollection_Add<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x1DBE390 Offset: 0x1DBE491 VA: 0x1DBE390
	|-Array.InternalArray__ICollection_Add<EventDispatcher.EventRecord>
	|
	|-RVA: 0x1DBE400 Offset: 0x1DBE501 VA: 0x1DBE400
	|-Array.InternalArray__ICollection_Add<FocusController.FocusedElement>
	|
	|-RVA: 0x1DBE470 Offset: 0x1DBE571 VA: 0x1DBE470
	|-Array.InternalArray__ICollection_Add<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x1DBE4E0 Offset: 0x1DBE5E1 VA: 0x1DBE4E0
	|-Array.InternalArray__ICollection_Add<StyleValue>
	|
	|-RVA: 0x1DBE550 Offset: 0x1DBE651 VA: 0x1DBE550
	|-Array.InternalArray__ICollection_Add<UILineInfo>
	|
	|-RVA: 0x1DBE5C0 Offset: 0x1DBE6C1 VA: 0x1DBE5C0
	|-Array.InternalArray__ICollection_Add<UIVertex>
	|
	|-RVA: 0x1DBE630 Offset: 0x1DBE731 VA: 0x1DBE630
	|-Array.InternalArray__ICollection_Add<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x1DBE6A0 Offset: 0x1DBE7A1 VA: 0x1DBE6A0
	|-Array.InternalArray__ICollection_Add<Vector2>
	|
	|-RVA: 0x1DBE710 Offset: 0x1DBE811 VA: 0x1DBE710
	|-Array.InternalArray__ICollection_Add<Vector2Int>
	|
	|-RVA: 0x1DBE780 Offset: 0x1DBE881 VA: 0x1DBE780
	|-Array.InternalArray__ICollection_Add<Vector3>
	|
	|-RVA: 0x1DBE7F0 Offset: 0x1DBE8F1 VA: 0x1DBE7F0
	|-Array.InternalArray__ICollection_Add<Vector3Int>
	|
	|-RVA: 0x1DBE860 Offset: 0x1DBE961 VA: 0x1DBE860
	|-Array.InternalArray__ICollection_Add<Vector4>
	|
	|-RVA: 0x1DBE8D0 Offset: 0x1DBE9D1 VA: 0x1DBE8D0
	|-Array.InternalArray__ICollection_Add<jvalue>
	|
	|-RVA: 0x1DBE940 Offset: 0x1DBEA41 VA: 0x1DBE940
	|-Array.InternalArray__ICollection_Add<WarpPoints.WarpPoint>
	|
	|-RVA: 0x1DBE9B0 Offset: 0x1DBEAB1 VA: 0x1DBE9B0
	|-Array.InternalArray__ICollection_Add<YieldItemParam>
	|
	|-RVA: 0x1DBEA20 Offset: 0x1DBEB21 VA: 0x1DBEA20
	|-Array.InternalArray__ICollection_Add<NetworkServiceAccountId>
	|
	|-RVA: 0x1DBEA90 Offset: 0x1DBEB91 VA: 0x1DBEA90
	|-Array.InternalArray__ICollection_Add<Uid>
	|
	|-RVA: 0x1DBEB00 Offset: 0x1DBEC01 VA: 0x1DBEB00
	|-Array.InternalArray__ICollection_Add<ConsumableServiceItemId>
	|
	|-RVA: 0x1DBEB70 Offset: 0x1DBEC71 VA: 0x1DBEB70
	|-Array.InternalArray__ICollection_Add<NsUid>
	|
	|-RVA: 0x1DBEBE0 Offset: 0x1DBECE1 VA: 0x1DBEBE0
	|-Array.InternalArray__ICollection_Add<Friend>
	|
	|-RVA: 0x1DBEC50 Offset: 0x1DBED51 VA: 0x1DBEC50
	|-Array.InternalArray__ICollection_Add<Profile>
	|
	|-RVA: 0x1DBECC0 Offset: 0x1DBEDC1 VA: 0x1DBECC0
	|-Array.InternalArray__ICollection_Add<DirectoryEntry>
	|
	|-RVA: 0x1DBED30 Offset: 0x1DBEE31 VA: 0x1DBED30
	|-Array.InternalArray__ICollection_Add<DebugPadState>
	|
	|-RVA: 0x1DBEDA0 Offset: 0x1DBEEA1 VA: 0x1DBEDA0
	|-Array.InternalArray__ICollection_Add<GesturePoint>
	|
	|-RVA: 0x1DBEE10 Offset: 0x1DBEF11 VA: 0x1DBEE10
	|-Array.InternalArray__ICollection_Add<GestureState>
	|
	|-RVA: 0x1DBEE80 Offset: 0x1DBEF81 VA: 0x1DBEE80
	|-Array.InternalArray__ICollection_Add<NpadFullKeyState>
	|
	|-RVA: 0x1DBEEF0 Offset: 0x1DBEFF1 VA: 0x1DBEEF0
	|-Array.InternalArray__ICollection_Add<NpadHandheldState>
	|
	|-RVA: 0x1DBEF60 Offset: 0x1DBF061 VA: 0x1DBEF60
	|-Array.InternalArray__ICollection_Add<NpadJoyDualState>
	|
	|-RVA: 0x1DBEFD0 Offset: 0x1DBF0D1 VA: 0x1DBEFD0
	|-Array.InternalArray__ICollection_Add<NpadJoyLeftState>
	|
	|-RVA: 0x1DBF040 Offset: 0x1DBF141 VA: 0x1DBF040
	|-Array.InternalArray__ICollection_Add<NpadJoyRightState>
	|
	|-RVA: 0x1DBF0B0 Offset: 0x1DBF1B1 VA: 0x1DBF0B0
	|-Array.InternalArray__ICollection_Add<NpadStateArrayItem>
	|
	|-RVA: 0x1DBF120 Offset: 0x1DBF221 VA: 0x1DBF120
	|-Array.InternalArray__ICollection_Add<SixAxisSensorHandle>
	|
	|-RVA: 0x1DBF190 Offset: 0x1DBF291 VA: 0x1DBF190
	|-Array.InternalArray__ICollection_Add<SixAxisSensorState>
	|
	|-RVA: 0x1DBF200 Offset: 0x1DBF301 VA: 0x1DBF200
	|-Array.InternalArray__ICollection_Add<TouchScreenState10>
	|
	|-RVA: 0x1DBF270 Offset: 0x1DBF371 VA: 0x1DBF270
	|-Array.InternalArray__ICollection_Add<TouchScreenState11>
	|
	|-RVA: 0x1DBF2E0 Offset: 0x1DBF3E1 VA: 0x1DBF2E0
	|-Array.InternalArray__ICollection_Add<TouchScreenState12>
	|
	|-RVA: 0x1DBF350 Offset: 0x1DBF451 VA: 0x1DBF350
	|-Array.InternalArray__ICollection_Add<TouchScreenState13>
	|
	|-RVA: 0x1DBF3C0 Offset: 0x1DBF4C1 VA: 0x1DBF3C0
	|-Array.InternalArray__ICollection_Add<TouchScreenState14>
	|
	|-RVA: 0x1DBF430 Offset: 0x1DBF531 VA: 0x1DBF430
	|-Array.InternalArray__ICollection_Add<TouchScreenState15>
	|
	|-RVA: 0x1DBF4A0 Offset: 0x1DBF5A1 VA: 0x1DBF4A0
	|-Array.InternalArray__ICollection_Add<TouchScreenState16>
	|
	|-RVA: 0x1DBF510 Offset: 0x1DBF611 VA: 0x1DBF510
	|-Array.InternalArray__ICollection_Add<TouchScreenState1>
	|
	|-RVA: 0x1DBF580 Offset: 0x1DBF681 VA: 0x1DBF580
	|-Array.InternalArray__ICollection_Add<TouchScreenState2>
	|
	|-RVA: 0x1DBF5F0 Offset: 0x1DBF6F1 VA: 0x1DBF5F0
	|-Array.InternalArray__ICollection_Add<TouchScreenState3>
	|
	|-RVA: 0x1DBF660 Offset: 0x1DBF761 VA: 0x1DBF660
	|-Array.InternalArray__ICollection_Add<TouchScreenState4>
	|
	|-RVA: 0x1DBF6D0 Offset: 0x1DBF7D1 VA: 0x1DBF6D0
	|-Array.InternalArray__ICollection_Add<TouchScreenState5>
	|
	|-RVA: 0x1DBF740 Offset: 0x1DBF841 VA: 0x1DBF740
	|-Array.InternalArray__ICollection_Add<TouchScreenState6>
	|
	|-RVA: 0x1DBF7B0 Offset: 0x1DBF8B1 VA: 0x1DBF7B0
	|-Array.InternalArray__ICollection_Add<TouchScreenState7>
	|
	|-RVA: 0x1DBF820 Offset: 0x1DBF921 VA: 0x1DBF820
	|-Array.InternalArray__ICollection_Add<TouchScreenState8>
	|
	|-RVA: 0x1DBF890 Offset: 0x1DBF991 VA: 0x1DBF890
	|-Array.InternalArray__ICollection_Add<TouchScreenState9>
	|
	|-RVA: 0x1DBF900 Offset: 0x1DBFA01 VA: 0x1DBF900
	|-Array.InternalArray__ICollection_Add<TouchState>
	|
	|-RVA: 0x1DBF970 Offset: 0x1DBFA71 VA: 0x1DBF970
	|-Array.InternalArray__ICollection_Add<VibrationDeviceHandle>
	|
	|-RVA: 0x1DBF9E0 Offset: 0x1DBFAE1 VA: 0x1DBF9E0
	|-Array.InternalArray__ICollection_Add<VibrationDeviceInfo>
	|
	|-RVA: 0x1DBFA50 Offset: 0x1DBFB51 VA: 0x1DBFA50
	|-Array.InternalArray__ICollection_Add<VibrationValue>
	|
	|-RVA: 0x1DBFAC0 Offset: 0x1DBFBC1 VA: 0x1DBFAC0
	|-Array.InternalArray__ICollection_Add<ClusteringData>
	|
	|-RVA: 0x1DBFB30 Offset: 0x1DBFC31 VA: 0x1DBFB30
	|-Array.InternalArray__ICollection_Add<ClusteringProcessorState>
	|
	|-RVA: 0x1DBFBA0 Offset: 0x1DBFCA1 VA: 0x1DBFBA0
	|-Array.InternalArray__ICollection_Add<Finger>
	|
	|-RVA: 0x1DBFC10 Offset: 0x1DBFD11 VA: 0x1DBFC10
	|-Array.InternalArray__ICollection_Add<Hand>
	|
	|-RVA: 0x1DBFC80 Offset: 0x1DBFD81 VA: 0x1DBFC80
	|-Array.InternalArray__ICollection_Add<HandAnalysisImageState>
	|
	|-RVA: 0x1DBFCF0 Offset: 0x1DBFDF1 VA: 0x1DBFCF0
	|-Array.InternalArray__ICollection_Add<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x1DBFD60 Offset: 0x1DBFE61 VA: 0x1DBFD60
	|-Array.InternalArray__ICollection_Add<MomentProcessorState>
	|
	|-RVA: 0x1DBFDD0 Offset: 0x1DBFED1 VA: 0x1DBFDD0
	|-Array.InternalArray__ICollection_Add<MomentStatistic>
	|
	|-RVA: 0x1DBFE40 Offset: 0x1DBFF41 VA: 0x1DBFE40
	|-Array.InternalArray__ICollection_Add<Protrusion>
	|
	|-RVA: 0x1DBFEB0 Offset: 0x1DBFFB1 VA: 0x1DBFEB0
	|-Array.InternalArray__ICollection_Add<Shape>
	|
	|-RVA: 0x1DBFF20 Offset: 0x1DC0021 VA: 0x1DBFF20
	|-Array.InternalArray__ICollection_Add<DictionaryInfo>
	|
	|-RVA: 0x1DBFF90 Offset: 0x1DC0091 VA: 0x1DBFF90
	|-Array.InternalArray__ICollection_Add<UserWord>
	|
	|-RVA: 0x1DC0000 Offset: 0x1DC0101 VA: 0x1DC0000
	|-Array.InternalArray__ICollection_Add<Color4u8>
	|
	|-RVA: 0x1DC0070 Offset: 0x1DC0171 VA: 0x1DC0070
	|-Array.InternalArray__ICollection_Add<Float2>
	|
	|-RVA: 0x1DC00E0 Offset: 0x1DC01E1 VA: 0x1DC00E0
	|-Array.InternalArray__ICollection_Add<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	internal bool InternalArray__ICollection_Remove<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21F3180 Offset: 0x21F3281 VA: 0x21F3180
	|-Array.InternalArray__ICollection_Remove<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x21F31F0 Offset: 0x21F32F1 VA: 0x21F31F0
	|-Array.InternalArray__ICollection_Remove<ActionCommandDataTable>
	|
	|-RVA: 0x21F3260 Offset: 0x21F3361 VA: 0x21F3260
	|-Array.InternalArray__ICollection_Remove<AdvScriptDefCountParam>
	|
	|-RVA: 0x21F32D0 Offset: 0x21F33D1 VA: 0x21F32D0
	|-Array.InternalArray__ICollection_Remove<JSONDeserialization.TaskField>
	|
	|-RVA: 0x21F3340 Offset: 0x21F3441 VA: 0x21F3340
	|-Array.InternalArray__ICollection_Remove<BitVector32Int>
	|
	|-RVA: 0x21F33B0 Offset: 0x21F34B1 VA: 0x21F33B0
	|-Array.InternalArray__ICollection_Remove<BuildItemData>
	|
	|-RVA: 0x21F3420 Offset: 0x21F3521 VA: 0x21F3420
	|-Array.InternalArray__ICollection_Remove<ButtonLinker.LinkObject>
	|
	|-RVA: 0x21F3490 Offset: 0x21F3591 VA: 0x21F3490
	|-Array.InternalArray__ICollection_Remove<CharaCallTable.BustupTable>
	|
	|-RVA: 0x21F3500 Offset: 0x21F3601 VA: 0x21F3500
	|-Array.InternalArray__ICollection_Remove<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x21F3570 Offset: 0x21F3671 VA: 0x21F3570
	|-Array.InternalArray__ICollection_Remove<CameraState.CustomBlendable>
	|
	|-RVA: 0x21F35E0 Offset: 0x21F36E1 VA: 0x21F35E0
	|-Array.InternalArray__ICollection_Remove<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x21F3650 Offset: 0x21F3751 VA: 0x21F3650
	|-Array.InternalArray__ICollection_Remove<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x21F36C0 Offset: 0x21F37C1 VA: 0x21F36C0
	|-Array.InternalArray__ICollection_Remove<CinemachineClearShot.Pair>
	|
	|-RVA: 0x21F3730 Offset: 0x21F3831 VA: 0x21F3730
	|-Array.InternalArray__ICollection_Remove<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x21F37A0 Offset: 0x21F38A1 VA: 0x21F37A0
	|-Array.InternalArray__ICollection_Remove<CinemachinePath.Waypoint>
	|
	|-RVA: 0x21F3810 Offset: 0x21F3911 VA: 0x21F3810
	|-Array.InternalArray__ICollection_Remove<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x21F3880 Offset: 0x21F3981 VA: 0x21F3880
	|-Array.InternalArray__ICollection_Remove<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x21F38F0 Offset: 0x21F39F1 VA: 0x21F38F0
	|-Array.InternalArray__ICollection_Remove<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x21F3960 Offset: 0x21F3A61 VA: 0x21F3960
	|-Array.InternalArray__ICollection_Remove<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x21F39D0 Offset: 0x21F3AD1 VA: 0x21F39D0
	|-Array.InternalArray__ICollection_Remove<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x21F3A40 Offset: 0x21F3B41 VA: 0x21F3A40
	|-Array.InternalArray__ICollection_Remove<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x21F3AB0 Offset: 0x21F3BB1 VA: 0x21F3AB0
	|-Array.InternalArray__ICollection_Remove<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x21F3B20 Offset: 0x21F3C21 VA: 0x21F3B20
	|-Array.InternalArray__ICollection_Remove<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x21F3B90 Offset: 0x21F3C91 VA: 0x21F3B90
	|-Array.InternalArray__ICollection_Remove<HeadingTracker.Item>
	|
	|-RVA: 0x21F3C00 Offset: 0x21F3D01 VA: 0x21F3C00
	|-Array.InternalArray__ICollection_Remove<CropDataTable>
	|
	|-RVA: 0x21F3C70 Offset: 0x21F3D71 VA: 0x21F3C70
	|-Array.InternalArray__ICollection_Remove<ControlPoint>
	|
	|-RVA: 0x21F3CE0 Offset: 0x21F3DE1 VA: 0x21F3CE0
	|-Array.InternalArray__ICollection_Remove<DamageTextInfo>
	|
	|-RVA: 0x21F3D50 Offset: 0x21F3E51 VA: 0x21F3D50
	|-Array.InternalArray__ICollection_Remove<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x21F3DC0 Offset: 0x21F3EC1 VA: 0x21F3DC0
	|-Array.InternalArray__ICollection_Remove<DropItemParam>
	|
	|-RVA: 0x21F3E30 Offset: 0x21F3F31 VA: 0x21F3E30
	|-Array.InternalArray__ICollection_Remove<DropTableElement>
	|
	|-RVA: 0x21F3EA0 Offset: 0x21F3FA1 VA: 0x21F3EA0
	|-Array.InternalArray__ICollection_Remove<EffectDataTable>
	|
	|-RVA: 0x21F3F10 Offset: 0x21F4011 VA: 0x21F3F10
	|-Array.InternalArray__ICollection_Remove<EnemyPatrolPoints>
	|
	|-RVA: 0x21F3F80 Offset: 0x21F4081 VA: 0x21F3F80
	|-Array.InternalArray__ICollection_Remove<Coord>
	|
	|-RVA: 0x21F3FF0 Offset: 0x21F40F1 VA: 0x21F3FF0
	|-Array.InternalArray__ICollection_Remove<ErosionBrush.UndoStep>
	|
	|-RVA: 0x21F4060 Offset: 0x21F4161 VA: 0x21F4060
	|-Array.InternalArray__ICollection_Remove<EventCheckId>
	|
	|-RVA: 0x21F40D0 Offset: 0x21F41D1 VA: 0x21F40D0
	|-Array.InternalArray__ICollection_Remove<EventFlagProgressData>
	|
	|-RVA: 0x21F4140 Offset: 0x21F4241 VA: 0x21F4140
	|-Array.InternalArray__ICollection_Remove<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x21F41B0 Offset: 0x21F42B1 VA: 0x21F41B0
	|-Array.InternalArray__ICollection_Remove<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x21F4220 Offset: 0x21F4321 VA: 0x21F4220
	|-Array.InternalArray__ICollection_Remove<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x21F4290 Offset: 0x21F4391 VA: 0x21F4290
	|-Array.InternalArray__ICollection_Remove<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x21F4300 Offset: 0x21F4401 VA: 0x21F4300
	|-Array.InternalArray__ICollection_Remove<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x21F4370 Offset: 0x21F4471 VA: 0x21F4370
	|-Array.InternalArray__ICollection_Remove<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x21F43E0 Offset: 0x21F44E1 VA: 0x21F43E0
	|-Array.InternalArray__ICollection_Remove<FesNpcScoreData>
	|
	|-RVA: 0x21F4450 Offset: 0x21F4551 VA: 0x21F4450
	|-Array.InternalArray__ICollection_Remove<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x21F44C0 Offset: 0x21F45C1 VA: 0x21F44C0
	|-Array.InternalArray__ICollection_Remove<FieldItemSpawnDataTable>
	|
	|-RVA: 0x21F4530 Offset: 0x21F4631 VA: 0x21F4530
	|-Array.InternalArray__ICollection_Remove<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x21F45A0 Offset: 0x21F46A1 VA: 0x21F45A0
	|-Array.InternalArray__ICollection_Remove<FieldSceneData.Data>
	|
	|-RVA: 0x21F4610 Offset: 0x21F4711 VA: 0x21F4610
	|-Array.InternalArray__ICollection_Remove<FieldTreasureBoxItemData>
	|
	|-RVA: 0x21F4680 Offset: 0x21F4781 VA: 0x21F4680
	|-Array.InternalArray__ICollection_Remove<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x21F46F0 Offset: 0x21F47F1 VA: 0x21F46F0
	|-Array.InternalArray__ICollection_Remove<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x21F4760 Offset: 0x21F4861 VA: 0x21F4760
	|-Array.InternalArray__ICollection_Remove<FocusObjectDataTable>
	|
	|-RVA: 0x21F47D0 Offset: 0x21F48D1 VA: 0x21F47D0
	|-Array.InternalArray__ICollection_Remove<FurnitureData>
	|
	|-RVA: 0x21F4840 Offset: 0x21F4941 VA: 0x21F4840
	|-Array.InternalArray__ICollection_Remove<GateDataTable>
	|
	|-RVA: 0x21F48B0 Offset: 0x21F49B1 VA: 0x21F48B0
	|-Array.InternalArray__ICollection_Remove<GateStatusDataTable>
	|
	|-RVA: 0x21F4920 Offset: 0x21F4A21 VA: 0x21F4920
	|-Array.InternalArray__ICollection_Remove<GimmickLayoutDataTable>
	|
	|-RVA: 0x21F4990 Offset: 0x21F4A91 VA: 0x21F4990
	|-Array.InternalArray__ICollection_Remove<HitResult>
	|
	|-RVA: 0x21F4A00 Offset: 0x21F4B01 VA: 0x21F4A00
	|-Array.InternalArray__ICollection_Remove<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x21F4A70 Offset: 0x21F4B71 VA: 0x21F4A70
	|-Array.InternalArray__ICollection_Remove<FurnitureManager.SendPos>
	|
	|-RVA: 0x21F4AE0 Offset: 0x21F4BE1 VA: 0x21F4AE0
	|-Array.InternalArray__ICollection_Remove<ItemLevelData>
	|
	|-RVA: 0x21F4B50 Offset: 0x21F4C51 VA: 0x21F4B50
	|-Array.InternalArray__ICollection_Remove<MapDatas.MapData>
	|
	|-RVA: 0x21F4BC0 Offset: 0x21F4CC1 VA: 0x21F4BC0
	|-Array.InternalArray__ICollection_Remove<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x21F4C30 Offset: 0x21F4D31 VA: 0x21F4C30
	|-Array.InternalArray__ICollection_Remove<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x21F4CA0 Offset: 0x21F4DA1 VA: 0x21F4CA0
	|-Array.InternalArray__ICollection_Remove<MineTypeDataTable>
	|
	|-RVA: 0x21F4D10 Offset: 0x21F4E11 VA: 0x21F4D10
	|-Array.InternalArray__ICollection_Remove<MiningDataTable>
	|
	|-RVA: 0x21F4D80 Offset: 0x21F4E81 VA: 0x21F4D80
	|-Array.InternalArray__ICollection_Remove<MiningPointSaveData>
	|
	|-RVA: 0x21F4DF0 Offset: 0x21F4EF1 VA: 0x21F4DF0
	|-Array.InternalArray__ICollection_Remove<CodePointIndexer.TableRange>
	|
	|-RVA: 0x21F4E60 Offset: 0x21F4F61 VA: 0x21F4E60
	|-Array.InternalArray__ICollection_Remove<MonsterBehaviorDataTable>
	|
	|-RVA: 0x21F4ED0 Offset: 0x21F4FD1 VA: 0x21F4ED0
	|-Array.InternalArray__ICollection_Remove<MonsterDataTable>
	|
	|-RVA: 0x21F4F40 Offset: 0x21F5041 VA: 0x21F4F40
	|-Array.InternalArray__ICollection_Remove<MonsterDropItemDataTable>
	|
	|-RVA: 0x21F4FB0 Offset: 0x21F50B1 VA: 0x21F4FB0
	|-Array.InternalArray__ICollection_Remove<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x21F5020 Offset: 0x21F5121 VA: 0x21F5020
	|-Array.InternalArray__ICollection_Remove<MonsterHutSaveData>
	|
	|-RVA: 0x21F5090 Offset: 0x21F5191 VA: 0x21F5090
	|-Array.InternalArray__ICollection_Remove<MonsterUIData.Data>
	|
	|-RVA: 0x21F5100 Offset: 0x21F5201 VA: 0x21F5100
	|-Array.InternalArray__ICollection_Remove<MonsterYieldItemDataTable>
	|
	|-RVA: 0x21F5170 Offset: 0x21F5271 VA: 0x21F5170
	|-Array.InternalArray__ICollection_Remove<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x21F51E0 Offset: 0x21F52E1 VA: 0x21F51E0
	|-Array.InternalArray__ICollection_Remove<NPCActionData>
	|
	|-RVA: 0x21F5250 Offset: 0x21F5351 VA: 0x21F5250
	|-Array.InternalArray__ICollection_Remove<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x21F52C0 Offset: 0x21F53C1 VA: 0x21F52C0
	|-Array.InternalArray__ICollection_Remove<NPCUIData.Data>
	|
	|-RVA: 0x21F5330 Offset: 0x21F5431 VA: 0x21F5330
	|-Array.InternalArray__ICollection_Remove<NpcPlaceSchedule>
	|
	|-RVA: 0x21F53A0 Offset: 0x21F54A1 VA: 0x21F53A0
	|-Array.InternalArray__ICollection_Remove<OrderLotterySaveParameter>
	|
	|-RVA: 0x21F5410 Offset: 0x21F5511 VA: 0x21F5410
	|-Array.InternalArray__ICollection_Remove<OrderSaveData>
	|
	|-RVA: 0x21F5480 Offset: 0x21F5581 VA: 0x21F5480
	|-Array.InternalArray__ICollection_Remove<OrderSaveParameter>
	|
	|-RVA: 0x21F54F0 Offset: 0x21F55F1 VA: 0x21F54F0
	|-Array.InternalArray__ICollection_Remove<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x21F5560 Offset: 0x21F5661 VA: 0x21F5560
	|-Array.InternalArray__ICollection_Remove<Parameter>
	|
	|-RVA: 0x21F55D0 Offset: 0x21F56D1 VA: 0x21F55D0
	|-Array.InternalArray__ICollection_Remove<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x21F5640 Offset: 0x21F5741 VA: 0x21F5640
	|-Array.InternalArray__ICollection_Remove<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x21F56B0 Offset: 0x21F57B1 VA: 0x21F56B0
	|-Array.InternalArray__ICollection_Remove<ShopCatalogPage>
	|
	|-RVA: 0x21F5720 Offset: 0x21F5821 VA: 0x21F5720
	|-Array.InternalArray__ICollection_Remove<ShopNpcTalk>
	|
	|-RVA: 0x21F5790 Offset: 0x21F5891 VA: 0x21F5790
	|-Array.InternalArray__ICollection_Remove<SubtitleDataTable.Data>
	|
	|-RVA: 0x21F5800 Offset: 0x21F5901 VA: 0x21F5800
	|-Array.InternalArray__ICollection_Remove<SubtitleDataTable.DataList>
	|
	|-RVA: 0x21F5870 Offset: 0x21F5971 VA: 0x21F5870
	|-Array.InternalArray__ICollection_Remove<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x21F58E0 Offset: 0x21F59E1 VA: 0x21F58E0
	|-Array.InternalArray__ICollection_Remove<AnimationWarping.Warp>
	|
	|-RVA: 0x21F5950 Offset: 0x21F5A51 VA: 0x21F5950
	|-Array.InternalArray__ICollection_Remove<GrounderQuadruped.Foot>
	|
	|-RVA: 0x21F59C0 Offset: 0x21F5AC1 VA: 0x21F59C0
	|-Array.InternalArray__ICollection_Remove<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x21F5A30 Offset: 0x21F5B31 VA: 0x21F5A30
	|-Array.InternalArray__ICollection_Remove<ProfilerFrame>
	|
	|-RVA: 0x21F5AA0 Offset: 0x21F5BA1 VA: 0x21F5AA0
	|-Array.InternalArray__ICollection_Remove<NumberControl.ValueRange>
	|
	|-RVA: 0x21F5B10 Offset: 0x21F5C11 VA: 0x21F5B10
	|-Array.InternalArray__ICollection_Remove<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x21F5B80 Offset: 0x21F5C81 VA: 0x21F5B80
	|-Array.InternalArray__ICollection_Remove<ResponsiveEnable.Entry>
	|
	|-RVA: 0x21F5BF0 Offset: 0x21F5CF1 VA: 0x21F5BF0
	|-Array.InternalArray__ICollection_Remove<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x21F5C60 Offset: 0x21F5D61 VA: 0x21F5C60
	|-Array.InternalArray__ICollection_Remove<ResponsiveResize.Element>
	|
	|-RVA: 0x21F5CD0 Offset: 0x21F5DD1 VA: 0x21F5CD0
	|-Array.InternalArray__ICollection_Remove<Schedule>
	|
	|-RVA: 0x21F5D40 Offset: 0x21F5E41 VA: 0x21F5D40
	|-Array.InternalArray__ICollection_Remove<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x21F5DB0 Offset: 0x21F5EB1 VA: 0x21F5DB0
	|-Array.InternalArray__ICollection_Remove<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x21F5E20 Offset: 0x21F5F21 VA: 0x21F5E20
	|-Array.InternalArray__ICollection_Remove<SpeedData>
	|
	|-RVA: 0x21F5E90 Offset: 0x21F5F91 VA: 0x21F5E90
	|-Array.InternalArray__ICollection_Remove<CurveSample>
	|
	|-RVA: 0x21F5F00 Offset: 0x21F6001 VA: 0x21F5F00
	|-Array.InternalArray__ICollection_Remove<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x21F5F70 Offset: 0x21F6071 VA: 0x21F5F70
	|-Array.InternalArray__ICollection_Remove<StringFormatData.FormatData>
	|
	|-RVA: 0x21F5FE0 Offset: 0x21F60E1 VA: 0x21F5FE0
	|-Array.InternalArray__ICollection_Remove<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x21F6050 Offset: 0x21F6151 VA: 0x21F6050
	|-Array.InternalArray__ICollection_Remove<ArraySegment<byte>>
	|
	|-RVA: 0x21F60C0 Offset: 0x21F61C1 VA: 0x21F60C0
	|-Array.InternalArray__ICollection_Remove<ArraySegment<object>>
	|
	|-RVA: 0x21F6130 Offset: 0x21F6231 VA: 0x21F6130
	|-Array.InternalArray__ICollection_Remove<bool>
	|
	|-RVA: 0x21F61A0 Offset: 0x21F62A1 VA: 0x21F61A0
	|-Array.InternalArray__ICollection_Remove<byte>
	|
	|-RVA: 0x21F6210 Offset: 0x21F6311 VA: 0x21F6210
	|-Array.InternalArray__ICollection_Remove<ByteEnum>
	|
	|-RVA: 0x21F6280 Offset: 0x21F6381 VA: 0x21F6280
	|-Array.InternalArray__ICollection_Remove<char>
	|
	|-RVA: 0x21F62F0 Offset: 0x21F63F1 VA: 0x21F62F0
	|-Array.InternalArray__ICollection_Remove<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x21F6360 Offset: 0x21F6461 VA: 0x21F6360
	|-Array.InternalArray__ICollection_Remove<DictionaryEntry>
	|
	|-RVA: 0x21F63D0 Offset: 0x21F64D1 VA: 0x21F63D0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x21F6440 Offset: 0x21F6541 VA: 0x21F6440
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x21F64B0 Offset: 0x21F65B1 VA: 0x21F64B0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x21F6520 Offset: 0x21F6621 VA: 0x21F6520
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x21F6590 Offset: 0x21F6691 VA: 0x21F6590
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x21F6600 Offset: 0x21F6701 VA: 0x21F6600
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x21F6670 Offset: 0x21F6771 VA: 0x21F6670
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x21F66E0 Offset: 0x21F67E1 VA: 0x21F66E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x21F6750 Offset: 0x21F6851 VA: 0x21F6750
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x21F67C0 Offset: 0x21F68C1 VA: 0x21F67C0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x21F6830 Offset: 0x21F6931 VA: 0x21F6830
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x21F68A0 Offset: 0x21F69A1 VA: 0x21F68A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x21F6910 Offset: 0x21F6A11 VA: 0x21F6910
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x21F6980 Offset: 0x21F6A81 VA: 0x21F6980
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x21F69F0 Offset: 0x21F6AF1 VA: 0x21F69F0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x21F6A60 Offset: 0x21F6B61 VA: 0x21F6A60
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x21F6AD0 Offset: 0x21F6BD1 VA: 0x21F6AD0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x21F6B40 Offset: 0x21F6C41 VA: 0x21F6B40
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x21F6BB0 Offset: 0x21F6CB1 VA: 0x21F6BB0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x21F6C20 Offset: 0x21F6D21 VA: 0x21F6C20
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x21F6C90 Offset: 0x21F6D91 VA: 0x21F6C90
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x21F6D00 Offset: 0x21F6E01 VA: 0x21F6D00
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x21F6D70 Offset: 0x21F6E71 VA: 0x21F6D70
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x21F6DE0 Offset: 0x21F6EE1 VA: 0x21F6DE0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x21F6E50 Offset: 0x21F6F51 VA: 0x21F6E50
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x21F6EC0 Offset: 0x21F6FC1 VA: 0x21F6EC0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x21F6F30 Offset: 0x21F7031 VA: 0x21F6F30
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x21F6FA0 Offset: 0x21F70A1 VA: 0x21F6FA0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x21F7010 Offset: 0x21F7111 VA: 0x21F7010
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x21F7080 Offset: 0x21F7181 VA: 0x21F7080
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x21F70F0 Offset: 0x21F71F1 VA: 0x21F70F0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x21F7160 Offset: 0x21F7261 VA: 0x21F7160
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x21F71D0 Offset: 0x21F72D1 VA: 0x21F71D0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x21F7240 Offset: 0x21F7341 VA: 0x21F7240
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x21F72B0 Offset: 0x21F73B1 VA: 0x21F72B0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x21F7320 Offset: 0x21F7421 VA: 0x21F7320
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x21F7390 Offset: 0x21F7491 VA: 0x21F7390
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x21F7400 Offset: 0x21F7501 VA: 0x21F7400
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x21F7470 Offset: 0x21F7571 VA: 0x21F7470
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x21F74E0 Offset: 0x21F75E1 VA: 0x21F74E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x21F7550 Offset: 0x21F7651 VA: 0x21F7550
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x21F75C0 Offset: 0x21F76C1 VA: 0x21F75C0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x21F7630 Offset: 0x21F7731 VA: 0x21F7630
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x21F76A0 Offset: 0x21F77A1 VA: 0x21F76A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x21F7710 Offset: 0x21F7811 VA: 0x21F7710
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x21F7780 Offset: 0x21F7881 VA: 0x21F7780
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x21F77F0 Offset: 0x21F78F1 VA: 0x21F77F0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x21F7860 Offset: 0x21F7961 VA: 0x21F7860
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x21F78D0 Offset: 0x21F79D1 VA: 0x21F78D0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x21F7940 Offset: 0x21F7A41 VA: 0x21F7940
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x21F79B0 Offset: 0x21F7AB1 VA: 0x21F79B0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x21F7A20 Offset: 0x21F7B21 VA: 0x21F7A20
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x21F7A90 Offset: 0x21F7B91 VA: 0x21F7A90
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x21F7B00 Offset: 0x21F7C01 VA: 0x21F7B00
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x21F7B70 Offset: 0x21F7C71 VA: 0x21F7B70
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x21F7BE0 Offset: 0x21F7CE1 VA: 0x21F7BE0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x21F7C50 Offset: 0x21F7D51 VA: 0x21F7C50
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x21F7CC0 Offset: 0x21F7DC1 VA: 0x21F7CC0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x21F7D30 Offset: 0x21F7E31 VA: 0x21F7D30
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x21F7DA0 Offset: 0x21F7EA1 VA: 0x21F7DA0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x21F7E10 Offset: 0x21F7F11 VA: 0x21F7E10
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x21F7E80 Offset: 0x21F7F81 VA: 0x21F7E80
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x21F7EF0 Offset: 0x21F7FF1 VA: 0x21F7EF0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x21F7F60 Offset: 0x21F8061 VA: 0x21F7F60
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x21F7FD0 Offset: 0x21F80D1 VA: 0x21F7FD0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x21F8040 Offset: 0x21F8141 VA: 0x21F8040
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x21F80B0 Offset: 0x21F81B1 VA: 0x21F80B0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x21F8120 Offset: 0x21F8221 VA: 0x21F8120
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x21F8190 Offset: 0x21F8291 VA: 0x21F8190
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x21F8200 Offset: 0x21F8301 VA: 0x21F8200
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x21F8270 Offset: 0x21F8371 VA: 0x21F8270
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x21F82E0 Offset: 0x21F83E1 VA: 0x21F82E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x21F8350 Offset: 0x21F8451 VA: 0x21F8350
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x21F83C0 Offset: 0x21F84C1 VA: 0x21F83C0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x21F8430 Offset: 0x21F8531 VA: 0x21F8430
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x21F84A0 Offset: 0x21F85A1 VA: 0x21F84A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x21F8510 Offset: 0x21F8611 VA: 0x21F8510
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x21F8580 Offset: 0x21F8681 VA: 0x21F8580
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x21F85F0 Offset: 0x21F86F1 VA: 0x21F85F0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x21F8660 Offset: 0x21F8761 VA: 0x21F8660
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x21F86D0 Offset: 0x21F87D1 VA: 0x21F86D0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x21F8740 Offset: 0x21F8841 VA: 0x21F8740
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x21F87B0 Offset: 0x21F88B1 VA: 0x21F87B0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x21F8820 Offset: 0x21F8921 VA: 0x21F8820
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x21F8890 Offset: 0x21F8991 VA: 0x21F8890
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x21F8900 Offset: 0x21F8A01 VA: 0x21F8900
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x21F8970 Offset: 0x21F8A71 VA: 0x21F8970
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x21F89E0 Offset: 0x21F8AE1 VA: 0x21F89E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x21F8A50 Offset: 0x21F8B51 VA: 0x21F8A50
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x21F8AC0 Offset: 0x21F8BC1 VA: 0x21F8AC0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x21F8B30 Offset: 0x21F8C31 VA: 0x21F8B30
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x21F8BA0 Offset: 0x21F8CA1 VA: 0x21F8BA0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x21F8C10 Offset: 0x21F8D11 VA: 0x21F8C10
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x21F8C80 Offset: 0x21F8D81 VA: 0x21F8C80
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x21F8CF0 Offset: 0x21F8DF1 VA: 0x21F8CF0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x21F8D60 Offset: 0x21F8E61 VA: 0x21F8D60
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x21F8DD0 Offset: 0x21F8ED1 VA: 0x21F8DD0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x21F8E40 Offset: 0x21F8F41 VA: 0x21F8E40
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x21F8EB0 Offset: 0x21F8FB1 VA: 0x21F8EB0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x21F8F20 Offset: 0x21F9021 VA: 0x21F8F20
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x21F8F90 Offset: 0x21F9091 VA: 0x21F8F90
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x21F9000 Offset: 0x21F9101 VA: 0x21F9000
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x21F9070 Offset: 0x21F9171 VA: 0x21F9070
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x21F90E0 Offset: 0x21F91E1 VA: 0x21F90E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x21F9150 Offset: 0x21F9251 VA: 0x21F9150
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x21F91C0 Offset: 0x21F92C1 VA: 0x21F91C0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x21F9230 Offset: 0x21F9331 VA: 0x21F9230
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x21F92A0 Offset: 0x21F93A1 VA: 0x21F92A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x21F9310 Offset: 0x21F9411 VA: 0x21F9310
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x21F9380 Offset: 0x21F9481 VA: 0x21F9380
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x21F93F0 Offset: 0x21F94F1 VA: 0x21F93F0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x21F9460 Offset: 0x21F9561 VA: 0x21F9460
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x21F94D0 Offset: 0x21F95D1 VA: 0x21F94D0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x21F9540 Offset: 0x21F9641 VA: 0x21F9540
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x21F95B0 Offset: 0x21F96B1 VA: 0x21F95B0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x21F9620 Offset: 0x21F9721 VA: 0x21F9620
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x21F9690 Offset: 0x21F9791 VA: 0x21F9690
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x21F9700 Offset: 0x21F9801 VA: 0x21F9700
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x21F9770 Offset: 0x21F9871 VA: 0x21F9770
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x21F97E0 Offset: 0x21F98E1 VA: 0x21F97E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x21F9850 Offset: 0x21F9951 VA: 0x21F9850
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x21F98C0 Offset: 0x21F99C1 VA: 0x21F98C0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x21F9930 Offset: 0x21F9A31 VA: 0x21F9930
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x21F99A0 Offset: 0x21F9AA1 VA: 0x21F99A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x21F9A10 Offset: 0x21F9B11 VA: 0x21F9A10
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x21F9A80 Offset: 0x21F9B81 VA: 0x21F9A80
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x21F9AF0 Offset: 0x21F9BF1 VA: 0x21F9AF0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x21F9B60 Offset: 0x21F9C61 VA: 0x21F9B60
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x21F9BD0 Offset: 0x21F9CD1 VA: 0x21F9BD0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x21F9C40 Offset: 0x21F9D41 VA: 0x21F9C40
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x21F9CB0 Offset: 0x21F9DB1 VA: 0x21F9CB0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x21F9D20 Offset: 0x21F9E21 VA: 0x21F9D20
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x21F9D90 Offset: 0x21F9E91 VA: 0x21F9D90
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x21F9E00 Offset: 0x21F9F01 VA: 0x21F9E00
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x21F9E70 Offset: 0x21F9F71 VA: 0x21F9E70
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x21F9EE0 Offset: 0x21F9FE1 VA: 0x21F9EE0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x21F9F50 Offset: 0x21FA051 VA: 0x21F9F50
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x21F9FC0 Offset: 0x21FA0C1 VA: 0x21F9FC0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x21FA030 Offset: 0x21FA131 VA: 0x21FA030
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x21FA0A0 Offset: 0x21FA1A1 VA: 0x21FA0A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x21FA110 Offset: 0x21FA211 VA: 0x21FA110
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x21FA180 Offset: 0x21FA281 VA: 0x21FA180
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x21FA1F0 Offset: 0x21FA2F1 VA: 0x21FA1F0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x21FA260 Offset: 0x21FA361 VA: 0x21FA260
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x21FA2D0 Offset: 0x21FA3D1 VA: 0x21FA2D0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x21FA340 Offset: 0x21FA441 VA: 0x21FA340
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x21FA3B0 Offset: 0x21FA4B1 VA: 0x21FA3B0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x21FA420 Offset: 0x21FA521 VA: 0x21FA420
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x21FA490 Offset: 0x21FA591 VA: 0x21FA490
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x21FA500 Offset: 0x21FA601 VA: 0x21FA500
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x21FA570 Offset: 0x21FA671 VA: 0x21FA570
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x21FA5E0 Offset: 0x21FA6E1 VA: 0x21FA5E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x21FA650 Offset: 0x21FA751 VA: 0x21FA650
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x21FA6C0 Offset: 0x21FA7C1 VA: 0x21FA6C0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x21FA730 Offset: 0x21FA831 VA: 0x21FA730
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x21FA7A0 Offset: 0x21FA8A1 VA: 0x21FA7A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x21FA810 Offset: 0x21FA911 VA: 0x21FA810
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x21FA880 Offset: 0x21FA981 VA: 0x21FA880
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x21FA8F0 Offset: 0x21FA9F1 VA: 0x21FA8F0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x21FA960 Offset: 0x21FAA61 VA: 0x21FA960
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x21FA9D0 Offset: 0x21FAAD1 VA: 0x21FA9D0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x21FAA40 Offset: 0x21FAB41 VA: 0x21FAA40
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x21FAAB0 Offset: 0x21FABB1 VA: 0x21FAAB0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x21FAB20 Offset: 0x21FAC21 VA: 0x21FAB20
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x21FAB90 Offset: 0x21FAC91 VA: 0x21FAB90
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x21FAC00 Offset: 0x21FAD01 VA: 0x21FAC00
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x21FAC70 Offset: 0x21FAD71 VA: 0x21FAC70
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x21FACE0 Offset: 0x21FADE1 VA: 0x21FACE0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x21FAD50 Offset: 0x21FAE51 VA: 0x21FAD50
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x21FADC0 Offset: 0x21FAEC1 VA: 0x21FADC0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x21FAE30 Offset: 0x21FAF31 VA: 0x21FAE30
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x21FAEA0 Offset: 0x21FAFA1 VA: 0x21FAEA0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x21FAF10 Offset: 0x21FB011 VA: 0x21FAF10
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x21FAF80 Offset: 0x21FB081 VA: 0x21FAF80
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x21FAFF0 Offset: 0x21FB0F1 VA: 0x21FAFF0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x21FB060 Offset: 0x21FB161 VA: 0x21FB060
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x21FB0D0 Offset: 0x21FB1D1 VA: 0x21FB0D0
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<int>>
	|
	|-RVA: 0x21FB140 Offset: 0x21FB241 VA: 0x21FB140
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x21FB1B0 Offset: 0x21FB2B1 VA: 0x21FB1B0
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<object>>
	|
	|-RVA: 0x21FB220 Offset: 0x21FB321 VA: 0x21FB220
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<uint>>
	|
	|-RVA: 0x21FB290 Offset: 0x21FB391 VA: 0x21FB290
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<Edge>>
	|
	|-RVA: 0x21FB300 Offset: 0x21FB401 VA: 0x21FB300
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x21FB370 Offset: 0x21FB471 VA: 0x21FB370
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x21FB3E0 Offset: 0x21FB4E1 VA: 0x21FB3E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x21FB450 Offset: 0x21FB551 VA: 0x21FB450
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x21FB4C0 Offset: 0x21FB5C1 VA: 0x21FB4C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x21FB530 Offset: 0x21FB631 VA: 0x21FB530
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x21FB5A0 Offset: 0x21FB6A1 VA: 0x21FB5A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x21FB610 Offset: 0x21FB711 VA: 0x21FB610
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x21FB680 Offset: 0x21FB781 VA: 0x21FB680
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x21FB6F0 Offset: 0x21FB7F1 VA: 0x21FB6F0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x21FB760 Offset: 0x21FB861 VA: 0x21FB760
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x21FB7D0 Offset: 0x21FB8D1 VA: 0x21FB7D0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x21FB840 Offset: 0x21FB941 VA: 0x21FB840
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x21FB8B0 Offset: 0x21FB9B1 VA: 0x21FB8B0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<bool, object>>
	|
	|-RVA: 0x21FB920 Offset: 0x21FBA21 VA: 0x21FB920
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<byte, object>>
	|
	|-RVA: 0x21FB990 Offset: 0x21FBA91 VA: 0x21FB990
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<char, object>>
	|
	|-RVA: 0x21FBA00 Offset: 0x21FBB01 VA: 0x21FBA00
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x21FBA70 Offset: 0x21FBB71 VA: 0x21FBA70
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<double, object>>
	|
	|-RVA: 0x21FBAE0 Offset: 0x21FBBE1 VA: 0x21FBAE0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x21FBB50 Offset: 0x21FBC51 VA: 0x21FBB50
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<short, object>>
	|
	|-RVA: 0x21FBBC0 Offset: 0x21FBCC1 VA: 0x21FBBC0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x21FBC30 Offset: 0x21FBD31 VA: 0x21FBC30
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x21FBCA0 Offset: 0x21FBDA1 VA: 0x21FBCA0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x21FBD10 Offset: 0x21FBE11 VA: 0x21FBD10
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x21FBD80 Offset: 0x21FBE81 VA: 0x21FBD80
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x21FBDF0 Offset: 0x21FBEF1 VA: 0x21FBDF0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, bool>>
	|
	|-RVA: 0x21FBE60 Offset: 0x21FBF61 VA: 0x21FBE60
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, char>>
	|
	|-RVA: 0x21FBED0 Offset: 0x21FBFD1 VA: 0x21FBED0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, int>>
	|
	|-RVA: 0x21FBF40 Offset: 0x21FC041 VA: 0x21FBF40
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x21FBFB0 Offset: 0x21FC0B1 VA: 0x21FBFB0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, long>>
	|
	|-RVA: 0x21FC020 Offset: 0x21FC121 VA: 0x21FC020
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, object>>
	|
	|-RVA: 0x21FC090 Offset: 0x21FC191 VA: 0x21FC090
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x21FC100 Offset: 0x21FC201 VA: 0x21FC100
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x21FC170 Offset: 0x21FC271 VA: 0x21FC170
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x21FC1E0 Offset: 0x21FC2E1 VA: 0x21FC1E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x21FC250 Offset: 0x21FC351 VA: 0x21FC250
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x21FC2C0 Offset: 0x21FC3C1 VA: 0x21FC2C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x21FC330 Offset: 0x21FC431 VA: 0x21FC330
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x21FC3A0 Offset: 0x21FC4A1 VA: 0x21FC3A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x21FC410 Offset: 0x21FC511 VA: 0x21FC410
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x21FC480 Offset: 0x21FC581 VA: 0x21FC480
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x21FC4F0 Offset: 0x21FC5F1 VA: 0x21FC4F0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x21FC560 Offset: 0x21FC661 VA: 0x21FC560
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x21FC5D0 Offset: 0x21FC6D1 VA: 0x21FC5D0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x21FC640 Offset: 0x21FC741 VA: 0x21FC640
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x21FC6B0 Offset: 0x21FC7B1 VA: 0x21FC6B0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x21FC720 Offset: 0x21FC821 VA: 0x21FC720
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x21FC790 Offset: 0x21FC891 VA: 0x21FC790
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<long, object>>
	|
	|-RVA: 0x21FC800 Offset: 0x21FC901 VA: 0x21FC800
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x21FC870 Offset: 0x21FC971 VA: 0x21FC870
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x21FC8E0 Offset: 0x21FC9E1 VA: 0x21FC8E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x21FC950 Offset: 0x21FCA51 VA: 0x21FC950
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x21FC9C0 Offset: 0x21FCAC1 VA: 0x21FC9C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x21FCA30 Offset: 0x21FCB31 VA: 0x21FCA30
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x21FCAA0 Offset: 0x21FCBA1 VA: 0x21FCAA0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x21FCB10 Offset: 0x21FCC11 VA: 0x21FCB10
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x21FCB80 Offset: 0x21FCC81 VA: 0x21FCB80
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x21FCBF0 Offset: 0x21FCCF1 VA: 0x21FCBF0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x21FCC60 Offset: 0x21FCD61 VA: 0x21FCC60
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x21FCCD0 Offset: 0x21FCDD1 VA: 0x21FCCD0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x21FCD40 Offset: 0x21FCE41 VA: 0x21FCD40
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x21FCDB0 Offset: 0x21FCEB1 VA: 0x21FCDB0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x21FCE20 Offset: 0x21FCF21 VA: 0x21FCE20
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x21FCE90 Offset: 0x21FCF91 VA: 0x21FCE90
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x21FCF00 Offset: 0x21FD001 VA: 0x21FCF00
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x21FCF70 Offset: 0x21FD071 VA: 0x21FCF70
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x21FCFE0 Offset: 0x21FD0E1 VA: 0x21FCFE0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x21FD050 Offset: 0x21FD151 VA: 0x21FD050
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x21FD0C0 Offset: 0x21FD1C1 VA: 0x21FD0C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x21FD130 Offset: 0x21FD231 VA: 0x21FD130
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x21FD1A0 Offset: 0x21FD2A1 VA: 0x21FD1A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x21FD210 Offset: 0x21FD311 VA: 0x21FD210
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x21FD280 Offset: 0x21FD381 VA: 0x21FD280
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x21FD2F0 Offset: 0x21FD3F1 VA: 0x21FD2F0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x21FD360 Offset: 0x21FD461 VA: 0x21FD360
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x21FD3D0 Offset: 0x21FD4D1 VA: 0x21FD3D0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x21FD440 Offset: 0x21FD541 VA: 0x21FD440
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x21FD4B0 Offset: 0x21FD5B1 VA: 0x21FD4B0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x21FD520 Offset: 0x21FD621 VA: 0x21FD520
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x21FD590 Offset: 0x21FD691 VA: 0x21FD590
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x21FD600 Offset: 0x21FD701 VA: 0x21FD600
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, bool>>
	|
	|-RVA: 0x21FD670 Offset: 0x21FD771 VA: 0x21FD670
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, byte>>
	|
	|-RVA: 0x21FD6E0 Offset: 0x21FD7E1 VA: 0x21FD6E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, char>>
	|
	|-RVA: 0x21FD750 Offset: 0x21FD851 VA: 0x21FD750
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x21FD7C0 Offset: 0x21FD8C1 VA: 0x21FD7C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, double>>
	|
	|-RVA: 0x21FD830 Offset: 0x21FD931 VA: 0x21FD830
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, short>>
	|
	|-RVA: 0x21FD8A0 Offset: 0x21FD9A1 VA: 0x21FD8A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, int>>
	|
	|-RVA: 0x21FD910 Offset: 0x21FDA11 VA: 0x21FD910
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x21FD980 Offset: 0x21FDA81 VA: 0x21FD980
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, long>>
	|
	|-RVA: 0x21FD9F0 Offset: 0x21FDAF1 VA: 0x21FD9F0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x21FDA60 Offset: 0x21FDB61 VA: 0x21FDA60
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x21FDAD0 Offset: 0x21FDBD1 VA: 0x21FDAD0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x22BF640 Offset: 0x22BF741 VA: 0x22BF640
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x22BF6B0 Offset: 0x22BF7B1 VA: 0x22BF6B0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x22BF720 Offset: 0x22BF821 VA: 0x22BF720
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x22BF790 Offset: 0x22BF891 VA: 0x22BF790
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x22BF800 Offset: 0x22BF901 VA: 0x22BF800
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x22BF870 Offset: 0x22BF971 VA: 0x22BF870
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x22BF8E0 Offset: 0x22BF9E1 VA: 0x22BF8E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x22BF950 Offset: 0x22BFA51 VA: 0x22BF950
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x22BF9C0 Offset: 0x22BFAC1 VA: 0x22BF9C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x22BFA30 Offset: 0x22BFB31 VA: 0x22BFA30
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x22BFAA0 Offset: 0x22BFBA1 VA: 0x22BFAA0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x22BFB10 Offset: 0x22BFC11 VA: 0x22BFB10
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x22BFB80 Offset: 0x22BFC81 VA: 0x22BFB80
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x22BFBF0 Offset: 0x22BFCF1 VA: 0x22BFBF0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x22BFC60 Offset: 0x22BFD61 VA: 0x22BFC60
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x22BFCD0 Offset: 0x22BFDD1 VA: 0x22BFCD0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x22BFD40 Offset: 0x22BFE41 VA: 0x22BFD40
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x22BFDB0 Offset: 0x22BFEB1 VA: 0x22BFDB0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, object>>
	|
	|-RVA: 0x22BFE20 Offset: 0x22BFF21 VA: 0x22BFE20
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x22BFE90 Offset: 0x22BFF91 VA: 0x22BFE90
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x22BFF00 Offset: 0x22C0001 VA: 0x22BFF00
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x22BFF70 Offset: 0x22C0071 VA: 0x22BFF70
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, float>>
	|
	|-RVA: 0x22BFFE0 Offset: 0x22C00E1 VA: 0x22BFFE0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x22C0050 Offset: 0x22C0151 VA: 0x22C0050
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, uint>>
	|
	|-RVA: 0x22C00C0 Offset: 0x22C01C1 VA: 0x22C00C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x22C0130 Offset: 0x22C0231 VA: 0x22C0130
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x22C01A0 Offset: 0x22C02A1 VA: 0x22C01A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x22C0210 Offset: 0x22C0311 VA: 0x22C0210
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x22C0280 Offset: 0x22C0381 VA: 0x22C0280
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x22C02F0 Offset: 0x22C03F1 VA: 0x22C02F0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Color>>
	|
	|-RVA: 0x22C0360 Offset: 0x22C0461 VA: 0x22C0360
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x22C03D0 Offset: 0x22C04D1 VA: 0x22C03D0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x22C0440 Offset: 0x22C0541 VA: 0x22C0440
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x22C04B0 Offset: 0x22C05B1 VA: 0x22C04B0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x22C0520 Offset: 0x22C0621 VA: 0x22C0520
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x22C0590 Offset: 0x22C0691 VA: 0x22C0590
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x22C0600 Offset: 0x22C0701 VA: 0x22C0600
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x22C0670 Offset: 0x22C0771 VA: 0x22C0670
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x22C06E0 Offset: 0x22C07E1 VA: 0x22C06E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x22C0750 Offset: 0x22C0851 VA: 0x22C0750
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x22C07C0 Offset: 0x22C08C1 VA: 0x22C07C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x22C0830 Offset: 0x22C0931 VA: 0x22C0830
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x22C08A0 Offset: 0x22C09A1 VA: 0x22C08A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x22C0910 Offset: 0x22C0A11 VA: 0x22C0910
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x22C0980 Offset: 0x22C0A81 VA: 0x22C0980
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x22C09F0 Offset: 0x22C0AF1 VA: 0x22C09F0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x22C0A60 Offset: 0x22C0B61 VA: 0x22C0A60
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x22C0AD0 Offset: 0x22C0BD1 VA: 0x22C0AD0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x22C0B40 Offset: 0x22C0C41 VA: 0x22C0B40
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x22C0BB0 Offset: 0x22C0CB1 VA: 0x22C0BB0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x22C0C20 Offset: 0x22C0D21 VA: 0x22C0C20
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x22C0C90 Offset: 0x22C0D91 VA: 0x22C0C90
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<float, object>>
	|
	|-RVA: 0x22C0D00 Offset: 0x22C0E01 VA: 0x22C0D00
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x22C0D70 Offset: 0x22C0E71 VA: 0x22C0D70
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, int>>
	|
	|-RVA: 0x22C0DE0 Offset: 0x22C0EE1 VA: 0x22C0DE0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x22C0E50 Offset: 0x22C0F51 VA: 0x22C0E50
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, object>>
	|
	|-RVA: 0x22C0EC0 Offset: 0x22C0FC1 VA: 0x22C0EC0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x22C0F30 Offset: 0x22C1031 VA: 0x22C0F30
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x22C0FA0 Offset: 0x22C10A1 VA: 0x22C0FA0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x22C1010 Offset: 0x22C1111 VA: 0x22C1010
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x22C1080 Offset: 0x22C1181 VA: 0x22C1080
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x22C10F0 Offset: 0x22C11F1 VA: 0x22C10F0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x22C1160 Offset: 0x22C1261 VA: 0x22C1160
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x22C11D0 Offset: 0x22C12D1 VA: 0x22C11D0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x22C1240 Offset: 0x22C1341 VA: 0x22C1240
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x22C12B0 Offset: 0x22C13B1 VA: 0x22C12B0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Color, object>>
	|
	|-RVA: 0x22C1320 Offset: 0x22C1421 VA: 0x22C1320
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x22C1390 Offset: 0x22C1491 VA: 0x22C1390
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x22C1400 Offset: 0x22C1501 VA: 0x22C1400
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x22C1470 Offset: 0x22C1571 VA: 0x22C1470
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x22C14E0 Offset: 0x22C15E1 VA: 0x22C14E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x22C1550 Offset: 0x22C1651 VA: 0x22C1550
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x22C15C0 Offset: 0x22C16C1 VA: 0x22C15C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x22C1630 Offset: 0x22C1731 VA: 0x22C1630
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x22C16A0 Offset: 0x22C17A1 VA: 0x22C16A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x22C1710 Offset: 0x22C1811 VA: 0x22C1710
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x22C1780 Offset: 0x22C1881 VA: 0x22C1780
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x22C17F0 Offset: 0x22C18F1 VA: 0x22C17F0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x22C1860 Offset: 0x22C1961 VA: 0x22C1860
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x22C18D0 Offset: 0x22C19D1 VA: 0x22C18D0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x22C1940 Offset: 0x22C1A41 VA: 0x22C1940
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x22C19B0 Offset: 0x22C1AB1 VA: 0x22C19B0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x22C1A20 Offset: 0x22C1B21 VA: 0x22C1A20
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x22C1A90 Offset: 0x22C1B91 VA: 0x22C1A90
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x22C1B00 Offset: 0x22C1C01 VA: 0x22C1B00
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x22C1B70 Offset: 0x22C1C71 VA: 0x22C1B70
	|-Array.InternalArray__ICollection_Remove<Hashtable.bucket>
	|
	|-RVA: 0x22C1BE0 Offset: 0x22C1CE1 VA: 0x22C1BE0
	|-Array.InternalArray__ICollection_Remove<DateTime>
	|
	|-RVA: 0x22C1C50 Offset: 0x22C1D51 VA: 0x22C1C50
	|-Array.InternalArray__ICollection_Remove<DateTimeOffset>
	|
	|-RVA: 0x22C1CC0 Offset: 0x22C1DC1 VA: 0x22C1CC0
	|-Array.InternalArray__ICollection_Remove<Decimal>
	|
	|-RVA: 0x22C1D30 Offset: 0x22C1E31 VA: 0x22C1D30
	|-Array.InternalArray__ICollection_Remove<double>
	|
	|-RVA: 0x22C1DA0 Offset: 0x22C1EA1 VA: 0x22C1DA0
	|-Array.InternalArray__ICollection_Remove<InternalCodePageDataItem>
	|
	|-RVA: 0x22C1E10 Offset: 0x22C1F11 VA: 0x22C1E10
	|-Array.InternalArray__ICollection_Remove<InternalEncodingDataItem>
	|
	|-RVA: 0x22C1E80 Offset: 0x22C1F81 VA: 0x22C1E80
	|-Array.InternalArray__ICollection_Remove<Guid>
	|
	|-RVA: 0x22C1EF0 Offset: 0x22C1FF1 VA: 0x22C1EF0
	|-Array.InternalArray__ICollection_Remove<short>
	|
	|-RVA: 0x22C1F60 Offset: 0x22C2061 VA: 0x22C1F60
	|-Array.InternalArray__ICollection_Remove<int>
	|
	|-RVA: 0x22C1FD0 Offset: 0x22C20D1 VA: 0x22C1FD0
	|-Array.InternalArray__ICollection_Remove<Int32Enum>
	|
	|-RVA: 0x22C2040 Offset: 0x22C2141 VA: 0x22C2040
	|-Array.InternalArray__ICollection_Remove<long>
	|
	|-RVA: 0x22C20B0 Offset: 0x22C21B1 VA: 0x22C20B0
	|-Array.InternalArray__ICollection_Remove<IntPtr>
	|
	|-RVA: 0x22C2120 Offset: 0x22C2221 VA: 0x22C2120
	|-Array.InternalArray__ICollection_Remove<InterpretedFrameInfo>
	|
	|-RVA: 0x22C2190 Offset: 0x22C2291 VA: 0x22C2190
	|-Array.InternalArray__ICollection_Remove<LocalDefinition>
	|
	|-RVA: 0x22C2200 Offset: 0x22C2301 VA: 0x22C2200
	|-Array.InternalArray__ICollection_Remove<RuntimeLabel>
	|
	|-RVA: 0x22C2270 Offset: 0x22C2371 VA: 0x22C2270
	|-Array.InternalArray__ICollection_Remove<Set.Slot<int>>
	|
	|-RVA: 0x22C22E0 Offset: 0x22C23E1 VA: 0x22C22E0
	|-Array.InternalArray__ICollection_Remove<Set.Slot<object>>
	|
	|-RVA: 0x22C2350 Offset: 0x22C2451 VA: 0x22C2350
	|-Array.InternalArray__ICollection_Remove<Memory<object>>
	|
	|-RVA: 0x22C23C0 Offset: 0x22C24C1 VA: 0x22C23C0
	|-Array.InternalArray__ICollection_Remove<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x22C2430 Offset: 0x22C2531 VA: 0x22C2430
	|-Array.InternalArray__ICollection_Remove<HeaderVariantInfo>
	|
	|-RVA: 0x22C24A0 Offset: 0x22C25A1 VA: 0x22C24A0
	|-Array.InternalArray__ICollection_Remove<Socket.WSABUF>
	|
	|-RVA: 0x22C2510 Offset: 0x22C2611 VA: 0x22C2510
	|-Array.InternalArray__ICollection_Remove<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x22C2580 Offset: 0x22C2681 VA: 0x22C2580
	|-Array.InternalArray__ICollection_Remove<Nullable<Int32Enum>>
	|
	|-RVA: 0x22C25F0 Offset: 0x22C26F1 VA: 0x22C25F0
	|-Array.InternalArray__ICollection_Remove<Nullable<Bounds>>
	|
	|-RVA: 0x22C2660 Offset: 0x22C2761 VA: 0x22C2660
	|-Array.InternalArray__ICollection_Remove<Nullable<BoundsInt>>
	|
	|-RVA: 0x22C26D0 Offset: 0x22C27D1 VA: 0x22C26D0
	|-Array.InternalArray__ICollection_Remove<Nullable<Color32>>
	|
	|-RVA: 0x22C2740 Offset: 0x22C2841 VA: 0x22C2740
	|-Array.InternalArray__ICollection_Remove<Nullable<Color>>
	|
	|-RVA: 0x22C27B0 Offset: 0x22C28B1 VA: 0x22C27B0
	|-Array.InternalArray__ICollection_Remove<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x22C2820 Offset: 0x22C2921 VA: 0x22C2820
	|-Array.InternalArray__ICollection_Remove<Nullable<GradientColorKey>>
	|
	|-RVA: 0x22C2890 Offset: 0x22C2991 VA: 0x22C2890
	|-Array.InternalArray__ICollection_Remove<Nullable<Keyframe>>
	|
	|-RVA: 0x22C2900 Offset: 0x22C2A01 VA: 0x22C2900
	|-Array.InternalArray__ICollection_Remove<Nullable<LayerMask>>
	|
	|-RVA: 0x22C2970 Offset: 0x22C2A71 VA: 0x22C2970
	|-Array.InternalArray__ICollection_Remove<Nullable<Matrix4x4>>
	|
	|-RVA: 0x22C29E0 Offset: 0x22C2AE1 VA: 0x22C29E0
	|-Array.InternalArray__ICollection_Remove<Nullable<Quaternion>>
	|
	|-RVA: 0x22C2A50 Offset: 0x22C2B51 VA: 0x22C2A50
	|-Array.InternalArray__ICollection_Remove<Nullable<RangeInt>>
	|
	|-RVA: 0x22C2AC0 Offset: 0x22C2BC1 VA: 0x22C2AC0
	|-Array.InternalArray__ICollection_Remove<Nullable<Rect>>
	|
	|-RVA: 0x22C2B30 Offset: 0x22C2C31 VA: 0x22C2B30
	|-Array.InternalArray__ICollection_Remove<Nullable<RectInt>>
	|
	|-RVA: 0x22C2BA0 Offset: 0x22C2CA1 VA: 0x22C2BA0
	|-Array.InternalArray__ICollection_Remove<Nullable<Vector2>>
	|
	|-RVA: 0x22C2C10 Offset: 0x22C2D11 VA: 0x22C2C10
	|-Array.InternalArray__ICollection_Remove<Nullable<Vector2Int>>
	|
	|-RVA: 0x22C2C80 Offset: 0x22C2D81 VA: 0x22C2C80
	|-Array.InternalArray__ICollection_Remove<Nullable<Vector3>>
	|
	|-RVA: 0x22C2CF0 Offset: 0x22C2DF1 VA: 0x22C2CF0
	|-Array.InternalArray__ICollection_Remove<Nullable<Vector3Int>>
	|
	|-RVA: 0x22C2D60 Offset: 0x22C2E61 VA: 0x22C2D60
	|-Array.InternalArray__ICollection_Remove<Nullable<Vector4>>
	|
	|-RVA: 0x22C2DD0 Offset: 0x22C2ED1 VA: 0x22C2DD0
	|-Array.InternalArray__ICollection_Remove<object>
	|
	|-RVA: 0x22C2E40 Offset: 0x22C2F41 VA: 0x22C2E40
	|-Array.InternalArray__ICollection_Remove<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x22C2EB0 Offset: 0x22C2FB1 VA: 0x22C2EB0
	|-Array.InternalArray__ICollection_Remove<ReadOnlyMemory<object>>
	|
	|-RVA: 0x22C2F20 Offset: 0x22C3021 VA: 0x22C2F20
	|-Array.InternalArray__ICollection_Remove<CustomAttributeNamedArgument>
	|
	|-RVA: 0x22C2F90 Offset: 0x22C3091 VA: 0x22C2F90
	|-Array.InternalArray__ICollection_Remove<CustomAttributeTypedArgument>
	|
	|-RVA: 0x22C3000 Offset: 0x22C3101 VA: 0x22C3000
	|-Array.InternalArray__ICollection_Remove<Label>
	|
	|-RVA: 0x22C3070 Offset: 0x22C3171 VA: 0x22C3070
	|-Array.InternalArray__ICollection_Remove<ParameterModifier>
	|
	|-RVA: 0x22C30E0 Offset: 0x22C31E1 VA: 0x22C30E0
	|-Array.InternalArray__ICollection_Remove<ResourceLocator>
	|
	|-RVA: 0x22C3150 Offset: 0x22C3251 VA: 0x22C3150
	|-Array.InternalArray__ICollection_Remove<Ephemeron>
	|
	|-RVA: 0x22C31C0 Offset: 0x22C32C1 VA: 0x22C31C0
	|-Array.InternalArray__ICollection_Remove<GCHandle>
	|
	|-RVA: 0x22C3230 Offset: 0x22C3331 VA: 0x22C3230
	|-Array.InternalArray__ICollection_Remove<RuntimeTypeHandle>
	|
	|-RVA: 0x22C32A0 Offset: 0x22C33A1 VA: 0x22C32A0
	|-Array.InternalArray__ICollection_Remove<sbyte>
	|
	|-RVA: 0x22C3310 Offset: 0x22C3411 VA: 0x22C3310
	|-Array.InternalArray__ICollection_Remove<X509ChainStatus>
	|
	|-RVA: 0x22C3380 Offset: 0x22C3481 VA: 0x22C3380
	|-Array.InternalArray__ICollection_Remove<float>
	|
	|-RVA: 0x22C33F0 Offset: 0x22C34F1 VA: 0x22C33F0
	|-Array.InternalArray__ICollection_Remove<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x22C3460 Offset: 0x22C3561 VA: 0x22C3460
	|-Array.InternalArray__ICollection_Remove<CancellationTokenRegistration>
	|
	|-RVA: 0x22C34D0 Offset: 0x22C35D1 VA: 0x22C34D0
	|-Array.InternalArray__ICollection_Remove<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x22C3540 Offset: 0x22C3641 VA: 0x22C3540
	|-Array.InternalArray__ICollection_Remove<TimeSpan>
	|
	|-RVA: 0x22C35B0 Offset: 0x22C36B1 VA: 0x22C35B0
	|-Array.InternalArray__ICollection_Remove<ushort>
	|
	|-RVA: 0x22C3620 Offset: 0x22C3721 VA: 0x22C3620
	|-Array.InternalArray__ICollection_Remove<UInt16Enum>
	|
	|-RVA: 0x22C3690 Offset: 0x22C3791 VA: 0x22C3690
	|-Array.InternalArray__ICollection_Remove<uint>
	|
	|-RVA: 0x22C3700 Offset: 0x22C3801 VA: 0x22C3700
	|-Array.InternalArray__ICollection_Remove<UInt32Enum>
	|
	|-RVA: 0x22C3770 Offset: 0x22C3871 VA: 0x22C3770
	|-Array.InternalArray__ICollection_Remove<ulong>
	|
	|-RVA: 0x22C37E0 Offset: 0x22C38E1 VA: 0x22C37E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x22C3850 Offset: 0x22C3951 VA: 0x22C3850
	|-Array.InternalArray__ICollection_Remove<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x22C38C0 Offset: 0x22C39C1 VA: 0x22C38C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x22C3930 Offset: 0x22C3A31 VA: 0x22C3930
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x22C39A0 Offset: 0x22C3AA1 VA: 0x22C39A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object>>
	|
	|-RVA: 0x22C3A10 Offset: 0x22C3B11 VA: 0x22C3A10
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, float>>
	|
	|-RVA: 0x22C3A80 Offset: 0x22C3B81 VA: 0x22C3A80
	|-Array.InternalArray__ICollection_Remove<ValueTuple<float, object>>
	|
	|-RVA: 0x22C3AF0 Offset: 0x22C3BF1 VA: 0x22C3AF0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<float, float>>
	|
	|-RVA: 0x22C3B60 Offset: 0x22C3C61 VA: 0x22C3B60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x22C3BD0 Offset: 0x22C3CD1 VA: 0x22C3BD0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x22C3C40 Offset: 0x22C3D41 VA: 0x22C3C40
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x22C3CB0 Offset: 0x22C3DB1 VA: 0x22C3CB0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x22C3D20 Offset: 0x22C3E21 VA: 0x22C3D20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x22C3D90 Offset: 0x22C3E91 VA: 0x22C3D90
	|-Array.InternalArray__ICollection_Remove<HighlightState>
	|
	|-RVA: 0x22C3E00 Offset: 0x22C3F01 VA: 0x22C3E00
	|-Array.InternalArray__ICollection_Remove<MaterialReference>
	|
	|-RVA: 0x22C3E70 Offset: 0x22C3F71 VA: 0x22C3E70
	|-Array.InternalArray__ICollection_Remove<RichTextTagAttribute>
	|
	|-RVA: 0x22C3EE0 Offset: 0x22C3FE1 VA: 0x22C3EE0
	|-Array.InternalArray__ICollection_Remove<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x22C3F50 Offset: 0x22C4051 VA: 0x22C3F50
	|-Array.InternalArray__ICollection_Remove<TMP_CharacterInfo>
	|
	|-RVA: 0x22C3FC0 Offset: 0x22C40C1 VA: 0x22C3FC0
	|-Array.InternalArray__ICollection_Remove<TMP_FontWeightPair>
	|
	|-RVA: 0x22C4030 Offset: 0x22C4131 VA: 0x22C4030
	|-Array.InternalArray__ICollection_Remove<TMP_LineInfo>
	|
	|-RVA: 0x22C40A0 Offset: 0x22C41A1 VA: 0x22C40A0
	|-Array.InternalArray__ICollection_Remove<TMP_LinkInfo>
	|
	|-RVA: 0x22C4110 Offset: 0x22C4211 VA: 0x22C4110
	|-Array.InternalArray__ICollection_Remove<TMP_MeshInfo>
	|
	|-RVA: 0x22C4180 Offset: 0x22C4281 VA: 0x22C4180
	|-Array.InternalArray__ICollection_Remove<TMP_PageInfo>
	|
	|-RVA: 0x22C41F0 Offset: 0x22C42F1 VA: 0x22C41F0
	|-Array.InternalArray__ICollection_Remove<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x22C4260 Offset: 0x22C4361 VA: 0x22C4260
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x22C42D0 Offset: 0x22C43D1 VA: 0x22C42D0
	|-Array.InternalArray__ICollection_Remove<TMP_WordInfo>
	|
	|-RVA: 0x22C4340 Offset: 0x22C4441 VA: 0x22C4340
	|-Array.InternalArray__ICollection_Remove<WordWrapState>
	|
	|-RVA: 0x22C43B0 Offset: 0x22C44B1 VA: 0x22C43B0
	|-Array.InternalArray__ICollection_Remove<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x22C4420 Offset: 0x22C4521 VA: 0x22C4420
	|-Array.InternalArray__ICollection_Remove<TransitionTables>
	|
	|-RVA: 0x22C4490 Offset: 0x22C4591 VA: 0x22C4490
	|-Array.InternalArray__ICollection_Remove<TutorialUnlockFlagData>
	|
	|-RVA: 0x22C4500 Offset: 0x22C4601 VA: 0x22C4500
	|-Array.InternalArray__ICollection_Remove<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x22C4570 Offset: 0x22C4671 VA: 0x22C4570
	|-Array.InternalArray__ICollection_Remove<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x22C45E0 Offset: 0x22C46E1 VA: 0x22C45E0
	|-Array.InternalArray__ICollection_Remove<CapEdge>
	|
	|-RVA: 0x22C4650 Offset: 0x22C4751 VA: 0x22C4650
	|-Array.InternalArray__ICollection_Remove<ClippedEdge>
	|
	|-RVA: 0x22C46C0 Offset: 0x22C47C1 VA: 0x22C46C0
	|-Array.InternalArray__ICollection_Remove<EdgeKeyByHash>
	|
	|-RVA: 0x22C4730 Offset: 0x22C4831 VA: 0x22C4730
	|-Array.InternalArray__ICollection_Remove<EdgeKeyByIndex>
	|
	|-RVA: 0x22C47A0 Offset: 0x22C48A1 VA: 0x22C47A0
	|-Array.InternalArray__ICollection_Remove<MeshDataConnectivity.Face>
	|
	|-RVA: 0x22C4810 Offset: 0x22C4911 VA: 0x22C4810
	|-Array.InternalArray__ICollection_Remove<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x22C4880 Offset: 0x22C4981 VA: 0x22C4880
	|-Array.InternalArray__ICollection_Remove<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x22C48F0 Offset: 0x22C49F1 VA: 0x22C48F0
	|-Array.InternalArray__ICollection_Remove<NavMeshBuildMarkup>
	|
	|-RVA: 0x22C4960 Offset: 0x22C4A61 VA: 0x22C4960
	|-Array.InternalArray__ICollection_Remove<NavMeshBuildSource>
	|
	|-RVA: 0x22C49D0 Offset: 0x22C4AD1 VA: 0x22C49D0
	|-Array.InternalArray__ICollection_Remove<ContentCatalogData.Bucket>
	|
	|-RVA: 0x22C4A40 Offset: 0x22C4B41 VA: 0x22C4A40
	|-Array.InternalArray__ICollection_Remove<ConstraintSource>
	|
	|-RVA: 0x22C4AB0 Offset: 0x22C4BB1 VA: 0x22C4AB0
	|-Array.InternalArray__ICollection_Remove<PropertySceneHandle>
	|
	|-RVA: 0x22C4B20 Offset: 0x22C4C21 VA: 0x22C4B20
	|-Array.InternalArray__ICollection_Remove<TransformStreamHandle>
	|
	|-RVA: 0x22C4B90 Offset: 0x22C4C91 VA: 0x22C4B90
	|-Array.InternalArray__ICollection_Remove<AnimatorClipInfo>
	|
	|-RVA: 0x22C4C00 Offset: 0x22C4D01 VA: 0x22C4C00
	|-Array.InternalArray__ICollection_Remove<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x22C4C70 Offset: 0x22C4D71 VA: 0x22C4C70
	|-Array.InternalArray__ICollection_Remove<BoneWeight1>
	|
	|-RVA: 0x22C4CE0 Offset: 0x22C4DE1 VA: 0x22C4CE0
	|-Array.InternalArray__ICollection_Remove<BoneWeight>
	|
	|-RVA: 0x22C4D50 Offset: 0x22C4E51 VA: 0x22C4D50
	|-Array.InternalArray__ICollection_Remove<BoundingSphere>
	|
	|-RVA: 0x22C4DC0 Offset: 0x22C4EC1 VA: 0x22C4DC0
	|-Array.InternalArray__ICollection_Remove<Bounds>
	|
	|-RVA: 0x22C4E30 Offset: 0x22C4F31 VA: 0x22C4E30
	|-Array.InternalArray__ICollection_Remove<BoundsInt>
	|
	|-RVA: 0x22C4EA0 Offset: 0x22C4FA1 VA: 0x22C4EA0
	|-Array.InternalArray__ICollection_Remove<CharacterInfo>
	|
	|-RVA: 0x22C4F10 Offset: 0x22C5011 VA: 0x22C4F10
	|-Array.InternalArray__ICollection_Remove<Color32>
	|
	|-RVA: 0x22C4F80 Offset: 0x22C5081 VA: 0x22C4F80
	|-Array.InternalArray__ICollection_Remove<Color>
	|
	|-RVA: 0x22C4FF0 Offset: 0x22C50F1 VA: 0x22C4FF0
	|-Array.InternalArray__ICollection_Remove<CombineInstance>
	|
	|-RVA: 0x22C5060 Offset: 0x22C5161 VA: 0x22C5060
	|-Array.InternalArray__ICollection_Remove<ContactPoint2D>
	|
	|-RVA: 0x22C50D0 Offset: 0x22C51D1 VA: 0x22C50D0
	|-Array.InternalArray__ICollection_Remove<ContactPoint>
	|
	|-RVA: 0x22C5140 Offset: 0x22C5241 VA: 0x22C5140
	|-Array.InternalArray__ICollection_Remove<RaycastResult>
	|
	|-RVA: 0x22C51B0 Offset: 0x22C52B1 VA: 0x22C51B0
	|-Array.InternalArray__ICollection_Remove<LightDataGI>
	|
	|-RVA: 0x22C5220 Offset: 0x22C5321 VA: 0x22C5220
	|-Array.InternalArray__ICollection_Remove<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x22C5290 Offset: 0x22C5391 VA: 0x22C5290
	|-Array.InternalArray__ICollection_Remove<GradientAlphaKey>
	|
	|-RVA: 0x22C5300 Offset: 0x22C5401 VA: 0x22C5300
	|-Array.InternalArray__ICollection_Remove<GradientColorKey>
	|
	|-RVA: 0x22C5370 Offset: 0x22C5471 VA: 0x22C5370
	|-Array.InternalArray__ICollection_Remove<HumanBone>
	|
	|-RVA: 0x22C53E0 Offset: 0x22C54E1 VA: 0x22C53E0
	|-Array.InternalArray__ICollection_Remove<Keyframe>
	|
	|-RVA: 0x22C5450 Offset: 0x22C5551 VA: 0x22C5450
	|-Array.InternalArray__ICollection_Remove<LOD>
	|
	|-RVA: 0x22C54C0 Offset: 0x22C55C1 VA: 0x22C54C0
	|-Array.InternalArray__ICollection_Remove<LayerMask>
	|
	|-RVA: 0x22C5530 Offset: 0x22C5631 VA: 0x22C5530
	|-Array.InternalArray__ICollection_Remove<PlayerLoopSystem>
	|
	|-RVA: 0x22C55A0 Offset: 0x22C56A1 VA: 0x22C55A0
	|-Array.InternalArray__ICollection_Remove<Matrix4x4>
	|
	|-RVA: 0x22C5610 Offset: 0x22C5711 VA: 0x22C5610
	|-Array.InternalArray__ICollection_Remove<ParticleSystem.Particle>
	|
	|-RVA: 0x22C5680 Offset: 0x22C5781 VA: 0x22C5680
	|-Array.InternalArray__ICollection_Remove<PatchExtents>
	|
	|-RVA: 0x22C56F0 Offset: 0x22C57F1 VA: 0x22C56F0
	|-Array.InternalArray__ICollection_Remove<Plane>
	|
	|-RVA: 0x22C5760 Offset: 0x22C5861 VA: 0x22C5760
	|-Array.InternalArray__ICollection_Remove<Playable>
	|
	|-RVA: 0x22C57D0 Offset: 0x22C58D1 VA: 0x22C57D0
	|-Array.InternalArray__ICollection_Remove<PlayableBinding>
	|
	|-RVA: 0x22C5840 Offset: 0x22C5941 VA: 0x22C5840
	|-Array.InternalArray__ICollection_Remove<PlayableGraph>
	|
	|-RVA: 0x22C58B0 Offset: 0x22C59B1 VA: 0x22C58B0
	|-Array.InternalArray__ICollection_Remove<Edge>
	|
	|-RVA: 0x22C5920 Offset: 0x22C5A21 VA: 0x22C5920
	|-Array.InternalArray__ICollection_Remove<IntVec3>
	|
	|-RVA: 0x22C5990 Offset: 0x22C5A91 VA: 0x22C5990
	|-Array.InternalArray__ICollection_Remove<Quaternion>
	|
	|-RVA: 0x22C5A00 Offset: 0x22C5B01 VA: 0x22C5A00
	|-Array.InternalArray__ICollection_Remove<RangeInt>
	|
	|-RVA: 0x22C5A70 Offset: 0x22C5B71 VA: 0x22C5A70
	|-Array.InternalArray__ICollection_Remove<RaycastHit2D>
	|
	|-RVA: 0x22C5AE0 Offset: 0x22C5BE1 VA: 0x22C5AE0
	|-Array.InternalArray__ICollection_Remove<RaycastHit>
	|
	|-RVA: 0x22C5B50 Offset: 0x22C5C51 VA: 0x22C5B50
	|-Array.InternalArray__ICollection_Remove<Rect>
	|
	|-RVA: 0x22C5BC0 Offset: 0x22C5CC1 VA: 0x22C5BC0
	|-Array.InternalArray__ICollection_Remove<RectInt>
	|
	|-RVA: 0x22C5C30 Offset: 0x22C5D31 VA: 0x22C5C30
	|-Array.InternalArray__ICollection_Remove<RenderBuffer>
	|
	|-RVA: 0x22C5CA0 Offset: 0x22C5DA1 VA: 0x22C5CA0
	|-Array.InternalArray__ICollection_Remove<BatchVisibility>
	|
	|-RVA: 0x22C5D10 Offset: 0x22C5E11 VA: 0x22C5D10
	|-Array.InternalArray__ICollection_Remove<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x22C5D80 Offset: 0x22C5E81 VA: 0x22C5D80
	|-Array.InternalArray__ICollection_Remove<SphericalHarmonicsL2>
	|
	|-RVA: 0x22C5DF0 Offset: 0x22C5EF1 VA: 0x22C5DF0
	|-Array.InternalArray__ICollection_Remove<VertexAttributeDescriptor>
	|
	|-RVA: 0x22C5E60 Offset: 0x22C5F61 VA: 0x22C5E60
	|-Array.InternalArray__ICollection_Remove<AsyncOperationHandle>
	|
	|-RVA: 0x22C5ED0 Offset: 0x22C5FD1 VA: 0x22C5ED0
	|-Array.InternalArray__ICollection_Remove<AsyncOperationHandle<object>>
	|
	|-RVA: 0x22C5F40 Offset: 0x22C6041 VA: 0x22C5F40
	|-Array.InternalArray__ICollection_Remove<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x22C5FB0 Offset: 0x22C60B1 VA: 0x22C5FB0
	|-Array.InternalArray__ICollection_Remove<DiagnosticEvent>
	|
	|-RVA: 0x22C6020 Offset: 0x22C6121 VA: 0x22C6020
	|-Array.InternalArray__ICollection_Remove<SceneInstance>
	|
	|-RVA: 0x22C6090 Offset: 0x22C6191 VA: 0x22C6090
	|-Array.InternalArray__ICollection_Remove<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x22C6100 Offset: 0x22C6201 VA: 0x22C6100
	|-Array.InternalArray__ICollection_Remove<ObjectInitializationData>
	|
	|-RVA: 0x22C6170 Offset: 0x22C6271 VA: 0x22C6170
	|-Array.InternalArray__ICollection_Remove<SerializedType>
	|
	|-RVA: 0x22C61E0 Offset: 0x22C62E1 VA: 0x22C61E0
	|-Array.InternalArray__ICollection_Remove<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x22C6250 Offset: 0x22C6351 VA: 0x22C6250
	|-Array.InternalArray__ICollection_Remove<SkeletonBone>
	|
	|-RVA: 0x22C62C0 Offset: 0x22C63C1 VA: 0x22C62C0
	|-Array.InternalArray__ICollection_Remove<GlyphRect>
	|
	|-RVA: 0x22C6330 Offset: 0x22C6431 VA: 0x22C6330
	|-Array.InternalArray__ICollection_Remove<GlyphMarshallingStruct>
	|
	|-RVA: 0x22C63A0 Offset: 0x22C64A1 VA: 0x22C63A0
	|-Array.InternalArray__ICollection_Remove<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x22C6410 Offset: 0x22C6511 VA: 0x22C6410
	|-Array.InternalArray__ICollection_Remove<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x22C6480 Offset: 0x22C6581 VA: 0x22C6480
	|-Array.InternalArray__ICollection_Remove<IntervalTreeNode>
	|
	|-RVA: 0x22C64F0 Offset: 0x22C65F1 VA: 0x22C64F0
	|-Array.InternalArray__ICollection_Remove<IntervalTree.Entry<object>>
	|
	|-RVA: 0x22C6560 Offset: 0x22C6661 VA: 0x22C6560
	|-Array.InternalArray__ICollection_Remove<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x22C65D0 Offset: 0x22C66D1 VA: 0x22C65D0
	|-Array.InternalArray__ICollection_Remove<Touch>
	|
	|-RVA: 0x22C6640 Offset: 0x22C6741 VA: 0x22C6640
	|-Array.InternalArray__ICollection_Remove<TreeInstance>
	|
	|-RVA: 0x22C66B0 Offset: 0x22C67B1 VA: 0x22C66B0
	|-Array.InternalArray__ICollection_Remove<ColorBlock>
	|
	|-RVA: 0x22C6720 Offset: 0x22C6821 VA: 0x22C6720
	|-Array.InternalArray__ICollection_Remove<Navigation>
	|
	|-RVA: 0x22C6790 Offset: 0x22C6891 VA: 0x22C6790
	|-Array.InternalArray__ICollection_Remove<SpriteState>
	|
	|-RVA: 0x22C6800 Offset: 0x22C6901 VA: 0x22C6800
	|-Array.InternalArray__ICollection_Remove<UICharInfo>
	|
	|-RVA: 0x22C6870 Offset: 0x22C6971 VA: 0x22C6870
	|-Array.InternalArray__ICollection_Remove<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x22C68E0 Offset: 0x22C69E1 VA: 0x22C68E0
	|-Array.InternalArray__ICollection_Remove<EventDispatcher.EventRecord>
	|
	|-RVA: 0x22C6950 Offset: 0x22C6A51 VA: 0x22C6950
	|-Array.InternalArray__ICollection_Remove<FocusController.FocusedElement>
	|
	|-RVA: 0x22C69C0 Offset: 0x22C6AC1 VA: 0x22C69C0
	|-Array.InternalArray__ICollection_Remove<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x22C6A30 Offset: 0x22C6B31 VA: 0x22C6A30
	|-Array.InternalArray__ICollection_Remove<StyleValue>
	|
	|-RVA: 0x22C6AA0 Offset: 0x22C6BA1 VA: 0x22C6AA0
	|-Array.InternalArray__ICollection_Remove<UILineInfo>
	|
	|-RVA: 0x22C6B10 Offset: 0x22C6C11 VA: 0x22C6B10
	|-Array.InternalArray__ICollection_Remove<UIVertex>
	|
	|-RVA: 0x22C6B80 Offset: 0x22C6C81 VA: 0x22C6B80
	|-Array.InternalArray__ICollection_Remove<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x22C6BF0 Offset: 0x22C6CF1 VA: 0x22C6BF0
	|-Array.InternalArray__ICollection_Remove<Vector2>
	|
	|-RVA: 0x22C6C60 Offset: 0x22C6D61 VA: 0x22C6C60
	|-Array.InternalArray__ICollection_Remove<Vector2Int>
	|
	|-RVA: 0x22C6CD0 Offset: 0x22C6DD1 VA: 0x22C6CD0
	|-Array.InternalArray__ICollection_Remove<Vector3>
	|
	|-RVA: 0x22C6D40 Offset: 0x22C6E41 VA: 0x22C6D40
	|-Array.InternalArray__ICollection_Remove<Vector3Int>
	|
	|-RVA: 0x22C6DB0 Offset: 0x22C6EB1 VA: 0x22C6DB0
	|-Array.InternalArray__ICollection_Remove<Vector4>
	|
	|-RVA: 0x22C6E20 Offset: 0x22C6F21 VA: 0x22C6E20
	|-Array.InternalArray__ICollection_Remove<jvalue>
	|
	|-RVA: 0x22C6E90 Offset: 0x22C6F91 VA: 0x22C6E90
	|-Array.InternalArray__ICollection_Remove<WarpPoints.WarpPoint>
	|
	|-RVA: 0x22C6F00 Offset: 0x22C7001 VA: 0x22C6F00
	|-Array.InternalArray__ICollection_Remove<YieldItemParam>
	|
	|-RVA: 0x22C6F70 Offset: 0x22C7071 VA: 0x22C6F70
	|-Array.InternalArray__ICollection_Remove<NetworkServiceAccountId>
	|
	|-RVA: 0x22C6FE0 Offset: 0x22C70E1 VA: 0x22C6FE0
	|-Array.InternalArray__ICollection_Remove<Uid>
	|
	|-RVA: 0x22C7050 Offset: 0x22C7151 VA: 0x22C7050
	|-Array.InternalArray__ICollection_Remove<ConsumableServiceItemId>
	|
	|-RVA: 0x22C70C0 Offset: 0x22C71C1 VA: 0x22C70C0
	|-Array.InternalArray__ICollection_Remove<NsUid>
	|
	|-RVA: 0x22C7130 Offset: 0x22C7231 VA: 0x22C7130
	|-Array.InternalArray__ICollection_Remove<Friend>
	|
	|-RVA: 0x22C71A0 Offset: 0x22C72A1 VA: 0x22C71A0
	|-Array.InternalArray__ICollection_Remove<Profile>
	|
	|-RVA: 0x22C7210 Offset: 0x22C7311 VA: 0x22C7210
	|-Array.InternalArray__ICollection_Remove<DirectoryEntry>
	|
	|-RVA: 0x22C7280 Offset: 0x22C7381 VA: 0x22C7280
	|-Array.InternalArray__ICollection_Remove<DebugPadState>
	|
	|-RVA: 0x22C72F0 Offset: 0x22C73F1 VA: 0x22C72F0
	|-Array.InternalArray__ICollection_Remove<GesturePoint>
	|
	|-RVA: 0x22C7360 Offset: 0x22C7461 VA: 0x22C7360
	|-Array.InternalArray__ICollection_Remove<GestureState>
	|
	|-RVA: 0x22C73D0 Offset: 0x22C74D1 VA: 0x22C73D0
	|-Array.InternalArray__ICollection_Remove<NpadFullKeyState>
	|
	|-RVA: 0x22C7440 Offset: 0x22C7541 VA: 0x22C7440
	|-Array.InternalArray__ICollection_Remove<NpadHandheldState>
	|
	|-RVA: 0x22C74B0 Offset: 0x22C75B1 VA: 0x22C74B0
	|-Array.InternalArray__ICollection_Remove<NpadJoyDualState>
	|
	|-RVA: 0x22C7520 Offset: 0x22C7621 VA: 0x22C7520
	|-Array.InternalArray__ICollection_Remove<NpadJoyLeftState>
	|
	|-RVA: 0x22C7590 Offset: 0x22C7691 VA: 0x22C7590
	|-Array.InternalArray__ICollection_Remove<NpadJoyRightState>
	|
	|-RVA: 0x22C7600 Offset: 0x22C7701 VA: 0x22C7600
	|-Array.InternalArray__ICollection_Remove<NpadStateArrayItem>
	|
	|-RVA: 0x22C7670 Offset: 0x22C7771 VA: 0x22C7670
	|-Array.InternalArray__ICollection_Remove<SixAxisSensorHandle>
	|
	|-RVA: 0x22C76E0 Offset: 0x22C77E1 VA: 0x22C76E0
	|-Array.InternalArray__ICollection_Remove<SixAxisSensorState>
	|
	|-RVA: 0x22C7750 Offset: 0x22C7851 VA: 0x22C7750
	|-Array.InternalArray__ICollection_Remove<TouchScreenState10>
	|
	|-RVA: 0x22C77C0 Offset: 0x22C78C1 VA: 0x22C77C0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState11>
	|
	|-RVA: 0x22C7830 Offset: 0x22C7931 VA: 0x22C7830
	|-Array.InternalArray__ICollection_Remove<TouchScreenState12>
	|
	|-RVA: 0x22C78A0 Offset: 0x22C79A1 VA: 0x22C78A0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState13>
	|
	|-RVA: 0x22C7910 Offset: 0x22C7A11 VA: 0x22C7910
	|-Array.InternalArray__ICollection_Remove<TouchScreenState14>
	|
	|-RVA: 0x22C7980 Offset: 0x22C7A81 VA: 0x22C7980
	|-Array.InternalArray__ICollection_Remove<TouchScreenState15>
	|
	|-RVA: 0x22C79F0 Offset: 0x22C7AF1 VA: 0x22C79F0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState16>
	|
	|-RVA: 0x22C7A60 Offset: 0x22C7B61 VA: 0x22C7A60
	|-Array.InternalArray__ICollection_Remove<TouchScreenState1>
	|
	|-RVA: 0x22C7AD0 Offset: 0x22C7BD1 VA: 0x22C7AD0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState2>
	|
	|-RVA: 0x22C7B40 Offset: 0x22C7C41 VA: 0x22C7B40
	|-Array.InternalArray__ICollection_Remove<TouchScreenState3>
	|
	|-RVA: 0x22C7BB0 Offset: 0x22C7CB1 VA: 0x22C7BB0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState4>
	|
	|-RVA: 0x22C7C20 Offset: 0x22C7D21 VA: 0x22C7C20
	|-Array.InternalArray__ICollection_Remove<TouchScreenState5>
	|
	|-RVA: 0x22C7C90 Offset: 0x22C7D91 VA: 0x22C7C90
	|-Array.InternalArray__ICollection_Remove<TouchScreenState6>
	|
	|-RVA: 0x22C7D00 Offset: 0x22C7E01 VA: 0x22C7D00
	|-Array.InternalArray__ICollection_Remove<TouchScreenState7>
	|
	|-RVA: 0x22C7D70 Offset: 0x22C7E71 VA: 0x22C7D70
	|-Array.InternalArray__ICollection_Remove<TouchScreenState8>
	|
	|-RVA: 0x22C7DE0 Offset: 0x22C7EE1 VA: 0x22C7DE0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState9>
	|
	|-RVA: 0x22C7E50 Offset: 0x22C7F51 VA: 0x22C7E50
	|-Array.InternalArray__ICollection_Remove<TouchState>
	|
	|-RVA: 0x22C7EC0 Offset: 0x22C7FC1 VA: 0x22C7EC0
	|-Array.InternalArray__ICollection_Remove<VibrationDeviceHandle>
	|
	|-RVA: 0x22C7F30 Offset: 0x22C8031 VA: 0x22C7F30
	|-Array.InternalArray__ICollection_Remove<VibrationDeviceInfo>
	|
	|-RVA: 0x22C7FA0 Offset: 0x22C80A1 VA: 0x22C7FA0
	|-Array.InternalArray__ICollection_Remove<VibrationValue>
	|
	|-RVA: 0x22C8010 Offset: 0x22C8111 VA: 0x22C8010
	|-Array.InternalArray__ICollection_Remove<ClusteringData>
	|
	|-RVA: 0x22C8080 Offset: 0x22C8181 VA: 0x22C8080
	|-Array.InternalArray__ICollection_Remove<ClusteringProcessorState>
	|
	|-RVA: 0x22C80F0 Offset: 0x22C81F1 VA: 0x22C80F0
	|-Array.InternalArray__ICollection_Remove<Finger>
	|
	|-RVA: 0x22C8160 Offset: 0x22C8261 VA: 0x22C8160
	|-Array.InternalArray__ICollection_Remove<Hand>
	|
	|-RVA: 0x22C81D0 Offset: 0x22C82D1 VA: 0x22C81D0
	|-Array.InternalArray__ICollection_Remove<HandAnalysisImageState>
	|
	|-RVA: 0x22C8240 Offset: 0x22C8341 VA: 0x22C8240
	|-Array.InternalArray__ICollection_Remove<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x22C82B0 Offset: 0x22C83B1 VA: 0x22C82B0
	|-Array.InternalArray__ICollection_Remove<MomentProcessorState>
	|
	|-RVA: 0x22C8320 Offset: 0x22C8421 VA: 0x22C8320
	|-Array.InternalArray__ICollection_Remove<MomentStatistic>
	|
	|-RVA: 0x22C8390 Offset: 0x22C8491 VA: 0x22C8390
	|-Array.InternalArray__ICollection_Remove<Protrusion>
	|
	|-RVA: 0x22C8400 Offset: 0x22C8501 VA: 0x22C8400
	|-Array.InternalArray__ICollection_Remove<Shape>
	|
	|-RVA: 0x22C8470 Offset: 0x22C8571 VA: 0x22C8470
	|-Array.InternalArray__ICollection_Remove<DictionaryInfo>
	|
	|-RVA: 0x22C84E0 Offset: 0x22C85E1 VA: 0x22C84E0
	|-Array.InternalArray__ICollection_Remove<UserWord>
	|
	|-RVA: 0x22C8550 Offset: 0x22C8651 VA: 0x22C8550
	|-Array.InternalArray__ICollection_Remove<Color4u8>
	|
	|-RVA: 0x22C85C0 Offset: 0x22C86C1 VA: 0x22C85C0
	|-Array.InternalArray__ICollection_Remove<Float2>
	|
	|-RVA: 0x22C8630 Offset: 0x22C8731 VA: 0x22C8630
	|-Array.InternalArray__ICollection_Remove<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	internal bool InternalArray__ICollection_Contains<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519E00 Offset: 0x2519F01 VA: 0x2519E00
	|-Array.InternalArray__ICollection_Contains<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x2519FC0 Offset: 0x251A0C1 VA: 0x2519FC0
	|-Array.InternalArray__ICollection_Contains<ActionCommandDataTable>
	|
	|-RVA: 0x251A1D0 Offset: 0x251A2D1 VA: 0x251A1D0
	|-Array.InternalArray__ICollection_Contains<AdvScriptDefCountParam>
	|
	|-RVA: 0x251A380 Offset: 0x251A481 VA: 0x251A380
	|-Array.InternalArray__ICollection_Contains<JSONDeserialization.TaskField>
	|
	|-RVA: 0x251A530 Offset: 0x251A631 VA: 0x251A530
	|-Array.InternalArray__ICollection_Contains<BitVector32Int>
	|
	|-RVA: 0x251A690 Offset: 0x251A791 VA: 0x251A690
	|-Array.InternalArray__ICollection_Contains<BuildItemData>
	|
	|-RVA: 0x251A8D0 Offset: 0x251A9D1 VA: 0x251A8D0
	|-Array.InternalArray__ICollection_Contains<ButtonLinker.LinkObject>
	|
	|-RVA: 0x251AA80 Offset: 0x251AB81 VA: 0x251AA80
	|-Array.InternalArray__ICollection_Contains<CharaCallTable.BustupTable>
	|
	|-RVA: 0x251AC30 Offset: 0x251AD31 VA: 0x251AC30
	|-Array.InternalArray__ICollection_Contains<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x251ADF0 Offset: 0x251AEF1 VA: 0x251ADF0
	|-Array.InternalArray__ICollection_Contains<CameraState.CustomBlendable>
	|
	|-RVA: 0x251AFA0 Offset: 0x251B0A1 VA: 0x251AFA0
	|-Array.InternalArray__ICollection_Contains<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x251B160 Offset: 0x251B261 VA: 0x251B160
	|-Array.InternalArray__ICollection_Contains<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x251B320 Offset: 0x251B421 VA: 0x251B320
	|-Array.InternalArray__ICollection_Contains<CinemachineClearShot.Pair>
	|
	|-RVA: 0x251B4D0 Offset: 0x251B5D1 VA: 0x251B4D0
	|-Array.InternalArray__ICollection_Contains<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x251B680 Offset: 0x251B781 VA: 0x251B680
	|-Array.InternalArray__ICollection_Contains<CinemachinePath.Waypoint>
	|
	|-RVA: 0x251B850 Offset: 0x251B951 VA: 0x251B850
	|-Array.InternalArray__ICollection_Contains<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x251BA00 Offset: 0x251BB01 VA: 0x251BA00
	|-Array.InternalArray__ICollection_Contains<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x251BBB0 Offset: 0x251BCB1 VA: 0x251BBB0
	|-Array.InternalArray__ICollection_Contains<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x251BD70 Offset: 0x251BE71 VA: 0x251BD70
	|-Array.InternalArray__ICollection_Contains<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x251BF20 Offset: 0x251C021 VA: 0x251BF20
	|-Array.InternalArray__ICollection_Contains<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x251C0D0 Offset: 0x251C1D1 VA: 0x251C0D0
	|-Array.InternalArray__ICollection_Contains<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x251C2B0 Offset: 0x251C3B1 VA: 0x251C2B0
	|-Array.InternalArray__ICollection_Contains<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x251C480 Offset: 0x251C581 VA: 0x251C480
	|-Array.InternalArray__ICollection_Contains<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x251C660 Offset: 0x251C761 VA: 0x251C660
	|-Array.InternalArray__ICollection_Contains<HeadingTracker.Item>
	|
	|-RVA: 0x251C820 Offset: 0x251C921 VA: 0x251C820
	|-Array.InternalArray__ICollection_Contains<CropDataTable>
	|
	|-RVA: 0x251CA20 Offset: 0x251CB21 VA: 0x251CA20
	|-Array.InternalArray__ICollection_Contains<ControlPoint>
	|
	|-RVA: 0x251CBE0 Offset: 0x251CCE1 VA: 0x251CBE0
	|-Array.InternalArray__ICollection_Contains<DamageTextInfo>
	|
	|-RVA: 0x251CDA0 Offset: 0x251CEA1 VA: 0x251CDA0
	|-Array.InternalArray__ICollection_Contains<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x251CF60 Offset: 0x251D061 VA: 0x251CF60
	|-Array.InternalArray__ICollection_Contains<DropItemParam>
	|
	|-RVA: 0x251D110 Offset: 0x251D211 VA: 0x251D110
	|-Array.InternalArray__ICollection_Contains<DropTableElement>
	|
	|-RVA: 0x251D2D0 Offset: 0x251D3D1 VA: 0x251D2D0
	|-Array.InternalArray__ICollection_Contains<EffectDataTable>
	|
	|-RVA: 0x251D490 Offset: 0x251D591 VA: 0x251D490
	|-Array.InternalArray__ICollection_Contains<EnemyPatrolPoints>
	|
	|-RVA: 0x251D640 Offset: 0x251D741 VA: 0x251D640
	|-Array.InternalArray__ICollection_Contains<Coord>
	|
	|-RVA: 0x251D7A0 Offset: 0x251D8A1 VA: 0x251D7A0
	|-Array.InternalArray__ICollection_Contains<ErosionBrush.UndoStep>
	|
	|-RVA: 0x251D960 Offset: 0x251DA61 VA: 0x251D960
	|-Array.InternalArray__ICollection_Contains<EventCheckId>
	|
	|-RVA: 0x251DB20 Offset: 0x251DC21 VA: 0x251DB20
	|-Array.InternalArray__ICollection_Contains<EventFlagProgressData>
	|
	|-RVA: 0x251DCD0 Offset: 0x251DDD1 VA: 0x251DCD0
	|-Array.InternalArray__ICollection_Contains<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x251DE80 Offset: 0x251DF81 VA: 0x251DE80
	|-Array.InternalArray__ICollection_Contains<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x251E0A0 Offset: 0x251E1A1 VA: 0x251E0A0
	|-Array.InternalArray__ICollection_Contains<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x251E290 Offset: 0x251E391 VA: 0x251E290
	|-Array.InternalArray__ICollection_Contains<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x251E450 Offset: 0x251E551 VA: 0x251E450
	|-Array.InternalArray__ICollection_Contains<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x251E610 Offset: 0x251E711 VA: 0x251E610
	|-Array.InternalArray__ICollection_Contains<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x251E7C0 Offset: 0x251E8C1 VA: 0x251E7C0
	|-Array.InternalArray__ICollection_Contains<FesNpcScoreData>
	|
	|-RVA: 0x251E970 Offset: 0x251EA71 VA: 0x251E970
	|-Array.InternalArray__ICollection_Contains<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x251EB20 Offset: 0x251EC21 VA: 0x251EB20
	|-Array.InternalArray__ICollection_Contains<FieldItemSpawnDataTable>
	|
	|-RVA: 0x251ED00 Offset: 0x251EE01 VA: 0x251ED00
	|-Array.InternalArray__ICollection_Contains<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x251EEC0 Offset: 0x251EFC1 VA: 0x251EEC0
	|-Array.InternalArray__ICollection_Contains<FieldSceneData.Data>
	|
	|-RVA: 0x251F0C0 Offset: 0x251F1C1 VA: 0x251F0C0
	|-Array.InternalArray__ICollection_Contains<FieldTreasureBoxItemData>
	|
	|-RVA: 0x251F270 Offset: 0x251F371 VA: 0x251F270
	|-Array.InternalArray__ICollection_Contains<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x251F440 Offset: 0x251F541 VA: 0x251F440
	|-Array.InternalArray__ICollection_Contains<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x251F600 Offset: 0x251F701 VA: 0x251F600
	|-Array.InternalArray__ICollection_Contains<FocusObjectDataTable>
	|
	|-RVA: 0x251F7C0 Offset: 0x251F8C1 VA: 0x251F7C0
	|-Array.InternalArray__ICollection_Contains<FurnitureData>
	|
	|-RVA: 0x251F980 Offset: 0x251FA81 VA: 0x251F980
	|-Array.InternalArray__ICollection_Contains<GateDataTable>
	|
	|-RVA: 0x251FB30 Offset: 0x251FC31 VA: 0x251FB30
	|-Array.InternalArray__ICollection_Contains<GateStatusDataTable>
	|
	|-RVA: 0x251FD00 Offset: 0x251FE01 VA: 0x251FD00
	|-Array.InternalArray__ICollection_Contains<GimmickLayoutDataTable>
	|
	|-RVA: 0x251FEB0 Offset: 0x251FFB1 VA: 0x251FEB0
	|-Array.InternalArray__ICollection_Contains<HitResult>
	|
	|-RVA: 0x2520080 Offset: 0x2520181 VA: 0x2520080
	|-Array.InternalArray__ICollection_Contains<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x2520240 Offset: 0x2520341 VA: 0x2520240
	|-Array.InternalArray__ICollection_Contains<FurnitureManager.SendPos>
	|
	|-RVA: 0x2520400 Offset: 0x2520501 VA: 0x2520400
	|-Array.InternalArray__ICollection_Contains<ItemLevelData>
	|
	|-RVA: 0x25205B0 Offset: 0x25206B1 VA: 0x25205B0
	|-Array.InternalArray__ICollection_Contains<MapDatas.MapData>
	|
	|-RVA: 0x2520770 Offset: 0x2520871 VA: 0x2520770
	|-Array.InternalArray__ICollection_Contains<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x2520940 Offset: 0x2520A41 VA: 0x2520940
	|-Array.InternalArray__ICollection_Contains<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x2520AF0 Offset: 0x2520BF1 VA: 0x2520AF0
	|-Array.InternalArray__ICollection_Contains<MineTypeDataTable>
	|
	|-RVA: 0x2520CE0 Offset: 0x2520DE1 VA: 0x2520CE0
	|-Array.InternalArray__ICollection_Contains<MiningDataTable>
	|
	|-RVA: 0x2520E90 Offset: 0x2520F91 VA: 0x2520E90
	|-Array.InternalArray__ICollection_Contains<MiningPointSaveData>
	|
	|-RVA: 0x2521070 Offset: 0x2521171 VA: 0x2521070
	|-Array.InternalArray__ICollection_Contains<CodePointIndexer.TableRange>
	|
	|-RVA: 0x2521230 Offset: 0x2521331 VA: 0x2521230
	|-Array.InternalArray__ICollection_Contains<MonsterBehaviorDataTable>
	|
	|-RVA: 0x25213F0 Offset: 0x25214F1 VA: 0x25213F0
	|-Array.InternalArray__ICollection_Contains<MonsterDataTable>
	|
	|-RVA: 0x25215F0 Offset: 0x25216F1 VA: 0x25215F0
	|-Array.InternalArray__ICollection_Contains<MonsterDropItemDataTable>
	|
	|-RVA: 0x25217B0 Offset: 0x25218B1 VA: 0x25217B0
	|-Array.InternalArray__ICollection_Contains<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x2521980 Offset: 0x2521A81 VA: 0x2521980
	|-Array.InternalArray__ICollection_Contains<MonsterHutSaveData>
	|
	|-RVA: 0x2521B50 Offset: 0x2521C51 VA: 0x2521B50
	|-Array.InternalArray__ICollection_Contains<MonsterUIData.Data>
	|
	|-RVA: 0x2521D20 Offset: 0x2521E21 VA: 0x2521D20
	|-Array.InternalArray__ICollection_Contains<MonsterYieldItemDataTable>
	|
	|-RVA: 0x2521ED0 Offset: 0x2521FD1 VA: 0x2521ED0
	|-Array.InternalArray__ICollection_Contains<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x2522080 Offset: 0x2522181 VA: 0x2522080
	|-Array.InternalArray__ICollection_Contains<NPCActionData>
	|
	|-RVA: 0x2522270 Offset: 0x2522371 VA: 0x2522270
	|-Array.InternalArray__ICollection_Contains<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x2522420 Offset: 0x2522521 VA: 0x2522420
	|-Array.InternalArray__ICollection_Contains<NPCUIData.Data>
	|
	|-RVA: 0x25225D0 Offset: 0x25226D1 VA: 0x25225D0
	|-Array.InternalArray__ICollection_Contains<NpcPlaceSchedule>
	|
	|-RVA: 0x2522790 Offset: 0x2522891 VA: 0x2522790
	|-Array.InternalArray__ICollection_Contains<OrderLotterySaveParameter>
	|
	|-RVA: 0x2522950 Offset: 0x2522A51 VA: 0x2522950
	|-Array.InternalArray__ICollection_Contains<OrderSaveData>
	|
	|-RVA: 0x2522B20 Offset: 0x2522C21 VA: 0x2522B20
	|-Array.InternalArray__ICollection_Contains<OrderSaveParameter>
	|
	|-RVA: 0x2522CE0 Offset: 0x2522DE1 VA: 0x2522CE0
	|-Array.InternalArray__ICollection_Contains<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2522E90 Offset: 0x2522F91 VA: 0x2522E90
	|-Array.InternalArray__ICollection_Contains<Parameter>
	|
	|-RVA: 0x2523090 Offset: 0x2523191 VA: 0x2523090
	|-Array.InternalArray__ICollection_Contains<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x2523240 Offset: 0x2523341 VA: 0x2523240
	|-Array.InternalArray__ICollection_Contains<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x2523410 Offset: 0x2523511 VA: 0x2523410
	|-Array.InternalArray__ICollection_Contains<ShopCatalogPage>
	|
	|-RVA: 0x25235C0 Offset: 0x25236C1 VA: 0x25235C0
	|-Array.InternalArray__ICollection_Contains<ShopNpcTalk>
	|
	|-RVA: 0x2523790 Offset: 0x2523891 VA: 0x2523790
	|-Array.InternalArray__ICollection_Contains<SubtitleDataTable.Data>
	|
	|-RVA: 0x2523950 Offset: 0x2523A51 VA: 0x2523950
	|-Array.InternalArray__ICollection_Contains<SubtitleDataTable.DataList>
	|
	|-RVA: 0x2523B00 Offset: 0x2523C01 VA: 0x2523B00
	|-Array.InternalArray__ICollection_Contains<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x2523CC0 Offset: 0x2523DC1 VA: 0x2523CC0
	|-Array.InternalArray__ICollection_Contains<AnimationWarping.Warp>
	|
	|-RVA: 0x2523E90 Offset: 0x2523F91 VA: 0x2523E90
	|-Array.InternalArray__ICollection_Contains<GrounderQuadruped.Foot>
	|
	|-RVA: 0x2524060 Offset: 0x2524161 VA: 0x2524060
	|-Array.InternalArray__ICollection_Contains<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x2524230 Offset: 0x2524331 VA: 0x2524230
	|-Array.InternalArray__ICollection_Contains<ProfilerFrame>
	|
	|-RVA: 0x25243F0 Offset: 0x25244F1 VA: 0x25243F0
	|-Array.InternalArray__ICollection_Contains<NumberControl.ValueRange>
	|
	|-RVA: 0x25245A0 Offset: 0x25246A1 VA: 0x25245A0
	|-Array.InternalArray__ICollection_Contains<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x2524760 Offset: 0x2524861 VA: 0x2524760
	|-Array.InternalArray__ICollection_Contains<ResponsiveEnable.Entry>
	|
	|-RVA: 0x2524920 Offset: 0x2524A21 VA: 0x2524920
	|-Array.InternalArray__ICollection_Contains<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x2524AD0 Offset: 0x2524BD1 VA: 0x2524AD0
	|-Array.InternalArray__ICollection_Contains<ResponsiveResize.Element>
	|
	|-RVA: 0x2524C80 Offset: 0x2524D81 VA: 0x2524C80
	|-Array.InternalArray__ICollection_Contains<Schedule>
	|
	|-RVA: 0x2524E40 Offset: 0x2524F41 VA: 0x2524E40
	|-Array.InternalArray__ICollection_Contains<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x2524FF0 Offset: 0x25250F1 VA: 0x2524FF0
	|-Array.InternalArray__ICollection_Contains<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x25251B0 Offset: 0x25252B1 VA: 0x25251B0
	|-Array.InternalArray__ICollection_Contains<SpeedData>
	|
	|-RVA: 0x2525360 Offset: 0x2525461 VA: 0x2525360
	|-Array.InternalArray__ICollection_Contains<CurveSample>
	|
	|-RVA: 0x2525500 Offset: 0x2525601 VA: 0x2525500
	|-Array.InternalArray__ICollection_Contains<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x25256B0 Offset: 0x25257B1 VA: 0x25256B0
	|-Array.InternalArray__ICollection_Contains<StringFormatData.FormatData>
	|
	|-RVA: 0x2525860 Offset: 0x2525961 VA: 0x2525860
	|-Array.InternalArray__ICollection_Contains<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x2525A00 Offset: 0x2525B01 VA: 0x2525A00
	|-Array.InternalArray__ICollection_Contains<ArraySegment<byte>>
	|
	|-RVA: 0x2525BA0 Offset: 0x2525CA1 VA: 0x2525BA0
	|-Array.InternalArray__ICollection_Contains<ArraySegment<object>>
	|
	|-RVA: 0x2525D40 Offset: 0x2525E41 VA: 0x2525D40
	|-Array.InternalArray__ICollection_Contains<bool>
	|
	|-RVA: 0x2525EA0 Offset: 0x2525FA1 VA: 0x2525EA0
	|-Array.InternalArray__ICollection_Contains<byte>
	|
	|-RVA: 0x2526000 Offset: 0x2526101 VA: 0x2526000
	|-Array.InternalArray__ICollection_Contains<ByteEnum>
	|
	|-RVA: 0x25261A0 Offset: 0x25262A1 VA: 0x25261A0
	|-Array.InternalArray__ICollection_Contains<char>
	|
	|-RVA: 0x2526300 Offset: 0x2526401 VA: 0x2526300
	|-Array.InternalArray__ICollection_Contains<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x25264B0 Offset: 0x25265B1 VA: 0x25264B0
	|-Array.InternalArray__ICollection_Contains<DictionaryEntry>
	|
	|-RVA: 0x2526660 Offset: 0x2526761 VA: 0x2526660
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x2526820 Offset: 0x2526921 VA: 0x2526820
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x25269E0 Offset: 0x2526AE1 VA: 0x25269E0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x2526BB0 Offset: 0x2526CB1 VA: 0x2526BB0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x2526DB0 Offset: 0x2526EB1 VA: 0x2526DB0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x2526F80 Offset: 0x2527081 VA: 0x2526F80
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x2527140 Offset: 0x2527241 VA: 0x2527140
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x2527300 Offset: 0x2527401 VA: 0x2527300
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x25274F0 Offset: 0x25275F1 VA: 0x25274F0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x25276B0 Offset: 0x25277B1 VA: 0x25276B0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x25278A0 Offset: 0x25279A1 VA: 0x25278A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x2527A70 Offset: 0x2527B71 VA: 0x2527A70
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x2527C70 Offset: 0x2527D71 VA: 0x2527C70
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x2527E30 Offset: 0x2527F31 VA: 0x2527E30
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x2527FF0 Offset: 0x25280F1 VA: 0x2527FF0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x25281B0 Offset: 0x25282B1 VA: 0x25281B0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x2528370 Offset: 0x2528471 VA: 0x2528370
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x2528530 Offset: 0x2528631 VA: 0x2528530
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x25286F0 Offset: 0x25287F1 VA: 0x25286F0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x25288B0 Offset: 0x25289B1 VA: 0x25288B0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x2528AB0 Offset: 0x2528BB1 VA: 0x2528AB0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x2528C70 Offset: 0x2528D71 VA: 0x2528C70
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x2528E20 Offset: 0x2528F21 VA: 0x2528E20
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x2529020 Offset: 0x2529121 VA: 0x2529020
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x25291E0 Offset: 0x25292E1 VA: 0x25291E0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x2529390 Offset: 0x2529491 VA: 0x2529390
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x2529540 Offset: 0x2529641 VA: 0x2529540
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x25296F0 Offset: 0x25297F1 VA: 0x25296F0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x25298A0 Offset: 0x25299A1 VA: 0x25298A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x2529A60 Offset: 0x2529B61 VA: 0x2529A60
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x2529C20 Offset: 0x2529D21 VA: 0x2529C20
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x2529E10 Offset: 0x2529F11 VA: 0x2529E10
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x2529FD0 Offset: 0x252A0D1 VA: 0x2529FD0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x252A190 Offset: 0x252A291 VA: 0x252A190
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x252A350 Offset: 0x252A451 VA: 0x252A350
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x252A550 Offset: 0x252A651 VA: 0x252A550
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x252A740 Offset: 0x252A841 VA: 0x252A740
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x252A910 Offset: 0x252AA11 VA: 0x252A910
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x252AAC0 Offset: 0x252ABC1 VA: 0x252AAC0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x252AC80 Offset: 0x252AD81 VA: 0x252AC80
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x252AE30 Offset: 0x252AF31 VA: 0x252AE30
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x252AFE0 Offset: 0x252B0E1 VA: 0x252AFE0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x252B1A0 Offset: 0x252B2A1 VA: 0x252B1A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x252B350 Offset: 0x252B451 VA: 0x252B350
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x252B510 Offset: 0x252B611 VA: 0x252B510
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x252B6D0 Offset: 0x252B7D1 VA: 0x252B6D0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x252B890 Offset: 0x252B991 VA: 0x252B890
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x252BA50 Offset: 0x252BB51 VA: 0x252BA50
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x252BC10 Offset: 0x252BD11 VA: 0x252BC10
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x252BDD0 Offset: 0x252BED1 VA: 0x252BDD0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x252BFA0 Offset: 0x252C0A1 VA: 0x252BFA0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x252C170 Offset: 0x252C271 VA: 0x252C170
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x252C330 Offset: 0x252C431 VA: 0x252C330
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x252C500 Offset: 0x252C601 VA: 0x252C500
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x252C6C0 Offset: 0x252C7C1 VA: 0x252C6C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x252C890 Offset: 0x252C991 VA: 0x252C890
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x252CA60 Offset: 0x252CB61 VA: 0x252CA60
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x252CC20 Offset: 0x252CD21 VA: 0x252CC20
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x252CE30 Offset: 0x252CF31 VA: 0x252CE30
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x252D000 Offset: 0x252D101 VA: 0x252D000
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x252D1C0 Offset: 0x252D2C1 VA: 0x252D1C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x252D390 Offset: 0x252D491 VA: 0x252D390
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x252D560 Offset: 0x252D661 VA: 0x252D560
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x252D720 Offset: 0x252D821 VA: 0x252D720
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x252D8E0 Offset: 0x252D9E1 VA: 0x252D8E0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x252DAA0 Offset: 0x252DBA1 VA: 0x252DAA0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x252DC60 Offset: 0x252DD61 VA: 0x252DC60
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x252DE30 Offset: 0x252DF31 VA: 0x252DE30
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x252DFF0 Offset: 0x252E0F1 VA: 0x252DFF0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x252E1C0 Offset: 0x252E2C1 VA: 0x252E1C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x252E3C0 Offset: 0x252E4C1 VA: 0x252E3C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x252E590 Offset: 0x252E691 VA: 0x252E590
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x252E750 Offset: 0x252E851 VA: 0x252E750
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x252E910 Offset: 0x252EA11 VA: 0x252E910
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x252EB00 Offset: 0x252EC01 VA: 0x252EB00
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x252ECC0 Offset: 0x252EDC1 VA: 0x252ECC0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x252EEB0 Offset: 0x252EFB1 VA: 0x252EEB0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x252F080 Offset: 0x252F181 VA: 0x252F080
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x252F280 Offset: 0x252F381 VA: 0x252F280
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x252F440 Offset: 0x252F541 VA: 0x252F440
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x252F600 Offset: 0x252F701 VA: 0x252F600
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x252F7C0 Offset: 0x252F8C1 VA: 0x252F7C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x252F980 Offset: 0x252FA81 VA: 0x252F980
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x252FB40 Offset: 0x252FC41 VA: 0x252FB40
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x252FD00 Offset: 0x252FE01 VA: 0x252FD00
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x252FEC0 Offset: 0x252FFC1 VA: 0x252FEC0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x2530080 Offset: 0x2530181 VA: 0x2530080
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x2530240 Offset: 0x2530341 VA: 0x2530240
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x2530400 Offset: 0x2530501 VA: 0x2530400
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x25305C0 Offset: 0x25306C1 VA: 0x25305C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x2530780 Offset: 0x2530881 VA: 0x2530780
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x2530950 Offset: 0x2530A51 VA: 0x2530950
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x2530B20 Offset: 0x2530C21 VA: 0x2530B20
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x2530CE0 Offset: 0x2530DE1 VA: 0x2530CE0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x2530EB0 Offset: 0x2530FB1 VA: 0x2530EB0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x2531070 Offset: 0x2531171 VA: 0x2531070
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x2531240 Offset: 0x2531341 VA: 0x2531240
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x2531410 Offset: 0x2531511 VA: 0x2531410
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x25315D0 Offset: 0x25316D1 VA: 0x25315D0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x25317E0 Offset: 0x25318E1 VA: 0x25317E0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x25319B0 Offset: 0x2531AB1 VA: 0x25319B0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x2531B70 Offset: 0x2531C71 VA: 0x2531B70
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x2531D40 Offset: 0x2531E41 VA: 0x2531D40
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x2531F10 Offset: 0x2532011 VA: 0x2531F10
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x25320D0 Offset: 0x25321D1 VA: 0x25320D0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x2532290 Offset: 0x2532391 VA: 0x2532290
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x2532450 Offset: 0x2532551 VA: 0x2532450
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x2532610 Offset: 0x2532711 VA: 0x2532610
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x25327E0 Offset: 0x25328E1 VA: 0x25327E0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x25329A0 Offset: 0x2532AA1 VA: 0x25329A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x2532B60 Offset: 0x2532C61 VA: 0x2532B60
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x2532D20 Offset: 0x2532E21 VA: 0x2532D20
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x2532EE0 Offset: 0x2532FE1 VA: 0x2532EE0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x25330A0 Offset: 0x25331A1 VA: 0x25330A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x2533260 Offset: 0x2533361 VA: 0x2533260
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x2533420 Offset: 0x2533521 VA: 0x2533420
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x25335E0 Offset: 0x25336E1 VA: 0x25335E0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x25337B0 Offset: 0x25338B1 VA: 0x25337B0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x2533980 Offset: 0x2533A81 VA: 0x2533980
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x2533B50 Offset: 0x2533C51 VA: 0x2533B50
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x2533D10 Offset: 0x2533E11 VA: 0x2533D10
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x2533ED0 Offset: 0x2533FD1 VA: 0x2533ED0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x2534090 Offset: 0x2534191 VA: 0x2534090
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x2534260 Offset: 0x2534361 VA: 0x2534260
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x2534430 Offset: 0x2534531 VA: 0x2534430
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x25345F0 Offset: 0x25346F1 VA: 0x25345F0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x25347F0 Offset: 0x25348F1 VA: 0x25347F0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x25349B0 Offset: 0x2534AB1 VA: 0x25349B0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x2534B70 Offset: 0x2534C71 VA: 0x2534B70
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x2534D30 Offset: 0x2534E31 VA: 0x2534D30
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x2534EF0 Offset: 0x2534FF1 VA: 0x2534EF0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x25350B0 Offset: 0x25351B1 VA: 0x25350B0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2535280 Offset: 0x2535381 VA: 0x2535280
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x27A6440 Offset: 0x27A6541 VA: 0x27A6440
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x27A6600 Offset: 0x27A6701 VA: 0x27A6600
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x27A67C0 Offset: 0x27A68C1 VA: 0x27A67C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x27A6980 Offset: 0x27A6A81 VA: 0x27A6980
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x27A6B40 Offset: 0x27A6C41 VA: 0x27A6B40
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x27A6D00 Offset: 0x27A6E01 VA: 0x27A6D00
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x27A6EC0 Offset: 0x27A6FC1 VA: 0x27A6EC0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x27A7080 Offset: 0x27A7181 VA: 0x27A7080
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x27A7240 Offset: 0x27A7341 VA: 0x27A7240
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x27A7460 Offset: 0x27A7561 VA: 0x27A7460
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x27A7620 Offset: 0x27A7721 VA: 0x27A7620
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x27A77E0 Offset: 0x27A78E1 VA: 0x27A77E0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x27A7990 Offset: 0x27A7A91 VA: 0x27A7990
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x27A7B40 Offset: 0x27A7C41 VA: 0x27A7B40
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x27A7D00 Offset: 0x27A7E01 VA: 0x27A7D00
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x27A7EC0 Offset: 0x27A7FC1 VA: 0x27A7EC0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x27A8080 Offset: 0x27A8181 VA: 0x27A8080
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x27A8270 Offset: 0x27A8371 VA: 0x27A8270
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x27A8460 Offset: 0x27A8561 VA: 0x27A8460
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x27A8640 Offset: 0x27A8741 VA: 0x27A8640
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x27A8800 Offset: 0x27A8901 VA: 0x27A8800
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x27A89C0 Offset: 0x27A8AC1 VA: 0x27A89C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x27A8B90 Offset: 0x27A8C91 VA: 0x27A8B90
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x27A8D60 Offset: 0x27A8E61 VA: 0x27A8D60
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x27A8F20 Offset: 0x27A9021 VA: 0x27A8F20
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x27A90E0 Offset: 0x27A91E1 VA: 0x27A90E0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x27A92A0 Offset: 0x27A93A1 VA: 0x27A92A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x27A9460 Offset: 0x27A9561 VA: 0x27A9460
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x27A9630 Offset: 0x27A9731 VA: 0x27A9630
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x27A9800 Offset: 0x27A9901 VA: 0x27A9800
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x27A99C0 Offset: 0x27A9AC1 VA: 0x27A99C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x27A9BC0 Offset: 0x27A9CC1 VA: 0x27A9BC0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x27A9D80 Offset: 0x27A9E81 VA: 0x27A9D80
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x27A9F40 Offset: 0x27AA041 VA: 0x27A9F40
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x27AA100 Offset: 0x27AA201 VA: 0x27AA100
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x27AA2C0 Offset: 0x27AA3C1 VA: 0x27AA2C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x27AA480 Offset: 0x27AA581 VA: 0x27AA480
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x27AA640 Offset: 0x27AA741 VA: 0x27AA640
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x27AA800 Offset: 0x27AA901 VA: 0x27AA800
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x27AA9C0 Offset: 0x27AAAC1 VA: 0x27AA9C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x27AAB80 Offset: 0x27AAC81 VA: 0x27AAB80
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x27AAD40 Offset: 0x27AAE41 VA: 0x27AAD40
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x27AAF00 Offset: 0x27AB001 VA: 0x27AAF00
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x27AB0C0 Offset: 0x27AB1C1 VA: 0x27AB0C0
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<int>>
	|
	|-RVA: 0x27AB280 Offset: 0x27AB381 VA: 0x27AB280
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x27AB440 Offset: 0x27AB541 VA: 0x27AB440
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<object>>
	|
	|-RVA: 0x27AB5F0 Offset: 0x27AB6F1 VA: 0x27AB5F0
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<uint>>
	|
	|-RVA: 0x27AB7B0 Offset: 0x27AB8B1 VA: 0x27AB7B0
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<Edge>>
	|
	|-RVA: 0x27AB960 Offset: 0x27ABA61 VA: 0x27AB960
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x27ABB20 Offset: 0x27ABC21 VA: 0x27ABB20
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x27ABCE0 Offset: 0x27ABDE1 VA: 0x27ABCE0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x27ABE90 Offset: 0x27ABF91 VA: 0x27ABE90
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x27AC050 Offset: 0x27AC151 VA: 0x27AC050
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x27AC240 Offset: 0x27AC341 VA: 0x27AC240
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x27AC400 Offset: 0x27AC501 VA: 0x27AC400
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x27AC5C0 Offset: 0x27AC6C1 VA: 0x27AC5C0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x27AC780 Offset: 0x27AC881 VA: 0x27AC780
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x27AC950 Offset: 0x27ACA51 VA: 0x27AC950
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x27ACB10 Offset: 0x27ACC11 VA: 0x27ACB10
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x27ACCE0 Offset: 0x27ACDE1 VA: 0x27ACCE0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x27ACEB0 Offset: 0x27ACFB1 VA: 0x27ACEB0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x27AD0B0 Offset: 0x27AD1B1 VA: 0x27AD0B0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<bool, object>>
	|
	|-RVA: 0x27AD260 Offset: 0x27AD361 VA: 0x27AD260
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<byte, object>>
	|
	|-RVA: 0x27AD410 Offset: 0x27AD511 VA: 0x27AD410
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<char, object>>
	|
	|-RVA: 0x27AD5C0 Offset: 0x27AD6C1 VA: 0x27AD5C0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x27AD770 Offset: 0x27AD871 VA: 0x27AD770
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<double, object>>
	|
	|-RVA: 0x27AD920 Offset: 0x27ADA21 VA: 0x27AD920
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x27ADAE0 Offset: 0x27ADBE1 VA: 0x27ADAE0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<short, object>>
	|
	|-RVA: 0x27ADC90 Offset: 0x27ADD91 VA: 0x27ADC90
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x27ADE90 Offset: 0x27ADF91 VA: 0x27ADE90
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x27AE050 Offset: 0x27AE151 VA: 0x27AE050
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x27AE200 Offset: 0x27AE301 VA: 0x27AE200
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x27AE400 Offset: 0x27AE501 VA: 0x27AE400
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x27AE5C0 Offset: 0x27AE6C1 VA: 0x27AE5C0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, bool>>
	|
	|-RVA: 0x27AE770 Offset: 0x27AE871 VA: 0x27AE770
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, char>>
	|
	|-RVA: 0x27AE920 Offset: 0x27AEA21 VA: 0x27AE920
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, int>>
	|
	|-RVA: 0x27AEAD0 Offset: 0x27AEBD1 VA: 0x27AEAD0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x27AEC80 Offset: 0x27AED81 VA: 0x27AEC80
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, long>>
	|
	|-RVA: 0x27AEE30 Offset: 0x27AEF31 VA: 0x27AEE30
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, object>>
	|
	|-RVA: 0x27AEFE0 Offset: 0x27AF0E1 VA: 0x27AEFE0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x27AF1D0 Offset: 0x27AF2D1 VA: 0x27AF1D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x27AF390 Offset: 0x27AF491 VA: 0x27AF390
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x27AF550 Offset: 0x27AF651 VA: 0x27AF550
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x27AF700 Offset: 0x27AF801 VA: 0x27AF700
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x27AF900 Offset: 0x27AFA01 VA: 0x27AF900
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x27AFAF0 Offset: 0x27AFBF1 VA: 0x27AFAF0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x27AFCB0 Offset: 0x27AFDB1 VA: 0x27AFCB0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x27AFE60 Offset: 0x27AFF61 VA: 0x27AFE60
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x27B0020 Offset: 0x27B0121 VA: 0x27B0020
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x27B01D0 Offset: 0x27B02D1 VA: 0x27B01D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x27B0380 Offset: 0x27B0481 VA: 0x27B0380
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x27B0530 Offset: 0x27B0631 VA: 0x27B0530
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x27B06E0 Offset: 0x27B07E1 VA: 0x27B06E0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x27B08A0 Offset: 0x27B09A1 VA: 0x27B08A0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x27B0A60 Offset: 0x27B0B61 VA: 0x27B0A60
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x27B0C10 Offset: 0x27B0D11 VA: 0x27B0C10
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<long, object>>
	|
	|-RVA: 0x27B0DC0 Offset: 0x27B0EC1 VA: 0x27B0DC0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x27B0F80 Offset: 0x27B1081 VA: 0x27B0F80
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x27B1130 Offset: 0x27B1231 VA: 0x27B1130
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x27B1300 Offset: 0x27B1401 VA: 0x27B1300
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x27B14D0 Offset: 0x27B15D1 VA: 0x27B14D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x27B1680 Offset: 0x27B1781 VA: 0x27B1680
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x27B1840 Offset: 0x27B1941 VA: 0x27B1840
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x27B1A00 Offset: 0x27B1B01 VA: 0x27B1A00
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x27B1BC0 Offset: 0x27B1CC1 VA: 0x27B1BC0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x27B1D90 Offset: 0x27B1E91 VA: 0x27B1D90
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x27B1F40 Offset: 0x27B2041 VA: 0x27B1F40
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x27B2140 Offset: 0x27B2241 VA: 0x27B2140
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x27B2300 Offset: 0x27B2401 VA: 0x27B2300
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x27B24C0 Offset: 0x27B25C1 VA: 0x27B24C0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x27B2680 Offset: 0x27B2781 VA: 0x27B2680
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x27B2840 Offset: 0x27B2941 VA: 0x27B2840
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x27B2A00 Offset: 0x27B2B01 VA: 0x27B2A00
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x27B2BC0 Offset: 0x27B2CC1 VA: 0x27B2BC0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x27B2D80 Offset: 0x27B2E81 VA: 0x27B2D80
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x27B2F40 Offset: 0x27B3041 VA: 0x27B2F40
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x27B3100 Offset: 0x27B3201 VA: 0x27B3100
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x27B32B0 Offset: 0x27B33B1 VA: 0x27B32B0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x27B3470 Offset: 0x27B3571 VA: 0x27B3470
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x27B3660 Offset: 0x27B3761 VA: 0x27B3660
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x27B3820 Offset: 0x27B3921 VA: 0x27B3820
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x27B39E0 Offset: 0x27B3AE1 VA: 0x27B39E0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x27B3BA0 Offset: 0x27B3CA1 VA: 0x27B3BA0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x27B3D70 Offset: 0x27B3E71 VA: 0x27B3D70
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x27B3F30 Offset: 0x27B4031 VA: 0x27B3F30
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x27B4100 Offset: 0x27B4201 VA: 0x27B4100
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x27B42D0 Offset: 0x27B43D1 VA: 0x27B42D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x27B44D0 Offset: 0x27B45D1 VA: 0x27B44D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x27B4690 Offset: 0x27B4791 VA: 0x27B4690
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, bool>>
	|
	|-RVA: 0x27B4840 Offset: 0x27B4941 VA: 0x27B4840
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, byte>>
	|
	|-RVA: 0x27B49F0 Offset: 0x27B4AF1 VA: 0x27B49F0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, char>>
	|
	|-RVA: 0x27B4BA0 Offset: 0x27B4CA1 VA: 0x27B4BA0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x27B4D50 Offset: 0x27B4E51 VA: 0x27B4D50
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, double>>
	|
	|-RVA: 0x27B4F00 Offset: 0x27B5001 VA: 0x27B4F00
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, short>>
	|
	|-RVA: 0x27B50B0 Offset: 0x27B51B1 VA: 0x27B50B0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, int>>
	|
	|-RVA: 0x27B5260 Offset: 0x27B5361 VA: 0x27B5260
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x27B5410 Offset: 0x27B5511 VA: 0x27B5410
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, long>>
	|
	|-RVA: 0x27B55C0 Offset: 0x27B56C1 VA: 0x27B55C0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x27B5780 Offset: 0x27B5881 VA: 0x27B5780
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x27B5930 Offset: 0x27B5A31 VA: 0x27B5930
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x27B5B00 Offset: 0x27B5C01 VA: 0x27B5B00
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x27B5CD0 Offset: 0x27B5DD1 VA: 0x27B5CD0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x27B5E80 Offset: 0x27B5F81 VA: 0x27B5E80
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x27B6040 Offset: 0x27B6141 VA: 0x27B6040
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x27B6200 Offset: 0x27B6301 VA: 0x27B6200
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x27B63C0 Offset: 0x27B64C1 VA: 0x27B63C0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x27B6590 Offset: 0x27B6691 VA: 0x27B6590
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x27B6740 Offset: 0x27B6841 VA: 0x27B6740
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x27B6940 Offset: 0x27B6A41 VA: 0x27B6940
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x27B6B00 Offset: 0x27B6C01 VA: 0x27B6B00
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x27B6CC0 Offset: 0x27B6DC1 VA: 0x27B6CC0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x27B6E80 Offset: 0x27B6F81 VA: 0x27B6E80
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x27B7040 Offset: 0x27B7141 VA: 0x27B7040
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x27B7200 Offset: 0x27B7301 VA: 0x27B7200
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x27B73C0 Offset: 0x27B74C1 VA: 0x27B73C0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x27B7580 Offset: 0x27B7681 VA: 0x27B7580
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x27B7740 Offset: 0x27B7841 VA: 0x27B7740
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x27B7900 Offset: 0x27B7A01 VA: 0x27B7900
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, object>>
	|
	|-RVA: 0x27B7AB0 Offset: 0x27B7BB1 VA: 0x27B7AB0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x27B7C70 Offset: 0x27B7D71 VA: 0x27B7C70
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x27B7E30 Offset: 0x27B7F31 VA: 0x27B7E30
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x27B7FE0 Offset: 0x27B80E1 VA: 0x27B7FE0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, float>>
	|
	|-RVA: 0x27B8190 Offset: 0x27B8291 VA: 0x27B8190
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x27B8340 Offset: 0x27B8441 VA: 0x27B8340
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, uint>>
	|
	|-RVA: 0x27B84F0 Offset: 0x27B85F1 VA: 0x27B84F0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x27B86A0 Offset: 0x27B87A1 VA: 0x27B86A0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x27B8870 Offset: 0x27B8971 VA: 0x27B8870
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x27B8A30 Offset: 0x27B8B31 VA: 0x27B8A30
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x27B8BF0 Offset: 0x27B8CF1 VA: 0x27B8BF0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x27B8DA0 Offset: 0x27B8EA1 VA: 0x27B8DA0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Color>>
	|
	|-RVA: 0x27B8F60 Offset: 0x27B9061 VA: 0x27B8F60
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x27B9110 Offset: 0x27B9211 VA: 0x27B9110
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x27B92D0 Offset: 0x27B93D1 VA: 0x27B92D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x27B94A0 Offset: 0x27B95A1 VA: 0x27B94A0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x27B9650 Offset: 0x27B9751 VA: 0x27B9650
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x27B9850 Offset: 0x27B9951 VA: 0x27B9850
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x27B9A10 Offset: 0x27B9B11 VA: 0x27B9A10
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x27B9BD0 Offset: 0x27B9CD1 VA: 0x27B9BD0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x27B9D80 Offset: 0x27B9E81 VA: 0x27B9D80
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x27B9F40 Offset: 0x27BA041 VA: 0x27B9F40
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x27BA100 Offset: 0x27BA201 VA: 0x27BA100
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x27BA2C0 Offset: 0x27BA3C1 VA: 0x27BA2C0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x27BA480 Offset: 0x27BA581 VA: 0x27BA480
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x27BA630 Offset: 0x27BA731 VA: 0x27BA630
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x27BA7E0 Offset: 0x27BA8E1 VA: 0x27BA7E0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x27BA9A0 Offset: 0x27BAAA1 VA: 0x27BA9A0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x27BAB60 Offset: 0x27BAC61 VA: 0x27BAB60
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x27BAD20 Offset: 0x27BAE21 VA: 0x27BAD20
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x27BAEE0 Offset: 0x27BAFE1 VA: 0x27BAEE0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x27BB090 Offset: 0x27BB191 VA: 0x27BB090
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x27BB240 Offset: 0x27BB341 VA: 0x27BB240
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x27BB450 Offset: 0x27BB551 VA: 0x27BB450
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<float, object>>
	|
	|-RVA: 0x27BB600 Offset: 0x27BB701 VA: 0x27BB600
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x27BB7B0 Offset: 0x27BB8B1 VA: 0x27BB7B0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, int>>
	|
	|-RVA: 0x27BB960 Offset: 0x27BBA61 VA: 0x27BB960
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x27BBB10 Offset: 0x27BBC11 VA: 0x27BBB10
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, object>>
	|
	|-RVA: 0x27BBCC0 Offset: 0x27BBDC1 VA: 0x27BBCC0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x27BBE70 Offset: 0x27BBF71 VA: 0x27BBE70
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x27BC030 Offset: 0x27BC131 VA: 0x27BC030
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x27BC220 Offset: 0x27BC321 VA: 0x27BC220
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x27BC410 Offset: 0x27BC511 VA: 0x27BC410
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x27BC5E0 Offset: 0x27BC6E1 VA: 0x27BC5E0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x27BC7A0 Offset: 0x27BC8A1 VA: 0x27BC7A0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x27BC950 Offset: 0x27BCA51 VA: 0x27BC950
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x27BCB10 Offset: 0x27BCC11 VA: 0x27BCB10
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x27BCCD0 Offset: 0x27BCDD1 VA: 0x27BCCD0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Color, object>>
	|
	|-RVA: 0x27BCE90 Offset: 0x27BCF91 VA: 0x27BCE90
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x27BD040 Offset: 0x27BD141 VA: 0x27BD040
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x27BD1F0 Offset: 0x27BD2F1 VA: 0x27BD1F0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x27BD3A0 Offset: 0x27BD4A1 VA: 0x27BD3A0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x27BD560 Offset: 0x27BD661 VA: 0x27BD560
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x27BD730 Offset: 0x27BD831 VA: 0x27BD730
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x27BD8E0 Offset: 0x27BD9E1 VA: 0x27BD8E0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x27BDAE0 Offset: 0x27BDBE1 VA: 0x27BDAE0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x27BDCA0 Offset: 0x27BDDA1 VA: 0x27BDCA0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x27BDE60 Offset: 0x27BDF61 VA: 0x27BDE60
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x27BE010 Offset: 0x27BE111 VA: 0x27BE010
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x27BE1D0 Offset: 0x27BE2D1 VA: 0x27BE1D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x27BE390 Offset: 0x27BE491 VA: 0x27BE390
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x27BE550 Offset: 0x27BE651 VA: 0x27BE550
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x27BE700 Offset: 0x27BE801 VA: 0x27BE700
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x27BE8B0 Offset: 0x27BE9B1 VA: 0x27BE8B0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x27BEA60 Offset: 0x27BEB61 VA: 0x27BEA60
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x27BEC20 Offset: 0x27BED21 VA: 0x27BEC20
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x27BEDE0 Offset: 0x27BEEE1 VA: 0x27BEDE0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x27BEFA0 Offset: 0x27BF0A1 VA: 0x27BEFA0
	|-Array.InternalArray__ICollection_Contains<Hashtable.bucket>
	|
	|-RVA: 0x27BF160 Offset: 0x27BF261 VA: 0x27BF160
	|-Array.InternalArray__ICollection_Contains<DateTime>
	|
	|-RVA: 0x27BF2C0 Offset: 0x27BF3C1 VA: 0x27BF2C0
	|-Array.InternalArray__ICollection_Contains<DateTimeOffset>
	|
	|-RVA: 0x27BF420 Offset: 0x27BF521 VA: 0x27BF420
	|-Array.InternalArray__ICollection_Contains<Decimal>
	|
	|-RVA: 0x27BF580 Offset: 0x27BF681 VA: 0x27BF580
	|-Array.InternalArray__ICollection_Contains<double>
	|
	|-RVA: 0x27BF6E0 Offset: 0x27BF7E1 VA: 0x27BF6E0
	|-Array.InternalArray__ICollection_Contains<InternalCodePageDataItem>
	|
	|-RVA: 0x27BF890 Offset: 0x27BF991 VA: 0x27BF890
	|-Array.InternalArray__ICollection_Contains<InternalEncodingDataItem>
	|
	|-RVA: 0x27BFA40 Offset: 0x27BFB41 VA: 0x27BFA40
	|-Array.InternalArray__ICollection_Contains<Guid>
	|
	|-RVA: 0x27BFBA0 Offset: 0x27BFCA1 VA: 0x27BFBA0
	|-Array.InternalArray__ICollection_Contains<short>
	|
	|-RVA: 0x27BFD00 Offset: 0x27BFE01 VA: 0x27BFD00
	|-Array.InternalArray__ICollection_Contains<int>
	|
	|-RVA: 0x27BFE60 Offset: 0x27BFF61 VA: 0x27BFE60
	|-Array.InternalArray__ICollection_Contains<Int32Enum>
	|
	|-RVA: 0x27C0000 Offset: 0x27C0101 VA: 0x27C0000
	|-Array.InternalArray__ICollection_Contains<long>
	|
	|-RVA: 0x27C0160 Offset: 0x27C0261 VA: 0x27C0160
	|-Array.InternalArray__ICollection_Contains<IntPtr>
	|
	|-RVA: 0x27C02C0 Offset: 0x27C03C1 VA: 0x27C02C0
	|-Array.InternalArray__ICollection_Contains<InterpretedFrameInfo>
	|
	|-RVA: 0x27C0470 Offset: 0x27C0571 VA: 0x27C0470
	|-Array.InternalArray__ICollection_Contains<LocalDefinition>
	|
	|-RVA: 0x27C05D0 Offset: 0x27C06D1 VA: 0x27C05D0
	|-Array.InternalArray__ICollection_Contains<RuntimeLabel>
	|
	|-RVA: 0x27C0790 Offset: 0x27C0891 VA: 0x27C0790
	|-Array.InternalArray__ICollection_Contains<Set.Slot<int>>
	|
	|-RVA: 0x27C0950 Offset: 0x27C0A51 VA: 0x27C0950
	|-Array.InternalArray__ICollection_Contains<Set.Slot<object>>
	|
	|-RVA: 0x27C0B10 Offset: 0x27C0C11 VA: 0x27C0B10
	|-Array.InternalArray__ICollection_Contains<Memory<object>>
	|
	|-RVA: 0x27C0CB0 Offset: 0x27C0DB1 VA: 0x27C0CB0
	|-Array.InternalArray__ICollection_Contains<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x27C0E60 Offset: 0x27C0F61 VA: 0x27C0E60
	|-Array.InternalArray__ICollection_Contains<HeaderVariantInfo>
	|
	|-RVA: 0x27C1010 Offset: 0x27C1111 VA: 0x27C1010
	|-Array.InternalArray__ICollection_Contains<Socket.WSABUF>
	|
	|-RVA: 0x27C11C0 Offset: 0x27C12C1 VA: 0x27C11C0
	|-Array.InternalArray__ICollection_Contains<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x27C1430 Offset: 0x27C1531 VA: 0x27C1430
	|-Array.InternalArray__ICollection_Contains<Nullable<Int32Enum>>
	|
	|-RVA: 0x27C1630 Offset: 0x27C1731 VA: 0x27C1630
	|-Array.InternalArray__ICollection_Contains<Nullable<Bounds>>
	|
	|-RVA: 0x27C18A0 Offset: 0x27C19A1 VA: 0x27C18A0
	|-Array.InternalArray__ICollection_Contains<Nullable<BoundsInt>>
	|
	|-RVA: 0x27C1B10 Offset: 0x27C1C11 VA: 0x27C1B10
	|-Array.InternalArray__ICollection_Contains<Nullable<Color32>>
	|
	|-RVA: 0x27C1D10 Offset: 0x27C1E11 VA: 0x27C1D10
	|-Array.InternalArray__ICollection_Contains<Nullable<Color>>
	|
	|-RVA: 0x27C1F50 Offset: 0x27C2051 VA: 0x27C1F50
	|-Array.InternalArray__ICollection_Contains<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x27C2180 Offset: 0x27C2281 VA: 0x27C2180
	|-Array.InternalArray__ICollection_Contains<Nullable<GradientColorKey>>
	|
	|-RVA: 0x27C23C0 Offset: 0x27C24C1 VA: 0x27C23C0
	|-Array.InternalArray__ICollection_Contains<Nullable<Keyframe>>
	|
	|-RVA: 0x27C2600 Offset: 0x27C2701 VA: 0x27C2600
	|-Array.InternalArray__ICollection_Contains<Nullable<LayerMask>>
	|
	|-RVA: 0x27C2800 Offset: 0x27C2901 VA: 0x27C2800
	|-Array.InternalArray__ICollection_Contains<Nullable<Matrix4x4>>
	|
	|-RVA: 0x27C2AE0 Offset: 0x27C2BE1 VA: 0x27C2AE0
	|-Array.InternalArray__ICollection_Contains<Nullable<Quaternion>>
	|
	|-RVA: 0x27C2D20 Offset: 0x27C2E21 VA: 0x27C2D20
	|-Array.InternalArray__ICollection_Contains<Nullable<RangeInt>>
	|
	|-RVA: 0x27C2F50 Offset: 0x27C3051 VA: 0x27C2F50
	|-Array.InternalArray__ICollection_Contains<Nullable<Rect>>
	|
	|-RVA: 0x27C3190 Offset: 0x27C3291 VA: 0x27C3190
	|-Array.InternalArray__ICollection_Contains<Nullable<RectInt>>
	|
	|-RVA: 0x27C33D0 Offset: 0x27C34D1 VA: 0x27C33D0
	|-Array.InternalArray__ICollection_Contains<Nullable<Vector2>>
	|
	|-RVA: 0x27C3600 Offset: 0x27C3701 VA: 0x27C3600
	|-Array.InternalArray__ICollection_Contains<Nullable<Vector2Int>>
	|
	|-RVA: 0x27C3830 Offset: 0x27C3931 VA: 0x27C3830
	|-Array.InternalArray__ICollection_Contains<Nullable<Vector3>>
	|
	|-RVA: 0x27C3A40 Offset: 0x27C3B41 VA: 0x27C3A40
	|-Array.InternalArray__ICollection_Contains<Nullable<Vector3Int>>
	|
	|-RVA: 0x27C3C50 Offset: 0x27C3D51 VA: 0x27C3C50
	|-Array.InternalArray__ICollection_Contains<Nullable<Vector4>>
	|
	|-RVA: 0x27C3E90 Offset: 0x27C3F91 VA: 0x27C3E90
	|-Array.InternalArray__ICollection_Contains<object>
	|
	|-RVA: 0x27C3FF0 Offset: 0x27C40F1 VA: 0x27C3FF0
	|-Array.InternalArray__ICollection_Contains<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x27C41A0 Offset: 0x27C42A1 VA: 0x27C41A0
	|-Array.InternalArray__ICollection_Contains<ReadOnlyMemory<object>>
	|
	|-RVA: 0x27C4340 Offset: 0x27C4441 VA: 0x27C4340
	|-Array.InternalArray__ICollection_Contains<CustomAttributeNamedArgument>
	|
	|-RVA: 0x27C44B0 Offset: 0x27C45B1 VA: 0x27C44B0
	|-Array.InternalArray__ICollection_Contains<CustomAttributeTypedArgument>
	|
	|-RVA: 0x27C4610 Offset: 0x27C4711 VA: 0x27C4610
	|-Array.InternalArray__ICollection_Contains<Label>
	|
	|-RVA: 0x27C4770 Offset: 0x27C4871 VA: 0x27C4770
	|-Array.InternalArray__ICollection_Contains<ParameterModifier>
	|
	|-RVA: 0x27C4920 Offset: 0x27C4A21 VA: 0x27C4920
	|-Array.InternalArray__ICollection_Contains<ResourceLocator>
	|
	|-RVA: 0x27C4AD0 Offset: 0x27C4BD1 VA: 0x27C4AD0
	|-Array.InternalArray__ICollection_Contains<Ephemeron>
	|
	|-RVA: 0x27C4C80 Offset: 0x27C4D81 VA: 0x27C4C80
	|-Array.InternalArray__ICollection_Contains<GCHandle>
	|
	|-RVA: 0x27C4DE0 Offset: 0x27C4EE1 VA: 0x27C4DE0
	|-Array.InternalArray__ICollection_Contains<RuntimeTypeHandle>
	|
	|-RVA: 0x27C4F40 Offset: 0x27C5041 VA: 0x27C4F40
	|-Array.InternalArray__ICollection_Contains<sbyte>
	|
	|-RVA: 0x27C50A0 Offset: 0x27C51A1 VA: 0x27C50A0
	|-Array.InternalArray__ICollection_Contains<X509ChainStatus>
	|
	|-RVA: 0x27C5250 Offset: 0x27C5351 VA: 0x27C5250
	|-Array.InternalArray__ICollection_Contains<float>
	|
	|-RVA: 0x27C53B0 Offset: 0x27C54B1 VA: 0x27C53B0
	|-Array.InternalArray__ICollection_Contains<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x27C5570 Offset: 0x27C5671 VA: 0x27C5570
	|-Array.InternalArray__ICollection_Contains<CancellationTokenRegistration>
	|
	|-RVA: 0x27C56E0 Offset: 0x27C57E1 VA: 0x27C56E0
	|-Array.InternalArray__ICollection_Contains<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x27C5890 Offset: 0x27C5991 VA: 0x27C5890
	|-Array.InternalArray__ICollection_Contains<TimeSpan>
	|
	|-RVA: 0x27C59F0 Offset: 0x27C5AF1 VA: 0x27C59F0
	|-Array.InternalArray__ICollection_Contains<ushort>
	|
	|-RVA: 0x27C5B50 Offset: 0x27C5C51 VA: 0x27C5B50
	|-Array.InternalArray__ICollection_Contains<UInt16Enum>
	|
	|-RVA: 0x27C5CF0 Offset: 0x27C5DF1 VA: 0x27C5CF0
	|-Array.InternalArray__ICollection_Contains<uint>
	|
	|-RVA: 0x27C5E50 Offset: 0x27C5F51 VA: 0x27C5E50
	|-Array.InternalArray__ICollection_Contains<UInt32Enum>
	|
	|-RVA: 0x27C5FF0 Offset: 0x27C60F1 VA: 0x27C5FF0
	|-Array.InternalArray__ICollection_Contains<ulong>
	|
	|-RVA: 0x27C6150 Offset: 0x27C6251 VA: 0x27C6150
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x27C62F0 Offset: 0x27C63F1 VA: 0x27C62F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x27C6490 Offset: 0x27C6591 VA: 0x27C6490
	|-Array.InternalArray__ICollection_Contains<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x27C6630 Offset: 0x27C6731 VA: 0x27C6630
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x27C67D0 Offset: 0x27C68D1 VA: 0x27C67D0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object>>
	|
	|-RVA: 0x27C6970 Offset: 0x27C6A71 VA: 0x27C6970
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, float>>
	|
	|-RVA: 0x27C6B10 Offset: 0x27C6C11 VA: 0x27C6B10
	|-Array.InternalArray__ICollection_Contains<ValueTuple<float, object>>
	|
	|-RVA: 0x27C6CB0 Offset: 0x27C6DB1 VA: 0x27C6CB0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<float, float>>
	|
	|-RVA: 0x27C6E60 Offset: 0x27C6F61 VA: 0x27C6E60
	|-Array.InternalArray__ICollection_Contains<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x27C7040 Offset: 0x27C7141 VA: 0x27C7040
	|-Array.InternalArray__ICollection_Contains<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x27C71F0 Offset: 0x27C72F1 VA: 0x27C71F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x27C73C0 Offset: 0x27C74C1 VA: 0x27C73C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x27C7590 Offset: 0x27C7691 VA: 0x27C7590
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x27C7790 Offset: 0x27C7891 VA: 0x27C7790
	|-Array.InternalArray__ICollection_Contains<HighlightState>
	|
	|-RVA: 0x27C7900 Offset: 0x27C7A01 VA: 0x27C7900
	|-Array.InternalArray__ICollection_Contains<MaterialReference>
	|
	|-RVA: 0x27C7AF0 Offset: 0x27C7BF1 VA: 0x27C7AF0
	|-Array.InternalArray__ICollection_Contains<RichTextTagAttribute>
	|
	|-RVA: 0x27C7CB0 Offset: 0x27C7DB1 VA: 0x27C7CB0
	|-Array.InternalArray__ICollection_Contains<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x27C7EA0 Offset: 0x27C7FA1 VA: 0x27C7EA0
	|-Array.InternalArray__ICollection_Contains<TMP_CharacterInfo>
	|
	|-RVA: 0x27C8070 Offset: 0x27C8171 VA: 0x27C8070
	|-Array.InternalArray__ICollection_Contains<TMP_FontWeightPair>
	|
	|-RVA: 0x27C8220 Offset: 0x27C8321 VA: 0x27C8220
	|-Array.InternalArray__ICollection_Contains<TMP_LineInfo>
	|
	|-RVA: 0x27C8450 Offset: 0x27C8551 VA: 0x27C8450
	|-Array.InternalArray__ICollection_Contains<TMP_LinkInfo>
	|
	|-RVA: 0x27C8620 Offset: 0x27C8721 VA: 0x27C8620
	|-Array.InternalArray__ICollection_Contains<TMP_MeshInfo>
	|
	|-RVA: 0x27C8820 Offset: 0x27C8921 VA: 0x27C8820
	|-Array.InternalArray__ICollection_Contains<TMP_PageInfo>
	|
	|-RVA: 0x21E23A0 Offset: 0x21E24A1 VA: 0x21E23A0
	|-Array.InternalArray__ICollection_Contains<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x21E2560 Offset: 0x21E2661 VA: 0x21E2560
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x21E2720 Offset: 0x21E2821 VA: 0x21E2720
	|-Array.InternalArray__ICollection_Contains<TMP_WordInfo>
	|
	|-RVA: 0x21E28E0 Offset: 0x21E29E1 VA: 0x21E28E0
	|-Array.InternalArray__ICollection_Contains<WordWrapState>
	|
	|-RVA: 0x21E2AB0 Offset: 0x21E2BB1 VA: 0x21E2AB0
	|-Array.InternalArray__ICollection_Contains<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x21E2C80 Offset: 0x21E2D81 VA: 0x21E2C80
	|-Array.InternalArray__ICollection_Contains<TransitionTables>
	|
	|-RVA: 0x21E2E40 Offset: 0x21E2F41 VA: 0x21E2E40
	|-Array.InternalArray__ICollection_Contains<TutorialUnlockFlagData>
	|
	|-RVA: 0x21E3000 Offset: 0x21E3101 VA: 0x21E3000
	|-Array.InternalArray__ICollection_Contains<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x21E31B0 Offset: 0x21E32B1 VA: 0x21E31B0
	|-Array.InternalArray__ICollection_Contains<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x21E3360 Offset: 0x21E3461 VA: 0x21E3360
	|-Array.InternalArray__ICollection_Contains<CapEdge>
	|
	|-RVA: 0x21E3540 Offset: 0x21E3641 VA: 0x21E3540
	|-Array.InternalArray__ICollection_Contains<ClippedEdge>
	|
	|-RVA: 0x21E3700 Offset: 0x21E3801 VA: 0x21E3700
	|-Array.InternalArray__ICollection_Contains<EdgeKeyByHash>
	|
	|-RVA: 0x21E38B0 Offset: 0x21E39B1 VA: 0x21E38B0
	|-Array.InternalArray__ICollection_Contains<EdgeKeyByIndex>
	|
	|-RVA: 0x21E3A60 Offset: 0x21E3B61 VA: 0x21E3A60
	|-Array.InternalArray__ICollection_Contains<MeshDataConnectivity.Face>
	|
	|-RVA: 0x21E3C10 Offset: 0x21E3D11 VA: 0x21E3C10
	|-Array.InternalArray__ICollection_Contains<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x21E3DD0 Offset: 0x21E3ED1 VA: 0x21E3DD0
	|-Array.InternalArray__ICollection_Contains<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x21E3FA0 Offset: 0x21E40A1 VA: 0x21E3FA0
	|-Array.InternalArray__ICollection_Contains<NavMeshBuildMarkup>
	|
	|-RVA: 0x21E4150 Offset: 0x21E4251 VA: 0x21E4150
	|-Array.InternalArray__ICollection_Contains<NavMeshBuildSource>
	|
	|-RVA: 0x21E4380 Offset: 0x21E4481 VA: 0x21E4380
	|-Array.InternalArray__ICollection_Contains<ContentCatalogData.Bucket>
	|
	|-RVA: 0x21E4530 Offset: 0x21E4631 VA: 0x21E4530
	|-Array.InternalArray__ICollection_Contains<ConstraintSource>
	|
	|-RVA: 0x21E46E0 Offset: 0x21E47E1 VA: 0x21E46E0
	|-Array.InternalArray__ICollection_Contains<PropertySceneHandle>
	|
	|-RVA: 0x21E4890 Offset: 0x21E4991 VA: 0x21E4890
	|-Array.InternalArray__ICollection_Contains<TransformStreamHandle>
	|
	|-RVA: 0x21E4A50 Offset: 0x21E4B51 VA: 0x21E4A50
	|-Array.InternalArray__ICollection_Contains<AnimatorClipInfo>
	|
	|-RVA: 0x21E4C00 Offset: 0x21E4D01 VA: 0x21E4C00
	|-Array.InternalArray__ICollection_Contains<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x21E4DB0 Offset: 0x21E4EB1 VA: 0x21E4DB0
	|-Array.InternalArray__ICollection_Contains<BoneWeight1>
	|
	|-RVA: 0x21E4F10 Offset: 0x21E5011 VA: 0x21E4F10
	|-Array.InternalArray__ICollection_Contains<BoneWeight>
	|
	|-RVA: 0x21E5080 Offset: 0x21E5181 VA: 0x21E5080
	|-Array.InternalArray__ICollection_Contains<BoundingSphere>
	|
	|-RVA: 0x21E5230 Offset: 0x21E5331 VA: 0x21E5230
	|-Array.InternalArray__ICollection_Contains<Bounds>
	|
	|-RVA: 0x21E53A0 Offset: 0x21E54A1 VA: 0x21E53A0
	|-Array.InternalArray__ICollection_Contains<BoundsInt>
	|
	|-RVA: 0x21E5510 Offset: 0x21E5611 VA: 0x21E5510
	|-Array.InternalArray__ICollection_Contains<CharacterInfo>
	|
	|-RVA: 0x21E5700 Offset: 0x21E5801 VA: 0x21E5700
	|-Array.InternalArray__ICollection_Contains<Color32>
	|
	|-RVA: 0x21E58B0 Offset: 0x21E59B1 VA: 0x21E58B0
	|-Array.InternalArray__ICollection_Contains<Color>
	|
	|-RVA: 0x21E5A10 Offset: 0x21E5B11 VA: 0x21E5A10
	|-Array.InternalArray__ICollection_Contains<CombineInstance>
	|
	|-RVA: 0x21E5C40 Offset: 0x21E5D41 VA: 0x21E5C40
	|-Array.InternalArray__ICollection_Contains<ContactPoint2D>
	|
	|-RVA: 0x21E5E30 Offset: 0x21E5F31 VA: 0x21E5E30
	|-Array.InternalArray__ICollection_Contains<ContactPoint>
	|
	|-RVA: 0x21E6010 Offset: 0x21E6111 VA: 0x21E6010
	|-Array.InternalArray__ICollection_Contains<RaycastResult>
	|
	|-RVA: 0x21E6210 Offset: 0x21E6311 VA: 0x21E6210
	|-Array.InternalArray__ICollection_Contains<LightDataGI>
	|
	|-RVA: 0x21E6420 Offset: 0x21E6521 VA: 0x21E6420
	|-Array.InternalArray__ICollection_Contains<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x21E65D0 Offset: 0x21E66D1 VA: 0x21E65D0
	|-Array.InternalArray__ICollection_Contains<GradientAlphaKey>
	|
	|-RVA: 0x21E6780 Offset: 0x21E6881 VA: 0x21E6780
	|-Array.InternalArray__ICollection_Contains<GradientColorKey>
	|
	|-RVA: 0x21E6940 Offset: 0x21E6A41 VA: 0x21E6940
	|-Array.InternalArray__ICollection_Contains<HumanBone>
	|
	|-RVA: 0x21E6B30 Offset: 0x21E6C31 VA: 0x21E6B30
	|-Array.InternalArray__ICollection_Contains<Keyframe>
	|
	|-RVA: 0x21E6D00 Offset: 0x21E6E01 VA: 0x21E6D00
	|-Array.InternalArray__ICollection_Contains<LOD>
	|
	|-RVA: 0x21E6EB0 Offset: 0x21E6FB1 VA: 0x21E6EB0
	|-Array.InternalArray__ICollection_Contains<LayerMask>
	|
	|-RVA: 0x21E7060 Offset: 0x21E7161 VA: 0x21E7060
	|-Array.InternalArray__ICollection_Contains<PlayerLoopSystem>
	|
	|-RVA: 0x21E7230 Offset: 0x21E7331 VA: 0x21E7230
	|-Array.InternalArray__ICollection_Contains<Matrix4x4>
	|
	|-RVA: 0x21E73C0 Offset: 0x21E74C1 VA: 0x21E73C0
	|-Array.InternalArray__ICollection_Contains<ParticleSystem.Particle>
	|
	|-RVA: 0x21E75B0 Offset: 0x21E76B1 VA: 0x21E75B0
	|-Array.InternalArray__ICollection_Contains<PatchExtents>
	|
	|-RVA: 0x21E7760 Offset: 0x21E7861 VA: 0x21E7760
	|-Array.InternalArray__ICollection_Contains<Plane>
	|
	|-RVA: 0x21E7910 Offset: 0x21E7A11 VA: 0x21E7910
	|-Array.InternalArray__ICollection_Contains<Playable>
	|
	|-RVA: 0x21E7AC0 Offset: 0x21E7BC1 VA: 0x21E7AC0
	|-Array.InternalArray__ICollection_Contains<PlayableBinding>
	|
	|-RVA: 0x21E7C80 Offset: 0x21E7D81 VA: 0x21E7C80
	|-Array.InternalArray__ICollection_Contains<PlayableGraph>
	|
	|-RVA: 0x21E7E30 Offset: 0x21E7F31 VA: 0x21E7E30
	|-Array.InternalArray__ICollection_Contains<Edge>
	|
	|-RVA: 0x21E7F90 Offset: 0x21E8091 VA: 0x21E7F90
	|-Array.InternalArray__ICollection_Contains<IntVec3>
	|
	|-RVA: 0x21E8100 Offset: 0x21E8201 VA: 0x21E8100
	|-Array.InternalArray__ICollection_Contains<Quaternion>
	|
	|-RVA: 0x21E8260 Offset: 0x21E8361 VA: 0x21E8260
	|-Array.InternalArray__ICollection_Contains<RangeInt>
	|
	|-RVA: 0x21E8410 Offset: 0x21E8511 VA: 0x21E8410
	|-Array.InternalArray__ICollection_Contains<RaycastHit2D>
	|
	|-RVA: 0x21E85F0 Offset: 0x21E86F1 VA: 0x21E85F0
	|-Array.InternalArray__ICollection_Contains<RaycastHit>
	|
	|-RVA: 0x21E87E0 Offset: 0x21E88E1 VA: 0x21E87E0
	|-Array.InternalArray__ICollection_Contains<Rect>
	|
	|-RVA: 0x21E8940 Offset: 0x21E8A41 VA: 0x21E8940
	|-Array.InternalArray__ICollection_Contains<RectInt>
	|
	|-RVA: 0x21E8AF0 Offset: 0x21E8BF1 VA: 0x21E8AF0
	|-Array.InternalArray__ICollection_Contains<RenderBuffer>
	|
	|-RVA: 0x21E8CA0 Offset: 0x21E8DA1 VA: 0x21E8CA0
	|-Array.InternalArray__ICollection_Contains<BatchVisibility>
	|
	|-RVA: 0x21E8E60 Offset: 0x21E8F61 VA: 0x21E8E60
	|-Array.InternalArray__ICollection_Contains<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x21E9010 Offset: 0x21E9111 VA: 0x21E9010
	|-Array.InternalArray__ICollection_Contains<SphericalHarmonicsL2>
	|
	|-RVA: 0x21E91D0 Offset: 0x21E92D1 VA: 0x21E91D0
	|-Array.InternalArray__ICollection_Contains<VertexAttributeDescriptor>
	|
	|-RVA: 0x21E9330 Offset: 0x21E9431 VA: 0x21E9330
	|-Array.InternalArray__ICollection_Contains<AsyncOperationHandle>
	|
	|-RVA: 0x21E94F0 Offset: 0x21E95F1 VA: 0x21E94F0
	|-Array.InternalArray__ICollection_Contains<AsyncOperationHandle<object>>
	|
	|-RVA: 0x21E96B0 Offset: 0x21E97B1 VA: 0x21E96B0
	|-Array.InternalArray__ICollection_Contains<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x21E9870 Offset: 0x21E9971 VA: 0x21E9870
	|-Array.InternalArray__ICollection_Contains<DiagnosticEvent>
	|
	|-RVA: 0x21E9A40 Offset: 0x21E9B41 VA: 0x21E9A40
	|-Array.InternalArray__ICollection_Contains<SceneInstance>
	|
	|-RVA: 0x21E9BA0 Offset: 0x21E9CA1 VA: 0x21E9BA0
	|-Array.InternalArray__ICollection_Contains<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x21E9D60 Offset: 0x21E9E61 VA: 0x21E9D60
	|-Array.InternalArray__ICollection_Contains<ObjectInitializationData>
	|
	|-RVA: 0x21E9F30 Offset: 0x21EA031 VA: 0x21E9F30
	|-Array.InternalArray__ICollection_Contains<SerializedType>
	|
	|-RVA: 0x21EA0F0 Offset: 0x21EA1F1 VA: 0x21EA0F0
	|-Array.InternalArray__ICollection_Contains<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x21EA2A0 Offset: 0x21EA3A1 VA: 0x21EA2A0
	|-Array.InternalArray__ICollection_Contains<SkeletonBone>
	|
	|-RVA: 0x21EA490 Offset: 0x21EA591 VA: 0x21EA490
	|-Array.InternalArray__ICollection_Contains<GlyphRect>
	|
	|-RVA: 0x21EA5F0 Offset: 0x21EA6F1 VA: 0x21EA5F0
	|-Array.InternalArray__ICollection_Contains<GlyphMarshallingStruct>
	|
	|-RVA: 0x21EA7C0 Offset: 0x21EA8C1 VA: 0x21EA7C0
	|-Array.InternalArray__ICollection_Contains<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x21EA9B0 Offset: 0x21EAAB1 VA: 0x21EA9B0
	|-Array.InternalArray__ICollection_Contains<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x21EAB80 Offset: 0x21EAC81 VA: 0x21EAB80
	|-Array.InternalArray__ICollection_Contains<IntervalTreeNode>
	|
	|-RVA: 0x21EAD40 Offset: 0x21EAE41 VA: 0x21EAD40
	|-Array.InternalArray__ICollection_Contains<IntervalTree.Entry<object>>
	|
	|-RVA: 0x21EAF00 Offset: 0x21EB001 VA: 0x21EAF00
	|-Array.InternalArray__ICollection_Contains<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x21EB0C0 Offset: 0x21EB1C1 VA: 0x21EB0C0
	|-Array.InternalArray__ICollection_Contains<Touch>
	|
	|-RVA: 0x21EB2C0 Offset: 0x21EB3C1 VA: 0x21EB2C0
	|-Array.InternalArray__ICollection_Contains<TreeInstance>
	|
	|-RVA: 0x21EB490 Offset: 0x21EB591 VA: 0x21EB490
	|-Array.InternalArray__ICollection_Contains<ColorBlock>
	|
	|-RVA: 0x21EB630 Offset: 0x21EB731 VA: 0x21EB630
	|-Array.InternalArray__ICollection_Contains<Navigation>
	|
	|-RVA: 0x21EB800 Offset: 0x21EB901 VA: 0x21EB800
	|-Array.InternalArray__ICollection_Contains<SpriteState>
	|
	|-RVA: 0x21EB9C0 Offset: 0x21EBAC1 VA: 0x21EB9C0
	|-Array.InternalArray__ICollection_Contains<UICharInfo>
	|
	|-RVA: 0x21EBB80 Offset: 0x21EBC81 VA: 0x21EBB80
	|-Array.InternalArray__ICollection_Contains<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x21EBD30 Offset: 0x21EBE31 VA: 0x21EBD30
	|-Array.InternalArray__ICollection_Contains<EventDispatcher.EventRecord>
	|
	|-RVA: 0x21EBEE0 Offset: 0x21EBFE1 VA: 0x21EBEE0
	|-Array.InternalArray__ICollection_Contains<FocusController.FocusedElement>
	|
	|-RVA: 0x21EC090 Offset: 0x21EC191 VA: 0x21EC090
	|-Array.InternalArray__ICollection_Contains<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x21EC240 Offset: 0x21EC341 VA: 0x21EC240
	|-Array.InternalArray__ICollection_Contains<StyleValue>
	|
	|-RVA: 0x21EC400 Offset: 0x21EC501 VA: 0x21EC400
	|-Array.InternalArray__ICollection_Contains<UILineInfo>
	|
	|-RVA: 0x21EC5B0 Offset: 0x21EC6B1 VA: 0x21EC5B0
	|-Array.InternalArray__ICollection_Contains<UIVertex>
	|
	|-RVA: 0x21EC7C0 Offset: 0x21EC8C1 VA: 0x21EC7C0
	|-Array.InternalArray__ICollection_Contains<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x21EC980 Offset: 0x21ECA81 VA: 0x21EC980
	|-Array.InternalArray__ICollection_Contains<Vector2>
	|
	|-RVA: 0x21ECAE0 Offset: 0x21ECBE1 VA: 0x21ECAE0
	|-Array.InternalArray__ICollection_Contains<Vector2Int>
	|
	|-RVA: 0x21ECC40 Offset: 0x21ECD41 VA: 0x21ECC40
	|-Array.InternalArray__ICollection_Contains<Vector3>
	|
	|-RVA: 0x21ECDB0 Offset: 0x21ECEB1 VA: 0x21ECDB0
	|-Array.InternalArray__ICollection_Contains<Vector3Int>
	|
	|-RVA: 0x21ECF20 Offset: 0x21ED021 VA: 0x21ECF20
	|-Array.InternalArray__ICollection_Contains<Vector4>
	|
	|-RVA: 0x21ED080 Offset: 0x21ED181 VA: 0x21ED080
	|-Array.InternalArray__ICollection_Contains<jvalue>
	|
	|-RVA: 0x21ED230 Offset: 0x21ED331 VA: 0x21ED230
	|-Array.InternalArray__ICollection_Contains<WarpPoints.WarpPoint>
	|
	|-RVA: 0x21ED470 Offset: 0x21ED571 VA: 0x21ED470
	|-Array.InternalArray__ICollection_Contains<YieldItemParam>
	|
	|-RVA: 0x21ED620 Offset: 0x21ED721 VA: 0x21ED620
	|-Array.InternalArray__ICollection_Contains<NetworkServiceAccountId>
	|
	|-RVA: 0x21ED780 Offset: 0x21ED881 VA: 0x21ED780
	|-Array.InternalArray__ICollection_Contains<Uid>
	|
	|-RVA: 0x21ED8E0 Offset: 0x21ED9E1 VA: 0x21ED8E0
	|-Array.InternalArray__ICollection_Contains<ConsumableServiceItemId>
	|
	|-RVA: 0x21EDA90 Offset: 0x21EDB91 VA: 0x21EDA90
	|-Array.InternalArray__ICollection_Contains<NsUid>
	|
	|-RVA: 0x21EDBF0 Offset: 0x21EDCF1 VA: 0x21EDBF0
	|-Array.InternalArray__ICollection_Contains<Friend>
	|
	|-RVA: 0x21EDDC0 Offset: 0x21EDEC1 VA: 0x21EDDC0
	|-Array.InternalArray__ICollection_Contains<Profile>
	|
	|-RVA: 0x21EDFC0 Offset: 0x21EE0C1 VA: 0x21EDFC0
	|-Array.InternalArray__ICollection_Contains<DirectoryEntry>
	|
	|-RVA: 0x21EE180 Offset: 0x21EE281 VA: 0x21EE180
	|-Array.InternalArray__ICollection_Contains<DebugPadState>
	|
	|-RVA: 0x21EE340 Offset: 0x21EE441 VA: 0x21EE340
	|-Array.InternalArray__ICollection_Contains<GesturePoint>
	|
	|-RVA: 0x21EE4A0 Offset: 0x21EE5A1 VA: 0x21EE4A0
	|-Array.InternalArray__ICollection_Contains<GestureState>
	|
	|-RVA: 0x21EE6C0 Offset: 0x21EE7C1 VA: 0x21EE6C0
	|-Array.InternalArray__ICollection_Contains<NpadFullKeyState>
	|
	|-RVA: 0x21EE890 Offset: 0x21EE991 VA: 0x21EE890
	|-Array.InternalArray__ICollection_Contains<NpadHandheldState>
	|
	|-RVA: 0x21EEA60 Offset: 0x21EEB61 VA: 0x21EEA60
	|-Array.InternalArray__ICollection_Contains<NpadJoyDualState>
	|
	|-RVA: 0x21EEC30 Offset: 0x21EED31 VA: 0x21EEC30
	|-Array.InternalArray__ICollection_Contains<NpadJoyLeftState>
	|
	|-RVA: 0x21EEE00 Offset: 0x21EEF01 VA: 0x21EEE00
	|-Array.InternalArray__ICollection_Contains<NpadJoyRightState>
	|
	|-RVA: 0x21EEFD0 Offset: 0x21EF0D1 VA: 0x21EEFD0
	|-Array.InternalArray__ICollection_Contains<NpadStateArrayItem>
	|
	|-RVA: 0x21EF1A0 Offset: 0x21EF2A1 VA: 0x21EF1A0
	|-Array.InternalArray__ICollection_Contains<SixAxisSensorHandle>
	|
	|-RVA: 0x21EF350 Offset: 0x21EF451 VA: 0x21EF350
	|-Array.InternalArray__ICollection_Contains<SixAxisSensorState>
	|
	|-RVA: 0x21EF570 Offset: 0x21EF671 VA: 0x21EF570
	|-Array.InternalArray__ICollection_Contains<TouchScreenState10>
	|
	|-RVA: 0x21EF740 Offset: 0x21EF841 VA: 0x21EF740
	|-Array.InternalArray__ICollection_Contains<TouchScreenState11>
	|
	|-RVA: 0x21EF910 Offset: 0x21EFA11 VA: 0x21EF910
	|-Array.InternalArray__ICollection_Contains<TouchScreenState12>
	|
	|-RVA: 0x21EFAE0 Offset: 0x21EFBE1 VA: 0x21EFAE0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState13>
	|
	|-RVA: 0x21EFCB0 Offset: 0x21EFDB1 VA: 0x21EFCB0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState14>
	|
	|-RVA: 0x21EFE80 Offset: 0x21EFF81 VA: 0x21EFE80
	|-Array.InternalArray__ICollection_Contains<TouchScreenState15>
	|
	|-RVA: 0x21F0050 Offset: 0x21F0151 VA: 0x21F0050
	|-Array.InternalArray__ICollection_Contains<TouchScreenState16>
	|
	|-RVA: 0x21F0220 Offset: 0x21F0321 VA: 0x21F0220
	|-Array.InternalArray__ICollection_Contains<TouchScreenState1>
	|
	|-RVA: 0x21F0410 Offset: 0x21F0511 VA: 0x21F0410
	|-Array.InternalArray__ICollection_Contains<TouchScreenState2>
	|
	|-RVA: 0x21F0630 Offset: 0x21F0731 VA: 0x21F0630
	|-Array.InternalArray__ICollection_Contains<TouchScreenState3>
	|
	|-RVA: 0x21F0820 Offset: 0x21F0921 VA: 0x21F0820
	|-Array.InternalArray__ICollection_Contains<TouchScreenState4>
	|
	|-RVA: 0x21F0A10 Offset: 0x21F0B11 VA: 0x21F0A10
	|-Array.InternalArray__ICollection_Contains<TouchScreenState5>
	|
	|-RVA: 0x21F0C10 Offset: 0x21F0D11 VA: 0x21F0C10
	|-Array.InternalArray__ICollection_Contains<TouchScreenState6>
	|
	|-RVA: 0x21F0E10 Offset: 0x21F0F11 VA: 0x21F0E10
	|-Array.InternalArray__ICollection_Contains<TouchScreenState7>
	|
	|-RVA: 0x21F0FE0 Offset: 0x21F10E1 VA: 0x21F0FE0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState8>
	|
	|-RVA: 0x21F11B0 Offset: 0x21F12B1 VA: 0x21F11B0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState9>
	|
	|-RVA: 0x21F1380 Offset: 0x21F1481 VA: 0x21F1380
	|-Array.InternalArray__ICollection_Contains<TouchState>
	|
	|-RVA: 0x21F1500 Offset: 0x21F1601 VA: 0x21F1500
	|-Array.InternalArray__ICollection_Contains<VibrationDeviceHandle>
	|
	|-RVA: 0x21F16B0 Offset: 0x21F17B1 VA: 0x21F16B0
	|-Array.InternalArray__ICollection_Contains<VibrationDeviceInfo>
	|
	|-RVA: 0x21F1860 Offset: 0x21F1961 VA: 0x21F1860
	|-Array.InternalArray__ICollection_Contains<VibrationValue>
	|
	|-RVA: 0x21F1A10 Offset: 0x21F1B11 VA: 0x21F1A10
	|-Array.InternalArray__ICollection_Contains<ClusteringData>
	|
	|-RVA: 0x21F1B80 Offset: 0x21F1C81 VA: 0x21F1B80
	|-Array.InternalArray__ICollection_Contains<ClusteringProcessorState>
	|
	|-RVA: 0x21F1D50 Offset: 0x21F1E51 VA: 0x21F1D50
	|-Array.InternalArray__ICollection_Contains<Finger>
	|
	|-RVA: 0x21F1ED0 Offset: 0x21F1FD1 VA: 0x21F1ED0
	|-Array.InternalArray__ICollection_Contains<Hand>
	|
	|-RVA: 0x21F2060 Offset: 0x21F2161 VA: 0x21F2060
	|-Array.InternalArray__ICollection_Contains<HandAnalysisImageState>
	|
	|-RVA: 0x21F2210 Offset: 0x21F2311 VA: 0x21F2210
	|-Array.InternalArray__ICollection_Contains<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x21F23E0 Offset: 0x21F24E1 VA: 0x21F23E0
	|-Array.InternalArray__ICollection_Contains<MomentProcessorState>
	|
	|-RVA: 0x21F25B0 Offset: 0x21F26B1 VA: 0x21F25B0
	|-Array.InternalArray__ICollection_Contains<MomentStatistic>
	|
	|-RVA: 0x21F2720 Offset: 0x21F2821 VA: 0x21F2720
	|-Array.InternalArray__ICollection_Contains<Protrusion>
	|
	|-RVA: 0x21F2880 Offset: 0x21F2981 VA: 0x21F2880
	|-Array.InternalArray__ICollection_Contains<Shape>
	|
	|-RVA: 0x21F29F0 Offset: 0x21F2AF1 VA: 0x21F29F0
	|-Array.InternalArray__ICollection_Contains<DictionaryInfo>
	|
	|-RVA: 0x21F2B50 Offset: 0x21F2C51 VA: 0x21F2B50
	|-Array.InternalArray__ICollection_Contains<UserWord>
	|
	|-RVA: 0x21F2D00 Offset: 0x21F2E01 VA: 0x21F2D00
	|-Array.InternalArray__ICollection_Contains<Color4u8>
	|
	|-RVA: 0x21F2E60 Offset: 0x21F2F61 VA: 0x21F2E60
	|-Array.InternalArray__ICollection_Contains<Float2>
	|
	|-RVA: 0x21F2FC0 Offset: 0x21F30C1 VA: 0x21F2FC0
	|-Array.InternalArray__ICollection_Contains<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DC0150 Offset: 0x1DC0251 VA: 0x1DC0150
	|-Array.InternalArray__ICollection_CopyTo<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x1DC01C0 Offset: 0x1DC02C1 VA: 0x1DC01C0
	|-Array.InternalArray__ICollection_CopyTo<ActionCommandDataTable>
	|
	|-RVA: 0x1DC0230 Offset: 0x1DC0331 VA: 0x1DC0230
	|-Array.InternalArray__ICollection_CopyTo<AdvScriptDefCountParam>
	|
	|-RVA: 0x1DC02A0 Offset: 0x1DC03A1 VA: 0x1DC02A0
	|-Array.InternalArray__ICollection_CopyTo<JSONDeserialization.TaskField>
	|
	|-RVA: 0x1DC0310 Offset: 0x1DC0411 VA: 0x1DC0310
	|-Array.InternalArray__ICollection_CopyTo<BitVector32Int>
	|
	|-RVA: 0x1DC0380 Offset: 0x1DC0481 VA: 0x1DC0380
	|-Array.InternalArray__ICollection_CopyTo<BuildItemData>
	|
	|-RVA: 0x1DC03F0 Offset: 0x1DC04F1 VA: 0x1DC03F0
	|-Array.InternalArray__ICollection_CopyTo<ButtonLinker.LinkObject>
	|
	|-RVA: 0x1DC0460 Offset: 0x1DC0561 VA: 0x1DC0460
	|-Array.InternalArray__ICollection_CopyTo<CharaCallTable.BustupTable>
	|
	|-RVA: 0x1DC04D0 Offset: 0x1DC05D1 VA: 0x1DC04D0
	|-Array.InternalArray__ICollection_CopyTo<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x1DC0540 Offset: 0x1DC0641 VA: 0x1DC0540
	|-Array.InternalArray__ICollection_CopyTo<CameraState.CustomBlendable>
	|
	|-RVA: 0x1DC05B0 Offset: 0x1DC06B1 VA: 0x1DC05B0
	|-Array.InternalArray__ICollection_CopyTo<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x1DC0620 Offset: 0x1DC0721 VA: 0x1DC0620
	|-Array.InternalArray__ICollection_CopyTo<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x1DC0690 Offset: 0x1DC0791 VA: 0x1DC0690
	|-Array.InternalArray__ICollection_CopyTo<CinemachineClearShot.Pair>
	|
	|-RVA: 0x1DC0700 Offset: 0x1DC0801 VA: 0x1DC0700
	|-Array.InternalArray__ICollection_CopyTo<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x1DC0770 Offset: 0x1DC0871 VA: 0x1DC0770
	|-Array.InternalArray__ICollection_CopyTo<CinemachinePath.Waypoint>
	|
	|-RVA: 0x1DC07E0 Offset: 0x1DC08E1 VA: 0x1DC07E0
	|-Array.InternalArray__ICollection_CopyTo<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x1DC0850 Offset: 0x1DC0951 VA: 0x1DC0850
	|-Array.InternalArray__ICollection_CopyTo<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x1DC08C0 Offset: 0x1DC09C1 VA: 0x1DC08C0
	|-Array.InternalArray__ICollection_CopyTo<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x1DC0930 Offset: 0x1DC0A31 VA: 0x1DC0930
	|-Array.InternalArray__ICollection_CopyTo<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x1DC09A0 Offset: 0x1DC0AA1 VA: 0x1DC09A0
	|-Array.InternalArray__ICollection_CopyTo<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x1DC0A10 Offset: 0x1DC0B11 VA: 0x1DC0A10
	|-Array.InternalArray__ICollection_CopyTo<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x1DC0A80 Offset: 0x1DC0B81 VA: 0x1DC0A80
	|-Array.InternalArray__ICollection_CopyTo<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x1DC0AF0 Offset: 0x1DC0BF1 VA: 0x1DC0AF0
	|-Array.InternalArray__ICollection_CopyTo<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x1DC0B60 Offset: 0x1DC0C61 VA: 0x1DC0B60
	|-Array.InternalArray__ICollection_CopyTo<HeadingTracker.Item>
	|
	|-RVA: 0x1DC0BD0 Offset: 0x1DC0CD1 VA: 0x1DC0BD0
	|-Array.InternalArray__ICollection_CopyTo<CropDataTable>
	|
	|-RVA: 0x1DC0C40 Offset: 0x1DC0D41 VA: 0x1DC0C40
	|-Array.InternalArray__ICollection_CopyTo<ControlPoint>
	|
	|-RVA: 0x1DC0CB0 Offset: 0x1DC0DB1 VA: 0x1DC0CB0
	|-Array.InternalArray__ICollection_CopyTo<DamageTextInfo>
	|
	|-RVA: 0x1DC0D20 Offset: 0x1DC0E21 VA: 0x1DC0D20
	|-Array.InternalArray__ICollection_CopyTo<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x1DC0D90 Offset: 0x1DC0E91 VA: 0x1DC0D90
	|-Array.InternalArray__ICollection_CopyTo<DropItemParam>
	|
	|-RVA: 0x1DC0E00 Offset: 0x1DC0F01 VA: 0x1DC0E00
	|-Array.InternalArray__ICollection_CopyTo<DropTableElement>
	|
	|-RVA: 0x1DC0E70 Offset: 0x1DC0F71 VA: 0x1DC0E70
	|-Array.InternalArray__ICollection_CopyTo<EffectDataTable>
	|
	|-RVA: 0x1DC0EE0 Offset: 0x1DC0FE1 VA: 0x1DC0EE0
	|-Array.InternalArray__ICollection_CopyTo<EnemyPatrolPoints>
	|
	|-RVA: 0x1DC0F50 Offset: 0x1DC1051 VA: 0x1DC0F50
	|-Array.InternalArray__ICollection_CopyTo<Coord>
	|
	|-RVA: 0x1DC0FC0 Offset: 0x1DC10C1 VA: 0x1DC0FC0
	|-Array.InternalArray__ICollection_CopyTo<ErosionBrush.UndoStep>
	|
	|-RVA: 0x1DC1030 Offset: 0x1DC1131 VA: 0x1DC1030
	|-Array.InternalArray__ICollection_CopyTo<EventCheckId>
	|
	|-RVA: 0x1DC10A0 Offset: 0x1DC11A1 VA: 0x1DC10A0
	|-Array.InternalArray__ICollection_CopyTo<EventFlagProgressData>
	|
	|-RVA: 0x1DC1110 Offset: 0x1DC1211 VA: 0x1DC1110
	|-Array.InternalArray__ICollection_CopyTo<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x1DC1180 Offset: 0x1DC1281 VA: 0x1DC1180
	|-Array.InternalArray__ICollection_CopyTo<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x1DC11F0 Offset: 0x1DC12F1 VA: 0x1DC11F0
	|-Array.InternalArray__ICollection_CopyTo<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1DC1260 Offset: 0x1DC1361 VA: 0x1DC1260
	|-Array.InternalArray__ICollection_CopyTo<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1DC12D0 Offset: 0x1DC13D1 VA: 0x1DC12D0
	|-Array.InternalArray__ICollection_CopyTo<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1DC1340 Offset: 0x1DC1441 VA: 0x1DC1340
	|-Array.InternalArray__ICollection_CopyTo<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1DC13B0 Offset: 0x1DC14B1 VA: 0x1DC13B0
	|-Array.InternalArray__ICollection_CopyTo<FesNpcScoreData>
	|
	|-RVA: 0x1DC1420 Offset: 0x1DC1521 VA: 0x1DC1420
	|-Array.InternalArray__ICollection_CopyTo<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x1DC1490 Offset: 0x1DC1591 VA: 0x1DC1490
	|-Array.InternalArray__ICollection_CopyTo<FieldItemSpawnDataTable>
	|
	|-RVA: 0x1DC1500 Offset: 0x1DC1601 VA: 0x1DC1500
	|-Array.InternalArray__ICollection_CopyTo<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x1DC1570 Offset: 0x1DC1671 VA: 0x1DC1570
	|-Array.InternalArray__ICollection_CopyTo<FieldSceneData.Data>
	|
	|-RVA: 0x1DC15E0 Offset: 0x1DC16E1 VA: 0x1DC15E0
	|-Array.InternalArray__ICollection_CopyTo<FieldTreasureBoxItemData>
	|
	|-RVA: 0x1DC1650 Offset: 0x1DC1751 VA: 0x1DC1650
	|-Array.InternalArray__ICollection_CopyTo<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x1DC16C0 Offset: 0x1DC17C1 VA: 0x1DC16C0
	|-Array.InternalArray__ICollection_CopyTo<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x1DC1730 Offset: 0x1DC1831 VA: 0x1DC1730
	|-Array.InternalArray__ICollection_CopyTo<FocusObjectDataTable>
	|
	|-RVA: 0x1DC17A0 Offset: 0x1DC18A1 VA: 0x1DC17A0
	|-Array.InternalArray__ICollection_CopyTo<FurnitureData>
	|
	|-RVA: 0x1DC1810 Offset: 0x1DC1911 VA: 0x1DC1810
	|-Array.InternalArray__ICollection_CopyTo<GateDataTable>
	|
	|-RVA: 0x1DC1880 Offset: 0x1DC1981 VA: 0x1DC1880
	|-Array.InternalArray__ICollection_CopyTo<GateStatusDataTable>
	|
	|-RVA: 0x1DC18F0 Offset: 0x1DC19F1 VA: 0x1DC18F0
	|-Array.InternalArray__ICollection_CopyTo<GimmickLayoutDataTable>
	|
	|-RVA: 0x1DC1960 Offset: 0x1DC1A61 VA: 0x1DC1960
	|-Array.InternalArray__ICollection_CopyTo<HitResult>
	|
	|-RVA: 0x1DC19D0 Offset: 0x1DC1AD1 VA: 0x1DC19D0
	|-Array.InternalArray__ICollection_CopyTo<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x1DC1A40 Offset: 0x1DC1B41 VA: 0x1DC1A40
	|-Array.InternalArray__ICollection_CopyTo<FurnitureManager.SendPos>
	|
	|-RVA: 0x1DC1AB0 Offset: 0x1DC1BB1 VA: 0x1DC1AB0
	|-Array.InternalArray__ICollection_CopyTo<ItemLevelData>
	|
	|-RVA: 0x1DC1B20 Offset: 0x1DC1C21 VA: 0x1DC1B20
	|-Array.InternalArray__ICollection_CopyTo<MapDatas.MapData>
	|
	|-RVA: 0x1DC1B90 Offset: 0x1DC1C91 VA: 0x1DC1B90
	|-Array.InternalArray__ICollection_CopyTo<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x1DC1C00 Offset: 0x1DC1D01 VA: 0x1DC1C00
	|-Array.InternalArray__ICollection_CopyTo<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x1DC1C70 Offset: 0x1DC1D71 VA: 0x1DC1C70
	|-Array.InternalArray__ICollection_CopyTo<MineTypeDataTable>
	|
	|-RVA: 0x1DC1CE0 Offset: 0x1DC1DE1 VA: 0x1DC1CE0
	|-Array.InternalArray__ICollection_CopyTo<MiningDataTable>
	|
	|-RVA: 0x1DC1D50 Offset: 0x1DC1E51 VA: 0x1DC1D50
	|-Array.InternalArray__ICollection_CopyTo<MiningPointSaveData>
	|
	|-RVA: 0x1DC1DC0 Offset: 0x1DC1EC1 VA: 0x1DC1DC0
	|-Array.InternalArray__ICollection_CopyTo<CodePointIndexer.TableRange>
	|
	|-RVA: 0x1DC1E30 Offset: 0x1DC1F31 VA: 0x1DC1E30
	|-Array.InternalArray__ICollection_CopyTo<MonsterBehaviorDataTable>
	|
	|-RVA: 0x1DC1EA0 Offset: 0x1DC1FA1 VA: 0x1DC1EA0
	|-Array.InternalArray__ICollection_CopyTo<MonsterDataTable>
	|
	|-RVA: 0x1DC1F10 Offset: 0x1DC2011 VA: 0x1DC1F10
	|-Array.InternalArray__ICollection_CopyTo<MonsterDropItemDataTable>
	|
	|-RVA: 0x1DC1F80 Offset: 0x1DC2081 VA: 0x1DC1F80
	|-Array.InternalArray__ICollection_CopyTo<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x1DC1FF0 Offset: 0x1DC20F1 VA: 0x1DC1FF0
	|-Array.InternalArray__ICollection_CopyTo<MonsterHutSaveData>
	|
	|-RVA: 0x1DC2060 Offset: 0x1DC2161 VA: 0x1DC2060
	|-Array.InternalArray__ICollection_CopyTo<MonsterUIData.Data>
	|
	|-RVA: 0x1DC20D0 Offset: 0x1DC21D1 VA: 0x1DC20D0
	|-Array.InternalArray__ICollection_CopyTo<MonsterYieldItemDataTable>
	|
	|-RVA: 0x1DC2140 Offset: 0x1DC2241 VA: 0x1DC2140
	|-Array.InternalArray__ICollection_CopyTo<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x1DC21B0 Offset: 0x1DC22B1 VA: 0x1DC21B0
	|-Array.InternalArray__ICollection_CopyTo<NPCActionData>
	|
	|-RVA: 0x1DC2220 Offset: 0x1DC2321 VA: 0x1DC2220
	|-Array.InternalArray__ICollection_CopyTo<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x1DC2290 Offset: 0x1DC2391 VA: 0x1DC2290
	|-Array.InternalArray__ICollection_CopyTo<NPCUIData.Data>
	|
	|-RVA: 0x1DC2300 Offset: 0x1DC2401 VA: 0x1DC2300
	|-Array.InternalArray__ICollection_CopyTo<NpcPlaceSchedule>
	|
	|-RVA: 0x1DC2370 Offset: 0x1DC2471 VA: 0x1DC2370
	|-Array.InternalArray__ICollection_CopyTo<OrderLotterySaveParameter>
	|
	|-RVA: 0x1DC23E0 Offset: 0x1DC24E1 VA: 0x1DC23E0
	|-Array.InternalArray__ICollection_CopyTo<OrderSaveData>
	|
	|-RVA: 0x1DC2450 Offset: 0x1DC2551 VA: 0x1DC2450
	|-Array.InternalArray__ICollection_CopyTo<OrderSaveParameter>
	|
	|-RVA: 0x1DC24C0 Offset: 0x1DC25C1 VA: 0x1DC24C0
	|-Array.InternalArray__ICollection_CopyTo<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x1DC2530 Offset: 0x1DC2631 VA: 0x1DC2530
	|-Array.InternalArray__ICollection_CopyTo<Parameter>
	|
	|-RVA: 0x1DC25A0 Offset: 0x1DC26A1 VA: 0x1DC25A0
	|-Array.InternalArray__ICollection_CopyTo<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x1DC2610 Offset: 0x1DC2711 VA: 0x1DC2610
	|-Array.InternalArray__ICollection_CopyTo<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x1DC2680 Offset: 0x1DC2781 VA: 0x1DC2680
	|-Array.InternalArray__ICollection_CopyTo<ShopCatalogPage>
	|
	|-RVA: 0x1DC26F0 Offset: 0x1DC27F1 VA: 0x1DC26F0
	|-Array.InternalArray__ICollection_CopyTo<ShopNpcTalk>
	|
	|-RVA: 0x1DC2760 Offset: 0x1DC2861 VA: 0x1DC2760
	|-Array.InternalArray__ICollection_CopyTo<SubtitleDataTable.Data>
	|
	|-RVA: 0x1DC27D0 Offset: 0x1DC28D1 VA: 0x1DC27D0
	|-Array.InternalArray__ICollection_CopyTo<SubtitleDataTable.DataList>
	|
	|-RVA: 0x1DC2840 Offset: 0x1DC2941 VA: 0x1DC2840
	|-Array.InternalArray__ICollection_CopyTo<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x1DC28B0 Offset: 0x1DC29B1 VA: 0x1DC28B0
	|-Array.InternalArray__ICollection_CopyTo<AnimationWarping.Warp>
	|
	|-RVA: 0x1DC2920 Offset: 0x1DC2A21 VA: 0x1DC2920
	|-Array.InternalArray__ICollection_CopyTo<GrounderQuadruped.Foot>
	|
	|-RVA: 0x1DC2990 Offset: 0x1DC2A91 VA: 0x1DC2990
	|-Array.InternalArray__ICollection_CopyTo<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x1DC2A00 Offset: 0x1DC2B01 VA: 0x1DC2A00
	|-Array.InternalArray__ICollection_CopyTo<ProfilerFrame>
	|
	|-RVA: 0x1DC2A70 Offset: 0x1DC2B71 VA: 0x1DC2A70
	|-Array.InternalArray__ICollection_CopyTo<NumberControl.ValueRange>
	|
	|-RVA: 0x1DC2AE0 Offset: 0x1DC2BE1 VA: 0x1DC2AE0
	|-Array.InternalArray__ICollection_CopyTo<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x1DC2B50 Offset: 0x1DC2C51 VA: 0x1DC2B50
	|-Array.InternalArray__ICollection_CopyTo<ResponsiveEnable.Entry>
	|
	|-RVA: 0x1DC2BC0 Offset: 0x1DC2CC1 VA: 0x1DC2BC0
	|-Array.InternalArray__ICollection_CopyTo<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x1DC2C30 Offset: 0x1DC2D31 VA: 0x1DC2C30
	|-Array.InternalArray__ICollection_CopyTo<ResponsiveResize.Element>
	|
	|-RVA: 0x1DC2CA0 Offset: 0x1DC2DA1 VA: 0x1DC2CA0
	|-Array.InternalArray__ICollection_CopyTo<Schedule>
	|
	|-RVA: 0x1DC2D10 Offset: 0x1DC2E11 VA: 0x1DC2D10
	|-Array.InternalArray__ICollection_CopyTo<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x1DC2D80 Offset: 0x1DC2E81 VA: 0x1DC2D80
	|-Array.InternalArray__ICollection_CopyTo<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x1DC2DF0 Offset: 0x1DC2EF1 VA: 0x1DC2DF0
	|-Array.InternalArray__ICollection_CopyTo<SpeedData>
	|
	|-RVA: 0x1DC2E60 Offset: 0x1DC2F61 VA: 0x1DC2E60
	|-Array.InternalArray__ICollection_CopyTo<CurveSample>
	|
	|-RVA: 0x1DC2ED0 Offset: 0x1DC2FD1 VA: 0x1DC2ED0
	|-Array.InternalArray__ICollection_CopyTo<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x1DC2F40 Offset: 0x1DC3041 VA: 0x1DC2F40
	|-Array.InternalArray__ICollection_CopyTo<StringFormatData.FormatData>
	|
	|-RVA: 0x1DC2FB0 Offset: 0x1DC30B1 VA: 0x1DC2FB0
	|-Array.InternalArray__ICollection_CopyTo<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x1DC3020 Offset: 0x1DC3121 VA: 0x1DC3020
	|-Array.InternalArray__ICollection_CopyTo<ArraySegment<byte>>
	|
	|-RVA: 0x1DC3090 Offset: 0x1DC3191 VA: 0x1DC3090
	|-Array.InternalArray__ICollection_CopyTo<ArraySegment<object>>
	|
	|-RVA: 0x1DC3100 Offset: 0x1DC3201 VA: 0x1DC3100
	|-Array.InternalArray__ICollection_CopyTo<bool>
	|
	|-RVA: 0x1DC3170 Offset: 0x1DC3271 VA: 0x1DC3170
	|-Array.InternalArray__ICollection_CopyTo<byte>
	|
	|-RVA: 0x1DC31E0 Offset: 0x1DC32E1 VA: 0x1DC31E0
	|-Array.InternalArray__ICollection_CopyTo<ByteEnum>
	|
	|-RVA: 0x1DC3250 Offset: 0x1DC3351 VA: 0x1DC3250
	|-Array.InternalArray__ICollection_CopyTo<char>
	|
	|-RVA: 0x1DC32C0 Offset: 0x1DC33C1 VA: 0x1DC32C0
	|-Array.InternalArray__ICollection_CopyTo<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x1DC3330 Offset: 0x1DC3431 VA: 0x1DC3330
	|-Array.InternalArray__ICollection_CopyTo<DictionaryEntry>
	|
	|-RVA: 0x1DC33A0 Offset: 0x1DC34A1 VA: 0x1DC33A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x1DC3410 Offset: 0x1DC3511 VA: 0x1DC3410
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x1DC3480 Offset: 0x1DC3581 VA: 0x1DC3480
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x1DC34F0 Offset: 0x1DC35F1 VA: 0x1DC34F0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x1DC3560 Offset: 0x1DC3661 VA: 0x1DC3560
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x1DC35D0 Offset: 0x1DC36D1 VA: 0x1DC35D0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x1DC3640 Offset: 0x1DC3741 VA: 0x1DC3640
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x1DC36B0 Offset: 0x1DC37B1 VA: 0x1DC36B0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x1DC3720 Offset: 0x1DC3821 VA: 0x1DC3720
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x1DC3790 Offset: 0x1DC3891 VA: 0x1DC3790
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x1DC3800 Offset: 0x1DC3901 VA: 0x1DC3800
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x1DC3870 Offset: 0x1DC3971 VA: 0x1DC3870
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x1DC38E0 Offset: 0x1DC39E1 VA: 0x1DC38E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x1DC3950 Offset: 0x1DC3A51 VA: 0x1DC3950
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x1DC39C0 Offset: 0x1DC3AC1 VA: 0x1DC39C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x1DC3A30 Offset: 0x1DC3B31 VA: 0x1DC3A30
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x1DC3AA0 Offset: 0x1DC3BA1 VA: 0x1DC3AA0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x1DC3B10 Offset: 0x1DC3C11 VA: 0x1DC3B10
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x1DC3B80 Offset: 0x1DC3C81 VA: 0x1DC3B80
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x1DC3BF0 Offset: 0x1DC3CF1 VA: 0x1DC3BF0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x1DC3C60 Offset: 0x1DC3D61 VA: 0x1DC3C60
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x1DC3CD0 Offset: 0x1DC3DD1 VA: 0x1DC3CD0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x1DC3D40 Offset: 0x1DC3E41 VA: 0x1DC3D40
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x1DC3DB0 Offset: 0x1DC3EB1 VA: 0x1DC3DB0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x1DC3E20 Offset: 0x1DC3F21 VA: 0x1DC3E20
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x1DC3E90 Offset: 0x1DC3F91 VA: 0x1DC3E90
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x1DC3F00 Offset: 0x1DC4001 VA: 0x1DC3F00
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x1DC3F70 Offset: 0x1DC4071 VA: 0x1DC3F70
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x1DC3FE0 Offset: 0x1DC40E1 VA: 0x1DC3FE0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x1DC4050 Offset: 0x1DC4151 VA: 0x1DC4050
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x1DC40C0 Offset: 0x1DC41C1 VA: 0x1DC40C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x1DC4130 Offset: 0x1DC4231 VA: 0x1DC4130
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x1DC41A0 Offset: 0x1DC42A1 VA: 0x1DC41A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x1DC4210 Offset: 0x1DC4311 VA: 0x1DC4210
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x1DC4280 Offset: 0x1DC4381 VA: 0x1DC4280
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x1DC42F0 Offset: 0x1DC43F1 VA: 0x1DC42F0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x1DC4360 Offset: 0x1DC4461 VA: 0x1DC4360
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x1DC43D0 Offset: 0x1DC44D1 VA: 0x1DC43D0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x1DC4440 Offset: 0x1DC4541 VA: 0x1DC4440
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x1DC44B0 Offset: 0x1DC45B1 VA: 0x1DC44B0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x1DC4520 Offset: 0x1DC4621 VA: 0x1DC4520
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1DC4590 Offset: 0x1DC4691 VA: 0x1DC4590
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x1DC4600 Offset: 0x1DC4701 VA: 0x1DC4600
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x1DC4670 Offset: 0x1DC4771 VA: 0x1DC4670
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x1DC46E0 Offset: 0x1DC47E1 VA: 0x1DC46E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x1DC4750 Offset: 0x1DC4851 VA: 0x1DC4750
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x1DC47C0 Offset: 0x1DC48C1 VA: 0x1DC47C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x1DC4830 Offset: 0x1DC4931 VA: 0x1DC4830
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x1DC48A0 Offset: 0x1DC49A1 VA: 0x1DC48A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x1DC4910 Offset: 0x1DC4A11 VA: 0x1DC4910
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x1DC4980 Offset: 0x1DC4A81 VA: 0x1DC4980
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x1DC49F0 Offset: 0x1DC4AF1 VA: 0x1DC49F0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x1DC4A60 Offset: 0x1DC4B61 VA: 0x1DC4A60
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x1DC4AD0 Offset: 0x1DC4BD1 VA: 0x1DC4AD0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x1DC4B40 Offset: 0x1DC4C41 VA: 0x1DC4B40
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x1DC4BB0 Offset: 0x1DC4CB1 VA: 0x1DC4BB0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x1DC4C20 Offset: 0x1DC4D21 VA: 0x1DC4C20
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x1DC4C90 Offset: 0x1DC4D91 VA: 0x1DC4C90
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x1DC4D00 Offset: 0x1DC4E01 VA: 0x1DC4D00
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x1DC4D70 Offset: 0x1DC4E71 VA: 0x1DC4D70
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x1DC4DE0 Offset: 0x1DC4EE1 VA: 0x1DC4DE0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x1DC4E50 Offset: 0x1DC4F51 VA: 0x1DC4E50
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x1DC4EC0 Offset: 0x1DC4FC1 VA: 0x1DC4EC0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x1DC4F30 Offset: 0x1DC5031 VA: 0x1DC4F30
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x1DC4FA0 Offset: 0x1DC50A1 VA: 0x1DC4FA0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x1DC5010 Offset: 0x1DC5111 VA: 0x1DC5010
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x1DC5080 Offset: 0x1DC5181 VA: 0x1DC5080
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x1DC50F0 Offset: 0x1DC51F1 VA: 0x1DC50F0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x1DC5160 Offset: 0x1DC5261 VA: 0x1DC5160
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x1DC51D0 Offset: 0x1DC52D1 VA: 0x1DC51D0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x1DC5240 Offset: 0x1DC5341 VA: 0x1DC5240
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x1DC52B0 Offset: 0x1DC53B1 VA: 0x1DC52B0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x1DC5320 Offset: 0x1DC5421 VA: 0x1DC5320
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x1DC5390 Offset: 0x1DC5491 VA: 0x1DC5390
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x1DC5400 Offset: 0x1DC5501 VA: 0x1DC5400
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x1DC5470 Offset: 0x1DC5571 VA: 0x1DC5470
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x1DC54E0 Offset: 0x1DC55E1 VA: 0x1DC54E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x1DC5550 Offset: 0x1DC5651 VA: 0x1DC5550
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x1DC55C0 Offset: 0x1DC56C1 VA: 0x1DC55C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x1DC5630 Offset: 0x1DC5731 VA: 0x1DC5630
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x1DC56A0 Offset: 0x1DC57A1 VA: 0x1DC56A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x1DC5710 Offset: 0x1DC5811 VA: 0x1DC5710
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x1DC5780 Offset: 0x1DC5881 VA: 0x1DC5780
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x1DC57F0 Offset: 0x1DC58F1 VA: 0x1DC57F0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x1DC5860 Offset: 0x1DC5961 VA: 0x1DC5860
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x1DC58D0 Offset: 0x1DC59D1 VA: 0x1DC58D0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x1DC5940 Offset: 0x1DC5A41 VA: 0x1DC5940
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x1DC59B0 Offset: 0x1DC5AB1 VA: 0x1DC59B0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x1DC5A20 Offset: 0x1DC5B21 VA: 0x1DC5A20
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x1DC5A90 Offset: 0x1DC5B91 VA: 0x1DC5A90
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x1DC5B00 Offset: 0x1DC5C01 VA: 0x1DC5B00
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x1DC5B70 Offset: 0x1DC5C71 VA: 0x1DC5B70
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x1DC5BE0 Offset: 0x1DC5CE1 VA: 0x1DC5BE0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x1DC5C50 Offset: 0x1DC5D51 VA: 0x1DC5C50
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x1DC5CC0 Offset: 0x1DC5DC1 VA: 0x1DC5CC0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x1DC5D30 Offset: 0x1DC5E31 VA: 0x1DC5D30
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x1DC5DA0 Offset: 0x1DC5EA1 VA: 0x1DC5DA0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x1DC5E10 Offset: 0x1DC5F11 VA: 0x1DC5E10
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x1DC5E80 Offset: 0x1DC5F81 VA: 0x1DC5E80
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x1DC5EF0 Offset: 0x1DC5FF1 VA: 0x1DC5EF0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x1DC5F60 Offset: 0x1DC6061 VA: 0x1DC5F60
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x1DC5FD0 Offset: 0x1DC60D1 VA: 0x1DC5FD0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x1DC6040 Offset: 0x1DC6141 VA: 0x1DC6040
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x1DC60B0 Offset: 0x1DC61B1 VA: 0x1DC60B0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x1DC6120 Offset: 0x1DC6221 VA: 0x1DC6120
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x1DC6190 Offset: 0x1DC6291 VA: 0x1DC6190
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x1DC6200 Offset: 0x1DC6301 VA: 0x1DC6200
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x1DC6270 Offset: 0x1DC6371 VA: 0x1DC6270
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x1DC62E0 Offset: 0x1DC63E1 VA: 0x1DC62E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x1DC6350 Offset: 0x1DC6451 VA: 0x1DC6350
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x1DC63C0 Offset: 0x1DC64C1 VA: 0x1DC63C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x1DC6430 Offset: 0x1DC6531 VA: 0x1DC6430
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x1DC64A0 Offset: 0x1DC65A1 VA: 0x1DC64A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x1DC6510 Offset: 0x1DC6611 VA: 0x1DC6510
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x1DC6580 Offset: 0x1DC6681 VA: 0x1DC6580
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x1DC65F0 Offset: 0x1DC66F1 VA: 0x1DC65F0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x1DC6660 Offset: 0x1DC6761 VA: 0x1DC6660
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x1DC66D0 Offset: 0x1DC67D1 VA: 0x1DC66D0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x1DC6740 Offset: 0x1DC6841 VA: 0x1DC6740
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x1DC67B0 Offset: 0x1DC68B1 VA: 0x1DC67B0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x1DC6820 Offset: 0x1DC6921 VA: 0x1DC6820
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x1DC6890 Offset: 0x1DC6991 VA: 0x1DC6890
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x1DC6900 Offset: 0x1DC6A01 VA: 0x1DC6900
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x1DC6970 Offset: 0x1DC6A71 VA: 0x1DC6970
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x1DC69E0 Offset: 0x1DC6AE1 VA: 0x1DC69E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x1DC6A50 Offset: 0x1DC6B51 VA: 0x1DC6A50
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x1DC6AC0 Offset: 0x1DC6BC1 VA: 0x1DC6AC0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x1DC6B30 Offset: 0x1DC6C31 VA: 0x1DC6B30
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x1DC6BA0 Offset: 0x1DC6CA1 VA: 0x1DC6BA0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x1DC6C10 Offset: 0x1DC6D11 VA: 0x1DC6C10
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x1DC6C80 Offset: 0x1DC6D81 VA: 0x1DC6C80
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x1DC6CF0 Offset: 0x1DC6DF1 VA: 0x1DC6CF0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1DC6D60 Offset: 0x1DC6E61 VA: 0x1DC6D60
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1DC6DD0 Offset: 0x1DC6ED1 VA: 0x1DC6DD0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x1DC6E40 Offset: 0x1DC6F41 VA: 0x1DC6E40
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x1DC6EB0 Offset: 0x1DC6FB1 VA: 0x1DC6EB0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x1DC6F20 Offset: 0x1DC7021 VA: 0x1DC6F20
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x1DC6F90 Offset: 0x1DC7091 VA: 0x1DC6F90
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x1DC7000 Offset: 0x1DC7101 VA: 0x1DC7000
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x1DC7070 Offset: 0x1DC7171 VA: 0x1DC7070
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x1DC70E0 Offset: 0x1DC71E1 VA: 0x1DC70E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x1DC7150 Offset: 0x1DC7251 VA: 0x1DC7150
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x1DC71C0 Offset: 0x1DC72C1 VA: 0x1DC71C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x1DC7230 Offset: 0x1DC7331 VA: 0x1DC7230
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x1DC72A0 Offset: 0x1DC73A1 VA: 0x1DC72A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x1DC7310 Offset: 0x1DC7411 VA: 0x1DC7310
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x1DC7380 Offset: 0x1DC7481 VA: 0x1DC7380
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x1DC73F0 Offset: 0x1DC74F1 VA: 0x1DC73F0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x1DC7460 Offset: 0x1DC7561 VA: 0x1DC7460
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x1DC74D0 Offset: 0x1DC75D1 VA: 0x1DC74D0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x1DC7540 Offset: 0x1DC7641 VA: 0x1DC7540
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x1DC75B0 Offset: 0x1DC76B1 VA: 0x1DC75B0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x1DC7620 Offset: 0x1DC7721 VA: 0x1DC7620
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x1DC7690 Offset: 0x1DC7791 VA: 0x1DC7690
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x1DC7700 Offset: 0x1DC7801 VA: 0x1DC7700
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x1DC7770 Offset: 0x1DC7871 VA: 0x1DC7770
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x1DC77E0 Offset: 0x1DC78E1 VA: 0x1DC77E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x1DC7850 Offset: 0x1DC7951 VA: 0x1DC7850
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x1DC78C0 Offset: 0x1DC79C1 VA: 0x1DC78C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1DC7930 Offset: 0x1DC7A31 VA: 0x1DC7930
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x1DC79A0 Offset: 0x1DC7AA1 VA: 0x1DC79A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x1DC7A10 Offset: 0x1DC7B11 VA: 0x1DC7A10
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x1DC7A80 Offset: 0x1DC7B81 VA: 0x1DC7A80
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x1DC7AF0 Offset: 0x1DC7BF1 VA: 0x1DC7AF0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x1DC7B60 Offset: 0x1DC7C61 VA: 0x1DC7B60
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x1DC7BD0 Offset: 0x1DC7CD1 VA: 0x1DC7BD0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x1DC7C40 Offset: 0x1DC7D41 VA: 0x1DC7C40
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x1DC7CB0 Offset: 0x1DC7DB1 VA: 0x1DC7CB0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x1DC7D20 Offset: 0x1DC7E21 VA: 0x1DC7D20
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x1DC7D90 Offset: 0x1DC7E91 VA: 0x1DC7D90
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x1DC7E00 Offset: 0x1DC7F01 VA: 0x1DC7E00
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x1DC7E70 Offset: 0x1DC7F71 VA: 0x1DC7E70
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x1DC7EE0 Offset: 0x1DC7FE1 VA: 0x1DC7EE0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x1DC7F50 Offset: 0x1DC8051 VA: 0x1DC7F50
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x1DC7FC0 Offset: 0x1DC80C1 VA: 0x1DC7FC0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x1DC8030 Offset: 0x1DC8131 VA: 0x1DC8030
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x1DC80A0 Offset: 0x1DC81A1 VA: 0x1DC80A0
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<int>>
	|
	|-RVA: 0x1DC8110 Offset: 0x1DC8211 VA: 0x1DC8110
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x1DC8180 Offset: 0x1DC8281 VA: 0x1DC8180
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<object>>
	|
	|-RVA: 0x1DC81F0 Offset: 0x1DC82F1 VA: 0x1DC81F0
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<uint>>
	|
	|-RVA: 0x1DC8260 Offset: 0x1DC8361 VA: 0x1DC8260
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<Edge>>
	|
	|-RVA: 0x1DC82D0 Offset: 0x1DC83D1 VA: 0x1DC82D0
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x1DC8340 Offset: 0x1DC8441 VA: 0x1DC8340
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x1DC83B0 Offset: 0x1DC84B1 VA: 0x1DC83B0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x1DC8420 Offset: 0x1DC8521 VA: 0x1DC8420
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x1DC8490 Offset: 0x1DC8591 VA: 0x1DC8490
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x1DC8500 Offset: 0x1DC8601 VA: 0x1DC8500
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x1DC8570 Offset: 0x1DC8671 VA: 0x1DC8570
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x1DC85E0 Offset: 0x1DC86E1 VA: 0x1DC85E0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x1DC8650 Offset: 0x1DC8751 VA: 0x1DC8650
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x1DC86C0 Offset: 0x1DC87C1 VA: 0x1DC86C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x1DC8730 Offset: 0x1DC8831 VA: 0x1DC8730
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x1DC87A0 Offset: 0x1DC88A1 VA: 0x1DC87A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x1DC8810 Offset: 0x1DC8911 VA: 0x1DC8810
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x1DC8880 Offset: 0x1DC8981 VA: 0x1DC8880
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<bool, object>>
	|
	|-RVA: 0x1DC88F0 Offset: 0x1DC89F1 VA: 0x1DC88F0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<byte, object>>
	|
	|-RVA: 0x1DC8960 Offset: 0x1DC8A61 VA: 0x1DC8960
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<char, object>>
	|
	|-RVA: 0x1DC89D0 Offset: 0x1DC8AD1 VA: 0x1DC89D0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x1DC8A40 Offset: 0x1DC8B41 VA: 0x1DC8A40
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<double, object>>
	|
	|-RVA: 0x1DC8AB0 Offset: 0x1DC8BB1 VA: 0x1DC8AB0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x1DC8B20 Offset: 0x1DC8C21 VA: 0x1DC8B20
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<short, object>>
	|
	|-RVA: 0x1DC8B90 Offset: 0x1DC8C91 VA: 0x1DC8B90
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x1DC8C00 Offset: 0x1DC8D01 VA: 0x1DC8C00
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x1DC8C70 Offset: 0x1DC8D71 VA: 0x1DC8C70
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x1DC8CE0 Offset: 0x1DC8DE1 VA: 0x1DC8CE0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x1DC8D50 Offset: 0x1DC8E51 VA: 0x1DC8D50
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x1DC8DC0 Offset: 0x1DC8EC1 VA: 0x1DC8DC0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, bool>>
	|
	|-RVA: 0x1DC8E30 Offset: 0x1DC8F31 VA: 0x1DC8E30
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, char>>
	|
	|-RVA: 0x1DC8EA0 Offset: 0x1DC8FA1 VA: 0x1DC8EA0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, int>>
	|
	|-RVA: 0x1DC8F10 Offset: 0x1DC9011 VA: 0x1DC8F10
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x1DC8F80 Offset: 0x1DC9081 VA: 0x1DC8F80
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, long>>
	|
	|-RVA: 0x1DC8FF0 Offset: 0x1DC90F1 VA: 0x1DC8FF0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, object>>
	|
	|-RVA: 0x1DC9060 Offset: 0x1DC9161 VA: 0x1DC9060
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x1DC90D0 Offset: 0x1DC91D1 VA: 0x1DC90D0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x1DC9140 Offset: 0x1DC9241 VA: 0x1DC9140
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x1DC91B0 Offset: 0x1DC92B1 VA: 0x1DC91B0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x1DC9220 Offset: 0x1DC9321 VA: 0x1DC9220
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x1DC9290 Offset: 0x1DC9391 VA: 0x1DC9290
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x1DC9300 Offset: 0x1DC9401 VA: 0x1DC9300
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x1DC9370 Offset: 0x1DC9471 VA: 0x1DC9370
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x1DC93E0 Offset: 0x1DC94E1 VA: 0x1DC93E0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x1DC9450 Offset: 0x1DC9551 VA: 0x1DC9450
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x1DC94C0 Offset: 0x1DC95C1 VA: 0x1DC94C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1DC9530 Offset: 0x1DC9631 VA: 0x1DC9530
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x1DC95A0 Offset: 0x1DC96A1 VA: 0x1DC95A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x1DC9610 Offset: 0x1DC9711 VA: 0x1DC9610
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x1DC9680 Offset: 0x1DC9781 VA: 0x1DC9680
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x1DC96F0 Offset: 0x1DC97F1 VA: 0x1DC96F0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x1DC9760 Offset: 0x1DC9861 VA: 0x1DC9760
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<long, object>>
	|
	|-RVA: 0x1DC97D0 Offset: 0x1DC98D1 VA: 0x1DC97D0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x1DC9840 Offset: 0x1DC9941 VA: 0x1DC9840
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x1DC98B0 Offset: 0x1DC99B1 VA: 0x1DC98B0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x1DC9920 Offset: 0x1DC9A21 VA: 0x1DC9920
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x1DC9990 Offset: 0x1DC9A91 VA: 0x1DC9990
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x1DC9A00 Offset: 0x1DC9B01 VA: 0x1DC9A00
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x1DC9A70 Offset: 0x1DC9B71 VA: 0x1DC9A70
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x1DC9AE0 Offset: 0x1DC9BE1 VA: 0x1DC9AE0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x1DC9B50 Offset: 0x1DC9C51 VA: 0x1DC9B50
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x1DC9BC0 Offset: 0x1DC9CC1 VA: 0x1DC9BC0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x1DC9C30 Offset: 0x1DC9D31 VA: 0x1DC9C30
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x1DC9CA0 Offset: 0x1DC9DA1 VA: 0x1DC9CA0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x1DC9D10 Offset: 0x1DC9E11 VA: 0x1DC9D10
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x1DC9D80 Offset: 0x1DC9E81 VA: 0x1DC9D80
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x1DC9DF0 Offset: 0x1DC9EF1 VA: 0x1DC9DF0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x1DC9E60 Offset: 0x1DC9F61 VA: 0x1DC9E60
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x1DC9ED0 Offset: 0x1DC9FD1 VA: 0x1DC9ED0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x1DC9F40 Offset: 0x1DCA041 VA: 0x1DC9F40
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x1DC9FB0 Offset: 0x1DCA0B1 VA: 0x1DC9FB0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x1DCA020 Offset: 0x1DCA121 VA: 0x1DCA020
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x1DCA090 Offset: 0x1DCA191 VA: 0x1DCA090
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x1DCA100 Offset: 0x1DCA201 VA: 0x1DCA100
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x1DCA170 Offset: 0x1DCA271 VA: 0x1DCA170
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x1DCA1E0 Offset: 0x1DCA2E1 VA: 0x1DCA1E0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x1DCA250 Offset: 0x1DCA351 VA: 0x1DCA250
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x1DCA2C0 Offset: 0x1DCA3C1 VA: 0x1DCA2C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x1DCA330 Offset: 0x1DCA431 VA: 0x1DCA330
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x1DCA3A0 Offset: 0x1DCA4A1 VA: 0x1DCA3A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x1DCA410 Offset: 0x1DCA511 VA: 0x1DCA410
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x1DCA480 Offset: 0x1DCA581 VA: 0x1DCA480
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x1DCA4F0 Offset: 0x1DCA5F1 VA: 0x1DCA4F0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x1DCA560 Offset: 0x1DCA661 VA: 0x1DCA560
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x1DCA5D0 Offset: 0x1DCA6D1 VA: 0x1DCA5D0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, bool>>
	|
	|-RVA: 0x1DCA640 Offset: 0x1DCA741 VA: 0x1DCA640
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, byte>>
	|
	|-RVA: 0x1DCA6B0 Offset: 0x1DCA7B1 VA: 0x1DCA6B0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, char>>
	|
	|-RVA: 0x1DCA720 Offset: 0x1DCA821 VA: 0x1DCA720
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x1DCA790 Offset: 0x1DCA891 VA: 0x1DCA790
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, double>>
	|
	|-RVA: 0x1DCA800 Offset: 0x1DCA901 VA: 0x1DCA800
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, short>>
	|
	|-RVA: 0x1DCA870 Offset: 0x1DCA971 VA: 0x1DCA870
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, int>>
	|
	|-RVA: 0x1DCA8E0 Offset: 0x1DCA9E1 VA: 0x1DCA8E0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x1DCA950 Offset: 0x1DCAA51 VA: 0x1DCA950
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, long>>
	|
	|-RVA: 0x1DCA9C0 Offset: 0x1DCAAC1 VA: 0x1DCA9C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x1DCAA30 Offset: 0x1DCAB31 VA: 0x1DCAA30
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x1DCAAA0 Offset: 0x1DCABA1 VA: 0x1DCAAA0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x1DCAB10 Offset: 0x1DCAC11 VA: 0x1DCAB10
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x1DCAB80 Offset: 0x1DCAC81 VA: 0x1DCAB80
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x1DCABF0 Offset: 0x1DCACF1 VA: 0x1DCABF0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x1DCAC60 Offset: 0x1DCAD61 VA: 0x1DCAC60
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x1DCACD0 Offset: 0x1DCADD1 VA: 0x1DCACD0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x1DCAD40 Offset: 0x1DCAE41 VA: 0x1DCAD40
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x1DCADB0 Offset: 0x1DCAEB1 VA: 0x1DCADB0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x1DCAE20 Offset: 0x1DCAF21 VA: 0x1DCAE20
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x1DCAE90 Offset: 0x1DCAF91 VA: 0x1DCAE90
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x1DCAF00 Offset: 0x1DCB001 VA: 0x1DCAF00
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x1DCAF70 Offset: 0x1DCB071 VA: 0x1DCAF70
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x1DCAFE0 Offset: 0x1DCB0E1 VA: 0x1DCAFE0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x1DCB050 Offset: 0x1DCB151 VA: 0x1DCB050
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x1DCB0C0 Offset: 0x1DCB1C1 VA: 0x1DCB0C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x1DCB130 Offset: 0x1DCB231 VA: 0x1DCB130
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x1DCB1A0 Offset: 0x1DCB2A1 VA: 0x1DCB1A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x1DCB210 Offset: 0x1DCB311 VA: 0x1DCB210
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x1DCB280 Offset: 0x1DCB381 VA: 0x1DCB280
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, object>>
	|
	|-RVA: 0x1DCB2F0 Offset: 0x1DCB3F1 VA: 0x1DCB2F0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x1DCB360 Offset: 0x1DCB461 VA: 0x1DCB360
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x1DCB3D0 Offset: 0x1DCB4D1 VA: 0x1DCB3D0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x1DCB440 Offset: 0x1DCB541 VA: 0x1DCB440
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, float>>
	|
	|-RVA: 0x1DCB4B0 Offset: 0x1DCB5B1 VA: 0x1DCB4B0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x1DCB520 Offset: 0x1DCB621 VA: 0x1DCB520
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, uint>>
	|
	|-RVA: 0x1DCB590 Offset: 0x1DCB691 VA: 0x1DCB590
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x1DCB600 Offset: 0x1DCB701 VA: 0x1DCB600
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x1DCB670 Offset: 0x1DCB771 VA: 0x1DCB670
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x1DCB6E0 Offset: 0x1DCB7E1 VA: 0x1DCB6E0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x1DCB750 Offset: 0x1DCB851 VA: 0x1DCB750
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x1DCB7C0 Offset: 0x1DCB8C1 VA: 0x1DCB7C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Color>>
	|
	|-RVA: 0x1DCB830 Offset: 0x1DCB931 VA: 0x1DCB830
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x1DCB8A0 Offset: 0x1DCB9A1 VA: 0x1DCB8A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x1DCB910 Offset: 0x1DCBA11 VA: 0x1DCB910
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x1DCB980 Offset: 0x1DCBA81 VA: 0x1DCB980
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x1DCB9F0 Offset: 0x1DCBAF1 VA: 0x1DCB9F0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x1DCBA60 Offset: 0x1DCBB61 VA: 0x1DCBA60
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x1DCBAD0 Offset: 0x1DCBBD1 VA: 0x1DCBAD0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x1DCBB40 Offset: 0x1DCBC41 VA: 0x1DCBB40
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x1DCBBB0 Offset: 0x1DCBCB1 VA: 0x1DCBBB0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x1DCBC20 Offset: 0x1DCBD21 VA: 0x1DCBC20
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x1DCBC90 Offset: 0x1DCBD91 VA: 0x1DCBC90
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1DCBD00 Offset: 0x1DCBE01 VA: 0x1DCBD00
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1DCBD70 Offset: 0x1DCBE71 VA: 0x1DCBD70
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x1DCBDE0 Offset: 0x1DCBEE1 VA: 0x1DCBDE0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x1DCBE50 Offset: 0x1DCBF51 VA: 0x1DCBE50
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x1DCBEC0 Offset: 0x1DCBFC1 VA: 0x1DCBEC0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x1DCBF30 Offset: 0x1DCC031 VA: 0x1DCBF30
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x1DCBFA0 Offset: 0x1DCC0A1 VA: 0x1DCBFA0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x1DCC010 Offset: 0x1DCC111 VA: 0x1DCC010
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x1DCC080 Offset: 0x1DCC181 VA: 0x1DCC080
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x1DCC0F0 Offset: 0x1DCC1F1 VA: 0x1DCC0F0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x1DCC160 Offset: 0x1DCC261 VA: 0x1DCC160
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<float, object>>
	|
	|-RVA: 0x1DCC1D0 Offset: 0x1DCC2D1 VA: 0x1DCC1D0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x1DCC240 Offset: 0x1DCC341 VA: 0x1DCC240
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, int>>
	|
	|-RVA: 0x1DCC2B0 Offset: 0x1DCC3B1 VA: 0x1DCC2B0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x1DCC320 Offset: 0x1DCC421 VA: 0x1DCC320
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, object>>
	|
	|-RVA: 0x1DCC390 Offset: 0x1DCC491 VA: 0x1DCC390
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x1DCC400 Offset: 0x1DCC501 VA: 0x1DCC400
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x1DCC470 Offset: 0x1DCC571 VA: 0x1DCC470
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x1DCC4E0 Offset: 0x1DCC5E1 VA: 0x1DCC4E0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x1DCC550 Offset: 0x1DCC651 VA: 0x1DCC550
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x1DCC5C0 Offset: 0x1DCC6C1 VA: 0x1DCC5C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x1DCC630 Offset: 0x1DCC731 VA: 0x1DCC630
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x1DCC6A0 Offset: 0x1DCC7A1 VA: 0x1DCC6A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x1DCC710 Offset: 0x1DCC811 VA: 0x1DCC710
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x1DCC780 Offset: 0x1DCC881 VA: 0x1DCC780
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Color, object>>
	|
	|-RVA: 0x1DCC7F0 Offset: 0x1DCC8F1 VA: 0x1DCC7F0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x1DCC860 Offset: 0x1DCC961 VA: 0x1DCC860
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1DCC8D0 Offset: 0x1DCC9D1 VA: 0x1DCC8D0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x1DCC940 Offset: 0x1DCCA41 VA: 0x1DCC940
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x1DCC9B0 Offset: 0x1DCCAB1 VA: 0x1DCC9B0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x1DCCA20 Offset: 0x1DCCB21 VA: 0x1DCCA20
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x1DCCA90 Offset: 0x1DCCB91 VA: 0x1DCCA90
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x1DCCB00 Offset: 0x1DCCC01 VA: 0x1DCCB00
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x1DCCB70 Offset: 0x1DCCC71 VA: 0x1DCCB70
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x1DCCBE0 Offset: 0x1DCCCE1 VA: 0x1DCCBE0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x1DCCC50 Offset: 0x1DCCD51 VA: 0x1DCCC50
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x1DCCCC0 Offset: 0x1DCCDC1 VA: 0x1DCCCC0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x1DCCD30 Offset: 0x1DCCE31 VA: 0x1DCCD30
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x1DCCDA0 Offset: 0x1DCCEA1 VA: 0x1DCCDA0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x1DCCE10 Offset: 0x1DCCF11 VA: 0x1DCCE10
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x1DCCE80 Offset: 0x1DCCF81 VA: 0x1DCCE80
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x1DCCEF0 Offset: 0x1DCCFF1 VA: 0x1DCCEF0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x1DCCF60 Offset: 0x1DCD061 VA: 0x1DCCF60
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x1DCCFD0 Offset: 0x1DCD0D1 VA: 0x1DCCFD0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x1DCD040 Offset: 0x1DCD141 VA: 0x1DCD040
	|-Array.InternalArray__ICollection_CopyTo<Hashtable.bucket>
	|
	|-RVA: 0x1F72D70 Offset: 0x1F72E71 VA: 0x1F72D70
	|-Array.InternalArray__ICollection_CopyTo<DateTime>
	|
	|-RVA: 0x1F72DE0 Offset: 0x1F72EE1 VA: 0x1F72DE0
	|-Array.InternalArray__ICollection_CopyTo<DateTimeOffset>
	|
	|-RVA: 0x1F72E50 Offset: 0x1F72F51 VA: 0x1F72E50
	|-Array.InternalArray__ICollection_CopyTo<Decimal>
	|
	|-RVA: 0x1F72EC0 Offset: 0x1F72FC1 VA: 0x1F72EC0
	|-Array.InternalArray__ICollection_CopyTo<double>
	|
	|-RVA: 0x1F72F30 Offset: 0x1F73031 VA: 0x1F72F30
	|-Array.InternalArray__ICollection_CopyTo<InternalCodePageDataItem>
	|
	|-RVA: 0x1F72FA0 Offset: 0x1F730A1 VA: 0x1F72FA0
	|-Array.InternalArray__ICollection_CopyTo<InternalEncodingDataItem>
	|
	|-RVA: 0x1F73010 Offset: 0x1F73111 VA: 0x1F73010
	|-Array.InternalArray__ICollection_CopyTo<Guid>
	|
	|-RVA: 0x1F73080 Offset: 0x1F73181 VA: 0x1F73080
	|-Array.InternalArray__ICollection_CopyTo<short>
	|
	|-RVA: 0x1F730F0 Offset: 0x1F731F1 VA: 0x1F730F0
	|-Array.InternalArray__ICollection_CopyTo<int>
	|
	|-RVA: 0x1F73160 Offset: 0x1F73261 VA: 0x1F73160
	|-Array.InternalArray__ICollection_CopyTo<Int32Enum>
	|
	|-RVA: 0x1F731D0 Offset: 0x1F732D1 VA: 0x1F731D0
	|-Array.InternalArray__ICollection_CopyTo<long>
	|
	|-RVA: 0x1F73240 Offset: 0x1F73341 VA: 0x1F73240
	|-Array.InternalArray__ICollection_CopyTo<IntPtr>
	|
	|-RVA: 0x1F732B0 Offset: 0x1F733B1 VA: 0x1F732B0
	|-Array.InternalArray__ICollection_CopyTo<InterpretedFrameInfo>
	|
	|-RVA: 0x1F73320 Offset: 0x1F73421 VA: 0x1F73320
	|-Array.InternalArray__ICollection_CopyTo<LocalDefinition>
	|
	|-RVA: 0x1F73390 Offset: 0x1F73491 VA: 0x1F73390
	|-Array.InternalArray__ICollection_CopyTo<RuntimeLabel>
	|
	|-RVA: 0x1F73400 Offset: 0x1F73501 VA: 0x1F73400
	|-Array.InternalArray__ICollection_CopyTo<Set.Slot<int>>
	|
	|-RVA: 0x1F73470 Offset: 0x1F73571 VA: 0x1F73470
	|-Array.InternalArray__ICollection_CopyTo<Set.Slot<object>>
	|
	|-RVA: 0x1F734E0 Offset: 0x1F735E1 VA: 0x1F734E0
	|-Array.InternalArray__ICollection_CopyTo<Memory<object>>
	|
	|-RVA: 0x1F73550 Offset: 0x1F73651 VA: 0x1F73550
	|-Array.InternalArray__ICollection_CopyTo<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x1F735C0 Offset: 0x1F736C1 VA: 0x1F735C0
	|-Array.InternalArray__ICollection_CopyTo<HeaderVariantInfo>
	|
	|-RVA: 0x1F73630 Offset: 0x1F73731 VA: 0x1F73630
	|-Array.InternalArray__ICollection_CopyTo<Socket.WSABUF>
	|
	|-RVA: 0x1F736A0 Offset: 0x1F737A1 VA: 0x1F736A0
	|-Array.InternalArray__ICollection_CopyTo<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x1F73710 Offset: 0x1F73811 VA: 0x1F73710
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Int32Enum>>
	|
	|-RVA: 0x1F73780 Offset: 0x1F73881 VA: 0x1F73780
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Bounds>>
	|
	|-RVA: 0x1F737F0 Offset: 0x1F738F1 VA: 0x1F737F0
	|-Array.InternalArray__ICollection_CopyTo<Nullable<BoundsInt>>
	|
	|-RVA: 0x1F73860 Offset: 0x1F73961 VA: 0x1F73860
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Color32>>
	|
	|-RVA: 0x1F738D0 Offset: 0x1F739D1 VA: 0x1F738D0
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Color>>
	|
	|-RVA: 0x1F73940 Offset: 0x1F73A41 VA: 0x1F73940
	|-Array.InternalArray__ICollection_CopyTo<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1F739B0 Offset: 0x1F73AB1 VA: 0x1F739B0
	|-Array.InternalArray__ICollection_CopyTo<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1F73A20 Offset: 0x1F73B21 VA: 0x1F73A20
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Keyframe>>
	|
	|-RVA: 0x1F73A90 Offset: 0x1F73B91 VA: 0x1F73A90
	|-Array.InternalArray__ICollection_CopyTo<Nullable<LayerMask>>
	|
	|-RVA: 0x1F73B00 Offset: 0x1F73C01 VA: 0x1F73B00
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1F73B70 Offset: 0x1F73C71 VA: 0x1F73B70
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Quaternion>>
	|
	|-RVA: 0x1F73BE0 Offset: 0x1F73CE1 VA: 0x1F73BE0
	|-Array.InternalArray__ICollection_CopyTo<Nullable<RangeInt>>
	|
	|-RVA: 0x1F73C50 Offset: 0x1F73D51 VA: 0x1F73C50
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Rect>>
	|
	|-RVA: 0x1F73CC0 Offset: 0x1F73DC1 VA: 0x1F73CC0
	|-Array.InternalArray__ICollection_CopyTo<Nullable<RectInt>>
	|
	|-RVA: 0x1F73D30 Offset: 0x1F73E31 VA: 0x1F73D30
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Vector2>>
	|
	|-RVA: 0x1F73DA0 Offset: 0x1F73EA1 VA: 0x1F73DA0
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Vector2Int>>
	|
	|-RVA: 0x1F73E10 Offset: 0x1F73F11 VA: 0x1F73E10
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Vector3>>
	|
	|-RVA: 0x1F73E80 Offset: 0x1F73F81 VA: 0x1F73E80
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Vector3Int>>
	|
	|-RVA: 0x1F73EF0 Offset: 0x1F73FF1 VA: 0x1F73EF0
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Vector4>>
	|
	|-RVA: 0x1F73F60 Offset: 0x1F74061 VA: 0x1F73F60
	|-Array.InternalArray__ICollection_CopyTo<object>
	|
	|-RVA: 0x1F73FD0 Offset: 0x1F740D1 VA: 0x1F73FD0
	|-Array.InternalArray__ICollection_CopyTo<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x1F74040 Offset: 0x1F74141 VA: 0x1F74040
	|-Array.InternalArray__ICollection_CopyTo<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1F740B0 Offset: 0x1F741B1 VA: 0x1F740B0
	|-Array.InternalArray__ICollection_CopyTo<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1F74120 Offset: 0x1F74221 VA: 0x1F74120
	|-Array.InternalArray__ICollection_CopyTo<CustomAttributeTypedArgument>
	|
	|-RVA: 0x1F74190 Offset: 0x1F74291 VA: 0x1F74190
	|-Array.InternalArray__ICollection_CopyTo<Label>
	|
	|-RVA: 0x1F74200 Offset: 0x1F74301 VA: 0x1F74200
	|-Array.InternalArray__ICollection_CopyTo<ParameterModifier>
	|
	|-RVA: 0x1F74270 Offset: 0x1F74371 VA: 0x1F74270
	|-Array.InternalArray__ICollection_CopyTo<ResourceLocator>
	|
	|-RVA: 0x1F742E0 Offset: 0x1F743E1 VA: 0x1F742E0
	|-Array.InternalArray__ICollection_CopyTo<Ephemeron>
	|
	|-RVA: 0x1F74350 Offset: 0x1F74451 VA: 0x1F74350
	|-Array.InternalArray__ICollection_CopyTo<GCHandle>
	|
	|-RVA: 0x1F743C0 Offset: 0x1F744C1 VA: 0x1F743C0
	|-Array.InternalArray__ICollection_CopyTo<RuntimeTypeHandle>
	|
	|-RVA: 0x1F74430 Offset: 0x1F74531 VA: 0x1F74430
	|-Array.InternalArray__ICollection_CopyTo<sbyte>
	|
	|-RVA: 0x1F744A0 Offset: 0x1F745A1 VA: 0x1F744A0
	|-Array.InternalArray__ICollection_CopyTo<X509ChainStatus>
	|
	|-RVA: 0x1F74510 Offset: 0x1F74611 VA: 0x1F74510
	|-Array.InternalArray__ICollection_CopyTo<float>
	|
	|-RVA: 0x1F74580 Offset: 0x1F74681 VA: 0x1F74580
	|-Array.InternalArray__ICollection_CopyTo<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x1F745F0 Offset: 0x1F746F1 VA: 0x1F745F0
	|-Array.InternalArray__ICollection_CopyTo<CancellationTokenRegistration>
	|
	|-RVA: 0x1F74660 Offset: 0x1F74761 VA: 0x1F74660
	|-Array.InternalArray__ICollection_CopyTo<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x1F746D0 Offset: 0x1F747D1 VA: 0x1F746D0
	|-Array.InternalArray__ICollection_CopyTo<TimeSpan>
	|
	|-RVA: 0x1F74740 Offset: 0x1F74841 VA: 0x1F74740
	|-Array.InternalArray__ICollection_CopyTo<ushort>
	|
	|-RVA: 0x1F747B0 Offset: 0x1F748B1 VA: 0x1F747B0
	|-Array.InternalArray__ICollection_CopyTo<UInt16Enum>
	|
	|-RVA: 0x1F74820 Offset: 0x1F74921 VA: 0x1F74820
	|-Array.InternalArray__ICollection_CopyTo<uint>
	|
	|-RVA: 0x1F74890 Offset: 0x1F74991 VA: 0x1F74890
	|-Array.InternalArray__ICollection_CopyTo<UInt32Enum>
	|
	|-RVA: 0x1F74900 Offset: 0x1F74A01 VA: 0x1F74900
	|-Array.InternalArray__ICollection_CopyTo<ulong>
	|
	|-RVA: 0x1F74970 Offset: 0x1F74A71 VA: 0x1F74970
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x1F749E0 Offset: 0x1F74AE1 VA: 0x1F749E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x1F74A50 Offset: 0x1F74B51 VA: 0x1F74A50
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x1F74AC0 Offset: 0x1F74BC1 VA: 0x1F74AC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x1F74B30 Offset: 0x1F74C31 VA: 0x1F74B30
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object>>
	|
	|-RVA: 0x1F74BA0 Offset: 0x1F74CA1 VA: 0x1F74BA0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, float>>
	|
	|-RVA: 0x1F74C10 Offset: 0x1F74D11 VA: 0x1F74C10
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<float, object>>
	|
	|-RVA: 0x1F74C80 Offset: 0x1F74D81 VA: 0x1F74C80
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<float, float>>
	|
	|-RVA: 0x1F74CF0 Offset: 0x1F74DF1 VA: 0x1F74CF0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x1F74D60 Offset: 0x1F74E61 VA: 0x1F74D60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1F74DD0 Offset: 0x1F74ED1 VA: 0x1F74DD0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x1F74E40 Offset: 0x1F74F41 VA: 0x1F74E40
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x1F74EB0 Offset: 0x1F74FB1 VA: 0x1F74EB0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x1F74F20 Offset: 0x1F75021 VA: 0x1F74F20
	|-Array.InternalArray__ICollection_CopyTo<HighlightState>
	|
	|-RVA: 0x1F74F90 Offset: 0x1F75091 VA: 0x1F74F90
	|-Array.InternalArray__ICollection_CopyTo<MaterialReference>
	|
	|-RVA: 0x1F75000 Offset: 0x1F75101 VA: 0x1F75000
	|-Array.InternalArray__ICollection_CopyTo<RichTextTagAttribute>
	|
	|-RVA: 0x1F75070 Offset: 0x1F75171 VA: 0x1F75070
	|-Array.InternalArray__ICollection_CopyTo<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x1F750E0 Offset: 0x1F751E1 VA: 0x1F750E0
	|-Array.InternalArray__ICollection_CopyTo<TMP_CharacterInfo>
	|
	|-RVA: 0x1F75150 Offset: 0x1F75251 VA: 0x1F75150
	|-Array.InternalArray__ICollection_CopyTo<TMP_FontWeightPair>
	|
	|-RVA: 0x1F751C0 Offset: 0x1F752C1 VA: 0x1F751C0
	|-Array.InternalArray__ICollection_CopyTo<TMP_LineInfo>
	|
	|-RVA: 0x1F75230 Offset: 0x1F75331 VA: 0x1F75230
	|-Array.InternalArray__ICollection_CopyTo<TMP_LinkInfo>
	|
	|-RVA: 0x1F752A0 Offset: 0x1F753A1 VA: 0x1F752A0
	|-Array.InternalArray__ICollection_CopyTo<TMP_MeshInfo>
	|
	|-RVA: 0x1F75310 Offset: 0x1F75411 VA: 0x1F75310
	|-Array.InternalArray__ICollection_CopyTo<TMP_PageInfo>
	|
	|-RVA: 0x1F75380 Offset: 0x1F75481 VA: 0x1F75380
	|-Array.InternalArray__ICollection_CopyTo<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x1F753F0 Offset: 0x1F754F1 VA: 0x1F753F0
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x1F75460 Offset: 0x1F75561 VA: 0x1F75460
	|-Array.InternalArray__ICollection_CopyTo<TMP_WordInfo>
	|
	|-RVA: 0x1F754D0 Offset: 0x1F755D1 VA: 0x1F754D0
	|-Array.InternalArray__ICollection_CopyTo<WordWrapState>
	|
	|-RVA: 0x1F75540 Offset: 0x1F75641 VA: 0x1F75540
	|-Array.InternalArray__ICollection_CopyTo<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x1F755B0 Offset: 0x1F756B1 VA: 0x1F755B0
	|-Array.InternalArray__ICollection_CopyTo<TransitionTables>
	|
	|-RVA: 0x1F75620 Offset: 0x1F75721 VA: 0x1F75620
	|-Array.InternalArray__ICollection_CopyTo<TutorialUnlockFlagData>
	|
	|-RVA: 0x1F75690 Offset: 0x1F75791 VA: 0x1F75690
	|-Array.InternalArray__ICollection_CopyTo<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x1F75700 Offset: 0x1F75801 VA: 0x1F75700
	|-Array.InternalArray__ICollection_CopyTo<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x1F75770 Offset: 0x1F75871 VA: 0x1F75770
	|-Array.InternalArray__ICollection_CopyTo<CapEdge>
	|
	|-RVA: 0x1F757E0 Offset: 0x1F758E1 VA: 0x1F757E0
	|-Array.InternalArray__ICollection_CopyTo<ClippedEdge>
	|
	|-RVA: 0x1F75850 Offset: 0x1F75951 VA: 0x1F75850
	|-Array.InternalArray__ICollection_CopyTo<EdgeKeyByHash>
	|
	|-RVA: 0x1F758C0 Offset: 0x1F759C1 VA: 0x1F758C0
	|-Array.InternalArray__ICollection_CopyTo<EdgeKeyByIndex>
	|
	|-RVA: 0x1F75930 Offset: 0x1F75A31 VA: 0x1F75930
	|-Array.InternalArray__ICollection_CopyTo<MeshDataConnectivity.Face>
	|
	|-RVA: 0x1F759A0 Offset: 0x1F75AA1 VA: 0x1F759A0
	|-Array.InternalArray__ICollection_CopyTo<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x1F75A10 Offset: 0x1F75B11 VA: 0x1F75A10
	|-Array.InternalArray__ICollection_CopyTo<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x1F75A80 Offset: 0x1F75B81 VA: 0x1F75A80
	|-Array.InternalArray__ICollection_CopyTo<NavMeshBuildMarkup>
	|
	|-RVA: 0x1F75AF0 Offset: 0x1F75BF1 VA: 0x1F75AF0
	|-Array.InternalArray__ICollection_CopyTo<NavMeshBuildSource>
	|
	|-RVA: 0x1F75B60 Offset: 0x1F75C61 VA: 0x1F75B60
	|-Array.InternalArray__ICollection_CopyTo<ContentCatalogData.Bucket>
	|
	|-RVA: 0x1F75BD0 Offset: 0x1F75CD1 VA: 0x1F75BD0
	|-Array.InternalArray__ICollection_CopyTo<ConstraintSource>
	|
	|-RVA: 0x1F75C40 Offset: 0x1F75D41 VA: 0x1F75C40
	|-Array.InternalArray__ICollection_CopyTo<PropertySceneHandle>
	|
	|-RVA: 0x1F75CB0 Offset: 0x1F75DB1 VA: 0x1F75CB0
	|-Array.InternalArray__ICollection_CopyTo<TransformStreamHandle>
	|
	|-RVA: 0x1F75D20 Offset: 0x1F75E21 VA: 0x1F75D20
	|-Array.InternalArray__ICollection_CopyTo<AnimatorClipInfo>
	|
	|-RVA: 0x1F75D90 Offset: 0x1F75E91 VA: 0x1F75D90
	|-Array.InternalArray__ICollection_CopyTo<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x1F75E00 Offset: 0x1F75F01 VA: 0x1F75E00
	|-Array.InternalArray__ICollection_CopyTo<BoneWeight1>
	|
	|-RVA: 0x1F75E70 Offset: 0x1F75F71 VA: 0x1F75E70
	|-Array.InternalArray__ICollection_CopyTo<BoneWeight>
	|
	|-RVA: 0x1F75EE0 Offset: 0x1F75FE1 VA: 0x1F75EE0
	|-Array.InternalArray__ICollection_CopyTo<BoundingSphere>
	|
	|-RVA: 0x1F75F50 Offset: 0x1F76051 VA: 0x1F75F50
	|-Array.InternalArray__ICollection_CopyTo<Bounds>
	|
	|-RVA: 0x1F75FC0 Offset: 0x1F760C1 VA: 0x1F75FC0
	|-Array.InternalArray__ICollection_CopyTo<BoundsInt>
	|
	|-RVA: 0x1F76030 Offset: 0x1F76131 VA: 0x1F76030
	|-Array.InternalArray__ICollection_CopyTo<CharacterInfo>
	|
	|-RVA: 0x1F760A0 Offset: 0x1F761A1 VA: 0x1F760A0
	|-Array.InternalArray__ICollection_CopyTo<Color32>
	|
	|-RVA: 0x1F76110 Offset: 0x1F76211 VA: 0x1F76110
	|-Array.InternalArray__ICollection_CopyTo<Color>
	|
	|-RVA: 0x1F76180 Offset: 0x1F76281 VA: 0x1F76180
	|-Array.InternalArray__ICollection_CopyTo<CombineInstance>
	|
	|-RVA: 0x1F761F0 Offset: 0x1F762F1 VA: 0x1F761F0
	|-Array.InternalArray__ICollection_CopyTo<ContactPoint2D>
	|
	|-RVA: 0x1F76260 Offset: 0x1F76361 VA: 0x1F76260
	|-Array.InternalArray__ICollection_CopyTo<ContactPoint>
	|
	|-RVA: 0x1F762D0 Offset: 0x1F763D1 VA: 0x1F762D0
	|-Array.InternalArray__ICollection_CopyTo<RaycastResult>
	|
	|-RVA: 0x1F76340 Offset: 0x1F76441 VA: 0x1F76340
	|-Array.InternalArray__ICollection_CopyTo<LightDataGI>
	|
	|-RVA: 0x1F763B0 Offset: 0x1F764B1 VA: 0x1F763B0
	|-Array.InternalArray__ICollection_CopyTo<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x1F76420 Offset: 0x1F76521 VA: 0x1F76420
	|-Array.InternalArray__ICollection_CopyTo<GradientAlphaKey>
	|
	|-RVA: 0x1F76490 Offset: 0x1F76591 VA: 0x1F76490
	|-Array.InternalArray__ICollection_CopyTo<GradientColorKey>
	|
	|-RVA: 0x1F76500 Offset: 0x1F76601 VA: 0x1F76500
	|-Array.InternalArray__ICollection_CopyTo<HumanBone>
	|
	|-RVA: 0x1F76570 Offset: 0x1F76671 VA: 0x1F76570
	|-Array.InternalArray__ICollection_CopyTo<Keyframe>
	|
	|-RVA: 0x1F765E0 Offset: 0x1F766E1 VA: 0x1F765E0
	|-Array.InternalArray__ICollection_CopyTo<LOD>
	|
	|-RVA: 0x1F76650 Offset: 0x1F76751 VA: 0x1F76650
	|-Array.InternalArray__ICollection_CopyTo<LayerMask>
	|
	|-RVA: 0x1F766C0 Offset: 0x1F767C1 VA: 0x1F766C0
	|-Array.InternalArray__ICollection_CopyTo<PlayerLoopSystem>
	|
	|-RVA: 0x1F76730 Offset: 0x1F76831 VA: 0x1F76730
	|-Array.InternalArray__ICollection_CopyTo<Matrix4x4>
	|
	|-RVA: 0x1F767A0 Offset: 0x1F768A1 VA: 0x1F767A0
	|-Array.InternalArray__ICollection_CopyTo<ParticleSystem.Particle>
	|
	|-RVA: 0x1F76810 Offset: 0x1F76911 VA: 0x1F76810
	|-Array.InternalArray__ICollection_CopyTo<PatchExtents>
	|
	|-RVA: 0x1F76880 Offset: 0x1F76981 VA: 0x1F76880
	|-Array.InternalArray__ICollection_CopyTo<Plane>
	|
	|-RVA: 0x1F768F0 Offset: 0x1F769F1 VA: 0x1F768F0
	|-Array.InternalArray__ICollection_CopyTo<Playable>
	|
	|-RVA: 0x1F76960 Offset: 0x1F76A61 VA: 0x1F76960
	|-Array.InternalArray__ICollection_CopyTo<PlayableBinding>
	|
	|-RVA: 0x1F769D0 Offset: 0x1F76AD1 VA: 0x1F769D0
	|-Array.InternalArray__ICollection_CopyTo<PlayableGraph>
	|
	|-RVA: 0x1F76A40 Offset: 0x1F76B41 VA: 0x1F76A40
	|-Array.InternalArray__ICollection_CopyTo<Edge>
	|
	|-RVA: 0x1F76AB0 Offset: 0x1F76BB1 VA: 0x1F76AB0
	|-Array.InternalArray__ICollection_CopyTo<IntVec3>
	|
	|-RVA: 0x1F76B20 Offset: 0x1F76C21 VA: 0x1F76B20
	|-Array.InternalArray__ICollection_CopyTo<Quaternion>
	|
	|-RVA: 0x1F76B90 Offset: 0x1F76C91 VA: 0x1F76B90
	|-Array.InternalArray__ICollection_CopyTo<RangeInt>
	|
	|-RVA: 0x1F76C00 Offset: 0x1F76D01 VA: 0x1F76C00
	|-Array.InternalArray__ICollection_CopyTo<RaycastHit2D>
	|
	|-RVA: 0x1F76C70 Offset: 0x1F76D71 VA: 0x1F76C70
	|-Array.InternalArray__ICollection_CopyTo<RaycastHit>
	|
	|-RVA: 0x1F76CE0 Offset: 0x1F76DE1 VA: 0x1F76CE0
	|-Array.InternalArray__ICollection_CopyTo<Rect>
	|
	|-RVA: 0x1F76D50 Offset: 0x1F76E51 VA: 0x1F76D50
	|-Array.InternalArray__ICollection_CopyTo<RectInt>
	|
	|-RVA: 0x1F76DC0 Offset: 0x1F76EC1 VA: 0x1F76DC0
	|-Array.InternalArray__ICollection_CopyTo<RenderBuffer>
	|
	|-RVA: 0x1F76E30 Offset: 0x1F76F31 VA: 0x1F76E30
	|-Array.InternalArray__ICollection_CopyTo<BatchVisibility>
	|
	|-RVA: 0x1F76EA0 Offset: 0x1F76FA1 VA: 0x1F76EA0
	|-Array.InternalArray__ICollection_CopyTo<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x1F76F10 Offset: 0x1F77011 VA: 0x1F76F10
	|-Array.InternalArray__ICollection_CopyTo<SphericalHarmonicsL2>
	|
	|-RVA: 0x1F76F80 Offset: 0x1F77081 VA: 0x1F76F80
	|-Array.InternalArray__ICollection_CopyTo<VertexAttributeDescriptor>
	|
	|-RVA: 0x1F76FF0 Offset: 0x1F770F1 VA: 0x1F76FF0
	|-Array.InternalArray__ICollection_CopyTo<AsyncOperationHandle>
	|
	|-RVA: 0x1F77060 Offset: 0x1F77161 VA: 0x1F77060
	|-Array.InternalArray__ICollection_CopyTo<AsyncOperationHandle<object>>
	|
	|-RVA: 0x1F770D0 Offset: 0x1F771D1 VA: 0x1F770D0
	|-Array.InternalArray__ICollection_CopyTo<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x1F77140 Offset: 0x1F77241 VA: 0x1F77140
	|-Array.InternalArray__ICollection_CopyTo<DiagnosticEvent>
	|
	|-RVA: 0x1F771B0 Offset: 0x1F772B1 VA: 0x1F771B0
	|-Array.InternalArray__ICollection_CopyTo<SceneInstance>
	|
	|-RVA: 0x1F77220 Offset: 0x1F77321 VA: 0x1F77220
	|-Array.InternalArray__ICollection_CopyTo<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x1F77290 Offset: 0x1F77391 VA: 0x1F77290
	|-Array.InternalArray__ICollection_CopyTo<ObjectInitializationData>
	|
	|-RVA: 0x1F77300 Offset: 0x1F77401 VA: 0x1F77300
	|-Array.InternalArray__ICollection_CopyTo<SerializedType>
	|
	|-RVA: 0x1F77370 Offset: 0x1F77471 VA: 0x1F77370
	|-Array.InternalArray__ICollection_CopyTo<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x1F773E0 Offset: 0x1F774E1 VA: 0x1F773E0
	|-Array.InternalArray__ICollection_CopyTo<SkeletonBone>
	|
	|-RVA: 0x1F77450 Offset: 0x1F77551 VA: 0x1F77450
	|-Array.InternalArray__ICollection_CopyTo<GlyphRect>
	|
	|-RVA: 0x1F774C0 Offset: 0x1F775C1 VA: 0x1F774C0
	|-Array.InternalArray__ICollection_CopyTo<GlyphMarshallingStruct>
	|
	|-RVA: 0x1F77530 Offset: 0x1F77631 VA: 0x1F77530
	|-Array.InternalArray__ICollection_CopyTo<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x1F775A0 Offset: 0x1F776A1 VA: 0x1F775A0
	|-Array.InternalArray__ICollection_CopyTo<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x1F77610 Offset: 0x1F77711 VA: 0x1F77610
	|-Array.InternalArray__ICollection_CopyTo<IntervalTreeNode>
	|
	|-RVA: 0x1F77680 Offset: 0x1F77781 VA: 0x1F77680
	|-Array.InternalArray__ICollection_CopyTo<IntervalTree.Entry<object>>
	|
	|-RVA: 0x1F776F0 Offset: 0x1F777F1 VA: 0x1F776F0
	|-Array.InternalArray__ICollection_CopyTo<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x1F77760 Offset: 0x1F77861 VA: 0x1F77760
	|-Array.InternalArray__ICollection_CopyTo<Touch>
	|
	|-RVA: 0x1F777D0 Offset: 0x1F778D1 VA: 0x1F777D0
	|-Array.InternalArray__ICollection_CopyTo<TreeInstance>
	|
	|-RVA: 0x1F77840 Offset: 0x1F77941 VA: 0x1F77840
	|-Array.InternalArray__ICollection_CopyTo<ColorBlock>
	|
	|-RVA: 0x1F778B0 Offset: 0x1F779B1 VA: 0x1F778B0
	|-Array.InternalArray__ICollection_CopyTo<Navigation>
	|
	|-RVA: 0x1F77920 Offset: 0x1F77A21 VA: 0x1F77920
	|-Array.InternalArray__ICollection_CopyTo<SpriteState>
	|
	|-RVA: 0x1F77990 Offset: 0x1F77A91 VA: 0x1F77990
	|-Array.InternalArray__ICollection_CopyTo<UICharInfo>
	|
	|-RVA: 0x1F77A00 Offset: 0x1F77B01 VA: 0x1F77A00
	|-Array.InternalArray__ICollection_CopyTo<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x1F77A70 Offset: 0x1F77B71 VA: 0x1F77A70
	|-Array.InternalArray__ICollection_CopyTo<EventDispatcher.EventRecord>
	|
	|-RVA: 0x1F77AE0 Offset: 0x1F77BE1 VA: 0x1F77AE0
	|-Array.InternalArray__ICollection_CopyTo<FocusController.FocusedElement>
	|
	|-RVA: 0x1F77B50 Offset: 0x1F77C51 VA: 0x1F77B50
	|-Array.InternalArray__ICollection_CopyTo<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x1F77BC0 Offset: 0x1F77CC1 VA: 0x1F77BC0
	|-Array.InternalArray__ICollection_CopyTo<StyleValue>
	|
	|-RVA: 0x1F77C30 Offset: 0x1F77D31 VA: 0x1F77C30
	|-Array.InternalArray__ICollection_CopyTo<UILineInfo>
	|
	|-RVA: 0x1F77CA0 Offset: 0x1F77DA1 VA: 0x1F77CA0
	|-Array.InternalArray__ICollection_CopyTo<UIVertex>
	|
	|-RVA: 0x1F77D10 Offset: 0x1F77E11 VA: 0x1F77D10
	|-Array.InternalArray__ICollection_CopyTo<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x1F77D80 Offset: 0x1F77E81 VA: 0x1F77D80
	|-Array.InternalArray__ICollection_CopyTo<Vector2>
	|
	|-RVA: 0x1F77DF0 Offset: 0x1F77EF1 VA: 0x1F77DF0
	|-Array.InternalArray__ICollection_CopyTo<Vector2Int>
	|
	|-RVA: 0x1F77E60 Offset: 0x1F77F61 VA: 0x1F77E60
	|-Array.InternalArray__ICollection_CopyTo<Vector3>
	|
	|-RVA: 0x1F77ED0 Offset: 0x1F77FD1 VA: 0x1F77ED0
	|-Array.InternalArray__ICollection_CopyTo<Vector3Int>
	|
	|-RVA: 0x1F77F40 Offset: 0x1F78041 VA: 0x1F77F40
	|-Array.InternalArray__ICollection_CopyTo<Vector4>
	|
	|-RVA: 0x1F77FB0 Offset: 0x1F780B1 VA: 0x1F77FB0
	|-Array.InternalArray__ICollection_CopyTo<jvalue>
	|
	|-RVA: 0x1F78020 Offset: 0x1F78121 VA: 0x1F78020
	|-Array.InternalArray__ICollection_CopyTo<WarpPoints.WarpPoint>
	|
	|-RVA: 0x1F78090 Offset: 0x1F78191 VA: 0x1F78090
	|-Array.InternalArray__ICollection_CopyTo<YieldItemParam>
	|
	|-RVA: 0x1F78100 Offset: 0x1F78201 VA: 0x1F78100
	|-Array.InternalArray__ICollection_CopyTo<NetworkServiceAccountId>
	|
	|-RVA: 0x1F78170 Offset: 0x1F78271 VA: 0x1F78170
	|-Array.InternalArray__ICollection_CopyTo<Uid>
	|
	|-RVA: 0x1F781E0 Offset: 0x1F782E1 VA: 0x1F781E0
	|-Array.InternalArray__ICollection_CopyTo<ConsumableServiceItemId>
	|
	|-RVA: 0x1F78250 Offset: 0x1F78351 VA: 0x1F78250
	|-Array.InternalArray__ICollection_CopyTo<NsUid>
	|
	|-RVA: 0x1F782C0 Offset: 0x1F783C1 VA: 0x1F782C0
	|-Array.InternalArray__ICollection_CopyTo<Friend>
	|
	|-RVA: 0x1F78330 Offset: 0x1F78431 VA: 0x1F78330
	|-Array.InternalArray__ICollection_CopyTo<Profile>
	|
	|-RVA: 0x1F783A0 Offset: 0x1F784A1 VA: 0x1F783A0
	|-Array.InternalArray__ICollection_CopyTo<DirectoryEntry>
	|
	|-RVA: 0x1F78410 Offset: 0x1F78511 VA: 0x1F78410
	|-Array.InternalArray__ICollection_CopyTo<DebugPadState>
	|
	|-RVA: 0x1F78480 Offset: 0x1F78581 VA: 0x1F78480
	|-Array.InternalArray__ICollection_CopyTo<GesturePoint>
	|
	|-RVA: 0x1F784F0 Offset: 0x1F785F1 VA: 0x1F784F0
	|-Array.InternalArray__ICollection_CopyTo<GestureState>
	|
	|-RVA: 0x1F78560 Offset: 0x1F78661 VA: 0x1F78560
	|-Array.InternalArray__ICollection_CopyTo<NpadFullKeyState>
	|
	|-RVA: 0x1F785D0 Offset: 0x1F786D1 VA: 0x1F785D0
	|-Array.InternalArray__ICollection_CopyTo<NpadHandheldState>
	|
	|-RVA: 0x1F78640 Offset: 0x1F78741 VA: 0x1F78640
	|-Array.InternalArray__ICollection_CopyTo<NpadJoyDualState>
	|
	|-RVA: 0x1F786B0 Offset: 0x1F787B1 VA: 0x1F786B0
	|-Array.InternalArray__ICollection_CopyTo<NpadJoyLeftState>
	|
	|-RVA: 0x1F78720 Offset: 0x1F78821 VA: 0x1F78720
	|-Array.InternalArray__ICollection_CopyTo<NpadJoyRightState>
	|
	|-RVA: 0x1F78790 Offset: 0x1F78891 VA: 0x1F78790
	|-Array.InternalArray__ICollection_CopyTo<NpadStateArrayItem>
	|
	|-RVA: 0x1F78800 Offset: 0x1F78901 VA: 0x1F78800
	|-Array.InternalArray__ICollection_CopyTo<SixAxisSensorHandle>
	|
	|-RVA: 0x1F78870 Offset: 0x1F78971 VA: 0x1F78870
	|-Array.InternalArray__ICollection_CopyTo<SixAxisSensorState>
	|
	|-RVA: 0x1F788E0 Offset: 0x1F789E1 VA: 0x1F788E0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState10>
	|
	|-RVA: 0x1F78950 Offset: 0x1F78A51 VA: 0x1F78950
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState11>
	|
	|-RVA: 0x1F789C0 Offset: 0x1F78AC1 VA: 0x1F789C0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState12>
	|
	|-RVA: 0x1F78A30 Offset: 0x1F78B31 VA: 0x1F78A30
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState13>
	|
	|-RVA: 0x1F78AA0 Offset: 0x1F78BA1 VA: 0x1F78AA0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState14>
	|
	|-RVA: 0x1F78B10 Offset: 0x1F78C11 VA: 0x1F78B10
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState15>
	|
	|-RVA: 0x1F78B80 Offset: 0x1F78C81 VA: 0x1F78B80
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState16>
	|
	|-RVA: 0x1F78BF0 Offset: 0x1F78CF1 VA: 0x1F78BF0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState1>
	|
	|-RVA: 0x1F78C60 Offset: 0x1F78D61 VA: 0x1F78C60
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState2>
	|
	|-RVA: 0x1F78CD0 Offset: 0x1F78DD1 VA: 0x1F78CD0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState3>
	|
	|-RVA: 0x1F78D40 Offset: 0x1F78E41 VA: 0x1F78D40
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState4>
	|
	|-RVA: 0x1F78DB0 Offset: 0x1F78EB1 VA: 0x1F78DB0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState5>
	|
	|-RVA: 0x1F78E20 Offset: 0x1F78F21 VA: 0x1F78E20
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState6>
	|
	|-RVA: 0x1F78E90 Offset: 0x1F78F91 VA: 0x1F78E90
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState7>
	|
	|-RVA: 0x1F78F00 Offset: 0x1F79001 VA: 0x1F78F00
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState8>
	|
	|-RVA: 0x1F78F70 Offset: 0x1F79071 VA: 0x1F78F70
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState9>
	|
	|-RVA: 0x1F78FE0 Offset: 0x1F790E1 VA: 0x1F78FE0
	|-Array.InternalArray__ICollection_CopyTo<TouchState>
	|
	|-RVA: 0x1F79050 Offset: 0x1F79151 VA: 0x1F79050
	|-Array.InternalArray__ICollection_CopyTo<VibrationDeviceHandle>
	|
	|-RVA: 0x1F790C0 Offset: 0x1F791C1 VA: 0x1F790C0
	|-Array.InternalArray__ICollection_CopyTo<VibrationDeviceInfo>
	|
	|-RVA: 0x1F79130 Offset: 0x1F79231 VA: 0x1F79130
	|-Array.InternalArray__ICollection_CopyTo<VibrationValue>
	|
	|-RVA: 0x1F791A0 Offset: 0x1F792A1 VA: 0x1F791A0
	|-Array.InternalArray__ICollection_CopyTo<ClusteringData>
	|
	|-RVA: 0x1F79210 Offset: 0x1F79311 VA: 0x1F79210
	|-Array.InternalArray__ICollection_CopyTo<ClusteringProcessorState>
	|
	|-RVA: 0x1F79280 Offset: 0x1F79381 VA: 0x1F79280
	|-Array.InternalArray__ICollection_CopyTo<Finger>
	|
	|-RVA: 0x1F792F0 Offset: 0x1F793F1 VA: 0x1F792F0
	|-Array.InternalArray__ICollection_CopyTo<Hand>
	|
	|-RVA: 0x1F79360 Offset: 0x1F79461 VA: 0x1F79360
	|-Array.InternalArray__ICollection_CopyTo<HandAnalysisImageState>
	|
	|-RVA: 0x1F793D0 Offset: 0x1F794D1 VA: 0x1F793D0
	|-Array.InternalArray__ICollection_CopyTo<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x1F79440 Offset: 0x1F79541 VA: 0x1F79440
	|-Array.InternalArray__ICollection_CopyTo<MomentProcessorState>
	|
	|-RVA: 0x1F794B0 Offset: 0x1F795B1 VA: 0x1F794B0
	|-Array.InternalArray__ICollection_CopyTo<MomentStatistic>
	|
	|-RVA: 0x1F79520 Offset: 0x1F79621 VA: 0x1F79520
	|-Array.InternalArray__ICollection_CopyTo<Protrusion>
	|
	|-RVA: 0x1F79590 Offset: 0x1F79691 VA: 0x1F79590
	|-Array.InternalArray__ICollection_CopyTo<Shape>
	|
	|-RVA: 0x1F79600 Offset: 0x1F79701 VA: 0x1F79600
	|-Array.InternalArray__ICollection_CopyTo<DictionaryInfo>
	|
	|-RVA: 0x1F79670 Offset: 0x1F79771 VA: 0x1F79670
	|-Array.InternalArray__ICollection_CopyTo<UserWord>
	|
	|-RVA: 0x1F796E0 Offset: 0x1F797E1 VA: 0x1F796E0
	|-Array.InternalArray__ICollection_CopyTo<Color4u8>
	|
	|-RVA: 0x1F79750 Offset: 0x1F79851 VA: 0x1F79750
	|-Array.InternalArray__ICollection_CopyTo<Float2>
	|
	|-RVA: 0x1F797C0 Offset: 0x1F798C1 VA: 0x1F797C0
	|-Array.InternalArray__ICollection_CopyTo<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	internal T InternalArray__IReadOnlyList_get_Item<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C8D80 Offset: 0x23C8E81 VA: 0x23C8D80
	|-Array.InternalArray__IReadOnlyList_get_Item<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x23C8E70 Offset: 0x23C8F71 VA: 0x23C8E70
	|-Array.InternalArray__IReadOnlyList_get_Item<ActionCommandDataTable>
	|
	|-RVA: 0x23C8F90 Offset: 0x23C9091 VA: 0x23C8F90
	|-Array.InternalArray__IReadOnlyList_get_Item<AdvScriptDefCountParam>
	|
	|-RVA: 0x23C9060 Offset: 0x23C9161 VA: 0x23C9060
	|-Array.InternalArray__IReadOnlyList_get_Item<JSONDeserialization.TaskField>
	|
	|-RVA: 0x23C9130 Offset: 0x23C9231 VA: 0x23C9130
	|-Array.InternalArray__IReadOnlyList_get_Item<BitVector32Int>
	|
	|-RVA: 0x23C9200 Offset: 0x23C9301 VA: 0x23C9200
	|-Array.InternalArray__IReadOnlyList_get_Item<BuildItemData>
	|
	|-RVA: 0x23C9330 Offset: 0x23C9431 VA: 0x23C9330
	|-Array.InternalArray__IReadOnlyList_get_Item<ButtonLinker.LinkObject>
	|
	|-RVA: 0x23C9400 Offset: 0x23C9501 VA: 0x23C9400
	|-Array.InternalArray__IReadOnlyList_get_Item<CharaCallTable.BustupTable>
	|
	|-RVA: 0x23C94D0 Offset: 0x23C95D1 VA: 0x23C94D0
	|-Array.InternalArray__IReadOnlyList_get_Item<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x23C95B0 Offset: 0x23C96B1 VA: 0x23C95B0
	|-Array.InternalArray__IReadOnlyList_get_Item<CameraState.CustomBlendable>
	|
	|-RVA: 0x23C9680 Offset: 0x23C9781 VA: 0x23C9680
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x23C9770 Offset: 0x23C9871 VA: 0x23C9770
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x23C9860 Offset: 0x23C9961 VA: 0x23C9860
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineClearShot.Pair>
	|
	|-RVA: 0x23C9930 Offset: 0x23C9A31 VA: 0x23C9930
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x23C9A00 Offset: 0x23C9B01 VA: 0x23C9A00
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachinePath.Waypoint>
	|
	|-RVA: 0x23C9AF0 Offset: 0x23C9BF1 VA: 0x23C9AF0
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x23C9BD0 Offset: 0x23C9CD1 VA: 0x23C9BD0
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x23C9CA0 Offset: 0x23C9DA1 VA: 0x23C9CA0
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x23C9D90 Offset: 0x23C9E91 VA: 0x23C9D90
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x23C9E60 Offset: 0x23C9F61 VA: 0x23C9E60
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x23C9F30 Offset: 0x23CA031 VA: 0x23C9F30
	|-Array.InternalArray__IReadOnlyList_get_Item<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x23CA020 Offset: 0x23CA121 VA: 0x23CA020
	|-Array.InternalArray__IReadOnlyList_get_Item<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x23CA110 Offset: 0x23CA211 VA: 0x23CA110
	|-Array.InternalArray__IReadOnlyList_get_Item<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x23CA200 Offset: 0x23CA301 VA: 0x23CA200
	|-Array.InternalArray__IReadOnlyList_get_Item<HeadingTracker.Item>
	|
	|-RVA: 0x23CA2F0 Offset: 0x23CA3F1 VA: 0x23CA2F0
	|-Array.InternalArray__IReadOnlyList_get_Item<CropDataTable>
	|
	|-RVA: 0x23CA410 Offset: 0x23CA511 VA: 0x23CA410
	|-Array.InternalArray__IReadOnlyList_get_Item<ControlPoint>
	|
	|-RVA: 0x23CA500 Offset: 0x23CA601 VA: 0x23CA500
	|-Array.InternalArray__IReadOnlyList_get_Item<DamageTextInfo>
	|
	|-RVA: 0x23CA5F0 Offset: 0x23CA6F1 VA: 0x23CA5F0
	|-Array.InternalArray__IReadOnlyList_get_Item<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x23CA6E0 Offset: 0x23CA7E1 VA: 0x23CA6E0
	|-Array.InternalArray__IReadOnlyList_get_Item<DropItemParam>
	|
	|-RVA: 0x23CA7B0 Offset: 0x23CA8B1 VA: 0x23CA7B0
	|-Array.InternalArray__IReadOnlyList_get_Item<DropTableElement>
	|
	|-RVA: 0x23CA8A0 Offset: 0x23CA9A1 VA: 0x23CA8A0
	|-Array.InternalArray__IReadOnlyList_get_Item<EffectDataTable>
	|
	|-RVA: 0x23CA990 Offset: 0x23CAA91 VA: 0x23CA990
	|-Array.InternalArray__IReadOnlyList_get_Item<EnemyPatrolPoints>
	|
	|-RVA: 0x23CAA60 Offset: 0x23CAB61 VA: 0x23CAA60
	|-Array.InternalArray__IReadOnlyList_get_Item<Coord>
	|
	|-RVA: 0x23CAB30 Offset: 0x23CAC31 VA: 0x23CAB30
	|-Array.InternalArray__IReadOnlyList_get_Item<ErosionBrush.UndoStep>
	|
	|-RVA: 0x23CAC20 Offset: 0x23CAD21 VA: 0x23CAC20
	|-Array.InternalArray__IReadOnlyList_get_Item<EventCheckId>
	|
	|-RVA: 0x23CAD10 Offset: 0x23CAE11 VA: 0x23CAD10
	|-Array.InternalArray__IReadOnlyList_get_Item<EventFlagProgressData>
	|
	|-RVA: 0x23CADE0 Offset: 0x23CAEE1 VA: 0x23CADE0
	|-Array.InternalArray__IReadOnlyList_get_Item<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x23CAEB0 Offset: 0x23CAFB1 VA: 0x23CAEB0
	|-Array.InternalArray__IReadOnlyList_get_Item<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x23CAFD0 Offset: 0x23CB0D1 VA: 0x23CAFD0
	|-Array.InternalArray__IReadOnlyList_get_Item<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x23CB0D0 Offset: 0x23CB1D1 VA: 0x23CB0D0
	|-Array.InternalArray__IReadOnlyList_get_Item<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x23CB1C0 Offset: 0x23CB2C1 VA: 0x23CB1C0
	|-Array.InternalArray__IReadOnlyList_get_Item<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x23CB2A0 Offset: 0x23CB3A1 VA: 0x23CB2A0
	|-Array.InternalArray__IReadOnlyList_get_Item<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x23CB370 Offset: 0x23CB471 VA: 0x23CB370
	|-Array.InternalArray__IReadOnlyList_get_Item<FesNpcScoreData>
	|
	|-RVA: 0x23CB440 Offset: 0x23CB541 VA: 0x23CB440
	|-Array.InternalArray__IReadOnlyList_get_Item<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x23CB510 Offset: 0x23CB611 VA: 0x23CB510
	|-Array.InternalArray__IReadOnlyList_get_Item<FieldItemSpawnDataTable>
	|
	|-RVA: 0x23CB600 Offset: 0x23CB701 VA: 0x23CB600
	|-Array.InternalArray__IReadOnlyList_get_Item<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x23CB6F0 Offset: 0x23CB7F1 VA: 0x23CB6F0
	|-Array.InternalArray__IReadOnlyList_get_Item<FieldSceneData.Data>
	|
	|-RVA: 0x23CB800 Offset: 0x23CB901 VA: 0x23CB800
	|-Array.InternalArray__IReadOnlyList_get_Item<FieldTreasureBoxItemData>
	|
	|-RVA: 0x23CB8D0 Offset: 0x23CB9D1 VA: 0x23CB8D0
	|-Array.InternalArray__IReadOnlyList_get_Item<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x23CB9C0 Offset: 0x23CBAC1 VA: 0x23CB9C0
	|-Array.InternalArray__IReadOnlyList_get_Item<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x23CBAB0 Offset: 0x23CBBB1 VA: 0x23CBAB0
	|-Array.InternalArray__IReadOnlyList_get_Item<FocusObjectDataTable>
	|
	|-RVA: 0x23CBBA0 Offset: 0x23CBCA1 VA: 0x23CBBA0
	|-Array.InternalArray__IReadOnlyList_get_Item<FurnitureData>
	|
	|-RVA: 0x23CBC90 Offset: 0x23CBD91 VA: 0x23CBC90
	|-Array.InternalArray__IReadOnlyList_get_Item<GateDataTable>
	|
	|-RVA: 0x23CBD60 Offset: 0x23CBE61 VA: 0x23CBD60
	|-Array.InternalArray__IReadOnlyList_get_Item<GateStatusDataTable>
	|
	|-RVA: 0x23CBE50 Offset: 0x23CBF51 VA: 0x23CBE50
	|-Array.InternalArray__IReadOnlyList_get_Item<GimmickLayoutDataTable>
	|
	|-RVA: 0x23CBF20 Offset: 0x23CC021 VA: 0x23CBF20
	|-Array.InternalArray__IReadOnlyList_get_Item<HitResult>
	|
	|-RVA: 0x23CC010 Offset: 0x23CC111 VA: 0x23CC010
	|-Array.InternalArray__IReadOnlyList_get_Item<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x23CC100 Offset: 0x23CC201 VA: 0x23CC100
	|-Array.InternalArray__IReadOnlyList_get_Item<FurnitureManager.SendPos>
	|
	|-RVA: 0x23CC1F0 Offset: 0x23CC2F1 VA: 0x23CC1F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ItemLevelData>
	|
	|-RVA: 0x23CC2C0 Offset: 0x23CC3C1 VA: 0x23CC2C0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapDatas.MapData>
	|
	|-RVA: 0x23CC3B0 Offset: 0x23CC4B1 VA: 0x23CC3B0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x23CC4A0 Offset: 0x23CC5A1 VA: 0x23CC4A0
	|-Array.InternalArray__IReadOnlyList_get_Item<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x23CC570 Offset: 0x23CC671 VA: 0x23CC570
	|-Array.InternalArray__IReadOnlyList_get_Item<MineTypeDataTable>
	|
	|-RVA: 0x23CC670 Offset: 0x23CC771 VA: 0x23CC670
	|-Array.InternalArray__IReadOnlyList_get_Item<MiningDataTable>
	|
	|-RVA: 0x23CC740 Offset: 0x23CC841 VA: 0x23CC740
	|-Array.InternalArray__IReadOnlyList_get_Item<MiningPointSaveData>
	|
	|-RVA: 0x23CC830 Offset: 0x23CC931 VA: 0x23CC830
	|-Array.InternalArray__IReadOnlyList_get_Item<CodePointIndexer.TableRange>
	|
	|-RVA: 0x23CC920 Offset: 0x23CCA21 VA: 0x23CC920
	|-Array.InternalArray__IReadOnlyList_get_Item<MonsterBehaviorDataTable>
	|
	|-RVA: 0x23CCA10 Offset: 0x23CCB11 VA: 0x23CCA10
	|-Array.InternalArray__IReadOnlyList_get_Item<MonsterDataTable>
	|
	|-RVA: 0x23CCB20 Offset: 0x23CCC21 VA: 0x23CCB20
	|-Array.InternalArray__IReadOnlyList_get_Item<MonsterDropItemDataTable>
	|
	|-RVA: 0x23CCC10 Offset: 0x23CCD11 VA: 0x23CCC10
	|-Array.InternalArray__IReadOnlyList_get_Item<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x23CCD00 Offset: 0x23CCE01 VA: 0x23CCD00
	|-Array.InternalArray__IReadOnlyList_get_Item<MonsterHutSaveData>
	|
	|-RVA: 0x23CCDF0 Offset: 0x23CCEF1 VA: 0x23CCDF0
	|-Array.InternalArray__IReadOnlyList_get_Item<MonsterUIData.Data>
	|
	|-RVA: 0x23CCEE0 Offset: 0x23CCFE1 VA: 0x23CCEE0
	|-Array.InternalArray__IReadOnlyList_get_Item<MonsterYieldItemDataTable>
	|
	|-RVA: 0x23CCFB0 Offset: 0x23CD0B1 VA: 0x23CCFB0
	|-Array.InternalArray__IReadOnlyList_get_Item<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x23CD080 Offset: 0x23CD181 VA: 0x23CD080
	|-Array.InternalArray__IReadOnlyList_get_Item<NPCActionData>
	|
	|-RVA: 0x23CD180 Offset: 0x23CD281 VA: 0x23CD180
	|-Array.InternalArray__IReadOnlyList_get_Item<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x23CD250 Offset: 0x23CD351 VA: 0x23CD250
	|-Array.InternalArray__IReadOnlyList_get_Item<NPCUIData.Data>
	|
	|-RVA: 0x23CD320 Offset: 0x23CD421 VA: 0x23CD320
	|-Array.InternalArray__IReadOnlyList_get_Item<NpcPlaceSchedule>
	|
	|-RVA: 0x23CD410 Offset: 0x23CD511 VA: 0x23CD410
	|-Array.InternalArray__IReadOnlyList_get_Item<OrderLotterySaveParameter>
	|
	|-RVA: 0x23CD4F0 Offset: 0x23CD5F1 VA: 0x23CD4F0
	|-Array.InternalArray__IReadOnlyList_get_Item<OrderSaveData>
	|
	|-RVA: 0x23CD5E0 Offset: 0x23CD6E1 VA: 0x23CD5E0
	|-Array.InternalArray__IReadOnlyList_get_Item<OrderSaveParameter>
	|
	|-RVA: 0x23CD6D0 Offset: 0x23CD7D1 VA: 0x23CD6D0
	|-Array.InternalArray__IReadOnlyList_get_Item<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x23CD7A0 Offset: 0x23CD8A1 VA: 0x23CD7A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Parameter>
	|
	|-RVA: 0x23CD8B0 Offset: 0x23CD9B1 VA: 0x23CD8B0
	|-Array.InternalArray__IReadOnlyList_get_Item<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x23CD980 Offset: 0x23CDA81 VA: 0x23CD980
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x23CDA70 Offset: 0x23CDB71 VA: 0x23CDA70
	|-Array.InternalArray__IReadOnlyList_get_Item<ShopCatalogPage>
	|
	|-RVA: 0x23CDB40 Offset: 0x23CDC41 VA: 0x23CDB40
	|-Array.InternalArray__IReadOnlyList_get_Item<ShopNpcTalk>
	|
	|-RVA: 0x23CDC30 Offset: 0x23CDD31 VA: 0x23CDC30
	|-Array.InternalArray__IReadOnlyList_get_Item<SubtitleDataTable.Data>
	|
	|-RVA: 0x23CDD10 Offset: 0x23CDE11 VA: 0x23CDD10
	|-Array.InternalArray__IReadOnlyList_get_Item<SubtitleDataTable.DataList>
	|
	|-RVA: 0x23CDDE0 Offset: 0x23CDEE1 VA: 0x23CDDE0
	|-Array.InternalArray__IReadOnlyList_get_Item<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x23CDEC0 Offset: 0x23CDFC1 VA: 0x23CDEC0
	|-Array.InternalArray__IReadOnlyList_get_Item<AnimationWarping.Warp>
	|
	|-RVA: 0x23CDFB0 Offset: 0x23CE0B1 VA: 0x23CDFB0
	|-Array.InternalArray__IReadOnlyList_get_Item<GrounderQuadruped.Foot>
	|
	|-RVA: 0x23CE0A0 Offset: 0x23CE1A1 VA: 0x23CE0A0
	|-Array.InternalArray__IReadOnlyList_get_Item<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x23CE190 Offset: 0x23CE291 VA: 0x23CE190
	|-Array.InternalArray__IReadOnlyList_get_Item<ProfilerFrame>
	|
	|-RVA: 0x23CE270 Offset: 0x23CE371 VA: 0x23CE270
	|-Array.InternalArray__IReadOnlyList_get_Item<NumberControl.ValueRange>
	|
	|-RVA: 0x23CE340 Offset: 0x23CE441 VA: 0x23CE340
	|-Array.InternalArray__IReadOnlyList_get_Item<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x23CE430 Offset: 0x23CE531 VA: 0x23CE430
	|-Array.InternalArray__IReadOnlyList_get_Item<ResponsiveEnable.Entry>
	|
	|-RVA: 0x23CE520 Offset: 0x23CE621 VA: 0x23CE520
	|-Array.InternalArray__IReadOnlyList_get_Item<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x23CE5F0 Offset: 0x23CE6F1 VA: 0x23CE5F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ResponsiveResize.Element>
	|
	|-RVA: 0x23CE6C0 Offset: 0x23CE7C1 VA: 0x23CE6C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Schedule>
	|
	|-RVA: 0x23CE7B0 Offset: 0x23CE8B1 VA: 0x23CE7B0
	|-Array.InternalArray__IReadOnlyList_get_Item<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x23CE880 Offset: 0x23CE981 VA: 0x23CE880
	|-Array.InternalArray__IReadOnlyList_get_Item<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x23CE960 Offset: 0x23CEA61 VA: 0x23CE960
	|-Array.InternalArray__IReadOnlyList_get_Item<SpeedData>
	|
	|-RVA: 0x23CEA30 Offset: 0x23CEB31 VA: 0x23CEA30
	|-Array.InternalArray__IReadOnlyList_get_Item<CurveSample>
	|
	|-RVA: 0x23CEB40 Offset: 0x23CEC41 VA: 0x23CEB40
	|-Array.InternalArray__IReadOnlyList_get_Item<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x23CEC10 Offset: 0x23CED11 VA: 0x23CEC10
	|-Array.InternalArray__IReadOnlyList_get_Item<StringFormatData.FormatData>
	|
	|-RVA: 0x23CECE0 Offset: 0x23CEDE1 VA: 0x23CECE0
	|-Array.InternalArray__IReadOnlyList_get_Item<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x23CEDB0 Offset: 0x23CEEB1 VA: 0x23CEDB0
	|-Array.InternalArray__IReadOnlyList_get_Item<ArraySegment<byte>>
	|
	|-RVA: 0x23CEE80 Offset: 0x23CEF81 VA: 0x23CEE80
	|-Array.InternalArray__IReadOnlyList_get_Item<ArraySegment<object>>
	|
	|-RVA: 0x23CEF50 Offset: 0x23CF051 VA: 0x23CEF50
	|-Array.InternalArray__IReadOnlyList_get_Item<bool>
	|
	|-RVA: 0x23CF020 Offset: 0x23CF121 VA: 0x23CF020
	|-Array.InternalArray__IReadOnlyList_get_Item<byte>
	|
	|-RVA: 0x23CF0F0 Offset: 0x23CF1F1 VA: 0x23CF0F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ByteEnum>
	|
	|-RVA: 0x23CF1C0 Offset: 0x23CF2C1 VA: 0x23CF1C0
	|-Array.InternalArray__IReadOnlyList_get_Item<char>
	|
	|-RVA: 0x23CF290 Offset: 0x23CF391 VA: 0x23CF290
	|-Array.InternalArray__IReadOnlyList_get_Item<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x23CF360 Offset: 0x23CF461 VA: 0x23CF360
	|-Array.InternalArray__IReadOnlyList_get_Item<DictionaryEntry>
	|
	|-RVA: 0x23CF430 Offset: 0x23CF531 VA: 0x23CF430
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x23CF520 Offset: 0x23CF621 VA: 0x23CF520
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x23CF610 Offset: 0x23CF711 VA: 0x23CF610
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x23CF700 Offset: 0x23CF801 VA: 0x23CF700
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x23CF810 Offset: 0x23CF911 VA: 0x23CF810
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x23CF900 Offset: 0x23CFA01 VA: 0x23CF900
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x23CF9F0 Offset: 0x23CFAF1 VA: 0x23CF9F0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x23CFAE0 Offset: 0x23CFBE1 VA: 0x23CFAE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x23CFBE0 Offset: 0x23CFCE1 VA: 0x23CFBE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x23CFCD0 Offset: 0x23CFDD1 VA: 0x23CFCD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x23CFDD0 Offset: 0x23CFED1 VA: 0x23CFDD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x23CFEC0 Offset: 0x23CFFC1 VA: 0x23CFEC0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x23CFFD0 Offset: 0x23D00D1 VA: 0x23CFFD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x23D00C0 Offset: 0x23D01C1 VA: 0x23D00C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x23D01B0 Offset: 0x23D02B1 VA: 0x23D01B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x23D02A0 Offset: 0x23D03A1 VA: 0x23D02A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x23D0390 Offset: 0x23D0491 VA: 0x23D0390
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x23D0480 Offset: 0x23D0581 VA: 0x23D0480
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x23D0570 Offset: 0x23D0671 VA: 0x23D0570
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x23D0660 Offset: 0x23D0761 VA: 0x23D0660
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x23D0790 Offset: 0x23D0891 VA: 0x23D0790
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x23D0880 Offset: 0x23D0981 VA: 0x23D0880
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x23D0950 Offset: 0x23D0A51 VA: 0x23D0950
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x23D0A60 Offset: 0x23D0B61 VA: 0x23D0A60
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x23D0B50 Offset: 0x23D0C51 VA: 0x23D0B50
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x23D0C20 Offset: 0x23D0D21 VA: 0x23D0C20
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x23D0CF0 Offset: 0x23D0DF1 VA: 0x23D0CF0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x23D0DC0 Offset: 0x23D0EC1 VA: 0x23D0DC0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x23D0E90 Offset: 0x23D0F91 VA: 0x23D0E90
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x23D0F80 Offset: 0x23D1081 VA: 0x23D0F80
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x23D1070 Offset: 0x23D1171 VA: 0x23D1070
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x23D1170 Offset: 0x23D1271 VA: 0x23D1170
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x23D1260 Offset: 0x23D1361 VA: 0x23D1260
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x23D1350 Offset: 0x23D1451 VA: 0x23D1350
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x23D1440 Offset: 0x23D1541 VA: 0x23D1440
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x23D1560 Offset: 0x23D1661 VA: 0x23D1560
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x23D1660 Offset: 0x23D1761 VA: 0x23D1660
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x23D1750 Offset: 0x23D1851 VA: 0x23D1750
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x23D1820 Offset: 0x23D1921 VA: 0x23D1820
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x23D1910 Offset: 0x23D1A11 VA: 0x23D1910
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x23D19E0 Offset: 0x23D1AE1 VA: 0x23D19E0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x23D1AB0 Offset: 0x23D1BB1 VA: 0x23D1AB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x23D1BA0 Offset: 0x23D1CA1 VA: 0x23D1BA0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x23D1C70 Offset: 0x23D1D71 VA: 0x23D1C70
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x23D1D60 Offset: 0x23D1E61 VA: 0x23D1D60
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x23D1E50 Offset: 0x23D1F51 VA: 0x23D1E50
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x23D1F40 Offset: 0x23D2041 VA: 0x23D1F40
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x23D2030 Offset: 0x23D2131 VA: 0x23D2030
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x23D2120 Offset: 0x23D2221 VA: 0x23D2120
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x23D2210 Offset: 0x23D2311 VA: 0x23D2210
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x23D2300 Offset: 0x23D2401 VA: 0x23D2300
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x23D23F0 Offset: 0x23D24F1 VA: 0x23D23F0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x23D24E0 Offset: 0x23D25E1 VA: 0x23D24E0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x23D25D0 Offset: 0x23D26D1 VA: 0x23D25D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x23D26C0 Offset: 0x23D27C1 VA: 0x23D26C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x23D27B0 Offset: 0x23D28B1 VA: 0x23D27B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x23D28A0 Offset: 0x23D29A1 VA: 0x23D28A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x23D2990 Offset: 0x23D2A91 VA: 0x23D2990
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x23D2AB0 Offset: 0x23D2BB1 VA: 0x23D2AB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x23D2BA0 Offset: 0x23D2CA1 VA: 0x23D2BA0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x23D2C90 Offset: 0x23D2D91 VA: 0x23D2C90
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x23D2D80 Offset: 0x23D2E81 VA: 0x23D2D80
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x23D2E70 Offset: 0x23D2F71 VA: 0x23D2E70
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x23D2F60 Offset: 0x23D3061 VA: 0x23D2F60
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x23D3050 Offset: 0x23D3151 VA: 0x23D3050
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x23D3140 Offset: 0x23D3241 VA: 0x23D3140
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x23D3230 Offset: 0x23D3331 VA: 0x23D3230
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x23D3320 Offset: 0x23D3421 VA: 0x23D3320
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x23D3410 Offset: 0x23D3511 VA: 0x23D3410
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x23D3500 Offset: 0x23D3601 VA: 0x23D3500
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x23D3610 Offset: 0x23D3711 VA: 0x23D3610
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x23D3700 Offset: 0x23D3801 VA: 0x23D3700
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x23D37F0 Offset: 0x23D38F1 VA: 0x23D37F0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x23D38E0 Offset: 0x23D39E1 VA: 0x23D38E0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x23D39E0 Offset: 0x23D3AE1 VA: 0x23D39E0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x23D3AD0 Offset: 0x23D3BD1 VA: 0x23D3AD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x23D3BD0 Offset: 0x23D3CD1 VA: 0x23D3BD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x23D3CC0 Offset: 0x23D3DC1 VA: 0x23D3CC0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x23D3DD0 Offset: 0x23D3ED1 VA: 0x23D3DD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x23D3EC0 Offset: 0x23D3FC1 VA: 0x23D3EC0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x23D3FB0 Offset: 0x23D40B1 VA: 0x23D3FB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x23D40A0 Offset: 0x23D41A1 VA: 0x23D40A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x23D4190 Offset: 0x23D4291 VA: 0x23D4190
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x23D4280 Offset: 0x23D4381 VA: 0x23D4280
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x23D4370 Offset: 0x23D4471 VA: 0x23D4370
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x23D4460 Offset: 0x23D4561 VA: 0x23D4460
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x23D4550 Offset: 0x23D4651 VA: 0x23D4550
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x23D4640 Offset: 0x23D4741 VA: 0x23D4640
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x23D4730 Offset: 0x23D4831 VA: 0x23D4730
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x23D4820 Offset: 0x23D4921 VA: 0x23D4820
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x23D4910 Offset: 0x23D4A11 VA: 0x23D4910
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x23D4A00 Offset: 0x23D4B01 VA: 0x23D4A00
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x23D4AF0 Offset: 0x23D4BF1 VA: 0x23D4AF0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x23D4BE0 Offset: 0x23D4CE1 VA: 0x23D4BE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x23D4CD0 Offset: 0x23D4DD1 VA: 0x23D4CD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x23D4DC0 Offset: 0x23D4EC1 VA: 0x23D4DC0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x23D4EB0 Offset: 0x23D4FB1 VA: 0x23D4EB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x23D4FA0 Offset: 0x23D50A1 VA: 0x23D4FA0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x23D5090 Offset: 0x23D5191 VA: 0x23D5090
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x23D51B0 Offset: 0x23D52B1 VA: 0x23D51B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x23D52A0 Offset: 0x23D53A1 VA: 0x23D52A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x23D5390 Offset: 0x23D5491 VA: 0x23D5390
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x23D5480 Offset: 0x23D5581 VA: 0x23D5480
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x23D5570 Offset: 0x23D5671 VA: 0x23D5570
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x23D5660 Offset: 0x23D5761 VA: 0x23D5660
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x23D5750 Offset: 0x23D5851 VA: 0x23D5750
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x23D5840 Offset: 0x23D5941 VA: 0x23D5840
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x23D5930 Offset: 0x23D5A31 VA: 0x23D5930
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x23D5A20 Offset: 0x23D5B21 VA: 0x23D5A20
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x23D5B10 Offset: 0x23D5C11 VA: 0x23D5B10
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x23D5C00 Offset: 0x23D5D01 VA: 0x23D5C00
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x23D5CF0 Offset: 0x23D5DF1 VA: 0x23D5CF0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x23D5DE0 Offset: 0x23D5EE1 VA: 0x23D5DE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x23D5ED0 Offset: 0x23D5FD1 VA: 0x23D5ED0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x23D5FC0 Offset: 0x23D60C1 VA: 0x23D5FC0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x23D60B0 Offset: 0x23D61B1 VA: 0x23D60B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x23D61A0 Offset: 0x23D62A1 VA: 0x23D61A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x23D6290 Offset: 0x23D6391 VA: 0x23D6290
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x23D6380 Offset: 0x23D6481 VA: 0x23D6380
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x23D6470 Offset: 0x23D6571 VA: 0x23D6470
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x23D6560 Offset: 0x23D6661 VA: 0x23D6560
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x23D6650 Offset: 0x23D6751 VA: 0x23D6650
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x23D6740 Offset: 0x23D6841 VA: 0x23D6740
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x23D6830 Offset: 0x23D6931 VA: 0x23D6830
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x23D6920 Offset: 0x23D6A21 VA: 0x23D6920
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x23D6A10 Offset: 0x23D6B11 VA: 0x23D6A10
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x23D6B20 Offset: 0x23D6C21 VA: 0x23D6B20
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x23D6C10 Offset: 0x23D6D11 VA: 0x23D6C10
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x23D6D00 Offset: 0x23D6E01 VA: 0x23D6D00
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x23D6DF0 Offset: 0x23D6EF1 VA: 0x23D6DF0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x23D6EE0 Offset: 0x23D6FE1 VA: 0x23D6EE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x23D6FD0 Offset: 0x23D70D1 VA: 0x23D6FD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x23D70C0 Offset: 0x23D71C1 VA: 0x23D70C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x23D71B0 Offset: 0x23D72B1 VA: 0x23D71B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x23D72A0 Offset: 0x23D73A1 VA: 0x23D72A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x23D7390 Offset: 0x23D7491 VA: 0x23D7390
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x23D7480 Offset: 0x23D7581 VA: 0x23D7480
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x23D7570 Offset: 0x23D7671 VA: 0x23D7570
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x23D7660 Offset: 0x23D7761 VA: 0x23D7660
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x23D7750 Offset: 0x23D7851 VA: 0x23D7750
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x23D7840 Offset: 0x23D7941 VA: 0x23D7840
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x23D7930 Offset: 0x23D7A31 VA: 0x23D7930
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x23D7A50 Offset: 0x23D7B51 VA: 0x23D7A50
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x23D7B40 Offset: 0x23D7C41 VA: 0x23D7B40
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x23D7C30 Offset: 0x23D7D31 VA: 0x23D7C30
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x23D7D00 Offset: 0x23D7E01 VA: 0x23D7D00
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x23D7DD0 Offset: 0x23D7ED1 VA: 0x23D7DD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x23D7EC0 Offset: 0x23D7FC1 VA: 0x23D7EC0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x23D7FB0 Offset: 0x23D80B1 VA: 0x23D7FB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x23D80A0 Offset: 0x23D81A1 VA: 0x23D80A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x23D81A0 Offset: 0x23D82A1 VA: 0x23D81A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x23D82A0 Offset: 0x23D83A1 VA: 0x23D82A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x23D8390 Offset: 0x23D8491 VA: 0x23D8390
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x23D8480 Offset: 0x23D8581 VA: 0x23D8480
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x23D8570 Offset: 0x23D8671 VA: 0x23D8570
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x23D8660 Offset: 0x23D8761 VA: 0x23D8660
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x23D8750 Offset: 0x23D8851 VA: 0x23D8750
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x23D8840 Offset: 0x23D8941 VA: 0x23D8840
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x23D8930 Offset: 0x23D8A31 VA: 0x23D8930
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x23D8A20 Offset: 0x23D8B21 VA: 0x23D8A20
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x23D8B10 Offset: 0x23D8C11 VA: 0x23D8B10
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x23D8C00 Offset: 0x23D8D01 VA: 0x23D8C00
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x23D8CF0 Offset: 0x23D8DF1 VA: 0x23D8CF0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x23D8DE0 Offset: 0x23D8EE1 VA: 0x23D8DE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x23D8EF0 Offset: 0x23D8FF1 VA: 0x23D8EF0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x23D8FE0 Offset: 0x23D90E1 VA: 0x23D8FE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x23D90D0 Offset: 0x23D91D1 VA: 0x23D90D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x23D91C0 Offset: 0x23D92C1 VA: 0x23D91C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x23D92B0 Offset: 0x23D93B1 VA: 0x23D92B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x23D93A0 Offset: 0x23D94A1 VA: 0x23D93A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x23D9490 Offset: 0x23D9591 VA: 0x23D9490
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x23D9580 Offset: 0x23D9681 VA: 0x23D9580
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x23D9670 Offset: 0x23D9771 VA: 0x23D9670
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x237D790 Offset: 0x237D891 VA: 0x237D790
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x237D880 Offset: 0x237D981 VA: 0x237D880
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x237D970 Offset: 0x237DA71 VA: 0x237D970
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x237DA60 Offset: 0x237DB61 VA: 0x237DA60
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<int>>
	|
	|-RVA: 0x237DB40 Offset: 0x237DC41 VA: 0x237DB40
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x237DC20 Offset: 0x237DD21 VA: 0x237DC20
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<object>>
	|
	|-RVA: 0x237DCF0 Offset: 0x237DDF1 VA: 0x237DCF0
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<uint>>
	|
	|-RVA: 0x237DDD0 Offset: 0x237DED1 VA: 0x237DDD0
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<Edge>>
	|
	|-RVA: 0x237DEA0 Offset: 0x237DFA1 VA: 0x237DEA0
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x237DF90 Offset: 0x237E091 VA: 0x237DF90
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x237E080 Offset: 0x237E181 VA: 0x237E080
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x237E150 Offset: 0x237E251 VA: 0x237E150
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x237E240 Offset: 0x237E341 VA: 0x237E240
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x237E340 Offset: 0x237E441 VA: 0x237E340
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x237E430 Offset: 0x237E531 VA: 0x237E430
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x237E520 Offset: 0x237E621 VA: 0x237E520
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x237E610 Offset: 0x237E711 VA: 0x237E610
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x237E700 Offset: 0x237E801 VA: 0x237E700
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x237E7F0 Offset: 0x237E8F1 VA: 0x237E7F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x237E8E0 Offset: 0x237E9E1 VA: 0x237E8E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x237E9D0 Offset: 0x237EAD1 VA: 0x237E9D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x237EAE0 Offset: 0x237EBE1 VA: 0x237EAE0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<bool, object>>
	|
	|-RVA: 0x237EBB0 Offset: 0x237ECB1 VA: 0x237EBB0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<byte, object>>
	|
	|-RVA: 0x237EC80 Offset: 0x237ED81 VA: 0x237EC80
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<char, object>>
	|
	|-RVA: 0x237ED50 Offset: 0x237EE51 VA: 0x237ED50
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x237EE20 Offset: 0x237EF21 VA: 0x237EE20
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<double, object>>
	|
	|-RVA: 0x237EEF0 Offset: 0x237EFF1 VA: 0x237EEF0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x237EFE0 Offset: 0x237F0E1 VA: 0x237EFE0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<short, object>>
	|
	|-RVA: 0x237F0B0 Offset: 0x237F1B1 VA: 0x237F0B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x237F1E0 Offset: 0x237F2E1 VA: 0x237F1E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x237F2D0 Offset: 0x237F3D1 VA: 0x237F2D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x237F3A0 Offset: 0x237F4A1 VA: 0x237F3A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x237F4B0 Offset: 0x237F5B1 VA: 0x237F4B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x237F5A0 Offset: 0x237F6A1 VA: 0x237F5A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, bool>>
	|
	|-RVA: 0x237F670 Offset: 0x237F771 VA: 0x237F670
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, char>>
	|
	|-RVA: 0x237F740 Offset: 0x237F841 VA: 0x237F740
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, int>>
	|
	|-RVA: 0x237F810 Offset: 0x237F911 VA: 0x237F810
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x237F8E0 Offset: 0x237F9E1 VA: 0x237F8E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, long>>
	|
	|-RVA: 0x237F9B0 Offset: 0x237FAB1 VA: 0x237F9B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, object>>
	|
	|-RVA: 0x237FA80 Offset: 0x237FB81 VA: 0x237FA80
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x237FB80 Offset: 0x237FC81 VA: 0x237FB80
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x237FC70 Offset: 0x237FD71 VA: 0x237FC70
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x237FD50 Offset: 0x237FE51 VA: 0x237FD50
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x237FE20 Offset: 0x237FF21 VA: 0x237FE20
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x237FF30 Offset: 0x2380031 VA: 0x237FF30
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x2380030 Offset: 0x2380131 VA: 0x2380030
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x2380120 Offset: 0x2380221 VA: 0x2380120
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x23801F0 Offset: 0x23802F1 VA: 0x23801F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x23802D0 Offset: 0x23803D1 VA: 0x23802D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x23803A0 Offset: 0x23804A1 VA: 0x23803A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2380470 Offset: 0x2380571 VA: 0x2380470
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x2380540 Offset: 0x2380641 VA: 0x2380540
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x2380610 Offset: 0x2380711 VA: 0x2380610
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x2380700 Offset: 0x2380801 VA: 0x2380700
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x23807E0 Offset: 0x23808E1 VA: 0x23807E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x23808B0 Offset: 0x23809B1 VA: 0x23808B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<long, object>>
	|
	|-RVA: 0x2380980 Offset: 0x2380A81 VA: 0x2380980
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x2380A70 Offset: 0x2380B71 VA: 0x2380A70
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x2380B40 Offset: 0x2380C41 VA: 0x2380B40
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x2380C30 Offset: 0x2380D31 VA: 0x2380C30
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x2380D20 Offset: 0x2380E21 VA: 0x2380D20
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x2380DF0 Offset: 0x2380EF1 VA: 0x2380DF0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x2380EE0 Offset: 0x2380FE1 VA: 0x2380EE0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x2380FD0 Offset: 0x23810D1 VA: 0x2380FD0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x23810C0 Offset: 0x23811C1 VA: 0x23810C0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x23811B0 Offset: 0x23812B1 VA: 0x23811B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x2381280 Offset: 0x2381381 VA: 0x2381280
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x2381390 Offset: 0x2381491 VA: 0x2381390
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x2381480 Offset: 0x2381581 VA: 0x2381480
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x2381570 Offset: 0x2381671 VA: 0x2381570
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x2381660 Offset: 0x2381761 VA: 0x2381660
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x2381750 Offset: 0x2381851 VA: 0x2381750
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x2381840 Offset: 0x2381941 VA: 0x2381840
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x2381930 Offset: 0x2381A31 VA: 0x2381930
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x2381A20 Offset: 0x2381B21 VA: 0x2381A20
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x2381B10 Offset: 0x2381C11 VA: 0x2381B10
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x2381C00 Offset: 0x2381D01 VA: 0x2381C00
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x2381CD0 Offset: 0x2381DD1 VA: 0x2381CD0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x2381DC0 Offset: 0x2381EC1 VA: 0x2381DC0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x2381EC0 Offset: 0x2381FC1 VA: 0x2381EC0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x2381FB0 Offset: 0x23820B1 VA: 0x2381FB0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x23820A0 Offset: 0x23821A1 VA: 0x23820A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x2382190 Offset: 0x2382291 VA: 0x2382190
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x2382280 Offset: 0x2382381 VA: 0x2382280
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x2382370 Offset: 0x2382471 VA: 0x2382370
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x2382460 Offset: 0x2382561 VA: 0x2382460
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x2382550 Offset: 0x2382651 VA: 0x2382550
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x2382660 Offset: 0x2382761 VA: 0x2382660
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x2382750 Offset: 0x2382851 VA: 0x2382750
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, bool>>
	|
	|-RVA: 0x2382820 Offset: 0x2382921 VA: 0x2382820
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, byte>>
	|
	|-RVA: 0x23828F0 Offset: 0x23829F1 VA: 0x23828F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, char>>
	|
	|-RVA: 0x23829C0 Offset: 0x2382AC1 VA: 0x23829C0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x2382A90 Offset: 0x2382B91 VA: 0x2382A90
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, double>>
	|
	|-RVA: 0x2382B60 Offset: 0x2382C61 VA: 0x2382B60
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, short>>
	|
	|-RVA: 0x2382C30 Offset: 0x2382D31 VA: 0x2382C30
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, int>>
	|
	|-RVA: 0x2382D00 Offset: 0x2382E01 VA: 0x2382D00
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x2382DD0 Offset: 0x2382ED1 VA: 0x2382DD0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, long>>
	|
	|-RVA: 0x2382EA0 Offset: 0x2382FA1 VA: 0x2382EA0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x2382F90 Offset: 0x2383091 VA: 0x2382F90
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x2383060 Offset: 0x2383161 VA: 0x2383060
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x2383150 Offset: 0x2383251 VA: 0x2383150
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x2383240 Offset: 0x2383341 VA: 0x2383240
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x2383310 Offset: 0x2383411 VA: 0x2383310
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x2383400 Offset: 0x2383501 VA: 0x2383400
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x23834F0 Offset: 0x23835F1 VA: 0x23834F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x23835E0 Offset: 0x23836E1 VA: 0x23835E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x23836D0 Offset: 0x23837D1 VA: 0x23836D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x23837A0 Offset: 0x23838A1 VA: 0x23837A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x23838B0 Offset: 0x23839B1 VA: 0x23838B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x23839A0 Offset: 0x2383AA1 VA: 0x23839A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x2383A90 Offset: 0x2383B91 VA: 0x2383A90
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x2383B80 Offset: 0x2383C81 VA: 0x2383B80
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x2383C70 Offset: 0x2383D71 VA: 0x2383C70
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x2383D60 Offset: 0x2383E61 VA: 0x2383D60
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x2383E50 Offset: 0x2383F51 VA: 0x2383E50
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x2383F40 Offset: 0x2384041 VA: 0x2383F40
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x2384030 Offset: 0x2384131 VA: 0x2384030
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x2384120 Offset: 0x2384221 VA: 0x2384120
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, object>>
	|
	|-RVA: 0x23841F0 Offset: 0x23842F1 VA: 0x23841F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x23842E0 Offset: 0x23843E1 VA: 0x23842E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x23843D0 Offset: 0x23844D1 VA: 0x23843D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x23844A0 Offset: 0x23845A1 VA: 0x23844A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, float>>
	|
	|-RVA: 0x2384570 Offset: 0x2384671 VA: 0x2384570
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x2384640 Offset: 0x2384741 VA: 0x2384640
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, uint>>
	|
	|-RVA: 0x2384710 Offset: 0x2384811 VA: 0x2384710
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x23847E0 Offset: 0x23848E1 VA: 0x23847E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x23848D0 Offset: 0x23849D1 VA: 0x23848D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x23849C0 Offset: 0x2384AC1 VA: 0x23849C0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x2384AB0 Offset: 0x2384BB1 VA: 0x2384AB0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x2384B80 Offset: 0x2384C81 VA: 0x2384B80
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Color>>
	|
	|-RVA: 0x2384C70 Offset: 0x2384D71 VA: 0x2384C70
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x2384D40 Offset: 0x2384E41 VA: 0x2384D40
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x2384E30 Offset: 0x2384F31 VA: 0x2384E30
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x2384F20 Offset: 0x2385021 VA: 0x2384F20
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x2384FF0 Offset: 0x23850F1 VA: 0x2384FF0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x2385100 Offset: 0x2385201 VA: 0x2385100
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x23851F0 Offset: 0x23852F1 VA: 0x23851F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x23852E0 Offset: 0x23853E1 VA: 0x23852E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x23853B0 Offset: 0x23854B1 VA: 0x23853B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x23854A0 Offset: 0x23855A1 VA: 0x23854A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x2385590 Offset: 0x2385691 VA: 0x2385590
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2385680 Offset: 0x2385781 VA: 0x2385680
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2385770 Offset: 0x2385871 VA: 0x2385770
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x2385840 Offset: 0x2385941 VA: 0x2385840
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x2385910 Offset: 0x2385A11 VA: 0x2385910
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x2385A00 Offset: 0x2385B01 VA: 0x2385A00
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x2385AF0 Offset: 0x2385BF1 VA: 0x2385AF0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x2385BE0 Offset: 0x2385CE1 VA: 0x2385BE0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x2385CD0 Offset: 0x2385DD1 VA: 0x2385CD0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x2385DA0 Offset: 0x2385EA1 VA: 0x2385DA0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x2385E70 Offset: 0x2385F71 VA: 0x2385E70
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x2385F90 Offset: 0x2386091 VA: 0x2385F90
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<float, object>>
	|
	|-RVA: 0x2386060 Offset: 0x2386161 VA: 0x2386060
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x2386130 Offset: 0x2386231 VA: 0x2386130
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, int>>
	|
	|-RVA: 0x2386200 Offset: 0x2386301 VA: 0x2386200
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x23862D0 Offset: 0x23863D1 VA: 0x23862D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, object>>
	|
	|-RVA: 0x23863A0 Offset: 0x23864A1 VA: 0x23863A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x2386470 Offset: 0x2386571 VA: 0x2386470
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x2386550 Offset: 0x2386651 VA: 0x2386550
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x2386650 Offset: 0x2386751 VA: 0x2386650
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x2386750 Offset: 0x2386851 VA: 0x2386750
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x2386840 Offset: 0x2386941 VA: 0x2386840
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x2386920 Offset: 0x2386A21 VA: 0x2386920
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x23869F0 Offset: 0x2386AF1 VA: 0x23869F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x2386AE0 Offset: 0x2386BE1 VA: 0x2386AE0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x2386BD0 Offset: 0x2386CD1 VA: 0x2386BD0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Color, object>>
	|
	|-RVA: 0x2386CC0 Offset: 0x2386DC1 VA: 0x2386CC0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x2386D90 Offset: 0x2386E91 VA: 0x2386D90
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2386E60 Offset: 0x2386F61 VA: 0x2386E60
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x2386F30 Offset: 0x2387031 VA: 0x2386F30
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x2387020 Offset: 0x2387121 VA: 0x2387020
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x2387110 Offset: 0x2387211 VA: 0x2387110
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x23871E0 Offset: 0x23872E1 VA: 0x23871E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x23872F0 Offset: 0x23873F1 VA: 0x23872F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x23873E0 Offset: 0x23874E1 VA: 0x23873E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x23874D0 Offset: 0x23875D1 VA: 0x23874D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x23875A0 Offset: 0x23876A1 VA: 0x23875A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x2387690 Offset: 0x2387791 VA: 0x2387690
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x2387780 Offset: 0x2387881 VA: 0x2387780
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x2387860 Offset: 0x2387961 VA: 0x2387860
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x2387930 Offset: 0x2387A31 VA: 0x2387930
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x2387A00 Offset: 0x2387B01 VA: 0x2387A00
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x2387AD0 Offset: 0x2387BD1 VA: 0x2387AD0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x2387BC0 Offset: 0x2387CC1 VA: 0x2387BC0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x2387CB0 Offset: 0x2387DB1 VA: 0x2387CB0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x2387DA0 Offset: 0x2387EA1 VA: 0x2387DA0
	|-Array.InternalArray__IReadOnlyList_get_Item<Hashtable.bucket>
	|
	|-RVA: 0x2387E90 Offset: 0x2387F91 VA: 0x2387E90
	|-Array.InternalArray__IReadOnlyList_get_Item<DateTime>
	|
	|-RVA: 0x2387F60 Offset: 0x2388061 VA: 0x2387F60
	|-Array.InternalArray__IReadOnlyList_get_Item<DateTimeOffset>
	|
	|-RVA: 0x2388030 Offset: 0x2388131 VA: 0x2388030
	|-Array.InternalArray__IReadOnlyList_get_Item<Decimal>
	|
	|-RVA: 0x2388100 Offset: 0x2388201 VA: 0x2388100
	|-Array.InternalArray__IReadOnlyList_get_Item<double>
	|
	|-RVA: 0x23881D0 Offset: 0x23882D1 VA: 0x23881D0
	|-Array.InternalArray__IReadOnlyList_get_Item<InternalCodePageDataItem>
	|
	|-RVA: 0x23882A0 Offset: 0x23883A1 VA: 0x23882A0
	|-Array.InternalArray__IReadOnlyList_get_Item<InternalEncodingDataItem>
	|
	|-RVA: 0x2388370 Offset: 0x2388471 VA: 0x2388370
	|-Array.InternalArray__IReadOnlyList_get_Item<Guid>
	|
	|-RVA: 0x2388440 Offset: 0x2388541 VA: 0x2388440
	|-Array.InternalArray__IReadOnlyList_get_Item<short>
	|
	|-RVA: 0x2388510 Offset: 0x2388611 VA: 0x2388510
	|-Array.InternalArray__IReadOnlyList_get_Item<int>
	|
	|-RVA: 0x23885E0 Offset: 0x23886E1 VA: 0x23885E0
	|-Array.InternalArray__IReadOnlyList_get_Item<Int32Enum>
	|
	|-RVA: 0x23886B0 Offset: 0x23887B1 VA: 0x23886B0
	|-Array.InternalArray__IReadOnlyList_get_Item<long>
	|
	|-RVA: 0x2388780 Offset: 0x2388881 VA: 0x2388780
	|-Array.InternalArray__IReadOnlyList_get_Item<IntPtr>
	|
	|-RVA: 0x2388850 Offset: 0x2388951 VA: 0x2388850
	|-Array.InternalArray__IReadOnlyList_get_Item<InterpretedFrameInfo>
	|
	|-RVA: 0x2388920 Offset: 0x2388A21 VA: 0x2388920
	|-Array.InternalArray__IReadOnlyList_get_Item<LocalDefinition>
	|
	|-RVA: 0x23889F0 Offset: 0x2388AF1 VA: 0x23889F0
	|-Array.InternalArray__IReadOnlyList_get_Item<RuntimeLabel>
	|
	|-RVA: 0x2388AD0 Offset: 0x2388BD1 VA: 0x2388AD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Set.Slot<int>>
	|
	|-RVA: 0x2388BB0 Offset: 0x2388CB1 VA: 0x2388BB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Set.Slot<object>>
	|
	|-RVA: 0x2388CA0 Offset: 0x2388DA1 VA: 0x2388CA0
	|-Array.InternalArray__IReadOnlyList_get_Item<Memory<object>>
	|
	|-RVA: 0x2388D70 Offset: 0x2388E71 VA: 0x2388D70
	|-Array.InternalArray__IReadOnlyList_get_Item<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x2388E40 Offset: 0x2388F41 VA: 0x2388E40
	|-Array.InternalArray__IReadOnlyList_get_Item<HeaderVariantInfo>
	|
	|-RVA: 0x2388F10 Offset: 0x2389011 VA: 0x2388F10
	|-Array.InternalArray__IReadOnlyList_get_Item<Socket.WSABUF>
	|
	|-RVA: 0x2388FE0 Offset: 0x23890E1 VA: 0x2388FE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x23890D0 Offset: 0x23891D1 VA: 0x23890D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Int32Enum>>
	|
	|-RVA: 0x23891A0 Offset: 0x23892A1 VA: 0x23891A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Bounds>>
	|
	|-RVA: 0x2389290 Offset: 0x2389391 VA: 0x2389290
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<BoundsInt>>
	|
	|-RVA: 0x2389380 Offset: 0x2389481 VA: 0x2389380
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Color32>>
	|
	|-RVA: 0x2389450 Offset: 0x2389551 VA: 0x2389450
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Color>>
	|
	|-RVA: 0x2389540 Offset: 0x2389641 VA: 0x2389540
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2389620 Offset: 0x2389721 VA: 0x2389620
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2389710 Offset: 0x2389811 VA: 0x2389710
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Keyframe>>
	|
	|-RVA: 0x2389800 Offset: 0x2389901 VA: 0x2389800
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<LayerMask>>
	|
	|-RVA: 0x23898D0 Offset: 0x23899D1 VA: 0x23898D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Matrix4x4>>
	|
	|-RVA: 0x23899E0 Offset: 0x2389AE1 VA: 0x23899E0
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Quaternion>>
	|
	|-RVA: 0x2389AD0 Offset: 0x2389BD1 VA: 0x2389AD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<RangeInt>>
	|
	|-RVA: 0x2389BB0 Offset: 0x2389CB1 VA: 0x2389BB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Rect>>
	|
	|-RVA: 0x2389CA0 Offset: 0x2389DA1 VA: 0x2389CA0
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<RectInt>>
	|
	|-RVA: 0x2389D90 Offset: 0x2389E91 VA: 0x2389D90
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Vector2>>
	|
	|-RVA: 0x2389E70 Offset: 0x2389F71 VA: 0x2389E70
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Vector2Int>>
	|
	|-RVA: 0x2389F50 Offset: 0x238A051 VA: 0x2389F50
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Vector3>>
	|
	|-RVA: 0x238A020 Offset: 0x238A121 VA: 0x238A020
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Vector3Int>>
	|
	|-RVA: 0x238A0F0 Offset: 0x238A1F1 VA: 0x238A0F0
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Vector4>>
	|
	|-RVA: 0x238A1E0 Offset: 0x238A2E1 VA: 0x238A1E0
	|-Array.InternalArray__IReadOnlyList_get_Item<object>
	|
	|-RVA: 0x238A2B0 Offset: 0x238A3B1 VA: 0x238A2B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x238A380 Offset: 0x238A481 VA: 0x238A380
	|-Array.InternalArray__IReadOnlyList_get_Item<ReadOnlyMemory<object>>
	|
	|-RVA: 0x238A450 Offset: 0x238A551 VA: 0x238A450
	|-Array.InternalArray__IReadOnlyList_get_Item<CustomAttributeNamedArgument>
	|
	|-RVA: 0x238A540 Offset: 0x238A641 VA: 0x238A540
	|-Array.InternalArray__IReadOnlyList_get_Item<CustomAttributeTypedArgument>
	|
	|-RVA: 0x238A610 Offset: 0x238A711 VA: 0x238A610
	|-Array.InternalArray__IReadOnlyList_get_Item<Label>
	|
	|-RVA: 0x238A6E0 Offset: 0x238A7E1 VA: 0x238A6E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ParameterModifier>
	|
	|-RVA: 0x238A7B0 Offset: 0x238A8B1 VA: 0x238A7B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ResourceLocator>
	|
	|-RVA: 0x238A880 Offset: 0x238A981 VA: 0x238A880
	|-Array.InternalArray__IReadOnlyList_get_Item<Ephemeron>
	|
	|-RVA: 0x238A950 Offset: 0x238AA51 VA: 0x238A950
	|-Array.InternalArray__IReadOnlyList_get_Item<GCHandle>
	|
	|-RVA: 0x238AA20 Offset: 0x238AB21 VA: 0x238AA20
	|-Array.InternalArray__IReadOnlyList_get_Item<RuntimeTypeHandle>
	|
	|-RVA: 0x238AAF0 Offset: 0x238ABF1 VA: 0x238AAF0
	|-Array.InternalArray__IReadOnlyList_get_Item<sbyte>
	|
	|-RVA: 0x238ABC0 Offset: 0x238ACC1 VA: 0x238ABC0
	|-Array.InternalArray__IReadOnlyList_get_Item<X509ChainStatus>
	|
	|-RVA: 0x238AC90 Offset: 0x238AD91 VA: 0x238AC90
	|-Array.InternalArray__IReadOnlyList_get_Item<float>
	|
	|-RVA: 0x238AD60 Offset: 0x238AE61 VA: 0x238AD60
	|-Array.InternalArray__IReadOnlyList_get_Item<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x238AE40 Offset: 0x238AF41 VA: 0x238AE40
	|-Array.InternalArray__IReadOnlyList_get_Item<CancellationTokenRegistration>
	|
	|-RVA: 0x238AF30 Offset: 0x238B031 VA: 0x238AF30
	|-Array.InternalArray__IReadOnlyList_get_Item<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x238B000 Offset: 0x238B101 VA: 0x238B000
	|-Array.InternalArray__IReadOnlyList_get_Item<TimeSpan>
	|
	|-RVA: 0x238B0D0 Offset: 0x238B1D1 VA: 0x238B0D0
	|-Array.InternalArray__IReadOnlyList_get_Item<ushort>
	|
	|-RVA: 0x238B1A0 Offset: 0x238B2A1 VA: 0x238B1A0
	|-Array.InternalArray__IReadOnlyList_get_Item<UInt16Enum>
	|
	|-RVA: 0x238B270 Offset: 0x238B371 VA: 0x238B270
	|-Array.InternalArray__IReadOnlyList_get_Item<uint>
	|
	|-RVA: 0x238B340 Offset: 0x238B441 VA: 0x238B340
	|-Array.InternalArray__IReadOnlyList_get_Item<UInt32Enum>
	|
	|-RVA: 0x238B410 Offset: 0x238B511 VA: 0x238B410
	|-Array.InternalArray__IReadOnlyList_get_Item<ulong>
	|
	|-RVA: 0x238B4E0 Offset: 0x238B5E1 VA: 0x238B4E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x238B5B0 Offset: 0x238B6B1 VA: 0x238B5B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x238B680 Offset: 0x238B781 VA: 0x238B680
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x238B750 Offset: 0x238B851 VA: 0x238B750
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x238B820 Offset: 0x238B921 VA: 0x238B820
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object>>
	|
	|-RVA: 0x238B8F0 Offset: 0x238B9F1 VA: 0x238B8F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, float>>
	|
	|-RVA: 0x238B9C0 Offset: 0x238BAC1 VA: 0x238B9C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<float, object>>
	|
	|-RVA: 0x238BA90 Offset: 0x238BB91 VA: 0x238BA90
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<float, float>>
	|
	|-RVA: 0x238BB60 Offset: 0x238BC61 VA: 0x238BB60
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x238BC50 Offset: 0x238BD51 VA: 0x238BC50
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x238BD30 Offset: 0x238BE31 VA: 0x238BD30
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x238BE20 Offset: 0x238BF21 VA: 0x238BE20
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x238BF10 Offset: 0x238C011 VA: 0x238BF10
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x238C010 Offset: 0x238C111 VA: 0x238C010
	|-Array.InternalArray__IReadOnlyList_get_Item<HighlightState>
	|
	|-RVA: 0x238C100 Offset: 0x238C201 VA: 0x238C100
	|-Array.InternalArray__IReadOnlyList_get_Item<MaterialReference>
	|
	|-RVA: 0x238C200 Offset: 0x238C301 VA: 0x238C200
	|-Array.InternalArray__IReadOnlyList_get_Item<RichTextTagAttribute>
	|
	|-RVA: 0x238C2F0 Offset: 0x238C3F1 VA: 0x238C2F0
	|-Array.InternalArray__IReadOnlyList_get_Item<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x238C3F0 Offset: 0x238C4F1 VA: 0x238C3F0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_CharacterInfo>
	|
	|-RVA: 0x238C4F0 Offset: 0x238C5F1 VA: 0x238C4F0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_FontWeightPair>
	|
	|-RVA: 0x238C5C0 Offset: 0x238C6C1 VA: 0x238C5C0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_LineInfo>
	|
	|-RVA: 0x238C6E0 Offset: 0x238C7E1 VA: 0x238C6E0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_LinkInfo>
	|
	|-RVA: 0x238C7D0 Offset: 0x238C8D1 VA: 0x238C7D0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_MeshInfo>
	|
	|-RVA: 0x238C8E0 Offset: 0x238C9E1 VA: 0x238C8E0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_PageInfo>
	|
	|-RVA: 0x238C9D0 Offset: 0x238CAD1 VA: 0x238C9D0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x238CAB0 Offset: 0x238CBB1 VA: 0x238CAB0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x238CBA0 Offset: 0x238CCA1 VA: 0x238CBA0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_WordInfo>
	|
	|-RVA: 0x238CC90 Offset: 0x238CD91 VA: 0x238CC90
	|-Array.InternalArray__IReadOnlyList_get_Item<WordWrapState>
	|
	|-RVA: 0x238CD90 Offset: 0x238CE91 VA: 0x238CD90
	|-Array.InternalArray__IReadOnlyList_get_Item<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x238CE80 Offset: 0x238CF81 VA: 0x238CE80
	|-Array.InternalArray__IReadOnlyList_get_Item<TransitionTables>
	|
	|-RVA: 0x238CF70 Offset: 0x238D071 VA: 0x238CF70
	|-Array.InternalArray__IReadOnlyList_get_Item<TutorialUnlockFlagData>
	|
	|-RVA: 0x238D050 Offset: 0x238D151 VA: 0x238D050
	|-Array.InternalArray__IReadOnlyList_get_Item<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x238D120 Offset: 0x238D221 VA: 0x238D120
	|-Array.InternalArray__IReadOnlyList_get_Item<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x238D1F0 Offset: 0x238D2F1 VA: 0x238D1F0
	|-Array.InternalArray__IReadOnlyList_get_Item<CapEdge>
	|
	|-RVA: 0x238D2E0 Offset: 0x238D3E1 VA: 0x238D2E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ClippedEdge>
	|
	|-RVA: 0x238D3D0 Offset: 0x238D4D1 VA: 0x238D3D0
	|-Array.InternalArray__IReadOnlyList_get_Item<EdgeKeyByHash>
	|
	|-RVA: 0x238D4A0 Offset: 0x238D5A1 VA: 0x238D4A0
	|-Array.InternalArray__IReadOnlyList_get_Item<EdgeKeyByIndex>
	|
	|-RVA: 0x238D570 Offset: 0x238D671 VA: 0x238D570
	|-Array.InternalArray__IReadOnlyList_get_Item<MeshDataConnectivity.Face>
	|
	|-RVA: 0x238D640 Offset: 0x238D741 VA: 0x238D640
	|-Array.InternalArray__IReadOnlyList_get_Item<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x238D730 Offset: 0x238D831 VA: 0x238D730
	|-Array.InternalArray__IReadOnlyList_get_Item<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x238D820 Offset: 0x238D921 VA: 0x238D820
	|-Array.InternalArray__IReadOnlyList_get_Item<NavMeshBuildMarkup>
	|
	|-RVA: 0x238D8F0 Offset: 0x238D9F1 VA: 0x238D8F0
	|-Array.InternalArray__IReadOnlyList_get_Item<NavMeshBuildSource>
	|
	|-RVA: 0x238DA10 Offset: 0x238DB11 VA: 0x238DA10
	|-Array.InternalArray__IReadOnlyList_get_Item<ContentCatalogData.Bucket>
	|
	|-RVA: 0x238DAE0 Offset: 0x238DBE1 VA: 0x238DAE0
	|-Array.InternalArray__IReadOnlyList_get_Item<ConstraintSource>
	|
	|-RVA: 0x238DBB0 Offset: 0x238DCB1 VA: 0x238DBB0
	|-Array.InternalArray__IReadOnlyList_get_Item<PropertySceneHandle>
	|
	|-RVA: 0x238DC80 Offset: 0x238DD81 VA: 0x238DC80
	|-Array.InternalArray__IReadOnlyList_get_Item<TransformStreamHandle>
	|
	|-RVA: 0x238DD60 Offset: 0x238DE61 VA: 0x238DD60
	|-Array.InternalArray__IReadOnlyList_get_Item<AnimatorClipInfo>
	|
	|-RVA: 0x238DE30 Offset: 0x238DF31 VA: 0x238DE30
	|-Array.InternalArray__IReadOnlyList_get_Item<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x238DF00 Offset: 0x238E001 VA: 0x238DF00
	|-Array.InternalArray__IReadOnlyList_get_Item<BoneWeight1>
	|
	|-RVA: 0x238DFD0 Offset: 0x238E0D1 VA: 0x238DFD0
	|-Array.InternalArray__IReadOnlyList_get_Item<BoneWeight>
	|
	|-RVA: 0x238E0C0 Offset: 0x238E1C1 VA: 0x238E0C0
	|-Array.InternalArray__IReadOnlyList_get_Item<BoundingSphere>
	|
	|-RVA: 0x238E1A0 Offset: 0x238E2A1 VA: 0x238E1A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Bounds>
	|
	|-RVA: 0x238E290 Offset: 0x238E391 VA: 0x238E290
	|-Array.InternalArray__IReadOnlyList_get_Item<BoundsInt>
	|
	|-RVA: 0x238E380 Offset: 0x238E481 VA: 0x238E380
	|-Array.InternalArray__IReadOnlyList_get_Item<CharacterInfo>
	|
	|-RVA: 0x238E480 Offset: 0x238E581 VA: 0x238E480
	|-Array.InternalArray__IReadOnlyList_get_Item<Color32>
	|
	|-RVA: 0x238E550 Offset: 0x238E651 VA: 0x238E550
	|-Array.InternalArray__IReadOnlyList_get_Item<Color>
	|
	|-RVA: 0x238E630 Offset: 0x238E731 VA: 0x238E630
	|-Array.InternalArray__IReadOnlyList_get_Item<CombineInstance>
	|
	|-RVA: 0x238E750 Offset: 0x238E851 VA: 0x238E750
	|-Array.InternalArray__IReadOnlyList_get_Item<ContactPoint2D>
	|
	|-RVA: 0x238E850 Offset: 0x238E951 VA: 0x238E850
	|-Array.InternalArray__IReadOnlyList_get_Item<ContactPoint>
	|
	|-RVA: 0x238E940 Offset: 0x238EA41 VA: 0x238E940
	|-Array.InternalArray__IReadOnlyList_get_Item<RaycastResult>
	|
	|-RVA: 0x238EA50 Offset: 0x238EB51 VA: 0x238EA50
	|-Array.InternalArray__IReadOnlyList_get_Item<LightDataGI>
	|
	|-RVA: 0x238EB70 Offset: 0x238EC71 VA: 0x238EB70
	|-Array.InternalArray__IReadOnlyList_get_Item<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x238EC40 Offset: 0x238ED41 VA: 0x238EC40
	|-Array.InternalArray__IReadOnlyList_get_Item<GradientAlphaKey>
	|
	|-RVA: 0x238ED10 Offset: 0x238EE11 VA: 0x238ED10
	|-Array.InternalArray__IReadOnlyList_get_Item<GradientColorKey>
	|
	|-RVA: 0x238EE00 Offset: 0x238EF01 VA: 0x238EE00
	|-Array.InternalArray__IReadOnlyList_get_Item<HumanBone>
	|
	|-RVA: 0x238EF00 Offset: 0x238F001 VA: 0x238EF00
	|-Array.InternalArray__IReadOnlyList_get_Item<Keyframe>
	|
	|-RVA: 0x238EFF0 Offset: 0x238F0F1 VA: 0x238EFF0
	|-Array.InternalArray__IReadOnlyList_get_Item<LOD>
	|
	|-RVA: 0x238F0C0 Offset: 0x238F1C1 VA: 0x238F0C0
	|-Array.InternalArray__IReadOnlyList_get_Item<LayerMask>
	|
	|-RVA: 0x238F190 Offset: 0x238F291 VA: 0x238F190
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayerLoopSystem>
	|
	|-RVA: 0x238F280 Offset: 0x238F381 VA: 0x238F280
	|-Array.InternalArray__IReadOnlyList_get_Item<Matrix4x4>
	|
	|-RVA: 0x238F380 Offset: 0x238F481 VA: 0x238F380
	|-Array.InternalArray__IReadOnlyList_get_Item<ParticleSystem.Particle>
	|
	|-RVA: 0x238F480 Offset: 0x238F581 VA: 0x238F480
	|-Array.InternalArray__IReadOnlyList_get_Item<PatchExtents>
	|
	|-RVA: 0x238F550 Offset: 0x238F651 VA: 0x238F550
	|-Array.InternalArray__IReadOnlyList_get_Item<Plane>
	|
	|-RVA: 0x238F630 Offset: 0x238F731 VA: 0x238F630
	|-Array.InternalArray__IReadOnlyList_get_Item<Playable>
	|
	|-RVA: 0x238F700 Offset: 0x238F801 VA: 0x238F700
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayableBinding>
	|
	|-RVA: 0x238F7F0 Offset: 0x238F8F1 VA: 0x238F7F0
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayableGraph>
	|
	|-RVA: 0x238F8C0 Offset: 0x238F9C1 VA: 0x238F8C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Edge>
	|
	|-RVA: 0x238F990 Offset: 0x238FA91 VA: 0x238F990
	|-Array.InternalArray__IReadOnlyList_get_Item<IntVec3>
	|
	|-RVA: 0x238FA70 Offset: 0x238FB71 VA: 0x238FA70
	|-Array.InternalArray__IReadOnlyList_get_Item<Quaternion>
	|
	|-RVA: 0x238FB50 Offset: 0x238FC51 VA: 0x238FB50
	|-Array.InternalArray__IReadOnlyList_get_Item<RangeInt>
	|
	|-RVA: 0x238FC20 Offset: 0x238FD21 VA: 0x238FC20
	|-Array.InternalArray__IReadOnlyList_get_Item<RaycastHit2D>
	|
	|-RVA: 0x238FD10 Offset: 0x238FE11 VA: 0x238FD10
	|-Array.InternalArray__IReadOnlyList_get_Item<RaycastHit>
	|
	|-RVA: 0x238FE10 Offset: 0x238FF11 VA: 0x238FE10
	|-Array.InternalArray__IReadOnlyList_get_Item<Rect>
	|
	|-RVA: 0x238FEF0 Offset: 0x238FFF1 VA: 0x238FEF0
	|-Array.InternalArray__IReadOnlyList_get_Item<RectInt>
	|
	|-RVA: 0x238FFC0 Offset: 0x23900C1 VA: 0x238FFC0
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderBuffer>
	|
	|-RVA: 0x2390090 Offset: 0x2390191 VA: 0x2390090
	|-Array.InternalArray__IReadOnlyList_get_Item<BatchVisibility>
	|
	|-RVA: 0x2390170 Offset: 0x2390271 VA: 0x2390170
	|-Array.InternalArray__IReadOnlyList_get_Item<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x2390240 Offset: 0x2390341 VA: 0x2390240
	|-Array.InternalArray__IReadOnlyList_get_Item<SphericalHarmonicsL2>
	|
	|-RVA: 0x2390370 Offset: 0x2390471 VA: 0x2390370
	|-Array.InternalArray__IReadOnlyList_get_Item<VertexAttributeDescriptor>
	|
	|-RVA: 0x2390440 Offset: 0x2390541 VA: 0x2390440
	|-Array.InternalArray__IReadOnlyList_get_Item<AsyncOperationHandle>
	|
	|-RVA: 0x2390530 Offset: 0x2390631 VA: 0x2390530
	|-Array.InternalArray__IReadOnlyList_get_Item<AsyncOperationHandle<object>>
	|
	|-RVA: 0x2390620 Offset: 0x2390721 VA: 0x2390620
	|-Array.InternalArray__IReadOnlyList_get_Item<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x2390710 Offset: 0x2390811 VA: 0x2390710
	|-Array.InternalArray__IReadOnlyList_get_Item<DiagnosticEvent>
	|
	|-RVA: 0x2390800 Offset: 0x2390901 VA: 0x2390800
	|-Array.InternalArray__IReadOnlyList_get_Item<SceneInstance>
	|
	|-RVA: 0x23908D0 Offset: 0x23909D1 VA: 0x23908D0
	|-Array.InternalArray__IReadOnlyList_get_Item<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x23909C0 Offset: 0x2390AC1 VA: 0x23909C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ObjectInitializationData>
	|
	|-RVA: 0x2390AB0 Offset: 0x2390BB1 VA: 0x2390AB0
	|-Array.InternalArray__IReadOnlyList_get_Item<SerializedType>
	|
	|-RVA: 0x2390BA0 Offset: 0x2390CA1 VA: 0x2390BA0
	|-Array.InternalArray__IReadOnlyList_get_Item<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x2390C70 Offset: 0x2390D71 VA: 0x2390C70
	|-Array.InternalArray__IReadOnlyList_get_Item<SkeletonBone>
	|
	|-RVA: 0x2390D70 Offset: 0x2390E71 VA: 0x2390D70
	|-Array.InternalArray__IReadOnlyList_get_Item<GlyphRect>
	|
	|-RVA: 0x2390E40 Offset: 0x2390F41 VA: 0x2390E40
	|-Array.InternalArray__IReadOnlyList_get_Item<GlyphMarshallingStruct>
	|
	|-RVA: 0x2390F30 Offset: 0x2391031 VA: 0x2390F30
	|-Array.InternalArray__IReadOnlyList_get_Item<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x2391030 Offset: 0x2391131 VA: 0x2391030
	|-Array.InternalArray__IReadOnlyList_get_Item<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2391120 Offset: 0x2391221 VA: 0x2391120
	|-Array.InternalArray__IReadOnlyList_get_Item<IntervalTreeNode>
	|
	|-RVA: 0x2391210 Offset: 0x2391311 VA: 0x2391210
	|-Array.InternalArray__IReadOnlyList_get_Item<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2391300 Offset: 0x2391401 VA: 0x2391300
	|-Array.InternalArray__IReadOnlyList_get_Item<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x23913F0 Offset: 0x23914F1 VA: 0x23913F0
	|-Array.InternalArray__IReadOnlyList_get_Item<Touch>
	|
	|-RVA: 0x2391500 Offset: 0x2391601 VA: 0x2391500
	|-Array.InternalArray__IReadOnlyList_get_Item<TreeInstance>
	|
	|-RVA: 0x23915F0 Offset: 0x23916F1 VA: 0x23915F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ColorBlock>
	|
	|-RVA: 0x2391710 Offset: 0x2391811 VA: 0x2391710
	|-Array.InternalArray__IReadOnlyList_get_Item<Navigation>
	|
	|-RVA: 0x2391800 Offset: 0x2391901 VA: 0x2391800
	|-Array.InternalArray__IReadOnlyList_get_Item<SpriteState>
	|
	|-RVA: 0x23918F0 Offset: 0x23919F1 VA: 0x23918F0
	|-Array.InternalArray__IReadOnlyList_get_Item<UICharInfo>
	|
	|-RVA: 0x23919D0 Offset: 0x2391AD1 VA: 0x23919D0
	|-Array.InternalArray__IReadOnlyList_get_Item<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x2391AA0 Offset: 0x2391BA1 VA: 0x2391AA0
	|-Array.InternalArray__IReadOnlyList_get_Item<EventDispatcher.EventRecord>
	|
	|-RVA: 0x2391B70 Offset: 0x2391C71 VA: 0x2391B70
	|-Array.InternalArray__IReadOnlyList_get_Item<FocusController.FocusedElement>
	|
	|-RVA: 0x2391C40 Offset: 0x2391D41 VA: 0x2391C40
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x2391D10 Offset: 0x2391E11 VA: 0x2391D10
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleValue>
	|
	|-RVA: 0x2391E00 Offset: 0x2391F01 VA: 0x2391E00
	|-Array.InternalArray__IReadOnlyList_get_Item<UILineInfo>
	|
	|-RVA: 0x2391ED0 Offset: 0x2391FD1 VA: 0x2391ED0
	|-Array.InternalArray__IReadOnlyList_get_Item<UIVertex>
	|
	|-RVA: 0x2391FF0 Offset: 0x23920F1 VA: 0x2391FF0
	|-Array.InternalArray__IReadOnlyList_get_Item<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x23920E0 Offset: 0x23921E1 VA: 0x23920E0
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector2>
	|
	|-RVA: 0x23921B0 Offset: 0x23922B1 VA: 0x23921B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector2Int>
	|
	|-RVA: 0x2392280 Offset: 0x2392381 VA: 0x2392280
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector3>
	|
	|-RVA: 0x2392360 Offset: 0x2392461 VA: 0x2392360
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector3Int>
	|
	|-RVA: 0x2392440 Offset: 0x2392541 VA: 0x2392440
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector4>
	|
	|-RVA: 0x2392520 Offset: 0x2392621 VA: 0x2392520
	|-Array.InternalArray__IReadOnlyList_get_Item<jvalue>
	|
	|-RVA: 0x23925F0 Offset: 0x23926F1 VA: 0x23925F0
	|-Array.InternalArray__IReadOnlyList_get_Item<WarpPoints.WarpPoint>
	|
	|-RVA: 0x2392720 Offset: 0x2392821 VA: 0x2392720
	|-Array.InternalArray__IReadOnlyList_get_Item<YieldItemParam>
	|
	|-RVA: 0x23927F0 Offset: 0x23928F1 VA: 0x23927F0
	|-Array.InternalArray__IReadOnlyList_get_Item<NetworkServiceAccountId>
	|
	|-RVA: 0x23928C0 Offset: 0x23929C1 VA: 0x23928C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Uid>
	|
	|-RVA: 0x2392990 Offset: 0x2392A91 VA: 0x2392990
	|-Array.InternalArray__IReadOnlyList_get_Item<ConsumableServiceItemId>
	|
	|-RVA: 0x2392A60 Offset: 0x2392B61 VA: 0x2392A60
	|-Array.InternalArray__IReadOnlyList_get_Item<NsUid>
	|
	|-RVA: 0x2392B30 Offset: 0x2392C31 VA: 0x2392B30
	|-Array.InternalArray__IReadOnlyList_get_Item<Friend>
	|
	|-RVA: 0x2392C30 Offset: 0x2392D31 VA: 0x2392C30
	|-Array.InternalArray__IReadOnlyList_get_Item<Profile>
	|
	|-RVA: 0x2392D60 Offset: 0x2392E61 VA: 0x2392D60
	|-Array.InternalArray__IReadOnlyList_get_Item<DirectoryEntry>
	|
	|-RVA: 0x2392E50 Offset: 0x2392F51 VA: 0x2392E50
	|-Array.InternalArray__IReadOnlyList_get_Item<DebugPadState>
	|
	|-RVA: 0x2392F40 Offset: 0x2393041 VA: 0x2392F40
	|-Array.InternalArray__IReadOnlyList_get_Item<GesturePoint>
	|
	|-RVA: 0x2393010 Offset: 0x2393111 VA: 0x2393010
	|-Array.InternalArray__IReadOnlyList_get_Item<GestureState>
	|
	|-RVA: 0x2393130 Offset: 0x2393231 VA: 0x2393130
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadFullKeyState>
	|
	|-RVA: 0x2393220 Offset: 0x2393321 VA: 0x2393220
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadHandheldState>
	|
	|-RVA: 0x2393310 Offset: 0x2393411 VA: 0x2393310
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadJoyDualState>
	|
	|-RVA: 0x2393400 Offset: 0x2393501 VA: 0x2393400
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadJoyLeftState>
	|
	|-RVA: 0x23934F0 Offset: 0x23935F1 VA: 0x23934F0
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadJoyRightState>
	|
	|-RVA: 0x23935E0 Offset: 0x23936E1 VA: 0x23935E0
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadStateArrayItem>
	|
	|-RVA: 0x23936D0 Offset: 0x23937D1 VA: 0x23936D0
	|-Array.InternalArray__IReadOnlyList_get_Item<SixAxisSensorHandle>
	|
	|-RVA: 0x23937A0 Offset: 0x23938A1 VA: 0x23937A0
	|-Array.InternalArray__IReadOnlyList_get_Item<SixAxisSensorState>
	|
	|-RVA: 0x23938C0 Offset: 0x23939C1 VA: 0x23938C0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState10>
	|
	|-RVA: 0x23939C0 Offset: 0x2393AC1 VA: 0x23939C0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState11>
	|
	|-RVA: 0x2393AC0 Offset: 0x2393BC1 VA: 0x2393AC0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState12>
	|
	|-RVA: 0x2393BC0 Offset: 0x2393CC1 VA: 0x2393BC0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState13>
	|
	|-RVA: 0x2393CC0 Offset: 0x2393DC1 VA: 0x2393CC0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState14>
	|
	|-RVA: 0x2393DC0 Offset: 0x2393EC1 VA: 0x2393DC0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState15>
	|
	|-RVA: 0x2393EC0 Offset: 0x2393FC1 VA: 0x2393EC0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState16>
	|
	|-RVA: 0x2393FC0 Offset: 0x23940C1 VA: 0x2393FC0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState1>
	|
	|-RVA: 0x23940C0 Offset: 0x23941C1 VA: 0x23940C0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState2>
	|
	|-RVA: 0x23941E0 Offset: 0x23942E1 VA: 0x23941E0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState3>
	|
	|-RVA: 0x23942E0 Offset: 0x23943E1 VA: 0x23942E0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState4>
	|
	|-RVA: 0x23943F0 Offset: 0x23944F1 VA: 0x23943F0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState5>
	|
	|-RVA: 0x2394510 Offset: 0x2394611 VA: 0x2394510
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState6>
	|
	|-RVA: 0x2394640 Offset: 0x2394741 VA: 0x2394640
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState7>
	|
	|-RVA: 0x2394740 Offset: 0x2394841 VA: 0x2394740
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState8>
	|
	|-RVA: 0x2394840 Offset: 0x2394941 VA: 0x2394840
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState9>
	|
	|-RVA: 0x2394940 Offset: 0x2394A41 VA: 0x2394940
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchState>
	|
	|-RVA: 0x2394A30 Offset: 0x2394B31 VA: 0x2394A30
	|-Array.InternalArray__IReadOnlyList_get_Item<VibrationDeviceHandle>
	|
	|-RVA: 0x2394B00 Offset: 0x2394C01 VA: 0x2394B00
	|-Array.InternalArray__IReadOnlyList_get_Item<VibrationDeviceInfo>
	|
	|-RVA: 0x2394BD0 Offset: 0x2394CD1 VA: 0x2394BD0
	|-Array.InternalArray__IReadOnlyList_get_Item<VibrationValue>
	|
	|-RVA: 0x2394CB0 Offset: 0x2394DB1 VA: 0x2394CB0
	|-Array.InternalArray__IReadOnlyList_get_Item<ClusteringData>
	|
	|-RVA: 0x2394DA0 Offset: 0x2394EA1 VA: 0x2394DA0
	|-Array.InternalArray__IReadOnlyList_get_Item<ClusteringProcessorState>
	|
	|-RVA: 0x2394EA0 Offset: 0x2394FA1 VA: 0x2394EA0
	|-Array.InternalArray__IReadOnlyList_get_Item<Finger>
	|
	|-RVA: 0x2394F90 Offset: 0x2395091 VA: 0x2394F90
	|-Array.InternalArray__IReadOnlyList_get_Item<Hand>
	|
	|-RVA: 0x2395090 Offset: 0x2395191 VA: 0x2395090
	|-Array.InternalArray__IReadOnlyList_get_Item<HandAnalysisImageState>
	|
	|-RVA: 0x2395160 Offset: 0x2395261 VA: 0x2395160
	|-Array.InternalArray__IReadOnlyList_get_Item<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x2395260 Offset: 0x2395361 VA: 0x2395260
	|-Array.InternalArray__IReadOnlyList_get_Item<MomentProcessorState>
	|
	|-RVA: 0x2395360 Offset: 0x2395461 VA: 0x2395360
	|-Array.InternalArray__IReadOnlyList_get_Item<MomentStatistic>
	|
	|-RVA: 0x2395440 Offset: 0x2395541 VA: 0x2395440
	|-Array.InternalArray__IReadOnlyList_get_Item<Protrusion>
	|
	|-RVA: 0x2395510 Offset: 0x2395611 VA: 0x2395510
	|-Array.InternalArray__IReadOnlyList_get_Item<Shape>
	|
	|-RVA: 0x2395600 Offset: 0x2395701 VA: 0x2395600
	|-Array.InternalArray__IReadOnlyList_get_Item<DictionaryInfo>
	|
	|-RVA: 0x23956D0 Offset: 0x23957D1 VA: 0x23956D0
	|-Array.InternalArray__IReadOnlyList_get_Item<UserWord>
	|
	|-RVA: 0x23957A0 Offset: 0x23958A1 VA: 0x23957A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Color4u8>
	|
	|-RVA: 0x2395870 Offset: 0x2395971 VA: 0x2395870
	|-Array.InternalArray__IReadOnlyList_get_Item<Float2>
	|
	|-RVA: 0x2395940 Offset: 0x2395A41 VA: 0x2395940
	|-Array.InternalArray__IReadOnlyList_get_Item<stCommand_t>
	*/

	// RVA: 0x184D5C0 Offset: 0x184D6C1 VA: 0x184D5C0
	internal int InternalArray__IReadOnlyCollection_get_Count() { }

	// RVA: -1 Offset: -1
	internal void InternalArray__Insert<T>(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F79830 Offset: 0x1F79931 VA: 0x1F79830
	|-Array.InternalArray__Insert<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x1F798A0 Offset: 0x1F799A1 VA: 0x1F798A0
	|-Array.InternalArray__Insert<ActionCommandDataTable>
	|
	|-RVA: 0x1F79910 Offset: 0x1F79A11 VA: 0x1F79910
	|-Array.InternalArray__Insert<AdvScriptDefCountParam>
	|
	|-RVA: 0x1F79980 Offset: 0x1F79A81 VA: 0x1F79980
	|-Array.InternalArray__Insert<JSONDeserialization.TaskField>
	|
	|-RVA: 0x1F799F0 Offset: 0x1F79AF1 VA: 0x1F799F0
	|-Array.InternalArray__Insert<BitVector32Int>
	|
	|-RVA: 0x1F79A60 Offset: 0x1F79B61 VA: 0x1F79A60
	|-Array.InternalArray__Insert<BuildItemData>
	|
	|-RVA: 0x1F79AD0 Offset: 0x1F79BD1 VA: 0x1F79AD0
	|-Array.InternalArray__Insert<ButtonLinker.LinkObject>
	|
	|-RVA: 0x1F79B40 Offset: 0x1F79C41 VA: 0x1F79B40
	|-Array.InternalArray__Insert<CharaCallTable.BustupTable>
	|
	|-RVA: 0x1F79BB0 Offset: 0x1F79CB1 VA: 0x1F79BB0
	|-Array.InternalArray__Insert<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x1F79C20 Offset: 0x1F79D21 VA: 0x1F79C20
	|-Array.InternalArray__Insert<CameraState.CustomBlendable>
	|
	|-RVA: 0x1F79C90 Offset: 0x1F79D91 VA: 0x1F79C90
	|-Array.InternalArray__Insert<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x1F79D00 Offset: 0x1F79E01 VA: 0x1F79D00
	|-Array.InternalArray__Insert<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x1F79D70 Offset: 0x1F79E71 VA: 0x1F79D70
	|-Array.InternalArray__Insert<CinemachineClearShot.Pair>
	|
	|-RVA: 0x1F79DE0 Offset: 0x1F79EE1 VA: 0x1F79DE0
	|-Array.InternalArray__Insert<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x1F79E50 Offset: 0x1F79F51 VA: 0x1F79E50
	|-Array.InternalArray__Insert<CinemachinePath.Waypoint>
	|
	|-RVA: 0x1F79EC0 Offset: 0x1F79FC1 VA: 0x1F79EC0
	|-Array.InternalArray__Insert<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x1F79F30 Offset: 0x1F7A031 VA: 0x1F79F30
	|-Array.InternalArray__Insert<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x1F79FA0 Offset: 0x1F7A0A1 VA: 0x1F79FA0
	|-Array.InternalArray__Insert<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x1F7A010 Offset: 0x1F7A111 VA: 0x1F7A010
	|-Array.InternalArray__Insert<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x1F7A080 Offset: 0x1F7A181 VA: 0x1F7A080
	|-Array.InternalArray__Insert<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x1F7A0F0 Offset: 0x1F7A1F1 VA: 0x1F7A0F0
	|-Array.InternalArray__Insert<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x1F7A160 Offset: 0x1F7A261 VA: 0x1F7A160
	|-Array.InternalArray__Insert<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x1F7A1D0 Offset: 0x1F7A2D1 VA: 0x1F7A1D0
	|-Array.InternalArray__Insert<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x1F7A240 Offset: 0x1F7A341 VA: 0x1F7A240
	|-Array.InternalArray__Insert<HeadingTracker.Item>
	|
	|-RVA: 0x1F7A2B0 Offset: 0x1F7A3B1 VA: 0x1F7A2B0
	|-Array.InternalArray__Insert<CropDataTable>
	|
	|-RVA: 0x1F7A320 Offset: 0x1F7A421 VA: 0x1F7A320
	|-Array.InternalArray__Insert<ControlPoint>
	|
	|-RVA: 0x1F7A390 Offset: 0x1F7A491 VA: 0x1F7A390
	|-Array.InternalArray__Insert<DamageTextInfo>
	|
	|-RVA: 0x1F7A400 Offset: 0x1F7A501 VA: 0x1F7A400
	|-Array.InternalArray__Insert<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x1F7A470 Offset: 0x1F7A571 VA: 0x1F7A470
	|-Array.InternalArray__Insert<DropItemParam>
	|
	|-RVA: 0x1F7A4E0 Offset: 0x1F7A5E1 VA: 0x1F7A4E0
	|-Array.InternalArray__Insert<DropTableElement>
	|
	|-RVA: 0x1F7A550 Offset: 0x1F7A651 VA: 0x1F7A550
	|-Array.InternalArray__Insert<EffectDataTable>
	|
	|-RVA: 0x1F7A5C0 Offset: 0x1F7A6C1 VA: 0x1F7A5C0
	|-Array.InternalArray__Insert<EnemyPatrolPoints>
	|
	|-RVA: 0x1F7A630 Offset: 0x1F7A731 VA: 0x1F7A630
	|-Array.InternalArray__Insert<Coord>
	|
	|-RVA: 0x1F7A6A0 Offset: 0x1F7A7A1 VA: 0x1F7A6A0
	|-Array.InternalArray__Insert<ErosionBrush.UndoStep>
	|
	|-RVA: 0x1F7A710 Offset: 0x1F7A811 VA: 0x1F7A710
	|-Array.InternalArray__Insert<EventCheckId>
	|
	|-RVA: 0x1F7A780 Offset: 0x1F7A881 VA: 0x1F7A780
	|-Array.InternalArray__Insert<EventFlagProgressData>
	|
	|-RVA: 0x1F7A7F0 Offset: 0x1F7A8F1 VA: 0x1F7A7F0
	|-Array.InternalArray__Insert<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x1F7A860 Offset: 0x1F7A961 VA: 0x1F7A860
	|-Array.InternalArray__Insert<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x1F7A8D0 Offset: 0x1F7A9D1 VA: 0x1F7A8D0
	|-Array.InternalArray__Insert<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1F7A940 Offset: 0x1F7AA41 VA: 0x1F7A940
	|-Array.InternalArray__Insert<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1F7A9B0 Offset: 0x1F7AAB1 VA: 0x1F7A9B0
	|-Array.InternalArray__Insert<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1F7AA20 Offset: 0x1F7AB21 VA: 0x1F7AA20
	|-Array.InternalArray__Insert<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1F7AA90 Offset: 0x1F7AB91 VA: 0x1F7AA90
	|-Array.InternalArray__Insert<FesNpcScoreData>
	|
	|-RVA: 0x1F7AB00 Offset: 0x1F7AC01 VA: 0x1F7AB00
	|-Array.InternalArray__Insert<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x1F7AB70 Offset: 0x1F7AC71 VA: 0x1F7AB70
	|-Array.InternalArray__Insert<FieldItemSpawnDataTable>
	|
	|-RVA: 0x1F7ABE0 Offset: 0x1F7ACE1 VA: 0x1F7ABE0
	|-Array.InternalArray__Insert<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x1F7AC50 Offset: 0x1F7AD51 VA: 0x1F7AC50
	|-Array.InternalArray__Insert<FieldSceneData.Data>
	|
	|-RVA: 0x1F7ACC0 Offset: 0x1F7ADC1 VA: 0x1F7ACC0
	|-Array.InternalArray__Insert<FieldTreasureBoxItemData>
	|
	|-RVA: 0x1F7AD30 Offset: 0x1F7AE31 VA: 0x1F7AD30
	|-Array.InternalArray__Insert<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x1F7ADA0 Offset: 0x1F7AEA1 VA: 0x1F7ADA0
	|-Array.InternalArray__Insert<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x1F7AE10 Offset: 0x1F7AF11 VA: 0x1F7AE10
	|-Array.InternalArray__Insert<FocusObjectDataTable>
	|
	|-RVA: 0x1F7AE80 Offset: 0x1F7AF81 VA: 0x1F7AE80
	|-Array.InternalArray__Insert<FurnitureData>
	|
	|-RVA: 0x1F7AEF0 Offset: 0x1F7AFF1 VA: 0x1F7AEF0
	|-Array.InternalArray__Insert<GateDataTable>
	|
	|-RVA: 0x1F7AF60 Offset: 0x1F7B061 VA: 0x1F7AF60
	|-Array.InternalArray__Insert<GateStatusDataTable>
	|
	|-RVA: 0x1F7AFD0 Offset: 0x1F7B0D1 VA: 0x1F7AFD0
	|-Array.InternalArray__Insert<GimmickLayoutDataTable>
	|
	|-RVA: 0x1F7B040 Offset: 0x1F7B141 VA: 0x1F7B040
	|-Array.InternalArray__Insert<HitResult>
	|
	|-RVA: 0x1F7B0B0 Offset: 0x1F7B1B1 VA: 0x1F7B0B0
	|-Array.InternalArray__Insert<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x1F7B120 Offset: 0x1F7B221 VA: 0x1F7B120
	|-Array.InternalArray__Insert<FurnitureManager.SendPos>
	|
	|-RVA: 0x1F7B190 Offset: 0x1F7B291 VA: 0x1F7B190
	|-Array.InternalArray__Insert<ItemLevelData>
	|
	|-RVA: 0x1F7B200 Offset: 0x1F7B301 VA: 0x1F7B200
	|-Array.InternalArray__Insert<MapDatas.MapData>
	|
	|-RVA: 0x1F7B270 Offset: 0x1F7B371 VA: 0x1F7B270
	|-Array.InternalArray__Insert<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x1F7B2E0 Offset: 0x1F7B3E1 VA: 0x1F7B2E0
	|-Array.InternalArray__Insert<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x1F7B350 Offset: 0x1F7B451 VA: 0x1F7B350
	|-Array.InternalArray__Insert<MineTypeDataTable>
	|
	|-RVA: 0x1F7B3C0 Offset: 0x1F7B4C1 VA: 0x1F7B3C0
	|-Array.InternalArray__Insert<MiningDataTable>
	|
	|-RVA: 0x1F7B430 Offset: 0x1F7B531 VA: 0x1F7B430
	|-Array.InternalArray__Insert<MiningPointSaveData>
	|
	|-RVA: 0x1F7B4A0 Offset: 0x1F7B5A1 VA: 0x1F7B4A0
	|-Array.InternalArray__Insert<CodePointIndexer.TableRange>
	|
	|-RVA: 0x1F7B510 Offset: 0x1F7B611 VA: 0x1F7B510
	|-Array.InternalArray__Insert<MonsterBehaviorDataTable>
	|
	|-RVA: 0x1F7B580 Offset: 0x1F7B681 VA: 0x1F7B580
	|-Array.InternalArray__Insert<MonsterDataTable>
	|
	|-RVA: 0x1F7B5F0 Offset: 0x1F7B6F1 VA: 0x1F7B5F0
	|-Array.InternalArray__Insert<MonsterDropItemDataTable>
	|
	|-RVA: 0x1F7B660 Offset: 0x1F7B761 VA: 0x1F7B660
	|-Array.InternalArray__Insert<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x1F7B6D0 Offset: 0x1F7B7D1 VA: 0x1F7B6D0
	|-Array.InternalArray__Insert<MonsterHutSaveData>
	|
	|-RVA: 0x1F7B740 Offset: 0x1F7B841 VA: 0x1F7B740
	|-Array.InternalArray__Insert<MonsterUIData.Data>
	|
	|-RVA: 0x1F7B7B0 Offset: 0x1F7B8B1 VA: 0x1F7B7B0
	|-Array.InternalArray__Insert<MonsterYieldItemDataTable>
	|
	|-RVA: 0x1F7B820 Offset: 0x1F7B921 VA: 0x1F7B820
	|-Array.InternalArray__Insert<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x1F7B890 Offset: 0x1F7B991 VA: 0x1F7B890
	|-Array.InternalArray__Insert<NPCActionData>
	|
	|-RVA: 0x1F7B900 Offset: 0x1F7BA01 VA: 0x1F7B900
	|-Array.InternalArray__Insert<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x1F7B970 Offset: 0x1F7BA71 VA: 0x1F7B970
	|-Array.InternalArray__Insert<NPCUIData.Data>
	|
	|-RVA: 0x1F7B9E0 Offset: 0x1F7BAE1 VA: 0x1F7B9E0
	|-Array.InternalArray__Insert<NpcPlaceSchedule>
	|
	|-RVA: 0x1F7BA50 Offset: 0x1F7BB51 VA: 0x1F7BA50
	|-Array.InternalArray__Insert<OrderLotterySaveParameter>
	|
	|-RVA: 0x1F7BAC0 Offset: 0x1F7BBC1 VA: 0x1F7BAC0
	|-Array.InternalArray__Insert<OrderSaveData>
	|
	|-RVA: 0x1F7BB30 Offset: 0x1F7BC31 VA: 0x1F7BB30
	|-Array.InternalArray__Insert<OrderSaveParameter>
	|
	|-RVA: 0x1F7BBA0 Offset: 0x1F7BCA1 VA: 0x1F7BBA0
	|-Array.InternalArray__Insert<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x1F7BC10 Offset: 0x1F7BD11 VA: 0x1F7BC10
	|-Array.InternalArray__Insert<Parameter>
	|
	|-RVA: 0x1F7BC80 Offset: 0x1F7BD81 VA: 0x1F7BC80
	|-Array.InternalArray__Insert<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x1F7BCF0 Offset: 0x1F7BDF1 VA: 0x1F7BCF0
	|-Array.InternalArray__Insert<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x1F7BD60 Offset: 0x1F7BE61 VA: 0x1F7BD60
	|-Array.InternalArray__Insert<ShopCatalogPage>
	|
	|-RVA: 0x1F7BDD0 Offset: 0x1F7BED1 VA: 0x1F7BDD0
	|-Array.InternalArray__Insert<ShopNpcTalk>
	|
	|-RVA: 0x1F7BE40 Offset: 0x1F7BF41 VA: 0x1F7BE40
	|-Array.InternalArray__Insert<SubtitleDataTable.Data>
	|
	|-RVA: 0x1F7BEB0 Offset: 0x1F7BFB1 VA: 0x1F7BEB0
	|-Array.InternalArray__Insert<SubtitleDataTable.DataList>
	|
	|-RVA: 0x1F7BF20 Offset: 0x1F7C021 VA: 0x1F7BF20
	|-Array.InternalArray__Insert<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x1F7BF90 Offset: 0x1F7C091 VA: 0x1F7BF90
	|-Array.InternalArray__Insert<AnimationWarping.Warp>
	|
	|-RVA: 0x1F7C000 Offset: 0x1F7C101 VA: 0x1F7C000
	|-Array.InternalArray__Insert<GrounderQuadruped.Foot>
	|
	|-RVA: 0x1F7C070 Offset: 0x1F7C171 VA: 0x1F7C070
	|-Array.InternalArray__Insert<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x1F7C0E0 Offset: 0x1F7C1E1 VA: 0x1F7C0E0
	|-Array.InternalArray__Insert<ProfilerFrame>
	|
	|-RVA: 0x1F7C150 Offset: 0x1F7C251 VA: 0x1F7C150
	|-Array.InternalArray__Insert<NumberControl.ValueRange>
	|
	|-RVA: 0x1F7C1C0 Offset: 0x1F7C2C1 VA: 0x1F7C1C0
	|-Array.InternalArray__Insert<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x1F7C230 Offset: 0x1F7C331 VA: 0x1F7C230
	|-Array.InternalArray__Insert<ResponsiveEnable.Entry>
	|
	|-RVA: 0x1F7C2A0 Offset: 0x1F7C3A1 VA: 0x1F7C2A0
	|-Array.InternalArray__Insert<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x1F7C310 Offset: 0x1F7C411 VA: 0x1F7C310
	|-Array.InternalArray__Insert<ResponsiveResize.Element>
	|
	|-RVA: 0x1F7C380 Offset: 0x1F7C481 VA: 0x1F7C380
	|-Array.InternalArray__Insert<Schedule>
	|
	|-RVA: 0x1F7C3F0 Offset: 0x1F7C4F1 VA: 0x1F7C3F0
	|-Array.InternalArray__Insert<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x1F7C460 Offset: 0x1F7C561 VA: 0x1F7C460
	|-Array.InternalArray__Insert<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x1F7C4D0 Offset: 0x1F7C5D1 VA: 0x1F7C4D0
	|-Array.InternalArray__Insert<SpeedData>
	|
	|-RVA: 0x1F7C540 Offset: 0x1F7C641 VA: 0x1F7C540
	|-Array.InternalArray__Insert<CurveSample>
	|
	|-RVA: 0x1F7C5B0 Offset: 0x1F7C6B1 VA: 0x1F7C5B0
	|-Array.InternalArray__Insert<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x1F7C620 Offset: 0x1F7C721 VA: 0x1F7C620
	|-Array.InternalArray__Insert<StringFormatData.FormatData>
	|
	|-RVA: 0x1F7C690 Offset: 0x1F7C791 VA: 0x1F7C690
	|-Array.InternalArray__Insert<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x1F7C700 Offset: 0x1F7C801 VA: 0x1F7C700
	|-Array.InternalArray__Insert<ArraySegment<byte>>
	|
	|-RVA: 0x1F7C770 Offset: 0x1F7C871 VA: 0x1F7C770
	|-Array.InternalArray__Insert<ArraySegment<object>>
	|
	|-RVA: 0x1F7C7E0 Offset: 0x1F7C8E1 VA: 0x1F7C7E0
	|-Array.InternalArray__Insert<bool>
	|
	|-RVA: 0x1F7C850 Offset: 0x1F7C951 VA: 0x1F7C850
	|-Array.InternalArray__Insert<byte>
	|
	|-RVA: 0x1F7C8C0 Offset: 0x1F7C9C1 VA: 0x1F7C8C0
	|-Array.InternalArray__Insert<ByteEnum>
	|
	|-RVA: 0x1F7C930 Offset: 0x1F7CA31 VA: 0x1F7C930
	|-Array.InternalArray__Insert<char>
	|
	|-RVA: 0x1F7C9A0 Offset: 0x1F7CAA1 VA: 0x1F7C9A0
	|-Array.InternalArray__Insert<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x1F7CA10 Offset: 0x1F7CB11 VA: 0x1F7CA10
	|-Array.InternalArray__Insert<DictionaryEntry>
	|
	|-RVA: 0x1F7CA80 Offset: 0x1F7CB81 VA: 0x1F7CA80
	|-Array.InternalArray__Insert<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x1F7CAF0 Offset: 0x1F7CBF1 VA: 0x1F7CAF0
	|-Array.InternalArray__Insert<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x1F7CB60 Offset: 0x1F7CC61 VA: 0x1F7CB60
	|-Array.InternalArray__Insert<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x1F7CBD0 Offset: 0x1F7CCD1 VA: 0x1F7CBD0
	|-Array.InternalArray__Insert<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x1F7CC40 Offset: 0x1F7CD41 VA: 0x1F7CC40
	|-Array.InternalArray__Insert<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x1F7CCB0 Offset: 0x1F7CDB1 VA: 0x1F7CCB0
	|-Array.InternalArray__Insert<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x1F7CD20 Offset: 0x1F7CE21 VA: 0x1F7CD20
	|-Array.InternalArray__Insert<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x1F7CD90 Offset: 0x1F7CE91 VA: 0x1F7CD90
	|-Array.InternalArray__Insert<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x1F7CE00 Offset: 0x1F7CF01 VA: 0x1F7CE00
	|-Array.InternalArray__Insert<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x1F7CE70 Offset: 0x1F7CF71 VA: 0x1F7CE70
	|-Array.InternalArray__Insert<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x1F7CEE0 Offset: 0x1F7CFE1 VA: 0x1F7CEE0
	|-Array.InternalArray__Insert<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x1F7CF50 Offset: 0x1F7D051 VA: 0x1F7CF50
	|-Array.InternalArray__Insert<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x1F7CFC0 Offset: 0x1F7D0C1 VA: 0x1F7CFC0
	|-Array.InternalArray__Insert<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x1F7D030 Offset: 0x1F7D131 VA: 0x1F7D030
	|-Array.InternalArray__Insert<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x1F7D0A0 Offset: 0x1F7D1A1 VA: 0x1F7D0A0
	|-Array.InternalArray__Insert<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x1F7D110 Offset: 0x1F7D211 VA: 0x1F7D110
	|-Array.InternalArray__Insert<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x1F7D180 Offset: 0x1F7D281 VA: 0x1F7D180
	|-Array.InternalArray__Insert<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x1F7D1F0 Offset: 0x1F7D2F1 VA: 0x1F7D1F0
	|-Array.InternalArray__Insert<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x1F7D260 Offset: 0x1F7D361 VA: 0x1F7D260
	|-Array.InternalArray__Insert<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x1F7D2D0 Offset: 0x1F7D3D1 VA: 0x1F7D2D0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x1F7D340 Offset: 0x1F7D441 VA: 0x1F7D340
	|-Array.InternalArray__Insert<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x1F7D3B0 Offset: 0x1F7D4B1 VA: 0x1F7D3B0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x1F7D420 Offset: 0x1F7D521 VA: 0x1F7D420
	|-Array.InternalArray__Insert<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x1F7D490 Offset: 0x1F7D591 VA: 0x1F7D490
	|-Array.InternalArray__Insert<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x1F7D500 Offset: 0x1F7D601 VA: 0x1F7D500
	|-Array.InternalArray__Insert<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x1F7D570 Offset: 0x1F7D671 VA: 0x1F7D570
	|-Array.InternalArray__Insert<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x1F7D5E0 Offset: 0x1F7D6E1 VA: 0x1F7D5E0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x1F7D650 Offset: 0x1F7D751 VA: 0x1F7D650
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x1F7D6C0 Offset: 0x1F7D7C1 VA: 0x1F7D6C0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x1F7D730 Offset: 0x1F7D831 VA: 0x1F7D730
	|-Array.InternalArray__Insert<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x1F7D7A0 Offset: 0x1F7D8A1 VA: 0x1F7D7A0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x1F7D810 Offset: 0x1F7D911 VA: 0x1F7D810
	|-Array.InternalArray__Insert<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x1F7D880 Offset: 0x1F7D981 VA: 0x1F7D880
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x1F7D8F0 Offset: 0x1F7D9F1 VA: 0x1F7D8F0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x1F7D960 Offset: 0x1F7DA61 VA: 0x1F7D960
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x1F7D9D0 Offset: 0x1F7DAD1 VA: 0x1F7D9D0
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x1F7DA40 Offset: 0x1F7DB41 VA: 0x1F7DA40
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x1F7DAB0 Offset: 0x1F7DBB1 VA: 0x1F7DAB0
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x1F7DB20 Offset: 0x1F7DC21 VA: 0x1F7DB20
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x1F7DB90 Offset: 0x1F7DC91 VA: 0x1F7DB90
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x1F7DC00 Offset: 0x1F7DD01 VA: 0x1F7DC00
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1F7DC70 Offset: 0x1F7DD71 VA: 0x1F7DC70
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x1F7DCE0 Offset: 0x1F7DDE1 VA: 0x1F7DCE0
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x1F7DD50 Offset: 0x1F7DE51 VA: 0x1F7DD50
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x1F7DDC0 Offset: 0x1F7DEC1 VA: 0x1F7DDC0
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x1F7DE30 Offset: 0x1F7DF31 VA: 0x1F7DE30
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x1F7DEA0 Offset: 0x1F7DFA1 VA: 0x1F7DEA0
	|-Array.InternalArray__Insert<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x1F7DF10 Offset: 0x1F7E011 VA: 0x1F7DF10
	|-Array.InternalArray__Insert<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x1F7DF80 Offset: 0x1F7E081 VA: 0x1F7DF80
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x1F7DFF0 Offset: 0x1F7E0F1 VA: 0x1F7DFF0
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x1F7E060 Offset: 0x1F7E161 VA: 0x1F7E060
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x1F7E0D0 Offset: 0x1F7E1D1 VA: 0x1F7E0D0
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x1F7E140 Offset: 0x1F7E241 VA: 0x1F7E140
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x1F7E1B0 Offset: 0x1F7E2B1 VA: 0x1F7E1B0
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x1F7E220 Offset: 0x1F7E321 VA: 0x1F7E220
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x1F7E290 Offset: 0x1F7E391 VA: 0x1F7E290
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x1F7E300 Offset: 0x1F7E401 VA: 0x1F7E300
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x1F7E370 Offset: 0x1F7E471 VA: 0x1F7E370
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x1F7E3E0 Offset: 0x1F7E4E1 VA: 0x1F7E3E0
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x1F7E450 Offset: 0x1F7E551 VA: 0x1F7E450
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x1F7E4C0 Offset: 0x1F7E5C1 VA: 0x1F7E4C0
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x1F7E530 Offset: 0x1F7E631 VA: 0x1F7E530
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x1F7E5A0 Offset: 0x1F7E6A1 VA: 0x1F7E5A0
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x1F7E610 Offset: 0x1F7E711 VA: 0x1F7E610
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x1F7E680 Offset: 0x1F7E781 VA: 0x1F7E680
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x1F7E6F0 Offset: 0x1F7E7F1 VA: 0x1F7E6F0
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x1F7E760 Offset: 0x1F7E861 VA: 0x1F7E760
	|-Array.InternalArray__Insert<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x1F7E7D0 Offset: 0x1F7E8D1 VA: 0x1F7E7D0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x1F7E840 Offset: 0x1F7E941 VA: 0x1F7E840
	|-Array.InternalArray__Insert<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x1F7E8B0 Offset: 0x1F7E9B1 VA: 0x1F7E8B0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x1F7E920 Offset: 0x1F7EA21 VA: 0x1F7E920
	|-Array.InternalArray__Insert<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x1F7E990 Offset: 0x1F7EA91 VA: 0x1F7E990
	|-Array.InternalArray__Insert<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x1F7EA00 Offset: 0x1F7EB01 VA: 0x1F7EA00
	|-Array.InternalArray__Insert<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x1F7EA70 Offset: 0x1F7EB71 VA: 0x1F7EA70
	|-Array.InternalArray__Insert<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x1F7EAE0 Offset: 0x1F7EBE1 VA: 0x1F7EAE0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x1F7EB50 Offset: 0x1F7EC51 VA: 0x1F7EB50
	|-Array.InternalArray__Insert<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x1F7EBC0 Offset: 0x1F7ECC1 VA: 0x1F7EBC0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x1F7EC30 Offset: 0x1F7ED31 VA: 0x1F7EC30
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x1F7ECA0 Offset: 0x1F7EDA1 VA: 0x1F7ECA0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x1F7ED10 Offset: 0x1F7EE11 VA: 0x1F7ED10
	|-Array.InternalArray__Insert<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x1F7ED80 Offset: 0x1F7EE81 VA: 0x1F7ED80
	|-Array.InternalArray__Insert<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x1F7EDF0 Offset: 0x1F7EEF1 VA: 0x1F7EDF0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x1F7EE60 Offset: 0x1F7EF61 VA: 0x1F7EE60
	|-Array.InternalArray__Insert<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x1F7EED0 Offset: 0x1F7EFD1 VA: 0x1F7EED0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x1F7EF40 Offset: 0x1F7F041 VA: 0x1F7EF40
	|-Array.InternalArray__Insert<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x1F7EFB0 Offset: 0x1F7F0B1 VA: 0x1F7EFB0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x1F7F020 Offset: 0x1F7F121 VA: 0x1F7F020
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x1F7F090 Offset: 0x1F7F191 VA: 0x1F7F090
	|-Array.InternalArray__Insert<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x1F7F100 Offset: 0x1F7F201 VA: 0x1F7F100
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x1F7F170 Offset: 0x1F7F271 VA: 0x1F7F170
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x1F7F1E0 Offset: 0x1F7F2E1 VA: 0x1F7F1E0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x1F7F250 Offset: 0x1F7F351 VA: 0x1F7F250
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x1F7F2C0 Offset: 0x1F7F3C1 VA: 0x1F7F2C0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x1F7F330 Offset: 0x1F7F431 VA: 0x1F7F330
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x1F7F3A0 Offset: 0x1F7F4A1 VA: 0x1F7F3A0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x1F7F410 Offset: 0x1F7F511 VA: 0x1F7F410
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x1F7F480 Offset: 0x1F7F581 VA: 0x1F7F480
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x1F7F4F0 Offset: 0x1F7F5F1 VA: 0x1F7F4F0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x1F7F560 Offset: 0x1F7F661 VA: 0x1F7F560
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x1F7F5D0 Offset: 0x1F7F6D1 VA: 0x1F7F5D0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x1F7F640 Offset: 0x1F7F741 VA: 0x1F7F640
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x1F7F6B0 Offset: 0x1F7F7B1 VA: 0x1F7F6B0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x1F7F720 Offset: 0x1F7F821 VA: 0x1F7F720
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x1F7F790 Offset: 0x1F7F891 VA: 0x1F7F790
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x1F7F800 Offset: 0x1F7F901 VA: 0x1F7F800
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x1F7F870 Offset: 0x1F7F971 VA: 0x1F7F870
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x1F7F8E0 Offset: 0x1F7F9E1 VA: 0x1F7F8E0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x1F7F950 Offset: 0x1F7FA51 VA: 0x1F7F950
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x1F7F9C0 Offset: 0x1F7FAC1 VA: 0x1F7F9C0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x1F7FA30 Offset: 0x1F7FB31 VA: 0x1F7FA30
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x1F7FAA0 Offset: 0x1F7FBA1 VA: 0x1F7FAA0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x1F7FB10 Offset: 0x1F7FC11 VA: 0x1F7FB10
	|-Array.InternalArray__Insert<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x1F7FB80 Offset: 0x1F7FC81 VA: 0x1F7FB80
	|-Array.InternalArray__Insert<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x1F7FBF0 Offset: 0x1F7FCF1 VA: 0x1F7FBF0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x1F7FC60 Offset: 0x1F7FD61 VA: 0x1F7FC60
	|-Array.InternalArray__Insert<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x1F7FCD0 Offset: 0x1F7FDD1 VA: 0x1F7FCD0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x1F7FD40 Offset: 0x1F7FE41 VA: 0x1F7FD40
	|-Array.InternalArray__Insert<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x1F7FDB0 Offset: 0x1F7FEB1 VA: 0x1F7FDB0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x1F7FE20 Offset: 0x1F7FF21 VA: 0x1F7FE20
	|-Array.InternalArray__Insert<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x1F7FE90 Offset: 0x1F7FF91 VA: 0x1F7FE90
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x1F7FF00 Offset: 0x1F80001 VA: 0x1F7FF00
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x1F7FF70 Offset: 0x1F80071 VA: 0x1F7FF70
	|-Array.InternalArray__Insert<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x1F7FFE0 Offset: 0x1F800E1 VA: 0x1F7FFE0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x1F80050 Offset: 0x1F80151 VA: 0x1F80050
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x1F800C0 Offset: 0x1F801C1 VA: 0x1F800C0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x1F80130 Offset: 0x1F80231 VA: 0x1F80130
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x1F801A0 Offset: 0x1F802A1 VA: 0x1F801A0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x1F80210 Offset: 0x1F80311 VA: 0x1F80210
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x1F80280 Offset: 0x1F80381 VA: 0x1F80280
	|-Array.InternalArray__Insert<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x1F802F0 Offset: 0x1F803F1 VA: 0x1F802F0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x1F80360 Offset: 0x1F80461 VA: 0x1F80360
	|-Array.InternalArray__Insert<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x1F803D0 Offset: 0x1F804D1 VA: 0x1F803D0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1F80440 Offset: 0x1F80541 VA: 0x1F80440
	|-Array.InternalArray__Insert<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1F804B0 Offset: 0x1F805B1 VA: 0x1F804B0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x1F80520 Offset: 0x1F80621 VA: 0x1F80520
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x1F80590 Offset: 0x1F80691 VA: 0x1F80590
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x1F80600 Offset: 0x1F80701 VA: 0x1F80600
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x1F80670 Offset: 0x1F80771 VA: 0x1F80670
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x1F806E0 Offset: 0x1F807E1 VA: 0x1F806E0
	|-Array.InternalArray__Insert<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x1F80750 Offset: 0x1F80851 VA: 0x1F80750
	|-Array.InternalArray__Insert<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x1F807C0 Offset: 0x1F808C1 VA: 0x1F807C0
	|-Array.InternalArray__Insert<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x1F80830 Offset: 0x1F80931 VA: 0x1F80830
	|-Array.InternalArray__Insert<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x1F808A0 Offset: 0x1F809A1 VA: 0x1F808A0
	|-Array.InternalArray__Insert<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x1F80910 Offset: 0x1F80A11 VA: 0x1F80910
	|-Array.InternalArray__Insert<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x1F80980 Offset: 0x1F80A81 VA: 0x1F80980
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x1F809F0 Offset: 0x1F80AF1 VA: 0x1F809F0
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x1F80A60 Offset: 0x1F80B61 VA: 0x1F80A60
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x1F80AD0 Offset: 0x1F80BD1 VA: 0x1F80AD0
	|-Array.InternalArray__Insert<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x1F80B40 Offset: 0x1F80C41 VA: 0x1F80B40
	|-Array.InternalArray__Insert<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x1F80BB0 Offset: 0x1F80CB1 VA: 0x1F80BB0
	|-Array.InternalArray__Insert<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x1F80C20 Offset: 0x1F80D21 VA: 0x1F80C20
	|-Array.InternalArray__Insert<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x1F80C90 Offset: 0x1F80D91 VA: 0x1F80C90
	|-Array.InternalArray__Insert<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x1F80D00 Offset: 0x1F80E01 VA: 0x1F80D00
	|-Array.InternalArray__Insert<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x1F80D70 Offset: 0x1F80E71 VA: 0x1F80D70
	|-Array.InternalArray__Insert<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x1F80DE0 Offset: 0x1F80EE1 VA: 0x1F80DE0
	|-Array.InternalArray__Insert<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x1F80E50 Offset: 0x1F80F51 VA: 0x1F80E50
	|-Array.InternalArray__Insert<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x1F80EC0 Offset: 0x1F80FC1 VA: 0x1F80EC0
	|-Array.InternalArray__Insert<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x1F80F30 Offset: 0x1F81031 VA: 0x1F80F30
	|-Array.InternalArray__Insert<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x1F80FA0 Offset: 0x1F810A1 VA: 0x1F80FA0
	|-Array.InternalArray__Insert<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1F81010 Offset: 0x1F81111 VA: 0x1F81010
	|-Array.InternalArray__Insert<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x1F81080 Offset: 0x1F81181 VA: 0x1F81080
	|-Array.InternalArray__Insert<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x1F810F0 Offset: 0x1F811F1 VA: 0x1F810F0
	|-Array.InternalArray__Insert<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x1F81160 Offset: 0x1F81261 VA: 0x1F81160
	|-Array.InternalArray__Insert<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x1F811D0 Offset: 0x1F812D1 VA: 0x1F811D0
	|-Array.InternalArray__Insert<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x1F81240 Offset: 0x1F81341 VA: 0x1F81240
	|-Array.InternalArray__Insert<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x1F812B0 Offset: 0x1F813B1 VA: 0x1F812B0
	|-Array.InternalArray__Insert<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x1F81320 Offset: 0x1F81421 VA: 0x1F81320
	|-Array.InternalArray__Insert<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x1F81390 Offset: 0x1F81491 VA: 0x1F81390
	|-Array.InternalArray__Insert<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x1F81400 Offset: 0x1F81501 VA: 0x1F81400
	|-Array.InternalArray__Insert<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x1F81470 Offset: 0x1F81571 VA: 0x1F81470
	|-Array.InternalArray__Insert<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x1F814E0 Offset: 0x1F815E1 VA: 0x1F814E0
	|-Array.InternalArray__Insert<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x1F81550 Offset: 0x1F81651 VA: 0x1F81550
	|-Array.InternalArray__Insert<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x1F815C0 Offset: 0x1F816C1 VA: 0x1F815C0
	|-Array.InternalArray__Insert<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x1F81630 Offset: 0x1F81731 VA: 0x1F81630
	|-Array.InternalArray__Insert<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x1F816A0 Offset: 0x1F817A1 VA: 0x1F816A0
	|-Array.InternalArray__Insert<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x1F81710 Offset: 0x1F81811 VA: 0x1F81710
	|-Array.InternalArray__Insert<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x1F81780 Offset: 0x1F81881 VA: 0x1F81780
	|-Array.InternalArray__Insert<HashSet.Slot<int>>
	|
	|-RVA: 0x1F817F0 Offset: 0x1F818F1 VA: 0x1F817F0
	|-Array.InternalArray__Insert<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x1F81860 Offset: 0x1F81961 VA: 0x1F81860
	|-Array.InternalArray__Insert<HashSet.Slot<object>>
	|
	|-RVA: 0x1F818D0 Offset: 0x1F819D1 VA: 0x1F818D0
	|-Array.InternalArray__Insert<HashSet.Slot<uint>>
	|
	|-RVA: 0x1F81940 Offset: 0x1F81A41 VA: 0x1F81940
	|-Array.InternalArray__Insert<HashSet.Slot<Edge>>
	|
	|-RVA: 0x1F819B0 Offset: 0x1F81AB1 VA: 0x1F819B0
	|-Array.InternalArray__Insert<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x1F81A20 Offset: 0x1F81B21 VA: 0x1F81A20
	|-Array.InternalArray__Insert<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x1F81A90 Offset: 0x1F81B91 VA: 0x1F81A90
	|-Array.InternalArray__Insert<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x1F81B00 Offset: 0x1F81C01 VA: 0x1F81B00
	|-Array.InternalArray__Insert<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x1F81B70 Offset: 0x1F81C71 VA: 0x1F81B70
	|-Array.InternalArray__Insert<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x1F81BE0 Offset: 0x1F81CE1 VA: 0x1F81BE0
	|-Array.InternalArray__Insert<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x1F81C50 Offset: 0x1F81D51 VA: 0x1F81C50
	|-Array.InternalArray__Insert<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x1F81CC0 Offset: 0x1F81DC1 VA: 0x1F81CC0
	|-Array.InternalArray__Insert<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x1F81D30 Offset: 0x1F81E31 VA: 0x1F81D30
	|-Array.InternalArray__Insert<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x1F81DA0 Offset: 0x1F81EA1 VA: 0x1F81DA0
	|-Array.InternalArray__Insert<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x1F81E10 Offset: 0x1F81F11 VA: 0x1F81E10
	|-Array.InternalArray__Insert<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x1F81E80 Offset: 0x1F81F81 VA: 0x1F81E80
	|-Array.InternalArray__Insert<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x1F81EF0 Offset: 0x1F81FF1 VA: 0x1F81EF0
	|-Array.InternalArray__Insert<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x1F81F60 Offset: 0x1F82061 VA: 0x1F81F60
	|-Array.InternalArray__Insert<KeyValuePair<bool, object>>
	|
	|-RVA: 0x1F81FD0 Offset: 0x1F820D1 VA: 0x1F81FD0
	|-Array.InternalArray__Insert<KeyValuePair<byte, object>>
	|
	|-RVA: 0x1F82040 Offset: 0x1F82141 VA: 0x1F82040
	|-Array.InternalArray__Insert<KeyValuePair<char, object>>
	|
	|-RVA: 0x1F820B0 Offset: 0x1F821B1 VA: 0x1F820B0
	|-Array.InternalArray__Insert<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x1F82120 Offset: 0x1F82221 VA: 0x1F82120
	|-Array.InternalArray__Insert<KeyValuePair<double, object>>
	|
	|-RVA: 0x1F82190 Offset: 0x1F82291 VA: 0x1F82190
	|-Array.InternalArray__Insert<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x1F82200 Offset: 0x1F82301 VA: 0x1F82200
	|-Array.InternalArray__Insert<KeyValuePair<short, object>>
	|
	|-RVA: 0x1F82270 Offset: 0x1F82371 VA: 0x1F82270
	|-Array.InternalArray__Insert<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x1F822E0 Offset: 0x1F823E1 VA: 0x1F822E0
	|-Array.InternalArray__Insert<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x1F82350 Offset: 0x1F82451 VA: 0x1F82350
	|-Array.InternalArray__Insert<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x1F823C0 Offset: 0x1F824C1 VA: 0x1F823C0
	|-Array.InternalArray__Insert<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x1F82430 Offset: 0x1F82531 VA: 0x1F82430
	|-Array.InternalArray__Insert<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x1F824A0 Offset: 0x1F825A1 VA: 0x1F824A0
	|-Array.InternalArray__Insert<KeyValuePair<int, bool>>
	|
	|-RVA: 0x1F82510 Offset: 0x1F82611 VA: 0x1F82510
	|-Array.InternalArray__Insert<KeyValuePair<int, char>>
	|
	|-RVA: 0x1F82580 Offset: 0x1F82681 VA: 0x1F82580
	|-Array.InternalArray__Insert<KeyValuePair<int, int>>
	|
	|-RVA: 0x1F825F0 Offset: 0x1F826F1 VA: 0x1F825F0
	|-Array.InternalArray__Insert<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x1F82660 Offset: 0x1F82761 VA: 0x1F82660
	|-Array.InternalArray__Insert<KeyValuePair<int, long>>
	|
	|-RVA: 0x1F826D0 Offset: 0x1F827D1 VA: 0x1F826D0
	|-Array.InternalArray__Insert<KeyValuePair<int, object>>
	|
	|-RVA: 0x1F82740 Offset: 0x1F82841 VA: 0x1F82740
	|-Array.InternalArray__Insert<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x1F827B0 Offset: 0x1F828B1 VA: 0x1F827B0
	|-Array.InternalArray__Insert<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x1F82820 Offset: 0x1F82921 VA: 0x1F82820
	|-Array.InternalArray__Insert<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x1F82890 Offset: 0x1F82991 VA: 0x1F82890
	|-Array.InternalArray__Insert<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x1F82900 Offset: 0x1F82A01 VA: 0x1F82900
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x1F82970 Offset: 0x1F82A71 VA: 0x1F82970
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x1F829E0 Offset: 0x1F82AE1 VA: 0x1F829E0
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x1F82A50 Offset: 0x1F82B51 VA: 0x1F82A50
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x1F82AC0 Offset: 0x1F82BC1 VA: 0x1F82AC0
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x1F82B30 Offset: 0x1F82C31 VA: 0x1F82B30
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x1F82BA0 Offset: 0x1F82CA1 VA: 0x1F82BA0
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1F82C10 Offset: 0x1F82D11 VA: 0x1F82C10
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x1F82C80 Offset: 0x1F82D81 VA: 0x1F82C80
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x1F82CF0 Offset: 0x1F82DF1 VA: 0x1F82CF0
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x1F82D60 Offset: 0x1F82E61 VA: 0x1F82D60
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x1F82DD0 Offset: 0x1F82ED1 VA: 0x1F82DD0
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x1F82E40 Offset: 0x1F82F41 VA: 0x1F82E40
	|-Array.InternalArray__Insert<KeyValuePair<long, object>>
	|
	|-RVA: 0x1F82EB0 Offset: 0x1F82FB1 VA: 0x1F82EB0
	|-Array.InternalArray__Insert<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x1F82F20 Offset: 0x1F83021 VA: 0x1F82F20
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x1F82F90 Offset: 0x1F83091 VA: 0x1F82F90
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x1F83000 Offset: 0x1F83101 VA: 0x1F83000
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x1F83070 Offset: 0x1F83171 VA: 0x1F83070
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x1F830E0 Offset: 0x1F831E1 VA: 0x1F830E0
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x1F83150 Offset: 0x1F83251 VA: 0x1F83150
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x1F831C0 Offset: 0x1F832C1 VA: 0x1F831C0
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x1F83230 Offset: 0x1F83331 VA: 0x1F83230
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x1F832A0 Offset: 0x1F833A1 VA: 0x1F832A0
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x1F83310 Offset: 0x1F83411 VA: 0x1F83310
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x1F83380 Offset: 0x1F83481 VA: 0x1F83380
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x1F833F0 Offset: 0x1F834F1 VA: 0x1F833F0
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x1F83460 Offset: 0x1F83561 VA: 0x1F83460
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x1F834D0 Offset: 0x1F835D1 VA: 0x1F834D0
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x1F83540 Offset: 0x1F83641 VA: 0x1F83540
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x1F835B0 Offset: 0x1F836B1 VA: 0x1F835B0
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x1F83620 Offset: 0x1F83721 VA: 0x1F83620
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x1F83690 Offset: 0x1F83791 VA: 0x1F83690
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x1F83700 Offset: 0x1F83801 VA: 0x1F83700
	|-Array.InternalArray__Insert<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x1F83770 Offset: 0x1F83871 VA: 0x1F83770
	|-Array.InternalArray__Insert<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x1F837E0 Offset: 0x1F838E1 VA: 0x1F837E0
	|-Array.InternalArray__Insert<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x1F83850 Offset: 0x1F83951 VA: 0x1F83850
	|-Array.InternalArray__Insert<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x1F838C0 Offset: 0x1F839C1 VA: 0x1F838C0
	|-Array.InternalArray__Insert<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x1F83930 Offset: 0x1F83A31 VA: 0x1F83930
	|-Array.InternalArray__Insert<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x1F839A0 Offset: 0x1F83AA1 VA: 0x1F839A0
	|-Array.InternalArray__Insert<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x1F83A10 Offset: 0x1F83B11 VA: 0x1F83A10
	|-Array.InternalArray__Insert<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x1F83A80 Offset: 0x1F83B81 VA: 0x1F83A80
	|-Array.InternalArray__Insert<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x1F83AF0 Offset: 0x1F83BF1 VA: 0x1F83AF0
	|-Array.InternalArray__Insert<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x1F83B60 Offset: 0x1F83C61 VA: 0x1F83B60
	|-Array.InternalArray__Insert<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x1F83BD0 Offset: 0x1F83CD1 VA: 0x1F83BD0
	|-Array.InternalArray__Insert<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x1F83C40 Offset: 0x1F83D41 VA: 0x1F83C40
	|-Array.InternalArray__Insert<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x1F83CB0 Offset: 0x1F83DB1 VA: 0x1F83CB0
	|-Array.InternalArray__Insert<KeyValuePair<object, bool>>
	|
	|-RVA: 0x1F83D20 Offset: 0x1F83E21 VA: 0x1F83D20
	|-Array.InternalArray__Insert<KeyValuePair<object, byte>>
	|
	|-RVA: 0x1F83D90 Offset: 0x1F83E91 VA: 0x1F83D90
	|-Array.InternalArray__Insert<KeyValuePair<object, char>>
	|
	|-RVA: 0x1F83E00 Offset: 0x1F83F01 VA: 0x1F83E00
	|-Array.InternalArray__Insert<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x1F83E70 Offset: 0x1F83F71 VA: 0x1F83E70
	|-Array.InternalArray__Insert<KeyValuePair<object, double>>
	|
	|-RVA: 0x1F83EE0 Offset: 0x1F83FE1 VA: 0x1F83EE0
	|-Array.InternalArray__Insert<KeyValuePair<object, short>>
	|
	|-RVA: 0x1F83F50 Offset: 0x1F84051 VA: 0x1F83F50
	|-Array.InternalArray__Insert<KeyValuePair<object, int>>
	|
	|-RVA: 0x1F83FC0 Offset: 0x1F840C1 VA: 0x1F83FC0
	|-Array.InternalArray__Insert<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x1F84030 Offset: 0x1F84131 VA: 0x1F84030
	|-Array.InternalArray__Insert<KeyValuePair<object, long>>
	|
	|-RVA: 0x1F840A0 Offset: 0x1F841A1 VA: 0x1F840A0
	|-Array.InternalArray__Insert<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x1F84110 Offset: 0x1F84211 VA: 0x1F84110
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x1F84180 Offset: 0x1F84281 VA: 0x1F84180
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x1F841F0 Offset: 0x1F842F1 VA: 0x1F841F0
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x1F84260 Offset: 0x1F84361 VA: 0x1F84260
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x1F842D0 Offset: 0x1F843D1 VA: 0x1F842D0
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x1F84340 Offset: 0x1F84441 VA: 0x1F84340
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x1F843B0 Offset: 0x1F844B1 VA: 0x1F843B0
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x1F84420 Offset: 0x1F84521 VA: 0x1F84420
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x1F84490 Offset: 0x1F84591 VA: 0x1F84490
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x1F84500 Offset: 0x1F84601 VA: 0x1F84500
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x1F84570 Offset: 0x1F84671 VA: 0x1F84570
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x1F845E0 Offset: 0x1F846E1 VA: 0x1F845E0
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x1F84650 Offset: 0x1F84751 VA: 0x1F84650
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x1F846C0 Offset: 0x1F847C1 VA: 0x1F846C0
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x1F84730 Offset: 0x1F84831 VA: 0x1F84730
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x1F847A0 Offset: 0x1F848A1 VA: 0x1F847A0
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x1F84810 Offset: 0x1F84911 VA: 0x1F84810
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x1F84880 Offset: 0x1F84981 VA: 0x1F84880
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x1F848F0 Offset: 0x1F849F1 VA: 0x1F848F0
	|-Array.InternalArray__Insert<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x1F84960 Offset: 0x1F84A61 VA: 0x1F84960
	|-Array.InternalArray__Insert<KeyValuePair<object, object>>
	|
	|-RVA: 0x1F849D0 Offset: 0x1F84AD1 VA: 0x1F849D0
	|-Array.InternalArray__Insert<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x1F84A40 Offset: 0x1F84B41 VA: 0x1F84A40
	|-Array.InternalArray__Insert<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x1F84AB0 Offset: 0x1F84BB1 VA: 0x1F84AB0
	|-Array.InternalArray__Insert<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x1F84B20 Offset: 0x1F84C21 VA: 0x1F84B20
	|-Array.InternalArray__Insert<KeyValuePair<object, float>>
	|
	|-RVA: 0x1F84B90 Offset: 0x1F84C91 VA: 0x1F84B90
	|-Array.InternalArray__Insert<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x1F84C00 Offset: 0x1F84D01 VA: 0x1F84C00
	|-Array.InternalArray__Insert<KeyValuePair<object, uint>>
	|
	|-RVA: 0x1F84C70 Offset: 0x1F84D71 VA: 0x1F84C70
	|-Array.InternalArray__Insert<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x1F84CE0 Offset: 0x1F84DE1 VA: 0x1F84CE0
	|-Array.InternalArray__Insert<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x1F84D50 Offset: 0x1F84E51 VA: 0x1F84D50
	|-Array.InternalArray__Insert<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x1F84DC0 Offset: 0x1F84EC1 VA: 0x1F84DC0
	|-Array.InternalArray__Insert<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x1F84E30 Offset: 0x1F84F31 VA: 0x1F84E30
	|-Array.InternalArray__Insert<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x1F84EA0 Offset: 0x1F84FA1 VA: 0x1F84EA0
	|-Array.InternalArray__Insert<KeyValuePair<object, Color>>
	|
	|-RVA: 0x1F84F10 Offset: 0x1F85011 VA: 0x1F84F10
	|-Array.InternalArray__Insert<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x1F84F80 Offset: 0x1F85081 VA: 0x1F84F80
	|-Array.InternalArray__Insert<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x1F84FF0 Offset: 0x1F850F1 VA: 0x1F84FF0
	|-Array.InternalArray__Insert<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x1F85060 Offset: 0x1F85161 VA: 0x1F85060
	|-Array.InternalArray__Insert<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x1F850D0 Offset: 0x1F851D1 VA: 0x1F850D0
	|-Array.InternalArray__Insert<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x1F85140 Offset: 0x1F85241 VA: 0x1F85140
	|-Array.InternalArray__Insert<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x1F851B0 Offset: 0x1F852B1 VA: 0x1F851B0
	|-Array.InternalArray__Insert<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x1F85220 Offset: 0x1F85321 VA: 0x1F85220
	|-Array.InternalArray__Insert<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x1F85290 Offset: 0x1F85391 VA: 0x1F85290
	|-Array.InternalArray__Insert<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x1F85300 Offset: 0x1F85401 VA: 0x1F85300
	|-Array.InternalArray__Insert<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x1F85370 Offset: 0x1F85471 VA: 0x1F85370
	|-Array.InternalArray__Insert<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1F853E0 Offset: 0x1F854E1 VA: 0x1F853E0
	|-Array.InternalArray__Insert<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1F85450 Offset: 0x1F85551 VA: 0x1F85450
	|-Array.InternalArray__Insert<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x1F854C0 Offset: 0x1F855C1 VA: 0x1F854C0
	|-Array.InternalArray__Insert<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x1F85530 Offset: 0x1F85631 VA: 0x1F85530
	|-Array.InternalArray__Insert<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x1F855A0 Offset: 0x1F856A1 VA: 0x1F855A0
	|-Array.InternalArray__Insert<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x1F85610 Offset: 0x1F85711 VA: 0x1F85610
	|-Array.InternalArray__Insert<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x1F85680 Offset: 0x1F85781 VA: 0x1F85680
	|-Array.InternalArray__Insert<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x1F856F0 Offset: 0x1F857F1 VA: 0x1F856F0
	|-Array.InternalArray__Insert<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x1F85760 Offset: 0x1F85861 VA: 0x1F85760
	|-Array.InternalArray__Insert<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x1F857D0 Offset: 0x1F858D1 VA: 0x1F857D0
	|-Array.InternalArray__Insert<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x1F85840 Offset: 0x1F85941 VA: 0x1F85840
	|-Array.InternalArray__Insert<KeyValuePair<float, object>>
	|
	|-RVA: 0x1F858B0 Offset: 0x1F859B1 VA: 0x1F858B0
	|-Array.InternalArray__Insert<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x1F85920 Offset: 0x1F85A21 VA: 0x1F85920
	|-Array.InternalArray__Insert<KeyValuePair<uint, int>>
	|
	|-RVA: 0x1F85990 Offset: 0x1F85A91 VA: 0x1F85990
	|-Array.InternalArray__Insert<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x1F85A00 Offset: 0x1F85B01 VA: 0x1F85A00
	|-Array.InternalArray__Insert<KeyValuePair<uint, object>>
	|
	|-RVA: 0x1F85A70 Offset: 0x1F85B71 VA: 0x1F85A70
	|-Array.InternalArray__Insert<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x1F85AE0 Offset: 0x1F85BE1 VA: 0x1F85AE0
	|-Array.InternalArray__Insert<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x1F85B50 Offset: 0x1F85C51 VA: 0x1F85B50
	|-Array.InternalArray__Insert<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x1F85BC0 Offset: 0x1F85CC1 VA: 0x1F85BC0
	|-Array.InternalArray__Insert<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x1F85C30 Offset: 0x1F85D31 VA: 0x1F85C30
	|-Array.InternalArray__Insert<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x1F85CA0 Offset: 0x1F85DA1 VA: 0x1F85CA0
	|-Array.InternalArray__Insert<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x1F85D10 Offset: 0x1F85E11 VA: 0x1F85D10
	|-Array.InternalArray__Insert<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x1F85D80 Offset: 0x1F85E81 VA: 0x1F85D80
	|-Array.InternalArray__Insert<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x1F85DF0 Offset: 0x1F85EF1 VA: 0x1F85DF0
	|-Array.InternalArray__Insert<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x1F85E60 Offset: 0x1F85F61 VA: 0x1F85E60
	|-Array.InternalArray__Insert<KeyValuePair<Color, object>>
	|
	|-RVA: 0x1F85ED0 Offset: 0x1F85FD1 VA: 0x1F85ED0
	|-Array.InternalArray__Insert<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x1F85F40 Offset: 0x1F86041 VA: 0x1F85F40
	|-Array.InternalArray__Insert<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1F85FB0 Offset: 0x1F860B1 VA: 0x1F85FB0
	|-Array.InternalArray__Insert<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x1F86020 Offset: 0x1F86121 VA: 0x1F86020
	|-Array.InternalArray__Insert<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x1F86090 Offset: 0x1F86191 VA: 0x1F86090
	|-Array.InternalArray__Insert<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x1F86100 Offset: 0x1F86201 VA: 0x1F86100
	|-Array.InternalArray__Insert<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x1F86170 Offset: 0x1F86271 VA: 0x1F86170
	|-Array.InternalArray__Insert<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x1F861E0 Offset: 0x1F862E1 VA: 0x1F861E0
	|-Array.InternalArray__Insert<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x1F86250 Offset: 0x1F86351 VA: 0x1F86250
	|-Array.InternalArray__Insert<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x1F862C0 Offset: 0x1F863C1 VA: 0x1F862C0
	|-Array.InternalArray__Insert<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x1F86330 Offset: 0x1F86431 VA: 0x1F86330
	|-Array.InternalArray__Insert<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x1F863A0 Offset: 0x1F864A1 VA: 0x1F863A0
	|-Array.InternalArray__Insert<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x1F86410 Offset: 0x1F86511 VA: 0x1F86410
	|-Array.InternalArray__Insert<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x1F86480 Offset: 0x1F86581 VA: 0x1F86480
	|-Array.InternalArray__Insert<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x1F864F0 Offset: 0x1F865F1 VA: 0x1F864F0
	|-Array.InternalArray__Insert<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x1F86560 Offset: 0x1F86661 VA: 0x1F86560
	|-Array.InternalArray__Insert<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x1F865D0 Offset: 0x1F866D1 VA: 0x1F865D0
	|-Array.InternalArray__Insert<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x1F86640 Offset: 0x1F86741 VA: 0x1F86640
	|-Array.InternalArray__Insert<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x1F866B0 Offset: 0x1F867B1 VA: 0x1F866B0
	|-Array.InternalArray__Insert<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x1F86720 Offset: 0x1F86821 VA: 0x1F86720
	|-Array.InternalArray__Insert<Hashtable.bucket>
	|
	|-RVA: 0x1F86790 Offset: 0x1F86891 VA: 0x1F86790
	|-Array.InternalArray__Insert<DateTime>
	|
	|-RVA: 0x1F86800 Offset: 0x1F86901 VA: 0x1F86800
	|-Array.InternalArray__Insert<DateTimeOffset>
	|
	|-RVA: 0x1F86870 Offset: 0x1F86971 VA: 0x1F86870
	|-Array.InternalArray__Insert<Decimal>
	|
	|-RVA: 0x1F868E0 Offset: 0x1F869E1 VA: 0x1F868E0
	|-Array.InternalArray__Insert<double>
	|
	|-RVA: 0x1F86950 Offset: 0x1F86A51 VA: 0x1F86950
	|-Array.InternalArray__Insert<InternalCodePageDataItem>
	|
	|-RVA: 0x1F869C0 Offset: 0x1F86AC1 VA: 0x1F869C0
	|-Array.InternalArray__Insert<InternalEncodingDataItem>
	|
	|-RVA: 0x1F86A30 Offset: 0x1F86B31 VA: 0x1F86A30
	|-Array.InternalArray__Insert<Guid>
	|
	|-RVA: 0x1F86AA0 Offset: 0x1F86BA1 VA: 0x1F86AA0
	|-Array.InternalArray__Insert<short>
	|
	|-RVA: 0x1F86B10 Offset: 0x1F86C11 VA: 0x1F86B10
	|-Array.InternalArray__Insert<int>
	|
	|-RVA: 0x1F86B80 Offset: 0x1F86C81 VA: 0x1F86B80
	|-Array.InternalArray__Insert<Int32Enum>
	|
	|-RVA: 0x1F86BF0 Offset: 0x1F86CF1 VA: 0x1F86BF0
	|-Array.InternalArray__Insert<long>
	|
	|-RVA: 0x1F86C60 Offset: 0x1F86D61 VA: 0x1F86C60
	|-Array.InternalArray__Insert<IntPtr>
	|
	|-RVA: 0x1F86CD0 Offset: 0x1F86DD1 VA: 0x1F86CD0
	|-Array.InternalArray__Insert<InterpretedFrameInfo>
	|
	|-RVA: 0x1F86D40 Offset: 0x1F86E41 VA: 0x1F86D40
	|-Array.InternalArray__Insert<LocalDefinition>
	|
	|-RVA: 0x1F86DB0 Offset: 0x1F86EB1 VA: 0x1F86DB0
	|-Array.InternalArray__Insert<RuntimeLabel>
	|
	|-RVA: 0x1F86E20 Offset: 0x1F86F21 VA: 0x1F86E20
	|-Array.InternalArray__Insert<Set.Slot<int>>
	|
	|-RVA: 0x1F86E90 Offset: 0x1F86F91 VA: 0x1F86E90
	|-Array.InternalArray__Insert<Set.Slot<object>>
	|
	|-RVA: 0x1F86F00 Offset: 0x1F87001 VA: 0x1F86F00
	|-Array.InternalArray__Insert<Memory<object>>
	|
	|-RVA: 0x1F86F70 Offset: 0x1F87071 VA: 0x1F86F70
	|-Array.InternalArray__Insert<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x1F86FE0 Offset: 0x1F870E1 VA: 0x1F86FE0
	|-Array.InternalArray__Insert<HeaderVariantInfo>
	|
	|-RVA: 0x1F87050 Offset: 0x1F87151 VA: 0x1F87050
	|-Array.InternalArray__Insert<Socket.WSABUF>
	|
	|-RVA: 0x1F870C0 Offset: 0x1F871C1 VA: 0x1F870C0
	|-Array.InternalArray__Insert<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x1F87130 Offset: 0x1F87231 VA: 0x1F87130
	|-Array.InternalArray__Insert<Nullable<Int32Enum>>
	|
	|-RVA: 0x1F871A0 Offset: 0x1F872A1 VA: 0x1F871A0
	|-Array.InternalArray__Insert<Nullable<Bounds>>
	|
	|-RVA: 0x1F87210 Offset: 0x1F87311 VA: 0x1F87210
	|-Array.InternalArray__Insert<Nullable<BoundsInt>>
	|
	|-RVA: 0x1F87280 Offset: 0x1F87381 VA: 0x1F87280
	|-Array.InternalArray__Insert<Nullable<Color32>>
	|
	|-RVA: 0x1F872F0 Offset: 0x1F873F1 VA: 0x1F872F0
	|-Array.InternalArray__Insert<Nullable<Color>>
	|
	|-RVA: 0x1F87360 Offset: 0x1F87461 VA: 0x1F87360
	|-Array.InternalArray__Insert<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1F873D0 Offset: 0x1F874D1 VA: 0x1F873D0
	|-Array.InternalArray__Insert<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1F87440 Offset: 0x1F87541 VA: 0x1F87440
	|-Array.InternalArray__Insert<Nullable<Keyframe>>
	|
	|-RVA: 0x1F874B0 Offset: 0x1F875B1 VA: 0x1F874B0
	|-Array.InternalArray__Insert<Nullable<LayerMask>>
	|
	|-RVA: 0x1F87520 Offset: 0x1F87621 VA: 0x1F87520
	|-Array.InternalArray__Insert<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1F87590 Offset: 0x1F87691 VA: 0x1F87590
	|-Array.InternalArray__Insert<Nullable<Quaternion>>
	|
	|-RVA: 0x1F87600 Offset: 0x1F87701 VA: 0x1F87600
	|-Array.InternalArray__Insert<Nullable<RangeInt>>
	|
	|-RVA: 0x1F87670 Offset: 0x1F87771 VA: 0x1F87670
	|-Array.InternalArray__Insert<Nullable<Rect>>
	|
	|-RVA: 0x1F876E0 Offset: 0x1F877E1 VA: 0x1F876E0
	|-Array.InternalArray__Insert<Nullable<RectInt>>
	|
	|-RVA: 0x1F87750 Offset: 0x1F87851 VA: 0x1F87750
	|-Array.InternalArray__Insert<Nullable<Vector2>>
	|
	|-RVA: 0x1F877C0 Offset: 0x1F878C1 VA: 0x1F877C0
	|-Array.InternalArray__Insert<Nullable<Vector2Int>>
	|
	|-RVA: 0x1F87830 Offset: 0x1F87931 VA: 0x1F87830
	|-Array.InternalArray__Insert<Nullable<Vector3>>
	|
	|-RVA: 0x1F878A0 Offset: 0x1F879A1 VA: 0x1F878A0
	|-Array.InternalArray__Insert<Nullable<Vector3Int>>
	|
	|-RVA: 0x1F87910 Offset: 0x1F87A11 VA: 0x1F87910
	|-Array.InternalArray__Insert<Nullable<Vector4>>
	|
	|-RVA: 0x1F87980 Offset: 0x1F87A81 VA: 0x1F87980
	|-Array.InternalArray__Insert<object>
	|
	|-RVA: 0x1F879F0 Offset: 0x1F87AF1 VA: 0x1F879F0
	|-Array.InternalArray__Insert<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x1F87A60 Offset: 0x1F87B61 VA: 0x1F87A60
	|-Array.InternalArray__Insert<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1F87AD0 Offset: 0x1F87BD1 VA: 0x1F87AD0
	|-Array.InternalArray__Insert<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1F87B40 Offset: 0x1F87C41 VA: 0x1F87B40
	|-Array.InternalArray__Insert<CustomAttributeTypedArgument>
	|
	|-RVA: 0x1F87BB0 Offset: 0x1F87CB1 VA: 0x1F87BB0
	|-Array.InternalArray__Insert<Label>
	|
	|-RVA: 0x1F87C20 Offset: 0x1F87D21 VA: 0x1F87C20
	|-Array.InternalArray__Insert<ParameterModifier>
	|
	|-RVA: 0x1F87C90 Offset: 0x1F87D91 VA: 0x1F87C90
	|-Array.InternalArray__Insert<ResourceLocator>
	|
	|-RVA: 0x1F87D00 Offset: 0x1F87E01 VA: 0x1F87D00
	|-Array.InternalArray__Insert<Ephemeron>
	|
	|-RVA: 0x1F87D70 Offset: 0x1F87E71 VA: 0x1F87D70
	|-Array.InternalArray__Insert<GCHandle>
	|
	|-RVA: 0x1F87DE0 Offset: 0x1F87EE1 VA: 0x1F87DE0
	|-Array.InternalArray__Insert<RuntimeTypeHandle>
	|
	|-RVA: 0x1F87E50 Offset: 0x1F87F51 VA: 0x1F87E50
	|-Array.InternalArray__Insert<sbyte>
	|
	|-RVA: 0x1F87EC0 Offset: 0x1F87FC1 VA: 0x1F87EC0
	|-Array.InternalArray__Insert<X509ChainStatus>
	|
	|-RVA: 0x1F87F30 Offset: 0x1F88031 VA: 0x1F87F30
	|-Array.InternalArray__Insert<float>
	|
	|-RVA: 0x1F87FA0 Offset: 0x1F880A1 VA: 0x1F87FA0
	|-Array.InternalArray__Insert<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x1F88010 Offset: 0x1F88111 VA: 0x1F88010
	|-Array.InternalArray__Insert<CancellationTokenRegistration>
	|
	|-RVA: 0x1F88080 Offset: 0x1F88181 VA: 0x1F88080
	|-Array.InternalArray__Insert<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x1F880F0 Offset: 0x1F881F1 VA: 0x1F880F0
	|-Array.InternalArray__Insert<TimeSpan>
	|
	|-RVA: 0x1F88160 Offset: 0x1F88261 VA: 0x1F88160
	|-Array.InternalArray__Insert<ushort>
	|
	|-RVA: 0x1F881D0 Offset: 0x1F882D1 VA: 0x1F881D0
	|-Array.InternalArray__Insert<UInt16Enum>
	|
	|-RVA: 0x1F88240 Offset: 0x1F88341 VA: 0x1F88240
	|-Array.InternalArray__Insert<uint>
	|
	|-RVA: 0x1F882B0 Offset: 0x1F883B1 VA: 0x1F882B0
	|-Array.InternalArray__Insert<UInt32Enum>
	|
	|-RVA: 0x1F88320 Offset: 0x1F88421 VA: 0x1F88320
	|-Array.InternalArray__Insert<ulong>
	|
	|-RVA: 0x1F88390 Offset: 0x1F88491 VA: 0x1F88390
	|-Array.InternalArray__Insert<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x1F88400 Offset: 0x1F88501 VA: 0x1F88400
	|-Array.InternalArray__Insert<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x1F88470 Offset: 0x1F88571 VA: 0x1F88470
	|-Array.InternalArray__Insert<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x1F884E0 Offset: 0x1F885E1 VA: 0x1F884E0
	|-Array.InternalArray__Insert<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x1F88550 Offset: 0x1F88651 VA: 0x1F88550
	|-Array.InternalArray__Insert<ValueTuple<object, object>>
	|
	|-RVA: 0x1F885C0 Offset: 0x1F886C1 VA: 0x1F885C0
	|-Array.InternalArray__Insert<ValueTuple<object, float>>
	|
	|-RVA: 0x1F88630 Offset: 0x1F88731 VA: 0x1F88630
	|-Array.InternalArray__Insert<ValueTuple<float, object>>
	|
	|-RVA: 0x1F886A0 Offset: 0x1F887A1 VA: 0x1F886A0
	|-Array.InternalArray__Insert<ValueTuple<float, float>>
	|
	|-RVA: 0x1F88710 Offset: 0x1F88811 VA: 0x1F88710
	|-Array.InternalArray__Insert<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x1F88780 Offset: 0x1F88881 VA: 0x1F88780
	|-Array.InternalArray__Insert<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1F887F0 Offset: 0x1F888F1 VA: 0x1F887F0
	|-Array.InternalArray__Insert<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x1F88860 Offset: 0x1F88961 VA: 0x1F88860
	|-Array.InternalArray__Insert<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x1F888D0 Offset: 0x1F889D1 VA: 0x1F888D0
	|-Array.InternalArray__Insert<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x1F88940 Offset: 0x1F88A41 VA: 0x1F88940
	|-Array.InternalArray__Insert<HighlightState>
	|
	|-RVA: 0x1F889B0 Offset: 0x1F88AB1 VA: 0x1F889B0
	|-Array.InternalArray__Insert<MaterialReference>
	|
	|-RVA: 0x1F88A20 Offset: 0x1F88B21 VA: 0x1F88A20
	|-Array.InternalArray__Insert<RichTextTagAttribute>
	|
	|-RVA: 0x1F88A90 Offset: 0x1F88B91 VA: 0x1F88A90
	|-Array.InternalArray__Insert<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x1F88B00 Offset: 0x1F88C01 VA: 0x1F88B00
	|-Array.InternalArray__Insert<TMP_CharacterInfo>
	|
	|-RVA: 0x1F88B70 Offset: 0x1F88C71 VA: 0x1F88B70
	|-Array.InternalArray__Insert<TMP_FontWeightPair>
	|
	|-RVA: 0x1F88BE0 Offset: 0x1F88CE1 VA: 0x1F88BE0
	|-Array.InternalArray__Insert<TMP_LineInfo>
	|
	|-RVA: 0x1F88C50 Offset: 0x1F88D51 VA: 0x1F88C50
	|-Array.InternalArray__Insert<TMP_LinkInfo>
	|
	|-RVA: 0x1F88CC0 Offset: 0x1F88DC1 VA: 0x1F88CC0
	|-Array.InternalArray__Insert<TMP_MeshInfo>
	|
	|-RVA: 0x1F88D30 Offset: 0x1F88E31 VA: 0x1F88D30
	|-Array.InternalArray__Insert<TMP_PageInfo>
	|
	|-RVA: 0x1F88DA0 Offset: 0x1F88EA1 VA: 0x1F88DA0
	|-Array.InternalArray__Insert<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x1F88E10 Offset: 0x1F88F11 VA: 0x1F88E10
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x1F88E80 Offset: 0x1F88F81 VA: 0x1F88E80
	|-Array.InternalArray__Insert<TMP_WordInfo>
	|
	|-RVA: 0x1F88EF0 Offset: 0x1F88FF1 VA: 0x1F88EF0
	|-Array.InternalArray__Insert<WordWrapState>
	|
	|-RVA: 0x1F88F60 Offset: 0x1F89061 VA: 0x1F88F60
	|-Array.InternalArray__Insert<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x1F88FD0 Offset: 0x1F890D1 VA: 0x1F88FD0
	|-Array.InternalArray__Insert<TransitionTables>
	|
	|-RVA: 0x1F89040 Offset: 0x1F89141 VA: 0x1F89040
	|-Array.InternalArray__Insert<TutorialUnlockFlagData>
	|
	|-RVA: 0x1F890B0 Offset: 0x1F891B1 VA: 0x1F890B0
	|-Array.InternalArray__Insert<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x1F89120 Offset: 0x1F89221 VA: 0x1F89120
	|-Array.InternalArray__Insert<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x1F89190 Offset: 0x1F89291 VA: 0x1F89190
	|-Array.InternalArray__Insert<CapEdge>
	|
	|-RVA: 0x1F89200 Offset: 0x1F89301 VA: 0x1F89200
	|-Array.InternalArray__Insert<ClippedEdge>
	|
	|-RVA: 0x1F89270 Offset: 0x1F89371 VA: 0x1F89270
	|-Array.InternalArray__Insert<EdgeKeyByHash>
	|
	|-RVA: 0x235BC70 Offset: 0x235BD71 VA: 0x235BC70
	|-Array.InternalArray__Insert<EdgeKeyByIndex>
	|
	|-RVA: 0x235BCE0 Offset: 0x235BDE1 VA: 0x235BCE0
	|-Array.InternalArray__Insert<MeshDataConnectivity.Face>
	|
	|-RVA: 0x235BD50 Offset: 0x235BE51 VA: 0x235BD50
	|-Array.InternalArray__Insert<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x235BDC0 Offset: 0x235BEC1 VA: 0x235BDC0
	|-Array.InternalArray__Insert<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x235BE30 Offset: 0x235BF31 VA: 0x235BE30
	|-Array.InternalArray__Insert<NavMeshBuildMarkup>
	|
	|-RVA: 0x235BEA0 Offset: 0x235BFA1 VA: 0x235BEA0
	|-Array.InternalArray__Insert<NavMeshBuildSource>
	|
	|-RVA: 0x235BF10 Offset: 0x235C011 VA: 0x235BF10
	|-Array.InternalArray__Insert<ContentCatalogData.Bucket>
	|
	|-RVA: 0x235BF80 Offset: 0x235C081 VA: 0x235BF80
	|-Array.InternalArray__Insert<ConstraintSource>
	|
	|-RVA: 0x235BFF0 Offset: 0x235C0F1 VA: 0x235BFF0
	|-Array.InternalArray__Insert<PropertySceneHandle>
	|
	|-RVA: 0x235C060 Offset: 0x235C161 VA: 0x235C060
	|-Array.InternalArray__Insert<TransformStreamHandle>
	|
	|-RVA: 0x235C0D0 Offset: 0x235C1D1 VA: 0x235C0D0
	|-Array.InternalArray__Insert<AnimatorClipInfo>
	|
	|-RVA: 0x235C140 Offset: 0x235C241 VA: 0x235C140
	|-Array.InternalArray__Insert<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x235C1B0 Offset: 0x235C2B1 VA: 0x235C1B0
	|-Array.InternalArray__Insert<BoneWeight1>
	|
	|-RVA: 0x235C220 Offset: 0x235C321 VA: 0x235C220
	|-Array.InternalArray__Insert<BoneWeight>
	|
	|-RVA: 0x235C290 Offset: 0x235C391 VA: 0x235C290
	|-Array.InternalArray__Insert<BoundingSphere>
	|
	|-RVA: 0x235C300 Offset: 0x235C401 VA: 0x235C300
	|-Array.InternalArray__Insert<Bounds>
	|
	|-RVA: 0x235C370 Offset: 0x235C471 VA: 0x235C370
	|-Array.InternalArray__Insert<BoundsInt>
	|
	|-RVA: 0x235C3E0 Offset: 0x235C4E1 VA: 0x235C3E0
	|-Array.InternalArray__Insert<CharacterInfo>
	|
	|-RVA: 0x235C450 Offset: 0x235C551 VA: 0x235C450
	|-Array.InternalArray__Insert<Color32>
	|
	|-RVA: 0x235C4C0 Offset: 0x235C5C1 VA: 0x235C4C0
	|-Array.InternalArray__Insert<Color>
	|
	|-RVA: 0x235C530 Offset: 0x235C631 VA: 0x235C530
	|-Array.InternalArray__Insert<CombineInstance>
	|
	|-RVA: 0x235C5A0 Offset: 0x235C6A1 VA: 0x235C5A0
	|-Array.InternalArray__Insert<ContactPoint2D>
	|
	|-RVA: 0x235C610 Offset: 0x235C711 VA: 0x235C610
	|-Array.InternalArray__Insert<ContactPoint>
	|
	|-RVA: 0x235C680 Offset: 0x235C781 VA: 0x235C680
	|-Array.InternalArray__Insert<RaycastResult>
	|
	|-RVA: 0x235C6F0 Offset: 0x235C7F1 VA: 0x235C6F0
	|-Array.InternalArray__Insert<LightDataGI>
	|
	|-RVA: 0x235C760 Offset: 0x235C861 VA: 0x235C760
	|-Array.InternalArray__Insert<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x235C7D0 Offset: 0x235C8D1 VA: 0x235C7D0
	|-Array.InternalArray__Insert<GradientAlphaKey>
	|
	|-RVA: 0x235C840 Offset: 0x235C941 VA: 0x235C840
	|-Array.InternalArray__Insert<GradientColorKey>
	|
	|-RVA: 0x235C8B0 Offset: 0x235C9B1 VA: 0x235C8B0
	|-Array.InternalArray__Insert<HumanBone>
	|
	|-RVA: 0x235C920 Offset: 0x235CA21 VA: 0x235C920
	|-Array.InternalArray__Insert<Keyframe>
	|
	|-RVA: 0x235C990 Offset: 0x235CA91 VA: 0x235C990
	|-Array.InternalArray__Insert<LOD>
	|
	|-RVA: 0x235CA00 Offset: 0x235CB01 VA: 0x235CA00
	|-Array.InternalArray__Insert<LayerMask>
	|
	|-RVA: 0x235CA70 Offset: 0x235CB71 VA: 0x235CA70
	|-Array.InternalArray__Insert<PlayerLoopSystem>
	|
	|-RVA: 0x235CAE0 Offset: 0x235CBE1 VA: 0x235CAE0
	|-Array.InternalArray__Insert<Matrix4x4>
	|
	|-RVA: 0x235CB50 Offset: 0x235CC51 VA: 0x235CB50
	|-Array.InternalArray__Insert<ParticleSystem.Particle>
	|
	|-RVA: 0x235CBC0 Offset: 0x235CCC1 VA: 0x235CBC0
	|-Array.InternalArray__Insert<PatchExtents>
	|
	|-RVA: 0x235CC30 Offset: 0x235CD31 VA: 0x235CC30
	|-Array.InternalArray__Insert<Plane>
	|
	|-RVA: 0x235CCA0 Offset: 0x235CDA1 VA: 0x235CCA0
	|-Array.InternalArray__Insert<Playable>
	|
	|-RVA: 0x235CD10 Offset: 0x235CE11 VA: 0x235CD10
	|-Array.InternalArray__Insert<PlayableBinding>
	|
	|-RVA: 0x235CD80 Offset: 0x235CE81 VA: 0x235CD80
	|-Array.InternalArray__Insert<PlayableGraph>
	|
	|-RVA: 0x235CDF0 Offset: 0x235CEF1 VA: 0x235CDF0
	|-Array.InternalArray__Insert<Edge>
	|
	|-RVA: 0x235CE60 Offset: 0x235CF61 VA: 0x235CE60
	|-Array.InternalArray__Insert<IntVec3>
	|
	|-RVA: 0x235CED0 Offset: 0x235CFD1 VA: 0x235CED0
	|-Array.InternalArray__Insert<Quaternion>
	|
	|-RVA: 0x235CF40 Offset: 0x235D041 VA: 0x235CF40
	|-Array.InternalArray__Insert<RangeInt>
	|
	|-RVA: 0x235CFB0 Offset: 0x235D0B1 VA: 0x235CFB0
	|-Array.InternalArray__Insert<RaycastHit2D>
	|
	|-RVA: 0x235D020 Offset: 0x235D121 VA: 0x235D020
	|-Array.InternalArray__Insert<RaycastHit>
	|
	|-RVA: 0x235D090 Offset: 0x235D191 VA: 0x235D090
	|-Array.InternalArray__Insert<Rect>
	|
	|-RVA: 0x235D100 Offset: 0x235D201 VA: 0x235D100
	|-Array.InternalArray__Insert<RectInt>
	|
	|-RVA: 0x235D170 Offset: 0x235D271 VA: 0x235D170
	|-Array.InternalArray__Insert<RenderBuffer>
	|
	|-RVA: 0x235D1E0 Offset: 0x235D2E1 VA: 0x235D1E0
	|-Array.InternalArray__Insert<BatchVisibility>
	|
	|-RVA: 0x235D250 Offset: 0x235D351 VA: 0x235D250
	|-Array.InternalArray__Insert<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x235D2C0 Offset: 0x235D3C1 VA: 0x235D2C0
	|-Array.InternalArray__Insert<SphericalHarmonicsL2>
	|
	|-RVA: 0x235D330 Offset: 0x235D431 VA: 0x235D330
	|-Array.InternalArray__Insert<VertexAttributeDescriptor>
	|
	|-RVA: 0x235D3A0 Offset: 0x235D4A1 VA: 0x235D3A0
	|-Array.InternalArray__Insert<AsyncOperationHandle>
	|
	|-RVA: 0x235D410 Offset: 0x235D511 VA: 0x235D410
	|-Array.InternalArray__Insert<AsyncOperationHandle<object>>
	|
	|-RVA: 0x235D480 Offset: 0x235D581 VA: 0x235D480
	|-Array.InternalArray__Insert<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x235D4F0 Offset: 0x235D5F1 VA: 0x235D4F0
	|-Array.InternalArray__Insert<DiagnosticEvent>
	|
	|-RVA: 0x235D560 Offset: 0x235D661 VA: 0x235D560
	|-Array.InternalArray__Insert<SceneInstance>
	|
	|-RVA: 0x235D5D0 Offset: 0x235D6D1 VA: 0x235D5D0
	|-Array.InternalArray__Insert<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x235D640 Offset: 0x235D741 VA: 0x235D640
	|-Array.InternalArray__Insert<ObjectInitializationData>
	|
	|-RVA: 0x235D6B0 Offset: 0x235D7B1 VA: 0x235D6B0
	|-Array.InternalArray__Insert<SerializedType>
	|
	|-RVA: 0x235D720 Offset: 0x235D821 VA: 0x235D720
	|-Array.InternalArray__Insert<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x235D790 Offset: 0x235D891 VA: 0x235D790
	|-Array.InternalArray__Insert<SkeletonBone>
	|
	|-RVA: 0x235D800 Offset: 0x235D901 VA: 0x235D800
	|-Array.InternalArray__Insert<GlyphRect>
	|
	|-RVA: 0x235D870 Offset: 0x235D971 VA: 0x235D870
	|-Array.InternalArray__Insert<GlyphMarshallingStruct>
	|
	|-RVA: 0x235D8E0 Offset: 0x235D9E1 VA: 0x235D8E0
	|-Array.InternalArray__Insert<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x235D950 Offset: 0x235DA51 VA: 0x235D950
	|-Array.InternalArray__Insert<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x235D9C0 Offset: 0x235DAC1 VA: 0x235D9C0
	|-Array.InternalArray__Insert<IntervalTreeNode>
	|
	|-RVA: 0x235DA30 Offset: 0x235DB31 VA: 0x235DA30
	|-Array.InternalArray__Insert<IntervalTree.Entry<object>>
	|
	|-RVA: 0x235DAA0 Offset: 0x235DBA1 VA: 0x235DAA0
	|-Array.InternalArray__Insert<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x235DB10 Offset: 0x235DC11 VA: 0x235DB10
	|-Array.InternalArray__Insert<Touch>
	|
	|-RVA: 0x235DB80 Offset: 0x235DC81 VA: 0x235DB80
	|-Array.InternalArray__Insert<TreeInstance>
	|
	|-RVA: 0x235DBF0 Offset: 0x235DCF1 VA: 0x235DBF0
	|-Array.InternalArray__Insert<ColorBlock>
	|
	|-RVA: 0x235DC60 Offset: 0x235DD61 VA: 0x235DC60
	|-Array.InternalArray__Insert<Navigation>
	|
	|-RVA: 0x235DCD0 Offset: 0x235DDD1 VA: 0x235DCD0
	|-Array.InternalArray__Insert<SpriteState>
	|
	|-RVA: 0x235DD40 Offset: 0x235DE41 VA: 0x235DD40
	|-Array.InternalArray__Insert<UICharInfo>
	|
	|-RVA: 0x235DDB0 Offset: 0x235DEB1 VA: 0x235DDB0
	|-Array.InternalArray__Insert<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x235DE20 Offset: 0x235DF21 VA: 0x235DE20
	|-Array.InternalArray__Insert<EventDispatcher.EventRecord>
	|
	|-RVA: 0x235DE90 Offset: 0x235DF91 VA: 0x235DE90
	|-Array.InternalArray__Insert<FocusController.FocusedElement>
	|
	|-RVA: 0x235DF00 Offset: 0x235E001 VA: 0x235DF00
	|-Array.InternalArray__Insert<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x235DF70 Offset: 0x235E071 VA: 0x235DF70
	|-Array.InternalArray__Insert<StyleValue>
	|
	|-RVA: 0x235DFE0 Offset: 0x235E0E1 VA: 0x235DFE0
	|-Array.InternalArray__Insert<UILineInfo>
	|
	|-RVA: 0x235E050 Offset: 0x235E151 VA: 0x235E050
	|-Array.InternalArray__Insert<UIVertex>
	|
	|-RVA: 0x235E0C0 Offset: 0x235E1C1 VA: 0x235E0C0
	|-Array.InternalArray__Insert<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x235E130 Offset: 0x235E231 VA: 0x235E130
	|-Array.InternalArray__Insert<Vector2>
	|
	|-RVA: 0x235E1A0 Offset: 0x235E2A1 VA: 0x235E1A0
	|-Array.InternalArray__Insert<Vector2Int>
	|
	|-RVA: 0x235E210 Offset: 0x235E311 VA: 0x235E210
	|-Array.InternalArray__Insert<Vector3>
	|
	|-RVA: 0x235E280 Offset: 0x235E381 VA: 0x235E280
	|-Array.InternalArray__Insert<Vector3Int>
	|
	|-RVA: 0x235E2F0 Offset: 0x235E3F1 VA: 0x235E2F0
	|-Array.InternalArray__Insert<Vector4>
	|
	|-RVA: 0x235E360 Offset: 0x235E461 VA: 0x235E360
	|-Array.InternalArray__Insert<jvalue>
	|
	|-RVA: 0x235E3D0 Offset: 0x235E4D1 VA: 0x235E3D0
	|-Array.InternalArray__Insert<WarpPoints.WarpPoint>
	|
	|-RVA: 0x235E440 Offset: 0x235E541 VA: 0x235E440
	|-Array.InternalArray__Insert<YieldItemParam>
	|
	|-RVA: 0x235E4B0 Offset: 0x235E5B1 VA: 0x235E4B0
	|-Array.InternalArray__Insert<NetworkServiceAccountId>
	|
	|-RVA: 0x235E520 Offset: 0x235E621 VA: 0x235E520
	|-Array.InternalArray__Insert<Uid>
	|
	|-RVA: 0x235E590 Offset: 0x235E691 VA: 0x235E590
	|-Array.InternalArray__Insert<ConsumableServiceItemId>
	|
	|-RVA: 0x235E600 Offset: 0x235E701 VA: 0x235E600
	|-Array.InternalArray__Insert<NsUid>
	|
	|-RVA: 0x235E670 Offset: 0x235E771 VA: 0x235E670
	|-Array.InternalArray__Insert<Friend>
	|
	|-RVA: 0x235E6E0 Offset: 0x235E7E1 VA: 0x235E6E0
	|-Array.InternalArray__Insert<Profile>
	|
	|-RVA: 0x235E750 Offset: 0x235E851 VA: 0x235E750
	|-Array.InternalArray__Insert<DirectoryEntry>
	|
	|-RVA: 0x235E7C0 Offset: 0x235E8C1 VA: 0x235E7C0
	|-Array.InternalArray__Insert<DebugPadState>
	|
	|-RVA: 0x235E830 Offset: 0x235E931 VA: 0x235E830
	|-Array.InternalArray__Insert<GesturePoint>
	|
	|-RVA: 0x235E8A0 Offset: 0x235E9A1 VA: 0x235E8A0
	|-Array.InternalArray__Insert<GestureState>
	|
	|-RVA: 0x235E910 Offset: 0x235EA11 VA: 0x235E910
	|-Array.InternalArray__Insert<NpadFullKeyState>
	|
	|-RVA: 0x235E980 Offset: 0x235EA81 VA: 0x235E980
	|-Array.InternalArray__Insert<NpadHandheldState>
	|
	|-RVA: 0x235E9F0 Offset: 0x235EAF1 VA: 0x235E9F0
	|-Array.InternalArray__Insert<NpadJoyDualState>
	|
	|-RVA: 0x235EA60 Offset: 0x235EB61 VA: 0x235EA60
	|-Array.InternalArray__Insert<NpadJoyLeftState>
	|
	|-RVA: 0x235EAD0 Offset: 0x235EBD1 VA: 0x235EAD0
	|-Array.InternalArray__Insert<NpadJoyRightState>
	|
	|-RVA: 0x235EB40 Offset: 0x235EC41 VA: 0x235EB40
	|-Array.InternalArray__Insert<NpadStateArrayItem>
	|
	|-RVA: 0x235EBB0 Offset: 0x235ECB1 VA: 0x235EBB0
	|-Array.InternalArray__Insert<SixAxisSensorHandle>
	|
	|-RVA: 0x235EC20 Offset: 0x235ED21 VA: 0x235EC20
	|-Array.InternalArray__Insert<SixAxisSensorState>
	|
	|-RVA: 0x235EC90 Offset: 0x235ED91 VA: 0x235EC90
	|-Array.InternalArray__Insert<TouchScreenState10>
	|
	|-RVA: 0x235ED00 Offset: 0x235EE01 VA: 0x235ED00
	|-Array.InternalArray__Insert<TouchScreenState11>
	|
	|-RVA: 0x235ED70 Offset: 0x235EE71 VA: 0x235ED70
	|-Array.InternalArray__Insert<TouchScreenState12>
	|
	|-RVA: 0x235EDE0 Offset: 0x235EEE1 VA: 0x235EDE0
	|-Array.InternalArray__Insert<TouchScreenState13>
	|
	|-RVA: 0x235EE50 Offset: 0x235EF51 VA: 0x235EE50
	|-Array.InternalArray__Insert<TouchScreenState14>
	|
	|-RVA: 0x235EEC0 Offset: 0x235EFC1 VA: 0x235EEC0
	|-Array.InternalArray__Insert<TouchScreenState15>
	|
	|-RVA: 0x235EF30 Offset: 0x235F031 VA: 0x235EF30
	|-Array.InternalArray__Insert<TouchScreenState16>
	|
	|-RVA: 0x235EFA0 Offset: 0x235F0A1 VA: 0x235EFA0
	|-Array.InternalArray__Insert<TouchScreenState1>
	|
	|-RVA: 0x235F010 Offset: 0x235F111 VA: 0x235F010
	|-Array.InternalArray__Insert<TouchScreenState2>
	|
	|-RVA: 0x235F080 Offset: 0x235F181 VA: 0x235F080
	|-Array.InternalArray__Insert<TouchScreenState3>
	|
	|-RVA: 0x235F0F0 Offset: 0x235F1F1 VA: 0x235F0F0
	|-Array.InternalArray__Insert<TouchScreenState4>
	|
	|-RVA: 0x235F160 Offset: 0x235F261 VA: 0x235F160
	|-Array.InternalArray__Insert<TouchScreenState5>
	|
	|-RVA: 0x235F1D0 Offset: 0x235F2D1 VA: 0x235F1D0
	|-Array.InternalArray__Insert<TouchScreenState6>
	|
	|-RVA: 0x235F240 Offset: 0x235F341 VA: 0x235F240
	|-Array.InternalArray__Insert<TouchScreenState7>
	|
	|-RVA: 0x235F2B0 Offset: 0x235F3B1 VA: 0x235F2B0
	|-Array.InternalArray__Insert<TouchScreenState8>
	|
	|-RVA: 0x235F320 Offset: 0x235F421 VA: 0x235F320
	|-Array.InternalArray__Insert<TouchScreenState9>
	|
	|-RVA: 0x235F390 Offset: 0x235F491 VA: 0x235F390
	|-Array.InternalArray__Insert<TouchState>
	|
	|-RVA: 0x235F400 Offset: 0x235F501 VA: 0x235F400
	|-Array.InternalArray__Insert<VibrationDeviceHandle>
	|
	|-RVA: 0x235F470 Offset: 0x235F571 VA: 0x235F470
	|-Array.InternalArray__Insert<VibrationDeviceInfo>
	|
	|-RVA: 0x235F4E0 Offset: 0x235F5E1 VA: 0x235F4E0
	|-Array.InternalArray__Insert<VibrationValue>
	|
	|-RVA: 0x235F550 Offset: 0x235F651 VA: 0x235F550
	|-Array.InternalArray__Insert<ClusteringData>
	|
	|-RVA: 0x235F5C0 Offset: 0x235F6C1 VA: 0x235F5C0
	|-Array.InternalArray__Insert<ClusteringProcessorState>
	|
	|-RVA: 0x235F630 Offset: 0x235F731 VA: 0x235F630
	|-Array.InternalArray__Insert<Finger>
	|
	|-RVA: 0x235F6A0 Offset: 0x235F7A1 VA: 0x235F6A0
	|-Array.InternalArray__Insert<Hand>
	|
	|-RVA: 0x235F710 Offset: 0x235F811 VA: 0x235F710
	|-Array.InternalArray__Insert<HandAnalysisImageState>
	|
	|-RVA: 0x235F780 Offset: 0x235F881 VA: 0x235F780
	|-Array.InternalArray__Insert<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x235F7F0 Offset: 0x235F8F1 VA: 0x235F7F0
	|-Array.InternalArray__Insert<MomentProcessorState>
	|
	|-RVA: 0x235F860 Offset: 0x235F961 VA: 0x235F860
	|-Array.InternalArray__Insert<MomentStatistic>
	|
	|-RVA: 0x235F8D0 Offset: 0x235F9D1 VA: 0x235F8D0
	|-Array.InternalArray__Insert<Protrusion>
	|
	|-RVA: 0x235F940 Offset: 0x235FA41 VA: 0x235F940
	|-Array.InternalArray__Insert<Shape>
	|
	|-RVA: 0x235F9B0 Offset: 0x235FAB1 VA: 0x235F9B0
	|-Array.InternalArray__Insert<DictionaryInfo>
	|
	|-RVA: 0x235FA20 Offset: 0x235FB21 VA: 0x235FA20
	|-Array.InternalArray__Insert<UserWord>
	|
	|-RVA: 0x235FA90 Offset: 0x235FB91 VA: 0x235FA90
	|-Array.InternalArray__Insert<Color4u8>
	|
	|-RVA: 0x235FB00 Offset: 0x235FC01 VA: 0x235FB00
	|-Array.InternalArray__Insert<Float2>
	|
	|-RVA: 0x235FB70 Offset: 0x235FC71 VA: 0x235FB70
	|-Array.InternalArray__Insert<stCommand_t>
	*/

	// RVA: 0x184D630 Offset: 0x184D731 VA: 0x184D630
	internal void InternalArray__RemoveAt(int index) { }

	// RVA: -1 Offset: -1
	internal int InternalArray__IndexOf<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26239F0 Offset: 0x2623AF1 VA: 0x26239F0
	|-Array.InternalArray__IndexOf<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x2623BD0 Offset: 0x2623CD1 VA: 0x2623BD0
	|-Array.InternalArray__IndexOf<ActionCommandDataTable>
	|
	|-RVA: 0x2623E00 Offset: 0x2623F01 VA: 0x2623E00
	|-Array.InternalArray__IndexOf<AdvScriptDefCountParam>
	|
	|-RVA: 0x2623FD0 Offset: 0x26240D1 VA: 0x2623FD0
	|-Array.InternalArray__IndexOf<JSONDeserialization.TaskField>
	|
	|-RVA: 0x26241A0 Offset: 0x26242A1 VA: 0x26241A0
	|-Array.InternalArray__IndexOf<BitVector32Int>
	|
	|-RVA: 0x2624320 Offset: 0x2624421 VA: 0x2624320
	|-Array.InternalArray__IndexOf<BuildItemData>
	|
	|-RVA: 0x2624580 Offset: 0x2624681 VA: 0x2624580
	|-Array.InternalArray__IndexOf<ButtonLinker.LinkObject>
	|
	|-RVA: 0x2624750 Offset: 0x2624851 VA: 0x2624750
	|-Array.InternalArray__IndexOf<CharaCallTable.BustupTable>
	|
	|-RVA: 0x2624920 Offset: 0x2624A21 VA: 0x2624920
	|-Array.InternalArray__IndexOf<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x2624B00 Offset: 0x2624C01 VA: 0x2624B00
	|-Array.InternalArray__IndexOf<CameraState.CustomBlendable>
	|
	|-RVA: 0x2624CD0 Offset: 0x2624DD1 VA: 0x2624CD0
	|-Array.InternalArray__IndexOf<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x2624EB0 Offset: 0x2624FB1 VA: 0x2624EB0
	|-Array.InternalArray__IndexOf<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x2625090 Offset: 0x2625191 VA: 0x2625090
	|-Array.InternalArray__IndexOf<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2625260 Offset: 0x2625361 VA: 0x2625260
	|-Array.InternalArray__IndexOf<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x2625430 Offset: 0x2625531 VA: 0x2625430
	|-Array.InternalArray__IndexOf<CinemachinePath.Waypoint>
	|
	|-RVA: 0x2625620 Offset: 0x2625721 VA: 0x2625620
	|-Array.InternalArray__IndexOf<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x2625800 Offset: 0x2625901 VA: 0x2625800
	|-Array.InternalArray__IndexOf<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x26259D0 Offset: 0x2625AD1 VA: 0x26259D0
	|-Array.InternalArray__IndexOf<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x2625BB0 Offset: 0x2625CB1 VA: 0x2625BB0
	|-Array.InternalArray__IndexOf<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x2625D80 Offset: 0x2625E81 VA: 0x2625D80
	|-Array.InternalArray__IndexOf<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x2625F50 Offset: 0x2626051 VA: 0x2625F50
	|-Array.InternalArray__IndexOf<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x2626150 Offset: 0x2626251 VA: 0x2626150
	|-Array.InternalArray__IndexOf<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2626340 Offset: 0x2626441 VA: 0x2626340
	|-Array.InternalArray__IndexOf<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x2626540 Offset: 0x2626641 VA: 0x2626540
	|-Array.InternalArray__IndexOf<HeadingTracker.Item>
	|
	|-RVA: 0x2626720 Offset: 0x2626821 VA: 0x2626720
	|-Array.InternalArray__IndexOf<CropDataTable>
	|
	|-RVA: 0x2626930 Offset: 0x2626A31 VA: 0x2626930
	|-Array.InternalArray__IndexOf<ControlPoint>
	|
	|-RVA: 0x2626B10 Offset: 0x2626C11 VA: 0x2626B10
	|-Array.InternalArray__IndexOf<DamageTextInfo>
	|
	|-RVA: 0x2626CF0 Offset: 0x2626DF1 VA: 0x2626CF0
	|-Array.InternalArray__IndexOf<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x2626ED0 Offset: 0x2626FD1 VA: 0x2626ED0
	|-Array.InternalArray__IndexOf<DropItemParam>
	|
	|-RVA: 0x26270A0 Offset: 0x26271A1 VA: 0x26270A0
	|-Array.InternalArray__IndexOf<DropTableElement>
	|
	|-RVA: 0x2627280 Offset: 0x2627381 VA: 0x2627280
	|-Array.InternalArray__IndexOf<EffectDataTable>
	|
	|-RVA: 0x2627460 Offset: 0x2627561 VA: 0x2627460
	|-Array.InternalArray__IndexOf<EnemyPatrolPoints>
	|
	|-RVA: 0x2627630 Offset: 0x2627731 VA: 0x2627630
	|-Array.InternalArray__IndexOf<Coord>
	|
	|-RVA: 0x26277B0 Offset: 0x26278B1 VA: 0x26277B0
	|-Array.InternalArray__IndexOf<ErosionBrush.UndoStep>
	|
	|-RVA: 0x2627990 Offset: 0x2627A91 VA: 0x2627990
	|-Array.InternalArray__IndexOf<EventCheckId>
	|
	|-RVA: 0x2627B70 Offset: 0x2627C71 VA: 0x2627B70
	|-Array.InternalArray__IndexOf<EventFlagProgressData>
	|
	|-RVA: 0x2627D40 Offset: 0x2627E41 VA: 0x2627D40
	|-Array.InternalArray__IndexOf<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x2627F10 Offset: 0x2628011 VA: 0x2627F10
	|-Array.InternalArray__IndexOf<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x2628140 Offset: 0x2628241 VA: 0x2628140
	|-Array.InternalArray__IndexOf<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2628360 Offset: 0x2628461 VA: 0x2628360
	|-Array.InternalArray__IndexOf<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2628540 Offset: 0x2628641 VA: 0x2628540
	|-Array.InternalArray__IndexOf<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2628720 Offset: 0x2628821 VA: 0x2628720
	|-Array.InternalArray__IndexOf<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x26288F0 Offset: 0x26289F1 VA: 0x26288F0
	|-Array.InternalArray__IndexOf<FesNpcScoreData>
	|
	|-RVA: 0x2628AC0 Offset: 0x2628BC1 VA: 0x2628AC0
	|-Array.InternalArray__IndexOf<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x2628C90 Offset: 0x2628D91 VA: 0x2628C90
	|-Array.InternalArray__IndexOf<FieldItemSpawnDataTable>
	|
	|-RVA: 0x2628E90 Offset: 0x2628F91 VA: 0x2628E90
	|-Array.InternalArray__IndexOf<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x2629070 Offset: 0x2629171 VA: 0x2629070
	|-Array.InternalArray__IndexOf<FieldSceneData.Data>
	|
	|-RVA: 0x2629290 Offset: 0x2629391 VA: 0x2629290
	|-Array.InternalArray__IndexOf<FieldTreasureBoxItemData>
	|
	|-RVA: 0x2629460 Offset: 0x2629561 VA: 0x2629460
	|-Array.InternalArray__IndexOf<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x2629650 Offset: 0x2629751 VA: 0x2629650
	|-Array.InternalArray__IndexOf<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x2629830 Offset: 0x2629931 VA: 0x2629830
	|-Array.InternalArray__IndexOf<FocusObjectDataTable>
	|
	|-RVA: 0x2629A10 Offset: 0x2629B11 VA: 0x2629A10
	|-Array.InternalArray__IndexOf<FurnitureData>
	|
	|-RVA: 0x2629BF0 Offset: 0x2629CF1 VA: 0x2629BF0
	|-Array.InternalArray__IndexOf<GateDataTable>
	|
	|-RVA: 0x2629DC0 Offset: 0x2629EC1 VA: 0x2629DC0
	|-Array.InternalArray__IndexOf<GateStatusDataTable>
	|
	|-RVA: 0x2629FB0 Offset: 0x262A0B1 VA: 0x2629FB0
	|-Array.InternalArray__IndexOf<GimmickLayoutDataTable>
	|
	|-RVA: 0x262A170 Offset: 0x262A271 VA: 0x262A170
	|-Array.InternalArray__IndexOf<HitResult>
	|
	|-RVA: 0x262A360 Offset: 0x262A461 VA: 0x262A360
	|-Array.InternalArray__IndexOf<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x262A540 Offset: 0x262A641 VA: 0x262A540
	|-Array.InternalArray__IndexOf<FurnitureManager.SendPos>
	|
	|-RVA: 0x262A720 Offset: 0x262A821 VA: 0x262A720
	|-Array.InternalArray__IndexOf<ItemLevelData>
	|
	|-RVA: 0x262A8F0 Offset: 0x262A9F1 VA: 0x262A8F0
	|-Array.InternalArray__IndexOf<MapDatas.MapData>
	|
	|-RVA: 0x262AAD0 Offset: 0x262ABD1 VA: 0x262AAD0
	|-Array.InternalArray__IndexOf<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x262ACC0 Offset: 0x262ADC1 VA: 0x262ACC0
	|-Array.InternalArray__IndexOf<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x262AE90 Offset: 0x262AF91 VA: 0x262AE90
	|-Array.InternalArray__IndexOf<MineTypeDataTable>
	|
	|-RVA: 0x262B0A0 Offset: 0x262B1A1 VA: 0x262B0A0
	|-Array.InternalArray__IndexOf<MiningDataTable>
	|
	|-RVA: 0x262B270 Offset: 0x262B371 VA: 0x262B270
	|-Array.InternalArray__IndexOf<MiningPointSaveData>
	|
	|-RVA: 0x262B470 Offset: 0x262B571 VA: 0x262B470
	|-Array.InternalArray__IndexOf<CodePointIndexer.TableRange>
	|
	|-RVA: 0x262B650 Offset: 0x262B751 VA: 0x262B650
	|-Array.InternalArray__IndexOf<MonsterBehaviorDataTable>
	|
	|-RVA: 0x262B830 Offset: 0x262B931 VA: 0x262B830
	|-Array.InternalArray__IndexOf<MonsterDataTable>
	|
	|-RVA: 0x262BA40 Offset: 0x262BB41 VA: 0x262BA40
	|-Array.InternalArray__IndexOf<MonsterDropItemDataTable>
	|
	|-RVA: 0x262BC20 Offset: 0x262BD21 VA: 0x262BC20
	|-Array.InternalArray__IndexOf<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x262BE10 Offset: 0x262BF11 VA: 0x262BE10
	|-Array.InternalArray__IndexOf<MonsterHutSaveData>
	|
	|-RVA: 0x262C000 Offset: 0x262C101 VA: 0x262C000
	|-Array.InternalArray__IndexOf<MonsterUIData.Data>
	|
	|-RVA: 0x262C1F0 Offset: 0x262C2F1 VA: 0x262C1F0
	|-Array.InternalArray__IndexOf<MonsterYieldItemDataTable>
	|
	|-RVA: 0x262C3C0 Offset: 0x262C4C1 VA: 0x262C3C0
	|-Array.InternalArray__IndexOf<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x262C590 Offset: 0x262C691 VA: 0x262C590
	|-Array.InternalArray__IndexOf<NPCActionData>
	|
	|-RVA: 0x262C7A0 Offset: 0x262C8A1 VA: 0x262C7A0
	|-Array.InternalArray__IndexOf<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x262C970 Offset: 0x262CA71 VA: 0x262C970
	|-Array.InternalArray__IndexOf<NPCUIData.Data>
	|
	|-RVA: 0x262CB40 Offset: 0x262CC41 VA: 0x262CB40
	|-Array.InternalArray__IndexOf<NpcPlaceSchedule>
	|
	|-RVA: 0x262CD20 Offset: 0x262CE21 VA: 0x262CD20
	|-Array.InternalArray__IndexOf<OrderLotterySaveParameter>
	|
	|-RVA: 0x262CF00 Offset: 0x262D001 VA: 0x262CF00
	|-Array.InternalArray__IndexOf<OrderSaveData>
	|
	|-RVA: 0x262D0F0 Offset: 0x262D1F1 VA: 0x262D0F0
	|-Array.InternalArray__IndexOf<OrderSaveParameter>
	|
	|-RVA: 0x262D2D0 Offset: 0x262D3D1 VA: 0x262D2D0
	|-Array.InternalArray__IndexOf<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x262D4A0 Offset: 0x262D5A1 VA: 0x262D4A0
	|-Array.InternalArray__IndexOf<Parameter>
	|
	|-RVA: 0x262D6B0 Offset: 0x262D7B1 VA: 0x262D6B0
	|-Array.InternalArray__IndexOf<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x262D880 Offset: 0x262D981 VA: 0x262D880
	|-Array.InternalArray__IndexOf<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x262DA70 Offset: 0x262DB71 VA: 0x262DA70
	|-Array.InternalArray__IndexOf<ShopCatalogPage>
	|
	|-RVA: 0x283E7B0 Offset: 0x283E8B1 VA: 0x283E7B0
	|-Array.InternalArray__IndexOf<ShopNpcTalk>
	|
	|-RVA: 0x283E9A0 Offset: 0x283EAA1 VA: 0x283E9A0
	|-Array.InternalArray__IndexOf<SubtitleDataTable.Data>
	|
	|-RVA: 0x283EB80 Offset: 0x283EC81 VA: 0x283EB80
	|-Array.InternalArray__IndexOf<SubtitleDataTable.DataList>
	|
	|-RVA: 0x283ED50 Offset: 0x283EE51 VA: 0x283ED50
	|-Array.InternalArray__IndexOf<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x283EF30 Offset: 0x283F031 VA: 0x283EF30
	|-Array.InternalArray__IndexOf<AnimationWarping.Warp>
	|
	|-RVA: 0x283F120 Offset: 0x283F221 VA: 0x283F120
	|-Array.InternalArray__IndexOf<GrounderQuadruped.Foot>
	|
	|-RVA: 0x283F310 Offset: 0x283F411 VA: 0x283F310
	|-Array.InternalArray__IndexOf<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x283F500 Offset: 0x283F601 VA: 0x283F500
	|-Array.InternalArray__IndexOf<ProfilerFrame>
	|
	|-RVA: 0x283F6F0 Offset: 0x283F7F1 VA: 0x283F6F0
	|-Array.InternalArray__IndexOf<NumberControl.ValueRange>
	|
	|-RVA: 0x283F8C0 Offset: 0x283F9C1 VA: 0x283F8C0
	|-Array.InternalArray__IndexOf<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x283FAA0 Offset: 0x283FBA1 VA: 0x283FAA0
	|-Array.InternalArray__IndexOf<ResponsiveEnable.Entry>
	|
	|-RVA: 0x283FC80 Offset: 0x283FD81 VA: 0x283FC80
	|-Array.InternalArray__IndexOf<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x283FE50 Offset: 0x283FF51 VA: 0x283FE50
	|-Array.InternalArray__IndexOf<ResponsiveResize.Element>
	|
	|-RVA: 0x2840020 Offset: 0x2840121 VA: 0x2840020
	|-Array.InternalArray__IndexOf<Schedule>
	|
	|-RVA: 0x2840200 Offset: 0x2840301 VA: 0x2840200
	|-Array.InternalArray__IndexOf<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x28403D0 Offset: 0x28404D1 VA: 0x28403D0
	|-Array.InternalArray__IndexOf<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x28405B0 Offset: 0x28406B1 VA: 0x28405B0
	|-Array.InternalArray__IndexOf<SpeedData>
	|
	|-RVA: 0x2840780 Offset: 0x2840881 VA: 0x2840780
	|-Array.InternalArray__IndexOf<CurveSample>
	|
	|-RVA: 0x2840930 Offset: 0x2840A31 VA: 0x2840930
	|-Array.InternalArray__IndexOf<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x2840B00 Offset: 0x2840C01 VA: 0x2840B00
	|-Array.InternalArray__IndexOf<StringFormatData.FormatData>
	|
	|-RVA: 0x2840CD0 Offset: 0x2840DD1 VA: 0x2840CD0
	|-Array.InternalArray__IndexOf<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x2840E90 Offset: 0x2840F91 VA: 0x2840E90
	|-Array.InternalArray__IndexOf<ArraySegment<byte>>
	|
	|-RVA: 0x2841050 Offset: 0x2841151 VA: 0x2841050
	|-Array.InternalArray__IndexOf<ArraySegment<object>>
	|
	|-RVA: 0x2841210 Offset: 0x2841311 VA: 0x2841210
	|-Array.InternalArray__IndexOf<bool>
	|
	|-RVA: 0x2841390 Offset: 0x2841491 VA: 0x2841390
	|-Array.InternalArray__IndexOf<byte>
	|
	|-RVA: 0x2841510 Offset: 0x2841611 VA: 0x2841510
	|-Array.InternalArray__IndexOf<ByteEnum>
	|
	|-RVA: 0x28416C0 Offset: 0x28417C1 VA: 0x28416C0
	|-Array.InternalArray__IndexOf<char>
	|
	|-RVA: 0x2841840 Offset: 0x2841941 VA: 0x2841840
	|-Array.InternalArray__IndexOf<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x2841A10 Offset: 0x2841B11 VA: 0x2841A10
	|-Array.InternalArray__IndexOf<DictionaryEntry>
	|
	|-RVA: 0x2841BE0 Offset: 0x2841CE1 VA: 0x2841BE0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x2841DC0 Offset: 0x2841EC1 VA: 0x2841DC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x2841FA0 Offset: 0x28420A1 VA: 0x2841FA0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x2842190 Offset: 0x2842291 VA: 0x2842190
	|-Array.InternalArray__IndexOf<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x28423B0 Offset: 0x28424B1 VA: 0x28423B0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x28425A0 Offset: 0x28426A1 VA: 0x28425A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x2842780 Offset: 0x2842881 VA: 0x2842780
	|-Array.InternalArray__IndexOf<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x2842960 Offset: 0x2842A61 VA: 0x2842960
	|-Array.InternalArray__IndexOf<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x2842B70 Offset: 0x2842C71 VA: 0x2842B70
	|-Array.InternalArray__IndexOf<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x2842D50 Offset: 0x2842E51 VA: 0x2842D50
	|-Array.InternalArray__IndexOf<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x2842F60 Offset: 0x2843061 VA: 0x2842F60
	|-Array.InternalArray__IndexOf<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x2843150 Offset: 0x2843251 VA: 0x2843150
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x2843360 Offset: 0x2843461 VA: 0x2843360
	|-Array.InternalArray__IndexOf<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x2843540 Offset: 0x2843641 VA: 0x2843540
	|-Array.InternalArray__IndexOf<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x2843720 Offset: 0x2843821 VA: 0x2843720
	|-Array.InternalArray__IndexOf<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x2843900 Offset: 0x2843A01 VA: 0x2843900
	|-Array.InternalArray__IndexOf<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x2843AE0 Offset: 0x2843BE1 VA: 0x2843AE0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x2843CC0 Offset: 0x2843DC1 VA: 0x2843CC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x2843EA0 Offset: 0x2843FA1 VA: 0x2843EA0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x2844080 Offset: 0x2844181 VA: 0x2844080
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x28442A0 Offset: 0x28443A1 VA: 0x28442A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x2844480 Offset: 0x2844581 VA: 0x2844480
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x2844650 Offset: 0x2844751 VA: 0x2844650
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x2844870 Offset: 0x2844971 VA: 0x2844870
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x2844A50 Offset: 0x2844B51 VA: 0x2844A50
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x2844C20 Offset: 0x2844D21 VA: 0x2844C20
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x2844DF0 Offset: 0x2844EF1 VA: 0x2844DF0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x2844FC0 Offset: 0x28450C1 VA: 0x2844FC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x2845190 Offset: 0x2845291 VA: 0x2845190
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x2845370 Offset: 0x2845471 VA: 0x2845370
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x2845550 Offset: 0x2845651 VA: 0x2845550
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x2845760 Offset: 0x2845861 VA: 0x2845760
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x2845940 Offset: 0x2845A41 VA: 0x2845940
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x2845B20 Offset: 0x2845C21 VA: 0x2845B20
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x2845D00 Offset: 0x2845E01 VA: 0x2845D00
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x2845F10 Offset: 0x2846011 VA: 0x2845F10
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x2846120 Offset: 0x2846221 VA: 0x2846120
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x2846310 Offset: 0x2846411 VA: 0x2846310
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x28464E0 Offset: 0x28465E1 VA: 0x28464E0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x28466C0 Offset: 0x28467C1 VA: 0x28466C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x2846890 Offset: 0x2846991 VA: 0x2846890
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2846A60 Offset: 0x2846B61 VA: 0x2846A60
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x2846C40 Offset: 0x2846D41 VA: 0x2846C40
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x2846E10 Offset: 0x2846F11 VA: 0x2846E10
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x2846FF0 Offset: 0x28470F1 VA: 0x2846FF0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x28471D0 Offset: 0x28472D1 VA: 0x28471D0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x28473B0 Offset: 0x28474B1 VA: 0x28473B0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x2847590 Offset: 0x2847691 VA: 0x2847590
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x2847770 Offset: 0x2847871 VA: 0x2847770
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x2847950 Offset: 0x2847A51 VA: 0x2847950
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x2847B40 Offset: 0x2847C41 VA: 0x2847B40
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x2847D30 Offset: 0x2847E31 VA: 0x2847D30
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x2847F10 Offset: 0x2848011 VA: 0x2847F10
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x2848100 Offset: 0x2848201 VA: 0x2848100
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x28482E0 Offset: 0x28483E1 VA: 0x28482E0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x28484D0 Offset: 0x28485D1 VA: 0x28484D0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x28486C0 Offset: 0x28487C1 VA: 0x28486C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x28488A0 Offset: 0x28489A1 VA: 0x28488A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x2848AD0 Offset: 0x2848BD1 VA: 0x2848AD0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x2848CC0 Offset: 0x2848DC1 VA: 0x2848CC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x2848EA0 Offset: 0x2848FA1 VA: 0x2848EA0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x2849090 Offset: 0x2849191 VA: 0x2849090
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x2849280 Offset: 0x2849381 VA: 0x2849280
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x2849460 Offset: 0x2849561 VA: 0x2849460
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x2849640 Offset: 0x2849741 VA: 0x2849640
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x2849820 Offset: 0x2849921 VA: 0x2849820
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x2849A00 Offset: 0x2849B01 VA: 0x2849A00
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x2849BF0 Offset: 0x2849CF1 VA: 0x2849BF0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x2849DD0 Offset: 0x2849ED1 VA: 0x2849DD0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x2849FC0 Offset: 0x284A0C1 VA: 0x2849FC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x284A1E0 Offset: 0x284A2E1 VA: 0x284A1E0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x284A3D0 Offset: 0x284A4D1 VA: 0x284A3D0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x284A5B0 Offset: 0x284A6B1 VA: 0x284A5B0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x284A790 Offset: 0x284A891 VA: 0x284A790
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x284A9A0 Offset: 0x284AAA1 VA: 0x284A9A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x284AB80 Offset: 0x284AC81 VA: 0x284AB80
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x284AD90 Offset: 0x284AE91 VA: 0x284AD90
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x284AF80 Offset: 0x284B081 VA: 0x284AF80
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x284B190 Offset: 0x284B291 VA: 0x284B190
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x284B370 Offset: 0x284B471 VA: 0x284B370
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x284B550 Offset: 0x284B651 VA: 0x284B550
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x284B730 Offset: 0x284B831 VA: 0x284B730
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x284B910 Offset: 0x284BA11 VA: 0x284B910
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x284BAF0 Offset: 0x284BBF1 VA: 0x284BAF0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x284BCD0 Offset: 0x284BDD1 VA: 0x284BCD0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x284BEB0 Offset: 0x284BFB1 VA: 0x284BEB0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x284C090 Offset: 0x284C191 VA: 0x284C090
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x284C270 Offset: 0x284C371 VA: 0x284C270
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x284C450 Offset: 0x284C551 VA: 0x284C450
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x284C630 Offset: 0x284C731 VA: 0x284C630
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x284C810 Offset: 0x284C911 VA: 0x284C810
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x284CA00 Offset: 0x284CB01 VA: 0x284CA00
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x284CBF0 Offset: 0x284CCF1 VA: 0x284CBF0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x284CDD0 Offset: 0x284CED1 VA: 0x284CDD0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x284CFC0 Offset: 0x284D0C1 VA: 0x284CFC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x284D1A0 Offset: 0x284D2A1 VA: 0x284D1A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x284D390 Offset: 0x284D491 VA: 0x284D390
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x284D580 Offset: 0x284D681 VA: 0x284D580
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x284D760 Offset: 0x284D861 VA: 0x284D760
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x284D990 Offset: 0x284DA91 VA: 0x284D990
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x284DB80 Offset: 0x284DC81 VA: 0x284DB80
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x284DD60 Offset: 0x284DE61 VA: 0x284DD60
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x284DF50 Offset: 0x284E051 VA: 0x284DF50
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x284E140 Offset: 0x284E241 VA: 0x284E140
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x284E320 Offset: 0x284E421 VA: 0x284E320
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x284E500 Offset: 0x284E601 VA: 0x284E500
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x284E6E0 Offset: 0x284E7E1 VA: 0x284E6E0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x284E8C0 Offset: 0x284E9C1 VA: 0x284E8C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x284EAB0 Offset: 0x284EBB1 VA: 0x284EAB0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x284EC90 Offset: 0x284ED91 VA: 0x284EC90
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x284EE70 Offset: 0x284EF71 VA: 0x284EE70
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x284F050 Offset: 0x284F151 VA: 0x284F050
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x284F230 Offset: 0x284F331 VA: 0x284F230
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x284F410 Offset: 0x284F511 VA: 0x284F410
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x284F5F0 Offset: 0x284F6F1 VA: 0x284F5F0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x284F7D0 Offset: 0x284F8D1 VA: 0x284F7D0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x284F9B0 Offset: 0x284FAB1 VA: 0x284F9B0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x284FBA0 Offset: 0x284FCA1 VA: 0x284FBA0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x284FD90 Offset: 0x284FE91 VA: 0x284FD90
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x284FF80 Offset: 0x2850081 VA: 0x284FF80
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x2850160 Offset: 0x2850261 VA: 0x2850160
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x2850340 Offset: 0x2850441 VA: 0x2850340
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x2850520 Offset: 0x2850621 VA: 0x2850520
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x2850710 Offset: 0x2850811 VA: 0x2850710
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x2850900 Offset: 0x2850A01 VA: 0x2850900
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x2850AE0 Offset: 0x2850BE1 VA: 0x2850AE0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x2850D00 Offset: 0x2850E01 VA: 0x2850D00
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x2850EE0 Offset: 0x2850FE1 VA: 0x2850EE0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x28510C0 Offset: 0x28511C1 VA: 0x28510C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x28512A0 Offset: 0x28513A1 VA: 0x28512A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x2851480 Offset: 0x2851581 VA: 0x2851480
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x2851660 Offset: 0x2851761 VA: 0x2851660
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2851850 Offset: 0x2851951 VA: 0x2851850
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2851A40 Offset: 0x2851B41 VA: 0x2851A40
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x2851C20 Offset: 0x2851D21 VA: 0x2851C20
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x2851E00 Offset: 0x2851F01 VA: 0x2851E00
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x2851FE0 Offset: 0x28520E1 VA: 0x2851FE0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x28521C0 Offset: 0x28522C1 VA: 0x28521C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x28523A0 Offset: 0x28524A1 VA: 0x28523A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x2852580 Offset: 0x2852681 VA: 0x2852580
	|-Array.InternalArray__IndexOf<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x2852760 Offset: 0x2852861 VA: 0x2852760
	|-Array.InternalArray__IndexOf<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x2852940 Offset: 0x2852A41 VA: 0x2852940
	|-Array.InternalArray__IndexOf<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x2852B80 Offset: 0x2852C81 VA: 0x2852B80
	|-Array.InternalArray__IndexOf<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x2852D60 Offset: 0x2852E61 VA: 0x2852D60
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x2852F40 Offset: 0x2853041 VA: 0x2852F40
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x2853110 Offset: 0x2853211 VA: 0x2853110
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x28532E0 Offset: 0x28533E1 VA: 0x28532E0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x28534C0 Offset: 0x28535C1 VA: 0x28534C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x28536A0 Offset: 0x28537A1 VA: 0x28536A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x2853880 Offset: 0x2853981 VA: 0x2853880
	|-Array.InternalArray__IndexOf<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x2853AA0 Offset: 0x2853BA1 VA: 0x2853AA0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x2853CB0 Offset: 0x2853DB1 VA: 0x2853CB0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x2853EB0 Offset: 0x2853FB1 VA: 0x2853EB0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x2854090 Offset: 0x2854191 VA: 0x2854090
	|-Array.InternalArray__IndexOf<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x2854270 Offset: 0x2854371 VA: 0x2854270
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x2854460 Offset: 0x2854561 VA: 0x2854460
	|-Array.InternalArray__IndexOf<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x2854650 Offset: 0x2854751 VA: 0x2854650
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x2854830 Offset: 0x2854931 VA: 0x2854830
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x2854A10 Offset: 0x2854B11 VA: 0x2854A10
	|-Array.InternalArray__IndexOf<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2854BF0 Offset: 0x2854CF1 VA: 0x2854BF0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x2854DD0 Offset: 0x2854ED1 VA: 0x2854DD0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x2854FC0 Offset: 0x28550C1 VA: 0x2854FC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x28551B0 Offset: 0x28552B1 VA: 0x28551B0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x2855390 Offset: 0x2855491 VA: 0x2855390
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x28555B0 Offset: 0x28556B1 VA: 0x28555B0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x2855790 Offset: 0x2855891 VA: 0x2855790
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x2855970 Offset: 0x2855A71 VA: 0x2855970
	|-Array.InternalArray__IndexOf<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x2855B50 Offset: 0x2855C51 VA: 0x2855B50
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x2855D30 Offset: 0x2855E31 VA: 0x2855D30
	|-Array.InternalArray__IndexOf<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x2855F10 Offset: 0x2856011 VA: 0x2855F10
	|-Array.InternalArray__IndexOf<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x28560F0 Offset: 0x28561F1 VA: 0x28560F0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x28562D0 Offset: 0x28563D1 VA: 0x28562D0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x28564B0 Offset: 0x28565B1 VA: 0x28564B0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x2856690 Offset: 0x2856791 VA: 0x2856690
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x2856870 Offset: 0x2856971 VA: 0x2856870
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x2856A50 Offset: 0x2856B51 VA: 0x2856A50
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x2856C30 Offset: 0x2856D31 VA: 0x2856C30
	|-Array.InternalArray__IndexOf<HashSet.Slot<int>>
	|
	|-RVA: 0x2856E10 Offset: 0x2856F11 VA: 0x2856E10
	|-Array.InternalArray__IndexOf<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x2856FF0 Offset: 0x28570F1 VA: 0x2856FF0
	|-Array.InternalArray__IndexOf<HashSet.Slot<object>>
	|
	|-RVA: 0x28571C0 Offset: 0x28572C1 VA: 0x28571C0
	|-Array.InternalArray__IndexOf<HashSet.Slot<uint>>
	|
	|-RVA: 0x28573A0 Offset: 0x28574A1 VA: 0x28573A0
	|-Array.InternalArray__IndexOf<HashSet.Slot<Edge>>
	|
	|-RVA: 0x2857570 Offset: 0x2857671 VA: 0x2857570
	|-Array.InternalArray__IndexOf<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x2857750 Offset: 0x2857851 VA: 0x2857750
	|-Array.InternalArray__IndexOf<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x2857930 Offset: 0x2857A31 VA: 0x2857930
	|-Array.InternalArray__IndexOf<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x2857B00 Offset: 0x2857C01 VA: 0x2857B00
	|-Array.InternalArray__IndexOf<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x2857CE0 Offset: 0x2857DE1 VA: 0x2857CE0
	|-Array.InternalArray__IndexOf<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x2857EF0 Offset: 0x2857FF1 VA: 0x2857EF0
	|-Array.InternalArray__IndexOf<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x28580D0 Offset: 0x28581D1 VA: 0x28580D0
	|-Array.InternalArray__IndexOf<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x28582B0 Offset: 0x28583B1 VA: 0x28582B0
	|-Array.InternalArray__IndexOf<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x2858490 Offset: 0x2858591 VA: 0x2858490
	|-Array.InternalArray__IndexOf<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x2858680 Offset: 0x2858781 VA: 0x2858680
	|-Array.InternalArray__IndexOf<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x2858860 Offset: 0x2858961 VA: 0x2858860
	|-Array.InternalArray__IndexOf<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x2858A50 Offset: 0x2858B51 VA: 0x2858A50
	|-Array.InternalArray__IndexOf<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x2858C40 Offset: 0x2858D41 VA: 0x2858C40
	|-Array.InternalArray__IndexOf<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x2858E50 Offset: 0x2858F51 VA: 0x2858E50
	|-Array.InternalArray__IndexOf<KeyValuePair<bool, object>>
	|
	|-RVA: 0x2859020 Offset: 0x2859121 VA: 0x2859020
	|-Array.InternalArray__IndexOf<KeyValuePair<byte, object>>
	|
	|-RVA: 0x28591F0 Offset: 0x28592F1 VA: 0x28591F0
	|-Array.InternalArray__IndexOf<KeyValuePair<char, object>>
	|
	|-RVA: 0x28593C0 Offset: 0x28594C1 VA: 0x28593C0
	|-Array.InternalArray__IndexOf<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2859590 Offset: 0x2859691 VA: 0x2859590
	|-Array.InternalArray__IndexOf<KeyValuePair<double, object>>
	|
	|-RVA: 0x2859760 Offset: 0x2859861 VA: 0x2859760
	|-Array.InternalArray__IndexOf<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x2859940 Offset: 0x2859A41 VA: 0x2859940
	|-Array.InternalArray__IndexOf<KeyValuePair<short, object>>
	|
	|-RVA: 0x2859B10 Offset: 0x2859C11 VA: 0x2859B10
	|-Array.InternalArray__IndexOf<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x2859D30 Offset: 0x2859E31 VA: 0x2859D30
	|-Array.InternalArray__IndexOf<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x2859F10 Offset: 0x285A011 VA: 0x2859F10
	|-Array.InternalArray__IndexOf<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x285A0E0 Offset: 0x285A1E1 VA: 0x285A0E0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x285A300 Offset: 0x285A401 VA: 0x285A300
	|-Array.InternalArray__IndexOf<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x285A4E0 Offset: 0x285A5E1 VA: 0x285A4E0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, bool>>
	|
	|-RVA: 0x285A6B0 Offset: 0x285A7B1 VA: 0x285A6B0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, char>>
	|
	|-RVA: 0x285A880 Offset: 0x285A981 VA: 0x285A880
	|-Array.InternalArray__IndexOf<KeyValuePair<int, int>>
	|
	|-RVA: 0x285AA50 Offset: 0x285AB51 VA: 0x285AA50
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x285AC20 Offset: 0x285AD21 VA: 0x285AC20
	|-Array.InternalArray__IndexOf<KeyValuePair<int, long>>
	|
	|-RVA: 0x285ADF0 Offset: 0x285AEF1 VA: 0x285ADF0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, object>>
	|
	|-RVA: 0x285AFC0 Offset: 0x285B0C1 VA: 0x285AFC0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x285B1D0 Offset: 0x285B2D1 VA: 0x285B1D0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x285B3B0 Offset: 0x285B4B1 VA: 0x285B3B0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x285B590 Offset: 0x285B691 VA: 0x285B590
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x285B760 Offset: 0x285B861 VA: 0x285B760
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x285B970 Offset: 0x285BA71 VA: 0x285B970
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x285BB80 Offset: 0x285BC81 VA: 0x285BB80
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x285BD60 Offset: 0x285BE61 VA: 0x285BD60
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x285BF30 Offset: 0x285C031 VA: 0x285BF30
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x285C110 Offset: 0x285C211 VA: 0x285C110
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x285C2E0 Offset: 0x285C3E1 VA: 0x285C2E0
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x285C4B0 Offset: 0x285C5B1 VA: 0x285C4B0
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x285C680 Offset: 0x285C781 VA: 0x285C680
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x285C850 Offset: 0x285C951 VA: 0x285C850
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x285CA30 Offset: 0x285CB31 VA: 0x285CA30
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x285CC10 Offset: 0x285CD11 VA: 0x285CC10
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x285CDE0 Offset: 0x285CEE1 VA: 0x285CDE0
	|-Array.InternalArray__IndexOf<KeyValuePair<long, object>>
	|
	|-RVA: 0x285CFB0 Offset: 0x285D0B1 VA: 0x285CFB0
	|-Array.InternalArray__IndexOf<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x285D190 Offset: 0x285D291 VA: 0x285D190
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x285D360 Offset: 0x285D461 VA: 0x285D360
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x285D550 Offset: 0x285D651 VA: 0x285D550
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x298C2F0 Offset: 0x298C3F1 VA: 0x298C2F0
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x298C4C0 Offset: 0x298C5C1 VA: 0x298C4C0
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x298C6A0 Offset: 0x298C7A1 VA: 0x298C6A0
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x298C880 Offset: 0x298C981 VA: 0x298C880
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x298CA60 Offset: 0x298CB61 VA: 0x298CA60
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x298CC50 Offset: 0x298CD51 VA: 0x298CC50
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x298CE20 Offset: 0x298CF21 VA: 0x298CE20
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x298D040 Offset: 0x298D141 VA: 0x298D040
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x298D220 Offset: 0x298D321 VA: 0x298D220
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x298D400 Offset: 0x298D501 VA: 0x298D400
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x298D5E0 Offset: 0x298D6E1 VA: 0x298D5E0
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x298D7C0 Offset: 0x298D8C1 VA: 0x298D7C0
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x298D9A0 Offset: 0x298DAA1 VA: 0x298D9A0
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x298DB80 Offset: 0x298DC81 VA: 0x298DB80
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x298DD60 Offset: 0x298DE61 VA: 0x298DD60
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x298DF40 Offset: 0x298E041 VA: 0x298DF40
	|-Array.InternalArray__IndexOf<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x298E120 Offset: 0x298E221 VA: 0x298E120
	|-Array.InternalArray__IndexOf<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x298E2F0 Offset: 0x298E3F1 VA: 0x298E2F0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x298E4D0 Offset: 0x298E5D1 VA: 0x298E4D0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x298E6E0 Offset: 0x298E7E1 VA: 0x298E6E0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x298E8C0 Offset: 0x298E9C1 VA: 0x298E8C0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x298EAA0 Offset: 0x298EBA1 VA: 0x298EAA0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x298EC80 Offset: 0x298ED81 VA: 0x298EC80
	|-Array.InternalArray__IndexOf<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x298EE70 Offset: 0x298EF71 VA: 0x298EE70
	|-Array.InternalArray__IndexOf<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x298F050 Offset: 0x298F151 VA: 0x298F050
	|-Array.InternalArray__IndexOf<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x298F240 Offset: 0x298F341 VA: 0x298F240
	|-Array.InternalArray__IndexOf<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x298F430 Offset: 0x298F531 VA: 0x298F430
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x298F640 Offset: 0x298F741 VA: 0x298F640
	|-Array.InternalArray__IndexOf<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x298F820 Offset: 0x298F921 VA: 0x298F820
	|-Array.InternalArray__IndexOf<KeyValuePair<object, bool>>
	|
	|-RVA: 0x298F9F0 Offset: 0x298FAF1 VA: 0x298F9F0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, byte>>
	|
	|-RVA: 0x298FBC0 Offset: 0x298FCC1 VA: 0x298FBC0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, char>>
	|
	|-RVA: 0x298FD90 Offset: 0x298FE91 VA: 0x298FD90
	|-Array.InternalArray__IndexOf<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x298FF60 Offset: 0x2990061 VA: 0x298FF60
	|-Array.InternalArray__IndexOf<KeyValuePair<object, double>>
	|
	|-RVA: 0x2990130 Offset: 0x2990231 VA: 0x2990130
	|-Array.InternalArray__IndexOf<KeyValuePair<object, short>>
	|
	|-RVA: 0x2990300 Offset: 0x2990401 VA: 0x2990300
	|-Array.InternalArray__IndexOf<KeyValuePair<object, int>>
	|
	|-RVA: 0x29904D0 Offset: 0x29905D1 VA: 0x29904D0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x29906A0 Offset: 0x29907A1 VA: 0x29906A0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, long>>
	|
	|-RVA: 0x2990870 Offset: 0x2990971 VA: 0x2990870
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x2990A50 Offset: 0x2990B51 VA: 0x2990A50
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x2990C20 Offset: 0x2990D21 VA: 0x2990C20
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x2990E10 Offset: 0x2990F11 VA: 0x2990E10
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x2991000 Offset: 0x2991101 VA: 0x2991000
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x29911D0 Offset: 0x29912D1 VA: 0x29911D0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x29913B0 Offset: 0x29914B1 VA: 0x29913B0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x2991590 Offset: 0x2991691 VA: 0x2991590
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x2991770 Offset: 0x2991871 VA: 0x2991770
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x2991960 Offset: 0x2991A61 VA: 0x2991960
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x2991B30 Offset: 0x2991C31 VA: 0x2991B30
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x2991D50 Offset: 0x2991E51 VA: 0x2991D50
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x2991F30 Offset: 0x2992031 VA: 0x2991F30
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x2992110 Offset: 0x2992211 VA: 0x2992110
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x29922F0 Offset: 0x29923F1 VA: 0x29922F0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x29924D0 Offset: 0x29925D1 VA: 0x29924D0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x29926B0 Offset: 0x29927B1 VA: 0x29926B0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x2992890 Offset: 0x2992991 VA: 0x2992890
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x2992A70 Offset: 0x2992B71 VA: 0x2992A70
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x2992C50 Offset: 0x2992D51 VA: 0x2992C50
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x2992E30 Offset: 0x2992F31 VA: 0x2992E30
	|-Array.InternalArray__IndexOf<KeyValuePair<object, object>>
	|
	|-RVA: 0x2993000 Offset: 0x2993101 VA: 0x2993000
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x29931E0 Offset: 0x29932E1 VA: 0x29931E0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x29933C0 Offset: 0x29934C1 VA: 0x29933C0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x2993590 Offset: 0x2993691 VA: 0x2993590
	|-Array.InternalArray__IndexOf<KeyValuePair<object, float>>
	|
	|-RVA: 0x2993760 Offset: 0x2993861 VA: 0x2993760
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x2993930 Offset: 0x2993A31 VA: 0x2993930
	|-Array.InternalArray__IndexOf<KeyValuePair<object, uint>>
	|
	|-RVA: 0x2993B00 Offset: 0x2993C01 VA: 0x2993B00
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x2993CD0 Offset: 0x2993DD1 VA: 0x2993CD0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x2993EC0 Offset: 0x2993FC1 VA: 0x2993EC0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x29940A0 Offset: 0x29941A1 VA: 0x29940A0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x2994280 Offset: 0x2994381 VA: 0x2994280
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x2994450 Offset: 0x2994551 VA: 0x2994450
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Color>>
	|
	|-RVA: 0x2994630 Offset: 0x2994731 VA: 0x2994630
	|-Array.InternalArray__IndexOf<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x2994800 Offset: 0x2994901 VA: 0x2994800
	|-Array.InternalArray__IndexOf<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x29949E0 Offset: 0x2994AE1 VA: 0x29949E0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x2994BD0 Offset: 0x2994CD1 VA: 0x2994BD0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x2994DA0 Offset: 0x2994EA1 VA: 0x2994DA0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x2994FC0 Offset: 0x29950C1 VA: 0x2994FC0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x29951A0 Offset: 0x29952A1 VA: 0x29951A0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x2995380 Offset: 0x2995481 VA: 0x2995380
	|-Array.InternalArray__IndexOf<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x2995550 Offset: 0x2995651 VA: 0x2995550
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x2995730 Offset: 0x2995831 VA: 0x2995730
	|-Array.InternalArray__IndexOf<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x2995910 Offset: 0x2995A11 VA: 0x2995910
	|-Array.InternalArray__IndexOf<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2995AF0 Offset: 0x2995BF1 VA: 0x2995AF0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2995CD0 Offset: 0x2995DD1 VA: 0x2995CD0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x2995EA0 Offset: 0x2995FA1 VA: 0x2995EA0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x2996070 Offset: 0x2996171 VA: 0x2996070
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x2996250 Offset: 0x2996351 VA: 0x2996250
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x2996430 Offset: 0x2996531 VA: 0x2996430
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x2996610 Offset: 0x2996711 VA: 0x2996610
	|-Array.InternalArray__IndexOf<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x29967F0 Offset: 0x29968F1 VA: 0x29967F0
	|-Array.InternalArray__IndexOf<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x29969C0 Offset: 0x2996AC1 VA: 0x29969C0
	|-Array.InternalArray__IndexOf<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x2996B90 Offset: 0x2996C91 VA: 0x2996B90
	|-Array.InternalArray__IndexOf<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x2996DC0 Offset: 0x2996EC1 VA: 0x2996DC0
	|-Array.InternalArray__IndexOf<KeyValuePair<float, object>>
	|
	|-RVA: 0x2996F90 Offset: 0x2997091 VA: 0x2996F90
	|-Array.InternalArray__IndexOf<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x2997160 Offset: 0x2997261 VA: 0x2997160
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, int>>
	|
	|-RVA: 0x2997330 Offset: 0x2997431 VA: 0x2997330
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x2997500 Offset: 0x2997601 VA: 0x2997500
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, object>>
	|
	|-RVA: 0x29976D0 Offset: 0x29977D1 VA: 0x29976D0
	|-Array.InternalArray__IndexOf<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x29978A0 Offset: 0x29979A1 VA: 0x29978A0
	|-Array.InternalArray__IndexOf<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x2997A80 Offset: 0x2997B81 VA: 0x2997A80
	|-Array.InternalArray__IndexOf<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x2997C90 Offset: 0x2997D91 VA: 0x2997C90
	|-Array.InternalArray__IndexOf<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x2997EA0 Offset: 0x2997FA1 VA: 0x2997EA0
	|-Array.InternalArray__IndexOf<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x2998090 Offset: 0x2998191 VA: 0x2998090
	|-Array.InternalArray__IndexOf<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x2998270 Offset: 0x2998371 VA: 0x2998270
	|-Array.InternalArray__IndexOf<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x2998440 Offset: 0x2998541 VA: 0x2998440
	|-Array.InternalArray__IndexOf<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x2998620 Offset: 0x2998721 VA: 0x2998620
	|-Array.InternalArray__IndexOf<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x2998800 Offset: 0x2998901 VA: 0x2998800
	|-Array.InternalArray__IndexOf<KeyValuePair<Color, object>>
	|
	|-RVA: 0x29989E0 Offset: 0x2998AE1 VA: 0x29989E0
	|-Array.InternalArray__IndexOf<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x2998BB0 Offset: 0x2998CB1 VA: 0x2998BB0
	|-Array.InternalArray__IndexOf<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2998D80 Offset: 0x2998E81 VA: 0x2998D80
	|-Array.InternalArray__IndexOf<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x2998F50 Offset: 0x2999051 VA: 0x2998F50
	|-Array.InternalArray__IndexOf<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x2999130 Offset: 0x2999231 VA: 0x2999130
	|-Array.InternalArray__IndexOf<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x2999320 Offset: 0x2999421 VA: 0x2999320
	|-Array.InternalArray__IndexOf<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x29994F0 Offset: 0x29995F1 VA: 0x29994F0
	|-Array.InternalArray__IndexOf<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x2999710 Offset: 0x2999811 VA: 0x2999710
	|-Array.InternalArray__IndexOf<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x29998F0 Offset: 0x29999F1 VA: 0x29998F0
	|-Array.InternalArray__IndexOf<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x2999AD0 Offset: 0x2999BD1 VA: 0x2999AD0
	|-Array.InternalArray__IndexOf<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x2999CA0 Offset: 0x2999DA1 VA: 0x2999CA0
	|-Array.InternalArray__IndexOf<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x2999E80 Offset: 0x2999F81 VA: 0x2999E80
	|-Array.InternalArray__IndexOf<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x299A060 Offset: 0x299A161 VA: 0x299A060
	|-Array.InternalArray__IndexOf<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x299A240 Offset: 0x299A341 VA: 0x299A240
	|-Array.InternalArray__IndexOf<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x299A410 Offset: 0x299A511 VA: 0x299A410
	|-Array.InternalArray__IndexOf<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x299A5E0 Offset: 0x299A6E1 VA: 0x299A5E0
	|-Array.InternalArray__IndexOf<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x299A7B0 Offset: 0x299A8B1 VA: 0x299A7B0
	|-Array.InternalArray__IndexOf<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x299A990 Offset: 0x299AA91 VA: 0x299A990
	|-Array.InternalArray__IndexOf<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x299AB70 Offset: 0x299AC71 VA: 0x299AB70
	|-Array.InternalArray__IndexOf<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x299AD50 Offset: 0x299AE51 VA: 0x299AD50
	|-Array.InternalArray__IndexOf<Hashtable.bucket>
	|
	|-RVA: 0x299AF30 Offset: 0x299B031 VA: 0x299AF30
	|-Array.InternalArray__IndexOf<DateTime>
	|
	|-RVA: 0x299B0B0 Offset: 0x299B1B1 VA: 0x299B0B0
	|-Array.InternalArray__IndexOf<DateTimeOffset>
	|
	|-RVA: 0x299B240 Offset: 0x299B341 VA: 0x299B240
	|-Array.InternalArray__IndexOf<Decimal>
	|
	|-RVA: 0x299B3D0 Offset: 0x299B4D1 VA: 0x299B3D0
	|-Array.InternalArray__IndexOf<double>
	|
	|-RVA: 0x299B550 Offset: 0x299B651 VA: 0x299B550
	|-Array.InternalArray__IndexOf<InternalCodePageDataItem>
	|
	|-RVA: 0x299B720 Offset: 0x299B821 VA: 0x299B720
	|-Array.InternalArray__IndexOf<InternalEncodingDataItem>
	|
	|-RVA: 0x299B8F0 Offset: 0x299B9F1 VA: 0x299B8F0
	|-Array.InternalArray__IndexOf<Guid>
	|
	|-RVA: 0x299BA80 Offset: 0x299BB81 VA: 0x299BA80
	|-Array.InternalArray__IndexOf<short>
	|
	|-RVA: 0x299BC00 Offset: 0x299BD01 VA: 0x299BC00
	|-Array.InternalArray__IndexOf<int>
	|
	|-RVA: 0x299BD80 Offset: 0x299BE81 VA: 0x299BD80
	|-Array.InternalArray__IndexOf<Int32Enum>
	|
	|-RVA: 0x299BF30 Offset: 0x299C031 VA: 0x299BF30
	|-Array.InternalArray__IndexOf<long>
	|
	|-RVA: 0x299C0B0 Offset: 0x299C1B1 VA: 0x299C0B0
	|-Array.InternalArray__IndexOf<IntPtr>
	|
	|-RVA: 0x299C230 Offset: 0x299C331 VA: 0x299C230
	|-Array.InternalArray__IndexOf<InterpretedFrameInfo>
	|
	|-RVA: 0x299C400 Offset: 0x299C501 VA: 0x299C400
	|-Array.InternalArray__IndexOf<LocalDefinition>
	|
	|-RVA: 0x299C590 Offset: 0x299C691 VA: 0x299C590
	|-Array.InternalArray__IndexOf<RuntimeLabel>
	|
	|-RVA: 0x299C770 Offset: 0x299C871 VA: 0x299C770
	|-Array.InternalArray__IndexOf<Set.Slot<int>>
	|
	|-RVA: 0x299C950 Offset: 0x299CA51 VA: 0x299C950
	|-Array.InternalArray__IndexOf<Set.Slot<object>>
	|
	|-RVA: 0x299CB30 Offset: 0x299CC31 VA: 0x299CB30
	|-Array.InternalArray__IndexOf<Memory<object>>
	|
	|-RVA: 0x299CCF0 Offset: 0x299CDF1 VA: 0x299CCF0
	|-Array.InternalArray__IndexOf<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x299CEC0 Offset: 0x299CFC1 VA: 0x299CEC0
	|-Array.InternalArray__IndexOf<HeaderVariantInfo>
	|
	|-RVA: 0x299D090 Offset: 0x299D191 VA: 0x299D090
	|-Array.InternalArray__IndexOf<Socket.WSABUF>
	|
	|-RVA: 0x299D260 Offset: 0x299D361 VA: 0x299D260
	|-Array.InternalArray__IndexOf<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x299D4E0 Offset: 0x299D5E1 VA: 0x299D4E0
	|-Array.InternalArray__IndexOf<Nullable<Int32Enum>>
	|
	|-RVA: 0x299D700 Offset: 0x299D801 VA: 0x299D700
	|-Array.InternalArray__IndexOf<Nullable<Bounds>>
	|
	|-RVA: 0x299D980 Offset: 0x299DA81 VA: 0x299D980
	|-Array.InternalArray__IndexOf<Nullable<BoundsInt>>
	|
	|-RVA: 0x299DC00 Offset: 0x299DD01 VA: 0x299DC00
	|-Array.InternalArray__IndexOf<Nullable<Color32>>
	|
	|-RVA: 0x299DE20 Offset: 0x299DF21 VA: 0x299DE20
	|-Array.InternalArray__IndexOf<Nullable<Color>>
	|
	|-RVA: 0x299E070 Offset: 0x299E171 VA: 0x299E070
	|-Array.InternalArray__IndexOf<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x299E2B0 Offset: 0x299E3B1 VA: 0x299E2B0
	|-Array.InternalArray__IndexOf<Nullable<GradientColorKey>>
	|
	|-RVA: 0x299E500 Offset: 0x299E601 VA: 0x299E500
	|-Array.InternalArray__IndexOf<Nullable<Keyframe>>
	|
	|-RVA: 0x299E750 Offset: 0x299E851 VA: 0x299E750
	|-Array.InternalArray__IndexOf<Nullable<LayerMask>>
	|
	|-RVA: 0x299E970 Offset: 0x299EA71 VA: 0x299E970
	|-Array.InternalArray__IndexOf<Nullable<Matrix4x4>>
	|
	|-RVA: 0x299EC50 Offset: 0x299ED51 VA: 0x299EC50
	|-Array.InternalArray__IndexOf<Nullable<Quaternion>>
	|
	|-RVA: 0x299EEA0 Offset: 0x299EFA1 VA: 0x299EEA0
	|-Array.InternalArray__IndexOf<Nullable<RangeInt>>
	|
	|-RVA: 0x299F0E0 Offset: 0x299F1E1 VA: 0x299F0E0
	|-Array.InternalArray__IndexOf<Nullable<Rect>>
	|
	|-RVA: 0x299F330 Offset: 0x299F431 VA: 0x299F330
	|-Array.InternalArray__IndexOf<Nullable<RectInt>>
	|
	|-RVA: 0x299F580 Offset: 0x299F681 VA: 0x299F580
	|-Array.InternalArray__IndexOf<Nullable<Vector2>>
	|
	|-RVA: 0x299F7C0 Offset: 0x299F8C1 VA: 0x299F7C0
	|-Array.InternalArray__IndexOf<Nullable<Vector2Int>>
	|
	|-RVA: 0x299FA00 Offset: 0x299FB01 VA: 0x299FA00
	|-Array.InternalArray__IndexOf<Nullable<Vector3>>
	|
	|-RVA: 0x299FC20 Offset: 0x299FD21 VA: 0x299FC20
	|-Array.InternalArray__IndexOf<Nullable<Vector3Int>>
	|
	|-RVA: 0x299FE40 Offset: 0x299FF41 VA: 0x299FE40
	|-Array.InternalArray__IndexOf<Nullable<Vector4>>
	|
	|-RVA: 0x29A0090 Offset: 0x29A0191 VA: 0x29A0090
	|-Array.InternalArray__IndexOf<object>
	|
	|-RVA: 0x29A0230 Offset: 0x29A0331 VA: 0x29A0230
	|-Array.InternalArray__IndexOf<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x29A0400 Offset: 0x29A0501 VA: 0x29A0400
	|-Array.InternalArray__IndexOf<ReadOnlyMemory<object>>
	|
	|-RVA: 0x29A05C0 Offset: 0x29A06C1 VA: 0x29A05C0
	|-Array.InternalArray__IndexOf<CustomAttributeNamedArgument>
	|
	|-RVA: 0x29A0750 Offset: 0x29A0851 VA: 0x29A0750
	|-Array.InternalArray__IndexOf<CustomAttributeTypedArgument>
	|
	|-RVA: 0x29A08E0 Offset: 0x29A09E1 VA: 0x29A08E0
	|-Array.InternalArray__IndexOf<Label>
	|
	|-RVA: 0x29A0A60 Offset: 0x29A0B61 VA: 0x29A0A60
	|-Array.InternalArray__IndexOf<ParameterModifier>
	|
	|-RVA: 0x29A0C30 Offset: 0x29A0D31 VA: 0x29A0C30
	|-Array.InternalArray__IndexOf<ResourceLocator>
	|
	|-RVA: 0x29A0E00 Offset: 0x29A0F01 VA: 0x29A0E00
	|-Array.InternalArray__IndexOf<Ephemeron>
	|
	|-RVA: 0x29A0FD0 Offset: 0x29A10D1 VA: 0x29A0FD0
	|-Array.InternalArray__IndexOf<GCHandle>
	|
	|-RVA: 0x29A1150 Offset: 0x29A1251 VA: 0x29A1150
	|-Array.InternalArray__IndexOf<RuntimeTypeHandle>
	|
	|-RVA: 0x29A12D0 Offset: 0x29A13D1 VA: 0x29A12D0
	|-Array.InternalArray__IndexOf<sbyte>
	|
	|-RVA: 0x29A1450 Offset: 0x29A1551 VA: 0x29A1450
	|-Array.InternalArray__IndexOf<X509ChainStatus>
	|
	|-RVA: 0x29A1620 Offset: 0x29A1721 VA: 0x29A1620
	|-Array.InternalArray__IndexOf<float>
	|
	|-RVA: 0x29A17A0 Offset: 0x29A18A1 VA: 0x29A17A0
	|-Array.InternalArray__IndexOf<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x29A1980 Offset: 0x29A1A81 VA: 0x29A1980
	|-Array.InternalArray__IndexOf<CancellationTokenRegistration>
	|
	|-RVA: 0x29A1B10 Offset: 0x29A1C11 VA: 0x29A1B10
	|-Array.InternalArray__IndexOf<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x29A1CE0 Offset: 0x29A1DE1 VA: 0x29A1CE0
	|-Array.InternalArray__IndexOf<TimeSpan>
	|
	|-RVA: 0x29A1E60 Offset: 0x29A1F61 VA: 0x29A1E60
	|-Array.InternalArray__IndexOf<ushort>
	|
	|-RVA: 0x29A1FE0 Offset: 0x29A20E1 VA: 0x29A1FE0
	|-Array.InternalArray__IndexOf<UInt16Enum>
	|
	|-RVA: 0x29A2190 Offset: 0x29A2291 VA: 0x29A2190
	|-Array.InternalArray__IndexOf<uint>
	|
	|-RVA: 0x29A2310 Offset: 0x29A2411 VA: 0x29A2310
	|-Array.InternalArray__IndexOf<UInt32Enum>
	|
	|-RVA: 0x29A24C0 Offset: 0x29A25C1 VA: 0x29A24C0
	|-Array.InternalArray__IndexOf<ulong>
	|
	|-RVA: 0x29A2640 Offset: 0x29A2741 VA: 0x29A2640
	|-Array.InternalArray__IndexOf<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x29A2800 Offset: 0x29A2901 VA: 0x29A2800
	|-Array.InternalArray__IndexOf<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x29A29C0 Offset: 0x29A2AC1 VA: 0x29A29C0
	|-Array.InternalArray__IndexOf<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x29A2B80 Offset: 0x29A2C81 VA: 0x29A2B80
	|-Array.InternalArray__IndexOf<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x29A2D40 Offset: 0x29A2E41 VA: 0x29A2D40
	|-Array.InternalArray__IndexOf<ValueTuple<object, object>>
	|
	|-RVA: 0x29A2F00 Offset: 0x29A3001 VA: 0x29A2F00
	|-Array.InternalArray__IndexOf<ValueTuple<object, float>>
	|
	|-RVA: 0x29A30C0 Offset: 0x29A31C1 VA: 0x29A30C0
	|-Array.InternalArray__IndexOf<ValueTuple<float, object>>
	|
	|-RVA: 0x29A3280 Offset: 0x29A3381 VA: 0x29A3280
	|-Array.InternalArray__IndexOf<ValueTuple<float, float>>
	|
	|-RVA: 0x29A3440 Offset: 0x29A3541 VA: 0x29A3440
	|-Array.InternalArray__IndexOf<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x29A3630 Offset: 0x29A3731 VA: 0x29A3630
	|-Array.InternalArray__IndexOf<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x29A3800 Offset: 0x29A3901 VA: 0x29A3800
	|-Array.InternalArray__IndexOf<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x29A39D0 Offset: 0x29A3AD1 VA: 0x29A39D0
	|-Array.InternalArray__IndexOf<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x29A3BA0 Offset: 0x29A3CA1 VA: 0x29A3BA0
	|-Array.InternalArray__IndexOf<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x29A3DB0 Offset: 0x29A3EB1 VA: 0x29A3DB0
	|-Array.InternalArray__IndexOf<HighlightState>
	|
	|-RVA: 0x29A3F40 Offset: 0x29A4041 VA: 0x29A3F40
	|-Array.InternalArray__IndexOf<MaterialReference>
	|
	|-RVA: 0x29A4150 Offset: 0x29A4251 VA: 0x29A4150
	|-Array.InternalArray__IndexOf<RichTextTagAttribute>
	|
	|-RVA: 0x29A4330 Offset: 0x29A4431 VA: 0x29A4330
	|-Array.InternalArray__IndexOf<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x29A4540 Offset: 0x29A4641 VA: 0x29A4540
	|-Array.InternalArray__IndexOf<TMP_CharacterInfo>
	|
	|-RVA: 0x29A4730 Offset: 0x29A4831 VA: 0x29A4730
	|-Array.InternalArray__IndexOf<TMP_FontWeightPair>
	|
	|-RVA: 0x29A4900 Offset: 0x29A4A01 VA: 0x29A4900
	|-Array.InternalArray__IndexOf<TMP_LineInfo>
	|
	|-RVA: 0x29A4B40 Offset: 0x29A4C41 VA: 0x29A4B40
	|-Array.InternalArray__IndexOf<TMP_LinkInfo>
	|
	|-RVA: 0x29A4D30 Offset: 0x29A4E31 VA: 0x29A4D30
	|-Array.InternalArray__IndexOf<TMP_MeshInfo>
	|
	|-RVA: 0x29A4F50 Offset: 0x29A5051 VA: 0x29A4F50
	|-Array.InternalArray__IndexOf<TMP_PageInfo>
	|
	|-RVA: 0x29A5130 Offset: 0x29A5231 VA: 0x29A5130
	|-Array.InternalArray__IndexOf<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x29A5310 Offset: 0x29A5411 VA: 0x29A5310
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x29A54F0 Offset: 0x29A55F1 VA: 0x29A54F0
	|-Array.InternalArray__IndexOf<TMP_WordInfo>
	|
	|-RVA: 0x29A56D0 Offset: 0x29A57D1 VA: 0x29A56D0
	|-Array.InternalArray__IndexOf<WordWrapState>
	|
	|-RVA: 0x29A58C0 Offset: 0x29A59C1 VA: 0x29A58C0
	|-Array.InternalArray__IndexOf<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x29A5AB0 Offset: 0x29A5BB1 VA: 0x29A5AB0
	|-Array.InternalArray__IndexOf<TransitionTables>
	|
	|-RVA: 0x29A5C90 Offset: 0x29A5D91 VA: 0x29A5C90
	|-Array.InternalArray__IndexOf<TutorialUnlockFlagData>
	|
	|-RVA: 0x29A5E70 Offset: 0x29A5F71 VA: 0x29A5E70
	|-Array.InternalArray__IndexOf<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x29A6040 Offset: 0x29A6141 VA: 0x29A6040
	|-Array.InternalArray__IndexOf<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x29A6210 Offset: 0x29A6311 VA: 0x29A6210
	|-Array.InternalArray__IndexOf<CapEdge>
	|
	|-RVA: 0x29A6410 Offset: 0x29A6511 VA: 0x29A6410
	|-Array.InternalArray__IndexOf<ClippedEdge>
	|
	|-RVA: 0x29A65F0 Offset: 0x29A66F1 VA: 0x29A65F0
	|-Array.InternalArray__IndexOf<EdgeKeyByHash>
	|
	|-RVA: 0x29A67C0 Offset: 0x29A68C1 VA: 0x29A67C0
	|-Array.InternalArray__IndexOf<EdgeKeyByIndex>
	|
	|-RVA: 0x29A6990 Offset: 0x29A6A91 VA: 0x29A6990
	|-Array.InternalArray__IndexOf<MeshDataConnectivity.Face>
	|
	|-RVA: 0x29A6B60 Offset: 0x29A6C61 VA: 0x29A6B60
	|-Array.InternalArray__IndexOf<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x29A6D40 Offset: 0x29A6E41 VA: 0x29A6D40
	|-Array.InternalArray__IndexOf<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x29A6F30 Offset: 0x29A7031 VA: 0x29A6F30
	|-Array.InternalArray__IndexOf<NavMeshBuildMarkup>
	|
	|-RVA: 0x29A7100 Offset: 0x29A7201 VA: 0x29A7100
	|-Array.InternalArray__IndexOf<NavMeshBuildSource>
	|
	|-RVA: 0x29A7340 Offset: 0x29A7441 VA: 0x29A7340
	|-Array.InternalArray__IndexOf<ContentCatalogData.Bucket>
	|
	|-RVA: 0x29A7510 Offset: 0x29A7611 VA: 0x29A7510
	|-Array.InternalArray__IndexOf<ConstraintSource>
	|
	|-RVA: 0x29A76E0 Offset: 0x29A77E1 VA: 0x29A76E0
	|-Array.InternalArray__IndexOf<PropertySceneHandle>
	|
	|-RVA: 0x29A78B0 Offset: 0x29A79B1 VA: 0x29A78B0
	|-Array.InternalArray__IndexOf<TransformStreamHandle>
	|
	|-RVA: 0x29A7A90 Offset: 0x29A7B91 VA: 0x29A7A90
	|-Array.InternalArray__IndexOf<AnimatorClipInfo>
	|
	|-RVA: 0x29A7C60 Offset: 0x29A7D61 VA: 0x29A7C60
	|-Array.InternalArray__IndexOf<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x29A7E30 Offset: 0x29A7F31 VA: 0x29A7E30
	|-Array.InternalArray__IndexOf<BoneWeight1>
	|
	|-RVA: 0x29A7FB0 Offset: 0x29A80B1 VA: 0x29A7FB0
	|-Array.InternalArray__IndexOf<BoneWeight>
	|
	|-RVA: 0x29A8140 Offset: 0x29A8241 VA: 0x29A8140
	|-Array.InternalArray__IndexOf<BoundingSphere>
	|
	|-RVA: 0x29A8320 Offset: 0x29A8421 VA: 0x29A8320
	|-Array.InternalArray__IndexOf<Bounds>
	|
	|-RVA: 0x29A84B0 Offset: 0x29A85B1 VA: 0x29A84B0
	|-Array.InternalArray__IndexOf<BoundsInt>
	|
	|-RVA: 0x29A8640 Offset: 0x29A8741 VA: 0x29A8640
	|-Array.InternalArray__IndexOf<CharacterInfo>
	|
	|-RVA: 0x29A8860 Offset: 0x29A8961 VA: 0x29A8860
	|-Array.InternalArray__IndexOf<Color32>
	|
	|-RVA: 0x29A8A30 Offset: 0x29A8B31 VA: 0x29A8A30
	|-Array.InternalArray__IndexOf<Color>
	|
	|-RVA: 0x29A8BD0 Offset: 0x29A8CD1 VA: 0x29A8BD0
	|-Array.InternalArray__IndexOf<CombineInstance>
	|
	|-RVA: 0x29A8E10 Offset: 0x29A8F11 VA: 0x29A8E10
	|-Array.InternalArray__IndexOf<ContactPoint2D>
	|
	|-RVA: 0x29A9020 Offset: 0x29A9121 VA: 0x29A9020
	|-Array.InternalArray__IndexOf<ContactPoint>
	|
	|-RVA: 0x29A9220 Offset: 0x29A9321 VA: 0x29A9220
	|-Array.InternalArray__IndexOf<RaycastResult>
	|
	|-RVA: 0x29A9440 Offset: 0x29A9541 VA: 0x29A9440
	|-Array.InternalArray__IndexOf<LightDataGI>
	|
	|-RVA: 0x29A9670 Offset: 0x29A9771 VA: 0x29A9670
	|-Array.InternalArray__IndexOf<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x29A9840 Offset: 0x29A9941 VA: 0x29A9840
	|-Array.InternalArray__IndexOf<GradientAlphaKey>
	|
	|-RVA: 0x29A9A10 Offset: 0x29A9B11 VA: 0x29A9A10
	|-Array.InternalArray__IndexOf<GradientColorKey>
	|
	|-RVA: 0x29A9BF0 Offset: 0x29A9CF1 VA: 0x29A9BF0
	|-Array.InternalArray__IndexOf<HumanBone>
	|
	|-RVA: 0x29A9E00 Offset: 0x29A9F01 VA: 0x29A9E00
	|-Array.InternalArray__IndexOf<Keyframe>
	|
	|-RVA: 0x29A9FF0 Offset: 0x29AA0F1 VA: 0x29A9FF0
	|-Array.InternalArray__IndexOf<LOD>
	|
	|-RVA: 0x29AA1C0 Offset: 0x29AA2C1 VA: 0x29AA1C0
	|-Array.InternalArray__IndexOf<LayerMask>
	|
	|-RVA: 0x29AA390 Offset: 0x29AA491 VA: 0x29AA390
	|-Array.InternalArray__IndexOf<PlayerLoopSystem>
	|
	|-RVA: 0x29AA580 Offset: 0x29AA681 VA: 0x29AA580
	|-Array.InternalArray__IndexOf<Matrix4x4>
	|
	|-RVA: 0x2549880 Offset: 0x2549981 VA: 0x2549880
	|-Array.InternalArray__IndexOf<ParticleSystem.Particle>
	|
	|-RVA: 0x2549A80 Offset: 0x2549B81 VA: 0x2549A80
	|-Array.InternalArray__IndexOf<PatchExtents>
	|
	|-RVA: 0x2549C50 Offset: 0x2549D51 VA: 0x2549C50
	|-Array.InternalArray__IndexOf<Plane>
	|
	|-RVA: 0x2549E30 Offset: 0x2549F31 VA: 0x2549E30
	|-Array.InternalArray__IndexOf<Playable>
	|
	|-RVA: 0x254A000 Offset: 0x254A101 VA: 0x254A000
	|-Array.InternalArray__IndexOf<PlayableBinding>
	|
	|-RVA: 0x254A1E0 Offset: 0x254A2E1 VA: 0x254A1E0
	|-Array.InternalArray__IndexOf<PlayableGraph>
	|
	|-RVA: 0x254A3B0 Offset: 0x254A4B1 VA: 0x254A3B0
	|-Array.InternalArray__IndexOf<Edge>
	|
	|-RVA: 0x254A530 Offset: 0x254A631 VA: 0x254A530
	|-Array.InternalArray__IndexOf<IntVec3>
	|
	|-RVA: 0x254A6D0 Offset: 0x254A7D1 VA: 0x254A6D0
	|-Array.InternalArray__IndexOf<Quaternion>
	|
	|-RVA: 0x254A870 Offset: 0x254A971 VA: 0x254A870
	|-Array.InternalArray__IndexOf<RangeInt>
	|
	|-RVA: 0x254AA40 Offset: 0x254AB41 VA: 0x254AA40
	|-Array.InternalArray__IndexOf<RaycastHit2D>
	|
	|-RVA: 0x254AC40 Offset: 0x254AD41 VA: 0x254AC40
	|-Array.InternalArray__IndexOf<RaycastHit>
	|
	|-RVA: 0x254AE50 Offset: 0x254AF51 VA: 0x254AE50
	|-Array.InternalArray__IndexOf<Rect>
	|
	|-RVA: 0x254AFF0 Offset: 0x254B0F1 VA: 0x254AFF0
	|-Array.InternalArray__IndexOf<RectInt>
	|
	|-RVA: 0x254B1C0 Offset: 0x254B2C1 VA: 0x254B1C0
	|-Array.InternalArray__IndexOf<RenderBuffer>
	|
	|-RVA: 0x254B390 Offset: 0x254B491 VA: 0x254B390
	|-Array.InternalArray__IndexOf<BatchVisibility>
	|
	|-RVA: 0x254B570 Offset: 0x254B671 VA: 0x254B570
	|-Array.InternalArray__IndexOf<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x254B740 Offset: 0x254B841 VA: 0x254B740
	|-Array.InternalArray__IndexOf<SphericalHarmonicsL2>
	|
	|-RVA: 0x254B920 Offset: 0x254BA21 VA: 0x254B920
	|-Array.InternalArray__IndexOf<VertexAttributeDescriptor>
	|
	|-RVA: 0x254BAB0 Offset: 0x254BBB1 VA: 0x254BAB0
	|-Array.InternalArray__IndexOf<AsyncOperationHandle>
	|
	|-RVA: 0x254BC90 Offset: 0x254BD91 VA: 0x254BC90
	|-Array.InternalArray__IndexOf<AsyncOperationHandle<object>>
	|
	|-RVA: 0x254BE70 Offset: 0x254BF71 VA: 0x254BE70
	|-Array.InternalArray__IndexOf<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x254C050 Offset: 0x254C151 VA: 0x254C050
	|-Array.InternalArray__IndexOf<DiagnosticEvent>
	|
	|-RVA: 0x254C240 Offset: 0x254C341 VA: 0x254C240
	|-Array.InternalArray__IndexOf<SceneInstance>
	|
	|-RVA: 0x254C3D0 Offset: 0x254C4D1 VA: 0x254C3D0
	|-Array.InternalArray__IndexOf<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x254C5B0 Offset: 0x254C6B1 VA: 0x254C5B0
	|-Array.InternalArray__IndexOf<ObjectInitializationData>
	|
	|-RVA: 0x254C7A0 Offset: 0x254C8A1 VA: 0x254C7A0
	|-Array.InternalArray__IndexOf<SerializedType>
	|
	|-RVA: 0x254C980 Offset: 0x254CA81 VA: 0x254C980
	|-Array.InternalArray__IndexOf<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x254CB50 Offset: 0x254CC51 VA: 0x254CB50
	|-Array.InternalArray__IndexOf<SkeletonBone>
	|
	|-RVA: 0x254CD60 Offset: 0x254CE61 VA: 0x254CD60
	|-Array.InternalArray__IndexOf<GlyphRect>
	|
	|-RVA: 0x254CEF0 Offset: 0x254CFF1 VA: 0x254CEF0
	|-Array.InternalArray__IndexOf<GlyphMarshallingStruct>
	|
	|-RVA: 0x254D0E0 Offset: 0x254D1E1 VA: 0x254D0E0
	|-Array.InternalArray__IndexOf<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x254D2F0 Offset: 0x254D3F1 VA: 0x254D2F0
	|-Array.InternalArray__IndexOf<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x254D4E0 Offset: 0x254D5E1 VA: 0x254D4E0
	|-Array.InternalArray__IndexOf<IntervalTreeNode>
	|
	|-RVA: 0x254D6C0 Offset: 0x254D7C1 VA: 0x254D6C0
	|-Array.InternalArray__IndexOf<IntervalTree.Entry<object>>
	|
	|-RVA: 0x254D8A0 Offset: 0x254D9A1 VA: 0x254D8A0
	|-Array.InternalArray__IndexOf<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x254DA80 Offset: 0x254DB81 VA: 0x254DA80
	|-Array.InternalArray__IndexOf<Touch>
	|
	|-RVA: 0x254DCB0 Offset: 0x254DDB1 VA: 0x254DCB0
	|-Array.InternalArray__IndexOf<TreeInstance>
	|
	|-RVA: 0x254DEA0 Offset: 0x254DFA1 VA: 0x254DEA0
	|-Array.InternalArray__IndexOf<ColorBlock>
	|
	|-RVA: 0x254E060 Offset: 0x254E161 VA: 0x254E060
	|-Array.InternalArray__IndexOf<Navigation>
	|
	|-RVA: 0x254E250 Offset: 0x254E351 VA: 0x254E250
	|-Array.InternalArray__IndexOf<SpriteState>
	|
	|-RVA: 0x254E430 Offset: 0x254E531 VA: 0x254E430
	|-Array.InternalArray__IndexOf<UICharInfo>
	|
	|-RVA: 0x254E620 Offset: 0x254E721 VA: 0x254E620
	|-Array.InternalArray__IndexOf<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x254E7F0 Offset: 0x254E8F1 VA: 0x254E7F0
	|-Array.InternalArray__IndexOf<EventDispatcher.EventRecord>
	|
	|-RVA: 0x254E9C0 Offset: 0x254EAC1 VA: 0x254E9C0
	|-Array.InternalArray__IndexOf<FocusController.FocusedElement>
	|
	|-RVA: 0x254EB90 Offset: 0x254EC91 VA: 0x254EB90
	|-Array.InternalArray__IndexOf<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x254ED60 Offset: 0x254EE61 VA: 0x254ED60
	|-Array.InternalArray__IndexOf<StyleValue>
	|
	|-RVA: 0x254EF40 Offset: 0x254F041 VA: 0x254EF40
	|-Array.InternalArray__IndexOf<UILineInfo>
	|
	|-RVA: 0x254F110 Offset: 0x254F211 VA: 0x254F110
	|-Array.InternalArray__IndexOf<UIVertex>
	|
	|-RVA: 0x254F340 Offset: 0x254F441 VA: 0x254F340
	|-Array.InternalArray__IndexOf<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x254F520 Offset: 0x254F621 VA: 0x254F520
	|-Array.InternalArray__IndexOf<Vector2>
	|
	|-RVA: 0x254F6B0 Offset: 0x254F7B1 VA: 0x254F6B0
	|-Array.InternalArray__IndexOf<Vector2Int>
	|
	|-RVA: 0x254F830 Offset: 0x254F931 VA: 0x254F830
	|-Array.InternalArray__IndexOf<Vector3>
	|
	|-RVA: 0x254F9D0 Offset: 0x254FAD1 VA: 0x254F9D0
	|-Array.InternalArray__IndexOf<Vector3Int>
	|
	|-RVA: 0x254FB60 Offset: 0x254FC61 VA: 0x254FB60
	|-Array.InternalArray__IndexOf<Vector4>
	|
	|-RVA: 0x254FD00 Offset: 0x254FE01 VA: 0x254FD00
	|-Array.InternalArray__IndexOf<jvalue>
	|
	|-RVA: 0x254FED0 Offset: 0x254FFD1 VA: 0x254FED0
	|-Array.InternalArray__IndexOf<WarpPoints.WarpPoint>
	|
	|-RVA: 0x2550130 Offset: 0x2550231 VA: 0x2550130
	|-Array.InternalArray__IndexOf<YieldItemParam>
	|
	|-RVA: 0x2550300 Offset: 0x2550401 VA: 0x2550300
	|-Array.InternalArray__IndexOf<NetworkServiceAccountId>
	|
	|-RVA: 0x2550480 Offset: 0x2550581 VA: 0x2550480
	|-Array.InternalArray__IndexOf<Uid>
	|
	|-RVA: 0x2550610 Offset: 0x2550711 VA: 0x2550610
	|-Array.InternalArray__IndexOf<ConsumableServiceItemId>
	|
	|-RVA: 0x25507E0 Offset: 0x25508E1 VA: 0x25507E0
	|-Array.InternalArray__IndexOf<NsUid>
	|
	|-RVA: 0x2550960 Offset: 0x2550A61 VA: 0x2550960
	|-Array.InternalArray__IndexOf<Friend>
	|
	|-RVA: 0x2550B50 Offset: 0x2550C51 VA: 0x2550B50
	|-Array.InternalArray__IndexOf<Profile>
	|
	|-RVA: 0x2550D70 Offset: 0x2550E71 VA: 0x2550D70
	|-Array.InternalArray__IndexOf<DirectoryEntry>
	|
	|-RVA: 0x2550F50 Offset: 0x2551051 VA: 0x2550F50
	|-Array.InternalArray__IndexOf<DebugPadState>
	|
	|-RVA: 0x2551130 Offset: 0x2551231 VA: 0x2551130
	|-Array.InternalArray__IndexOf<GesturePoint>
	|
	|-RVA: 0x25512B0 Offset: 0x25513B1 VA: 0x25512B0
	|-Array.InternalArray__IndexOf<GestureState>
	|
	|-RVA: 0x25514E0 Offset: 0x25515E1 VA: 0x25514E0
	|-Array.InternalArray__IndexOf<NpadFullKeyState>
	|
	|-RVA: 0x25516D0 Offset: 0x25517D1 VA: 0x25516D0
	|-Array.InternalArray__IndexOf<NpadHandheldState>
	|
	|-RVA: 0x25518C0 Offset: 0x25519C1 VA: 0x25518C0
	|-Array.InternalArray__IndexOf<NpadJoyDualState>
	|
	|-RVA: 0x2551AB0 Offset: 0x2551BB1 VA: 0x2551AB0
	|-Array.InternalArray__IndexOf<NpadJoyLeftState>
	|
	|-RVA: 0x2551CA0 Offset: 0x2551DA1 VA: 0x2551CA0
	|-Array.InternalArray__IndexOf<NpadJoyRightState>
	|
	|-RVA: 0x2551E90 Offset: 0x2551F91 VA: 0x2551E90
	|-Array.InternalArray__IndexOf<NpadStateArrayItem>
	|
	|-RVA: 0x2552080 Offset: 0x2552181 VA: 0x2552080
	|-Array.InternalArray__IndexOf<SixAxisSensorHandle>
	|
	|-RVA: 0x2552250 Offset: 0x2552351 VA: 0x2552250
	|-Array.InternalArray__IndexOf<SixAxisSensorState>
	|
	|-RVA: 0x2552480 Offset: 0x2552581 VA: 0x2552480
	|-Array.InternalArray__IndexOf<TouchScreenState10>
	|
	|-RVA: 0x2552670 Offset: 0x2552771 VA: 0x2552670
	|-Array.InternalArray__IndexOf<TouchScreenState11>
	|
	|-RVA: 0x2552860 Offset: 0x2552961 VA: 0x2552860
	|-Array.InternalArray__IndexOf<TouchScreenState12>
	|
	|-RVA: 0x2552A50 Offset: 0x2552B51 VA: 0x2552A50
	|-Array.InternalArray__IndexOf<TouchScreenState13>
	|
	|-RVA: 0x2552C40 Offset: 0x2552D41 VA: 0x2552C40
	|-Array.InternalArray__IndexOf<TouchScreenState14>
	|
	|-RVA: 0x2552E30 Offset: 0x2552F31 VA: 0x2552E30
	|-Array.InternalArray__IndexOf<TouchScreenState15>
	|
	|-RVA: 0x2553020 Offset: 0x2553121 VA: 0x2553020
	|-Array.InternalArray__IndexOf<TouchScreenState16>
	|
	|-RVA: 0x2553210 Offset: 0x2553311 VA: 0x2553210
	|-Array.InternalArray__IndexOf<TouchScreenState1>
	|
	|-RVA: 0x2553420 Offset: 0x2553521 VA: 0x2553420
	|-Array.InternalArray__IndexOf<TouchScreenState2>
	|
	|-RVA: 0x2553650 Offset: 0x2553751 VA: 0x2553650
	|-Array.InternalArray__IndexOf<TouchScreenState3>
	|
	|-RVA: 0x2553850 Offset: 0x2553951 VA: 0x2553850
	|-Array.InternalArray__IndexOf<TouchScreenState4>
	|
	|-RVA: 0x2553A60 Offset: 0x2553B61 VA: 0x2553A60
	|-Array.InternalArray__IndexOf<TouchScreenState5>
	|
	|-RVA: 0x2553C70 Offset: 0x2553D71 VA: 0x2553C70
	|-Array.InternalArray__IndexOf<TouchScreenState6>
	|
	|-RVA: 0x2553E90 Offset: 0x2553F91 VA: 0x2553E90
	|-Array.InternalArray__IndexOf<TouchScreenState7>
	|
	|-RVA: 0x2554080 Offset: 0x2554181 VA: 0x2554080
	|-Array.InternalArray__IndexOf<TouchScreenState8>
	|
	|-RVA: 0x2554270 Offset: 0x2554371 VA: 0x2554270
	|-Array.InternalArray__IndexOf<TouchScreenState9>
	|
	|-RVA: 0x2554460 Offset: 0x2554561 VA: 0x2554460
	|-Array.InternalArray__IndexOf<TouchState>
	|
	|-RVA: 0x2554600 Offset: 0x2554701 VA: 0x2554600
	|-Array.InternalArray__IndexOf<VibrationDeviceHandle>
	|
	|-RVA: 0x25547D0 Offset: 0x25548D1 VA: 0x25547D0
	|-Array.InternalArray__IndexOf<VibrationDeviceInfo>
	|
	|-RVA: 0x25549A0 Offset: 0x2554AA1 VA: 0x25549A0
	|-Array.InternalArray__IndexOf<VibrationValue>
	|
	|-RVA: 0x2554B80 Offset: 0x2554C81 VA: 0x2554B80
	|-Array.InternalArray__IndexOf<ClusteringData>
	|
	|-RVA: 0x2554D10 Offset: 0x2554E11 VA: 0x2554D10
	|-Array.InternalArray__IndexOf<ClusteringProcessorState>
	|
	|-RVA: 0x2554F00 Offset: 0x2555001 VA: 0x2554F00
	|-Array.InternalArray__IndexOf<Finger>
	|
	|-RVA: 0x25550A0 Offset: 0x25551A1 VA: 0x25550A0
	|-Array.InternalArray__IndexOf<Hand>
	|
	|-RVA: 0x2555240 Offset: 0x2555341 VA: 0x2555240
	|-Array.InternalArray__IndexOf<HandAnalysisImageState>
	|
	|-RVA: 0x2555410 Offset: 0x2555511 VA: 0x2555410
	|-Array.InternalArray__IndexOf<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x2555600 Offset: 0x2555701 VA: 0x2555600
	|-Array.InternalArray__IndexOf<MomentProcessorState>
	|
	|-RVA: 0x25557F0 Offset: 0x25558F1 VA: 0x25557F0
	|-Array.InternalArray__IndexOf<MomentStatistic>
	|
	|-RVA: 0x2555990 Offset: 0x2555A91 VA: 0x2555990
	|-Array.InternalArray__IndexOf<Protrusion>
	|
	|-RVA: 0x2555B10 Offset: 0x2555C11 VA: 0x2555B10
	|-Array.InternalArray__IndexOf<Shape>
	|
	|-RVA: 0x2555CA0 Offset: 0x2555DA1 VA: 0x2555CA0
	|-Array.InternalArray__IndexOf<DictionaryInfo>
	|
	|-RVA: 0x2555E20 Offset: 0x2555F21 VA: 0x2555E20
	|-Array.InternalArray__IndexOf<UserWord>
	|
	|-RVA: 0x2555FF0 Offset: 0x25560F1 VA: 0x2555FF0
	|-Array.InternalArray__IndexOf<Color4u8>
	|
	|-RVA: 0x2556170 Offset: 0x2556271 VA: 0x2556170
	|-Array.InternalArray__IndexOf<Float2>
	|
	|-RVA: 0x2556300 Offset: 0x2556401 VA: 0x2556300
	|-Array.InternalArray__IndexOf<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	internal T InternalArray__get_Item<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2395A30 Offset: 0x2395B31 VA: 0x2395A30
	|-Array.InternalArray__get_Item<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x2395B20 Offset: 0x2395C21 VA: 0x2395B20
	|-Array.InternalArray__get_Item<ActionCommandDataTable>
	|
	|-RVA: 0x2395C40 Offset: 0x2395D41 VA: 0x2395C40
	|-Array.InternalArray__get_Item<AdvScriptDefCountParam>
	|
	|-RVA: 0x2395D10 Offset: 0x2395E11 VA: 0x2395D10
	|-Array.InternalArray__get_Item<JSONDeserialization.TaskField>
	|
	|-RVA: 0x2395DE0 Offset: 0x2395EE1 VA: 0x2395DE0
	|-Array.InternalArray__get_Item<BitVector32Int>
	|
	|-RVA: 0x2395EB0 Offset: 0x2395FB1 VA: 0x2395EB0
	|-Array.InternalArray__get_Item<BuildItemData>
	|
	|-RVA: 0x2395FE0 Offset: 0x23960E1 VA: 0x2395FE0
	|-Array.InternalArray__get_Item<ButtonLinker.LinkObject>
	|
	|-RVA: 0x23960B0 Offset: 0x23961B1 VA: 0x23960B0
	|-Array.InternalArray__get_Item<CharaCallTable.BustupTable>
	|
	|-RVA: 0x2396180 Offset: 0x2396281 VA: 0x2396180
	|-Array.InternalArray__get_Item<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x2396260 Offset: 0x2396361 VA: 0x2396260
	|-Array.InternalArray__get_Item<CameraState.CustomBlendable>
	|
	|-RVA: 0x2396330 Offset: 0x2396431 VA: 0x2396330
	|-Array.InternalArray__get_Item<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x2396420 Offset: 0x2396521 VA: 0x2396420
	|-Array.InternalArray__get_Item<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x2396510 Offset: 0x2396611 VA: 0x2396510
	|-Array.InternalArray__get_Item<CinemachineClearShot.Pair>
	|
	|-RVA: 0x23965E0 Offset: 0x23966E1 VA: 0x23965E0
	|-Array.InternalArray__get_Item<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x23966B0 Offset: 0x23967B1 VA: 0x23966B0
	|-Array.InternalArray__get_Item<CinemachinePath.Waypoint>
	|
	|-RVA: 0x23967A0 Offset: 0x23968A1 VA: 0x23967A0
	|-Array.InternalArray__get_Item<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x2396880 Offset: 0x2396981 VA: 0x2396880
	|-Array.InternalArray__get_Item<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2396950 Offset: 0x2396A51 VA: 0x2396950
	|-Array.InternalArray__get_Item<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x2396A40 Offset: 0x2396B41 VA: 0x2396A40
	|-Array.InternalArray__get_Item<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x2396B10 Offset: 0x2396C11 VA: 0x2396B10
	|-Array.InternalArray__get_Item<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x2396BE0 Offset: 0x2396CE1 VA: 0x2396BE0
	|-Array.InternalArray__get_Item<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x2396CD0 Offset: 0x2396DD1 VA: 0x2396CD0
	|-Array.InternalArray__get_Item<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2396DC0 Offset: 0x2396EC1 VA: 0x2396DC0
	|-Array.InternalArray__get_Item<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x2396EB0 Offset: 0x2396FB1 VA: 0x2396EB0
	|-Array.InternalArray__get_Item<HeadingTracker.Item>
	|
	|-RVA: 0x2396FA0 Offset: 0x23970A1 VA: 0x2396FA0
	|-Array.InternalArray__get_Item<CropDataTable>
	|
	|-RVA: 0x23970C0 Offset: 0x23971C1 VA: 0x23970C0
	|-Array.InternalArray__get_Item<ControlPoint>
	|
	|-RVA: 0x23971B0 Offset: 0x23972B1 VA: 0x23971B0
	|-Array.InternalArray__get_Item<DamageTextInfo>
	|
	|-RVA: 0x23972A0 Offset: 0x23973A1 VA: 0x23972A0
	|-Array.InternalArray__get_Item<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x2397390 Offset: 0x2397491 VA: 0x2397390
	|-Array.InternalArray__get_Item<DropItemParam>
	|
	|-RVA: 0x2397460 Offset: 0x2397561 VA: 0x2397460
	|-Array.InternalArray__get_Item<DropTableElement>
	|
	|-RVA: 0x2397550 Offset: 0x2397651 VA: 0x2397550
	|-Array.InternalArray__get_Item<EffectDataTable>
	|
	|-RVA: 0x2397640 Offset: 0x2397741 VA: 0x2397640
	|-Array.InternalArray__get_Item<EnemyPatrolPoints>
	|
	|-RVA: 0x2397710 Offset: 0x2397811 VA: 0x2397710
	|-Array.InternalArray__get_Item<Coord>
	|
	|-RVA: 0x23977E0 Offset: 0x23978E1 VA: 0x23977E0
	|-Array.InternalArray__get_Item<ErosionBrush.UndoStep>
	|
	|-RVA: 0x23978D0 Offset: 0x23979D1 VA: 0x23978D0
	|-Array.InternalArray__get_Item<EventCheckId>
	|
	|-RVA: 0x23979C0 Offset: 0x2397AC1 VA: 0x23979C0
	|-Array.InternalArray__get_Item<EventFlagProgressData>
	|
	|-RVA: 0x2397A90 Offset: 0x2397B91 VA: 0x2397A90
	|-Array.InternalArray__get_Item<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x2397B60 Offset: 0x2397C61 VA: 0x2397B60
	|-Array.InternalArray__get_Item<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x2397C80 Offset: 0x2397D81 VA: 0x2397C80
	|-Array.InternalArray__get_Item<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2397D80 Offset: 0x2397E81 VA: 0x2397D80
	|-Array.InternalArray__get_Item<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2397E70 Offset: 0x2397F71 VA: 0x2397E70
	|-Array.InternalArray__get_Item<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2397F50 Offset: 0x2398051 VA: 0x2397F50
	|-Array.InternalArray__get_Item<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x2398020 Offset: 0x2398121 VA: 0x2398020
	|-Array.InternalArray__get_Item<FesNpcScoreData>
	|
	|-RVA: 0x23980F0 Offset: 0x23981F1 VA: 0x23980F0
	|-Array.InternalArray__get_Item<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x23981C0 Offset: 0x23982C1 VA: 0x23981C0
	|-Array.InternalArray__get_Item<FieldItemSpawnDataTable>
	|
	|-RVA: 0x23982B0 Offset: 0x23983B1 VA: 0x23982B0
	|-Array.InternalArray__get_Item<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x23983A0 Offset: 0x23984A1 VA: 0x23983A0
	|-Array.InternalArray__get_Item<FieldSceneData.Data>
	|
	|-RVA: 0x23984B0 Offset: 0x23985B1 VA: 0x23984B0
	|-Array.InternalArray__get_Item<FieldTreasureBoxItemData>
	|
	|-RVA: 0x2398580 Offset: 0x2398681 VA: 0x2398580
	|-Array.InternalArray__get_Item<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x2398670 Offset: 0x2398771 VA: 0x2398670
	|-Array.InternalArray__get_Item<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x2398760 Offset: 0x2398861 VA: 0x2398760
	|-Array.InternalArray__get_Item<FocusObjectDataTable>
	|
	|-RVA: 0x2398850 Offset: 0x2398951 VA: 0x2398850
	|-Array.InternalArray__get_Item<FurnitureData>
	|
	|-RVA: 0x24FA140 Offset: 0x24FA241 VA: 0x24FA140
	|-Array.InternalArray__get_Item<GateDataTable>
	|
	|-RVA: 0x24FA210 Offset: 0x24FA311 VA: 0x24FA210
	|-Array.InternalArray__get_Item<GateStatusDataTable>
	|
	|-RVA: 0x24FA300 Offset: 0x24FA401 VA: 0x24FA300
	|-Array.InternalArray__get_Item<GimmickLayoutDataTable>
	|
	|-RVA: 0x24FA3D0 Offset: 0x24FA4D1 VA: 0x24FA3D0
	|-Array.InternalArray__get_Item<HitResult>
	|
	|-RVA: 0x24FA4C0 Offset: 0x24FA5C1 VA: 0x24FA4C0
	|-Array.InternalArray__get_Item<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x24FA5B0 Offset: 0x24FA6B1 VA: 0x24FA5B0
	|-Array.InternalArray__get_Item<FurnitureManager.SendPos>
	|
	|-RVA: 0x24FA6A0 Offset: 0x24FA7A1 VA: 0x24FA6A0
	|-Array.InternalArray__get_Item<ItemLevelData>
	|
	|-RVA: 0x24FA770 Offset: 0x24FA871 VA: 0x24FA770
	|-Array.InternalArray__get_Item<MapDatas.MapData>
	|
	|-RVA: 0x24FA860 Offset: 0x24FA961 VA: 0x24FA860
	|-Array.InternalArray__get_Item<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x24FA950 Offset: 0x24FAA51 VA: 0x24FA950
	|-Array.InternalArray__get_Item<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x24FAA20 Offset: 0x24FAB21 VA: 0x24FAA20
	|-Array.InternalArray__get_Item<MineTypeDataTable>
	|
	|-RVA: 0x24FAB20 Offset: 0x24FAC21 VA: 0x24FAB20
	|-Array.InternalArray__get_Item<MiningDataTable>
	|
	|-RVA: 0x24FABF0 Offset: 0x24FACF1 VA: 0x24FABF0
	|-Array.InternalArray__get_Item<MiningPointSaveData>
	|
	|-RVA: 0x24FACE0 Offset: 0x24FADE1 VA: 0x24FACE0
	|-Array.InternalArray__get_Item<CodePointIndexer.TableRange>
	|
	|-RVA: 0x24FADD0 Offset: 0x24FAED1 VA: 0x24FADD0
	|-Array.InternalArray__get_Item<MonsterBehaviorDataTable>
	|
	|-RVA: 0x24FAEC0 Offset: 0x24FAFC1 VA: 0x24FAEC0
	|-Array.InternalArray__get_Item<MonsterDataTable>
	|
	|-RVA: 0x24FAFD0 Offset: 0x24FB0D1 VA: 0x24FAFD0
	|-Array.InternalArray__get_Item<MonsterDropItemDataTable>
	|
	|-RVA: 0x24FB0C0 Offset: 0x24FB1C1 VA: 0x24FB0C0
	|-Array.InternalArray__get_Item<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x24FB1B0 Offset: 0x24FB2B1 VA: 0x24FB1B0
	|-Array.InternalArray__get_Item<MonsterHutSaveData>
	|
	|-RVA: 0x24FB2A0 Offset: 0x24FB3A1 VA: 0x24FB2A0
	|-Array.InternalArray__get_Item<MonsterUIData.Data>
	|
	|-RVA: 0x24FB390 Offset: 0x24FB491 VA: 0x24FB390
	|-Array.InternalArray__get_Item<MonsterYieldItemDataTable>
	|
	|-RVA: 0x24FB460 Offset: 0x24FB561 VA: 0x24FB460
	|-Array.InternalArray__get_Item<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x24FB530 Offset: 0x24FB631 VA: 0x24FB530
	|-Array.InternalArray__get_Item<NPCActionData>
	|
	|-RVA: 0x24FB630 Offset: 0x24FB731 VA: 0x24FB630
	|-Array.InternalArray__get_Item<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x24FB700 Offset: 0x24FB801 VA: 0x24FB700
	|-Array.InternalArray__get_Item<NPCUIData.Data>
	|
	|-RVA: 0x24FB7D0 Offset: 0x24FB8D1 VA: 0x24FB7D0
	|-Array.InternalArray__get_Item<NpcPlaceSchedule>
	|
	|-RVA: 0x24FB8C0 Offset: 0x24FB9C1 VA: 0x24FB8C0
	|-Array.InternalArray__get_Item<OrderLotterySaveParameter>
	|
	|-RVA: 0x24FB9A0 Offset: 0x24FBAA1 VA: 0x24FB9A0
	|-Array.InternalArray__get_Item<OrderSaveData>
	|
	|-RVA: 0x24FBA90 Offset: 0x24FBB91 VA: 0x24FBA90
	|-Array.InternalArray__get_Item<OrderSaveParameter>
	|
	|-RVA: 0x24FBB80 Offset: 0x24FBC81 VA: 0x24FBB80
	|-Array.InternalArray__get_Item<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x24FBC50 Offset: 0x24FBD51 VA: 0x24FBC50
	|-Array.InternalArray__get_Item<Parameter>
	|
	|-RVA: 0x24FBD60 Offset: 0x24FBE61 VA: 0x24FBD60
	|-Array.InternalArray__get_Item<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x24FBE30 Offset: 0x24FBF31 VA: 0x24FBE30
	|-Array.InternalArray__get_Item<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x24FBF20 Offset: 0x24FC021 VA: 0x24FBF20
	|-Array.InternalArray__get_Item<ShopCatalogPage>
	|
	|-RVA: 0x24FBFF0 Offset: 0x24FC0F1 VA: 0x24FBFF0
	|-Array.InternalArray__get_Item<ShopNpcTalk>
	|
	|-RVA: 0x24FC0E0 Offset: 0x24FC1E1 VA: 0x24FC0E0
	|-Array.InternalArray__get_Item<SubtitleDataTable.Data>
	|
	|-RVA: 0x24FC1C0 Offset: 0x24FC2C1 VA: 0x24FC1C0
	|-Array.InternalArray__get_Item<SubtitleDataTable.DataList>
	|
	|-RVA: 0x24FC290 Offset: 0x24FC391 VA: 0x24FC290
	|-Array.InternalArray__get_Item<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x24FC370 Offset: 0x24FC471 VA: 0x24FC370
	|-Array.InternalArray__get_Item<AnimationWarping.Warp>
	|
	|-RVA: 0x24FC460 Offset: 0x24FC561 VA: 0x24FC460
	|-Array.InternalArray__get_Item<GrounderQuadruped.Foot>
	|
	|-RVA: 0x24FC550 Offset: 0x24FC651 VA: 0x24FC550
	|-Array.InternalArray__get_Item<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x24FC640 Offset: 0x24FC741 VA: 0x24FC640
	|-Array.InternalArray__get_Item<ProfilerFrame>
	|
	|-RVA: 0x24FC720 Offset: 0x24FC821 VA: 0x24FC720
	|-Array.InternalArray__get_Item<NumberControl.ValueRange>
	|
	|-RVA: 0x24FC7F0 Offset: 0x24FC8F1 VA: 0x24FC7F0
	|-Array.InternalArray__get_Item<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x24FC8E0 Offset: 0x24FC9E1 VA: 0x24FC8E0
	|-Array.InternalArray__get_Item<ResponsiveEnable.Entry>
	|
	|-RVA: 0x24FC9D0 Offset: 0x24FCAD1 VA: 0x24FC9D0
	|-Array.InternalArray__get_Item<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x24FCAA0 Offset: 0x24FCBA1 VA: 0x24FCAA0
	|-Array.InternalArray__get_Item<ResponsiveResize.Element>
	|
	|-RVA: 0x24FCB70 Offset: 0x24FCC71 VA: 0x24FCB70
	|-Array.InternalArray__get_Item<Schedule>
	|
	|-RVA: 0x24FCC60 Offset: 0x24FCD61 VA: 0x24FCC60
	|-Array.InternalArray__get_Item<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x24FCD30 Offset: 0x24FCE31 VA: 0x24FCD30
	|-Array.InternalArray__get_Item<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x24FCE10 Offset: 0x24FCF11 VA: 0x24FCE10
	|-Array.InternalArray__get_Item<SpeedData>
	|
	|-RVA: 0x24FCEE0 Offset: 0x24FCFE1 VA: 0x24FCEE0
	|-Array.InternalArray__get_Item<CurveSample>
	|
	|-RVA: 0x24FCFF0 Offset: 0x24FD0F1 VA: 0x24FCFF0
	|-Array.InternalArray__get_Item<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x24FD0C0 Offset: 0x24FD1C1 VA: 0x24FD0C0
	|-Array.InternalArray__get_Item<StringFormatData.FormatData>
	|
	|-RVA: 0x24FD190 Offset: 0x24FD291 VA: 0x24FD190
	|-Array.InternalArray__get_Item<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x24FD260 Offset: 0x24FD361 VA: 0x24FD260
	|-Array.InternalArray__get_Item<ArraySegment<byte>>
	|
	|-RVA: 0x24FD330 Offset: 0x24FD431 VA: 0x24FD330
	|-Array.InternalArray__get_Item<ArraySegment<object>>
	|
	|-RVA: 0x24FD400 Offset: 0x24FD501 VA: 0x24FD400
	|-Array.InternalArray__get_Item<bool>
	|
	|-RVA: 0x24FD4D0 Offset: 0x24FD5D1 VA: 0x24FD4D0
	|-Array.InternalArray__get_Item<byte>
	|
	|-RVA: 0x24FD5A0 Offset: 0x24FD6A1 VA: 0x24FD5A0
	|-Array.InternalArray__get_Item<ByteEnum>
	|
	|-RVA: 0x24FD670 Offset: 0x24FD771 VA: 0x24FD670
	|-Array.InternalArray__get_Item<char>
	|
	|-RVA: 0x24FD740 Offset: 0x24FD841 VA: 0x24FD740
	|-Array.InternalArray__get_Item<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x24FD810 Offset: 0x24FD911 VA: 0x24FD810
	|-Array.InternalArray__get_Item<DictionaryEntry>
	|
	|-RVA: 0x24FD8E0 Offset: 0x24FD9E1 VA: 0x24FD8E0
	|-Array.InternalArray__get_Item<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x24FD9D0 Offset: 0x24FDAD1 VA: 0x24FD9D0
	|-Array.InternalArray__get_Item<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x24FDAC0 Offset: 0x24FDBC1 VA: 0x24FDAC0
	|-Array.InternalArray__get_Item<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x24FDBB0 Offset: 0x24FDCB1 VA: 0x24FDBB0
	|-Array.InternalArray__get_Item<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x24FDCC0 Offset: 0x24FDDC1 VA: 0x24FDCC0
	|-Array.InternalArray__get_Item<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x24FDDB0 Offset: 0x24FDEB1 VA: 0x24FDDB0
	|-Array.InternalArray__get_Item<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x24FDEA0 Offset: 0x24FDFA1 VA: 0x24FDEA0
	|-Array.InternalArray__get_Item<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x24FDF90 Offset: 0x24FE091 VA: 0x24FDF90
	|-Array.InternalArray__get_Item<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x24FE090 Offset: 0x24FE191 VA: 0x24FE090
	|-Array.InternalArray__get_Item<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x24FE180 Offset: 0x24FE281 VA: 0x24FE180
	|-Array.InternalArray__get_Item<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x24FE280 Offset: 0x24FE381 VA: 0x24FE280
	|-Array.InternalArray__get_Item<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x24FE370 Offset: 0x24FE471 VA: 0x24FE370
	|-Array.InternalArray__get_Item<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x24FE480 Offset: 0x24FE581 VA: 0x24FE480
	|-Array.InternalArray__get_Item<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x24FE570 Offset: 0x24FE671 VA: 0x24FE570
	|-Array.InternalArray__get_Item<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x24FE660 Offset: 0x24FE761 VA: 0x24FE660
	|-Array.InternalArray__get_Item<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x24FE750 Offset: 0x24FE851 VA: 0x24FE750
	|-Array.InternalArray__get_Item<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x24FE840 Offset: 0x24FE941 VA: 0x24FE840
	|-Array.InternalArray__get_Item<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x24FE930 Offset: 0x24FEA31 VA: 0x24FE930
	|-Array.InternalArray__get_Item<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x24FEA20 Offset: 0x24FEB21 VA: 0x24FEA20
	|-Array.InternalArray__get_Item<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x24FEB10 Offset: 0x24FEC11 VA: 0x24FEB10
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x24FEC40 Offset: 0x24FED41 VA: 0x24FEC40
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x24FED30 Offset: 0x24FEE31 VA: 0x24FED30
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x24FEE00 Offset: 0x24FEF01 VA: 0x24FEE00
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x24FEF10 Offset: 0x24FF011 VA: 0x24FEF10
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x24FF000 Offset: 0x24FF101 VA: 0x24FF000
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x24FF0D0 Offset: 0x24FF1D1 VA: 0x24FF0D0
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x24FF1A0 Offset: 0x24FF2A1 VA: 0x24FF1A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x24FF270 Offset: 0x24FF371 VA: 0x24FF270
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x24FF340 Offset: 0x24FF441 VA: 0x24FF340
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x24FF430 Offset: 0x24FF531 VA: 0x24FF430
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x24FF520 Offset: 0x24FF621 VA: 0x24FF520
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x24FF620 Offset: 0x24FF721 VA: 0x24FF620
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x24FF710 Offset: 0x24FF811 VA: 0x24FF710
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x24FF800 Offset: 0x24FF901 VA: 0x24FF800
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x24FF8F0 Offset: 0x24FF9F1 VA: 0x24FF8F0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x24FFA10 Offset: 0x24FFB11 VA: 0x24FFA10
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x24FFB10 Offset: 0x24FFC11 VA: 0x24FFB10
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x24FFC00 Offset: 0x24FFD01 VA: 0x24FFC00
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x24FFCD0 Offset: 0x24FFDD1 VA: 0x24FFCD0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x24FFDC0 Offset: 0x24FFEC1 VA: 0x24FFDC0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x24FFE90 Offset: 0x24FFF91 VA: 0x24FFE90
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x24FFF60 Offset: 0x2500061 VA: 0x24FFF60
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x2500050 Offset: 0x2500151 VA: 0x2500050
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x2500120 Offset: 0x2500221 VA: 0x2500120
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x2500210 Offset: 0x2500311 VA: 0x2500210
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x2500300 Offset: 0x2500401 VA: 0x2500300
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x25003F0 Offset: 0x25004F1 VA: 0x25003F0
	|-Array.InternalArray__get_Item<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x25004E0 Offset: 0x25005E1 VA: 0x25004E0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x25005D0 Offset: 0x25006D1 VA: 0x25005D0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x25006C0 Offset: 0x25007C1 VA: 0x25006C0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x25007B0 Offset: 0x25008B1 VA: 0x25007B0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x25008A0 Offset: 0x25009A1 VA: 0x25008A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x2500990 Offset: 0x2500A91 VA: 0x2500990
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x2500A80 Offset: 0x2500B81 VA: 0x2500A80
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x2500B70 Offset: 0x2500C71 VA: 0x2500B70
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x2500C60 Offset: 0x2500D61 VA: 0x2500C60
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x2500D50 Offset: 0x2500E51 VA: 0x2500D50
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x2500E40 Offset: 0x2500F41 VA: 0x2500E40
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x2500F60 Offset: 0x2501061 VA: 0x2500F60
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x2501050 Offset: 0x2501151 VA: 0x2501050
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x2501140 Offset: 0x2501241 VA: 0x2501140
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x2501230 Offset: 0x2501331 VA: 0x2501230
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x2501320 Offset: 0x2501421 VA: 0x2501320
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x2501410 Offset: 0x2501511 VA: 0x2501410
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x2501500 Offset: 0x2501601 VA: 0x2501500
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x25015F0 Offset: 0x25016F1 VA: 0x25015F0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x25016E0 Offset: 0x25017E1 VA: 0x25016E0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x25017D0 Offset: 0x25018D1 VA: 0x25017D0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x25018C0 Offset: 0x25019C1 VA: 0x25018C0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x25019B0 Offset: 0x2501AB1 VA: 0x25019B0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x2501AC0 Offset: 0x2501BC1 VA: 0x2501AC0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x2501BB0 Offset: 0x2501CB1 VA: 0x2501BB0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x2501CA0 Offset: 0x2501DA1 VA: 0x2501CA0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x2501D90 Offset: 0x2501E91 VA: 0x2501D90
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x2501E90 Offset: 0x2501F91 VA: 0x2501E90
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x2501F80 Offset: 0x2502081 VA: 0x2501F80
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x2502080 Offset: 0x2502181 VA: 0x2502080
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x2502170 Offset: 0x2502271 VA: 0x2502170
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x2502280 Offset: 0x2502381 VA: 0x2502280
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x2502370 Offset: 0x2502471 VA: 0x2502370
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x2502460 Offset: 0x2502561 VA: 0x2502460
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x2502550 Offset: 0x2502651 VA: 0x2502550
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x2502640 Offset: 0x2502741 VA: 0x2502640
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x2502730 Offset: 0x2502831 VA: 0x2502730
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x2502820 Offset: 0x2502921 VA: 0x2502820
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x2502910 Offset: 0x2502A11 VA: 0x2502910
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x2502A00 Offset: 0x2502B01 VA: 0x2502A00
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x2502AF0 Offset: 0x2502BF1 VA: 0x2502AF0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x2502BE0 Offset: 0x2502CE1 VA: 0x2502BE0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x2502CD0 Offset: 0x2502DD1 VA: 0x2502CD0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x2502DC0 Offset: 0x2502EC1 VA: 0x2502DC0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x2502EB0 Offset: 0x2502FB1 VA: 0x2502EB0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x2502FA0 Offset: 0x25030A1 VA: 0x2502FA0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x2503090 Offset: 0x2503191 VA: 0x2503090
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x2503180 Offset: 0x2503281 VA: 0x2503180
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x2503270 Offset: 0x2503371 VA: 0x2503270
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x2503360 Offset: 0x2503461 VA: 0x2503360
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x2503450 Offset: 0x2503551 VA: 0x2503450
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x2503540 Offset: 0x2503641 VA: 0x2503540
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x2503660 Offset: 0x2503761 VA: 0x2503660
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x2503750 Offset: 0x2503851 VA: 0x2503750
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x2503840 Offset: 0x2503941 VA: 0x2503840
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x2503930 Offset: 0x2503A31 VA: 0x2503930
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x2503A20 Offset: 0x2503B21 VA: 0x2503A20
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x2503B10 Offset: 0x2503C11 VA: 0x2503B10
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x2503C00 Offset: 0x2503D01 VA: 0x2503C00
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x2503CF0 Offset: 0x2503DF1 VA: 0x2503CF0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x2503DE0 Offset: 0x2503EE1 VA: 0x2503DE0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x2503ED0 Offset: 0x2503FD1 VA: 0x2503ED0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x2503FC0 Offset: 0x25040C1 VA: 0x2503FC0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x25040B0 Offset: 0x25041B1 VA: 0x25040B0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x25041A0 Offset: 0x25042A1 VA: 0x25041A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x2504290 Offset: 0x2504391 VA: 0x2504290
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x2504380 Offset: 0x2504481 VA: 0x2504380
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x2504470 Offset: 0x2504571 VA: 0x2504470
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x2504560 Offset: 0x2504661 VA: 0x2504560
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x2504650 Offset: 0x2504751 VA: 0x2504650
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x2504740 Offset: 0x2504841 VA: 0x2504740
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x2504830 Offset: 0x2504931 VA: 0x2504830
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x2504920 Offset: 0x2504A21 VA: 0x2504920
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x2504A10 Offset: 0x2504B11 VA: 0x2504A10
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x2504B00 Offset: 0x2504C01 VA: 0x2504B00
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x2504BF0 Offset: 0x2504CF1 VA: 0x2504BF0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x2504CE0 Offset: 0x2504DE1 VA: 0x2504CE0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x2504DD0 Offset: 0x2504ED1 VA: 0x2504DD0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x2504EC0 Offset: 0x2504FC1 VA: 0x2504EC0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x2504FD0 Offset: 0x25050D1 VA: 0x2504FD0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x25050C0 Offset: 0x25051C1 VA: 0x25050C0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x25051B0 Offset: 0x25052B1 VA: 0x25051B0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x25052A0 Offset: 0x25053A1 VA: 0x25052A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x2505390 Offset: 0x2505491 VA: 0x2505390
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x2505480 Offset: 0x2505581 VA: 0x2505480
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2505570 Offset: 0x2505671 VA: 0x2505570
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2505660 Offset: 0x2505761 VA: 0x2505660
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x2505750 Offset: 0x2505851 VA: 0x2505750
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x2505840 Offset: 0x2505941 VA: 0x2505840
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x2505930 Offset: 0x2505A31 VA: 0x2505930
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x2505A20 Offset: 0x2505B21 VA: 0x2505A20
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x2505B10 Offset: 0x2505C11 VA: 0x2505B10
	|-Array.InternalArray__get_Item<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x2505C00 Offset: 0x2505D01 VA: 0x2505C00
	|-Array.InternalArray__get_Item<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x2505CF0 Offset: 0x2505DF1 VA: 0x2505CF0
	|-Array.InternalArray__get_Item<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x2505DE0 Offset: 0x2505EE1 VA: 0x2505DE0
	|-Array.InternalArray__get_Item<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x2505F00 Offset: 0x2506001 VA: 0x2505F00
	|-Array.InternalArray__get_Item<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x2505FF0 Offset: 0x25060F1 VA: 0x2505FF0
	|-Array.InternalArray__get_Item<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x25060E0 Offset: 0x25061E1 VA: 0x25060E0
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x25061B0 Offset: 0x25062B1 VA: 0x25061B0
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x2506280 Offset: 0x2506381 VA: 0x2506280
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x2506370 Offset: 0x2506471 VA: 0x2506370
	|-Array.InternalArray__get_Item<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x2506460 Offset: 0x2506561 VA: 0x2506460
	|-Array.InternalArray__get_Item<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x2506550 Offset: 0x2506651 VA: 0x2506550
	|-Array.InternalArray__get_Item<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x2506650 Offset: 0x2506751 VA: 0x2506650
	|-Array.InternalArray__get_Item<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x2506750 Offset: 0x2506851 VA: 0x2506750
	|-Array.InternalArray__get_Item<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x2506840 Offset: 0x2506941 VA: 0x2506840
	|-Array.InternalArray__get_Item<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x2506930 Offset: 0x2506A31 VA: 0x2506930
	|-Array.InternalArray__get_Item<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x2506A20 Offset: 0x2506B21 VA: 0x2506A20
	|-Array.InternalArray__get_Item<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x2506B10 Offset: 0x2506C11 VA: 0x2506B10
	|-Array.InternalArray__get_Item<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x2506C00 Offset: 0x2506D01 VA: 0x2506C00
	|-Array.InternalArray__get_Item<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x2506CF0 Offset: 0x2506DF1 VA: 0x2506CF0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x2506DE0 Offset: 0x2506EE1 VA: 0x2506DE0
	|-Array.InternalArray__get_Item<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2506ED0 Offset: 0x2506FD1 VA: 0x2506ED0
	|-Array.InternalArray__get_Item<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x2506FC0 Offset: 0x25070C1 VA: 0x2506FC0
	|-Array.InternalArray__get_Item<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x25070B0 Offset: 0x25071B1 VA: 0x25070B0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x25071A0 Offset: 0x25072A1 VA: 0x25071A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x2507290 Offset: 0x2507391 VA: 0x2507290
	|-Array.InternalArray__get_Item<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x25073A0 Offset: 0x25074A1 VA: 0x25073A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x2507490 Offset: 0x2507591 VA: 0x2507490
	|-Array.InternalArray__get_Item<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x2507580 Offset: 0x2507681 VA: 0x2507580
	|-Array.InternalArray__get_Item<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x2507670 Offset: 0x2507771 VA: 0x2507670
	|-Array.InternalArray__get_Item<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x2507760 Offset: 0x2507861 VA: 0x2507760
	|-Array.InternalArray__get_Item<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x2507850 Offset: 0x2507951 VA: 0x2507850
	|-Array.InternalArray__get_Item<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x2507940 Offset: 0x2507A41 VA: 0x2507940
	|-Array.InternalArray__get_Item<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x2507A30 Offset: 0x2507B31 VA: 0x2507A30
	|-Array.InternalArray__get_Item<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x2507B20 Offset: 0x2507C21 VA: 0x2507B20
	|-Array.InternalArray__get_Item<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x2507C10 Offset: 0x2507D11 VA: 0x2507C10
	|-Array.InternalArray__get_Item<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x2507D00 Offset: 0x2507E01 VA: 0x2507D00
	|-Array.InternalArray__get_Item<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x2507DF0 Offset: 0x2507EF1 VA: 0x2507DF0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x2507EE0 Offset: 0x2507FE1 VA: 0x2507EE0
	|-Array.InternalArray__get_Item<HashSet.Slot<int>>
	|
	|-RVA: 0x2507FC0 Offset: 0x25080C1 VA: 0x2507FC0
	|-Array.InternalArray__get_Item<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x25080A0 Offset: 0x25081A1 VA: 0x25080A0
	|-Array.InternalArray__get_Item<HashSet.Slot<object>>
	|
	|-RVA: 0x2508170 Offset: 0x2508271 VA: 0x2508170
	|-Array.InternalArray__get_Item<HashSet.Slot<uint>>
	|
	|-RVA: 0x2508250 Offset: 0x2508351 VA: 0x2508250
	|-Array.InternalArray__get_Item<HashSet.Slot<Edge>>
	|
	|-RVA: 0x2508320 Offset: 0x2508421 VA: 0x2508320
	|-Array.InternalArray__get_Item<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x2508410 Offset: 0x2508511 VA: 0x2508410
	|-Array.InternalArray__get_Item<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x2508500 Offset: 0x2508601 VA: 0x2508500
	|-Array.InternalArray__get_Item<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x25085D0 Offset: 0x25086D1 VA: 0x25085D0
	|-Array.InternalArray__get_Item<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x25086C0 Offset: 0x25087C1 VA: 0x25086C0
	|-Array.InternalArray__get_Item<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x25087C0 Offset: 0x25088C1 VA: 0x25087C0
	|-Array.InternalArray__get_Item<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x25088B0 Offset: 0x25089B1 VA: 0x25088B0
	|-Array.InternalArray__get_Item<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x25089A0 Offset: 0x2508AA1 VA: 0x25089A0
	|-Array.InternalArray__get_Item<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x2508A90 Offset: 0x2508B91 VA: 0x2508A90
	|-Array.InternalArray__get_Item<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x2508B80 Offset: 0x2508C81 VA: 0x2508B80
	|-Array.InternalArray__get_Item<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x2508C70 Offset: 0x2508D71 VA: 0x2508C70
	|-Array.InternalArray__get_Item<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x2508D60 Offset: 0x2508E61 VA: 0x2508D60
	|-Array.InternalArray__get_Item<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x2508E50 Offset: 0x2508F51 VA: 0x2508E50
	|-Array.InternalArray__get_Item<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x2508F60 Offset: 0x2509061 VA: 0x2508F60
	|-Array.InternalArray__get_Item<KeyValuePair<bool, object>>
	|
	|-RVA: 0x2509030 Offset: 0x2509131 VA: 0x2509030
	|-Array.InternalArray__get_Item<KeyValuePair<byte, object>>
	|
	|-RVA: 0x2509100 Offset: 0x2509201 VA: 0x2509100
	|-Array.InternalArray__get_Item<KeyValuePair<char, object>>
	|
	|-RVA: 0x25091D0 Offset: 0x25092D1 VA: 0x25091D0
	|-Array.InternalArray__get_Item<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x25092A0 Offset: 0x25093A1 VA: 0x25092A0
	|-Array.InternalArray__get_Item<KeyValuePair<double, object>>
	|
	|-RVA: 0x2509370 Offset: 0x2509471 VA: 0x2509370
	|-Array.InternalArray__get_Item<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x2509460 Offset: 0x2509561 VA: 0x2509460
	|-Array.InternalArray__get_Item<KeyValuePair<short, object>>
	|
	|-RVA: 0x2509530 Offset: 0x2509631 VA: 0x2509530
	|-Array.InternalArray__get_Item<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x2509660 Offset: 0x2509761 VA: 0x2509660
	|-Array.InternalArray__get_Item<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x2509750 Offset: 0x2509851 VA: 0x2509750
	|-Array.InternalArray__get_Item<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x2509820 Offset: 0x2509921 VA: 0x2509820
	|-Array.InternalArray__get_Item<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x2509930 Offset: 0x2509A31 VA: 0x2509930
	|-Array.InternalArray__get_Item<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x2509A20 Offset: 0x2509B21 VA: 0x2509A20
	|-Array.InternalArray__get_Item<KeyValuePair<int, bool>>
	|
	|-RVA: 0x2509AF0 Offset: 0x2509BF1 VA: 0x2509AF0
	|-Array.InternalArray__get_Item<KeyValuePair<int, char>>
	|
	|-RVA: 0x2509BC0 Offset: 0x2509CC1 VA: 0x2509BC0
	|-Array.InternalArray__get_Item<KeyValuePair<int, int>>
	|
	|-RVA: 0x2509C90 Offset: 0x2509D91 VA: 0x2509C90
	|-Array.InternalArray__get_Item<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x2509D60 Offset: 0x2509E61 VA: 0x2509D60
	|-Array.InternalArray__get_Item<KeyValuePair<int, long>>
	|
	|-RVA: 0x2509E30 Offset: 0x2509F31 VA: 0x2509E30
	|-Array.InternalArray__get_Item<KeyValuePair<int, object>>
	|
	|-RVA: 0x2509F00 Offset: 0x250A001 VA: 0x2509F00
	|-Array.InternalArray__get_Item<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x250A000 Offset: 0x250A101 VA: 0x250A000
	|-Array.InternalArray__get_Item<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x250A0F0 Offset: 0x250A1F1 VA: 0x250A0F0
	|-Array.InternalArray__get_Item<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x250A1D0 Offset: 0x250A2D1 VA: 0x250A1D0
	|-Array.InternalArray__get_Item<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x250A2A0 Offset: 0x250A3A1 VA: 0x250A2A0
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x250A3B0 Offset: 0x250A4B1 VA: 0x250A3B0
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x250A4B0 Offset: 0x250A5B1 VA: 0x250A4B0
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x250A5A0 Offset: 0x250A6A1 VA: 0x250A5A0
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x250A670 Offset: 0x250A771 VA: 0x250A670
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x250A750 Offset: 0x250A851 VA: 0x250A750
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x250A820 Offset: 0x250A921 VA: 0x250A820
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x250A8F0 Offset: 0x250A9F1 VA: 0x250A8F0
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x250A9C0 Offset: 0x250AAC1 VA: 0x250A9C0
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x250AA90 Offset: 0x250AB91 VA: 0x250AA90
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x250AB80 Offset: 0x250AC81 VA: 0x250AB80
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x250AC60 Offset: 0x250AD61 VA: 0x250AC60
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x250AD30 Offset: 0x250AE31 VA: 0x250AD30
	|-Array.InternalArray__get_Item<KeyValuePair<long, object>>
	|
	|-RVA: 0x250AE00 Offset: 0x250AF01 VA: 0x250AE00
	|-Array.InternalArray__get_Item<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x250AEF0 Offset: 0x250AFF1 VA: 0x250AEF0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x250AFC0 Offset: 0x250B0C1 VA: 0x250AFC0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x250B0B0 Offset: 0x250B1B1 VA: 0x250B0B0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x250B1A0 Offset: 0x250B2A1 VA: 0x250B1A0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x250B270 Offset: 0x250B371 VA: 0x250B270
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x250B360 Offset: 0x250B461 VA: 0x250B360
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x250B450 Offset: 0x250B551 VA: 0x250B450
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x250B540 Offset: 0x250B641 VA: 0x250B540
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x250B630 Offset: 0x250B731 VA: 0x250B630
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x250B700 Offset: 0x250B801 VA: 0x250B700
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x250B810 Offset: 0x250B911 VA: 0x250B810
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x250B900 Offset: 0x250BA01 VA: 0x250B900
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x250B9F0 Offset: 0x250BAF1 VA: 0x250B9F0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x250BAE0 Offset: 0x250BBE1 VA: 0x250BAE0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x250BBD0 Offset: 0x250BCD1 VA: 0x250BBD0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x250BCC0 Offset: 0x250BDC1 VA: 0x250BCC0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x250BDB0 Offset: 0x250BEB1 VA: 0x250BDB0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x250BEA0 Offset: 0x250BFA1 VA: 0x250BEA0
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x250BF90 Offset: 0x250C091 VA: 0x250BF90
	|-Array.InternalArray__get_Item<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x250C080 Offset: 0x250C181 VA: 0x250C080
	|-Array.InternalArray__get_Item<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x250C150 Offset: 0x250C251 VA: 0x250C150
	|-Array.InternalArray__get_Item<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x250C240 Offset: 0x250C341 VA: 0x250C240
	|-Array.InternalArray__get_Item<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x250C340 Offset: 0x250C441 VA: 0x250C340
	|-Array.InternalArray__get_Item<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x250C430 Offset: 0x250C531 VA: 0x250C430
	|-Array.InternalArray__get_Item<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x250C520 Offset: 0x250C621 VA: 0x250C520
	|-Array.InternalArray__get_Item<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x250C610 Offset: 0x250C711 VA: 0x250C610
	|-Array.InternalArray__get_Item<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x250C700 Offset: 0x250C801 VA: 0x250C700
	|-Array.InternalArray__get_Item<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x250C7F0 Offset: 0x250C8F1 VA: 0x250C7F0
	|-Array.InternalArray__get_Item<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x250C8E0 Offset: 0x250C9E1 VA: 0x250C8E0
	|-Array.InternalArray__get_Item<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x250C9D0 Offset: 0x250CAD1 VA: 0x250C9D0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x250CAE0 Offset: 0x250CBE1 VA: 0x250CAE0
	|-Array.InternalArray__get_Item<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x250CBD0 Offset: 0x250CCD1 VA: 0x250CBD0
	|-Array.InternalArray__get_Item<KeyValuePair<object, bool>>
	|
	|-RVA: 0x250CCA0 Offset: 0x250CDA1 VA: 0x250CCA0
	|-Array.InternalArray__get_Item<KeyValuePair<object, byte>>
	|
	|-RVA: 0x250CD70 Offset: 0x250CE71 VA: 0x250CD70
	|-Array.InternalArray__get_Item<KeyValuePair<object, char>>
	|
	|-RVA: 0x250CE40 Offset: 0x250CF41 VA: 0x250CE40
	|-Array.InternalArray__get_Item<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x250CF10 Offset: 0x250D011 VA: 0x250CF10
	|-Array.InternalArray__get_Item<KeyValuePair<object, double>>
	|
	|-RVA: 0x250CFE0 Offset: 0x250D0E1 VA: 0x250CFE0
	|-Array.InternalArray__get_Item<KeyValuePair<object, short>>
	|
	|-RVA: 0x250D0B0 Offset: 0x250D1B1 VA: 0x250D0B0
	|-Array.InternalArray__get_Item<KeyValuePair<object, int>>
	|
	|-RVA: 0x250D180 Offset: 0x250D281 VA: 0x250D180
	|-Array.InternalArray__get_Item<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x250D250 Offset: 0x250D351 VA: 0x250D250
	|-Array.InternalArray__get_Item<KeyValuePair<object, long>>
	|
	|-RVA: 0x250D320 Offset: 0x250D421 VA: 0x250D320
	|-Array.InternalArray__get_Item<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x250D410 Offset: 0x250D511 VA: 0x250D410
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x250D4E0 Offset: 0x250D5E1 VA: 0x250D4E0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x250D5D0 Offset: 0x250D6D1 VA: 0x250D5D0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x250D6C0 Offset: 0x250D7C1 VA: 0x250D6C0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x250D790 Offset: 0x250D891 VA: 0x250D790
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x250D880 Offset: 0x250D981 VA: 0x250D880
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x250D970 Offset: 0x250DA71 VA: 0x250D970
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x250DA60 Offset: 0x250DB61 VA: 0x250DA60
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x250DB50 Offset: 0x250DC51 VA: 0x250DB50
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x250DC20 Offset: 0x250DD21 VA: 0x250DC20
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x250DD30 Offset: 0x250DE31 VA: 0x250DD30
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x250DE20 Offset: 0x250DF21 VA: 0x250DE20
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x250DF10 Offset: 0x250E011 VA: 0x250DF10
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x250E000 Offset: 0x250E101 VA: 0x250E000
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x250E0F0 Offset: 0x250E1F1 VA: 0x250E0F0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x250E1E0 Offset: 0x250E2E1 VA: 0x250E1E0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x250E2D0 Offset: 0x250E3D1 VA: 0x250E2D0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x250E3C0 Offset: 0x250E4C1 VA: 0x250E3C0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x250E4B0 Offset: 0x250E5B1 VA: 0x250E4B0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x250E5A0 Offset: 0x250E6A1 VA: 0x250E5A0
	|-Array.InternalArray__get_Item<KeyValuePair<object, object>>
	|
	|-RVA: 0x250E670 Offset: 0x250E771 VA: 0x250E670
	|-Array.InternalArray__get_Item<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x250E760 Offset: 0x250E861 VA: 0x250E760
	|-Array.InternalArray__get_Item<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x250E850 Offset: 0x250E951 VA: 0x250E850
	|-Array.InternalArray__get_Item<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x250E920 Offset: 0x250EA21 VA: 0x250E920
	|-Array.InternalArray__get_Item<KeyValuePair<object, float>>
	|
	|-RVA: 0x250E9F0 Offset: 0x250EAF1 VA: 0x250E9F0
	|-Array.InternalArray__get_Item<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x250EAC0 Offset: 0x250EBC1 VA: 0x250EAC0
	|-Array.InternalArray__get_Item<KeyValuePair<object, uint>>
	|
	|-RVA: 0x250EB90 Offset: 0x250EC91 VA: 0x250EB90
	|-Array.InternalArray__get_Item<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x250EC60 Offset: 0x250ED61 VA: 0x250EC60
	|-Array.InternalArray__get_Item<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x250ED50 Offset: 0x250EE51 VA: 0x250ED50
	|-Array.InternalArray__get_Item<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x250EE40 Offset: 0x250EF41 VA: 0x250EE40
	|-Array.InternalArray__get_Item<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x250EF30 Offset: 0x250F031 VA: 0x250EF30
	|-Array.InternalArray__get_Item<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x250F000 Offset: 0x250F101 VA: 0x250F000
	|-Array.InternalArray__get_Item<KeyValuePair<object, Color>>
	|
	|-RVA: 0x250F0F0 Offset: 0x250F1F1 VA: 0x250F0F0
	|-Array.InternalArray__get_Item<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x250F1C0 Offset: 0x250F2C1 VA: 0x250F1C0
	|-Array.InternalArray__get_Item<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x250F2B0 Offset: 0x250F3B1 VA: 0x250F2B0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x250F3A0 Offset: 0x250F4A1 VA: 0x250F3A0
	|-Array.InternalArray__get_Item<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x250F470 Offset: 0x250F571 VA: 0x250F470
	|-Array.InternalArray__get_Item<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x250F580 Offset: 0x250F681 VA: 0x250F580
	|-Array.InternalArray__get_Item<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x250F670 Offset: 0x250F771 VA: 0x250F670
	|-Array.InternalArray__get_Item<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x250F760 Offset: 0x250F861 VA: 0x250F760
	|-Array.InternalArray__get_Item<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x250F830 Offset: 0x250F931 VA: 0x250F830
	|-Array.InternalArray__get_Item<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x250F920 Offset: 0x250FA21 VA: 0x250F920
	|-Array.InternalArray__get_Item<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x250FA10 Offset: 0x250FB11 VA: 0x250FA10
	|-Array.InternalArray__get_Item<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x250FB00 Offset: 0x250FC01 VA: 0x250FB00
	|-Array.InternalArray__get_Item<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x250FBF0 Offset: 0x250FCF1 VA: 0x250FBF0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x250FCC0 Offset: 0x250FDC1 VA: 0x250FCC0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x250FD90 Offset: 0x250FE91 VA: 0x250FD90
	|-Array.InternalArray__get_Item<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x250FE80 Offset: 0x250FF81 VA: 0x250FE80
	|-Array.InternalArray__get_Item<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x250FF70 Offset: 0x2510071 VA: 0x250FF70
	|-Array.InternalArray__get_Item<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x2510060 Offset: 0x2510161 VA: 0x2510060
	|-Array.InternalArray__get_Item<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x2510150 Offset: 0x2510251 VA: 0x2510150
	|-Array.InternalArray__get_Item<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x2510220 Offset: 0x2510321 VA: 0x2510220
	|-Array.InternalArray__get_Item<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x25102F0 Offset: 0x25103F1 VA: 0x25102F0
	|-Array.InternalArray__get_Item<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x2510410 Offset: 0x2510511 VA: 0x2510410
	|-Array.InternalArray__get_Item<KeyValuePair<float, object>>
	|
	|-RVA: 0x25104E0 Offset: 0x25105E1 VA: 0x25104E0
	|-Array.InternalArray__get_Item<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x25105B0 Offset: 0x25106B1 VA: 0x25105B0
	|-Array.InternalArray__get_Item<KeyValuePair<uint, int>>
	|
	|-RVA: 0x2510680 Offset: 0x2510781 VA: 0x2510680
	|-Array.InternalArray__get_Item<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x2510750 Offset: 0x2510851 VA: 0x2510750
	|-Array.InternalArray__get_Item<KeyValuePair<uint, object>>
	|
	|-RVA: 0x2510820 Offset: 0x2510921 VA: 0x2510820
	|-Array.InternalArray__get_Item<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x25108F0 Offset: 0x25109F1 VA: 0x25108F0
	|-Array.InternalArray__get_Item<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x25109D0 Offset: 0x2510AD1 VA: 0x25109D0
	|-Array.InternalArray__get_Item<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x2510AD0 Offset: 0x2510BD1 VA: 0x2510AD0
	|-Array.InternalArray__get_Item<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x2510BD0 Offset: 0x2510CD1 VA: 0x2510BD0
	|-Array.InternalArray__get_Item<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x2510CC0 Offset: 0x2510DC1 VA: 0x2510CC0
	|-Array.InternalArray__get_Item<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x2510DA0 Offset: 0x2510EA1 VA: 0x2510DA0
	|-Array.InternalArray__get_Item<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x2510E70 Offset: 0x2510F71 VA: 0x2510E70
	|-Array.InternalArray__get_Item<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x2510F60 Offset: 0x2511061 VA: 0x2510F60
	|-Array.InternalArray__get_Item<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x2511050 Offset: 0x2511151 VA: 0x2511050
	|-Array.InternalArray__get_Item<KeyValuePair<Color, object>>
	|
	|-RVA: 0x2511140 Offset: 0x2511241 VA: 0x2511140
	|-Array.InternalArray__get_Item<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x2511210 Offset: 0x2511311 VA: 0x2511210
	|-Array.InternalArray__get_Item<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x25112E0 Offset: 0x25113E1 VA: 0x25112E0
	|-Array.InternalArray__get_Item<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x25113B0 Offset: 0x25114B1 VA: 0x25113B0
	|-Array.InternalArray__get_Item<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x25114A0 Offset: 0x25115A1 VA: 0x25114A0
	|-Array.InternalArray__get_Item<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x2511590 Offset: 0x2511691 VA: 0x2511590
	|-Array.InternalArray__get_Item<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x2511660 Offset: 0x2511761 VA: 0x2511660
	|-Array.InternalArray__get_Item<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x2511770 Offset: 0x2511871 VA: 0x2511770
	|-Array.InternalArray__get_Item<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x2511860 Offset: 0x2511961 VA: 0x2511860
	|-Array.InternalArray__get_Item<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x2511950 Offset: 0x2511A51 VA: 0x2511950
	|-Array.InternalArray__get_Item<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x2511A20 Offset: 0x2511B21 VA: 0x2511A20
	|-Array.InternalArray__get_Item<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x2511B10 Offset: 0x2511C11 VA: 0x2511B10
	|-Array.InternalArray__get_Item<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x2511C00 Offset: 0x2511D01 VA: 0x2511C00
	|-Array.InternalArray__get_Item<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x2511CE0 Offset: 0x2511DE1 VA: 0x2511CE0
	|-Array.InternalArray__get_Item<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x2511DB0 Offset: 0x2511EB1 VA: 0x2511DB0
	|-Array.InternalArray__get_Item<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x2511E80 Offset: 0x2511F81 VA: 0x2511E80
	|-Array.InternalArray__get_Item<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x2511F50 Offset: 0x2512051 VA: 0x2511F50
	|-Array.InternalArray__get_Item<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x2512040 Offset: 0x2512141 VA: 0x2512040
	|-Array.InternalArray__get_Item<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x2512130 Offset: 0x2512231 VA: 0x2512130
	|-Array.InternalArray__get_Item<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x2512220 Offset: 0x2512321 VA: 0x2512220
	|-Array.InternalArray__get_Item<Hashtable.bucket>
	|
	|-RVA: 0x2512310 Offset: 0x2512411 VA: 0x2512310
	|-Array.InternalArray__get_Item<DateTime>
	|
	|-RVA: 0x25123E0 Offset: 0x25124E1 VA: 0x25123E0
	|-Array.InternalArray__get_Item<DateTimeOffset>
	|
	|-RVA: 0x25124B0 Offset: 0x25125B1 VA: 0x25124B0
	|-Array.InternalArray__get_Item<Decimal>
	|
	|-RVA: 0x2512580 Offset: 0x2512681 VA: 0x2512580
	|-Array.InternalArray__get_Item<double>
	|
	|-RVA: 0x2512650 Offset: 0x2512751 VA: 0x2512650
	|-Array.InternalArray__get_Item<InternalCodePageDataItem>
	|
	|-RVA: 0x2512720 Offset: 0x2512821 VA: 0x2512720
	|-Array.InternalArray__get_Item<InternalEncodingDataItem>
	|
	|-RVA: 0x25127F0 Offset: 0x25128F1 VA: 0x25127F0
	|-Array.InternalArray__get_Item<Guid>
	|
	|-RVA: 0x25128C0 Offset: 0x25129C1 VA: 0x25128C0
	|-Array.InternalArray__get_Item<short>
	|
	|-RVA: 0x2512990 Offset: 0x2512A91 VA: 0x2512990
	|-Array.InternalArray__get_Item<int>
	|
	|-RVA: 0x2512A60 Offset: 0x2512B61 VA: 0x2512A60
	|-Array.InternalArray__get_Item<Int32Enum>
	|
	|-RVA: 0x2512B30 Offset: 0x2512C31 VA: 0x2512B30
	|-Array.InternalArray__get_Item<long>
	|
	|-RVA: 0x2512C00 Offset: 0x2512D01 VA: 0x2512C00
	|-Array.InternalArray__get_Item<IntPtr>
	|
	|-RVA: 0x2512CD0 Offset: 0x2512DD1 VA: 0x2512CD0
	|-Array.InternalArray__get_Item<InterpretedFrameInfo>
	|
	|-RVA: 0x2512DA0 Offset: 0x2512EA1 VA: 0x2512DA0
	|-Array.InternalArray__get_Item<LocalDefinition>
	|
	|-RVA: 0x2512E70 Offset: 0x2512F71 VA: 0x2512E70
	|-Array.InternalArray__get_Item<RuntimeLabel>
	|
	|-RVA: 0x2512F50 Offset: 0x2513051 VA: 0x2512F50
	|-Array.InternalArray__get_Item<Set.Slot<int>>
	|
	|-RVA: 0x2513030 Offset: 0x2513131 VA: 0x2513030
	|-Array.InternalArray__get_Item<Set.Slot<object>>
	|
	|-RVA: 0x2513120 Offset: 0x2513221 VA: 0x2513120
	|-Array.InternalArray__get_Item<Memory<object>>
	|
	|-RVA: 0x25131F0 Offset: 0x25132F1 VA: 0x25131F0
	|-Array.InternalArray__get_Item<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x25132C0 Offset: 0x25133C1 VA: 0x25132C0
	|-Array.InternalArray__get_Item<HeaderVariantInfo>
	|
	|-RVA: 0x2513390 Offset: 0x2513491 VA: 0x2513390
	|-Array.InternalArray__get_Item<Socket.WSABUF>
	|
	|-RVA: 0x2513460 Offset: 0x2513561 VA: 0x2513460
	|-Array.InternalArray__get_Item<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x2513550 Offset: 0x2513651 VA: 0x2513550
	|-Array.InternalArray__get_Item<Nullable<Int32Enum>>
	|
	|-RVA: 0x2513620 Offset: 0x2513721 VA: 0x2513620
	|-Array.InternalArray__get_Item<Nullable<Bounds>>
	|
	|-RVA: 0x2513710 Offset: 0x2513811 VA: 0x2513710
	|-Array.InternalArray__get_Item<Nullable<BoundsInt>>
	|
	|-RVA: 0x2513800 Offset: 0x2513901 VA: 0x2513800
	|-Array.InternalArray__get_Item<Nullable<Color32>>
	|
	|-RVA: 0x25138D0 Offset: 0x25139D1 VA: 0x25138D0
	|-Array.InternalArray__get_Item<Nullable<Color>>
	|
	|-RVA: 0x25139C0 Offset: 0x2513AC1 VA: 0x25139C0
	|-Array.InternalArray__get_Item<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2513AA0 Offset: 0x2513BA1 VA: 0x2513AA0
	|-Array.InternalArray__get_Item<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2513B90 Offset: 0x2513C91 VA: 0x2513B90
	|-Array.InternalArray__get_Item<Nullable<Keyframe>>
	|
	|-RVA: 0x2513C80 Offset: 0x2513D81 VA: 0x2513C80
	|-Array.InternalArray__get_Item<Nullable<LayerMask>>
	|
	|-RVA: 0x2513D50 Offset: 0x2513E51 VA: 0x2513D50
	|-Array.InternalArray__get_Item<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2513E60 Offset: 0x2513F61 VA: 0x2513E60
	|-Array.InternalArray__get_Item<Nullable<Quaternion>>
	|
	|-RVA: 0x2513F50 Offset: 0x2514051 VA: 0x2513F50
	|-Array.InternalArray__get_Item<Nullable<RangeInt>>
	|
	|-RVA: 0x2514030 Offset: 0x2514131 VA: 0x2514030
	|-Array.InternalArray__get_Item<Nullable<Rect>>
	|
	|-RVA: 0x2514120 Offset: 0x2514221 VA: 0x2514120
	|-Array.InternalArray__get_Item<Nullable<RectInt>>
	|
	|-RVA: 0x2514210 Offset: 0x2514311 VA: 0x2514210
	|-Array.InternalArray__get_Item<Nullable<Vector2>>
	|
	|-RVA: 0x25142F0 Offset: 0x25143F1 VA: 0x25142F0
	|-Array.InternalArray__get_Item<Nullable<Vector2Int>>
	|
	|-RVA: 0x25143D0 Offset: 0x25144D1 VA: 0x25143D0
	|-Array.InternalArray__get_Item<Nullable<Vector3>>
	|
	|-RVA: 0x25144A0 Offset: 0x25145A1 VA: 0x25144A0
	|-Array.InternalArray__get_Item<Nullable<Vector3Int>>
	|
	|-RVA: 0x2514570 Offset: 0x2514671 VA: 0x2514570
	|-Array.InternalArray__get_Item<Nullable<Vector4>>
	|
	|-RVA: 0x2514660 Offset: 0x2514761 VA: 0x2514660
	|-Array.InternalArray__get_Item<object>
	|
	|-RVA: 0x2514730 Offset: 0x2514831 VA: 0x2514730
	|-Array.InternalArray__get_Item<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x2514800 Offset: 0x2514901 VA: 0x2514800
	|-Array.InternalArray__get_Item<ReadOnlyMemory<object>>
	|
	|-RVA: 0x25148D0 Offset: 0x25149D1 VA: 0x25148D0
	|-Array.InternalArray__get_Item<CustomAttributeNamedArgument>
	|
	|-RVA: 0x25149C0 Offset: 0x2514AC1 VA: 0x25149C0
	|-Array.InternalArray__get_Item<CustomAttributeTypedArgument>
	|
	|-RVA: 0x2514A90 Offset: 0x2514B91 VA: 0x2514A90
	|-Array.InternalArray__get_Item<Label>
	|
	|-RVA: 0x2514B60 Offset: 0x2514C61 VA: 0x2514B60
	|-Array.InternalArray__get_Item<ParameterModifier>
	|
	|-RVA: 0x2514C30 Offset: 0x2514D31 VA: 0x2514C30
	|-Array.InternalArray__get_Item<ResourceLocator>
	|
	|-RVA: 0x2514D00 Offset: 0x2514E01 VA: 0x2514D00
	|-Array.InternalArray__get_Item<Ephemeron>
	|
	|-RVA: 0x2514DD0 Offset: 0x2514ED1 VA: 0x2514DD0
	|-Array.InternalArray__get_Item<GCHandle>
	|
	|-RVA: 0x2514EA0 Offset: 0x2514FA1 VA: 0x2514EA0
	|-Array.InternalArray__get_Item<RuntimeTypeHandle>
	|
	|-RVA: 0x2514F70 Offset: 0x2515071 VA: 0x2514F70
	|-Array.InternalArray__get_Item<sbyte>
	|
	|-RVA: 0x2515040 Offset: 0x2515141 VA: 0x2515040
	|-Array.InternalArray__get_Item<X509ChainStatus>
	|
	|-RVA: 0x2515110 Offset: 0x2515211 VA: 0x2515110
	|-Array.InternalArray__get_Item<float>
	|
	|-RVA: 0x25151E0 Offset: 0x25152E1 VA: 0x25151E0
	|-Array.InternalArray__get_Item<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x25152C0 Offset: 0x25153C1 VA: 0x25152C0
	|-Array.InternalArray__get_Item<CancellationTokenRegistration>
	|
	|-RVA: 0x25153B0 Offset: 0x25154B1 VA: 0x25153B0
	|-Array.InternalArray__get_Item<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x2515480 Offset: 0x2515581 VA: 0x2515480
	|-Array.InternalArray__get_Item<TimeSpan>
	|
	|-RVA: 0x2515550 Offset: 0x2515651 VA: 0x2515550
	|-Array.InternalArray__get_Item<ushort>
	|
	|-RVA: 0x2515620 Offset: 0x2515721 VA: 0x2515620
	|-Array.InternalArray__get_Item<UInt16Enum>
	|
	|-RVA: 0x25156F0 Offset: 0x25157F1 VA: 0x25156F0
	|-Array.InternalArray__get_Item<uint>
	|
	|-RVA: 0x25157C0 Offset: 0x25158C1 VA: 0x25157C0
	|-Array.InternalArray__get_Item<UInt32Enum>
	|
	|-RVA: 0x2515890 Offset: 0x2515991 VA: 0x2515890
	|-Array.InternalArray__get_Item<ulong>
	|
	|-RVA: 0x2515960 Offset: 0x2515A61 VA: 0x2515960
	|-Array.InternalArray__get_Item<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x2515A30 Offset: 0x2515B31 VA: 0x2515A30
	|-Array.InternalArray__get_Item<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2515B00 Offset: 0x2515C01 VA: 0x2515B00
	|-Array.InternalArray__get_Item<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x2515BD0 Offset: 0x2515CD1 VA: 0x2515BD0
	|-Array.InternalArray__get_Item<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x2515CA0 Offset: 0x2515DA1 VA: 0x2515CA0
	|-Array.InternalArray__get_Item<ValueTuple<object, object>>
	|
	|-RVA: 0x2515D70 Offset: 0x2515E71 VA: 0x2515D70
	|-Array.InternalArray__get_Item<ValueTuple<object, float>>
	|
	|-RVA: 0x2515E40 Offset: 0x2515F41 VA: 0x2515E40
	|-Array.InternalArray__get_Item<ValueTuple<float, object>>
	|
	|-RVA: 0x2515F10 Offset: 0x2516011 VA: 0x2515F10
	|-Array.InternalArray__get_Item<ValueTuple<float, float>>
	|
	|-RVA: 0x2515FE0 Offset: 0x25160E1 VA: 0x2515FE0
	|-Array.InternalArray__get_Item<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x22572B0 Offset: 0x22573B1 VA: 0x22572B0
	|-Array.InternalArray__get_Item<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2257390 Offset: 0x2257491 VA: 0x2257390
	|-Array.InternalArray__get_Item<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x2257480 Offset: 0x2257581 VA: 0x2257480
	|-Array.InternalArray__get_Item<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x2257570 Offset: 0x2257671 VA: 0x2257570
	|-Array.InternalArray__get_Item<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x2257670 Offset: 0x2257771 VA: 0x2257670
	|-Array.InternalArray__get_Item<HighlightState>
	|
	|-RVA: 0x2257760 Offset: 0x2257861 VA: 0x2257760
	|-Array.InternalArray__get_Item<MaterialReference>
	|
	|-RVA: 0x2257860 Offset: 0x2257961 VA: 0x2257860
	|-Array.InternalArray__get_Item<RichTextTagAttribute>
	|
	|-RVA: 0x2257950 Offset: 0x2257A51 VA: 0x2257950
	|-Array.InternalArray__get_Item<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x2257A50 Offset: 0x2257B51 VA: 0x2257A50
	|-Array.InternalArray__get_Item<TMP_CharacterInfo>
	|
	|-RVA: 0x2257B50 Offset: 0x2257C51 VA: 0x2257B50
	|-Array.InternalArray__get_Item<TMP_FontWeightPair>
	|
	|-RVA: 0x2257C20 Offset: 0x2257D21 VA: 0x2257C20
	|-Array.InternalArray__get_Item<TMP_LineInfo>
	|
	|-RVA: 0x2257D40 Offset: 0x2257E41 VA: 0x2257D40
	|-Array.InternalArray__get_Item<TMP_LinkInfo>
	|
	|-RVA: 0x2257E30 Offset: 0x2257F31 VA: 0x2257E30
	|-Array.InternalArray__get_Item<TMP_MeshInfo>
	|
	|-RVA: 0x2257F40 Offset: 0x2258041 VA: 0x2257F40
	|-Array.InternalArray__get_Item<TMP_PageInfo>
	|
	|-RVA: 0x2258030 Offset: 0x2258131 VA: 0x2258030
	|-Array.InternalArray__get_Item<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x2258110 Offset: 0x2258211 VA: 0x2258110
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x2258200 Offset: 0x2258301 VA: 0x2258200
	|-Array.InternalArray__get_Item<TMP_WordInfo>
	|
	|-RVA: 0x22582F0 Offset: 0x22583F1 VA: 0x22582F0
	|-Array.InternalArray__get_Item<WordWrapState>
	|
	|-RVA: 0x22583F0 Offset: 0x22584F1 VA: 0x22583F0
	|-Array.InternalArray__get_Item<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x22584E0 Offset: 0x22585E1 VA: 0x22584E0
	|-Array.InternalArray__get_Item<TransitionTables>
	|
	|-RVA: 0x22585D0 Offset: 0x22586D1 VA: 0x22585D0
	|-Array.InternalArray__get_Item<TutorialUnlockFlagData>
	|
	|-RVA: 0x22586B0 Offset: 0x22587B1 VA: 0x22586B0
	|-Array.InternalArray__get_Item<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x2258780 Offset: 0x2258881 VA: 0x2258780
	|-Array.InternalArray__get_Item<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x2258850 Offset: 0x2258951 VA: 0x2258850
	|-Array.InternalArray__get_Item<CapEdge>
	|
	|-RVA: 0x2258940 Offset: 0x2258A41 VA: 0x2258940
	|-Array.InternalArray__get_Item<ClippedEdge>
	|
	|-RVA: 0x2258A30 Offset: 0x2258B31 VA: 0x2258A30
	|-Array.InternalArray__get_Item<EdgeKeyByHash>
	|
	|-RVA: 0x2258B00 Offset: 0x2258C01 VA: 0x2258B00
	|-Array.InternalArray__get_Item<EdgeKeyByIndex>
	|
	|-RVA: 0x2258BD0 Offset: 0x2258CD1 VA: 0x2258BD0
	|-Array.InternalArray__get_Item<MeshDataConnectivity.Face>
	|
	|-RVA: 0x2258CA0 Offset: 0x2258DA1 VA: 0x2258CA0
	|-Array.InternalArray__get_Item<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x2258D90 Offset: 0x2258E91 VA: 0x2258D90
	|-Array.InternalArray__get_Item<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x2258E80 Offset: 0x2258F81 VA: 0x2258E80
	|-Array.InternalArray__get_Item<NavMeshBuildMarkup>
	|
	|-RVA: 0x2258F50 Offset: 0x2259051 VA: 0x2258F50
	|-Array.InternalArray__get_Item<NavMeshBuildSource>
	|
	|-RVA: 0x2259070 Offset: 0x2259171 VA: 0x2259070
	|-Array.InternalArray__get_Item<ContentCatalogData.Bucket>
	|
	|-RVA: 0x2259140 Offset: 0x2259241 VA: 0x2259140
	|-Array.InternalArray__get_Item<ConstraintSource>
	|
	|-RVA: 0x2259210 Offset: 0x2259311 VA: 0x2259210
	|-Array.InternalArray__get_Item<PropertySceneHandle>
	|
	|-RVA: 0x22592E0 Offset: 0x22593E1 VA: 0x22592E0
	|-Array.InternalArray__get_Item<TransformStreamHandle>
	|
	|-RVA: 0x22593C0 Offset: 0x22594C1 VA: 0x22593C0
	|-Array.InternalArray__get_Item<AnimatorClipInfo>
	|
	|-RVA: 0x2259490 Offset: 0x2259591 VA: 0x2259490
	|-Array.InternalArray__get_Item<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x2259560 Offset: 0x2259661 VA: 0x2259560
	|-Array.InternalArray__get_Item<BoneWeight1>
	|
	|-RVA: 0x2259630 Offset: 0x2259731 VA: 0x2259630
	|-Array.InternalArray__get_Item<BoneWeight>
	|
	|-RVA: 0x2259720 Offset: 0x2259821 VA: 0x2259720
	|-Array.InternalArray__get_Item<BoundingSphere>
	|
	|-RVA: 0x2259800 Offset: 0x2259901 VA: 0x2259800
	|-Array.InternalArray__get_Item<Bounds>
	|
	|-RVA: 0x22598F0 Offset: 0x22599F1 VA: 0x22598F0
	|-Array.InternalArray__get_Item<BoundsInt>
	|
	|-RVA: 0x22599E0 Offset: 0x2259AE1 VA: 0x22599E0
	|-Array.InternalArray__get_Item<CharacterInfo>
	|
	|-RVA: 0x2259AE0 Offset: 0x2259BE1 VA: 0x2259AE0
	|-Array.InternalArray__get_Item<Color32>
	|
	|-RVA: 0x2259BB0 Offset: 0x2259CB1 VA: 0x2259BB0
	|-Array.InternalArray__get_Item<Color>
	|
	|-RVA: 0x2259C90 Offset: 0x2259D91 VA: 0x2259C90
	|-Array.InternalArray__get_Item<CombineInstance>
	|
	|-RVA: 0x2259DB0 Offset: 0x2259EB1 VA: 0x2259DB0
	|-Array.InternalArray__get_Item<ContactPoint2D>
	|
	|-RVA: 0x2259EB0 Offset: 0x2259FB1 VA: 0x2259EB0
	|-Array.InternalArray__get_Item<ContactPoint>
	|
	|-RVA: 0x2259FA0 Offset: 0x225A0A1 VA: 0x2259FA0
	|-Array.InternalArray__get_Item<RaycastResult>
	|
	|-RVA: 0x225A0B0 Offset: 0x225A1B1 VA: 0x225A0B0
	|-Array.InternalArray__get_Item<LightDataGI>
	|
	|-RVA: 0x225A1D0 Offset: 0x225A2D1 VA: 0x225A1D0
	|-Array.InternalArray__get_Item<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x225A2A0 Offset: 0x225A3A1 VA: 0x225A2A0
	|-Array.InternalArray__get_Item<GradientAlphaKey>
	|
	|-RVA: 0x225A370 Offset: 0x225A471 VA: 0x225A370
	|-Array.InternalArray__get_Item<GradientColorKey>
	|
	|-RVA: 0x225A460 Offset: 0x225A561 VA: 0x225A460
	|-Array.InternalArray__get_Item<HumanBone>
	|
	|-RVA: 0x225A560 Offset: 0x225A661 VA: 0x225A560
	|-Array.InternalArray__get_Item<Keyframe>
	|
	|-RVA: 0x225A650 Offset: 0x225A751 VA: 0x225A650
	|-Array.InternalArray__get_Item<LOD>
	|
	|-RVA: 0x225A720 Offset: 0x225A821 VA: 0x225A720
	|-Array.InternalArray__get_Item<LayerMask>
	|
	|-RVA: 0x225A7F0 Offset: 0x225A8F1 VA: 0x225A7F0
	|-Array.InternalArray__get_Item<PlayerLoopSystem>
	|
	|-RVA: 0x225A8E0 Offset: 0x225A9E1 VA: 0x225A8E0
	|-Array.InternalArray__get_Item<Matrix4x4>
	|
	|-RVA: 0x225A9E0 Offset: 0x225AAE1 VA: 0x225A9E0
	|-Array.InternalArray__get_Item<ParticleSystem.Particle>
	|
	|-RVA: 0x225AAE0 Offset: 0x225ABE1 VA: 0x225AAE0
	|-Array.InternalArray__get_Item<PatchExtents>
	|
	|-RVA: 0x225ABB0 Offset: 0x225ACB1 VA: 0x225ABB0
	|-Array.InternalArray__get_Item<Plane>
	|
	|-RVA: 0x225AC90 Offset: 0x225AD91 VA: 0x225AC90
	|-Array.InternalArray__get_Item<Playable>
	|
	|-RVA: 0x225AD60 Offset: 0x225AE61 VA: 0x225AD60
	|-Array.InternalArray__get_Item<PlayableBinding>
	|
	|-RVA: 0x225AE50 Offset: 0x225AF51 VA: 0x225AE50
	|-Array.InternalArray__get_Item<PlayableGraph>
	|
	|-RVA: 0x225AF20 Offset: 0x225B021 VA: 0x225AF20
	|-Array.InternalArray__get_Item<Edge>
	|
	|-RVA: 0x225AFF0 Offset: 0x225B0F1 VA: 0x225AFF0
	|-Array.InternalArray__get_Item<IntVec3>
	|
	|-RVA: 0x225B0D0 Offset: 0x225B1D1 VA: 0x225B0D0
	|-Array.InternalArray__get_Item<Quaternion>
	|
	|-RVA: 0x225B1B0 Offset: 0x225B2B1 VA: 0x225B1B0
	|-Array.InternalArray__get_Item<RangeInt>
	|
	|-RVA: 0x225B280 Offset: 0x225B381 VA: 0x225B280
	|-Array.InternalArray__get_Item<RaycastHit2D>
	|
	|-RVA: 0x225B370 Offset: 0x225B471 VA: 0x225B370
	|-Array.InternalArray__get_Item<RaycastHit>
	|
	|-RVA: 0x225B470 Offset: 0x225B571 VA: 0x225B470
	|-Array.InternalArray__get_Item<Rect>
	|
	|-RVA: 0x225B550 Offset: 0x225B651 VA: 0x225B550
	|-Array.InternalArray__get_Item<RectInt>
	|
	|-RVA: 0x225B620 Offset: 0x225B721 VA: 0x225B620
	|-Array.InternalArray__get_Item<RenderBuffer>
	|
	|-RVA: 0x225B6F0 Offset: 0x225B7F1 VA: 0x225B6F0
	|-Array.InternalArray__get_Item<BatchVisibility>
	|
	|-RVA: 0x225B7D0 Offset: 0x225B8D1 VA: 0x225B7D0
	|-Array.InternalArray__get_Item<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x225B8A0 Offset: 0x225B9A1 VA: 0x225B8A0
	|-Array.InternalArray__get_Item<SphericalHarmonicsL2>
	|
	|-RVA: 0x225B9D0 Offset: 0x225BAD1 VA: 0x225B9D0
	|-Array.InternalArray__get_Item<VertexAttributeDescriptor>
	|
	|-RVA: 0x225BAA0 Offset: 0x225BBA1 VA: 0x225BAA0
	|-Array.InternalArray__get_Item<AsyncOperationHandle>
	|
	|-RVA: 0x225BB90 Offset: 0x225BC91 VA: 0x225BB90
	|-Array.InternalArray__get_Item<AsyncOperationHandle<object>>
	|
	|-RVA: 0x225BC80 Offset: 0x225BD81 VA: 0x225BC80
	|-Array.InternalArray__get_Item<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x225BD70 Offset: 0x225BE71 VA: 0x225BD70
	|-Array.InternalArray__get_Item<DiagnosticEvent>
	|
	|-RVA: 0x225BE60 Offset: 0x225BF61 VA: 0x225BE60
	|-Array.InternalArray__get_Item<SceneInstance>
	|
	|-RVA: 0x225BF30 Offset: 0x225C031 VA: 0x225BF30
	|-Array.InternalArray__get_Item<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x225C020 Offset: 0x225C121 VA: 0x225C020
	|-Array.InternalArray__get_Item<ObjectInitializationData>
	|
	|-RVA: 0x225C110 Offset: 0x225C211 VA: 0x225C110
	|-Array.InternalArray__get_Item<SerializedType>
	|
	|-RVA: 0x225C200 Offset: 0x225C301 VA: 0x225C200
	|-Array.InternalArray__get_Item<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x225C2D0 Offset: 0x225C3D1 VA: 0x225C2D0
	|-Array.InternalArray__get_Item<SkeletonBone>
	|
	|-RVA: 0x225C3D0 Offset: 0x225C4D1 VA: 0x225C3D0
	|-Array.InternalArray__get_Item<GlyphRect>
	|
	|-RVA: 0x225C4A0 Offset: 0x225C5A1 VA: 0x225C4A0
	|-Array.InternalArray__get_Item<GlyphMarshallingStruct>
	|
	|-RVA: 0x225C590 Offset: 0x225C691 VA: 0x225C590
	|-Array.InternalArray__get_Item<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x225C690 Offset: 0x225C791 VA: 0x225C690
	|-Array.InternalArray__get_Item<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x225C780 Offset: 0x225C881 VA: 0x225C780
	|-Array.InternalArray__get_Item<IntervalTreeNode>
	|
	|-RVA: 0x225C870 Offset: 0x225C971 VA: 0x225C870
	|-Array.InternalArray__get_Item<IntervalTree.Entry<object>>
	|
	|-RVA: 0x225C960 Offset: 0x225CA61 VA: 0x225C960
	|-Array.InternalArray__get_Item<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x225CA50 Offset: 0x225CB51 VA: 0x225CA50
	|-Array.InternalArray__get_Item<Touch>
	|
	|-RVA: 0x225CB60 Offset: 0x225CC61 VA: 0x225CB60
	|-Array.InternalArray__get_Item<TreeInstance>
	|
	|-RVA: 0x225CC50 Offset: 0x225CD51 VA: 0x225CC50
	|-Array.InternalArray__get_Item<ColorBlock>
	|
	|-RVA: 0x225CD70 Offset: 0x225CE71 VA: 0x225CD70
	|-Array.InternalArray__get_Item<Navigation>
	|
	|-RVA: 0x225CE60 Offset: 0x225CF61 VA: 0x225CE60
	|-Array.InternalArray__get_Item<SpriteState>
	|
	|-RVA: 0x225CF50 Offset: 0x225D051 VA: 0x225CF50
	|-Array.InternalArray__get_Item<UICharInfo>
	|
	|-RVA: 0x225D030 Offset: 0x225D131 VA: 0x225D030
	|-Array.InternalArray__get_Item<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x225D100 Offset: 0x225D201 VA: 0x225D100
	|-Array.InternalArray__get_Item<EventDispatcher.EventRecord>
	|
	|-RVA: 0x225D1D0 Offset: 0x225D2D1 VA: 0x225D1D0
	|-Array.InternalArray__get_Item<FocusController.FocusedElement>
	|
	|-RVA: 0x225D2A0 Offset: 0x225D3A1 VA: 0x225D2A0
	|-Array.InternalArray__get_Item<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x225D370 Offset: 0x225D471 VA: 0x225D370
	|-Array.InternalArray__get_Item<StyleValue>
	|
	|-RVA: 0x225D460 Offset: 0x225D561 VA: 0x225D460
	|-Array.InternalArray__get_Item<UILineInfo>
	|
	|-RVA: 0x225D530 Offset: 0x225D631 VA: 0x225D530
	|-Array.InternalArray__get_Item<UIVertex>
	|
	|-RVA: 0x225D650 Offset: 0x225D751 VA: 0x225D650
	|-Array.InternalArray__get_Item<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x225D740 Offset: 0x225D841 VA: 0x225D740
	|-Array.InternalArray__get_Item<Vector2>
	|
	|-RVA: 0x225D810 Offset: 0x225D911 VA: 0x225D810
	|-Array.InternalArray__get_Item<Vector2Int>
	|
	|-RVA: 0x225D8E0 Offset: 0x225D9E1 VA: 0x225D8E0
	|-Array.InternalArray__get_Item<Vector3>
	|
	|-RVA: 0x225D9C0 Offset: 0x225DAC1 VA: 0x225D9C0
	|-Array.InternalArray__get_Item<Vector3Int>
	|
	|-RVA: 0x225DAA0 Offset: 0x225DBA1 VA: 0x225DAA0
	|-Array.InternalArray__get_Item<Vector4>
	|
	|-RVA: 0x225DB80 Offset: 0x225DC81 VA: 0x225DB80
	|-Array.InternalArray__get_Item<jvalue>
	|
	|-RVA: 0x225DC50 Offset: 0x225DD51 VA: 0x225DC50
	|-Array.InternalArray__get_Item<WarpPoints.WarpPoint>
	|
	|-RVA: 0x225DD80 Offset: 0x225DE81 VA: 0x225DD80
	|-Array.InternalArray__get_Item<YieldItemParam>
	|
	|-RVA: 0x225DE50 Offset: 0x225DF51 VA: 0x225DE50
	|-Array.InternalArray__get_Item<NetworkServiceAccountId>
	|
	|-RVA: 0x225DF20 Offset: 0x225E021 VA: 0x225DF20
	|-Array.InternalArray__get_Item<Uid>
	|
	|-RVA: 0x225DFF0 Offset: 0x225E0F1 VA: 0x225DFF0
	|-Array.InternalArray__get_Item<ConsumableServiceItemId>
	|
	|-RVA: 0x225E0C0 Offset: 0x225E1C1 VA: 0x225E0C0
	|-Array.InternalArray__get_Item<NsUid>
	|
	|-RVA: 0x225E190 Offset: 0x225E291 VA: 0x225E190
	|-Array.InternalArray__get_Item<Friend>
	|
	|-RVA: 0x225E290 Offset: 0x225E391 VA: 0x225E290
	|-Array.InternalArray__get_Item<Profile>
	|
	|-RVA: 0x225E3C0 Offset: 0x225E4C1 VA: 0x225E3C0
	|-Array.InternalArray__get_Item<DirectoryEntry>
	|
	|-RVA: 0x225E4B0 Offset: 0x225E5B1 VA: 0x225E4B0
	|-Array.InternalArray__get_Item<DebugPadState>
	|
	|-RVA: 0x225E5A0 Offset: 0x225E6A1 VA: 0x225E5A0
	|-Array.InternalArray__get_Item<GesturePoint>
	|
	|-RVA: 0x225E670 Offset: 0x225E771 VA: 0x225E670
	|-Array.InternalArray__get_Item<GestureState>
	|
	|-RVA: 0x225E790 Offset: 0x225E891 VA: 0x225E790
	|-Array.InternalArray__get_Item<NpadFullKeyState>
	|
	|-RVA: 0x225E880 Offset: 0x225E981 VA: 0x225E880
	|-Array.InternalArray__get_Item<NpadHandheldState>
	|
	|-RVA: 0x225E970 Offset: 0x225EA71 VA: 0x225E970
	|-Array.InternalArray__get_Item<NpadJoyDualState>
	|
	|-RVA: 0x225EA60 Offset: 0x225EB61 VA: 0x225EA60
	|-Array.InternalArray__get_Item<NpadJoyLeftState>
	|
	|-RVA: 0x225EB50 Offset: 0x225EC51 VA: 0x225EB50
	|-Array.InternalArray__get_Item<NpadJoyRightState>
	|
	|-RVA: 0x225EC40 Offset: 0x225ED41 VA: 0x225EC40
	|-Array.InternalArray__get_Item<NpadStateArrayItem>
	|
	|-RVA: 0x225ED30 Offset: 0x225EE31 VA: 0x225ED30
	|-Array.InternalArray__get_Item<SixAxisSensorHandle>
	|
	|-RVA: 0x225EE00 Offset: 0x225EF01 VA: 0x225EE00
	|-Array.InternalArray__get_Item<SixAxisSensorState>
	|
	|-RVA: 0x225EF20 Offset: 0x225F021 VA: 0x225EF20
	|-Array.InternalArray__get_Item<TouchScreenState10>
	|
	|-RVA: 0x225F020 Offset: 0x225F121 VA: 0x225F020
	|-Array.InternalArray__get_Item<TouchScreenState11>
	|
	|-RVA: 0x225F120 Offset: 0x225F221 VA: 0x225F120
	|-Array.InternalArray__get_Item<TouchScreenState12>
	|
	|-RVA: 0x225F220 Offset: 0x225F321 VA: 0x225F220
	|-Array.InternalArray__get_Item<TouchScreenState13>
	|
	|-RVA: 0x225F320 Offset: 0x225F421 VA: 0x225F320
	|-Array.InternalArray__get_Item<TouchScreenState14>
	|
	|-RVA: 0x225F420 Offset: 0x225F521 VA: 0x225F420
	|-Array.InternalArray__get_Item<TouchScreenState15>
	|
	|-RVA: 0x225F520 Offset: 0x225F621 VA: 0x225F520
	|-Array.InternalArray__get_Item<TouchScreenState16>
	|
	|-RVA: 0x225F620 Offset: 0x225F721 VA: 0x225F620
	|-Array.InternalArray__get_Item<TouchScreenState1>
	|
	|-RVA: 0x225F720 Offset: 0x225F821 VA: 0x225F720
	|-Array.InternalArray__get_Item<TouchScreenState2>
	|
	|-RVA: 0x225F840 Offset: 0x225F941 VA: 0x225F840
	|-Array.InternalArray__get_Item<TouchScreenState3>
	|
	|-RVA: 0x225F940 Offset: 0x225FA41 VA: 0x225F940
	|-Array.InternalArray__get_Item<TouchScreenState4>
	|
	|-RVA: 0x225FA50 Offset: 0x225FB51 VA: 0x225FA50
	|-Array.InternalArray__get_Item<TouchScreenState5>
	|
	|-RVA: 0x225FB70 Offset: 0x225FC71 VA: 0x225FB70
	|-Array.InternalArray__get_Item<TouchScreenState6>
	|
	|-RVA: 0x225FCA0 Offset: 0x225FDA1 VA: 0x225FCA0
	|-Array.InternalArray__get_Item<TouchScreenState7>
	|
	|-RVA: 0x225FDA0 Offset: 0x225FEA1 VA: 0x225FDA0
	|-Array.InternalArray__get_Item<TouchScreenState8>
	|
	|-RVA: 0x225FEA0 Offset: 0x225FFA1 VA: 0x225FEA0
	|-Array.InternalArray__get_Item<TouchScreenState9>
	|
	|-RVA: 0x225FFA0 Offset: 0x22600A1 VA: 0x225FFA0
	|-Array.InternalArray__get_Item<TouchState>
	|
	|-RVA: 0x2260090 Offset: 0x2260191 VA: 0x2260090
	|-Array.InternalArray__get_Item<VibrationDeviceHandle>
	|
	|-RVA: 0x2260160 Offset: 0x2260261 VA: 0x2260160
	|-Array.InternalArray__get_Item<VibrationDeviceInfo>
	|
	|-RVA: 0x2260230 Offset: 0x2260331 VA: 0x2260230
	|-Array.InternalArray__get_Item<VibrationValue>
	|
	|-RVA: 0x2260310 Offset: 0x2260411 VA: 0x2260310
	|-Array.InternalArray__get_Item<ClusteringData>
	|
	|-RVA: 0x2260400 Offset: 0x2260501 VA: 0x2260400
	|-Array.InternalArray__get_Item<ClusteringProcessorState>
	|
	|-RVA: 0x2260500 Offset: 0x2260601 VA: 0x2260500
	|-Array.InternalArray__get_Item<Finger>
	|
	|-RVA: 0x22605F0 Offset: 0x22606F1 VA: 0x22605F0
	|-Array.InternalArray__get_Item<Hand>
	|
	|-RVA: 0x22606F0 Offset: 0x22607F1 VA: 0x22606F0
	|-Array.InternalArray__get_Item<HandAnalysisImageState>
	|
	|-RVA: 0x22607C0 Offset: 0x22608C1 VA: 0x22607C0
	|-Array.InternalArray__get_Item<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x22608C0 Offset: 0x22609C1 VA: 0x22608C0
	|-Array.InternalArray__get_Item<MomentProcessorState>
	|
	|-RVA: 0x22609C0 Offset: 0x2260AC1 VA: 0x22609C0
	|-Array.InternalArray__get_Item<MomentStatistic>
	|
	|-RVA: 0x2260AA0 Offset: 0x2260BA1 VA: 0x2260AA0
	|-Array.InternalArray__get_Item<Protrusion>
	|
	|-RVA: 0x2260B70 Offset: 0x2260C71 VA: 0x2260B70
	|-Array.InternalArray__get_Item<Shape>
	|
	|-RVA: 0x2260C60 Offset: 0x2260D61 VA: 0x2260C60
	|-Array.InternalArray__get_Item<DictionaryInfo>
	|
	|-RVA: 0x2260D30 Offset: 0x2260E31 VA: 0x2260D30
	|-Array.InternalArray__get_Item<UserWord>
	|
	|-RVA: 0x2260E00 Offset: 0x2260F01 VA: 0x2260E00
	|-Array.InternalArray__get_Item<Color4u8>
	|
	|-RVA: 0x2260ED0 Offset: 0x2260FD1 VA: 0x2260ED0
	|-Array.InternalArray__get_Item<Float2>
	|
	|-RVA: 0x2260FA0 Offset: 0x22610A1 VA: 0x2260FA0
	|-Array.InternalArray__get_Item<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	internal void InternalArray__set_Item<T>(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x235FBE0 Offset: 0x235FCE1 VA: 0x235FBE0
	|-Array.InternalArray__set_Item<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x235FD70 Offset: 0x235FE71 VA: 0x235FD70
	|-Array.InternalArray__set_Item<ActionCommandDataTable>
	|
	|-RVA: 0x235FF20 Offset: 0x2360021 VA: 0x235FF20
	|-Array.InternalArray__set_Item<AdvScriptDefCountParam>
	|
	|-RVA: 0x2360090 Offset: 0x2360191 VA: 0x2360090
	|-Array.InternalArray__set_Item<JSONDeserialization.TaskField>
	|
	|-RVA: 0x2360200 Offset: 0x2360301 VA: 0x2360200
	|-Array.InternalArray__set_Item<BitVector32Int>
	|
	|-RVA: 0x2360370 Offset: 0x2360471 VA: 0x2360370
	|-Array.InternalArray__set_Item<BuildItemData>
	|
	|-RVA: 0x2360530 Offset: 0x2360631 VA: 0x2360530
	|-Array.InternalArray__set_Item<ButtonLinker.LinkObject>
	|
	|-RVA: 0x23606A0 Offset: 0x23607A1 VA: 0x23606A0
	|-Array.InternalArray__set_Item<CharaCallTable.BustupTable>
	|
	|-RVA: 0x2360810 Offset: 0x2360911 VA: 0x2360810
	|-Array.InternalArray__set_Item<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x2360990 Offset: 0x2360A91 VA: 0x2360990
	|-Array.InternalArray__set_Item<CameraState.CustomBlendable>
	|
	|-RVA: 0x2360B00 Offset: 0x2360C01 VA: 0x2360B00
	|-Array.InternalArray__set_Item<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x2360C90 Offset: 0x2360D91 VA: 0x2360C90
	|-Array.InternalArray__set_Item<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x2360E20 Offset: 0x2360F21 VA: 0x2360E20
	|-Array.InternalArray__set_Item<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2360F90 Offset: 0x2361091 VA: 0x2360F90
	|-Array.InternalArray__set_Item<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x2361100 Offset: 0x2361201 VA: 0x2361100
	|-Array.InternalArray__set_Item<CinemachinePath.Waypoint>
	|
	|-RVA: 0x23612A0 Offset: 0x23613A1 VA: 0x23612A0
	|-Array.InternalArray__set_Item<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x2361410 Offset: 0x2361511 VA: 0x2361410
	|-Array.InternalArray__set_Item<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2361580 Offset: 0x2361681 VA: 0x2361580
	|-Array.InternalArray__set_Item<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x2361710 Offset: 0x2361811 VA: 0x2361710
	|-Array.InternalArray__set_Item<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x2361880 Offset: 0x2361981 VA: 0x2361880
	|-Array.InternalArray__set_Item<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x23619F0 Offset: 0x2361AF1 VA: 0x23619F0
	|-Array.InternalArray__set_Item<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x2361B90 Offset: 0x2361C91 VA: 0x2361B90
	|-Array.InternalArray__set_Item<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2361D30 Offset: 0x2361E31 VA: 0x2361D30
	|-Array.InternalArray__set_Item<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x2361ED0 Offset: 0x2361FD1 VA: 0x2361ED0
	|-Array.InternalArray__set_Item<HeadingTracker.Item>
	|
	|-RVA: 0x2362060 Offset: 0x2362161 VA: 0x2362060
	|-Array.InternalArray__set_Item<CropDataTable>
	|
	|-RVA: 0x23621F0 Offset: 0x23622F1 VA: 0x23621F0
	|-Array.InternalArray__set_Item<ControlPoint>
	|
	|-RVA: 0x2362380 Offset: 0x2362481 VA: 0x2362380
	|-Array.InternalArray__set_Item<DamageTextInfo>
	|
	|-RVA: 0x2362510 Offset: 0x2362611 VA: 0x2362510
	|-Array.InternalArray__set_Item<UIEMDefine.CategoryDataSet>
	|
	|-RVA: 0x23626A0 Offset: 0x23627A1 VA: 0x23626A0
	|-Array.InternalArray__set_Item<DropItemParam>
	|
	|-RVA: 0x2362810 Offset: 0x2362911 VA: 0x2362810
	|-Array.InternalArray__set_Item<DropTableElement>
	|
	|-RVA: 0x23629A0 Offset: 0x2362AA1 VA: 0x23629A0
	|-Array.InternalArray__set_Item<EffectDataTable>
	|
	|-RVA: 0x2362B30 Offset: 0x2362C31 VA: 0x2362B30
	|-Array.InternalArray__set_Item<EnemyPatrolPoints>
	|
	|-RVA: 0x2362CA0 Offset: 0x2362DA1 VA: 0x2362CA0
	|-Array.InternalArray__set_Item<Coord>
	|
	|-RVA: 0x2362E10 Offset: 0x2362F11 VA: 0x2362E10
	|-Array.InternalArray__set_Item<ErosionBrush.UndoStep>
	|
	|-RVA: 0x2362FA0 Offset: 0x23630A1 VA: 0x2362FA0
	|-Array.InternalArray__set_Item<EventCheckId>
	|
	|-RVA: 0x2363130 Offset: 0x2363231 VA: 0x2363130
	|-Array.InternalArray__set_Item<EventFlagProgressData>
	|
	|-RVA: 0x23632A0 Offset: 0x23633A1 VA: 0x23632A0
	|-Array.InternalArray__set_Item<EyeMouthAnimate.EMAnimSet>
	|
	|-RVA: 0x2363410 Offset: 0x2363511 VA: 0x2363410
	|-Array.InternalArray__set_Item<FarmManager.RF4_CROP_PARAM>
	|
	|-RVA: 0x23635C0 Offset: 0x23636C1 VA: 0x23635C0
	|-Array.InternalArray__set_Item<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x2363770 Offset: 0x2363871 VA: 0x2363770
	|-Array.InternalArray__set_Item<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x2363900 Offset: 0x2363A01 VA: 0x2363900
	|-Array.InternalArray__set_Item<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2363A80 Offset: 0x2363B81 VA: 0x2363A80
	|-Array.InternalArray__set_Item<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x2363BF0 Offset: 0x2363CF1 VA: 0x2363BF0
	|-Array.InternalArray__set_Item<FesNpcScoreData>
	|
	|-RVA: 0x2363D60 Offset: 0x2363E61 VA: 0x2363D60
	|-Array.InternalArray__set_Item<FieldHideItemSpawnDataTable>
	|
	|-RVA: 0x2363ED0 Offset: 0x2363FD1 VA: 0x2363ED0
	|-Array.InternalArray__set_Item<FieldItemSpawnDataTable>
	|
	|-RVA: 0x2364070 Offset: 0x2364171 VA: 0x2364070
	|-Array.InternalArray__set_Item<FieldRandomTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x2364200 Offset: 0x2364301 VA: 0x2364200
	|-Array.InternalArray__set_Item<FieldSceneData.Data>
	|
	|-RVA: 0x23643B0 Offset: 0x23644B1 VA: 0x23643B0
	|-Array.InternalArray__set_Item<FieldTreasureBoxItemData>
	|
	|-RVA: 0x2364520 Offset: 0x2364621 VA: 0x2364520
	|-Array.InternalArray__set_Item<FieldUniqueTreasureBoxSpawnDataTable>
	|
	|-RVA: 0x23646C0 Offset: 0x23647C1 VA: 0x23646C0
	|-Array.InternalArray__set_Item<FieldWoodBoxSpawnDataTable>
	|
	|-RVA: 0x2364850 Offset: 0x2364951 VA: 0x2364850
	|-Array.InternalArray__set_Item<FocusObjectDataTable>
	|
	|-RVA: 0x23649E0 Offset: 0x2364AE1 VA: 0x23649E0
	|-Array.InternalArray__set_Item<FurnitureData>
	|
	|-RVA: 0x2364B70 Offset: 0x2364C71 VA: 0x2364B70
	|-Array.InternalArray__set_Item<GateDataTable>
	|
	|-RVA: 0x2364CE0 Offset: 0x2364DE1 VA: 0x2364CE0
	|-Array.InternalArray__set_Item<GateStatusDataTable>
	|
	|-RVA: 0x2364E80 Offset: 0x2364F81 VA: 0x2364E80
	|-Array.InternalArray__set_Item<GimmickLayoutDataTable>
	|
	|-RVA: 0x2364FF0 Offset: 0x23650F1 VA: 0x2364FF0
	|-Array.InternalArray__set_Item<HitResult>
	|
	|-RVA: 0x2365190 Offset: 0x2365291 VA: 0x2365190
	|-Array.InternalArray__set_Item<ImagePaneDatas.ImagePaneData>
	|
	|-RVA: 0x2365320 Offset: 0x2365421 VA: 0x2365320
	|-Array.InternalArray__set_Item<FurnitureManager.SendPos>
	|
	|-RVA: 0x23654B0 Offset: 0x23655B1 VA: 0x23654B0
	|-Array.InternalArray__set_Item<ItemLevelData>
	|
	|-RVA: 0x2365620 Offset: 0x2365721 VA: 0x2365620
	|-Array.InternalArray__set_Item<MapDatas.MapData>
	|
	|-RVA: 0x23657B0 Offset: 0x23658B1 VA: 0x23657B0
	|-Array.InternalArray__set_Item<MapObjectDatas.MapObjectData>
	|
	|-RVA: 0x2365950 Offset: 0x2365A51 VA: 0x2365950
	|-Array.InternalArray__set_Item<ByteArrayStringHashTable.Entry>
	|
	|-RVA: 0x2365AC0 Offset: 0x2365BC1 VA: 0x2365AC0
	|-Array.InternalArray__set_Item<MineTypeDataTable>
	|
	|-RVA: 0x2365C60 Offset: 0x2365D61 VA: 0x2365C60
	|-Array.InternalArray__set_Item<MiningDataTable>
	|
	|-RVA: 0x2365DD0 Offset: 0x2365ED1 VA: 0x2365DD0
	|-Array.InternalArray__set_Item<MiningPointSaveData>
	|
	|-RVA: 0x2365F70 Offset: 0x2366071 VA: 0x2365F70
	|-Array.InternalArray__set_Item<CodePointIndexer.TableRange>
	|
	|-RVA: 0x2366100 Offset: 0x2366201 VA: 0x2366100
	|-Array.InternalArray__set_Item<MonsterBehaviorDataTable>
	|
	|-RVA: 0x2366290 Offset: 0x2366391 VA: 0x2366290
	|-Array.InternalArray__set_Item<MonsterDataTable>
	|
	|-RVA: 0x2366420 Offset: 0x2366521 VA: 0x2366420
	|-Array.InternalArray__set_Item<MonsterDropItemDataTable>
	|
	|-RVA: 0x23665B0 Offset: 0x23666B1 VA: 0x23665B0
	|-Array.InternalArray__set_Item<MonsterFootStepEventDataTable>
	|
	|-RVA: 0x2366750 Offset: 0x2366851 VA: 0x2366750
	|-Array.InternalArray__set_Item<MonsterHutSaveData>
	|
	|-RVA: 0x23668F0 Offset: 0x23669F1 VA: 0x23668F0
	|-Array.InternalArray__set_Item<MonsterUIData.Data>
	|
	|-RVA: 0x2366A90 Offset: 0x2366B91 VA: 0x2366A90
	|-Array.InternalArray__set_Item<MonsterYieldItemDataTable>
	|
	|-RVA: 0x2366C00 Offset: 0x2366D01 VA: 0x2366C00
	|-Array.InternalArray__set_Item<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x2366D70 Offset: 0x2366E71 VA: 0x2366D70
	|-Array.InternalArray__set_Item<NPCActionData>
	|
	|-RVA: 0x2366F10 Offset: 0x2367011 VA: 0x2366F10
	|-Array.InternalArray__set_Item<NPCCallingNameTextData.Data>
	|
	|-RVA: 0x2367080 Offset: 0x2367181 VA: 0x2367080
	|-Array.InternalArray__set_Item<NPCUIData.Data>
	|
	|-RVA: 0x23671F0 Offset: 0x23672F1 VA: 0x23671F0
	|-Array.InternalArray__set_Item<NpcPlaceSchedule>
	|
	|-RVA: 0x2367380 Offset: 0x2367481 VA: 0x2367380
	|-Array.InternalArray__set_Item<OrderLotterySaveParameter>
	|
	|-RVA: 0x2367500 Offset: 0x2367601 VA: 0x2367500
	|-Array.InternalArray__set_Item<OrderSaveData>
	|
	|-RVA: 0x23676A0 Offset: 0x23677A1 VA: 0x23676A0
	|-Array.InternalArray__set_Item<OrderSaveParameter>
	|
	|-RVA: 0x2367830 Offset: 0x2367931 VA: 0x2367830
	|-Array.InternalArray__set_Item<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x23679A0 Offset: 0x2367AA1 VA: 0x23679A0
	|-Array.InternalArray__set_Item<Parameter>
	|
	|-RVA: 0x2367B30 Offset: 0x2367C31 VA: 0x2367B30
	|-Array.InternalArray__set_Item<PartnerNPCWeaponBehaviorDataTable>
	|
	|-RVA: 0x2367CA0 Offset: 0x2367DA1 VA: 0x2367CA0
	|-Array.InternalArray__set_Item<PlayerCallingNameTextData.Data>
	|
	|-RVA: 0x2367E40 Offset: 0x2367F41 VA: 0x2367E40
	|-Array.InternalArray__set_Item<ShopCatalogPage>
	|
	|-RVA: 0x2367FB0 Offset: 0x23680B1 VA: 0x2367FB0
	|-Array.InternalArray__set_Item<ShopNpcTalk>
	|
	|-RVA: 0x2368150 Offset: 0x2368251 VA: 0x2368150
	|-Array.InternalArray__set_Item<SubtitleDataTable.Data>
	|
	|-RVA: 0x23682D0 Offset: 0x23683D1 VA: 0x23682D0
	|-Array.InternalArray__set_Item<SubtitleDataTable.DataList>
	|
	|-RVA: 0x2368440 Offset: 0x2368541 VA: 0x2368440
	|-Array.InternalArray__set_Item<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x23685C0 Offset: 0x23686C1 VA: 0x23685C0
	|-Array.InternalArray__set_Item<AnimationWarping.Warp>
	|
	|-RVA: 0x2368760 Offset: 0x2368861 VA: 0x2368760
	|-Array.InternalArray__set_Item<GrounderQuadruped.Foot>
	|
	|-RVA: 0x2368900 Offset: 0x2368A01 VA: 0x2368900
	|-Array.InternalArray__set_Item<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x2368AA0 Offset: 0x2368BA1 VA: 0x2368AA0
	|-Array.InternalArray__set_Item<ProfilerFrame>
	|
	|-RVA: 0x2368C20 Offset: 0x2368D21 VA: 0x2368C20
	|-Array.InternalArray__set_Item<NumberControl.ValueRange>
	|
	|-RVA: 0x2368D90 Offset: 0x2368E91 VA: 0x2368D90
	|-Array.InternalArray__set_Item<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x2368F20 Offset: 0x2369021 VA: 0x2368F20
	|-Array.InternalArray__set_Item<ResponsiveEnable.Entry>
	|
	|-RVA: 0x23690B0 Offset: 0x23691B1 VA: 0x23690B0
	|-Array.InternalArray__set_Item<ResponsiveResize.Element.SizeDefinition>
	|
	|-RVA: 0x2369220 Offset: 0x2369321 VA: 0x2369220
	|-Array.InternalArray__set_Item<ResponsiveResize.Element>
	|
	|-RVA: 0x2369390 Offset: 0x2369491 VA: 0x2369390
	|-Array.InternalArray__set_Item<Schedule>
	|
	|-RVA: 0x2369520 Offset: 0x2369621 VA: 0x2369520
	|-Array.InternalArray__set_Item<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x2369690 Offset: 0x2369791 VA: 0x2369690
	|-Array.InternalArray__set_Item<SkillLevelUpEffectController.LevelUpInfo>
	|
	|-RVA: 0x2369810 Offset: 0x2369911 VA: 0x2369810
	|-Array.InternalArray__set_Item<SpeedData>
	|
	|-RVA: 0x2369980 Offset: 0x2369A81 VA: 0x2369980
	|-Array.InternalArray__set_Item<CurveSample>
	|
	|-RVA: 0x2369B30 Offset: 0x2369C31 VA: 0x2369B30
	|-Array.InternalArray__set_Item<StatusPageSetParameter.ElementParameterText>
	|
	|-RVA: 0x2369CA0 Offset: 0x2369DA1 VA: 0x2369CA0
	|-Array.InternalArray__set_Item<StringFormatData.FormatData>
	|
	|-RVA: 0x2369E10 Offset: 0x2369F11 VA: 0x2369E10
	|-Array.InternalArray__set_Item<ArraySegment<ProfilerFrame>>
	|
	|-RVA: 0x2369F80 Offset: 0x236A081 VA: 0x2369F80
	|-Array.InternalArray__set_Item<ArraySegment<byte>>
	|
	|-RVA: 0x236A0F0 Offset: 0x236A1F1 VA: 0x236A0F0
	|-Array.InternalArray__set_Item<ArraySegment<object>>
	|
	|-RVA: 0x236A260 Offset: 0x236A361 VA: 0x236A260
	|-Array.InternalArray__set_Item<bool>
	|
	|-RVA: 0x236A3D0 Offset: 0x236A4D1 VA: 0x236A3D0
	|-Array.InternalArray__set_Item<byte>
	|
	|-RVA: 0x236A540 Offset: 0x236A641 VA: 0x236A540
	|-Array.InternalArray__set_Item<ByteEnum>
	|
	|-RVA: 0x236A6B0 Offset: 0x236A7B1 VA: 0x236A6B0
	|-Array.InternalArray__set_Item<char>
	|
	|-RVA: 0x236A820 Offset: 0x236A921 VA: 0x236A820
	|-Array.InternalArray__set_Item<ConcurrentQueue.Segment.Slot<object>>
	|
	|-RVA: 0x236A990 Offset: 0x236AA91 VA: 0x236A990
	|-Array.InternalArray__set_Item<DictionaryEntry>
	|
	|-RVA: 0x236AB00 Offset: 0x236AC01 VA: 0x236AB00
	|-Array.InternalArray__set_Item<Dictionary.Entry<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x236AC90 Offset: 0x236AD91 VA: 0x236AC90
	|-Array.InternalArray__set_Item<Dictionary.Entry<BitVector32Int, object>>
	|
	|-RVA: 0x236AE20 Offset: 0x236AF21 VA: 0x236AE20
	|-Array.InternalArray__set_Item<Dictionary.Entry<EventCheckId, object>>
	|
	|-RVA: 0x236AFC0 Offset: 0x236B0C1 VA: 0x236AFC0
	|-Array.InternalArray__set_Item<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x236B170 Offset: 0x236B271 VA: 0x236B170
	|-Array.InternalArray__set_Item<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x236B310 Offset: 0x236B411 VA: 0x236B310
	|-Array.InternalArray__set_Item<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x236B4A0 Offset: 0x236B5A1 VA: 0x236B4A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x236B630 Offset: 0x236B731 VA: 0x236B630
	|-Array.InternalArray__set_Item<Dictionary.Entry<MonsterHutSaveData, object>>
	|
	|-RVA: 0x236B7D0 Offset: 0x236B8D1 VA: 0x236B7D0
	|-Array.InternalArray__set_Item<Dictionary.Entry<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x236B960 Offset: 0x236BA61 VA: 0x236B960
	|-Array.InternalArray__set_Item<Dictionary.Entry<OrderSaveData, object>>
	|
	|-RVA: 0x236BB00 Offset: 0x236BC01 VA: 0x236BB00
	|-Array.InternalArray__set_Item<Dictionary.Entry<OrderSaveParameter, object>>
	|
	|-RVA: 0x236BCA0 Offset: 0x236BDA1 VA: 0x236BCA0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Parameter, object>>
	|
	|-RVA: 0x236BE30 Offset: 0x236BF31 VA: 0x236BE30
	|-Array.InternalArray__set_Item<Dictionary.Entry<bool, object>>
	|
	|-RVA: 0x236BFC0 Offset: 0x236C0C1 VA: 0x236BFC0
	|-Array.InternalArray__set_Item<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x236C150 Offset: 0x236C251 VA: 0x236C150
	|-Array.InternalArray__set_Item<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x236C2E0 Offset: 0x236C3E1 VA: 0x236C2E0
	|-Array.InternalArray__set_Item<Dictionary.Entry<DateTime, object>>
	|
	|-RVA: 0x236C470 Offset: 0x236C571 VA: 0x236C470
	|-Array.InternalArray__set_Item<Dictionary.Entry<double, object>>
	|
	|-RVA: 0x236C600 Offset: 0x236C701 VA: 0x236C600
	|-Array.InternalArray__set_Item<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x236C790 Offset: 0x236C891 VA: 0x236C790
	|-Array.InternalArray__set_Item<Dictionary.Entry<short, object>>
	|
	|-RVA: 0x236C920 Offset: 0x236CA21 VA: 0x236C920
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, CropDataTable>>
	|
	|-RVA: 0x236CAB0 Offset: 0x236CBB1 VA: 0x236CAB0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, EffectDataTable>>
	|
	|-RVA: 0x236CC40 Offset: 0x236CD41 VA: 0x236CC40
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x236CDB0 Offset: 0x236CEB1 VA: 0x236CDB0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, MineTypeDataTable>>
	|
	|-RVA: 0x236CF60 Offset: 0x236D061 VA: 0x236CF60
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, MiningDataTable>>
	|
	|-RVA: 0x236D0F0 Offset: 0x236D1F1 VA: 0x236D0F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x236D260 Offset: 0x236D361 VA: 0x236D260
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x236D3D0 Offset: 0x236D4D1 VA: 0x236D3D0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x236D540 Offset: 0x236D641 VA: 0x236D540
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x236D6B0 Offset: 0x236D7B1 VA: 0x236D6B0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x236D840 Offset: 0x236D941 VA: 0x236D840
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x236D9D0 Offset: 0x236DAD1 VA: 0x236D9D0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x236DB70 Offset: 0x236DC71 VA: 0x236DB70
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, SceneInstance>>
	|
	|-RVA: 0x236DD00 Offset: 0x236DE01 VA: 0x236DD00
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Vector2Int>>
	|
	|-RVA: 0x236DE90 Offset: 0x236DF91 VA: 0x236DE90
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Vector3>>
	|
	|-RVA: 0x236E020 Offset: 0x236E121 VA: 0x236E020
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x236E1B0 Offset: 0x236E2B1 VA: 0x236E1B0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x236E350 Offset: 0x236E451 VA: 0x236E350
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x236E4F0 Offset: 0x236E5F1 VA: 0x236E4F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x236E660 Offset: 0x236E761 VA: 0x236E660
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x236E7F0 Offset: 0x236E8F1 VA: 0x236E7F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x236E960 Offset: 0x236EA61 VA: 0x236E960
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x236EAD0 Offset: 0x236EBD1 VA: 0x236EAD0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x236EC60 Offset: 0x236ED61 VA: 0x236EC60
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, float>>
	|
	|-RVA: 0x236EDD0 Offset: 0x236EED1 VA: 0x236EDD0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x236EF60 Offset: 0x236F061 VA: 0x236EF60
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x236F0F0 Offset: 0x236F1F1 VA: 0x236F0F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x236F280 Offset: 0x236F381 VA: 0x236F280
	|-Array.InternalArray__set_Item<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x236F410 Offset: 0x236F511 VA: 0x236F410
	|-Array.InternalArray__set_Item<Dictionary.Entry<Memory<object>, object>>
	|
	|-RVA: 0x236F5A0 Offset: 0x236F6A1 VA: 0x236F5A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x236F730 Offset: 0x236F831 VA: 0x236F730
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Bounds>, object>>
	|
	|-RVA: 0x236F8D0 Offset: 0x236F9D1 VA: 0x236F8D0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x236FA70 Offset: 0x236FB71 VA: 0x236FA70
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Color32>, object>>
	|
	|-RVA: 0x236FC00 Offset: 0x236FD01 VA: 0x236FC00
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Color>, object>>
	|
	|-RVA: 0x236FDA0 Offset: 0x236FEA1 VA: 0x236FDA0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x236FF30 Offset: 0x2370031 VA: 0x236FF30
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x23700D0 Offset: 0x23701D1 VA: 0x23700D0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x2370270 Offset: 0x2370371 VA: 0x2370270
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x2370400 Offset: 0x2370501 VA: 0x2370400
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x23705B0 Offset: 0x23706B1 VA: 0x23705B0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x2370750 Offset: 0x2370851 VA: 0x2370750
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x23708E0 Offset: 0x23709E1 VA: 0x23708E0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Rect>, object>>
	|
	|-RVA: 0x2370A80 Offset: 0x2370B81 VA: 0x2370A80
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<RectInt>, object>>
	|
	|-RVA: 0x2370C20 Offset: 0x2370D21 VA: 0x2370C20
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Vector2>, object>>
	|
	|-RVA: 0x2370DB0 Offset: 0x2370EB1 VA: 0x2370DB0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x2370F40 Offset: 0x2371041 VA: 0x2370F40
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Vector3>, object>>
	|
	|-RVA: 0x23710D0 Offset: 0x23711D1 VA: 0x23710D0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x2371260 Offset: 0x2371361 VA: 0x2371260
	|-Array.InternalArray__set_Item<Dictionary.Entry<Nullable<Vector4>, object>>
	|
	|-RVA: 0x2371400 Offset: 0x2371501 VA: 0x2371400
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, BitVector32Int>>
	|
	|-RVA: 0x2371590 Offset: 0x2371691 VA: 0x2371590
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, EventCheckId>>
	|
	|-RVA: 0x2371730 Offset: 0x2371831 VA: 0x2371730
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x23718E0 Offset: 0x23719E1 VA: 0x23718E0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x2371A80 Offset: 0x2371B81 VA: 0x2371A80
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x2371C10 Offset: 0x2371D11 VA: 0x2371C10
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x2371DA0 Offset: 0x2371EA1 VA: 0x2371DA0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, MonsterHutSaveData>>
	|
	|-RVA: 0x2371F40 Offset: 0x2372041 VA: 0x2371F40
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x23720D0 Offset: 0x23721D1 VA: 0x23720D0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, OrderSaveData>>
	|
	|-RVA: 0x2372270 Offset: 0x2372371 VA: 0x2372270
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, OrderSaveParameter>>
	|
	|-RVA: 0x2372410 Offset: 0x2372511 VA: 0x2372410
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Parameter>>
	|
	|-RVA: 0x23725A0 Offset: 0x23726A1 VA: 0x23725A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x2372730 Offset: 0x2372831 VA: 0x2372730
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x23728C0 Offset: 0x23729C1 VA: 0x23728C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x2372A50 Offset: 0x2372B51 VA: 0x2372A50
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, char>>
	|
	|-RVA: 0x2372BE0 Offset: 0x2372CE1 VA: 0x2372BE0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, DateTime>>
	|
	|-RVA: 0x2372D70 Offset: 0x2372E71 VA: 0x2372D70
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, double>>
	|
	|-RVA: 0x2372F00 Offset: 0x2373001 VA: 0x2372F00
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, short>>
	|
	|-RVA: 0x2373090 Offset: 0x2373191 VA: 0x2373090
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x2373220 Offset: 0x2373321 VA: 0x2373220
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x23733B0 Offset: 0x23734B1 VA: 0x23733B0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, long>>
	|
	|-RVA: 0x2373540 Offset: 0x2373641 VA: 0x2373540
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Memory<object>>>
	|
	|-RVA: 0x23736D0 Offset: 0x23737D1 VA: 0x23736D0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x2373860 Offset: 0x2373961 VA: 0x2373860
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Bounds>>>
	|
	|-RVA: 0x2373A00 Offset: 0x2373B01 VA: 0x2373A00
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x2373BA0 Offset: 0x2373CA1 VA: 0x2373BA0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Color32>>>
	|
	|-RVA: 0x2373D30 Offset: 0x2373E31 VA: 0x2373D30
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Color>>>
	|
	|-RVA: 0x2373ED0 Offset: 0x2373FD1 VA: 0x2373ED0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x2374060 Offset: 0x2374161 VA: 0x2374060
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x2374200 Offset: 0x2374301 VA: 0x2374200
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x23743A0 Offset: 0x23744A1 VA: 0x23743A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x2374530 Offset: 0x2374631 VA: 0x2374530
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x23746E0 Offset: 0x23747E1 VA: 0x23746E0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x2374880 Offset: 0x2374981 VA: 0x2374880
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x2374A10 Offset: 0x2374B11 VA: 0x2374A10
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Rect>>>
	|
	|-RVA: 0x2374BB0 Offset: 0x2374CB1 VA: 0x2374BB0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<RectInt>>>
	|
	|-RVA: 0x2374D50 Offset: 0x2374E51 VA: 0x2374D50
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Vector2>>>
	|
	|-RVA: 0x2374EE0 Offset: 0x2374FE1 VA: 0x2374EE0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x2375070 Offset: 0x2375171 VA: 0x2375070
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Vector3>>>
	|
	|-RVA: 0x2375200 Offset: 0x2375301 VA: 0x2375200
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x2375390 Offset: 0x2375491 VA: 0x2375390
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Nullable<Vector4>>>
	|
	|-RVA: 0x2375530 Offset: 0x2375631 VA: 0x2375530
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x23756C0 Offset: 0x23757C1 VA: 0x23756C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x2375850 Offset: 0x2375951 VA: 0x2375850
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x23759E0 Offset: 0x2375AE1 VA: 0x23759E0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, sbyte>>
	|
	|-RVA: 0x2375B70 Offset: 0x2375C71 VA: 0x2375B70
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x2375D00 Offset: 0x2375E01 VA: 0x2375D00
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x2375E90 Offset: 0x2375F91 VA: 0x2375E90
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, uint>>
	|
	|-RVA: 0x2376020 Offset: 0x2376121 VA: 0x2376020
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ulong>>
	|
	|-RVA: 0x23761B0 Offset: 0x23762B1 VA: 0x23761B0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, TransitionTables>>
	|
	|-RVA: 0x2376350 Offset: 0x2376451 VA: 0x2376350
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Bounds>>
	|
	|-RVA: 0x23764F0 Offset: 0x23765F1 VA: 0x23764F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, BoundsInt>>
	|
	|-RVA: 0x2376690 Offset: 0x2376791 VA: 0x2376690
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Color32>>
	|
	|-RVA: 0x2376820 Offset: 0x2376921 VA: 0x2376820
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Color>>
	|
	|-RVA: 0x23769B0 Offset: 0x2376AB1 VA: 0x23769B0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, GradientAlphaKey>>
	|
	|-RVA: 0x2376B40 Offset: 0x2376C41 VA: 0x2376B40
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, GradientColorKey>>
	|
	|-RVA: 0x2376CE0 Offset: 0x2376DE1 VA: 0x2376CE0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Keyframe>>
	|
	|-RVA: 0x2376E80 Offset: 0x2376F81 VA: 0x2376E80
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, LayerMask>>
	|
	|-RVA: 0x2377010 Offset: 0x2377111 VA: 0x2377010
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Matrix4x4>>
	|
	|-RVA: 0x23771C0 Offset: 0x23772C1 VA: 0x23771C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x2377350 Offset: 0x2377451 VA: 0x2377350
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Quaternion>>
	|
	|-RVA: 0x23774E0 Offset: 0x23775E1 VA: 0x23774E0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, RangeInt>>
	|
	|-RVA: 0x2377670 Offset: 0x2377771 VA: 0x2377670
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Rect>>
	|
	|-RVA: 0x2377800 Offset: 0x2377901 VA: 0x2377800
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, RectInt>>
	|
	|-RVA: 0x2377990 Offset: 0x2377A91 VA: 0x2377990
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2377B30 Offset: 0x2377C31 VA: 0x2377B30
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2377CD0 Offset: 0x2377DD1 VA: 0x2377CD0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Vector2>>
	|
	|-RVA: 0x2377E60 Offset: 0x2377F61 VA: 0x2377E60
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Vector2Int>>
	|
	|-RVA: 0x2377FF0 Offset: 0x23780F1 VA: 0x2377FF0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Vector3>>
	|
	|-RVA: 0x2378180 Offset: 0x2378281 VA: 0x2378180
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Vector3Int>>
	|
	|-RVA: 0x2378310 Offset: 0x2378411 VA: 0x2378310
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Vector4>>
	|
	|-RVA: 0x23784A0 Offset: 0x23785A1 VA: 0x23784A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x2378630 Offset: 0x2378731 VA: 0x2378630
	|-Array.InternalArray__set_Item<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x23787C0 Offset: 0x23788C1 VA: 0x23787C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x2378950 Offset: 0x2378A51 VA: 0x2378950
	|-Array.InternalArray__set_Item<Dictionary.Entry<float, CurveSample>>
	|
	|-RVA: 0x2378B10 Offset: 0x2378C11 VA: 0x2378B10
	|-Array.InternalArray__set_Item<Dictionary.Entry<float, object>>
	|
	|-RVA: 0x2378CA0 Offset: 0x2378DA1 VA: 0x2378CA0
	|-Array.InternalArray__set_Item<Dictionary.Entry<ushort, object>>
	|
	|-RVA: 0x2378E30 Offset: 0x2378F31 VA: 0x2378E30
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x2378FA0 Offset: 0x23790A1 VA: 0x2378FA0
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, Int32Enum>>
	|
	|-RVA: 0x2379110 Offset: 0x2379211 VA: 0x2379110
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x23792A0 Offset: 0x23793A1 VA: 0x23792A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x2379430 Offset: 0x2379531 VA: 0x2379430
	|-Array.InternalArray__set_Item<Dictionary.Entry<EdgeKeyByHash, int>>
	|
	|-RVA: 0x23795C0 Offset: 0x23796C1 VA: 0x23795C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x2379770 Offset: 0x2379871 VA: 0x2379770
	|-Array.InternalArray__set_Item<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x2379910 Offset: 0x2379A11 VA: 0x2379910
	|-Array.InternalArray__set_Item<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x2379AB0 Offset: 0x2379BB1 VA: 0x2379AB0
	|-Array.InternalArray__set_Item<Dictionary.Entry<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x2379C40 Offset: 0x2379D41 VA: 0x2379C40
	|-Array.InternalArray__set_Item<Dictionary.Entry<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x2379DD0 Offset: 0x2379ED1 VA: 0x2379DD0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Bounds, object>>
	|
	|-RVA: 0x2379F70 Offset: 0x237A071 VA: 0x2379F70
	|-Array.InternalArray__set_Item<Dictionary.Entry<BoundsInt, object>>
	|
	|-RVA: 0x237A110 Offset: 0x237A211 VA: 0x237A110
	|-Array.InternalArray__set_Item<Dictionary.Entry<Color, object>>
	|
	|-RVA: 0x237A2A0 Offset: 0x237A3A1 VA: 0x237A2A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Color32, object>>
	|
	|-RVA: 0x237A430 Offset: 0x237A531 VA: 0x237A430
	|-Array.InternalArray__set_Item<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x237A5C0 Offset: 0x237A6C1 VA: 0x237A5C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<GradientAlphaKey, object>>
	|
	|-RVA: 0x237A750 Offset: 0x237A851 VA: 0x237A750
	|-Array.InternalArray__set_Item<Dictionary.Entry<GradientColorKey, object>>
	|
	|-RVA: 0x237A8F0 Offset: 0x237A9F1 VA: 0x237A8F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Keyframe, object>>
	|
	|-RVA: 0x237AA90 Offset: 0x237AB91 VA: 0x237AA90
	|-Array.InternalArray__set_Item<Dictionary.Entry<LayerMask, object>>
	|
	|-RVA: 0x237AC20 Offset: 0x237AD21 VA: 0x237AC20
	|-Array.InternalArray__set_Item<Dictionary.Entry<Matrix4x4, object>>
	|
	|-RVA: 0x237ADD0 Offset: 0x237AED1 VA: 0x237ADD0
	|-Array.InternalArray__set_Item<Dictionary.Entry<IntVec3, object>>
	|
	|-RVA: 0x237AF60 Offset: 0x237B061 VA: 0x237AF60
	|-Array.InternalArray__set_Item<Dictionary.Entry<Quaternion, object>>
	|
	|-RVA: 0x237B0F0 Offset: 0x237B1F1 VA: 0x237B0F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<RangeInt, object>>
	|
	|-RVA: 0x237B280 Offset: 0x237B381 VA: 0x237B280
	|-Array.InternalArray__set_Item<Dictionary.Entry<Rect, object>>
	|
	|-RVA: 0x237B410 Offset: 0x237B511 VA: 0x237B410
	|-Array.InternalArray__set_Item<Dictionary.Entry<RectInt, object>>
	|
	|-RVA: 0x237B5A0 Offset: 0x237B6A1 VA: 0x237B5A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x237B730 Offset: 0x237B831 VA: 0x237B730
	|-Array.InternalArray__set_Item<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x237B8C0 Offset: 0x237B9C1 VA: 0x237B8C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Vector2, object>>
	|
	|-RVA: 0x237BA50 Offset: 0x237BB51 VA: 0x237BA50
	|-Array.InternalArray__set_Item<Dictionary.Entry<Vector2Int, object>>
	|
	|-RVA: 0x237BBE0 Offset: 0x237BCE1 VA: 0x237BBE0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Vector3, object>>
	|
	|-RVA: 0x237BD70 Offset: 0x237BE71 VA: 0x237BD70
	|-Array.InternalArray__set_Item<Dictionary.Entry<Vector3Int, object>>
	|
	|-RVA: 0x237BF00 Offset: 0x237C001 VA: 0x237BF00
	|-Array.InternalArray__set_Item<Dictionary.Entry<Vector4, object>>
	|
	|-RVA: 0x237C090 Offset: 0x237C191 VA: 0x237C090
	|-Array.InternalArray__set_Item<HashSet.Slot<int>>
	|
	|-RVA: 0x237C210 Offset: 0x237C311 VA: 0x237C210
	|-Array.InternalArray__set_Item<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x237C390 Offset: 0x237C491 VA: 0x237C390
	|-Array.InternalArray__set_Item<HashSet.Slot<object>>
	|
	|-RVA: 0x237C500 Offset: 0x237C601 VA: 0x237C500
	|-Array.InternalArray__set_Item<HashSet.Slot<uint>>
	|
	|-RVA: 0x237C680 Offset: 0x237C781 VA: 0x237C680
	|-Array.InternalArray__set_Item<HashSet.Slot<Edge>>
	|
	|-RVA: 0x237C7F0 Offset: 0x237C8F1 VA: 0x237C7F0
	|-Array.InternalArray__set_Item<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x237C980 Offset: 0x237CA81 VA: 0x237C980
	|-Array.InternalArray__set_Item<KeyValuePair<JSONDeserialization.TaskField, object>>
	|
	|-RVA: 0x237CB10 Offset: 0x237CC11 VA: 0x237CB10
	|-Array.InternalArray__set_Item<KeyValuePair<BitVector32Int, object>>
	|
	|-RVA: 0x237CC80 Offset: 0x237CD81 VA: 0x237CC80
	|-Array.InternalArray__set_Item<KeyValuePair<EventCheckId, object>>
	|
	|-RVA: 0x237CE10 Offset: 0x237CF11 VA: 0x237CE10
	|-Array.InternalArray__set_Item<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>
	|
	|-RVA: 0x237CFB0 Offset: 0x237D0B1 VA: 0x237CFB0
	|-Array.InternalArray__set_Item<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>
	|
	|-RVA: 0x237D140 Offset: 0x237D241 VA: 0x237D140
	|-Array.InternalArray__set_Item<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>
	|
	|-RVA: 0x237D2D0 Offset: 0x237D3D1 VA: 0x237D2D0
	|-Array.InternalArray__set_Item<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>
	|
	|-RVA: 0x237D460 Offset: 0x237D561 VA: 0x237D460
	|-Array.InternalArray__set_Item<KeyValuePair<MonsterHutSaveData, object>>
	|
	|-RVA: 0x237D600 Offset: 0x237D701 VA: 0x237D600
	|-Array.InternalArray__set_Item<KeyValuePair<OrderLotterySaveParameter, object>>
	|
	|-RVA: 0x25F29A0 Offset: 0x25F2AA1 VA: 0x25F29A0
	|-Array.InternalArray__set_Item<KeyValuePair<OrderSaveData, object>>
	|
	|-RVA: 0x25F2B40 Offset: 0x25F2C41 VA: 0x25F2B40
	|-Array.InternalArray__set_Item<KeyValuePair<OrderSaveParameter, object>>
	|
	|-RVA: 0x25F2CE0 Offset: 0x25F2DE1 VA: 0x25F2CE0
	|-Array.InternalArray__set_Item<KeyValuePair<Parameter, object>>
	|
	|-RVA: 0x25F2E70 Offset: 0x25F2F71 VA: 0x25F2E70
	|-Array.InternalArray__set_Item<KeyValuePair<bool, object>>
	|
	|-RVA: 0x25F2FE0 Offset: 0x25F30E1 VA: 0x25F2FE0
	|-Array.InternalArray__set_Item<KeyValuePair<byte, object>>
	|
	|-RVA: 0x25F3150 Offset: 0x25F3251 VA: 0x25F3150
	|-Array.InternalArray__set_Item<KeyValuePair<char, object>>
	|
	|-RVA: 0x25F32C0 Offset: 0x25F33C1 VA: 0x25F32C0
	|-Array.InternalArray__set_Item<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x25F3430 Offset: 0x25F3531 VA: 0x25F3430
	|-Array.InternalArray__set_Item<KeyValuePair<double, object>>
	|
	|-RVA: 0x25F35A0 Offset: 0x25F36A1 VA: 0x25F35A0
	|-Array.InternalArray__set_Item<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x25F3730 Offset: 0x25F3831 VA: 0x25F3730
	|-Array.InternalArray__set_Item<KeyValuePair<short, object>>
	|
	|-RVA: 0x25F38A0 Offset: 0x25F39A1 VA: 0x25F38A0
	|-Array.InternalArray__set_Item<KeyValuePair<int, CropDataTable>>
	|
	|-RVA: 0x25F3A30 Offset: 0x25F3B31 VA: 0x25F3A30
	|-Array.InternalArray__set_Item<KeyValuePair<int, EffectDataTable>>
	|
	|-RVA: 0x25F3BC0 Offset: 0x25F3CC1 VA: 0x25F3BC0
	|-Array.InternalArray__set_Item<KeyValuePair<int, GimmickLayoutDataTable>>
	|
	|-RVA: 0x25F3D30 Offset: 0x25F3E31 VA: 0x25F3D30
	|-Array.InternalArray__set_Item<KeyValuePair<int, MineTypeDataTable>>
	|
	|-RVA: 0x25F3EE0 Offset: 0x25F3FE1 VA: 0x25F3EE0
	|-Array.InternalArray__set_Item<KeyValuePair<int, MiningDataTable>>
	|
	|-RVA: 0x25F4070 Offset: 0x25F4171 VA: 0x25F4070
	|-Array.InternalArray__set_Item<KeyValuePair<int, bool>>
	|
	|-RVA: 0x25F41E0 Offset: 0x25F42E1 VA: 0x25F41E0
	|-Array.InternalArray__set_Item<KeyValuePair<int, char>>
	|
	|-RVA: 0x25F4350 Offset: 0x25F4451 VA: 0x25F4350
	|-Array.InternalArray__set_Item<KeyValuePair<int, int>>
	|
	|-RVA: 0x25F44C0 Offset: 0x25F45C1 VA: 0x25F44C0
	|-Array.InternalArray__set_Item<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x25F4630 Offset: 0x25F4731 VA: 0x25F4630
	|-Array.InternalArray__set_Item<KeyValuePair<int, long>>
	|
	|-RVA: 0x25F47A0 Offset: 0x25F48A1 VA: 0x25F47A0
	|-Array.InternalArray__set_Item<KeyValuePair<int, object>>
	|
	|-RVA: 0x25F4910 Offset: 0x25F4A11 VA: 0x25F4910
	|-Array.InternalArray__set_Item<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x25F4AB0 Offset: 0x25F4BB1 VA: 0x25F4AB0
	|-Array.InternalArray__set_Item<KeyValuePair<int, SceneInstance>>
	|
	|-RVA: 0x25F4C40 Offset: 0x25F4D41 VA: 0x25F4C40
	|-Array.InternalArray__set_Item<KeyValuePair<int, Vector2Int>>
	|
	|-RVA: 0x25F4DC0 Offset: 0x25F4EC1 VA: 0x25F4DC0
	|-Array.InternalArray__set_Item<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x25F4F30 Offset: 0x25F5031 VA: 0x25F4F30
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, MonsterDataTable>>
	|
	|-RVA: 0x25F50C0 Offset: 0x25F51C1 VA: 0x25F50C0
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>
	|
	|-RVA: 0x25F5260 Offset: 0x25F5361 VA: 0x25F5260
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>
	|
	|-RVA: 0x25F53F0 Offset: 0x25F54F1 VA: 0x25F53F0
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x25F5560 Offset: 0x25F5661 VA: 0x25F5560
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>
	|
	|-RVA: 0x25F56E0 Offset: 0x25F57E1 VA: 0x25F56E0
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x25F5850 Offset: 0x25F5951 VA: 0x25F5850
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x25F59C0 Offset: 0x25F5AC1 VA: 0x25F59C0
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x25F5B30 Offset: 0x25F5C31 VA: 0x25F5B30
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x25F5CA0 Offset: 0x25F5DA1 VA: 0x25F5CA0
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, ValueTuple<object, object>>>
	|
	|-RVA: 0x25F5E30 Offset: 0x25F5F31 VA: 0x25F5E30
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, ValueTuple<float, float>>>
	|
	|-RVA: 0x25F5FB0 Offset: 0x25F60B1 VA: 0x25F5FB0
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>
	|
	|-RVA: 0x25F6120 Offset: 0x25F6221 VA: 0x25F6120
	|-Array.InternalArray__set_Item<KeyValuePair<long, object>>
	|
	|-RVA: 0x25F6290 Offset: 0x25F6391 VA: 0x25F6290
	|-Array.InternalArray__set_Item<KeyValuePair<Memory<object>, object>>
	|
	|-RVA: 0x25F6420 Offset: 0x25F6521 VA: 0x25F6420
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Int32Enum>, object>>
	|
	|-RVA: 0x25F6590 Offset: 0x25F6691 VA: 0x25F6590
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Bounds>, object>>
	|
	|-RVA: 0x25F6730 Offset: 0x25F6831 VA: 0x25F6730
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<BoundsInt>, object>>
	|
	|-RVA: 0x25F68D0 Offset: 0x25F69D1 VA: 0x25F68D0
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Color32>, object>>
	|
	|-RVA: 0x25F6A40 Offset: 0x25F6B41 VA: 0x25F6A40
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Color>, object>>
	|
	|-RVA: 0x25F6BD0 Offset: 0x25F6CD1 VA: 0x25F6BD0
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<GradientAlphaKey>, object>>
	|
	|-RVA: 0x25F6D60 Offset: 0x25F6E61 VA: 0x25F6D60
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<GradientColorKey>, object>>
	|
	|-RVA: 0x25F6EF0 Offset: 0x25F6FF1 VA: 0x25F6EF0
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Keyframe>, object>>
	|
	|-RVA: 0x25F7090 Offset: 0x25F7191 VA: 0x25F7090
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<LayerMask>, object>>
	|
	|-RVA: 0x25F7200 Offset: 0x25F7301 VA: 0x25F7200
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Matrix4x4>, object>>
	|
	|-RVA: 0x25F73B0 Offset: 0x25F74B1 VA: 0x25F73B0
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Quaternion>, object>>
	|
	|-RVA: 0x25F7540 Offset: 0x25F7641 VA: 0x25F7540
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<RangeInt>, object>>
	|
	|-RVA: 0x25F76D0 Offset: 0x25F77D1 VA: 0x25F76D0
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Rect>, object>>
	|
	|-RVA: 0x25F7860 Offset: 0x25F7961 VA: 0x25F7860
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<RectInt>, object>>
	|
	|-RVA: 0x25F79F0 Offset: 0x25F7AF1 VA: 0x25F79F0
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Vector2>, object>>
	|
	|-RVA: 0x25F7B80 Offset: 0x25F7C81 VA: 0x25F7B80
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Vector2Int>, object>>
	|
	|-RVA: 0x25F7D10 Offset: 0x25F7E11 VA: 0x25F7D10
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Vector3>, object>>
	|
	|-RVA: 0x25F7EA0 Offset: 0x25F7FA1 VA: 0x25F7EA0
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Vector3Int>, object>>
	|
	|-RVA: 0x25F8030 Offset: 0x25F8131 VA: 0x25F8030
	|-Array.InternalArray__set_Item<KeyValuePair<Nullable<Vector4>, object>>
	|
	|-RVA: 0x25F81C0 Offset: 0x25F82C1 VA: 0x25F81C0
	|-Array.InternalArray__set_Item<KeyValuePair<object, BitVector32Int>>
	|
	|-RVA: 0x25F8330 Offset: 0x25F8431 VA: 0x25F8330
	|-Array.InternalArray__set_Item<KeyValuePair<object, EventCheckId>>
	|
	|-RVA: 0x25F84C0 Offset: 0x25F85C1 VA: 0x25F84C0
	|-Array.InternalArray__set_Item<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>
	|
	|-RVA: 0x25F8660 Offset: 0x25F8761 VA: 0x25F8660
	|-Array.InternalArray__set_Item<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>
	|
	|-RVA: 0x25F87F0 Offset: 0x25F88F1 VA: 0x25F87F0
	|-Array.InternalArray__set_Item<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>
	|
	|-RVA: 0x25F8980 Offset: 0x25F8A81 VA: 0x25F8980
	|-Array.InternalArray__set_Item<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>
	|
	|-RVA: 0x25F8B10 Offset: 0x25F8C11 VA: 0x25F8B10
	|-Array.InternalArray__set_Item<KeyValuePair<object, MonsterHutSaveData>>
	|
	|-RVA: 0x25F8CB0 Offset: 0x25F8DB1 VA: 0x25F8CB0
	|-Array.InternalArray__set_Item<KeyValuePair<object, OrderLotterySaveParameter>>
	|
	|-RVA: 0x25F8E40 Offset: 0x25F8F41 VA: 0x25F8E40
	|-Array.InternalArray__set_Item<KeyValuePair<object, OrderSaveData>>
	|
	|-RVA: 0x25F8FE0 Offset: 0x25F90E1 VA: 0x25F8FE0
	|-Array.InternalArray__set_Item<KeyValuePair<object, OrderSaveParameter>>
	|
	|-RVA: 0x25F9180 Offset: 0x25F9281 VA: 0x25F9180
	|-Array.InternalArray__set_Item<KeyValuePair<object, Parameter>>
	|
	|-RVA: 0x25F9310 Offset: 0x25F9411 VA: 0x25F9310
	|-Array.InternalArray__set_Item<KeyValuePair<object, NumberControl.ValueRange>>
	|
	|-RVA: 0x25F94A0 Offset: 0x25F95A1 VA: 0x25F94A0
	|-Array.InternalArray__set_Item<KeyValuePair<object, bool>>
	|
	|-RVA: 0x25F9610 Offset: 0x25F9711 VA: 0x25F9610
	|-Array.InternalArray__set_Item<KeyValuePair<object, byte>>
	|
	|-RVA: 0x25F9780 Offset: 0x25F9881 VA: 0x25F9780
	|-Array.InternalArray__set_Item<KeyValuePair<object, char>>
	|
	|-RVA: 0x25F98F0 Offset: 0x25F99F1 VA: 0x25F98F0
	|-Array.InternalArray__set_Item<KeyValuePair<object, DateTime>>
	|
	|-RVA: 0x25F9A60 Offset: 0x25F9B61 VA: 0x25F9A60
	|-Array.InternalArray__set_Item<KeyValuePair<object, double>>
	|
	|-RVA: 0x25F9BD0 Offset: 0x25F9CD1 VA: 0x25F9BD0
	|-Array.InternalArray__set_Item<KeyValuePair<object, short>>
	|
	|-RVA: 0x25F9D40 Offset: 0x25F9E41 VA: 0x25F9D40
	|-Array.InternalArray__set_Item<KeyValuePair<object, int>>
	|
	|-RVA: 0x25F9EB0 Offset: 0x25F9FB1 VA: 0x25F9EB0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x25FA020 Offset: 0x25FA121 VA: 0x25FA020
	|-Array.InternalArray__set_Item<KeyValuePair<object, long>>
	|
	|-RVA: 0x25FA190 Offset: 0x25FA291 VA: 0x25FA190
	|-Array.InternalArray__set_Item<KeyValuePair<object, Memory<object>>>
	|
	|-RVA: 0x25FA320 Offset: 0x25FA421 VA: 0x25FA320
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Int32Enum>>>
	|
	|-RVA: 0x25FA490 Offset: 0x25FA591 VA: 0x25FA490
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Bounds>>>
	|
	|-RVA: 0x25FA630 Offset: 0x25FA731 VA: 0x25FA630
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<BoundsInt>>>
	|
	|-RVA: 0x25FA7D0 Offset: 0x25FA8D1 VA: 0x25FA7D0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Color32>>>
	|
	|-RVA: 0x25FA940 Offset: 0x25FAA41 VA: 0x25FA940
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Color>>>
	|
	|-RVA: 0x25FAAD0 Offset: 0x25FABD1 VA: 0x25FAAD0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<GradientAlphaKey>>>
	|
	|-RVA: 0x25FAC60 Offset: 0x25FAD61 VA: 0x25FAC60
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<GradientColorKey>>>
	|
	|-RVA: 0x25FADF0 Offset: 0x25FAEF1 VA: 0x25FADF0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Keyframe>>>
	|
	|-RVA: 0x25FAF90 Offset: 0x25FB091 VA: 0x25FAF90
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<LayerMask>>>
	|
	|-RVA: 0x25FB100 Offset: 0x25FB201 VA: 0x25FB100
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Matrix4x4>>>
	|
	|-RVA: 0x25FB2B0 Offset: 0x25FB3B1 VA: 0x25FB2B0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Quaternion>>>
	|
	|-RVA: 0x25FB440 Offset: 0x25FB541 VA: 0x25FB440
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<RangeInt>>>
	|
	|-RVA: 0x25FB5D0 Offset: 0x25FB6D1 VA: 0x25FB5D0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Rect>>>
	|
	|-RVA: 0x25FB760 Offset: 0x25FB861 VA: 0x25FB760
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<RectInt>>>
	|
	|-RVA: 0x25FB8F0 Offset: 0x25FB9F1 VA: 0x25FB8F0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Vector2>>>
	|
	|-RVA: 0x25FBA80 Offset: 0x25FBB81 VA: 0x25FBA80
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Vector2Int>>>
	|
	|-RVA: 0x25FBC10 Offset: 0x25FBD11 VA: 0x25FBC10
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Vector3>>>
	|
	|-RVA: 0x25FBDA0 Offset: 0x25FBEA1 VA: 0x25FBDA0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Vector3Int>>>
	|
	|-RVA: 0x25FBF30 Offset: 0x25FC031 VA: 0x25FBF30
	|-Array.InternalArray__set_Item<KeyValuePair<object, Nullable<Vector4>>>
	|
	|-RVA: 0x25FC0C0 Offset: 0x25FC1C1 VA: 0x25FC0C0
	|-Array.InternalArray__set_Item<KeyValuePair<object, object>>
	|
	|-RVA: 0x25FC230 Offset: 0x25FC331 VA: 0x25FC230
	|-Array.InternalArray__set_Item<KeyValuePair<object, ReadOnlyMemory<object>>>
	|
	|-RVA: 0x25FC3C0 Offset: 0x25FC4C1 VA: 0x25FC3C0
	|-Array.InternalArray__set_Item<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x25FC550 Offset: 0x25FC651 VA: 0x25FC550
	|-Array.InternalArray__set_Item<KeyValuePair<object, sbyte>>
	|
	|-RVA: 0x25FC6C0 Offset: 0x25FC7C1 VA: 0x25FC6C0
	|-Array.InternalArray__set_Item<KeyValuePair<object, float>>
	|
	|-RVA: 0x25FC830 Offset: 0x25FC931 VA: 0x25FC830
	|-Array.InternalArray__set_Item<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x25FC9A0 Offset: 0x25FCAA1 VA: 0x25FC9A0
	|-Array.InternalArray__set_Item<KeyValuePair<object, uint>>
	|
	|-RVA: 0x25FCB10 Offset: 0x25FCC11 VA: 0x25FCB10
	|-Array.InternalArray__set_Item<KeyValuePair<object, ulong>>
	|
	|-RVA: 0x25FCC80 Offset: 0x25FCD81 VA: 0x25FCC80
	|-Array.InternalArray__set_Item<KeyValuePair<object, TransitionTables>>
	|
	|-RVA: 0x25FCE20 Offset: 0x25FCF21 VA: 0x25FCE20
	|-Array.InternalArray__set_Item<KeyValuePair<object, Bounds>>
	|
	|-RVA: 0x25FCFB0 Offset: 0x25FD0B1 VA: 0x25FCFB0
	|-Array.InternalArray__set_Item<KeyValuePair<object, BoundsInt>>
	|
	|-RVA: 0x25FD140 Offset: 0x25FD241 VA: 0x25FD140
	|-Array.InternalArray__set_Item<KeyValuePair<object, Color32>>
	|
	|-RVA: 0x25FD2B0 Offset: 0x25FD3B1 VA: 0x25FD2B0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Color>>
	|
	|-RVA: 0x25FD440 Offset: 0x25FD541 VA: 0x25FD440
	|-Array.InternalArray__set_Item<KeyValuePair<object, GradientAlphaKey>>
	|
	|-RVA: 0x25FD5B0 Offset: 0x25FD6B1 VA: 0x25FD5B0
	|-Array.InternalArray__set_Item<KeyValuePair<object, GradientColorKey>>
	|
	|-RVA: 0x25FD740 Offset: 0x25FD841 VA: 0x25FD740
	|-Array.InternalArray__set_Item<KeyValuePair<object, Keyframe>>
	|
	|-RVA: 0x25FD8E0 Offset: 0x25FD9E1 VA: 0x25FD8E0
	|-Array.InternalArray__set_Item<KeyValuePair<object, LayerMask>>
	|
	|-RVA: 0x25FDA50 Offset: 0x25FDB51 VA: 0x25FDA50
	|-Array.InternalArray__set_Item<KeyValuePair<object, Matrix4x4>>
	|
	|-RVA: 0x25FDC00 Offset: 0x25FDD01 VA: 0x25FDC00
	|-Array.InternalArray__set_Item<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x25FDD90 Offset: 0x25FDE91 VA: 0x25FDD90
	|-Array.InternalArray__set_Item<KeyValuePair<object, Quaternion>>
	|
	|-RVA: 0x25FDF20 Offset: 0x25FE021 VA: 0x25FDF20
	|-Array.InternalArray__set_Item<KeyValuePair<object, RangeInt>>
	|
	|-RVA: 0x25FE090 Offset: 0x25FE191 VA: 0x25FE090
	|-Array.InternalArray__set_Item<KeyValuePair<object, Rect>>
	|
	|-RVA: 0x25FE220 Offset: 0x25FE321 VA: 0x25FE220
	|-Array.InternalArray__set_Item<KeyValuePair<object, RectInt>>
	|
	|-RVA: 0x25FE3B0 Offset: 0x25FE4B1 VA: 0x25FE3B0
	|-Array.InternalArray__set_Item<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x25FE540 Offset: 0x25FE641 VA: 0x25FE540
	|-Array.InternalArray__set_Item<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x25FE6D0 Offset: 0x25FE7D1 VA: 0x25FE6D0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Vector2>>
	|
	|-RVA: 0x25FE840 Offset: 0x25FE941 VA: 0x25FE840
	|-Array.InternalArray__set_Item<KeyValuePair<object, Vector2Int>>
	|
	|-RVA: 0x25FE9B0 Offset: 0x25FEAB1 VA: 0x25FE9B0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Vector3>>
	|
	|-RVA: 0x25FEB40 Offset: 0x25FEC41 VA: 0x25FEB40
	|-Array.InternalArray__set_Item<KeyValuePair<object, Vector3Int>>
	|
	|-RVA: 0x25FECD0 Offset: 0x25FEDD1 VA: 0x25FECD0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Vector4>>
	|
	|-RVA: 0x25FEE60 Offset: 0x25FEF61 VA: 0x25FEE60
	|-Array.InternalArray__set_Item<KeyValuePair<ReadOnlyMemory<object>, object>>
	|
	|-RVA: 0x25FEFF0 Offset: 0x25FF0F1 VA: 0x25FEFF0
	|-Array.InternalArray__set_Item<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>
	|
	|-RVA: 0x25FF160 Offset: 0x25FF261 VA: 0x25FF160
	|-Array.InternalArray__set_Item<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x25FF2D0 Offset: 0x25FF3D1 VA: 0x25FF2D0
	|-Array.InternalArray__set_Item<KeyValuePair<float, CurveSample>>
	|
	|-RVA: 0x25FF480 Offset: 0x25FF581 VA: 0x25FF480
	|-Array.InternalArray__set_Item<KeyValuePair<float, object>>
	|
	|-RVA: 0x25FF5F0 Offset: 0x25FF6F1 VA: 0x25FF5F0
	|-Array.InternalArray__set_Item<KeyValuePair<ushort, object>>
	|
	|-RVA: 0x25FF760 Offset: 0x25FF861 VA: 0x25FF760
	|-Array.InternalArray__set_Item<KeyValuePair<uint, int>>
	|
	|-RVA: 0x25FF8D0 Offset: 0x25FF9D1 VA: 0x25FF8D0
	|-Array.InternalArray__set_Item<KeyValuePair<uint, Int32Enum>>
	|
	|-RVA: 0x25FFA40 Offset: 0x25FFB41 VA: 0x25FFA40
	|-Array.InternalArray__set_Item<KeyValuePair<uint, object>>
	|
	|-RVA: 0x25FFBB0 Offset: 0x25FFCB1 VA: 0x25FFBB0
	|-Array.InternalArray__set_Item<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x25FFD20 Offset: 0x25FFE21 VA: 0x25FFD20
	|-Array.InternalArray__set_Item<KeyValuePair<EdgeKeyByHash, int>>
	|
	|-RVA: 0x25FFEA0 Offset: 0x25FFFA1 VA: 0x25FFEA0
	|-Array.InternalArray__set_Item<KeyValuePair<EdgeKeyByHash, CapEdge>>
	|
	|-RVA: 0x2600040 Offset: 0x2600141 VA: 0x2600040
	|-Array.InternalArray__set_Item<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>
	|
	|-RVA: 0x26001E0 Offset: 0x26002E1 VA: 0x26001E0
	|-Array.InternalArray__set_Item<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>
	|
	|-RVA: 0x2600380 Offset: 0x2600481 VA: 0x2600380
	|-Array.InternalArray__set_Item<KeyValuePair<MeshDataConnectivity.Face, bool>>
	|
	|-RVA: 0x2600500 Offset: 0x2600601 VA: 0x2600500
	|-Array.InternalArray__set_Item<KeyValuePair<MeshDataConnectivity.Face, object>>
	|
	|-RVA: 0x2600670 Offset: 0x2600771 VA: 0x2600670
	|-Array.InternalArray__set_Item<KeyValuePair<Bounds, object>>
	|
	|-RVA: 0x2600800 Offset: 0x2600901 VA: 0x2600800
	|-Array.InternalArray__set_Item<KeyValuePair<BoundsInt, object>>
	|
	|-RVA: 0x2600990 Offset: 0x2600A91 VA: 0x2600990
	|-Array.InternalArray__set_Item<KeyValuePair<Color, object>>
	|
	|-RVA: 0x2600B20 Offset: 0x2600C21 VA: 0x2600B20
	|-Array.InternalArray__set_Item<KeyValuePair<Color32, object>>
	|
	|-RVA: 0x2600C90 Offset: 0x2600D91 VA: 0x2600C90
	|-Array.InternalArray__set_Item<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2600E00 Offset: 0x2600F01 VA: 0x2600E00
	|-Array.InternalArray__set_Item<KeyValuePair<GradientAlphaKey, object>>
	|
	|-RVA: 0x2600F70 Offset: 0x2601071 VA: 0x2600F70
	|-Array.InternalArray__set_Item<KeyValuePair<GradientColorKey, object>>
	|
	|-RVA: 0x2601100 Offset: 0x2601201 VA: 0x2601100
	|-Array.InternalArray__set_Item<KeyValuePair<Keyframe, object>>
	|
	|-RVA: 0x26012A0 Offset: 0x26013A1 VA: 0x26012A0
	|-Array.InternalArray__set_Item<KeyValuePair<LayerMask, object>>
	|
	|-RVA: 0x2601410 Offset: 0x2601511 VA: 0x2601410
	|-Array.InternalArray__set_Item<KeyValuePair<Matrix4x4, object>>
	|
	|-RVA: 0x26015C0 Offset: 0x26016C1 VA: 0x26015C0
	|-Array.InternalArray__set_Item<KeyValuePair<IntVec3, object>>
	|
	|-RVA: 0x2601750 Offset: 0x2601851 VA: 0x2601750
	|-Array.InternalArray__set_Item<KeyValuePair<Quaternion, object>>
	|
	|-RVA: 0x26018E0 Offset: 0x26019E1 VA: 0x26018E0
	|-Array.InternalArray__set_Item<KeyValuePair<RangeInt, object>>
	|
	|-RVA: 0x2601A50 Offset: 0x2601B51 VA: 0x2601A50
	|-Array.InternalArray__set_Item<KeyValuePair<Rect, object>>
	|
	|-RVA: 0x2601BE0 Offset: 0x2601CE1 VA: 0x2601BE0
	|-Array.InternalArray__set_Item<KeyValuePair<RectInt, object>>
	|
	|-RVA: 0x2601D70 Offset: 0x2601E71 VA: 0x2601D70
	|-Array.InternalArray__set_Item<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>
	|
	|-RVA: 0x2601EF0 Offset: 0x2601FF1 VA: 0x2601EF0
	|-Array.InternalArray__set_Item<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|
	|-RVA: 0x2602060 Offset: 0x2602161 VA: 0x2602060
	|-Array.InternalArray__set_Item<KeyValuePair<Vector2, object>>
	|
	|-RVA: 0x26021D0 Offset: 0x26022D1 VA: 0x26021D0
	|-Array.InternalArray__set_Item<KeyValuePair<Vector2Int, object>>
	|
	|-RVA: 0x2602340 Offset: 0x2602441 VA: 0x2602340
	|-Array.InternalArray__set_Item<KeyValuePair<Vector3, object>>
	|
	|-RVA: 0x26024D0 Offset: 0x26025D1 VA: 0x26024D0
	|-Array.InternalArray__set_Item<KeyValuePair<Vector3Int, object>>
	|
	|-RVA: 0x2602660 Offset: 0x2602761 VA: 0x2602660
	|-Array.InternalArray__set_Item<KeyValuePair<Vector4, object>>
	|
	|-RVA: 0x26027F0 Offset: 0x26028F1 VA: 0x26027F0
	|-Array.InternalArray__set_Item<Hashtable.bucket>
	|
	|-RVA: 0x2602980 Offset: 0x2602A81 VA: 0x2602980
	|-Array.InternalArray__set_Item<DateTime>
	|
	|-RVA: 0x2602AF0 Offset: 0x2602BF1 VA: 0x2602AF0
	|-Array.InternalArray__set_Item<DateTimeOffset>
	|
	|-RVA: 0x2602C60 Offset: 0x2602D61 VA: 0x2602C60
	|-Array.InternalArray__set_Item<Decimal>
	|
	|-RVA: 0x2602DD0 Offset: 0x2602ED1 VA: 0x2602DD0
	|-Array.InternalArray__set_Item<double>
	|
	|-RVA: 0x2602F40 Offset: 0x2603041 VA: 0x2602F40
	|-Array.InternalArray__set_Item<InternalCodePageDataItem>
	|
	|-RVA: 0x26030B0 Offset: 0x26031B1 VA: 0x26030B0
	|-Array.InternalArray__set_Item<InternalEncodingDataItem>
	|
	|-RVA: 0x2603220 Offset: 0x2603321 VA: 0x2603220
	|-Array.InternalArray__set_Item<Guid>
	|
	|-RVA: 0x2603390 Offset: 0x2603491 VA: 0x2603390
	|-Array.InternalArray__set_Item<short>
	|
	|-RVA: 0x2603500 Offset: 0x2603601 VA: 0x2603500
	|-Array.InternalArray__set_Item<int>
	|
	|-RVA: 0x2603670 Offset: 0x2603771 VA: 0x2603670
	|-Array.InternalArray__set_Item<Int32Enum>
	|
	|-RVA: 0x26037E0 Offset: 0x26038E1 VA: 0x26037E0
	|-Array.InternalArray__set_Item<long>
	|
	|-RVA: 0x2603950 Offset: 0x2603A51 VA: 0x2603950
	|-Array.InternalArray__set_Item<IntPtr>
	|
	|-RVA: 0x2603AC0 Offset: 0x2603BC1 VA: 0x2603AC0
	|-Array.InternalArray__set_Item<InterpretedFrameInfo>
	|
	|-RVA: 0x2603C30 Offset: 0x2603D31 VA: 0x2603C30
	|-Array.InternalArray__set_Item<LocalDefinition>
	|
	|-RVA: 0x2603DA0 Offset: 0x2603EA1 VA: 0x2603DA0
	|-Array.InternalArray__set_Item<RuntimeLabel>
	|
	|-RVA: 0x2603F20 Offset: 0x2604021 VA: 0x2603F20
	|-Array.InternalArray__set_Item<Set.Slot<int>>
	|
	|-RVA: 0x26040A0 Offset: 0x26041A1 VA: 0x26040A0
	|-Array.InternalArray__set_Item<Set.Slot<object>>
	|
	|-RVA: 0x2604230 Offset: 0x2604331 VA: 0x2604230
	|-Array.InternalArray__set_Item<Memory<object>>
	|
	|-RVA: 0x26043A0 Offset: 0x26044A1 VA: 0x26043A0
	|-Array.InternalArray__set_Item<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x2604510 Offset: 0x2604611 VA: 0x2604510
	|-Array.InternalArray__set_Item<HeaderVariantInfo>
	|
	|-RVA: 0x2604680 Offset: 0x2604781 VA: 0x2604680
	|-Array.InternalArray__set_Item<Socket.WSABUF>
	|
	|-RVA: 0x26047F0 Offset: 0x26048F1 VA: 0x26047F0
	|-Array.InternalArray__set_Item<Nullable<ReadOnlySequence<byte>>>
	|
	|-RVA: 0x2604990 Offset: 0x2604A91 VA: 0x2604990
	|-Array.InternalArray__set_Item<Nullable<Int32Enum>>
	|
	|-RVA: 0x2604B00 Offset: 0x2604C01 VA: 0x2604B00
	|-Array.InternalArray__set_Item<Nullable<Bounds>>
	|
	|-RVA: 0x2604CA0 Offset: 0x2604DA1 VA: 0x2604CA0
	|-Array.InternalArray__set_Item<Nullable<BoundsInt>>
	|
	|-RVA: 0x2604E40 Offset: 0x2604F41 VA: 0x2604E40
	|-Array.InternalArray__set_Item<Nullable<Color32>>
	|
	|-RVA: 0x2604FB0 Offset: 0x26050B1 VA: 0x2604FB0
	|-Array.InternalArray__set_Item<Nullable<Color>>
	|
	|-RVA: 0x2605140 Offset: 0x2605241 VA: 0x2605140
	|-Array.InternalArray__set_Item<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x26052C0 Offset: 0x26053C1 VA: 0x26052C0
	|-Array.InternalArray__set_Item<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2605450 Offset: 0x2605551 VA: 0x2605450
	|-Array.InternalArray__set_Item<Nullable<Keyframe>>
	|
	|-RVA: 0x26055E0 Offset: 0x26056E1 VA: 0x26055E0
	|-Array.InternalArray__set_Item<Nullable<LayerMask>>
	|
	|-RVA: 0x2605750 Offset: 0x2605851 VA: 0x2605750
	|-Array.InternalArray__set_Item<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2605900 Offset: 0x2605A01 VA: 0x2605900
	|-Array.InternalArray__set_Item<Nullable<Quaternion>>
	|
	|-RVA: 0x2605A90 Offset: 0x2605B91 VA: 0x2605A90
	|-Array.InternalArray__set_Item<Nullable<RangeInt>>
	|
	|-RVA: 0x2605C10 Offset: 0x2605D11 VA: 0x2605C10
	|-Array.InternalArray__set_Item<Nullable<Rect>>
	|
	|-RVA: 0x2605DA0 Offset: 0x2605EA1 VA: 0x2605DA0
	|-Array.InternalArray__set_Item<Nullable<RectInt>>
	|
	|-RVA: 0x2605F30 Offset: 0x2606031 VA: 0x2605F30
	|-Array.InternalArray__set_Item<Nullable<Vector2>>
	|
	|-RVA: 0x26060B0 Offset: 0x26061B1 VA: 0x26060B0
	|-Array.InternalArray__set_Item<Nullable<Vector2Int>>
	|
	|-RVA: 0x2606230 Offset: 0x2606331 VA: 0x2606230
	|-Array.InternalArray__set_Item<Nullable<Vector3>>
	|
	|-RVA: 0x26063A0 Offset: 0x26064A1 VA: 0x26063A0
	|-Array.InternalArray__set_Item<Nullable<Vector3Int>>
	|
	|-RVA: 0x2606510 Offset: 0x2606611 VA: 0x2606510
	|-Array.InternalArray__set_Item<Nullable<Vector4>>
	|
	|-RVA: 0x26066A0 Offset: 0x26067A1 VA: 0x26066A0
	|-Array.InternalArray__set_Item<object>
	|
	|-RVA: 0x26067F0 Offset: 0x26068F1 VA: 0x26067F0
	|-Array.InternalArray__set_Item<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x2606960 Offset: 0x2606A61 VA: 0x2606960
	|-Array.InternalArray__set_Item<ReadOnlyMemory<object>>
	|
	|-RVA: 0x2606AD0 Offset: 0x2606BD1 VA: 0x2606AD0
	|-Array.InternalArray__set_Item<CustomAttributeNamedArgument>
	|
	|-RVA: 0x2606C60 Offset: 0x2606D61 VA: 0x2606C60
	|-Array.InternalArray__set_Item<CustomAttributeTypedArgument>
	|
	|-RVA: 0x2606DD0 Offset: 0x2606ED1 VA: 0x2606DD0
	|-Array.InternalArray__set_Item<Label>
	|
	|-RVA: 0x2606F40 Offset: 0x2607041 VA: 0x2606F40
	|-Array.InternalArray__set_Item<ParameterModifier>
	|
	|-RVA: 0x26070B0 Offset: 0x26071B1 VA: 0x26070B0
	|-Array.InternalArray__set_Item<ResourceLocator>
	|
	|-RVA: 0x2607220 Offset: 0x2607321 VA: 0x2607220
	|-Array.InternalArray__set_Item<Ephemeron>
	|
	|-RVA: 0x2607390 Offset: 0x2607491 VA: 0x2607390
	|-Array.InternalArray__set_Item<GCHandle>
	|
	|-RVA: 0x2607500 Offset: 0x2607601 VA: 0x2607500
	|-Array.InternalArray__set_Item<RuntimeTypeHandle>
	|
	|-RVA: 0x2607670 Offset: 0x2607771 VA: 0x2607670
	|-Array.InternalArray__set_Item<sbyte>
	|
	|-RVA: 0x26077E0 Offset: 0x26078E1 VA: 0x26077E0
	|-Array.InternalArray__set_Item<X509ChainStatus>
	|
	|-RVA: 0x2607950 Offset: 0x2607A51 VA: 0x2607950
	|-Array.InternalArray__set_Item<float>
	|
	|-RVA: 0x2607AC0 Offset: 0x2607BC1 VA: 0x2607AC0
	|-Array.InternalArray__set_Item<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x2607C40 Offset: 0x2607D41 VA: 0x2607C40
	|-Array.InternalArray__set_Item<CancellationTokenRegistration>
	|
	|-RVA: 0x2607DD0 Offset: 0x2607ED1 VA: 0x2607DD0
	|-Array.InternalArray__set_Item<ThreadLocal.LinkedSlotVolatile<object>>
	|
	|-RVA: 0x2607F40 Offset: 0x2608041 VA: 0x2607F40
	|-Array.InternalArray__set_Item<TimeSpan>
	|
	|-RVA: 0x26080B0 Offset: 0x26081B1 VA: 0x26080B0
	|-Array.InternalArray__set_Item<ushort>
	|
	|-RVA: 0x2608220 Offset: 0x2608321 VA: 0x2608220
	|-Array.InternalArray__set_Item<UInt16Enum>
	|
	|-RVA: 0x2608390 Offset: 0x2608491 VA: 0x2608390
	|-Array.InternalArray__set_Item<uint>
	|
	|-RVA: 0x2608500 Offset: 0x2608601 VA: 0x2608500
	|-Array.InternalArray__set_Item<UInt32Enum>
	|
	|-RVA: 0x2608670 Offset: 0x2608771 VA: 0x2608670
	|-Array.InternalArray__set_Item<ulong>
	|
	|-RVA: 0x26087E0 Offset: 0x26088E1 VA: 0x26087E0
	|-Array.InternalArray__set_Item<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x2608950 Offset: 0x2608A51 VA: 0x2608950
	|-Array.InternalArray__set_Item<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2608AC0 Offset: 0x2608BC1 VA: 0x2608AC0
	|-Array.InternalArray__set_Item<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x2608C30 Offset: 0x2608D31 VA: 0x2608C30
	|-Array.InternalArray__set_Item<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x2608DA0 Offset: 0x2608EA1 VA: 0x2608DA0
	|-Array.InternalArray__set_Item<ValueTuple<object, object>>
	|
	|-RVA: 0x2608F10 Offset: 0x2609011 VA: 0x2608F10
	|-Array.InternalArray__set_Item<ValueTuple<object, float>>
	|
	|-RVA: 0x2609080 Offset: 0x2609181 VA: 0x2609080
	|-Array.InternalArray__set_Item<ValueTuple<float, object>>
	|
	|-RVA: 0x26091F0 Offset: 0x26092F1 VA: 0x26091F0
	|-Array.InternalArray__set_Item<ValueTuple<float, float>>
	|
	|-RVA: 0x2609360 Offset: 0x2609461 VA: 0x2609360
	|-Array.InternalArray__set_Item<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0x2609500 Offset: 0x2609601 VA: 0x2609500
	|-Array.InternalArray__set_Item<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2609680 Offset: 0x2609781 VA: 0x2609680
	|-Array.InternalArray__set_Item<ValueTuple<object, object, Vector3>>
	|
	|-RVA: 0x2609810 Offset: 0x2609911 VA: 0x2609810
	|-Array.InternalArray__set_Item<ValueTuple<object, object, Vector3, float>>
	|
	|-RVA: 0x26099A0 Offset: 0x2609AA1 VA: 0x26099A0
	|-Array.InternalArray__set_Item<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x2609B40 Offset: 0x2609C41 VA: 0x2609B40
	|-Array.InternalArray__set_Item<HighlightState>
	|
	|-RVA: 0x2609CD0 Offset: 0x2609DD1 VA: 0x2609CD0
	|-Array.InternalArray__set_Item<MaterialReference>
	|
	|-RVA: 0x2609E70 Offset: 0x2609F71 VA: 0x2609E70
	|-Array.InternalArray__set_Item<RichTextTagAttribute>
	|
	|-RVA: 0x260A000 Offset: 0x260A101 VA: 0x260A000
	|-Array.InternalArray__set_Item<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x260A1A0 Offset: 0x260A2A1 VA: 0x260A1A0
	|-Array.InternalArray__set_Item<TMP_CharacterInfo>
	|
	|-RVA: 0x260A330 Offset: 0x260A431 VA: 0x260A330
	|-Array.InternalArray__set_Item<TMP_FontWeightPair>
	|
	|-RVA: 0x260A4A0 Offset: 0x260A5A1 VA: 0x260A4A0
	|-Array.InternalArray__set_Item<TMP_LineInfo>
	|
	|-RVA: 0x260A660 Offset: 0x260A761 VA: 0x260A660
	|-Array.InternalArray__set_Item<TMP_LinkInfo>
	|
	|-RVA: 0x260A800 Offset: 0x260A901 VA: 0x260A800
	|-Array.InternalArray__set_Item<TMP_MeshInfo>
	|
	|-RVA: 0x260A9B0 Offset: 0x260AAB1 VA: 0x260A9B0
	|-Array.InternalArray__set_Item<TMP_PageInfo>
	|
	|-RVA: 0x260AB40 Offset: 0x260AC41 VA: 0x260AB40
	|-Array.InternalArray__set_Item<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x260ACC0 Offset: 0x260ADC1 VA: 0x260ACC0
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x260AE50 Offset: 0x260AF51 VA: 0x260AE50
	|-Array.InternalArray__set_Item<TMP_WordInfo>
	|
	|-RVA: 0x260AFE0 Offset: 0x260B0E1 VA: 0x260AFE0
	|-Array.InternalArray__set_Item<WordWrapState>
	|
	|-RVA: 0x260B170 Offset: 0x260B271 VA: 0x260B170
	|-Array.InternalArray__set_Item<TextPaneDatas.TextPaneData>
	|
	|-RVA: 0x260B310 Offset: 0x260B411 VA: 0x260B310
	|-Array.InternalArray__set_Item<TransitionTables>
	|
	|-RVA: 0x260B4A0 Offset: 0x260B5A1 VA: 0x260B4A0
	|-Array.InternalArray__set_Item<TutorialUnlockFlagData>
	|
	|-RVA: 0x260B620 Offset: 0x260B721 VA: 0x260B620
	|-Array.InternalArray__set_Item<UICheckOnBackRune.LinkSet>
	|
	|-RVA: 0x260B790 Offset: 0x260B891 VA: 0x260B790
	|-Array.InternalArray__set_Item<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x260B900 Offset: 0x260BA01 VA: 0x260B900
	|-Array.InternalArray__set_Item<CapEdge>
	|
	|-RVA: 0x260BAA0 Offset: 0x260BBA1 VA: 0x260BAA0
	|-Array.InternalArray__set_Item<ClippedEdge>
	|
	|-RVA: 0x260BC30 Offset: 0x260BD31 VA: 0x260BC30
	|-Array.InternalArray__set_Item<EdgeKeyByHash>
	|
	|-RVA: 0x260BDA0 Offset: 0x260BEA1 VA: 0x260BDA0
	|-Array.InternalArray__set_Item<EdgeKeyByIndex>
	|
	|-RVA: 0x260BF10 Offset: 0x260C011 VA: 0x260BF10
	|-Array.InternalArray__set_Item<MeshDataConnectivity.Face>
	|
	|-RVA: 0x260C080 Offset: 0x260C181 VA: 0x260C080
	|-Array.InternalArray__set_Item<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x260C210 Offset: 0x260C311 VA: 0x260C210
	|-Array.InternalArray__set_Item<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x260C3B0 Offset: 0x260C4B1 VA: 0x260C3B0
	|-Array.InternalArray__set_Item<NavMeshBuildMarkup>
	|
	|-RVA: 0x260C520 Offset: 0x260C621 VA: 0x260C520
	|-Array.InternalArray__set_Item<NavMeshBuildSource>
	|
	|-RVA: 0x260C6E0 Offset: 0x260C7E1 VA: 0x260C6E0
	|-Array.InternalArray__set_Item<ContentCatalogData.Bucket>
	|
	|-RVA: 0x260C850 Offset: 0x260C951 VA: 0x260C850
	|-Array.InternalArray__set_Item<ConstraintSource>
	|
	|-RVA: 0x260C9C0 Offset: 0x260CAC1 VA: 0x260C9C0
	|-Array.InternalArray__set_Item<PropertySceneHandle>
	|
	|-RVA: 0x260CB30 Offset: 0x260CC31 VA: 0x260CB30
	|-Array.InternalArray__set_Item<TransformStreamHandle>
	|
	|-RVA: 0x260CCB0 Offset: 0x260CDB1 VA: 0x260CCB0
	|-Array.InternalArray__set_Item<AnimatorClipInfo>
	|
	|-RVA: 0x260CE20 Offset: 0x260CF21 VA: 0x260CE20
	|-Array.InternalArray__set_Item<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x260CF90 Offset: 0x260D091 VA: 0x260CF90
	|-Array.InternalArray__set_Item<BoneWeight1>
	|
	|-RVA: 0x260D100 Offset: 0x260D201 VA: 0x260D100
	|-Array.InternalArray__set_Item<BoneWeight>
	|
	|-RVA: 0x260D290 Offset: 0x260D391 VA: 0x260D290
	|-Array.InternalArray__set_Item<BoundingSphere>
	|
	|-RVA: 0x260D400 Offset: 0x260D501 VA: 0x260D400
	|-Array.InternalArray__set_Item<Bounds>
	|
	|-RVA: 0x260D590 Offset: 0x260D691 VA: 0x260D590
	|-Array.InternalArray__set_Item<BoundsInt>
	|
	|-RVA: 0x260D720 Offset: 0x260D821 VA: 0x260D720
	|-Array.InternalArray__set_Item<CharacterInfo>
	|
	|-RVA: 0x260D8D0 Offset: 0x260D9D1 VA: 0x260D8D0
	|-Array.InternalArray__set_Item<Color32>
	|
	|-RVA: 0x260DA40 Offset: 0x260DB41 VA: 0x260DA40
	|-Array.InternalArray__set_Item<Color>
	|
	|-RVA: 0x260DBB0 Offset: 0x260DCB1 VA: 0x260DBB0
	|-Array.InternalArray__set_Item<CombineInstance>
	|
	|-RVA: 0x260DD70 Offset: 0x260DE71 VA: 0x260DD70
	|-Array.InternalArray__set_Item<ContactPoint2D>
	|
	|-RVA: 0x260DF10 Offset: 0x260E011 VA: 0x260DF10
	|-Array.InternalArray__set_Item<ContactPoint>
	|
	|-RVA: 0x260E0B0 Offset: 0x260E1B1 VA: 0x260E0B0
	|-Array.InternalArray__set_Item<RaycastResult>
	|
	|-RVA: 0x260E260 Offset: 0x260E361 VA: 0x260E260
	|-Array.InternalArray__set_Item<LightDataGI>
	|
	|-RVA: 0x260E410 Offset: 0x260E511 VA: 0x260E410
	|-Array.InternalArray__set_Item<TerrainUtility.TerrainMap.TileCoord>
	|
	|-RVA: 0x260E580 Offset: 0x260E681 VA: 0x260E580
	|-Array.InternalArray__set_Item<GradientAlphaKey>
	|
	|-RVA: 0x260E6F0 Offset: 0x260E7F1 VA: 0x260E6F0
	|-Array.InternalArray__set_Item<GradientColorKey>
	|
	|-RVA: 0x260E880 Offset: 0x260E981 VA: 0x260E880
	|-Array.InternalArray__set_Item<HumanBone>
	|
	|-RVA: 0x260EA20 Offset: 0x260EB21 VA: 0x260EA20
	|-Array.InternalArray__set_Item<Keyframe>
	|
	|-RVA: 0x260EBC0 Offset: 0x260ECC1 VA: 0x260EBC0
	|-Array.InternalArray__set_Item<LOD>
	|
	|-RVA: 0x260ED30 Offset: 0x260EE31 VA: 0x260ED30
	|-Array.InternalArray__set_Item<LayerMask>
	|
	|-RVA: 0x260EEA0 Offset: 0x260EFA1 VA: 0x260EEA0
	|-Array.InternalArray__set_Item<PlayerLoopSystem>
	|
	|-RVA: 0x260F040 Offset: 0x260F141 VA: 0x260F040
	|-Array.InternalArray__set_Item<Matrix4x4>
	|
	|-RVA: 0x260F1E0 Offset: 0x260F2E1 VA: 0x260F1E0
	|-Array.InternalArray__set_Item<ParticleSystem.Particle>
	|
	|-RVA: 0x260F370 Offset: 0x260F471 VA: 0x260F370
	|-Array.InternalArray__set_Item<PatchExtents>
	|
	|-RVA: 0x260F4E0 Offset: 0x260F5E1 VA: 0x260F4E0
	|-Array.InternalArray__set_Item<Plane>
	|
	|-RVA: 0x260F650 Offset: 0x260F751 VA: 0x260F650
	|-Array.InternalArray__set_Item<Playable>
	|
	|-RVA: 0x260F7C0 Offset: 0x260F8C1 VA: 0x260F7C0
	|-Array.InternalArray__set_Item<PlayableBinding>
	|
	|-RVA: 0x260F950 Offset: 0x260FA51 VA: 0x260F950
	|-Array.InternalArray__set_Item<PlayableGraph>
	|
	|-RVA: 0x260FAC0 Offset: 0x260FBC1 VA: 0x260FAC0
	|-Array.InternalArray__set_Item<Edge>
	|
	|-RVA: 0x260FC30 Offset: 0x260FD31 VA: 0x260FC30
	|-Array.InternalArray__set_Item<IntVec3>
	|
	|-RVA: 0x260FDB0 Offset: 0x260FEB1 VA: 0x260FDB0
	|-Array.InternalArray__set_Item<Quaternion>
	|
	|-RVA: 0x260FF20 Offset: 0x2610021 VA: 0x260FF20
	|-Array.InternalArray__set_Item<RangeInt>
	|
	|-RVA: 0x2610090 Offset: 0x2610191 VA: 0x2610090
	|-Array.InternalArray__set_Item<RaycastHit2D>
	|
	|-RVA: 0x2610230 Offset: 0x2610331 VA: 0x2610230
	|-Array.InternalArray__set_Item<RaycastHit>
	|
	|-RVA: 0x26103D0 Offset: 0x26104D1 VA: 0x26103D0
	|-Array.InternalArray__set_Item<Rect>
	|
	|-RVA: 0x2610540 Offset: 0x2610641 VA: 0x2610540
	|-Array.InternalArray__set_Item<RectInt>
	|
	|-RVA: 0x26106B0 Offset: 0x26107B1 VA: 0x26106B0
	|-Array.InternalArray__set_Item<RenderBuffer>
	|
	|-RVA: 0x2610820 Offset: 0x2610921 VA: 0x2610820
	|-Array.InternalArray__set_Item<BatchVisibility>
	|
	|-RVA: 0x26109A0 Offset: 0x2610AA1 VA: 0x26109A0
	|-Array.InternalArray__set_Item<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x2610B10 Offset: 0x2610C11 VA: 0x2610B10
	|-Array.InternalArray__set_Item<SphericalHarmonicsL2>
	|
	|-RVA: 0x2610CD0 Offset: 0x2610DD1 VA: 0x2610CD0
	|-Array.InternalArray__set_Item<VertexAttributeDescriptor>
	|
	|-RVA: 0x2610E40 Offset: 0x2610F41 VA: 0x2610E40
	|-Array.InternalArray__set_Item<AsyncOperationHandle>
	|
	|-RVA: 0x2610FD0 Offset: 0x26110D1 VA: 0x2610FD0
	|-Array.InternalArray__set_Item<AsyncOperationHandle<object>>
	|
	|-RVA: 0x2611160 Offset: 0x2611261 VA: 0x2611160
	|-Array.InternalArray__set_Item<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x26112F0 Offset: 0x26113F1 VA: 0x26112F0
	|-Array.InternalArray__set_Item<DiagnosticEvent>
	|
	|-RVA: 0x2611490 Offset: 0x2611591 VA: 0x2611490
	|-Array.InternalArray__set_Item<SceneInstance>
	|
	|-RVA: 0x2611600 Offset: 0x2611701 VA: 0x2611600
	|-Array.InternalArray__set_Item<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2611790 Offset: 0x2611891 VA: 0x2611790
	|-Array.InternalArray__set_Item<ObjectInitializationData>
	|
	|-RVA: 0x2611930 Offset: 0x2611A31 VA: 0x2611930
	|-Array.InternalArray__set_Item<SerializedType>
	|
	|-RVA: 0x2611AC0 Offset: 0x2611BC1 VA: 0x2611AC0
	|-Array.InternalArray__set_Item<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x2611C30 Offset: 0x2611D31 VA: 0x2611C30
	|-Array.InternalArray__set_Item<SkeletonBone>
	|
	|-RVA: 0x2611DD0 Offset: 0x2611ED1 VA: 0x2611DD0
	|-Array.InternalArray__set_Item<GlyphRect>
	|
	|-RVA: 0x2611F40 Offset: 0x2612041 VA: 0x2611F40
	|-Array.InternalArray__set_Item<GlyphMarshallingStruct>
	|
	|-RVA: 0x26120E0 Offset: 0x26121E1 VA: 0x26120E0
	|-Array.InternalArray__set_Item<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x2612280 Offset: 0x2612381 VA: 0x2612280
	|-Array.InternalArray__set_Item<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2612420 Offset: 0x2612521 VA: 0x2612420
	|-Array.InternalArray__set_Item<IntervalTreeNode>
	|
	|-RVA: 0x26125B0 Offset: 0x26126B1 VA: 0x26125B0
	|-Array.InternalArray__set_Item<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2612740 Offset: 0x2612841 VA: 0x2612740
	|-Array.InternalArray__set_Item<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x26128D0 Offset: 0x26129D1 VA: 0x26128D0
	|-Array.InternalArray__set_Item<Touch>
	|
	|-RVA: 0x2612A80 Offset: 0x2612B81 VA: 0x2612A80
	|-Array.InternalArray__set_Item<TreeInstance>
	|
	|-RVA: 0x2612C20 Offset: 0x2612D21 VA: 0x2612C20
	|-Array.InternalArray__set_Item<ColorBlock>
	|
	|-RVA: 0x2612DD0 Offset: 0x2612ED1 VA: 0x2612DD0
	|-Array.InternalArray__set_Item<Navigation>
	|
	|-RVA: 0x2612F70 Offset: 0x2613071 VA: 0x2612F70
	|-Array.InternalArray__set_Item<SpriteState>
	|
	|-RVA: 0x2613100 Offset: 0x2613201 VA: 0x2613100
	|-Array.InternalArray__set_Item<UICharInfo>
	|
	|-RVA: 0x2613280 Offset: 0x2613381 VA: 0x2613280
	|-Array.InternalArray__set_Item<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x26133F0 Offset: 0x26134F1 VA: 0x26133F0
	|-Array.InternalArray__set_Item<EventDispatcher.EventRecord>
	|
	|-RVA: 0x2613560 Offset: 0x2613661 VA: 0x2613560
	|-Array.InternalArray__set_Item<FocusController.FocusedElement>
	|
	|-RVA: 0x26136D0 Offset: 0x26137D1 VA: 0x26136D0
	|-Array.InternalArray__set_Item<StyleSheetCache.SheetHandleKey>
	|
	|-RVA: 0x2613840 Offset: 0x2613941 VA: 0x2613840
	|-Array.InternalArray__set_Item<StyleValue>
	|
	|-RVA: 0x26139D0 Offset: 0x2613AD1 VA: 0x26139D0
	|-Array.InternalArray__set_Item<UILineInfo>
	|
	|-RVA: 0x2613B40 Offset: 0x2613C41 VA: 0x2613B40
	|-Array.InternalArray__set_Item<UIVertex>
	|
	|-RVA: 0x2613CF0 Offset: 0x2613DF1 VA: 0x2613CF0
	|-Array.InternalArray__set_Item<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x2613E80 Offset: 0x2613F81 VA: 0x2613E80
	|-Array.InternalArray__set_Item<Vector2>
	|
	|-RVA: 0x2613FF0 Offset: 0x26140F1 VA: 0x2613FF0
	|-Array.InternalArray__set_Item<Vector2Int>
	|
	|-RVA: 0x2614160 Offset: 0x2614261 VA: 0x2614160
	|-Array.InternalArray__set_Item<Vector3>
	|
	|-RVA: 0x26142E0 Offset: 0x26143E1 VA: 0x26142E0
	|-Array.InternalArray__set_Item<Vector3Int>
	|
	|-RVA: 0x2614460 Offset: 0x2614561 VA: 0x2614460
	|-Array.InternalArray__set_Item<Vector4>
	|
	|-RVA: 0x26145D0 Offset: 0x26146D1 VA: 0x26145D0
	|-Array.InternalArray__set_Item<jvalue>
	|
	|-RVA: 0x2614740 Offset: 0x2614841 VA: 0x2614740
	|-Array.InternalArray__set_Item<WarpPoints.WarpPoint>
	|
	|-RVA: 0x2614900 Offset: 0x2614A01 VA: 0x2614900
	|-Array.InternalArray__set_Item<YieldItemParam>
	|
	|-RVA: 0x2614A70 Offset: 0x2614B71 VA: 0x2614A70
	|-Array.InternalArray__set_Item<NetworkServiceAccountId>
	|
	|-RVA: 0x2614BE0 Offset: 0x2614CE1 VA: 0x2614BE0
	|-Array.InternalArray__set_Item<Uid>
	|
	|-RVA: 0x2614D50 Offset: 0x2614E51 VA: 0x2614D50
	|-Array.InternalArray__set_Item<ConsumableServiceItemId>
	|
	|-RVA: 0x2614EC0 Offset: 0x2614FC1 VA: 0x2614EC0
	|-Array.InternalArray__set_Item<NsUid>
	|
	|-RVA: 0x2615030 Offset: 0x2615131 VA: 0x2615030
	|-Array.InternalArray__set_Item<Friend>
	|
	|-RVA: 0x26151C0 Offset: 0x26152C1 VA: 0x26151C0
	|-Array.InternalArray__set_Item<Profile>
	|
	|-RVA: 0x2615350 Offset: 0x2615451 VA: 0x2615350
	|-Array.InternalArray__set_Item<DirectoryEntry>
	|
	|-RVA: 0x26154E0 Offset: 0x26155E1 VA: 0x26154E0
	|-Array.InternalArray__set_Item<DebugPadState>
	|
	|-RVA: 0x2615670 Offset: 0x2615771 VA: 0x2615670
	|-Array.InternalArray__set_Item<GesturePoint>
	|
	|-RVA: 0x26157E0 Offset: 0x26158E1 VA: 0x26157E0
	|-Array.InternalArray__set_Item<GestureState>
	|
	|-RVA: 0x2615990 Offset: 0x2615A91 VA: 0x2615990
	|-Array.InternalArray__set_Item<NpadFullKeyState>
	|
	|-RVA: 0x2615B30 Offset: 0x2615C31 VA: 0x2615B30
	|-Array.InternalArray__set_Item<NpadHandheldState>
	|
	|-RVA: 0x2615CD0 Offset: 0x2615DD1 VA: 0x2615CD0
	|-Array.InternalArray__set_Item<NpadJoyDualState>
	|
	|-RVA: 0x264F9C0 Offset: 0x264FAC1 VA: 0x264F9C0
	|-Array.InternalArray__set_Item<NpadJoyLeftState>
	|
	|-RVA: 0x264FB60 Offset: 0x264FC61 VA: 0x264FB60
	|-Array.InternalArray__set_Item<NpadJoyRightState>
	|
	|-RVA: 0x264FD00 Offset: 0x264FE01 VA: 0x264FD00
	|-Array.InternalArray__set_Item<NpadStateArrayItem>
	|
	|-RVA: 0x264FEA0 Offset: 0x264FFA1 VA: 0x264FEA0
	|-Array.InternalArray__set_Item<SixAxisSensorHandle>
	|
	|-RVA: 0x2650010 Offset: 0x2650111 VA: 0x2650010
	|-Array.InternalArray__set_Item<SixAxisSensorState>
	|
	|-RVA: 0x26501C0 Offset: 0x26502C1 VA: 0x26501C0
	|-Array.InternalArray__set_Item<TouchScreenState10>
	|
	|-RVA: 0x2650350 Offset: 0x2650451 VA: 0x2650350
	|-Array.InternalArray__set_Item<TouchScreenState11>
	|
	|-RVA: 0x26504E0 Offset: 0x26505E1 VA: 0x26504E0
	|-Array.InternalArray__set_Item<TouchScreenState12>
	|
	|-RVA: 0x2650670 Offset: 0x2650771 VA: 0x2650670
	|-Array.InternalArray__set_Item<TouchScreenState13>
	|
	|-RVA: 0x2650800 Offset: 0x2650901 VA: 0x2650800
	|-Array.InternalArray__set_Item<TouchScreenState14>
	|
	|-RVA: 0x2650990 Offset: 0x2650A91 VA: 0x2650990
	|-Array.InternalArray__set_Item<TouchScreenState15>
	|
	|-RVA: 0x2650B20 Offset: 0x2650C21 VA: 0x2650B20
	|-Array.InternalArray__set_Item<TouchScreenState16>
	|
	|-RVA: 0x2650CB0 Offset: 0x2650DB1 VA: 0x2650CB0
	|-Array.InternalArray__set_Item<TouchScreenState1>
	|
	|-RVA: 0x2650E50 Offset: 0x2650F51 VA: 0x2650E50
	|-Array.InternalArray__set_Item<TouchScreenState2>
	|
	|-RVA: 0x2651000 Offset: 0x2651101 VA: 0x2651000
	|-Array.InternalArray__set_Item<TouchScreenState3>
	|
	|-RVA: 0x2651190 Offset: 0x2651291 VA: 0x2651190
	|-Array.InternalArray__set_Item<TouchScreenState4>
	|
	|-RVA: 0x2651320 Offset: 0x2651421 VA: 0x2651320
	|-Array.InternalArray__set_Item<TouchScreenState5>
	|
	|-RVA: 0x26514B0 Offset: 0x26515B1 VA: 0x26514B0
	|-Array.InternalArray__set_Item<TouchScreenState6>
	|
	|-RVA: 0x2651640 Offset: 0x2651741 VA: 0x2651640
	|-Array.InternalArray__set_Item<TouchScreenState7>
	|
	|-RVA: 0x26517D0 Offset: 0x26518D1 VA: 0x26517D0
	|-Array.InternalArray__set_Item<TouchScreenState8>
	|
	|-RVA: 0x2651960 Offset: 0x2651A61 VA: 0x2651960
	|-Array.InternalArray__set_Item<TouchScreenState9>
	|
	|-RVA: 0x2651AF0 Offset: 0x2651BF1 VA: 0x2651AF0
	|-Array.InternalArray__set_Item<TouchState>
	|
	|-RVA: 0x2651C90 Offset: 0x2651D91 VA: 0x2651C90
	|-Array.InternalArray__set_Item<VibrationDeviceHandle>
	|
	|-RVA: 0x2651E00 Offset: 0x2651F01 VA: 0x2651E00
	|-Array.InternalArray__set_Item<VibrationDeviceInfo>
	|
	|-RVA: 0x2651F70 Offset: 0x2652071 VA: 0x2651F70
	|-Array.InternalArray__set_Item<VibrationValue>
	|
	|-RVA: 0x26520E0 Offset: 0x26521E1 VA: 0x26520E0
	|-Array.InternalArray__set_Item<ClusteringData>
	|
	|-RVA: 0x2652270 Offset: 0x2652371 VA: 0x2652270
	|-Array.InternalArray__set_Item<ClusteringProcessorState>
	|
	|-RVA: 0x2652400 Offset: 0x2652501 VA: 0x2652400
	|-Array.InternalArray__set_Item<Finger>
	|
	|-RVA: 0x26525A0 Offset: 0x26526A1 VA: 0x26525A0
	|-Array.InternalArray__set_Item<Hand>
	|
	|-RVA: 0x2652730 Offset: 0x2652831 VA: 0x2652730
	|-Array.InternalArray__set_Item<HandAnalysisImageState>
	|
	|-RVA: 0x26528A0 Offset: 0x26529A1 VA: 0x26528A0
	|-Array.InternalArray__set_Item<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x2652A30 Offset: 0x2652B31 VA: 0x2652A30
	|-Array.InternalArray__set_Item<MomentProcessorState>
	|
	|-RVA: 0x2652BC0 Offset: 0x2652CC1 VA: 0x2652BC0
	|-Array.InternalArray__set_Item<MomentStatistic>
	|
	|-RVA: 0x2652D40 Offset: 0x2652E41 VA: 0x2652D40
	|-Array.InternalArray__set_Item<Protrusion>
	|
	|-RVA: 0x2652EB0 Offset: 0x2652FB1 VA: 0x2652EB0
	|-Array.InternalArray__set_Item<Shape>
	|
	|-RVA: 0x2653040 Offset: 0x2653141 VA: 0x2653040
	|-Array.InternalArray__set_Item<DictionaryInfo>
	|
	|-RVA: 0x26531B0 Offset: 0x26532B1 VA: 0x26531B0
	|-Array.InternalArray__set_Item<UserWord>
	|
	|-RVA: 0x2653320 Offset: 0x2653421 VA: 0x2653320
	|-Array.InternalArray__set_Item<Color4u8>
	|
	|-RVA: 0x2653490 Offset: 0x2653591 VA: 0x2653490
	|-Array.InternalArray__set_Item<Float2>
	|
	|-RVA: 0x2653600 Offset: 0x2653701 VA: 0x2653600
	|-Array.InternalArray__set_Item<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	internal void GetGenericValueImpl<T>(int pos, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Array.GetGenericValueImpl<object>
	*/

	// RVA: -1 Offset: -1
	internal void SetGenericValueImpl<T>(int pos, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Array.SetGenericValueImpl<object>
	*/

	[ReliabilityContractAttribute] // RVA: 0xB57A0 Offset: 0xB58A1 VA: 0xB57A0
	// RVA: 0x1848FC0 Offset: 0x18490C1 VA: 0x1848FC0
	public int get_Length() { }

	[ReliabilityContractAttribute] // RVA: 0xB57C0 Offset: 0xB58C1 VA: 0xB57C0
	// RVA: 0x18499B0 Offset: 0x1849AB1 VA: 0x18499B0
	public int get_Rank() { }

	// RVA: 0x184D6A0 Offset: 0x184D7A1 VA: 0x184D6A0
	private int GetRank() { }

	// RVA: 0x184B100 Offset: 0x184B201 VA: 0x184B100
	public int GetLength(int dimension) { }

	[ReliabilityContractAttribute] // RVA: 0xB57E0 Offset: 0xB58E1 VA: 0xB57E0
	// RVA: 0x18495B0 Offset: 0x18496B1 VA: 0x18495B0
	public int GetLowerBound(int dimension) { }

	// RVA: 0x184B670 Offset: 0x184B771 VA: 0x184B670
	public object GetValue(int[] indices) { }

	// RVA: 0x184CAC0 Offset: 0x184CBC1 VA: 0x184CAC0
	public void SetValue(object value, int[] indices) { }

	// RVA: 0x184D6B0 Offset: 0x184D7B1 VA: 0x184D6B0
	internal object GetValueImpl(int pos) { }

	// RVA: 0x184D6C0 Offset: 0x184D7C1 VA: 0x184D6C0
	internal void SetValueImpl(object value, int pos) { }

	// RVA: 0x184D6D0 Offset: 0x184D7D1 VA: 0x184D6D0
	internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length) { }

	// RVA: 0x184D6E0 Offset: 0x184D7E1 VA: 0x184D6E0
	internal static Array CreateInstanceImpl(Type elementType, int[] lengths, int[] bounds) { }

	[ReliabilityContractAttribute] // RVA: 0xB5800 Offset: 0xB5901 VA: 0xB5800
	// RVA: 0x184D6F0 Offset: 0x184D7F1 VA: 0x184D6F0
	public int GetUpperBound(int dimension) { }

	// RVA: 0x1849050 Offset: 0x1849151 VA: 0x1849050
	public object GetValue(int index) { }

	// RVA: 0x184B2A0 Offset: 0x184B3A1 VA: 0x184B2A0
	public object GetValue(int index1, int index2) { }

	// RVA: 0x184B440 Offset: 0x184B541 VA: 0x184B440
	public object GetValue(int index1, int index2, int index3) { }

	// RVA: 0x18491F0 Offset: 0x18492F1 VA: 0x18491F0
	public void SetValue(object value, int index) { }

	// RVA: 0x184C6B0 Offset: 0x184C7B1 VA: 0x184C6B0
	public void SetValue(object value, int index1, int index2) { }

	// RVA: 0x184C870 Offset: 0x184C971 VA: 0x184C870
	public void SetValue(object value, int index1, int index2, int index3) { }

	// RVA: 0x184D740 Offset: 0x184D841 VA: 0x184D740
	internal static Array UnsafeCreateInstance(Type elementType, int[] lengths, int[] lowerBounds) { }

	// RVA: 0x184DB10 Offset: 0x184DC11 VA: 0x184DB10
	internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2) { }

	// RVA: 0x184DBC0 Offset: 0x184DCC1 VA: 0x184DBC0
	internal static Array UnsafeCreateInstance(Type elementType, int[] lengths) { }

	// RVA: 0x184DBD0 Offset: 0x184DCD1 VA: 0x184DBD0
	public static Array CreateInstance(Type elementType, int length) { }

	// RVA: 0x184DB20 Offset: 0x184DC21 VA: 0x184DB20
	public static Array CreateInstance(Type elementType, int length1, int length2) { }

	// RVA: 0x184DC60 Offset: 0x184DD61 VA: 0x184DC60
	public static Array CreateInstance(Type elementType, int length1, int length2, int length3) { }

	// RVA: 0x1848CC0 Offset: 0x1848DC1 VA: 0x1848CC0
	public static Array CreateInstance(Type elementType, int[] lengths) { }

	// RVA: 0x184D750 Offset: 0x184D851 VA: 0x184D750
	public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds) { }

	[ReliabilityContractAttribute] // RVA: 0xB5820 Offset: 0xB5921 VA: 0xB5820
	// RVA: 0x18495C0 Offset: 0x18496C1 VA: 0x18495C0
	public static void Clear(Array array, int index, int length) { }

	// RVA: 0x184DD10 Offset: 0x184DE11 VA: 0x184DD10
	private static void ClearInternal(Array a, int index, int count) { }

	[ReliabilityContractAttribute] // RVA: 0xB5840 Offset: 0xB5941 VA: 0xB5840
	// RVA: 0x184ADF0 Offset: 0x184AEF1 VA: 0x184ADF0
	public static void Copy(Array sourceArray, Array destinationArray, int length) { }

	[ReliabilityContractAttribute] // RVA: 0xB5860 Offset: 0xB5961 VA: 0xB5860
	// RVA: 0x18499C0 Offset: 0x1849AC1 VA: 0x18499C0
	public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	// RVA: 0x184DD20 Offset: 0x184DE21 VA: 0x184DD20
	private static Exception CreateArrayTypeMismatchException() { }

	// RVA: 0x184DDD0 Offset: 0x184DED1 VA: 0x184DDD0
	private static bool CanAssignArrayElement(Type source, Type target) { }

	[ReliabilityContractAttribute] // RVA: 0xB5880 Offset: 0xB5981 VA: 0xB5880
	// RVA: 0x184DF40 Offset: 0x184E041 VA: 0x184DF40
	public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	// RVA: -1 Offset: -1
	public static T[] Empty<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226F830 Offset: 0x226F931 VA: 0x226F830
	|-Array.Empty<IMessagePackFormatter>
	|-Array.Empty<IFormatterResolver>
	|-Array.Empty<AutomataDictionary.AutomataNode>
	|-Array.Empty<Expression>
	|-Array.Empty<ParameterExpression>
	|-Array.Empty<ParameterInfo>
	|-Array.Empty<string[]>
	|-Array.Empty<Type>
	|-Array.Empty<GUILayoutOption>
	|-Array.Empty<IResourceLocation>
	|-Array.Empty<object>
	|-Array.Empty<string>
	|
	|-RVA: 0x226E390 Offset: 0x226E491 VA: 0x226E390
	|-Array.Empty<bool>
	|
	|-RVA: 0x226E440 Offset: 0x226E541 VA: 0x226E440
	|-Array.Empty<byte>
	|
	|-RVA: 0x226E650 Offset: 0x226E751 VA: 0x226E650
	|-Array.Empty<DateTime>
	|
	|-RVA: 0x226E700 Offset: 0x226E801 VA: 0x226E700
	|-Array.Empty<double>
	|
	|-RVA: 0x226E7B0 Offset: 0x226E8B1 VA: 0x226E7B0
	|-Array.Empty<short>
	|
	|-RVA: 0x226E860 Offset: 0x226E961 VA: 0x226E860
	|-Array.Empty<int>
	|
	|-RVA: 0x226E9C0 Offset: 0x226EAC1 VA: 0x226E9C0
	|-Array.Empty<long>
	|
	|-RVA: 0x226EA70 Offset: 0x226EB71 VA: 0x226EA70
	|-Array.Empty<LocalDefinition>
	|
	|-RVA: 0x226F8E0 Offset: 0x226F9E1 VA: 0x226F8E0
	|-Array.Empty<sbyte>
	|
	|-RVA: 0x226F990 Offset: 0x226FA91 VA: 0x226F990
	|-Array.Empty<float>
	|
	|-RVA: 0x226FA40 Offset: 0x226FB41 VA: 0x226FA40
	|-Array.Empty<ushort>
	|
	|-RVA: 0x226FAF0 Offset: 0x226FBF1 VA: 0x226FAF0
	|-Array.Empty<uint>
	|
	|-RVA: 0x226FBA0 Offset: 0x226FCA1 VA: 0x226FBA0
	|-Array.Empty<ulong>
	|
	|-RVA: 0x226E2E0 Offset: 0x226E3E1 VA: 0x226E2E0
	|-Array.Empty<DamageTextInfo>
	|
	|-RVA: 0x226E4F0 Offset: 0x226E5F1 VA: 0x226E4F0
	|-Array.Empty<char>
	|
	|-RVA: 0x226E5A0 Offset: 0x226E6A1 VA: 0x226E5A0
	|-Array.Empty<KeyValuePair<object, object>>
	|
	|-RVA: 0x226E910 Offset: 0x226EA11 VA: 0x226E910
	|-Array.Empty<Int32Enum>
	|
	|-RVA: 0x226EB20 Offset: 0x226EC21 VA: 0x226EB20
	|-Array.Empty<Nullable<Int32Enum>>
	|
	|-RVA: 0x226EBD0 Offset: 0x226ECD1 VA: 0x226EBD0
	|-Array.Empty<Nullable<Bounds>>
	|
	|-RVA: 0x226EC80 Offset: 0x226ED81 VA: 0x226EC80
	|-Array.Empty<Nullable<BoundsInt>>
	|
	|-RVA: 0x226ED30 Offset: 0x226EE31 VA: 0x226ED30
	|-Array.Empty<Nullable<Color32>>
	|
	|-RVA: 0x226EDE0 Offset: 0x226EEE1 VA: 0x226EDE0
	|-Array.Empty<Nullable<Color>>
	|
	|-RVA: 0x226EE90 Offset: 0x226EF91 VA: 0x226EE90
	|-Array.Empty<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x226EF40 Offset: 0x226F041 VA: 0x226EF40
	|-Array.Empty<Nullable<GradientColorKey>>
	|
	|-RVA: 0x226EFF0 Offset: 0x226F0F1 VA: 0x226EFF0
	|-Array.Empty<Nullable<Keyframe>>
	|
	|-RVA: 0x226F0A0 Offset: 0x226F1A1 VA: 0x226F0A0
	|-Array.Empty<Nullable<LayerMask>>
	|
	|-RVA: 0x226F150 Offset: 0x226F251 VA: 0x226F150
	|-Array.Empty<Nullable<Matrix4x4>>
	|
	|-RVA: 0x226F200 Offset: 0x226F301 VA: 0x226F200
	|-Array.Empty<Nullable<Quaternion>>
	|
	|-RVA: 0x226F2B0 Offset: 0x226F3B1 VA: 0x226F2B0
	|-Array.Empty<Nullable<RangeInt>>
	|
	|-RVA: 0x226F360 Offset: 0x226F461 VA: 0x226F360
	|-Array.Empty<Nullable<Rect>>
	|
	|-RVA: 0x226F410 Offset: 0x226F511 VA: 0x226F410
	|-Array.Empty<Nullable<RectInt>>
	|
	|-RVA: 0x226F4C0 Offset: 0x226F5C1 VA: 0x226F4C0
	|-Array.Empty<Nullable<Vector2>>
	|
	|-RVA: 0x226F570 Offset: 0x226F671 VA: 0x226F570
	|-Array.Empty<Nullable<Vector2Int>>
	|
	|-RVA: 0x226F620 Offset: 0x226F721 VA: 0x226F620
	|-Array.Empty<Nullable<Vector3>>
	|
	|-RVA: 0x226F6D0 Offset: 0x226F7D1 VA: 0x226F6D0
	|-Array.Empty<Nullable<Vector3Int>>
	|
	|-RVA: 0x226F780 Offset: 0x226F881 VA: 0x226F780
	|-Array.Empty<Nullable<Vector4>>
	|
	|-RVA: 0x226FC50 Offset: 0x226FD51 VA: 0x226FC50
	|-Array.Empty<Bounds>
	|
	|-RVA: 0x226FD00 Offset: 0x226FE01 VA: 0x226FD00
	|-Array.Empty<BoundsInt>
	|
	|-RVA: 0x226FDB0 Offset: 0x226FEB1 VA: 0x226FDB0
	|-Array.Empty<Color32>
	|
	|-RVA: 0x226FE60 Offset: 0x226FF61 VA: 0x226FE60
	|-Array.Empty<Color>
	|
	|-RVA: 0x226FF10 Offset: 0x2270011 VA: 0x226FF10
	|-Array.Empty<GradientAlphaKey>
	|
	|-RVA: 0x226FFC0 Offset: 0x22700C1 VA: 0x226FFC0
	|-Array.Empty<GradientColorKey>
	|
	|-RVA: 0x2270070 Offset: 0x2270171 VA: 0x2270070
	|-Array.Empty<Keyframe>
	|
	|-RVA: 0x2270120 Offset: 0x2270221 VA: 0x2270120
	|-Array.Empty<LayerMask>
	|
	|-RVA: 0x22701D0 Offset: 0x22702D1 VA: 0x22701D0
	|-Array.Empty<Matrix4x4>
	|
	|-RVA: 0x2270280 Offset: 0x2270381 VA: 0x2270280
	|-Array.Empty<Quaternion>
	|
	|-RVA: 0x2270330 Offset: 0x2270431 VA: 0x2270330
	|-Array.Empty<RangeInt>
	|
	|-RVA: 0x22703E0 Offset: 0x22704E1 VA: 0x22703E0
	|-Array.Empty<Rect>
	|
	|-RVA: 0x2270490 Offset: 0x2270591 VA: 0x2270490
	|-Array.Empty<RectInt>
	|
	|-RVA: 0x2270540 Offset: 0x2270641 VA: 0x2270540
	|-Array.Empty<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x22705F0 Offset: 0x22706F1 VA: 0x22705F0
	|-Array.Empty<EventDispatcher.DispatchContext>
	|
	|-RVA: 0x22706A0 Offset: 0x22707A1 VA: 0x22706A0
	|-Array.Empty<EventDispatcher.EventRecord>
	|
	|-RVA: 0x2270750 Offset: 0x2270851 VA: 0x2270750
	|-Array.Empty<Vector2>
	|
	|-RVA: 0x2270800 Offset: 0x2270901 VA: 0x2270800
	|-Array.Empty<Vector2Int>
	|
	|-RVA: 0x22708B0 Offset: 0x22709B1 VA: 0x22708B0
	|-Array.Empty<Vector3>
	|
	|-RVA: 0x2270960 Offset: 0x2270A61 VA: 0x2270960
	|-Array.Empty<Vector3Int>
	|
	|-RVA: 0x2270A10 Offset: 0x2270B11 VA: 0x2270A10
	|-Array.Empty<Vector4>
	*/

	// RVA: 0x184DF50 Offset: 0x184E051 VA: 0x184DF50
	public void Initialize() { }

	// RVA: -1 Offset: -1
	private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x261F1C0 Offset: 0x261F2C1 VA: 0x261F1C0
	|-Array.IndexOfImpl<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x261F250 Offset: 0x261F351 VA: 0x261F250
	|-Array.IndexOfImpl<BuildItemData>
	|
	|-RVA: 0x261F350 Offset: 0x261F451 VA: 0x261F350
	|-Array.IndexOfImpl<ButtonLinker.LinkObject>
	|
	|-RVA: 0x261F3C0 Offset: 0x261F4C1 VA: 0x261F3C0
	|-Array.IndexOfImpl<CharaCallTable.BustupTable>
	|
	|-RVA: 0x261F430 Offset: 0x261F531 VA: 0x261F430
	|-Array.IndexOfImpl<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x261F4A0 Offset: 0x261F5A1 VA: 0x261F4A0
	|-Array.IndexOfImpl<CameraState.CustomBlendable>
	|
	|-RVA: 0x261F510 Offset: 0x261F611 VA: 0x261F510
	|-Array.IndexOfImpl<CinemachineClearShot.Pair>
	|
	|-RVA: 0x261F570 Offset: 0x261F671 VA: 0x261F570
	|-Array.IndexOfImpl<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x261F5D0 Offset: 0x261F6D1 VA: 0x261F5D0
	|-Array.IndexOfImpl<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x261F670 Offset: 0x261F771 VA: 0x261F670
	|-Array.IndexOfImpl<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x261F720 Offset: 0x261F821 VA: 0x261F720
	|-Array.IndexOfImpl<CropDataTable>
	|
	|-RVA: 0x261F7D0 Offset: 0x261F8D1 VA: 0x261F7D0
	|-Array.IndexOfImpl<DropItemParam>
	|
	|-RVA: 0x261F830 Offset: 0x261F931 VA: 0x261F830
	|-Array.IndexOfImpl<ErosionBrush.UndoStep>
	|
	|-RVA: 0x261F8C0 Offset: 0x261F9C1 VA: 0x261F8C0
	|-Array.IndexOfImpl<EventCheckId>
	|
	|-RVA: 0x261F950 Offset: 0x261FA51 VA: 0x261F950
	|-Array.IndexOfImpl<EventFlagProgressData>
	|
	|-RVA: 0x261F9C0 Offset: 0x261FAC1 VA: 0x261F9C0
	|-Array.IndexOfImpl<FesNpcScoreData>
	|
	|-RVA: 0x261FA30 Offset: 0x261FB31 VA: 0x261FA30
	|-Array.IndexOfImpl<MiningPointSaveData>
	|
	|-RVA: 0x261FAE0 Offset: 0x261FBE1 VA: 0x261FAE0
	|-Array.IndexOfImpl<MonsterHutSaveData>
	|
	|-RVA: 0x261FB80 Offset: 0x261FC81 VA: 0x261FB80
	|-Array.IndexOfImpl<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x261FBF0 Offset: 0x261FCF1 VA: 0x261FBF0
	|-Array.IndexOfImpl<NPCActionData>
	|
	|-RVA: 0x261FCA0 Offset: 0x261FDA1 VA: 0x261FCA0
	|-Array.IndexOfImpl<NpcPlaceSchedule>
	|
	|-RVA: 0x261FD30 Offset: 0x261FE31 VA: 0x261FD30
	|-Array.IndexOfImpl<OrderLotterySaveParameter>
	|
	|-RVA: 0x261FDA0 Offset: 0x261FEA1 VA: 0x261FDA0
	|-Array.IndexOfImpl<OrderSaveParameter>
	|
	|-RVA: 0x261FE30 Offset: 0x261FF31 VA: 0x261FE30
	|-Array.IndexOfImpl<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x261FEA0 Offset: 0x261FFA1 VA: 0x261FEA0
	|-Array.IndexOfImpl<ShopCatalogPage>
	|
	|-RVA: 0x261FF10 Offset: 0x2620011 VA: 0x261FF10
	|-Array.IndexOfImpl<ShopNpcTalk>
	|
	|-RVA: 0x261FFB0 Offset: 0x26200B1 VA: 0x261FFB0
	|-Array.IndexOfImpl<SubtitleDataTable.Data>
	|
	|-RVA: 0x2620020 Offset: 0x2620121 VA: 0x2620020
	|-Array.IndexOfImpl<SubtitleDataTable.DataList>
	|
	|-RVA: 0x2620080 Offset: 0x2620181 VA: 0x2620080
	|-Array.IndexOfImpl<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x26200F0 Offset: 0x26201F1 VA: 0x26200F0
	|-Array.IndexOfImpl<ProfilerFrame>
	|
	|-RVA: 0x2620180 Offset: 0x2620281 VA: 0x2620180
	|-Array.IndexOfImpl<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x2620210 Offset: 0x2620311 VA: 0x2620210
	|-Array.IndexOfImpl<Schedule>
	|
	|-RVA: 0x26202A0 Offset: 0x26203A1 VA: 0x26202A0
	|-Array.IndexOfImpl<CurveSample>
	|
	|-RVA: 0x2620360 Offset: 0x2620461 VA: 0x2620360
	|-Array.IndexOfImpl<bool>
	|
	|-RVA: 0x26203C0 Offset: 0x26204C1 VA: 0x26203C0
	|-Array.IndexOfImpl<byte>
	|
	|-RVA: 0x2620420 Offset: 0x2620521 VA: 0x2620420
	|-Array.IndexOfImpl<char>
	|
	|-RVA: 0x2620480 Offset: 0x2620581 VA: 0x2620480
	|-Array.IndexOfImpl<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x26204F0 Offset: 0x26205F1 VA: 0x26204F0
	|-Array.IndexOfImpl<KeyValuePair<int, object>>
	|
	|-RVA: 0x2620560 Offset: 0x2620661 VA: 0x2620560
	|-Array.IndexOfImpl<KeyValuePair<object, object>>
	|
	|-RVA: 0x26205D0 Offset: 0x26206D1 VA: 0x26205D0
	|-Array.IndexOfImpl<DateTime>
	|
	|-RVA: 0x2620630 Offset: 0x2620731 VA: 0x2620630
	|-Array.IndexOfImpl<double>
	|
	|-RVA: 0x26206A0 Offset: 0x26207A1 VA: 0x26206A0
	|-Array.IndexOfImpl<short>
	|
	|-RVA: 0x2620700 Offset: 0x2620801 VA: 0x2620700
	|-Array.IndexOfImpl<int>
	|
	|-RVA: 0x2620760 Offset: 0x2620861 VA: 0x2620760
	|-Array.IndexOfImpl<Int32Enum>
	|
	|-RVA: 0x26207C0 Offset: 0x26208C1 VA: 0x26207C0
	|-Array.IndexOfImpl<long>
	|
	|-RVA: 0x2620820 Offset: 0x2620921 VA: 0x2620820
	|-Array.IndexOfImpl<InterpretedFrameInfo>
	|
	|-RVA: 0x2620890 Offset: 0x2620991 VA: 0x2620890
	|-Array.IndexOfImpl<Nullable<Int32Enum>>
	|
	|-RVA: 0x26208F0 Offset: 0x26209F1 VA: 0x26208F0
	|-Array.IndexOfImpl<Nullable<Bounds>>
	|
	|-RVA: 0x2620990 Offset: 0x2620A91 VA: 0x2620990
	|-Array.IndexOfImpl<Nullable<BoundsInt>>
	|
	|-RVA: 0x2620A30 Offset: 0x2620B31 VA: 0x2620A30
	|-Array.IndexOfImpl<Nullable<Color32>>
	|
	|-RVA: 0x2620A90 Offset: 0x2620B91 VA: 0x2620A90
	|-Array.IndexOfImpl<Nullable<Color>>
	|
	|-RVA: 0x2620B20 Offset: 0x2620C21 VA: 0x2620B20
	|-Array.IndexOfImpl<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2620B90 Offset: 0x2620C91 VA: 0x2620B90
	|-Array.IndexOfImpl<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2620C20 Offset: 0x2620D21 VA: 0x2620C20
	|-Array.IndexOfImpl<Nullable<Keyframe>>
	|
	|-RVA: 0x2620CB0 Offset: 0x2620DB1 VA: 0x2620CB0
	|-Array.IndexOfImpl<Nullable<LayerMask>>
	|
	|-RVA: 0x2620D10 Offset: 0x2620E11 VA: 0x2620D10
	|-Array.IndexOfImpl<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2620DE0 Offset: 0x2620EE1 VA: 0x2620DE0
	|-Array.IndexOfImpl<Nullable<Quaternion>>
	|
	|-RVA: 0x2620E70 Offset: 0x2620F71 VA: 0x2620E70
	|-Array.IndexOfImpl<Nullable<RangeInt>>
	|
	|-RVA: 0x2620EE0 Offset: 0x2620FE1 VA: 0x2620EE0
	|-Array.IndexOfImpl<Nullable<Rect>>
	|
	|-RVA: 0x2620F70 Offset: 0x2621071 VA: 0x2620F70
	|-Array.IndexOfImpl<Nullable<RectInt>>
	|
	|-RVA: 0x2621000 Offset: 0x2621101 VA: 0x2621000
	|-Array.IndexOfImpl<Nullable<Vector2>>
	|
	|-RVA: 0x2621070 Offset: 0x2621171 VA: 0x2621070
	|-Array.IndexOfImpl<Nullable<Vector2Int>>
	|
	|-RVA: 0x26210E0 Offset: 0x26211E1 VA: 0x26210E0
	|-Array.IndexOfImpl<Nullable<Vector3>>
	|
	|-RVA: 0x2621150 Offset: 0x2621251 VA: 0x2621150
	|-Array.IndexOfImpl<Nullable<Vector3Int>>
	|
	|-RVA: 0x26211C0 Offset: 0x26212C1 VA: 0x26211C0
	|-Array.IndexOfImpl<Nullable<Vector4>>
	|
	|-RVA: 0x2621250 Offset: 0x2621351 VA: 0x2621250
	|-Array.IndexOfImpl<object>
	|
	|-RVA: 0x26212B0 Offset: 0x26213B1 VA: 0x26212B0
	|-Array.IndexOfImpl<sbyte>
	|
	|-RVA: 0x2621310 Offset: 0x2621411 VA: 0x2621310
	|-Array.IndexOfImpl<float>
	|
	|-RVA: 0x2621380 Offset: 0x2621481 VA: 0x2621380
	|-Array.IndexOfImpl<ushort>
	|
	|-RVA: 0x26213E0 Offset: 0x26214E1 VA: 0x26213E0
	|-Array.IndexOfImpl<uint>
	|
	|-RVA: 0x2621440 Offset: 0x2621541 VA: 0x2621440
	|-Array.IndexOfImpl<ulong>
	|
	|-RVA: 0x26214A0 Offset: 0x26215A1 VA: 0x26214A0
	|-Array.IndexOfImpl<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x2621500 Offset: 0x2621601 VA: 0x2621500
	|-Array.IndexOfImpl<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2621560 Offset: 0x2621661 VA: 0x2621560
	|-Array.IndexOfImpl<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x26215D0 Offset: 0x26216D1 VA: 0x26215D0
	|-Array.IndexOfImpl<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x2621640 Offset: 0x2621741 VA: 0x2621640
	|-Array.IndexOfImpl<ValueTuple<object, object>>
	|
	|-RVA: 0x26216B0 Offset: 0x26217B1 VA: 0x26216B0
	|-Array.IndexOfImpl<ValueTuple<object, float>>
	|
	|-RVA: 0x2621720 Offset: 0x2621821 VA: 0x2621720
	|-Array.IndexOfImpl<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2621790 Offset: 0x2621891 VA: 0x2621790
	|-Array.IndexOfImpl<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x2621840 Offset: 0x2621941 VA: 0x2621840
	|-Array.IndexOfImpl<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x26218F0 Offset: 0x26219F1 VA: 0x26218F0
	|-Array.IndexOfImpl<TutorialUnlockFlagData>
	|
	|-RVA: 0x2621960 Offset: 0x2621A61 VA: 0x2621960
	|-Array.IndexOfImpl<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x26219D0 Offset: 0x2621AD1 VA: 0x26219D0
	|-Array.IndexOfImpl<CapEdge>
	|
	|-RVA: 0x2621A80 Offset: 0x2621B81 VA: 0x2621A80
	|-Array.IndexOfImpl<MeshDataConnectivity.Face>
	|
	|-RVA: 0x2621AE0 Offset: 0x2621BE1 VA: 0x2621AE0
	|-Array.IndexOfImpl<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x2621B70 Offset: 0x2621C71 VA: 0x2621B70
	|-Array.IndexOfImpl<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x2621C10 Offset: 0x2621D11 VA: 0x2621C10
	|-Array.IndexOfImpl<NavMeshBuildMarkup>
	|
	|-RVA: 0x2621C80 Offset: 0x2621D81 VA: 0x2621C80
	|-Array.IndexOfImpl<NavMeshBuildSource>
	|
	|-RVA: 0x2621D60 Offset: 0x2621E61 VA: 0x2621D60
	|-Array.IndexOfImpl<ConstraintSource>
	|
	|-RVA: 0x2621DD0 Offset: 0x2621ED1 VA: 0x2621DD0
	|-Array.IndexOfImpl<AnimatorClipInfo>
	|
	|-RVA: 0x2621E30 Offset: 0x2621F31 VA: 0x2621E30
	|-Array.IndexOfImpl<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x2621EA0 Offset: 0x2621FA1 VA: 0x2621EA0
	|-Array.IndexOfImpl<BoneWeight>
	|
	|-RVA: 0x2621F30 Offset: 0x2622031 VA: 0x2621F30
	|-Array.IndexOfImpl<Bounds>
	|
	|-RVA: 0x2621FC0 Offset: 0x26220C1 VA: 0x2621FC0
	|-Array.IndexOfImpl<BoundsInt>
	|
	|-RVA: 0x2622050 Offset: 0x2622151 VA: 0x2622050
	|-Array.IndexOfImpl<Color32>
	|
	|-RVA: 0x26220B0 Offset: 0x26221B1 VA: 0x26220B0
	|-Array.IndexOfImpl<Color>
	|
	|-RVA: 0x2622140 Offset: 0x2622241 VA: 0x2622140
	|-Array.IndexOfImpl<CombineInstance>
	|
	|-RVA: 0x2622220 Offset: 0x2622321 VA: 0x2622220
	|-Array.IndexOfImpl<RaycastResult>
	|
	|-RVA: 0x26222E0 Offset: 0x26223E1 VA: 0x26222E0
	|-Array.IndexOfImpl<GradientAlphaKey>
	|
	|-RVA: 0x2622350 Offset: 0x2622451 VA: 0x2622350
	|-Array.IndexOfImpl<GradientColorKey>
	|
	|-RVA: 0x26223E0 Offset: 0x26224E1 VA: 0x26223E0
	|-Array.IndexOfImpl<Keyframe>
	|
	|-RVA: 0x2622480 Offset: 0x2622581 VA: 0x2622480
	|-Array.IndexOfImpl<LayerMask>
	|
	|-RVA: 0x26224E0 Offset: 0x26225E1 VA: 0x26224E0
	|-Array.IndexOfImpl<Matrix4x4>
	|
	|-RVA: 0x2622590 Offset: 0x2622691 VA: 0x2622590
	|-Array.IndexOfImpl<ParticleSystem.Particle>
	|
	|-RVA: 0x2622640 Offset: 0x2622741 VA: 0x2622640
	|-Array.IndexOfImpl<Playable>
	|
	|-RVA: 0x26226B0 Offset: 0x26227B1 VA: 0x26226B0
	|-Array.IndexOfImpl<PlayableBinding>
	|
	|-RVA: 0x2622740 Offset: 0x2622841 VA: 0x2622740
	|-Array.IndexOfImpl<PlayableGraph>
	|
	|-RVA: 0x26227B0 Offset: 0x26228B1 VA: 0x26227B0
	|-Array.IndexOfImpl<Edge>
	|
	|-RVA: 0x2622810 Offset: 0x2622911 VA: 0x2622810
	|-Array.IndexOfImpl<Quaternion>
	|
	|-RVA: 0x26228A0 Offset: 0x26229A1 VA: 0x26228A0
	|-Array.IndexOfImpl<RangeInt>
	|
	|-RVA: 0x2622900 Offset: 0x2622A01 VA: 0x2622900
	|-Array.IndexOfImpl<RaycastHit2D>
	|
	|-RVA: 0x26229B0 Offset: 0x2622AB1 VA: 0x26229B0
	|-Array.IndexOfImpl<RaycastHit>
	|
	|-RVA: 0x2622A60 Offset: 0x2622B61 VA: 0x2622A60
	|-Array.IndexOfImpl<Rect>
	|
	|-RVA: 0x2622AF0 Offset: 0x2622BF1 VA: 0x2622AF0
	|-Array.IndexOfImpl<RectInt>
	|
	|-RVA: 0x2622B60 Offset: 0x2622C61 VA: 0x2622B60
	|-Array.IndexOfImpl<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x2622BD0 Offset: 0x2622CD1 VA: 0x2622BD0
	|-Array.IndexOfImpl<SphericalHarmonicsL2>
	|
	|-RVA: 0x2622CD0 Offset: 0x2622DD1 VA: 0x2622CD0
	|-Array.IndexOfImpl<VertexAttributeDescriptor>
	|
	|-RVA: 0x2622D40 Offset: 0x2622E41 VA: 0x2622D40
	|-Array.IndexOfImpl<AsyncOperationHandle>
	|
	|-RVA: 0x2622DD0 Offset: 0x2622ED1 VA: 0x2622DD0
	|-Array.IndexOfImpl<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x2622E60 Offset: 0x2622F61 VA: 0x2622E60
	|-Array.IndexOfImpl<DiagnosticEvent>
	|
	|-RVA: 0x2622F00 Offset: 0x2623001 VA: 0x2622F00
	|-Array.IndexOfImpl<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2622F90 Offset: 0x2623091 VA: 0x2622F90
	|-Array.IndexOfImpl<ObjectInitializationData>
	|
	|-RVA: 0x2623030 Offset: 0x2623131 VA: 0x2623030
	|-Array.IndexOfImpl<GlyphRect>
	|
	|-RVA: 0x26230A0 Offset: 0x26231A1 VA: 0x26230A0
	|-Array.IndexOfImpl<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2623140 Offset: 0x2623241 VA: 0x2623140
	|-Array.IndexOfImpl<IntervalTreeNode>
	|
	|-RVA: 0x26231D0 Offset: 0x26232D1 VA: 0x26231D0
	|-Array.IndexOfImpl<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2623260 Offset: 0x2623361 VA: 0x2623260
	|-Array.IndexOfImpl<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x26232F0 Offset: 0x26233F1 VA: 0x26232F0
	|-Array.IndexOfImpl<UICharInfo>
	|
	|-RVA: 0x2623370 Offset: 0x2623471 VA: 0x2623370
	|-Array.IndexOfImpl<FocusController.FocusedElement>
	|
	|-RVA: 0x26233E0 Offset: 0x26234E1 VA: 0x26233E0
	|-Array.IndexOfImpl<UILineInfo>
	|
	|-RVA: 0x2623450 Offset: 0x2623551 VA: 0x2623450
	|-Array.IndexOfImpl<UIVertex>
	|
	|-RVA: 0x2623520 Offset: 0x2623621 VA: 0x2623520
	|-Array.IndexOfImpl<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x26235B0 Offset: 0x26236B1 VA: 0x26235B0
	|-Array.IndexOfImpl<Vector2>
	|
	|-RVA: 0x2623620 Offset: 0x2623721 VA: 0x2623620
	|-Array.IndexOfImpl<Vector2Int>
	|
	|-RVA: 0x2623680 Offset: 0x2623781 VA: 0x2623680
	|-Array.IndexOfImpl<Vector3>
	|
	|-RVA: 0x2623700 Offset: 0x2623801 VA: 0x2623700
	|-Array.IndexOfImpl<Vector3Int>
	|
	|-RVA: 0x2623770 Offset: 0x2623871 VA: 0x2623770
	|-Array.IndexOfImpl<Vector4>
	|
	|-RVA: 0x2623800 Offset: 0x2623901 VA: 0x2623800
	|-Array.IndexOfImpl<WarpPoints.WarpPoint>
	|
	|-RVA: 0x2623900 Offset: 0x2623A01 VA: 0x2623900
	|-Array.IndexOfImpl<YieldItemParam>
	|
	|-RVA: 0x2623960 Offset: 0x2623A61 VA: 0x2623960
	|-Array.IndexOfImpl<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25573A0 Offset: 0x25574A1 VA: 0x25573A0
	|-Array.LastIndexOfImpl<KeyValuePair<object, object>>
	|
	|-RVA: 0x2557410 Offset: 0x2557511 VA: 0x2557410
	|-Array.LastIndexOfImpl<int>
	|
	|-RVA: 0x2557470 Offset: 0x2557571 VA: 0x2557470
	|-Array.LastIndexOfImpl<Int32Enum>
	|
	|-RVA: 0x25574D0 Offset: 0x25575D1 VA: 0x25574D0
	|-Array.LastIndexOfImpl<object>
	|
	|-RVA: 0x2557530 Offset: 0x2557631 VA: 0x2557530
	|-Array.LastIndexOfImpl<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x25575C0 Offset: 0x25576C1 VA: 0x25575C0
	|-Array.LastIndexOfImpl<EventDispatcher.DispatchContext>
	*/

	// RVA: 0x184D1D0 Offset: 0x184D2D1 VA: 0x184D1D0
	private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer) { }

	// RVA: -1 Offset: -1
	internal static T UnsafeLoad<T>(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2261090 Offset: 0x2261191 VA: 0x2261090
	|-Array.UnsafeLoad<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x22610E0 Offset: 0x22611E1 VA: 0x22610E0
	|-Array.UnsafeLoad<BuildItemData>
	|
	|-RVA: 0x2261160 Offset: 0x2261261 VA: 0x2261160
	|-Array.UnsafeLoad<ButtonLinker.LinkObject>
	|
	|-RVA: 0x22611A0 Offset: 0x22612A1 VA: 0x22611A0
	|-Array.UnsafeLoad<CharaCallTable.BustupTable>
	|
	|-RVA: 0x22611E0 Offset: 0x22612E1 VA: 0x22611E0
	|-Array.UnsafeLoad<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x2261230 Offset: 0x2261331 VA: 0x2261230
	|-Array.UnsafeLoad<CameraState.CustomBlendable>
	|
	|-RVA: 0x2261270 Offset: 0x2261371 VA: 0x2261270
	|-Array.UnsafeLoad<CinemachineClearShot.Pair>
	|
	|-RVA: 0x22612B0 Offset: 0x22613B1 VA: 0x22612B0
	|-Array.UnsafeLoad<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x22612F0 Offset: 0x22613F1 VA: 0x22612F0
	|-Array.UnsafeLoad<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2261340 Offset: 0x2261441 VA: 0x2261340
	|-Array.UnsafeLoad<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x22613A0 Offset: 0x22614A1 VA: 0x22613A0
	|-Array.UnsafeLoad<CropDataTable>
	|
	|-RVA: 0x22613F0 Offset: 0x22614F1 VA: 0x22613F0
	|-Array.UnsafeLoad<DropItemParam>
	|
	|-RVA: 0x2261430 Offset: 0x2261531 VA: 0x2261430
	|-Array.UnsafeLoad<ErosionBrush.UndoStep>
	|
	|-RVA: 0x2261480 Offset: 0x2261581 VA: 0x2261480
	|-Array.UnsafeLoad<EventCheckId>
	|
	|-RVA: 0x22614D0 Offset: 0x22615D1 VA: 0x22614D0
	|-Array.UnsafeLoad<EventFlagProgressData>
	|
	|-RVA: 0x2261510 Offset: 0x2261611 VA: 0x2261510
	|-Array.UnsafeLoad<FesNpcScoreData>
	|
	|-RVA: 0x2261550 Offset: 0x2261651 VA: 0x2261550
	|-Array.UnsafeLoad<MiningPointSaveData>
	|
	|-RVA: 0x22615B0 Offset: 0x22616B1 VA: 0x22615B0
	|-Array.UnsafeLoad<MonsterHutSaveData>
	|
	|-RVA: 0x2261600 Offset: 0x2261701 VA: 0x2261600
	|-Array.UnsafeLoad<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x2261640 Offset: 0x2261741 VA: 0x2261640
	|-Array.UnsafeLoad<NPCActionData>
	|
	|-RVA: 0x22616A0 Offset: 0x22617A1 VA: 0x22616A0
	|-Array.UnsafeLoad<NpcPlaceSchedule>
	|
	|-RVA: 0x22616F0 Offset: 0x22617F1 VA: 0x22616F0
	|-Array.UnsafeLoad<OrderLotterySaveParameter>
	|
	|-RVA: 0x2261740 Offset: 0x2261841 VA: 0x2261740
	|-Array.UnsafeLoad<OrderSaveParameter>
	|
	|-RVA: 0x2261790 Offset: 0x2261891 VA: 0x2261790
	|-Array.UnsafeLoad<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x22617D0 Offset: 0x22618D1 VA: 0x22617D0
	|-Array.UnsafeLoad<ShopCatalogPage>
	|
	|-RVA: 0x2261810 Offset: 0x2261911 VA: 0x2261810
	|-Array.UnsafeLoad<ShopNpcTalk>
	|
	|-RVA: 0x2261860 Offset: 0x2261961 VA: 0x2261860
	|-Array.UnsafeLoad<SubtitleDataTable.Data>
	|
	|-RVA: 0x22618B0 Offset: 0x22619B1 VA: 0x22618B0
	|-Array.UnsafeLoad<SubtitleDataTable.DataList>
	|
	|-RVA: 0x22618F0 Offset: 0x22619F1 VA: 0x22618F0
	|-Array.UnsafeLoad<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x2261940 Offset: 0x2261A41 VA: 0x2261940
	|-Array.UnsafeLoad<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x2261990 Offset: 0x2261A91 VA: 0x2261990
	|-Array.UnsafeLoad<Schedule>
	|
	|-RVA: 0x22619E0 Offset: 0x2261AE1 VA: 0x22619E0
	|-Array.UnsafeLoad<CurveSample>
	|
	|-RVA: 0x2261A40 Offset: 0x2261B41 VA: 0x2261A40
	|-Array.UnsafeLoad<bool>
	|
	|-RVA: 0x2261A80 Offset: 0x2261B81 VA: 0x2261A80
	|-Array.UnsafeLoad<byte>
	|
	|-RVA: 0x2261AC0 Offset: 0x2261BC1 VA: 0x2261AC0
	|-Array.UnsafeLoad<char>
	|
	|-RVA: 0x2261B00 Offset: 0x2261C01 VA: 0x2261B00
	|-Array.UnsafeLoad<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2261B40 Offset: 0x2261C41 VA: 0x2261B40
	|-Array.UnsafeLoad<KeyValuePair<int, object>>
	|
	|-RVA: 0x2261B80 Offset: 0x2261C81 VA: 0x2261B80
	|-Array.UnsafeLoad<KeyValuePair<object, object>>
	|
	|-RVA: 0x2261BC0 Offset: 0x2261CC1 VA: 0x2261BC0
	|-Array.UnsafeLoad<DateTime>
	|
	|-RVA: 0x2261C00 Offset: 0x2261D01 VA: 0x2261C00
	|-Array.UnsafeLoad<double>
	|
	|-RVA: 0x2261C40 Offset: 0x2261D41 VA: 0x2261C40
	|-Array.UnsafeLoad<short>
	|
	|-RVA: 0x2261C80 Offset: 0x2261D81 VA: 0x2261C80
	|-Array.UnsafeLoad<int>
	|
	|-RVA: 0x2261CC0 Offset: 0x2261DC1 VA: 0x2261CC0
	|-Array.UnsafeLoad<Int32Enum>
	|
	|-RVA: 0x2261D00 Offset: 0x2261E01 VA: 0x2261D00
	|-Array.UnsafeLoad<long>
	|
	|-RVA: 0x2261D40 Offset: 0x2261E41 VA: 0x2261D40
	|-Array.UnsafeLoad<InterpretedFrameInfo>
	|
	|-RVA: 0x2261D80 Offset: 0x2261E81 VA: 0x2261D80
	|-Array.UnsafeLoad<Nullable<Int32Enum>>
	|
	|-RVA: 0x2261DC0 Offset: 0x2261EC1 VA: 0x2261DC0
	|-Array.UnsafeLoad<Nullable<Bounds>>
	|
	|-RVA: 0x2261E10 Offset: 0x2261F11 VA: 0x2261E10
	|-Array.UnsafeLoad<Nullable<BoundsInt>>
	|
	|-RVA: 0x2261E60 Offset: 0x2261F61 VA: 0x2261E60
	|-Array.UnsafeLoad<Nullable<Color32>>
	|
	|-RVA: 0x2261EA0 Offset: 0x2261FA1 VA: 0x2261EA0
	|-Array.UnsafeLoad<Nullable<Color>>
	|
	|-RVA: 0x2261EF0 Offset: 0x2261FF1 VA: 0x2261EF0
	|-Array.UnsafeLoad<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2261F40 Offset: 0x2262041 VA: 0x2261F40
	|-Array.UnsafeLoad<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2261F90 Offset: 0x2262091 VA: 0x2261F90
	|-Array.UnsafeLoad<Nullable<Keyframe>>
	|
	|-RVA: 0x2261FE0 Offset: 0x22620E1 VA: 0x2261FE0
	|-Array.UnsafeLoad<Nullable<LayerMask>>
	|
	|-RVA: 0x2262020 Offset: 0x2262121 VA: 0x2262020
	|-Array.UnsafeLoad<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2262090 Offset: 0x2262191 VA: 0x2262090
	|-Array.UnsafeLoad<Nullable<Quaternion>>
	|
	|-RVA: 0x22620E0 Offset: 0x22621E1 VA: 0x22620E0
	|-Array.UnsafeLoad<Nullable<RangeInt>>
	|
	|-RVA: 0x2262130 Offset: 0x2262231 VA: 0x2262130
	|-Array.UnsafeLoad<Nullable<Rect>>
	|
	|-RVA: 0x2262180 Offset: 0x2262281 VA: 0x2262180
	|-Array.UnsafeLoad<Nullable<RectInt>>
	|
	|-RVA: 0x22621D0 Offset: 0x22622D1 VA: 0x22621D0
	|-Array.UnsafeLoad<Nullable<Vector2>>
	|
	|-RVA: 0x2262220 Offset: 0x2262321 VA: 0x2262220
	|-Array.UnsafeLoad<Nullable<Vector2Int>>
	|
	|-RVA: 0x2262270 Offset: 0x2262371 VA: 0x2262270
	|-Array.UnsafeLoad<Nullable<Vector3>>
	|
	|-RVA: 0x22622B0 Offset: 0x22623B1 VA: 0x22622B0
	|-Array.UnsafeLoad<Nullable<Vector3Int>>
	|
	|-RVA: 0x22622F0 Offset: 0x22623F1 VA: 0x22622F0
	|-Array.UnsafeLoad<Nullable<Vector4>>
	|
	|-RVA: 0x2262340 Offset: 0x2262441 VA: 0x2262340
	|-Array.UnsafeLoad<object>
	|
	|-RVA: 0x2262380 Offset: 0x2262481 VA: 0x2262380
	|-Array.UnsafeLoad<sbyte>
	|
	|-RVA: 0x22623C0 Offset: 0x22624C1 VA: 0x22623C0
	|-Array.UnsafeLoad<float>
	|
	|-RVA: 0x2262400 Offset: 0x2262501 VA: 0x2262400
	|-Array.UnsafeLoad<ushort>
	|
	|-RVA: 0x2262440 Offset: 0x2262541 VA: 0x2262440
	|-Array.UnsafeLoad<uint>
	|
	|-RVA: 0x2262480 Offset: 0x2262581 VA: 0x2262480
	|-Array.UnsafeLoad<ulong>
	|
	|-RVA: 0x22624C0 Offset: 0x22625C1 VA: 0x22624C0
	|-Array.UnsafeLoad<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x2262500 Offset: 0x2262601 VA: 0x2262500
	|-Array.UnsafeLoad<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2262540 Offset: 0x2262641 VA: 0x2262540
	|-Array.UnsafeLoad<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x2262580 Offset: 0x2262681 VA: 0x2262580
	|-Array.UnsafeLoad<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x22625C0 Offset: 0x22626C1 VA: 0x22625C0
	|-Array.UnsafeLoad<ValueTuple<object, object>>
	|
	|-RVA: 0x2262600 Offset: 0x2262701 VA: 0x2262600
	|-Array.UnsafeLoad<ValueTuple<object, float>>
	|
	|-RVA: 0x2262640 Offset: 0x2262741 VA: 0x2262640
	|-Array.UnsafeLoad<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2262690 Offset: 0x2262791 VA: 0x2262690
	|-Array.UnsafeLoad<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x22626F0 Offset: 0x22627F1 VA: 0x22626F0
	|-Array.UnsafeLoad<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x2262750 Offset: 0x2262851 VA: 0x2262750
	|-Array.UnsafeLoad<TutorialUnlockFlagData>
	|
	|-RVA: 0x22627A0 Offset: 0x22628A1 VA: 0x22627A0
	|-Array.UnsafeLoad<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x22627E0 Offset: 0x22628E1 VA: 0x22627E0
	|-Array.UnsafeLoad<CapEdge>
	|
	|-RVA: 0x2262840 Offset: 0x2262941 VA: 0x2262840
	|-Array.UnsafeLoad<MeshDataConnectivity.Face>
	|
	|-RVA: 0x2262880 Offset: 0x2262981 VA: 0x2262880
	|-Array.UnsafeLoad<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x22628D0 Offset: 0x22629D1 VA: 0x22628D0
	|-Array.UnsafeLoad<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x2262920 Offset: 0x2262A21 VA: 0x2262920
	|-Array.UnsafeLoad<NavMeshBuildMarkup>
	|
	|-RVA: 0x2262960 Offset: 0x2262A61 VA: 0x2262960
	|-Array.UnsafeLoad<NavMeshBuildSource>
	|
	|-RVA: 0x22629D0 Offset: 0x2262AD1 VA: 0x22629D0
	|-Array.UnsafeLoad<ConstraintSource>
	|
	|-RVA: 0x2262A10 Offset: 0x2262B11 VA: 0x2262A10
	|-Array.UnsafeLoad<AnimatorClipInfo>
	|
	|-RVA: 0x2262A50 Offset: 0x2262B51 VA: 0x2262A50
	|-Array.UnsafeLoad<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x2262A90 Offset: 0x2262B91 VA: 0x2262A90
	|-Array.UnsafeLoad<BoneWeight>
	|
	|-RVA: 0x2262AE0 Offset: 0x2262BE1 VA: 0x2262AE0
	|-Array.UnsafeLoad<Bounds>
	|
	|-RVA: 0x2262B30 Offset: 0x2262C31 VA: 0x2262B30
	|-Array.UnsafeLoad<BoundsInt>
	|
	|-RVA: 0x2262B80 Offset: 0x2262C81 VA: 0x2262B80
	|-Array.UnsafeLoad<Color32>
	|
	|-RVA: 0x2262BC0 Offset: 0x2262CC1 VA: 0x2262BC0
	|-Array.UnsafeLoad<Color>
	|
	|-RVA: 0x2262C00 Offset: 0x2262D01 VA: 0x2262C00
	|-Array.UnsafeLoad<CombineInstance>
	|
	|-RVA: 0x2262C70 Offset: 0x2262D71 VA: 0x2262C70
	|-Array.UnsafeLoad<RaycastResult>
	|
	|-RVA: 0x2262CD0 Offset: 0x2262DD1 VA: 0x2262CD0
	|-Array.UnsafeLoad<GradientAlphaKey>
	|
	|-RVA: 0x2262D10 Offset: 0x2262E11 VA: 0x2262D10
	|-Array.UnsafeLoad<GradientColorKey>
	|
	|-RVA: 0x2262D60 Offset: 0x2262E61 VA: 0x2262D60
	|-Array.UnsafeLoad<Keyframe>
	|
	|-RVA: 0x2262DB0 Offset: 0x2262EB1 VA: 0x2262DB0
	|-Array.UnsafeLoad<LayerMask>
	|
	|-RVA: 0x2262DF0 Offset: 0x2262EF1 VA: 0x2262DF0
	|-Array.UnsafeLoad<Matrix4x4>
	|
	|-RVA: 0x2262E50 Offset: 0x2262F51 VA: 0x2262E50
	|-Array.UnsafeLoad<ParticleSystem.Particle>
	|
	|-RVA: 0x2262EA0 Offset: 0x2262FA1 VA: 0x2262EA0
	|-Array.UnsafeLoad<Playable>
	|
	|-RVA: 0x2262EE0 Offset: 0x2262FE1 VA: 0x2262EE0
	|-Array.UnsafeLoad<PlayableBinding>
	|
	|-RVA: 0x2262F30 Offset: 0x2263031 VA: 0x2262F30
	|-Array.UnsafeLoad<PlayableGraph>
	|
	|-RVA: 0x2262F70 Offset: 0x2263071 VA: 0x2262F70
	|-Array.UnsafeLoad<Edge>
	|
	|-RVA: 0x2262FB0 Offset: 0x22630B1 VA: 0x2262FB0
	|-Array.UnsafeLoad<Quaternion>
	|
	|-RVA: 0x2262FF0 Offset: 0x22630F1 VA: 0x2262FF0
	|-Array.UnsafeLoad<RangeInt>
	|
	|-RVA: 0x2263030 Offset: 0x2263131 VA: 0x2263030
	|-Array.UnsafeLoad<RaycastHit2D>
	|
	|-RVA: 0x2263090 Offset: 0x2263191 VA: 0x2263090
	|-Array.UnsafeLoad<RaycastHit>
	|
	|-RVA: 0x22630F0 Offset: 0x22631F1 VA: 0x22630F0
	|-Array.UnsafeLoad<Rect>
	|
	|-RVA: 0x2263130 Offset: 0x2263231 VA: 0x2263130
	|-Array.UnsafeLoad<RectInt>
	|
	|-RVA: 0x2263170 Offset: 0x2263271 VA: 0x2263170
	|-Array.UnsafeLoad<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x22631B0 Offset: 0x22632B1 VA: 0x22631B0
	|-Array.UnsafeLoad<SphericalHarmonicsL2>
	|
	|-RVA: 0x2263230 Offset: 0x2263331 VA: 0x2263230
	|-Array.UnsafeLoad<VertexAttributeDescriptor>
	|
	|-RVA: 0x2263270 Offset: 0x2263371 VA: 0x2263270
	|-Array.UnsafeLoad<AsyncOperationHandle>
	|
	|-RVA: 0x22632C0 Offset: 0x22633C1 VA: 0x22632C0
	|-Array.UnsafeLoad<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x2263310 Offset: 0x2263411 VA: 0x2263310
	|-Array.UnsafeLoad<DiagnosticEvent>
	|
	|-RVA: 0x2263360 Offset: 0x2263461 VA: 0x2263360
	|-Array.UnsafeLoad<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x22633B0 Offset: 0x22634B1 VA: 0x22633B0
	|-Array.UnsafeLoad<ObjectInitializationData>
	|
	|-RVA: 0x2263400 Offset: 0x2263501 VA: 0x2263400
	|-Array.UnsafeLoad<GlyphRect>
	|
	|-RVA: 0x2263440 Offset: 0x2263541 VA: 0x2263440
	|-Array.UnsafeLoad<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2263490 Offset: 0x2263591 VA: 0x2263490
	|-Array.UnsafeLoad<IntervalTreeNode>
	|
	|-RVA: 0x22634E0 Offset: 0x22635E1 VA: 0x22634E0
	|-Array.UnsafeLoad<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2263530 Offset: 0x2263631 VA: 0x2263530
	|-Array.UnsafeLoad<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x2263580 Offset: 0x2263681 VA: 0x2263580
	|-Array.UnsafeLoad<UICharInfo>
	|
	|-RVA: 0x22635D0 Offset: 0x22636D1 VA: 0x22635D0
	|-Array.UnsafeLoad<FocusController.FocusedElement>
	|
	|-RVA: 0x2263610 Offset: 0x2263711 VA: 0x2263610
	|-Array.UnsafeLoad<UILineInfo>
	|
	|-RVA: 0x2263650 Offset: 0x2263751 VA: 0x2263650
	|-Array.UnsafeLoad<UIVertex>
	|
	|-RVA: 0x22636C0 Offset: 0x22637C1 VA: 0x22636C0
	|-Array.UnsafeLoad<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x2263710 Offset: 0x2263811 VA: 0x2263710
	|-Array.UnsafeLoad<Vector2>
	|
	|-RVA: 0x2263750 Offset: 0x2263851 VA: 0x2263750
	|-Array.UnsafeLoad<Vector2Int>
	|
	|-RVA: 0x2263790 Offset: 0x2263891 VA: 0x2263790
	|-Array.UnsafeLoad<Vector3>
	|
	|-RVA: 0x22637E0 Offset: 0x22638E1 VA: 0x22637E0
	|-Array.UnsafeLoad<Vector3Int>
	|
	|-RVA: 0x2263830 Offset: 0x2263931 VA: 0x2263830
	|-Array.UnsafeLoad<Vector4>
	|
	|-RVA: 0x2263870 Offset: 0x2263971 VA: 0x2263870
	|-Array.UnsafeLoad<WarpPoints.WarpPoint>
	|
	|-RVA: 0x22638F0 Offset: 0x22639F1 VA: 0x22638F0
	|-Array.UnsafeLoad<YieldItemParam>
	|
	|-RVA: 0x2263930 Offset: 0x2263A31 VA: 0x2263930
	|-Array.UnsafeLoad<stCommand_t>
	*/

	// RVA: -1 Offset: -1
	internal static void UnsafeStore<T>(T[] array, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B2370 Offset: 0x24B2471 VA: 0x24B2370
	|-Array.UnsafeStore<object>
	*/

	// RVA: -1 Offset: -1
	internal static R UnsafeMov<S, R>(S instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x280FBF0 Offset: 0x280FCF1 VA: 0x280FBF0
	|-Array.UnsafeMov<Int32Enum, int>
	|
	|-RVA: 0x280FC00 Offset: 0x280FD01 VA: 0x280FC00
	|-Array.UnsafeMov<object, object>
	*/
}

