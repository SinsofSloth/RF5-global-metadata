public abstract class StorageFurniture : PlayerItemFurniture2, ItemInteractionInterface, FocusInterface // TypeDefIndex: 10280
{
	// Fields
	[SerializeField] // RVA: 0x180DB0 Offset: 0x180EB1 VA: 0x180DB0
	private GameObject m_model; // 0x70
	[SerializeField] // RVA: 0x180DC0 Offset: 0x180EC1 VA: 0x180DC0
	private InteractionType m_InteractionType; // 0x78

	// Methods

	// RVA: -1 Offset: -1 Slot: 36
	public abstract bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1F3D410 Offset: 0x1F3D511 VA: 0x1F3D410 Slot: 35
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }

	// RVA: 0x1F3B620 Offset: 0x1F3B721 VA: 0x1F3B620 Slot: 37
	public virtual void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1F37FF0 Offset: 0x1F380F1 VA: 0x1F37FF0
	public void Shake() { }

	// RVA: 0x1F36770 Offset: 0x1F36871 VA: 0x1F36770
	public void StorageAction(bool is_storage) { }

	// RVA: 0x1F3D420 Offset: 0x1F3D521 VA: 0x1F3D420 Slot: 32
	public override ushort GetInteractionType() { }

	// RVA: 0x1F3B640 Offset: 0x1F3B741 VA: 0x1F3B640
	protected void .ctor() { }

	// RVA: 0x1F3D520 Offset: 0x1F3D621 VA: 0x1F3D520 Slot: 30
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1F3D530 Offset: 0x1F3D631 VA: 0x1F3D530 Slot: 31
	private Transform FocusInterface.get_transform() { }
}

