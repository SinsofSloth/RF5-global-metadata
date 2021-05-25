public class HUDCharactorStatus : MonoBehaviour // TypeDefIndex: 8544
{
	// Fields
	private readonly int[] PartnerIdTable; // 0x18
	[SerializeField] // RVA: 0x170540 Offset: 0x170641 VA: 0x170540
	private HUDCharactorStatus.CharactorType charactorType; // 0x20
	[SerializeField] // RVA: 0x170550 Offset: 0x170651 VA: 0x170550
	private Image HpGauge; // 0x28
	[SerializeField] // RVA: 0x170560 Offset: 0x170661 VA: 0x170560
	private HUDDamageHpBar HUDDamageHpBar; // 0x30
	[SerializeField] // RVA: 0x170570 Offset: 0x170671 VA: 0x170570
	private Image RpGauge; // 0x38
	[SerializeField] // RVA: 0x170580 Offset: 0x170681 VA: 0x170580
	private UIFaceIconLoader UIFaceIconLoader; // 0x40
	private float prevHpGageSize; // 0x48
	private float prevRpGageSize; // 0x4C
	[SerializeField] // RVA: 0x170590 Offset: 0x170691 VA: 0x170590
	private HUDBadStatusIconDisp HUDBadStatusIconDisp; // 0x50
	[SerializeField] // RVA: 0x1705A0 Offset: 0x1706A1 VA: 0x1705A0
	private HUDPartnerBuffIcon partnerBuffIcon; // 0x58
	[SerializeField] // RVA: 0x1705B0 Offset: 0x1706B1 VA: 0x1705B0
	public Image CanDualImage; // 0x60
	[SerializeField] // RVA: 0x1705C0 Offset: 0x1706C1 VA: 0x1705C0
	public Image DualGaugeImage; // 0x68
	[SerializeField] // RVA: 0x1705D0 Offset: 0x1706D1 VA: 0x1705D0
	public Image SelectDualImage; // 0x70
	public CharacterStatusBase Status; // 0x78
	public bool CharacterAttached; // 0x80
	private NPCID npcId; // 0x84
	private PartyBase ptBase; // 0x88
	private PartyHuman pthuman; // 0x90
	private PartyMonster ptmonster; // 0x98
	private PartyHandCuffs pthandcuff; // 0xA0
	private HumanStatus pthumanStatus; // 0xA8
	private bool IsPlayerMale; // 0xB0
	private float hp; // 0xB4
	private float hpMax; // 0xB8
	[SerializeField] // RVA: 0x1705E0 Offset: 0x1706E1 VA: 0x1705E0
	private Image BorderImage; // 0xC0
	[SerializeField] // RVA: 0x1705F0 Offset: 0x1706F1 VA: 0x1705F0
	private Sprite NPCBorder; // 0xC8
	[SerializeField] // RVA: 0x170600 Offset: 0x170701 VA: 0x170600
	private Sprite HandCuffBorder; // 0xD0
	[SerializeField] // RVA: 0x170610 Offset: 0x170711 VA: 0x170610
	private HUDDualWorkSelectInput HUDDualWorkSelectInput; // 0xD8

	// Methods

	// RVA: 0x1EB7800 Offset: 0x1EB7901 VA: 0x1EB7800
	public HUDCharactorStatus.CharactorType GetCharactorType() { }

	// RVA: 0x1EB7810 Offset: 0x1EB7911 VA: 0x1EB7810
	private void SetNpcIdFromPartner(int partnerid) { }

	// RVA: 0x1EB7C40 Offset: 0x1EB7D41 VA: 0x1EB7C40
	private CharacterStatusBase GetCharacter() { }

	// RVA: 0x1EB7D50 Offset: 0x1EB7E51 VA: 0x1EB7D50
	private void CheckCharaChange() { }

	// RVA: 0x1EB7EF0 Offset: 0x1EB7FF1 VA: 0x1EB7EF0
	public void CharaChange() { }

	// RVA: 0x1EB88B0 Offset: 0x1EB89B1 VA: 0x1EB88B0
	private void UpdateGauge(Image gauge, float max, float current) { }

	// RVA: 0x1EB8FE0 Offset: 0x1EB90E1 VA: 0x1EB8FE0
	private void OnUpdateHp(CharacterStatusBase status, int amount) { }

	// RVA: 0x1EB94E0 Offset: 0x1EB95E1 VA: 0x1EB94E0
	private void OnUpdateRp(CharacterStatusBase status, int amount) { }

	// RVA: 0x1EB9680 Offset: 0x1EB9781 VA: 0x1EB9680
	private void Update() { }

	// RVA: 0x1EB9710 Offset: 0x1EB9811 VA: 0x1EB9710
	private void Start() { }

	// RVA: 0x1EB9720 Offset: 0x1EB9821 VA: 0x1EB9720
	public void .ctor() { }
}

