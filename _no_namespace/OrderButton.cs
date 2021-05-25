public class OrderButton : UIButtonLinkerInScrollBox // TypeDefIndex: 8744
{
	// Fields
	[SerializeField] // RVA: 0x1730F0 Offset: 0x1731F1 VA: 0x1730F0
	private Text NameText; // 0x70
	[SerializeField] // RVA: 0x173100 Offset: 0x173201 VA: 0x173100
	private Image IconImage; // 0x78
	[SerializeField] // RVA: 0x173110 Offset: 0x173211 VA: 0x173110
	private Image BorderImage; // 0x80
	[SerializeField] // RVA: 0x173120 Offset: 0x173221 VA: 0x173120
	private Sprite OnSprite; // 0x88
	[SerializeField] // RVA: 0x173130 Offset: 0x173231 VA: 0x173130
	private Sprite NoSprite; // 0x90
	[SerializeField] // RVA: 0x173140 Offset: 0x173241 VA: 0x173140
	private Color OnSelectColor; // 0x98
	[SerializeField] // RVA: 0x173150 Offset: 0x173251 VA: 0x173150
	private Color NoSelectColor; // 0xA8

	// Methods

	// RVA: 0x1F1D520 Offset: 0x1F1D621 VA: 0x1F1D520 Slot: 16
	public override void Init() { }

	// RVA: 0x1F1D530 Offset: 0x1F1D631 VA: 0x1F1D530 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1F1D590 Offset: 0x1F1D691 VA: 0x1F1D590 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1F1D5F0 Offset: 0x1F1D6F1 VA: 0x1F1D5F0
	public void Setup(UIOrderBoardMenu.OrderList orderList, Sprite iconSprite) { }

	// RVA: 0x1F1D840 Offset: 0x1F1D941 VA: 0x1F1D840
	public void .ctor() { }
}

