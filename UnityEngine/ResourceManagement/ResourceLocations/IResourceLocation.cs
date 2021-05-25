public interface IResourceLocation // TypeDefIndex: 4503
{
	// Properties
	public abstract string InternalId { get; }
	public abstract string ProviderId { get; }
	public abstract IList<IResourceLocation> Dependencies { get; }
	public abstract int DependencyHashCode { get; }
	public abstract bool HasDependencies { get; }
	public abstract object Data { get; }
	public abstract string PrimaryKey { get; }
	public abstract Type ResourceType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_InternalId() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ProviderId() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IList<IResourceLocation> get_Dependencies() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int Hash(Type resultType) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_DependencyHashCode() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_HasDependencies() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_Data() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_PrimaryKey() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Type get_ResourceType() { }
}

