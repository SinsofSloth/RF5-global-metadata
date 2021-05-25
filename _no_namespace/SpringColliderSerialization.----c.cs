[CompilerGeneratedAttribute] // RVA: 0x159AC0 Offset: 0x159BC1 VA: 0x159AC0
[Serializable]
private sealed class SpringColliderSerialization.<>c // TypeDefIndex: 9158
{
	// Fields
	public static readonly SpringColliderSerialization.<>c <>9; // 0x0
	public static Func<SpringSphereCollider, SpringColliderSerialization.SphereColliderSerializer> <>9__1_0; // 0x8
	public static Func<SpringCapsuleCollider, SpringColliderSerialization.CapsuleColliderSerializer> <>9__1_1; // 0x10
	public static Func<SpringPanelCollider, SpringColliderSerialization.PanelColliderSerializer> <>9__1_2; // 0x18
	public static Func<DynamicsNull, SpringColliderSerialization.TransformSerializer> <>9__8_0; // 0x20

	// Methods

	// RVA: 0x239F6F0 Offset: 0x239F7F1 VA: 0x239F6F0
	private static void .cctor() { }

	// RVA: 0x239F760 Offset: 0x239F861 VA: 0x239F760
	public void .ctor() { }

	// RVA: 0x239F770 Offset: 0x239F871 VA: 0x239F770
	internal SpringColliderSerialization.SphereColliderSerializer <AppendColliders>b__1_0(SpringSphereCollider item) { }

	// RVA: 0x239F780 Offset: 0x239F881 VA: 0x239F780
	internal SpringColliderSerialization.CapsuleColliderSerializer <AppendColliders>b__1_1(SpringCapsuleCollider item) { }

	// RVA: 0x239F790 Offset: 0x239F891 VA: 0x239F790
	internal SpringColliderSerialization.PanelColliderSerializer <AppendColliders>b__1_2(SpringPanelCollider item) { }

	// RVA: 0x239F7A0 Offset: 0x239F8A1 VA: 0x239F7A0
	internal SpringColliderSerialization.TransformSerializer <AppendDynamicsNulls>b__8_0(DynamicsNull item) { }
}

