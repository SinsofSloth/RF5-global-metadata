public class GimmickHpRpDown : GimmickBase // TypeDefIndex: 7575
{
	// Fields
	[SerializeField] // RVA: 0x167820 Offset: 0x167921 VA: 0x167820
	private GimmickHpRpDown.DamageType damageType; // 0x20
	[SerializeField] // RVA: 0x167830 Offset: 0x167931 VA: 0x167830
	private float Interval; // 0x24
	[SerializeField] // RVA: 0x167840 Offset: 0x167941 VA: 0x167840
	[RangeAttribute] // RVA: 0x167840 Offset: 0x167941 VA: 0x167840
	private float DamagePercent; // 0x28
	protected SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher; // 0x30
	protected bool stayRoom; // 0x38
	private float CurrentTime; // 0x3C

	// Methods

	// RVA: 0x1EA19C0 Offset: 0x1EA1AC1 VA: 0x1EA19C0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EA1B60 Offset: 0x1EA1C61 VA: 0x1EA1B60
	private void Update() { }

	// RVA: 0x1EA1C40 Offset: 0x1EA1D41 VA: 0x1EA1C40
	private void DamageHp() { }

	// RVA: 0x1EA1ED0 Offset: 0x1EA1FD1 VA: 0x1EA1ED0
	private void DamageRp() { }

	// RVA: 0x1EA2060 Offset: 0x1EA2161 VA: 0x1EA2060
	private void OnStayEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA2170 Offset: 0x1EA2271 VA: 0x1EA2170
	private void OnExitEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA2280 Offset: 0x1EA2381 VA: 0x1EA2280
	protected void OnChangeSwitchState(bool newState, bool immediate) { }

	// RVA: 0x1EA2290 Offset: 0x1EA2391 VA: 0x1EA2290
	public void .ctor() { }
}

