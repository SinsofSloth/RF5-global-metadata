public class UICampQuestMain : MonoBehaviour // TypeDefIndex: 8690
{
	// Fields
	private UIQuestSlotInPoliceBook focusingSlot; // 0x18
	[SerializeField] // RVA: 0x172580 Offset: 0x172681 VA: 0x172580
	private ButtonLinker TopButton; // 0x20
	[SerializeField] // RVA: 0x172590 Offset: 0x172691 VA: 0x172590
	private Image QuestClearedImage; // 0x28
	[SerializeField] // RVA: 0x1725A0 Offset: 0x1726A1 VA: 0x1725A0
	private GameObject QuestDetail; // 0x30
	[SerializeField] // RVA: 0x1725B0 Offset: 0x1726B1 VA: 0x1725B0
	private GameObject NoAnyQuest; // 0x38
	[SerializeField] // RVA: 0x1725C0 Offset: 0x1726C1 VA: 0x1725C0
	private AdvCharaImageControl AdvCharaImageControl; // 0x40
	private AdvCharaImageControl NowAdvCharaImageControl; // 0x48
	private UIQuestSlotInPoliceBook[] questSlots; // 0x50
	private List<OrderData> AcceptOrderDatas; // 0x58
	private int OpenedNpcRequester; // 0x60
	private int currentDispNo; // 0x64

	// Methods

	// RVA: 0x1F05510 Offset: 0x1F05611 VA: 0x1F05510
	public void CancelQuest() { }

	// RVA: 0x1F05EA0 Offset: 0x1F05FA1 VA: 0x1F05EA0
	public void SetFocusingSlot(UIQuestSlotInPoliceBook _slot) { }

	// RVA: 0x1F06100 Offset: 0x1F06201 VA: 0x1F06100
	private void SetOpenDetail(bool doopen) { }

	// RVA: 0x1F05670 Offset: 0x1F05771 VA: 0x1F05670
	private void DispAll() { }

	// RVA: 0x1F06380 Offset: 0x1F06481 VA: 0x1F06380
	public void ChangeFocus(int _slot_no) { }

	// RVA: 0x1F063F0 Offset: 0x1F064F1 VA: 0x1F063F0
	private void OnEnable() { }

	// RVA: 0x1F06400 Offset: 0x1F06501 VA: 0x1F06400
	private void OnDisable() { }

	// RVA: 0x1F06530 Offset: 0x1F06631 VA: 0x1F06530
	public void .ctor() { }
}

