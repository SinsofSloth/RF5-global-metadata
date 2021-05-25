internal interface IGenericProviderOperation // TypeDefIndex: 4522
{
	// Properties
	public abstract int ProvideHandleVersion { get; }
	public abstract IResourceLocation Location { get; }
	public abstract int DependencyCount { get; }
	public abstract Type RequestedType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_ProvideHandleVersion() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IResourceLocation get_Location() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_DependencyCount() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetDependencies(IList<object> dstList) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericProviderOperation.GetDependency<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetProgressCallback(Func<float> callback) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ProviderCompleted<T>(T result, bool status, Exception e) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericProviderOperation.ProviderCompleted<object>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_RequestedType() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void SetDownloadProgressCallback(Func<DownloadStatus> callback) { }
}

