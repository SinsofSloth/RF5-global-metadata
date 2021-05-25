public interface PotInteractionInterface : ToolInteractionInterface, FocusInterface // TypeDefIndex: 7638
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool UsePot(HumanController humanController, EquipItemData equipItemData) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanUsePot(HumanController humanController, EquipItemData equipItemData, bool isRange) { }
}

