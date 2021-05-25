[DebuggerTypeProxyAttribute] // RVA: 0xB38C0 Offset: 0xB39C1 VA: 0xB38C0
[DebuggerDisplayAttribute] // RVA: 0xB38C0 Offset: 0xB39C1 VA: 0xB38C0
[Serializable]
public sealed class Dictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 1425
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E23B0 Offset: 0x27E24B1 VA: 0x27E23B0
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x27E2DB0 Offset: 0x27E2EB1 VA: 0x27E2DB0
	|-Dictionary.KeyCollection<BitVector32Int, object>..ctor
	|
	|-RVA: 0x27E3790 Offset: 0x27E3891 VA: 0x27E3790
	|-Dictionary.KeyCollection<EventCheckId, object>..ctor
	|
	|-RVA: 0x27E4210 Offset: 0x27E4311 VA: 0x27E4210
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x27E4D20 Offset: 0x27E4E21 VA: 0x27E4D20
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x27E5790 Offset: 0x27E5891 VA: 0x27E5790
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x27E6180 Offset: 0x27E6281 VA: 0x27E6180
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x27E6B70 Offset: 0x27E6C71 VA: 0x27E6B70
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x27E7630 Offset: 0x27E7731 VA: 0x27E7630
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x27E8020 Offset: 0x27E8121 VA: 0x27E8020
	|-Dictionary.KeyCollection<OrderSaveData, object>..ctor
	|
	|-RVA: 0x27E8AE0 Offset: 0x27E8BE1 VA: 0x27E8AE0
	|-Dictionary.KeyCollection<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x27E9560 Offset: 0x27E9661 VA: 0x27E9560
	|-Dictionary.KeyCollection<Parameter, object>..ctor
	|
	|-RVA: 0x27EA070 Offset: 0x27EA171 VA: 0x27EA070
	|-Dictionary.KeyCollection<bool, object>..ctor
	|
	|-RVA: 0x27EAA50 Offset: 0x27EAB51 VA: 0x27EAA50
	|-Dictionary.KeyCollection<byte, object>..ctor
	|
	|-RVA: 0x27EB430 Offset: 0x27EB531 VA: 0x27EB430
	|-Dictionary.KeyCollection<char, object>..ctor
	|
	|-RVA: 0x27EBE10 Offset: 0x27EBF11 VA: 0x27EBE10
	|-Dictionary.KeyCollection<DateTime, object>..ctor
	|
	|-RVA: 0x27EC7F0 Offset: 0x27EC8F1 VA: 0x27EC7F0
	|-Dictionary.KeyCollection<double, object>..ctor
	|
	|-RVA: 0x27ED1D0 Offset: 0x27ED2D1 VA: 0x27ED1D0
	|-Dictionary.KeyCollection<Guid, object>..ctor
	|
	|-RVA: 0x27EDBC0 Offset: 0x27EDCC1 VA: 0x27EDBC0
	|-Dictionary.KeyCollection<short, object>..ctor
	|
	|-RVA: 0x27EE5A0 Offset: 0x27EE6A1 VA: 0x27EE5A0
	|-Dictionary.KeyCollection<int, CropDataTable>..ctor
	|
	|-RVA: 0x27EEF80 Offset: 0x27EF081 VA: 0x27EEF80
	|-Dictionary.KeyCollection<int, EffectDataTable>..ctor
	|
	|-RVA: 0x27EF960 Offset: 0x27EFA61 VA: 0x27EF960
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x27F0340 Offset: 0x27F0441 VA: 0x27F0340
	|-Dictionary.KeyCollection<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x27F0D20 Offset: 0x27F0E21 VA: 0x27F0D20
	|-Dictionary.KeyCollection<int, MiningDataTable>..ctor
	|
	|-RVA: 0x27F1700 Offset: 0x27F1801 VA: 0x27F1700
	|-Dictionary.KeyCollection<int, bool>..ctor
	|
	|-RVA: 0x27F20E0 Offset: 0x27F21E1 VA: 0x27F20E0
	|-Dictionary.KeyCollection<int, char>..ctor
	|
	|-RVA: 0x27F2AC0 Offset: 0x27F2BC1 VA: 0x27F2AC0
	|-Dictionary.KeyCollection<int, int>..ctor
	|
	|-RVA: 0x27F34A0 Offset: 0x27F35A1 VA: 0x27F34A0
	|-Dictionary.KeyCollection<int, Int32Enum>..ctor
	|
	|-RVA: 0x27F3E80 Offset: 0x27F3F81 VA: 0x27F3E80
	|-Dictionary.KeyCollection<int, long>..ctor
	|
	|-RVA: 0x27F4860 Offset: 0x27F4961 VA: 0x27F4860
	|-Dictionary.KeyCollection<int, object>..ctor
	|
	|-RVA: 0x27F5240 Offset: 0x27F5341 VA: 0x27F5240
	|-Dictionary.KeyCollection<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x27F5C20 Offset: 0x27F5D21 VA: 0x27F5C20
	|-Dictionary.KeyCollection<int, SceneInstance>..ctor
	|
	|-RVA: 0x27F6600 Offset: 0x27F6701 VA: 0x27F6600
	|-Dictionary.KeyCollection<int, Vector2Int>..ctor
	|
	|-RVA: 0x27F6FE0 Offset: 0x27F70E1 VA: 0x27F6FE0
	|-Dictionary.KeyCollection<int, Vector3>..ctor
	|
	|-RVA: 0x27F79C0 Offset: 0x27F7AC1 VA: 0x27F79C0
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x27F83A0 Offset: 0x27F84A1 VA: 0x27F83A0
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x29D70A0 Offset: 0x29D71A1 VA: 0x29D70A0
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x29D7A80 Offset: 0x29D7B81 VA: 0x29D7A80
	|-Dictionary.KeyCollection<Int32Enum, bool>..ctor
	|
	|-RVA: 0x29D8460 Offset: 0x29D8561 VA: 0x29D8460
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x29D8E40 Offset: 0x29D8F41 VA: 0x29D8E40
	|-Dictionary.KeyCollection<Int32Enum, int>..ctor
	|
	|-RVA: 0x29D9820 Offset: 0x29D9921 VA: 0x29D9820
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x29DA200 Offset: 0x29DA301 VA: 0x29DA200
	|-Dictionary.KeyCollection<Int32Enum, object>..ctor
	|
	|-RVA: 0x29DABE0 Offset: 0x29DACE1 VA: 0x29DABE0
	|-Dictionary.KeyCollection<Int32Enum, float>..ctor
	|
	|-RVA: 0x29DB5C0 Offset: 0x29DB6C1 VA: 0x29DB5C0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x29DBFA0 Offset: 0x29DC0A1 VA: 0x29DBFA0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x29DC980 Offset: 0x29DCA81 VA: 0x29DC980
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x29DD360 Offset: 0x29DD461 VA: 0x29DD360
	|-Dictionary.KeyCollection<long, object>..ctor
	|
	|-RVA: 0x29DDD40 Offset: 0x29DDE41 VA: 0x29DDD40
	|-Dictionary.KeyCollection<Memory<object>, object>..ctor
	|
	|-RVA: 0x29DE740 Offset: 0x29DE841 VA: 0x29DE740
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x29DF120 Offset: 0x29DF221 VA: 0x29DF120
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x29DFBD0 Offset: 0x29DFCD1 VA: 0x29DFBD0
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x29E0680 Offset: 0x29E0781 VA: 0x29E0680
	|-Dictionary.KeyCollection<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x29E1060 Offset: 0x29E1161 VA: 0x29E1060
	|-Dictionary.KeyCollection<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x29E1AD0 Offset: 0x29E1BD1 VA: 0x29E1AD0
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x29E24C0 Offset: 0x29E25C1 VA: 0x29E24C0
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x29E2F30 Offset: 0x29E3031 VA: 0x29E2F30
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x29E39B0 Offset: 0x29E3AB1 VA: 0x29E39B0
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x29E4390 Offset: 0x29E4491 VA: 0x29E4390
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x29E4EF0 Offset: 0x29E4FF1 VA: 0x29E4EF0
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x29E5960 Offset: 0x29E5A61 VA: 0x29E5960
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x29E6350 Offset: 0x29E6451 VA: 0x29E6350
	|-Dictionary.KeyCollection<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x29E6DC0 Offset: 0x29E6EC1 VA: 0x29E6DC0
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x29E7830 Offset: 0x29E7931 VA: 0x29E7830
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x29E8220 Offset: 0x29E8321 VA: 0x29E8220
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x29E8C10 Offset: 0x29E8D11 VA: 0x29E8C10
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x29E9600 Offset: 0x29E9701 VA: 0x29E9600
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x29E9FF0 Offset: 0x29EA0F1 VA: 0x29E9FF0
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x29EAA60 Offset: 0x29EAB61 VA: 0x29EAA60
	|-Dictionary.KeyCollection<object, BitVector32Int>..ctor
	|
	|-RVA: 0x29EB410 Offset: 0x29EB511 VA: 0x29EB410
	|-Dictionary.KeyCollection<object, EventCheckId>..ctor
	|
	|-RVA: 0x29EBDC0 Offset: 0x29EBEC1 VA: 0x29EBDC0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x29EC770 Offset: 0x29EC871 VA: 0x29EC770
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x29ED120 Offset: 0x29ED221 VA: 0x29ED120
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x29AA720 Offset: 0x29AA821 VA: 0x29AA720
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x29AB0D0 Offset: 0x29AB1D1 VA: 0x29AB0D0
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x29ABA80 Offset: 0x29ABB81 VA: 0x29ABA80
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x29AC430 Offset: 0x29AC531 VA: 0x29AC430
	|-Dictionary.KeyCollection<object, OrderSaveData>..ctor
	|
	|-RVA: 0x29ACDE0 Offset: 0x29ACEE1 VA: 0x29ACDE0
	|-Dictionary.KeyCollection<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x29AD790 Offset: 0x29AD891 VA: 0x29AD790
	|-Dictionary.KeyCollection<object, Parameter>..ctor
	|
	|-RVA: 0x29AE140 Offset: 0x29AE241 VA: 0x29AE140
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x29AEAF0 Offset: 0x29AEBF1 VA: 0x29AEAF0
	|-Dictionary.KeyCollection<object, bool>..ctor
	|
	|-RVA: 0x29AF4A0 Offset: 0x29AF5A1 VA: 0x29AF4A0
	|-Dictionary.KeyCollection<object, byte>..ctor
	|
	|-RVA: 0x29AFE50 Offset: 0x29AFF51 VA: 0x29AFE50
	|-Dictionary.KeyCollection<object, char>..ctor
	|
	|-RVA: 0x29B0800 Offset: 0x29B0901 VA: 0x29B0800
	|-Dictionary.KeyCollection<object, DateTime>..ctor
	|
	|-RVA: 0x29B11B0 Offset: 0x29B12B1 VA: 0x29B11B0
	|-Dictionary.KeyCollection<object, double>..ctor
	|
	|-RVA: 0x29B1B60 Offset: 0x29B1C61 VA: 0x29B1B60
	|-Dictionary.KeyCollection<object, short>..ctor
	|
	|-RVA: 0x29B2510 Offset: 0x29B2611 VA: 0x29B2510
	|-Dictionary.KeyCollection<object, int>..ctor
	|
	|-RVA: 0x29B2EC0 Offset: 0x29B2FC1 VA: 0x29B2EC0
	|-Dictionary.KeyCollection<object, Int32Enum>..ctor
	|
	|-RVA: 0x29B3870 Offset: 0x29B3971 VA: 0x29B3870
	|-Dictionary.KeyCollection<object, long>..ctor
	|
	|-RVA: 0x29B4220 Offset: 0x29B4321 VA: 0x29B4220
	|-Dictionary.KeyCollection<object, Memory<object>>..ctor
	|
	|-RVA: 0x29B4BD0 Offset: 0x29B4CD1 VA: 0x29B4BD0
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x29B5580 Offset: 0x29B5681 VA: 0x29B5580
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x29B5F30 Offset: 0x29B6031 VA: 0x29B5F30
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x29B68E0 Offset: 0x29B69E1 VA: 0x29B68E0
	|-Dictionary.KeyCollection<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x29B7290 Offset: 0x29B7391 VA: 0x29B7290
	|-Dictionary.KeyCollection<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x29B7C40 Offset: 0x29B7D41 VA: 0x29B7C40
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x29B85F0 Offset: 0x29B86F1 VA: 0x29B85F0
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x29B8FA0 Offset: 0x29B90A1 VA: 0x29B8FA0
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x29B9950 Offset: 0x29B9A51 VA: 0x29B9950
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x29BA300 Offset: 0x29BA401 VA: 0x29BA300
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x29BACB0 Offset: 0x29BADB1 VA: 0x29BACB0
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x29BB660 Offset: 0x29BB761 VA: 0x29BB660
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x29BC010 Offset: 0x29BC111 VA: 0x29BC010
	|-Dictionary.KeyCollection<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x29BC9C0 Offset: 0x29BCAC1 VA: 0x29BC9C0
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x29BD370 Offset: 0x29BD471 VA: 0x29BD370
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x29BDD20 Offset: 0x29BDE21 VA: 0x29BDD20
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x29BE6D0 Offset: 0x29BE7D1 VA: 0x29BE6D0
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x29BF080 Offset: 0x29BF181 VA: 0x29BF080
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x29BFA30 Offset: 0x29BFB31 VA: 0x29BFA30
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x29C03E0 Offset: 0x29C04E1 VA: 0x29C03E0
	|-Dictionary.KeyCollection<object, object>..ctor
	|
	|-RVA: 0x2A3BED0 Offset: 0x2A3BFD1 VA: 0x2A3BED0
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x2A3C880 Offset: 0x2A3C981 VA: 0x2A3C880
	|-Dictionary.KeyCollection<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2A3D230 Offset: 0x2A3D331 VA: 0x2A3D230
	|-Dictionary.KeyCollection<object, sbyte>..ctor
	|
	|-RVA: 0x2A3DBE0 Offset: 0x2A3DCE1 VA: 0x2A3DBE0
	|-Dictionary.KeyCollection<object, float>..ctor
	|
	|-RVA: 0x2A3E590 Offset: 0x2A3E691 VA: 0x2A3E590
	|-Dictionary.KeyCollection<object, ushort>..ctor
	|
	|-RVA: 0x2A3EF40 Offset: 0x2A3F041 VA: 0x2A3EF40
	|-Dictionary.KeyCollection<object, uint>..ctor
	|
	|-RVA: 0x2A3F8F0 Offset: 0x2A3F9F1 VA: 0x2A3F8F0
	|-Dictionary.KeyCollection<object, ulong>..ctor
	|
	|-RVA: 0x2A402A0 Offset: 0x2A403A1 VA: 0x2A402A0
	|-Dictionary.KeyCollection<object, TransitionTables>..ctor
	|
	|-RVA: 0x2A40C50 Offset: 0x2A40D51 VA: 0x2A40C50
	|-Dictionary.KeyCollection<object, Bounds>..ctor
	|
	|-RVA: 0x2A41600 Offset: 0x2A41701 VA: 0x2A41600
	|-Dictionary.KeyCollection<object, BoundsInt>..ctor
	|
	|-RVA: 0x2A41FB0 Offset: 0x2A420B1 VA: 0x2A41FB0
	|-Dictionary.KeyCollection<object, Color32>..ctor
	|
	|-RVA: 0x2A42960 Offset: 0x2A42A61 VA: 0x2A42960
	|-Dictionary.KeyCollection<object, Color>..ctor
	|
	|-RVA: 0x2A43310 Offset: 0x2A43411 VA: 0x2A43310
	|-Dictionary.KeyCollection<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x2A43CC0 Offset: 0x2A43DC1 VA: 0x2A43CC0
	|-Dictionary.KeyCollection<object, GradientColorKey>..ctor
	|
	|-RVA: 0x2A44670 Offset: 0x2A44771 VA: 0x2A44670
	|-Dictionary.KeyCollection<object, Keyframe>..ctor
	|
	|-RVA: 0x2A45020 Offset: 0x2A45121 VA: 0x2A45020
	|-Dictionary.KeyCollection<object, LayerMask>..ctor
	|
	|-RVA: 0x2A459D0 Offset: 0x2A45AD1 VA: 0x2A459D0
	|-Dictionary.KeyCollection<object, Matrix4x4>..ctor
	|
	|-RVA: 0x2A46380 Offset: 0x2A46481 VA: 0x2A46380
	|-Dictionary.KeyCollection<object, Playable>..ctor
	|
	|-RVA: 0x2A46D30 Offset: 0x2A46E31 VA: 0x2A46D30
	|-Dictionary.KeyCollection<object, Quaternion>..ctor
	|
	|-RVA: 0x2A476E0 Offset: 0x2A477E1 VA: 0x2A476E0
	|-Dictionary.KeyCollection<object, RangeInt>..ctor
	|
	|-RVA: 0x2A48090 Offset: 0x2A48191 VA: 0x2A48090
	|-Dictionary.KeyCollection<object, Rect>..ctor
	|
	|-RVA: 0x2A48A40 Offset: 0x2A48B41 VA: 0x2A48A40
	|-Dictionary.KeyCollection<object, RectInt>..ctor
	|
	|-RVA: 0x2A493F0 Offset: 0x2A494F1 VA: 0x2A493F0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2A49DA0 Offset: 0x2A49EA1 VA: 0x2A49DA0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2A4A750 Offset: 0x2A4A851 VA: 0x2A4A750
	|-Dictionary.KeyCollection<object, Vector2>..ctor
	|
	|-RVA: 0x2A4B100 Offset: 0x2A4B201 VA: 0x2A4B100
	|-Dictionary.KeyCollection<object, Vector2Int>..ctor
	|
	|-RVA: 0x2A4BAB0 Offset: 0x2A4BBB1 VA: 0x2A4BAB0
	|-Dictionary.KeyCollection<object, Vector3>..ctor
	|
	|-RVA: 0x2A4C460 Offset: 0x2A4C561 VA: 0x2A4C460
	|-Dictionary.KeyCollection<object, Vector3Int>..ctor
	|
	|-RVA: 0x2A4CE10 Offset: 0x2A4CF11 VA: 0x2A4CE10
	|-Dictionary.KeyCollection<object, Vector4>..ctor
	|
	|-RVA: 0x2A4D7C0 Offset: 0x2A4D8C1 VA: 0x2A4D7C0
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x2A4E1C0 Offset: 0x2A4E2C1 VA: 0x2A4E1C0
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2A4EBA0 Offset: 0x2A4ECA1 VA: 0x2A4EBA0
	|-Dictionary.KeyCollection<sbyte, object>..ctor
	|
	|-RVA: 0x2A4F580 Offset: 0x2A4F681 VA: 0x2A4F580
	|-Dictionary.KeyCollection<float, CurveSample>..ctor
	|
	|-RVA: 0x2A4FF60 Offset: 0x2A50061 VA: 0x2A4FF60
	|-Dictionary.KeyCollection<float, object>..ctor
	|
	|-RVA: 0x2A50940 Offset: 0x2A50A41 VA: 0x2A50940
	|-Dictionary.KeyCollection<ushort, object>..ctor
	|
	|-RVA: 0x2A51320 Offset: 0x2A51421 VA: 0x2A51320
	|-Dictionary.KeyCollection<uint, int>..ctor
	|
	|-RVA: 0x2A51D00 Offset: 0x2A51E01 VA: 0x2A51D00
	|-Dictionary.KeyCollection<uint, Int32Enum>..ctor
	|
	|-RVA: 0x2776E60 Offset: 0x2776F61 VA: 0x2776E60
	|-Dictionary.KeyCollection<uint, object>..ctor
	|
	|-RVA: 0x2777840 Offset: 0x2777941 VA: 0x2777840
	|-Dictionary.KeyCollection<ulong, object>..ctor
	|
	|-RVA: 0x2778220 Offset: 0x2778321 VA: 0x2778220
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x2778C00 Offset: 0x2778D01 VA: 0x2778C00
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x27795E0 Offset: 0x27796E1 VA: 0x27795E0
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x2779FC0 Offset: 0x277A0C1 VA: 0x2779FC0
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x277A9A0 Offset: 0x277AAA1 VA: 0x277A9A0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x277B380 Offset: 0x277B481 VA: 0x277B380
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x277BD60 Offset: 0x277BE61 VA: 0x277BD60
	|-Dictionary.KeyCollection<Bounds, object>..ctor
	|
	|-RVA: 0x277C7D0 Offset: 0x277C8D1 VA: 0x277C7D0
	|-Dictionary.KeyCollection<BoundsInt, object>..ctor
	|
	|-RVA: 0x277D240 Offset: 0x277D341 VA: 0x277D240
	|-Dictionary.KeyCollection<Color, object>..ctor
	|
	|-RVA: 0x277DC30 Offset: 0x277DD31 VA: 0x277DC30
	|-Dictionary.KeyCollection<Color32, object>..ctor
	|
	|-RVA: 0x277E610 Offset: 0x277E711 VA: 0x277E610
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x277EFF0 Offset: 0x277F0F1 VA: 0x277EFF0
	|-Dictionary.KeyCollection<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x277F9E0 Offset: 0x277FAE1 VA: 0x277F9E0
	|-Dictionary.KeyCollection<GradientColorKey, object>..ctor
	|
	|-RVA: 0x2780450 Offset: 0x2780551 VA: 0x2780450
	|-Dictionary.KeyCollection<Keyframe, object>..ctor
	|
	|-RVA: 0x2780F00 Offset: 0x2781001 VA: 0x2780F00
	|-Dictionary.KeyCollection<LayerMask, object>..ctor
	|
	|-RVA: 0x27818E0 Offset: 0x27819E1 VA: 0x27818E0
	|-Dictionary.KeyCollection<Matrix4x4, object>..ctor
	|
	|-RVA: 0x27823D0 Offset: 0x27824D1 VA: 0x27823D0
	|-Dictionary.KeyCollection<IntVec3, object>..ctor
	|
	|-RVA: 0x2782DC0 Offset: 0x2782EC1 VA: 0x2782DC0
	|-Dictionary.KeyCollection<Quaternion, object>..ctor
	|
	|-RVA: 0x27837B0 Offset: 0x27838B1 VA: 0x27837B0
	|-Dictionary.KeyCollection<RangeInt, object>..ctor
	|
	|-RVA: 0x2784190 Offset: 0x2784291 VA: 0x2784190
	|-Dictionary.KeyCollection<Rect, object>..ctor
	|
	|-RVA: 0x2784B80 Offset: 0x2784C81 VA: 0x2784B80
	|-Dictionary.KeyCollection<RectInt, object>..ctor
	|
	|-RVA: 0x2785570 Offset: 0x2785671 VA: 0x2785570
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x2785F50 Offset: 0x2786051 VA: 0x2785F50
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x2786930 Offset: 0x2786A31 VA: 0x2786930
	|-Dictionary.KeyCollection<Vector2, object>..ctor
	|
	|-RVA: 0x2787320 Offset: 0x2787421 VA: 0x2787320
	|-Dictionary.KeyCollection<Vector2Int, object>..ctor
	|
	|-RVA: 0x2787D00 Offset: 0x2787E01 VA: 0x2787D00
	|-Dictionary.KeyCollection<Vector3, object>..ctor
	|
	|-RVA: 0x27886F0 Offset: 0x27887F1 VA: 0x27886F0
	|-Dictionary.KeyCollection<Vector3Int, object>..ctor
	|
	|-RVA: 0x27890E0 Offset: 0x27891E1 VA: 0x27890E0
	|-Dictionary.KeyCollection<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E2460 Offset: 0x27E2561 VA: 0x27E2460
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, List<int>>.GetEnumerator
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.GetEnumerator
	|
	|-RVA: 0x29C0490 Offset: 0x29C0591 VA: 0x29C0490
	|-Dictionary.KeyCollection<BinaryDeserialization.ObjectFieldMap, List<int>>.GetEnumerator
	|-Dictionary.KeyCollection<Character, AvoidController>.GetEnumerator
	|-Dictionary.KeyCollection<Character, YawnController>.GetEnumerator
	|-Dictionary.KeyCollection<CharacterBase, MagicController>.GetEnumerator
	|-Dictionary.KeyCollection<CharacterBase, ThrottleController>.GetEnumerator
	|-Dictionary.KeyCollection<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.GetEnumerator
	|-Dictionary.KeyCollection<ParameterExpression, LocalVariable>.GetEnumerator
	|-Dictionary.KeyCollection<string, BoolKeyframeGroup>.GetEnumerator
	|-Dictionary.KeyCollection<string, ColorKeyframeGroup>.GetEnumerator
	|-Dictionary.KeyCollection<string, IKeyframeGroup>.GetEnumerator
	|-Dictionary.KeyCollection<string, NumberKeyframeGroup>.GetEnumerator
	|-Dictionary.KeyCollection<string, SpherePointKeyframeGroup>.GetEnumerator
	|-Dictionary.KeyCollection<string, TextureKeyframeGroup>.GetEnumerator
	|-Dictionary.KeyCollection<Collider, CharacterBase>.GetEnumerator
	|-Dictionary.KeyCollection<object, object>.GetEnumerator
	|
	|-RVA: 0x2A3DC90 Offset: 0x2A3DD91 VA: 0x2A3DC90
	|-Dictionary.KeyCollection<Character, float>.GetEnumerator
	|-Dictionary.KeyCollection<object, float>.GetEnumerator
	|
	|-RVA: 0x29DA2B0 Offset: 0x29DA3B1 VA: 0x29DA2B0
	|-Dictionary.KeyCollection<ActorID, GrappleController>.GetEnumerator
	|-Dictionary.KeyCollection<ActorID, HandCuffsController>.GetEnumerator
	|-Dictionary.KeyCollection<ActorID, HumanStatusData>.GetEnumerator
	|-Dictionary.KeyCollection<ActorID, ItemStorageData>.GetEnumerator
	|-Dictionary.KeyCollection<ActorID, MobTravelerController>.GetEnumerator
	|-Dictionary.KeyCollection<ActorID, Dictionary<EquipSlotType, HumanEquipItem>>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, object>.GetEnumerator
	|
	|-RVA: 0x29D8EF0 Offset: 0x29D8FF1 VA: 0x29D8EF0
	|-Dictionary.KeyCollection<RF5SystemData.FLAG, int>.GetEnumerator
	|-Dictionary.KeyCollection<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x27F4910 Offset: 0x27F4A11 VA: 0x27F4910
	|-Dictionary.KeyCollection<int, Dictionary<int, List<OrderMasterData>>>.GetEnumerator
	|-Dictionary.KeyCollection<int, List<MeshDataConnectivity.Face>>.GetEnumerator
	|-Dictionary.KeyCollection<int, object>.GetEnumerator
	|
	|-RVA: 0x29B2F70 Offset: 0x29B3071 VA: 0x29B2F70
	|-Dictionary.KeyCollection<string, SystemLanguage>.GetEnumerator
	|-Dictionary.KeyCollection<object, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2776F10 Offset: 0x2777011 VA: 0x2776F10
	|-Dictionary.KeyCollection<uint, FriendMonsterStatus>.GetEnumerator
	|-Dictionary.KeyCollection<uint, object>.GetEnumerator
	|
	|-RVA: 0x277E6C0 Offset: 0x277E7C1 VA: 0x277E6C0
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, Terrain>.GetEnumerator
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.GetEnumerator
	|
	|-RVA: 0x27E2E60 Offset: 0x27E2F61 VA: 0x27E2E60
	|-Dictionary.KeyCollection<BitVector32Int, object>.GetEnumerator
	|
	|-RVA: 0x27E3840 Offset: 0x27E3941 VA: 0x27E3840
	|-Dictionary.KeyCollection<EventCheckId, object>.GetEnumerator
	|
	|-RVA: 0x27E42C0 Offset: 0x27E43C1 VA: 0x27E42C0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.GetEnumerator
	|
	|-RVA: 0x27E4DD0 Offset: 0x27E4ED1 VA: 0x27E4DD0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.GetEnumerator
	|
	|-RVA: 0x27E5840 Offset: 0x27E5941 VA: 0x27E5840
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.GetEnumerator
	|
	|-RVA: 0x27E6230 Offset: 0x27E6331 VA: 0x27E6230
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.GetEnumerator
	|
	|-RVA: 0x27E6C20 Offset: 0x27E6D21 VA: 0x27E6C20
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.GetEnumerator
	|
	|-RVA: 0x27E76E0 Offset: 0x27E77E1 VA: 0x27E76E0
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.GetEnumerator
	|
	|-RVA: 0x27E80D0 Offset: 0x27E81D1 VA: 0x27E80D0
	|-Dictionary.KeyCollection<OrderSaveData, object>.GetEnumerator
	|
	|-RVA: 0x27E8B90 Offset: 0x27E8C91 VA: 0x27E8B90
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.GetEnumerator
	|
	|-RVA: 0x27E9610 Offset: 0x27E9711 VA: 0x27E9610
	|-Dictionary.KeyCollection<Parameter, object>.GetEnumerator
	|
	|-RVA: 0x27EA120 Offset: 0x27EA221 VA: 0x27EA120
	|-Dictionary.KeyCollection<bool, object>.GetEnumerator
	|
	|-RVA: 0x27EAB00 Offset: 0x27EAC01 VA: 0x27EAB00
	|-Dictionary.KeyCollection<byte, object>.GetEnumerator
	|
	|-RVA: 0x27EB4E0 Offset: 0x27EB5E1 VA: 0x27EB4E0
	|-Dictionary.KeyCollection<char, object>.GetEnumerator
	|
	|-RVA: 0x27EBEC0 Offset: 0x27EBFC1 VA: 0x27EBEC0
	|-Dictionary.KeyCollection<DateTime, object>.GetEnumerator
	|
	|-RVA: 0x27EC8A0 Offset: 0x27EC9A1 VA: 0x27EC8A0
	|-Dictionary.KeyCollection<double, object>.GetEnumerator
	|
	|-RVA: 0x27ED280 Offset: 0x27ED381 VA: 0x27ED280
	|-Dictionary.KeyCollection<Guid, object>.GetEnumerator
	|
	|-RVA: 0x27EDC70 Offset: 0x27EDD71 VA: 0x27EDC70
	|-Dictionary.KeyCollection<short, object>.GetEnumerator
	|
	|-RVA: 0x27EE650 Offset: 0x27EE751 VA: 0x27EE650
	|-Dictionary.KeyCollection<int, CropDataTable>.GetEnumerator
	|
	|-RVA: 0x27EF030 Offset: 0x27EF131 VA: 0x27EF030
	|-Dictionary.KeyCollection<int, EffectDataTable>.GetEnumerator
	|
	|-RVA: 0x27EFA10 Offset: 0x27EFB11 VA: 0x27EFA10
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.GetEnumerator
	|
	|-RVA: 0x27F03F0 Offset: 0x27F04F1 VA: 0x27F03F0
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.GetEnumerator
	|
	|-RVA: 0x27F0DD0 Offset: 0x27F0ED1 VA: 0x27F0DD0
	|-Dictionary.KeyCollection<int, MiningDataTable>.GetEnumerator
	|
	|-RVA: 0x27F17B0 Offset: 0x27F18B1 VA: 0x27F17B0
	|-Dictionary.KeyCollection<int, bool>.GetEnumerator
	|
	|-RVA: 0x27F2190 Offset: 0x27F2291 VA: 0x27F2190
	|-Dictionary.KeyCollection<int, char>.GetEnumerator
	|
	|-RVA: 0x27F2B70 Offset: 0x27F2C71 VA: 0x27F2B70
	|-Dictionary.KeyCollection<int, int>.GetEnumerator
	|
	|-RVA: 0x27F3550 Offset: 0x27F3651 VA: 0x27F3550
	|-Dictionary.KeyCollection<int, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x27F3F30 Offset: 0x27F4031 VA: 0x27F3F30
	|-Dictionary.KeyCollection<int, long>.GetEnumerator
	|
	|-RVA: 0x27F52F0 Offset: 0x27F53F1 VA: 0x27F52F0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x27F5CD0 Offset: 0x27F5DD1 VA: 0x27F5CD0
	|-Dictionary.KeyCollection<int, SceneInstance>.GetEnumerator
	|
	|-RVA: 0x27F66B0 Offset: 0x27F67B1 VA: 0x27F66B0
	|-Dictionary.KeyCollection<int, Vector2Int>.GetEnumerator
	|
	|-RVA: 0x27F7090 Offset: 0x27F7191 VA: 0x27F7090
	|-Dictionary.KeyCollection<int, Vector3>.GetEnumerator
	|
	|-RVA: 0x27F7A70 Offset: 0x27F7B71 VA: 0x27F7A70
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.GetEnumerator
	|
	|-RVA: 0x27F8450 Offset: 0x27F8551 VA: 0x27F8450
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.GetEnumerator
	|
	|-RVA: 0x29D7150 Offset: 0x29D7251 VA: 0x29D7150
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.GetEnumerator
	|
	|-RVA: 0x29D7B30 Offset: 0x29D7C31 VA: 0x29D7B30
	|-Dictionary.KeyCollection<Int32Enum, bool>.GetEnumerator
	|
	|-RVA: 0x29D8510 Offset: 0x29D8611 VA: 0x29D8510
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x29D98D0 Offset: 0x29D99D1 VA: 0x29D98D0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x29DAC90 Offset: 0x29DAD91 VA: 0x29DAC90
	|-Dictionary.KeyCollection<Int32Enum, float>.GetEnumerator
	|
	|-RVA: 0x29DB670 Offset: 0x29DB771 VA: 0x29DB670
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.GetEnumerator
	|
	|-RVA: 0x29DC050 Offset: 0x29DC151 VA: 0x29DC050
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.GetEnumerator
	|
	|-RVA: 0x29DCA30 Offset: 0x29DCB31 VA: 0x29DCA30
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.GetEnumerator
	|
	|-RVA: 0x29DD410 Offset: 0x29DD511 VA: 0x29DD410
	|-Dictionary.KeyCollection<long, object>.GetEnumerator
	|
	|-RVA: 0x29DDDF0 Offset: 0x29DDEF1 VA: 0x29DDDF0
	|-Dictionary.KeyCollection<Memory<object>, object>.GetEnumerator
	|
	|-RVA: 0x29DE7F0 Offset: 0x29DE8F1 VA: 0x29DE7F0
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.GetEnumerator
	|
	|-RVA: 0x29DF1D0 Offset: 0x29DF2D1 VA: 0x29DF1D0
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.GetEnumerator
	|
	|-RVA: 0x29DFC80 Offset: 0x29DFD81 VA: 0x29DFC80
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.GetEnumerator
	|
	|-RVA: 0x29E0730 Offset: 0x29E0831 VA: 0x29E0730
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.GetEnumerator
	|
	|-RVA: 0x29E1110 Offset: 0x29E1211 VA: 0x29E1110
	|-Dictionary.KeyCollection<Nullable<Color>, object>.GetEnumerator
	|
	|-RVA: 0x29E1B80 Offset: 0x29E1C81 VA: 0x29E1B80
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.GetEnumerator
	|
	|-RVA: 0x29E2570 Offset: 0x29E2671 VA: 0x29E2570
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.GetEnumerator
	|
	|-RVA: 0x29E2FE0 Offset: 0x29E30E1 VA: 0x29E2FE0
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.GetEnumerator
	|
	|-RVA: 0x29E3A60 Offset: 0x29E3B61 VA: 0x29E3A60
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.GetEnumerator
	|
	|-RVA: 0x29E4440 Offset: 0x29E4541 VA: 0x29E4440
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.GetEnumerator
	|
	|-RVA: 0x29E4FA0 Offset: 0x29E50A1 VA: 0x29E4FA0
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.GetEnumerator
	|
	|-RVA: 0x29E5A10 Offset: 0x29E5B11 VA: 0x29E5A10
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.GetEnumerator
	|
	|-RVA: 0x29E6400 Offset: 0x29E6501 VA: 0x29E6400
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.GetEnumerator
	|
	|-RVA: 0x29E6E70 Offset: 0x29E6F71 VA: 0x29E6E70
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.GetEnumerator
	|
	|-RVA: 0x29E78E0 Offset: 0x29E79E1 VA: 0x29E78E0
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.GetEnumerator
	|
	|-RVA: 0x29E82D0 Offset: 0x29E83D1 VA: 0x29E82D0
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.GetEnumerator
	|
	|-RVA: 0x29E8CC0 Offset: 0x29E8DC1 VA: 0x29E8CC0
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.GetEnumerator
	|
	|-RVA: 0x29E96B0 Offset: 0x29E97B1 VA: 0x29E96B0
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.GetEnumerator
	|
	|-RVA: 0x29EA0A0 Offset: 0x29EA1A1 VA: 0x29EA0A0
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.GetEnumerator
	|
	|-RVA: 0x29EAB10 Offset: 0x29EAC11 VA: 0x29EAB10
	|-Dictionary.KeyCollection<object, BitVector32Int>.GetEnumerator
	|
	|-RVA: 0x29EB4C0 Offset: 0x29EB5C1 VA: 0x29EB4C0
	|-Dictionary.KeyCollection<object, EventCheckId>.GetEnumerator
	|
	|-RVA: 0x29EBE70 Offset: 0x29EBF71 VA: 0x29EBE70
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.GetEnumerator
	|
	|-RVA: 0x29EC820 Offset: 0x29EC921 VA: 0x29EC820
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.GetEnumerator
	|
	|-RVA: 0x29ED1D0 Offset: 0x29ED2D1 VA: 0x29ED1D0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.GetEnumerator
	|
	|-RVA: 0x29AA7D0 Offset: 0x29AA8D1 VA: 0x29AA7D0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.GetEnumerator
	|
	|-RVA: 0x29AB180 Offset: 0x29AB281 VA: 0x29AB180
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.GetEnumerator
	|
	|-RVA: 0x29ABB30 Offset: 0x29ABC31 VA: 0x29ABB30
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.GetEnumerator
	|
	|-RVA: 0x29AC4E0 Offset: 0x29AC5E1 VA: 0x29AC4E0
	|-Dictionary.KeyCollection<object, OrderSaveData>.GetEnumerator
	|
	|-RVA: 0x29ACE90 Offset: 0x29ACF91 VA: 0x29ACE90
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.GetEnumerator
	|
	|-RVA: 0x29AD840 Offset: 0x29AD941 VA: 0x29AD840
	|-Dictionary.KeyCollection<object, Parameter>.GetEnumerator
	|
	|-RVA: 0x29AE1F0 Offset: 0x29AE2F1 VA: 0x29AE1F0
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.GetEnumerator
	|
	|-RVA: 0x29AEBA0 Offset: 0x29AECA1 VA: 0x29AEBA0
	|-Dictionary.KeyCollection<object, bool>.GetEnumerator
	|
	|-RVA: 0x29AF550 Offset: 0x29AF651 VA: 0x29AF550
	|-Dictionary.KeyCollection<object, byte>.GetEnumerator
	|
	|-RVA: 0x29AFF00 Offset: 0x29B0001 VA: 0x29AFF00
	|-Dictionary.KeyCollection<object, char>.GetEnumerator
	|
	|-RVA: 0x29B08B0 Offset: 0x29B09B1 VA: 0x29B08B0
	|-Dictionary.KeyCollection<object, DateTime>.GetEnumerator
	|
	|-RVA: 0x29B1260 Offset: 0x29B1361 VA: 0x29B1260
	|-Dictionary.KeyCollection<object, double>.GetEnumerator
	|
	|-RVA: 0x29B1C10 Offset: 0x29B1D11 VA: 0x29B1C10
	|-Dictionary.KeyCollection<object, short>.GetEnumerator
	|
	|-RVA: 0x29B25C0 Offset: 0x29B26C1 VA: 0x29B25C0
	|-Dictionary.KeyCollection<object, int>.GetEnumerator
	|
	|-RVA: 0x29B3920 Offset: 0x29B3A21 VA: 0x29B3920
	|-Dictionary.KeyCollection<object, long>.GetEnumerator
	|
	|-RVA: 0x29B42D0 Offset: 0x29B43D1 VA: 0x29B42D0
	|-Dictionary.KeyCollection<object, Memory<object>>.GetEnumerator
	|
	|-RVA: 0x29B4C80 Offset: 0x29B4D81 VA: 0x29B4C80
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x29B5630 Offset: 0x29B5731 VA: 0x29B5630
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.GetEnumerator
	|
	|-RVA: 0x29B5FE0 Offset: 0x29B60E1 VA: 0x29B5FE0
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.GetEnumerator
	|
	|-RVA: 0x29B6990 Offset: 0x29B6A91 VA: 0x29B6990
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.GetEnumerator
	|
	|-RVA: 0x29B7340 Offset: 0x29B7441 VA: 0x29B7340
	|-Dictionary.KeyCollection<object, Nullable<Color>>.GetEnumerator
	|
	|-RVA: 0x29B7CF0 Offset: 0x29B7DF1 VA: 0x29B7CF0
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.GetEnumerator
	|
	|-RVA: 0x29B86A0 Offset: 0x29B87A1 VA: 0x29B86A0
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.GetEnumerator
	|
	|-RVA: 0x29B9050 Offset: 0x29B9151 VA: 0x29B9050
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.GetEnumerator
	|
	|-RVA: 0x29B9A00 Offset: 0x29B9B01 VA: 0x29B9A00
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.GetEnumerator
	|
	|-RVA: 0x29BA3B0 Offset: 0x29BA4B1 VA: 0x29BA3B0
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.GetEnumerator
	|
	|-RVA: 0x29BAD60 Offset: 0x29BAE61 VA: 0x29BAD60
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.GetEnumerator
	|
	|-RVA: 0x29BB710 Offset: 0x29BB811 VA: 0x29BB710
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.GetEnumerator
	|
	|-RVA: 0x29BC0C0 Offset: 0x29BC1C1 VA: 0x29BC0C0
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.GetEnumerator
	|
	|-RVA: 0x29BCA70 Offset: 0x29BCB71 VA: 0x29BCA70
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.GetEnumerator
	|
	|-RVA: 0x29BD420 Offset: 0x29BD521 VA: 0x29BD420
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.GetEnumerator
	|
	|-RVA: 0x29BDDD0 Offset: 0x29BDED1 VA: 0x29BDDD0
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.GetEnumerator
	|
	|-RVA: 0x29BE780 Offset: 0x29BE881 VA: 0x29BE780
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.GetEnumerator
	|
	|-RVA: 0x29BF130 Offset: 0x29BF231 VA: 0x29BF130
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.GetEnumerator
	|
	|-RVA: 0x29BFAE0 Offset: 0x29BFBE1 VA: 0x29BFAE0
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.GetEnumerator
	|
	|-RVA: 0x2A3BF80 Offset: 0x2A3C081 VA: 0x2A3BF80
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.GetEnumerator
	|
	|-RVA: 0x2A3C930 Offset: 0x2A3CA31 VA: 0x2A3C930
	|-Dictionary.KeyCollection<object, ResourceLocator>.GetEnumerator
	|
	|-RVA: 0x2A3D2E0 Offset: 0x2A3D3E1 VA: 0x2A3D2E0
	|-Dictionary.KeyCollection<object, sbyte>.GetEnumerator
	|
	|-RVA: 0x2A3E640 Offset: 0x2A3E741 VA: 0x2A3E640
	|-Dictionary.KeyCollection<object, ushort>.GetEnumerator
	|
	|-RVA: 0x2A3EFF0 Offset: 0x2A3F0F1 VA: 0x2A3EFF0
	|-Dictionary.KeyCollection<object, uint>.GetEnumerator
	|
	|-RVA: 0x2A3F9A0 Offset: 0x2A3FAA1 VA: 0x2A3F9A0
	|-Dictionary.KeyCollection<object, ulong>.GetEnumerator
	|
	|-RVA: 0x2A40350 Offset: 0x2A40451 VA: 0x2A40350
	|-Dictionary.KeyCollection<object, TransitionTables>.GetEnumerator
	|
	|-RVA: 0x2A40D00 Offset: 0x2A40E01 VA: 0x2A40D00
	|-Dictionary.KeyCollection<object, Bounds>.GetEnumerator
	|
	|-RVA: 0x2A416B0 Offset: 0x2A417B1 VA: 0x2A416B0
	|-Dictionary.KeyCollection<object, BoundsInt>.GetEnumerator
	|
	|-RVA: 0x2A42060 Offset: 0x2A42161 VA: 0x2A42060
	|-Dictionary.KeyCollection<object, Color32>.GetEnumerator
	|
	|-RVA: 0x2A42A10 Offset: 0x2A42B11 VA: 0x2A42A10
	|-Dictionary.KeyCollection<object, Color>.GetEnumerator
	|
	|-RVA: 0x2A433C0 Offset: 0x2A434C1 VA: 0x2A433C0
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.GetEnumerator
	|
	|-RVA: 0x2A43D70 Offset: 0x2A43E71 VA: 0x2A43D70
	|-Dictionary.KeyCollection<object, GradientColorKey>.GetEnumerator
	|
	|-RVA: 0x2A44720 Offset: 0x2A44821 VA: 0x2A44720
	|-Dictionary.KeyCollection<object, Keyframe>.GetEnumerator
	|
	|-RVA: 0x2A450D0 Offset: 0x2A451D1 VA: 0x2A450D0
	|-Dictionary.KeyCollection<object, LayerMask>.GetEnumerator
	|
	|-RVA: 0x2A45A80 Offset: 0x2A45B81 VA: 0x2A45A80
	|-Dictionary.KeyCollection<object, Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x2A46430 Offset: 0x2A46531 VA: 0x2A46430
	|-Dictionary.KeyCollection<object, Playable>.GetEnumerator
	|
	|-RVA: 0x2A46DE0 Offset: 0x2A46EE1 VA: 0x2A46DE0
	|-Dictionary.KeyCollection<object, Quaternion>.GetEnumerator
	|
	|-RVA: 0x2A47790 Offset: 0x2A47891 VA: 0x2A47790
	|-Dictionary.KeyCollection<object, RangeInt>.GetEnumerator
	|
	|-RVA: 0x2A48140 Offset: 0x2A48241 VA: 0x2A48140
	|-Dictionary.KeyCollection<object, Rect>.GetEnumerator
	|
	|-RVA: 0x2A48AF0 Offset: 0x2A48BF1 VA: 0x2A48AF0
	|-Dictionary.KeyCollection<object, RectInt>.GetEnumerator
	|
	|-RVA: 0x2A494A0 Offset: 0x2A495A1 VA: 0x2A494A0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x2A49E50 Offset: 0x2A49F51 VA: 0x2A49E50
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.GetEnumerator
	|
	|-RVA: 0x2A4A800 Offset: 0x2A4A901 VA: 0x2A4A800
	|-Dictionary.KeyCollection<object, Vector2>.GetEnumerator
	|
	|-RVA: 0x2A4B1B0 Offset: 0x2A4B2B1 VA: 0x2A4B1B0
	|-Dictionary.KeyCollection<object, Vector2Int>.GetEnumerator
	|
	|-RVA: 0x2A4BB60 Offset: 0x2A4BC61 VA: 0x2A4BB60
	|-Dictionary.KeyCollection<object, Vector3>.GetEnumerator
	|
	|-RVA: 0x2A4C510 Offset: 0x2A4C611 VA: 0x2A4C510
	|-Dictionary.KeyCollection<object, Vector3Int>.GetEnumerator
	|
	|-RVA: 0x2A4CEC0 Offset: 0x2A4CFC1 VA: 0x2A4CEC0
	|-Dictionary.KeyCollection<object, Vector4>.GetEnumerator
	|
	|-RVA: 0x2A4D870 Offset: 0x2A4D971 VA: 0x2A4D870
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.GetEnumerator
	|
	|-RVA: 0x2A4E270 Offset: 0x2A4E371 VA: 0x2A4E270
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.GetEnumerator
	|
	|-RVA: 0x2A4EC50 Offset: 0x2A4ED51 VA: 0x2A4EC50
	|-Dictionary.KeyCollection<sbyte, object>.GetEnumerator
	|
	|-RVA: 0x2A4F630 Offset: 0x2A4F731 VA: 0x2A4F630
	|-Dictionary.KeyCollection<float, CurveSample>.GetEnumerator
	|
	|-RVA: 0x2A50010 Offset: 0x2A50111 VA: 0x2A50010
	|-Dictionary.KeyCollection<float, object>.GetEnumerator
	|
	|-RVA: 0x2A509F0 Offset: 0x2A50AF1 VA: 0x2A509F0
	|-Dictionary.KeyCollection<ushort, object>.GetEnumerator
	|
	|-RVA: 0x2A513D0 Offset: 0x2A514D1 VA: 0x2A513D0
	|-Dictionary.KeyCollection<uint, int>.GetEnumerator
	|
	|-RVA: 0x2A51DB0 Offset: 0x2A51EB1 VA: 0x2A51DB0
	|-Dictionary.KeyCollection<uint, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x27778F0 Offset: 0x27779F1 VA: 0x27778F0
	|-Dictionary.KeyCollection<ulong, object>.GetEnumerator
	|
	|-RVA: 0x27782D0 Offset: 0x27783D1 VA: 0x27782D0
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.GetEnumerator
	|
	|-RVA: 0x2778CB0 Offset: 0x2778DB1 VA: 0x2778CB0
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.GetEnumerator
	|
	|-RVA: 0x2779690 Offset: 0x2779791 VA: 0x2779690
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.GetEnumerator
	|
	|-RVA: 0x277A070 Offset: 0x277A171 VA: 0x277A070
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.GetEnumerator
	|
	|-RVA: 0x277AA50 Offset: 0x277AB51 VA: 0x277AA50
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.GetEnumerator
	|
	|-RVA: 0x277B430 Offset: 0x277B531 VA: 0x277B430
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.GetEnumerator
	|
	|-RVA: 0x277BE10 Offset: 0x277BF11 VA: 0x277BE10
	|-Dictionary.KeyCollection<Bounds, object>.GetEnumerator
	|
	|-RVA: 0x277C880 Offset: 0x277C981 VA: 0x277C880
	|-Dictionary.KeyCollection<BoundsInt, object>.GetEnumerator
	|
	|-RVA: 0x277D2F0 Offset: 0x277D3F1 VA: 0x277D2F0
	|-Dictionary.KeyCollection<Color, object>.GetEnumerator
	|
	|-RVA: 0x277DCE0 Offset: 0x277DDE1 VA: 0x277DCE0
	|-Dictionary.KeyCollection<Color32, object>.GetEnumerator
	|
	|-RVA: 0x277F0A0 Offset: 0x277F1A1 VA: 0x277F0A0
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.GetEnumerator
	|
	|-RVA: 0x277FA90 Offset: 0x277FB91 VA: 0x277FA90
	|-Dictionary.KeyCollection<GradientColorKey, object>.GetEnumerator
	|
	|-RVA: 0x2780500 Offset: 0x2780601 VA: 0x2780500
	|-Dictionary.KeyCollection<Keyframe, object>.GetEnumerator
	|
	|-RVA: 0x2780FB0 Offset: 0x27810B1 VA: 0x2780FB0
	|-Dictionary.KeyCollection<LayerMask, object>.GetEnumerator
	|
	|-RVA: 0x2781990 Offset: 0x2781A91 VA: 0x2781990
	|-Dictionary.KeyCollection<Matrix4x4, object>.GetEnumerator
	|
	|-RVA: 0x2782480 Offset: 0x2782581 VA: 0x2782480
	|-Dictionary.KeyCollection<IntVec3, object>.GetEnumerator
	|
	|-RVA: 0x2782E70 Offset: 0x2782F71 VA: 0x2782E70
	|-Dictionary.KeyCollection<Quaternion, object>.GetEnumerator
	|
	|-RVA: 0x2783860 Offset: 0x2783961 VA: 0x2783860
	|-Dictionary.KeyCollection<RangeInt, object>.GetEnumerator
	|
	|-RVA: 0x2784240 Offset: 0x2784341 VA: 0x2784240
	|-Dictionary.KeyCollection<Rect, object>.GetEnumerator
	|
	|-RVA: 0x2784C30 Offset: 0x2784D31 VA: 0x2784C30
	|-Dictionary.KeyCollection<RectInt, object>.GetEnumerator
	|
	|-RVA: 0x2785620 Offset: 0x2785721 VA: 0x2785620
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.GetEnumerator
	|
	|-RVA: 0x2786000 Offset: 0x2786101 VA: 0x2786000
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.GetEnumerator
	|
	|-RVA: 0x27869E0 Offset: 0x2786AE1 VA: 0x27869E0
	|-Dictionary.KeyCollection<Vector2, object>.GetEnumerator
	|
	|-RVA: 0x27873D0 Offset: 0x27874D1 VA: 0x27873D0
	|-Dictionary.KeyCollection<Vector2Int, object>.GetEnumerator
	|
	|-RVA: 0x2787DB0 Offset: 0x2787EB1 VA: 0x2787DB0
	|-Dictionary.KeyCollection<Vector3, object>.GetEnumerator
	|
	|-RVA: 0x27887A0 Offset: 0x27888A1 VA: 0x27887A0
	|-Dictionary.KeyCollection<Vector3Int, object>.GetEnumerator
	|
	|-RVA: 0x2789190 Offset: 0x2789291 VA: 0x2789190
	|-Dictionary.KeyCollection<Vector4, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E24C0 Offset: 0x27E25C1 VA: 0x27E24C0
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.CopyTo
	|
	|-RVA: 0x27E2EC0 Offset: 0x27E2FC1 VA: 0x27E2EC0
	|-Dictionary.KeyCollection<BitVector32Int, object>.CopyTo
	|
	|-RVA: 0x27E38A0 Offset: 0x27E39A1 VA: 0x27E38A0
	|-Dictionary.KeyCollection<EventCheckId, object>.CopyTo
	|
	|-RVA: 0x27E4340 Offset: 0x27E4441 VA: 0x27E4340
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.CopyTo
	|
	|-RVA: 0x27E4E30 Offset: 0x27E4F31 VA: 0x27E4E30
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.CopyTo
	|
	|-RVA: 0x27E58A0 Offset: 0x27E59A1 VA: 0x27E58A0
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.CopyTo
	|
	|-RVA: 0x27E6290 Offset: 0x27E6391 VA: 0x27E6290
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.CopyTo
	|
	|-RVA: 0x27E6C90 Offset: 0x27E6D91 VA: 0x27E6C90
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.CopyTo
	|
	|-RVA: 0x27E7740 Offset: 0x27E7841 VA: 0x27E7740
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.CopyTo
	|
	|-RVA: 0x27E8140 Offset: 0x27E8241 VA: 0x27E8140
	|-Dictionary.KeyCollection<OrderSaveData, object>.CopyTo
	|
	|-RVA: 0x27E8C00 Offset: 0x27E8D01 VA: 0x27E8C00
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.CopyTo
	|
	|-RVA: 0x27E96A0 Offset: 0x27E97A1 VA: 0x27E96A0
	|-Dictionary.KeyCollection<Parameter, object>.CopyTo
	|
	|-RVA: 0x27EA180 Offset: 0x27EA281 VA: 0x27EA180
	|-Dictionary.KeyCollection<bool, object>.CopyTo
	|
	|-RVA: 0x27EAB60 Offset: 0x27EAC61 VA: 0x27EAB60
	|-Dictionary.KeyCollection<byte, object>.CopyTo
	|
	|-RVA: 0x27EB540 Offset: 0x27EB641 VA: 0x27EB540
	|-Dictionary.KeyCollection<char, object>.CopyTo
	|
	|-RVA: 0x27EBF20 Offset: 0x27EC021 VA: 0x27EBF20
	|-Dictionary.KeyCollection<DateTime, object>.CopyTo
	|
	|-RVA: 0x27EC900 Offset: 0x27ECA01 VA: 0x27EC900
	|-Dictionary.KeyCollection<double, object>.CopyTo
	|
	|-RVA: 0x27ED2E0 Offset: 0x27ED3E1 VA: 0x27ED2E0
	|-Dictionary.KeyCollection<Guid, object>.CopyTo
	|
	|-RVA: 0x27EDCD0 Offset: 0x27EDDD1 VA: 0x27EDCD0
	|-Dictionary.KeyCollection<short, object>.CopyTo
	|
	|-RVA: 0x27EE6B0 Offset: 0x27EE7B1 VA: 0x27EE6B0
	|-Dictionary.KeyCollection<int, CropDataTable>.CopyTo
	|
	|-RVA: 0x27EF090 Offset: 0x27EF191 VA: 0x27EF090
	|-Dictionary.KeyCollection<int, EffectDataTable>.CopyTo
	|
	|-RVA: 0x27EFA70 Offset: 0x27EFB71 VA: 0x27EFA70
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.CopyTo
	|
	|-RVA: 0x27F0450 Offset: 0x27F0551 VA: 0x27F0450
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.CopyTo
	|
	|-RVA: 0x27F0E30 Offset: 0x27F0F31 VA: 0x27F0E30
	|-Dictionary.KeyCollection<int, MiningDataTable>.CopyTo
	|
	|-RVA: 0x27F1810 Offset: 0x27F1911 VA: 0x27F1810
	|-Dictionary.KeyCollection<int, bool>.CopyTo
	|
	|-RVA: 0x27F21F0 Offset: 0x27F22F1 VA: 0x27F21F0
	|-Dictionary.KeyCollection<int, char>.CopyTo
	|
	|-RVA: 0x27F2BD0 Offset: 0x27F2CD1 VA: 0x27F2BD0
	|-Dictionary.KeyCollection<int, int>.CopyTo
	|
	|-RVA: 0x27F35B0 Offset: 0x27F36B1 VA: 0x27F35B0
	|-Dictionary.KeyCollection<int, Int32Enum>.CopyTo
	|
	|-RVA: 0x27F3F90 Offset: 0x27F4091 VA: 0x27F3F90
	|-Dictionary.KeyCollection<int, long>.CopyTo
	|
	|-RVA: 0x27F4970 Offset: 0x27F4A71 VA: 0x27F4970
	|-Dictionary.KeyCollection<int, object>.CopyTo
	|
	|-RVA: 0x27F5350 Offset: 0x27F5451 VA: 0x27F5350
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x27F5D30 Offset: 0x27F5E31 VA: 0x27F5D30
	|-Dictionary.KeyCollection<int, SceneInstance>.CopyTo
	|
	|-RVA: 0x27F6710 Offset: 0x27F6811 VA: 0x27F6710
	|-Dictionary.KeyCollection<int, Vector2Int>.CopyTo
	|
	|-RVA: 0x27F70F0 Offset: 0x27F71F1 VA: 0x27F70F0
	|-Dictionary.KeyCollection<int, Vector3>.CopyTo
	|
	|-RVA: 0x27F7AD0 Offset: 0x27F7BD1 VA: 0x27F7AD0
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.CopyTo
	|
	|-RVA: 0x27F84B0 Offset: 0x27F85B1 VA: 0x27F84B0
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.CopyTo
	|
	|-RVA: 0x29D71B0 Offset: 0x29D72B1 VA: 0x29D71B0
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.CopyTo
	|
	|-RVA: 0x29D7B90 Offset: 0x29D7C91 VA: 0x29D7B90
	|-Dictionary.KeyCollection<Int32Enum, bool>.CopyTo
	|
	|-RVA: 0x29D8570 Offset: 0x29D8671 VA: 0x29D8570
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x29D8F50 Offset: 0x29D9051 VA: 0x29D8F50
	|-Dictionary.KeyCollection<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x29D9930 Offset: 0x29D9A31 VA: 0x29D9930
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.CopyTo
	|
	|-RVA: 0x29DA310 Offset: 0x29DA411 VA: 0x29DA310
	|-Dictionary.KeyCollection<Int32Enum, object>.CopyTo
	|
	|-RVA: 0x29DACF0 Offset: 0x29DADF1 VA: 0x29DACF0
	|-Dictionary.KeyCollection<Int32Enum, float>.CopyTo
	|
	|-RVA: 0x29DB6D0 Offset: 0x29DB7D1 VA: 0x29DB6D0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.CopyTo
	|
	|-RVA: 0x29DC0B0 Offset: 0x29DC1B1 VA: 0x29DC0B0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.CopyTo
	|
	|-RVA: 0x29DCA90 Offset: 0x29DCB91 VA: 0x29DCA90
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.CopyTo
	|
	|-RVA: 0x29DD470 Offset: 0x29DD571 VA: 0x29DD470
	|-Dictionary.KeyCollection<long, object>.CopyTo
	|
	|-RVA: 0x29DDE50 Offset: 0x29DDF51 VA: 0x29DDE50
	|-Dictionary.KeyCollection<Memory<object>, object>.CopyTo
	|
	|-RVA: 0x29DE850 Offset: 0x29DE951 VA: 0x29DE850
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.CopyTo
	|
	|-RVA: 0x29DF240 Offset: 0x29DF341 VA: 0x29DF240
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.CopyTo
	|
	|-RVA: 0x29DFCF0 Offset: 0x29DFDF1 VA: 0x29DFCF0
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.CopyTo
	|
	|-RVA: 0x29E0790 Offset: 0x29E0891 VA: 0x29E0790
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.CopyTo
	|
	|-RVA: 0x29E1170 Offset: 0x29E1271 VA: 0x29E1170
	|-Dictionary.KeyCollection<Nullable<Color>, object>.CopyTo
	|
	|-RVA: 0x29E1BE0 Offset: 0x29E1CE1 VA: 0x29E1BE0
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.CopyTo
	|
	|-RVA: 0x29E25D0 Offset: 0x29E26D1 VA: 0x29E25D0
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.CopyTo
	|
	|-RVA: 0x29E3050 Offset: 0x29E3151 VA: 0x29E3050
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.CopyTo
	|
	|-RVA: 0x29E3AC0 Offset: 0x29E3BC1 VA: 0x29E3AC0
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.CopyTo
	|
	|-RVA: 0x29E44D0 Offset: 0x29E45D1 VA: 0x29E44D0
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.CopyTo
	|
	|-RVA: 0x29E5000 Offset: 0x29E5101 VA: 0x29E5000
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.CopyTo
	|
	|-RVA: 0x29E5A70 Offset: 0x29E5B71 VA: 0x29E5A70
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.CopyTo
	|
	|-RVA: 0x29E6460 Offset: 0x29E6561 VA: 0x29E6460
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.CopyTo
	|
	|-RVA: 0x29E6ED0 Offset: 0x29E6FD1 VA: 0x29E6ED0
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.CopyTo
	|
	|-RVA: 0x29E7940 Offset: 0x29E7A41 VA: 0x29E7940
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.CopyTo
	|
	|-RVA: 0x29E8330 Offset: 0x29E8431 VA: 0x29E8330
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.CopyTo
	|
	|-RVA: 0x29E8D20 Offset: 0x29E8E21 VA: 0x29E8D20
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.CopyTo
	|
	|-RVA: 0x29E9710 Offset: 0x29E9811 VA: 0x29E9710
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.CopyTo
	|
	|-RVA: 0x29EA100 Offset: 0x29EA201 VA: 0x29EA100
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.CopyTo
	|
	|-RVA: 0x29EAB70 Offset: 0x29EAC71 VA: 0x29EAB70
	|-Dictionary.KeyCollection<object, BitVector32Int>.CopyTo
	|
	|-RVA: 0x29EB520 Offset: 0x29EB621 VA: 0x29EB520
	|-Dictionary.KeyCollection<object, EventCheckId>.CopyTo
	|
	|-RVA: 0x29EBED0 Offset: 0x29EBFD1 VA: 0x29EBED0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.CopyTo
	|
	|-RVA: 0x29EC880 Offset: 0x29EC981 VA: 0x29EC880
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.CopyTo
	|
	|-RVA: 0x29ED230 Offset: 0x29ED331 VA: 0x29ED230
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.CopyTo
	|
	|-RVA: 0x29AA830 Offset: 0x29AA931 VA: 0x29AA830
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.CopyTo
	|
	|-RVA: 0x29AB1E0 Offset: 0x29AB2E1 VA: 0x29AB1E0
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.CopyTo
	|
	|-RVA: 0x29ABB90 Offset: 0x29ABC91 VA: 0x29ABB90
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.CopyTo
	|
	|-RVA: 0x29AC540 Offset: 0x29AC641 VA: 0x29AC540
	|-Dictionary.KeyCollection<object, OrderSaveData>.CopyTo
	|
	|-RVA: 0x29ACEF0 Offset: 0x29ACFF1 VA: 0x29ACEF0
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.CopyTo
	|
	|-RVA: 0x29AD8A0 Offset: 0x29AD9A1 VA: 0x29AD8A0
	|-Dictionary.KeyCollection<object, Parameter>.CopyTo
	|
	|-RVA: 0x29AE250 Offset: 0x29AE351 VA: 0x29AE250
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.CopyTo
	|
	|-RVA: 0x29AEC00 Offset: 0x29AED01 VA: 0x29AEC00
	|-Dictionary.KeyCollection<object, bool>.CopyTo
	|
	|-RVA: 0x29AF5B0 Offset: 0x29AF6B1 VA: 0x29AF5B0
	|-Dictionary.KeyCollection<object, byte>.CopyTo
	|
	|-RVA: 0x29AFF60 Offset: 0x29B0061 VA: 0x29AFF60
	|-Dictionary.KeyCollection<object, char>.CopyTo
	|
	|-RVA: 0x29B0910 Offset: 0x29B0A11 VA: 0x29B0910
	|-Dictionary.KeyCollection<object, DateTime>.CopyTo
	|
	|-RVA: 0x29B12C0 Offset: 0x29B13C1 VA: 0x29B12C0
	|-Dictionary.KeyCollection<object, double>.CopyTo
	|
	|-RVA: 0x29B1C70 Offset: 0x29B1D71 VA: 0x29B1C70
	|-Dictionary.KeyCollection<object, short>.CopyTo
	|
	|-RVA: 0x29B2620 Offset: 0x29B2721 VA: 0x29B2620
	|-Dictionary.KeyCollection<object, int>.CopyTo
	|
	|-RVA: 0x29B2FD0 Offset: 0x29B30D1 VA: 0x29B2FD0
	|-Dictionary.KeyCollection<object, Int32Enum>.CopyTo
	|
	|-RVA: 0x29B3980 Offset: 0x29B3A81 VA: 0x29B3980
	|-Dictionary.KeyCollection<object, long>.CopyTo
	|
	|-RVA: 0x29B4330 Offset: 0x29B4431 VA: 0x29B4330
	|-Dictionary.KeyCollection<object, Memory<object>>.CopyTo
	|
	|-RVA: 0x29B4CE0 Offset: 0x29B4DE1 VA: 0x29B4CE0
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.CopyTo
	|
	|-RVA: 0x29B5690 Offset: 0x29B5791 VA: 0x29B5690
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.CopyTo
	|
	|-RVA: 0x29B6040 Offset: 0x29B6141 VA: 0x29B6040
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.CopyTo
	|
	|-RVA: 0x29B69F0 Offset: 0x29B6AF1 VA: 0x29B69F0
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.CopyTo
	|
	|-RVA: 0x29B73A0 Offset: 0x29B74A1 VA: 0x29B73A0
	|-Dictionary.KeyCollection<object, Nullable<Color>>.CopyTo
	|
	|-RVA: 0x29B7D50 Offset: 0x29B7E51 VA: 0x29B7D50
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.CopyTo
	|
	|-RVA: 0x29B8700 Offset: 0x29B8801 VA: 0x29B8700
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.CopyTo
	|
	|-RVA: 0x29B90B0 Offset: 0x29B91B1 VA: 0x29B90B0
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.CopyTo
	|
	|-RVA: 0x29B9A60 Offset: 0x29B9B61 VA: 0x29B9A60
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.CopyTo
	|
	|-RVA: 0x29BA410 Offset: 0x29BA511 VA: 0x29BA410
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.CopyTo
	|
	|-RVA: 0x29BADC0 Offset: 0x29BAEC1 VA: 0x29BADC0
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.CopyTo
	|
	|-RVA: 0x29BB770 Offset: 0x29BB871 VA: 0x29BB770
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.CopyTo
	|
	|-RVA: 0x29BC120 Offset: 0x29BC221 VA: 0x29BC120
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.CopyTo
	|
	|-RVA: 0x29BCAD0 Offset: 0x29BCBD1 VA: 0x29BCAD0
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.CopyTo
	|
	|-RVA: 0x29BD480 Offset: 0x29BD581 VA: 0x29BD480
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.CopyTo
	|
	|-RVA: 0x29BDE30 Offset: 0x29BDF31 VA: 0x29BDE30
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.CopyTo
	|
	|-RVA: 0x29BE7E0 Offset: 0x29BE8E1 VA: 0x29BE7E0
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.CopyTo
	|
	|-RVA: 0x29BF190 Offset: 0x29BF291 VA: 0x29BF190
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.CopyTo
	|
	|-RVA: 0x29BFB40 Offset: 0x29BFC41 VA: 0x29BFB40
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.CopyTo
	|
	|-RVA: 0x29C04F0 Offset: 0x29C05F1 VA: 0x29C04F0
	|-Dictionary.KeyCollection<object, object>.CopyTo
	|-Dictionary.KeyCollection<Material, List<CombinedMesh.MaterialMeshInfo>>.CopyTo
	|
	|-RVA: 0x2A3BFE0 Offset: 0x2A3C0E1 VA: 0x2A3BFE0
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.CopyTo
	|
	|-RVA: 0x2A3C990 Offset: 0x2A3CA91 VA: 0x2A3C990
	|-Dictionary.KeyCollection<object, ResourceLocator>.CopyTo
	|
	|-RVA: 0x2A3D340 Offset: 0x2A3D441 VA: 0x2A3D340
	|-Dictionary.KeyCollection<object, sbyte>.CopyTo
	|
	|-RVA: 0x2A3DCF0 Offset: 0x2A3DDF1 VA: 0x2A3DCF0
	|-Dictionary.KeyCollection<object, float>.CopyTo
	|
	|-RVA: 0x2A3E6A0 Offset: 0x2A3E7A1 VA: 0x2A3E6A0
	|-Dictionary.KeyCollection<object, ushort>.CopyTo
	|
	|-RVA: 0x2A3F050 Offset: 0x2A3F151 VA: 0x2A3F050
	|-Dictionary.KeyCollection<object, uint>.CopyTo
	|
	|-RVA: 0x2A3FA00 Offset: 0x2A3FB01 VA: 0x2A3FA00
	|-Dictionary.KeyCollection<object, ulong>.CopyTo
	|
	|-RVA: 0x2A403B0 Offset: 0x2A404B1 VA: 0x2A403B0
	|-Dictionary.KeyCollection<object, TransitionTables>.CopyTo
	|
	|-RVA: 0x2A40D60 Offset: 0x2A40E61 VA: 0x2A40D60
	|-Dictionary.KeyCollection<object, Bounds>.CopyTo
	|
	|-RVA: 0x2A41710 Offset: 0x2A41811 VA: 0x2A41710
	|-Dictionary.KeyCollection<object, BoundsInt>.CopyTo
	|
	|-RVA: 0x2A420C0 Offset: 0x2A421C1 VA: 0x2A420C0
	|-Dictionary.KeyCollection<object, Color32>.CopyTo
	|
	|-RVA: 0x2A42A70 Offset: 0x2A42B71 VA: 0x2A42A70
	|-Dictionary.KeyCollection<object, Color>.CopyTo
	|
	|-RVA: 0x2A43420 Offset: 0x2A43521 VA: 0x2A43420
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.CopyTo
	|
	|-RVA: 0x2A43DD0 Offset: 0x2A43ED1 VA: 0x2A43DD0
	|-Dictionary.KeyCollection<object, GradientColorKey>.CopyTo
	|
	|-RVA: 0x2A44780 Offset: 0x2A44881 VA: 0x2A44780
	|-Dictionary.KeyCollection<object, Keyframe>.CopyTo
	|
	|-RVA: 0x2A45130 Offset: 0x2A45231 VA: 0x2A45130
	|-Dictionary.KeyCollection<object, LayerMask>.CopyTo
	|
	|-RVA: 0x2A45AE0 Offset: 0x2A45BE1 VA: 0x2A45AE0
	|-Dictionary.KeyCollection<object, Matrix4x4>.CopyTo
	|
	|-RVA: 0x2A46490 Offset: 0x2A46591 VA: 0x2A46490
	|-Dictionary.KeyCollection<object, Playable>.CopyTo
	|
	|-RVA: 0x2A46E40 Offset: 0x2A46F41 VA: 0x2A46E40
	|-Dictionary.KeyCollection<object, Quaternion>.CopyTo
	|
	|-RVA: 0x2A477F0 Offset: 0x2A478F1 VA: 0x2A477F0
	|-Dictionary.KeyCollection<object, RangeInt>.CopyTo
	|
	|-RVA: 0x2A481A0 Offset: 0x2A482A1 VA: 0x2A481A0
	|-Dictionary.KeyCollection<object, Rect>.CopyTo
	|
	|-RVA: 0x2A48B50 Offset: 0x2A48C51 VA: 0x2A48B50
	|-Dictionary.KeyCollection<object, RectInt>.CopyTo
	|
	|-RVA: 0x2A49500 Offset: 0x2A49601 VA: 0x2A49500
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x2A49EB0 Offset: 0x2A49FB1 VA: 0x2A49EB0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.CopyTo
	|
	|-RVA: 0x2A4A860 Offset: 0x2A4A961 VA: 0x2A4A860
	|-Dictionary.KeyCollection<object, Vector2>.CopyTo
	|
	|-RVA: 0x2A4B210 Offset: 0x2A4B311 VA: 0x2A4B210
	|-Dictionary.KeyCollection<object, Vector2Int>.CopyTo
	|
	|-RVA: 0x2A4BBC0 Offset: 0x2A4BCC1 VA: 0x2A4BBC0
	|-Dictionary.KeyCollection<object, Vector3>.CopyTo
	|
	|-RVA: 0x2A4C570 Offset: 0x2A4C671 VA: 0x2A4C570
	|-Dictionary.KeyCollection<object, Vector3Int>.CopyTo
	|
	|-RVA: 0x2A4CF20 Offset: 0x2A4D021 VA: 0x2A4CF20
	|-Dictionary.KeyCollection<object, Vector4>.CopyTo
	|
	|-RVA: 0x2A4D8D0 Offset: 0x2A4D9D1 VA: 0x2A4D8D0
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.CopyTo
	|
	|-RVA: 0x2A4E2D0 Offset: 0x2A4E3D1 VA: 0x2A4E2D0
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.CopyTo
	|
	|-RVA: 0x2A4ECB0 Offset: 0x2A4EDB1 VA: 0x2A4ECB0
	|-Dictionary.KeyCollection<sbyte, object>.CopyTo
	|
	|-RVA: 0x2A4F690 Offset: 0x2A4F791 VA: 0x2A4F690
	|-Dictionary.KeyCollection<float, CurveSample>.CopyTo
	|
	|-RVA: 0x2A50070 Offset: 0x2A50171 VA: 0x2A50070
	|-Dictionary.KeyCollection<float, object>.CopyTo
	|
	|-RVA: 0x2A50A50 Offset: 0x2A50B51 VA: 0x2A50A50
	|-Dictionary.KeyCollection<ushort, object>.CopyTo
	|
	|-RVA: 0x2A51430 Offset: 0x2A51531 VA: 0x2A51430
	|-Dictionary.KeyCollection<uint, int>.CopyTo
	|
	|-RVA: 0x2A51E10 Offset: 0x2A51F11 VA: 0x2A51E10
	|-Dictionary.KeyCollection<uint, Int32Enum>.CopyTo
	|
	|-RVA: 0x2776F70 Offset: 0x2777071 VA: 0x2776F70
	|-Dictionary.KeyCollection<uint, object>.CopyTo
	|
	|-RVA: 0x2777950 Offset: 0x2777A51 VA: 0x2777950
	|-Dictionary.KeyCollection<ulong, object>.CopyTo
	|
	|-RVA: 0x2778330 Offset: 0x2778431 VA: 0x2778330
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.CopyTo
	|
	|-RVA: 0x2778D10 Offset: 0x2778E11 VA: 0x2778D10
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.CopyTo
	|
	|-RVA: 0x27796F0 Offset: 0x27797F1 VA: 0x27796F0
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.CopyTo
	|
	|-RVA: 0x277A0D0 Offset: 0x277A1D1 VA: 0x277A0D0
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.CopyTo
	|
	|-RVA: 0x277AAB0 Offset: 0x277ABB1 VA: 0x277AAB0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.CopyTo
	|
	|-RVA: 0x277B490 Offset: 0x277B591 VA: 0x277B490
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.CopyTo
	|
	|-RVA: 0x277BE70 Offset: 0x277BF71 VA: 0x277BE70
	|-Dictionary.KeyCollection<Bounds, object>.CopyTo
	|
	|-RVA: 0x277C8E0 Offset: 0x277C9E1 VA: 0x277C8E0
	|-Dictionary.KeyCollection<BoundsInt, object>.CopyTo
	|
	|-RVA: 0x277D350 Offset: 0x277D451 VA: 0x277D350
	|-Dictionary.KeyCollection<Color, object>.CopyTo
	|
	|-RVA: 0x277DD40 Offset: 0x277DE41 VA: 0x277DD40
	|-Dictionary.KeyCollection<Color32, object>.CopyTo
	|
	|-RVA: 0x277E720 Offset: 0x277E821 VA: 0x277E720
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.CopyTo
	|
	|-RVA: 0x277F100 Offset: 0x277F201 VA: 0x277F100
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.CopyTo
	|
	|-RVA: 0x277FAF0 Offset: 0x277FBF1 VA: 0x277FAF0
	|-Dictionary.KeyCollection<GradientColorKey, object>.CopyTo
	|
	|-RVA: 0x2780570 Offset: 0x2780671 VA: 0x2780570
	|-Dictionary.KeyCollection<Keyframe, object>.CopyTo
	|
	|-RVA: 0x2781010 Offset: 0x2781111 VA: 0x2781010
	|-Dictionary.KeyCollection<LayerMask, object>.CopyTo
	|
	|-RVA: 0x2781A10 Offset: 0x2781B11 VA: 0x2781A10
	|-Dictionary.KeyCollection<Matrix4x4, object>.CopyTo
	|
	|-RVA: 0x27824E0 Offset: 0x27825E1 VA: 0x27824E0
	|-Dictionary.KeyCollection<IntVec3, object>.CopyTo
	|
	|-RVA: 0x2782ED0 Offset: 0x2782FD1 VA: 0x2782ED0
	|-Dictionary.KeyCollection<Quaternion, object>.CopyTo
	|
	|-RVA: 0x27838C0 Offset: 0x27839C1 VA: 0x27838C0
	|-Dictionary.KeyCollection<RangeInt, object>.CopyTo
	|
	|-RVA: 0x27842A0 Offset: 0x27843A1 VA: 0x27842A0
	|-Dictionary.KeyCollection<Rect, object>.CopyTo
	|
	|-RVA: 0x2784C90 Offset: 0x2784D91 VA: 0x2784C90
	|-Dictionary.KeyCollection<RectInt, object>.CopyTo
	|
	|-RVA: 0x2785680 Offset: 0x2785781 VA: 0x2785680
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.CopyTo
	|
	|-RVA: 0x2786060 Offset: 0x2786161 VA: 0x2786060
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.CopyTo
	|
	|-RVA: 0x2786A40 Offset: 0x2786B41 VA: 0x2786A40
	|-Dictionary.KeyCollection<Vector2, object>.CopyTo
	|
	|-RVA: 0x2787430 Offset: 0x2787531 VA: 0x2787430
	|-Dictionary.KeyCollection<Vector2Int, object>.CopyTo
	|
	|-RVA: 0x2787E10 Offset: 0x2787F11 VA: 0x2787E10
	|-Dictionary.KeyCollection<Vector3, object>.CopyTo
	|
	|-RVA: 0x2788800 Offset: 0x2788901 VA: 0x2788800
	|-Dictionary.KeyCollection<Vector3Int, object>.CopyTo
	|
	|-RVA: 0x27891F0 Offset: 0x27892F1 VA: 0x27891F0
	|-Dictionary.KeyCollection<Vector4, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E26C0 Offset: 0x27E27C1 VA: 0x27E26C0
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.get_Count
	|
	|-RVA: 0x27E30A0 Offset: 0x27E31A1 VA: 0x27E30A0
	|-Dictionary.KeyCollection<BitVector32Int, object>.get_Count
	|
	|-RVA: 0x29DA4F0 Offset: 0x29DA5F1 VA: 0x29DA4F0
	|-Dictionary.KeyCollection<ActorID, ItemStorageData>.get_Count
	|-Dictionary.KeyCollection<Int32Enum, object>.get_Count
	|
	|-RVA: 0x27E3AC0 Offset: 0x27E3BC1 VA: 0x27E3AC0
	|-Dictionary.KeyCollection<EventCheckId, object>.get_Count
	|
	|-RVA: 0x27E4580 Offset: 0x27E4681 VA: 0x27E4580
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.get_Count
	|
	|-RVA: 0x27E5040 Offset: 0x27E5141 VA: 0x27E5040
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.get_Count
	|
	|-RVA: 0x27E5A90 Offset: 0x27E5B91 VA: 0x27E5A90
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.get_Count
	|
	|-RVA: 0x27E6480 Offset: 0x27E6581 VA: 0x27E6480
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.get_Count
	|
	|-RVA: 0x27E6EC0 Offset: 0x27E6FC1 VA: 0x27E6EC0
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.get_Count
	|
	|-RVA: 0x27E7930 Offset: 0x27E7A31 VA: 0x27E7930
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.get_Count
	|
	|-RVA: 0x27E8370 Offset: 0x27E8471 VA: 0x27E8370
	|-Dictionary.KeyCollection<OrderSaveData, object>.get_Count
	|
	|-RVA: 0x27E8E10 Offset: 0x27E8F11 VA: 0x27E8E10
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.get_Count
	|
	|-RVA: 0x27E98C0 Offset: 0x27E99C1 VA: 0x27E98C0
	|-Dictionary.KeyCollection<Parameter, object>.get_Count
	|
	|-RVA: 0x27EA360 Offset: 0x27EA461 VA: 0x27EA360
	|-Dictionary.KeyCollection<bool, object>.get_Count
	|
	|-RVA: 0x27EAD40 Offset: 0x27EAE41 VA: 0x27EAD40
	|-Dictionary.KeyCollection<byte, object>.get_Count
	|
	|-RVA: 0x27EB720 Offset: 0x27EB821 VA: 0x27EB720
	|-Dictionary.KeyCollection<char, object>.get_Count
	|
	|-RVA: 0x27EC100 Offset: 0x27EC201 VA: 0x27EC100
	|-Dictionary.KeyCollection<DateTime, object>.get_Count
	|
	|-RVA: 0x27ECAE0 Offset: 0x27ECBE1 VA: 0x27ECAE0
	|-Dictionary.KeyCollection<double, object>.get_Count
	|
	|-RVA: 0x27ED4D0 Offset: 0x27ED5D1 VA: 0x27ED4D0
	|-Dictionary.KeyCollection<Guid, object>.get_Count
	|
	|-RVA: 0x27EDEB0 Offset: 0x27EDFB1 VA: 0x27EDEB0
	|-Dictionary.KeyCollection<short, object>.get_Count
	|
	|-RVA: 0x27EE890 Offset: 0x27EE991 VA: 0x27EE890
	|-Dictionary.KeyCollection<int, CropDataTable>.get_Count
	|
	|-RVA: 0x27EF270 Offset: 0x27EF371 VA: 0x27EF270
	|-Dictionary.KeyCollection<int, EffectDataTable>.get_Count
	|
	|-RVA: 0x27EFC50 Offset: 0x27EFD51 VA: 0x27EFC50
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.get_Count
	|
	|-RVA: 0x27F0630 Offset: 0x27F0731 VA: 0x27F0630
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.get_Count
	|
	|-RVA: 0x27F1010 Offset: 0x27F1111 VA: 0x27F1010
	|-Dictionary.KeyCollection<int, MiningDataTable>.get_Count
	|
	|-RVA: 0x27F19F0 Offset: 0x27F1AF1 VA: 0x27F19F0
	|-Dictionary.KeyCollection<int, bool>.get_Count
	|
	|-RVA: 0x27F23D0 Offset: 0x27F24D1 VA: 0x27F23D0
	|-Dictionary.KeyCollection<int, char>.get_Count
	|
	|-RVA: 0x27F2DB0 Offset: 0x27F2EB1 VA: 0x27F2DB0
	|-Dictionary.KeyCollection<int, int>.get_Count
	|
	|-RVA: 0x27F3790 Offset: 0x27F3891 VA: 0x27F3790
	|-Dictionary.KeyCollection<int, Int32Enum>.get_Count
	|
	|-RVA: 0x27F4170 Offset: 0x27F4271 VA: 0x27F4170
	|-Dictionary.KeyCollection<int, long>.get_Count
	|
	|-RVA: 0x27F4B50 Offset: 0x27F4C51 VA: 0x27F4B50
	|-Dictionary.KeyCollection<int, object>.get_Count
	|
	|-RVA: 0x27F5530 Offset: 0x27F5631 VA: 0x27F5530
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.get_Count
	|
	|-RVA: 0x27F5F10 Offset: 0x27F6011 VA: 0x27F5F10
	|-Dictionary.KeyCollection<int, SceneInstance>.get_Count
	|
	|-RVA: 0x27F68F0 Offset: 0x27F69F1 VA: 0x27F68F0
	|-Dictionary.KeyCollection<int, Vector2Int>.get_Count
	|
	|-RVA: 0x27F72D0 Offset: 0x27F73D1 VA: 0x27F72D0
	|-Dictionary.KeyCollection<int, Vector3>.get_Count
	|
	|-RVA: 0x27F7CB0 Offset: 0x27F7DB1 VA: 0x27F7CB0
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.get_Count
	|
	|-RVA: 0x27F8690 Offset: 0x27F8791 VA: 0x27F8690
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.get_Count
	|
	|-RVA: 0x29D7390 Offset: 0x29D7491 VA: 0x29D7390
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Count
	|
	|-RVA: 0x29D7D70 Offset: 0x29D7E71 VA: 0x29D7D70
	|-Dictionary.KeyCollection<Int32Enum, bool>.get_Count
	|
	|-RVA: 0x29D8750 Offset: 0x29D8851 VA: 0x29D8750
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Count
	|
	|-RVA: 0x29D9130 Offset: 0x29D9231 VA: 0x29D9130
	|-Dictionary.KeyCollection<Int32Enum, int>.get_Count
	|
	|-RVA: 0x29D9B10 Offset: 0x29D9C11 VA: 0x29D9B10
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.get_Count
	|
	|-RVA: 0x29DAED0 Offset: 0x29DAFD1 VA: 0x29DAED0
	|-Dictionary.KeyCollection<Int32Enum, float>.get_Count
	|
	|-RVA: 0x29DB8B0 Offset: 0x29DB9B1 VA: 0x29DB8B0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.get_Count
	|
	|-RVA: 0x29DC290 Offset: 0x29DC391 VA: 0x29DC290
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.get_Count
	|
	|-RVA: 0x29DCC70 Offset: 0x29DCD71 VA: 0x29DCC70
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.get_Count
	|
	|-RVA: 0x29DD650 Offset: 0x29DD751 VA: 0x29DD650
	|-Dictionary.KeyCollection<long, object>.get_Count
	|
	|-RVA: 0x29DE050 Offset: 0x29DE151 VA: 0x29DE050
	|-Dictionary.KeyCollection<Memory<object>, object>.get_Count
	|
	|-RVA: 0x29DEA30 Offset: 0x29DEB31 VA: 0x29DEA30
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.get_Count
	|
	|-RVA: 0x29DF460 Offset: 0x29DF561 VA: 0x29DF460
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.get_Count
	|
	|-RVA: 0x29DFF10 Offset: 0x29E0011 VA: 0x29DFF10
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.get_Count
	|
	|-RVA: 0x29E0970 Offset: 0x29E0A71 VA: 0x29E0970
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.get_Count
	|
	|-RVA: 0x29E1380 Offset: 0x29E1481 VA: 0x29E1380
	|-Dictionary.KeyCollection<Nullable<Color>, object>.get_Count
	|
	|-RVA: 0x29E1DD0 Offset: 0x29E1ED1 VA: 0x29E1DD0
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.get_Count
	|
	|-RVA: 0x29E27E0 Offset: 0x29E28E1 VA: 0x29E27E0
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.get_Count
	|
	|-RVA: 0x29E3260 Offset: 0x29E3361 VA: 0x29E3260
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.get_Count
	|
	|-RVA: 0x29E3CA0 Offset: 0x29E3DA1 VA: 0x29E3CA0
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.get_Count
	|
	|-RVA: 0x29E4720 Offset: 0x29E4821 VA: 0x29E4720
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.get_Count
	|
	|-RVA: 0x29E5210 Offset: 0x29E5311 VA: 0x29E5210
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.get_Count
	|
	|-RVA: 0x29E5C60 Offset: 0x29E5D61 VA: 0x29E5C60
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.get_Count
	|
	|-RVA: 0x29E6670 Offset: 0x29E6771 VA: 0x29E6670
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.get_Count
	|
	|-RVA: 0x29E70E0 Offset: 0x29E71E1 VA: 0x29E70E0
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.get_Count
	|
	|-RVA: 0x29E7B30 Offset: 0x29E7C31 VA: 0x29E7B30
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.get_Count
	|
	|-RVA: 0x29E8520 Offset: 0x29E8621 VA: 0x29E8520
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.get_Count
	|
	|-RVA: 0x29E8F10 Offset: 0x29E9011 VA: 0x29E8F10
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.get_Count
	|
	|-RVA: 0x29E9900 Offset: 0x29E9A01 VA: 0x29E9900
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.get_Count
	|
	|-RVA: 0x29EA310 Offset: 0x29EA411 VA: 0x29EA310
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.get_Count
	|
	|-RVA: 0x29EAD60 Offset: 0x29EAE61 VA: 0x29EAD60
	|-Dictionary.KeyCollection<object, BitVector32Int>.get_Count
	|
	|-RVA: 0x29EB710 Offset: 0x29EB811 VA: 0x29EB710
	|-Dictionary.KeyCollection<object, EventCheckId>.get_Count
	|
	|-RVA: 0x29EC0C0 Offset: 0x29EC1C1 VA: 0x29EC0C0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.get_Count
	|
	|-RVA: 0x29ECA70 Offset: 0x29ECB71 VA: 0x29ECA70
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.get_Count
	|
	|-RVA: 0x29ED420 Offset: 0x29ED521 VA: 0x29ED420
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.get_Count
	|
	|-RVA: 0x29AAA20 Offset: 0x29AAB21 VA: 0x29AAA20
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.get_Count
	|
	|-RVA: 0x29AB3D0 Offset: 0x29AB4D1 VA: 0x29AB3D0
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.get_Count
	|
	|-RVA: 0x29ABD80 Offset: 0x29ABE81 VA: 0x29ABD80
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.get_Count
	|
	|-RVA: 0x29AC730 Offset: 0x29AC831 VA: 0x29AC730
	|-Dictionary.KeyCollection<object, OrderSaveData>.get_Count
	|
	|-RVA: 0x29AD0E0 Offset: 0x29AD1E1 VA: 0x29AD0E0
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.get_Count
	|
	|-RVA: 0x29ADA90 Offset: 0x29ADB91 VA: 0x29ADA90
	|-Dictionary.KeyCollection<object, Parameter>.get_Count
	|
	|-RVA: 0x29AE440 Offset: 0x29AE541 VA: 0x29AE440
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.get_Count
	|
	|-RVA: 0x29AEDF0 Offset: 0x29AEEF1 VA: 0x29AEDF0
	|-Dictionary.KeyCollection<object, bool>.get_Count
	|
	|-RVA: 0x29AF7A0 Offset: 0x29AF8A1 VA: 0x29AF7A0
	|-Dictionary.KeyCollection<object, byte>.get_Count
	|
	|-RVA: 0x29B0150 Offset: 0x29B0251 VA: 0x29B0150
	|-Dictionary.KeyCollection<object, char>.get_Count
	|
	|-RVA: 0x29B0B00 Offset: 0x29B0C01 VA: 0x29B0B00
	|-Dictionary.KeyCollection<object, DateTime>.get_Count
	|
	|-RVA: 0x29B14B0 Offset: 0x29B15B1 VA: 0x29B14B0
	|-Dictionary.KeyCollection<object, double>.get_Count
	|
	|-RVA: 0x29B1E60 Offset: 0x29B1F61 VA: 0x29B1E60
	|-Dictionary.KeyCollection<object, short>.get_Count
	|
	|-RVA: 0x29B2810 Offset: 0x29B2911 VA: 0x29B2810
	|-Dictionary.KeyCollection<object, int>.get_Count
	|
	|-RVA: 0x29B31C0 Offset: 0x29B32C1 VA: 0x29B31C0
	|-Dictionary.KeyCollection<object, Int32Enum>.get_Count
	|
	|-RVA: 0x29B3B70 Offset: 0x29B3C71 VA: 0x29B3B70
	|-Dictionary.KeyCollection<object, long>.get_Count
	|
	|-RVA: 0x29B4520 Offset: 0x29B4621 VA: 0x29B4520
	|-Dictionary.KeyCollection<object, Memory<object>>.get_Count
	|
	|-RVA: 0x29B4ED0 Offset: 0x29B4FD1 VA: 0x29B4ED0
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.get_Count
	|
	|-RVA: 0x29B5880 Offset: 0x29B5981 VA: 0x29B5880
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.get_Count
	|
	|-RVA: 0x29B6230 Offset: 0x29B6331 VA: 0x29B6230
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.get_Count
	|
	|-RVA: 0x29B6BE0 Offset: 0x29B6CE1 VA: 0x29B6BE0
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.get_Count
	|
	|-RVA: 0x29B7590 Offset: 0x29B7691 VA: 0x29B7590
	|-Dictionary.KeyCollection<object, Nullable<Color>>.get_Count
	|
	|-RVA: 0x29B7F40 Offset: 0x29B8041 VA: 0x29B7F40
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.get_Count
	|
	|-RVA: 0x29B88F0 Offset: 0x29B89F1 VA: 0x29B88F0
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.get_Count
	|
	|-RVA: 0x29B92A0 Offset: 0x29B93A1 VA: 0x29B92A0
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.get_Count
	|
	|-RVA: 0x29B9C50 Offset: 0x29B9D51 VA: 0x29B9C50
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.get_Count
	|
	|-RVA: 0x29BA600 Offset: 0x29BA701 VA: 0x29BA600
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.get_Count
	|
	|-RVA: 0x29BAFB0 Offset: 0x29BB0B1 VA: 0x29BAFB0
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.get_Count
	|
	|-RVA: 0x29BB960 Offset: 0x29BBA61 VA: 0x29BB960
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.get_Count
	|
	|-RVA: 0x29BC310 Offset: 0x29BC411 VA: 0x29BC310
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.get_Count
	|
	|-RVA: 0x29BCCC0 Offset: 0x29BCDC1 VA: 0x29BCCC0
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.get_Count
	|
	|-RVA: 0x29BD670 Offset: 0x29BD771 VA: 0x29BD670
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.get_Count
	|
	|-RVA: 0x29BE020 Offset: 0x29BE121 VA: 0x29BE020
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.get_Count
	|
	|-RVA: 0x29BE9D0 Offset: 0x29BEAD1 VA: 0x29BE9D0
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.get_Count
	|
	|-RVA: 0x29BF380 Offset: 0x29BF481 VA: 0x29BF380
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.get_Count
	|
	|-RVA: 0x29BFD30 Offset: 0x29BFE31 VA: 0x29BFD30
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.get_Count
	|
	|-RVA: 0x29C06E0 Offset: 0x29C07E1 VA: 0x29C06E0
	|-Dictionary.KeyCollection<object, object>.get_Count
	|-Dictionary.KeyCollection<Material, List<CombinedMesh.MaterialMeshInfo>>.get_Count
	|
	|-RVA: 0x2A3C1D0 Offset: 0x2A3C2D1 VA: 0x2A3C1D0
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.get_Count
	|
	|-RVA: 0x2A3CB80 Offset: 0x2A3CC81 VA: 0x2A3CB80
	|-Dictionary.KeyCollection<object, ResourceLocator>.get_Count
	|
	|-RVA: 0x2A3D530 Offset: 0x2A3D631 VA: 0x2A3D530
	|-Dictionary.KeyCollection<object, sbyte>.get_Count
	|
	|-RVA: 0x2A3DEE0 Offset: 0x2A3DFE1 VA: 0x2A3DEE0
	|-Dictionary.KeyCollection<object, float>.get_Count
	|
	|-RVA: 0x2A3E890 Offset: 0x2A3E991 VA: 0x2A3E890
	|-Dictionary.KeyCollection<object, ushort>.get_Count
	|
	|-RVA: 0x2A3F240 Offset: 0x2A3F341 VA: 0x2A3F240
	|-Dictionary.KeyCollection<object, uint>.get_Count
	|
	|-RVA: 0x2A3FBF0 Offset: 0x2A3FCF1 VA: 0x2A3FBF0
	|-Dictionary.KeyCollection<object, ulong>.get_Count
	|
	|-RVA: 0x2A405A0 Offset: 0x2A406A1 VA: 0x2A405A0
	|-Dictionary.KeyCollection<object, TransitionTables>.get_Count
	|
	|-RVA: 0x2A40F50 Offset: 0x2A41051 VA: 0x2A40F50
	|-Dictionary.KeyCollection<object, Bounds>.get_Count
	|
	|-RVA: 0x2A41900 Offset: 0x2A41A01 VA: 0x2A41900
	|-Dictionary.KeyCollection<object, BoundsInt>.get_Count
	|
	|-RVA: 0x2A422B0 Offset: 0x2A423B1 VA: 0x2A422B0
	|-Dictionary.KeyCollection<object, Color32>.get_Count
	|
	|-RVA: 0x2A42C60 Offset: 0x2A42D61 VA: 0x2A42C60
	|-Dictionary.KeyCollection<object, Color>.get_Count
	|
	|-RVA: 0x2A43610 Offset: 0x2A43711 VA: 0x2A43610
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.get_Count
	|
	|-RVA: 0x2A43FC0 Offset: 0x2A440C1 VA: 0x2A43FC0
	|-Dictionary.KeyCollection<object, GradientColorKey>.get_Count
	|
	|-RVA: 0x2A44970 Offset: 0x2A44A71 VA: 0x2A44970
	|-Dictionary.KeyCollection<object, Keyframe>.get_Count
	|
	|-RVA: 0x2A45320 Offset: 0x2A45421 VA: 0x2A45320
	|-Dictionary.KeyCollection<object, LayerMask>.get_Count
	|
	|-RVA: 0x2A45CD0 Offset: 0x2A45DD1 VA: 0x2A45CD0
	|-Dictionary.KeyCollection<object, Matrix4x4>.get_Count
	|
	|-RVA: 0x2A46680 Offset: 0x2A46781 VA: 0x2A46680
	|-Dictionary.KeyCollection<object, Playable>.get_Count
	|
	|-RVA: 0x2A47030 Offset: 0x2A47131 VA: 0x2A47030
	|-Dictionary.KeyCollection<object, Quaternion>.get_Count
	|
	|-RVA: 0x2A479E0 Offset: 0x2A47AE1 VA: 0x2A479E0
	|-Dictionary.KeyCollection<object, RangeInt>.get_Count
	|
	|-RVA: 0x2A48390 Offset: 0x2A48491 VA: 0x2A48390
	|-Dictionary.KeyCollection<object, Rect>.get_Count
	|
	|-RVA: 0x2A48D40 Offset: 0x2A48E41 VA: 0x2A48D40
	|-Dictionary.KeyCollection<object, RectInt>.get_Count
	|
	|-RVA: 0x2A496F0 Offset: 0x2A497F1 VA: 0x2A496F0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x2A4A0A0 Offset: 0x2A4A1A1 VA: 0x2A4A0A0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.get_Count
	|
	|-RVA: 0x2A4AA50 Offset: 0x2A4AB51 VA: 0x2A4AA50
	|-Dictionary.KeyCollection<object, Vector2>.get_Count
	|
	|-RVA: 0x2A4B400 Offset: 0x2A4B501 VA: 0x2A4B400
	|-Dictionary.KeyCollection<object, Vector2Int>.get_Count
	|
	|-RVA: 0x2A4BDB0 Offset: 0x2A4BEB1 VA: 0x2A4BDB0
	|-Dictionary.KeyCollection<object, Vector3>.get_Count
	|
	|-RVA: 0x2A4C760 Offset: 0x2A4C861 VA: 0x2A4C760
	|-Dictionary.KeyCollection<object, Vector3Int>.get_Count
	|
	|-RVA: 0x2A4D110 Offset: 0x2A4D211 VA: 0x2A4D110
	|-Dictionary.KeyCollection<object, Vector4>.get_Count
	|
	|-RVA: 0x2A4DAD0 Offset: 0x2A4DBD1 VA: 0x2A4DAD0
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.get_Count
	|
	|-RVA: 0x2A4E4B0 Offset: 0x2A4E5B1 VA: 0x2A4E4B0
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Count
	|
	|-RVA: 0x2A4EE90 Offset: 0x2A4EF91 VA: 0x2A4EE90
	|-Dictionary.KeyCollection<sbyte, object>.get_Count
	|
	|-RVA: 0x2A4F870 Offset: 0x2A4F971 VA: 0x2A4F870
	|-Dictionary.KeyCollection<float, CurveSample>.get_Count
	|
	|-RVA: 0x2A50250 Offset: 0x2A50351 VA: 0x2A50250
	|-Dictionary.KeyCollection<float, object>.get_Count
	|
	|-RVA: 0x2A50C30 Offset: 0x2A50D31 VA: 0x2A50C30
	|-Dictionary.KeyCollection<ushort, object>.get_Count
	|
	|-RVA: 0x2A51610 Offset: 0x2A51711 VA: 0x2A51610
	|-Dictionary.KeyCollection<uint, int>.get_Count
	|
	|-RVA: 0x2A51FF0 Offset: 0x2A520F1 VA: 0x2A51FF0
	|-Dictionary.KeyCollection<uint, Int32Enum>.get_Count
	|
	|-RVA: 0x2777150 Offset: 0x2777251 VA: 0x2777150
	|-Dictionary.KeyCollection<uint, object>.get_Count
	|
	|-RVA: 0x2777B30 Offset: 0x2777C31 VA: 0x2777B30
	|-Dictionary.KeyCollection<ulong, object>.get_Count
	|
	|-RVA: 0x2778510 Offset: 0x2778611 VA: 0x2778510
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.get_Count
	|
	|-RVA: 0x2778EF0 Offset: 0x2778FF1 VA: 0x2778EF0
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.get_Count
	|
	|-RVA: 0x27798D0 Offset: 0x27799D1 VA: 0x27798D0
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Count
	|
	|-RVA: 0x277A2B0 Offset: 0x277A3B1 VA: 0x277A2B0
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.get_Count
	|
	|-RVA: 0x277AC90 Offset: 0x277AD91 VA: 0x277AC90
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.get_Count
	|
	|-RVA: 0x277B670 Offset: 0x277B771 VA: 0x277B670
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.get_Count
	|
	|-RVA: 0x277C080 Offset: 0x277C181 VA: 0x277C080
	|-Dictionary.KeyCollection<Bounds, object>.get_Count
	|
	|-RVA: 0x277CAF0 Offset: 0x277CBF1 VA: 0x277CAF0
	|-Dictionary.KeyCollection<BoundsInt, object>.get_Count
	|
	|-RVA: 0x277D540 Offset: 0x277D641 VA: 0x277D540
	|-Dictionary.KeyCollection<Color, object>.get_Count
	|
	|-RVA: 0x277DF20 Offset: 0x277E021 VA: 0x277DF20
	|-Dictionary.KeyCollection<Color32, object>.get_Count
	|
	|-RVA: 0x277E900 Offset: 0x277EA01 VA: 0x277E900
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.get_Count
	|
	|-RVA: 0x277F2F0 Offset: 0x277F3F1 VA: 0x277F2F0
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.get_Count
	|
	|-RVA: 0x277FD00 Offset: 0x277FE01 VA: 0x277FD00
	|-Dictionary.KeyCollection<GradientColorKey, object>.get_Count
	|
	|-RVA: 0x2780790 Offset: 0x2780891 VA: 0x2780790
	|-Dictionary.KeyCollection<Keyframe, object>.get_Count
	|
	|-RVA: 0x27811F0 Offset: 0x27812F1 VA: 0x27811F0
	|-Dictionary.KeyCollection<LayerMask, object>.get_Count
	|
	|-RVA: 0x2781C40 Offset: 0x2781D41 VA: 0x2781C40
	|-Dictionary.KeyCollection<Matrix4x4, object>.get_Count
	|
	|-RVA: 0x27826D0 Offset: 0x27827D1 VA: 0x27826D0
	|-Dictionary.KeyCollection<IntVec3, object>.get_Count
	|
	|-RVA: 0x27830C0 Offset: 0x27831C1 VA: 0x27830C0
	|-Dictionary.KeyCollection<Quaternion, object>.get_Count
	|
	|-RVA: 0x2783AA0 Offset: 0x2783BA1 VA: 0x2783AA0
	|-Dictionary.KeyCollection<RangeInt, object>.get_Count
	|
	|-RVA: 0x2784490 Offset: 0x2784591 VA: 0x2784490
	|-Dictionary.KeyCollection<Rect, object>.get_Count
	|
	|-RVA: 0x2784E80 Offset: 0x2784F81 VA: 0x2784E80
	|-Dictionary.KeyCollection<RectInt, object>.get_Count
	|
	|-RVA: 0x2785860 Offset: 0x2785961 VA: 0x2785860
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.get_Count
	|
	|-RVA: 0x2786240 Offset: 0x2786341 VA: 0x2786240
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.get_Count
	|
	|-RVA: 0x2786C30 Offset: 0x2786D31 VA: 0x2786C30
	|-Dictionary.KeyCollection<Vector2, object>.get_Count
	|
	|-RVA: 0x2787610 Offset: 0x2787711 VA: 0x2787610
	|-Dictionary.KeyCollection<Vector2Int, object>.get_Count
	|
	|-RVA: 0x2788000 Offset: 0x2788101 VA: 0x2788000
	|-Dictionary.KeyCollection<Vector3, object>.get_Count
	|
	|-RVA: 0x27889F0 Offset: 0x2788AF1 VA: 0x27889F0
	|-Dictionary.KeyCollection<Vector3Int, object>.get_Count
	|
	|-RVA: 0x27893E0 Offset: 0x27894E1 VA: 0x27893E0
	|-Dictionary.KeyCollection<Vector4, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E26F0 Offset: 0x27E27F1 VA: 0x27E26F0
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E30D0 Offset: 0x27E31D1 VA: 0x27E30D0
	|-Dictionary.KeyCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E3AF0 Offset: 0x27E3BF1 VA: 0x27E3AF0
	|-Dictionary.KeyCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E45B0 Offset: 0x27E46B1 VA: 0x27E45B0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E5070 Offset: 0x27E5171 VA: 0x27E5070
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E5AC0 Offset: 0x27E5BC1 VA: 0x27E5AC0
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E64B0 Offset: 0x27E65B1 VA: 0x27E64B0
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E6EF0 Offset: 0x27E6FF1 VA: 0x27E6EF0
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E7960 Offset: 0x27E7A61 VA: 0x27E7960
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E83A0 Offset: 0x27E84A1 VA: 0x27E83A0
	|-Dictionary.KeyCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E8E40 Offset: 0x27E8F41 VA: 0x27E8E40
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27E98F0 Offset: 0x27E99F1 VA: 0x27E98F0
	|-Dictionary.KeyCollection<Parameter, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27EA390 Offset: 0x27EA491 VA: 0x27EA390
	|-Dictionary.KeyCollection<bool, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27EAD70 Offset: 0x27EAE71 VA: 0x27EAD70
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27EB750 Offset: 0x27EB851 VA: 0x27EB750
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27EC130 Offset: 0x27EC231 VA: 0x27EC130
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27ECB10 Offset: 0x27ECC11 VA: 0x27ECB10
	|-Dictionary.KeyCollection<double, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27ED500 Offset: 0x27ED601 VA: 0x27ED500
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27EDEE0 Offset: 0x27EDFE1 VA: 0x27EDEE0
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27EE8C0 Offset: 0x27EE9C1 VA: 0x27EE8C0
	|-Dictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27EF2A0 Offset: 0x27EF3A1 VA: 0x27EF2A0
	|-Dictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27EFC80 Offset: 0x27EFD81 VA: 0x27EFC80
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F0660 Offset: 0x27F0761 VA: 0x27F0660
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F1040 Offset: 0x27F1141 VA: 0x27F1040
	|-Dictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F1A20 Offset: 0x27F1B21 VA: 0x27F1A20
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F2400 Offset: 0x27F2501 VA: 0x27F2400
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F2DE0 Offset: 0x27F2EE1 VA: 0x27F2DE0
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F37C0 Offset: 0x27F38C1 VA: 0x27F37C0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F41A0 Offset: 0x27F42A1 VA: 0x27F41A0
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F4B80 Offset: 0x27F4C81 VA: 0x27F4B80
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F5560 Offset: 0x27F5661 VA: 0x27F5560
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F5F40 Offset: 0x27F6041 VA: 0x27F5F40
	|-Dictionary.KeyCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F6920 Offset: 0x27F6A21 VA: 0x27F6920
	|-Dictionary.KeyCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F7300 Offset: 0x27F7401 VA: 0x27F7300
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F7CE0 Offset: 0x27F7DE1 VA: 0x27F7CE0
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27F86C0 Offset: 0x27F87C1 VA: 0x27F86C0
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29D73C0 Offset: 0x29D74C1 VA: 0x29D73C0
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29D7DA0 Offset: 0x29D7EA1 VA: 0x29D7DA0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29D8780 Offset: 0x29D8881 VA: 0x29D8780
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29D9160 Offset: 0x29D9261 VA: 0x29D9160
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29D9B40 Offset: 0x29D9C41 VA: 0x29D9B40
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DA520 Offset: 0x29DA621 VA: 0x29DA520
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DAF00 Offset: 0x29DB001 VA: 0x29DAF00
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DB8E0 Offset: 0x29DB9E1 VA: 0x29DB8E0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DC2C0 Offset: 0x29DC3C1 VA: 0x29DC2C0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DCCA0 Offset: 0x29DCDA1 VA: 0x29DCCA0
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DD680 Offset: 0x29DD781 VA: 0x29DD680
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DE080 Offset: 0x29DE181 VA: 0x29DE080
	|-Dictionary.KeyCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DEA60 Offset: 0x29DEB61 VA: 0x29DEA60
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DF490 Offset: 0x29DF591 VA: 0x29DF490
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29DFF40 Offset: 0x29E0041 VA: 0x29DFF40
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E09A0 Offset: 0x29E0AA1 VA: 0x29E09A0
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E13B0 Offset: 0x29E14B1 VA: 0x29E13B0
	|-Dictionary.KeyCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E1E00 Offset: 0x29E1F01 VA: 0x29E1E00
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E2810 Offset: 0x29E2911 VA: 0x29E2810
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E3290 Offset: 0x29E3391 VA: 0x29E3290
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E3CD0 Offset: 0x29E3DD1 VA: 0x29E3CD0
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E4750 Offset: 0x29E4851 VA: 0x29E4750
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E5240 Offset: 0x29E5341 VA: 0x29E5240
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E5C90 Offset: 0x29E5D91 VA: 0x29E5C90
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E66A0 Offset: 0x29E67A1 VA: 0x29E66A0
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E7110 Offset: 0x29E7211 VA: 0x29E7110
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E7B60 Offset: 0x29E7C61 VA: 0x29E7B60
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E8550 Offset: 0x29E8651 VA: 0x29E8550
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E8F40 Offset: 0x29E9041 VA: 0x29E8F40
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29E9930 Offset: 0x29E9A31 VA: 0x29E9930
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29EA340 Offset: 0x29EA441 VA: 0x29EA340
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29EAD90 Offset: 0x29EAE91 VA: 0x29EAD90
	|-Dictionary.KeyCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29EB740 Offset: 0x29EB841 VA: 0x29EB740
	|-Dictionary.KeyCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29EC0F0 Offset: 0x29EC1F1 VA: 0x29EC0F0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29ECAA0 Offset: 0x29ECBA1 VA: 0x29ECAA0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29ED450 Offset: 0x29ED551 VA: 0x29ED450
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29AAA50 Offset: 0x29AAB51 VA: 0x29AAA50
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29AB400 Offset: 0x29AB501 VA: 0x29AB400
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29ABDB0 Offset: 0x29ABEB1 VA: 0x29ABDB0
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29AC760 Offset: 0x29AC861 VA: 0x29AC760
	|-Dictionary.KeyCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29AD110 Offset: 0x29AD211 VA: 0x29AD110
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29ADAC0 Offset: 0x29ADBC1 VA: 0x29ADAC0
	|-Dictionary.KeyCollection<object, Parameter>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29AE470 Offset: 0x29AE571 VA: 0x29AE470
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29AEE20 Offset: 0x29AEF21 VA: 0x29AEE20
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29AF7D0 Offset: 0x29AF8D1 VA: 0x29AF7D0
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B0180 Offset: 0x29B0281 VA: 0x29B0180
	|-Dictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B0B30 Offset: 0x29B0C31 VA: 0x29B0B30
	|-Dictionary.KeyCollection<object, DateTime>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B14E0 Offset: 0x29B15E1 VA: 0x29B14E0
	|-Dictionary.KeyCollection<object, double>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B1E90 Offset: 0x29B1F91 VA: 0x29B1E90
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B2840 Offset: 0x29B2941 VA: 0x29B2840
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B31F0 Offset: 0x29B32F1 VA: 0x29B31F0
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B3BA0 Offset: 0x29B3CA1 VA: 0x29B3BA0
	|-Dictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B4550 Offset: 0x29B4651 VA: 0x29B4550
	|-Dictionary.KeyCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B4F00 Offset: 0x29B5001 VA: 0x29B4F00
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B58B0 Offset: 0x29B59B1 VA: 0x29B58B0
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B6260 Offset: 0x29B6361 VA: 0x29B6260
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B6C10 Offset: 0x29B6D11 VA: 0x29B6C10
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B75C0 Offset: 0x29B76C1 VA: 0x29B75C0
	|-Dictionary.KeyCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B7F70 Offset: 0x29B8071 VA: 0x29B7F70
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B8920 Offset: 0x29B8A21 VA: 0x29B8920
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B92D0 Offset: 0x29B93D1 VA: 0x29B92D0
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29B9C80 Offset: 0x29B9D81 VA: 0x29B9C80
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BA630 Offset: 0x29BA731 VA: 0x29BA630
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BAFE0 Offset: 0x29BB0E1 VA: 0x29BAFE0
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BB990 Offset: 0x29BBA91 VA: 0x29BB990
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BC340 Offset: 0x29BC441 VA: 0x29BC340
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BCCF0 Offset: 0x29BCDF1 VA: 0x29BCCF0
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BD6A0 Offset: 0x29BD7A1 VA: 0x29BD6A0
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BE050 Offset: 0x29BE151 VA: 0x29BE050
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BEA00 Offset: 0x29BEB01 VA: 0x29BEA00
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BF3B0 Offset: 0x29BF4B1 VA: 0x29BF3B0
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29BFD60 Offset: 0x29BFE61 VA: 0x29BFD60
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x29C0710 Offset: 0x29C0811 VA: 0x29C0710
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A3C200 Offset: 0x2A3C301 VA: 0x2A3C200
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A3CBB0 Offset: 0x2A3CCB1 VA: 0x2A3CBB0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A3D560 Offset: 0x2A3D661 VA: 0x2A3D560
	|-Dictionary.KeyCollection<object, sbyte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A3DF10 Offset: 0x2A3E011 VA: 0x2A3DF10
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A3E8C0 Offset: 0x2A3E9C1 VA: 0x2A3E8C0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A3F270 Offset: 0x2A3F371 VA: 0x2A3F270
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A3FC20 Offset: 0x2A3FD21 VA: 0x2A3FC20
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A405D0 Offset: 0x2A406D1 VA: 0x2A405D0
	|-Dictionary.KeyCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A40F80 Offset: 0x2A41081 VA: 0x2A40F80
	|-Dictionary.KeyCollection<object, Bounds>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A41930 Offset: 0x2A41A31 VA: 0x2A41930
	|-Dictionary.KeyCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A422E0 Offset: 0x2A423E1 VA: 0x2A422E0
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A42C90 Offset: 0x2A42D91 VA: 0x2A42C90
	|-Dictionary.KeyCollection<object, Color>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A43640 Offset: 0x2A43741 VA: 0x2A43640
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A43FF0 Offset: 0x2A440F1 VA: 0x2A43FF0
	|-Dictionary.KeyCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A449A0 Offset: 0x2A44AA1 VA: 0x2A449A0
	|-Dictionary.KeyCollection<object, Keyframe>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A45350 Offset: 0x2A45451 VA: 0x2A45350
	|-Dictionary.KeyCollection<object, LayerMask>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A45D00 Offset: 0x2A45E01 VA: 0x2A45D00
	|-Dictionary.KeyCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A466B0 Offset: 0x2A467B1 VA: 0x2A466B0
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A47060 Offset: 0x2A47161 VA: 0x2A47060
	|-Dictionary.KeyCollection<object, Quaternion>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A47A10 Offset: 0x2A47B11 VA: 0x2A47A10
	|-Dictionary.KeyCollection<object, RangeInt>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A483C0 Offset: 0x2A484C1 VA: 0x2A483C0
	|-Dictionary.KeyCollection<object, Rect>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A48D70 Offset: 0x2A48E71 VA: 0x2A48D70
	|-Dictionary.KeyCollection<object, RectInt>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A49720 Offset: 0x2A49821 VA: 0x2A49720
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4A0D0 Offset: 0x2A4A1D1 VA: 0x2A4A0D0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4AA80 Offset: 0x2A4AB81 VA: 0x2A4AA80
	|-Dictionary.KeyCollection<object, Vector2>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4B430 Offset: 0x2A4B531 VA: 0x2A4B430
	|-Dictionary.KeyCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4BDE0 Offset: 0x2A4BEE1 VA: 0x2A4BDE0
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4C790 Offset: 0x2A4C891 VA: 0x2A4C790
	|-Dictionary.KeyCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4D140 Offset: 0x2A4D241 VA: 0x2A4D140
	|-Dictionary.KeyCollection<object, Vector4>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4DB00 Offset: 0x2A4DC01 VA: 0x2A4DB00
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4E4E0 Offset: 0x2A4E5E1 VA: 0x2A4E4E0
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4EEC0 Offset: 0x2A4EFC1 VA: 0x2A4EEC0
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A4F8A0 Offset: 0x2A4F9A1 VA: 0x2A4F8A0
	|-Dictionary.KeyCollection<float, CurveSample>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A50280 Offset: 0x2A50381 VA: 0x2A50280
	|-Dictionary.KeyCollection<float, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A50C60 Offset: 0x2A50D61 VA: 0x2A50C60
	|-Dictionary.KeyCollection<ushort, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A51640 Offset: 0x2A51741 VA: 0x2A51640
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A52020 Offset: 0x2A52121 VA: 0x2A52020
	|-Dictionary.KeyCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2777180 Offset: 0x2777281 VA: 0x2777180
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2777B60 Offset: 0x2777C61 VA: 0x2777B60
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2778540 Offset: 0x2778641 VA: 0x2778540
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2778F20 Offset: 0x2779021 VA: 0x2778F20
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2779900 Offset: 0x2779A01 VA: 0x2779900
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277A2E0 Offset: 0x277A3E1 VA: 0x277A2E0
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277ACC0 Offset: 0x277ADC1 VA: 0x277ACC0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277B6A0 Offset: 0x277B7A1 VA: 0x277B6A0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277C0B0 Offset: 0x277C1B1 VA: 0x277C0B0
	|-Dictionary.KeyCollection<Bounds, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277CB20 Offset: 0x277CC21 VA: 0x277CB20
	|-Dictionary.KeyCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277D570 Offset: 0x277D671 VA: 0x277D570
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277DF50 Offset: 0x277E051 VA: 0x277DF50
	|-Dictionary.KeyCollection<Color32, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277E930 Offset: 0x277EA31 VA: 0x277E930
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277F320 Offset: 0x277F421 VA: 0x277F320
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x277FD30 Offset: 0x277FE31 VA: 0x277FD30
	|-Dictionary.KeyCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27807C0 Offset: 0x27808C1 VA: 0x27807C0
	|-Dictionary.KeyCollection<Keyframe, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2781220 Offset: 0x2781321 VA: 0x2781220
	|-Dictionary.KeyCollection<LayerMask, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2781C70 Offset: 0x2781D71 VA: 0x2781C70
	|-Dictionary.KeyCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2782700 Offset: 0x2782801 VA: 0x2782700
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27830F0 Offset: 0x27831F1 VA: 0x27830F0
	|-Dictionary.KeyCollection<Quaternion, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2783AD0 Offset: 0x2783BD1 VA: 0x2783AD0
	|-Dictionary.KeyCollection<RangeInt, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x27844C0 Offset: 0x27845C1 VA: 0x27844C0
	|-Dictionary.KeyCollection<Rect, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2784EB0 Offset: 0x2784FB1 VA: 0x2784EB0
	|-Dictionary.KeyCollection<RectInt, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2785890 Offset: 0x2785991 VA: 0x2785890
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2786270 Offset: 0x2786371 VA: 0x2786270
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2786C60 Offset: 0x2786D61 VA: 0x2786C60
	|-Dictionary.KeyCollection<Vector2, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2787640 Offset: 0x2787741 VA: 0x2787640
	|-Dictionary.KeyCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2788030 Offset: 0x2788131 VA: 0x2788030
	|-Dictionary.KeyCollection<Vector3, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2788A20 Offset: 0x2788B21 VA: 0x2788A20
	|-Dictionary.KeyCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2789410 Offset: 0x2789511 VA: 0x2789410
	|-Dictionary.KeyCollection<Vector4, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E2700 Offset: 0x27E2801 VA: 0x27E2700
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E30E0 Offset: 0x27E31E1 VA: 0x27E30E0
	|-Dictionary.KeyCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E3B00 Offset: 0x27E3C01 VA: 0x27E3B00
	|-Dictionary.KeyCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E45C0 Offset: 0x27E46C1 VA: 0x27E45C0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E5080 Offset: 0x27E5181 VA: 0x27E5080
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E5AD0 Offset: 0x27E5BD1 VA: 0x27E5AD0
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E64C0 Offset: 0x27E65C1 VA: 0x27E64C0
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E6F00 Offset: 0x27E7001 VA: 0x27E6F00
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E7970 Offset: 0x27E7A71 VA: 0x27E7970
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E83B0 Offset: 0x27E84B1 VA: 0x27E83B0
	|-Dictionary.KeyCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E8E50 Offset: 0x27E8F51 VA: 0x27E8E50
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27E9900 Offset: 0x27E9A01 VA: 0x27E9900
	|-Dictionary.KeyCollection<Parameter, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27EA3A0 Offset: 0x27EA4A1 VA: 0x27EA3A0
	|-Dictionary.KeyCollection<bool, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27EAD80 Offset: 0x27EAE81 VA: 0x27EAD80
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27EB760 Offset: 0x27EB861 VA: 0x27EB760
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27EC140 Offset: 0x27EC241 VA: 0x27EC140
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27ECB20 Offset: 0x27ECC21 VA: 0x27ECB20
	|-Dictionary.KeyCollection<double, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27ED510 Offset: 0x27ED611 VA: 0x27ED510
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27EDEF0 Offset: 0x27EDFF1 VA: 0x27EDEF0
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27EE8D0 Offset: 0x27EE9D1 VA: 0x27EE8D0
	|-Dictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27EF2B0 Offset: 0x27EF3B1 VA: 0x27EF2B0
	|-Dictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27EFC90 Offset: 0x27EFD91 VA: 0x27EFC90
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F0670 Offset: 0x27F0771 VA: 0x27F0670
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F1050 Offset: 0x27F1151 VA: 0x27F1050
	|-Dictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F1A30 Offset: 0x27F1B31 VA: 0x27F1A30
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F2410 Offset: 0x27F2511 VA: 0x27F2410
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F2DF0 Offset: 0x27F2EF1 VA: 0x27F2DF0
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F37D0 Offset: 0x27F38D1 VA: 0x27F37D0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F41B0 Offset: 0x27F42B1 VA: 0x27F41B0
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F4B90 Offset: 0x27F4C91 VA: 0x27F4B90
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F5570 Offset: 0x27F5671 VA: 0x27F5570
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F5F50 Offset: 0x27F6051 VA: 0x27F5F50
	|-Dictionary.KeyCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F6930 Offset: 0x27F6A31 VA: 0x27F6930
	|-Dictionary.KeyCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F7310 Offset: 0x27F7411 VA: 0x27F7310
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F7CF0 Offset: 0x27F7DF1 VA: 0x27F7CF0
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27F86D0 Offset: 0x27F87D1 VA: 0x27F86D0
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29D73D0 Offset: 0x29D74D1 VA: 0x29D73D0
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29D7DB0 Offset: 0x29D7EB1 VA: 0x29D7DB0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29D8790 Offset: 0x29D8891 VA: 0x29D8790
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29D9170 Offset: 0x29D9271 VA: 0x29D9170
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29D9B50 Offset: 0x29D9C51 VA: 0x29D9B50
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DA530 Offset: 0x29DA631 VA: 0x29DA530
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DAF10 Offset: 0x29DB011 VA: 0x29DAF10
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DB8F0 Offset: 0x29DB9F1 VA: 0x29DB8F0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DC2D0 Offset: 0x29DC3D1 VA: 0x29DC2D0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DCCB0 Offset: 0x29DCDB1 VA: 0x29DCCB0
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DD690 Offset: 0x29DD791 VA: 0x29DD690
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DE090 Offset: 0x29DE191 VA: 0x29DE090
	|-Dictionary.KeyCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DEA70 Offset: 0x29DEB71 VA: 0x29DEA70
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DF4A0 Offset: 0x29DF5A1 VA: 0x29DF4A0
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29DFF50 Offset: 0x29E0051 VA: 0x29DFF50
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E09B0 Offset: 0x29E0AB1 VA: 0x29E09B0
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E13C0 Offset: 0x29E14C1 VA: 0x29E13C0
	|-Dictionary.KeyCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E1E10 Offset: 0x29E1F11 VA: 0x29E1E10
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E2820 Offset: 0x29E2921 VA: 0x29E2820
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E32A0 Offset: 0x29E33A1 VA: 0x29E32A0
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E3CE0 Offset: 0x29E3DE1 VA: 0x29E3CE0
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E4760 Offset: 0x29E4861 VA: 0x29E4760
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E5250 Offset: 0x29E5351 VA: 0x29E5250
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E5CA0 Offset: 0x29E5DA1 VA: 0x29E5CA0
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E66B0 Offset: 0x29E67B1 VA: 0x29E66B0
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E7120 Offset: 0x29E7221 VA: 0x29E7120
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E7B70 Offset: 0x29E7C71 VA: 0x29E7B70
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E8560 Offset: 0x29E8661 VA: 0x29E8560
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E8F50 Offset: 0x29E9051 VA: 0x29E8F50
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29E9940 Offset: 0x29E9A41 VA: 0x29E9940
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29EA350 Offset: 0x29EA451 VA: 0x29EA350
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29EADA0 Offset: 0x29EAEA1 VA: 0x29EADA0
	|-Dictionary.KeyCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29EB750 Offset: 0x29EB851 VA: 0x29EB750
	|-Dictionary.KeyCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29EC100 Offset: 0x29EC201 VA: 0x29EC100
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29ECAB0 Offset: 0x29ECBB1 VA: 0x29ECAB0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29ED460 Offset: 0x29ED561 VA: 0x29ED460
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29AAA60 Offset: 0x29AAB61 VA: 0x29AAA60
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29AB410 Offset: 0x29AB511 VA: 0x29AB410
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29ABDC0 Offset: 0x29ABEC1 VA: 0x29ABDC0
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29AC770 Offset: 0x29AC871 VA: 0x29AC770
	|-Dictionary.KeyCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29AD120 Offset: 0x29AD221 VA: 0x29AD120
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29ADAD0 Offset: 0x29ADBD1 VA: 0x29ADAD0
	|-Dictionary.KeyCollection<object, Parameter>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29AE480 Offset: 0x29AE581 VA: 0x29AE480
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29AEE30 Offset: 0x29AEF31 VA: 0x29AEE30
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29AF7E0 Offset: 0x29AF8E1 VA: 0x29AF7E0
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B0190 Offset: 0x29B0291 VA: 0x29B0190
	|-Dictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B0B40 Offset: 0x29B0C41 VA: 0x29B0B40
	|-Dictionary.KeyCollection<object, DateTime>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B14F0 Offset: 0x29B15F1 VA: 0x29B14F0
	|-Dictionary.KeyCollection<object, double>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B1EA0 Offset: 0x29B1FA1 VA: 0x29B1EA0
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B2850 Offset: 0x29B2951 VA: 0x29B2850
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B3200 Offset: 0x29B3301 VA: 0x29B3200
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B3BB0 Offset: 0x29B3CB1 VA: 0x29B3BB0
	|-Dictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B4560 Offset: 0x29B4661 VA: 0x29B4560
	|-Dictionary.KeyCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B4F10 Offset: 0x29B5011 VA: 0x29B4F10
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B58C0 Offset: 0x29B59C1 VA: 0x29B58C0
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B6270 Offset: 0x29B6371 VA: 0x29B6270
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B6C20 Offset: 0x29B6D21 VA: 0x29B6C20
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B75D0 Offset: 0x29B76D1 VA: 0x29B75D0
	|-Dictionary.KeyCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B7F80 Offset: 0x29B8081 VA: 0x29B7F80
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B8930 Offset: 0x29B8A31 VA: 0x29B8930
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B92E0 Offset: 0x29B93E1 VA: 0x29B92E0
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29B9C90 Offset: 0x29B9D91 VA: 0x29B9C90
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BA640 Offset: 0x29BA741 VA: 0x29BA640
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BAFF0 Offset: 0x29BB0F1 VA: 0x29BAFF0
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BB9A0 Offset: 0x29BBAA1 VA: 0x29BB9A0
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BC350 Offset: 0x29BC451 VA: 0x29BC350
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BCD00 Offset: 0x29BCE01 VA: 0x29BCD00
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BD6B0 Offset: 0x29BD7B1 VA: 0x29BD6B0
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BE060 Offset: 0x29BE161 VA: 0x29BE060
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BEA10 Offset: 0x29BEB11 VA: 0x29BEA10
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BF3C0 Offset: 0x29BF4C1 VA: 0x29BF3C0
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29BFD70 Offset: 0x29BFE71 VA: 0x29BFD70
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x29C0720 Offset: 0x29C0821 VA: 0x29C0720
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A3C210 Offset: 0x2A3C311 VA: 0x2A3C210
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A3CBC0 Offset: 0x2A3CCC1 VA: 0x2A3CBC0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A3D570 Offset: 0x2A3D671 VA: 0x2A3D570
	|-Dictionary.KeyCollection<object, sbyte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A3DF20 Offset: 0x2A3E021 VA: 0x2A3DF20
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A3E8D0 Offset: 0x2A3E9D1 VA: 0x2A3E8D0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A3F280 Offset: 0x2A3F381 VA: 0x2A3F280
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A3FC30 Offset: 0x2A3FD31 VA: 0x2A3FC30
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A405E0 Offset: 0x2A406E1 VA: 0x2A405E0
	|-Dictionary.KeyCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A40F90 Offset: 0x2A41091 VA: 0x2A40F90
	|-Dictionary.KeyCollection<object, Bounds>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A41940 Offset: 0x2A41A41 VA: 0x2A41940
	|-Dictionary.KeyCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A422F0 Offset: 0x2A423F1 VA: 0x2A422F0
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A42CA0 Offset: 0x2A42DA1 VA: 0x2A42CA0
	|-Dictionary.KeyCollection<object, Color>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A43650 Offset: 0x2A43751 VA: 0x2A43650
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A44000 Offset: 0x2A44101 VA: 0x2A44000
	|-Dictionary.KeyCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A449B0 Offset: 0x2A44AB1 VA: 0x2A449B0
	|-Dictionary.KeyCollection<object, Keyframe>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A45360 Offset: 0x2A45461 VA: 0x2A45360
	|-Dictionary.KeyCollection<object, LayerMask>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A45D10 Offset: 0x2A45E11 VA: 0x2A45D10
	|-Dictionary.KeyCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A466C0 Offset: 0x2A467C1 VA: 0x2A466C0
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A47070 Offset: 0x2A47171 VA: 0x2A47070
	|-Dictionary.KeyCollection<object, Quaternion>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A47A20 Offset: 0x2A47B21 VA: 0x2A47A20
	|-Dictionary.KeyCollection<object, RangeInt>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A483D0 Offset: 0x2A484D1 VA: 0x2A483D0
	|-Dictionary.KeyCollection<object, Rect>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A48D80 Offset: 0x2A48E81 VA: 0x2A48D80
	|-Dictionary.KeyCollection<object, RectInt>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A49730 Offset: 0x2A49831 VA: 0x2A49730
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4A0E0 Offset: 0x2A4A1E1 VA: 0x2A4A0E0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4AA90 Offset: 0x2A4AB91 VA: 0x2A4AA90
	|-Dictionary.KeyCollection<object, Vector2>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4B440 Offset: 0x2A4B541 VA: 0x2A4B440
	|-Dictionary.KeyCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4BDF0 Offset: 0x2A4BEF1 VA: 0x2A4BDF0
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4C7A0 Offset: 0x2A4C8A1 VA: 0x2A4C7A0
	|-Dictionary.KeyCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4D150 Offset: 0x2A4D251 VA: 0x2A4D150
	|-Dictionary.KeyCollection<object, Vector4>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4DB10 Offset: 0x2A4DC11 VA: 0x2A4DB10
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4E4F0 Offset: 0x2A4E5F1 VA: 0x2A4E4F0
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4EED0 Offset: 0x2A4EFD1 VA: 0x2A4EED0
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A4F8B0 Offset: 0x2A4F9B1 VA: 0x2A4F8B0
	|-Dictionary.KeyCollection<float, CurveSample>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A50290 Offset: 0x2A50391 VA: 0x2A50290
	|-Dictionary.KeyCollection<float, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A50C70 Offset: 0x2A50D71 VA: 0x2A50C70
	|-Dictionary.KeyCollection<ushort, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A51650 Offset: 0x2A51751 VA: 0x2A51650
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A52030 Offset: 0x2A52131 VA: 0x2A52030
	|-Dictionary.KeyCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2777190 Offset: 0x2777291 VA: 0x2777190
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2777B70 Offset: 0x2777C71 VA: 0x2777B70
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2778550 Offset: 0x2778651 VA: 0x2778550
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2778F30 Offset: 0x2779031 VA: 0x2778F30
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2779910 Offset: 0x2779A11 VA: 0x2779910
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277A2F0 Offset: 0x277A3F1 VA: 0x277A2F0
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277ACD0 Offset: 0x277ADD1 VA: 0x277ACD0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277B6B0 Offset: 0x277B7B1 VA: 0x277B6B0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277C0C0 Offset: 0x277C1C1 VA: 0x277C0C0
	|-Dictionary.KeyCollection<Bounds, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277CB30 Offset: 0x277CC31 VA: 0x277CB30
	|-Dictionary.KeyCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277D580 Offset: 0x277D681 VA: 0x277D580
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277DF60 Offset: 0x277E061 VA: 0x277DF60
	|-Dictionary.KeyCollection<Color32, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277E940 Offset: 0x277EA41 VA: 0x277E940
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277F330 Offset: 0x277F431 VA: 0x277F330
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x277FD40 Offset: 0x277FE41 VA: 0x277FD40
	|-Dictionary.KeyCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27807D0 Offset: 0x27808D1 VA: 0x27807D0
	|-Dictionary.KeyCollection<Keyframe, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2781230 Offset: 0x2781331 VA: 0x2781230
	|-Dictionary.KeyCollection<LayerMask, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2781C80 Offset: 0x2781D81 VA: 0x2781C80
	|-Dictionary.KeyCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2782710 Offset: 0x2782811 VA: 0x2782710
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2783100 Offset: 0x2783201 VA: 0x2783100
	|-Dictionary.KeyCollection<Quaternion, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2783AE0 Offset: 0x2783BE1 VA: 0x2783AE0
	|-Dictionary.KeyCollection<RangeInt, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27844D0 Offset: 0x27845D1 VA: 0x27844D0
	|-Dictionary.KeyCollection<Rect, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2784EC0 Offset: 0x2784FC1 VA: 0x2784EC0
	|-Dictionary.KeyCollection<RectInt, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x27858A0 Offset: 0x27859A1 VA: 0x27858A0
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2786280 Offset: 0x2786381 VA: 0x2786280
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2786C70 Offset: 0x2786D71 VA: 0x2786C70
	|-Dictionary.KeyCollection<Vector2, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2787650 Offset: 0x2787751 VA: 0x2787650
	|-Dictionary.KeyCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2788040 Offset: 0x2788141 VA: 0x2788040
	|-Dictionary.KeyCollection<Vector3, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2788A30 Offset: 0x2788B31 VA: 0x2788A30
	|-Dictionary.KeyCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2789420 Offset: 0x2789521 VA: 0x2789420
	|-Dictionary.KeyCollection<Vector4, object>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E2770 Offset: 0x27E2871 VA: 0x27E2770
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E3150 Offset: 0x27E3251 VA: 0x27E3150
	|-Dictionary.KeyCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E3B70 Offset: 0x27E3C71 VA: 0x27E3B70
	|-Dictionary.KeyCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E4630 Offset: 0x27E4731 VA: 0x27E4630
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E50F0 Offset: 0x27E51F1 VA: 0x27E50F0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E5B40 Offset: 0x27E5C41 VA: 0x27E5B40
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E6530 Offset: 0x27E6631 VA: 0x27E6530
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E6F70 Offset: 0x27E7071 VA: 0x27E6F70
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E79E0 Offset: 0x27E7AE1 VA: 0x27E79E0
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E8420 Offset: 0x27E8521 VA: 0x27E8420
	|-Dictionary.KeyCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E8EC0 Offset: 0x27E8FC1 VA: 0x27E8EC0
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27E9970 Offset: 0x27E9A71 VA: 0x27E9970
	|-Dictionary.KeyCollection<Parameter, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27EA410 Offset: 0x27EA511 VA: 0x27EA410
	|-Dictionary.KeyCollection<bool, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27EADF0 Offset: 0x27EAEF1 VA: 0x27EADF0
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27EB7D0 Offset: 0x27EB8D1 VA: 0x27EB7D0
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27EC1B0 Offset: 0x27EC2B1 VA: 0x27EC1B0
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27ECB90 Offset: 0x27ECC91 VA: 0x27ECB90
	|-Dictionary.KeyCollection<double, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27ED580 Offset: 0x27ED681 VA: 0x27ED580
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27EDF60 Offset: 0x27EE061 VA: 0x27EDF60
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27EE940 Offset: 0x27EEA41 VA: 0x27EE940
	|-Dictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27EF320 Offset: 0x27EF421 VA: 0x27EF320
	|-Dictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27EFD00 Offset: 0x27EFE01 VA: 0x27EFD00
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F06E0 Offset: 0x27F07E1 VA: 0x27F06E0
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F10C0 Offset: 0x27F11C1 VA: 0x27F10C0
	|-Dictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F1AA0 Offset: 0x27F1BA1 VA: 0x27F1AA0
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F2480 Offset: 0x27F2581 VA: 0x27F2480
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F2E60 Offset: 0x27F2F61 VA: 0x27F2E60
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F3840 Offset: 0x27F3941 VA: 0x27F3840
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F4220 Offset: 0x27F4321 VA: 0x27F4220
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F4C00 Offset: 0x27F4D01 VA: 0x27F4C00
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F55E0 Offset: 0x27F56E1 VA: 0x27F55E0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F5FC0 Offset: 0x27F60C1 VA: 0x27F5FC0
	|-Dictionary.KeyCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F69A0 Offset: 0x27F6AA1 VA: 0x27F69A0
	|-Dictionary.KeyCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F7380 Offset: 0x27F7481 VA: 0x27F7380
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F7D60 Offset: 0x27F7E61 VA: 0x27F7D60
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27F8740 Offset: 0x27F8841 VA: 0x27F8740
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29D7440 Offset: 0x29D7541 VA: 0x29D7440
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29D7E20 Offset: 0x29D7F21 VA: 0x29D7E20
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29D8800 Offset: 0x29D8901 VA: 0x29D8800
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29D91E0 Offset: 0x29D92E1 VA: 0x29D91E0
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29D9BC0 Offset: 0x29D9CC1 VA: 0x29D9BC0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DA5A0 Offset: 0x29DA6A1 VA: 0x29DA5A0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DAF80 Offset: 0x29DB081 VA: 0x29DAF80
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DB960 Offset: 0x29DBA61 VA: 0x29DB960
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DC340 Offset: 0x29DC441 VA: 0x29DC340
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DCD20 Offset: 0x29DCE21 VA: 0x29DCD20
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DD700 Offset: 0x29DD801 VA: 0x29DD700
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DE100 Offset: 0x29DE201 VA: 0x29DE100
	|-Dictionary.KeyCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DEAE0 Offset: 0x29DEBE1 VA: 0x29DEAE0
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DF510 Offset: 0x29DF611 VA: 0x29DF510
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29DFFC0 Offset: 0x29E00C1 VA: 0x29DFFC0
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E0A20 Offset: 0x29E0B21 VA: 0x29E0A20
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E1430 Offset: 0x29E1531 VA: 0x29E1430
	|-Dictionary.KeyCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E1E80 Offset: 0x29E1F81 VA: 0x29E1E80
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E2890 Offset: 0x29E2991 VA: 0x29E2890
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E3310 Offset: 0x29E3411 VA: 0x29E3310
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E3D50 Offset: 0x29E3E51 VA: 0x29E3D50
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E47D0 Offset: 0x29E48D1 VA: 0x29E47D0
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E52C0 Offset: 0x29E53C1 VA: 0x29E52C0
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E5D10 Offset: 0x29E5E11 VA: 0x29E5D10
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E6720 Offset: 0x29E6821 VA: 0x29E6720
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E7190 Offset: 0x29E7291 VA: 0x29E7190
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E7BE0 Offset: 0x29E7CE1 VA: 0x29E7BE0
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E85D0 Offset: 0x29E86D1 VA: 0x29E85D0
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E8FC0 Offset: 0x29E90C1 VA: 0x29E8FC0
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29E99B0 Offset: 0x29E9AB1 VA: 0x29E99B0
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29EA3C0 Offset: 0x29EA4C1 VA: 0x29EA3C0
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29EAE10 Offset: 0x29EAF11 VA: 0x29EAE10
	|-Dictionary.KeyCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29EB7C0 Offset: 0x29EB8C1 VA: 0x29EB7C0
	|-Dictionary.KeyCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29EC170 Offset: 0x29EC271 VA: 0x29EC170
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29ECB20 Offset: 0x29ECC21 VA: 0x29ECB20
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29ED4D0 Offset: 0x29ED5D1 VA: 0x29ED4D0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29AAAD0 Offset: 0x29AABD1 VA: 0x29AAAD0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29AB480 Offset: 0x29AB581 VA: 0x29AB480
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29ABE30 Offset: 0x29ABF31 VA: 0x29ABE30
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29AC7E0 Offset: 0x29AC8E1 VA: 0x29AC7E0
	|-Dictionary.KeyCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29AD190 Offset: 0x29AD291 VA: 0x29AD190
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29ADB40 Offset: 0x29ADC41 VA: 0x29ADB40
	|-Dictionary.KeyCollection<object, Parameter>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29AE4F0 Offset: 0x29AE5F1 VA: 0x29AE4F0
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29AEEA0 Offset: 0x29AEFA1 VA: 0x29AEEA0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29AF850 Offset: 0x29AF951 VA: 0x29AF850
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B0200 Offset: 0x29B0301 VA: 0x29B0200
	|-Dictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B0BB0 Offset: 0x29B0CB1 VA: 0x29B0BB0
	|-Dictionary.KeyCollection<object, DateTime>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B1560 Offset: 0x29B1661 VA: 0x29B1560
	|-Dictionary.KeyCollection<object, double>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B1F10 Offset: 0x29B2011 VA: 0x29B1F10
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B28C0 Offset: 0x29B29C1 VA: 0x29B28C0
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B3270 Offset: 0x29B3371 VA: 0x29B3270
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B3C20 Offset: 0x29B3D21 VA: 0x29B3C20
	|-Dictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B45D0 Offset: 0x29B46D1 VA: 0x29B45D0
	|-Dictionary.KeyCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B4F80 Offset: 0x29B5081 VA: 0x29B4F80
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B5930 Offset: 0x29B5A31 VA: 0x29B5930
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B62E0 Offset: 0x29B63E1 VA: 0x29B62E0
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B6C90 Offset: 0x29B6D91 VA: 0x29B6C90
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B7640 Offset: 0x29B7741 VA: 0x29B7640
	|-Dictionary.KeyCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B7FF0 Offset: 0x29B80F1 VA: 0x29B7FF0
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B89A0 Offset: 0x29B8AA1 VA: 0x29B89A0
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B9350 Offset: 0x29B9451 VA: 0x29B9350
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29B9D00 Offset: 0x29B9E01 VA: 0x29B9D00
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BA6B0 Offset: 0x29BA7B1 VA: 0x29BA6B0
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BB060 Offset: 0x29BB161 VA: 0x29BB060
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BBA10 Offset: 0x29BBB11 VA: 0x29BBA10
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BC3C0 Offset: 0x29BC4C1 VA: 0x29BC3C0
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BCD70 Offset: 0x29BCE71 VA: 0x29BCD70
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BD720 Offset: 0x29BD821 VA: 0x29BD720
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BE0D0 Offset: 0x29BE1D1 VA: 0x29BE0D0
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BEA80 Offset: 0x29BEB81 VA: 0x29BEA80
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BF430 Offset: 0x29BF531 VA: 0x29BF430
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29BFDE0 Offset: 0x29BFEE1 VA: 0x29BFDE0
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x29C0790 Offset: 0x29C0891 VA: 0x29C0790
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A3C280 Offset: 0x2A3C381 VA: 0x2A3C280
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A3CC30 Offset: 0x2A3CD31 VA: 0x2A3CC30
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A3D5E0 Offset: 0x2A3D6E1 VA: 0x2A3D5E0
	|-Dictionary.KeyCollection<object, sbyte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A3DF90 Offset: 0x2A3E091 VA: 0x2A3DF90
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A3E940 Offset: 0x2A3EA41 VA: 0x2A3E940
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A3F2F0 Offset: 0x2A3F3F1 VA: 0x2A3F2F0
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A3FCA0 Offset: 0x2A3FDA1 VA: 0x2A3FCA0
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A40650 Offset: 0x2A40751 VA: 0x2A40650
	|-Dictionary.KeyCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A41000 Offset: 0x2A41101 VA: 0x2A41000
	|-Dictionary.KeyCollection<object, Bounds>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A419B0 Offset: 0x2A41AB1 VA: 0x2A419B0
	|-Dictionary.KeyCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A42360 Offset: 0x2A42461 VA: 0x2A42360
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A42D10 Offset: 0x2A42E11 VA: 0x2A42D10
	|-Dictionary.KeyCollection<object, Color>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A436C0 Offset: 0x2A437C1 VA: 0x2A436C0
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A44070 Offset: 0x2A44171 VA: 0x2A44070
	|-Dictionary.KeyCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A44A20 Offset: 0x2A44B21 VA: 0x2A44A20
	|-Dictionary.KeyCollection<object, Keyframe>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A453D0 Offset: 0x2A454D1 VA: 0x2A453D0
	|-Dictionary.KeyCollection<object, LayerMask>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A45D80 Offset: 0x2A45E81 VA: 0x2A45D80
	|-Dictionary.KeyCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A46730 Offset: 0x2A46831 VA: 0x2A46730
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A470E0 Offset: 0x2A471E1 VA: 0x2A470E0
	|-Dictionary.KeyCollection<object, Quaternion>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A47A90 Offset: 0x2A47B91 VA: 0x2A47A90
	|-Dictionary.KeyCollection<object, RangeInt>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A48440 Offset: 0x2A48541 VA: 0x2A48440
	|-Dictionary.KeyCollection<object, Rect>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A48DF0 Offset: 0x2A48EF1 VA: 0x2A48DF0
	|-Dictionary.KeyCollection<object, RectInt>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A497A0 Offset: 0x2A498A1 VA: 0x2A497A0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4A150 Offset: 0x2A4A251 VA: 0x2A4A150
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4AB00 Offset: 0x2A4AC01 VA: 0x2A4AB00
	|-Dictionary.KeyCollection<object, Vector2>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4B4B0 Offset: 0x2A4B5B1 VA: 0x2A4B4B0
	|-Dictionary.KeyCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4BE60 Offset: 0x2A4BF61 VA: 0x2A4BE60
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4C810 Offset: 0x2A4C911 VA: 0x2A4C810
	|-Dictionary.KeyCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4D1C0 Offset: 0x2A4D2C1 VA: 0x2A4D1C0
	|-Dictionary.KeyCollection<object, Vector4>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4DB80 Offset: 0x2A4DC81 VA: 0x2A4DB80
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4E560 Offset: 0x2A4E661 VA: 0x2A4E560
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4EF40 Offset: 0x2A4F041 VA: 0x2A4EF40
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A4F920 Offset: 0x2A4FA21 VA: 0x2A4F920
	|-Dictionary.KeyCollection<float, CurveSample>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A50300 Offset: 0x2A50401 VA: 0x2A50300
	|-Dictionary.KeyCollection<float, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A50CE0 Offset: 0x2A50DE1 VA: 0x2A50CE0
	|-Dictionary.KeyCollection<ushort, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A516C0 Offset: 0x2A517C1 VA: 0x2A516C0
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A520A0 Offset: 0x2A521A1 VA: 0x2A520A0
	|-Dictionary.KeyCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2777200 Offset: 0x2777301 VA: 0x2777200
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2777BE0 Offset: 0x2777CE1 VA: 0x2777BE0
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27785C0 Offset: 0x27786C1 VA: 0x27785C0
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2778FA0 Offset: 0x27790A1 VA: 0x2778FA0
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2779980 Offset: 0x2779A81 VA: 0x2779980
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277A360 Offset: 0x277A461 VA: 0x277A360
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277AD40 Offset: 0x277AE41 VA: 0x277AD40
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277B720 Offset: 0x277B821 VA: 0x277B720
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277C130 Offset: 0x277C231 VA: 0x277C130
	|-Dictionary.KeyCollection<Bounds, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277CBA0 Offset: 0x277CCA1 VA: 0x277CBA0
	|-Dictionary.KeyCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277D5F0 Offset: 0x277D6F1 VA: 0x277D5F0
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277DFD0 Offset: 0x277E0D1 VA: 0x277DFD0
	|-Dictionary.KeyCollection<Color32, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277E9B0 Offset: 0x277EAB1 VA: 0x277E9B0
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277F3A0 Offset: 0x277F4A1 VA: 0x277F3A0
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x277FDB0 Offset: 0x277FEB1 VA: 0x277FDB0
	|-Dictionary.KeyCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2780840 Offset: 0x2780941 VA: 0x2780840
	|-Dictionary.KeyCollection<Keyframe, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27812A0 Offset: 0x27813A1 VA: 0x27812A0
	|-Dictionary.KeyCollection<LayerMask, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2781CF0 Offset: 0x2781DF1 VA: 0x2781CF0
	|-Dictionary.KeyCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2782780 Offset: 0x2782881 VA: 0x2782780
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2783170 Offset: 0x2783271 VA: 0x2783170
	|-Dictionary.KeyCollection<Quaternion, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2783B50 Offset: 0x2783C51 VA: 0x2783B50
	|-Dictionary.KeyCollection<RangeInt, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2784540 Offset: 0x2784641 VA: 0x2784540
	|-Dictionary.KeyCollection<Rect, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2784F30 Offset: 0x2785031 VA: 0x2784F30
	|-Dictionary.KeyCollection<RectInt, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2785910 Offset: 0x2785A11 VA: 0x2785910
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27862F0 Offset: 0x27863F1 VA: 0x27862F0
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2786CE0 Offset: 0x2786DE1 VA: 0x2786CE0
	|-Dictionary.KeyCollection<Vector2, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27876C0 Offset: 0x27877C1 VA: 0x27876C0
	|-Dictionary.KeyCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x27880B0 Offset: 0x27881B1 VA: 0x27880B0
	|-Dictionary.KeyCollection<Vector3, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2788AA0 Offset: 0x2788BA1 VA: 0x2788AA0
	|-Dictionary.KeyCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2789490 Offset: 0x2789591 VA: 0x2789490
	|-Dictionary.KeyCollection<Vector4, object>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E27E0 Offset: 0x27E28E1 VA: 0x27E27E0
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E31C0 Offset: 0x27E32C1 VA: 0x27E31C0
	|-Dictionary.KeyCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E3BE0 Offset: 0x27E3CE1 VA: 0x27E3BE0
	|-Dictionary.KeyCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E46A0 Offset: 0x27E47A1 VA: 0x27E46A0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E5160 Offset: 0x27E5261 VA: 0x27E5160
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E5BB0 Offset: 0x27E5CB1 VA: 0x27E5BB0
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E65A0 Offset: 0x27E66A1 VA: 0x27E65A0
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E6FE0 Offset: 0x27E70E1 VA: 0x27E6FE0
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E7A50 Offset: 0x27E7B51 VA: 0x27E7A50
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E8490 Offset: 0x27E8591 VA: 0x27E8490
	|-Dictionary.KeyCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E8F30 Offset: 0x27E9031 VA: 0x27E8F30
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27E99E0 Offset: 0x27E9AE1 VA: 0x27E99E0
	|-Dictionary.KeyCollection<Parameter, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27EA480 Offset: 0x27EA581 VA: 0x27EA480
	|-Dictionary.KeyCollection<bool, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27EAE60 Offset: 0x27EAF61 VA: 0x27EAE60
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27EB840 Offset: 0x27EB941 VA: 0x27EB840
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27EC220 Offset: 0x27EC321 VA: 0x27EC220
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27ECC00 Offset: 0x27ECD01 VA: 0x27ECC00
	|-Dictionary.KeyCollection<double, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27ED5F0 Offset: 0x27ED6F1 VA: 0x27ED5F0
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27EDFD0 Offset: 0x27EE0D1 VA: 0x27EDFD0
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27EE9B0 Offset: 0x27EEAB1 VA: 0x27EE9B0
	|-Dictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27EF390 Offset: 0x27EF491 VA: 0x27EF390
	|-Dictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27EFD70 Offset: 0x27EFE71 VA: 0x27EFD70
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F0750 Offset: 0x27F0851 VA: 0x27F0750
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F1130 Offset: 0x27F1231 VA: 0x27F1130
	|-Dictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F1B10 Offset: 0x27F1C11 VA: 0x27F1B10
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F24F0 Offset: 0x27F25F1 VA: 0x27F24F0
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F2ED0 Offset: 0x27F2FD1 VA: 0x27F2ED0
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F38B0 Offset: 0x27F39B1 VA: 0x27F38B0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F4290 Offset: 0x27F4391 VA: 0x27F4290
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F4C70 Offset: 0x27F4D71 VA: 0x27F4C70
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F5650 Offset: 0x27F5751 VA: 0x27F5650
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F6030 Offset: 0x27F6131 VA: 0x27F6030
	|-Dictionary.KeyCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F6A10 Offset: 0x27F6B11 VA: 0x27F6A10
	|-Dictionary.KeyCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F73F0 Offset: 0x27F74F1 VA: 0x27F73F0
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F7DD0 Offset: 0x27F7ED1 VA: 0x27F7DD0
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27F87B0 Offset: 0x27F88B1 VA: 0x27F87B0
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29D74B0 Offset: 0x29D75B1 VA: 0x29D74B0
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29D7E90 Offset: 0x29D7F91 VA: 0x29D7E90
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29D8870 Offset: 0x29D8971 VA: 0x29D8870
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29D9250 Offset: 0x29D9351 VA: 0x29D9250
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29D9C30 Offset: 0x29D9D31 VA: 0x29D9C30
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29DA610 Offset: 0x29DA711 VA: 0x29DA610
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29DAFF0 Offset: 0x29DB0F1 VA: 0x29DAFF0
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29DB9D0 Offset: 0x29DBAD1 VA: 0x29DB9D0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29DC3B0 Offset: 0x29DC4B1 VA: 0x29DC3B0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29DCD90 Offset: 0x29DCE91 VA: 0x29DCD90
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29DD770 Offset: 0x29DD871 VA: 0x29DD770
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29DE170 Offset: 0x29DE271 VA: 0x29DE170
	|-Dictionary.KeyCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29DEB50 Offset: 0x29DEC51 VA: 0x29DEB50
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29DF580 Offset: 0x29DF681 VA: 0x29DF580
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E0030 Offset: 0x29E0131 VA: 0x29E0030
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E0A90 Offset: 0x29E0B91 VA: 0x29E0A90
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E14A0 Offset: 0x29E15A1 VA: 0x29E14A0
	|-Dictionary.KeyCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E1EF0 Offset: 0x29E1FF1 VA: 0x29E1EF0
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E2900 Offset: 0x29E2A01 VA: 0x29E2900
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E3380 Offset: 0x29E3481 VA: 0x29E3380
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E3DC0 Offset: 0x29E3EC1 VA: 0x29E3DC0
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E4840 Offset: 0x29E4941 VA: 0x29E4840
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E5330 Offset: 0x29E5431 VA: 0x29E5330
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E5D80 Offset: 0x29E5E81 VA: 0x29E5D80
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E6790 Offset: 0x29E6891 VA: 0x29E6790
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E7200 Offset: 0x29E7301 VA: 0x29E7200
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E7C50 Offset: 0x29E7D51 VA: 0x29E7C50
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E8640 Offset: 0x29E8741 VA: 0x29E8640
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E9030 Offset: 0x29E9131 VA: 0x29E9030
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29E9A20 Offset: 0x29E9B21 VA: 0x29E9A20
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29EA430 Offset: 0x29EA531 VA: 0x29EA430
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29EAE80 Offset: 0x29EAF81 VA: 0x29EAE80
	|-Dictionary.KeyCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29EB830 Offset: 0x29EB931 VA: 0x29EB830
	|-Dictionary.KeyCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29EC1E0 Offset: 0x29EC2E1 VA: 0x29EC1E0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29ECB90 Offset: 0x29ECC91 VA: 0x29ECB90
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29ED540 Offset: 0x29ED641 VA: 0x29ED540
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29AAB40 Offset: 0x29AAC41 VA: 0x29AAB40
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29AB4F0 Offset: 0x29AB5F1 VA: 0x29AB4F0
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29ABEA0 Offset: 0x29ABFA1 VA: 0x29ABEA0
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29AC850 Offset: 0x29AC951 VA: 0x29AC850
	|-Dictionary.KeyCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29AD200 Offset: 0x29AD301 VA: 0x29AD200
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29ADBB0 Offset: 0x29ADCB1 VA: 0x29ADBB0
	|-Dictionary.KeyCollection<object, Parameter>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29AE560 Offset: 0x29AE661 VA: 0x29AE560
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29AEF10 Offset: 0x29AF011 VA: 0x29AEF10
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29AF8C0 Offset: 0x29AF9C1 VA: 0x29AF8C0
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B0270 Offset: 0x29B0371 VA: 0x29B0270
	|-Dictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B0C20 Offset: 0x29B0D21 VA: 0x29B0C20
	|-Dictionary.KeyCollection<object, DateTime>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B15D0 Offset: 0x29B16D1 VA: 0x29B15D0
	|-Dictionary.KeyCollection<object, double>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B1F80 Offset: 0x29B2081 VA: 0x29B1F80
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B2930 Offset: 0x29B2A31 VA: 0x29B2930
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B32E0 Offset: 0x29B33E1 VA: 0x29B32E0
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B3C90 Offset: 0x29B3D91 VA: 0x29B3C90
	|-Dictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B4640 Offset: 0x29B4741 VA: 0x29B4640
	|-Dictionary.KeyCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B4FF0 Offset: 0x29B50F1 VA: 0x29B4FF0
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B59A0 Offset: 0x29B5AA1 VA: 0x29B59A0
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B6350 Offset: 0x29B6451 VA: 0x29B6350
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B6D00 Offset: 0x29B6E01 VA: 0x29B6D00
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B76B0 Offset: 0x29B77B1 VA: 0x29B76B0
	|-Dictionary.KeyCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B8060 Offset: 0x29B8161 VA: 0x29B8060
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B8A10 Offset: 0x29B8B11 VA: 0x29B8A10
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B93C0 Offset: 0x29B94C1 VA: 0x29B93C0
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29B9D70 Offset: 0x29B9E71 VA: 0x29B9D70
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BA720 Offset: 0x29BA821 VA: 0x29BA720
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BB0D0 Offset: 0x29BB1D1 VA: 0x29BB0D0
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BBA80 Offset: 0x29BBB81 VA: 0x29BBA80
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BC430 Offset: 0x29BC531 VA: 0x29BC430
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BCDE0 Offset: 0x29BCEE1 VA: 0x29BCDE0
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BD790 Offset: 0x29BD891 VA: 0x29BD790
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BE140 Offset: 0x29BE241 VA: 0x29BE140
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BEAF0 Offset: 0x29BEBF1 VA: 0x29BEAF0
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BF4A0 Offset: 0x29BF5A1 VA: 0x29BF4A0
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29BFE50 Offset: 0x29BFF51 VA: 0x29BFE50
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x29C0800 Offset: 0x29C0901 VA: 0x29C0800
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A3C2F0 Offset: 0x2A3C3F1 VA: 0x2A3C2F0
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A3CCA0 Offset: 0x2A3CDA1 VA: 0x2A3CCA0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A3D650 Offset: 0x2A3D751 VA: 0x2A3D650
	|-Dictionary.KeyCollection<object, sbyte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A3E000 Offset: 0x2A3E101 VA: 0x2A3E000
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A3E9B0 Offset: 0x2A3EAB1 VA: 0x2A3E9B0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A3F360 Offset: 0x2A3F461 VA: 0x2A3F360
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A3FD10 Offset: 0x2A3FE11 VA: 0x2A3FD10
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A406C0 Offset: 0x2A407C1 VA: 0x2A406C0
	|-Dictionary.KeyCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A41070 Offset: 0x2A41171 VA: 0x2A41070
	|-Dictionary.KeyCollection<object, Bounds>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A41A20 Offset: 0x2A41B21 VA: 0x2A41A20
	|-Dictionary.KeyCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A423D0 Offset: 0x2A424D1 VA: 0x2A423D0
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A42D80 Offset: 0x2A42E81 VA: 0x2A42D80
	|-Dictionary.KeyCollection<object, Color>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A43730 Offset: 0x2A43831 VA: 0x2A43730
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A440E0 Offset: 0x2A441E1 VA: 0x2A440E0
	|-Dictionary.KeyCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A44A90 Offset: 0x2A44B91 VA: 0x2A44A90
	|-Dictionary.KeyCollection<object, Keyframe>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A45440 Offset: 0x2A45541 VA: 0x2A45440
	|-Dictionary.KeyCollection<object, LayerMask>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A45DF0 Offset: 0x2A45EF1 VA: 0x2A45DF0
	|-Dictionary.KeyCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A467A0 Offset: 0x2A468A1 VA: 0x2A467A0
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A47150 Offset: 0x2A47251 VA: 0x2A47150
	|-Dictionary.KeyCollection<object, Quaternion>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A47B00 Offset: 0x2A47C01 VA: 0x2A47B00
	|-Dictionary.KeyCollection<object, RangeInt>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A484B0 Offset: 0x2A485B1 VA: 0x2A484B0
	|-Dictionary.KeyCollection<object, Rect>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A48E60 Offset: 0x2A48F61 VA: 0x2A48E60
	|-Dictionary.KeyCollection<object, RectInt>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A49810 Offset: 0x2A49911 VA: 0x2A49810
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4A1C0 Offset: 0x2A4A2C1 VA: 0x2A4A1C0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4AB70 Offset: 0x2A4AC71 VA: 0x2A4AB70
	|-Dictionary.KeyCollection<object, Vector2>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4B520 Offset: 0x2A4B621 VA: 0x2A4B520
	|-Dictionary.KeyCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4BED0 Offset: 0x2A4BFD1 VA: 0x2A4BED0
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4C880 Offset: 0x2A4C981 VA: 0x2A4C880
	|-Dictionary.KeyCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4D230 Offset: 0x2A4D331 VA: 0x2A4D230
	|-Dictionary.KeyCollection<object, Vector4>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4DBF0 Offset: 0x2A4DCF1 VA: 0x2A4DBF0
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4E5D0 Offset: 0x2A4E6D1 VA: 0x2A4E5D0
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4EFB0 Offset: 0x2A4F0B1 VA: 0x2A4EFB0
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A4F990 Offset: 0x2A4FA91 VA: 0x2A4F990
	|-Dictionary.KeyCollection<float, CurveSample>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A50370 Offset: 0x2A50471 VA: 0x2A50370
	|-Dictionary.KeyCollection<float, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A50D50 Offset: 0x2A50E51 VA: 0x2A50D50
	|-Dictionary.KeyCollection<ushort, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A51730 Offset: 0x2A51831 VA: 0x2A51730
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A52110 Offset: 0x2A52211 VA: 0x2A52110
	|-Dictionary.KeyCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2777270 Offset: 0x2777371 VA: 0x2777270
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2777C50 Offset: 0x2777D51 VA: 0x2777C50
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2778630 Offset: 0x2778731 VA: 0x2778630
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2779010 Offset: 0x2779111 VA: 0x2779010
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27799F0 Offset: 0x2779AF1 VA: 0x27799F0
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277A3D0 Offset: 0x277A4D1 VA: 0x277A3D0
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277ADB0 Offset: 0x277AEB1 VA: 0x277ADB0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277B790 Offset: 0x277B891 VA: 0x277B790
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277C1A0 Offset: 0x277C2A1 VA: 0x277C1A0
	|-Dictionary.KeyCollection<Bounds, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277CC10 Offset: 0x277CD11 VA: 0x277CC10
	|-Dictionary.KeyCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277D660 Offset: 0x277D761 VA: 0x277D660
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277E040 Offset: 0x277E141 VA: 0x277E040
	|-Dictionary.KeyCollection<Color32, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277EA20 Offset: 0x277EB21 VA: 0x277EA20
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277F410 Offset: 0x277F511 VA: 0x277F410
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x277FE20 Offset: 0x277FF21 VA: 0x277FE20
	|-Dictionary.KeyCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27808B0 Offset: 0x27809B1 VA: 0x27808B0
	|-Dictionary.KeyCollection<Keyframe, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2781310 Offset: 0x2781411 VA: 0x2781310
	|-Dictionary.KeyCollection<LayerMask, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2781D60 Offset: 0x2781E61 VA: 0x2781D60
	|-Dictionary.KeyCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27827F0 Offset: 0x27828F1 VA: 0x27827F0
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27831E0 Offset: 0x27832E1 VA: 0x27831E0
	|-Dictionary.KeyCollection<Quaternion, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2783BC0 Offset: 0x2783CC1 VA: 0x2783BC0
	|-Dictionary.KeyCollection<RangeInt, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x27845B0 Offset: 0x27846B1 VA: 0x27845B0
	|-Dictionary.KeyCollection<Rect, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2784FA0 Offset: 0x27850A1 VA: 0x2784FA0
	|-Dictionary.KeyCollection<RectInt, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2785980 Offset: 0x2785A81 VA: 0x2785980
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2786360 Offset: 0x2786461 VA: 0x2786360
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2786D50 Offset: 0x2786E51 VA: 0x2786D50
	|-Dictionary.KeyCollection<Vector2, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2787730 Offset: 0x2787831 VA: 0x2787730
	|-Dictionary.KeyCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2788120 Offset: 0x2788221 VA: 0x2788120
	|-Dictionary.KeyCollection<Vector3, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2788B10 Offset: 0x2788C11 VA: 0x2788B10
	|-Dictionary.KeyCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2789500 Offset: 0x2789601 VA: 0x2789500
	|-Dictionary.KeyCollection<Vector4, object>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E2810 Offset: 0x27E2911 VA: 0x27E2810
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E31F0 Offset: 0x27E32F1 VA: 0x27E31F0
	|-Dictionary.KeyCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E3C50 Offset: 0x27E3D51 VA: 0x27E3C50
	|-Dictionary.KeyCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E4730 Offset: 0x27E4831 VA: 0x27E4730
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E51D0 Offset: 0x27E52D1 VA: 0x27E51D0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E5BE0 Offset: 0x27E5CE1 VA: 0x27E5BE0
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E65D0 Offset: 0x27E66D1 VA: 0x27E65D0
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E7060 Offset: 0x27E7161 VA: 0x27E7060
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E7A80 Offset: 0x27E7B81 VA: 0x27E7A80
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E8510 Offset: 0x27E8611 VA: 0x27E8510
	|-Dictionary.KeyCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E8FA0 Offset: 0x27E90A1 VA: 0x27E8FA0
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27E9A60 Offset: 0x27E9B61 VA: 0x27E9A60
	|-Dictionary.KeyCollection<Parameter, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27EA4B0 Offset: 0x27EA5B1 VA: 0x27EA4B0
	|-Dictionary.KeyCollection<bool, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27EAE90 Offset: 0x27EAF91 VA: 0x27EAE90
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27EB870 Offset: 0x27EB971 VA: 0x27EB870
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27EC250 Offset: 0x27EC351 VA: 0x27EC250
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27ECC30 Offset: 0x27ECD31 VA: 0x27ECC30
	|-Dictionary.KeyCollection<double, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27ED620 Offset: 0x27ED721 VA: 0x27ED620
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27EE000 Offset: 0x27EE101 VA: 0x27EE000
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27EE9E0 Offset: 0x27EEAE1 VA: 0x27EE9E0
	|-Dictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27EF3C0 Offset: 0x27EF4C1 VA: 0x27EF3C0
	|-Dictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27EFDA0 Offset: 0x27EFEA1 VA: 0x27EFDA0
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F0780 Offset: 0x27F0881 VA: 0x27F0780
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F1160 Offset: 0x27F1261 VA: 0x27F1160
	|-Dictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F1B40 Offset: 0x27F1C41 VA: 0x27F1B40
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F2520 Offset: 0x27F2621 VA: 0x27F2520
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F2F00 Offset: 0x27F3001 VA: 0x27F2F00
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F38E0 Offset: 0x27F39E1 VA: 0x27F38E0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F42C0 Offset: 0x27F43C1 VA: 0x27F42C0
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F4CA0 Offset: 0x27F4DA1 VA: 0x27F4CA0
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F5680 Offset: 0x27F5781 VA: 0x27F5680
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F6060 Offset: 0x27F6161 VA: 0x27F6060
	|-Dictionary.KeyCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F6A40 Offset: 0x27F6B41 VA: 0x27F6A40
	|-Dictionary.KeyCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F7420 Offset: 0x27F7521 VA: 0x27F7420
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F7E00 Offset: 0x27F7F01 VA: 0x27F7E00
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27F87E0 Offset: 0x27F88E1 VA: 0x27F87E0
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29D74E0 Offset: 0x29D75E1 VA: 0x29D74E0
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29D7EC0 Offset: 0x29D7FC1 VA: 0x29D7EC0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29D88A0 Offset: 0x29D89A1 VA: 0x29D88A0
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29D9280 Offset: 0x29D9381 VA: 0x29D9280
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29D9C60 Offset: 0x29D9D61 VA: 0x29D9C60
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29DA640 Offset: 0x29DA741 VA: 0x29DA640
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29DB020 Offset: 0x29DB121 VA: 0x29DB020
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29DBA00 Offset: 0x29DBB01 VA: 0x29DBA00
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29DC3E0 Offset: 0x29DC4E1 VA: 0x29DC3E0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29DCDC0 Offset: 0x29DCEC1 VA: 0x29DCDC0
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29DD7A0 Offset: 0x29DD8A1 VA: 0x29DD7A0
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29DE1A0 Offset: 0x29DE2A1 VA: 0x29DE1A0
	|-Dictionary.KeyCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29DEB80 Offset: 0x29DEC81 VA: 0x29DEB80
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29DF600 Offset: 0x29DF701 VA: 0x29DF600
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E00B0 Offset: 0x29E01B1 VA: 0x29E00B0
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E0AC0 Offset: 0x29E0BC1 VA: 0x29E0AC0
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E1510 Offset: 0x29E1611 VA: 0x29E1510
	|-Dictionary.KeyCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E1F20 Offset: 0x29E2021 VA: 0x29E1F20
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E2970 Offset: 0x29E2A71 VA: 0x29E2970
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E33F0 Offset: 0x29E34F1 VA: 0x29E33F0
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E3DF0 Offset: 0x29E3EF1 VA: 0x29E3DF0
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E48E0 Offset: 0x29E49E1 VA: 0x29E48E0
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E53A0 Offset: 0x29E54A1 VA: 0x29E53A0
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E5DB0 Offset: 0x29E5EB1 VA: 0x29E5DB0
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E6800 Offset: 0x29E6901 VA: 0x29E6800
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E7270 Offset: 0x29E7371 VA: 0x29E7270
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E7C80 Offset: 0x29E7D81 VA: 0x29E7C80
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E8670 Offset: 0x29E8771 VA: 0x29E8670
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E9060 Offset: 0x29E9161 VA: 0x29E9060
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29E9A50 Offset: 0x29E9B51 VA: 0x29E9A50
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29EA4A0 Offset: 0x29EA5A1 VA: 0x29EA4A0
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29EAEB0 Offset: 0x29EAFB1 VA: 0x29EAEB0
	|-Dictionary.KeyCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29EB860 Offset: 0x29EB961 VA: 0x29EB860
	|-Dictionary.KeyCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29EC210 Offset: 0x29EC311 VA: 0x29EC210
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29ECBC0 Offset: 0x29ECCC1 VA: 0x29ECBC0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29ED570 Offset: 0x29ED671 VA: 0x29ED570
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29AAB70 Offset: 0x29AAC71 VA: 0x29AAB70
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29AB520 Offset: 0x29AB621 VA: 0x29AB520
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29ABED0 Offset: 0x29ABFD1 VA: 0x29ABED0
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29AC880 Offset: 0x29AC981 VA: 0x29AC880
	|-Dictionary.KeyCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29AD230 Offset: 0x29AD331 VA: 0x29AD230
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29ADBE0 Offset: 0x29ADCE1 VA: 0x29ADBE0
	|-Dictionary.KeyCollection<object, Parameter>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29AE590 Offset: 0x29AE691 VA: 0x29AE590
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29AEF40 Offset: 0x29AF041 VA: 0x29AEF40
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29AF8F0 Offset: 0x29AF9F1 VA: 0x29AF8F0
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B02A0 Offset: 0x29B03A1 VA: 0x29B02A0
	|-Dictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B0C50 Offset: 0x29B0D51 VA: 0x29B0C50
	|-Dictionary.KeyCollection<object, DateTime>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B1600 Offset: 0x29B1701 VA: 0x29B1600
	|-Dictionary.KeyCollection<object, double>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B1FB0 Offset: 0x29B20B1 VA: 0x29B1FB0
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B2960 Offset: 0x29B2A61 VA: 0x29B2960
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B3310 Offset: 0x29B3411 VA: 0x29B3310
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B3CC0 Offset: 0x29B3DC1 VA: 0x29B3CC0
	|-Dictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B4670 Offset: 0x29B4771 VA: 0x29B4670
	|-Dictionary.KeyCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B5020 Offset: 0x29B5121 VA: 0x29B5020
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B59D0 Offset: 0x29B5AD1 VA: 0x29B59D0
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B6380 Offset: 0x29B6481 VA: 0x29B6380
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B6D30 Offset: 0x29B6E31 VA: 0x29B6D30
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B76E0 Offset: 0x29B77E1 VA: 0x29B76E0
	|-Dictionary.KeyCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B8090 Offset: 0x29B8191 VA: 0x29B8090
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B8A40 Offset: 0x29B8B41 VA: 0x29B8A40
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B93F0 Offset: 0x29B94F1 VA: 0x29B93F0
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29B9DA0 Offset: 0x29B9EA1 VA: 0x29B9DA0
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BA750 Offset: 0x29BA851 VA: 0x29BA750
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BB100 Offset: 0x29BB201 VA: 0x29BB100
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BBAB0 Offset: 0x29BBBB1 VA: 0x29BBAB0
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BC460 Offset: 0x29BC561 VA: 0x29BC460
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BCE10 Offset: 0x29BCF11 VA: 0x29BCE10
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BD7C0 Offset: 0x29BD8C1 VA: 0x29BD7C0
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BE170 Offset: 0x29BE271 VA: 0x29BE170
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BEB20 Offset: 0x29BEC21 VA: 0x29BEB20
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BF4D0 Offset: 0x29BF5D1 VA: 0x29BF4D0
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29BFE80 Offset: 0x29BFF81 VA: 0x29BFE80
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x29C0830 Offset: 0x29C0931 VA: 0x29C0830
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A3C320 Offset: 0x2A3C421 VA: 0x2A3C320
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A3CCD0 Offset: 0x2A3CDD1 VA: 0x2A3CCD0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A3D680 Offset: 0x2A3D781 VA: 0x2A3D680
	|-Dictionary.KeyCollection<object, sbyte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A3E030 Offset: 0x2A3E131 VA: 0x2A3E030
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A3E9E0 Offset: 0x2A3EAE1 VA: 0x2A3E9E0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A3F390 Offset: 0x2A3F491 VA: 0x2A3F390
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A3FD40 Offset: 0x2A3FE41 VA: 0x2A3FD40
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A406F0 Offset: 0x2A407F1 VA: 0x2A406F0
	|-Dictionary.KeyCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A410A0 Offset: 0x2A411A1 VA: 0x2A410A0
	|-Dictionary.KeyCollection<object, Bounds>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A41A50 Offset: 0x2A41B51 VA: 0x2A41A50
	|-Dictionary.KeyCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A42400 Offset: 0x2A42501 VA: 0x2A42400
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A42DB0 Offset: 0x2A42EB1 VA: 0x2A42DB0
	|-Dictionary.KeyCollection<object, Color>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A43760 Offset: 0x2A43861 VA: 0x2A43760
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A44110 Offset: 0x2A44211 VA: 0x2A44110
	|-Dictionary.KeyCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A44AC0 Offset: 0x2A44BC1 VA: 0x2A44AC0
	|-Dictionary.KeyCollection<object, Keyframe>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A45470 Offset: 0x2A45571 VA: 0x2A45470
	|-Dictionary.KeyCollection<object, LayerMask>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A45E20 Offset: 0x2A45F21 VA: 0x2A45E20
	|-Dictionary.KeyCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A467D0 Offset: 0x2A468D1 VA: 0x2A467D0
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A47180 Offset: 0x2A47281 VA: 0x2A47180
	|-Dictionary.KeyCollection<object, Quaternion>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A47B30 Offset: 0x2A47C31 VA: 0x2A47B30
	|-Dictionary.KeyCollection<object, RangeInt>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A484E0 Offset: 0x2A485E1 VA: 0x2A484E0
	|-Dictionary.KeyCollection<object, Rect>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A48E90 Offset: 0x2A48F91 VA: 0x2A48E90
	|-Dictionary.KeyCollection<object, RectInt>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A49840 Offset: 0x2A49941 VA: 0x2A49840
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4A1F0 Offset: 0x2A4A2F1 VA: 0x2A4A1F0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4ABA0 Offset: 0x2A4ACA1 VA: 0x2A4ABA0
	|-Dictionary.KeyCollection<object, Vector2>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4B550 Offset: 0x2A4B651 VA: 0x2A4B550
	|-Dictionary.KeyCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4BF00 Offset: 0x2A4C001 VA: 0x2A4BF00
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4C8B0 Offset: 0x2A4C9B1 VA: 0x2A4C8B0
	|-Dictionary.KeyCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4D260 Offset: 0x2A4D361 VA: 0x2A4D260
	|-Dictionary.KeyCollection<object, Vector4>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4DC20 Offset: 0x2A4DD21 VA: 0x2A4DC20
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4E600 Offset: 0x2A4E701 VA: 0x2A4E600
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4EFE0 Offset: 0x2A4F0E1 VA: 0x2A4EFE0
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A4F9C0 Offset: 0x2A4FAC1 VA: 0x2A4F9C0
	|-Dictionary.KeyCollection<float, CurveSample>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A503A0 Offset: 0x2A504A1 VA: 0x2A503A0
	|-Dictionary.KeyCollection<float, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A50D80 Offset: 0x2A50E81 VA: 0x2A50D80
	|-Dictionary.KeyCollection<ushort, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A51760 Offset: 0x2A51861 VA: 0x2A51760
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A52140 Offset: 0x2A52241 VA: 0x2A52140
	|-Dictionary.KeyCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27772A0 Offset: 0x27773A1 VA: 0x27772A0
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2777C80 Offset: 0x2777D81 VA: 0x2777C80
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2778660 Offset: 0x2778761 VA: 0x2778660
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2779040 Offset: 0x2779141 VA: 0x2779040
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2779A20 Offset: 0x2779B21 VA: 0x2779A20
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277A400 Offset: 0x277A501 VA: 0x277A400
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277ADE0 Offset: 0x277AEE1 VA: 0x277ADE0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277B7C0 Offset: 0x277B8C1 VA: 0x277B7C0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277C210 Offset: 0x277C311 VA: 0x277C210
	|-Dictionary.KeyCollection<Bounds, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277CC80 Offset: 0x277CD81 VA: 0x277CC80
	|-Dictionary.KeyCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277D690 Offset: 0x277D791 VA: 0x277D690
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277E070 Offset: 0x277E171 VA: 0x277E070
	|-Dictionary.KeyCollection<Color32, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277EA50 Offset: 0x277EB51 VA: 0x277EA50
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277F440 Offset: 0x277F541 VA: 0x277F440
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x277FE90 Offset: 0x277FF91 VA: 0x277FE90
	|-Dictionary.KeyCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2780930 Offset: 0x2780A31 VA: 0x2780930
	|-Dictionary.KeyCollection<Keyframe, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2781340 Offset: 0x2781441 VA: 0x2781340
	|-Dictionary.KeyCollection<LayerMask, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2781DF0 Offset: 0x2781EF1 VA: 0x2781DF0
	|-Dictionary.KeyCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2782820 Offset: 0x2782921 VA: 0x2782820
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2783210 Offset: 0x2783311 VA: 0x2783210
	|-Dictionary.KeyCollection<Quaternion, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2783BF0 Offset: 0x2783CF1 VA: 0x2783BF0
	|-Dictionary.KeyCollection<RangeInt, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27845E0 Offset: 0x27846E1 VA: 0x27845E0
	|-Dictionary.KeyCollection<Rect, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2784FD0 Offset: 0x27850D1 VA: 0x2784FD0
	|-Dictionary.KeyCollection<RectInt, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x27859B0 Offset: 0x2785AB1 VA: 0x27859B0
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2786390 Offset: 0x2786491 VA: 0x2786390
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2786D80 Offset: 0x2786E81 VA: 0x2786D80
	|-Dictionary.KeyCollection<Vector2, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2787760 Offset: 0x2787861 VA: 0x2787760
	|-Dictionary.KeyCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2788150 Offset: 0x2788251 VA: 0x2788150
	|-Dictionary.KeyCollection<Vector3, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2788B40 Offset: 0x2788C41 VA: 0x2788B40
	|-Dictionary.KeyCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2789530 Offset: 0x2789631 VA: 0x2789530
	|-Dictionary.KeyCollection<Vector4, object>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E2880 Offset: 0x27E2981 VA: 0x27E2880
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E3260 Offset: 0x27E3361 VA: 0x27E3260
	|-Dictionary.KeyCollection<BitVector32Int, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E3CC0 Offset: 0x27E3DC1 VA: 0x27E3CC0
	|-Dictionary.KeyCollection<EventCheckId, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E47A0 Offset: 0x27E48A1 VA: 0x27E47A0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E5240 Offset: 0x27E5341 VA: 0x27E5240
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E5C50 Offset: 0x27E5D51 VA: 0x27E5C50
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E6640 Offset: 0x27E6741 VA: 0x27E6640
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E70D0 Offset: 0x27E71D1 VA: 0x27E70D0
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E7AF0 Offset: 0x27E7BF1 VA: 0x27E7AF0
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E8580 Offset: 0x27E8681 VA: 0x27E8580
	|-Dictionary.KeyCollection<OrderSaveData, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E9010 Offset: 0x27E9111 VA: 0x27E9010
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27E9AD0 Offset: 0x27E9BD1 VA: 0x27E9AD0
	|-Dictionary.KeyCollection<Parameter, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27EA520 Offset: 0x27EA621 VA: 0x27EA520
	|-Dictionary.KeyCollection<bool, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27EAF00 Offset: 0x27EB001 VA: 0x27EAF00
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27EB8E0 Offset: 0x27EB9E1 VA: 0x27EB8E0
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27EC2C0 Offset: 0x27EC3C1 VA: 0x27EC2C0
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27ECCA0 Offset: 0x27ECDA1 VA: 0x27ECCA0
	|-Dictionary.KeyCollection<double, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27ED690 Offset: 0x27ED791 VA: 0x27ED690
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27EE070 Offset: 0x27EE171 VA: 0x27EE070
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27EEA50 Offset: 0x27EEB51 VA: 0x27EEA50
	|-Dictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27EF430 Offset: 0x27EF531 VA: 0x27EF430
	|-Dictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27EFE10 Offset: 0x27EFF11 VA: 0x27EFE10
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F07F0 Offset: 0x27F08F1 VA: 0x27F07F0
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F11D0 Offset: 0x27F12D1 VA: 0x27F11D0
	|-Dictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F1BB0 Offset: 0x27F1CB1 VA: 0x27F1BB0
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F2590 Offset: 0x27F2691 VA: 0x27F2590
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F2F70 Offset: 0x27F3071 VA: 0x27F2F70
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F3950 Offset: 0x27F3A51 VA: 0x27F3950
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F4330 Offset: 0x27F4431 VA: 0x27F4330
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F4D10 Offset: 0x27F4E11 VA: 0x27F4D10
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F56F0 Offset: 0x27F57F1 VA: 0x27F56F0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F60D0 Offset: 0x27F61D1 VA: 0x27F60D0
	|-Dictionary.KeyCollection<int, SceneInstance>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F6AB0 Offset: 0x27F6BB1 VA: 0x27F6AB0
	|-Dictionary.KeyCollection<int, Vector2Int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F7490 Offset: 0x27F7591 VA: 0x27F7490
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F7E70 Offset: 0x27F7F71 VA: 0x27F7E70
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27F8850 Offset: 0x27F8951 VA: 0x27F8850
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29D7550 Offset: 0x29D7651 VA: 0x29D7550
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29D7F30 Offset: 0x29D8031 VA: 0x29D7F30
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29D8910 Offset: 0x29D8A11 VA: 0x29D8910
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29D92F0 Offset: 0x29D93F1 VA: 0x29D92F0
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29D9CD0 Offset: 0x29D9DD1 VA: 0x29D9CD0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29DA6B0 Offset: 0x29DA7B1 VA: 0x29DA6B0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29DB090 Offset: 0x29DB191 VA: 0x29DB090
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29DBA70 Offset: 0x29DBB71 VA: 0x29DBA70
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29DC450 Offset: 0x29DC551 VA: 0x29DC450
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29DCE30 Offset: 0x29DCF31 VA: 0x29DCE30
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29DD810 Offset: 0x29DD911 VA: 0x29DD810
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29DE210 Offset: 0x29DE311 VA: 0x29DE210
	|-Dictionary.KeyCollection<Memory<object>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29DEBF0 Offset: 0x29DECF1 VA: 0x29DEBF0
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29DF670 Offset: 0x29DF771 VA: 0x29DF670
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E0120 Offset: 0x29E0221 VA: 0x29E0120
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E0B30 Offset: 0x29E0C31 VA: 0x29E0B30
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E1580 Offset: 0x29E1681 VA: 0x29E1580
	|-Dictionary.KeyCollection<Nullable<Color>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E1F90 Offset: 0x29E2091 VA: 0x29E1F90
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E29E0 Offset: 0x29E2AE1 VA: 0x29E29E0
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E3460 Offset: 0x29E3561 VA: 0x29E3460
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E3E60 Offset: 0x29E3F61 VA: 0x29E3E60
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E4950 Offset: 0x29E4A51 VA: 0x29E4950
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E5410 Offset: 0x29E5511 VA: 0x29E5410
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E5E20 Offset: 0x29E5F21 VA: 0x29E5E20
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E6870 Offset: 0x29E6971 VA: 0x29E6870
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E72E0 Offset: 0x29E73E1 VA: 0x29E72E0
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E7CF0 Offset: 0x29E7DF1 VA: 0x29E7CF0
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E86E0 Offset: 0x29E87E1 VA: 0x29E86E0
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E90D0 Offset: 0x29E91D1 VA: 0x29E90D0
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29E9AC0 Offset: 0x29E9BC1 VA: 0x29E9AC0
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29EA510 Offset: 0x29EA611 VA: 0x29EA510
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29EAF20 Offset: 0x29EB021 VA: 0x29EAF20
	|-Dictionary.KeyCollection<object, BitVector32Int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29EB8D0 Offset: 0x29EB9D1 VA: 0x29EB8D0
	|-Dictionary.KeyCollection<object, EventCheckId>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29EC280 Offset: 0x29EC381 VA: 0x29EC280
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29ECC30 Offset: 0x29ECD31 VA: 0x29ECC30
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29ED5E0 Offset: 0x29ED6E1 VA: 0x29ED5E0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29AABE0 Offset: 0x29AACE1 VA: 0x29AABE0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29AB590 Offset: 0x29AB691 VA: 0x29AB590
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29ABF40 Offset: 0x29AC041 VA: 0x29ABF40
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29AC8F0 Offset: 0x29AC9F1 VA: 0x29AC8F0
	|-Dictionary.KeyCollection<object, OrderSaveData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29AD2A0 Offset: 0x29AD3A1 VA: 0x29AD2A0
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29ADC50 Offset: 0x29ADD51 VA: 0x29ADC50
	|-Dictionary.KeyCollection<object, Parameter>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29AE600 Offset: 0x29AE701 VA: 0x29AE600
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29AEFB0 Offset: 0x29AF0B1 VA: 0x29AEFB0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29AF960 Offset: 0x29AFA61 VA: 0x29AF960
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B0310 Offset: 0x29B0411 VA: 0x29B0310
	|-Dictionary.KeyCollection<object, char>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B0CC0 Offset: 0x29B0DC1 VA: 0x29B0CC0
	|-Dictionary.KeyCollection<object, DateTime>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B1670 Offset: 0x29B1771 VA: 0x29B1670
	|-Dictionary.KeyCollection<object, double>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B2020 Offset: 0x29B2121 VA: 0x29B2020
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B29D0 Offset: 0x29B2AD1 VA: 0x29B29D0
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B3380 Offset: 0x29B3481 VA: 0x29B3380
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B3D30 Offset: 0x29B3E31 VA: 0x29B3D30
	|-Dictionary.KeyCollection<object, long>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B46E0 Offset: 0x29B47E1 VA: 0x29B46E0
	|-Dictionary.KeyCollection<object, Memory<object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B5090 Offset: 0x29B5191 VA: 0x29B5090
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B5A40 Offset: 0x29B5B41 VA: 0x29B5A40
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B63F0 Offset: 0x29B64F1 VA: 0x29B63F0
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B6DA0 Offset: 0x29B6EA1 VA: 0x29B6DA0
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B7750 Offset: 0x29B7851 VA: 0x29B7750
	|-Dictionary.KeyCollection<object, Nullable<Color>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B8100 Offset: 0x29B8201 VA: 0x29B8100
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B8AB0 Offset: 0x29B8BB1 VA: 0x29B8AB0
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B9460 Offset: 0x29B9561 VA: 0x29B9460
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29B9E10 Offset: 0x29B9F11 VA: 0x29B9E10
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BA7C0 Offset: 0x29BA8C1 VA: 0x29BA7C0
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BB170 Offset: 0x29BB271 VA: 0x29BB170
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BBB20 Offset: 0x29BBC21 VA: 0x29BBB20
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BC4D0 Offset: 0x29BC5D1 VA: 0x29BC4D0
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BCE80 Offset: 0x29BCF81 VA: 0x29BCE80
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BD830 Offset: 0x29BD931 VA: 0x29BD830
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BE1E0 Offset: 0x29BE2E1 VA: 0x29BE1E0
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BEB90 Offset: 0x29BEC91 VA: 0x29BEB90
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BF540 Offset: 0x29BF641 VA: 0x29BF540
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29BFEF0 Offset: 0x29BFFF1 VA: 0x29BFEF0
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x29C08A0 Offset: 0x29C09A1 VA: 0x29C08A0
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A3C390 Offset: 0x2A3C491 VA: 0x2A3C390
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A3CD40 Offset: 0x2A3CE41 VA: 0x2A3CD40
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A3D6F0 Offset: 0x2A3D7F1 VA: 0x2A3D6F0
	|-Dictionary.KeyCollection<object, sbyte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A3E0A0 Offset: 0x2A3E1A1 VA: 0x2A3E0A0
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A3EA50 Offset: 0x2A3EB51 VA: 0x2A3EA50
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A3F400 Offset: 0x2A3F501 VA: 0x2A3F400
	|-Dictionary.KeyCollection<object, uint>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A3FDB0 Offset: 0x2A3FEB1 VA: 0x2A3FDB0
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A40760 Offset: 0x2A40861 VA: 0x2A40760
	|-Dictionary.KeyCollection<object, TransitionTables>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A41110 Offset: 0x2A41211 VA: 0x2A41110
	|-Dictionary.KeyCollection<object, Bounds>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A41AC0 Offset: 0x2A41BC1 VA: 0x2A41AC0
	|-Dictionary.KeyCollection<object, BoundsInt>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A42470 Offset: 0x2A42571 VA: 0x2A42470
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A42E20 Offset: 0x2A42F21 VA: 0x2A42E20
	|-Dictionary.KeyCollection<object, Color>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A437D0 Offset: 0x2A438D1 VA: 0x2A437D0
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A44180 Offset: 0x2A44281 VA: 0x2A44180
	|-Dictionary.KeyCollection<object, GradientColorKey>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A44B30 Offset: 0x2A44C31 VA: 0x2A44B30
	|-Dictionary.KeyCollection<object, Keyframe>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A454E0 Offset: 0x2A455E1 VA: 0x2A454E0
	|-Dictionary.KeyCollection<object, LayerMask>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A45E90 Offset: 0x2A45F91 VA: 0x2A45E90
	|-Dictionary.KeyCollection<object, Matrix4x4>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A46840 Offset: 0x2A46941 VA: 0x2A46840
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A471F0 Offset: 0x2A472F1 VA: 0x2A471F0
	|-Dictionary.KeyCollection<object, Quaternion>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A47BA0 Offset: 0x2A47CA1 VA: 0x2A47BA0
	|-Dictionary.KeyCollection<object, RangeInt>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A48550 Offset: 0x2A48651 VA: 0x2A48550
	|-Dictionary.KeyCollection<object, Rect>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A48F00 Offset: 0x2A49001 VA: 0x2A48F00
	|-Dictionary.KeyCollection<object, RectInt>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A498B0 Offset: 0x2A499B1 VA: 0x2A498B0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4A260 Offset: 0x2A4A361 VA: 0x2A4A260
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4AC10 Offset: 0x2A4AD11 VA: 0x2A4AC10
	|-Dictionary.KeyCollection<object, Vector2>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4B5C0 Offset: 0x2A4B6C1 VA: 0x2A4B5C0
	|-Dictionary.KeyCollection<object, Vector2Int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4BF70 Offset: 0x2A4C071 VA: 0x2A4BF70
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4C920 Offset: 0x2A4CA21 VA: 0x2A4C920
	|-Dictionary.KeyCollection<object, Vector3Int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4D2D0 Offset: 0x2A4D3D1 VA: 0x2A4D2D0
	|-Dictionary.KeyCollection<object, Vector4>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4DC90 Offset: 0x2A4DD91 VA: 0x2A4DC90
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4E670 Offset: 0x2A4E771 VA: 0x2A4E670
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4F050 Offset: 0x2A4F151 VA: 0x2A4F050
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A4FA30 Offset: 0x2A4FB31 VA: 0x2A4FA30
	|-Dictionary.KeyCollection<float, CurveSample>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A50410 Offset: 0x2A50511 VA: 0x2A50410
	|-Dictionary.KeyCollection<float, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A50DF0 Offset: 0x2A50EF1 VA: 0x2A50DF0
	|-Dictionary.KeyCollection<ushort, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A517D0 Offset: 0x2A518D1 VA: 0x2A517D0
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A521B0 Offset: 0x2A522B1 VA: 0x2A521B0
	|-Dictionary.KeyCollection<uint, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2777310 Offset: 0x2777411 VA: 0x2777310
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2777CF0 Offset: 0x2777DF1 VA: 0x2777CF0
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27786D0 Offset: 0x27787D1 VA: 0x27786D0
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27790B0 Offset: 0x27791B1 VA: 0x27790B0
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2779A90 Offset: 0x2779B91 VA: 0x2779A90
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277A470 Offset: 0x277A571 VA: 0x277A470
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277AE50 Offset: 0x277AF51 VA: 0x277AE50
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277B830 Offset: 0x277B931 VA: 0x277B830
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277C280 Offset: 0x277C381 VA: 0x277C280
	|-Dictionary.KeyCollection<Bounds, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277CCF0 Offset: 0x277CDF1 VA: 0x277CCF0
	|-Dictionary.KeyCollection<BoundsInt, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277D700 Offset: 0x277D801 VA: 0x277D700
	|-Dictionary.KeyCollection<Color, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277E0E0 Offset: 0x277E1E1 VA: 0x277E0E0
	|-Dictionary.KeyCollection<Color32, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277EAC0 Offset: 0x277EBC1 VA: 0x277EAC0
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277F4B0 Offset: 0x277F5B1 VA: 0x277F4B0
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x277FF00 Offset: 0x2780001 VA: 0x277FF00
	|-Dictionary.KeyCollection<GradientColorKey, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27809A0 Offset: 0x2780AA1 VA: 0x27809A0
	|-Dictionary.KeyCollection<Keyframe, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27813B0 Offset: 0x27814B1 VA: 0x27813B0
	|-Dictionary.KeyCollection<LayerMask, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2781E60 Offset: 0x2781F61 VA: 0x2781E60
	|-Dictionary.KeyCollection<Matrix4x4, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2782890 Offset: 0x2782991 VA: 0x2782890
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2783280 Offset: 0x2783381 VA: 0x2783280
	|-Dictionary.KeyCollection<Quaternion, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2783C60 Offset: 0x2783D61 VA: 0x2783C60
	|-Dictionary.KeyCollection<RangeInt, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2784650 Offset: 0x2784751 VA: 0x2784650
	|-Dictionary.KeyCollection<Rect, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2785040 Offset: 0x2785141 VA: 0x2785040
	|-Dictionary.KeyCollection<RectInt, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2785A20 Offset: 0x2785B21 VA: 0x2785A20
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2786400 Offset: 0x2786501 VA: 0x2786400
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2786DF0 Offset: 0x2786EF1 VA: 0x2786DF0
	|-Dictionary.KeyCollection<Vector2, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27877D0 Offset: 0x27878D1 VA: 0x27877D0
	|-Dictionary.KeyCollection<Vector2Int, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27881C0 Offset: 0x27882C1 VA: 0x27881C0
	|-Dictionary.KeyCollection<Vector3, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2788BB0 Offset: 0x2788CB1 VA: 0x2788BB0
	|-Dictionary.KeyCollection<Vector3Int, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x27895A0 Offset: 0x27896A1 VA: 0x27895A0
	|-Dictionary.KeyCollection<Vector4, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E2900 Offset: 0x27E2A01 VA: 0x27E2900
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E32E0 Offset: 0x27E33E1 VA: 0x27E32E0
	|-Dictionary.KeyCollection<BitVector32Int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E3D50 Offset: 0x27E3E51 VA: 0x27E3D50
	|-Dictionary.KeyCollection<EventCheckId, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E4840 Offset: 0x27E4941 VA: 0x27E4840
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E52D0 Offset: 0x27E53D1 VA: 0x27E52D0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E5CD0 Offset: 0x27E5DD1 VA: 0x27E5CD0
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E66C0 Offset: 0x27E67C1 VA: 0x27E66C0
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E7160 Offset: 0x27E7261 VA: 0x27E7160
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E7B70 Offset: 0x27E7C71 VA: 0x27E7B70
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E8610 Offset: 0x27E8711 VA: 0x27E8610
	|-Dictionary.KeyCollection<OrderSaveData, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E90A0 Offset: 0x27E91A1 VA: 0x27E90A0
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27E9B80 Offset: 0x27E9C81 VA: 0x27E9B80
	|-Dictionary.KeyCollection<Parameter, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27EA5A0 Offset: 0x27EA6A1 VA: 0x27EA5A0
	|-Dictionary.KeyCollection<bool, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27EAF80 Offset: 0x27EB081 VA: 0x27EAF80
	|-Dictionary.KeyCollection<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27EB960 Offset: 0x27EBA61 VA: 0x27EB960
	|-Dictionary.KeyCollection<char, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27EC340 Offset: 0x27EC441 VA: 0x27EC340
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27ECD20 Offset: 0x27ECE21 VA: 0x27ECD20
	|-Dictionary.KeyCollection<double, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27ED710 Offset: 0x27ED811 VA: 0x27ED710
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27EE0F0 Offset: 0x27EE1F1 VA: 0x27EE0F0
	|-Dictionary.KeyCollection<short, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27EEAD0 Offset: 0x27EEBD1 VA: 0x27EEAD0
	|-Dictionary.KeyCollection<int, CropDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27EF4B0 Offset: 0x27EF5B1 VA: 0x27EF4B0
	|-Dictionary.KeyCollection<int, EffectDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27EFE90 Offset: 0x27EFF91 VA: 0x27EFE90
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F0870 Offset: 0x27F0971 VA: 0x27F0870
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F1250 Offset: 0x27F1351 VA: 0x27F1250
	|-Dictionary.KeyCollection<int, MiningDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F1C30 Offset: 0x27F1D31 VA: 0x27F1C30
	|-Dictionary.KeyCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F2610 Offset: 0x27F2711 VA: 0x27F2610
	|-Dictionary.KeyCollection<int, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F2FF0 Offset: 0x27F30F1 VA: 0x27F2FF0
	|-Dictionary.KeyCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F39D0 Offset: 0x27F3AD1 VA: 0x27F39D0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F43B0 Offset: 0x27F44B1 VA: 0x27F43B0
	|-Dictionary.KeyCollection<int, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F4D90 Offset: 0x27F4E91 VA: 0x27F4D90
	|-Dictionary.KeyCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F5770 Offset: 0x27F5871 VA: 0x27F5770
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F6150 Offset: 0x27F6251 VA: 0x27F6150
	|-Dictionary.KeyCollection<int, SceneInstance>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F6B30 Offset: 0x27F6C31 VA: 0x27F6B30
	|-Dictionary.KeyCollection<int, Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F7510 Offset: 0x27F7611 VA: 0x27F7510
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F7EF0 Offset: 0x27F7FF1 VA: 0x27F7EF0
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27F88D0 Offset: 0x27F89D1 VA: 0x27F88D0
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D75D0 Offset: 0x29D76D1 VA: 0x29D75D0
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D7FB0 Offset: 0x29D80B1 VA: 0x29D7FB0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D8990 Offset: 0x29D8A91 VA: 0x29D8990
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D9370 Offset: 0x29D9471 VA: 0x29D9370
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D9D50 Offset: 0x29D9E51 VA: 0x29D9D50
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29DA730 Offset: 0x29DA831 VA: 0x29DA730
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29DB110 Offset: 0x29DB211 VA: 0x29DB110
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29DBAF0 Offset: 0x29DBBF1 VA: 0x29DBAF0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29DC4D0 Offset: 0x29DC5D1 VA: 0x29DC4D0
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29DCEB0 Offset: 0x29DCFB1 VA: 0x29DCEB0
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29DD890 Offset: 0x29DD991 VA: 0x29DD890
	|-Dictionary.KeyCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29DE290 Offset: 0x29DE391 VA: 0x29DE290
	|-Dictionary.KeyCollection<Memory<object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29DEC70 Offset: 0x29DED71 VA: 0x29DEC70
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29DF700 Offset: 0x29DF801 VA: 0x29DF700
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E01B0 Offset: 0x29E02B1 VA: 0x29E01B0
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E0BB0 Offset: 0x29E0CB1 VA: 0x29E0BB0
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E1610 Offset: 0x29E1711 VA: 0x29E1610
	|-Dictionary.KeyCollection<Nullable<Color>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E2010 Offset: 0x29E2111 VA: 0x29E2010
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E2A70 Offset: 0x29E2B71 VA: 0x29E2A70
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E34F0 Offset: 0x29E35F1 VA: 0x29E34F0
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E3EE0 Offset: 0x29E3FE1 VA: 0x29E3EE0
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E4A00 Offset: 0x29E4B01 VA: 0x29E4A00
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E54A0 Offset: 0x29E55A1 VA: 0x29E54A0
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E5EA0 Offset: 0x29E5FA1 VA: 0x29E5EA0
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E6900 Offset: 0x29E6A01 VA: 0x29E6900
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E7370 Offset: 0x29E7471 VA: 0x29E7370
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E7D70 Offset: 0x29E7E71 VA: 0x29E7D70
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E8760 Offset: 0x29E8861 VA: 0x29E8760
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E9150 Offset: 0x29E9251 VA: 0x29E9150
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29E9B40 Offset: 0x29E9C41 VA: 0x29E9B40
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29EA5A0 Offset: 0x29EA6A1 VA: 0x29EA5A0
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29EAFA0 Offset: 0x29EB0A1 VA: 0x29EAFA0
	|-Dictionary.KeyCollection<object, BitVector32Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29EB950 Offset: 0x29EBA51 VA: 0x29EB950
	|-Dictionary.KeyCollection<object, EventCheckId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29EC300 Offset: 0x29EC401 VA: 0x29EC300
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29ECCB0 Offset: 0x29ECDB1 VA: 0x29ECCB0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29ED660 Offset: 0x29ED761 VA: 0x29ED660
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29AAC60 Offset: 0x29AAD61 VA: 0x29AAC60
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29AB610 Offset: 0x29AB711 VA: 0x29AB610
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29ABFC0 Offset: 0x29AC0C1 VA: 0x29ABFC0
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29AC970 Offset: 0x29ACA71 VA: 0x29AC970
	|-Dictionary.KeyCollection<object, OrderSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29AD320 Offset: 0x29AD421 VA: 0x29AD320
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29ADCD0 Offset: 0x29ADDD1 VA: 0x29ADCD0
	|-Dictionary.KeyCollection<object, Parameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29AE680 Offset: 0x29AE781 VA: 0x29AE680
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29AF030 Offset: 0x29AF131 VA: 0x29AF030
	|-Dictionary.KeyCollection<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29AF9E0 Offset: 0x29AFAE1 VA: 0x29AF9E0
	|-Dictionary.KeyCollection<object, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B0390 Offset: 0x29B0491 VA: 0x29B0390
	|-Dictionary.KeyCollection<object, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B0D40 Offset: 0x29B0E41 VA: 0x29B0D40
	|-Dictionary.KeyCollection<object, DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B16F0 Offset: 0x29B17F1 VA: 0x29B16F0
	|-Dictionary.KeyCollection<object, double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B20A0 Offset: 0x29B21A1 VA: 0x29B20A0
	|-Dictionary.KeyCollection<object, short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B2A50 Offset: 0x29B2B51 VA: 0x29B2A50
	|-Dictionary.KeyCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B3400 Offset: 0x29B3501 VA: 0x29B3400
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B3DB0 Offset: 0x29B3EB1 VA: 0x29B3DB0
	|-Dictionary.KeyCollection<object, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B4760 Offset: 0x29B4861 VA: 0x29B4760
	|-Dictionary.KeyCollection<object, Memory<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B5110 Offset: 0x29B5211 VA: 0x29B5110
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B5AC0 Offset: 0x29B5BC1 VA: 0x29B5AC0
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B6470 Offset: 0x29B6571 VA: 0x29B6470
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B6E20 Offset: 0x29B6F21 VA: 0x29B6E20
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B77D0 Offset: 0x29B78D1 VA: 0x29B77D0
	|-Dictionary.KeyCollection<object, Nullable<Color>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B8180 Offset: 0x29B8281 VA: 0x29B8180
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B8B30 Offset: 0x29B8C31 VA: 0x29B8B30
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B94E0 Offset: 0x29B95E1 VA: 0x29B94E0
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29B9E90 Offset: 0x29B9F91 VA: 0x29B9E90
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BA840 Offset: 0x29BA941 VA: 0x29BA840
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BB1F0 Offset: 0x29BB2F1 VA: 0x29BB1F0
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BBBA0 Offset: 0x29BBCA1 VA: 0x29BBBA0
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BC550 Offset: 0x29BC651 VA: 0x29BC550
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BCF00 Offset: 0x29BD001 VA: 0x29BCF00
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BD8B0 Offset: 0x29BD9B1 VA: 0x29BD8B0
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BE260 Offset: 0x29BE361 VA: 0x29BE260
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BEC10 Offset: 0x29BED11 VA: 0x29BEC10
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BF5C0 Offset: 0x29BF6C1 VA: 0x29BF5C0
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29BFF70 Offset: 0x29C0071 VA: 0x29BFF70
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C0920 Offset: 0x29C0A21 VA: 0x29C0920
	|-Dictionary.KeyCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A3C410 Offset: 0x2A3C511 VA: 0x2A3C410
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A3CDC0 Offset: 0x2A3CEC1 VA: 0x2A3CDC0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A3D770 Offset: 0x2A3D871 VA: 0x2A3D770
	|-Dictionary.KeyCollection<object, sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A3E120 Offset: 0x2A3E221 VA: 0x2A3E120
	|-Dictionary.KeyCollection<object, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A3EAD0 Offset: 0x2A3EBD1 VA: 0x2A3EAD0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A3F480 Offset: 0x2A3F581 VA: 0x2A3F480
	|-Dictionary.KeyCollection<object, uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A3FE30 Offset: 0x2A3FF31 VA: 0x2A3FE30
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A407E0 Offset: 0x2A408E1 VA: 0x2A407E0
	|-Dictionary.KeyCollection<object, TransitionTables>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A41190 Offset: 0x2A41291 VA: 0x2A41190
	|-Dictionary.KeyCollection<object, Bounds>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A41B40 Offset: 0x2A41C41 VA: 0x2A41B40
	|-Dictionary.KeyCollection<object, BoundsInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A424F0 Offset: 0x2A425F1 VA: 0x2A424F0
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A42EA0 Offset: 0x2A42FA1 VA: 0x2A42EA0
	|-Dictionary.KeyCollection<object, Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A43850 Offset: 0x2A43951 VA: 0x2A43850
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A44200 Offset: 0x2A44301 VA: 0x2A44200
	|-Dictionary.KeyCollection<object, GradientColorKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A44BB0 Offset: 0x2A44CB1 VA: 0x2A44BB0
	|-Dictionary.KeyCollection<object, Keyframe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A45560 Offset: 0x2A45661 VA: 0x2A45560
	|-Dictionary.KeyCollection<object, LayerMask>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A45F10 Offset: 0x2A46011 VA: 0x2A45F10
	|-Dictionary.KeyCollection<object, Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A468C0 Offset: 0x2A469C1 VA: 0x2A468C0
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A47270 Offset: 0x2A47371 VA: 0x2A47270
	|-Dictionary.KeyCollection<object, Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A47C20 Offset: 0x2A47D21 VA: 0x2A47C20
	|-Dictionary.KeyCollection<object, RangeInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A485D0 Offset: 0x2A486D1 VA: 0x2A485D0
	|-Dictionary.KeyCollection<object, Rect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A48F80 Offset: 0x2A49081 VA: 0x2A48F80
	|-Dictionary.KeyCollection<object, RectInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A49930 Offset: 0x2A49A31 VA: 0x2A49930
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4A2E0 Offset: 0x2A4A3E1 VA: 0x2A4A2E0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4AC90 Offset: 0x2A4AD91 VA: 0x2A4AC90
	|-Dictionary.KeyCollection<object, Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4B640 Offset: 0x2A4B741 VA: 0x2A4B640
	|-Dictionary.KeyCollection<object, Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4BFF0 Offset: 0x2A4C0F1 VA: 0x2A4BFF0
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4C9A0 Offset: 0x2A4CAA1 VA: 0x2A4C9A0
	|-Dictionary.KeyCollection<object, Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4D350 Offset: 0x2A4D451 VA: 0x2A4D350
	|-Dictionary.KeyCollection<object, Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4DD10 Offset: 0x2A4DE11 VA: 0x2A4DD10
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4E6F0 Offset: 0x2A4E7F1 VA: 0x2A4E6F0
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4F0D0 Offset: 0x2A4F1D1 VA: 0x2A4F0D0
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A4FAB0 Offset: 0x2A4FBB1 VA: 0x2A4FAB0
	|-Dictionary.KeyCollection<float, CurveSample>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A50490 Offset: 0x2A50591 VA: 0x2A50490
	|-Dictionary.KeyCollection<float, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A50E70 Offset: 0x2A50F71 VA: 0x2A50E70
	|-Dictionary.KeyCollection<ushort, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A51850 Offset: 0x2A51951 VA: 0x2A51850
	|-Dictionary.KeyCollection<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A52230 Offset: 0x2A52331 VA: 0x2A52230
	|-Dictionary.KeyCollection<uint, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2777390 Offset: 0x2777491 VA: 0x2777390
	|-Dictionary.KeyCollection<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2777D70 Offset: 0x2777E71 VA: 0x2777D70
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2778750 Offset: 0x2778851 VA: 0x2778750
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2779130 Offset: 0x2779231 VA: 0x2779130
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2779B10 Offset: 0x2779C11 VA: 0x2779B10
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277A4F0 Offset: 0x277A5F1 VA: 0x277A4F0
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277AED0 Offset: 0x277AFD1 VA: 0x277AED0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277B8B0 Offset: 0x277B9B1 VA: 0x277B8B0
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277C310 Offset: 0x277C411 VA: 0x277C310
	|-Dictionary.KeyCollection<Bounds, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277CD80 Offset: 0x277CE81 VA: 0x277CD80
	|-Dictionary.KeyCollection<BoundsInt, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277D780 Offset: 0x277D881 VA: 0x277D780
	|-Dictionary.KeyCollection<Color, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277E160 Offset: 0x277E261 VA: 0x277E160
	|-Dictionary.KeyCollection<Color32, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277EB40 Offset: 0x277EC41 VA: 0x277EB40
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277F530 Offset: 0x277F631 VA: 0x277F530
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x277FF90 Offset: 0x2780091 VA: 0x277FF90
	|-Dictionary.KeyCollection<GradientColorKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2780A30 Offset: 0x2780B31 VA: 0x2780A30
	|-Dictionary.KeyCollection<Keyframe, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2781430 Offset: 0x2781531 VA: 0x2781430
	|-Dictionary.KeyCollection<LayerMask, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2781F00 Offset: 0x2782001 VA: 0x2781F00
	|-Dictionary.KeyCollection<Matrix4x4, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2782910 Offset: 0x2782A11 VA: 0x2782910
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2783300 Offset: 0x2783401 VA: 0x2783300
	|-Dictionary.KeyCollection<Quaternion, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2783CE0 Offset: 0x2783DE1 VA: 0x2783CE0
	|-Dictionary.KeyCollection<RangeInt, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27846D0 Offset: 0x27847D1 VA: 0x27846D0
	|-Dictionary.KeyCollection<Rect, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x27850C0 Offset: 0x27851C1 VA: 0x27850C0
	|-Dictionary.KeyCollection<RectInt, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2785AA0 Offset: 0x2785BA1 VA: 0x2785AA0
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2786480 Offset: 0x2786581 VA: 0x2786480
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2786E70 Offset: 0x2786F71 VA: 0x2786E70
	|-Dictionary.KeyCollection<Vector2, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2787850 Offset: 0x2787951 VA: 0x2787850
	|-Dictionary.KeyCollection<Vector2Int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2788240 Offset: 0x2788341 VA: 0x2788240
	|-Dictionary.KeyCollection<Vector3, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2788C30 Offset: 0x2788D31 VA: 0x2788C30
	|-Dictionary.KeyCollection<Vector3Int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2789620 Offset: 0x2789721 VA: 0x2789620
	|-Dictionary.KeyCollection<Vector4, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E2980 Offset: 0x27E2A81 VA: 0x27E2980
	|-Dictionary.KeyCollection<JSONDeserialization.TaskField, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E3360 Offset: 0x27E3461 VA: 0x27E3360
	|-Dictionary.KeyCollection<BitVector32Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E3DE0 Offset: 0x27E3EE1 VA: 0x27E3DE0
	|-Dictionary.KeyCollection<EventCheckId, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E48E0 Offset: 0x27E49E1 VA: 0x27E48E0
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E5360 Offset: 0x27E5461 VA: 0x27E5360
	|-Dictionary.KeyCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E5D50 Offset: 0x27E5E51 VA: 0x27E5D50
	|-Dictionary.KeyCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E6740 Offset: 0x27E6841 VA: 0x27E6740
	|-Dictionary.KeyCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E71F0 Offset: 0x27E72F1 VA: 0x27E71F0
	|-Dictionary.KeyCollection<MonsterHutSaveData, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E7BF0 Offset: 0x27E7CF1 VA: 0x27E7BF0
	|-Dictionary.KeyCollection<OrderLotterySaveParameter, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E86A0 Offset: 0x27E87A1 VA: 0x27E86A0
	|-Dictionary.KeyCollection<OrderSaveData, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E9130 Offset: 0x27E9231 VA: 0x27E9130
	|-Dictionary.KeyCollection<OrderSaveParameter, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27E9C30 Offset: 0x27E9D31 VA: 0x27E9C30
	|-Dictionary.KeyCollection<Parameter, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27EA620 Offset: 0x27EA721 VA: 0x27EA620
	|-Dictionary.KeyCollection<bool, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27EB000 Offset: 0x27EB101 VA: 0x27EB000
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27EB9E0 Offset: 0x27EBAE1 VA: 0x27EB9E0
	|-Dictionary.KeyCollection<char, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27EC3C0 Offset: 0x27EC4C1 VA: 0x27EC3C0
	|-Dictionary.KeyCollection<DateTime, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27ECDA0 Offset: 0x27ECEA1 VA: 0x27ECDA0
	|-Dictionary.KeyCollection<double, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27ED790 Offset: 0x27ED891 VA: 0x27ED790
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27EE170 Offset: 0x27EE271 VA: 0x27EE170
	|-Dictionary.KeyCollection<short, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27EEB50 Offset: 0x27EEC51 VA: 0x27EEB50
	|-Dictionary.KeyCollection<int, CropDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27EF530 Offset: 0x27EF631 VA: 0x27EF530
	|-Dictionary.KeyCollection<int, EffectDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27EFF10 Offset: 0x27F0011 VA: 0x27EFF10
	|-Dictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F08F0 Offset: 0x27F09F1 VA: 0x27F08F0
	|-Dictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F12D0 Offset: 0x27F13D1 VA: 0x27F12D0
	|-Dictionary.KeyCollection<int, MiningDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F1CB0 Offset: 0x27F1DB1 VA: 0x27F1CB0
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F2690 Offset: 0x27F2791 VA: 0x27F2690
	|-Dictionary.KeyCollection<int, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F3070 Offset: 0x27F3171 VA: 0x27F3070
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F3A50 Offset: 0x27F3B51 VA: 0x27F3A50
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F4430 Offset: 0x27F4531 VA: 0x27F4430
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F4E10 Offset: 0x27F4F11 VA: 0x27F4E10
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F57F0 Offset: 0x27F58F1 VA: 0x27F57F0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F61D0 Offset: 0x27F62D1 VA: 0x27F61D0
	|-Dictionary.KeyCollection<int, SceneInstance>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F6BB0 Offset: 0x27F6CB1 VA: 0x27F6BB0
	|-Dictionary.KeyCollection<int, Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F7590 Offset: 0x27F7691 VA: 0x27F7590
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F7F70 Offset: 0x27F8071 VA: 0x27F7F70
	|-Dictionary.KeyCollection<Int32Enum, MonsterDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27F8950 Offset: 0x27F8A51 VA: 0x27F8950
	|-Dictionary.KeyCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D7650 Offset: 0x29D7751 VA: 0x29D7650
	|-Dictionary.KeyCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D8030 Offset: 0x29D8131 VA: 0x29D8030
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D8A10 Offset: 0x29D8B11 VA: 0x29D8A10
	|-Dictionary.KeyCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D93F0 Offset: 0x29D94F1 VA: 0x29D93F0
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D9DD0 Offset: 0x29D9ED1 VA: 0x29D9DD0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29DA7B0 Offset: 0x29DA8B1 VA: 0x29DA7B0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29DB190 Offset: 0x29DB291 VA: 0x29DB190
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29DBB70 Offset: 0x29DBC71 VA: 0x29DBB70
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29DC550 Offset: 0x29DC651 VA: 0x29DC550
	|-Dictionary.KeyCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29DCF30 Offset: 0x29DD031 VA: 0x29DCF30
	|-Dictionary.KeyCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29DD910 Offset: 0x29DDA11 VA: 0x29DD910
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29DE310 Offset: 0x29DE411 VA: 0x29DE310
	|-Dictionary.KeyCollection<Memory<object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29DECF0 Offset: 0x29DEDF1 VA: 0x29DECF0
	|-Dictionary.KeyCollection<Nullable<Int32Enum>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29DF790 Offset: 0x29DF891 VA: 0x29DF790
	|-Dictionary.KeyCollection<Nullable<Bounds>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E0240 Offset: 0x29E0341 VA: 0x29E0240
	|-Dictionary.KeyCollection<Nullable<BoundsInt>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E0C30 Offset: 0x29E0D31 VA: 0x29E0C30
	|-Dictionary.KeyCollection<Nullable<Color32>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E16A0 Offset: 0x29E17A1 VA: 0x29E16A0
	|-Dictionary.KeyCollection<Nullable<Color>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E2090 Offset: 0x29E2191 VA: 0x29E2090
	|-Dictionary.KeyCollection<Nullable<GradientAlphaKey>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E2B00 Offset: 0x29E2C01 VA: 0x29E2B00
	|-Dictionary.KeyCollection<Nullable<GradientColorKey>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E3580 Offset: 0x29E3681 VA: 0x29E3580
	|-Dictionary.KeyCollection<Nullable<Keyframe>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E3F60 Offset: 0x29E4061 VA: 0x29E3F60
	|-Dictionary.KeyCollection<Nullable<LayerMask>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E4AB0 Offset: 0x29E4BB1 VA: 0x29E4AB0
	|-Dictionary.KeyCollection<Nullable<Matrix4x4>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E5530 Offset: 0x29E5631 VA: 0x29E5530
	|-Dictionary.KeyCollection<Nullable<Quaternion>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E5F20 Offset: 0x29E6021 VA: 0x29E5F20
	|-Dictionary.KeyCollection<Nullable<RangeInt>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E6990 Offset: 0x29E6A91 VA: 0x29E6990
	|-Dictionary.KeyCollection<Nullable<Rect>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E7400 Offset: 0x29E7501 VA: 0x29E7400
	|-Dictionary.KeyCollection<Nullable<RectInt>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E7DF0 Offset: 0x29E7EF1 VA: 0x29E7DF0
	|-Dictionary.KeyCollection<Nullable<Vector2>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E87E0 Offset: 0x29E88E1 VA: 0x29E87E0
	|-Dictionary.KeyCollection<Nullable<Vector2Int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E91D0 Offset: 0x29E92D1 VA: 0x29E91D0
	|-Dictionary.KeyCollection<Nullable<Vector3>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29E9BC0 Offset: 0x29E9CC1 VA: 0x29E9BC0
	|-Dictionary.KeyCollection<Nullable<Vector3Int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29EA630 Offset: 0x29EA731 VA: 0x29EA630
	|-Dictionary.KeyCollection<Nullable<Vector4>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29EB020 Offset: 0x29EB121 VA: 0x29EB020
	|-Dictionary.KeyCollection<object, BitVector32Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29EB9D0 Offset: 0x29EBAD1 VA: 0x29EB9D0
	|-Dictionary.KeyCollection<object, EventCheckId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29EC380 Offset: 0x29EC481 VA: 0x29EC380
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29ECD30 Offset: 0x29ECE31 VA: 0x29ECD30
	|-Dictionary.KeyCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29ED6E0 Offset: 0x29ED7E1 VA: 0x29ED6E0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29AACE0 Offset: 0x29AADE1 VA: 0x29AACE0
	|-Dictionary.KeyCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29AB690 Offset: 0x29AB791 VA: 0x29AB690
	|-Dictionary.KeyCollection<object, MonsterHutSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29AC040 Offset: 0x29AC141 VA: 0x29AC040
	|-Dictionary.KeyCollection<object, OrderLotterySaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29AC9F0 Offset: 0x29ACAF1 VA: 0x29AC9F0
	|-Dictionary.KeyCollection<object, OrderSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29AD3A0 Offset: 0x29AD4A1 VA: 0x29AD3A0
	|-Dictionary.KeyCollection<object, OrderSaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29ADD50 Offset: 0x29ADE51 VA: 0x29ADD50
	|-Dictionary.KeyCollection<object, Parameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29AE700 Offset: 0x29AE801 VA: 0x29AE700
	|-Dictionary.KeyCollection<object, NumberControl.ValueRange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29AF0B0 Offset: 0x29AF1B1 VA: 0x29AF0B0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29AFA60 Offset: 0x29AFB61 VA: 0x29AFA60
	|-Dictionary.KeyCollection<object, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B0410 Offset: 0x29B0511 VA: 0x29B0410
	|-Dictionary.KeyCollection<object, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B0DC0 Offset: 0x29B0EC1 VA: 0x29B0DC0
	|-Dictionary.KeyCollection<object, DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B1770 Offset: 0x29B1871 VA: 0x29B1770
	|-Dictionary.KeyCollection<object, double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B2120 Offset: 0x29B2221 VA: 0x29B2120
	|-Dictionary.KeyCollection<object, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B2AD0 Offset: 0x29B2BD1 VA: 0x29B2AD0
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B3480 Offset: 0x29B3581 VA: 0x29B3480
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B3E30 Offset: 0x29B3F31 VA: 0x29B3E30
	|-Dictionary.KeyCollection<object, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B47E0 Offset: 0x29B48E1 VA: 0x29B47E0
	|-Dictionary.KeyCollection<object, Memory<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B5190 Offset: 0x29B5291 VA: 0x29B5190
	|-Dictionary.KeyCollection<object, Nullable<Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B5B40 Offset: 0x29B5C41 VA: 0x29B5B40
	|-Dictionary.KeyCollection<object, Nullable<Bounds>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B64F0 Offset: 0x29B65F1 VA: 0x29B64F0
	|-Dictionary.KeyCollection<object, Nullable<BoundsInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B6EA0 Offset: 0x29B6FA1 VA: 0x29B6EA0
	|-Dictionary.KeyCollection<object, Nullable<Color32>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B7850 Offset: 0x29B7951 VA: 0x29B7850
	|-Dictionary.KeyCollection<object, Nullable<Color>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B8200 Offset: 0x29B8301 VA: 0x29B8200
	|-Dictionary.KeyCollection<object, Nullable<GradientAlphaKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B8BB0 Offset: 0x29B8CB1 VA: 0x29B8BB0
	|-Dictionary.KeyCollection<object, Nullable<GradientColorKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B9560 Offset: 0x29B9661 VA: 0x29B9560
	|-Dictionary.KeyCollection<object, Nullable<Keyframe>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29B9F10 Offset: 0x29BA011 VA: 0x29B9F10
	|-Dictionary.KeyCollection<object, Nullable<LayerMask>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BA8C0 Offset: 0x29BA9C1 VA: 0x29BA8C0
	|-Dictionary.KeyCollection<object, Nullable<Matrix4x4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BB270 Offset: 0x29BB371 VA: 0x29BB270
	|-Dictionary.KeyCollection<object, Nullable<Quaternion>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BBC20 Offset: 0x29BBD21 VA: 0x29BBC20
	|-Dictionary.KeyCollection<object, Nullable<RangeInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BC5D0 Offset: 0x29BC6D1 VA: 0x29BC5D0
	|-Dictionary.KeyCollection<object, Nullable<Rect>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BCF80 Offset: 0x29BD081 VA: 0x29BCF80
	|-Dictionary.KeyCollection<object, Nullable<RectInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BD930 Offset: 0x29BDA31 VA: 0x29BD930
	|-Dictionary.KeyCollection<object, Nullable<Vector2>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BE2E0 Offset: 0x29BE3E1 VA: 0x29BE2E0
	|-Dictionary.KeyCollection<object, Nullable<Vector2Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BEC90 Offset: 0x29BED91 VA: 0x29BEC90
	|-Dictionary.KeyCollection<object, Nullable<Vector3>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BF640 Offset: 0x29BF741 VA: 0x29BF640
	|-Dictionary.KeyCollection<object, Nullable<Vector3Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29BFFF0 Offset: 0x29C00F1 VA: 0x29BFFF0
	|-Dictionary.KeyCollection<object, Nullable<Vector4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C09A0 Offset: 0x29C0AA1 VA: 0x29C09A0
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A3C490 Offset: 0x2A3C591 VA: 0x2A3C490
	|-Dictionary.KeyCollection<object, ReadOnlyMemory<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A3CE40 Offset: 0x2A3CF41 VA: 0x2A3CE40
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A3D7F0 Offset: 0x2A3D8F1 VA: 0x2A3D7F0
	|-Dictionary.KeyCollection<object, sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A3E1A0 Offset: 0x2A3E2A1 VA: 0x2A3E1A0
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A3EB50 Offset: 0x2A3EC51 VA: 0x2A3EB50
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A3F500 Offset: 0x2A3F601 VA: 0x2A3F500
	|-Dictionary.KeyCollection<object, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A3FEB0 Offset: 0x2A3FFB1 VA: 0x2A3FEB0
	|-Dictionary.KeyCollection<object, ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A40860 Offset: 0x2A40961 VA: 0x2A40860
	|-Dictionary.KeyCollection<object, TransitionTables>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A41210 Offset: 0x2A41311 VA: 0x2A41210
	|-Dictionary.KeyCollection<object, Bounds>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A41BC0 Offset: 0x2A41CC1 VA: 0x2A41BC0
	|-Dictionary.KeyCollection<object, BoundsInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A42570 Offset: 0x2A42671 VA: 0x2A42570
	|-Dictionary.KeyCollection<object, Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A42F20 Offset: 0x2A43021 VA: 0x2A42F20
	|-Dictionary.KeyCollection<object, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A438D0 Offset: 0x2A439D1 VA: 0x2A438D0
	|-Dictionary.KeyCollection<object, GradientAlphaKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A44280 Offset: 0x2A44381 VA: 0x2A44280
	|-Dictionary.KeyCollection<object, GradientColorKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A44C30 Offset: 0x2A44D31 VA: 0x2A44C30
	|-Dictionary.KeyCollection<object, Keyframe>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A455E0 Offset: 0x2A456E1 VA: 0x2A455E0
	|-Dictionary.KeyCollection<object, LayerMask>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A45F90 Offset: 0x2A46091 VA: 0x2A45F90
	|-Dictionary.KeyCollection<object, Matrix4x4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A46940 Offset: 0x2A46A41 VA: 0x2A46940
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A472F0 Offset: 0x2A473F1 VA: 0x2A472F0
	|-Dictionary.KeyCollection<object, Quaternion>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A47CA0 Offset: 0x2A47DA1 VA: 0x2A47CA0
	|-Dictionary.KeyCollection<object, RangeInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A48650 Offset: 0x2A48751 VA: 0x2A48650
	|-Dictionary.KeyCollection<object, Rect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A49000 Offset: 0x2A49101 VA: 0x2A49000
	|-Dictionary.KeyCollection<object, RectInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A499B0 Offset: 0x2A49AB1 VA: 0x2A499B0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4A360 Offset: 0x2A4A461 VA: 0x2A4A360
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4AD10 Offset: 0x2A4AE11 VA: 0x2A4AD10
	|-Dictionary.KeyCollection<object, Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4B6C0 Offset: 0x2A4B7C1 VA: 0x2A4B6C0
	|-Dictionary.KeyCollection<object, Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4C070 Offset: 0x2A4C171 VA: 0x2A4C070
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4CA20 Offset: 0x2A4CB21 VA: 0x2A4CA20
	|-Dictionary.KeyCollection<object, Vector3Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4D3D0 Offset: 0x2A4D4D1 VA: 0x2A4D3D0
	|-Dictionary.KeyCollection<object, Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4DD90 Offset: 0x2A4DE91 VA: 0x2A4DD90
	|-Dictionary.KeyCollection<ReadOnlyMemory<object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4E770 Offset: 0x2A4E871 VA: 0x2A4E770
	|-Dictionary.KeyCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4F150 Offset: 0x2A4F251 VA: 0x2A4F150
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A4FB30 Offset: 0x2A4FC31 VA: 0x2A4FB30
	|-Dictionary.KeyCollection<float, CurveSample>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A50510 Offset: 0x2A50611 VA: 0x2A50510
	|-Dictionary.KeyCollection<float, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A50EF0 Offset: 0x2A50FF1 VA: 0x2A50EF0
	|-Dictionary.KeyCollection<ushort, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A518D0 Offset: 0x2A519D1 VA: 0x2A518D0
	|-Dictionary.KeyCollection<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A522B0 Offset: 0x2A523B1 VA: 0x2A522B0
	|-Dictionary.KeyCollection<uint, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2777410 Offset: 0x2777511 VA: 0x2777410
	|-Dictionary.KeyCollection<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2777DF0 Offset: 0x2777EF1 VA: 0x2777DF0
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27787D0 Offset: 0x27788D1 VA: 0x27787D0
	|-Dictionary.KeyCollection<EdgeKeyByHash, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27791B0 Offset: 0x27792B1 VA: 0x27791B0
	|-Dictionary.KeyCollection<EdgeKeyByHash, CapEdge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2779B90 Offset: 0x2779C91 VA: 0x2779B90
	|-Dictionary.KeyCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x277A570 Offset: 0x277A671 VA: 0x277A570
	|-Dictionary.KeyCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x277AF50 Offset: 0x277B051 VA: 0x277AF50
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x277B930 Offset: 0x277BA31 VA: 0x277B930
	|-Dictionary.KeyCollection<MeshDataConnectivity.Face, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x277C3A0 Offset: 0x277C4A1 VA: 0x277C3A0
	|-Dictionary.KeyCollection<Bounds, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x277CE10 Offset: 0x277CF11 VA: 0x277CE10
	|-Dictionary.KeyCollection<BoundsInt, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x277D800 Offset: 0x277D901 VA: 0x277D800
	|-Dictionary.KeyCollection<Color, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x277E1E0 Offset: 0x277E2E1 VA: 0x277E1E0
	|-Dictionary.KeyCollection<Color32, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x277EBC0 Offset: 0x277ECC1 VA: 0x277EBC0
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x277F5B0 Offset: 0x277F6B1 VA: 0x277F5B0
	|-Dictionary.KeyCollection<GradientAlphaKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2780020 Offset: 0x2780121 VA: 0x2780020
	|-Dictionary.KeyCollection<GradientColorKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2780AC0 Offset: 0x2780BC1 VA: 0x2780AC0
	|-Dictionary.KeyCollection<Keyframe, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27814B0 Offset: 0x27815B1 VA: 0x27814B0
	|-Dictionary.KeyCollection<LayerMask, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2781FA0 Offset: 0x27820A1 VA: 0x2781FA0
	|-Dictionary.KeyCollection<Matrix4x4, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2782990 Offset: 0x2782A91 VA: 0x2782990
	|-Dictionary.KeyCollection<IntVec3, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2783380 Offset: 0x2783481 VA: 0x2783380
	|-Dictionary.KeyCollection<Quaternion, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2783D60 Offset: 0x2783E61 VA: 0x2783D60
	|-Dictionary.KeyCollection<RangeInt, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2784750 Offset: 0x2784851 VA: 0x2784750
	|-Dictionary.KeyCollection<Rect, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2785140 Offset: 0x2785241 VA: 0x2785140
	|-Dictionary.KeyCollection<RectInt, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2785B20 Offset: 0x2785C21 VA: 0x2785B20
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2786500 Offset: 0x2786601 VA: 0x2786500
	|-Dictionary.KeyCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2786EF0 Offset: 0x2786FF1 VA: 0x2786EF0
	|-Dictionary.KeyCollection<Vector2, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27878D0 Offset: 0x27879D1 VA: 0x27878D0
	|-Dictionary.KeyCollection<Vector2Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27882C0 Offset: 0x27883C1 VA: 0x27882C0
	|-Dictionary.KeyCollection<Vector3, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2788CB0 Offset: 0x2788DB1 VA: 0x2788CB0
	|-Dictionary.KeyCollection<Vector3Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x27896A0 Offset: 0x27897A1 VA: 0x27896A0
	|-Dictionary.KeyCollection<Vector4, object>.System.Collections.ICollection.CopyTo
	*/
}

