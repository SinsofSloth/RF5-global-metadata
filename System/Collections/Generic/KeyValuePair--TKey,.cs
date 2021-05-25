[Serializable]
public struct KeyValuePair<TKey, TValue> // TypeDefIndex: 1417
{
	// Fields
	private TKey key; // 0x0
	private TValue value; // 0x0

	// Properties
	public TKey Key { get; }
	public TValue Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x304C40 Offset: 0x304D41 VA: 0x304C40
	|-KeyValuePair<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x304CB0 Offset: 0x304DB1 VA: 0x304CB0
	|-KeyValuePair<BitVector32Int, object>..ctor
	|
	|-RVA: 0x304CF0 Offset: 0x304DF1 VA: 0x304CF0
	|-KeyValuePair<EventCheckId, object>..ctor
	|
	|-RVA: 0x305AE0 Offset: 0x305BE1 VA: 0x305AE0
	|-KeyValuePair<FarmManager.FARM_ID, int>..ctor
	|-KeyValuePair<Int32Enum, int>..ctor
	|
	|-RVA: 0x304D80 Offset: 0x304E81 VA: 0x304D80
	|-KeyValuePair<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x304E10 Offset: 0x304F11 VA: 0x304E10
	|-KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x304E70 Offset: 0x304F71 VA: 0x304E70
	|-KeyValuePair<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x304EC0 Offset: 0x304FC1 VA: 0x304EC0
	|-KeyValuePair<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x304F00 Offset: 0x305001 VA: 0x304F00
	|-KeyValuePair<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x304F90 Offset: 0x305091 VA: 0x304F90
	|-KeyValuePair<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x304FE0 Offset: 0x3050E1 VA: 0x304FE0
	|-KeyValuePair<OrderSaveData, object>..ctor
	|
	|-RVA: 0x305070 Offset: 0x305171 VA: 0x305070
	|-KeyValuePair<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x305100 Offset: 0x305201 VA: 0x305100
	|-KeyValuePair<Parameter, object>..ctor
	|
	|-RVA: 0x305170 Offset: 0x305271 VA: 0x305170
	|-KeyValuePair<bool, object>..ctor
	|
	|-RVA: 0x3051C0 Offset: 0x3052C1 VA: 0x3051C0
	|-KeyValuePair<byte, object>..ctor
	|
	|-RVA: 0x305200 Offset: 0x305301 VA: 0x305200
	|-KeyValuePair<char, object>..ctor
	|
	|-RVA: 0x305240 Offset: 0x305341 VA: 0x305240
	|-KeyValuePair<DateTime, object>..ctor
	|-KeyValuePair<DateTime, TimeType>..ctor
	|
	|-RVA: 0x305280 Offset: 0x305381 VA: 0x305280
	|-KeyValuePair<double, object>..ctor
	|
	|-RVA: 0x3052C0 Offset: 0x3053C1 VA: 0x3052C0
	|-KeyValuePair<Guid, object>..ctor
	|
	|-RVA: 0x305300 Offset: 0x305401 VA: 0x305300
	|-KeyValuePair<short, object>..ctor
	|
	|-RVA: 0x305340 Offset: 0x305441 VA: 0x305340
	|-KeyValuePair<int, CropDataTable>..ctor
	|
	|-RVA: 0x3053D0 Offset: 0x3054D1 VA: 0x3053D0
	|-KeyValuePair<int, EffectDataTable>..ctor
	|
	|-RVA: 0x305450 Offset: 0x305551 VA: 0x305450
	|-KeyValuePair<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x305490 Offset: 0x305591 VA: 0x305490
	|-KeyValuePair<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x305540 Offset: 0x305641 VA: 0x305540
	|-KeyValuePair<int, MiningDataTable>..ctor
	|
	|-RVA: 0x305590 Offset: 0x305691 VA: 0x305590
	|-KeyValuePair<int, bool>..ctor
	|
	|-RVA: 0x3055D0 Offset: 0x3056D1 VA: 0x3055D0
	|-KeyValuePair<int, char>..ctor
	|
	|-RVA: 0x305610 Offset: 0x305711 VA: 0x305610
	|-KeyValuePair<int, int>..ctor
	|
	|-RVA: 0x305650 Offset: 0x305751 VA: 0x305650
	|-KeyValuePair<int, Int32Enum>..ctor
	|
	|-RVA: 0x305690 Offset: 0x305791 VA: 0x305690
	|-KeyValuePair<int, long>..ctor
	|
	|-RVA: 0x3056D0 Offset: 0x3057D1 VA: 0x3056D0
	|-KeyValuePair<int, object>..ctor
	|
	|-RVA: 0x305710 Offset: 0x305811 VA: 0x305710
	|-KeyValuePair<int, uint>..ctor
	|
	|-RVA: 0x305750 Offset: 0x305851 VA: 0x305750
	|-KeyValuePair<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x3057E0 Offset: 0x3058E1 VA: 0x3057E0
	|-KeyValuePair<int, SceneInstance>..ctor
	|
	|-RVA: 0x305830 Offset: 0x305931 VA: 0x305830
	|-KeyValuePair<int, Vector2Int>..ctor
	|
	|-RVA: 0x305870 Offset: 0x305971 VA: 0x305870
	|-KeyValuePair<int, Vector3>..ctor
	|
	|-RVA: 0x3058C0 Offset: 0x3059C1 VA: 0x3058C0
	|-KeyValuePair<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x305950 Offset: 0x305A51 VA: 0x305950
	|-KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x3059E0 Offset: 0x305AE1 VA: 0x3059E0
	|-KeyValuePair<Int32Enum, MonsterSearchRangeParameter>..ctor
	|
	|-RVA: 0x305A20 Offset: 0x305B21 VA: 0x305A20
	|-KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x305A60 Offset: 0x305B61 VA: 0x305A60
	|-KeyValuePair<Int32Enum, bool>..ctor
	|
	|-RVA: 0x305AA0 Offset: 0x305BA1 VA: 0x305AA0
	|-KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x305B20 Offset: 0x305C21 VA: 0x305B20
	|-KeyValuePair<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x305B60 Offset: 0x305C61 VA: 0x305B60
	|-KeyValuePair<Int32Enum, object>..ctor
	|
	|-RVA: 0x305BA0 Offset: 0x305CA1 VA: 0x305BA0
	|-KeyValuePair<Int32Enum, float>..ctor
	|
	|-RVA: 0x305BE0 Offset: 0x305CE1 VA: 0x305BE0
	|-KeyValuePair<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x305C30 Offset: 0x305D31 VA: 0x305C30
	|-KeyValuePair<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x305C70 Offset: 0x305D71 VA: 0x305C70
	|-KeyValuePair<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x305CB0 Offset: 0x305DB1 VA: 0x305CB0
	|-KeyValuePair<long, object>..ctor
	|
	|-RVA: 0x305CF0 Offset: 0x305DF1 VA: 0x305CF0
	|-KeyValuePair<Memory<object>, object>..ctor
	|
	|-RVA: 0x305D60 Offset: 0x305E61 VA: 0x305D60
	|-KeyValuePair<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x305DA0 Offset: 0x305EA1 VA: 0x305DA0
	|-KeyValuePair<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x305E10 Offset: 0x305F11 VA: 0x305E10
	|-KeyValuePair<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x305E80 Offset: 0x305F81 VA: 0x305E80
	|-KeyValuePair<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x305EC0 Offset: 0x305FC1 VA: 0x305EC0
	|-KeyValuePair<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x305F20 Offset: 0x306021 VA: 0x305F20
	|-KeyValuePair<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x305F70 Offset: 0x306071 VA: 0x305F70
	|-KeyValuePair<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x305FD0 Offset: 0x3060D1 VA: 0x305FD0
	|-KeyValuePair<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x306030 Offset: 0x306131 VA: 0x306030
	|-KeyValuePair<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x306070 Offset: 0x306171 VA: 0x306070
	|-KeyValuePair<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x306110 Offset: 0x306211 VA: 0x306110
	|-KeyValuePair<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x306170 Offset: 0x306271 VA: 0x306170
	|-KeyValuePair<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x3061C0 Offset: 0x3062C1 VA: 0x3061C0
	|-KeyValuePair<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x306220 Offset: 0x306321 VA: 0x306220
	|-KeyValuePair<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x306280 Offset: 0x306381 VA: 0x306280
	|-KeyValuePair<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x3062D0 Offset: 0x3063D1 VA: 0x3062D0
	|-KeyValuePair<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x306320 Offset: 0x306421 VA: 0x306320
	|-KeyValuePair<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x306360 Offset: 0x306461 VA: 0x306360
	|-KeyValuePair<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x3063A0 Offset: 0x3064A1 VA: 0x3063A0
	|-KeyValuePair<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x306400 Offset: 0x306501 VA: 0x306400
	|-KeyValuePair<object, BitVector32Int>..ctor
	|
	|-RVA: 0x306460 Offset: 0x306561 VA: 0x306460
	|-KeyValuePair<object, EventCheckId>..ctor
	|
	|-RVA: 0x306500 Offset: 0x306601 VA: 0x306500
	|-KeyValuePair<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x3065D0 Offset: 0x3066D1 VA: 0x3065D0
	|-KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x306660 Offset: 0x306761 VA: 0x306660
	|-KeyValuePair<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x3066D0 Offset: 0x3067D1 VA: 0x3066D0
	|-KeyValuePair<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x306740 Offset: 0x306841 VA: 0x306740
	|-KeyValuePair<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x3067F0 Offset: 0x3068F1 VA: 0x3067F0
	|-KeyValuePair<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x306860 Offset: 0x306961 VA: 0x306860
	|-KeyValuePair<object, OrderSaveData>..ctor
	|
	|-RVA: 0x306910 Offset: 0x306A11 VA: 0x306910
	|-KeyValuePair<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x3069B0 Offset: 0x306AB1 VA: 0x3069B0
	|-KeyValuePair<object, Parameter>..ctor
	|
	|-RVA: 0x306A50 Offset: 0x306B51 VA: 0x306A50
	|-KeyValuePair<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x306AC0 Offset: 0x306BC1 VA: 0x306AC0
	|-KeyValuePair<object, bool>..ctor
	|
	|-RVA: 0x306B30 Offset: 0x306C31 VA: 0x306B30
	|-KeyValuePair<object, byte>..ctor
	|
	|-RVA: 0x306B90 Offset: 0x306C91 VA: 0x306B90
	|-KeyValuePair<object, char>..ctor
	|
	|-RVA: 0x306BF0 Offset: 0x306CF1 VA: 0x306BF0
	|-KeyValuePair<object, DateTime>..ctor
	|
	|-RVA: 0x306C50 Offset: 0x306D51 VA: 0x306C50
	|-KeyValuePair<object, double>..ctor
	|
	|-RVA: 0x306CC0 Offset: 0x306DC1 VA: 0x306CC0
	|-KeyValuePair<object, short>..ctor
	|
	|-RVA: 0x306D20 Offset: 0x306E21 VA: 0x306D20
	|-KeyValuePair<object, int>..ctor
	|-KeyValuePair<string, int>..ctor
	|
	|-RVA: 0x306D80 Offset: 0x306E81 VA: 0x306D80
	|-KeyValuePair<object, Int32Enum>..ctor
	|
	|-RVA: 0x306DE0 Offset: 0x306EE1 VA: 0x306DE0
	|-KeyValuePair<object, long>..ctor
	|
	|-RVA: 0x306E40 Offset: 0x306F41 VA: 0x306E40
	|-KeyValuePair<object, Memory<object>>..ctor
	|
	|-RVA: 0x306EC0 Offset: 0x306FC1 VA: 0x306EC0
	|-KeyValuePair<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x306F20 Offset: 0x307021 VA: 0x306F20
	|-KeyValuePair<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x306FC0 Offset: 0x3070C1 VA: 0x306FC0
	|-KeyValuePair<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x307060 Offset: 0x307161 VA: 0x307060
	|-KeyValuePair<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x3070C0 Offset: 0x3071C1 VA: 0x3070C0
	|-KeyValuePair<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x307150 Offset: 0x307251 VA: 0x307150
	|-KeyValuePair<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x3071C0 Offset: 0x3072C1 VA: 0x3071C0
	|-KeyValuePair<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x307250 Offset: 0x307351 VA: 0x307250
	|-KeyValuePair<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x3072E0 Offset: 0x3073E1 VA: 0x3072E0
	|-KeyValuePair<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x307340 Offset: 0x307441 VA: 0x307340
	|-KeyValuePair<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x307430 Offset: 0x307531 VA: 0x307430
	|-KeyValuePair<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3074C0 Offset: 0x3075C1 VA: 0x3074C0
	|-KeyValuePair<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x307530 Offset: 0x307631 VA: 0x307530
	|-KeyValuePair<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x3075C0 Offset: 0x3076C1 VA: 0x3075C0
	|-KeyValuePair<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x307650 Offset: 0x307751 VA: 0x307650
	|-KeyValuePair<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x3076C0 Offset: 0x3077C1 VA: 0x3076C0
	|-KeyValuePair<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x307730 Offset: 0x307831 VA: 0x307730
	|-KeyValuePair<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x3077A0 Offset: 0x3078A1 VA: 0x3077A0
	|-KeyValuePair<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x307810 Offset: 0x307911 VA: 0x307810
	|-KeyValuePair<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x3078A0 Offset: 0x3079A1 VA: 0x3078A0
	|-KeyValuePair<object, object>..ctor
	|-KeyValuePair<string, object>..ctor
	|-KeyValuePair<AnimationClip, AnimationClip>..ctor
	|
	|-RVA: 0x307950 Offset: 0x307A51 VA: 0x307950
	|-KeyValuePair<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x3079D0 Offset: 0x307AD1 VA: 0x3079D0
	|-KeyValuePair<object, ResourceLocator>..ctor
	|
	|-RVA: 0x307A50 Offset: 0x307B51 VA: 0x307A50
	|-KeyValuePair<object, sbyte>..ctor
	|
	|-RVA: 0x307AB0 Offset: 0x307BB1 VA: 0x307AB0
	|-KeyValuePair<object, float>..ctor
	|
	|-RVA: 0x307B20 Offset: 0x307C21 VA: 0x307B20
	|-KeyValuePair<object, ushort>..ctor
	|
	|-RVA: 0x307B80 Offset: 0x307C81 VA: 0x307B80
	|-KeyValuePair<object, uint>..ctor
	|
	|-RVA: 0x307BE0 Offset: 0x307CE1 VA: 0x307BE0
	|-KeyValuePair<object, ulong>..ctor
	|
	|-RVA: 0x307C40 Offset: 0x307D41 VA: 0x307C40
	|-KeyValuePair<object, TransitionTables>..ctor
	|
	|-RVA: 0x307CE0 Offset: 0x307DE1 VA: 0x307CE0
	|-KeyValuePair<object, Bounds>..ctor
	|
	|-RVA: 0x307D70 Offset: 0x307E71 VA: 0x307D70
	|-KeyValuePair<object, BoundsInt>..ctor
	|
	|-RVA: 0x307E00 Offset: 0x307F01 VA: 0x307E00
	|-KeyValuePair<object, Color32>..ctor
	|
	|-RVA: 0x307E60 Offset: 0x307F61 VA: 0x307E60
	|-KeyValuePair<object, Color>..ctor
	|
	|-RVA: 0x307EF0 Offset: 0x307FF1 VA: 0x307EF0
	|-KeyValuePair<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x307F60 Offset: 0x308061 VA: 0x307F60
	|-KeyValuePair<object, GradientColorKey>..ctor
	|
	|-RVA: 0x307FF0 Offset: 0x3080F1 VA: 0x307FF0
	|-KeyValuePair<object, Keyframe>..ctor
	|
	|-RVA: 0x308090 Offset: 0x308191 VA: 0x308090
	|-KeyValuePair<object, LayerMask>..ctor
	|
	|-RVA: 0x3080F0 Offset: 0x3081F1 VA: 0x3080F0
	|-KeyValuePair<object, Matrix4x4>..ctor
	|
	|-RVA: 0x3081B0 Offset: 0x3082B1 VA: 0x3081B0
	|-KeyValuePair<object, Playable>..ctor
	|
	|-RVA: 0x308220 Offset: 0x308321 VA: 0x308220
	|-KeyValuePair<object, Quaternion>..ctor
	|
	|-RVA: 0x3082B0 Offset: 0x3083B1 VA: 0x3082B0
	|-KeyValuePair<object, RangeInt>..ctor
	|
	|-RVA: 0x308310 Offset: 0x308411 VA: 0x308310
	|-KeyValuePair<object, Rect>..ctor
	|
	|-RVA: 0x3083A0 Offset: 0x3084A1 VA: 0x3083A0
	|-KeyValuePair<object, RectInt>..ctor
	|
	|-RVA: 0x308410 Offset: 0x308511 VA: 0x308410
	|-KeyValuePair<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3084B0 Offset: 0x3085B1 VA: 0x3084B0
	|-KeyValuePair<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x308550 Offset: 0x308651 VA: 0x308550
	|-KeyValuePair<object, Vector2>..ctor
	|
	|-RVA: 0x3085C0 Offset: 0x3086C1 VA: 0x3085C0
	|-KeyValuePair<object, Vector2Int>..ctor
	|
	|-RVA: 0x308620 Offset: 0x308721 VA: 0x308620
	|-KeyValuePair<object, Vector3>..ctor
	|
	|-RVA: 0x3086A0 Offset: 0x3087A1 VA: 0x3086A0
	|-KeyValuePair<object, Vector3Int>..ctor
	|
	|-RVA: 0x308710 Offset: 0x308811 VA: 0x308710
	|-KeyValuePair<object, Vector4>..ctor
	|
	|-RVA: 0x3087A0 Offset: 0x3088A1 VA: 0x3087A0
	|-KeyValuePair<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x308810 Offset: 0x308911 VA: 0x308810
	|-KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x308850 Offset: 0x308951 VA: 0x308850
	|-KeyValuePair<sbyte, object>..ctor
	|
	|-RVA: 0x308890 Offset: 0x308991 VA: 0x308890
	|-KeyValuePair<float, CurveSample>..ctor
	|
	|-RVA: 0x308960 Offset: 0x308A61 VA: 0x308960
	|-KeyValuePair<float, int>..ctor
	|
	|-RVA: 0x3089A0 Offset: 0x308AA1 VA: 0x3089A0
	|-KeyValuePair<float, object>..ctor
	|
	|-RVA: 0x3089E0 Offset: 0x308AE1 VA: 0x3089E0
	|-KeyValuePair<ushort, object>..ctor
	|
	|-RVA: 0x308A20 Offset: 0x308B21 VA: 0x308A20
	|-KeyValuePair<uint, int>..ctor
	|
	|-RVA: 0x308A60 Offset: 0x308B61 VA: 0x308A60
	|-KeyValuePair<uint, Int32Enum>..ctor
	|
	|-RVA: 0x308AA0 Offset: 0x308BA1 VA: 0x308AA0
	|-KeyValuePair<uint, object>..ctor
	|
	|-RVA: 0x308AE0 Offset: 0x308BE1 VA: 0x308AE0
	|-KeyValuePair<ulong, object>..ctor
	|
	|-RVA: 0x308B20 Offset: 0x308C21 VA: 0x308B20
	|-KeyValuePair<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x308B60 Offset: 0x308C61 VA: 0x308B60
	|-KeyValuePair<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x308C00 Offset: 0x308D01 VA: 0x308C00
	|-KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x308C90 Offset: 0x308D91 VA: 0x308C90
	|-KeyValuePair<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x308D10 Offset: 0x308E11 VA: 0x308D10
	|-KeyValuePair<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x308D50 Offset: 0x308E51 VA: 0x308D50
	|-KeyValuePair<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x308D90 Offset: 0x308E91 VA: 0x308D90
	|-KeyValuePair<Bounds, object>..ctor
	|
	|-RVA: 0x308DF0 Offset: 0x308EF1 VA: 0x308DF0
	|-KeyValuePair<BoundsInt, object>..ctor
	|
	|-RVA: 0x308E50 Offset: 0x308F51 VA: 0x308E50
	|-KeyValuePair<Color, object>..ctor
	|
	|-RVA: 0x308EA0 Offset: 0x308FA1 VA: 0x308EA0
	|-KeyValuePair<Color32, object>..ctor
	|
	|-RVA: 0x308EE0 Offset: 0x308FE1 VA: 0x308EE0
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x308F20 Offset: 0x309021 VA: 0x308F20
	|-KeyValuePair<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x308F60 Offset: 0x309061 VA: 0x308F60
	|-KeyValuePair<GradientColorKey, object>..ctor
	|
	|-RVA: 0x308FC0 Offset: 0x3090C1 VA: 0x308FC0
	|-KeyValuePair<Keyframe, object>..ctor
	|
	|-RVA: 0x309030 Offset: 0x309131 VA: 0x309030
	|-KeyValuePair<LayerMask, object>..ctor
	|
	|-RVA: 0x309070 Offset: 0x309171 VA: 0x309070
	|-KeyValuePair<Matrix4x4, object>..ctor
	|
	|-RVA: 0x309100 Offset: 0x309201 VA: 0x309100
	|-KeyValuePair<IntVec3, object>..ctor
	|
	|-RVA: 0x309150 Offset: 0x309251 VA: 0x309150
	|-KeyValuePair<Quaternion, object>..ctor
	|
	|-RVA: 0x3091A0 Offset: 0x3092A1 VA: 0x3091A0
	|-KeyValuePair<RangeInt, object>..ctor
	|
	|-RVA: 0x3091E0 Offset: 0x3092E1 VA: 0x3091E0
	|-KeyValuePair<Rect, object>..ctor
	|
	|-RVA: 0x309230 Offset: 0x309331 VA: 0x309230
	|-KeyValuePair<RectInt, object>..ctor
	|
	|-RVA: 0x309270 Offset: 0x309371 VA: 0x309270
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x3092B0 Offset: 0x3093B1 VA: 0x3092B0
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x3092F0 Offset: 0x3093F1 VA: 0x3092F0
	|-KeyValuePair<Vector2, object>..ctor
	|
	|-RVA: 0x309330 Offset: 0x309431 VA: 0x309330
	|-KeyValuePair<Vector2Int, object>..ctor
	|
	|-RVA: 0x309370 Offset: 0x309471 VA: 0x309370
	|-KeyValuePair<Vector3, object>..ctor
	|
	|-RVA: 0x3093C0 Offset: 0x3094C1 VA: 0x3093C0
	|-KeyValuePair<Vector3Int, object>..ctor
	|
	|-RVA: 0x309410 Offset: 0x309511 VA: 0x309410
	|-KeyValuePair<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3078E0 Offset: 0x3079E1 VA: 0x3078E0
	|-KeyValuePair<SharedVariable, object>.get_Key
	|-KeyValuePair<CharacterBase, DamageTextController>.get_Key
	|-KeyValuePair<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.get_Key
	|-KeyValuePair<OptionDefinition, OptionsControlBase>.get_Key
	|-KeyValuePair<byte[], Encoding>.get_Key
	|-KeyValuePair<int[], Terrain>.get_Key
	|-KeyValuePair<string, BehaviorManager.TaskAddData.OverrideFieldValue>.get_Key
	|-KeyValuePair<string, ObjectSerializationInfo.EmittableMember>.get_Key
	|-KeyValuePair<string, InfoBlock>.get_Key
	|-KeyValuePair<string, SeasonTextureData>.get_Key
	|-KeyValuePair<string, IList<InfoEntry>>.get_Key
	|-KeyValuePair<string, List<OptionDefinition>>.get_Key
	|-KeyValuePair<string, object>.get_Key
	|-KeyValuePair<string, ResourceLocationBase>.get_Key
	|-KeyValuePair<TimeParamTable, HashSet<ObjectChangeTime>>.get_Key
	|-KeyValuePair<TimeParamTable, HashSet<RendererChangeTime>>.get_Key
	|-KeyValuePair<TimeParamTable, HashSet<Material>>.get_Key
	|-KeyValuePair<AnimationClip, AnimationClip>.get_Key
	|-KeyValuePair<Collider, CharacterNearCullingController>.get_Key
	|-KeyValuePair<GameObject, Material[]>.get_Key
	|-KeyValuePair<GameObject, Renderer[]>.get_Key
	|-KeyValuePair<Transform, UpdateTracker.UpdateStatus>.get_Key
	|-KeyValuePair<Transform, List<SpringBone>>.get_Key
	|-KeyValuePair<object, object>.get_Key
	|
	|-RVA: 0x305B70 Offset: 0x305C71 VA: 0x305B70
	|-KeyValuePair<BadStatus, BadStatusEffectController.ObjInfo>.get_Key
	|-KeyValuePair<EnvironmentSoundType, List<EnvironmentSoundDataTable>>.get_Key
	|-KeyValuePair<EquipSlotType, AS_ToolController.ToolActionData>.get_Key
	|-KeyValuePair<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.get_Key
	|-KeyValuePair<SoundID, EnvironmentSoundDataTable>.get_Key
	|-KeyValuePair<SoundID, EnvironmentSoundController>.get_Key
	|-KeyValuePair<Int32Enum, object>.get_Key
	|
	|-RVA: 0x305B30 Offset: 0x305C31 VA: 0x305B30
	|-KeyValuePair<EmotionType, Prefab>.get_Key
	|-KeyValuePair<Int32Enum, Int32Enum>.get_Key
	|
	|-RVA: 0x305AF0 Offset: 0x305BF1 VA: 0x305AF0
	|-KeyValuePair<FarmManager.FARM_ID, int>.get_Key
	|-KeyValuePair<Int32Enum, int>.get_Key
	|
	|-RVA: 0x306D50 Offset: 0x306E51 VA: 0x306D50
	|-KeyValuePair<MonsterControllerBase, int>.get_Key
	|-KeyValuePair<object, int>.get_Key
	|
	|-RVA: 0x3056E0 Offset: 0x3057E1 VA: 0x3056E0
	|-KeyValuePair<int, FishSwim>.get_Key
	|-KeyValuePair<int, OnGroundItem>.get_Key
	|-KeyValuePair<int, List<MeshDataConnectivity.Face>>.get_Key
	|-KeyValuePair<int, string>.get_Key
	|-KeyValuePair<int, PointerEventData>.get_Key
	|-KeyValuePair<int, TerrainUtility.TerrainMap>.get_Key
	|-KeyValuePair<int, object>.get_Key
	|
	|-RVA: 0x305620 Offset: 0x305721 VA: 0x305620
	|-KeyValuePair<int, int>.get_Key
	|
	|-RVA: 0x305890 Offset: 0x305991 VA: 0x305890
	|-KeyValuePair<int, Vector3>.get_Key
	|
	|-RVA: 0x308D20 Offset: 0x308E21 VA: 0x308D20
	|-KeyValuePair<MeshDataConnectivity.Face, bool>.get_Key
	|
	|-RVA: 0x308D60 Offset: 0x308E61 VA: 0x308D60
	|-KeyValuePair<MeshDataConnectivity.Face, List<int>>.get_Key
	|-KeyValuePair<MeshDataConnectivity.Face, object>.get_Key
	|
	|-RVA: 0x308EF0 Offset: 0x308FF1 VA: 0x308EF0
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Key
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>.get_Key
	|
	|-RVA: 0x304C80 Offset: 0x304D81 VA: 0x304C80
	|-KeyValuePair<JSONDeserialization.TaskField, object>.get_Key
	|
	|-RVA: 0x304CC0 Offset: 0x304DC1 VA: 0x304CC0
	|-KeyValuePair<BitVector32Int, object>.get_Key
	|
	|-RVA: 0x304D40 Offset: 0x304E41 VA: 0x304D40
	|-KeyValuePair<EventCheckId, object>.get_Key
	|
	|-RVA: 0x304DC0 Offset: 0x304EC1 VA: 0x304DC0
	|-KeyValuePair<FarmManager.RF4_CROP_STATE, object>.get_Key
	|
	|-RVA: 0x304E30 Offset: 0x304F31 VA: 0x304E30
	|-KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>.get_Key
	|
	|-RVA: 0x304E90 Offset: 0x304F91 VA: 0x304E90
	|-KeyValuePair<FarmManager.RF4_MCROP_INFO, object>.get_Key
	|
	|-RVA: 0x304ED0 Offset: 0x304FD1 VA: 0x304ED0
	|-KeyValuePair<FarmManager.RF4_SOIL_INFO, object>.get_Key
	|
	|-RVA: 0x304F50 Offset: 0x305051 VA: 0x304F50
	|-KeyValuePair<MonsterHutSaveData, object>.get_Key
	|
	|-RVA: 0x304FB0 Offset: 0x3050B1 VA: 0x304FB0
	|-KeyValuePair<OrderLotterySaveParameter, object>.get_Key
	|
	|-RVA: 0x305030 Offset: 0x305131 VA: 0x305030
	|-KeyValuePair<OrderSaveData, object>.get_Key
	|
	|-RVA: 0x3050C0 Offset: 0x3051C1 VA: 0x3050C0
	|-KeyValuePair<OrderSaveParameter, object>.get_Key
	|
	|-RVA: 0x305140 Offset: 0x305241 VA: 0x305140
	|-KeyValuePair<Parameter, object>.get_Key
	|
	|-RVA: 0x305190 Offset: 0x305291 VA: 0x305190
	|-KeyValuePair<bool, object>.get_Key
	|
	|-RVA: 0x3051D0 Offset: 0x3052D1 VA: 0x3051D0
	|-KeyValuePair<byte, object>.get_Key
	|
	|-RVA: 0x305210 Offset: 0x305311 VA: 0x305210
	|-KeyValuePair<char, object>.get_Key
	|
	|-RVA: 0x305250 Offset: 0x305351 VA: 0x305250
	|-KeyValuePair<DateTime, object>.get_Key
	|-KeyValuePair<DateTime, TimeType>.get_Key
	|
	|-RVA: 0x305290 Offset: 0x305391 VA: 0x305290
	|-KeyValuePair<double, object>.get_Key
	|
	|-RVA: 0x3052D0 Offset: 0x3053D1 VA: 0x3052D0
	|-KeyValuePair<Guid, object>.get_Key
	|
	|-RVA: 0x305310 Offset: 0x305411 VA: 0x305310
	|-KeyValuePair<short, object>.get_Key
	|
	|-RVA: 0x3053A0 Offset: 0x3054A1 VA: 0x3053A0
	|-KeyValuePair<int, CropDataTable>.get_Key
	|
	|-RVA: 0x305410 Offset: 0x305511 VA: 0x305410
	|-KeyValuePair<int, EffectDataTable>.get_Key
	|
	|-RVA: 0x305460 Offset: 0x305561 VA: 0x305460
	|-KeyValuePair<int, GimmickLayoutDataTable>.get_Key
	|
	|-RVA: 0x3054F0 Offset: 0x3055F1 VA: 0x3054F0
	|-KeyValuePair<int, MineTypeDataTable>.get_Key
	|
	|-RVA: 0x305560 Offset: 0x305661 VA: 0x305560
	|-KeyValuePair<int, MiningDataTable>.get_Key
	|
	|-RVA: 0x3055A0 Offset: 0x3056A1 VA: 0x3055A0
	|-KeyValuePair<int, bool>.get_Key
	|
	|-RVA: 0x3055E0 Offset: 0x3056E1 VA: 0x3055E0
	|-KeyValuePair<int, char>.get_Key
	|
	|-RVA: 0x305660 Offset: 0x305761 VA: 0x305660
	|-KeyValuePair<int, Int32Enum>.get_Key
	|
	|-RVA: 0x3056A0 Offset: 0x3057A1 VA: 0x3056A0
	|-KeyValuePair<int, long>.get_Key
	|
	|-RVA: 0x305720 Offset: 0x305821 VA: 0x305720
	|-KeyValuePair<int, uint>.get_Key
	|
	|-RVA: 0x3057A0 Offset: 0x3058A1 VA: 0x3057A0
	|-KeyValuePair<int, DiagnosticEvent>.get_Key
	|
	|-RVA: 0x305800 Offset: 0x305901 VA: 0x305800
	|-KeyValuePair<int, SceneInstance>.get_Key
	|
	|-RVA: 0x305840 Offset: 0x305941 VA: 0x305840
	|-KeyValuePair<int, Vector2Int>.get_Key
	|
	|-RVA: 0x305920 Offset: 0x305A21 VA: 0x305920
	|-KeyValuePair<Int32Enum, MonsterDataTable>.get_Key
	|
	|-RVA: 0x3059A0 Offset: 0x305AA1 VA: 0x3059A0
	|-KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>.get_Key
	|
	|-RVA: 0x3059F0 Offset: 0x305AF1 VA: 0x3059F0
	|-KeyValuePair<Int32Enum, MonsterSearchRangeParameter>.get_Key
	|
	|-RVA: 0x305A30 Offset: 0x305B31 VA: 0x305A30
	|-KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Key
	|
	|-RVA: 0x305A70 Offset: 0x305B71 VA: 0x305A70
	|-KeyValuePair<Int32Enum, bool>.get_Key
	|
	|-RVA: 0x305AB0 Offset: 0x305BB1 VA: 0x305AB0
	|-KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Key
	|
	|-RVA: 0x305BB0 Offset: 0x305CB1 VA: 0x305BB0
	|-KeyValuePair<Int32Enum, float>.get_Key
	|
	|-RVA: 0x305C00 Offset: 0x305D01 VA: 0x305C00
	|-KeyValuePair<Int32Enum, ValueTuple<object, object>>.get_Key
	|
	|-RVA: 0x305C40 Offset: 0x305D41 VA: 0x305C40
	|-KeyValuePair<Int32Enum, ValueTuple<float, float>>.get_Key
	|
	|-RVA: 0x305C80 Offset: 0x305D81 VA: 0x305C80
	|-KeyValuePair<Int32Enum, TutorialUnlockFlagData>.get_Key
	|
	|-RVA: 0x305CC0 Offset: 0x305DC1 VA: 0x305CC0
	|-KeyValuePair<long, object>.get_Key
	|
	|-RVA: 0x305D30 Offset: 0x305E31 VA: 0x305D30
	|-KeyValuePair<Memory<object>, object>.get_Key
	|
	|-RVA: 0x305D70 Offset: 0x305E71 VA: 0x305D70
	|-KeyValuePair<Nullable<Int32Enum>, object>.get_Key
	|
	|-RVA: 0x305DD0 Offset: 0x305ED1 VA: 0x305DD0
	|-KeyValuePair<Nullable<Bounds>, object>.get_Key
	|
	|-RVA: 0x305E40 Offset: 0x305F41 VA: 0x305E40
	|-KeyValuePair<Nullable<BoundsInt>, object>.get_Key
	|
	|-RVA: 0x305E90 Offset: 0x305F91 VA: 0x305E90
	|-KeyValuePair<Nullable<Color32>, object>.get_Key
	|
	|-RVA: 0x305EE0 Offset: 0x305FE1 VA: 0x305EE0
	|-KeyValuePair<Nullable<Color>, object>.get_Key
	|
	|-RVA: 0x305F40 Offset: 0x306041 VA: 0x305F40
	|-KeyValuePair<Nullable<GradientAlphaKey>, object>.get_Key
	|
	|-RVA: 0x305F90 Offset: 0x306091 VA: 0x305F90
	|-KeyValuePair<Nullable<GradientColorKey>, object>.get_Key
	|
	|-RVA: 0x305FF0 Offset: 0x3060F1 VA: 0x305FF0
	|-KeyValuePair<Nullable<Keyframe>, object>.get_Key
	|
	|-RVA: 0x306040 Offset: 0x306141 VA: 0x306040
	|-KeyValuePair<Nullable<LayerMask>, object>.get_Key
	|
	|-RVA: 0x3060B0 Offset: 0x3061B1 VA: 0x3060B0
	|-KeyValuePair<Nullable<Matrix4x4>, object>.get_Key
	|
	|-RVA: 0x306130 Offset: 0x306231 VA: 0x306130
	|-KeyValuePair<Nullable<Quaternion>, object>.get_Key
	|
	|-RVA: 0x306190 Offset: 0x306291 VA: 0x306190
	|-KeyValuePair<Nullable<RangeInt>, object>.get_Key
	|
	|-RVA: 0x3061E0 Offset: 0x3062E1 VA: 0x3061E0
	|-KeyValuePair<Nullable<Rect>, object>.get_Key
	|
	|-RVA: 0x306240 Offset: 0x306341 VA: 0x306240
	|-KeyValuePair<Nullable<RectInt>, object>.get_Key
	|
	|-RVA: 0x3062A0 Offset: 0x3063A1 VA: 0x3062A0
	|-KeyValuePair<Nullable<Vector2>, object>.get_Key
	|
	|-RVA: 0x3062F0 Offset: 0x3063F1 VA: 0x3062F0
	|-KeyValuePair<Nullable<Vector2Int>, object>.get_Key
	|
	|-RVA: 0x306330 Offset: 0x306431 VA: 0x306330
	|-KeyValuePair<Nullable<Vector3>, object>.get_Key
	|
	|-RVA: 0x306370 Offset: 0x306471 VA: 0x306370
	|-KeyValuePair<Nullable<Vector3Int>, object>.get_Key
	|
	|-RVA: 0x3063C0 Offset: 0x3064C1 VA: 0x3063C0
	|-KeyValuePair<Nullable<Vector4>, object>.get_Key
	|
	|-RVA: 0x306430 Offset: 0x306531 VA: 0x306430
	|-KeyValuePair<object, BitVector32Int>.get_Key
	|
	|-RVA: 0x3064C0 Offset: 0x3065C1 VA: 0x3064C0
	|-KeyValuePair<object, EventCheckId>.get_Key
	|
	|-RVA: 0x306580 Offset: 0x306681 VA: 0x306580
	|-KeyValuePair<object, FarmManager.RF4_CROP_STATE>.get_Key
	|
	|-RVA: 0x306620 Offset: 0x306721 VA: 0x306620
	|-KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>.get_Key
	|
	|-RVA: 0x3066A0 Offset: 0x3067A1 VA: 0x3066A0
	|-KeyValuePair<object, FarmManager.RF4_MCROP_INFO>.get_Key
	|
	|-RVA: 0x306710 Offset: 0x306811 VA: 0x306710
	|-KeyValuePair<object, FarmManager.RF4_SOIL_INFO>.get_Key
	|
	|-RVA: 0x3067B0 Offset: 0x3068B1 VA: 0x3067B0
	|-KeyValuePair<object, MonsterHutSaveData>.get_Key
	|
	|-RVA: 0x306830 Offset: 0x306931 VA: 0x306830
	|-KeyValuePair<object, OrderLotterySaveParameter>.get_Key
	|
	|-RVA: 0x3068D0 Offset: 0x3069D1 VA: 0x3068D0
	|-KeyValuePair<object, OrderSaveData>.get_Key
	|
	|-RVA: 0x306970 Offset: 0x306A71 VA: 0x306970
	|-KeyValuePair<object, OrderSaveParameter>.get_Key
	|
	|-RVA: 0x306A20 Offset: 0x306B21 VA: 0x306A20
	|-KeyValuePair<object, Parameter>.get_Key
	|
	|-RVA: 0x306A90 Offset: 0x306B91 VA: 0x306A90
	|-KeyValuePair<object, NumberControl.ValueRange>.get_Key
	|
	|-RVA: 0x306B00 Offset: 0x306C01 VA: 0x306B00
	|-KeyValuePair<object, bool>.get_Key
	|
	|-RVA: 0x306B60 Offset: 0x306C61 VA: 0x306B60
	|-KeyValuePair<object, byte>.get_Key
	|
	|-RVA: 0x306BC0 Offset: 0x306CC1 VA: 0x306BC0
	|-KeyValuePair<object, char>.get_Key
	|
	|-RVA: 0x306C20 Offset: 0x306D21 VA: 0x306C20
	|-KeyValuePair<object, DateTime>.get_Key
	|
	|-RVA: 0x306C90 Offset: 0x306D91 VA: 0x306C90
	|-KeyValuePair<object, double>.get_Key
	|
	|-RVA: 0x306CF0 Offset: 0x306DF1 VA: 0x306CF0
	|-KeyValuePair<object, short>.get_Key
	|
	|-RVA: 0x306DB0 Offset: 0x306EB1 VA: 0x306DB0
	|-KeyValuePair<object, Int32Enum>.get_Key
	|
	|-RVA: 0x306E10 Offset: 0x306F11 VA: 0x306E10
	|-KeyValuePair<object, long>.get_Key
	|
	|-RVA: 0x306E90 Offset: 0x306F91 VA: 0x306E90
	|-KeyValuePair<object, Memory<object>>.get_Key
	|
	|-RVA: 0x306EF0 Offset: 0x306FF1 VA: 0x306EF0
	|-KeyValuePair<object, Nullable<Int32Enum>>.get_Key
	|
	|-RVA: 0x306F80 Offset: 0x307081 VA: 0x306F80
	|-KeyValuePair<object, Nullable<Bounds>>.get_Key
	|
	|-RVA: 0x307020 Offset: 0x307121 VA: 0x307020
	|-KeyValuePair<object, Nullable<BoundsInt>>.get_Key
	|
	|-RVA: 0x307090 Offset: 0x307191 VA: 0x307090
	|-KeyValuePair<object, Nullable<Color32>>.get_Key
	|
	|-RVA: 0x307110 Offset: 0x307211 VA: 0x307110
	|-KeyValuePair<object, Nullable<Color>>.get_Key
	|
	|-RVA: 0x307190 Offset: 0x307291 VA: 0x307190
	|-KeyValuePair<object, Nullable<GradientAlphaKey>>.get_Key
	|
	|-RVA: 0x307210 Offset: 0x307311 VA: 0x307210
	|-KeyValuePair<object, Nullable<GradientColorKey>>.get_Key
	|
	|-RVA: 0x3072A0 Offset: 0x3073A1 VA: 0x3072A0
	|-KeyValuePair<object, Nullable<Keyframe>>.get_Key
	|
	|-RVA: 0x307310 Offset: 0x307411 VA: 0x307310
	|-KeyValuePair<object, Nullable<LayerMask>>.get_Key
	|
	|-RVA: 0x3073D0 Offset: 0x3074D1 VA: 0x3073D0
	|-KeyValuePair<object, Nullable<Matrix4x4>>.get_Key
	|
	|-RVA: 0x307480 Offset: 0x307581 VA: 0x307480
	|-KeyValuePair<object, Nullable<Quaternion>>.get_Key
	|
	|-RVA: 0x307500 Offset: 0x307601 VA: 0x307500
	|-KeyValuePair<object, Nullable<RangeInt>>.get_Key
	|
	|-RVA: 0x307580 Offset: 0x307681 VA: 0x307580
	|-KeyValuePair<object, Nullable<Rect>>.get_Key
	|
	|-RVA: 0x307610 Offset: 0x307711 VA: 0x307610
	|-KeyValuePair<object, Nullable<RectInt>>.get_Key
	|
	|-RVA: 0x307690 Offset: 0x307791 VA: 0x307690
	|-KeyValuePair<object, Nullable<Vector2>>.get_Key
	|
	|-RVA: 0x307700 Offset: 0x307801 VA: 0x307700
	|-KeyValuePair<object, Nullable<Vector2Int>>.get_Key
	|
	|-RVA: 0x307770 Offset: 0x307871 VA: 0x307770
	|-KeyValuePair<object, Nullable<Vector3>>.get_Key
	|
	|-RVA: 0x3077E0 Offset: 0x3078E1 VA: 0x3077E0
	|-KeyValuePair<object, Nullable<Vector3Int>>.get_Key
	|
	|-RVA: 0x307860 Offset: 0x307961 VA: 0x307860
	|-KeyValuePair<object, Nullable<Vector4>>.get_Key
	|
	|-RVA: 0x3079A0 Offset: 0x307AA1 VA: 0x3079A0
	|-KeyValuePair<object, ReadOnlyMemory<object>>.get_Key
	|
	|-RVA: 0x307A20 Offset: 0x307B21 VA: 0x307A20
	|-KeyValuePair<object, ResourceLocator>.get_Key
	|
	|-RVA: 0x307A80 Offset: 0x307B81 VA: 0x307A80
	|-KeyValuePair<object, sbyte>.get_Key
	|
	|-RVA: 0x307AF0 Offset: 0x307BF1 VA: 0x307AF0
	|-KeyValuePair<object, float>.get_Key
	|
	|-RVA: 0x307B50 Offset: 0x307C51 VA: 0x307B50
	|-KeyValuePair<object, ushort>.get_Key
	|
	|-RVA: 0x307BB0 Offset: 0x307CB1 VA: 0x307BB0
	|-KeyValuePair<object, uint>.get_Key
	|
	|-RVA: 0x307C10 Offset: 0x307D11 VA: 0x307C10
	|-KeyValuePair<object, ulong>.get_Key
	|
	|-RVA: 0x307CA0 Offset: 0x307DA1 VA: 0x307CA0
	|-KeyValuePair<object, TransitionTables>.get_Key
	|
	|-RVA: 0x307D30 Offset: 0x307E31 VA: 0x307D30
	|-KeyValuePair<object, Bounds>.get_Key
	|
	|-RVA: 0x307DC0 Offset: 0x307EC1 VA: 0x307DC0
	|-KeyValuePair<object, BoundsInt>.get_Key
	|
	|-RVA: 0x307E30 Offset: 0x307F31 VA: 0x307E30
	|-KeyValuePair<object, Color32>.get_Key
	|
	|-RVA: 0x307EC0 Offset: 0x307FC1 VA: 0x307EC0
	|-KeyValuePair<object, Color>.get_Key
	|
	|-RVA: 0x307F30 Offset: 0x308031 VA: 0x307F30
	|-KeyValuePair<object, GradientAlphaKey>.get_Key
	|
	|-RVA: 0x307FB0 Offset: 0x3080B1 VA: 0x307FB0
	|-KeyValuePair<object, GradientColorKey>.get_Key
	|
	|-RVA: 0x308050 Offset: 0x308151 VA: 0x308050
	|-KeyValuePair<object, Keyframe>.get_Key
	|
	|-RVA: 0x3080C0 Offset: 0x3081C1 VA: 0x3080C0
	|-KeyValuePair<object, LayerMask>.get_Key
	|
	|-RVA: 0x308160 Offset: 0x308261 VA: 0x308160
	|-KeyValuePair<object, Matrix4x4>.get_Key
	|
	|-RVA: 0x3081F0 Offset: 0x3082F1 VA: 0x3081F0
	|-KeyValuePair<object, Playable>.get_Key
	|
	|-RVA: 0x308280 Offset: 0x308381 VA: 0x308280
	|-KeyValuePair<object, Quaternion>.get_Key
	|
	|-RVA: 0x3082E0 Offset: 0x3083E1 VA: 0x3082E0
	|-KeyValuePair<object, RangeInt>.get_Key
	|
	|-RVA: 0x308370 Offset: 0x308471 VA: 0x308370
	|-KeyValuePair<object, Rect>.get_Key
	|
	|-RVA: 0x3083E0 Offset: 0x3084E1 VA: 0x3083E0
	|-KeyValuePair<object, RectInt>.get_Key
	|
	|-RVA: 0x308470 Offset: 0x308571 VA: 0x308470
	|-KeyValuePair<object, AsyncOperationHandle>.get_Key
	|
	|-RVA: 0x308510 Offset: 0x308611 VA: 0x308510
	|-KeyValuePair<object, AsyncOperationHandle<object>>.get_Key
	|
	|-RVA: 0x308590 Offset: 0x308691 VA: 0x308590
	|-KeyValuePair<object, Vector2>.get_Key
	|
	|-RVA: 0x3085F0 Offset: 0x3086F1 VA: 0x3085F0
	|-KeyValuePair<object, Vector2Int>.get_Key
	|
	|-RVA: 0x308670 Offset: 0x308771 VA: 0x308670
	|-KeyValuePair<object, Vector3>.get_Key
	|
	|-RVA: 0x3086E0 Offset: 0x3087E1 VA: 0x3086E0
	|-KeyValuePair<object, Vector3Int>.get_Key
	|
	|-RVA: 0x308770 Offset: 0x308871 VA: 0x308770
	|-KeyValuePair<object, Vector4>.get_Key
	|
	|-RVA: 0x3087E0 Offset: 0x3088E1 VA: 0x3087E0
	|-KeyValuePair<ReadOnlyMemory<object>, object>.get_Key
	|
	|-RVA: 0x308820 Offset: 0x308921 VA: 0x308820
	|-KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Key
	|
	|-RVA: 0x308860 Offset: 0x308961 VA: 0x308860
	|-KeyValuePair<sbyte, object>.get_Key
	|
	|-RVA: 0x308900 Offset: 0x308A01 VA: 0x308900
	|-KeyValuePair<float, CurveSample>.get_Key
	|
	|-RVA: 0x308970 Offset: 0x308A71 VA: 0x308970
	|-KeyValuePair<float, int>.get_Key
	|
	|-RVA: 0x3089B0 Offset: 0x308AB1 VA: 0x3089B0
	|-KeyValuePair<float, object>.get_Key
	|
	|-RVA: 0x3089F0 Offset: 0x308AF1 VA: 0x3089F0
	|-KeyValuePair<ushort, object>.get_Key
	|
	|-RVA: 0x308A30 Offset: 0x308B31 VA: 0x308A30
	|-KeyValuePair<uint, int>.get_Key
	|
	|-RVA: 0x308A70 Offset: 0x308B71 VA: 0x308A70
	|-KeyValuePair<uint, Int32Enum>.get_Key
	|
	|-RVA: 0x308AB0 Offset: 0x308BB1 VA: 0x308AB0
	|-KeyValuePair<uint, object>.get_Key
	|
	|-RVA: 0x308AF0 Offset: 0x308BF1 VA: 0x308AF0
	|-KeyValuePair<ulong, object>.get_Key
	|
	|-RVA: 0x308B30 Offset: 0x308C31 VA: 0x308B30
	|-KeyValuePair<EdgeKeyByHash, int>.get_Key
	|
	|-RVA: 0x308BB0 Offset: 0x308CB1 VA: 0x308BB0
	|-KeyValuePair<EdgeKeyByHash, CapEdge>.get_Key
	|
	|-RVA: 0x308C50 Offset: 0x308D51 VA: 0x308C50
	|-KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Key
	|
	|-RVA: 0x308CD0 Offset: 0x308DD1 VA: 0x308CD0
	|-KeyValuePair<EdgeKeyByIndex, ClippedEdge>.get_Key
	|
	|-RVA: 0x308DB0 Offset: 0x308EB1 VA: 0x308DB0
	|-KeyValuePair<Bounds, object>.get_Key
	|
	|-RVA: 0x308E10 Offset: 0x308F11 VA: 0x308E10
	|-KeyValuePair<BoundsInt, object>.get_Key
	|
	|-RVA: 0x308E70 Offset: 0x308F71 VA: 0x308E70
	|-KeyValuePair<Color, object>.get_Key
	|
	|-RVA: 0x308EB0 Offset: 0x308FB1 VA: 0x308EB0
	|-KeyValuePair<Color32, object>.get_Key
	|
	|-RVA: 0x308F30 Offset: 0x309031 VA: 0x308F30
	|-KeyValuePair<GradientAlphaKey, object>.get_Key
	|
	|-RVA: 0x308F80 Offset: 0x309081 VA: 0x308F80
	|-KeyValuePair<GradientColorKey, object>.get_Key
	|
	|-RVA: 0x308FF0 Offset: 0x3090F1 VA: 0x308FF0
	|-KeyValuePair<Keyframe, object>.get_Key
	|
	|-RVA: 0x309040 Offset: 0x309141 VA: 0x309040
	|-KeyValuePair<LayerMask, object>.get_Key
	|
	|-RVA: 0x3090B0 Offset: 0x3091B1 VA: 0x3090B0
	|-KeyValuePair<Matrix4x4, object>.get_Key
	|
	|-RVA: 0x309120 Offset: 0x309221 VA: 0x309120
	|-KeyValuePair<IntVec3, object>.get_Key
	|
	|-RVA: 0x309170 Offset: 0x309271 VA: 0x309170
	|-KeyValuePair<Quaternion, object>.get_Key
	|
	|-RVA: 0x3091B0 Offset: 0x3092B1 VA: 0x3091B0
	|-KeyValuePair<RangeInt, object>.get_Key
	|
	|-RVA: 0x309200 Offset: 0x309301 VA: 0x309200
	|-KeyValuePair<Rect, object>.get_Key
	|
	|-RVA: 0x309240 Offset: 0x309341 VA: 0x309240
	|-KeyValuePair<RectInt, object>.get_Key
	|
	|-RVA: 0x309280 Offset: 0x309381 VA: 0x309280
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, int>.get_Key
	|
	|-RVA: 0x3092C0 Offset: 0x3093C1 VA: 0x3092C0
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, object>.get_Key
	|
	|-RVA: 0x309300 Offset: 0x309401 VA: 0x309300
	|-KeyValuePair<Vector2, object>.get_Key
	|
	|-RVA: 0x309340 Offset: 0x309441 VA: 0x309340
	|-KeyValuePair<Vector2Int, object>.get_Key
	|
	|-RVA: 0x309390 Offset: 0x309491 VA: 0x309390
	|-KeyValuePair<Vector3, object>.get_Key
	|
	|-RVA: 0x3093E0 Offset: 0x3094E1 VA: 0x3093E0
	|-KeyValuePair<Vector3Int, object>.get_Key
	|
	|-RVA: 0x309430 Offset: 0x309531 VA: 0x309430
	|-KeyValuePair<Vector4, object>.get_Key
	*/

	// RVA: -1 Offset: -1
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3078F0 Offset: 0x3079F1 VA: 0x3078F0
	|-KeyValuePair<SharedVariable, object>.get_Value
	|-KeyValuePair<CharacterBase, DamageTextController>.get_Value
	|-KeyValuePair<ICinemachineCamera, object>.get_Value
	|-KeyValuePair<OptionDefinition, OptionsControlBase>.get_Value
	|-KeyValuePair<byte[], Encoding>.get_Value
	|-KeyValuePair<int[], SceneSplit>.get_Value
	|-KeyValuePair<int[], Terrain>.get_Value
	|-KeyValuePair<LabelTarget, LabelInfo>.get_Value
	|-KeyValuePair<string, BehaviorManager.TaskAddData.OverrideFieldValue>.get_Value
	|-KeyValuePair<string, Texture[]>.get_Value
	|-KeyValuePair<string, ObjectSerializationInfo.EmittableMember>.get_Value
	|-KeyValuePair<string, InfoBlock>.get_Value
	|-KeyValuePair<string, SeasonTextureData>.get_Value
	|-KeyValuePair<string, IList<InfoEntry>>.get_Value
	|-KeyValuePair<string, List<TaskCoroutine>>.get_Value
	|-KeyValuePair<string, List<OptionDefinition>>.get_Value
	|-KeyValuePair<string, object>.get_Value
	|-KeyValuePair<string, ResourceLocationBase>.get_Value
	|-KeyValuePair<TimeParamTable, HashSet<ObjectChangeTime>>.get_Value
	|-KeyValuePair<TimeParamTable, HashSet<RendererChangeTime>>.get_Value
	|-KeyValuePair<TimeParamTable, HashSet<Material>>.get_Value
	|-KeyValuePair<AnimationClip, AnimationClip>.get_Value
	|-KeyValuePair<Camera, Camera>.get_Value
	|-KeyValuePair<Collider, CharacterNearCullingController>.get_Value
	|-KeyValuePair<GameObject, Material[]>.get_Value
	|-KeyValuePair<GameObject, Renderer[]>.get_Value
	|-KeyValuePair<Transform, TargetPositionCache.CacheEntry>.get_Value
	|-KeyValuePair<Transform, UpdateTracker.UpdateStatus>.get_Value
	|-KeyValuePair<Transform, List<SpringBone>>.get_Value
	|-KeyValuePair<object, object>.get_Value
	|-KeyValuePair<string, string>.get_Value
	|
	|-RVA: 0x305B80 Offset: 0x305C81 VA: 0x305B80
	|-KeyValuePair<BadStatus, BadStatusEffectController.ObjInfo>.get_Value
	|-KeyValuePair<VariationNo, HumanData>.get_Value
	|-KeyValuePair<EnvironmentSoundType, List<EnvironmentSoundDataTable>>.get_Value
	|-KeyValuePair<EquipSlotType, AS_ToolController.ToolActionData>.get_Value
	|-KeyValuePair<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.get_Value
	|-KeyValuePair<SoundID, EnvironmentSoundDataTable>.get_Value
	|-KeyValuePair<SoundID, EnvironmentSoundController>.get_Value
	|-KeyValuePair<Int32Enum, object>.get_Value
	|
	|-RVA: 0x305B40 Offset: 0x305C41 VA: 0x305B40
	|-KeyValuePair<EmotionType, Prefab>.get_Value
	|-KeyValuePair<Int32Enum, Int32Enum>.get_Value
	|
	|-RVA: 0x305B00 Offset: 0x305C01 VA: 0x305B00
	|-KeyValuePair<FarmManager.FARM_ID, int>.get_Value
	|-KeyValuePair<Int32Enum, int>.get_Value
	|
	|-RVA: 0x306D60 Offset: 0x306E61 VA: 0x306D60
	|-KeyValuePair<MonsterControllerBase, int>.get_Value
	|-KeyValuePair<string, int>.get_Value
	|-KeyValuePair<object, int>.get_Value
	|
	|-RVA: 0x305C10 Offset: 0x305D11 VA: 0x305C10
	|-KeyValuePair<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>.get_Value
	|-KeyValuePair<Int32Enum, ValueTuple<object, object>>.get_Value
	|
	|-RVA: 0x3056F0 Offset: 0x3057F1 VA: 0x3056F0
	|-KeyValuePair<int, BossBehaviorController>.get_Value
	|-KeyValuePair<int, FishSwim>.get_Value
	|-KeyValuePair<int, HarinezumiController.NeedleController>.get_Value
	|-KeyValuePair<int, MonsterBehaviorController>.get_Value
	|-KeyValuePair<int, OnGroundItem>.get_Value
	|-KeyValuePair<int, PartnerNPCBehaviorController>.get_Value
	|-KeyValuePair<int, List<MeshDataConnectivity.Face>>.get_Value
	|-KeyValuePair<int, string>.get_Value
	|-KeyValuePair<int, PointerEventData>.get_Value
	|-KeyValuePair<int, TerrainUtility.TerrainMap>.get_Value
	|-KeyValuePair<int, Panel>.get_Value
	|-KeyValuePair<int, object>.get_Value
	|
	|-RVA: 0x305630 Offset: 0x305731 VA: 0x305630
	|-KeyValuePair<int, int>.get_Value
	|
	|-RVA: 0x3058A0 Offset: 0x3059A1 VA: 0x3058A0
	|-KeyValuePair<int, Vector3>.get_Value
	|
	|-RVA: 0x308AC0 Offset: 0x308BC1 VA: 0x308AC0
	|-KeyValuePair<uint, FarmMonsterBehaviorController>.get_Value
	|-KeyValuePair<uint, TriangulationConstraint>.get_Value
	|-KeyValuePair<uint, object>.get_Value
	|
	|-RVA: 0x308D30 Offset: 0x308E31 VA: 0x308D30
	|-KeyValuePair<MeshDataConnectivity.Face, bool>.get_Value
	|
	|-RVA: 0x308D70 Offset: 0x308E71 VA: 0x308D70
	|-KeyValuePair<MeshDataConnectivity.Face, List<int>>.get_Value
	|-KeyValuePair<MeshDataConnectivity.Face, object>.get_Value
	|
	|-RVA: 0x309130 Offset: 0x309231 VA: 0x309130
	|-KeyValuePair<IntVec3, List<int>>.get_Value
	|-KeyValuePair<IntVec3, object>.get_Value
	|
	|-RVA: 0x3093A0 Offset: 0x3094A1 VA: 0x3093A0
	|-KeyValuePair<Vector3, List<int>>.get_Value
	|-KeyValuePair<Vector3, object>.get_Value
	|
	|-RVA: 0x304C90 Offset: 0x304D91 VA: 0x304C90
	|-KeyValuePair<JSONDeserialization.TaskField, object>.get_Value
	|
	|-RVA: 0x304CD0 Offset: 0x304DD1 VA: 0x304CD0
	|-KeyValuePair<BitVector32Int, object>.get_Value
	|
	|-RVA: 0x304D60 Offset: 0x304E61 VA: 0x304D60
	|-KeyValuePair<EventCheckId, object>.get_Value
	|
	|-RVA: 0x304DF0 Offset: 0x304EF1 VA: 0x304DF0
	|-KeyValuePair<FarmManager.RF4_CROP_STATE, object>.get_Value
	|
	|-RVA: 0x304E50 Offset: 0x304F51 VA: 0x304E50
	|-KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>.get_Value
	|
	|-RVA: 0x304EA0 Offset: 0x304FA1 VA: 0x304EA0
	|-KeyValuePair<FarmManager.RF4_MCROP_INFO, object>.get_Value
	|
	|-RVA: 0x304EE0 Offset: 0x304FE1 VA: 0x304EE0
	|-KeyValuePair<FarmManager.RF4_SOIL_INFO, object>.get_Value
	|
	|-RVA: 0x304F70 Offset: 0x305071 VA: 0x304F70
	|-KeyValuePair<MonsterHutSaveData, object>.get_Value
	|
	|-RVA: 0x304FC0 Offset: 0x3050C1 VA: 0x304FC0
	|-KeyValuePair<OrderLotterySaveParameter, object>.get_Value
	|
	|-RVA: 0x305050 Offset: 0x305151 VA: 0x305050
	|-KeyValuePair<OrderSaveData, object>.get_Value
	|
	|-RVA: 0x3050E0 Offset: 0x3051E1 VA: 0x3050E0
	|-KeyValuePair<OrderSaveParameter, object>.get_Value
	|
	|-RVA: 0x305150 Offset: 0x305251 VA: 0x305150
	|-KeyValuePair<Parameter, object>.get_Value
	|
	|-RVA: 0x3051A0 Offset: 0x3052A1 VA: 0x3051A0
	|-KeyValuePair<bool, object>.get_Value
	|
	|-RVA: 0x3051E0 Offset: 0x3052E1 VA: 0x3051E0
	|-KeyValuePair<byte, object>.get_Value
	|
	|-RVA: 0x305220 Offset: 0x305321 VA: 0x305220
	|-KeyValuePair<char, object>.get_Value
	|
	|-RVA: 0x305260 Offset: 0x305361 VA: 0x305260
	|-KeyValuePair<DateTime, object>.get_Value
	|-KeyValuePair<DateTime, TimeType>.get_Value
	|
	|-RVA: 0x3052A0 Offset: 0x3053A1 VA: 0x3052A0
	|-KeyValuePair<double, object>.get_Value
	|
	|-RVA: 0x3052E0 Offset: 0x3053E1 VA: 0x3052E0
	|-KeyValuePair<Guid, object>.get_Value
	|
	|-RVA: 0x305320 Offset: 0x305421 VA: 0x305320
	|-KeyValuePair<short, object>.get_Value
	|
	|-RVA: 0x3053B0 Offset: 0x3054B1 VA: 0x3053B0
	|-KeyValuePair<int, CropDataTable>.get_Value
	|
	|-RVA: 0x305420 Offset: 0x305521 VA: 0x305420
	|-KeyValuePair<int, EffectDataTable>.get_Value
	|
	|-RVA: 0x305470 Offset: 0x305571 VA: 0x305470
	|-KeyValuePair<int, GimmickLayoutDataTable>.get_Value
	|
	|-RVA: 0x305500 Offset: 0x305601 VA: 0x305500
	|-KeyValuePair<int, MineTypeDataTable>.get_Value
	|
	|-RVA: 0x305570 Offset: 0x305671 VA: 0x305570
	|-KeyValuePair<int, MiningDataTable>.get_Value
	|
	|-RVA: 0x3055B0 Offset: 0x3056B1 VA: 0x3055B0
	|-KeyValuePair<int, bool>.get_Value
	|
	|-RVA: 0x3055F0 Offset: 0x3056F1 VA: 0x3055F0
	|-KeyValuePair<int, char>.get_Value
	|
	|-RVA: 0x305670 Offset: 0x305771 VA: 0x305670
	|-KeyValuePair<int, Int32Enum>.get_Value
	|
	|-RVA: 0x3056B0 Offset: 0x3057B1 VA: 0x3056B0
	|-KeyValuePair<int, long>.get_Value
	|
	|-RVA: 0x305730 Offset: 0x305831 VA: 0x305730
	|-KeyValuePair<int, uint>.get_Value
	|
	|-RVA: 0x3057B0 Offset: 0x3058B1 VA: 0x3057B0
	|-KeyValuePair<int, DiagnosticEvent>.get_Value
	|
	|-RVA: 0x305810 Offset: 0x305911 VA: 0x305810
	|-KeyValuePair<int, SceneInstance>.get_Value
	|
	|-RVA: 0x305850 Offset: 0x305951 VA: 0x305850
	|-KeyValuePair<int, Vector2Int>.get_Value
	|
	|-RVA: 0x305930 Offset: 0x305A31 VA: 0x305930
	|-KeyValuePair<Int32Enum, MonsterDataTable>.get_Value
	|
	|-RVA: 0x3059B0 Offset: 0x305AB1 VA: 0x3059B0
	|-KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>.get_Value
	|
	|-RVA: 0x305A00 Offset: 0x305B01 VA: 0x305A00
	|-KeyValuePair<Int32Enum, MonsterSearchRangeParameter>.get_Value
	|
	|-RVA: 0x305A40 Offset: 0x305B41 VA: 0x305A40
	|-KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Value
	|
	|-RVA: 0x305A80 Offset: 0x305B81 VA: 0x305A80
	|-KeyValuePair<Int32Enum, bool>.get_Value
	|
	|-RVA: 0x305AC0 Offset: 0x305BC1 VA: 0x305AC0
	|-KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Value
	|
	|-RVA: 0x305BC0 Offset: 0x305CC1 VA: 0x305BC0
	|-KeyValuePair<Int32Enum, float>.get_Value
	|
	|-RVA: 0x305C50 Offset: 0x305D51 VA: 0x305C50
	|-KeyValuePair<Int32Enum, ValueTuple<float, float>>.get_Value
	|
	|-RVA: 0x305C90 Offset: 0x305D91 VA: 0x305C90
	|-KeyValuePair<Int32Enum, TutorialUnlockFlagData>.get_Value
	|
	|-RVA: 0x305CD0 Offset: 0x305DD1 VA: 0x305CD0
	|-KeyValuePair<long, object>.get_Value
	|
	|-RVA: 0x305D40 Offset: 0x305E41 VA: 0x305D40
	|-KeyValuePair<Memory<object>, object>.get_Value
	|
	|-RVA: 0x305D80 Offset: 0x305E81 VA: 0x305D80
	|-KeyValuePair<Nullable<Int32Enum>, object>.get_Value
	|
	|-RVA: 0x305DF0 Offset: 0x305EF1 VA: 0x305DF0
	|-KeyValuePair<Nullable<Bounds>, object>.get_Value
	|
	|-RVA: 0x305E60 Offset: 0x305F61 VA: 0x305E60
	|-KeyValuePair<Nullable<BoundsInt>, object>.get_Value
	|
	|-RVA: 0x305EA0 Offset: 0x305FA1 VA: 0x305EA0
	|-KeyValuePair<Nullable<Color32>, object>.get_Value
	|
	|-RVA: 0x305F00 Offset: 0x306001 VA: 0x305F00
	|-KeyValuePair<Nullable<Color>, object>.get_Value
	|
	|-RVA: 0x305F50 Offset: 0x306051 VA: 0x305F50
	|-KeyValuePair<Nullable<GradientAlphaKey>, object>.get_Value
	|
	|-RVA: 0x305FB0 Offset: 0x3060B1 VA: 0x305FB0
	|-KeyValuePair<Nullable<GradientColorKey>, object>.get_Value
	|
	|-RVA: 0x306010 Offset: 0x306111 VA: 0x306010
	|-KeyValuePair<Nullable<Keyframe>, object>.get_Value
	|
	|-RVA: 0x306050 Offset: 0x306151 VA: 0x306050
	|-KeyValuePair<Nullable<LayerMask>, object>.get_Value
	|
	|-RVA: 0x3060F0 Offset: 0x3061F1 VA: 0x3060F0
	|-KeyValuePair<Nullable<Matrix4x4>, object>.get_Value
	|
	|-RVA: 0x306150 Offset: 0x306251 VA: 0x306150
	|-KeyValuePair<Nullable<Quaternion>, object>.get_Value
	|
	|-RVA: 0x3061A0 Offset: 0x3062A1 VA: 0x3061A0
	|-KeyValuePair<Nullable<RangeInt>, object>.get_Value
	|
	|-RVA: 0x306200 Offset: 0x306301 VA: 0x306200
	|-KeyValuePair<Nullable<Rect>, object>.get_Value
	|
	|-RVA: 0x306260 Offset: 0x306361 VA: 0x306260
	|-KeyValuePair<Nullable<RectInt>, object>.get_Value
	|
	|-RVA: 0x3062B0 Offset: 0x3063B1 VA: 0x3062B0
	|-KeyValuePair<Nullable<Vector2>, object>.get_Value
	|
	|-RVA: 0x306300 Offset: 0x306401 VA: 0x306300
	|-KeyValuePair<Nullable<Vector2Int>, object>.get_Value
	|
	|-RVA: 0x306340 Offset: 0x306441 VA: 0x306340
	|-KeyValuePair<Nullable<Vector3>, object>.get_Value
	|
	|-RVA: 0x306380 Offset: 0x306481 VA: 0x306380
	|-KeyValuePair<Nullable<Vector3Int>, object>.get_Value
	|
	|-RVA: 0x3063E0 Offset: 0x3064E1 VA: 0x3063E0
	|-KeyValuePair<Nullable<Vector4>, object>.get_Value
	|
	|-RVA: 0x306440 Offset: 0x306541 VA: 0x306440
	|-KeyValuePair<object, BitVector32Int>.get_Value
	|
	|-RVA: 0x3064D0 Offset: 0x3065D1 VA: 0x3064D0
	|-KeyValuePair<object, EventCheckId>.get_Value
	|
	|-RVA: 0x306590 Offset: 0x306691 VA: 0x306590
	|-KeyValuePair<object, FarmManager.RF4_CROP_STATE>.get_Value
	|
	|-RVA: 0x306630 Offset: 0x306731 VA: 0x306630
	|-KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>.get_Value
	|
	|-RVA: 0x3066B0 Offset: 0x3067B1 VA: 0x3066B0
	|-KeyValuePair<object, FarmManager.RF4_MCROP_INFO>.get_Value
	|
	|-RVA: 0x306720 Offset: 0x306821 VA: 0x306720
	|-KeyValuePair<object, FarmManager.RF4_SOIL_INFO>.get_Value
	|
	|-RVA: 0x3067C0 Offset: 0x3068C1 VA: 0x3067C0
	|-KeyValuePair<object, MonsterHutSaveData>.get_Value
	|
	|-RVA: 0x306840 Offset: 0x306941 VA: 0x306840
	|-KeyValuePair<object, OrderLotterySaveParameter>.get_Value
	|
	|-RVA: 0x3068E0 Offset: 0x3069E1 VA: 0x3068E0
	|-KeyValuePair<object, OrderSaveData>.get_Value
	|
	|-RVA: 0x306980 Offset: 0x306A81 VA: 0x306980
	|-KeyValuePair<object, OrderSaveParameter>.get_Value
	|
	|-RVA: 0x306A30 Offset: 0x306B31 VA: 0x306A30
	|-KeyValuePair<object, Parameter>.get_Value
	|
	|-RVA: 0x306AA0 Offset: 0x306BA1 VA: 0x306AA0
	|-KeyValuePair<object, NumberControl.ValueRange>.get_Value
	|
	|-RVA: 0x306B10 Offset: 0x306C11 VA: 0x306B10
	|-KeyValuePair<object, bool>.get_Value
	|
	|-RVA: 0x306B70 Offset: 0x306C71 VA: 0x306B70
	|-KeyValuePair<object, byte>.get_Value
	|
	|-RVA: 0x306BD0 Offset: 0x306CD1 VA: 0x306BD0
	|-KeyValuePair<object, char>.get_Value
	|
	|-RVA: 0x306C30 Offset: 0x306D31 VA: 0x306C30
	|-KeyValuePair<object, DateTime>.get_Value
	|
	|-RVA: 0x306CA0 Offset: 0x306DA1 VA: 0x306CA0
	|-KeyValuePair<object, double>.get_Value
	|
	|-RVA: 0x306D00 Offset: 0x306E01 VA: 0x306D00
	|-KeyValuePair<object, short>.get_Value
	|
	|-RVA: 0x306DC0 Offset: 0x306EC1 VA: 0x306DC0
	|-KeyValuePair<object, Int32Enum>.get_Value
	|
	|-RVA: 0x306E20 Offset: 0x306F21 VA: 0x306E20
	|-KeyValuePair<object, long>.get_Value
	|
	|-RVA: 0x306EA0 Offset: 0x306FA1 VA: 0x306EA0
	|-KeyValuePair<object, Memory<object>>.get_Value
	|
	|-RVA: 0x306F00 Offset: 0x307001 VA: 0x306F00
	|-KeyValuePair<object, Nullable<Int32Enum>>.get_Value
	|
	|-RVA: 0x306F90 Offset: 0x307091 VA: 0x306F90
	|-KeyValuePair<object, Nullable<Bounds>>.get_Value
	|
	|-RVA: 0x307030 Offset: 0x307131 VA: 0x307030
	|-KeyValuePair<object, Nullable<BoundsInt>>.get_Value
	|
	|-RVA: 0x3070A0 Offset: 0x3071A1 VA: 0x3070A0
	|-KeyValuePair<object, Nullable<Color32>>.get_Value
	|
	|-RVA: 0x307120 Offset: 0x307221 VA: 0x307120
	|-KeyValuePair<object, Nullable<Color>>.get_Value
	|
	|-RVA: 0x3071A0 Offset: 0x3072A1 VA: 0x3071A0
	|-KeyValuePair<object, Nullable<GradientAlphaKey>>.get_Value
	|
	|-RVA: 0x307220 Offset: 0x307321 VA: 0x307220
	|-KeyValuePair<object, Nullable<GradientColorKey>>.get_Value
	|
	|-RVA: 0x3072B0 Offset: 0x3073B1 VA: 0x3072B0
	|-KeyValuePair<object, Nullable<Keyframe>>.get_Value
	|
	|-RVA: 0x307320 Offset: 0x307421 VA: 0x307320
	|-KeyValuePair<object, Nullable<LayerMask>>.get_Value
	|
	|-RVA: 0x3073E0 Offset: 0x3074E1 VA: 0x3073E0
	|-KeyValuePair<object, Nullable<Matrix4x4>>.get_Value
	|
	|-RVA: 0x307490 Offset: 0x307591 VA: 0x307490
	|-KeyValuePair<object, Nullable<Quaternion>>.get_Value
	|
	|-RVA: 0x307510 Offset: 0x307611 VA: 0x307510
	|-KeyValuePair<object, Nullable<RangeInt>>.get_Value
	|
	|-RVA: 0x307590 Offset: 0x307691 VA: 0x307590
	|-KeyValuePair<object, Nullable<Rect>>.get_Value
	|
	|-RVA: 0x307620 Offset: 0x307721 VA: 0x307620
	|-KeyValuePair<object, Nullable<RectInt>>.get_Value
	|
	|-RVA: 0x3076A0 Offset: 0x3077A1 VA: 0x3076A0
	|-KeyValuePair<object, Nullable<Vector2>>.get_Value
	|
	|-RVA: 0x307710 Offset: 0x307811 VA: 0x307710
	|-KeyValuePair<object, Nullable<Vector2Int>>.get_Value
	|
	|-RVA: 0x307780 Offset: 0x307881 VA: 0x307780
	|-KeyValuePair<object, Nullable<Vector3>>.get_Value
	|
	|-RVA: 0x3077F0 Offset: 0x3078F1 VA: 0x3077F0
	|-KeyValuePair<object, Nullable<Vector3Int>>.get_Value
	|
	|-RVA: 0x307870 Offset: 0x307971 VA: 0x307870
	|-KeyValuePair<object, Nullable<Vector4>>.get_Value
	|
	|-RVA: 0x3079B0 Offset: 0x307AB1 VA: 0x3079B0
	|-KeyValuePair<object, ReadOnlyMemory<object>>.get_Value
	|
	|-RVA: 0x307A30 Offset: 0x307B31 VA: 0x307A30
	|-KeyValuePair<object, ResourceLocator>.get_Value
	|
	|-RVA: 0x307A90 Offset: 0x307B91 VA: 0x307A90
	|-KeyValuePair<object, sbyte>.get_Value
	|
	|-RVA: 0x307B00 Offset: 0x307C01 VA: 0x307B00
	|-KeyValuePair<object, float>.get_Value
	|
	|-RVA: 0x307B60 Offset: 0x307C61 VA: 0x307B60
	|-KeyValuePair<object, ushort>.get_Value
	|
	|-RVA: 0x307BC0 Offset: 0x307CC1 VA: 0x307BC0
	|-KeyValuePair<object, uint>.get_Value
	|
	|-RVA: 0x307C20 Offset: 0x307D21 VA: 0x307C20
	|-KeyValuePair<object, ulong>.get_Value
	|
	|-RVA: 0x307CB0 Offset: 0x307DB1 VA: 0x307CB0
	|-KeyValuePair<object, TransitionTables>.get_Value
	|
	|-RVA: 0x307D40 Offset: 0x307E41 VA: 0x307D40
	|-KeyValuePair<object, Bounds>.get_Value
	|
	|-RVA: 0x307DD0 Offset: 0x307ED1 VA: 0x307DD0
	|-KeyValuePair<object, BoundsInt>.get_Value
	|
	|-RVA: 0x307E40 Offset: 0x307F41 VA: 0x307E40
	|-KeyValuePair<object, Color32>.get_Value
	|
	|-RVA: 0x307ED0 Offset: 0x307FD1 VA: 0x307ED0
	|-KeyValuePair<object, Color>.get_Value
	|
	|-RVA: 0x307F40 Offset: 0x308041 VA: 0x307F40
	|-KeyValuePair<object, GradientAlphaKey>.get_Value
	|
	|-RVA: 0x307FC0 Offset: 0x3080C1 VA: 0x307FC0
	|-KeyValuePair<object, GradientColorKey>.get_Value
	|
	|-RVA: 0x308060 Offset: 0x308161 VA: 0x308060
	|-KeyValuePair<object, Keyframe>.get_Value
	|
	|-RVA: 0x3080D0 Offset: 0x3081D1 VA: 0x3080D0
	|-KeyValuePair<object, LayerMask>.get_Value
	|
	|-RVA: 0x308170 Offset: 0x308271 VA: 0x308170
	|-KeyValuePair<object, Matrix4x4>.get_Value
	|
	|-RVA: 0x308200 Offset: 0x308301 VA: 0x308200
	|-KeyValuePair<object, Playable>.get_Value
	|
	|-RVA: 0x308290 Offset: 0x308391 VA: 0x308290
	|-KeyValuePair<object, Quaternion>.get_Value
	|
	|-RVA: 0x3082F0 Offset: 0x3083F1 VA: 0x3082F0
	|-KeyValuePair<object, RangeInt>.get_Value
	|
	|-RVA: 0x308380 Offset: 0x308481 VA: 0x308380
	|-KeyValuePair<object, Rect>.get_Value
	|
	|-RVA: 0x3083F0 Offset: 0x3084F1 VA: 0x3083F0
	|-KeyValuePair<object, RectInt>.get_Value
	|
	|-RVA: 0x308480 Offset: 0x308581 VA: 0x308480
	|-KeyValuePair<object, AsyncOperationHandle>.get_Value
	|
	|-RVA: 0x308520 Offset: 0x308621 VA: 0x308520
	|-KeyValuePair<object, AsyncOperationHandle<object>>.get_Value
	|
	|-RVA: 0x3085A0 Offset: 0x3086A1 VA: 0x3085A0
	|-KeyValuePair<object, Vector2>.get_Value
	|
	|-RVA: 0x308600 Offset: 0x308701 VA: 0x308600
	|-KeyValuePair<object, Vector2Int>.get_Value
	|
	|-RVA: 0x308680 Offset: 0x308781 VA: 0x308680
	|-KeyValuePair<object, Vector3>.get_Value
	|
	|-RVA: 0x3086F0 Offset: 0x3087F1 VA: 0x3086F0
	|-KeyValuePair<object, Vector3Int>.get_Value
	|
	|-RVA: 0x308780 Offset: 0x308881 VA: 0x308780
	|-KeyValuePair<object, Vector4>.get_Value
	|
	|-RVA: 0x3087F0 Offset: 0x3088F1 VA: 0x3087F0
	|-KeyValuePair<ReadOnlyMemory<object>, object>.get_Value
	|
	|-RVA: 0x308830 Offset: 0x308931 VA: 0x308830
	|-KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Value
	|
	|-RVA: 0x308870 Offset: 0x308971 VA: 0x308870
	|-KeyValuePair<sbyte, object>.get_Value
	|
	|-RVA: 0x308910 Offset: 0x308A11 VA: 0x308910
	|-KeyValuePair<float, CurveSample>.get_Value
	|
	|-RVA: 0x308980 Offset: 0x308A81 VA: 0x308980
	|-KeyValuePair<float, int>.get_Value
	|
	|-RVA: 0x3089C0 Offset: 0x308AC1 VA: 0x3089C0
	|-KeyValuePair<float, object>.get_Value
	|
	|-RVA: 0x308A00 Offset: 0x308B01 VA: 0x308A00
	|-KeyValuePair<ushort, object>.get_Value
	|
	|-RVA: 0x308A40 Offset: 0x308B41 VA: 0x308A40
	|-KeyValuePair<uint, int>.get_Value
	|
	|-RVA: 0x308A80 Offset: 0x308B81 VA: 0x308A80
	|-KeyValuePair<uint, Int32Enum>.get_Value
	|
	|-RVA: 0x308B00 Offset: 0x308C01 VA: 0x308B00
	|-KeyValuePair<ulong, object>.get_Value
	|
	|-RVA: 0x308B40 Offset: 0x308C41 VA: 0x308B40
	|-KeyValuePair<EdgeKeyByHash, int>.get_Value
	|
	|-RVA: 0x308BC0 Offset: 0x308CC1 VA: 0x308BC0
	|-KeyValuePair<EdgeKeyByHash, CapEdge>.get_Value
	|
	|-RVA: 0x308C60 Offset: 0x308D61 VA: 0x308C60
	|-KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Value
	|
	|-RVA: 0x308CE0 Offset: 0x308DE1 VA: 0x308CE0
	|-KeyValuePair<EdgeKeyByIndex, ClippedEdge>.get_Value
	|
	|-RVA: 0x308DD0 Offset: 0x308ED1 VA: 0x308DD0
	|-KeyValuePair<Bounds, object>.get_Value
	|
	|-RVA: 0x308E30 Offset: 0x308F31 VA: 0x308E30
	|-KeyValuePair<BoundsInt, object>.get_Value
	|
	|-RVA: 0x308E80 Offset: 0x308F81 VA: 0x308E80
	|-KeyValuePair<Color, object>.get_Value
	|
	|-RVA: 0x308EC0 Offset: 0x308FC1 VA: 0x308EC0
	|-KeyValuePair<Color32, object>.get_Value
	|
	|-RVA: 0x308F00 Offset: 0x309001 VA: 0x308F00
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>.get_Value
	|
	|-RVA: 0x308F40 Offset: 0x309041 VA: 0x308F40
	|-KeyValuePair<GradientAlphaKey, object>.get_Value
	|
	|-RVA: 0x308FA0 Offset: 0x3090A1 VA: 0x308FA0
	|-KeyValuePair<GradientColorKey, object>.get_Value
	|
	|-RVA: 0x309010 Offset: 0x309111 VA: 0x309010
	|-KeyValuePair<Keyframe, object>.get_Value
	|
	|-RVA: 0x309050 Offset: 0x309151 VA: 0x309050
	|-KeyValuePair<LayerMask, object>.get_Value
	|
	|-RVA: 0x3090E0 Offset: 0x3091E1 VA: 0x3090E0
	|-KeyValuePair<Matrix4x4, object>.get_Value
	|
	|-RVA: 0x309180 Offset: 0x309281 VA: 0x309180
	|-KeyValuePair<Quaternion, object>.get_Value
	|
	|-RVA: 0x3091C0 Offset: 0x3092C1 VA: 0x3091C0
	|-KeyValuePair<RangeInt, object>.get_Value
	|
	|-RVA: 0x309210 Offset: 0x309311 VA: 0x309210
	|-KeyValuePair<Rect, object>.get_Value
	|
	|-RVA: 0x309250 Offset: 0x309351 VA: 0x309250
	|-KeyValuePair<RectInt, object>.get_Value
	|
	|-RVA: 0x309290 Offset: 0x309391 VA: 0x309290
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, int>.get_Value
	|
	|-RVA: 0x3092D0 Offset: 0x3093D1 VA: 0x3092D0
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, object>.get_Value
	|
	|-RVA: 0x309310 Offset: 0x309411 VA: 0x309310
	|-KeyValuePair<Vector2, object>.get_Value
	|
	|-RVA: 0x309350 Offset: 0x309451 VA: 0x309350
	|-KeyValuePair<Vector2Int, object>.get_Value
	|
	|-RVA: 0x3093F0 Offset: 0x3094F1 VA: 0x3093F0
	|-KeyValuePair<Vector3Int, object>.get_Value
	|
	|-RVA: 0x309440 Offset: 0x309541 VA: 0x309440
	|-KeyValuePair<Vector4, object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x304CA0 Offset: 0x304DA1 VA: 0x304CA0
	|-KeyValuePair<JSONDeserialization.TaskField, object>.ToString
	|
	|-RVA: 0x304CE0 Offset: 0x304DE1 VA: 0x304CE0
	|-KeyValuePair<BitVector32Int, object>.ToString
	|
	|-RVA: 0x304D70 Offset: 0x304E71 VA: 0x304D70
	|-KeyValuePair<EventCheckId, object>.ToString
	|
	|-RVA: 0x304E00 Offset: 0x304F01 VA: 0x304E00
	|-KeyValuePair<FarmManager.RF4_CROP_STATE, object>.ToString
	|
	|-RVA: 0x304E60 Offset: 0x304F61 VA: 0x304E60
	|-KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>.ToString
	|
	|-RVA: 0x304EB0 Offset: 0x304FB1 VA: 0x304EB0
	|-KeyValuePair<FarmManager.RF4_MCROP_INFO, object>.ToString
	|
	|-RVA: 0x304EF0 Offset: 0x304FF1 VA: 0x304EF0
	|-KeyValuePair<FarmManager.RF4_SOIL_INFO, object>.ToString
	|
	|-RVA: 0x304F80 Offset: 0x305081 VA: 0x304F80
	|-KeyValuePair<MonsterHutSaveData, object>.ToString
	|
	|-RVA: 0x304FD0 Offset: 0x3050D1 VA: 0x304FD0
	|-KeyValuePair<OrderLotterySaveParameter, object>.ToString
	|
	|-RVA: 0x305060 Offset: 0x305161 VA: 0x305060
	|-KeyValuePair<OrderSaveData, object>.ToString
	|
	|-RVA: 0x3050F0 Offset: 0x3051F1 VA: 0x3050F0
	|-KeyValuePair<OrderSaveParameter, object>.ToString
	|
	|-RVA: 0x305160 Offset: 0x305261 VA: 0x305160
	|-KeyValuePair<Parameter, object>.ToString
	|
	|-RVA: 0x3051B0 Offset: 0x3052B1 VA: 0x3051B0
	|-KeyValuePair<bool, object>.ToString
	|
	|-RVA: 0x3051F0 Offset: 0x3052F1 VA: 0x3051F0
	|-KeyValuePair<byte, object>.ToString
	|
	|-RVA: 0x305230 Offset: 0x305331 VA: 0x305230
	|-KeyValuePair<char, object>.ToString
	|
	|-RVA: 0x305270 Offset: 0x305371 VA: 0x305270
	|-KeyValuePair<DateTime, object>.ToString
	|
	|-RVA: 0x3052B0 Offset: 0x3053B1 VA: 0x3052B0
	|-KeyValuePair<double, object>.ToString
	|
	|-RVA: 0x3052F0 Offset: 0x3053F1 VA: 0x3052F0
	|-KeyValuePair<Guid, object>.ToString
	|
	|-RVA: 0x305330 Offset: 0x305431 VA: 0x305330
	|-KeyValuePair<short, object>.ToString
	|
	|-RVA: 0x3053C0 Offset: 0x3054C1 VA: 0x3053C0
	|-KeyValuePair<int, CropDataTable>.ToString
	|
	|-RVA: 0x305440 Offset: 0x305541 VA: 0x305440
	|-KeyValuePair<int, EffectDataTable>.ToString
	|
	|-RVA: 0x305480 Offset: 0x305581 VA: 0x305480
	|-KeyValuePair<int, GimmickLayoutDataTable>.ToString
	|
	|-RVA: 0x305530 Offset: 0x305631 VA: 0x305530
	|-KeyValuePair<int, MineTypeDataTable>.ToString
	|
	|-RVA: 0x305580 Offset: 0x305681 VA: 0x305580
	|-KeyValuePair<int, MiningDataTable>.ToString
	|
	|-RVA: 0x3055C0 Offset: 0x3056C1 VA: 0x3055C0
	|-KeyValuePair<int, bool>.ToString
	|
	|-RVA: 0x305600 Offset: 0x305701 VA: 0x305600
	|-KeyValuePair<int, char>.ToString
	|
	|-RVA: 0x305640 Offset: 0x305741 VA: 0x305640
	|-KeyValuePair<int, int>.ToString
	|
	|-RVA: 0x305680 Offset: 0x305781 VA: 0x305680
	|-KeyValuePair<int, Int32Enum>.ToString
	|
	|-RVA: 0x3056C0 Offset: 0x3057C1 VA: 0x3056C0
	|-KeyValuePair<int, long>.ToString
	|
	|-RVA: 0x305700 Offset: 0x305801 VA: 0x305700
	|-KeyValuePair<int, object>.ToString
	|-KeyValuePair<int, PointerEventData>.ToString
	|
	|-RVA: 0x305740 Offset: 0x305841 VA: 0x305740
	|-KeyValuePair<int, uint>.ToString
	|
	|-RVA: 0x3057D0 Offset: 0x3058D1 VA: 0x3057D0
	|-KeyValuePair<int, DiagnosticEvent>.ToString
	|
	|-RVA: 0x305820 Offset: 0x305921 VA: 0x305820
	|-KeyValuePair<int, SceneInstance>.ToString
	|
	|-RVA: 0x305860 Offset: 0x305961 VA: 0x305860
	|-KeyValuePair<int, Vector2Int>.ToString
	|
	|-RVA: 0x3058B0 Offset: 0x3059B1 VA: 0x3058B0
	|-KeyValuePair<int, Vector3>.ToString
	|
	|-RVA: 0x305940 Offset: 0x305A41 VA: 0x305940
	|-KeyValuePair<Int32Enum, MonsterDataTable>.ToString
	|
	|-RVA: 0x3059D0 Offset: 0x305AD1 VA: 0x3059D0
	|-KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>.ToString
	|
	|-RVA: 0x305A10 Offset: 0x305B11 VA: 0x305A10
	|-KeyValuePair<Int32Enum, MonsterSearchRangeParameter>.ToString
	|
	|-RVA: 0x305A50 Offset: 0x305B51 VA: 0x305A50
	|-KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.ToString
	|
	|-RVA: 0x305A90 Offset: 0x305B91 VA: 0x305A90
	|-KeyValuePair<Int32Enum, bool>.ToString
	|
	|-RVA: 0x305AD0 Offset: 0x305BD1 VA: 0x305AD0
	|-KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>.ToString
	|
	|-RVA: 0x305B10 Offset: 0x305C11 VA: 0x305B10
	|-KeyValuePair<Int32Enum, int>.ToString
	|
	|-RVA: 0x305B50 Offset: 0x305C51 VA: 0x305B50
	|-KeyValuePair<Int32Enum, Int32Enum>.ToString
	|
	|-RVA: 0x305B90 Offset: 0x305C91 VA: 0x305B90
	|-KeyValuePair<Int32Enum, object>.ToString
	|
	|-RVA: 0x305BD0 Offset: 0x305CD1 VA: 0x305BD0
	|-KeyValuePair<Int32Enum, float>.ToString
	|
	|-RVA: 0x305C20 Offset: 0x305D21 VA: 0x305C20
	|-KeyValuePair<Int32Enum, ValueTuple<object, object>>.ToString
	|
	|-RVA: 0x305C60 Offset: 0x305D61 VA: 0x305C60
	|-KeyValuePair<Int32Enum, ValueTuple<float, float>>.ToString
	|
	|-RVA: 0x305CA0 Offset: 0x305DA1 VA: 0x305CA0
	|-KeyValuePair<Int32Enum, TutorialUnlockFlagData>.ToString
	|
	|-RVA: 0x305CE0 Offset: 0x305DE1 VA: 0x305CE0
	|-KeyValuePair<long, object>.ToString
	|
	|-RVA: 0x305D50 Offset: 0x305E51 VA: 0x305D50
	|-KeyValuePair<Memory<object>, object>.ToString
	|
	|-RVA: 0x305D90 Offset: 0x305E91 VA: 0x305D90
	|-KeyValuePair<Nullable<Int32Enum>, object>.ToString
	|
	|-RVA: 0x305E00 Offset: 0x305F01 VA: 0x305E00
	|-KeyValuePair<Nullable<Bounds>, object>.ToString
	|
	|-RVA: 0x305E70 Offset: 0x305F71 VA: 0x305E70
	|-KeyValuePair<Nullable<BoundsInt>, object>.ToString
	|
	|-RVA: 0x305EB0 Offset: 0x305FB1 VA: 0x305EB0
	|-KeyValuePair<Nullable<Color32>, object>.ToString
	|
	|-RVA: 0x305F10 Offset: 0x306011 VA: 0x305F10
	|-KeyValuePair<Nullable<Color>, object>.ToString
	|
	|-RVA: 0x305F60 Offset: 0x306061 VA: 0x305F60
	|-KeyValuePair<Nullable<GradientAlphaKey>, object>.ToString
	|
	|-RVA: 0x305FC0 Offset: 0x3060C1 VA: 0x305FC0
	|-KeyValuePair<Nullable<GradientColorKey>, object>.ToString
	|
	|-RVA: 0x306020 Offset: 0x306121 VA: 0x306020
	|-KeyValuePair<Nullable<Keyframe>, object>.ToString
	|
	|-RVA: 0x306060 Offset: 0x306161 VA: 0x306060
	|-KeyValuePair<Nullable<LayerMask>, object>.ToString
	|
	|-RVA: 0x306100 Offset: 0x306201 VA: 0x306100
	|-KeyValuePair<Nullable<Matrix4x4>, object>.ToString
	|
	|-RVA: 0x306160 Offset: 0x306261 VA: 0x306160
	|-KeyValuePair<Nullable<Quaternion>, object>.ToString
	|
	|-RVA: 0x3061B0 Offset: 0x3062B1 VA: 0x3061B0
	|-KeyValuePair<Nullable<RangeInt>, object>.ToString
	|
	|-RVA: 0x306210 Offset: 0x306311 VA: 0x306210
	|-KeyValuePair<Nullable<Rect>, object>.ToString
	|
	|-RVA: 0x306270 Offset: 0x306371 VA: 0x306270
	|-KeyValuePair<Nullable<RectInt>, object>.ToString
	|
	|-RVA: 0x3062C0 Offset: 0x3063C1 VA: 0x3062C0
	|-KeyValuePair<Nullable<Vector2>, object>.ToString
	|
	|-RVA: 0x306310 Offset: 0x306411 VA: 0x306310
	|-KeyValuePair<Nullable<Vector2Int>, object>.ToString
	|
	|-RVA: 0x306350 Offset: 0x306451 VA: 0x306350
	|-KeyValuePair<Nullable<Vector3>, object>.ToString
	|
	|-RVA: 0x306390 Offset: 0x306491 VA: 0x306390
	|-KeyValuePair<Nullable<Vector3Int>, object>.ToString
	|
	|-RVA: 0x3063F0 Offset: 0x3064F1 VA: 0x3063F0
	|-KeyValuePair<Nullable<Vector4>, object>.ToString
	|
	|-RVA: 0x306450 Offset: 0x306551 VA: 0x306450
	|-KeyValuePair<object, BitVector32Int>.ToString
	|
	|-RVA: 0x3064F0 Offset: 0x3065F1 VA: 0x3064F0
	|-KeyValuePair<object, EventCheckId>.ToString
	|
	|-RVA: 0x3065C0 Offset: 0x3066C1 VA: 0x3065C0
	|-KeyValuePair<object, FarmManager.RF4_CROP_STATE>.ToString
	|
	|-RVA: 0x306650 Offset: 0x306751 VA: 0x306650
	|-KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>.ToString
	|
	|-RVA: 0x3066C0 Offset: 0x3067C1 VA: 0x3066C0
	|-KeyValuePair<object, FarmManager.RF4_MCROP_INFO>.ToString
	|
	|-RVA: 0x306730 Offset: 0x306831 VA: 0x306730
	|-KeyValuePair<object, FarmManager.RF4_SOIL_INFO>.ToString
	|
	|-RVA: 0x3067E0 Offset: 0x3068E1 VA: 0x3067E0
	|-KeyValuePair<object, MonsterHutSaveData>.ToString
	|
	|-RVA: 0x306850 Offset: 0x306951 VA: 0x306850
	|-KeyValuePair<object, OrderLotterySaveParameter>.ToString
	|
	|-RVA: 0x306900 Offset: 0x306A01 VA: 0x306900
	|-KeyValuePair<object, OrderSaveData>.ToString
	|
	|-RVA: 0x3069A0 Offset: 0x306AA1 VA: 0x3069A0
	|-KeyValuePair<object, OrderSaveParameter>.ToString
	|
	|-RVA: 0x306A40 Offset: 0x306B41 VA: 0x306A40
	|-KeyValuePair<object, Parameter>.ToString
	|
	|-RVA: 0x306AB0 Offset: 0x306BB1 VA: 0x306AB0
	|-KeyValuePair<object, NumberControl.ValueRange>.ToString
	|
	|-RVA: 0x306B20 Offset: 0x306C21 VA: 0x306B20
	|-KeyValuePair<object, bool>.ToString
	|
	|-RVA: 0x306B80 Offset: 0x306C81 VA: 0x306B80
	|-KeyValuePair<object, byte>.ToString
	|
	|-RVA: 0x306BE0 Offset: 0x306CE1 VA: 0x306BE0
	|-KeyValuePair<object, char>.ToString
	|
	|-RVA: 0x306C40 Offset: 0x306D41 VA: 0x306C40
	|-KeyValuePair<object, DateTime>.ToString
	|
	|-RVA: 0x306CB0 Offset: 0x306DB1 VA: 0x306CB0
	|-KeyValuePair<object, double>.ToString
	|
	|-RVA: 0x306D10 Offset: 0x306E11 VA: 0x306D10
	|-KeyValuePair<object, short>.ToString
	|
	|-RVA: 0x306D70 Offset: 0x306E71 VA: 0x306D70
	|-KeyValuePair<object, int>.ToString
	|
	|-RVA: 0x306DD0 Offset: 0x306ED1 VA: 0x306DD0
	|-KeyValuePair<object, Int32Enum>.ToString
	|
	|-RVA: 0x306E30 Offset: 0x306F31 VA: 0x306E30
	|-KeyValuePair<object, long>.ToString
	|
	|-RVA: 0x306EB0 Offset: 0x306FB1 VA: 0x306EB0
	|-KeyValuePair<object, Memory<object>>.ToString
	|
	|-RVA: 0x306F10 Offset: 0x307011 VA: 0x306F10
	|-KeyValuePair<object, Nullable<Int32Enum>>.ToString
	|
	|-RVA: 0x306FB0 Offset: 0x3070B1 VA: 0x306FB0
	|-KeyValuePair<object, Nullable<Bounds>>.ToString
	|
	|-RVA: 0x307050 Offset: 0x307151 VA: 0x307050
	|-KeyValuePair<object, Nullable<BoundsInt>>.ToString
	|
	|-RVA: 0x3070B0 Offset: 0x3071B1 VA: 0x3070B0
	|-KeyValuePair<object, Nullable<Color32>>.ToString
	|
	|-RVA: 0x307140 Offset: 0x307241 VA: 0x307140
	|-KeyValuePair<object, Nullable<Color>>.ToString
	|
	|-RVA: 0x3071B0 Offset: 0x3072B1 VA: 0x3071B0
	|-KeyValuePair<object, Nullable<GradientAlphaKey>>.ToString
	|
	|-RVA: 0x307240 Offset: 0x307341 VA: 0x307240
	|-KeyValuePair<object, Nullable<GradientColorKey>>.ToString
	|
	|-RVA: 0x3072D0 Offset: 0x3073D1 VA: 0x3072D0
	|-KeyValuePair<object, Nullable<Keyframe>>.ToString
	|
	|-RVA: 0x307330 Offset: 0x307431 VA: 0x307330
	|-KeyValuePair<object, Nullable<LayerMask>>.ToString
	|
	|-RVA: 0x307420 Offset: 0x307521 VA: 0x307420
	|-KeyValuePair<object, Nullable<Matrix4x4>>.ToString
	|
	|-RVA: 0x3074B0 Offset: 0x3075B1 VA: 0x3074B0
	|-KeyValuePair<object, Nullable<Quaternion>>.ToString
	|
	|-RVA: 0x307520 Offset: 0x307621 VA: 0x307520
	|-KeyValuePair<object, Nullable<RangeInt>>.ToString
	|
	|-RVA: 0x3075B0 Offset: 0x3076B1 VA: 0x3075B0
	|-KeyValuePair<object, Nullable<Rect>>.ToString
	|
	|-RVA: 0x307640 Offset: 0x307741 VA: 0x307640
	|-KeyValuePair<object, Nullable<RectInt>>.ToString
	|
	|-RVA: 0x3076B0 Offset: 0x3077B1 VA: 0x3076B0
	|-KeyValuePair<object, Nullable<Vector2>>.ToString
	|
	|-RVA: 0x307720 Offset: 0x307821 VA: 0x307720
	|-KeyValuePair<object, Nullable<Vector2Int>>.ToString
	|
	|-RVA: 0x307790 Offset: 0x307891 VA: 0x307790
	|-KeyValuePair<object, Nullable<Vector3>>.ToString
	|
	|-RVA: 0x307800 Offset: 0x307901 VA: 0x307800
	|-KeyValuePair<object, Nullable<Vector3Int>>.ToString
	|
	|-RVA: 0x307890 Offset: 0x307991 VA: 0x307890
	|-KeyValuePair<object, Nullable<Vector4>>.ToString
	|
	|-RVA: 0x307900 Offset: 0x307A01 VA: 0x307900
	|-KeyValuePair<object, object>.ToString
	|
	|-RVA: 0x3079C0 Offset: 0x307AC1 VA: 0x3079C0
	|-KeyValuePair<object, ReadOnlyMemory<object>>.ToString
	|
	|-RVA: 0x307A40 Offset: 0x307B41 VA: 0x307A40
	|-KeyValuePair<object, ResourceLocator>.ToString
	|
	|-RVA: 0x307AA0 Offset: 0x307BA1 VA: 0x307AA0
	|-KeyValuePair<object, sbyte>.ToString
	|
	|-RVA: 0x307B10 Offset: 0x307C11 VA: 0x307B10
	|-KeyValuePair<object, float>.ToString
	|
	|-RVA: 0x307B70 Offset: 0x307C71 VA: 0x307B70
	|-KeyValuePair<object, ushort>.ToString
	|
	|-RVA: 0x307BD0 Offset: 0x307CD1 VA: 0x307BD0
	|-KeyValuePair<object, uint>.ToString
	|
	|-RVA: 0x307C30 Offset: 0x307D31 VA: 0x307C30
	|-KeyValuePair<object, ulong>.ToString
	|
	|-RVA: 0x307CD0 Offset: 0x307DD1 VA: 0x307CD0
	|-KeyValuePair<object, TransitionTables>.ToString
	|
	|-RVA: 0x307D60 Offset: 0x307E61 VA: 0x307D60
	|-KeyValuePair<object, Bounds>.ToString
	|
	|-RVA: 0x307DF0 Offset: 0x307EF1 VA: 0x307DF0
	|-KeyValuePair<object, BoundsInt>.ToString
	|
	|-RVA: 0x307E50 Offset: 0x307F51 VA: 0x307E50
	|-KeyValuePair<object, Color32>.ToString
	|
	|-RVA: 0x307EE0 Offset: 0x307FE1 VA: 0x307EE0
	|-KeyValuePair<object, Color>.ToString
	|
	|-RVA: 0x307F50 Offset: 0x308051 VA: 0x307F50
	|-KeyValuePair<object, GradientAlphaKey>.ToString
	|
	|-RVA: 0x307FE0 Offset: 0x3080E1 VA: 0x307FE0
	|-KeyValuePair<object, GradientColorKey>.ToString
	|
	|-RVA: 0x308080 Offset: 0x308181 VA: 0x308080
	|-KeyValuePair<object, Keyframe>.ToString
	|
	|-RVA: 0x3080E0 Offset: 0x3081E1 VA: 0x3080E0
	|-KeyValuePair<object, LayerMask>.ToString
	|
	|-RVA: 0x3081A0 Offset: 0x3082A1 VA: 0x3081A0
	|-KeyValuePair<object, Matrix4x4>.ToString
	|
	|-RVA: 0x308210 Offset: 0x308311 VA: 0x308210
	|-KeyValuePair<object, Playable>.ToString
	|
	|-RVA: 0x3082A0 Offset: 0x3083A1 VA: 0x3082A0
	|-KeyValuePair<object, Quaternion>.ToString
	|
	|-RVA: 0x308300 Offset: 0x308401 VA: 0x308300
	|-KeyValuePair<object, RangeInt>.ToString
	|
	|-RVA: 0x308390 Offset: 0x308491 VA: 0x308390
	|-KeyValuePair<object, Rect>.ToString
	|
	|-RVA: 0x308400 Offset: 0x308501 VA: 0x308400
	|-KeyValuePair<object, RectInt>.ToString
	|
	|-RVA: 0x3084A0 Offset: 0x3085A1 VA: 0x3084A0
	|-KeyValuePair<object, AsyncOperationHandle>.ToString
	|
	|-RVA: 0x308540 Offset: 0x308641 VA: 0x308540
	|-KeyValuePair<object, AsyncOperationHandle<object>>.ToString
	|
	|-RVA: 0x3085B0 Offset: 0x3086B1 VA: 0x3085B0
	|-KeyValuePair<object, Vector2>.ToString
	|
	|-RVA: 0x308610 Offset: 0x308711 VA: 0x308610
	|-KeyValuePair<object, Vector2Int>.ToString
	|
	|-RVA: 0x308690 Offset: 0x308791 VA: 0x308690
	|-KeyValuePair<object, Vector3>.ToString
	|
	|-RVA: 0x308700 Offset: 0x308801 VA: 0x308700
	|-KeyValuePair<object, Vector3Int>.ToString
	|
	|-RVA: 0x308790 Offset: 0x308891 VA: 0x308790
	|-KeyValuePair<object, Vector4>.ToString
	|
	|-RVA: 0x308800 Offset: 0x308901 VA: 0x308800
	|-KeyValuePair<ReadOnlyMemory<object>, object>.ToString
	|
	|-RVA: 0x308840 Offset: 0x308941 VA: 0x308840
	|-KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>.ToString
	|
	|-RVA: 0x308880 Offset: 0x308981 VA: 0x308880
	|-KeyValuePair<sbyte, object>.ToString
	|
	|-RVA: 0x308950 Offset: 0x308A51 VA: 0x308950
	|-KeyValuePair<float, CurveSample>.ToString
	|
	|-RVA: 0x308990 Offset: 0x308A91 VA: 0x308990
	|-KeyValuePair<float, int>.ToString
	|
	|-RVA: 0x3089D0 Offset: 0x308AD1 VA: 0x3089D0
	|-KeyValuePair<float, object>.ToString
	|
	|-RVA: 0x308A10 Offset: 0x308B11 VA: 0x308A10
	|-KeyValuePair<ushort, object>.ToString
	|
	|-RVA: 0x308A50 Offset: 0x308B51 VA: 0x308A50
	|-KeyValuePair<uint, int>.ToString
	|
	|-RVA: 0x308A90 Offset: 0x308B91 VA: 0x308A90
	|-KeyValuePair<uint, Int32Enum>.ToString
	|
	|-RVA: 0x308AD0 Offset: 0x308BD1 VA: 0x308AD0
	|-KeyValuePair<uint, object>.ToString
	|
	|-RVA: 0x308B10 Offset: 0x308C11 VA: 0x308B10
	|-KeyValuePair<ulong, object>.ToString
	|
	|-RVA: 0x308B50 Offset: 0x308C51 VA: 0x308B50
	|-KeyValuePair<EdgeKeyByHash, int>.ToString
	|
	|-RVA: 0x308BF0 Offset: 0x308CF1 VA: 0x308BF0
	|-KeyValuePair<EdgeKeyByHash, CapEdge>.ToString
	|
	|-RVA: 0x308C80 Offset: 0x308D81 VA: 0x308C80
	|-KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.ToString
	|
	|-RVA: 0x308D00 Offset: 0x308E01 VA: 0x308D00
	|-KeyValuePair<EdgeKeyByIndex, ClippedEdge>.ToString
	|
	|-RVA: 0x308D40 Offset: 0x308E41 VA: 0x308D40
	|-KeyValuePair<MeshDataConnectivity.Face, bool>.ToString
	|
	|-RVA: 0x308D80 Offset: 0x308E81 VA: 0x308D80
	|-KeyValuePair<MeshDataConnectivity.Face, object>.ToString
	|
	|-RVA: 0x308DE0 Offset: 0x308EE1 VA: 0x308DE0
	|-KeyValuePair<Bounds, object>.ToString
	|
	|-RVA: 0x308E40 Offset: 0x308F41 VA: 0x308E40
	|-KeyValuePair<BoundsInt, object>.ToString
	|
	|-RVA: 0x308E90 Offset: 0x308F91 VA: 0x308E90
	|-KeyValuePair<Color, object>.ToString
	|
	|-RVA: 0x308ED0 Offset: 0x308FD1 VA: 0x308ED0
	|-KeyValuePair<Color32, object>.ToString
	|
	|-RVA: 0x308F10 Offset: 0x309011 VA: 0x308F10
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>.ToString
	|
	|-RVA: 0x308F50 Offset: 0x309051 VA: 0x308F50
	|-KeyValuePair<GradientAlphaKey, object>.ToString
	|
	|-RVA: 0x308FB0 Offset: 0x3090B1 VA: 0x308FB0
	|-KeyValuePair<GradientColorKey, object>.ToString
	|
	|-RVA: 0x309020 Offset: 0x309121 VA: 0x309020
	|-KeyValuePair<Keyframe, object>.ToString
	|
	|-RVA: 0x309060 Offset: 0x309161 VA: 0x309060
	|-KeyValuePair<LayerMask, object>.ToString
	|
	|-RVA: 0x3090F0 Offset: 0x3091F1 VA: 0x3090F0
	|-KeyValuePair<Matrix4x4, object>.ToString
	|
	|-RVA: 0x309140 Offset: 0x309241 VA: 0x309140
	|-KeyValuePair<IntVec3, object>.ToString
	|
	|-RVA: 0x309190 Offset: 0x309291 VA: 0x309190
	|-KeyValuePair<Quaternion, object>.ToString
	|
	|-RVA: 0x3091D0 Offset: 0x3092D1 VA: 0x3091D0
	|-KeyValuePair<RangeInt, object>.ToString
	|
	|-RVA: 0x309220 Offset: 0x309321 VA: 0x309220
	|-KeyValuePair<Rect, object>.ToString
	|
	|-RVA: 0x309260 Offset: 0x309361 VA: 0x309260
	|-KeyValuePair<RectInt, object>.ToString
	|
	|-RVA: 0x3092A0 Offset: 0x3093A1 VA: 0x3092A0
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, int>.ToString
	|
	|-RVA: 0x3092E0 Offset: 0x3093E1 VA: 0x3092E0
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, object>.ToString
	|
	|-RVA: 0x309320 Offset: 0x309421 VA: 0x309320
	|-KeyValuePair<Vector2, object>.ToString
	|
	|-RVA: 0x309360 Offset: 0x309461 VA: 0x309360
	|-KeyValuePair<Vector2Int, object>.ToString
	|
	|-RVA: 0x3093B0 Offset: 0x3094B1 VA: 0x3093B0
	|-KeyValuePair<Vector3, object>.ToString
	|
	|-RVA: 0x309400 Offset: 0x309501 VA: 0x309400
	|-KeyValuePair<Vector3Int, object>.ToString
	|
	|-RVA: 0x309450 Offset: 0x309551 VA: 0x309450
	|-KeyValuePair<Vector4, object>.ToString
	*/
}

