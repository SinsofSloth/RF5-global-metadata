[TaskCategoryAttribute] // RVA: 0x157230 Offset: 0x157331 VA: 0x157230
public class CharacterSeek : Action // TypeDefIndex: 11442
{
	// Fields
	private const float CalcPathSqrRange = 90;
	private readonly List<Vector3> CheckTargetAroundPointList; // 0x50
	[TooltipAttribute] // RVA: 0x195030 Offset: 0x195131 VA: 0x195030
	public SharedGameObject target; // 0x58
	[TooltipAttribute] // RVA: 0x195070 Offset: 0x195171 VA: 0x195070
	public SharedVector3 targetPosition; // 0x60
	public SharedBool IsRotate; // 0x68
	[TooltipAttribute] // RVA: 0x1950B0 Offset: 0x1951B1 VA: 0x1950B0
	public SharedFloat MoveSpeedScale; // 0x70
	public SharedFloat ArriveDistance; // 0x78
	public bool IsClearVelocity; // 0x80
	private AIInput AIInput; // 0x88
	public static string MoveSpeedScaleKey; // 0x0
	private Vector3 LatestSteeringTarget; // 0x90
	private NavMeshHit TargetNavMeshHit; // 0x9C
	private NavMeshPath CalcNavMeshPath; // 0xC0

	// Methods

	// RVA: 0x20E2EA0 Offset: 0x20E2FA1 VA: 0x20E2EA0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20E2F90 Offset: 0x20E3091 VA: 0x20E2F90 Slot: 5
	public override void OnStart() { }

	// RVA: 0x20E34A0 Offset: 0x20E35A1 VA: 0x20E34A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E3840 Offset: 0x20E3941 VA: 0x20E3840 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E3910 Offset: 0x20E3A11 VA: 0x20E3910
	private bool IsUpdatePath() { }

	// RVA: 0x20E3190 Offset: 0x20E3291 VA: 0x20E3190
	private Vector3 Target() { }

	// RVA: 0x20E39C0 Offset: 0x20E3AC1 VA: 0x20E39C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E3710 Offset: 0x20E3811 VA: 0x20E3710
	private bool HasArrived() { }

	// RVA: 0x20E3B00 Offset: 0x20E3C01 VA: 0x20E3B00
	public void .ctor() { }

	// RVA: 0x20E3DA0 Offset: 0x20E3EA1 VA: 0x20E3DA0
	private static void .cctor() { }
}

