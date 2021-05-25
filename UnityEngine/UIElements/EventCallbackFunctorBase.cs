internal abstract class EventCallbackFunctorBase // TypeDefIndex: 4167
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x11EBE0 Offset: 0x11ECE1 VA: 0x11EBE0
	[CompilerGeneratedAttribute] // RVA: 0x11EBE0 Offset: 0x11ECE1 VA: 0x11EBE0
	private CallbackPhase <phase>k__BackingField; // 0x10

	// Properties
	public CallbackPhase phase { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11FBD0 Offset: 0x11FCD1 VA: 0x11FBD0
	// RVA: 0x15BC050 Offset: 0x15BC151 VA: 0x15BC050
	public CallbackPhase get_phase() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(EventBase evt) { }
}

