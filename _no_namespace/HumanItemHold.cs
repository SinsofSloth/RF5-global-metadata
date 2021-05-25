[DefaultExecutionOrder] // RVA: 0x145E90 Offset: 0x145F91 VA: 0x145E90
public class HumanItemHold : MonoBehaviour // TypeDefIndex: 6650
{
	// Fields
	private HumanItemHold.State m_State; // 0x18
	private HumanItemHold.State m_PrevState; // 0x1C
	private HumanItemHold.State m_ReserveState; // 0x20
	private const float RUCKINOUT_TIME = 0.2;
	private HumanController m_Human; // 0x28
	private HoldableInterface _HoldItem; // 0x30
	private float m_Elapsed; // 0x38
	public bool IsUnscaledTime; // 0x3C
	private HoldableInterface m_PickupItem; // 0x40
	private ItemInteractionInterface m_ItemInteractionTarget; // 0x48
	[SerializeField] // RVA: 0x15E610 Offset: 0x15E711 VA: 0x15E610
	private LayerMask m_PutOnLayer; // 0x50
	private Quaternion m_RotationOffset; // 0x54
	private Vector3 m_PositionOffset; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x15E620 Offset: 0x15E721 VA: 0x15E620
	private int <FurnitureRotateY>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x15E630 Offset: 0x15E731 VA: 0x15E630
	private HoldMotionType <CurrentHoldMotionType>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x15E640 Offset: 0x15E741 VA: 0x15E640
	private float <y_offset>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x15E650 Offset: 0x15E751 VA: 0x15E650
	private float <y_offset_yasai_head>k__BackingField; // 0x7C
	private HandCuffsController HandCuffsController; // 0x80

	// Properties
	private HumanStatus HumanStatus { get; }
	private HumanModel HumanModel { get; }
	public HoldableInterface HoldItem { get; }
	public ItemData HoldItemData { get; }
	public bool IsHold { get; }
	public int FurnitureRotateY { get; set; }
	private HoldMotionType CurrentHoldMotionType { get; set; }
	private float y_offset { get; set; }
	private float y_offset_yasai_head { get; set; }

	// Methods

	// RVA: 0x1E97730 Offset: 0x1E97831 VA: 0x1E97730
	private HumanStatus get_HumanStatus() { }

	// RVA: 0x1E977E0 Offset: 0x1E978E1 VA: 0x1E977E0
	private HumanModel get_HumanModel() { }

	// RVA: 0x1E978D0 Offset: 0x1E979D1 VA: 0x1E978D0
	public HoldableInterface get_HoldItem() { }

	// RVA: 0x1E978E0 Offset: 0x1E979E1 VA: 0x1E978E0
	private void SetHoldItem(HoldableInterface value) { }

	// RVA: 0x1E97B90 Offset: 0x1E97C91 VA: 0x1E97B90
	private void SetHoldItemWithItemData(HoldableInterface value) { }

	// RVA: 0x1E8CF90 Offset: 0x1E8D091 VA: 0x1E8CF90
	public ItemData get_HoldItemData() { }

	// RVA: 0x1E84830 Offset: 0x1E84931 VA: 0x1E84830
	public bool get_IsHold() { }

	// RVA: 0x1E97D10 Offset: 0x1E97E11 VA: 0x1E97D10
	public bool CanHold() { }

	// RVA: 0x1E97F00 Offset: 0x1E98001 VA: 0x1E97F00
	public bool CanGrapple() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C560 Offset: 0x19C661 VA: 0x19C560
	// RVA: 0x1E97F10 Offset: 0x1E98011 VA: 0x1E97F10
	public int get_FurnitureRotateY() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C570 Offset: 0x19C671 VA: 0x19C570
	// RVA: 0x1E97F20 Offset: 0x1E98021 VA: 0x1E97F20
	private void set_FurnitureRotateY(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C580 Offset: 0x19C681 VA: 0x19C580
	// RVA: 0x1E97F30 Offset: 0x1E98031 VA: 0x1E97F30
	private HoldMotionType get_CurrentHoldMotionType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C590 Offset: 0x19C691 VA: 0x19C590
	// RVA: 0x1E97F40 Offset: 0x1E98041 VA: 0x1E97F40
	private void set_CurrentHoldMotionType(HoldMotionType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C5A0 Offset: 0x19C6A1 VA: 0x19C5A0
	// RVA: 0x1E97F50 Offset: 0x1E98051 VA: 0x1E97F50
	private float get_y_offset() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C5B0 Offset: 0x19C6B1 VA: 0x19C5B0
	// RVA: 0x1E97F60 Offset: 0x1E98061 VA: 0x1E97F60
	private void set_y_offset(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C5C0 Offset: 0x19C6C1 VA: 0x19C5C0
	// RVA: 0x1E97F70 Offset: 0x1E98071 VA: 0x1E97F70
	private float get_y_offset_yasai_head() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C5D0 Offset: 0x19C6D1 VA: 0x19C5D0
	// RVA: 0x1E97F80 Offset: 0x1E98081 VA: 0x1E97F80
	private void set_y_offset_yasai_head(float value) { }

	// RVA: 0x1E8D100 Offset: 0x1E8D201 VA: 0x1E8D100
	public void Pickup(HoldableInterface holdableInterface) { }

	// RVA: 0x1E98230 Offset: 0x1E98331 VA: 0x1E98230
	public void Hold(HoldableInterface holdableInterface) { }

	// RVA: 0x1E984E0 Offset: 0x1E985E1 VA: 0x1E984E0
	public void Present(ItemInteractionInterface itemInteractionInterface) { }

	// RVA: 0x1E98510 Offset: 0x1E98611 VA: 0x1E98510
	public void PutIn(ItemInteractionInterface itemInteractionInterface) { }

	// RVA: 0x1E8D270 Offset: 0x1E8D371 VA: 0x1E8D270
	public bool CanPuton() { }

	// RVA: 0x1E8D360 Offset: 0x1E8D461 VA: 0x1E8D360
	public void Puton() { }

	// RVA: 0x1E8C530 Offset: 0x1E8C631 VA: 0x1E8C530
	public void RuckOut() { }

	// RVA: 0x1E8D7E0 Offset: 0x1E8D8E1 VA: 0x1E8D7E0
	public bool CanRuckIn() { }

	// RVA: 0x1E8D8B0 Offset: 0x1E8D9B1 VA: 0x1E8D8B0
	public void RuckIn() { }

	// RVA: 0x1E8D4D0 Offset: 0x1E8D5D1 VA: 0x1E8D4D0
	public bool CanThrow() { }

	// RVA: 0x1E8D5C0 Offset: 0x1E8D6C1 VA: 0x1E8D5C0
	public void Throw() { }

	// RVA: 0x1E8DCF0 Offset: 0x1E8DDF1 VA: 0x1E8DCF0
	public bool CanEatOrDrink() { }

	// RVA: 0x1E8DDD0 Offset: 0x1E8DED1 VA: 0x1E8DDD0
	public void EatOrDrink() { }

	// RVA: 0x1E98540 Offset: 0x1E98641 VA: 0x1E98540
	public void Drop() { }

	// RVA: 0x1E8BC50 Offset: 0x1E8BD51 VA: 0x1E8BC50
	public void UpdateHoldItem() { }

	// RVA: 0x1E98550 Offset: 0x1E98651 VA: 0x1E98550
	public bool CheckHoldItemAmount() { }

	// RVA: 0x1E98680 Offset: 0x1E98781 VA: 0x1E98680
	public bool EnableOpenMenu() { }

	// RVA: 0x1E986B0 Offset: 0x1E987B1 VA: 0x1E986B0
	public void ItemDestroy() { }

	// RVA: 0x1E98820 Offset: 0x1E98921 VA: 0x1E98820
	public void Clear() { }

	// RVA: 0x1E98910 Offset: 0x1E98A11 VA: 0x1E98910
	public void FurnitureRotate(bool rotate) { }

	// RVA: 0x1E989E0 Offset: 0x1E98AE1 VA: 0x1E989E0
	private bool IsChangeStateEnable() { }

	// RVA: 0x1E97F90 Offset: 0x1E98091 VA: 0x1E97F90
	private void ChangeState(HumanItemHold.State state) { }

	// RVA: 0x1E869C0 Offset: 0x1E86AC1 VA: 0x1E869C0
	public void UpdateState() { }

	// RVA: 0x1E98B40 Offset: 0x1E98C41 VA: 0x1E98B40
	private void NoHold_Enter() { }

	// RVA: 0x1E99D90 Offset: 0x1E99E91 VA: 0x1E99D90
	private void NoHold_Update() { }

	// RVA: 0x1E9A400 Offset: 0x1E9A501 VA: 0x1E9A400
	private void NoHold_LateUpdate() { }

	// RVA: 0x1E9A410 Offset: 0x1E9A511 VA: 0x1E9A410
	private void NoHold_AnimEvent(HumanItemHold.AnimEvent animEvent) { }

	// RVA: 0x1E9A420 Offset: 0x1E9A521 VA: 0x1E9A420
	private void UpdateOnGroundItemOffset(OnGroundItem onGroundItem) { }

	// RVA: 0x1E98B70 Offset: 0x1E98C71 VA: 0x1E98B70
	private void RuckOut_Enter() { }

	// RVA: 0x1E99DA0 Offset: 0x1E99EA1 VA: 0x1E99DA0
	private void RuckOut_Update() { }

	// RVA: 0x1E9AA50 Offset: 0x1E9AB51 VA: 0x1E9AA50
	private void RuckOut_LateUpdate() { }

	// RVA: 0x1E9AA60 Offset: 0x1E9AB61 VA: 0x1E9AA60
	private void RuckOut_AnimEvent(HumanItemHold.AnimEvent animEvent) { }

	// RVA: 0x1E98ED0 Offset: 0x1E98FD1 VA: 0x1E98ED0
	private void RuckIn_Enter() { }

	// RVA: 0x1E99F20 Offset: 0x1E9A021 VA: 0x1E99F20
	private void RuckIn_Update() { }

	// RVA: 0x1E9AB80 Offset: 0x1E9AC81 VA: 0x1E9AB80
	private void RuckIn_LateUpdate() { }

	// RVA: 0x1E9AB90 Offset: 0x1E9AC91 VA: 0x1E9AB90
	private void RuckIn_AnimEvent(HumanItemHold.AnimEvent animEvent) { }

	// RVA: 0x1E991E0 Offset: 0x1E992E1 VA: 0x1E991E0
	private void Pickup_Enter() { }

	// RVA: 0x1E9A0A0 Offset: 0x1E9A1A1 VA: 0x1E9A0A0
	private void Pickup_Update() { }

	// RVA: 0x1E9AF00 Offset: 0x1E9B001 VA: 0x1E9AF00
	private void Pickup_LateUpdate() { }

	// RVA: 0x1E9AF10 Offset: 0x1E9B011 VA: 0x1E9AF10
	private void Pickup_AnimEvent(HumanItemHold.AnimEvent animEvent) { }

	// RVA: 0x1E9B1C0 Offset: 0x1E9B2C1 VA: 0x1E9B1C0
	private int GetFurnitureR() { }

	// RVA: 0x1E99370 Offset: 0x1E99471 VA: 0x1E99370
	private void Puton_Enter() { }

	// RVA: 0x1E9A0B0 Offset: 0x1E9A1B1 VA: 0x1E9A0B0
	private void Puton_Update() { }

	// RVA: 0x1E9B510 Offset: 0x1E9B611 VA: 0x1E9B510
	private void Puton_LateUpdate() { }

	// RVA: 0x1E9B520 Offset: 0x1E9B621 VA: 0x1E9B520
	private void Puton_AnimEvent(HumanItemHold.AnimEvent animEvent) { }

	// RVA: 0x1E99500 Offset: 0x1E99601 VA: 0x1E99500
	private void Throw_Enter() { }

	// RVA: 0x1E9A0C0 Offset: 0x1E9A1C1 VA: 0x1E9A0C0
	private void Throw_Update() { }

	// RVA: 0x1E9C3F0 Offset: 0x1E9C4F1 VA: 0x1E9C3F0
	private void Throw_LateUpdate() { }

	// RVA: 0x1E9C400 Offset: 0x1E9C501 VA: 0x1E9C400
	private void Throw_AnimEvent(HumanItemHold.AnimEvent animEvent) { }

	// RVA: 0x1E99730 Offset: 0x1E99831 VA: 0x1E99730
	private void EatDrink_Enter() { }

	// RVA: 0x1E9A2D0 Offset: 0x1E9A3D1 VA: 0x1E9A2D0
	private void EatDrink_Update() { }

	// RVA: 0x1E9CB60 Offset: 0x1E9CC61 VA: 0x1E9CB60
	private void EatDrink_LateUpdate() { }

	// RVA: 0x1E9C700 Offset: 0x1E9C801 VA: 0x1E9C700
	private void EatDrink_AnimEvent(HumanItemHold.AnimEvent animEvent) { }

	// RVA: 0x1E999A0 Offset: 0x1E99AA1 VA: 0x1E999A0
	private void Hold_Enter() { }

	// RVA: 0x1E9A2E0 Offset: 0x1E9A3E1 VA: 0x1E9A2E0
	private void Hold_Update() { }

	// RVA: 0x1E9CCA0 Offset: 0x1E9CDA1 VA: 0x1E9CCA0
	private void Hold_LateUpdate() { }

	// RVA: 0x1E9CCB0 Offset: 0x1E9CDB1 VA: 0x1E9CCB0
	private void Hold_AnimEvent(HumanItemHold.AnimEvent animEvent) { }

	// RVA: 0x1E99CB0 Offset: 0x1E99DB1 VA: 0x1E99CB0
	private void Present_Enter() { }

	// RVA: 0x1E99D20 Offset: 0x1E99E21 VA: 0x1E99D20
	private void PutIn_Enter() { }

	// RVA: 0x1E9A3F0 Offset: 0x1E9A4F1 VA: 0x1E9A3F0
	private void Interaction_Update() { }

	// RVA: 0x1E9CCD0 Offset: 0x1E9CDD1 VA: 0x1E9CCD0
	private void Interaction_LateUpdate() { }

	// RVA: 0x1E9CCE0 Offset: 0x1E9CDE1 VA: 0x1E9CCE0
	private void Interaction_AnimEvent(HumanItemHold.AnimEvent animEvent) { }

	// RVA: 0x1E81BD0 Offset: 0x1E81CD1 VA: 0x1E81BD0
	public void OnAnimEvent(HumanItemHold.AnimEvent animEvent, HoldItemObserve observe) { }

	// RVA: 0x1E9CEB0 Offset: 0x1E9CFB1 VA: 0x1E9CEB0
	private void Awake() { }

	// RVA: 0x1E849F0 Offset: 0x1E84AF1 VA: 0x1E849F0
	public void Init(HumanController humanController) { }

	// RVA: 0x1E86EF0 Offset: 0x1E86FF1 VA: 0x1E86EF0
	public void SetVisible(bool visible) { }

	// RVA: 0x1E9CF10 Offset: 0x1E9D011 VA: 0x1E9CF10
	private void LateUpdate() { }

	// RVA: 0x1E9A620 Offset: 0x1E9A721 VA: 0x1E9A620
	private void UpdatePosition() { }

	// RVA: 0x1E89620 Offset: 0x1E89721 VA: 0x1E89620
	public bool OnTakeDamage(DamageResult damageResult) { }

	// RVA: 0x1E9CB70 Offset: 0x1E9CC71 VA: 0x1E9CB70
	public static void CheckWithCallTutorialADV(ItemData itemData) { }

	// RVA: 0x1E9CFA0 Offset: 0x1E9D0A1 VA: 0x1E9CFA0
	private void HoldOnGroundItemEvent() { }

	// RVA: 0x1E9CFB0 Offset: 0x1E9D0B1 VA: 0x1E9CFB0
	private void DoKeepItemEvent() { }

	// RVA: 0x1E9CFC0 Offset: 0x1E9D0C1 VA: 0x1E9CFC0
	private void HoldInventoryItemEvent() { }

	// RVA: 0x1E9CFD0 Offset: 0x1E9D0D1 VA: 0x1E9CFD0
	private void ThrowItemEvent() { }

	// RVA: 0x1E9CFE0 Offset: 0x1E9D0E1 VA: 0x1E9CFE0
	private void OnItemPutOnEvent() { }

	// RVA: 0x1E9CFF0 Offset: 0x1E9D0F1 VA: 0x1E9CFF0
	private void OnUseItem() { }

	// RVA: 0x1E9D000 Offset: 0x1E9D101 VA: 0x1E9D000
	public void .ctor() { }
}

