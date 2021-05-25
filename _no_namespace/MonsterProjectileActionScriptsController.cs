public class MonsterProjectileActionScriptsController : MonsterActionScriptsControllerBase // TypeDefIndex: 6254
{
	// Fields
	public Character Causer; // 0x180
	public Collider TargetCollider; // 0x188
	public ProjectileBulletBase ProjectileBulletBase; // 0x190
	public UnityEventCollider OnHitProjectileEvent; // 0x198
	public UnityEventCollider OnHitGroundProjectileEvent; // 0x1A0

	// Properties
	public override Character Character { get; }

	// Methods

	// RVA: 0x1CD3960 Offset: 0x1CD3A61 VA: 0x1CD3960 Slot: 4
	public override Character get_Character() { }

	// RVA: 0x1CD3970 Offset: 0x1CD3A71 VA: 0x1CD3970 Slot: 9
	protected override void OnDestroy() { }

	// RVA: 0x1CD39F0 Offset: 0x1CD3AF1 VA: 0x1CD39F0 Slot: 24
	public override void SetActionCodeDataTableArray(MonsterActionCodeDataTableArray array) { }

	// RVA: 0x1CD3A30 Offset: 0x1CD3B31 VA: 0x1CD3A30 Slot: 27
	public virtual void SetupActionCode(string actionCodeName, Vector2 directionBlurAngle) { }

	// RVA: 0x1CD3B60 Offset: 0x1CD3C61 VA: 0x1CD3B60
	public void SetupProjectile(Vector2 directionBlurAngle) { }

	// RVA: 0x1CD3D80 Offset: 0x1CD3E81 VA: 0x1CD3D80 Slot: 12
	public override void DoAction(ActionCode actionCode) { }

	// RVA: 0x1CD3D90 Offset: 0x1CD3E91 VA: 0x1CD3D90 Slot: 13
	public override void StopAction() { }

	// RVA: 0x1CD3E20 Offset: 0x1CD3F21 VA: 0x1CD3E20 Slot: 10
	protected override ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable) { }

	// RVA: 0x1CD3F40 Offset: 0x1CD4041 VA: 0x1CD3F40
	public void OnHit(CharacterBase characterBase, int actionIndex) { }

	// RVA: 0x1CD3FE0 Offset: 0x1CD40E1 VA: 0x1CD3FE0
	public void OnHitGround(Collider collider) { }

	// RVA: 0x1CD4070 Offset: 0x1CD4171 VA: 0x1CD4070
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A8B0 Offset: 0x19A9B1 VA: 0x19A8B0
	// RVA: 0x1CD4110 Offset: 0x1CD4211 VA: 0x1CD4110
	private void <SetupProjectile>b__10_0() { }
}

