[FlagsAttribute] // RVA: 0xE0F20 Offset: 0xE1021 VA: 0xE0F20
public enum MeshColliderCookingOptions // TypeDefIndex: 3416
{
	// Fields
	public int value__; // 0x0
	public const MeshColliderCookingOptions None = 0;
	[ObsoleteAttribute] // RVA: 0xE1570 Offset: 0xE1671 VA: 0xE1570
	public const MeshColliderCookingOptions InflateConvexMesh = 1;
	public const MeshColliderCookingOptions CookForFasterSimulation = 2;
	public const MeshColliderCookingOptions EnableMeshCleaning = 4;
	public const MeshColliderCookingOptions WeldColocatedVertices = 8;
	public const MeshColliderCookingOptions UseFastMidphase = 16;
}

