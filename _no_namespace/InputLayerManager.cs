public class InputLayerManager : SingletonMonoBehaviour<InputLayerManager> // TypeDefIndex: 7628
{
	// Fields
	public List<GameObject>[] InputLayers; // 0x18
	private bool CheckCleanLayer; // 0x20

	// Methods

	// RVA: 0x20CB3D0 Offset: 0x20CB4D1 VA: 0x20CB3D0
	public bool GetPermit(INPUTLAYER layer) { }

	// RVA: 0x20CB480 Offset: 0x20CB581 VA: 0x20CB480
	public void AddObjectLayer(GameObject obj, INPUTLAYER layer = 0) { }

	// RVA: 0x20CB570 Offset: 0x20CB671 VA: 0x20CB570
	public void RemoveObjectLayer(GameObject obj, INPUTLAYER layer = -1) { }

	// RVA: 0x20CB630 Offset: 0x20CB731 VA: 0x20CB630
	public void CleanObjectLayer(INPUTLAYER layer) { }

	// RVA: 0x20CAC90 Offset: 0x20CAD91 VA: 0x20CAC90
	public void CleanObjectLayers() { }

	// RVA: 0x20CB770 Offset: 0x20CB871 VA: 0x20CB770 Slot: 4
	protected override void Awake() { }

	// RVA: 0x20CB880 Offset: 0x20CB981 VA: 0x20CB880
	private void Update() { }

	// RVA: 0x20CB890 Offset: 0x20CB991 VA: 0x20CB890
	public void .ctor() { }
}

