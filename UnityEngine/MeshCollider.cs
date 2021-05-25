[NativeHeaderAttribute] // RVA: 0xE11A0 Offset: 0xE12A1 VA: 0xE11A0
[NativeHeaderAttribute] // RVA: 0xE11A0 Offset: 0xE12A1 VA: 0xE11A0
[RequiredByNativeCodeAttribute] // RVA: 0xE11A0 Offset: 0xE12A1 VA: 0xE11A0
public class MeshCollider : Collider // TypeDefIndex: 3432
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public bool convex { get; set; }
	[ObsoleteAttribute] // RVA: 0xE4670 Offset: 0xE4771 VA: 0xE4670
	public bool inflateMesh { get; set; }
	public MeshColliderCookingOptions cookingOptions { get; set; }
	[ObsoleteAttribute] // RVA: 0xE46B0 Offset: 0xE47B1 VA: 0xE46B0
	public float skinWidth { get; set; }
	[ObsoleteAttribute] // RVA: 0xE46F0 Offset: 0xE47F1 VA: 0xE46F0
	public bool smoothSphereCollisions { get; set; }

	// Methods

	// RVA: 0x350CD70 Offset: 0x350CE71 VA: 0x350CD70
	public Mesh get_sharedMesh() { }

	// RVA: 0x350CDC0 Offset: 0x350CEC1 VA: 0x350CDC0
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x350CE10 Offset: 0x350CF11 VA: 0x350CE10
	public bool get_convex() { }

	// RVA: 0x350CE60 Offset: 0x350CF61 VA: 0x350CE60
	public void set_convex(bool value) { }

	// RVA: 0x350CEB0 Offset: 0x350CFB1 VA: 0x350CEB0
	public bool get_inflateMesh() { }

	// RVA: 0x350CEC0 Offset: 0x350CFC1 VA: 0x350CEC0
	public void set_inflateMesh(bool value) { }

	// RVA: 0x350CED0 Offset: 0x350CFD1 VA: 0x350CED0
	public MeshColliderCookingOptions get_cookingOptions() { }

	// RVA: 0x350CF20 Offset: 0x350D021 VA: 0x350CF20
	public void set_cookingOptions(MeshColliderCookingOptions value) { }

	// RVA: 0x350CF70 Offset: 0x350D071 VA: 0x350CF70
	public float get_skinWidth() { }

	// RVA: 0x350CF80 Offset: 0x350D081 VA: 0x350CF80
	public void set_skinWidth(float value) { }

	// RVA: 0x350CF90 Offset: 0x350D091 VA: 0x350CF90
	public bool get_smoothSphereCollisions() { }

	// RVA: 0x350CFA0 Offset: 0x350D0A1 VA: 0x350CFA0
	public void set_smoothSphereCollisions(bool value) { }

	// RVA: 0x350CFB0 Offset: 0x350D0B1 VA: 0x350CFB0
	public void .ctor() { }
}

