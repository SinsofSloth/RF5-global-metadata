public class DiagnosticEventCollector : MonoBehaviour // TypeDefIndex: 4508
{
	// Fields
	private static DiagnosticEventCollector s_Collector; // 0x0

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x19D6CB0 Offset: 0x19D6DB1 VA: 0x19D6CB0
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x19D6DD0 Offset: 0x19D6ED1 VA: 0x19D6DD0
	public static DiagnosticEventCollector FindOrCreateGlobalInstance() { }

	// RVA: 0x19D6F80 Offset: 0x19D7081 VA: 0x19D6F80
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x19D7070 Offset: 0x19D7171 VA: 0x19D7070
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x19D7180 Offset: 0x19D7281 VA: 0x19D7180
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x19D7400 Offset: 0x19D7501 VA: 0x19D7400
	public void .ctor() { }
}

