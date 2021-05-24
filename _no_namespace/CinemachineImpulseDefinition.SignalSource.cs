private class CinemachineImpulseDefinition.SignalSource : ISignalSource6D // TypeDefIndex: 4882
{
	// Fields
	private CinemachineImpulseDefinition m_Def; // 0x10
	private Vector3 m_Velocity; // 0x18
	private float m_StartTimeOffset; // 0x24

	// Properties
	public float SignalDuration { get; }

	// Methods

	// RVA: 0x172BEE0 Offset: 0x172BFE1 VA: 0x172BEE0
	public void .ctor(CinemachineImpulseDefinition def, Vector3 velocity) { }

	// RVA: 0x172C1A0 Offset: 0x172C2A1 VA: 0x172C1A0 Slot: 4
	public float get_SignalDuration() { }

	// RVA: 0x172C1D0 Offset: 0x172C2D1 VA: 0x172C1D0 Slot: 5
	public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }
}

