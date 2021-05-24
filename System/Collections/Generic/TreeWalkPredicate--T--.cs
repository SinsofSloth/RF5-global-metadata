internal sealed class TreeWalkPredicate<T> : MulticastDelegate // TypeDefIndex: 2100
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5210 Offset: 0x2EE5311 VA: 0x2EE5210
	|-TreeWalkPredicate<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2EE5670 Offset: 0x2EE5771 VA: 0x2EE5670
	|-TreeWalkPredicate<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5230 Offset: 0x2EE5331 VA: 0x2EE5230
	|-TreeWalkPredicate<KeyValuePair<object, object>>.Invoke
	|
	|-RVA: 0x2EE5690 Offset: 0x2EE5791 VA: 0x2EE5690
	|-TreeWalkPredicate<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(SortedSet.Node<T> node, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5610 Offset: 0x2EE5711 VA: 0x2EE5610
	|-TreeWalkPredicate<KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x2EE5A70 Offset: 0x2EE5B71 VA: 0x2EE5A70
	|-TreeWalkPredicate<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5640 Offset: 0x2EE5741 VA: 0x2EE5640
	|-TreeWalkPredicate<KeyValuePair<object, object>>.EndInvoke
	|
	|-RVA: 0x2EE5AA0 Offset: 0x2EE5BA1 VA: 0x2EE5AA0
	|-TreeWalkPredicate<object>.EndInvoke
	*/
}

