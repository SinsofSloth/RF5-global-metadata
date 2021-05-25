public struct AsyncOperationHandle<TObject> : IEnumerator, IEquatable<AsyncOperationHandle<TObject>> // TypeDefIndex: 4516
{
	// Fields
	internal AsyncOperationBase<TObject> m_InternalOp; // 0x0
	private int m_Version; // 0x0
	private string m_LocationName; // 0x0

	// Properties
	internal string LocationName { get; set; }
	public string DebugName { get; }
	private AsyncOperationBase<TObject> InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public TObject Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<TObject> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal string get_LocationName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377D70 Offset: 0x377E71 VA: 0x377D70
	|-AsyncOperationHandle<bool>.get_LocationName
	|
	|-RVA: 0x3781D0 Offset: 0x3782D1 VA: 0x3781D0
	|-AsyncOperationHandle<long>.get_LocationName
	|
	|-RVA: 0x3786B0 Offset: 0x3787B1 VA: 0x3786B0
	|-AsyncOperationHandle<object>.get_LocationName
	|
	|-RVA: 0x378B40 Offset: 0x378C41 VA: 0x378B40
	|-AsyncOperationHandle<SceneInstance>.get_LocationName
	*/

	// RVA: -1 Offset: -1
	internal void set_LocationName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377D80 Offset: 0x377E81 VA: 0x377D80
	|-AsyncOperationHandle<bool>.set_LocationName
	|
	|-RVA: 0x3781E0 Offset: 0x3782E1 VA: 0x3781E0
	|-AsyncOperationHandle<long>.set_LocationName
	|
	|-RVA: 0x3786C0 Offset: 0x3787C1 VA: 0x3786C0
	|-AsyncOperationHandle<object>.set_LocationName
	|
	|-RVA: 0x378B50 Offset: 0x378C51 VA: 0x378B50
	|-AsyncOperationHandle<SceneInstance>.set_LocationName
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle op_Implicit(AsyncOperationHandle<TObject> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9B380 Offset: 0x2A9B481 VA: 0x2A9B380
	|-AsyncOperationHandle<bool>.op_Implicit
	|
	|-RVA: 0x2A9E300 Offset: 0x2A9E401 VA: 0x2A9E300
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.op_Implicit
	|-AsyncOperationHandle<IList<IAssetBundleResource>>.op_Implicit
	|-AsyncOperationHandle<List<IResourceLocator>>.op_Implicit
	|-AsyncOperationHandle<object>.op_Implicit
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.op_Implicit
	|-AsyncOperationHandle<ContentCatalogData>.op_Implicit
	|-AsyncOperationHandle<IResourceLocator>.op_Implicit
	|-AsyncOperationHandle<GameObject>.op_Implicit
	|
	|-RVA: 0x2A9CB40 Offset: 0x2A9CC41 VA: 0x2A9CB40
	|-AsyncOperationHandle<long>.op_Implicit
	|
	|-RVA: 0x2A9FA70 Offset: 0x2A9FB71 VA: 0x2A9FA70
	|-AsyncOperationHandle<SceneInstance>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(AsyncOperationBase<TObject> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377D90 Offset: 0x377E91 VA: 0x377D90
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x3781F0 Offset: 0x3782F1 VA: 0x3781F0
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x3786D0 Offset: 0x3787D1 VA: 0x3786D0
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x378B60 Offset: 0x378C61 VA: 0x378B60
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public DownloadStatus GetDownloadStatus() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377E30 Offset: 0x377F31 VA: 0x377E30
	|-AsyncOperationHandle<bool>.GetDownloadStatus
	|
	|-RVA: 0x378290 Offset: 0x378391 VA: 0x378290
	|-AsyncOperationHandle<long>.GetDownloadStatus
	|
	|-RVA: 0x378770 Offset: 0x378871 VA: 0x378770
	|-AsyncOperationHandle<object>.GetDownloadStatus
	|
	|-RVA: 0x378C00 Offset: 0x378D01 VA: 0x378C00
	|-AsyncOperationHandle<SceneInstance>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377EF0 Offset: 0x377FF1 VA: 0x377EF0
	|-AsyncOperationHandle<bool>.InternalGetDownloadStatus
	|
	|-RVA: 0x378830 Offset: 0x378931 VA: 0x378830
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.InternalGetDownloadStatus
	|-AsyncOperationHandle<object>.InternalGetDownloadStatus
	|-AsyncOperationHandle<GameObject>.InternalGetDownloadStatus
	|
	|-RVA: 0x378350 Offset: 0x378451 VA: 0x378350
	|-AsyncOperationHandle<long>.InternalGetDownloadStatus
	|
	|-RVA: 0x378CC0 Offset: 0x378DC1 VA: 0x378CC0
	|-AsyncOperationHandle<SceneInstance>.InternalGetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377F00 Offset: 0x378001 VA: 0x377F00
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x378360 Offset: 0x378461 VA: 0x378360
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x378840 Offset: 0x378941 VA: 0x378840
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x378CD0 Offset: 0x378DD1 VA: 0x378CD0
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377F10 Offset: 0x378011 VA: 0x377F10
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x378370 Offset: 0x378471 VA: 0x378370
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x378850 Offset: 0x378951 VA: 0x378850
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x378CE0 Offset: 0x378DE1 VA: 0x378CE0
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377F20 Offset: 0x378021 VA: 0x377F20
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x378380 Offset: 0x378481 VA: 0x378380
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x378860 Offset: 0x378961 VA: 0x378860
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x378CF0 Offset: 0x378DF1 VA: 0x378CF0
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377F30 Offset: 0x378031 VA: 0x377F30
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x378390 Offset: 0x378491 VA: 0x378390
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x378870 Offset: 0x378971 VA: 0x378870
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x378D00 Offset: 0x378E01 VA: 0x378D00
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377F40 Offset: 0x378041 VA: 0x377F40
	|-AsyncOperationHandle<bool>.Acquire
	|
	|-RVA: 0x378880 Offset: 0x378981 VA: 0x378880
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.Acquire
	|-AsyncOperationHandle<object>.Acquire
	|
	|-RVA: 0x3783A0 Offset: 0x3784A1 VA: 0x3783A0
	|-AsyncOperationHandle<long>.Acquire
	|
	|-RVA: 0x378D10 Offset: 0x378E11 VA: 0x378D10
	|-AsyncOperationHandle<SceneInstance>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378890 Offset: 0x378991 VA: 0x378890
	|-AsyncOperationHandle<AssetDataTable>.add_Completed
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.add_Completed
	|-AsyncOperationHandle<IList<IAssetBundleResource>>.add_Completed
	|-AsyncOperationHandle<object>.add_Completed
	|-AsyncOperationHandle<ContentCatalogData>.add_Completed
	|-AsyncOperationHandle<IResourceLocator>.add_Completed
	|
	|-RVA: 0x377F50 Offset: 0x378051 VA: 0x377F50
	|-AsyncOperationHandle<bool>.add_Completed
	|
	|-RVA: 0x3783B0 Offset: 0x3784B1 VA: 0x3783B0
	|-AsyncOperationHandle<long>.add_Completed
	|
	|-RVA: 0x378D20 Offset: 0x378E21 VA: 0x378D20
	|-AsyncOperationHandle<SceneInstance>.add_Completed
	*/

	// RVA: -1 Offset: -1
	public void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377F60 Offset: 0x378061 VA: 0x377F60
	|-AsyncOperationHandle<bool>.remove_Completed
	|
	|-RVA: 0x3783C0 Offset: 0x3784C1 VA: 0x3783C0
	|-AsyncOperationHandle<long>.remove_Completed
	|
	|-RVA: 0x3788A0 Offset: 0x3789A1 VA: 0x3788A0
	|-AsyncOperationHandle<object>.remove_Completed
	|
	|-RVA: 0x378D30 Offset: 0x378E31 VA: 0x378D30
	|-AsyncOperationHandle<SceneInstance>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	public void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377F70 Offset: 0x378071 VA: 0x377F70
	|-AsyncOperationHandle<bool>.add_CompletedTypeless
	|
	|-RVA: 0x3788B0 Offset: 0x3789B1 VA: 0x3788B0
	|-AsyncOperationHandle<List<string>>.add_CompletedTypeless
	|-AsyncOperationHandle<List<IResourceLocator>>.add_CompletedTypeless
	|-AsyncOperationHandle<object>.add_CompletedTypeless
	|-AsyncOperationHandle<GameObject>.add_CompletedTypeless
	|
	|-RVA: 0x3783D0 Offset: 0x3784D1 VA: 0x3783D0
	|-AsyncOperationHandle<long>.add_CompletedTypeless
	|
	|-RVA: 0x378D40 Offset: 0x378E41 VA: 0x378D40
	|-AsyncOperationHandle<SceneInstance>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377F80 Offset: 0x378081 VA: 0x377F80
	|-AsyncOperationHandle<bool>.remove_CompletedTypeless
	|
	|-RVA: 0x3783E0 Offset: 0x3784E1 VA: 0x3783E0
	|-AsyncOperationHandle<long>.remove_CompletedTypeless
	|
	|-RVA: 0x3788C0 Offset: 0x3789C1 VA: 0x3788C0
	|-AsyncOperationHandle<object>.remove_CompletedTypeless
	|
	|-RVA: 0x378D50 Offset: 0x378E51 VA: 0x378D50
	|-AsyncOperationHandle<SceneInstance>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377F90 Offset: 0x378091 VA: 0x377F90
	|-AsyncOperationHandle<bool>.get_DebugName
	|
	|-RVA: 0x3788D0 Offset: 0x3789D1 VA: 0x3788D0
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_DebugName
	|-AsyncOperationHandle<object>.get_DebugName
	|-AsyncOperationHandle<GameObject>.get_DebugName
	|
	|-RVA: 0x3783F0 Offset: 0x3784F1 VA: 0x3783F0
	|-AsyncOperationHandle<long>.get_DebugName
	|
	|-RVA: 0x378D60 Offset: 0x378E61 VA: 0x378D60
	|-AsyncOperationHandle<SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377FA0 Offset: 0x3780A1 VA: 0x377FA0
	|-AsyncOperationHandle<bool>.add_Destroyed
	|
	|-RVA: 0x378400 Offset: 0x378501 VA: 0x378400
	|-AsyncOperationHandle<long>.add_Destroyed
	|
	|-RVA: 0x3788E0 Offset: 0x3789E1 VA: 0x3788E0
	|-AsyncOperationHandle<object>.add_Destroyed
	|
	|-RVA: 0x378D70 Offset: 0x378E71 VA: 0x378D70
	|-AsyncOperationHandle<SceneInstance>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377FB0 Offset: 0x3780B1 VA: 0x377FB0
	|-AsyncOperationHandle<bool>.remove_Destroyed
	|
	|-RVA: 0x378410 Offset: 0x378511 VA: 0x378410
	|-AsyncOperationHandle<long>.remove_Destroyed
	|
	|-RVA: 0x3788F0 Offset: 0x3789F1 VA: 0x3788F0
	|-AsyncOperationHandle<object>.remove_Destroyed
	|
	|-RVA: 0x378D80 Offset: 0x378E81 VA: 0x378D80
	|-AsyncOperationHandle<SceneInstance>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(AsyncOperationHandle<TObject> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377FC0 Offset: 0x3780C1 VA: 0x377FC0
	|-AsyncOperationHandle<bool>.Equals
	|
	|-RVA: 0x378420 Offset: 0x378521 VA: 0x378420
	|-AsyncOperationHandle<long>.Equals
	|
	|-RVA: 0x378900 Offset: 0x378A01 VA: 0x378900
	|-AsyncOperationHandle<object>.Equals
	|
	|-RVA: 0x378D90 Offset: 0x378E91 VA: 0x378D90
	|-AsyncOperationHandle<SceneInstance>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377FF0 Offset: 0x3780F1 VA: 0x377FF0
	|-AsyncOperationHandle<bool>.GetHashCode
	|
	|-RVA: 0x378450 Offset: 0x378551 VA: 0x378450
	|-AsyncOperationHandle<long>.GetHashCode
	|
	|-RVA: 0x378930 Offset: 0x378A31 VA: 0x378930
	|-AsyncOperationHandle<object>.GetHashCode
	|
	|-RVA: 0x378DC0 Offset: 0x378EC1 VA: 0x378DC0
	|-AsyncOperationHandle<SceneInstance>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationBase<TObject> get_InternalOp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378030 Offset: 0x378131 VA: 0x378030
	|-AsyncOperationHandle<bool>.get_InternalOp
	|
	|-RVA: 0x378490 Offset: 0x378591 VA: 0x378490
	|-AsyncOperationHandle<long>.get_InternalOp
	|
	|-RVA: 0x378970 Offset: 0x378A71 VA: 0x378970
	|-AsyncOperationHandle<object>.get_InternalOp
	|
	|-RVA: 0x378E00 Offset: 0x378F01 VA: 0x378E00
	|-AsyncOperationHandle<SceneInstance>.get_InternalOp
	*/

	// RVA: -1 Offset: -1
	public bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378040 Offset: 0x378141 VA: 0x378040
	|-AsyncOperationHandle<bool>.get_IsDone
	|
	|-RVA: 0x378980 Offset: 0x378A81 VA: 0x378980
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_IsDone
	|-AsyncOperationHandle<List<IResourceLocator>>.get_IsDone
	|-AsyncOperationHandle<object>.get_IsDone
	|-AsyncOperationHandle<IResourceLocator>.get_IsDone
	|
	|-RVA: 0x3784A0 Offset: 0x3785A1 VA: 0x3784A0
	|-AsyncOperationHandle<long>.get_IsDone
	|
	|-RVA: 0x378E10 Offset: 0x378F11 VA: 0x378E10
	|-AsyncOperationHandle<SceneInstance>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	public bool IsValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378050 Offset: 0x378151 VA: 0x378050
	|-AsyncOperationHandle<bool>.IsValid
	|
	|-RVA: 0x378990 Offset: 0x378A91 VA: 0x378990
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.IsValid
	|-AsyncOperationHandle<List<string>>.IsValid
	|-AsyncOperationHandle<List<IResourceLocator>>.IsValid
	|-AsyncOperationHandle<object>.IsValid
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.IsValid
	|-AsyncOperationHandle<IResourceLocator>.IsValid
	|-AsyncOperationHandle<GameObject>.IsValid
	|
	|-RVA: 0x3784B0 Offset: 0x3785B1 VA: 0x3784B0
	|-AsyncOperationHandle<long>.IsValid
	|
	|-RVA: 0x378E20 Offset: 0x378F21 VA: 0x378E20
	|-AsyncOperationHandle<SceneInstance>.IsValid
	*/

	// RVA: -1 Offset: -1
	public Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3780F0 Offset: 0x3781F1 VA: 0x3780F0
	|-AsyncOperationHandle<bool>.get_OperationException
	|
	|-RVA: 0x378A30 Offset: 0x378B31 VA: 0x378A30
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_OperationException
	|-AsyncOperationHandle<object>.get_OperationException
	|-AsyncOperationHandle<IResourceLocator>.get_OperationException
	|-AsyncOperationHandle<GameObject>.get_OperationException
	|
	|-RVA: 0x378550 Offset: 0x378651 VA: 0x378550
	|-AsyncOperationHandle<long>.get_OperationException
	|
	|-RVA: 0x378EC0 Offset: 0x378FC1 VA: 0x378EC0
	|-AsyncOperationHandle<SceneInstance>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	public float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378100 Offset: 0x378201 VA: 0x378100
	|-AsyncOperationHandle<bool>.get_PercentComplete
	|
	|-RVA: 0x378A40 Offset: 0x378B41 VA: 0x378A40
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_PercentComplete
	|-AsyncOperationHandle<object>.get_PercentComplete
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.get_PercentComplete
	|-AsyncOperationHandle<GameObject>.get_PercentComplete
	|
	|-RVA: 0x378560 Offset: 0x378661 VA: 0x378560
	|-AsyncOperationHandle<long>.get_PercentComplete
	|
	|-RVA: 0x378ED0 Offset: 0x378FD1 VA: 0x378ED0
	|-AsyncOperationHandle<SceneInstance>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378110 Offset: 0x378211 VA: 0x378110
	|-AsyncOperationHandle<bool>.get_ReferenceCount
	|
	|-RVA: 0x378570 Offset: 0x378671 VA: 0x378570
	|-AsyncOperationHandle<long>.get_ReferenceCount
	|
	|-RVA: 0x378A50 Offset: 0x378B51 VA: 0x378A50
	|-AsyncOperationHandle<object>.get_ReferenceCount
	|
	|-RVA: 0x378EE0 Offset: 0x378FE1 VA: 0x378EE0
	|-AsyncOperationHandle<SceneInstance>.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378120 Offset: 0x378221 VA: 0x378120
	|-AsyncOperationHandle<bool>.Release
	|
	|-RVA: 0x378A60 Offset: 0x378B61 VA: 0x378A60
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.Release
	|-AsyncOperationHandle<object>.Release
	|
	|-RVA: 0x378580 Offset: 0x378681 VA: 0x378580
	|-AsyncOperationHandle<long>.Release
	|
	|-RVA: 0x378EF0 Offset: 0x378FF1 VA: 0x378EF0
	|-AsyncOperationHandle<SceneInstance>.Release
	*/

	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378A70 Offset: 0x378B71 VA: 0x378A70
	|-AsyncOperationHandle<AssetDataTable>.get_Result
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.get_Result
	|-AsyncOperationHandle<ContentCatalogData>.get_Result
	|-AsyncOperationHandle<IResourceLocator>.get_Result
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_Result
	|-AsyncOperationHandle<object>.get_Result
	|-AsyncOperationHandle<GameObject>.get_Result
	|
	|-RVA: 0x378130 Offset: 0x378231 VA: 0x378130
	|-AsyncOperationHandle<bool>.get_Result
	|
	|-RVA: 0x378590 Offset: 0x378691 VA: 0x378590
	|-AsyncOperationHandle<long>.get_Result
	|
	|-RVA: 0x378F00 Offset: 0x379001 VA: 0x378F00
	|-AsyncOperationHandle<SceneInstance>.get_Result
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378140 Offset: 0x378241 VA: 0x378140
	|-AsyncOperationHandle<bool>.get_Status
	|
	|-RVA: 0x378A80 Offset: 0x378B81 VA: 0x378A80
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_Status
	|-AsyncOperationHandle<object>.get_Status
	|-AsyncOperationHandle<GameObject>.get_Status
	|
	|-RVA: 0x3785A0 Offset: 0x3786A1 VA: 0x3785A0
	|-AsyncOperationHandle<long>.get_Status
	|
	|-RVA: 0x378F10 Offset: 0x379011 VA: 0x378F10
	|-AsyncOperationHandle<SceneInstance>.get_Status
	*/

	// RVA: -1 Offset: -1
	public Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378150 Offset: 0x378251 VA: 0x378150
	|-AsyncOperationHandle<bool>.get_Task
	|
	|-RVA: 0x3785B0 Offset: 0x3786B1 VA: 0x3785B0
	|-AsyncOperationHandle<long>.get_Task
	|
	|-RVA: 0x378A90 Offset: 0x378B91 VA: 0x378A90
	|-AsyncOperationHandle<object>.get_Task
	|
	|-RVA: 0x378F20 Offset: 0x379021 VA: 0x378F20
	|-AsyncOperationHandle<SceneInstance>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378160 Offset: 0x378261 VA: 0x378160
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3785C0 Offset: 0x3786C1 VA: 0x3785C0
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x378AA0 Offset: 0x378BA1 VA: 0x378AA0
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x378F30 Offset: 0x379031 VA: 0x378F30
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378170 Offset: 0x378271 VA: 0x378170
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x378650 Offset: 0x378751 VA: 0x378650
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x378AE0 Offset: 0x378BE1 VA: 0x378AE0
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x378F40 Offset: 0x379041 VA: 0x378F40
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3781C0 Offset: 0x3782C1 VA: 0x3781C0
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3786A0 Offset: 0x3787A1 VA: 0x3786A0
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x378B30 Offset: 0x378C31 VA: 0x378B30
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x378F90 Offset: 0x379091 VA: 0x378F90
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.Reset
	*/
}

