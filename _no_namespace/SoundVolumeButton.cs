public class SoundVolumeButton : ButtonLinkerSetImage // TypeDefIndex: 8805
{
	// Fields
	[SerializeField] // RVA: 0x173970 Offset: 0x173A71 VA: 0x173970
	private Image Gauge; // 0xC0
	[SerializeField] // RVA: 0x173980 Offset: 0x173A81 VA: 0x173980
	private Slider Slider; // 0xC8
	[SerializeField] // RVA: 0x173990 Offset: 0x173A91 VA: 0x173990
	private MixerVolumeGroup MixerGroup; // 0xD0
	[SerializeField] // RVA: 0x1739A0 Offset: 0x173AA1 VA: 0x1739A0
	private Text SoundVolumeText; // 0xD8

	// Properties
	private float SoundValue { get; set; }

	// Methods

	// RVA: 0x2117AA0 Offset: 0x2117BA1 VA: 0x2117AA0
	private float get_SoundValue() { }

	// RVA: 0x2117B60 Offset: 0x2117C61 VA: 0x2117B60
	private void set_SoundValue(float value) { }

	// RVA: 0x2117C30 Offset: 0x2117D31 VA: 0x2117C30 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x2117C40 Offset: 0x2117D41 VA: 0x2117C40 Slot: 8
	public override void OnNextFocus(CursorLinker nextObject) { }

	// RVA: 0x2117C50 Offset: 0x2117D51 VA: 0x2117C50
	private void OnEnable() { }

	// RVA: 0x2117D80 Offset: 0x2117E81 VA: 0x2117D80
	private void SyncGauge() { }

	// RVA: 0x2117E50 Offset: 0x2117F51 VA: 0x2117E50
	private void Update() { }

	// RVA: 0x21180C0 Offset: 0x21181C1 VA: 0x21180C0
	public void OnSliderChange() { }

	// RVA: 0x2118110 Offset: 0x2118211 VA: 0x2118110
	private void Start() { }

	// RVA: 0x2118170 Offset: 0x2118271 VA: 0x2118170
	public void .ctor() { }
}

