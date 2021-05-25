public class EquipStatusMenu : MonoBehaviour // TypeDefIndex: 8658
{
	// Fields
	[SerializeField] // RVA: 0x171A00 Offset: 0x171B01 VA: 0x171A00
	private Text Txt_Hp; // 0x18
	[SerializeField] // RVA: 0x171A10 Offset: 0x171B11 VA: 0x171A10
	private Text Txt_Rp; // 0x20
	[SerializeField] // RVA: 0x171A20 Offset: 0x171B21 VA: 0x171A20
	private Text Txt_Lv; // 0x28
	[SerializeField] // RVA: 0x171A30 Offset: 0x171B31 VA: 0x171A30
	private Image Img_HpGauge; // 0x30
	[SerializeField] // RVA: 0x171A40 Offset: 0x171B41 VA: 0x171A40
	private Image Img_RpGauge; // 0x38
	[SerializeField] // RVA: 0x171A50 Offset: 0x171B51 VA: 0x171A50
	private Image Img_ExpGauge; // 0x40
	[SerializeField] // RVA: 0x171A60 Offset: 0x171B61 VA: 0x171A60
	private Text Txt_Atk; // 0x48
	[SerializeField] // RVA: 0x171A70 Offset: 0x171B71 VA: 0x171A70
	private Text Txt_Def; // 0x50
	[SerializeField] // RVA: 0x171A80 Offset: 0x171B81 VA: 0x171A80
	private Text Txt_MAtk; // 0x58
	[SerializeField] // RVA: 0x171A90 Offset: 0x171B91 VA: 0x171A90
	private Text Txt_MDef; // 0x60
	[SerializeField] // RVA: 0x171AA0 Offset: 0x171BA1 VA: 0x171AA0
	private Text Txt_Str; // 0x68
	[SerializeField] // RVA: 0x171AB0 Offset: 0x171BB1 VA: 0x171AB0
	private Text Txt_Vit; // 0x70
	[SerializeField] // RVA: 0x171AC0 Offset: 0x171BC1 VA: 0x171AC0
	private Text Txt_Int; // 0x78
	[SerializeField] // RVA: 0x171AD0 Offset: 0x171BD1 VA: 0x171AD0
	private Text Txt_NPCName; // 0x80
	[SerializeField] // RVA: 0x171AE0 Offset: 0x171BE1 VA: 0x171AE0
	private Text Txt_DifAtk; // 0x88
	[SerializeField] // RVA: 0x171AF0 Offset: 0x171BF1 VA: 0x171AF0
	private Text Txt_DifDef; // 0x90
	[SerializeField] // RVA: 0x171B00 Offset: 0x171C01 VA: 0x171B00
	private Text Txt_DifMAtk; // 0x98
	[SerializeField] // RVA: 0x171B10 Offset: 0x171C11 VA: 0x171B10
	private Text Txt_DifMDef; // 0xA0
	[SerializeField] // RVA: 0x171B20 Offset: 0x171C21 VA: 0x171B20
	private Text Txt_DifStr; // 0xA8
	[SerializeField] // RVA: 0x171B30 Offset: 0x171C31 VA: 0x171B30
	private Text Txt_DifVit; // 0xB0
	[SerializeField] // RVA: 0x171B40 Offset: 0x171C41 VA: 0x171B40
	private Text Txt_DifInt; // 0xB8
	[SerializeField] // RVA: 0x171B50 Offset: 0x171C51 VA: 0x171B50
	private Text Txt_ResistFire; // 0xC0
	[SerializeField] // RVA: 0x171B60 Offset: 0x171C61 VA: 0x171B60
	private Text Txt_ResistWater; // 0xC8
	[SerializeField] // RVA: 0x171B70 Offset: 0x171C71 VA: 0x171B70
	private Text Txt_ResistEarth; // 0xD0
	[SerializeField] // RVA: 0x171B80 Offset: 0x171C81 VA: 0x171B80
	private Text Txt_ResistWind; // 0xD8
	[SerializeField] // RVA: 0x171B90 Offset: 0x171C91 VA: 0x171B90
	private Text Txt_ResistShine; // 0xE0
	[SerializeField] // RVA: 0x171BA0 Offset: 0x171CA1 VA: 0x171BA0
	private Text Txt_ResistDark; // 0xE8
	[SerializeField] // RVA: 0x171BB0 Offset: 0x171CB1 VA: 0x171BB0
	private Text Txt_ResistLove; // 0xF0
	[SerializeField] // RVA: 0x171BC0 Offset: 0x171CC1 VA: 0x171BC0
	private Image Icon_DifAtk; // 0xF8
	[SerializeField] // RVA: 0x171BD0 Offset: 0x171CD1 VA: 0x171BD0
	private Image Icon_DifDef; // 0x100
	[SerializeField] // RVA: 0x171BE0 Offset: 0x171CE1 VA: 0x171BE0
	private Image Icon_DifMAtk; // 0x108
	[SerializeField] // RVA: 0x171BF0 Offset: 0x171CF1 VA: 0x171BF0
	private Image Icon_DifMDef; // 0x110
	[SerializeField] // RVA: 0x171C00 Offset: 0x171D01 VA: 0x171C00
	private Image Icon_DifStr; // 0x118
	[SerializeField] // RVA: 0x171C10 Offset: 0x171D11 VA: 0x171C10
	private Image Icon_DifVit; // 0x120
	[SerializeField] // RVA: 0x171C20 Offset: 0x171D21 VA: 0x171C20
	private Image Icon_DifInt; // 0x128
	[SerializeField] // RVA: 0x171C30 Offset: 0x171D31 VA: 0x171C30
	private Image Icon_ResistFire; // 0x130
	[SerializeField] // RVA: 0x171C40 Offset: 0x171D41 VA: 0x171C40
	private Image Icon_ResistWater; // 0x138
	[SerializeField] // RVA: 0x171C50 Offset: 0x171D51 VA: 0x171C50
	private Image Icon_ResistEarth; // 0x140
	[SerializeField] // RVA: 0x171C60 Offset: 0x171D61 VA: 0x171C60
	private Image Icon_ResistWind; // 0x148
	[SerializeField] // RVA: 0x171C70 Offset: 0x171D71 VA: 0x171C70
	private Image Icon_ResistShine; // 0x150
	[SerializeField] // RVA: 0x171C80 Offset: 0x171D81 VA: 0x171C80
	private Image Icon_ResistDark; // 0x158
	[SerializeField] // RVA: 0x171C90 Offset: 0x171D91 VA: 0x171C90
	private Image Icon_ResistLove; // 0x160
	[SerializeField] // RVA: 0x171CA0 Offset: 0x171DA1 VA: 0x171CA0
	private Sprite parameterUpIcon; // 0x168
	[SerializeField] // RVA: 0x171CB0 Offset: 0x171DB1 VA: 0x171CB0
	private Sprite parameterDownIcon; // 0x170
	[SerializeField] // RVA: 0x171CC0 Offset: 0x171DC1 VA: 0x171CC0
	private Sprite resistParameterUpIcon; // 0x178
	[SerializeField] // RVA: 0x171CD0 Offset: 0x171DD1 VA: 0x171CD0
	private Sprite resistParameterDownIcon; // 0x180
	private int charaId; // 0x188
	private readonly Color PARAMETERUP_COLOR; // 0x18C
	private readonly Color PARAMETERDOWN_COLOR; // 0x19C

	// Methods

	// RVA: 0x2AE0750 Offset: 0x2AE0851 VA: 0x2AE0750
	private EquipSlotType GetSlotType(ItemType ItemType) { }

	// RVA: 0x2AE0780 Offset: 0x2AE0881 VA: 0x2AE0780
	private void AddItemToEquip(HumanEquip equip, ItemData itemData) { }

	// RVA: 0x2AE0800 Offset: 0x2AE0901 VA: 0x2AE0800
	private Parameter GetParameter(ActorID actor_id, bool UseWeaponStatus, bool UseToolStatus, ItemData itemData) { }

	// RVA: 0x2AE0930 Offset: 0x2AE0A31 VA: 0x2AE0930
	public void SetStatusNPC(ActorID actor_id, bool UseWeaponStatus, bool UseToolStatus) { }

	// RVA: 0x2AE17F0 Offset: 0x2AE18F1 VA: 0x2AE17F0
	private void ShowDifText(Text Txt, Image iconImg, int defaultVal, int equipedVal, bool isResistParameter = False) { }

	// RVA: 0x2AE1A00 Offset: 0x2AE1B01 VA: 0x2AE1A00
	private void ShowDifText(Text Txt, Image iconImg, float _defaultVal, float _equipedVal, bool isResistParameter = False) { }

	// RVA: 0x2AE1CC0 Offset: 0x2AE1DC1 VA: 0x2AE1CC0
	public void SetDifItemParameter(ActorID actorID, bool UseWeaponStatus, bool UseToolStatus, ItemData itemData) { }

	// RVA: 0x2AE2180 Offset: 0x2AE2281 VA: 0x2AE2180
	public void ClearDifItemParamter() { }

	// RVA: 0x2AE26E0 Offset: 0x2AE27E1 VA: 0x2AE26E0
	public void .ctor() { }
}

