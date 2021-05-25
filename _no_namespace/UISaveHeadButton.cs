public class UISaveHeadButton : ButtonLinker // TypeDefIndex: 8724
{
	// Fields
	[SerializeField] // RVA: 0x172DD0 Offset: 0x172ED1 VA: 0x172DD0
	private Image OnSelectImage; // 0x60
	[SerializeField] // RVA: 0x172DE0 Offset: 0x172EE1 VA: 0x172DE0
	private Image OffSelectImage; // 0x68
	[SerializeField] // RVA: 0x172DF0 Offset: 0x172EF1 VA: 0x172DF0
	private Sprite[] OnSelectBorderSprite; // 0x70
	[SerializeField] // RVA: 0x172E00 Offset: 0x172F01 VA: 0x172E00
	private Sprite[] OffSelectBorderSprite; // 0x78
	[SerializeField] // RVA: 0x172E10 Offset: 0x172F11 VA: 0x172E10
	private SText onText; // 0x80
	[SerializeField] // RVA: 0x172E20 Offset: 0x172F21 VA: 0x172E20
	private SText offText; // 0x88
	[SerializeField] // RVA: 0x172E30 Offset: 0x172F31 VA: 0x172E30
	private Color[] onTextColor; // 0x90
	[SerializeField] // RVA: 0x172E40 Offset: 0x172F41 VA: 0x172E40
	private Color[] offTextColor; // 0x98
	[SerializeField] // RVA: 0x172E50 Offset: 0x172F51 VA: 0x172E50
	private GameObject NoSaveActiveOnFocusObj; // 0xA0
	[SerializeField] // RVA: 0x172E60 Offset: 0x172F61 VA: 0x172E60
	private GameObject NoSaveUnActiveOnFocusObj; // 0xA8

	// Methods

	// RVA: 0x1DD5620 Offset: 0x1DD5721 VA: 0x1DD5620
	private void PageSwitch(bool openSaveBlock) { }

	// RVA: 0x1DD5670 Offset: 0x1DD5771 VA: 0x1DD5670
	private void OnEnable() { }

	// RVA: 0x1DD57D0 Offset: 0x1DD58D1 VA: 0x1DD57D0 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1DD5880 Offset: 0x1DD5981 VA: 0x1DD5880 Slot: 8
	public override void OnNextFocus(CursorLinker nextObject) { }

	// RVA: 0x1DD5950 Offset: 0x1DD5A51 VA: 0x1DD5950
	public void .ctor() { }
}

