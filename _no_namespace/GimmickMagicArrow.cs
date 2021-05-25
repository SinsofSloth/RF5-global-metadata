public class GimmickMagicArrow : GimmickBase // TypeDefIndex: 7579
{
	// Fields
	private const int loaderId = 16332;
	[SerializeField] // RVA: 0x1678B0 Offset: 0x1679B1 VA: 0x1678B0
	protected float Interval; // 0x20
	[SerializeField] // RVA: 0x1678C0 Offset: 0x1679C1 VA: 0x1678C0
	protected float ArrowDamage; // 0x24
	[SerializeField] // RVA: 0x1678D0 Offset: 0x1679D1 VA: 0x1678D0
	private float AttackKnockbackPower; // 0x28
	[SerializeField] // RVA: 0x1678E0 Offset: 0x1679E1 VA: 0x1678E0
	protected float ArrowSpeed; // 0x2C
	[SerializeField] // RVA: 0x1678F0 Offset: 0x1679F1 VA: 0x1678F0
	protected GimmickMagicArrow.MagicCircleType Type; // 0x30
	[SerializeField] // RVA: 0x167900 Offset: 0x167A01 VA: 0x167900
	private float ColliderStartTime; // 0x34
	[SerializeField] // RVA: 0x167910 Offset: 0x167A11 VA: 0x167910
	private float FadeOutTime; // 0x38
	[SerializeField] // RVA: 0x167920 Offset: 0x167A21 VA: 0x167920
	private float ShotEffectStopTime; // 0x3C
	protected Transform MagicCircle; // 0x40
	protected SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher; // 0x48
	protected bool stayRoom; // 0x50
	protected bool stopFlg; // 0x51
	protected float CurrentTime; // 0x54
	private int arrow_id; // 0x58
	private GameObject LoadPrefab; // 0x60

	// Methods

	// RVA: 0x1EA2A60 Offset: 0x1EA2B61 VA: 0x1EA2A60 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x1EA2B30 Offset: 0x1EA2C31 VA: 0x1EA2B30 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EA2D40 Offset: 0x1EA2E41 VA: 0x1EA2D40
	private void Update() { }

	// RVA: 0x1EA2DA0 Offset: 0x1EA2EA1 VA: 0x1EA2DA0
	private void SpawnArrow() { }

	// RVA: 0x1EA2EA0 Offset: 0x1EA2FA1 VA: 0x1EA2EA0
	private void SpawnGimmickObject(GameObject baseObj) { }

	// RVA: 0x1EA3110 Offset: 0x1EA3211 VA: 0x1EA3110 Slot: 11
	protected virtual void OnEnterEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA3220 Offset: 0x1EA3321 VA: 0x1EA3220 Slot: 12
	protected virtual void OnStayEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA3230 Offset: 0x1EA3331 VA: 0x1EA3230
	private void OnExitEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA3340 Offset: 0x1EA3441 VA: 0x1EA3340
	protected void OnChangeSwitchState(bool newState, bool immediate) { }

	// RVA: 0x1EA3350 Offset: 0x1EA3451 VA: 0x1EA3350
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1CC0 Offset: 0x1A1DC1 VA: 0x1A1CC0
	// RVA: 0x1EA3380 Offset: 0x1EA3481 VA: 0x1EA3380
	private void <SpawnArrow>b__20_0(AssetHandle<GameObject> handle) { }
}

