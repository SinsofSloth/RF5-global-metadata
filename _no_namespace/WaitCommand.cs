public class WaitCommand : ActionBehaviorCommandBase // TypeDefIndex: 6129
{
	// Fields
	public SharedMovementBehaviorType SharedMovementBehaviorType; // 0x20
	public SharedFloat MaxWaitInterval; // 0x28
	public SharedFloat MinWaitInterval; // 0x30
	public SharedBool IsReleseEyes; // 0x38
	public float TimeRate; // 0x40

	// Methods

	// RVA: 0x1D024D0 Offset: 0x1D025D1 VA: 0x1D024D0
	public void .ctor(ActionBehaviorController controller, ActionBehaviorCommandInformation info, float timeRate = 1) { }

	// RVA: 0x1D02510 Offset: 0x1D02611 VA: 0x1D02510 Slot: 4
	public override void OnSetupParameter() { }

	// RVA: 0x1D02740 Offset: 0x1D02841 VA: 0x1D02740 Slot: 5
	public override void OnExecute() { }
}

