public class FestivalSnowball : MonoBehaviour // TypeDefIndex: 7408
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x166370 Offset: 0x166471 VA: 0x166370
	private SnowballData <SnowballData>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x166380 Offset: 0x166481 VA: 0x166380
	private Renderer rend; // 0x20
	[SerializeField] // RVA: 0x166390 Offset: 0x166491 VA: 0x166390
	private Material[] material; // 0x28
	[SerializeField] // RVA: 0x1663A0 Offset: 0x1664A1 VA: 0x1663A0
	private GameObject[] snowball; // 0x30
	private const float FLASHING_SPEED = 15;
	private bool isFlashing; // 0x38

	// Properties
	public SnowballData SnowballData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A0AF0 Offset: 0x1A0BF1 VA: 0x1A0AF0
	// RVA: 0x1E230D0 Offset: 0x1E231D1 VA: 0x1E230D0
	public SnowballData get_SnowballData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0B00 Offset: 0x1A0C01 VA: 0x1A0B00
	// RVA: 0x1E230E0 Offset: 0x1E231E1 VA: 0x1E230E0
	private void set_SnowballData(SnowballData value) { }

	// RVA: 0x1E230F0 Offset: 0x1E231F1 VA: 0x1E230F0
	private void Update() { }

	// RVA: 0x1E23240 Offset: 0x1E23341 VA: 0x1E23240
	public void SwitchSnowball(SnowmanObjectID _id) { }

	// RVA: 0x1E234A0 Offset: 0x1E235A1 VA: 0x1E234A0
	public void StartFlash() { }

	// RVA: 0x1E23100 Offset: 0x1E23201 VA: 0x1E23100
	private void UpdateFlashing() { }

	// RVA: 0x1E234B0 Offset: 0x1E235B1 VA: 0x1E234B0
	public void .ctor() { }
}

