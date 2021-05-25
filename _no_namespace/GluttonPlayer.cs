public class GluttonPlayer : MonoBehaviour // TypeDefIndex: 7390
{
	// Fields
	[SerializeField] // RVA: 0x1661D0 Offset: 0x1662D1 VA: 0x1661D0
	private bool isPlayer; // 0x18
	private FestivalCharacterController controller; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1661E0 Offset: 0x1662E1 VA: 0x1661E0
	private GluttonTablePos <CharaPos>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1661F0 Offset: 0x1662F1 VA: 0x1661F0
	private GluttonCharaState <CharaState>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x166200 Offset: 0x166301 VA: 0x166200
	private GluttonFood[] <CurrentFood>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x166210 Offset: 0x166311 VA: 0x166210
	private GameObject[] <FoodDish>k__BackingField; // 0x38
	[SerializeField] // RVA: 0x166220 Offset: 0x166321 VA: 0x166220
	private GameObject tablePos; // 0x40
	private readonly Vector3 PLAYER_BASE_POS; // 0x48
	private readonly Vector3[] DISH_POS; // 0x58
	private Vector3[] playerPos; // 0x60
	private FoodID pastEated; // 0x68
	private int[] dishCount; // 0x70
	private int currentFoodLife; // 0x78
	private int combo; // 0x7C
	private bool enableEat; // 0x80
	private const float COOL_TIME = 1;
	[SerializeField] // RVA: 0x166230 Offset: 0x166331 VA: 0x166230
	private float actTimeInterval; // 0x84
	private float actTimeCount; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x166240 Offset: 0x166341 VA: 0x166240
	private bool <IsMoving>k__BackingField; // 0x8C

	// Properties
	public GluttonTablePos CharaPos { get; set; }
	public GluttonCharaState CharaState { get; set; }
	public GluttonFood[] CurrentFood { get; set; }
	public GameObject[] FoodDish { get; set; }
	public bool IsMoving { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A07B0 Offset: 0x1A08B1 VA: 0x1A07B0
	// RVA: 0x1EB0670 Offset: 0x1EB0771 VA: 0x1EB0670
	public GluttonTablePos get_CharaPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A07C0 Offset: 0x1A08C1 VA: 0x1A07C0
	// RVA: 0x1EB0680 Offset: 0x1EB0781 VA: 0x1EB0680
	private void set_CharaPos(GluttonTablePos value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A07D0 Offset: 0x1A08D1 VA: 0x1A07D0
	// RVA: 0x1EB0690 Offset: 0x1EB0791 VA: 0x1EB0690
	public GluttonCharaState get_CharaState() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A07E0 Offset: 0x1A08E1 VA: 0x1A07E0
	// RVA: 0x1EB06A0 Offset: 0x1EB07A1 VA: 0x1EB06A0
	private void set_CharaState(GluttonCharaState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A07F0 Offset: 0x1A08F1 VA: 0x1A07F0
	// RVA: 0x1EB06B0 Offset: 0x1EB07B1 VA: 0x1EB06B0
	public GluttonFood[] get_CurrentFood() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0800 Offset: 0x1A0901 VA: 0x1A0800
	// RVA: 0x1EB06C0 Offset: 0x1EB07C1 VA: 0x1EB06C0
	private void set_CurrentFood(GluttonFood[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0810 Offset: 0x1A0911 VA: 0x1A0810
	// RVA: 0x1EB06D0 Offset: 0x1EB07D1 VA: 0x1EB06D0
	public GameObject[] get_FoodDish() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0820 Offset: 0x1A0921 VA: 0x1A0820
	// RVA: 0x1EB06E0 Offset: 0x1EB07E1 VA: 0x1EB06E0
	private void set_FoodDish(GameObject[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0830 Offset: 0x1A0931 VA: 0x1A0830
	// RVA: 0x1EB06F0 Offset: 0x1EB07F1 VA: 0x1EB06F0
	public bool get_IsMoving() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0840 Offset: 0x1A0941 VA: 0x1A0840
	// RVA: 0x1EB0700 Offset: 0x1EB0801 VA: 0x1EB0700
	public void set_IsMoving(bool value) { }

	// RVA: 0x1EB0710 Offset: 0x1EB0811 VA: 0x1EB0710
	private void Start() { }

	// RVA: 0x1EB09D0 Offset: 0x1EB0AD1 VA: 0x1EB09D0
	private void Update() { }

	// RVA: 0x1EADEC0 Offset: 0x1EADFC1 VA: 0x1EADEC0
	public void Init(FestivalCharacterController _controller) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0850 Offset: 0x1A0951 VA: 0x1A0850
	// RVA: 0x1EAEBA0 Offset: 0x1EAECA1 VA: 0x1EAEBA0
	public IEnumerator Run(GluttonTablePos _pos) { }

	// RVA: 0x1EAED50 Offset: 0x1EAEE51 VA: 0x1EAED50
	public void Eat() { }

	// RVA: 0x1EB0F10 Offset: 0x1EB1011 VA: 0x1EB0F10
	private void DishGenerator() { }

	// RVA: 0x1EB1240 Offset: 0x1EB1341 VA: 0x1EB1240
	private void ResetCoolTime() { }

	// RVA: 0x1EB0D50 Offset: 0x1EB0E51 VA: 0x1EB0D50
	private void UpdateNpcTimer() { }

	// RVA: 0x1EAE9B0 Offset: 0x1EAEAB1 VA: 0x1EAE9B0
	public bool CheckNpcTimer() { }

	// RVA: 0x1EAEA90 Offset: 0x1EAEB91 VA: 0x1EAEA90
	public void ResetNpcTimer() { }

	// RVA: 0x1EB1260 Offset: 0x1EB1361 VA: 0x1EB1260
	public void .ctor() { }
}

