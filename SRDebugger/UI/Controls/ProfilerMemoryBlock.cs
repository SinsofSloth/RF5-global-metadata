public class ProfilerMemoryBlock : SRMonoBehaviourEx // TypeDefIndex: 5590
{
	// Fields
	private float _lastRefresh; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C8A0 Offset: 0x13C9A1 VA: 0x13C8A0
	public Text CurrentUsedText; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C8B0 Offset: 0x13C9B1 VA: 0x13C8B0
	public Slider Slider; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C8C0 Offset: 0x13C9C1 VA: 0x13C8C0
	public Text TotalAllocatedText; // 0x60

	// Methods

	// RVA: 0x1B2D620 Offset: 0x1B2D721 VA: 0x1B2D620 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B2D870 Offset: 0x1B2D971 VA: 0x1B2D870 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B2D650 Offset: 0x1B2D751 VA: 0x1B2D650
	public void TriggerRefresh() { }

	// RVA: 0x1B2D980 Offset: 0x1B2DA81 VA: 0x1B2D980
	public void TriggerCleanup() { }

	[IteratorStateMachineAttribute] // RVA: 0x13CF60 Offset: 0x13D061 VA: 0x13CF60
	// RVA: 0x1B2DA10 Offset: 0x1B2DB11 VA: 0x1B2DA10
	private IEnumerator CleanUp() { }

	// RVA: 0x1B2DAC0 Offset: 0x1B2DBC1 VA: 0x1B2DAC0
	public void .ctor() { }
}

