[NativeHeaderAttribute] // RVA: 0xC7370 Offset: 0xC7471 VA: 0xC7370
[NativeHeaderAttribute] // RVA: 0xC7370 Offset: 0xC7471 VA: 0xC7370
[NativeHeaderAttribute] // RVA: 0xC7370 Offset: 0xC7471 VA: 0xC7370
[RequiredByNativeCodeAttribute] // RVA: 0xC7370 Offset: 0xC7471 VA: 0xC7370
public class Transform : Component, IEnumerable // TypeDefIndex: 3072
{
	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; set; }
	public Vector3 up { get; set; }
	public Vector3 forward { get; set; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	[NativeConditionalAttribute] // RVA: 0xDF240 Offset: 0xDF341 VA: 0xDF240
	internal RotationOrder rotationOrder { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform root { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativePropertyAttribute] // RVA: 0xDF280 Offset: 0xDF381 VA: 0xDF280
	public bool hasChanged { get; set; }
	public int hierarchyCapacity { get; set; }
	public int hierarchyCount { get; }

	// Methods

	// RVA: 0x2A38150 Offset: 0x2A38251 VA: 0x2A38150
	protected void .ctor() { }

	// RVA: 0x2A38160 Offset: 0x2A38261 VA: 0x2A38160
	public Vector3 get_position() { }

	// RVA: 0x2A38210 Offset: 0x2A38311 VA: 0x2A38210
	public void set_position(Vector3 value) { }

	// RVA: 0x2A382C0 Offset: 0x2A383C1 VA: 0x2A382C0
	public Vector3 get_localPosition() { }

	// RVA: 0x2A38370 Offset: 0x2A38471 VA: 0x2A38370
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x2A38420 Offset: 0x2A38521 VA: 0x2A38420
	internal Vector3 GetLocalEulerAngles(RotationOrder order) { }

	// RVA: 0x2A384F0 Offset: 0x2A385F1 VA: 0x2A384F0
	internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order) { }

	[NativeConditionalAttribute] // RVA: 0xD8470 Offset: 0xD8571 VA: 0xD8470
	// RVA: 0x2A385C0 Offset: 0x2A386C1 VA: 0x2A385C0
	internal void SetLocalEulerHint(Vector3 euler) { }

	// RVA: 0x2A38670 Offset: 0x2A38771 VA: 0x2A38670
	public Vector3 get_eulerAngles() { }

	// RVA: 0x2A38750 Offset: 0x2A38851 VA: 0x2A38750
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x2A38880 Offset: 0x2A38981 VA: 0x2A38880
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x2A38960 Offset: 0x2A38A61 VA: 0x2A38960
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x2A38A90 Offset: 0x2A38B91 VA: 0x2A38A90
	public Vector3 get_right() { }

	// RVA: 0x2A38BB0 Offset: 0x2A38CB1 VA: 0x2A38BB0
	public void set_right(Vector3 value) { }

	// RVA: 0x2A38CD0 Offset: 0x2A38DD1 VA: 0x2A38CD0
	public Vector3 get_up() { }

	// RVA: 0x2A38DF0 Offset: 0x2A38EF1 VA: 0x2A38DF0
	public void set_up(Vector3 value) { }

	// RVA: 0x2A38F10 Offset: 0x2A39011 VA: 0x2A38F10
	public Vector3 get_forward() { }

	// RVA: 0x2A39030 Offset: 0x2A39131 VA: 0x2A39030
	public void set_forward(Vector3 value) { }

	// RVA: 0x2A386F0 Offset: 0x2A387F1 VA: 0x2A386F0
	public Quaternion get_rotation() { }

	// RVA: 0x2A38820 Offset: 0x2A38921 VA: 0x2A38820
	public void set_rotation(Quaternion value) { }

	// RVA: 0x2A38900 Offset: 0x2A38A01 VA: 0x2A38900
	public Quaternion get_localRotation() { }

	// RVA: 0x2A38A30 Offset: 0x2A38B31 VA: 0x2A38A30
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x2A39240 Offset: 0x2A39341 VA: 0x2A39240
	internal RotationOrder get_rotationOrder() { }

	// RVA: 0x2A392E0 Offset: 0x2A393E1 VA: 0x2A392E0
	internal void set_rotationOrder(RotationOrder value) { }

	[NativeConditionalAttribute] // RVA: 0xD84B0 Offset: 0xD85B1 VA: 0xD84B0
	[NativeMethodAttribute] // RVA: 0xD84B0 Offset: 0xD85B1 VA: 0xD84B0
	// RVA: 0x2A39290 Offset: 0x2A39391 VA: 0x2A39290
	internal int GetRotationOrderInternal() { }

	[NativeMethodAttribute] // RVA: 0xD8510 Offset: 0xD8611 VA: 0xD8510
	[NativeConditionalAttribute] // RVA: 0xD8510 Offset: 0xD8611 VA: 0xD8510
	// RVA: 0x2A39330 Offset: 0x2A39431 VA: 0x2A39330
	internal void SetRotationOrderInternal(RotationOrder rotationOrder) { }

	// RVA: 0x2A39380 Offset: 0x2A39481 VA: 0x2A39380
	public Vector3 get_localScale() { }

	// RVA: 0x2A39430 Offset: 0x2A39531 VA: 0x2A39430
	public void set_localScale(Vector3 value) { }

	// RVA: 0x2A394E0 Offset: 0x2A395E1 VA: 0x2A394E0
	public Transform get_parent() { }

	// RVA: 0x2A39580 Offset: 0x2A39681 VA: 0x2A39580
	public void set_parent(Transform value) { }

	// RVA: 0x2A39530 Offset: 0x2A39631 VA: 0x2A39530
	internal Transform get_parentInternal() { }

	// RVA: 0x2A39660 Offset: 0x2A39761 VA: 0x2A39660
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x2A396C0 Offset: 0x2A397C1 VA: 0x2A396C0
	private Transform GetParent() { }

	// RVA: 0x2A39710 Offset: 0x2A39811 VA: 0x2A39710
	public void SetParent(Transform p) { }

	[FreeFunctionAttribute] // RVA: 0xD8570 Offset: 0xD8671 VA: 0xD8570
	// RVA: 0x2A39770 Offset: 0x2A39871 VA: 0x2A39770
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x2A397D0 Offset: 0x2A398D1 VA: 0x2A397D0
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x2A398B0 Offset: 0x2A399B1 VA: 0x2A398B0
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x2A39990 Offset: 0x2A39A91 VA: 0x2A39990
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2A39A60 Offset: 0x2A39B61 VA: 0x2A39A60
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x2A39C80 Offset: 0x2A39D81 VA: 0x2A39C80
	public void Translate(Vector3 translation) { }

	// RVA: 0x2A39C90 Offset: 0x2A39D91 VA: 0x2A39C90
	public void Translate(float x, float y, float z, Space relativeTo) { }

	// RVA: 0x2A39CE0 Offset: 0x2A39DE1 VA: 0x2A39CE0
	public void Translate(float x, float y, float z) { }

	// RVA: 0x2A39D30 Offset: 0x2A39E31 VA: 0x2A39D30
	public void Translate(Vector3 translation, Transform relativeTo) { }

	// RVA: 0x2A39F20 Offset: 0x2A3A021 VA: 0x2A39F20
	public void Translate(float x, float y, float z, Transform relativeTo) { }

	// RVA: 0x2A39F70 Offset: 0x2A3A071 VA: 0x2A39F70
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x2A3A260 Offset: 0x2A3A361 VA: 0x2A3A260
	public void Rotate(Vector3 eulers) { }

	// RVA: 0x2A3A270 Offset: 0x2A3A371 VA: 0x2A3A270
	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }

	// RVA: 0x2A3A2C0 Offset: 0x2A3A3C1 VA: 0x2A3A2C0
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	[NativeMethodAttribute] // RVA: 0xD85C0 Offset: 0xD86C1 VA: 0xD85C0
	// RVA: 0x2A3A310 Offset: 0x2A3A411 VA: 0x2A3A310
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x2A3A3E0 Offset: 0x2A3A4E1 VA: 0x2A3A3E0
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x2A3A500 Offset: 0x2A3A601 VA: 0x2A3A500
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x2A3A510 Offset: 0x2A3A611 VA: 0x2A3A510
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x2A3A730 Offset: 0x2A3A831 VA: 0x2A3A730
	public void LookAt(Transform target, Vector3 worldUp) { }

	// RVA: 0x2A3A8E0 Offset: 0x2A3A9E1 VA: 0x2A3A8E0
	public void LookAt(Transform target) { }

	// RVA: 0x2A3A870 Offset: 0x2A3A971 VA: 0x2A3A870
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2A3AAA0 Offset: 0x2A3ABA1 VA: 0x2A3AAA0
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD8600 Offset: 0xD8701 VA: 0xD8600
	// RVA: 0x2A3AA30 Offset: 0x2A3AB31 VA: 0x2A3AA30
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2A39C10 Offset: 0x2A39D11 VA: 0x2A39C10
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x2A3AC30 Offset: 0x2A3AD31 VA: 0x2A3AC30
	public Vector3 TransformDirection(float x, float y, float z) { }

	// RVA: 0x2A3ACC0 Offset: 0x2A3ADC1 VA: 0x2A3ACC0
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x2A3AD90 Offset: 0x2A3AE91 VA: 0x2A3AD90
	public Vector3 InverseTransformDirection(float x, float y, float z) { }

	// RVA: 0x2A3AE20 Offset: 0x2A3AF21 VA: 0x2A3AE20
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x2A3AEF0 Offset: 0x2A3AFF1 VA: 0x2A3AEF0
	public Vector3 TransformVector(float x, float y, float z) { }

	// RVA: 0x2A3AF80 Offset: 0x2A3B081 VA: 0x2A3AF80
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x2A3B050 Offset: 0x2A3B151 VA: 0x2A3B050
	public Vector3 InverseTransformVector(float x, float y, float z) { }

	// RVA: 0x2A3B0E0 Offset: 0x2A3B1E1 VA: 0x2A3B0E0
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x2A3B1B0 Offset: 0x2A3B2B1 VA: 0x2A3B1B0
	public Vector3 TransformPoint(float x, float y, float z) { }

	// RVA: 0x2A3B240 Offset: 0x2A3B341 VA: 0x2A3B240
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x2A3B310 Offset: 0x2A3B411 VA: 0x2A3B310
	public Vector3 InverseTransformPoint(float x, float y, float z) { }

	// RVA: 0x2A3B3A0 Offset: 0x2A3B4A1 VA: 0x2A3B3A0
	public Transform get_root() { }

	// RVA: 0x2A3B3F0 Offset: 0x2A3B4F1 VA: 0x2A3B3F0
	private Transform GetRoot() { }

	[NativeMethodAttribute] // RVA: 0xD8650 Offset: 0xD8751 VA: 0xD8650
	// RVA: 0x2A3B440 Offset: 0x2A3B541 VA: 0x2A3B440
	public int get_childCount() { }

	[FreeFunctionAttribute] // RVA: 0xD8690 Offset: 0xD8791 VA: 0xD8690
	// RVA: 0x2A3B490 Offset: 0x2A3B591 VA: 0x2A3B490
	public void DetachChildren() { }

	// RVA: 0x2A3B4E0 Offset: 0x2A3B5E1 VA: 0x2A3B4E0
	public void SetAsFirstSibling() { }

	// RVA: 0x2A3B530 Offset: 0x2A3B631 VA: 0x2A3B530
	public void SetAsLastSibling() { }

	// RVA: 0x2A3B580 Offset: 0x2A3B681 VA: 0x2A3B580
	public void SetSiblingIndex(int index) { }

	// RVA: 0x2A3B5D0 Offset: 0x2A3B6D1 VA: 0x2A3B5D0
	public int GetSiblingIndex() { }

	[FreeFunctionAttribute] // RVA: 0xD86E0 Offset: 0xD87E1 VA: 0xD86E0
	// RVA: 0x2A3B620 Offset: 0x2A3B721 VA: 0x2A3B620
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x2A3B680 Offset: 0x2A3B781 VA: 0x2A3B680
	public Transform Find(string n) { }

	[NativeConditionalAttribute] // RVA: 0xD86F0 Offset: 0xD87F1 VA: 0xD86F0
	// RVA: 0x2A3B740 Offset: 0x2A3B841 VA: 0x2A3B740
	internal void SendTransformChangedScale() { }

	[NativeMethodAttribute] // RVA: 0xD8730 Offset: 0xD8831 VA: 0xD8730
	// RVA: 0x2A3B790 Offset: 0x2A3B891 VA: 0x2A3B790
	public Vector3 get_lossyScale() { }

	[FreeFunctionAttribute] // RVA: 0xD8770 Offset: 0xD8871 VA: 0xD8770
	// RVA: 0x2A3B840 Offset: 0x2A3B941 VA: 0x2A3B840
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x2A3B890 Offset: 0x2A3B991 VA: 0x2A3B890
	public bool get_hasChanged() { }

	// RVA: 0x2A3B8E0 Offset: 0x2A3B9E1 VA: 0x2A3B8E0
	public void set_hasChanged(bool value) { }

	[ObsoleteAttribute] // RVA: 0xD87C0 Offset: 0xD88C1 VA: 0xD87C0
	// RVA: 0x2A3B930 Offset: 0x2A3BA31 VA: 0x2A3B930
	public Transform FindChild(string n) { }

	// RVA: 0x2A3B9F0 Offset: 0x2A3BAF1 VA: 0x2A3B9F0 Slot: 4
	public IEnumerator GetEnumerator() { }

	[ObsoleteAttribute] // RVA: 0xD8800 Offset: 0xD8901 VA: 0xD8800
	// RVA: 0x2A3BA60 Offset: 0x2A3BB61 VA: 0x2A3BA60
	public void RotateAround(Vector3 axis, float angle) { }

	[ObsoleteAttribute] // RVA: 0xD8840 Offset: 0xD8941 VA: 0xD8840
	// RVA: 0x2A3BB30 Offset: 0x2A3BC31 VA: 0x2A3BB30
	public void RotateAroundLocal(Vector3 axis, float angle) { }

	[NativeThrowsAttribute] // RVA: 0xD8880 Offset: 0xD8981 VA: 0xD8880
	[FreeFunctionAttribute] // RVA: 0xD8880 Offset: 0xD8981 VA: 0xD8880
	// RVA: 0x2A3BC00 Offset: 0x2A3BD01 VA: 0x2A3BC00
	public Transform GetChild(int index) { }

	[ObsoleteAttribute] // RVA: 0xD88E0 Offset: 0xD89E1 VA: 0xD88E0
	[NativeMethodAttribute] // RVA: 0xD88E0 Offset: 0xD89E1 VA: 0xD88E0
	// RVA: 0x2A3BC50 Offset: 0x2A3BD51 VA: 0x2A3BC50
	public int GetChildCount() { }

	// RVA: 0x2A3BCA0 Offset: 0x2A3BDA1 VA: 0x2A3BCA0
	public int get_hierarchyCapacity() { }

	// RVA: 0x2A3BD40 Offset: 0x2A3BE41 VA: 0x2A3BD40
	public void set_hierarchyCapacity(int value) { }

	[FreeFunctionAttribute] // RVA: 0xD8950 Offset: 0xD8A51 VA: 0xD8950
	// RVA: 0x2A3BCF0 Offset: 0x2A3BDF1 VA: 0x2A3BCF0
	private int internal_getHierarchyCapacity() { }

	[FreeFunctionAttribute] // RVA: 0xD89A0 Offset: 0xD8AA1 VA: 0xD89A0
	// RVA: 0x2A3BD90 Offset: 0x2A3BE91 VA: 0x2A3BD90
	private void internal_setHierarchyCapacity(int value) { }

	// RVA: 0x2A3BDE0 Offset: 0x2A3BEE1 VA: 0x2A3BDE0
	public int get_hierarchyCount() { }

	[FreeFunctionAttribute] // RVA: 0xD89F0 Offset: 0xD8AF1 VA: 0xD89F0
	// RVA: 0x2A3BE30 Offset: 0x2A3BF31 VA: 0x2A3BE30
	private int internal_getHierarchyCount() { }

	[NativeConditionalAttribute] // RVA: 0xD8A40 Offset: 0xD8B41 VA: 0xD8A40
	[FreeFunctionAttribute] // RVA: 0xD8A40 Offset: 0xD8B41 VA: 0xD8A40
	// RVA: 0x2A3BE80 Offset: 0x2A3BF81 VA: 0x2A3BE80
	internal bool IsNonUniformScaleTransform() { }

	// RVA: 0x2A381C0 Offset: 0x2A382C1 VA: 0x2A381C0
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x2A38270 Offset: 0x2A38371 VA: 0x2A38270
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x2A38320 Offset: 0x2A38421 VA: 0x2A38320
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2A383D0 Offset: 0x2A384D1 VA: 0x2A383D0
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x2A38490 Offset: 0x2A38591 VA: 0x2A38490
	private void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret) { }

	// RVA: 0x2A38560 Offset: 0x2A38661 VA: 0x2A38560
	private void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order) { }

	// RVA: 0x2A38620 Offset: 0x2A38721 VA: 0x2A38620
	private void SetLocalEulerHint_Injected(ref Vector3 euler) { }

	// RVA: 0x2A39100 Offset: 0x2A39201 VA: 0x2A39100
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x2A39150 Offset: 0x2A39251 VA: 0x2A39150
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x2A391A0 Offset: 0x2A392A1 VA: 0x2A391A0
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x2A391F0 Offset: 0x2A392F1 VA: 0x2A391F0
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x2A393E0 Offset: 0x2A394E1 VA: 0x2A393E0
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x2A39490 Offset: 0x2A39591 VA: 0x2A39490
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x2A39860 Offset: 0x2A39961 VA: 0x2A39860
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2A39940 Offset: 0x2A39A41 VA: 0x2A39940
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2A39A00 Offset: 0x2A39B01 VA: 0x2A39A00
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x2A3A380 Offset: 0x2A3A481 VA: 0x2A3A380
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x2A3AB70 Offset: 0x2A3AC71 VA: 0x2A3AB70
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x2A3ABD0 Offset: 0x2A3ACD1 VA: 0x2A3ABD0
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x2A3AD30 Offset: 0x2A3AE31 VA: 0x2A3AD30
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x2A3AE90 Offset: 0x2A3AF91 VA: 0x2A3AE90
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x2A3AFF0 Offset: 0x2A3B0F1 VA: 0x2A3AFF0
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x2A3B150 Offset: 0x2A3B251 VA: 0x2A3B150
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2A3B2B0 Offset: 0x2A3B3B1 VA: 0x2A3B2B0
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2A3B7F0 Offset: 0x2A3B8F1 VA: 0x2A3B7F0
	private void get_lossyScale_Injected(out Vector3 ret) { }

	// RVA: 0x2A3BAD0 Offset: 0x2A3BBD1 VA: 0x2A3BAD0
	private void RotateAround_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x2A3BBA0 Offset: 0x2A3BCA1 VA: 0x2A3BBA0
	private void RotateAroundLocal_Injected(ref Vector3 axis, float angle) { }
}

