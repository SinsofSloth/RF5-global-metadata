public class MaterialChangeTimeManager : SingletonMonoBehaviour<MaterialChangeTimeManager> // TypeDefIndex: 10455
{
	// Fields
	private const int MaterialChangeFrameCount = 3;
	public Dictionary<TimeParamTable, HashSet<Material>> TimeParamMaterialDict; // 0x18
	public Dictionary<TimeParamTable, HashSet<MaterialChangeTime>> TimeParamMaterialChangeDict; // 0x20
	public Dictionary<TimeParamTable, HashSet<ObjectChangeTime>> TimeParamObjectChangeDict; // 0x28
	public Dictionary<TimeParamTable, HashSet<RendererChangeTime>> TimeParamRendererChangeDict; // 0x30
	private Light _Light; // 0x38
	private Coroutine UpdateCoroutine; // 0x40

	// Properties
	public Light Light { get; set; }

	// Methods

	// RVA: 0x1EE9CC0 Offset: 0x1EE9DC1 VA: 0x1EE9CC0
	public Light get_Light() { }

	// RVA: 0x1EE9CD0 Offset: 0x1EE9DD1 VA: 0x1EE9CD0
	public void set_Light(Light value) { }

	// RVA: 0x1EE97B0 Offset: 0x1EE98B1 VA: 0x1EE97B0
	public void AddMaterialChangeTime(TimeParamTable timeParamTable, MaterialChangeTime materialChangeTime) { }

	// RVA: 0x1EE9620 Offset: 0x1EE9721 VA: 0x1EE9620
	public void RemoveMaterialChangeTime(TimeParamTable timeParamTable, MaterialChangeTime materialChangeTime) { }

	// RVA: 0x1EE9DE0 Offset: 0x1EE9EE1 VA: 0x1EE9DE0
	public void AddObjectChangeTime(TimeParamTable timeParamTable, ObjectChangeTime objectChangeTime) { }

	// RVA: 0x1EE9ED0 Offset: 0x1EE9FD1 VA: 0x1EE9ED0
	public void RemoveObjectChangeTime(TimeParamTable timeParamTable, ObjectChangeTime objectChangeTime) { }

	// RVA: 0x1EE9FA0 Offset: 0x1EEA0A1 VA: 0x1EE9FA0
	public void AddRendererChangeTime(TimeParamTable timeParamTable, RendererChangeTime rendererChangeTime) { }

	// RVA: 0x1EEA090 Offset: 0x1EEA191 VA: 0x1EEA090
	public void RemoveRendererChangeTime(TimeParamTable timeParamTable, RendererChangeTime rendererChangeTime) { }

	// RVA: 0x1EEA160 Offset: 0x1EEA261 VA: 0x1EEA160
	private void Start() { }

	// RVA: 0x1EEA1D0 Offset: 0x1EEA2D1 VA: 0x1EEA1D0
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF430 Offset: 0x1AF531 VA: 0x1AF430
	// RVA: 0x1EEA290 Offset: 0x1EEA391 VA: 0x1EEA290
	private IEnumerator UpdateObjectCoroutine() { }

	// RVA: 0x1EEA340 Offset: 0x1EEA441 VA: 0x1EEA340
	private void UpdateMaterialParameter(TimeParamTable timeParamTable, HashSet<MaterialChangeTime> materialChangeSet, float dailyRatio) { }

	// RVA: 0x1EEB3D0 Offset: 0x1EEB4D1 VA: 0x1EEB3D0
	private void UpdateMaterialParameter(TimeParamTable timeParamTable, HashSet<Material> materialSet, float dailyRatio) { }

	// RVA: 0x1EEC090 Offset: 0x1EEC191 VA: 0x1EEC090
	private void UpdateObjectParameter(TimeParamTable timeParamTable, HashSet<ObjectChangeTime> objectChangeSet, float dailyRatio) { }

	// RVA: 0x1EEC370 Offset: 0x1EEC471 VA: 0x1EEC370
	private void UpdateRendererParameter(TimeParamTable timeParamTable, HashSet<RendererChangeTime> rendererChangeSet, float dailyRatio) { }

	// RVA: 0x1EEC7B0 Offset: 0x1EEC8B1 VA: 0x1EEC7B0
	public Material GetChangeMaterial(Material checkMaterial) { }

	// RVA: 0x1EEC7C0 Offset: 0x1EEC8C1 VA: 0x1EEC7C0
	public void .ctor() { }
}

