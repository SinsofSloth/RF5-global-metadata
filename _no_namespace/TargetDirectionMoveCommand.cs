public class TargetDirectionMoveCommand : ActionBehaviorCommandBase // TypeDefIndex: 6128
{
	// Fields
	public SharedGameObject Target; // 0x20
	public SharedVector3 MovePosition; // 0x28
	public SharedFloat MoveSpeedScale; // 0x30
	public SharedMovementBehaviorType SharedMovementBehaviorType; // 0x38

	// Methods

	// RVA: 0x1C77990 Offset: 0x1C77A91 VA: 0x1C77990
	public void .ctor(ActionBehaviorController controller, ActionBehaviorCommandInformation info) { }

	// RVA: 0x1C779A0 Offset: 0x1C77AA1 VA: 0x1C779A0 Slot: 4
	public override void OnSetupParameter() { }

	// RVA: 0x1C77BE0 Offset: 0x1C77CE1 VA: 0x1C77BE0 Slot: 5
	public override void OnExecute() { }
}

