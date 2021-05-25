public class ObjectCullingGroup : MonoBehaviour // TypeDefIndex: 7437
{
	// Fields
	private CullingGroup CullingGroup; // 0x18
	private BoundingSphere[] Bounds; // 0x20
	[SerializeField] // RVA: 0x166730 Offset: 0x166831 VA: 0x166730
	private Transform[] Targets; // 0x28
	[SerializeField] // RVA: 0x166740 Offset: 0x166841 VA: 0x166740
	private float[] BoundingDistances; // 0x30
	[SerializeField] // RVA: 0x166750 Offset: 0x166851 VA: 0x166750
	private float BoundingRadius; // 0x38
	[SerializeField] // RVA: 0x166760 Offset: 0x166861 VA: 0x166760
	private bool UseIsVisible; // 0x3C

	// Methods

	// RVA: 0x1D8CDA0 Offset: 0x1D8CEA1 VA: 0x1D8CDA0
	private void Awake() { }

	// RVA: 0x1D8CE00 Offset: 0x1D8CF01 VA: 0x1D8CE00
	private void Start() { }

	// RVA: 0x1D8D030 Offset: 0x1D8D131 VA: 0x1D8D030
	private void OnDestroy() { }

	// RVA: 0x1D8D140 Offset: 0x1D8D241 VA: 0x1D8D140
	private void OnChange(CullingGroupEvent ev) { }

	// RVA: 0x1D8D250 Offset: 0x1D8D351 VA: 0x1D8D250
	public void .ctor() { }
}

