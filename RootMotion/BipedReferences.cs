[Serializable]
public class BipedReferences // TypeDefIndex: 9313
{
	// Fields
	public Transform root; // 0x10
	public Transform pelvis; // 0x18
	public Transform leftThigh; // 0x20
	public Transform leftCalf; // 0x28
	public Transform leftFoot; // 0x30
	public Transform rightThigh; // 0x38
	public Transform rightCalf; // 0x40
	public Transform rightFoot; // 0x48
	public Transform leftUpperArm; // 0x50
	public Transform leftForearm; // 0x58
	public Transform leftHand; // 0x60
	public Transform rightUpperArm; // 0x68
	public Transform rightForearm; // 0x70
	public Transform rightHand; // 0x78
	public Transform head; // 0x80
	public Transform[] spine; // 0x88
	public Transform[] eyes; // 0x90

	// Properties
	public virtual bool isFilled { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x26B9CA0 Offset: 0x26B9DA1 VA: 0x26B9CA0 Slot: 4
	public virtual bool get_isFilled() { }

	// RVA: 0x26BA080 Offset: 0x26BA181 VA: 0x26BA080
	public bool get_isEmpty() { }

	// RVA: 0x26BA090 Offset: 0x26BA191 VA: 0x26BA090 Slot: 5
	public virtual bool IsEmpty(bool includeRoot) { }

	// RVA: 0x26BA4B0 Offset: 0x26BA5B1 VA: 0x26BA4B0 Slot: 6
	public virtual bool Contains(Transform t, bool ignoreRoot = False) { }

	// RVA: 0x26BA8E0 Offset: 0x26BA9E1 VA: 0x26BA8E0
	public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB0D0 Offset: 0x26BB1D1 VA: 0x26BB0D0
	public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BABD0 Offset: 0x26BACD1 VA: 0x26BABD0
	public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB990 Offset: 0x26BBA91 VA: 0x26BB990
	public static bool SetupError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BBA90 Offset: 0x26BBB91 VA: 0x26BBA90
	public static bool SetupWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BC0B0 Offset: 0x26BC1B1 VA: 0x26BC0B0
	private static bool IsNeckBone(Transform bone, Transform leftUpperArm) { }

	// RVA: 0x26BBE90 Offset: 0x26BBF91 VA: 0x26BBE90
	private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBD00 Offset: 0x26BBE01 VA: 0x26BBD00
	private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBB30 Offset: 0x26BBC31 VA: 0x26BBB30
	private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) { }

	// RVA: 0x26BBFA0 Offset: 0x26BC0A1 VA: 0x26BBFA0
	private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) { }

	// RVA: 0x26BC1B0 Offset: 0x26BC2B1 VA: 0x26BC1B0
	private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) { }

	// RVA: 0x26BCD30 Offset: 0x26BCE31 VA: 0x26BCD30
	private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) { }

	// RVA: 0x26BC800 Offset: 0x26BC901 VA: 0x26BC800
	private static bool SpineError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0A0 Offset: 0x26BD1A1 VA: 0x26BD0A0
	private static bool SpineWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BCB50 Offset: 0x26BCC51 VA: 0x26BCB50
	private static bool EyesError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0B0 Offset: 0x26BD1B1 VA: 0x26BD0B0
	private static bool EyesWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD0C0 Offset: 0x26BD1C1 VA: 0x26BD0C0
	private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD290 Offset: 0x26BD391 VA: 0x26BD290
	private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD4C0 Offset: 0x26BD5C1 VA: 0x26BD4C0
	private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) { }

	// RVA: 0x26BAB40 Offset: 0x26BAC41 VA: 0x26BAB40
	public void .ctor() { }
}

[Serializable]
public class BipedReferences // TypeDefIndex: 9313
{
	// Fields
	public Transform root; // 0x10
	public Transform pelvis; // 0x18
	public Transform leftThigh; // 0x20
	public Transform leftCalf; // 0x28
	public Transform leftFoot; // 0x30
	public Transform rightThigh; // 0x38
	public Transform rightCalf; // 0x40
	public Transform rightFoot; // 0x48
	public Transform leftUpperArm; // 0x50
	public Transform leftForearm; // 0x58
	public Transform leftHand; // 0x60
	public Transform rightUpperArm; // 0x68
	public Transform rightForearm; // 0x70
	public Transform rightHand; // 0x78
	public Transform head; // 0x80
	public Transform[] spine; // 0x88
	public Transform[] eyes; // 0x90

	// Properties
	public virtual bool isFilled { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x26B9CA0 Offset: 0x26B9DA1 VA: 0x26B9CA0 Slot: 4
	public virtual bool get_isFilled() { }

	// RVA: 0x26BA080 Offset: 0x26BA181 VA: 0x26BA080
	public bool get_isEmpty() { }

	// RVA: 0x26BA090 Offset: 0x26BA191 VA: 0x26BA090 Slot: 5
	public virtual bool IsEmpty(bool includeRoot) { }

	// RVA: 0x26BA4B0 Offset: 0x26BA5B1 VA: 0x26BA4B0 Slot: 6
	public virtual bool Contains(Transform t, bool ignoreRoot = False) { }

	// RVA: 0x26BA8E0 Offset: 0x26BA9E1 VA: 0x26BA8E0
	public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB0D0 Offset: 0x26BB1D1 VA: 0x26BB0D0
	public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BABD0 Offset: 0x26BACD1 VA: 0x26BABD0
	public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB990 Offset: 0x26BBA91 VA: 0x26BB990
	public static bool SetupError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BBA90 Offset: 0x26BBB91 VA: 0x26BBA90
	public static bool SetupWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BC0B0 Offset: 0x26BC1B1 VA: 0x26BC0B0
	private static bool IsNeckBone(Transform bone, Transform leftUpperArm) { }

	// RVA: 0x26BBE90 Offset: 0x26BBF91 VA: 0x26BBE90
	private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBD00 Offset: 0x26BBE01 VA: 0x26BBD00
	private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBB30 Offset: 0x26BBC31 VA: 0x26BBB30
	private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) { }

	// RVA: 0x26BBFA0 Offset: 0x26BC0A1 VA: 0x26BBFA0
	private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) { }

	// RVA: 0x26BC1B0 Offset: 0x26BC2B1 VA: 0x26BC1B0
	private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) { }

	// RVA: 0x26BCD30 Offset: 0x26BCE31 VA: 0x26BCD30
	private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) { }

	// RVA: 0x26BC800 Offset: 0x26BC901 VA: 0x26BC800
	private static bool SpineError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0A0 Offset: 0x26BD1A1 VA: 0x26BD0A0
	private static bool SpineWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BCB50 Offset: 0x26BCC51 VA: 0x26BCB50
	private static bool EyesError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0B0 Offset: 0x26BD1B1 VA: 0x26BD0B0
	private static bool EyesWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD0C0 Offset: 0x26BD1C1 VA: 0x26BD0C0
	private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD290 Offset: 0x26BD391 VA: 0x26BD290
	private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD4C0 Offset: 0x26BD5C1 VA: 0x26BD4C0
	private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) { }

	// RVA: 0x26BAB40 Offset: 0x26BAC41 VA: 0x26BAB40
	public void .ctor() { }
}

[Serializable]
public class BipedReferences // TypeDefIndex: 9313
{
	// Fields
	public Transform root; // 0x10
	public Transform pelvis; // 0x18
	public Transform leftThigh; // 0x20
	public Transform leftCalf; // 0x28
	public Transform leftFoot; // 0x30
	public Transform rightThigh; // 0x38
	public Transform rightCalf; // 0x40
	public Transform rightFoot; // 0x48
	public Transform leftUpperArm; // 0x50
	public Transform leftForearm; // 0x58
	public Transform leftHand; // 0x60
	public Transform rightUpperArm; // 0x68
	public Transform rightForearm; // 0x70
	public Transform rightHand; // 0x78
	public Transform head; // 0x80
	public Transform[] spine; // 0x88
	public Transform[] eyes; // 0x90

	// Properties
	public virtual bool isFilled { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x26B9CA0 Offset: 0x26B9DA1 VA: 0x26B9CA0 Slot: 4
	public virtual bool get_isFilled() { }

	// RVA: 0x26BA080 Offset: 0x26BA181 VA: 0x26BA080
	public bool get_isEmpty() { }

	// RVA: 0x26BA090 Offset: 0x26BA191 VA: 0x26BA090 Slot: 5
	public virtual bool IsEmpty(bool includeRoot) { }

	// RVA: 0x26BA4B0 Offset: 0x26BA5B1 VA: 0x26BA4B0 Slot: 6
	public virtual bool Contains(Transform t, bool ignoreRoot = False) { }

	// RVA: 0x26BA8E0 Offset: 0x26BA9E1 VA: 0x26BA8E0
	public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB0D0 Offset: 0x26BB1D1 VA: 0x26BB0D0
	public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BABD0 Offset: 0x26BACD1 VA: 0x26BABD0
	public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB990 Offset: 0x26BBA91 VA: 0x26BB990
	public static bool SetupError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BBA90 Offset: 0x26BBB91 VA: 0x26BBA90
	public static bool SetupWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BC0B0 Offset: 0x26BC1B1 VA: 0x26BC0B0
	private static bool IsNeckBone(Transform bone, Transform leftUpperArm) { }

	// RVA: 0x26BBE90 Offset: 0x26BBF91 VA: 0x26BBE90
	private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBD00 Offset: 0x26BBE01 VA: 0x26BBD00
	private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBB30 Offset: 0x26BBC31 VA: 0x26BBB30
	private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) { }

	// RVA: 0x26BBFA0 Offset: 0x26BC0A1 VA: 0x26BBFA0
	private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) { }

	// RVA: 0x26BC1B0 Offset: 0x26BC2B1 VA: 0x26BC1B0
	private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) { }

	// RVA: 0x26BCD30 Offset: 0x26BCE31 VA: 0x26BCD30
	private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) { }

	// RVA: 0x26BC800 Offset: 0x26BC901 VA: 0x26BC800
	private static bool SpineError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0A0 Offset: 0x26BD1A1 VA: 0x26BD0A0
	private static bool SpineWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BCB50 Offset: 0x26BCC51 VA: 0x26BCB50
	private static bool EyesError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0B0 Offset: 0x26BD1B1 VA: 0x26BD0B0
	private static bool EyesWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD0C0 Offset: 0x26BD1C1 VA: 0x26BD0C0
	private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD290 Offset: 0x26BD391 VA: 0x26BD290
	private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD4C0 Offset: 0x26BD5C1 VA: 0x26BD4C0
	private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) { }

	// RVA: 0x26BAB40 Offset: 0x26BAC41 VA: 0x26BAB40
	public void .ctor() { }
}

[Serializable]
public class BipedReferences // TypeDefIndex: 9313
{
	// Fields
	public Transform root; // 0x10
	public Transform pelvis; // 0x18
	public Transform leftThigh; // 0x20
	public Transform leftCalf; // 0x28
	public Transform leftFoot; // 0x30
	public Transform rightThigh; // 0x38
	public Transform rightCalf; // 0x40
	public Transform rightFoot; // 0x48
	public Transform leftUpperArm; // 0x50
	public Transform leftForearm; // 0x58
	public Transform leftHand; // 0x60
	public Transform rightUpperArm; // 0x68
	public Transform rightForearm; // 0x70
	public Transform rightHand; // 0x78
	public Transform head; // 0x80
	public Transform[] spine; // 0x88
	public Transform[] eyes; // 0x90

	// Properties
	public virtual bool isFilled { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x26B9CA0 Offset: 0x26B9DA1 VA: 0x26B9CA0 Slot: 4
	public virtual bool get_isFilled() { }

	// RVA: 0x26BA080 Offset: 0x26BA181 VA: 0x26BA080
	public bool get_isEmpty() { }

	// RVA: 0x26BA090 Offset: 0x26BA191 VA: 0x26BA090 Slot: 5
	public virtual bool IsEmpty(bool includeRoot) { }

	// RVA: 0x26BA4B0 Offset: 0x26BA5B1 VA: 0x26BA4B0 Slot: 6
	public virtual bool Contains(Transform t, bool ignoreRoot = False) { }

	// RVA: 0x26BA8E0 Offset: 0x26BA9E1 VA: 0x26BA8E0
	public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB0D0 Offset: 0x26BB1D1 VA: 0x26BB0D0
	public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BABD0 Offset: 0x26BACD1 VA: 0x26BABD0
	public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB990 Offset: 0x26BBA91 VA: 0x26BB990
	public static bool SetupError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BBA90 Offset: 0x26BBB91 VA: 0x26BBA90
	public static bool SetupWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BC0B0 Offset: 0x26BC1B1 VA: 0x26BC0B0
	private static bool IsNeckBone(Transform bone, Transform leftUpperArm) { }

	// RVA: 0x26BBE90 Offset: 0x26BBF91 VA: 0x26BBE90
	private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBD00 Offset: 0x26BBE01 VA: 0x26BBD00
	private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBB30 Offset: 0x26BBC31 VA: 0x26BBB30
	private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) { }

	// RVA: 0x26BBFA0 Offset: 0x26BC0A1 VA: 0x26BBFA0
	private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) { }

	// RVA: 0x26BC1B0 Offset: 0x26BC2B1 VA: 0x26BC1B0
	private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) { }

	// RVA: 0x26BCD30 Offset: 0x26BCE31 VA: 0x26BCD30
	private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) { }

	// RVA: 0x26BC800 Offset: 0x26BC901 VA: 0x26BC800
	private static bool SpineError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0A0 Offset: 0x26BD1A1 VA: 0x26BD0A0
	private static bool SpineWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BCB50 Offset: 0x26BCC51 VA: 0x26BCB50
	private static bool EyesError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0B0 Offset: 0x26BD1B1 VA: 0x26BD0B0
	private static bool EyesWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD0C0 Offset: 0x26BD1C1 VA: 0x26BD0C0
	private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD290 Offset: 0x26BD391 VA: 0x26BD290
	private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD4C0 Offset: 0x26BD5C1 VA: 0x26BD4C0
	private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) { }

	// RVA: 0x26BAB40 Offset: 0x26BAC41 VA: 0x26BAB40
	public void .ctor() { }
}

[Serializable]
public class BipedReferences // TypeDefIndex: 9313
{
	// Fields
	public Transform root; // 0x10
	public Transform pelvis; // 0x18
	public Transform leftThigh; // 0x20
	public Transform leftCalf; // 0x28
	public Transform leftFoot; // 0x30
	public Transform rightThigh; // 0x38
	public Transform rightCalf; // 0x40
	public Transform rightFoot; // 0x48
	public Transform leftUpperArm; // 0x50
	public Transform leftForearm; // 0x58
	public Transform leftHand; // 0x60
	public Transform rightUpperArm; // 0x68
	public Transform rightForearm; // 0x70
	public Transform rightHand; // 0x78
	public Transform head; // 0x80
	public Transform[] spine; // 0x88
	public Transform[] eyes; // 0x90

	// Properties
	public virtual bool isFilled { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x26B9CA0 Offset: 0x26B9DA1 VA: 0x26B9CA0 Slot: 4
	public virtual bool get_isFilled() { }

	// RVA: 0x26BA080 Offset: 0x26BA181 VA: 0x26BA080
	public bool get_isEmpty() { }

	// RVA: 0x26BA090 Offset: 0x26BA191 VA: 0x26BA090 Slot: 5
	public virtual bool IsEmpty(bool includeRoot) { }

	// RVA: 0x26BA4B0 Offset: 0x26BA5B1 VA: 0x26BA4B0 Slot: 6
	public virtual bool Contains(Transform t, bool ignoreRoot = False) { }

	// RVA: 0x26BA8E0 Offset: 0x26BA9E1 VA: 0x26BA8E0
	public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB0D0 Offset: 0x26BB1D1 VA: 0x26BB0D0
	public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BABD0 Offset: 0x26BACD1 VA: 0x26BABD0
	public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BB990 Offset: 0x26BBA91 VA: 0x26BB990
	public static bool SetupError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BBA90 Offset: 0x26BBB91 VA: 0x26BBA90
	public static bool SetupWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BC0B0 Offset: 0x26BC1B1 VA: 0x26BC0B0
	private static bool IsNeckBone(Transform bone, Transform leftUpperArm) { }

	// RVA: 0x26BBE90 Offset: 0x26BBF91 VA: 0x26BBE90
	private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBD00 Offset: 0x26BBE01 VA: 0x26BBD00
	private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x26BBB30 Offset: 0x26BBC31 VA: 0x26BBB30
	private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) { }

	// RVA: 0x26BBFA0 Offset: 0x26BC0A1 VA: 0x26BBFA0
	private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) { }

	// RVA: 0x26BC1B0 Offset: 0x26BC2B1 VA: 0x26BC1B0
	private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) { }

	// RVA: 0x26BCD30 Offset: 0x26BCE31 VA: 0x26BCD30
	private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) { }

	// RVA: 0x26BC800 Offset: 0x26BC901 VA: 0x26BC800
	private static bool SpineError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0A0 Offset: 0x26BD1A1 VA: 0x26BD0A0
	private static bool SpineWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BCB50 Offset: 0x26BCC51 VA: 0x26BCB50
	private static bool EyesError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x26BD0B0 Offset: 0x26BD1B1 VA: 0x26BD0B0
	private static bool EyesWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD0C0 Offset: 0x26BD1C1 VA: 0x26BD0C0
	private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD290 Offset: 0x26BD391 VA: 0x26BD290
	private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x26BD4C0 Offset: 0x26BD5C1 VA: 0x26BD4C0
	private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) { }

	// RVA: 0x26BAB40 Offset: 0x26BAC41 VA: 0x26BAB40
	public void .ctor() { }
}

