private class Enumerable.WhereArrayIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 2166
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF44C0 Offset: 0x2BF45C1 VA: 0x2BF44C0
	|-Enumerable.WhereArrayIterator<CropDataTable>..ctor
	|
	|-RVA: 0x2BF47D0 Offset: 0x2BF48D1 VA: 0x2BF47D0
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2BF4A20 Offset: 0x2BF4B21 VA: 0x2BF4A20
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2BF4C70 Offset: 0x2BF4D71 VA: 0x2BF4C70
	|-Enumerable.WhereArrayIterator<Int32Enum>..ctor
	|
	|-RVA: 0x2BF4EB0 Offset: 0x2BF4FB1 VA: 0x2BF4EB0
	|-Enumerable.WhereArrayIterator<object>..ctor
	|
	|-RVA: 0x2BF50F0 Offset: 0x2BF51F1 VA: 0x2BF50F0
	|-Enumerable.WhereArrayIterator<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2BF5330 Offset: 0x2BF5431 VA: 0x2BF5330
	|-Enumerable.WhereArrayIterator<ValueTuple<object, Int32Enum>>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4530 Offset: 0x2BF4631 VA: 0x2BF4530
	|-Enumerable.WhereArrayIterator<CropDataTable>.Clone
	|
	|-RVA: 0x2BF4840 Offset: 0x2BF4941 VA: 0x2BF4840
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x2BF4A90 Offset: 0x2BF4B91 VA: 0x2BF4A90
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Clone
	|
	|-RVA: 0x2BF4CE0 Offset: 0x2BF4DE1 VA: 0x2BF4CE0
	|-Enumerable.WhereArrayIterator<Int32Enum>.Clone
	|
	|-RVA: 0x2BF4F20 Offset: 0x2BF5021 VA: 0x2BF4F20
	|-Enumerable.WhereArrayIterator<object>.Clone
	|
	|-RVA: 0x2BF5160 Offset: 0x2BF5261 VA: 0x2BF5160
	|-Enumerable.WhereArrayIterator<ValueTuple<Int32Enum, int>>.Clone
	|
	|-RVA: 0x2BF53A0 Offset: 0x2BF54A1 VA: 0x2BF53A0
	|-Enumerable.WhereArrayIterator<ValueTuple<object, Int32Enum>>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF45A0 Offset: 0x2BF46A1 VA: 0x2BF45A0
	|-Enumerable.WhereArrayIterator<CropDataTable>.MoveNext
	|
	|-RVA: 0x2BF48B0 Offset: 0x2BF49B1 VA: 0x2BF48B0
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x2BF4B00 Offset: 0x2BF4C01 VA: 0x2BF4B00
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x2BF4D50 Offset: 0x2BF4E51 VA: 0x2BF4D50
	|-Enumerable.WhereArrayIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x2BF4F90 Offset: 0x2BF5091 VA: 0x2BF4F90
	|-Enumerable.WhereArrayIterator<object>.MoveNext
	|
	|-RVA: 0x2BF51D0 Offset: 0x2BF52D1 VA: 0x2BF51D0
	|-Enumerable.WhereArrayIterator<ValueTuple<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2BF5410 Offset: 0x2BF5511 VA: 0x2BF5410
	|-Enumerable.WhereArrayIterator<ValueTuple<object, Int32Enum>>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2127EB0 Offset: 0x2127FB1 VA: 0x2127EB0
	|-Enumerable.WhereArrayIterator<CropDataTable>.Select<int>
	|
	|-RVA: 0x2127F30 Offset: 0x2128031 VA: 0x2127F30
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Select<object>
	|
	|-RVA: 0x2127FB0 Offset: 0x21280B1 VA: 0x2127FB0
	|-Enumerable.WhereArrayIterator<Int32Enum>.Select<object>
	|
	|-RVA: 0x2128030 Offset: 0x2128131 VA: 0x2128030
	|-Enumerable.WhereArrayIterator<Int32Enum>.Select<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x21280B0 Offset: 0x21281B1 VA: 0x21280B0
	|-Enumerable.WhereArrayIterator<object>.Select<CropDataTable>
	|
	|-RVA: 0x2128130 Offset: 0x2128231 VA: 0x2128130
	|-Enumerable.WhereArrayIterator<object>.Select<int>
	|
	|-RVA: 0x21281B0 Offset: 0x21282B1 VA: 0x21281B0
	|-Enumerable.WhereArrayIterator<object>.Select<Int32Enum>
	|
	|-RVA: 0x2128230 Offset: 0x2128331 VA: 0x2128230
	|-Enumerable.WhereArrayIterator<object>.Select<object>
	|
	|-RVA: 0x21282B0 Offset: 0x21283B1 VA: 0x21282B0
	|-Enumerable.WhereArrayIterator<object>.Select<Label>
	|
	|-RVA: 0x2128330 Offset: 0x2128431 VA: 0x2128330
	|-Enumerable.WhereArrayIterator<object>.Select<float>
	|
	|-RVA: 0x21283B0 Offset: 0x21284B1 VA: 0x21283B0
	|-Enumerable.WhereArrayIterator<object>.Select<Vector2>
	|
	|-RVA: 0x2128430 Offset: 0x2128531 VA: 0x2128430
	|-Enumerable.WhereArrayIterator<object>.Select<Vector3>
	|
	|-RVA: 0x21284B0 Offset: 0x21285B1 VA: 0x21284B0
	|-Enumerable.WhereArrayIterator<ValueTuple<object, Int32Enum>>.Select<Int32Enum>
	|
	|-RVA: 0x2128530 Offset: 0x2128631 VA: 0x2128530
	|-Enumerable.WhereArrayIterator<ValueTuple<object, Int32Enum>>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4740 Offset: 0x2BF4841 VA: 0x2BF4740
	|-Enumerable.WhereArrayIterator<CropDataTable>.Where
	|
	|-RVA: 0x2BF4990 Offset: 0x2BF4A91 VA: 0x2BF4990
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x2BF4BE0 Offset: 0x2BF4CE1 VA: 0x2BF4BE0
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Where
	|
	|-RVA: 0x2BF4E20 Offset: 0x2BF4F21 VA: 0x2BF4E20
	|-Enumerable.WhereArrayIterator<Int32Enum>.Where
	|
	|-RVA: 0x2BF5060 Offset: 0x2BF5161 VA: 0x2BF5060
	|-Enumerable.WhereArrayIterator<object>.Where
	|
	|-RVA: 0x2BF52A0 Offset: 0x2BF53A1 VA: 0x2BF52A0
	|-Enumerable.WhereArrayIterator<ValueTuple<Int32Enum, int>>.Where
	|
	|-RVA: 0x2BF54F0 Offset: 0x2BF55F1 VA: 0x2BF54F0
	|-Enumerable.WhereArrayIterator<ValueTuple<object, Int32Enum>>.Where
	*/
}

