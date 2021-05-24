[Serializable]
public struct Dictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 1424
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0
	private int version; // 0x0
	private int index; // 0x0
	private KeyValuePair<TKey, TValue> current; // 0x0
	private int getEnumeratorRetType; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302980 Offset: 0x302A81 VA: 0x302980
	|-Dictionary.Enumerator<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x302B10 Offset: 0x302C11 VA: 0x302B10
	|-Dictionary.Enumerator<BitVector32Int, object>..ctor
	|
	|-RVA: 0x302C80 Offset: 0x302D81 VA: 0x302C80
	|-Dictionary.Enumerator<EventCheckId, object>..ctor
	|
	|-RVA: 0x302E10 Offset: 0x302F11 VA: 0x302E10
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x302FD0 Offset: 0x3030D1 VA: 0x302FD0
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x303160 Offset: 0x303261 VA: 0x303160
	|-Dictionary.Enumerator<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x3032F0 Offset: 0x3033F1 VA: 0x3032F0
	|-Dictionary.Enumerator<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x303480 Offset: 0x303581 VA: 0x303480
	|-Dictionary.Enumerator<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x303620 Offset: 0x303721 VA: 0x303620
	|-Dictionary.Enumerator<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x3037B0 Offset: 0x3038B1 VA: 0x3037B0
	|-Dictionary.Enumerator<OrderSaveData, object>..ctor
	|
	|-RVA: 0x303950 Offset: 0x303A51 VA: 0x303950
	|-Dictionary.Enumerator<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x303AF0 Offset: 0x303BF1 VA: 0x303AF0
	|-Dictionary.Enumerator<Parameter, object>..ctor
	|
	|-RVA: 0x303CF0 Offset: 0x303DF1 VA: 0x303CF0
	|-Dictionary.Enumerator<bool, object>..ctor
	|
	|-RVA: 0x303E60 Offset: 0x303F61 VA: 0x303E60
	|-Dictionary.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x303FD0 Offset: 0x3040D1 VA: 0x303FD0
	|-Dictionary.Enumerator<char, object>..ctor
	|
	|-RVA: 0x304140 Offset: 0x304241 VA: 0x304140
	|-Dictionary.Enumerator<DateTime, object>..ctor
	|
	|-RVA: 0x3042B0 Offset: 0x3043B1 VA: 0x3042B0
	|-Dictionary.Enumerator<double, object>..ctor
	|
	|-RVA: 0x304420 Offset: 0x304521 VA: 0x304420
	|-Dictionary.Enumerator<Guid, object>..ctor
	|
	|-RVA: 0x3045B0 Offset: 0x3046B1 VA: 0x3045B0
	|-Dictionary.Enumerator<short, object>..ctor
	|
	|-RVA: 0x304720 Offset: 0x304821 VA: 0x304720
	|-Dictionary.Enumerator<int, CropDataTable>..ctor
	|
	|-RVA: 0x304950 Offset: 0x304A51 VA: 0x304950
	|-Dictionary.Enumerator<int, EffectDataTable>..ctor
	|
	|-RVA: 0x304AE0 Offset: 0x304BE1 VA: 0x304AE0
	|-Dictionary.Enumerator<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x3314D0 Offset: 0x3315D1 VA: 0x3314D0
	|-Dictionary.Enumerator<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x331690 Offset: 0x331791 VA: 0x331690
	|-Dictionary.Enumerator<int, MiningDataTable>..ctor
	|
	|-RVA: 0x331820 Offset: 0x331921 VA: 0x331820
	|-Dictionary.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x331980 Offset: 0x331A81 VA: 0x331980
	|-Dictionary.Enumerator<int, char>..ctor
	|
	|-RVA: 0x331AE0 Offset: 0x331BE1 VA: 0x331AE0
	|-Dictionary.Enumerator<int, int>..ctor
	|
	|-RVA: 0x331C40 Offset: 0x331D41 VA: 0x331C40
	|-Dictionary.Enumerator<int, Int32Enum>..ctor
	|
	|-RVA: 0x331DA0 Offset: 0x331EA1 VA: 0x331DA0
	|-Dictionary.Enumerator<int, long>..ctor
	|
	|-RVA: 0x331F10 Offset: 0x332011 VA: 0x331F10
	|-Dictionary.Enumerator<int, object>..ctor
	|
	|-RVA: 0x332080 Offset: 0x332181 VA: 0x332080
	|-Dictionary.Enumerator<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x332240 Offset: 0x332341 VA: 0x332240
	|-Dictionary.Enumerator<int, SceneInstance>..ctor
	|
	|-RVA: 0x3323D0 Offset: 0x3324D1 VA: 0x3323D0
	|-Dictionary.Enumerator<int, Vector2Int>..ctor
	|
	|-RVA: 0x332540 Offset: 0x332641 VA: 0x332540
	|-Dictionary.Enumerator<int, Vector3>..ctor
	|
	|-RVA: 0x3326B0 Offset: 0x3327B1 VA: 0x3326B0
	|-Dictionary.Enumerator<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x3328B0 Offset: 0x3329B1 VA: 0x3328B0
	|-Dictionary.Enumerator<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x332A70 Offset: 0x332B71 VA: 0x332A70
	|-Dictionary.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x332BF0 Offset: 0x332CF1 VA: 0x332BF0
	|-Dictionary.Enumerator<Int32Enum, bool>..ctor
	|
	|-RVA: 0x332D50 Offset: 0x332E51 VA: 0x332D50
	|-Dictionary.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x332EC0 Offset: 0x332FC1 VA: 0x332EC0
	|-Dictionary.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x333020 Offset: 0x333121 VA: 0x333020
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x333180 Offset: 0x333281 VA: 0x333180
	|-Dictionary.Enumerator<Int32Enum, object>..ctor
	|
	|-RVA: 0x3332F0 Offset: 0x3333F1 VA: 0x3332F0
	|-Dictionary.Enumerator<Int32Enum, float>..ctor
	|
	|-RVA: 0x333450 Offset: 0x333551 VA: 0x333450
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x3335E0 Offset: 0x3336E1 VA: 0x3335E0
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x333750 Offset: 0x333851 VA: 0x333750
	|-Dictionary.Enumerator<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x3338C0 Offset: 0x3339C1 VA: 0x3338C0
	|-Dictionary.Enumerator<long, object>..ctor
	|
	|-RVA: 0x333A30 Offset: 0x333B31 VA: 0x333A30
	|-Dictionary.Enumerator<Memory<object>, object>..ctor
	|
	|-RVA: 0x333BC0 Offset: 0x333CC1 VA: 0x333BC0
	|-Dictionary.Enumerator<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x333D30 Offset: 0x333E31 VA: 0x333D30
	|-Dictionary.Enumerator<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x333ED0 Offset: 0x333FD1 VA: 0x333ED0
	|-Dictionary.Enumerator<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x334070 Offset: 0x334171 VA: 0x334070
	|-Dictionary.Enumerator<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x3341E0 Offset: 0x3342E1 VA: 0x3341E0
	|-Dictionary.Enumerator<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x334370 Offset: 0x334471 VA: 0x334370
	|-Dictionary.Enumerator<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x334500 Offset: 0x334601 VA: 0x334500
	|-Dictionary.Enumerator<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x334690 Offset: 0x334791 VA: 0x334690
	|-Dictionary.Enumerator<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x334830 Offset: 0x334931 VA: 0x334830
	|-Dictionary.Enumerator<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x3349A0 Offset: 0x334AA1 VA: 0x3349A0
	|-Dictionary.Enumerator<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x334B60 Offset: 0x334C61 VA: 0x334B60
	|-Dictionary.Enumerator<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x334CF0 Offset: 0x334DF1 VA: 0x334CF0
	|-Dictionary.Enumerator<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x334E80 Offset: 0x334F81 VA: 0x334E80
	|-Dictionary.Enumerator<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x32D850 Offset: 0x32D951 VA: 0x32D850
	|-Dictionary.Enumerator<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x32D9E0 Offset: 0x32DAE1 VA: 0x32D9E0
	|-Dictionary.Enumerator<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x32DB70 Offset: 0x32DC71 VA: 0x32DB70
	|-Dictionary.Enumerator<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x32DD00 Offset: 0x32DE01 VA: 0x32DD00
	|-Dictionary.Enumerator<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x32DE90 Offset: 0x32DF91 VA: 0x32DE90
	|-Dictionary.Enumerator<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x32E020 Offset: 0x32E121 VA: 0x32E020
	|-Dictionary.Enumerator<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x32E1B0 Offset: 0x32E2B1 VA: 0x32E1B0
	|-Dictionary.Enumerator<object, BitVector32Int>..ctor
	|
	|-RVA: 0x32E320 Offset: 0x32E421 VA: 0x32E320
	|-Dictionary.Enumerator<object, EventCheckId>..ctor
	|
	|-RVA: 0x32E4B0 Offset: 0x32E5B1 VA: 0x32E4B0
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x32E670 Offset: 0x32E771 VA: 0x32E670
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x32E800 Offset: 0x32E901 VA: 0x32E800
	|-Dictionary.Enumerator<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x32E990 Offset: 0x32EA91 VA: 0x32E990
	|-Dictionary.Enumerator<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x32EB20 Offset: 0x32EC21 VA: 0x32EB20
	|-Dictionary.Enumerator<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x32ECC0 Offset: 0x32EDC1 VA: 0x32ECC0
	|-Dictionary.Enumerator<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x32EE50 Offset: 0x32EF51 VA: 0x32EE50
	|-Dictionary.Enumerator<object, OrderSaveData>..ctor
	|
	|-RVA: 0x32EFF0 Offset: 0x32F0F1 VA: 0x32EFF0
	|-Dictionary.Enumerator<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x32F190 Offset: 0x32F291 VA: 0x32F190
	|-Dictionary.Enumerator<object, Parameter>..ctor
	|
	|-RVA: 0x32F390 Offset: 0x32F491 VA: 0x32F390
	|-Dictionary.Enumerator<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x32F520 Offset: 0x32F621 VA: 0x32F520
	|-Dictionary.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x32F690 Offset: 0x32F791 VA: 0x32F690
	|-Dictionary.Enumerator<object, byte>..ctor
	|
	|-RVA: 0x32F800 Offset: 0x32F901 VA: 0x32F800
	|-Dictionary.Enumerator<object, char>..ctor
	|
	|-RVA: 0x32F970 Offset: 0x32FA71 VA: 0x32F970
	|-Dictionary.Enumerator<object, DateTime>..ctor
	|
	|-RVA: 0x32FAE0 Offset: 0x32FBE1 VA: 0x32FAE0
	|-Dictionary.Enumerator<object, double>..ctor
	|
	|-RVA: 0x32FC50 Offset: 0x32FD51 VA: 0x32FC50
	|-Dictionary.Enumerator<object, short>..ctor
	|
	|-RVA: 0x32FDC0 Offset: 0x32FEC1 VA: 0x32FDC0
	|-Dictionary.Enumerator<object, int>..ctor
	|
	|-RVA: 0x32FF30 Offset: 0x330031 VA: 0x32FF30
	|-Dictionary.Enumerator<object, Int32Enum>..ctor
	|
	|-RVA: 0x3300A0 Offset: 0x3301A1 VA: 0x3300A0
	|-Dictionary.Enumerator<object, long>..ctor
	|
	|-RVA: 0x330210 Offset: 0x330311 VA: 0x330210
	|-Dictionary.Enumerator<object, Memory<object>>..ctor
	|
	|-RVA: 0x3303A0 Offset: 0x3304A1 VA: 0x3303A0
	|-Dictionary.Enumerator<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x330510 Offset: 0x330611 VA: 0x330510
	|-Dictionary.Enumerator<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x3306B0 Offset: 0x3307B1 VA: 0x3306B0
	|-Dictionary.Enumerator<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x330850 Offset: 0x330951 VA: 0x330850
	|-Dictionary.Enumerator<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x3309C0 Offset: 0x330AC1 VA: 0x3309C0
	|-Dictionary.Enumerator<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x330B50 Offset: 0x330C51 VA: 0x330B50
	|-Dictionary.Enumerator<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x330CE0 Offset: 0x330DE1 VA: 0x330CE0
	|-Dictionary.Enumerator<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x330E70 Offset: 0x330F71 VA: 0x330E70
	|-Dictionary.Enumerator<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x331010 Offset: 0x331111 VA: 0x331010
	|-Dictionary.Enumerator<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x331180 Offset: 0x331281 VA: 0x331180
	|-Dictionary.Enumerator<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x331340 Offset: 0x331441 VA: 0x331340
	|-Dictionary.Enumerator<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x33EE10 Offset: 0x33EF11 VA: 0x33EE10
	|-Dictionary.Enumerator<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x33EFA0 Offset: 0x33F0A1 VA: 0x33EFA0
	|-Dictionary.Enumerator<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x33F130 Offset: 0x33F231 VA: 0x33F130
	|-Dictionary.Enumerator<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x33F2C0 Offset: 0x33F3C1 VA: 0x33F2C0
	|-Dictionary.Enumerator<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x33F450 Offset: 0x33F551 VA: 0x33F450
	|-Dictionary.Enumerator<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x33F5E0 Offset: 0x33F6E1 VA: 0x33F5E0
	|-Dictionary.Enumerator<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x33F770 Offset: 0x33F871 VA: 0x33F770
	|-Dictionary.Enumerator<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x33F900 Offset: 0x33FA01 VA: 0x33F900
	|-Dictionary.Enumerator<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x33FA90 Offset: 0x33FB91 VA: 0x33FA90
	|-Dictionary.Enumerator<object, object>..ctor
	|
	|-RVA: 0x33FC00 Offset: 0x33FD01 VA: 0x33FC00
	|-Dictionary.Enumerator<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x33FD90 Offset: 0x33FE91 VA: 0x33FD90
	|-Dictionary.Enumerator<object, ResourceLocator>..ctor
	|
	|-RVA: 0x33FF20 Offset: 0x340021 VA: 0x33FF20
	|-Dictionary.Enumerator<object, sbyte>..ctor
	|
	|-RVA: 0x340090 Offset: 0x340191 VA: 0x340090
	|-Dictionary.Enumerator<object, float>..ctor
	|
	|-RVA: 0x340200 Offset: 0x340301 VA: 0x340200
	|-Dictionary.Enumerator<object, ushort>..ctor
	|
	|-RVA: 0x340370 Offset: 0x340471 VA: 0x340370
	|-Dictionary.Enumerator<object, uint>..ctor
	|
	|-RVA: 0x3404E0 Offset: 0x3405E1 VA: 0x3404E0
	|-Dictionary.Enumerator<object, ulong>..ctor
	|
	|-RVA: 0x340650 Offset: 0x340751 VA: 0x340650
	|-Dictionary.Enumerator<object, TransitionTables>..ctor
	|
	|-RVA: 0x3407F0 Offset: 0x3408F1 VA: 0x3407F0
	|-Dictionary.Enumerator<object, Bounds>..ctor
	|
	|-RVA: 0x340980 Offset: 0x340A81 VA: 0x340980
	|-Dictionary.Enumerator<object, BoundsInt>..ctor
	|
	|-RVA: 0x340B10 Offset: 0x340C11 VA: 0x340B10
	|-Dictionary.Enumerator<object, Color32>..ctor
	|
	|-RVA: 0x340C80 Offset: 0x340D81 VA: 0x340C80
	|-Dictionary.Enumerator<object, Color>..ctor
	|
	|-RVA: 0x340E10 Offset: 0x340F11 VA: 0x340E10
	|-Dictionary.Enumerator<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x340F80 Offset: 0x341081 VA: 0x340F80
	|-Dictionary.Enumerator<object, GradientColorKey>..ctor
	|
	|-RVA: 0x341110 Offset: 0x341211 VA: 0x341110
	|-Dictionary.Enumerator<object, Keyframe>..ctor
	|
	|-RVA: 0x3412B0 Offset: 0x3413B1 VA: 0x3412B0
	|-Dictionary.Enumerator<object, LayerMask>..ctor
	|
	|-RVA: 0x341420 Offset: 0x341521 VA: 0x341420
	|-Dictionary.Enumerator<object, Matrix4x4>..ctor
	|
	|-RVA: 0x3415E0 Offset: 0x3416E1 VA: 0x3415E0
	|-Dictionary.Enumerator<object, Playable>..ctor
	|
	|-RVA: 0x341770 Offset: 0x341871 VA: 0x341770
	|-Dictionary.Enumerator<object, Quaternion>..ctor
	|
	|-RVA: 0x341900 Offset: 0x341A01 VA: 0x341900
	|-Dictionary.Enumerator<object, RangeInt>..ctor
	|
	|-RVA: 0x341A70 Offset: 0x341B71 VA: 0x341A70
	|-Dictionary.Enumerator<object, Rect>..ctor
	|
	|-RVA: 0x341C00 Offset: 0x341D01 VA: 0x341C00
	|-Dictionary.Enumerator<object, RectInt>..ctor
	|
	|-RVA: 0x341D90 Offset: 0x341E91 VA: 0x341D90
	|-Dictionary.Enumerator<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x341F20 Offset: 0x342021 VA: 0x341F20
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3420B0 Offset: 0x3421B1 VA: 0x3420B0
	|-Dictionary.Enumerator<object, Vector2>..ctor
	|
	|-RVA: 0x342220 Offset: 0x342321 VA: 0x342220
	|-Dictionary.Enumerator<object, Vector2Int>..ctor
	|
	|-RVA: 0x342390 Offset: 0x342491 VA: 0x342390
	|-Dictionary.Enumerator<object, Vector3>..ctor
	|
	|-RVA: 0x342520 Offset: 0x342621 VA: 0x342520
	|-Dictionary.Enumerator<object, Vector3Int>..ctor
	|
	|-RVA: 0x3426B0 Offset: 0x3427B1 VA: 0x3426B0
	|-Dictionary.Enumerator<object, Vector4>..ctor
	|
	|-RVA: 0x342840 Offset: 0x342941 VA: 0x342840
	|-Dictionary.Enumerator<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x335010 Offset: 0x335111 VA: 0x335010
	|-Dictionary.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x335180 Offset: 0x335281 VA: 0x335180
	|-Dictionary.Enumerator<sbyte, object>..ctor
	|
	|-RVA: 0x3352F0 Offset: 0x3353F1 VA: 0x3352F0
	|-Dictionary.Enumerator<float, CurveSample>..ctor
	|
	|-RVA: 0x3354C0 Offset: 0x3355C1 VA: 0x3354C0
	|-Dictionary.Enumerator<float, object>..ctor
	|
	|-RVA: 0x335630 Offset: 0x335731 VA: 0x335630
	|-Dictionary.Enumerator<ushort, object>..ctor
	|
	|-RVA: 0x3357A0 Offset: 0x3358A1 VA: 0x3357A0
	|-Dictionary.Enumerator<uint, int>..ctor
	|
	|-RVA: 0x335900 Offset: 0x335A01 VA: 0x335900
	|-Dictionary.Enumerator<uint, Int32Enum>..ctor
	|
	|-RVA: 0x335A60 Offset: 0x335B61 VA: 0x335A60
	|-Dictionary.Enumerator<uint, object>..ctor
	|
	|-RVA: 0x335BD0 Offset: 0x335CD1 VA: 0x335BD0
	|-Dictionary.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x335D40 Offset: 0x335E41 VA: 0x335D40
	|-Dictionary.Enumerator<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x335EB0 Offset: 0x335FB1 VA: 0x335EB0
	|-Dictionary.Enumerator<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x336060 Offset: 0x336161 VA: 0x336060
	|-Dictionary.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x336220 Offset: 0x336321 VA: 0x336220
	|-Dictionary.Enumerator<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x3363B0 Offset: 0x3364B1 VA: 0x3363B0
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x336520 Offset: 0x336621 VA: 0x336520
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x336690 Offset: 0x336791 VA: 0x336690
	|-Dictionary.Enumerator<Bounds, object>..ctor
	|
	|-RVA: 0x336820 Offset: 0x336921 VA: 0x336820
	|-Dictionary.Enumerator<BoundsInt, object>..ctor
	|
	|-RVA: 0x3369B0 Offset: 0x336AB1 VA: 0x3369B0
	|-Dictionary.Enumerator<Color, object>..ctor
	|
	|-RVA: 0x336B40 Offset: 0x336C41 VA: 0x336B40
	|-Dictionary.Enumerator<Color32, object>..ctor
	|
	|-RVA: 0x336CB0 Offset: 0x336DB1 VA: 0x336CB0
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x336E20 Offset: 0x336F21 VA: 0x336E20
	|-Dictionary.Enumerator<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x336F90 Offset: 0x337091 VA: 0x336F90
	|-Dictionary.Enumerator<GradientColorKey, object>..ctor
	|
	|-RVA: 0x337120 Offset: 0x337221 VA: 0x337120
	|-Dictionary.Enumerator<Keyframe, object>..ctor
	|
	|-RVA: 0x3372C0 Offset: 0x3373C1 VA: 0x3372C0
	|-Dictionary.Enumerator<LayerMask, object>..ctor
	|
	|-RVA: 0x337430 Offset: 0x337531 VA: 0x337430
	|-Dictionary.Enumerator<Matrix4x4, object>..ctor
	|
	|-RVA: 0x3375F0 Offset: 0x3376F1 VA: 0x3375F0
	|-Dictionary.Enumerator<IntVec3, object>..ctor
	|
	|-RVA: 0x337780 Offset: 0x337881 VA: 0x337780
	|-Dictionary.Enumerator<Quaternion, object>..ctor
	|
	|-RVA: 0x337910 Offset: 0x337A11 VA: 0x337910
	|-Dictionary.Enumerator<RangeInt, object>..ctor
	|
	|-RVA: 0x337A80 Offset: 0x337B81 VA: 0x337A80
	|-Dictionary.Enumerator<Rect, object>..ctor
	|
	|-RVA: 0x337C10 Offset: 0x337D11 VA: 0x337C10
	|-Dictionary.Enumerator<RectInt, object>..ctor
	|
	|-RVA: 0x337DA0 Offset: 0x337EA1 VA: 0x337DA0
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x337F10 Offset: 0x338011 VA: 0x337F10
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x338080 Offset: 0x338181 VA: 0x338080
	|-Dictionary.Enumerator<Vector2, object>..ctor
	|
	|-RVA: 0x3381F0 Offset: 0x3382F1 VA: 0x3381F0
	|-Dictionary.Enumerator<Vector2Int, object>..ctor
	|
	|-RVA: 0x338360 Offset: 0x338461 VA: 0x338360
	|-Dictionary.Enumerator<Vector3, object>..ctor
	|
	|-RVA: 0x3384F0 Offset: 0x3385F1 VA: 0x3384F0
	|-Dictionary.Enumerator<Vector3Int, object>..ctor
	|
	|-RVA: 0x338680 Offset: 0x338781 VA: 0x338680
	|-Dictionary.Enumerator<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3029D0 Offset: 0x302AD1 VA: 0x3029D0
	|-Dictionary.Enumerator<JSONDeserialization.TaskField, object>.MoveNext
	|
	|-RVA: 0x33FAE0 Offset: 0x33FBE1 VA: 0x33FAE0
	|-Dictionary.Enumerator<SharedVariable, object>.MoveNext
	|-Dictionary.Enumerator<CharacterBase, DamageTextController>.MoveNext
	|-Dictionary.Enumerator<ICinemachineCamera, object>.MoveNext
	|-Dictionary.Enumerator<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.MoveNext
	|-Dictionary.Enumerator<OptionDefinition, OptionsControlBase>.MoveNext
	|-Dictionary.Enumerator<byte[], Encoding>.MoveNext
	|-Dictionary.Enumerator<int[], SceneSplit>.MoveNext
	|-Dictionary.Enumerator<int[], Terrain>.MoveNext
	|-Dictionary.Enumerator<object, object>.MoveNext
	|-Dictionary.Enumerator<string, BehaviorManager.TaskAddData.OverrideFieldValue>.MoveNext
	|-Dictionary.Enumerator<string, Texture[]>.MoveNext
	|-Dictionary.Enumerator<string, InfoBlock>.MoveNext
	|-Dictionary.Enumerator<string, SeasonTextureData>.MoveNext
	|-Dictionary.Enumerator<string, IList<InfoEntry>>.MoveNext
	|-Dictionary.Enumerator<string, List<TaskCoroutine>>.MoveNext
	|-Dictionary.Enumerator<string, List<OptionDefinition>>.MoveNext
	|-Dictionary.Enumerator<string, object>.MoveNext
	|-Dictionary.Enumerator<string, string>.MoveNext
	|-Dictionary.Enumerator<string, ResourceLocationBase>.MoveNext
	|-Dictionary.Enumerator<TimeParamTable, HashSet<ObjectChangeTime>>.MoveNext
	|-Dictionary.Enumerator<TimeParamTable, HashSet<RendererChangeTime>>.MoveNext
	|-Dictionary.Enumerator<TimeParamTable, HashSet<Material>>.MoveNext
	|-Dictionary.Enumerator<Camera, Camera>.MoveNext
	|-Dictionary.Enumerator<Collider, CharacterNearCullingController>.MoveNext
	|-Dictionary.Enumerator<GameObject, Material[]>.MoveNext
	|-Dictionary.Enumerator<GameObject, Renderer[]>.MoveNext
	|-Dictionary.Enumerator<Transform, TargetPositionCache.CacheEntry>.MoveNext
	|-Dictionary.Enumerator<Transform, UpdateTracker.UpdateStatus>.MoveNext
	|-Dictionary.Enumerator<Transform, List<SpringBone>>.MoveNext
	|
	|-RVA: 0x302B60 Offset: 0x302C61 VA: 0x302B60
	|-Dictionary.Enumerator<BitVector32Int, object>.MoveNext
	|
	|-RVA: 0x3331D0 Offset: 0x3332D1 VA: 0x3331D0
	|-Dictionary.Enumerator<BadStatus, BadStatusEffectController.ObjInfo>.MoveNext
	|-Dictionary.Enumerator<VariationNo, HumanData>.MoveNext
	|-Dictionary.Enumerator<EnvironmentSoundType, List<EnvironmentSoundDataTable>>.MoveNext
	|-Dictionary.Enumerator<EquipSlotType, AS_ToolController.ToolActionData>.MoveNext
	|-Dictionary.Enumerator<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.MoveNext
	|-Dictionary.Enumerator<SoundID, EnvironmentSoundDataTable>.MoveNext
	|-Dictionary.Enumerator<SoundID, EnvironmentSoundController>.MoveNext
	|-Dictionary.Enumerator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x333070 Offset: 0x333171 VA: 0x333070
	|-Dictionary.Enumerator<EmotionType, Prefab>.MoveNext
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x302CD0 Offset: 0x302DD1 VA: 0x302CD0
	|-Dictionary.Enumerator<EventCheckId, object>.MoveNext
	|
	|-RVA: 0x302E70 Offset: 0x302F71 VA: 0x302E70
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE, object>.MoveNext
	|
	|-RVA: 0x303020 Offset: 0x303121 VA: 0x303020
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.MoveNext
	|
	|-RVA: 0x3031B0 Offset: 0x3032B1 VA: 0x3031B0
	|-Dictionary.Enumerator<FarmManager.RF4_MCROP_INFO, object>.MoveNext
	|
	|-RVA: 0x303340 Offset: 0x303441 VA: 0x303340
	|-Dictionary.Enumerator<FarmManager.RF4_SOIL_INFO, object>.MoveNext
	|
	|-RVA: 0x32FE10 Offset: 0x32FF11 VA: 0x32FE10
	|-Dictionary.Enumerator<MonsterControllerBase, int>.MoveNext
	|-Dictionary.Enumerator<object, int>.MoveNext
	|
	|-RVA: 0x3034E0 Offset: 0x3035E1 VA: 0x3034E0
	|-Dictionary.Enumerator<MonsterHutSaveData, object>.MoveNext
	|
	|-RVA: 0x303670 Offset: 0x303771 VA: 0x303670
	|-Dictionary.Enumerator<OrderLotterySaveParameter, object>.MoveNext
	|
	|-RVA: 0x303810 Offset: 0x303911 VA: 0x303810
	|-Dictionary.Enumerator<OrderSaveData, object>.MoveNext
	|
	|-RVA: 0x3039B0 Offset: 0x303AB1 VA: 0x3039B0
	|-Dictionary.Enumerator<OrderSaveParameter, object>.MoveNext
	|
	|-RVA: 0x303B70 Offset: 0x303C71 VA: 0x303B70
	|-Dictionary.Enumerator<Parameter, object>.MoveNext
	|
	|-RVA: 0x3334A0 Offset: 0x3335A1 VA: 0x3334A0
	|-Dictionary.Enumerator<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>.MoveNext
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x303D40 Offset: 0x303E41 VA: 0x303D40
	|-Dictionary.Enumerator<bool, object>.MoveNext
	|
	|-RVA: 0x303EB0 Offset: 0x303FB1 VA: 0x303EB0
	|-Dictionary.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x304020 Offset: 0x304121 VA: 0x304020
	|-Dictionary.Enumerator<char, object>.MoveNext
	|
	|-RVA: 0x304190 Offset: 0x304291 VA: 0x304190
	|-Dictionary.Enumerator<DateTime, object>.MoveNext
	|
	|-RVA: 0x304300 Offset: 0x304401 VA: 0x304300
	|-Dictionary.Enumerator<double, object>.MoveNext
	|
	|-RVA: 0x304470 Offset: 0x304571 VA: 0x304470
	|-Dictionary.Enumerator<Guid, object>.MoveNext
	|
	|-RVA: 0x304600 Offset: 0x304701 VA: 0x304600
	|-Dictionary.Enumerator<short, object>.MoveNext
	|
	|-RVA: 0x331F60 Offset: 0x332061 VA: 0x331F60
	|-Dictionary.Enumerator<int, BossBehaviorController>.MoveNext
	|-Dictionary.Enumerator<int, FishSwim>.MoveNext
	|-Dictionary.Enumerator<int, HarinezumiController.NeedleController>.MoveNext
	|-Dictionary.Enumerator<int, MonsterBehaviorController>.MoveNext
	|-Dictionary.Enumerator<int, PartnerNPCBehaviorController>.MoveNext
	|-Dictionary.Enumerator<int, List<MeshDataConnectivity.Face>>.MoveNext
	|-Dictionary.Enumerator<int, object>.MoveNext
	|-Dictionary.Enumerator<int, string>.MoveNext
	|-Dictionary.Enumerator<int, PointerEventData>.MoveNext
	|-Dictionary.Enumerator<int, TerrainUtility.TerrainMap>.MoveNext
	|-Dictionary.Enumerator<int, Panel>.MoveNext
	|
	|-RVA: 0x3047B0 Offset: 0x3048B1 VA: 0x3047B0
	|-Dictionary.Enumerator<int, CropDataTable>.MoveNext
	|
	|-RVA: 0x3049A0 Offset: 0x304AA1 VA: 0x3049A0
	|-Dictionary.Enumerator<int, EffectDataTable>.MoveNext
	|
	|-RVA: 0x304B30 Offset: 0x304C31 VA: 0x304B30
	|-Dictionary.Enumerator<int, GimmickLayoutDataTable>.MoveNext
	|
	|-RVA: 0x331530 Offset: 0x331631 VA: 0x331530
	|-Dictionary.Enumerator<int, MineTypeDataTable>.MoveNext
	|
	|-RVA: 0x3316E0 Offset: 0x3317E1 VA: 0x3316E0
	|-Dictionary.Enumerator<int, MiningDataTable>.MoveNext
	|
	|-RVA: 0x331870 Offset: 0x331971 VA: 0x331870
	|-Dictionary.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x3319D0 Offset: 0x331AD1 VA: 0x3319D0
	|-Dictionary.Enumerator<int, char>.MoveNext
	|
	|-RVA: 0x331B30 Offset: 0x331C31 VA: 0x331B30
	|-Dictionary.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x331C90 Offset: 0x331D91 VA: 0x331C90
	|-Dictionary.Enumerator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x331DF0 Offset: 0x331EF1 VA: 0x331DF0
	|-Dictionary.Enumerator<int, long>.MoveNext
	|
	|-RVA: 0x3320E0 Offset: 0x3321E1 VA: 0x3320E0
	|-Dictionary.Enumerator<int, DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x332290 Offset: 0x332391 VA: 0x332290
	|-Dictionary.Enumerator<int, SceneInstance>.MoveNext
	|
	|-RVA: 0x332420 Offset: 0x332521 VA: 0x332420
	|-Dictionary.Enumerator<int, Vector2Int>.MoveNext
	|
	|-RVA: 0x332590 Offset: 0x332691 VA: 0x332590
	|-Dictionary.Enumerator<int, Vector3>.MoveNext
	|
	|-RVA: 0x332730 Offset: 0x332831 VA: 0x332730
	|-Dictionary.Enumerator<Int32Enum, MonsterDataTable>.MoveNext
	|
	|-RVA: 0x332910 Offset: 0x332A11 VA: 0x332910
	|-Dictionary.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.MoveNext
	|
	|-RVA: 0x332AC0 Offset: 0x332BC1 VA: 0x332AC0
	|-Dictionary.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.MoveNext
	|
	|-RVA: 0x332C40 Offset: 0x332D41 VA: 0x332C40
	|-Dictionary.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x332DA0 Offset: 0x332EA1 VA: 0x332DA0
	|-Dictionary.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x332F10 Offset: 0x333011 VA: 0x332F10
	|-Dictionary.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x333340 Offset: 0x333441 VA: 0x333340
	|-Dictionary.Enumerator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x333630 Offset: 0x333731 VA: 0x333630
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<float, float>>.MoveNext
	|
	|-RVA: 0x3337A0 Offset: 0x3338A1 VA: 0x3337A0
	|-Dictionary.Enumerator<Int32Enum, TutorialUnlockFlagData>.MoveNext
	|
	|-RVA: 0x333910 Offset: 0x333A11 VA: 0x333910
	|-Dictionary.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x333A80 Offset: 0x333B81 VA: 0x333A80
	|-Dictionary.Enumerator<Memory<object>, object>.MoveNext
	|
	|-RVA: 0x333C10 Offset: 0x333D11 VA: 0x333C10
	|-Dictionary.Enumerator<Nullable<Int32Enum>, object>.MoveNext
	|
	|-RVA: 0x333D90 Offset: 0x333E91 VA: 0x333D90
	|-Dictionary.Enumerator<Nullable<Bounds>, object>.MoveNext
	|
	|-RVA: 0x333F30 Offset: 0x334031 VA: 0x333F30
	|-Dictionary.Enumerator<Nullable<BoundsInt>, object>.MoveNext
	|
	|-RVA: 0x3340C0 Offset: 0x3341C1 VA: 0x3340C0
	|-Dictionary.Enumerator<Nullable<Color32>, object>.MoveNext
	|
	|-RVA: 0x334230 Offset: 0x334331 VA: 0x334230
	|-Dictionary.Enumerator<Nullable<Color>, object>.MoveNext
	|
	|-RVA: 0x3343C0 Offset: 0x3344C1 VA: 0x3343C0
	|-Dictionary.Enumerator<Nullable<GradientAlphaKey>, object>.MoveNext
	|
	|-RVA: 0x334550 Offset: 0x334651 VA: 0x334550
	|-Dictionary.Enumerator<Nullable<GradientColorKey>, object>.MoveNext
	|
	|-RVA: 0x3346F0 Offset: 0x3347F1 VA: 0x3346F0
	|-Dictionary.Enumerator<Nullable<Keyframe>, object>.MoveNext
	|
	|-RVA: 0x334880 Offset: 0x334981 VA: 0x334880
	|-Dictionary.Enumerator<Nullable<LayerMask>, object>.MoveNext
	|
	|-RVA: 0x334A00 Offset: 0x334B01 VA: 0x334A00
	|-Dictionary.Enumerator<Nullable<Matrix4x4>, object>.MoveNext
	|
	|-RVA: 0x334BB0 Offset: 0x334CB1 VA: 0x334BB0
	|-Dictionary.Enumerator<Nullable<Quaternion>, object>.MoveNext
	|
	|-RVA: 0x334D40 Offset: 0x334E41 VA: 0x334D40
	|-Dictionary.Enumerator<Nullable<RangeInt>, object>.MoveNext
	|
	|-RVA: 0x334ED0 Offset: 0x334FD1 VA: 0x334ED0
	|-Dictionary.Enumerator<Nullable<Rect>, object>.MoveNext
	|
	|-RVA: 0x32D8A0 Offset: 0x32D9A1 VA: 0x32D8A0
	|-Dictionary.Enumerator<Nullable<RectInt>, object>.MoveNext
	|
	|-RVA: 0x32DA30 Offset: 0x32DB31 VA: 0x32DA30
	|-Dictionary.Enumerator<Nullable<Vector2>, object>.MoveNext
	|
	|-RVA: 0x32DBC0 Offset: 0x32DCC1 VA: 0x32DBC0
	|-Dictionary.Enumerator<Nullable<Vector2Int>, object>.MoveNext
	|
	|-RVA: 0x32DD50 Offset: 0x32DE51 VA: 0x32DD50
	|-Dictionary.Enumerator<Nullable<Vector3>, object>.MoveNext
	|
	|-RVA: 0x32DEE0 Offset: 0x32DFE1 VA: 0x32DEE0
	|-Dictionary.Enumerator<Nullable<Vector3Int>, object>.MoveNext
	|
	|-RVA: 0x32E070 Offset: 0x32E171 VA: 0x32E070
	|-Dictionary.Enumerator<Nullable<Vector4>, object>.MoveNext
	|
	|-RVA: 0x32E200 Offset: 0x32E301 VA: 0x32E200
	|-Dictionary.Enumerator<object, BitVector32Int>.MoveNext
	|
	|-RVA: 0x32E370 Offset: 0x32E471 VA: 0x32E370
	|-Dictionary.Enumerator<object, EventCheckId>.MoveNext
	|
	|-RVA: 0x32E510 Offset: 0x32E611 VA: 0x32E510
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE>.MoveNext
	|
	|-RVA: 0x32E6C0 Offset: 0x32E7C1 VA: 0x32E6C0
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.MoveNext
	|
	|-RVA: 0x32E850 Offset: 0x32E951 VA: 0x32E850
	|-Dictionary.Enumerator<object, FarmManager.RF4_MCROP_INFO>.MoveNext
	|
	|-RVA: 0x32E9E0 Offset: 0x32EAE1 VA: 0x32E9E0
	|-Dictionary.Enumerator<object, FarmManager.RF4_SOIL_INFO>.MoveNext
	|
	|-RVA: 0x32EB80 Offset: 0x32EC81 VA: 0x32EB80
	|-Dictionary.Enumerator<object, MonsterHutSaveData>.MoveNext
	|
	|-RVA: 0x32ED10 Offset: 0x32EE11 VA: 0x32ED10
	|-Dictionary.Enumerator<object, OrderLotterySaveParameter>.MoveNext
	|
	|-RVA: 0x32EEB0 Offset: 0x32EFB1 VA: 0x32EEB0
	|-Dictionary.Enumerator<object, OrderSaveData>.MoveNext
	|
	|-RVA: 0x32F050 Offset: 0x32F151 VA: 0x32F050
	|-Dictionary.Enumerator<object, OrderSaveParameter>.MoveNext
	|
	|-RVA: 0x32F210 Offset: 0x32F311 VA: 0x32F210
	|-Dictionary.Enumerator<object, Parameter>.MoveNext
	|
	|-RVA: 0x32F3E0 Offset: 0x32F4E1 VA: 0x32F3E0
	|-Dictionary.Enumerator<object, NumberControl.ValueRange>.MoveNext
	|
	|-RVA: 0x32F570 Offset: 0x32F671 VA: 0x32F570
	|-Dictionary.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x32F6E0 Offset: 0x32F7E1 VA: 0x32F6E0
	|-Dictionary.Enumerator<object, byte>.MoveNext
	|
	|-RVA: 0x32F850 Offset: 0x32F951 VA: 0x32F850
	|-Dictionary.Enumerator<object, char>.MoveNext
	|
	|-RVA: 0x32F9C0 Offset: 0x32FAC1 VA: 0x32F9C0
	|-Dictionary.Enumerator<object, DateTime>.MoveNext
	|
	|-RVA: 0x32FB30 Offset: 0x32FC31 VA: 0x32FB30
	|-Dictionary.Enumerator<object, double>.MoveNext
	|
	|-RVA: 0x32FCA0 Offset: 0x32FDA1 VA: 0x32FCA0
	|-Dictionary.Enumerator<object, short>.MoveNext
	|
	|-RVA: 0x32FF80 Offset: 0x330081 VA: 0x32FF80
	|-Dictionary.Enumerator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x3300F0 Offset: 0x3301F1 VA: 0x3300F0
	|-Dictionary.Enumerator<object, long>.MoveNext
	|
	|-RVA: 0x330260 Offset: 0x330361 VA: 0x330260
	|-Dictionary.Enumerator<object, Memory<object>>.MoveNext
	|
	|-RVA: 0x3303F0 Offset: 0x3304F1 VA: 0x3303F0
	|-Dictionary.Enumerator<object, Nullable<Int32Enum>>.MoveNext
	|
	|-RVA: 0x330570 Offset: 0x330671 VA: 0x330570
	|-Dictionary.Enumerator<object, Nullable<Bounds>>.MoveNext
	|
	|-RVA: 0x330710 Offset: 0x330811 VA: 0x330710
	|-Dictionary.Enumerator<object, Nullable<BoundsInt>>.MoveNext
	|
	|-RVA: 0x3308A0 Offset: 0x3309A1 VA: 0x3308A0
	|-Dictionary.Enumerator<object, Nullable<Color32>>.MoveNext
	|
	|-RVA: 0x330A10 Offset: 0x330B11 VA: 0x330A10
	|-Dictionary.Enumerator<object, Nullable<Color>>.MoveNext
	|
	|-RVA: 0x330BA0 Offset: 0x330CA1 VA: 0x330BA0
	|-Dictionary.Enumerator<object, Nullable<GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x330D30 Offset: 0x330E31 VA: 0x330D30
	|-Dictionary.Enumerator<object, Nullable<GradientColorKey>>.MoveNext
	|
	|-RVA: 0x330ED0 Offset: 0x330FD1 VA: 0x330ED0
	|-Dictionary.Enumerator<object, Nullable<Keyframe>>.MoveNext
	|
	|-RVA: 0x331060 Offset: 0x331161 VA: 0x331060
	|-Dictionary.Enumerator<object, Nullable<LayerMask>>.MoveNext
	|
	|-RVA: 0x3311E0 Offset: 0x3312E1 VA: 0x3311E0
	|-Dictionary.Enumerator<object, Nullable<Matrix4x4>>.MoveNext
	|
	|-RVA: 0x331390 Offset: 0x331491 VA: 0x331390
	|-Dictionary.Enumerator<object, Nullable<Quaternion>>.MoveNext
	|
	|-RVA: 0x33EE60 Offset: 0x33EF61 VA: 0x33EE60
	|-Dictionary.Enumerator<object, Nullable<RangeInt>>.MoveNext
	|
	|-RVA: 0x33EFF0 Offset: 0x33F0F1 VA: 0x33EFF0
	|-Dictionary.Enumerator<object, Nullable<Rect>>.MoveNext
	|
	|-RVA: 0x33F180 Offset: 0x33F281 VA: 0x33F180
	|-Dictionary.Enumerator<object, Nullable<RectInt>>.MoveNext
	|
	|-RVA: 0x33F310 Offset: 0x33F411 VA: 0x33F310
	|-Dictionary.Enumerator<object, Nullable<Vector2>>.MoveNext
	|
	|-RVA: 0x33F4A0 Offset: 0x33F5A1 VA: 0x33F4A0
	|-Dictionary.Enumerator<object, Nullable<Vector2Int>>.MoveNext
	|
	|-RVA: 0x33F630 Offset: 0x33F731 VA: 0x33F630
	|-Dictionary.Enumerator<object, Nullable<Vector3>>.MoveNext
	|
	|-RVA: 0x33F7C0 Offset: 0x33F8C1 VA: 0x33F7C0
	|-Dictionary.Enumerator<object, Nullable<Vector3Int>>.MoveNext
	|
	|-RVA: 0x33F950 Offset: 0x33FA51 VA: 0x33F950
	|-Dictionary.Enumerator<object, Nullable<Vector4>>.MoveNext
	|
	|-RVA: 0x33FC50 Offset: 0x33FD51 VA: 0x33FC50
	|-Dictionary.Enumerator<object, ReadOnlyMemory<object>>.MoveNext
	|
	|-RVA: 0x33FDE0 Offset: 0x33FEE1 VA: 0x33FDE0
	|-Dictionary.Enumerator<object, ResourceLocator>.MoveNext
	|
	|-RVA: 0x33FF70 Offset: 0x340071 VA: 0x33FF70
	|-Dictionary.Enumerator<object, sbyte>.MoveNext
	|
	|-RVA: 0x3400E0 Offset: 0x3401E1 VA: 0x3400E0
	|-Dictionary.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x340250 Offset: 0x340351 VA: 0x340250
	|-Dictionary.Enumerator<object, ushort>.MoveNext
	|
	|-RVA: 0x3403C0 Offset: 0x3404C1 VA: 0x3403C0
	|-Dictionary.Enumerator<object, uint>.MoveNext
	|
	|-RVA: 0x340530 Offset: 0x340631 VA: 0x340530
	|-Dictionary.Enumerator<object, ulong>.MoveNext
	|
	|-RVA: 0x3406B0 Offset: 0x3407B1 VA: 0x3406B0
	|-Dictionary.Enumerator<object, TransitionTables>.MoveNext
	|
	|-RVA: 0x340840 Offset: 0x340941 VA: 0x340840
	|-Dictionary.Enumerator<object, Bounds>.MoveNext
	|
	|-RVA: 0x3409D0 Offset: 0x340AD1 VA: 0x3409D0
	|-Dictionary.Enumerator<object, BoundsInt>.MoveNext
	|
	|-RVA: 0x340B60 Offset: 0x340C61 VA: 0x340B60
	|-Dictionary.Enumerator<object, Color32>.MoveNext
	|
	|-RVA: 0x340CD0 Offset: 0x340DD1 VA: 0x340CD0
	|-Dictionary.Enumerator<object, Color>.MoveNext
	|
	|-RVA: 0x340E60 Offset: 0x340F61 VA: 0x340E60
	|-Dictionary.Enumerator<object, GradientAlphaKey>.MoveNext
	|
	|-RVA: 0x340FD0 Offset: 0x3410D1 VA: 0x340FD0
	|-Dictionary.Enumerator<object, GradientColorKey>.MoveNext
	|
	|-RVA: 0x341170 Offset: 0x341271 VA: 0x341170
	|-Dictionary.Enumerator<object, Keyframe>.MoveNext
	|
	|-RVA: 0x341300 Offset: 0x341401 VA: 0x341300
	|-Dictionary.Enumerator<object, LayerMask>.MoveNext
	|
	|-RVA: 0x341480 Offset: 0x341581 VA: 0x341480
	|-Dictionary.Enumerator<object, Matrix4x4>.MoveNext
	|
	|-RVA: 0x341630 Offset: 0x341731 VA: 0x341630
	|-Dictionary.Enumerator<object, Playable>.MoveNext
	|
	|-RVA: 0x3417C0 Offset: 0x3418C1 VA: 0x3417C0
	|-Dictionary.Enumerator<object, Quaternion>.MoveNext
	|
	|-RVA: 0x341950 Offset: 0x341A51 VA: 0x341950
	|-Dictionary.Enumerator<object, RangeInt>.MoveNext
	|
	|-RVA: 0x341AC0 Offset: 0x341BC1 VA: 0x341AC0
	|-Dictionary.Enumerator<object, Rect>.MoveNext
	|
	|-RVA: 0x341C50 Offset: 0x341D51 VA: 0x341C50
	|-Dictionary.Enumerator<object, RectInt>.MoveNext
	|
	|-RVA: 0x341DE0 Offset: 0x341EE1 VA: 0x341DE0
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x341F70 Offset: 0x342071 VA: 0x341F70
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x342100 Offset: 0x342201 VA: 0x342100
	|-Dictionary.Enumerator<object, Vector2>.MoveNext
	|
	|-RVA: 0x342270 Offset: 0x342371 VA: 0x342270
	|-Dictionary.Enumerator<object, Vector2Int>.MoveNext
	|
	|-RVA: 0x3423E0 Offset: 0x3424E1 VA: 0x3423E0
	|-Dictionary.Enumerator<object, Vector3>.MoveNext
	|
	|-RVA: 0x342570 Offset: 0x342671 VA: 0x342570
	|-Dictionary.Enumerator<object, Vector3Int>.MoveNext
	|
	|-RVA: 0x342700 Offset: 0x342801 VA: 0x342700
	|-Dictionary.Enumerator<object, Vector4>.MoveNext
	|
	|-RVA: 0x342890 Offset: 0x342991 VA: 0x342890
	|-Dictionary.Enumerator<ReadOnlyMemory<object>, object>.MoveNext
	|
	|-RVA: 0x335060 Offset: 0x335161 VA: 0x335060
	|-Dictionary.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x3351D0 Offset: 0x3352D1 VA: 0x3351D0
	|-Dictionary.Enumerator<sbyte, object>.MoveNext
	|
	|-RVA: 0x335350 Offset: 0x335451 VA: 0x335350
	|-Dictionary.Enumerator<float, CurveSample>.MoveNext
	|
	|-RVA: 0x335510 Offset: 0x335611 VA: 0x335510
	|-Dictionary.Enumerator<float, object>.MoveNext
	|
	|-RVA: 0x335680 Offset: 0x335781 VA: 0x335680
	|-Dictionary.Enumerator<ushort, object>.MoveNext
	|
	|-RVA: 0x335AB0 Offset: 0x335BB1 VA: 0x335AB0
	|-Dictionary.Enumerator<uint, FarmMonsterBehaviorController>.MoveNext
	|-Dictionary.Enumerator<uint, TriangulationConstraint>.MoveNext
	|-Dictionary.Enumerator<uint, object>.MoveNext
	|
	|-RVA: 0x3357F0 Offset: 0x3358F1 VA: 0x3357F0
	|-Dictionary.Enumerator<uint, int>.MoveNext
	|
	|-RVA: 0x335950 Offset: 0x335A51 VA: 0x335950
	|-Dictionary.Enumerator<uint, Int32Enum>.MoveNext
	|
	|-RVA: 0x335C20 Offset: 0x335D21 VA: 0x335C20
	|-Dictionary.Enumerator<ulong, object>.MoveNext
	|
	|-RVA: 0x335D90 Offset: 0x335E91 VA: 0x335D90
	|-Dictionary.Enumerator<EdgeKeyByHash, int>.MoveNext
	|
	|-RVA: 0x335F10 Offset: 0x336011 VA: 0x335F10
	|-Dictionary.Enumerator<EdgeKeyByHash, CapEdge>.MoveNext
	|
	|-RVA: 0x3360C0 Offset: 0x3361C1 VA: 0x3360C0
	|-Dictionary.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.MoveNext
	|
	|-RVA: 0x336270 Offset: 0x336371 VA: 0x336270
	|-Dictionary.Enumerator<EdgeKeyByIndex, ClippedEdge>.MoveNext
	|
	|-RVA: 0x336400 Offset: 0x336501 VA: 0x336400
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, bool>.MoveNext
	|
	|-RVA: 0x336570 Offset: 0x336671 VA: 0x336570
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, List<int>>.MoveNext
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, object>.MoveNext
	|
	|-RVA: 0x3366E0 Offset: 0x3367E1 VA: 0x3366E0
	|-Dictionary.Enumerator<Bounds, object>.MoveNext
	|
	|-RVA: 0x336870 Offset: 0x336971 VA: 0x336870
	|-Dictionary.Enumerator<BoundsInt, object>.MoveNext
	|
	|-RVA: 0x336A00 Offset: 0x336B01 VA: 0x336A00
	|-Dictionary.Enumerator<Color, object>.MoveNext
	|
	|-RVA: 0x336B90 Offset: 0x336C91 VA: 0x336B90
	|-Dictionary.Enumerator<Color32, object>.MoveNext
	|
	|-RVA: 0x336D00 Offset: 0x336E01 VA: 0x336D00
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.MoveNext
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.MoveNext
	|
	|-RVA: 0x336E70 Offset: 0x336F71 VA: 0x336E70
	|-Dictionary.Enumerator<GradientAlphaKey, object>.MoveNext
	|
	|-RVA: 0x336FE0 Offset: 0x3370E1 VA: 0x336FE0
	|-Dictionary.Enumerator<GradientColorKey, object>.MoveNext
	|
	|-RVA: 0x337180 Offset: 0x337281 VA: 0x337180
	|-Dictionary.Enumerator<Keyframe, object>.MoveNext
	|
	|-RVA: 0x337310 Offset: 0x337411 VA: 0x337310
	|-Dictionary.Enumerator<LayerMask, object>.MoveNext
	|
	|-RVA: 0x337490 Offset: 0x337591 VA: 0x337490
	|-Dictionary.Enumerator<Matrix4x4, object>.MoveNext
	|
	|-RVA: 0x337640 Offset: 0x337741 VA: 0x337640
	|-Dictionary.Enumerator<IntVec3, List<int>>.MoveNext
	|-Dictionary.Enumerator<IntVec3, object>.MoveNext
	|
	|-RVA: 0x3377D0 Offset: 0x3378D1 VA: 0x3377D0
	|-Dictionary.Enumerator<Quaternion, object>.MoveNext
	|
	|-RVA: 0x337960 Offset: 0x337A61 VA: 0x337960
	|-Dictionary.Enumerator<RangeInt, object>.MoveNext
	|
	|-RVA: 0x337AD0 Offset: 0x337BD1 VA: 0x337AD0
	|-Dictionary.Enumerator<Rect, object>.MoveNext
	|
	|-RVA: 0x337C60 Offset: 0x337D61 VA: 0x337C60
	|-Dictionary.Enumerator<RectInt, object>.MoveNext
	|
	|-RVA: 0x337DF0 Offset: 0x337EF1 VA: 0x337DF0
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, int>.MoveNext
	|
	|-RVA: 0x337F60 Offset: 0x338061 VA: 0x337F60
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.MoveNext
	|
	|-RVA: 0x3380D0 Offset: 0x3381D1 VA: 0x3380D0
	|-Dictionary.Enumerator<Vector2, object>.MoveNext
	|
	|-RVA: 0x338240 Offset: 0x338341 VA: 0x338240
	|-Dictionary.Enumerator<Vector2Int, object>.MoveNext
	|
	|-RVA: 0x3383B0 Offset: 0x3384B1 VA: 0x3383B0
	|-Dictionary.Enumerator<Vector3, List<int>>.MoveNext
	|-Dictionary.Enumerator<Vector3, object>.MoveNext
	|
	|-RVA: 0x338540 Offset: 0x338641 VA: 0x338540
	|-Dictionary.Enumerator<Vector3Int, object>.MoveNext
	|
	|-RVA: 0x3386D0 Offset: 0x3387D1 VA: 0x3386D0
	|-Dictionary.Enumerator<Vector4, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33FAF0 Offset: 0x33FBF1 VA: 0x33FAF0
	|-Dictionary.Enumerator<SharedVariable, object>.get_Current
	|-Dictionary.Enumerator<CharacterBase, DamageTextController>.get_Current
	|-Dictionary.Enumerator<ICinemachineCamera, object>.get_Current
	|-Dictionary.Enumerator<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.get_Current
	|-Dictionary.Enumerator<OptionDefinition, OptionsControlBase>.get_Current
	|-Dictionary.Enumerator<byte[], Encoding>.get_Current
	|-Dictionary.Enumerator<int[], SceneSplit>.get_Current
	|-Dictionary.Enumerator<int[], Terrain>.get_Current
	|-Dictionary.Enumerator<string, BehaviorManager.TaskAddData.OverrideFieldValue>.get_Current
	|-Dictionary.Enumerator<string, Texture[]>.get_Current
	|-Dictionary.Enumerator<string, InfoBlock>.get_Current
	|-Dictionary.Enumerator<string, SeasonTextureData>.get_Current
	|-Dictionary.Enumerator<string, IList<InfoEntry>>.get_Current
	|-Dictionary.Enumerator<string, List<TaskCoroutine>>.get_Current
	|-Dictionary.Enumerator<string, List<OptionDefinition>>.get_Current
	|-Dictionary.Enumerator<string, object>.get_Current
	|-Dictionary.Enumerator<string, ResourceLocationBase>.get_Current
	|-Dictionary.Enumerator<TimeParamTable, HashSet<ObjectChangeTime>>.get_Current
	|-Dictionary.Enumerator<TimeParamTable, HashSet<RendererChangeTime>>.get_Current
	|-Dictionary.Enumerator<TimeParamTable, HashSet<Material>>.get_Current
	|-Dictionary.Enumerator<Camera, Camera>.get_Current
	|-Dictionary.Enumerator<Collider, CharacterNearCullingController>.get_Current
	|-Dictionary.Enumerator<GameObject, Material[]>.get_Current
	|-Dictionary.Enumerator<GameObject, Renderer[]>.get_Current
	|-Dictionary.Enumerator<Transform, TargetPositionCache.CacheEntry>.get_Current
	|-Dictionary.Enumerator<Transform, UpdateTracker.UpdateStatus>.get_Current
	|-Dictionary.Enumerator<Transform, List<SpringBone>>.get_Current
	|-Dictionary.Enumerator<object, object>.get_Current
	|-Dictionary.Enumerator<string, string>.get_Current
	|
	|-RVA: 0x3331E0 Offset: 0x3332E1 VA: 0x3331E0
	|-Dictionary.Enumerator<BadStatus, BadStatusEffectController.ObjInfo>.get_Current
	|-Dictionary.Enumerator<VariationNo, HumanData>.get_Current
	|-Dictionary.Enumerator<EnvironmentSoundType, List<EnvironmentSoundDataTable>>.get_Current
	|-Dictionary.Enumerator<EquipSlotType, AS_ToolController.ToolActionData>.get_Current
	|-Dictionary.Enumerator<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.get_Current
	|-Dictionary.Enumerator<SoundID, EnvironmentSoundDataTable>.get_Current
	|-Dictionary.Enumerator<SoundID, EnvironmentSoundController>.get_Current
	|-Dictionary.Enumerator<Int32Enum, object>.get_Current
	|
	|-RVA: 0x333080 Offset: 0x333181 VA: 0x333080
	|-Dictionary.Enumerator<EmotionType, Prefab>.get_Current
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x32FE20 Offset: 0x32FF21 VA: 0x32FE20
	|-Dictionary.Enumerator<MonsterControllerBase, int>.get_Current
	|-Dictionary.Enumerator<object, int>.get_Current
	|
	|-RVA: 0x3334B0 Offset: 0x3335B1 VA: 0x3334B0
	|-Dictionary.Enumerator<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>.get_Current
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<object, object>>.get_Current
	|
	|-RVA: 0x331F70 Offset: 0x332071 VA: 0x331F70
	|-Dictionary.Enumerator<int, BossBehaviorController>.get_Current
	|-Dictionary.Enumerator<int, FishSwim>.get_Current
	|-Dictionary.Enumerator<int, HarinezumiController.NeedleController>.get_Current
	|-Dictionary.Enumerator<int, MonsterBehaviorController>.get_Current
	|-Dictionary.Enumerator<int, PartnerNPCBehaviorController>.get_Current
	|-Dictionary.Enumerator<int, List<MeshDataConnectivity.Face>>.get_Current
	|-Dictionary.Enumerator<int, string>.get_Current
	|-Dictionary.Enumerator<int, PointerEventData>.get_Current
	|-Dictionary.Enumerator<int, TerrainUtility.TerrainMap>.get_Current
	|-Dictionary.Enumerator<int, Panel>.get_Current
	|-Dictionary.Enumerator<int, object>.get_Current
	|
	|-RVA: 0x331B40 Offset: 0x331C41 VA: 0x331B40
	|-Dictionary.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x3325A0 Offset: 0x3326A1 VA: 0x3325A0
	|-Dictionary.Enumerator<int, Vector3>.get_Current
	|
	|-RVA: 0x335AC0 Offset: 0x335BC1 VA: 0x335AC0
	|-Dictionary.Enumerator<uint, FarmMonsterBehaviorController>.get_Current
	|-Dictionary.Enumerator<uint, TriangulationConstraint>.get_Current
	|-Dictionary.Enumerator<uint, object>.get_Current
	|
	|-RVA: 0x336410 Offset: 0x336511 VA: 0x336410
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, bool>.get_Current
	|
	|-RVA: 0x336580 Offset: 0x336681 VA: 0x336580
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, List<int>>.get_Current
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, object>.get_Current
	|
	|-RVA: 0x336D10 Offset: 0x336E11 VA: 0x336D10
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Current
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.get_Current
	|
	|-RVA: 0x337650 Offset: 0x337751 VA: 0x337650
	|-Dictionary.Enumerator<IntVec3, List<int>>.get_Current
	|-Dictionary.Enumerator<IntVec3, object>.get_Current
	|
	|-RVA: 0x3383C0 Offset: 0x3384C1 VA: 0x3383C0
	|-Dictionary.Enumerator<Vector3, List<int>>.get_Current
	|-Dictionary.Enumerator<Vector3, object>.get_Current
	|
	|-RVA: 0x3029E0 Offset: 0x302AE1 VA: 0x3029E0
	|-Dictionary.Enumerator<JSONDeserialization.TaskField, object>.get_Current
	|
	|-RVA: 0x302B70 Offset: 0x302C71 VA: 0x302B70
	|-Dictionary.Enumerator<BitVector32Int, object>.get_Current
	|
	|-RVA: 0x302CE0 Offset: 0x302DE1 VA: 0x302CE0
	|-Dictionary.Enumerator<EventCheckId, object>.get_Current
	|
	|-RVA: 0x302E80 Offset: 0x302F81 VA: 0x302E80
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE, object>.get_Current
	|
	|-RVA: 0x303030 Offset: 0x303131 VA: 0x303030
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.get_Current
	|
	|-RVA: 0x3031C0 Offset: 0x3032C1 VA: 0x3031C0
	|-Dictionary.Enumerator<FarmManager.RF4_MCROP_INFO, object>.get_Current
	|
	|-RVA: 0x303350 Offset: 0x303451 VA: 0x303350
	|-Dictionary.Enumerator<FarmManager.RF4_SOIL_INFO, object>.get_Current
	|
	|-RVA: 0x3034F0 Offset: 0x3035F1 VA: 0x3034F0
	|-Dictionary.Enumerator<MonsterHutSaveData, object>.get_Current
	|
	|-RVA: 0x303680 Offset: 0x303781 VA: 0x303680
	|-Dictionary.Enumerator<OrderLotterySaveParameter, object>.get_Current
	|
	|-RVA: 0x303820 Offset: 0x303921 VA: 0x303820
	|-Dictionary.Enumerator<OrderSaveData, object>.get_Current
	|
	|-RVA: 0x3039C0 Offset: 0x303AC1 VA: 0x3039C0
	|-Dictionary.Enumerator<OrderSaveParameter, object>.get_Current
	|
	|-RVA: 0x303B80 Offset: 0x303C81 VA: 0x303B80
	|-Dictionary.Enumerator<Parameter, object>.get_Current
	|
	|-RVA: 0x303D50 Offset: 0x303E51 VA: 0x303D50
	|-Dictionary.Enumerator<bool, object>.get_Current
	|
	|-RVA: 0x303EC0 Offset: 0x303FC1 VA: 0x303EC0
	|-Dictionary.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x304030 Offset: 0x304131 VA: 0x304030
	|-Dictionary.Enumerator<char, object>.get_Current
	|
	|-RVA: 0x3041A0 Offset: 0x3042A1 VA: 0x3041A0
	|-Dictionary.Enumerator<DateTime, object>.get_Current
	|
	|-RVA: 0x304310 Offset: 0x304411 VA: 0x304310
	|-Dictionary.Enumerator<double, object>.get_Current
	|
	|-RVA: 0x304480 Offset: 0x304581 VA: 0x304480
	|-Dictionary.Enumerator<Guid, object>.get_Current
	|
	|-RVA: 0x304610 Offset: 0x304711 VA: 0x304610
	|-Dictionary.Enumerator<short, object>.get_Current
	|
	|-RVA: 0x3047C0 Offset: 0x3048C1 VA: 0x3047C0
	|-Dictionary.Enumerator<int, CropDataTable>.get_Current
	|
	|-RVA: 0x3049B0 Offset: 0x304AB1 VA: 0x3049B0
	|-Dictionary.Enumerator<int, EffectDataTable>.get_Current
	|
	|-RVA: 0x304B40 Offset: 0x304C41 VA: 0x304B40
	|-Dictionary.Enumerator<int, GimmickLayoutDataTable>.get_Current
	|
	|-RVA: 0x331540 Offset: 0x331641 VA: 0x331540
	|-Dictionary.Enumerator<int, MineTypeDataTable>.get_Current
	|
	|-RVA: 0x3316F0 Offset: 0x3317F1 VA: 0x3316F0
	|-Dictionary.Enumerator<int, MiningDataTable>.get_Current
	|
	|-RVA: 0x331880 Offset: 0x331981 VA: 0x331880
	|-Dictionary.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x3319E0 Offset: 0x331AE1 VA: 0x3319E0
	|-Dictionary.Enumerator<int, char>.get_Current
	|
	|-RVA: 0x331CA0 Offset: 0x331DA1 VA: 0x331CA0
	|-Dictionary.Enumerator<int, Int32Enum>.get_Current
	|
	|-RVA: 0x331E00 Offset: 0x331F01 VA: 0x331E00
	|-Dictionary.Enumerator<int, long>.get_Current
	|
	|-RVA: 0x3320F0 Offset: 0x3321F1 VA: 0x3320F0
	|-Dictionary.Enumerator<int, DiagnosticEvent>.get_Current
	|
	|-RVA: 0x3322A0 Offset: 0x3323A1 VA: 0x3322A0
	|-Dictionary.Enumerator<int, SceneInstance>.get_Current
	|
	|-RVA: 0x332430 Offset: 0x332531 VA: 0x332430
	|-Dictionary.Enumerator<int, Vector2Int>.get_Current
	|
	|-RVA: 0x332740 Offset: 0x332841 VA: 0x332740
	|-Dictionary.Enumerator<Int32Enum, MonsterDataTable>.get_Current
	|
	|-RVA: 0x332920 Offset: 0x332A21 VA: 0x332920
	|-Dictionary.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.get_Current
	|
	|-RVA: 0x332AD0 Offset: 0x332BD1 VA: 0x332AD0
	|-Dictionary.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Current
	|
	|-RVA: 0x332C50 Offset: 0x332D51 VA: 0x332C50
	|-Dictionary.Enumerator<Int32Enum, bool>.get_Current
	|
	|-RVA: 0x332DB0 Offset: 0x332EB1 VA: 0x332DB0
	|-Dictionary.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x332F20 Offset: 0x333021 VA: 0x332F20
	|-Dictionary.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x333350 Offset: 0x333451 VA: 0x333350
	|-Dictionary.Enumerator<Int32Enum, float>.get_Current
	|
	|-RVA: 0x333640 Offset: 0x333741 VA: 0x333640
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<float, float>>.get_Current
	|
	|-RVA: 0x3337B0 Offset: 0x3338B1 VA: 0x3337B0
	|-Dictionary.Enumerator<Int32Enum, TutorialUnlockFlagData>.get_Current
	|
	|-RVA: 0x333920 Offset: 0x333A21 VA: 0x333920
	|-Dictionary.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x333A90 Offset: 0x333B91 VA: 0x333A90
	|-Dictionary.Enumerator<Memory<object>, object>.get_Current
	|
	|-RVA: 0x333C20 Offset: 0x333D21 VA: 0x333C20
	|-Dictionary.Enumerator<Nullable<Int32Enum>, object>.get_Current
	|
	|-RVA: 0x333DA0 Offset: 0x333EA1 VA: 0x333DA0
	|-Dictionary.Enumerator<Nullable<Bounds>, object>.get_Current
	|
	|-RVA: 0x333F40 Offset: 0x334041 VA: 0x333F40
	|-Dictionary.Enumerator<Nullable<BoundsInt>, object>.get_Current
	|
	|-RVA: 0x3340D0 Offset: 0x3341D1 VA: 0x3340D0
	|-Dictionary.Enumerator<Nullable<Color32>, object>.get_Current
	|
	|-RVA: 0x334240 Offset: 0x334341 VA: 0x334240
	|-Dictionary.Enumerator<Nullable<Color>, object>.get_Current
	|
	|-RVA: 0x3343D0 Offset: 0x3344D1 VA: 0x3343D0
	|-Dictionary.Enumerator<Nullable<GradientAlphaKey>, object>.get_Current
	|
	|-RVA: 0x334560 Offset: 0x334661 VA: 0x334560
	|-Dictionary.Enumerator<Nullable<GradientColorKey>, object>.get_Current
	|
	|-RVA: 0x334700 Offset: 0x334801 VA: 0x334700
	|-Dictionary.Enumerator<Nullable<Keyframe>, object>.get_Current
	|
	|-RVA: 0x334890 Offset: 0x334991 VA: 0x334890
	|-Dictionary.Enumerator<Nullable<LayerMask>, object>.get_Current
	|
	|-RVA: 0x334A10 Offset: 0x334B11 VA: 0x334A10
	|-Dictionary.Enumerator<Nullable<Matrix4x4>, object>.get_Current
	|
	|-RVA: 0x334BC0 Offset: 0x334CC1 VA: 0x334BC0
	|-Dictionary.Enumerator<Nullable<Quaternion>, object>.get_Current
	|
	|-RVA: 0x334D50 Offset: 0x334E51 VA: 0x334D50
	|-Dictionary.Enumerator<Nullable<RangeInt>, object>.get_Current
	|
	|-RVA: 0x334EE0 Offset: 0x334FE1 VA: 0x334EE0
	|-Dictionary.Enumerator<Nullable<Rect>, object>.get_Current
	|
	|-RVA: 0x32D8B0 Offset: 0x32D9B1 VA: 0x32D8B0
	|-Dictionary.Enumerator<Nullable<RectInt>, object>.get_Current
	|
	|-RVA: 0x32DA40 Offset: 0x32DB41 VA: 0x32DA40
	|-Dictionary.Enumerator<Nullable<Vector2>, object>.get_Current
	|
	|-RVA: 0x32DBD0 Offset: 0x32DCD1 VA: 0x32DBD0
	|-Dictionary.Enumerator<Nullable<Vector2Int>, object>.get_Current
	|
	|-RVA: 0x32DD60 Offset: 0x32DE61 VA: 0x32DD60
	|-Dictionary.Enumerator<Nullable<Vector3>, object>.get_Current
	|
	|-RVA: 0x32DEF0 Offset: 0x32DFF1 VA: 0x32DEF0
	|-Dictionary.Enumerator<Nullable<Vector3Int>, object>.get_Current
	|
	|-RVA: 0x32E080 Offset: 0x32E181 VA: 0x32E080
	|-Dictionary.Enumerator<Nullable<Vector4>, object>.get_Current
	|
	|-RVA: 0x32E210 Offset: 0x32E311 VA: 0x32E210
	|-Dictionary.Enumerator<object, BitVector32Int>.get_Current
	|
	|-RVA: 0x32E380 Offset: 0x32E481 VA: 0x32E380
	|-Dictionary.Enumerator<object, EventCheckId>.get_Current
	|
	|-RVA: 0x32E520 Offset: 0x32E621 VA: 0x32E520
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE>.get_Current
	|
	|-RVA: 0x32E6D0 Offset: 0x32E7D1 VA: 0x32E6D0
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.get_Current
	|
	|-RVA: 0x32E860 Offset: 0x32E961 VA: 0x32E860
	|-Dictionary.Enumerator<object, FarmManager.RF4_MCROP_INFO>.get_Current
	|
	|-RVA: 0x32E9F0 Offset: 0x32EAF1 VA: 0x32E9F0
	|-Dictionary.Enumerator<object, FarmManager.RF4_SOIL_INFO>.get_Current
	|
	|-RVA: 0x32EB90 Offset: 0x32EC91 VA: 0x32EB90
	|-Dictionary.Enumerator<object, MonsterHutSaveData>.get_Current
	|
	|-RVA: 0x32ED20 Offset: 0x32EE21 VA: 0x32ED20
	|-Dictionary.Enumerator<object, OrderLotterySaveParameter>.get_Current
	|
	|-RVA: 0x32EEC0 Offset: 0x32EFC1 VA: 0x32EEC0
	|-Dictionary.Enumerator<object, OrderSaveData>.get_Current
	|
	|-RVA: 0x32F060 Offset: 0x32F161 VA: 0x32F060
	|-Dictionary.Enumerator<object, OrderSaveParameter>.get_Current
	|
	|-RVA: 0x32F220 Offset: 0x32F321 VA: 0x32F220
	|-Dictionary.Enumerator<object, Parameter>.get_Current
	|
	|-RVA: 0x32F3F0 Offset: 0x32F4F1 VA: 0x32F3F0
	|-Dictionary.Enumerator<object, NumberControl.ValueRange>.get_Current
	|
	|-RVA: 0x32F580 Offset: 0x32F681 VA: 0x32F580
	|-Dictionary.Enumerator<object, bool>.get_Current
	|
	|-RVA: 0x32F6F0 Offset: 0x32F7F1 VA: 0x32F6F0
	|-Dictionary.Enumerator<object, byte>.get_Current
	|
	|-RVA: 0x32F860 Offset: 0x32F961 VA: 0x32F860
	|-Dictionary.Enumerator<object, char>.get_Current
	|
	|-RVA: 0x32F9D0 Offset: 0x32FAD1 VA: 0x32F9D0
	|-Dictionary.Enumerator<object, DateTime>.get_Current
	|
	|-RVA: 0x32FB40 Offset: 0x32FC41 VA: 0x32FB40
	|-Dictionary.Enumerator<object, double>.get_Current
	|
	|-RVA: 0x32FCB0 Offset: 0x32FDB1 VA: 0x32FCB0
	|-Dictionary.Enumerator<object, short>.get_Current
	|
	|-RVA: 0x32FF90 Offset: 0x330091 VA: 0x32FF90
	|-Dictionary.Enumerator<object, Int32Enum>.get_Current
	|
	|-RVA: 0x330100 Offset: 0x330201 VA: 0x330100
	|-Dictionary.Enumerator<object, long>.get_Current
	|
	|-RVA: 0x330270 Offset: 0x330371 VA: 0x330270
	|-Dictionary.Enumerator<object, Memory<object>>.get_Current
	|
	|-RVA: 0x330400 Offset: 0x330501 VA: 0x330400
	|-Dictionary.Enumerator<object, Nullable<Int32Enum>>.get_Current
	|
	|-RVA: 0x330580 Offset: 0x330681 VA: 0x330580
	|-Dictionary.Enumerator<object, Nullable<Bounds>>.get_Current
	|
	|-RVA: 0x330720 Offset: 0x330821 VA: 0x330720
	|-Dictionary.Enumerator<object, Nullable<BoundsInt>>.get_Current
	|
	|-RVA: 0x3308B0 Offset: 0x3309B1 VA: 0x3308B0
	|-Dictionary.Enumerator<object, Nullable<Color32>>.get_Current
	|
	|-RVA: 0x330A20 Offset: 0x330B21 VA: 0x330A20
	|-Dictionary.Enumerator<object, Nullable<Color>>.get_Current
	|
	|-RVA: 0x330BB0 Offset: 0x330CB1 VA: 0x330BB0
	|-Dictionary.Enumerator<object, Nullable<GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x330D40 Offset: 0x330E41 VA: 0x330D40
	|-Dictionary.Enumerator<object, Nullable<GradientColorKey>>.get_Current
	|
	|-RVA: 0x330EE0 Offset: 0x330FE1 VA: 0x330EE0
	|-Dictionary.Enumerator<object, Nullable<Keyframe>>.get_Current
	|
	|-RVA: 0x331070 Offset: 0x331171 VA: 0x331070
	|-Dictionary.Enumerator<object, Nullable<LayerMask>>.get_Current
	|
	|-RVA: 0x3311F0 Offset: 0x3312F1 VA: 0x3311F0
	|-Dictionary.Enumerator<object, Nullable<Matrix4x4>>.get_Current
	|
	|-RVA: 0x3313A0 Offset: 0x3314A1 VA: 0x3313A0
	|-Dictionary.Enumerator<object, Nullable<Quaternion>>.get_Current
	|
	|-RVA: 0x33EE70 Offset: 0x33EF71 VA: 0x33EE70
	|-Dictionary.Enumerator<object, Nullable<RangeInt>>.get_Current
	|
	|-RVA: 0x33F000 Offset: 0x33F101 VA: 0x33F000
	|-Dictionary.Enumerator<object, Nullable<Rect>>.get_Current
	|
	|-RVA: 0x33F190 Offset: 0x33F291 VA: 0x33F190
	|-Dictionary.Enumerator<object, Nullable<RectInt>>.get_Current
	|
	|-RVA: 0x33F320 Offset: 0x33F421 VA: 0x33F320
	|-Dictionary.Enumerator<object, Nullable<Vector2>>.get_Current
	|
	|-RVA: 0x33F4B0 Offset: 0x33F5B1 VA: 0x33F4B0
	|-Dictionary.Enumerator<object, Nullable<Vector2Int>>.get_Current
	|
	|-RVA: 0x33F640 Offset: 0x33F741 VA: 0x33F640
	|-Dictionary.Enumerator<object, Nullable<Vector3>>.get_Current
	|
	|-RVA: 0x33F7D0 Offset: 0x33F8D1 VA: 0x33F7D0
	|-Dictionary.Enumerator<object, Nullable<Vector3Int>>.get_Current
	|
	|-RVA: 0x33F960 Offset: 0x33FA61 VA: 0x33F960
	|-Dictionary.Enumerator<object, Nullable<Vector4>>.get_Current
	|
	|-RVA: 0x33FC60 Offset: 0x33FD61 VA: 0x33FC60
	|-Dictionary.Enumerator<object, ReadOnlyMemory<object>>.get_Current
	|
	|-RVA: 0x33FDF0 Offset: 0x33FEF1 VA: 0x33FDF0
	|-Dictionary.Enumerator<object, ResourceLocator>.get_Current
	|
	|-RVA: 0x33FF80 Offset: 0x340081 VA: 0x33FF80
	|-Dictionary.Enumerator<object, sbyte>.get_Current
	|
	|-RVA: 0x3400F0 Offset: 0x3401F1 VA: 0x3400F0
	|-Dictionary.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x340260 Offset: 0x340361 VA: 0x340260
	|-Dictionary.Enumerator<object, ushort>.get_Current
	|
	|-RVA: 0x3403D0 Offset: 0x3404D1 VA: 0x3403D0
	|-Dictionary.Enumerator<object, uint>.get_Current
	|
	|-RVA: 0x340540 Offset: 0x340641 VA: 0x340540
	|-Dictionary.Enumerator<object, ulong>.get_Current
	|
	|-RVA: 0x3406C0 Offset: 0x3407C1 VA: 0x3406C0
	|-Dictionary.Enumerator<object, TransitionTables>.get_Current
	|
	|-RVA: 0x340850 Offset: 0x340951 VA: 0x340850
	|-Dictionary.Enumerator<object, Bounds>.get_Current
	|
	|-RVA: 0x3409E0 Offset: 0x340AE1 VA: 0x3409E0
	|-Dictionary.Enumerator<object, BoundsInt>.get_Current
	|
	|-RVA: 0x340B70 Offset: 0x340C71 VA: 0x340B70
	|-Dictionary.Enumerator<object, Color32>.get_Current
	|
	|-RVA: 0x340CE0 Offset: 0x340DE1 VA: 0x340CE0
	|-Dictionary.Enumerator<object, Color>.get_Current
	|
	|-RVA: 0x340E70 Offset: 0x340F71 VA: 0x340E70
	|-Dictionary.Enumerator<object, GradientAlphaKey>.get_Current
	|
	|-RVA: 0x340FE0 Offset: 0x3410E1 VA: 0x340FE0
	|-Dictionary.Enumerator<object, GradientColorKey>.get_Current
	|
	|-RVA: 0x341180 Offset: 0x341281 VA: 0x341180
	|-Dictionary.Enumerator<object, Keyframe>.get_Current
	|
	|-RVA: 0x341310 Offset: 0x341411 VA: 0x341310
	|-Dictionary.Enumerator<object, LayerMask>.get_Current
	|
	|-RVA: 0x341490 Offset: 0x341591 VA: 0x341490
	|-Dictionary.Enumerator<object, Matrix4x4>.get_Current
	|
	|-RVA: 0x341640 Offset: 0x341741 VA: 0x341640
	|-Dictionary.Enumerator<object, Playable>.get_Current
	|
	|-RVA: 0x3417D0 Offset: 0x3418D1 VA: 0x3417D0
	|-Dictionary.Enumerator<object, Quaternion>.get_Current
	|
	|-RVA: 0x341960 Offset: 0x341A61 VA: 0x341960
	|-Dictionary.Enumerator<object, RangeInt>.get_Current
	|
	|-RVA: 0x341AD0 Offset: 0x341BD1 VA: 0x341AD0
	|-Dictionary.Enumerator<object, Rect>.get_Current
	|
	|-RVA: 0x341C60 Offset: 0x341D61 VA: 0x341C60
	|-Dictionary.Enumerator<object, RectInt>.get_Current
	|
	|-RVA: 0x341DF0 Offset: 0x341EF1 VA: 0x341DF0
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x341F80 Offset: 0x342081 VA: 0x341F80
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x342110 Offset: 0x342211 VA: 0x342110
	|-Dictionary.Enumerator<object, Vector2>.get_Current
	|
	|-RVA: 0x342280 Offset: 0x342381 VA: 0x342280
	|-Dictionary.Enumerator<object, Vector2Int>.get_Current
	|
	|-RVA: 0x3423F0 Offset: 0x3424F1 VA: 0x3423F0
	|-Dictionary.Enumerator<object, Vector3>.get_Current
	|
	|-RVA: 0x342580 Offset: 0x342681 VA: 0x342580
	|-Dictionary.Enumerator<object, Vector3Int>.get_Current
	|
	|-RVA: 0x342710 Offset: 0x342811 VA: 0x342710
	|-Dictionary.Enumerator<object, Vector4>.get_Current
	|
	|-RVA: 0x3428A0 Offset: 0x3429A1 VA: 0x3428A0
	|-Dictionary.Enumerator<ReadOnlyMemory<object>, object>.get_Current
	|
	|-RVA: 0x335070 Offset: 0x335171 VA: 0x335070
	|-Dictionary.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x3351E0 Offset: 0x3352E1 VA: 0x3351E0
	|-Dictionary.Enumerator<sbyte, object>.get_Current
	|
	|-RVA: 0x335360 Offset: 0x335461 VA: 0x335360
	|-Dictionary.Enumerator<float, CurveSample>.get_Current
	|
	|-RVA: 0x335520 Offset: 0x335621 VA: 0x335520
	|-Dictionary.Enumerator<float, object>.get_Current
	|
	|-RVA: 0x335690 Offset: 0x335791 VA: 0x335690
	|-Dictionary.Enumerator<ushort, object>.get_Current
	|
	|-RVA: 0x335800 Offset: 0x335901 VA: 0x335800
	|-Dictionary.Enumerator<uint, int>.get_Current
	|
	|-RVA: 0x335960 Offset: 0x335A61 VA: 0x335960
	|-Dictionary.Enumerator<uint, Int32Enum>.get_Current
	|
	|-RVA: 0x335C30 Offset: 0x335D31 VA: 0x335C30
	|-Dictionary.Enumerator<ulong, object>.get_Current
	|
	|-RVA: 0x335DA0 Offset: 0x335EA1 VA: 0x335DA0
	|-Dictionary.Enumerator<EdgeKeyByHash, int>.get_Current
	|
	|-RVA: 0x335F20 Offset: 0x336021 VA: 0x335F20
	|-Dictionary.Enumerator<EdgeKeyByHash, CapEdge>.get_Current
	|
	|-RVA: 0x3360D0 Offset: 0x3361D1 VA: 0x3360D0
	|-Dictionary.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Current
	|
	|-RVA: 0x336280 Offset: 0x336381 VA: 0x336280
	|-Dictionary.Enumerator<EdgeKeyByIndex, ClippedEdge>.get_Current
	|
	|-RVA: 0x3366F0 Offset: 0x3367F1 VA: 0x3366F0
	|-Dictionary.Enumerator<Bounds, object>.get_Current
	|
	|-RVA: 0x336880 Offset: 0x336981 VA: 0x336880
	|-Dictionary.Enumerator<BoundsInt, object>.get_Current
	|
	|-RVA: 0x336A10 Offset: 0x336B11 VA: 0x336A10
	|-Dictionary.Enumerator<Color, object>.get_Current
	|
	|-RVA: 0x336BA0 Offset: 0x336CA1 VA: 0x336BA0
	|-Dictionary.Enumerator<Color32, object>.get_Current
	|
	|-RVA: 0x336E80 Offset: 0x336F81 VA: 0x336E80
	|-Dictionary.Enumerator<GradientAlphaKey, object>.get_Current
	|
	|-RVA: 0x336FF0 Offset: 0x3370F1 VA: 0x336FF0
	|-Dictionary.Enumerator<GradientColorKey, object>.get_Current
	|
	|-RVA: 0x337190 Offset: 0x337291 VA: 0x337190
	|-Dictionary.Enumerator<Keyframe, object>.get_Current
	|
	|-RVA: 0x337320 Offset: 0x337421 VA: 0x337320
	|-Dictionary.Enumerator<LayerMask, object>.get_Current
	|
	|-RVA: 0x3374A0 Offset: 0x3375A1 VA: 0x3374A0
	|-Dictionary.Enumerator<Matrix4x4, object>.get_Current
	|
	|-RVA: 0x3377E0 Offset: 0x3378E1 VA: 0x3377E0
	|-Dictionary.Enumerator<Quaternion, object>.get_Current
	|
	|-RVA: 0x337970 Offset: 0x337A71 VA: 0x337970
	|-Dictionary.Enumerator<RangeInt, object>.get_Current
	|
	|-RVA: 0x337AE0 Offset: 0x337BE1 VA: 0x337AE0
	|-Dictionary.Enumerator<Rect, object>.get_Current
	|
	|-RVA: 0x337C70 Offset: 0x337D71 VA: 0x337C70
	|-Dictionary.Enumerator<RectInt, object>.get_Current
	|
	|-RVA: 0x337E00 Offset: 0x337F01 VA: 0x337E00
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, int>.get_Current
	|
	|-RVA: 0x337F70 Offset: 0x338071 VA: 0x337F70
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.get_Current
	|
	|-RVA: 0x3380E0 Offset: 0x3381E1 VA: 0x3380E0
	|-Dictionary.Enumerator<Vector2, object>.get_Current
	|
	|-RVA: 0x338250 Offset: 0x338351 VA: 0x338250
	|-Dictionary.Enumerator<Vector2Int, object>.get_Current
	|
	|-RVA: 0x338550 Offset: 0x338651 VA: 0x338550
	|-Dictionary.Enumerator<Vector3Int, object>.get_Current
	|
	|-RVA: 0x3386E0 Offset: 0x3387E1 VA: 0x3386E0
	|-Dictionary.Enumerator<Vector4, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302A00 Offset: 0x302B01 VA: 0x302A00
	|-Dictionary.Enumerator<JSONDeserialization.TaskField, object>.Dispose
	|
	|-RVA: 0x33FB00 Offset: 0x33FC01 VA: 0x33FB00
	|-Dictionary.Enumerator<SharedVariable, object>.Dispose
	|-Dictionary.Enumerator<CharacterBase, DamageTextController>.Dispose
	|-Dictionary.Enumerator<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.Dispose
	|-Dictionary.Enumerator<OptionDefinition, OptionsControlBase>.Dispose
	|-Dictionary.Enumerator<byte[], Encoding>.Dispose
	|-Dictionary.Enumerator<int[], SceneSplit>.Dispose
	|-Dictionary.Enumerator<int[], Terrain>.Dispose
	|-Dictionary.Enumerator<object, object>.Dispose
	|-Dictionary.Enumerator<string, BehaviorManager.TaskAddData.OverrideFieldValue>.Dispose
	|-Dictionary.Enumerator<string, Texture[]>.Dispose
	|-Dictionary.Enumerator<string, InfoBlock>.Dispose
	|-Dictionary.Enumerator<string, SeasonTextureData>.Dispose
	|-Dictionary.Enumerator<string, IList<InfoEntry>>.Dispose
	|-Dictionary.Enumerator<string, List<TaskCoroutine>>.Dispose
	|-Dictionary.Enumerator<string, List<OptionDefinition>>.Dispose
	|-Dictionary.Enumerator<string, object>.Dispose
	|-Dictionary.Enumerator<string, string>.Dispose
	|-Dictionary.Enumerator<string, ResourceLocationBase>.Dispose
	|-Dictionary.Enumerator<TimeParamTable, HashSet<ObjectChangeTime>>.Dispose
	|-Dictionary.Enumerator<TimeParamTable, HashSet<RendererChangeTime>>.Dispose
	|-Dictionary.Enumerator<TimeParamTable, HashSet<Material>>.Dispose
	|-Dictionary.Enumerator<Camera, Camera>.Dispose
	|-Dictionary.Enumerator<Collider, CharacterNearCullingController>.Dispose
	|-Dictionary.Enumerator<GameObject, Material[]>.Dispose
	|-Dictionary.Enumerator<GameObject, Renderer[]>.Dispose
	|-Dictionary.Enumerator<Transform, List<SpringBone>>.Dispose
	|
	|-RVA: 0x302B80 Offset: 0x302C81 VA: 0x302B80
	|-Dictionary.Enumerator<BitVector32Int, object>.Dispose
	|
	|-RVA: 0x3331F0 Offset: 0x3332F1 VA: 0x3331F0
	|-Dictionary.Enumerator<BadStatus, BadStatusEffectController.ObjInfo>.Dispose
	|-Dictionary.Enumerator<VariationNo, HumanData>.Dispose
	|-Dictionary.Enumerator<EnvironmentSoundType, List<EnvironmentSoundDataTable>>.Dispose
	|-Dictionary.Enumerator<EquipSlotType, AS_ToolController.ToolActionData>.Dispose
	|-Dictionary.Enumerator<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.Dispose
	|-Dictionary.Enumerator<SoundID, EnvironmentSoundDataTable>.Dispose
	|-Dictionary.Enumerator<SoundID, EnvironmentSoundController>.Dispose
	|-Dictionary.Enumerator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x333090 Offset: 0x333191 VA: 0x333090
	|-Dictionary.Enumerator<EmotionType, Prefab>.Dispose
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x302D00 Offset: 0x302E01 VA: 0x302D00
	|-Dictionary.Enumerator<EventCheckId, object>.Dispose
	|
	|-RVA: 0x302EB0 Offset: 0x302FB1 VA: 0x302EB0
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE, object>.Dispose
	|
	|-RVA: 0x303050 Offset: 0x303151 VA: 0x303050
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.Dispose
	|
	|-RVA: 0x3031E0 Offset: 0x3032E1 VA: 0x3031E0
	|-Dictionary.Enumerator<FarmManager.RF4_MCROP_INFO, object>.Dispose
	|
	|-RVA: 0x303370 Offset: 0x303471 VA: 0x303370
	|-Dictionary.Enumerator<FarmManager.RF4_SOIL_INFO, object>.Dispose
	|
	|-RVA: 0x32FE30 Offset: 0x32FF31 VA: 0x32FE30
	|-Dictionary.Enumerator<MonsterControllerBase, int>.Dispose
	|-Dictionary.Enumerator<object, int>.Dispose
	|
	|-RVA: 0x303510 Offset: 0x303611 VA: 0x303510
	|-Dictionary.Enumerator<MonsterHutSaveData, object>.Dispose
	|
	|-RVA: 0x3036A0 Offset: 0x3037A1 VA: 0x3036A0
	|-Dictionary.Enumerator<OrderLotterySaveParameter, object>.Dispose
	|
	|-RVA: 0x303840 Offset: 0x303941 VA: 0x303840
	|-Dictionary.Enumerator<OrderSaveData, object>.Dispose
	|
	|-RVA: 0x3039E0 Offset: 0x303AE1 VA: 0x3039E0
	|-Dictionary.Enumerator<OrderSaveParameter, object>.Dispose
	|
	|-RVA: 0x303B90 Offset: 0x303C91 VA: 0x303B90
	|-Dictionary.Enumerator<Parameter, object>.Dispose
	|
	|-RVA: 0x3334D0 Offset: 0x3335D1 VA: 0x3334D0
	|-Dictionary.Enumerator<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>.Dispose
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x303D60 Offset: 0x303E61 VA: 0x303D60
	|-Dictionary.Enumerator<bool, object>.Dispose
	|
	|-RVA: 0x303ED0 Offset: 0x303FD1 VA: 0x303ED0
	|-Dictionary.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x304040 Offset: 0x304141 VA: 0x304040
	|-Dictionary.Enumerator<char, object>.Dispose
	|
	|-RVA: 0x3041B0 Offset: 0x3042B1 VA: 0x3041B0
	|-Dictionary.Enumerator<DateTime, object>.Dispose
	|
	|-RVA: 0x304320 Offset: 0x304421 VA: 0x304320
	|-Dictionary.Enumerator<double, object>.Dispose
	|
	|-RVA: 0x3044A0 Offset: 0x3045A1 VA: 0x3044A0
	|-Dictionary.Enumerator<Guid, object>.Dispose
	|
	|-RVA: 0x304620 Offset: 0x304721 VA: 0x304620
	|-Dictionary.Enumerator<short, object>.Dispose
	|
	|-RVA: 0x331F80 Offset: 0x332081 VA: 0x331F80
	|-Dictionary.Enumerator<int, BossBehaviorController>.Dispose
	|-Dictionary.Enumerator<int, FishSwim>.Dispose
	|-Dictionary.Enumerator<int, HarinezumiController.NeedleController>.Dispose
	|-Dictionary.Enumerator<int, MonsterBehaviorController>.Dispose
	|-Dictionary.Enumerator<int, PartnerNPCBehaviorController>.Dispose
	|-Dictionary.Enumerator<int, List<MeshDataConnectivity.Face>>.Dispose
	|-Dictionary.Enumerator<int, object>.Dispose
	|-Dictionary.Enumerator<int, string>.Dispose
	|-Dictionary.Enumerator<int, PointerEventData>.Dispose
	|-Dictionary.Enumerator<int, TerrainUtility.TerrainMap>.Dispose
	|
	|-RVA: 0x3047D0 Offset: 0x3048D1 VA: 0x3047D0
	|-Dictionary.Enumerator<int, CropDataTable>.Dispose
	|
	|-RVA: 0x3049D0 Offset: 0x304AD1 VA: 0x3049D0
	|-Dictionary.Enumerator<int, EffectDataTable>.Dispose
	|
	|-RVA: 0x304B50 Offset: 0x304C51 VA: 0x304B50
	|-Dictionary.Enumerator<int, GimmickLayoutDataTable>.Dispose
	|
	|-RVA: 0x331570 Offset: 0x331671 VA: 0x331570
	|-Dictionary.Enumerator<int, MineTypeDataTable>.Dispose
	|
	|-RVA: 0x331710 Offset: 0x331811 VA: 0x331710
	|-Dictionary.Enumerator<int, MiningDataTable>.Dispose
	|
	|-RVA: 0x331890 Offset: 0x331991 VA: 0x331890
	|-Dictionary.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x3319F0 Offset: 0x331AF1 VA: 0x3319F0
	|-Dictionary.Enumerator<int, char>.Dispose
	|
	|-RVA: 0x331B50 Offset: 0x331C51 VA: 0x331B50
	|-Dictionary.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x331CB0 Offset: 0x331DB1 VA: 0x331CB0
	|-Dictionary.Enumerator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x331E10 Offset: 0x331F11 VA: 0x331E10
	|-Dictionary.Enumerator<int, long>.Dispose
	|
	|-RVA: 0x332120 Offset: 0x332221 VA: 0x332120
	|-Dictionary.Enumerator<int, DiagnosticEvent>.Dispose
	|
	|-RVA: 0x3322C0 Offset: 0x3323C1 VA: 0x3322C0
	|-Dictionary.Enumerator<int, SceneInstance>.Dispose
	|
	|-RVA: 0x332440 Offset: 0x332541 VA: 0x332440
	|-Dictionary.Enumerator<int, Vector2Int>.Dispose
	|
	|-RVA: 0x3325B0 Offset: 0x3326B1 VA: 0x3325B0
	|-Dictionary.Enumerator<int, Vector3>.Dispose
	|
	|-RVA: 0x332750 Offset: 0x332851 VA: 0x332750
	|-Dictionary.Enumerator<Int32Enum, MonsterDataTable>.Dispose
	|
	|-RVA: 0x332950 Offset: 0x332A51 VA: 0x332950
	|-Dictionary.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.Dispose
	|
	|-RVA: 0x332AF0 Offset: 0x332BF1 VA: 0x332AF0
	|-Dictionary.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.Dispose
	|
	|-RVA: 0x332C60 Offset: 0x332D61 VA: 0x332C60
	|-Dictionary.Enumerator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x332DC0 Offset: 0x332EC1 VA: 0x332DC0
	|-Dictionary.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x332F30 Offset: 0x333031 VA: 0x332F30
	|-Dictionary.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x333360 Offset: 0x333461 VA: 0x333360
	|-Dictionary.Enumerator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x333650 Offset: 0x333751 VA: 0x333650
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<float, float>>.Dispose
	|
	|-RVA: 0x3337C0 Offset: 0x3338C1 VA: 0x3337C0
	|-Dictionary.Enumerator<Int32Enum, TutorialUnlockFlagData>.Dispose
	|
	|-RVA: 0x333930 Offset: 0x333A31 VA: 0x333930
	|-Dictionary.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x333AB0 Offset: 0x333BB1 VA: 0x333AB0
	|-Dictionary.Enumerator<Memory<object>, object>.Dispose
	|
	|-RVA: 0x333C30 Offset: 0x333D31 VA: 0x333C30
	|-Dictionary.Enumerator<Nullable<Int32Enum>, object>.Dispose
	|
	|-RVA: 0x333DC0 Offset: 0x333EC1 VA: 0x333DC0
	|-Dictionary.Enumerator<Nullable<Bounds>, object>.Dispose
	|
	|-RVA: 0x333F60 Offset: 0x334061 VA: 0x333F60
	|-Dictionary.Enumerator<Nullable<BoundsInt>, object>.Dispose
	|
	|-RVA: 0x3340E0 Offset: 0x3341E1 VA: 0x3340E0
	|-Dictionary.Enumerator<Nullable<Color32>, object>.Dispose
	|
	|-RVA: 0x334260 Offset: 0x334361 VA: 0x334260
	|-Dictionary.Enumerator<Nullable<Color>, object>.Dispose
	|
	|-RVA: 0x3343F0 Offset: 0x3344F1 VA: 0x3343F0
	|-Dictionary.Enumerator<Nullable<GradientAlphaKey>, object>.Dispose
	|
	|-RVA: 0x334580 Offset: 0x334681 VA: 0x334580
	|-Dictionary.Enumerator<Nullable<GradientColorKey>, object>.Dispose
	|
	|-RVA: 0x334720 Offset: 0x334821 VA: 0x334720
	|-Dictionary.Enumerator<Nullable<Keyframe>, object>.Dispose
	|
	|-RVA: 0x3348A0 Offset: 0x3349A1 VA: 0x3348A0
	|-Dictionary.Enumerator<Nullable<LayerMask>, object>.Dispose
	|
	|-RVA: 0x334A40 Offset: 0x334B41 VA: 0x334A40
	|-Dictionary.Enumerator<Nullable<Matrix4x4>, object>.Dispose
	|
	|-RVA: 0x334BE0 Offset: 0x334CE1 VA: 0x334BE0
	|-Dictionary.Enumerator<Nullable<Quaternion>, object>.Dispose
	|
	|-RVA: 0x334D70 Offset: 0x334E71 VA: 0x334D70
	|-Dictionary.Enumerator<Nullable<RangeInt>, object>.Dispose
	|
	|-RVA: 0x334F00 Offset: 0x335001 VA: 0x334F00
	|-Dictionary.Enumerator<Nullable<Rect>, object>.Dispose
	|
	|-RVA: 0x32D8D0 Offset: 0x32D9D1 VA: 0x32D8D0
	|-Dictionary.Enumerator<Nullable<RectInt>, object>.Dispose
	|
	|-RVA: 0x32DA60 Offset: 0x32DB61 VA: 0x32DA60
	|-Dictionary.Enumerator<Nullable<Vector2>, object>.Dispose
	|
	|-RVA: 0x32DBF0 Offset: 0x32DCF1 VA: 0x32DBF0
	|-Dictionary.Enumerator<Nullable<Vector2Int>, object>.Dispose
	|
	|-RVA: 0x32DD80 Offset: 0x32DE81 VA: 0x32DD80
	|-Dictionary.Enumerator<Nullable<Vector3>, object>.Dispose
	|
	|-RVA: 0x32DF10 Offset: 0x32E011 VA: 0x32DF10
	|-Dictionary.Enumerator<Nullable<Vector3Int>, object>.Dispose
	|
	|-RVA: 0x32E0A0 Offset: 0x32E1A1 VA: 0x32E0A0
	|-Dictionary.Enumerator<Nullable<Vector4>, object>.Dispose
	|
	|-RVA: 0x32E220 Offset: 0x32E321 VA: 0x32E220
	|-Dictionary.Enumerator<object, BitVector32Int>.Dispose
	|
	|-RVA: 0x32E3A0 Offset: 0x32E4A1 VA: 0x32E3A0
	|-Dictionary.Enumerator<object, EventCheckId>.Dispose
	|
	|-RVA: 0x32E550 Offset: 0x32E651 VA: 0x32E550
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE>.Dispose
	|
	|-RVA: 0x32E6F0 Offset: 0x32E7F1 VA: 0x32E6F0
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.Dispose
	|
	|-RVA: 0x32E880 Offset: 0x32E981 VA: 0x32E880
	|-Dictionary.Enumerator<object, FarmManager.RF4_MCROP_INFO>.Dispose
	|
	|-RVA: 0x32EA10 Offset: 0x32EB11 VA: 0x32EA10
	|-Dictionary.Enumerator<object, FarmManager.RF4_SOIL_INFO>.Dispose
	|
	|-RVA: 0x32EBB0 Offset: 0x32ECB1 VA: 0x32EBB0
	|-Dictionary.Enumerator<object, MonsterHutSaveData>.Dispose
	|
	|-RVA: 0x32ED40 Offset: 0x32EE41 VA: 0x32ED40
	|-Dictionary.Enumerator<object, OrderLotterySaveParameter>.Dispose
	|
	|-RVA: 0x32EEE0 Offset: 0x32EFE1 VA: 0x32EEE0
	|-Dictionary.Enumerator<object, OrderSaveData>.Dispose
	|
	|-RVA: 0x32F080 Offset: 0x32F181 VA: 0x32F080
	|-Dictionary.Enumerator<object, OrderSaveParameter>.Dispose
	|
	|-RVA: 0x32F230 Offset: 0x32F331 VA: 0x32F230
	|-Dictionary.Enumerator<object, Parameter>.Dispose
	|
	|-RVA: 0x32F410 Offset: 0x32F511 VA: 0x32F410
	|-Dictionary.Enumerator<object, NumberControl.ValueRange>.Dispose
	|
	|-RVA: 0x32F590 Offset: 0x32F691 VA: 0x32F590
	|-Dictionary.Enumerator<object, bool>.Dispose
	|
	|-RVA: 0x32F700 Offset: 0x32F801 VA: 0x32F700
	|-Dictionary.Enumerator<object, byte>.Dispose
	|
	|-RVA: 0x32F870 Offset: 0x32F971 VA: 0x32F870
	|-Dictionary.Enumerator<object, char>.Dispose
	|
	|-RVA: 0x32F9E0 Offset: 0x32FAE1 VA: 0x32F9E0
	|-Dictionary.Enumerator<object, DateTime>.Dispose
	|
	|-RVA: 0x32FB50 Offset: 0x32FC51 VA: 0x32FB50
	|-Dictionary.Enumerator<object, double>.Dispose
	|
	|-RVA: 0x32FCC0 Offset: 0x32FDC1 VA: 0x32FCC0
	|-Dictionary.Enumerator<object, short>.Dispose
	|
	|-RVA: 0x32FFA0 Offset: 0x3300A1 VA: 0x32FFA0
	|-Dictionary.Enumerator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x330110 Offset: 0x330211 VA: 0x330110
	|-Dictionary.Enumerator<object, long>.Dispose
	|
	|-RVA: 0x330290 Offset: 0x330391 VA: 0x330290
	|-Dictionary.Enumerator<object, Memory<object>>.Dispose
	|
	|-RVA: 0x330410 Offset: 0x330511 VA: 0x330410
	|-Dictionary.Enumerator<object, Nullable<Int32Enum>>.Dispose
	|
	|-RVA: 0x3305A0 Offset: 0x3306A1 VA: 0x3305A0
	|-Dictionary.Enumerator<object, Nullable<Bounds>>.Dispose
	|
	|-RVA: 0x330740 Offset: 0x330841 VA: 0x330740
	|-Dictionary.Enumerator<object, Nullable<BoundsInt>>.Dispose
	|
	|-RVA: 0x3308C0 Offset: 0x3309C1 VA: 0x3308C0
	|-Dictionary.Enumerator<object, Nullable<Color32>>.Dispose
	|
	|-RVA: 0x330A40 Offset: 0x330B41 VA: 0x330A40
	|-Dictionary.Enumerator<object, Nullable<Color>>.Dispose
	|
	|-RVA: 0x330BD0 Offset: 0x330CD1 VA: 0x330BD0
	|-Dictionary.Enumerator<object, Nullable<GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x330D60 Offset: 0x330E61 VA: 0x330D60
	|-Dictionary.Enumerator<object, Nullable<GradientColorKey>>.Dispose
	|
	|-RVA: 0x330F00 Offset: 0x331001 VA: 0x330F00
	|-Dictionary.Enumerator<object, Nullable<Keyframe>>.Dispose
	|
	|-RVA: 0x331080 Offset: 0x331181 VA: 0x331080
	|-Dictionary.Enumerator<object, Nullable<LayerMask>>.Dispose
	|
	|-RVA: 0x331220 Offset: 0x331321 VA: 0x331220
	|-Dictionary.Enumerator<object, Nullable<Matrix4x4>>.Dispose
	|
	|-RVA: 0x3313C0 Offset: 0x3314C1 VA: 0x3313C0
	|-Dictionary.Enumerator<object, Nullable<Quaternion>>.Dispose
	|
	|-RVA: 0x33EE90 Offset: 0x33EF91 VA: 0x33EE90
	|-Dictionary.Enumerator<object, Nullable<RangeInt>>.Dispose
	|
	|-RVA: 0x33F020 Offset: 0x33F121 VA: 0x33F020
	|-Dictionary.Enumerator<object, Nullable<Rect>>.Dispose
	|
	|-RVA: 0x33F1B0 Offset: 0x33F2B1 VA: 0x33F1B0
	|-Dictionary.Enumerator<object, Nullable<RectInt>>.Dispose
	|
	|-RVA: 0x33F340 Offset: 0x33F441 VA: 0x33F340
	|-Dictionary.Enumerator<object, Nullable<Vector2>>.Dispose
	|
	|-RVA: 0x33F4D0 Offset: 0x33F5D1 VA: 0x33F4D0
	|-Dictionary.Enumerator<object, Nullable<Vector2Int>>.Dispose
	|
	|-RVA: 0x33F660 Offset: 0x33F761 VA: 0x33F660
	|-Dictionary.Enumerator<object, Nullable<Vector3>>.Dispose
	|
	|-RVA: 0x33F7F0 Offset: 0x33F8F1 VA: 0x33F7F0
	|-Dictionary.Enumerator<object, Nullable<Vector3Int>>.Dispose
	|
	|-RVA: 0x33F980 Offset: 0x33FA81 VA: 0x33F980
	|-Dictionary.Enumerator<object, Nullable<Vector4>>.Dispose
	|
	|-RVA: 0x33FC80 Offset: 0x33FD81 VA: 0x33FC80
	|-Dictionary.Enumerator<object, ReadOnlyMemory<object>>.Dispose
	|
	|-RVA: 0x33FE10 Offset: 0x33FF11 VA: 0x33FE10
	|-Dictionary.Enumerator<object, ResourceLocator>.Dispose
	|
	|-RVA: 0x33FF90 Offset: 0x340091 VA: 0x33FF90
	|-Dictionary.Enumerator<object, sbyte>.Dispose
	|
	|-RVA: 0x340100 Offset: 0x340201 VA: 0x340100
	|-Dictionary.Enumerator<object, float>.Dispose
	|
	|-RVA: 0x340270 Offset: 0x340371 VA: 0x340270
	|-Dictionary.Enumerator<object, ushort>.Dispose
	|
	|-RVA: 0x3403E0 Offset: 0x3404E1 VA: 0x3403E0
	|-Dictionary.Enumerator<object, uint>.Dispose
	|
	|-RVA: 0x340550 Offset: 0x340651 VA: 0x340550
	|-Dictionary.Enumerator<object, ulong>.Dispose
	|
	|-RVA: 0x3406E0 Offset: 0x3407E1 VA: 0x3406E0
	|-Dictionary.Enumerator<object, TransitionTables>.Dispose
	|
	|-RVA: 0x340870 Offset: 0x340971 VA: 0x340870
	|-Dictionary.Enumerator<object, Bounds>.Dispose
	|
	|-RVA: 0x340A00 Offset: 0x340B01 VA: 0x340A00
	|-Dictionary.Enumerator<object, BoundsInt>.Dispose
	|
	|-RVA: 0x340B80 Offset: 0x340C81 VA: 0x340B80
	|-Dictionary.Enumerator<object, Color32>.Dispose
	|
	|-RVA: 0x340D00 Offset: 0x340E01 VA: 0x340D00
	|-Dictionary.Enumerator<object, Color>.Dispose
	|
	|-RVA: 0x340E80 Offset: 0x340F81 VA: 0x340E80
	|-Dictionary.Enumerator<object, GradientAlphaKey>.Dispose
	|
	|-RVA: 0x341000 Offset: 0x341101 VA: 0x341000
	|-Dictionary.Enumerator<object, GradientColorKey>.Dispose
	|
	|-RVA: 0x3411A0 Offset: 0x3412A1 VA: 0x3411A0
	|-Dictionary.Enumerator<object, Keyframe>.Dispose
	|
	|-RVA: 0x341320 Offset: 0x341421 VA: 0x341320
	|-Dictionary.Enumerator<object, LayerMask>.Dispose
	|
	|-RVA: 0x3414C0 Offset: 0x3415C1 VA: 0x3414C0
	|-Dictionary.Enumerator<object, Matrix4x4>.Dispose
	|
	|-RVA: 0x341660 Offset: 0x341761 VA: 0x341660
	|-Dictionary.Enumerator<object, Playable>.Dispose
	|
	|-RVA: 0x3417F0 Offset: 0x3418F1 VA: 0x3417F0
	|-Dictionary.Enumerator<object, Quaternion>.Dispose
	|
	|-RVA: 0x341970 Offset: 0x341A71 VA: 0x341970
	|-Dictionary.Enumerator<object, RangeInt>.Dispose
	|
	|-RVA: 0x341AF0 Offset: 0x341BF1 VA: 0x341AF0
	|-Dictionary.Enumerator<object, Rect>.Dispose
	|
	|-RVA: 0x341C80 Offset: 0x341D81 VA: 0x341C80
	|-Dictionary.Enumerator<object, RectInt>.Dispose
	|
	|-RVA: 0x341E10 Offset: 0x341F11 VA: 0x341E10
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x341FA0 Offset: 0x3420A1 VA: 0x341FA0
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x342120 Offset: 0x342221 VA: 0x342120
	|-Dictionary.Enumerator<object, Vector2>.Dispose
	|
	|-RVA: 0x342290 Offset: 0x342391 VA: 0x342290
	|-Dictionary.Enumerator<object, Vector2Int>.Dispose
	|
	|-RVA: 0x342410 Offset: 0x342511 VA: 0x342410
	|-Dictionary.Enumerator<object, Vector3>.Dispose
	|
	|-RVA: 0x3425A0 Offset: 0x3426A1 VA: 0x3425A0
	|-Dictionary.Enumerator<object, Vector3Int>.Dispose
	|
	|-RVA: 0x342730 Offset: 0x342831 VA: 0x342730
	|-Dictionary.Enumerator<object, Vector4>.Dispose
	|
	|-RVA: 0x3428C0 Offset: 0x3429C1 VA: 0x3428C0
	|-Dictionary.Enumerator<ReadOnlyMemory<object>, object>.Dispose
	|
	|-RVA: 0x335080 Offset: 0x335181 VA: 0x335080
	|-Dictionary.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.Dispose
	|
	|-RVA: 0x3351F0 Offset: 0x3352F1 VA: 0x3351F0
	|-Dictionary.Enumerator<sbyte, object>.Dispose
	|
	|-RVA: 0x3353A0 Offset: 0x3354A1 VA: 0x3353A0
	|-Dictionary.Enumerator<float, CurveSample>.Dispose
	|
	|-RVA: 0x335530 Offset: 0x335631 VA: 0x335530
	|-Dictionary.Enumerator<float, object>.Dispose
	|
	|-RVA: 0x3356A0 Offset: 0x3357A1 VA: 0x3356A0
	|-Dictionary.Enumerator<ushort, object>.Dispose
	|
	|-RVA: 0x335AD0 Offset: 0x335BD1 VA: 0x335AD0
	|-Dictionary.Enumerator<uint, FarmMonsterBehaviorController>.Dispose
	|-Dictionary.Enumerator<uint, object>.Dispose
	|
	|-RVA: 0x335810 Offset: 0x335911 VA: 0x335810
	|-Dictionary.Enumerator<uint, int>.Dispose
	|
	|-RVA: 0x335970 Offset: 0x335A71 VA: 0x335970
	|-Dictionary.Enumerator<uint, Int32Enum>.Dispose
	|
	|-RVA: 0x335C40 Offset: 0x335D41 VA: 0x335C40
	|-Dictionary.Enumerator<ulong, object>.Dispose
	|
	|-RVA: 0x335DB0 Offset: 0x335EB1 VA: 0x335DB0
	|-Dictionary.Enumerator<EdgeKeyByHash, int>.Dispose
	|
	|-RVA: 0x335F50 Offset: 0x336051 VA: 0x335F50
	|-Dictionary.Enumerator<EdgeKeyByHash, CapEdge>.Dispose
	|
	|-RVA: 0x336100 Offset: 0x336201 VA: 0x336100
	|-Dictionary.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.Dispose
	|
	|-RVA: 0x3362A0 Offset: 0x3363A1 VA: 0x3362A0
	|-Dictionary.Enumerator<EdgeKeyByIndex, ClippedEdge>.Dispose
	|
	|-RVA: 0x336420 Offset: 0x336521 VA: 0x336420
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, bool>.Dispose
	|
	|-RVA: 0x336590 Offset: 0x336691 VA: 0x336590
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, List<int>>.Dispose
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, object>.Dispose
	|
	|-RVA: 0x336710 Offset: 0x336811 VA: 0x336710
	|-Dictionary.Enumerator<Bounds, object>.Dispose
	|
	|-RVA: 0x3368A0 Offset: 0x3369A1 VA: 0x3368A0
	|-Dictionary.Enumerator<BoundsInt, object>.Dispose
	|
	|-RVA: 0x336A30 Offset: 0x336B31 VA: 0x336A30
	|-Dictionary.Enumerator<Color, object>.Dispose
	|
	|-RVA: 0x336BB0 Offset: 0x336CB1 VA: 0x336BB0
	|-Dictionary.Enumerator<Color32, object>.Dispose
	|
	|-RVA: 0x336D20 Offset: 0x336E21 VA: 0x336D20
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.Dispose
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.Dispose
	|
	|-RVA: 0x336E90 Offset: 0x336F91 VA: 0x336E90
	|-Dictionary.Enumerator<GradientAlphaKey, object>.Dispose
	|
	|-RVA: 0x337010 Offset: 0x337111 VA: 0x337010
	|-Dictionary.Enumerator<GradientColorKey, object>.Dispose
	|
	|-RVA: 0x3371B0 Offset: 0x3372B1 VA: 0x3371B0
	|-Dictionary.Enumerator<Keyframe, object>.Dispose
	|
	|-RVA: 0x337330 Offset: 0x337431 VA: 0x337330
	|-Dictionary.Enumerator<LayerMask, object>.Dispose
	|
	|-RVA: 0x3374D0 Offset: 0x3375D1 VA: 0x3374D0
	|-Dictionary.Enumerator<Matrix4x4, object>.Dispose
	|
	|-RVA: 0x337670 Offset: 0x337771 VA: 0x337670
	|-Dictionary.Enumerator<IntVec3, List<int>>.Dispose
	|-Dictionary.Enumerator<IntVec3, object>.Dispose
	|
	|-RVA: 0x337800 Offset: 0x337901 VA: 0x337800
	|-Dictionary.Enumerator<Quaternion, object>.Dispose
	|
	|-RVA: 0x337980 Offset: 0x337A81 VA: 0x337980
	|-Dictionary.Enumerator<RangeInt, object>.Dispose
	|
	|-RVA: 0x337B00 Offset: 0x337C01 VA: 0x337B00
	|-Dictionary.Enumerator<Rect, object>.Dispose
	|
	|-RVA: 0x337C90 Offset: 0x337D91 VA: 0x337C90
	|-Dictionary.Enumerator<RectInt, object>.Dispose
	|
	|-RVA: 0x337E10 Offset: 0x337F11 VA: 0x337E10
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, int>.Dispose
	|
	|-RVA: 0x337F80 Offset: 0x338081 VA: 0x337F80
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.Dispose
	|
	|-RVA: 0x3380F0 Offset: 0x3381F1 VA: 0x3380F0
	|-Dictionary.Enumerator<Vector2, object>.Dispose
	|
	|-RVA: 0x338260 Offset: 0x338361 VA: 0x338260
	|-Dictionary.Enumerator<Vector2Int, object>.Dispose
	|
	|-RVA: 0x3383E0 Offset: 0x3384E1 VA: 0x3383E0
	|-Dictionary.Enumerator<Vector3, List<int>>.Dispose
	|-Dictionary.Enumerator<Vector3, object>.Dispose
	|
	|-RVA: 0x338570 Offset: 0x338671 VA: 0x338570
	|-Dictionary.Enumerator<Vector3Int, object>.Dispose
	|
	|-RVA: 0x338700 Offset: 0x338801 VA: 0x338700
	|-Dictionary.Enumerator<Vector4, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302A10 Offset: 0x302B11 VA: 0x302A10
	|-Dictionary.Enumerator<JSONDeserialization.TaskField, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x302B90 Offset: 0x302C91 VA: 0x302B90
	|-Dictionary.Enumerator<BitVector32Int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x302D10 Offset: 0x302E11 VA: 0x302D10
	|-Dictionary.Enumerator<EventCheckId, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x302EC0 Offset: 0x302FC1 VA: 0x302EC0
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x303060 Offset: 0x303161 VA: 0x303060
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3031F0 Offset: 0x3032F1 VA: 0x3031F0
	|-Dictionary.Enumerator<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x303380 Offset: 0x303481 VA: 0x303380
	|-Dictionary.Enumerator<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x303520 Offset: 0x303621 VA: 0x303520
	|-Dictionary.Enumerator<MonsterHutSaveData, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3036B0 Offset: 0x3037B1 VA: 0x3036B0
	|-Dictionary.Enumerator<OrderLotterySaveParameter, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x303850 Offset: 0x303951 VA: 0x303850
	|-Dictionary.Enumerator<OrderSaveData, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3039F0 Offset: 0x303AF1 VA: 0x3039F0
	|-Dictionary.Enumerator<OrderSaveParameter, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x303BA0 Offset: 0x303CA1 VA: 0x303BA0
	|-Dictionary.Enumerator<Parameter, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x303D70 Offset: 0x303E71 VA: 0x303D70
	|-Dictionary.Enumerator<bool, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x303EE0 Offset: 0x303FE1 VA: 0x303EE0
	|-Dictionary.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x304050 Offset: 0x304151 VA: 0x304050
	|-Dictionary.Enumerator<char, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3041C0 Offset: 0x3042C1 VA: 0x3041C0
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x304330 Offset: 0x304431 VA: 0x304330
	|-Dictionary.Enumerator<double, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3044B0 Offset: 0x3045B1 VA: 0x3044B0
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x304630 Offset: 0x304731 VA: 0x304630
	|-Dictionary.Enumerator<short, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3047E0 Offset: 0x3048E1 VA: 0x3047E0
	|-Dictionary.Enumerator<int, CropDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3049E0 Offset: 0x304AE1 VA: 0x3049E0
	|-Dictionary.Enumerator<int, EffectDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x304B60 Offset: 0x304C61 VA: 0x304B60
	|-Dictionary.Enumerator<int, GimmickLayoutDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x331580 Offset: 0x331681 VA: 0x331580
	|-Dictionary.Enumerator<int, MineTypeDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x331720 Offset: 0x331821 VA: 0x331720
	|-Dictionary.Enumerator<int, MiningDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3318A0 Offset: 0x3319A1 VA: 0x3318A0
	|-Dictionary.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x331A00 Offset: 0x331B01 VA: 0x331A00
	|-Dictionary.Enumerator<int, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x331B60 Offset: 0x331C61 VA: 0x331B60
	|-Dictionary.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x331CC0 Offset: 0x331DC1 VA: 0x331CC0
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x331E20 Offset: 0x331F21 VA: 0x331E20
	|-Dictionary.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x331F90 Offset: 0x332091 VA: 0x331F90
	|-Dictionary.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x332130 Offset: 0x332231 VA: 0x332130
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3322D0 Offset: 0x3323D1 VA: 0x3322D0
	|-Dictionary.Enumerator<int, SceneInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x332450 Offset: 0x332551 VA: 0x332450
	|-Dictionary.Enumerator<int, Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3325C0 Offset: 0x3326C1 VA: 0x3325C0
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x332760 Offset: 0x332861 VA: 0x332760
	|-Dictionary.Enumerator<Int32Enum, MonsterDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x332960 Offset: 0x332A61 VA: 0x332960
	|-Dictionary.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x332B00 Offset: 0x332C01 VA: 0x332B00
	|-Dictionary.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x332C70 Offset: 0x332D71 VA: 0x332C70
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x332DD0 Offset: 0x332ED1 VA: 0x332DD0
	|-Dictionary.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x332F40 Offset: 0x333041 VA: 0x332F40
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3330A0 Offset: 0x3331A1 VA: 0x3330A0
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x333200 Offset: 0x333301 VA: 0x333200
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x333370 Offset: 0x333471 VA: 0x333370
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3334E0 Offset: 0x3335E1 VA: 0x3334E0
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x333660 Offset: 0x333761 VA: 0x333660
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<float, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3337D0 Offset: 0x3338D1 VA: 0x3337D0
	|-Dictionary.Enumerator<Int32Enum, TutorialUnlockFlagData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x333940 Offset: 0x333A41 VA: 0x333940
	|-Dictionary.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x333AC0 Offset: 0x333BC1 VA: 0x333AC0
	|-Dictionary.Enumerator<Memory<object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x333C40 Offset: 0x333D41 VA: 0x333C40
	|-Dictionary.Enumerator<Nullable<Int32Enum>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x333DD0 Offset: 0x333ED1 VA: 0x333DD0
	|-Dictionary.Enumerator<Nullable<Bounds>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x333F70 Offset: 0x334071 VA: 0x333F70
	|-Dictionary.Enumerator<Nullable<BoundsInt>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3340F0 Offset: 0x3341F1 VA: 0x3340F0
	|-Dictionary.Enumerator<Nullable<Color32>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x334270 Offset: 0x334371 VA: 0x334270
	|-Dictionary.Enumerator<Nullable<Color>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x334400 Offset: 0x334501 VA: 0x334400
	|-Dictionary.Enumerator<Nullable<GradientAlphaKey>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x334590 Offset: 0x334691 VA: 0x334590
	|-Dictionary.Enumerator<Nullable<GradientColorKey>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x334730 Offset: 0x334831 VA: 0x334730
	|-Dictionary.Enumerator<Nullable<Keyframe>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3348B0 Offset: 0x3349B1 VA: 0x3348B0
	|-Dictionary.Enumerator<Nullable<LayerMask>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x334A50 Offset: 0x334B51 VA: 0x334A50
	|-Dictionary.Enumerator<Nullable<Matrix4x4>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x334BF0 Offset: 0x334CF1 VA: 0x334BF0
	|-Dictionary.Enumerator<Nullable<Quaternion>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x334D80 Offset: 0x334E81 VA: 0x334D80
	|-Dictionary.Enumerator<Nullable<RangeInt>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x334F10 Offset: 0x335011 VA: 0x334F10
	|-Dictionary.Enumerator<Nullable<Rect>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32D8E0 Offset: 0x32D9E1 VA: 0x32D8E0
	|-Dictionary.Enumerator<Nullable<RectInt>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32DA70 Offset: 0x32DB71 VA: 0x32DA70
	|-Dictionary.Enumerator<Nullable<Vector2>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32DC00 Offset: 0x32DD01 VA: 0x32DC00
	|-Dictionary.Enumerator<Nullable<Vector2Int>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32DD90 Offset: 0x32DE91 VA: 0x32DD90
	|-Dictionary.Enumerator<Nullable<Vector3>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32DF20 Offset: 0x32E021 VA: 0x32DF20
	|-Dictionary.Enumerator<Nullable<Vector3Int>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32E0B0 Offset: 0x32E1B1 VA: 0x32E0B0
	|-Dictionary.Enumerator<Nullable<Vector4>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32E230 Offset: 0x32E331 VA: 0x32E230
	|-Dictionary.Enumerator<object, BitVector32Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32E3B0 Offset: 0x32E4B1 VA: 0x32E3B0
	|-Dictionary.Enumerator<object, EventCheckId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32E560 Offset: 0x32E661 VA: 0x32E560
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32E700 Offset: 0x32E801 VA: 0x32E700
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32E890 Offset: 0x32E991 VA: 0x32E890
	|-Dictionary.Enumerator<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32EA20 Offset: 0x32EB21 VA: 0x32EA20
	|-Dictionary.Enumerator<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32EBC0 Offset: 0x32ECC1 VA: 0x32EBC0
	|-Dictionary.Enumerator<object, MonsterHutSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32ED50 Offset: 0x32EE51 VA: 0x32ED50
	|-Dictionary.Enumerator<object, OrderLotterySaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32EEF0 Offset: 0x32EFF1 VA: 0x32EEF0
	|-Dictionary.Enumerator<object, OrderSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32F090 Offset: 0x32F191 VA: 0x32F090
	|-Dictionary.Enumerator<object, OrderSaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32F240 Offset: 0x32F341 VA: 0x32F240
	|-Dictionary.Enumerator<object, Parameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32F420 Offset: 0x32F521 VA: 0x32F420
	|-Dictionary.Enumerator<object, NumberControl.ValueRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32F5A0 Offset: 0x32F6A1 VA: 0x32F5A0
	|-Dictionary.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32F710 Offset: 0x32F811 VA: 0x32F710
	|-Dictionary.Enumerator<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32F880 Offset: 0x32F981 VA: 0x32F880
	|-Dictionary.Enumerator<object, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32F9F0 Offset: 0x32FAF1 VA: 0x32F9F0
	|-Dictionary.Enumerator<object, DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32FB60 Offset: 0x32FC61 VA: 0x32FB60
	|-Dictionary.Enumerator<object, double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32FCD0 Offset: 0x32FDD1 VA: 0x32FCD0
	|-Dictionary.Enumerator<object, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32FE40 Offset: 0x32FF41 VA: 0x32FE40
	|-Dictionary.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32FFB0 Offset: 0x3300B1 VA: 0x32FFB0
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x330120 Offset: 0x330221 VA: 0x330120
	|-Dictionary.Enumerator<object, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3302A0 Offset: 0x3303A1 VA: 0x3302A0
	|-Dictionary.Enumerator<object, Memory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x330420 Offset: 0x330521 VA: 0x330420
	|-Dictionary.Enumerator<object, Nullable<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3305B0 Offset: 0x3306B1 VA: 0x3305B0
	|-Dictionary.Enumerator<object, Nullable<Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x330750 Offset: 0x330851 VA: 0x330750
	|-Dictionary.Enumerator<object, Nullable<BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3308D0 Offset: 0x3309D1 VA: 0x3308D0
	|-Dictionary.Enumerator<object, Nullable<Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x330A50 Offset: 0x330B51 VA: 0x330A50
	|-Dictionary.Enumerator<object, Nullable<Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x330BE0 Offset: 0x330CE1 VA: 0x330BE0
	|-Dictionary.Enumerator<object, Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x330D70 Offset: 0x330E71 VA: 0x330D70
	|-Dictionary.Enumerator<object, Nullable<GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x330F10 Offset: 0x331011 VA: 0x330F10
	|-Dictionary.Enumerator<object, Nullable<Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x331090 Offset: 0x331191 VA: 0x331090
	|-Dictionary.Enumerator<object, Nullable<LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x331230 Offset: 0x331331 VA: 0x331230
	|-Dictionary.Enumerator<object, Nullable<Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3313D0 Offset: 0x3314D1 VA: 0x3313D0
	|-Dictionary.Enumerator<object, Nullable<Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33EEA0 Offset: 0x33EFA1 VA: 0x33EEA0
	|-Dictionary.Enumerator<object, Nullable<RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33F030 Offset: 0x33F131 VA: 0x33F030
	|-Dictionary.Enumerator<object, Nullable<Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33F1C0 Offset: 0x33F2C1 VA: 0x33F1C0
	|-Dictionary.Enumerator<object, Nullable<RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33F350 Offset: 0x33F451 VA: 0x33F350
	|-Dictionary.Enumerator<object, Nullable<Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33F4E0 Offset: 0x33F5E1 VA: 0x33F4E0
	|-Dictionary.Enumerator<object, Nullable<Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33F670 Offset: 0x33F771 VA: 0x33F670
	|-Dictionary.Enumerator<object, Nullable<Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33F800 Offset: 0x33F901 VA: 0x33F800
	|-Dictionary.Enumerator<object, Nullable<Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33F990 Offset: 0x33FA91 VA: 0x33F990
	|-Dictionary.Enumerator<object, Nullable<Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33FB10 Offset: 0x33FC11 VA: 0x33FB10
	|-Dictionary.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33FC90 Offset: 0x33FD91 VA: 0x33FC90
	|-Dictionary.Enumerator<object, ReadOnlyMemory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33FE20 Offset: 0x33FF21 VA: 0x33FE20
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33FFA0 Offset: 0x3400A1 VA: 0x33FFA0
	|-Dictionary.Enumerator<object, sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x340110 Offset: 0x340211 VA: 0x340110
	|-Dictionary.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x340280 Offset: 0x340381 VA: 0x340280
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3403F0 Offset: 0x3404F1 VA: 0x3403F0
	|-Dictionary.Enumerator<object, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x340560 Offset: 0x340661 VA: 0x340560
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3406F0 Offset: 0x3407F1 VA: 0x3406F0
	|-Dictionary.Enumerator<object, TransitionTables>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x340880 Offset: 0x340981 VA: 0x340880
	|-Dictionary.Enumerator<object, Bounds>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x340A10 Offset: 0x340B11 VA: 0x340A10
	|-Dictionary.Enumerator<object, BoundsInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x340B90 Offset: 0x340C91 VA: 0x340B90
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x340D10 Offset: 0x340E11 VA: 0x340D10
	|-Dictionary.Enumerator<object, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x340E90 Offset: 0x340F91 VA: 0x340E90
	|-Dictionary.Enumerator<object, GradientAlphaKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x341010 Offset: 0x341111 VA: 0x341010
	|-Dictionary.Enumerator<object, GradientColorKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3411B0 Offset: 0x3412B1 VA: 0x3411B0
	|-Dictionary.Enumerator<object, Keyframe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x341330 Offset: 0x341431 VA: 0x341330
	|-Dictionary.Enumerator<object, LayerMask>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3414D0 Offset: 0x3415D1 VA: 0x3414D0
	|-Dictionary.Enumerator<object, Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x341670 Offset: 0x341771 VA: 0x341670
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x341800 Offset: 0x341901 VA: 0x341800
	|-Dictionary.Enumerator<object, Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x341980 Offset: 0x341A81 VA: 0x341980
	|-Dictionary.Enumerator<object, RangeInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x341B00 Offset: 0x341C01 VA: 0x341B00
	|-Dictionary.Enumerator<object, Rect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x341C90 Offset: 0x341D91 VA: 0x341C90
	|-Dictionary.Enumerator<object, RectInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x341E20 Offset: 0x341F21 VA: 0x341E20
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x341FB0 Offset: 0x3420B1 VA: 0x341FB0
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x342130 Offset: 0x342231 VA: 0x342130
	|-Dictionary.Enumerator<object, Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3422A0 Offset: 0x3423A1 VA: 0x3422A0
	|-Dictionary.Enumerator<object, Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x342420 Offset: 0x342521 VA: 0x342420
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3425B0 Offset: 0x3426B1 VA: 0x3425B0
	|-Dictionary.Enumerator<object, Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x342740 Offset: 0x342841 VA: 0x342740
	|-Dictionary.Enumerator<object, Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3428D0 Offset: 0x3429D1 VA: 0x3428D0
	|-Dictionary.Enumerator<ReadOnlyMemory<object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x335090 Offset: 0x335191 VA: 0x335090
	|-Dictionary.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x335200 Offset: 0x335301 VA: 0x335200
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3353B0 Offset: 0x3354B1 VA: 0x3353B0
	|-Dictionary.Enumerator<float, CurveSample>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x335540 Offset: 0x335641 VA: 0x335540
	|-Dictionary.Enumerator<float, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3356B0 Offset: 0x3357B1 VA: 0x3356B0
	|-Dictionary.Enumerator<ushort, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x335820 Offset: 0x335921 VA: 0x335820
	|-Dictionary.Enumerator<uint, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x335980 Offset: 0x335A81 VA: 0x335980
	|-Dictionary.Enumerator<uint, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x335AE0 Offset: 0x335BE1 VA: 0x335AE0
	|-Dictionary.Enumerator<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x335C50 Offset: 0x335D51 VA: 0x335C50
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x335DC0 Offset: 0x335EC1 VA: 0x335DC0
	|-Dictionary.Enumerator<EdgeKeyByHash, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x335F60 Offset: 0x336061 VA: 0x335F60
	|-Dictionary.Enumerator<EdgeKeyByHash, CapEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x336110 Offset: 0x336211 VA: 0x336110
	|-Dictionary.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3362B0 Offset: 0x3363B1 VA: 0x3362B0
	|-Dictionary.Enumerator<EdgeKeyByIndex, ClippedEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x336430 Offset: 0x336531 VA: 0x336430
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3365A0 Offset: 0x3366A1 VA: 0x3365A0
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x336720 Offset: 0x336821 VA: 0x336720
	|-Dictionary.Enumerator<Bounds, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3368B0 Offset: 0x3369B1 VA: 0x3368B0
	|-Dictionary.Enumerator<BoundsInt, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x336A40 Offset: 0x336B41 VA: 0x336A40
	|-Dictionary.Enumerator<Color, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x336BC0 Offset: 0x336CC1 VA: 0x336BC0
	|-Dictionary.Enumerator<Color32, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x336D30 Offset: 0x336E31 VA: 0x336D30
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x336EA0 Offset: 0x336FA1 VA: 0x336EA0
	|-Dictionary.Enumerator<GradientAlphaKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x337020 Offset: 0x337121 VA: 0x337020
	|-Dictionary.Enumerator<GradientColorKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3371C0 Offset: 0x3372C1 VA: 0x3371C0
	|-Dictionary.Enumerator<Keyframe, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x337340 Offset: 0x337441 VA: 0x337340
	|-Dictionary.Enumerator<LayerMask, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3374E0 Offset: 0x3375E1 VA: 0x3374E0
	|-Dictionary.Enumerator<Matrix4x4, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x337680 Offset: 0x337781 VA: 0x337680
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x337810 Offset: 0x337911 VA: 0x337810
	|-Dictionary.Enumerator<Quaternion, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x337990 Offset: 0x337A91 VA: 0x337990
	|-Dictionary.Enumerator<RangeInt, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x337B10 Offset: 0x337C11 VA: 0x337B10
	|-Dictionary.Enumerator<Rect, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x337CA0 Offset: 0x337DA1 VA: 0x337CA0
	|-Dictionary.Enumerator<RectInt, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x337E20 Offset: 0x337F21 VA: 0x337E20
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x337F90 Offset: 0x338091 VA: 0x337F90
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x338100 Offset: 0x338201 VA: 0x338100
	|-Dictionary.Enumerator<Vector2, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x338270 Offset: 0x338371 VA: 0x338270
	|-Dictionary.Enumerator<Vector2Int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3383F0 Offset: 0x3384F1 VA: 0x3383F0
	|-Dictionary.Enumerator<Vector3, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x338580 Offset: 0x338681 VA: 0x338580
	|-Dictionary.Enumerator<Vector3Int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x338710 Offset: 0x338811 VA: 0x338710
	|-Dictionary.Enumerator<Vector4, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302A20 Offset: 0x302B21 VA: 0x302A20
	|-Dictionary.Enumerator<JSONDeserialization.TaskField, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x302BA0 Offset: 0x302CA1 VA: 0x302BA0
	|-Dictionary.Enumerator<BitVector32Int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x302D20 Offset: 0x302E21 VA: 0x302D20
	|-Dictionary.Enumerator<EventCheckId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x302ED0 Offset: 0x302FD1 VA: 0x302ED0
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x303070 Offset: 0x303171 VA: 0x303070
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x303200 Offset: 0x303301 VA: 0x303200
	|-Dictionary.Enumerator<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x303390 Offset: 0x303491 VA: 0x303390
	|-Dictionary.Enumerator<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x303530 Offset: 0x303631 VA: 0x303530
	|-Dictionary.Enumerator<MonsterHutSaveData, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3036C0 Offset: 0x3037C1 VA: 0x3036C0
	|-Dictionary.Enumerator<OrderLotterySaveParameter, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x303860 Offset: 0x303961 VA: 0x303860
	|-Dictionary.Enumerator<OrderSaveData, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x303A00 Offset: 0x303B01 VA: 0x303A00
	|-Dictionary.Enumerator<OrderSaveParameter, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x303BB0 Offset: 0x303CB1 VA: 0x303BB0
	|-Dictionary.Enumerator<Parameter, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x303D80 Offset: 0x303E81 VA: 0x303D80
	|-Dictionary.Enumerator<bool, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x303EF0 Offset: 0x303FF1 VA: 0x303EF0
	|-Dictionary.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x304060 Offset: 0x304161 VA: 0x304060
	|-Dictionary.Enumerator<char, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3041D0 Offset: 0x3042D1 VA: 0x3041D0
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x304340 Offset: 0x304441 VA: 0x304340
	|-Dictionary.Enumerator<double, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3044C0 Offset: 0x3045C1 VA: 0x3044C0
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x304640 Offset: 0x304741 VA: 0x304640
	|-Dictionary.Enumerator<short, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3047F0 Offset: 0x3048F1 VA: 0x3047F0
	|-Dictionary.Enumerator<int, CropDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3049F0 Offset: 0x304AF1 VA: 0x3049F0
	|-Dictionary.Enumerator<int, EffectDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x304B70 Offset: 0x304C71 VA: 0x304B70
	|-Dictionary.Enumerator<int, GimmickLayoutDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x331590 Offset: 0x331691 VA: 0x331590
	|-Dictionary.Enumerator<int, MineTypeDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x331730 Offset: 0x331831 VA: 0x331730
	|-Dictionary.Enumerator<int, MiningDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3318B0 Offset: 0x3319B1 VA: 0x3318B0
	|-Dictionary.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x331A10 Offset: 0x331B11 VA: 0x331A10
	|-Dictionary.Enumerator<int, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x331B70 Offset: 0x331C71 VA: 0x331B70
	|-Dictionary.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x331CD0 Offset: 0x331DD1 VA: 0x331CD0
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x331E30 Offset: 0x331F31 VA: 0x331E30
	|-Dictionary.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x331FA0 Offset: 0x3320A1 VA: 0x331FA0
	|-Dictionary.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x332140 Offset: 0x332241 VA: 0x332140
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3322E0 Offset: 0x3323E1 VA: 0x3322E0
	|-Dictionary.Enumerator<int, SceneInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x332460 Offset: 0x332561 VA: 0x332460
	|-Dictionary.Enumerator<int, Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3325D0 Offset: 0x3326D1 VA: 0x3325D0
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x332770 Offset: 0x332871 VA: 0x332770
	|-Dictionary.Enumerator<Int32Enum, MonsterDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x332970 Offset: 0x332A71 VA: 0x332970
	|-Dictionary.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x332B10 Offset: 0x332C11 VA: 0x332B10
	|-Dictionary.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x332C80 Offset: 0x332D81 VA: 0x332C80
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x332DE0 Offset: 0x332EE1 VA: 0x332DE0
	|-Dictionary.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x332F50 Offset: 0x333051 VA: 0x332F50
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3330B0 Offset: 0x3331B1 VA: 0x3330B0
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x333210 Offset: 0x333311 VA: 0x333210
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x333380 Offset: 0x333481 VA: 0x333380
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3334F0 Offset: 0x3335F1 VA: 0x3334F0
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x333670 Offset: 0x333771 VA: 0x333670
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<float, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3337E0 Offset: 0x3338E1 VA: 0x3337E0
	|-Dictionary.Enumerator<Int32Enum, TutorialUnlockFlagData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x333950 Offset: 0x333A51 VA: 0x333950
	|-Dictionary.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x333AD0 Offset: 0x333BD1 VA: 0x333AD0
	|-Dictionary.Enumerator<Memory<object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x333C50 Offset: 0x333D51 VA: 0x333C50
	|-Dictionary.Enumerator<Nullable<Int32Enum>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x333DE0 Offset: 0x333EE1 VA: 0x333DE0
	|-Dictionary.Enumerator<Nullable<Bounds>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x333F80 Offset: 0x334081 VA: 0x333F80
	|-Dictionary.Enumerator<Nullable<BoundsInt>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x334100 Offset: 0x334201 VA: 0x334100
	|-Dictionary.Enumerator<Nullable<Color32>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x334280 Offset: 0x334381 VA: 0x334280
	|-Dictionary.Enumerator<Nullable<Color>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x334410 Offset: 0x334511 VA: 0x334410
	|-Dictionary.Enumerator<Nullable<GradientAlphaKey>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3345A0 Offset: 0x3346A1 VA: 0x3345A0
	|-Dictionary.Enumerator<Nullable<GradientColorKey>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x334740 Offset: 0x334841 VA: 0x334740
	|-Dictionary.Enumerator<Nullable<Keyframe>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3348C0 Offset: 0x3349C1 VA: 0x3348C0
	|-Dictionary.Enumerator<Nullable<LayerMask>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x334A60 Offset: 0x334B61 VA: 0x334A60
	|-Dictionary.Enumerator<Nullable<Matrix4x4>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x334C00 Offset: 0x334D01 VA: 0x334C00
	|-Dictionary.Enumerator<Nullable<Quaternion>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x334D90 Offset: 0x334E91 VA: 0x334D90
	|-Dictionary.Enumerator<Nullable<RangeInt>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x334F20 Offset: 0x335021 VA: 0x334F20
	|-Dictionary.Enumerator<Nullable<Rect>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32D8F0 Offset: 0x32D9F1 VA: 0x32D8F0
	|-Dictionary.Enumerator<Nullable<RectInt>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32DA80 Offset: 0x32DB81 VA: 0x32DA80
	|-Dictionary.Enumerator<Nullable<Vector2>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32DC10 Offset: 0x32DD11 VA: 0x32DC10
	|-Dictionary.Enumerator<Nullable<Vector2Int>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32DDA0 Offset: 0x32DEA1 VA: 0x32DDA0
	|-Dictionary.Enumerator<Nullable<Vector3>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32DF30 Offset: 0x32E031 VA: 0x32DF30
	|-Dictionary.Enumerator<Nullable<Vector3Int>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32E0C0 Offset: 0x32E1C1 VA: 0x32E0C0
	|-Dictionary.Enumerator<Nullable<Vector4>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32E240 Offset: 0x32E341 VA: 0x32E240
	|-Dictionary.Enumerator<object, BitVector32Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32E3C0 Offset: 0x32E4C1 VA: 0x32E3C0
	|-Dictionary.Enumerator<object, EventCheckId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32E570 Offset: 0x32E671 VA: 0x32E570
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32E710 Offset: 0x32E811 VA: 0x32E710
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32E8A0 Offset: 0x32E9A1 VA: 0x32E8A0
	|-Dictionary.Enumerator<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32EA30 Offset: 0x32EB31 VA: 0x32EA30
	|-Dictionary.Enumerator<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32EBD0 Offset: 0x32ECD1 VA: 0x32EBD0
	|-Dictionary.Enumerator<object, MonsterHutSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32ED60 Offset: 0x32EE61 VA: 0x32ED60
	|-Dictionary.Enumerator<object, OrderLotterySaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32EF00 Offset: 0x32F001 VA: 0x32EF00
	|-Dictionary.Enumerator<object, OrderSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32F0A0 Offset: 0x32F1A1 VA: 0x32F0A0
	|-Dictionary.Enumerator<object, OrderSaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32F250 Offset: 0x32F351 VA: 0x32F250
	|-Dictionary.Enumerator<object, Parameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32F430 Offset: 0x32F531 VA: 0x32F430
	|-Dictionary.Enumerator<object, NumberControl.ValueRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32F5B0 Offset: 0x32F6B1 VA: 0x32F5B0
	|-Dictionary.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32F720 Offset: 0x32F821 VA: 0x32F720
	|-Dictionary.Enumerator<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32F890 Offset: 0x32F991 VA: 0x32F890
	|-Dictionary.Enumerator<object, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32FA00 Offset: 0x32FB01 VA: 0x32FA00
	|-Dictionary.Enumerator<object, DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32FB70 Offset: 0x32FC71 VA: 0x32FB70
	|-Dictionary.Enumerator<object, double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32FCE0 Offset: 0x32FDE1 VA: 0x32FCE0
	|-Dictionary.Enumerator<object, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32FE50 Offset: 0x32FF51 VA: 0x32FE50
	|-Dictionary.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32FFC0 Offset: 0x3300C1 VA: 0x32FFC0
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x330130 Offset: 0x330231 VA: 0x330130
	|-Dictionary.Enumerator<object, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3302B0 Offset: 0x3303B1 VA: 0x3302B0
	|-Dictionary.Enumerator<object, Memory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x330430 Offset: 0x330531 VA: 0x330430
	|-Dictionary.Enumerator<object, Nullable<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3305C0 Offset: 0x3306C1 VA: 0x3305C0
	|-Dictionary.Enumerator<object, Nullable<Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x330760 Offset: 0x330861 VA: 0x330760
	|-Dictionary.Enumerator<object, Nullable<BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3308E0 Offset: 0x3309E1 VA: 0x3308E0
	|-Dictionary.Enumerator<object, Nullable<Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x330A60 Offset: 0x330B61 VA: 0x330A60
	|-Dictionary.Enumerator<object, Nullable<Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x330BF0 Offset: 0x330CF1 VA: 0x330BF0
	|-Dictionary.Enumerator<object, Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x330D80 Offset: 0x330E81 VA: 0x330D80
	|-Dictionary.Enumerator<object, Nullable<GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x330F20 Offset: 0x331021 VA: 0x330F20
	|-Dictionary.Enumerator<object, Nullable<Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3310A0 Offset: 0x3311A1 VA: 0x3310A0
	|-Dictionary.Enumerator<object, Nullable<LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x331240 Offset: 0x331341 VA: 0x331240
	|-Dictionary.Enumerator<object, Nullable<Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3313E0 Offset: 0x3314E1 VA: 0x3313E0
	|-Dictionary.Enumerator<object, Nullable<Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33EEB0 Offset: 0x33EFB1 VA: 0x33EEB0
	|-Dictionary.Enumerator<object, Nullable<RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33F040 Offset: 0x33F141 VA: 0x33F040
	|-Dictionary.Enumerator<object, Nullable<Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33F1D0 Offset: 0x33F2D1 VA: 0x33F1D0
	|-Dictionary.Enumerator<object, Nullable<RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33F360 Offset: 0x33F461 VA: 0x33F360
	|-Dictionary.Enumerator<object, Nullable<Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33F4F0 Offset: 0x33F5F1 VA: 0x33F4F0
	|-Dictionary.Enumerator<object, Nullable<Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33F680 Offset: 0x33F781 VA: 0x33F680
	|-Dictionary.Enumerator<object, Nullable<Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33F810 Offset: 0x33F911 VA: 0x33F810
	|-Dictionary.Enumerator<object, Nullable<Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33F9A0 Offset: 0x33FAA1 VA: 0x33F9A0
	|-Dictionary.Enumerator<object, Nullable<Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33FB20 Offset: 0x33FC21 VA: 0x33FB20
	|-Dictionary.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33FCA0 Offset: 0x33FDA1 VA: 0x33FCA0
	|-Dictionary.Enumerator<object, ReadOnlyMemory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33FE30 Offset: 0x33FF31 VA: 0x33FE30
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33FFB0 Offset: 0x3400B1 VA: 0x33FFB0
	|-Dictionary.Enumerator<object, sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340120 Offset: 0x340221 VA: 0x340120
	|-Dictionary.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340290 Offset: 0x340391 VA: 0x340290
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340400 Offset: 0x340501 VA: 0x340400
	|-Dictionary.Enumerator<object, uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340570 Offset: 0x340671 VA: 0x340570
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340700 Offset: 0x340801 VA: 0x340700
	|-Dictionary.Enumerator<object, TransitionTables>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340890 Offset: 0x340991 VA: 0x340890
	|-Dictionary.Enumerator<object, Bounds>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340A20 Offset: 0x340B21 VA: 0x340A20
	|-Dictionary.Enumerator<object, BoundsInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340BA0 Offset: 0x340CA1 VA: 0x340BA0
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340D20 Offset: 0x340E21 VA: 0x340D20
	|-Dictionary.Enumerator<object, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x340EA0 Offset: 0x340FA1 VA: 0x340EA0
	|-Dictionary.Enumerator<object, GradientAlphaKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x341020 Offset: 0x341121 VA: 0x341020
	|-Dictionary.Enumerator<object, GradientColorKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3411C0 Offset: 0x3412C1 VA: 0x3411C0
	|-Dictionary.Enumerator<object, Keyframe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x341340 Offset: 0x341441 VA: 0x341340
	|-Dictionary.Enumerator<object, LayerMask>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3414E0 Offset: 0x3415E1 VA: 0x3414E0
	|-Dictionary.Enumerator<object, Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x341680 Offset: 0x341781 VA: 0x341680
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x341810 Offset: 0x341911 VA: 0x341810
	|-Dictionary.Enumerator<object, Quaternion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x341990 Offset: 0x341A91 VA: 0x341990
	|-Dictionary.Enumerator<object, RangeInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x341B10 Offset: 0x341C11 VA: 0x341B10
	|-Dictionary.Enumerator<object, Rect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x341CA0 Offset: 0x341DA1 VA: 0x341CA0
	|-Dictionary.Enumerator<object, RectInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x341E30 Offset: 0x341F31 VA: 0x341E30
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x341FC0 Offset: 0x3420C1 VA: 0x341FC0
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x342140 Offset: 0x342241 VA: 0x342140
	|-Dictionary.Enumerator<object, Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3422B0 Offset: 0x3423B1 VA: 0x3422B0
	|-Dictionary.Enumerator<object, Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x342430 Offset: 0x342531 VA: 0x342430
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3425C0 Offset: 0x3426C1 VA: 0x3425C0
	|-Dictionary.Enumerator<object, Vector3Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x342750 Offset: 0x342851 VA: 0x342750
	|-Dictionary.Enumerator<object, Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3428E0 Offset: 0x3429E1 VA: 0x3428E0
	|-Dictionary.Enumerator<ReadOnlyMemory<object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3350A0 Offset: 0x3351A1 VA: 0x3350A0
	|-Dictionary.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x335210 Offset: 0x335311 VA: 0x335210
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3353C0 Offset: 0x3354C1 VA: 0x3353C0
	|-Dictionary.Enumerator<float, CurveSample>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x335550 Offset: 0x335651 VA: 0x335550
	|-Dictionary.Enumerator<float, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3356C0 Offset: 0x3357C1 VA: 0x3356C0
	|-Dictionary.Enumerator<ushort, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x335830 Offset: 0x335931 VA: 0x335830
	|-Dictionary.Enumerator<uint, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x335990 Offset: 0x335A91 VA: 0x335990
	|-Dictionary.Enumerator<uint, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x335AF0 Offset: 0x335BF1 VA: 0x335AF0
	|-Dictionary.Enumerator<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x335C60 Offset: 0x335D61 VA: 0x335C60
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x335DD0 Offset: 0x335ED1 VA: 0x335DD0
	|-Dictionary.Enumerator<EdgeKeyByHash, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x335F70 Offset: 0x336071 VA: 0x335F70
	|-Dictionary.Enumerator<EdgeKeyByHash, CapEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x336120 Offset: 0x336221 VA: 0x336120
	|-Dictionary.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3362C0 Offset: 0x3363C1 VA: 0x3362C0
	|-Dictionary.Enumerator<EdgeKeyByIndex, ClippedEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x336440 Offset: 0x336541 VA: 0x336440
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3365B0 Offset: 0x3366B1 VA: 0x3365B0
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x336730 Offset: 0x336831 VA: 0x336730
	|-Dictionary.Enumerator<Bounds, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3368C0 Offset: 0x3369C1 VA: 0x3368C0
	|-Dictionary.Enumerator<BoundsInt, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x336A50 Offset: 0x336B51 VA: 0x336A50
	|-Dictionary.Enumerator<Color, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x336BD0 Offset: 0x336CD1 VA: 0x336BD0
	|-Dictionary.Enumerator<Color32, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x336D40 Offset: 0x336E41 VA: 0x336D40
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x336EB0 Offset: 0x336FB1 VA: 0x336EB0
	|-Dictionary.Enumerator<GradientAlphaKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x337030 Offset: 0x337131 VA: 0x337030
	|-Dictionary.Enumerator<GradientColorKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3371D0 Offset: 0x3372D1 VA: 0x3371D0
	|-Dictionary.Enumerator<Keyframe, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x337350 Offset: 0x337451 VA: 0x337350
	|-Dictionary.Enumerator<LayerMask, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3374F0 Offset: 0x3375F1 VA: 0x3374F0
	|-Dictionary.Enumerator<Matrix4x4, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x337690 Offset: 0x337791 VA: 0x337690
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x337820 Offset: 0x337921 VA: 0x337820
	|-Dictionary.Enumerator<Quaternion, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3379A0 Offset: 0x337AA1 VA: 0x3379A0
	|-Dictionary.Enumerator<RangeInt, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x337B20 Offset: 0x337C21 VA: 0x337B20
	|-Dictionary.Enumerator<Rect, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x337CB0 Offset: 0x337DB1 VA: 0x337CB0
	|-Dictionary.Enumerator<RectInt, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x337E30 Offset: 0x337F31 VA: 0x337E30
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x337FA0 Offset: 0x3380A1 VA: 0x337FA0
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x338110 Offset: 0x338211 VA: 0x338110
	|-Dictionary.Enumerator<Vector2, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x338280 Offset: 0x338381 VA: 0x338280
	|-Dictionary.Enumerator<Vector2Int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x338400 Offset: 0x338501 VA: 0x338400
	|-Dictionary.Enumerator<Vector3, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x338590 Offset: 0x338691 VA: 0x338590
	|-Dictionary.Enumerator<Vector3Int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x338720 Offset: 0x338821 VA: 0x338720
	|-Dictionary.Enumerator<Vector4, object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302AE0 Offset: 0x302BE1 VA: 0x302AE0
	|-Dictionary.Enumerator<JSONDeserialization.TaskField, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x302C50 Offset: 0x302D51 VA: 0x302C50
	|-Dictionary.Enumerator<BitVector32Int, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x302DE0 Offset: 0x302EE1 VA: 0x302DE0
	|-Dictionary.Enumerator<EventCheckId, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x302FA0 Offset: 0x3030A1 VA: 0x302FA0
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x303130 Offset: 0x303231 VA: 0x303130
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3032C0 Offset: 0x3033C1 VA: 0x3032C0
	|-Dictionary.Enumerator<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x303450 Offset: 0x303551 VA: 0x303450
	|-Dictionary.Enumerator<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3035F0 Offset: 0x3036F1 VA: 0x3035F0
	|-Dictionary.Enumerator<MonsterHutSaveData, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x303780 Offset: 0x303881 VA: 0x303780
	|-Dictionary.Enumerator<OrderLotterySaveParameter, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x303920 Offset: 0x303A21 VA: 0x303920
	|-Dictionary.Enumerator<OrderSaveData, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x303AC0 Offset: 0x303BC1 VA: 0x303AC0
	|-Dictionary.Enumerator<OrderSaveParameter, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x303CC0 Offset: 0x303DC1 VA: 0x303CC0
	|-Dictionary.Enumerator<Parameter, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x303E30 Offset: 0x303F31 VA: 0x303E30
	|-Dictionary.Enumerator<bool, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x303FA0 Offset: 0x3040A1 VA: 0x303FA0
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x304110 Offset: 0x304211 VA: 0x304110
	|-Dictionary.Enumerator<char, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x304280 Offset: 0x304381 VA: 0x304280
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3043F0 Offset: 0x3044F1 VA: 0x3043F0
	|-Dictionary.Enumerator<double, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x304580 Offset: 0x304681 VA: 0x304580
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3046F0 Offset: 0x3047F1 VA: 0x3046F0
	|-Dictionary.Enumerator<short, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x304920 Offset: 0x304A21 VA: 0x304920
	|-Dictionary.Enumerator<int, CropDataTable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x304AB0 Offset: 0x304BB1 VA: 0x304AB0
	|-Dictionary.Enumerator<int, EffectDataTable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x304C10 Offset: 0x304D11 VA: 0x304C10
	|-Dictionary.Enumerator<int, GimmickLayoutDataTable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x331660 Offset: 0x331761 VA: 0x331660
	|-Dictionary.Enumerator<int, MineTypeDataTable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3317F0 Offset: 0x3318F1 VA: 0x3317F0
	|-Dictionary.Enumerator<int, MiningDataTable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x331950 Offset: 0x331A51 VA: 0x331950
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x331AB0 Offset: 0x331BB1 VA: 0x331AB0
	|-Dictionary.Enumerator<int, char>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x331C10 Offset: 0x331D11 VA: 0x331C10
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x331D70 Offset: 0x331E71 VA: 0x331D70
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x331EE0 Offset: 0x331FE1 VA: 0x331EE0
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332050 Offset: 0x332151 VA: 0x332050
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332210 Offset: 0x332311 VA: 0x332210
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3323A0 Offset: 0x3324A1 VA: 0x3323A0
	|-Dictionary.Enumerator<int, SceneInstance>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332510 Offset: 0x332611 VA: 0x332510
	|-Dictionary.Enumerator<int, Vector2Int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332680 Offset: 0x332781 VA: 0x332680
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332880 Offset: 0x332981 VA: 0x332880
	|-Dictionary.Enumerator<Int32Enum, MonsterDataTable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332A40 Offset: 0x332B41 VA: 0x332A40
	|-Dictionary.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332BC0 Offset: 0x332CC1 VA: 0x332BC0
	|-Dictionary.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332D20 Offset: 0x332E21 VA: 0x332D20
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332E90 Offset: 0x332F91 VA: 0x332E90
	|-Dictionary.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x332FF0 Offset: 0x3330F1 VA: 0x332FF0
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x333150 Offset: 0x333251 VA: 0x333150
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3332C0 Offset: 0x3333C1 VA: 0x3332C0
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x333420 Offset: 0x333521 VA: 0x333420
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3335B0 Offset: 0x3336B1 VA: 0x3335B0
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<object, object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x333720 Offset: 0x333821 VA: 0x333720
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<float, float>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x333890 Offset: 0x333991 VA: 0x333890
	|-Dictionary.Enumerator<Int32Enum, TutorialUnlockFlagData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x333A00 Offset: 0x333B01 VA: 0x333A00
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x333B90 Offset: 0x333C91 VA: 0x333B90
	|-Dictionary.Enumerator<Memory<object>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x333D00 Offset: 0x333E01 VA: 0x333D00
	|-Dictionary.Enumerator<Nullable<Int32Enum>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x333EA0 Offset: 0x333FA1 VA: 0x333EA0
	|-Dictionary.Enumerator<Nullable<Bounds>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x334040 Offset: 0x334141 VA: 0x334040
	|-Dictionary.Enumerator<Nullable<BoundsInt>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3341B0 Offset: 0x3342B1 VA: 0x3341B0
	|-Dictionary.Enumerator<Nullable<Color32>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x334340 Offset: 0x334441 VA: 0x334340
	|-Dictionary.Enumerator<Nullable<Color>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3344D0 Offset: 0x3345D1 VA: 0x3344D0
	|-Dictionary.Enumerator<Nullable<GradientAlphaKey>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x334660 Offset: 0x334761 VA: 0x334660
	|-Dictionary.Enumerator<Nullable<GradientColorKey>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x334800 Offset: 0x334901 VA: 0x334800
	|-Dictionary.Enumerator<Nullable<Keyframe>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x334970 Offset: 0x334A71 VA: 0x334970
	|-Dictionary.Enumerator<Nullable<LayerMask>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x334B30 Offset: 0x334C31 VA: 0x334B30
	|-Dictionary.Enumerator<Nullable<Matrix4x4>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x334CC0 Offset: 0x334DC1 VA: 0x334CC0
	|-Dictionary.Enumerator<Nullable<Quaternion>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x334E50 Offset: 0x334F51 VA: 0x334E50
	|-Dictionary.Enumerator<Nullable<RangeInt>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x334FE0 Offset: 0x3350E1 VA: 0x334FE0
	|-Dictionary.Enumerator<Nullable<Rect>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32D9B0 Offset: 0x32DAB1 VA: 0x32D9B0
	|-Dictionary.Enumerator<Nullable<RectInt>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32DB40 Offset: 0x32DC41 VA: 0x32DB40
	|-Dictionary.Enumerator<Nullable<Vector2>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32DCD0 Offset: 0x32DDD1 VA: 0x32DCD0
	|-Dictionary.Enumerator<Nullable<Vector2Int>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32DE60 Offset: 0x32DF61 VA: 0x32DE60
	|-Dictionary.Enumerator<Nullable<Vector3>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32DFF0 Offset: 0x32E0F1 VA: 0x32DFF0
	|-Dictionary.Enumerator<Nullable<Vector3Int>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32E180 Offset: 0x32E281 VA: 0x32E180
	|-Dictionary.Enumerator<Nullable<Vector4>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32E2F0 Offset: 0x32E3F1 VA: 0x32E2F0
	|-Dictionary.Enumerator<object, BitVector32Int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32E480 Offset: 0x32E581 VA: 0x32E480
	|-Dictionary.Enumerator<object, EventCheckId>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32E640 Offset: 0x32E741 VA: 0x32E640
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32E7D0 Offset: 0x32E8D1 VA: 0x32E7D0
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32E960 Offset: 0x32EA61 VA: 0x32E960
	|-Dictionary.Enumerator<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32EAF0 Offset: 0x32EBF1 VA: 0x32EAF0
	|-Dictionary.Enumerator<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32EC90 Offset: 0x32ED91 VA: 0x32EC90
	|-Dictionary.Enumerator<object, MonsterHutSaveData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32EE20 Offset: 0x32EF21 VA: 0x32EE20
	|-Dictionary.Enumerator<object, OrderLotterySaveParameter>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32EFC0 Offset: 0x32F0C1 VA: 0x32EFC0
	|-Dictionary.Enumerator<object, OrderSaveData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32F160 Offset: 0x32F261 VA: 0x32F160
	|-Dictionary.Enumerator<object, OrderSaveParameter>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32F360 Offset: 0x32F461 VA: 0x32F360
	|-Dictionary.Enumerator<object, Parameter>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32F4F0 Offset: 0x32F5F1 VA: 0x32F4F0
	|-Dictionary.Enumerator<object, NumberControl.ValueRange>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32F660 Offset: 0x32F761 VA: 0x32F660
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32F7D0 Offset: 0x32F8D1 VA: 0x32F7D0
	|-Dictionary.Enumerator<object, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32F940 Offset: 0x32FA41 VA: 0x32F940
	|-Dictionary.Enumerator<object, char>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32FAB0 Offset: 0x32FBB1 VA: 0x32FAB0
	|-Dictionary.Enumerator<object, DateTime>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32FC20 Offset: 0x32FD21 VA: 0x32FC20
	|-Dictionary.Enumerator<object, double>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32FD90 Offset: 0x32FE91 VA: 0x32FD90
	|-Dictionary.Enumerator<object, short>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x32FF00 Offset: 0x330001 VA: 0x32FF00
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x330070 Offset: 0x330171 VA: 0x330070
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3301E0 Offset: 0x3302E1 VA: 0x3301E0
	|-Dictionary.Enumerator<object, long>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x330370 Offset: 0x330471 VA: 0x330370
	|-Dictionary.Enumerator<object, Memory<object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3304E0 Offset: 0x3305E1 VA: 0x3304E0
	|-Dictionary.Enumerator<object, Nullable<Int32Enum>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x330680 Offset: 0x330781 VA: 0x330680
	|-Dictionary.Enumerator<object, Nullable<Bounds>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x330820 Offset: 0x330921 VA: 0x330820
	|-Dictionary.Enumerator<object, Nullable<BoundsInt>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x330990 Offset: 0x330A91 VA: 0x330990
	|-Dictionary.Enumerator<object, Nullable<Color32>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x330B20 Offset: 0x330C21 VA: 0x330B20
	|-Dictionary.Enumerator<object, Nullable<Color>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x330CB0 Offset: 0x330DB1 VA: 0x330CB0
	|-Dictionary.Enumerator<object, Nullable<GradientAlphaKey>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x330E40 Offset: 0x330F41 VA: 0x330E40
	|-Dictionary.Enumerator<object, Nullable<GradientColorKey>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x330FE0 Offset: 0x3310E1 VA: 0x330FE0
	|-Dictionary.Enumerator<object, Nullable<Keyframe>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x331150 Offset: 0x331251 VA: 0x331150
	|-Dictionary.Enumerator<object, Nullable<LayerMask>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x331310 Offset: 0x331411 VA: 0x331310
	|-Dictionary.Enumerator<object, Nullable<Matrix4x4>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3314A0 Offset: 0x3315A1 VA: 0x3314A0
	|-Dictionary.Enumerator<object, Nullable<Quaternion>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33EF70 Offset: 0x33F071 VA: 0x33EF70
	|-Dictionary.Enumerator<object, Nullable<RangeInt>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33F100 Offset: 0x33F201 VA: 0x33F100
	|-Dictionary.Enumerator<object, Nullable<Rect>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33F290 Offset: 0x33F391 VA: 0x33F290
	|-Dictionary.Enumerator<object, Nullable<RectInt>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33F420 Offset: 0x33F521 VA: 0x33F420
	|-Dictionary.Enumerator<object, Nullable<Vector2>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33F5B0 Offset: 0x33F6B1 VA: 0x33F5B0
	|-Dictionary.Enumerator<object, Nullable<Vector2Int>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33F740 Offset: 0x33F841 VA: 0x33F740
	|-Dictionary.Enumerator<object, Nullable<Vector3>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33F8D0 Offset: 0x33F9D1 VA: 0x33F8D0
	|-Dictionary.Enumerator<object, Nullable<Vector3Int>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33FA60 Offset: 0x33FB61 VA: 0x33FA60
	|-Dictionary.Enumerator<object, Nullable<Vector4>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33FBD0 Offset: 0x33FCD1 VA: 0x33FBD0
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33FD60 Offset: 0x33FE61 VA: 0x33FD60
	|-Dictionary.Enumerator<object, ReadOnlyMemory<object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x33FEF0 Offset: 0x33FFF1 VA: 0x33FEF0
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x340060 Offset: 0x340161 VA: 0x340060
	|-Dictionary.Enumerator<object, sbyte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3401D0 Offset: 0x3402D1 VA: 0x3401D0
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x340340 Offset: 0x340441 VA: 0x340340
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3404B0 Offset: 0x3405B1 VA: 0x3404B0
	|-Dictionary.Enumerator<object, uint>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x340620 Offset: 0x340721 VA: 0x340620
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3407C0 Offset: 0x3408C1 VA: 0x3407C0
	|-Dictionary.Enumerator<object, TransitionTables>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x340950 Offset: 0x340A51 VA: 0x340950
	|-Dictionary.Enumerator<object, Bounds>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x340AE0 Offset: 0x340BE1 VA: 0x340AE0
	|-Dictionary.Enumerator<object, BoundsInt>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x340C50 Offset: 0x340D51 VA: 0x340C50
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x340DE0 Offset: 0x340EE1 VA: 0x340DE0
	|-Dictionary.Enumerator<object, Color>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x340F50 Offset: 0x341051 VA: 0x340F50
	|-Dictionary.Enumerator<object, GradientAlphaKey>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3410E0 Offset: 0x3411E1 VA: 0x3410E0
	|-Dictionary.Enumerator<object, GradientColorKey>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x341280 Offset: 0x341381 VA: 0x341280
	|-Dictionary.Enumerator<object, Keyframe>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3413F0 Offset: 0x3414F1 VA: 0x3413F0
	|-Dictionary.Enumerator<object, LayerMask>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3415B0 Offset: 0x3416B1 VA: 0x3415B0
	|-Dictionary.Enumerator<object, Matrix4x4>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x341740 Offset: 0x341841 VA: 0x341740
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3418D0 Offset: 0x3419D1 VA: 0x3418D0
	|-Dictionary.Enumerator<object, Quaternion>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x341A40 Offset: 0x341B41 VA: 0x341A40
	|-Dictionary.Enumerator<object, RangeInt>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x341BD0 Offset: 0x341CD1 VA: 0x341BD0
	|-Dictionary.Enumerator<object, Rect>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x341D60 Offset: 0x341E61 VA: 0x341D60
	|-Dictionary.Enumerator<object, RectInt>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x341EF0 Offset: 0x341FF1 VA: 0x341EF0
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x342080 Offset: 0x342181 VA: 0x342080
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3421F0 Offset: 0x3422F1 VA: 0x3421F0
	|-Dictionary.Enumerator<object, Vector2>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x342360 Offset: 0x342461 VA: 0x342360
	|-Dictionary.Enumerator<object, Vector2Int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3424F0 Offset: 0x3425F1 VA: 0x3424F0
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x342680 Offset: 0x342781 VA: 0x342680
	|-Dictionary.Enumerator<object, Vector3Int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x342810 Offset: 0x342911 VA: 0x342810
	|-Dictionary.Enumerator<object, Vector4>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3429A0 Offset: 0x342AA1 VA: 0x3429A0
	|-Dictionary.Enumerator<ReadOnlyMemory<object>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x335150 Offset: 0x335251 VA: 0x335150
	|-Dictionary.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3352C0 Offset: 0x3353C1 VA: 0x3352C0
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x335490 Offset: 0x335591 VA: 0x335490
	|-Dictionary.Enumerator<float, CurveSample>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x335600 Offset: 0x335701 VA: 0x335600
	|-Dictionary.Enumerator<float, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x335770 Offset: 0x335871 VA: 0x335770
	|-Dictionary.Enumerator<ushort, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3358D0 Offset: 0x3359D1 VA: 0x3358D0
	|-Dictionary.Enumerator<uint, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x335A30 Offset: 0x335B31 VA: 0x335A30
	|-Dictionary.Enumerator<uint, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x335BA0 Offset: 0x335CA1 VA: 0x335BA0
	|-Dictionary.Enumerator<uint, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x335D10 Offset: 0x335E11 VA: 0x335D10
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x335E80 Offset: 0x335F81 VA: 0x335E80
	|-Dictionary.Enumerator<EdgeKeyByHash, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x336030 Offset: 0x336131 VA: 0x336030
	|-Dictionary.Enumerator<EdgeKeyByHash, CapEdge>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3361F0 Offset: 0x3362F1 VA: 0x3361F0
	|-Dictionary.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x336380 Offset: 0x336481 VA: 0x336380
	|-Dictionary.Enumerator<EdgeKeyByIndex, ClippedEdge>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3364F0 Offset: 0x3365F1 VA: 0x3364F0
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x336660 Offset: 0x336761 VA: 0x336660
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3367F0 Offset: 0x3368F1 VA: 0x3367F0
	|-Dictionary.Enumerator<Bounds, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x336980 Offset: 0x336A81 VA: 0x336980
	|-Dictionary.Enumerator<BoundsInt, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x336B10 Offset: 0x336C11 VA: 0x336B10
	|-Dictionary.Enumerator<Color, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x336C80 Offset: 0x336D81 VA: 0x336C80
	|-Dictionary.Enumerator<Color32, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x336DF0 Offset: 0x336EF1 VA: 0x336DF0
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x336F60 Offset: 0x337061 VA: 0x336F60
	|-Dictionary.Enumerator<GradientAlphaKey, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3370F0 Offset: 0x3371F1 VA: 0x3370F0
	|-Dictionary.Enumerator<GradientColorKey, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x337290 Offset: 0x337391 VA: 0x337290
	|-Dictionary.Enumerator<Keyframe, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x337400 Offset: 0x337501 VA: 0x337400
	|-Dictionary.Enumerator<LayerMask, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3375C0 Offset: 0x3376C1 VA: 0x3375C0
	|-Dictionary.Enumerator<Matrix4x4, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x337750 Offset: 0x337851 VA: 0x337750
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3378E0 Offset: 0x3379E1 VA: 0x3378E0
	|-Dictionary.Enumerator<Quaternion, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x337A50 Offset: 0x337B51 VA: 0x337A50
	|-Dictionary.Enumerator<RangeInt, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x337BE0 Offset: 0x337CE1 VA: 0x337BE0
	|-Dictionary.Enumerator<Rect, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x337D70 Offset: 0x337E71 VA: 0x337D70
	|-Dictionary.Enumerator<RectInt, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x337EE0 Offset: 0x337FE1 VA: 0x337EE0
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x338050 Offset: 0x338151 VA: 0x338050
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3381C0 Offset: 0x3382C1 VA: 0x3381C0
	|-Dictionary.Enumerator<Vector2, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x338330 Offset: 0x338431 VA: 0x338330
	|-Dictionary.Enumerator<Vector2Int, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3384C0 Offset: 0x3385C1 VA: 0x3384C0
	|-Dictionary.Enumerator<Vector3, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x338650 Offset: 0x338751 VA: 0x338650
	|-Dictionary.Enumerator<Vector3Int, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3387E0 Offset: 0x3388E1 VA: 0x3387E0
	|-Dictionary.Enumerator<Vector4, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302AF0 Offset: 0x302BF1 VA: 0x302AF0
	|-Dictionary.Enumerator<JSONDeserialization.TaskField, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x302C60 Offset: 0x302D61 VA: 0x302C60
	|-Dictionary.Enumerator<BitVector32Int, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x302DF0 Offset: 0x302EF1 VA: 0x302DF0
	|-Dictionary.Enumerator<EventCheckId, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x302FB0 Offset: 0x3030B1 VA: 0x302FB0
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x303140 Offset: 0x303241 VA: 0x303140
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3032D0 Offset: 0x3033D1 VA: 0x3032D0
	|-Dictionary.Enumerator<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x303460 Offset: 0x303561 VA: 0x303460
	|-Dictionary.Enumerator<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x303600 Offset: 0x303701 VA: 0x303600
	|-Dictionary.Enumerator<MonsterHutSaveData, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x303790 Offset: 0x303891 VA: 0x303790
	|-Dictionary.Enumerator<OrderLotterySaveParameter, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x303930 Offset: 0x303A31 VA: 0x303930
	|-Dictionary.Enumerator<OrderSaveData, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x303AD0 Offset: 0x303BD1 VA: 0x303AD0
	|-Dictionary.Enumerator<OrderSaveParameter, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x303CD0 Offset: 0x303DD1 VA: 0x303CD0
	|-Dictionary.Enumerator<Parameter, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x303E40 Offset: 0x303F41 VA: 0x303E40
	|-Dictionary.Enumerator<bool, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x303FB0 Offset: 0x3040B1 VA: 0x303FB0
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x304120 Offset: 0x304221 VA: 0x304120
	|-Dictionary.Enumerator<char, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x304290 Offset: 0x304391 VA: 0x304290
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x304400 Offset: 0x304501 VA: 0x304400
	|-Dictionary.Enumerator<double, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x304590 Offset: 0x304691 VA: 0x304590
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x304700 Offset: 0x304801 VA: 0x304700
	|-Dictionary.Enumerator<short, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x304930 Offset: 0x304A31 VA: 0x304930
	|-Dictionary.Enumerator<int, CropDataTable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x304AC0 Offset: 0x304BC1 VA: 0x304AC0
	|-Dictionary.Enumerator<int, EffectDataTable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x304C20 Offset: 0x304D21 VA: 0x304C20
	|-Dictionary.Enumerator<int, GimmickLayoutDataTable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x331670 Offset: 0x331771 VA: 0x331670
	|-Dictionary.Enumerator<int, MineTypeDataTable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x331800 Offset: 0x331901 VA: 0x331800
	|-Dictionary.Enumerator<int, MiningDataTable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x331960 Offset: 0x331A61 VA: 0x331960
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x331AC0 Offset: 0x331BC1 VA: 0x331AC0
	|-Dictionary.Enumerator<int, char>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x331C20 Offset: 0x331D21 VA: 0x331C20
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x331D80 Offset: 0x331E81 VA: 0x331D80
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x331EF0 Offset: 0x331FF1 VA: 0x331EF0
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x332060 Offset: 0x332161 VA: 0x332060
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x332220 Offset: 0x332321 VA: 0x332220
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3323B0 Offset: 0x3324B1 VA: 0x3323B0
	|-Dictionary.Enumerator<int, SceneInstance>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x332520 Offset: 0x332621 VA: 0x332520
	|-Dictionary.Enumerator<int, Vector2Int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x332690 Offset: 0x332791 VA: 0x332690
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x332890 Offset: 0x332991 VA: 0x332890
	|-Dictionary.Enumerator<Int32Enum, MonsterDataTable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x332A50 Offset: 0x332B51 VA: 0x332A50
	|-Dictionary.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x332BD0 Offset: 0x332CD1 VA: 0x332BD0
	|-Dictionary.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x332D30 Offset: 0x332E31 VA: 0x332D30
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x332EA0 Offset: 0x332FA1 VA: 0x332EA0
	|-Dictionary.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x333000 Offset: 0x333101 VA: 0x333000
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x333160 Offset: 0x333261 VA: 0x333160
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3332D0 Offset: 0x3333D1 VA: 0x3332D0
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x333430 Offset: 0x333531 VA: 0x333430
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3335C0 Offset: 0x3336C1 VA: 0x3335C0
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<object, object>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x333730 Offset: 0x333831 VA: 0x333730
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<float, float>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3338A0 Offset: 0x3339A1 VA: 0x3338A0
	|-Dictionary.Enumerator<Int32Enum, TutorialUnlockFlagData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x333A10 Offset: 0x333B11 VA: 0x333A10
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x333BA0 Offset: 0x333CA1 VA: 0x333BA0
	|-Dictionary.Enumerator<Memory<object>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x333D10 Offset: 0x333E11 VA: 0x333D10
	|-Dictionary.Enumerator<Nullable<Int32Enum>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x333EB0 Offset: 0x333FB1 VA: 0x333EB0
	|-Dictionary.Enumerator<Nullable<Bounds>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x334050 Offset: 0x334151 VA: 0x334050
	|-Dictionary.Enumerator<Nullable<BoundsInt>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3341C0 Offset: 0x3342C1 VA: 0x3341C0
	|-Dictionary.Enumerator<Nullable<Color32>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x334350 Offset: 0x334451 VA: 0x334350
	|-Dictionary.Enumerator<Nullable<Color>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3344E0 Offset: 0x3345E1 VA: 0x3344E0
	|-Dictionary.Enumerator<Nullable<GradientAlphaKey>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x334670 Offset: 0x334771 VA: 0x334670
	|-Dictionary.Enumerator<Nullable<GradientColorKey>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x334810 Offset: 0x334911 VA: 0x334810
	|-Dictionary.Enumerator<Nullable<Keyframe>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x334980 Offset: 0x334A81 VA: 0x334980
	|-Dictionary.Enumerator<Nullable<LayerMask>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x334B40 Offset: 0x334C41 VA: 0x334B40
	|-Dictionary.Enumerator<Nullable<Matrix4x4>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x334CD0 Offset: 0x334DD1 VA: 0x334CD0
	|-Dictionary.Enumerator<Nullable<Quaternion>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x334E60 Offset: 0x334F61 VA: 0x334E60
	|-Dictionary.Enumerator<Nullable<RangeInt>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x334FF0 Offset: 0x3350F1 VA: 0x334FF0
	|-Dictionary.Enumerator<Nullable<Rect>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32D9C0 Offset: 0x32DAC1 VA: 0x32D9C0
	|-Dictionary.Enumerator<Nullable<RectInt>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32DB50 Offset: 0x32DC51 VA: 0x32DB50
	|-Dictionary.Enumerator<Nullable<Vector2>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32DCE0 Offset: 0x32DDE1 VA: 0x32DCE0
	|-Dictionary.Enumerator<Nullable<Vector2Int>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32DE70 Offset: 0x32DF71 VA: 0x32DE70
	|-Dictionary.Enumerator<Nullable<Vector3>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32E000 Offset: 0x32E101 VA: 0x32E000
	|-Dictionary.Enumerator<Nullable<Vector3Int>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32E190 Offset: 0x32E291 VA: 0x32E190
	|-Dictionary.Enumerator<Nullable<Vector4>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32E300 Offset: 0x32E401 VA: 0x32E300
	|-Dictionary.Enumerator<object, BitVector32Int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32E490 Offset: 0x32E591 VA: 0x32E490
	|-Dictionary.Enumerator<object, EventCheckId>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32E650 Offset: 0x32E751 VA: 0x32E650
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32E7E0 Offset: 0x32E8E1 VA: 0x32E7E0
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32E970 Offset: 0x32EA71 VA: 0x32E970
	|-Dictionary.Enumerator<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32EB00 Offset: 0x32EC01 VA: 0x32EB00
	|-Dictionary.Enumerator<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32ECA0 Offset: 0x32EDA1 VA: 0x32ECA0
	|-Dictionary.Enumerator<object, MonsterHutSaveData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32EE30 Offset: 0x32EF31 VA: 0x32EE30
	|-Dictionary.Enumerator<object, OrderLotterySaveParameter>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32EFD0 Offset: 0x32F0D1 VA: 0x32EFD0
	|-Dictionary.Enumerator<object, OrderSaveData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32F170 Offset: 0x32F271 VA: 0x32F170
	|-Dictionary.Enumerator<object, OrderSaveParameter>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32F370 Offset: 0x32F471 VA: 0x32F370
	|-Dictionary.Enumerator<object, Parameter>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32F500 Offset: 0x32F601 VA: 0x32F500
	|-Dictionary.Enumerator<object, NumberControl.ValueRange>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32F670 Offset: 0x32F771 VA: 0x32F670
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32F7E0 Offset: 0x32F8E1 VA: 0x32F7E0
	|-Dictionary.Enumerator<object, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32F950 Offset: 0x32FA51 VA: 0x32F950
	|-Dictionary.Enumerator<object, char>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32FAC0 Offset: 0x32FBC1 VA: 0x32FAC0
	|-Dictionary.Enumerator<object, DateTime>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32FC30 Offset: 0x32FD31 VA: 0x32FC30
	|-Dictionary.Enumerator<object, double>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32FDA0 Offset: 0x32FEA1 VA: 0x32FDA0
	|-Dictionary.Enumerator<object, short>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x32FF10 Offset: 0x330011 VA: 0x32FF10
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x330080 Offset: 0x330181 VA: 0x330080
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3301F0 Offset: 0x3302F1 VA: 0x3301F0
	|-Dictionary.Enumerator<object, long>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x330380 Offset: 0x330481 VA: 0x330380
	|-Dictionary.Enumerator<object, Memory<object>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3304F0 Offset: 0x3305F1 VA: 0x3304F0
	|-Dictionary.Enumerator<object, Nullable<Int32Enum>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x330690 Offset: 0x330791 VA: 0x330690
	|-Dictionary.Enumerator<object, Nullable<Bounds>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x330830 Offset: 0x330931 VA: 0x330830
	|-Dictionary.Enumerator<object, Nullable<BoundsInt>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3309A0 Offset: 0x330AA1 VA: 0x3309A0
	|-Dictionary.Enumerator<object, Nullable<Color32>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x330B30 Offset: 0x330C31 VA: 0x330B30
	|-Dictionary.Enumerator<object, Nullable<Color>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x330CC0 Offset: 0x330DC1 VA: 0x330CC0
	|-Dictionary.Enumerator<object, Nullable<GradientAlphaKey>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x330E50 Offset: 0x330F51 VA: 0x330E50
	|-Dictionary.Enumerator<object, Nullable<GradientColorKey>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x330FF0 Offset: 0x3310F1 VA: 0x330FF0
	|-Dictionary.Enumerator<object, Nullable<Keyframe>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x331160 Offset: 0x331261 VA: 0x331160
	|-Dictionary.Enumerator<object, Nullable<LayerMask>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x331320 Offset: 0x331421 VA: 0x331320
	|-Dictionary.Enumerator<object, Nullable<Matrix4x4>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3314B0 Offset: 0x3315B1 VA: 0x3314B0
	|-Dictionary.Enumerator<object, Nullable<Quaternion>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33EF80 Offset: 0x33F081 VA: 0x33EF80
	|-Dictionary.Enumerator<object, Nullable<RangeInt>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33F110 Offset: 0x33F211 VA: 0x33F110
	|-Dictionary.Enumerator<object, Nullable<Rect>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33F2A0 Offset: 0x33F3A1 VA: 0x33F2A0
	|-Dictionary.Enumerator<object, Nullable<RectInt>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33F430 Offset: 0x33F531 VA: 0x33F430
	|-Dictionary.Enumerator<object, Nullable<Vector2>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33F5C0 Offset: 0x33F6C1 VA: 0x33F5C0
	|-Dictionary.Enumerator<object, Nullable<Vector2Int>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33F750 Offset: 0x33F851 VA: 0x33F750
	|-Dictionary.Enumerator<object, Nullable<Vector3>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33F8E0 Offset: 0x33F9E1 VA: 0x33F8E0
	|-Dictionary.Enumerator<object, Nullable<Vector3Int>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33FA70 Offset: 0x33FB71 VA: 0x33FA70
	|-Dictionary.Enumerator<object, Nullable<Vector4>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33FBE0 Offset: 0x33FCE1 VA: 0x33FBE0
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33FD70 Offset: 0x33FE71 VA: 0x33FD70
	|-Dictionary.Enumerator<object, ReadOnlyMemory<object>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x33FF00 Offset: 0x340001 VA: 0x33FF00
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x340070 Offset: 0x340171 VA: 0x340070
	|-Dictionary.Enumerator<object, sbyte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3401E0 Offset: 0x3402E1 VA: 0x3401E0
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x340350 Offset: 0x340451 VA: 0x340350
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3404C0 Offset: 0x3405C1 VA: 0x3404C0
	|-Dictionary.Enumerator<object, uint>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x340630 Offset: 0x340731 VA: 0x340630
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3407D0 Offset: 0x3408D1 VA: 0x3407D0
	|-Dictionary.Enumerator<object, TransitionTables>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x340960 Offset: 0x340A61 VA: 0x340960
	|-Dictionary.Enumerator<object, Bounds>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x340AF0 Offset: 0x340BF1 VA: 0x340AF0
	|-Dictionary.Enumerator<object, BoundsInt>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x340C60 Offset: 0x340D61 VA: 0x340C60
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x340DF0 Offset: 0x340EF1 VA: 0x340DF0
	|-Dictionary.Enumerator<object, Color>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x340F60 Offset: 0x341061 VA: 0x340F60
	|-Dictionary.Enumerator<object, GradientAlphaKey>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3410F0 Offset: 0x3411F1 VA: 0x3410F0
	|-Dictionary.Enumerator<object, GradientColorKey>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x341290 Offset: 0x341391 VA: 0x341290
	|-Dictionary.Enumerator<object, Keyframe>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x341400 Offset: 0x341501 VA: 0x341400
	|-Dictionary.Enumerator<object, LayerMask>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3415C0 Offset: 0x3416C1 VA: 0x3415C0
	|-Dictionary.Enumerator<object, Matrix4x4>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x341750 Offset: 0x341851 VA: 0x341750
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3418E0 Offset: 0x3419E1 VA: 0x3418E0
	|-Dictionary.Enumerator<object, Quaternion>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x341A50 Offset: 0x341B51 VA: 0x341A50
	|-Dictionary.Enumerator<object, RangeInt>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x341BE0 Offset: 0x341CE1 VA: 0x341BE0
	|-Dictionary.Enumerator<object, Rect>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x341D70 Offset: 0x341E71 VA: 0x341D70
	|-Dictionary.Enumerator<object, RectInt>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x341F00 Offset: 0x342001 VA: 0x341F00
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x342090 Offset: 0x342191 VA: 0x342090
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x342200 Offset: 0x342301 VA: 0x342200
	|-Dictionary.Enumerator<object, Vector2>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x342370 Offset: 0x342471 VA: 0x342370
	|-Dictionary.Enumerator<object, Vector2Int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x342500 Offset: 0x342601 VA: 0x342500
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x342690 Offset: 0x342791 VA: 0x342690
	|-Dictionary.Enumerator<object, Vector3Int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x342820 Offset: 0x342921 VA: 0x342820
	|-Dictionary.Enumerator<object, Vector4>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3429B0 Offset: 0x342AB1 VA: 0x3429B0
	|-Dictionary.Enumerator<ReadOnlyMemory<object>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x335160 Offset: 0x335261 VA: 0x335160
	|-Dictionary.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3352D0 Offset: 0x3353D1 VA: 0x3352D0
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3354A0 Offset: 0x3355A1 VA: 0x3354A0
	|-Dictionary.Enumerator<float, CurveSample>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x335610 Offset: 0x335711 VA: 0x335610
	|-Dictionary.Enumerator<float, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x335780 Offset: 0x335881 VA: 0x335780
	|-Dictionary.Enumerator<ushort, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3358E0 Offset: 0x3359E1 VA: 0x3358E0
	|-Dictionary.Enumerator<uint, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x335A40 Offset: 0x335B41 VA: 0x335A40
	|-Dictionary.Enumerator<uint, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x335BB0 Offset: 0x335CB1 VA: 0x335BB0
	|-Dictionary.Enumerator<uint, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x335D20 Offset: 0x335E21 VA: 0x335D20
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x335E90 Offset: 0x335F91 VA: 0x335E90
	|-Dictionary.Enumerator<EdgeKeyByHash, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336040 Offset: 0x336141 VA: 0x336040
	|-Dictionary.Enumerator<EdgeKeyByHash, CapEdge>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336200 Offset: 0x336301 VA: 0x336200
	|-Dictionary.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336390 Offset: 0x336491 VA: 0x336390
	|-Dictionary.Enumerator<EdgeKeyByIndex, ClippedEdge>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336500 Offset: 0x336601 VA: 0x336500
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336670 Offset: 0x336771 VA: 0x336670
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336800 Offset: 0x336901 VA: 0x336800
	|-Dictionary.Enumerator<Bounds, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336990 Offset: 0x336A91 VA: 0x336990
	|-Dictionary.Enumerator<BoundsInt, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336B20 Offset: 0x336C21 VA: 0x336B20
	|-Dictionary.Enumerator<Color, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336C90 Offset: 0x336D91 VA: 0x336C90
	|-Dictionary.Enumerator<Color32, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336E00 Offset: 0x336F01 VA: 0x336E00
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x336F70 Offset: 0x337071 VA: 0x336F70
	|-Dictionary.Enumerator<GradientAlphaKey, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x337100 Offset: 0x337201 VA: 0x337100
	|-Dictionary.Enumerator<GradientColorKey, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3372A0 Offset: 0x3373A1 VA: 0x3372A0
	|-Dictionary.Enumerator<Keyframe, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x337410 Offset: 0x337511 VA: 0x337410
	|-Dictionary.Enumerator<LayerMask, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3375D0 Offset: 0x3376D1 VA: 0x3375D0
	|-Dictionary.Enumerator<Matrix4x4, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x337760 Offset: 0x337861 VA: 0x337760
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3378F0 Offset: 0x3379F1 VA: 0x3378F0
	|-Dictionary.Enumerator<Quaternion, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x337A60 Offset: 0x337B61 VA: 0x337A60
	|-Dictionary.Enumerator<RangeInt, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x337BF0 Offset: 0x337CF1 VA: 0x337BF0
	|-Dictionary.Enumerator<Rect, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x337D80 Offset: 0x337E81 VA: 0x337D80
	|-Dictionary.Enumerator<RectInt, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x337EF0 Offset: 0x337FF1 VA: 0x337EF0
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x338060 Offset: 0x338161 VA: 0x338060
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3381D0 Offset: 0x3382D1 VA: 0x3381D0
	|-Dictionary.Enumerator<Vector2, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x338340 Offset: 0x338441 VA: 0x338340
	|-Dictionary.Enumerator<Vector2Int, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3384D0 Offset: 0x3385D1 VA: 0x3384D0
	|-Dictionary.Enumerator<Vector3, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x338660 Offset: 0x338761 VA: 0x338660
	|-Dictionary.Enumerator<Vector3Int, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3387F0 Offset: 0x3388F1 VA: 0x3387F0
	|-Dictionary.Enumerator<Vector4, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302B00 Offset: 0x302C01 VA: 0x302B00
	|-Dictionary.Enumerator<JSONDeserialization.TaskField, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x302C70 Offset: 0x302D71 VA: 0x302C70
	|-Dictionary.Enumerator<BitVector32Int, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x302E00 Offset: 0x302F01 VA: 0x302E00
	|-Dictionary.Enumerator<EventCheckId, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x302FC0 Offset: 0x3030C1 VA: 0x302FC0
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x303150 Offset: 0x303251 VA: 0x303150
	|-Dictionary.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3032E0 Offset: 0x3033E1 VA: 0x3032E0
	|-Dictionary.Enumerator<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x303470 Offset: 0x303571 VA: 0x303470
	|-Dictionary.Enumerator<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x303610 Offset: 0x303711 VA: 0x303610
	|-Dictionary.Enumerator<MonsterHutSaveData, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3037A0 Offset: 0x3038A1 VA: 0x3037A0
	|-Dictionary.Enumerator<OrderLotterySaveParameter, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x303940 Offset: 0x303A41 VA: 0x303940
	|-Dictionary.Enumerator<OrderSaveData, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x303AE0 Offset: 0x303BE1 VA: 0x303AE0
	|-Dictionary.Enumerator<OrderSaveParameter, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x303CE0 Offset: 0x303DE1 VA: 0x303CE0
	|-Dictionary.Enumerator<Parameter, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x303E50 Offset: 0x303F51 VA: 0x303E50
	|-Dictionary.Enumerator<bool, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x303FC0 Offset: 0x3040C1 VA: 0x303FC0
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x304130 Offset: 0x304231 VA: 0x304130
	|-Dictionary.Enumerator<char, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3042A0 Offset: 0x3043A1 VA: 0x3042A0
	|-Dictionary.Enumerator<DateTime, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x304410 Offset: 0x304511 VA: 0x304410
	|-Dictionary.Enumerator<double, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3045A0 Offset: 0x3046A1 VA: 0x3045A0
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x304710 Offset: 0x304811 VA: 0x304710
	|-Dictionary.Enumerator<short, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x304940 Offset: 0x304A41 VA: 0x304940
	|-Dictionary.Enumerator<int, CropDataTable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x304AD0 Offset: 0x304BD1 VA: 0x304AD0
	|-Dictionary.Enumerator<int, EffectDataTable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x304C30 Offset: 0x304D31 VA: 0x304C30
	|-Dictionary.Enumerator<int, GimmickLayoutDataTable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331680 Offset: 0x331781 VA: 0x331680
	|-Dictionary.Enumerator<int, MineTypeDataTable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331810 Offset: 0x331911 VA: 0x331810
	|-Dictionary.Enumerator<int, MiningDataTable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331970 Offset: 0x331A71 VA: 0x331970
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331AD0 Offset: 0x331BD1 VA: 0x331AD0
	|-Dictionary.Enumerator<int, char>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331C30 Offset: 0x331D31 VA: 0x331C30
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331D90 Offset: 0x331E91 VA: 0x331D90
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331F00 Offset: 0x332001 VA: 0x331F00
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x332070 Offset: 0x332171 VA: 0x332070
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x332230 Offset: 0x332331 VA: 0x332230
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3323C0 Offset: 0x3324C1 VA: 0x3323C0
	|-Dictionary.Enumerator<int, SceneInstance>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x332530 Offset: 0x332631 VA: 0x332530
	|-Dictionary.Enumerator<int, Vector2Int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3326A0 Offset: 0x3327A1 VA: 0x3326A0
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3328A0 Offset: 0x3329A1 VA: 0x3328A0
	|-Dictionary.Enumerator<Int32Enum, MonsterDataTable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x332A60 Offset: 0x332B61 VA: 0x332A60
	|-Dictionary.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x332BE0 Offset: 0x332CE1 VA: 0x332BE0
	|-Dictionary.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x332D40 Offset: 0x332E41 VA: 0x332D40
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x332EB0 Offset: 0x332FB1 VA: 0x332EB0
	|-Dictionary.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x333010 Offset: 0x333111 VA: 0x333010
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x333170 Offset: 0x333271 VA: 0x333170
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3332E0 Offset: 0x3333E1 VA: 0x3332E0
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x333440 Offset: 0x333541 VA: 0x333440
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3335D0 Offset: 0x3336D1 VA: 0x3335D0
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<object, object>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x333740 Offset: 0x333841 VA: 0x333740
	|-Dictionary.Enumerator<Int32Enum, ValueTuple<float, float>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3338B0 Offset: 0x3339B1 VA: 0x3338B0
	|-Dictionary.Enumerator<Int32Enum, TutorialUnlockFlagData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x333A20 Offset: 0x333B21 VA: 0x333A20
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x333BB0 Offset: 0x333CB1 VA: 0x333BB0
	|-Dictionary.Enumerator<Memory<object>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x333D20 Offset: 0x333E21 VA: 0x333D20
	|-Dictionary.Enumerator<Nullable<Int32Enum>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x333EC0 Offset: 0x333FC1 VA: 0x333EC0
	|-Dictionary.Enumerator<Nullable<Bounds>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x334060 Offset: 0x334161 VA: 0x334060
	|-Dictionary.Enumerator<Nullable<BoundsInt>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3341D0 Offset: 0x3342D1 VA: 0x3341D0
	|-Dictionary.Enumerator<Nullable<Color32>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x334360 Offset: 0x334461 VA: 0x334360
	|-Dictionary.Enumerator<Nullable<Color>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3344F0 Offset: 0x3345F1 VA: 0x3344F0
	|-Dictionary.Enumerator<Nullable<GradientAlphaKey>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x334680 Offset: 0x334781 VA: 0x334680
	|-Dictionary.Enumerator<Nullable<GradientColorKey>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x334820 Offset: 0x334921 VA: 0x334820
	|-Dictionary.Enumerator<Nullable<Keyframe>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x334990 Offset: 0x334A91 VA: 0x334990
	|-Dictionary.Enumerator<Nullable<LayerMask>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x334B50 Offset: 0x334C51 VA: 0x334B50
	|-Dictionary.Enumerator<Nullable<Matrix4x4>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x334CE0 Offset: 0x334DE1 VA: 0x334CE0
	|-Dictionary.Enumerator<Nullable<Quaternion>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x334E70 Offset: 0x334F71 VA: 0x334E70
	|-Dictionary.Enumerator<Nullable<RangeInt>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x335000 Offset: 0x335101 VA: 0x335000
	|-Dictionary.Enumerator<Nullable<Rect>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32D9D0 Offset: 0x32DAD1 VA: 0x32D9D0
	|-Dictionary.Enumerator<Nullable<RectInt>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32DB60 Offset: 0x32DC61 VA: 0x32DB60
	|-Dictionary.Enumerator<Nullable<Vector2>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32DCF0 Offset: 0x32DDF1 VA: 0x32DCF0
	|-Dictionary.Enumerator<Nullable<Vector2Int>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32DE80 Offset: 0x32DF81 VA: 0x32DE80
	|-Dictionary.Enumerator<Nullable<Vector3>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32E010 Offset: 0x32E111 VA: 0x32E010
	|-Dictionary.Enumerator<Nullable<Vector3Int>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32E1A0 Offset: 0x32E2A1 VA: 0x32E1A0
	|-Dictionary.Enumerator<Nullable<Vector4>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32E310 Offset: 0x32E411 VA: 0x32E310
	|-Dictionary.Enumerator<object, BitVector32Int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32E4A0 Offset: 0x32E5A1 VA: 0x32E4A0
	|-Dictionary.Enumerator<object, EventCheckId>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32E660 Offset: 0x32E761 VA: 0x32E660
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32E7F0 Offset: 0x32E8F1 VA: 0x32E7F0
	|-Dictionary.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32E980 Offset: 0x32EA81 VA: 0x32E980
	|-Dictionary.Enumerator<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32EB10 Offset: 0x32EC11 VA: 0x32EB10
	|-Dictionary.Enumerator<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32ECB0 Offset: 0x32EDB1 VA: 0x32ECB0
	|-Dictionary.Enumerator<object, MonsterHutSaveData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32EE40 Offset: 0x32EF41 VA: 0x32EE40
	|-Dictionary.Enumerator<object, OrderLotterySaveParameter>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32EFE0 Offset: 0x32F0E1 VA: 0x32EFE0
	|-Dictionary.Enumerator<object, OrderSaveData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32F180 Offset: 0x32F281 VA: 0x32F180
	|-Dictionary.Enumerator<object, OrderSaveParameter>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32F380 Offset: 0x32F481 VA: 0x32F380
	|-Dictionary.Enumerator<object, Parameter>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32F510 Offset: 0x32F611 VA: 0x32F510
	|-Dictionary.Enumerator<object, NumberControl.ValueRange>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32F680 Offset: 0x32F781 VA: 0x32F680
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32F7F0 Offset: 0x32F8F1 VA: 0x32F7F0
	|-Dictionary.Enumerator<object, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32F960 Offset: 0x32FA61 VA: 0x32F960
	|-Dictionary.Enumerator<object, char>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32FAD0 Offset: 0x32FBD1 VA: 0x32FAD0
	|-Dictionary.Enumerator<object, DateTime>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32FC40 Offset: 0x32FD41 VA: 0x32FC40
	|-Dictionary.Enumerator<object, double>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32FDB0 Offset: 0x32FEB1 VA: 0x32FDB0
	|-Dictionary.Enumerator<object, short>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x32FF20 Offset: 0x330021 VA: 0x32FF20
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x330090 Offset: 0x330191 VA: 0x330090
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x330200 Offset: 0x330301 VA: 0x330200
	|-Dictionary.Enumerator<object, long>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x330390 Offset: 0x330491 VA: 0x330390
	|-Dictionary.Enumerator<object, Memory<object>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x330500 Offset: 0x330601 VA: 0x330500
	|-Dictionary.Enumerator<object, Nullable<Int32Enum>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3306A0 Offset: 0x3307A1 VA: 0x3306A0
	|-Dictionary.Enumerator<object, Nullable<Bounds>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x330840 Offset: 0x330941 VA: 0x330840
	|-Dictionary.Enumerator<object, Nullable<BoundsInt>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3309B0 Offset: 0x330AB1 VA: 0x3309B0
	|-Dictionary.Enumerator<object, Nullable<Color32>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x330B40 Offset: 0x330C41 VA: 0x330B40
	|-Dictionary.Enumerator<object, Nullable<Color>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x330CD0 Offset: 0x330DD1 VA: 0x330CD0
	|-Dictionary.Enumerator<object, Nullable<GradientAlphaKey>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x330E60 Offset: 0x330F61 VA: 0x330E60
	|-Dictionary.Enumerator<object, Nullable<GradientColorKey>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331000 Offset: 0x331101 VA: 0x331000
	|-Dictionary.Enumerator<object, Nullable<Keyframe>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331170 Offset: 0x331271 VA: 0x331170
	|-Dictionary.Enumerator<object, Nullable<LayerMask>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x331330 Offset: 0x331431 VA: 0x331330
	|-Dictionary.Enumerator<object, Nullable<Matrix4x4>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3314C0 Offset: 0x3315C1 VA: 0x3314C0
	|-Dictionary.Enumerator<object, Nullable<Quaternion>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33EF90 Offset: 0x33F091 VA: 0x33EF90
	|-Dictionary.Enumerator<object, Nullable<RangeInt>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33F120 Offset: 0x33F221 VA: 0x33F120
	|-Dictionary.Enumerator<object, Nullable<Rect>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33F2B0 Offset: 0x33F3B1 VA: 0x33F2B0
	|-Dictionary.Enumerator<object, Nullable<RectInt>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33F440 Offset: 0x33F541 VA: 0x33F440
	|-Dictionary.Enumerator<object, Nullable<Vector2>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33F5D0 Offset: 0x33F6D1 VA: 0x33F5D0
	|-Dictionary.Enumerator<object, Nullable<Vector2Int>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33F760 Offset: 0x33F861 VA: 0x33F760
	|-Dictionary.Enumerator<object, Nullable<Vector3>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33F8F0 Offset: 0x33F9F1 VA: 0x33F8F0
	|-Dictionary.Enumerator<object, Nullable<Vector3Int>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33FA80 Offset: 0x33FB81 VA: 0x33FA80
	|-Dictionary.Enumerator<object, Nullable<Vector4>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33FBF0 Offset: 0x33FCF1 VA: 0x33FBF0
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33FD80 Offset: 0x33FE81 VA: 0x33FD80
	|-Dictionary.Enumerator<object, ReadOnlyMemory<object>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x33FF10 Offset: 0x340011 VA: 0x33FF10
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x340080 Offset: 0x340181 VA: 0x340080
	|-Dictionary.Enumerator<object, sbyte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3401F0 Offset: 0x3402F1 VA: 0x3401F0
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x340360 Offset: 0x340461 VA: 0x340360
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3404D0 Offset: 0x3405D1 VA: 0x3404D0
	|-Dictionary.Enumerator<object, uint>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x340640 Offset: 0x340741 VA: 0x340640
	|-Dictionary.Enumerator<object, ulong>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3407E0 Offset: 0x3408E1 VA: 0x3407E0
	|-Dictionary.Enumerator<object, TransitionTables>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x340970 Offset: 0x340A71 VA: 0x340970
	|-Dictionary.Enumerator<object, Bounds>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x340B00 Offset: 0x340C01 VA: 0x340B00
	|-Dictionary.Enumerator<object, BoundsInt>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x340C70 Offset: 0x340D71 VA: 0x340C70
	|-Dictionary.Enumerator<object, Color32>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x340E00 Offset: 0x340F01 VA: 0x340E00
	|-Dictionary.Enumerator<object, Color>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x340F70 Offset: 0x341071 VA: 0x340F70
	|-Dictionary.Enumerator<object, GradientAlphaKey>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x341100 Offset: 0x341201 VA: 0x341100
	|-Dictionary.Enumerator<object, GradientColorKey>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3412A0 Offset: 0x3413A1 VA: 0x3412A0
	|-Dictionary.Enumerator<object, Keyframe>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x341410 Offset: 0x341511 VA: 0x341410
	|-Dictionary.Enumerator<object, LayerMask>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3415D0 Offset: 0x3416D1 VA: 0x3415D0
	|-Dictionary.Enumerator<object, Matrix4x4>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x341760 Offset: 0x341861 VA: 0x341760
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3418F0 Offset: 0x3419F1 VA: 0x3418F0
	|-Dictionary.Enumerator<object, Quaternion>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x341A60 Offset: 0x341B61 VA: 0x341A60
	|-Dictionary.Enumerator<object, RangeInt>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x341BF0 Offset: 0x341CF1 VA: 0x341BF0
	|-Dictionary.Enumerator<object, Rect>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x341D80 Offset: 0x341E81 VA: 0x341D80
	|-Dictionary.Enumerator<object, RectInt>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x341F10 Offset: 0x342011 VA: 0x341F10
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3420A0 Offset: 0x3421A1 VA: 0x3420A0
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x342210 Offset: 0x342311 VA: 0x342210
	|-Dictionary.Enumerator<object, Vector2>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x342380 Offset: 0x342481 VA: 0x342380
	|-Dictionary.Enumerator<object, Vector2Int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x342510 Offset: 0x342611 VA: 0x342510
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3426A0 Offset: 0x3427A1 VA: 0x3426A0
	|-Dictionary.Enumerator<object, Vector3Int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x342830 Offset: 0x342931 VA: 0x342830
	|-Dictionary.Enumerator<object, Vector4>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3429C0 Offset: 0x342AC1 VA: 0x3429C0
	|-Dictionary.Enumerator<ReadOnlyMemory<object>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x335170 Offset: 0x335271 VA: 0x335170
	|-Dictionary.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3352E0 Offset: 0x3353E1 VA: 0x3352E0
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3354B0 Offset: 0x3355B1 VA: 0x3354B0
	|-Dictionary.Enumerator<float, CurveSample>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x335620 Offset: 0x335721 VA: 0x335620
	|-Dictionary.Enumerator<float, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x335790 Offset: 0x335891 VA: 0x335790
	|-Dictionary.Enumerator<ushort, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3358F0 Offset: 0x3359F1 VA: 0x3358F0
	|-Dictionary.Enumerator<uint, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x335A50 Offset: 0x335B51 VA: 0x335A50
	|-Dictionary.Enumerator<uint, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x335BC0 Offset: 0x335CC1 VA: 0x335BC0
	|-Dictionary.Enumerator<uint, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x335D30 Offset: 0x335E31 VA: 0x335D30
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x335EA0 Offset: 0x335FA1 VA: 0x335EA0
	|-Dictionary.Enumerator<EdgeKeyByHash, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x336050 Offset: 0x336151 VA: 0x336050
	|-Dictionary.Enumerator<EdgeKeyByHash, CapEdge>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x336210 Offset: 0x336311 VA: 0x336210
	|-Dictionary.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3363A0 Offset: 0x3364A1 VA: 0x3363A0
	|-Dictionary.Enumerator<EdgeKeyByIndex, ClippedEdge>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x336510 Offset: 0x336611 VA: 0x336510
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x336680 Offset: 0x336781 VA: 0x336680
	|-Dictionary.Enumerator<MeshDataConnectivity.Face, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x336810 Offset: 0x336911 VA: 0x336810
	|-Dictionary.Enumerator<Bounds, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3369A0 Offset: 0x336AA1 VA: 0x3369A0
	|-Dictionary.Enumerator<BoundsInt, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x336B30 Offset: 0x336C31 VA: 0x336B30
	|-Dictionary.Enumerator<Color, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x336CA0 Offset: 0x336DA1 VA: 0x336CA0
	|-Dictionary.Enumerator<Color32, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x336E10 Offset: 0x336F11 VA: 0x336E10
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x336F80 Offset: 0x337081 VA: 0x336F80
	|-Dictionary.Enumerator<GradientAlphaKey, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x337110 Offset: 0x337211 VA: 0x337110
	|-Dictionary.Enumerator<GradientColorKey, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3372B0 Offset: 0x3373B1 VA: 0x3372B0
	|-Dictionary.Enumerator<Keyframe, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x337420 Offset: 0x337521 VA: 0x337420
	|-Dictionary.Enumerator<LayerMask, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3375E0 Offset: 0x3376E1 VA: 0x3375E0
	|-Dictionary.Enumerator<Matrix4x4, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x337770 Offset: 0x337871 VA: 0x337770
	|-Dictionary.Enumerator<IntVec3, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x337900 Offset: 0x337A01 VA: 0x337900
	|-Dictionary.Enumerator<Quaternion, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x337A70 Offset: 0x337B71 VA: 0x337A70
	|-Dictionary.Enumerator<RangeInt, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x337C00 Offset: 0x337D01 VA: 0x337C00
	|-Dictionary.Enumerator<Rect, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x337D90 Offset: 0x337E91 VA: 0x337D90
	|-Dictionary.Enumerator<RectInt, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x337F00 Offset: 0x338001 VA: 0x337F00
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x338070 Offset: 0x338171 VA: 0x338070
	|-Dictionary.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3381E0 Offset: 0x3382E1 VA: 0x3381E0
	|-Dictionary.Enumerator<Vector2, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x338350 Offset: 0x338451 VA: 0x338350
	|-Dictionary.Enumerator<Vector2Int, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3384E0 Offset: 0x3385E1 VA: 0x3384E0
	|-Dictionary.Enumerator<Vector3, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x338670 Offset: 0x338771 VA: 0x338670
	|-Dictionary.Enumerator<Vector3Int, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x338800 Offset: 0x338901 VA: 0x338800
	|-Dictionary.Enumerator<Vector4, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/
}

