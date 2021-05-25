public class HUDPartnerBuffIcon : MonoBehaviour // TypeDefIndex: 8574
{
	// Fields
	[SerializeField] // RVA: 0x170BC0 Offset: 0x170CC1 VA: 0x170BC0
	private Image FoodIconImage; // 0x18
	[SerializeField] // RVA: 0x170BD0 Offset: 0x170CD1 VA: 0x170BD0
	private Image RuneBuffIconImage; // 0x20
	[SerializeField] // RVA: 0x170BE0 Offset: 0x170CE1 VA: 0x170BE0
	private Sprite[] RuneBuffSprites; // 0x28
	[SerializeField] // RVA: 0x170BF0 Offset: 0x170CF1 VA: 0x170BF0
	private AnimationCurve RuneBuffAnimationCurve; // 0x30
	private bool inited; // 0x38
	private bool foodStat; // 0x39
	private bool runeBuffStat; // 0x3A
	private CharacterStatusBase status; // 0x40
	private bool[] runeBuffSubStat; // 0x48
	private List<Sprite> RuneBuffSpriteList; // 0x50
	private float runeBuffChangeTime; // 0x58
	private int nowRuneBuffSpriteNo; // 0x5C

	// Methods

	// RVA: 0x1ECDAD0 Offset: 0x1ECDBD1 VA: 0x1ECDAD0
	private void CheckInit() { }

	// RVA: 0x1ECDC10 Offset: 0x1ECDD11 VA: 0x1ECDC10
	private void Start() { }

	// RVA: 0x1EB8580 Offset: 0x1EB8681 VA: 0x1EB8580
	public void Setup(CharacterStatusBase _status) { }

	// RVA: 0x1ECDC20 Offset: 0x1ECDD21 VA: 0x1ECDC20
	private bool CheckOnFoodBuff() { }

	// RVA: 0x1ECDD80 Offset: 0x1ECDE81 VA: 0x1ECDD80
	private void SetDispFood() { }

	// RVA: 0x1ECDE70 Offset: 0x1ECDF71 VA: 0x1ECDE70
	private bool CheckOnRuneBuff() { }

	// RVA: 0x1ECE150 Offset: 0x1ECE251 VA: 0x1ECE150
	private void SetDispRuneBuff() { }

	// RVA: 0x1ECE290 Offset: 0x1ECE391 VA: 0x1ECE290
	private void Update() { }

	// RVA: 0x1ECE2E0 Offset: 0x1ECE3E1 VA: 0x1ECE2E0
	public void .ctor() { }
}

