public class SimpleHpBar : MonoBehaviour // TypeDefIndex: 8959
{
	// Fields
	private CharacterStatusBase Sstatus; // 0x18
	private GameObject Prefab; // 0x20
	private Image Gauge; // 0x28
	private HUDDamageHpBar HUDDamageHpBar; // 0x30
	private Image borderObject; // 0x38
	[SerializeField] // RVA: 0x174EC0 Offset: 0x174FC1 VA: 0x174EC0
	private Vector3 offset; // 0x40
	private Camera Camera; // 0x50
	private UIPositionOnModelHead UIPositionOnModelHead; // 0x58
	private float appearTime; // 0x60
	private readonly float appearTimeMax; // 0x64
	private bool nowAppear; // 0x68
	private bool visible; // 0x69
	private bool hiding; // 0x6A
	private HUDBadStatusIconDisp BadStatusIcon; // 0x70
	private float hp; // 0x78
	private float hpMax; // 0x7C

	// Methods

	// RVA: 0x1C4FF70 Offset: 0x1C50071 VA: 0x1C4FF70
	private void Start() { }

	// RVA: 0x1C506F0 Offset: 0x1C507F1 VA: 0x1C506F0
	private void OnDestroy() { }

	// RVA: 0x1C505C0 Offset: 0x1C506C1 VA: 0x1C505C0
	public void SetAppear(bool stat) { }

	// RVA: 0x1C50680 Offset: 0x1C50781 VA: 0x1C50680
	private void SetVisible(bool Flag) { }

	// RVA: 0x1C50760 Offset: 0x1C50861 VA: 0x1C50760
	private void Update() { }

	// RVA: 0x1C50430 Offset: 0x1C50531 VA: 0x1C50430
	private void UpdateHp(CharacterStatusBase status, int amount) { }

	// RVA: 0x1C50BE0 Offset: 0x1C50CE1 VA: 0x1C50BE0
	public void SetHide(bool val) { }

	// RVA: 0x1C50BF0 Offset: 0x1C50CF1 VA: 0x1C50BF0
	public void .ctor() { }
}

