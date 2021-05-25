[Serializable]
public class TouchWalls.EffectorLink // TypeDefIndex: 9381
{
	// Fields
	public bool enabled; // 0x10
	public FullBodyBipedEffector effectorType; // 0x14
	public InteractionObject interactionObject; // 0x18
	public Transform spherecastFrom; // 0x20
	public float spherecastRadius; // 0x28
	public float minDistance; // 0x2C
	public LayerMask touchLayers; // 0x30
	public float lerpSpeed; // 0x34
	public float minSwitchTime; // 0x38
	public float releaseDistance; // 0x3C
	public bool sliding; // 0x40
	private Vector3 raycastDirectionLocal; // 0x44
	private float raycastDistance; // 0x50
	private bool inTouch; // 0x54
	private RaycastHit hit; // 0x58
	private Vector3 targetPosition; // 0x84
	private Quaternion targetRotation; // 0x90
	private bool initiated; // 0xA0
	private float nextSwitchTime; // 0xA4
	private float speedF; // 0xA8

	// Methods

	// RVA: 0x272B7D0 Offset: 0x272B8D1 VA: 0x272B7D0
	public void Initiate(InteractionSystem interactionSystem) { }

	// RVA: 0x272C510 Offset: 0x272C611 VA: 0x272C510
	private bool FindWalls(Vector3 direction) { }

	// RVA: 0x272BB50 Offset: 0x272BC51 VA: 0x272BB50
	public void Update(InteractionSystem interactionSystem) { }

	// RVA: 0x272C600 Offset: 0x272C701 VA: 0x272C600
	private void StopTouch(InteractionSystem interactionSystem) { }

	// RVA: 0x272C7A0 Offset: 0x272C8A1 VA: 0x272C7A0
	private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x272C840 Offset: 0x272C941 VA: 0x272C840
	private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x272C8E0 Offset: 0x272C9E1 VA: 0x272C8E0
	private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x272C350 Offset: 0x272C451 VA: 0x272C350
	public void Destroy(InteractionSystem interactionSystem) { }

	// RVA: 0x272C980 Offset: 0x272CA81 VA: 0x272C980
	public void .ctor() { }
}

