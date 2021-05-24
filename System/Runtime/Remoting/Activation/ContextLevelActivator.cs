[Serializable]
internal class ContextLevelActivator : IActivator // TypeDefIndex: 1178
{
	// Fields
	private IActivator m_NextActivator; // 0x10

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x1806CA0 Offset: 0x1806DA1 VA: 0x1806CA0
	public void .ctor(IActivator next) { }

	// RVA: 0x18078D0 Offset: 0x18079D1 VA: 0x18078D0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x18078E0 Offset: 0x18079E1 VA: 0x18078E0 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

