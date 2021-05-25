public abstract class BaseSpriteInstancedRenderer : MonoBehaviour // TypeDefIndex: 9691
{
	// Fields
	public const int kArrayMaxSprites = 1000;
	[CompilerGeneratedAttribute] // RVA: 0x17EAD0 Offset: 0x17EBD1 VA: 0x17EAD0
	private int <maxSprites>k__BackingField; // 0x18
	[TooltipAttribute] // RVA: 0x17EAE0 Offset: 0x17EBE1 VA: 0x17EAE0
	public Mesh modelMesh; // 0x20
	[TooltipAttribute] // RVA: 0x17EB20 Offset: 0x17EC21 VA: 0x17EB20
	public Material renderMaterial; // 0x28
	protected Queue<BaseSpriteItemData> m_Available; // 0x30
	protected HashSet<BaseSpriteItemData> m_Active; // 0x38
	private MaterialPropertyBlock m_PropertyBlock; // 0x40
	private Matrix4x4[] m_ModelMatrices; // 0x48
	private float[] m_StartTimes; // 0x50
	private float[] m_EndTimes; // 0x58
	protected SpriteSheetData m_SpriteSheetLayout; // 0x60
	protected Texture m_SpriteTexture; // 0x68
	protected Color m_TintColor; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x17EB60 Offset: 0x17EC61 VA: 0x17EB60
	private Camera <m_ViewerCamera>k__BackingField; // 0x80

	// Properties
	public int maxSprites { get; set; }
	protected Camera m_ViewerCamera { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AC650 Offset: 0x1AC751 VA: 0x1AC650
	// RVA: 0x22AF410 Offset: 0x22AF511 VA: 0x22AF410
	public int get_maxSprites() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC660 Offset: 0x1AC761 VA: 0x1AC660
	// RVA: 0x22AF420 Offset: 0x22AF521 VA: 0x22AF420
	protected void set_maxSprites(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC670 Offset: 0x1AC771 VA: 0x1AC670
	// RVA: 0x22AF430 Offset: 0x22AF531 VA: 0x22AF430
	protected Camera get_m_ViewerCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC680 Offset: 0x1AC781 VA: 0x1AC680
	// RVA: 0x22AF440 Offset: 0x22AF541 VA: 0x22AF440
	protected void set_m_ViewerCamera(Camera value) { }

	// RVA: 0x22AF450 Offset: 0x22AF551 VA: 0x22AF450
	private void Start() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Bounds CalculateMeshBounds() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract BaseSpriteItemData CreateSpriteItemData() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract bool IsRenderingEnabled() { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract int GetNextSpawnCount() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void ConfigureSpriteItemData(BaseSpriteItemData data) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x22AF500 Offset: 0x22AF601 VA: 0x22AF500
	private BaseSpriteItemData DequeueNextSpriteItemData() { }

	// RVA: 0x22AF5B0 Offset: 0x22AF6B1 VA: 0x22AF5B0
	private void ReturnSpriteItemData(BaseSpriteItemData splash) { }

	// RVA: 0x22AF670 Offset: 0x22AF771 VA: 0x22AF670 Slot: 12
	protected virtual void LateUpdate() { }

	// RVA: 0x22AF6E0 Offset: 0x22AF7E1 VA: 0x22AF6E0
	private void GenerateNewSprites() { }

	// RVA: 0x22AF970 Offset: 0x22AFA71 VA: 0x22AF970
	private void AdvanceAllSprites() { }

	// RVA: 0x22AFB00 Offset: 0x22AFC01 VA: 0x22AFB00
	private void RenderAllSprites() { }

	// RVA: 0x22B0340 Offset: 0x22B0441 VA: 0x22B0340 Slot: 13
	protected virtual Mesh GenerateMesh() { }

	// RVA: 0x22B06F0 Offset: 0x22B07F1 VA: 0x22B06F0
	protected void .ctor() { }
}

