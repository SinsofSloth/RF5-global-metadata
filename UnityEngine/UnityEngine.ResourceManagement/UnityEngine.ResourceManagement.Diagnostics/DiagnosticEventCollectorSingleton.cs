public class DiagnosticEventCollectorSingleton : ComponentSingleton<DiagnosticEventCollectorSingleton> // TypeDefIndex: 4506
{
	// Fields
	private static Guid s_editorConnectionGuid; // 0x0
	internal Dictionary<int, DiagnosticEvent> m_CreatedEvents; // 0x18
	internal List<DiagnosticEvent> m_UnhandledEvents; // 0x20
	internal DelegateList<DiagnosticEvent> s_EventHandlers; // 0x28
	private float m_lastTickSent; // 0x30
	private int m_lastFrame; // 0x34
	private float fpsAvg; // 0x38

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x19D6CC0 Offset: 0x19D6DC1 VA: 0x19D6CC0
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x19D7410 Offset: 0x19D7511 VA: 0x19D7410 Slot: 4
	protected override string GetGameObjectName() { }

	// RVA: 0x19D6F90 Offset: 0x19D7091 VA: 0x19D6F90
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x19D7460 Offset: 0x19D7561 VA: 0x19D7460
	internal void RegisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x19D70D0 Offset: 0x19D71D1 VA: 0x19D70D0
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x19D7220 Offset: 0x19D7321 VA: 0x19D7220
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x19D78A0 Offset: 0x19D79A1 VA: 0x19D78A0
	private void Awake() { }

	// RVA: 0x19D79B0 Offset: 0x19D7AB1 VA: 0x19D79B0
	private void Update() { }

	// RVA: 0x19D7BF0 Offset: 0x19D7CF1 VA: 0x19D7BF0
	public void .ctor() { }
}

