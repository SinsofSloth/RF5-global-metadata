public class NPCMoveAttackRangeCommand : NPCActionBehaviorCommandBase // TypeDefIndex: 6119
{
	// Fields
	private SharedFloat MinAttackRange; // 0x28
	private SharedFloat MaxAttackRange; // 0x30
	private SharedFloat SphereCastHeight; // 0x38
	private SharedFloat SphereCastInterval; // 0x40
	public SharedFloat MoveSpeedScale; // 0x48

	// Methods

	// RVA: 0x1FB1630 Offset: 0x1FB1731 VA: 0x1FB1630
	public void .ctor(NPCActionBehaviorController controller, ActionBehaviorCommandInformation info) { }

	// RVA: 0x1FB4F10 Offset: 0x1FB5011 VA: 0x1FB4F10 Slot: 4
	public override void OnSetupParameter() { }

	// RVA: 0x1FB51A0 Offset: 0x1FB52A1 VA: 0x1FB51A0 Slot: 5
	public override void OnExecute() { }
}

