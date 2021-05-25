public class AutoPilot : MonoBehaviour // TypeDefIndex: 6679
{
	// Fields
	[SerializeField] // RVA: 0x15EBB0 Offset: 0x15ECB1 VA: 0x15EBB0
	private float IntervalBase; // 0x18
	[SerializeField] // RVA: 0x15EBC0 Offset: 0x15ECC1 VA: 0x15EBC0
	private float IntervalRange; // 0x1C
	[SerializeField] // RVA: 0x15EBD0 Offset: 0x15ECD1 VA: 0x15EBD0
	private int[] padPatternWeight; // 0x20
	private int totalWeight; // 0x28
	private AutoPilot.PadPattern padPattern; // 0x2C
	private float intervalSec; // 0x30

	// Methods

	// RVA: 0x214AE20 Offset: 0x214AF21 VA: 0x214AE20
	private void Awake() { }

	// RVA: 0x214AF30 Offset: 0x214B031 VA: 0x214AF30
	private void Update() { }

	[ContextMenu] // RVA: 0x19C8C0 Offset: 0x19C9C1 VA: 0x19C8C0
	// RVA: 0x214AE30 Offset: 0x214AF31 VA: 0x214AE30
	private void ResetTotalWeight() { }

	// RVA: 0x214B0D0 Offset: 0x214B1D1 VA: 0x214B0D0
	private void SetInterval() { }

	// RVA: 0x214B110 Offset: 0x214B211 VA: 0x214B110
	public Vector3 InputDirection() { }

	// RVA: 0x214B220 Offset: 0x214B321 VA: 0x214B220
	public void .ctor() { }
}

