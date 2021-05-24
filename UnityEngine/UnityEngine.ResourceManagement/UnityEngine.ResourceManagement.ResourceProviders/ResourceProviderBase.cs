public abstract class ResourceProviderBase : IResourceProvider, IInitializableObject // TypeDefIndex: 4494
{
	// Fields
	protected string m_ProviderId; // 0x10
	protected ProviderBehaviourFlags m_BehaviourFlags; // 0x18

	// Properties
	public virtual string ProviderId { get; }
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.BehaviourFlags { get; }

	// Methods

	// RVA: 0x19E1770 Offset: 0x19E1871 VA: 0x19E1770 Slot: 12
	public virtual string get_ProviderId() { }

	// RVA: 0x19E17E0 Offset: 0x19E18E1 VA: 0x19E17E0 Slot: 13
	public virtual bool Initialize(string id, string data) { }

	// RVA: 0x19E1820 Offset: 0x19E1921 VA: 0x19E1820 Slot: 14
	public virtual bool CanProvide(Type t, IResourceLocation location) { }

	// RVA: 0x19E1870 Offset: 0x19E1971 VA: 0x19E1870 Slot: 3
	public override string ToString() { }

	// RVA: 0x19E1880 Offset: 0x19E1981 VA: 0x19E1880 Slot: 15
	public virtual void Release(IResourceLocation location, object obj) { }

	// RVA: 0x19E1890 Offset: 0x19E1991 VA: 0x19E1890 Slot: 16
	public virtual Type GetDefaultType(IResourceLocation location) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Provide(ProvideHandle provideHandle) { }

	// RVA: 0x19E1900 Offset: 0x19E1A01 VA: 0x19E1900 Slot: 18
	public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data) { }

	// RVA: 0x19E1AF0 Offset: 0x19E1BF1 VA: 0x19E1AF0 Slot: 9
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.get_BehaviourFlags() { }

	// RVA: 0x19DDD30 Offset: 0x19DDE31 VA: 0x19DDD30
	protected void .ctor() { }
}

