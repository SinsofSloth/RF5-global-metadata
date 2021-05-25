private sealed class AssetHandle.LoadAsyncVJ<T> : MulticastDelegate // TypeDefIndex: 10219
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24800 Offset: 0x2D24901 VA: 0x2D24800
	|-AssetHandle.LoadAsyncVJ<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24820 Offset: 0x2D24921 VA: 0x2D24820
	|-AssetHandle.LoadAsyncVJ<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(AssetHandle<T> handle, bool load, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24CB0 Offset: 0x2D24DB1 VA: 0x2D24CB0
	|-AssetHandle.LoadAsyncVJ<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24D50 Offset: 0x2D24E51 VA: 0x2D24D50
	|-AssetHandle.LoadAsyncVJ<object>.EndInvoke
	*/
}

