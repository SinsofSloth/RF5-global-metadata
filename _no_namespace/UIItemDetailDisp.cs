public class UIItemDetailDisp : MonoBehaviour // TypeDefIndex: 8830
{
	// Fields
	[SerializeField] // RVA: 0x173E20 Offset: 0x173F21 VA: 0x173E20
	private Text NameText; // 0x18
	[SerializeField] // RVA: 0x173E30 Offset: 0x173F31 VA: 0x173E30
	private Text LevelText; // 0x20
	[SerializeField] // RVA: 0x173E40 Offset: 0x173F41 VA: 0x173E40
	private Text DiscriptText; // 0x28
	[SerializeField] // RVA: 0x173E50 Offset: 0x173F51 VA: 0x173E50
	private Text ItemBuyPriceText; // 0x30
	[SerializeField] // RVA: 0x173E60 Offset: 0x173F61 VA: 0x173E60
	private Text ItemSellPriceText; // 0x38
	[SerializeField] // RVA: 0x173E70 Offset: 0x173F71 VA: 0x173E70
	private UIOnOffAnimate UIOnOffAnimate; // 0x40
	[SerializeField] // RVA: 0x173E80 Offset: 0x173F81 VA: 0x173E80
	private bool ClearOnNullData; // 0x48

	// Methods

	// RVA: 0x1F17C90 Offset: 0x1F17D91 VA: 0x1F17C90
	public void SetItemDetailQuick(ItemID itemId) { }

	// RVA: 0x1F184C0 Offset: 0x1F185C1 VA: 0x1F184C0
	public void SetItemDetailFull(ItemID itemId) { }

	// RVA: 0x1F17CD0 Offset: 0x1F17DD1 VA: 0x1F17CD0
	public void SetItemDetailQuick(ItemData itemData) { }

	// RVA: 0x1F18500 Offset: 0x1F18601 VA: 0x1F18500
	public void SetItemDetailFull(ItemData itemData) { }

	// RVA: 0x1F18CE0 Offset: 0x1F18DE1 VA: 0x1F18CE0
	public void ClearText() { }

	// RVA: 0x1F18F30 Offset: 0x1F19031 VA: 0x1F18F30
	public void .ctor() { }
}

