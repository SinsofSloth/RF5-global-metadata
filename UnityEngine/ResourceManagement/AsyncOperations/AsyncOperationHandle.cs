public struct AsyncOperationHandle : IEnumerator // TypeDefIndex: 4517
{
	// Fields
	internal IAsyncOperation m_InternalOp; // 0x0
	private int m_Version; // 0x8
	private string m_LocationName; // 0x10

	// Properties
	internal string LocationName { get; set; }
	public string DebugName { get; }
	private IAsyncOperation InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public object Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<object> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x15780 Offset: 0x15881 VA: 0x15780
	internal string get_LocationName() { }

	// RVA: 0x15790 Offset: 0x15891 VA: 0x15790
	internal void set_LocationName(string value) { }

	// RVA: 0x157A0 Offset: 0x158A1 VA: 0x157A0
	internal void .ctor(IAsyncOperation op) { }

	// RVA: 0x157B0 Offset: 0x158B1 VA: 0x157B0
	internal void .ctor(IAsyncOperation op, int version) { }

	// RVA: 0x157F0 Offset: 0x158F1 VA: 0x157F0
	internal void .ctor(IAsyncOperation op, string locationName) { }

	// RVA: 0x15800 Offset: 0x15901 VA: 0x15800
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }

	// RVA: 0x15850 Offset: 0x15951 VA: 0x15850
	internal AsyncOperationHandle Acquire() { }

	// RVA: 0x15860 Offset: 0x15961 VA: 0x15860
	public void add_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x15870 Offset: 0x15971 VA: 0x15870
	public void remove_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> Convert<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A2420 Offset: 0x3A2521 VA: 0x3A2420
	|-AsyncOperationHandle.Convert<IList<IAssetBundleResource>>
	|-AsyncOperationHandle.Convert<IList<AsyncOperationHandle>>
	|-AsyncOperationHandle.Convert<object>
	|
	|-RVA: 0x3A24A0 Offset: 0x3A25A1 VA: 0x3A24A0
	|-AsyncOperationHandle.Convert<SceneInstance>
	*/

	// RVA: 0x15880 Offset: 0x15981 VA: 0x15880
	public bool Equals(AsyncOperationHandle other) { }

	// RVA: 0x158B0 Offset: 0x159B1 VA: 0x158B0
	public string get_DebugName() { }

	// RVA: 0x158C0 Offset: 0x159C1 VA: 0x158C0
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x158D0 Offset: 0x159D1 VA: 0x158D0
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x158E0 Offset: 0x159E1 VA: 0x158E0
	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x158F0 Offset: 0x159F1 VA: 0x158F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15930 Offset: 0x15A31 VA: 0x15930
	private IAsyncOperation get_InternalOp() { }

	// RVA: 0x15940 Offset: 0x15A41 VA: 0x15940
	public bool get_IsDone() { }

	// RVA: 0x15950 Offset: 0x15A51 VA: 0x15950
	public bool IsValid() { }

	// RVA: 0x15A20 Offset: 0x15B21 VA: 0x15A20
	public Exception get_OperationException() { }

	// RVA: 0x15A30 Offset: 0x15B31 VA: 0x15A30
	public float get_PercentComplete() { }

	// RVA: 0x15A40 Offset: 0x15B41 VA: 0x15A40
	public DownloadStatus GetDownloadStatus() { }

	// RVA: 0x15AC0 Offset: 0x15BC1 VA: 0x15AC0
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x15AD0 Offset: 0x15BD1 VA: 0x15AD0
	internal int get_ReferenceCount() { }

	// RVA: 0x15AE0 Offset: 0x15BE1 VA: 0x15AE0
	internal void Release() { }

	// RVA: 0x15AF0 Offset: 0x15BF1 VA: 0x15AF0
	public object get_Result() { }

	// RVA: 0x15BB0 Offset: 0x15CB1 VA: 0x15BB0
	public AsyncOperationStatus get_Status() { }

	// RVA: 0x15BC0 Offset: 0x15CC1 VA: 0x15BC0
	public Task<object> get_Task() { }

	// RVA: 0x15BD0 Offset: 0x15CD1 VA: 0x15BD0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x15C90 Offset: 0x15D91 VA: 0x15C90 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x15CB0 Offset: 0x15DB1 VA: 0x15CB0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
}

