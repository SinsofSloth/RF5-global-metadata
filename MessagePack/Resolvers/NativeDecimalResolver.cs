public sealed class NativeDecimalResolver : IFormatterResolver // TypeDefIndex: 5260
{
	// Fields
	public static readonly NativeDecimalResolver Instance; // 0x0

	// Methods

	// RVA: 0x14F8810 Offset: 0x14F8911 VA: 0x14F8810
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1832900 Offset: 0x1832A01 VA: 0x1832900
	|-NativeDecimalResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x18329B0 Offset: 0x1832AB1 VA: 0x18329B0
	|-NativeDecimalResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x1832A60 Offset: 0x1832B61 VA: 0x1832A60
	|-NativeDecimalResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1832B10 Offset: 0x1832C11 VA: 0x1832B10
	|-NativeDecimalResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1832BC0 Offset: 0x1832CC1 VA: 0x1832BC0
	|-NativeDecimalResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1832C70 Offset: 0x1832D71 VA: 0x1832C70
	|-NativeDecimalResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1832D20 Offset: 0x1832E21 VA: 0x1832D20
	|-NativeDecimalResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x1832DD0 Offset: 0x1832ED1 VA: 0x1832DD0
	|-NativeDecimalResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x1832E80 Offset: 0x1832F81 VA: 0x1832E80
	|-NativeDecimalResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x1832F30 Offset: 0x1833031 VA: 0x1832F30
	|-NativeDecimalResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x1832FE0 Offset: 0x18330E1 VA: 0x1832FE0
	|-NativeDecimalResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x1833090 Offset: 0x1833191 VA: 0x1833090
	|-NativeDecimalResolver.GetFormatter<bool>
	|
	|-RVA: 0x1833140 Offset: 0x1833241 VA: 0x1833140
	|-NativeDecimalResolver.GetFormatter<byte>
	|
	|-RVA: 0x18331F0 Offset: 0x18332F1 VA: 0x18331F0
	|-NativeDecimalResolver.GetFormatter<char>
	|
	|-RVA: 0x18332A0 Offset: 0x18333A1 VA: 0x18332A0
	|-NativeDecimalResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x1833350 Offset: 0x1833451 VA: 0x1833350
	|-NativeDecimalResolver.GetFormatter<double>
	|
	|-RVA: 0x1833400 Offset: 0x1833501 VA: 0x1833400
	|-NativeDecimalResolver.GetFormatter<short>
	|
	|-RVA: 0x18334B0 Offset: 0x18335B1 VA: 0x18334B0
	|-NativeDecimalResolver.GetFormatter<int>
	|
	|-RVA: 0x1833560 Offset: 0x1833661 VA: 0x1833560
	|-NativeDecimalResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x1833610 Offset: 0x1833711 VA: 0x1833610
	|-NativeDecimalResolver.GetFormatter<long>
	|
	|-RVA: 0x18336C0 Offset: 0x18337C1 VA: 0x18336C0
	|-NativeDecimalResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x1833770 Offset: 0x1833871 VA: 0x1833770
	|-NativeDecimalResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x1833820 Offset: 0x1833921 VA: 0x1833820
	|-NativeDecimalResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x18338D0 Offset: 0x18339D1 VA: 0x18338D0
	|-NativeDecimalResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x1833980 Offset: 0x1833A81 VA: 0x1833980
	|-NativeDecimalResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x1833A30 Offset: 0x1833B31 VA: 0x1833A30
	|-NativeDecimalResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x1833AE0 Offset: 0x1833BE1 VA: 0x1833AE0
	|-NativeDecimalResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1833B90 Offset: 0x1833C91 VA: 0x1833B90
	|-NativeDecimalResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1833C40 Offset: 0x1833D41 VA: 0x1833C40
	|-NativeDecimalResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x1833CF0 Offset: 0x1833DF1 VA: 0x1833CF0
	|-NativeDecimalResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x1833DA0 Offset: 0x1833EA1 VA: 0x1833DA0
	|-NativeDecimalResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1833E50 Offset: 0x1833F51 VA: 0x1833E50
	|-NativeDecimalResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x1833F00 Offset: 0x1834001 VA: 0x1833F00
	|-NativeDecimalResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x1833FB0 Offset: 0x18340B1 VA: 0x1833FB0
	|-NativeDecimalResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x1834060 Offset: 0x1834161 VA: 0x1834060
	|-NativeDecimalResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x1834110 Offset: 0x1834211 VA: 0x1834110
	|-NativeDecimalResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x18341C0 Offset: 0x18342C1 VA: 0x18341C0
	|-NativeDecimalResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x1834270 Offset: 0x1834371 VA: 0x1834270
	|-NativeDecimalResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x1834320 Offset: 0x1834421 VA: 0x1834320
	|-NativeDecimalResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x18343D0 Offset: 0x18344D1 VA: 0x18343D0
	|-NativeDecimalResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x1834480 Offset: 0x1834581 VA: 0x1834480
	|-NativeDecimalResolver.GetFormatter<object>
	|
	|-RVA: 0x1834530 Offset: 0x1834631 VA: 0x1834530
	|-NativeDecimalResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x18345E0 Offset: 0x18346E1 VA: 0x18345E0
	|-NativeDecimalResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x1834690 Offset: 0x1834791 VA: 0x1834690
	|-NativeDecimalResolver.GetFormatter<float>
	|
	|-RVA: 0x1834740 Offset: 0x1834841 VA: 0x1834740
	|-NativeDecimalResolver.GetFormatter<ushort>
	|
	|-RVA: 0x18347F0 Offset: 0x18348F1 VA: 0x18347F0
	|-NativeDecimalResolver.GetFormatter<uint>
	|
	|-RVA: 0x18348A0 Offset: 0x18349A1 VA: 0x18348A0
	|-NativeDecimalResolver.GetFormatter<ulong>
	|
	|-RVA: 0x1834950 Offset: 0x1834A51 VA: 0x1834950
	|-NativeDecimalResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x1834A00 Offset: 0x1834B01 VA: 0x1834A00
	|-NativeDecimalResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x1834AB0 Offset: 0x1834BB1 VA: 0x1834AB0
	|-NativeDecimalResolver.GetFormatter<Color32>
	|
	|-RVA: 0x1834B60 Offset: 0x1834C61 VA: 0x1834B60
	|-NativeDecimalResolver.GetFormatter<Color>
	|
	|-RVA: 0x1834C10 Offset: 0x1834D11 VA: 0x1834C10
	|-NativeDecimalResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x27F8D80 Offset: 0x27F8E81 VA: 0x27F8D80
	|-NativeDecimalResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x27F8E30 Offset: 0x27F8F31 VA: 0x27F8E30
	|-NativeDecimalResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x27F8EE0 Offset: 0x27F8FE1 VA: 0x27F8EE0
	|-NativeDecimalResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x27F8F90 Offset: 0x27F9091 VA: 0x27F8F90
	|-NativeDecimalResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x27F9040 Offset: 0x27F9141 VA: 0x27F9040
	|-NativeDecimalResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x27F90F0 Offset: 0x27F91F1 VA: 0x27F90F0
	|-NativeDecimalResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x27F91A0 Offset: 0x27F92A1 VA: 0x27F91A0
	|-NativeDecimalResolver.GetFormatter<Rect>
	|
	|-RVA: 0x27F9250 Offset: 0x27F9351 VA: 0x27F9250
	|-NativeDecimalResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x27F9300 Offset: 0x27F9401 VA: 0x27F9300
	|-NativeDecimalResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x27F93B0 Offset: 0x27F94B1 VA: 0x27F93B0
	|-NativeDecimalResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x27F9460 Offset: 0x27F9561 VA: 0x27F9460
	|-NativeDecimalResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x27F9510 Offset: 0x27F9611 VA: 0x27F9510
	|-NativeDecimalResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x27F95C0 Offset: 0x27F96C1 VA: 0x27F95C0
	|-NativeDecimalResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14F8820 Offset: 0x14F8921 VA: 0x14F8820
	private static object GetFormatterHelper(Type t) { }

	// RVA: 0x14F8990 Offset: 0x14F8A91 VA: 0x14F8990
	private static void .cctor() { }
}

