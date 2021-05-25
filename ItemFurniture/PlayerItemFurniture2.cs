public class PlayerItemFurniture2 : MonoBehaviour, HoldableInterface, InteractionInterface, FocusInterface // TypeDefIndex: 10277
{
	// Fields
	public FurnitureID FurnitureID; // 0x18
	public string UniqueID; // 0x20
	public int Hp; // 0x28
	[HideInInspector] // RVA: 0x180D50 Offset: 0x180E51 VA: 0x180D50
	public bool LoadCreate; // 0x2C
	[HideInInspector] // RVA: 0x180D60 Offset: 0x180E61 VA: 0x180D60
	public int PrefabId; // 0x30
	[HideInInspector] // RVA: 0x180D70 Offset: 0x180E71 VA: 0x180D70
	public Vector3 ShadowPos; // 0x34
	private FurnitureShadow furnitureShadow; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x180D80 Offset: 0x180E81 VA: 0x180D80
	private Renderer[] <ModelMeshes>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x180D90 Offset: 0x180E91 VA: 0x180D90
	private bool <IsDispModel>k__BackingField; // 0x50
	private bool isRemove; // 0x51
	private PlayerItemFurniture2.State CurrentState; // 0x54
	private Collider Collider; // 0x58
	private MeshCollider MeshCollider; // 0x60
	[SerializeField] // RVA: 0x180DA0 Offset: 0x180EA1 VA: 0x180DA0
	private FurnitureBreakConditions furnitureBreakConditions; // 0x68

	// Properties
	public Renderer[] ModelMeshes { get; set; }
	public bool IsDispModel { get; set; }
	public HoldMotionType HoldMotionType { get; }
	public ItemData ItemData { get; }
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }
	public ThrowController ThrowController { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1ADD10 Offset: 0x1ADE11 VA: 0x1ADD10
	// RVA: 0x1F3B650 Offset: 0x1F3B751 VA: 0x1F3B650
	public Renderer[] get_ModelMeshes() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADD20 Offset: 0x1ADE21 VA: 0x1ADD20
	// RVA: 0x1F3B660 Offset: 0x1F3B761 VA: 0x1F3B660
	private void set_ModelMeshes(Renderer[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADD30 Offset: 0x1ADE31 VA: 0x1ADD30
	// RVA: 0x1F3B670 Offset: 0x1F3B771 VA: 0x1F3B670
	public bool get_IsDispModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADD40 Offset: 0x1ADE41 VA: 0x1ADD40
	// RVA: 0x1F3B680 Offset: 0x1F3B781 VA: 0x1F3B680
	public void set_IsDispModel(bool value) { }

	// RVA: 0x1F3B690 Offset: 0x1F3B791 VA: 0x1F3B690
	private void OnDestroy() { }

	// RVA: 0x1F2FED0 Offset: 0x1F2FFD1 VA: 0x1F2FED0
	public void Break(bool is_remove, bool del_savedata = True) { }

	// RVA: 0x1F3B790 Offset: 0x1F3B891 VA: 0x1F3B790
	private void CreateItem(ItemID itemID) { }

	// RVA: 0x1F3B880 Offset: 0x1F3B981 VA: 0x1F3B880 Slot: 11
	public HoldMotionType get_HoldMotionType() { }

	// RVA: 0x1F3B890 Offset: 0x1F3B991 VA: 0x1F3B890
	public ItemData get_ItemData() { }

	// RVA: 0x1F37CB0 Offset: 0x1F37DB1 VA: 0x1F37CB0 Slot: 23
	public bool get_Focusable() { }

	// RVA: 0x1F3B8A0 Offset: 0x1F3B9A1 VA: 0x1F3B8A0 Slot: 26
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1F3B8B0 Offset: 0x1F3B9B1 VA: 0x1F3B8B0 Slot: 27
	public int get_FocusPriority() { }

	// RVA: 0x1F3B8C0 Offset: 0x1F3B9C1 VA: 0x1F3B8C0 Slot: 28
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1F3B8D0 Offset: 0x1F3B9D1 VA: 0x1F3B8D0 Slot: 6
	public ThrowController get_ThrowController() { }

	// RVA: 0x1F3B8E0 Offset: 0x1F3B9E1 VA: 0x1F3B8E0
	private void Awake() { }

	// RVA: 0x1F39000 Offset: 0x1F39101 VA: 0x1F39000
	public void SetHp(int hp) { }

	// RVA: 0x1F3BD20 Offset: 0x1F3BE21 VA: 0x1F3BD20
	private void OnDisable() { }

	// RVA: 0x1F3BDD0 Offset: 0x1F3BED1 VA: 0x1F3BDD0
	private void OnEnable() { }

	// RVA: 0x1F3BE80 Offset: 0x1F3BF81 VA: 0x1F3BE80
	private void Update() { }

	// RVA: 0x1F3C390 Offset: 0x1F3C491 VA: 0x1F3C390 Slot: 4
	public void OnHold() { }

	// RVA: 0x1F3C590 Offset: 0x1F3C691 VA: 0x1F3C590 Slot: 5
	public void OnPutOn() { }

	// RVA: 0x1F3C720 Offset: 0x1F3C821 VA: 0x1F3C720 Slot: 7
	public bool CanThrow() { }

	// RVA: 0x1F3C730 Offset: 0x1F3C831 VA: 0x1F3C730
	public void Throw(Quaternion direction) { }

	// RVA: 0x1F3C740 Offset: 0x1F3C841 VA: 0x1F3C740 Slot: 17
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1F35540 Offset: 0x1F35641 VA: 0x1F35540
	public void PickUp() { }

	// RVA: 0x1F386A0 Offset: 0x1F387A1 VA: 0x1F386A0
	public void Have() { }

	// RVA: 0x1F3C850 Offset: 0x1F3C951 VA: 0x1F3C850 Slot: 18
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1F3C8C0 Offset: 0x1F3C9C1 VA: 0x1F3C8C0 Slot: 21
	public string GetInteractionButtonHint() { }

	// RVA: 0x1F3C910 Offset: 0x1F3CA11 VA: 0x1F3C910 Slot: 22
	public string GetFocusName() { }

	// RVA: 0x1F3C920 Offset: 0x1F3CA21 VA: 0x1F3C920 Slot: 24
	public void OnFocus() { }

	// RVA: 0x1F3C930 Offset: 0x1F3CA31 VA: 0x1F3C930 Slot: 25
	public void OffFocus() { }

	// RVA: 0x1F3C940 Offset: 0x1F3CA41 VA: 0x1F3C940 Slot: 32
	public virtual ushort GetInteractionType() { }

	// RVA: 0x1F3C9F0 Offset: 0x1F3CAF1 VA: 0x1F3C9F0 Slot: 15
	public ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID) { }

	// RVA: 0x1F3CA30 Offset: 0x1F3CB31 VA: 0x1F3CA30 Slot: 12
	public bool CanPuton() { }

	// RVA: 0x1F3CA70 Offset: 0x1F3CB71 VA: 0x1F3CA70 Slot: 13
	public bool CanRuckIn() { }

	// RVA: 0x1F3CA80 Offset: 0x1F3CB81 VA: 0x1F3CA80 Slot: 14
	public bool OnTakeDamage(DamageResult result) { }

	// RVA: 0x1F3CBD0 Offset: 0x1F3CCD1 VA: 0x1F3CBD0
	public void OnThrow(Quaternion direction) { }

	// RVA: 0x1F3CBE0 Offset: 0x1F3CCE1 VA: 0x1F3CBE0 Slot: 8
	public void OnThrow() { }

	// RVA: 0x1F3CBF0 Offset: 0x1F3CCF1 VA: 0x1F3CBF0
	public void HitCheck(Collider collider) { }

	// RVA: 0x1F3CC00 Offset: 0x1F3CD01 VA: 0x1F3CC00 Slot: 10
	public void OnPutOnByThrow() { }

	// RVA: 0x1F3CC10 Offset: 0x1F3CD11 VA: 0x1F3CC10 Slot: 9
	public bool HitCheck(HitResult result, ThrowController throwController) { }

	// RVA: 0x1F3CC20 Offset: 0x1F3CD21 VA: 0x1F3CC20 Slot: 19
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1F3CC30 Offset: 0x1F3CD31 VA: 0x1F3CC30 Slot: 20
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1F3C710 Offset: 0x1F3C811 VA: 0x1F3C710 Slot: 16
	public void SetAlpha(float alpha) { }

	// RVA: 0x1F3CC40 Offset: 0x1F3CD41 VA: 0x1F3CC40
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x1F3BBA0 Offset: 0x1F3BCA1 VA: 0x1F3BBA0
	private void SetTrigger(bool enable) { }

	// RVA: 0x1F3BC60 Offset: 0x1F3BD61 VA: 0x1F3BC60
	private void SetEnable(bool enable) { }

	// RVA: 0x1F3C4E0 Offset: 0x1F3C5E1 VA: 0x1F3C4E0
	private void OnCollider() { }

	// RVA: 0x1F3CE40 Offset: 0x1F3CF41 VA: 0x1F3CE40
	public void .ctor() { }

	// RVA: 0x1F3CEF0 Offset: 0x1F3CFF1 VA: 0x1F3CEF0 Slot: 30
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1F3CF00 Offset: 0x1F3D001 VA: 0x1F3CF00 Slot: 31
	private Transform FocusInterface.get_transform() { }
}

