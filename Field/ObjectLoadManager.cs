public class ObjectLoadManager : SingletonMonoBehaviour<ObjectLoadManager> // TypeDefIndex: 10459
{
	// Fields
	private List<ObjectLoader> ObjectLoadList; // 0x18
	private List<ObjectLoader> LoadRequestList; // 0x20

	// Methods

	// RVA: 0x1EED3A0 Offset: 0x1EED4A1 VA: 0x1EED3A0
	public int GetObjectLoadListCount() { }

	// RVA: 0x1EED3F0 Offset: 0x1EED4F1 VA: 0x1EED3F0
	public void AddObjectLoadList(ObjectLoader objectLoad) { }

	// RVA: 0x1EED460 Offset: 0x1EED561 VA: 0x1EED460
	public void RemoveObjectLoadList(ObjectLoader objectLoad) { }

	// RVA: 0x1EED4D0 Offset: 0x1EED5D1 VA: 0x1EED4D0
	public bool IsLoadCompleted() { }

	// RVA: 0x1EED610 Offset: 0x1EED711 VA: 0x1EED610
	public void LoadRequest(ObjectLoader objectLoad) { }

	// RVA: 0x1EED680 Offset: 0x1EED781 VA: 0x1EED680
	private void OnEnable() { }

	// RVA: 0x1EED690 Offset: 0x1EED791 VA: 0x1EED690
	private void Start() { }

	// RVA: 0x1EED6A0 Offset: 0x1EED7A1 VA: 0x1EED6A0
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF4A0 Offset: 0x1AF5A1 VA: 0x1AF4A0
	// RVA: 0x1EED770 Offset: 0x1EED871 VA: 0x1EED770
	public IEnumerator LoadObject() { }

	// RVA: 0x1EED820 Offset: 0x1EED921 VA: 0x1EED820
	public void .ctor() { }
}

