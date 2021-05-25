public interface FarmDrugInteractionInterface : ToolInteractionInterface, FocusInterface // TypeDefIndex: 7633
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DoSpray(HumanController human, ItemData itemData) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanSpray(HumanController human, ItemData itemData) { }
}

