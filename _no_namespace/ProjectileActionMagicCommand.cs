public class ProjectileActionMagicCommand : ActionCommandBase // TypeDefIndex: 6189
{
	// Fields
	public Action OnHit; // 0x80
	public Action OnHitGround; // 0x88

	// Properties
	public BulletID UseBulletID { get; }
	public Vector3 ShootPosition { get; }
	public Vector2 ShootDirection { get; }
	public float MotionPower { get; }
	public bool IsTargetParent { get; }
	public bool IsLateral { get; }

	// Methods

	// RVA: 0x1DEA5D0 Offset: 0x1DEA6D1 VA: 0x1DEA5D0
	public BulletID get_UseBulletID() { }

	// RVA: 0x1DEA6F0 Offset: 0x1DEA7F1 VA: 0x1DEA6F0
	public Vector3 get_ShootPosition() { }

	// RVA: 0x1DEA710 Offset: 0x1DEA811 VA: 0x1DEA710
	public Vector2 get_ShootDirection() { }

	// RVA: 0x1DEA730 Offset: 0x1DEA831 VA: 0x1DEA730
	public float get_MotionPower() { }

	// RVA: 0x1DEA750 Offset: 0x1DEA851 VA: 0x1DEA750
	public bool get_IsTargetParent() { }

	// RVA: 0x1DEA770 Offset: 0x1DEA871 VA: 0x1DEA770
	public bool get_IsLateral() { }

	// RVA: 0x1DEA790 Offset: 0x1DEA891 VA: 0x1DEA790
	public void .ctor(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller) { }

	// RVA: 0x1DEA7F0 Offset: 0x1DEA8F1 VA: 0x1DEA7F0 Slot: 8
	public override void DoAction() { }
}

