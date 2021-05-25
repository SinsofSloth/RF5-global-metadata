public class UIShipmentItemButton : UIButtonLinkerInScrollBox // TypeDefIndex: 8818
{
	// Fields
	[SerializeField] // RVA: 0x173BC0 Offset: 0x173CC1 VA: 0x173BC0
	private Text ItemName; // 0x70
	[SerializeField] // RVA: 0x173BD0 Offset: 0x173CD1 VA: 0x173BD0
	private Text Score; // 0x78
	[SerializeField] // RVA: 0x173BE0 Offset: 0x173CE1 VA: 0x173BE0
	private Image Crown; // 0x80
	[SerializeField] // RVA: 0x173BF0 Offset: 0x173CF1 VA: 0x173BF0
	private ItemIconLoader ItemIcon; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x173C00 Offset: 0x173D01 VA: 0x173C00
	private ItemID <ItemID>k__BackingField; // 0x90

	// Properties
	public ItemID ItemID { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A8830 Offset: 0x1A8931 VA: 0x1A8830
	// RVA: 0x1DDAB40 Offset: 0x1DDAC41 VA: 0x1DDAB40
	public ItemID get_ItemID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8840 Offset: 0x1A8941 VA: 0x1A8840
	// RVA: 0x1DDAB50 Offset: 0x1DDAC51 VA: 0x1DDAB50
	private void set_ItemID(ItemID value) { }

	// RVA: 0x1DDAB60 Offset: 0x1DDAC61 VA: 0x1DDAB60 Slot: 16
	public override void Init() { }

	// RVA: 0x1DDAB70 Offset: 0x1DDAC71 VA: 0x1DDAB70
	public void SetItem(ShipmentItemRecords shipmentItemRecords, Sprite crownSprite) { }

	// RVA: 0x1DDADA0 Offset: 0x1DDAEA1 VA: 0x1DDADA0
	public void SetItem(ShipmentItemRecords shipmentItemRecords, FishShipmentRecords fishShipmentRecords, Sprite crownSprite) { }

	// RVA: 0x1DDB020 Offset: 0x1DDB121 VA: 0x1DDB020 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1DDB030 Offset: 0x1DDB131 VA: 0x1DDB030 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1DDB040 Offset: 0x1DDB141 VA: 0x1DDB040
	public void .ctor() { }
}

