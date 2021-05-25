public interface ScissorsInteractionInterface : ToolInteractionInterface, FocusInterface // TypeDefIndex: 7639
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool DoUseScissors(out float size) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanUseScissors(HumanController character) { }
}

