public class FieldTreasureBox : CharacterBase, InteractionInterface, FocusInterface // TypeDefIndex: 10497
{
	// Fields
	private const UITextDic.DICID FoucsNameTextID = 300000;
	[CompilerGeneratedAttribute] // RVA: 0x181C40 Offset: 0x181D41 VA: 0x181C40
	private int <ID>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x181C50 Offset: 0x181D51 VA: 0x181C50
	private FieldTreasureBoxDataType <TreasureBoxType>k__BackingField; // 0x68
	protected FieldTreasureBoxData BoxData; // 0x70
	[SerializeField] // RVA: 0x181C60 Offset: 0x181D61 VA: 0x181C60
	protected Transform[] DropPoints; // 0x78
	[SerializeField] // RVA: 0x181C70 Offset: 0x181D71 VA: 0x181C70
	protected Transform DropStartPoint; // 0x80
	[SerializeField] // RVA: 0x181C80 Offset: 0x181D81 VA: 0x181C80
	protected float SmokeEffectHeight; // 0x88
	[SerializeField] // RVA: 0x181C90 Offset: 0x181D91 VA: 0x181C90
	protected float SmokeEffectLength; // 0x8C
	public static readonly Vector3 TreasureSmokeOffset; // 0x0
	protected GameObject Model; // 0x90
	protected string FocusName; // 0x98
	protected bool DoneInteraction; // 0xA0
	protected bool IsBroken; // 0xA1
	protected bool IsAdvWait; // 0xA2
	private float CurrentTime; // 0xA4

	// Properties
	public int ID { get; set; }
	public FieldTreasureBoxDataType TreasureBoxType { get; set; }
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AF950 Offset: 0x1AFA51 VA: 0x1AF950
	// RVA: 0x1E2BF20 Offset: 0x1E2C021 VA: 0x1E2BF20
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF960 Offset: 0x1AFA61 VA: 0x1AF960
	// RVA: 0x1E2BF30 Offset: 0x1E2C031 VA: 0x1E2BF30
	public void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF970 Offset: 0x1AFA71 VA: 0x1AF970
	// RVA: 0x1E2BF40 Offset: 0x1E2C041 VA: 0x1E2BF40
	public FieldTreasureBoxDataType get_TreasureBoxType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF980 Offset: 0x1AFA81 VA: 0x1AF980
	// RVA: 0x1E2BF50 Offset: 0x1E2C051 VA: 0x1E2BF50
	public void set_TreasureBoxType(FieldTreasureBoxDataType value) { }

	// RVA: 0x1E29A40 Offset: 0x1E29B41 VA: 0x1E29A40
	public bool CanSpawn() { }

	// RVA: 0x1E2BF60 Offset: 0x1E2C061 VA: 0x1E2BF60 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1E29530 Offset: 0x1E29631 VA: 0x1E29530
	public void SetBoxData(FieldTreasureBoxData boxData) { }

	// RVA: 0x1E2C050 Offset: 0x1E2C151 VA: 0x1E2C050
	private void OnDestroy() { }

	// RVA: 0x1E2C2F0 Offset: 0x1E2C3F1 VA: 0x1E2C2F0 Slot: 31
	public virtual void SetDataTableID(int id, FieldTreasureBoxDataType type) { }

	// RVA: 0x1E28F60 Offset: 0x1E29061 VA: 0x1E28F60
	public void BoxReset() { }

	// RVA: 0x1E2C300 Offset: 0x1E2C401 VA: 0x1E2C300 Slot: 32
	public virtual void DoInteraction(HumanController character) { }

	// RVA: 0x1E2C4E0 Offset: 0x1E2C5E1 VA: 0x1E2C4E0
	protected void OpenTreasureBox() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF990 Offset: 0x1AFA91 VA: 0x1AF990
	// RVA: 0x1E2CE40 Offset: 0x1E2CF41 VA: 0x1E2CE40
	protected IEnumerator GetRecipeAdvScript(FieldTreasureBoxDropRecipe[] recipeDatas, int gold) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFA00 Offset: 0x1AFB01 VA: 0x1AFA00
	// RVA: 0x1E2CDC0 Offset: 0x1E2CEC1 VA: 0x1E2CDC0
	protected IEnumerator FadeClearModel() { }

	// RVA: 0x1E2CF40 Offset: 0x1E2D041 VA: 0x1E2CF40 Slot: 22
	public bool get_Focusable() { }

	// RVA: 0x1E2CF80 Offset: 0x1E2D081 VA: 0x1E2CF80 Slot: 25
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1E2CF90 Offset: 0x1E2D091 VA: 0x1E2CF90 Slot: 26
	public int get_FocusPriority() { }

	// RVA: 0x1E2CFA0 Offset: 0x1E2D0A1 VA: 0x1E2CFA0 Slot: 27
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1E2CFB0 Offset: 0x1E2D0B1 VA: 0x1E2CFB0 Slot: 17
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1E2D050 Offset: 0x1E2D151 VA: 0x1E2D050 Slot: 21
	public string GetFocusName() { }

	// RVA: 0x1E2D060 Offset: 0x1E2D161 VA: 0x1E2D060 Slot: 20
	public string GetInteractionButtonHint() { }

	// RVA: 0x1E2D0B0 Offset: 0x1E2D1B1 VA: 0x1E2D0B0 Slot: 24
	public void OffFocus() { }

	// RVA: 0x1E2D0C0 Offset: 0x1E2D1C1 VA: 0x1E2D0C0 Slot: 23
	public void OnFocus() { }

	// RVA: 0x1E2D0D0 Offset: 0x1E2D1D1 VA: 0x1E2D0D0 Slot: 28
	public ushort GetInteractionType() { }

	// RVA: 0x1E2D1B0 Offset: 0x1E2D2B1 VA: 0x1E2D1B0
	protected void OnDrawGizmos() { }

	// RVA: 0x1E2D2D0 Offset: 0x1E2D3D1 VA: 0x1E2D2D0 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage) { }

	// RVA: 0x1E2D4D0 Offset: 0x1E2D5D1 VA: 0x1E2D4D0 Slot: 18
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1E2D4E0 Offset: 0x1E2D5E1 VA: 0x1E2D4E0 Slot: 19
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1E2D4F0 Offset: 0x1E2D5F1 VA: 0x1E2D4F0
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x1E2D680 Offset: 0x1E2D781 VA: 0x1E2D680
	public void .ctor() { }

	// RVA: 0x1E2D6A0 Offset: 0x1E2D7A1 VA: 0x1E2D6A0
	private static void .cctor() { }

	// RVA: 0x1E2D730 Offset: 0x1E2D831 VA: 0x1E2D730 Slot: 29
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1E2D740 Offset: 0x1E2D841 VA: 0x1E2D740 Slot: 30
	private Transform FocusInterface.get_transform() { }
}

