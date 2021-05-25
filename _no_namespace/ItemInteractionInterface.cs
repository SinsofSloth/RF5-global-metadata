public interface ItemInteractionInterface : FocusInterface // TypeDefIndex: 7636
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }
}

