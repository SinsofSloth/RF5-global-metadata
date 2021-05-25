private class Enumerable.WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 2169
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFA7F0 Offset: 0x2BFA8F1 VA: 0x2BFA7F0
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, int>..ctor
	|
	|-RVA: 0x2BFAB30 Offset: 0x2BFAC31 VA: 0x2BFAB30
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, object>..ctor
	|
	|-RVA: 0x2BFAE80 Offset: 0x2BFAF81 VA: 0x2BFAE80
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, Label>..ctor
	|
	|-RVA: 0x2BFB1C0 Offset: 0x2BFB2C1 VA: 0x2BFB1C0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, CropDataTable>..ctor
	|
	|-RVA: 0x2BFB450 Offset: 0x2BFB551 VA: 0x2BFB450
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x2BFB6C0 Offset: 0x2BFB7C1 VA: 0x2BFB6C0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|
	|-RVA: 0x2BFB930 Offset: 0x2BFBA31 VA: 0x2BFB930
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x2BFBBB0 Offset: 0x2BFBCB1 VA: 0x2BFBBB0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Label>..ctor
	|
	|-RVA: 0x2BFBE20 Offset: 0x2BFBF21 VA: 0x2BFBE20
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>..ctor
	|
	|-RVA: 0x2BFC090 Offset: 0x2BFC191 VA: 0x2BFC090
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Vector2>..ctor
	|
	|-RVA: 0x2BFC300 Offset: 0x2BFC401 VA: 0x2BFC300
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Vector3>..ctor
	|
	|-RVA: 0x2BFC570 Offset: 0x2BFC671 VA: 0x2BFC570
	|-Enumerable.WhereSelectArrayIterator<int, CropDataTable>..ctor
	|
	|-RVA: 0x2BFC7F0 Offset: 0x2BFC8F1 VA: 0x2BFC7F0
	|-Enumerable.WhereSelectArrayIterator<int, int>..ctor
	|
	|-RVA: 0x2BFCA60 Offset: 0x2BFCB61 VA: 0x2BFCA60
	|-Enumerable.WhereSelectArrayIterator<int, Int32Enum>..ctor
	|
	|-RVA: 0x2BFCCD0 Offset: 0x2BFCDD1 VA: 0x2BFCCD0
	|-Enumerable.WhereSelectArrayIterator<int, object>..ctor
	|
	|-RVA: 0x2BFCF40 Offset: 0x2BFD041 VA: 0x2BFCF40
	|-Enumerable.WhereSelectArrayIterator<int, Label>..ctor
	|
	|-RVA: 0x2BFD1B0 Offset: 0x2BFD2B1 VA: 0x2BFD1B0
	|-Enumerable.WhereSelectArrayIterator<int, float>..ctor
	|
	|-RVA: 0x2BFD420 Offset: 0x2BFD521 VA: 0x2BFD420
	|-Enumerable.WhereSelectArrayIterator<int, Vector2>..ctor
	|
	|-RVA: 0x2BFD690 Offset: 0x2BFD791 VA: 0x2BFD690
	|-Enumerable.WhereSelectArrayIterator<int, Vector3>..ctor
	|
	|-RVA: 0x2BFD900 Offset: 0x2BFDA01 VA: 0x2BFD900
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, CropDataTable>..ctor
	|
	|-RVA: 0x2BFDB80 Offset: 0x2BFDC81 VA: 0x2BFDB80
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>..ctor
	|
	|-RVA: 0x2BFDDF0 Offset: 0x2BFDEF1 VA: 0x2BFDDF0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2BFE060 Offset: 0x2BFE161 VA: 0x2BFE060
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>..ctor
	|
	|-RVA: 0x2BFE2D0 Offset: 0x2BFE3D1 VA: 0x2BFE2D0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Label>..ctor
	|
	|-RVA: 0x2BFE540 Offset: 0x2BFE641 VA: 0x2BFE540
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>..ctor
	|
	|-RVA: 0x2BFE7B0 Offset: 0x2BFE8B1 VA: 0x2BFE7B0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2BFEA20 Offset: 0x2BFEB21 VA: 0x2BFEA20
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Vector2>..ctor
	|
	|-RVA: 0x2BFEC90 Offset: 0x2BFED91 VA: 0x2BFEC90
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Vector3>..ctor
	|
	|-RVA: 0x2BFEF00 Offset: 0x2BFF001 VA: 0x2BFEF00
	|-Enumerable.WhereSelectArrayIterator<object, CropDataTable>..ctor
	|
	|-RVA: 0x2BFF180 Offset: 0x2BFF281 VA: 0x2BFF180
	|-Enumerable.WhereSelectArrayIterator<object, int>..ctor
	|
	|-RVA: 0x2BFF3F0 Offset: 0x2BFF4F1 VA: 0x2BFF3F0
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>..ctor
	|
	|-RVA: 0x2BFF660 Offset: 0x2BFF761 VA: 0x2BFF660
	|-Enumerable.WhereSelectArrayIterator<object, object>..ctor
	|
	|-RVA: 0x2BFF8D0 Offset: 0x2BFF9D1 VA: 0x2BFF8D0
	|-Enumerable.WhereSelectArrayIterator<object, Label>..ctor
	|
	|-RVA: 0x2BFFB40 Offset: 0x2BFFC41 VA: 0x2BFFB40
	|-Enumerable.WhereSelectArrayIterator<object, float>..ctor
	|
	|-RVA: 0x2BFFDB0 Offset: 0x2BFFEB1 VA: 0x2BFFDB0
	|-Enumerable.WhereSelectArrayIterator<object, ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2C00020 Offset: 0x2C00121 VA: 0x2C00020
	|-Enumerable.WhereSelectArrayIterator<object, Vector2>..ctor
	|
	|-RVA: 0x2C00290 Offset: 0x2C00391 VA: 0x2C00290
	|-Enumerable.WhereSelectArrayIterator<object, Vector3>..ctor
	|
	|-RVA: 0x2C00500 Offset: 0x2C00601 VA: 0x2C00500
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, CropDataTable>..ctor
	|
	|-RVA: 0x2C00790 Offset: 0x2C00891 VA: 0x2C00790
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, int>..ctor
	|
	|-RVA: 0x2C00A00 Offset: 0x2C00B01 VA: 0x2C00A00
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Int32Enum>..ctor
	|
	|-RVA: 0x2C00C70 Offset: 0x2C00D71 VA: 0x2C00C70
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>..ctor
	|
	|-RVA: 0x2C00EF0 Offset: 0x2C00FF1 VA: 0x2C00EF0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Label>..ctor
	|
	|-RVA: 0x2C01160 Offset: 0x2C01261 VA: 0x2C01160
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, float>..ctor
	|
	|-RVA: 0x2C013D0 Offset: 0x2C014D1 VA: 0x2C013D0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2C01640 Offset: 0x2C01741 VA: 0x2C01640
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Vector2>..ctor
	|
	|-RVA: 0x2C018B0 Offset: 0x2C019B1 VA: 0x2C018B0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Vector3>..ctor
	|
	|-RVA: 0x2C01B20 Offset: 0x2C01C21 VA: 0x2C01B20
	|-Enumerable.WhereSelectArrayIterator<Vector4, Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFA870 Offset: 0x2BFA971 VA: 0x2BFA870
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, int>.Clone
	|
	|-RVA: 0x2BFABB0 Offset: 0x2BFACB1 VA: 0x2BFABB0
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, object>.Clone
	|
	|-RVA: 0x2BFAF00 Offset: 0x2BFB001 VA: 0x2BFAF00
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, Label>.Clone
	|
	|-RVA: 0x2BFB240 Offset: 0x2BFB341 VA: 0x2BFB240
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, CropDataTable>.Clone
	|
	|-RVA: 0x2BFB4D0 Offset: 0x2BFB5D1 VA: 0x2BFB4D0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Clone
	|
	|-RVA: 0x2BFB740 Offset: 0x2BFB841 VA: 0x2BFB740
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|
	|-RVA: 0x2BFB9B0 Offset: 0x2BFBAB1 VA: 0x2BFB9B0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Clone
	|
	|-RVA: 0x2BFBC30 Offset: 0x2BFBD31 VA: 0x2BFBC30
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Label>.Clone
	|
	|-RVA: 0x2BFBEA0 Offset: 0x2BFBFA1 VA: 0x2BFBEA0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.Clone
	|
	|-RVA: 0x2BFC110 Offset: 0x2BFC211 VA: 0x2BFC110
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Vector2>.Clone
	|
	|-RVA: 0x2BFC380 Offset: 0x2BFC481 VA: 0x2BFC380
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Vector3>.Clone
	|
	|-RVA: 0x2BFC5F0 Offset: 0x2BFC6F1 VA: 0x2BFC5F0
	|-Enumerable.WhereSelectArrayIterator<int, CropDataTable>.Clone
	|
	|-RVA: 0x2BFC870 Offset: 0x2BFC971 VA: 0x2BFC870
	|-Enumerable.WhereSelectArrayIterator<int, int>.Clone
	|
	|-RVA: 0x2BFCAE0 Offset: 0x2BFCBE1 VA: 0x2BFCAE0
	|-Enumerable.WhereSelectArrayIterator<int, Int32Enum>.Clone
	|
	|-RVA: 0x2BFCD50 Offset: 0x2BFCE51 VA: 0x2BFCD50
	|-Enumerable.WhereSelectArrayIterator<int, object>.Clone
	|
	|-RVA: 0x2BFCFC0 Offset: 0x2BFD0C1 VA: 0x2BFCFC0
	|-Enumerable.WhereSelectArrayIterator<int, Label>.Clone
	|
	|-RVA: 0x2BFD230 Offset: 0x2BFD331 VA: 0x2BFD230
	|-Enumerable.WhereSelectArrayIterator<int, float>.Clone
	|
	|-RVA: 0x2BFD4A0 Offset: 0x2BFD5A1 VA: 0x2BFD4A0
	|-Enumerable.WhereSelectArrayIterator<int, Vector2>.Clone
	|
	|-RVA: 0x2BFD710 Offset: 0x2BFD811 VA: 0x2BFD710
	|-Enumerable.WhereSelectArrayIterator<int, Vector3>.Clone
	|
	|-RVA: 0x2BFD980 Offset: 0x2BFDA81 VA: 0x2BFD980
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, CropDataTable>.Clone
	|
	|-RVA: 0x2BFDC00 Offset: 0x2BFDD01 VA: 0x2BFDC00
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Clone
	|
	|-RVA: 0x2BFDE70 Offset: 0x2BFDF71 VA: 0x2BFDE70
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Clone
	|
	|-RVA: 0x2BFE0E0 Offset: 0x2BFE1E1 VA: 0x2BFE0E0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Clone
	|
	|-RVA: 0x2BFE350 Offset: 0x2BFE451 VA: 0x2BFE350
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Label>.Clone
	|
	|-RVA: 0x2BFE5C0 Offset: 0x2BFE6C1 VA: 0x2BFE5C0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.Clone
	|
	|-RVA: 0x2BFE830 Offset: 0x2BFE931 VA: 0x2BFE830
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2BFEAA0 Offset: 0x2BFEBA1 VA: 0x2BFEAA0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Vector2>.Clone
	|
	|-RVA: 0x2BFED10 Offset: 0x2BFEE11 VA: 0x2BFED10
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Vector3>.Clone
	|
	|-RVA: 0x2BFEF80 Offset: 0x2BFF081 VA: 0x2BFEF80
	|-Enumerable.WhereSelectArrayIterator<object, CropDataTable>.Clone
	|
	|-RVA: 0x2BFF200 Offset: 0x2BFF301 VA: 0x2BFF200
	|-Enumerable.WhereSelectArrayIterator<object, int>.Clone
	|
	|-RVA: 0x2BFF470 Offset: 0x2BFF571 VA: 0x2BFF470
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Clone
	|
	|-RVA: 0x2BFF6E0 Offset: 0x2BFF7E1 VA: 0x2BFF6E0
	|-Enumerable.WhereSelectArrayIterator<object, object>.Clone
	|
	|-RVA: 0x2BFF950 Offset: 0x2BFFA51 VA: 0x2BFF950
	|-Enumerable.WhereSelectArrayIterator<object, Label>.Clone
	|
	|-RVA: 0x2BFFBC0 Offset: 0x2BFFCC1 VA: 0x2BFFBC0
	|-Enumerable.WhereSelectArrayIterator<object, float>.Clone
	|
	|-RVA: 0x2BFFE30 Offset: 0x2BFFF31 VA: 0x2BFFE30
	|-Enumerable.WhereSelectArrayIterator<object, ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2C000A0 Offset: 0x2C001A1 VA: 0x2C000A0
	|-Enumerable.WhereSelectArrayIterator<object, Vector2>.Clone
	|
	|-RVA: 0x2C00310 Offset: 0x2C00411 VA: 0x2C00310
	|-Enumerable.WhereSelectArrayIterator<object, Vector3>.Clone
	|
	|-RVA: 0x2C00580 Offset: 0x2C00681 VA: 0x2C00580
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, CropDataTable>.Clone
	|
	|-RVA: 0x2C00810 Offset: 0x2C00911 VA: 0x2C00810
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, int>.Clone
	|
	|-RVA: 0x2C00A80 Offset: 0x2C00B81 VA: 0x2C00A80
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Clone
	|
	|-RVA: 0x2C00CF0 Offset: 0x2C00DF1 VA: 0x2C00CF0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Clone
	|
	|-RVA: 0x2C00F70 Offset: 0x2C01071 VA: 0x2C00F70
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Label>.Clone
	|
	|-RVA: 0x2C011E0 Offset: 0x2C012E1 VA: 0x2C011E0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, float>.Clone
	|
	|-RVA: 0x2C01450 Offset: 0x2C01551 VA: 0x2C01450
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2C016C0 Offset: 0x2C017C1 VA: 0x2C016C0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Vector2>.Clone
	|
	|-RVA: 0x2C01930 Offset: 0x2C01A31 VA: 0x2C01930
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Vector3>.Clone
	|
	|-RVA: 0x2C01BA0 Offset: 0x2C01CA1 VA: 0x2C01BA0
	|-Enumerable.WhereSelectArrayIterator<Vector4, Vector2>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFA8F0 Offset: 0x2BFA9F1 VA: 0x2BFA8F0
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, int>.MoveNext
	|
	|-RVA: 0x2BFAC30 Offset: 0x2BFAD31 VA: 0x2BFAC30
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, object>.MoveNext
	|
	|-RVA: 0x2BFAF80 Offset: 0x2BFB081 VA: 0x2BFAF80
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, Label>.MoveNext
	|
	|-RVA: 0x2BFB2C0 Offset: 0x2BFB3C1 VA: 0x2BFB2C0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, CropDataTable>.MoveNext
	|
	|-RVA: 0x2BFB550 Offset: 0x2BFB651 VA: 0x2BFB550
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x2BFB7C0 Offset: 0x2BFB8C1 VA: 0x2BFB7C0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2BFBA30 Offset: 0x2BFBB31 VA: 0x2BFBA30
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x2BFBCB0 Offset: 0x2BFBDB1 VA: 0x2BFBCB0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Label>.MoveNext
	|
	|-RVA: 0x2BFBF20 Offset: 0x2BFC021 VA: 0x2BFBF20
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x2BFC190 Offset: 0x2BFC291 VA: 0x2BFC190
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Vector2>.MoveNext
	|
	|-RVA: 0x2BFC400 Offset: 0x2BFC501 VA: 0x2BFC400
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Vector3>.MoveNext
	|
	|-RVA: 0x2BFC670 Offset: 0x2BFC771 VA: 0x2BFC670
	|-Enumerable.WhereSelectArrayIterator<int, CropDataTable>.MoveNext
	|
	|-RVA: 0x2BFC8F0 Offset: 0x2BFC9F1 VA: 0x2BFC8F0
	|-Enumerable.WhereSelectArrayIterator<int, int>.MoveNext
	|
	|-RVA: 0x2BFCB60 Offset: 0x2BFCC61 VA: 0x2BFCB60
	|-Enumerable.WhereSelectArrayIterator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x2BFCDD0 Offset: 0x2BFCED1 VA: 0x2BFCDD0
	|-Enumerable.WhereSelectArrayIterator<int, object>.MoveNext
	|
	|-RVA: 0x2BFD040 Offset: 0x2BFD141 VA: 0x2BFD040
	|-Enumerable.WhereSelectArrayIterator<int, Label>.MoveNext
	|
	|-RVA: 0x2BFD2B0 Offset: 0x2BFD3B1 VA: 0x2BFD2B0
	|-Enumerable.WhereSelectArrayIterator<int, float>.MoveNext
	|
	|-RVA: 0x2BFD520 Offset: 0x2BFD621 VA: 0x2BFD520
	|-Enumerable.WhereSelectArrayIterator<int, Vector2>.MoveNext
	|
	|-RVA: 0x2BFD790 Offset: 0x2BFD891 VA: 0x2BFD790
	|-Enumerable.WhereSelectArrayIterator<int, Vector3>.MoveNext
	|
	|-RVA: 0x2BFDA00 Offset: 0x2BFDB01 VA: 0x2BFDA00
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, CropDataTable>.MoveNext
	|
	|-RVA: 0x2BFDC80 Offset: 0x2BFDD81 VA: 0x2BFDC80
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x2BFDEF0 Offset: 0x2BFDFF1 VA: 0x2BFDEF0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x2BFE160 Offset: 0x2BFE261 VA: 0x2BFE160
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x2BFE3D0 Offset: 0x2BFE4D1 VA: 0x2BFE3D0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Label>.MoveNext
	|
	|-RVA: 0x2BFE640 Offset: 0x2BFE741 VA: 0x2BFE640
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x2BFE8B0 Offset: 0x2BFE9B1 VA: 0x2BFE8B0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2BFEB20 Offset: 0x2BFEC21 VA: 0x2BFEB20
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Vector2>.MoveNext
	|
	|-RVA: 0x2BFED90 Offset: 0x2BFEE91 VA: 0x2BFED90
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Vector3>.MoveNext
	|
	|-RVA: 0x2BFF000 Offset: 0x2BFF101 VA: 0x2BFF000
	|-Enumerable.WhereSelectArrayIterator<object, CropDataTable>.MoveNext
	|
	|-RVA: 0x2BFF280 Offset: 0x2BFF381 VA: 0x2BFF280
	|-Enumerable.WhereSelectArrayIterator<object, int>.MoveNext
	|
	|-RVA: 0x2BFF4F0 Offset: 0x2BFF5F1 VA: 0x2BFF4F0
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x2BFF760 Offset: 0x2BFF861 VA: 0x2BFF760
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0x2BFF9D0 Offset: 0x2BFFAD1 VA: 0x2BFF9D0
	|-Enumerable.WhereSelectArrayIterator<object, Label>.MoveNext
	|
	|-RVA: 0x2BFFC40 Offset: 0x2BFFD41 VA: 0x2BFFC40
	|-Enumerable.WhereSelectArrayIterator<object, float>.MoveNext
	|
	|-RVA: 0x2BFFEB0 Offset: 0x2BFFFB1 VA: 0x2BFFEB0
	|-Enumerable.WhereSelectArrayIterator<object, ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2C00120 Offset: 0x2C00221 VA: 0x2C00120
	|-Enumerable.WhereSelectArrayIterator<object, Vector2>.MoveNext
	|
	|-RVA: 0x2C00390 Offset: 0x2C00491 VA: 0x2C00390
	|-Enumerable.WhereSelectArrayIterator<object, Vector3>.MoveNext
	|
	|-RVA: 0x2C00600 Offset: 0x2C00701 VA: 0x2C00600
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, CropDataTable>.MoveNext
	|
	|-RVA: 0x2C00890 Offset: 0x2C00991 VA: 0x2C00890
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, int>.MoveNext
	|
	|-RVA: 0x2C00B00 Offset: 0x2C00C01 VA: 0x2C00B00
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2C00D70 Offset: 0x2C00E71 VA: 0x2C00D70
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.MoveNext
	|
	|-RVA: 0x2C00FF0 Offset: 0x2C010F1 VA: 0x2C00FF0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Label>.MoveNext
	|
	|-RVA: 0x2C01260 Offset: 0x2C01361 VA: 0x2C01260
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, float>.MoveNext
	|
	|-RVA: 0x2C014D0 Offset: 0x2C015D1 VA: 0x2C014D0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2C01740 Offset: 0x2C01841 VA: 0x2C01740
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Vector2>.MoveNext
	|
	|-RVA: 0x2C019B0 Offset: 0x2C01AB1 VA: 0x2C019B0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Vector3>.MoveNext
	|
	|-RVA: 0x2C01C20 Offset: 0x2C01D21 VA: 0x2C01C20
	|-Enumerable.WhereSelectArrayIterator<Vector4, Vector2>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D5430 Offset: 0x22D5531 VA: 0x22D5430
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, int>.Select<object>
	|
	|-RVA: 0x22D54C0 Offset: 0x22D55C1 VA: 0x22D54C0
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, int>.Select<Label>
	|
	|-RVA: 0x22D5550 Offset: 0x22D5651 VA: 0x22D5550
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<CropDataTable>
	|
	|-RVA: 0x22D55E0 Offset: 0x22D56E1 VA: 0x22D55E0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<int>
	|
	|-RVA: 0x22D5670 Offset: 0x22D5771 VA: 0x22D5670
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|
	|-RVA: 0x22D5700 Offset: 0x22D5801 VA: 0x22D5700
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<object>
	|
	|-RVA: 0x22D5790 Offset: 0x22D5891 VA: 0x22D5790
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Label>
	|
	|-RVA: 0x22D5820 Offset: 0x22D5921 VA: 0x22D5820
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<float>
	|
	|-RVA: 0x22D58B0 Offset: 0x22D59B1 VA: 0x22D58B0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Vector2>
	|
	|-RVA: 0x22D5940 Offset: 0x22D5A41 VA: 0x22D5940
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Vector3>
	|
	|-RVA: 0x22D59D0 Offset: 0x22D5AD1 VA: 0x22D59D0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<CropDataTable>
	|
	|-RVA: 0x22D5A60 Offset: 0x22D5B61 VA: 0x22D5A60
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<int>
	|
	|-RVA: 0x22D5AF0 Offset: 0x22D5BF1 VA: 0x22D5AF0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<Int32Enum>
	|
	|-RVA: 0x22D5B80 Offset: 0x22D5C81 VA: 0x22D5B80
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<object>
	|
	|-RVA: 0x22D5C10 Offset: 0x22D5D11 VA: 0x22D5C10
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<Label>
	|
	|-RVA: 0x22D5CA0 Offset: 0x22D5DA1 VA: 0x22D5CA0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<float>
	|
	|-RVA: 0x22D5D30 Offset: 0x22D5E31 VA: 0x22D5D30
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<Vector2>
	|
	|-RVA: 0x22D5DC0 Offset: 0x22D5EC1 VA: 0x22D5DC0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<Vector3>
	|
	|-RVA: 0x22D5E50 Offset: 0x22D5F51 VA: 0x22D5E50
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<CropDataTable>
	|
	|-RVA: 0x22D5EE0 Offset: 0x22D5FE1 VA: 0x22D5EE0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<int>
	|
	|-RVA: 0x22D5F70 Offset: 0x22D6071 VA: 0x22D5F70
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Int32Enum>
	|
	|-RVA: 0x22D6000 Offset: 0x22D6101 VA: 0x22D6000
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<object>
	|
	|-RVA: 0x22D6090 Offset: 0x22D6191 VA: 0x22D6090
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Label>
	|
	|-RVA: 0x22D6120 Offset: 0x22D6221 VA: 0x22D6120
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<float>
	|
	|-RVA: 0x22D61B0 Offset: 0x22D62B1 VA: 0x22D61B0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Vector2>
	|
	|-RVA: 0x22D6240 Offset: 0x22D6341 VA: 0x22D6240
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Vector3>
	|
	|-RVA: 0x22D62D0 Offset: 0x22D63D1 VA: 0x22D62D0
	|-Enumerable.WhereSelectArrayIterator<object, CropDataTable>.Select<int>
	|
	|-RVA: 0x22D6360 Offset: 0x22D6461 VA: 0x22D6360
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<object>
	|
	|-RVA: 0x22D63F0 Offset: 0x22D64F1 VA: 0x22D63F0
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<Label>
	|
	|-RVA: 0x22D6480 Offset: 0x22D6581 VA: 0x22D6480
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Select<object>
	|
	|-RVA: 0x22D6510 Offset: 0x22D6611 VA: 0x22D6510
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Select<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x22D65A0 Offset: 0x22D66A1 VA: 0x22D65A0
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<CropDataTable>
	|
	|-RVA: 0x22D6630 Offset: 0x22D6731 VA: 0x22D6630
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<int>
	|
	|-RVA: 0x22D66C0 Offset: 0x22D67C1 VA: 0x22D66C0
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Int32Enum>
	|
	|-RVA: 0x22D6750 Offset: 0x22D6851 VA: 0x22D6750
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<object>
	|
	|-RVA: 0x22D67E0 Offset: 0x22D68E1 VA: 0x22D67E0
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Label>
	|
	|-RVA: 0x22D6870 Offset: 0x22D6971 VA: 0x22D6870
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<float>
	|
	|-RVA: 0x22D6900 Offset: 0x22D6A01 VA: 0x22D6900
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Vector2>
	|
	|-RVA: 0x22D6990 Offset: 0x22D6A91 VA: 0x22D6990
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Vector3>
	|
	|-RVA: 0x22D6A20 Offset: 0x22D6B21 VA: 0x22D6A20
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Select<object>
	|
	|-RVA: 0x22D6AB0 Offset: 0x22D6BB1 VA: 0x22D6AB0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Select<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x22D6B40 Offset: 0x22D6C41 VA: 0x22D6B40
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Select<CropDataTable>
	|
	|-RVA: 0x22D6BD0 Offset: 0x22D6CD1 VA: 0x22D6BD0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Select<int>
	|
	|-RVA: 0x22D6C60 Offset: 0x22D6D61 VA: 0x22D6C60
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Select<Int32Enum>
	|
	|-RVA: 0x22D6CF0 Offset: 0x22D6DF1 VA: 0x22D6CF0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Select<object>
	|
	|-RVA: 0x22D6D80 Offset: 0x22D6E81 VA: 0x22D6D80
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Select<Label>
	|
	|-RVA: 0x22D6E10 Offset: 0x22D6F11 VA: 0x22D6E10
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Select<float>
	|
	|-RVA: 0x22D6EA0 Offset: 0x22D6FA1 VA: 0x22D6EA0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Select<Vector2>
	|
	|-RVA: 0x22D6F30 Offset: 0x22D7031 VA: 0x22D6F30
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Select<Vector3>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFAAB0 Offset: 0x2BFABB1 VA: 0x2BFAAB0
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, int>.Where
	|
	|-RVA: 0x2BFAE00 Offset: 0x2BFAF01 VA: 0x2BFAE00
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, object>.Where
	|
	|-RVA: 0x2BFB140 Offset: 0x2BFB241 VA: 0x2BFB140
	|-Enumerable.WhereSelectArrayIterator<CropDataTable, Label>.Where
	|
	|-RVA: 0x2BFB3D0 Offset: 0x2BFB4D1 VA: 0x2BFB3D0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, CropDataTable>.Where
	|
	|-RVA: 0x2BFB640 Offset: 0x2BFB741 VA: 0x2BFB640
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Where
	|
	|-RVA: 0x2BFB8B0 Offset: 0x2BFB9B1 VA: 0x2BFB8B0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|
	|-RVA: 0x2BFBB30 Offset: 0x2BFBC31 VA: 0x2BFBB30
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Where
	|
	|-RVA: 0x2BFBDA0 Offset: 0x2BFBEA1 VA: 0x2BFBDA0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Label>.Where
	|
	|-RVA: 0x2BFC010 Offset: 0x2BFC111 VA: 0x2BFC010
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.Where
	|
	|-RVA: 0x2BFC280 Offset: 0x2BFC381 VA: 0x2BFC280
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Vector2>.Where
	|
	|-RVA: 0x2BFC4F0 Offset: 0x2BFC5F1 VA: 0x2BFC4F0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Vector3>.Where
	|
	|-RVA: 0x2BFC770 Offset: 0x2BFC871 VA: 0x2BFC770
	|-Enumerable.WhereSelectArrayIterator<int, CropDataTable>.Where
	|
	|-RVA: 0x2BFC9E0 Offset: 0x2BFCAE1 VA: 0x2BFC9E0
	|-Enumerable.WhereSelectArrayIterator<int, int>.Where
	|
	|-RVA: 0x2BFCC50 Offset: 0x2BFCD51 VA: 0x2BFCC50
	|-Enumerable.WhereSelectArrayIterator<int, Int32Enum>.Where
	|
	|-RVA: 0x2BFCEC0 Offset: 0x2BFCFC1 VA: 0x2BFCEC0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Where
	|
	|-RVA: 0x2BFD130 Offset: 0x2BFD231 VA: 0x2BFD130
	|-Enumerable.WhereSelectArrayIterator<int, Label>.Where
	|
	|-RVA: 0x2BFD3A0 Offset: 0x2BFD4A1 VA: 0x2BFD3A0
	|-Enumerable.WhereSelectArrayIterator<int, float>.Where
	|
	|-RVA: 0x2BFD610 Offset: 0x2BFD711 VA: 0x2BFD610
	|-Enumerable.WhereSelectArrayIterator<int, Vector2>.Where
	|
	|-RVA: 0x2BFD880 Offset: 0x2BFD981 VA: 0x2BFD880
	|-Enumerable.WhereSelectArrayIterator<int, Vector3>.Where
	|
	|-RVA: 0x2BFDB00 Offset: 0x2BFDC01 VA: 0x2BFDB00
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, CropDataTable>.Where
	|
	|-RVA: 0x2BFDD70 Offset: 0x2BFDE71 VA: 0x2BFDD70
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Where
	|
	|-RVA: 0x2BFDFE0 Offset: 0x2BFE0E1 VA: 0x2BFDFE0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Where
	|
	|-RVA: 0x2BFE250 Offset: 0x2BFE351 VA: 0x2BFE250
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Where
	|
	|-RVA: 0x2BFE4C0 Offset: 0x2BFE5C1 VA: 0x2BFE4C0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Label>.Where
	|
	|-RVA: 0x2BFE730 Offset: 0x2BFE831 VA: 0x2BFE730
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.Where
	|
	|-RVA: 0x2BFE9A0 Offset: 0x2BFEAA1 VA: 0x2BFE9A0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2BFEC10 Offset: 0x2BFED11 VA: 0x2BFEC10
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Vector2>.Where
	|
	|-RVA: 0x2BFEE80 Offset: 0x2BFEF81 VA: 0x2BFEE80
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Vector3>.Where
	|
	|-RVA: 0x2BFF100 Offset: 0x2BFF201 VA: 0x2BFF100
	|-Enumerable.WhereSelectArrayIterator<object, CropDataTable>.Where
	|
	|-RVA: 0x2BFF370 Offset: 0x2BFF471 VA: 0x2BFF370
	|-Enumerable.WhereSelectArrayIterator<object, int>.Where
	|
	|-RVA: 0x2BFF5E0 Offset: 0x2BFF6E1 VA: 0x2BFF5E0
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Where
	|
	|-RVA: 0x2BFF850 Offset: 0x2BFF951 VA: 0x2BFF850
	|-Enumerable.WhereSelectArrayIterator<object, object>.Where
	|
	|-RVA: 0x2BFFAC0 Offset: 0x2BFFBC1 VA: 0x2BFFAC0
	|-Enumerable.WhereSelectArrayIterator<object, Label>.Where
	|
	|-RVA: 0x2BFFD30 Offset: 0x2BFFE31 VA: 0x2BFFD30
	|-Enumerable.WhereSelectArrayIterator<object, float>.Where
	|
	|-RVA: 0x2BFFFA0 Offset: 0x2C000A1 VA: 0x2BFFFA0
	|-Enumerable.WhereSelectArrayIterator<object, ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2C00210 Offset: 0x2C00311 VA: 0x2C00210
	|-Enumerable.WhereSelectArrayIterator<object, Vector2>.Where
	|
	|-RVA: 0x2C00480 Offset: 0x2C00581 VA: 0x2C00480
	|-Enumerable.WhereSelectArrayIterator<object, Vector3>.Where
	|
	|-RVA: 0x2C00710 Offset: 0x2C00811 VA: 0x2C00710
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, CropDataTable>.Where
	|
	|-RVA: 0x2C00980 Offset: 0x2C00A81 VA: 0x2C00980
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, int>.Where
	|
	|-RVA: 0x2C00BF0 Offset: 0x2C00CF1 VA: 0x2C00BF0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Where
	|
	|-RVA: 0x2C00E70 Offset: 0x2C00F71 VA: 0x2C00E70
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, object>.Where
	|
	|-RVA: 0x2C010E0 Offset: 0x2C011E1 VA: 0x2C010E0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Label>.Where
	|
	|-RVA: 0x2C01350 Offset: 0x2C01451 VA: 0x2C01350
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, float>.Where
	|
	|-RVA: 0x2C015C0 Offset: 0x2C016C1 VA: 0x2C015C0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2C01830 Offset: 0x2C01931 VA: 0x2C01830
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Vector2>.Where
	|
	|-RVA: 0x2C01AA0 Offset: 0x2C01BA1 VA: 0x2C01AA0
	|-Enumerable.WhereSelectArrayIterator<ValueTuple<object, Int32Enum>, Vector3>.Where
	|
	|-RVA: 0x2C01D20 Offset: 0x2C01E21 VA: 0x2C01D20
	|-Enumerable.WhereSelectArrayIterator<Vector4, Vector2>.Where
	*/
}

