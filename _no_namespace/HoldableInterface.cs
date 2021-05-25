public interface HoldableInterface : InteractionInterface, FocusInterface // TypeDefIndex: 7664
{
	// Properties
	public abstract ThrowController ThrowController { get; }
	public abstract HoldMotionType HoldMotionType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnHold() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPutOn() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ThrowController get_ThrowController() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool CanThrow() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnThrow() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool HitCheck(HitResult result, ThrowController throwController) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnPutOnByThrow() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract HoldMotionType get_HoldMotionType() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool CanPuton() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool CanRuckIn() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool OnTakeDamage(DamageResult result) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void SetAlpha(float alpha) { }
}

