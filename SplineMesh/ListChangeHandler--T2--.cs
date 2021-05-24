public sealed class ListChangeHandler<T2> : MulticastDelegate // TypeDefIndex: 9737
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAF9F0 Offset: 0x2CAFAF1 VA: 0x2CAF9F0
	|-ListChangeHandler<SplineNode>..ctor
	|-ListChangeHandler<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(object sender, ListChangedEventArgs<T2> args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAFA10 Offset: 0x2CAFB11 VA: 0x2CAFA10
	|-ListChangeHandler<SplineNode>.Invoke
	|-ListChangeHandler<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ListChangedEventArgs<T2> args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAFE30 Offset: 0x2CAFF31 VA: 0x2CAFE30
	|-ListChangeHandler<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAFE60 Offset: 0x2CAFF61 VA: 0x2CAFE60
	|-ListChangeHandler<object>.EndInvoke
	*/
}

