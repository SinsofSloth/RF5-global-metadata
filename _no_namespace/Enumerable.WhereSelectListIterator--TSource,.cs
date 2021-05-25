private class Enumerable.WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 2170
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A58C90 Offset: 0x2A58D91 VA: 0x2A58C90
	|-Enumerable.WhereSelectListIterator<CropDataTable, int>..ctor
	|
	|-RVA: 0x2A59010 Offset: 0x2A59111 VA: 0x2A59010
	|-Enumerable.WhereSelectListIterator<CropDataTable, object>..ctor
	|
	|-RVA: 0x2A59390 Offset: 0x2A59491 VA: 0x2A59390
	|-Enumerable.WhereSelectListIterator<CropDataTable, Label>..ctor
	|
	|-RVA: 0x2A59710 Offset: 0x2A59811 VA: 0x2A59710
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, CropDataTable>..ctor
	|
	|-RVA: 0x2A599D0 Offset: 0x2A59AD1 VA: 0x2A599D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x2A59C80 Offset: 0x2A59D81 VA: 0x2A59C80
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|
	|-RVA: 0x2A59F30 Offset: 0x2A5A031 VA: 0x2A59F30
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x2A5A1F0 Offset: 0x2A5A2F1 VA: 0x2A5A1F0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Label>..ctor
	|
	|-RVA: 0x2A5A4A0 Offset: 0x2A5A5A1 VA: 0x2A5A4A0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>..ctor
	|
	|-RVA: 0x2A5A750 Offset: 0x2A5A851 VA: 0x2A5A750
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Vector2>..ctor
	|
	|-RVA: 0x2A5AA00 Offset: 0x2A5AB01 VA: 0x2A5AA00
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Vector3>..ctor
	|
	|-RVA: 0x2A5ACB0 Offset: 0x2A5ADB1 VA: 0x2A5ACB0
	|-Enumerable.WhereSelectListIterator<int, CropDataTable>..ctor
	|
	|-RVA: 0x2A5AF70 Offset: 0x2A5B071 VA: 0x2A5AF70
	|-Enumerable.WhereSelectListIterator<int, int>..ctor
	|
	|-RVA: 0x2A5B210 Offset: 0x2A5B311 VA: 0x2A5B210
	|-Enumerable.WhereSelectListIterator<int, Int32Enum>..ctor
	|
	|-RVA: 0x2A5B4B0 Offset: 0x2A5B5B1 VA: 0x2A5B4B0
	|-Enumerable.WhereSelectListIterator<int, object>..ctor
	|
	|-RVA: 0x2A5B750 Offset: 0x2A5B851 VA: 0x2A5B750
	|-Enumerable.WhereSelectListIterator<int, Label>..ctor
	|
	|-RVA: 0x2A5B9F0 Offset: 0x2A5BAF1 VA: 0x2A5B9F0
	|-Enumerable.WhereSelectListIterator<int, float>..ctor
	|
	|-RVA: 0x2A5BC90 Offset: 0x2A5BD91 VA: 0x2A5BC90
	|-Enumerable.WhereSelectListIterator<int, Vector2>..ctor
	|
	|-RVA: 0x2A5BF30 Offset: 0x2A5C031 VA: 0x2A5BF30
	|-Enumerable.WhereSelectListIterator<int, Vector3>..ctor
	|
	|-RVA: 0x2A5C1D0 Offset: 0x2A5C2D1 VA: 0x2A5C1D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, CropDataTable>..ctor
	|
	|-RVA: 0x2A5C490 Offset: 0x2A5C591 VA: 0x2A5C490
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>..ctor
	|
	|-RVA: 0x2A5C730 Offset: 0x2A5C831 VA: 0x2A5C730
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2A5C9D0 Offset: 0x2A5CAD1 VA: 0x2A5C9D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>..ctor
	|
	|-RVA: 0x2A5CC70 Offset: 0x2A5CD71 VA: 0x2A5CC70
	|-Enumerable.WhereSelectListIterator<Int32Enum, Label>..ctor
	|
	|-RVA: 0x2A5CF10 Offset: 0x2A5D011 VA: 0x2A5CF10
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>..ctor
	|
	|-RVA: 0x2A5D1B0 Offset: 0x2A5D2B1 VA: 0x2A5D1B0
	|-Enumerable.WhereSelectListIterator<Int32Enum, ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2A5D450 Offset: 0x2A5D551 VA: 0x2A5D450
	|-Enumerable.WhereSelectListIterator<Int32Enum, Vector2>..ctor
	|
	|-RVA: 0x2A5D6F0 Offset: 0x2A5D7F1 VA: 0x2A5D6F0
	|-Enumerable.WhereSelectListIterator<Int32Enum, Vector3>..ctor
	|
	|-RVA: 0x2A5D990 Offset: 0x2A5DA91 VA: 0x2A5D990
	|-Enumerable.WhereSelectListIterator<object, CropDataTable>..ctor
	|
	|-RVA: 0x2A5DC50 Offset: 0x2A5DD51 VA: 0x2A5DC50
	|-Enumerable.WhereSelectListIterator<object, int>..ctor
	|
	|-RVA: 0x2A5DEF0 Offset: 0x2A5DFF1 VA: 0x2A5DEF0
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>..ctor
	|
	|-RVA: 0x2A5E190 Offset: 0x2A5E291 VA: 0x2A5E190
	|-Enumerable.WhereSelectListIterator<object, object>..ctor
	|
	|-RVA: 0x2A5E430 Offset: 0x2A5E531 VA: 0x2A5E430
	|-Enumerable.WhereSelectListIterator<object, Label>..ctor
	|
	|-RVA: 0x2A5E6D0 Offset: 0x2A5E7D1 VA: 0x2A5E6D0
	|-Enumerable.WhereSelectListIterator<object, float>..ctor
	|
	|-RVA: 0x2A5E970 Offset: 0x2A5EA71 VA: 0x2A5E970
	|-Enumerable.WhereSelectListIterator<object, ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2A5EC10 Offset: 0x2A5ED11 VA: 0x2A5EC10
	|-Enumerable.WhereSelectListIterator<object, Vector2>..ctor
	|
	|-RVA: 0x2A5EEB0 Offset: 0x2A5EFB1 VA: 0x2A5EEB0
	|-Enumerable.WhereSelectListIterator<object, Vector3>..ctor
	|
	|-RVA: 0x2A5F150 Offset: 0x2A5F251 VA: 0x2A5F150
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, CropDataTable>..ctor
	|
	|-RVA: 0x2A5F410 Offset: 0x2A5F511 VA: 0x2A5F410
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, int>..ctor
	|
	|-RVA: 0x2A5F6C0 Offset: 0x2A5F7C1 VA: 0x2A5F6C0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Int32Enum>..ctor
	|
	|-RVA: 0x2A5F970 Offset: 0x2A5FA71 VA: 0x2A5F970
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>..ctor
	|
	|-RVA: 0x2A5FC30 Offset: 0x2A5FD31 VA: 0x2A5FC30
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Label>..ctor
	|
	|-RVA: 0x2A5FEE0 Offset: 0x2A5FFE1 VA: 0x2A5FEE0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, float>..ctor
	|
	|-RVA: 0x2A60190 Offset: 0x2A60291 VA: 0x2A60190
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2A60440 Offset: 0x2A60541 VA: 0x2A60440
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Vector2>..ctor
	|
	|-RVA: 0x2A606F0 Offset: 0x2A607F1 VA: 0x2A606F0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Vector3>..ctor
	|
	|-RVA: 0x2A609A0 Offset: 0x2A60AA1 VA: 0x2A609A0
	|-Enumerable.WhereSelectListIterator<Vector4, Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A58D10 Offset: 0x2A58E11 VA: 0x2A58D10
	|-Enumerable.WhereSelectListIterator<CropDataTable, int>.Clone
	|
	|-RVA: 0x2A59090 Offset: 0x2A59191 VA: 0x2A59090
	|-Enumerable.WhereSelectListIterator<CropDataTable, object>.Clone
	|
	|-RVA: 0x2A59410 Offset: 0x2A59511 VA: 0x2A59410
	|-Enumerable.WhereSelectListIterator<CropDataTable, Label>.Clone
	|
	|-RVA: 0x2A59790 Offset: 0x2A59891 VA: 0x2A59790
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, CropDataTable>.Clone
	|
	|-RVA: 0x2A59A50 Offset: 0x2A59B51 VA: 0x2A59A50
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Clone
	|
	|-RVA: 0x2A59D00 Offset: 0x2A59E01 VA: 0x2A59D00
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|
	|-RVA: 0x2A59FB0 Offset: 0x2A5A0B1 VA: 0x2A59FB0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Clone
	|
	|-RVA: 0x2A5A270 Offset: 0x2A5A371 VA: 0x2A5A270
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Label>.Clone
	|
	|-RVA: 0x2A5A520 Offset: 0x2A5A621 VA: 0x2A5A520
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.Clone
	|
	|-RVA: 0x2A5A7D0 Offset: 0x2A5A8D1 VA: 0x2A5A7D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Vector2>.Clone
	|
	|-RVA: 0x2A5AA80 Offset: 0x2A5AB81 VA: 0x2A5AA80
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Vector3>.Clone
	|
	|-RVA: 0x2A5AD30 Offset: 0x2A5AE31 VA: 0x2A5AD30
	|-Enumerable.WhereSelectListIterator<int, CropDataTable>.Clone
	|
	|-RVA: 0x2A5AFF0 Offset: 0x2A5B0F1 VA: 0x2A5AFF0
	|-Enumerable.WhereSelectListIterator<int, int>.Clone
	|
	|-RVA: 0x2A5B290 Offset: 0x2A5B391 VA: 0x2A5B290
	|-Enumerable.WhereSelectListIterator<int, Int32Enum>.Clone
	|
	|-RVA: 0x2A5B530 Offset: 0x2A5B631 VA: 0x2A5B530
	|-Enumerable.WhereSelectListIterator<int, object>.Clone
	|
	|-RVA: 0x2A5B7D0 Offset: 0x2A5B8D1 VA: 0x2A5B7D0
	|-Enumerable.WhereSelectListIterator<int, Label>.Clone
	|
	|-RVA: 0x2A5BA70 Offset: 0x2A5BB71 VA: 0x2A5BA70
	|-Enumerable.WhereSelectListIterator<int, float>.Clone
	|
	|-RVA: 0x2A5BD10 Offset: 0x2A5BE11 VA: 0x2A5BD10
	|-Enumerable.WhereSelectListIterator<int, Vector2>.Clone
	|
	|-RVA: 0x2A5BFB0 Offset: 0x2A5C0B1 VA: 0x2A5BFB0
	|-Enumerable.WhereSelectListIterator<int, Vector3>.Clone
	|
	|-RVA: 0x2A5C250 Offset: 0x2A5C351 VA: 0x2A5C250
	|-Enumerable.WhereSelectListIterator<Int32Enum, CropDataTable>.Clone
	|
	|-RVA: 0x2A5C510 Offset: 0x2A5C611 VA: 0x2A5C510
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Clone
	|
	|-RVA: 0x2A5C7B0 Offset: 0x2A5C8B1 VA: 0x2A5C7B0
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Clone
	|
	|-RVA: 0x2A5CA50 Offset: 0x2A5CB51 VA: 0x2A5CA50
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Clone
	|
	|-RVA: 0x2A5CCF0 Offset: 0x2A5CDF1 VA: 0x2A5CCF0
	|-Enumerable.WhereSelectListIterator<Int32Enum, Label>.Clone
	|
	|-RVA: 0x2A5CF90 Offset: 0x2A5D091 VA: 0x2A5CF90
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.Clone
	|
	|-RVA: 0x2A5D230 Offset: 0x2A5D331 VA: 0x2A5D230
	|-Enumerable.WhereSelectListIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2A5D4D0 Offset: 0x2A5D5D1 VA: 0x2A5D4D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, Vector2>.Clone
	|
	|-RVA: 0x2A5D770 Offset: 0x2A5D871 VA: 0x2A5D770
	|-Enumerable.WhereSelectListIterator<Int32Enum, Vector3>.Clone
	|
	|-RVA: 0x2A5DA10 Offset: 0x2A5DB11 VA: 0x2A5DA10
	|-Enumerable.WhereSelectListIterator<object, CropDataTable>.Clone
	|
	|-RVA: 0x2A5DCD0 Offset: 0x2A5DDD1 VA: 0x2A5DCD0
	|-Enumerable.WhereSelectListIterator<object, int>.Clone
	|
	|-RVA: 0x2A5DF70 Offset: 0x2A5E071 VA: 0x2A5DF70
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Clone
	|
	|-RVA: 0x2A5E210 Offset: 0x2A5E311 VA: 0x2A5E210
	|-Enumerable.WhereSelectListIterator<object, object>.Clone
	|
	|-RVA: 0x2A5E4B0 Offset: 0x2A5E5B1 VA: 0x2A5E4B0
	|-Enumerable.WhereSelectListIterator<object, Label>.Clone
	|
	|-RVA: 0x2A5E750 Offset: 0x2A5E851 VA: 0x2A5E750
	|-Enumerable.WhereSelectListIterator<object, float>.Clone
	|
	|-RVA: 0x2A5E9F0 Offset: 0x2A5EAF1 VA: 0x2A5E9F0
	|-Enumerable.WhereSelectListIterator<object, ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2A5EC90 Offset: 0x2A5ED91 VA: 0x2A5EC90
	|-Enumerable.WhereSelectListIterator<object, Vector2>.Clone
	|
	|-RVA: 0x2A5EF30 Offset: 0x2A5F031 VA: 0x2A5EF30
	|-Enumerable.WhereSelectListIterator<object, Vector3>.Clone
	|
	|-RVA: 0x2A5F1D0 Offset: 0x2A5F2D1 VA: 0x2A5F1D0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, CropDataTable>.Clone
	|
	|-RVA: 0x2A5F490 Offset: 0x2A5F591 VA: 0x2A5F490
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, int>.Clone
	|
	|-RVA: 0x2A5F740 Offset: 0x2A5F841 VA: 0x2A5F740
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Clone
	|
	|-RVA: 0x2A5F9F0 Offset: 0x2A5FAF1 VA: 0x2A5F9F0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Clone
	|
	|-RVA: 0x2A5FCB0 Offset: 0x2A5FDB1 VA: 0x2A5FCB0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Label>.Clone
	|
	|-RVA: 0x2A5FF60 Offset: 0x2A60061 VA: 0x2A5FF60
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, float>.Clone
	|
	|-RVA: 0x2A60210 Offset: 0x2A60311 VA: 0x2A60210
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2A604C0 Offset: 0x2A605C1 VA: 0x2A604C0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Vector2>.Clone
	|
	|-RVA: 0x2A60770 Offset: 0x2A60871 VA: 0x2A60770
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Vector3>.Clone
	|
	|-RVA: 0x2A60A20 Offset: 0x2A60B21 VA: 0x2A60A20
	|-Enumerable.WhereSelectListIterator<Vector4, Vector2>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A58D90 Offset: 0x2A58E91 VA: 0x2A58D90
	|-Enumerable.WhereSelectListIterator<CropDataTable, int>.MoveNext
	|
	|-RVA: 0x2A59110 Offset: 0x2A59211 VA: 0x2A59110
	|-Enumerable.WhereSelectListIterator<CropDataTable, object>.MoveNext
	|
	|-RVA: 0x2A59490 Offset: 0x2A59591 VA: 0x2A59490
	|-Enumerable.WhereSelectListIterator<CropDataTable, Label>.MoveNext
	|
	|-RVA: 0x2A59810 Offset: 0x2A59911 VA: 0x2A59810
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, CropDataTable>.MoveNext
	|
	|-RVA: 0x2A59AD0 Offset: 0x2A59BD1 VA: 0x2A59AD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x2A59D80 Offset: 0x2A59E81 VA: 0x2A59D80
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2A5A030 Offset: 0x2A5A131 VA: 0x2A5A030
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x2A5A2F0 Offset: 0x2A5A3F1 VA: 0x2A5A2F0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Label>.MoveNext
	|
	|-RVA: 0x2A5A5A0 Offset: 0x2A5A6A1 VA: 0x2A5A5A0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x2A5A850 Offset: 0x2A5A951 VA: 0x2A5A850
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Vector2>.MoveNext
	|
	|-RVA: 0x2A5AB00 Offset: 0x2A5AC01 VA: 0x2A5AB00
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Vector3>.MoveNext
	|
	|-RVA: 0x2A5ADB0 Offset: 0x2A5AEB1 VA: 0x2A5ADB0
	|-Enumerable.WhereSelectListIterator<int, CropDataTable>.MoveNext
	|
	|-RVA: 0x2A5B070 Offset: 0x2A5B171 VA: 0x2A5B070
	|-Enumerable.WhereSelectListIterator<int, int>.MoveNext
	|
	|-RVA: 0x2A5B310 Offset: 0x2A5B411 VA: 0x2A5B310
	|-Enumerable.WhereSelectListIterator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x2A5B5B0 Offset: 0x2A5B6B1 VA: 0x2A5B5B0
	|-Enumerable.WhereSelectListIterator<int, object>.MoveNext
	|
	|-RVA: 0x2A5B850 Offset: 0x2A5B951 VA: 0x2A5B850
	|-Enumerable.WhereSelectListIterator<int, Label>.MoveNext
	|
	|-RVA: 0x2A5BAF0 Offset: 0x2A5BBF1 VA: 0x2A5BAF0
	|-Enumerable.WhereSelectListIterator<int, float>.MoveNext
	|
	|-RVA: 0x2A5BD90 Offset: 0x2A5BE91 VA: 0x2A5BD90
	|-Enumerable.WhereSelectListIterator<int, Vector2>.MoveNext
	|
	|-RVA: 0x2A5C030 Offset: 0x2A5C131 VA: 0x2A5C030
	|-Enumerable.WhereSelectListIterator<int, Vector3>.MoveNext
	|
	|-RVA: 0x2A5C2D0 Offset: 0x2A5C3D1 VA: 0x2A5C2D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, CropDataTable>.MoveNext
	|
	|-RVA: 0x2A5C590 Offset: 0x2A5C691 VA: 0x2A5C590
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x2A5C830 Offset: 0x2A5C931 VA: 0x2A5C830
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x2A5CAD0 Offset: 0x2A5CBD1 VA: 0x2A5CAD0
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x2A5CD70 Offset: 0x2A5CE71 VA: 0x2A5CD70
	|-Enumerable.WhereSelectListIterator<Int32Enum, Label>.MoveNext
	|
	|-RVA: 0x2A5D010 Offset: 0x2A5D111 VA: 0x2A5D010
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x2A5D2B0 Offset: 0x2A5D3B1 VA: 0x2A5D2B0
	|-Enumerable.WhereSelectListIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2A5D550 Offset: 0x2A5D651 VA: 0x2A5D550
	|-Enumerable.WhereSelectListIterator<Int32Enum, Vector2>.MoveNext
	|
	|-RVA: 0x2A5D7F0 Offset: 0x2A5D8F1 VA: 0x2A5D7F0
	|-Enumerable.WhereSelectListIterator<Int32Enum, Vector3>.MoveNext
	|
	|-RVA: 0x2A5DA90 Offset: 0x2A5DB91 VA: 0x2A5DA90
	|-Enumerable.WhereSelectListIterator<object, CropDataTable>.MoveNext
	|
	|-RVA: 0x2A5DD50 Offset: 0x2A5DE51 VA: 0x2A5DD50
	|-Enumerable.WhereSelectListIterator<object, int>.MoveNext
	|
	|-RVA: 0x2A5DFF0 Offset: 0x2A5E0F1 VA: 0x2A5DFF0
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x2A5E290 Offset: 0x2A5E391 VA: 0x2A5E290
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0x2A5E530 Offset: 0x2A5E631 VA: 0x2A5E530
	|-Enumerable.WhereSelectListIterator<object, Label>.MoveNext
	|
	|-RVA: 0x2A5E7D0 Offset: 0x2A5E8D1 VA: 0x2A5E7D0
	|-Enumerable.WhereSelectListIterator<object, float>.MoveNext
	|
	|-RVA: 0x2A5EA70 Offset: 0x2A5EB71 VA: 0x2A5EA70
	|-Enumerable.WhereSelectListIterator<object, ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2A5ED10 Offset: 0x2A5EE11 VA: 0x2A5ED10
	|-Enumerable.WhereSelectListIterator<object, Vector2>.MoveNext
	|
	|-RVA: 0x2A5EFB0 Offset: 0x2A5F0B1 VA: 0x2A5EFB0
	|-Enumerable.WhereSelectListIterator<object, Vector3>.MoveNext
	|
	|-RVA: 0x2A5F250 Offset: 0x2A5F351 VA: 0x2A5F250
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, CropDataTable>.MoveNext
	|
	|-RVA: 0x2A5F510 Offset: 0x2A5F611 VA: 0x2A5F510
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, int>.MoveNext
	|
	|-RVA: 0x2A5F7C0 Offset: 0x2A5F8C1 VA: 0x2A5F7C0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2A5FA70 Offset: 0x2A5FB71 VA: 0x2A5FA70
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.MoveNext
	|
	|-RVA: 0x2A5FD30 Offset: 0x2A5FE31 VA: 0x2A5FD30
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Label>.MoveNext
	|
	|-RVA: 0x2A5FFE0 Offset: 0x2A600E1 VA: 0x2A5FFE0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, float>.MoveNext
	|
	|-RVA: 0x2A60290 Offset: 0x2A60391 VA: 0x2A60290
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2A60540 Offset: 0x2A60641 VA: 0x2A60540
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Vector2>.MoveNext
	|
	|-RVA: 0x2A607F0 Offset: 0x2A608F1 VA: 0x2A607F0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Vector3>.MoveNext
	|
	|-RVA: 0x2A60AA0 Offset: 0x2A60BA1 VA: 0x2A60AA0
	|-Enumerable.WhereSelectListIterator<Vector4, Vector2>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2126320 Offset: 0x2126421 VA: 0x2126320
	|-Enumerable.WhereSelectListIterator<CropDataTable, int>.Select<object>
	|
	|-RVA: 0x21263B0 Offset: 0x21264B1 VA: 0x21263B0
	|-Enumerable.WhereSelectListIterator<CropDataTable, int>.Select<Label>
	|
	|-RVA: 0x2126440 Offset: 0x2126541 VA: 0x2126440
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<CropDataTable>
	|
	|-RVA: 0x21264D0 Offset: 0x21265D1 VA: 0x21264D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<int>
	|
	|-RVA: 0x2126560 Offset: 0x2126661 VA: 0x2126560
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|
	|-RVA: 0x21265F0 Offset: 0x21266F1 VA: 0x21265F0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<object>
	|
	|-RVA: 0x2126680 Offset: 0x2126781 VA: 0x2126680
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Label>
	|
	|-RVA: 0x2126710 Offset: 0x2126811 VA: 0x2126710
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<float>
	|
	|-RVA: 0x21267A0 Offset: 0x21268A1 VA: 0x21267A0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Vector2>
	|
	|-RVA: 0x2126830 Offset: 0x2126931 VA: 0x2126830
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Vector3>
	|
	|-RVA: 0x21268C0 Offset: 0x21269C1 VA: 0x21268C0
	|-Enumerable.WhereSelectListIterator<int, object>.Select<CropDataTable>
	|
	|-RVA: 0x2126950 Offset: 0x2126A51 VA: 0x2126950
	|-Enumerable.WhereSelectListIterator<int, object>.Select<int>
	|
	|-RVA: 0x21269E0 Offset: 0x2126AE1 VA: 0x21269E0
	|-Enumerable.WhereSelectListIterator<int, object>.Select<Int32Enum>
	|
	|-RVA: 0x2126A70 Offset: 0x2126B71 VA: 0x2126A70
	|-Enumerable.WhereSelectListIterator<int, object>.Select<object>
	|
	|-RVA: 0x2126B00 Offset: 0x2126C01 VA: 0x2126B00
	|-Enumerable.WhereSelectListIterator<int, object>.Select<Label>
	|
	|-RVA: 0x2126B90 Offset: 0x2126C91 VA: 0x2126B90
	|-Enumerable.WhereSelectListIterator<int, object>.Select<float>
	|
	|-RVA: 0x2126C20 Offset: 0x2126D21 VA: 0x2126C20
	|-Enumerable.WhereSelectListIterator<int, object>.Select<Vector2>
	|
	|-RVA: 0x2126CB0 Offset: 0x2126DB1 VA: 0x2126CB0
	|-Enumerable.WhereSelectListIterator<int, object>.Select<Vector3>
	|
	|-RVA: 0x2126D40 Offset: 0x2126E41 VA: 0x2126D40
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<CropDataTable>
	|
	|-RVA: 0x2126DD0 Offset: 0x2126ED1 VA: 0x2126DD0
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<int>
	|
	|-RVA: 0x2126E60 Offset: 0x2126F61 VA: 0x2126E60
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Int32Enum>
	|
	|-RVA: 0x2126EF0 Offset: 0x2126FF1 VA: 0x2126EF0
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<object>
	|
	|-RVA: 0x2126F80 Offset: 0x2127081 VA: 0x2126F80
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Label>
	|
	|-RVA: 0x2127010 Offset: 0x2127111 VA: 0x2127010
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<float>
	|
	|-RVA: 0x21270A0 Offset: 0x21271A1 VA: 0x21270A0
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Vector2>
	|
	|-RVA: 0x2127130 Offset: 0x2127231 VA: 0x2127130
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Vector3>
	|
	|-RVA: 0x21271C0 Offset: 0x21272C1 VA: 0x21271C0
	|-Enumerable.WhereSelectListIterator<object, CropDataTable>.Select<int>
	|
	|-RVA: 0x2127250 Offset: 0x2127351 VA: 0x2127250
	|-Enumerable.WhereSelectListIterator<object, int>.Select<object>
	|
	|-RVA: 0x21272E0 Offset: 0x21273E1 VA: 0x21272E0
	|-Enumerable.WhereSelectListIterator<object, int>.Select<Label>
	|
	|-RVA: 0x2127370 Offset: 0x2127471 VA: 0x2127370
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Select<object>
	|
	|-RVA: 0x2127400 Offset: 0x2127501 VA: 0x2127400
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Select<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x2127490 Offset: 0x2127591 VA: 0x2127490
	|-Enumerable.WhereSelectListIterator<object, object>.Select<CropDataTable>
	|
	|-RVA: 0x2127520 Offset: 0x2127621 VA: 0x2127520
	|-Enumerable.WhereSelectListIterator<object, object>.Select<int>
	|
	|-RVA: 0x21275B0 Offset: 0x21276B1 VA: 0x21275B0
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Int32Enum>
	|
	|-RVA: 0x2127640 Offset: 0x2127741 VA: 0x2127640
	|-Enumerable.WhereSelectListIterator<object, object>.Select<object>
	|
	|-RVA: 0x21276D0 Offset: 0x21277D1 VA: 0x21276D0
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Label>
	|
	|-RVA: 0x2127760 Offset: 0x2127861 VA: 0x2127760
	|-Enumerable.WhereSelectListIterator<object, object>.Select<float>
	|
	|-RVA: 0x21277F0 Offset: 0x21278F1 VA: 0x21277F0
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Vector2>
	|
	|-RVA: 0x2127880 Offset: 0x2127981 VA: 0x2127880
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Vector3>
	|
	|-RVA: 0x2127910 Offset: 0x2127A11 VA: 0x2127910
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Select<object>
	|
	|-RVA: 0x21279A0 Offset: 0x2127AA1 VA: 0x21279A0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Select<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x2127A30 Offset: 0x2127B31 VA: 0x2127A30
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Select<CropDataTable>
	|
	|-RVA: 0x2127AC0 Offset: 0x2127BC1 VA: 0x2127AC0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Select<int>
	|
	|-RVA: 0x2127B50 Offset: 0x2127C51 VA: 0x2127B50
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Select<Int32Enum>
	|
	|-RVA: 0x2127BE0 Offset: 0x2127CE1 VA: 0x2127BE0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Select<object>
	|
	|-RVA: 0x2127C70 Offset: 0x2127D71 VA: 0x2127C70
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Select<Label>
	|
	|-RVA: 0x2127D00 Offset: 0x2127E01 VA: 0x2127D00
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Select<float>
	|
	|-RVA: 0x2127D90 Offset: 0x2127E91 VA: 0x2127D90
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Select<Vector2>
	|
	|-RVA: 0x2127E20 Offset: 0x2127F21 VA: 0x2127E20
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Select<Vector3>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A58F90 Offset: 0x2A59091 VA: 0x2A58F90
	|-Enumerable.WhereSelectListIterator<CropDataTable, int>.Where
	|
	|-RVA: 0x2A59310 Offset: 0x2A59411 VA: 0x2A59310
	|-Enumerable.WhereSelectListIterator<CropDataTable, object>.Where
	|
	|-RVA: 0x2A59690 Offset: 0x2A59791 VA: 0x2A59690
	|-Enumerable.WhereSelectListIterator<CropDataTable, Label>.Where
	|
	|-RVA: 0x2A59950 Offset: 0x2A59A51 VA: 0x2A59950
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, CropDataTable>.Where
	|
	|-RVA: 0x2A59C00 Offset: 0x2A59D01 VA: 0x2A59C00
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Where
	|
	|-RVA: 0x2A59EB0 Offset: 0x2A59FB1 VA: 0x2A59EB0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|
	|-RVA: 0x2A5A170 Offset: 0x2A5A271 VA: 0x2A5A170
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Where
	|
	|-RVA: 0x2A5A420 Offset: 0x2A5A521 VA: 0x2A5A420
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Label>.Where
	|
	|-RVA: 0x2A5A6D0 Offset: 0x2A5A7D1 VA: 0x2A5A6D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.Where
	|
	|-RVA: 0x2A5A980 Offset: 0x2A5AA81 VA: 0x2A5A980
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Vector2>.Where
	|
	|-RVA: 0x2A5AC30 Offset: 0x2A5AD31 VA: 0x2A5AC30
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Vector3>.Where
	|
	|-RVA: 0x2A5AEF0 Offset: 0x2A5AFF1 VA: 0x2A5AEF0
	|-Enumerable.WhereSelectListIterator<int, CropDataTable>.Where
	|
	|-RVA: 0x2A5B190 Offset: 0x2A5B291 VA: 0x2A5B190
	|-Enumerable.WhereSelectListIterator<int, int>.Where
	|
	|-RVA: 0x2A5B430 Offset: 0x2A5B531 VA: 0x2A5B430
	|-Enumerable.WhereSelectListIterator<int, Int32Enum>.Where
	|
	|-RVA: 0x2A5B6D0 Offset: 0x2A5B7D1 VA: 0x2A5B6D0
	|-Enumerable.WhereSelectListIterator<int, object>.Where
	|
	|-RVA: 0x2A5B970 Offset: 0x2A5BA71 VA: 0x2A5B970
	|-Enumerable.WhereSelectListIterator<int, Label>.Where
	|
	|-RVA: 0x2A5BC10 Offset: 0x2A5BD11 VA: 0x2A5BC10
	|-Enumerable.WhereSelectListIterator<int, float>.Where
	|
	|-RVA: 0x2A5BEB0 Offset: 0x2A5BFB1 VA: 0x2A5BEB0
	|-Enumerable.WhereSelectListIterator<int, Vector2>.Where
	|
	|-RVA: 0x2A5C150 Offset: 0x2A5C251 VA: 0x2A5C150
	|-Enumerable.WhereSelectListIterator<int, Vector3>.Where
	|
	|-RVA: 0x2A5C410 Offset: 0x2A5C511 VA: 0x2A5C410
	|-Enumerable.WhereSelectListIterator<Int32Enum, CropDataTable>.Where
	|
	|-RVA: 0x2A5C6B0 Offset: 0x2A5C7B1 VA: 0x2A5C6B0
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Where
	|
	|-RVA: 0x2A5C950 Offset: 0x2A5CA51 VA: 0x2A5C950
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Where
	|
	|-RVA: 0x2A5CBF0 Offset: 0x2A5CCF1 VA: 0x2A5CBF0
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Where
	|
	|-RVA: 0x2A5CE90 Offset: 0x2A5CF91 VA: 0x2A5CE90
	|-Enumerable.WhereSelectListIterator<Int32Enum, Label>.Where
	|
	|-RVA: 0x2A5D130 Offset: 0x2A5D231 VA: 0x2A5D130
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.Where
	|
	|-RVA: 0x2A5D3D0 Offset: 0x2A5D4D1 VA: 0x2A5D3D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2A5D670 Offset: 0x2A5D771 VA: 0x2A5D670
	|-Enumerable.WhereSelectListIterator<Int32Enum, Vector2>.Where
	|
	|-RVA: 0x2A5D910 Offset: 0x2A5DA11 VA: 0x2A5D910
	|-Enumerable.WhereSelectListIterator<Int32Enum, Vector3>.Where
	|
	|-RVA: 0x2A5DBD0 Offset: 0x2A5DCD1 VA: 0x2A5DBD0
	|-Enumerable.WhereSelectListIterator<object, CropDataTable>.Where
	|
	|-RVA: 0x2A5DE70 Offset: 0x2A5DF71 VA: 0x2A5DE70
	|-Enumerable.WhereSelectListIterator<object, int>.Where
	|
	|-RVA: 0x2A5E110 Offset: 0x2A5E211 VA: 0x2A5E110
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Where
	|
	|-RVA: 0x2A5E3B0 Offset: 0x2A5E4B1 VA: 0x2A5E3B0
	|-Enumerable.WhereSelectListIterator<object, object>.Where
	|
	|-RVA: 0x2A5E650 Offset: 0x2A5E751 VA: 0x2A5E650
	|-Enumerable.WhereSelectListIterator<object, Label>.Where
	|
	|-RVA: 0x2A5E8F0 Offset: 0x2A5E9F1 VA: 0x2A5E8F0
	|-Enumerable.WhereSelectListIterator<object, float>.Where
	|
	|-RVA: 0x2A5EB90 Offset: 0x2A5EC91 VA: 0x2A5EB90
	|-Enumerable.WhereSelectListIterator<object, ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2A5EE30 Offset: 0x2A5EF31 VA: 0x2A5EE30
	|-Enumerable.WhereSelectListIterator<object, Vector2>.Where
	|
	|-RVA: 0x2A5F0D0 Offset: 0x2A5F1D1 VA: 0x2A5F0D0
	|-Enumerable.WhereSelectListIterator<object, Vector3>.Where
	|
	|-RVA: 0x2A5F390 Offset: 0x2A5F491 VA: 0x2A5F390
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, CropDataTable>.Where
	|
	|-RVA: 0x2A5F640 Offset: 0x2A5F741 VA: 0x2A5F640
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, int>.Where
	|
	|-RVA: 0x2A5F8F0 Offset: 0x2A5F9F1 VA: 0x2A5F8F0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Where
	|
	|-RVA: 0x2A5FBB0 Offset: 0x2A5FCB1 VA: 0x2A5FBB0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, object>.Where
	|
	|-RVA: 0x2A5FE60 Offset: 0x2A5FF61 VA: 0x2A5FE60
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Label>.Where
	|
	|-RVA: 0x2A60110 Offset: 0x2A60211 VA: 0x2A60110
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, float>.Where
	|
	|-RVA: 0x2A603C0 Offset: 0x2A604C1 VA: 0x2A603C0
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2A60670 Offset: 0x2A60771 VA: 0x2A60670
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Vector2>.Where
	|
	|-RVA: 0x2A60920 Offset: 0x2A60A21 VA: 0x2A60920
	|-Enumerable.WhereSelectListIterator<ValueTuple<object, Int32Enum>, Vector3>.Where
	|
	|-RVA: 0x2A60BF0 Offset: 0x2A60CF1 VA: 0x2A60BF0
	|-Enumerable.WhereSelectListIterator<Vector4, Vector2>.Where
	*/
}

