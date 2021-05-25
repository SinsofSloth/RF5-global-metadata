public class UIEMCustomizeMenu : UIScrollBoxBase // TypeDefIndex: 9818
{
	// Fields
	[SerializeField] // RVA: 0x17F660 Offset: 0x17F761 VA: 0x17F660
	private Text DetailCategoryText; // 0x68
	[SerializeField] // RVA: 0x17F670 Offset: 0x17F771 VA: 0x17F670
	private Text DetailTextBox; // 0x70
	[SerializeField] // RVA: 0x17F680 Offset: 0x17F781 VA: 0x17F680
	private Text UpText; // 0x78
	[SerializeField] // RVA: 0x17F690 Offset: 0x17F791 VA: 0x17F690
	private Text DownText; // 0x80
	[SerializeField] // RVA: 0x17F6A0 Offset: 0x17F7A1 VA: 0x17F6A0
	private Text NowText; // 0x88
	[SerializeField] // RVA: 0x17F6B0 Offset: 0x17F7B1 VA: 0x17F6B0
	private Image UpIcon; // 0x90
	[SerializeField] // RVA: 0x17F6C0 Offset: 0x17F7C1 VA: 0x17F6C0
	private Image DownIcon; // 0x98
	[SerializeField] // RVA: 0x17F6D0 Offset: 0x17F7D1 VA: 0x17F6D0
	private Image NowIcon; // 0xA0
	[SerializeField] // RVA: 0x17F6E0 Offset: 0x17F7E1 VA: 0x17F6E0
	private Image PadIcon; // 0xA8
	[SerializeField] // RVA: 0x17F6F0 Offset: 0x17F7F1 VA: 0x17F6F0
	private Sprite[] OnIcon; // 0xB0
	[SerializeField] // RVA: 0x17F700 Offset: 0x17F801 VA: 0x17F700
	private Sprite[] OffIcon; // 0xB8
	private UIEMCustomizeCategoryBlock focusingBlock; // 0xC0
	private UIEMCustomizeCategoryBlock selectingBlock; // 0xC8
	private UIEMCustomizeSet selectingSet; // 0xD0
	private List<UIEMCustomizeSet> UIEMCustomizeSets; // 0xD8

	// Methods

	// RVA: 0x1D9C060 Offset: 0x1D9C161 VA: 0x1D9C060
	public int GetActivedCategorys() { }

	// RVA: 0x1D9CAC0 Offset: 0x1D9CBC1 VA: 0x1D9CAC0
	private void OnEnable() { }

	// RVA: 0x1D9CDC0 Offset: 0x1D9CEC1 VA: 0x1D9CDC0 Slot: 10
	protected override void OnDisable() { }

	// RVA: 0x1D9CC00 Offset: 0x1D9CD01 VA: 0x1D9CC00
	private void Generate() { }

	// RVA: 0x1D9CF90 Offset: 0x1D9D091 VA: 0x1D9CF90 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1D9CFF0 Offset: 0x1D9D0F1 VA: 0x1D9CFF0 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1D9C100 Offset: 0x1D9C201 VA: 0x1D9C100
	public void SetPreview(UIEMCustomizeSet _emset, bool _is_submit = False) { }

	// RVA: 0x1D9B710 Offset: 0x1D9B811 VA: 0x1D9B710
	internal void SetFocusingBlock(UIEMCustomizeCategoryBlock uIEMCustomizeCategoryBlock) { }

	// RVA: 0x1D9BE50 Offset: 0x1D9BF51 VA: 0x1D9BE50
	internal void DoSelectX(UIEMCustomizeCategoryBlock uIEMCustomizeCategoryBlock) { }

	// RVA: 0x1D9D1D0 Offset: 0x1D9D2D1 VA: 0x1D9D1D0 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1D9D1E0 Offset: 0x1D9D2E1 VA: 0x1D9D1E0
	private void LateUpdate() { }

	// RVA: 0x1D9D3A0 Offset: 0x1D9D4A1 VA: 0x1D9D3A0
	public void .ctor() { }
}

