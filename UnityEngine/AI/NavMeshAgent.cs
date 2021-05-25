[NativeHeaderAttribute] // RVA: 0x1090C0 Offset: 0x1091C1 VA: 0x1090C0
[MovedFromAttribute] // RVA: 0x1090C0 Offset: 0x1091C1 VA: 0x1090C0
[NativeHeaderAttribute] // RVA: 0x1090C0 Offset: 0x1091C1 VA: 0x1090C0
public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 3770
{
	// Properties
	public Vector3 destination { get; set; }
	public float stoppingDistance { get; set; }
	public Vector3 velocity { get; set; }
	[NativePropertyAttribute] // RVA: 0x10A2A0 Offset: 0x10A3A1 VA: 0x10A2A0
	public Vector3 nextPosition { get; set; }
	public Vector3 steeringTarget { get; }
	public Vector3 desiredVelocity { get; }
	public float remainingDistance { get; }
	public float baseOffset { get; set; }
	public bool isOnOffMeshLink { get; }
	public OffMeshLinkData currentOffMeshLinkData { get; }
	public OffMeshLinkData nextOffMeshLinkData { get; }
	public bool autoTraverseOffMeshLink { get; set; }
	public bool autoBraking { get; set; }
	public bool autoRepath { get; set; }
	public bool hasPath { get; }
	public bool pathPending { get; }
	public bool isPathStale { get; }
	public NavMeshPathStatus pathStatus { get; }
	[NativePropertyAttribute] // RVA: 0x10A2E0 Offset: 0x10A3E1 VA: 0x10A2E0
	public Vector3 pathEndPosition { get; }
	public bool isStopped { get; set; }
	public NavMeshPath path { get; set; }
	public Object navMeshOwner { get; }
	public int agentTypeID { get; set; }
	[ObsoleteAttribute] // RVA: 0x10A320 Offset: 0x10A421 VA: 0x10A320
	public int walkableMask { get; set; }
	public int areaMask { get; set; }
	public float speed { get; set; }
	public float angularSpeed { get; set; }
	public float acceleration { get; set; }
	public bool updatePosition { get; set; }
	public bool updateRotation { get; set; }
	public bool updateUpAxis { get; set; }
	public float radius { get; set; }
	public float height { get; set; }
	public ObstacleAvoidanceType obstacleAvoidanceType { get; set; }
	public int avoidancePriority { get; set; }
	public bool isOnNavMesh { get; }

	// Methods

	// RVA: 0x1BAC1D0 Offset: 0x1BAC2D1 VA: 0x1BAC1D0
	public bool SetDestination(Vector3 target) { }

	// RVA: 0x1BAC280 Offset: 0x1BAC381 VA: 0x1BAC280
	public Vector3 get_destination() { }

	// RVA: 0x1BAC330 Offset: 0x1BAC431 VA: 0x1BAC330
	public void set_destination(Vector3 value) { }

	// RVA: 0x1BAC3E0 Offset: 0x1BAC4E1 VA: 0x1BAC3E0
	public float get_stoppingDistance() { }

	// RVA: 0x1BAC430 Offset: 0x1BAC531 VA: 0x1BAC430
	public void set_stoppingDistance(float value) { }

	// RVA: 0x1BAC480 Offset: 0x1BAC581 VA: 0x1BAC480
	public Vector3 get_velocity() { }

	// RVA: 0x1BAC530 Offset: 0x1BAC631 VA: 0x1BAC530
	public void set_velocity(Vector3 value) { }

	// RVA: 0x1BAC5E0 Offset: 0x1BAC6E1 VA: 0x1BAC5E0
	public Vector3 get_nextPosition() { }

	// RVA: 0x1BAC690 Offset: 0x1BAC791 VA: 0x1BAC690
	public void set_nextPosition(Vector3 value) { }

	// RVA: 0x1BAC740 Offset: 0x1BAC841 VA: 0x1BAC740
	public Vector3 get_steeringTarget() { }

	// RVA: 0x1BAC7F0 Offset: 0x1BAC8F1 VA: 0x1BAC7F0
	public Vector3 get_desiredVelocity() { }

	// RVA: 0x1BAC8A0 Offset: 0x1BAC9A1 VA: 0x1BAC8A0
	public float get_remainingDistance() { }

	// RVA: 0x1BAC8F0 Offset: 0x1BAC9F1 VA: 0x1BAC8F0
	public float get_baseOffset() { }

	// RVA: 0x1BAC940 Offset: 0x1BACA41 VA: 0x1BAC940
	public void set_baseOffset(float value) { }

	[NativeNameAttribute] // RVA: 0x109790 Offset: 0x109891 VA: 0x109790
	// RVA: 0x1BAC990 Offset: 0x1BACA91 VA: 0x1BAC990
	public bool get_isOnOffMeshLink() { }

	// RVA: 0x1BAC9E0 Offset: 0x1BACAE1 VA: 0x1BAC9E0
	public void ActivateCurrentOffMeshLink(bool activated) { }

	// RVA: 0x1BACA30 Offset: 0x1BACB31 VA: 0x1BACA30
	public OffMeshLinkData get_currentOffMeshLinkData() { }

	[FreeFunctionAttribute] // RVA: 0x1097D0 Offset: 0x1098D1 VA: 0x1097D0
	// RVA: 0x1BACAB0 Offset: 0x1BACBB1 VA: 0x1BACAB0
	internal OffMeshLinkData GetCurrentOffMeshLinkDataInternal() { }

	// RVA: 0x1BACB80 Offset: 0x1BACC81 VA: 0x1BACB80
	public OffMeshLinkData get_nextOffMeshLinkData() { }

	[FreeFunctionAttribute] // RVA: 0x109820 Offset: 0x109921 VA: 0x109820
	// RVA: 0x1BACC00 Offset: 0x1BACD01 VA: 0x1BACC00
	internal OffMeshLinkData GetNextOffMeshLinkDataInternal() { }

	// RVA: 0x1BACCD0 Offset: 0x1BACDD1 VA: 0x1BACCD0
	public void CompleteOffMeshLink() { }

	// RVA: 0x1BACD20 Offset: 0x1BACE21 VA: 0x1BACD20
	public bool get_autoTraverseOffMeshLink() { }

	// RVA: 0x1BACD70 Offset: 0x1BACE71 VA: 0x1BACD70
	public void set_autoTraverseOffMeshLink(bool value) { }

	// RVA: 0x1BACDC0 Offset: 0x1BACEC1 VA: 0x1BACDC0
	public bool get_autoBraking() { }

	// RVA: 0x1BACE10 Offset: 0x1BACF11 VA: 0x1BACE10
	public void set_autoBraking(bool value) { }

	// RVA: 0x1BACE60 Offset: 0x1BACF61 VA: 0x1BACE60
	public bool get_autoRepath() { }

	// RVA: 0x1BACEB0 Offset: 0x1BACFB1 VA: 0x1BACEB0
	public void set_autoRepath(bool value) { }

	[NativeNameAttribute] // RVA: 0x109870 Offset: 0x109971 VA: 0x109870
	// RVA: 0x1BACF00 Offset: 0x1BAD001 VA: 0x1BACF00
	public bool get_hasPath() { }

	[NativeNameAttribute] // RVA: 0x1098B0 Offset: 0x1099B1 VA: 0x1098B0
	// RVA: 0x1BACF50 Offset: 0x1BAD051 VA: 0x1BACF50
	public bool get_pathPending() { }

	[NativeNameAttribute] // RVA: 0x1098F0 Offset: 0x1099F1 VA: 0x1098F0
	// RVA: 0x1BACFA0 Offset: 0x1BAD0A1 VA: 0x1BACFA0
	public bool get_isPathStale() { }

	// RVA: 0x1BACFF0 Offset: 0x1BAD0F1 VA: 0x1BACFF0
	public NavMeshPathStatus get_pathStatus() { }

	// RVA: 0x1BAD040 Offset: 0x1BAD141 VA: 0x1BAD040
	public Vector3 get_pathEndPosition() { }

	// RVA: 0x1BAD0F0 Offset: 0x1BAD1F1 VA: 0x1BAD0F0
	public bool Warp(Vector3 newPosition) { }

	// RVA: 0x1BAD1A0 Offset: 0x1BAD2A1 VA: 0x1BAD1A0
	public void Move(Vector3 offset) { }

	[ObsoleteAttribute] // RVA: 0x109930 Offset: 0x109A31 VA: 0x109930
	// RVA: 0x1BAD250 Offset: 0x1BAD351 VA: 0x1BAD250
	public void Stop() { }

	[ObsoleteAttribute] // RVA: 0x109970 Offset: 0x109A71 VA: 0x109970
	// RVA: 0x1BAD2A0 Offset: 0x1BAD3A1 VA: 0x1BAD2A0
	public void Stop(bool stopUpdates) { }

	[ObsoleteAttribute] // RVA: 0x1099B0 Offset: 0x109AB1 VA: 0x1099B0
	// RVA: 0x1BAD2F0 Offset: 0x1BAD3F1 VA: 0x1BAD2F0
	public void Resume() { }

	[FreeFunctionAttribute] // RVA: 0x1099F0 Offset: 0x109AF1 VA: 0x1099F0
	// RVA: 0x1BAD340 Offset: 0x1BAD441 VA: 0x1BAD340
	public bool get_isStopped() { }

	[FreeFunctionAttribute] // RVA: 0x109A40 Offset: 0x109B41 VA: 0x109A40
	// RVA: 0x1BAD390 Offset: 0x1BAD491 VA: 0x1BAD390
	public void set_isStopped(bool value) { }

	// RVA: 0x1BAD3E0 Offset: 0x1BAD4E1 VA: 0x1BAD3E0
	public void ResetPath() { }

	// RVA: 0x1BAD430 Offset: 0x1BAD531 VA: 0x1BAD430
	public bool SetPath(NavMeshPath path) { }

	// RVA: 0x1BAD480 Offset: 0x1BAD581 VA: 0x1BAD480
	public NavMeshPath get_path() { }

	// RVA: 0x1BAD5E0 Offset: 0x1BAD6E1 VA: 0x1BAD5E0
	public void set_path(NavMeshPath value) { }

	[NativeMethodAttribute] // RVA: 0x109A90 Offset: 0x109B91 VA: 0x109A90
	// RVA: 0x1BAD590 Offset: 0x1BAD691 VA: 0x1BAD590
	internal void CopyPathTo(NavMeshPath path) { }

	[NativeNameAttribute] // RVA: 0x109AD0 Offset: 0x109BD1 VA: 0x109AD0
	// RVA: 0x1BAD690 Offset: 0x1BAD791 VA: 0x1BAD690
	public bool FindClosestEdge(out NavMeshHit hit) { }

	// RVA: 0x1BAD6E0 Offset: 0x1BAD7E1 VA: 0x1BAD6E0
	public bool Raycast(Vector3 targetPosition, out NavMeshHit hit) { }

	// RVA: 0x1BAD7B0 Offset: 0x1BAD8B1 VA: 0x1BAD7B0
	public bool CalculatePath(Vector3 targetPosition, NavMeshPath path) { }

	[FreeFunctionAttribute] // RVA: 0x109B10 Offset: 0x109C11 VA: 0x109B10
	// RVA: 0x1BAD880 Offset: 0x1BAD981 VA: 0x1BAD880
	private bool CalculatePathInternal(Vector3 targetPosition, NavMeshPath path) { }

	// RVA: 0x1BAD950 Offset: 0x1BADA51 VA: 0x1BAD950
	public bool SamplePathPosition(int areaMask, float maxDistance, out NavMeshHit hit) { }

	[ObsoleteAttribute] // RVA: 0x109B60 Offset: 0x109C61 VA: 0x109B60
	[NativeMethodAttribute] // RVA: 0x109B60 Offset: 0x109C61 VA: 0x109B60
	// RVA: 0x1BAD9C0 Offset: 0x1BADAC1 VA: 0x1BAD9C0
	public void SetLayerCost(int layer, float cost) { }

	[ObsoleteAttribute] // RVA: 0x109BC0 Offset: 0x109CC1 VA: 0x109BC0
	[NativeMethodAttribute] // RVA: 0x109BC0 Offset: 0x109CC1 VA: 0x109BC0
	// RVA: 0x1BADA20 Offset: 0x1BADB21 VA: 0x1BADA20
	public float GetLayerCost(int layer) { }

	// RVA: 0x1BADA70 Offset: 0x1BADB71 VA: 0x1BADA70
	public void SetAreaCost(int areaIndex, float areaCost) { }

	// RVA: 0x1BADAD0 Offset: 0x1BADBD1 VA: 0x1BADAD0
	public float GetAreaCost(int areaIndex) { }

	// RVA: 0x1BADB20 Offset: 0x1BADC21 VA: 0x1BADB20
	public Object get_navMeshOwner() { }

	// RVA: 0x1BADBC0 Offset: 0x1BADCC1 VA: 0x1BADBC0
	public int get_agentTypeID() { }

	// RVA: 0x1BADC10 Offset: 0x1BADD11 VA: 0x1BADC10
	public void set_agentTypeID(int value) { }

	[NativeNameAttribute] // RVA: 0x109C20 Offset: 0x109D21 VA: 0x109C20
	// RVA: 0x1BADB70 Offset: 0x1BADC71 VA: 0x1BADB70
	private Object GetOwnerInternal() { }

	// RVA: 0x1BADC60 Offset: 0x1BADD61 VA: 0x1BADC60
	public int get_walkableMask() { }

	// RVA: 0x1BADD00 Offset: 0x1BADE01 VA: 0x1BADD00
	public void set_walkableMask(int value) { }

	// RVA: 0x1BADCB0 Offset: 0x1BADDB1 VA: 0x1BADCB0
	public int get_areaMask() { }

	// RVA: 0x1BADD50 Offset: 0x1BADE51 VA: 0x1BADD50
	public void set_areaMask(int value) { }

	// RVA: 0x1BADDA0 Offset: 0x1BADEA1 VA: 0x1BADDA0
	public float get_speed() { }

	// RVA: 0x1BADDF0 Offset: 0x1BADEF1 VA: 0x1BADDF0
	public void set_speed(float value) { }

	// RVA: 0x1BADE40 Offset: 0x1BADF41 VA: 0x1BADE40
	public float get_angularSpeed() { }

	// RVA: 0x1BADE90 Offset: 0x1BADF91 VA: 0x1BADE90
	public void set_angularSpeed(float value) { }

	// RVA: 0x1BADEE0 Offset: 0x1BADFE1 VA: 0x1BADEE0
	public float get_acceleration() { }

	// RVA: 0x1BADF30 Offset: 0x1BAE031 VA: 0x1BADF30
	public void set_acceleration(float value) { }

	// RVA: 0x1BADF80 Offset: 0x1BAE081 VA: 0x1BADF80
	public bool get_updatePosition() { }

	// RVA: 0x1BADFD0 Offset: 0x1BAE0D1 VA: 0x1BADFD0
	public void set_updatePosition(bool value) { }

	// RVA: 0x1BAE020 Offset: 0x1BAE121 VA: 0x1BAE020
	public bool get_updateRotation() { }

	// RVA: 0x1BAE070 Offset: 0x1BAE171 VA: 0x1BAE070
	public void set_updateRotation(bool value) { }

	// RVA: 0x1BAE0C0 Offset: 0x1BAE1C1 VA: 0x1BAE0C0
	public bool get_updateUpAxis() { }

	// RVA: 0x1BAE110 Offset: 0x1BAE211 VA: 0x1BAE110
	public void set_updateUpAxis(bool value) { }

	// RVA: 0x1BAE160 Offset: 0x1BAE261 VA: 0x1BAE160
	public float get_radius() { }

	// RVA: 0x1BAE1B0 Offset: 0x1BAE2B1 VA: 0x1BAE1B0
	public void set_radius(float value) { }

	// RVA: 0x1BAE200 Offset: 0x1BAE301 VA: 0x1BAE200
	public float get_height() { }

	// RVA: 0x1BAE250 Offset: 0x1BAE351 VA: 0x1BAE250
	public void set_height(float value) { }

	// RVA: 0x1BAE2A0 Offset: 0x1BAE3A1 VA: 0x1BAE2A0
	public ObstacleAvoidanceType get_obstacleAvoidanceType() { }

	// RVA: 0x1BAE2F0 Offset: 0x1BAE3F1 VA: 0x1BAE2F0
	public void set_obstacleAvoidanceType(ObstacleAvoidanceType value) { }

	// RVA: 0x1BAE340 Offset: 0x1BAE441 VA: 0x1BAE340
	public int get_avoidancePriority() { }

	// RVA: 0x1BAE390 Offset: 0x1BAE491 VA: 0x1BAE390
	public void set_avoidancePriority(int value) { }

	[NativeNameAttribute] // RVA: 0x109C60 Offset: 0x109D61 VA: 0x109C60
	// RVA: 0x1BAE3E0 Offset: 0x1BAE4E1 VA: 0x1BAE3E0
	public bool get_isOnNavMesh() { }

	// RVA: 0x1BAE430 Offset: 0x1BAE531 VA: 0x1BAE430
	public void .ctor() { }

	// RVA: 0x1BAC230 Offset: 0x1BAC331 VA: 0x1BAC230
	private bool SetDestination_Injected(ref Vector3 target) { }

	// RVA: 0x1BAC2E0 Offset: 0x1BAC3E1 VA: 0x1BAC2E0
	private void get_destination_Injected(out Vector3 ret) { }

	// RVA: 0x1BAC390 Offset: 0x1BAC491 VA: 0x1BAC390
	private void set_destination_Injected(ref Vector3 value) { }

	// RVA: 0x1BAC4E0 Offset: 0x1BAC5E1 VA: 0x1BAC4E0
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x1BAC590 Offset: 0x1BAC691 VA: 0x1BAC590
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x1BAC640 Offset: 0x1BAC741 VA: 0x1BAC640
	private void get_nextPosition_Injected(out Vector3 ret) { }

	// RVA: 0x1BAC6F0 Offset: 0x1BAC7F1 VA: 0x1BAC6F0
	private void set_nextPosition_Injected(ref Vector3 value) { }

	// RVA: 0x1BAC7A0 Offset: 0x1BAC8A1 VA: 0x1BAC7A0
	private void get_steeringTarget_Injected(out Vector3 ret) { }

	// RVA: 0x1BAC850 Offset: 0x1BAC951 VA: 0x1BAC850
	private void get_desiredVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x1BACB30 Offset: 0x1BACC31 VA: 0x1BACB30
	private void GetCurrentOffMeshLinkDataInternal_Injected(out OffMeshLinkData ret) { }

	// RVA: 0x1BACC80 Offset: 0x1BACD81 VA: 0x1BACC80
	private void GetNextOffMeshLinkDataInternal_Injected(out OffMeshLinkData ret) { }

	// RVA: 0x1BAD0A0 Offset: 0x1BAD1A1 VA: 0x1BAD0A0
	private void get_pathEndPosition_Injected(out Vector3 ret) { }

	// RVA: 0x1BAD150 Offset: 0x1BAD251 VA: 0x1BAD150
	private bool Warp_Injected(ref Vector3 newPosition) { }

	// RVA: 0x1BAD200 Offset: 0x1BAD301 VA: 0x1BAD200
	private void Move_Injected(ref Vector3 offset) { }

	// RVA: 0x1BAD750 Offset: 0x1BAD851 VA: 0x1BAD750
	private bool Raycast_Injected(ref Vector3 targetPosition, out NavMeshHit hit) { }

	// RVA: 0x1BAD8F0 Offset: 0x1BAD9F1 VA: 0x1BAD8F0
	private bool CalculatePathInternal_Injected(ref Vector3 targetPosition, NavMeshPath path) { }
}

