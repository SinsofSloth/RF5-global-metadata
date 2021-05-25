public class CamSpeedButton : ButtonLinkerSetImage // TypeDefIndex: 8798
{
	// Fields
	[SerializeField] // RVA: 0x173890 Offset: 0x173991 VA: 0x173890
	private Image Gauge; // 0xC0
	[SerializeField] // RVA: 0x1738A0 Offset: 0x1739A1 VA: 0x1738A0
	private Slider Slider; // 0xC8
	[SerializeField] // RVA: 0x1738B0 Offset: 0x1739B1 VA: 0x1738B0
	private Text valueText; // 0xD0
	[SerializeField] // RVA: 0x1738C0 Offset: 0x1739C1 VA: 0x1738C0
	private CamSpeedButton.CamType camType; // 0xD8

	// Properties
	private float _Value { get; set; }

	// Methods

	// RVA: 0x1D32AA0 Offset: 0x1D32BA1 VA: 0x1D32AA0
	private float get__Value() { }

	// RVA: 0x1D32AE0 Offset: 0x1D32BE1 VA: 0x1D32AE0
	private void set__Value(float value) { }

	// RVA: 0x1D32B40 Offset: 0x1D32C41 VA: 0x1D32B40 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1D32B50 Offset: 0x1D32C51 VA: 0x1D32B50 Slot: 8
	public override void OnNextFocus(CursorLinker nextObject) { }

	// RVA: 0x1D32B60 Offset: 0x1D32C61 VA: 0x1D32B60
	private void OnEnable() { }

	// RVA: 0x1D32CB0 Offset: 0x1D32DB1 VA: 0x1D32CB0
	private void SyncGauge() { }

	// RVA: 0x1D32D90 Offset: 0x1D32E91 VA: 0x1D32D90
	private void Update() { }

	// RVA: 0x1D330F0 Offset: 0x1D331F1 VA: 0x1D330F0
	public void OnSliderChange() { }

	// RVA: 0x1D33140 Offset: 0x1D33241 VA: 0x1D33140
	private void Start() { }

	// RVA: 0x1D331A0 Offset: 0x1D332A1 VA: 0x1D331A0
	public void .ctor() { }
}

