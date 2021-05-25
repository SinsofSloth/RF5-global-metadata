private class Enumerable.WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 2168
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01DA0 Offset: 0x2C01EA1 VA: 0x2C01DA0
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, int>..ctor
	|
	|-RVA: 0x2C02380 Offset: 0x2C02481 VA: 0x2C02380
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, object>..ctor
	|
	|-RVA: 0x2C02970 Offset: 0x2C02A71 VA: 0x2C02970
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, Label>..ctor
	|
	|-RVA: 0x2C02F50 Offset: 0x2C03051 VA: 0x2C02F50
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, CropDataTable>..ctor
	|
	|-RVA: 0x2C03480 Offset: 0x2C03581 VA: 0x2C03480
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x2C03990 Offset: 0x2C03A91 VA: 0x2C03990
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|
	|-RVA: 0x2C03EA0 Offset: 0x2C03FA1 VA: 0x2C03EA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x2C043C0 Offset: 0x2C044C1 VA: 0x2C043C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Label>..ctor
	|
	|-RVA: 0x2C048D0 Offset: 0x2C049D1 VA: 0x2C048D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>..ctor
	|
	|-RVA: 0x2C04DE0 Offset: 0x2C04EE1 VA: 0x2C04DE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector2>..ctor
	|
	|-RVA: 0x2C052F0 Offset: 0x2C053F1 VA: 0x2C052F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector3>..ctor
	|
	|-RVA: 0x2C05810 Offset: 0x2C05911 VA: 0x2C05810
	|-Enumerable.WhereSelectEnumerableIterator<int, CropDataTable>..ctor
	|
	|-RVA: 0x2C05D30 Offset: 0x2C05E31 VA: 0x2C05D30
	|-Enumerable.WhereSelectEnumerableIterator<int, int>..ctor
	|
	|-RVA: 0x2C06240 Offset: 0x2C06341 VA: 0x2C06240
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>..ctor
	|
	|-RVA: 0x2C06750 Offset: 0x2C06851 VA: 0x2C06750
	|-Enumerable.WhereSelectEnumerableIterator<int, object>..ctor
	|
	|-RVA: 0x2C06C60 Offset: 0x2C06D61 VA: 0x2C06C60
	|-Enumerable.WhereSelectEnumerableIterator<int, Label>..ctor
	|
	|-RVA: 0x2C07170 Offset: 0x2C07271 VA: 0x2C07170
	|-Enumerable.WhereSelectEnumerableIterator<int, float>..ctor
	|
	|-RVA: 0x2C07680 Offset: 0x2C07781 VA: 0x2C07680
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector2>..ctor
	|
	|-RVA: 0x2C07B90 Offset: 0x2C07C91 VA: 0x2C07B90
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector3>..ctor
	|
	|-RVA: 0x2C080A0 Offset: 0x2C081A1 VA: 0x2C080A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, CropDataTable>..ctor
	|
	|-RVA: 0x2C085C0 Offset: 0x2C086C1 VA: 0x2C085C0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>..ctor
	|
	|-RVA: 0x2C08AD0 Offset: 0x2C08BD1 VA: 0x2C08AD0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2C08FE0 Offset: 0x2C090E1 VA: 0x2C08FE0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>..ctor
	|
	|-RVA: 0x2C094F0 Offset: 0x2C095F1 VA: 0x2C094F0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Label>..ctor
	|
	|-RVA: 0x2C09A00 Offset: 0x2C09B01 VA: 0x2C09A00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>..ctor
	|
	|-RVA: 0x2C09F10 Offset: 0x2C0A011 VA: 0x2C09F10
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2C0A420 Offset: 0x2C0A521 VA: 0x2C0A420
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector2>..ctor
	|
	|-RVA: 0x2A526E0 Offset: 0x2A527E1 VA: 0x2A526E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector3>..ctor
	|
	|-RVA: 0x2A52BF0 Offset: 0x2A52CF1 VA: 0x2A52BF0
	|-Enumerable.WhereSelectEnumerableIterator<object, CropDataTable>..ctor
	|
	|-RVA: 0x2A53110 Offset: 0x2A53211 VA: 0x2A53110
	|-Enumerable.WhereSelectEnumerableIterator<object, int>..ctor
	|
	|-RVA: 0x2A53620 Offset: 0x2A53721 VA: 0x2A53620
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>..ctor
	|
	|-RVA: 0x2A53B30 Offset: 0x2A53C31 VA: 0x2A53B30
	|-Enumerable.WhereSelectEnumerableIterator<object, object>..ctor
	|
	|-RVA: 0x2A54040 Offset: 0x2A54141 VA: 0x2A54040
	|-Enumerable.WhereSelectEnumerableIterator<object, Label>..ctor
	|
	|-RVA: 0x2A54550 Offset: 0x2A54651 VA: 0x2A54550
	|-Enumerable.WhereSelectEnumerableIterator<object, float>..ctor
	|
	|-RVA: 0x2A54A60 Offset: 0x2A54B61 VA: 0x2A54A60
	|-Enumerable.WhereSelectEnumerableIterator<object, ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2A54F70 Offset: 0x2A55071 VA: 0x2A54F70
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector2>..ctor
	|
	|-RVA: 0x2A55480 Offset: 0x2A55581 VA: 0x2A55480
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>..ctor
	|
	|-RVA: 0x2A55990 Offset: 0x2A55A91 VA: 0x2A55990
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, CropDataTable>..ctor
	|
	|-RVA: 0x2A55EC0 Offset: 0x2A55FC1 VA: 0x2A55EC0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, int>..ctor
	|
	|-RVA: 0x2A563D0 Offset: 0x2A564D1 VA: 0x2A563D0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Int32Enum>..ctor
	|
	|-RVA: 0x2A568E0 Offset: 0x2A569E1 VA: 0x2A568E0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>..ctor
	|
	|-RVA: 0x2A56E00 Offset: 0x2A56F01 VA: 0x2A56E00
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Label>..ctor
	|
	|-RVA: 0x2A57310 Offset: 0x2A57411 VA: 0x2A57310
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, float>..ctor
	|
	|-RVA: 0x2A57820 Offset: 0x2A57921 VA: 0x2A57820
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2A57D30 Offset: 0x2A57E31 VA: 0x2A57D30
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector2>..ctor
	|
	|-RVA: 0x2A58240 Offset: 0x2A58341 VA: 0x2A58240
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector3>..ctor
	|
	|-RVA: 0x2A58760 Offset: 0x2A58861 VA: 0x2A58760
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01E20 Offset: 0x2C01F21 VA: 0x2C01E20
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, int>.Clone
	|
	|-RVA: 0x2C02400 Offset: 0x2C02501 VA: 0x2C02400
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, object>.Clone
	|
	|-RVA: 0x2C029F0 Offset: 0x2C02AF1 VA: 0x2C029F0
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, Label>.Clone
	|
	|-RVA: 0x2C02FD0 Offset: 0x2C030D1 VA: 0x2C02FD0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, CropDataTable>.Clone
	|
	|-RVA: 0x2C03500 Offset: 0x2C03601 VA: 0x2C03500
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Clone
	|
	|-RVA: 0x2C03A10 Offset: 0x2C03B11 VA: 0x2C03A10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|
	|-RVA: 0x2C03F20 Offset: 0x2C04021 VA: 0x2C03F20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Clone
	|
	|-RVA: 0x2C04440 Offset: 0x2C04541 VA: 0x2C04440
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Label>.Clone
	|
	|-RVA: 0x2C04950 Offset: 0x2C04A51 VA: 0x2C04950
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Clone
	|
	|-RVA: 0x2C04E60 Offset: 0x2C04F61 VA: 0x2C04E60
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector2>.Clone
	|
	|-RVA: 0x2C05370 Offset: 0x2C05471 VA: 0x2C05370
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector3>.Clone
	|
	|-RVA: 0x2C05890 Offset: 0x2C05991 VA: 0x2C05890
	|-Enumerable.WhereSelectEnumerableIterator<int, CropDataTable>.Clone
	|
	|-RVA: 0x2C05DB0 Offset: 0x2C05EB1 VA: 0x2C05DB0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Clone
	|
	|-RVA: 0x2C062C0 Offset: 0x2C063C1 VA: 0x2C062C0
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>.Clone
	|
	|-RVA: 0x2C067D0 Offset: 0x2C068D1 VA: 0x2C067D0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Clone
	|
	|-RVA: 0x2C06CE0 Offset: 0x2C06DE1 VA: 0x2C06CE0
	|-Enumerable.WhereSelectEnumerableIterator<int, Label>.Clone
	|
	|-RVA: 0x2C071F0 Offset: 0x2C072F1 VA: 0x2C071F0
	|-Enumerable.WhereSelectEnumerableIterator<int, float>.Clone
	|
	|-RVA: 0x2C07700 Offset: 0x2C07801 VA: 0x2C07700
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector2>.Clone
	|
	|-RVA: 0x2C07C10 Offset: 0x2C07D11 VA: 0x2C07C10
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector3>.Clone
	|
	|-RVA: 0x2C08120 Offset: 0x2C08221 VA: 0x2C08120
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, CropDataTable>.Clone
	|
	|-RVA: 0x2C08640 Offset: 0x2C08741 VA: 0x2C08640
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Clone
	|
	|-RVA: 0x2C08B50 Offset: 0x2C08C51 VA: 0x2C08B50
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Clone
	|
	|-RVA: 0x2C09060 Offset: 0x2C09161 VA: 0x2C09060
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Clone
	|
	|-RVA: 0x2C09570 Offset: 0x2C09671 VA: 0x2C09570
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Label>.Clone
	|
	|-RVA: 0x2C09A80 Offset: 0x2C09B81 VA: 0x2C09A80
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Clone
	|
	|-RVA: 0x2C09F90 Offset: 0x2C0A091 VA: 0x2C09F90
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2C0A4A0 Offset: 0x2C0A5A1 VA: 0x2C0A4A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector2>.Clone
	|
	|-RVA: 0x2A52760 Offset: 0x2A52861 VA: 0x2A52760
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector3>.Clone
	|
	|-RVA: 0x2A52C70 Offset: 0x2A52D71 VA: 0x2A52C70
	|-Enumerable.WhereSelectEnumerableIterator<object, CropDataTable>.Clone
	|
	|-RVA: 0x2A53190 Offset: 0x2A53291 VA: 0x2A53190
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Clone
	|
	|-RVA: 0x2A536A0 Offset: 0x2A537A1 VA: 0x2A536A0
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Clone
	|
	|-RVA: 0x2A53BB0 Offset: 0x2A53CB1 VA: 0x2A53BB0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Clone
	|
	|-RVA: 0x2A540C0 Offset: 0x2A541C1 VA: 0x2A540C0
	|-Enumerable.WhereSelectEnumerableIterator<object, Label>.Clone
	|
	|-RVA: 0x2A545D0 Offset: 0x2A546D1 VA: 0x2A545D0
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Clone
	|
	|-RVA: 0x2A54AE0 Offset: 0x2A54BE1 VA: 0x2A54AE0
	|-Enumerable.WhereSelectEnumerableIterator<object, ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2A54FF0 Offset: 0x2A550F1 VA: 0x2A54FF0
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector2>.Clone
	|
	|-RVA: 0x2A55500 Offset: 0x2A55601 VA: 0x2A55500
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>.Clone
	|
	|-RVA: 0x2A55A10 Offset: 0x2A55B11 VA: 0x2A55A10
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, CropDataTable>.Clone
	|
	|-RVA: 0x2A55F40 Offset: 0x2A56041 VA: 0x2A55F40
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, int>.Clone
	|
	|-RVA: 0x2A56450 Offset: 0x2A56551 VA: 0x2A56450
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Clone
	|
	|-RVA: 0x2A56960 Offset: 0x2A56A61 VA: 0x2A56960
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Clone
	|
	|-RVA: 0x2A56E80 Offset: 0x2A56F81 VA: 0x2A56E80
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Label>.Clone
	|
	|-RVA: 0x2A57390 Offset: 0x2A57491 VA: 0x2A57390
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, float>.Clone
	|
	|-RVA: 0x2A578A0 Offset: 0x2A579A1 VA: 0x2A578A0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.Clone
	|
	|-RVA: 0x2A57DB0 Offset: 0x2A57EB1 VA: 0x2A57DB0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector2>.Clone
	|
	|-RVA: 0x2A582C0 Offset: 0x2A583C1 VA: 0x2A582C0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector3>.Clone
	|
	|-RVA: 0x2A587E0 Offset: 0x2A588E1 VA: 0x2A587E0
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01EA0 Offset: 0x2C01FA1 VA: 0x2C01EA0
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, int>.Dispose
	|
	|-RVA: 0x2C02480 Offset: 0x2C02581 VA: 0x2C02480
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, object>.Dispose
	|
	|-RVA: 0x2C02A70 Offset: 0x2C02B71 VA: 0x2C02A70
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, Label>.Dispose
	|
	|-RVA: 0x2C03050 Offset: 0x2C03151 VA: 0x2C03050
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, CropDataTable>.Dispose
	|
	|-RVA: 0x2C03580 Offset: 0x2C03681 VA: 0x2C03580
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Dispose
	|
	|-RVA: 0x2C03A90 Offset: 0x2C03B91 VA: 0x2C03A90
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x2C03FA0 Offset: 0x2C040A1 VA: 0x2C03FA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x2C044C0 Offset: 0x2C045C1 VA: 0x2C044C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Label>.Dispose
	|
	|-RVA: 0x2C049D0 Offset: 0x2C04AD1 VA: 0x2C049D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Dispose
	|
	|-RVA: 0x2C04EE0 Offset: 0x2C04FE1 VA: 0x2C04EE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector2>.Dispose
	|
	|-RVA: 0x2C053F0 Offset: 0x2C054F1 VA: 0x2C053F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector3>.Dispose
	|
	|-RVA: 0x2C05910 Offset: 0x2C05A11 VA: 0x2C05910
	|-Enumerable.WhereSelectEnumerableIterator<int, CropDataTable>.Dispose
	|
	|-RVA: 0x2C05E30 Offset: 0x2C05F31 VA: 0x2C05E30
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Dispose
	|
	|-RVA: 0x2C06340 Offset: 0x2C06441 VA: 0x2C06340
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x2C06850 Offset: 0x2C06951 VA: 0x2C06850
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Dispose
	|
	|-RVA: 0x2C06D60 Offset: 0x2C06E61 VA: 0x2C06D60
	|-Enumerable.WhereSelectEnumerableIterator<int, Label>.Dispose
	|
	|-RVA: 0x2C07270 Offset: 0x2C07371 VA: 0x2C07270
	|-Enumerable.WhereSelectEnumerableIterator<int, float>.Dispose
	|
	|-RVA: 0x2C07780 Offset: 0x2C07881 VA: 0x2C07780
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector2>.Dispose
	|
	|-RVA: 0x2C07C90 Offset: 0x2C07D91 VA: 0x2C07C90
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector3>.Dispose
	|
	|-RVA: 0x2C081A0 Offset: 0x2C082A1 VA: 0x2C081A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, CropDataTable>.Dispose
	|
	|-RVA: 0x2C086C0 Offset: 0x2C087C1 VA: 0x2C086C0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x2C08BD0 Offset: 0x2C08CD1 VA: 0x2C08BD0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x2C090E0 Offset: 0x2C091E1 VA: 0x2C090E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x2C095F0 Offset: 0x2C096F1 VA: 0x2C095F0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Label>.Dispose
	|
	|-RVA: 0x2C09B00 Offset: 0x2C09C01 VA: 0x2C09B00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x2C0A010 Offset: 0x2C0A111 VA: 0x2C0A010
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.Dispose
	|
	|-RVA: 0x2C0A520 Offset: 0x2C0A621 VA: 0x2C0A520
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector2>.Dispose
	|
	|-RVA: 0x2A527E0 Offset: 0x2A528E1 VA: 0x2A527E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector3>.Dispose
	|
	|-RVA: 0x2A52CF0 Offset: 0x2A52DF1 VA: 0x2A52CF0
	|-Enumerable.WhereSelectEnumerableIterator<object, CropDataTable>.Dispose
	|
	|-RVA: 0x2A53210 Offset: 0x2A53311 VA: 0x2A53210
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Dispose
	|
	|-RVA: 0x2A53720 Offset: 0x2A53821 VA: 0x2A53720
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x2A53C30 Offset: 0x2A53D31 VA: 0x2A53C30
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0x2A54140 Offset: 0x2A54241 VA: 0x2A54140
	|-Enumerable.WhereSelectEnumerableIterator<object, Label>.Dispose
	|
	|-RVA: 0x2A54650 Offset: 0x2A54751 VA: 0x2A54650
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Dispose
	|
	|-RVA: 0x2A54B60 Offset: 0x2A54C61 VA: 0x2A54B60
	|-Enumerable.WhereSelectEnumerableIterator<object, ValueTuple<bool, Int32Enum>>.Dispose
	|
	|-RVA: 0x2A55070 Offset: 0x2A55171 VA: 0x2A55070
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector2>.Dispose
	|
	|-RVA: 0x2A55580 Offset: 0x2A55681 VA: 0x2A55580
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>.Dispose
	|
	|-RVA: 0x2A55A90 Offset: 0x2A55B91 VA: 0x2A55A90
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, CropDataTable>.Dispose
	|
	|-RVA: 0x2A55FC0 Offset: 0x2A560C1 VA: 0x2A55FC0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, int>.Dispose
	|
	|-RVA: 0x2A564D0 Offset: 0x2A565D1 VA: 0x2A564D0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Dispose
	|
	|-RVA: 0x2A569E0 Offset: 0x2A56AE1 VA: 0x2A569E0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Dispose
	|
	|-RVA: 0x2A56F00 Offset: 0x2A57001 VA: 0x2A56F00
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Label>.Dispose
	|
	|-RVA: 0x2A57410 Offset: 0x2A57511 VA: 0x2A57410
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, float>.Dispose
	|
	|-RVA: 0x2A57920 Offset: 0x2A57A21 VA: 0x2A57920
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.Dispose
	|
	|-RVA: 0x2A57E30 Offset: 0x2A57F31 VA: 0x2A57E30
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector2>.Dispose
	|
	|-RVA: 0x2A58340 Offset: 0x2A58441 VA: 0x2A58340
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector3>.Dispose
	|
	|-RVA: 0x2A58860 Offset: 0x2A58961 VA: 0x2A58860
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01FA0 Offset: 0x2C020A1 VA: 0x2C01FA0
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, int>.MoveNext
	|
	|-RVA: 0x2C02580 Offset: 0x2C02681 VA: 0x2C02580
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, object>.MoveNext
	|
	|-RVA: 0x2C02B70 Offset: 0x2C02C71 VA: 0x2C02B70
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, Label>.MoveNext
	|
	|-RVA: 0x2C03150 Offset: 0x2C03251 VA: 0x2C03150
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, CropDataTable>.MoveNext
	|
	|-RVA: 0x2C03680 Offset: 0x2C03781 VA: 0x2C03680
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x2C03B90 Offset: 0x2C03C91 VA: 0x2C03B90
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2C040A0 Offset: 0x2C041A1 VA: 0x2C040A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x2C045C0 Offset: 0x2C046C1 VA: 0x2C045C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Label>.MoveNext
	|
	|-RVA: 0x2C04AD0 Offset: 0x2C04BD1 VA: 0x2C04AD0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x2C04FE0 Offset: 0x2C050E1 VA: 0x2C04FE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector2>.MoveNext
	|
	|-RVA: 0x2C054F0 Offset: 0x2C055F1 VA: 0x2C054F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector3>.MoveNext
	|
	|-RVA: 0x2C05A10 Offset: 0x2C05B11 VA: 0x2C05A10
	|-Enumerable.WhereSelectEnumerableIterator<int, CropDataTable>.MoveNext
	|
	|-RVA: 0x2C05F30 Offset: 0x2C06031 VA: 0x2C05F30
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.MoveNext
	|
	|-RVA: 0x2C06440 Offset: 0x2C06541 VA: 0x2C06440
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x2C06950 Offset: 0x2C06A51 VA: 0x2C06950
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.MoveNext
	|
	|-RVA: 0x2C06E60 Offset: 0x2C06F61 VA: 0x2C06E60
	|-Enumerable.WhereSelectEnumerableIterator<int, Label>.MoveNext
	|
	|-RVA: 0x2C07370 Offset: 0x2C07471 VA: 0x2C07370
	|-Enumerable.WhereSelectEnumerableIterator<int, float>.MoveNext
	|
	|-RVA: 0x2C07880 Offset: 0x2C07981 VA: 0x2C07880
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector2>.MoveNext
	|
	|-RVA: 0x2C07D90 Offset: 0x2C07E91 VA: 0x2C07D90
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector3>.MoveNext
	|
	|-RVA: 0x2C082A0 Offset: 0x2C083A1 VA: 0x2C082A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, CropDataTable>.MoveNext
	|
	|-RVA: 0x2C087C0 Offset: 0x2C088C1 VA: 0x2C087C0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x2C08CD0 Offset: 0x2C08DD1 VA: 0x2C08CD0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x2C091E0 Offset: 0x2C092E1 VA: 0x2C091E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x2C096F0 Offset: 0x2C097F1 VA: 0x2C096F0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Label>.MoveNext
	|
	|-RVA: 0x2C09C00 Offset: 0x2C09D01 VA: 0x2C09C00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x2C0A110 Offset: 0x2C0A211 VA: 0x2C0A110
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2C0A620 Offset: 0x2C0A721 VA: 0x2C0A620
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector2>.MoveNext
	|
	|-RVA: 0x2A528E0 Offset: 0x2A529E1 VA: 0x2A528E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector3>.MoveNext
	|
	|-RVA: 0x2A52DF0 Offset: 0x2A52EF1 VA: 0x2A52DF0
	|-Enumerable.WhereSelectEnumerableIterator<object, CropDataTable>.MoveNext
	|
	|-RVA: 0x2A53310 Offset: 0x2A53411 VA: 0x2A53310
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.MoveNext
	|
	|-RVA: 0x2A53820 Offset: 0x2A53921 VA: 0x2A53820
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x2A53D30 Offset: 0x2A53E31 VA: 0x2A53D30
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0x2A54240 Offset: 0x2A54341 VA: 0x2A54240
	|-Enumerable.WhereSelectEnumerableIterator<object, Label>.MoveNext
	|
	|-RVA: 0x2A54750 Offset: 0x2A54851 VA: 0x2A54750
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.MoveNext
	|
	|-RVA: 0x2A54C60 Offset: 0x2A54D61 VA: 0x2A54C60
	|-Enumerable.WhereSelectEnumerableIterator<object, ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2A55170 Offset: 0x2A55271 VA: 0x2A55170
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector2>.MoveNext
	|
	|-RVA: 0x2A55680 Offset: 0x2A55781 VA: 0x2A55680
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>.MoveNext
	|
	|-RVA: 0x2A55B90 Offset: 0x2A55C91 VA: 0x2A55B90
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, CropDataTable>.MoveNext
	|
	|-RVA: 0x2A560C0 Offset: 0x2A561C1 VA: 0x2A560C0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, int>.MoveNext
	|
	|-RVA: 0x2A565D0 Offset: 0x2A566D1 VA: 0x2A565D0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2A56AE0 Offset: 0x2A56BE1 VA: 0x2A56AE0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.MoveNext
	|
	|-RVA: 0x2A57000 Offset: 0x2A57101 VA: 0x2A57000
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Label>.MoveNext
	|
	|-RVA: 0x2A57510 Offset: 0x2A57611 VA: 0x2A57510
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, float>.MoveNext
	|
	|-RVA: 0x2A57A20 Offset: 0x2A57B21 VA: 0x2A57A20
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2A57F30 Offset: 0x2A58031 VA: 0x2A57F30
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector2>.MoveNext
	|
	|-RVA: 0x2A58440 Offset: 0x2A58541 VA: 0x2A58440
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector3>.MoveNext
	|
	|-RVA: 0x2A58960 Offset: 0x2A58A61 VA: 0x2A58960
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D6FC0 Offset: 0x22D70C1 VA: 0x22D6FC0
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, int>.Select<object>
	|
	|-RVA: 0x22D7050 Offset: 0x22D7151 VA: 0x22D7050
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, int>.Select<Label>
	|
	|-RVA: 0x22D70E0 Offset: 0x22D71E1 VA: 0x22D70E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<CropDataTable>
	|
	|-RVA: 0x22D7170 Offset: 0x22D7271 VA: 0x22D7170
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<int>
	|
	|-RVA: 0x22D7200 Offset: 0x22D7301 VA: 0x22D7200
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|
	|-RVA: 0x22D7290 Offset: 0x22D7391 VA: 0x22D7290
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<object>
	|
	|-RVA: 0x22D7320 Offset: 0x22D7421 VA: 0x22D7320
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Label>
	|
	|-RVA: 0x22D73B0 Offset: 0x22D74B1 VA: 0x22D73B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<float>
	|
	|-RVA: 0x22D7440 Offset: 0x22D7541 VA: 0x22D7440
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Vector2>
	|
	|-RVA: 0x22D74D0 Offset: 0x22D75D1 VA: 0x22D74D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Vector3>
	|
	|-RVA: 0x22D7560 Offset: 0x22D7661 VA: 0x22D7560
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<CropDataTable>
	|
	|-RVA: 0x22D75F0 Offset: 0x22D76F1 VA: 0x22D75F0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<int>
	|
	|-RVA: 0x22D7680 Offset: 0x22D7781 VA: 0x22D7680
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<Int32Enum>
	|
	|-RVA: 0x22D7710 Offset: 0x22D7811 VA: 0x22D7710
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<object>
	|
	|-RVA: 0x22D77A0 Offset: 0x22D78A1 VA: 0x22D77A0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<Label>
	|
	|-RVA: 0x22D7830 Offset: 0x22D7931 VA: 0x22D7830
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<float>
	|
	|-RVA: 0x22D78C0 Offset: 0x22D79C1 VA: 0x22D78C0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<Vector2>
	|
	|-RVA: 0x22D7950 Offset: 0x22D7A51 VA: 0x22D7950
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<Vector3>
	|
	|-RVA: 0x22D79E0 Offset: 0x22D7AE1 VA: 0x22D79E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<CropDataTable>
	|
	|-RVA: 0x22D7A70 Offset: 0x22D7B71 VA: 0x22D7A70
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<int>
	|
	|-RVA: 0x22D7B00 Offset: 0x22D7C01 VA: 0x22D7B00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Int32Enum>
	|
	|-RVA: 0x22D7B90 Offset: 0x22D7C91 VA: 0x22D7B90
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<object>
	|
	|-RVA: 0x21253F0 Offset: 0x21254F1 VA: 0x21253F0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Label>
	|
	|-RVA: 0x2125480 Offset: 0x2125581 VA: 0x2125480
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<float>
	|
	|-RVA: 0x2125510 Offset: 0x2125611 VA: 0x2125510
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Vector2>
	|
	|-RVA: 0x21255A0 Offset: 0x21256A1 VA: 0x21255A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Vector3>
	|
	|-RVA: 0x2125630 Offset: 0x2125731 VA: 0x2125630
	|-Enumerable.WhereSelectEnumerableIterator<object, CropDataTable>.Select<int>
	|
	|-RVA: 0x21256C0 Offset: 0x21257C1 VA: 0x21256C0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<object>
	|
	|-RVA: 0x2125750 Offset: 0x2125851 VA: 0x2125750
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<Label>
	|
	|-RVA: 0x21257E0 Offset: 0x21258E1 VA: 0x21257E0
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Select<object>
	|
	|-RVA: 0x2125870 Offset: 0x2125971 VA: 0x2125870
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Select<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x2125900 Offset: 0x2125A01 VA: 0x2125900
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<CropDataTable>
	|
	|-RVA: 0x2125990 Offset: 0x2125A91 VA: 0x2125990
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<int>
	|
	|-RVA: 0x2125A20 Offset: 0x2125B21 VA: 0x2125A20
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Int32Enum>
	|
	|-RVA: 0x2125AB0 Offset: 0x2125BB1 VA: 0x2125AB0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<object>
	|
	|-RVA: 0x2125B40 Offset: 0x2125C41 VA: 0x2125B40
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Label>
	|
	|-RVA: 0x2125BD0 Offset: 0x2125CD1 VA: 0x2125BD0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<float>
	|
	|-RVA: 0x2125C60 Offset: 0x2125D61 VA: 0x2125C60
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Vector2>
	|
	|-RVA: 0x2125CF0 Offset: 0x2125DF1 VA: 0x2125CF0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Vector3>
	|
	|-RVA: 0x2125D80 Offset: 0x2125E81 VA: 0x2125D80
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Select<object>
	|
	|-RVA: 0x2125E10 Offset: 0x2125F11 VA: 0x2125E10
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Select<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x2125EA0 Offset: 0x2125FA1 VA: 0x2125EA0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Select<CropDataTable>
	|
	|-RVA: 0x2125F30 Offset: 0x2126031 VA: 0x2125F30
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Select<int>
	|
	|-RVA: 0x2125FC0 Offset: 0x21260C1 VA: 0x2125FC0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Select<Int32Enum>
	|
	|-RVA: 0x2126050 Offset: 0x2126151 VA: 0x2126050
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Select<object>
	|
	|-RVA: 0x21260E0 Offset: 0x21261E1 VA: 0x21260E0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Select<Label>
	|
	|-RVA: 0x2126170 Offset: 0x2126271 VA: 0x2126170
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Select<float>
	|
	|-RVA: 0x2126200 Offset: 0x2126301 VA: 0x2126200
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Select<Vector2>
	|
	|-RVA: 0x2126290 Offset: 0x2126391 VA: 0x2126290
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Select<Vector3>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C02300 Offset: 0x2C02401 VA: 0x2C02300
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, int>.Where
	|
	|-RVA: 0x2C028F0 Offset: 0x2C029F1 VA: 0x2C028F0
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, object>.Where
	|
	|-RVA: 0x2C02ED0 Offset: 0x2C02FD1 VA: 0x2C02ED0
	|-Enumerable.WhereSelectEnumerableIterator<CropDataTable, Label>.Where
	|
	|-RVA: 0x2C03400 Offset: 0x2C03501 VA: 0x2C03400
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, CropDataTable>.Where
	|
	|-RVA: 0x2C03910 Offset: 0x2C03A11 VA: 0x2C03910
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Where
	|
	|-RVA: 0x2C03E20 Offset: 0x2C03F21 VA: 0x2C03E20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|
	|-RVA: 0x2C04340 Offset: 0x2C04441 VA: 0x2C04340
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Where
	|
	|-RVA: 0x2C04850 Offset: 0x2C04951 VA: 0x2C04850
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Label>.Where
	|
	|-RVA: 0x2C04D60 Offset: 0x2C04E61 VA: 0x2C04D60
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Where
	|
	|-RVA: 0x2C05270 Offset: 0x2C05371 VA: 0x2C05270
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector2>.Where
	|
	|-RVA: 0x2C05790 Offset: 0x2C05891 VA: 0x2C05790
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Vector3>.Where
	|
	|-RVA: 0x2C05CB0 Offset: 0x2C05DB1 VA: 0x2C05CB0
	|-Enumerable.WhereSelectEnumerableIterator<int, CropDataTable>.Where
	|
	|-RVA: 0x2C061C0 Offset: 0x2C062C1 VA: 0x2C061C0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Where
	|
	|-RVA: 0x2C066D0 Offset: 0x2C067D1 VA: 0x2C066D0
	|-Enumerable.WhereSelectEnumerableIterator<int, Int32Enum>.Where
	|
	|-RVA: 0x2C06BE0 Offset: 0x2C06CE1 VA: 0x2C06BE0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Where
	|
	|-RVA: 0x2C070F0 Offset: 0x2C071F1 VA: 0x2C070F0
	|-Enumerable.WhereSelectEnumerableIterator<int, Label>.Where
	|
	|-RVA: 0x2C07600 Offset: 0x2C07701 VA: 0x2C07600
	|-Enumerable.WhereSelectEnumerableIterator<int, float>.Where
	|
	|-RVA: 0x2C07B10 Offset: 0x2C07C11 VA: 0x2C07B10
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector2>.Where
	|
	|-RVA: 0x2C08020 Offset: 0x2C08121 VA: 0x2C08020
	|-Enumerable.WhereSelectEnumerableIterator<int, Vector3>.Where
	|
	|-RVA: 0x2C08540 Offset: 0x2C08641 VA: 0x2C08540
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, CropDataTable>.Where
	|
	|-RVA: 0x2C08A50 Offset: 0x2C08B51 VA: 0x2C08A50
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Where
	|
	|-RVA: 0x2C08F60 Offset: 0x2C09061 VA: 0x2C08F60
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Where
	|
	|-RVA: 0x2C09470 Offset: 0x2C09571 VA: 0x2C09470
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Where
	|
	|-RVA: 0x2C09980 Offset: 0x2C09A81 VA: 0x2C09980
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Label>.Where
	|
	|-RVA: 0x2C09E90 Offset: 0x2C09F91 VA: 0x2C09E90
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Where
	|
	|-RVA: 0x2C0A3A0 Offset: 0x2C0A4A1 VA: 0x2C0A3A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2C0A8B0 Offset: 0x2C0A9B1 VA: 0x2C0A8B0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector2>.Where
	|
	|-RVA: 0x2A52B70 Offset: 0x2A52C71 VA: 0x2A52B70
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Vector3>.Where
	|
	|-RVA: 0x2A53090 Offset: 0x2A53191 VA: 0x2A53090
	|-Enumerable.WhereSelectEnumerableIterator<object, CropDataTable>.Where
	|
	|-RVA: 0x2A535A0 Offset: 0x2A536A1 VA: 0x2A535A0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Where
	|
	|-RVA: 0x2A53AB0 Offset: 0x2A53BB1 VA: 0x2A53AB0
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Where
	|
	|-RVA: 0x2A53FC0 Offset: 0x2A540C1 VA: 0x2A53FC0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Where
	|
	|-RVA: 0x2A544D0 Offset: 0x2A545D1 VA: 0x2A544D0
	|-Enumerable.WhereSelectEnumerableIterator<object, Label>.Where
	|
	|-RVA: 0x2A549E0 Offset: 0x2A54AE1 VA: 0x2A549E0
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Where
	|
	|-RVA: 0x2A54EF0 Offset: 0x2A54FF1 VA: 0x2A54EF0
	|-Enumerable.WhereSelectEnumerableIterator<object, ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2A55400 Offset: 0x2A55501 VA: 0x2A55400
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector2>.Where
	|
	|-RVA: 0x2A55910 Offset: 0x2A55A11 VA: 0x2A55910
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>.Where
	|
	|-RVA: 0x2A55E40 Offset: 0x2A55F41 VA: 0x2A55E40
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, CropDataTable>.Where
	|
	|-RVA: 0x2A56350 Offset: 0x2A56451 VA: 0x2A56350
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, int>.Where
	|
	|-RVA: 0x2A56860 Offset: 0x2A56961 VA: 0x2A56860
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Int32Enum>.Where
	|
	|-RVA: 0x2A56D80 Offset: 0x2A56E81 VA: 0x2A56D80
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, object>.Where
	|
	|-RVA: 0x2A57290 Offset: 0x2A57391 VA: 0x2A57290
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Label>.Where
	|
	|-RVA: 0x2A577A0 Offset: 0x2A578A1 VA: 0x2A577A0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, float>.Where
	|
	|-RVA: 0x2A57CB0 Offset: 0x2A57DB1 VA: 0x2A57CB0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>>.Where
	|
	|-RVA: 0x2A581C0 Offset: 0x2A582C1 VA: 0x2A581C0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector2>.Where
	|
	|-RVA: 0x2A586E0 Offset: 0x2A587E1 VA: 0x2A586E0
	|-Enumerable.WhereSelectEnumerableIterator<ValueTuple<object, Int32Enum>, Vector3>.Where
	|
	|-RVA: 0x2A58C10 Offset: 0x2A58D11 VA: 0x2A58C10
	|-Enumerable.WhereSelectEnumerableIterator<Vector4, Vector2>.Where
	*/
}

