[TaskCategoryAttribute] // RVA: 0x145810 Offset: 0x145911 VA: 0x145810
public class EndChangeAnimatorState : Action // TypeDefIndex: 6401
{
	// Fields
	public SharedInt StateLayerIndex; // 0x50
	public SharedString AnimationStateName; // 0x58
	public SharedFloat ClossFadeTime; // 0x60
	private AIInput AIInput; // 0x68

	// Methods

	// RVA: 0x201C0D0 Offset: 0x201C1D1 VA: 0x201C0D0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x201C1A0 Offset: 0x201C2A1 VA: 0x201C1A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x201C1B0 Offset: 0x201C2B1 VA: 0x201C1B0 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x201C300 Offset: 0x201C401 VA: 0x201C300
	public void .ctor() { }
}

