[Serializable]
public struct Dictionary.ValueCollection.Enumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 1428
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private TValue currentValue; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36AAE0 Offset: 0x36ABE1 VA: 0x36AAE0
	|-Dictionary.ValueCollection.Enumerator<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x36ACA0 Offset: 0x36ADA1 VA: 0x36ACA0
	|-Dictionary.ValueCollection.Enumerator<BitVector32Int, object>..ctor
	|
	|-RVA: 0x36AE60 Offset: 0x36AF61 VA: 0x36AE60
	|-Dictionary.ValueCollection.Enumerator<EventCheckId, object>..ctor
	|
	|-RVA: 0x36B020 Offset: 0x36B121 VA: 0x36B020
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x36B1E0 Offset: 0x36B2E1 VA: 0x36B1E0
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x36B3A0 Offset: 0x36B4A1 VA: 0x36B3A0
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x36B560 Offset: 0x36B661 VA: 0x36B560
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x36B720 Offset: 0x36B821 VA: 0x36B720
	|-Dictionary.ValueCollection.Enumerator<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x36B8E0 Offset: 0x36B9E1 VA: 0x36B8E0
	|-Dictionary.ValueCollection.Enumerator<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x36BAA0 Offset: 0x36BBA1 VA: 0x36BAA0
	|-Dictionary.ValueCollection.Enumerator<OrderSaveData, object>..ctor
	|
	|-RVA: 0x36BC60 Offset: 0x36BD61 VA: 0x36BC60
	|-Dictionary.ValueCollection.Enumerator<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x36BE20 Offset: 0x36BF21 VA: 0x36BE20
	|-Dictionary.ValueCollection.Enumerator<Parameter, object>..ctor
	|
	|-RVA: 0x36BFE0 Offset: 0x36C0E1 VA: 0x36BFE0
	|-Dictionary.ValueCollection.Enumerator<bool, object>..ctor
	|
	|-RVA: 0x36C1A0 Offset: 0x36C2A1 VA: 0x36C1A0
	|-Dictionary.ValueCollection.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x2EA000 Offset: 0x2EA101 VA: 0x2EA000
	|-Dictionary.ValueCollection.Enumerator<char, object>..ctor
	|
	|-RVA: 0x2EA1C0 Offset: 0x2EA2C1 VA: 0x2EA1C0
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>..ctor
	|
	|-RVA: 0x2EA380 Offset: 0x2EA481 VA: 0x2EA380
	|-Dictionary.ValueCollection.Enumerator<double, object>..ctor
	|
	|-RVA: 0x2EA540 Offset: 0x2EA641 VA: 0x2EA540
	|-Dictionary.ValueCollection.Enumerator<Guid, object>..ctor
	|
	|-RVA: 0x2EA700 Offset: 0x2EA801 VA: 0x2EA700
	|-Dictionary.ValueCollection.Enumerator<short, object>..ctor
	|
	|-RVA: 0x2EA8C0 Offset: 0x2EA9C1 VA: 0x2EA8C0
	|-Dictionary.ValueCollection.Enumerator<int, CropDataTable>..ctor
	|
	|-RVA: 0x2EAA60 Offset: 0x2EAB61 VA: 0x2EAA60
	|-Dictionary.ValueCollection.Enumerator<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2EABA0 Offset: 0x2EACA1 VA: 0x2EABA0
	|-Dictionary.ValueCollection.Enumerator<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2EACC0 Offset: 0x2EADC1 VA: 0x2EACC0
	|-Dictionary.ValueCollection.Enumerator<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2EAE20 Offset: 0x2EAF21 VA: 0x2EAE20
	|-Dictionary.ValueCollection.Enumerator<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2EAF40 Offset: 0x2EB041 VA: 0x2EAF40
	|-Dictionary.ValueCollection.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x2EB060 Offset: 0x2EB161 VA: 0x2EB060
	|-Dictionary.ValueCollection.Enumerator<int, char>..ctor
	|
	|-RVA: 0x2EB180 Offset: 0x2EB281 VA: 0x2EB180
	|-Dictionary.ValueCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x2EB2A0 Offset: 0x2EB3A1 VA: 0x2EB2A0
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>..ctor
	|
	|-RVA: 0x2EB3C0 Offset: 0x2EB4C1 VA: 0x2EB3C0
	|-Dictionary.ValueCollection.Enumerator<int, long>..ctor
	|
	|-RVA: 0x2EB4E0 Offset: 0x2EB5E1 VA: 0x2EB4E0
	|-Dictionary.ValueCollection.Enumerator<int, object>..ctor
	|
	|-RVA: 0x2EB6A0 Offset: 0x2EB7A1 VA: 0x2EB6A0
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x2EB7F0 Offset: 0x2EB8F1 VA: 0x2EB7F0
	|-Dictionary.ValueCollection.Enumerator<int, SceneInstance>..ctor
	|
	|-RVA: 0x2EB910 Offset: 0x2EBA11 VA: 0x2EB910
	|-Dictionary.ValueCollection.Enumerator<int, Vector2Int>..ctor
	|
	|-RVA: 0x2EBA30 Offset: 0x2EBB31 VA: 0x2EBA30
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>..ctor
	|
	|-RVA: 0x2EBB60 Offset: 0x2EBC61 VA: 0x2EBB60
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x2EBCE0 Offset: 0x2EBDE1 VA: 0x2EBCE0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2EBE30 Offset: 0x2EBF31 VA: 0x2EBE30
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x2EBF50 Offset: 0x2EC051 VA: 0x2EBF50
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2EC070 Offset: 0x2EC171 VA: 0x2EC070
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2EC190 Offset: 0x2EC291 VA: 0x2EC190
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x2EC2B0 Offset: 0x2EC3B1 VA: 0x2EC2B0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2EC3D0 Offset: 0x2EC4D1 VA: 0x2EC3D0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>..ctor
	|
	|-RVA: 0x2EC590 Offset: 0x2EC691 VA: 0x2EC590
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>..ctor
	|
	|-RVA: 0x2EC6B0 Offset: 0x2EC7B1 VA: 0x2EC6B0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2EC7D0 Offset: 0x2EC8D1 VA: 0x2EC7D0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x2EC8F0 Offset: 0x2EC9F1 VA: 0x2EC8F0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x2ECA20 Offset: 0x2ECB21 VA: 0x2ECA20
	|-Dictionary.ValueCollection.Enumerator<long, object>..ctor
	|
	|-RVA: 0x2ECBE0 Offset: 0x2ECCE1 VA: 0x2ECBE0
	|-Dictionary.ValueCollection.Enumerator<Memory<object>, object>..ctor
	|
	|-RVA: 0x2ECDA0 Offset: 0x2ECEA1 VA: 0x2ECDA0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x2ECF60 Offset: 0x2ED061 VA: 0x2ECF60
	|-Dictionary.ValueCollection.Enumerator<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x2ED120 Offset: 0x2ED221 VA: 0x2ED120
	|-Dictionary.ValueCollection.Enumerator<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x2ED2E0 Offset: 0x2ED3E1 VA: 0x2ED2E0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x2ED4A0 Offset: 0x2ED5A1 VA: 0x2ED4A0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x2ED660 Offset: 0x2ED761 VA: 0x2ED660
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x2ED820 Offset: 0x2ED921 VA: 0x2ED820
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x2ED9E0 Offset: 0x2EDAE1 VA: 0x2ED9E0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x2EDBA0 Offset: 0x2EDCA1 VA: 0x2EDBA0
	|-Dictionary.ValueCollection.Enumerator<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x2EDD60 Offset: 0x2EDE61 VA: 0x2EDD60
	|-Dictionary.ValueCollection.Enumerator<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x2EDF20 Offset: 0x2EE021 VA: 0x2EDF20
	|-Dictionary.ValueCollection.Enumerator<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x2EE0E0 Offset: 0x2EE1E1 VA: 0x2EE0E0
	|-Dictionary.ValueCollection.Enumerator<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x2EE2A0 Offset: 0x2EE3A1 VA: 0x2EE2A0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x2EE460 Offset: 0x2EE561 VA: 0x2EE460
	|-Dictionary.ValueCollection.Enumerator<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x2EE620 Offset: 0x2EE721 VA: 0x2EE620
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x2EE7E0 Offset: 0x2EE8E1 VA: 0x2EE7E0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x2EE9A0 Offset: 0x2EEAA1 VA: 0x2EE9A0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x2EEB60 Offset: 0x2EEC61 VA: 0x2EEB60
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x2EED20 Offset: 0x2EEE21 VA: 0x2EED20
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x2EEEE0 Offset: 0x2EEFE1 VA: 0x2EEEE0
	|-Dictionary.ValueCollection.Enumerator<object, BitVector32Int>..ctor
	|
	|-RVA: 0x2EF000 Offset: 0x2EF101 VA: 0x2EF000
	|-Dictionary.ValueCollection.Enumerator<object, EventCheckId>..ctor
	|
	|-RVA: 0x2EF140 Offset: 0x2EF241 VA: 0x2EF140
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2EF2A0 Offset: 0x2EF3A1 VA: 0x2EF2A0
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2EF3E0 Offset: 0x2EF4E1 VA: 0x2EF3E0
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2EF510 Offset: 0x2EF611 VA: 0x2EF510
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x2EF630 Offset: 0x2EF731 VA: 0x2EF630
	|-Dictionary.ValueCollection.Enumerator<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2EF780 Offset: 0x2EF881 VA: 0x2EF780
	|-Dictionary.ValueCollection.Enumerator<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2EF8B0 Offset: 0x2EF9B1 VA: 0x2EF8B0
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveData>..ctor
	|
	|-RVA: 0x2EFA00 Offset: 0x2EFB01 VA: 0x2EFA00
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x2EFB40 Offset: 0x2EFC41 VA: 0x2EFB40
	|-Dictionary.ValueCollection.Enumerator<object, Parameter>..ctor
	|
	|-RVA: 0x2EFCC0 Offset: 0x2EFDC1 VA: 0x2EFCC0
	|-Dictionary.ValueCollection.Enumerator<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x2EFDE0 Offset: 0x2EFEE1 VA: 0x2EFDE0
	|-Dictionary.ValueCollection.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x2EFF00 Offset: 0x2F0001 VA: 0x2EFF00
	|-Dictionary.ValueCollection.Enumerator<object, byte>..ctor
	|
	|-RVA: 0x2F0020 Offset: 0x2F0121 VA: 0x2F0020
	|-Dictionary.ValueCollection.Enumerator<object, char>..ctor
	|
	|-RVA: 0x2F0140 Offset: 0x2F0241 VA: 0x2F0140
	|-Dictionary.ValueCollection.Enumerator<object, DateTime>..ctor
	|
	|-RVA: 0x2F0260 Offset: 0x2F0361 VA: 0x2F0260
	|-Dictionary.ValueCollection.Enumerator<object, double>..ctor
	|
	|-RVA: 0x2F0380 Offset: 0x2F0481 VA: 0x2F0380
	|-Dictionary.ValueCollection.Enumerator<object, short>..ctor
	|
	|-RVA: 0x2F04A0 Offset: 0x2F05A1 VA: 0x2F04A0
	|-Dictionary.ValueCollection.Enumerator<object, int>..ctor
	|
	|-RVA: 0x2F05C0 Offset: 0x2F06C1 VA: 0x2F05C0
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>..ctor
	|
	|-RVA: 0x2F06E0 Offset: 0x2F07E1 VA: 0x2F06E0
	|-Dictionary.ValueCollection.Enumerator<object, long>..ctor
	|
	|-RVA: 0x2F0800 Offset: 0x2F0901 VA: 0x2F0800
	|-Dictionary.ValueCollection.Enumerator<object, Memory<object>>..ctor
	|
	|-RVA: 0x2F0920 Offset: 0x2F0A21 VA: 0x2F0920
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x2F0A40 Offset: 0x2F0B41 VA: 0x2F0A40
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x2F0B90 Offset: 0x2F0C91 VA: 0x2F0B90
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x2F0CE0 Offset: 0x2F0DE1 VA: 0x2F0CE0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x2F0E00 Offset: 0x2F0F01 VA: 0x2F0E00
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x2F0F40 Offset: 0x2F1041 VA: 0x2F0F40
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2F1070 Offset: 0x2F1171 VA: 0x2F1070
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2F11B0 Offset: 0x2F12B1 VA: 0x2F11B0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2F12F0 Offset: 0x2F13F1 VA: 0x2F12F0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x2FB4D0 Offset: 0x2FB5D1 VA: 0x2FB4D0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x2FB640 Offset: 0x2FB741 VA: 0x2FB640
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2FB780 Offset: 0x2FB881 VA: 0x2FB780
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2FB8B0 Offset: 0x2FB9B1 VA: 0x2FB8B0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x2FB9F0 Offset: 0x2FBAF1 VA: 0x2FB9F0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2FBB30 Offset: 0x2FBC31 VA: 0x2FBB30
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x2FBC60 Offset: 0x2FBD61 VA: 0x2FBC60
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2FBD90 Offset: 0x2FBE91 VA: 0x2FBD90
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2FBEB0 Offset: 0x2FBFB1 VA: 0x2FBEB0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2FBFD0 Offset: 0x2FC0D1 VA: 0x2FBFD0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2FC110 Offset: 0x2FC211 VA: 0x2FC110
	|-Dictionary.ValueCollection.Enumerator<object, object>..ctor
	|
	|-RVA: 0x2FC2D0 Offset: 0x2FC3D1 VA: 0x2FC2D0
	|-Dictionary.ValueCollection.Enumerator<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x2FC3F0 Offset: 0x2FC4F1 VA: 0x2FC3F0
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2FC510 Offset: 0x2FC611 VA: 0x2FC510
	|-Dictionary.ValueCollection.Enumerator<object, sbyte>..ctor
	|
	|-RVA: 0x2FC630 Offset: 0x2FC731 VA: 0x2FC630
	|-Dictionary.ValueCollection.Enumerator<object, float>..ctor
	|
	|-RVA: 0x2FC750 Offset: 0x2FC851 VA: 0x2FC750
	|-Dictionary.ValueCollection.Enumerator<object, ushort>..ctor
	|
	|-RVA: 0x2FC870 Offset: 0x2FC971 VA: 0x2FC870
	|-Dictionary.ValueCollection.Enumerator<object, uint>..ctor
	|
	|-RVA: 0x2FC990 Offset: 0x2FCA91 VA: 0x2FC990
	|-Dictionary.ValueCollection.Enumerator<object, ulong>..ctor
	|
	|-RVA: 0x2FCAB0 Offset: 0x2FCBB1 VA: 0x2FCAB0
	|-Dictionary.ValueCollection.Enumerator<object, TransitionTables>..ctor
	|
	|-RVA: 0x2FCBF0 Offset: 0x2FCCF1 VA: 0x2FCBF0
	|-Dictionary.ValueCollection.Enumerator<object, Bounds>..ctor
	|
	|-RVA: 0x2FCD30 Offset: 0x2FCE31 VA: 0x2FCD30
	|-Dictionary.ValueCollection.Enumerator<object, BoundsInt>..ctor
	|
	|-RVA: 0x2FCE70 Offset: 0x2FCF71 VA: 0x2FCE70
	|-Dictionary.ValueCollection.Enumerator<object, Color32>..ctor
	|
	|-RVA: 0x2FCF90 Offset: 0x2FD091 VA: 0x2FCF90
	|-Dictionary.ValueCollection.Enumerator<object, Color>..ctor
	|
	|-RVA: 0x2FD0B0 Offset: 0x2FD1B1 VA: 0x2FD0B0
	|-Dictionary.ValueCollection.Enumerator<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x2FD1D0 Offset: 0x2FD2D1 VA: 0x2FD1D0
	|-Dictionary.ValueCollection.Enumerator<object, GradientColorKey>..ctor
	|
	|-RVA: 0x2FD310 Offset: 0x2FD411 VA: 0x2FD310
	|-Dictionary.ValueCollection.Enumerator<object, Keyframe>..ctor
	|
	|-RVA: 0x2FD460 Offset: 0x2FD561 VA: 0x2FD460
	|-Dictionary.ValueCollection.Enumerator<object, LayerMask>..ctor
	|
	|-RVA: 0x2FD580 Offset: 0x2FD681 VA: 0x2FD580
	|-Dictionary.ValueCollection.Enumerator<object, Matrix4x4>..ctor
	|
	|-RVA: 0x2FD6E0 Offset: 0x2FD7E1 VA: 0x2FD6E0
	|-Dictionary.ValueCollection.Enumerator<object, Playable>..ctor
	|
	|-RVA: 0x2FD800 Offset: 0x2FD901 VA: 0x2FD800
	|-Dictionary.ValueCollection.Enumerator<object, Quaternion>..ctor
	|
	|-RVA: 0x2FD920 Offset: 0x2FDA21 VA: 0x2FD920
	|-Dictionary.ValueCollection.Enumerator<object, RangeInt>..ctor
	|
	|-RVA: 0x2FDA40 Offset: 0x2FDB41 VA: 0x2FDA40
	|-Dictionary.ValueCollection.Enumerator<object, Rect>..ctor
	|
	|-RVA: 0x2FDB60 Offset: 0x2FDC61 VA: 0x2FDB60
	|-Dictionary.ValueCollection.Enumerator<object, RectInt>..ctor
	|
	|-RVA: 0x2FDC80 Offset: 0x2FDD81 VA: 0x2FDC80
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2FDDC0 Offset: 0x2FDEC1 VA: 0x2FDDC0
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2FDF00 Offset: 0x2FE001 VA: 0x2FDF00
	|-Dictionary.ValueCollection.Enumerator<object, Vector2>..ctor
	|
	|-RVA: 0x2FE020 Offset: 0x2FE121 VA: 0x2FE020
	|-Dictionary.ValueCollection.Enumerator<object, Vector2Int>..ctor
	|
	|-RVA: 0x2FE140 Offset: 0x2FE241 VA: 0x2FE140
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>..ctor
	|
	|-RVA: 0x2FE270 Offset: 0x2FE371 VA: 0x2FE270
	|-Dictionary.ValueCollection.Enumerator<object, Vector3Int>..ctor
	|
	|-RVA: 0x2FE3A0 Offset: 0x2FE4A1 VA: 0x2FE3A0
	|-Dictionary.ValueCollection.Enumerator<object, Vector4>..ctor
	|
	|-RVA: 0x2FE4C0 Offset: 0x2FE5C1 VA: 0x2FE4C0
	|-Dictionary.ValueCollection.Enumerator<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x2FE680 Offset: 0x2FE781 VA: 0x2FE680
	|-Dictionary.ValueCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2FE7A0 Offset: 0x2FE8A1 VA: 0x2FE7A0
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>..ctor
	|
	|-RVA: 0x2FE960 Offset: 0x2FEA61 VA: 0x2FE960
	|-Dictionary.ValueCollection.Enumerator<float, CurveSample>..ctor
	|
	|-RVA: 0x2FEAC0 Offset: 0x2FEBC1 VA: 0x2FEAC0
	|-Dictionary.ValueCollection.Enumerator<float, object>..ctor
	|
	|-RVA: 0x2FEC80 Offset: 0x2FED81 VA: 0x2FEC80
	|-Dictionary.ValueCollection.Enumerator<ushort, object>..ctor
	|
	|-RVA: 0x2FEE40 Offset: 0x2FEF41 VA: 0x2FEE40
	|-Dictionary.ValueCollection.Enumerator<uint, int>..ctor
	|
	|-RVA: 0x2FEF60 Offset: 0x2FF061 VA: 0x2FEF60
	|-Dictionary.ValueCollection.Enumerator<uint, Int32Enum>..ctor
	|
	|-RVA: 0x2FF080 Offset: 0x2FF181 VA: 0x2FF080
	|-Dictionary.ValueCollection.Enumerator<uint, object>..ctor
	|
	|-RVA: 0x2FF240 Offset: 0x2FF341 VA: 0x2FF240
	|-Dictionary.ValueCollection.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x2FF400 Offset: 0x2FF501 VA: 0x2FF400
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x2FF520 Offset: 0x2FF621 VA: 0x2FF520
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x2FF680 Offset: 0x2FF781 VA: 0x2FF680
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x2FF7D0 Offset: 0x2FF8D1 VA: 0x2FF7D0
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x2FF910 Offset: 0x2FFA11 VA: 0x2FF910
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x2FFA30 Offset: 0x2FFB31 VA: 0x2FFA30
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x2FFBF0 Offset: 0x2FFCF1 VA: 0x2FFBF0
	|-Dictionary.ValueCollection.Enumerator<Bounds, object>..ctor
	|
	|-RVA: 0x2FFDB0 Offset: 0x2FFEB1 VA: 0x2FFDB0
	|-Dictionary.ValueCollection.Enumerator<BoundsInt, object>..ctor
	|
	|-RVA: 0x2FFF70 Offset: 0x300071 VA: 0x2FFF70
	|-Dictionary.ValueCollection.Enumerator<Color, object>..ctor
	|
	|-RVA: 0x300130 Offset: 0x300231 VA: 0x300130
	|-Dictionary.ValueCollection.Enumerator<Color32, object>..ctor
	|
	|-RVA: 0x3002F0 Offset: 0x3003F1 VA: 0x3002F0
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x3004B0 Offset: 0x3005B1 VA: 0x3004B0
	|-Dictionary.ValueCollection.Enumerator<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x300670 Offset: 0x300771 VA: 0x300670
	|-Dictionary.ValueCollection.Enumerator<GradientColorKey, object>..ctor
	|
	|-RVA: 0x300830 Offset: 0x300931 VA: 0x300830
	|-Dictionary.ValueCollection.Enumerator<Keyframe, object>..ctor
	|
	|-RVA: 0x3009F0 Offset: 0x300AF1 VA: 0x3009F0
	|-Dictionary.ValueCollection.Enumerator<LayerMask, object>..ctor
	|
	|-RVA: 0x300BB0 Offset: 0x300CB1 VA: 0x300BB0
	|-Dictionary.ValueCollection.Enumerator<Matrix4x4, object>..ctor
	|
	|-RVA: 0x300D70 Offset: 0x300E71 VA: 0x300D70
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>..ctor
	|
	|-RVA: 0x300F30 Offset: 0x301031 VA: 0x300F30
	|-Dictionary.ValueCollection.Enumerator<Quaternion, object>..ctor
	|
	|-RVA: 0x3010F0 Offset: 0x3011F1 VA: 0x3010F0
	|-Dictionary.ValueCollection.Enumerator<RangeInt, object>..ctor
	|
	|-RVA: 0x3012B0 Offset: 0x3013B1 VA: 0x3012B0
	|-Dictionary.ValueCollection.Enumerator<Rect, object>..ctor
	|
	|-RVA: 0x301470 Offset: 0x301571 VA: 0x301470
	|-Dictionary.ValueCollection.Enumerator<RectInt, object>..ctor
	|
	|-RVA: 0x301630 Offset: 0x301731 VA: 0x301630
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x301750 Offset: 0x301851 VA: 0x301750
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x301910 Offset: 0x301A11 VA: 0x301910
	|-Dictionary.ValueCollection.Enumerator<Vector2, object>..ctor
	|
	|-RVA: 0x301AD0 Offset: 0x301BD1 VA: 0x301AD0
	|-Dictionary.ValueCollection.Enumerator<Vector2Int, object>..ctor
	|
	|-RVA: 0x301C90 Offset: 0x301D91 VA: 0x301C90
	|-Dictionary.ValueCollection.Enumerator<Vector3, object>..ctor
	|
	|-RVA: 0x301E50 Offset: 0x301F51 VA: 0x301E50
	|-Dictionary.ValueCollection.Enumerator<Vector3Int, object>..ctor
	|
	|-RVA: 0x302010 Offset: 0x302111 VA: 0x302010
	|-Dictionary.ValueCollection.Enumerator<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EC410 Offset: 0x2EC511 VA: 0x2EC410
	|-Dictionary.ValueCollection.Enumerator<BeanID, BeanData>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ActorID, LifeCycleScriptPlayer>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ActorID, GrappleController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ActorID, HandCuffsController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ActorID, MobTravelerController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<BadStatus, BadStatusEffectController.ObjInfo>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ToolChargeLevel, ParticleSystem>.Dispose
	|-Dictionary.ValueCollection.Enumerator<EquipSlotType, HumanEquipItem>.Dispose
	|-Dictionary.ValueCollection.Enumerator<GateDataID, GateController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<ItemID, ItemPoolData>.Dispose
	|-Dictionary.ValueCollection.Enumerator<SnowmanObjectID, SnowballData>.Dispose
	|-Dictionary.ValueCollection.Enumerator<SoundID, EnvironmentSoundController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x36AB20 Offset: 0x36AC21 VA: 0x36AB20
	|-Dictionary.ValueCollection.Enumerator<JSONDeserialization.TaskField, object>.Dispose
	|
	|-RVA: 0x36ACE0 Offset: 0x36ADE1 VA: 0x36ACE0
	|-Dictionary.ValueCollection.Enumerator<BitVector32Int, object>.Dispose
	|
	|-RVA: 0x2FC150 Offset: 0x2FC251 VA: 0x2FC150
	|-Dictionary.ValueCollection.Enumerator<Character, ActionSpeedController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Character, AvoidController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Character, BitController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Character, GrantAttributeController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Character, LazyController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Character, RestraintController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Character, SuperArmorController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Character, SpringManager>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Character, YawnController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, EmotionController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, EscapeController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, MagicController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, SlowStateController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, SoulController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, ThrottleController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, ActionCode>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, Transform>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Collider, CharacterNearCullingController>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Material, List<CombinedMesh.MaterialMeshInfo>>.Dispose
	|
	|-RVA: 0x2EC2F0 Offset: 0x2EC3F1 VA: 0x2EC2F0
	|-Dictionary.ValueCollection.Enumerator<EmotionType, Prefab>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x36AEA0 Offset: 0x36AFA1 VA: 0x36AEA0
	|-Dictionary.ValueCollection.Enumerator<EventCheckId, object>.Dispose
	|
	|-RVA: 0x36B060 Offset: 0x36B161 VA: 0x36B060
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.Dispose
	|
	|-RVA: 0x36B220 Offset: 0x36B321 VA: 0x36B220
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.Dispose
	|
	|-RVA: 0x36B3E0 Offset: 0x36B4E1 VA: 0x36B3E0
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.Dispose
	|
	|-RVA: 0x36B5A0 Offset: 0x36B6A1 VA: 0x36B5A0
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.Dispose
	|
	|-RVA: 0x2F04E0 Offset: 0x2F05E1 VA: 0x2F04E0
	|-Dictionary.ValueCollection.Enumerator<MonsterControllerBase, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<object, int>.Dispose
	|
	|-RVA: 0x2EBBD0 Offset: 0x2EBCD1 VA: 0x2EBBD0
	|-Dictionary.ValueCollection.Enumerator<MonsterDataID, MonsterDataTable>.Dispose
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterDataTable>.Dispose
	|
	|-RVA: 0x36B760 Offset: 0x36B861 VA: 0x36B760
	|-Dictionary.ValueCollection.Enumerator<MonsterHutSaveData, object>.Dispose
	|
	|-RVA: 0x36B920 Offset: 0x36BA21 VA: 0x36B920
	|-Dictionary.ValueCollection.Enumerator<OrderLotterySaveParameter, object>.Dispose
	|
	|-RVA: 0x36BAE0 Offset: 0x36BBE1 VA: 0x36BAE0
	|-Dictionary.ValueCollection.Enumerator<OrderSaveData, object>.Dispose
	|
	|-RVA: 0x36BCA0 Offset: 0x36BDA1 VA: 0x36BCA0
	|-Dictionary.ValueCollection.Enumerator<OrderSaveParameter, object>.Dispose
	|
	|-RVA: 0x36BE60 Offset: 0x36BF61 VA: 0x36BE60
	|-Dictionary.ValueCollection.Enumerator<Parameter, object>.Dispose
	|
	|-RVA: 0x36C020 Offset: 0x36C121 VA: 0x36C020
	|-Dictionary.ValueCollection.Enumerator<bool, object>.Dispose
	|
	|-RVA: 0x36C1E0 Offset: 0x36C2E1 VA: 0x36C1E0
	|-Dictionary.ValueCollection.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x2EA040 Offset: 0x2EA141 VA: 0x2EA040
	|-Dictionary.ValueCollection.Enumerator<char, object>.Dispose
	|
	|-RVA: 0x2EA200 Offset: 0x2EA301 VA: 0x2EA200
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.Dispose
	|
	|-RVA: 0x2EA3C0 Offset: 0x2EA4C1 VA: 0x2EA3C0
	|-Dictionary.ValueCollection.Enumerator<double, object>.Dispose
	|
	|-RVA: 0x2EA580 Offset: 0x2EA681 VA: 0x2EA580
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.Dispose
	|
	|-RVA: 0x2EA740 Offset: 0x2EA841 VA: 0x2EA740
	|-Dictionary.ValueCollection.Enumerator<short, object>.Dispose
	|
	|-RVA: 0x2EB520 Offset: 0x2EB621 VA: 0x2EB520
	|-Dictionary.ValueCollection.Enumerator<int, BossStageManager>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, AssetHandle>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, PointerEventData>.Dispose
	|
	|-RVA: 0x2EA940 Offset: 0x2EAA41 VA: 0x2EA940
	|-Dictionary.ValueCollection.Enumerator<int, CropDataTable>.Dispose
	|
	|-RVA: 0x2EAAA0 Offset: 0x2EABA1 VA: 0x2EAAA0
	|-Dictionary.ValueCollection.Enumerator<int, EffectDataTable>.Dispose
	|
	|-RVA: 0x2EABE0 Offset: 0x2EACE1 VA: 0x2EABE0
	|-Dictionary.ValueCollection.Enumerator<int, GimmickLayoutDataTable>.Dispose
	|
	|-RVA: 0x2EAD10 Offset: 0x2EAE11 VA: 0x2EAD10
	|-Dictionary.ValueCollection.Enumerator<int, MineTypeDataTable>.Dispose
	|
	|-RVA: 0x2EAE60 Offset: 0x2EAF61 VA: 0x2EAE60
	|-Dictionary.ValueCollection.Enumerator<int, MiningDataTable>.Dispose
	|
	|-RVA: 0x2EAF80 Offset: 0x2EB081 VA: 0x2EAF80
	|-Dictionary.ValueCollection.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x2EB0A0 Offset: 0x2EB1A1 VA: 0x2EB0A0
	|-Dictionary.ValueCollection.Enumerator<int, char>.Dispose
	|
	|-RVA: 0x2EB1C0 Offset: 0x2EB2C1 VA: 0x2EB1C0
	|-Dictionary.ValueCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x2EB2E0 Offset: 0x2EB3E1 VA: 0x2EB2E0
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x2EB400 Offset: 0x2EB501 VA: 0x2EB400
	|-Dictionary.ValueCollection.Enumerator<int, long>.Dispose
	|
	|-RVA: 0x2EB6F0 Offset: 0x2EB7F1 VA: 0x2EB6F0
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.Dispose
	|
	|-RVA: 0x2EB830 Offset: 0x2EB931 VA: 0x2EB830
	|-Dictionary.ValueCollection.Enumerator<int, SceneInstance>.Dispose
	|
	|-RVA: 0x2EB950 Offset: 0x2EBA51 VA: 0x2EB950
	|-Dictionary.ValueCollection.Enumerator<int, Vector2Int>.Dispose
	|
	|-RVA: 0x2EBA70 Offset: 0x2EBB71 VA: 0x2EBA70
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.Dispose
	|
	|-RVA: 0x2EBD30 Offset: 0x2EBE31 VA: 0x2EBD30
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.Dispose
	|
	|-RVA: 0x2EBE70 Offset: 0x2EBF71 VA: 0x2EBE70
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.Dispose
	|
	|-RVA: 0x2EBF90 Offset: 0x2EC091 VA: 0x2EBF90
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x2EC0B0 Offset: 0x2EC1B1 VA: 0x2EC0B0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2EC1D0 Offset: 0x2EC2D1 VA: 0x2EC1D0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x2EC5D0 Offset: 0x2EC6D1 VA: 0x2EC5D0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x2EC6F0 Offset: 0x2EC7F1 VA: 0x2EC6F0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x2EC810 Offset: 0x2EC911 VA: 0x2EC810
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.Dispose
	|
	|-RVA: 0x2EC930 Offset: 0x2ECA31 VA: 0x2EC930
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.Dispose
	|
	|-RVA: 0x2ECA60 Offset: 0x2ECB61 VA: 0x2ECA60
	|-Dictionary.ValueCollection.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x2ECC20 Offset: 0x2ECD21 VA: 0x2ECC20
	|-Dictionary.ValueCollection.Enumerator<Memory<object>, object>.Dispose
	|
	|-RVA: 0x2ECDE0 Offset: 0x2ECEE1 VA: 0x2ECDE0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Int32Enum>, object>.Dispose
	|
	|-RVA: 0x2ECFA0 Offset: 0x2ED0A1 VA: 0x2ECFA0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Bounds>, object>.Dispose
	|
	|-RVA: 0x2ED160 Offset: 0x2ED261 VA: 0x2ED160
	|-Dictionary.ValueCollection.Enumerator<Nullable<BoundsInt>, object>.Dispose
	|
	|-RVA: 0x2ED320 Offset: 0x2ED421 VA: 0x2ED320
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color32>, object>.Dispose
	|
	|-RVA: 0x2ED4E0 Offset: 0x2ED5E1 VA: 0x2ED4E0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color>, object>.Dispose
	|
	|-RVA: 0x2ED6A0 Offset: 0x2ED7A1 VA: 0x2ED6A0
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientAlphaKey>, object>.Dispose
	|
	|-RVA: 0x2ED860 Offset: 0x2ED961 VA: 0x2ED860
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientColorKey>, object>.Dispose
	|
	|-RVA: 0x2EDA20 Offset: 0x2EDB21 VA: 0x2EDA20
	|-Dictionary.ValueCollection.Enumerator<Nullable<Keyframe>, object>.Dispose
	|
	|-RVA: 0x2EDBE0 Offset: 0x2EDCE1 VA: 0x2EDBE0
	|-Dictionary.ValueCollection.Enumerator<Nullable<LayerMask>, object>.Dispose
	|
	|-RVA: 0x2EDDA0 Offset: 0x2EDEA1 VA: 0x2EDDA0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Matrix4x4>, object>.Dispose
	|
	|-RVA: 0x2EDF60 Offset: 0x2EE061 VA: 0x2EDF60
	|-Dictionary.ValueCollection.Enumerator<Nullable<Quaternion>, object>.Dispose
	|
	|-RVA: 0x2EE120 Offset: 0x2EE221 VA: 0x2EE120
	|-Dictionary.ValueCollection.Enumerator<Nullable<RangeInt>, object>.Dispose
	|
	|-RVA: 0x2EE2E0 Offset: 0x2EE3E1 VA: 0x2EE2E0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Rect>, object>.Dispose
	|
	|-RVA: 0x2EE4A0 Offset: 0x2EE5A1 VA: 0x2EE4A0
	|-Dictionary.ValueCollection.Enumerator<Nullable<RectInt>, object>.Dispose
	|
	|-RVA: 0x2EE660 Offset: 0x2EE761 VA: 0x2EE660
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2>, object>.Dispose
	|
	|-RVA: 0x2EE820 Offset: 0x2EE921 VA: 0x2EE820
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2Int>, object>.Dispose
	|
	|-RVA: 0x2EE9E0 Offset: 0x2EEAE1 VA: 0x2EE9E0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3>, object>.Dispose
	|
	|-RVA: 0x2EEBA0 Offset: 0x2EECA1 VA: 0x2EEBA0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3Int>, object>.Dispose
	|
	|-RVA: 0x2EED60 Offset: 0x2EEE61 VA: 0x2EED60
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector4>, object>.Dispose
	|
	|-RVA: 0x2EEF20 Offset: 0x2EF021 VA: 0x2EEF20
	|-Dictionary.ValueCollection.Enumerator<object, BitVector32Int>.Dispose
	|
	|-RVA: 0x2EF040 Offset: 0x2EF141 VA: 0x2EF040
	|-Dictionary.ValueCollection.Enumerator<object, EventCheckId>.Dispose
	|
	|-RVA: 0x2EF190 Offset: 0x2EF291 VA: 0x2EF190
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.Dispose
	|
	|-RVA: 0x2EF2E0 Offset: 0x2EF3E1 VA: 0x2EF2E0
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.Dispose
	|
	|-RVA: 0x2EF420 Offset: 0x2EF521 VA: 0x2EF420
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.Dispose
	|
	|-RVA: 0x2EF550 Offset: 0x2EF651 VA: 0x2EF550
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.Dispose
	|
	|-RVA: 0x2EF680 Offset: 0x2EF781 VA: 0x2EF680
	|-Dictionary.ValueCollection.Enumerator<object, MonsterHutSaveData>.Dispose
	|
	|-RVA: 0x2EF7C0 Offset: 0x2EF8C1 VA: 0x2EF7C0
	|-Dictionary.ValueCollection.Enumerator<object, OrderLotterySaveParameter>.Dispose
	|
	|-RVA: 0x2EF900 Offset: 0x2EFA01 VA: 0x2EF900
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveData>.Dispose
	|
	|-RVA: 0x2EFA40 Offset: 0x2EFB41 VA: 0x2EFA40
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveParameter>.Dispose
	|
	|-RVA: 0x2EFBB0 Offset: 0x2EFCB1 VA: 0x2EFBB0
	|-Dictionary.ValueCollection.Enumerator<object, Parameter>.Dispose
	|
	|-RVA: 0x2EFD00 Offset: 0x2EFE01 VA: 0x2EFD00
	|-Dictionary.ValueCollection.Enumerator<object, NumberControl.ValueRange>.Dispose
	|
	|-RVA: 0x2EFE20 Offset: 0x2EFF21 VA: 0x2EFE20
	|-Dictionary.ValueCollection.Enumerator<object, bool>.Dispose
	|
	|-RVA: 0x2EFF40 Offset: 0x2F0041 VA: 0x2EFF40
	|-Dictionary.ValueCollection.Enumerator<object, byte>.Dispose
	|
	|-RVA: 0x2F0060 Offset: 0x2F0161 VA: 0x2F0060
	|-Dictionary.ValueCollection.Enumerator<object, char>.Dispose
	|
	|-RVA: 0x2F0180 Offset: 0x2F0281 VA: 0x2F0180
	|-Dictionary.ValueCollection.Enumerator<object, DateTime>.Dispose
	|
	|-RVA: 0x2F02A0 Offset: 0x2F03A1 VA: 0x2F02A0
	|-Dictionary.ValueCollection.Enumerator<object, double>.Dispose
	|
	|-RVA: 0x2F03C0 Offset: 0x2F04C1 VA: 0x2F03C0
	|-Dictionary.ValueCollection.Enumerator<object, short>.Dispose
	|
	|-RVA: 0x2F0600 Offset: 0x2F0701 VA: 0x2F0600
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x2F0720 Offset: 0x2F0821 VA: 0x2F0720
	|-Dictionary.ValueCollection.Enumerator<object, long>.Dispose
	|
	|-RVA: 0x2F0840 Offset: 0x2F0941 VA: 0x2F0840
	|-Dictionary.ValueCollection.Enumerator<object, Memory<object>>.Dispose
	|
	|-RVA: 0x2F0960 Offset: 0x2F0A61 VA: 0x2F0960
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Int32Enum>>.Dispose
	|
	|-RVA: 0x2F0A90 Offset: 0x2F0B91 VA: 0x2F0A90
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Bounds>>.Dispose
	|
	|-RVA: 0x2F0BE0 Offset: 0x2F0CE1 VA: 0x2F0BE0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<BoundsInt>>.Dispose
	|
	|-RVA: 0x2F0D20 Offset: 0x2F0E21 VA: 0x2F0D20
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color32>>.Dispose
	|
	|-RVA: 0x2F0E40 Offset: 0x2F0F41 VA: 0x2F0E40
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color>>.Dispose
	|
	|-RVA: 0x2F0F80 Offset: 0x2F1081 VA: 0x2F0F80
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x2F10B0 Offset: 0x2F11B1 VA: 0x2F10B0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientColorKey>>.Dispose
	|
	|-RVA: 0x2F11F0 Offset: 0x2F12F1 VA: 0x2F11F0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Keyframe>>.Dispose
	|
	|-RVA: 0x2F1330 Offset: 0x2F1431 VA: 0x2F1330
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<LayerMask>>.Dispose
	|
	|-RVA: 0x2FB520 Offset: 0x2FB621 VA: 0x2FB520
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Matrix4x4>>.Dispose
	|
	|-RVA: 0x2FB680 Offset: 0x2FB781 VA: 0x2FB680
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Quaternion>>.Dispose
	|
	|-RVA: 0x2FB7C0 Offset: 0x2FB8C1 VA: 0x2FB7C0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RangeInt>>.Dispose
	|
	|-RVA: 0x2FB8F0 Offset: 0x2FB9F1 VA: 0x2FB8F0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Rect>>.Dispose
	|
	|-RVA: 0x2FBA30 Offset: 0x2FBB31 VA: 0x2FBA30
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RectInt>>.Dispose
	|
	|-RVA: 0x2FBB70 Offset: 0x2FBC71 VA: 0x2FBB70
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2>>.Dispose
	|
	|-RVA: 0x2FBCA0 Offset: 0x2FBDA1 VA: 0x2FBCA0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2Int>>.Dispose
	|
	|-RVA: 0x2FBDD0 Offset: 0x2FBED1 VA: 0x2FBDD0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3>>.Dispose
	|
	|-RVA: 0x2FBEF0 Offset: 0x2FBFF1 VA: 0x2FBEF0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3Int>>.Dispose
	|
	|-RVA: 0x2FC010 Offset: 0x2FC111 VA: 0x2FC010
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector4>>.Dispose
	|
	|-RVA: 0x2FC310 Offset: 0x2FC411 VA: 0x2FC310
	|-Dictionary.ValueCollection.Enumerator<object, ReadOnlyMemory<object>>.Dispose
	|
	|-RVA: 0x2FC430 Offset: 0x2FC531 VA: 0x2FC430
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.Dispose
	|
	|-RVA: 0x2FC550 Offset: 0x2FC651 VA: 0x2FC550
	|-Dictionary.ValueCollection.Enumerator<object, sbyte>.Dispose
	|
	|-RVA: 0x2FC670 Offset: 0x2FC771 VA: 0x2FC670
	|-Dictionary.ValueCollection.Enumerator<object, float>.Dispose
	|
	|-RVA: 0x2FC790 Offset: 0x2FC891 VA: 0x2FC790
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.Dispose
	|
	|-RVA: 0x2FC8B0 Offset: 0x2FC9B1 VA: 0x2FC8B0
	|-Dictionary.ValueCollection.Enumerator<object, uint>.Dispose
	|
	|-RVA: 0x2FC9D0 Offset: 0x2FCAD1 VA: 0x2FC9D0
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.Dispose
	|
	|-RVA: 0x2FCAF0 Offset: 0x2FCBF1 VA: 0x2FCAF0
	|-Dictionary.ValueCollection.Enumerator<object, TransitionTables>.Dispose
	|
	|-RVA: 0x2FCC30 Offset: 0x2FCD31 VA: 0x2FCC30
	|-Dictionary.ValueCollection.Enumerator<object, Bounds>.Dispose
	|
	|-RVA: 0x2FCD70 Offset: 0x2FCE71 VA: 0x2FCD70
	|-Dictionary.ValueCollection.Enumerator<object, BoundsInt>.Dispose
	|
	|-RVA: 0x2FCEB0 Offset: 0x2FCFB1 VA: 0x2FCEB0
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.Dispose
	|
	|-RVA: 0x2FCFD0 Offset: 0x2FD0D1 VA: 0x2FCFD0
	|-Dictionary.ValueCollection.Enumerator<object, Color>.Dispose
	|
	|-RVA: 0x2FD0F0 Offset: 0x2FD1F1 VA: 0x2FD0F0
	|-Dictionary.ValueCollection.Enumerator<object, GradientAlphaKey>.Dispose
	|
	|-RVA: 0x2FD210 Offset: 0x2FD311 VA: 0x2FD210
	|-Dictionary.ValueCollection.Enumerator<object, GradientColorKey>.Dispose
	|
	|-RVA: 0x2FD360 Offset: 0x2FD461 VA: 0x2FD360
	|-Dictionary.ValueCollection.Enumerator<object, Keyframe>.Dispose
	|
	|-RVA: 0x2FD4A0 Offset: 0x2FD5A1 VA: 0x2FD4A0
	|-Dictionary.ValueCollection.Enumerator<object, LayerMask>.Dispose
	|
	|-RVA: 0x2FD5D0 Offset: 0x2FD6D1 VA: 0x2FD5D0
	|-Dictionary.ValueCollection.Enumerator<object, Matrix4x4>.Dispose
	|
	|-RVA: 0x2FD720 Offset: 0x2FD821 VA: 0x2FD720
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.Dispose
	|
	|-RVA: 0x2FD840 Offset: 0x2FD941 VA: 0x2FD840
	|-Dictionary.ValueCollection.Enumerator<object, Quaternion>.Dispose
	|
	|-RVA: 0x2FD960 Offset: 0x2FDA61 VA: 0x2FD960
	|-Dictionary.ValueCollection.Enumerator<object, RangeInt>.Dispose
	|
	|-RVA: 0x2FDA80 Offset: 0x2FDB81 VA: 0x2FDA80
	|-Dictionary.ValueCollection.Enumerator<object, Rect>.Dispose
	|
	|-RVA: 0x2FDBA0 Offset: 0x2FDCA1 VA: 0x2FDBA0
	|-Dictionary.ValueCollection.Enumerator<object, RectInt>.Dispose
	|
	|-RVA: 0x2FDCC0 Offset: 0x2FDDC1 VA: 0x2FDCC0
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x2FDE00 Offset: 0x2FDF01 VA: 0x2FDE00
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x2FDF40 Offset: 0x2FE041 VA: 0x2FDF40
	|-Dictionary.ValueCollection.Enumerator<object, Vector2>.Dispose
	|
	|-RVA: 0x2FE060 Offset: 0x2FE161 VA: 0x2FE060
	|-Dictionary.ValueCollection.Enumerator<object, Vector2Int>.Dispose
	|
	|-RVA: 0x2FE180 Offset: 0x2FE281 VA: 0x2FE180
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.Dispose
	|
	|-RVA: 0x2FE2B0 Offset: 0x2FE3B1 VA: 0x2FE2B0
	|-Dictionary.ValueCollection.Enumerator<object, Vector3Int>.Dispose
	|
	|-RVA: 0x2FE3E0 Offset: 0x2FE4E1 VA: 0x2FE3E0
	|-Dictionary.ValueCollection.Enumerator<object, Vector4>.Dispose
	|
	|-RVA: 0x2FE500 Offset: 0x2FE601 VA: 0x2FE500
	|-Dictionary.ValueCollection.Enumerator<ReadOnlyMemory<object>, object>.Dispose
	|
	|-RVA: 0x2FE6C0 Offset: 0x2FE7C1 VA: 0x2FE6C0
	|-Dictionary.ValueCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.Dispose
	|
	|-RVA: 0x2FE7E0 Offset: 0x2FE8E1 VA: 0x2FE7E0
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.Dispose
	|
	|-RVA: 0x2FE9B0 Offset: 0x2FEAB1 VA: 0x2FE9B0
	|-Dictionary.ValueCollection.Enumerator<float, CurveSample>.Dispose
	|
	|-RVA: 0x2FEB00 Offset: 0x2FEC01 VA: 0x2FEB00
	|-Dictionary.ValueCollection.Enumerator<float, object>.Dispose
	|
	|-RVA: 0x2FECC0 Offset: 0x2FEDC1 VA: 0x2FECC0
	|-Dictionary.ValueCollection.Enumerator<ushort, object>.Dispose
	|
	|-RVA: 0x2FF0C0 Offset: 0x2FF1C1 VA: 0x2FF0C0
	|-Dictionary.ValueCollection.Enumerator<uint, FriendMonsterStatus>.Dispose
	|-Dictionary.ValueCollection.Enumerator<uint, object>.Dispose
	|
	|-RVA: 0x2FEE80 Offset: 0x2FEF81 VA: 0x2FEE80
	|-Dictionary.ValueCollection.Enumerator<uint, int>.Dispose
	|
	|-RVA: 0x2FEFA0 Offset: 0x2FF0A1 VA: 0x2FEFA0
	|-Dictionary.ValueCollection.Enumerator<uint, Int32Enum>.Dispose
	|
	|-RVA: 0x2FF280 Offset: 0x2FF381 VA: 0x2FF280
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.Dispose
	|
	|-RVA: 0x2FF440 Offset: 0x2FF541 VA: 0x2FF440
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, int>.Dispose
	|
	|-RVA: 0x2FF570 Offset: 0x2FF671 VA: 0x2FF570
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, CapEdge>.Dispose
	|
	|-RVA: 0x2FF6D0 Offset: 0x2FF7D1 VA: 0x2FF6D0
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.Dispose
	|
	|-RVA: 0x2FF810 Offset: 0x2FF911 VA: 0x2FF810
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.Dispose
	|
	|-RVA: 0x2FF950 Offset: 0x2FFA51 VA: 0x2FF950
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, bool>.Dispose
	|
	|-RVA: 0x2FFA70 Offset: 0x2FFB71 VA: 0x2FFA70
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, object>.Dispose
	|
	|-RVA: 0x2FFC30 Offset: 0x2FFD31 VA: 0x2FFC30
	|-Dictionary.ValueCollection.Enumerator<Bounds, object>.Dispose
	|
	|-RVA: 0x2FFDF0 Offset: 0x2FFEF1 VA: 0x2FFDF0
	|-Dictionary.ValueCollection.Enumerator<BoundsInt, object>.Dispose
	|
	|-RVA: 0x2FFFB0 Offset: 0x3000B1 VA: 0x2FFFB0
	|-Dictionary.ValueCollection.Enumerator<Color, object>.Dispose
	|
	|-RVA: 0x300170 Offset: 0x300271 VA: 0x300170
	|-Dictionary.ValueCollection.Enumerator<Color32, object>.Dispose
	|
	|-RVA: 0x300330 Offset: 0x300431 VA: 0x300330
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.Dispose
	|
	|-RVA: 0x3004F0 Offset: 0x3005F1 VA: 0x3004F0
	|-Dictionary.ValueCollection.Enumerator<GradientAlphaKey, object>.Dispose
	|
	|-RVA: 0x3006B0 Offset: 0x3007B1 VA: 0x3006B0
	|-Dictionary.ValueCollection.Enumerator<GradientColorKey, object>.Dispose
	|
	|-RVA: 0x300870 Offset: 0x300971 VA: 0x300870
	|-Dictionary.ValueCollection.Enumerator<Keyframe, object>.Dispose
	|
	|-RVA: 0x300A30 Offset: 0x300B31 VA: 0x300A30
	|-Dictionary.ValueCollection.Enumerator<LayerMask, object>.Dispose
	|
	|-RVA: 0x300BF0 Offset: 0x300CF1 VA: 0x300BF0
	|-Dictionary.ValueCollection.Enumerator<Matrix4x4, object>.Dispose
	|
	|-RVA: 0x300DB0 Offset: 0x300EB1 VA: 0x300DB0
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.Dispose
	|
	|-RVA: 0x300F70 Offset: 0x301071 VA: 0x300F70
	|-Dictionary.ValueCollection.Enumerator<Quaternion, object>.Dispose
	|
	|-RVA: 0x301130 Offset: 0x301231 VA: 0x301130
	|-Dictionary.ValueCollection.Enumerator<RangeInt, object>.Dispose
	|
	|-RVA: 0x3012F0 Offset: 0x3013F1 VA: 0x3012F0
	|-Dictionary.ValueCollection.Enumerator<Rect, object>.Dispose
	|
	|-RVA: 0x3014B0 Offset: 0x3015B1 VA: 0x3014B0
	|-Dictionary.ValueCollection.Enumerator<RectInt, object>.Dispose
	|
	|-RVA: 0x301670 Offset: 0x301771 VA: 0x301670
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.Dispose
	|
	|-RVA: 0x301790 Offset: 0x301891 VA: 0x301790
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.Dispose
	|
	|-RVA: 0x301950 Offset: 0x301A51 VA: 0x301950
	|-Dictionary.ValueCollection.Enumerator<Vector2, object>.Dispose
	|
	|-RVA: 0x301B10 Offset: 0x301C11 VA: 0x301B10
	|-Dictionary.ValueCollection.Enumerator<Vector2Int, object>.Dispose
	|
	|-RVA: 0x301CD0 Offset: 0x301DD1 VA: 0x301CD0
	|-Dictionary.ValueCollection.Enumerator<Vector3, object>.Dispose
	|
	|-RVA: 0x301E90 Offset: 0x301F91 VA: 0x301E90
	|-Dictionary.ValueCollection.Enumerator<Vector3Int, object>.Dispose
	|
	|-RVA: 0x302050 Offset: 0x302151 VA: 0x302050
	|-Dictionary.ValueCollection.Enumerator<Vector4, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EC420 Offset: 0x2EC521 VA: 0x2EC420
	|-Dictionary.ValueCollection.Enumerator<BeanID, BeanData>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ActorID, LifeCycleScriptPlayer>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ActorID, GrappleController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ActorID, HandCuffsController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ActorID, MobTravelerController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<BadStatus, BadStatusEffectController.ObjInfo>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ToolChargeLevel, ParticleSystem>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<EquipSlotType, HumanEquipItem>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<GateDataID, GateController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<ItemID, ItemPoolData>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<SnowmanObjectID, SnowballData>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<SoundID, EnvironmentSoundController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x36AB30 Offset: 0x36AC31 VA: 0x36AB30
	|-Dictionary.ValueCollection.Enumerator<JSONDeserialization.TaskField, object>.MoveNext
	|
	|-RVA: 0x36ACF0 Offset: 0x36ADF1 VA: 0x36ACF0
	|-Dictionary.ValueCollection.Enumerator<BitVector32Int, object>.MoveNext
	|
	|-RVA: 0x2FC160 Offset: 0x2FC261 VA: 0x2FC160
	|-Dictionary.ValueCollection.Enumerator<Character, ActionSpeedController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Character, AvoidController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Character, BitController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Character, GrantAttributeController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Character, LazyController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Character, RestraintController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Character, SuperArmorController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Character, SpringManager>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Character, YawnController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, EmotionController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, EscapeController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, MagicController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, SlowStateController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, SoulController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, ThrottleController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, ActionCode>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, Transform>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Collider, CharacterNearCullingController>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Material, List<CombinedMesh.MaterialMeshInfo>>.MoveNext
	|
	|-RVA: 0x2EC300 Offset: 0x2EC401 VA: 0x2EC300
	|-Dictionary.ValueCollection.Enumerator<EmotionType, Prefab>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x36AEB0 Offset: 0x36AFB1 VA: 0x36AEB0
	|-Dictionary.ValueCollection.Enumerator<EventCheckId, object>.MoveNext
	|
	|-RVA: 0x36B070 Offset: 0x36B171 VA: 0x36B070
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.MoveNext
	|
	|-RVA: 0x36B230 Offset: 0x36B331 VA: 0x36B230
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.MoveNext
	|
	|-RVA: 0x36B3F0 Offset: 0x36B4F1 VA: 0x36B3F0
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.MoveNext
	|
	|-RVA: 0x36B5B0 Offset: 0x36B6B1 VA: 0x36B5B0
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.MoveNext
	|
	|-RVA: 0x2F04F0 Offset: 0x2F05F1 VA: 0x2F04F0
	|-Dictionary.ValueCollection.Enumerator<MonsterControllerBase, int>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<object, int>.MoveNext
	|
	|-RVA: 0x2EBBE0 Offset: 0x2EBCE1 VA: 0x2EBBE0
	|-Dictionary.ValueCollection.Enumerator<MonsterDataID, MonsterDataTable>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterDataTable>.MoveNext
	|
	|-RVA: 0x36B770 Offset: 0x36B871 VA: 0x36B770
	|-Dictionary.ValueCollection.Enumerator<MonsterHutSaveData, object>.MoveNext
	|
	|-RVA: 0x36B930 Offset: 0x36BA31 VA: 0x36B930
	|-Dictionary.ValueCollection.Enumerator<OrderLotterySaveParameter, object>.MoveNext
	|
	|-RVA: 0x36BAF0 Offset: 0x36BBF1 VA: 0x36BAF0
	|-Dictionary.ValueCollection.Enumerator<OrderSaveData, object>.MoveNext
	|
	|-RVA: 0x36BCB0 Offset: 0x36BDB1 VA: 0x36BCB0
	|-Dictionary.ValueCollection.Enumerator<OrderSaveParameter, object>.MoveNext
	|
	|-RVA: 0x36BE70 Offset: 0x36BF71 VA: 0x36BE70
	|-Dictionary.ValueCollection.Enumerator<Parameter, object>.MoveNext
	|
	|-RVA: 0x36C030 Offset: 0x36C131 VA: 0x36C030
	|-Dictionary.ValueCollection.Enumerator<bool, object>.MoveNext
	|
	|-RVA: 0x36C1F0 Offset: 0x36C2F1 VA: 0x36C1F0
	|-Dictionary.ValueCollection.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x2EA050 Offset: 0x2EA151 VA: 0x2EA050
	|-Dictionary.ValueCollection.Enumerator<char, object>.MoveNext
	|
	|-RVA: 0x2EA210 Offset: 0x2EA311 VA: 0x2EA210
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.MoveNext
	|
	|-RVA: 0x2EA3D0 Offset: 0x2EA4D1 VA: 0x2EA3D0
	|-Dictionary.ValueCollection.Enumerator<double, object>.MoveNext
	|
	|-RVA: 0x2EA590 Offset: 0x2EA691 VA: 0x2EA590
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.MoveNext
	|
	|-RVA: 0x2EA750 Offset: 0x2EA851 VA: 0x2EA750
	|-Dictionary.ValueCollection.Enumerator<short, object>.MoveNext
	|
	|-RVA: 0x2EB530 Offset: 0x2EB631 VA: 0x2EB530
	|-Dictionary.ValueCollection.Enumerator<int, BossStageManager>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, AssetHandle>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, PointerEventData>.MoveNext
	|
	|-RVA: 0x2EA950 Offset: 0x2EAA51 VA: 0x2EA950
	|-Dictionary.ValueCollection.Enumerator<int, CropDataTable>.MoveNext
	|
	|-RVA: 0x2EAAB0 Offset: 0x2EABB1 VA: 0x2EAAB0
	|-Dictionary.ValueCollection.Enumerator<int, EffectDataTable>.MoveNext
	|
	|-RVA: 0x2EABF0 Offset: 0x2EACF1 VA: 0x2EABF0
	|-Dictionary.ValueCollection.Enumerator<int, GimmickLayoutDataTable>.MoveNext
	|
	|-RVA: 0x2EAD20 Offset: 0x2EAE21 VA: 0x2EAD20
	|-Dictionary.ValueCollection.Enumerator<int, MineTypeDataTable>.MoveNext
	|
	|-RVA: 0x2EAE70 Offset: 0x2EAF71 VA: 0x2EAE70
	|-Dictionary.ValueCollection.Enumerator<int, MiningDataTable>.MoveNext
	|
	|-RVA: 0x2EAF90 Offset: 0x2EB091 VA: 0x2EAF90
	|-Dictionary.ValueCollection.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x2EB0B0 Offset: 0x2EB1B1 VA: 0x2EB0B0
	|-Dictionary.ValueCollection.Enumerator<int, char>.MoveNext
	|
	|-RVA: 0x2EB1D0 Offset: 0x2EB2D1 VA: 0x2EB1D0
	|-Dictionary.ValueCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x2EB2F0 Offset: 0x2EB3F1 VA: 0x2EB2F0
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x2EB410 Offset: 0x2EB511 VA: 0x2EB410
	|-Dictionary.ValueCollection.Enumerator<int, long>.MoveNext
	|
	|-RVA: 0x2EB700 Offset: 0x2EB801 VA: 0x2EB700
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x2EB840 Offset: 0x2EB941 VA: 0x2EB840
	|-Dictionary.ValueCollection.Enumerator<int, SceneInstance>.MoveNext
	|
	|-RVA: 0x2EB960 Offset: 0x2EBA61 VA: 0x2EB960
	|-Dictionary.ValueCollection.Enumerator<int, Vector2Int>.MoveNext
	|
	|-RVA: 0x2EBA80 Offset: 0x2EBB81 VA: 0x2EBA80
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.MoveNext
	|
	|-RVA: 0x2EBD40 Offset: 0x2EBE41 VA: 0x2EBD40
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.MoveNext
	|
	|-RVA: 0x2EBE80 Offset: 0x2EBF81 VA: 0x2EBE80
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.MoveNext
	|
	|-RVA: 0x2EBFA0 Offset: 0x2EC0A1 VA: 0x2EBFA0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x2EC0C0 Offset: 0x2EC1C1 VA: 0x2EC0C0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2EC1E0 Offset: 0x2EC2E1 VA: 0x2EC1E0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x2EC5E0 Offset: 0x2EC6E1 VA: 0x2EC5E0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x2EC700 Offset: 0x2EC801 VA: 0x2EC700
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x2EC820 Offset: 0x2EC921 VA: 0x2EC820
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.MoveNext
	|
	|-RVA: 0x2EC940 Offset: 0x2ECA41 VA: 0x2EC940
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.MoveNext
	|
	|-RVA: 0x2ECA70 Offset: 0x2ECB71 VA: 0x2ECA70
	|-Dictionary.ValueCollection.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x2ECC30 Offset: 0x2ECD31 VA: 0x2ECC30
	|-Dictionary.ValueCollection.Enumerator<Memory<object>, object>.MoveNext
	|
	|-RVA: 0x2ECDF0 Offset: 0x2ECEF1 VA: 0x2ECDF0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Int32Enum>, object>.MoveNext
	|
	|-RVA: 0x2ECFB0 Offset: 0x2ED0B1 VA: 0x2ECFB0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Bounds>, object>.MoveNext
	|
	|-RVA: 0x2ED170 Offset: 0x2ED271 VA: 0x2ED170
	|-Dictionary.ValueCollection.Enumerator<Nullable<BoundsInt>, object>.MoveNext
	|
	|-RVA: 0x2ED330 Offset: 0x2ED431 VA: 0x2ED330
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color32>, object>.MoveNext
	|
	|-RVA: 0x2ED4F0 Offset: 0x2ED5F1 VA: 0x2ED4F0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color>, object>.MoveNext
	|
	|-RVA: 0x2ED6B0 Offset: 0x2ED7B1 VA: 0x2ED6B0
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientAlphaKey>, object>.MoveNext
	|
	|-RVA: 0x2ED870 Offset: 0x2ED971 VA: 0x2ED870
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientColorKey>, object>.MoveNext
	|
	|-RVA: 0x2EDA30 Offset: 0x2EDB31 VA: 0x2EDA30
	|-Dictionary.ValueCollection.Enumerator<Nullable<Keyframe>, object>.MoveNext
	|
	|-RVA: 0x2EDBF0 Offset: 0x2EDCF1 VA: 0x2EDBF0
	|-Dictionary.ValueCollection.Enumerator<Nullable<LayerMask>, object>.MoveNext
	|
	|-RVA: 0x2EDDB0 Offset: 0x2EDEB1 VA: 0x2EDDB0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Matrix4x4>, object>.MoveNext
	|
	|-RVA: 0x2EDF70 Offset: 0x2EE071 VA: 0x2EDF70
	|-Dictionary.ValueCollection.Enumerator<Nullable<Quaternion>, object>.MoveNext
	|
	|-RVA: 0x2EE130 Offset: 0x2EE231 VA: 0x2EE130
	|-Dictionary.ValueCollection.Enumerator<Nullable<RangeInt>, object>.MoveNext
	|
	|-RVA: 0x2EE2F0 Offset: 0x2EE3F1 VA: 0x2EE2F0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Rect>, object>.MoveNext
	|
	|-RVA: 0x2EE4B0 Offset: 0x2EE5B1 VA: 0x2EE4B0
	|-Dictionary.ValueCollection.Enumerator<Nullable<RectInt>, object>.MoveNext
	|
	|-RVA: 0x2EE670 Offset: 0x2EE771 VA: 0x2EE670
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2>, object>.MoveNext
	|
	|-RVA: 0x2EE830 Offset: 0x2EE931 VA: 0x2EE830
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2Int>, object>.MoveNext
	|
	|-RVA: 0x2EE9F0 Offset: 0x2EEAF1 VA: 0x2EE9F0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3>, object>.MoveNext
	|
	|-RVA: 0x2EEBB0 Offset: 0x2EECB1 VA: 0x2EEBB0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3Int>, object>.MoveNext
	|
	|-RVA: 0x2EED70 Offset: 0x2EEE71 VA: 0x2EED70
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector4>, object>.MoveNext
	|
	|-RVA: 0x2EEF30 Offset: 0x2EF031 VA: 0x2EEF30
	|-Dictionary.ValueCollection.Enumerator<object, BitVector32Int>.MoveNext
	|
	|-RVA: 0x2EF050 Offset: 0x2EF151 VA: 0x2EF050
	|-Dictionary.ValueCollection.Enumerator<object, EventCheckId>.MoveNext
	|
	|-RVA: 0x2EF1A0 Offset: 0x2EF2A1 VA: 0x2EF1A0
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.MoveNext
	|
	|-RVA: 0x2EF2F0 Offset: 0x2EF3F1 VA: 0x2EF2F0
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.MoveNext
	|
	|-RVA: 0x2EF430 Offset: 0x2EF531 VA: 0x2EF430
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.MoveNext
	|
	|-RVA: 0x2EF560 Offset: 0x2EF661 VA: 0x2EF560
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.MoveNext
	|
	|-RVA: 0x2EF690 Offset: 0x2EF791 VA: 0x2EF690
	|-Dictionary.ValueCollection.Enumerator<object, MonsterHutSaveData>.MoveNext
	|
	|-RVA: 0x2EF7D0 Offset: 0x2EF8D1 VA: 0x2EF7D0
	|-Dictionary.ValueCollection.Enumerator<object, OrderLotterySaveParameter>.MoveNext
	|
	|-RVA: 0x2EF910 Offset: 0x2EFA11 VA: 0x2EF910
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveData>.MoveNext
	|
	|-RVA: 0x2EFA50 Offset: 0x2EFB51 VA: 0x2EFA50
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveParameter>.MoveNext
	|
	|-RVA: 0x2EFBC0 Offset: 0x2EFCC1 VA: 0x2EFBC0
	|-Dictionary.ValueCollection.Enumerator<object, Parameter>.MoveNext
	|
	|-RVA: 0x2EFD10 Offset: 0x2EFE11 VA: 0x2EFD10
	|-Dictionary.ValueCollection.Enumerator<object, NumberControl.ValueRange>.MoveNext
	|
	|-RVA: 0x2EFE30 Offset: 0x2EFF31 VA: 0x2EFE30
	|-Dictionary.ValueCollection.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x2EFF50 Offset: 0x2F0051 VA: 0x2EFF50
	|-Dictionary.ValueCollection.Enumerator<object, byte>.MoveNext
	|
	|-RVA: 0x2F0070 Offset: 0x2F0171 VA: 0x2F0070
	|-Dictionary.ValueCollection.Enumerator<object, char>.MoveNext
	|
	|-RVA: 0x2F0190 Offset: 0x2F0291 VA: 0x2F0190
	|-Dictionary.ValueCollection.Enumerator<object, DateTime>.MoveNext
	|
	|-RVA: 0x2F02B0 Offset: 0x2F03B1 VA: 0x2F02B0
	|-Dictionary.ValueCollection.Enumerator<object, double>.MoveNext
	|
	|-RVA: 0x2F03D0 Offset: 0x2F04D1 VA: 0x2F03D0
	|-Dictionary.ValueCollection.Enumerator<object, short>.MoveNext
	|
	|-RVA: 0x2F0610 Offset: 0x2F0711 VA: 0x2F0610
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x2F0730 Offset: 0x2F0831 VA: 0x2F0730
	|-Dictionary.ValueCollection.Enumerator<object, long>.MoveNext
	|
	|-RVA: 0x2F0850 Offset: 0x2F0951 VA: 0x2F0850
	|-Dictionary.ValueCollection.Enumerator<object, Memory<object>>.MoveNext
	|
	|-RVA: 0x2F0970 Offset: 0x2F0A71 VA: 0x2F0970
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Int32Enum>>.MoveNext
	|
	|-RVA: 0x2F0AA0 Offset: 0x2F0BA1 VA: 0x2F0AA0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Bounds>>.MoveNext
	|
	|-RVA: 0x2F0BF0 Offset: 0x2F0CF1 VA: 0x2F0BF0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<BoundsInt>>.MoveNext
	|
	|-RVA: 0x2F0D30 Offset: 0x2F0E31 VA: 0x2F0D30
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color32>>.MoveNext
	|
	|-RVA: 0x2F0E50 Offset: 0x2F0F51 VA: 0x2F0E50
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color>>.MoveNext
	|
	|-RVA: 0x2F0F90 Offset: 0x2F1091 VA: 0x2F0F90
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x2F10C0 Offset: 0x2F11C1 VA: 0x2F10C0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientColorKey>>.MoveNext
	|
	|-RVA: 0x2F1200 Offset: 0x2F1301 VA: 0x2F1200
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Keyframe>>.MoveNext
	|
	|-RVA: 0x2F1340 Offset: 0x2F1441 VA: 0x2F1340
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<LayerMask>>.MoveNext
	|
	|-RVA: 0x2FB530 Offset: 0x2FB631 VA: 0x2FB530
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Matrix4x4>>.MoveNext
	|
	|-RVA: 0x2FB690 Offset: 0x2FB791 VA: 0x2FB690
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Quaternion>>.MoveNext
	|
	|-RVA: 0x2FB7D0 Offset: 0x2FB8D1 VA: 0x2FB7D0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RangeInt>>.MoveNext
	|
	|-RVA: 0x2FB900 Offset: 0x2FBA01 VA: 0x2FB900
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Rect>>.MoveNext
	|
	|-RVA: 0x2FBA40 Offset: 0x2FBB41 VA: 0x2FBA40
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RectInt>>.MoveNext
	|
	|-RVA: 0x2FBB80 Offset: 0x2FBC81 VA: 0x2FBB80
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2>>.MoveNext
	|
	|-RVA: 0x2FBCB0 Offset: 0x2FBDB1 VA: 0x2FBCB0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2Int>>.MoveNext
	|
	|-RVA: 0x2FBDE0 Offset: 0x2FBEE1 VA: 0x2FBDE0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3>>.MoveNext
	|
	|-RVA: 0x2FBF00 Offset: 0x2FC001 VA: 0x2FBF00
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3Int>>.MoveNext
	|
	|-RVA: 0x2FC020 Offset: 0x2FC121 VA: 0x2FC020
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector4>>.MoveNext
	|
	|-RVA: 0x2FC320 Offset: 0x2FC421 VA: 0x2FC320
	|-Dictionary.ValueCollection.Enumerator<object, ReadOnlyMemory<object>>.MoveNext
	|
	|-RVA: 0x2FC440 Offset: 0x2FC541 VA: 0x2FC440
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.MoveNext
	|
	|-RVA: 0x2FC560 Offset: 0x2FC661 VA: 0x2FC560
	|-Dictionary.ValueCollection.Enumerator<object, sbyte>.MoveNext
	|
	|-RVA: 0x2FC680 Offset: 0x2FC781 VA: 0x2FC680
	|-Dictionary.ValueCollection.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x2FC7A0 Offset: 0x2FC8A1 VA: 0x2FC7A0
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.MoveNext
	|
	|-RVA: 0x2FC8C0 Offset: 0x2FC9C1 VA: 0x2FC8C0
	|-Dictionary.ValueCollection.Enumerator<object, uint>.MoveNext
	|
	|-RVA: 0x2FC9E0 Offset: 0x2FCAE1 VA: 0x2FC9E0
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.MoveNext
	|
	|-RVA: 0x2FCB00 Offset: 0x2FCC01 VA: 0x2FCB00
	|-Dictionary.ValueCollection.Enumerator<object, TransitionTables>.MoveNext
	|
	|-RVA: 0x2FCC40 Offset: 0x2FCD41 VA: 0x2FCC40
	|-Dictionary.ValueCollection.Enumerator<object, Bounds>.MoveNext
	|
	|-RVA: 0x2FCD80 Offset: 0x2FCE81 VA: 0x2FCD80
	|-Dictionary.ValueCollection.Enumerator<object, BoundsInt>.MoveNext
	|
	|-RVA: 0x2FCEC0 Offset: 0x2FCFC1 VA: 0x2FCEC0
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.MoveNext
	|
	|-RVA: 0x2FCFE0 Offset: 0x2FD0E1 VA: 0x2FCFE0
	|-Dictionary.ValueCollection.Enumerator<object, Color>.MoveNext
	|
	|-RVA: 0x2FD100 Offset: 0x2FD201 VA: 0x2FD100
	|-Dictionary.ValueCollection.Enumerator<object, GradientAlphaKey>.MoveNext
	|
	|-RVA: 0x2FD220 Offset: 0x2FD321 VA: 0x2FD220
	|-Dictionary.ValueCollection.Enumerator<object, GradientColorKey>.MoveNext
	|
	|-RVA: 0x2FD370 Offset: 0x2FD471 VA: 0x2FD370
	|-Dictionary.ValueCollection.Enumerator<object, Keyframe>.MoveNext
	|
	|-RVA: 0x2FD4B0 Offset: 0x2FD5B1 VA: 0x2FD4B0
	|-Dictionary.ValueCollection.Enumerator<object, LayerMask>.MoveNext
	|
	|-RVA: 0x2FD5E0 Offset: 0x2FD6E1 VA: 0x2FD5E0
	|-Dictionary.ValueCollection.Enumerator<object, Matrix4x4>.MoveNext
	|
	|-RVA: 0x2FD730 Offset: 0x2FD831 VA: 0x2FD730
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.MoveNext
	|
	|-RVA: 0x2FD850 Offset: 0x2FD951 VA: 0x2FD850
	|-Dictionary.ValueCollection.Enumerator<object, Quaternion>.MoveNext
	|
	|-RVA: 0x2FD970 Offset: 0x2FDA71 VA: 0x2FD970
	|-Dictionary.ValueCollection.Enumerator<object, RangeInt>.MoveNext
	|
	|-RVA: 0x2FDA90 Offset: 0x2FDB91 VA: 0x2FDA90
	|-Dictionary.ValueCollection.Enumerator<object, Rect>.MoveNext
	|
	|-RVA: 0x2FDBB0 Offset: 0x2FDCB1 VA: 0x2FDBB0
	|-Dictionary.ValueCollection.Enumerator<object, RectInt>.MoveNext
	|
	|-RVA: 0x2FDCD0 Offset: 0x2FDDD1 VA: 0x2FDCD0
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x2FDE10 Offset: 0x2FDF11 VA: 0x2FDE10
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x2FDF50 Offset: 0x2FE051 VA: 0x2FDF50
	|-Dictionary.ValueCollection.Enumerator<object, Vector2>.MoveNext
	|
	|-RVA: 0x2FE070 Offset: 0x2FE171 VA: 0x2FE070
	|-Dictionary.ValueCollection.Enumerator<object, Vector2Int>.MoveNext
	|
	|-RVA: 0x2FE190 Offset: 0x2FE291 VA: 0x2FE190
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.MoveNext
	|
	|-RVA: 0x2FE2C0 Offset: 0x2FE3C1 VA: 0x2FE2C0
	|-Dictionary.ValueCollection.Enumerator<object, Vector3Int>.MoveNext
	|
	|-RVA: 0x2FE3F0 Offset: 0x2FE4F1 VA: 0x2FE3F0
	|-Dictionary.ValueCollection.Enumerator<object, Vector4>.MoveNext
	|
	|-RVA: 0x2FE510 Offset: 0x2FE611 VA: 0x2FE510
	|-Dictionary.ValueCollection.Enumerator<ReadOnlyMemory<object>, object>.MoveNext
	|
	|-RVA: 0x2FE6D0 Offset: 0x2FE7D1 VA: 0x2FE6D0
	|-Dictionary.ValueCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x2FE7F0 Offset: 0x2FE8F1 VA: 0x2FE7F0
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.MoveNext
	|
	|-RVA: 0x2FE9C0 Offset: 0x2FEAC1 VA: 0x2FE9C0
	|-Dictionary.ValueCollection.Enumerator<float, CurveSample>.MoveNext
	|
	|-RVA: 0x2FEB10 Offset: 0x2FEC11 VA: 0x2FEB10
	|-Dictionary.ValueCollection.Enumerator<float, object>.MoveNext
	|
	|-RVA: 0x2FECD0 Offset: 0x2FEDD1 VA: 0x2FECD0
	|-Dictionary.ValueCollection.Enumerator<ushort, object>.MoveNext
	|
	|-RVA: 0x2FF0D0 Offset: 0x2FF1D1 VA: 0x2FF0D0
	|-Dictionary.ValueCollection.Enumerator<uint, FriendMonsterStatus>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<uint, object>.MoveNext
	|
	|-RVA: 0x2FEE90 Offset: 0x2FEF91 VA: 0x2FEE90
	|-Dictionary.ValueCollection.Enumerator<uint, int>.MoveNext
	|
	|-RVA: 0x2FEFB0 Offset: 0x2FF0B1 VA: 0x2FEFB0
	|-Dictionary.ValueCollection.Enumerator<uint, Int32Enum>.MoveNext
	|
	|-RVA: 0x2FF290 Offset: 0x2FF391 VA: 0x2FF290
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.MoveNext
	|
	|-RVA: 0x2FF450 Offset: 0x2FF551 VA: 0x2FF450
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, int>.MoveNext
	|
	|-RVA: 0x2FF580 Offset: 0x2FF681 VA: 0x2FF580
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, CapEdge>.MoveNext
	|
	|-RVA: 0x2FF6E0 Offset: 0x2FF7E1 VA: 0x2FF6E0
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.MoveNext
	|
	|-RVA: 0x2FF820 Offset: 0x2FF921 VA: 0x2FF820
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.MoveNext
	|
	|-RVA: 0x2FF960 Offset: 0x2FFA61 VA: 0x2FF960
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, bool>.MoveNext
	|
	|-RVA: 0x2FFA80 Offset: 0x2FFB81 VA: 0x2FFA80
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, object>.MoveNext
	|
	|-RVA: 0x2FFC40 Offset: 0x2FFD41 VA: 0x2FFC40
	|-Dictionary.ValueCollection.Enumerator<Bounds, object>.MoveNext
	|
	|-RVA: 0x2FFE00 Offset: 0x2FFF01 VA: 0x2FFE00
	|-Dictionary.ValueCollection.Enumerator<BoundsInt, object>.MoveNext
	|
	|-RVA: 0x2FFFC0 Offset: 0x3000C1 VA: 0x2FFFC0
	|-Dictionary.ValueCollection.Enumerator<Color, object>.MoveNext
	|
	|-RVA: 0x300180 Offset: 0x300281 VA: 0x300180
	|-Dictionary.ValueCollection.Enumerator<Color32, object>.MoveNext
	|
	|-RVA: 0x300340 Offset: 0x300441 VA: 0x300340
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.MoveNext
	|
	|-RVA: 0x300500 Offset: 0x300601 VA: 0x300500
	|-Dictionary.ValueCollection.Enumerator<GradientAlphaKey, object>.MoveNext
	|
	|-RVA: 0x3006C0 Offset: 0x3007C1 VA: 0x3006C0
	|-Dictionary.ValueCollection.Enumerator<GradientColorKey, object>.MoveNext
	|
	|-RVA: 0x300880 Offset: 0x300981 VA: 0x300880
	|-Dictionary.ValueCollection.Enumerator<Keyframe, object>.MoveNext
	|
	|-RVA: 0x300A40 Offset: 0x300B41 VA: 0x300A40
	|-Dictionary.ValueCollection.Enumerator<LayerMask, object>.MoveNext
	|
	|-RVA: 0x300C00 Offset: 0x300D01 VA: 0x300C00
	|-Dictionary.ValueCollection.Enumerator<Matrix4x4, object>.MoveNext
	|
	|-RVA: 0x300DC0 Offset: 0x300EC1 VA: 0x300DC0
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.MoveNext
	|
	|-RVA: 0x300F80 Offset: 0x301081 VA: 0x300F80
	|-Dictionary.ValueCollection.Enumerator<Quaternion, object>.MoveNext
	|
	|-RVA: 0x301140 Offset: 0x301241 VA: 0x301140
	|-Dictionary.ValueCollection.Enumerator<RangeInt, object>.MoveNext
	|
	|-RVA: 0x301300 Offset: 0x301401 VA: 0x301300
	|-Dictionary.ValueCollection.Enumerator<Rect, object>.MoveNext
	|
	|-RVA: 0x3014C0 Offset: 0x3015C1 VA: 0x3014C0
	|-Dictionary.ValueCollection.Enumerator<RectInt, object>.MoveNext
	|
	|-RVA: 0x301680 Offset: 0x301781 VA: 0x301680
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.MoveNext
	|
	|-RVA: 0x3017A0 Offset: 0x3018A1 VA: 0x3017A0
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.MoveNext
	|
	|-RVA: 0x301960 Offset: 0x301A61 VA: 0x301960
	|-Dictionary.ValueCollection.Enumerator<Vector2, object>.MoveNext
	|
	|-RVA: 0x301B20 Offset: 0x301C21 VA: 0x301B20
	|-Dictionary.ValueCollection.Enumerator<Vector2Int, object>.MoveNext
	|
	|-RVA: 0x301CE0 Offset: 0x301DE1 VA: 0x301CE0
	|-Dictionary.ValueCollection.Enumerator<Vector3, object>.MoveNext
	|
	|-RVA: 0x301EA0 Offset: 0x301FA1 VA: 0x301EA0
	|-Dictionary.ValueCollection.Enumerator<Vector3Int, object>.MoveNext
	|
	|-RVA: 0x302060 Offset: 0x302161 VA: 0x302060
	|-Dictionary.ValueCollection.Enumerator<Vector4, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EC430 Offset: 0x2EC531 VA: 0x2EC430
	|-Dictionary.ValueCollection.Enumerator<BeanID, BeanData>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ActorID, LifeCycleScriptPlayer>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ActorID, GrappleController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ActorID, HandCuffsController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ActorID, MobTravelerController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<BadStatus, BadStatusEffectController.ObjInfo>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ToolChargeLevel, ParticleSystem>.get_Current
	|-Dictionary.ValueCollection.Enumerator<EquipSlotType, HumanEquipItem>.get_Current
	|-Dictionary.ValueCollection.Enumerator<GateDataID, GateController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<ItemID, ItemPoolData>.get_Current
	|-Dictionary.ValueCollection.Enumerator<SnowmanObjectID, SnowballData>.get_Current
	|-Dictionary.ValueCollection.Enumerator<SoundID, EnvironmentSoundController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.get_Current
	|
	|-RVA: 0x2FC170 Offset: 0x2FC271 VA: 0x2FC170
	|-Dictionary.ValueCollection.Enumerator<Character, ActionSpeedController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Character, AvoidController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Character, BitController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Character, GrantAttributeController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Character, LazyController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Character, RestraintController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Character, SuperArmorController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Character, SpringManager>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Character, YawnController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, EmotionController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, EscapeController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, MagicController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, SlowStateController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, SoulController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<CharacterBase, ThrottleController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, ActionCode>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, Transform>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Collider, CharacterNearCullingController>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Material, List<CombinedMesh.MaterialMeshInfo>>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x2EC310 Offset: 0x2EC411 VA: 0x2EC310
	|-Dictionary.ValueCollection.Enumerator<EmotionType, Prefab>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x2F0500 Offset: 0x2F0601 VA: 0x2F0500
	|-Dictionary.ValueCollection.Enumerator<MonsterControllerBase, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<object, int>.get_Current
	|
	|-RVA: 0x2EBBF0 Offset: 0x2EBCF1 VA: 0x2EBBF0
	|-Dictionary.ValueCollection.Enumerator<MonsterDataID, MonsterDataTable>.get_Current
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterDataTable>.get_Current
	|
	|-RVA: 0x2EB540 Offset: 0x2EB641 VA: 0x2EB540
	|-Dictionary.ValueCollection.Enumerator<int, BossStageManager>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, AssetHandle>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, PointerEventData>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, object>.get_Current
	|
	|-RVA: 0x2EB850 Offset: 0x2EB951 VA: 0x2EB850
	|-Dictionary.ValueCollection.Enumerator<int, SceneInstance>.get_Current
	|
	|-RVA: 0x2FF0E0 Offset: 0x2FF1E1 VA: 0x2FF0E0
	|-Dictionary.ValueCollection.Enumerator<uint, FriendMonsterStatus>.get_Current
	|-Dictionary.ValueCollection.Enumerator<uint, object>.get_Current
	|
	|-RVA: 0x36AB40 Offset: 0x36AC41 VA: 0x36AB40
	|-Dictionary.ValueCollection.Enumerator<JSONDeserialization.TaskField, object>.get_Current
	|
	|-RVA: 0x36AD00 Offset: 0x36AE01 VA: 0x36AD00
	|-Dictionary.ValueCollection.Enumerator<BitVector32Int, object>.get_Current
	|
	|-RVA: 0x36AEC0 Offset: 0x36AFC1 VA: 0x36AEC0
	|-Dictionary.ValueCollection.Enumerator<EventCheckId, object>.get_Current
	|
	|-RVA: 0x36B080 Offset: 0x36B181 VA: 0x36B080
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.get_Current
	|
	|-RVA: 0x36B240 Offset: 0x36B341 VA: 0x36B240
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.get_Current
	|
	|-RVA: 0x36B400 Offset: 0x36B501 VA: 0x36B400
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.get_Current
	|
	|-RVA: 0x36B5C0 Offset: 0x36B6C1 VA: 0x36B5C0
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.get_Current
	|
	|-RVA: 0x36B780 Offset: 0x36B881 VA: 0x36B780
	|-Dictionary.ValueCollection.Enumerator<MonsterHutSaveData, object>.get_Current
	|
	|-RVA: 0x36B940 Offset: 0x36BA41 VA: 0x36B940
	|-Dictionary.ValueCollection.Enumerator<OrderLotterySaveParameter, object>.get_Current
	|
	|-RVA: 0x36BB00 Offset: 0x36BC01 VA: 0x36BB00
	|-Dictionary.ValueCollection.Enumerator<OrderSaveData, object>.get_Current
	|
	|-RVA: 0x36BCC0 Offset: 0x36BDC1 VA: 0x36BCC0
	|-Dictionary.ValueCollection.Enumerator<OrderSaveParameter, object>.get_Current
	|
	|-RVA: 0x36BE80 Offset: 0x36BF81 VA: 0x36BE80
	|-Dictionary.ValueCollection.Enumerator<Parameter, object>.get_Current
	|
	|-RVA: 0x36C040 Offset: 0x36C141 VA: 0x36C040
	|-Dictionary.ValueCollection.Enumerator<bool, object>.get_Current
	|
	|-RVA: 0x36C200 Offset: 0x36C301 VA: 0x36C200
	|-Dictionary.ValueCollection.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x2EA060 Offset: 0x2EA161 VA: 0x2EA060
	|-Dictionary.ValueCollection.Enumerator<char, object>.get_Current
	|
	|-RVA: 0x2EA220 Offset: 0x2EA321 VA: 0x2EA220
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.get_Current
	|
	|-RVA: 0x2EA3E0 Offset: 0x2EA4E1 VA: 0x2EA3E0
	|-Dictionary.ValueCollection.Enumerator<double, object>.get_Current
	|
	|-RVA: 0x2EA5A0 Offset: 0x2EA6A1 VA: 0x2EA5A0
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.get_Current
	|
	|-RVA: 0x2EA760 Offset: 0x2EA861 VA: 0x2EA760
	|-Dictionary.ValueCollection.Enumerator<short, object>.get_Current
	|
	|-RVA: 0x2EA960 Offset: 0x2EAA61 VA: 0x2EA960
	|-Dictionary.ValueCollection.Enumerator<int, CropDataTable>.get_Current
	|
	|-RVA: 0x2EAAC0 Offset: 0x2EABC1 VA: 0x2EAAC0
	|-Dictionary.ValueCollection.Enumerator<int, EffectDataTable>.get_Current
	|
	|-RVA: 0x2EAC00 Offset: 0x2EAD01 VA: 0x2EAC00
	|-Dictionary.ValueCollection.Enumerator<int, GimmickLayoutDataTable>.get_Current
	|
	|-RVA: 0x2EAD30 Offset: 0x2EAE31 VA: 0x2EAD30
	|-Dictionary.ValueCollection.Enumerator<int, MineTypeDataTable>.get_Current
	|
	|-RVA: 0x2EAE80 Offset: 0x2EAF81 VA: 0x2EAE80
	|-Dictionary.ValueCollection.Enumerator<int, MiningDataTable>.get_Current
	|
	|-RVA: 0x2EAFA0 Offset: 0x2EB0A1 VA: 0x2EAFA0
	|-Dictionary.ValueCollection.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x2EB0C0 Offset: 0x2EB1C1 VA: 0x2EB0C0
	|-Dictionary.ValueCollection.Enumerator<int, char>.get_Current
	|
	|-RVA: 0x2EB1E0 Offset: 0x2EB2E1 VA: 0x2EB1E0
	|-Dictionary.ValueCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x2EB300 Offset: 0x2EB401 VA: 0x2EB300
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.get_Current
	|
	|-RVA: 0x2EB420 Offset: 0x2EB521 VA: 0x2EB420
	|-Dictionary.ValueCollection.Enumerator<int, long>.get_Current
	|
	|-RVA: 0x2EB710 Offset: 0x2EB811 VA: 0x2EB710
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.get_Current
	|
	|-RVA: 0x2EB970 Offset: 0x2EBA71 VA: 0x2EB970
	|-Dictionary.ValueCollection.Enumerator<int, Vector2Int>.get_Current
	|
	|-RVA: 0x2EBA90 Offset: 0x2EBB91 VA: 0x2EBA90
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.get_Current
	|
	|-RVA: 0x2EBD50 Offset: 0x2EBE51 VA: 0x2EBD50
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.get_Current
	|
	|-RVA: 0x2EBE90 Offset: 0x2EBF91 VA: 0x2EBE90
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Current
	|
	|-RVA: 0x2EBFB0 Offset: 0x2EC0B1 VA: 0x2EBFB0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.get_Current
	|
	|-RVA: 0x2EC0D0 Offset: 0x2EC1D1 VA: 0x2EC0D0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2EC1F0 Offset: 0x2EC2F1 VA: 0x2EC1F0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x2EC5F0 Offset: 0x2EC6F1 VA: 0x2EC5F0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.get_Current
	|
	|-RVA: 0x2EC710 Offset: 0x2EC811 VA: 0x2EC710
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.get_Current
	|
	|-RVA: 0x2EC830 Offset: 0x2EC931 VA: 0x2EC830
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.get_Current
	|
	|-RVA: 0x2EC950 Offset: 0x2ECA51 VA: 0x2EC950
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.get_Current
	|
	|-RVA: 0x2ECA80 Offset: 0x2ECB81 VA: 0x2ECA80
	|-Dictionary.ValueCollection.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x2ECC40 Offset: 0x2ECD41 VA: 0x2ECC40
	|-Dictionary.ValueCollection.Enumerator<Memory<object>, object>.get_Current
	|
	|-RVA: 0x2ECE00 Offset: 0x2ECF01 VA: 0x2ECE00
	|-Dictionary.ValueCollection.Enumerator<Nullable<Int32Enum>, object>.get_Current
	|
	|-RVA: 0x2ECFC0 Offset: 0x2ED0C1 VA: 0x2ECFC0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Bounds>, object>.get_Current
	|
	|-RVA: 0x2ED180 Offset: 0x2ED281 VA: 0x2ED180
	|-Dictionary.ValueCollection.Enumerator<Nullable<BoundsInt>, object>.get_Current
	|
	|-RVA: 0x2ED340 Offset: 0x2ED441 VA: 0x2ED340
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color32>, object>.get_Current
	|
	|-RVA: 0x2ED500 Offset: 0x2ED601 VA: 0x2ED500
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color>, object>.get_Current
	|
	|-RVA: 0x2ED6C0 Offset: 0x2ED7C1 VA: 0x2ED6C0
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientAlphaKey>, object>.get_Current
	|
	|-RVA: 0x2ED880 Offset: 0x2ED981 VA: 0x2ED880
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientColorKey>, object>.get_Current
	|
	|-RVA: 0x2EDA40 Offset: 0x2EDB41 VA: 0x2EDA40
	|-Dictionary.ValueCollection.Enumerator<Nullable<Keyframe>, object>.get_Current
	|
	|-RVA: 0x2EDC00 Offset: 0x2EDD01 VA: 0x2EDC00
	|-Dictionary.ValueCollection.Enumerator<Nullable<LayerMask>, object>.get_Current
	|
	|-RVA: 0x2EDDC0 Offset: 0x2EDEC1 VA: 0x2EDDC0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Matrix4x4>, object>.get_Current
	|
	|-RVA: 0x2EDF80 Offset: 0x2EE081 VA: 0x2EDF80
	|-Dictionary.ValueCollection.Enumerator<Nullable<Quaternion>, object>.get_Current
	|
	|-RVA: 0x2EE140 Offset: 0x2EE241 VA: 0x2EE140
	|-Dictionary.ValueCollection.Enumerator<Nullable<RangeInt>, object>.get_Current
	|
	|-RVA: 0x2EE300 Offset: 0x2EE401 VA: 0x2EE300
	|-Dictionary.ValueCollection.Enumerator<Nullable<Rect>, object>.get_Current
	|
	|-RVA: 0x2EE4C0 Offset: 0x2EE5C1 VA: 0x2EE4C0
	|-Dictionary.ValueCollection.Enumerator<Nullable<RectInt>, object>.get_Current
	|
	|-RVA: 0x2EE680 Offset: 0x2EE781 VA: 0x2EE680
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2>, object>.get_Current
	|
	|-RVA: 0x2EE840 Offset: 0x2EE941 VA: 0x2EE840
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2Int>, object>.get_Current
	|
	|-RVA: 0x2EEA00 Offset: 0x2EEB01 VA: 0x2EEA00
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3>, object>.get_Current
	|
	|-RVA: 0x2EEBC0 Offset: 0x2EECC1 VA: 0x2EEBC0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3Int>, object>.get_Current
	|
	|-RVA: 0x2EED80 Offset: 0x2EEE81 VA: 0x2EED80
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector4>, object>.get_Current
	|
	|-RVA: 0x2EEF40 Offset: 0x2EF041 VA: 0x2EEF40
	|-Dictionary.ValueCollection.Enumerator<object, BitVector32Int>.get_Current
	|
	|-RVA: 0x2EF060 Offset: 0x2EF161 VA: 0x2EF060
	|-Dictionary.ValueCollection.Enumerator<object, EventCheckId>.get_Current
	|
	|-RVA: 0x2EF1B0 Offset: 0x2EF2B1 VA: 0x2EF1B0
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.get_Current
	|
	|-RVA: 0x2EF300 Offset: 0x2EF401 VA: 0x2EF300
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.get_Current
	|
	|-RVA: 0x2EF440 Offset: 0x2EF541 VA: 0x2EF440
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.get_Current
	|
	|-RVA: 0x2EF570 Offset: 0x2EF671 VA: 0x2EF570
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.get_Current
	|
	|-RVA: 0x2EF6A0 Offset: 0x2EF7A1 VA: 0x2EF6A0
	|-Dictionary.ValueCollection.Enumerator<object, MonsterHutSaveData>.get_Current
	|
	|-RVA: 0x2EF7E0 Offset: 0x2EF8E1 VA: 0x2EF7E0
	|-Dictionary.ValueCollection.Enumerator<object, OrderLotterySaveParameter>.get_Current
	|
	|-RVA: 0x2EF920 Offset: 0x2EFA21 VA: 0x2EF920
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveData>.get_Current
	|
	|-RVA: 0x2EFA60 Offset: 0x2EFB61 VA: 0x2EFA60
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveParameter>.get_Current
	|
	|-RVA: 0x2EFBD0 Offset: 0x2EFCD1 VA: 0x2EFBD0
	|-Dictionary.ValueCollection.Enumerator<object, Parameter>.get_Current
	|
	|-RVA: 0x2EFD20 Offset: 0x2EFE21 VA: 0x2EFD20
	|-Dictionary.ValueCollection.Enumerator<object, NumberControl.ValueRange>.get_Current
	|
	|-RVA: 0x2EFE40 Offset: 0x2EFF41 VA: 0x2EFE40
	|-Dictionary.ValueCollection.Enumerator<object, bool>.get_Current
	|
	|-RVA: 0x2EFF60 Offset: 0x2F0061 VA: 0x2EFF60
	|-Dictionary.ValueCollection.Enumerator<object, byte>.get_Current
	|
	|-RVA: 0x2F0080 Offset: 0x2F0181 VA: 0x2F0080
	|-Dictionary.ValueCollection.Enumerator<object, char>.get_Current
	|
	|-RVA: 0x2F01A0 Offset: 0x2F02A1 VA: 0x2F01A0
	|-Dictionary.ValueCollection.Enumerator<object, DateTime>.get_Current
	|
	|-RVA: 0x2F02C0 Offset: 0x2F03C1 VA: 0x2F02C0
	|-Dictionary.ValueCollection.Enumerator<object, double>.get_Current
	|
	|-RVA: 0x2F03E0 Offset: 0x2F04E1 VA: 0x2F03E0
	|-Dictionary.ValueCollection.Enumerator<object, short>.get_Current
	|
	|-RVA: 0x2F0620 Offset: 0x2F0721 VA: 0x2F0620
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.get_Current
	|
	|-RVA: 0x2F0740 Offset: 0x2F0841 VA: 0x2F0740
	|-Dictionary.ValueCollection.Enumerator<object, long>.get_Current
	|
	|-RVA: 0x2F0860 Offset: 0x2F0961 VA: 0x2F0860
	|-Dictionary.ValueCollection.Enumerator<object, Memory<object>>.get_Current
	|
	|-RVA: 0x2F0980 Offset: 0x2F0A81 VA: 0x2F0980
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Int32Enum>>.get_Current
	|
	|-RVA: 0x2F0AB0 Offset: 0x2F0BB1 VA: 0x2F0AB0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Bounds>>.get_Current
	|
	|-RVA: 0x2F0C00 Offset: 0x2F0D01 VA: 0x2F0C00
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<BoundsInt>>.get_Current
	|
	|-RVA: 0x2F0D40 Offset: 0x2F0E41 VA: 0x2F0D40
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color32>>.get_Current
	|
	|-RVA: 0x2F0E60 Offset: 0x2F0F61 VA: 0x2F0E60
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color>>.get_Current
	|
	|-RVA: 0x2F0FA0 Offset: 0x2F10A1 VA: 0x2F0FA0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x2F10D0 Offset: 0x2F11D1 VA: 0x2F10D0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientColorKey>>.get_Current
	|
	|-RVA: 0x2F1210 Offset: 0x2F1311 VA: 0x2F1210
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Keyframe>>.get_Current
	|
	|-RVA: 0x2F1350 Offset: 0x2F1451 VA: 0x2F1350
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<LayerMask>>.get_Current
	|
	|-RVA: 0x2FB540 Offset: 0x2FB641 VA: 0x2FB540
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Matrix4x4>>.get_Current
	|
	|-RVA: 0x2FB6A0 Offset: 0x2FB7A1 VA: 0x2FB6A0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Quaternion>>.get_Current
	|
	|-RVA: 0x2FB7E0 Offset: 0x2FB8E1 VA: 0x2FB7E0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RangeInt>>.get_Current
	|
	|-RVA: 0x2FB910 Offset: 0x2FBA11 VA: 0x2FB910
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Rect>>.get_Current
	|
	|-RVA: 0x2FBA50 Offset: 0x2FBB51 VA: 0x2FBA50
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RectInt>>.get_Current
	|
	|-RVA: 0x2FBB90 Offset: 0x2FBC91 VA: 0x2FBB90
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2>>.get_Current
	|
	|-RVA: 0x2FBCC0 Offset: 0x2FBDC1 VA: 0x2FBCC0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2Int>>.get_Current
	|
	|-RVA: 0x2FBDF0 Offset: 0x2FBEF1 VA: 0x2FBDF0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3>>.get_Current
	|
	|-RVA: 0x2FBF10 Offset: 0x2FC011 VA: 0x2FBF10
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3Int>>.get_Current
	|
	|-RVA: 0x2FC030 Offset: 0x2FC131 VA: 0x2FC030
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector4>>.get_Current
	|
	|-RVA: 0x2FC330 Offset: 0x2FC431 VA: 0x2FC330
	|-Dictionary.ValueCollection.Enumerator<object, ReadOnlyMemory<object>>.get_Current
	|
	|-RVA: 0x2FC450 Offset: 0x2FC551 VA: 0x2FC450
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.get_Current
	|
	|-RVA: 0x2FC570 Offset: 0x2FC671 VA: 0x2FC570
	|-Dictionary.ValueCollection.Enumerator<object, sbyte>.get_Current
	|
	|-RVA: 0x2FC690 Offset: 0x2FC791 VA: 0x2FC690
	|-Dictionary.ValueCollection.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x2FC7B0 Offset: 0x2FC8B1 VA: 0x2FC7B0
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.get_Current
	|
	|-RVA: 0x2FC8D0 Offset: 0x2FC9D1 VA: 0x2FC8D0
	|-Dictionary.ValueCollection.Enumerator<object, uint>.get_Current
	|
	|-RVA: 0x2FC9F0 Offset: 0x2FCAF1 VA: 0x2FC9F0
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.get_Current
	|
	|-RVA: 0x2FCB10 Offset: 0x2FCC11 VA: 0x2FCB10
	|-Dictionary.ValueCollection.Enumerator<object, TransitionTables>.get_Current
	|
	|-RVA: 0x2FCC50 Offset: 0x2FCD51 VA: 0x2FCC50
	|-Dictionary.ValueCollection.Enumerator<object, Bounds>.get_Current
	|
	|-RVA: 0x2FCD90 Offset: 0x2FCE91 VA: 0x2FCD90
	|-Dictionary.ValueCollection.Enumerator<object, BoundsInt>.get_Current
	|
	|-RVA: 0x2FCED0 Offset: 0x2FCFD1 VA: 0x2FCED0
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.get_Current
	|
	|-RVA: 0x2FCFF0 Offset: 0x2FD0F1 VA: 0x2FCFF0
	|-Dictionary.ValueCollection.Enumerator<object, Color>.get_Current
	|
	|-RVA: 0x2FD110 Offset: 0x2FD211 VA: 0x2FD110
	|-Dictionary.ValueCollection.Enumerator<object, GradientAlphaKey>.get_Current
	|
	|-RVA: 0x2FD230 Offset: 0x2FD331 VA: 0x2FD230
	|-Dictionary.ValueCollection.Enumerator<object, GradientColorKey>.get_Current
	|
	|-RVA: 0x2FD380 Offset: 0x2FD481 VA: 0x2FD380
	|-Dictionary.ValueCollection.Enumerator<object, Keyframe>.get_Current
	|
	|-RVA: 0x2FD4C0 Offset: 0x2FD5C1 VA: 0x2FD4C0
	|-Dictionary.ValueCollection.Enumerator<object, LayerMask>.get_Current
	|
	|-RVA: 0x2FD5F0 Offset: 0x2FD6F1 VA: 0x2FD5F0
	|-Dictionary.ValueCollection.Enumerator<object, Matrix4x4>.get_Current
	|
	|-RVA: 0x2FD740 Offset: 0x2FD841 VA: 0x2FD740
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.get_Current
	|
	|-RVA: 0x2FD860 Offset: 0x2FD961 VA: 0x2FD860
	|-Dictionary.ValueCollection.Enumerator<object, Quaternion>.get_Current
	|
	|-RVA: 0x2FD980 Offset: 0x2FDA81 VA: 0x2FD980
	|-Dictionary.ValueCollection.Enumerator<object, RangeInt>.get_Current
	|
	|-RVA: 0x2FDAA0 Offset: 0x2FDBA1 VA: 0x2FDAA0
	|-Dictionary.ValueCollection.Enumerator<object, Rect>.get_Current
	|
	|-RVA: 0x2FDBC0 Offset: 0x2FDCC1 VA: 0x2FDBC0
	|-Dictionary.ValueCollection.Enumerator<object, RectInt>.get_Current
	|
	|-RVA: 0x2FDCE0 Offset: 0x2FDDE1 VA: 0x2FDCE0
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x2FDE20 Offset: 0x2FDF21 VA: 0x2FDE20
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x2FDF60 Offset: 0x2FE061 VA: 0x2FDF60
	|-Dictionary.ValueCollection.Enumerator<object, Vector2>.get_Current
	|
	|-RVA: 0x2FE080 Offset: 0x2FE181 VA: 0x2FE080
	|-Dictionary.ValueCollection.Enumerator<object, Vector2Int>.get_Current
	|
	|-RVA: 0x2FE1A0 Offset: 0x2FE2A1 VA: 0x2FE1A0
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.get_Current
	|
	|-RVA: 0x2FE2D0 Offset: 0x2FE3D1 VA: 0x2FE2D0
	|-Dictionary.ValueCollection.Enumerator<object, Vector3Int>.get_Current
	|
	|-RVA: 0x2FE400 Offset: 0x2FE501 VA: 0x2FE400
	|-Dictionary.ValueCollection.Enumerator<object, Vector4>.get_Current
	|
	|-RVA: 0x2FE520 Offset: 0x2FE621 VA: 0x2FE520
	|-Dictionary.ValueCollection.Enumerator<ReadOnlyMemory<object>, object>.get_Current
	|
	|-RVA: 0x2FE6E0 Offset: 0x2FE7E1 VA: 0x2FE6E0
	|-Dictionary.ValueCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x2FE800 Offset: 0x2FE901 VA: 0x2FE800
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.get_Current
	|
	|-RVA: 0x2FE9D0 Offset: 0x2FEAD1 VA: 0x2FE9D0
	|-Dictionary.ValueCollection.Enumerator<float, CurveSample>.get_Current
	|
	|-RVA: 0x2FEB20 Offset: 0x2FEC21 VA: 0x2FEB20
	|-Dictionary.ValueCollection.Enumerator<float, object>.get_Current
	|
	|-RVA: 0x2FECE0 Offset: 0x2FEDE1 VA: 0x2FECE0
	|-Dictionary.ValueCollection.Enumerator<ushort, object>.get_Current
	|
	|-RVA: 0x2FEEA0 Offset: 0x2FEFA1 VA: 0x2FEEA0
	|-Dictionary.ValueCollection.Enumerator<uint, int>.get_Current
	|
	|-RVA: 0x2FEFC0 Offset: 0x2FF0C1 VA: 0x2FEFC0
	|-Dictionary.ValueCollection.Enumerator<uint, Int32Enum>.get_Current
	|
	|-RVA: 0x2FF2A0 Offset: 0x2FF3A1 VA: 0x2FF2A0
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.get_Current
	|
	|-RVA: 0x2FF460 Offset: 0x2FF561 VA: 0x2FF460
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, int>.get_Current
	|
	|-RVA: 0x2FF590 Offset: 0x2FF691 VA: 0x2FF590
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, CapEdge>.get_Current
	|
	|-RVA: 0x2FF6F0 Offset: 0x2FF7F1 VA: 0x2FF6F0
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Current
	|
	|-RVA: 0x2FF830 Offset: 0x2FF931 VA: 0x2FF830
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.get_Current
	|
	|-RVA: 0x2FF970 Offset: 0x2FFA71 VA: 0x2FF970
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, bool>.get_Current
	|
	|-RVA: 0x2FFA90 Offset: 0x2FFB91 VA: 0x2FFA90
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, object>.get_Current
	|
	|-RVA: 0x2FFC50 Offset: 0x2FFD51 VA: 0x2FFC50
	|-Dictionary.ValueCollection.Enumerator<Bounds, object>.get_Current
	|
	|-RVA: 0x2FFE10 Offset: 0x2FFF11 VA: 0x2FFE10
	|-Dictionary.ValueCollection.Enumerator<BoundsInt, object>.get_Current
	|
	|-RVA: 0x2FFFD0 Offset: 0x3000D1 VA: 0x2FFFD0
	|-Dictionary.ValueCollection.Enumerator<Color, object>.get_Current
	|
	|-RVA: 0x300190 Offset: 0x300291 VA: 0x300190
	|-Dictionary.ValueCollection.Enumerator<Color32, object>.get_Current
	|
	|-RVA: 0x300350 Offset: 0x300451 VA: 0x300350
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.get_Current
	|
	|-RVA: 0x300510 Offset: 0x300611 VA: 0x300510
	|-Dictionary.ValueCollection.Enumerator<GradientAlphaKey, object>.get_Current
	|
	|-RVA: 0x3006D0 Offset: 0x3007D1 VA: 0x3006D0
	|-Dictionary.ValueCollection.Enumerator<GradientColorKey, object>.get_Current
	|
	|-RVA: 0x300890 Offset: 0x300991 VA: 0x300890
	|-Dictionary.ValueCollection.Enumerator<Keyframe, object>.get_Current
	|
	|-RVA: 0x300A50 Offset: 0x300B51 VA: 0x300A50
	|-Dictionary.ValueCollection.Enumerator<LayerMask, object>.get_Current
	|
	|-RVA: 0x300C10 Offset: 0x300D11 VA: 0x300C10
	|-Dictionary.ValueCollection.Enumerator<Matrix4x4, object>.get_Current
	|
	|-RVA: 0x300DD0 Offset: 0x300ED1 VA: 0x300DD0
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.get_Current
	|
	|-RVA: 0x300F90 Offset: 0x301091 VA: 0x300F90
	|-Dictionary.ValueCollection.Enumerator<Quaternion, object>.get_Current
	|
	|-RVA: 0x301150 Offset: 0x301251 VA: 0x301150
	|-Dictionary.ValueCollection.Enumerator<RangeInt, object>.get_Current
	|
	|-RVA: 0x301310 Offset: 0x301411 VA: 0x301310
	|-Dictionary.ValueCollection.Enumerator<Rect, object>.get_Current
	|
	|-RVA: 0x3014D0 Offset: 0x3015D1 VA: 0x3014D0
	|-Dictionary.ValueCollection.Enumerator<RectInt, object>.get_Current
	|
	|-RVA: 0x301690 Offset: 0x301791 VA: 0x301690
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.get_Current
	|
	|-RVA: 0x3017B0 Offset: 0x3018B1 VA: 0x3017B0
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.get_Current
	|
	|-RVA: 0x301970 Offset: 0x301A71 VA: 0x301970
	|-Dictionary.ValueCollection.Enumerator<Vector2, object>.get_Current
	|
	|-RVA: 0x301B30 Offset: 0x301C31 VA: 0x301B30
	|-Dictionary.ValueCollection.Enumerator<Vector2Int, object>.get_Current
	|
	|-RVA: 0x301CF0 Offset: 0x301DF1 VA: 0x301CF0
	|-Dictionary.ValueCollection.Enumerator<Vector3, object>.get_Current
	|
	|-RVA: 0x301EB0 Offset: 0x301FB1 VA: 0x301EB0
	|-Dictionary.ValueCollection.Enumerator<Vector3Int, object>.get_Current
	|
	|-RVA: 0x302070 Offset: 0x302171 VA: 0x302070
	|-Dictionary.ValueCollection.Enumerator<Vector4, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36AB50 Offset: 0x36AC51 VA: 0x36AB50
	|-Dictionary.ValueCollection.Enumerator<JSONDeserialization.TaskField, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36AD10 Offset: 0x36AE11 VA: 0x36AD10
	|-Dictionary.ValueCollection.Enumerator<BitVector32Int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36AED0 Offset: 0x36AFD1 VA: 0x36AED0
	|-Dictionary.ValueCollection.Enumerator<EventCheckId, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36B090 Offset: 0x36B191 VA: 0x36B090
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36B250 Offset: 0x36B351 VA: 0x36B250
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36B410 Offset: 0x36B511 VA: 0x36B410
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36B5D0 Offset: 0x36B6D1 VA: 0x36B5D0
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36B790 Offset: 0x36B891 VA: 0x36B790
	|-Dictionary.ValueCollection.Enumerator<MonsterHutSaveData, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36B950 Offset: 0x36BA51 VA: 0x36B950
	|-Dictionary.ValueCollection.Enumerator<OrderLotterySaveParameter, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36BB10 Offset: 0x36BC11 VA: 0x36BB10
	|-Dictionary.ValueCollection.Enumerator<OrderSaveData, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36BCD0 Offset: 0x36BDD1 VA: 0x36BCD0
	|-Dictionary.ValueCollection.Enumerator<OrderSaveParameter, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36BE90 Offset: 0x36BF91 VA: 0x36BE90
	|-Dictionary.ValueCollection.Enumerator<Parameter, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36C050 Offset: 0x36C151 VA: 0x36C050
	|-Dictionary.ValueCollection.Enumerator<bool, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36C210 Offset: 0x36C311 VA: 0x36C210
	|-Dictionary.ValueCollection.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EA070 Offset: 0x2EA171 VA: 0x2EA070
	|-Dictionary.ValueCollection.Enumerator<char, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EA230 Offset: 0x2EA331 VA: 0x2EA230
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EA3F0 Offset: 0x2EA4F1 VA: 0x2EA3F0
	|-Dictionary.ValueCollection.Enumerator<double, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EA5B0 Offset: 0x2EA6B1 VA: 0x2EA5B0
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EA770 Offset: 0x2EA871 VA: 0x2EA770
	|-Dictionary.ValueCollection.Enumerator<short, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EA970 Offset: 0x2EAA71 VA: 0x2EA970
	|-Dictionary.ValueCollection.Enumerator<int, CropDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAAE0 Offset: 0x2EABE1 VA: 0x2EAAE0
	|-Dictionary.ValueCollection.Enumerator<int, EffectDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAC10 Offset: 0x2EAD11 VA: 0x2EAC10
	|-Dictionary.ValueCollection.Enumerator<int, GimmickLayoutDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAD60 Offset: 0x2EAE61 VA: 0x2EAD60
	|-Dictionary.ValueCollection.Enumerator<int, MineTypeDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAE90 Offset: 0x2EAF91 VA: 0x2EAE90
	|-Dictionary.ValueCollection.Enumerator<int, MiningDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAFB0 Offset: 0x2EB0B1 VA: 0x2EAFB0
	|-Dictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB0D0 Offset: 0x2EB1D1 VA: 0x2EB0D0
	|-Dictionary.ValueCollection.Enumerator<int, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB1F0 Offset: 0x2EB2F1 VA: 0x2EB1F0
	|-Dictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB310 Offset: 0x2EB411 VA: 0x2EB310
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB430 Offset: 0x2EB531 VA: 0x2EB430
	|-Dictionary.ValueCollection.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB550 Offset: 0x2EB651 VA: 0x2EB550
	|-Dictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB730 Offset: 0x2EB831 VA: 0x2EB730
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB860 Offset: 0x2EB961 VA: 0x2EB860
	|-Dictionary.ValueCollection.Enumerator<int, SceneInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB980 Offset: 0x2EBA81 VA: 0x2EB980
	|-Dictionary.ValueCollection.Enumerator<int, Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBAA0 Offset: 0x2EBBA1 VA: 0x2EBAA0
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBC00 Offset: 0x2EBD01 VA: 0x2EBC00
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBD70 Offset: 0x2EBE71 VA: 0x2EBD70
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBEA0 Offset: 0x2EBFA1 VA: 0x2EBEA0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBFC0 Offset: 0x2EC0C1 VA: 0x2EBFC0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EC0E0 Offset: 0x2EC1E1 VA: 0x2EC0E0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EC200 Offset: 0x2EC301 VA: 0x2EC200
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EC320 Offset: 0x2EC421 VA: 0x2EC320
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EC440 Offset: 0x2EC541 VA: 0x2EC440
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EC600 Offset: 0x2EC701 VA: 0x2EC600
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EC720 Offset: 0x2EC821 VA: 0x2EC720
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EC840 Offset: 0x2EC941 VA: 0x2EC840
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EC960 Offset: 0x2ECA61 VA: 0x2EC960
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2ECA90 Offset: 0x2ECB91 VA: 0x2ECA90
	|-Dictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2ECC50 Offset: 0x2ECD51 VA: 0x2ECC50
	|-Dictionary.ValueCollection.Enumerator<Memory<object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2ECE10 Offset: 0x2ECF11 VA: 0x2ECE10
	|-Dictionary.ValueCollection.Enumerator<Nullable<Int32Enum>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2ECFD0 Offset: 0x2ED0D1 VA: 0x2ECFD0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Bounds>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2ED190 Offset: 0x2ED291 VA: 0x2ED190
	|-Dictionary.ValueCollection.Enumerator<Nullable<BoundsInt>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2ED350 Offset: 0x2ED451 VA: 0x2ED350
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color32>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2ED510 Offset: 0x2ED611 VA: 0x2ED510
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2ED6D0 Offset: 0x2ED7D1 VA: 0x2ED6D0
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientAlphaKey>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2ED890 Offset: 0x2ED991 VA: 0x2ED890
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientColorKey>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EDA50 Offset: 0x2EDB51 VA: 0x2EDA50
	|-Dictionary.ValueCollection.Enumerator<Nullable<Keyframe>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EDC10 Offset: 0x2EDD11 VA: 0x2EDC10
	|-Dictionary.ValueCollection.Enumerator<Nullable<LayerMask>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EDDD0 Offset: 0x2EDED1 VA: 0x2EDDD0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Matrix4x4>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EDF90 Offset: 0x2EE091 VA: 0x2EDF90
	|-Dictionary.ValueCollection.Enumerator<Nullable<Quaternion>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EE150 Offset: 0x2EE251 VA: 0x2EE150
	|-Dictionary.ValueCollection.Enumerator<Nullable<RangeInt>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EE310 Offset: 0x2EE411 VA: 0x2EE310
	|-Dictionary.ValueCollection.Enumerator<Nullable<Rect>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EE4D0 Offset: 0x2EE5D1 VA: 0x2EE4D0
	|-Dictionary.ValueCollection.Enumerator<Nullable<RectInt>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EE690 Offset: 0x2EE791 VA: 0x2EE690
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EE850 Offset: 0x2EE951 VA: 0x2EE850
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2Int>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EEA10 Offset: 0x2EEB11 VA: 0x2EEA10
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EEBD0 Offset: 0x2EECD1 VA: 0x2EEBD0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3Int>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EED90 Offset: 0x2EEE91 VA: 0x2EED90
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector4>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EEF50 Offset: 0x2EF051 VA: 0x2EEF50
	|-Dictionary.ValueCollection.Enumerator<object, BitVector32Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EF080 Offset: 0x2EF181 VA: 0x2EF080
	|-Dictionary.ValueCollection.Enumerator<object, EventCheckId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EF1E0 Offset: 0x2EF2E1 VA: 0x2EF1E0
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EF320 Offset: 0x2EF421 VA: 0x2EF320
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EF450 Offset: 0x2EF551 VA: 0x2EF450
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EF580 Offset: 0x2EF681 VA: 0x2EF580
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EF6C0 Offset: 0x2EF7C1 VA: 0x2EF6C0
	|-Dictionary.ValueCollection.Enumerator<object, MonsterHutSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EF7F0 Offset: 0x2EF8F1 VA: 0x2EF7F0
	|-Dictionary.ValueCollection.Enumerator<object, OrderLotterySaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EF940 Offset: 0x2EFA41 VA: 0x2EF940
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EFA80 Offset: 0x2EFB81 VA: 0x2EFA80
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EFBE0 Offset: 0x2EFCE1 VA: 0x2EFBE0
	|-Dictionary.ValueCollection.Enumerator<object, Parameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EFD30 Offset: 0x2EFE31 VA: 0x2EFD30
	|-Dictionary.ValueCollection.Enumerator<object, NumberControl.ValueRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EFE50 Offset: 0x2EFF51 VA: 0x2EFE50
	|-Dictionary.ValueCollection.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EFF70 Offset: 0x2F0071 VA: 0x2EFF70
	|-Dictionary.ValueCollection.Enumerator<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0090 Offset: 0x2F0191 VA: 0x2F0090
	|-Dictionary.ValueCollection.Enumerator<object, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F01B0 Offset: 0x2F02B1 VA: 0x2F01B0
	|-Dictionary.ValueCollection.Enumerator<object, DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F02D0 Offset: 0x2F03D1 VA: 0x2F02D0
	|-Dictionary.ValueCollection.Enumerator<object, double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F03F0 Offset: 0x2F04F1 VA: 0x2F03F0
	|-Dictionary.ValueCollection.Enumerator<object, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0510 Offset: 0x2F0611 VA: 0x2F0510
	|-Dictionary.ValueCollection.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0630 Offset: 0x2F0731 VA: 0x2F0630
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0750 Offset: 0x2F0851 VA: 0x2F0750
	|-Dictionary.ValueCollection.Enumerator<object, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0870 Offset: 0x2F0971 VA: 0x2F0870
	|-Dictionary.ValueCollection.Enumerator<object, Memory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0990 Offset: 0x2F0A91 VA: 0x2F0990
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0AD0 Offset: 0x2F0BD1 VA: 0x2F0AD0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0C20 Offset: 0x2F0D21 VA: 0x2F0C20
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0D50 Offset: 0x2F0E51 VA: 0x2F0D50
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0E80 Offset: 0x2F0F81 VA: 0x2F0E80
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F0FB0 Offset: 0x2F10B1 VA: 0x2F0FB0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F10F0 Offset: 0x2F11F1 VA: 0x2F10F0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F1230 Offset: 0x2F1331 VA: 0x2F1230
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F1360 Offset: 0x2F1461 VA: 0x2F1360
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FB580 Offset: 0x2FB681 VA: 0x2FB580
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FB6C0 Offset: 0x2FB7C1 VA: 0x2FB6C0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FB7F0 Offset: 0x2FB8F1 VA: 0x2FB7F0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FB930 Offset: 0x2FBA31 VA: 0x2FB930
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FBA70 Offset: 0x2FBB71 VA: 0x2FBA70
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FBBA0 Offset: 0x2FBCA1 VA: 0x2FBBA0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FBCD0 Offset: 0x2FBDD1 VA: 0x2FBCD0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FBE00 Offset: 0x2FBF01 VA: 0x2FBE00
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FBF20 Offset: 0x2FC021 VA: 0x2FBF20
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FC050 Offset: 0x2FC151 VA: 0x2FC050
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FC180 Offset: 0x2FC281 VA: 0x2FC180
	|-Dictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FC340 Offset: 0x2FC441 VA: 0x2FC340
	|-Dictionary.ValueCollection.Enumerator<object, ReadOnlyMemory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FC460 Offset: 0x2FC561 VA: 0x2FC460
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FC580 Offset: 0x2FC681 VA: 0x2FC580
	|-Dictionary.ValueCollection.Enumerator<object, sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FC6A0 Offset: 0x2FC7A1 VA: 0x2FC6A0
	|-Dictionary.ValueCollection.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FC7C0 Offset: 0x2FC8C1 VA: 0x2FC7C0
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FC8E0 Offset: 0x2FC9E1 VA: 0x2FC8E0
	|-Dictionary.ValueCollection.Enumerator<object, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FCA00 Offset: 0x2FCB01 VA: 0x2FCA00
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FCB30 Offset: 0x2FCC31 VA: 0x2FCB30
	|-Dictionary.ValueCollection.Enumerator<object, TransitionTables>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FCC70 Offset: 0x2FCD71 VA: 0x2FCC70
	|-Dictionary.ValueCollection.Enumerator<object, Bounds>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FCDB0 Offset: 0x2FCEB1 VA: 0x2FCDB0
	|-Dictionary.ValueCollection.Enumerator<object, BoundsInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FCEE0 Offset: 0x2FCFE1 VA: 0x2FCEE0
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FD000 Offset: 0x2FD101 VA: 0x2FD000
	|-Dictionary.ValueCollection.Enumerator<object, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FD120 Offset: 0x2FD221 VA: 0x2FD120
	|-Dictionary.ValueCollection.Enumerator<object, GradientAlphaKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FD250 Offset: 0x2FD351 VA: 0x2FD250
	|-Dictionary.ValueCollection.Enumerator<object, GradientColorKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FD3A0 Offset: 0x2FD4A1 VA: 0x2FD3A0
	|-Dictionary.ValueCollection.Enumerator<object, Keyframe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FD4D0 Offset: 0x2FD5D1 VA: 0x2FD4D0
	|-Dictionary.ValueCollection.Enumerator<object, LayerMask>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FD620 Offset: 0x2FD721 VA: 0x2FD620
	|-Dictionary.ValueCollection.Enumerator<object, Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FD750 Offset: 0x2FD851 VA: 0x2FD750
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FD870 Offset: 0x2FD971 VA: 0x2FD870
	|-Dictionary.ValueCollection.Enumerator<object, Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FD990 Offset: 0x2FDA91 VA: 0x2FD990
	|-Dictionary.ValueCollection.Enumerator<object, RangeInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FDAB0 Offset: 0x2FDBB1 VA: 0x2FDAB0
	|-Dictionary.ValueCollection.Enumerator<object, Rect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FDBD0 Offset: 0x2FDCD1 VA: 0x2FDBD0
	|-Dictionary.ValueCollection.Enumerator<object, RectInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FDD00 Offset: 0x2FDE01 VA: 0x2FDD00
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FDE40 Offset: 0x2FDF41 VA: 0x2FDE40
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FDF70 Offset: 0x2FE071 VA: 0x2FDF70
	|-Dictionary.ValueCollection.Enumerator<object, Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FE090 Offset: 0x2FE191 VA: 0x2FE090
	|-Dictionary.ValueCollection.Enumerator<object, Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FE1B0 Offset: 0x2FE2B1 VA: 0x2FE1B0
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FE2E0 Offset: 0x2FE3E1 VA: 0x2FE2E0
	|-Dictionary.ValueCollection.Enumerator<object, Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FE410 Offset: 0x2FE511 VA: 0x2FE410
	|-Dictionary.ValueCollection.Enumerator<object, Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FE530 Offset: 0x2FE631 VA: 0x2FE530
	|-Dictionary.ValueCollection.Enumerator<ReadOnlyMemory<object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FE6F0 Offset: 0x2FE7F1 VA: 0x2FE6F0
	|-Dictionary.ValueCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FE810 Offset: 0x2FE911 VA: 0x2FE810
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FEA00 Offset: 0x2FEB01 VA: 0x2FEA00
	|-Dictionary.ValueCollection.Enumerator<float, CurveSample>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FEB30 Offset: 0x2FEC31 VA: 0x2FEB30
	|-Dictionary.ValueCollection.Enumerator<float, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FECF0 Offset: 0x2FEDF1 VA: 0x2FECF0
	|-Dictionary.ValueCollection.Enumerator<ushort, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FEEB0 Offset: 0x2FEFB1 VA: 0x2FEEB0
	|-Dictionary.ValueCollection.Enumerator<uint, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FEFD0 Offset: 0x2FF0D1 VA: 0x2FEFD0
	|-Dictionary.ValueCollection.Enumerator<uint, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FF0F0 Offset: 0x2FF1F1 VA: 0x2FF0F0
	|-Dictionary.ValueCollection.Enumerator<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FF2B0 Offset: 0x2FF3B1 VA: 0x2FF2B0
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FF470 Offset: 0x2FF571 VA: 0x2FF470
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FF5C0 Offset: 0x2FF6C1 VA: 0x2FF5C0
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, CapEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FF710 Offset: 0x2FF811 VA: 0x2FF710
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FF850 Offset: 0x2FF951 VA: 0x2FF850
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FF980 Offset: 0x2FFA81 VA: 0x2FF980
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FFAA0 Offset: 0x2FFBA1 VA: 0x2FFAA0
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FFC60 Offset: 0x2FFD61 VA: 0x2FFC60
	|-Dictionary.ValueCollection.Enumerator<Bounds, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FFE20 Offset: 0x2FFF21 VA: 0x2FFE20
	|-Dictionary.ValueCollection.Enumerator<BoundsInt, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FFFE0 Offset: 0x3000E1 VA: 0x2FFFE0
	|-Dictionary.ValueCollection.Enumerator<Color, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3001A0 Offset: 0x3002A1 VA: 0x3001A0
	|-Dictionary.ValueCollection.Enumerator<Color32, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x300360 Offset: 0x300461 VA: 0x300360
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x300520 Offset: 0x300621 VA: 0x300520
	|-Dictionary.ValueCollection.Enumerator<GradientAlphaKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3006E0 Offset: 0x3007E1 VA: 0x3006E0
	|-Dictionary.ValueCollection.Enumerator<GradientColorKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3008A0 Offset: 0x3009A1 VA: 0x3008A0
	|-Dictionary.ValueCollection.Enumerator<Keyframe, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x300A60 Offset: 0x300B61 VA: 0x300A60
	|-Dictionary.ValueCollection.Enumerator<LayerMask, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x300C20 Offset: 0x300D21 VA: 0x300C20
	|-Dictionary.ValueCollection.Enumerator<Matrix4x4, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x300DE0 Offset: 0x300EE1 VA: 0x300DE0
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x300FA0 Offset: 0x3010A1 VA: 0x300FA0
	|-Dictionary.ValueCollection.Enumerator<Quaternion, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x301160 Offset: 0x301261 VA: 0x301160
	|-Dictionary.ValueCollection.Enumerator<RangeInt, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x301320 Offset: 0x301421 VA: 0x301320
	|-Dictionary.ValueCollection.Enumerator<Rect, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3014E0 Offset: 0x3015E1 VA: 0x3014E0
	|-Dictionary.ValueCollection.Enumerator<RectInt, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3016A0 Offset: 0x3017A1 VA: 0x3016A0
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3017C0 Offset: 0x3018C1 VA: 0x3017C0
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x301980 Offset: 0x301A81 VA: 0x301980
	|-Dictionary.ValueCollection.Enumerator<Vector2, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x301B40 Offset: 0x301C41 VA: 0x301B40
	|-Dictionary.ValueCollection.Enumerator<Vector2Int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x301D00 Offset: 0x301E01 VA: 0x301D00
	|-Dictionary.ValueCollection.Enumerator<Vector3, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x301EC0 Offset: 0x301FC1 VA: 0x301EC0
	|-Dictionary.ValueCollection.Enumerator<Vector3Int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x302080 Offset: 0x302181 VA: 0x302080
	|-Dictionary.ValueCollection.Enumerator<Vector4, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36AC00 Offset: 0x36AD01 VA: 0x36AC00
	|-Dictionary.ValueCollection.Enumerator<JSONDeserialization.TaskField, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36ADC0 Offset: 0x36AEC1 VA: 0x36ADC0
	|-Dictionary.ValueCollection.Enumerator<BitVector32Int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36AF80 Offset: 0x36B081 VA: 0x36AF80
	|-Dictionary.ValueCollection.Enumerator<EventCheckId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36B140 Offset: 0x36B241 VA: 0x36B140
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36B300 Offset: 0x36B401 VA: 0x36B300
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36B4C0 Offset: 0x36B5C1 VA: 0x36B4C0
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36B680 Offset: 0x36B781 VA: 0x36B680
	|-Dictionary.ValueCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36B840 Offset: 0x36B941 VA: 0x36B840
	|-Dictionary.ValueCollection.Enumerator<MonsterHutSaveData, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36BA00 Offset: 0x36BB01 VA: 0x36BA00
	|-Dictionary.ValueCollection.Enumerator<OrderLotterySaveParameter, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36BBC0 Offset: 0x36BCC1 VA: 0x36BBC0
	|-Dictionary.ValueCollection.Enumerator<OrderSaveData, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36BD80 Offset: 0x36BE81 VA: 0x36BD80
	|-Dictionary.ValueCollection.Enumerator<OrderSaveParameter, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36BF40 Offset: 0x36C041 VA: 0x36BF40
	|-Dictionary.ValueCollection.Enumerator<Parameter, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36C100 Offset: 0x36C201 VA: 0x36C100
	|-Dictionary.ValueCollection.Enumerator<bool, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36C2C0 Offset: 0x36C3C1 VA: 0x36C2C0
	|-Dictionary.ValueCollection.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EA120 Offset: 0x2EA221 VA: 0x2EA120
	|-Dictionary.ValueCollection.Enumerator<char, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EA2E0 Offset: 0x2EA3E1 VA: 0x2EA2E0
	|-Dictionary.ValueCollection.Enumerator<DateTime, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EA4A0 Offset: 0x2EA5A1 VA: 0x2EA4A0
	|-Dictionary.ValueCollection.Enumerator<double, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EA660 Offset: 0x2EA761 VA: 0x2EA660
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EA820 Offset: 0x2EA921 VA: 0x2EA820
	|-Dictionary.ValueCollection.Enumerator<short, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EA980 Offset: 0x2EAA81 VA: 0x2EA980
	|-Dictionary.ValueCollection.Enumerator<int, CropDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAAF0 Offset: 0x2EABF1 VA: 0x2EAAF0
	|-Dictionary.ValueCollection.Enumerator<int, EffectDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAC20 Offset: 0x2EAD21 VA: 0x2EAC20
	|-Dictionary.ValueCollection.Enumerator<int, GimmickLayoutDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAD70 Offset: 0x2EAE71 VA: 0x2EAD70
	|-Dictionary.ValueCollection.Enumerator<int, MineTypeDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAEA0 Offset: 0x2EAFA1 VA: 0x2EAEA0
	|-Dictionary.ValueCollection.Enumerator<int, MiningDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAFC0 Offset: 0x2EB0C1 VA: 0x2EAFC0
	|-Dictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB0E0 Offset: 0x2EB1E1 VA: 0x2EB0E0
	|-Dictionary.ValueCollection.Enumerator<int, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB200 Offset: 0x2EB301 VA: 0x2EB200
	|-Dictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB320 Offset: 0x2EB421 VA: 0x2EB320
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB440 Offset: 0x2EB541 VA: 0x2EB440
	|-Dictionary.ValueCollection.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB600 Offset: 0x2EB701 VA: 0x2EB600
	|-Dictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB740 Offset: 0x2EB841 VA: 0x2EB740
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB870 Offset: 0x2EB971 VA: 0x2EB870
	|-Dictionary.ValueCollection.Enumerator<int, SceneInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB990 Offset: 0x2EBA91 VA: 0x2EB990
	|-Dictionary.ValueCollection.Enumerator<int, Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBAB0 Offset: 0x2EBBB1 VA: 0x2EBAB0
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBC10 Offset: 0x2EBD11 VA: 0x2EBC10
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBD80 Offset: 0x2EBE81 VA: 0x2EBD80
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBEB0 Offset: 0x2EBFB1 VA: 0x2EBEB0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBFD0 Offset: 0x2EC0D1 VA: 0x2EBFD0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EC0F0 Offset: 0x2EC1F1 VA: 0x2EC0F0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EC210 Offset: 0x2EC311 VA: 0x2EC210
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EC330 Offset: 0x2EC431 VA: 0x2EC330
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EC4F0 Offset: 0x2EC5F1 VA: 0x2EC4F0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EC610 Offset: 0x2EC711 VA: 0x2EC610
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EC730 Offset: 0x2EC831 VA: 0x2EC730
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EC850 Offset: 0x2EC951 VA: 0x2EC850
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EC970 Offset: 0x2ECA71 VA: 0x2EC970
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2ECB40 Offset: 0x2ECC41 VA: 0x2ECB40
	|-Dictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2ECD00 Offset: 0x2ECE01 VA: 0x2ECD00
	|-Dictionary.ValueCollection.Enumerator<Memory<object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2ECEC0 Offset: 0x2ECFC1 VA: 0x2ECEC0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Int32Enum>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2ED080 Offset: 0x2ED181 VA: 0x2ED080
	|-Dictionary.ValueCollection.Enumerator<Nullable<Bounds>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2ED240 Offset: 0x2ED341 VA: 0x2ED240
	|-Dictionary.ValueCollection.Enumerator<Nullable<BoundsInt>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2ED400 Offset: 0x2ED501 VA: 0x2ED400
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color32>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2ED5C0 Offset: 0x2ED6C1 VA: 0x2ED5C0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Color>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2ED780 Offset: 0x2ED881 VA: 0x2ED780
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientAlphaKey>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2ED940 Offset: 0x2EDA41 VA: 0x2ED940
	|-Dictionary.ValueCollection.Enumerator<Nullable<GradientColorKey>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EDB00 Offset: 0x2EDC01 VA: 0x2EDB00
	|-Dictionary.ValueCollection.Enumerator<Nullable<Keyframe>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EDCC0 Offset: 0x2EDDC1 VA: 0x2EDCC0
	|-Dictionary.ValueCollection.Enumerator<Nullable<LayerMask>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EDE80 Offset: 0x2EDF81 VA: 0x2EDE80
	|-Dictionary.ValueCollection.Enumerator<Nullable<Matrix4x4>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EE040 Offset: 0x2EE141 VA: 0x2EE040
	|-Dictionary.ValueCollection.Enumerator<Nullable<Quaternion>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EE200 Offset: 0x2EE301 VA: 0x2EE200
	|-Dictionary.ValueCollection.Enumerator<Nullable<RangeInt>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EE3C0 Offset: 0x2EE4C1 VA: 0x2EE3C0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Rect>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EE580 Offset: 0x2EE681 VA: 0x2EE580
	|-Dictionary.ValueCollection.Enumerator<Nullable<RectInt>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EE740 Offset: 0x2EE841 VA: 0x2EE740
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EE900 Offset: 0x2EEA01 VA: 0x2EE900
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector2Int>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EEAC0 Offset: 0x2EEBC1 VA: 0x2EEAC0
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EEC80 Offset: 0x2EED81 VA: 0x2EEC80
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector3Int>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EEE40 Offset: 0x2EEF41 VA: 0x2EEE40
	|-Dictionary.ValueCollection.Enumerator<Nullable<Vector4>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EEF60 Offset: 0x2EF061 VA: 0x2EEF60
	|-Dictionary.ValueCollection.Enumerator<object, BitVector32Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EF090 Offset: 0x2EF191 VA: 0x2EF090
	|-Dictionary.ValueCollection.Enumerator<object, EventCheckId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EF1F0 Offset: 0x2EF2F1 VA: 0x2EF1F0
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EF330 Offset: 0x2EF431 VA: 0x2EF330
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EF460 Offset: 0x2EF561 VA: 0x2EF460
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EF590 Offset: 0x2EF691 VA: 0x2EF590
	|-Dictionary.ValueCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EF6D0 Offset: 0x2EF7D1 VA: 0x2EF6D0
	|-Dictionary.ValueCollection.Enumerator<object, MonsterHutSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EF800 Offset: 0x2EF901 VA: 0x2EF800
	|-Dictionary.ValueCollection.Enumerator<object, OrderLotterySaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EF950 Offset: 0x2EFA51 VA: 0x2EF950
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EFA90 Offset: 0x2EFB91 VA: 0x2EFA90
	|-Dictionary.ValueCollection.Enumerator<object, OrderSaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EFBF0 Offset: 0x2EFCF1 VA: 0x2EFBF0
	|-Dictionary.ValueCollection.Enumerator<object, Parameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EFD40 Offset: 0x2EFE41 VA: 0x2EFD40
	|-Dictionary.ValueCollection.Enumerator<object, NumberControl.ValueRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EFE60 Offset: 0x2EFF61 VA: 0x2EFE60
	|-Dictionary.ValueCollection.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EFF80 Offset: 0x2F0081 VA: 0x2EFF80
	|-Dictionary.ValueCollection.Enumerator<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F00A0 Offset: 0x2F01A1 VA: 0x2F00A0
	|-Dictionary.ValueCollection.Enumerator<object, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F01C0 Offset: 0x2F02C1 VA: 0x2F01C0
	|-Dictionary.ValueCollection.Enumerator<object, DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F02E0 Offset: 0x2F03E1 VA: 0x2F02E0
	|-Dictionary.ValueCollection.Enumerator<object, double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0400 Offset: 0x2F0501 VA: 0x2F0400
	|-Dictionary.ValueCollection.Enumerator<object, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0520 Offset: 0x2F0621 VA: 0x2F0520
	|-Dictionary.ValueCollection.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0640 Offset: 0x2F0741 VA: 0x2F0640
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0760 Offset: 0x2F0861 VA: 0x2F0760
	|-Dictionary.ValueCollection.Enumerator<object, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0880 Offset: 0x2F0981 VA: 0x2F0880
	|-Dictionary.ValueCollection.Enumerator<object, Memory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F09A0 Offset: 0x2F0AA1 VA: 0x2F09A0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0AE0 Offset: 0x2F0BE1 VA: 0x2F0AE0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0C30 Offset: 0x2F0D31 VA: 0x2F0C30
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0D60 Offset: 0x2F0E61 VA: 0x2F0D60
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0E90 Offset: 0x2F0F91 VA: 0x2F0E90
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F0FC0 Offset: 0x2F10C1 VA: 0x2F0FC0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F1100 Offset: 0x2F1201 VA: 0x2F1100
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F1240 Offset: 0x2F1341 VA: 0x2F1240
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F1370 Offset: 0x2F1471 VA: 0x2F1370
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FB590 Offset: 0x2FB691 VA: 0x2FB590
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FB6D0 Offset: 0x2FB7D1 VA: 0x2FB6D0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FB800 Offset: 0x2FB901 VA: 0x2FB800
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FB940 Offset: 0x2FBA41 VA: 0x2FB940
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FBA80 Offset: 0x2FBB81 VA: 0x2FBA80
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FBBB0 Offset: 0x2FBCB1 VA: 0x2FBBB0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FBCE0 Offset: 0x2FBDE1 VA: 0x2FBCE0
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FBE10 Offset: 0x2FBF11 VA: 0x2FBE10
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FBF30 Offset: 0x2FC031 VA: 0x2FBF30
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FC060 Offset: 0x2FC161 VA: 0x2FC060
	|-Dictionary.ValueCollection.Enumerator<object, Nullable<Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FC230 Offset: 0x2FC331 VA: 0x2FC230
	|-Dictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FC350 Offset: 0x2FC451 VA: 0x2FC350
	|-Dictionary.ValueCollection.Enumerator<object, ReadOnlyMemory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FC470 Offset: 0x2FC571 VA: 0x2FC470
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FC590 Offset: 0x2FC691 VA: 0x2FC590
	|-Dictionary.ValueCollection.Enumerator<object, sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FC6B0 Offset: 0x2FC7B1 VA: 0x2FC6B0
	|-Dictionary.ValueCollection.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FC7D0 Offset: 0x2FC8D1 VA: 0x2FC7D0
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FC8F0 Offset: 0x2FC9F1 VA: 0x2FC8F0
	|-Dictionary.ValueCollection.Enumerator<object, uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FCA10 Offset: 0x2FCB11 VA: 0x2FCA10
	|-Dictionary.ValueCollection.Enumerator<object, ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FCB40 Offset: 0x2FCC41 VA: 0x2FCB40
	|-Dictionary.ValueCollection.Enumerator<object, TransitionTables>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FCC80 Offset: 0x2FCD81 VA: 0x2FCC80
	|-Dictionary.ValueCollection.Enumerator<object, Bounds>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FCDC0 Offset: 0x2FCEC1 VA: 0x2FCDC0
	|-Dictionary.ValueCollection.Enumerator<object, BoundsInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FCEF0 Offset: 0x2FCFF1 VA: 0x2FCEF0
	|-Dictionary.ValueCollection.Enumerator<object, Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FD010 Offset: 0x2FD111 VA: 0x2FD010
	|-Dictionary.ValueCollection.Enumerator<object, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FD130 Offset: 0x2FD231 VA: 0x2FD130
	|-Dictionary.ValueCollection.Enumerator<object, GradientAlphaKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FD260 Offset: 0x2FD361 VA: 0x2FD260
	|-Dictionary.ValueCollection.Enumerator<object, GradientColorKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FD3B0 Offset: 0x2FD4B1 VA: 0x2FD3B0
	|-Dictionary.ValueCollection.Enumerator<object, Keyframe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FD4E0 Offset: 0x2FD5E1 VA: 0x2FD4E0
	|-Dictionary.ValueCollection.Enumerator<object, LayerMask>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FD630 Offset: 0x2FD731 VA: 0x2FD630
	|-Dictionary.ValueCollection.Enumerator<object, Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FD760 Offset: 0x2FD861 VA: 0x2FD760
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FD880 Offset: 0x2FD981 VA: 0x2FD880
	|-Dictionary.ValueCollection.Enumerator<object, Quaternion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FD9A0 Offset: 0x2FDAA1 VA: 0x2FD9A0
	|-Dictionary.ValueCollection.Enumerator<object, RangeInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FDAC0 Offset: 0x2FDBC1 VA: 0x2FDAC0
	|-Dictionary.ValueCollection.Enumerator<object, Rect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FDBE0 Offset: 0x2FDCE1 VA: 0x2FDBE0
	|-Dictionary.ValueCollection.Enumerator<object, RectInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FDD10 Offset: 0x2FDE11 VA: 0x2FDD10
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FDE50 Offset: 0x2FDF51 VA: 0x2FDE50
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FDF80 Offset: 0x2FE081 VA: 0x2FDF80
	|-Dictionary.ValueCollection.Enumerator<object, Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FE0A0 Offset: 0x2FE1A1 VA: 0x2FE0A0
	|-Dictionary.ValueCollection.Enumerator<object, Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FE1C0 Offset: 0x2FE2C1 VA: 0x2FE1C0
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FE2F0 Offset: 0x2FE3F1 VA: 0x2FE2F0
	|-Dictionary.ValueCollection.Enumerator<object, Vector3Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FE420 Offset: 0x2FE521 VA: 0x2FE420
	|-Dictionary.ValueCollection.Enumerator<object, Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FE5E0 Offset: 0x2FE6E1 VA: 0x2FE5E0
	|-Dictionary.ValueCollection.Enumerator<ReadOnlyMemory<object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FE700 Offset: 0x2FE801 VA: 0x2FE700
	|-Dictionary.ValueCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FE8C0 Offset: 0x2FE9C1 VA: 0x2FE8C0
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FEA10 Offset: 0x2FEB11 VA: 0x2FEA10
	|-Dictionary.ValueCollection.Enumerator<float, CurveSample>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FEBE0 Offset: 0x2FECE1 VA: 0x2FEBE0
	|-Dictionary.ValueCollection.Enumerator<float, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FEDA0 Offset: 0x2FEEA1 VA: 0x2FEDA0
	|-Dictionary.ValueCollection.Enumerator<ushort, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FEEC0 Offset: 0x2FEFC1 VA: 0x2FEEC0
	|-Dictionary.ValueCollection.Enumerator<uint, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FEFE0 Offset: 0x2FF0E1 VA: 0x2FEFE0
	|-Dictionary.ValueCollection.Enumerator<uint, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FF1A0 Offset: 0x2FF2A1 VA: 0x2FF1A0
	|-Dictionary.ValueCollection.Enumerator<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FF360 Offset: 0x2FF461 VA: 0x2FF360
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FF480 Offset: 0x2FF581 VA: 0x2FF480
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FF5D0 Offset: 0x2FF6D1 VA: 0x2FF5D0
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, CapEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FF720 Offset: 0x2FF821 VA: 0x2FF720
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FF860 Offset: 0x2FF961 VA: 0x2FF860
	|-Dictionary.ValueCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FF990 Offset: 0x2FFA91 VA: 0x2FF990
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FFB50 Offset: 0x2FFC51 VA: 0x2FFB50
	|-Dictionary.ValueCollection.Enumerator<MeshDataConnectivity.Face, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FFD10 Offset: 0x2FFE11 VA: 0x2FFD10
	|-Dictionary.ValueCollection.Enumerator<Bounds, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FFED0 Offset: 0x2FFFD1 VA: 0x2FFED0
	|-Dictionary.ValueCollection.Enumerator<BoundsInt, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x300090 Offset: 0x300191 VA: 0x300090
	|-Dictionary.ValueCollection.Enumerator<Color, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x300250 Offset: 0x300351 VA: 0x300250
	|-Dictionary.ValueCollection.Enumerator<Color32, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x300410 Offset: 0x300511 VA: 0x300410
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3005D0 Offset: 0x3006D1 VA: 0x3005D0
	|-Dictionary.ValueCollection.Enumerator<GradientAlphaKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x300790 Offset: 0x300891 VA: 0x300790
	|-Dictionary.ValueCollection.Enumerator<GradientColorKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x300950 Offset: 0x300A51 VA: 0x300950
	|-Dictionary.ValueCollection.Enumerator<Keyframe, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x300B10 Offset: 0x300C11 VA: 0x300B10
	|-Dictionary.ValueCollection.Enumerator<LayerMask, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x300CD0 Offset: 0x300DD1 VA: 0x300CD0
	|-Dictionary.ValueCollection.Enumerator<Matrix4x4, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x300E90 Offset: 0x300F91 VA: 0x300E90
	|-Dictionary.ValueCollection.Enumerator<IntVec3, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x301050 Offset: 0x301151 VA: 0x301050
	|-Dictionary.ValueCollection.Enumerator<Quaternion, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x301210 Offset: 0x301311 VA: 0x301210
	|-Dictionary.ValueCollection.Enumerator<RangeInt, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3013D0 Offset: 0x3014D1 VA: 0x3013D0
	|-Dictionary.ValueCollection.Enumerator<Rect, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x301590 Offset: 0x301691 VA: 0x301590
	|-Dictionary.ValueCollection.Enumerator<RectInt, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3016B0 Offset: 0x3017B1 VA: 0x3016B0
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x301870 Offset: 0x301971 VA: 0x301870
	|-Dictionary.ValueCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x301A30 Offset: 0x301B31 VA: 0x301A30
	|-Dictionary.ValueCollection.Enumerator<Vector2, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x301BF0 Offset: 0x301CF1 VA: 0x301BF0
	|-Dictionary.ValueCollection.Enumerator<Vector2Int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x301DB0 Offset: 0x301EB1 VA: 0x301DB0
	|-Dictionary.ValueCollection.Enumerator<Vector3, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x301F70 Offset: 0x302071 VA: 0x301F70
	|-Dictionary.ValueCollection.Enumerator<Vector3Int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x302130 Offset: 0x302231 VA: 0x302130
	|-Dictionary.ValueCollection.Enumerator<Vector4, object>.System.Collections.IEnumerator.Reset
	*/
}

