public class BeanController : MonoBehaviour, IPooledObejct // TypeDefIndex: 7340
{
	// Fields
	private const string OUTER_WALL = "OuterWallCube";
	private const string PLAYER_TAG = "Player";
	private const float ROTATE_SPEED = 360;
	private const float FADE_SPEED = 0.5;
	private bool firstBoot; // 0x18
	private bool isCollided; // 0x19
	private Vector3 direction; // 0x1C
	private Rigidbody rb; // 0x28
	private BoxCollider boxCollider; // 0x30
	private Material material; // 0x38
	private float timeCount; // 0x40
	private float alpha; // 0x44

	// Methods

	// RVA: 0x20D5B40 Offset: 0x20D5C41 VA: 0x20D5B40 Slot: 4
	public void OnObjectSpawn() { }

	// RVA: 0x20D5C70 Offset: 0x20D5D71 VA: 0x20D5C70
	private void Update() { }

	// RVA: 0x20D5CF0 Offset: 0x20D5DF1 VA: 0x20D5CF0
	private void UpdateBean() { }

	// RVA: 0x20D5FD0 Offset: 0x20D60D1 VA: 0x20D5FD0
	public void SetDirection(Vector3 _direction) { }

	// RVA: 0x20D5FE0 Offset: 0x20D60E1 VA: 0x20D5FE0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x20D5EB0 Offset: 0x20D5FB1 VA: 0x20D5EB0
	private void UpdateCollided() { }

	// RVA: 0x20D61A0 Offset: 0x20D62A1 VA: 0x20D61A0
	public void .ctor() { }
}

