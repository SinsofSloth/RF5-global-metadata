public interface InteractionInterface : FocusInterface // TypeDefIndex: 7635
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DoInteraction(HumanController character) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanInteraction(HumanController character) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DoInteraction(MonsterControllerBase character) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool CanInteraction(MonsterControllerBase character) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetInteractionButtonHint() { }
}

