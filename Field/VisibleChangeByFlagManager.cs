public class VisibleChangeByFlagManager : SingletonMonoBehaviour<VisibleChangeByFlagManager> // TypeDefIndex: 10476
{
	// Fields
	private HashSet<VisibleChangeByFlag> VisibleChangeByFlagHashSet; // 0x18
	private HashSet<TextureChangeByFlag> TextureChangeByFlagHashSet; // 0x20

	// Methods

	// RVA: 0x1EF1AB0 Offset: 0x1EF1BB1 VA: 0x1EF1AB0
	private void Start() { }

	// RVA: 0x1EF1BB0 Offset: 0x1EF1CB1 VA: 0x1EF1BB0
	public void UpdateObjectVisible() { }

	// RVA: 0x1EF1060 Offset: 0x1EF1161 VA: 0x1EF1060
	public void Add(VisibleChangeByFlag visibleChangeByFlag) { }

	// RVA: 0x1EF0E50 Offset: 0x1EF0F51 VA: 0x1EF0E50
	public void Remove(VisibleChangeByFlag visibleChangeByFlag) { }

	// RVA: 0x1EEFC20 Offset: 0x1EEFD21 VA: 0x1EEFC20
	public void Add(TextureChangeByFlag textureChangeByFlag) { }

	// RVA: 0x1EEFAB0 Offset: 0x1EEFBB1 VA: 0x1EEFAB0
	public void Remove(TextureChangeByFlag textureChangeByFlag) { }

	// RVA: 0x1EF1E30 Offset: 0x1EF1F31 VA: 0x1EF1E30
	private void OnSceneChangeObjectVisible() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF710 Offset: 0x1AF811 VA: 0x1AF710
	// RVA: 0x1EF1E40 Offset: 0x1EF1F41 VA: 0x1EF1E40
	private IEnumerator OnSceneChangeLoad() { }

	// RVA: 0x1EF1EF0 Offset: 0x1EF1FF1 VA: 0x1EF1EF0
	public void AfterLoadGameData() { }

	// RVA: 0x1EF20C0 Offset: 0x1EF21C1 VA: 0x1EF20C0
	public void .ctor() { }
}

