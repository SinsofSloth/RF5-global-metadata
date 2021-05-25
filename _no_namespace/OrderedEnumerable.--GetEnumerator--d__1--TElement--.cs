[CompilerGeneratedAttribute] // RVA: 0xBE240 Offset: 0xBE341 VA: 0xBE240
private sealed class OrderedEnumerable.<GetEnumerator>d__1<TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 2198
{
	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public OrderedEnumerable<TElement> <>4__this; // 0x0
	private Buffer<TElement> <buffer>5__1; // 0x0
	private int[] <map>5__2; // 0x0
	private int <i>5__3; // 0x0

	// Properties
	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xC0640 Offset: 0xC0741 VA: 0xC0640
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A68C80 Offset: 0x2A68D81 VA: 0x2A68C80
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>..ctor
	|
	|-RVA: 0x2A68F10 Offset: 0x2A69011 VA: 0x2A68F10
	|-OrderedEnumerable.<GetEnumerator>d__1<object>..ctor
	|
	|-RVA: 0x2A69160 Offset: 0x2A69261 VA: 0x2A69160
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>..ctor
	|
	|-RVA: 0x2A69430 Offset: 0x2A69531 VA: 0x2A69430
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC0650 Offset: 0xC0751 VA: 0xC0650
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A68CC0 Offset: 0x2A68DC1 VA: 0x2A68CC0
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.IDisposable.Dispose
	|
	|-RVA: 0x2A68F50 Offset: 0x2A69051 VA: 0x2A68F50
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x2A691A0 Offset: 0x2A692A1 VA: 0x2A691A0
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.System.IDisposable.Dispose
	|
	|-RVA: 0x2A69470 Offset: 0x2A69571 VA: 0x2A69470
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A68CD0 Offset: 0x2A68DD1 VA: 0x2A68CD0
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.MoveNext
	|
	|-RVA: 0x2A68F60 Offset: 0x2A69061 VA: 0x2A68F60
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0x2A691B0 Offset: 0x2A692B1 VA: 0x2A691B0
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.MoveNext
	|
	|-RVA: 0x2A69480 Offset: 0x2A69581 VA: 0x2A69480
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC0660 Offset: 0xC0761 VA: 0xC0660
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A68E50 Offset: 0x2A68F51 VA: 0x2A68E50
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x2A690E0 Offset: 0x2A691E1 VA: 0x2A690E0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x2A69330 Offset: 0x2A69431 VA: 0x2A69330
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x2A69620 Offset: 0x2A69721 VA: 0x2A69620
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC0670 Offset: 0xC0771 VA: 0xC0670
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A68E60 Offset: 0x2A68F61 VA: 0x2A68E60
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A690F0 Offset: 0x2A691F1 VA: 0x2A690F0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A69360 Offset: 0x2A69461 VA: 0x2A69360
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A69640 Offset: 0x2A69741 VA: 0x2A69640
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC0680 Offset: 0xC0781 VA: 0xC0680
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A68EC0 Offset: 0x2A68FC1 VA: 0x2A68EC0
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A69150 Offset: 0x2A69251 VA: 0x2A69150
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A693C0 Offset: 0x2A694C1 VA: 0x2A693C0
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A696A0 Offset: 0x2A697A1 VA: 0x2A696A0
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	*/
}

