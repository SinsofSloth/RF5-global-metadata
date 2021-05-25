public class AdvStaffRollBase : MonoBehaviour // TypeDefIndex: 8423
{
	// Fields
	private int step; // 0x18
	private AdvStaffRollControl SRCntl; // 0x20
	private int prefabNo; // 0x28
	private float scroll_time; // 0x2C

	// Methods

	// RVA: 0x2278400 Offset: 0x2278501 VA: 0x2278400
	private void Start() { }

	// RVA: 0x2278430 Offset: 0x2278531 VA: 0x2278430
	private void Update() { }

	// RVA: 0x22787B0 Offset: 0x22788B1 VA: 0x22787B0
	private void OnDestroy() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A7540 Offset: 0x1A7641 VA: 0x1A7540
	// RVA: 0x22787C0 Offset: 0x22788C1 VA: 0x22787C0
	private IEnumerator createPrefab(int prefabNo) { }

	// RVA: 0x2278880 Offset: 0x2278981 VA: 0x2278880
	public void StartStaffRoll(int type, float time) { }

	// RVA: 0x22789A0 Offset: 0x2278AA1 VA: 0x22789A0
	public void EndStaffRoll() { }

	// RVA: 0x2278AE0 Offset: 0x2278BE1 VA: 0x2278AE0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A75B0 Offset: 0x1A76B1 VA: 0x1A75B0
	// RVA: 0x2278AF0 Offset: 0x2278BF1 VA: 0x2278AF0
	private void <createPrefab>b__7_0(AssetHandle<GameObject> handle) { }
}

