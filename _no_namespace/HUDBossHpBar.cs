public class HUDBossHpBar : MonoBehaviour // TypeDefIndex: 8539
{
	// Fields
	public static HUDBossHpBar Instance; // 0x0
	[SerializeField] // RVA: 0x1704B0 Offset: 0x1705B1 VA: 0x1704B0
	private GameObject GaugeAllObject; // 0x18
	[SerializeField] // RVA: 0x1704C0 Offset: 0x1705C1 VA: 0x1704C0
	private HUDBossHpDispGauge[] HpGauges; // 0x20
	[SerializeField] // RVA: 0x1704D0 Offset: 0x1705D1 VA: 0x1704D0
	private HUDBadStatusIconDisp HUDBadStatusIconDisp; // 0x28
	private bool realAppearStat; // 0x30
	private bool nowAllHideStat; // 0x31

	// Methods

	// RVA: 0x1EB6CA0 Offset: 0x1EB6DA1 VA: 0x1EB6CA0
	private void Awake() { }

	// RVA: 0x1EB6D40 Offset: 0x1EB6E41 VA: 0x1EB6D40
	private void SetActive() { }

	// RVA: 0x1EB6E70 Offset: 0x1EB6F71 VA: 0x1EB6E70
	public void SetHpBar(float hp, float hpMax, CharacterStatusBase status) { }

	// RVA: 0x1EB6FF0 Offset: 0x1EB70F1 VA: 0x1EB6FF0
	public void OnHPBar() { }

	// RVA: 0x1EB7000 Offset: 0x1EB7101 VA: 0x1EB7000
	public void OffHpBar() { }

	// RVA: 0x1EB7010 Offset: 0x1EB7111 VA: 0x1EB7010
	private void LateUpdate() { }

	// RVA: 0x1EB7140 Offset: 0x1EB7241 VA: 0x1EB7140
	public void .ctor() { }
}

