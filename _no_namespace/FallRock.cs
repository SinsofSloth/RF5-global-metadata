public class FallRock : MonoBehaviour // TypeDefIndex: 7551
{
	// Fields
	public float DamagePercent; // 0x18
	public float FallAccelSpeed; // 0x1C
	public float FallMaxSpeed; // 0x20
	[SerializeField] // RVA: 0x167140 Offset: 0x167241 VA: 0x167140
	private float DelayTime; // 0x24
	private float CurrentSpeed; // 0x28
	private Rigidbody[] Rigidbodys; // 0x30
	private MeshCollider[] MeshColliders; // 0x38
	private bool IsBreak; // 0x40
	public SoundID BreakSe; // 0x44

	// Methods

	// RVA: 0x20866B0 Offset: 0x20867B1 VA: 0x20866B0
	private void Awake() { }

	// RVA: 0x2086740 Offset: 0x2086841 VA: 0x2086740
	private void Start() { }

	// RVA: 0x2086750 Offset: 0x2086851 VA: 0x2086750
	private void FixedUpdate() { }

	// RVA: 0x20868B0 Offset: 0x20869B1 VA: 0x20868B0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x2086C30 Offset: 0x2086D31 VA: 0x2086C30
	private void Break() { }

	// RVA: 0x2086F40 Offset: 0x2087041 VA: 0x2086F40
	public void .ctor() { }
}

