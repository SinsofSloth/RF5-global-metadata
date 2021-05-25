public interface IResourceProvider // TypeDefIndex: 4487
{
	// Properties
	public abstract string ProviderId { get; }
	public abstract ProviderBehaviourFlags BehaviourFlags { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ProviderId() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type GetDefaultType(IResourceLocation location) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool CanProvide(Type type, IResourceLocation location) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Provide(ProvideHandle provideHandle) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release(IResourceLocation location, object asset) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ProviderBehaviourFlags get_BehaviourFlags() { }
}

