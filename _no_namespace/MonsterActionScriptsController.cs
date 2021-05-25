public class MonsterActionScriptsController : MonsterActionScriptsControllerBase // TypeDefIndex: 6240
{
	// Fields
	[SerializeField] // RVA: 0x15BE60 Offset: 0x15BF61 VA: 0x15BE60
	public List<AttackCollider> AttackColliderList; // 0x180
	public UnityEventMonsterActionHit OnHitEvent; // 0x188
	public EffectID m_HitEffectName; // 0x190

	// Methods

	// RVA: 0x1CC6620 Offset: 0x1CC6721 VA: 0x1CC6620 Slot: 8
	protected override void Awake() { }

	// RVA: 0x1CC6720 Offset: 0x1CC6821 VA: 0x1CC6720
	public void SetupCollider() { }

	// RVA: 0x1CC68F0 Offset: 0x1CC69F1 VA: 0x1CC68F0 Slot: 25
	public override void SharedProjectileControllerParameter(MonsterProjectileActionScriptsController controller) { }

	// RVA: 0x1CC6A80 Offset: 0x1CC6B81 VA: 0x1CC6A80 Slot: 10
	protected override ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable) { }

	// RVA: 0x1CC6BA0 Offset: 0x1CC6CA1 VA: 0x1CC6BA0
	public void NextInitial(string NextActionCodeName) { }

	// RVA: 0x1CC6C30 Offset: 0x1CC6D31 VA: 0x1CC6C30
	public void Next() { }

	// RVA: 0x1CC6CB0 Offset: 0x1CC6DB1 VA: 0x1CC6CB0 Slot: 27
	public virtual void StartAction(string actionCodeName, int actionIndex = -1) { }

	// RVA: 0x1CC6D50 Offset: 0x1CC6E51 VA: 0x1CC6D50 Slot: 28
	public virtual void OnHitAttack(CharacterBase characterBase, Collider attackCollider, Vector3 hitPosition) { }

	// RVA: 0x1CC77C0 Offset: 0x1CC78C1 VA: 0x1CC77C0
	private void OnHit(CharacterBase characterBase, int actionIndex) { }

	// RVA: 0x1CC7830 Offset: 0x1CC7931 VA: 0x1CC7830
	private void OnHitProjctile(CharacterBase characterBase, MonsterProjectileActionScriptsController controller, int index) { }

	// RVA: 0x1CC78A0 Offset: 0x1CC79A1 VA: 0x1CC78A0
	public void OnAttackCollision(string colliderName, out AttackCollider attackCollider) { }

	// RVA: 0x1CC79F0 Offset: 0x1CC7AF1 VA: 0x1CC79F0
	public void .ctor() { }
}

