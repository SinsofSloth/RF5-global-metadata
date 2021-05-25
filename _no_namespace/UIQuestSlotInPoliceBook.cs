public class UIQuestSlotInPoliceBook : ButtonLinker // TypeDefIndex: 8696
{
	// Fields
	private UICampQuestMain UICampQuestMain; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x172670 Offset: 0x172771 VA: 0x172670
	private OrderData <orderData>k__BackingField; // 0x68
	[SerializeField] // RVA: 0x172680 Offset: 0x172781 VA: 0x172680
	private int slotNo; // 0x70
	[SerializeField] // RVA: 0x172690 Offset: 0x172791 VA: 0x172690
	private Image QuestIcon; // 0x78
	[SerializeField] // RVA: 0x1726A0 Offset: 0x1727A1 VA: 0x1726A0
	private Image TopicQuestIcon; // 0x80
	[SerializeField] // RVA: 0x1726B0 Offset: 0x1727B1 VA: 0x1726B0
	private Text TopicText; // 0x88
	[SerializeField] // RVA: 0x1726C0 Offset: 0x1727C1 VA: 0x1726C0
	private Text NumberText; // 0x90
	[SerializeField] // RVA: 0x1726D0 Offset: 0x1727D1 VA: 0x1726D0
	private Text FrebHeadText; // 0x98
	[SerializeField] // RVA: 0x1726E0 Offset: 0x1727E1 VA: 0x1726E0
	private Text FrebContentText; // 0xA0
	[SerializeField] // RVA: 0x1726F0 Offset: 0x1727F1 VA: 0x1726F0
	private Text RewardHeadText; // 0xA8
	[SerializeField] // RVA: 0x172700 Offset: 0x172801 VA: 0x172700
	private Text RewardContentText; // 0xB0
	[SerializeField] // RVA: 0x172710 Offset: 0x172811 VA: 0x172710
	private Sprite OnSelectSprite; // 0xB8
	[SerializeField] // RVA: 0x172720 Offset: 0x172821 VA: 0x172720
	private Sprite NotSelectSprite; // 0xC0
	[SerializeField] // RVA: 0x172730 Offset: 0x172831 VA: 0x172730
	private Sprite[] IconSprite; // 0xC8
	private Color NoneSelectIconColor; // 0xD0
	[SerializeField] // RVA: 0x172740 Offset: 0x172841 VA: 0x172740
	private UIQuestCancelButton CancelButton; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x172750 Offset: 0x172851 VA: 0x172750
	private bool <isWantedBlock>k__BackingField; // 0xE8

	// Properties
	public OrderData orderData { get; set; }
	public bool isWantedBlock { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A8060 Offset: 0x1A8161 VA: 0x1A8060
	// RVA: 0x1DD08F0 Offset: 0x1DD09F1 VA: 0x1DD08F0
	public OrderData get_orderData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8070 Offset: 0x1A8171 VA: 0x1A8070
	// RVA: 0x1DD0900 Offset: 0x1DD0A01 VA: 0x1DD0900
	private void set_orderData(OrderData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8080 Offset: 0x1A8181 VA: 0x1A8080
	// RVA: 0x1DD0910 Offset: 0x1DD0A11 VA: 0x1DD0910
	public bool get_isWantedBlock() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8090 Offset: 0x1A8191 VA: 0x1A8090
	// RVA: 0x1DD0920 Offset: 0x1DD0A21 VA: 0x1DD0920
	private void set_isWantedBlock(bool value) { }

	// RVA: 0x1DD0930 Offset: 0x1DD0A31 VA: 0x1DD0930
	public void SetupWanted() { }

	// RVA: 0x1DD0A10 Offset: 0x1DD0B11 VA: 0x1DD0A10
	public void Setup(UICampQuestMain _UICampQuestMain, OrderData _orderData) { }

	// RVA: 0x1DD0B80 Offset: 0x1DD0C81 VA: 0x1DD0B80
	public void DispQuestData() { }

	// RVA: 0x1DD1BE0 Offset: 0x1DD1CE1 VA: 0x1DD1BE0
	public void EndFocusButton() { }

	// RVA: 0x1DD1C70 Offset: 0x1DD1D71 VA: 0x1DD1C70 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1DD1CB0 Offset: 0x1DD1DB1 VA: 0x1DD1CB0 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1DD1CC0 Offset: 0x1DD1DC1 VA: 0x1DD1CC0
	public void .ctor() { }
}

