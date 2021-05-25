[DebuggerTypeProxyAttribute] // RVA: 0xB3950 Offset: 0xB3A51 VA: 0xB3950
[DebuggerDisplayAttribute] // RVA: 0xB3950 Offset: 0xB3A51 VA: 0xB3950
[Serializable]
public sealed class Dictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 1427
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2340F50 Offset: 0x2341051 VA: 0x2340F50
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x2341900 Offset: 0x2341A01 VA: 0x2341900
	|-Dictionary.ValueCollection<BitVector32Int, object>..ctor
	|
	|-RVA: 0x23422B0 Offset: 0x23423B1 VA: 0x23422B0
	|-Dictionary.ValueCollection<EventCheckId, object>..ctor
	|
	|-RVA: 0x28FD2A0 Offset: 0x28FD3A1 VA: 0x28FD2A0
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x28FDC50 Offset: 0x28FDD51 VA: 0x28FDC50
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x28FE600 Offset: 0x28FE701 VA: 0x28FE600
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x28FEFB0 Offset: 0x28FF0B1 VA: 0x28FEFB0
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x28FF960 Offset: 0x28FFA61 VA: 0x28FF960
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x2900310 Offset: 0x2900411 VA: 0x2900310
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x2900CC0 Offset: 0x2900DC1 VA: 0x2900CC0
	|-Dictionary.ValueCollection<OrderSaveData, object>..ctor
	|
	|-RVA: 0x2901670 Offset: 0x2901771 VA: 0x2901670
	|-Dictionary.ValueCollection<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x2902020 Offset: 0x2902121 VA: 0x2902020
	|-Dictionary.ValueCollection<Parameter, object>..ctor
	|
	|-RVA: 0x29029D0 Offset: 0x2902AD1 VA: 0x29029D0
	|-Dictionary.ValueCollection<bool, object>..ctor
	|
	|-RVA: 0x2903380 Offset: 0x2903481 VA: 0x2903380
	|-Dictionary.ValueCollection<byte, object>..ctor
	|
	|-RVA: 0x2903D30 Offset: 0x2903E31 VA: 0x2903D30
	|-Dictionary.ValueCollection<char, object>..ctor
	|
	|-RVA: 0x29046E0 Offset: 0x29047E1 VA: 0x29046E0
	|-Dictionary.ValueCollection<DateTime, object>..ctor
	|
	|-RVA: 0x2905090 Offset: 0x2905191 VA: 0x2905090
	|-Dictionary.ValueCollection<double, object>..ctor
	|
	|-RVA: 0x2905A40 Offset: 0x2905B41 VA: 0x2905A40
	|-Dictionary.ValueCollection<Guid, object>..ctor
	|
	|-RVA: 0x29063F0 Offset: 0x29064F1 VA: 0x29063F0
	|-Dictionary.ValueCollection<short, object>..ctor
	|
	|-RVA: 0x2906DA0 Offset: 0x2906EA1 VA: 0x2906DA0
	|-Dictionary.ValueCollection<int, CropDataTable>..ctor
	|
	|-RVA: 0x29078E0 Offset: 0x29079E1 VA: 0x29078E0
	|-Dictionary.ValueCollection<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2908350 Offset: 0x2908451 VA: 0x2908350
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2908D30 Offset: 0x2908E31 VA: 0x2908D30
	|-Dictionary.ValueCollection<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2909820 Offset: 0x2909921 VA: 0x2909820
	|-Dictionary.ValueCollection<int, MiningDataTable>..ctor
	|
	|-RVA: 0x290A220 Offset: 0x290A321 VA: 0x290A220
	|-Dictionary.ValueCollection<int, bool>..ctor
	|
	|-RVA: 0x290AC00 Offset: 0x290AD01 VA: 0x290AC00
	|-Dictionary.ValueCollection<int, char>..ctor
	|
	|-RVA: 0x290B5E0 Offset: 0x290B6E1 VA: 0x290B5E0
	|-Dictionary.ValueCollection<int, int>..ctor
	|
	|-RVA: 0x290BFC0 Offset: 0x290C0C1 VA: 0x290BFC0
	|-Dictionary.ValueCollection<int, Int32Enum>..ctor
	|
	|-RVA: 0x290C9A0 Offset: 0x290CAA1 VA: 0x290C9A0
	|-Dictionary.ValueCollection<int, long>..ctor
	|
	|-RVA: 0x290D380 Offset: 0x290D481 VA: 0x290D380
	|-Dictionary.ValueCollection<int, object>..ctor
	|
	|-RVA: 0x290DD30 Offset: 0x290DE31 VA: 0x290DD30
	|-Dictionary.ValueCollection<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x290E800 Offset: 0x290E901 VA: 0x290E800
	|-Dictionary.ValueCollection<int, SceneInstance>..ctor
	|
	|-RVA: 0x290F200 Offset: 0x290F301 VA: 0x290F200
	|-Dictionary.ValueCollection<int, Vector2Int>..ctor
	|
	|-RVA: 0x290FBE0 Offset: 0x290FCE1 VA: 0x290FBE0
	|-Dictionary.ValueCollection<int, Vector3>..ctor
	|
	|-RVA: 0x29105D0 Offset: 0x29106D1 VA: 0x29105D0
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x29110F0 Offset: 0x29111F1 VA: 0x29110F0
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2911BC0 Offset: 0x2911CC1 VA: 0x2911BC0
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x29125B0 Offset: 0x29126B1 VA: 0x29125B0
	|-Dictionary.ValueCollection<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2912F90 Offset: 0x2913091 VA: 0x2912F90
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x29C0D90 Offset: 0x29C0E91 VA: 0x29C0D90
	|-Dictionary.ValueCollection<Int32Enum, int>..ctor
	|
	|-RVA: 0x29C1770 Offset: 0x29C1871 VA: 0x29C1770
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x29C2150 Offset: 0x29C2251 VA: 0x29C2150
	|-Dictionary.ValueCollection<Int32Enum, object>..ctor
	|
	|-RVA: 0x29C2B00 Offset: 0x29C2C01 VA: 0x29C2B00
	|-Dictionary.ValueCollection<Int32Enum, float>..ctor
	|
	|-RVA: 0x29C34E0 Offset: 0x29C35E1 VA: 0x29C34E0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x29C3EE0 Offset: 0x29C3FE1 VA: 0x29C3EE0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x29C48D0 Offset: 0x29C49D1 VA: 0x29C48D0
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x29C52C0 Offset: 0x29C53C1 VA: 0x29C52C0
	|-Dictionary.ValueCollection<long, object>..ctor
	|
	|-RVA: 0x29C5C70 Offset: 0x29C5D71 VA: 0x29C5C70
	|-Dictionary.ValueCollection<Memory<object>, object>..ctor
	|
	|-RVA: 0x29C6620 Offset: 0x29C6721 VA: 0x29C6620
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x29C6FD0 Offset: 0x29C70D1 VA: 0x29C6FD0
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x29C7980 Offset: 0x29C7A81 VA: 0x29C7980
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x29C8330 Offset: 0x29C8431 VA: 0x29C8330
	|-Dictionary.ValueCollection<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x29C8CE0 Offset: 0x29C8DE1 VA: 0x29C8CE0
	|-Dictionary.ValueCollection<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x29C9690 Offset: 0x29C9791 VA: 0x29C9690
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x29CA040 Offset: 0x29CA141 VA: 0x29CA040
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x29CA9F0 Offset: 0x29CAAF1 VA: 0x29CA9F0
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x29CB3A0 Offset: 0x29CB4A1 VA: 0x29CB3A0
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x29CBD50 Offset: 0x29CBE51 VA: 0x29CBD50
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x29CC700 Offset: 0x29CC801 VA: 0x29CC700
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x29CD0B0 Offset: 0x29CD1B1 VA: 0x29CD0B0
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x29CDA60 Offset: 0x29CDB61 VA: 0x29CDA60
	|-Dictionary.ValueCollection<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x29CE410 Offset: 0x29CE511 VA: 0x29CE410
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x29CEDC0 Offset: 0x29CEEC1 VA: 0x29CEDC0
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x29CF770 Offset: 0x29CF871 VA: 0x29CF770
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x29D0120 Offset: 0x29D0221 VA: 0x29D0120
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x29D0AD0 Offset: 0x29D0BD1 VA: 0x29D0AD0
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x29D1480 Offset: 0x29D1581 VA: 0x29D1480
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x29D1E30 Offset: 0x29D1F31 VA: 0x29D1E30
	|-Dictionary.ValueCollection<object, BitVector32Int>..ctor
	|
	|-RVA: 0x29D2810 Offset: 0x29D2911 VA: 0x29D2810
	|-Dictionary.ValueCollection<object, EventCheckId>..ctor
	|
	|-RVA: 0x29D3290 Offset: 0x29D3391 VA: 0x29D3290
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x29D3DA0 Offset: 0x29D3EA1 VA: 0x29D3DA0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x29D4810 Offset: 0x29D4911 VA: 0x29D4810
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x29D5200 Offset: 0x29D5301 VA: 0x29D5200
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x29D5BF0 Offset: 0x29D5CF1 VA: 0x29D5BF0
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x29D66B0 Offset: 0x29D67B1 VA: 0x29D66B0
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2958220 Offset: 0x2958321 VA: 0x2958220
	|-Dictionary.ValueCollection<object, OrderSaveData>..ctor
	|
	|-RVA: 0x2958CE0 Offset: 0x2958DE1 VA: 0x2958CE0
	|-Dictionary.ValueCollection<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x2959760 Offset: 0x2959861 VA: 0x2959760
	|-Dictionary.ValueCollection<object, Parameter>..ctor
	|
	|-RVA: 0x295A270 Offset: 0x295A371 VA: 0x295A270
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x295AC60 Offset: 0x295AD61 VA: 0x295AC60
	|-Dictionary.ValueCollection<object, bool>..ctor
	|
	|-RVA: 0x295B640 Offset: 0x295B741 VA: 0x295B640
	|-Dictionary.ValueCollection<object, byte>..ctor
	|
	|-RVA: 0x295C020 Offset: 0x295C121 VA: 0x295C020
	|-Dictionary.ValueCollection<object, char>..ctor
	|
	|-RVA: 0x295CA00 Offset: 0x295CB01 VA: 0x295CA00
	|-Dictionary.ValueCollection<object, DateTime>..ctor
	|
	|-RVA: 0x295D3E0 Offset: 0x295D4E1 VA: 0x295D3E0
	|-Dictionary.ValueCollection<object, double>..ctor
	|
	|-RVA: 0x295DDC0 Offset: 0x295DEC1 VA: 0x295DDC0
	|-Dictionary.ValueCollection<object, short>..ctor
	|
	|-RVA: 0x295E7A0 Offset: 0x295E8A1 VA: 0x295E7A0
	|-Dictionary.ValueCollection<object, int>..ctor
	|
	|-RVA: 0x295F180 Offset: 0x295F281 VA: 0x295F180
	|-Dictionary.ValueCollection<object, Int32Enum>..ctor
	|
	|-RVA: 0x295FB60 Offset: 0x295FC61 VA: 0x295FB60
	|-Dictionary.ValueCollection<object, long>..ctor
	|
	|-RVA: 0x2960540 Offset: 0x2960641 VA: 0x2960540
	|-Dictionary.ValueCollection<object, Memory<object>>..ctor
	|
	|-RVA: 0x2960F40 Offset: 0x2961041 VA: 0x2960F40
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x2961920 Offset: 0x2961A21 VA: 0x2961920
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x29623D0 Offset: 0x29624D1 VA: 0x29623D0
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x2962E80 Offset: 0x2962F81 VA: 0x2962E80
	|-Dictionary.ValueCollection<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x2963860 Offset: 0x2963961 VA: 0x2963860
	|-Dictionary.ValueCollection<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x29642D0 Offset: 0x29643D1 VA: 0x29642D0
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2964CC0 Offset: 0x2964DC1 VA: 0x2964CC0
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2965730 Offset: 0x2965831 VA: 0x2965730
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x29661B0 Offset: 0x29662B1 VA: 0x29661B0
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x2966B90 Offset: 0x2966C91 VA: 0x2966B90
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x29676F0 Offset: 0x29677F1 VA: 0x29676F0
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2968160 Offset: 0x2968261 VA: 0x2968160
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2968B50 Offset: 0x2968C51 VA: 0x2968B50
	|-Dictionary.ValueCollection<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x29695C0 Offset: 0x29696C1 VA: 0x29695C0
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x296A030 Offset: 0x296A131 VA: 0x296A030
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x296AA20 Offset: 0x296AB21 VA: 0x296AA20
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x296B410 Offset: 0x296B511 VA: 0x296B410
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x296BE00 Offset: 0x296BF01 VA: 0x296BE00
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x296C7F0 Offset: 0x296C8F1 VA: 0x296C7F0
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x296D260 Offset: 0x296D361 VA: 0x296D260
	|-Dictionary.ValueCollection<object, object>..ctor
	|
	|-RVA: 0x296DC10 Offset: 0x296DD11 VA: 0x296DC10
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x296E610 Offset: 0x296E711 VA: 0x296E610
	|-Dictionary.ValueCollection<object, ResourceLocator>..ctor
	|
	|-RVA: 0x29EDAD0 Offset: 0x29EDBD1 VA: 0x29EDAD0
	|-Dictionary.ValueCollection<object, sbyte>..ctor
	|
	|-RVA: 0x29EE4B0 Offset: 0x29EE5B1 VA: 0x29EE4B0
	|-Dictionary.ValueCollection<object, float>..ctor
	|
	|-RVA: 0x29EEE90 Offset: 0x29EEF91 VA: 0x29EEE90
	|-Dictionary.ValueCollection<object, ushort>..ctor
	|
	|-RVA: 0x29EF870 Offset: 0x29EF971 VA: 0x29EF870
	|-Dictionary.ValueCollection<object, uint>..ctor
	|
	|-RVA: 0x29F0250 Offset: 0x29F0351 VA: 0x29F0250
	|-Dictionary.ValueCollection<object, ulong>..ctor
	|
	|-RVA: 0x29F0C30 Offset: 0x29F0D31 VA: 0x29F0C30
	|-Dictionary.ValueCollection<object, TransitionTables>..ctor
	|
	|-RVA: 0x29F16B0 Offset: 0x29F17B1 VA: 0x29F16B0
	|-Dictionary.ValueCollection<object, Bounds>..ctor
	|
	|-RVA: 0x29F2120 Offset: 0x29F2221 VA: 0x29F2120
	|-Dictionary.ValueCollection<object, BoundsInt>..ctor
	|
	|-RVA: 0x29F2B90 Offset: 0x29F2C91 VA: 0x29F2B90
	|-Dictionary.ValueCollection<object, Color32>..ctor
	|
	|-RVA: 0x29F3570 Offset: 0x29F3671 VA: 0x29F3570
	|-Dictionary.ValueCollection<object, Color>..ctor
	|
	|-RVA: 0x29F3F60 Offset: 0x29F4061 VA: 0x29F3F60
	|-Dictionary.ValueCollection<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x29F4950 Offset: 0x29F4A51 VA: 0x29F4950
	|-Dictionary.ValueCollection<object, GradientColorKey>..ctor
	|
	|-RVA: 0x29F53C0 Offset: 0x29F54C1 VA: 0x29F53C0
	|-Dictionary.ValueCollection<object, Keyframe>..ctor
	|
	|-RVA: 0x29F5E70 Offset: 0x29F5F71 VA: 0x29F5E70
	|-Dictionary.ValueCollection<object, LayerMask>..ctor
	|
	|-RVA: 0x29F6850 Offset: 0x29F6951 VA: 0x29F6850
	|-Dictionary.ValueCollection<object, Matrix4x4>..ctor
	|
	|-RVA: 0x29F7340 Offset: 0x29F7441 VA: 0x29F7340
	|-Dictionary.ValueCollection<object, Playable>..ctor
	|
	|-RVA: 0x29F7D30 Offset: 0x29F7E31 VA: 0x29F7D30
	|-Dictionary.ValueCollection<object, Quaternion>..ctor
	|
	|-RVA: 0x29F8720 Offset: 0x29F8821 VA: 0x29F8720
	|-Dictionary.ValueCollection<object, RangeInt>..ctor
	|
	|-RVA: 0x29F9100 Offset: 0x29F9201 VA: 0x29F9100
	|-Dictionary.ValueCollection<object, Rect>..ctor
	|
	|-RVA: 0x29F9AF0 Offset: 0x29F9BF1 VA: 0x29F9AF0
	|-Dictionary.ValueCollection<object, RectInt>..ctor
	|
	|-RVA: 0x29FA4E0 Offset: 0x29FA5E1 VA: 0x29FA4E0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x29FAF60 Offset: 0x29FB061 VA: 0x29FAF60
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x29FB9E0 Offset: 0x29FBAE1 VA: 0x29FB9E0
	|-Dictionary.ValueCollection<object, Vector2>..ctor
	|
	|-RVA: 0x29FC3D0 Offset: 0x29FC4D1 VA: 0x29FC3D0
	|-Dictionary.ValueCollection<object, Vector2Int>..ctor
	|
	|-RVA: 0x29FCDB0 Offset: 0x29FCEB1 VA: 0x29FCDB0
	|-Dictionary.ValueCollection<object, Vector3>..ctor
	|
	|-RVA: 0x29FD7A0 Offset: 0x29FD8A1 VA: 0x29FD7A0
	|-Dictionary.ValueCollection<object, Vector3Int>..ctor
	|
	|-RVA: 0x29FE190 Offset: 0x29FE291 VA: 0x29FE190
	|-Dictionary.ValueCollection<object, Vector4>..ctor
	|
	|-RVA: 0x29FEB80 Offset: 0x29FEC81 VA: 0x29FEB80
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x29FF530 Offset: 0x29FF631 VA: 0x29FF530
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x29FFF10 Offset: 0x2A00011 VA: 0x29FFF10
	|-Dictionary.ValueCollection<sbyte, object>..ctor
	|
	|-RVA: 0x2A008C0 Offset: 0x2A009C1 VA: 0x2A008C0
	|-Dictionary.ValueCollection<float, CurveSample>..ctor
	|
	|-RVA: 0x2A01410 Offset: 0x2A01511 VA: 0x2A01410
	|-Dictionary.ValueCollection<float, object>..ctor
	|
	|-RVA: 0x2A01DC0 Offset: 0x2A01EC1 VA: 0x2A01DC0
	|-Dictionary.ValueCollection<ushort, object>..ctor
	|
	|-RVA: 0x2A02770 Offset: 0x2A02871 VA: 0x2A02770
	|-Dictionary.ValueCollection<uint, int>..ctor
	|
	|-RVA: 0x2A03150 Offset: 0x2A03251 VA: 0x2A03150
	|-Dictionary.ValueCollection<uint, Int32Enum>..ctor
	|
	|-RVA: 0x2A03B30 Offset: 0x2A03C31 VA: 0x2A03B30
	|-Dictionary.ValueCollection<uint, object>..ctor
	|
	|-RVA: 0x2A044E0 Offset: 0x2A045E1 VA: 0x2A044E0
	|-Dictionary.ValueCollection<ulong, object>..ctor
	|
	|-RVA: 0x2A04E90 Offset: 0x2A04F91 VA: 0x2A04E90
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x2A05870 Offset: 0x2A05971 VA: 0x2A05870
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x2A06330 Offset: 0x2A06431 VA: 0x2A06330
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x2A06E00 Offset: 0x2A06F01 VA: 0x2A06E00
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x2A07870 Offset: 0x2A07971 VA: 0x2A07870
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x2A08250 Offset: 0x2A08351 VA: 0x2A08250
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x2A08C00 Offset: 0x2A08D01 VA: 0x2A08C00
	|-Dictionary.ValueCollection<Bounds, object>..ctor
	|
	|-RVA: 0x2A095B0 Offset: 0x2A096B1 VA: 0x2A095B0
	|-Dictionary.ValueCollection<BoundsInt, object>..ctor
	|
	|-RVA: 0x2A09F60 Offset: 0x2A0A061 VA: 0x2A09F60
	|-Dictionary.ValueCollection<Color, object>..ctor
	|
	|-RVA: 0x2A0A910 Offset: 0x2A0AA11 VA: 0x2A0A910
	|-Dictionary.ValueCollection<Color32, object>..ctor
	|
	|-RVA: 0x2A0B2C0 Offset: 0x2A0B3C1 VA: 0x2A0B2C0
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x2A0BC70 Offset: 0x2A0BD71 VA: 0x2A0BC70
	|-Dictionary.ValueCollection<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x2A0C620 Offset: 0x2A0C721 VA: 0x2A0C620
	|-Dictionary.ValueCollection<GradientColorKey, object>..ctor
	|
	|-RVA: 0x2A0CFD0 Offset: 0x2A0D0D1 VA: 0x2A0CFD0
	|-Dictionary.ValueCollection<Keyframe, object>..ctor
	|
	|-RVA: 0x2A0D980 Offset: 0x2A0DA81 VA: 0x2A0D980
	|-Dictionary.ValueCollection<LayerMask, object>..ctor
	|
	|-RVA: 0x2A0E330 Offset: 0x2A0E431 VA: 0x2A0E330
	|-Dictionary.ValueCollection<Matrix4x4, object>..ctor
	|
	|-RVA: 0x2A0ECE0 Offset: 0x2A0EDE1 VA: 0x2A0ECE0
	|-Dictionary.ValueCollection<IntVec3, object>..ctor
	|
	|-RVA: 0x2A0F690 Offset: 0x2A0F791 VA: 0x2A0F690
	|-Dictionary.ValueCollection<Quaternion, object>..ctor
	|
	|-RVA: 0x2A10040 Offset: 0x2A10141 VA: 0x2A10040
	|-Dictionary.ValueCollection<RangeInt, object>..ctor
	|
	|-RVA: 0x2A109F0 Offset: 0x2A10AF1 VA: 0x2A109F0
	|-Dictionary.ValueCollection<Rect, object>..ctor
	|
	|-RVA: 0x2A113A0 Offset: 0x2A114A1 VA: 0x2A113A0
	|-Dictionary.ValueCollection<RectInt, object>..ctor
	|
	|-RVA: 0x2A11D50 Offset: 0x2A11E51 VA: 0x2A11D50
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x2A12730 Offset: 0x2A12831 VA: 0x2A12730
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x2A130E0 Offset: 0x2A131E1 VA: 0x2A130E0
	|-Dictionary.ValueCollection<Vector2, object>..ctor
	|
	|-RVA: 0x2A13A90 Offset: 0x2A13B91 VA: 0x2A13A90
	|-Dictionary.ValueCollection<Vector2Int, object>..ctor
	|
	|-RVA: 0x2A14440 Offset: 0x2A14541 VA: 0x2A14440
	|-Dictionary.ValueCollection<Vector3, object>..ctor
	|
	|-RVA: 0x2A14DF0 Offset: 0x2A14EF1 VA: 0x2A14DF0
	|-Dictionary.ValueCollection<Vector3Int, object>..ctor
	|
	|-RVA: 0x2A157A0 Offset: 0x2A158A1 VA: 0x2A157A0
	|-Dictionary.ValueCollection<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29C2200 Offset: 0x29C2301 VA: 0x29C2200
	|-Dictionary.ValueCollection<BeanID, BeanData>.GetEnumerator
	|-Dictionary.ValueCollection<ActorID, LifeCycleScriptPlayer>.GetEnumerator
	|-Dictionary.ValueCollection<ActorID, GrappleController>.GetEnumerator
	|-Dictionary.ValueCollection<ActorID, HandCuffsController>.GetEnumerator
	|-Dictionary.ValueCollection<ActorID, MobTravelerController>.GetEnumerator
	|-Dictionary.ValueCollection<BadStatus, BadStatusEffectController.ObjInfo>.GetEnumerator
	|-Dictionary.ValueCollection<ToolChargeLevel, ParticleSystem>.GetEnumerator
	|-Dictionary.ValueCollection<EquipSlotType, HumanEquipItem>.GetEnumerator
	|-Dictionary.ValueCollection<GateDataID, GateController>.GetEnumerator
	|-Dictionary.ValueCollection<ItemID, ItemPoolData>.GetEnumerator
	|-Dictionary.ValueCollection<SnowmanObjectID, SnowballData>.GetEnumerator
	|-Dictionary.ValueCollection<SoundID, EnvironmentSoundController>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, object>.GetEnumerator
	|
	|-RVA: 0x296D310 Offset: 0x296D411 VA: 0x296D310
	|-Dictionary.ValueCollection<Character, ActionSpeedController>.GetEnumerator
	|-Dictionary.ValueCollection<Character, AvoidController>.GetEnumerator
	|-Dictionary.ValueCollection<Character, BitController>.GetEnumerator
	|-Dictionary.ValueCollection<Character, GrantAttributeController>.GetEnumerator
	|-Dictionary.ValueCollection<Character, LazyController>.GetEnumerator
	|-Dictionary.ValueCollection<Character, RestraintController>.GetEnumerator
	|-Dictionary.ValueCollection<Character, SuperArmorController>.GetEnumerator
	|-Dictionary.ValueCollection<Character, SpringManager>.GetEnumerator
	|-Dictionary.ValueCollection<Character, YawnController>.GetEnumerator
	|-Dictionary.ValueCollection<CharacterBase, EmotionController>.GetEnumerator
	|-Dictionary.ValueCollection<CharacterBase, EscapeController>.GetEnumerator
	|-Dictionary.ValueCollection<CharacterBase, MagicController>.GetEnumerator
	|-Dictionary.ValueCollection<CharacterBase, SlowStateController>.GetEnumerator
	|-Dictionary.ValueCollection<CharacterBase, SoulController>.GetEnumerator
	|-Dictionary.ValueCollection<CharacterBase, ThrottleController>.GetEnumerator
	|-Dictionary.ValueCollection<string, ActionCode>.GetEnumerator
	|-Dictionary.ValueCollection<string, GUIStyle>.GetEnumerator
	|-Dictionary.ValueCollection<string, Transform>.GetEnumerator
	|-Dictionary.ValueCollection<Collider, CharacterNearCullingController>.GetEnumerator
	|-Dictionary.ValueCollection<Material, List<CombinedMesh.MaterialMeshInfo>>.GetEnumerator
	|-Dictionary.ValueCollection<object, object>.GetEnumerator
	|
	|-RVA: 0x29C1820 Offset: 0x29C1921 VA: 0x29C1820
	|-Dictionary.ValueCollection<EmotionType, Prefab>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x295E850 Offset: 0x295E951 VA: 0x295E850
	|-Dictionary.ValueCollection<MonsterControllerBase, int>.GetEnumerator
	|-Dictionary.ValueCollection<object, int>.GetEnumerator
	|
	|-RVA: 0x2910680 Offset: 0x2910781 VA: 0x2910680
	|-Dictionary.ValueCollection<MonsterDataID, MonsterDataTable>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.GetEnumerator
	|
	|-RVA: 0x290D430 Offset: 0x290D531 VA: 0x290D430
	|-Dictionary.ValueCollection<int, BossStageManager>.GetEnumerator
	|-Dictionary.ValueCollection<int, AssetHandle>.GetEnumerator
	|-Dictionary.ValueCollection<int, PointerEventData>.GetEnumerator
	|-Dictionary.ValueCollection<int, object>.GetEnumerator
	|
	|-RVA: 0x290E8B0 Offset: 0x290E9B1 VA: 0x290E8B0
	|-Dictionary.ValueCollection<int, SceneInstance>.GetEnumerator
	|
	|-RVA: 0x2A03BE0 Offset: 0x2A03CE1 VA: 0x2A03BE0
	|-Dictionary.ValueCollection<uint, FriendMonsterStatus>.GetEnumerator
	|-Dictionary.ValueCollection<uint, object>.GetEnumerator
	|
	|-RVA: 0x2341000 Offset: 0x2341101 VA: 0x2341000
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.GetEnumerator
	|
	|-RVA: 0x23419B0 Offset: 0x2341AB1 VA: 0x23419B0
	|-Dictionary.ValueCollection<BitVector32Int, object>.GetEnumerator
	|
	|-RVA: 0x2342360 Offset: 0x2342461 VA: 0x2342360
	|-Dictionary.ValueCollection<EventCheckId, object>.GetEnumerator
	|
	|-RVA: 0x28FD350 Offset: 0x28FD451 VA: 0x28FD350
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.GetEnumerator
	|
	|-RVA: 0x28FDD00 Offset: 0x28FDE01 VA: 0x28FDD00
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.GetEnumerator
	|
	|-RVA: 0x28FE6B0 Offset: 0x28FE7B1 VA: 0x28FE6B0
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.GetEnumerator
	|
	|-RVA: 0x28FF060 Offset: 0x28FF161 VA: 0x28FF060
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.GetEnumerator
	|
	|-RVA: 0x28FFA10 Offset: 0x28FFB11 VA: 0x28FFA10
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.GetEnumerator
	|
	|-RVA: 0x29003C0 Offset: 0x29004C1 VA: 0x29003C0
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.GetEnumerator
	|
	|-RVA: 0x2900D70 Offset: 0x2900E71 VA: 0x2900D70
	|-Dictionary.ValueCollection<OrderSaveData, object>.GetEnumerator
	|
	|-RVA: 0x2901720 Offset: 0x2901821 VA: 0x2901720
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.GetEnumerator
	|
	|-RVA: 0x29020D0 Offset: 0x29021D1 VA: 0x29020D0
	|-Dictionary.ValueCollection<Parameter, object>.GetEnumerator
	|
	|-RVA: 0x2902A80 Offset: 0x2902B81 VA: 0x2902A80
	|-Dictionary.ValueCollection<bool, object>.GetEnumerator
	|
	|-RVA: 0x2903430 Offset: 0x2903531 VA: 0x2903430
	|-Dictionary.ValueCollection<byte, object>.GetEnumerator
	|
	|-RVA: 0x2903DE0 Offset: 0x2903EE1 VA: 0x2903DE0
	|-Dictionary.ValueCollection<char, object>.GetEnumerator
	|
	|-RVA: 0x2904790 Offset: 0x2904891 VA: 0x2904790
	|-Dictionary.ValueCollection<DateTime, object>.GetEnumerator
	|
	|-RVA: 0x2905140 Offset: 0x2905241 VA: 0x2905140
	|-Dictionary.ValueCollection<double, object>.GetEnumerator
	|
	|-RVA: 0x2905AF0 Offset: 0x2905BF1 VA: 0x2905AF0
	|-Dictionary.ValueCollection<Guid, object>.GetEnumerator
	|
	|-RVA: 0x29064A0 Offset: 0x29065A1 VA: 0x29064A0
	|-Dictionary.ValueCollection<short, object>.GetEnumerator
	|
	|-RVA: 0x2906E50 Offset: 0x2906F51 VA: 0x2906E50
	|-Dictionary.ValueCollection<int, CropDataTable>.GetEnumerator
	|
	|-RVA: 0x2907990 Offset: 0x2907A91 VA: 0x2907990
	|-Dictionary.ValueCollection<int, EffectDataTable>.GetEnumerator
	|
	|-RVA: 0x2908400 Offset: 0x2908501 VA: 0x2908400
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.GetEnumerator
	|
	|-RVA: 0x2908DE0 Offset: 0x2908EE1 VA: 0x2908DE0
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.GetEnumerator
	|
	|-RVA: 0x29098D0 Offset: 0x29099D1 VA: 0x29098D0
	|-Dictionary.ValueCollection<int, MiningDataTable>.GetEnumerator
	|
	|-RVA: 0x290A2D0 Offset: 0x290A3D1 VA: 0x290A2D0
	|-Dictionary.ValueCollection<int, bool>.GetEnumerator
	|
	|-RVA: 0x290ACB0 Offset: 0x290ADB1 VA: 0x290ACB0
	|-Dictionary.ValueCollection<int, char>.GetEnumerator
	|
	|-RVA: 0x290B690 Offset: 0x290B791 VA: 0x290B690
	|-Dictionary.ValueCollection<int, int>.GetEnumerator
	|
	|-RVA: 0x290C070 Offset: 0x290C171 VA: 0x290C070
	|-Dictionary.ValueCollection<int, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x290CA50 Offset: 0x290CB51 VA: 0x290CA50
	|-Dictionary.ValueCollection<int, long>.GetEnumerator
	|
	|-RVA: 0x290DDE0 Offset: 0x290DEE1 VA: 0x290DDE0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x290F2B0 Offset: 0x290F3B1 VA: 0x290F2B0
	|-Dictionary.ValueCollection<int, Vector2Int>.GetEnumerator
	|
	|-RVA: 0x290FC90 Offset: 0x290FD91 VA: 0x290FC90
	|-Dictionary.ValueCollection<int, Vector3>.GetEnumerator
	|
	|-RVA: 0x29111A0 Offset: 0x29112A1 VA: 0x29111A0
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.GetEnumerator
	|
	|-RVA: 0x2911C70 Offset: 0x2911D71 VA: 0x2911C70
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.GetEnumerator
	|
	|-RVA: 0x2912660 Offset: 0x2912761 VA: 0x2912660
	|-Dictionary.ValueCollection<Int32Enum, bool>.GetEnumerator
	|
	|-RVA: 0x2913040 Offset: 0x2913141 VA: 0x2913040
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x29C0E40 Offset: 0x29C0F41 VA: 0x29C0E40
	|-Dictionary.ValueCollection<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x29C2BB0 Offset: 0x29C2CB1 VA: 0x29C2BB0
	|-Dictionary.ValueCollection<Int32Enum, float>.GetEnumerator
	|
	|-RVA: 0x29C3590 Offset: 0x29C3691 VA: 0x29C3590
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.GetEnumerator
	|
	|-RVA: 0x29C3F90 Offset: 0x29C4091 VA: 0x29C3F90
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.GetEnumerator
	|
	|-RVA: 0x29C4980 Offset: 0x29C4A81 VA: 0x29C4980
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.GetEnumerator
	|
	|-RVA: 0x29C5370 Offset: 0x29C5471 VA: 0x29C5370
	|-Dictionary.ValueCollection<long, object>.GetEnumerator
	|
	|-RVA: 0x29C5D20 Offset: 0x29C5E21 VA: 0x29C5D20
	|-Dictionary.ValueCollection<Memory<object>, object>.GetEnumerator
	|
	|-RVA: 0x29C66D0 Offset: 0x29C67D1 VA: 0x29C66D0
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.GetEnumerator
	|
	|-RVA: 0x29C7080 Offset: 0x29C7181 VA: 0x29C7080
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.GetEnumerator
	|
	|-RVA: 0x29C7A30 Offset: 0x29C7B31 VA: 0x29C7A30
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.GetEnumerator
	|
	|-RVA: 0x29C83E0 Offset: 0x29C84E1 VA: 0x29C83E0
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.GetEnumerator
	|
	|-RVA: 0x29C8D90 Offset: 0x29C8E91 VA: 0x29C8D90
	|-Dictionary.ValueCollection<Nullable<Color>, object>.GetEnumerator
	|
	|-RVA: 0x29C9740 Offset: 0x29C9841 VA: 0x29C9740
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.GetEnumerator
	|
	|-RVA: 0x29CA0F0 Offset: 0x29CA1F1 VA: 0x29CA0F0
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.GetEnumerator
	|
	|-RVA: 0x29CAAA0 Offset: 0x29CABA1 VA: 0x29CAAA0
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.GetEnumerator
	|
	|-RVA: 0x29CB450 Offset: 0x29CB551 VA: 0x29CB450
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.GetEnumerator
	|
	|-RVA: 0x29CBE00 Offset: 0x29CBF01 VA: 0x29CBE00
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.GetEnumerator
	|
	|-RVA: 0x29CC7B0 Offset: 0x29CC8B1 VA: 0x29CC7B0
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.GetEnumerator
	|
	|-RVA: 0x29CD160 Offset: 0x29CD261 VA: 0x29CD160
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.GetEnumerator
	|
	|-RVA: 0x29CDB10 Offset: 0x29CDC11 VA: 0x29CDB10
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.GetEnumerator
	|
	|-RVA: 0x29CE4C0 Offset: 0x29CE5C1 VA: 0x29CE4C0
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.GetEnumerator
	|
	|-RVA: 0x29CEE70 Offset: 0x29CEF71 VA: 0x29CEE70
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.GetEnumerator
	|
	|-RVA: 0x29CF820 Offset: 0x29CF921 VA: 0x29CF820
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.GetEnumerator
	|
	|-RVA: 0x29D01D0 Offset: 0x29D02D1 VA: 0x29D01D0
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.GetEnumerator
	|
	|-RVA: 0x29D0B80 Offset: 0x29D0C81 VA: 0x29D0B80
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.GetEnumerator
	|
	|-RVA: 0x29D1530 Offset: 0x29D1631 VA: 0x29D1530
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.GetEnumerator
	|
	|-RVA: 0x29D1EE0 Offset: 0x29D1FE1 VA: 0x29D1EE0
	|-Dictionary.ValueCollection<object, BitVector32Int>.GetEnumerator
	|
	|-RVA: 0x29D28C0 Offset: 0x29D29C1 VA: 0x29D28C0
	|-Dictionary.ValueCollection<object, EventCheckId>.GetEnumerator
	|
	|-RVA: 0x29D3340 Offset: 0x29D3441 VA: 0x29D3340
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.GetEnumerator
	|
	|-RVA: 0x29D3E50 Offset: 0x29D3F51 VA: 0x29D3E50
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.GetEnumerator
	|
	|-RVA: 0x29D48C0 Offset: 0x29D49C1 VA: 0x29D48C0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.GetEnumerator
	|
	|-RVA: 0x29D52B0 Offset: 0x29D53B1 VA: 0x29D52B0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.GetEnumerator
	|
	|-RVA: 0x29D5CA0 Offset: 0x29D5DA1 VA: 0x29D5CA0
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.GetEnumerator
	|
	|-RVA: 0x29D6760 Offset: 0x29D6861 VA: 0x29D6760
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.GetEnumerator
	|
	|-RVA: 0x29582D0 Offset: 0x29583D1 VA: 0x29582D0
	|-Dictionary.ValueCollection<object, OrderSaveData>.GetEnumerator
	|
	|-RVA: 0x2958D90 Offset: 0x2958E91 VA: 0x2958D90
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.GetEnumerator
	|
	|-RVA: 0x2959810 Offset: 0x2959911 VA: 0x2959810
	|-Dictionary.ValueCollection<object, Parameter>.GetEnumerator
	|
	|-RVA: 0x295A320 Offset: 0x295A421 VA: 0x295A320
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.GetEnumerator
	|
	|-RVA: 0x295AD10 Offset: 0x295AE11 VA: 0x295AD10
	|-Dictionary.ValueCollection<object, bool>.GetEnumerator
	|
	|-RVA: 0x295B6F0 Offset: 0x295B7F1 VA: 0x295B6F0
	|-Dictionary.ValueCollection<object, byte>.GetEnumerator
	|
	|-RVA: 0x295C0D0 Offset: 0x295C1D1 VA: 0x295C0D0
	|-Dictionary.ValueCollection<object, char>.GetEnumerator
	|
	|-RVA: 0x295CAB0 Offset: 0x295CBB1 VA: 0x295CAB0
	|-Dictionary.ValueCollection<object, DateTime>.GetEnumerator
	|
	|-RVA: 0x295D490 Offset: 0x295D591 VA: 0x295D490
	|-Dictionary.ValueCollection<object, double>.GetEnumerator
	|
	|-RVA: 0x295DE70 Offset: 0x295DF71 VA: 0x295DE70
	|-Dictionary.ValueCollection<object, short>.GetEnumerator
	|
	|-RVA: 0x295F230 Offset: 0x295F331 VA: 0x295F230
	|-Dictionary.ValueCollection<object, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x295FC10 Offset: 0x295FD11 VA: 0x295FC10
	|-Dictionary.ValueCollection<object, long>.GetEnumerator
	|
	|-RVA: 0x29605F0 Offset: 0x29606F1 VA: 0x29605F0
	|-Dictionary.ValueCollection<object, Memory<object>>.GetEnumerator
	|
	|-RVA: 0x2960FF0 Offset: 0x29610F1 VA: 0x2960FF0
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x29619D0 Offset: 0x2961AD1 VA: 0x29619D0
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.GetEnumerator
	|
	|-RVA: 0x2962480 Offset: 0x2962581 VA: 0x2962480
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.GetEnumerator
	|
	|-RVA: 0x2962F30 Offset: 0x2963031 VA: 0x2962F30
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.GetEnumerator
	|
	|-RVA: 0x2963910 Offset: 0x2963A11 VA: 0x2963910
	|-Dictionary.ValueCollection<object, Nullable<Color>>.GetEnumerator
	|
	|-RVA: 0x2964380 Offset: 0x2964481 VA: 0x2964380
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.GetEnumerator
	|
	|-RVA: 0x2964D70 Offset: 0x2964E71 VA: 0x2964D70
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.GetEnumerator
	|
	|-RVA: 0x29657E0 Offset: 0x29658E1 VA: 0x29657E0
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.GetEnumerator
	|
	|-RVA: 0x2966260 Offset: 0x2966361 VA: 0x2966260
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.GetEnumerator
	|
	|-RVA: 0x2966C40 Offset: 0x2966D41 VA: 0x2966C40
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.GetEnumerator
	|
	|-RVA: 0x29677A0 Offset: 0x29678A1 VA: 0x29677A0
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.GetEnumerator
	|
	|-RVA: 0x2968210 Offset: 0x2968311 VA: 0x2968210
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.GetEnumerator
	|
	|-RVA: 0x2968C00 Offset: 0x2968D01 VA: 0x2968C00
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.GetEnumerator
	|
	|-RVA: 0x2969670 Offset: 0x2969771 VA: 0x2969670
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.GetEnumerator
	|
	|-RVA: 0x296A0E0 Offset: 0x296A1E1 VA: 0x296A0E0
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.GetEnumerator
	|
	|-RVA: 0x296AAD0 Offset: 0x296ABD1 VA: 0x296AAD0
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.GetEnumerator
	|
	|-RVA: 0x296B4C0 Offset: 0x296B5C1 VA: 0x296B4C0
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.GetEnumerator
	|
	|-RVA: 0x296BEB0 Offset: 0x296BFB1 VA: 0x296BEB0
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.GetEnumerator
	|
	|-RVA: 0x296C8A0 Offset: 0x296C9A1 VA: 0x296C8A0
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.GetEnumerator
	|
	|-RVA: 0x296DCC0 Offset: 0x296DDC1 VA: 0x296DCC0
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.GetEnumerator
	|
	|-RVA: 0x296E6C0 Offset: 0x296E7C1 VA: 0x296E6C0
	|-Dictionary.ValueCollection<object, ResourceLocator>.GetEnumerator
	|
	|-RVA: 0x29EDB80 Offset: 0x29EDC81 VA: 0x29EDB80
	|-Dictionary.ValueCollection<object, sbyte>.GetEnumerator
	|
	|-RVA: 0x29EE560 Offset: 0x29EE661 VA: 0x29EE560
	|-Dictionary.ValueCollection<object, float>.GetEnumerator
	|
	|-RVA: 0x29EEF40 Offset: 0x29EF041 VA: 0x29EEF40
	|-Dictionary.ValueCollection<object, ushort>.GetEnumerator
	|
	|-RVA: 0x29EF920 Offset: 0x29EFA21 VA: 0x29EF920
	|-Dictionary.ValueCollection<object, uint>.GetEnumerator
	|
	|-RVA: 0x29F0300 Offset: 0x29F0401 VA: 0x29F0300
	|-Dictionary.ValueCollection<object, ulong>.GetEnumerator
	|
	|-RVA: 0x29F0CE0 Offset: 0x29F0DE1 VA: 0x29F0CE0
	|-Dictionary.ValueCollection<object, TransitionTables>.GetEnumerator
	|
	|-RVA: 0x29F1760 Offset: 0x29F1861 VA: 0x29F1760
	|-Dictionary.ValueCollection<object, Bounds>.GetEnumerator
	|
	|-RVA: 0x29F21D0 Offset: 0x29F22D1 VA: 0x29F21D0
	|-Dictionary.ValueCollection<object, BoundsInt>.GetEnumerator
	|
	|-RVA: 0x29F2C40 Offset: 0x29F2D41 VA: 0x29F2C40
	|-Dictionary.ValueCollection<object, Color32>.GetEnumerator
	|
	|-RVA: 0x29F3620 Offset: 0x29F3721 VA: 0x29F3620
	|-Dictionary.ValueCollection<object, Color>.GetEnumerator
	|
	|-RVA: 0x29F4010 Offset: 0x29F4111 VA: 0x29F4010
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.GetEnumerator
	|
	|-RVA: 0x29F4A00 Offset: 0x29F4B01 VA: 0x29F4A00
	|-Dictionary.ValueCollection<object, GradientColorKey>.GetEnumerator
	|
	|-RVA: 0x29F5470 Offset: 0x29F5571 VA: 0x29F5470
	|-Dictionary.ValueCollection<object, Keyframe>.GetEnumerator
	|
	|-RVA: 0x29F5F20 Offset: 0x29F6021 VA: 0x29F5F20
	|-Dictionary.ValueCollection<object, LayerMask>.GetEnumerator
	|
	|-RVA: 0x29F6900 Offset: 0x29F6A01 VA: 0x29F6900
	|-Dictionary.ValueCollection<object, Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x29F73F0 Offset: 0x29F74F1 VA: 0x29F73F0
	|-Dictionary.ValueCollection<object, Playable>.GetEnumerator
	|
	|-RVA: 0x29F7DE0 Offset: 0x29F7EE1 VA: 0x29F7DE0
	|-Dictionary.ValueCollection<object, Quaternion>.GetEnumerator
	|
	|-RVA: 0x29F87D0 Offset: 0x29F88D1 VA: 0x29F87D0
	|-Dictionary.ValueCollection<object, RangeInt>.GetEnumerator
	|
	|-RVA: 0x29F91B0 Offset: 0x29F92B1 VA: 0x29F91B0
	|-Dictionary.ValueCollection<object, Rect>.GetEnumerator
	|
	|-RVA: 0x29F9BA0 Offset: 0x29F9CA1 VA: 0x29F9BA0
	|-Dictionary.ValueCollection<object, RectInt>.GetEnumerator
	|
	|-RVA: 0x29FA590 Offset: 0x29FA691 VA: 0x29FA590
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x29FB010 Offset: 0x29FB111 VA: 0x29FB010
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.GetEnumerator
	|
	|-RVA: 0x29FBA90 Offset: 0x29FBB91 VA: 0x29FBA90
	|-Dictionary.ValueCollection<object, Vector2>.GetEnumerator
	|
	|-RVA: 0x29FC480 Offset: 0x29FC581 VA: 0x29FC480
	|-Dictionary.ValueCollection<object, Vector2Int>.GetEnumerator
	|
	|-RVA: 0x29FCE60 Offset: 0x29FCF61 VA: 0x29FCE60
	|-Dictionary.ValueCollection<object, Vector3>.GetEnumerator
	|
	|-RVA: 0x29FD850 Offset: 0x29FD951 VA: 0x29FD850
	|-Dictionary.ValueCollection<object, Vector3Int>.GetEnumerator
	|
	|-RVA: 0x29FE240 Offset: 0x29FE341 VA: 0x29FE240
	|-Dictionary.ValueCollection<object, Vector4>.GetEnumerator
	|
	|-RVA: 0x29FEC30 Offset: 0x29FED31 VA: 0x29FEC30
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.GetEnumerator
	|
	|-RVA: 0x29FF5E0 Offset: 0x29FF6E1 VA: 0x29FF5E0
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.GetEnumerator
	|
	|-RVA: 0x29FFFC0 Offset: 0x2A000C1 VA: 0x29FFFC0
	|-Dictionary.ValueCollection<sbyte, object>.GetEnumerator
	|
	|-RVA: 0x2A00970 Offset: 0x2A00A71 VA: 0x2A00970
	|-Dictionary.ValueCollection<float, CurveSample>.GetEnumerator
	|
	|-RVA: 0x2A014C0 Offset: 0x2A015C1 VA: 0x2A014C0
	|-Dictionary.ValueCollection<float, object>.GetEnumerator
	|
	|-RVA: 0x2A01E70 Offset: 0x2A01F71 VA: 0x2A01E70
	|-Dictionary.ValueCollection<ushort, object>.GetEnumerator
	|
	|-RVA: 0x2A02820 Offset: 0x2A02921 VA: 0x2A02820
	|-Dictionary.ValueCollection<uint, int>.GetEnumerator
	|
	|-RVA: 0x2A03200 Offset: 0x2A03301 VA: 0x2A03200
	|-Dictionary.ValueCollection<uint, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2A04590 Offset: 0x2A04691 VA: 0x2A04590
	|-Dictionary.ValueCollection<ulong, object>.GetEnumerator
	|
	|-RVA: 0x2A04F40 Offset: 0x2A05041 VA: 0x2A04F40
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.GetEnumerator
	|
	|-RVA: 0x2A05920 Offset: 0x2A05A21 VA: 0x2A05920
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.GetEnumerator
	|
	|-RVA: 0x2A063E0 Offset: 0x2A064E1 VA: 0x2A063E0
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.GetEnumerator
	|
	|-RVA: 0x2A06EB0 Offset: 0x2A06FB1 VA: 0x2A06EB0
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.GetEnumerator
	|
	|-RVA: 0x2A07920 Offset: 0x2A07A21 VA: 0x2A07920
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.GetEnumerator
	|
	|-RVA: 0x2A08300 Offset: 0x2A08401 VA: 0x2A08300
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.GetEnumerator
	|
	|-RVA: 0x2A08CB0 Offset: 0x2A08DB1 VA: 0x2A08CB0
	|-Dictionary.ValueCollection<Bounds, object>.GetEnumerator
	|
	|-RVA: 0x2A09660 Offset: 0x2A09761 VA: 0x2A09660
	|-Dictionary.ValueCollection<BoundsInt, object>.GetEnumerator
	|
	|-RVA: 0x2A0A010 Offset: 0x2A0A111 VA: 0x2A0A010
	|-Dictionary.ValueCollection<Color, object>.GetEnumerator
	|
	|-RVA: 0x2A0A9C0 Offset: 0x2A0AAC1 VA: 0x2A0A9C0
	|-Dictionary.ValueCollection<Color32, object>.GetEnumerator
	|
	|-RVA: 0x2A0B370 Offset: 0x2A0B471 VA: 0x2A0B370
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.GetEnumerator
	|
	|-RVA: 0x2A0BD20 Offset: 0x2A0BE21 VA: 0x2A0BD20
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.GetEnumerator
	|
	|-RVA: 0x2A0C6D0 Offset: 0x2A0C7D1 VA: 0x2A0C6D0
	|-Dictionary.ValueCollection<GradientColorKey, object>.GetEnumerator
	|
	|-RVA: 0x2A0D080 Offset: 0x2A0D181 VA: 0x2A0D080
	|-Dictionary.ValueCollection<Keyframe, object>.GetEnumerator
	|
	|-RVA: 0x2A0DA30 Offset: 0x2A0DB31 VA: 0x2A0DA30
	|-Dictionary.ValueCollection<LayerMask, object>.GetEnumerator
	|
	|-RVA: 0x2A0E3E0 Offset: 0x2A0E4E1 VA: 0x2A0E3E0
	|-Dictionary.ValueCollection<Matrix4x4, object>.GetEnumerator
	|
	|-RVA: 0x2A0ED90 Offset: 0x2A0EE91 VA: 0x2A0ED90
	|-Dictionary.ValueCollection<IntVec3, object>.GetEnumerator
	|
	|-RVA: 0x2A0F740 Offset: 0x2A0F841 VA: 0x2A0F740
	|-Dictionary.ValueCollection<Quaternion, object>.GetEnumerator
	|
	|-RVA: 0x2A100F0 Offset: 0x2A101F1 VA: 0x2A100F0
	|-Dictionary.ValueCollection<RangeInt, object>.GetEnumerator
	|
	|-RVA: 0x2A10AA0 Offset: 0x2A10BA1 VA: 0x2A10AA0
	|-Dictionary.ValueCollection<Rect, object>.GetEnumerator
	|
	|-RVA: 0x2A11450 Offset: 0x2A11551 VA: 0x2A11450
	|-Dictionary.ValueCollection<RectInt, object>.GetEnumerator
	|
	|-RVA: 0x2A11E00 Offset: 0x2A11F01 VA: 0x2A11E00
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.GetEnumerator
	|
	|-RVA: 0x2A127E0 Offset: 0x2A128E1 VA: 0x2A127E0
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.GetEnumerator
	|
	|-RVA: 0x2A13190 Offset: 0x2A13291 VA: 0x2A13190
	|-Dictionary.ValueCollection<Vector2, object>.GetEnumerator
	|
	|-RVA: 0x2A13B40 Offset: 0x2A13C41 VA: 0x2A13B40
	|-Dictionary.ValueCollection<Vector2Int, object>.GetEnumerator
	|
	|-RVA: 0x2A144F0 Offset: 0x2A145F1 VA: 0x2A144F0
	|-Dictionary.ValueCollection<Vector3, object>.GetEnumerator
	|
	|-RVA: 0x2A14EA0 Offset: 0x2A14FA1 VA: 0x2A14EA0
	|-Dictionary.ValueCollection<Vector3Int, object>.GetEnumerator
	|
	|-RVA: 0x2A15850 Offset: 0x2A15951 VA: 0x2A15850
	|-Dictionary.ValueCollection<Vector4, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2341060 Offset: 0x2341161 VA: 0x2341060
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.CopyTo
	|
	|-RVA: 0x2341A10 Offset: 0x2341B11 VA: 0x2341A10
	|-Dictionary.ValueCollection<BitVector32Int, object>.CopyTo
	|
	|-RVA: 0x23423C0 Offset: 0x23424C1 VA: 0x23423C0
	|-Dictionary.ValueCollection<EventCheckId, object>.CopyTo
	|
	|-RVA: 0x28FD3B0 Offset: 0x28FD4B1 VA: 0x28FD3B0
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.CopyTo
	|
	|-RVA: 0x28FDD60 Offset: 0x28FDE61 VA: 0x28FDD60
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.CopyTo
	|
	|-RVA: 0x28FE710 Offset: 0x28FE811 VA: 0x28FE710
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.CopyTo
	|
	|-RVA: 0x28FF0C0 Offset: 0x28FF1C1 VA: 0x28FF0C0
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.CopyTo
	|
	|-RVA: 0x28FFA70 Offset: 0x28FFB71 VA: 0x28FFA70
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.CopyTo
	|
	|-RVA: 0x2900420 Offset: 0x2900521 VA: 0x2900420
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.CopyTo
	|
	|-RVA: 0x2900DD0 Offset: 0x2900ED1 VA: 0x2900DD0
	|-Dictionary.ValueCollection<OrderSaveData, object>.CopyTo
	|
	|-RVA: 0x2901780 Offset: 0x2901881 VA: 0x2901780
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.CopyTo
	|
	|-RVA: 0x2902130 Offset: 0x2902231 VA: 0x2902130
	|-Dictionary.ValueCollection<Parameter, object>.CopyTo
	|
	|-RVA: 0x2902AE0 Offset: 0x2902BE1 VA: 0x2902AE0
	|-Dictionary.ValueCollection<bool, object>.CopyTo
	|
	|-RVA: 0x2903490 Offset: 0x2903591 VA: 0x2903490
	|-Dictionary.ValueCollection<byte, object>.CopyTo
	|
	|-RVA: 0x2903E40 Offset: 0x2903F41 VA: 0x2903E40
	|-Dictionary.ValueCollection<char, object>.CopyTo
	|
	|-RVA: 0x29047F0 Offset: 0x29048F1 VA: 0x29047F0
	|-Dictionary.ValueCollection<DateTime, object>.CopyTo
	|
	|-RVA: 0x29051A0 Offset: 0x29052A1 VA: 0x29051A0
	|-Dictionary.ValueCollection<double, object>.CopyTo
	|
	|-RVA: 0x2905B50 Offset: 0x2905C51 VA: 0x2905B50
	|-Dictionary.ValueCollection<Guid, object>.CopyTo
	|
	|-RVA: 0x2906500 Offset: 0x2906601 VA: 0x2906500
	|-Dictionary.ValueCollection<short, object>.CopyTo
	|
	|-RVA: 0x2906EE0 Offset: 0x2906FE1 VA: 0x2906EE0
	|-Dictionary.ValueCollection<int, CropDataTable>.CopyTo
	|
	|-RVA: 0x29079F0 Offset: 0x2907AF1 VA: 0x29079F0
	|-Dictionary.ValueCollection<int, EffectDataTable>.CopyTo
	|
	|-RVA: 0x2908460 Offset: 0x2908561 VA: 0x2908460
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.CopyTo
	|
	|-RVA: 0x2908E60 Offset: 0x2908F61 VA: 0x2908E60
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.CopyTo
	|
	|-RVA: 0x2909930 Offset: 0x2909A31 VA: 0x2909930
	|-Dictionary.ValueCollection<int, MiningDataTable>.CopyTo
	|
	|-RVA: 0x290A330 Offset: 0x290A431 VA: 0x290A330
	|-Dictionary.ValueCollection<int, bool>.CopyTo
	|
	|-RVA: 0x290AD10 Offset: 0x290AE11 VA: 0x290AD10
	|-Dictionary.ValueCollection<int, char>.CopyTo
	|
	|-RVA: 0x290B6F0 Offset: 0x290B7F1 VA: 0x290B6F0
	|-Dictionary.ValueCollection<int, int>.CopyTo
	|
	|-RVA: 0x290C0D0 Offset: 0x290C1D1 VA: 0x290C0D0
	|-Dictionary.ValueCollection<int, Int32Enum>.CopyTo
	|
	|-RVA: 0x290CAB0 Offset: 0x290CBB1 VA: 0x290CAB0
	|-Dictionary.ValueCollection<int, long>.CopyTo
	|
	|-RVA: 0x290D490 Offset: 0x290D591 VA: 0x290D490
	|-Dictionary.ValueCollection<int, object>.CopyTo
	|
	|-RVA: 0x290DE50 Offset: 0x290DF51 VA: 0x290DE50
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x290E910 Offset: 0x290EA11 VA: 0x290E910
	|-Dictionary.ValueCollection<int, SceneInstance>.CopyTo
	|
	|-RVA: 0x290F310 Offset: 0x290F411 VA: 0x290F310
	|-Dictionary.ValueCollection<int, Vector2Int>.CopyTo
	|
	|-RVA: 0x290FCF0 Offset: 0x290FDF1 VA: 0x290FCF0
	|-Dictionary.ValueCollection<int, Vector3>.CopyTo
	|
	|-RVA: 0x2910710 Offset: 0x2910811 VA: 0x2910710
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.CopyTo
	|
	|-RVA: 0x2911210 Offset: 0x2911311 VA: 0x2911210
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.CopyTo
	|
	|-RVA: 0x2911CD0 Offset: 0x2911DD1 VA: 0x2911CD0
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.CopyTo
	|
	|-RVA: 0x29126C0 Offset: 0x29127C1 VA: 0x29126C0
	|-Dictionary.ValueCollection<Int32Enum, bool>.CopyTo
	|
	|-RVA: 0x29130A0 Offset: 0x29131A1 VA: 0x29130A0
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x29C0EA0 Offset: 0x29C0FA1 VA: 0x29C0EA0
	|-Dictionary.ValueCollection<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x29C1880 Offset: 0x29C1981 VA: 0x29C1880
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.CopyTo
	|
	|-RVA: 0x29C2260 Offset: 0x29C2361 VA: 0x29C2260
	|-Dictionary.ValueCollection<Int32Enum, object>.CopyTo
	|
	|-RVA: 0x29C2C10 Offset: 0x29C2D11 VA: 0x29C2C10
	|-Dictionary.ValueCollection<Int32Enum, float>.CopyTo
	|
	|-RVA: 0x29C35F0 Offset: 0x29C36F1 VA: 0x29C35F0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.CopyTo
	|
	|-RVA: 0x29C3FF0 Offset: 0x29C40F1 VA: 0x29C3FF0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.CopyTo
	|
	|-RVA: 0x29C49E0 Offset: 0x29C4AE1 VA: 0x29C49E0
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.CopyTo
	|
	|-RVA: 0x29C53D0 Offset: 0x29C54D1 VA: 0x29C53D0
	|-Dictionary.ValueCollection<long, object>.CopyTo
	|
	|-RVA: 0x29C5D80 Offset: 0x29C5E81 VA: 0x29C5D80
	|-Dictionary.ValueCollection<Memory<object>, object>.CopyTo
	|
	|-RVA: 0x29C6730 Offset: 0x29C6831 VA: 0x29C6730
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.CopyTo
	|
	|-RVA: 0x29C70E0 Offset: 0x29C71E1 VA: 0x29C70E0
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.CopyTo
	|
	|-RVA: 0x29C7A90 Offset: 0x29C7B91 VA: 0x29C7A90
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.CopyTo
	|
	|-RVA: 0x29C8440 Offset: 0x29C8541 VA: 0x29C8440
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.CopyTo
	|
	|-RVA: 0x29C8DF0 Offset: 0x29C8EF1 VA: 0x29C8DF0
	|-Dictionary.ValueCollection<Nullable<Color>, object>.CopyTo
	|
	|-RVA: 0x29C97A0 Offset: 0x29C98A1 VA: 0x29C97A0
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.CopyTo
	|
	|-RVA: 0x29CA150 Offset: 0x29CA251 VA: 0x29CA150
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.CopyTo
	|
	|-RVA: 0x29CAB00 Offset: 0x29CAC01 VA: 0x29CAB00
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.CopyTo
	|
	|-RVA: 0x29CB4B0 Offset: 0x29CB5B1 VA: 0x29CB4B0
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.CopyTo
	|
	|-RVA: 0x29CBE60 Offset: 0x29CBF61 VA: 0x29CBE60
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.CopyTo
	|
	|-RVA: 0x29CC810 Offset: 0x29CC911 VA: 0x29CC810
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.CopyTo
	|
	|-RVA: 0x29CD1C0 Offset: 0x29CD2C1 VA: 0x29CD1C0
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.CopyTo
	|
	|-RVA: 0x29CDB70 Offset: 0x29CDC71 VA: 0x29CDB70
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.CopyTo
	|
	|-RVA: 0x29CE520 Offset: 0x29CE621 VA: 0x29CE520
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.CopyTo
	|
	|-RVA: 0x29CEED0 Offset: 0x29CEFD1 VA: 0x29CEED0
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.CopyTo
	|
	|-RVA: 0x29CF880 Offset: 0x29CF981 VA: 0x29CF880
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.CopyTo
	|
	|-RVA: 0x29D0230 Offset: 0x29D0331 VA: 0x29D0230
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.CopyTo
	|
	|-RVA: 0x29D0BE0 Offset: 0x29D0CE1 VA: 0x29D0BE0
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.CopyTo
	|
	|-RVA: 0x29D1590 Offset: 0x29D1691 VA: 0x29D1590
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.CopyTo
	|
	|-RVA: 0x29D1F40 Offset: 0x29D2041 VA: 0x29D1F40
	|-Dictionary.ValueCollection<object, BitVector32Int>.CopyTo
	|
	|-RVA: 0x29D2920 Offset: 0x29D2A21 VA: 0x29D2920
	|-Dictionary.ValueCollection<object, EventCheckId>.CopyTo
	|
	|-RVA: 0x29D33C0 Offset: 0x29D34C1 VA: 0x29D33C0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.CopyTo
	|
	|-RVA: 0x29D3EB0 Offset: 0x29D3FB1 VA: 0x29D3EB0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.CopyTo
	|
	|-RVA: 0x29D4920 Offset: 0x29D4A21 VA: 0x29D4920
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.CopyTo
	|
	|-RVA: 0x29D5310 Offset: 0x29D5411 VA: 0x29D5310
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.CopyTo
	|
	|-RVA: 0x29D5D10 Offset: 0x29D5E11 VA: 0x29D5D10
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.CopyTo
	|
	|-RVA: 0x29D67C0 Offset: 0x29D68C1 VA: 0x29D67C0
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.CopyTo
	|
	|-RVA: 0x2958340 Offset: 0x2958441 VA: 0x2958340
	|-Dictionary.ValueCollection<object, OrderSaveData>.CopyTo
	|
	|-RVA: 0x2958E00 Offset: 0x2958F01 VA: 0x2958E00
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.CopyTo
	|
	|-RVA: 0x29598A0 Offset: 0x29599A1 VA: 0x29598A0
	|-Dictionary.ValueCollection<object, Parameter>.CopyTo
	|
	|-RVA: 0x295A380 Offset: 0x295A481 VA: 0x295A380
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.CopyTo
	|
	|-RVA: 0x295AD70 Offset: 0x295AE71 VA: 0x295AD70
	|-Dictionary.ValueCollection<object, bool>.CopyTo
	|
	|-RVA: 0x295B750 Offset: 0x295B851 VA: 0x295B750
	|-Dictionary.ValueCollection<object, byte>.CopyTo
	|
	|-RVA: 0x295C130 Offset: 0x295C231 VA: 0x295C130
	|-Dictionary.ValueCollection<object, char>.CopyTo
	|
	|-RVA: 0x295CB10 Offset: 0x295CC11 VA: 0x295CB10
	|-Dictionary.ValueCollection<object, DateTime>.CopyTo
	|
	|-RVA: 0x295D4F0 Offset: 0x295D5F1 VA: 0x295D4F0
	|-Dictionary.ValueCollection<object, double>.CopyTo
	|
	|-RVA: 0x295DED0 Offset: 0x295DFD1 VA: 0x295DED0
	|-Dictionary.ValueCollection<object, short>.CopyTo
	|
	|-RVA: 0x295E8B0 Offset: 0x295E9B1 VA: 0x295E8B0
	|-Dictionary.ValueCollection<object, int>.CopyTo
	|
	|-RVA: 0x295F290 Offset: 0x295F391 VA: 0x295F290
	|-Dictionary.ValueCollection<object, Int32Enum>.CopyTo
	|
	|-RVA: 0x295FC70 Offset: 0x295FD71 VA: 0x295FC70
	|-Dictionary.ValueCollection<object, long>.CopyTo
	|
	|-RVA: 0x2960650 Offset: 0x2960751 VA: 0x2960650
	|-Dictionary.ValueCollection<object, Memory<object>>.CopyTo
	|
	|-RVA: 0x2961050 Offset: 0x2961151 VA: 0x2961050
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.CopyTo
	|
	|-RVA: 0x2961A40 Offset: 0x2961B41 VA: 0x2961A40
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.CopyTo
	|
	|-RVA: 0x29624F0 Offset: 0x29625F1 VA: 0x29624F0
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.CopyTo
	|
	|-RVA: 0x2962F90 Offset: 0x2963091 VA: 0x2962F90
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.CopyTo
	|
	|-RVA: 0x2963970 Offset: 0x2963A71 VA: 0x2963970
	|-Dictionary.ValueCollection<object, Nullable<Color>>.CopyTo
	|
	|-RVA: 0x29643E0 Offset: 0x29644E1 VA: 0x29643E0
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.CopyTo
	|
	|-RVA: 0x2964DD0 Offset: 0x2964ED1 VA: 0x2964DD0
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.CopyTo
	|
	|-RVA: 0x2965850 Offset: 0x2965951 VA: 0x2965850
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.CopyTo
	|
	|-RVA: 0x29662C0 Offset: 0x29663C1 VA: 0x29662C0
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.CopyTo
	|
	|-RVA: 0x2966CD0 Offset: 0x2966DD1 VA: 0x2966CD0
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.CopyTo
	|
	|-RVA: 0x2967800 Offset: 0x2967901 VA: 0x2967800
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.CopyTo
	|
	|-RVA: 0x2968270 Offset: 0x2968371 VA: 0x2968270
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.CopyTo
	|
	|-RVA: 0x2968C60 Offset: 0x2968D61 VA: 0x2968C60
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.CopyTo
	|
	|-RVA: 0x29696D0 Offset: 0x29697D1 VA: 0x29696D0
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.CopyTo
	|
	|-RVA: 0x296A140 Offset: 0x296A241 VA: 0x296A140
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.CopyTo
	|
	|-RVA: 0x296AB30 Offset: 0x296AC31 VA: 0x296AB30
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.CopyTo
	|
	|-RVA: 0x296B520 Offset: 0x296B621 VA: 0x296B520
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.CopyTo
	|
	|-RVA: 0x296BF10 Offset: 0x296C011 VA: 0x296BF10
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.CopyTo
	|
	|-RVA: 0x296C900 Offset: 0x296CA01 VA: 0x296C900
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.CopyTo
	|
	|-RVA: 0x296D370 Offset: 0x296D471 VA: 0x296D370
	|-Dictionary.ValueCollection<object, object>.CopyTo
	|
	|-RVA: 0x296DD20 Offset: 0x296DE21 VA: 0x296DD20
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.CopyTo
	|
	|-RVA: 0x296E720 Offset: 0x296E821 VA: 0x296E720
	|-Dictionary.ValueCollection<object, ResourceLocator>.CopyTo
	|
	|-RVA: 0x29EDBE0 Offset: 0x29EDCE1 VA: 0x29EDBE0
	|-Dictionary.ValueCollection<object, sbyte>.CopyTo
	|
	|-RVA: 0x29EE5C0 Offset: 0x29EE6C1 VA: 0x29EE5C0
	|-Dictionary.ValueCollection<object, float>.CopyTo
	|
	|-RVA: 0x29EEFA0 Offset: 0x29EF0A1 VA: 0x29EEFA0
	|-Dictionary.ValueCollection<object, ushort>.CopyTo
	|
	|-RVA: 0x29EF980 Offset: 0x29EFA81 VA: 0x29EF980
	|-Dictionary.ValueCollection<object, uint>.CopyTo
	|
	|-RVA: 0x29F0360 Offset: 0x29F0461 VA: 0x29F0360
	|-Dictionary.ValueCollection<object, ulong>.CopyTo
	|
	|-RVA: 0x29F0D50 Offset: 0x29F0E51 VA: 0x29F0D50
	|-Dictionary.ValueCollection<object, TransitionTables>.CopyTo
	|
	|-RVA: 0x29F17C0 Offset: 0x29F18C1 VA: 0x29F17C0
	|-Dictionary.ValueCollection<object, Bounds>.CopyTo
	|
	|-RVA: 0x29F2230 Offset: 0x29F2331 VA: 0x29F2230
	|-Dictionary.ValueCollection<object, BoundsInt>.CopyTo
	|
	|-RVA: 0x29F2CA0 Offset: 0x29F2DA1 VA: 0x29F2CA0
	|-Dictionary.ValueCollection<object, Color32>.CopyTo
	|
	|-RVA: 0x29F3680 Offset: 0x29F3781 VA: 0x29F3680
	|-Dictionary.ValueCollection<object, Color>.CopyTo
	|
	|-RVA: 0x29F4070 Offset: 0x29F4171 VA: 0x29F4070
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.CopyTo
	|
	|-RVA: 0x29F4A60 Offset: 0x29F4B61 VA: 0x29F4A60
	|-Dictionary.ValueCollection<object, GradientColorKey>.CopyTo
	|
	|-RVA: 0x29F54E0 Offset: 0x29F55E1 VA: 0x29F54E0
	|-Dictionary.ValueCollection<object, Keyframe>.CopyTo
	|
	|-RVA: 0x29F5F80 Offset: 0x29F6081 VA: 0x29F5F80
	|-Dictionary.ValueCollection<object, LayerMask>.CopyTo
	|
	|-RVA: 0x29F6980 Offset: 0x29F6A81 VA: 0x29F6980
	|-Dictionary.ValueCollection<object, Matrix4x4>.CopyTo
	|
	|-RVA: 0x29F7450 Offset: 0x29F7551 VA: 0x29F7450
	|-Dictionary.ValueCollection<object, Playable>.CopyTo
	|
	|-RVA: 0x29F7E40 Offset: 0x29F7F41 VA: 0x29F7E40
	|-Dictionary.ValueCollection<object, Quaternion>.CopyTo
	|
	|-RVA: 0x29F8830 Offset: 0x29F8931 VA: 0x29F8830
	|-Dictionary.ValueCollection<object, RangeInt>.CopyTo
	|
	|-RVA: 0x29F9210 Offset: 0x29F9311 VA: 0x29F9210
	|-Dictionary.ValueCollection<object, Rect>.CopyTo
	|
	|-RVA: 0x29F9C00 Offset: 0x29F9D01 VA: 0x29F9C00
	|-Dictionary.ValueCollection<object, RectInt>.CopyTo
	|
	|-RVA: 0x29FA5F0 Offset: 0x29FA6F1 VA: 0x29FA5F0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x29FB070 Offset: 0x29FB171 VA: 0x29FB070
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.CopyTo
	|
	|-RVA: 0x29FBAF0 Offset: 0x29FBBF1 VA: 0x29FBAF0
	|-Dictionary.ValueCollection<object, Vector2>.CopyTo
	|
	|-RVA: 0x29FC4E0 Offset: 0x29FC5E1 VA: 0x29FC4E0
	|-Dictionary.ValueCollection<object, Vector2Int>.CopyTo
	|
	|-RVA: 0x29FCEC0 Offset: 0x29FCFC1 VA: 0x29FCEC0
	|-Dictionary.ValueCollection<object, Vector3>.CopyTo
	|
	|-RVA: 0x29FD8B0 Offset: 0x29FD9B1 VA: 0x29FD8B0
	|-Dictionary.ValueCollection<object, Vector3Int>.CopyTo
	|
	|-RVA: 0x29FE2A0 Offset: 0x29FE3A1 VA: 0x29FE2A0
	|-Dictionary.ValueCollection<object, Vector4>.CopyTo
	|
	|-RVA: 0x29FEC90 Offset: 0x29FED91 VA: 0x29FEC90
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.CopyTo
	|
	|-RVA: 0x29FF640 Offset: 0x29FF741 VA: 0x29FF640
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.CopyTo
	|
	|-RVA: 0x2A00020 Offset: 0x2A00121 VA: 0x2A00020
	|-Dictionary.ValueCollection<sbyte, object>.CopyTo
	|
	|-RVA: 0x2A00A00 Offset: 0x2A00B01 VA: 0x2A00A00
	|-Dictionary.ValueCollection<float, CurveSample>.CopyTo
	|
	|-RVA: 0x2A01520 Offset: 0x2A01621 VA: 0x2A01520
	|-Dictionary.ValueCollection<float, object>.CopyTo
	|
	|-RVA: 0x2A01ED0 Offset: 0x2A01FD1 VA: 0x2A01ED0
	|-Dictionary.ValueCollection<ushort, object>.CopyTo
	|
	|-RVA: 0x2A02880 Offset: 0x2A02981 VA: 0x2A02880
	|-Dictionary.ValueCollection<uint, int>.CopyTo
	|
	|-RVA: 0x2A03260 Offset: 0x2A03361 VA: 0x2A03260
	|-Dictionary.ValueCollection<uint, Int32Enum>.CopyTo
	|
	|-RVA: 0x2A03C40 Offset: 0x2A03D41 VA: 0x2A03C40
	|-Dictionary.ValueCollection<uint, object>.CopyTo
	|
	|-RVA: 0x2A045F0 Offset: 0x2A046F1 VA: 0x2A045F0
	|-Dictionary.ValueCollection<ulong, object>.CopyTo
	|
	|-RVA: 0x2A04FA0 Offset: 0x2A050A1 VA: 0x2A04FA0
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.CopyTo
	|
	|-RVA: 0x2A05990 Offset: 0x2A05A91 VA: 0x2A05990
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.CopyTo
	|
	|-RVA: 0x2A06450 Offset: 0x2A06551 VA: 0x2A06450
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.CopyTo
	|
	|-RVA: 0x2A06F10 Offset: 0x2A07011 VA: 0x2A06F10
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.CopyTo
	|
	|-RVA: 0x2A07980 Offset: 0x2A07A81 VA: 0x2A07980
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.CopyTo
	|
	|-RVA: 0x2A08360 Offset: 0x2A08461 VA: 0x2A08360
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.CopyTo
	|
	|-RVA: 0x2A08D10 Offset: 0x2A08E11 VA: 0x2A08D10
	|-Dictionary.ValueCollection<Bounds, object>.CopyTo
	|
	|-RVA: 0x2A096C0 Offset: 0x2A097C1 VA: 0x2A096C0
	|-Dictionary.ValueCollection<BoundsInt, object>.CopyTo
	|
	|-RVA: 0x2A0A070 Offset: 0x2A0A171 VA: 0x2A0A070
	|-Dictionary.ValueCollection<Color, object>.CopyTo
	|
	|-RVA: 0x2A0AA20 Offset: 0x2A0AB21 VA: 0x2A0AA20
	|-Dictionary.ValueCollection<Color32, object>.CopyTo
	|
	|-RVA: 0x2A0B3D0 Offset: 0x2A0B4D1 VA: 0x2A0B3D0
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.CopyTo
	|
	|-RVA: 0x2A0BD80 Offset: 0x2A0BE81 VA: 0x2A0BD80
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.CopyTo
	|
	|-RVA: 0x2A0C730 Offset: 0x2A0C831 VA: 0x2A0C730
	|-Dictionary.ValueCollection<GradientColorKey, object>.CopyTo
	|
	|-RVA: 0x2A0D0E0 Offset: 0x2A0D1E1 VA: 0x2A0D0E0
	|-Dictionary.ValueCollection<Keyframe, object>.CopyTo
	|
	|-RVA: 0x2A0DA90 Offset: 0x2A0DB91 VA: 0x2A0DA90
	|-Dictionary.ValueCollection<LayerMask, object>.CopyTo
	|
	|-RVA: 0x2A0E440 Offset: 0x2A0E541 VA: 0x2A0E440
	|-Dictionary.ValueCollection<Matrix4x4, object>.CopyTo
	|
	|-RVA: 0x2A0EDF0 Offset: 0x2A0EEF1 VA: 0x2A0EDF0
	|-Dictionary.ValueCollection<IntVec3, object>.CopyTo
	|
	|-RVA: 0x2A0F7A0 Offset: 0x2A0F8A1 VA: 0x2A0F7A0
	|-Dictionary.ValueCollection<Quaternion, object>.CopyTo
	|
	|-RVA: 0x2A10150 Offset: 0x2A10251 VA: 0x2A10150
	|-Dictionary.ValueCollection<RangeInt, object>.CopyTo
	|
	|-RVA: 0x2A10B00 Offset: 0x2A10C01 VA: 0x2A10B00
	|-Dictionary.ValueCollection<Rect, object>.CopyTo
	|
	|-RVA: 0x2A114B0 Offset: 0x2A115B1 VA: 0x2A114B0
	|-Dictionary.ValueCollection<RectInt, object>.CopyTo
	|
	|-RVA: 0x2A11E60 Offset: 0x2A11F61 VA: 0x2A11E60
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.CopyTo
	|
	|-RVA: 0x2A12840 Offset: 0x2A12941 VA: 0x2A12840
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.CopyTo
	|
	|-RVA: 0x2A131F0 Offset: 0x2A132F1 VA: 0x2A131F0
	|-Dictionary.ValueCollection<Vector2, object>.CopyTo
	|
	|-RVA: 0x2A13BA0 Offset: 0x2A13CA1 VA: 0x2A13BA0
	|-Dictionary.ValueCollection<Vector2Int, object>.CopyTo
	|
	|-RVA: 0x2A14550 Offset: 0x2A14651 VA: 0x2A14550
	|-Dictionary.ValueCollection<Vector3, object>.CopyTo
	|
	|-RVA: 0x2A14F00 Offset: 0x2A15001 VA: 0x2A14F00
	|-Dictionary.ValueCollection<Vector3Int, object>.CopyTo
	|
	|-RVA: 0x2A158B0 Offset: 0x2A159B1 VA: 0x2A158B0
	|-Dictionary.ValueCollection<Vector4, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2341250 Offset: 0x2341351 VA: 0x2341250
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.get_Count
	|
	|-RVA: 0x2341C00 Offset: 0x2341D01 VA: 0x2341C00
	|-Dictionary.ValueCollection<BitVector32Int, object>.get_Count
	|
	|-RVA: 0x23425B0 Offset: 0x23426B1 VA: 0x23425B0
	|-Dictionary.ValueCollection<EventCheckId, object>.get_Count
	|
	|-RVA: 0x28FD5A0 Offset: 0x28FD6A1 VA: 0x28FD5A0
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.get_Count
	|
	|-RVA: 0x28FDF50 Offset: 0x28FE051 VA: 0x28FDF50
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.get_Count
	|
	|-RVA: 0x28FE900 Offset: 0x28FEA01 VA: 0x28FE900
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.get_Count
	|
	|-RVA: 0x28FF2B0 Offset: 0x28FF3B1 VA: 0x28FF2B0
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.get_Count
	|
	|-RVA: 0x28FFC60 Offset: 0x28FFD61 VA: 0x28FFC60
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.get_Count
	|
	|-RVA: 0x2900610 Offset: 0x2900711 VA: 0x2900610
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.get_Count
	|
	|-RVA: 0x2900FC0 Offset: 0x29010C1 VA: 0x2900FC0
	|-Dictionary.ValueCollection<OrderSaveData, object>.get_Count
	|
	|-RVA: 0x2901970 Offset: 0x2901A71 VA: 0x2901970
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.get_Count
	|
	|-RVA: 0x2902320 Offset: 0x2902421 VA: 0x2902320
	|-Dictionary.ValueCollection<Parameter, object>.get_Count
	|
	|-RVA: 0x2902CD0 Offset: 0x2902DD1 VA: 0x2902CD0
	|-Dictionary.ValueCollection<bool, object>.get_Count
	|
	|-RVA: 0x2903680 Offset: 0x2903781 VA: 0x2903680
	|-Dictionary.ValueCollection<byte, object>.get_Count
	|
	|-RVA: 0x2904030 Offset: 0x2904131 VA: 0x2904030
	|-Dictionary.ValueCollection<char, object>.get_Count
	|
	|-RVA: 0x29049E0 Offset: 0x2904AE1 VA: 0x29049E0
	|-Dictionary.ValueCollection<DateTime, object>.get_Count
	|
	|-RVA: 0x2905390 Offset: 0x2905491 VA: 0x2905390
	|-Dictionary.ValueCollection<double, object>.get_Count
	|
	|-RVA: 0x2905D40 Offset: 0x2905E41 VA: 0x2905D40
	|-Dictionary.ValueCollection<Guid, object>.get_Count
	|
	|-RVA: 0x29066F0 Offset: 0x29067F1 VA: 0x29066F0
	|-Dictionary.ValueCollection<short, object>.get_Count
	|
	|-RVA: 0x2907110 Offset: 0x2907211 VA: 0x2907110
	|-Dictionary.ValueCollection<int, CropDataTable>.get_Count
	|
	|-RVA: 0x2907C00 Offset: 0x2907D01 VA: 0x2907C00
	|-Dictionary.ValueCollection<int, EffectDataTable>.get_Count
	|
	|-RVA: 0x2908640 Offset: 0x2908741 VA: 0x2908640
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.get_Count
	|
	|-RVA: 0x2909090 Offset: 0x2909191 VA: 0x2909090
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.get_Count
	|
	|-RVA: 0x2909B30 Offset: 0x2909C31 VA: 0x2909B30
	|-Dictionary.ValueCollection<int, MiningDataTable>.get_Count
	|
	|-RVA: 0x290A510 Offset: 0x290A611 VA: 0x290A510
	|-Dictionary.ValueCollection<int, bool>.get_Count
	|
	|-RVA: 0x290AEF0 Offset: 0x290AFF1 VA: 0x290AEF0
	|-Dictionary.ValueCollection<int, char>.get_Count
	|
	|-RVA: 0x290B8D0 Offset: 0x290B9D1 VA: 0x290B8D0
	|-Dictionary.ValueCollection<int, int>.get_Count
	|
	|-RVA: 0x290C2B0 Offset: 0x290C3B1 VA: 0x290C2B0
	|-Dictionary.ValueCollection<int, Int32Enum>.get_Count
	|
	|-RVA: 0x290CC90 Offset: 0x290CD91 VA: 0x290CC90
	|-Dictionary.ValueCollection<int, long>.get_Count
	|
	|-RVA: 0x290D680 Offset: 0x290D781 VA: 0x290D680
	|-Dictionary.ValueCollection<int, object>.get_Count
	|
	|-RVA: 0x290E080 Offset: 0x290E181 VA: 0x290E080
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.get_Count
	|
	|-RVA: 0x290EB10 Offset: 0x290EC11 VA: 0x290EB10
	|-Dictionary.ValueCollection<int, SceneInstance>.get_Count
	|
	|-RVA: 0x290F4F0 Offset: 0x290F5F1 VA: 0x290F4F0
	|-Dictionary.ValueCollection<int, Vector2Int>.get_Count
	|
	|-RVA: 0x290FEE0 Offset: 0x290FFE1 VA: 0x290FEE0
	|-Dictionary.ValueCollection<int, Vector3>.get_Count
	|
	|-RVA: 0x2910940 Offset: 0x2910A41 VA: 0x2910940
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.get_Count
	|
	|-RVA: 0x2911440 Offset: 0x2911541 VA: 0x2911440
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.get_Count
	|
	|-RVA: 0x2911EC0 Offset: 0x2911FC1 VA: 0x2911EC0
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Count
	|
	|-RVA: 0x29128A0 Offset: 0x29129A1 VA: 0x29128A0
	|-Dictionary.ValueCollection<Int32Enum, bool>.get_Count
	|
	|-RVA: 0x2913280 Offset: 0x2913381 VA: 0x2913280
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Count
	|
	|-RVA: 0x29C1080 Offset: 0x29C1181 VA: 0x29C1080
	|-Dictionary.ValueCollection<Int32Enum, int>.get_Count
	|
	|-RVA: 0x29C1A60 Offset: 0x29C1B61 VA: 0x29C1A60
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.get_Count
	|
	|-RVA: 0x29C2450 Offset: 0x29C2551 VA: 0x29C2450
	|-Dictionary.ValueCollection<Int32Enum, object>.get_Count
	|
	|-RVA: 0x29C2DF0 Offset: 0x29C2EF1 VA: 0x29C2DF0
	|-Dictionary.ValueCollection<Int32Enum, float>.get_Count
	|
	|-RVA: 0x29C37F0 Offset: 0x29C38F1 VA: 0x29C37F0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.get_Count
	|
	|-RVA: 0x29C41E0 Offset: 0x29C42E1 VA: 0x29C41E0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.get_Count
	|
	|-RVA: 0x29C4BD0 Offset: 0x29C4CD1 VA: 0x29C4BD0
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.get_Count
	|
	|-RVA: 0x29C55C0 Offset: 0x29C56C1 VA: 0x29C55C0
	|-Dictionary.ValueCollection<long, object>.get_Count
	|
	|-RVA: 0x29C5F70 Offset: 0x29C6071 VA: 0x29C5F70
	|-Dictionary.ValueCollection<Memory<object>, object>.get_Count
	|
	|-RVA: 0x29C6920 Offset: 0x29C6A21 VA: 0x29C6920
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.get_Count
	|
	|-RVA: 0x29C72D0 Offset: 0x29C73D1 VA: 0x29C72D0
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.get_Count
	|
	|-RVA: 0x29C7C80 Offset: 0x29C7D81 VA: 0x29C7C80
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.get_Count
	|
	|-RVA: 0x29C8630 Offset: 0x29C8731 VA: 0x29C8630
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.get_Count
	|
	|-RVA: 0x29C8FE0 Offset: 0x29C90E1 VA: 0x29C8FE0
	|-Dictionary.ValueCollection<Nullable<Color>, object>.get_Count
	|
	|-RVA: 0x29C9990 Offset: 0x29C9A91 VA: 0x29C9990
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.get_Count
	|
	|-RVA: 0x29CA340 Offset: 0x29CA441 VA: 0x29CA340
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.get_Count
	|
	|-RVA: 0x29CACF0 Offset: 0x29CADF1 VA: 0x29CACF0
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.get_Count
	|
	|-RVA: 0x29CB6A0 Offset: 0x29CB7A1 VA: 0x29CB6A0
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.get_Count
	|
	|-RVA: 0x29CC050 Offset: 0x29CC151 VA: 0x29CC050
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.get_Count
	|
	|-RVA: 0x29CCA00 Offset: 0x29CCB01 VA: 0x29CCA00
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.get_Count
	|
	|-RVA: 0x29CD3B0 Offset: 0x29CD4B1 VA: 0x29CD3B0
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.get_Count
	|
	|-RVA: 0x29CDD60 Offset: 0x29CDE61 VA: 0x29CDD60
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.get_Count
	|
	|-RVA: 0x29CE710 Offset: 0x29CE811 VA: 0x29CE710
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.get_Count
	|
	|-RVA: 0x29CF0C0 Offset: 0x29CF1C1 VA: 0x29CF0C0
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.get_Count
	|
	|-RVA: 0x29CFA70 Offset: 0x29CFB71 VA: 0x29CFA70
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.get_Count
	|
	|-RVA: 0x29D0420 Offset: 0x29D0521 VA: 0x29D0420
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.get_Count
	|
	|-RVA: 0x29D0DD0 Offset: 0x29D0ED1 VA: 0x29D0DD0
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.get_Count
	|
	|-RVA: 0x29D1780 Offset: 0x29D1881 VA: 0x29D1780
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.get_Count
	|
	|-RVA: 0x29D2120 Offset: 0x29D2221 VA: 0x29D2120
	|-Dictionary.ValueCollection<object, BitVector32Int>.get_Count
	|
	|-RVA: 0x29D2B40 Offset: 0x29D2C41 VA: 0x29D2B40
	|-Dictionary.ValueCollection<object, EventCheckId>.get_Count
	|
	|-RVA: 0x29D3600 Offset: 0x29D3701 VA: 0x29D3600
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.get_Count
	|
	|-RVA: 0x29D40C0 Offset: 0x29D41C1 VA: 0x29D40C0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.get_Count
	|
	|-RVA: 0x29D4B10 Offset: 0x29D4C11 VA: 0x29D4B10
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.get_Count
	|
	|-RVA: 0x29D5500 Offset: 0x29D5601 VA: 0x29D5500
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.get_Count
	|
	|-RVA: 0x29D5F40 Offset: 0x29D6041 VA: 0x29D5F40
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.get_Count
	|
	|-RVA: 0x29D69B0 Offset: 0x29D6AB1 VA: 0x29D69B0
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.get_Count
	|
	|-RVA: 0x2958570 Offset: 0x2958671 VA: 0x2958570
	|-Dictionary.ValueCollection<object, OrderSaveData>.get_Count
	|
	|-RVA: 0x2959010 Offset: 0x2959111 VA: 0x2959010
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.get_Count
	|
	|-RVA: 0x2959AC0 Offset: 0x2959BC1 VA: 0x2959AC0
	|-Dictionary.ValueCollection<object, Parameter>.get_Count
	|
	|-RVA: 0x295A570 Offset: 0x295A671 VA: 0x295A570
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.get_Count
	|
	|-RVA: 0x295AF50 Offset: 0x295B051 VA: 0x295AF50
	|-Dictionary.ValueCollection<object, bool>.get_Count
	|
	|-RVA: 0x295B930 Offset: 0x295BA31 VA: 0x295B930
	|-Dictionary.ValueCollection<object, byte>.get_Count
	|
	|-RVA: 0x295C310 Offset: 0x295C411 VA: 0x295C310
	|-Dictionary.ValueCollection<object, char>.get_Count
	|
	|-RVA: 0x295CCF0 Offset: 0x295CDF1 VA: 0x295CCF0
	|-Dictionary.ValueCollection<object, DateTime>.get_Count
	|
	|-RVA: 0x295D6D0 Offset: 0x295D7D1 VA: 0x295D6D0
	|-Dictionary.ValueCollection<object, double>.get_Count
	|
	|-RVA: 0x295E0B0 Offset: 0x295E1B1 VA: 0x295E0B0
	|-Dictionary.ValueCollection<object, short>.get_Count
	|
	|-RVA: 0x295EA90 Offset: 0x295EB91 VA: 0x295EA90
	|-Dictionary.ValueCollection<object, int>.get_Count
	|
	|-RVA: 0x295F470 Offset: 0x295F571 VA: 0x295F470
	|-Dictionary.ValueCollection<object, Int32Enum>.get_Count
	|
	|-RVA: 0x295FE50 Offset: 0x295FF51 VA: 0x295FE50
	|-Dictionary.ValueCollection<object, long>.get_Count
	|
	|-RVA: 0x2960850 Offset: 0x2960951 VA: 0x2960850
	|-Dictionary.ValueCollection<object, Memory<object>>.get_Count
	|
	|-RVA: 0x2961230 Offset: 0x2961331 VA: 0x2961230
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.get_Count
	|
	|-RVA: 0x2961C60 Offset: 0x2961D61 VA: 0x2961C60
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.get_Count
	|
	|-RVA: 0x2962710 Offset: 0x2962811 VA: 0x2962710
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.get_Count
	|
	|-RVA: 0x2963170 Offset: 0x2963271 VA: 0x2963170
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.get_Count
	|
	|-RVA: 0x2963B80 Offset: 0x2963C81 VA: 0x2963B80
	|-Dictionary.ValueCollection<object, Nullable<Color>>.get_Count
	|
	|-RVA: 0x29645D0 Offset: 0x29646D1 VA: 0x29645D0
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.get_Count
	|
	|-RVA: 0x2964FE0 Offset: 0x29650E1 VA: 0x2964FE0
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.get_Count
	|
	|-RVA: 0x2965A60 Offset: 0x2965B61 VA: 0x2965A60
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.get_Count
	|
	|-RVA: 0x29664A0 Offset: 0x29665A1 VA: 0x29664A0
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.get_Count
	|
	|-RVA: 0x2966F20 Offset: 0x2967021 VA: 0x2966F20
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.get_Count
	|
	|-RVA: 0x2967A10 Offset: 0x2967B11 VA: 0x2967A10
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.get_Count
	|
	|-RVA: 0x2968460 Offset: 0x2968561 VA: 0x2968460
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.get_Count
	|
	|-RVA: 0x2968E70 Offset: 0x2968F71 VA: 0x2968E70
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.get_Count
	|
	|-RVA: 0x29698E0 Offset: 0x29699E1 VA: 0x29698E0
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.get_Count
	|
	|-RVA: 0x296A330 Offset: 0x296A431 VA: 0x296A330
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.get_Count
	|
	|-RVA: 0x296AD20 Offset: 0x296AE21 VA: 0x296AD20
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.get_Count
	|
	|-RVA: 0x296B710 Offset: 0x296B811 VA: 0x296B710
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.get_Count
	|
	|-RVA: 0x296C100 Offset: 0x296C201 VA: 0x296C100
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.get_Count
	|
	|-RVA: 0x296CB10 Offset: 0x296CC11 VA: 0x296CB10
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.get_Count
	|
	|-RVA: 0x296D560 Offset: 0x296D661 VA: 0x296D560
	|-Dictionary.ValueCollection<object, object>.get_Count
	|
	|-RVA: 0x296DF20 Offset: 0x296E021 VA: 0x296DF20
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.get_Count
	|
	|-RVA: 0x296E920 Offset: 0x296EA21 VA: 0x296E920
	|-Dictionary.ValueCollection<object, ResourceLocator>.get_Count
	|
	|-RVA: 0x29EDDC0 Offset: 0x29EDEC1 VA: 0x29EDDC0
	|-Dictionary.ValueCollection<object, sbyte>.get_Count
	|
	|-RVA: 0x29EE7A0 Offset: 0x29EE8A1 VA: 0x29EE7A0
	|-Dictionary.ValueCollection<object, float>.get_Count
	|
	|-RVA: 0x29EF180 Offset: 0x29EF281 VA: 0x29EF180
	|-Dictionary.ValueCollection<object, ushort>.get_Count
	|
	|-RVA: 0x29EFB60 Offset: 0x29EFC61 VA: 0x29EFB60
	|-Dictionary.ValueCollection<object, uint>.get_Count
	|
	|-RVA: 0x29F0540 Offset: 0x29F0641 VA: 0x29F0540
	|-Dictionary.ValueCollection<object, ulong>.get_Count
	|
	|-RVA: 0x29F0F60 Offset: 0x29F1061 VA: 0x29F0F60
	|-Dictionary.ValueCollection<object, TransitionTables>.get_Count
	|
	|-RVA: 0x29F19D0 Offset: 0x29F1AD1 VA: 0x29F19D0
	|-Dictionary.ValueCollection<object, Bounds>.get_Count
	|
	|-RVA: 0x29F2440 Offset: 0x29F2541 VA: 0x29F2440
	|-Dictionary.ValueCollection<object, BoundsInt>.get_Count
	|
	|-RVA: 0x29F2E80 Offset: 0x29F2F81 VA: 0x29F2E80
	|-Dictionary.ValueCollection<object, Color32>.get_Count
	|
	|-RVA: 0x29F3870 Offset: 0x29F3971 VA: 0x29F3870
	|-Dictionary.ValueCollection<object, Color>.get_Count
	|
	|-RVA: 0x29F4260 Offset: 0x29F4361 VA: 0x29F4260
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.get_Count
	|
	|-RVA: 0x29F4C70 Offset: 0x29F4D71 VA: 0x29F4C70
	|-Dictionary.ValueCollection<object, GradientColorKey>.get_Count
	|
	|-RVA: 0x29F5700 Offset: 0x29F5801 VA: 0x29F5700
	|-Dictionary.ValueCollection<object, Keyframe>.get_Count
	|
	|-RVA: 0x29F6160 Offset: 0x29F6261 VA: 0x29F6160
	|-Dictionary.ValueCollection<object, LayerMask>.get_Count
	|
	|-RVA: 0x29F6BB0 Offset: 0x29F6CB1 VA: 0x29F6BB0
	|-Dictionary.ValueCollection<object, Matrix4x4>.get_Count
	|
	|-RVA: 0x29F7640 Offset: 0x29F7741 VA: 0x29F7640
	|-Dictionary.ValueCollection<object, Playable>.get_Count
	|
	|-RVA: 0x29F8030 Offset: 0x29F8131 VA: 0x29F8030
	|-Dictionary.ValueCollection<object, Quaternion>.get_Count
	|
	|-RVA: 0x29F8A10 Offset: 0x29F8B11 VA: 0x29F8A10
	|-Dictionary.ValueCollection<object, RangeInt>.get_Count
	|
	|-RVA: 0x29F9400 Offset: 0x29F9501 VA: 0x29F9400
	|-Dictionary.ValueCollection<object, Rect>.get_Count
	|
	|-RVA: 0x29F9DF0 Offset: 0x29F9EF1 VA: 0x29F9DF0
	|-Dictionary.ValueCollection<object, RectInt>.get_Count
	|
	|-RVA: 0x29FA810 Offset: 0x29FA911 VA: 0x29FA810
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x29FB290 Offset: 0x29FB391 VA: 0x29FB290
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.get_Count
	|
	|-RVA: 0x29FBCE0 Offset: 0x29FBDE1 VA: 0x29FBCE0
	|-Dictionary.ValueCollection<object, Vector2>.get_Count
	|
	|-RVA: 0x29FC6C0 Offset: 0x29FC7C1 VA: 0x29FC6C0
	|-Dictionary.ValueCollection<object, Vector2Int>.get_Count
	|
	|-RVA: 0x29FD0B0 Offset: 0x29FD1B1 VA: 0x29FD0B0
	|-Dictionary.ValueCollection<object, Vector3>.get_Count
	|
	|-RVA: 0x29FDAA0 Offset: 0x29FDBA1 VA: 0x29FDAA0
	|-Dictionary.ValueCollection<object, Vector3Int>.get_Count
	|
	|-RVA: 0x29FE490 Offset: 0x29FE591 VA: 0x29FE490
	|-Dictionary.ValueCollection<object, Vector4>.get_Count
	|
	|-RVA: 0x29FEE80 Offset: 0x29FEF81 VA: 0x29FEE80
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.get_Count
	|
	|-RVA: 0x29FF820 Offset: 0x29FF921 VA: 0x29FF820
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Count
	|
	|-RVA: 0x2A00210 Offset: 0x2A00311 VA: 0x2A00210
	|-Dictionary.ValueCollection<sbyte, object>.get_Count
	|
	|-RVA: 0x2A00C40 Offset: 0x2A00D41 VA: 0x2A00C40
	|-Dictionary.ValueCollection<float, CurveSample>.get_Count
	|
	|-RVA: 0x2A01710 Offset: 0x2A01811 VA: 0x2A01710
	|-Dictionary.ValueCollection<float, object>.get_Count
	|
	|-RVA: 0x2A020C0 Offset: 0x2A021C1 VA: 0x2A020C0
	|-Dictionary.ValueCollection<ushort, object>.get_Count
	|
	|-RVA: 0x2A02A60 Offset: 0x2A02B61 VA: 0x2A02A60
	|-Dictionary.ValueCollection<uint, int>.get_Count
	|
	|-RVA: 0x2A03440 Offset: 0x2A03541 VA: 0x2A03440
	|-Dictionary.ValueCollection<uint, Int32Enum>.get_Count
	|
	|-RVA: 0x2A03E30 Offset: 0x2A03F31 VA: 0x2A03E30
	|-Dictionary.ValueCollection<uint, object>.get_Count
	|
	|-RVA: 0x2A047E0 Offset: 0x2A048E1 VA: 0x2A047E0
	|-Dictionary.ValueCollection<ulong, object>.get_Count
	|
	|-RVA: 0x2A05180 Offset: 0x2A05281 VA: 0x2A05180
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.get_Count
	|
	|-RVA: 0x2A05BC0 Offset: 0x2A05CC1 VA: 0x2A05BC0
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.get_Count
	|
	|-RVA: 0x2A06680 Offset: 0x2A06781 VA: 0x2A06680
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Count
	|
	|-RVA: 0x2A07120 Offset: 0x2A07221 VA: 0x2A07120
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.get_Count
	|
	|-RVA: 0x2A07B60 Offset: 0x2A07C61 VA: 0x2A07B60
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.get_Count
	|
	|-RVA: 0x2A08550 Offset: 0x2A08651 VA: 0x2A08550
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.get_Count
	|
	|-RVA: 0x2A08F00 Offset: 0x2A09001 VA: 0x2A08F00
	|-Dictionary.ValueCollection<Bounds, object>.get_Count
	|
	|-RVA: 0x2A098B0 Offset: 0x2A099B1 VA: 0x2A098B0
	|-Dictionary.ValueCollection<BoundsInt, object>.get_Count
	|
	|-RVA: 0x2A0A260 Offset: 0x2A0A361 VA: 0x2A0A260
	|-Dictionary.ValueCollection<Color, object>.get_Count
	|
	|-RVA: 0x2A0AC10 Offset: 0x2A0AD11 VA: 0x2A0AC10
	|-Dictionary.ValueCollection<Color32, object>.get_Count
	|
	|-RVA: 0x2A0B5C0 Offset: 0x2A0B6C1 VA: 0x2A0B5C0
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.get_Count
	|
	|-RVA: 0x2A0BF70 Offset: 0x2A0C071 VA: 0x2A0BF70
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.get_Count
	|
	|-RVA: 0x2A0C920 Offset: 0x2A0CA21 VA: 0x2A0C920
	|-Dictionary.ValueCollection<GradientColorKey, object>.get_Count
	|
	|-RVA: 0x2A0D2D0 Offset: 0x2A0D3D1 VA: 0x2A0D2D0
	|-Dictionary.ValueCollection<Keyframe, object>.get_Count
	|
	|-RVA: 0x2A0DC80 Offset: 0x2A0DD81 VA: 0x2A0DC80
	|-Dictionary.ValueCollection<LayerMask, object>.get_Count
	|
	|-RVA: 0x2A0E630 Offset: 0x2A0E731 VA: 0x2A0E630
	|-Dictionary.ValueCollection<Matrix4x4, object>.get_Count
	|
	|-RVA: 0x2A0EFE0 Offset: 0x2A0F0E1 VA: 0x2A0EFE0
	|-Dictionary.ValueCollection<IntVec3, object>.get_Count
	|
	|-RVA: 0x2A0F990 Offset: 0x2A0FA91 VA: 0x2A0F990
	|-Dictionary.ValueCollection<Quaternion, object>.get_Count
	|
	|-RVA: 0x2A10340 Offset: 0x2A10441 VA: 0x2A10340
	|-Dictionary.ValueCollection<RangeInt, object>.get_Count
	|
	|-RVA: 0x2A10CF0 Offset: 0x2A10DF1 VA: 0x2A10CF0
	|-Dictionary.ValueCollection<Rect, object>.get_Count
	|
	|-RVA: 0x2A116A0 Offset: 0x2A117A1 VA: 0x2A116A0
	|-Dictionary.ValueCollection<RectInt, object>.get_Count
	|
	|-RVA: 0x2A12040 Offset: 0x2A12141 VA: 0x2A12040
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.get_Count
	|
	|-RVA: 0x2A12A30 Offset: 0x2A12B31 VA: 0x2A12A30
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.get_Count
	|
	|-RVA: 0x2A133E0 Offset: 0x2A134E1 VA: 0x2A133E0
	|-Dictionary.ValueCollection<Vector2, object>.get_Count
	|
	|-RVA: 0x2A13D90 Offset: 0x2A13E91 VA: 0x2A13D90
	|-Dictionary.ValueCollection<Vector2Int, object>.get_Count
	|
	|-RVA: 0x2A14740 Offset: 0x2A14841 VA: 0x2A14740
	|-Dictionary.ValueCollection<Vector3, object>.get_Count
	|
	|-RVA: 0x2A150F0 Offset: 0x2A151F1 VA: 0x2A150F0
	|-Dictionary.ValueCollection<Vector3Int, object>.get_Count
	|
	|-RVA: 0x2A15AA0 Offset: 0x2A15BA1 VA: 0x2A15AA0
	|-Dictionary.ValueCollection<Vector4, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2341280 Offset: 0x2341381 VA: 0x2341280
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2341C30 Offset: 0x2341D31 VA: 0x2341C30
	|-Dictionary.ValueCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x23425E0 Offset: 0x23426E1 VA: 0x23425E0
	|-Dictionary.ValueCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x28FD5D0 Offset: 0x28FD6D1 VA: 0x28FD5D0
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x28FDF80 Offset: 0x28FE081 VA: 0x28FDF80
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x28FE930 Offset: 0x28FEA31 VA: 0x28FE930
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x28FF2E0 Offset: 0x28FF3E1 VA: 0x28FF2E0
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x28FFC90 Offset: 0x28FFD91 VA: 0x28FFC90
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2900640 Offset: 0x2900741 VA: 0x2900640
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2900FF0 Offset: 0x29010F1 VA: 0x2900FF0
	|-Dictionary.ValueCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29019A0 Offset: 0x2901AA1 VA: 0x29019A0
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2902350 Offset: 0x2902451 VA: 0x2902350
	|-Dictionary.ValueCollection<Parameter, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2902D00 Offset: 0x2902E01 VA: 0x2902D00
	|-Dictionary.ValueCollection<bool, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29036B0 Offset: 0x29037B1 VA: 0x29036B0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2904060 Offset: 0x2904161 VA: 0x2904060
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2904A10 Offset: 0x2904B11 VA: 0x2904A10
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29053C0 Offset: 0x29054C1 VA: 0x29053C0
	|-Dictionary.ValueCollection<double, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2905D70 Offset: 0x2905E71 VA: 0x2905D70
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2906720 Offset: 0x2906821 VA: 0x2906720
	|-Dictionary.ValueCollection<short, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2907140 Offset: 0x2907241 VA: 0x2907140
	|-Dictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2907C30 Offset: 0x2907D31 VA: 0x2907C30
	|-Dictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2908670 Offset: 0x2908771 VA: 0x2908670
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29090C0 Offset: 0x29091C1 VA: 0x29090C0
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2909B60 Offset: 0x2909C61 VA: 0x2909B60
	|-Dictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290A540 Offset: 0x290A641 VA: 0x290A540
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290AF20 Offset: 0x290B021 VA: 0x290AF20
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290B900 Offset: 0x290BA01 VA: 0x290B900
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290C2E0 Offset: 0x290C3E1 VA: 0x290C2E0
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290CCC0 Offset: 0x290CDC1 VA: 0x290CCC0
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290D6B0 Offset: 0x290D7B1 VA: 0x290D6B0
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290E0B0 Offset: 0x290E1B1 VA: 0x290E0B0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290EB40 Offset: 0x290EC41 VA: 0x290EB40
	|-Dictionary.ValueCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290F520 Offset: 0x290F621 VA: 0x290F520
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x290FF10 Offset: 0x2910011 VA: 0x290FF10
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2910970 Offset: 0x2910A71 VA: 0x2910970
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2911470 Offset: 0x2911571 VA: 0x2911470
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2911EF0 Offset: 0x2911FF1 VA: 0x2911EF0
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29128D0 Offset: 0x29129D1 VA: 0x29128D0
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29132B0 Offset: 0x29133B1 VA: 0x29132B0
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C10B0 Offset: 0x29C11B1 VA: 0x29C10B0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C1A90 Offset: 0x29C1B91 VA: 0x29C1A90
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C2480 Offset: 0x29C2581 VA: 0x29C2480
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C2E20 Offset: 0x29C2F21 VA: 0x29C2E20
	|-Dictionary.ValueCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C3820 Offset: 0x29C3921 VA: 0x29C3820
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C4210 Offset: 0x29C4311 VA: 0x29C4210
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C4C00 Offset: 0x29C4D01 VA: 0x29C4C00
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C55F0 Offset: 0x29C56F1 VA: 0x29C55F0
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C5FA0 Offset: 0x29C60A1 VA: 0x29C5FA0
	|-Dictionary.ValueCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C6950 Offset: 0x29C6A51 VA: 0x29C6950
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C7300 Offset: 0x29C7401 VA: 0x29C7300
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C7CB0 Offset: 0x29C7DB1 VA: 0x29C7CB0
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C8660 Offset: 0x29C8761 VA: 0x29C8660
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C9010 Offset: 0x29C9111 VA: 0x29C9010
	|-Dictionary.ValueCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29C99C0 Offset: 0x29C9AC1 VA: 0x29C99C0
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CA370 Offset: 0x29CA471 VA: 0x29CA370
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CAD20 Offset: 0x29CAE21 VA: 0x29CAD20
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CB6D0 Offset: 0x29CB7D1 VA: 0x29CB6D0
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CC080 Offset: 0x29CC181 VA: 0x29CC080
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CCA30 Offset: 0x29CCB31 VA: 0x29CCA30
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CD3E0 Offset: 0x29CD4E1 VA: 0x29CD3E0
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CDD90 Offset: 0x29CDE91 VA: 0x29CDD90
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CE740 Offset: 0x29CE841 VA: 0x29CE740
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CF0F0 Offset: 0x29CF1F1 VA: 0x29CF0F0
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29CFAA0 Offset: 0x29CFBA1 VA: 0x29CFAA0
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D0450 Offset: 0x29D0551 VA: 0x29D0450
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D0E00 Offset: 0x29D0F01 VA: 0x29D0E00
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D17B0 Offset: 0x29D18B1 VA: 0x29D17B0
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D2150 Offset: 0x29D2251 VA: 0x29D2150
	|-Dictionary.ValueCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D2B70 Offset: 0x29D2C71 VA: 0x29D2B70
	|-Dictionary.ValueCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D3630 Offset: 0x29D3731 VA: 0x29D3630
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D40F0 Offset: 0x29D41F1 VA: 0x29D40F0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D4B40 Offset: 0x29D4C41 VA: 0x29D4B40
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D5530 Offset: 0x29D5631 VA: 0x29D5530
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D5F70 Offset: 0x29D6071 VA: 0x29D5F70
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29D69E0 Offset: 0x29D6AE1 VA: 0x29D69E0
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29585A0 Offset: 0x29586A1 VA: 0x29585A0
	|-Dictionary.ValueCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2959040 Offset: 0x2959141 VA: 0x2959040
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2959AF0 Offset: 0x2959BF1 VA: 0x2959AF0
	|-Dictionary.ValueCollection<object, Parameter>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295A5A0 Offset: 0x295A6A1 VA: 0x295A5A0
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295AF80 Offset: 0x295B081 VA: 0x295AF80
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295B960 Offset: 0x295BA61 VA: 0x295B960
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295C340 Offset: 0x295C441 VA: 0x295C340
	|-Dictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295CD20 Offset: 0x295CE21 VA: 0x295CD20
	|-Dictionary.ValueCollection<object, DateTime>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295D700 Offset: 0x295D801 VA: 0x295D700
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295E0E0 Offset: 0x295E1E1 VA: 0x295E0E0
	|-Dictionary.ValueCollection<object, short>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295EAC0 Offset: 0x295EBC1 VA: 0x295EAC0
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295F4A0 Offset: 0x295F5A1 VA: 0x295F4A0
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x295FE80 Offset: 0x295FF81 VA: 0x295FE80
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2960880 Offset: 0x2960981 VA: 0x2960880
	|-Dictionary.ValueCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2961260 Offset: 0x2961361 VA: 0x2961260
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2961C90 Offset: 0x2961D91 VA: 0x2961C90
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2962740 Offset: 0x2962841 VA: 0x2962740
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29631A0 Offset: 0x29632A1 VA: 0x29631A0
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2963BB0 Offset: 0x2963CB1 VA: 0x2963BB0
	|-Dictionary.ValueCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2964600 Offset: 0x2964701 VA: 0x2964600
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2965010 Offset: 0x2965111 VA: 0x2965010
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2965A90 Offset: 0x2965B91 VA: 0x2965A90
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29664D0 Offset: 0x29665D1 VA: 0x29664D0
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2966F50 Offset: 0x2967051 VA: 0x2966F50
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2967A40 Offset: 0x2967B41 VA: 0x2967A40
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2968490 Offset: 0x2968591 VA: 0x2968490
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2968EA0 Offset: 0x2968FA1 VA: 0x2968EA0
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2969910 Offset: 0x2969A11 VA: 0x2969910
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x296A360 Offset: 0x296A461 VA: 0x296A360
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x296AD50 Offset: 0x296AE51 VA: 0x296AD50
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x296B740 Offset: 0x296B841 VA: 0x296B740
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x296C130 Offset: 0x296C231 VA: 0x296C130
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x296CB40 Offset: 0x296CC41 VA: 0x296CB40
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x296D590 Offset: 0x296D691 VA: 0x296D590
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x296DF50 Offset: 0x296E051 VA: 0x296DF50
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x296E950 Offset: 0x296EA51 VA: 0x296E950
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29EDDF0 Offset: 0x29EDEF1 VA: 0x29EDDF0
	|-Dictionary.ValueCollection<object, sbyte>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29EE7D0 Offset: 0x29EE8D1 VA: 0x29EE7D0
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29EF1B0 Offset: 0x29EF2B1 VA: 0x29EF1B0
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29EFB90 Offset: 0x29EFC91 VA: 0x29EFB90
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F0570 Offset: 0x29F0671 VA: 0x29F0570
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F0F90 Offset: 0x29F1091 VA: 0x29F0F90
	|-Dictionary.ValueCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F1A00 Offset: 0x29F1B01 VA: 0x29F1A00
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F2470 Offset: 0x29F2571 VA: 0x29F2470
	|-Dictionary.ValueCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F2EB0 Offset: 0x29F2FB1 VA: 0x29F2EB0
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F38A0 Offset: 0x29F39A1 VA: 0x29F38A0
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F4290 Offset: 0x29F4391 VA: 0x29F4290
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F4CA0 Offset: 0x29F4DA1 VA: 0x29F4CA0
	|-Dictionary.ValueCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F5730 Offset: 0x29F5831 VA: 0x29F5730
	|-Dictionary.ValueCollection<object, Keyframe>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F6190 Offset: 0x29F6291 VA: 0x29F6190
	|-Dictionary.ValueCollection<object, LayerMask>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F6BE0 Offset: 0x29F6CE1 VA: 0x29F6BE0
	|-Dictionary.ValueCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F7670 Offset: 0x29F7771 VA: 0x29F7670
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F8060 Offset: 0x29F8161 VA: 0x29F8060
	|-Dictionary.ValueCollection<object, Quaternion>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F8A40 Offset: 0x29F8B41 VA: 0x29F8A40
	|-Dictionary.ValueCollection<object, RangeInt>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F9430 Offset: 0x29F9531 VA: 0x29F9430
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29F9E20 Offset: 0x29F9F21 VA: 0x29F9E20
	|-Dictionary.ValueCollection<object, RectInt>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29FA840 Offset: 0x29FA941 VA: 0x29FA840
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29FB2C0 Offset: 0x29FB3C1 VA: 0x29FB2C0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29FBD10 Offset: 0x29FBE11 VA: 0x29FBD10
	|-Dictionary.ValueCollection<object, Vector2>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29FC6F0 Offset: 0x29FC7F1 VA: 0x29FC6F0
	|-Dictionary.ValueCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29FD0E0 Offset: 0x29FD1E1 VA: 0x29FD0E0
	|-Dictionary.ValueCollection<object, Vector3>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29FDAD0 Offset: 0x29FDBD1 VA: 0x29FDAD0
	|-Dictionary.ValueCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29FE4C0 Offset: 0x29FE5C1 VA: 0x29FE4C0
	|-Dictionary.ValueCollection<object, Vector4>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29FEEB0 Offset: 0x29FEFB1 VA: 0x29FEEB0
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x29FF850 Offset: 0x29FF951 VA: 0x29FF850
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A00240 Offset: 0x2A00341 VA: 0x2A00240
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A00C70 Offset: 0x2A00D71 VA: 0x2A00C70
	|-Dictionary.ValueCollection<float, CurveSample>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A01740 Offset: 0x2A01841 VA: 0x2A01740
	|-Dictionary.ValueCollection<float, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A020F0 Offset: 0x2A021F1 VA: 0x2A020F0
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A02A90 Offset: 0x2A02B91 VA: 0x2A02A90
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A03470 Offset: 0x2A03571 VA: 0x2A03470
	|-Dictionary.ValueCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A03E60 Offset: 0x2A03F61 VA: 0x2A03E60
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A04810 Offset: 0x2A04911 VA: 0x2A04810
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A051B0 Offset: 0x2A052B1 VA: 0x2A051B0
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A05BF0 Offset: 0x2A05CF1 VA: 0x2A05BF0
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A066B0 Offset: 0x2A067B1 VA: 0x2A066B0
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A07150 Offset: 0x2A07251 VA: 0x2A07150
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A07B90 Offset: 0x2A07C91 VA: 0x2A07B90
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A08580 Offset: 0x2A08681 VA: 0x2A08580
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A08F30 Offset: 0x2A09031 VA: 0x2A08F30
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A098E0 Offset: 0x2A099E1 VA: 0x2A098E0
	|-Dictionary.ValueCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0A290 Offset: 0x2A0A391 VA: 0x2A0A290
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0AC40 Offset: 0x2A0AD41 VA: 0x2A0AC40
	|-Dictionary.ValueCollection<Color32, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0B5F0 Offset: 0x2A0B6F1 VA: 0x2A0B5F0
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0BFA0 Offset: 0x2A0C0A1 VA: 0x2A0BFA0
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0C950 Offset: 0x2A0CA51 VA: 0x2A0C950
	|-Dictionary.ValueCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0D300 Offset: 0x2A0D401 VA: 0x2A0D300
	|-Dictionary.ValueCollection<Keyframe, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0DCB0 Offset: 0x2A0DDB1 VA: 0x2A0DCB0
	|-Dictionary.ValueCollection<LayerMask, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0E660 Offset: 0x2A0E761 VA: 0x2A0E660
	|-Dictionary.ValueCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0F010 Offset: 0x2A0F111 VA: 0x2A0F010
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A0F9C0 Offset: 0x2A0FAC1 VA: 0x2A0F9C0
	|-Dictionary.ValueCollection<Quaternion, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A10370 Offset: 0x2A10471 VA: 0x2A10370
	|-Dictionary.ValueCollection<RangeInt, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A10D20 Offset: 0x2A10E21 VA: 0x2A10D20
	|-Dictionary.ValueCollection<Rect, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A116D0 Offset: 0x2A117D1 VA: 0x2A116D0
	|-Dictionary.ValueCollection<RectInt, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A12070 Offset: 0x2A12171 VA: 0x2A12070
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A12A60 Offset: 0x2A12B61 VA: 0x2A12A60
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A13410 Offset: 0x2A13511 VA: 0x2A13410
	|-Dictionary.ValueCollection<Vector2, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A13DC0 Offset: 0x2A13EC1 VA: 0x2A13DC0
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A14770 Offset: 0x2A14871 VA: 0x2A14770
	|-Dictionary.ValueCollection<Vector3, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A15120 Offset: 0x2A15221 VA: 0x2A15120
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2A15AD0 Offset: 0x2A15BD1 VA: 0x2A15AD0
	|-Dictionary.ValueCollection<Vector4, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2341290 Offset: 0x2341391 VA: 0x2341290
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2341C40 Offset: 0x2341D41 VA: 0x2341C40
	|-Dictionary.ValueCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x23425F0 Offset: 0x23426F1 VA: 0x23425F0
	|-Dictionary.ValueCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x28FD5E0 Offset: 0x28FD6E1 VA: 0x28FD5E0
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x28FDF90 Offset: 0x28FE091 VA: 0x28FDF90
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x28FE940 Offset: 0x28FEA41 VA: 0x28FE940
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x28FF2F0 Offset: 0x28FF3F1 VA: 0x28FF2F0
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x28FFCA0 Offset: 0x28FFDA1 VA: 0x28FFCA0
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2900650 Offset: 0x2900751 VA: 0x2900650
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2901000 Offset: 0x2901101 VA: 0x2901000
	|-Dictionary.ValueCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29019B0 Offset: 0x2901AB1 VA: 0x29019B0
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2902360 Offset: 0x2902461 VA: 0x2902360
	|-Dictionary.ValueCollection<Parameter, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2902D10 Offset: 0x2902E11 VA: 0x2902D10
	|-Dictionary.ValueCollection<bool, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29036C0 Offset: 0x29037C1 VA: 0x29036C0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2904070 Offset: 0x2904171 VA: 0x2904070
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2904A20 Offset: 0x2904B21 VA: 0x2904A20
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29053D0 Offset: 0x29054D1 VA: 0x29053D0
	|-Dictionary.ValueCollection<double, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2905D80 Offset: 0x2905E81 VA: 0x2905D80
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2906730 Offset: 0x2906831 VA: 0x2906730
	|-Dictionary.ValueCollection<short, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2907150 Offset: 0x2907251 VA: 0x2907150
	|-Dictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2907C40 Offset: 0x2907D41 VA: 0x2907C40
	|-Dictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2908680 Offset: 0x2908781 VA: 0x2908680
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29090D0 Offset: 0x29091D1 VA: 0x29090D0
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2909B70 Offset: 0x2909C71 VA: 0x2909B70
	|-Dictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290A550 Offset: 0x290A651 VA: 0x290A550
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290AF30 Offset: 0x290B031 VA: 0x290AF30
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290B910 Offset: 0x290BA11 VA: 0x290B910
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290C2F0 Offset: 0x290C3F1 VA: 0x290C2F0
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290CCD0 Offset: 0x290CDD1 VA: 0x290CCD0
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290D6C0 Offset: 0x290D7C1 VA: 0x290D6C0
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290E0C0 Offset: 0x290E1C1 VA: 0x290E0C0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290EB50 Offset: 0x290EC51 VA: 0x290EB50
	|-Dictionary.ValueCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290F530 Offset: 0x290F631 VA: 0x290F530
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x290FF20 Offset: 0x2910021 VA: 0x290FF20
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2910980 Offset: 0x2910A81 VA: 0x2910980
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2911480 Offset: 0x2911581 VA: 0x2911480
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2911F00 Offset: 0x2912001 VA: 0x2911F00
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29128E0 Offset: 0x29129E1 VA: 0x29128E0
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29132C0 Offset: 0x29133C1 VA: 0x29132C0
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C10C0 Offset: 0x29C11C1 VA: 0x29C10C0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C1AA0 Offset: 0x29C1BA1 VA: 0x29C1AA0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C2490 Offset: 0x29C2591 VA: 0x29C2490
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C2E30 Offset: 0x29C2F31 VA: 0x29C2E30
	|-Dictionary.ValueCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C3830 Offset: 0x29C3931 VA: 0x29C3830
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C4220 Offset: 0x29C4321 VA: 0x29C4220
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C4C10 Offset: 0x29C4D11 VA: 0x29C4C10
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C5600 Offset: 0x29C5701 VA: 0x29C5600
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C5FB0 Offset: 0x29C60B1 VA: 0x29C5FB0
	|-Dictionary.ValueCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C6960 Offset: 0x29C6A61 VA: 0x29C6960
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C7310 Offset: 0x29C7411 VA: 0x29C7310
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C7CC0 Offset: 0x29C7DC1 VA: 0x29C7CC0
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C8670 Offset: 0x29C8771 VA: 0x29C8670
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C9020 Offset: 0x29C9121 VA: 0x29C9020
	|-Dictionary.ValueCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29C99D0 Offset: 0x29C9AD1 VA: 0x29C99D0
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CA380 Offset: 0x29CA481 VA: 0x29CA380
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CAD30 Offset: 0x29CAE31 VA: 0x29CAD30
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CB6E0 Offset: 0x29CB7E1 VA: 0x29CB6E0
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CC090 Offset: 0x29CC191 VA: 0x29CC090
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CCA40 Offset: 0x29CCB41 VA: 0x29CCA40
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CD3F0 Offset: 0x29CD4F1 VA: 0x29CD3F0
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CDDA0 Offset: 0x29CDEA1 VA: 0x29CDDA0
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CE750 Offset: 0x29CE851 VA: 0x29CE750
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CF100 Offset: 0x29CF201 VA: 0x29CF100
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29CFAB0 Offset: 0x29CFBB1 VA: 0x29CFAB0
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D0460 Offset: 0x29D0561 VA: 0x29D0460
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D0E10 Offset: 0x29D0F11 VA: 0x29D0E10
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D17C0 Offset: 0x29D18C1 VA: 0x29D17C0
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D2160 Offset: 0x29D2261 VA: 0x29D2160
	|-Dictionary.ValueCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D2B80 Offset: 0x29D2C81 VA: 0x29D2B80
	|-Dictionary.ValueCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D3640 Offset: 0x29D3741 VA: 0x29D3640
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D4100 Offset: 0x29D4201 VA: 0x29D4100
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D4B50 Offset: 0x29D4C51 VA: 0x29D4B50
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D5540 Offset: 0x29D5641 VA: 0x29D5540
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D5F80 Offset: 0x29D6081 VA: 0x29D5F80
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29D69F0 Offset: 0x29D6AF1 VA: 0x29D69F0
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29585B0 Offset: 0x29586B1 VA: 0x29585B0
	|-Dictionary.ValueCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2959050 Offset: 0x2959151 VA: 0x2959050
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2959B00 Offset: 0x2959C01 VA: 0x2959B00
	|-Dictionary.ValueCollection<object, Parameter>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295A5B0 Offset: 0x295A6B1 VA: 0x295A5B0
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295AF90 Offset: 0x295B091 VA: 0x295AF90
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295B970 Offset: 0x295BA71 VA: 0x295B970
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295C350 Offset: 0x295C451 VA: 0x295C350
	|-Dictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295CD30 Offset: 0x295CE31 VA: 0x295CD30
	|-Dictionary.ValueCollection<object, DateTime>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295D710 Offset: 0x295D811 VA: 0x295D710
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295E0F0 Offset: 0x295E1F1 VA: 0x295E0F0
	|-Dictionary.ValueCollection<object, short>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295EAD0 Offset: 0x295EBD1 VA: 0x295EAD0
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295F4B0 Offset: 0x295F5B1 VA: 0x295F4B0
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x295FE90 Offset: 0x295FF91 VA: 0x295FE90
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2960890 Offset: 0x2960991 VA: 0x2960890
	|-Dictionary.ValueCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2961270 Offset: 0x2961371 VA: 0x2961270
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2961CA0 Offset: 0x2961DA1 VA: 0x2961CA0
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2962750 Offset: 0x2962851 VA: 0x2962750
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29631B0 Offset: 0x29632B1 VA: 0x29631B0
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2963BC0 Offset: 0x2963CC1 VA: 0x2963BC0
	|-Dictionary.ValueCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2964610 Offset: 0x2964711 VA: 0x2964610
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2965020 Offset: 0x2965121 VA: 0x2965020
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2965AA0 Offset: 0x2965BA1 VA: 0x2965AA0
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29664E0 Offset: 0x29665E1 VA: 0x29664E0
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2966F60 Offset: 0x2967061 VA: 0x2966F60
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2967A50 Offset: 0x2967B51 VA: 0x2967A50
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29684A0 Offset: 0x29685A1 VA: 0x29684A0
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2968EB0 Offset: 0x2968FB1 VA: 0x2968EB0
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2969920 Offset: 0x2969A21 VA: 0x2969920
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x296A370 Offset: 0x296A471 VA: 0x296A370
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x296AD60 Offset: 0x296AE61 VA: 0x296AD60
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x296B750 Offset: 0x296B851 VA: 0x296B750
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x296C140 Offset: 0x296C241 VA: 0x296C140
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x296CB50 Offset: 0x296CC51 VA: 0x296CB50
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x296D5A0 Offset: 0x296D6A1 VA: 0x296D5A0
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x296DF60 Offset: 0x296E061 VA: 0x296DF60
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x296E960 Offset: 0x296EA61 VA: 0x296E960
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29EDE00 Offset: 0x29EDF01 VA: 0x29EDE00
	|-Dictionary.ValueCollection<object, sbyte>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29EE7E0 Offset: 0x29EE8E1 VA: 0x29EE7E0
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29EF1C0 Offset: 0x29EF2C1 VA: 0x29EF1C0
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29EFBA0 Offset: 0x29EFCA1 VA: 0x29EFBA0
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F0580 Offset: 0x29F0681 VA: 0x29F0580
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F0FA0 Offset: 0x29F10A1 VA: 0x29F0FA0
	|-Dictionary.ValueCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F1A10 Offset: 0x29F1B11 VA: 0x29F1A10
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F2480 Offset: 0x29F2581 VA: 0x29F2480
	|-Dictionary.ValueCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F2EC0 Offset: 0x29F2FC1 VA: 0x29F2EC0
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F38B0 Offset: 0x29F39B1 VA: 0x29F38B0
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F42A0 Offset: 0x29F43A1 VA: 0x29F42A0
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F4CB0 Offset: 0x29F4DB1 VA: 0x29F4CB0
	|-Dictionary.ValueCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F5740 Offset: 0x29F5841 VA: 0x29F5740
	|-Dictionary.ValueCollection<object, Keyframe>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F61A0 Offset: 0x29F62A1 VA: 0x29F61A0
	|-Dictionary.ValueCollection<object, LayerMask>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F6BF0 Offset: 0x29F6CF1 VA: 0x29F6BF0
	|-Dictionary.ValueCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F7680 Offset: 0x29F7781 VA: 0x29F7680
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F8070 Offset: 0x29F8171 VA: 0x29F8070
	|-Dictionary.ValueCollection<object, Quaternion>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F8A50 Offset: 0x29F8B51 VA: 0x29F8A50
	|-Dictionary.ValueCollection<object, RangeInt>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F9440 Offset: 0x29F9541 VA: 0x29F9440
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29F9E30 Offset: 0x29F9F31 VA: 0x29F9E30
	|-Dictionary.ValueCollection<object, RectInt>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29FA850 Offset: 0x29FA951 VA: 0x29FA850
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29FB2D0 Offset: 0x29FB3D1 VA: 0x29FB2D0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29FBD20 Offset: 0x29FBE21 VA: 0x29FBD20
	|-Dictionary.ValueCollection<object, Vector2>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29FC700 Offset: 0x29FC801 VA: 0x29FC700
	|-Dictionary.ValueCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29FD0F0 Offset: 0x29FD1F1 VA: 0x29FD0F0
	|-Dictionary.ValueCollection<object, Vector3>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29FDAE0 Offset: 0x29FDBE1 VA: 0x29FDAE0
	|-Dictionary.ValueCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29FE4D0 Offset: 0x29FE5D1 VA: 0x29FE4D0
	|-Dictionary.ValueCollection<object, Vector4>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29FEEC0 Offset: 0x29FEFC1 VA: 0x29FEEC0
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x29FF860 Offset: 0x29FF961 VA: 0x29FF860
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A00250 Offset: 0x2A00351 VA: 0x2A00250
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A00C80 Offset: 0x2A00D81 VA: 0x2A00C80
	|-Dictionary.ValueCollection<float, CurveSample>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A01750 Offset: 0x2A01851 VA: 0x2A01750
	|-Dictionary.ValueCollection<float, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A02100 Offset: 0x2A02201 VA: 0x2A02100
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A02AA0 Offset: 0x2A02BA1 VA: 0x2A02AA0
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A03480 Offset: 0x2A03581 VA: 0x2A03480
	|-Dictionary.ValueCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A03E70 Offset: 0x2A03F71 VA: 0x2A03E70
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A04820 Offset: 0x2A04921 VA: 0x2A04820
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A051C0 Offset: 0x2A052C1 VA: 0x2A051C0
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A05C00 Offset: 0x2A05D01 VA: 0x2A05C00
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A066C0 Offset: 0x2A067C1 VA: 0x2A066C0
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A07160 Offset: 0x2A07261 VA: 0x2A07160
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A07BA0 Offset: 0x2A07CA1 VA: 0x2A07BA0
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A08590 Offset: 0x2A08691 VA: 0x2A08590
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A08F40 Offset: 0x2A09041 VA: 0x2A08F40
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A098F0 Offset: 0x2A099F1 VA: 0x2A098F0
	|-Dictionary.ValueCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0A2A0 Offset: 0x2A0A3A1 VA: 0x2A0A2A0
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0AC50 Offset: 0x2A0AD51 VA: 0x2A0AC50
	|-Dictionary.ValueCollection<Color32, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0B600 Offset: 0x2A0B701 VA: 0x2A0B600
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0BFB0 Offset: 0x2A0C0B1 VA: 0x2A0BFB0
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0C960 Offset: 0x2A0CA61 VA: 0x2A0C960
	|-Dictionary.ValueCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0D310 Offset: 0x2A0D411 VA: 0x2A0D310
	|-Dictionary.ValueCollection<Keyframe, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0DCC0 Offset: 0x2A0DDC1 VA: 0x2A0DCC0
	|-Dictionary.ValueCollection<LayerMask, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0E670 Offset: 0x2A0E771 VA: 0x2A0E670
	|-Dictionary.ValueCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0F020 Offset: 0x2A0F121 VA: 0x2A0F020
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A0F9D0 Offset: 0x2A0FAD1 VA: 0x2A0F9D0
	|-Dictionary.ValueCollection<Quaternion, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A10380 Offset: 0x2A10481 VA: 0x2A10380
	|-Dictionary.ValueCollection<RangeInt, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A10D30 Offset: 0x2A10E31 VA: 0x2A10D30
	|-Dictionary.ValueCollection<Rect, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A116E0 Offset: 0x2A117E1 VA: 0x2A116E0
	|-Dictionary.ValueCollection<RectInt, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A12080 Offset: 0x2A12181 VA: 0x2A12080
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A12A70 Offset: 0x2A12B71 VA: 0x2A12A70
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A13420 Offset: 0x2A13521 VA: 0x2A13420
	|-Dictionary.ValueCollection<Vector2, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A13DD0 Offset: 0x2A13ED1 VA: 0x2A13DD0
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A14780 Offset: 0x2A14881 VA: 0x2A14780
	|-Dictionary.ValueCollection<Vector3, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A15130 Offset: 0x2A15231 VA: 0x2A15130
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2A15AE0 Offset: 0x2A15BE1 VA: 0x2A15AE0
	|-Dictionary.ValueCollection<Vector4, object>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2341300 Offset: 0x2341401 VA: 0x2341300
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2341CB0 Offset: 0x2341DB1 VA: 0x2341CB0
	|-Dictionary.ValueCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2342660 Offset: 0x2342761 VA: 0x2342660
	|-Dictionary.ValueCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x28FD650 Offset: 0x28FD751 VA: 0x28FD650
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x28FE000 Offset: 0x28FE101 VA: 0x28FE000
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x28FE9B0 Offset: 0x28FEAB1 VA: 0x28FE9B0
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x28FF360 Offset: 0x28FF461 VA: 0x28FF360
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x28FFD10 Offset: 0x28FFE11 VA: 0x28FFD10
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29006C0 Offset: 0x29007C1 VA: 0x29006C0
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2901070 Offset: 0x2901171 VA: 0x2901070
	|-Dictionary.ValueCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2901A20 Offset: 0x2901B21 VA: 0x2901A20
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29023D0 Offset: 0x29024D1 VA: 0x29023D0
	|-Dictionary.ValueCollection<Parameter, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2902D80 Offset: 0x2902E81 VA: 0x2902D80
	|-Dictionary.ValueCollection<bool, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2903730 Offset: 0x2903831 VA: 0x2903730
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29040E0 Offset: 0x29041E1 VA: 0x29040E0
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2904A90 Offset: 0x2904B91 VA: 0x2904A90
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2905440 Offset: 0x2905541 VA: 0x2905440
	|-Dictionary.ValueCollection<double, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2905DF0 Offset: 0x2905EF1 VA: 0x2905DF0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29067A0 Offset: 0x29068A1 VA: 0x29067A0
	|-Dictionary.ValueCollection<short, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29071C0 Offset: 0x29072C1 VA: 0x29071C0
	|-Dictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2907CB0 Offset: 0x2907DB1 VA: 0x2907CB0
	|-Dictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29086F0 Offset: 0x29087F1 VA: 0x29086F0
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2909140 Offset: 0x2909241 VA: 0x2909140
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2909BE0 Offset: 0x2909CE1 VA: 0x2909BE0
	|-Dictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290A5C0 Offset: 0x290A6C1 VA: 0x290A5C0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290AFA0 Offset: 0x290B0A1 VA: 0x290AFA0
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290B980 Offset: 0x290BA81 VA: 0x290B980
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290C360 Offset: 0x290C461 VA: 0x290C360
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290CD40 Offset: 0x290CE41 VA: 0x290CD40
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290D730 Offset: 0x290D831 VA: 0x290D730
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290E130 Offset: 0x290E231 VA: 0x290E130
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290EBC0 Offset: 0x290ECC1 VA: 0x290EBC0
	|-Dictionary.ValueCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290F5A0 Offset: 0x290F6A1 VA: 0x290F5A0
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x290FF90 Offset: 0x2910091 VA: 0x290FF90
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29109F0 Offset: 0x2910AF1 VA: 0x29109F0
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29114F0 Offset: 0x29115F1 VA: 0x29114F0
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2911F70 Offset: 0x2912071 VA: 0x2911F70
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2912950 Offset: 0x2912A51 VA: 0x2912950
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2913330 Offset: 0x2913431 VA: 0x2913330
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C1130 Offset: 0x29C1231 VA: 0x29C1130
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C1B10 Offset: 0x29C1C11 VA: 0x29C1B10
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C2500 Offset: 0x29C2601 VA: 0x29C2500
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C2EA0 Offset: 0x29C2FA1 VA: 0x29C2EA0
	|-Dictionary.ValueCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C38A0 Offset: 0x29C39A1 VA: 0x29C38A0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C4290 Offset: 0x29C4391 VA: 0x29C4290
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C4C80 Offset: 0x29C4D81 VA: 0x29C4C80
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C5670 Offset: 0x29C5771 VA: 0x29C5670
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C6020 Offset: 0x29C6121 VA: 0x29C6020
	|-Dictionary.ValueCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C69D0 Offset: 0x29C6AD1 VA: 0x29C69D0
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C7380 Offset: 0x29C7481 VA: 0x29C7380
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C7D30 Offset: 0x29C7E31 VA: 0x29C7D30
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C86E0 Offset: 0x29C87E1 VA: 0x29C86E0
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C9090 Offset: 0x29C9191 VA: 0x29C9090
	|-Dictionary.ValueCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29C9A40 Offset: 0x29C9B41 VA: 0x29C9A40
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CA3F0 Offset: 0x29CA4F1 VA: 0x29CA3F0
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CADA0 Offset: 0x29CAEA1 VA: 0x29CADA0
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CB750 Offset: 0x29CB851 VA: 0x29CB750
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CC100 Offset: 0x29CC201 VA: 0x29CC100
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CCAB0 Offset: 0x29CCBB1 VA: 0x29CCAB0
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CD460 Offset: 0x29CD561 VA: 0x29CD460
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CDE10 Offset: 0x29CDF11 VA: 0x29CDE10
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CE7C0 Offset: 0x29CE8C1 VA: 0x29CE7C0
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CF170 Offset: 0x29CF271 VA: 0x29CF170
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29CFB20 Offset: 0x29CFC21 VA: 0x29CFB20
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D04D0 Offset: 0x29D05D1 VA: 0x29D04D0
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D0E80 Offset: 0x29D0F81 VA: 0x29D0E80
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D1830 Offset: 0x29D1931 VA: 0x29D1830
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D21D0 Offset: 0x29D22D1 VA: 0x29D21D0
	|-Dictionary.ValueCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D2BF0 Offset: 0x29D2CF1 VA: 0x29D2BF0
	|-Dictionary.ValueCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D36B0 Offset: 0x29D37B1 VA: 0x29D36B0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D4170 Offset: 0x29D4271 VA: 0x29D4170
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D4BC0 Offset: 0x29D4CC1 VA: 0x29D4BC0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D55B0 Offset: 0x29D56B1 VA: 0x29D55B0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D5FF0 Offset: 0x29D60F1 VA: 0x29D5FF0
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29D6A60 Offset: 0x29D6B61 VA: 0x29D6A60
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2958620 Offset: 0x2958721 VA: 0x2958620
	|-Dictionary.ValueCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29590C0 Offset: 0x29591C1 VA: 0x29590C0
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2959B70 Offset: 0x2959C71 VA: 0x2959B70
	|-Dictionary.ValueCollection<object, Parameter>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295A620 Offset: 0x295A721 VA: 0x295A620
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295B000 Offset: 0x295B101 VA: 0x295B000
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295B9E0 Offset: 0x295BAE1 VA: 0x295B9E0
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295C3C0 Offset: 0x295C4C1 VA: 0x295C3C0
	|-Dictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295CDA0 Offset: 0x295CEA1 VA: 0x295CDA0
	|-Dictionary.ValueCollection<object, DateTime>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295D780 Offset: 0x295D881 VA: 0x295D780
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295E160 Offset: 0x295E261 VA: 0x295E160
	|-Dictionary.ValueCollection<object, short>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295EB40 Offset: 0x295EC41 VA: 0x295EB40
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295F520 Offset: 0x295F621 VA: 0x295F520
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x295FF00 Offset: 0x2960001 VA: 0x295FF00
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2960900 Offset: 0x2960A01 VA: 0x2960900
	|-Dictionary.ValueCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29612E0 Offset: 0x29613E1 VA: 0x29612E0
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2961D10 Offset: 0x2961E11 VA: 0x2961D10
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29627C0 Offset: 0x29628C1 VA: 0x29627C0
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2963220 Offset: 0x2963321 VA: 0x2963220
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2963C30 Offset: 0x2963D31 VA: 0x2963C30
	|-Dictionary.ValueCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2964680 Offset: 0x2964781 VA: 0x2964680
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2965090 Offset: 0x2965191 VA: 0x2965090
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2965B10 Offset: 0x2965C11 VA: 0x2965B10
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2966550 Offset: 0x2966651 VA: 0x2966550
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2966FD0 Offset: 0x29670D1 VA: 0x2966FD0
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2967AC0 Offset: 0x2967BC1 VA: 0x2967AC0
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2968510 Offset: 0x2968611 VA: 0x2968510
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2968F20 Offset: 0x2969021 VA: 0x2968F20
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2969990 Offset: 0x2969A91 VA: 0x2969990
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x296A3E0 Offset: 0x296A4E1 VA: 0x296A3E0
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x296ADD0 Offset: 0x296AED1 VA: 0x296ADD0
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x296B7C0 Offset: 0x296B8C1 VA: 0x296B7C0
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x296C1B0 Offset: 0x296C2B1 VA: 0x296C1B0
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x296CBC0 Offset: 0x296CCC1 VA: 0x296CBC0
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x296D610 Offset: 0x296D711 VA: 0x296D610
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x296DFD0 Offset: 0x296E0D1 VA: 0x296DFD0
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x296E9D0 Offset: 0x296EAD1 VA: 0x296E9D0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29EDE70 Offset: 0x29EDF71 VA: 0x29EDE70
	|-Dictionary.ValueCollection<object, sbyte>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29EE850 Offset: 0x29EE951 VA: 0x29EE850
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29EF230 Offset: 0x29EF331 VA: 0x29EF230
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29EFC10 Offset: 0x29EFD11 VA: 0x29EFC10
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F05F0 Offset: 0x29F06F1 VA: 0x29F05F0
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F1010 Offset: 0x29F1111 VA: 0x29F1010
	|-Dictionary.ValueCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F1A80 Offset: 0x29F1B81 VA: 0x29F1A80
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F24F0 Offset: 0x29F25F1 VA: 0x29F24F0
	|-Dictionary.ValueCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F2F30 Offset: 0x29F3031 VA: 0x29F2F30
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F3920 Offset: 0x29F3A21 VA: 0x29F3920
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F4310 Offset: 0x29F4411 VA: 0x29F4310
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F4D20 Offset: 0x29F4E21 VA: 0x29F4D20
	|-Dictionary.ValueCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F57B0 Offset: 0x29F58B1 VA: 0x29F57B0
	|-Dictionary.ValueCollection<object, Keyframe>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F6210 Offset: 0x29F6311 VA: 0x29F6210
	|-Dictionary.ValueCollection<object, LayerMask>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F6C60 Offset: 0x29F6D61 VA: 0x29F6C60
	|-Dictionary.ValueCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F76F0 Offset: 0x29F77F1 VA: 0x29F76F0
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F80E0 Offset: 0x29F81E1 VA: 0x29F80E0
	|-Dictionary.ValueCollection<object, Quaternion>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F8AC0 Offset: 0x29F8BC1 VA: 0x29F8AC0
	|-Dictionary.ValueCollection<object, RangeInt>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F94B0 Offset: 0x29F95B1 VA: 0x29F94B0
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29F9EA0 Offset: 0x29F9FA1 VA: 0x29F9EA0
	|-Dictionary.ValueCollection<object, RectInt>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29FA8C0 Offset: 0x29FA9C1 VA: 0x29FA8C0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29FB340 Offset: 0x29FB441 VA: 0x29FB340
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29FBD90 Offset: 0x29FBE91 VA: 0x29FBD90
	|-Dictionary.ValueCollection<object, Vector2>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29FC770 Offset: 0x29FC871 VA: 0x29FC770
	|-Dictionary.ValueCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29FD160 Offset: 0x29FD261 VA: 0x29FD160
	|-Dictionary.ValueCollection<object, Vector3>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29FDB50 Offset: 0x29FDC51 VA: 0x29FDB50
	|-Dictionary.ValueCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29FE540 Offset: 0x29FE641 VA: 0x29FE540
	|-Dictionary.ValueCollection<object, Vector4>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29FEF30 Offset: 0x29FF031 VA: 0x29FEF30
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x29FF8D0 Offset: 0x29FF9D1 VA: 0x29FF8D0
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A002C0 Offset: 0x2A003C1 VA: 0x2A002C0
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A00CF0 Offset: 0x2A00DF1 VA: 0x2A00CF0
	|-Dictionary.ValueCollection<float, CurveSample>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A017C0 Offset: 0x2A018C1 VA: 0x2A017C0
	|-Dictionary.ValueCollection<float, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A02170 Offset: 0x2A02271 VA: 0x2A02170
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A02B10 Offset: 0x2A02C11 VA: 0x2A02B10
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A034F0 Offset: 0x2A035F1 VA: 0x2A034F0
	|-Dictionary.ValueCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A03EE0 Offset: 0x2A03FE1 VA: 0x2A03EE0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A04890 Offset: 0x2A04991 VA: 0x2A04890
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A05230 Offset: 0x2A05331 VA: 0x2A05230
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A05C70 Offset: 0x2A05D71 VA: 0x2A05C70
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A06730 Offset: 0x2A06831 VA: 0x2A06730
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A071D0 Offset: 0x2A072D1 VA: 0x2A071D0
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A07C10 Offset: 0x2A07D11 VA: 0x2A07C10
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A08600 Offset: 0x2A08701 VA: 0x2A08600
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A08FB0 Offset: 0x2A090B1 VA: 0x2A08FB0
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A09960 Offset: 0x2A09A61 VA: 0x2A09960
	|-Dictionary.ValueCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0A310 Offset: 0x2A0A411 VA: 0x2A0A310
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0ACC0 Offset: 0x2A0ADC1 VA: 0x2A0ACC0
	|-Dictionary.ValueCollection<Color32, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0B670 Offset: 0x2A0B771 VA: 0x2A0B670
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0C020 Offset: 0x2A0C121 VA: 0x2A0C020
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0C9D0 Offset: 0x2A0CAD1 VA: 0x2A0C9D0
	|-Dictionary.ValueCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0D380 Offset: 0x2A0D481 VA: 0x2A0D380
	|-Dictionary.ValueCollection<Keyframe, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0DD30 Offset: 0x2A0DE31 VA: 0x2A0DD30
	|-Dictionary.ValueCollection<LayerMask, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0E6E0 Offset: 0x2A0E7E1 VA: 0x2A0E6E0
	|-Dictionary.ValueCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0F090 Offset: 0x2A0F191 VA: 0x2A0F090
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A0FA40 Offset: 0x2A0FB41 VA: 0x2A0FA40
	|-Dictionary.ValueCollection<Quaternion, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A103F0 Offset: 0x2A104F1 VA: 0x2A103F0
	|-Dictionary.ValueCollection<RangeInt, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A10DA0 Offset: 0x2A10EA1 VA: 0x2A10DA0
	|-Dictionary.ValueCollection<Rect, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A11750 Offset: 0x2A11851 VA: 0x2A11750
	|-Dictionary.ValueCollection<RectInt, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A120F0 Offset: 0x2A121F1 VA: 0x2A120F0
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A12AE0 Offset: 0x2A12BE1 VA: 0x2A12AE0
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A13490 Offset: 0x2A13591 VA: 0x2A13490
	|-Dictionary.ValueCollection<Vector2, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A13E40 Offset: 0x2A13F41 VA: 0x2A13E40
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A147F0 Offset: 0x2A148F1 VA: 0x2A147F0
	|-Dictionary.ValueCollection<Vector3, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A151A0 Offset: 0x2A152A1 VA: 0x2A151A0
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2A15B50 Offset: 0x2A15C51 VA: 0x2A15B50
	|-Dictionary.ValueCollection<Vector4, object>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2341370 Offset: 0x2341471 VA: 0x2341370
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2341D20 Offset: 0x2341E21 VA: 0x2341D20
	|-Dictionary.ValueCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x23426D0 Offset: 0x23427D1 VA: 0x23426D0
	|-Dictionary.ValueCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x28FD6C0 Offset: 0x28FD7C1 VA: 0x28FD6C0
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x28FE070 Offset: 0x28FE171 VA: 0x28FE070
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x28FEA20 Offset: 0x28FEB21 VA: 0x28FEA20
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x28FF3D0 Offset: 0x28FF4D1 VA: 0x28FF3D0
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x28FFD80 Offset: 0x28FFE81 VA: 0x28FFD80
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2900730 Offset: 0x2900831 VA: 0x2900730
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29010E0 Offset: 0x29011E1 VA: 0x29010E0
	|-Dictionary.ValueCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2901A90 Offset: 0x2901B91 VA: 0x2901A90
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2902440 Offset: 0x2902541 VA: 0x2902440
	|-Dictionary.ValueCollection<Parameter, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2902DF0 Offset: 0x2902EF1 VA: 0x2902DF0
	|-Dictionary.ValueCollection<bool, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29037A0 Offset: 0x29038A1 VA: 0x29037A0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2904150 Offset: 0x2904251 VA: 0x2904150
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2904B00 Offset: 0x2904C01 VA: 0x2904B00
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29054B0 Offset: 0x29055B1 VA: 0x29054B0
	|-Dictionary.ValueCollection<double, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2905E60 Offset: 0x2905F61 VA: 0x2905E60
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2906810 Offset: 0x2906911 VA: 0x2906810
	|-Dictionary.ValueCollection<short, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2907230 Offset: 0x2907331 VA: 0x2907230
	|-Dictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2907D20 Offset: 0x2907E21 VA: 0x2907D20
	|-Dictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2908760 Offset: 0x2908861 VA: 0x2908760
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29091B0 Offset: 0x29092B1 VA: 0x29091B0
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2909C50 Offset: 0x2909D51 VA: 0x2909C50
	|-Dictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x290A630 Offset: 0x290A731 VA: 0x290A630
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x290B010 Offset: 0x290B111 VA: 0x290B010
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x290B9F0 Offset: 0x290BAF1 VA: 0x290B9F0
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x290C3D0 Offset: 0x290C4D1 VA: 0x290C3D0
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x290CDB0 Offset: 0x290CEB1 VA: 0x290CDB0
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x290D7A0 Offset: 0x290D8A1 VA: 0x290D7A0
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x290E1A0 Offset: 0x290E2A1 VA: 0x290E1A0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x290EC30 Offset: 0x290ED31 VA: 0x290EC30
	|-Dictionary.ValueCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x290F610 Offset: 0x290F711 VA: 0x290F610
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2910000 Offset: 0x2910101 VA: 0x2910000
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2910A60 Offset: 0x2910B61 VA: 0x2910A60
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2911560 Offset: 0x2911661 VA: 0x2911560
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2911FE0 Offset: 0x29120E1 VA: 0x2911FE0
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29129C0 Offset: 0x2912AC1 VA: 0x29129C0
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29133A0 Offset: 0x29134A1 VA: 0x29133A0
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C11A0 Offset: 0x29C12A1 VA: 0x29C11A0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C1B80 Offset: 0x29C1C81 VA: 0x29C1B80
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C2570 Offset: 0x29C2671 VA: 0x29C2570
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C2F10 Offset: 0x29C3011 VA: 0x29C2F10
	|-Dictionary.ValueCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C3910 Offset: 0x29C3A11 VA: 0x29C3910
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C4300 Offset: 0x29C4401 VA: 0x29C4300
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C4CF0 Offset: 0x29C4DF1 VA: 0x29C4CF0
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C56E0 Offset: 0x29C57E1 VA: 0x29C56E0
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C6090 Offset: 0x29C6191 VA: 0x29C6090
	|-Dictionary.ValueCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C6A40 Offset: 0x29C6B41 VA: 0x29C6A40
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C73F0 Offset: 0x29C74F1 VA: 0x29C73F0
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C7DA0 Offset: 0x29C7EA1 VA: 0x29C7DA0
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C8750 Offset: 0x29C8851 VA: 0x29C8750
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C9100 Offset: 0x29C9201 VA: 0x29C9100
	|-Dictionary.ValueCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29C9AB0 Offset: 0x29C9BB1 VA: 0x29C9AB0
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CA460 Offset: 0x29CA561 VA: 0x29CA460
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CAE10 Offset: 0x29CAF11 VA: 0x29CAE10
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CB7C0 Offset: 0x29CB8C1 VA: 0x29CB7C0
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CC170 Offset: 0x29CC271 VA: 0x29CC170
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CCB20 Offset: 0x29CCC21 VA: 0x29CCB20
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CD4D0 Offset: 0x29CD5D1 VA: 0x29CD4D0
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CDE80 Offset: 0x29CDF81 VA: 0x29CDE80
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CE830 Offset: 0x29CE931 VA: 0x29CE830
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CF1E0 Offset: 0x29CF2E1 VA: 0x29CF1E0
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29CFB90 Offset: 0x29CFC91 VA: 0x29CFB90
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D0540 Offset: 0x29D0641 VA: 0x29D0540
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D0EF0 Offset: 0x29D0FF1 VA: 0x29D0EF0
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D18A0 Offset: 0x29D19A1 VA: 0x29D18A0
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D2240 Offset: 0x29D2341 VA: 0x29D2240
	|-Dictionary.ValueCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D2C60 Offset: 0x29D2D61 VA: 0x29D2C60
	|-Dictionary.ValueCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D3720 Offset: 0x29D3821 VA: 0x29D3720
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D41E0 Offset: 0x29D42E1 VA: 0x29D41E0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D4C30 Offset: 0x29D4D31 VA: 0x29D4C30
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D5620 Offset: 0x29D5721 VA: 0x29D5620
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D6060 Offset: 0x29D6161 VA: 0x29D6060
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29D6AD0 Offset: 0x29D6BD1 VA: 0x29D6AD0
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2958690 Offset: 0x2958791 VA: 0x2958690
	|-Dictionary.ValueCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2959130 Offset: 0x2959231 VA: 0x2959130
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2959BE0 Offset: 0x2959CE1 VA: 0x2959BE0
	|-Dictionary.ValueCollection<object, Parameter>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295A690 Offset: 0x295A791 VA: 0x295A690
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295B070 Offset: 0x295B171 VA: 0x295B070
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295BA50 Offset: 0x295BB51 VA: 0x295BA50
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295C430 Offset: 0x295C531 VA: 0x295C430
	|-Dictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295CE10 Offset: 0x295CF11 VA: 0x295CE10
	|-Dictionary.ValueCollection<object, DateTime>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295D7F0 Offset: 0x295D8F1 VA: 0x295D7F0
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295E1D0 Offset: 0x295E2D1 VA: 0x295E1D0
	|-Dictionary.ValueCollection<object, short>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295EBB0 Offset: 0x295ECB1 VA: 0x295EBB0
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295F590 Offset: 0x295F691 VA: 0x295F590
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x295FF70 Offset: 0x2960071 VA: 0x295FF70
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2960970 Offset: 0x2960A71 VA: 0x2960970
	|-Dictionary.ValueCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2961350 Offset: 0x2961451 VA: 0x2961350
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2961D80 Offset: 0x2961E81 VA: 0x2961D80
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2962830 Offset: 0x2962931 VA: 0x2962830
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2963290 Offset: 0x2963391 VA: 0x2963290
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2963CA0 Offset: 0x2963DA1 VA: 0x2963CA0
	|-Dictionary.ValueCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29646F0 Offset: 0x29647F1 VA: 0x29646F0
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2965100 Offset: 0x2965201 VA: 0x2965100
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2965B80 Offset: 0x2965C81 VA: 0x2965B80
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29665C0 Offset: 0x29666C1 VA: 0x29665C0
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2967040 Offset: 0x2967141 VA: 0x2967040
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2967B30 Offset: 0x2967C31 VA: 0x2967B30
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2968580 Offset: 0x2968681 VA: 0x2968580
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2968F90 Offset: 0x2969091 VA: 0x2968F90
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2969A00 Offset: 0x2969B01 VA: 0x2969A00
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x296A450 Offset: 0x296A551 VA: 0x296A450
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x296AE40 Offset: 0x296AF41 VA: 0x296AE40
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x296B830 Offset: 0x296B931 VA: 0x296B830
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x296C220 Offset: 0x296C321 VA: 0x296C220
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x296CC30 Offset: 0x296CD31 VA: 0x296CC30
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x296D680 Offset: 0x296D781 VA: 0x296D680
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x296E040 Offset: 0x296E141 VA: 0x296E040
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x296EA40 Offset: 0x296EB41 VA: 0x296EA40
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29EDEE0 Offset: 0x29EDFE1 VA: 0x29EDEE0
	|-Dictionary.ValueCollection<object, sbyte>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29EE8C0 Offset: 0x29EE9C1 VA: 0x29EE8C0
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29EF2A0 Offset: 0x29EF3A1 VA: 0x29EF2A0
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29EFC80 Offset: 0x29EFD81 VA: 0x29EFC80
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F0660 Offset: 0x29F0761 VA: 0x29F0660
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F1080 Offset: 0x29F1181 VA: 0x29F1080
	|-Dictionary.ValueCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F1AF0 Offset: 0x29F1BF1 VA: 0x29F1AF0
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F2560 Offset: 0x29F2661 VA: 0x29F2560
	|-Dictionary.ValueCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F2FA0 Offset: 0x29F30A1 VA: 0x29F2FA0
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F3990 Offset: 0x29F3A91 VA: 0x29F3990
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F4380 Offset: 0x29F4481 VA: 0x29F4380
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F4D90 Offset: 0x29F4E91 VA: 0x29F4D90
	|-Dictionary.ValueCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F5820 Offset: 0x29F5921 VA: 0x29F5820
	|-Dictionary.ValueCollection<object, Keyframe>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F6280 Offset: 0x29F6381 VA: 0x29F6280
	|-Dictionary.ValueCollection<object, LayerMask>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F6CD0 Offset: 0x29F6DD1 VA: 0x29F6CD0
	|-Dictionary.ValueCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F7760 Offset: 0x29F7861 VA: 0x29F7760
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F8150 Offset: 0x29F8251 VA: 0x29F8150
	|-Dictionary.ValueCollection<object, Quaternion>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F8B30 Offset: 0x29F8C31 VA: 0x29F8B30
	|-Dictionary.ValueCollection<object, RangeInt>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F9520 Offset: 0x29F9621 VA: 0x29F9520
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29F9F10 Offset: 0x29FA011 VA: 0x29F9F10
	|-Dictionary.ValueCollection<object, RectInt>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29FA930 Offset: 0x29FAA31 VA: 0x29FA930
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29FB3B0 Offset: 0x29FB4B1 VA: 0x29FB3B0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29FBE00 Offset: 0x29FBF01 VA: 0x29FBE00
	|-Dictionary.ValueCollection<object, Vector2>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29FC7E0 Offset: 0x29FC8E1 VA: 0x29FC7E0
	|-Dictionary.ValueCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29FD1D0 Offset: 0x29FD2D1 VA: 0x29FD1D0
	|-Dictionary.ValueCollection<object, Vector3>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29FDBC0 Offset: 0x29FDCC1 VA: 0x29FDBC0
	|-Dictionary.ValueCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29FE5B0 Offset: 0x29FE6B1 VA: 0x29FE5B0
	|-Dictionary.ValueCollection<object, Vector4>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29FEFA0 Offset: 0x29FF0A1 VA: 0x29FEFA0
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x29FF940 Offset: 0x29FFA41 VA: 0x29FF940
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A00330 Offset: 0x2A00431 VA: 0x2A00330
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A00D60 Offset: 0x2A00E61 VA: 0x2A00D60
	|-Dictionary.ValueCollection<float, CurveSample>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A01830 Offset: 0x2A01931 VA: 0x2A01830
	|-Dictionary.ValueCollection<float, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A021E0 Offset: 0x2A022E1 VA: 0x2A021E0
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A02B80 Offset: 0x2A02C81 VA: 0x2A02B80
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A03560 Offset: 0x2A03661 VA: 0x2A03560
	|-Dictionary.ValueCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A03F50 Offset: 0x2A04051 VA: 0x2A03F50
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A04900 Offset: 0x2A04A01 VA: 0x2A04900
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A052A0 Offset: 0x2A053A1 VA: 0x2A052A0
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A05CE0 Offset: 0x2A05DE1 VA: 0x2A05CE0
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A067A0 Offset: 0x2A068A1 VA: 0x2A067A0
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A07240 Offset: 0x2A07341 VA: 0x2A07240
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A07C80 Offset: 0x2A07D81 VA: 0x2A07C80
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A08670 Offset: 0x2A08771 VA: 0x2A08670
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A09020 Offset: 0x2A09121 VA: 0x2A09020
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A099D0 Offset: 0x2A09AD1 VA: 0x2A099D0
	|-Dictionary.ValueCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0A380 Offset: 0x2A0A481 VA: 0x2A0A380
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0AD30 Offset: 0x2A0AE31 VA: 0x2A0AD30
	|-Dictionary.ValueCollection<Color32, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0B6E0 Offset: 0x2A0B7E1 VA: 0x2A0B6E0
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0C090 Offset: 0x2A0C191 VA: 0x2A0C090
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0CA40 Offset: 0x2A0CB41 VA: 0x2A0CA40
	|-Dictionary.ValueCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0D3F0 Offset: 0x2A0D4F1 VA: 0x2A0D3F0
	|-Dictionary.ValueCollection<Keyframe, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0DDA0 Offset: 0x2A0DEA1 VA: 0x2A0DDA0
	|-Dictionary.ValueCollection<LayerMask, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0E750 Offset: 0x2A0E851 VA: 0x2A0E750
	|-Dictionary.ValueCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0F100 Offset: 0x2A0F201 VA: 0x2A0F100
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A0FAB0 Offset: 0x2A0FBB1 VA: 0x2A0FAB0
	|-Dictionary.ValueCollection<Quaternion, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A10460 Offset: 0x2A10561 VA: 0x2A10460
	|-Dictionary.ValueCollection<RangeInt, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A10E10 Offset: 0x2A10F11 VA: 0x2A10E10
	|-Dictionary.ValueCollection<Rect, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A117C0 Offset: 0x2A118C1 VA: 0x2A117C0
	|-Dictionary.ValueCollection<RectInt, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A12160 Offset: 0x2A12261 VA: 0x2A12160
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A12B50 Offset: 0x2A12C51 VA: 0x2A12B50
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A13500 Offset: 0x2A13601 VA: 0x2A13500
	|-Dictionary.ValueCollection<Vector2, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A13EB0 Offset: 0x2A13FB1 VA: 0x2A13EB0
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A14860 Offset: 0x2A14961 VA: 0x2A14860
	|-Dictionary.ValueCollection<Vector3, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A15210 Offset: 0x2A15311 VA: 0x2A15210
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2A15BC0 Offset: 0x2A15CC1 VA: 0x2A15BC0
	|-Dictionary.ValueCollection<Vector4, object>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23413E0 Offset: 0x23414E1 VA: 0x23413E0
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2341D90 Offset: 0x2341E91 VA: 0x2341D90
	|-Dictionary.ValueCollection<BitVector32Int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2342740 Offset: 0x2342841 VA: 0x2342740
	|-Dictionary.ValueCollection<EventCheckId, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x28FD730 Offset: 0x28FD831 VA: 0x28FD730
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x28FE0E0 Offset: 0x28FE1E1 VA: 0x28FE0E0
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x28FEA90 Offset: 0x28FEB91 VA: 0x28FEA90
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x28FF440 Offset: 0x28FF541 VA: 0x28FF440
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x28FFDF0 Offset: 0x28FFEF1 VA: 0x28FFDF0
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29007A0 Offset: 0x29008A1 VA: 0x29007A0
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2901150 Offset: 0x2901251 VA: 0x2901150
	|-Dictionary.ValueCollection<OrderSaveData, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2901B00 Offset: 0x2901C01 VA: 0x2901B00
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29024B0 Offset: 0x29025B1 VA: 0x29024B0
	|-Dictionary.ValueCollection<Parameter, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2902E60 Offset: 0x2902F61 VA: 0x2902E60
	|-Dictionary.ValueCollection<bool, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2903810 Offset: 0x2903911 VA: 0x2903810
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29041C0 Offset: 0x29042C1 VA: 0x29041C0
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2904B70 Offset: 0x2904C71 VA: 0x2904B70
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2905520 Offset: 0x2905621 VA: 0x2905520
	|-Dictionary.ValueCollection<double, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2905ED0 Offset: 0x2905FD1 VA: 0x2905ED0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2906880 Offset: 0x2906981 VA: 0x2906880
	|-Dictionary.ValueCollection<short, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29072A0 Offset: 0x29073A1 VA: 0x29072A0
	|-Dictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2907D90 Offset: 0x2907E91 VA: 0x2907D90
	|-Dictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29087D0 Offset: 0x29088D1 VA: 0x29087D0
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2909220 Offset: 0x2909321 VA: 0x2909220
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2909CC0 Offset: 0x2909DC1 VA: 0x2909CC0
	|-Dictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x290A6A0 Offset: 0x290A7A1 VA: 0x290A6A0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x290B080 Offset: 0x290B181 VA: 0x290B080
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x290BA60 Offset: 0x290BB61 VA: 0x290BA60
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x290C440 Offset: 0x290C541 VA: 0x290C440
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x290CE20 Offset: 0x290CF21 VA: 0x290CE20
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x290D810 Offset: 0x290D911 VA: 0x290D810
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x290E210 Offset: 0x290E311 VA: 0x290E210
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x290ECA0 Offset: 0x290EDA1 VA: 0x290ECA0
	|-Dictionary.ValueCollection<int, SceneInstance>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x290F680 Offset: 0x290F781 VA: 0x290F680
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2910070 Offset: 0x2910171 VA: 0x2910070
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2910AD0 Offset: 0x2910BD1 VA: 0x2910AD0
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29115D0 Offset: 0x29116D1 VA: 0x29115D0
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2912050 Offset: 0x2912151 VA: 0x2912050
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2912A30 Offset: 0x2912B31 VA: 0x2912A30
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2913410 Offset: 0x2913511 VA: 0x2913410
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C1210 Offset: 0x29C1311 VA: 0x29C1210
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C1BF0 Offset: 0x29C1CF1 VA: 0x29C1BF0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C25E0 Offset: 0x29C26E1 VA: 0x29C25E0
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C2F80 Offset: 0x29C3081 VA: 0x29C2F80
	|-Dictionary.ValueCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C3980 Offset: 0x29C3A81 VA: 0x29C3980
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C4370 Offset: 0x29C4471 VA: 0x29C4370
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C4D60 Offset: 0x29C4E61 VA: 0x29C4D60
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C5750 Offset: 0x29C5851 VA: 0x29C5750
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C6100 Offset: 0x29C6201 VA: 0x29C6100
	|-Dictionary.ValueCollection<Memory<object>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C6AB0 Offset: 0x29C6BB1 VA: 0x29C6AB0
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C7460 Offset: 0x29C7561 VA: 0x29C7460
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C7E10 Offset: 0x29C7F11 VA: 0x29C7E10
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C87C0 Offset: 0x29C88C1 VA: 0x29C87C0
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C9170 Offset: 0x29C9271 VA: 0x29C9170
	|-Dictionary.ValueCollection<Nullable<Color>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29C9B20 Offset: 0x29C9C21 VA: 0x29C9B20
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CA4D0 Offset: 0x29CA5D1 VA: 0x29CA4D0
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CAE80 Offset: 0x29CAF81 VA: 0x29CAE80
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CB830 Offset: 0x29CB931 VA: 0x29CB830
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CC1E0 Offset: 0x29CC2E1 VA: 0x29CC1E0
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CCB90 Offset: 0x29CCC91 VA: 0x29CCB90
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CD540 Offset: 0x29CD641 VA: 0x29CD540
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CDEF0 Offset: 0x29CDFF1 VA: 0x29CDEF0
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CE8A0 Offset: 0x29CE9A1 VA: 0x29CE8A0
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CF250 Offset: 0x29CF351 VA: 0x29CF250
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29CFC00 Offset: 0x29CFD01 VA: 0x29CFC00
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D05B0 Offset: 0x29D06B1 VA: 0x29D05B0
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D0F60 Offset: 0x29D1061 VA: 0x29D0F60
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D1910 Offset: 0x29D1A11 VA: 0x29D1910
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D22B0 Offset: 0x29D23B1 VA: 0x29D22B0
	|-Dictionary.ValueCollection<object, BitVector32Int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D2CD0 Offset: 0x29D2DD1 VA: 0x29D2CD0
	|-Dictionary.ValueCollection<object, EventCheckId>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D3790 Offset: 0x29D3891 VA: 0x29D3790
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D4250 Offset: 0x29D4351 VA: 0x29D4250
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D4CA0 Offset: 0x29D4DA1 VA: 0x29D4CA0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D5690 Offset: 0x29D5791 VA: 0x29D5690
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D60D0 Offset: 0x29D61D1 VA: 0x29D60D0
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29D6B40 Offset: 0x29D6C41 VA: 0x29D6B40
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2958700 Offset: 0x2958801 VA: 0x2958700
	|-Dictionary.ValueCollection<object, OrderSaveData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29591A0 Offset: 0x29592A1 VA: 0x29591A0
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2959C50 Offset: 0x2959D51 VA: 0x2959C50
	|-Dictionary.ValueCollection<object, Parameter>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295A700 Offset: 0x295A801 VA: 0x295A700
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295B0E0 Offset: 0x295B1E1 VA: 0x295B0E0
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295BAC0 Offset: 0x295BBC1 VA: 0x295BAC0
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295C4A0 Offset: 0x295C5A1 VA: 0x295C4A0
	|-Dictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295CE80 Offset: 0x295CF81 VA: 0x295CE80
	|-Dictionary.ValueCollection<object, DateTime>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295D860 Offset: 0x295D961 VA: 0x295D860
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295E240 Offset: 0x295E341 VA: 0x295E240
	|-Dictionary.ValueCollection<object, short>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295EC20 Offset: 0x295ED21 VA: 0x295EC20
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295F600 Offset: 0x295F701 VA: 0x295F600
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x295FFE0 Offset: 0x29600E1 VA: 0x295FFE0
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29609E0 Offset: 0x2960AE1 VA: 0x29609E0
	|-Dictionary.ValueCollection<object, Memory<object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29613C0 Offset: 0x29614C1 VA: 0x29613C0
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2961DF0 Offset: 0x2961EF1 VA: 0x2961DF0
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29628A0 Offset: 0x29629A1 VA: 0x29628A0
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2963300 Offset: 0x2963401 VA: 0x2963300
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2963D10 Offset: 0x2963E11 VA: 0x2963D10
	|-Dictionary.ValueCollection<object, Nullable<Color>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2964760 Offset: 0x2964861 VA: 0x2964760
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2965170 Offset: 0x2965271 VA: 0x2965170
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2965BF0 Offset: 0x2965CF1 VA: 0x2965BF0
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2966630 Offset: 0x2966731 VA: 0x2966630
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29670B0 Offset: 0x29671B1 VA: 0x29670B0
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2967BA0 Offset: 0x2967CA1 VA: 0x2967BA0
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29685F0 Offset: 0x29686F1 VA: 0x29685F0
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2969000 Offset: 0x2969101 VA: 0x2969000
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2969A70 Offset: 0x2969B71 VA: 0x2969A70
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x296A4C0 Offset: 0x296A5C1 VA: 0x296A4C0
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x296AEB0 Offset: 0x296AFB1 VA: 0x296AEB0
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x296B8A0 Offset: 0x296B9A1 VA: 0x296B8A0
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x296C290 Offset: 0x296C391 VA: 0x296C290
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x296CCA0 Offset: 0x296CDA1 VA: 0x296CCA0
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x296D6F0 Offset: 0x296D7F1 VA: 0x296D6F0
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x296E0B0 Offset: 0x296E1B1 VA: 0x296E0B0
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x296EAB0 Offset: 0x296EBB1 VA: 0x296EAB0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29EDF50 Offset: 0x29EE051 VA: 0x29EDF50
	|-Dictionary.ValueCollection<object, sbyte>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29EE930 Offset: 0x29EEA31 VA: 0x29EE930
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29EF310 Offset: 0x29EF411 VA: 0x29EF310
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29EFCF0 Offset: 0x29EFDF1 VA: 0x29EFCF0
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F06D0 Offset: 0x29F07D1 VA: 0x29F06D0
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F10F0 Offset: 0x29F11F1 VA: 0x29F10F0
	|-Dictionary.ValueCollection<object, TransitionTables>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F1B60 Offset: 0x29F1C61 VA: 0x29F1B60
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F25D0 Offset: 0x29F26D1 VA: 0x29F25D0
	|-Dictionary.ValueCollection<object, BoundsInt>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F3010 Offset: 0x29F3111 VA: 0x29F3010
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F3A00 Offset: 0x29F3B01 VA: 0x29F3A00
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F43F0 Offset: 0x29F44F1 VA: 0x29F43F0
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F4E00 Offset: 0x29F4F01 VA: 0x29F4E00
	|-Dictionary.ValueCollection<object, GradientColorKey>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F5890 Offset: 0x29F5991 VA: 0x29F5890
	|-Dictionary.ValueCollection<object, Keyframe>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F62F0 Offset: 0x29F63F1 VA: 0x29F62F0
	|-Dictionary.ValueCollection<object, LayerMask>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F6D40 Offset: 0x29F6E41 VA: 0x29F6D40
	|-Dictionary.ValueCollection<object, Matrix4x4>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F77D0 Offset: 0x29F78D1 VA: 0x29F77D0
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F81C0 Offset: 0x29F82C1 VA: 0x29F81C0
	|-Dictionary.ValueCollection<object, Quaternion>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F8BA0 Offset: 0x29F8CA1 VA: 0x29F8BA0
	|-Dictionary.ValueCollection<object, RangeInt>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F9590 Offset: 0x29F9691 VA: 0x29F9590
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29F9F80 Offset: 0x29FA081 VA: 0x29F9F80
	|-Dictionary.ValueCollection<object, RectInt>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29FA9A0 Offset: 0x29FAAA1 VA: 0x29FA9A0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29FB420 Offset: 0x29FB521 VA: 0x29FB420
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29FBE70 Offset: 0x29FBF71 VA: 0x29FBE70
	|-Dictionary.ValueCollection<object, Vector2>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29FC850 Offset: 0x29FC951 VA: 0x29FC850
	|-Dictionary.ValueCollection<object, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29FD240 Offset: 0x29FD341 VA: 0x29FD240
	|-Dictionary.ValueCollection<object, Vector3>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29FDC30 Offset: 0x29FDD31 VA: 0x29FDC30
	|-Dictionary.ValueCollection<object, Vector3Int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29FE620 Offset: 0x29FE721 VA: 0x29FE620
	|-Dictionary.ValueCollection<object, Vector4>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29FF010 Offset: 0x29FF111 VA: 0x29FF010
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x29FF9B0 Offset: 0x29FFAB1 VA: 0x29FF9B0
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A003A0 Offset: 0x2A004A1 VA: 0x2A003A0
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A00DD0 Offset: 0x2A00ED1 VA: 0x2A00DD0
	|-Dictionary.ValueCollection<float, CurveSample>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A018A0 Offset: 0x2A019A1 VA: 0x2A018A0
	|-Dictionary.ValueCollection<float, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A02250 Offset: 0x2A02351 VA: 0x2A02250
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A02BF0 Offset: 0x2A02CF1 VA: 0x2A02BF0
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A035D0 Offset: 0x2A036D1 VA: 0x2A035D0
	|-Dictionary.ValueCollection<uint, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A03FC0 Offset: 0x2A040C1 VA: 0x2A03FC0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A04970 Offset: 0x2A04A71 VA: 0x2A04970
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A05310 Offset: 0x2A05411 VA: 0x2A05310
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A05D50 Offset: 0x2A05E51 VA: 0x2A05D50
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A06810 Offset: 0x2A06911 VA: 0x2A06810
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A072B0 Offset: 0x2A073B1 VA: 0x2A072B0
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A07CF0 Offset: 0x2A07DF1 VA: 0x2A07CF0
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A086E0 Offset: 0x2A087E1 VA: 0x2A086E0
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A09090 Offset: 0x2A09191 VA: 0x2A09090
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A09A40 Offset: 0x2A09B41 VA: 0x2A09A40
	|-Dictionary.ValueCollection<BoundsInt, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0A3F0 Offset: 0x2A0A4F1 VA: 0x2A0A3F0
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0ADA0 Offset: 0x2A0AEA1 VA: 0x2A0ADA0
	|-Dictionary.ValueCollection<Color32, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0B750 Offset: 0x2A0B851 VA: 0x2A0B750
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0C100 Offset: 0x2A0C201 VA: 0x2A0C100
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0CAB0 Offset: 0x2A0CBB1 VA: 0x2A0CAB0
	|-Dictionary.ValueCollection<GradientColorKey, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0D460 Offset: 0x2A0D561 VA: 0x2A0D460
	|-Dictionary.ValueCollection<Keyframe, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0DE10 Offset: 0x2A0DF11 VA: 0x2A0DE10
	|-Dictionary.ValueCollection<LayerMask, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0E7C0 Offset: 0x2A0E8C1 VA: 0x2A0E7C0
	|-Dictionary.ValueCollection<Matrix4x4, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0F170 Offset: 0x2A0F271 VA: 0x2A0F170
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A0FB20 Offset: 0x2A0FC21 VA: 0x2A0FB20
	|-Dictionary.ValueCollection<Quaternion, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A104D0 Offset: 0x2A105D1 VA: 0x2A104D0
	|-Dictionary.ValueCollection<RangeInt, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A10E80 Offset: 0x2A10F81 VA: 0x2A10E80
	|-Dictionary.ValueCollection<Rect, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A11830 Offset: 0x2A11931 VA: 0x2A11830
	|-Dictionary.ValueCollection<RectInt, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A121D0 Offset: 0x2A122D1 VA: 0x2A121D0
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A12BC0 Offset: 0x2A12CC1 VA: 0x2A12BC0
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A13570 Offset: 0x2A13671 VA: 0x2A13570
	|-Dictionary.ValueCollection<Vector2, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A13F20 Offset: 0x2A14021 VA: 0x2A13F20
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A148D0 Offset: 0x2A149D1 VA: 0x2A148D0
	|-Dictionary.ValueCollection<Vector3, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A15280 Offset: 0x2A15381 VA: 0x2A15280
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2A15C30 Offset: 0x2A15D31 VA: 0x2A15C30
	|-Dictionary.ValueCollection<Vector4, object>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2341410 Offset: 0x2341511 VA: 0x2341410
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2341DC0 Offset: 0x2341EC1 VA: 0x2341DC0
	|-Dictionary.ValueCollection<BitVector32Int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2342770 Offset: 0x2342871 VA: 0x2342770
	|-Dictionary.ValueCollection<EventCheckId, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x28FD760 Offset: 0x28FD861 VA: 0x28FD760
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x28FE110 Offset: 0x28FE211 VA: 0x28FE110
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x28FEAC0 Offset: 0x28FEBC1 VA: 0x28FEAC0
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x28FF470 Offset: 0x28FF571 VA: 0x28FF470
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x28FFE20 Offset: 0x28FFF21 VA: 0x28FFE20
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29007D0 Offset: 0x29008D1 VA: 0x29007D0
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2901180 Offset: 0x2901281 VA: 0x2901180
	|-Dictionary.ValueCollection<OrderSaveData, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2901B30 Offset: 0x2901C31 VA: 0x2901B30
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29024E0 Offset: 0x29025E1 VA: 0x29024E0
	|-Dictionary.ValueCollection<Parameter, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2902E90 Offset: 0x2902F91 VA: 0x2902E90
	|-Dictionary.ValueCollection<bool, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2903840 Offset: 0x2903941 VA: 0x2903840
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29041F0 Offset: 0x29042F1 VA: 0x29041F0
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2904BA0 Offset: 0x2904CA1 VA: 0x2904BA0
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2905550 Offset: 0x2905651 VA: 0x2905550
	|-Dictionary.ValueCollection<double, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2905F00 Offset: 0x2906001 VA: 0x2905F00
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29068B0 Offset: 0x29069B1 VA: 0x29068B0
	|-Dictionary.ValueCollection<short, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2907320 Offset: 0x2907421 VA: 0x2907320
	|-Dictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2907E00 Offset: 0x2907F01 VA: 0x2907E00
	|-Dictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2908800 Offset: 0x2908901 VA: 0x2908800
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29092B0 Offset: 0x29093B1 VA: 0x29092B0
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2909CF0 Offset: 0x2909DF1 VA: 0x2909CF0
	|-Dictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x290A6D0 Offset: 0x290A7D1 VA: 0x290A6D0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x290B0B0 Offset: 0x290B1B1 VA: 0x290B0B0
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x290BA90 Offset: 0x290BB91 VA: 0x290BA90
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x290C470 Offset: 0x290C571 VA: 0x290C470
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x290CE50 Offset: 0x290CF51 VA: 0x290CE50
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x290D840 Offset: 0x290D941 VA: 0x290D840
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x290E290 Offset: 0x290E391 VA: 0x290E290
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x290ECD0 Offset: 0x290EDD1 VA: 0x290ECD0
	|-Dictionary.ValueCollection<int, SceneInstance>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x290F6B0 Offset: 0x290F7B1 VA: 0x290F6B0
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29100A0 Offset: 0x29101A1 VA: 0x29100A0
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2910B50 Offset: 0x2910C51 VA: 0x2910B50
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2911650 Offset: 0x2911751 VA: 0x2911650
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2912080 Offset: 0x2912181 VA: 0x2912080
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2912A60 Offset: 0x2912B61 VA: 0x2912A60
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2913440 Offset: 0x2913541 VA: 0x2913440
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C1240 Offset: 0x29C1341 VA: 0x29C1240
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C1C20 Offset: 0x29C1D21 VA: 0x29C1C20
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C2610 Offset: 0x29C2711 VA: 0x29C2610
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C2FB0 Offset: 0x29C30B1 VA: 0x29C2FB0
	|-Dictionary.ValueCollection<Int32Enum, float>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C39B0 Offset: 0x29C3AB1 VA: 0x29C39B0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C43A0 Offset: 0x29C44A1 VA: 0x29C43A0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C4D90 Offset: 0x29C4E91 VA: 0x29C4D90
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C5780 Offset: 0x29C5881 VA: 0x29C5780
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C6130 Offset: 0x29C6231 VA: 0x29C6130
	|-Dictionary.ValueCollection<Memory<object>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C6AE0 Offset: 0x29C6BE1 VA: 0x29C6AE0
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C7490 Offset: 0x29C7591 VA: 0x29C7490
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C7E40 Offset: 0x29C7F41 VA: 0x29C7E40
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C87F0 Offset: 0x29C88F1 VA: 0x29C87F0
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C91A0 Offset: 0x29C92A1 VA: 0x29C91A0
	|-Dictionary.ValueCollection<Nullable<Color>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29C9B50 Offset: 0x29C9C51 VA: 0x29C9B50
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CA500 Offset: 0x29CA601 VA: 0x29CA500
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CAEB0 Offset: 0x29CAFB1 VA: 0x29CAEB0
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CB860 Offset: 0x29CB961 VA: 0x29CB860
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CC210 Offset: 0x29CC311 VA: 0x29CC210
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CCBC0 Offset: 0x29CCCC1 VA: 0x29CCBC0
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CD570 Offset: 0x29CD671 VA: 0x29CD570
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CDF20 Offset: 0x29CE021 VA: 0x29CDF20
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CE8D0 Offset: 0x29CE9D1 VA: 0x29CE8D0
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CF280 Offset: 0x29CF381 VA: 0x29CF280
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29CFC30 Offset: 0x29CFD31 VA: 0x29CFC30
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D05E0 Offset: 0x29D06E1 VA: 0x29D05E0
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D0F90 Offset: 0x29D1091 VA: 0x29D0F90
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D1940 Offset: 0x29D1A41 VA: 0x29D1940
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D22E0 Offset: 0x29D23E1 VA: 0x29D22E0
	|-Dictionary.ValueCollection<object, BitVector32Int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D2D40 Offset: 0x29D2E41 VA: 0x29D2D40
	|-Dictionary.ValueCollection<object, EventCheckId>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D3820 Offset: 0x29D3921 VA: 0x29D3820
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D42C0 Offset: 0x29D43C1 VA: 0x29D42C0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D4CD0 Offset: 0x29D4DD1 VA: 0x29D4CD0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D56C0 Offset: 0x29D57C1 VA: 0x29D56C0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D6150 Offset: 0x29D6251 VA: 0x29D6150
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29D6B70 Offset: 0x29D6C71 VA: 0x29D6B70
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2958780 Offset: 0x2958881 VA: 0x2958780
	|-Dictionary.ValueCollection<object, OrderSaveData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2959210 Offset: 0x2959311 VA: 0x2959210
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2959CD0 Offset: 0x2959DD1 VA: 0x2959CD0
	|-Dictionary.ValueCollection<object, Parameter>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x295A730 Offset: 0x295A831 VA: 0x295A730
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x295B110 Offset: 0x295B211 VA: 0x295B110
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x295BAF0 Offset: 0x295BBF1 VA: 0x295BAF0
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x295C4D0 Offset: 0x295C5D1 VA: 0x295C4D0
	|-Dictionary.ValueCollection<object, char>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x295CEB0 Offset: 0x295CFB1 VA: 0x295CEB0
	|-Dictionary.ValueCollection<object, DateTime>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x295D890 Offset: 0x295D991 VA: 0x295D890
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x295E270 Offset: 0x295E371 VA: 0x295E270
	|-Dictionary.ValueCollection<object, short>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x295EC50 Offset: 0x295ED51 VA: 0x295EC50
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x295F630 Offset: 0x295F731 VA: 0x295F630
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2960010 Offset: 0x2960111 VA: 0x2960010
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2960A10 Offset: 0x2960B11 VA: 0x2960A10
	|-Dictionary.ValueCollection<object, Memory<object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29613F0 Offset: 0x29614F1 VA: 0x29613F0
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2961E70 Offset: 0x2961F71 VA: 0x2961E70
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2962920 Offset: 0x2962A21 VA: 0x2962920
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2963330 Offset: 0x2963431 VA: 0x2963330
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2963D80 Offset: 0x2963E81 VA: 0x2963D80
	|-Dictionary.ValueCollection<object, Nullable<Color>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2964790 Offset: 0x2964891 VA: 0x2964790
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29651E0 Offset: 0x29652E1 VA: 0x29651E0
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2965C60 Offset: 0x2965D61 VA: 0x2965C60
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2966660 Offset: 0x2966761 VA: 0x2966660
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2967150 Offset: 0x2967251 VA: 0x2967150
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2967C10 Offset: 0x2967D11 VA: 0x2967C10
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2968620 Offset: 0x2968721 VA: 0x2968620
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2969070 Offset: 0x2969171 VA: 0x2969070
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2969AE0 Offset: 0x2969BE1 VA: 0x2969AE0
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x296A4F0 Offset: 0x296A5F1 VA: 0x296A4F0
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x296AEE0 Offset: 0x296AFE1 VA: 0x296AEE0
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x296B8D0 Offset: 0x296B9D1 VA: 0x296B8D0
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x296C2C0 Offset: 0x296C3C1 VA: 0x296C2C0
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x296CD10 Offset: 0x296CE11 VA: 0x296CD10
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x296D720 Offset: 0x296D821 VA: 0x296D720
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x296E0E0 Offset: 0x296E1E1 VA: 0x296E0E0
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x296EAE0 Offset: 0x296EBE1 VA: 0x296EAE0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29EDF80 Offset: 0x29EE081 VA: 0x29EDF80
	|-Dictionary.ValueCollection<object, sbyte>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29EE960 Offset: 0x29EEA61 VA: 0x29EE960
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29EF340 Offset: 0x29EF441 VA: 0x29EF340
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29EFD20 Offset: 0x29EFE21 VA: 0x29EFD20
	|-Dictionary.ValueCollection<object, uint>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F0700 Offset: 0x29F0801 VA: 0x29F0700
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F1160 Offset: 0x29F1261 VA: 0x29F1160
	|-Dictionary.ValueCollection<object, TransitionTables>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F1BD0 Offset: 0x29F1CD1 VA: 0x29F1BD0
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F2640 Offset: 0x29F2741 VA: 0x29F2640
	|-Dictionary.ValueCollection<object, BoundsInt>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F3040 Offset: 0x29F3141 VA: 0x29F3040
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F3A30 Offset: 0x29F3B31 VA: 0x29F3A30
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F4420 Offset: 0x29F4521 VA: 0x29F4420
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F4E70 Offset: 0x29F4F71 VA: 0x29F4E70
	|-Dictionary.ValueCollection<object, GradientColorKey>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F5910 Offset: 0x29F5A11 VA: 0x29F5910
	|-Dictionary.ValueCollection<object, Keyframe>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F6320 Offset: 0x29F6421 VA: 0x29F6320
	|-Dictionary.ValueCollection<object, LayerMask>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F6DD0 Offset: 0x29F6ED1 VA: 0x29F6DD0
	|-Dictionary.ValueCollection<object, Matrix4x4>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F7800 Offset: 0x29F7901 VA: 0x29F7800
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F81F0 Offset: 0x29F82F1 VA: 0x29F81F0
	|-Dictionary.ValueCollection<object, Quaternion>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F8BD0 Offset: 0x29F8CD1 VA: 0x29F8BD0
	|-Dictionary.ValueCollection<object, RangeInt>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F95C0 Offset: 0x29F96C1 VA: 0x29F95C0
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29F9FB0 Offset: 0x29FA0B1 VA: 0x29F9FB0
	|-Dictionary.ValueCollection<object, RectInt>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29FAA10 Offset: 0x29FAB11 VA: 0x29FAA10
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29FB490 Offset: 0x29FB591 VA: 0x29FB490
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29FBEA0 Offset: 0x29FBFA1 VA: 0x29FBEA0
	|-Dictionary.ValueCollection<object, Vector2>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29FC880 Offset: 0x29FC981 VA: 0x29FC880
	|-Dictionary.ValueCollection<object, Vector2Int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29FD270 Offset: 0x29FD371 VA: 0x29FD270
	|-Dictionary.ValueCollection<object, Vector3>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29FDC60 Offset: 0x29FDD61 VA: 0x29FDC60
	|-Dictionary.ValueCollection<object, Vector3Int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29FE650 Offset: 0x29FE751 VA: 0x29FE650
	|-Dictionary.ValueCollection<object, Vector4>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29FF040 Offset: 0x29FF141 VA: 0x29FF040
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x29FF9E0 Offset: 0x29FFAE1 VA: 0x29FF9E0
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A003D0 Offset: 0x2A004D1 VA: 0x2A003D0
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A00E70 Offset: 0x2A00F71 VA: 0x2A00E70
	|-Dictionary.ValueCollection<float, CurveSample>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A018D0 Offset: 0x2A019D1 VA: 0x2A018D0
	|-Dictionary.ValueCollection<float, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A02280 Offset: 0x2A02381 VA: 0x2A02280
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A02C20 Offset: 0x2A02D21 VA: 0x2A02C20
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A03600 Offset: 0x2A03701 VA: 0x2A03600
	|-Dictionary.ValueCollection<uint, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A03FF0 Offset: 0x2A040F1 VA: 0x2A03FF0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A049A0 Offset: 0x2A04AA1 VA: 0x2A049A0
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A05340 Offset: 0x2A05441 VA: 0x2A05340
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A05DD0 Offset: 0x2A05ED1 VA: 0x2A05DD0
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A06890 Offset: 0x2A06991 VA: 0x2A06890
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A07320 Offset: 0x2A07421 VA: 0x2A07320
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A07D20 Offset: 0x2A07E21 VA: 0x2A07D20
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A08710 Offset: 0x2A08811 VA: 0x2A08710
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A090C0 Offset: 0x2A091C1 VA: 0x2A090C0
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A09A70 Offset: 0x2A09B71 VA: 0x2A09A70
	|-Dictionary.ValueCollection<BoundsInt, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0A420 Offset: 0x2A0A521 VA: 0x2A0A420
	|-Dictionary.ValueCollection<Color, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0ADD0 Offset: 0x2A0AED1 VA: 0x2A0ADD0
	|-Dictionary.ValueCollection<Color32, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0B780 Offset: 0x2A0B881 VA: 0x2A0B780
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0C130 Offset: 0x2A0C231 VA: 0x2A0C130
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0CAE0 Offset: 0x2A0CBE1 VA: 0x2A0CAE0
	|-Dictionary.ValueCollection<GradientColorKey, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0D490 Offset: 0x2A0D591 VA: 0x2A0D490
	|-Dictionary.ValueCollection<Keyframe, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0DE40 Offset: 0x2A0DF41 VA: 0x2A0DE40
	|-Dictionary.ValueCollection<LayerMask, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0E7F0 Offset: 0x2A0E8F1 VA: 0x2A0E7F0
	|-Dictionary.ValueCollection<Matrix4x4, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0F1A0 Offset: 0x2A0F2A1 VA: 0x2A0F1A0
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A0FB50 Offset: 0x2A0FC51 VA: 0x2A0FB50
	|-Dictionary.ValueCollection<Quaternion, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A10500 Offset: 0x2A10601 VA: 0x2A10500
	|-Dictionary.ValueCollection<RangeInt, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A10EB0 Offset: 0x2A10FB1 VA: 0x2A10EB0
	|-Dictionary.ValueCollection<Rect, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A11860 Offset: 0x2A11961 VA: 0x2A11860
	|-Dictionary.ValueCollection<RectInt, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A12200 Offset: 0x2A12301 VA: 0x2A12200
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A12BF0 Offset: 0x2A12CF1 VA: 0x2A12BF0
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A135A0 Offset: 0x2A136A1 VA: 0x2A135A0
	|-Dictionary.ValueCollection<Vector2, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A13F50 Offset: 0x2A14051 VA: 0x2A13F50
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A14900 Offset: 0x2A14A01 VA: 0x2A14900
	|-Dictionary.ValueCollection<Vector3, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A152B0 Offset: 0x2A153B1 VA: 0x2A152B0
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2A15C60 Offset: 0x2A15D61 VA: 0x2A15C60
	|-Dictionary.ValueCollection<Vector4, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2341490 Offset: 0x2341591 VA: 0x2341490
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2341E40 Offset: 0x2341F41 VA: 0x2341E40
	|-Dictionary.ValueCollection<BitVector32Int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x23427F0 Offset: 0x23428F1 VA: 0x23427F0
	|-Dictionary.ValueCollection<EventCheckId, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28FD7E0 Offset: 0x28FD8E1 VA: 0x28FD7E0
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28FE190 Offset: 0x28FE291 VA: 0x28FE190
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28FEB40 Offset: 0x28FEC41 VA: 0x28FEB40
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28FF4F0 Offset: 0x28FF5F1 VA: 0x28FF4F0
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28FFEA0 Offset: 0x28FFFA1 VA: 0x28FFEA0
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2900850 Offset: 0x2900951 VA: 0x2900850
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2901200 Offset: 0x2901301 VA: 0x2901200
	|-Dictionary.ValueCollection<OrderSaveData, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2901BB0 Offset: 0x2901CB1 VA: 0x2901BB0
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2902560 Offset: 0x2902661 VA: 0x2902560
	|-Dictionary.ValueCollection<Parameter, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2902F10 Offset: 0x2903011 VA: 0x2902F10
	|-Dictionary.ValueCollection<bool, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29038C0 Offset: 0x29039C1 VA: 0x29038C0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2904270 Offset: 0x2904371 VA: 0x2904270
	|-Dictionary.ValueCollection<char, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2904C20 Offset: 0x2904D21 VA: 0x2904C20
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29055D0 Offset: 0x29056D1 VA: 0x29055D0
	|-Dictionary.ValueCollection<double, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2905F80 Offset: 0x2906081 VA: 0x2905F80
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2906930 Offset: 0x2906A31 VA: 0x2906930
	|-Dictionary.ValueCollection<short, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29073E0 Offset: 0x29074E1 VA: 0x29073E0
	|-Dictionary.ValueCollection<int, CropDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2907E90 Offset: 0x2907F91 VA: 0x2907E90
	|-Dictionary.ValueCollection<int, EffectDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2908880 Offset: 0x2908981 VA: 0x2908880
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2909350 Offset: 0x2909451 VA: 0x2909350
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2909D70 Offset: 0x2909E71 VA: 0x2909D70
	|-Dictionary.ValueCollection<int, MiningDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x290A750 Offset: 0x290A851 VA: 0x290A750
	|-Dictionary.ValueCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x290B130 Offset: 0x290B231 VA: 0x290B130
	|-Dictionary.ValueCollection<int, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x290BB10 Offset: 0x290BC11 VA: 0x290BB10
	|-Dictionary.ValueCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x290C4F0 Offset: 0x290C5F1 VA: 0x290C4F0
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x290CED0 Offset: 0x290CFD1 VA: 0x290CED0
	|-Dictionary.ValueCollection<int, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x290D8C0 Offset: 0x290D9C1 VA: 0x290D8C0
	|-Dictionary.ValueCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x290E330 Offset: 0x290E431 VA: 0x290E330
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x290ED50 Offset: 0x290EE51 VA: 0x290ED50
	|-Dictionary.ValueCollection<int, SceneInstance>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x290F730 Offset: 0x290F831 VA: 0x290F730
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2910120 Offset: 0x2910221 VA: 0x2910120
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2910C00 Offset: 0x2910D01 VA: 0x2910C00
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29116F0 Offset: 0x29117F1 VA: 0x29116F0
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2912100 Offset: 0x2912201 VA: 0x2912100
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2912AE0 Offset: 0x2912BE1 VA: 0x2912AE0
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29134C0 Offset: 0x29135C1 VA: 0x29134C0
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C12C0 Offset: 0x29C13C1 VA: 0x29C12C0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C1CA0 Offset: 0x29C1DA1 VA: 0x29C1CA0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C2690 Offset: 0x29C2791 VA: 0x29C2690
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C3030 Offset: 0x29C3131 VA: 0x29C3030
	|-Dictionary.ValueCollection<Int32Enum, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C3A30 Offset: 0x29C3B31 VA: 0x29C3A30
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C4420 Offset: 0x29C4521 VA: 0x29C4420
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C4E10 Offset: 0x29C4F11 VA: 0x29C4E10
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C5800 Offset: 0x29C5901 VA: 0x29C5800
	|-Dictionary.ValueCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C61B0 Offset: 0x29C62B1 VA: 0x29C61B0
	|-Dictionary.ValueCollection<Memory<object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C6B60 Offset: 0x29C6C61 VA: 0x29C6B60
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C7510 Offset: 0x29C7611 VA: 0x29C7510
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C7EC0 Offset: 0x29C7FC1 VA: 0x29C7EC0
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C8870 Offset: 0x29C8971 VA: 0x29C8870
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C9220 Offset: 0x29C9321 VA: 0x29C9220
	|-Dictionary.ValueCollection<Nullable<Color>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29C9BD0 Offset: 0x29C9CD1 VA: 0x29C9BD0
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CA580 Offset: 0x29CA681 VA: 0x29CA580
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CAF30 Offset: 0x29CB031 VA: 0x29CAF30
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CB8E0 Offset: 0x29CB9E1 VA: 0x29CB8E0
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CC290 Offset: 0x29CC391 VA: 0x29CC290
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CCC40 Offset: 0x29CCD41 VA: 0x29CCC40
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CD5F0 Offset: 0x29CD6F1 VA: 0x29CD5F0
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CDFA0 Offset: 0x29CE0A1 VA: 0x29CDFA0
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CE950 Offset: 0x29CEA51 VA: 0x29CE950
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CF300 Offset: 0x29CF401 VA: 0x29CF300
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29CFCB0 Offset: 0x29CFDB1 VA: 0x29CFCB0
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D0660 Offset: 0x29D0761 VA: 0x29D0660
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D1010 Offset: 0x29D1111 VA: 0x29D1010
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D19C0 Offset: 0x29D1AC1 VA: 0x29D19C0
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D2360 Offset: 0x29D2461 VA: 0x29D2360
	|-Dictionary.ValueCollection<object, BitVector32Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D2DD0 Offset: 0x29D2ED1 VA: 0x29D2DD0
	|-Dictionary.ValueCollection<object, EventCheckId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D38C0 Offset: 0x29D39C1 VA: 0x29D38C0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D4350 Offset: 0x29D4451 VA: 0x29D4350
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D4D50 Offset: 0x29D4E51 VA: 0x29D4D50
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D5740 Offset: 0x29D5841 VA: 0x29D5740
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D61E0 Offset: 0x29D62E1 VA: 0x29D61E0
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29D6BF0 Offset: 0x29D6CF1 VA: 0x29D6BF0
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2958810 Offset: 0x2958911 VA: 0x2958810
	|-Dictionary.ValueCollection<object, OrderSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29592A0 Offset: 0x29593A1 VA: 0x29592A0
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2959D80 Offset: 0x2959E81 VA: 0x2959D80
	|-Dictionary.ValueCollection<object, Parameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x295A7B0 Offset: 0x295A8B1 VA: 0x295A7B0
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x295B190 Offset: 0x295B291 VA: 0x295B190
	|-Dictionary.ValueCollection<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x295BB70 Offset: 0x295BC71 VA: 0x295BB70
	|-Dictionary.ValueCollection<object, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x295C550 Offset: 0x295C651 VA: 0x295C550
	|-Dictionary.ValueCollection<object, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x295CF30 Offset: 0x295D031 VA: 0x295CF30
	|-Dictionary.ValueCollection<object, DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x295D910 Offset: 0x295DA11 VA: 0x295D910
	|-Dictionary.ValueCollection<object, double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x295E2F0 Offset: 0x295E3F1 VA: 0x295E2F0
	|-Dictionary.ValueCollection<object, short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x295ECD0 Offset: 0x295EDD1 VA: 0x295ECD0
	|-Dictionary.ValueCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x295F6B0 Offset: 0x295F7B1 VA: 0x295F6B0
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2960090 Offset: 0x2960191 VA: 0x2960090
	|-Dictionary.ValueCollection<object, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2960A90 Offset: 0x2960B91 VA: 0x2960A90
	|-Dictionary.ValueCollection<object, Memory<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2961470 Offset: 0x2961571 VA: 0x2961470
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2961F00 Offset: 0x2962001 VA: 0x2961F00
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29629B0 Offset: 0x2962AB1 VA: 0x29629B0
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29633B0 Offset: 0x29634B1 VA: 0x29633B0
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2963E10 Offset: 0x2963F11 VA: 0x2963E10
	|-Dictionary.ValueCollection<object, Nullable<Color>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2964810 Offset: 0x2964911 VA: 0x2964810
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2965270 Offset: 0x2965371 VA: 0x2965270
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2965CF0 Offset: 0x2965DF1 VA: 0x2965CF0
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29666E0 Offset: 0x29667E1 VA: 0x29666E0
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2967200 Offset: 0x2967301 VA: 0x2967200
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2967CA0 Offset: 0x2967DA1 VA: 0x2967CA0
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29686A0 Offset: 0x29687A1 VA: 0x29686A0
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2969100 Offset: 0x2969201 VA: 0x2969100
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2969B70 Offset: 0x2969C71 VA: 0x2969B70
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x296A570 Offset: 0x296A671 VA: 0x296A570
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x296AF60 Offset: 0x296B061 VA: 0x296AF60
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x296B950 Offset: 0x296BA51 VA: 0x296B950
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x296C340 Offset: 0x296C441 VA: 0x296C340
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x296CDA0 Offset: 0x296CEA1 VA: 0x296CDA0
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x296D7A0 Offset: 0x296D8A1 VA: 0x296D7A0
	|-Dictionary.ValueCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x296E160 Offset: 0x296E261 VA: 0x296E160
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x296EB60 Offset: 0x296EC61 VA: 0x296EB60
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29EE000 Offset: 0x29EE101 VA: 0x29EE000
	|-Dictionary.ValueCollection<object, sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29EE9E0 Offset: 0x29EEAE1 VA: 0x29EE9E0
	|-Dictionary.ValueCollection<object, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29EF3C0 Offset: 0x29EF4C1 VA: 0x29EF3C0
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29EFDA0 Offset: 0x29EFEA1 VA: 0x29EFDA0
	|-Dictionary.ValueCollection<object, uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F0780 Offset: 0x29F0881 VA: 0x29F0780
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F11F0 Offset: 0x29F12F1 VA: 0x29F11F0
	|-Dictionary.ValueCollection<object, TransitionTables>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F1C60 Offset: 0x29F1D61 VA: 0x29F1C60
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F26D0 Offset: 0x29F27D1 VA: 0x29F26D0
	|-Dictionary.ValueCollection<object, BoundsInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F30C0 Offset: 0x29F31C1 VA: 0x29F30C0
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F3AB0 Offset: 0x29F3BB1 VA: 0x29F3AB0
	|-Dictionary.ValueCollection<object, Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F44A0 Offset: 0x29F45A1 VA: 0x29F44A0
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F4F00 Offset: 0x29F5001 VA: 0x29F4F00
	|-Dictionary.ValueCollection<object, GradientColorKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F59A0 Offset: 0x29F5AA1 VA: 0x29F59A0
	|-Dictionary.ValueCollection<object, Keyframe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F63A0 Offset: 0x29F64A1 VA: 0x29F63A0
	|-Dictionary.ValueCollection<object, LayerMask>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F6E70 Offset: 0x29F6F71 VA: 0x29F6E70
	|-Dictionary.ValueCollection<object, Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F7880 Offset: 0x29F7981 VA: 0x29F7880
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F8270 Offset: 0x29F8371 VA: 0x29F8270
	|-Dictionary.ValueCollection<object, Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F8C50 Offset: 0x29F8D51 VA: 0x29F8C50
	|-Dictionary.ValueCollection<object, RangeInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29F9640 Offset: 0x29F9741 VA: 0x29F9640
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FA030 Offset: 0x29FA131 VA: 0x29FA030
	|-Dictionary.ValueCollection<object, RectInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FAAA0 Offset: 0x29FABA1 VA: 0x29FAAA0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FB520 Offset: 0x29FB621 VA: 0x29FB520
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FBF20 Offset: 0x29FC021 VA: 0x29FBF20
	|-Dictionary.ValueCollection<object, Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FC900 Offset: 0x29FCA01 VA: 0x29FC900
	|-Dictionary.ValueCollection<object, Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FD2F0 Offset: 0x29FD3F1 VA: 0x29FD2F0
	|-Dictionary.ValueCollection<object, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FDCE0 Offset: 0x29FDDE1 VA: 0x29FDCE0
	|-Dictionary.ValueCollection<object, Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FE6D0 Offset: 0x29FE7D1 VA: 0x29FE6D0
	|-Dictionary.ValueCollection<object, Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FF0C0 Offset: 0x29FF1C1 VA: 0x29FF0C0
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FFA60 Offset: 0x29FFB61 VA: 0x29FFA60
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A00450 Offset: 0x2A00551 VA: 0x2A00450
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A00F20 Offset: 0x2A01021 VA: 0x2A00F20
	|-Dictionary.ValueCollection<float, CurveSample>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A01950 Offset: 0x2A01A51 VA: 0x2A01950
	|-Dictionary.ValueCollection<float, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A02300 Offset: 0x2A02401 VA: 0x2A02300
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A02CA0 Offset: 0x2A02DA1 VA: 0x2A02CA0
	|-Dictionary.ValueCollection<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A03680 Offset: 0x2A03781 VA: 0x2A03680
	|-Dictionary.ValueCollection<uint, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A04070 Offset: 0x2A04171 VA: 0x2A04070
	|-Dictionary.ValueCollection<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A04A20 Offset: 0x2A04B21 VA: 0x2A04A20
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A053C0 Offset: 0x2A054C1 VA: 0x2A053C0
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A05E60 Offset: 0x2A05F61 VA: 0x2A05E60
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A06930 Offset: 0x2A06A31 VA: 0x2A06930
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A073B0 Offset: 0x2A074B1 VA: 0x2A073B0
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A07DA0 Offset: 0x2A07EA1 VA: 0x2A07DA0
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A08790 Offset: 0x2A08891 VA: 0x2A08790
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A09140 Offset: 0x2A09241 VA: 0x2A09140
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A09AF0 Offset: 0x2A09BF1 VA: 0x2A09AF0
	|-Dictionary.ValueCollection<BoundsInt, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0A4A0 Offset: 0x2A0A5A1 VA: 0x2A0A4A0
	|-Dictionary.ValueCollection<Color, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0AE50 Offset: 0x2A0AF51 VA: 0x2A0AE50
	|-Dictionary.ValueCollection<Color32, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0B800 Offset: 0x2A0B901 VA: 0x2A0B800
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0C1B0 Offset: 0x2A0C2B1 VA: 0x2A0C1B0
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0CB60 Offset: 0x2A0CC61 VA: 0x2A0CB60
	|-Dictionary.ValueCollection<GradientColorKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0D510 Offset: 0x2A0D611 VA: 0x2A0D510
	|-Dictionary.ValueCollection<Keyframe, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0DEC0 Offset: 0x2A0DFC1 VA: 0x2A0DEC0
	|-Dictionary.ValueCollection<LayerMask, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0E870 Offset: 0x2A0E971 VA: 0x2A0E870
	|-Dictionary.ValueCollection<Matrix4x4, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0F220 Offset: 0x2A0F321 VA: 0x2A0F220
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A0FBD0 Offset: 0x2A0FCD1 VA: 0x2A0FBD0
	|-Dictionary.ValueCollection<Quaternion, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A10580 Offset: 0x2A10681 VA: 0x2A10580
	|-Dictionary.ValueCollection<RangeInt, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A10F30 Offset: 0x2A11031 VA: 0x2A10F30
	|-Dictionary.ValueCollection<Rect, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A118E0 Offset: 0x2A119E1 VA: 0x2A118E0
	|-Dictionary.ValueCollection<RectInt, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A12280 Offset: 0x2A12381 VA: 0x2A12280
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A12C70 Offset: 0x2A12D71 VA: 0x2A12C70
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A13620 Offset: 0x2A13721 VA: 0x2A13620
	|-Dictionary.ValueCollection<Vector2, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A13FD0 Offset: 0x2A140D1 VA: 0x2A13FD0
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A14980 Offset: 0x2A14A81 VA: 0x2A14980
	|-Dictionary.ValueCollection<Vector3, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A15330 Offset: 0x2A15431 VA: 0x2A15330
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A15CE0 Offset: 0x2A15DE1 VA: 0x2A15CE0
	|-Dictionary.ValueCollection<Vector4, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2341510 Offset: 0x2341611 VA: 0x2341510
	|-Dictionary.ValueCollection<JSONDeserialization.TaskField, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2341EC0 Offset: 0x2341FC1 VA: 0x2341EC0
	|-Dictionary.ValueCollection<BitVector32Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2342870 Offset: 0x2342971 VA: 0x2342870
	|-Dictionary.ValueCollection<EventCheckId, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x28FD860 Offset: 0x28FD961 VA: 0x28FD860
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x28FE210 Offset: 0x28FE311 VA: 0x28FE210
	|-Dictionary.ValueCollection<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x28FEBC0 Offset: 0x28FECC1 VA: 0x28FEBC0
	|-Dictionary.ValueCollection<FarmManager.RF4_MCROP_INFO, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x28FF570 Offset: 0x28FF671 VA: 0x28FF570
	|-Dictionary.ValueCollection<FarmManager.RF4_SOIL_INFO, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x28FFF20 Offset: 0x2900021 VA: 0x28FFF20
	|-Dictionary.ValueCollection<MonsterHutSaveData, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29008D0 Offset: 0x29009D1 VA: 0x29008D0
	|-Dictionary.ValueCollection<OrderLotterySaveParameter, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2901280 Offset: 0x2901381 VA: 0x2901280
	|-Dictionary.ValueCollection<OrderSaveData, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2901C30 Offset: 0x2901D31 VA: 0x2901C30
	|-Dictionary.ValueCollection<OrderSaveParameter, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29025E0 Offset: 0x29026E1 VA: 0x29025E0
	|-Dictionary.ValueCollection<Parameter, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2902F90 Offset: 0x2903091 VA: 0x2902F90
	|-Dictionary.ValueCollection<bool, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2903940 Offset: 0x2903A41 VA: 0x2903940
	|-Dictionary.ValueCollection<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29042F0 Offset: 0x29043F1 VA: 0x29042F0
	|-Dictionary.ValueCollection<char, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2904CA0 Offset: 0x2904DA1 VA: 0x2904CA0
	|-Dictionary.ValueCollection<DateTime, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2905650 Offset: 0x2905751 VA: 0x2905650
	|-Dictionary.ValueCollection<double, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2906000 Offset: 0x2906101 VA: 0x2906000
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29069B0 Offset: 0x2906AB1 VA: 0x29069B0
	|-Dictionary.ValueCollection<short, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29074A0 Offset: 0x29075A1 VA: 0x29074A0
	|-Dictionary.ValueCollection<int, CropDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2907F20 Offset: 0x2908021 VA: 0x2907F20
	|-Dictionary.ValueCollection<int, EffectDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2908900 Offset: 0x2908A01 VA: 0x2908900
	|-Dictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29093F0 Offset: 0x29094F1 VA: 0x29093F0
	|-Dictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2909DF0 Offset: 0x2909EF1 VA: 0x2909DF0
	|-Dictionary.ValueCollection<int, MiningDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x290A7D0 Offset: 0x290A8D1 VA: 0x290A7D0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x290B1B0 Offset: 0x290B2B1 VA: 0x290B1B0
	|-Dictionary.ValueCollection<int, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x290BB90 Offset: 0x290BC91 VA: 0x290BB90
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x290C570 Offset: 0x290C671 VA: 0x290C570
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x290CF50 Offset: 0x290D051 VA: 0x290CF50
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x290D940 Offset: 0x290DA41 VA: 0x290D940
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x290E3D0 Offset: 0x290E4D1 VA: 0x290E3D0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x290EDD0 Offset: 0x290EED1 VA: 0x290EDD0
	|-Dictionary.ValueCollection<int, SceneInstance>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x290F7B0 Offset: 0x290F8B1 VA: 0x290F7B0
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29101A0 Offset: 0x29102A1 VA: 0x29101A0
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2910CB0 Offset: 0x2910DB1 VA: 0x2910CB0
	|-Dictionary.ValueCollection<Int32Enum, MonsterDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2911790 Offset: 0x2911891 VA: 0x2911790
	|-Dictionary.ValueCollection<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2912180 Offset: 0x2912281 VA: 0x2912180
	|-Dictionary.ValueCollection<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2912B60 Offset: 0x2912C61 VA: 0x2912B60
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2913540 Offset: 0x2913641 VA: 0x2913540
	|-Dictionary.ValueCollection<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C1340 Offset: 0x29C1441 VA: 0x29C1340
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C1D20 Offset: 0x29C1E21 VA: 0x29C1D20
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C2710 Offset: 0x29C2811 VA: 0x29C2710
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C30B0 Offset: 0x29C31B1 VA: 0x29C30B0
	|-Dictionary.ValueCollection<Int32Enum, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C3AB0 Offset: 0x29C3BB1 VA: 0x29C3AB0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C44A0 Offset: 0x29C45A1 VA: 0x29C44A0
	|-Dictionary.ValueCollection<Int32Enum, ValueTuple<float, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C4E90 Offset: 0x29C4F91 VA: 0x29C4E90
	|-Dictionary.ValueCollection<Int32Enum, TutorialUnlockFlagData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C5880 Offset: 0x29C5981 VA: 0x29C5880
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C6230 Offset: 0x29C6331 VA: 0x29C6230
	|-Dictionary.ValueCollection<Memory<object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C6BE0 Offset: 0x29C6CE1 VA: 0x29C6BE0
	|-Dictionary.ValueCollection<Nullable<Int32Enum>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C7590 Offset: 0x29C7691 VA: 0x29C7590
	|-Dictionary.ValueCollection<Nullable<Bounds>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C7F40 Offset: 0x29C8041 VA: 0x29C7F40
	|-Dictionary.ValueCollection<Nullable<BoundsInt>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C88F0 Offset: 0x29C89F1 VA: 0x29C88F0
	|-Dictionary.ValueCollection<Nullable<Color32>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C92A0 Offset: 0x29C93A1 VA: 0x29C92A0
	|-Dictionary.ValueCollection<Nullable<Color>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29C9C50 Offset: 0x29C9D51 VA: 0x29C9C50
	|-Dictionary.ValueCollection<Nullable<GradientAlphaKey>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CA600 Offset: 0x29CA701 VA: 0x29CA600
	|-Dictionary.ValueCollection<Nullable<GradientColorKey>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CAFB0 Offset: 0x29CB0B1 VA: 0x29CAFB0
	|-Dictionary.ValueCollection<Nullable<Keyframe>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CB960 Offset: 0x29CBA61 VA: 0x29CB960
	|-Dictionary.ValueCollection<Nullable<LayerMask>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CC310 Offset: 0x29CC411 VA: 0x29CC310
	|-Dictionary.ValueCollection<Nullable<Matrix4x4>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CCCC0 Offset: 0x29CCDC1 VA: 0x29CCCC0
	|-Dictionary.ValueCollection<Nullable<Quaternion>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CD670 Offset: 0x29CD771 VA: 0x29CD670
	|-Dictionary.ValueCollection<Nullable<RangeInt>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CE020 Offset: 0x29CE121 VA: 0x29CE020
	|-Dictionary.ValueCollection<Nullable<Rect>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CE9D0 Offset: 0x29CEAD1 VA: 0x29CE9D0
	|-Dictionary.ValueCollection<Nullable<RectInt>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CF380 Offset: 0x29CF481 VA: 0x29CF380
	|-Dictionary.ValueCollection<Nullable<Vector2>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29CFD30 Offset: 0x29CFE31 VA: 0x29CFD30
	|-Dictionary.ValueCollection<Nullable<Vector2Int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D06E0 Offset: 0x29D07E1 VA: 0x29D06E0
	|-Dictionary.ValueCollection<Nullable<Vector3>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D1090 Offset: 0x29D1191 VA: 0x29D1090
	|-Dictionary.ValueCollection<Nullable<Vector3Int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D1A40 Offset: 0x29D1B41 VA: 0x29D1A40
	|-Dictionary.ValueCollection<Nullable<Vector4>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D23E0 Offset: 0x29D24E1 VA: 0x29D23E0
	|-Dictionary.ValueCollection<object, BitVector32Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D2E60 Offset: 0x29D2F61 VA: 0x29D2E60
	|-Dictionary.ValueCollection<object, EventCheckId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D3960 Offset: 0x29D3A61 VA: 0x29D3960
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D43E0 Offset: 0x29D44E1 VA: 0x29D43E0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D4DD0 Offset: 0x29D4ED1 VA: 0x29D4DD0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_MCROP_INFO>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D57C0 Offset: 0x29D58C1 VA: 0x29D57C0
	|-Dictionary.ValueCollection<object, FarmManager.RF4_SOIL_INFO>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D6270 Offset: 0x29D6371 VA: 0x29D6270
	|-Dictionary.ValueCollection<object, MonsterHutSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29D6C70 Offset: 0x29D6D71 VA: 0x29D6C70
	|-Dictionary.ValueCollection<object, OrderLotterySaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29588A0 Offset: 0x29589A1 VA: 0x29588A0
	|-Dictionary.ValueCollection<object, OrderSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2959330 Offset: 0x2959431 VA: 0x2959330
	|-Dictionary.ValueCollection<object, OrderSaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2959E30 Offset: 0x2959F31 VA: 0x2959E30
	|-Dictionary.ValueCollection<object, Parameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x295A830 Offset: 0x295A931 VA: 0x295A830
	|-Dictionary.ValueCollection<object, NumberControl.ValueRange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x295B210 Offset: 0x295B311 VA: 0x295B210
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x295BBF0 Offset: 0x295BCF1 VA: 0x295BBF0
	|-Dictionary.ValueCollection<object, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x295C5D0 Offset: 0x295C6D1 VA: 0x295C5D0
	|-Dictionary.ValueCollection<object, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x295CFB0 Offset: 0x295D0B1 VA: 0x295CFB0
	|-Dictionary.ValueCollection<object, DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x295D990 Offset: 0x295DA91 VA: 0x295D990
	|-Dictionary.ValueCollection<object, double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x295E370 Offset: 0x295E471 VA: 0x295E370
	|-Dictionary.ValueCollection<object, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x295ED50 Offset: 0x295EE51 VA: 0x295ED50
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x295F730 Offset: 0x295F831 VA: 0x295F730
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2960110 Offset: 0x2960211 VA: 0x2960110
	|-Dictionary.ValueCollection<object, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2960B10 Offset: 0x2960C11 VA: 0x2960B10
	|-Dictionary.ValueCollection<object, Memory<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29614F0 Offset: 0x29615F1 VA: 0x29614F0
	|-Dictionary.ValueCollection<object, Nullable<Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2961F90 Offset: 0x2962091 VA: 0x2961F90
	|-Dictionary.ValueCollection<object, Nullable<Bounds>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2962A40 Offset: 0x2962B41 VA: 0x2962A40
	|-Dictionary.ValueCollection<object, Nullable<BoundsInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2963430 Offset: 0x2963531 VA: 0x2963430
	|-Dictionary.ValueCollection<object, Nullable<Color32>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2963EA0 Offset: 0x2963FA1 VA: 0x2963EA0
	|-Dictionary.ValueCollection<object, Nullable<Color>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2964890 Offset: 0x2964991 VA: 0x2964890
	|-Dictionary.ValueCollection<object, Nullable<GradientAlphaKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2965300 Offset: 0x2965401 VA: 0x2965300
	|-Dictionary.ValueCollection<object, Nullable<GradientColorKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2965D80 Offset: 0x2965E81 VA: 0x2965D80
	|-Dictionary.ValueCollection<object, Nullable<Keyframe>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2966760 Offset: 0x2966861 VA: 0x2966760
	|-Dictionary.ValueCollection<object, Nullable<LayerMask>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29672B0 Offset: 0x29673B1 VA: 0x29672B0
	|-Dictionary.ValueCollection<object, Nullable<Matrix4x4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2967D30 Offset: 0x2967E31 VA: 0x2967D30
	|-Dictionary.ValueCollection<object, Nullable<Quaternion>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2968720 Offset: 0x2968821 VA: 0x2968720
	|-Dictionary.ValueCollection<object, Nullable<RangeInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2969190 Offset: 0x2969291 VA: 0x2969190
	|-Dictionary.ValueCollection<object, Nullable<Rect>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2969C00 Offset: 0x2969D01 VA: 0x2969C00
	|-Dictionary.ValueCollection<object, Nullable<RectInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x296A5F0 Offset: 0x296A6F1 VA: 0x296A5F0
	|-Dictionary.ValueCollection<object, Nullable<Vector2>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x296AFE0 Offset: 0x296B0E1 VA: 0x296AFE0
	|-Dictionary.ValueCollection<object, Nullable<Vector2Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x296B9D0 Offset: 0x296BAD1 VA: 0x296B9D0
	|-Dictionary.ValueCollection<object, Nullable<Vector3>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x296C3C0 Offset: 0x296C4C1 VA: 0x296C3C0
	|-Dictionary.ValueCollection<object, Nullable<Vector3Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x296CE30 Offset: 0x296CF31 VA: 0x296CE30
	|-Dictionary.ValueCollection<object, Nullable<Vector4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x296D820 Offset: 0x296D921 VA: 0x296D820
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x296E1E0 Offset: 0x296E2E1 VA: 0x296E1E0
	|-Dictionary.ValueCollection<object, ReadOnlyMemory<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x296EBE0 Offset: 0x296ECE1 VA: 0x296EBE0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29EE080 Offset: 0x29EE181 VA: 0x29EE080
	|-Dictionary.ValueCollection<object, sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29EEA60 Offset: 0x29EEB61 VA: 0x29EEA60
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29EF440 Offset: 0x29EF541 VA: 0x29EF440
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29EFE20 Offset: 0x29EFF21 VA: 0x29EFE20
	|-Dictionary.ValueCollection<object, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F0800 Offset: 0x29F0901 VA: 0x29F0800
	|-Dictionary.ValueCollection<object, ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F1280 Offset: 0x29F1381 VA: 0x29F1280
	|-Dictionary.ValueCollection<object, TransitionTables>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F1CF0 Offset: 0x29F1DF1 VA: 0x29F1CF0
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F2760 Offset: 0x29F2861 VA: 0x29F2760
	|-Dictionary.ValueCollection<object, BoundsInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F3140 Offset: 0x29F3241 VA: 0x29F3140
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F3B30 Offset: 0x29F3C31 VA: 0x29F3B30
	|-Dictionary.ValueCollection<object, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F4520 Offset: 0x29F4621 VA: 0x29F4520
	|-Dictionary.ValueCollection<object, GradientAlphaKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F4F90 Offset: 0x29F5091 VA: 0x29F4F90
	|-Dictionary.ValueCollection<object, GradientColorKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F5A30 Offset: 0x29F5B31 VA: 0x29F5A30
	|-Dictionary.ValueCollection<object, Keyframe>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F6420 Offset: 0x29F6521 VA: 0x29F6420
	|-Dictionary.ValueCollection<object, LayerMask>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F6F10 Offset: 0x29F7011 VA: 0x29F6F10
	|-Dictionary.ValueCollection<object, Matrix4x4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F7900 Offset: 0x29F7A01 VA: 0x29F7900
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F82F0 Offset: 0x29F83F1 VA: 0x29F82F0
	|-Dictionary.ValueCollection<object, Quaternion>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F8CD0 Offset: 0x29F8DD1 VA: 0x29F8CD0
	|-Dictionary.ValueCollection<object, RangeInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29F96C0 Offset: 0x29F97C1 VA: 0x29F96C0
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FA0B0 Offset: 0x29FA1B1 VA: 0x29FA0B0
	|-Dictionary.ValueCollection<object, RectInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FAB30 Offset: 0x29FAC31 VA: 0x29FAB30
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FB5B0 Offset: 0x29FB6B1 VA: 0x29FB5B0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FBFA0 Offset: 0x29FC0A1 VA: 0x29FBFA0
	|-Dictionary.ValueCollection<object, Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FC980 Offset: 0x29FCA81 VA: 0x29FC980
	|-Dictionary.ValueCollection<object, Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FD370 Offset: 0x29FD471 VA: 0x29FD370
	|-Dictionary.ValueCollection<object, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FDD60 Offset: 0x29FDE61 VA: 0x29FDD60
	|-Dictionary.ValueCollection<object, Vector3Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FE750 Offset: 0x29FE851 VA: 0x29FE750
	|-Dictionary.ValueCollection<object, Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FF140 Offset: 0x29FF241 VA: 0x29FF140
	|-Dictionary.ValueCollection<ReadOnlyMemory<object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x29FFAE0 Offset: 0x29FFBE1 VA: 0x29FFAE0
	|-Dictionary.ValueCollection<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A004D0 Offset: 0x2A005D1 VA: 0x2A004D0
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A00FD0 Offset: 0x2A010D1 VA: 0x2A00FD0
	|-Dictionary.ValueCollection<float, CurveSample>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A019D0 Offset: 0x2A01AD1 VA: 0x2A019D0
	|-Dictionary.ValueCollection<float, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A02380 Offset: 0x2A02481 VA: 0x2A02380
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A02D20 Offset: 0x2A02E21 VA: 0x2A02D20
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A03700 Offset: 0x2A03801 VA: 0x2A03700
	|-Dictionary.ValueCollection<uint, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A040F0 Offset: 0x2A041F1 VA: 0x2A040F0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A04AA0 Offset: 0x2A04BA1 VA: 0x2A04AA0
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A05440 Offset: 0x2A05541 VA: 0x2A05440
	|-Dictionary.ValueCollection<EdgeKeyByHash, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A05EF0 Offset: 0x2A05FF1 VA: 0x2A05EF0
	|-Dictionary.ValueCollection<EdgeKeyByHash, CapEdge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A069D0 Offset: 0x2A06AD1 VA: 0x2A069D0
	|-Dictionary.ValueCollection<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A07440 Offset: 0x2A07541 VA: 0x2A07440
	|-Dictionary.ValueCollection<EdgeKeyByIndex, ClippedEdge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A07E20 Offset: 0x2A07F21 VA: 0x2A07E20
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A08810 Offset: 0x2A08911 VA: 0x2A08810
	|-Dictionary.ValueCollection<MeshDataConnectivity.Face, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A091C0 Offset: 0x2A092C1 VA: 0x2A091C0
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A09B70 Offset: 0x2A09C71 VA: 0x2A09B70
	|-Dictionary.ValueCollection<BoundsInt, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0A520 Offset: 0x2A0A621 VA: 0x2A0A520
	|-Dictionary.ValueCollection<Color, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0AED0 Offset: 0x2A0AFD1 VA: 0x2A0AED0
	|-Dictionary.ValueCollection<Color32, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0B880 Offset: 0x2A0B981 VA: 0x2A0B880
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0C230 Offset: 0x2A0C331 VA: 0x2A0C230
	|-Dictionary.ValueCollection<GradientAlphaKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0CBE0 Offset: 0x2A0CCE1 VA: 0x2A0CBE0
	|-Dictionary.ValueCollection<GradientColorKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0D590 Offset: 0x2A0D691 VA: 0x2A0D590
	|-Dictionary.ValueCollection<Keyframe, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0DF40 Offset: 0x2A0E041 VA: 0x2A0DF40
	|-Dictionary.ValueCollection<LayerMask, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0E8F0 Offset: 0x2A0E9F1 VA: 0x2A0E8F0
	|-Dictionary.ValueCollection<Matrix4x4, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0F2A0 Offset: 0x2A0F3A1 VA: 0x2A0F2A0
	|-Dictionary.ValueCollection<IntVec3, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A0FC50 Offset: 0x2A0FD51 VA: 0x2A0FC50
	|-Dictionary.ValueCollection<Quaternion, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A10600 Offset: 0x2A10701 VA: 0x2A10600
	|-Dictionary.ValueCollection<RangeInt, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A10FB0 Offset: 0x2A110B1 VA: 0x2A10FB0
	|-Dictionary.ValueCollection<Rect, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A11960 Offset: 0x2A11A61 VA: 0x2A11960
	|-Dictionary.ValueCollection<RectInt, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A12300 Offset: 0x2A12401 VA: 0x2A12300
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A12CF0 Offset: 0x2A12DF1 VA: 0x2A12CF0
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A136A0 Offset: 0x2A137A1 VA: 0x2A136A0
	|-Dictionary.ValueCollection<Vector2, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A14050 Offset: 0x2A14151 VA: 0x2A14050
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A14A00 Offset: 0x2A14B01 VA: 0x2A14A00
	|-Dictionary.ValueCollection<Vector3, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A153B0 Offset: 0x2A154B1 VA: 0x2A153B0
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A15D60 Offset: 0x2A15E61 VA: 0x2A15D60
	|-Dictionary.ValueCollection<Vector4, object>.System.Collections.ICollection.CopyTo
	*/
}

