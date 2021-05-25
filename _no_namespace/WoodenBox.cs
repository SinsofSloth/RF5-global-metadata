public class WoodenBox : CharacterBase, InteractionInterface, FocusInterface, HoldableInterface // TypeDefIndex: 7527
{
	// Fields
	private static Vector3 ItemSpawnOffset; // 0x0
	private const UITextDic.DICID FoucsNameTextID = 300004;
	private bool IsThrow; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x166D30 Offset: 0x166E31 VA: 0x166D30
	private Renderer[] <ModelsMeshes>k__BackingField; // 0x68
	private MaterialPropertyBlock materialPropertyBlock; // 0x70
	[SerializeField] // RVA: 0x166D40 Offset: 0x166E41 VA: 0x166D40
	private BoxCollider box; // 0x78
	[SerializeField] // RVA: 0x166D50 Offset: 0x166E51 VA: 0x166D50
	private SphereCollider sphere; // 0x80
	private FieldWoodBoxSpawnID BoxSpawnID; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x166D60 Offset: 0x166E61 VA: 0x166D60
	private ItemLotteryID <ItemLotteryID>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x166D70 Offset: 0x166E71 VA: 0x166D70
	private int <ModelID>k__BackingField; // 0x90
	protected string FocusName; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x166D80 Offset: 0x166E81 VA: 0x166D80
	private ThrowController <ThrowController>k__BackingField; // 0xA0
	private bool DoneBroken; // 0xA8
	private bool IsDamaged; // 0xA9

	// Properties
	public Renderer[] ModelsMeshes { get; set; }
	public ItemLotteryID ItemLotteryID { get; set; }
	public int ModelID { get; set; }
	public bool Focusable { get; }
	public HoldMotionType HoldMotionType { get; }
	public ItemData ItemData { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }
	public ThrowController ThrowController { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A19B0 Offset: 0x1A1AB1 VA: 0x1A19B0
	// RVA: 0x1D0B4C0 Offset: 0x1D0B5C1 VA: 0x1D0B4C0
	public Renderer[] get_ModelsMeshes() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A19C0 Offset: 0x1A1AC1 VA: 0x1A19C0
	// RVA: 0x1D0B4D0 Offset: 0x1D0B5D1 VA: 0x1D0B4D0
	private void set_ModelsMeshes(Renderer[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A19D0 Offset: 0x1A1AD1 VA: 0x1A19D0
	// RVA: 0x1D0B4E0 Offset: 0x1D0B5E1 VA: 0x1D0B4E0
	public ItemLotteryID get_ItemLotteryID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A19E0 Offset: 0x1A1AE1 VA: 0x1A19E0
	// RVA: 0x1D0B4F0 Offset: 0x1D0B5F1 VA: 0x1D0B4F0
	public void set_ItemLotteryID(ItemLotteryID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A19F0 Offset: 0x1A1AF1 VA: 0x1A19F0
	// RVA: 0x1D0B500 Offset: 0x1D0B601 VA: 0x1D0B500
	public int get_ModelID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1A00 Offset: 0x1A1B01 VA: 0x1A1A00
	// RVA: 0x1D0B510 Offset: 0x1D0B611 VA: 0x1D0B510
	private void set_ModelID(int value) { }

	// RVA: 0x1D0B520 Offset: 0x1D0B621 VA: 0x1D0B520
	public void SetModelID(int modelId) { }

	// RVA: 0x1D0B630 Offset: 0x1D0B731 VA: 0x1D0B630
	public void SetDataID(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1D0B640 Offset: 0x1D0B741 VA: 0x1D0B640
	private void OnDestroy() { }

	// RVA: 0x1D0B710 Offset: 0x1D0B811 VA: 0x1D0B710 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1D0B890 Offset: 0x1D0B991 VA: 0x1D0B890 Slot: 22
	public bool get_Focusable() { }

	// RVA: 0x1D0B920 Offset: 0x1D0BA21 VA: 0x1D0B920 Slot: 38
	public HoldMotionType get_HoldMotionType() { }

	// RVA: 0x1D0B930 Offset: 0x1D0BA31 VA: 0x1D0B930
	public ItemData get_ItemData() { }

	// RVA: 0x1D0B940 Offset: 0x1D0BA41 VA: 0x1D0B940 Slot: 25
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1D0B950 Offset: 0x1D0BA51 VA: 0x1D0B950 Slot: 26
	public int get_FocusPriority() { }

	// RVA: 0x1D0B960 Offset: 0x1D0BA61 VA: 0x1D0B960 Slot: 27
	public FocusPointType get_FocusPointType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1A10 Offset: 0x1A1B11 VA: 0x1A1A10
	// RVA: 0x1D0B970 Offset: 0x1D0BA71 VA: 0x1D0B970 Slot: 33
	public ThrowController get_ThrowController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1A20 Offset: 0x1A1B21 VA: 0x1A1A20
	// RVA: 0x1D0B980 Offset: 0x1D0BA81 VA: 0x1D0B980
	private void set_ThrowController(ThrowController value) { }

	// RVA: 0x1D0B990 Offset: 0x1D0BA91 VA: 0x1D0B990 Slot: 17
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1D0B9E0 Offset: 0x1D0BAE1 VA: 0x1D0B9E0 Slot: 40
	public bool CanRuckIn() { }

	// RVA: 0x1D0B9F0 Offset: 0x1D0BAF1 VA: 0x1D0B9F0 Slot: 39
	public bool CanPuton() { }

	// RVA: 0x1D0BA00 Offset: 0x1D0BB01 VA: 0x1D0BA00 Slot: 34
	public bool CanThrow() { }

	// RVA: 0x1D0BA10 Offset: 0x1D0BB11 VA: 0x1D0BA10 Slot: 41
	public bool OnTakeDamage(DamageResult result) { }

	// RVA: 0x1D0BA20 Offset: 0x1D0BB21 VA: 0x1D0BA20 Slot: 16
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1D0BA50 Offset: 0x1D0BB51 VA: 0x1D0BA50 Slot: 21
	public string GetFocusName() { }

	// RVA: 0x1D0BA60 Offset: 0x1D0BB61 VA: 0x1D0BA60 Slot: 20
	public string GetInteractionButtonHint() { }

	// RVA: 0x1D0BAB0 Offset: 0x1D0BBB1 VA: 0x1D0BAB0 Slot: 24
	public void OffFocus() { }

	// RVA: 0x1D0BAC0 Offset: 0x1D0BBC1 VA: 0x1D0BAC0 Slot: 23
	public void OnFocus() { }

	// RVA: 0x1D0BAD0 Offset: 0x1D0BBD1 VA: 0x1D0BAD0 Slot: 28
	public ushort GetInteractionType() { }

	// RVA: 0x1D0BB80 Offset: 0x1D0BC81 VA: 0x1D0BB80 Slot: 42
	public ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID) { }

	// RVA: 0x1D0BD20 Offset: 0x1D0BE21 VA: 0x1D0BD20 Slot: 31
	public void OnHold() { }

	// RVA: 0x1D0BDF0 Offset: 0x1D0BEF1 VA: 0x1D0BDF0 Slot: 32
	public void OnPutOn() { }

	// RVA: 0x1D0BEB0 Offset: 0x1D0BFB1 VA: 0x1D0BEB0
	private void OnBroken() { }

	// RVA: 0x1D0C2B0 Offset: 0x1D0C3B1 VA: 0x1D0C2B0 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage) { }

	// RVA: 0x1D0C370 Offset: 0x1D0C471 VA: 0x1D0C370 Slot: 35
	public void OnThrow() { }

	// RVA: 0x1D0C3F0 Offset: 0x1D0C4F1 VA: 0x1D0C3F0 Slot: 36
	public bool HitCheck(HitResult result, ThrowController throwController) { }

	// RVA: 0x1D0C7D0 Offset: 0x1D0C8D1 VA: 0x1D0C7D0 Slot: 37
	public void OnPutOnByThrow() { }

	// RVA: 0x1D0C7E0 Offset: 0x1D0C8E1 VA: 0x1D0C7E0 Slot: 18
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D0C7F0 Offset: 0x1D0C8F1 VA: 0x1D0C7F0 Slot: 19
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D0BEA0 Offset: 0x1D0BFA1 VA: 0x1D0BEA0 Slot: 43
	public void SetAlpha(float alpha) { }

	// RVA: 0x1D0C800 Offset: 0x1D0C901 VA: 0x1D0C800
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x1D0C9A0 Offset: 0x1D0CAA1 VA: 0x1D0C9A0
	public void .ctor() { }

	// RVA: 0x1D0CA10 Offset: 0x1D0CB11 VA: 0x1D0CA10
	private static void .cctor() { }

	// RVA: 0x1D0CAA0 Offset: 0x1D0CBA1 VA: 0x1D0CAA0 Slot: 29
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1D0CAB0 Offset: 0x1D0CBB1 VA: 0x1D0CAB0 Slot: 30
	private Transform FocusInterface.get_transform() { }
}

