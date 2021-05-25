public class GluttonManager : SingletonMonoBehaviour<GluttonManager> // TypeDefIndex: 7386
{
	// Fields
	private readonly int[] FOOD_PREFAB_ID; // 0x18
	private const int DISH_PREFAB_ID = 16167;
	[CompilerGeneratedAttribute] // RVA: 0x166160 Offset: 0x166261 VA: 0x166160
	private Dictionary<FoodID, GluttonFood> <GluttonFoods>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x166170 Offset: 0x166271 VA: 0x166170
	private GameObject <Dish>k__BackingField; // 0x28
	[SerializeField] // RVA: 0x166180 Offset: 0x166281 VA: 0x166180
	private FestivalCamera gluttonCamera; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x166190 Offset: 0x166291 VA: 0x166190
	private GluttonUI <GluttonUI>k__BackingField; // 0x38
	[SerializeField] // RVA: 0x1661A0 Offset: 0x1662A1 VA: 0x1661A0
	private ObjectPooler objectPooler; // 0x40
	[SerializeField] // RVA: 0x1661B0 Offset: 0x1662B1 VA: 0x1661B0
	private GluttonPlayer gluttonPlayer; // 0x48
	[SerializeField] // RVA: 0x1661C0 Offset: 0x1662C1 VA: 0x1661C0
	private GluttonPlayer[] gluttonNPC; // 0x50
	private List<ActorID> actorID; // 0x58
	private GluttonLotteryDataTable gluttonLotteryDataTable; // 0x60
	private GluttonDataTable gluttonDataTable; // 0x68
	private GluttonBonusDataTable gluttonBonusDataTable; // 0x70
	private GluttonManager.State state; // 0x78
	private int term; // 0x7C

	// Properties
	public Dictionary<FoodID, GluttonFood> GluttonFoods { get; set; }
	public List<float> GluttonBonus { get; }
	public GameObject Dish { get; set; }
	public FestivalCamera Camera { get; }
	public GluttonUI GluttonUI { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A06D0 Offset: 0x1A07D1 VA: 0x1A06D0
	// RVA: 0x1EAD5B0 Offset: 0x1EAD6B1 VA: 0x1EAD5B0
	public Dictionary<FoodID, GluttonFood> get_GluttonFoods() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A06E0 Offset: 0x1A07E1 VA: 0x1A06E0
	// RVA: 0x1EAD5C0 Offset: 0x1EAD6C1 VA: 0x1EAD5C0
	private void set_GluttonFoods(Dictionary<FoodID, GluttonFood> value) { }

	// RVA: 0x1EAD5D0 Offset: 0x1EAD6D1 VA: 0x1EAD5D0
	public List<float> get_GluttonBonus() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A06F0 Offset: 0x1A07F1 VA: 0x1A06F0
	// RVA: 0x1EAD5F0 Offset: 0x1EAD6F1 VA: 0x1EAD5F0
	public GameObject get_Dish() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0700 Offset: 0x1A0801 VA: 0x1A0700
	// RVA: 0x1EAD600 Offset: 0x1EAD701 VA: 0x1EAD600
	private void set_Dish(GameObject value) { }

	// RVA: 0x1EAD610 Offset: 0x1EAD711 VA: 0x1EAD610
	public FestivalCamera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0710 Offset: 0x1A0811 VA: 0x1A0710
	// RVA: 0x1EAD620 Offset: 0x1EAD721 VA: 0x1EAD620
	public GluttonUI get_GluttonUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0720 Offset: 0x1A0821 VA: 0x1A0720
	// RVA: 0x1EAD630 Offset: 0x1EAD731 VA: 0x1EAD630
	private void set_GluttonUI(GluttonUI value) { }

	// RVA: 0x1EAD640 Offset: 0x1EAD741 VA: 0x1EAD640 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1EAD6B0 Offset: 0x1EAD7B1 VA: 0x1EAD6B0
	private void Start() { }

	// RVA: 0x1EADB20 Offset: 0x1EADC21 VA: 0x1EADB20
	private void OnLoadingFood(int i) { }

	// RVA: 0x1EADC50 Offset: 0x1EADD51 VA: 0x1EADC50
	private void OnDestroy() { }

	// RVA: 0x1EADD50 Offset: 0x1EADE51 VA: 0x1EADD50
	private void CharaSetup() { }

	// RVA: 0x1EAE090 Offset: 0x1EAE191 VA: 0x1EAE090
	private bool IsLoading() { }

	// RVA: 0x1EAE2A0 Offset: 0x1EAE3A1 VA: 0x1EAE2A0
	private void Update() { }

	// RVA: 0x1EAEAA0 Offset: 0x1EAEBA1 VA: 0x1EAEAA0
	public void MovePosition(bool _move_dir) { }

	// RVA: 0x1EAEC30 Offset: 0x1EAED31 VA: 0x1EAEC30
	private void MovePositionNPC(GluttonTablePos _pos, int _no = 1) { }

	// RVA: 0x1EAED20 Offset: 0x1EAEE21 VA: 0x1EAED20
	public void Eat() { }

	// RVA: 0x1EAE9C0 Offset: 0x1EAEAC1 VA: 0x1EAE9C0
	private void procAI(int _no) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0730 Offset: 0x1A0831 VA: 0x1A0730
	// RVA: 0x1EAE930 Offset: 0x1EAEA31 VA: 0x1EAE930
	private IEnumerator GluttonGame() { }

	// RVA: 0x1EAF430 Offset: 0x1EAF531 VA: 0x1EAF430
	private void FoodGenerator(GluttonPlayer _player, int _term) { }

	// RVA: 0x1EAFA20 Offset: 0x1EAFB21 VA: 0x1EAFA20
	public void FoodRepop(GluttonPlayer _player) { }

	// RVA: 0x1EAFEF0 Offset: 0x1EAFFF1 VA: 0x1EAFEF0
	public void ResetNpc() { }

	// RVA: 0x1EB00C0 Offset: 0x1EB01C1 VA: 0x1EB00C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A07A0 Offset: 0x1A08A1 VA: 0x1A07A0
	// RVA: 0x1EB0190 Offset: 0x1EB0291 VA: 0x1EB0190
	private void <Start>b__30_0(AssetHandle<GameObject> handle) { }
}

