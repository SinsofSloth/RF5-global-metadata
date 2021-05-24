[Serializable]
internal class EnvoyInfo : IEnvoyInfo // TypeDefIndex: 1102
{
	// Fields
	private IMessageSink envoySinks; // 0x10

	// Properties
	public IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: 0x1749D20 Offset: 0x1749E21 VA: 0x1749D20
	public void .ctor(IMessageSink sinks) { }

	// RVA: 0x1749D60 Offset: 0x1749E61 VA: 0x1749D60 Slot: 4
	public IMessageSink get_EnvoySinks() { }
}

