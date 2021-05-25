public class SetMoveSpeedParameterCommand : MonsterActionCommandBase // TypeDefIndex: 6238
{
	// Fields
	private bool DoneUpdateMove; // 0x88

	// Properties
	public override float Duration { get; }

	// Methods

	// RVA: 0x1C8BD20 Offset: 0x1C8BE21 VA: 0x1C8BD20
	public void .ctor(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller) { }

	// RVA: 0x1C8BD80 Offset: 0x1C8BE81 VA: 0x1C8BD80 Slot: 4
	public override float get_Duration() { }

	// RVA: 0x1C8BDA0 Offset: 0x1C8BEA1 VA: 0x1C8BDA0 Slot: 8
	public override void DoAction() { }

	// RVA: 0x1C8BDD0 Offset: 0x1C8BED1 VA: 0x1C8BDD0
	private void StartMove() { }

	// RVA: 0x1C8BED0 Offset: 0x1C8BFD1 VA: 0x1C8BED0
	private void UpdateMoveSpeed() { }

	// RVA: 0x1C8BF50 Offset: 0x1C8C051 VA: 0x1C8BF50 Slot: 9
	public override void UpdateAction(float elapsedTime) { }

	// RVA: 0x1C8BFC0 Offset: 0x1C8C0C1 VA: 0x1C8BFC0 Slot: 10
	public override void EndAction() { }

	// RVA: 0x1C8BFD0 Offset: 0x1C8C0D1 VA: 0x1C8BFD0 Slot: 11
	public override void ActionFinal() { }
}

