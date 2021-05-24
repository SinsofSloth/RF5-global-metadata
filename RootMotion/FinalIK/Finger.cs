[Serializable]
public class Finger // TypeDefIndex: 9420
{
	// Fields
	[TooltipAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	[RangeAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	public float weight; // 0x10
	[TooltipAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	[RangeAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	public float rotationWeight; // 0x14
	[TooltipAttribute] // RVA: 0x178F90 Offset: 0x179091 VA: 0x178F90
	public Finger.DOF rotationDOF; // 0x18
	[TooltipAttribute] // RVA: 0x178FD0 Offset: 0x1790D1 VA: 0x178FD0
	public bool fixBone1Twist; // 0x1C
	[TooltipAttribute] // RVA: 0x179010 Offset: 0x179111 VA: 0x179010
	public Transform bone1; // 0x20
	[TooltipAttribute] // RVA: 0x179050 Offset: 0x179151 VA: 0x179050
	public Transform bone2; // 0x28
	[TooltipAttribute] // RVA: 0x179090 Offset: 0x179191 VA: 0x179090
	public Transform bone3; // 0x30
	[TooltipAttribute] // RVA: 0x1790D0 Offset: 0x1791D1 VA: 0x1790D0
	public Transform tip; // 0x38
	[TooltipAttribute] // RVA: 0x179110 Offset: 0x179211 VA: 0x179110
	public Transform target; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x179150 Offset: 0x179251 VA: 0x179150
	private bool <initiated>k__BackingField; // 0x48
	private IKSolverLimb solver; // 0x50
	private Quaternion bone3RelativeToTarget; // 0x58
	private Vector3 bone3DefaultLocalPosition; // 0x68
	private Quaternion bone3DefaultLocalRotation; // 0x74
	private Vector3 bone1Axis; // 0x84
	private Vector3 tipAxis; // 0x90
	private Vector3 bone1TwistAxis; // 0x9C

	// Properties
	public bool initiated { get; set; }
	public Vector3 IKPosition { get; set; }
	public Quaternion IKRotation { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA330 Offset: 0x1AA431 VA: 0x1AA330
	// RVA: 0x2B2D0E0 Offset: 0x2B2D1E1 VA: 0x2B2D0E0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA340 Offset: 0x1AA441 VA: 0x1AA340
	// RVA: 0x2B2D0F0 Offset: 0x2B2D1F1 VA: 0x2B2D0F0
	private void set_initiated(bool value) { }

	// RVA: 0x2B2D100 Offset: 0x2B2D201 VA: 0x2B2D100
	public Vector3 get_IKPosition() { }

	// RVA: 0x2B2D120 Offset: 0x2B2D221 VA: 0x2B2D120
	public void set_IKPosition(Vector3 value) { }

	// RVA: 0x2B2D150 Offset: 0x2B2D251 VA: 0x2B2D150
	public Quaternion get_IKRotation() { }

	// RVA: 0x2B2D170 Offset: 0x2B2D271 VA: 0x2B2D170
	public void set_IKRotation(Quaternion value) { }

	// RVA: 0x2B2D1A0 Offset: 0x2B2D2A1 VA: 0x2B2D1A0
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x2B2D2C0 Offset: 0x2B2D3C1 VA: 0x2B2D2C0
	public void Initiate(Transform hand, int index) { }

	// RVA: 0x2B2D880 Offset: 0x2B2D981 VA: 0x2B2D880
	public void FixTransforms() { }

	// RVA: 0x2B2D960 Offset: 0x2B2DA61 VA: 0x2B2D960
	public void StoreDefaultLocalState() { }

	// RVA: 0x2B2DA30 Offset: 0x2B2DB31 VA: 0x2B2DA30
	public void Update(float masterWeight) { }

	// RVA: 0x2B2E180 Offset: 0x2B2E281 VA: 0x2B2E180
	public void .ctor() { }
}

[Serializable]
public class Finger // TypeDefIndex: 9420
{
	// Fields
	[TooltipAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	[RangeAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	public float weight; // 0x10
	[TooltipAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	[RangeAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	public float rotationWeight; // 0x14
	[TooltipAttribute] // RVA: 0x178F90 Offset: 0x179091 VA: 0x178F90
	public Finger.DOF rotationDOF; // 0x18
	[TooltipAttribute] // RVA: 0x178FD0 Offset: 0x1790D1 VA: 0x178FD0
	public bool fixBone1Twist; // 0x1C
	[TooltipAttribute] // RVA: 0x179010 Offset: 0x179111 VA: 0x179010
	public Transform bone1; // 0x20
	[TooltipAttribute] // RVA: 0x179050 Offset: 0x179151 VA: 0x179050
	public Transform bone2; // 0x28
	[TooltipAttribute] // RVA: 0x179090 Offset: 0x179191 VA: 0x179090
	public Transform bone3; // 0x30
	[TooltipAttribute] // RVA: 0x1790D0 Offset: 0x1791D1 VA: 0x1790D0
	public Transform tip; // 0x38
	[TooltipAttribute] // RVA: 0x179110 Offset: 0x179211 VA: 0x179110
	public Transform target; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x179150 Offset: 0x179251 VA: 0x179150
	private bool <initiated>k__BackingField; // 0x48
	private IKSolverLimb solver; // 0x50
	private Quaternion bone3RelativeToTarget; // 0x58
	private Vector3 bone3DefaultLocalPosition; // 0x68
	private Quaternion bone3DefaultLocalRotation; // 0x74
	private Vector3 bone1Axis; // 0x84
	private Vector3 tipAxis; // 0x90
	private Vector3 bone1TwistAxis; // 0x9C

	// Properties
	public bool initiated { get; set; }
	public Vector3 IKPosition { get; set; }
	public Quaternion IKRotation { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA330 Offset: 0x1AA431 VA: 0x1AA330
	// RVA: 0x2B2D0E0 Offset: 0x2B2D1E1 VA: 0x2B2D0E0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA340 Offset: 0x1AA441 VA: 0x1AA340
	// RVA: 0x2B2D0F0 Offset: 0x2B2D1F1 VA: 0x2B2D0F0
	private void set_initiated(bool value) { }

	// RVA: 0x2B2D100 Offset: 0x2B2D201 VA: 0x2B2D100
	public Vector3 get_IKPosition() { }

	// RVA: 0x2B2D120 Offset: 0x2B2D221 VA: 0x2B2D120
	public void set_IKPosition(Vector3 value) { }

	// RVA: 0x2B2D150 Offset: 0x2B2D251 VA: 0x2B2D150
	public Quaternion get_IKRotation() { }

	// RVA: 0x2B2D170 Offset: 0x2B2D271 VA: 0x2B2D170
	public void set_IKRotation(Quaternion value) { }

	// RVA: 0x2B2D1A0 Offset: 0x2B2D2A1 VA: 0x2B2D1A0
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x2B2D2C0 Offset: 0x2B2D3C1 VA: 0x2B2D2C0
	public void Initiate(Transform hand, int index) { }

	// RVA: 0x2B2D880 Offset: 0x2B2D981 VA: 0x2B2D880
	public void FixTransforms() { }

	// RVA: 0x2B2D960 Offset: 0x2B2DA61 VA: 0x2B2D960
	public void StoreDefaultLocalState() { }

	// RVA: 0x2B2DA30 Offset: 0x2B2DB31 VA: 0x2B2DA30
	public void Update(float masterWeight) { }

	// RVA: 0x2B2E180 Offset: 0x2B2E281 VA: 0x2B2E180
	public void .ctor() { }
}

[Serializable]
public class Finger // TypeDefIndex: 9420
{
	// Fields
	[TooltipAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	[RangeAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	public float weight; // 0x10
	[TooltipAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	[RangeAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	public float rotationWeight; // 0x14
	[TooltipAttribute] // RVA: 0x178F90 Offset: 0x179091 VA: 0x178F90
	public Finger.DOF rotationDOF; // 0x18
	[TooltipAttribute] // RVA: 0x178FD0 Offset: 0x1790D1 VA: 0x178FD0
	public bool fixBone1Twist; // 0x1C
	[TooltipAttribute] // RVA: 0x179010 Offset: 0x179111 VA: 0x179010
	public Transform bone1; // 0x20
	[TooltipAttribute] // RVA: 0x179050 Offset: 0x179151 VA: 0x179050
	public Transform bone2; // 0x28
	[TooltipAttribute] // RVA: 0x179090 Offset: 0x179191 VA: 0x179090
	public Transform bone3; // 0x30
	[TooltipAttribute] // RVA: 0x1790D0 Offset: 0x1791D1 VA: 0x1790D0
	public Transform tip; // 0x38
	[TooltipAttribute] // RVA: 0x179110 Offset: 0x179211 VA: 0x179110
	public Transform target; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x179150 Offset: 0x179251 VA: 0x179150
	private bool <initiated>k__BackingField; // 0x48
	private IKSolverLimb solver; // 0x50
	private Quaternion bone3RelativeToTarget; // 0x58
	private Vector3 bone3DefaultLocalPosition; // 0x68
	private Quaternion bone3DefaultLocalRotation; // 0x74
	private Vector3 bone1Axis; // 0x84
	private Vector3 tipAxis; // 0x90
	private Vector3 bone1TwistAxis; // 0x9C

	// Properties
	public bool initiated { get; set; }
	public Vector3 IKPosition { get; set; }
	public Quaternion IKRotation { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA330 Offset: 0x1AA431 VA: 0x1AA330
	// RVA: 0x2B2D0E0 Offset: 0x2B2D1E1 VA: 0x2B2D0E0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA340 Offset: 0x1AA441 VA: 0x1AA340
	// RVA: 0x2B2D0F0 Offset: 0x2B2D1F1 VA: 0x2B2D0F0
	private void set_initiated(bool value) { }

	// RVA: 0x2B2D100 Offset: 0x2B2D201 VA: 0x2B2D100
	public Vector3 get_IKPosition() { }

	// RVA: 0x2B2D120 Offset: 0x2B2D221 VA: 0x2B2D120
	public void set_IKPosition(Vector3 value) { }

	// RVA: 0x2B2D150 Offset: 0x2B2D251 VA: 0x2B2D150
	public Quaternion get_IKRotation() { }

	// RVA: 0x2B2D170 Offset: 0x2B2D271 VA: 0x2B2D170
	public void set_IKRotation(Quaternion value) { }

	// RVA: 0x2B2D1A0 Offset: 0x2B2D2A1 VA: 0x2B2D1A0
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x2B2D2C0 Offset: 0x2B2D3C1 VA: 0x2B2D2C0
	public void Initiate(Transform hand, int index) { }

	// RVA: 0x2B2D880 Offset: 0x2B2D981 VA: 0x2B2D880
	public void FixTransforms() { }

	// RVA: 0x2B2D960 Offset: 0x2B2DA61 VA: 0x2B2D960
	public void StoreDefaultLocalState() { }

	// RVA: 0x2B2DA30 Offset: 0x2B2DB31 VA: 0x2B2DA30
	public void Update(float masterWeight) { }

	// RVA: 0x2B2E180 Offset: 0x2B2E281 VA: 0x2B2E180
	public void .ctor() { }
}

[Serializable]
public class Finger // TypeDefIndex: 9420
{
	// Fields
	[TooltipAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	[RangeAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	public float weight; // 0x10
	[TooltipAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	[RangeAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	public float rotationWeight; // 0x14
	[TooltipAttribute] // RVA: 0x178F90 Offset: 0x179091 VA: 0x178F90
	public Finger.DOF rotationDOF; // 0x18
	[TooltipAttribute] // RVA: 0x178FD0 Offset: 0x1790D1 VA: 0x178FD0
	public bool fixBone1Twist; // 0x1C
	[TooltipAttribute] // RVA: 0x179010 Offset: 0x179111 VA: 0x179010
	public Transform bone1; // 0x20
	[TooltipAttribute] // RVA: 0x179050 Offset: 0x179151 VA: 0x179050
	public Transform bone2; // 0x28
	[TooltipAttribute] // RVA: 0x179090 Offset: 0x179191 VA: 0x179090
	public Transform bone3; // 0x30
	[TooltipAttribute] // RVA: 0x1790D0 Offset: 0x1791D1 VA: 0x1790D0
	public Transform tip; // 0x38
	[TooltipAttribute] // RVA: 0x179110 Offset: 0x179211 VA: 0x179110
	public Transform target; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x179150 Offset: 0x179251 VA: 0x179150
	private bool <initiated>k__BackingField; // 0x48
	private IKSolverLimb solver; // 0x50
	private Quaternion bone3RelativeToTarget; // 0x58
	private Vector3 bone3DefaultLocalPosition; // 0x68
	private Quaternion bone3DefaultLocalRotation; // 0x74
	private Vector3 bone1Axis; // 0x84
	private Vector3 tipAxis; // 0x90
	private Vector3 bone1TwistAxis; // 0x9C

	// Properties
	public bool initiated { get; set; }
	public Vector3 IKPosition { get; set; }
	public Quaternion IKRotation { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA330 Offset: 0x1AA431 VA: 0x1AA330
	// RVA: 0x2B2D0E0 Offset: 0x2B2D1E1 VA: 0x2B2D0E0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA340 Offset: 0x1AA441 VA: 0x1AA340
	// RVA: 0x2B2D0F0 Offset: 0x2B2D1F1 VA: 0x2B2D0F0
	private void set_initiated(bool value) { }

	// RVA: 0x2B2D100 Offset: 0x2B2D201 VA: 0x2B2D100
	public Vector3 get_IKPosition() { }

	// RVA: 0x2B2D120 Offset: 0x2B2D221 VA: 0x2B2D120
	public void set_IKPosition(Vector3 value) { }

	// RVA: 0x2B2D150 Offset: 0x2B2D251 VA: 0x2B2D150
	public Quaternion get_IKRotation() { }

	// RVA: 0x2B2D170 Offset: 0x2B2D271 VA: 0x2B2D170
	public void set_IKRotation(Quaternion value) { }

	// RVA: 0x2B2D1A0 Offset: 0x2B2D2A1 VA: 0x2B2D1A0
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x2B2D2C0 Offset: 0x2B2D3C1 VA: 0x2B2D2C0
	public void Initiate(Transform hand, int index) { }

	// RVA: 0x2B2D880 Offset: 0x2B2D981 VA: 0x2B2D880
	public void FixTransforms() { }

	// RVA: 0x2B2D960 Offset: 0x2B2DA61 VA: 0x2B2D960
	public void StoreDefaultLocalState() { }

	// RVA: 0x2B2DA30 Offset: 0x2B2DB31 VA: 0x2B2DA30
	public void Update(float masterWeight) { }

	// RVA: 0x2B2E180 Offset: 0x2B2E281 VA: 0x2B2E180
	public void .ctor() { }
}

[Serializable]
public class Finger // TypeDefIndex: 9420
{
	// Fields
	[TooltipAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	[RangeAttribute] // RVA: 0x178ED0 Offset: 0x178FD1 VA: 0x178ED0
	public float weight; // 0x10
	[TooltipAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	[RangeAttribute] // RVA: 0x178F30 Offset: 0x179031 VA: 0x178F30
	public float rotationWeight; // 0x14
	[TooltipAttribute] // RVA: 0x178F90 Offset: 0x179091 VA: 0x178F90
	public Finger.DOF rotationDOF; // 0x18
	[TooltipAttribute] // RVA: 0x178FD0 Offset: 0x1790D1 VA: 0x178FD0
	public bool fixBone1Twist; // 0x1C
	[TooltipAttribute] // RVA: 0x179010 Offset: 0x179111 VA: 0x179010
	public Transform bone1; // 0x20
	[TooltipAttribute] // RVA: 0x179050 Offset: 0x179151 VA: 0x179050
	public Transform bone2; // 0x28
	[TooltipAttribute] // RVA: 0x179090 Offset: 0x179191 VA: 0x179090
	public Transform bone3; // 0x30
	[TooltipAttribute] // RVA: 0x1790D0 Offset: 0x1791D1 VA: 0x1790D0
	public Transform tip; // 0x38
	[TooltipAttribute] // RVA: 0x179110 Offset: 0x179211 VA: 0x179110
	public Transform target; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x179150 Offset: 0x179251 VA: 0x179150
	private bool <initiated>k__BackingField; // 0x48
	private IKSolverLimb solver; // 0x50
	private Quaternion bone3RelativeToTarget; // 0x58
	private Vector3 bone3DefaultLocalPosition; // 0x68
	private Quaternion bone3DefaultLocalRotation; // 0x74
	private Vector3 bone1Axis; // 0x84
	private Vector3 tipAxis; // 0x90
	private Vector3 bone1TwistAxis; // 0x9C

	// Properties
	public bool initiated { get; set; }
	public Vector3 IKPosition { get; set; }
	public Quaternion IKRotation { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA330 Offset: 0x1AA431 VA: 0x1AA330
	// RVA: 0x2B2D0E0 Offset: 0x2B2D1E1 VA: 0x2B2D0E0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA340 Offset: 0x1AA441 VA: 0x1AA340
	// RVA: 0x2B2D0F0 Offset: 0x2B2D1F1 VA: 0x2B2D0F0
	private void set_initiated(bool value) { }

	// RVA: 0x2B2D100 Offset: 0x2B2D201 VA: 0x2B2D100
	public Vector3 get_IKPosition() { }

	// RVA: 0x2B2D120 Offset: 0x2B2D221 VA: 0x2B2D120
	public void set_IKPosition(Vector3 value) { }

	// RVA: 0x2B2D150 Offset: 0x2B2D251 VA: 0x2B2D150
	public Quaternion get_IKRotation() { }

	// RVA: 0x2B2D170 Offset: 0x2B2D271 VA: 0x2B2D170
	public void set_IKRotation(Quaternion value) { }

	// RVA: 0x2B2D1A0 Offset: 0x2B2D2A1 VA: 0x2B2D1A0
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x2B2D2C0 Offset: 0x2B2D3C1 VA: 0x2B2D2C0
	public void Initiate(Transform hand, int index) { }

	// RVA: 0x2B2D880 Offset: 0x2B2D981 VA: 0x2B2D880
	public void FixTransforms() { }

	// RVA: 0x2B2D960 Offset: 0x2B2DA61 VA: 0x2B2D960
	public void StoreDefaultLocalState() { }

	// RVA: 0x2B2DA30 Offset: 0x2B2DB31 VA: 0x2B2DA30
	public void Update(float masterWeight) { }

	// RVA: 0x2B2E180 Offset: 0x2B2E281 VA: 0x2B2E180
	public void .ctor() { }
}

