[CompilerGeneratedAttribute] // RVA: 0xBE0E0 Offset: 0xBE1E1 VA: 0xBE0E0
private sealed class Enumerable.<SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 2173
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, IEnumerable<TResult>> selector; // 0x0
	public Func<TSource, IEnumerable<TResult>> <>3__selector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0
	private IEnumerator<TResult> <>7__wrap2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xBFF80 Offset: 0xC0081 VA: 0xBFF80
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26300 Offset: 0x2B26401 VA: 0x2B26300
	|-Enumerable.<SelectManyIterator>d__17<int, int>..ctor
	|
	|-RVA: 0x2B26C80 Offset: 0x2B26D81 VA: 0x2B26C80
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>..ctor
	|
	|-RVA: 0x2B27600 Offset: 0x2B27701 VA: 0x2B27600
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2B28000 Offset: 0x2B28101 VA: 0x2B28000
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x2B28990 Offset: 0x2B28A91 VA: 0x2B28990
	|-Enumerable.<SelectManyIterator>d__17<object, int>..ctor
	|
	|-RVA: 0x2BF0F00 Offset: 0x2BF1001 VA: 0x2BF0F00
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0xBFF90 Offset: 0xC0091 VA: 0xBFF90
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26340 Offset: 0x2B26441 VA: 0x2B26340
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B26CC0 Offset: 0x2B26DC1 VA: 0x2B26CC0
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B27640 Offset: 0x2B27741 VA: 0x2B27640
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B28040 Offset: 0x2B28141 VA: 0x2B28040
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B289D0 Offset: 0x2B28AD1 VA: 0x2B289D0
	|-Enumerable.<SelectManyIterator>d__17<object, int>.System.IDisposable.Dispose
	|
	|-RVA: 0x2BF0F40 Offset: 0x2BF1041 VA: 0x2BF0F40
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26400 Offset: 0x2B26501 VA: 0x2B26400
	|-Enumerable.<SelectManyIterator>d__17<int, int>.MoveNext
	|
	|-RVA: 0x2B26D80 Offset: 0x2B26E81 VA: 0x2B26D80
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.MoveNext
	|
	|-RVA: 0x2B27700 Offset: 0x2B27801 VA: 0x2B27700
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>.MoveNext
	|
	|-RVA: 0x2B28100 Offset: 0x2B28201 VA: 0x2B28100
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>.MoveNext
	|
	|-RVA: 0x2B28A90 Offset: 0x2B28B91 VA: 0x2B28A90
	|-Enumerable.<SelectManyIterator>d__17<object, int>.MoveNext
	|
	|-RVA: 0x2BF1000 Offset: 0x2BF1101 VA: 0x2BF1000
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26950 Offset: 0x2B26A51 VA: 0x2B26950
	|-Enumerable.<SelectManyIterator>d__17<int, int>.<>m__Finally1
	|
	|-RVA: 0x2B272D0 Offset: 0x2B273D1 VA: 0x2B272D0
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.<>m__Finally1
	|
	|-RVA: 0x2B27C70 Offset: 0x2B27D71 VA: 0x2B27C70
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>.<>m__Finally1
	|
	|-RVA: 0x2B28650 Offset: 0x2B28751 VA: 0x2B28650
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>.<>m__Finally1
	|
	|-RVA: 0x2B28FE0 Offset: 0x2B290E1 VA: 0x2B28FE0
	|-Enumerable.<SelectManyIterator>d__17<object, int>.<>m__Finally1
	|
	|-RVA: 0x2BF1560 Offset: 0x2BF1661 VA: 0x2BF1560
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26A10 Offset: 0x2B26B11 VA: 0x2B26A10
	|-Enumerable.<SelectManyIterator>d__17<int, int>.<>m__Finally2
	|
	|-RVA: 0x2B27390 Offset: 0x2B27491 VA: 0x2B27390
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.<>m__Finally2
	|
	|-RVA: 0x2B27D30 Offset: 0x2B27E31 VA: 0x2B27D30
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>.<>m__Finally2
	|
	|-RVA: 0x2B28710 Offset: 0x2B28811 VA: 0x2B28710
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>.<>m__Finally2
	|
	|-RVA: 0x2B290A0 Offset: 0x2B291A1 VA: 0x2B290A0
	|-Enumerable.<SelectManyIterator>d__17<object, int>.<>m__Finally2
	|
	|-RVA: 0x2BF1620 Offset: 0x2BF1721 VA: 0x2BF1620
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0xBFFA0 Offset: 0xC00A1 VA: 0xBFFA0
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26AD0 Offset: 0x2B26BD1 VA: 0x2B26AD0
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x2B27450 Offset: 0x2B27551 VA: 0x2B27450
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x2B27DF0 Offset: 0x2B27EF1 VA: 0x2B27DF0
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x2B287D0 Offset: 0x2B288D1 VA: 0x2B287D0
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x2B29160 Offset: 0x2B29261 VA: 0x2B29160
	|-Enumerable.<SelectManyIterator>d__17<object, int>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x2BF16E0 Offset: 0x2BF17E1 VA: 0x2BF16E0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xBFFB0 Offset: 0xC00B1 VA: 0xBFFB0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26AE0 Offset: 0x2B26BE1 VA: 0x2B26AE0
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B27460 Offset: 0x2B27561 VA: 0x2B27460
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B27E30 Offset: 0x2B27F31 VA: 0x2B27E30
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B287E0 Offset: 0x2B288E1 VA: 0x2B287E0
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B29170 Offset: 0x2B29271 VA: 0x2B29170
	|-Enumerable.<SelectManyIterator>d__17<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF16F0 Offset: 0x2BF17F1 VA: 0x2BF16F0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0xBFFC0 Offset: 0xC00C1 VA: 0xBFFC0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26B40 Offset: 0x2B26C41 VA: 0x2B26B40
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B274C0 Offset: 0x2B275C1 VA: 0x2B274C0
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B27E90 Offset: 0x2B27F91 VA: 0x2B27E90
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B28840 Offset: 0x2B28941 VA: 0x2B28840
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B291D0 Offset: 0x2B292D1 VA: 0x2B291D0
	|-Enumerable.<SelectManyIterator>d__17<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF1750 Offset: 0x2BF1851 VA: 0x2BF1750
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xBFFD0 Offset: 0xC00D1 VA: 0xBFFD0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26B90 Offset: 0x2B26C91 VA: 0x2B26B90
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x2B27510 Offset: 0x2B27611 VA: 0x2B27510
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x2B27F10 Offset: 0x2B28011 VA: 0x2B27F10
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x2B288A0 Offset: 0x2B289A1 VA: 0x2B288A0
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x2B29220 Offset: 0x2B29321 VA: 0x2B29220
	|-Enumerable.<SelectManyIterator>d__17<object, int>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x2BF1760 Offset: 0x2BF1861 VA: 0x2BF1760
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0xBFFE0 Offset: 0xC00E1 VA: 0xBFFE0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B26C50 Offset: 0x2B26D51 VA: 0x2B26C50
	|-Enumerable.<SelectManyIterator>d__17<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B275D0 Offset: 0x2B276D1 VA: 0x2B275D0
	|-Enumerable.<SelectManyIterator>d__17<int, Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B27FD0 Offset: 0x2B280D1 VA: 0x2B27FD0
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B28960 Offset: 0x2B28A61 VA: 0x2B28960
	|-Enumerable.<SelectManyIterator>d__17<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B292E0 Offset: 0x2B293E1 VA: 0x2B292E0
	|-Enumerable.<SelectManyIterator>d__17<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF1820 Offset: 0x2BF1921 VA: 0x2BF1820
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

