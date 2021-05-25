[ServiceAttribute] // RVA: 0x13B7D0 Offset: 0x13B8D1 VA: 0x13B7D0
public class DebugTriggerImpl : SRServiceBase<IDebugTriggerService>, IDebugTriggerService // TypeDefIndex: 5630
{
	// Fields
	private PinAlignment _position; // 0x48
	private TriggerRoot _trigger; // 0x50
	private IConsoleService _consoleService; // 0x58

	// Properties
	public bool IsEnabled { get; set; }
	public PinAlignment Position { get; set; }

	// Methods

	// RVA: 0x1535DD0 Offset: 0x1535ED1 VA: 0x1535DD0 Slot: 11
	public bool get_IsEnabled() { }

	// RVA: 0x1535E80 Offset: 0x1535F81 VA: 0x1535E80 Slot: 12
	public void set_IsEnabled(bool value) { }

	// RVA: 0x15363A0 Offset: 0x15364A1 VA: 0x15363A0 Slot: 13
	public PinAlignment get_Position() { }

	// RVA: 0x15363B0 Offset: 0x15364B1 VA: 0x15363B0 Slot: 14
	public void set_Position(PinAlignment value) { }

	// RVA: 0x1536560 Offset: 0x1536661 VA: 0x1536560 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1536670 Offset: 0x1536771 VA: 0x1536670
	private void OnError(IConsoleService console) { }

	// RVA: 0x1535F80 Offset: 0x1536081 VA: 0x1535F80
	private void CreateTrigger() { }

	// RVA: 0x1536710 Offset: 0x1536811 VA: 0x1536710 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1536880 Offset: 0x1536981 VA: 0x1536880
	private static void OnActiveSceneChanged(Scene s1, Scene s2) { }

	// RVA: 0x1536890 Offset: 0x1536991 VA: 0x1536890
	private void OnTriggerButtonClick() { }

	// RVA: 0x1536450 Offset: 0x1536551 VA: 0x1536450
	private static void SetTriggerPosition(RectTransform t, PinAlignment position) { }

	// RVA: 0x1536A30 Offset: 0x1536B31 VA: 0x1536A30
	public void .ctor() { }
}

