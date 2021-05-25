public class TerrainCullingSystem : MonoBehaviour // TypeDefIndex: 9090
{
	// Fields
	[TooltipAttribute] // RVA: 0x176EB0 Offset: 0x176FB1 VA: 0x176EB0
	public float renderingDistance; // 0x18
	private float sphereSize; // 0x1C
	private Terrain terrain; // 0x20
	private CullingGroup group; // 0x28
	private BoundingSphere[] spheres; // 0x30
	private Vector3 offsetVector; // 0x38
	private Vector3 offsetVectorUp; // 0x44
	private Camera mainCamera; // 0x50
	private int heightSphereNumber; // 0x58
	[HideInInspector] // RVA: 0x176EF0 Offset: 0x176FF1 VA: 0x176EF0
	public bool disableTrees; // 0x5C

	// Methods

	// RVA: 0x20A6AF0 Offset: 0x20A6BF1 VA: 0x20A6AF0
	private void Start() { }

	// RVA: 0x20A7260 Offset: 0x20A7361 VA: 0x20A7260
	private void OnDrawGizmosSelected() { }

	// RVA: 0x20A73B0 Offset: 0x20A74B1 VA: 0x20A73B0
	private void CheckVisibility() { }

	// RVA: 0x20A7440 Offset: 0x20A7541 VA: 0x20A7440
	private void StateChangedMethod(CullingGroupEvent evt) { }

	// RVA: 0x20A7520 Offset: 0x20A7621 VA: 0x20A7520
	private void SetTerrainVisible(bool visible) { }

	// RVA: 0x20A7580 Offset: 0x20A7681 VA: 0x20A7580
	private void OnDestroy() { }

	// RVA: 0x20A7130 Offset: 0x20A7231 VA: 0x20A7130
	private void OnChangeActiveCamara(Camera camera) { }

	// RVA: 0x20A76A0 Offset: 0x20A77A1 VA: 0x20A76A0
	public void .ctor() { }
}

