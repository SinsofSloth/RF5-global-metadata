public class UIOneSceneAnim : MonoBehaviour // TypeDefIndex: 9834
{
	// Fields
	private static UIOneSceneAnim.Type OpenType; // 0x0
	private static readonly int[] LoaderIDTable; // 0x8
	[SerializeField] // RVA: 0x17F7C0 Offset: 0x17F8C1 VA: 0x17F7C0
	private RectTransform[] PrefEffectSpawnArea; // 0x18
	[SerializeField] // RVA: 0x17F7D0 Offset: 0x17F8D1 VA: 0x17F7D0
	private UIShopMoneyEffect UIShopMoneyEffect; // 0x20
	private List<float> EffectSpawnDelayTimes; // 0x28
	[SerializeField] // RVA: 0x17F7E0 Offset: 0x17F8E1 VA: 0x17F7E0
	private float SpawnDelayTimeRandMin; // 0x30
	[SerializeField] // RVA: 0x17F7F0 Offset: 0x17F8F1 VA: 0x17F7F0
	private float SpawnDelayTimeRandMax; // 0x34
	private static int loadingId; // 0x10
	private static UnityAction EndCallback; // 0x18
	private static GameObject usingAnim; // 0x20

	// Methods

	// RVA: 0x1DA3CC0 Offset: 0x1DA3DC1 VA: 0x1DA3CC0
	private void Start() { }

	// RVA: 0x1DA3D90 Offset: 0x1DA3E91 VA: 0x1DA3D90
	private float ReDalayEffectTime() { }

	// RVA: 0x1DA3DA0 Offset: 0x1DA3EA1 VA: 0x1DA3DA0
	private void Update() { }

	// RVA: 0x1DA4050 Offset: 0x1DA4151 VA: 0x1DA4050
	private static void Loaded(AssetHandle<GameObject> handle) { }

	// RVA: 0x1DA4120 Offset: 0x1DA4221 VA: 0x1DA4120
	public static void Call(UIOneSceneAnim.Type OpenType, UnityAction _EndCallback) { }

	// RVA: 0x1DA4310 Offset: 0x1DA4411 VA: 0x1DA4310
	public static void End() { }

	// RVA: 0x1DA43E0 Offset: 0x1DA44E1 VA: 0x1DA43E0
	private void OnDestroy() { }

	// RVA: 0x1DA4540 Offset: 0x1DA4641 VA: 0x1DA4540
	public void .ctor() { }

	// RVA: 0x1DA4550 Offset: 0x1DA4651 VA: 0x1DA4550
	private static void .cctor() { }
}

