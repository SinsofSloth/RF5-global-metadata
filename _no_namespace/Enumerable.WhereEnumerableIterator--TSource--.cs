private class Enumerable.WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 2165
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5580 Offset: 0x2BF5681 VA: 0x2BF5580
	|-Enumerable.WhereEnumerableIterator<CropDataTable>..ctor
	|
	|-RVA: 0x2BF5B20 Offset: 0x2BF5C21 VA: 0x2BF5B20
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2BF6010 Offset: 0x2BF6111 VA: 0x2BF6010
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2BF6500 Offset: 0x2BF6601 VA: 0x2BF6500
	|-Enumerable.WhereEnumerableIterator<int>..ctor
	|
	|-RVA: 0x2BF69E0 Offset: 0x2BF6AE1 VA: 0x2BF69E0
	|-Enumerable.WhereEnumerableIterator<Int32Enum>..ctor
	|
	|-RVA: 0x2BF6EC0 Offset: 0x2BF6FC1 VA: 0x2BF6EC0
	|-Enumerable.WhereEnumerableIterator<object>..ctor
	|
	|-RVA: 0x2BF73A0 Offset: 0x2BF74A1 VA: 0x2BF73A0
	|-Enumerable.WhereEnumerableIterator<Label>..ctor
	|
	|-RVA: 0x2BF7880 Offset: 0x2BF7981 VA: 0x2BF7880
	|-Enumerable.WhereEnumerableIterator<float>..ctor
	|
	|-RVA: 0x2BF7D50 Offset: 0x2BF7E51 VA: 0x2BF7D50
	|-Enumerable.WhereEnumerableIterator<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2BF8230 Offset: 0x2BF8331 VA: 0x2BF8230
	|-Enumerable.WhereEnumerableIterator<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2BF8710 Offset: 0x2BF8811 VA: 0x2BF8710
	|-Enumerable.WhereEnumerableIterator<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x2BF8C00 Offset: 0x2BF8D01 VA: 0x2BF8C00
	|-Enumerable.WhereEnumerableIterator<Vector2>..ctor
	|
	|-RVA: 0x2BF90D0 Offset: 0x2BF91D1 VA: 0x2BF90D0
	|-Enumerable.WhereEnumerableIterator<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF55F0 Offset: 0x2BF56F1 VA: 0x2BF55F0
	|-Enumerable.WhereEnumerableIterator<CropDataTable>.Clone
	|
	|-RVA: 0x2BF5B90 Offset: 0x2BF5C91 VA: 0x2BF5B90
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x2BF6080 Offset: 0x2BF6181 VA: 0x2BF6080
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Clone
	|
	|-RVA: 0x2BF6570 Offset: 0x2BF6671 VA: 0x2BF6570
	|-Enumerable.WhereEnumerableIterator<int>.Clone
	|
	|-RVA: 0x2BF6A50 Offset: 0x2BF6B51 VA: 0x2BF6A50
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Clone
	|
	|-RVA: 0x2BF6F30 Offset: 0x2BF7031 VA: 0x2BF6F30
	|-Enumerable.WhereEnumerableIterator<object>.Clone
	|
	|-RVA: 0x2BF7410 Offset: 0x2BF7511 VA: 0x2BF7410
	|-Enumerable.WhereEnumerableIterator<Label>.Clone
	|
	|-RVA: 0x2BF78F0 Offset: 0x2BF79F1 VA: 0x2BF78F0
	|-Enumerable.WhereEnumerableIterator<float>.Clone
	|
	|-RVA: 0x2BF7DC0 Offset: 0x2BF7EC1 VA: 0x2BF7DC0
	|-Enumerable.WhereEnumerableIterator<ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2BF82A0 Offset: 0x2BF83A1 VA: 0x2BF82A0
	|-Enumerable.WhereEnumerableIterator<ValueTuple<Int32Enum, int>>.Clone
	|
	|-RVA: 0x2BF8780 Offset: 0x2BF8881 VA: 0x2BF8780
	|-Enumerable.WhereEnumerableIterator<ValueTuple<object, Int32Enum>>.Clone
	|
	|-RVA: 0x2BF8C70 Offset: 0x2BF8D71 VA: 0x2BF8C70
	|-Enumerable.WhereEnumerableIterator<Vector2>.Clone
	|
	|-RVA: 0x2BF9140 Offset: 0x2BF9241 VA: 0x2BF9140
	|-Enumerable.WhereEnumerableIterator<Vector3>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5660 Offset: 0x2BF5761 VA: 0x2BF5660
	|-Enumerable.WhereEnumerableIterator<CropDataTable>.Dispose
	|
	|-RVA: 0x2BF5C00 Offset: 0x2BF5D01 VA: 0x2BF5C00
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x2BF60F0 Offset: 0x2BF61F1 VA: 0x2BF60F0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x2BF65E0 Offset: 0x2BF66E1 VA: 0x2BF65E0
	|-Enumerable.WhereEnumerableIterator<int>.Dispose
	|
	|-RVA: 0x2BF6AC0 Offset: 0x2BF6BC1 VA: 0x2BF6AC0
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Dispose
	|
	|-RVA: 0x2BF6FA0 Offset: 0x2BF70A1 VA: 0x2BF6FA0
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0x2BF7480 Offset: 0x2BF7581 VA: 0x2BF7480
	|-Enumerable.WhereEnumerableIterator<Label>.Dispose
	|
	|-RVA: 0x2BF7960 Offset: 0x2BF7A61 VA: 0x2BF7960
	|-Enumerable.WhereEnumerableIterator<float>.Dispose
	|
	|-RVA: 0x2BF7E30 Offset: 0x2BF7F31 VA: 0x2BF7E30
	|-Enumerable.WhereEnumerableIterator<ValueTuple<bool, Int32Enum>>.Dispose
	|
	|-RVA: 0x2BF8310 Offset: 0x2BF8411 VA: 0x2BF8310
	|-Enumerable.WhereEnumerableIterator<ValueTuple<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2BF87F0 Offset: 0x2BF88F1 VA: 0x2BF87F0
	|-Enumerable.WhereEnumerableIterator<ValueTuple<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x2BF8CE0 Offset: 0x2BF8DE1 VA: 0x2BF8CE0
	|-Enumerable.WhereEnumerableIterator<Vector2>.Dispose
	|
	|-RVA: 0x2BF91B0 Offset: 0x2BF92B1 VA: 0x2BF91B0
	|-Enumerable.WhereEnumerableIterator<Vector3>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5760 Offset: 0x2BF5861 VA: 0x2BF5760
	|-Enumerable.WhereEnumerableIterator<CropDataTable>.MoveNext
	|
	|-RVA: 0x2BF5D00 Offset: 0x2BF5E01 VA: 0x2BF5D00
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x2BF61F0 Offset: 0x2BF62F1 VA: 0x2BF61F0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x2BF66E0 Offset: 0x2BF67E1 VA: 0x2BF66E0
	|-Enumerable.WhereEnumerableIterator<int>.MoveNext
	|
	|-RVA: 0x2BF6BC0 Offset: 0x2BF6CC1 VA: 0x2BF6BC0
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x2BF70A0 Offset: 0x2BF71A1 VA: 0x2BF70A0
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0x2BF7580 Offset: 0x2BF7681 VA: 0x2BF7580
	|-Enumerable.WhereEnumerableIterator<Label>.MoveNext
	|
	|-RVA: 0x2BF7A60 Offset: 0x2BF7B61 VA: 0x2BF7A60
	|-Enumerable.WhereEnumerableIterator<float>.MoveNext
	|
	|-RVA: 0x2BF7F30 Offset: 0x2BF8031 VA: 0x2BF7F30
	|-Enumerable.WhereEnumerableIterator<ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2BF8410 Offset: 0x2BF8511 VA: 0x2BF8410
	|-Enumerable.WhereEnumerableIterator<ValueTuple<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2BF88F0 Offset: 0x2BF89F1 VA: 0x2BF88F0
	|-Enumerable.WhereEnumerableIterator<ValueTuple<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2BF8DE0 Offset: 0x2BF8EE1 VA: 0x2BF8DE0
	|-Enumerable.WhereEnumerableIterator<Vector2>.MoveNext
	|
	|-RVA: 0x2BF92B0 Offset: 0x2BF93B1 VA: 0x2BF92B0
	|-Enumerable.WhereEnumerableIterator<Vector3>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21285B0 Offset: 0x21286B1 VA: 0x21285B0
	|-Enumerable.WhereEnumerableIterator<CropDataTable>.Select<int>
	|
	|-RVA: 0x2128630 Offset: 0x2128731 VA: 0x2128630
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Select<object>
	|
	|-RVA: 0x21286B0 Offset: 0x21287B1 VA: 0x21286B0
	|-Enumerable.WhereEnumerableIterator<int>.Select<object>
	|
	|-RVA: 0x2128730 Offset: 0x2128831 VA: 0x2128730
	|-Enumerable.WhereEnumerableIterator<int>.Select<Label>
	|
	|-RVA: 0x21287B0 Offset: 0x21288B1 VA: 0x21287B0
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Select<object>
	|
	|-RVA: 0x2128830 Offset: 0x2128931 VA: 0x2128830
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Select<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x21288B0 Offset: 0x21289B1 VA: 0x21288B0
	|-Enumerable.WhereEnumerableIterator<object>.Select<CropDataTable>
	|
	|-RVA: 0x2128930 Offset: 0x2128A31 VA: 0x2128930
	|-Enumerable.WhereEnumerableIterator<object>.Select<int>
	|
	|-RVA: 0x21289B0 Offset: 0x2128AB1 VA: 0x21289B0
	|-Enumerable.WhereEnumerableIterator<object>.Select<Int32Enum>
	|
	|-RVA: 0x2128A30 Offset: 0x2128B31 VA: 0x2128A30
	|-Enumerable.WhereEnumerableIterator<object>.Select<object>
	|
	|-RVA: 0x2128AB0 Offset: 0x2128BB1 VA: 0x2128AB0
	|-Enumerable.WhereEnumerableIterator<object>.Select<Label>
	|
	|-RVA: 0x2128B30 Offset: 0x2128C31 VA: 0x2128B30
	|-Enumerable.WhereEnumerableIterator<object>.Select<float>
	|
	|-RVA: 0x2128BB0 Offset: 0x2128CB1 VA: 0x2128BB0
	|-Enumerable.WhereEnumerableIterator<object>.Select<Vector2>
	|
	|-RVA: 0x2128C30 Offset: 0x2128D31 VA: 0x2128C30
	|-Enumerable.WhereEnumerableIterator<object>.Select<Vector3>
	|
	|-RVA: 0x2128CB0 Offset: 0x2128DB1 VA: 0x2128CB0
	|-Enumerable.WhereEnumerableIterator<ValueTuple<object, Int32Enum>>.Select<Int32Enum>
	|
	|-RVA: 0x2128D30 Offset: 0x2128E31 VA: 0x2128D30
	|-Enumerable.WhereEnumerableIterator<ValueTuple<object, Int32Enum>>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5A90 Offset: 0x2BF5B91 VA: 0x2BF5A90
	|-Enumerable.WhereEnumerableIterator<CropDataTable>.Where
	|
	|-RVA: 0x2BF5F80 Offset: 0x2BF6081 VA: 0x2BF5F80
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x2BF6470 Offset: 0x2BF6571 VA: 0x2BF6470
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Where
	|
	|-RVA: 0x2BF6950 Offset: 0x2BF6A51 VA: 0x2BF6950
	|-Enumerable.WhereEnumerableIterator<int>.Where
	|
	|-RVA: 0x2BF6E30 Offset: 0x2BF6F31 VA: 0x2BF6E30
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Where
	|
	|-RVA: 0x2BF7310 Offset: 0x2BF7411 VA: 0x2BF7310
	|-Enumerable.WhereEnumerableIterator<object>.Where
	|
	|-RVA: 0x2BF77F0 Offset: 0x2BF78F1 VA: 0x2BF77F0
	|-Enumerable.WhereEnumerableIterator<Label>.Where
	|
	|-RVA: 0x2BF7CC0 Offset: 0x2BF7DC1 VA: 0x2BF7CC0
	|-Enumerable.WhereEnumerableIterator<float>.Where
	|
	|-RVA: 0x2BF81A0 Offset: 0x2BF82A1 VA: 0x2BF81A0
	|-Enumerable.WhereEnumerableIterator<ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2BF8680 Offset: 0x2BF8781 VA: 0x2BF8680
	|-Enumerable.WhereEnumerableIterator<ValueTuple<Int32Enum, int>>.Where
	|
	|-RVA: 0x2BF8B70 Offset: 0x2BF8C71 VA: 0x2BF8B70
	|-Enumerable.WhereEnumerableIterator<ValueTuple<object, Int32Enum>>.Where
	|
	|-RVA: 0x2BF9040 Offset: 0x2BF9141 VA: 0x2BF9040
	|-Enumerable.WhereEnumerableIterator<Vector2>.Where
	|
	|-RVA: 0x2BF9520 Offset: 0x2BF9621 VA: 0x2BF9520
	|-Enumerable.WhereEnumerableIterator<Vector3>.Where
	*/
}

