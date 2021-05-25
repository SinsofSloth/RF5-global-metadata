public class PlayerInteractionCollider : SingletonMonoBehaviour<PlayerInteractionCollider> // TypeDefIndex: 6780
{
	// Fields
	[SerializeField] // RVA: 0x15F6E0 Offset: 0x15F7E1 VA: 0x15F6E0
	private InteractionCollider m_InteractionCollider; // 0x18
	[SerializeField] // RVA: 0x15F6F0 Offset: 0x15F7F1 VA: 0x15F6F0
	private OnGroundItemPickupCollider m_OnGroundItemPickupCollider; // 0x20
	[SerializeField] // RVA: 0x15F700 Offset: 0x15F801 VA: 0x15F700
	private FarmChargeInteraction m_FarmChargeInteraction; // 0x28
	[SerializeField] // RVA: 0x15F710 Offset: 0x15F811 VA: 0x15F710
	private BoxCollider m_FarmRapidCollider; // 0x30
	[SerializeField] // RVA: 0x15F720 Offset: 0x15F821 VA: 0x15F720
	private SymbolFieldInteractionCollider m_SymbolFieldInteractionCollider; // 0x38
	[TupleElementNamesAttribute] // RVA: 0x15F730 Offset: 0x15F831 VA: 0x15F730
	private static readonly ValueTuple<Vector3, Quaternion>[] FarmColliderRotations; // 0x0

	// Properties
	public BoxCollider FarmRapidCollider { get; }
	public static InteractionCollider InteractionCollider { get; }
	public static OnGroundItemPickupCollider OnGroundItemPickupCollider { get; }
	public static SymbolFieldInteractionCollider SymbolFieldInteractionCollider { get; }

	// Methods

	// RVA: 0x21FE0A0 Offset: 0x21FE1A1 VA: 0x21FE0A0
	public BoxCollider get_FarmRapidCollider() { }

	// RVA: 0x21FE0B0 Offset: 0x21FE1B1 VA: 0x21FE0B0
	public static InteractionCollider get_InteractionCollider() { }

	// RVA: 0x21FE110 Offset: 0x21FE211 VA: 0x21FE110
	public static OnGroundItemPickupCollider get_OnGroundItemPickupCollider() { }

	// RVA: 0x21FE170 Offset: 0x21FE271 VA: 0x21FE170
	public static SymbolFieldInteractionCollider get_SymbolFieldInteractionCollider() { }

	// RVA: 0x21FE1D0 Offset: 0x21FE2D1 VA: 0x21FE1D0
	private void FixedUpdate() { }

	// RVA: 0x21FE1E0 Offset: 0x21FE2E1 VA: 0x21FE1E0
	private void DoUpdate() { }

	// RVA: 0x21FEEE0 Offset: 0x21FEFE1 VA: 0x21FEEE0
	public static bool CanInteraction(HumanController human) { }

	// RVA: 0x21FF050 Offset: 0x21FF151 VA: 0x21FF050
	public static void DoInteraction(HumanController human) { }

	// RVA: 0x21FF230 Offset: 0x21FF331 VA: 0x21FF230
	public static bool CanInteraction(MonsterControllerBase monster) { }

	// RVA: 0x21FF3A0 Offset: 0x21FF4A1 VA: 0x21FF3A0
	public static void DoInteraction(MonsterControllerBase monster) { }

	// RVA: 0x21FF580 Offset: 0x21FF681 VA: 0x21FF580
	public static bool CanItemInteraction(HumanController human) { }

	// RVA: 0x21FF6F0 Offset: 0x21FF7F1 VA: 0x21FF6F0
	public static bool CanRapidItemInteraction(HumanController human) { }

	// RVA: 0x21FF860 Offset: 0x21FF961 VA: 0x21FF860
	public static void DoItemInteraction(HumanController human) { }

	// RVA: 0x21FED60 Offset: 0x21FEE61 VA: 0x21FED60
	private int FindClosestRotationIndex(Vector3 vector) { }

	// RVA: 0x21FFA70 Offset: 0x21FFB71 VA: 0x21FFA70
	public void .ctor() { }

	// RVA: 0x21FFAC0 Offset: 0x21FFBC1 VA: 0x21FFAC0
	private static void .cctor() { }
}

