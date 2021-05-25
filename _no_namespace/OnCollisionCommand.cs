public class OnCollisionCommand : MonsterProjectileActionCommandBase // TypeDefIndex: 6247
{
	// Properties
	public override float Duration { get; }
	public bool IsEndHit { get; }
	public bool IsEndHitOther { get; }
	public EffectID EffectName { get; }

	// Methods

	// RVA: 0x1D8F120 Offset: 0x1D8F221 VA: 0x1D8F120 Slot: 4
	public override float get_Duration() { }

	// RVA: 0x1D8F140 Offset: 0x1D8F241 VA: 0x1D8F140
	public bool get_IsEndHit() { }

	// RVA: 0x1D8F160 Offset: 0x1D8F261 VA: 0x1D8F160
	public bool get_IsEndHitOther() { }

	// RVA: 0x1D8F180 Offset: 0x1D8F281 VA: 0x1D8F180
	public EffectID get_EffectName() { }

	// RVA: 0x1D8F220 Offset: 0x1D8F321 VA: 0x1D8F220
	public void .ctor(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller) { }

	// RVA: 0x1D8F280 Offset: 0x1D8F381 VA: 0x1D8F280 Slot: 8
	public override void DoAction() { }

	// RVA: 0x1D8F580 Offset: 0x1D8F681 VA: 0x1D8F580 Slot: 10
	public override void EndAction() { }

	// RVA: 0x1D8F590 Offset: 0x1D8F691 VA: 0x1D8F590 Slot: 11
	public override void ActionFinal() { }

	// RVA: 0x1D8F750 Offset: 0x1D8F851 VA: 0x1D8F750
	private void OnHitCollision(CharacterBase characterBase, MonsterProjectileActionScriptsController controller, int index) { }

	// RVA: 0x1D8F780 Offset: 0x1D8F881 VA: 0x1D8F780
	private void OnHitCollisionGround(MonsterProjectileActionScriptsController controller, int index) { }
}

