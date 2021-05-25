public interface SowInteractionInterface : ToolInteractionInterface, FocusInterface // TypeDefIndex: 7642
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DoSow(HumanController human, SeedItemData itemData) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanSow(HumanController human, SeedItemData itemData) { }
}

