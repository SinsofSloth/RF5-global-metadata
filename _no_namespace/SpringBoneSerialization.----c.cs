[CompilerGeneratedAttribute] // RVA: 0x159A60 Offset: 0x159B61 VA: 0x159A60
[Serializable]
private sealed class SpringBoneSerialization.<>c // TypeDefIndex: 9142
{
	// Fields
	public static readonly SpringBoneSerialization.<>c <>9; // 0x0
	public static Func<Transform, bool> <>9__3_0; // 0x8
	public static Func<Transform, SpringBoneSerialization.LengthLimitSerializer> <>9__3_1; // 0x10
	public static Func<SpringSphereCollider, bool> <>9__5_0; // 0x18
	public static Func<SpringSphereCollider, string> <>9__5_1; // 0x20
	public static Func<SpringCapsuleCollider, bool> <>9__5_2; // 0x28
	public static Func<SpringCapsuleCollider, string> <>9__5_3; // 0x30
	public static Func<SpringPanelCollider, bool> <>9__5_4; // 0x38
	public static Func<SpringPanelCollider, string> <>9__5_5; // 0x40
	public static Func<SpringBone, bool> <>9__6_0; // 0x48
	public static Func<SpringBone, Transform> <>9__6_1; // 0x50
	public static Func<Transform, SpringBoneSerialization.PivotSerializer> <>9__6_2; // 0x58
	public static Func<string, bool> <>9__17_0; // 0x60

	// Methods

	// RVA: 0x20084A0 Offset: 0x20085A1 VA: 0x20084A0
	private static void .cctor() { }

	// RVA: 0x2008510 Offset: 0x2008611 VA: 0x2008510
	public void .ctor() { }

	// RVA: 0x2008520 Offset: 0x2008621 VA: 0x2008520
	internal bool <SpringBoneToBaseSerializer>b__3_0(Transform item) { }

	// RVA: 0x2008590 Offset: 0x2008691 VA: 0x2008590
	internal SpringBoneSerialization.LengthLimitSerializer <SpringBoneToBaseSerializer>b__3_1(Transform item) { }

	// RVA: 0x2008640 Offset: 0x2008741 VA: 0x2008640
	internal bool <AppendSpringBones>b__5_0(SpringSphereCollider item) { }

	// RVA: 0x20086B0 Offset: 0x20087B1 VA: 0x20086B0
	internal string <AppendSpringBones>b__5_1(SpringSphereCollider item) { }

	// RVA: 0x20086D0 Offset: 0x20087D1 VA: 0x20086D0
	internal bool <AppendSpringBones>b__5_2(SpringCapsuleCollider item) { }

	// RVA: 0x2008740 Offset: 0x2008841 VA: 0x2008740
	internal string <AppendSpringBones>b__5_3(SpringCapsuleCollider item) { }

	// RVA: 0x2008760 Offset: 0x2008861 VA: 0x2008760
	internal bool <AppendSpringBones>b__5_4(SpringPanelCollider item) { }

	// RVA: 0x20087D0 Offset: 0x20088D1 VA: 0x20087D0
	internal string <AppendSpringBones>b__5_5(SpringPanelCollider item) { }

	// RVA: 0x20087F0 Offset: 0x20088F1 VA: 0x20087F0
	internal bool <AppendPivots>b__6_0(SpringBone bone) { }

	// RVA: 0x2008910 Offset: 0x2008A11 VA: 0x2008910
	internal Transform <AppendPivots>b__6_1(SpringBone bone) { }

	// RVA: 0x2008930 Offset: 0x2008A31 VA: 0x2008930
	internal SpringBoneSerialization.PivotSerializer <AppendPivots>b__6_2(Transform pivot) { }

	// RVA: 0x2008940 Offset: 0x2008A41 VA: 0x2008940
	internal bool <SerializeSpringBoneRecords>b__17_0(string item) { }
}

