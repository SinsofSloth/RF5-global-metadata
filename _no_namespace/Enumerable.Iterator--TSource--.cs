private abstract class Enumerable.Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2164
{
	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2A50 Offset: 0x2BF2B51 VA: 0x2BF2A50
	|-Enumerable.Iterator<CropDataTable>..ctor
	|
	|-RVA: 0x2BF2C90 Offset: 0x2BF2D91 VA: 0x2BF2C90
	|-Enumerable.Iterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2BF2E70 Offset: 0x2BF2F71 VA: 0x2BF2E70
	|-Enumerable.Iterator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2BF3050 Offset: 0x2BF3151 VA: 0x2BF3050
	|-Enumerable.Iterator<int>..ctor
	|
	|-RVA: 0x2BF3230 Offset: 0x2BF3331 VA: 0x2BF3230
	|-Enumerable.Iterator<Int32Enum>..ctor
	|
	|-RVA: 0x2BF3410 Offset: 0x2BF3511 VA: 0x2BF3410
	|-Enumerable.Iterator<object>..ctor
	|
	|-RVA: 0x2BF35B0 Offset: 0x2BF36B1 VA: 0x2BF35B0
	|-Enumerable.Iterator<Label>..ctor
	|
	|-RVA: 0x2BF3790 Offset: 0x2BF3891 VA: 0x2BF3790
	|-Enumerable.Iterator<float>..ctor
	|
	|-RVA: 0x2BF3970 Offset: 0x2BF3A71 VA: 0x2BF3970
	|-Enumerable.Iterator<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2BF3B50 Offset: 0x2BF3C51 VA: 0x2BF3B50
	|-Enumerable.Iterator<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2BF3D30 Offset: 0x2BF3E31 VA: 0x2BF3D30
	|-Enumerable.Iterator<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x2BF3F10 Offset: 0x2BF4011 VA: 0x2BF3F10
	|-Enumerable.Iterator<Vector2>..ctor
	|
	|-RVA: 0x2BF40F0 Offset: 0x2BF41F1 VA: 0x2BF40F0
	|-Enumerable.Iterator<Vector3>..ctor
	|
	|-RVA: 0x2BF42E0 Offset: 0x2BF43E1 VA: 0x2BF42E0
	|-Enumerable.Iterator<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2AA0 Offset: 0x2BF2BA1 VA: 0x2BF2AA0
	|-Enumerable.Iterator<CropDataTable>.get_Current
	|
	|-RVA: 0x2BF2CE0 Offset: 0x2BF2DE1 VA: 0x2BF2CE0
	|-Enumerable.Iterator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x2BF2EC0 Offset: 0x2BF2FC1 VA: 0x2BF2EC0
	|-Enumerable.Iterator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x2BF30A0 Offset: 0x2BF31A1 VA: 0x2BF30A0
	|-Enumerable.Iterator<int>.get_Current
	|
	|-RVA: 0x2BF3280 Offset: 0x2BF3381 VA: 0x2BF3280
	|-Enumerable.Iterator<Int32Enum>.get_Current
	|
	|-RVA: 0x2BF3460 Offset: 0x2BF3561 VA: 0x2BF3460
	|-Enumerable.Iterator<object>.get_Current
	|
	|-RVA: 0x2BF3600 Offset: 0x2BF3701 VA: 0x2BF3600
	|-Enumerable.Iterator<Label>.get_Current
	|
	|-RVA: 0x2BF37E0 Offset: 0x2BF38E1 VA: 0x2BF37E0
	|-Enumerable.Iterator<float>.get_Current
	|
	|-RVA: 0x2BF39C0 Offset: 0x2BF3AC1 VA: 0x2BF39C0
	|-Enumerable.Iterator<ValueTuple<bool, Int32Enum>>.get_Current
	|
	|-RVA: 0x2BF3BA0 Offset: 0x2BF3CA1 VA: 0x2BF3BA0
	|-Enumerable.Iterator<ValueTuple<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2BF3D80 Offset: 0x2BF3E81 VA: 0x2BF3D80
	|-Enumerable.Iterator<ValueTuple<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x2BF3F60 Offset: 0x2BF4061 VA: 0x2BF3F60
	|-Enumerable.Iterator<Vector2>.get_Current
	|
	|-RVA: 0x2BF4140 Offset: 0x2BF4241 VA: 0x2BF4140
	|-Enumerable.Iterator<Vector3>.get_Current
	|
	|-RVA: 0x2BF4330 Offset: 0x2BF4431 VA: 0x2BF4330
	|-Enumerable.Iterator<Vector4>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2AC0 Offset: 0x2BF2BC1 VA: 0x2BF2AC0
	|-Enumerable.Iterator<CropDataTable>.Dispose
	|
	|-RVA: 0x2BF2CF0 Offset: 0x2BF2DF1 VA: 0x2BF2CF0
	|-Enumerable.Iterator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x2BF2ED0 Offset: 0x2BF2FD1 VA: 0x2BF2ED0
	|-Enumerable.Iterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x2BF30B0 Offset: 0x2BF31B1 VA: 0x2BF30B0
	|-Enumerable.Iterator<int>.Dispose
	|
	|-RVA: 0x2BF3290 Offset: 0x2BF3391 VA: 0x2BF3290
	|-Enumerable.Iterator<Int32Enum>.Dispose
	|
	|-RVA: 0x2BF3470 Offset: 0x2BF3571 VA: 0x2BF3470
	|-Enumerable.Iterator<object>.Dispose
	|
	|-RVA: 0x2BF3610 Offset: 0x2BF3711 VA: 0x2BF3610
	|-Enumerable.Iterator<Label>.Dispose
	|
	|-RVA: 0x2BF37F0 Offset: 0x2BF38F1 VA: 0x2BF37F0
	|-Enumerable.Iterator<float>.Dispose
	|
	|-RVA: 0x2BF39D0 Offset: 0x2BF3AD1 VA: 0x2BF39D0
	|-Enumerable.Iterator<ValueTuple<bool, Int32Enum>>.Dispose
	|
	|-RVA: 0x2BF3BB0 Offset: 0x2BF3CB1 VA: 0x2BF3BB0
	|-Enumerable.Iterator<ValueTuple<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2BF3D90 Offset: 0x2BF3E91 VA: 0x2BF3D90
	|-Enumerable.Iterator<ValueTuple<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x2BF3F70 Offset: 0x2BF4071 VA: 0x2BF3F70
	|-Enumerable.Iterator<Vector2>.Dispose
	|
	|-RVA: 0x2BF4150 Offset: 0x2BF4251 VA: 0x2BF4150
	|-Enumerable.Iterator<Vector3>.Dispose
	|
	|-RVA: 0x2BF4340 Offset: 0x2BF4441 VA: 0x2BF4340
	|-Enumerable.Iterator<Vector4>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2B10 Offset: 0x2BF2C11 VA: 0x2BF2B10
	|-Enumerable.Iterator<CropDataTable>.GetEnumerator
	|
	|-RVA: 0x2BF2D00 Offset: 0x2BF2E01 VA: 0x2BF2D00
	|-Enumerable.Iterator<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x2BF2EE0 Offset: 0x2BF2FE1 VA: 0x2BF2EE0
	|-Enumerable.Iterator<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x2BF30C0 Offset: 0x2BF31C1 VA: 0x2BF30C0
	|-Enumerable.Iterator<int>.GetEnumerator
	|
	|-RVA: 0x2BF32A0 Offset: 0x2BF33A1 VA: 0x2BF32A0
	|-Enumerable.Iterator<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2BF3480 Offset: 0x2BF3581 VA: 0x2BF3480
	|-Enumerable.Iterator<object>.GetEnumerator
	|
	|-RVA: 0x2BF3620 Offset: 0x2BF3721 VA: 0x2BF3620
	|-Enumerable.Iterator<Label>.GetEnumerator
	|
	|-RVA: 0x2BF3800 Offset: 0x2BF3901 VA: 0x2BF3800
	|-Enumerable.Iterator<float>.GetEnumerator
	|
	|-RVA: 0x2BF39E0 Offset: 0x2BF3AE1 VA: 0x2BF39E0
	|-Enumerable.Iterator<ValueTuple<bool, Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x2BF3BC0 Offset: 0x2BF3CC1 VA: 0x2BF3BC0
	|-Enumerable.Iterator<ValueTuple<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x2BF3DA0 Offset: 0x2BF3EA1 VA: 0x2BF3DA0
	|-Enumerable.Iterator<ValueTuple<object, Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x2BF3F80 Offset: 0x2BF4081 VA: 0x2BF3F80
	|-Enumerable.Iterator<Vector2>.GetEnumerator
	|
	|-RVA: 0x2BF4170 Offset: 0x2BF4271 VA: 0x2BF4170
	|-Enumerable.Iterator<Vector3>.GetEnumerator
	|
	|-RVA: 0x2BF4350 Offset: 0x2BF4451 VA: 0x2BF4350
	|-Enumerable.Iterator<Vector4>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Where
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2B80 Offset: 0x2BF2C81 VA: 0x2BF2B80
	|-Enumerable.Iterator<CropDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF2D70 Offset: 0x2BF2E71 VA: 0x2BF2D70
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF2F50 Offset: 0x2BF3051 VA: 0x2BF2F50
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF3130 Offset: 0x2BF3231 VA: 0x2BF3130
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF3310 Offset: 0x2BF3411 VA: 0x2BF3310
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF34F0 Offset: 0x2BF35F1 VA: 0x2BF34F0
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF3690 Offset: 0x2BF3791 VA: 0x2BF3690
	|-Enumerable.Iterator<Label>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF3870 Offset: 0x2BF3971 VA: 0x2BF3870
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF3A50 Offset: 0x2BF3B51 VA: 0x2BF3A50
	|-Enumerable.Iterator<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF3C30 Offset: 0x2BF3D31 VA: 0x2BF3C30
	|-Enumerable.Iterator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF3E10 Offset: 0x2BF3F11 VA: 0x2BF3E10
	|-Enumerable.Iterator<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF3FF0 Offset: 0x2BF40F1 VA: 0x2BF3FF0
	|-Enumerable.Iterator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF41E0 Offset: 0x2BF42E1 VA: 0x2BF41E0
	|-Enumerable.Iterator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF43C0 Offset: 0x2BF44C1 VA: 0x2BF43C0
	|-Enumerable.Iterator<Vector4>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2C00 Offset: 0x2BF2D01 VA: 0x2BF2C00
	|-Enumerable.Iterator<CropDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF2DE0 Offset: 0x2BF2EE1 VA: 0x2BF2DE0
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF2FC0 Offset: 0x2BF30C1 VA: 0x2BF2FC0
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF31A0 Offset: 0x2BF32A1 VA: 0x2BF31A0
	|-Enumerable.Iterator<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF3380 Offset: 0x2BF3481 VA: 0x2BF3380
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF3520 Offset: 0x2BF3621 VA: 0x2BF3520
	|-Enumerable.Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF3700 Offset: 0x2BF3801 VA: 0x2BF3700
	|-Enumerable.Iterator<Label>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF38E0 Offset: 0x2BF39E1 VA: 0x2BF38E0
	|-Enumerable.Iterator<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF3AC0 Offset: 0x2BF3BC1 VA: 0x2BF3AC0
	|-Enumerable.Iterator<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF3CA0 Offset: 0x2BF3DA1 VA: 0x2BF3CA0
	|-Enumerable.Iterator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF3E80 Offset: 0x2BF3F81 VA: 0x2BF3E80
	|-Enumerable.Iterator<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF4060 Offset: 0x2BF4161 VA: 0x2BF4060
	|-Enumerable.Iterator<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF4250 Offset: 0x2BF4351 VA: 0x2BF4250
	|-Enumerable.Iterator<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF4430 Offset: 0x2BF4531 VA: 0x2BF4430
	|-Enumerable.Iterator<Vector4>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2C30 Offset: 0x2BF2D31 VA: 0x2BF2C30
	|-Enumerable.Iterator<CropDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF2E10 Offset: 0x2BF2F11 VA: 0x2BF2E10
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF2FF0 Offset: 0x2BF30F1 VA: 0x2BF2FF0
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF31D0 Offset: 0x2BF32D1 VA: 0x2BF31D0
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF33B0 Offset: 0x2BF34B1 VA: 0x2BF33B0
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF3550 Offset: 0x2BF3651 VA: 0x2BF3550
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF3730 Offset: 0x2BF3831 VA: 0x2BF3730
	|-Enumerable.Iterator<Label>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF3910 Offset: 0x2BF3A11 VA: 0x2BF3910
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF3AF0 Offset: 0x2BF3BF1 VA: 0x2BF3AF0
	|-Enumerable.Iterator<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF3CD0 Offset: 0x2BF3DD1 VA: 0x2BF3CD0
	|-Enumerable.Iterator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF3EB0 Offset: 0x2BF3FB1 VA: 0x2BF3EB0
	|-Enumerable.Iterator<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF4090 Offset: 0x2BF4191 VA: 0x2BF4090
	|-Enumerable.Iterator<Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF4280 Offset: 0x2BF4381 VA: 0x2BF4280
	|-Enumerable.Iterator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF4460 Offset: 0x2BF4561 VA: 0x2BF4460
	|-Enumerable.Iterator<Vector4>.System.Collections.IEnumerator.Reset
	*/
}

