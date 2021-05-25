public class HUDLockOnObject : MonoBehaviour // TypeDefIndex: 8565
{
	// Fields
	[SerializeField] // RVA: 0x170A00 Offset: 0x170B01 VA: 0x170A00
	private GameObject LockOnImage; // 0x18
	[SerializeField] // RVA: 0x170A10 Offset: 0x170B11 VA: 0x170A10
	private GameObject StartLockOnImage; // 0x20
	[SerializeField] // RVA: 0x170A20 Offset: 0x170B21 VA: 0x170A20
	private UIImageMove[] UIImageMoves; // 0x28
	[SerializeField] // RVA: 0x170A30 Offset: 0x170B31 VA: 0x170A30
	private HudPadLock HudPadLock; // 0x30
	[SerializeField] // RVA: 0x170A40 Offset: 0x170B41 VA: 0x170A40
	private float StartAnimTime; // 0x38
	private float nowStartTime; // 0x3C
	private bool playingStartAnim; // 0x40
	private CharacterBase LockonTarget; // 0x48
	private bool isEnable; // 0x50

	// Methods

	// RVA: 0x1EC1380 Offset: 0x1EC1481 VA: 0x1EC1380
	private void Awake() { }

	// RVA: 0x1EC1400 Offset: 0x1EC1501 VA: 0x1EC1400
	private void PlayStartAnim() { }

	// RVA: 0x1EC14B0 Offset: 0x1EC15B1 VA: 0x1EC14B0
	public void ReplayStartAnim() { }

	// RVA: 0x1EC1560 Offset: 0x1EC1661 VA: 0x1EC1560
	private void ChangeToIdelAnim() { }

	// RVA: 0x1EC15B0 Offset: 0x1EC16B1 VA: 0x1EC15B0
	private void EndAnim() { }

	// RVA: 0x1EC1610 Offset: 0x1EC1711 VA: 0x1EC1610
	private void Update() { }

	// RVA: 0x1EC1B40 Offset: 0x1EC1C41 VA: 0x1EC1B40
	public void .ctor() { }
}

