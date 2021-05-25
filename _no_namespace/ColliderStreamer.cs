public class ColliderStreamer : MonoBehaviour // TypeDefIndex: 9073
{
	// Fields
	[TooltipAttribute] // RVA: 0x176550 Offset: 0x176651 VA: 0x176550
	public string sceneName; // 0x18
	[TooltipAttribute] // RVA: 0x176590 Offset: 0x176691 VA: 0x176590
	public string scenePath; // 0x20
	[HideInInspector] // RVA: 0x1765D0 Offset: 0x1766D1 VA: 0x1765D0
	public GameObject sceneGameObject; // 0x28
	[HideInInspector] // RVA: 0x1765E0 Offset: 0x1766E1 VA: 0x1765E0
	public ColliderStreamerManager colliderStreamerManager; // 0x30
	[TooltipAttribute] // RVA: 0x1765F0 Offset: 0x1766F1 VA: 0x1765F0
	public bool playerOnlyActivate; // 0x38
	[TooltipAttribute] // RVA: 0x176630 Offset: 0x176731 VA: 0x176630
	public float unloadTimer; // 0x3C
	private bool loaded; // 0x40

	// Methods

	// RVA: 0x1E629B0 Offset: 0x1E62AB1 VA: 0x1E629B0
	private void Start() { }

	// RVA: 0x1E62B20 Offset: 0x1E62C21 VA: 0x1E62B20
	public void SetSceneGameObject(GameObject sceneGameObject) { }

	// RVA: 0x1E62B90 Offset: 0x1E62C91 VA: 0x1E62B90
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x1E62C90 Offset: 0x1E62D91 VA: 0x1E62C90
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x1E62DB0 Offset: 0x1E62EB1 VA: 0x1E62DB0
	private void UnloadScene() { }

	// RVA: 0x1E62E20 Offset: 0x1E62F21 VA: 0x1E62E20
	public void .ctor() { }
}

