[NativeHeaderAttribute] // RVA: 0xE1030 Offset: 0xE1131 VA: 0xE1030
[RequireComponent] // RVA: 0xE1030 Offset: 0xE1131 VA: 0xE1030
public class Rigidbody : Component // TypeDefIndex: 3429
{
	// Properties
	public Vector3 velocity { get; set; }
	public Vector3 angularVelocity { get; set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public float mass { get; set; }
	public bool useGravity { get; set; }
	public float maxDepenetrationVelocity { get; set; }
	public bool isKinematic { get; set; }
	public bool freezeRotation { get; set; }
	public RigidbodyConstraints constraints { get; set; }
	public CollisionDetectionMode collisionDetectionMode { get; set; }
	public Vector3 centerOfMass { get; set; }
	public Vector3 worldCenterOfMass { get; }
	public Quaternion inertiaTensorRotation { get; set; }
	public Vector3 inertiaTensor { get; set; }
	public bool detectCollisions { get; set; }
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public RigidbodyInterpolation interpolation { get; set; }
	public int solverIterations { get; set; }
	public float sleepThreshold { get; set; }
	public float maxAngularVelocity { get; set; }
	public int solverVelocityIterations { get; set; }
	[ObsoleteAttribute] // RVA: 0xE44F0 Offset: 0xE45F1 VA: 0xE44F0
	public float sleepVelocity { get; set; }
	[ObsoleteAttribute] // RVA: 0xE4530 Offset: 0xE4631 VA: 0xE4530
	public float sleepAngularVelocity { get; set; }
	[ObsoleteAttribute] // RVA: 0xE4570 Offset: 0xE4671 VA: 0xE4570
	public bool useConeFriction { get; set; }
	[ObsoleteAttribute] // RVA: 0xE45B0 Offset: 0xE46B1 VA: 0xE45B0
	public int solverIterationCount { get; set; }
	[ObsoleteAttribute] // RVA: 0xE45F0 Offset: 0xE46F1 VA: 0xE45F0
	public int solverVelocityIterationCount { get; set; }

	// Methods

	// RVA: 0x3513260 Offset: 0x3513361 VA: 0x3513260
	public Vector3 get_velocity() { }

	// RVA: 0x3513310 Offset: 0x3513411 VA: 0x3513310
	public void set_velocity(Vector3 value) { }

	// RVA: 0x35133C0 Offset: 0x35134C1 VA: 0x35133C0
	public Vector3 get_angularVelocity() { }

	// RVA: 0x3513470 Offset: 0x3513571 VA: 0x3513470
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x3513520 Offset: 0x3513621 VA: 0x3513520
	public float get_drag() { }

	// RVA: 0x3513570 Offset: 0x3513671 VA: 0x3513570
	public void set_drag(float value) { }

	// RVA: 0x35135C0 Offset: 0x35136C1 VA: 0x35135C0
	public float get_angularDrag() { }

	// RVA: 0x3513610 Offset: 0x3513711 VA: 0x3513610
	public void set_angularDrag(float value) { }

	// RVA: 0x3513660 Offset: 0x3513761 VA: 0x3513660
	public float get_mass() { }

	// RVA: 0x35136B0 Offset: 0x35137B1 VA: 0x35136B0
	public void set_mass(float value) { }

	// RVA: 0x3513700 Offset: 0x3513801 VA: 0x3513700
	public void SetDensity(float density) { }

	// RVA: 0x3513750 Offset: 0x3513851 VA: 0x3513750
	public bool get_useGravity() { }

	// RVA: 0x35137A0 Offset: 0x35138A1 VA: 0x35137A0
	public void set_useGravity(bool value) { }

	// RVA: 0x35137F0 Offset: 0x35138F1 VA: 0x35137F0
	public float get_maxDepenetrationVelocity() { }

	// RVA: 0x3513840 Offset: 0x3513941 VA: 0x3513840
	public void set_maxDepenetrationVelocity(float value) { }

	// RVA: 0x3513890 Offset: 0x3513991 VA: 0x3513890
	public bool get_isKinematic() { }

	// RVA: 0x35138E0 Offset: 0x35139E1 VA: 0x35138E0
	public void set_isKinematic(bool value) { }

	// RVA: 0x3513930 Offset: 0x3513A31 VA: 0x3513930
	public bool get_freezeRotation() { }

	// RVA: 0x3513980 Offset: 0x3513A81 VA: 0x3513980
	public void set_freezeRotation(bool value) { }

	// RVA: 0x35139D0 Offset: 0x3513AD1 VA: 0x35139D0
	public RigidbodyConstraints get_constraints() { }

	// RVA: 0x3513A20 Offset: 0x3513B21 VA: 0x3513A20
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x3513A70 Offset: 0x3513B71 VA: 0x3513A70
	public CollisionDetectionMode get_collisionDetectionMode() { }

	// RVA: 0x3513AC0 Offset: 0x3513BC1 VA: 0x3513AC0
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x3513B10 Offset: 0x3513C11 VA: 0x3513B10
	public Vector3 get_centerOfMass() { }

	// RVA: 0x3513BC0 Offset: 0x3513CC1 VA: 0x3513BC0
	public void set_centerOfMass(Vector3 value) { }

	// RVA: 0x3513C70 Offset: 0x3513D71 VA: 0x3513C70
	public Vector3 get_worldCenterOfMass() { }

	// RVA: 0x3513D20 Offset: 0x3513E21 VA: 0x3513D20
	public Quaternion get_inertiaTensorRotation() { }

	// RVA: 0x3513DD0 Offset: 0x3513ED1 VA: 0x3513DD0
	public void set_inertiaTensorRotation(Quaternion value) { }

	// RVA: 0x3513E80 Offset: 0x3513F81 VA: 0x3513E80
	public Vector3 get_inertiaTensor() { }

	// RVA: 0x3513F30 Offset: 0x3514031 VA: 0x3513F30
	public void set_inertiaTensor(Vector3 value) { }

	// RVA: 0x3513FE0 Offset: 0x35140E1 VA: 0x3513FE0
	public bool get_detectCollisions() { }

	// RVA: 0x3514030 Offset: 0x3514131 VA: 0x3514030
	public void set_detectCollisions(bool value) { }

	// RVA: 0x3514080 Offset: 0x3514181 VA: 0x3514080
	public Vector3 get_position() { }

	// RVA: 0x3514130 Offset: 0x3514231 VA: 0x3514130
	public void set_position(Vector3 value) { }

	// RVA: 0x35141E0 Offset: 0x35142E1 VA: 0x35141E0
	public Quaternion get_rotation() { }

	// RVA: 0x3514290 Offset: 0x3514391 VA: 0x3514290
	public void set_rotation(Quaternion value) { }

	// RVA: 0x3514340 Offset: 0x3514441 VA: 0x3514340
	public RigidbodyInterpolation get_interpolation() { }

	// RVA: 0x3514390 Offset: 0x3514491 VA: 0x3514390
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x35143E0 Offset: 0x35144E1 VA: 0x35143E0
	public int get_solverIterations() { }

	// RVA: 0x3514430 Offset: 0x3514531 VA: 0x3514430
	public void set_solverIterations(int value) { }

	// RVA: 0x3514480 Offset: 0x3514581 VA: 0x3514480
	public float get_sleepThreshold() { }

	// RVA: 0x35144D0 Offset: 0x35145D1 VA: 0x35144D0
	public void set_sleepThreshold(float value) { }

	// RVA: 0x3514520 Offset: 0x3514621 VA: 0x3514520
	public float get_maxAngularVelocity() { }

	// RVA: 0x3514570 Offset: 0x3514671 VA: 0x3514570
	public void set_maxAngularVelocity(float value) { }

	// RVA: 0x35145C0 Offset: 0x35146C1 VA: 0x35145C0
	public void MovePosition(Vector3 position) { }

	// RVA: 0x3514670 Offset: 0x3514771 VA: 0x3514670
	public void MoveRotation(Quaternion rot) { }

	// RVA: 0x3514720 Offset: 0x3514821 VA: 0x3514720
	public void Sleep() { }

	// RVA: 0x3514770 Offset: 0x3514871 VA: 0x3514770
	public bool IsSleeping() { }

	// RVA: 0x35147C0 Offset: 0x35148C1 VA: 0x35147C0
	public void WakeUp() { }

	// RVA: 0x3514810 Offset: 0x3514911 VA: 0x3514810
	public void ResetCenterOfMass() { }

	// RVA: 0x3514860 Offset: 0x3514961 VA: 0x3514860
	public void ResetInertiaTensor() { }

	// RVA: 0x35148B0 Offset: 0x35149B1 VA: 0x35148B0
	public Vector3 GetRelativePointVelocity(Vector3 relativePoint) { }

	// RVA: 0x3514980 Offset: 0x3514A81 VA: 0x3514980
	public Vector3 GetPointVelocity(Vector3 worldPoint) { }

	// RVA: 0x3514A50 Offset: 0x3514B51 VA: 0x3514A50
	public int get_solverVelocityIterations() { }

	// RVA: 0x3514AA0 Offset: 0x3514BA1 VA: 0x3514AA0
	public void set_solverVelocityIterations(int value) { }

	// RVA: 0x3514AF0 Offset: 0x3514BF1 VA: 0x3514AF0
	public float get_sleepVelocity() { }

	// RVA: 0x3514B40 Offset: 0x3514C41 VA: 0x3514B40
	public void set_sleepVelocity(float value) { }

	// RVA: 0x3514B90 Offset: 0x3514C91 VA: 0x3514B90
	public float get_sleepAngularVelocity() { }

	// RVA: 0x3514BE0 Offset: 0x3514CE1 VA: 0x3514BE0
	public void set_sleepAngularVelocity(float value) { }

	[ObsoleteAttribute] // RVA: 0xE1730 Offset: 0xE1831 VA: 0xE1730
	// RVA: 0x3514C30 Offset: 0x3514D31 VA: 0x3514C30
	public void SetMaxAngularVelocity(float a) { }

	// RVA: 0x3514C80 Offset: 0x3514D81 VA: 0x3514C80
	public bool get_useConeFriction() { }

	// RVA: 0x3514C90 Offset: 0x3514D91 VA: 0x3514C90
	public void set_useConeFriction(bool value) { }

	// RVA: 0x3514CA0 Offset: 0x3514DA1 VA: 0x3514CA0
	public int get_solverIterationCount() { }

	// RVA: 0x3514CF0 Offset: 0x3514DF1 VA: 0x3514CF0
	public void set_solverIterationCount(int value) { }

	// RVA: 0x3514D40 Offset: 0x3514E41 VA: 0x3514D40
	public int get_solverVelocityIterationCount() { }

	// RVA: 0x3514D90 Offset: 0x3514E91 VA: 0x3514D90
	public void set_solverVelocityIterationCount(int value) { }

	// RVA: 0x3514DE0 Offset: 0x3514EE1 VA: 0x3514DE0
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1770 Offset: 0xE1871 VA: 0xE1770
	// RVA: 0x3514EB0 Offset: 0x3514FB1 VA: 0x3514EB0
	public void AddForce(Vector3 force) { }

	// RVA: 0x3514F10 Offset: 0x3515011 VA: 0x3514F10
	public void AddForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1780 Offset: 0xE1881 VA: 0xE1780
	// RVA: 0x3514FA0 Offset: 0x35150A1 VA: 0x3514FA0
	public void AddForce(float x, float y, float z) { }

	// RVA: 0x3515020 Offset: 0x3515121 VA: 0x3515020
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1790 Offset: 0xE1891 VA: 0xE1790
	// RVA: 0x35150F0 Offset: 0x35151F1 VA: 0x35150F0
	public void AddRelativeForce(Vector3 force) { }

	// RVA: 0x3515150 Offset: 0x3515251 VA: 0x3515150
	public void AddRelativeForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE17A0 Offset: 0xE18A1 VA: 0xE17A0
	// RVA: 0x35151E0 Offset: 0x35152E1 VA: 0x35151E0
	public void AddRelativeForce(float x, float y, float z) { }

	// RVA: 0x3515260 Offset: 0x3515361 VA: 0x3515260
	public void AddTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE17B0 Offset: 0xE18B1 VA: 0xE17B0
	// RVA: 0x3515330 Offset: 0x3515431 VA: 0x3515330
	public void AddTorque(Vector3 torque) { }

	// RVA: 0x3515390 Offset: 0x3515491 VA: 0x3515390
	public void AddTorque(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE17C0 Offset: 0xE18C1 VA: 0xE17C0
	// RVA: 0x3515420 Offset: 0x3515521 VA: 0x3515420
	public void AddTorque(float x, float y, float z) { }

	// RVA: 0x35154A0 Offset: 0x35155A1 VA: 0x35154A0
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE17D0 Offset: 0xE18D1 VA: 0xE17D0
	// RVA: 0x3515570 Offset: 0x3515671 VA: 0x3515570
	public void AddRelativeTorque(Vector3 torque) { }

	// RVA: 0x35155D0 Offset: 0x35156D1 VA: 0x35155D0
	public void AddRelativeTorque(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE17E0 Offset: 0xE18E1 VA: 0xE17E0
	// RVA: 0x3515660 Offset: 0x3515761 VA: 0x3515660
	public void AddRelativeTorque(float x, float y, float z) { }

	// RVA: 0x35156E0 Offset: 0x35157E1 VA: 0x35156E0
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE17F0 Offset: 0xE18F1 VA: 0xE17F0
	// RVA: 0x35157D0 Offset: 0x35158D1 VA: 0x35157D0
	public void AddForceAtPosition(Vector3 force, Vector3 position) { }

	// RVA: 0x3515840 Offset: 0x3515941 VA: 0x3515840
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1800 Offset: 0xE1901 VA: 0xE1800
	// RVA: 0x3515950 Offset: 0x3515A51 VA: 0x3515950
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1810 Offset: 0xE1911 VA: 0xE1810
	// RVA: 0x35159E0 Offset: 0x3515AE1 VA: 0x35159E0
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) { }

	[NativeNameAttribute] // RVA: 0xE1820 Offset: 0xE1921 VA: 0xE1820
	// RVA: 0x3515A60 Offset: 0x3515B61 VA: 0x3515A60
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x3515B40 Offset: 0x3515C41 VA: 0x3515B40
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x3515C30 Offset: 0x3515D31 VA: 0x3515C30
	private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit) { }

	// RVA: 0x3515D70 Offset: 0x3515E71 VA: 0x3515D70
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1860 Offset: 0xE1961 VA: 0xE1860
	// RVA: 0x3515F10 Offset: 0x3516011 VA: 0x3515F10
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1870 Offset: 0xE1971 VA: 0xE1870
	// RVA: 0x3515F20 Offset: 0x3516021 VA: 0x3515F20
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo) { }

	[NativeNameAttribute] // RVA: 0xE1880 Offset: 0xE1981 VA: 0xE1880
	// RVA: 0x3515F30 Offset: 0x3516031 VA: 0x3515F30
	private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3516020 Offset: 0x3516121 VA: 0x3516020
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE18C0 Offset: 0xE19C1 VA: 0xE18C0
	// RVA: 0x3516150 Offset: 0x3516251 VA: 0x3516150
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE18D0 Offset: 0xE19D1 VA: 0xE18D0
	// RVA: 0x3516160 Offset: 0x3516261 VA: 0x3516160
	public RaycastHit[] SweepTestAll(Vector3 direction) { }

	// RVA: 0x3516170 Offset: 0x3516271 VA: 0x3516170
	public void .ctor() { }

	// RVA: 0x35132C0 Offset: 0x35133C1 VA: 0x35132C0
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x3513370 Offset: 0x3513471 VA: 0x3513370
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x3513420 Offset: 0x3513521 VA: 0x3513420
	private void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x35134D0 Offset: 0x35135D1 VA: 0x35134D0
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x3513B70 Offset: 0x3513C71 VA: 0x3513B70
	private void get_centerOfMass_Injected(out Vector3 ret) { }

	// RVA: 0x3513C20 Offset: 0x3513D21 VA: 0x3513C20
	private void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0x3513CD0 Offset: 0x3513DD1 VA: 0x3513CD0
	private void get_worldCenterOfMass_Injected(out Vector3 ret) { }

	// RVA: 0x3513D80 Offset: 0x3513E81 VA: 0x3513D80
	private void get_inertiaTensorRotation_Injected(out Quaternion ret) { }

	// RVA: 0x3513E30 Offset: 0x3513F31 VA: 0x3513E30
	private void set_inertiaTensorRotation_Injected(ref Quaternion value) { }

	// RVA: 0x3513EE0 Offset: 0x3513FE1 VA: 0x3513EE0
	private void get_inertiaTensor_Injected(out Vector3 ret) { }

	// RVA: 0x3513F90 Offset: 0x3514091 VA: 0x3513F90
	private void set_inertiaTensor_Injected(ref Vector3 value) { }

	// RVA: 0x35140E0 Offset: 0x35141E1 VA: 0x35140E0
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x3514190 Offset: 0x3514291 VA: 0x3514190
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x3514240 Offset: 0x3514341 VA: 0x3514240
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x35142F0 Offset: 0x35143F1 VA: 0x35142F0
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x3514620 Offset: 0x3514721 VA: 0x3514620
	private void MovePosition_Injected(ref Vector3 position) { }

	// RVA: 0x35146D0 Offset: 0x35147D1 VA: 0x35146D0
	private void MoveRotation_Injected(ref Quaternion rot) { }

	// RVA: 0x3514920 Offset: 0x3514A21 VA: 0x3514920
	private void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret) { }

	// RVA: 0x35149F0 Offset: 0x3514AF1 VA: 0x35149F0
	private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) { }

	// RVA: 0x3514E50 Offset: 0x3514F51 VA: 0x3514E50
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x3515090 Offset: 0x3515191 VA: 0x3515090
	private void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x35152D0 Offset: 0x35153D1 VA: 0x35152D0
	private void AddTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x3515510 Offset: 0x3515611 VA: 0x3515510
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x3515760 Offset: 0x3515861 VA: 0x3515760
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

	// RVA: 0x35158D0 Offset: 0x35159D1 VA: 0x35158D0
	private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	// RVA: 0x3515AD0 Offset: 0x3515BD1 VA: 0x3515AD0
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x3515CF0 Offset: 0x3515DF1 VA: 0x3515CF0
	private void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x3515FB0 Offset: 0x35160B1 VA: 0x3515FB0
	private RaycastHit[] Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }
}

