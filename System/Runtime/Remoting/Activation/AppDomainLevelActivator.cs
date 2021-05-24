internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 1176
{
	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x1806C50 Offset: 0x1806D51 VA: 0x1806C50
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x18072B0 Offset: 0x18073B1 VA: 0x18072B0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x18072C0 Offset: 0x18073C1 VA: 0x18072C0 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

