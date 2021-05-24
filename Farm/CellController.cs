public class CellController : MonoBehaviour, InteractionInterface, FocusInterface, ItemInteractionInterface, PlowInteractionInterface, ToolInteractionInterface, SmashInteractionInterface, PotInteractionInterface, SowInteractionInterface, SlashInteractionInterface, ChopInteractionInterface, FarmDrugInteractionInterface // TypeDefIndex: 10324
{
	// Fields
	[SerializeField] // RVA: 0x181330 Offset: 0x181431 VA: 0x181330
	private CellSetController cellSetController; // 0x18
	[SerializeField] // RVA: 0x181340 Offset: 0x181441 VA: 0x181340
	private SoilStatus soilStatus; // 0x20
	[SerializeField] // RVA: 0x181350 Offset: 0x181451 VA: 0x181350
	private PlantStatus plantStatus; // 0x28
	private Vector3 _tPosition; // 0x30
	private bool largeCursor; // 0x3C
	private bool _isEnableCells; // 0x3D
	public bool _isMeteor; // 0x3E
	[CompilerGeneratedAttribute] // RVA: 0x181360 Offset: 0x181461 VA: 0x181360
	private FarmManager.FARM_ID <FarmId>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181370 Offset: 0x181471 VA: 0x181370
	private int <CellId>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x181380 Offset: 0x181481 VA: 0x181380
	private Vector3Int <CellSetId>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x181390 Offset: 0x181491 VA: 0x181390
	private ItemData <CropItemData>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x1813A0 Offset: 0x1814A1 VA: 0x1813A0
	private CropDataTable <CropData>k__BackingField; // 0x60
	private GameObject FarmRunePrefab; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x1813B0 Offset: 0x1814B1 VA: 0x1813B0
	private Vector2 <CellPositionInFarm>k__BackingField; // 0x158

	// Properties
	public FarmManager.FARM_ID FarmId { get; set; }
	public int CellId { get; set; }
	public Vector3Int CellSetId { get; set; }
	public ItemData CropItemData { get; set; }
	public CropDataTable CropData { get; set; }
	public CellSetController GetCellSetController { get; }
	public Vector2 CellPositionInFarm { get; set; }
	public bool Focusable { get; }
	public SoilStatus GetSoilStatus { get; set; }
	public PlantStatus GetPlantStatus { get; set; }
	public string ItemInteractionButtonHint { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AE5E0 Offset: 0x1AE6E1 VA: 0x1AE5E0
	// RVA: 0x20873B0 Offset: 0x20874B1 VA: 0x20873B0
	public void set_FarmId(FarmManager.FARM_ID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE5F0 Offset: 0x1AE6F1 VA: 0x1AE5F0
	// RVA: 0x20873C0 Offset: 0x20874C1 VA: 0x20873C0
	public FarmManager.FARM_ID get_FarmId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE600 Offset: 0x1AE701 VA: 0x1AE600
	// RVA: 0x20873D0 Offset: 0x20874D1 VA: 0x20873D0
	public void set_CellId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE610 Offset: 0x1AE711 VA: 0x1AE610
	// RVA: 0x20873E0 Offset: 0x20874E1 VA: 0x20873E0
	public int get_CellId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE620 Offset: 0x1AE721 VA: 0x1AE620
	// RVA: 0x20873F0 Offset: 0x20874F1 VA: 0x20873F0
	public Vector3Int get_CellSetId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE630 Offset: 0x1AE731 VA: 0x1AE630
	// RVA: 0x2087400 Offset: 0x2087501 VA: 0x2087400
	public void set_CellSetId(Vector3Int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE640 Offset: 0x1AE741 VA: 0x1AE640
	// RVA: 0x2087410 Offset: 0x2087511 VA: 0x2087410
	public ItemData get_CropItemData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE650 Offset: 0x1AE751 VA: 0x1AE650
	// RVA: 0x2087420 Offset: 0x2087521 VA: 0x2087420
	public void set_CropItemData(ItemData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE660 Offset: 0x1AE761 VA: 0x1AE660
	// RVA: 0x2087430 Offset: 0x2087531 VA: 0x2087430
	public CropDataTable get_CropData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE670 Offset: 0x1AE771 VA: 0x1AE670
	// RVA: 0x2087440 Offset: 0x2087541 VA: 0x2087440
	public void set_CropData(CropDataTable value) { }

	// RVA: 0x2087470 Offset: 0x2087571 VA: 0x2087470
	public CellSetController get_GetCellSetController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE680 Offset: 0x1AE781 VA: 0x1AE680
	// RVA: 0x2087480 Offset: 0x2087581 VA: 0x2087480
	public void set_CellPositionInFarm(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE690 Offset: 0x1AE791 VA: 0x1AE690
	// RVA: 0x2087490 Offset: 0x2087591 VA: 0x2087490
	public Vector2 get_CellPositionInFarm() { }

	// RVA: 0x20874A0 Offset: 0x20875A1 VA: 0x20874A0 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x20874B0 Offset: 0x20875B1 VA: 0x20874B0
	public SoilStatus get_GetSoilStatus() { }

	// RVA: 0x20874C0 Offset: 0x20875C1 VA: 0x20874C0
	public void set_GetSoilStatus(SoilStatus value) { }

	// RVA: 0x20874D0 Offset: 0x20875D1 VA: 0x20874D0
	public PlantStatus get_GetPlantStatus() { }

	// RVA: 0x20874E0 Offset: 0x20875E1 VA: 0x20874E0
	public void set_GetPlantStatus(PlantStatus value) { }

	// RVA: 0x20874F0 Offset: 0x20875F1 VA: 0x20874F0
	public string get_ItemInteractionButtonHint() { }

	// RVA: 0x2087550 Offset: 0x2087651 VA: 0x2087550 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x2087560 Offset: 0x2087661 VA: 0x2087560 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x2087570 Offset: 0x2087671 VA: 0x2087570 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x2087580 Offset: 0x2087681 VA: 0x2087580
	private void OnDestroy() { }

	// RVA: 0x2087650 Offset: 0x2087751 VA: 0x2087650
	public void CheckEquipedItem() { }

	// RVA: 0x20877A0 Offset: 0x20878A1 VA: 0x20877A0 Slot: 12
	public void OffFocus() { }

	// RVA: 0x20877D0 Offset: 0x20878D1 VA: 0x20877D0 Slot: 11
	public void OnFocus() { }

	// RVA: 0x2087840 Offset: 0x2087941 VA: 0x2087840 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x2087850 Offset: 0x2087951 VA: 0x2087850 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x2087B40 Offset: 0x2087C41 VA: 0x2087B40 Slot: 23
	public bool CanPlow(HumanController humanController) { }

	// RVA: 0x2087D50 Offset: 0x2087E51 VA: 0x2087D50 Slot: 22
	public void DoPlow(HumanController humanController) { }

	// RVA: 0x2088290 Offset: 0x2088391 VA: 0x2088290 Slot: 31
	public bool CanSow(HumanController human, SeedItemData itemData) { }

	// RVA: 0x2088350 Offset: 0x2088451 VA: 0x2088350 Slot: 30
	public void DoSow(HumanController human, SeedItemData itemData) { }

	// RVA: 0x2088C40 Offset: 0x2088D41 VA: 0x2088C40 Slot: 29
	public bool CanUsePot(HumanController humanController, EquipItemData equipItemData, bool isRange) { }

	// RVA: 0x2088D40 Offset: 0x2088E41 VA: 0x2088D40 Slot: 28
	public bool UsePot(HumanController humanController, EquipItemData equipItemData) { }

	// RVA: 0x2088EE0 Offset: 0x2088FE1 VA: 0x2088EE0 Slot: 25
	public bool CanSmash(HumanController humanController) { }

	// RVA: 0x2088F40 Offset: 0x2089041 VA: 0x2088F40 Slot: 24
	public void DoSmash(HumanController humanController) { }

	// RVA: 0x2089190 Offset: 0x2089291 VA: 0x2089190 Slot: 26
	public void DoBreak(HumanController humanController) { }

	// RVA: 0x20891A0 Offset: 0x20892A1 VA: 0x20891A0 Slot: 27
	public bool CanBreak(HumanController humanController) { }

	// RVA: 0x20891B0 Offset: 0x20892B1 VA: 0x20891B0 Slot: 33
	public bool CanSlash(HumanController humanController) { }

	// RVA: 0x2089200 Offset: 0x2089301 VA: 0x2089200 Slot: 32
	public void DoSlash(HumanController humanController) { }

	// RVA: 0x2089530 Offset: 0x2089631 VA: 0x2089530 Slot: 34
	public void DoChop(HumanController humanController) { }

	// RVA: 0x2089680 Offset: 0x2089781 VA: 0x2089680 Slot: 35
	public bool CanChop(HumanController humanController) { }

	// RVA: 0x20896C0 Offset: 0x20897C1 VA: 0x20896C0 Slot: 36
	public void DoSpray(HumanController human, ItemData itemData) { }

	// RVA: 0x20898F0 Offset: 0x20899F1 VA: 0x20898F0 Slot: 37
	public bool CanSpray(HumanController human, ItemData itemData) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE6A0 Offset: 0x1AE7A1 VA: 0x1AE6A0
	// RVA: 0x2089930 Offset: 0x2089A31 VA: 0x2089930
	public IEnumerator ChangeCropData(int growLv, Action<CropDataTable> callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE710 Offset: 0x1AE811 VA: 0x1AE710
	// RVA: 0x2089A00 Offset: 0x2089B01 VA: 0x2089A00
	public IEnumerator ChangeCropData(bool isGrow) { }

	// RVA: 0x20881A0 Offset: 0x20882A1 VA: 0x20881A0
	public static void playEffect(EffectID effectId, Vector3 position, float scale = 2) { }

	// RVA: 0x2089A90 Offset: 0x2089B91 VA: 0x2089A90
	public static CellController getHittingCell(Vector3 pos) { }

	// RVA: 0x2089C40 Offset: 0x2089D41 VA: 0x2089C40
	private void Start() { }

	// RVA: 0x2089DA0 Offset: 0x2089EA1 VA: 0x2089DA0
	private void OnDisable() { }

	// RVA: 0x2089DB0 Offset: 0x2089EB1 VA: 0x2089DB0
	private void OnEnable() { }

	// RVA: 0x2089DC0 Offset: 0x2089EC1 VA: 0x2089DC0
	private void Harvest(HumanController chracter, bool isItemInteraction) { }

	// RVA: 0x208A570 Offset: 0x208A671 VA: 0x208A570 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x208A580 Offset: 0x208A681 VA: 0x208A580 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x208A610 Offset: 0x208A711 VA: 0x208A610 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x208A660 Offset: 0x208A761 VA: 0x208A660 Slot: 19
	public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x208A670 Offset: 0x208A771 VA: 0x208A670 Slot: 20
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x208A780 Offset: 0x208A881 VA: 0x208A780 Slot: 21
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }

	// RVA: 0x2088B90 Offset: 0x2088C91 VA: 0x2088B90
	public void ResetCell() { }

	// RVA: 0x208A790 Offset: 0x208A891 VA: 0x208A790
	public void DoFarmAction(FarmManager.FARM_MONSTER_TASK task, ItemData seedItemData) { }

	// RVA: 0x208B000 Offset: 0x208B101 VA: 0x208B000 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x208B010 Offset: 0x208B111 VA: 0x208B010 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x208B020 Offset: 0x208B121 VA: 0x208B020
	public void .ctor() { }

	// RVA: 0x208B030 Offset: 0x208B131 VA: 0x208B030 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x208B040 Offset: 0x208B141 VA: 0x208B040 Slot: 18
	private Transform FocusInterface.get_transform() { }
}

