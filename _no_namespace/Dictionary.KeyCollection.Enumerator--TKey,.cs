[Serializable]
public struct Dictionary.KeyCollection.Enumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 1426
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private TKey currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x338810 Offset: 0x338911 VA: 0x338810
	|-Dictionary.KeyCollection.Enumerator<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x338930 Offset: 0x338A31 VA: 0x338930
	|-Dictionary.KeyCollection.Enumerator<BitVector32Int, object>..ctor
	|
	|-RVA: 0x338A50 Offset: 0x338B51 VA: 0x338A50
	|-Dictionary.KeyCollection.Enumerator<EventCheckId, object>..ctor
	|
	|-RVA: 0x338B90 Offset: 0x338C91 VA: 0x338B90
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x2E2FB0 Offset: 0x2E30B1 VA: 0x2E2FB0
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x2E30F0 Offset: 0x2E31F1 VA: 0x2E30F0
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x2E3220 Offset: 0x2E3321 VA: 0x2E3220
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x2E3340 Offset: 0x2E3441 VA: 0x2E3340
	|-Dictionary.KeyCollection.Enumerator<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x2E3490 Offset: 0x2E3591 VA: 0x2E3490
	|-Dictionary.KeyCollection.Enumerator<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x2E35C0 Offset: 0x2E36C1 VA: 0x2E35C0
	|-Dictionary.KeyCollection.Enumerator<OrderSaveData, object>..ctor
	|
	|-RVA: 0x2E3710 Offset: 0x2E3811 VA: 0x2E3710
	|-Dictionary.KeyCollection.Enumerator<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x2E3850 Offset: 0x2E3951 VA: 0x2E3850
	|-Dictionary.KeyCollection.Enumerator<Parameter, object>..ctor
	|
	|-RVA: 0x2E39D0 Offset: 0x2E3AD1 VA: 0x2E39D0
	|-Dictionary.KeyCollection.Enumerator<bool, object>..ctor
	|
	|-RVA: 0x2E3AF0 Offset: 0x2E3BF1 VA: 0x2E3AF0
	|-Dictionary.KeyCollection.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x2E3C10 Offset: 0x2E3D11 VA: 0x2E3C10
	|-Dictionary.KeyCollection.Enumerator<char, object>..ctor
	|
	|-RVA: 0x2E3D30 Offset: 0x2E3E31 VA: 0x2E3D30
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>..ctor
	|
	|-RVA: 0x2E3E50 Offset: 0x2E3F51 VA: 0x2E3E50
	|-Dictionary.KeyCollection.Enumerator<double, object>..ctor
	|
	|-RVA: 0x2E3F70 Offset: 0x2E4071 VA: 0x2E3F70
	|-Dictionary.KeyCollection.Enumerator<Guid, object>..ctor
	|
	|-RVA: 0x2E4090 Offset: 0x2E4191 VA: 0x2E4090
	|-Dictionary.KeyCollection.Enumerator<short, object>..ctor
	|
	|-RVA: 0x2E41B0 Offset: 0x2E42B1 VA: 0x2E41B0
	|-Dictionary.KeyCollection.Enumerator<int, CropDataTable>..ctor
	|
	|-RVA: 0x2E42D0 Offset: 0x2E43D1 VA: 0x2E42D0
	|-Dictionary.KeyCollection.Enumerator<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2E43F0 Offset: 0x2E44F1 VA: 0x2E43F0
	|-Dictionary.KeyCollection.Enumerator<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E4510 Offset: 0x2E4611 VA: 0x2E4510
	|-Dictionary.KeyCollection.Enumerator<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E4630 Offset: 0x2E4731 VA: 0x2E4630
	|-Dictionary.KeyCollection.Enumerator<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2E4750 Offset: 0x2E4851 VA: 0x2E4750
	|-Dictionary.KeyCollection.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x2E4870 Offset: 0x2E4971 VA: 0x2E4870
	|-Dictionary.KeyCollection.Enumerator<int, char>..ctor
	|
	|-RVA: 0x2E4990 Offset: 0x2E4A91 VA: 0x2E4990
	|-Dictionary.KeyCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x2E4AB0 Offset: 0x2E4BB1 VA: 0x2E4AB0
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>..ctor
	|
	|-RVA: 0x2E4BD0 Offset: 0x2E4CD1 VA: 0x2E4BD0
	|-Dictionary.KeyCollection.Enumerator<int, long>..ctor
	|
	|-RVA: 0x2E4CF0 Offset: 0x2E4DF1 VA: 0x2E4CF0
	|-Dictionary.KeyCollection.Enumerator<int, object>..ctor
	|
	|-RVA: 0x2E4E10 Offset: 0x2E4F11 VA: 0x2E4E10
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x2E4F30 Offset: 0x2E5031 VA: 0x2E4F30
	|-Dictionary.KeyCollection.Enumerator<int, SceneInstance>..ctor
	|
	|-RVA: 0x2E5050 Offset: 0x2E5151 VA: 0x2E5050
	|-Dictionary.KeyCollection.Enumerator<int, Vector2Int>..ctor
	|
	|-RVA: 0x2E5170 Offset: 0x2E5271 VA: 0x2E5170
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>..ctor
	|
	|-RVA: 0x2E5290 Offset: 0x2E5391 VA: 0x2E5290
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x2E53B0 Offset: 0x2E54B1 VA: 0x2E53B0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E54D0 Offset: 0x2E55D1 VA: 0x2E54D0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x2E55F0 Offset: 0x2E56F1 VA: 0x2E55F0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2E5710 Offset: 0x2E5811 VA: 0x2E5710
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2E5830 Offset: 0x2E5931 VA: 0x2E5830
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x2E5950 Offset: 0x2E5A51 VA: 0x2E5950
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2E5A70 Offset: 0x2E5B71 VA: 0x2E5A70
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>..ctor
	|
	|-RVA: 0x2E5B90 Offset: 0x2E5C91 VA: 0x2E5B90
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>..ctor
	|
	|-RVA: 0x2E5CB0 Offset: 0x2E5DB1 VA: 0x2E5CB0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2E5DD0 Offset: 0x2E5ED1 VA: 0x2E5DD0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x2E5EF0 Offset: 0x2E5FF1 VA: 0x2E5EF0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x2E6010 Offset: 0x2E6111 VA: 0x2E6010
	|-Dictionary.KeyCollection.Enumerator<long, object>..ctor
	|
	|-RVA: 0x2E6130 Offset: 0x2E6231 VA: 0x2E6130
	|-Dictionary.KeyCollection.Enumerator<Memory<object>, object>..ctor
	|
	|-RVA: 0x2E6250 Offset: 0x2E6351 VA: 0x2E6250
	|-Dictionary.KeyCollection.Enumerator<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x2E6370 Offset: 0x2E6471 VA: 0x2E6370
	|-Dictionary.KeyCollection.Enumerator<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x2E64C0 Offset: 0x2E65C1 VA: 0x2E64C0
	|-Dictionary.KeyCollection.Enumerator<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x2E6610 Offset: 0x2E6711 VA: 0x2E6610
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x2E6730 Offset: 0x2E6831 VA: 0x2E6730
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x2E6870 Offset: 0x2E6971 VA: 0x2E6870
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x2E69A0 Offset: 0x2E6AA1 VA: 0x2E69A0
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x2E6AE0 Offset: 0x2E6BE1 VA: 0x2E6AE0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x2E6C20 Offset: 0x2E6D21 VA: 0x2E6C20
	|-Dictionary.KeyCollection.Enumerator<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x2E6D40 Offset: 0x2E6E41 VA: 0x2E6D40
	|-Dictionary.KeyCollection.Enumerator<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x2E6EB0 Offset: 0x2E6FB1 VA: 0x2E6EB0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x2E6FF0 Offset: 0x2E70F1 VA: 0x2E6FF0
	|-Dictionary.KeyCollection.Enumerator<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x2E7120 Offset: 0x2E7221 VA: 0x2E7120
	|-Dictionary.KeyCollection.Enumerator<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x2E7260 Offset: 0x2E7361 VA: 0x2E7260
	|-Dictionary.KeyCollection.Enumerator<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x2E73A0 Offset: 0x2E74A1 VA: 0x2E73A0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x2E74D0 Offset: 0x2E75D1 VA: 0x2E74D0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x2E7600 Offset: 0x2E7701 VA: 0x2E7600
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x2E7720 Offset: 0x2E7821 VA: 0x2E7720
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x2E7840 Offset: 0x2E7941 VA: 0x2E7840
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x2E7980 Offset: 0x2E7A81 VA: 0x2E7980
	|-Dictionary.KeyCollection.Enumerator<object, BitVector32Int>..ctor
	|
	|-RVA: 0x2E7B40 Offset: 0x2E7C41 VA: 0x2E7B40
	|-Dictionary.KeyCollection.Enumerator<object, EventCheckId>..ctor
	|
	|-RVA: 0x2E7D00 Offset: 0x2E7E01 VA: 0x2E7D00
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2E7EC0 Offset: 0x2E7FC1 VA: 0x2E7EC0
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2E8080 Offset: 0x2E8181 VA: 0x2E8080
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2E8240 Offset: 0x2E8341 VA: 0x2E8240
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x2E8400 Offset: 0x2E8501 VA: 0x2E8400
	|-Dictionary.KeyCollection.Enumerator<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2E85C0 Offset: 0x2E86C1 VA: 0x2E85C0
	|-Dictionary.KeyCollection.Enumerator<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2E8780 Offset: 0x2E8881 VA: 0x2E8780
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveData>..ctor
	|
	|-RVA: 0x2E8940 Offset: 0x2E8A41 VA: 0x2E8940
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x2E8B00 Offset: 0x2E8C01 VA: 0x2E8B00
	|-Dictionary.KeyCollection.Enumerator<object, Parameter>..ctor
	|
	|-RVA: 0x2E8CC0 Offset: 0x2E8DC1 VA: 0x2E8CC0
	|-Dictionary.KeyCollection.Enumerator<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x2E8E80 Offset: 0x2E8F81 VA: 0x2E8E80
	|-Dictionary.KeyCollection.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x2E9040 Offset: 0x2E9141 VA: 0x2E9040
	|-Dictionary.KeyCollection.Enumerator<object, byte>..ctor
	|
	|-RVA: 0x2E9200 Offset: 0x2E9301 VA: 0x2E9200
	|-Dictionary.KeyCollection.Enumerator<object, char>..ctor
	|
	|-RVA: 0x2E93C0 Offset: 0x2E94C1 VA: 0x2E93C0
	|-Dictionary.KeyCollection.Enumerator<object, DateTime>..ctor
	|
	|-RVA: 0x2E9580 Offset: 0x2E9681 VA: 0x2E9580
	|-Dictionary.KeyCollection.Enumerator<object, double>..ctor
	|
	|-RVA: 0x2E9740 Offset: 0x2E9841 VA: 0x2E9740
	|-Dictionary.KeyCollection.Enumerator<object, short>..ctor
	|
	|-RVA: 0x2E9900 Offset: 0x2E9A01 VA: 0x2E9900
	|-Dictionary.KeyCollection.Enumerator<object, int>..ctor
	|
	|-RVA: 0x2E9AC0 Offset: 0x2E9BC1 VA: 0x2E9AC0
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>..ctor
	|
	|-RVA: 0x2E9C80 Offset: 0x2E9D81 VA: 0x2E9C80
	|-Dictionary.KeyCollection.Enumerator<object, long>..ctor
	|
	|-RVA: 0x2E9E40 Offset: 0x2E9F41 VA: 0x2E9E40
	|-Dictionary.KeyCollection.Enumerator<object, Memory<object>>..ctor
	|
	|-RVA: 0x2F35A0 Offset: 0x2F36A1 VA: 0x2F35A0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x2F3760 Offset: 0x2F3861 VA: 0x2F3760
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x2F3920 Offset: 0x2F3A21 VA: 0x2F3920
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x2F3AE0 Offset: 0x2F3BE1 VA: 0x2F3AE0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x2F3CA0 Offset: 0x2F3DA1 VA: 0x2F3CA0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x2F3E60 Offset: 0x2F3F61 VA: 0x2F3E60
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2F4020 Offset: 0x2F4121 VA: 0x2F4020
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2F41E0 Offset: 0x2F42E1 VA: 0x2F41E0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2F43A0 Offset: 0x2F44A1 VA: 0x2F43A0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x2F4560 Offset: 0x2F4661 VA: 0x2F4560
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x2F4720 Offset: 0x2F4821 VA: 0x2F4720
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2F48E0 Offset: 0x2F49E1 VA: 0x2F48E0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2F4AA0 Offset: 0x2F4BA1 VA: 0x2F4AA0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x2F4C60 Offset: 0x2F4D61 VA: 0x2F4C60
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2F4E20 Offset: 0x2F4F21 VA: 0x2F4E20
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x2F4FE0 Offset: 0x2F50E1 VA: 0x2F4FE0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2F51A0 Offset: 0x2F52A1 VA: 0x2F51A0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2F5360 Offset: 0x2F5461 VA: 0x2F5360
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2F5520 Offset: 0x2F5621 VA: 0x2F5520
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2F56E0 Offset: 0x2F57E1 VA: 0x2F56E0
	|-Dictionary.KeyCollection.Enumerator<object, object>..ctor
	|
	|-RVA: 0x2F58A0 Offset: 0x2F59A1 VA: 0x2F58A0
	|-Dictionary.KeyCollection.Enumerator<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x2F5A60 Offset: 0x2F5B61 VA: 0x2F5A60
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2F5C20 Offset: 0x2F5D21 VA: 0x2F5C20
	|-Dictionary.KeyCollection.Enumerator<object, sbyte>..ctor
	|
	|-RVA: 0x2F5DE0 Offset: 0x2F5EE1 VA: 0x2F5DE0
	|-Dictionary.KeyCollection.Enumerator<object, float>..ctor
	|
	|-RVA: 0x2F5FA0 Offset: 0x2F60A1 VA: 0x2F5FA0
	|-Dictionary.KeyCollection.Enumerator<object, ushort>..ctor
	|
	|-RVA: 0x2F6160 Offset: 0x2F6261 VA: 0x2F6160
	|-Dictionary.KeyCollection.Enumerator<object, uint>..ctor
	|
	|-RVA: 0x2F6320 Offset: 0x2F6421 VA: 0x2F6320
	|-Dictionary.KeyCollection.Enumerator<object, ulong>..ctor
	|
	|-RVA: 0x2F64E0 Offset: 0x2F65E1 VA: 0x2F64E0
	|-Dictionary.KeyCollection.Enumerator<object, TransitionTables>..ctor
	|
	|-RVA: 0x2F66A0 Offset: 0x2F67A1 VA: 0x2F66A0
	|-Dictionary.KeyCollection.Enumerator<object, Bounds>..ctor
	|
	|-RVA: 0x2F6860 Offset: 0x2F6961 VA: 0x2F6860
	|-Dictionary.KeyCollection.Enumerator<object, BoundsInt>..ctor
	|
	|-RVA: 0x2F6A20 Offset: 0x2F6B21 VA: 0x2F6A20
	|-Dictionary.KeyCollection.Enumerator<object, Color32>..ctor
	|
	|-RVA: 0x2F6BE0 Offset: 0x2F6CE1 VA: 0x2F6BE0
	|-Dictionary.KeyCollection.Enumerator<object, Color>..ctor
	|
	|-RVA: 0x2F6DA0 Offset: 0x2F6EA1 VA: 0x2F6DA0
	|-Dictionary.KeyCollection.Enumerator<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x2F6F60 Offset: 0x2F7061 VA: 0x2F6F60
	|-Dictionary.KeyCollection.Enumerator<object, GradientColorKey>..ctor
	|
	|-RVA: 0x2F7120 Offset: 0x2F7221 VA: 0x2F7120
	|-Dictionary.KeyCollection.Enumerator<object, Keyframe>..ctor
	|
	|-RVA: 0x2F72E0 Offset: 0x2F73E1 VA: 0x2F72E0
	|-Dictionary.KeyCollection.Enumerator<object, LayerMask>..ctor
	|
	|-RVA: 0x2F74A0 Offset: 0x2F75A1 VA: 0x2F74A0
	|-Dictionary.KeyCollection.Enumerator<object, Matrix4x4>..ctor
	|
	|-RVA: 0x2F7660 Offset: 0x2F7761 VA: 0x2F7660
	|-Dictionary.KeyCollection.Enumerator<object, Playable>..ctor
	|
	|-RVA: 0x2F7820 Offset: 0x2F7921 VA: 0x2F7820
	|-Dictionary.KeyCollection.Enumerator<object, Quaternion>..ctor
	|
	|-RVA: 0x2F79E0 Offset: 0x2F7AE1 VA: 0x2F79E0
	|-Dictionary.KeyCollection.Enumerator<object, RangeInt>..ctor
	|
	|-RVA: 0x2F7BA0 Offset: 0x2F7CA1 VA: 0x2F7BA0
	|-Dictionary.KeyCollection.Enumerator<object, Rect>..ctor
	|
	|-RVA: 0x2F7D60 Offset: 0x2F7E61 VA: 0x2F7D60
	|-Dictionary.KeyCollection.Enumerator<object, RectInt>..ctor
	|
	|-RVA: 0x2F7F20 Offset: 0x2F8021 VA: 0x2F7F20
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2F80E0 Offset: 0x2F81E1 VA: 0x2F80E0
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2F82A0 Offset: 0x2F83A1 VA: 0x2F82A0
	|-Dictionary.KeyCollection.Enumerator<object, Vector2>..ctor
	|
	|-RVA: 0x2F8460 Offset: 0x2F8561 VA: 0x2F8460
	|-Dictionary.KeyCollection.Enumerator<object, Vector2Int>..ctor
	|
	|-RVA: 0x2F8620 Offset: 0x2F8721 VA: 0x2F8620
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>..ctor
	|
	|-RVA: 0x2F87E0 Offset: 0x2F88E1 VA: 0x2F87E0
	|-Dictionary.KeyCollection.Enumerator<object, Vector3Int>..ctor
	|
	|-RVA: 0x2F89A0 Offset: 0x2F8AA1 VA: 0x2F89A0
	|-Dictionary.KeyCollection.Enumerator<object, Vector4>..ctor
	|
	|-RVA: 0x2F8B60 Offset: 0x2F8C61 VA: 0x2F8B60
	|-Dictionary.KeyCollection.Enumerator<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x2F8C80 Offset: 0x2F8D81 VA: 0x2F8C80
	|-Dictionary.KeyCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2F8DA0 Offset: 0x2F8EA1 VA: 0x2F8DA0
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>..ctor
	|
	|-RVA: 0x2F8EC0 Offset: 0x2F8FC1 VA: 0x2F8EC0
	|-Dictionary.KeyCollection.Enumerator<float, CurveSample>..ctor
	|
	|-RVA: 0x2F8FE0 Offset: 0x2F90E1 VA: 0x2F8FE0
	|-Dictionary.KeyCollection.Enumerator<float, object>..ctor
	|
	|-RVA: 0x2F9100 Offset: 0x2F9201 VA: 0x2F9100
	|-Dictionary.KeyCollection.Enumerator<ushort, object>..ctor
	|
	|-RVA: 0x2F9220 Offset: 0x2F9321 VA: 0x2F9220
	|-Dictionary.KeyCollection.Enumerator<uint, int>..ctor
	|
	|-RVA: 0x2F9340 Offset: 0x2F9441 VA: 0x2F9340
	|-Dictionary.KeyCollection.Enumerator<uint, Int32Enum>..ctor
	|
	|-RVA: 0x2F9460 Offset: 0x2F9561 VA: 0x2F9460
	|-Dictionary.KeyCollection.Enumerator<uint, object>..ctor
	|
	|-RVA: 0x2F9580 Offset: 0x2F9681 VA: 0x2F9580
	|-Dictionary.KeyCollection.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x2F96A0 Offset: 0x2F97A1 VA: 0x2F96A0
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x2F97C0 Offset: 0x2F98C1 VA: 0x2F97C0
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x2F98E0 Offset: 0x2F99E1 VA: 0x2F98E0
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x2F9A00 Offset: 0x2F9B01 VA: 0x2F9A00
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x2F9B20 Offset: 0x2F9C21 VA: 0x2F9B20
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x2F9C40 Offset: 0x2F9D41 VA: 0x2F9C40
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x2F9D60 Offset: 0x2F9E61 VA: 0x2F9D60
	|-Dictionary.KeyCollection.Enumerator<Bounds, object>..ctor
	|
	|-RVA: 0x2F9EA0 Offset: 0x2F9FA1 VA: 0x2F9EA0
	|-Dictionary.KeyCollection.Enumerator<BoundsInt, object>..ctor
	|
	|-RVA: 0x2F9FE0 Offset: 0x2FA0E1 VA: 0x2F9FE0
	|-Dictionary.KeyCollection.Enumerator<Color, object>..ctor
	|
	|-RVA: 0x2FA100 Offset: 0x2FA201 VA: 0x2FA100
	|-Dictionary.KeyCollection.Enumerator<Color32, object>..ctor
	|
	|-RVA: 0x2FA220 Offset: 0x2FA321 VA: 0x2FA220
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x2FA340 Offset: 0x2FA441 VA: 0x2FA340
	|-Dictionary.KeyCollection.Enumerator<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x2FA460 Offset: 0x2FA561 VA: 0x2FA460
	|-Dictionary.KeyCollection.Enumerator<GradientColorKey, object>..ctor
	|
	|-RVA: 0x2FA5A0 Offset: 0x2FA6A1 VA: 0x2FA5A0
	|-Dictionary.KeyCollection.Enumerator<Keyframe, object>..ctor
	|
	|-RVA: 0x2FA6F0 Offset: 0x2FA7F1 VA: 0x2FA6F0
	|-Dictionary.KeyCollection.Enumerator<LayerMask, object>..ctor
	|
	|-RVA: 0x2FA810 Offset: 0x2FA911 VA: 0x2FA810
	|-Dictionary.KeyCollection.Enumerator<Matrix4x4, object>..ctor
	|
	|-RVA: 0x2FA970 Offset: 0x2FAA71 VA: 0x2FA970
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>..ctor
	|
	|-RVA: 0x2FAAA0 Offset: 0x2FABA1 VA: 0x2FAAA0
	|-Dictionary.KeyCollection.Enumerator<Quaternion, object>..ctor
	|
	|-RVA: 0x2FABC0 Offset: 0x2FACC1 VA: 0x2FABC0
	|-Dictionary.KeyCollection.Enumerator<RangeInt, object>..ctor
	|
	|-RVA: 0x2FACE0 Offset: 0x2FADE1 VA: 0x2FACE0
	|-Dictionary.KeyCollection.Enumerator<Rect, object>..ctor
	|
	|-RVA: 0x2FAE00 Offset: 0x2FAF01 VA: 0x2FAE00
	|-Dictionary.KeyCollection.Enumerator<RectInt, object>..ctor
	|
	|-RVA: 0x2FAF20 Offset: 0x2FB021 VA: 0x2FAF20
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x2FB040 Offset: 0x2FB141 VA: 0x2FB040
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x2FB160 Offset: 0x2FB261 VA: 0x2FB160
	|-Dictionary.KeyCollection.Enumerator<Vector2, object>..ctor
	|
	|-RVA: 0x2FB280 Offset: 0x2FB381 VA: 0x2FB280
	|-Dictionary.KeyCollection.Enumerator<Vector2Int, object>..ctor
	|
	|-RVA: 0x2FB3A0 Offset: 0x2FB4A1 VA: 0x2FB3A0
	|-Dictionary.KeyCollection.Enumerator<Vector3, object>..ctor
	|
	|-RVA: 0x36C440 Offset: 0x36C541 VA: 0x36C440
	|-Dictionary.KeyCollection.Enumerator<Vector3Int, object>..ctor
	|
	|-RVA: 0x36C570 Offset: 0x36C671 VA: 0x36C570
	|-Dictionary.KeyCollection.Enumerator<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x338850 Offset: 0x338951 VA: 0x338850
	|-Dictionary.KeyCollection.Enumerator<JSONDeserialization.TaskField, List<int>>.Dispose
	|-Dictionary.KeyCollection.Enumerator<JSONDeserialization.TaskField, object>.Dispose
	|
	|-RVA: 0x2F5720 Offset: 0x2F5821 VA: 0x2F5720
	|-Dictionary.KeyCollection.Enumerator<BinaryDeserialization.ObjectFieldMap, List<int>>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Character, AvoidController>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Character, YawnController>.Dispose
	|-Dictionary.KeyCollection.Enumerator<CharacterBase, MagicController>.Dispose
	|-Dictionary.KeyCollection.Enumerator<CharacterBase, ThrottleController>.Dispose
	|-Dictionary.KeyCollection.Enumerator<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ParameterExpression, LocalVariable>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, BoolKeyframeGroup>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, ColorKeyframeGroup>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, IKeyframeGroup>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, NumberKeyframeGroup>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, SpherePointKeyframeGroup>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, TextureKeyframeGroup>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Collider, CharacterBase>.Dispose
	|
	|-RVA: 0x338970 Offset: 0x338A71 VA: 0x338970
	|-Dictionary.KeyCollection.Enumerator<BitVector32Int, object>.Dispose
	|
	|-RVA: 0x2F5E20 Offset: 0x2F5F21 VA: 0x2F5E20
	|-Dictionary.KeyCollection.Enumerator<Character, float>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, float>.Dispose
	|
	|-RVA: 0x2E5AB0 Offset: 0x2E5BB1 VA: 0x2E5AB0
	|-Dictionary.KeyCollection.Enumerator<ActorID, GrappleController>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ActorID, HandCuffsController>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ActorID, HumanStatusData>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ActorID, ItemStorageData>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ActorID, MobTravelerController>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ActorID, Dictionary<EquipSlotType, HumanEquipItem>>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x338A90 Offset: 0x338B91 VA: 0x338A90
	|-Dictionary.KeyCollection.Enumerator<EventCheckId, object>.Dispose
	|
	|-RVA: 0x338BE0 Offset: 0x338CE1 VA: 0x338BE0
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.Dispose
	|
	|-RVA: 0x2E2FF0 Offset: 0x2E30F1 VA: 0x2E2FF0
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.Dispose
	|
	|-RVA: 0x2E3130 Offset: 0x2E3231 VA: 0x2E3130
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.Dispose
	|
	|-RVA: 0x2E3260 Offset: 0x2E3361 VA: 0x2E3260
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.Dispose
	|
	|-RVA: 0x2E3390 Offset: 0x2E3491 VA: 0x2E3390
	|-Dictionary.KeyCollection.Enumerator<MonsterHutSaveData, object>.Dispose
	|
	|-RVA: 0x2E34D0 Offset: 0x2E35D1 VA: 0x2E34D0
	|-Dictionary.KeyCollection.Enumerator<OrderLotterySaveParameter, object>.Dispose
	|
	|-RVA: 0x2E3610 Offset: 0x2E3711 VA: 0x2E3610
	|-Dictionary.KeyCollection.Enumerator<OrderSaveData, object>.Dispose
	|
	|-RVA: 0x2E3750 Offset: 0x2E3851 VA: 0x2E3750
	|-Dictionary.KeyCollection.Enumerator<OrderSaveParameter, object>.Dispose
	|
	|-RVA: 0x2E38C0 Offset: 0x2E39C1 VA: 0x2E38C0
	|-Dictionary.KeyCollection.Enumerator<Parameter, object>.Dispose
	|
	|-RVA: 0x2E5870 Offset: 0x2E5971 VA: 0x2E5870
	|-Dictionary.KeyCollection.Enumerator<RF5SystemData.FLAG, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x2E3A10 Offset: 0x2E3B11 VA: 0x2E3A10
	|-Dictionary.KeyCollection.Enumerator<bool, object>.Dispose
	|
	|-RVA: 0x2E3B30 Offset: 0x2E3C31 VA: 0x2E3B30
	|-Dictionary.KeyCollection.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x2E3C50 Offset: 0x2E3D51 VA: 0x2E3C50
	|-Dictionary.KeyCollection.Enumerator<char, object>.Dispose
	|
	|-RVA: 0x2E3D70 Offset: 0x2E3E71 VA: 0x2E3D70
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.Dispose
	|
	|-RVA: 0x2E3E90 Offset: 0x2E3F91 VA: 0x2E3E90
	|-Dictionary.KeyCollection.Enumerator<double, object>.Dispose
	|
	|-RVA: 0x2E3FB0 Offset: 0x2E40B1 VA: 0x2E3FB0
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.Dispose
	|
	|-RVA: 0x2E40D0 Offset: 0x2E41D1 VA: 0x2E40D0
	|-Dictionary.KeyCollection.Enumerator<short, object>.Dispose
	|
	|-RVA: 0x2E41F0 Offset: 0x2E42F1 VA: 0x2E41F0
	|-Dictionary.KeyCollection.Enumerator<int, CropDataTable>.Dispose
	|
	|-RVA: 0x2E4310 Offset: 0x2E4411 VA: 0x2E4310
	|-Dictionary.KeyCollection.Enumerator<int, EffectDataTable>.Dispose
	|
	|-RVA: 0x2E4430 Offset: 0x2E4531 VA: 0x2E4430
	|-Dictionary.KeyCollection.Enumerator<int, GimmickLayoutDataTable>.Dispose
	|
	|-RVA: 0x2E4550 Offset: 0x2E4651 VA: 0x2E4550
	|-Dictionary.KeyCollection.Enumerator<int, MineTypeDataTable>.Dispose
	|
	|-RVA: 0x2E4670 Offset: 0x2E4771 VA: 0x2E4670
	|-Dictionary.KeyCollection.Enumerator<int, MiningDataTable>.Dispose
	|
	|-RVA: 0x2E4790 Offset: 0x2E4891 VA: 0x2E4790
	|-Dictionary.KeyCollection.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x2E48B0 Offset: 0x2E49B1 VA: 0x2E48B0
	|-Dictionary.KeyCollection.Enumerator<int, char>.Dispose
	|
	|-RVA: 0x2E4D30 Offset: 0x2E4E31 VA: 0x2E4D30
	|-Dictionary.KeyCollection.Enumerator<int, Dictionary<int, List<OrderMasterData>>>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, List<MeshDataConnectivity.Face>>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, object>.Dispose
	|
	|-RVA: 0x2E49D0 Offset: 0x2E4AD1 VA: 0x2E49D0
	|-Dictionary.KeyCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x2E4AF0 Offset: 0x2E4BF1 VA: 0x2E4AF0
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x2E4C10 Offset: 0x2E4D11 VA: 0x2E4C10
	|-Dictionary.KeyCollection.Enumerator<int, long>.Dispose
	|
	|-RVA: 0x2E4E50 Offset: 0x2E4F51 VA: 0x2E4E50
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.Dispose
	|
	|-RVA: 0x2E4F70 Offset: 0x2E5071 VA: 0x2E4F70
	|-Dictionary.KeyCollection.Enumerator<int, SceneInstance>.Dispose
	|
	|-RVA: 0x2E5090 Offset: 0x2E5191 VA: 0x2E5090
	|-Dictionary.KeyCollection.Enumerator<int, Vector2Int>.Dispose
	|
	|-RVA: 0x2E51B0 Offset: 0x2E52B1 VA: 0x2E51B0
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.Dispose
	|
	|-RVA: 0x2E52D0 Offset: 0x2E53D1 VA: 0x2E52D0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterDataTable>.Dispose
	|
	|-RVA: 0x2E53F0 Offset: 0x2E54F1 VA: 0x2E53F0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.Dispose
	|
	|-RVA: 0x2E5510 Offset: 0x2E5611 VA: 0x2E5510
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.Dispose
	|
	|-RVA: 0x2E5630 Offset: 0x2E5731 VA: 0x2E5630
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x2E5750 Offset: 0x2E5851 VA: 0x2E5750
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2E5990 Offset: 0x2E5A91 VA: 0x2E5990
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x2E5BD0 Offset: 0x2E5CD1 VA: 0x2E5BD0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x2E5CF0 Offset: 0x2E5DF1 VA: 0x2E5CF0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x2E5E10 Offset: 0x2E5F11 VA: 0x2E5E10
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.Dispose
	|
	|-RVA: 0x2E5F30 Offset: 0x2E6031 VA: 0x2E5F30
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.Dispose
	|
	|-RVA: 0x2E6050 Offset: 0x2E6151 VA: 0x2E6050
	|-Dictionary.KeyCollection.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x2E6170 Offset: 0x2E6271 VA: 0x2E6170
	|-Dictionary.KeyCollection.Enumerator<Memory<object>, object>.Dispose
	|
	|-RVA: 0x2E6290 Offset: 0x2E6391 VA: 0x2E6290
	|-Dictionary.KeyCollection.Enumerator<Nullable<Int32Enum>, object>.Dispose
	|
	|-RVA: 0x2E63C0 Offset: 0x2E64C1 VA: 0x2E63C0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Bounds>, object>.Dispose
	|
	|-RVA: 0x2E6510 Offset: 0x2E6611 VA: 0x2E6510
	|-Dictionary.KeyCollection.Enumerator<Nullable<BoundsInt>, object>.Dispose
	|
	|-RVA: 0x2E6650 Offset: 0x2E6751 VA: 0x2E6650
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color32>, object>.Dispose
	|
	|-RVA: 0x2E6770 Offset: 0x2E6871 VA: 0x2E6770
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color>, object>.Dispose
	|
	|-RVA: 0x2E68B0 Offset: 0x2E69B1 VA: 0x2E68B0
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientAlphaKey>, object>.Dispose
	|
	|-RVA: 0x2E69E0 Offset: 0x2E6AE1 VA: 0x2E69E0
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientColorKey>, object>.Dispose
	|
	|-RVA: 0x2E6B20 Offset: 0x2E6C21 VA: 0x2E6B20
	|-Dictionary.KeyCollection.Enumerator<Nullable<Keyframe>, object>.Dispose
	|
	|-RVA: 0x2E6C60 Offset: 0x2E6D61 VA: 0x2E6C60
	|-Dictionary.KeyCollection.Enumerator<Nullable<LayerMask>, object>.Dispose
	|
	|-RVA: 0x2E6D90 Offset: 0x2E6E91 VA: 0x2E6D90
	|-Dictionary.KeyCollection.Enumerator<Nullable<Matrix4x4>, object>.Dispose
	|
	|-RVA: 0x2E6EF0 Offset: 0x2E6FF1 VA: 0x2E6EF0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Quaternion>, object>.Dispose
	|
	|-RVA: 0x2E7030 Offset: 0x2E7131 VA: 0x2E7030
	|-Dictionary.KeyCollection.Enumerator<Nullable<RangeInt>, object>.Dispose
	|
	|-RVA: 0x2E7160 Offset: 0x2E7261 VA: 0x2E7160
	|-Dictionary.KeyCollection.Enumerator<Nullable<Rect>, object>.Dispose
	|
	|-RVA: 0x2E72A0 Offset: 0x2E73A1 VA: 0x2E72A0
	|-Dictionary.KeyCollection.Enumerator<Nullable<RectInt>, object>.Dispose
	|
	|-RVA: 0x2E73E0 Offset: 0x2E74E1 VA: 0x2E73E0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2>, object>.Dispose
	|
	|-RVA: 0x2E7510 Offset: 0x2E7611 VA: 0x2E7510
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2Int>, object>.Dispose
	|
	|-RVA: 0x2E7640 Offset: 0x2E7741 VA: 0x2E7640
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3>, object>.Dispose
	|
	|-RVA: 0x2E7760 Offset: 0x2E7861 VA: 0x2E7760
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3Int>, object>.Dispose
	|
	|-RVA: 0x2E7880 Offset: 0x2E7981 VA: 0x2E7880
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector4>, object>.Dispose
	|
	|-RVA: 0x2E79C0 Offset: 0x2E7AC1 VA: 0x2E79C0
	|-Dictionary.KeyCollection.Enumerator<object, BitVector32Int>.Dispose
	|
	|-RVA: 0x2E7B80 Offset: 0x2E7C81 VA: 0x2E7B80
	|-Dictionary.KeyCollection.Enumerator<object, EventCheckId>.Dispose
	|
	|-RVA: 0x2E7D40 Offset: 0x2E7E41 VA: 0x2E7D40
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.Dispose
	|
	|-RVA: 0x2E7F00 Offset: 0x2E8001 VA: 0x2E7F00
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.Dispose
	|
	|-RVA: 0x2E80C0 Offset: 0x2E81C1 VA: 0x2E80C0
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.Dispose
	|
	|-RVA: 0x2E8280 Offset: 0x2E8381 VA: 0x2E8280
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.Dispose
	|
	|-RVA: 0x2E8440 Offset: 0x2E8541 VA: 0x2E8440
	|-Dictionary.KeyCollection.Enumerator<object, MonsterHutSaveData>.Dispose
	|
	|-RVA: 0x2E8600 Offset: 0x2E8701 VA: 0x2E8600
	|-Dictionary.KeyCollection.Enumerator<object, OrderLotterySaveParameter>.Dispose
	|
	|-RVA: 0x2E87C0 Offset: 0x2E88C1 VA: 0x2E87C0
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveData>.Dispose
	|
	|-RVA: 0x2E8980 Offset: 0x2E8A81 VA: 0x2E8980
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveParameter>.Dispose
	|
	|-RVA: 0x2E8B40 Offset: 0x2E8C41 VA: 0x2E8B40
	|-Dictionary.KeyCollection.Enumerator<object, Parameter>.Dispose
	|
	|-RVA: 0x2E8D00 Offset: 0x2E8E01 VA: 0x2E8D00
	|-Dictionary.KeyCollection.Enumerator<object, NumberControl.ValueRange>.Dispose
	|
	|-RVA: 0x2E8EC0 Offset: 0x2E8FC1 VA: 0x2E8EC0
	|-Dictionary.KeyCollection.Enumerator<object, bool>.Dispose
	|
	|-RVA: 0x2E9080 Offset: 0x2E9181 VA: 0x2E9080
	|-Dictionary.KeyCollection.Enumerator<object, byte>.Dispose
	|
	|-RVA: 0x2E9240 Offset: 0x2E9341 VA: 0x2E9240
	|-Dictionary.KeyCollection.Enumerator<object, char>.Dispose
	|
	|-RVA: 0x2E9400 Offset: 0x2E9501 VA: 0x2E9400
	|-Dictionary.KeyCollection.Enumerator<object, DateTime>.Dispose
	|
	|-RVA: 0x2E95C0 Offset: 0x2E96C1 VA: 0x2E95C0
	|-Dictionary.KeyCollection.Enumerator<object, double>.Dispose
	|
	|-RVA: 0x2E9780 Offset: 0x2E9881 VA: 0x2E9780
	|-Dictionary.KeyCollection.Enumerator<object, short>.Dispose
	|
	|-RVA: 0x2E9940 Offset: 0x2E9A41 VA: 0x2E9940
	|-Dictionary.KeyCollection.Enumerator<object, int>.Dispose
	|
	|-RVA: 0x2E9B00 Offset: 0x2E9C01 VA: 0x2E9B00
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, SystemLanguage>.Dispose
	|
	|-RVA: 0x2E9CC0 Offset: 0x2E9DC1 VA: 0x2E9CC0
	|-Dictionary.KeyCollection.Enumerator<object, long>.Dispose
	|
	|-RVA: 0x2E9E80 Offset: 0x2E9F81 VA: 0x2E9E80
	|-Dictionary.KeyCollection.Enumerator<object, Memory<object>>.Dispose
	|
	|-RVA: 0x2F35E0 Offset: 0x2F36E1 VA: 0x2F35E0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Int32Enum>>.Dispose
	|
	|-RVA: 0x2F37A0 Offset: 0x2F38A1 VA: 0x2F37A0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Bounds>>.Dispose
	|
	|-RVA: 0x2F3960 Offset: 0x2F3A61 VA: 0x2F3960
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<BoundsInt>>.Dispose
	|
	|-RVA: 0x2F3B20 Offset: 0x2F3C21 VA: 0x2F3B20
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color32>>.Dispose
	|
	|-RVA: 0x2F3CE0 Offset: 0x2F3DE1 VA: 0x2F3CE0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color>>.Dispose
	|
	|-RVA: 0x2F3EA0 Offset: 0x2F3FA1 VA: 0x2F3EA0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x2F4060 Offset: 0x2F4161 VA: 0x2F4060
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientColorKey>>.Dispose
	|
	|-RVA: 0x2F4220 Offset: 0x2F4321 VA: 0x2F4220
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Keyframe>>.Dispose
	|
	|-RVA: 0x2F43E0 Offset: 0x2F44E1 VA: 0x2F43E0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<LayerMask>>.Dispose
	|
	|-RVA: 0x2F45A0 Offset: 0x2F46A1 VA: 0x2F45A0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Matrix4x4>>.Dispose
	|
	|-RVA: 0x2F4760 Offset: 0x2F4861 VA: 0x2F4760
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Quaternion>>.Dispose
	|
	|-RVA: 0x2F4920 Offset: 0x2F4A21 VA: 0x2F4920
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RangeInt>>.Dispose
	|
	|-RVA: 0x2F4AE0 Offset: 0x2F4BE1 VA: 0x2F4AE0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Rect>>.Dispose
	|
	|-RVA: 0x2F4CA0 Offset: 0x2F4DA1 VA: 0x2F4CA0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RectInt>>.Dispose
	|
	|-RVA: 0x2F4E60 Offset: 0x2F4F61 VA: 0x2F4E60
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2>>.Dispose
	|
	|-RVA: 0x2F5020 Offset: 0x2F5121 VA: 0x2F5020
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2Int>>.Dispose
	|
	|-RVA: 0x2F51E0 Offset: 0x2F52E1 VA: 0x2F51E0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3>>.Dispose
	|
	|-RVA: 0x2F53A0 Offset: 0x2F54A1 VA: 0x2F53A0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3Int>>.Dispose
	|
	|-RVA: 0x2F5560 Offset: 0x2F5661 VA: 0x2F5560
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector4>>.Dispose
	|
	|-RVA: 0x2F58E0 Offset: 0x2F59E1 VA: 0x2F58E0
	|-Dictionary.KeyCollection.Enumerator<object, ReadOnlyMemory<object>>.Dispose
	|
	|-RVA: 0x2F5AA0 Offset: 0x2F5BA1 VA: 0x2F5AA0
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.Dispose
	|
	|-RVA: 0x2F5C60 Offset: 0x2F5D61 VA: 0x2F5C60
	|-Dictionary.KeyCollection.Enumerator<object, sbyte>.Dispose
	|
	|-RVA: 0x2F5FE0 Offset: 0x2F60E1 VA: 0x2F5FE0
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.Dispose
	|
	|-RVA: 0x2F61A0 Offset: 0x2F62A1 VA: 0x2F61A0
	|-Dictionary.KeyCollection.Enumerator<object, uint>.Dispose
	|
	|-RVA: 0x2F6360 Offset: 0x2F6461 VA: 0x2F6360
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.Dispose
	|
	|-RVA: 0x2F6520 Offset: 0x2F6621 VA: 0x2F6520
	|-Dictionary.KeyCollection.Enumerator<object, TransitionTables>.Dispose
	|
	|-RVA: 0x2F66E0 Offset: 0x2F67E1 VA: 0x2F66E0
	|-Dictionary.KeyCollection.Enumerator<object, Bounds>.Dispose
	|
	|-RVA: 0x2F68A0 Offset: 0x2F69A1 VA: 0x2F68A0
	|-Dictionary.KeyCollection.Enumerator<object, BoundsInt>.Dispose
	|
	|-RVA: 0x2F6A60 Offset: 0x2F6B61 VA: 0x2F6A60
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.Dispose
	|
	|-RVA: 0x2F6C20 Offset: 0x2F6D21 VA: 0x2F6C20
	|-Dictionary.KeyCollection.Enumerator<object, Color>.Dispose
	|
	|-RVA: 0x2F6DE0 Offset: 0x2F6EE1 VA: 0x2F6DE0
	|-Dictionary.KeyCollection.Enumerator<object, GradientAlphaKey>.Dispose
	|
	|-RVA: 0x2F6FA0 Offset: 0x2F70A1 VA: 0x2F6FA0
	|-Dictionary.KeyCollection.Enumerator<object, GradientColorKey>.Dispose
	|
	|-RVA: 0x2F7160 Offset: 0x2F7261 VA: 0x2F7160
	|-Dictionary.KeyCollection.Enumerator<object, Keyframe>.Dispose
	|
	|-RVA: 0x2F7320 Offset: 0x2F7421 VA: 0x2F7320
	|-Dictionary.KeyCollection.Enumerator<object, LayerMask>.Dispose
	|
	|-RVA: 0x2F74E0 Offset: 0x2F75E1 VA: 0x2F74E0
	|-Dictionary.KeyCollection.Enumerator<object, Matrix4x4>.Dispose
	|
	|-RVA: 0x2F76A0 Offset: 0x2F77A1 VA: 0x2F76A0
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.Dispose
	|
	|-RVA: 0x2F7860 Offset: 0x2F7961 VA: 0x2F7860
	|-Dictionary.KeyCollection.Enumerator<object, Quaternion>.Dispose
	|
	|-RVA: 0x2F7A20 Offset: 0x2F7B21 VA: 0x2F7A20
	|-Dictionary.KeyCollection.Enumerator<object, RangeInt>.Dispose
	|
	|-RVA: 0x2F7BE0 Offset: 0x2F7CE1 VA: 0x2F7BE0
	|-Dictionary.KeyCollection.Enumerator<object, Rect>.Dispose
	|
	|-RVA: 0x2F7DA0 Offset: 0x2F7EA1 VA: 0x2F7DA0
	|-Dictionary.KeyCollection.Enumerator<object, RectInt>.Dispose
	|
	|-RVA: 0x2F7F60 Offset: 0x2F8061 VA: 0x2F7F60
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x2F8120 Offset: 0x2F8221 VA: 0x2F8120
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x2F82E0 Offset: 0x2F83E1 VA: 0x2F82E0
	|-Dictionary.KeyCollection.Enumerator<object, Vector2>.Dispose
	|
	|-RVA: 0x2F84A0 Offset: 0x2F85A1 VA: 0x2F84A0
	|-Dictionary.KeyCollection.Enumerator<object, Vector2Int>.Dispose
	|
	|-RVA: 0x2F8660 Offset: 0x2F8761 VA: 0x2F8660
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.Dispose
	|
	|-RVA: 0x2F8820 Offset: 0x2F8921 VA: 0x2F8820
	|-Dictionary.KeyCollection.Enumerator<object, Vector3Int>.Dispose
	|
	|-RVA: 0x2F89E0 Offset: 0x2F8AE1 VA: 0x2F89E0
	|-Dictionary.KeyCollection.Enumerator<object, Vector4>.Dispose
	|
	|-RVA: 0x2F8BA0 Offset: 0x2F8CA1 VA: 0x2F8BA0
	|-Dictionary.KeyCollection.Enumerator<ReadOnlyMemory<object>, object>.Dispose
	|
	|-RVA: 0x2F8CC0 Offset: 0x2F8DC1 VA: 0x2F8CC0
	|-Dictionary.KeyCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.Dispose
	|
	|-RVA: 0x2F8DE0 Offset: 0x2F8EE1 VA: 0x2F8DE0
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.Dispose
	|
	|-RVA: 0x2F8F00 Offset: 0x2F9001 VA: 0x2F8F00
	|-Dictionary.KeyCollection.Enumerator<float, CurveSample>.Dispose
	|
	|-RVA: 0x2F9020 Offset: 0x2F9121 VA: 0x2F9020
	|-Dictionary.KeyCollection.Enumerator<float, object>.Dispose
	|
	|-RVA: 0x2F9140 Offset: 0x2F9241 VA: 0x2F9140
	|-Dictionary.KeyCollection.Enumerator<ushort, object>.Dispose
	|
	|-RVA: 0x2F94A0 Offset: 0x2F95A1 VA: 0x2F94A0
	|-Dictionary.KeyCollection.Enumerator<uint, FriendMonsterStatus>.Dispose
	|-Dictionary.KeyCollection.Enumerator<uint, object>.Dispose
	|
	|-RVA: 0x2F9260 Offset: 0x2F9361 VA: 0x2F9260
	|-Dictionary.KeyCollection.Enumerator<uint, int>.Dispose
	|
	|-RVA: 0x2F9380 Offset: 0x2F9481 VA: 0x2F9380
	|-Dictionary.KeyCollection.Enumerator<uint, Int32Enum>.Dispose
	|
	|-RVA: 0x2F95C0 Offset: 0x2F96C1 VA: 0x2F95C0
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.Dispose
	|
	|-RVA: 0x2F96E0 Offset: 0x2F97E1 VA: 0x2F96E0
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, int>.Dispose
	|
	|-RVA: 0x2F9800 Offset: 0x2F9901 VA: 0x2F9800
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, CapEdge>.Dispose
	|
	|-RVA: 0x2F9920 Offset: 0x2F9A21 VA: 0x2F9920
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.Dispose
	|
	|-RVA: 0x2F9A40 Offset: 0x2F9B41 VA: 0x2F9A40
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.Dispose
	|
	|-RVA: 0x2F9B60 Offset: 0x2F9C61 VA: 0x2F9B60
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, bool>.Dispose
	|
	|-RVA: 0x2F9C80 Offset: 0x2F9D81 VA: 0x2F9C80
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, object>.Dispose
	|
	|-RVA: 0x2F9DA0 Offset: 0x2F9EA1 VA: 0x2F9DA0
	|-Dictionary.KeyCollection.Enumerator<Bounds, object>.Dispose
	|
	|-RVA: 0x2F9EE0 Offset: 0x2F9FE1 VA: 0x2F9EE0
	|-Dictionary.KeyCollection.Enumerator<BoundsInt, object>.Dispose
	|
	|-RVA: 0x2FA020 Offset: 0x2FA121 VA: 0x2FA020
	|-Dictionary.KeyCollection.Enumerator<Color, object>.Dispose
	|
	|-RVA: 0x2FA140 Offset: 0x2FA241 VA: 0x2FA140
	|-Dictionary.KeyCollection.Enumerator<Color32, object>.Dispose
	|
	|-RVA: 0x2FA260 Offset: 0x2FA361 VA: 0x2FA260
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.Dispose
	|
	|-RVA: 0x2FA380 Offset: 0x2FA481 VA: 0x2FA380
	|-Dictionary.KeyCollection.Enumerator<GradientAlphaKey, object>.Dispose
	|
	|-RVA: 0x2FA4A0 Offset: 0x2FA5A1 VA: 0x2FA4A0
	|-Dictionary.KeyCollection.Enumerator<GradientColorKey, object>.Dispose
	|
	|-RVA: 0x2FA5F0 Offset: 0x2FA6F1 VA: 0x2FA5F0
	|-Dictionary.KeyCollection.Enumerator<Keyframe, object>.Dispose
	|
	|-RVA: 0x2FA730 Offset: 0x2FA831 VA: 0x2FA730
	|-Dictionary.KeyCollection.Enumerator<LayerMask, object>.Dispose
	|
	|-RVA: 0x2FA860 Offset: 0x2FA961 VA: 0x2FA860
	|-Dictionary.KeyCollection.Enumerator<Matrix4x4, object>.Dispose
	|
	|-RVA: 0x2FA9B0 Offset: 0x2FAAB1 VA: 0x2FA9B0
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.Dispose
	|
	|-RVA: 0x2FAAE0 Offset: 0x2FABE1 VA: 0x2FAAE0
	|-Dictionary.KeyCollection.Enumerator<Quaternion, object>.Dispose
	|
	|-RVA: 0x2FAC00 Offset: 0x2FAD01 VA: 0x2FAC00
	|-Dictionary.KeyCollection.Enumerator<RangeInt, object>.Dispose
	|
	|-RVA: 0x2FAD20 Offset: 0x2FAE21 VA: 0x2FAD20
	|-Dictionary.KeyCollection.Enumerator<Rect, object>.Dispose
	|
	|-RVA: 0x2FAE40 Offset: 0x2FAF41 VA: 0x2FAE40
	|-Dictionary.KeyCollection.Enumerator<RectInt, object>.Dispose
	|
	|-RVA: 0x2FAF60 Offset: 0x2FB061 VA: 0x2FAF60
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.Dispose
	|
	|-RVA: 0x2FB080 Offset: 0x2FB181 VA: 0x2FB080
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.Dispose
	|
	|-RVA: 0x2FB1A0 Offset: 0x2FB2A1 VA: 0x2FB1A0
	|-Dictionary.KeyCollection.Enumerator<Vector2, object>.Dispose
	|
	|-RVA: 0x2FB2C0 Offset: 0x2FB3C1 VA: 0x2FB2C0
	|-Dictionary.KeyCollection.Enumerator<Vector2Int, object>.Dispose
	|
	|-RVA: 0x2FB3E0 Offset: 0x2FB4E1 VA: 0x2FB3E0
	|-Dictionary.KeyCollection.Enumerator<Vector3, object>.Dispose
	|
	|-RVA: 0x36C480 Offset: 0x36C581 VA: 0x36C480
	|-Dictionary.KeyCollection.Enumerator<Vector3Int, object>.Dispose
	|
	|-RVA: 0x36C5B0 Offset: 0x36C6B1 VA: 0x36C5B0
	|-Dictionary.KeyCollection.Enumerator<Vector4, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x338860 Offset: 0x338961 VA: 0x338860
	|-Dictionary.KeyCollection.Enumerator<JSONDeserialization.TaskField, List<int>>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<JSONDeserialization.TaskField, object>.MoveNext
	|
	|-RVA: 0x2F5730 Offset: 0x2F5831 VA: 0x2F5730
	|-Dictionary.KeyCollection.Enumerator<BinaryDeserialization.ObjectFieldMap, List<int>>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Character, AvoidController>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Character, YawnController>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<CharacterBase, MagicController>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<CharacterBase, ThrottleController>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ParameterExpression, LocalVariable>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, BoolKeyframeGroup>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, ColorKeyframeGroup>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, IKeyframeGroup>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, NumberKeyframeGroup>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, SpherePointKeyframeGroup>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, TextureKeyframeGroup>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Collider, CharacterBase>.MoveNext
	|
	|-RVA: 0x338980 Offset: 0x338A81 VA: 0x338980
	|-Dictionary.KeyCollection.Enumerator<BitVector32Int, object>.MoveNext
	|
	|-RVA: 0x2F5E30 Offset: 0x2F5F31 VA: 0x2F5E30
	|-Dictionary.KeyCollection.Enumerator<Character, float>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x2E5AC0 Offset: 0x2E5BC1 VA: 0x2E5AC0
	|-Dictionary.KeyCollection.Enumerator<ActorID, GrappleController>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ActorID, HandCuffsController>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ActorID, HumanStatusData>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ActorID, ItemStorageData>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ActorID, MobTravelerController>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ActorID, Dictionary<EquipSlotType, HumanEquipItem>>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x338AA0 Offset: 0x338BA1 VA: 0x338AA0
	|-Dictionary.KeyCollection.Enumerator<EventCheckId, object>.MoveNext
	|
	|-RVA: 0x338BF0 Offset: 0x338CF1 VA: 0x338BF0
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.MoveNext
	|
	|-RVA: 0x2E3000 Offset: 0x2E3101 VA: 0x2E3000
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.MoveNext
	|
	|-RVA: 0x2E3140 Offset: 0x2E3241 VA: 0x2E3140
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.MoveNext
	|
	|-RVA: 0x2E3270 Offset: 0x2E3371 VA: 0x2E3270
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.MoveNext
	|
	|-RVA: 0x2E33A0 Offset: 0x2E34A1 VA: 0x2E33A0
	|-Dictionary.KeyCollection.Enumerator<MonsterHutSaveData, object>.MoveNext
	|
	|-RVA: 0x2E34E0 Offset: 0x2E35E1 VA: 0x2E34E0
	|-Dictionary.KeyCollection.Enumerator<OrderLotterySaveParameter, object>.MoveNext
	|
	|-RVA: 0x2E3620 Offset: 0x2E3721 VA: 0x2E3620
	|-Dictionary.KeyCollection.Enumerator<OrderSaveData, object>.MoveNext
	|
	|-RVA: 0x2E3760 Offset: 0x2E3861 VA: 0x2E3760
	|-Dictionary.KeyCollection.Enumerator<OrderSaveParameter, object>.MoveNext
	|
	|-RVA: 0x2E38D0 Offset: 0x2E39D1 VA: 0x2E38D0
	|-Dictionary.KeyCollection.Enumerator<Parameter, object>.MoveNext
	|
	|-RVA: 0x2E5880 Offset: 0x2E5981 VA: 0x2E5880
	|-Dictionary.KeyCollection.Enumerator<RF5SystemData.FLAG, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x2E3A20 Offset: 0x2E3B21 VA: 0x2E3A20
	|-Dictionary.KeyCollection.Enumerator<bool, object>.MoveNext
	|
	|-RVA: 0x2E3B40 Offset: 0x2E3C41 VA: 0x2E3B40
	|-Dictionary.KeyCollection.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x2E3C60 Offset: 0x2E3D61 VA: 0x2E3C60
	|-Dictionary.KeyCollection.Enumerator<char, object>.MoveNext
	|
	|-RVA: 0x2E3D80 Offset: 0x2E3E81 VA: 0x2E3D80
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.MoveNext
	|
	|-RVA: 0x2E3EA0 Offset: 0x2E3FA1 VA: 0x2E3EA0
	|-Dictionary.KeyCollection.Enumerator<double, object>.MoveNext
	|
	|-RVA: 0x2E3FC0 Offset: 0x2E40C1 VA: 0x2E3FC0
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.MoveNext
	|
	|-RVA: 0x2E40E0 Offset: 0x2E41E1 VA: 0x2E40E0
	|-Dictionary.KeyCollection.Enumerator<short, object>.MoveNext
	|
	|-RVA: 0x2E4200 Offset: 0x2E4301 VA: 0x2E4200
	|-Dictionary.KeyCollection.Enumerator<int, CropDataTable>.MoveNext
	|
	|-RVA: 0x2E4320 Offset: 0x2E4421 VA: 0x2E4320
	|-Dictionary.KeyCollection.Enumerator<int, EffectDataTable>.MoveNext
	|
	|-RVA: 0x2E4440 Offset: 0x2E4541 VA: 0x2E4440
	|-Dictionary.KeyCollection.Enumerator<int, GimmickLayoutDataTable>.MoveNext
	|
	|-RVA: 0x2E4560 Offset: 0x2E4661 VA: 0x2E4560
	|-Dictionary.KeyCollection.Enumerator<int, MineTypeDataTable>.MoveNext
	|
	|-RVA: 0x2E4680 Offset: 0x2E4781 VA: 0x2E4680
	|-Dictionary.KeyCollection.Enumerator<int, MiningDataTable>.MoveNext
	|
	|-RVA: 0x2E47A0 Offset: 0x2E48A1 VA: 0x2E47A0
	|-Dictionary.KeyCollection.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x2E48C0 Offset: 0x2E49C1 VA: 0x2E48C0
	|-Dictionary.KeyCollection.Enumerator<int, char>.MoveNext
	|
	|-RVA: 0x2E4D40 Offset: 0x2E4E41 VA: 0x2E4D40
	|-Dictionary.KeyCollection.Enumerator<int, Dictionary<int, List<OrderMasterData>>>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<int, List<MeshDataConnectivity.Face>>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<int, object>.MoveNext
	|
	|-RVA: 0x2E49E0 Offset: 0x2E4AE1 VA: 0x2E49E0
	|-Dictionary.KeyCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x2E4B00 Offset: 0x2E4C01 VA: 0x2E4B00
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x2E4C20 Offset: 0x2E4D21 VA: 0x2E4C20
	|-Dictionary.KeyCollection.Enumerator<int, long>.MoveNext
	|
	|-RVA: 0x2E4E60 Offset: 0x2E4F61 VA: 0x2E4E60
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x2E4F80 Offset: 0x2E5081 VA: 0x2E4F80
	|-Dictionary.KeyCollection.Enumerator<int, SceneInstance>.MoveNext
	|
	|-RVA: 0x2E50A0 Offset: 0x2E51A1 VA: 0x2E50A0
	|-Dictionary.KeyCollection.Enumerator<int, Vector2Int>.MoveNext
	|
	|-RVA: 0x2E51C0 Offset: 0x2E52C1 VA: 0x2E51C0
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.MoveNext
	|
	|-RVA: 0x2E52E0 Offset: 0x2E53E1 VA: 0x2E52E0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterDataTable>.MoveNext
	|
	|-RVA: 0x2E5400 Offset: 0x2E5501 VA: 0x2E5400
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.MoveNext
	|
	|-RVA: 0x2E5520 Offset: 0x2E5621 VA: 0x2E5520
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.MoveNext
	|
	|-RVA: 0x2E5640 Offset: 0x2E5741 VA: 0x2E5640
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x2E5760 Offset: 0x2E5861 VA: 0x2E5760
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2E59A0 Offset: 0x2E5AA1 VA: 0x2E59A0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x2E5BE0 Offset: 0x2E5CE1 VA: 0x2E5BE0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x2E5D00 Offset: 0x2E5E01 VA: 0x2E5D00
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x2E5E20 Offset: 0x2E5F21 VA: 0x2E5E20
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.MoveNext
	|
	|-RVA: 0x2E5F40 Offset: 0x2E6041 VA: 0x2E5F40
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.MoveNext
	|
	|-RVA: 0x2E6060 Offset: 0x2E6161 VA: 0x2E6060
	|-Dictionary.KeyCollection.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x2E6180 Offset: 0x2E6281 VA: 0x2E6180
	|-Dictionary.KeyCollection.Enumerator<Memory<object>, object>.MoveNext
	|
	|-RVA: 0x2E62A0 Offset: 0x2E63A1 VA: 0x2E62A0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Int32Enum>, object>.MoveNext
	|
	|-RVA: 0x2E63D0 Offset: 0x2E64D1 VA: 0x2E63D0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Bounds>, object>.MoveNext
	|
	|-RVA: 0x2E6520 Offset: 0x2E6621 VA: 0x2E6520
	|-Dictionary.KeyCollection.Enumerator<Nullable<BoundsInt>, object>.MoveNext
	|
	|-RVA: 0x2E6660 Offset: 0x2E6761 VA: 0x2E6660
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color32>, object>.MoveNext
	|
	|-RVA: 0x2E6780 Offset: 0x2E6881 VA: 0x2E6780
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color>, object>.MoveNext
	|
	|-RVA: 0x2E68C0 Offset: 0x2E69C1 VA: 0x2E68C0
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientAlphaKey>, object>.MoveNext
	|
	|-RVA: 0x2E69F0 Offset: 0x2E6AF1 VA: 0x2E69F0
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientColorKey>, object>.MoveNext
	|
	|-RVA: 0x2E6B30 Offset: 0x2E6C31 VA: 0x2E6B30
	|-Dictionary.KeyCollection.Enumerator<Nullable<Keyframe>, object>.MoveNext
	|
	|-RVA: 0x2E6C70 Offset: 0x2E6D71 VA: 0x2E6C70
	|-Dictionary.KeyCollection.Enumerator<Nullable<LayerMask>, object>.MoveNext
	|
	|-RVA: 0x2E6DA0 Offset: 0x2E6EA1 VA: 0x2E6DA0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Matrix4x4>, object>.MoveNext
	|
	|-RVA: 0x2E6F00 Offset: 0x2E7001 VA: 0x2E6F00
	|-Dictionary.KeyCollection.Enumerator<Nullable<Quaternion>, object>.MoveNext
	|
	|-RVA: 0x2E7040 Offset: 0x2E7141 VA: 0x2E7040
	|-Dictionary.KeyCollection.Enumerator<Nullable<RangeInt>, object>.MoveNext
	|
	|-RVA: 0x2E7170 Offset: 0x2E7271 VA: 0x2E7170
	|-Dictionary.KeyCollection.Enumerator<Nullable<Rect>, object>.MoveNext
	|
	|-RVA: 0x2E72B0 Offset: 0x2E73B1 VA: 0x2E72B0
	|-Dictionary.KeyCollection.Enumerator<Nullable<RectInt>, object>.MoveNext
	|
	|-RVA: 0x2E73F0 Offset: 0x2E74F1 VA: 0x2E73F0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2>, object>.MoveNext
	|
	|-RVA: 0x2E7520 Offset: 0x2E7621 VA: 0x2E7520
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2Int>, object>.MoveNext
	|
	|-RVA: 0x2E7650 Offset: 0x2E7751 VA: 0x2E7650
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3>, object>.MoveNext
	|
	|-RVA: 0x2E7770 Offset: 0x2E7871 VA: 0x2E7770
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3Int>, object>.MoveNext
	|
	|-RVA: 0x2E7890 Offset: 0x2E7991 VA: 0x2E7890
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector4>, object>.MoveNext
	|
	|-RVA: 0x2E79D0 Offset: 0x2E7AD1 VA: 0x2E79D0
	|-Dictionary.KeyCollection.Enumerator<object, BitVector32Int>.MoveNext
	|
	|-RVA: 0x2E7B90 Offset: 0x2E7C91 VA: 0x2E7B90
	|-Dictionary.KeyCollection.Enumerator<object, EventCheckId>.MoveNext
	|
	|-RVA: 0x2E7D50 Offset: 0x2E7E51 VA: 0x2E7D50
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.MoveNext
	|
	|-RVA: 0x2E7F10 Offset: 0x2E8011 VA: 0x2E7F10
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.MoveNext
	|
	|-RVA: 0x2E80D0 Offset: 0x2E81D1 VA: 0x2E80D0
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.MoveNext
	|
	|-RVA: 0x2E8290 Offset: 0x2E8391 VA: 0x2E8290
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.MoveNext
	|
	|-RVA: 0x2E8450 Offset: 0x2E8551 VA: 0x2E8450
	|-Dictionary.KeyCollection.Enumerator<object, MonsterHutSaveData>.MoveNext
	|
	|-RVA: 0x2E8610 Offset: 0x2E8711 VA: 0x2E8610
	|-Dictionary.KeyCollection.Enumerator<object, OrderLotterySaveParameter>.MoveNext
	|
	|-RVA: 0x2E87D0 Offset: 0x2E88D1 VA: 0x2E87D0
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveData>.MoveNext
	|
	|-RVA: 0x2E8990 Offset: 0x2E8A91 VA: 0x2E8990
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveParameter>.MoveNext
	|
	|-RVA: 0x2E8B50 Offset: 0x2E8C51 VA: 0x2E8B50
	|-Dictionary.KeyCollection.Enumerator<object, Parameter>.MoveNext
	|
	|-RVA: 0x2E8D10 Offset: 0x2E8E11 VA: 0x2E8D10
	|-Dictionary.KeyCollection.Enumerator<object, NumberControl.ValueRange>.MoveNext
	|
	|-RVA: 0x2E8ED0 Offset: 0x2E8FD1 VA: 0x2E8ED0
	|-Dictionary.KeyCollection.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x2E9090 Offset: 0x2E9191 VA: 0x2E9090
	|-Dictionary.KeyCollection.Enumerator<object, byte>.MoveNext
	|
	|-RVA: 0x2E9250 Offset: 0x2E9351 VA: 0x2E9250
	|-Dictionary.KeyCollection.Enumerator<object, char>.MoveNext
	|
	|-RVA: 0x2E9410 Offset: 0x2E9511 VA: 0x2E9410
	|-Dictionary.KeyCollection.Enumerator<object, DateTime>.MoveNext
	|
	|-RVA: 0x2E95D0 Offset: 0x2E96D1 VA: 0x2E95D0
	|-Dictionary.KeyCollection.Enumerator<object, double>.MoveNext
	|
	|-RVA: 0x2E9790 Offset: 0x2E9891 VA: 0x2E9790
	|-Dictionary.KeyCollection.Enumerator<object, short>.MoveNext
	|
	|-RVA: 0x2E9950 Offset: 0x2E9A51 VA: 0x2E9950
	|-Dictionary.KeyCollection.Enumerator<object, int>.MoveNext
	|
	|-RVA: 0x2E9B10 Offset: 0x2E9C11 VA: 0x2E9B10
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, SystemLanguage>.MoveNext
	|
	|-RVA: 0x2E9CD0 Offset: 0x2E9DD1 VA: 0x2E9CD0
	|-Dictionary.KeyCollection.Enumerator<object, long>.MoveNext
	|
	|-RVA: 0x2E9E90 Offset: 0x2E9F91 VA: 0x2E9E90
	|-Dictionary.KeyCollection.Enumerator<object, Memory<object>>.MoveNext
	|
	|-RVA: 0x2F35F0 Offset: 0x2F36F1 VA: 0x2F35F0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Int32Enum>>.MoveNext
	|
	|-RVA: 0x2F37B0 Offset: 0x2F38B1 VA: 0x2F37B0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Bounds>>.MoveNext
	|
	|-RVA: 0x2F3970 Offset: 0x2F3A71 VA: 0x2F3970
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<BoundsInt>>.MoveNext
	|
	|-RVA: 0x2F3B30 Offset: 0x2F3C31 VA: 0x2F3B30
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color32>>.MoveNext
	|
	|-RVA: 0x2F3CF0 Offset: 0x2F3DF1 VA: 0x2F3CF0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color>>.MoveNext
	|
	|-RVA: 0x2F3EB0 Offset: 0x2F3FB1 VA: 0x2F3EB0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x2F4070 Offset: 0x2F4171 VA: 0x2F4070
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientColorKey>>.MoveNext
	|
	|-RVA: 0x2F4230 Offset: 0x2F4331 VA: 0x2F4230
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Keyframe>>.MoveNext
	|
	|-RVA: 0x2F43F0 Offset: 0x2F44F1 VA: 0x2F43F0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<LayerMask>>.MoveNext
	|
	|-RVA: 0x2F45B0 Offset: 0x2F46B1 VA: 0x2F45B0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Matrix4x4>>.MoveNext
	|
	|-RVA: 0x2F4770 Offset: 0x2F4871 VA: 0x2F4770
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Quaternion>>.MoveNext
	|
	|-RVA: 0x2F4930 Offset: 0x2F4A31 VA: 0x2F4930
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RangeInt>>.MoveNext
	|
	|-RVA: 0x2F4AF0 Offset: 0x2F4BF1 VA: 0x2F4AF0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Rect>>.MoveNext
	|
	|-RVA: 0x2F4CB0 Offset: 0x2F4DB1 VA: 0x2F4CB0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RectInt>>.MoveNext
	|
	|-RVA: 0x2F4E70 Offset: 0x2F4F71 VA: 0x2F4E70
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2>>.MoveNext
	|
	|-RVA: 0x2F5030 Offset: 0x2F5131 VA: 0x2F5030
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2Int>>.MoveNext
	|
	|-RVA: 0x2F51F0 Offset: 0x2F52F1 VA: 0x2F51F0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3>>.MoveNext
	|
	|-RVA: 0x2F53B0 Offset: 0x2F54B1 VA: 0x2F53B0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3Int>>.MoveNext
	|
	|-RVA: 0x2F5570 Offset: 0x2F5671 VA: 0x2F5570
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector4>>.MoveNext
	|
	|-RVA: 0x2F58F0 Offset: 0x2F59F1 VA: 0x2F58F0
	|-Dictionary.KeyCollection.Enumerator<object, ReadOnlyMemory<object>>.MoveNext
	|
	|-RVA: 0x2F5AB0 Offset: 0x2F5BB1 VA: 0x2F5AB0
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.MoveNext
	|
	|-RVA: 0x2F5C70 Offset: 0x2F5D71 VA: 0x2F5C70
	|-Dictionary.KeyCollection.Enumerator<object, sbyte>.MoveNext
	|
	|-RVA: 0x2F5FF0 Offset: 0x2F60F1 VA: 0x2F5FF0
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.MoveNext
	|
	|-RVA: 0x2F61B0 Offset: 0x2F62B1 VA: 0x2F61B0
	|-Dictionary.KeyCollection.Enumerator<object, uint>.MoveNext
	|
	|-RVA: 0x2F6370 Offset: 0x2F6471 VA: 0x2F6370
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.MoveNext
	|
	|-RVA: 0x2F6530 Offset: 0x2F6631 VA: 0x2F6530
	|-Dictionary.KeyCollection.Enumerator<object, TransitionTables>.MoveNext
	|
	|-RVA: 0x2F66F0 Offset: 0x2F67F1 VA: 0x2F66F0
	|-Dictionary.KeyCollection.Enumerator<object, Bounds>.MoveNext
	|
	|-RVA: 0x2F68B0 Offset: 0x2F69B1 VA: 0x2F68B0
	|-Dictionary.KeyCollection.Enumerator<object, BoundsInt>.MoveNext
	|
	|-RVA: 0x2F6A70 Offset: 0x2F6B71 VA: 0x2F6A70
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.MoveNext
	|
	|-RVA: 0x2F6C30 Offset: 0x2F6D31 VA: 0x2F6C30
	|-Dictionary.KeyCollection.Enumerator<object, Color>.MoveNext
	|
	|-RVA: 0x2F6DF0 Offset: 0x2F6EF1 VA: 0x2F6DF0
	|-Dictionary.KeyCollection.Enumerator<object, GradientAlphaKey>.MoveNext
	|
	|-RVA: 0x2F6FB0 Offset: 0x2F70B1 VA: 0x2F6FB0
	|-Dictionary.KeyCollection.Enumerator<object, GradientColorKey>.MoveNext
	|
	|-RVA: 0x2F7170 Offset: 0x2F7271 VA: 0x2F7170
	|-Dictionary.KeyCollection.Enumerator<object, Keyframe>.MoveNext
	|
	|-RVA: 0x2F7330 Offset: 0x2F7431 VA: 0x2F7330
	|-Dictionary.KeyCollection.Enumerator<object, LayerMask>.MoveNext
	|
	|-RVA: 0x2F74F0 Offset: 0x2F75F1 VA: 0x2F74F0
	|-Dictionary.KeyCollection.Enumerator<object, Matrix4x4>.MoveNext
	|
	|-RVA: 0x2F76B0 Offset: 0x2F77B1 VA: 0x2F76B0
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.MoveNext
	|
	|-RVA: 0x2F7870 Offset: 0x2F7971 VA: 0x2F7870
	|-Dictionary.KeyCollection.Enumerator<object, Quaternion>.MoveNext
	|
	|-RVA: 0x2F7A30 Offset: 0x2F7B31 VA: 0x2F7A30
	|-Dictionary.KeyCollection.Enumerator<object, RangeInt>.MoveNext
	|
	|-RVA: 0x2F7BF0 Offset: 0x2F7CF1 VA: 0x2F7BF0
	|-Dictionary.KeyCollection.Enumerator<object, Rect>.MoveNext
	|
	|-RVA: 0x2F7DB0 Offset: 0x2F7EB1 VA: 0x2F7DB0
	|-Dictionary.KeyCollection.Enumerator<object, RectInt>.MoveNext
	|
	|-RVA: 0x2F7F70 Offset: 0x2F8071 VA: 0x2F7F70
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x2F8130 Offset: 0x2F8231 VA: 0x2F8130
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x2F82F0 Offset: 0x2F83F1 VA: 0x2F82F0
	|-Dictionary.KeyCollection.Enumerator<object, Vector2>.MoveNext
	|
	|-RVA: 0x2F84B0 Offset: 0x2F85B1 VA: 0x2F84B0
	|-Dictionary.KeyCollection.Enumerator<object, Vector2Int>.MoveNext
	|
	|-RVA: 0x2F8670 Offset: 0x2F8771 VA: 0x2F8670
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.MoveNext
	|
	|-RVA: 0x2F8830 Offset: 0x2F8931 VA: 0x2F8830
	|-Dictionary.KeyCollection.Enumerator<object, Vector3Int>.MoveNext
	|
	|-RVA: 0x2F89F0 Offset: 0x2F8AF1 VA: 0x2F89F0
	|-Dictionary.KeyCollection.Enumerator<object, Vector4>.MoveNext
	|
	|-RVA: 0x2F8BB0 Offset: 0x2F8CB1 VA: 0x2F8BB0
	|-Dictionary.KeyCollection.Enumerator<ReadOnlyMemory<object>, object>.MoveNext
	|
	|-RVA: 0x2F8CD0 Offset: 0x2F8DD1 VA: 0x2F8CD0
	|-Dictionary.KeyCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x2F8DF0 Offset: 0x2F8EF1 VA: 0x2F8DF0
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.MoveNext
	|
	|-RVA: 0x2F8F10 Offset: 0x2F9011 VA: 0x2F8F10
	|-Dictionary.KeyCollection.Enumerator<float, CurveSample>.MoveNext
	|
	|-RVA: 0x2F9030 Offset: 0x2F9131 VA: 0x2F9030
	|-Dictionary.KeyCollection.Enumerator<float, object>.MoveNext
	|
	|-RVA: 0x2F9150 Offset: 0x2F9251 VA: 0x2F9150
	|-Dictionary.KeyCollection.Enumerator<ushort, object>.MoveNext
	|
	|-RVA: 0x2F94B0 Offset: 0x2F95B1 VA: 0x2F94B0
	|-Dictionary.KeyCollection.Enumerator<uint, FriendMonsterStatus>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<uint, object>.MoveNext
	|
	|-RVA: 0x2F9270 Offset: 0x2F9371 VA: 0x2F9270
	|-Dictionary.KeyCollection.Enumerator<uint, int>.MoveNext
	|
	|-RVA: 0x2F9390 Offset: 0x2F9491 VA: 0x2F9390
	|-Dictionary.KeyCollection.Enumerator<uint, Int32Enum>.MoveNext
	|
	|-RVA: 0x2F95D0 Offset: 0x2F96D1 VA: 0x2F95D0
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.MoveNext
	|
	|-RVA: 0x2F96F0 Offset: 0x2F97F1 VA: 0x2F96F0
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, int>.MoveNext
	|
	|-RVA: 0x2F9810 Offset: 0x2F9911 VA: 0x2F9810
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, CapEdge>.MoveNext
	|
	|-RVA: 0x2F9930 Offset: 0x2F9A31 VA: 0x2F9930
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.MoveNext
	|
	|-RVA: 0x2F9A50 Offset: 0x2F9B51 VA: 0x2F9A50
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.MoveNext
	|
	|-RVA: 0x2F9B70 Offset: 0x2F9C71 VA: 0x2F9B70
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, bool>.MoveNext
	|
	|-RVA: 0x2F9C90 Offset: 0x2F9D91 VA: 0x2F9C90
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, object>.MoveNext
	|
	|-RVA: 0x2F9DB0 Offset: 0x2F9EB1 VA: 0x2F9DB0
	|-Dictionary.KeyCollection.Enumerator<Bounds, object>.MoveNext
	|
	|-RVA: 0x2F9EF0 Offset: 0x2F9FF1 VA: 0x2F9EF0
	|-Dictionary.KeyCollection.Enumerator<BoundsInt, object>.MoveNext
	|
	|-RVA: 0x2FA030 Offset: 0x2FA131 VA: 0x2FA030
	|-Dictionary.KeyCollection.Enumerator<Color, object>.MoveNext
	|
	|-RVA: 0x2FA150 Offset: 0x2FA251 VA: 0x2FA150
	|-Dictionary.KeyCollection.Enumerator<Color32, object>.MoveNext
	|
	|-RVA: 0x2FA270 Offset: 0x2FA371 VA: 0x2FA270
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.MoveNext
	|
	|-RVA: 0x2FA390 Offset: 0x2FA491 VA: 0x2FA390
	|-Dictionary.KeyCollection.Enumerator<GradientAlphaKey, object>.MoveNext
	|
	|-RVA: 0x2FA4B0 Offset: 0x2FA5B1 VA: 0x2FA4B0
	|-Dictionary.KeyCollection.Enumerator<GradientColorKey, object>.MoveNext
	|
	|-RVA: 0x2FA600 Offset: 0x2FA701 VA: 0x2FA600
	|-Dictionary.KeyCollection.Enumerator<Keyframe, object>.MoveNext
	|
	|-RVA: 0x2FA740 Offset: 0x2FA841 VA: 0x2FA740
	|-Dictionary.KeyCollection.Enumerator<LayerMask, object>.MoveNext
	|
	|-RVA: 0x2FA870 Offset: 0x2FA971 VA: 0x2FA870
	|-Dictionary.KeyCollection.Enumerator<Matrix4x4, object>.MoveNext
	|
	|-RVA: 0x2FA9C0 Offset: 0x2FAAC1 VA: 0x2FA9C0
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.MoveNext
	|
	|-RVA: 0x2FAAF0 Offset: 0x2FABF1 VA: 0x2FAAF0
	|-Dictionary.KeyCollection.Enumerator<Quaternion, object>.MoveNext
	|
	|-RVA: 0x2FAC10 Offset: 0x2FAD11 VA: 0x2FAC10
	|-Dictionary.KeyCollection.Enumerator<RangeInt, object>.MoveNext
	|
	|-RVA: 0x2FAD30 Offset: 0x2FAE31 VA: 0x2FAD30
	|-Dictionary.KeyCollection.Enumerator<Rect, object>.MoveNext
	|
	|-RVA: 0x2FAE50 Offset: 0x2FAF51 VA: 0x2FAE50
	|-Dictionary.KeyCollection.Enumerator<RectInt, object>.MoveNext
	|
	|-RVA: 0x2FAF70 Offset: 0x2FB071 VA: 0x2FAF70
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.MoveNext
	|
	|-RVA: 0x2FB090 Offset: 0x2FB191 VA: 0x2FB090
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.MoveNext
	|
	|-RVA: 0x2FB1B0 Offset: 0x2FB2B1 VA: 0x2FB1B0
	|-Dictionary.KeyCollection.Enumerator<Vector2, object>.MoveNext
	|
	|-RVA: 0x2FB2D0 Offset: 0x2FB3D1 VA: 0x2FB2D0
	|-Dictionary.KeyCollection.Enumerator<Vector2Int, object>.MoveNext
	|
	|-RVA: 0x2FB3F0 Offset: 0x2FB4F1 VA: 0x2FB3F0
	|-Dictionary.KeyCollection.Enumerator<Vector3, object>.MoveNext
	|
	|-RVA: 0x36C490 Offset: 0x36C591 VA: 0x36C490
	|-Dictionary.KeyCollection.Enumerator<Vector3Int, object>.MoveNext
	|
	|-RVA: 0x36C5C0 Offset: 0x36C6C1 VA: 0x36C5C0
	|-Dictionary.KeyCollection.Enumerator<Vector4, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x338870 Offset: 0x338971 VA: 0x338870
	|-Dictionary.KeyCollection.Enumerator<JSONDeserialization.TaskField, List<int>>.get_Current
	|-Dictionary.KeyCollection.Enumerator<JSONDeserialization.TaskField, object>.get_Current
	|
	|-RVA: 0x2F5740 Offset: 0x2F5841 VA: 0x2F5740
	|-Dictionary.KeyCollection.Enumerator<BinaryDeserialization.ObjectFieldMap, List<int>>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Character, AvoidController>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Character, YawnController>.get_Current
	|-Dictionary.KeyCollection.Enumerator<CharacterBase, MagicController>.get_Current
	|-Dictionary.KeyCollection.Enumerator<CharacterBase, ThrottleController>.get_Current
	|-Dictionary.KeyCollection.Enumerator<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ParameterExpression, LocalVariable>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, BoolKeyframeGroup>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, ColorKeyframeGroup>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, IKeyframeGroup>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, NumberKeyframeGroup>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, SpherePointKeyframeGroup>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, TextureKeyframeGroup>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Collider, CharacterBase>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x2F5E40 Offset: 0x2F5F41 VA: 0x2F5E40
	|-Dictionary.KeyCollection.Enumerator<Character, float>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x2E5AD0 Offset: 0x2E5BD1 VA: 0x2E5AD0
	|-Dictionary.KeyCollection.Enumerator<ActorID, GrappleController>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ActorID, HandCuffsController>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ActorID, HumanStatusData>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ActorID, ItemStorageData>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ActorID, MobTravelerController>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ActorID, Dictionary<EquipSlotType, HumanEquipItem>>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.get_Current
	|
	|-RVA: 0x2E5890 Offset: 0x2E5991 VA: 0x2E5890
	|-Dictionary.KeyCollection.Enumerator<RF5SystemData.FLAG, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x2E4D50 Offset: 0x2E4E51 VA: 0x2E4D50
	|-Dictionary.KeyCollection.Enumerator<int, Dictionary<int, List<OrderMasterData>>>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, List<MeshDataConnectivity.Face>>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, object>.get_Current
	|
	|-RVA: 0x2E9B20 Offset: 0x2E9C21 VA: 0x2E9B20
	|-Dictionary.KeyCollection.Enumerator<string, SystemLanguage>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.get_Current
	|
	|-RVA: 0x2F94C0 Offset: 0x2F95C1 VA: 0x2F94C0
	|-Dictionary.KeyCollection.Enumerator<uint, FriendMonsterStatus>.get_Current
	|-Dictionary.KeyCollection.Enumerator<uint, object>.get_Current
	|
	|-RVA: 0x2FA280 Offset: 0x2FA381 VA: 0x2FA280
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Current
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.get_Current
	|
	|-RVA: 0x338990 Offset: 0x338A91 VA: 0x338990
	|-Dictionary.KeyCollection.Enumerator<BitVector32Int, object>.get_Current
	|
	|-RVA: 0x338AB0 Offset: 0x338BB1 VA: 0x338AB0
	|-Dictionary.KeyCollection.Enumerator<EventCheckId, object>.get_Current
	|
	|-RVA: 0x338C00 Offset: 0x338D01 VA: 0x338C00
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.get_Current
	|
	|-RVA: 0x2E3010 Offset: 0x2E3111 VA: 0x2E3010
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.get_Current
	|
	|-RVA: 0x2E3150 Offset: 0x2E3251 VA: 0x2E3150
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.get_Current
	|
	|-RVA: 0x2E3280 Offset: 0x2E3381 VA: 0x2E3280
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.get_Current
	|
	|-RVA: 0x2E33B0 Offset: 0x2E34B1 VA: 0x2E33B0
	|-Dictionary.KeyCollection.Enumerator<MonsterHutSaveData, object>.get_Current
	|
	|-RVA: 0x2E34F0 Offset: 0x2E35F1 VA: 0x2E34F0
	|-Dictionary.KeyCollection.Enumerator<OrderLotterySaveParameter, object>.get_Current
	|
	|-RVA: 0x2E3630 Offset: 0x2E3731 VA: 0x2E3630
	|-Dictionary.KeyCollection.Enumerator<OrderSaveData, object>.get_Current
	|
	|-RVA: 0x2E3770 Offset: 0x2E3871 VA: 0x2E3770
	|-Dictionary.KeyCollection.Enumerator<OrderSaveParameter, object>.get_Current
	|
	|-RVA: 0x2E38E0 Offset: 0x2E39E1 VA: 0x2E38E0
	|-Dictionary.KeyCollection.Enumerator<Parameter, object>.get_Current
	|
	|-RVA: 0x2E3A30 Offset: 0x2E3B31 VA: 0x2E3A30
	|-Dictionary.KeyCollection.Enumerator<bool, object>.get_Current
	|
	|-RVA: 0x2E3B50 Offset: 0x2E3C51 VA: 0x2E3B50
	|-Dictionary.KeyCollection.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x2E3C70 Offset: 0x2E3D71 VA: 0x2E3C70
	|-Dictionary.KeyCollection.Enumerator<char, object>.get_Current
	|
	|-RVA: 0x2E3D90 Offset: 0x2E3E91 VA: 0x2E3D90
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.get_Current
	|
	|-RVA: 0x2E3EB0 Offset: 0x2E3FB1 VA: 0x2E3EB0
	|-Dictionary.KeyCollection.Enumerator<double, object>.get_Current
	|
	|-RVA: 0x2E3FD0 Offset: 0x2E40D1 VA: 0x2E3FD0
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.get_Current
	|
	|-RVA: 0x2E40F0 Offset: 0x2E41F1 VA: 0x2E40F0
	|-Dictionary.KeyCollection.Enumerator<short, object>.get_Current
	|
	|-RVA: 0x2E4210 Offset: 0x2E4311 VA: 0x2E4210
	|-Dictionary.KeyCollection.Enumerator<int, CropDataTable>.get_Current
	|
	|-RVA: 0x2E4330 Offset: 0x2E4431 VA: 0x2E4330
	|-Dictionary.KeyCollection.Enumerator<int, EffectDataTable>.get_Current
	|
	|-RVA: 0x2E4450 Offset: 0x2E4551 VA: 0x2E4450
	|-Dictionary.KeyCollection.Enumerator<int, GimmickLayoutDataTable>.get_Current
	|
	|-RVA: 0x2E4570 Offset: 0x2E4671 VA: 0x2E4570
	|-Dictionary.KeyCollection.Enumerator<int, MineTypeDataTable>.get_Current
	|
	|-RVA: 0x2E4690 Offset: 0x2E4791 VA: 0x2E4690
	|-Dictionary.KeyCollection.Enumerator<int, MiningDataTable>.get_Current
	|
	|-RVA: 0x2E47B0 Offset: 0x2E48B1 VA: 0x2E47B0
	|-Dictionary.KeyCollection.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x2E48D0 Offset: 0x2E49D1 VA: 0x2E48D0
	|-Dictionary.KeyCollection.Enumerator<int, char>.get_Current
	|
	|-RVA: 0x2E49F0 Offset: 0x2E4AF1 VA: 0x2E49F0
	|-Dictionary.KeyCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x2E4B10 Offset: 0x2E4C11 VA: 0x2E4B10
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.get_Current
	|
	|-RVA: 0x2E4C30 Offset: 0x2E4D31 VA: 0x2E4C30
	|-Dictionary.KeyCollection.Enumerator<int, long>.get_Current
	|
	|-RVA: 0x2E4E70 Offset: 0x2E4F71 VA: 0x2E4E70
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.get_Current
	|
	|-RVA: 0x2E4F90 Offset: 0x2E5091 VA: 0x2E4F90
	|-Dictionary.KeyCollection.Enumerator<int, SceneInstance>.get_Current
	|
	|-RVA: 0x2E50B0 Offset: 0x2E51B1 VA: 0x2E50B0
	|-Dictionary.KeyCollection.Enumerator<int, Vector2Int>.get_Current
	|
	|-RVA: 0x2E51D0 Offset: 0x2E52D1 VA: 0x2E51D0
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.get_Current
	|
	|-RVA: 0x2E52F0 Offset: 0x2E53F1 VA: 0x2E52F0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterDataTable>.get_Current
	|
	|-RVA: 0x2E5410 Offset: 0x2E5511 VA: 0x2E5410
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.get_Current
	|
	|-RVA: 0x2E5530 Offset: 0x2E5631 VA: 0x2E5530
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Current
	|
	|-RVA: 0x2E5650 Offset: 0x2E5751 VA: 0x2E5650
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.get_Current
	|
	|-RVA: 0x2E5770 Offset: 0x2E5871 VA: 0x2E5770
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2E59B0 Offset: 0x2E5AB1 VA: 0x2E59B0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x2E5BF0 Offset: 0x2E5CF1 VA: 0x2E5BF0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.get_Current
	|
	|-RVA: 0x2E5D10 Offset: 0x2E5E11 VA: 0x2E5D10
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.get_Current
	|
	|-RVA: 0x2E5E30 Offset: 0x2E5F31 VA: 0x2E5E30
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.get_Current
	|
	|-RVA: 0x2E5F50 Offset: 0x2E6051 VA: 0x2E5F50
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.get_Current
	|
	|-RVA: 0x2E6070 Offset: 0x2E6171 VA: 0x2E6070
	|-Dictionary.KeyCollection.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x2E6190 Offset: 0x2E6291 VA: 0x2E6190
	|-Dictionary.KeyCollection.Enumerator<Memory<object>, object>.get_Current
	|
	|-RVA: 0x2E62B0 Offset: 0x2E63B1 VA: 0x2E62B0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Int32Enum>, object>.get_Current
	|
	|-RVA: 0x2E63E0 Offset: 0x2E64E1 VA: 0x2E63E0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Bounds>, object>.get_Current
	|
	|-RVA: 0x2E6530 Offset: 0x2E6631 VA: 0x2E6530
	|-Dictionary.KeyCollection.Enumerator<Nullable<BoundsInt>, object>.get_Current
	|
	|-RVA: 0x2E6670 Offset: 0x2E6771 VA: 0x2E6670
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color32>, object>.get_Current
	|
	|-RVA: 0x2E6790 Offset: 0x2E6891 VA: 0x2E6790
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color>, object>.get_Current
	|
	|-RVA: 0x2E68D0 Offset: 0x2E69D1 VA: 0x2E68D0
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientAlphaKey>, object>.get_Current
	|
	|-RVA: 0x2E6A00 Offset: 0x2E6B01 VA: 0x2E6A00
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientColorKey>, object>.get_Current
	|
	|-RVA: 0x2E6B40 Offset: 0x2E6C41 VA: 0x2E6B40
	|-Dictionary.KeyCollection.Enumerator<Nullable<Keyframe>, object>.get_Current
	|
	|-RVA: 0x2E6C80 Offset: 0x2E6D81 VA: 0x2E6C80
	|-Dictionary.KeyCollection.Enumerator<Nullable<LayerMask>, object>.get_Current
	|
	|-RVA: 0x2E6DB0 Offset: 0x2E6EB1 VA: 0x2E6DB0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Matrix4x4>, object>.get_Current
	|
	|-RVA: 0x2E6F10 Offset: 0x2E7011 VA: 0x2E6F10
	|-Dictionary.KeyCollection.Enumerator<Nullable<Quaternion>, object>.get_Current
	|
	|-RVA: 0x2E7050 Offset: 0x2E7151 VA: 0x2E7050
	|-Dictionary.KeyCollection.Enumerator<Nullable<RangeInt>, object>.get_Current
	|
	|-RVA: 0x2E7180 Offset: 0x2E7281 VA: 0x2E7180
	|-Dictionary.KeyCollection.Enumerator<Nullable<Rect>, object>.get_Current
	|
	|-RVA: 0x2E72C0 Offset: 0x2E73C1 VA: 0x2E72C0
	|-Dictionary.KeyCollection.Enumerator<Nullable<RectInt>, object>.get_Current
	|
	|-RVA: 0x2E7400 Offset: 0x2E7501 VA: 0x2E7400
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2>, object>.get_Current
	|
	|-RVA: 0x2E7530 Offset: 0x2E7631 VA: 0x2E7530
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2Int>, object>.get_Current
	|
	|-RVA: 0x2E7660 Offset: 0x2E7761 VA: 0x2E7660
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3>, object>.get_Current
	|
	|-RVA: 0x2E7780 Offset: 0x2E7881 VA: 0x2E7780
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3Int>, object>.get_Current
	|
	|-RVA: 0x2E78A0 Offset: 0x2E79A1 VA: 0x2E78A0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector4>, object>.get_Current
	|
	|-RVA: 0x2E79E0 Offset: 0x2E7AE1 VA: 0x2E79E0
	|-Dictionary.KeyCollection.Enumerator<object, BitVector32Int>.get_Current
	|
	|-RVA: 0x2E7BA0 Offset: 0x2E7CA1 VA: 0x2E7BA0
	|-Dictionary.KeyCollection.Enumerator<object, EventCheckId>.get_Current
	|
	|-RVA: 0x2E7D60 Offset: 0x2E7E61 VA: 0x2E7D60
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.get_Current
	|
	|-RVA: 0x2E7F20 Offset: 0x2E8021 VA: 0x2E7F20
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.get_Current
	|
	|-RVA: 0x2E80E0 Offset: 0x2E81E1 VA: 0x2E80E0
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.get_Current
	|
	|-RVA: 0x2E82A0 Offset: 0x2E83A1 VA: 0x2E82A0
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.get_Current
	|
	|-RVA: 0x2E8460 Offset: 0x2E8561 VA: 0x2E8460
	|-Dictionary.KeyCollection.Enumerator<object, MonsterHutSaveData>.get_Current
	|
	|-RVA: 0x2E8620 Offset: 0x2E8721 VA: 0x2E8620
	|-Dictionary.KeyCollection.Enumerator<object, OrderLotterySaveParameter>.get_Current
	|
	|-RVA: 0x2E87E0 Offset: 0x2E88E1 VA: 0x2E87E0
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveData>.get_Current
	|
	|-RVA: 0x2E89A0 Offset: 0x2E8AA1 VA: 0x2E89A0
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveParameter>.get_Current
	|
	|-RVA: 0x2E8B60 Offset: 0x2E8C61 VA: 0x2E8B60
	|-Dictionary.KeyCollection.Enumerator<object, Parameter>.get_Current
	|
	|-RVA: 0x2E8D20 Offset: 0x2E8E21 VA: 0x2E8D20
	|-Dictionary.KeyCollection.Enumerator<object, NumberControl.ValueRange>.get_Current
	|
	|-RVA: 0x2E8EE0 Offset: 0x2E8FE1 VA: 0x2E8EE0
	|-Dictionary.KeyCollection.Enumerator<object, bool>.get_Current
	|
	|-RVA: 0x2E90A0 Offset: 0x2E91A1 VA: 0x2E90A0
	|-Dictionary.KeyCollection.Enumerator<object, byte>.get_Current
	|
	|-RVA: 0x2E9260 Offset: 0x2E9361 VA: 0x2E9260
	|-Dictionary.KeyCollection.Enumerator<object, char>.get_Current
	|
	|-RVA: 0x2E9420 Offset: 0x2E9521 VA: 0x2E9420
	|-Dictionary.KeyCollection.Enumerator<object, DateTime>.get_Current
	|
	|-RVA: 0x2E95E0 Offset: 0x2E96E1 VA: 0x2E95E0
	|-Dictionary.KeyCollection.Enumerator<object, double>.get_Current
	|
	|-RVA: 0x2E97A0 Offset: 0x2E98A1 VA: 0x2E97A0
	|-Dictionary.KeyCollection.Enumerator<object, short>.get_Current
	|
	|-RVA: 0x2E9960 Offset: 0x2E9A61 VA: 0x2E9960
	|-Dictionary.KeyCollection.Enumerator<object, int>.get_Current
	|
	|-RVA: 0x2E9CE0 Offset: 0x2E9DE1 VA: 0x2E9CE0
	|-Dictionary.KeyCollection.Enumerator<object, long>.get_Current
	|
	|-RVA: 0x2E9EA0 Offset: 0x2E9FA1 VA: 0x2E9EA0
	|-Dictionary.KeyCollection.Enumerator<object, Memory<object>>.get_Current
	|
	|-RVA: 0x2F3600 Offset: 0x2F3701 VA: 0x2F3600
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Int32Enum>>.get_Current
	|
	|-RVA: 0x2F37C0 Offset: 0x2F38C1 VA: 0x2F37C0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Bounds>>.get_Current
	|
	|-RVA: 0x2F3980 Offset: 0x2F3A81 VA: 0x2F3980
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<BoundsInt>>.get_Current
	|
	|-RVA: 0x2F3B40 Offset: 0x2F3C41 VA: 0x2F3B40
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color32>>.get_Current
	|
	|-RVA: 0x2F3D00 Offset: 0x2F3E01 VA: 0x2F3D00
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color>>.get_Current
	|
	|-RVA: 0x2F3EC0 Offset: 0x2F3FC1 VA: 0x2F3EC0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x2F4080 Offset: 0x2F4181 VA: 0x2F4080
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientColorKey>>.get_Current
	|
	|-RVA: 0x2F4240 Offset: 0x2F4341 VA: 0x2F4240
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Keyframe>>.get_Current
	|
	|-RVA: 0x2F4400 Offset: 0x2F4501 VA: 0x2F4400
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<LayerMask>>.get_Current
	|
	|-RVA: 0x2F45C0 Offset: 0x2F46C1 VA: 0x2F45C0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Matrix4x4>>.get_Current
	|
	|-RVA: 0x2F4780 Offset: 0x2F4881 VA: 0x2F4780
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Quaternion>>.get_Current
	|
	|-RVA: 0x2F4940 Offset: 0x2F4A41 VA: 0x2F4940
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RangeInt>>.get_Current
	|
	|-RVA: 0x2F4B00 Offset: 0x2F4C01 VA: 0x2F4B00
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Rect>>.get_Current
	|
	|-RVA: 0x2F4CC0 Offset: 0x2F4DC1 VA: 0x2F4CC0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RectInt>>.get_Current
	|
	|-RVA: 0x2F4E80 Offset: 0x2F4F81 VA: 0x2F4E80
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2>>.get_Current
	|
	|-RVA: 0x2F5040 Offset: 0x2F5141 VA: 0x2F5040
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2Int>>.get_Current
	|
	|-RVA: 0x2F5200 Offset: 0x2F5301 VA: 0x2F5200
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3>>.get_Current
	|
	|-RVA: 0x2F53C0 Offset: 0x2F54C1 VA: 0x2F53C0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3Int>>.get_Current
	|
	|-RVA: 0x2F5580 Offset: 0x2F5681 VA: 0x2F5580
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector4>>.get_Current
	|
	|-RVA: 0x2F5900 Offset: 0x2F5A01 VA: 0x2F5900
	|-Dictionary.KeyCollection.Enumerator<object, ReadOnlyMemory<object>>.get_Current
	|
	|-RVA: 0x2F5AC0 Offset: 0x2F5BC1 VA: 0x2F5AC0
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.get_Current
	|
	|-RVA: 0x2F5C80 Offset: 0x2F5D81 VA: 0x2F5C80
	|-Dictionary.KeyCollection.Enumerator<object, sbyte>.get_Current
	|
	|-RVA: 0x2F6000 Offset: 0x2F6101 VA: 0x2F6000
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.get_Current
	|
	|-RVA: 0x2F61C0 Offset: 0x2F62C1 VA: 0x2F61C0
	|-Dictionary.KeyCollection.Enumerator<object, uint>.get_Current
	|
	|-RVA: 0x2F6380 Offset: 0x2F6481 VA: 0x2F6380
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.get_Current
	|
	|-RVA: 0x2F6540 Offset: 0x2F6641 VA: 0x2F6540
	|-Dictionary.KeyCollection.Enumerator<object, TransitionTables>.get_Current
	|
	|-RVA: 0x2F6700 Offset: 0x2F6801 VA: 0x2F6700
	|-Dictionary.KeyCollection.Enumerator<object, Bounds>.get_Current
	|
	|-RVA: 0x2F68C0 Offset: 0x2F69C1 VA: 0x2F68C0
	|-Dictionary.KeyCollection.Enumerator<object, BoundsInt>.get_Current
	|
	|-RVA: 0x2F6A80 Offset: 0x2F6B81 VA: 0x2F6A80
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.get_Current
	|
	|-RVA: 0x2F6C40 Offset: 0x2F6D41 VA: 0x2F6C40
	|-Dictionary.KeyCollection.Enumerator<object, Color>.get_Current
	|
	|-RVA: 0x2F6E00 Offset: 0x2F6F01 VA: 0x2F6E00
	|-Dictionary.KeyCollection.Enumerator<object, GradientAlphaKey>.get_Current
	|
	|-RVA: 0x2F6FC0 Offset: 0x2F70C1 VA: 0x2F6FC0
	|-Dictionary.KeyCollection.Enumerator<object, GradientColorKey>.get_Current
	|
	|-RVA: 0x2F7180 Offset: 0x2F7281 VA: 0x2F7180
	|-Dictionary.KeyCollection.Enumerator<object, Keyframe>.get_Current
	|
	|-RVA: 0x2F7340 Offset: 0x2F7441 VA: 0x2F7340
	|-Dictionary.KeyCollection.Enumerator<object, LayerMask>.get_Current
	|
	|-RVA: 0x2F7500 Offset: 0x2F7601 VA: 0x2F7500
	|-Dictionary.KeyCollection.Enumerator<object, Matrix4x4>.get_Current
	|
	|-RVA: 0x2F76C0 Offset: 0x2F77C1 VA: 0x2F76C0
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.get_Current
	|
	|-RVA: 0x2F7880 Offset: 0x2F7981 VA: 0x2F7880
	|-Dictionary.KeyCollection.Enumerator<object, Quaternion>.get_Current
	|
	|-RVA: 0x2F7A40 Offset: 0x2F7B41 VA: 0x2F7A40
	|-Dictionary.KeyCollection.Enumerator<object, RangeInt>.get_Current
	|
	|-RVA: 0x2F7C00 Offset: 0x2F7D01 VA: 0x2F7C00
	|-Dictionary.KeyCollection.Enumerator<object, Rect>.get_Current
	|
	|-RVA: 0x2F7DC0 Offset: 0x2F7EC1 VA: 0x2F7DC0
	|-Dictionary.KeyCollection.Enumerator<object, RectInt>.get_Current
	|
	|-RVA: 0x2F7F80 Offset: 0x2F8081 VA: 0x2F7F80
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x2F8140 Offset: 0x2F8241 VA: 0x2F8140
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x2F8300 Offset: 0x2F8401 VA: 0x2F8300
	|-Dictionary.KeyCollection.Enumerator<object, Vector2>.get_Current
	|
	|-RVA: 0x2F84C0 Offset: 0x2F85C1 VA: 0x2F84C0
	|-Dictionary.KeyCollection.Enumerator<object, Vector2Int>.get_Current
	|
	|-RVA: 0x2F8680 Offset: 0x2F8781 VA: 0x2F8680
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.get_Current
	|
	|-RVA: 0x2F8840 Offset: 0x2F8941 VA: 0x2F8840
	|-Dictionary.KeyCollection.Enumerator<object, Vector3Int>.get_Current
	|
	|-RVA: 0x2F8A00 Offset: 0x2F8B01 VA: 0x2F8A00
	|-Dictionary.KeyCollection.Enumerator<object, Vector4>.get_Current
	|
	|-RVA: 0x2F8BC0 Offset: 0x2F8CC1 VA: 0x2F8BC0
	|-Dictionary.KeyCollection.Enumerator<ReadOnlyMemory<object>, object>.get_Current
	|
	|-RVA: 0x2F8CE0 Offset: 0x2F8DE1 VA: 0x2F8CE0
	|-Dictionary.KeyCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x2F8E00 Offset: 0x2F8F01 VA: 0x2F8E00
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.get_Current
	|
	|-RVA: 0x2F8F20 Offset: 0x2F9021 VA: 0x2F8F20
	|-Dictionary.KeyCollection.Enumerator<float, CurveSample>.get_Current
	|
	|-RVA: 0x2F9040 Offset: 0x2F9141 VA: 0x2F9040
	|-Dictionary.KeyCollection.Enumerator<float, object>.get_Current
	|
	|-RVA: 0x2F9160 Offset: 0x2F9261 VA: 0x2F9160
	|-Dictionary.KeyCollection.Enumerator<ushort, object>.get_Current
	|
	|-RVA: 0x2F9280 Offset: 0x2F9381 VA: 0x2F9280
	|-Dictionary.KeyCollection.Enumerator<uint, int>.get_Current
	|
	|-RVA: 0x2F93A0 Offset: 0x2F94A1 VA: 0x2F93A0
	|-Dictionary.KeyCollection.Enumerator<uint, Int32Enum>.get_Current
	|
	|-RVA: 0x2F95E0 Offset: 0x2F96E1 VA: 0x2F95E0
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.get_Current
	|
	|-RVA: 0x2F9700 Offset: 0x2F9801 VA: 0x2F9700
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, int>.get_Current
	|
	|-RVA: 0x2F9820 Offset: 0x2F9921 VA: 0x2F9820
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, CapEdge>.get_Current
	|
	|-RVA: 0x2F9940 Offset: 0x2F9A41 VA: 0x2F9940
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Current
	|
	|-RVA: 0x2F9A60 Offset: 0x2F9B61 VA: 0x2F9A60
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.get_Current
	|
	|-RVA: 0x2F9B80 Offset: 0x2F9C81 VA: 0x2F9B80
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, bool>.get_Current
	|
	|-RVA: 0x2F9CA0 Offset: 0x2F9DA1 VA: 0x2F9CA0
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, object>.get_Current
	|
	|-RVA: 0x2F9DC0 Offset: 0x2F9EC1 VA: 0x2F9DC0
	|-Dictionary.KeyCollection.Enumerator<Bounds, object>.get_Current
	|
	|-RVA: 0x2F9F00 Offset: 0x2FA001 VA: 0x2F9F00
	|-Dictionary.KeyCollection.Enumerator<BoundsInt, object>.get_Current
	|
	|-RVA: 0x2FA040 Offset: 0x2FA141 VA: 0x2FA040
	|-Dictionary.KeyCollection.Enumerator<Color, object>.get_Current
	|
	|-RVA: 0x2FA160 Offset: 0x2FA261 VA: 0x2FA160
	|-Dictionary.KeyCollection.Enumerator<Color32, object>.get_Current
	|
	|-RVA: 0x2FA3A0 Offset: 0x2FA4A1 VA: 0x2FA3A0
	|-Dictionary.KeyCollection.Enumerator<GradientAlphaKey, object>.get_Current
	|
	|-RVA: 0x2FA4C0 Offset: 0x2FA5C1 VA: 0x2FA4C0
	|-Dictionary.KeyCollection.Enumerator<GradientColorKey, object>.get_Current
	|
	|-RVA: 0x2FA610 Offset: 0x2FA711 VA: 0x2FA610
	|-Dictionary.KeyCollection.Enumerator<Keyframe, object>.get_Current
	|
	|-RVA: 0x2FA750 Offset: 0x2FA851 VA: 0x2FA750
	|-Dictionary.KeyCollection.Enumerator<LayerMask, object>.get_Current
	|
	|-RVA: 0x2FA880 Offset: 0x2FA981 VA: 0x2FA880
	|-Dictionary.KeyCollection.Enumerator<Matrix4x4, object>.get_Current
	|
	|-RVA: 0x2FA9D0 Offset: 0x2FAAD1 VA: 0x2FA9D0
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.get_Current
	|
	|-RVA: 0x2FAB00 Offset: 0x2FAC01 VA: 0x2FAB00
	|-Dictionary.KeyCollection.Enumerator<Quaternion, object>.get_Current
	|
	|-RVA: 0x2FAC20 Offset: 0x2FAD21 VA: 0x2FAC20
	|-Dictionary.KeyCollection.Enumerator<RangeInt, object>.get_Current
	|
	|-RVA: 0x2FAD40 Offset: 0x2FAE41 VA: 0x2FAD40
	|-Dictionary.KeyCollection.Enumerator<Rect, object>.get_Current
	|
	|-RVA: 0x2FAE60 Offset: 0x2FAF61 VA: 0x2FAE60
	|-Dictionary.KeyCollection.Enumerator<RectInt, object>.get_Current
	|
	|-RVA: 0x2FAF80 Offset: 0x2FB081 VA: 0x2FAF80
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.get_Current
	|
	|-RVA: 0x2FB0A0 Offset: 0x2FB1A1 VA: 0x2FB0A0
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.get_Current
	|
	|-RVA: 0x2FB1C0 Offset: 0x2FB2C1 VA: 0x2FB1C0
	|-Dictionary.KeyCollection.Enumerator<Vector2, object>.get_Current
	|
	|-RVA: 0x2FB2E0 Offset: 0x2FB3E1 VA: 0x2FB2E0
	|-Dictionary.KeyCollection.Enumerator<Vector2Int, object>.get_Current
	|
	|-RVA: 0x2FB400 Offset: 0x2FB501 VA: 0x2FB400
	|-Dictionary.KeyCollection.Enumerator<Vector3, object>.get_Current
	|
	|-RVA: 0x36C4A0 Offset: 0x36C5A1 VA: 0x36C4A0
	|-Dictionary.KeyCollection.Enumerator<Vector3Int, object>.get_Current
	|
	|-RVA: 0x36C5D0 Offset: 0x36C6D1 VA: 0x36C5D0
	|-Dictionary.KeyCollection.Enumerator<Vector4, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x338880 Offset: 0x338981 VA: 0x338880
	|-Dictionary.KeyCollection.Enumerator<JSONDeserialization.TaskField, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3389A0 Offset: 0x338AA1 VA: 0x3389A0
	|-Dictionary.KeyCollection.Enumerator<BitVector32Int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x338AD0 Offset: 0x338BD1 VA: 0x338AD0
	|-Dictionary.KeyCollection.Enumerator<EventCheckId, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x338C30 Offset: 0x338D31 VA: 0x338C30
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3030 Offset: 0x2E3131 VA: 0x2E3030
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3160 Offset: 0x2E3261 VA: 0x2E3160
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3290 Offset: 0x2E3391 VA: 0x2E3290
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E33D0 Offset: 0x2E34D1 VA: 0x2E33D0
	|-Dictionary.KeyCollection.Enumerator<MonsterHutSaveData, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3500 Offset: 0x2E3601 VA: 0x2E3500
	|-Dictionary.KeyCollection.Enumerator<OrderLotterySaveParameter, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3650 Offset: 0x2E3751 VA: 0x2E3650
	|-Dictionary.KeyCollection.Enumerator<OrderSaveData, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3790 Offset: 0x2E3891 VA: 0x2E3790
	|-Dictionary.KeyCollection.Enumerator<OrderSaveParameter, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E38F0 Offset: 0x2E39F1 VA: 0x2E38F0
	|-Dictionary.KeyCollection.Enumerator<Parameter, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3A40 Offset: 0x2E3B41 VA: 0x2E3A40
	|-Dictionary.KeyCollection.Enumerator<bool, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3B60 Offset: 0x2E3C61 VA: 0x2E3B60
	|-Dictionary.KeyCollection.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3C80 Offset: 0x2E3D81 VA: 0x2E3C80
	|-Dictionary.KeyCollection.Enumerator<char, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3DA0 Offset: 0x2E3EA1 VA: 0x2E3DA0
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3EC0 Offset: 0x2E3FC1 VA: 0x2E3EC0
	|-Dictionary.KeyCollection.Enumerator<double, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E3FE0 Offset: 0x2E40E1 VA: 0x2E3FE0
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4100 Offset: 0x2E4201 VA: 0x2E4100
	|-Dictionary.KeyCollection.Enumerator<short, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4220 Offset: 0x2E4321 VA: 0x2E4220
	|-Dictionary.KeyCollection.Enumerator<int, CropDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4340 Offset: 0x2E4441 VA: 0x2E4340
	|-Dictionary.KeyCollection.Enumerator<int, EffectDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4460 Offset: 0x2E4561 VA: 0x2E4460
	|-Dictionary.KeyCollection.Enumerator<int, GimmickLayoutDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4580 Offset: 0x2E4681 VA: 0x2E4580
	|-Dictionary.KeyCollection.Enumerator<int, MineTypeDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E46A0 Offset: 0x2E47A1 VA: 0x2E46A0
	|-Dictionary.KeyCollection.Enumerator<int, MiningDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E47C0 Offset: 0x2E48C1 VA: 0x2E47C0
	|-Dictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E48E0 Offset: 0x2E49E1 VA: 0x2E48E0
	|-Dictionary.KeyCollection.Enumerator<int, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4A00 Offset: 0x2E4B01 VA: 0x2E4A00
	|-Dictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4B20 Offset: 0x2E4C21 VA: 0x2E4B20
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4C40 Offset: 0x2E4D41 VA: 0x2E4C40
	|-Dictionary.KeyCollection.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4D60 Offset: 0x2E4E61 VA: 0x2E4D60
	|-Dictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4E80 Offset: 0x2E4F81 VA: 0x2E4E80
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E4FA0 Offset: 0x2E50A1 VA: 0x2E4FA0
	|-Dictionary.KeyCollection.Enumerator<int, SceneInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E50C0 Offset: 0x2E51C1 VA: 0x2E50C0
	|-Dictionary.KeyCollection.Enumerator<int, Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E51E0 Offset: 0x2E52E1 VA: 0x2E51E0
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5300 Offset: 0x2E5401 VA: 0x2E5300
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5420 Offset: 0x2E5521 VA: 0x2E5420
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5540 Offset: 0x2E5641 VA: 0x2E5540
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5660 Offset: 0x2E5761 VA: 0x2E5660
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5780 Offset: 0x2E5881 VA: 0x2E5780
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E58A0 Offset: 0x2E59A1 VA: 0x2E58A0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E59C0 Offset: 0x2E5AC1 VA: 0x2E59C0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5AE0 Offset: 0x2E5BE1 VA: 0x2E5AE0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5C00 Offset: 0x2E5D01 VA: 0x2E5C00
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5D20 Offset: 0x2E5E21 VA: 0x2E5D20
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5E40 Offset: 0x2E5F41 VA: 0x2E5E40
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E5F60 Offset: 0x2E6061 VA: 0x2E5F60
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E6080 Offset: 0x2E6181 VA: 0x2E6080
	|-Dictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E61A0 Offset: 0x2E62A1 VA: 0x2E61A0
	|-Dictionary.KeyCollection.Enumerator<Memory<object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E62C0 Offset: 0x2E63C1 VA: 0x2E62C0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Int32Enum>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E6400 Offset: 0x2E6501 VA: 0x2E6400
	|-Dictionary.KeyCollection.Enumerator<Nullable<Bounds>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E6550 Offset: 0x2E6651 VA: 0x2E6550
	|-Dictionary.KeyCollection.Enumerator<Nullable<BoundsInt>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E6680 Offset: 0x2E6781 VA: 0x2E6680
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color32>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E67B0 Offset: 0x2E68B1 VA: 0x2E67B0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E68E0 Offset: 0x2E69E1 VA: 0x2E68E0
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientAlphaKey>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E6A20 Offset: 0x2E6B21 VA: 0x2E6A20
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientColorKey>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E6B60 Offset: 0x2E6C61 VA: 0x2E6B60
	|-Dictionary.KeyCollection.Enumerator<Nullable<Keyframe>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E6C90 Offset: 0x2E6D91 VA: 0x2E6C90
	|-Dictionary.KeyCollection.Enumerator<Nullable<LayerMask>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E6DF0 Offset: 0x2E6EF1 VA: 0x2E6DF0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Matrix4x4>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E6F30 Offset: 0x2E7031 VA: 0x2E6F30
	|-Dictionary.KeyCollection.Enumerator<Nullable<Quaternion>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E7060 Offset: 0x2E7161 VA: 0x2E7060
	|-Dictionary.KeyCollection.Enumerator<Nullable<RangeInt>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E71A0 Offset: 0x2E72A1 VA: 0x2E71A0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Rect>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E72E0 Offset: 0x2E73E1 VA: 0x2E72E0
	|-Dictionary.KeyCollection.Enumerator<Nullable<RectInt>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E7410 Offset: 0x2E7511 VA: 0x2E7410
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E7540 Offset: 0x2E7641 VA: 0x2E7540
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2Int>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E7670 Offset: 0x2E7771 VA: 0x2E7670
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E7790 Offset: 0x2E7891 VA: 0x2E7790
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3Int>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E78C0 Offset: 0x2E79C1 VA: 0x2E78C0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector4>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E79F0 Offset: 0x2E7AF1 VA: 0x2E79F0
	|-Dictionary.KeyCollection.Enumerator<object, BitVector32Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E7BB0 Offset: 0x2E7CB1 VA: 0x2E7BB0
	|-Dictionary.KeyCollection.Enumerator<object, EventCheckId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E7D70 Offset: 0x2E7E71 VA: 0x2E7D70
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E7F30 Offset: 0x2E8031 VA: 0x2E7F30
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E80F0 Offset: 0x2E81F1 VA: 0x2E80F0
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E82B0 Offset: 0x2E83B1 VA: 0x2E82B0
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E8470 Offset: 0x2E8571 VA: 0x2E8470
	|-Dictionary.KeyCollection.Enumerator<object, MonsterHutSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E8630 Offset: 0x2E8731 VA: 0x2E8630
	|-Dictionary.KeyCollection.Enumerator<object, OrderLotterySaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E87F0 Offset: 0x2E88F1 VA: 0x2E87F0
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E89B0 Offset: 0x2E8AB1 VA: 0x2E89B0
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E8B70 Offset: 0x2E8C71 VA: 0x2E8B70
	|-Dictionary.KeyCollection.Enumerator<object, Parameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E8D30 Offset: 0x2E8E31 VA: 0x2E8D30
	|-Dictionary.KeyCollection.Enumerator<object, NumberControl.ValueRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E8EF0 Offset: 0x2E8FF1 VA: 0x2E8EF0
	|-Dictionary.KeyCollection.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E90B0 Offset: 0x2E91B1 VA: 0x2E90B0
	|-Dictionary.KeyCollection.Enumerator<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E9270 Offset: 0x2E9371 VA: 0x2E9270
	|-Dictionary.KeyCollection.Enumerator<object, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E9430 Offset: 0x2E9531 VA: 0x2E9430
	|-Dictionary.KeyCollection.Enumerator<object, DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E95F0 Offset: 0x2E96F1 VA: 0x2E95F0
	|-Dictionary.KeyCollection.Enumerator<object, double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E97B0 Offset: 0x2E98B1 VA: 0x2E97B0
	|-Dictionary.KeyCollection.Enumerator<object, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E9970 Offset: 0x2E9A71 VA: 0x2E9970
	|-Dictionary.KeyCollection.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E9B30 Offset: 0x2E9C31 VA: 0x2E9B30
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E9CF0 Offset: 0x2E9DF1 VA: 0x2E9CF0
	|-Dictionary.KeyCollection.Enumerator<object, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E9EB0 Offset: 0x2E9FB1 VA: 0x2E9EB0
	|-Dictionary.KeyCollection.Enumerator<object, Memory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F3610 Offset: 0x2F3711 VA: 0x2F3610
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F37D0 Offset: 0x2F38D1 VA: 0x2F37D0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F3990 Offset: 0x2F3A91 VA: 0x2F3990
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F3B50 Offset: 0x2F3C51 VA: 0x2F3B50
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F3D10 Offset: 0x2F3E11 VA: 0x2F3D10
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F3ED0 Offset: 0x2F3FD1 VA: 0x2F3ED0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F4090 Offset: 0x2F4191 VA: 0x2F4090
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F4250 Offset: 0x2F4351 VA: 0x2F4250
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F4410 Offset: 0x2F4511 VA: 0x2F4410
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F45D0 Offset: 0x2F46D1 VA: 0x2F45D0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F4790 Offset: 0x2F4891 VA: 0x2F4790
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F4950 Offset: 0x2F4A51 VA: 0x2F4950
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F4B10 Offset: 0x2F4C11 VA: 0x2F4B10
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F4CD0 Offset: 0x2F4DD1 VA: 0x2F4CD0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F4E90 Offset: 0x2F4F91 VA: 0x2F4E90
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F5050 Offset: 0x2F5151 VA: 0x2F5050
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F5210 Offset: 0x2F5311 VA: 0x2F5210
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F53D0 Offset: 0x2F54D1 VA: 0x2F53D0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F5590 Offset: 0x2F5691 VA: 0x2F5590
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F5750 Offset: 0x2F5851 VA: 0x2F5750
	|-Dictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F5910 Offset: 0x2F5A11 VA: 0x2F5910
	|-Dictionary.KeyCollection.Enumerator<object, ReadOnlyMemory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F5AD0 Offset: 0x2F5BD1 VA: 0x2F5AD0
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F5C90 Offset: 0x2F5D91 VA: 0x2F5C90
	|-Dictionary.KeyCollection.Enumerator<object, sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F5E50 Offset: 0x2F5F51 VA: 0x2F5E50
	|-Dictionary.KeyCollection.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F6010 Offset: 0x2F6111 VA: 0x2F6010
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F61D0 Offset: 0x2F62D1 VA: 0x2F61D0
	|-Dictionary.KeyCollection.Enumerator<object, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F6390 Offset: 0x2F6491 VA: 0x2F6390
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F6550 Offset: 0x2F6651 VA: 0x2F6550
	|-Dictionary.KeyCollection.Enumerator<object, TransitionTables>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F6710 Offset: 0x2F6811 VA: 0x2F6710
	|-Dictionary.KeyCollection.Enumerator<object, Bounds>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F68D0 Offset: 0x2F69D1 VA: 0x2F68D0
	|-Dictionary.KeyCollection.Enumerator<object, BoundsInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F6A90 Offset: 0x2F6B91 VA: 0x2F6A90
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F6C50 Offset: 0x2F6D51 VA: 0x2F6C50
	|-Dictionary.KeyCollection.Enumerator<object, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F6E10 Offset: 0x2F6F11 VA: 0x2F6E10
	|-Dictionary.KeyCollection.Enumerator<object, GradientAlphaKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F6FD0 Offset: 0x2F70D1 VA: 0x2F6FD0
	|-Dictionary.KeyCollection.Enumerator<object, GradientColorKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7190 Offset: 0x2F7291 VA: 0x2F7190
	|-Dictionary.KeyCollection.Enumerator<object, Keyframe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7350 Offset: 0x2F7451 VA: 0x2F7350
	|-Dictionary.KeyCollection.Enumerator<object, LayerMask>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7510 Offset: 0x2F7611 VA: 0x2F7510
	|-Dictionary.KeyCollection.Enumerator<object, Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F76D0 Offset: 0x2F77D1 VA: 0x2F76D0
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7890 Offset: 0x2F7991 VA: 0x2F7890
	|-Dictionary.KeyCollection.Enumerator<object, Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7A50 Offset: 0x2F7B51 VA: 0x2F7A50
	|-Dictionary.KeyCollection.Enumerator<object, RangeInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7C10 Offset: 0x2F7D11 VA: 0x2F7C10
	|-Dictionary.KeyCollection.Enumerator<object, Rect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7DD0 Offset: 0x2F7ED1 VA: 0x2F7DD0
	|-Dictionary.KeyCollection.Enumerator<object, RectInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7F90 Offset: 0x2F8091 VA: 0x2F7F90
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F8150 Offset: 0x2F8251 VA: 0x2F8150
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F8310 Offset: 0x2F8411 VA: 0x2F8310
	|-Dictionary.KeyCollection.Enumerator<object, Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F84D0 Offset: 0x2F85D1 VA: 0x2F84D0
	|-Dictionary.KeyCollection.Enumerator<object, Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F8690 Offset: 0x2F8791 VA: 0x2F8690
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F8850 Offset: 0x2F8951 VA: 0x2F8850
	|-Dictionary.KeyCollection.Enumerator<object, Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F8A10 Offset: 0x2F8B11 VA: 0x2F8A10
	|-Dictionary.KeyCollection.Enumerator<object, Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F8BD0 Offset: 0x2F8CD1 VA: 0x2F8BD0
	|-Dictionary.KeyCollection.Enumerator<ReadOnlyMemory<object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F8CF0 Offset: 0x2F8DF1 VA: 0x2F8CF0
	|-Dictionary.KeyCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F8E10 Offset: 0x2F8F11 VA: 0x2F8E10
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F8F30 Offset: 0x2F9031 VA: 0x2F8F30
	|-Dictionary.KeyCollection.Enumerator<float, CurveSample>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9050 Offset: 0x2F9151 VA: 0x2F9050
	|-Dictionary.KeyCollection.Enumerator<float, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9170 Offset: 0x2F9271 VA: 0x2F9170
	|-Dictionary.KeyCollection.Enumerator<ushort, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9290 Offset: 0x2F9391 VA: 0x2F9290
	|-Dictionary.KeyCollection.Enumerator<uint, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F93B0 Offset: 0x2F94B1 VA: 0x2F93B0
	|-Dictionary.KeyCollection.Enumerator<uint, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F94D0 Offset: 0x2F95D1 VA: 0x2F94D0
	|-Dictionary.KeyCollection.Enumerator<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F95F0 Offset: 0x2F96F1 VA: 0x2F95F0
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9710 Offset: 0x2F9811 VA: 0x2F9710
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9830 Offset: 0x2F9931 VA: 0x2F9830
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, CapEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9950 Offset: 0x2F9A51 VA: 0x2F9950
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9A70 Offset: 0x2F9B71 VA: 0x2F9A70
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9B90 Offset: 0x2F9C91 VA: 0x2F9B90
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9CB0 Offset: 0x2F9DB1 VA: 0x2F9CB0
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9DE0 Offset: 0x2F9EE1 VA: 0x2F9DE0
	|-Dictionary.KeyCollection.Enumerator<Bounds, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F9F20 Offset: 0x2FA021 VA: 0x2F9F20
	|-Dictionary.KeyCollection.Enumerator<BoundsInt, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FA050 Offset: 0x2FA151 VA: 0x2FA050
	|-Dictionary.KeyCollection.Enumerator<Color, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FA170 Offset: 0x2FA271 VA: 0x2FA170
	|-Dictionary.KeyCollection.Enumerator<Color32, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FA290 Offset: 0x2FA391 VA: 0x2FA290
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FA3B0 Offset: 0x2FA4B1 VA: 0x2FA3B0
	|-Dictionary.KeyCollection.Enumerator<GradientAlphaKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FA4E0 Offset: 0x2FA5E1 VA: 0x2FA4E0
	|-Dictionary.KeyCollection.Enumerator<GradientColorKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FA630 Offset: 0x2FA731 VA: 0x2FA630
	|-Dictionary.KeyCollection.Enumerator<Keyframe, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FA760 Offset: 0x2FA861 VA: 0x2FA760
	|-Dictionary.KeyCollection.Enumerator<LayerMask, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FA8B0 Offset: 0x2FA9B1 VA: 0x2FA8B0
	|-Dictionary.KeyCollection.Enumerator<Matrix4x4, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FA9E0 Offset: 0x2FAAE1 VA: 0x2FA9E0
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FAB10 Offset: 0x2FAC11 VA: 0x2FAB10
	|-Dictionary.KeyCollection.Enumerator<Quaternion, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FAC30 Offset: 0x2FAD31 VA: 0x2FAC30
	|-Dictionary.KeyCollection.Enumerator<RangeInt, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FAD50 Offset: 0x2FAE51 VA: 0x2FAD50
	|-Dictionary.KeyCollection.Enumerator<Rect, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FAE70 Offset: 0x2FAF71 VA: 0x2FAE70
	|-Dictionary.KeyCollection.Enumerator<RectInt, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FAF90 Offset: 0x2FB091 VA: 0x2FAF90
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FB0B0 Offset: 0x2FB1B1 VA: 0x2FB0B0
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FB1D0 Offset: 0x2FB2D1 VA: 0x2FB1D0
	|-Dictionary.KeyCollection.Enumerator<Vector2, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FB2F0 Offset: 0x2FB3F1 VA: 0x2FB2F0
	|-Dictionary.KeyCollection.Enumerator<Vector2Int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2FB410 Offset: 0x2FB511 VA: 0x2FB410
	|-Dictionary.KeyCollection.Enumerator<Vector3, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36C4B0 Offset: 0x36C5B1 VA: 0x36C4B0
	|-Dictionary.KeyCollection.Enumerator<Vector3Int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36C5E0 Offset: 0x36C6E1 VA: 0x36C5E0
	|-Dictionary.KeyCollection.Enumerator<Vector4, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x338890 Offset: 0x338991 VA: 0x338890
	|-Dictionary.KeyCollection.Enumerator<JSONDeserialization.TaskField, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3389B0 Offset: 0x338AB1 VA: 0x3389B0
	|-Dictionary.KeyCollection.Enumerator<BitVector32Int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x338AE0 Offset: 0x338BE1 VA: 0x338AE0
	|-Dictionary.KeyCollection.Enumerator<EventCheckId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x338C40 Offset: 0x338D41 VA: 0x338C40
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3040 Offset: 0x2E3141 VA: 0x2E3040
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3170 Offset: 0x2E3271 VA: 0x2E3170
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E32A0 Offset: 0x2E33A1 VA: 0x2E32A0
	|-Dictionary.KeyCollection.Enumerator<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E33E0 Offset: 0x2E34E1 VA: 0x2E33E0
	|-Dictionary.KeyCollection.Enumerator<MonsterHutSaveData, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3510 Offset: 0x2E3611 VA: 0x2E3510
	|-Dictionary.KeyCollection.Enumerator<OrderLotterySaveParameter, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3660 Offset: 0x2E3761 VA: 0x2E3660
	|-Dictionary.KeyCollection.Enumerator<OrderSaveData, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E37A0 Offset: 0x2E38A1 VA: 0x2E37A0
	|-Dictionary.KeyCollection.Enumerator<OrderSaveParameter, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3900 Offset: 0x2E3A01 VA: 0x2E3900
	|-Dictionary.KeyCollection.Enumerator<Parameter, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3A50 Offset: 0x2E3B51 VA: 0x2E3A50
	|-Dictionary.KeyCollection.Enumerator<bool, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3B70 Offset: 0x2E3C71 VA: 0x2E3B70
	|-Dictionary.KeyCollection.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3C90 Offset: 0x2E3D91 VA: 0x2E3C90
	|-Dictionary.KeyCollection.Enumerator<char, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3DB0 Offset: 0x2E3EB1 VA: 0x2E3DB0
	|-Dictionary.KeyCollection.Enumerator<DateTime, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3ED0 Offset: 0x2E3FD1 VA: 0x2E3ED0
	|-Dictionary.KeyCollection.Enumerator<double, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E3FF0 Offset: 0x2E40F1 VA: 0x2E3FF0
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4110 Offset: 0x2E4211 VA: 0x2E4110
	|-Dictionary.KeyCollection.Enumerator<short, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4230 Offset: 0x2E4331 VA: 0x2E4230
	|-Dictionary.KeyCollection.Enumerator<int, CropDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4350 Offset: 0x2E4451 VA: 0x2E4350
	|-Dictionary.KeyCollection.Enumerator<int, EffectDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4470 Offset: 0x2E4571 VA: 0x2E4470
	|-Dictionary.KeyCollection.Enumerator<int, GimmickLayoutDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4590 Offset: 0x2E4691 VA: 0x2E4590
	|-Dictionary.KeyCollection.Enumerator<int, MineTypeDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E46B0 Offset: 0x2E47B1 VA: 0x2E46B0
	|-Dictionary.KeyCollection.Enumerator<int, MiningDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E47D0 Offset: 0x2E48D1 VA: 0x2E47D0
	|-Dictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E48F0 Offset: 0x2E49F1 VA: 0x2E48F0
	|-Dictionary.KeyCollection.Enumerator<int, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4A10 Offset: 0x2E4B11 VA: 0x2E4A10
	|-Dictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4B30 Offset: 0x2E4C31 VA: 0x2E4B30
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4C50 Offset: 0x2E4D51 VA: 0x2E4C50
	|-Dictionary.KeyCollection.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4D70 Offset: 0x2E4E71 VA: 0x2E4D70
	|-Dictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4E90 Offset: 0x2E4F91 VA: 0x2E4E90
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E4FB0 Offset: 0x2E50B1 VA: 0x2E4FB0
	|-Dictionary.KeyCollection.Enumerator<int, SceneInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E50D0 Offset: 0x2E51D1 VA: 0x2E50D0
	|-Dictionary.KeyCollection.Enumerator<int, Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E51F0 Offset: 0x2E52F1 VA: 0x2E51F0
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5310 Offset: 0x2E5411 VA: 0x2E5310
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5430 Offset: 0x2E5531 VA: 0x2E5430
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5550 Offset: 0x2E5651 VA: 0x2E5550
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5670 Offset: 0x2E5771 VA: 0x2E5670
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5790 Offset: 0x2E5891 VA: 0x2E5790
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E58B0 Offset: 0x2E59B1 VA: 0x2E58B0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E59D0 Offset: 0x2E5AD1 VA: 0x2E59D0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5AF0 Offset: 0x2E5BF1 VA: 0x2E5AF0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5C10 Offset: 0x2E5D11 VA: 0x2E5C10
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5D30 Offset: 0x2E5E31 VA: 0x2E5D30
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5E50 Offset: 0x2E5F51 VA: 0x2E5E50
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ValueTuple<float, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E5F70 Offset: 0x2E6071 VA: 0x2E5F70
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, TutorialUnlockFlagData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E6090 Offset: 0x2E6191 VA: 0x2E6090
	|-Dictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E61B0 Offset: 0x2E62B1 VA: 0x2E61B0
	|-Dictionary.KeyCollection.Enumerator<Memory<object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E62D0 Offset: 0x2E63D1 VA: 0x2E62D0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Int32Enum>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E6410 Offset: 0x2E6511 VA: 0x2E6410
	|-Dictionary.KeyCollection.Enumerator<Nullable<Bounds>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E6560 Offset: 0x2E6661 VA: 0x2E6560
	|-Dictionary.KeyCollection.Enumerator<Nullable<BoundsInt>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E6690 Offset: 0x2E6791 VA: 0x2E6690
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color32>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E67C0 Offset: 0x2E68C1 VA: 0x2E67C0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Color>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E68F0 Offset: 0x2E69F1 VA: 0x2E68F0
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientAlphaKey>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E6A30 Offset: 0x2E6B31 VA: 0x2E6A30
	|-Dictionary.KeyCollection.Enumerator<Nullable<GradientColorKey>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E6B70 Offset: 0x2E6C71 VA: 0x2E6B70
	|-Dictionary.KeyCollection.Enumerator<Nullable<Keyframe>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E6CA0 Offset: 0x2E6DA1 VA: 0x2E6CA0
	|-Dictionary.KeyCollection.Enumerator<Nullable<LayerMask>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E6E00 Offset: 0x2E6F01 VA: 0x2E6E00
	|-Dictionary.KeyCollection.Enumerator<Nullable<Matrix4x4>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E6F40 Offset: 0x2E7041 VA: 0x2E6F40
	|-Dictionary.KeyCollection.Enumerator<Nullable<Quaternion>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E7070 Offset: 0x2E7171 VA: 0x2E7070
	|-Dictionary.KeyCollection.Enumerator<Nullable<RangeInt>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E71B0 Offset: 0x2E72B1 VA: 0x2E71B0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Rect>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E72F0 Offset: 0x2E73F1 VA: 0x2E72F0
	|-Dictionary.KeyCollection.Enumerator<Nullable<RectInt>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E7420 Offset: 0x2E7521 VA: 0x2E7420
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E7550 Offset: 0x2E7651 VA: 0x2E7550
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector2Int>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E7680 Offset: 0x2E7781 VA: 0x2E7680
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E77A0 Offset: 0x2E78A1 VA: 0x2E77A0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector3Int>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E78D0 Offset: 0x2E79D1 VA: 0x2E78D0
	|-Dictionary.KeyCollection.Enumerator<Nullable<Vector4>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E7AA0 Offset: 0x2E7BA1 VA: 0x2E7AA0
	|-Dictionary.KeyCollection.Enumerator<object, BitVector32Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E7C60 Offset: 0x2E7D61 VA: 0x2E7C60
	|-Dictionary.KeyCollection.Enumerator<object, EventCheckId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E7E20 Offset: 0x2E7F21 VA: 0x2E7E20
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E7FE0 Offset: 0x2E80E1 VA: 0x2E7FE0
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E81A0 Offset: 0x2E82A1 VA: 0x2E81A0
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E8360 Offset: 0x2E8461 VA: 0x2E8360
	|-Dictionary.KeyCollection.Enumerator<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E8520 Offset: 0x2E8621 VA: 0x2E8520
	|-Dictionary.KeyCollection.Enumerator<object, MonsterHutSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E86E0 Offset: 0x2E87E1 VA: 0x2E86E0
	|-Dictionary.KeyCollection.Enumerator<object, OrderLotterySaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E88A0 Offset: 0x2E89A1 VA: 0x2E88A0
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E8A60 Offset: 0x2E8B61 VA: 0x2E8A60
	|-Dictionary.KeyCollection.Enumerator<object, OrderSaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E8C20 Offset: 0x2E8D21 VA: 0x2E8C20
	|-Dictionary.KeyCollection.Enumerator<object, Parameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E8DE0 Offset: 0x2E8EE1 VA: 0x2E8DE0
	|-Dictionary.KeyCollection.Enumerator<object, NumberControl.ValueRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E8FA0 Offset: 0x2E90A1 VA: 0x2E8FA0
	|-Dictionary.KeyCollection.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E9160 Offset: 0x2E9261 VA: 0x2E9160
	|-Dictionary.KeyCollection.Enumerator<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E9320 Offset: 0x2E9421 VA: 0x2E9320
	|-Dictionary.KeyCollection.Enumerator<object, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E94E0 Offset: 0x2E95E1 VA: 0x2E94E0
	|-Dictionary.KeyCollection.Enumerator<object, DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E96A0 Offset: 0x2E97A1 VA: 0x2E96A0
	|-Dictionary.KeyCollection.Enumerator<object, double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E9860 Offset: 0x2E9961 VA: 0x2E9860
	|-Dictionary.KeyCollection.Enumerator<object, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E9A20 Offset: 0x2E9B21 VA: 0x2E9A20
	|-Dictionary.KeyCollection.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E9BE0 Offset: 0x2E9CE1 VA: 0x2E9BE0
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E9DA0 Offset: 0x2E9EA1 VA: 0x2E9DA0
	|-Dictionary.KeyCollection.Enumerator<object, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E9F60 Offset: 0x2EA061 VA: 0x2E9F60
	|-Dictionary.KeyCollection.Enumerator<object, Memory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F36C0 Offset: 0x2F37C1 VA: 0x2F36C0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F3880 Offset: 0x2F3981 VA: 0x2F3880
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F3A40 Offset: 0x2F3B41 VA: 0x2F3A40
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F3C00 Offset: 0x2F3D01 VA: 0x2F3C00
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F3DC0 Offset: 0x2F3EC1 VA: 0x2F3DC0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F3F80 Offset: 0x2F4081 VA: 0x2F3F80
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F4140 Offset: 0x2F4241 VA: 0x2F4140
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F4300 Offset: 0x2F4401 VA: 0x2F4300
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F44C0 Offset: 0x2F45C1 VA: 0x2F44C0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F4680 Offset: 0x2F4781 VA: 0x2F4680
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F4840 Offset: 0x2F4941 VA: 0x2F4840
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F4A00 Offset: 0x2F4B01 VA: 0x2F4A00
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F4BC0 Offset: 0x2F4CC1 VA: 0x2F4BC0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F4D80 Offset: 0x2F4E81 VA: 0x2F4D80
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F4F40 Offset: 0x2F5041 VA: 0x2F4F40
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F5100 Offset: 0x2F5201 VA: 0x2F5100
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F52C0 Offset: 0x2F53C1 VA: 0x2F52C0
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F5480 Offset: 0x2F5581 VA: 0x2F5480
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F5640 Offset: 0x2F5741 VA: 0x2F5640
	|-Dictionary.KeyCollection.Enumerator<object, Nullable<Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F5800 Offset: 0x2F5901 VA: 0x2F5800
	|-Dictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F59C0 Offset: 0x2F5AC1 VA: 0x2F59C0
	|-Dictionary.KeyCollection.Enumerator<object, ReadOnlyMemory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F5B80 Offset: 0x2F5C81 VA: 0x2F5B80
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F5D40 Offset: 0x2F5E41 VA: 0x2F5D40
	|-Dictionary.KeyCollection.Enumerator<object, sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F5F00 Offset: 0x2F6001 VA: 0x2F5F00
	|-Dictionary.KeyCollection.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F60C0 Offset: 0x2F61C1 VA: 0x2F60C0
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F6280 Offset: 0x2F6381 VA: 0x2F6280
	|-Dictionary.KeyCollection.Enumerator<object, uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F6440 Offset: 0x2F6541 VA: 0x2F6440
	|-Dictionary.KeyCollection.Enumerator<object, ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F6600 Offset: 0x2F6701 VA: 0x2F6600
	|-Dictionary.KeyCollection.Enumerator<object, TransitionTables>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F67C0 Offset: 0x2F68C1 VA: 0x2F67C0
	|-Dictionary.KeyCollection.Enumerator<object, Bounds>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F6980 Offset: 0x2F6A81 VA: 0x2F6980
	|-Dictionary.KeyCollection.Enumerator<object, BoundsInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F6B40 Offset: 0x2F6C41 VA: 0x2F6B40
	|-Dictionary.KeyCollection.Enumerator<object, Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F6D00 Offset: 0x2F6E01 VA: 0x2F6D00
	|-Dictionary.KeyCollection.Enumerator<object, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F6EC0 Offset: 0x2F6FC1 VA: 0x2F6EC0
	|-Dictionary.KeyCollection.Enumerator<object, GradientAlphaKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7080 Offset: 0x2F7181 VA: 0x2F7080
	|-Dictionary.KeyCollection.Enumerator<object, GradientColorKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7240 Offset: 0x2F7341 VA: 0x2F7240
	|-Dictionary.KeyCollection.Enumerator<object, Keyframe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7400 Offset: 0x2F7501 VA: 0x2F7400
	|-Dictionary.KeyCollection.Enumerator<object, LayerMask>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F75C0 Offset: 0x2F76C1 VA: 0x2F75C0
	|-Dictionary.KeyCollection.Enumerator<object, Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7780 Offset: 0x2F7881 VA: 0x2F7780
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7940 Offset: 0x2F7A41 VA: 0x2F7940
	|-Dictionary.KeyCollection.Enumerator<object, Quaternion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7B00 Offset: 0x2F7C01 VA: 0x2F7B00
	|-Dictionary.KeyCollection.Enumerator<object, RangeInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7CC0 Offset: 0x2F7DC1 VA: 0x2F7CC0
	|-Dictionary.KeyCollection.Enumerator<object, Rect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7E80 Offset: 0x2F7F81 VA: 0x2F7E80
	|-Dictionary.KeyCollection.Enumerator<object, RectInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8040 Offset: 0x2F8141 VA: 0x2F8040
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8200 Offset: 0x2F8301 VA: 0x2F8200
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F83C0 Offset: 0x2F84C1 VA: 0x2F83C0
	|-Dictionary.KeyCollection.Enumerator<object, Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8580 Offset: 0x2F8681 VA: 0x2F8580
	|-Dictionary.KeyCollection.Enumerator<object, Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8740 Offset: 0x2F8841 VA: 0x2F8740
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8900 Offset: 0x2F8A01 VA: 0x2F8900
	|-Dictionary.KeyCollection.Enumerator<object, Vector3Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8AC0 Offset: 0x2F8BC1 VA: 0x2F8AC0
	|-Dictionary.KeyCollection.Enumerator<object, Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8BE0 Offset: 0x2F8CE1 VA: 0x2F8BE0
	|-Dictionary.KeyCollection.Enumerator<ReadOnlyMemory<object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8D00 Offset: 0x2F8E01 VA: 0x2F8D00
	|-Dictionary.KeyCollection.Enumerator<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8E20 Offset: 0x2F8F21 VA: 0x2F8E20
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F8F40 Offset: 0x2F9041 VA: 0x2F8F40
	|-Dictionary.KeyCollection.Enumerator<float, CurveSample>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9060 Offset: 0x2F9161 VA: 0x2F9060
	|-Dictionary.KeyCollection.Enumerator<float, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9180 Offset: 0x2F9281 VA: 0x2F9180
	|-Dictionary.KeyCollection.Enumerator<ushort, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F92A0 Offset: 0x2F93A1 VA: 0x2F92A0
	|-Dictionary.KeyCollection.Enumerator<uint, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F93C0 Offset: 0x2F94C1 VA: 0x2F93C0
	|-Dictionary.KeyCollection.Enumerator<uint, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F94E0 Offset: 0x2F95E1 VA: 0x2F94E0
	|-Dictionary.KeyCollection.Enumerator<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9600 Offset: 0x2F9701 VA: 0x2F9600
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9720 Offset: 0x2F9821 VA: 0x2F9720
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9840 Offset: 0x2F9941 VA: 0x2F9840
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, CapEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9960 Offset: 0x2F9A61 VA: 0x2F9960
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9A80 Offset: 0x2F9B81 VA: 0x2F9A80
	|-Dictionary.KeyCollection.Enumerator<EdgeKeyByIndex, ClippedEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9BA0 Offset: 0x2F9CA1 VA: 0x2F9BA0
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9CC0 Offset: 0x2F9DC1 VA: 0x2F9CC0
	|-Dictionary.KeyCollection.Enumerator<MeshDataConnectivity.Face, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9DF0 Offset: 0x2F9EF1 VA: 0x2F9DF0
	|-Dictionary.KeyCollection.Enumerator<Bounds, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F9F30 Offset: 0x2FA031 VA: 0x2F9F30
	|-Dictionary.KeyCollection.Enumerator<BoundsInt, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FA060 Offset: 0x2FA161 VA: 0x2FA060
	|-Dictionary.KeyCollection.Enumerator<Color, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FA180 Offset: 0x2FA281 VA: 0x2FA180
	|-Dictionary.KeyCollection.Enumerator<Color32, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FA2A0 Offset: 0x2FA3A1 VA: 0x2FA2A0
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FA3C0 Offset: 0x2FA4C1 VA: 0x2FA3C0
	|-Dictionary.KeyCollection.Enumerator<GradientAlphaKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FA4F0 Offset: 0x2FA5F1 VA: 0x2FA4F0
	|-Dictionary.KeyCollection.Enumerator<GradientColorKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FA640 Offset: 0x2FA741 VA: 0x2FA640
	|-Dictionary.KeyCollection.Enumerator<Keyframe, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FA770 Offset: 0x2FA871 VA: 0x2FA770
	|-Dictionary.KeyCollection.Enumerator<LayerMask, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FA8C0 Offset: 0x2FA9C1 VA: 0x2FA8C0
	|-Dictionary.KeyCollection.Enumerator<Matrix4x4, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FA9F0 Offset: 0x2FAAF1 VA: 0x2FA9F0
	|-Dictionary.KeyCollection.Enumerator<IntVec3, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FAB20 Offset: 0x2FAC21 VA: 0x2FAB20
	|-Dictionary.KeyCollection.Enumerator<Quaternion, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FAC40 Offset: 0x2FAD41 VA: 0x2FAC40
	|-Dictionary.KeyCollection.Enumerator<RangeInt, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FAD60 Offset: 0x2FAE61 VA: 0x2FAD60
	|-Dictionary.KeyCollection.Enumerator<Rect, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FAE80 Offset: 0x2FAF81 VA: 0x2FAE80
	|-Dictionary.KeyCollection.Enumerator<RectInt, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FAFA0 Offset: 0x2FB0A1 VA: 0x2FAFA0
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FB0C0 Offset: 0x2FB1C1 VA: 0x2FB0C0
	|-Dictionary.KeyCollection.Enumerator<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FB1E0 Offset: 0x2FB2E1 VA: 0x2FB1E0
	|-Dictionary.KeyCollection.Enumerator<Vector2, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FB300 Offset: 0x2FB401 VA: 0x2FB300
	|-Dictionary.KeyCollection.Enumerator<Vector2Int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2FB420 Offset: 0x2FB521 VA: 0x2FB420
	|-Dictionary.KeyCollection.Enumerator<Vector3, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36C4C0 Offset: 0x36C5C1 VA: 0x36C4C0
	|-Dictionary.KeyCollection.Enumerator<Vector3Int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x36C5F0 Offset: 0x36C6F1 VA: 0x36C5F0
	|-Dictionary.KeyCollection.Enumerator<Vector4, object>.System.Collections.IEnumerator.Reset
	*/
}

