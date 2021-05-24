[ComVisibleAttribute] // RVA: 0xB0FB0 Offset: 0xB10B1 VA: 0xB0FB0
public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1180
{
	// Properties
	public abstract Type ActivationType { get; }
	public abstract string ActivationTypeName { get; }
	public abstract IActivator Activator { get; set; }
	public abstract object[] CallSiteActivationAttributes { get; }
	public abstract IList ContextProperties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_ActivationType() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ActivationTypeName() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IActivator get_Activator() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Activator(IActivator value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object[] get_CallSiteActivationAttributes() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IList get_ContextProperties() { }
}

