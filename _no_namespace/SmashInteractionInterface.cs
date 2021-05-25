public interface SmashInteractionInterface : ToolInteractionInterface, FocusInterface // TypeDefIndex: 7641
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DoSmash(HumanController humanController) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanSmash(HumanController humanController) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DoBreak(HumanController humanController) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool CanBreak(HumanController humanController) { }
}

