public class AS_BulletController : ActionScriptControllerBase // TypeDefIndex: 6155
{
	// Fields
	protected BulletBase m_bullet; // 0x140
	protected Character creater; // 0x148

	// Properties
	public override Character Character { get; }

	// Methods

	// RVA: 0x1E645F0 Offset: 0x1E646F1 VA: 0x1E645F0 Slot: 4
	public override Character get_Character() { }

	// RVA: 0x1E64680 Offset: 0x1E64781 VA: 0x1E64680
	public void DoAction(string actionCodeName, BulletBase bullet) { }

	// RVA: 0x1E64900 Offset: 0x1E64A01 VA: 0x1E64900 Slot: 16
	protected override void BulletShot(ProjectileActionMagicCommand onProjectileActionCommand, Collider targetCollider) { }

	// RVA: 0x1E64AB0 Offset: 0x1E64BB1 VA: 0x1E64AB0 Slot: 17
	protected override void CreateBullet(BulletID bulletID, Character chara, Vector3 offset, Quaternion rotation, bool isTargetParent, bool isLateral) { }

	// RVA: 0x1E64E70 Offset: 0x1E64F71 VA: 0x1E64E70
	public void .ctor() { }
}

