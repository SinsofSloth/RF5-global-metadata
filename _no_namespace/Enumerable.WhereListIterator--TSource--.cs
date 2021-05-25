private class Enumerable.WhereListIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 2167
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF95B0 Offset: 0x2BF96B1 VA: 0x2BF95B0
	|-Enumerable.WhereListIterator<CropDataTable>..ctor
	|
	|-RVA: 0x2BF98F0 Offset: 0x2BF99F1 VA: 0x2BF98F0
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2BF9B80 Offset: 0x2BF9C81 VA: 0x2BF9B80
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2BF9E10 Offset: 0x2BF9F11 VA: 0x2BF9E10
	|-Enumerable.WhereListIterator<Int32Enum>..ctor
	|
	|-RVA: 0x2BFA080 Offset: 0x2BFA181 VA: 0x2BFA080
	|-Enumerable.WhereListIterator<object>..ctor
	|
	|-RVA: 0x2BFA2F0 Offset: 0x2BFA3F1 VA: 0x2BFA2F0
	|-Enumerable.WhereListIterator<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2BFA560 Offset: 0x2BFA661 VA: 0x2BFA560
	|-Enumerable.WhereListIterator<ValueTuple<object, Int32Enum>>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF9620 Offset: 0x2BF9721 VA: 0x2BF9620
	|-Enumerable.WhereListIterator<CropDataTable>.Clone
	|
	|-RVA: 0x2BF9960 Offset: 0x2BF9A61 VA: 0x2BF9960
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x2BF9BF0 Offset: 0x2BF9CF1 VA: 0x2BF9BF0
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Clone
	|
	|-RVA: 0x2BF9E80 Offset: 0x2BF9F81 VA: 0x2BF9E80
	|-Enumerable.WhereListIterator<Int32Enum>.Clone
	|
	|-RVA: 0x2BFA0F0 Offset: 0x2BFA1F1 VA: 0x2BFA0F0
	|-Enumerable.WhereListIterator<object>.Clone
	|
	|-RVA: 0x2BFA360 Offset: 0x2BFA461 VA: 0x2BFA360
	|-Enumerable.WhereListIterator<ValueTuple<Int32Enum, int>>.Clone
	|
	|-RVA: 0x2BFA5D0 Offset: 0x2BFA6D1 VA: 0x2BFA5D0
	|-Enumerable.WhereListIterator<ValueTuple<object, Int32Enum>>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF9690 Offset: 0x2BF9791 VA: 0x2BF9690
	|-Enumerable.WhereListIterator<CropDataTable>.MoveNext
	|
	|-RVA: 0x2BF99D0 Offset: 0x2BF9AD1 VA: 0x2BF99D0
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x2BF9C60 Offset: 0x2BF9D61 VA: 0x2BF9C60
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x2BF9EF0 Offset: 0x2BF9FF1 VA: 0x2BF9EF0
	|-Enumerable.WhereListIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x2BFA160 Offset: 0x2BFA261 VA: 0x2BFA160
	|-Enumerable.WhereListIterator<object>.MoveNext
	|
	|-RVA: 0x2BFA3D0 Offset: 0x2BFA4D1 VA: 0x2BFA3D0
	|-Enumerable.WhereListIterator<ValueTuple<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2BFA640 Offset: 0x2BFA741 VA: 0x2BFA640
	|-Enumerable.WhereListIterator<ValueTuple<object, Int32Enum>>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2128DB0 Offset: 0x2128EB1 VA: 0x2128DB0
	|-Enumerable.WhereListIterator<CropDataTable>.Select<int>
	|
	|-RVA: 0x2128E30 Offset: 0x2128F31 VA: 0x2128E30
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Select<object>
	|
	|-RVA: 0x2128EB0 Offset: 0x2128FB1 VA: 0x2128EB0
	|-Enumerable.WhereListIterator<Int32Enum>.Select<object>
	|
	|-RVA: 0x2128F30 Offset: 0x2129031 VA: 0x2128F30
	|-Enumerable.WhereListIterator<Int32Enum>.Select<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x2128FB0 Offset: 0x21290B1 VA: 0x2128FB0
	|-Enumerable.WhereListIterator<object>.Select<CropDataTable>
	|
	|-RVA: 0x2129030 Offset: 0x2129131 VA: 0x2129030
	|-Enumerable.WhereListIterator<object>.Select<int>
	|
	|-RVA: 0x21290B0 Offset: 0x21291B1 VA: 0x21290B0
	|-Enumerable.WhereListIterator<object>.Select<Int32Enum>
	|
	|-RVA: 0x2129130 Offset: 0x2129231 VA: 0x2129130
	|-Enumerable.WhereListIterator<object>.Select<object>
	|
	|-RVA: 0x21291B0 Offset: 0x21292B1 VA: 0x21291B0
	|-Enumerable.WhereListIterator<object>.Select<Label>
	|
	|-RVA: 0x2129230 Offset: 0x2129331 VA: 0x2129230
	|-Enumerable.WhereListIterator<object>.Select<float>
	|
	|-RVA: 0x21292B0 Offset: 0x21293B1 VA: 0x21292B0
	|-Enumerable.WhereListIterator<object>.Select<Vector2>
	|
	|-RVA: 0x2129330 Offset: 0x2129431 VA: 0x2129330
	|-Enumerable.WhereListIterator<object>.Select<Vector3>
	|
	|-RVA: 0x21293B0 Offset: 0x21294B1 VA: 0x21293B0
	|-Enumerable.WhereListIterator<ValueTuple<object, Int32Enum>>.Select<Int32Enum>
	|
	|-RVA: 0x2129430 Offset: 0x2129531 VA: 0x2129430
	|-Enumerable.WhereListIterator<ValueTuple<object, Int32Enum>>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF9860 Offset: 0x2BF9961 VA: 0x2BF9860
	|-Enumerable.WhereListIterator<CropDataTable>.Where
	|
	|-RVA: 0x2BF9AF0 Offset: 0x2BF9BF1 VA: 0x2BF9AF0
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x2BF9D80 Offset: 0x2BF9E81 VA: 0x2BF9D80
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Where
	|
	|-RVA: 0x2BF9FF0 Offset: 0x2BFA0F1 VA: 0x2BF9FF0
	|-Enumerable.WhereListIterator<Int32Enum>.Where
	|
	|-RVA: 0x2BFA260 Offset: 0x2BFA361 VA: 0x2BFA260
	|-Enumerable.WhereListIterator<object>.Where
	|
	|-RVA: 0x2BFA4D0 Offset: 0x2BFA5D1 VA: 0x2BFA4D0
	|-Enumerable.WhereListIterator<ValueTuple<Int32Enum, int>>.Where
	|
	|-RVA: 0x2BFA760 Offset: 0x2BFA861 VA: 0x2BFA760
	|-Enumerable.WhereListIterator<ValueTuple<object, Int32Enum>>.Where
	*/
}

