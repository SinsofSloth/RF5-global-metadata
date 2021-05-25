public class ItemSortMenu : MonoBehaviour // TypeDefIndex: 8603
{
	// Fields
	[SerializeField] // RVA: 0x171050 Offset: 0x171151 VA: 0x171050
	private GameObject ItemBlock; // 0x18
	[SerializeField] // RVA: 0x171060 Offset: 0x171161 VA: 0x171060
	private GameObject RuneBlock; // 0x20
	[SerializeField] // RVA: 0x171070 Offset: 0x171171 VA: 0x171070
	private Transform MenuItemParent; // 0x28
	[SerializeField] // RVA: 0x171080 Offset: 0x171181 VA: 0x171080
	private Transform MenuRuneParent; // 0x30
	private Image[] MenuItem; // 0x38
	[SerializeField] // RVA: 0x171090 Offset: 0x171191 VA: 0x171090
	private Sprite selectedBorderSprite; // 0x40
	[SerializeField] // RVA: 0x1710A0 Offset: 0x1711A1 VA: 0x1710A0
	private Sprite NonSelectBorderSprite; // 0x48
	[SerializeField] // RVA: 0x1710B0 Offset: 0x1711B1 VA: 0x1710B0
	private Sprite selectedLastBorderSprite; // 0x50
	[SerializeField] // RVA: 0x1710C0 Offset: 0x1711C1 VA: 0x1710C0
	private Sprite NonSelectLastBorderSprite; // 0x58
	private GenerateItemSlot MyGenerator; // 0x60
	private int selectingtItem; // 0x68
	private readonly SubSortType[] ItemTypeTable; // 0x70
	private readonly SubSortType[] RuneTypeTable; // 0x78

	// Methods

	// RVA: 0x208BAC0 Offset: 0x208BBC1 VA: 0x208BAC0
	public void OnInstantiate(GenerateItemSlot _MyGenerator) { }

	// RVA: 0x208BBA0 Offset: 0x208BCA1 VA: 0x208BBA0
	private void SetCursorPos() { }

	// RVA: 0x208BC90 Offset: 0x208BD91 VA: 0x208BC90
	private void Start() { }

	// RVA: 0x208BD20 Offset: 0x208BE21 VA: 0x208BD20
	private void Update() { }

	// RVA: 0x208BF70 Offset: 0x208C071 VA: 0x208BF70
	private void CloseWindows() { }

	// RVA: 0x208C030 Offset: 0x208C131 VA: 0x208C030
	public void .ctor() { }
}

