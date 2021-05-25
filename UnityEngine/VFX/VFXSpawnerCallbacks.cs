[RequiredByNativeCodeAttribute] // RVA: 0x1226E0 Offset: 0x1227E1 VA: 0x1226E0
[Serializable]
public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 4261
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	// RVA: 0x1BE1A70 Offset: 0x1BE1B71 VA: 0x1BE1A70
	protected void .ctor() { }
}

