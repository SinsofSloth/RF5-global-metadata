[AddComponentMenu] // RVA: 0x11AAF0 Offset: 0x11ABF1 VA: 0x11AAF0
public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 4084
{
	// Fields
	private float m_PrevActionTime; // 0x58
	private Vector2 m_LastMoveVector; // 0x5C
	private int m_ConsecutiveMoveCount; // 0x64
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private GameObject m_CurrentFocusedGameObject; // 0x78
	private PointerEventData m_InputPointerEvent; // 0x80
	[SerializeField] // RVA: 0x11CC40 Offset: 0x11CD41 VA: 0x11CC40
	private string m_HorizontalAxis; // 0x88
	[SerializeField] // RVA: 0x11CC50 Offset: 0x11CD51 VA: 0x11CC50
	private string m_VerticalAxis; // 0x90
	[SerializeField] // RVA: 0x11CC60 Offset: 0x11CD61 VA: 0x11CC60
	private string m_SubmitButton; // 0x98
	[SerializeField] // RVA: 0x11CC70 Offset: 0x11CD71 VA: 0x11CC70
	private string m_CancelButton; // 0xA0
	[SerializeField] // RVA: 0x11CC80 Offset: 0x11CD81 VA: 0x11CC80
	private float m_InputActionsPerSecond; // 0xA8
	[SerializeField] // RVA: 0x11CC90 Offset: 0x11CD91 VA: 0x11CC90
	private float m_RepeatDelay; // 0xAC
	[SerializeField] // RVA: 0x11CCA0 Offset: 0x11CDA1 VA: 0x11CCA0
	[FormerlySerializedAsAttribute] // RVA: 0x11CCA0 Offset: 0x11CDA1 VA: 0x11CCA0
	private bool m_ForceModuleActive; // 0xB0

	// Properties
	[ObsoleteAttribute] // RVA: 0x11DBA0 Offset: 0x11DCA1 VA: 0x11DBA0
	public StandaloneInputModule.InputMode inputMode { get; }
	[ObsoleteAttribute] // RVA: 0x11DBE0 Offset: 0x11DCE1 VA: 0x11DBE0
	public bool allowActivationOnMobileDevice { get; set; }
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x1640EA0 Offset: 0x1640FA1 VA: 0x1640EA0
	protected void .ctor() { }

	// RVA: 0x1640F50 Offset: 0x1641051 VA: 0x1640F50
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x1640F60 Offset: 0x1641061 VA: 0x1640F60
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x1640F70 Offset: 0x1641071 VA: 0x1640F70
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x1640F80 Offset: 0x1641081 VA: 0x1640F80
	public bool get_forceModuleActive() { }

	// RVA: 0x1640F90 Offset: 0x1641091 VA: 0x1640F90
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x1640FA0 Offset: 0x16410A1 VA: 0x1640FA0
	public float get_inputActionsPerSecond() { }

	// RVA: 0x1640FB0 Offset: 0x16410B1 VA: 0x1640FB0
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x1640FC0 Offset: 0x16410C1 VA: 0x1640FC0
	public float get_repeatDelay() { }

	// RVA: 0x1640FD0 Offset: 0x16410D1 VA: 0x1640FD0
	public void set_repeatDelay(float value) { }

	// RVA: 0x1640FE0 Offset: 0x16410E1 VA: 0x1640FE0
	public string get_horizontalAxis() { }

	// RVA: 0x1640FF0 Offset: 0x16410F1 VA: 0x1640FF0
	public void set_horizontalAxis(string value) { }

	// RVA: 0x1641000 Offset: 0x1641101 VA: 0x1641000
	public string get_verticalAxis() { }

	// RVA: 0x1641010 Offset: 0x1641111 VA: 0x1641010
	public void set_verticalAxis(string value) { }

	// RVA: 0x1641020 Offset: 0x1641121 VA: 0x1641020
	public string get_submitButton() { }

	// RVA: 0x1641030 Offset: 0x1641131 VA: 0x1641030
	public void set_submitButton(string value) { }

	// RVA: 0x1641040 Offset: 0x1641141 VA: 0x1641040
	public string get_cancelButton() { }

	// RVA: 0x1641050 Offset: 0x1641151 VA: 0x1641050
	public void set_cancelButton(string value) { }

	// RVA: 0x1641060 Offset: 0x1641161 VA: 0x1641060
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x1641090 Offset: 0x1641191 VA: 0x1641090 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x16411B0 Offset: 0x16412B1 VA: 0x16411B0
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x1641610 Offset: 0x1641711 VA: 0x1641610 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x1641680 Offset: 0x1641781 VA: 0x1641680 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x16418D0 Offset: 0x16419D1 VA: 0x16418D0 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x1641A00 Offset: 0x1641B01 VA: 0x1641A00 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x1641A10 Offset: 0x1641B11 VA: 0x1641A10 Slot: 17
	public override void Process() { }

	// RVA: 0x1641C50 Offset: 0x1641D51 VA: 0x1641C50
	private bool ProcessTouchEvents() { }

	// RVA: 0x1642340 Offset: 0x1642441 VA: 0x1642340
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x1642100 Offset: 0x1642201 VA: 0x1642100
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x1642C40 Offset: 0x1642D41 VA: 0x1642C40
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x1641E60 Offset: 0x1641F61 VA: 0x1641E60
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x1641E50 Offset: 0x1641F51 VA: 0x1641E50
	protected void ProcessMouseEvent() { }

	[ObsoleteAttribute] // RVA: 0x11D700 Offset: 0x11D801 VA: 0x11D700
	// RVA: 0x1643020 Offset: 0x1643121 VA: 0x1643020 Slot: 30
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x1642D90 Offset: 0x1642E91 VA: 0x1642D90
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x1641AD0 Offset: 0x1641BD1 VA: 0x1641AD0
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x1643030 Offset: 0x1643131 VA: 0x1643030
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x16434B0 Offset: 0x16435B1 VA: 0x16434B0
	protected GameObject GetCurrentFocusedGameObject() { }
}

