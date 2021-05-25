public abstract class PickUp2Handed : MonoBehaviour // TypeDefIndex: 9371
{
	// Fields
	public int GUIspace; // 0x18
	public InteractionSystem interactionSystem; // 0x20
	public InteractionObject obj; // 0x28
	public Transform pivot; // 0x30
	public Transform holdPoint; // 0x38
	public float pickUpTime; // 0x40
	private float holdWeight; // 0x44
	private float holdWeightVel; // 0x48
	private Vector3 pickUpPosition; // 0x4C
	private Quaternion pickUpRotation; // 0x58

	// Properties
	private bool holding { get; }

	// Methods

	// RVA: 0x2727640 Offset: 0x2727741 VA: 0x2727640
	private void OnGUI() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void RotatePivot() { }

	// RVA: 0x2727940 Offset: 0x2727A41 VA: 0x2727940
	private void Start() { }

	// RVA: 0x2727AE0 Offset: 0x2727BE1 VA: 0x2727AE0
	private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x2727C60 Offset: 0x2727D61 VA: 0x2727C60
	private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x2727D40 Offset: 0x2727E41 VA: 0x2727D40
	private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x2727E70 Offset: 0x2727F71 VA: 0x2727E70
	private void LateUpdate() { }

	// RVA: 0x2727920 Offset: 0x2727A21 VA: 0x2727920
	private bool get_holding() { }

	// RVA: 0x2728090 Offset: 0x2728191 VA: 0x2728090
	private void OnDestroy() { }

	// RVA: 0x2728280 Offset: 0x2728381 VA: 0x2728280
	protected void .ctor() { }
}

