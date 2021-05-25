public interface BrushInteractionInterface : ToolInteractionInterface, FocusInterface // TypeDefIndex: 7631
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool DoUseBrush(out float size) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanUseBrush(HumanController character) { }
}

