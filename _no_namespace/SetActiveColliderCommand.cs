public class SetActiveColliderCommand : MonsterActionCommandBase // TypeDefIndex: 6237
{
	// Fields
	private AttackCollider AttackCollider; // 0x88

	// Properties
	private EffectID EffectName { get; }
	public override float Duration { get; }

	// Methods

	// RVA: 0x1C88BD0 Offset: 0x1C88CD1 VA: 0x1C88BD0
	private EffectID get_EffectName() { }

	// RVA: 0x1C88C70 Offset: 0x1C88D71 VA: 0x1C88C70
	public void .ctor(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller) { }

	// RVA: 0x1C88CD0 Offset: 0x1C88DD1 VA: 0x1C88CD0 Slot: 4
	public override float get_Duration() { }

	// RVA: 0x1C88CF0 Offset: 0x1C88DF1 VA: 0x1C88CF0 Slot: 8
	public override void DoAction() { }

	// RVA: 0x1C88EA0 Offset: 0x1C88FA1 VA: 0x1C88EA0 Slot: 10
	public override void EndAction() { }

	// RVA: 0x1C88EB0 Offset: 0x1C88FB1 VA: 0x1C88EB0 Slot: 11
	public override void ActionFinal() { }

	// RVA: 0x1C88FD0 Offset: 0x1C890D1 VA: 0x1C88FD0
	private void StopCollision() { }
}

