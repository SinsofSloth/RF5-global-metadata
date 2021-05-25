[FlagsAttribute] // RVA: 0xC8560 Offset: 0xC8661 VA: 0xC8560
public enum MeshUpdateFlags // TypeDefIndex: 3271
{
	// Fields
	public int value__; // 0x0
	public const MeshUpdateFlags Default = 0;
	public const MeshUpdateFlags DontValidateIndices = 1;
	public const MeshUpdateFlags DontResetBoneBounds = 2;
	public const MeshUpdateFlags DontNotifyMeshUsers = 4;
	public const MeshUpdateFlags DontRecalculateBounds = 8;
}

