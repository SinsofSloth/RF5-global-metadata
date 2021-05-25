public class PartnerMovementController // TypeDefIndex: 6764
{
	// Fields
	private const float RangeMargin = 0.125;
	private AIInput AIInput; // 0x10
	private PartnerMovementController.StatusType CurrentStatusType; // 0x18
	private HumanStatusData HumanStatusData; // 0x20
	private EnemyStatusData HandCuffsMonsterStatusData; // 0x28
	private FriendMonsterStatusData MonsterStatusData; // 0x30
	private PartnerMovementOrderType PreviousOrderType; // 0x38
	private float CloseRange; // 0x3C
	private float LeaveRange; // 0x40
	private NavMeshPath CalcPath; // 0x48
	private Vector3[] CalcCorners; // 0x50

	// Methods

	// RVA: 0x1FD8BE0 Offset: 0x1FD8CE1 VA: 0x1FD8BE0
	public void .ctor(PartnerNPCBehaviorController controller) { }

	// RVA: 0x1FD8E10 Offset: 0x1FD8F11 VA: 0x1FD8E10
	public void .ctor(PartnerMonsterBehaviorController controller) { }

	// RVA: 0x1FD9090 Offset: 0x1FD9191 VA: 0x1FD9090
	public bool IsChangeMovementOrderType() { }

	// RVA: 0x1FD90F0 Offset: 0x1FD91F1 VA: 0x1FD90F0
	public PartnerMovementOrderType GetMovementOrderType(bool isUpdatePrevious = False) { }

	// RVA: 0x1FD9160 Offset: 0x1FD9261 VA: 0x1FD9160
	private float GetMoveRangeByMovementOrder(PartnerMovementOrderType orderType) { }

	// RVA: 0x1FD9190 Offset: 0x1FD9291 VA: 0x1FD9190
	public float CalcMargin(float range) { }

	// RVA: 0x1FD91A0 Offset: 0x1FD92A1 VA: 0x1FD91A0
	public bool TryGetMovementInformation(PartnerMovementOrderType orderType, out PartnerMovementController.MovementInformation info) { }

	// RVA: 0x1FD9510 Offset: 0x1FD9611 VA: 0x1FD9510
	public Vector3 GetLeavePosition() { }
}

