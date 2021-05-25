public class RecipeMaterialSlot : ButtonLinker // TypeDefIndex: 8712
{
	// Fields
	[SerializeField] // RVA: 0x172A30 Offset: 0x172B31 VA: 0x172A30
	private Image Image; // 0x60
	[SerializeField] // RVA: 0x172A40 Offset: 0x172B41 VA: 0x172A40
	private Image XImg; // 0x68
	[SerializeField] // RVA: 0x172A50 Offset: 0x172B51 VA: 0x172A50
	private Image XImg2; // 0x70
	private bool haveItem; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x172A60 Offset: 0x172B61 VA: 0x172A60
	private ItemID <ItemID>k__BackingField; // 0x7C

	// Properties
	public ItemID ItemID { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A81A0 Offset: 0x1A82A1 VA: 0x1A81A0
	// RVA: 0x1DAF7B0 Offset: 0x1DAF8B1 VA: 0x1DAF7B0
	public ItemID get_ItemID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A81B0 Offset: 0x1A82B1 VA: 0x1A81B0
	// RVA: 0x1DAF7C0 Offset: 0x1DAF8C1 VA: 0x1DAF7C0
	private void set_ItemID(ItemID value) { }

	// RVA: 0x1DAF7D0 Offset: 0x1DAF8D1 VA: 0x1DAF7D0
	private void CheckImageNull() { }

	// RVA: 0x1DAF8D0 Offset: 0x1DAF9D1 VA: 0x1DAF8D0
	private void SetItemSprite() { }

	// RVA: 0x1DAF1B0 Offset: 0x1DAF2B1 VA: 0x1DAF1B0
	public void UpdateMaterial(ItemID _item, bool _have_item) { }

	// RVA: 0x1DAFA80 Offset: 0x1DAFB81 VA: 0x1DAFA80
	public void .ctor() { }
}

