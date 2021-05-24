public interface IResourceLocator // TypeDefIndex: 5728
{
	// Properties
	public abstract string LocatorId { get; }
	public abstract IEnumerable<object> Keys { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_LocatorId() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerable<object> get_Keys() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }
}

