public class HumanStatusA : MonoBehaviour // TypeDefIndex: 8678
{
	// Fields
	public HumanStatusA.HumanType type; // 0x18
	[SerializeField] // RVA: 0x172190 Offset: 0x172291 VA: 0x172190
	private Text LvText; // 0x20
	[SerializeField] // RVA: 0x1721A0 Offset: 0x1722A1 VA: 0x1721A0
	private Image ExpGauge; // 0x28
	[SerializeField] // RVA: 0x1721B0 Offset: 0x1722B1 VA: 0x1721B0
	private Text HpText; // 0x30
	[SerializeField] // RVA: 0x1721C0 Offset: 0x1722C1 VA: 0x1721C0
	private Image HpGauge; // 0x38
	[SerializeField] // RVA: 0x1721D0 Offset: 0x1722D1 VA: 0x1721D0
	private Text RpText; // 0x40
	[SerializeField] // RVA: 0x1721E0 Offset: 0x1722E1 VA: 0x1721E0
	private Image RpGauge; // 0x48
	[SerializeField] // RVA: 0x1721F0 Offset: 0x1722F1 VA: 0x1721F0
	private Image RideIcon1; // 0x50
	[SerializeField] // RVA: 0x172200 Offset: 0x172301 VA: 0x172200
	private Image RideIcon2; // 0x58
	[SerializeField] // RVA: 0x172210 Offset: 0x172311 VA: 0x172210
	private Sprite Ride1SpriteOK; // 0x60
	[SerializeField] // RVA: 0x172220 Offset: 0x172321 VA: 0x172220
	private Sprite Ride2SpriteOK; // 0x68
	[SerializeField] // RVA: 0x172230 Offset: 0x172331 VA: 0x172230
	private Sprite Ride1SpriteNG; // 0x70
	[SerializeField] // RVA: 0x172240 Offset: 0x172341 VA: 0x172240
	private Sprite Ride2SpriteNG; // 0x78

	// Methods

	// RVA: 0x20C3A90 Offset: 0x20C3B91 VA: 0x20C3A90
	public void SetParameter(ActorID actor_id, HumanStatus humanStatus) { }

	// RVA: 0x20C3E10 Offset: 0x20C3F11 VA: 0x20C3E10
	public void SetParameter(FriendMonsterStatus monsterStatusController) { }

	// RVA: 0x20C41F0 Offset: 0x20C42F1 VA: 0x20C41F0
	public void SetParameter(HandCuffsStatus monsterStatusController, MonsterDataTable monsterDataTable) { }

	// RVA: 0x20C45C0 Offset: 0x20C46C1 VA: 0x20C45C0
	public void .ctor() { }
}

