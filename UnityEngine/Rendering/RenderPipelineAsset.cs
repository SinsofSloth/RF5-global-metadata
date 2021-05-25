public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 3327
{
	// Properties
	public virtual string[] renderingLayerMaskNames { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }

	// Methods

	// RVA: 0x2A1FF90 Offset: 0x2A20091 VA: 0x2A1FF90
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x2A20280 Offset: 0x2A20381 VA: 0x2A20280 Slot: 4
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x2A20290 Offset: 0x2A20391 VA: 0x2A20290 Slot: 5
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x2A202A0 Offset: 0x2A203A1 VA: 0x2A202A0 Slot: 6
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x2A202B0 Offset: 0x2A203B1 VA: 0x2A202B0 Slot: 7
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x2A202C0 Offset: 0x2A203C1 VA: 0x2A202C0 Slot: 8
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x2A202D0 Offset: 0x2A203D1 VA: 0x2A202D0 Slot: 9
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x2A202E0 Offset: 0x2A203E1 VA: 0x2A202E0 Slot: 10
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x2A202F0 Offset: 0x2A203F1 VA: 0x2A202F0 Slot: 11
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x2A20300 Offset: 0x2A20401 VA: 0x2A20300 Slot: 12
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x2A20310 Offset: 0x2A20411 VA: 0x2A20310 Slot: 13
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x2A20320 Offset: 0x2A20421 VA: 0x2A20320 Slot: 14
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x2A20330 Offset: 0x2A20431 VA: 0x2A20330 Slot: 15
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x2A20340 Offset: 0x2A20441 VA: 0x2A20340 Slot: 16
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x2A20350 Offset: 0x2A20451 VA: 0x2A20350 Slot: 17
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x2A20360 Offset: 0x2A20461 VA: 0x2A20360 Slot: 18
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x2A20370 Offset: 0x2A20471 VA: 0x2A20370 Slot: 19
	public virtual Shader get_defaultShader() { }

	// RVA: 0x2A20380 Offset: 0x2A20481 VA: 0x2A20380 Slot: 20
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x2A20390 Offset: 0x2A20491 VA: 0x2A20390 Slot: 21
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract RenderPipeline CreatePipeline() { }

	// RVA: 0x2A203A0 Offset: 0x2A204A1 VA: 0x2A203A0 Slot: 23
	protected virtual void OnValidate() { }

	// RVA: 0x2A20A80 Offset: 0x2A20B81 VA: 0x2A20A80 Slot: 24
	protected virtual void OnDisable() { }

	// RVA: 0x2A20AF0 Offset: 0x2A20BF1 VA: 0x2A20AF0
	protected void .ctor() { }
}

