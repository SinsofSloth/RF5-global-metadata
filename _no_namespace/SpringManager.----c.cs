[CompilerGeneratedAttribute] // RVA: 0x159B20 Offset: 0x159C21 VA: 0x159B20
[Serializable]
private sealed class SpringManager.<>c // TypeDefIndex: 9171
{
	// Fields
	public static readonly SpringManager.<>c <>9; // 0x0
	public static Func<SpringSphereCollider, bool> <>9__15_0; // 0x8
	public static Func<SpringCapsuleCollider, bool> <>9__15_1; // 0x10
	public static Func<SpringPanelCollider, bool> <>9__15_2; // 0x18
	public static Func<SpringBone, <>f__AnonymousType0<SpringBone, int>> <>9__16_0; // 0x20
	public static Comparison<<>f__AnonymousType0<SpringBone, int>> <>9__16_1; // 0x28
	public static Func<<>f__AnonymousType0<SpringBone, int>, SpringBone> <>9__16_2; // 0x30

	// Methods

	// RVA: 0x23A2310 Offset: 0x23A2411 VA: 0x23A2310
	private static void .cctor() { }

	// RVA: 0x23A2380 Offset: 0x23A2481 VA: 0x23A2380
	public void .ctor() { }

	// RVA: 0x23A2390 Offset: 0x23A2491 VA: 0x23A2390
	internal bool <CleanUpBoneColliders>b__15_0(SpringSphereCollider collider) { }

	// RVA: 0x23A2400 Offset: 0x23A2501 VA: 0x23A2400
	internal bool <CleanUpBoneColliders>b__15_1(SpringCapsuleCollider collider) { }

	// RVA: 0x23A2470 Offset: 0x23A2571 VA: 0x23A2470
	internal bool <CleanUpBoneColliders>b__15_2(SpringPanelCollider collider) { }

	// RVA: 0x23A24E0 Offset: 0x23A25E1 VA: 0x23A24E0
	internal <>f__AnonymousType0<SpringBone, int> <FindSpringBones>b__16_0(SpringBone bone) { }

	// RVA: 0x23A2600 Offset: 0x23A2701 VA: 0x23A2600
	internal int <FindSpringBones>b__16_1(<>f__AnonymousType0<SpringBone, int> a, <>f__AnonymousType0<SpringBone, int> b) { }

	// RVA: 0x23A2680 Offset: 0x23A2781 VA: 0x23A2680
	internal SpringBone <FindSpringBones>b__16_2(<>f__AnonymousType0<SpringBone, int> item) { }
}

